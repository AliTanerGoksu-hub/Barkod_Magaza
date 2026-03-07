Imports DevExpress.XtraEditors
Public Class frm_uretim_plan
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEVRAKNO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowACIKLAMA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDETAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIMMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISLEMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONERISIMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKULLANICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERMIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMEBASLAMATARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIPARISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISEMRIIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISEMRINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VGrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents sec_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_uretim_plan))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.VGrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl
        Me.ds_baslik = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.sec_aciklama = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowEVRAKNO = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ds_hareket = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDETAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEKMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIRIM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIRIMMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKDV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colISLEMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSONERISIMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKULLANICI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colORAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTUR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYERNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTERMIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colURETIMEBASLAMATARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSIPARISNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colISEMRIIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colISEMRINO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.CloseButtonAffectAllTabs = False
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarSubItem6, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 22
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Belge Dizayn"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Belge Önizle"
        Me.BarButtonItem2.Id = 7
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Belge Yazdýr"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Belgeyi Ýptal Et"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Plan"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Ýþ Emri Oluþtur"
        Me.BarButtonItem5.Id = 10
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Ýþ Emri Oluþtur ve Belgeleri Göster"
        Me.BarButtonItem6.Id = 11
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Ýþ Emri Oluþtur ve Üretimi Baþlat"
        Me.BarButtonItem7.Id = 12
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Ýþ Emri Oluþtur ve Üretimi Bitir"
        Me.BarButtonItem8.Id = 13
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Görünüm"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Baþlýk"
        Me.BarButtonItem9.Id = 14
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Hareketler"
        Me.BarButtonItem10.Id = 15
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Toplam"
        Me.BarButtonItem11.Id = 16
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Araçlar"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Birleþtir"
        Me.BarButtonItem12.Id = 17
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Ekle"
        Me.BarSubItem5.Id = 4
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Mamül Ekle"
        Me.BarButtonItem13.Id = 18
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Sipariþ Ekle"
        Me.BarButtonItem14.Id = 19
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Ekran"
        Me.BarSubItem6.Id = 5
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem15.Caption = "Tam Ekran"
        Me.BarButtonItem15.Id = 20
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Status?"
        Me.BarButtonItem16.Id = 21
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 517)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 495)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 495)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.VGrid_baslik)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 22)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 104)
        Me.PanelControl1.TabIndex = 4
        '
        'VGrid_baslik
        '
        Me.VGrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(806, 402, 208, 252)
        Me.VGrid_baslik.DataMember = Nothing
        Me.VGrid_baslik.DataSource = Me.ds_baslik
        Me.VGrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_baslik.Name = "VGrid_baslik"
        Me.VGrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_aciklama})
        Me.VGrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTanýmlar})
        Me.VGrid_baslik.Size = New System.Drawing.Size(820, 100)
        Me.VGrid_baslik.TabIndex = 0
        Me.VGrid_baslik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "EVRAKNO"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ACIKLAMA"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "TARIH"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'sec_aciklama
        '
        Me.sec_aciklama.MaxLength = 100
        Me.sec_aciklama.Name = "sec_aciklama"
        Me.sec_aciklama.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIND, Me.rowEVRAKNO, Me.rowTARIH, Me.rowACIKLAMA})
        Me.categoryTanýmlar.Name = "categoryTanýmlar"
        Me.categoryTanýmlar.Properties.Caption = "Tanýmlar"
        '
        'rowIND
        '
        Me.rowIND.Name = "rowIND"
        Me.rowIND.Properties.Caption = "Kayýt No"
        Me.rowIND.Properties.FieldName = "IND"
        Me.rowIND.Properties.ReadOnly = True
        '
        'rowEVRAKNO
        '
        Me.rowEVRAKNO.Height = 16
        Me.rowEVRAKNO.Name = "rowEVRAKNO"
        Me.rowEVRAKNO.Properties.Caption = "Belge No"
        Me.rowEVRAKNO.Properties.FieldName = "EVRAKNO"
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.Properties.Caption = "Tarih"
        Me.rowTARIH.Properties.FieldName = "TARIH"
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.Properties.Caption = "Açýklama"
        Me.rowACIKLAMA.Properties.FieldName = "ACIKLAMA"
        Me.rowACIKLAMA.Properties.RowEdit = Me.sec_aciklama
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 126)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 5)
        Me.SplitterControl1.TabIndex = 5
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 485)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 32)
        Me.PanelControl2.TabIndex = 6
        Me.PanelControl2.Visible = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Label1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 461)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 24)
        Me.PanelControl3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Satýr % / %"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GridControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 131)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(824, 330)
        Me.PanelControl4.TabIndex = 8
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 326)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "IND"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "DETAY"
        Me.DataColumn6.DataType = GetType(Long)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "EVRAKNO"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "STOKNO"
        Me.DataColumn8.DataType = GetType(Long)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "STOKKODU"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "MALINCINSI"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "MIKTAR"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "EKMIKTAR"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "BIRIM"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "BIRIMMIKTAR"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "KDV"
        Me.DataColumn15.DataType = GetType(Long)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "FIYAT"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "BARCODE"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ISLEMTARIHI"
        Me.DataColumn18.DataType = GetType(Date)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "SONERISIMTARIHI"
        Me.DataColumn19.DataType = GetType(Date)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "KULLANICI"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ORAN"
        Me.DataColumn21.DataType = GetType(Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "TUR"
        Me.DataColumn22.DataType = GetType(Long)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "YERNO"
        Me.DataColumn23.DataType = GetType(Long)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "ACIKLAMA"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "TERMIN"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "URETIMEBASLAMATARIHI"
        Me.DataColumn26.DataType = GetType(Date)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "SIPARISNO"
        Me.DataColumn27.DataType = GetType(Long)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "ISEMRIIND"
        Me.DataColumn28.DataType = GetType(Long)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "ISEMRINO"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colDETAY, Me.colEVRAKNO, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colMIKTAR, Me.colEKMIKTAR, Me.colBIRIM, Me.colBIRIMMIKTAR, Me.colKDV, Me.colFIYAT, Me.colBARCODE, Me.colISLEMTARIHI, Me.colSONERISIMTARIHI, Me.colKULLANICI, Me.colORAN, Me.colTUR, Me.colYERNO, Me.colACIKLAMA, Me.colTERMIN, Me.colURETIMEBASLAMATARIHI, Me.colSIPARISNO, Me.colISEMRIIND, Me.colISEMRINO})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(451, 234, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.OptionsColumn.AllowEdit = False
        '
        'colDETAY
        '
        Me.colDETAY.Caption = "Detay"
        Me.colDETAY.FieldName = "DETAY"
        Me.colDETAY.Name = "colDETAY"
        Me.colDETAY.OptionsColumn.AllowEdit = False
        '
        'colEVRAKNO
        '
        Me.colEVRAKNO.Caption = "Evrak No"
        Me.colEVRAKNO.FieldName = "EVRAKNO"
        Me.colEVRAKNO.Name = "colEVRAKNO"
        Me.colEVRAKNO.OptionsColumn.AllowEdit = False
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        Me.colSTOKNO.OptionsColumn.AllowEdit = False
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.OptionsColumn.AllowEdit = False
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 0
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 1
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.####"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.####}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 2
        '
        'colEKMIKTAR
        '
        Me.colEKMIKTAR.Caption = "EkMiktar"
        Me.colEKMIKTAR.DisplayFormat.FormatString = "#,0.####"
        Me.colEKMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKMIKTAR.FieldName = "EKMIKTAR"
        Me.colEKMIKTAR.Name = "colEKMIKTAR"
        Me.colEKMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKMIKTAR", "{0:#,0.####}")})
        Me.colEKMIKTAR.Visible = True
        Me.colEKMIKTAR.VisibleIndex = 3
        '
        'colBIRIM
        '
        Me.colBIRIM.Caption = "Birim"
        Me.colBIRIM.FieldName = "BIRIM"
        Me.colBIRIM.Name = "colBIRIM"
        Me.colBIRIM.Visible = True
        Me.colBIRIM.VisibleIndex = 4
        '
        'colBIRIMMIKTAR
        '
        Me.colBIRIMMIKTAR.Caption = "Birim Miktar"
        Me.colBIRIMMIKTAR.DisplayFormat.FormatString = "#,0.####"
        Me.colBIRIMMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBIRIMMIKTAR.FieldName = "BIRIMMIKTAR"
        Me.colBIRIMMIKTAR.Name = "colBIRIMMIKTAR"
        '
        'colKDV
        '
        Me.colKDV.Caption = "Kdv"
        Me.colKDV.DisplayFormat.FormatString = "#,0.####"
        Me.colKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKDV.FieldName = "KDV"
        Me.colKDV.Name = "colKDV"
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.DisplayFormat.FormatString = "#,0.####"
        Me.colFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT.FieldName = "FIYAT"
        Me.colFIYAT.Name = "colFIYAT"
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barcode"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        '
        'colISLEMTARIHI
        '
        Me.colISLEMTARIHI.Caption = "Ýþlem Tarihi"
        Me.colISLEMTARIHI.FieldName = "ISLEMTARIHI"
        Me.colISLEMTARIHI.Name = "colISLEMTARIHI"
        '
        'colSONERISIMTARIHI
        '
        Me.colSONERISIMTARIHI.Caption = "SonEriþimTarihi"
        Me.colSONERISIMTARIHI.FieldName = "SONERISIMTARIHI"
        Me.colSONERISIMTARIHI.Name = "colSONERISIMTARIHI"
        '
        'colKULLANICI
        '
        Me.colKULLANICI.Caption = "Kaydeden"
        Me.colKULLANICI.FieldName = "KULLANICI"
        Me.colKULLANICI.Name = "colKULLANICI"
        Me.colKULLANICI.OptionsColumn.AllowEdit = False
        '
        'colORAN
        '
        Me.colORAN.Caption = "Oran%"
        Me.colORAN.DisplayFormat.FormatString = "#,0.####"
        Me.colORAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN.FieldName = "ORAN"
        Me.colORAN.Name = "colORAN"
        Me.colORAN.OptionsColumn.AllowEdit = False
        '
        'colTUR
        '
        Me.colTUR.Caption = "Tür"
        Me.colTUR.FieldName = "TUR"
        Me.colTUR.Name = "colTUR"
        Me.colTUR.OptionsColumn.AllowEdit = False
        '
        'colYERNO
        '
        Me.colYERNO.Caption = "Yer"
        Me.colYERNO.FieldName = "YERNO"
        Me.colYERNO.Name = "colYERNO"
        Me.colYERNO.OptionsColumn.AllowEdit = False
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 5
        '
        'colTERMIN
        '
        Me.colTERMIN.Caption = "Termin"
        Me.colTERMIN.FieldName = "TERMIN"
        Me.colTERMIN.Name = "colTERMIN"
        Me.colTERMIN.Visible = True
        Me.colTERMIN.VisibleIndex = 6
        '
        'colURETIMEBASLAMATARIHI
        '
        Me.colURETIMEBASLAMATARIHI.Caption = "ÜretimeBaþlamaTarihi"
        Me.colURETIMEBASLAMATARIHI.FieldName = "URETIMEBASLAMATARIHI"
        Me.colURETIMEBASLAMATARIHI.Name = "colURETIMEBASLAMATARIHI"
        Me.colURETIMEBASLAMATARIHI.Visible = True
        Me.colURETIMEBASLAMATARIHI.VisibleIndex = 7
        '
        'colSIPARISNO
        '
        Me.colSIPARISNO.Caption = "Sipariþ No"
        Me.colSIPARISNO.FieldName = "SIPARISNO"
        Me.colSIPARISNO.Name = "colSIPARISNO"
        Me.colSIPARISNO.OptionsColumn.AllowEdit = False
        '
        'colISEMRIIND
        '
        Me.colISEMRIIND.Caption = "ÝþEmriNo"
        Me.colISEMRIIND.FieldName = "ISEMRIIND"
        Me.colISEMRIIND.Name = "colISEMRIIND"
        Me.colISEMRIIND.OptionsColumn.AllowEdit = False
        '
        'colISEMRINO
        '
        Me.colISEMRINO.Caption = "ÝþEmriBelgeNo"
        Me.colISEMRINO.FieldName = "ISEMRINO"
        Me.colISEMRINO.Name = "colISEMRINO"
        Me.colISEMRINO.OptionsColumn.AllowEdit = False
        '
        'Timer1
        '
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem4, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem2.Text = "Sil"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Deðer Yay"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 100, 60)
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_uretim_plan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 542)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_uretim_plan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üretim Planý"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public firma
    Public donemno
    Public donem
    Public userno
    Public username
    Public connection
    Public depono
    Public belgeind As Int64
    Dim dr As DataRow
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dr_baslik As DataRow
    Dim dr_haraket As DataRow
    'Dim dr_maliyet As DataRow
    'Dim dr_toplam As DataRow
    'Dim dr_cikti As DataRow
    'Dim dr_pozisyon As DataRow
    'Dim dr_arac As DataRow
    Private Sub frm_uretim_plan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        stok_degistir()
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub stok_degistir()
        If belgeind = 0 Then
            dr = ds_baslik.Tables(0).NewRow
            dr("IND") = 100
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = ds_baslik.Tables(0).Rows(0)
            dr = ds_baslik.Tables(0).Rows(0)
            Try
                dr("EVRAKNO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
                con.Close()
            Catch ex As Exception
                dr("EVRAKNO") = "A-000001"
            End Try
            dr("TARIH") = Today
            dr("ACIKLAMA") = ""
            dr("IND") = baslik_kaydet_yeni(dr("EVRAKNO"), dr("TARIH"), dr("ACIKLAMA"))
            belgeind = dr("IND")
        ElseIf belgeind <> 0 Then
        Else
            Me.Close()
        End If
    End Sub
    Private Function belgeno_kontrol(ByVal belgeno As String, Optional ByVal islem As Integer = 0) As String
        Dim seri
        Dim no
        Dim evrak_no
        evrak_no = belgeno
        evrak_no = evrak_no.Replace(0, "")
        evrak_no = evrak_no.Replace(1, "")
        evrak_no = evrak_no.Replace(2, "")
        evrak_no = evrak_no.Replace(3, "")
        evrak_no = evrak_no.Replace(4, "")
        evrak_no = evrak_no.Replace(5, "")
        evrak_no = evrak_no.Replace(6, "")
        evrak_no = evrak_no.Replace(7, "")
        evrak_no = evrak_no.Replace(8, "")
        evrak_no = evrak_no.Replace(9, "")
        'txtbelgeseri.EditValue = evrak_no
        seri = evrak_no
        If evrak_no = "" Then
            seri = "A-"
        End If
        evrak_no = belgeno
        evrak_no = evrak_no.Replace("A", "")
        evrak_no = evrak_no.Replace("B", "")
        evrak_no = evrak_no.Replace("C", "")
        evrak_no = evrak_no.Replace("Ç", "")
        evrak_no = evrak_no.Replace("D", "")
        evrak_no = evrak_no.Replace("E", "")
        evrak_no = evrak_no.Replace("F", "")
        evrak_no = evrak_no.Replace("G", "")
        evrak_no = evrak_no.Replace("H", "")
        evrak_no = evrak_no.Replace("I", "")
        evrak_no = evrak_no.Replace("Ý", "")
        evrak_no = evrak_no.Replace("J", "")
        evrak_no = evrak_no.Replace("K", "")
        evrak_no = evrak_no.Replace("L", "")
        evrak_no = evrak_no.Replace("M", "")
        evrak_no = evrak_no.Replace("N", "")
        evrak_no = evrak_no.Replace("O", "")
        evrak_no = evrak_no.Replace("Ö", "")
        evrak_no = evrak_no.Replace("P", "")
        evrak_no = evrak_no.Replace("R", "")
        evrak_no = evrak_no.Replace("S", "")
        evrak_no = evrak_no.Replace("Þ", "")
        evrak_no = evrak_no.Replace("T", "")
        evrak_no = evrak_no.Replace("U", "")
        evrak_no = evrak_no.Replace("Ü", "")
        evrak_no = evrak_no.Replace("V", "")
        evrak_no = evrak_no.Replace("Y", "")
        evrak_no = evrak_no.Replace("Z", "")
        evrak_no = evrak_no.Replace("X", "")
        evrak_no = evrak_no.Replace("W", "")
        evrak_no = evrak_no.Replace("_", "")
        evrak_no = evrak_no.Replace("-", "")
        evrak_no = evrak_no.Replace("*", "")
        evrak_no = evrak_no.Replace("/", "")
        evrak_no = evrak_no.Replace("+", "")
        Try
            If islem = 0 Then
                no = CType(evrak_no, Integer) + 1
            Else
                no = CType(evrak_no, Integer)
            End If
            no = columnuzunlukinteger_sifir(no.ToString, 6)
            belgeno = seri + no.ToString
        Catch ex As Exception
            belgeno = seri + columnuzunlukinteger_sifir(1, 6)
        End Try
        Return belgeno
    End Function
    Private Function dataload_belgeno() As String
        Dim sonuc
        Try
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(EVRAKNO,'A-000001') AS BELGENO FROM TBLUREPLANLIST WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM TBLUREPLANLIST  WHERE  EVRAKNO LIKE 'A%')")
            sonuc = cmd.ExecuteScalar
            con.Close()
            If CStr(sonuc).ToString = "" Then
                sonuc = "A-000000"
            End If
        Catch ex As Exception
            sonuc = "A-000000"
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return sonuc
        sonuc = Nothing
    End Function
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Sub satir_ekle_girdi()
        Dim frm As New frm_uretim_recete_liste
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If frm.ShowDialog() = DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_hareket.Tables(0).NewRow
                    Dim dr1 As DataRow = frm.GridView1.GetDataRow(s)
                    dr("DETAY") = 0
                    dr("EVRAKNO") = belgeind
                    dr("STOKNO") = dr1("STOKNO")
                    dr("STOKKODU") = dr1("STOKKODU")
                    dr("MALINCINSI") = dr1("MALINCINSI")
                    dr("MIKTAR") = 1
                    dr("EKMIKTAR") = 0
                    dr("BIRIM") = dr1("BIRIM")
                    dr("BIRIMMIKTAR") = 1
                    dr("KDV") = dr1("KDV")
                    dr("FIYAT") = dr1("FIYAT")
                    dr("BARCODE") = "" 'dr1("BARCODE")
                    dr("ISLEMTARIHI") = Today
                    dr("SONERISIMTARIHI") = Today
                    dr("KULLANICI") = userno
                    dr("ORAN") = 100
                    dr("TUR") = 0
                    dr("YERNO") = 0
                    dr("ACIKLAMA") = ""
                    dr("TERMIN") = Today
                    dr("URETIMEBASLAMATARIHI") = Today
                    dr("SIPARISNO") = 0
                    dr("ISEMRIIND") = 0
                    dr("ISEMRINO") = 0
                    dr("IND") = hareket_kaydet_yeni(dr("DETAY"), dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("EKMIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), dr("ISLEMTARIHI"), dr("SONERISIMTARIHI"), dr("KULLANICI"), dr("ORAN"), dr("TUR"), dr("YERNO"), dr("ACIKLAMA"), dr("TERMIN"), dr("URETIMEBASLAMATARIHI"), dr("SIPARISNO"), dr("ISEMRIIND"), dr("ISEMRINO"))
                    ds_hareket.Tables(0).Rows.Add(dr)
                    dr1 = Nothing
                Next
            End If
        Else
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        'kl = CType(Me.BindingContext(DataView1), CurrencyManager)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim Ý As Integer
        Ý = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        'kl.Position += 1
        For Ý = 1 To TOPLAM
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            girdi_tutar_hesapla()
            'maliyetkontrol()
            GridView1.FocusedRowHandle += 1
        Next
        'kl.Position = satir
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub ekran_full()
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        ekran_full()
    End Sub
    Private Function baslik_kaydet_yeni(ByVal EVRAKNO As String, ByVal TARIH As DateTime, ByVal ACIKLAMA As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREPLANLIST (EVRAKNO, TARIH, ACIKLAMA) VALUES     ('" & EVRAKNO & "', '" & TARIH & "', '" & ACIKLAMA & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub baslik_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As String, ByVal TARIH As DateTime, ByVal ACIKLAMA As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREPLANLIST SET EVRAKNO = '" & EVRAKNO & "', TARIH = '" & TARIH & "', ACIKLAMA = '" & ACIKLAMA & "' WHERE IND  =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub baslik_kaydet_sil(ByVal ind As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM TBLUREPLANLIST WHERE IND  =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function hareket_kaydet_yeni(ByVal DETAY As Int64, ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal EKMIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal KDV As Decimal, ByVal FIYAT As Decimal, ByVal BARCODE As String, ByVal ISLEMTARIHI As DateTime, ByVal SONERISIMTARIHI As DateTime, ByVal KULLANICI As Int64, ByVal ORAN As Decimal, ByVal TUR As Int64, ByVal YERNO As Int64, ByVal ACIKLAMA As String, ByVal TERMIN As DateTime, ByVal URETIMEBASLAMATARIHI As DateTime, ByVal SIPARISNO As Int64, ByVal ISEMRIIND As Int64, ByVal ISEMRINO As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREPLAN (DETAY, EVRAKNO, STOKNO, STOKKODU, MALINCINSI, MIKTAR, EKMIKTAR, BIRIM, BIRIMMIKTAR, KDV, FIYAT, BARCODE, ISLEMTARIHI,SONERISIMTARIHI, KULLANICI, ORAN, TUR, YERNO, ACIKLAMA, TERMIN, URETIMEBASLAMATARIHI, SIPARISNO, ISEMRIIND, ISEMRINO) VALUES     (" & DETAY & ", " & EVRAKNO & ", " & STOKNO & ", '" & STOKKODU & "', '" & MALINCINSI & "', " & MIKTAR & ", " & EKMIKTAR & ", '" & BIRIM & "', " & BIRIMMIKTAR & ", " & KDV & " , " & FIYAT & ", '" & BARCODE & "', '" & ISLEMTARIHI & "','" & SONERISIMTARIHI & "', " & KULLANICI & ", " & ORAN & ", " & TUR & " , " & YERNO & " , '" & ACIKLAMA & "', '" & TERMIN & "', '" & URETIMEBASLAMATARIHI & "', " & SIPARISNO & ", " & ISEMRIIND & ", " & ISEMRINO & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal DETAY As Int64, ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal EKMIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal KDV As Decimal, ByVal FIYAT As Decimal, ByVal BARCODE As String, ByVal ISLEMTARIHI As DateTime, ByVal SONERISIMTARIHI As DateTime, ByVal KULLANICI As Int64, ByVal ORAN As Decimal, ByVal TUR As Int64, ByVal YERNO As Int64, ByVal ACIKLAMA As String, ByVal TERMIN As DateTime, ByVal URETIMEBASLAMATARIHI As DateTime, ByVal SIPARISNO As Int64, ByVal ISEMRIIND As Int64, ByVal ISEMRINO As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    TBLUREPLAN SET              DETAY = " & DETAY & ", EVRAKNO = " & EVRAKNO & " , STOKNO = " & STOKNO & " , STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "', MIKTAR = " & MIKTAR & " ,  EKMIKTAR = " & EKMIKTAR & " , BIRIM = '" & BIRIM & "', BIRIMMIKTAR = " & BIRIMMIKTAR & " , KDV = " & KDV & " , FIYAT = " & FIYAT & " , BARCODE = '" & BARCODE & "', ISLEMTARIHI = '" & ISLEMTARIHI & "', SONERISIMTARIHI = '" & SONERISIMTARIHI & "', KULLANICI = " & KULLANICI & " , ORAN = " & ORAN & " , TUR = " & TUR & " , YERNO = " & YERNO & " , ACIKLAMA = '" & ACIKLAMA & "', TERMIN = '" & TERMIN & "', URETIMEBASLAMATARIHI = '" & URETIMEBASLAMATARIHI & "', SIPARISNO = " & SIPARISNO & " , ISEMRIIND = " & ISEMRIIND & " , ISEMRINO = " & ISEMRINO & "  WHERE IND = " & ind & " AND EVRAKNO =" & EVRAKNO & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_sil(ByVal ind As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREPLAN  WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         TBLUREPLANLIST WHERE IND =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
    End Function
    Private Function sorgu_hareket(ByVal kriter As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         TBLUREPLAN WHERE EVRAKNO =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
    End Function
    Private Sub loaded()
        'stok class çalýþtýr
        'stok_islemleri.firmano = firmano
        'stok_islemleri.firma = firma
        'stok_islemleri.donemno = donemno
        'stok_islemleri.donem = donem
        'stok_islemleri.userno = userno
        'stok_islemleri.username = username
        'stok_islemleri.connection = connection
        dataload_baslik()
        dataload_hareket()
        GridControl1.Focus()
        GridControl1.Select()
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        Timer1.Enabled = True
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\PLAN\HAREKET\" & Me.Name.ToString & "")
        VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\PLAN\BASLIK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\PLAN\HAREKET\" & Me.Name.ToString & "")
        'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\PLAN\BASLIK\" & Me.Name.ToString & "")
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
    End Sub
    Private Sub dataload_baslik()
        ds_baslik.Tables(0).Clear()
        ds_baslik = sorgu_baslik("")
        VGrid_baslik.DataSource = ds_baslik
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
    End Sub
    Private Sub dataload_hareket()
        ds_hareket = sorgu_hareket("")
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        GridControl1.Select()
    End Sub
    Private Sub alttoplam_hesapla()
        Dim miktar As Decimal = 0
        Dim dr As DataRow
        For Each dr In ds_hareket.Tables(0).Rows
            miktar = miktar + dr("MIKTAR")
        Next
        Label1.Text = "Satýr : " & FormatNumber(GridView1.FocusedRowHandle + 1, 0) & " / " & GridView1.RowCount & " ,Toplam Miktar : [ " & FormatNumber(miktar, 2) & " ]"
        miktar = Nothing
    End Sub
    Private Sub belge_iptal(ByVal evrakno As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'Plan Baþlýk
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREPLANLIST WHERE IND =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Plan Hareket
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREPLAN WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        ''Çýktý Sil
        'cmd.CommandText = sorgu_query("DELETE FROM TBLURERECETECIKTI WHERE EVRAKNO =" & evrakno & "")
        'cmd.ExecuteNonQuery()
        ''Araç Sil
        'cmd.CommandText = sorgu_query("DELETE FROM TBLURERECETEARAC WHERE EVRAKNO =" & evrakno & "")
        'cmd.ExecuteNonQuery()
        ''Reçete Bilgisi Sil
        'cmd.CommandText = sorgu_query("DELETE FROM TBLURERECETELIST WHERE IND =" & evrakno & "")
        'cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub girdi_tutar_hesapla()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            If dr("MIKTAR") = 0 Then
                dr("MIKTAR") = 1
            End If
            'If GridView1.FocusedColumn.Name.ToString = colHTUTAR.Name.ToString Then
            '    dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
            'Else
            '    dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            'End If
            'dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), dr("DETAY"), dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("EKMIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), dr("ISLEMTARIHI"), dr("SONERISIMTARIHI"), dr("KULLANICI"), dr("ORAN"), dr("TUR"), dr("YERNO"), dr("ACIKLAMA"), dr("TERMIN"), dr("URETIMEBASLAMATARIHI"), dr("SIPARISNO"), dr("ISEMRIIND"), dr("ISEMRINO"))
            Timer1.Enabled = False
            'alttoplam_hesapla()
            'cikti_maliyet_degistir(belgeind, dr_baslik("MIKTAR"), 1, dr_toplam("BIRIMMALIYET"), dr_toplam("TOPLAM"), dr_baslik("STOKNO"))
            Timer1.Enabled = True
            'dataload_cikti()
            'oran_dagilim()
            'dataload_pozisyon_maliyet()
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        Try
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("EVRAKNO"), dr_baslik("TARIH"), dr_baslik("ACIKLAMA"))
        Catch ex As Exception
        End Try
        'VGrid_baslik.PostEditor()
        'VGrid_baslik.UpdateFocusedRecord()
        'VGrid_baslik.CloseEditor()
        'baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("EVRAKNO"), dr_baslik("TARIH"), dr_baslik("ACIKLAMA"))
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Kapatmak Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        VGrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle_girdi()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Girdi Kaydýný Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                hareket_kaydet_sil(dr("IND"))
                ds_hareket.Tables(0).Rows.Remove(dr)
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            alttoplam_hesapla()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Planlama Kaydýný Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            belge_iptal(belgeind)
            Me.Close()
        End If
    End Sub
    Private Sub frm_uretim_plan_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If GridView1.RowCount = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..! " & vbCrLf & "Planlama Kaydýný Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                belge_iptal(belgeind)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        satir_ekle_girdi()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("EVRAKNO") & vbCrLf & "Açýklama :" & vbTab & dr_baslik("ACIKLAMA"), "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Üretim Planlarý", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PageSetup()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("EVRAKNO") & vbCrLf & "Açýklama :" & vbTab & dr_baslik("ACIKLAMA"), "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Üretim Planlarý", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewFormEx.ShowDialog()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        'Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("BELGENO") & vbCrLf & "ÖzelKod :" & vbTab & dr_baslik("OZELKOD") & vbCrLf & "Açýklama :" & vbTab & txt_aciklama.EditValue & vbCrLf & "Toplam :" & vbTab & FormatNumber(txt_toplamtutar.EditValue, 2), "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "SatýnAlma Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("EVRAKNO") & vbCrLf & "Açýklama :" & vbTab & dr_baslik("ACIKLAMA"), "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Üretim Planlarý", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PrintDlg()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView1.FocusedColumn().FieldName)
                If GridView1.FocusedColumn().FieldName = "FIRMAKODU" Then
                    degeryay("FIRMANO")
                    degeryay("FIRMAKODU")
                    degeryay("FIRMAADI")
                ElseIf GridView1.FocusedColumn().FieldName = "FIRMAADI" Then
                    degeryay("FIRMANO")
                    degeryay("FIRMAKODU")
                    degeryay("FIRMAADI")
                ElseIf GridView1.FocusedColumn().FieldName = "FIRMANO" Then
                    degeryay("FIRMANO")
                    degeryay("FIRMAKODU")
                    degeryay("FIRMAADI")
                ElseIf GridView1.FocusedColumn().FieldName = "STOKNO" Then
                    degeryay("STOKNO")
                    degeryay("STOKKODU")
                    degeryay("MALINCINSI")
                ElseIf GridView1.FocusedColumn().FieldName = "STOKKODU" Then
                    degeryay("STOKNO")
                    degeryay("STOKKODU")
                    degeryay("MALINCINSI")
                ElseIf GridView1.FocusedColumn().FieldName = "MALINCINSI" Then
                    degeryay("STOKNO")
                    degeryay("STOKKODU")
                    degeryay("MALINCINSI")
                End If
            End If
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class
