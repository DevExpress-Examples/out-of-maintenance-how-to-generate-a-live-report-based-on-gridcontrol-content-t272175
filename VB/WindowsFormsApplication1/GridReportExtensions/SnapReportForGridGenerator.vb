Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.Snap.Core.Fields
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraRichEdit.API.Native

Namespace WindowsFormsApplication1.GridReportExtensions
	Public Module SnapReportContentGenerator
        Private ReadOnly formatFinder As New Regex("(?:^|[^\{])(\{0(?:(?:,\d+)?(?::([\d]*[\w]?))?)?\})")

        <System.Runtime.CompilerServices.Extension> _
        Public Sub ShowSnapReportPreviewForm(ByVal currentGridControl As GridControl)
            Dim SnapReportForm As RibbonForm
            Dim SnapReport As SnapControl
            Using dlg As New WaitDialogForm("Please wait", "Document processing...")
                SnapReport = New SnapControl()
                SnapReport.Tag = currentGridControl.DataSource

                SnapReportForm = SnapReport.CreateReportPreviewForm()

                AddHandler SnapReport.DocumentLoaded, AddressOf SnapReport_DocumentLoaded
                SnapReport.CreateNewDocument()

                AssignDataSourceToSnapControl(SnapReport)
                Dim document As SnapDocument = SnapReport.Document
                document.BeginUpdate()
                GenerateSnapReportForGridControlContent(currentGridControl.LevelTree, document)
                document.Fields.Update()
                document.EndUpdate()
            End Using
            SnapReportForm.ShowDialog(currentGridControl.FindForm())
        End Sub

        Private Sub SnapReport_DocumentLoaded(ByVal sender As Object, ByVal e As DocumentImportedEventArgs)
            AssignDataSourceToSnapControl(TryCast(sender, SnapControl))
        End Sub

        Private Sub AssignDataSourceToSnapControl(ByVal snap As SnapControl)
            snap.DataSource = snap.Tag
        End Sub

        Private Sub GenerateSnapReportForGridControlContent(ByVal node As GridLevelNode, ByVal document As SnapDocument)
            GenerateSnapListForCurrentLevel(node, document, document.Range.End, 1)
        End Sub

        Private Sub GenerateSnapListForCurrentLevel(ByVal node As GridLevelNode, ByVal document As SnapDocument, ByVal position As DocumentPosition, ByVal level As Integer)
            Dim grid As GridView = TryCast(node.LevelTemplate, GridView)
            If grid Is Nothing OrElse grid.VisibleColumns.Count = 0 Then
                Return
            End If

            Dim list As SnapList = document.CreateSnList(document.Range.End, grid.Name)
            list.BeginUpdate()

            ApplyDataSource(list, node)
            ApplyGroups(list, grid)
            ApplySorting(list, grid)
            ApplyFilter(list, grid)
            Dim table As Table = Nothing
            Dim template As SnapDocument = Nothing
            MakeTemplate(list, grid, table, template)
            MakeReportFooter(list, grid)
            ApplyDetails(node, table, template, level)

            list.ApplyTableStyles(level)
            list.EndUpdate()
        End Sub

        Private Sub ApplyDataSource(ByVal list As SnapList, ByVal node As GridLevelNode)
            If (Not node.IsRootLevel) Then
                list.DataMember = node.RelationName
            End If
        End Sub

        Private Sub ApplySorting(ByVal list As SnapList, ByVal grid As GridView)
            For Each col As GridColumn In grid.SortedColumns
                list.Sorting.Add(New SnapListGroupParam(col.FieldName, col.SortOrder))
            Next col
        End Sub

        Private Sub ApplyDetails(ByVal node As GridLevelNode, ByVal table As Table, ByVal template As SnapDocument, ByVal level As Integer)
            If node.HasChildren Then
                For Each child As GridLevelNode In node.Nodes
                    Dim detail As TableRow = table.Rows.Append()
                    table.MergeCells(detail.FirstCell, detail.LastCell)
                    GenerateSnapListForCurrentLevel(child, template, detail.Range.Start, level + 1)
                Next child
            End If
        End Sub

        Private Sub ApplyFilter(ByVal list As SnapList, ByVal grid As GridView)
            Dim filter As String = grid.ActiveFilterString
            If (Not String.IsNullOrEmpty(filter)) Then
                list.Filters.Add(filter)
            End If
        End Sub

        Private Sub ApplyGroups(ByVal list As SnapList, ByVal grid As GridView)
            For Each col As GridColumn In grid.GroupedColumns
                Dim group As SnapListGroupInfo = list.Groups.CreateSnapListGroupInfo(New SnapListGroupParam(col.FieldName, col.SortOrder))
                Dim groupHeader As SnapDocument = group.CreateHeader()
                Dim box As Table = groupHeader.Tables.Create(groupHeader.Range.End, 1, 1)
                AdjustSize(box)
                groupHeader.CreateSnText(box.Cell(0, 0).Range.Start, col.FieldName)
                groupHeader.InsertText(box.Cell(0, 0).Range.Start, String.Format("{0}: ", col.FieldName))
                ApplySummary(group, grid)
                list.Groups.Add(group)
            Next col
        End Sub

        Private Sub ApplySummary(ByVal group As SnapListGroupInfo, ByVal grid As GridView)
            For Each item As GridSummaryItem In grid.GroupSummary
                Dim summary As GridGroupSummaryItem = TryCast(item, GridGroupSummaryItem)
                If summary IsNot Nothing Then
                    If summary.ShowInGroupColumnFooter Is Nothing Then
                        BuildSummaryTemplate(group.Header, group.Header.Tables(0).Cell(0, 0), summary, SummaryRunning.Group)
                    Else
                        Dim col As Integer = grid.VisibleColumns.IndexOf(summary.ShowInGroupColumnFooter)
                        If col < 0 Then
                            Continue For
                        End If
                        Dim footer As SnapDocument = group.Footer
                        If footer Is Nothing Then
                            footer = group.CreateFooter()
                        End If
                        If footer.Tables.Count = 0 OrElse footer.Tables(0).Rows.Count = 0 OrElse footer.Tables(0).Rows(0).Cells.Count <> grid.VisibleColumns.Count Then
                            Dim table As Table = footer.Tables.Create(footer.Range.Start, 1, grid.VisibleColumns.Count)
                            AdjustSize(table)
                        End If
                        BuildSummaryTemplate(footer, footer.Tables(0).Cell(0, col), summary, SummaryRunning.Group)
                    End If
                End If
            Next item
        End Sub

        Private Sub AdjustSize(ByVal table As Table)
            table.SetPreferredWidth(50 * 100, WidthType.FiftiethsOfPercent)
            table.TableLayout = TableLayoutType.Fixed
            table.ForEachCell(AddressOf AssignPreferredWidth)
        End Sub

        Private Sub AssignPreferredWidth(ByVal cell As TableCell, ByVal rowIndex As Integer, ByVal cellIndex As Integer)
            cell.PreferredWidthType = WidthType.FiftiethsOfPercent
            cell.PreferredWidth = CSng(50.0 * 100.0 / cell.Row.Cells.Count)
        End Sub

        Private Sub BuildSummaryTemplate(ByVal template As SnapDocument, ByVal box As TableCell, ByVal source As GridSummaryItem, ByVal running As SummaryRunning)
            Dim formatFields As MatchCollection = formatFinder.Matches(source.DisplayFormat)
            Dim k As Integer = 0
            template.InsertText(box.ContentRange.End, " ")
            For Each match As System.Text.RegularExpressions.Match In formatFields
                template.InsertText(box.ContentRange.End, source.DisplayFormat.Substring(k, match.Groups(1).Index - k))
                k = match.Groups(1).Index + match.Groups(1).Length
                Dim snText As SnapText = template.CreateSnText(box.ContentRange.End, source.FieldName)
                snText.BeginUpdate()
                snText.SummaryRunning = running
                snText.SummaryFunc = source.SummaryType
                Dim format As String = match.Groups(2).Value
                If (Not String.IsNullOrEmpty(format)) Then
                    If format.EndsWith("C", StringComparison.InvariantCultureIgnoreCase) Then
                        snText.FormatString = "$0.00"
                    End If
                End If
                snText.EndUpdate()
            Next match
            template.InsertText(box.ContentRange.End, source.DisplayFormat.Substring(k))
        End Sub

        Private Function GetColType(ByVal gridCol As GridColumn) As Type
            Return gridCol.ColumnType
        End Function


        Private Sub MakeTemplate(ByVal list As SnapList, ByVal grid As GridView, <System.Runtime.InteropServices.Out()> ByRef table As Table, <System.Runtime.InteropServices.Out()> ByRef template As SnapDocument)
            template = list.RowTemplate
            Dim header As SnapDocument = list.ListHeader

            table = template.Tables.Create(template.Range.End, 1, grid.VisibleColumns.Count)
            Dim caption As Table = header.Tables.Create(header.Range.End, 1, grid.VisibleColumns.Count)
            AdjustSize(table)
            AdjustSize(caption)

            For Each col As GridColumn In grid.VisibleColumns
                header.InsertText(caption.Cell(0, col.VisibleIndex).Range.Start, col.FieldName)
                Dim cell As TableCell = table.Cell(0, col.VisibleIndex)

                Dim pos As DocumentPosition = cell.Range.Start
                Dim colType As Type = GetColType(col)
                If colType Is GetType(Byte()) Then
                    template.CreateSnImage(pos, col.FieldName)
                ElseIf colType Is GetType(Boolean) Then
                    template.CreateSnCheckBox(pos, col.FieldName)
                Else
                    template.CreateSnText(pos, col.FieldName)
                End If
            Next col
        End Sub

        Private Sub MakeReportFooter(ByVal list As SnapList, ByVal grid As GridView)
            Dim tmp = New Dictionary(Of Integer, List(Of GridColumnSummaryItem))()
            For Each column As GridColumn In grid.VisibleColumns
                Dim colNum As Integer = column.VisibleIndex
                For Each item As GridColumnSummaryItem In column.Summary
                    If (Not tmp.ContainsKey(colNum)) Then
                        tmp(colNum) = New List(Of GridColumnSummaryItem)(1)
                    End If
                    tmp(colNum).Add(item)
                Next item
            Next column
            If tmp.Count = 0 Then
                Return
            End If
            Dim footer As SnapDocument = list.ListFooter
            Dim table As Table = footer.Tables.Create(footer.Range.Start, tmp.Values.Max(Function(o) o.Count), grid.VisibleColumns.Count)
            AdjustSize(table)
            For Each rec As KeyValuePair(Of Integer, List(Of GridColumnSummaryItem)) In tmp
                Dim colNum As Integer = rec.Key
                Dim rowNum As Integer = 0
                For Each summary As GridColumnSummaryItem In rec.Value
                    BuildSummaryTemplate(footer, table.Cell(rowNum, colNum), summary, SummaryRunning.Report)
                    rowNum += 1
                Next summary
            Next rec
        End Sub
	End Module
End Namespace
