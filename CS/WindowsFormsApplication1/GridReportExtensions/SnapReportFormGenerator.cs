using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Snap;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid;

namespace WindowsFormsApplication1.GridReportExtensions {
    public static class SnapReportFormGenerator {
        public static RibbonForm CreateReportPreviewForm(this SnapControl snapControl) {
            RibbonForm reportForm = new RibbonForm();

            //create DockManager and Dock Panels
            DevExpress.Snap.Extensions.SnapDockManager dockManager = CreateDefaultSnapFormContent(reportForm, snapControl);

            // create default SnapControl Ribbon Menu
            CreateRibbonMenuWithPredefinedItems(reportForm, snapControl, dockManager);

            return reportForm;        
        }

        static DevExpress.Snap.Extensions.SnapDockManager CreateDefaultSnapFormContent(RibbonForm snapForm, SnapControl snapControl) {
            DevExpress.Snap.Extensions.SnapDockManager snapDockManager = new DevExpress.Snap.Extensions.SnapDockManager();
            DevExpress.Snap.Extensions.UI.FieldListDockPanel fieldListDockPanel = new DevExpress.Snap.Extensions.UI.FieldListDockPanel();
            DevExpress.XtraBars.Docking.ControlContainer fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel reportExplorerDockPanel = new DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel();
            DevExpress.XtraBars.Docking.ControlContainer reportExplorerDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            DevExpress.XtraBars.Docking.DockPanel panelContainer = new DevExpress.XtraBars.Docking.DockPanel();
            DevExpress.Snap.Extensions.SnapDocumentManager snapDocumentManager = new DevExpress.Snap.Extensions.SnapDocumentManager();
            DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView();
            ((System.ComponentModel.ISupportInitialize)(snapDockManager)).BeginInit();
            fieldListDockPanel.SuspendLayout();
            reportExplorerDockPanel.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(snapDocumentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(noDocumentsView)).BeginInit();
            snapForm.SuspendLayout();
            // 
            // snapControl
            // 
            snapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            snapControl.EnableToolTips = true;
            snapControl.Location = new System.Drawing.Point(0, 0);
            snapControl.Name = "snapControl1";
            snapControl.Options.Fields.EnableEmptyFieldDataAlias = true;
            snapControl.Options.SnapMailMergeVisualOptions.DataSourceName = null;
            snapControl.Size = new System.Drawing.Size(744, 672);
            snapControl.TabIndex = 0;
            snapControl.Text = "snapControl1";
            // 
            // snapDockManager
            // 
            snapDockManager.Form = snapForm;
            snapDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            panelContainer});
            snapDockManager.SnapControl = snapControl;
            snapDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // fieldListDockPanel
            // 
            fieldListDockPanel.Controls.Add(fieldListDockPanel1_Container);
            fieldListDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            fieldListDockPanel.ID = Guid.NewGuid();
            fieldListDockPanel.Location = new System.Drawing.Point(0, 0);
            fieldListDockPanel.Name = "fieldListDockPanel1";
            fieldListDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            fieldListDockPanel.Size = new System.Drawing.Size(200, 336);
            fieldListDockPanel.SnapControl = snapControl;
            // 
            // fieldListDockPanel1_Container
            // 
            fieldListDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            fieldListDockPanel1_Container.Size = new System.Drawing.Size(192, 309);
            fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // reportExplorerDockPanel1
            // 
            reportExplorerDockPanel.Controls.Add(reportExplorerDockPanel1_Container);
            reportExplorerDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            reportExplorerDockPanel.ID = Guid.NewGuid();
            reportExplorerDockPanel.Location = new System.Drawing.Point(0, 336);
            reportExplorerDockPanel.Name = "reportExplorerDockPanel1";
            reportExplorerDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            reportExplorerDockPanel.Size = new System.Drawing.Size(200, 336);
            reportExplorerDockPanel.SnapControl = snapControl;
            // 
            // reportExplorerDockPanel1_Container
            // 
            reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(192, 309);
            reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // panelContainer1
            // 
            panelContainer.Controls.Add(fieldListDockPanel);
            panelContainer.Controls.Add(reportExplorerDockPanel);
            panelContainer.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            panelContainer.ID = Guid.NewGuid();
            panelContainer.Location = new System.Drawing.Point(744, 0);
            panelContainer.Name = "panelContainer1";
            panelContainer.OriginalSize = new System.Drawing.Size(200, 200);
            panelContainer.Size = new System.Drawing.Size(200, 672);
            panelContainer.Text = "panelContainer1";
            // 
            // snapDocumentManager1
            // 
            snapDocumentManager.ClientControl = snapControl;
            snapDocumentManager.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            snapDocumentManager.View = noDocumentsView;
            snapDocumentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            noDocumentsView});
            // 
            // MainForm
            // 
            snapForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            snapForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            snapForm.ClientSize = new System.Drawing.Size(944, 672);
            snapForm.Controls.Add(snapControl);
            snapForm.Controls.Add(panelContainer);
            snapForm.Name = "SnapReportForm";
            snapForm.Text = "Snap Report Preview";
            ((System.ComponentModel.ISupportInitialize)(snapDockManager)).EndInit();
            fieldListDockPanel.ResumeLayout(false);
            reportExplorerDockPanel.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(snapDocumentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(noDocumentsView)).EndInit();
            snapForm.ResumeLayout(false);

            return snapDockManager;
        }

        static void CreateRibbonMenuWithPredefinedItems(RibbonForm snapForm, SnapControl snapControl, DevExpress.Snap.Extensions.SnapDockManager dockManager) {
            DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
            DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
            DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
            DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
            DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
            DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem1;
            DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
            DevExpress.XtraRichEdit.UI.PrintItem printItem1;
            DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
            DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
            DevExpress.XtraRichEdit.UI.CutItem cutItem1;
            DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
            DevExpress.XtraRichEdit.UI.PasteSpecialItem pasteSpecialItem1;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
            DevExpress.XtraRichEdit.UI.ChangeFontNameItem changeFontNameItem1;
            DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
            DevExpress.XtraRichEdit.UI.ChangeFontSizeItem changeFontSizeItem1;
            DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
            DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem fontSizeIncreaseItem1;
            DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem fontSizeDecreaseItem1;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
            DevExpress.XtraRichEdit.UI.ToggleFontBoldItem toggleFontBoldItem1;
            DevExpress.XtraRichEdit.UI.ToggleFontItalicItem toggleFontItalicItem1;
            DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem toggleFontUnderlineItem1;
            DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
            DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
            DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;
            DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem toggleFontSuperscriptItem1;
            DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem toggleFontSubscriptItem1;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
            DevExpress.XtraRichEdit.UI.ChangeFontColorItem changeFontColorItem1;
            DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem changeFontBackColorItem1;
            DevExpress.XtraRichEdit.UI.ChangeTextCaseItem changeTextCaseItem1;
            DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem makeTextUpperCaseItem1;
            DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem makeTextLowerCaseItem1;
            DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem capitalizeEachWordCaseItem1;
            DevExpress.XtraRichEdit.UI.ToggleTextCaseItem toggleTextCaseItem1;
            DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
            DevExpress.XtraRichEdit.UI.ToggleBulletedListItem toggleBulletedListItem1;
            DevExpress.XtraRichEdit.UI.ToggleNumberingListItem toggleNumberingListItem1;
            DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem toggleMultiLevelListItem1;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup5;
            DevExpress.XtraRichEdit.UI.DecreaseIndentItem decreaseIndentItem1;
            DevExpress.XtraRichEdit.UI.IncreaseIndentItem increaseIndentItem1;
            DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem toggleShowWhitespaceItem1;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup6;
            DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;
            DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;
            DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;
            DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup7;
            DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;
            DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;
            DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;
            DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;
            DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem showLineSpacingFormItem1;
            DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;
            DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;
            DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;
            DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;
            DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem changeParagraphBackColorItem1;
            DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem galleryChangeStyleItem1;
            DevExpress.XtraRichEdit.UI.FindItem findItem1;
            DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
            DevExpress.XtraRichEdit.UI.InsertPageBreakItem2 insertPageBreakItem21;
            DevExpress.XtraRichEdit.UI.InsertTableItem insertTableItem1;
            DevExpress.XtraRichEdit.UI.InsertPictureItem insertPictureItem1;
            DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem insertFloatingPictureItem1;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem3;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem4;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem5;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem6;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem7;
            DevExpress.XtraRichEdit.UI.InsertBookmarkItem insertBookmarkItem1;
            DevExpress.XtraRichEdit.UI.InsertHyperlinkItem insertHyperlinkItem1;
            DevExpress.XtraRichEdit.UI.EditPageHeaderItem editPageHeaderItem1;
            DevExpress.XtraRichEdit.UI.EditPageFooterItem editPageFooterItem1;
            DevExpress.XtraRichEdit.UI.InsertPageNumberItem insertPageNumberItem1;
            DevExpress.XtraRichEdit.UI.InsertPageCountItem insertPageCountItem1;
            DevExpress.XtraRichEdit.UI.InsertTextBoxItem insertTextBoxItem1;
            DevExpress.XtraRichEdit.UI.InsertSymbolItem insertSymbolItem1;
            DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem changeSectionPageMarginsItem1;
            DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem setNormalSectionPageMarginsItem1;
            DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem setNarrowSectionPageMarginsItem1;
            DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem setModerateSectionPageMarginsItem1;
            DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem setWideSectionPageMarginsItem1;
            DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem showPageMarginsSetupFormItem1;
            DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem changeSectionPageOrientationItem1;
            DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem setPortraitPageOrientationItem1;
            DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem setLandscapePageOrientationItem1;
            DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem changeSectionPaperKindItem1;
            DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem changeSectionColumnsItem1;
            DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem setSectionOneColumnItem1;
            DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem setSectionTwoColumnsItem1;
            DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem setSectionThreeColumnsItem1;
            DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem showColumnsSetupFormItem1;
            DevExpress.XtraRichEdit.UI.InsertBreakItem insertBreakItem1;
            DevExpress.XtraRichEdit.UI.InsertPageBreakItem insertPageBreakItem1;
            DevExpress.XtraRichEdit.UI.InsertColumnBreakItem insertColumnBreakItem1;
            DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem insertSectionBreakNextPageItem1;
            DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem insertSectionBreakEvenPageItem1;
            DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem insertSectionBreakOddPageItem1;
            DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem changeSectionLineNumberingItem1;
            DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem setSectionLineNumberingNoneItem1;
            DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem setSectionLineNumberingContinuousItem1;
            DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem setSectionLineNumberingRestartNewPageItem1;
            DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem setSectionLineNumberingRestartNewSectionItem1;
            DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem toggleParagraphSuppressLineNumbersItem1;
            DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem showLineNumberingFormItem1;
            DevExpress.XtraRichEdit.UI.ChangePageColorItem changePageColorItem1;
            DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem switchToSimpleViewItem1;
            DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem switchToDraftViewItem1;
            DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem switchToPrintLayoutViewItem1;
            DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem toggleShowHorizontalRulerItem1;
            DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem toggleShowVerticalRulerItem1;
            DevExpress.XtraRichEdit.UI.ZoomOutItem zoomOutItem1;
            DevExpress.XtraRichEdit.UI.ZoomInItem zoomInItem1;
            DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem snapBarToolbarsListItem1;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem1;
            DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem showAllFieldCodesItem1;
            DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem showAllFieldResultsItem1;
            DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem toggleFieldHighlightingItem1;
            DevExpress.XtraRichEdit.UI.GoToPageHeaderItem goToPageHeaderItem1;
            DevExpress.XtraRichEdit.UI.GoToPageFooterItem goToPageFooterItem1;
            DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem goToNextHeaderFooterItem1;
            DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem goToPreviousHeaderFooterItem1;
            DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem toggleLinkToPreviousItem1;
            DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem toggleDifferentFirstPageItem1;
            DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem toggleDifferentOddAndEvenPagesItem1;
            DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem closePageHeaderFooterItem1;
            DevExpress.XtraRichEdit.UI.ToggleFirstRowItem toggleFirstRowItem1;
            DevExpress.XtraRichEdit.UI.ToggleLastRowItem toggleLastRowItem1;
            DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem toggleBandedRowsItem1;
            DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem toggleFirstColumnItem1;
            DevExpress.XtraRichEdit.UI.ToggleLastColumnItem toggleLastColumnItem1;
            DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem toggleBandedColumnsItem1;
            DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem galleryChangeTableStyleItem1;
            DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem galleryChangeTableCellStyleItem1;
            DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem changeTableBorderLineStyleItem1;
            DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle repositoryItemBorderLineStyle1;
            DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem changeTableBorderLineWeightItem1;
            DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight repositoryItemBorderLineWeight1;
            DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem changeTableBorderColorItem1;
            DevExpress.XtraRichEdit.UI.ChangeTableBordersItem changeTableBordersItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem toggleTableCellsBottomBorderItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem toggleTableCellsTopBorderItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem toggleTableCellsLeftBorderItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem toggleTableCellsRightBorderItem1;
            DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem resetTableCellsAllBordersItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem toggleTableCellsAllBordersItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem toggleTableCellsOutsideBorderItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem toggleTableCellsInsideBorderItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem toggleTableCellsInsideHorizontalBorderItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem toggleTableCellsInsideVerticalBorderItem1;
            DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem toggleShowTableGridLinesItem1;
            DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem changeTableCellsShadingItem1;
            DevExpress.XtraRichEdit.UI.SelectTableElementsItem selectTableElementsItem1;
            DevExpress.XtraRichEdit.UI.SelectTableCellItem selectTableCellItem1;
            DevExpress.XtraRichEdit.UI.SelectTableColumnItem selectTableColumnItem1;
            DevExpress.XtraRichEdit.UI.SelectTableRowItem selectTableRowItem1;
            DevExpress.XtraRichEdit.UI.SelectTableItem selectTableItem1;
            DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem showTablePropertiesFormItem1;
            DevExpress.XtraRichEdit.UI.DeleteTableElementsItem deleteTableElementsItem1;
            DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem showDeleteTableCellsFormItem1;
            DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem deleteTableColumnsItem1;
            DevExpress.XtraRichEdit.UI.DeleteTableRowsItem deleteTableRowsItem1;
            DevExpress.XtraRichEdit.UI.DeleteTableItem deleteTableItem1;
            DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem insertTableRowAboveItem1;
            DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem insertTableRowBelowItem1;
            DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem insertTableColumnToLeftItem1;
            DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem insertTableColumnToRightItem1;
            DevExpress.XtraRichEdit.UI.MergeTableCellsItem mergeTableCellsItem1;
            DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm showSplitTableCellsForm1;
            DevExpress.XtraRichEdit.UI.SplitTableItem splitTableItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem toggleTableAutoFitItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem toggleTableAutoFitContentsItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem toggleTableAutoFitWindowItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem toggleTableFixedColumnWidthItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem toggleTableCellsTopLeftAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem toggleTableCellsMiddleLeftAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem toggleTableCellsBottomLeftAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem toggleTableCellsTopCenterAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem toggleTableCellsMiddleCenterAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem toggleTableCellsBottomCenterAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem toggleTableCellsTopRightAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem toggleTableCellsMiddleRightAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem toggleTableCellsBottomRightAlignmentItem1;
            DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem showTableOptionsFormItem1;
            DevExpress.XtraRichEdit.UI.CheckSpellingItem checkSpellingItem1;
            DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem insertTableOfContentsItem1;
            DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem updateTableOfContentsItem1;
            DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem addParagraphsToTableOfContentItem1;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem1;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem2;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem3;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem4;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem5;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem6;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem7;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem8;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem9;
            DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem setParagraphHeadingLevelItem10;
            DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem insertCaptionPlaceholderItem1;
            DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems insertFiguresCaptionItems1;
            DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems insertTablesCaptionItems1;
            DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems insertEquationsCaptionItems1;
            DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem insertTableOfFiguresPlaceholderItem1;
            DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems insertTableOfFiguresItems1;
            DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems insertTableOfTablesItems1;
            DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems insertTableOfEquationsItems1;
            DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem updateTableOfFiguresItem1;
            DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem changeFloatingObjectFillColorItem1;
            DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem changeFloatingObjectOutlineColorItem1;
            DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem changeFloatingObjectOutlineWeightItem1;
            DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight repositoryItemFloatingObjectOutlineWeight1;
            DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem changeFloatingObjectTextWrapTypeItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem setFloatingObjectSquareTextWrapTypeItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem setFloatingObjectTightTextWrapTypeItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem setFloatingObjectThroughTextWrapTypeItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem setFloatingObjectTopAndBottomTextWrapTypeItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem setFloatingObjectBehindTextWrapTypeItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem setFloatingObjectInFrontOfTextWrapTypeItem1;
            DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem changeFloatingObjectAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem setFloatingObjectTopLeftAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem setFloatingObjectTopCenterAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem setFloatingObjectTopRightAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem setFloatingObjectMiddleLeftAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem setFloatingObjectMiddleCenterAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem setFloatingObjectMiddleRightAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem setFloatingObjectBottomLeftAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem setFloatingObjectBottomCenterAlignmentItem1;
            DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem setFloatingObjectBottomRightAlignmentItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem floatingObjectBringForwardSubItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem floatingObjectBringForwardItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem floatingObjectBringToFrontItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem floatingObjectBringInFrontOfTextItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem floatingObjectSendBackwardSubItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem floatingObjectSendBackwardItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem floatingObjectSendToBackItem1;
            DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem floatingObjectSendBehindTextItem1;
            DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem themesGalleryBarItem1;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem2;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem3;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem4;
            DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem1;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem5;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem6;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem7;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem8;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem9;
            DevExpress.Snap.Extensions.UI.FilterPopupButtonItem filterPopupButtonItem1;
            DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem propertiesBarButtonItem1;
            DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem2;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem10;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem11;
            DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem3;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem12;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem13;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem8;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem9;
            DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem4;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem14;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem15;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem16;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem17;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem18;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem19;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem20;
            DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem5;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem21;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem22;
            DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem6;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem23;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem24;
            DevExpress.Snap.Extensions.UI.CommandBarSubItem commandBarSubItem7;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem25;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem26;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem27;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem28;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem29;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem30;
            DevExpress.Snap.Extensions.UI.CommandBarCheckItem commandBarCheckItem31;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem10;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem11;
            DevExpress.Snap.Extensions.UI.CommandBarItem commandBarItem12;
            DevExpress.XtraBars.BarButtonGroup barButtonGroup8;
            DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem changeEditorRowLimitItem1;
            DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit repositoryItemEditorRowLimitEdit1;
            DevExpress.XtraCharts.UI.CreateBarBaseItem createBarBaseItem1;
            DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown1;
            DevExpress.XtraCharts.UI.CreateLineBaseItem createLineBaseItem1;
            DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown2;
            DevExpress.XtraCharts.UI.CreatePieBaseItem createPieBaseItem1;
            DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown3;
            DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem createRotatedBarBaseItem1;
            DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown4;
            DevExpress.XtraCharts.UI.CreateAreaBaseItem createAreaBaseItem1;
            DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown5;
            DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem createOtherSeriesTypesBaseItem1;
            DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown6;
            DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem changePaletteGalleryBaseItem1;
            DevExpress.XtraBars.Commands.CommandBarGalleryDropDown commandBarGalleryDropDown7;
            DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem changeAppearanceGalleryBaseItem1;
            DevExpress.XtraCharts.UI.RunWizardChartItem runWizardChartItem1;
            DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory headerFooterToolsRibbonPageCategory1;
            DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage headerFooterToolsDesignRibbonPage1;
            DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup headerFooterToolsDesignNavigationRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup headerFooterToolsDesignOptionsRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup headerFooterToolsDesignCloseRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory tableToolsRibbonPageCategory1;
            DevExpress.XtraRichEdit.UI.TableDesignRibbonPage tableDesignRibbonPage1;
            DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup tableStyleOptionsRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup tableStylesRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup tableCellStylesRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup tableDrawBordersRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage tableLayoutRibbonPage1;
            DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup tableTableRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup tableRowsAndColumnsRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup tableMergeRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup tableCellSizeRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup tableAlignmentRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory floatingPictureToolsRibbonPageCategory1;
            DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage floatingPictureToolsFormatPage1;
            DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup floatingPictureToolsShapeStylesPageGroup1;
            DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup floatingPictureToolsArrangePageGroup1;
            DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory dataToolsRibbonPageCategory1;
            DevExpress.Snap.Extensions.UI.AppearanceRibbonPage appearanceRibbonPage1;
            DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup themesRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage snMergeFieldToolsRibbonPage1;
            DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup dataShapingRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup snMergeFieldPropertiesRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage groupToolsRibbonPage1;
            DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup groupingRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.ListToolsRibbonPage listToolsRibbonPage1;
            DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup listHeaderAndFooterRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup listCommandsRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup listEditorRowLimitRibbonPageGroup1;
            DevExpress.XtraCharts.UI.ChartRibbonPageCategory chartRibbonPageCategory1;
            DevExpress.XtraCharts.UI.CreateChartRibbonPage createChartRibbonPage1;
            DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup chartTypeRibbonPageGroup1;
            DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup chartAppearanceRibbonPageGroup1;
            DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup chartWizardRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.FileRibbonPage fileRibbonPage1;
            DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.HomeRibbonPage homeRibbonPage1;
            DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup clipboardRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.FontRibbonPageGroup fontRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup paragraphRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup stylesRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup editingRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.InsertRibbonPage insertRibbonPage1;
            DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup pagesRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup tablesRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup toolboxRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup linksRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup headerFooterRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.TextRibbonPageGroup textRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup symbolsRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage pageLayoutRibbonPage1;
            DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup pageSetupRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup pageBackgroundRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.ViewRibbonPage viewRibbonPage1;
            DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup documentViewsRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup showRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup zoomRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup viewRibbonPageGroup1;
            DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup viewFieldsRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.ReviewRibbonPage reviewRibbonPage1;
            DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup documentProofingRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.ReferencesRibbonPage referencesRibbonPage1;
            DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup tableOfContentsRibbonPageGroup1;
            DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup captionsRibbonPageGroup1;
            DevExpress.Snap.Extensions.SnapBarController snapBarController1;

            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(snapForm.GetType());
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraRichEdit.Model.BorderInfo borderInfo1 = new DevExpress.XtraRichEdit.Model.BorderInfo();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn chartControlCommandGalleryItemGroup2DColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn();
            DevExpress.XtraCharts.UI.CreateBarChartItem createBarChartItem1 = new DevExpress.XtraCharts.UI.CreateBarChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem createFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem createSideBySideFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem createSideBySideStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBarChartItem createStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn chartControlCommandGalleryItemGroup3DColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn();
            DevExpress.XtraCharts.UI.CreateBar3DChartItem createBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem createFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateManhattanBarChartItem createManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem createSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem createSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem createStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn chartControlCommandGalleryItemGroupCylinderColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn();
            DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem createCylinderBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem createCylinderFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem createCylinderManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem createCylinderSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem createCylinderSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem createCylinderStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn chartControlCommandGalleryItemGroupConeColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn();
            DevExpress.XtraCharts.UI.CreateConeBar3DChartItem createConeBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem createConeFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem createConeManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem createConeSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem createConeSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem createConeStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn chartControlCommandGalleryItemGroupPyramidColumn1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn();
            DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem createPyramidBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem createPyramidFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem createPyramidManhattanBarChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem createPyramidSideBySideFullStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem createPyramidSideBySideStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem createPyramidStackedBar3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine chartControlCommandGalleryItemGroup2DLine1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine();
            DevExpress.XtraCharts.UI.CreateLineChartItem createLineChartItem1 = new DevExpress.XtraCharts.UI.CreateLineChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem createFullStackedLineChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateScatterLineChartItem createScatterLineChartItem1 = new DevExpress.XtraCharts.UI.CreateScatterLineChartItem();
            DevExpress.XtraCharts.UI.CreateSplineChartItem createSplineChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLineChartItem createStackedLineChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedLineChartItem();
            DevExpress.XtraCharts.UI.CreateStepLineChartItem createStepLineChartItem1 = new DevExpress.XtraCharts.UI.CreateStepLineChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine chartControlCommandGalleryItemGroup3DLine1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine();
            DevExpress.XtraCharts.UI.CreateLine3DChartItem createLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem createFullStackedLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateSpline3DChartItem createSpline3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSpline3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem createStackedLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepLine3DChartItem createStepLine3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStepLine3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie chartControlCommandGalleryItemGroup2DPie1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie();
            DevExpress.XtraCharts.UI.CreatePieChartItem createPieChartItem1 = new DevExpress.XtraCharts.UI.CreatePieChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnutChartItem createDoughnutChartItem1 = new DevExpress.XtraCharts.UI.CreateDoughnutChartItem();
            DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem createNestedDoughnutChartItem1 = new DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie chartControlCommandGalleryItemGroup3DPie1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie();
            DevExpress.XtraCharts.UI.CreatePie3DChartItem createPie3DChartItem1 = new DevExpress.XtraCharts.UI.CreatePie3DChartItem();
            DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem createDoughnut3DChartItem1 = new DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar chartControlCommandGalleryItemGroup2DBar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar();
            DevExpress.XtraCharts.UI.CreateRotatedBarChartItem createRotatedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem createRotatedFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem createRotatedSideBySideFullStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem createRotatedSideBySideStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem();
            DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem createRotatedStackedBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea chartControlCommandGalleryItemGroup2DArea1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea();
            DevExpress.XtraCharts.UI.CreateAreaChartItem createAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem createFullStackedAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem createFullStackedSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateSplineAreaChartItem createSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedAreaChartItem createStackedAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem createStackedSplineAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem();
            DevExpress.XtraCharts.UI.CreateStepAreaChartItem createStepAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateStepAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea chartControlCommandGalleryItemGroup3DArea1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea();
            DevExpress.XtraCharts.UI.CreateArea3DChartItem createArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem createFullStackedArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem createFullStackedSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem createSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem createStackedArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem createStackedSplineArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem();
            DevExpress.XtraCharts.UI.CreateStepArea3DChartItem createStepArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateStepArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint chartControlCommandGalleryItemGroupPoint1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint();
            DevExpress.XtraCharts.UI.CreatePointChartItem createPointChartItem1 = new DevExpress.XtraCharts.UI.CreatePointChartItem();
            DevExpress.XtraCharts.UI.CreateBubbleChartItem createBubbleChartItem1 = new DevExpress.XtraCharts.UI.CreateBubbleChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel chartControlCommandGalleryItemGroupFunnel1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel();
            DevExpress.XtraCharts.UI.CreateFunnelChartItem createFunnelChartItem1 = new DevExpress.XtraCharts.UI.CreateFunnelChartItem();
            DevExpress.XtraCharts.UI.CreateFunnel3DChartItem createFunnel3DChartItem1 = new DevExpress.XtraCharts.UI.CreateFunnel3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial chartControlCommandGalleryItemGroupFinancial1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial();
            DevExpress.XtraCharts.UI.CreateStockChartItem createStockChartItem1 = new DevExpress.XtraCharts.UI.CreateStockChartItem();
            DevExpress.XtraCharts.UI.CreateCandleStickChartItem createCandleStickChartItem1 = new DevExpress.XtraCharts.UI.CreateCandleStickChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar chartControlCommandGalleryItemGroupRadar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar();
            DevExpress.XtraCharts.UI.CreateRadarPointChartItem createRadarPointChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarPointChartItem();
            DevExpress.XtraCharts.UI.CreateRadarLineChartItem createRadarLineChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarLineChartItem();
            DevExpress.XtraCharts.UI.CreateRadarAreaChartItem createRadarAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateRadarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar chartControlCommandGalleryItemGroupPolar1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar();
            DevExpress.XtraCharts.UI.CreatePolarPointChartItem createPolarPointChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarPointChartItem();
            DevExpress.XtraCharts.UI.CreatePolarLineChartItem createPolarLineChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarLineChartItem();
            DevExpress.XtraCharts.UI.CreatePolarAreaChartItem createPolarAreaChartItem1 = new DevExpress.XtraCharts.UI.CreatePolarAreaChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange chartControlCommandGalleryItemGroupRange1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange();
            DevExpress.XtraCharts.UI.CreateRangeBarChartItem createRangeBarChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem createSideBySideRangeBarChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem();
            DevExpress.XtraCharts.UI.CreateRangeAreaChartItem createRangeAreaChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeAreaChartItem();
            DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem createRangeArea3DChartItem1 = new DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem();
            DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt chartControlCommandGalleryItemGroupGantt1 = new DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt();
            DevExpress.XtraCharts.UI.CreateGanttChartItem createGanttChartItem1 = new DevExpress.XtraCharts.UI.CreateGanttChartItem();
            DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem createSideBySideGanttChartItem1 = new DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();

            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            snapBarController1 = new DevExpress.Snap.Extensions.SnapBarController();
            commonRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup();
            fileRibbonPage1 = new DevExpress.XtraRichEdit.UI.FileRibbonPage();
            undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            commandBarItem1 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            clipboardRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup();
            homeRibbonPage1 = new DevExpress.XtraRichEdit.UI.HomeRibbonPage();
            pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            fontRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.FontRibbonPageGroup();
            changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            toggleFontSuperscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem();
            toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            changeFontBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem();
            changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            capitalizeEachWordCaseItem1 = new DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem();
            toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            paragraphRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup();
            toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
            barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonGroup5 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonGroup6 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonGroup7 = new DevExpress.XtraBars.BarButtonGroup();
            stylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup();
            galleryChangeStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem();
            editingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup();
            findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            pagesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup();
            insertRibbonPage1 = new DevExpress.XtraRichEdit.UI.InsertRibbonPage();
            insertPageBreakItem21 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem2();
            tablesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup();
            insertTableItem1 = new DevExpress.XtraRichEdit.UI.InsertTableItem();
            illustrationsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup();
            insertPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertPictureItem();
            insertFloatingPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem();
            toolboxRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup();
            commandBarItem3 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarItem4 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarItem5 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarItem6 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarItem7 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            linksRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup();
            insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            headerFooterRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup();
            editPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.EditPageHeaderItem();
            editPageFooterItem1 = new DevExpress.XtraRichEdit.UI.EditPageFooterItem();
            insertPageNumberItem1 = new DevExpress.XtraRichEdit.UI.InsertPageNumberItem();
            insertPageCountItem1 = new DevExpress.XtraRichEdit.UI.InsertPageCountItem();
            textRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TextRibbonPageGroup();
            insertTextBoxItem1 = new DevExpress.XtraRichEdit.UI.InsertTextBoxItem();
            symbolsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup();
            insertSymbolItem1 = new DevExpress.XtraRichEdit.UI.InsertSymbolItem();
            pageSetupRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup();
            pageLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage();
            changeSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem();
            setNormalSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem();
            setNarrowSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem();
            setModerateSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem();
            setWideSectionPageMarginsItem1 = new DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem();
            showPageMarginsSetupFormItem1 = new DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem();
            changeSectionPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem();
            setPortraitPageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem();
            setLandscapePageOrientationItem1 = new DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem();
            changeSectionPaperKindItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem();
            changeSectionColumnsItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem();
            setSectionOneColumnItem1 = new DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem();
            setSectionTwoColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem();
            setSectionThreeColumnsItem1 = new DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem();
            showColumnsSetupFormItem1 = new DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem();
            insertBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertBreakItem();
            insertPageBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertPageBreakItem();
            insertColumnBreakItem1 = new DevExpress.XtraRichEdit.UI.InsertColumnBreakItem();
            insertSectionBreakNextPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem();
            insertSectionBreakEvenPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem();
            insertSectionBreakOddPageItem1 = new DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem();
            changeSectionLineNumberingItem1 = new DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem();
            setSectionLineNumberingNoneItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem();
            setSectionLineNumberingContinuousItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem();
            setSectionLineNumberingRestartNewPageItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem();
            setSectionLineNumberingRestartNewSectionItem1 = new DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem();
            toggleParagraphSuppressLineNumbersItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem();
            showLineNumberingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem();
            pageBackgroundRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup();
            changePageColorItem1 = new DevExpress.XtraRichEdit.UI.ChangePageColorItem();
            documentViewsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup();
            viewRibbonPage1 = new DevExpress.XtraRichEdit.UI.ViewRibbonPage();
            switchToSimpleViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem();
            switchToDraftViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem();
            switchToPrintLayoutViewItem1 = new DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem();
            showRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup();
            toggleShowHorizontalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem();
            toggleShowVerticalRulerItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem();
            zoomRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup();
            zoomOutItem1 = new DevExpress.XtraRichEdit.UI.ZoomOutItem();
            zoomInItem1 = new DevExpress.XtraRichEdit.UI.ZoomInItem();
            viewRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup();
            snapBarToolbarsListItem1 = new DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem();
            commandBarCheckItem1 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            viewFieldsRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup();
            showAllFieldCodesItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            showAllFieldResultsItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            toggleFieldHighlightingItem1 = new DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem();
            headerFooterToolsDesignNavigationRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup();
            headerFooterToolsDesignRibbonPage1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage();
            headerFooterToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory();
            goToPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.GoToPageHeaderItem();
            goToPageFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToPageFooterItem();
            goToNextHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem();
            goToPreviousHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem();
            toggleLinkToPreviousItem1 = new DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem();
            headerFooterToolsDesignOptionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup();
            toggleDifferentFirstPageItem1 = new DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem();
            toggleDifferentOddAndEvenPagesItem1 = new DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem();
            headerFooterToolsDesignCloseRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup();
            closePageHeaderFooterItem1 = new DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem();
            tableStyleOptionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup();
            tableDesignRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableDesignRibbonPage();
            tableToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory();
            toggleFirstRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstRowItem();
            toggleLastRowItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastRowItem();
            toggleBandedRowsItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem();
            toggleFirstColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem();
            toggleLastColumnItem1 = new DevExpress.XtraRichEdit.UI.ToggleLastColumnItem();
            toggleBandedColumnsItem1 = new DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem();
            tableStylesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup();
            galleryChangeTableStyleItem1 = new DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem();
            tableCellStylesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup();
            galleryChangeTableCellStyleItem1 = new DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem();
            tableDrawBordersRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup();
            changeTableBorderLineStyleItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem();
            changeTableBorderLineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem();
            changeTableBorderColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem();
            changeTableBordersItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableBordersItem();
            toggleTableCellsBottomBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem();
            toggleTableCellsTopBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem();
            toggleTableCellsLeftBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem();
            toggleTableCellsRightBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem();
            resetTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem();
            toggleTableCellsAllBordersItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem();
            toggleTableCellsOutsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem();
            toggleTableCellsInsideBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem();
            toggleTableCellsInsideHorizontalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem();
            toggleTableCellsInsideVerticalBorderItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem();
            toggleShowTableGridLinesItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem();
            changeTableCellsShadingItem1 = new DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem();
            repositoryItemBorderLineStyle1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle();
            repositoryItemBorderLineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight();
            tableTableRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup();
            tableLayoutRibbonPage1 = new DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage();
            selectTableElementsItem1 = new DevExpress.XtraRichEdit.UI.SelectTableElementsItem();
            selectTableCellItem1 = new DevExpress.XtraRichEdit.UI.SelectTableCellItem();
            selectTableColumnItem1 = new DevExpress.XtraRichEdit.UI.SelectTableColumnItem();
            selectTableRowItem1 = new DevExpress.XtraRichEdit.UI.SelectTableRowItem();
            selectTableItem1 = new DevExpress.XtraRichEdit.UI.SelectTableItem();
            showTablePropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem();
            tableRowsAndColumnsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup();
            deleteTableElementsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableElementsItem();
            showDeleteTableCellsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem();
            deleteTableColumnsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem();
            deleteTableRowsItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableRowsItem();
            deleteTableItem1 = new DevExpress.XtraRichEdit.UI.DeleteTableItem();
            insertTableRowAboveItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem();
            insertTableRowBelowItem1 = new DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem();
            insertTableColumnToLeftItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem();
            insertTableColumnToRightItem1 = new DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem();
            tableMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup();
            mergeTableCellsItem1 = new DevExpress.XtraRichEdit.UI.MergeTableCellsItem();
            showSplitTableCellsForm1 = new DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm();
            splitTableItem1 = new DevExpress.XtraRichEdit.UI.SplitTableItem();
            tableCellSizeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup();
            toggleTableAutoFitItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem();
            toggleTableAutoFitContentsItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem();
            toggleTableAutoFitWindowItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem();
            toggleTableFixedColumnWidthItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem();
            tableAlignmentRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup();
            toggleTableCellsTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem();
            toggleTableCellsMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem();
            toggleTableCellsBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem();
            toggleTableCellsTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem();
            toggleTableCellsMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem();
            toggleTableCellsBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem();
            toggleTableCellsTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem();
            toggleTableCellsMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem();
            toggleTableCellsBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem();
            showTableOptionsFormItem1 = new DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem();
            documentProofingRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup();
            reviewRibbonPage1 = new DevExpress.XtraRichEdit.UI.ReviewRibbonPage();
            checkSpellingItem1 = new DevExpress.XtraRichEdit.UI.CheckSpellingItem();
            tableOfContentsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup();
            referencesRibbonPage1 = new DevExpress.XtraRichEdit.UI.ReferencesRibbonPage();
            insertTableOfContentsItem1 = new DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem();
            updateTableOfContentsItem1 = new DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem();
            addParagraphsToTableOfContentItem1 = new DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem();
            setParagraphHeadingLevelItem1 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem2 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem3 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem4 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem5 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem6 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem7 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem8 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem9 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            setParagraphHeadingLevelItem10 = new DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem();
            captionsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup();
            insertCaptionPlaceholderItem1 = new DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem();
            insertFiguresCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems();
            insertTablesCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems();
            insertEquationsCaptionItems1 = new DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems();
            insertTableOfFiguresPlaceholderItem1 = new DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem();
            insertTableOfFiguresItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems();
            insertTableOfTablesItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems();
            insertTableOfEquationsItems1 = new DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems();
            updateTableOfFiguresItem1 = new DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem();
            floatingPictureToolsShapeStylesPageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup();
            floatingPictureToolsFormatPage1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage();
            floatingPictureToolsRibbonPageCategory1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory();
            changeFloatingObjectFillColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem();
            changeFloatingObjectOutlineColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem();
            changeFloatingObjectOutlineWeightItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem();
            repositoryItemFloatingObjectOutlineWeight1 = new DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight();
            floatingPictureToolsArrangePageGroup1 = new DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup();
            changeFloatingObjectTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem();
            setFloatingObjectSquareTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem();
            setFloatingObjectTightTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem();
            setFloatingObjectThroughTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem();
            setFloatingObjectTopAndBottomTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem();
            setFloatingObjectBehindTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem();
            setFloatingObjectInFrontOfTextWrapTypeItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem();
            changeFloatingObjectAlignmentItem1 = new DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem();
            setFloatingObjectTopLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem();
            setFloatingObjectTopCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem();
            setFloatingObjectTopRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem();
            setFloatingObjectMiddleLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem();
            setFloatingObjectMiddleCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem();
            setFloatingObjectMiddleRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem();
            setFloatingObjectBottomLeftAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem();
            setFloatingObjectBottomCenterAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem();
            setFloatingObjectBottomRightAlignmentItem1 = new DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem();
            floatingObjectBringForwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem();
            floatingObjectBringForwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem();
            floatingObjectBringToFrontItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem();
            floatingObjectBringInFrontOfTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem();
            floatingObjectSendBackwardSubItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem();
            floatingObjectSendBackwardItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem();
            floatingObjectSendToBackItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem();
            floatingObjectSendBehindTextItem1 = new DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem();
            themesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup();
            appearanceRibbonPage1 = new DevExpress.Snap.Extensions.UI.AppearanceRibbonPage();
            dataToolsRibbonPageCategory1 = new DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory();
            themesGalleryBarItem1 = new DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem();
            dataShapingRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup();
            snMergeFieldToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage();
            commandBarCheckItem2 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem3 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem4 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarSubItem1 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            commandBarCheckItem5 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem6 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem7 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem8 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem9 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            filterPopupButtonItem1 = new DevExpress.Snap.Extensions.UI.FilterPopupButtonItem();
            snMergeFieldPropertiesRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup();
            propertiesBarButtonItem1 = new DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem();
            groupingRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup();
            groupToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage();
            commandBarSubItem2 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            commandBarCheckItem10 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem11 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarSubItem3 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            commandBarCheckItem12 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem13 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarItem8 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarItem9 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarSubItem4 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            commandBarCheckItem14 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem15 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem16 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem17 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem18 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem19 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem20 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            listHeaderAndFooterRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup();
            listToolsRibbonPage1 = new DevExpress.Snap.Extensions.UI.ListToolsRibbonPage();
            commandBarSubItem5 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            commandBarCheckItem21 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem22 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarSubItem6 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            commandBarCheckItem23 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem24 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarSubItem7 = new DevExpress.Snap.Extensions.UI.CommandBarSubItem();
            commandBarCheckItem25 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem26 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem27 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem28 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem29 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem30 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            commandBarCheckItem31 = new DevExpress.Snap.Extensions.UI.CommandBarCheckItem();
            listCommandsRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup();
            commandBarItem10 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarItem11 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            commandBarItem12 = new DevExpress.Snap.Extensions.UI.CommandBarItem();
            listEditorRowLimitRibbonPageGroup1 = new DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup();
            changeEditorRowLimitItem1 = new DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem();
            barButtonGroup8 = new DevExpress.XtraBars.BarButtonGroup();
            repositoryItemEditorRowLimitEdit1 = new DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit();
            chartTypeRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup();
            createChartRibbonPage1 = new DevExpress.XtraCharts.UI.CreateChartRibbonPage();
            chartRibbonPageCategory1 = new DevExpress.XtraCharts.UI.ChartRibbonPageCategory();
            createBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateBarBaseItem();
            commandBarGalleryDropDown1 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown();
            createLineBaseItem1 = new DevExpress.XtraCharts.UI.CreateLineBaseItem();
            commandBarGalleryDropDown2 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown();
            createPieBaseItem1 = new DevExpress.XtraCharts.UI.CreatePieBaseItem();
            commandBarGalleryDropDown3 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown();
            createRotatedBarBaseItem1 = new DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem();
            commandBarGalleryDropDown4 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown();
            createAreaBaseItem1 = new DevExpress.XtraCharts.UI.CreateAreaBaseItem();
            commandBarGalleryDropDown5 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown();
            createOtherSeriesTypesBaseItem1 = new DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem();
            commandBarGalleryDropDown6 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown();
            chartAppearanceRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup();
            changePaletteGalleryBaseItem1 = new DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem();
            commandBarGalleryDropDown7 = new DevExpress.XtraBars.Commands.CommandBarGalleryDropDown();
            changeAppearanceGalleryBaseItem1 = new DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem();
            chartWizardRibbonPageGroup1 = new DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup();
            runWizardChartItem1 = new DevExpress.XtraCharts.UI.RunWizardChartItem();
            ((System.ComponentModel.ISupportInitialize)(ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(snapBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemBorderLineStyle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemBorderLineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemFloatingObjectOutlineWeight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemEditorRowLimitEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown7)).BeginInit();

            snapForm.SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            ribbonControl1.ExpandCollapseItem,
            undoItem1,
            redoItem1,
            fileOpenItem1,
            fileSaveItem1,
            fileSaveAsItem1,
            commandBarItem1,
            quickPrintItem1,
            printItem1,
            printPreviewItem1,
            pasteItem1,
            cutItem1,
            copyItem1,
            pasteSpecialItem1,
            barButtonGroup1,
            changeFontNameItem1,
            changeFontSizeItem1,
            fontSizeIncreaseItem1,
            fontSizeDecreaseItem1,
            barButtonGroup2,
            toggleFontBoldItem1,
            toggleFontItalicItem1,
            toggleFontUnderlineItem1,
            toggleFontDoubleUnderlineItem1,
            toggleFontStrikeoutItem1,
            toggleFontDoubleStrikeoutItem1,
            toggleFontSuperscriptItem1,
            toggleFontSubscriptItem1,
            barButtonGroup3,
            changeFontColorItem1,
            changeFontBackColorItem1,
            changeTextCaseItem1,
            makeTextUpperCaseItem1,
            makeTextLowerCaseItem1,
            capitalizeEachWordCaseItem1,
            toggleTextCaseItem1,
            clearFormattingItem1,
            barButtonGroup4,
            toggleBulletedListItem1,
            toggleNumberingListItem1,
            toggleMultiLevelListItem1,
            barButtonGroup5,
            decreaseIndentItem1,
            increaseIndentItem1,
            barButtonGroup6,
            toggleParagraphAlignmentLeftItem1,
            toggleParagraphAlignmentCenterItem1,
            toggleParagraphAlignmentRightItem1,
            toggleParagraphAlignmentJustifyItem1,
            toggleShowWhitespaceItem1,
            barButtonGroup7,
            changeParagraphLineSpacingItem1,
            setSingleParagraphSpacingItem1,
            setSesquialteralParagraphSpacingItem1,
            setDoubleParagraphSpacingItem1,
            showLineSpacingFormItem1,
            addSpacingBeforeParagraphItem1,
            removeSpacingBeforeParagraphItem1,
            addSpacingAfterParagraphItem1,
            removeSpacingAfterParagraphItem1,
            changeParagraphBackColorItem1,
            galleryChangeStyleItem1,
            findItem1,
            replaceItem1,
            insertPageBreakItem21,
            insertTableItem1,
            insertPictureItem1,
            insertFloatingPictureItem1,
            commandBarItem3,
            commandBarItem4,
            commandBarItem5,
            commandBarItem6,
            commandBarItem7,
            insertBookmarkItem1,
            insertHyperlinkItem1,
            editPageHeaderItem1,
            editPageFooterItem1,
            insertPageNumberItem1,
            insertPageCountItem1,
            insertTextBoxItem1,
            insertSymbolItem1,
            changeSectionPageMarginsItem1,
            setNormalSectionPageMarginsItem1,
            setNarrowSectionPageMarginsItem1,
            setModerateSectionPageMarginsItem1,
            setWideSectionPageMarginsItem1,
            showPageMarginsSetupFormItem1,
            changeSectionPageOrientationItem1,
            setPortraitPageOrientationItem1,
            setLandscapePageOrientationItem1,
            changeSectionPaperKindItem1,
            changeSectionColumnsItem1,
            setSectionOneColumnItem1,
            setSectionTwoColumnsItem1,
            setSectionThreeColumnsItem1,
            showColumnsSetupFormItem1,
            insertBreakItem1,
            insertPageBreakItem1,
            insertColumnBreakItem1,
            insertSectionBreakNextPageItem1,
            insertSectionBreakEvenPageItem1,
            insertSectionBreakOddPageItem1,
            changeSectionLineNumberingItem1,
            setSectionLineNumberingNoneItem1,
            setSectionLineNumberingContinuousItem1,
            setSectionLineNumberingRestartNewPageItem1,
            setSectionLineNumberingRestartNewSectionItem1,
            toggleParagraphSuppressLineNumbersItem1,
            showLineNumberingFormItem1,
            changePageColorItem1,
            switchToSimpleViewItem1,
            switchToDraftViewItem1,
            switchToPrintLayoutViewItem1,
            toggleShowHorizontalRulerItem1,
            toggleShowVerticalRulerItem1,
            zoomOutItem1,
            zoomInItem1,
            snapBarToolbarsListItem1,
            commandBarCheckItem1,
            showAllFieldCodesItem1,
            showAllFieldResultsItem1,
            toggleFieldHighlightingItem1,
            goToPageHeaderItem1,
            goToPageFooterItem1,
            goToNextHeaderFooterItem1,
            goToPreviousHeaderFooterItem1,
            toggleLinkToPreviousItem1,
            toggleDifferentFirstPageItem1,
            toggleDifferentOddAndEvenPagesItem1,
            closePageHeaderFooterItem1,
            toggleFirstRowItem1,
            toggleLastRowItem1,
            toggleBandedRowsItem1,
            toggleFirstColumnItem1,
            toggleLastColumnItem1,
            toggleBandedColumnsItem1,
            galleryChangeTableStyleItem1,
            galleryChangeTableCellStyleItem1,
            changeTableBorderLineStyleItem1,
            changeTableBorderLineWeightItem1,
            changeTableBorderColorItem1,
            changeTableBordersItem1,
            toggleTableCellsBottomBorderItem1,
            toggleTableCellsTopBorderItem1,
            toggleTableCellsLeftBorderItem1,
            toggleTableCellsRightBorderItem1,
            resetTableCellsAllBordersItem1,
            toggleTableCellsAllBordersItem1,
            toggleTableCellsOutsideBorderItem1,
            toggleTableCellsInsideBorderItem1,
            toggleTableCellsInsideHorizontalBorderItem1,
            toggleTableCellsInsideVerticalBorderItem1,
            toggleShowTableGridLinesItem1,
            changeTableCellsShadingItem1,
            selectTableElementsItem1,
            selectTableCellItem1,
            selectTableColumnItem1,
            selectTableRowItem1,
            selectTableItem1,
            showTablePropertiesFormItem1,
            deleteTableElementsItem1,
            showDeleteTableCellsFormItem1,
            deleteTableColumnsItem1,
            deleteTableRowsItem1,
            deleteTableItem1,
            insertTableRowAboveItem1,
            insertTableRowBelowItem1,
            insertTableColumnToLeftItem1,
            insertTableColumnToRightItem1,
            mergeTableCellsItem1,
            showSplitTableCellsForm1,
            splitTableItem1,
            toggleTableAutoFitItem1,
            toggleTableAutoFitContentsItem1,
            toggleTableAutoFitWindowItem1,
            toggleTableFixedColumnWidthItem1,
            toggleTableCellsTopLeftAlignmentItem1,
            toggleTableCellsMiddleLeftAlignmentItem1,
            toggleTableCellsBottomLeftAlignmentItem1,
            toggleTableCellsTopCenterAlignmentItem1,
            toggleTableCellsMiddleCenterAlignmentItem1,
            toggleTableCellsBottomCenterAlignmentItem1,
            toggleTableCellsTopRightAlignmentItem1,
            toggleTableCellsMiddleRightAlignmentItem1,
            toggleTableCellsBottomRightAlignmentItem1,
            showTableOptionsFormItem1,
            checkSpellingItem1,
            insertTableOfContentsItem1,
            updateTableOfContentsItem1,
            addParagraphsToTableOfContentItem1,
            setParagraphHeadingLevelItem1,
            setParagraphHeadingLevelItem2,
            setParagraphHeadingLevelItem3,
            setParagraphHeadingLevelItem4,
            setParagraphHeadingLevelItem5,
            setParagraphHeadingLevelItem6,
            setParagraphHeadingLevelItem7,
            setParagraphHeadingLevelItem8,
            setParagraphHeadingLevelItem9,
            setParagraphHeadingLevelItem10,
            insertCaptionPlaceholderItem1,
            insertFiguresCaptionItems1,
            insertTablesCaptionItems1,
            insertEquationsCaptionItems1,
            insertTableOfFiguresPlaceholderItem1,
            insertTableOfFiguresItems1,
            insertTableOfTablesItems1,
            insertTableOfEquationsItems1,
            updateTableOfFiguresItem1,
            changeFloatingObjectFillColorItem1,
            changeFloatingObjectOutlineColorItem1,
            changeFloatingObjectOutlineWeightItem1,
            changeFloatingObjectTextWrapTypeItem1,
            setFloatingObjectSquareTextWrapTypeItem1,
            setFloatingObjectTightTextWrapTypeItem1,
            setFloatingObjectThroughTextWrapTypeItem1,
            setFloatingObjectTopAndBottomTextWrapTypeItem1,
            setFloatingObjectBehindTextWrapTypeItem1,
            setFloatingObjectInFrontOfTextWrapTypeItem1,
            changeFloatingObjectAlignmentItem1,
            setFloatingObjectTopLeftAlignmentItem1,
            setFloatingObjectTopCenterAlignmentItem1,
            setFloatingObjectTopRightAlignmentItem1,
            setFloatingObjectMiddleLeftAlignmentItem1,
            setFloatingObjectMiddleCenterAlignmentItem1,
            setFloatingObjectMiddleRightAlignmentItem1,
            setFloatingObjectBottomLeftAlignmentItem1,
            setFloatingObjectBottomCenterAlignmentItem1,
            setFloatingObjectBottomRightAlignmentItem1,
            floatingObjectBringForwardSubItem1,
            floatingObjectBringForwardItem1,
            floatingObjectBringToFrontItem1,
            floatingObjectBringInFrontOfTextItem1,
            floatingObjectSendBackwardSubItem1,
            floatingObjectSendBackwardItem1,
            floatingObjectSendToBackItem1,
            floatingObjectSendBehindTextItem1,
            themesGalleryBarItem1,
            commandBarCheckItem2,
            commandBarCheckItem3,
            commandBarCheckItem4,
            commandBarSubItem1,
            commandBarCheckItem5,
            commandBarCheckItem6,
            commandBarCheckItem7,
            commandBarCheckItem8,
            commandBarCheckItem9,
            filterPopupButtonItem1,
            propertiesBarButtonItem1,
            commandBarSubItem2,
            commandBarCheckItem10,
            commandBarCheckItem11,
            commandBarSubItem3,
            commandBarCheckItem12,
            commandBarCheckItem13,
            commandBarItem8,
            commandBarItem9,
            commandBarSubItem4,
            commandBarCheckItem14,
            commandBarCheckItem15,
            commandBarCheckItem16,
            commandBarCheckItem17,
            commandBarCheckItem18,
            commandBarCheckItem19,
            commandBarCheckItem20,
            commandBarSubItem5,
            commandBarCheckItem21,
            commandBarCheckItem22,
            commandBarSubItem6,
            commandBarCheckItem23,
            commandBarCheckItem24,
            commandBarSubItem7,
            commandBarCheckItem25,
            commandBarCheckItem26,
            commandBarCheckItem27,
            commandBarCheckItem28,
            commandBarCheckItem29,
            commandBarCheckItem30,
            commandBarCheckItem31,
            commandBarItem10,
            commandBarItem11,
            commandBarItem12,
            barButtonGroup8,
            changeEditorRowLimitItem1,
            createBarBaseItem1,
            createLineBaseItem1,
            createPieBaseItem1,
            createRotatedBarBaseItem1,
            createAreaBaseItem1,
            createOtherSeriesTypesBaseItem1,
            changePaletteGalleryBaseItem1,
            changeAppearanceGalleryBaseItem1,
            runWizardChartItem1});
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.MaxItemId = 303;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            headerFooterToolsRibbonPageCategory1,
            tableToolsRibbonPageCategory1,
            floatingPictureToolsRibbonPageCategory1,
            dataToolsRibbonPageCategory1,
            chartRibbonPageCategory1});
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            fileRibbonPage1,
            homeRibbonPage1,
            insertRibbonPage1,
            pageLayoutRibbonPage1,
            viewRibbonPage1,
            reviewRibbonPage1,
            referencesRibbonPage1});
            ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            repositoryItemFontEdit1,
            repositoryItemRichEditFontSizeEdit1,
            repositoryItemBorderLineStyle1,
            repositoryItemBorderLineWeight1,
            repositoryItemFloatingObjectOutlineWeight1,
            repositoryItemEditorRowLimitEdit1});
            ribbonControl1.Size = new System.Drawing.Size(952, 142);
            // 
            // snapBarController1
            // 
            snapBarController1.BarItems.Add(undoItem1);
            snapBarController1.BarItems.Add(redoItem1);
            snapBarController1.BarItems.Add(fileOpenItem1);
            snapBarController1.BarItems.Add(fileSaveItem1);
            snapBarController1.BarItems.Add(fileSaveAsItem1);
            snapBarController1.BarItems.Add(commandBarItem1);
            snapBarController1.BarItems.Add(quickPrintItem1);
            snapBarController1.BarItems.Add(printItem1);
            snapBarController1.BarItems.Add(printPreviewItem1);
            snapBarController1.BarItems.Add(pasteItem1);
            snapBarController1.BarItems.Add(cutItem1);
            snapBarController1.BarItems.Add(copyItem1);
            snapBarController1.BarItems.Add(pasteSpecialItem1);
            snapBarController1.BarItems.Add(changeFontNameItem1);
            snapBarController1.BarItems.Add(changeFontSizeItem1);
            snapBarController1.BarItems.Add(fontSizeIncreaseItem1);
            snapBarController1.BarItems.Add(fontSizeDecreaseItem1);
            snapBarController1.BarItems.Add(toggleFontBoldItem1);
            snapBarController1.BarItems.Add(toggleFontItalicItem1);
            snapBarController1.BarItems.Add(toggleFontUnderlineItem1);
            snapBarController1.BarItems.Add(toggleFontDoubleUnderlineItem1);
            snapBarController1.BarItems.Add(toggleFontStrikeoutItem1);
            snapBarController1.BarItems.Add(toggleFontDoubleStrikeoutItem1);
            snapBarController1.BarItems.Add(toggleFontSuperscriptItem1);
            snapBarController1.BarItems.Add(toggleFontSubscriptItem1);
            snapBarController1.BarItems.Add(changeFontColorItem1);
            snapBarController1.BarItems.Add(changeFontBackColorItem1);
            snapBarController1.BarItems.Add(changeTextCaseItem1);
            snapBarController1.BarItems.Add(makeTextUpperCaseItem1);
            snapBarController1.BarItems.Add(makeTextLowerCaseItem1);
            snapBarController1.BarItems.Add(capitalizeEachWordCaseItem1);
            snapBarController1.BarItems.Add(toggleTextCaseItem1);
            snapBarController1.BarItems.Add(clearFormattingItem1);
            snapBarController1.BarItems.Add(toggleBulletedListItem1);
            snapBarController1.BarItems.Add(toggleNumberingListItem1);
            snapBarController1.BarItems.Add(toggleMultiLevelListItem1);
            snapBarController1.BarItems.Add(decreaseIndentItem1);
            snapBarController1.BarItems.Add(increaseIndentItem1);
            snapBarController1.BarItems.Add(toggleParagraphAlignmentLeftItem1);
            snapBarController1.BarItems.Add(toggleParagraphAlignmentCenterItem1);
            snapBarController1.BarItems.Add(toggleParagraphAlignmentRightItem1);
            snapBarController1.BarItems.Add(toggleParagraphAlignmentJustifyItem1);
            snapBarController1.BarItems.Add(toggleShowWhitespaceItem1);
            snapBarController1.BarItems.Add(changeParagraphLineSpacingItem1);
            snapBarController1.BarItems.Add(setSingleParagraphSpacingItem1);
            snapBarController1.BarItems.Add(setSesquialteralParagraphSpacingItem1);
            snapBarController1.BarItems.Add(setDoubleParagraphSpacingItem1);
            snapBarController1.BarItems.Add(showLineSpacingFormItem1);
            snapBarController1.BarItems.Add(addSpacingBeforeParagraphItem1);
            snapBarController1.BarItems.Add(removeSpacingBeforeParagraphItem1);
            snapBarController1.BarItems.Add(addSpacingAfterParagraphItem1);
            snapBarController1.BarItems.Add(removeSpacingAfterParagraphItem1);
            snapBarController1.BarItems.Add(changeParagraphBackColorItem1);
            snapBarController1.BarItems.Add(galleryChangeStyleItem1);
            snapBarController1.BarItems.Add(findItem1);
            snapBarController1.BarItems.Add(replaceItem1);
            snapBarController1.BarItems.Add(insertPageBreakItem21);
            snapBarController1.BarItems.Add(insertTableItem1);
            snapBarController1.BarItems.Add(insertPictureItem1);
            snapBarController1.BarItems.Add(insertFloatingPictureItem1);
            snapBarController1.BarItems.Add(commandBarItem3);
            snapBarController1.BarItems.Add(commandBarItem4);
            snapBarController1.BarItems.Add(commandBarItem5);
            snapBarController1.BarItems.Add(commandBarItem6);
            snapBarController1.BarItems.Add(commandBarItem7);
            snapBarController1.BarItems.Add(insertBookmarkItem1);
            snapBarController1.BarItems.Add(insertHyperlinkItem1);
            snapBarController1.BarItems.Add(editPageHeaderItem1);
            snapBarController1.BarItems.Add(editPageFooterItem1);
            snapBarController1.BarItems.Add(insertPageNumberItem1);
            snapBarController1.BarItems.Add(insertPageCountItem1);
            snapBarController1.BarItems.Add(insertTextBoxItem1);
            snapBarController1.BarItems.Add(insertSymbolItem1);
            snapBarController1.BarItems.Add(changeSectionPageMarginsItem1);
            snapBarController1.BarItems.Add(setNormalSectionPageMarginsItem1);
            snapBarController1.BarItems.Add(setNarrowSectionPageMarginsItem1);
            snapBarController1.BarItems.Add(setModerateSectionPageMarginsItem1);
            snapBarController1.BarItems.Add(setWideSectionPageMarginsItem1);
            snapBarController1.BarItems.Add(showPageMarginsSetupFormItem1);
            snapBarController1.BarItems.Add(changeSectionPageOrientationItem1);
            snapBarController1.BarItems.Add(setPortraitPageOrientationItem1);
            snapBarController1.BarItems.Add(setLandscapePageOrientationItem1);
            snapBarController1.BarItems.Add(changeSectionPaperKindItem1);
            snapBarController1.BarItems.Add(changeSectionColumnsItem1);
            snapBarController1.BarItems.Add(setSectionOneColumnItem1);
            snapBarController1.BarItems.Add(setSectionTwoColumnsItem1);
            snapBarController1.BarItems.Add(setSectionThreeColumnsItem1);
            snapBarController1.BarItems.Add(showColumnsSetupFormItem1);
            snapBarController1.BarItems.Add(insertBreakItem1);
            snapBarController1.BarItems.Add(insertPageBreakItem1);
            snapBarController1.BarItems.Add(insertColumnBreakItem1);
            snapBarController1.BarItems.Add(insertSectionBreakNextPageItem1);
            snapBarController1.BarItems.Add(insertSectionBreakEvenPageItem1);
            snapBarController1.BarItems.Add(insertSectionBreakOddPageItem1);
            snapBarController1.BarItems.Add(changeSectionLineNumberingItem1);
            snapBarController1.BarItems.Add(setSectionLineNumberingNoneItem1);
            snapBarController1.BarItems.Add(setSectionLineNumberingContinuousItem1);
            snapBarController1.BarItems.Add(setSectionLineNumberingRestartNewPageItem1);
            snapBarController1.BarItems.Add(setSectionLineNumberingRestartNewSectionItem1);
            snapBarController1.BarItems.Add(toggleParagraphSuppressLineNumbersItem1);
            snapBarController1.BarItems.Add(showLineNumberingFormItem1);
            snapBarController1.BarItems.Add(changePageColorItem1);
            snapBarController1.BarItems.Add(switchToSimpleViewItem1);
            snapBarController1.BarItems.Add(switchToDraftViewItem1);
            snapBarController1.BarItems.Add(switchToPrintLayoutViewItem1);
            snapBarController1.BarItems.Add(toggleShowHorizontalRulerItem1);
            snapBarController1.BarItems.Add(toggleShowVerticalRulerItem1);
            snapBarController1.BarItems.Add(zoomOutItem1);
            snapBarController1.BarItems.Add(zoomInItem1);
            snapBarController1.BarItems.Add(snapBarToolbarsListItem1);
            snapBarController1.BarItems.Add(commandBarCheckItem1);
            snapBarController1.BarItems.Add(showAllFieldCodesItem1);
            snapBarController1.BarItems.Add(showAllFieldResultsItem1);
            snapBarController1.BarItems.Add(toggleFieldHighlightingItem1);
            snapBarController1.BarItems.Add(goToPageHeaderItem1);
            snapBarController1.BarItems.Add(goToPageFooterItem1);
            snapBarController1.BarItems.Add(goToNextHeaderFooterItem1);
            snapBarController1.BarItems.Add(goToPreviousHeaderFooterItem1);
            snapBarController1.BarItems.Add(toggleLinkToPreviousItem1);
            snapBarController1.BarItems.Add(toggleDifferentFirstPageItem1);
            snapBarController1.BarItems.Add(toggleDifferentOddAndEvenPagesItem1);
            snapBarController1.BarItems.Add(closePageHeaderFooterItem1);
            snapBarController1.BarItems.Add(toggleFirstRowItem1);
            snapBarController1.BarItems.Add(toggleLastRowItem1);
            snapBarController1.BarItems.Add(toggleBandedRowsItem1);
            snapBarController1.BarItems.Add(toggleFirstColumnItem1);
            snapBarController1.BarItems.Add(toggleLastColumnItem1);
            snapBarController1.BarItems.Add(toggleBandedColumnsItem1);
            snapBarController1.BarItems.Add(galleryChangeTableStyleItem1);
            snapBarController1.BarItems.Add(galleryChangeTableCellStyleItem1);
            snapBarController1.BarItems.Add(changeTableBorderLineStyleItem1);
            snapBarController1.BarItems.Add(changeTableBorderLineWeightItem1);
            snapBarController1.BarItems.Add(changeTableBorderColorItem1);
            snapBarController1.BarItems.Add(changeTableBordersItem1);
            snapBarController1.BarItems.Add(toggleTableCellsBottomBorderItem1);
            snapBarController1.BarItems.Add(toggleTableCellsTopBorderItem1);
            snapBarController1.BarItems.Add(toggleTableCellsLeftBorderItem1);
            snapBarController1.BarItems.Add(toggleTableCellsRightBorderItem1);
            snapBarController1.BarItems.Add(resetTableCellsAllBordersItem1);
            snapBarController1.BarItems.Add(toggleTableCellsAllBordersItem1);
            snapBarController1.BarItems.Add(toggleTableCellsOutsideBorderItem1);
            snapBarController1.BarItems.Add(toggleTableCellsInsideBorderItem1);
            snapBarController1.BarItems.Add(toggleTableCellsInsideHorizontalBorderItem1);
            snapBarController1.BarItems.Add(toggleTableCellsInsideVerticalBorderItem1);
            snapBarController1.BarItems.Add(toggleShowTableGridLinesItem1);
            snapBarController1.BarItems.Add(changeTableCellsShadingItem1);
            snapBarController1.BarItems.Add(selectTableElementsItem1);
            snapBarController1.BarItems.Add(selectTableCellItem1);
            snapBarController1.BarItems.Add(selectTableColumnItem1);
            snapBarController1.BarItems.Add(selectTableRowItem1);
            snapBarController1.BarItems.Add(selectTableItem1);
            snapBarController1.BarItems.Add(showTablePropertiesFormItem1);
            snapBarController1.BarItems.Add(deleteTableElementsItem1);
            snapBarController1.BarItems.Add(showDeleteTableCellsFormItem1);
            snapBarController1.BarItems.Add(deleteTableColumnsItem1);
            snapBarController1.BarItems.Add(deleteTableRowsItem1);
            snapBarController1.BarItems.Add(deleteTableItem1);
            snapBarController1.BarItems.Add(insertTableRowAboveItem1);
            snapBarController1.BarItems.Add(insertTableRowBelowItem1);
            snapBarController1.BarItems.Add(insertTableColumnToLeftItem1);
            snapBarController1.BarItems.Add(insertTableColumnToRightItem1);
            snapBarController1.BarItems.Add(mergeTableCellsItem1);
            snapBarController1.BarItems.Add(showSplitTableCellsForm1);
            snapBarController1.BarItems.Add(splitTableItem1);
            snapBarController1.BarItems.Add(toggleTableAutoFitItem1);
            snapBarController1.BarItems.Add(toggleTableAutoFitContentsItem1);
            snapBarController1.BarItems.Add(toggleTableAutoFitWindowItem1);
            snapBarController1.BarItems.Add(toggleTableFixedColumnWidthItem1);
            snapBarController1.BarItems.Add(toggleTableCellsTopLeftAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsMiddleLeftAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsBottomLeftAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsTopCenterAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsMiddleCenterAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsBottomCenterAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsTopRightAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsMiddleRightAlignmentItem1);
            snapBarController1.BarItems.Add(toggleTableCellsBottomRightAlignmentItem1);
            snapBarController1.BarItems.Add(showTableOptionsFormItem1);
            snapBarController1.BarItems.Add(checkSpellingItem1);
            snapBarController1.BarItems.Add(insertTableOfContentsItem1);
            snapBarController1.BarItems.Add(updateTableOfContentsItem1);
            snapBarController1.BarItems.Add(addParagraphsToTableOfContentItem1);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem1);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem2);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem3);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem4);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem5);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem6);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem7);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem8);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem9);
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem10);
            snapBarController1.BarItems.Add(insertCaptionPlaceholderItem1);
            snapBarController1.BarItems.Add(insertFiguresCaptionItems1);
            snapBarController1.BarItems.Add(insertTablesCaptionItems1);
            snapBarController1.BarItems.Add(insertEquationsCaptionItems1);
            snapBarController1.BarItems.Add(insertTableOfFiguresPlaceholderItem1);
            snapBarController1.BarItems.Add(insertTableOfFiguresItems1);
            snapBarController1.BarItems.Add(insertTableOfTablesItems1);
            snapBarController1.BarItems.Add(insertTableOfEquationsItems1);
            snapBarController1.BarItems.Add(updateTableOfFiguresItem1);
            snapBarController1.BarItems.Add(changeFloatingObjectFillColorItem1);
            snapBarController1.BarItems.Add(changeFloatingObjectOutlineColorItem1);
            snapBarController1.BarItems.Add(changeFloatingObjectOutlineWeightItem1);
            snapBarController1.BarItems.Add(changeFloatingObjectTextWrapTypeItem1);
            snapBarController1.BarItems.Add(setFloatingObjectSquareTextWrapTypeItem1);
            snapBarController1.BarItems.Add(setFloatingObjectTightTextWrapTypeItem1);
            snapBarController1.BarItems.Add(setFloatingObjectThroughTextWrapTypeItem1);
            snapBarController1.BarItems.Add(setFloatingObjectTopAndBottomTextWrapTypeItem1);
            snapBarController1.BarItems.Add(setFloatingObjectBehindTextWrapTypeItem1);
            snapBarController1.BarItems.Add(setFloatingObjectInFrontOfTextWrapTypeItem1);
            snapBarController1.BarItems.Add(changeFloatingObjectAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectTopLeftAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectTopCenterAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectTopRightAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectMiddleLeftAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectMiddleCenterAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectMiddleRightAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectBottomLeftAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectBottomCenterAlignmentItem1);
            snapBarController1.BarItems.Add(setFloatingObjectBottomRightAlignmentItem1);
            snapBarController1.BarItems.Add(floatingObjectBringForwardSubItem1);
            snapBarController1.BarItems.Add(floatingObjectBringForwardItem1);
            snapBarController1.BarItems.Add(floatingObjectBringToFrontItem1);
            snapBarController1.BarItems.Add(floatingObjectBringInFrontOfTextItem1);
            snapBarController1.BarItems.Add(floatingObjectSendBackwardSubItem1);
            snapBarController1.BarItems.Add(floatingObjectSendBackwardItem1);
            snapBarController1.BarItems.Add(floatingObjectSendToBackItem1);
            snapBarController1.BarItems.Add(floatingObjectSendBehindTextItem1);
            snapBarController1.BarItems.Add(themesGalleryBarItem1);
            snapBarController1.BarItems.Add(commandBarCheckItem2);
            snapBarController1.BarItems.Add(commandBarCheckItem3);
            snapBarController1.BarItems.Add(commandBarCheckItem4);
            snapBarController1.BarItems.Add(commandBarSubItem1);
            snapBarController1.BarItems.Add(commandBarCheckItem5);
            snapBarController1.BarItems.Add(commandBarCheckItem6);
            snapBarController1.BarItems.Add(commandBarCheckItem7);
            snapBarController1.BarItems.Add(commandBarCheckItem8);
            snapBarController1.BarItems.Add(commandBarCheckItem9);
            snapBarController1.BarItems.Add(filterPopupButtonItem1);
            snapBarController1.BarItems.Add(propertiesBarButtonItem1);
            snapBarController1.BarItems.Add(commandBarSubItem2);
            snapBarController1.BarItems.Add(commandBarCheckItem10);
            snapBarController1.BarItems.Add(commandBarCheckItem11);
            snapBarController1.BarItems.Add(commandBarSubItem3);
            snapBarController1.BarItems.Add(commandBarCheckItem12);
            snapBarController1.BarItems.Add(commandBarCheckItem13);
            snapBarController1.BarItems.Add(commandBarItem8);
            snapBarController1.BarItems.Add(commandBarItem9);
            snapBarController1.BarItems.Add(commandBarSubItem4);
            snapBarController1.BarItems.Add(commandBarCheckItem14);
            snapBarController1.BarItems.Add(commandBarCheckItem15);
            snapBarController1.BarItems.Add(commandBarCheckItem16);
            snapBarController1.BarItems.Add(commandBarCheckItem17);
            snapBarController1.BarItems.Add(commandBarCheckItem18);
            snapBarController1.BarItems.Add(commandBarCheckItem19);
            snapBarController1.BarItems.Add(commandBarCheckItem20);
            snapBarController1.BarItems.Add(commandBarSubItem5);
            snapBarController1.BarItems.Add(commandBarCheckItem21);
            snapBarController1.BarItems.Add(commandBarCheckItem22);
            snapBarController1.BarItems.Add(commandBarSubItem6);
            snapBarController1.BarItems.Add(commandBarCheckItem23);
            snapBarController1.BarItems.Add(commandBarCheckItem24);
            snapBarController1.BarItems.Add(commandBarSubItem7);
            snapBarController1.BarItems.Add(commandBarCheckItem25);
            snapBarController1.BarItems.Add(commandBarCheckItem26);
            snapBarController1.BarItems.Add(commandBarCheckItem27);
            snapBarController1.BarItems.Add(commandBarCheckItem28);
            snapBarController1.BarItems.Add(commandBarCheckItem29);
            snapBarController1.BarItems.Add(commandBarCheckItem30);
            snapBarController1.BarItems.Add(commandBarCheckItem31);
            snapBarController1.BarItems.Add(commandBarItem10);
            snapBarController1.BarItems.Add(commandBarItem11);
            snapBarController1.BarItems.Add(commandBarItem12);
            snapBarController1.BarItems.Add(changeEditorRowLimitItem1);
            snapBarController1.BarItems.Add(createBarBaseItem1);
            snapBarController1.BarItems.Add(createLineBaseItem1);
            snapBarController1.BarItems.Add(createPieBaseItem1);
            snapBarController1.BarItems.Add(createRotatedBarBaseItem1);
            snapBarController1.BarItems.Add(createAreaBaseItem1);
            snapBarController1.BarItems.Add(createOtherSeriesTypesBaseItem1);
            snapBarController1.BarItems.Add(changePaletteGalleryBaseItem1);
            snapBarController1.BarItems.Add(changeAppearanceGalleryBaseItem1);
            snapBarController1.BarItems.Add(runWizardChartItem1);
            snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(headerFooterToolsRibbonPageCategory1));
            snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(tableToolsRibbonPageCategory1));
            snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(floatingPictureToolsRibbonPageCategory1));
            snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(dataToolsRibbonPageCategory1));
            snapBarController1.ContextPageCategories.Add(new DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(chartRibbonPageCategory1));
            snapBarController1.Control = snapControl;
            snapBarController1.RibbonControl = ribbonControl1;
            snapBarController1.SnapDockManager = dockManager;
            // 
            // commonRibbonPageGroup1
            // 
            commonRibbonPageGroup1.ItemLinks.Add(undoItem1);
            commonRibbonPageGroup1.ItemLinks.Add(redoItem1);
            commonRibbonPageGroup1.ItemLinks.Add(fileOpenItem1);
            commonRibbonPageGroup1.ItemLinks.Add(fileSaveItem1);
            commonRibbonPageGroup1.ItemLinks.Add(fileSaveAsItem1);
            commonRibbonPageGroup1.ItemLinks.Add(commandBarItem1);
            commonRibbonPageGroup1.ItemLinks.Add(quickPrintItem1);
            commonRibbonPageGroup1.ItemLinks.Add(printItem1);
            commonRibbonPageGroup1.ItemLinks.Add(printPreviewItem1);
            commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // fileRibbonPage1
            // 
            fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            commonRibbonPageGroup1});
            fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // undoItem1
            // 
            undoItem1.Id = 1;
            undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            redoItem1.Id = 2;
            redoItem1.Name = "redoItem1";
            // 
            // fileOpenItem1
            // 
            fileOpenItem1.Id = 4;
            fileOpenItem1.Name = "fileOpenItem1";
            // 
            // fileSaveItem1
            // 
            fileSaveItem1.Id = 5;
            fileSaveItem1.Name = "fileSaveItem1";
            // 
            // fileSaveAsItem1
            // 
            fileSaveAsItem1.Id = 6;
            fileSaveAsItem1.Name = "fileSaveAsItem1";
            // 
            // commandBarItem1
            // 
            commandBarItem1.Id = 7;
            commandBarItem1.Name = "commandBarItem1";
            commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument;
            // 
            // quickPrintItem1
            // 
            quickPrintItem1.Id = 8;
            quickPrintItem1.Name = "quickPrintItem1";
            // 
            // printItem1
            // 
            printItem1.Id = 9;
            printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            printPreviewItem1.Id = 10;
            printPreviewItem1.Name = "printPreviewItem1";
            // 
            // clipboardRibbonPageGroup1
            // 
            clipboardRibbonPageGroup1.ItemLinks.Add(pasteItem1);
            clipboardRibbonPageGroup1.ItemLinks.Add(cutItem1);
            clipboardRibbonPageGroup1.ItemLinks.Add(copyItem1);
            clipboardRibbonPageGroup1.ItemLinks.Add(pasteSpecialItem1);
            clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1";
            // 
            // homeRibbonPage1
            // 
            homeRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            clipboardRibbonPageGroup1,
            fontRibbonPageGroup1,
            paragraphRibbonPageGroup1,
            stylesRibbonPageGroup1,
            editingRibbonPageGroup1});
            homeRibbonPage1.Name = "homeRibbonPage1";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable;
            reduceOperation1.Group = stylesRibbonPageGroup1;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            homeRibbonPage1.ReduceOperations.Add(reduceOperation1);
            // 
            // pasteItem1
            // 
            pasteItem1.Id = 19;
            pasteItem1.Name = "pasteItem1";
            // 
            // cutItem1
            // 
            cutItem1.Id = 20;
            cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            copyItem1.Id = 21;
            copyItem1.Name = "copyItem1";
            // 
            // pasteSpecialItem1
            // 
            pasteSpecialItem1.Id = 22;
            pasteSpecialItem1.Name = "pasteSpecialItem1";
            // 
            // fontRibbonPageGroup1
            // 
            fontRibbonPageGroup1.ItemLinks.Add(barButtonGroup1);
            fontRibbonPageGroup1.ItemLinks.Add(barButtonGroup2);
            fontRibbonPageGroup1.ItemLinks.Add(barButtonGroup3);
            fontRibbonPageGroup1.ItemLinks.Add(changeTextCaseItem1);
            fontRibbonPageGroup1.ItemLinks.Add(clearFormattingItem1);
            fontRibbonPageGroup1.Name = "fontRibbonPageGroup1";
            // 
            // changeFontNameItem1
            // 
            changeFontNameItem1.Edit = repositoryItemFontEdit1;
            changeFontNameItem1.Id = 23;
            changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // changeFontSizeItem1
            // 
            changeFontSizeItem1.Edit = repositoryItemRichEditFontSizeEdit1;
            changeFontSizeItem1.Id = 24;
            changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // fontSizeIncreaseItem1
            // 
            fontSizeIncreaseItem1.Id = 25;
            fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            // 
            // fontSizeDecreaseItem1
            // 
            fontSizeDecreaseItem1.Id = 26;
            fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            // 
            // toggleFontBoldItem1
            // 
            toggleFontBoldItem1.Id = 27;
            toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            // 
            // toggleFontItalicItem1
            // 
            toggleFontItalicItem1.Id = 28;
            toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            // 
            // toggleFontUnderlineItem1
            // 
            toggleFontUnderlineItem1.Id = 29;
            toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            // 
            // toggleFontDoubleUnderlineItem1
            // 
            toggleFontDoubleUnderlineItem1.Id = 30;
            toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            // 
            // toggleFontStrikeoutItem1
            // 
            toggleFontStrikeoutItem1.Id = 31;
            toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            // 
            // toggleFontDoubleStrikeoutItem1
            // 
            toggleFontDoubleStrikeoutItem1.Id = 32;
            toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            // 
            // toggleFontSuperscriptItem1
            // 
            toggleFontSuperscriptItem1.Id = 33;
            toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1";
            // 
            // toggleFontSubscriptItem1
            // 
            toggleFontSubscriptItem1.Id = 34;
            toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            // 
            // changeFontColorItem1
            // 
            changeFontColorItem1.Id = 35;
            changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // changeFontBackColorItem1
            // 
            changeFontBackColorItem1.Id = 36;
            changeFontBackColorItem1.Name = "changeFontBackColorItem1";
            // 
            // changeTextCaseItem1
            // 
            changeTextCaseItem1.Id = 37;
            changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(capitalizeEachWordCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTextCaseItem1)});
            changeTextCaseItem1.Name = "changeTextCaseItem1";
            // 
            // makeTextUpperCaseItem1
            // 
            makeTextUpperCaseItem1.Id = 38;
            makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            // 
            // makeTextLowerCaseItem1
            // 
            makeTextLowerCaseItem1.Id = 39;
            makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            // 
            // capitalizeEachWordCaseItem1
            // 
            capitalizeEachWordCaseItem1.Id = 40;
            capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1";
            // 
            // toggleTextCaseItem1
            // 
            toggleTextCaseItem1.Id = 41;
            toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            // 
            // clearFormattingItem1
            // 
            clearFormattingItem1.Id = 42;
            clearFormattingItem1.Name = "clearFormattingItem1";
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Id = 12;
            barButtonGroup1.ItemLinks.Add(changeFontNameItem1);
            barButtonGroup1.ItemLinks.Add(changeFontSizeItem1);
            barButtonGroup1.ItemLinks.Add(fontSizeIncreaseItem1);
            barButtonGroup1.ItemLinks.Add(fontSizeDecreaseItem1);
            barButtonGroup1.Name = "barButtonGroup1";
            barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            // 
            // repositoryItemFontEdit1
            // 
            repositoryItemFontEdit1.AutoHeight = false;
            repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemRichEditFontSizeEdit1.Control = snapControl;
            repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // barButtonGroup2
            // 
            barButtonGroup2.Id = 13;
            barButtonGroup2.ItemLinks.Add(toggleFontBoldItem1);
            barButtonGroup2.ItemLinks.Add(toggleFontItalicItem1);
            barButtonGroup2.ItemLinks.Add(toggleFontUnderlineItem1);
            barButtonGroup2.ItemLinks.Add(toggleFontDoubleUnderlineItem1);
            barButtonGroup2.ItemLinks.Add(toggleFontStrikeoutItem1);
            barButtonGroup2.ItemLinks.Add(toggleFontDoubleStrikeoutItem1);
            barButtonGroup2.ItemLinks.Add(toggleFontSuperscriptItem1);
            barButtonGroup2.ItemLinks.Add(toggleFontSubscriptItem1);
            barButtonGroup2.Name = "barButtonGroup2";
            barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}";
            // 
            // barButtonGroup3
            // 
            barButtonGroup3.Id = 14;
            barButtonGroup3.ItemLinks.Add(changeFontColorItem1);
            barButtonGroup3.ItemLinks.Add(changeFontBackColorItem1);
            barButtonGroup3.Name = "barButtonGroup3";
            barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}";
            // 
            // paragraphRibbonPageGroup1
            // 
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup4);
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup5);
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup6);
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup7);
            paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1";
            // 
            // toggleBulletedListItem1
            // 
            toggleBulletedListItem1.Id = 43;
            toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            // 
            // toggleNumberingListItem1
            // 
            toggleNumberingListItem1.Id = 44;
            toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            // 
            // toggleMultiLevelListItem1
            // 
            toggleMultiLevelListItem1.Id = 45;
            toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            // 
            // decreaseIndentItem1
            // 
            decreaseIndentItem1.Id = 46;
            decreaseIndentItem1.Name = "decreaseIndentItem1";
            // 
            // increaseIndentItem1
            // 
            increaseIndentItem1.Id = 47;
            increaseIndentItem1.Name = "increaseIndentItem1";
            // 
            // toggleParagraphAlignmentLeftItem1
            // 
            toggleParagraphAlignmentLeftItem1.Id = 48;
            toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            // 
            // toggleParagraphAlignmentCenterItem1
            // 
            toggleParagraphAlignmentCenterItem1.Id = 49;
            toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            // 
            // toggleParagraphAlignmentRightItem1
            // 
            toggleParagraphAlignmentRightItem1.Id = 50;
            toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            // 
            // toggleParagraphAlignmentJustifyItem1
            // 
            toggleParagraphAlignmentJustifyItem1.Id = 51;
            toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            // 
            // toggleShowWhitespaceItem1
            // 
            toggleShowWhitespaceItem1.Id = 52;
            toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            // 
            // changeParagraphLineSpacingItem1
            // 
            changeParagraphLineSpacingItem1.Id = 53;
            changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(addSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(removeSpacingAfterParagraphItem1)});
            changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            // 
            // setSingleParagraphSpacingItem1
            // 
            setSingleParagraphSpacingItem1.Id = 54;
            setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            // 
            // setSesquialteralParagraphSpacingItem1
            // 
            setSesquialteralParagraphSpacingItem1.Id = 55;
            setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            // 
            // setDoubleParagraphSpacingItem1
            // 
            setDoubleParagraphSpacingItem1.Id = 56;
            setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            // 
            // showLineSpacingFormItem1
            // 
            showLineSpacingFormItem1.Id = 57;
            showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            // 
            // addSpacingBeforeParagraphItem1
            // 
            addSpacingBeforeParagraphItem1.Id = 58;
            addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            // 
            // removeSpacingBeforeParagraphItem1
            // 
            removeSpacingBeforeParagraphItem1.Id = 59;
            removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            // 
            // addSpacingAfterParagraphItem1
            // 
            addSpacingAfterParagraphItem1.Id = 60;
            addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            // 
            // removeSpacingAfterParagraphItem1
            // 
            removeSpacingAfterParagraphItem1.Id = 61;
            removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            // 
            // changeParagraphBackColorItem1
            // 
            changeParagraphBackColorItem1.Id = 62;
            changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
            // 
            // barButtonGroup4
            // 
            barButtonGroup4.Id = 15;
            barButtonGroup4.ItemLinks.Add(toggleBulletedListItem1);
            barButtonGroup4.ItemLinks.Add(toggleNumberingListItem1);
            barButtonGroup4.ItemLinks.Add(toggleMultiLevelListItem1);
            barButtonGroup4.Name = "barButtonGroup4";
            barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}";
            // 
            // barButtonGroup5
            // 
            barButtonGroup5.Id = 16;
            barButtonGroup5.ItemLinks.Add(decreaseIndentItem1);
            barButtonGroup5.ItemLinks.Add(increaseIndentItem1);
            barButtonGroup5.ItemLinks.Add(toggleShowWhitespaceItem1);
            barButtonGroup5.Name = "barButtonGroup5";
            barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}";
            // 
            // barButtonGroup6
            // 
            barButtonGroup6.Id = 17;
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentLeftItem1);
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentCenterItem1);
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentRightItem1);
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentJustifyItem1);
            barButtonGroup6.Name = "barButtonGroup6";
            barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}";
            // 
            // barButtonGroup7
            // 
            barButtonGroup7.Id = 18;
            barButtonGroup7.ItemLinks.Add(changeParagraphLineSpacingItem1);
            barButtonGroup7.ItemLinks.Add(changeParagraphBackColorItem1);
            barButtonGroup7.Name = "barButtonGroup7";
            barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}";
            // 
            // stylesRibbonPageGroup1
            // 
            stylesRibbonPageGroup1.ItemLinks.Add(galleryChangeStyleItem1);
            stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1";
            // 
            // galleryChangeStyleItem1
            // 
            // 
            // 
            // 
            galleryChangeStyleItem1.Gallery.ColumnCount = 10;
            galleryChangeStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            galleryChangeStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            galleryChangeStyleItem1.Id = 63;
            galleryChangeStyleItem1.Name = "galleryChangeStyleItem1";
            // 
            // editingRibbonPageGroup1
            // 
            editingRibbonPageGroup1.ItemLinks.Add(findItem1);
            editingRibbonPageGroup1.ItemLinks.Add(replaceItem1);
            editingRibbonPageGroup1.Name = "editingRibbonPageGroup1";
            // 
            // findItem1
            // 
            findItem1.Id = 64;
            findItem1.Name = "findItem1";
            // 
            // replaceItem1
            // 
            replaceItem1.Id = 65;
            replaceItem1.Name = "replaceItem1";
            // 
            // pagesRibbonPageGroup1
            // 
            pagesRibbonPageGroup1.AllowTextClipping = false;
            pagesRibbonPageGroup1.ItemLinks.Add(insertPageBreakItem21);
            pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1";
            // 
            // insertRibbonPage1
            // 
            insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            pagesRibbonPageGroup1,
            tablesRibbonPageGroup1,
            illustrationsRibbonPageGroup1,
            toolboxRibbonPageGroup1,
            linksRibbonPageGroup1,
            headerFooterRibbonPageGroup1,
            textRibbonPageGroup1,
            symbolsRibbonPageGroup1});
            insertRibbonPage1.Name = "insertRibbonPage1";
            // 
            // insertPageBreakItem21
            // 
            insertPageBreakItem21.Id = 66;
            insertPageBreakItem21.Name = "insertPageBreakItem21";
            // 
            // tablesRibbonPageGroup1
            // 
            tablesRibbonPageGroup1.AllowTextClipping = false;
            tablesRibbonPageGroup1.ItemLinks.Add(insertTableItem1);
            tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            // 
            // insertTableItem1
            // 
            insertTableItem1.Id = 67;
            insertTableItem1.Name = "insertTableItem1";
            // 
            // illustrationsRibbonPageGroup1
            // 
            illustrationsRibbonPageGroup1.ItemLinks.Add(insertPictureItem1);
            illustrationsRibbonPageGroup1.ItemLinks.Add(insertFloatingPictureItem1);
            illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            // 
            // insertPictureItem1
            // 
            insertPictureItem1.Id = 68;
            insertPictureItem1.Name = "insertPictureItem1";
            // 
            // insertFloatingPictureItem1
            // 
            insertFloatingPictureItem1.Id = 69;
            insertFloatingPictureItem1.Name = "insertFloatingPictureItem1";
            // 
            // toolboxRibbonPageGroup1
            // 
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem3);
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem4);
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem5);
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem6);
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem7);
            toolboxRibbonPageGroup1.Name = "toolboxRibbonPageGroup1";
            // 
            // commandBarItem3
            // 
            commandBarItem3.Id = 70;
            commandBarItem3.Name = "commandBarItem3";
            commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertBarCode;
            // 
            // commandBarItem4
            // 
            commandBarItem4.Id = 71;
            commandBarItem4.Name = "commandBarItem4";
            commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertCheckBox;
            // 
            // commandBarItem5
            // 
            commandBarItem5.Id = 72;
            commandBarItem5.Name = "commandBarItem5";
            commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertChart;
            // 
            // commandBarItem6
            // 
            commandBarItem6.Id = 73;
            commandBarItem6.Name = "commandBarItem6";
            commandBarItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSparkline;
            // 
            // commandBarItem7
            // 
            commandBarItem7.Id = 74;
            commandBarItem7.Name = "commandBarItem7";
            commandBarItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertIndex;
            // 
            // linksRibbonPageGroup1
            // 
            linksRibbonPageGroup1.ItemLinks.Add(insertBookmarkItem1);
            linksRibbonPageGroup1.ItemLinks.Add(insertHyperlinkItem1);
            linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            // 
            // insertBookmarkItem1
            // 
            insertBookmarkItem1.Id = 75;
            insertBookmarkItem1.Name = "insertBookmarkItem1";
            // 
            // insertHyperlinkItem1
            // 
            insertHyperlinkItem1.Id = 76;
            insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            // 
            // headerFooterRibbonPageGroup1
            // 
            headerFooterRibbonPageGroup1.ItemLinks.Add(editPageHeaderItem1);
            headerFooterRibbonPageGroup1.ItemLinks.Add(editPageFooterItem1);
            headerFooterRibbonPageGroup1.ItemLinks.Add(insertPageNumberItem1);
            headerFooterRibbonPageGroup1.ItemLinks.Add(insertPageCountItem1);
            headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1";
            // 
            // editPageHeaderItem1
            // 
            editPageHeaderItem1.Id = 77;
            editPageHeaderItem1.Name = "editPageHeaderItem1";
            // 
            // editPageFooterItem1
            // 
            editPageFooterItem1.Id = 78;
            editPageFooterItem1.Name = "editPageFooterItem1";
            // 
            // insertPageNumberItem1
            // 
            insertPageNumberItem1.Id = 79;
            insertPageNumberItem1.Name = "insertPageNumberItem1";
            // 
            // insertPageCountItem1
            // 
            insertPageCountItem1.Id = 80;
            insertPageCountItem1.Name = "insertPageCountItem1";
            // 
            // textRibbonPageGroup1
            // 
            textRibbonPageGroup1.ItemLinks.Add(insertTextBoxItem1);
            textRibbonPageGroup1.Name = "textRibbonPageGroup1";
            // 
            // insertTextBoxItem1
            // 
            insertTextBoxItem1.Id = 81;
            insertTextBoxItem1.Name = "insertTextBoxItem1";
            // 
            // symbolsRibbonPageGroup1
            // 
            symbolsRibbonPageGroup1.AllowTextClipping = false;
            symbolsRibbonPageGroup1.ItemLinks.Add(insertSymbolItem1);
            symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1";
            // 
            // insertSymbolItem1
            // 
            insertSymbolItem1.Id = 82;
            insertSymbolItem1.Name = "insertSymbolItem1";
            // 
            // pageSetupRibbonPageGroup1
            // 
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionPageMarginsItem1);
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionPageOrientationItem1);
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionPaperKindItem1);
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionColumnsItem1);
            pageSetupRibbonPageGroup1.ItemLinks.Add(insertBreakItem1);
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionLineNumberingItem1);
            pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1";
            // 
            // pageLayoutRibbonPage1
            // 
            pageLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            pageSetupRibbonPageGroup1,
            pageBackgroundRibbonPageGroup1});
            pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1";
            // 
            // changeSectionPageMarginsItem1
            // 
            changeSectionPageMarginsItem1.Id = 83;
            changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setNormalSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setNarrowSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setModerateSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setWideSectionPageMarginsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(showPageMarginsSetupFormItem1, true)});
            changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1";
            // 
            // setNormalSectionPageMarginsItem1
            // 
            setNormalSectionPageMarginsItem1.Id = 84;
            setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1";
            // 
            // setNarrowSectionPageMarginsItem1
            // 
            setNarrowSectionPageMarginsItem1.Id = 85;
            setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1";
            // 
            // setModerateSectionPageMarginsItem1
            // 
            setModerateSectionPageMarginsItem1.Id = 86;
            setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1";
            // 
            // setWideSectionPageMarginsItem1
            // 
            setWideSectionPageMarginsItem1.Id = 87;
            setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1";
            // 
            // showPageMarginsSetupFormItem1
            // 
            showPageMarginsSetupFormItem1.Id = 88;
            showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1";
            // 
            // changeSectionPageOrientationItem1
            // 
            changeSectionPageOrientationItem1.Id = 89;
            changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setPortraitPageOrientationItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setLandscapePageOrientationItem1)});
            changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1";
            // 
            // setPortraitPageOrientationItem1
            // 
            setPortraitPageOrientationItem1.Id = 90;
            setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1";
            // 
            // setLandscapePageOrientationItem1
            // 
            setLandscapePageOrientationItem1.Id = 91;
            setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1";
            // 
            // changeSectionPaperKindItem1
            // 
            changeSectionPaperKindItem1.Id = 92;
            changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1";
            // 
            // changeSectionColumnsItem1
            // 
            changeSectionColumnsItem1.Id = 93;
            changeSectionColumnsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setSectionOneColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setSectionTwoColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setSectionThreeColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(showColumnsSetupFormItem1, true)});
            changeSectionColumnsItem1.Name = "changeSectionColumnsItem1";
            // 
            // setSectionOneColumnItem1
            // 
            setSectionOneColumnItem1.Id = 94;
            setSectionOneColumnItem1.Name = "setSectionOneColumnItem1";
            // 
            // setSectionTwoColumnsItem1
            // 
            setSectionTwoColumnsItem1.Id = 95;
            setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1";
            // 
            // setSectionThreeColumnsItem1
            // 
            setSectionThreeColumnsItem1.Id = 96;
            setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1";
            // 
            // showColumnsSetupFormItem1
            // 
            showColumnsSetupFormItem1.Id = 97;
            showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1";
            // 
            // insertBreakItem1
            // 
            insertBreakItem1.Id = 98;
            insertBreakItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(insertPageBreakItem1),
            new DevExpress.XtraBars.LinkPersistInfo(insertColumnBreakItem1),
            new DevExpress.XtraBars.LinkPersistInfo(insertSectionBreakNextPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(insertSectionBreakEvenPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(insertSectionBreakOddPageItem1)});
            insertBreakItem1.Name = "insertBreakItem1";
            // 
            // insertPageBreakItem1
            // 
            insertPageBreakItem1.Id = 99;
            insertPageBreakItem1.Name = "insertPageBreakItem1";
            // 
            // insertColumnBreakItem1
            // 
            insertColumnBreakItem1.Id = 100;
            insertColumnBreakItem1.Name = "insertColumnBreakItem1";
            // 
            // insertSectionBreakNextPageItem1
            // 
            insertSectionBreakNextPageItem1.Id = 101;
            insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1";
            // 
            // insertSectionBreakEvenPageItem1
            // 
            insertSectionBreakEvenPageItem1.Id = 102;
            insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1";
            // 
            // insertSectionBreakOddPageItem1
            // 
            insertSectionBreakOddPageItem1.Id = 103;
            insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1";
            // 
            // changeSectionLineNumberingItem1
            // 
            changeSectionLineNumberingItem1.Id = 104;
            changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingNoneItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingContinuousItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingRestartNewPageItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingRestartNewSectionItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleParagraphSuppressLineNumbersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(showLineNumberingFormItem1, true)});
            changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1";
            // 
            // setSectionLineNumberingNoneItem1
            // 
            setSectionLineNumberingNoneItem1.Id = 105;
            setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1";
            // 
            // setSectionLineNumberingContinuousItem1
            // 
            setSectionLineNumberingContinuousItem1.Id = 106;
            setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1";
            // 
            // setSectionLineNumberingRestartNewPageItem1
            // 
            setSectionLineNumberingRestartNewPageItem1.Id = 107;
            setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1";
            // 
            // setSectionLineNumberingRestartNewSectionItem1
            // 
            setSectionLineNumberingRestartNewSectionItem1.Id = 108;
            setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1";
            // 
            // toggleParagraphSuppressLineNumbersItem1
            // 
            toggleParagraphSuppressLineNumbersItem1.Id = 109;
            toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1";
            // 
            // showLineNumberingFormItem1
            // 
            showLineNumberingFormItem1.Id = 110;
            showLineNumberingFormItem1.Name = "showLineNumberingFormItem1";
            // 
            // pageBackgroundRibbonPageGroup1
            // 
            pageBackgroundRibbonPageGroup1.AllowTextClipping = false;
            pageBackgroundRibbonPageGroup1.ItemLinks.Add(changePageColorItem1);
            pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1";
            // 
            // changePageColorItem1
            // 
            changePageColorItem1.Id = 111;
            changePageColorItem1.Name = "changePageColorItem1";
            // 
            // documentViewsRibbonPageGroup1
            // 
            documentViewsRibbonPageGroup1.ItemLinks.Add(switchToSimpleViewItem1);
            documentViewsRibbonPageGroup1.ItemLinks.Add(switchToDraftViewItem1);
            documentViewsRibbonPageGroup1.ItemLinks.Add(switchToPrintLayoutViewItem1);
            documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1";
            // 
            // viewRibbonPage1
            // 
            viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            documentViewsRibbonPageGroup1,
            showRibbonPageGroup1,
            zoomRibbonPageGroup1,
            viewRibbonPageGroup1,
            viewFieldsRibbonPageGroup1});
            viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // switchToSimpleViewItem1
            // 
            switchToSimpleViewItem1.Id = 112;
            switchToSimpleViewItem1.Name = "switchToSimpleViewItem1";
            // 
            // switchToDraftViewItem1
            // 
            switchToDraftViewItem1.Id = 113;
            switchToDraftViewItem1.Name = "switchToDraftViewItem1";
            // 
            // switchToPrintLayoutViewItem1
            // 
            switchToPrintLayoutViewItem1.Id = 114;
            switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1";
            // 
            // showRibbonPageGroup1
            // 
            showRibbonPageGroup1.ItemLinks.Add(toggleShowHorizontalRulerItem1);
            showRibbonPageGroup1.ItemLinks.Add(toggleShowVerticalRulerItem1);
            showRibbonPageGroup1.Name = "showRibbonPageGroup1";
            // 
            // toggleShowHorizontalRulerItem1
            // 
            toggleShowHorizontalRulerItem1.Id = 115;
            toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1";
            // 
            // toggleShowVerticalRulerItem1
            // 
            toggleShowVerticalRulerItem1.Id = 116;
            toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1";
            // 
            // zoomRibbonPageGroup1
            // 
            zoomRibbonPageGroup1.ItemLinks.Add(zoomOutItem1);
            zoomRibbonPageGroup1.ItemLinks.Add(zoomInItem1);
            zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1";
            // 
            // zoomOutItem1
            // 
            zoomOutItem1.Id = 117;
            zoomOutItem1.Name = "zoomOutItem1";
            // 
            // zoomInItem1
            // 
            zoomInItem1.Id = 118;
            zoomInItem1.Name = "zoomInItem1";
            // 
            // viewRibbonPageGroup1
            // 
            viewRibbonPageGroup1.ItemLinks.Add(snapBarToolbarsListItem1);
            viewRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem1);
            viewRibbonPageGroup1.Name = "viewRibbonPageGroup1";
            // 
            // snapBarToolbarsListItem1
            // 
            snapBarToolbarsListItem1.Caption = "&Windows";
            snapBarToolbarsListItem1.Hint = "Show or hide the Data Explorer and Report Explorer windows.";
            snapBarToolbarsListItem1.Id = 119;
            snapBarToolbarsListItem1.Name = "snapBarToolbarsListItem1";
            snapBarToolbarsListItem1.ShowCustomizationItem = false;
            snapBarToolbarsListItem1.ShowDockPanels = true;
            snapBarToolbarsListItem1.ShowToolbars = false;
            // 
            // commandBarCheckItem1
            // 
            commandBarCheckItem1.Id = 120;
            commandBarCheckItem1.Name = "commandBarCheckItem1";
            commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.HighlightActiveElement;
            // 
            // viewFieldsRibbonPageGroup1
            // 
            viewFieldsRibbonPageGroup1.ItemLinks.Add(showAllFieldCodesItem1);
            viewFieldsRibbonPageGroup1.ItemLinks.Add(showAllFieldResultsItem1);
            viewFieldsRibbonPageGroup1.ItemLinks.Add(toggleFieldHighlightingItem1);
            viewFieldsRibbonPageGroup1.Name = "viewFieldsRibbonPageGroup1";
            // 
            // showAllFieldCodesItem1
            // 
            showAllFieldCodesItem1.Id = 121;
            showAllFieldCodesItem1.Name = "showAllFieldCodesItem1";
            // 
            // showAllFieldResultsItem1
            // 
            showAllFieldResultsItem1.Id = 122;
            showAllFieldResultsItem1.Name = "showAllFieldResultsItem1";
            // 
            // toggleFieldHighlightingItem1
            // 
            toggleFieldHighlightingItem1.Id = 123;
            toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1";
            // 
            // headerFooterToolsDesignNavigationRibbonPageGroup1
            // 
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToPageHeaderItem1);
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToPageFooterItem1);
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToNextHeaderFooterItem1);
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToPreviousHeaderFooterItem1);
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(toggleLinkToPreviousItem1);
            headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1";
            // 
            // headerFooterToolsDesignRibbonPage1
            // 
            headerFooterToolsDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            headerFooterToolsDesignNavigationRibbonPageGroup1,
            headerFooterToolsDesignOptionsRibbonPageGroup1,
            headerFooterToolsDesignCloseRibbonPageGroup1});
            headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1";
            // 
            // headerFooterToolsRibbonPageCategory1
            // 
            headerFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(176)))), ((int)(((byte)(35)))));
            headerFooterToolsRibbonPageCategory1.Control = snapControl;
            headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1";
            headerFooterToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            headerFooterToolsDesignRibbonPage1});
            // 
            // goToPageHeaderItem1
            // 
            goToPageHeaderItem1.Id = 124;
            goToPageHeaderItem1.Name = "goToPageHeaderItem1";
            // 
            // goToPageFooterItem1
            // 
            goToPageFooterItem1.Id = 125;
            goToPageFooterItem1.Name = "goToPageFooterItem1";
            // 
            // goToNextHeaderFooterItem1
            // 
            goToNextHeaderFooterItem1.Id = 126;
            goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1";
            // 
            // goToPreviousHeaderFooterItem1
            // 
            goToPreviousHeaderFooterItem1.Id = 127;
            goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1";
            // 
            // toggleLinkToPreviousItem1
            // 
            toggleLinkToPreviousItem1.Id = 128;
            toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1";
            // 
            // headerFooterToolsDesignOptionsRibbonPageGroup1
            // 
            headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(toggleDifferentFirstPageItem1);
            headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(toggleDifferentOddAndEvenPagesItem1);
            headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1";
            // 
            // toggleDifferentFirstPageItem1
            // 
            toggleDifferentFirstPageItem1.Id = 129;
            toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1";
            // 
            // toggleDifferentOddAndEvenPagesItem1
            // 
            toggleDifferentOddAndEvenPagesItem1.Id = 130;
            toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1";
            // 
            // headerFooterToolsDesignCloseRibbonPageGroup1
            // 
            headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(closePageHeaderFooterItem1);
            headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1";
            // 
            // closePageHeaderFooterItem1
            // 
            closePageHeaderFooterItem1.Id = 131;
            closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1";
            // 
            // tableStyleOptionsRibbonPageGroup1
            // 
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleFirstRowItem1);
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleLastRowItem1);
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleBandedRowsItem1);
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleFirstColumnItem1);
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleLastColumnItem1);
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleBandedColumnsItem1);
            tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1";
            // 
            // tableDesignRibbonPage1
            // 
            tableDesignRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            tableStyleOptionsRibbonPageGroup1,
            tableStylesRibbonPageGroup1,
            tableCellStylesRibbonPageGroup1,
            tableDrawBordersRibbonPageGroup1});
            tableDesignRibbonPage1.Name = "tableDesignRibbonPage1";
            // 
            // tableToolsRibbonPageCategory1
            // 
            tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(20)))));
            tableToolsRibbonPageCategory1.Control = snapControl;
            tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1";
            tableToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            tableDesignRibbonPage1,
            tableLayoutRibbonPage1});
            // 
            // toggleFirstRowItem1
            // 
            toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            toggleFirstRowItem1.Id = 132;
            toggleFirstRowItem1.Name = "toggleFirstRowItem1";
            // 
            // toggleLastRowItem1
            // 
            toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            toggleLastRowItem1.Id = 133;
            toggleLastRowItem1.Name = "toggleLastRowItem1";
            // 
            // toggleBandedRowsItem1
            // 
            toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            toggleBandedRowsItem1.Id = 134;
            toggleBandedRowsItem1.Name = "toggleBandedRowsItem1";
            // 
            // toggleFirstColumnItem1
            // 
            toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            toggleFirstColumnItem1.Id = 135;
            toggleFirstColumnItem1.Name = "toggleFirstColumnItem1";
            // 
            // toggleLastColumnItem1
            // 
            toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            toggleLastColumnItem1.Id = 136;
            toggleLastColumnItem1.Name = "toggleLastColumnItem1";
            // 
            // toggleBandedColumnsItem1
            // 
            toggleBandedColumnsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            toggleBandedColumnsItem1.Id = 137;
            toggleBandedColumnsItem1.Name = "toggleBandedColumnsItem1";
            // 
            // tableStylesRibbonPageGroup1
            // 
            tableStylesRibbonPageGroup1.ItemLinks.Add(galleryChangeTableStyleItem1);
            tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1";
            // 
            // galleryChangeTableStyleItem1
            // 
            galleryChangeTableStyleItem1.CurrentItem = null;
            galleryChangeTableStyleItem1.CurrentItemStyle = null;
            galleryChangeTableStyleItem1.CurrentStyle = null;
            galleryChangeTableStyleItem1.DeleteItemLink = null;
            // 
            // 
            // 
            galleryChangeTableStyleItem1.Gallery.ColumnCount = 3;
            galleryChangeTableStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            galleryChangeTableStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            galleryChangeTableStyleItem1.Id = 138;
            galleryChangeTableStyleItem1.ModifyItemLink = null;
            galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1";
            galleryChangeTableStyleItem1.NewItemLink = null;
            galleryChangeTableStyleItem1.PopupGallery = null;
            // 
            // tableCellStylesRibbonPageGroup1
            // 
            tableCellStylesRibbonPageGroup1.ItemLinks.Add(galleryChangeTableCellStyleItem1);
            tableCellStylesRibbonPageGroup1.Name = "tableCellStylesRibbonPageGroup1";
            // 
            // galleryChangeTableCellStyleItem1
            // 
            galleryChangeTableCellStyleItem1.CurrentCellStyle = null;
            galleryChangeTableCellStyleItem1.CurrentItem = null;
            galleryChangeTableCellStyleItem1.CurrentItemCellStyle = null;
            galleryChangeTableCellStyleItem1.DeleteItemLink = null;
            // 
            // 
            // 
            galleryChangeTableCellStyleItem1.Gallery.ColumnCount = 3;
            galleryChangeTableCellStyleItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            galleryChangeTableCellStyleItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            galleryChangeTableCellStyleItem1.Id = 139;
            galleryChangeTableCellStyleItem1.ModifyItemLink = null;
            galleryChangeTableCellStyleItem1.Name = "galleryChangeTableCellStyleItem1";
            galleryChangeTableCellStyleItem1.NewItemLink = null;
            galleryChangeTableCellStyleItem1.PopupGallery = null;
            // 
            // tableDrawBordersRibbonPageGroup1
            // 
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBorderLineStyleItem1);
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBorderLineWeightItem1);
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBorderColorItem1);
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBordersItem1);
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableCellsShadingItem1);
            tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1";
            // 
            // changeTableBorderLineStyleItem1
            // 
            changeTableBorderLineStyleItem1.Edit = repositoryItemBorderLineStyle1;
            borderInfo1.Color = System.Drawing.Color.Black;
            borderInfo1.Frame = false;
            borderInfo1.Offset = 0;
            borderInfo1.Shadow = false;
            borderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single;
            borderInfo1.Width = 10;
            changeTableBorderLineStyleItem1.EditValue = borderInfo1;
            changeTableBorderLineStyleItem1.Id = 140;
            changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1";
            // 
            // changeTableBorderLineWeightItem1
            // 
            changeTableBorderLineWeightItem1.Edit = repositoryItemBorderLineWeight1;
            changeTableBorderLineWeightItem1.EditValue = 20;
            changeTableBorderLineWeightItem1.Id = 141;
            changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1";
            // 
            // changeTableBorderColorItem1
            // 
            changeTableBorderColorItem1.Id = 142;
            changeTableBorderColorItem1.Name = "changeTableBorderColorItem1";
            // 
            // changeTableBordersItem1
            // 
            changeTableBordersItem1.Id = 143;
            changeTableBordersItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsBottomBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsTopBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsLeftBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsRightBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(resetTableCellsAllBordersItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsAllBordersItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsOutsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideHorizontalBorderItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideVerticalBorderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleShowTableGridLinesItem1, true)});
            changeTableBordersItem1.Name = "changeTableBordersItem1";
            // 
            // toggleTableCellsBottomBorderItem1
            // 
            toggleTableCellsBottomBorderItem1.Id = 144;
            toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1";
            // 
            // toggleTableCellsTopBorderItem1
            // 
            toggleTableCellsTopBorderItem1.Id = 145;
            toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1";
            // 
            // toggleTableCellsLeftBorderItem1
            // 
            toggleTableCellsLeftBorderItem1.Id = 146;
            toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1";
            // 
            // toggleTableCellsRightBorderItem1
            // 
            toggleTableCellsRightBorderItem1.Id = 147;
            toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1";
            // 
            // resetTableCellsAllBordersItem1
            // 
            resetTableCellsAllBordersItem1.Id = 148;
            resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1";
            // 
            // toggleTableCellsAllBordersItem1
            // 
            toggleTableCellsAllBordersItem1.Id = 149;
            toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1";
            // 
            // toggleTableCellsOutsideBorderItem1
            // 
            toggleTableCellsOutsideBorderItem1.Id = 150;
            toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1";
            // 
            // toggleTableCellsInsideBorderItem1
            // 
            toggleTableCellsInsideBorderItem1.Id = 151;
            toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1";
            // 
            // toggleTableCellsInsideHorizontalBorderItem1
            // 
            toggleTableCellsInsideHorizontalBorderItem1.Id = 152;
            toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1";
            // 
            // toggleTableCellsInsideVerticalBorderItem1
            // 
            toggleTableCellsInsideVerticalBorderItem1.Id = 153;
            toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1";
            // 
            // toggleShowTableGridLinesItem1
            // 
            toggleShowTableGridLinesItem1.Id = 154;
            toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1";
            // 
            // changeTableCellsShadingItem1
            // 
            changeTableCellsShadingItem1.Id = 155;
            changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1";
            // 
            // repositoryItemBorderLineStyle1
            // 
            repositoryItemBorderLineStyle1.AutoHeight = false;
            repositoryItemBorderLineStyle1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemBorderLineStyle1.Control = snapControl;
            repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1";
            // 
            // repositoryItemBorderLineWeight1
            // 
            repositoryItemBorderLineWeight1.AutoHeight = false;
            repositoryItemBorderLineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemBorderLineWeight1.Control = snapControl;
            repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1";
            // 
            // tableTableRibbonPageGroup1
            // 
            tableTableRibbonPageGroup1.ItemLinks.Add(selectTableElementsItem1);
            tableTableRibbonPageGroup1.ItemLinks.Add(toggleShowTableGridLinesItem1);
            tableTableRibbonPageGroup1.ItemLinks.Add(showTablePropertiesFormItem1);
            tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1";
            // 
            // tableLayoutRibbonPage1
            // 
            tableLayoutRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            tableTableRibbonPageGroup1,
            tableRowsAndColumnsRibbonPageGroup1,
            tableMergeRibbonPageGroup1,
            tableCellSizeRibbonPageGroup1,
            tableAlignmentRibbonPageGroup1});
            tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1";
            // 
            // selectTableElementsItem1
            // 
            selectTableElementsItem1.Id = 156;
            selectTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(selectTableCellItem1),
            new DevExpress.XtraBars.LinkPersistInfo(selectTableColumnItem1),
            new DevExpress.XtraBars.LinkPersistInfo(selectTableRowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(selectTableItem1)});
            selectTableElementsItem1.Name = "selectTableElementsItem1";
            // 
            // selectTableCellItem1
            // 
            selectTableCellItem1.Id = 157;
            selectTableCellItem1.Name = "selectTableCellItem1";
            // 
            // selectTableColumnItem1
            // 
            selectTableColumnItem1.Id = 158;
            selectTableColumnItem1.Name = "selectTableColumnItem1";
            // 
            // selectTableRowItem1
            // 
            selectTableRowItem1.Id = 159;
            selectTableRowItem1.Name = "selectTableRowItem1";
            // 
            // selectTableItem1
            // 
            selectTableItem1.Id = 160;
            selectTableItem1.Name = "selectTableItem1";
            // 
            // showTablePropertiesFormItem1
            // 
            showTablePropertiesFormItem1.Id = 161;
            showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1";
            // 
            // tableRowsAndColumnsRibbonPageGroup1
            // 
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(deleteTableElementsItem1);
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableRowAboveItem1);
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableRowBelowItem1);
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableColumnToLeftItem1);
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableColumnToRightItem1);
            tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1";
            // 
            // deleteTableElementsItem1
            // 
            deleteTableElementsItem1.Id = 162;
            deleteTableElementsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(showDeleteTableCellsFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(deleteTableColumnsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(deleteTableRowsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(deleteTableItem1)});
            deleteTableElementsItem1.Name = "deleteTableElementsItem1";
            // 
            // showDeleteTableCellsFormItem1
            // 
            showDeleteTableCellsFormItem1.Id = 163;
            showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1";
            // 
            // deleteTableColumnsItem1
            // 
            deleteTableColumnsItem1.Id = 164;
            deleteTableColumnsItem1.Name = "deleteTableColumnsItem1";
            // 
            // deleteTableRowsItem1
            // 
            deleteTableRowsItem1.Id = 165;
            deleteTableRowsItem1.Name = "deleteTableRowsItem1";
            // 
            // deleteTableItem1
            // 
            deleteTableItem1.Id = 166;
            deleteTableItem1.Name = "deleteTableItem1";
            // 
            // insertTableRowAboveItem1
            // 
            insertTableRowAboveItem1.Id = 167;
            insertTableRowAboveItem1.Name = "insertTableRowAboveItem1";
            // 
            // insertTableRowBelowItem1
            // 
            insertTableRowBelowItem1.Id = 168;
            insertTableRowBelowItem1.Name = "insertTableRowBelowItem1";
            // 
            // insertTableColumnToLeftItem1
            // 
            insertTableColumnToLeftItem1.Id = 169;
            insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1";
            // 
            // insertTableColumnToRightItem1
            // 
            insertTableColumnToRightItem1.Id = 170;
            insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1";
            // 
            // tableMergeRibbonPageGroup1
            // 
            tableMergeRibbonPageGroup1.ItemLinks.Add(mergeTableCellsItem1);
            tableMergeRibbonPageGroup1.ItemLinks.Add(showSplitTableCellsForm1);
            tableMergeRibbonPageGroup1.ItemLinks.Add(splitTableItem1);
            tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1";
            // 
            // mergeTableCellsItem1
            // 
            mergeTableCellsItem1.Id = 171;
            mergeTableCellsItem1.Name = "mergeTableCellsItem1";
            // 
            // showSplitTableCellsForm1
            // 
            showSplitTableCellsForm1.Id = 172;
            showSplitTableCellsForm1.Name = "showSplitTableCellsForm1";
            // 
            // splitTableItem1
            // 
            splitTableItem1.Id = 173;
            splitTableItem1.Name = "splitTableItem1";
            // 
            // tableCellSizeRibbonPageGroup1
            // 
            tableCellSizeRibbonPageGroup1.AllowTextClipping = false;
            tableCellSizeRibbonPageGroup1.ItemLinks.Add(toggleTableAutoFitItem1);
            tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1";
            // 
            // toggleTableAutoFitItem1
            // 
            toggleTableAutoFitItem1.Id = 174;
            toggleTableAutoFitItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableAutoFitContentsItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableAutoFitWindowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(toggleTableFixedColumnWidthItem1)});
            toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1";
            // 
            // toggleTableAutoFitContentsItem1
            // 
            toggleTableAutoFitContentsItem1.Id = 175;
            toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1";
            // 
            // toggleTableAutoFitWindowItem1
            // 
            toggleTableAutoFitWindowItem1.Id = 176;
            toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1";
            // 
            // toggleTableFixedColumnWidthItem1
            // 
            toggleTableFixedColumnWidthItem1.Id = 177;
            toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1";
            // 
            // tableAlignmentRibbonPageGroup1
            // 
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsTopLeftAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsMiddleLeftAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsBottomLeftAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsTopCenterAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsMiddleCenterAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsBottomCenterAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsTopRightAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsMiddleRightAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsBottomRightAlignmentItem1);
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(showTableOptionsFormItem1);
            tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1";
            // 
            // toggleTableCellsTopLeftAlignmentItem1
            // 
            toggleTableCellsTopLeftAlignmentItem1.Id = 178;
            toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1";
            // 
            // toggleTableCellsMiddleLeftAlignmentItem1
            // 
            toggleTableCellsMiddleLeftAlignmentItem1.Id = 179;
            toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1";
            // 
            // toggleTableCellsBottomLeftAlignmentItem1
            // 
            toggleTableCellsBottomLeftAlignmentItem1.Id = 180;
            toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1";
            // 
            // toggleTableCellsTopCenterAlignmentItem1
            // 
            toggleTableCellsTopCenterAlignmentItem1.Id = 181;
            toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1";
            // 
            // toggleTableCellsMiddleCenterAlignmentItem1
            // 
            toggleTableCellsMiddleCenterAlignmentItem1.Id = 182;
            toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1";
            // 
            // toggleTableCellsBottomCenterAlignmentItem1
            // 
            toggleTableCellsBottomCenterAlignmentItem1.Id = 183;
            toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1";
            // 
            // toggleTableCellsTopRightAlignmentItem1
            // 
            toggleTableCellsTopRightAlignmentItem1.Id = 184;
            toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1";
            // 
            // toggleTableCellsMiddleRightAlignmentItem1
            // 
            toggleTableCellsMiddleRightAlignmentItem1.Id = 185;
            toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1";
            // 
            // toggleTableCellsBottomRightAlignmentItem1
            // 
            toggleTableCellsBottomRightAlignmentItem1.Id = 186;
            toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1";
            // 
            // showTableOptionsFormItem1
            // 
            showTableOptionsFormItem1.Id = 187;
            showTableOptionsFormItem1.Name = "showTableOptionsFormItem1";
            // 
            // documentProofingRibbonPageGroup1
            // 
            documentProofingRibbonPageGroup1.ItemLinks.Add(checkSpellingItem1);
            documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1";
            // 
            // reviewRibbonPage1
            // 
            reviewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            documentProofingRibbonPageGroup1});
            reviewRibbonPage1.Name = "reviewRibbonPage1";
            // 
            // checkSpellingItem1
            // 
            checkSpellingItem1.Id = 188;
            checkSpellingItem1.Name = "checkSpellingItem1";
            // 
            // tableOfContentsRibbonPageGroup1
            // 
            tableOfContentsRibbonPageGroup1.ItemLinks.Add(insertTableOfContentsItem1);
            tableOfContentsRibbonPageGroup1.ItemLinks.Add(updateTableOfContentsItem1);
            tableOfContentsRibbonPageGroup1.ItemLinks.Add(addParagraphsToTableOfContentItem1);
            tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1";
            // 
            // referencesRibbonPage1
            // 
            referencesRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            tableOfContentsRibbonPageGroup1,
            captionsRibbonPageGroup1});
            referencesRibbonPage1.Name = "referencesRibbonPage1";
            // 
            // insertTableOfContentsItem1
            // 
            insertTableOfContentsItem1.Id = 189;
            insertTableOfContentsItem1.Name = "insertTableOfContentsItem1";
            // 
            // updateTableOfContentsItem1
            // 
            updateTableOfContentsItem1.Id = 190;
            updateTableOfContentsItem1.Name = "updateTableOfContentsItem1";
            // 
            // addParagraphsToTableOfContentItem1
            // 
            addParagraphsToTableOfContentItem1.Id = 191;
            addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem2),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem3),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem4),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem5),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem6),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem7),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem8),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem9),
            new DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem10)});
            addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1";
            // 
            // setParagraphHeadingLevelItem1
            // 
            setParagraphHeadingLevelItem1.Id = 192;
            setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1";
            setParagraphHeadingLevelItem1.OutlineLevel = 0;
            // 
            // setParagraphHeadingLevelItem2
            // 
            setParagraphHeadingLevelItem2.Id = 193;
            setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2";
            setParagraphHeadingLevelItem2.OutlineLevel = 1;
            // 
            // setParagraphHeadingLevelItem3
            // 
            setParagraphHeadingLevelItem3.Id = 194;
            setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3";
            setParagraphHeadingLevelItem3.OutlineLevel = 2;
            // 
            // setParagraphHeadingLevelItem4
            // 
            setParagraphHeadingLevelItem4.Id = 195;
            setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4";
            setParagraphHeadingLevelItem4.OutlineLevel = 3;
            // 
            // setParagraphHeadingLevelItem5
            // 
            setParagraphHeadingLevelItem5.Id = 196;
            setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5";
            setParagraphHeadingLevelItem5.OutlineLevel = 4;
            // 
            // setParagraphHeadingLevelItem6
            // 
            setParagraphHeadingLevelItem6.Id = 197;
            setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6";
            setParagraphHeadingLevelItem6.OutlineLevel = 5;
            // 
            // setParagraphHeadingLevelItem7
            // 
            setParagraphHeadingLevelItem7.Id = 198;
            setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7";
            setParagraphHeadingLevelItem7.OutlineLevel = 6;
            // 
            // setParagraphHeadingLevelItem8
            // 
            setParagraphHeadingLevelItem8.Id = 199;
            setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8";
            setParagraphHeadingLevelItem8.OutlineLevel = 7;
            // 
            // setParagraphHeadingLevelItem9
            // 
            setParagraphHeadingLevelItem9.Id = 200;
            setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9";
            setParagraphHeadingLevelItem9.OutlineLevel = 8;
            // 
            // setParagraphHeadingLevelItem10
            // 
            setParagraphHeadingLevelItem10.Id = 201;
            setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10";
            setParagraphHeadingLevelItem10.OutlineLevel = 9;
            // 
            // captionsRibbonPageGroup1
            // 
            captionsRibbonPageGroup1.ItemLinks.Add(insertCaptionPlaceholderItem1);
            captionsRibbonPageGroup1.ItemLinks.Add(insertTableOfFiguresPlaceholderItem1);
            captionsRibbonPageGroup1.ItemLinks.Add(updateTableOfFiguresItem1);
            captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1";
            // 
            // insertCaptionPlaceholderItem1
            // 
            insertCaptionPlaceholderItem1.Id = 202;
            insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(insertFiguresCaptionItems1),
            new DevExpress.XtraBars.LinkPersistInfo(insertTablesCaptionItems1),
            new DevExpress.XtraBars.LinkPersistInfo(insertEquationsCaptionItems1)});
            insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1";
            // 
            // insertFiguresCaptionItems1
            // 
            insertFiguresCaptionItems1.Id = 203;
            insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1";
            // 
            // insertTablesCaptionItems1
            // 
            insertTablesCaptionItems1.Id = 204;
            insertTablesCaptionItems1.Name = "insertTablesCaptionItems1";
            // 
            // insertEquationsCaptionItems1
            // 
            insertEquationsCaptionItems1.Id = 205;
            insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1";
            // 
            // insertTableOfFiguresPlaceholderItem1
            // 
            insertTableOfFiguresPlaceholderItem1.Id = 206;
            insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(insertTableOfFiguresItems1),
            new DevExpress.XtraBars.LinkPersistInfo(insertTableOfTablesItems1),
            new DevExpress.XtraBars.LinkPersistInfo(insertTableOfEquationsItems1)});
            insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1";
            // 
            // insertTableOfFiguresItems1
            // 
            insertTableOfFiguresItems1.Id = 207;
            insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1";
            // 
            // insertTableOfTablesItems1
            // 
            insertTableOfTablesItems1.Id = 208;
            insertTableOfTablesItems1.Name = "insertTableOfTablesItems1";
            // 
            // insertTableOfEquationsItems1
            // 
            insertTableOfEquationsItems1.Id = 209;
            insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1";
            // 
            // updateTableOfFiguresItem1
            // 
            updateTableOfFiguresItem1.Id = 210;
            updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1";
            // 
            // floatingPictureToolsShapeStylesPageGroup1
            // 
            floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(changeFloatingObjectFillColorItem1);
            floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(changeFloatingObjectOutlineColorItem1);
            floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(changeFloatingObjectOutlineWeightItem1);
            floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1";
            // 
            // floatingPictureToolsFormatPage1
            // 
            floatingPictureToolsFormatPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            floatingPictureToolsShapeStylesPageGroup1,
            floatingPictureToolsArrangePageGroup1});
            floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1";
            // 
            // floatingPictureToolsRibbonPageCategory1
            // 
            floatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            floatingPictureToolsRibbonPageCategory1.Control = snapControl;
            floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1";
            floatingPictureToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            floatingPictureToolsFormatPage1});
            // 
            // changeFloatingObjectFillColorItem1
            // 
            changeFloatingObjectFillColorItem1.Id = 211;
            changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1";
            // 
            // changeFloatingObjectOutlineColorItem1
            // 
            changeFloatingObjectOutlineColorItem1.Id = 212;
            changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1";
            // 
            // changeFloatingObjectOutlineWeightItem1
            // 
            changeFloatingObjectOutlineWeightItem1.Edit = repositoryItemFloatingObjectOutlineWeight1;
            changeFloatingObjectOutlineWeightItem1.EditValue = 20;
            changeFloatingObjectOutlineWeightItem1.Id = 213;
            changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1";
            // 
            // repositoryItemFloatingObjectOutlineWeight1
            // 
            repositoryItemFloatingObjectOutlineWeight1.AutoHeight = false;
            repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemFloatingObjectOutlineWeight1.Control = snapControl;
            repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1";
            // 
            // floatingPictureToolsArrangePageGroup1
            // 
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(changeFloatingObjectTextWrapTypeItem1);
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(changeFloatingObjectAlignmentItem1);
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(floatingObjectBringForwardSubItem1);
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(floatingObjectSendBackwardSubItem1);
            floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1";
            // 
            // changeFloatingObjectTextWrapTypeItem1
            // 
            changeFloatingObjectTextWrapTypeItem1.Id = 214;
            changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectSquareTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTightTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectThroughTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopAndBottomTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBehindTextWrapTypeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectInFrontOfTextWrapTypeItem1)});
            changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1";
            // 
            // setFloatingObjectSquareTextWrapTypeItem1
            // 
            setFloatingObjectSquareTextWrapTypeItem1.Id = 215;
            setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1";
            // 
            // setFloatingObjectTightTextWrapTypeItem1
            // 
            setFloatingObjectTightTextWrapTypeItem1.Id = 216;
            setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1";
            // 
            // setFloatingObjectThroughTextWrapTypeItem1
            // 
            setFloatingObjectThroughTextWrapTypeItem1.Id = 217;
            setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1";
            // 
            // setFloatingObjectTopAndBottomTextWrapTypeItem1
            // 
            setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 218;
            setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1";
            // 
            // setFloatingObjectBehindTextWrapTypeItem1
            // 
            setFloatingObjectBehindTextWrapTypeItem1.Id = 219;
            setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1";
            // 
            // setFloatingObjectInFrontOfTextWrapTypeItem1
            // 
            setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 220;
            setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1";
            // 
            // changeFloatingObjectAlignmentItem1
            // 
            changeFloatingObjectAlignmentItem1.Id = 221;
            changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectMiddleLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectMiddleCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectMiddleRightAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBottomLeftAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBottomCenterAlignmentItem1),
            new DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBottomRightAlignmentItem1)});
            changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1";
            // 
            // setFloatingObjectTopLeftAlignmentItem1
            // 
            setFloatingObjectTopLeftAlignmentItem1.Id = 222;
            setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1";
            // 
            // setFloatingObjectTopCenterAlignmentItem1
            // 
            setFloatingObjectTopCenterAlignmentItem1.Id = 223;
            setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1";
            // 
            // setFloatingObjectTopRightAlignmentItem1
            // 
            setFloatingObjectTopRightAlignmentItem1.Id = 224;
            setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1";
            // 
            // setFloatingObjectMiddleLeftAlignmentItem1
            // 
            setFloatingObjectMiddleLeftAlignmentItem1.Id = 225;
            setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1";
            // 
            // setFloatingObjectMiddleCenterAlignmentItem1
            // 
            setFloatingObjectMiddleCenterAlignmentItem1.Id = 226;
            setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1";
            // 
            // setFloatingObjectMiddleRightAlignmentItem1
            // 
            setFloatingObjectMiddleRightAlignmentItem1.Id = 227;
            setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1";
            // 
            // setFloatingObjectBottomLeftAlignmentItem1
            // 
            setFloatingObjectBottomLeftAlignmentItem1.Id = 228;
            setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1";
            // 
            // setFloatingObjectBottomCenterAlignmentItem1
            // 
            setFloatingObjectBottomCenterAlignmentItem1.Id = 229;
            setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1";
            // 
            // setFloatingObjectBottomRightAlignmentItem1
            // 
            setFloatingObjectBottomRightAlignmentItem1.Id = 230;
            setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1";
            // 
            // floatingObjectBringForwardSubItem1
            // 
            floatingObjectBringForwardSubItem1.Id = 231;
            floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(floatingObjectBringForwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(floatingObjectBringToFrontItem1),
            new DevExpress.XtraBars.LinkPersistInfo(floatingObjectBringInFrontOfTextItem1)});
            floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1";
            // 
            // floatingObjectBringForwardItem1
            // 
            floatingObjectBringForwardItem1.Id = 232;
            floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1";
            // 
            // floatingObjectBringToFrontItem1
            // 
            floatingObjectBringToFrontItem1.Id = 233;
            floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1";
            // 
            // floatingObjectBringInFrontOfTextItem1
            // 
            floatingObjectBringInFrontOfTextItem1.Id = 234;
            floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1";
            // 
            // floatingObjectSendBackwardSubItem1
            // 
            floatingObjectSendBackwardSubItem1.Id = 235;
            floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(floatingObjectSendBackwardItem1),
            new DevExpress.XtraBars.LinkPersistInfo(floatingObjectSendToBackItem1),
            new DevExpress.XtraBars.LinkPersistInfo(floatingObjectSendBehindTextItem1)});
            floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1";
            // 
            // floatingObjectSendBackwardItem1
            // 
            floatingObjectSendBackwardItem1.Id = 236;
            floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1";
            // 
            // floatingObjectSendToBackItem1
            // 
            floatingObjectSendToBackItem1.Id = 237;
            floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1";
            // 
            // floatingObjectSendBehindTextItem1
            // 
            floatingObjectSendBehindTextItem1.Id = 238;
            floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1";
            // 
            // themesRibbonPageGroup1
            // 
            themesRibbonPageGroup1.ItemLinks.Add(themesGalleryBarItem1);
            themesRibbonPageGroup1.Name = "themesRibbonPageGroup1";
            // 
            // appearanceRibbonPage1
            // 
            appearanceRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            themesRibbonPageGroup1});
            appearanceRibbonPage1.Name = "appearanceRibbonPage1";
            // 
            // dataToolsRibbonPageCategory1
            // 
            dataToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(166)))), ((int)(((byte)(207)))));
            dataToolsRibbonPageCategory1.Control = snapControl;
            dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1";
            dataToolsRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            appearanceRibbonPage1,
            snMergeFieldToolsRibbonPage1,
            groupToolsRibbonPage1,
            listToolsRibbonPage1});
            // 
            // themesGalleryBarItem1
            // 
            // 
            // 
            // 
            themesGalleryBarItem1.Gallery.ColumnCount = 7;
            themesGalleryBarItem1.Gallery.ImageSize = new System.Drawing.Size(65, 46);
            themesGalleryBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
            themesGalleryBarItem1.Gallery.RowCount = 1;
            themesGalleryBarItem1.Id = 239;
            themesGalleryBarItem1.Name = "themesGalleryBarItem1";
            // 
            // dataShapingRibbonPageGroup1
            // 
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem2);
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem3);
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem4);
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem1);
            dataShapingRibbonPageGroup1.ItemLinks.Add(filterPopupButtonItem1);
            dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1";
            // 
            // snMergeFieldToolsRibbonPage1
            // 
            snMergeFieldToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            dataShapingRibbonPageGroup1,
            snMergeFieldPropertiesRibbonPageGroup1});
            snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1";
            // 
            // commandBarCheckItem2
            // 
            commandBarCheckItem2.Id = 240;
            commandBarCheckItem2.Name = "commandBarCheckItem2";
            commandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField;
            // 
            // commandBarCheckItem3
            // 
            commandBarCheckItem3.Id = 241;
            commandBarCheckItem3.Name = "commandBarCheckItem3";
            commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldAscending;
            // 
            // commandBarCheckItem4
            // 
            commandBarCheckItem4.Id = 242;
            commandBarCheckItem4.Name = "commandBarCheckItem4";
            commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldDescending;
            // 
            // commandBarSubItem1
            // 
            commandBarSubItem1.Id = 243;
            commandBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem6),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem7),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem8),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem9)});
            commandBarSubItem1.Name = "commandBarSubItem1";
            commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField;
            // 
            // commandBarCheckItem5
            // 
            commandBarCheckItem5.Id = 244;
            commandBarCheckItem5.Name = "commandBarCheckItem5";
            commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount;
            // 
            // commandBarCheckItem6
            // 
            commandBarCheckItem6.Id = 245;
            commandBarCheckItem6.Name = "commandBarCheckItem6";
            commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum;
            // 
            // commandBarCheckItem7
            // 
            commandBarCheckItem7.Id = 246;
            commandBarCheckItem7.Name = "commandBarCheckItem7";
            commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage;
            // 
            // commandBarCheckItem8
            // 
            commandBarCheckItem8.Id = 247;
            commandBarCheckItem8.Name = "commandBarCheckItem8";
            commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax;
            // 
            // commandBarCheckItem9
            // 
            commandBarCheckItem9.Id = 248;
            commandBarCheckItem9.Name = "commandBarCheckItem9";
            commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin;
            // 
            // filterPopupButtonItem1
            // 
            filterPopupButtonItem1.ActAsDropDown = true;
            filterPopupButtonItem1.Id = 249;
            filterPopupButtonItem1.Name = "filterPopupButtonItem1";
            // 
            // snMergeFieldPropertiesRibbonPageGroup1
            // 
            snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(propertiesBarButtonItem1);
            snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1";
            // 
            // propertiesBarButtonItem1
            // 
            propertiesBarButtonItem1.ActAsDropDown = true;
            propertiesBarButtonItem1.Id = 250;
            propertiesBarButtonItem1.Name = "propertiesBarButtonItem1";
            propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // groupingRibbonPageGroup1
            // 
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem2);
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem3);
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarItem8);
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarItem9);
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem4);
            groupingRibbonPageGroup1.Name = "groupingRibbonPageGroup1";
            // 
            // groupToolsRibbonPage1
            // 
            groupToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            groupingRibbonPageGroup1});
            groupToolsRibbonPage1.Name = "groupToolsRibbonPage1";
            // 
            // commandBarSubItem2
            // 
            commandBarSubItem2.Id = 251;
            commandBarSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem10),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem11)});
            commandBarSubItem2.Name = "commandBarSubItem2";
            commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupHeader;
            // 
            // commandBarCheckItem10
            // 
            commandBarCheckItem10.Id = 252;
            commandBarCheckItem10.Name = "commandBarCheckItem10";
            commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupHeader;
            // 
            // commandBarCheckItem11
            // 
            commandBarCheckItem11.Id = 253;
            commandBarCheckItem11.Name = "commandBarCheckItem11";
            commandBarCheckItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupHeader;
            // 
            // commandBarSubItem3
            // 
            commandBarSubItem3.Id = 254;
            commandBarSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem12),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem13)});
            commandBarSubItem3.Name = "commandBarSubItem3";
            commandBarSubItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFooter;
            // 
            // commandBarCheckItem12
            // 
            commandBarCheckItem12.Id = 255;
            commandBarCheckItem12.Name = "commandBarCheckItem12";
            commandBarCheckItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupFooter;
            // 
            // commandBarCheckItem13
            // 
            commandBarCheckItem13.Id = 256;
            commandBarCheckItem13.Name = "commandBarCheckItem13";
            commandBarCheckItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupFooter;
            // 
            // commandBarItem8
            // 
            commandBarItem8.Id = 257;
            commandBarItem8.Name = "commandBarItem8";
            commandBarItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFieldsCollection;
            // 
            // commandBarItem9
            // 
            commandBarItem9.Id = 258;
            commandBarItem9.Name = "commandBarItem9";
            commandBarItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ShowReportStructureEditorForm;
            // 
            // commandBarSubItem4
            // 
            commandBarSubItem4.Id = 259;
            commandBarSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem14),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem15),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem16),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem17),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem18),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem19),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem20)});
            commandBarSubItem4.Name = "commandBarSubItem4";
            commandBarSubItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupSeparator;
            // 
            // commandBarCheckItem14
            // 
            commandBarCheckItem14.Id = 260;
            commandBarCheckItem14.Name = "commandBarCheckItem14";
            commandBarCheckItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakGroupSeparator;
            // 
            // commandBarCheckItem15
            // 
            commandBarCheckItem15.Id = 261;
            commandBarCheckItem15.Name = "commandBarCheckItem15";
            commandBarCheckItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageGroupSeparator;
            // 
            // commandBarCheckItem16
            // 
            commandBarCheckItem16.Id = 262;
            commandBarCheckItem16.Name = "commandBarCheckItem16";
            commandBarCheckItem16.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageGroupSeparator;
            // 
            // commandBarCheckItem17
            // 
            commandBarCheckItem17.Id = 263;
            commandBarCheckItem17.Name = "commandBarCheckItem17";
            commandBarCheckItem17.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageGroupSeparator;
            // 
            // commandBarCheckItem18
            // 
            commandBarCheckItem18.Id = 264;
            commandBarCheckItem18.Name = "commandBarCheckItem18";
            commandBarCheckItem18.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphGroupSeparator;
            // 
            // commandBarCheckItem19
            // 
            commandBarCheckItem19.Id = 265;
            commandBarCheckItem19.Name = "commandBarCheckItem19";
            commandBarCheckItem19.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowGroupSeparator;
            // 
            // commandBarCheckItem20
            // 
            commandBarCheckItem20.Id = 266;
            commandBarCheckItem20.Name = "commandBarCheckItem20";
            commandBarCheckItem20.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneGroupSeparator;
            // 
            // listHeaderAndFooterRibbonPageGroup1
            // 
            listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(commandBarSubItem5);
            listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(commandBarSubItem6);
            listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(commandBarSubItem7);
            listHeaderAndFooterRibbonPageGroup1.Name = "listHeaderAndFooterRibbonPageGroup1";
            // 
            // listToolsRibbonPage1
            // 
            listToolsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            listHeaderAndFooterRibbonPageGroup1,
            listCommandsRibbonPageGroup1,
            listEditorRowLimitRibbonPageGroup1});
            listToolsRibbonPage1.Name = "listToolsRibbonPage1";
            // 
            // commandBarSubItem5
            // 
            commandBarSubItem5.Id = 268;
            commandBarSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem21),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem22)});
            commandBarSubItem5.Name = "commandBarSubItem5";
            commandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            commandBarSubItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListHeader;
            // 
            // commandBarCheckItem21
            // 
            commandBarCheckItem21.Id = 269;
            commandBarCheckItem21.Name = "commandBarCheckItem21";
            commandBarCheckItem21.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListHeader;
            // 
            // commandBarCheckItem22
            // 
            commandBarCheckItem22.Id = 270;
            commandBarCheckItem22.Name = "commandBarCheckItem22";
            commandBarCheckItem22.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListHeader;
            // 
            // commandBarSubItem6
            // 
            commandBarSubItem6.Id = 271;
            commandBarSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem23),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem24)});
            commandBarSubItem6.Name = "commandBarSubItem6";
            commandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            commandBarSubItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListFooter;
            // 
            // commandBarCheckItem23
            // 
            commandBarCheckItem23.Id = 272;
            commandBarCheckItem23.Name = "commandBarCheckItem23";
            commandBarCheckItem23.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListFooter;
            // 
            // commandBarCheckItem24
            // 
            commandBarCheckItem24.Id = 273;
            commandBarCheckItem24.Name = "commandBarCheckItem24";
            commandBarCheckItem24.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListFooter;
            // 
            // commandBarSubItem7
            // 
            commandBarSubItem7.Id = 274;
            commandBarSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem25),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem26),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem27),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem28),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem29),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem30),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem31)});
            commandBarSubItem7.Name = "commandBarSubItem7";
            commandBarSubItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertDataRowSeparator;
            // 
            // commandBarCheckItem25
            // 
            commandBarCheckItem25.Id = 275;
            commandBarCheckItem25.Name = "commandBarCheckItem25";
            commandBarCheckItem25.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakDataRowSeparator;
            // 
            // commandBarCheckItem26
            // 
            commandBarCheckItem26.Id = 276;
            commandBarCheckItem26.Name = "commandBarCheckItem26";
            commandBarCheckItem26.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageDataRowSeparator;
            // 
            // commandBarCheckItem27
            // 
            commandBarCheckItem27.Id = 277;
            commandBarCheckItem27.Name = "commandBarCheckItem27";
            commandBarCheckItem27.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageDataRowSeparator;
            // 
            // commandBarCheckItem28
            // 
            commandBarCheckItem28.Id = 278;
            commandBarCheckItem28.Name = "commandBarCheckItem28";
            commandBarCheckItem28.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageDataRowSeparator;
            // 
            // commandBarCheckItem29
            // 
            commandBarCheckItem29.Id = 279;
            commandBarCheckItem29.Name = "commandBarCheckItem29";
            commandBarCheckItem29.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphDataRowSeparator;
            // 
            // commandBarCheckItem30
            // 
            commandBarCheckItem30.Id = 280;
            commandBarCheckItem30.Name = "commandBarCheckItem30";
            commandBarCheckItem30.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowDataRowSeparator;
            // 
            // commandBarCheckItem31
            // 
            commandBarCheckItem31.Id = 281;
            commandBarCheckItem31.Name = "commandBarCheckItem31";
            commandBarCheckItem31.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneDataRowSeparator;
            // 
            // listCommandsRibbonPageGroup1
            // 
            listCommandsRibbonPageGroup1.ItemLinks.Add(commandBarItem10);
            listCommandsRibbonPageGroup1.ItemLinks.Add(commandBarItem11);
            listCommandsRibbonPageGroup1.ItemLinks.Add(commandBarItem12);
            listCommandsRibbonPageGroup1.Name = "listCommandsRibbonPageGroup1";
            // 
            // commandBarItem10
            // 
            commandBarItem10.Id = 282;
            commandBarItem10.Name = "commandBarItem10";
            commandBarItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FilterList;
            // 
            // commandBarItem11
            // 
            commandBarItem11.Id = 283;
            commandBarItem11.Name = "commandBarItem11";
            commandBarItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ConvertToParagraphs;
            // 
            // commandBarItem12
            // 
            commandBarItem12.Id = 284;
            commandBarItem12.Name = "commandBarItem12";
            commandBarItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.DeleteList;
            // 
            // listEditorRowLimitRibbonPageGroup1
            // 
            listEditorRowLimitRibbonPageGroup1.ItemLinks.Add(barButtonGroup8);
            listEditorRowLimitRibbonPageGroup1.Name = "listEditorRowLimitRibbonPageGroup1";
            // 
            // changeEditorRowLimitItem1
            // 
            changeEditorRowLimitItem1.Edit = repositoryItemEditorRowLimitEdit1;
            changeEditorRowLimitItem1.Id = 285;
            changeEditorRowLimitItem1.Name = "changeEditorRowLimitItem1";
            changeEditorRowLimitItem1.Width = 90;
            // 
            // barButtonGroup8
            // 
            barButtonGroup8.Id = 267;
            barButtonGroup8.ItemLinks.Add(changeEditorRowLimitItem1);
            barButtonGroup8.Name = "barButtonGroup8";
            barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}";
            // 
            // repositoryItemEditorRowLimitEdit1
            // 
            repositoryItemEditorRowLimitEdit1.AutoHeight = false;
            repositoryItemEditorRowLimitEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemEditorRowLimitEdit1.Control = snapControl;
            repositoryItemEditorRowLimitEdit1.Name = "repositoryItemEditorRowLimitEdit1";
            // 
            // chartTypeRibbonPageGroup1
            // 
            chartTypeRibbonPageGroup1.ItemLinks.Add(createBarBaseItem1);
            chartTypeRibbonPageGroup1.ItemLinks.Add(createLineBaseItem1);
            chartTypeRibbonPageGroup1.ItemLinks.Add(createPieBaseItem1);
            chartTypeRibbonPageGroup1.ItemLinks.Add(createRotatedBarBaseItem1);
            chartTypeRibbonPageGroup1.ItemLinks.Add(createAreaBaseItem1);
            chartTypeRibbonPageGroup1.ItemLinks.Add(createOtherSeriesTypesBaseItem1);
            chartTypeRibbonPageGroup1.Name = "chartTypeRibbonPageGroup1";
            // 
            // createChartRibbonPage1
            // 
            createChartRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            chartTypeRibbonPageGroup1,
            chartAppearanceRibbonPageGroup1,
            chartWizardRibbonPageGroup1});
            createChartRibbonPage1.Name = "createChartRibbonPage1";
            // 
            // chartRibbonPageCategory1
            // 
            chartRibbonPageCategory1.Control = null;
            chartRibbonPageCategory1.Name = "chartRibbonPageCategory1";
            chartRibbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            createChartRibbonPage1});
            // 
            // createBarBaseItem1
            // 
            createBarBaseItem1.DropDownControl = commandBarGalleryDropDown1;
            createBarBaseItem1.Id = 286;
            createBarBaseItem1.Name = "createBarBaseItem1";
            // 
            // commandBarGalleryDropDown1
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBarChartItem1,
            createFullStackedBarChartItem1,
            createSideBySideFullStackedBarChartItem1,
            createSideBySideStackedBarChartItem1,
            createStackedBarChartItem1});
            chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createBar3DChartItem1,
            createFullStackedBar3DChartItem1,
            createManhattanBarChartItem1,
            createSideBySideFullStackedBar3DChartItem1,
            createSideBySideStackedBar3DChartItem1,
            createStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createCylinderBar3DChartItem1,
            createCylinderFullStackedBar3DChartItem1,
            createCylinderManhattanBarChartItem1,
            createCylinderSideBySideFullStackedBar3DChartItem1,
            createCylinderSideBySideStackedBar3DChartItem1,
            createCylinderStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createConeBar3DChartItem1,
            createConeFullStackedBar3DChartItem1,
            createConeManhattanBarChartItem1,
            createConeSideBySideFullStackedBar3DChartItem1,
            createConeSideBySideStackedBar3DChartItem1,
            createConeStackedBar3DChartItem1});
            chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPyramidBar3DChartItem1,
            createPyramidFullStackedBar3DChartItem1,
            createPyramidManhattanBarChartItem1,
            createPyramidSideBySideFullStackedBar3DChartItem1,
            createPyramidSideBySideStackedBar3DChartItem1,
            createPyramidStackedBar3DChartItem1});
            commandBarGalleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DColumn1,
            chartControlCommandGalleryItemGroup3DColumn1,
            chartControlCommandGalleryItemGroupCylinderColumn1,
            chartControlCommandGalleryItemGroupConeColumn1,
            chartControlCommandGalleryItemGroupPyramidColumn1});
            commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1";
            commandBarGalleryDropDown1.Ribbon = ribbonControl1;
            // 
            // createLineBaseItem1
            // 
            createLineBaseItem1.DropDownControl = commandBarGalleryDropDown2;
            createLineBaseItem1.Id = 287;
            createLineBaseItem1.Name = "createLineBaseItem1";
            // 
            // commandBarGalleryDropDown2
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLineChartItem1,
            createFullStackedLineChartItem1,
            createScatterLineChartItem1,
            createSplineChartItem1,
            createStackedLineChartItem1,
            createStepLineChartItem1});
            chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createLine3DChartItem1,
            createFullStackedLine3DChartItem1,
            createSpline3DChartItem1,
            createStackedLine3DChartItem1,
            createStepLine3DChartItem1});
            commandBarGalleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DLine1,
            chartControlCommandGalleryItemGroup3DLine1});
            commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2";
            commandBarGalleryDropDown2.Ribbon = ribbonControl1;
            // 
            // createPieBaseItem1
            // 
            createPieBaseItem1.DropDownControl = commandBarGalleryDropDown3;
            createPieBaseItem1.Id = 288;
            createPieBaseItem1.Name = "createPieBaseItem1";
            // 
            // commandBarGalleryDropDown3
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPieChartItem1,
            createDoughnutChartItem1,
            createNestedDoughnutChartItem1});
            chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPie3DChartItem1,
            createDoughnut3DChartItem1});
            commandBarGalleryDropDown3.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DPie1,
            chartControlCommandGalleryItemGroup3DPie1});
            commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3";
            commandBarGalleryDropDown3.Ribbon = ribbonControl1;
            // 
            // createRotatedBarBaseItem1
            // 
            createRotatedBarBaseItem1.DropDownControl = commandBarGalleryDropDown4;
            createRotatedBarBaseItem1.Id = 289;
            createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1";
            // 
            // commandBarGalleryDropDown4
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRotatedBarChartItem1,
            createRotatedFullStackedBarChartItem1,
            createRotatedSideBySideFullStackedBarChartItem1,
            createRotatedSideBySideStackedBarChartItem1,
            createRotatedStackedBarChartItem1});
            commandBarGalleryDropDown4.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DBar1});
            commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4";
            commandBarGalleryDropDown4.Ribbon = ribbonControl1;
            // 
            // createAreaBaseItem1
            // 
            createAreaBaseItem1.DropDownControl = commandBarGalleryDropDown5;
            createAreaBaseItem1.Id = 290;
            createAreaBaseItem1.Name = "createAreaBaseItem1";
            // 
            // commandBarGalleryDropDown5
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createAreaChartItem1,
            createFullStackedAreaChartItem1,
            createFullStackedSplineAreaChartItem1,
            createSplineAreaChartItem1,
            createStackedAreaChartItem1,
            createStackedSplineAreaChartItem1,
            createStepAreaChartItem1});
            chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createArea3DChartItem1,
            createFullStackedArea3DChartItem1,
            createFullStackedSplineArea3DChartItem1,
            createSplineArea3DChartItem1,
            createStackedArea3DChartItem1,
            createStackedSplineArea3DChartItem1,
            createStepArea3DChartItem1});
            commandBarGalleryDropDown5.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroup2DArea1,
            chartControlCommandGalleryItemGroup3DArea1});
            commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5";
            commandBarGalleryDropDown5.Ribbon = ribbonControl1;
            // 
            // createOtherSeriesTypesBaseItem1
            // 
            createOtherSeriesTypesBaseItem1.DropDownControl = commandBarGalleryDropDown6;
            createOtherSeriesTypesBaseItem1.Id = 291;
            createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1";
            // 
            // commandBarGalleryDropDown6
            // 
            // 
            // 
            // 
            chartControlCommandGalleryItemGroupPoint1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPointChartItem1,
            createBubbleChartItem1});
            chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createFunnelChartItem1,
            createFunnel3DChartItem1});
            chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createStockChartItem1,
            createCandleStickChartItem1});
            chartControlCommandGalleryItemGroupRadar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRadarPointChartItem1,
            createRadarLineChartItem1,
            createRadarAreaChartItem1});
            chartControlCommandGalleryItemGroupPolar1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createPolarPointChartItem1,
            createPolarLineChartItem1,
            createPolarAreaChartItem1});
            chartControlCommandGalleryItemGroupRange1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createRangeBarChartItem1,
            createSideBySideRangeBarChartItem1,
            createRangeAreaChartItem1,
            createRangeArea3DChartItem1});
            chartControlCommandGalleryItemGroupGantt1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            createGanttChartItem1,
            createSideBySideGanttChartItem1});
            commandBarGalleryDropDown6.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            chartControlCommandGalleryItemGroupPoint1,
            chartControlCommandGalleryItemGroupFunnel1,
            chartControlCommandGalleryItemGroupFinancial1,
            chartControlCommandGalleryItemGroupRadar1,
            chartControlCommandGalleryItemGroupPolar1,
            chartControlCommandGalleryItemGroupRange1,
            chartControlCommandGalleryItemGroupGantt1});
            commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6";
            commandBarGalleryDropDown6.Ribbon = ribbonControl1;
            // 
            // chartAppearanceRibbonPageGroup1
            // 
            chartAppearanceRibbonPageGroup1.ItemLinks.Add(changePaletteGalleryBaseItem1);
            chartAppearanceRibbonPageGroup1.ItemLinks.Add(changeAppearanceGalleryBaseItem1);
            chartAppearanceRibbonPageGroup1.Name = "chartAppearanceRibbonPageGroup1";
            // 
            // changePaletteGalleryBaseItem1
            // 
            changePaletteGalleryBaseItem1.DropDownControl = commandBarGalleryDropDown7;
            changePaletteGalleryBaseItem1.Id = 292;
            changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1";
            // 
            // commandBarGalleryDropDown7
            // 
            commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7";
            commandBarGalleryDropDown7.Ribbon = ribbonControl1;
            // 
            // changeAppearanceGalleryBaseItem1
            // 
            // 
            // 
            // 
            changeAppearanceGalleryBaseItem1.Gallery.ColumnCount = 7;
            changeAppearanceGalleryBaseItem1.Gallery.ImageSize = new System.Drawing.Size(80, 50);
            changeAppearanceGalleryBaseItem1.Gallery.RowCount = 4;
            changeAppearanceGalleryBaseItem1.Id = 293;
            changeAppearanceGalleryBaseItem1.Name = "changeAppearanceGalleryBaseItem1";
            // 
            // chartWizardRibbonPageGroup1
            // 
            chartWizardRibbonPageGroup1.AllowMinimize = false;
            chartWizardRibbonPageGroup1.ItemLinks.Add(runWizardChartItem1);
            chartWizardRibbonPageGroup1.Name = "chartWizardRibbonPageGroup1";
            // 
            // runWizardChartItem1
            // 
            runWizardChartItem1.Id = 294;
            runWizardChartItem1.Name = "runWizardChartItem1";
            // 
            // Form1
            // 
            snapForm.Controls.Add(ribbonControl1);
            ((System.ComponentModel.ISupportInitialize)(ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(snapBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemBorderLineStyle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemBorderLineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemFloatingObjectOutlineWeight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemEditorRowLimitEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(commandBarGalleryDropDown7)).EndInit();
            snapForm.ResumeLayout(false);
            snapForm.PerformLayout();
        }
    }
}
