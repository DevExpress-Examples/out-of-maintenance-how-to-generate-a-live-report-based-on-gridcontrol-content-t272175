using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.Snap.Core.Fields;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.API.Native;

namespace WindowsFormsApplication1.GridReportExtensions {
    public static class SnapReportContentGenerator {
        static readonly Regex formatFinder = new Regex(@"(?:^|[^\{])(\{0(?:(?:,\d+)?(?::([\d]*[\w]?))?)?\})");

        public static void ShowSnapReportPreviewForm(this GridControl currentGridControl) {
            RibbonForm SnapReportForm;
            SnapControl SnapReport;
            using(WaitDialogForm dlg = new WaitDialogForm("Please wait", "Document processing...")) {
                SnapReport = new SnapControl();
                SnapReport.Tag = currentGridControl.DataSource;

                SnapReportForm = SnapReport.CreateReportPreviewForm();

                SnapReport.DocumentLoaded += SnapReport_DocumentLoaded;
                SnapReport.CreateNewDocument();

                AssignDataSourceToSnapControl(SnapReport);
                SnapDocument document = SnapReport.Document;
                document.BeginUpdate();
                GenerateSnapReportForGridControlContent(currentGridControl.LevelTree, document);
                document.Fields.Update();
                document.EndUpdate();                
            }
            SnapReportForm.ShowDialog(currentGridControl.FindForm());
        }

        static void SnapReport_DocumentLoaded(object sender, DocumentImportedEventArgs e) {
            AssignDataSourceToSnapControl(sender as SnapControl);
        }

        static void AssignDataSourceToSnapControl(SnapControl snap) {
            snap.DataSource = snap.Tag;        
        }

        static void GenerateSnapReportForGridControlContent(GridLevelNode node, SnapDocument document) {
            GenerateSnapListForCurrentLevel(node, document, document.Range.End, 1);
        }

        static void GenerateSnapListForCurrentLevel(GridLevelNode node, SnapDocument document, DocumentPosition position, int level) {
            GridView grid = node.LevelTemplate as GridView;
            if(grid == null || grid.VisibleColumns.Count == 0)
                return;

            SnapList list = document.CreateSnList(document.Range.End, grid.Name);
            list.BeginUpdate();

            ApplyDataSource(list, node);
            ApplyGroups(list, grid);
            ApplySorting(list, grid);
            ApplyFilter(list, grid);
            Table table = null;
            SnapDocument template = null;
            MakeTemplate(list, grid, out table, out template);
            MakeReportFooter(list, grid);
            ApplyDetails(node, table, template, level);

            list.ApplyTableStyles(level);
            list.EndUpdate();
        }

        static void ApplyDataSource(SnapList list, GridLevelNode node) {
            if(!node.IsRootLevel) {
                list.DataMember = node.RelationName;
            }
        }

        static void ApplySorting(SnapList list, GridView grid) {
            foreach(GridColumn col in grid.SortedColumns) {
                list.Sorting.Add(new SnapListGroupParam(col.FieldName, col.SortOrder));
            }
        }

        static void ApplyDetails(GridLevelNode node, Table table, SnapDocument template, int level) {
            if(node.HasChildren)
                foreach(GridLevelNode child in node.Nodes) {
                    TableRow detail = table.Rows.Append();
                    table.MergeCells(detail.FirstCell, detail.LastCell);
                    GenerateSnapListForCurrentLevel(child, template, detail.Range.Start, level + 1);
                }
        }

        static void ApplyFilter(SnapList list, GridView grid) {
            string filter = grid.ActiveFilterString;
            if(!String.IsNullOrEmpty(filter))
                list.Filters.Add(filter);
        }

        static void ApplyGroups(SnapList list, GridView grid) {
            foreach(GridColumn col in grid.GroupedColumns) {
                SnapListGroupInfo group = list.Groups.CreateSnapListGroupInfo(new SnapListGroupParam(col.FieldName, col.SortOrder));
                SnapDocument groupHeader = group.CreateHeader();
                Table box = groupHeader.Tables.Create(groupHeader.Range.End, 1, 1);
                AdjustSize(box);
                groupHeader.CreateSnText(box.Cell(0, 0).Range.Start, col.FieldName);
                groupHeader.InsertText(box.Cell(0, 0).Range.Start, String.Format("{0}: ", col.FieldName));
                ApplySummary(group, grid);
                list.Groups.Add(group);
            }
        }

