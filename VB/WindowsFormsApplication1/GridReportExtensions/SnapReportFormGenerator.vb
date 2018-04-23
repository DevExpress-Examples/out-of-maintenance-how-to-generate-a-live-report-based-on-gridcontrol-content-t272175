Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Snap
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid

Namespace WindowsFormsApplication1.GridReportExtensions
	Public Module SnapReportFormGenerator

        <System.Runtime.CompilerServices.Extension> _
        Public Function CreateReportPreviewForm(ByVal snapControl As SnapControl) As RibbonForm
            Dim reportForm As New RibbonForm()

            'create DockManager and Dock Panels
            Dim dockManager As DevExpress.Snap.Extensions.SnapDockManager = CreateDefaultSnapFormContent(reportForm, snapControl)

            ' create default SnapControl Ribbon Menu
            CreateRibbonMenuWithPredefinedItems(reportForm, snapControl, dockManager)

            Return reportForm
        End Function

        Private Function CreateDefaultSnapFormContent(ByVal snapForm As RibbonForm, ByVal snapControl As SnapControl) As DevExpress.Snap.Extensions.SnapDockManager
            Dim snapDockManager As New DevExpress.Snap.Extensions.SnapDockManager()
            Dim fieldListDockPanel As New DevExpress.Snap.Extensions.UI.FieldListDockPanel()
            Dim fieldListDockPanel1_Container As New DevExpress.XtraBars.Docking.ControlContainer()
            Dim reportExplorerDockPanel As New DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel()
            Dim reportExplorerDockPanel1_Container As New DevExpress.XtraBars.Docking.ControlContainer()
            Dim panelContainer As New DevExpress.XtraBars.Docking.DockPanel()
            Dim snapDocumentManager As New DevExpress.Snap.Extensions.SnapDocumentManager()
            Dim noDocumentsView As New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView()
            CType(snapDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            fieldListDockPanel.SuspendLayout()
            reportExplorerDockPanel.SuspendLayout()
            panelContainer.SuspendLayout()
            CType(snapDocumentManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(noDocumentsView, System.ComponentModel.ISupportInitialize).BeginInit()
            snapForm.SuspendLayout()
            ' 
            ' snapControl
            ' 
            snapControl.Dock = System.Windows.Forms.DockStyle.Fill
            snapControl.EnableToolTips = True
            snapControl.Location = New System.Drawing.Point(0, 0)
            snapControl.Name = "snapControl1"
            snapControl.Options.Fields.EnableEmptyFieldDataAlias = True
            snapControl.Options.SnapMailMergeVisualOptions.DataSourceName = Nothing
            snapControl.Size = New System.Drawing.Size(744, 672)
            snapControl.TabIndex = 0
            snapControl.Text = "snapControl1"
            ' 
            ' snapDockManager
            ' 
            snapDockManager.Form = snapForm
            snapDockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {panelContainer})
            snapDockManager.SnapControl = snapControl
            snapDockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
            ' 
            ' fieldListDockPanel
            ' 
            fieldListDockPanel.Controls.Add(fieldListDockPanel1_Container)
            fieldListDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            fieldListDockPanel.ID = Guid.NewGuid()
            fieldListDockPanel.Location = New System.Drawing.Point(0, 0)
            fieldListDockPanel.Name = "fieldListDockPanel1"
            fieldListDockPanel.OriginalSize = New System.Drawing.Size(200, 200)
            fieldListDockPanel.Size = New System.Drawing.Size(200, 336)
            fieldListDockPanel.SnapControl = snapControl
            ' 
            ' fieldListDockPanel1_Container
            ' 
            fieldListDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
            fieldListDockPanel1_Container.Size = New System.Drawing.Size(192, 309)
            fieldListDockPanel1_Container.TabIndex = 0
            ' 
            ' reportExplorerDockPanel1
            ' 
            reportExplorerDockPanel.Controls.Add(reportExplorerDockPanel1_Container)
            reportExplorerDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            reportExplorerDockPanel.ID = Guid.NewGuid()
            reportExplorerDockPanel.Location = New System.Drawing.Point(0, 336)
            reportExplorerDockPanel.Name = "reportExplorerDockPanel1"
            reportExplorerDockPanel.OriginalSize = New System.Drawing.Size(200, 200)
            reportExplorerDockPanel.Size = New System.Drawing.Size(200, 336)
            reportExplorerDockPanel.SnapControl = snapControl
            ' 
            ' reportExplorerDockPanel1_Container
            ' 
            reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(4, 23)
            reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
            reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(192, 309)
            reportExplorerDockPanel1_Container.TabIndex = 0
            ' 
            ' panelContainer1
            ' 
            panelContainer.Controls.Add(fieldListDockPanel)
            panelContainer.Controls.Add(reportExplorerDockPanel)
            panelContainer.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            panelContainer.ID = Guid.NewGuid()
            panelContainer.Location = New System.Drawing.Point(744, 0)
            panelContainer.Name = "panelContainer1"
            panelContainer.OriginalSize = New System.Drawing.Size(200, 200)
            panelContainer.Size = New System.Drawing.Size(200, 672)
            panelContainer.Text = "panelContainer1"
            ' 
            ' snapDocumentManager1
            ' 
            snapDocumentManager.ClientControl = snapControl
            snapDocumentManager.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False
            snapDocumentManager.View = noDocumentsView
            snapDocumentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {noDocumentsView})
            ' 
            ' MainForm
            ' 
            snapForm.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            snapForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            snapForm.ClientSize = New System.Drawing.Size(944, 672)
            snapForm.Controls.Add(snapControl)
            snapForm.Controls.Add(panelContainer)
            snapForm.Name = "SnapReportForm"
            snapForm.Text = "Snap Report Preview"
            CType(snapDockManager, System.ComponentModel.ISupportInitialize).EndInit()
            fieldListDockPanel.ResumeLayout(False)
            reportExplorerDockPanel.ResumeLayout(False)
            panelContainer.ResumeLayout(False)
            CType(snapDocumentManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(noDocumentsView, System.ComponentModel.ISupportInitialize).EndInit()
            snapForm.ResumeLayout(False)

            Return snapDockManager
        End Function

        Private Sub CreateRibbonMenuWithPredefinedItems(ByVal snapForm As RibbonForm, ByVal snapControl As SnapControl, ByVal dockManager As DevExpress.Snap.Extensions.SnapDockManager)
            Dim ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
            Dim undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
            Dim redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
            Dim fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
            Dim fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
            Dim fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
            Dim commandBarItem1 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
            Dim printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
            Dim printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
            Dim pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
            Dim cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
            Dim copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
            Dim pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
            Dim barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
            Dim changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
            Dim repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
            Dim changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
            Dim repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
            Dim fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
            Dim fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
            Dim barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
            Dim toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
            Dim toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
            Dim toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
            Dim toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
            Dim toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
            Dim toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
            Dim toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
            Dim toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
            Dim barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
            Dim changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
            Dim changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
            Dim changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
            Dim makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
            Dim makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
            Dim capitalizeEachWordCaseItem1 As DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem
            Dim toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
            Dim clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
            Dim barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
            Dim toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
            Dim toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
            Dim toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
            Dim barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
            Dim decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
            Dim increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
            Dim toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
            Dim barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
            Dim toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
            Dim toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
            Dim toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
            Dim toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
            Dim barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
            Dim changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
            Dim setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
            Dim setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
            Dim setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
            Dim showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
            Dim addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
            Dim removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
            Dim addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
            Dim removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
            Dim changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
            Dim galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
            Dim findItem1 As DevExpress.XtraRichEdit.UI.FindItem
            Dim replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
            Dim insertPageBreakItem21 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem2
            Dim insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
            Dim insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
            Dim insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
            Dim commandBarItem3 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarItem4 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarItem5 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarItem6 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarItem7 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
            Dim insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
            Dim editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
            Dim editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
            Dim insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
            Dim insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
            Dim insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
            Dim insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
            Dim changeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
            Dim setNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
            Dim setNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
            Dim setModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
            Dim setWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
            Dim showPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
            Dim changeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
            Dim setPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
            Dim setLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
            Dim changeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
            Dim changeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
            Dim setSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
            Dim setSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
            Dim setSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
            Dim showColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
            Dim insertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
            Dim insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
            Dim insertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
            Dim insertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
            Dim insertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
            Dim insertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
            Dim changeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
            Dim setSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
            Dim setSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
            Dim setSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
            Dim setSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
            Dim toggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
            Dim showLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
            Dim changePageColorItem1 As DevExpress.XtraRichEdit.UI.ChangePageColorItem
            Dim switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
            Dim switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
            Dim switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
            Dim toggleShowHorizontalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem
            Dim toggleShowVerticalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem
            Dim zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
            Dim zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
            Dim snapBarToolbarsListItem1 As DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem
            Dim commandBarCheckItem1 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
            Dim showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
            Dim toggleFieldHighlightingItem1 As DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem
            Dim goToPageHeaderItem1 As DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
            Dim goToPageFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPageFooterItem
            Dim goToNextHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
            Dim goToPreviousHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
            Dim toggleLinkToPreviousItem1 As DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
            Dim toggleDifferentFirstPageItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
            Dim toggleDifferentOddAndEvenPagesItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
            Dim closePageHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
            Dim toggleFirstRowItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstRowItem
            Dim toggleLastRowItem1 As DevExpress.XtraRichEdit.UI.ToggleLastRowItem
            Dim toggleBandedRowsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem
            Dim toggleFirstColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem
            Dim toggleLastColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleLastColumnItem
            Dim toggleBandedColumnsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem
            Dim galleryChangeTableStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem
            Dim galleryChangeTableCellStyleItem1 As DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem
            Dim changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
            Dim repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
            Dim changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
            Dim repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
            Dim changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
            Dim changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
            Dim toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
            Dim toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
            Dim toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
            Dim toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
            Dim resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
            Dim toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
            Dim toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
            Dim toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
            Dim toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
            Dim toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
            Dim toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
            Dim changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
            Dim selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
            Dim selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
            Dim selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
            Dim selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
            Dim selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
            Dim showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
            Dim deleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
            Dim showDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
            Dim deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
            Dim deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
            Dim deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
            Dim insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
            Dim insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
            Dim insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
            Dim insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
            Dim mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
            Dim showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
            Dim splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
            Dim toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
            Dim toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
            Dim toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
            Dim toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
            Dim toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
            Dim toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
            Dim toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
            Dim toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
            Dim toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
            Dim toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
            Dim toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
            Dim toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
            Dim toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
            Dim showTableOptionsFormItem1 As DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
            Dim checkSpellingItem1 As DevExpress.XtraRichEdit.UI.CheckSpellingItem
            Dim insertTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem
            Dim updateTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem
            Dim addParagraphsToTableOfContentItem1 As DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem
            Dim setParagraphHeadingLevelItem1 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem2 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem3 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem4 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem5 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem6 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem7 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem8 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem9 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim setParagraphHeadingLevelItem10 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
            Dim insertCaptionPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem
            Dim insertFiguresCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems
            Dim insertTablesCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems
            Dim insertEquationsCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems
            Dim insertTableOfFiguresPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem
            Dim insertTableOfFiguresItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems
            Dim insertTableOfTablesItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems
            Dim insertTableOfEquationsItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems
            Dim updateTableOfFiguresItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem
            Dim changeFloatingObjectFillColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem
            Dim changeFloatingObjectOutlineColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem
            Dim changeFloatingObjectOutlineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem
            Dim repositoryItemFloatingObjectOutlineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
            Dim changeFloatingObjectTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem
            Dim setFloatingObjectSquareTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem
            Dim setFloatingObjectTightTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem
            Dim setFloatingObjectThroughTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem
            Dim setFloatingObjectTopAndBottomTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
            Dim setFloatingObjectBehindTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem
            Dim setFloatingObjectInFrontOfTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem
            Dim changeFloatingObjectAlignmentItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem
            Dim setFloatingObjectTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem
            Dim setFloatingObjectTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem
            Dim setFloatingObjectTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem
            Dim setFloatingObjectMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem
            Dim setFloatingObjectMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem
            Dim setFloatingObjectMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem
            Dim setFloatingObjectBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem
            Dim setFloatingObjectBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem
            Dim setFloatingObjectBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem
            Dim floatingObjectBringForwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem
            Dim floatingObjectBringForwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem
            Dim floatingObjectBringToFrontItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem
            Dim floatingObjectBringInFrontOfTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem
            Dim floatingObjectSendBackwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem
            Dim floatingObjectSendBackwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem
            Dim floatingObjectSendToBackItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem
            Dim floatingObjectSendBehindTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem
            Dim themesGalleryBarItem1 As DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem
            Dim commandBarCheckItem2 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem3 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem4 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarSubItem1 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
            Dim commandBarCheckItem5 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem6 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem7 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem8 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem9 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim filterPopupButtonItem1 As DevExpress.Snap.Extensions.UI.FilterPopupButtonItem
            Dim propertiesBarButtonItem1 As DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem
            Dim commandBarSubItem2 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
            Dim commandBarCheckItem10 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem11 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarSubItem3 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
            Dim commandBarCheckItem12 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem13 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarItem8 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarItem9 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarSubItem4 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
            Dim commandBarCheckItem14 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem15 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem16 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem17 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem18 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem19 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem20 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarSubItem5 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
            Dim commandBarCheckItem21 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem22 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarSubItem6 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
            Dim commandBarCheckItem23 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem24 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarSubItem7 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
            Dim commandBarCheckItem25 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem26 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem27 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem28 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem29 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem30 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarCheckItem31 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
            Dim commandBarItem10 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarItem11 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim commandBarItem12 As DevExpress.Snap.Extensions.UI.CommandBarItem
            Dim barButtonGroup8 As DevExpress.XtraBars.BarButtonGroup
            Dim changeEditorRowLimitItem1 As DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem
            Dim repositoryItemEditorRowLimitEdit1 As DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit
            Dim createBarBaseItem1 As DevExpress.XtraCharts.UI.CreateBarBaseItem
            Dim commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
            Dim createLineBaseItem1 As DevExpress.XtraCharts.UI.CreateLineBaseItem
            Dim commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
            Dim createPieBaseItem1 As DevExpress.XtraCharts.UI.CreatePieBaseItem
            Dim commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
            Dim createRotatedBarBaseItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem
            Dim commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
            Dim createAreaBaseItem1 As DevExpress.XtraCharts.UI.CreateAreaBaseItem
            Dim commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
            Dim createOtherSeriesTypesBaseItem1 As DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem
            Dim commandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
            Dim changePaletteGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem
            Dim commandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
            Dim changeAppearanceGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem
            Dim runWizardChartItem1 As DevExpress.XtraCharts.UI.RunWizardChartItem
            Dim headerFooterToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory
            Dim headerFooterToolsDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage
            Dim headerFooterToolsDesignNavigationRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup
            Dim headerFooterToolsDesignOptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup
            Dim headerFooterToolsDesignCloseRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup
            Dim tableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
            Dim tableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
            Dim tableStyleOptionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup
            Dim tableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
            Dim tableCellStylesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup
            Dim tableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
            Dim tableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
            Dim tableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
            Dim tableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
            Dim tableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
            Dim tableCellSizeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup
            Dim tableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
            Dim floatingPictureToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory
            Dim floatingPictureToolsFormatPage1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage
            Dim floatingPictureToolsShapeStylesPageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup
            Dim floatingPictureToolsArrangePageGroup1 As DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup
            Dim dataToolsRibbonPageCategory1 As DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory
            Dim appearanceRibbonPage1 As DevExpress.Snap.Extensions.UI.AppearanceRibbonPage
            Dim themesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup
            Dim snMergeFieldToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage
            Dim dataShapingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup
            Dim snMergeFieldPropertiesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup
            Dim groupToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage
            Dim groupingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup
            Dim listToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.ListToolsRibbonPage
            Dim listHeaderAndFooterRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup
            Dim listCommandsRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup
            Dim listEditorRowLimitRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup
            Dim chartRibbonPageCategory1 As DevExpress.XtraCharts.UI.ChartRibbonPageCategory
            Dim createChartRibbonPage1 As DevExpress.XtraCharts.UI.CreateChartRibbonPage
            Dim chartTypeRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup
            Dim chartAppearanceRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup
            Dim chartWizardRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup
            Dim fileRibbonPage1 As DevExpress.XtraRichEdit.UI.FileRibbonPage
            Dim commonRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
            Dim homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
            Dim clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
            Dim fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
            Dim paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
            Dim stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
            Dim editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
            Dim insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
            Dim pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
            Dim tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
            Dim illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
            Dim toolboxRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup
            Dim linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
            Dim headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
            Dim textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
            Dim symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
            Dim pageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
            Dim pageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
            Dim pageBackgroundRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup
            Dim viewRibbonPage1 As DevExpress.XtraRichEdit.UI.ViewRibbonPage
            Dim documentViewsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup
            Dim showRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup
            Dim zoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
            Dim viewRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup
            Dim viewFieldsRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup
            Dim reviewRibbonPage1 As DevExpress.XtraRichEdit.UI.ReviewRibbonPage
            Dim documentProofingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup
            Dim referencesRibbonPage1 As DevExpress.XtraRichEdit.UI.ReferencesRibbonPage
            Dim tableOfContentsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup
            Dim captionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup
            Dim snapBarController1 As DevExpress.Snap.Extensions.SnapBarController

            Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim resources As New System.ComponentModel.ComponentResourceManager(snapForm.GetType())
            Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItemGroup3 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim borderInfo1 As New DevExpress.XtraRichEdit.Model.BorderInfo()
            Dim chartControlCommandGalleryItemGroup2DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
            Dim createBarChartItem1 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
            Dim createFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
            Dim createSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
            Dim createSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
            Dim createStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
            Dim chartControlCommandGalleryItemGroup3DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
            Dim createBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
            Dim createFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
            Dim createManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
            Dim createSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
            Dim createSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
            Dim createStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupCylinderColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
            Dim createCylinderBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
            Dim createCylinderFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
            Dim createCylinderManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
            Dim createCylinderSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
            Dim createCylinderSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
            Dim createCylinderStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupConeColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
            Dim createConeBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
            Dim createConeFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
            Dim createConeManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
            Dim createConeSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
            Dim createConeSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
            Dim createConeStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupPyramidColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
            Dim createPyramidBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
            Dim createPyramidFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
            Dim createPyramidManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
            Dim createPyramidSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
            Dim createPyramidSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
            Dim createPyramidStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
            Dim createLineChartItem1 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
            Dim createFullStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
            Dim createScatterLineChartItem1 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
            Dim createSplineChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
            Dim createStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
            Dim createStepLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
            Dim chartControlCommandGalleryItemGroup3DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
            Dim createLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
            Dim createFullStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
            Dim createSpline3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
            Dim createStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
            Dim createStepLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
            Dim createPieChartItem1 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
            Dim createDoughnutChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
            Dim createNestedDoughnutChartItem1 As New DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem()
            Dim chartControlCommandGalleryItemGroup3DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
            Dim createPie3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
            Dim createDoughnut3DChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DBar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
            Dim createRotatedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
            Dim createRotatedFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
            Dim createRotatedSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
            Dim createRotatedSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
            Dim createRotatedStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
            Dim chartControlCommandGalleryItemGroup2DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
            Dim createAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
            Dim createFullStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
            Dim createFullStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
            Dim createSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
            Dim createStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
            Dim createStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
            Dim createStepAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
            Dim chartControlCommandGalleryItemGroup3DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
            Dim createArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
            Dim createFullStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
            Dim createFullStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
            Dim createSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
            Dim createStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
            Dim createStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
            Dim createStepArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
            Dim chartControlCommandGalleryItemGroupPoint1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
            Dim createPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
            Dim createBubbleChartItem1 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
            Dim chartControlCommandGalleryItemGroupFunnel1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
            Dim createFunnelChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
            Dim createFunnel3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
            Dim chartControlCommandGalleryItemGroupFinancial1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
            Dim createStockChartItem1 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
            Dim createCandleStickChartItem1 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
            Dim chartControlCommandGalleryItemGroupRadar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
            Dim createRadarPointChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
            Dim createRadarLineChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
            Dim createRadarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
            Dim chartControlCommandGalleryItemGroupPolar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
            Dim createPolarPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
            Dim createPolarLineChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
            Dim createPolarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
            Dim chartControlCommandGalleryItemGroupRange1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
            Dim createRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
            Dim createSideBySideRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
            Dim createRangeAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
            Dim createRangeArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
            Dim chartControlCommandGalleryItemGroupGantt1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
            Dim createGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
            Dim createSideBySideGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
            Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As New DevExpress.Utils.SerializableAppearanceObject()

            ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
            commonRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            fileRibbonPage1 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            commandBarItem1 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            capitalizeEachWordCaseItem1 = New DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem()
            toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
            barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            insertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
            tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            toolboxRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup()
            commandBarItem3 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarItem4 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarItem5 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarItem6 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarItem7 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            pageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
            pageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
            changeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
            setNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
            setNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
            setModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
            setWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
            showPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
            changeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
            setPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
            setLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
            changeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
            changeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
            setSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
            setSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
            setSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
            showColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
            insertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
            insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            insertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
            insertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
            insertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
            insertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
            changeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
            setSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
            setSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
            setSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
            setSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
            toggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
            showLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
            pageBackgroundRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup()
            changePageColorItem1 = New DevExpress.XtraRichEdit.UI.ChangePageColorItem()
            documentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
            viewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
            switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            showRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
            toggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
            toggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
            zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
            zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            viewRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup()
            snapBarToolbarsListItem1 = New DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem()
            commandBarCheckItem1 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            viewFieldsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup()
            showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            toggleFieldHighlightingItem1 = New DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem()
            headerFooterToolsDesignNavigationRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignNavigationRibbonPageGroup()
            headerFooterToolsDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignRibbonPage()
            headerFooterToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsRibbonPageCategory()
            goToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem()
            goToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem()
            goToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem()
            goToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem()
            toggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem()
            headerFooterToolsDesignOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignOptionsRibbonPageGroup()
            toggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem()
            toggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem()
            headerFooterToolsDesignCloseRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterToolsDesignCloseRibbonPageGroup()
            closePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem()
            tableStyleOptionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStyleOptionsRibbonPageGroup()
            tableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
            tableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
            toggleFirstRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstRowItem()
            toggleLastRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastRowItem()
            toggleBandedRowsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem()
            toggleFirstColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem()
            toggleLastColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastColumnItem()
            toggleBandedColumnsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem()
            tableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
            galleryChangeTableStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem()
            tableCellStylesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.TableCellStylesRibbonPageGroup()
            galleryChangeTableCellStyleItem1 = New DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem()
            tableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
            changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            tableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
            tableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
            selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            tableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
            deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            tableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
            mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            tableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
            toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
            toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
            toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
            toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
            tableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
            toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            showTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem()
            documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
            reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
            checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
            tableOfContentsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup()
            referencesRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReferencesRibbonPage()
            insertTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem()
            updateTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem()
            addParagraphsToTableOfContentItem1 = New DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem()
            setParagraphHeadingLevelItem1 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem2 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem3 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem4 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem5 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem6 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem7 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem8 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem9 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            setParagraphHeadingLevelItem10 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            captionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup()
            insertCaptionPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem()
            insertFiguresCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems()
            insertTablesCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems()
            insertEquationsCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems()
            insertTableOfFiguresPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem()
            insertTableOfFiguresItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems()
            insertTableOfTablesItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems()
            insertTableOfEquationsItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems()
            updateTableOfFiguresItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem()
            floatingPictureToolsShapeStylesPageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsShapeStylesPageGroup()
            floatingPictureToolsFormatPage1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsFormatPage()
            floatingPictureToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsRibbonPageCategory()
            changeFloatingObjectFillColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem()
            changeFloatingObjectOutlineColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem()
            changeFloatingObjectOutlineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem()
            repositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
            floatingPictureToolsArrangePageGroup1 = New DevExpress.XtraRichEdit.UI.FloatingPictureToolsArrangePageGroup()
            changeFloatingObjectTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem()
            setFloatingObjectSquareTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem()
            setFloatingObjectTightTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem()
            setFloatingObjectThroughTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem()
            setFloatingObjectTopAndBottomTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem()
            setFloatingObjectBehindTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem()
            setFloatingObjectInFrontOfTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem()
            changeFloatingObjectAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem()
            setFloatingObjectTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem()
            setFloatingObjectTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem()
            setFloatingObjectTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem()
            setFloatingObjectMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem()
            setFloatingObjectMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem()
            setFloatingObjectMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem()
            setFloatingObjectBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem()
            setFloatingObjectBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem()
            setFloatingObjectBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem()
            floatingObjectBringForwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem()
            floatingObjectBringForwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem()
            floatingObjectBringToFrontItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem()
            floatingObjectBringInFrontOfTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem()
            floatingObjectSendBackwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem()
            floatingObjectSendBackwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem()
            floatingObjectSendToBackItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem()
            floatingObjectSendBehindTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem()
            themesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup()
            appearanceRibbonPage1 = New DevExpress.Snap.Extensions.UI.AppearanceRibbonPage()
            dataToolsRibbonPageCategory1 = New DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory()
            themesGalleryBarItem1 = New DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem()
            dataShapingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup()
            snMergeFieldToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage()
            commandBarCheckItem2 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem3 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem4 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarSubItem1 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            commandBarCheckItem5 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem6 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem7 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem8 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem9 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            filterPopupButtonItem1 = New DevExpress.Snap.Extensions.UI.FilterPopupButtonItem()
            snMergeFieldPropertiesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup()
            propertiesBarButtonItem1 = New DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem()
            groupingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup()
            groupToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage()
            commandBarSubItem2 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            commandBarCheckItem10 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem11 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarSubItem3 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            commandBarCheckItem12 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem13 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarItem8 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarItem9 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarSubItem4 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            commandBarCheckItem14 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem15 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem16 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem17 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem18 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem19 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem20 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            listHeaderAndFooterRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup()
            listToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.ListToolsRibbonPage()
            commandBarSubItem5 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            commandBarCheckItem21 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem22 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarSubItem6 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            commandBarCheckItem23 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem24 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarSubItem7 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            commandBarCheckItem25 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem26 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem27 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem28 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem29 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem30 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            commandBarCheckItem31 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            listCommandsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup()
            commandBarItem10 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarItem11 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            commandBarItem12 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            listEditorRowLimitRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup()
            changeEditorRowLimitItem1 = New DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem()
            barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
            repositoryItemEditorRowLimitEdit1 = New DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit()
            chartTypeRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartTypeRibbonPageGroup()
            createChartRibbonPage1 = New DevExpress.XtraCharts.UI.CreateChartRibbonPage()
            chartRibbonPageCategory1 = New DevExpress.XtraCharts.UI.ChartRibbonPageCategory()
            createBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateBarBaseItem()
            commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown()
            createLineBaseItem1 = New DevExpress.XtraCharts.UI.CreateLineBaseItem()
            commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown()
            createPieBaseItem1 = New DevExpress.XtraCharts.UI.CreatePieBaseItem()
            commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown()
            createRotatedBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem()
            commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown()
            createAreaBaseItem1 = New DevExpress.XtraCharts.UI.CreateAreaBaseItem()
            commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown()
            createOtherSeriesTypesBaseItem1 = New DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem()
            commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown()
            chartAppearanceRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartAppearanceRibbonPageGroup()
            changePaletteGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem()
            commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown()
            changeAppearanceGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem()
            chartWizardRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartWizardRibbonPageGroup()
            runWizardChartItem1 = New DevExpress.XtraCharts.UI.RunWizardChartItem()
            CType(ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()

            snapForm.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            ribbonControl1.ExpandCollapseItem.Id = 0
            ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {ribbonControl1.ExpandCollapseItem, undoItem1, redoItem1, fileOpenItem1, fileSaveItem1, fileSaveAsItem1, commandBarItem1, quickPrintItem1, printItem1, printPreviewItem1, pasteItem1, cutItem1, copyItem1, pasteSpecialItem1, barButtonGroup1, changeFontNameItem1, changeFontSizeItem1, fontSizeIncreaseItem1, fontSizeDecreaseItem1, barButtonGroup2, toggleFontBoldItem1, toggleFontItalicItem1, toggleFontUnderlineItem1, toggleFontDoubleUnderlineItem1, toggleFontStrikeoutItem1, toggleFontDoubleStrikeoutItem1, toggleFontSuperscriptItem1, toggleFontSubscriptItem1, barButtonGroup3, changeFontColorItem1, changeFontBackColorItem1, changeTextCaseItem1, makeTextUpperCaseItem1, makeTextLowerCaseItem1, capitalizeEachWordCaseItem1, toggleTextCaseItem1, clearFormattingItem1, barButtonGroup4, toggleBulletedListItem1, toggleNumberingListItem1, toggleMultiLevelListItem1, barButtonGroup5, decreaseIndentItem1, increaseIndentItem1, barButtonGroup6, toggleParagraphAlignmentLeftItem1, toggleParagraphAlignmentCenterItem1, toggleParagraphAlignmentRightItem1, toggleParagraphAlignmentJustifyItem1, toggleShowWhitespaceItem1, barButtonGroup7, changeParagraphLineSpacingItem1, setSingleParagraphSpacingItem1, setSesquialteralParagraphSpacingItem1, setDoubleParagraphSpacingItem1, showLineSpacingFormItem1, addSpacingBeforeParagraphItem1, removeSpacingBeforeParagraphItem1, addSpacingAfterParagraphItem1, removeSpacingAfterParagraphItem1, changeParagraphBackColorItem1, galleryChangeStyleItem1, findItem1, replaceItem1, insertPageBreakItem21, insertTableItem1, insertPictureItem1, insertFloatingPictureItem1, commandBarItem3, commandBarItem4, commandBarItem5, commandBarItem6, commandBarItem7, insertBookmarkItem1, insertHyperlinkItem1, editPageHeaderItem1, editPageFooterItem1, insertPageNumberItem1, insertPageCountItem1, insertTextBoxItem1, insertSymbolItem1, changeSectionPageMarginsItem1, setNormalSectionPageMarginsItem1, setNarrowSectionPageMarginsItem1, setModerateSectionPageMarginsItem1, setWideSectionPageMarginsItem1, showPageMarginsSetupFormItem1, changeSectionPageOrientationItem1, setPortraitPageOrientationItem1, setLandscapePageOrientationItem1, changeSectionPaperKindItem1, changeSectionColumnsItem1, setSectionOneColumnItem1, setSectionTwoColumnsItem1, setSectionThreeColumnsItem1, showColumnsSetupFormItem1, insertBreakItem1, insertPageBreakItem1, insertColumnBreakItem1, insertSectionBreakNextPageItem1, insertSectionBreakEvenPageItem1, insertSectionBreakOddPageItem1, changeSectionLineNumberingItem1, setSectionLineNumberingNoneItem1, setSectionLineNumberingContinuousItem1, setSectionLineNumberingRestartNewPageItem1, setSectionLineNumberingRestartNewSectionItem1, toggleParagraphSuppressLineNumbersItem1, showLineNumberingFormItem1, changePageColorItem1, switchToSimpleViewItem1, switchToDraftViewItem1, switchToPrintLayoutViewItem1, toggleShowHorizontalRulerItem1, toggleShowVerticalRulerItem1, zoomOutItem1, zoomInItem1, snapBarToolbarsListItem1, commandBarCheckItem1, showAllFieldCodesItem1, showAllFieldResultsItem1, toggleFieldHighlightingItem1, goToPageHeaderItem1, goToPageFooterItem1, goToNextHeaderFooterItem1, goToPreviousHeaderFooterItem1, toggleLinkToPreviousItem1, toggleDifferentFirstPageItem1, toggleDifferentOddAndEvenPagesItem1, closePageHeaderFooterItem1, toggleFirstRowItem1, toggleLastRowItem1, toggleBandedRowsItem1, toggleFirstColumnItem1, toggleLastColumnItem1, toggleBandedColumnsItem1, galleryChangeTableStyleItem1, galleryChangeTableCellStyleItem1, changeTableBorderLineStyleItem1, changeTableBorderLineWeightItem1, changeTableBorderColorItem1, changeTableBordersItem1, toggleTableCellsBottomBorderItem1, toggleTableCellsTopBorderItem1, toggleTableCellsLeftBorderItem1, toggleTableCellsRightBorderItem1, resetTableCellsAllBordersItem1, toggleTableCellsAllBordersItem1, toggleTableCellsOutsideBorderItem1, toggleTableCellsInsideBorderItem1, toggleTableCellsInsideHorizontalBorderItem1, toggleTableCellsInsideVerticalBorderItem1, toggleShowTableGridLinesItem1, changeTableCellsShadingItem1, selectTableElementsItem1, selectTableCellItem1, selectTableColumnItem1, selectTableRowItem1, selectTableItem1, showTablePropertiesFormItem1, deleteTableElementsItem1, showDeleteTableCellsFormItem1, deleteTableColumnsItem1, deleteTableRowsItem1, deleteTableItem1, insertTableRowAboveItem1, insertTableRowBelowItem1, insertTableColumnToLeftItem1, insertTableColumnToRightItem1, mergeTableCellsItem1, showSplitTableCellsForm1, splitTableItem1, toggleTableAutoFitItem1, toggleTableAutoFitContentsItem1, toggleTableAutoFitWindowItem1, toggleTableFixedColumnWidthItem1, toggleTableCellsTopLeftAlignmentItem1, toggleTableCellsMiddleLeftAlignmentItem1, toggleTableCellsBottomLeftAlignmentItem1, toggleTableCellsTopCenterAlignmentItem1, toggleTableCellsMiddleCenterAlignmentItem1, toggleTableCellsBottomCenterAlignmentItem1, toggleTableCellsTopRightAlignmentItem1, toggleTableCellsMiddleRightAlignmentItem1, toggleTableCellsBottomRightAlignmentItem1, showTableOptionsFormItem1, checkSpellingItem1, insertTableOfContentsItem1, updateTableOfContentsItem1, addParagraphsToTableOfContentItem1, setParagraphHeadingLevelItem1, setParagraphHeadingLevelItem2, setParagraphHeadingLevelItem3, setParagraphHeadingLevelItem4, setParagraphHeadingLevelItem5, setParagraphHeadingLevelItem6, setParagraphHeadingLevelItem7, setParagraphHeadingLevelItem8, setParagraphHeadingLevelItem9, setParagraphHeadingLevelItem10, insertCaptionPlaceholderItem1, insertFiguresCaptionItems1, insertTablesCaptionItems1, insertEquationsCaptionItems1, insertTableOfFiguresPlaceholderItem1, insertTableOfFiguresItems1, insertTableOfTablesItems1, insertTableOfEquationsItems1, updateTableOfFiguresItem1, changeFloatingObjectFillColorItem1, changeFloatingObjectOutlineColorItem1, changeFloatingObjectOutlineWeightItem1, changeFloatingObjectTextWrapTypeItem1, setFloatingObjectSquareTextWrapTypeItem1, setFloatingObjectTightTextWrapTypeItem1, setFloatingObjectThroughTextWrapTypeItem1, setFloatingObjectTopAndBottomTextWrapTypeItem1, setFloatingObjectBehindTextWrapTypeItem1, setFloatingObjectInFrontOfTextWrapTypeItem1, changeFloatingObjectAlignmentItem1, setFloatingObjectTopLeftAlignmentItem1, setFloatingObjectTopCenterAlignmentItem1, setFloatingObjectTopRightAlignmentItem1, setFloatingObjectMiddleLeftAlignmentItem1, setFloatingObjectMiddleCenterAlignmentItem1, setFloatingObjectMiddleRightAlignmentItem1, setFloatingObjectBottomLeftAlignmentItem1, setFloatingObjectBottomCenterAlignmentItem1, setFloatingObjectBottomRightAlignmentItem1, floatingObjectBringForwardSubItem1, floatingObjectBringForwardItem1, floatingObjectBringToFrontItem1, floatingObjectBringInFrontOfTextItem1, floatingObjectSendBackwardSubItem1, floatingObjectSendBackwardItem1, floatingObjectSendToBackItem1, floatingObjectSendBehindTextItem1, themesGalleryBarItem1, commandBarCheckItem2, commandBarCheckItem3, commandBarCheckItem4, commandBarSubItem1, commandBarCheckItem5, commandBarCheckItem6, commandBarCheckItem7, commandBarCheckItem8, commandBarCheckItem9, filterPopupButtonItem1, propertiesBarButtonItem1, commandBarSubItem2, commandBarCheckItem10, commandBarCheckItem11, commandBarSubItem3, commandBarCheckItem12, commandBarCheckItem13, commandBarItem8, commandBarItem9, commandBarSubItem4, commandBarCheckItem14, commandBarCheckItem15, commandBarCheckItem16, commandBarCheckItem17, commandBarCheckItem18, commandBarCheckItem19, commandBarCheckItem20, commandBarSubItem5, commandBarCheckItem21, commandBarCheckItem22, commandBarSubItem6, commandBarCheckItem23, commandBarCheckItem24, commandBarSubItem7, commandBarCheckItem25, commandBarCheckItem26, commandBarCheckItem27, commandBarCheckItem28, commandBarCheckItem29, commandBarCheckItem30, commandBarCheckItem31, commandBarItem10, commandBarItem11, commandBarItem12, barButtonGroup8, changeEditorRowLimitItem1, createBarBaseItem1, createLineBaseItem1, createPieBaseItem1, createRotatedBarBaseItem1, createAreaBaseItem1, createOtherSeriesTypesBaseItem1, changePaletteGalleryBaseItem1, changeAppearanceGalleryBaseItem1, runWizardChartItem1})
            ribbonControl1.Location = New System.Drawing.Point(0, 0)
            ribbonControl1.MaxItemId = 303
            ribbonControl1.Name = "ribbonControl1"
            ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {headerFooterToolsRibbonPageCategory1, tableToolsRibbonPageCategory1, floatingPictureToolsRibbonPageCategory1, dataToolsRibbonPageCategory1, chartRibbonPageCategory1})
            ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {fileRibbonPage1, homeRibbonPage1, insertRibbonPage1, pageLayoutRibbonPage1, viewRibbonPage1, reviewRibbonPage1, referencesRibbonPage1})
            ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {repositoryItemFontEdit1, repositoryItemRichEditFontSizeEdit1, repositoryItemBorderLineStyle1, repositoryItemBorderLineWeight1, repositoryItemFloatingObjectOutlineWeight1, repositoryItemEditorRowLimitEdit1})
            ribbonControl1.Size = New System.Drawing.Size(952, 142)
            ' 
            ' snapBarController1
            ' 
            snapBarController1.BarItems.Add(undoItem1)
            snapBarController1.BarItems.Add(redoItem1)
            snapBarController1.BarItems.Add(fileOpenItem1)
            snapBarController1.BarItems.Add(fileSaveItem1)
            snapBarController1.BarItems.Add(fileSaveAsItem1)
            snapBarController1.BarItems.Add(commandBarItem1)
            snapBarController1.BarItems.Add(quickPrintItem1)
            snapBarController1.BarItems.Add(printItem1)
            snapBarController1.BarItems.Add(printPreviewItem1)
            snapBarController1.BarItems.Add(pasteItem1)
            snapBarController1.BarItems.Add(cutItem1)
            snapBarController1.BarItems.Add(copyItem1)
            snapBarController1.BarItems.Add(pasteSpecialItem1)
            snapBarController1.BarItems.Add(changeFontNameItem1)
            snapBarController1.BarItems.Add(changeFontSizeItem1)
            snapBarController1.BarItems.Add(fontSizeIncreaseItem1)
            snapBarController1.BarItems.Add(fontSizeDecreaseItem1)
            snapBarController1.BarItems.Add(toggleFontBoldItem1)
            snapBarController1.BarItems.Add(toggleFontItalicItem1)
            snapBarController1.BarItems.Add(toggleFontUnderlineItem1)
            snapBarController1.BarItems.Add(toggleFontDoubleUnderlineItem1)
            snapBarController1.BarItems.Add(toggleFontStrikeoutItem1)
            snapBarController1.BarItems.Add(toggleFontDoubleStrikeoutItem1)
            snapBarController1.BarItems.Add(toggleFontSuperscriptItem1)
            snapBarController1.BarItems.Add(toggleFontSubscriptItem1)
            snapBarController1.BarItems.Add(changeFontColorItem1)
            snapBarController1.BarItems.Add(changeFontBackColorItem1)
            snapBarController1.BarItems.Add(changeTextCaseItem1)
            snapBarController1.BarItems.Add(makeTextUpperCaseItem1)
            snapBarController1.BarItems.Add(makeTextLowerCaseItem1)
            snapBarController1.BarItems.Add(capitalizeEachWordCaseItem1)
            snapBarController1.BarItems.Add(toggleTextCaseItem1)
            snapBarController1.BarItems.Add(clearFormattingItem1)
            snapBarController1.BarItems.Add(toggleBulletedListItem1)
            snapBarController1.BarItems.Add(toggleNumberingListItem1)
            snapBarController1.BarItems.Add(toggleMultiLevelListItem1)
            snapBarController1.BarItems.Add(decreaseIndentItem1)
            snapBarController1.BarItems.Add(increaseIndentItem1)
            snapBarController1.BarItems.Add(toggleParagraphAlignmentLeftItem1)
            snapBarController1.BarItems.Add(toggleParagraphAlignmentCenterItem1)
            snapBarController1.BarItems.Add(toggleParagraphAlignmentRightItem1)
            snapBarController1.BarItems.Add(toggleParagraphAlignmentJustifyItem1)
            snapBarController1.BarItems.Add(toggleShowWhitespaceItem1)
            snapBarController1.BarItems.Add(changeParagraphLineSpacingItem1)
            snapBarController1.BarItems.Add(setSingleParagraphSpacingItem1)
            snapBarController1.BarItems.Add(setSesquialteralParagraphSpacingItem1)
            snapBarController1.BarItems.Add(setDoubleParagraphSpacingItem1)
            snapBarController1.BarItems.Add(showLineSpacingFormItem1)
            snapBarController1.BarItems.Add(addSpacingBeforeParagraphItem1)
            snapBarController1.BarItems.Add(removeSpacingBeforeParagraphItem1)
            snapBarController1.BarItems.Add(addSpacingAfterParagraphItem1)
            snapBarController1.BarItems.Add(removeSpacingAfterParagraphItem1)
            snapBarController1.BarItems.Add(changeParagraphBackColorItem1)
            snapBarController1.BarItems.Add(galleryChangeStyleItem1)
            snapBarController1.BarItems.Add(findItem1)
            snapBarController1.BarItems.Add(replaceItem1)
            snapBarController1.BarItems.Add(insertPageBreakItem21)
            snapBarController1.BarItems.Add(insertTableItem1)
            snapBarController1.BarItems.Add(insertPictureItem1)
            snapBarController1.BarItems.Add(insertFloatingPictureItem1)
            snapBarController1.BarItems.Add(commandBarItem3)
            snapBarController1.BarItems.Add(commandBarItem4)
            snapBarController1.BarItems.Add(commandBarItem5)
            snapBarController1.BarItems.Add(commandBarItem6)
            snapBarController1.BarItems.Add(commandBarItem7)
            snapBarController1.BarItems.Add(insertBookmarkItem1)
            snapBarController1.BarItems.Add(insertHyperlinkItem1)
            snapBarController1.BarItems.Add(editPageHeaderItem1)
            snapBarController1.BarItems.Add(editPageFooterItem1)
            snapBarController1.BarItems.Add(insertPageNumberItem1)
            snapBarController1.BarItems.Add(insertPageCountItem1)
            snapBarController1.BarItems.Add(insertTextBoxItem1)
            snapBarController1.BarItems.Add(insertSymbolItem1)
            snapBarController1.BarItems.Add(changeSectionPageMarginsItem1)
            snapBarController1.BarItems.Add(setNormalSectionPageMarginsItem1)
            snapBarController1.BarItems.Add(setNarrowSectionPageMarginsItem1)
            snapBarController1.BarItems.Add(setModerateSectionPageMarginsItem1)
            snapBarController1.BarItems.Add(setWideSectionPageMarginsItem1)
            snapBarController1.BarItems.Add(showPageMarginsSetupFormItem1)
            snapBarController1.BarItems.Add(changeSectionPageOrientationItem1)
            snapBarController1.BarItems.Add(setPortraitPageOrientationItem1)
            snapBarController1.BarItems.Add(setLandscapePageOrientationItem1)
            snapBarController1.BarItems.Add(changeSectionPaperKindItem1)
            snapBarController1.BarItems.Add(changeSectionColumnsItem1)
            snapBarController1.BarItems.Add(setSectionOneColumnItem1)
            snapBarController1.BarItems.Add(setSectionTwoColumnsItem1)
            snapBarController1.BarItems.Add(setSectionThreeColumnsItem1)
            snapBarController1.BarItems.Add(showColumnsSetupFormItem1)
            snapBarController1.BarItems.Add(insertBreakItem1)
            snapBarController1.BarItems.Add(insertPageBreakItem1)
            snapBarController1.BarItems.Add(insertColumnBreakItem1)
            snapBarController1.BarItems.Add(insertSectionBreakNextPageItem1)
            snapBarController1.BarItems.Add(insertSectionBreakEvenPageItem1)
            snapBarController1.BarItems.Add(insertSectionBreakOddPageItem1)
            snapBarController1.BarItems.Add(changeSectionLineNumberingItem1)
            snapBarController1.BarItems.Add(setSectionLineNumberingNoneItem1)
            snapBarController1.BarItems.Add(setSectionLineNumberingContinuousItem1)
            snapBarController1.BarItems.Add(setSectionLineNumberingRestartNewPageItem1)
            snapBarController1.BarItems.Add(setSectionLineNumberingRestartNewSectionItem1)
            snapBarController1.BarItems.Add(toggleParagraphSuppressLineNumbersItem1)
            snapBarController1.BarItems.Add(showLineNumberingFormItem1)
            snapBarController1.BarItems.Add(changePageColorItem1)
            snapBarController1.BarItems.Add(switchToSimpleViewItem1)
            snapBarController1.BarItems.Add(switchToDraftViewItem1)
            snapBarController1.BarItems.Add(switchToPrintLayoutViewItem1)
            snapBarController1.BarItems.Add(toggleShowHorizontalRulerItem1)
            snapBarController1.BarItems.Add(toggleShowVerticalRulerItem1)
            snapBarController1.BarItems.Add(zoomOutItem1)
            snapBarController1.BarItems.Add(zoomInItem1)
            snapBarController1.BarItems.Add(snapBarToolbarsListItem1)
            snapBarController1.BarItems.Add(commandBarCheckItem1)
            snapBarController1.BarItems.Add(showAllFieldCodesItem1)
            snapBarController1.BarItems.Add(showAllFieldResultsItem1)
            snapBarController1.BarItems.Add(toggleFieldHighlightingItem1)
            snapBarController1.BarItems.Add(goToPageHeaderItem1)
            snapBarController1.BarItems.Add(goToPageFooterItem1)
            snapBarController1.BarItems.Add(goToNextHeaderFooterItem1)
            snapBarController1.BarItems.Add(goToPreviousHeaderFooterItem1)
            snapBarController1.BarItems.Add(toggleLinkToPreviousItem1)
            snapBarController1.BarItems.Add(toggleDifferentFirstPageItem1)
            snapBarController1.BarItems.Add(toggleDifferentOddAndEvenPagesItem1)
            snapBarController1.BarItems.Add(closePageHeaderFooterItem1)
            snapBarController1.BarItems.Add(toggleFirstRowItem1)
            snapBarController1.BarItems.Add(toggleLastRowItem1)
            snapBarController1.BarItems.Add(toggleBandedRowsItem1)
            snapBarController1.BarItems.Add(toggleFirstColumnItem1)
            snapBarController1.BarItems.Add(toggleLastColumnItem1)
            snapBarController1.BarItems.Add(toggleBandedColumnsItem1)
            snapBarController1.BarItems.Add(galleryChangeTableStyleItem1)
            snapBarController1.BarItems.Add(galleryChangeTableCellStyleItem1)
            snapBarController1.BarItems.Add(changeTableBorderLineStyleItem1)
            snapBarController1.BarItems.Add(changeTableBorderLineWeightItem1)
            snapBarController1.BarItems.Add(changeTableBorderColorItem1)
            snapBarController1.BarItems.Add(changeTableBordersItem1)
            snapBarController1.BarItems.Add(toggleTableCellsBottomBorderItem1)
            snapBarController1.BarItems.Add(toggleTableCellsTopBorderItem1)
            snapBarController1.BarItems.Add(toggleTableCellsLeftBorderItem1)
            snapBarController1.BarItems.Add(toggleTableCellsRightBorderItem1)
            snapBarController1.BarItems.Add(resetTableCellsAllBordersItem1)
            snapBarController1.BarItems.Add(toggleTableCellsAllBordersItem1)
            snapBarController1.BarItems.Add(toggleTableCellsOutsideBorderItem1)
            snapBarController1.BarItems.Add(toggleTableCellsInsideBorderItem1)
            snapBarController1.BarItems.Add(toggleTableCellsInsideHorizontalBorderItem1)
            snapBarController1.BarItems.Add(toggleTableCellsInsideVerticalBorderItem1)
            snapBarController1.BarItems.Add(toggleShowTableGridLinesItem1)
            snapBarController1.BarItems.Add(changeTableCellsShadingItem1)
            snapBarController1.BarItems.Add(selectTableElementsItem1)
            snapBarController1.BarItems.Add(selectTableCellItem1)
            snapBarController1.BarItems.Add(selectTableColumnItem1)
            snapBarController1.BarItems.Add(selectTableRowItem1)
            snapBarController1.BarItems.Add(selectTableItem1)
            snapBarController1.BarItems.Add(showTablePropertiesFormItem1)
            snapBarController1.BarItems.Add(deleteTableElementsItem1)
            snapBarController1.BarItems.Add(showDeleteTableCellsFormItem1)
            snapBarController1.BarItems.Add(deleteTableColumnsItem1)
            snapBarController1.BarItems.Add(deleteTableRowsItem1)
            snapBarController1.BarItems.Add(deleteTableItem1)
            snapBarController1.BarItems.Add(insertTableRowAboveItem1)
            snapBarController1.BarItems.Add(insertTableRowBelowItem1)
            snapBarController1.BarItems.Add(insertTableColumnToLeftItem1)
            snapBarController1.BarItems.Add(insertTableColumnToRightItem1)
            snapBarController1.BarItems.Add(mergeTableCellsItem1)
            snapBarController1.BarItems.Add(showSplitTableCellsForm1)
            snapBarController1.BarItems.Add(splitTableItem1)
            snapBarController1.BarItems.Add(toggleTableAutoFitItem1)
            snapBarController1.BarItems.Add(toggleTableAutoFitContentsItem1)
            snapBarController1.BarItems.Add(toggleTableAutoFitWindowItem1)
            snapBarController1.BarItems.Add(toggleTableFixedColumnWidthItem1)
            snapBarController1.BarItems.Add(toggleTableCellsTopLeftAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsMiddleLeftAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsBottomLeftAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsTopCenterAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsMiddleCenterAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsBottomCenterAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsTopRightAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsMiddleRightAlignmentItem1)
            snapBarController1.BarItems.Add(toggleTableCellsBottomRightAlignmentItem1)
            snapBarController1.BarItems.Add(showTableOptionsFormItem1)
            snapBarController1.BarItems.Add(checkSpellingItem1)
            snapBarController1.BarItems.Add(insertTableOfContentsItem1)
            snapBarController1.BarItems.Add(updateTableOfContentsItem1)
            snapBarController1.BarItems.Add(addParagraphsToTableOfContentItem1)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem1)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem2)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem3)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem4)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem5)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem6)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem7)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem8)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem9)
            snapBarController1.BarItems.Add(setParagraphHeadingLevelItem10)
            snapBarController1.BarItems.Add(insertCaptionPlaceholderItem1)
            snapBarController1.BarItems.Add(insertFiguresCaptionItems1)
            snapBarController1.BarItems.Add(insertTablesCaptionItems1)
            snapBarController1.BarItems.Add(insertEquationsCaptionItems1)
            snapBarController1.BarItems.Add(insertTableOfFiguresPlaceholderItem1)
            snapBarController1.BarItems.Add(insertTableOfFiguresItems1)
            snapBarController1.BarItems.Add(insertTableOfTablesItems1)
            snapBarController1.BarItems.Add(insertTableOfEquationsItems1)
            snapBarController1.BarItems.Add(updateTableOfFiguresItem1)
            snapBarController1.BarItems.Add(changeFloatingObjectFillColorItem1)
            snapBarController1.BarItems.Add(changeFloatingObjectOutlineColorItem1)
            snapBarController1.BarItems.Add(changeFloatingObjectOutlineWeightItem1)
            snapBarController1.BarItems.Add(changeFloatingObjectTextWrapTypeItem1)
            snapBarController1.BarItems.Add(setFloatingObjectSquareTextWrapTypeItem1)
            snapBarController1.BarItems.Add(setFloatingObjectTightTextWrapTypeItem1)
            snapBarController1.BarItems.Add(setFloatingObjectThroughTextWrapTypeItem1)
            snapBarController1.BarItems.Add(setFloatingObjectTopAndBottomTextWrapTypeItem1)
            snapBarController1.BarItems.Add(setFloatingObjectBehindTextWrapTypeItem1)
            snapBarController1.BarItems.Add(setFloatingObjectInFrontOfTextWrapTypeItem1)
            snapBarController1.BarItems.Add(changeFloatingObjectAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectTopLeftAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectTopCenterAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectTopRightAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectMiddleLeftAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectMiddleCenterAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectMiddleRightAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectBottomLeftAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectBottomCenterAlignmentItem1)
            snapBarController1.BarItems.Add(setFloatingObjectBottomRightAlignmentItem1)
            snapBarController1.BarItems.Add(floatingObjectBringForwardSubItem1)
            snapBarController1.BarItems.Add(floatingObjectBringForwardItem1)
            snapBarController1.BarItems.Add(floatingObjectBringToFrontItem1)
            snapBarController1.BarItems.Add(floatingObjectBringInFrontOfTextItem1)
            snapBarController1.BarItems.Add(floatingObjectSendBackwardSubItem1)
            snapBarController1.BarItems.Add(floatingObjectSendBackwardItem1)
            snapBarController1.BarItems.Add(floatingObjectSendToBackItem1)
            snapBarController1.BarItems.Add(floatingObjectSendBehindTextItem1)
            snapBarController1.BarItems.Add(themesGalleryBarItem1)
            snapBarController1.BarItems.Add(commandBarCheckItem2)
            snapBarController1.BarItems.Add(commandBarCheckItem3)
            snapBarController1.BarItems.Add(commandBarCheckItem4)
            snapBarController1.BarItems.Add(commandBarSubItem1)
            snapBarController1.BarItems.Add(commandBarCheckItem5)
            snapBarController1.BarItems.Add(commandBarCheckItem6)
            snapBarController1.BarItems.Add(commandBarCheckItem7)
            snapBarController1.BarItems.Add(commandBarCheckItem8)
            snapBarController1.BarItems.Add(commandBarCheckItem9)
            snapBarController1.BarItems.Add(filterPopupButtonItem1)
            snapBarController1.BarItems.Add(propertiesBarButtonItem1)
            snapBarController1.BarItems.Add(commandBarSubItem2)
            snapBarController1.BarItems.Add(commandBarCheckItem10)
            snapBarController1.BarItems.Add(commandBarCheckItem11)
            snapBarController1.BarItems.Add(commandBarSubItem3)
            snapBarController1.BarItems.Add(commandBarCheckItem12)
            snapBarController1.BarItems.Add(commandBarCheckItem13)
            snapBarController1.BarItems.Add(commandBarItem8)
            snapBarController1.BarItems.Add(commandBarItem9)
            snapBarController1.BarItems.Add(commandBarSubItem4)
            snapBarController1.BarItems.Add(commandBarCheckItem14)
            snapBarController1.BarItems.Add(commandBarCheckItem15)
            snapBarController1.BarItems.Add(commandBarCheckItem16)
            snapBarController1.BarItems.Add(commandBarCheckItem17)
            snapBarController1.BarItems.Add(commandBarCheckItem18)
            snapBarController1.BarItems.Add(commandBarCheckItem19)
            snapBarController1.BarItems.Add(commandBarCheckItem20)
            snapBarController1.BarItems.Add(commandBarSubItem5)
            snapBarController1.BarItems.Add(commandBarCheckItem21)
            snapBarController1.BarItems.Add(commandBarCheckItem22)
            snapBarController1.BarItems.Add(commandBarSubItem6)
            snapBarController1.BarItems.Add(commandBarCheckItem23)
            snapBarController1.BarItems.Add(commandBarCheckItem24)
            snapBarController1.BarItems.Add(commandBarSubItem7)
            snapBarController1.BarItems.Add(commandBarCheckItem25)
            snapBarController1.BarItems.Add(commandBarCheckItem26)
            snapBarController1.BarItems.Add(commandBarCheckItem27)
            snapBarController1.BarItems.Add(commandBarCheckItem28)
            snapBarController1.BarItems.Add(commandBarCheckItem29)
            snapBarController1.BarItems.Add(commandBarCheckItem30)
            snapBarController1.BarItems.Add(commandBarCheckItem31)
            snapBarController1.BarItems.Add(commandBarItem10)
            snapBarController1.BarItems.Add(commandBarItem11)
            snapBarController1.BarItems.Add(commandBarItem12)
            snapBarController1.BarItems.Add(changeEditorRowLimitItem1)
            snapBarController1.BarItems.Add(createBarBaseItem1)
            snapBarController1.BarItems.Add(createLineBaseItem1)
            snapBarController1.BarItems.Add(createPieBaseItem1)
            snapBarController1.BarItems.Add(createRotatedBarBaseItem1)
            snapBarController1.BarItems.Add(createAreaBaseItem1)
            snapBarController1.BarItems.Add(createOtherSeriesTypesBaseItem1)
            snapBarController1.BarItems.Add(changePaletteGalleryBaseItem1)
            snapBarController1.BarItems.Add(changeAppearanceGalleryBaseItem1)
            snapBarController1.BarItems.Add(runWizardChartItem1)
            snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(headerFooterToolsRibbonPageCategory1))
            snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(tableToolsRibbonPageCategory1))
            snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(floatingPictureToolsRibbonPageCategory1))
            snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(dataToolsRibbonPageCategory1))
            snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(chartRibbonPageCategory1))
            snapBarController1.Control = snapControl
            snapBarController1.RibbonControl = ribbonControl1
            snapBarController1.SnapDockManager = dockManager
            ' 
            ' commonRibbonPageGroup1
            ' 
            commonRibbonPageGroup1.ItemLinks.Add(undoItem1)
            commonRibbonPageGroup1.ItemLinks.Add(redoItem1)
            commonRibbonPageGroup1.ItemLinks.Add(fileOpenItem1)
            commonRibbonPageGroup1.ItemLinks.Add(fileSaveItem1)
            commonRibbonPageGroup1.ItemLinks.Add(fileSaveAsItem1)
            commonRibbonPageGroup1.ItemLinks.Add(commandBarItem1)
            commonRibbonPageGroup1.ItemLinks.Add(quickPrintItem1)
            commonRibbonPageGroup1.ItemLinks.Add(printItem1)
            commonRibbonPageGroup1.ItemLinks.Add(printPreviewItem1)
            commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {commonRibbonPageGroup1})
            fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' undoItem1
            ' 
            undoItem1.Id = 1
            undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            redoItem1.Id = 2
            redoItem1.Name = "redoItem1"
            ' 
            ' fileOpenItem1
            ' 
            fileOpenItem1.Id = 4
            fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            fileSaveItem1.Id = 5
            fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            fileSaveAsItem1.Id = 6
            fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' commandBarItem1
            ' 
            commandBarItem1.Id = 7
            commandBarItem1.Name = "commandBarItem1"
            commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
            ' 
            ' quickPrintItem1
            ' 
            quickPrintItem1.Id = 8
            quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            printItem1.Id = 9
            printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            printPreviewItem1.Id = 10
            printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            clipboardRibbonPageGroup1.ItemLinks.Add(pasteItem1)
            clipboardRibbonPageGroup1.ItemLinks.Add(cutItem1)
            clipboardRibbonPageGroup1.ItemLinks.Add(copyItem1)
            clipboardRibbonPageGroup1.ItemLinks.Add(pasteSpecialItem1)
            clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {clipboardRibbonPageGroup1, fontRibbonPageGroup1, paragraphRibbonPageGroup1, stylesRibbonPageGroup1, editingRibbonPageGroup1})
            homeRibbonPage1.Name = "homeRibbonPage1"
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation1.Group = stylesRibbonPageGroup1
            reduceOperation1.ItemLinkIndex = 0
            reduceOperation1.ItemLinksCount = 0
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            homeRibbonPage1.ReduceOperations.Add(reduceOperation1)
            ' 
            ' pasteItem1
            ' 
            pasteItem1.Id = 19
            pasteItem1.Name = "pasteItem1"
            ' 
            ' cutItem1
            ' 
            cutItem1.Id = 20
            cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            copyItem1.Id = 21
            copyItem1.Name = "copyItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            pasteSpecialItem1.Id = 22
            pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            fontRibbonPageGroup1.ItemLinks.Add(barButtonGroup1)
            fontRibbonPageGroup1.ItemLinks.Add(barButtonGroup2)
            fontRibbonPageGroup1.ItemLinks.Add(barButtonGroup3)
            fontRibbonPageGroup1.ItemLinks.Add(changeTextCaseItem1)
            fontRibbonPageGroup1.ItemLinks.Add(clearFormattingItem1)
            fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            ' 
            ' changeFontNameItem1
            ' 
            changeFontNameItem1.Edit = repositoryItemFontEdit1
            changeFontNameItem1.Id = 23
            changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' changeFontSizeItem1
            ' 
            changeFontSizeItem1.Edit = repositoryItemRichEditFontSizeEdit1
            changeFontSizeItem1.Id = 24
            changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' fontSizeIncreaseItem1
            ' 
            fontSizeIncreaseItem1.Id = 25
            fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            fontSizeDecreaseItem1.Id = 26
            fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' toggleFontBoldItem1
            ' 
            toggleFontBoldItem1.Id = 27
            toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            toggleFontItalicItem1.Id = 28
            toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            toggleFontUnderlineItem1.Id = 29
            toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            toggleFontDoubleUnderlineItem1.Id = 30
            toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            toggleFontStrikeoutItem1.Id = 31
            toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            toggleFontDoubleStrikeoutItem1.Id = 32
            toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            toggleFontSuperscriptItem1.Id = 33
            toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            toggleFontSubscriptItem1.Id = 34
            toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' changeFontColorItem1
            ' 
            changeFontColorItem1.Id = 35
            changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            changeFontBackColorItem1.Id = 36
            changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' changeTextCaseItem1
            ' 
            changeTextCaseItem1.Id = 37
            changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(makeTextUpperCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(makeTextLowerCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(capitalizeEachWordCaseItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTextCaseItem1)})
            changeTextCaseItem1.Name = "changeTextCaseItem1"
            ' 
            ' makeTextUpperCaseItem1
            ' 
            makeTextUpperCaseItem1.Id = 38
            makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            ' 
            ' makeTextLowerCaseItem1
            ' 
            makeTextLowerCaseItem1.Id = 39
            makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            ' 
            ' capitalizeEachWordCaseItem1
            ' 
            capitalizeEachWordCaseItem1.Id = 40
            capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
            ' 
            ' toggleTextCaseItem1
            ' 
            toggleTextCaseItem1.Id = 41
            toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            clearFormattingItem1.Id = 42
            clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' barButtonGroup1
            ' 
            barButtonGroup1.Id = 12
            barButtonGroup1.ItemLinks.Add(changeFontNameItem1)
            barButtonGroup1.ItemLinks.Add(changeFontSizeItem1)
            barButtonGroup1.ItemLinks.Add(fontSizeIncreaseItem1)
            barButtonGroup1.ItemLinks.Add(fontSizeDecreaseItem1)
            barButtonGroup1.Name = "barButtonGroup1"
            barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' repositoryItemFontEdit1
            ' 
            repositoryItemFontEdit1.AutoHeight = False
            repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemRichEditFontSizeEdit1.Control = snapControl
            repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' barButtonGroup2
            ' 
            barButtonGroup2.Id = 13
            barButtonGroup2.ItemLinks.Add(toggleFontBoldItem1)
            barButtonGroup2.ItemLinks.Add(toggleFontItalicItem1)
            barButtonGroup2.ItemLinks.Add(toggleFontUnderlineItem1)
            barButtonGroup2.ItemLinks.Add(toggleFontDoubleUnderlineItem1)
            barButtonGroup2.ItemLinks.Add(toggleFontStrikeoutItem1)
            barButtonGroup2.ItemLinks.Add(toggleFontDoubleStrikeoutItem1)
            barButtonGroup2.ItemLinks.Add(toggleFontSuperscriptItem1)
            barButtonGroup2.ItemLinks.Add(toggleFontSubscriptItem1)
            barButtonGroup2.Name = "barButtonGroup2"
            barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            ' 
            ' barButtonGroup3
            ' 
            barButtonGroup3.Id = 14
            barButtonGroup3.ItemLinks.Add(changeFontColorItem1)
            barButtonGroup3.ItemLinks.Add(changeFontBackColorItem1)
            barButtonGroup3.Name = "barButtonGroup3"
            barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            ' 
            ' paragraphRibbonPageGroup1
            ' 
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup4)
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup5)
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup6)
            paragraphRibbonPageGroup1.ItemLinks.Add(barButtonGroup7)
            paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            ' 
            ' toggleBulletedListItem1
            ' 
            toggleBulletedListItem1.Id = 43
            toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            toggleNumberingListItem1.Id = 44
            toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            toggleMultiLevelListItem1.Id = 45
            toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' decreaseIndentItem1
            ' 
            decreaseIndentItem1.Id = 46
            decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            increaseIndentItem1.Id = 47
            increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            toggleParagraphAlignmentLeftItem1.Id = 48
            toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            toggleParagraphAlignmentCenterItem1.Id = 49
            toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            toggleParagraphAlignmentRightItem1.Id = 50
            toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            toggleParagraphAlignmentJustifyItem1.Id = 51
            toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            toggleShowWhitespaceItem1.Id = 52
            toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' changeParagraphLineSpacingItem1
            ' 
            changeParagraphLineSpacingItem1.Id = 53
            changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setSingleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(setSesquialteralParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(setDoubleParagraphSpacingItem1), New DevExpress.XtraBars.LinkPersistInfo(showLineSpacingFormItem1), New DevExpress.XtraBars.LinkPersistInfo(addSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(removeSpacingBeforeParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(addSpacingAfterParagraphItem1), New DevExpress.XtraBars.LinkPersistInfo(removeSpacingAfterParagraphItem1)})
            changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            ' 
            ' setSingleParagraphSpacingItem1
            ' 
            setSingleParagraphSpacingItem1.Id = 54
            setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            ' 
            ' setSesquialteralParagraphSpacingItem1
            ' 
            setSesquialteralParagraphSpacingItem1.Id = 55
            setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            ' 
            ' setDoubleParagraphSpacingItem1
            ' 
            setDoubleParagraphSpacingItem1.Id = 56
            setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            ' 
            ' showLineSpacingFormItem1
            ' 
            showLineSpacingFormItem1.Id = 57
            showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            ' 
            ' addSpacingBeforeParagraphItem1
            ' 
            addSpacingBeforeParagraphItem1.Id = 58
            addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            ' 
            ' removeSpacingBeforeParagraphItem1
            ' 
            removeSpacingBeforeParagraphItem1.Id = 59
            removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            ' 
            ' addSpacingAfterParagraphItem1
            ' 
            addSpacingAfterParagraphItem1.Id = 60
            addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            ' 
            ' removeSpacingAfterParagraphItem1
            ' 
            removeSpacingAfterParagraphItem1.Id = 61
            removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            ' 
            ' changeParagraphBackColorItem1
            ' 
            changeParagraphBackColorItem1.Id = 62
            changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            ' 
            ' barButtonGroup4
            ' 
            barButtonGroup4.Id = 15
            barButtonGroup4.ItemLinks.Add(toggleBulletedListItem1)
            barButtonGroup4.ItemLinks.Add(toggleNumberingListItem1)
            barButtonGroup4.ItemLinks.Add(toggleMultiLevelListItem1)
            barButtonGroup4.Name = "barButtonGroup4"
            barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' barButtonGroup5
            ' 
            barButtonGroup5.Id = 16
            barButtonGroup5.ItemLinks.Add(decreaseIndentItem1)
            barButtonGroup5.ItemLinks.Add(increaseIndentItem1)
            barButtonGroup5.ItemLinks.Add(toggleShowWhitespaceItem1)
            barButtonGroup5.Name = "barButtonGroup5"
            barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            ' 
            ' barButtonGroup6
            ' 
            barButtonGroup6.Id = 17
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentLeftItem1)
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentCenterItem1)
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentRightItem1)
            barButtonGroup6.ItemLinks.Add(toggleParagraphAlignmentJustifyItem1)
            barButtonGroup6.Name = "barButtonGroup6"
            barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            ' 
            ' barButtonGroup7
            ' 
            barButtonGroup7.Id = 18
            barButtonGroup7.ItemLinks.Add(changeParagraphLineSpacingItem1)
            barButtonGroup7.ItemLinks.Add(changeParagraphBackColorItem1)
            barButtonGroup7.Name = "barButtonGroup7"
            barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            ' 
            ' stylesRibbonPageGroup1
            ' 
            stylesRibbonPageGroup1.ItemLinks.Add(galleryChangeStyleItem1)
            stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            ' 
            ' galleryChangeStyleItem1
            ' 
            ' 
            ' 
            ' 
            galleryChangeStyleItem1.Gallery.ColumnCount = 10
            galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            galleryChangeStyleItem1.Id = 63
            galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            ' 
            ' editingRibbonPageGroup1
            ' 
            editingRibbonPageGroup1.ItemLinks.Add(findItem1)
            editingRibbonPageGroup1.ItemLinks.Add(replaceItem1)
            editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' findItem1
            ' 
            findItem1.Id = 64
            findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            replaceItem1.Id = 65
            replaceItem1.Name = "replaceItem1"
            ' 
            ' pagesRibbonPageGroup1
            ' 
            pagesRibbonPageGroup1.AllowTextClipping = False
            pagesRibbonPageGroup1.ItemLinks.Add(insertPageBreakItem21)
            pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            ' 
            ' insertRibbonPage1
            ' 
            insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {pagesRibbonPageGroup1, tablesRibbonPageGroup1, illustrationsRibbonPageGroup1, toolboxRibbonPageGroup1, linksRibbonPageGroup1, headerFooterRibbonPageGroup1, textRibbonPageGroup1, symbolsRibbonPageGroup1})
            insertRibbonPage1.Name = "insertRibbonPage1"
            ' 
            ' insertPageBreakItem21
            ' 
            insertPageBreakItem21.Id = 66
            insertPageBreakItem21.Name = "insertPageBreakItem21"
            ' 
            ' tablesRibbonPageGroup1
            ' 
            tablesRibbonPageGroup1.AllowTextClipping = False
            tablesRibbonPageGroup1.ItemLinks.Add(insertTableItem1)
            tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' insertTableItem1
            ' 
            insertTableItem1.Id = 67
            insertTableItem1.Name = "insertTableItem1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            illustrationsRibbonPageGroup1.ItemLinks.Add(insertPictureItem1)
            illustrationsRibbonPageGroup1.ItemLinks.Add(insertFloatingPictureItem1)
            illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' insertPictureItem1
            ' 
            insertPictureItem1.Id = 68
            insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' insertFloatingPictureItem1
            ' 
            insertFloatingPictureItem1.Id = 69
            insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            ' 
            ' toolboxRibbonPageGroup1
            ' 
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem3)
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem4)
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem5)
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem6)
            toolboxRibbonPageGroup1.ItemLinks.Add(commandBarItem7)
            toolboxRibbonPageGroup1.Name = "toolboxRibbonPageGroup1"
            ' 
            ' commandBarItem3
            ' 
            commandBarItem3.Id = 70
            commandBarItem3.Name = "commandBarItem3"
            commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertBarCode
            ' 
            ' commandBarItem4
            ' 
            commandBarItem4.Id = 71
            commandBarItem4.Name = "commandBarItem4"
            commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertCheckBox
            ' 
            ' commandBarItem5
            ' 
            commandBarItem5.Id = 72
            commandBarItem5.Name = "commandBarItem5"
            commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertChart
            ' 
            ' commandBarItem6
            ' 
            commandBarItem6.Id = 73
            commandBarItem6.Name = "commandBarItem6"
            commandBarItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSparkline
            ' 
            ' commandBarItem7
            ' 
            commandBarItem7.Id = 74
            commandBarItem7.Name = "commandBarItem7"
            commandBarItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertIndex
            ' 
            ' linksRibbonPageGroup1
            ' 
            linksRibbonPageGroup1.ItemLinks.Add(insertBookmarkItem1)
            linksRibbonPageGroup1.ItemLinks.Add(insertHyperlinkItem1)
            linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' insertBookmarkItem1
            ' 
            insertBookmarkItem1.Id = 75
            insertBookmarkItem1.Name = "insertBookmarkItem1"
            ' 
            ' insertHyperlinkItem1
            ' 
            insertHyperlinkItem1.Id = 76
            insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            ' 
            ' headerFooterRibbonPageGroup1
            ' 
            headerFooterRibbonPageGroup1.ItemLinks.Add(editPageHeaderItem1)
            headerFooterRibbonPageGroup1.ItemLinks.Add(editPageFooterItem1)
            headerFooterRibbonPageGroup1.ItemLinks.Add(insertPageNumberItem1)
            headerFooterRibbonPageGroup1.ItemLinks.Add(insertPageCountItem1)
            headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            ' 
            ' editPageHeaderItem1
            ' 
            editPageHeaderItem1.Id = 77
            editPageHeaderItem1.Name = "editPageHeaderItem1"
            ' 
            ' editPageFooterItem1
            ' 
            editPageFooterItem1.Id = 78
            editPageFooterItem1.Name = "editPageFooterItem1"
            ' 
            ' insertPageNumberItem1
            ' 
            insertPageNumberItem1.Id = 79
            insertPageNumberItem1.Name = "insertPageNumberItem1"
            ' 
            ' insertPageCountItem1
            ' 
            insertPageCountItem1.Id = 80
            insertPageCountItem1.Name = "insertPageCountItem1"
            ' 
            ' textRibbonPageGroup1
            ' 
            textRibbonPageGroup1.ItemLinks.Add(insertTextBoxItem1)
            textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            ' 
            ' insertTextBoxItem1
            ' 
            insertTextBoxItem1.Id = 81
            insertTextBoxItem1.Name = "insertTextBoxItem1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            symbolsRibbonPageGroup1.AllowTextClipping = False
            symbolsRibbonPageGroup1.ItemLinks.Add(insertSymbolItem1)
            symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' insertSymbolItem1
            ' 
            insertSymbolItem1.Id = 82
            insertSymbolItem1.Name = "insertSymbolItem1"
            ' 
            ' pageSetupRibbonPageGroup1
            ' 
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionPageMarginsItem1)
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionPageOrientationItem1)
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionPaperKindItem1)
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionColumnsItem1)
            pageSetupRibbonPageGroup1.ItemLinks.Add(insertBreakItem1)
            pageSetupRibbonPageGroup1.ItemLinks.Add(changeSectionLineNumberingItem1)
            pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
            ' 
            ' pageLayoutRibbonPage1
            ' 
            pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {pageSetupRibbonPageGroup1, pageBackgroundRibbonPageGroup1})
            pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
            ' 
            ' changeSectionPageMarginsItem1
            ' 
            changeSectionPageMarginsItem1.Id = 83
            changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setNormalSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(setNarrowSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(setModerateSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(setWideSectionPageMarginsItem1), New DevExpress.XtraBars.LinkPersistInfo(showPageMarginsSetupFormItem1, True)})
            changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            ' 
            ' setNormalSectionPageMarginsItem1
            ' 
            setNormalSectionPageMarginsItem1.Id = 84
            setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            ' 
            ' setNarrowSectionPageMarginsItem1
            ' 
            setNarrowSectionPageMarginsItem1.Id = 85
            setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            ' 
            ' setModerateSectionPageMarginsItem1
            ' 
            setModerateSectionPageMarginsItem1.Id = 86
            setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            ' 
            ' setWideSectionPageMarginsItem1
            ' 
            setWideSectionPageMarginsItem1.Id = 87
            setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            ' 
            ' showPageMarginsSetupFormItem1
            ' 
            showPageMarginsSetupFormItem1.Id = 88
            showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
            ' 
            ' changeSectionPageOrientationItem1
            ' 
            changeSectionPageOrientationItem1.Id = 89
            changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setPortraitPageOrientationItem1), New DevExpress.XtraBars.LinkPersistInfo(setLandscapePageOrientationItem1)})
            changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            ' 
            ' setPortraitPageOrientationItem1
            ' 
            setPortraitPageOrientationItem1.Id = 90
            setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            ' 
            ' setLandscapePageOrientationItem1
            ' 
            setLandscapePageOrientationItem1.Id = 91
            setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            ' 
            ' changeSectionPaperKindItem1
            ' 
            changeSectionPaperKindItem1.Id = 92
            changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            ' 
            ' changeSectionColumnsItem1
            ' 
            changeSectionColumnsItem1.Id = 93
            changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setSectionOneColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(setSectionTwoColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(setSectionThreeColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(showColumnsSetupFormItem1, True)})
            changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            ' 
            ' setSectionOneColumnItem1
            ' 
            setSectionOneColumnItem1.Id = 94
            setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            ' 
            ' setSectionTwoColumnsItem1
            ' 
            setSectionTwoColumnsItem1.Id = 95
            setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            ' 
            ' setSectionThreeColumnsItem1
            ' 
            setSectionThreeColumnsItem1.Id = 96
            setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            ' 
            ' showColumnsSetupFormItem1
            ' 
            showColumnsSetupFormItem1.Id = 97
            showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            ' 
            ' insertBreakItem1
            ' 
            insertBreakItem1.Id = 98
            insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(insertPageBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(insertColumnBreakItem1), New DevExpress.XtraBars.LinkPersistInfo(insertSectionBreakNextPageItem1), New DevExpress.XtraBars.LinkPersistInfo(insertSectionBreakEvenPageItem1), New DevExpress.XtraBars.LinkPersistInfo(insertSectionBreakOddPageItem1)})
            insertBreakItem1.Name = "insertBreakItem1"
            ' 
            ' insertPageBreakItem1
            ' 
            insertPageBreakItem1.Id = 99
            insertPageBreakItem1.Name = "insertPageBreakItem1"
            ' 
            ' insertColumnBreakItem1
            ' 
            insertColumnBreakItem1.Id = 100
            insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            ' 
            ' insertSectionBreakNextPageItem1
            ' 
            insertSectionBreakNextPageItem1.Id = 101
            insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            ' 
            ' insertSectionBreakEvenPageItem1
            ' 
            insertSectionBreakEvenPageItem1.Id = 102
            insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            ' 
            ' insertSectionBreakOddPageItem1
            ' 
            insertSectionBreakOddPageItem1.Id = 103
            insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            ' 
            ' changeSectionLineNumberingItem1
            ' 
            changeSectionLineNumberingItem1.Id = 104
            changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingContinuousItem1), New DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingRestartNewPageItem1), New DevExpress.XtraBars.LinkPersistInfo(setSectionLineNumberingRestartNewSectionItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleParagraphSuppressLineNumbersItem1), New DevExpress.XtraBars.LinkPersistInfo(showLineNumberingFormItem1, True)})
            changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            ' 
            ' setSectionLineNumberingNoneItem1
            ' 
            setSectionLineNumberingNoneItem1.Id = 105
            setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            ' 
            ' setSectionLineNumberingContinuousItem1
            ' 
            setSectionLineNumberingContinuousItem1.Id = 106
            setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            ' 
            ' setSectionLineNumberingRestartNewPageItem1
            ' 
            setSectionLineNumberingRestartNewPageItem1.Id = 107
            setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            ' 
            ' setSectionLineNumberingRestartNewSectionItem1
            ' 
            setSectionLineNumberingRestartNewSectionItem1.Id = 108
            setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            ' 
            ' toggleParagraphSuppressLineNumbersItem1
            ' 
            toggleParagraphSuppressLineNumbersItem1.Id = 109
            toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            ' 
            ' showLineNumberingFormItem1
            ' 
            showLineNumberingFormItem1.Id = 110
            showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            ' 
            ' pageBackgroundRibbonPageGroup1
            ' 
            pageBackgroundRibbonPageGroup1.AllowTextClipping = False
            pageBackgroundRibbonPageGroup1.ItemLinks.Add(changePageColorItem1)
            pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1"
            ' 
            ' changePageColorItem1
            ' 
            changePageColorItem1.Id = 111
            changePageColorItem1.Name = "changePageColorItem1"
            ' 
            ' documentViewsRibbonPageGroup1
            ' 
            documentViewsRibbonPageGroup1.ItemLinks.Add(switchToSimpleViewItem1)
            documentViewsRibbonPageGroup1.ItemLinks.Add(switchToDraftViewItem1)
            documentViewsRibbonPageGroup1.ItemLinks.Add(switchToPrintLayoutViewItem1)
            documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {documentViewsRibbonPageGroup1, showRibbonPageGroup1, zoomRibbonPageGroup1, viewRibbonPageGroup1, viewFieldsRibbonPageGroup1})
            viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' switchToSimpleViewItem1
            ' 
            switchToSimpleViewItem1.Id = 112
            switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            ' 
            ' switchToDraftViewItem1
            ' 
            switchToDraftViewItem1.Id = 113
            switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            ' 
            ' switchToPrintLayoutViewItem1
            ' 
            switchToPrintLayoutViewItem1.Id = 114
            switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            ' 
            ' showRibbonPageGroup1
            ' 
            showRibbonPageGroup1.ItemLinks.Add(toggleShowHorizontalRulerItem1)
            showRibbonPageGroup1.ItemLinks.Add(toggleShowVerticalRulerItem1)
            showRibbonPageGroup1.Name = "showRibbonPageGroup1"
            ' 
            ' toggleShowHorizontalRulerItem1
            ' 
            toggleShowHorizontalRulerItem1.Id = 115
            toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
            ' 
            ' toggleShowVerticalRulerItem1
            ' 
            toggleShowVerticalRulerItem1.Id = 116
            toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
            ' 
            ' zoomRibbonPageGroup1
            ' 
            zoomRibbonPageGroup1.ItemLinks.Add(zoomOutItem1)
            zoomRibbonPageGroup1.ItemLinks.Add(zoomInItem1)
            zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
            ' 
            ' zoomOutItem1
            ' 
            zoomOutItem1.Id = 117
            zoomOutItem1.Name = "zoomOutItem1"
            ' 
            ' zoomInItem1
            ' 
            zoomInItem1.Id = 118
            zoomInItem1.Name = "zoomInItem1"
            ' 
            ' viewRibbonPageGroup1
            ' 
            viewRibbonPageGroup1.ItemLinks.Add(snapBarToolbarsListItem1)
            viewRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem1)
            viewRibbonPageGroup1.Name = "viewRibbonPageGroup1"
            ' 
            ' snapBarToolbarsListItem1
            ' 
            snapBarToolbarsListItem1.Caption = "&Windows"
            snapBarToolbarsListItem1.Hint = "Show or hide the Data Explorer and Report Explorer windows."
            snapBarToolbarsListItem1.Id = 119
            snapBarToolbarsListItem1.Name = "snapBarToolbarsListItem1"
            snapBarToolbarsListItem1.ShowCustomizationItem = False
            snapBarToolbarsListItem1.ShowDockPanels = True
            snapBarToolbarsListItem1.ShowToolbars = False
            ' 
            ' commandBarCheckItem1
            ' 
            commandBarCheckItem1.Id = 120
            commandBarCheckItem1.Name = "commandBarCheckItem1"
            commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.HighlightActiveElement
            ' 
            ' viewFieldsRibbonPageGroup1
            ' 
            viewFieldsRibbonPageGroup1.ItemLinks.Add(showAllFieldCodesItem1)
            viewFieldsRibbonPageGroup1.ItemLinks.Add(showAllFieldResultsItem1)
            viewFieldsRibbonPageGroup1.ItemLinks.Add(toggleFieldHighlightingItem1)
            viewFieldsRibbonPageGroup1.Name = "viewFieldsRibbonPageGroup1"
            ' 
            ' showAllFieldCodesItem1
            ' 
            showAllFieldCodesItem1.Id = 121
            showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            ' 
            ' showAllFieldResultsItem1
            ' 
            showAllFieldResultsItem1.Id = 122
            showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            ' 
            ' toggleFieldHighlightingItem1
            ' 
            toggleFieldHighlightingItem1.Id = 123
            toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1"
            ' 
            ' headerFooterToolsDesignNavigationRibbonPageGroup1
            ' 
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToPageHeaderItem1)
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToPageFooterItem1)
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToNextHeaderFooterItem1)
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(goToPreviousHeaderFooterItem1)
            headerFooterToolsDesignNavigationRibbonPageGroup1.ItemLinks.Add(toggleLinkToPreviousItem1)
            headerFooterToolsDesignNavigationRibbonPageGroup1.Name = "headerFooterToolsDesignNavigationRibbonPageGroup1"
            ' 
            ' headerFooterToolsDesignRibbonPage1
            ' 
            headerFooterToolsDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {headerFooterToolsDesignNavigationRibbonPageGroup1, headerFooterToolsDesignOptionsRibbonPageGroup1, headerFooterToolsDesignCloseRibbonPageGroup1})
            headerFooterToolsDesignRibbonPage1.Name = "headerFooterToolsDesignRibbonPage1"
            ' 
            ' headerFooterToolsRibbonPageCategory1
            ' 
            headerFooterToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(38))))), (CInt(Fix((CByte(176))))), (CInt(Fix((CByte(35))))))
            headerFooterToolsRibbonPageCategory1.Control = snapControl
            headerFooterToolsRibbonPageCategory1.Name = "headerFooterToolsRibbonPageCategory1"
            headerFooterToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {headerFooterToolsDesignRibbonPage1})
            ' 
            ' goToPageHeaderItem1
            ' 
            goToPageHeaderItem1.Id = 124
            goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            ' 
            ' goToPageFooterItem1
            ' 
            goToPageFooterItem1.Id = 125
            goToPageFooterItem1.Name = "goToPageFooterItem1"
            ' 
            ' goToNextHeaderFooterItem1
            ' 
            goToNextHeaderFooterItem1.Id = 126
            goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            ' 
            ' goToPreviousHeaderFooterItem1
            ' 
            goToPreviousHeaderFooterItem1.Id = 127
            goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            ' 
            ' toggleLinkToPreviousItem1
            ' 
            toggleLinkToPreviousItem1.Id = 128
            toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            ' 
            ' headerFooterToolsDesignOptionsRibbonPageGroup1
            ' 
            headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(toggleDifferentFirstPageItem1)
            headerFooterToolsDesignOptionsRibbonPageGroup1.ItemLinks.Add(toggleDifferentOddAndEvenPagesItem1)
            headerFooterToolsDesignOptionsRibbonPageGroup1.Name = "headerFooterToolsDesignOptionsRibbonPageGroup1"
            ' 
            ' toggleDifferentFirstPageItem1
            ' 
            toggleDifferentFirstPageItem1.Id = 129
            toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            ' 
            ' toggleDifferentOddAndEvenPagesItem1
            ' 
            toggleDifferentOddAndEvenPagesItem1.Id = 130
            toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            ' 
            ' headerFooterToolsDesignCloseRibbonPageGroup1
            ' 
            headerFooterToolsDesignCloseRibbonPageGroup1.ItemLinks.Add(closePageHeaderFooterItem1)
            headerFooterToolsDesignCloseRibbonPageGroup1.Name = "headerFooterToolsDesignCloseRibbonPageGroup1"
            ' 
            ' closePageHeaderFooterItem1
            ' 
            closePageHeaderFooterItem1.Id = 131
            closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            ' 
            ' tableStyleOptionsRibbonPageGroup1
            ' 
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleFirstRowItem1)
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleLastRowItem1)
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleBandedRowsItem1)
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleFirstColumnItem1)
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleLastColumnItem1)
            tableStyleOptionsRibbonPageGroup1.ItemLinks.Add(toggleBandedColumnsItem1)
            tableStyleOptionsRibbonPageGroup1.Name = "tableStyleOptionsRibbonPageGroup1"
            ' 
            ' tableDesignRibbonPage1
            ' 
            tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {tableStyleOptionsRibbonPageGroup1, tableStylesRibbonPageGroup1, tableCellStylesRibbonPageGroup1, tableDrawBordersRibbonPageGroup1})
            tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
            ' 
            ' tableToolsRibbonPageCategory1
            ' 
            tableToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(252))))), (CInt(Fix((CByte(233))))), (CInt(Fix((CByte(20))))))
            tableToolsRibbonPageCategory1.Control = snapControl
            tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
            tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {tableDesignRibbonPage1, tableLayoutRibbonPage1})
            ' 
            ' toggleFirstRowItem1
            ' 
            toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleFirstRowItem1.Id = 132
            toggleFirstRowItem1.Name = "toggleFirstRowItem1"
            ' 
            ' toggleLastRowItem1
            ' 
            toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleLastRowItem1.Id = 133
            toggleLastRowItem1.Name = "toggleLastRowItem1"
            ' 
            ' toggleBandedRowsItem1
            ' 
            toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleBandedRowsItem1.Id = 134
            toggleBandedRowsItem1.Name = "toggleBandedRowsItem1"
            ' 
            ' toggleFirstColumnItem1
            ' 
            toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleFirstColumnItem1.Id = 135
            toggleFirstColumnItem1.Name = "toggleFirstColumnItem1"
            ' 
            ' toggleLastColumnItem1
            ' 
            toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleLastColumnItem1.Id = 136
            toggleLastColumnItem1.Name = "toggleLastColumnItem1"
            ' 
            ' toggleBandedColumnsItem1
            ' 
            toggleBandedColumnsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleBandedColumnsItem1.Id = 137
            toggleBandedColumnsItem1.Name = "toggleBandedColumnsItem1"
            ' 
            ' tableStylesRibbonPageGroup1
            ' 
            tableStylesRibbonPageGroup1.ItemLinks.Add(galleryChangeTableStyleItem1)
            tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
            ' 
            ' galleryChangeTableStyleItem1
            ' 
            galleryChangeTableStyleItem1.CurrentItem = Nothing
            galleryChangeTableStyleItem1.CurrentItemStyle = Nothing
            galleryChangeTableStyleItem1.CurrentStyle = Nothing
            galleryChangeTableStyleItem1.DeleteItemLink = Nothing
            ' 
            ' 
            ' 
            galleryChangeTableStyleItem1.Gallery.ColumnCount = 3
            galleryChangeTableStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup2})
            galleryChangeTableStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            galleryChangeTableStyleItem1.Id = 138
            galleryChangeTableStyleItem1.ModifyItemLink = Nothing
            galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1"
            galleryChangeTableStyleItem1.NewItemLink = Nothing
            galleryChangeTableStyleItem1.PopupGallery = Nothing
            ' 
            ' tableCellStylesRibbonPageGroup1
            ' 
            tableCellStylesRibbonPageGroup1.ItemLinks.Add(galleryChangeTableCellStyleItem1)
            tableCellStylesRibbonPageGroup1.Name = "tableCellStylesRibbonPageGroup1"
            ' 
            ' galleryChangeTableCellStyleItem1
            ' 
            galleryChangeTableCellStyleItem1.CurrentCellStyle = Nothing
            galleryChangeTableCellStyleItem1.CurrentItem = Nothing
            galleryChangeTableCellStyleItem1.CurrentItemCellStyle = Nothing
            galleryChangeTableCellStyleItem1.DeleteItemLink = Nothing
            ' 
            ' 
            ' 
            galleryChangeTableCellStyleItem1.Gallery.ColumnCount = 3
            galleryChangeTableCellStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup3})
            galleryChangeTableCellStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            galleryChangeTableCellStyleItem1.Id = 139
            galleryChangeTableCellStyleItem1.ModifyItemLink = Nothing
            galleryChangeTableCellStyleItem1.Name = "galleryChangeTableCellStyleItem1"
            galleryChangeTableCellStyleItem1.NewItemLink = Nothing
            galleryChangeTableCellStyleItem1.PopupGallery = Nothing
            ' 
            ' tableDrawBordersRibbonPageGroup1
            ' 
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBorderLineStyleItem1)
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBorderLineWeightItem1)
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBorderColorItem1)
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableBordersItem1)
            tableDrawBordersRibbonPageGroup1.ItemLinks.Add(changeTableCellsShadingItem1)
            tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
            ' 
            ' changeTableBorderLineStyleItem1
            ' 
            changeTableBorderLineStyleItem1.Edit = repositoryItemBorderLineStyle1
            borderInfo1.Color = System.Drawing.Color.Black
            borderInfo1.Frame = False
            borderInfo1.Offset = 0
            borderInfo1.Shadow = False
            borderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single
            borderInfo1.Width = 10
            changeTableBorderLineStyleItem1.EditValue = borderInfo1
            changeTableBorderLineStyleItem1.Id = 140
            changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            ' 
            ' changeTableBorderLineWeightItem1
            ' 
            changeTableBorderLineWeightItem1.Edit = repositoryItemBorderLineWeight1
            changeTableBorderLineWeightItem1.EditValue = 20
            changeTableBorderLineWeightItem1.Id = 141
            changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            ' 
            ' changeTableBorderColorItem1
            ' 
            changeTableBorderColorItem1.Id = 142
            changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            ' 
            ' changeTableBordersItem1
            ' 
            changeTableBordersItem1.Id = 143
            changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(resetTableCellsAllBordersItem1, True), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideHorizontalBorderItem1, True), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideVerticalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleShowTableGridLinesItem1, True)})
            changeTableBordersItem1.Name = "changeTableBordersItem1"
            ' 
            ' toggleTableCellsBottomBorderItem1
            ' 
            toggleTableCellsBottomBorderItem1.Id = 144
            toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            ' 
            ' toggleTableCellsTopBorderItem1
            ' 
            toggleTableCellsTopBorderItem1.Id = 145
            toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            ' 
            ' toggleTableCellsLeftBorderItem1
            ' 
            toggleTableCellsLeftBorderItem1.Id = 146
            toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            ' 
            ' toggleTableCellsRightBorderItem1
            ' 
            toggleTableCellsRightBorderItem1.Id = 147
            toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            ' 
            ' resetTableCellsAllBordersItem1
            ' 
            resetTableCellsAllBordersItem1.Id = 148
            resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsAllBordersItem1
            ' 
            toggleTableCellsAllBordersItem1.Id = 149
            toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsOutsideBorderItem1
            ' 
            toggleTableCellsOutsideBorderItem1.Id = 150
            toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            ' 
            ' toggleTableCellsInsideBorderItem1
            ' 
            toggleTableCellsInsideBorderItem1.Id = 151
            toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            ' 
            ' toggleTableCellsInsideHorizontalBorderItem1
            ' 
            toggleTableCellsInsideHorizontalBorderItem1.Id = 152
            toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            ' 
            ' toggleTableCellsInsideVerticalBorderItem1
            ' 
            toggleTableCellsInsideVerticalBorderItem1.Id = 153
            toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            ' 
            ' toggleShowTableGridLinesItem1
            ' 
            toggleShowTableGridLinesItem1.Id = 154
            toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            ' 
            ' changeTableCellsShadingItem1
            ' 
            changeTableCellsShadingItem1.Id = 155
            changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            repositoryItemBorderLineStyle1.AutoHeight = False
            repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemBorderLineStyle1.Control = snapControl
            repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            repositoryItemBorderLineWeight1.AutoHeight = False
            repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemBorderLineWeight1.Control = snapControl
            repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' tableTableRibbonPageGroup1
            ' 
            tableTableRibbonPageGroup1.ItemLinks.Add(selectTableElementsItem1)
            tableTableRibbonPageGroup1.ItemLinks.Add(toggleShowTableGridLinesItem1)
            tableTableRibbonPageGroup1.ItemLinks.Add(showTablePropertiesFormItem1)
            tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
            ' 
            ' tableLayoutRibbonPage1
            ' 
            tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {tableTableRibbonPageGroup1, tableRowsAndColumnsRibbonPageGroup1, tableMergeRibbonPageGroup1, tableCellSizeRibbonPageGroup1, tableAlignmentRibbonPageGroup1})
            tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
            ' 
            ' selectTableElementsItem1
            ' 
            selectTableElementsItem1.Id = 156
            selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(selectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(selectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(selectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(selectTableItem1)})
            selectTableElementsItem1.Name = "selectTableElementsItem1"
            ' 
            ' selectTableCellItem1
            ' 
            selectTableCellItem1.Id = 157
            selectTableCellItem1.Name = "selectTableCellItem1"
            ' 
            ' selectTableColumnItem1
            ' 
            selectTableColumnItem1.Id = 158
            selectTableColumnItem1.Name = "selectTableColumnItem1"
            ' 
            ' selectTableRowItem1
            ' 
            selectTableRowItem1.Id = 159
            selectTableRowItem1.Name = "selectTableRowItem1"
            ' 
            ' selectTableItem1
            ' 
            selectTableItem1.Id = 160
            selectTableItem1.Name = "selectTableItem1"
            ' 
            ' showTablePropertiesFormItem1
            ' 
            showTablePropertiesFormItem1.Id = 161
            showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            ' 
            ' tableRowsAndColumnsRibbonPageGroup1
            ' 
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(deleteTableElementsItem1)
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableRowAboveItem1)
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableRowBelowItem1)
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableColumnToLeftItem1)
            tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(insertTableColumnToRightItem1)
            tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
            ' 
            ' deleteTableElementsItem1
            ' 
            deleteTableElementsItem1.Id = 162
            deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(showDeleteTableCellsFormItem1), New DevExpress.XtraBars.LinkPersistInfo(deleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(deleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(deleteTableItem1)})
            deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            ' 
            ' showDeleteTableCellsFormItem1
            ' 
            showDeleteTableCellsFormItem1.Id = 163
            showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            ' 
            ' deleteTableColumnsItem1
            ' 
            deleteTableColumnsItem1.Id = 164
            deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            ' 
            ' deleteTableRowsItem1
            ' 
            deleteTableRowsItem1.Id = 165
            deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            ' 
            ' deleteTableItem1
            ' 
            deleteTableItem1.Id = 166
            deleteTableItem1.Name = "deleteTableItem1"
            ' 
            ' insertTableRowAboveItem1
            ' 
            insertTableRowAboveItem1.Id = 167
            insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            ' 
            ' insertTableRowBelowItem1
            ' 
            insertTableRowBelowItem1.Id = 168
            insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            ' 
            ' insertTableColumnToLeftItem1
            ' 
            insertTableColumnToLeftItem1.Id = 169
            insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            ' 
            ' insertTableColumnToRightItem1
            ' 
            insertTableColumnToRightItem1.Id = 170
            insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            ' 
            ' tableMergeRibbonPageGroup1
            ' 
            tableMergeRibbonPageGroup1.ItemLinks.Add(mergeTableCellsItem1)
            tableMergeRibbonPageGroup1.ItemLinks.Add(showSplitTableCellsForm1)
            tableMergeRibbonPageGroup1.ItemLinks.Add(splitTableItem1)
            tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
            ' 
            ' mergeTableCellsItem1
            ' 
            mergeTableCellsItem1.Id = 171
            mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            ' 
            ' showSplitTableCellsForm1
            ' 
            showSplitTableCellsForm1.Id = 172
            showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            ' 
            ' splitTableItem1
            ' 
            splitTableItem1.Id = 173
            splitTableItem1.Name = "splitTableItem1"
            ' 
            ' tableCellSizeRibbonPageGroup1
            ' 
            tableCellSizeRibbonPageGroup1.AllowTextClipping = False
            tableCellSizeRibbonPageGroup1.ItemLinks.Add(toggleTableAutoFitItem1)
            tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
            ' 
            ' toggleTableAutoFitItem1
            ' 
            toggleTableAutoFitItem1.Id = 174
            toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(toggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableFixedColumnWidthItem1)})
            toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            ' 
            ' toggleTableAutoFitContentsItem1
            ' 
            toggleTableAutoFitContentsItem1.Id = 175
            toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            ' 
            ' toggleTableAutoFitWindowItem1
            ' 
            toggleTableAutoFitWindowItem1.Id = 176
            toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            ' 
            ' toggleTableFixedColumnWidthItem1
            ' 
            toggleTableFixedColumnWidthItem1.Id = 177
            toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            ' 
            ' tableAlignmentRibbonPageGroup1
            ' 
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsTopLeftAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsMiddleLeftAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsBottomLeftAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsTopCenterAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsMiddleCenterAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsBottomCenterAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsTopRightAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsMiddleRightAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(toggleTableCellsBottomRightAlignmentItem1)
            tableAlignmentRibbonPageGroup1.ItemLinks.Add(showTableOptionsFormItem1)
            tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
            ' 
            ' toggleTableCellsTopLeftAlignmentItem1
            ' 
            toggleTableCellsTopLeftAlignmentItem1.Id = 178
            toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleLeftAlignmentItem1
            ' 
            toggleTableCellsMiddleLeftAlignmentItem1.Id = 179
            toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            ' 
            ' toggleTableCellsBottomLeftAlignmentItem1
            ' 
            toggleTableCellsBottomLeftAlignmentItem1.Id = 180
            toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            ' 
            ' toggleTableCellsTopCenterAlignmentItem1
            ' 
            toggleTableCellsTopCenterAlignmentItem1.Id = 181
            toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleCenterAlignmentItem1
            ' 
            toggleTableCellsMiddleCenterAlignmentItem1.Id = 182
            toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            ' 
            ' toggleTableCellsBottomCenterAlignmentItem1
            ' 
            toggleTableCellsBottomCenterAlignmentItem1.Id = 183
            toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            ' 
            ' toggleTableCellsTopRightAlignmentItem1
            ' 
            toggleTableCellsTopRightAlignmentItem1.Id = 184
            toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleRightAlignmentItem1
            ' 
            toggleTableCellsMiddleRightAlignmentItem1.Id = 185
            toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            ' 
            ' toggleTableCellsBottomRightAlignmentItem1
            ' 
            toggleTableCellsBottomRightAlignmentItem1.Id = 186
            toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            ' 
            ' showTableOptionsFormItem1
            ' 
            showTableOptionsFormItem1.Id = 187
            showTableOptionsFormItem1.Name = "showTableOptionsFormItem1"
            ' 
            ' documentProofingRibbonPageGroup1
            ' 
            documentProofingRibbonPageGroup1.ItemLinks.Add(checkSpellingItem1)
            documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
            ' 
            ' reviewRibbonPage1
            ' 
            reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {documentProofingRibbonPageGroup1})
            reviewRibbonPage1.Name = "reviewRibbonPage1"
            ' 
            ' checkSpellingItem1
            ' 
            checkSpellingItem1.Id = 188
            checkSpellingItem1.Name = "checkSpellingItem1"
            ' 
            ' tableOfContentsRibbonPageGroup1
            ' 
            tableOfContentsRibbonPageGroup1.ItemLinks.Add(insertTableOfContentsItem1)
            tableOfContentsRibbonPageGroup1.ItemLinks.Add(updateTableOfContentsItem1)
            tableOfContentsRibbonPageGroup1.ItemLinks.Add(addParagraphsToTableOfContentItem1)
            tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1"
            ' 
            ' referencesRibbonPage1
            ' 
            referencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {tableOfContentsRibbonPageGroup1, captionsRibbonPageGroup1})
            referencesRibbonPage1.Name = "referencesRibbonPage1"
            ' 
            ' insertTableOfContentsItem1
            ' 
            insertTableOfContentsItem1.Id = 189
            insertTableOfContentsItem1.Name = "insertTableOfContentsItem1"
            ' 
            ' updateTableOfContentsItem1
            ' 
            updateTableOfContentsItem1.Id = 190
            updateTableOfContentsItem1.Name = "updateTableOfContentsItem1"
            ' 
            ' addParagraphsToTableOfContentItem1
            ' 
            addParagraphsToTableOfContentItem1.Id = 191
            addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem1), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem2), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem3), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem4), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem5), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem6), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem7), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem8), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem9), New DevExpress.XtraBars.LinkPersistInfo(setParagraphHeadingLevelItem10)})
            addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1"
            ' 
            ' setParagraphHeadingLevelItem1
            ' 
            setParagraphHeadingLevelItem1.Id = 192
            setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1"
            setParagraphHeadingLevelItem1.OutlineLevel = 0
            ' 
            ' setParagraphHeadingLevelItem2
            ' 
            setParagraphHeadingLevelItem2.Id = 193
            setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2"
            setParagraphHeadingLevelItem2.OutlineLevel = 1
            ' 
            ' setParagraphHeadingLevelItem3
            ' 
            setParagraphHeadingLevelItem3.Id = 194
            setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3"
            setParagraphHeadingLevelItem3.OutlineLevel = 2
            ' 
            ' setParagraphHeadingLevelItem4
            ' 
            setParagraphHeadingLevelItem4.Id = 195
            setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4"
            setParagraphHeadingLevelItem4.OutlineLevel = 3
            ' 
            ' setParagraphHeadingLevelItem5
            ' 
            setParagraphHeadingLevelItem5.Id = 196
            setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5"
            setParagraphHeadingLevelItem5.OutlineLevel = 4
            ' 
            ' setParagraphHeadingLevelItem6
            ' 
            setParagraphHeadingLevelItem6.Id = 197
            setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6"
            setParagraphHeadingLevelItem6.OutlineLevel = 5
            ' 
            ' setParagraphHeadingLevelItem7
            ' 
            setParagraphHeadingLevelItem7.Id = 198
            setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7"
            setParagraphHeadingLevelItem7.OutlineLevel = 6
            ' 
            ' setParagraphHeadingLevelItem8
            ' 
            setParagraphHeadingLevelItem8.Id = 199
            setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8"
            setParagraphHeadingLevelItem8.OutlineLevel = 7
            ' 
            ' setParagraphHeadingLevelItem9
            ' 
            setParagraphHeadingLevelItem9.Id = 200
            setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9"
            setParagraphHeadingLevelItem9.OutlineLevel = 8
            ' 
            ' setParagraphHeadingLevelItem10
            ' 
            setParagraphHeadingLevelItem10.Id = 201
            setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10"
            setParagraphHeadingLevelItem10.OutlineLevel = 9
            ' 
            ' captionsRibbonPageGroup1
            ' 
            captionsRibbonPageGroup1.ItemLinks.Add(insertCaptionPlaceholderItem1)
            captionsRibbonPageGroup1.ItemLinks.Add(insertTableOfFiguresPlaceholderItem1)
            captionsRibbonPageGroup1.ItemLinks.Add(updateTableOfFiguresItem1)
            captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1"
            ' 
            ' insertCaptionPlaceholderItem1
            ' 
            insertCaptionPlaceholderItem1.Id = 202
            insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(insertFiguresCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(insertTablesCaptionItems1), New DevExpress.XtraBars.LinkPersistInfo(insertEquationsCaptionItems1)})
            insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1"
            ' 
            ' insertFiguresCaptionItems1
            ' 
            insertFiguresCaptionItems1.Id = 203
            insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1"
            ' 
            ' insertTablesCaptionItems1
            ' 
            insertTablesCaptionItems1.Id = 204
            insertTablesCaptionItems1.Name = "insertTablesCaptionItems1"
            ' 
            ' insertEquationsCaptionItems1
            ' 
            insertEquationsCaptionItems1.Id = 205
            insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1"
            ' 
            ' insertTableOfFiguresPlaceholderItem1
            ' 
            insertTableOfFiguresPlaceholderItem1.Id = 206
            insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(insertTableOfFiguresItems1), New DevExpress.XtraBars.LinkPersistInfo(insertTableOfTablesItems1), New DevExpress.XtraBars.LinkPersistInfo(insertTableOfEquationsItems1)})
            insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1"
            ' 
            ' insertTableOfFiguresItems1
            ' 
            insertTableOfFiguresItems1.Id = 207
            insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1"
            ' 
            ' insertTableOfTablesItems1
            ' 
            insertTableOfTablesItems1.Id = 208
            insertTableOfTablesItems1.Name = "insertTableOfTablesItems1"
            ' 
            ' insertTableOfEquationsItems1
            ' 
            insertTableOfEquationsItems1.Id = 209
            insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1"
            ' 
            ' updateTableOfFiguresItem1
            ' 
            updateTableOfFiguresItem1.Id = 210
            updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1"
            ' 
            ' floatingPictureToolsShapeStylesPageGroup1
            ' 
            floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(changeFloatingObjectFillColorItem1)
            floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(changeFloatingObjectOutlineColorItem1)
            floatingPictureToolsShapeStylesPageGroup1.ItemLinks.Add(changeFloatingObjectOutlineWeightItem1)
            floatingPictureToolsShapeStylesPageGroup1.Name = "floatingPictureToolsShapeStylesPageGroup1"
            ' 
            ' floatingPictureToolsFormatPage1
            ' 
            floatingPictureToolsFormatPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {floatingPictureToolsShapeStylesPageGroup1, floatingPictureToolsArrangePageGroup1})
            floatingPictureToolsFormatPage1.Name = "floatingPictureToolsFormatPage1"
            ' 
            ' floatingPictureToolsRibbonPageCategory1
            ' 
            floatingPictureToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(201))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(119))))))
            floatingPictureToolsRibbonPageCategory1.Control = snapControl
            floatingPictureToolsRibbonPageCategory1.Name = "floatingPictureToolsRibbonPageCategory1"
            floatingPictureToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {floatingPictureToolsFormatPage1})
            ' 
            ' changeFloatingObjectFillColorItem1
            ' 
            changeFloatingObjectFillColorItem1.Id = 211
            changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
            ' 
            ' changeFloatingObjectOutlineColorItem1
            ' 
            changeFloatingObjectOutlineColorItem1.Id = 212
            changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
            ' 
            ' changeFloatingObjectOutlineWeightItem1
            ' 
            changeFloatingObjectOutlineWeightItem1.Edit = repositoryItemFloatingObjectOutlineWeight1
            changeFloatingObjectOutlineWeightItem1.EditValue = 20
            changeFloatingObjectOutlineWeightItem1.Id = 213
            changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1"
            ' 
            ' repositoryItemFloatingObjectOutlineWeight1
            ' 
            repositoryItemFloatingObjectOutlineWeight1.AutoHeight = False
            repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemFloatingObjectOutlineWeight1.Control = snapControl
            repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
            ' 
            ' floatingPictureToolsArrangePageGroup1
            ' 
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(changeFloatingObjectTextWrapTypeItem1)
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(changeFloatingObjectAlignmentItem1)
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(floatingObjectBringForwardSubItem1)
            floatingPictureToolsArrangePageGroup1.ItemLinks.Add(floatingObjectSendBackwardSubItem1)
            floatingPictureToolsArrangePageGroup1.Name = "floatingPictureToolsArrangePageGroup1"
            ' 
            ' changeFloatingObjectTextWrapTypeItem1
            ' 
            changeFloatingObjectTextWrapTypeItem1.Id = 214
            changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectSquareTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTightTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectThroughTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopAndBottomTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBehindTextWrapTypeItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectInFrontOfTextWrapTypeItem1)})
            changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
            ' 
            ' setFloatingObjectSquareTextWrapTypeItem1
            ' 
            setFloatingObjectSquareTextWrapTypeItem1.Id = 215
            setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTightTextWrapTypeItem1
            ' 
            setFloatingObjectTightTextWrapTypeItem1.Id = 216
            setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
            ' 
            ' setFloatingObjectThroughTextWrapTypeItem1
            ' 
            setFloatingObjectThroughTextWrapTypeItem1.Id = 217
            setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTopAndBottomTextWrapTypeItem1
            ' 
            setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 218
            setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
            ' 
            ' setFloatingObjectBehindTextWrapTypeItem1
            ' 
            setFloatingObjectBehindTextWrapTypeItem1.Id = 219
            setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
            ' 
            ' setFloatingObjectInFrontOfTextWrapTypeItem1
            ' 
            setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 220
            setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
            ' 
            ' changeFloatingObjectAlignmentItem1
            ' 
            changeFloatingObjectAlignmentItem1.Id = 221
            changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectTopRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectMiddleLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectMiddleCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectMiddleRightAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBottomLeftAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBottomCenterAlignmentItem1), New DevExpress.XtraBars.LinkPersistInfo(setFloatingObjectBottomRightAlignmentItem1)})
            changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
            ' 
            ' setFloatingObjectTopLeftAlignmentItem1
            ' 
            setFloatingObjectTopLeftAlignmentItem1.Id = 222
            setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
            ' 
            ' setFloatingObjectTopCenterAlignmentItem1
            ' 
            setFloatingObjectTopCenterAlignmentItem1.Id = 223
            setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
            ' 
            ' setFloatingObjectTopRightAlignmentItem1
            ' 
            setFloatingObjectTopRightAlignmentItem1.Id = 224
            setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleLeftAlignmentItem1
            ' 
            setFloatingObjectMiddleLeftAlignmentItem1.Id = 225
            setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleCenterAlignmentItem1
            ' 
            setFloatingObjectMiddleCenterAlignmentItem1.Id = 226
            setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleRightAlignmentItem1
            ' 
            setFloatingObjectMiddleRightAlignmentItem1.Id = 227
            setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
            ' 
            ' setFloatingObjectBottomLeftAlignmentItem1
            ' 
            setFloatingObjectBottomLeftAlignmentItem1.Id = 228
            setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
            ' 
            ' setFloatingObjectBottomCenterAlignmentItem1
            ' 
            setFloatingObjectBottomCenterAlignmentItem1.Id = 229
            setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
            ' 
            ' setFloatingObjectBottomRightAlignmentItem1
            ' 
            setFloatingObjectBottomRightAlignmentItem1.Id = 230
            setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
            ' 
            ' floatingObjectBringForwardSubItem1
            ' 
            floatingObjectBringForwardSubItem1.Id = 231
            floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(floatingObjectBringForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(floatingObjectBringToFrontItem1), New DevExpress.XtraBars.LinkPersistInfo(floatingObjectBringInFrontOfTextItem1)})
            floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
            ' 
            ' floatingObjectBringForwardItem1
            ' 
            floatingObjectBringForwardItem1.Id = 232
            floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
            ' 
            ' floatingObjectBringToFrontItem1
            ' 
            floatingObjectBringToFrontItem1.Id = 233
            floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
            ' 
            ' floatingObjectBringInFrontOfTextItem1
            ' 
            floatingObjectBringInFrontOfTextItem1.Id = 234
            floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
            ' 
            ' floatingObjectSendBackwardSubItem1
            ' 
            floatingObjectSendBackwardSubItem1.Id = 235
            floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(floatingObjectSendBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(floatingObjectSendToBackItem1), New DevExpress.XtraBars.LinkPersistInfo(floatingObjectSendBehindTextItem1)})
            floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
            ' 
            ' floatingObjectSendBackwardItem1
            ' 
            floatingObjectSendBackwardItem1.Id = 236
            floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
            ' 
            ' floatingObjectSendToBackItem1
            ' 
            floatingObjectSendToBackItem1.Id = 237
            floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
            ' 
            ' floatingObjectSendBehindTextItem1
            ' 
            floatingObjectSendBehindTextItem1.Id = 238
            floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
            ' 
            ' themesRibbonPageGroup1
            ' 
            themesRibbonPageGroup1.ItemLinks.Add(themesGalleryBarItem1)
            themesRibbonPageGroup1.Name = "themesRibbonPageGroup1"
            ' 
            ' appearanceRibbonPage1
            ' 
            appearanceRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {themesRibbonPageGroup1})
            appearanceRibbonPage1.Name = "appearanceRibbonPage1"
            ' 
            ' dataToolsRibbonPageCategory1
            ' 
            dataToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(31))))), (CInt(Fix((CByte(166))))), (CInt(Fix((CByte(207))))))
            dataToolsRibbonPageCategory1.Control = snapControl
            dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1"
            dataToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {appearanceRibbonPage1, snMergeFieldToolsRibbonPage1, groupToolsRibbonPage1, listToolsRibbonPage1})
            ' 
            ' themesGalleryBarItem1
            ' 
            ' 
            ' 
            ' 
            themesGalleryBarItem1.Gallery.ColumnCount = 7
            themesGalleryBarItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            themesGalleryBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
            themesGalleryBarItem1.Gallery.RowCount = 1
            themesGalleryBarItem1.Id = 239
            themesGalleryBarItem1.Name = "themesGalleryBarItem1"
            ' 
            ' dataShapingRibbonPageGroup1
            ' 
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem2)
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem3)
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarCheckItem4)
            dataShapingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem1)
            dataShapingRibbonPageGroup1.ItemLinks.Add(filterPopupButtonItem1)
            dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1"
            ' 
            ' snMergeFieldToolsRibbonPage1
            ' 
            snMergeFieldToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {dataShapingRibbonPageGroup1, snMergeFieldPropertiesRibbonPageGroup1})
            snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1"
            ' 
            ' commandBarCheckItem2
            ' 
            commandBarCheckItem2.Id = 240
            commandBarCheckItem2.Name = "commandBarCheckItem2"
            commandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField
            ' 
            ' commandBarCheckItem3
            ' 
            commandBarCheckItem3.Id = 241
            commandBarCheckItem3.Name = "commandBarCheckItem3"
            commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldAscending
            ' 
            ' commandBarCheckItem4
            ' 
            commandBarCheckItem4.Id = 242
            commandBarCheckItem4.Name = "commandBarCheckItem4"
            commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldDescending
            ' 
            ' commandBarSubItem1
            ' 
            commandBarSubItem1.Id = 243
            commandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem5), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem6), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem7), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem8), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem9)})
            commandBarSubItem1.Name = "commandBarSubItem1"
            commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField
            ' 
            ' commandBarCheckItem5
            ' 
            commandBarCheckItem5.Id = 244
            commandBarCheckItem5.Name = "commandBarCheckItem5"
            commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount
            ' 
            ' commandBarCheckItem6
            ' 
            commandBarCheckItem6.Id = 245
            commandBarCheckItem6.Name = "commandBarCheckItem6"
            commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum
            ' 
            ' commandBarCheckItem7
            ' 
            commandBarCheckItem7.Id = 246
            commandBarCheckItem7.Name = "commandBarCheckItem7"
            commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage
            ' 
            ' commandBarCheckItem8
            ' 
            commandBarCheckItem8.Id = 247
            commandBarCheckItem8.Name = "commandBarCheckItem8"
            commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax
            ' 
            ' commandBarCheckItem9
            ' 
            commandBarCheckItem9.Id = 248
            commandBarCheckItem9.Name = "commandBarCheckItem9"
            commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin
            ' 
            ' filterPopupButtonItem1
            ' 
            filterPopupButtonItem1.ActAsDropDown = True
            filterPopupButtonItem1.Id = 249
            filterPopupButtonItem1.Name = "filterPopupButtonItem1"
            ' 
            ' snMergeFieldPropertiesRibbonPageGroup1
            ' 
            snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(propertiesBarButtonItem1)
            snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1"
            ' 
            ' propertiesBarButtonItem1
            ' 
            propertiesBarButtonItem1.ActAsDropDown = True
            propertiesBarButtonItem1.Id = 250
            propertiesBarButtonItem1.Name = "propertiesBarButtonItem1"
            propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' groupingRibbonPageGroup1
            ' 
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem2)
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem3)
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarItem8)
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarItem9)
            groupingRibbonPageGroup1.ItemLinks.Add(commandBarSubItem4)
            groupingRibbonPageGroup1.Name = "groupingRibbonPageGroup1"
            ' 
            ' groupToolsRibbonPage1
            ' 
            groupToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {groupingRibbonPageGroup1})
            groupToolsRibbonPage1.Name = "groupToolsRibbonPage1"
            ' 
            ' commandBarSubItem2
            ' 
            commandBarSubItem2.Id = 251
            commandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem10), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem11)})
            commandBarSubItem2.Name = "commandBarSubItem2"
            commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupHeader
            ' 
            ' commandBarCheckItem10
            ' 
            commandBarCheckItem10.Id = 252
            commandBarCheckItem10.Name = "commandBarCheckItem10"
            commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupHeader
            ' 
            ' commandBarCheckItem11
            ' 
            commandBarCheckItem11.Id = 253
            commandBarCheckItem11.Name = "commandBarCheckItem11"
            commandBarCheckItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupHeader
            ' 
            ' commandBarSubItem3
            ' 
            commandBarSubItem3.Id = 254
            commandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem12), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem13)})
            commandBarSubItem3.Name = "commandBarSubItem3"
            commandBarSubItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFooter
            ' 
            ' commandBarCheckItem12
            ' 
            commandBarCheckItem12.Id = 255
            commandBarCheckItem12.Name = "commandBarCheckItem12"
            commandBarCheckItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupFooter
            ' 
            ' commandBarCheckItem13
            ' 
            commandBarCheckItem13.Id = 256
            commandBarCheckItem13.Name = "commandBarCheckItem13"
            commandBarCheckItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupFooter
            ' 
            ' commandBarItem8
            ' 
            commandBarItem8.Id = 257
            commandBarItem8.Name = "commandBarItem8"
            commandBarItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFieldsCollection
            ' 
            ' commandBarItem9
            ' 
            commandBarItem9.Id = 258
            commandBarItem9.Name = "commandBarItem9"
            commandBarItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ShowReportStructureEditorForm
            ' 
            ' commandBarSubItem4
            ' 
            commandBarSubItem4.Id = 259
            commandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem14), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem15), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem16), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem17), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem18), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem19), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem20)})
            commandBarSubItem4.Name = "commandBarSubItem4"
            commandBarSubItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupSeparator
            ' 
            ' commandBarCheckItem14
            ' 
            commandBarCheckItem14.Id = 260
            commandBarCheckItem14.Name = "commandBarCheckItem14"
            commandBarCheckItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakGroupSeparator
            ' 
            ' commandBarCheckItem15
            ' 
            commandBarCheckItem15.Id = 261
            commandBarCheckItem15.Name = "commandBarCheckItem15"
            commandBarCheckItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageGroupSeparator
            ' 
            ' commandBarCheckItem16
            ' 
            commandBarCheckItem16.Id = 262
            commandBarCheckItem16.Name = "commandBarCheckItem16"
            commandBarCheckItem16.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageGroupSeparator
            ' 
            ' commandBarCheckItem17
            ' 
            commandBarCheckItem17.Id = 263
            commandBarCheckItem17.Name = "commandBarCheckItem17"
            commandBarCheckItem17.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageGroupSeparator
            ' 
            ' commandBarCheckItem18
            ' 
            commandBarCheckItem18.Id = 264
            commandBarCheckItem18.Name = "commandBarCheckItem18"
            commandBarCheckItem18.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphGroupSeparator
            ' 
            ' commandBarCheckItem19
            ' 
            commandBarCheckItem19.Id = 265
            commandBarCheckItem19.Name = "commandBarCheckItem19"
            commandBarCheckItem19.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowGroupSeparator
            ' 
            ' commandBarCheckItem20
            ' 
            commandBarCheckItem20.Id = 266
            commandBarCheckItem20.Name = "commandBarCheckItem20"
            commandBarCheckItem20.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneGroupSeparator
            ' 
            ' listHeaderAndFooterRibbonPageGroup1
            ' 
            listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(commandBarSubItem5)
            listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(commandBarSubItem6)
            listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(commandBarSubItem7)
            listHeaderAndFooterRibbonPageGroup1.Name = "listHeaderAndFooterRibbonPageGroup1"
            ' 
            ' listToolsRibbonPage1
            ' 
            listToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {listHeaderAndFooterRibbonPageGroup1, listCommandsRibbonPageGroup1, listEditorRowLimitRibbonPageGroup1})
            listToolsRibbonPage1.Name = "listToolsRibbonPage1"
            ' 
            ' commandBarSubItem5
            ' 
            commandBarSubItem5.Id = 268
            commandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem21), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem22)})
            commandBarSubItem5.Name = "commandBarSubItem5"
            commandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            commandBarSubItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListHeader
            ' 
            ' commandBarCheckItem21
            ' 
            commandBarCheckItem21.Id = 269
            commandBarCheckItem21.Name = "commandBarCheckItem21"
            commandBarCheckItem21.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListHeader
            ' 
            ' commandBarCheckItem22
            ' 
            commandBarCheckItem22.Id = 270
            commandBarCheckItem22.Name = "commandBarCheckItem22"
            commandBarCheckItem22.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListHeader
            ' 
            ' commandBarSubItem6
            ' 
            commandBarSubItem6.Id = 271
            commandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem23), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem24)})
            commandBarSubItem6.Name = "commandBarSubItem6"
            commandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            commandBarSubItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListFooter
            ' 
            ' commandBarCheckItem23
            ' 
            commandBarCheckItem23.Id = 272
            commandBarCheckItem23.Name = "commandBarCheckItem23"
            commandBarCheckItem23.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListFooter
            ' 
            ' commandBarCheckItem24
            ' 
            commandBarCheckItem24.Id = 273
            commandBarCheckItem24.Name = "commandBarCheckItem24"
            commandBarCheckItem24.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListFooter
            ' 
            ' commandBarSubItem7
            ' 
            commandBarSubItem7.Id = 274
            commandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem25), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem26), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem27), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem28), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem29), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem30), New DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem31)})
            commandBarSubItem7.Name = "commandBarSubItem7"
            commandBarSubItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertDataRowSeparator
            ' 
            ' commandBarCheckItem25
            ' 
            commandBarCheckItem25.Id = 275
            commandBarCheckItem25.Name = "commandBarCheckItem25"
            commandBarCheckItem25.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakDataRowSeparator
            ' 
            ' commandBarCheckItem26
            ' 
            commandBarCheckItem26.Id = 276
            commandBarCheckItem26.Name = "commandBarCheckItem26"
            commandBarCheckItem26.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageDataRowSeparator
            ' 
            ' commandBarCheckItem27
            ' 
            commandBarCheckItem27.Id = 277
            commandBarCheckItem27.Name = "commandBarCheckItem27"
            commandBarCheckItem27.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageDataRowSeparator
            ' 
            ' commandBarCheckItem28
            ' 
            commandBarCheckItem28.Id = 278
            commandBarCheckItem28.Name = "commandBarCheckItem28"
            commandBarCheckItem28.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageDataRowSeparator
            ' 
            ' commandBarCheckItem29
            ' 
            commandBarCheckItem29.Id = 279
            commandBarCheckItem29.Name = "commandBarCheckItem29"
            commandBarCheckItem29.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphDataRowSeparator
            ' 
            ' commandBarCheckItem30
            ' 
            commandBarCheckItem30.Id = 280
            commandBarCheckItem30.Name = "commandBarCheckItem30"
            commandBarCheckItem30.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowDataRowSeparator
            ' 
            ' commandBarCheckItem31
            ' 
            commandBarCheckItem31.Id = 281
            commandBarCheckItem31.Name = "commandBarCheckItem31"
            commandBarCheckItem31.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneDataRowSeparator
            ' 
            ' listCommandsRibbonPageGroup1
            ' 
            listCommandsRibbonPageGroup1.ItemLinks.Add(commandBarItem10)
            listCommandsRibbonPageGroup1.ItemLinks.Add(commandBarItem11)
            listCommandsRibbonPageGroup1.ItemLinks.Add(commandBarItem12)
            listCommandsRibbonPageGroup1.Name = "listCommandsRibbonPageGroup1"
            ' 
            ' commandBarItem10
            ' 
            commandBarItem10.Id = 282
            commandBarItem10.Name = "commandBarItem10"
            commandBarItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FilterList
            ' 
            ' commandBarItem11
            ' 
            commandBarItem11.Id = 283
            commandBarItem11.Name = "commandBarItem11"
            commandBarItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ConvertToParagraphs
            ' 
            ' commandBarItem12
            ' 
            commandBarItem12.Id = 284
            commandBarItem12.Name = "commandBarItem12"
            commandBarItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.DeleteList
            ' 
            ' listEditorRowLimitRibbonPageGroup1
            ' 
            listEditorRowLimitRibbonPageGroup1.ItemLinks.Add(barButtonGroup8)
            listEditorRowLimitRibbonPageGroup1.Name = "listEditorRowLimitRibbonPageGroup1"
            ' 
            ' changeEditorRowLimitItem1
            ' 
            changeEditorRowLimitItem1.Edit = repositoryItemEditorRowLimitEdit1
            changeEditorRowLimitItem1.Id = 285
            changeEditorRowLimitItem1.Name = "changeEditorRowLimitItem1"
            changeEditorRowLimitItem1.Width = 90
            ' 
            ' barButtonGroup8
            ' 
            barButtonGroup8.Id = 267
            barButtonGroup8.ItemLinks.Add(changeEditorRowLimitItem1)
            barButtonGroup8.Name = "barButtonGroup8"
            barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' repositoryItemEditorRowLimitEdit1
            ' 
            repositoryItemEditorRowLimitEdit1.AutoHeight = False
            repositoryItemEditorRowLimitEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemEditorRowLimitEdit1.Control = snapControl
            repositoryItemEditorRowLimitEdit1.Name = "repositoryItemEditorRowLimitEdit1"
            ' 
            ' chartTypeRibbonPageGroup1
            ' 
            chartTypeRibbonPageGroup1.ItemLinks.Add(createBarBaseItem1)
            chartTypeRibbonPageGroup1.ItemLinks.Add(createLineBaseItem1)
            chartTypeRibbonPageGroup1.ItemLinks.Add(createPieBaseItem1)
            chartTypeRibbonPageGroup1.ItemLinks.Add(createRotatedBarBaseItem1)
            chartTypeRibbonPageGroup1.ItemLinks.Add(createAreaBaseItem1)
            chartTypeRibbonPageGroup1.ItemLinks.Add(createOtherSeriesTypesBaseItem1)
            chartTypeRibbonPageGroup1.Name = "chartTypeRibbonPageGroup1"
            ' 
            ' createChartRibbonPage1
            ' 
            createChartRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {chartTypeRibbonPageGroup1, chartAppearanceRibbonPageGroup1, chartWizardRibbonPageGroup1})
            createChartRibbonPage1.Name = "createChartRibbonPage1"
            ' 
            ' chartRibbonPageCategory1
            ' 
            chartRibbonPageCategory1.Control = Nothing
            chartRibbonPageCategory1.Name = "chartRibbonPageCategory1"
            chartRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {createChartRibbonPage1})
            ' 
            ' createBarBaseItem1
            ' 
            createBarBaseItem1.DropDownControl = commandBarGalleryDropDown1
            createBarBaseItem1.Id = 286
            createBarBaseItem1.Name = "createBarBaseItem1"
            ' 
            ' commandBarGalleryDropDown1
            ' 
            ' 
            ' 
            ' 
            chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createBarChartItem1, createFullStackedBarChartItem1, createSideBySideFullStackedBarChartItem1, createSideBySideStackedBarChartItem1, createStackedBarChartItem1})
            chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createBar3DChartItem1, createFullStackedBar3DChartItem1, createManhattanBarChartItem1, createSideBySideFullStackedBar3DChartItem1, createSideBySideStackedBar3DChartItem1, createStackedBar3DChartItem1})
            chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createCylinderBar3DChartItem1, createCylinderFullStackedBar3DChartItem1, createCylinderManhattanBarChartItem1, createCylinderSideBySideFullStackedBar3DChartItem1, createCylinderSideBySideStackedBar3DChartItem1, createCylinderStackedBar3DChartItem1})
            chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createConeBar3DChartItem1, createConeFullStackedBar3DChartItem1, createConeManhattanBarChartItem1, createConeSideBySideFullStackedBar3DChartItem1, createConeSideBySideStackedBar3DChartItem1, createConeStackedBar3DChartItem1})
            chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createPyramidBar3DChartItem1, createPyramidFullStackedBar3DChartItem1, createPyramidManhattanBarChartItem1, createPyramidSideBySideFullStackedBar3DChartItem1, createPyramidSideBySideStackedBar3DChartItem1, createPyramidStackedBar3DChartItem1})
            commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {chartControlCommandGalleryItemGroup2DColumn1, chartControlCommandGalleryItemGroup3DColumn1, chartControlCommandGalleryItemGroupCylinderColumn1, chartControlCommandGalleryItemGroupConeColumn1, chartControlCommandGalleryItemGroupPyramidColumn1})
            commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
            commandBarGalleryDropDown1.Ribbon = ribbonControl1
            ' 
            ' createLineBaseItem1
            ' 
            createLineBaseItem1.DropDownControl = commandBarGalleryDropDown2
            createLineBaseItem1.Id = 287
            createLineBaseItem1.Name = "createLineBaseItem1"
            ' 
            ' commandBarGalleryDropDown2
            ' 
            ' 
            ' 
            ' 
            chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createLineChartItem1, createFullStackedLineChartItem1, createScatterLineChartItem1, createSplineChartItem1, createStackedLineChartItem1, createStepLineChartItem1})
            chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createLine3DChartItem1, createFullStackedLine3DChartItem1, createSpline3DChartItem1, createStackedLine3DChartItem1, createStepLine3DChartItem1})
            commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {chartControlCommandGalleryItemGroup2DLine1, chartControlCommandGalleryItemGroup3DLine1})
            commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
            commandBarGalleryDropDown2.Ribbon = ribbonControl1
            ' 
            ' createPieBaseItem1
            ' 
            createPieBaseItem1.DropDownControl = commandBarGalleryDropDown3
            createPieBaseItem1.Id = 288
            createPieBaseItem1.Name = "createPieBaseItem1"
            ' 
            ' commandBarGalleryDropDown3
            ' 
            ' 
            ' 
            ' 
            chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createPieChartItem1, createDoughnutChartItem1, createNestedDoughnutChartItem1})
            chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createPie3DChartItem1, createDoughnut3DChartItem1})
            commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {chartControlCommandGalleryItemGroup2DPie1, chartControlCommandGalleryItemGroup3DPie1})
            commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
            commandBarGalleryDropDown3.Ribbon = ribbonControl1
            ' 
            ' createRotatedBarBaseItem1
            ' 
            createRotatedBarBaseItem1.DropDownControl = commandBarGalleryDropDown4
            createRotatedBarBaseItem1.Id = 289
            createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1"
            ' 
            ' commandBarGalleryDropDown4
            ' 
            ' 
            ' 
            ' 
            chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createRotatedBarChartItem1, createRotatedFullStackedBarChartItem1, createRotatedSideBySideFullStackedBarChartItem1, createRotatedSideBySideStackedBarChartItem1, createRotatedStackedBarChartItem1})
            commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {chartControlCommandGalleryItemGroup2DBar1})
            commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
            commandBarGalleryDropDown4.Ribbon = ribbonControl1
            ' 
            ' createAreaBaseItem1
            ' 
            createAreaBaseItem1.DropDownControl = commandBarGalleryDropDown5
            createAreaBaseItem1.Id = 290
            createAreaBaseItem1.Name = "createAreaBaseItem1"
            ' 
            ' commandBarGalleryDropDown5
            ' 
            ' 
            ' 
            ' 
            chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createAreaChartItem1, createFullStackedAreaChartItem1, createFullStackedSplineAreaChartItem1, createSplineAreaChartItem1, createStackedAreaChartItem1, createStackedSplineAreaChartItem1, createStepAreaChartItem1})
            chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createArea3DChartItem1, createFullStackedArea3DChartItem1, createFullStackedSplineArea3DChartItem1, createSplineArea3DChartItem1, createStackedArea3DChartItem1, createStackedSplineArea3DChartItem1, createStepArea3DChartItem1})
            commandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {chartControlCommandGalleryItemGroup2DArea1, chartControlCommandGalleryItemGroup3DArea1})
            commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
            commandBarGalleryDropDown5.Ribbon = ribbonControl1
            ' 
            ' createOtherSeriesTypesBaseItem1
            ' 
            createOtherSeriesTypesBaseItem1.DropDownControl = commandBarGalleryDropDown6
            createOtherSeriesTypesBaseItem1.Id = 291
            createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1"
            ' 
            ' commandBarGalleryDropDown6
            ' 
            ' 
            ' 
            ' 
            chartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createPointChartItem1, createBubbleChartItem1})
            chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createFunnelChartItem1, createFunnel3DChartItem1})
            chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createStockChartItem1, createCandleStickChartItem1})
            chartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createRadarPointChartItem1, createRadarLineChartItem1, createRadarAreaChartItem1})
            chartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createPolarPointChartItem1, createPolarLineChartItem1, createPolarAreaChartItem1})
            chartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createRangeBarChartItem1, createSideBySideRangeBarChartItem1, createRangeAreaChartItem1, createRangeArea3DChartItem1})
            chartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {createGanttChartItem1, createSideBySideGanttChartItem1})
            commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {chartControlCommandGalleryItemGroupPoint1, chartControlCommandGalleryItemGroupFunnel1, chartControlCommandGalleryItemGroupFinancial1, chartControlCommandGalleryItemGroupRadar1, chartControlCommandGalleryItemGroupPolar1, chartControlCommandGalleryItemGroupRange1, chartControlCommandGalleryItemGroupGantt1})
            commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
            commandBarGalleryDropDown6.Ribbon = ribbonControl1
            ' 
            ' chartAppearanceRibbonPageGroup1
            ' 
            chartAppearanceRibbonPageGroup1.ItemLinks.Add(changePaletteGalleryBaseItem1)
            chartAppearanceRibbonPageGroup1.ItemLinks.Add(changeAppearanceGalleryBaseItem1)
            chartAppearanceRibbonPageGroup1.Name = "chartAppearanceRibbonPageGroup1"
            ' 
            ' changePaletteGalleryBaseItem1
            ' 
            changePaletteGalleryBaseItem1.DropDownControl = commandBarGalleryDropDown7
            changePaletteGalleryBaseItem1.Id = 292
            changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1"
            ' 
            ' commandBarGalleryDropDown7
            ' 
            commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
            commandBarGalleryDropDown7.Ribbon = ribbonControl1
            ' 
            ' changeAppearanceGalleryBaseItem1
            ' 
            ' 
            ' 
            ' 
            changeAppearanceGalleryBaseItem1.Gallery.ColumnCount = 7
            changeAppearanceGalleryBaseItem1.Gallery.ImageSize = New System.Drawing.Size(80, 50)
            changeAppearanceGalleryBaseItem1.Gallery.RowCount = 4
            changeAppearanceGalleryBaseItem1.Id = 293
            changeAppearanceGalleryBaseItem1.Name = "changeAppearanceGalleryBaseItem1"
            ' 
            ' chartWizardRibbonPageGroup1
            ' 
            chartWizardRibbonPageGroup1.AllowMinimize = False
            chartWizardRibbonPageGroup1.ItemLinks.Add(runWizardChartItem1)
            chartWizardRibbonPageGroup1.Name = "chartWizardRibbonPageGroup1"
            ' 
            ' runWizardChartItem1
            ' 
            runWizardChartItem1.Id = 294
            runWizardChartItem1.Name = "runWizardChartItem1"
            ' 
            ' Form1
            ' 
            snapForm.Controls.Add(ribbonControl1)
            CType(ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
            snapForm.ResumeLayout(False)
            snapForm.PerformLayout()
        End Sub
	End Module
End Namespace
