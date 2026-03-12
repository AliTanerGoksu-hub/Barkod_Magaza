Imports DevExpress.XtraEditors
Public Class frm_uretim_satinalma
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
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_toplamtutar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_toplammiktar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBELGENO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOZELKOD As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIHTIYACTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKABUL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGEIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERMINTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents Vgrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents sec_tur As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_kabul As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_fiyat As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ds_girdi_tur As System.Data.DataSet
    Friend WithEvents DataTable8 As System.Data.DataTable
    Friend WithEvents DataColumn116 As System.Data.DataColumn
    Friend WithEvents DataColumn117 As System.Data.DataColumn
    Friend WithEvents ds_kabul As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_uretim_satinalma))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Vgrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl
        Me.ds_baslik = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowBELGENO = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowOZELKOD = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txt_aciklama = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_toplammiktar = New DevExpress.XtraEditors.CalcEdit
        Me.txt_toplamtutar = New DevExpress.XtraEditors.CalcEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.ds_hareket = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIRIM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_fiyat = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIHTIYACTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTUR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_tur = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DataTable8 = New System.Data.DataTable
        Me.DataColumn116 = New System.Data.DataColumn
        Me.DataColumn117 = New System.Data.DataColumn
        Me.colKABUL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_kabul = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBELGEIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTERMINTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ds_girdi_tur = New System.Data.DataSet
        Me.ds_kabul = New System.Data.DataSet
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_toplammiktar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_toplamtutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kabul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_girdi_tur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kabul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarSubItem6, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarStaticItem1})
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
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Kopyala"
        Me.BarButtonItem11.Id = 16
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K))
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Belge Dizayn"
        Me.BarButtonItem12.Id = 17
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Belge Önizle"
        Me.BarButtonItem13.Id = 18
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Belge Yazdýr"
        Me.BarButtonItem14.Id = 19
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Belgeyi Ýptal Et"
        Me.BarButtonItem15.Id = 20
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Görünüm"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Baþlýk"
        Me.BarButtonItem6.Id = 11
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Hareketler"
        Me.BarButtonItem7.Id = 12
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Görünümü Kaydet"
        Me.BarButtonItem10.Id = 15
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Araçlar"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Ýhtiyaç Tablosu"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Kaynak Seç"
        Me.BarButtonItem5.Id = 10
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Ekle"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Satýr Ekle"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Ekran"
        Me.BarSubItem5.Id = 4
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Tam Ekran"
        Me.BarButtonItem2.Id = 7
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Language"
        Me.BarSubItem6.Id = 5
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Dil Deðiþtir"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Status"
        Me.BarStaticItem1.Id = 21
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 523)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 19)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 499)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 499)
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Toplam"
        Me.BarButtonItem8.Id = 13
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Açýklama"
        Me.BarButtonItem9.Id = 14
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Vgrid_baslik)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 24)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 96)
        Me.PanelControl1.TabIndex = 4
        '
        'Vgrid_baslik
        '
        Me.Vgrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.Vgrid_baslik.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.Vgrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.Vgrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(806, 402, 208, 252)
        Me.Vgrid_baslik.DataMember = Nothing
        Me.Vgrid_baslik.DataSource = Me.ds_baslik
        Me.Vgrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vgrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.Vgrid_baslik.Location = New System.Drawing.Point(3, 3)
        Me.Vgrid_baslik.Name = "Vgrid_baslik"
        Me.Vgrid_baslik.OptionsBehavior.UseEnterAsTab = True
        Me.Vgrid_baslik.OptionsBehavior.UseTabKey = False
        Me.Vgrid_baslik.RecordWidth = 215
        Me.Vgrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTanýmlar})
        Me.Vgrid_baslik.Size = New System.Drawing.Size(818, 90)
        Me.Vgrid_baslik.TabIndex = 0
        Me.Vgrid_baslik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "BELGENO"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TARIH"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ACIKLAMA"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "TOPLAM"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "OZELKOD"
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIND, Me.rowBELGENO, Me.rowTARIH, Me.rowOZELKOD})
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
        'rowBELGENO
        '
        Me.rowBELGENO.Name = "rowBELGENO"
        Me.rowBELGENO.Properties.Caption = "Belge No"
        Me.rowBELGENO.Properties.FieldName = "BELGENO"
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.Properties.Caption = "Tarih"
        Me.rowTARIH.Properties.FieldName = "TARIH"
        '
        'rowOZELKOD
        '
        Me.rowOZELKOD.Name = "rowOZELKOD"
        Me.rowOZELKOD.Properties.Caption = "ÖzelKod"
        Me.rowOZELKOD.Properties.FieldName = "OZELKOD"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 120)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 4)
        Me.SplitterControl1.TabIndex = 5
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 435)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 88)
        Me.PanelControl2.TabIndex = 6
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.BackColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.BackColor2 = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.txt_aciklama)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(586, 82)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Açýklamalar"
        '
        'txt_aciklama
        '
        Me.txt_aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_baslik, "Table1.ACIKLAMA", True))
        Me.txt_aciklama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds_baslik, "Table1.ACIKLAMA", True))
        Me.txt_aciklama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_aciklama.Location = New System.Drawing.Point(3, 19)
        Me.txt_aciklama.Name = "txt_aciklama"
        Me.txt_aciklama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_aciklama.Properties.Appearance.Options.UseBackColor = True
        Me.txt_aciklama.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama.Size = New System.Drawing.Size(580, 60)
        Me.txt_aciklama.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.BackColor = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.txt_toplammiktar)
        Me.GroupControl1.Controls.Add(Me.txt_toplamtutar)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(589, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(232, 82)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Toplamlar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Toplam Tutar :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Toplam Miktar :"
        '
        'txt_toplammiktar
        '
        Me.txt_toplammiktar.Location = New System.Drawing.Point(104, 32)
        Me.txt_toplammiktar.Name = "txt_toplammiktar"
        Me.txt_toplammiktar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_toplammiktar.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.txt_toplammiktar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_toplammiktar.Properties.ReadOnly = True
        Me.txt_toplammiktar.Size = New System.Drawing.Size(120, 22)
        Me.txt_toplammiktar.TabIndex = 1
        '
        'txt_toplamtutar
        '
        Me.txt_toplamtutar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_baslik, "Table1.TOPLAM", True))
        Me.txt_toplamtutar.Location = New System.Drawing.Point(104, 54)
        Me.txt_toplamtutar.Name = "txt_toplamtutar"
        Me.txt_toplamtutar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_toplamtutar.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.txt_toplamtutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_toplamtutar.Properties.ReadOnly = True
        Me.txt_toplamtutar.Size = New System.Drawing.Size(120, 22)
        Me.txt_toplamtutar.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 124)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 311)
        Me.PanelControl3.TabIndex = 7
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_tur, Me.sec_kabul, Me.sec_fiyat})
        Me.GridControl1.Size = New System.Drawing.Size(818, 305)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem5, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Satýr Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Firma Seç"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Satýr Sil"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Deðer Yay"
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "IND"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "EVRAKNO"
        Me.DataColumn8.DataType = GetType(Long)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "FIRMANO"
        Me.DataColumn9.DataType = GetType(Integer)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "FIRMAKODU"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "FIRMAADI"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "STOKNO"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "STOKKODU"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "MALINCINSI"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "MIKTAR"
        Me.DataColumn15.DataType = GetType(Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "BIRIM"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "FIYAT"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "TUTAR"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "IHTIYACTARIHI"
        Me.DataColumn19.DataType = GetType(Date)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "TUR"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "KABUL"
        Me.DataColumn21.DataType = GetType(Long)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ACIKLAMA"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "BELGEIND"
        Me.DataColumn23.DataType = GetType(Long)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "TERMINTARIHI"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colEVRAKNO, Me.colFIRMANO, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colMIKTAR, Me.colBIRIM, Me.colFIYAT, Me.colTUTAR, Me.colIHTIYACTARIHI, Me.colTUR, Me.colKABUL, Me.colACIKLAMA, Me.colBELGEIND, Me.colTERMINTARIHI})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(653, 297, 208, 170)
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
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
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
        'colEVRAKNO
        '
        Me.colEVRAKNO.Caption = "Evrak No"
        Me.colEVRAKNO.FieldName = "EVRAKNO"
        Me.colEVRAKNO.Name = "colEVRAKNO"
        Me.colEVRAKNO.OptionsColumn.AllowEdit = False
        '
        'colFIRMANO
        '
        Me.colFIRMANO.Caption = "Firma No"
        Me.colFIRMANO.FieldName = "FIRMANO"
        Me.colFIRMANO.Name = "colFIRMANO"
        Me.colFIRMANO.OptionsColumn.AllowEdit = False
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Firma Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.OptionsColumn.AllowEdit = False
        Me.colFIRMAKODU.SummaryItem.DisplayFormat = "{0}"
        Me.colFIRMAKODU.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 0
        Me.colFIRMAKODU.Width = 76
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Firma Adý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 1
        Me.colFIRMAADI.Width = 132
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
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 2
        Me.colSTOKKODU.Width = 74
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 3
        Me.colMALINCINSI.Width = 152
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.####"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.colMIKTAR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 4
        Me.colMIKTAR.Width = 57
        '
        'colBIRIM
        '
        Me.colBIRIM.Caption = "Birim"
        Me.colBIRIM.FieldName = "BIRIM"
        Me.colBIRIM.Name = "colBIRIM"
        Me.colBIRIM.Visible = True
        Me.colBIRIM.VisibleIndex = 5
        Me.colBIRIM.Width = 57
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT.FieldName = "FIYAT"
        Me.colFIYAT.Name = "colFIYAT"
        Me.colFIYAT.Visible = True
        Me.colFIYAT.VisibleIndex = 6
        Me.colFIYAT.Width = 57
        '
        'sec_fiyat
        '
        Me.sec_fiyat.AutoHeight = False
        Me.sec_fiyat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.sec_fiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat.EditFormat.FormatString = "#,0.00##"
        Me.sec_fiyat.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat.Name = "sec_fiyat"
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.ColumnEdit = Me.sec_fiyat
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00##"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.SummaryItem.DisplayFormat = "{0:#,0.00##}"
        Me.colTUTAR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 7
        Me.colTUTAR.Width = 57
        '
        'colIHTIYACTARIHI
        '
        Me.colIHTIYACTARIHI.Caption = "ÝhtiyaçTarihi"
        Me.colIHTIYACTARIHI.FieldName = "IHTIYACTARIHI"
        Me.colIHTIYACTARIHI.Name = "colIHTIYACTARIHI"
        Me.colIHTIYACTARIHI.Visible = True
        Me.colIHTIYACTARIHI.VisibleIndex = 8
        Me.colIHTIYACTARIHI.Width = 86
        '
        'colTUR
        '
        Me.colTUR.Caption = "Tür"
        Me.colTUR.ColumnEdit = Me.sec_tur
        Me.colTUR.FieldName = "TUR"
        Me.colTUR.Name = "colTUR"
        Me.colTUR.Visible = True
        Me.colTUR.VisibleIndex = 9
        Me.colTUR.Width = 46
        '
        'sec_tur
        '
        Me.sec_tur.AutoHeight = False
        Me.sec_tur.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tur.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_tur.DataSource = Me.DataTable8
        Me.sec_tur.DisplayMember = "ACIKLAMA"
        Me.sec_tur.Name = "sec_tur"
        Me.sec_tur.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_tur.ShowFooter = False
        Me.sec_tur.ShowHeader = False
        Me.sec_tur.ShowLines = False
        Me.sec_tur.ValueMember = "IND"
        '
        'DataTable8
        '
        Me.DataTable8.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn116, Me.DataColumn117})
        Me.DataTable8.TableName = "Table1"
        '
        'DataColumn116
        '
        Me.DataColumn116.ColumnName = "IND"
        Me.DataColumn116.DataType = GetType(Long)
        '
        'DataColumn117
        '
        Me.DataColumn117.ColumnName = "ACIKLAMA"
        '
        'colKABUL
        '
        Me.colKABUL.Caption = "Sonuç"
        Me.colKABUL.ColumnEdit = Me.sec_kabul
        Me.colKABUL.FieldName = "KABUL"
        Me.colKABUL.Name = "colKABUL"
        Me.colKABUL.Visible = True
        Me.colKABUL.VisibleIndex = 10
        Me.colKABUL.Width = 55
        '
        'sec_kabul
        '
        Me.sec_kabul.AutoHeight = False
        Me.sec_kabul.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kabul.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_kabul.DataSource = Me.DataTable3
        Me.sec_kabul.DisplayMember = "ACIKLAMA"
        Me.sec_kabul.Name = "sec_kabul"
        Me.sec_kabul.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_kabul.ShowFooter = False
        Me.sec_kabul.ShowHeader = False
        Me.sec_kabul.ShowLines = False
        Me.sec_kabul.ValueMember = "IND"
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "IND"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "ACIKLAMA"
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        '
        'colBELGEIND
        '
        Me.colBELGEIND.Caption = "BelgeKayýtNo"
        Me.colBELGEIND.FieldName = "BELGEIND"
        Me.colBELGEIND.Name = "colBELGEIND"
        Me.colBELGEIND.OptionsColumn.AllowEdit = False
        '
        'colTERMINTARIHI
        '
        Me.colTERMINTARIHI.Caption = "Termin"
        Me.colTERMINTARIHI.FieldName = "TERMINTARIHI"
        Me.colTERMINTARIHI.Name = "colTERMINTARIHI"
        Me.colTERMINTARIHI.Width = 69
        '
        'Timer1
        '
        '
        'ds_girdi_tur
        '
        Me.ds_girdi_tur.DataSetName = "NewDataSet"
        Me.ds_girdi_tur.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_girdi_tur.Tables.AddRange(New System.Data.DataTable() {Me.DataTable8})
        '
        'ds_kabul
        '
        Me.ds_kabul.DataSetName = "NewDataSet"
        Me.ds_kabul.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kabul.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "SatýnAlma Emirleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "SatýnAlma Ýþlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_uretim_satinalma
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 542)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_uretim_satinalma"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SatýnAlma Emirleri"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txt_toplammiktar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_toplamtutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kabul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_girdi_tur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kabul, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub frm_uretim_satinalma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                dr("BELGENO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
                con.Close()
            Catch ex As Exception
                dr("BELGENO") = "A-000001"
            End Try
            dr("TARIH") = Today
            dr("ACIKLAMA") = ""
            dr("OZELKOD") = ""
            dr("TOPLAM") = 0
            dr("IND") = baslik_kaydet_yeni(dr("BELGENO"), dr("TARIH"), dr("ACIKLAMA"), dr("TOPLAM"), dr("OZELKOD"))
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
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(BELGENO,'A-000001') AS BELGENO FROM TBLURESATINALMALIST WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM TBLURESATINALMALIST  WHERE  BELGENO LIKE 'A%')")
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
        Dim frm As New frm_stok
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        Dim yeni = False
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
                    dr("EVRAKNO") = belgeind
                    dr("FIRMANO") = 0
                    dr("FIRMAKODU") = ""
                    dr("FIRMAADI") = ""
                    dr("STOKNO") = dr1("nStokID")
                    dr("STOKKODU") = dr1("sKodu")
                    dr("MALINCINSI") = dr1("sAciklama")
                    dr("MIKTAR") = 1
                    dr("BIRIM") = dr1("sBirimCinsi1")
                    dr("FIYAT") = sorgu_sayi(dr1("ALISFIYATI"), 0)
                    dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
                    dr("IHTIYACTARIHI") = Today
                    dr("TUR") = 0
                    dr("KABUL") = "B"
                    dr("ACIKLAMA") = ""
                    dr("BELGEIND") = 0
                    dr("TERMINTARIHI") = Today
                    dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("FIRMANO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("FIYAT"), dr("IHTIYACTARIHI"), dr("TUR"), dr("KABUL"), dr("ACIKLAMA"), dr("BELGEIND"), dr("TERMINTARIHI"))
                    ds_hareket.Tables(0).Rows.Add(dr)
                    dr1 = Nothing
                    yeni = frm.yeni
                Next
            End If
        Else
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.SimpleButton1 = Nothing
        frm.SimpleButton2 = Nothing
        'frm.PanelControl1.Dispose()
        'frm.PanelControl1 = Nothing
        'frm.PanelControl2.Dispose()
        'frm.PanelControl2 = Nothing
        'frm.PanelControl3.Dispose()
        'frm.PanelControl3 = Nothing
        frm.PictureBox1.Dispose()
        frm.PictureBox1 = Nothing
        frm.GridControl1.Dispose()
        frm.GridControl1 = Nothing
        frm.GridView1.Dispose()
        frm.GridView1 = Nothing
        frm.XtraTabControl1.Dispose()
        frm.XtraTabControl1 = Nothing
        frm.XtraTabPage1.Dispose()
        frm.XtraTabPage1 = Nothing
        frm.Label1.Dispose()
        frm.Label1 = Nothing
        frm.Label2.Dispose()
        frm.Label2 = Nothing
        frm.Close()
        frm.Dispose()
        frm = Nothing
        If yeni = True Then
            satir_ekle_girdi()
        End If
        yeni = Nothing
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
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
    Private Sub satir_duzelt_hareket()
        Dim frm As New frm_firma_liste
        dr = ds_baslik.Tables(0).Rows(0)
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        If frm.ShowDialog() = DialogResult.OK Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("FIRMANO") = dr1("nFirmaID")
            dr("FIRMAKODU") = dr1("sKodu")
            dr("FIRMAADI") = dr1("sAciklama")
            dr1 = Nothing
            hareket_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("FIRMANO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("FIYAT"), dr("IHTIYACTARIHI"), dr("TUR"), dr("KABUL"), dr("ACIKLAMA"), dr("BELGEIND"), dr("TERMINTARIHI"))
        End If
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         TBLURESATINALMALIST WHERE IND =" & belgeind & "")
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,MIKTAR*FIYAT AS TUTAR FROM         TBLURESATINALMA WHERE EVRAKNO =" & belgeind & "")
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
        girdi_turleri()
        kabul_turleri()
        GridControl1.Focus()
        GridControl1.Select()
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        Timer1.Enabled = True
        txt_aciklama.EditValue = dr_baslik("ACIKLAMA")
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\SATINALMA\HAREKET\" & Me.Name.ToString & "")
        Vgrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\SATINALMA\BASLIK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\SATINALMA\HAREKET\" & Me.Name.ToString & "")
        'Vgrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\SATINALMA\BASLIK\" & Me.Name.ToString & "")
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
        Vgrid_baslik.DataSource = ds_baslik
        Vgrid_baslik.DataMember = "BASLIK"
        Vgrid_baslik.Refresh()
    End Sub
    Private Sub dataload_hareket()
        ds_hareket = sorgu_hareket("")
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        GridControl1.Select()
    End Sub
    Private Sub girdi_turleri()
        Dim dr1 As DataRow = ds_girdi_tur.Tables(0).NewRow
        dr1("IND") = 0
        dr1("ACIKLAMA") = "Satýn Al"
        ds_girdi_tur.Tables(0).Rows.Add(dr1)
        dr1 = ds_girdi_tur.Tables(0).NewRow
        dr1("IND") = 1
        dr1("ACIKLAMA") = "Üret"
        ds_girdi_tur.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub kabul_turleri()
        Dim dr1 As DataRow = ds_kabul.Tables(0).NewRow
        dr1("IND") = "B"
        dr1("ACIKLAMA") = "Bekliyor"
        ds_kabul.Tables(0).Rows.Add(dr1)
        dr1 = ds_kabul.Tables(0).NewRow
        dr1("IND") = "K"
        dr1("ACIKLAMA") = "Kabul Edildi"
        ds_kabul.Tables(0).Rows.Add(dr1)
        dr1 = ds_kabul.Tables(0).NewRow
        dr1("IND") = "R"
        dr1("ACIKLAMA") = "Red Edildi"
        ds_kabul.Tables(0).Rows.Add(dr1)
        dr1 = ds_kabul.Tables(0).NewRow
        dr1("IND") = "G"
        dr1("ACIKLAMA") = "Gerçekleþti"
        ds_kabul.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub alttoplam_hesapla()
        Dim miktar As Decimal = 0
        Dim tutar As Decimal = 0
        Dim dr As DataRow
        For Each dr In ds_hareket.Tables(0).Rows
            miktar = miktar + dr("MIKTAR")
            tutar = tutar + dr("TUTAR")
        Next
        'dr_baslik("TOPLAM") = tutar
        'Label1.Text = "Satýr : " & FormatNumber(GridView1.FocusedRowHandle + 1, 0) & " / " & GridView1.RowCount & " ,Toplam Miktar : [ " & FormatNumber(miktar, 2) & " ]"
        colFIRMAKODU.SummaryItem.DisplayFormat = "Satýr : " & FormatNumber(GridView1.FocusedRowHandle + 1, 0) & " / " & GridView1.RowCount & ""
        txt_toplammiktar.EditValue = miktar
        txt_toplamtutar.EditValue = tutar
        miktar = Nothing
    End Sub
    Private Sub girdi_tutar_hesapla()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            If dr("MIKTAR") = 0 Then
                dr("MIKTAR") = 1
            End If
            If GridView1.FocusedColumn.Name.ToString = colTUTAR.Name.ToString Then
                dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
            Else
                dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            End If
            dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("FIRMANO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("FIYAT"), dr("IHTIYACTARIHI"), dr("TUR"), dr("KABUL"), dr("ACIKLAMA"), dr("BELGEIND"), dr("TERMINTARIHI"))
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
    Private Function baslik_kaydet_yeni(ByVal BELGENO As String, ByVal TARIH As DateTime, ByVal ACIKLAMA As String, ByVal TOPLAM As Decimal, ByVal OZELKOD As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLURESATINALMALIST (BELGENO, TARIH, ACIKLAMA, TOPLAM, OZELKOD) VALUES     ('" & BELGENO & "', '" & TARIH & "', '" & ACIKLAMA & "', " & TOPLAM & ", '" & OZELKOD & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub baslik_kaydet_degistir(ByVal ind As Int64, ByVal BELGENO As String, ByVal TARIH As DateTime, ByVal ACIKLAMA As String, ByVal TOPLAM As Decimal, ByVal OZELKOD As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLURESATINALMALIST SET BELGENO = '" & BELGENO & "', TARIH = '" & TARIH & "', ACIKLAMA = '" & ACIKLAMA & "', TOPLAM = " & TOPLAM & ", OZELKOD = '" & OZELKOD & "' WHERE IND  =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub baslik_kaydet_sil(ByVal ind As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM TBLURESATINALMALIST WHERE IND  =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal FIYAT As Decimal, ByVal IHTIYACTARIHI As DateTime, ByVal TUR As Int64, ByVal KABUL As String, ByVal ACIKLAMA As String, ByVal BELGEIND As Int64, ByVal TERMINTARIHI As DateTime) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLURESATINALMA (EVRAKNO, FIRMANO, FIRMAKODU, FIRMAADI, STOKNO, STOKKODU, MALINCINSI, MIKTAR, BIRIM, FIYAT, IHTIYACTARIHI, TUR, KABUL, ACIKLAMA,BELGEIND, TERMINTARIHI) VALUES     (" & EVRAKNO & ", " & FIRMANO & ", '" & FIRMAKODU & "', '" & FIRMAADI & "', " & STOKNO & ",'" & STOKKODU & "', '" & MALINCINSI & "', " & MIKTAR & ", '" & BIRIM & "', " & FIYAT & ", '" & IHTIYACTARIHI & "', " & TUR & ", '" & KABUL & "', '" & ACIKLAMA & "'," & BELGEIND & ", '" & TERMINTARIHI & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal FIYAT As Decimal, ByVal IHTIYACTARIHI As DateTime, ByVal TUR As Int64, ByVal KABUL As String, ByVal ACIKLAMA As String, ByVal BELGEIND As Int64, ByVal TERMINTARIHI As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    TBLURESATINALMA SET              EVRAKNO = " & EVRAKNO & ", FIRMANO = " & FIRMANO & " , FIRMAKODU = '" & FIRMAKODU & "', FIRMAADI = '" & FIRMAADI & "', STOKNO = " & STOKNO & ", STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "', MIKTAR = " & MIKTAR & " , BIRIM = '" & BIRIM & "', FIYAT = " & FIYAT & " , IHTIYACTARIHI = '" & IHTIYACTARIHI & "' , TUR = " & TUR & " , KABUL = '" & KABUL & "' , ACIKLAMA = '" & ACIKLAMA & "', BELGEIND = " & BELGEIND & " , TERMINTARIHI = '" & TERMINTARIHI & "' WHERE  IND = " & ind & " AND EVRAKNO =" & EVRAKNO & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_sil(ByVal ind As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLURESATINALMA  WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub belge_iptal(ByVal evrakno As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'Plan Baþlýk
        cmd.CommandText = sorgu_query("DELETE FROM TBLURESATINALMALIST WHERE IND =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Plan Hareket
        cmd.CommandText = sorgu_query("DELETE FROM TBLURESATINALMA WHERE EVRAKNO =" & evrakno & "")
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
    Private Sub ekran_full()
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ekran_full()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            alttoplam_hesapla()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle_girdi()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Girdi Kaydýný Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                hareket_kaydet_sil(dr("IND"))
                ds_hareket.Tables(0).Rows.Remove(dr)
            End If
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Kapatmak Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        satir_duzelt_hareket()
    End Sub
    Private Sub frm_uretim_satinalma_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If GridView1.RowCount = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..! " & vbCrLf & "Satýn Alma Emrini Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                belge_iptal(belgeind)
                Me.Close()
            End If
        ElseIf GridView1.RowCount > 0 Then
            Try
                Timer1.Enabled = False
                alttoplam_hesapla()
                baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("BELGENO"), dr_baslik("TARIH"), txt_aciklama.EditValue, txt_toplamtutar.EditValue, dr_baslik("OZELKOD"))
                Timer1.Enabled = True
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub Vgrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles Vgrid_baslik.CellValueChanged
        Try
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
            Timer1.Enabled = False
            alttoplam_hesapla()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("BELGENO"), dr_baslik("TARIH"), txt_aciklama.EditValue, txt_toplamtutar.EditValue, dr_baslik("OZELKOD"))
            Timer1.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_aciklama_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_aciklama.EditValueChanged
        Try
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
            Timer1.Enabled = False
            alttoplam_hesapla()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("BELGENO"), dr_baslik("TARIH"), txt_aciklama.EditValue, txt_toplamtutar.EditValue, dr_baslik("OZELKOD"))
            Timer1.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("BELGENO") & vbCrLf & "ÖzelKod :" & vbTab & dr_baslik("OZELKOD") & vbCrLf & "Açýklama :" & vbTab & txt_aciklama.EditValue & vbCrLf & "Toplam :" & vbTab & FormatNumber(txt_toplamtutar.EditValue, 2), "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "SatýnAlma Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewFormEx.ShowDialog()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        'Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("BELGENO") & vbCrLf & "ÖzelKod :" & vbTab & dr_baslik("OZELKOD") & vbCrLf & "Açýklama :" & vbTab & txt_aciklama.EditValue & vbCrLf & "Toplam :" & vbTab & FormatNumber(txt_toplamtutar.EditValue, 2), "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "SatýnAlma Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("BELGENO") & vbCrLf & "ÖzelKod :" & vbTab & dr_baslik("OZELKOD") & vbCrLf & "Açýklama :" & vbTab & txt_aciklama.EditValue & vbCrLf & "ToplamTutar :" & vbTab & FormatNumber(txt_toplamtutar.EditValue, 2), "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "SatýnAlma Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PrintDlg()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"Tarih : " & vbTab & dr_baslik("TARIH") & vbCrLf & "BelgeNo :" & vbTab & dr_baslik("BELGENO") & vbCrLf & "ÖzelKod :" & vbTab & dr_baslik("OZELKOD") & vbCrLf & "Açýklama :" & vbTab & txt_aciklama.EditValue & vbCrLf & "Toplam :" & vbTab & FormatNumber(txt_toplamtutar.EditValue, 2), "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "SatýnAlma Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PageSetup()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("SatýnAlma Emri Kaydýný Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            belge_iptal(belgeind)
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Vgrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        satir_ekle_girdi()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
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