        static void ApplySummary(SnapListGroupInfo group, GridView grid) {
            foreach(GridSummaryItem item in grid.GroupSummary) {
                GridGroupSummaryItem summary = item as GridGroupSummaryItem;
                if(summary != null) {
                    if(summary.ShowInGroupColumnFooter == null) {
                        BuildSummaryTemplate(group.Header, group.Header.Tables[0].Cell(0, 0), summary, SummaryRunning.Group);
                    }
                    else {
                        int col = grid.VisibleColumns.IndexOf(summary.ShowInGroupColumnFooter);
                        if(col < 0)
                            continue;
                        SnapDocument footer = group.Footer;
                        if(footer == null)
                            footer = group.CreateFooter();
                        if(footer.Tables.Count == 0 || footer.Tables[0].Rows.Count == 0 || footer.Tables[0].Rows[0].Cells.Count != grid.VisibleColumns.Count) {
                            Table table = footer.Tables.Create(footer.Range.Start, 1, grid.VisibleColumns.Count);
                            AdjustSize(table);
                        }
                        BuildSummaryTemplate(footer, footer.Tables[0].Cell(0, col), summary, SummaryRunning.Group);
                    }
                }
            }
        }

        static void AdjustSize(Table table) {
            table.SetPreferredWidth(50 * 100, WidthType.FiftiethsOfPercent);
            table.TableLayout = TableLayoutType.Fixed;
            table.ForEachCell(AssignPreferredWidth);
        }

        static void AssignPreferredWidth(TableCell cell, int rowIndex, int cellIndex) {
            cell.PreferredWidthType = WidthType.FiftiethsOfPercent;
            cell.PreferredWidth = (float)(50.0 * 100.0 / cell.Row.Cells.Count);
        }

        static void BuildSummaryTemplate(SnapDocument template, TableCell box, GridSummaryItem source, SummaryRunning running) {
            MatchCollection formatFields = formatFinder.Matches(source.DisplayFormat);
            int k = 0;
            template.InsertText(box.ContentRange.End, " ");
            foreach(System.Text.RegularExpressions.Match match in formatFields) {
                template.InsertText(box.ContentRange.End, source.DisplayFormat.Substring(k, match.Groups[1].Index - k));
                k = match.Groups[1].Index + match.Groups[1].Length;
                SnapText snText = template.CreateSnText(box.ContentRange.End, source.FieldName);
                snText.BeginUpdate();
                snText.SummaryRunning = running;
                snText.SummaryFunc = source.SummaryType;
                string format = match.Groups[2].Value;
                if(!String.IsNullOrEmpty(format)) {
                    if(format.EndsWith("C", StringComparison.InvariantCultureIgnoreCase))
                        snText.FormatString = @"$0.00";
                }
                snText.EndUpdate();
            }
            template.InsertText(box.ContentRange.End, source.DisplayFormat.Substring(k));
        }

        static Type GetColType(GridColumn gridCol) {                
            return gridCol.ColumnType;
        }


        static void MakeTemplate(SnapList list, GridView grid, out Table table, out SnapDocument template) {
            template = list.RowTemplate;
            SnapDocument header = list.ListHeader;

            table = template.Tables.Create(template.Range.End, 1, grid.VisibleColumns.Count);
            Table caption = header.Tables.Create(header.Range.End, 1, grid.VisibleColumns.Count);
            AdjustSize(table);
            AdjustSize(caption);

            foreach(GridColumn col in grid.VisibleColumns) {
                header.InsertText(caption.Cell(0, col.VisibleIndex).Range.Start, col.FieldName);
                TableCell cell = table.Cell(0, col.VisibleIndex);

                DocumentPosition pos = cell.Range.Start;
                Type colType = GetColType(col);
                if(colType == typeof(byte[]))
                    template.CreateSnImage(pos, col.FieldName);
                else if(colType == typeof(bool))
                    template.CreateSnCheckBox(pos, col.FieldName);
                else
                    template.CreateSnText(pos, col.FieldName);
            }
        }

        static void MakeReportFooter(SnapList list, GridView grid) {
            var tmp = new Dictionary<int, List<GridColumnSummaryItem>>();
            foreach(GridColumn column in grid.VisibleColumns) {
                int colNum = column.VisibleIndex;
                foreach(GridColumnSummaryItem item in column.Summary) {
                    if(!tmp.ContainsKey(colNum))
                        tmp[colNum] = new List<GridColumnSummaryItem>(1);
                    tmp[colNum].Add(item);
                }
            }
            if(tmp.Count == 0)
                return;
            SnapDocument footer = list.ListFooter;
            Table table = footer.Tables.Create(footer.Range.Start, tmp.Values.Max(o => o.Count), grid.VisibleColumns.Count);
            AdjustSize(table);
            foreach(KeyValuePair<int, List<GridColumnSummaryItem>> rec in tmp) {
                int colNum = rec.Key;
                int rowNum = 0;
                foreach(GridColumnSummaryItem summary in rec.Value) {
                    BuildSummaryTemplate(footer, table.Cell(rowNum++, colNum), summary, SummaryRunning.Report);
                }
            }
        }
    }
}
