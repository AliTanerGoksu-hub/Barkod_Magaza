Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_liste_hareket
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_magaza As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents ds_kasa As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents ds_kasiyer As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents ds_harekettipi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents ds_fistipi As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_kasakasiyer As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_harekettipi As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_fistipi As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kasatipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ContextMenu2 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_liste_hareket))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_ozet = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_satici = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara_stok = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_kasatipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_fistipi = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_harekettipi = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_kasakasiyer = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_detayli = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_dahil = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collGiren = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikisTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisVerisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHesapKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHesapAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnISK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnISK2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnISK3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnISK4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAciklama5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikisFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFiyati = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.ds_magaza = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.ds_kasa = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.ds_kasiyer = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.ds_harekettipi = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.ds_fistipi = New System.Data.DataSet()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_ozet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasatipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_harekettipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasakasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_detayli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_dahil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kasiyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_harekettipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_fistipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'collMevcut
        '
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,0.####"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        Me.collMevcut.Visible = True
        Me.collMevcut.VisibleIndex = 9
        Me.collMevcut.Width = 82
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 136)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_ozet)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.sec_satici)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_konum_stok)
        Me.GroupControl1.Controls.Add(Me.sec_kriter_stok)
        Me.GroupControl1.Controls.Add(Me.txt_ara_stok)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sec_kasatipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.sec_fistipi)
        Me.GroupControl1.Controls.Add(Me.sec_harekettipi)
        Me.GroupControl1.Controls.Add(Me.sec_kasakasiyer)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_detayli)
        Me.GroupControl1.Controls.Add(Me.sec_dahil)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(720, 132)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_ozet
        '
        Me.sec_ozet.Location = New System.Drawing.Point(405, 82)
        Me.sec_ozet.Name = "sec_ozet"
        Me.sec_ozet.Properties.Caption = "Özet"
        Me.sec_ozet.Size = New System.Drawing.Size(75, 19)
        Me.sec_ozet.TabIndex = 54
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(360, 62)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl10.TabIndex = 51
        Me.LabelControl10.Text = "Satýcý:"
        '
        'sec_satici
        '
        Me.sec_satici.EditValue = "[Tümü]"
        Me.sec_satici.EnterMoveNextControl = True
        Me.sec_satici.Location = New System.Drawing.Point(407, 59)
        Me.sec_satici.Name = "sec_satici"
        Me.sec_satici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satici.Properties.ShowPopupCloseButton = False
        Me.sec_satici.Size = New System.Drawing.Size(272, 20)
        Me.sec_satici.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(361, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Stoklar:"
        '
        'sec_konum_stok
        '
        Me.sec_konum_stok.EditValue = "Kod"
        Me.sec_konum_stok.EnterMoveNextControl = True
        Me.sec_konum_stok.Location = New System.Drawing.Point(524, 21)
        Me.sec_konum_stok.Name = "sec_konum_stok"
        Me.sec_konum_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum_stok.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum_stok.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum_stok.TabIndex = 43
        '
        'sec_kriter_stok
        '
        Me.sec_kriter_stok.EditValue = "Baþlar"
        Me.sec_kriter_stok.EnterMoveNextControl = True
        Me.sec_kriter_stok.Location = New System.Drawing.Point(615, 21)
        Me.sec_kriter_stok.Name = "sec_kriter_stok"
        Me.sec_kriter_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_stok.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter_stok.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter_stok.TabIndex = 44
        '
        'txt_ara_stok
        '
        Me.txt_ara_stok.EnterMoveNextControl = True
        Me.txt_ara_stok.Location = New System.Drawing.Point(407, 21)
        Me.txt_ara_stok.Name = "txt_ara_stok"
        Me.txt_ara_stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara_stok.Properties.Appearance.Options.UseFont = True
        Me.txt_ara_stok.Properties.MaxLength = 15
        Me.txt_ara_stok.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara_stok.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(351, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Hesaplar:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(524, 40)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 46
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(615, 40)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 47
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(407, 40)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 45
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(304, 78)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl9.TabIndex = 25
        Me.LabelControl9.Text = "Ýçerir"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(304, 59)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Ýçerir"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(304, 40)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "Ýçerir"
        '
        'sec_kasatipi
        '
        Me.sec_kasatipi.EditValue = "Kasiyer:"
        Me.sec_kasatipi.EnterMoveNextControl = True
        Me.sec_kasatipi.Location = New System.Drawing.Point(5, 59)
        Me.sec_kasatipi.Name = "sec_kasatipi"
        Me.sec_kasatipi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_kasatipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_kasatipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasatipi.Properties.Items.AddRange(New Object() {"Kasiyer:", "Kasa:"})
        Me.sec_kasatipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kasatipi.Size = New System.Drawing.Size(67, 20)
        Me.sec_kasatipi.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(7, 80)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "Ht:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(7, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Maðaza:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(165, 80)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Fiþler:"
        '
        'sec_fistipi
        '
        Me.sec_fistipi.EditValue = "[Tümü]"
        Me.sec_fistipi.EnterMoveNextControl = True
        Me.sec_fistipi.Location = New System.Drawing.Point(202, 78)
        Me.sec_fistipi.Name = "sec_fistipi"
        Me.sec_fistipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fistipi.Properties.PopupControl = Me.sec_grid
        Me.sec_fistipi.Properties.ShowPopupCloseButton = False
        Me.sec_fistipi.Size = New System.Drawing.Size(100, 20)
        Me.sec_fistipi.TabIndex = 6
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(144, 24)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 1
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextMenu2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(232, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenu2
        '
        Me.ContextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18})
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Tümünü Seç"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "Tümünü Kaldýr"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colSEC
        '
        Me.colSEC.Caption = "Seçim"
        Me.colSEC.FieldName = "SEC"
        Me.colSEC.Name = "colSEC"
        Me.colSEC.Visible = True
        Me.colSEC.VisibleIndex = 0
        Me.colSEC.Width = 48
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kod"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.OptionsColumn.AllowFocus = False
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 1
        Me.colKOD.Width = 52
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.OptionsColumn.AllowFocus = False
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        Me.colACIKLAMA.Width = 128
        '
        'sec_harekettipi
        '
        Me.sec_harekettipi.EditValue = "[Tümü]"
        Me.sec_harekettipi.EnterMoveNextControl = True
        Me.sec_harekettipi.Location = New System.Drawing.Point(72, 78)
        Me.sec_harekettipi.Name = "sec_harekettipi"
        Me.sec_harekettipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_harekettipi.Properties.ShowPopupCloseButton = False
        Me.sec_harekettipi.Size = New System.Drawing.Size(88, 20)
        Me.sec_harekettipi.TabIndex = 5
        '
        'sec_kasakasiyer
        '
        Me.sec_kasakasiyer.EditValue = "[Tümü]"
        Me.sec_kasakasiyer.EnterMoveNextControl = True
        Me.sec_kasakasiyer.Location = New System.Drawing.Point(72, 59)
        Me.sec_kasakasiyer.Name = "sec_kasakasiyer"
        Me.sec_kasakasiyer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasakasiyer.Properties.ShowPopupCloseButton = False
        Me.sec_kasakasiyer.Size = New System.Drawing.Size(230, 20)
        Me.sec_kasakasiyer.TabIndex = 4
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(72, 40)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(230, 20)
        Me.sec_depo.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(304, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Arasýndaki"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(168, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "ve"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(7, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 6, 16, 19, 41, 57, 199)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(202, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2007, 6, 16, 19, 41, 51, 511)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(72, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(88, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(72, 101)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(609, 20)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_detayli
        '
        Me.sec_detayli.Location = New System.Drawing.Point(604, 82)
        Me.sec_detayli.Name = "sec_detayli"
        Me.sec_detayli.Properties.Caption = "Detayli"
        Me.sec_detayli.Size = New System.Drawing.Size(75, 19)
        Me.sec_detayli.TabIndex = 53
        '
        'sec_dahil
        '
        Me.sec_dahil.Location = New System.Drawing.Point(504, 82)
        Me.sec_dahil.Name = "sec_dahil"
        Me.sec_dahil.Properties.Caption = "KdvDahil"
        Me.sec_dahil.Size = New System.Drawing.Size(75, 19)
        Me.sec_dahil.TabIndex = 52
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(816, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(6, 11)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "*"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 136)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 223)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 219)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem25, Me.MenuItem15, Me.MenuItem16, Me.MenuItem19, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem26, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem25
        '
        Me.MenuItem25.Enabled = False
        Me.MenuItem25.Index = 2
        Me.MenuItem25.Text = "Fisi Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem21.Text = "Stok Kartý"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 7
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem22.Text = "Stok Hareketleri"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 8
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem23.Text = "Envanter"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 9
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem24.Text = "Stok Fiyatlandýr"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 10
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 11
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 12
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 13
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 14
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 16
        Me.MenuItem26.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 17
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 18
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 19
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 20
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 21
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 22
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 23
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "lGiren"
        Me.DataColumn1.DataType = GetType(Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lGirisTutar"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lCikan"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lCikisTutar"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lKalan"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "lMevcut"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nStokID"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sKodu"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAciklama"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sRenk"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sRenkAdi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sBeden"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sModel"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "SINIF1"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "SINIF2"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "SINIF3"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "SINIF4"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "SINIF5"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "SINIF6"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "SINIF7"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "SINIF8"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "SINIF9"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "SINIF10"
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collGiren, Me.collGirisTutar, Me.collCikan, Me.collCikisTutar, Me.collKalan, Me.collMevcut, Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsModel, Me.colSINIF1, Me.colSINIF2, Me.colSINIF3, Me.colSINIF4, Me.colSINIF5, Me.colSINIF6, Me.colSINIF7, Me.colSINIF8, Me.colSINIF9, Me.colSINIF10, Me.coldteIslemTarihi, Me.colnFirmaID, Me.colnMusteriID, Me.colsFisTipi, Me.coldteFisTarihi, Me.collFisNo, Me.colnGirisCikis, Me.colsDepo, Me.colsFiyatTipi, Me.collBrutFiyat, Me.collBrutTutar, Me.colnIskontoYuzdesi, Me.collIskontoTutari, Me.colsHareketTipi, Me.colnStokFisiID, Me.colnAlisVerisID, Me.colnKdvOrani, Me.colsHesapKodu, Me.colsHesapAdi, Me.collKar, Me.collMaliyet, Me.colnISK1, Me.colnISK2, Me.colnISK3, Me.colnISK4, Me.colnAciklama1, Me.colnAciklama2, Me.colnAciklama3, Me.colnAciklama4, Me.colnAciklama5, Me.colnCikisFiyat, Me.colnGirisFiyat, Me.colnStokFiyati})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(494, 332, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.collMevcut
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.collMevcut
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGiren", Nothing, "Giren:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisTutar", Nothing, "GirisTutari:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikan", Nothing, "Cikan:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisTutar", Nothing, "CikisTutari:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", Nothing, "Kalan:{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.colsKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGiren", Me.collGiren, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisTutar", Me.collGirisTutar, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikan", Me.collCikan, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisTutar", Me.collCikisTutar, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", Me.collKalan, "{0:#,0.####}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'collGiren
        '
        Me.collGiren.Caption = "Giren"
        Me.collGiren.DisplayFormat.FormatString = "#,0.####"
        Me.collGiren.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGiren.FieldName = "lGiren"
        Me.collGiren.Name = "collGiren"
        Me.collGiren.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGiren", "{0:#,0.00##}")})
        Me.collGiren.Visible = True
        Me.collGiren.VisibleIndex = 3
        Me.collGiren.Width = 58
        '
        'collGirisTutar
        '
        Me.collGirisTutar.Caption = "Giriþ Tutarý"
        Me.collGirisTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisTutar.FieldName = "lGirisTutar"
        Me.collGirisTutar.Name = "collGirisTutar"
        Me.collGirisTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisTutar", "{0:#,0.00##}")})
        Me.collGirisTutar.Visible = True
        Me.collGirisTutar.VisibleIndex = 4
        Me.collGirisTutar.Width = 58
        '
        'collCikan
        '
        Me.collCikan.Caption = "Çýkan"
        Me.collCikan.DisplayFormat.FormatString = "#,0.####"
        Me.collCikan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikan.FieldName = "lCikan"
        Me.collCikan.Name = "collCikan"
        Me.collCikan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikan", "{0:#,0.00##}")})
        Me.collCikan.Visible = True
        Me.collCikan.VisibleIndex = 5
        Me.collCikan.Width = 58
        '
        'collCikisTutar
        '
        Me.collCikisTutar.Caption = "Çýkýþ Tutarý"
        Me.collCikisTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collCikisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikisTutar.FieldName = "lCikisTutar"
        Me.collCikisTutar.Name = "collCikisTutar"
        Me.collCikisTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisTutar", "{0:#,0.00##}")})
        Me.collCikisTutar.Visible = True
        Me.collCikisTutar.VisibleIndex = 6
        Me.collCikisTutar.Width = 58
        '
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.####"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.00##}")})
        Me.collKalan.Visible = True
        Me.collKalan.VisibleIndex = 7
        Me.collKalan.Width = 62
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok ID"
        Me.colnStokID.FieldName = "lMevcut"
        Me.colnStokID.Name = "colnStokID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 102
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 183
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk Adý"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 2
        Me.colsRenkAdi.Width = 69
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colSINIF1
        '
        Me.colSINIF1.Caption = "Sýnýf 1"
        Me.colSINIF1.FieldName = "SINIF1"
        Me.colSINIF1.Name = "colSINIF1"
        Me.colSINIF1.Width = 100
        '
        'colSINIF2
        '
        Me.colSINIF2.Caption = "Sýnýf 2"
        Me.colSINIF2.FieldName = "SINIF2"
        Me.colSINIF2.Name = "colSINIF2"
        '
        'colSINIF3
        '
        Me.colSINIF3.Caption = "Sýnýf 3"
        Me.colSINIF3.FieldName = "SINIF3"
        Me.colSINIF3.Name = "colSINIF3"
        '
        'colSINIF4
        '
        Me.colSINIF4.Caption = "Sýnýf 4"
        Me.colSINIF4.FieldName = "SINIF4"
        Me.colSINIF4.Name = "colSINIF4"
        '
        'colSINIF5
        '
        Me.colSINIF5.Caption = "Sýnýf 5"
        Me.colSINIF5.FieldName = "SINIF5"
        Me.colSINIF5.Name = "colSINIF5"
        '
        'colSINIF6
        '
        Me.colSINIF6.Caption = "Sýnýf 6"
        Me.colSINIF6.FieldName = "SINIF6"
        Me.colSINIF6.Name = "colSINIF6"
        '
        'colSINIF7
        '
        Me.colSINIF7.Caption = "Sýnýf 7"
        Me.colSINIF7.FieldName = "SINIF7"
        Me.colSINIF7.Name = "colSINIF7"
        '
        'colSINIF8
        '
        Me.colSINIF8.Caption = "Sýnýf 8"
        Me.colSINIF8.FieldName = "SINIF8"
        Me.colSINIF8.Name = "colSINIF8"
        '
        'colSINIF9
        '
        Me.colSINIF9.Caption = "Sýnýf 9"
        Me.colSINIF9.FieldName = "SINIF9"
        Me.colSINIF9.Name = "colSINIF9"
        '
        'colSINIF10
        '
        Me.colSINIF10.Caption = "Sýnýf 10"
        Me.colSINIF10.FieldName = "SINIF10"
        Me.colSINIF10.Name = "colSINIF10"
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "dteIslemTarihi"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma ID"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müþteri ID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Width = 47
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Fiþ Tarihi"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Width = 53
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Width = 39
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Brüt Fiyat"
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Brüt Tutar"
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "% Ýsk."
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Ýskonto Tutarý"
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "HT"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Stok Fiþi ID"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colnAlisVerisID
        '
        Me.colnAlisVerisID.Caption = "Alýþveriþ ID"
        Me.colnAlisVerisID.FieldName = "nAlisVerisID"
        Me.colnAlisVerisID.Name = "colnAlisVerisID"
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        '
        'colsHesapKodu
        '
        Me.colsHesapKodu.Caption = "Hesap Kodu"
        Me.colsHesapKodu.FieldName = "sHesapKodu"
        Me.colsHesapKodu.Name = "colsHesapKodu"
        '
        'colsHesapAdi
        '
        Me.colsHesapAdi.Caption = "HesapAdý"
        Me.colsHesapAdi.FieldName = "sHesapAdi"
        Me.colsHesapAdi.Name = "colsHesapAdi"
        '
        'collKar
        '
        Me.collKar.Caption = "Kar"
        Me.collKar.DisplayFormat.FormatString = "#,0.00"
        Me.collKar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKar.FieldName = "lKar"
        Me.collKar.Name = "collKar"
        Me.collKar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKar", "{0:#,0.00}")})
        Me.collKar.Visible = True
        Me.collKar.VisibleIndex = 8
        Me.collKar.Width = 86
        '
        'collMaliyet
        '
        Me.collMaliyet.Caption = "Maliyet Fiyatý"
        Me.collMaliyet.DisplayFormat.FormatString = "#,0.00"
        Me.collMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMaliyet.FieldName = "MALIYET"
        Me.collMaliyet.Name = "collMaliyet"
        '
        'colnISK1
        '
        Me.colnISK1.Caption = "ISK1"
        Me.colnISK1.FieldName = "ISK1"
        Me.colnISK1.Name = "colnISK1"
        Me.colnISK1.Visible = True
        Me.colnISK1.VisibleIndex = 10
        '
        'colnISK2
        '
        Me.colnISK2.Caption = "ISK2"
        Me.colnISK2.FieldName = "ISK2"
        Me.colnISK2.Name = "colnISK2"
        Me.colnISK2.Visible = True
        Me.colnISK2.VisibleIndex = 11
        '
        'colnISK3
        '
        Me.colnISK3.Caption = "ISK3"
        Me.colnISK3.FieldName = "ISK3"
        Me.colnISK3.Name = "colnISK3"
        Me.colnISK3.Visible = True
        Me.colnISK3.VisibleIndex = 12
        '
        'colnISK4
        '
        Me.colnISK4.Caption = "ISK4"
        Me.colnISK4.FieldName = "ISK4"
        Me.colnISK4.Name = "colnISK4"
        Me.colnISK4.Visible = True
        Me.colnISK4.VisibleIndex = 13
        '
        'colnAciklama1
        '
        Me.colnAciklama1.Caption = "Açýklama1"
        Me.colnAciklama1.FieldName = "sAciklama1"
        Me.colnAciklama1.Name = "colnAciklama1"
        Me.colnAciklama1.Visible = True
        Me.colnAciklama1.VisibleIndex = 14
        '
        'colnAciklama2
        '
        Me.colnAciklama2.Caption = "Açýklama2"
        Me.colnAciklama2.FieldName = "sAciklama2"
        Me.colnAciklama2.Name = "colnAciklama2"
        Me.colnAciklama2.Visible = True
        Me.colnAciklama2.VisibleIndex = 15
        '
        'colnAciklama3
        '
        Me.colnAciklama3.Caption = "Açýklama3"
        Me.colnAciklama3.FieldName = "sAciklama3"
        Me.colnAciklama3.Name = "colnAciklama3"
        Me.colnAciklama3.Visible = True
        Me.colnAciklama3.VisibleIndex = 16
        '
        'colnAciklama4
        '
        Me.colnAciklama4.Caption = "Açýklama4"
        Me.colnAciklama4.FieldName = "sAciklama4"
        Me.colnAciklama4.Name = "colnAciklama4"
        Me.colnAciklama4.Visible = True
        Me.colnAciklama4.VisibleIndex = 17
        '
        'colnAciklama5
        '
        Me.colnAciklama5.Caption = "Açýklama5"
        Me.colnAciklama5.FieldName = "sAciklama5"
        Me.colnAciklama5.Name = "colnAciklama5"
        Me.colnAciklama5.Visible = True
        Me.colnAciklama5.VisibleIndex = 18
        '
        'colnCikisFiyat
        '
        Me.colnCikisFiyat.Caption = "Çýkýþ Fiyat"
        Me.colnCikisFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.colnCikisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnCikisFiyat.FieldName = "CikisFiyat"
        Me.colnCikisFiyat.Name = "colnCikisFiyat"
        Me.colnCikisFiyat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CikisFiyat", "{0:#,0.00##}")})
        Me.colnCikisFiyat.Visible = True
        Me.colnCikisFiyat.VisibleIndex = 19
        '
        'colnGirisFiyat
        '
        Me.colnGirisFiyat.Caption = "Giriþ Fiyat"
        Me.colnGirisFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.colnGirisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGirisFiyat.FieldName = "GirisFiyat"
        Me.colnGirisFiyat.Name = "colnGirisFiyat"
        Me.colnGirisFiyat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GirisFiyat", "{0:#,0.00##}")})
        Me.colnGirisFiyat.Visible = True
        Me.colnGirisFiyat.VisibleIndex = 20
        '
        'colnStokFiyati
        '
        Me.colnStokFiyati.Caption = "StokFiyatý"
        Me.colnStokFiyati.DisplayFormat.FormatString = "#,0.00##"
        Me.colnStokFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnStokFiyati.FieldName = "StokFiyatý"
        Me.colnStokFiyati.Name = "colnStokFiyati"
        Me.colnStokFiyati.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "StokFiyatý", "{0:#,0.00##}")})
        Me.colnStokFiyati.Visible = True
        Me.colnStokFiyati.VisibleIndex = 21
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
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Firma Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Firma Hesaplarý Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'ds_magaza
        '
        Me.ds_magaza.DataSetName = "NewDataSet"
        Me.ds_magaza.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_magaza.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "SEC"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "KOD"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ACIKLAMA"
        '
        'ds_kasa
        '
        Me.ds_kasa.DataSetName = "NewDataSet"
        Me.ds_kasa.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kasa.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "SEC"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KOD"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ACIKLAMA"
        '
        'ds_kasiyer
        '
        Me.ds_kasiyer.DataSetName = "NewDataSet"
        Me.ds_kasiyer.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kasiyer.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "SEC"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "KOD"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ACIKLAMA"
        '
        'ds_harekettipi
        '
        Me.ds_harekettipi.DataSetName = "NewDataSet"
        Me.ds_harekettipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_harekettipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "SEC"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "KOD"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "ACIKLAMA"
        '
        'ds_fistipi
        '
        Me.ds_fistipi.DataSetName = "NewDataSet"
        Me.ds_fistipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_fistipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "SEC"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "KOD"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "ACIKLAMA"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Stok Kartý"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Envanter"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Stok Hareketleri"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Firma Kartý"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Firma Hareketleri"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Ýletiþim"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Excel"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Text"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Mail"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'frm_stok_liste_hareket
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_liste_hareket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Hareketleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_ozet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasatipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_harekettipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasakasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_detayli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_dahil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kasiyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_harekettipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_fistipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public islemstatus As Boolean = False
    Dim ds1 As DataSet
    Dim nakit As Decimal = 0
    Dim masraf As Decimal = 0
    Dim ds_satici As DataSet
    Dim firmatipi As Boolean = False
    Public islem As String = "Ekstre"
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        If txt_ara.EditValue <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        txt_ara_stok.EditValue = ""
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
        dataload_depo()
        Me.Text += "#" & islem
        If islem = "Girisler" Then
            collCikan.Visible = False
            collCikan.OptionsColumn.ShowInCustomizationForm = False
            collCikisTutar.Visible = False
            collCikisTutar.OptionsColumn.ShowInCustomizationForm = False
            collKalan.Visible = False
            collKalan.OptionsColumn.ShowInCustomizationForm = False
        ElseIf islem = "Cikislar" Then
            collGiren.Visible = False
            collGiren.OptionsColumn.ShowInCustomizationForm = False
            collGirisTutar.Visible = False
            collGirisTutar.OptionsColumn.ShowInCustomizationForm = False
            collKalan.Visible = False
            collKalan.OptionsColumn.ShowInCustomizationForm = False
        End If
    End Sub
    Private Sub dataload_depo()
        ds_magaza = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        ds_kasiyer = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sKasiyerRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM tbKasiyer WHERE (sKasiyerRumuzu <> '') ORDER BY sAdi"))
        ds_kasa = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, nKasaNo AS KOD, sAciklama AS ACIKLAMA FROM tbParekendeKasa"))
        ds_harekettipi = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sHareketTipi AS KOD, sAciklama AS ACIKLAMA FROM tbHareketTipi WHERE (sHareketTipi <> '') and (aktif = 1)"))
        If islem = "Girisler" Then
            ds_fistipi = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sFisTipi AS KOD, sAciklama AS ACIKLAMA FROM tbFisTipi WHERE (bSatismi = 0) "))
        ElseIf islem = "Cikislar" Then
            ds_fistipi = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sFisTipi AS KOD, sAciklama AS ACIKLAMA FROM tbFisTipi WHERE (bSatismi = 1) "))
        ElseIf islem = "Ekstre" Then
            ds_fistipi = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sFisTipi AS KOD, sAciklama AS ACIKLAMA FROM tbFisTipi "))
        End If
        ds_satici = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi+ ' ' + sSoyadi AS ACIKLAMA FROM tbSatici WHERE (sSaticiRumuzu <> '') and bAktif =1"))
    End Sub
    Private Sub dataload_satislar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal satici As String)
        Dim kriter As String = ""
        kriter = " Where tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' and tbStokFisiDetayi.sFisTipi <> 'T' "
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                If firmatipi = False Then
                    kriter += " AND (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                End If
            ElseIf sec_konum.Text = "Adý" Then
                If firmatipi = False Then
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
                End If
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND ((tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "ÝþAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "EvTelefonu" Then
                kriter += " AND (tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "ÝþTelefonu" Then
                kriter += " AND (tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Gsm" Then
                kriter += " AND (tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "DoðumYeri" Then
                kriter += " AND (tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "1.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "2.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Adý+Soyadý" Then
                Dim adi As String = ""
                Dim soyadi As String = ""
                Dim x
                If CStr(ara.ToString) <> "" Then
                    x = (ara).IndexOf(" ", 1, (ara.Length - 1))
                    If x = -1 Then
                        adi = ara
                    Else
                        adi = (ara).Substring(0, x)
                        soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                        If IsNumeric(ara) Then
                        Else
                        End If
                    End If
                End If
                'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
                If adi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
                End If
            Else
            End If
        End If
        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
                'ElseIf konum_stok = "Soyadý" Then
                '   kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Barkod" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID  FROM         tbStok INNER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            End If
        End If
        'kriter = " AND tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND a.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND a.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND tbStokFisiDetayi.sDepo IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter += " AND tbStokFisiDetayi.sHareketTipi IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter += " AND tbStokFisiDetayi.sFisTipi IN ( " & fistipi & " )"
        End If
        If islem = "Girisler" Then
            kriter += " AND tbStokFisiDetayi.lGirisMiktar1 <>0 and tbStokFisiDetayi.lCikisMiktar1=0 "
        ElseIf islem = "Cikislar" Then
            kriter += " AND tbStokFisiDetayi.lCikisMiktar1 <>0 and tbStokFisiDetayi.lGirisMiktar1=0"
        ElseIf islem = "Ekstre" Then
        End If
        If sec_detayli.Checked = True Then
            'coldteIslemTarihi.Visible = True
            'colnFirmaID.Visible = True
            'colnMusteriID.Visible = True
            colsHesapAdi.Visible = True
            colsHesapAdi.VisibleIndex = 0
            coldteFisTarihi.Visible = True
            coldteFisTarihi.VisibleIndex = 1
            colsFisTipi.Visible = True
            colsFisTipi.VisibleIndex = 2
            collFisNo.Visible = True
            collFisNo.VisibleIndex = 3
        ElseIf sec_detayli.Checked = False Then
            colsHesapAdi.Visible = False
            coldteFisTarihi.Visible = False
            colsFisTipi.Visible = False
            collFisNo.Visible = False
        End If
        If sec_dahil.Checked = True Then
            If sec_detayli.Checked = True Then
                'ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.lGirisMiktar1 AS lGiren, (CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, tbStokFisiDetayi.lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lGirisTutar, tbStokFisiDetayi.lCikisMiktar1 AS lCikan, tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lCikisTutar, tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1 AS lKalan, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET,(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) - (tbStokFisiDetayi.lCikisMiktar1) * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lKar, '' AS nOran,tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10, tbStokFisiDetayi.dteIslemTarihi, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 as lBrutFiyat, tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 as lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sHareketTipi, tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nAlisverisID, sHesapKodu = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN CAST(tbMusteri.lKodu AS NVARCHAR(20)) ELSE tbFirma.sKodu END,sHesapAdi = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN tbMusteri.sAdi+ ' ' + tbMusteri.sSoyadi ELSE tbFirma.sAciklama END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID " & kriter & " "))
                ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.lGirisMiktar1 AS lGiren, (CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, tbStokFisiDetayi.lGirisTutar  AS lGirisTutar, tbStokFisiDetayi.lCikisMiktar1 AS lCikan, tbStokFisiDetayi.lCikisTutar AS lCikisTutar, tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1 AS lKalan, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET,(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) - (tbStokFisiDetayi.lCikisMiktar1) * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS lKar, '' AS nOran,tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10, tbStokFisiDetayi.dteIslemTarihi,tbStokFisiAciklamasi.sAciklama1,tbStokFisiAciklamasi.sAciklama2,tbStokFisiAciklamasi.sAciklama3,tbStokFisiAciklamasi.sAciklama4,tbStokFisiAciklamasi.sAciklama5,tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sHareketTipi, tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nAlisverisID, sHesapKodu = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN CAST(tbMusteri.lKodu AS NVARCHAR(20)) ELSE tbFirma.sKodu END, sHesapAdi = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi ELSE tbFirma.sAciklama END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbStokFisiAciklamasi On tbStokFisiDetayi.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID " & kriter & " "))
            Else
                ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lGirisMiktar1) AS lGiren, (CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, SUM(tbStokFisiDetayi.lGirisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lGirisTutar, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lCikan, SUM(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lCikisTutar, SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) AS lKalan, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, SUM(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) - SUM(tbStokFisiDetayi.lCikisMiktar1) * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lKar, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,'' AS nOran,tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID " & kriter & " GROUP BY tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama, tbSSinif2.sAciklama, tbSSinif3.sAciklama, tbSSinif4.sAciklama, tbSSinif5.sAciklama, tbSSinif6.sAciklama, tbSSinif7.sAciklama, tbSSinif8.sAciklama, tbSSinif9.sAciklama, tbSSinif10.sAciklama, tbStokFisiDetayi.sAciklama"))
            End If
        Else
            If sec_detayli.Checked = True Then
                'ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.lGirisMiktar1 AS lGiren, (CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, tbStokFisiDetayi.lGirisTutar  AS lGirisTutar, tbStokFisiDetayi.lCikisMiktar1 AS lCikan, tbStokFisiDetayi.lCikisTutar AS lCikisTutar, tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1 AS lKalan, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET,(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) - (tbStokFisiDetayi.lCikisMiktar1) * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lKar, '' AS nOran,tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10, tbStokFisiDetayi.dteIslemTarihi, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sHareketTipi, tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nAlisverisID, sHesapKodu = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN CAST(tbMusteri.lKodu AS NVARCHAR(20)) ELSE tbFirma.sKodu END, sHesapAdi = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi ELSE tbFirma.sAciklama END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID " & kriter & " "))
                ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.lGirisMiktar1 AS lGiren, (CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, tbStokFisiDetayi.lGirisTutar  AS lGirisTutar, tbStokFisiDetayi.lCikisMiktar1 AS lCikan, tbStokFisiDetayi.lCikisTutar AS lCikisTutar, tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1 AS lKalan, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET,(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) - (tbStokFisiDetayi.lCikisMiktar1) * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS lKar, '' AS nOran,tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10, tbStokFisiDetayi.dteIslemTarihi,tbStokFisiAciklamasi.sAciklama1,tbStokFisiAciklamasi.sAciklama2,tbStokFisiAciklamasi.sAciklama3,tbStokFisiAciklamasi.sAciklama4,tbStokFisiAciklamasi.sAciklama5,tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sHareketTipi, tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nAlisverisID, sHesapKodu = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN CAST(tbMusteri.lKodu AS NVARCHAR(20)) ELSE tbFirma.sKodu END, sHesapAdi = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi ELSE tbFirma.sAciklama END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbStokFisiAciklamasi On tbStokFisiDetayi.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID " & kriter & " "))
            Else
                ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lGirisMiktar1) AS lGiren, (CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, SUM(tbStokFisiDetayi.lGirisTutar) AS lGirisTutar, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lCikan, SUM(tbStokFisiDetayi.lCikisTutar) AS lCikisTutar, SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) AS lKalan, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, SUM(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) - SUM(tbStokFisiDetayi.lCikisMiktar1) * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lKar, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,'' AS nOran,tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID " & kriter & " GROUP BY tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sModel, tbSSinif1.sAciklama, tbSSinif2.sAciklama, tbSSinif3.sAciklama, tbSSinif4.sAciklama, tbSSinif5.sAciklama, tbSSinif6.sAciklama, tbSSinif7.sAciklama, tbSSinif8.sAciklama, tbSSinif9.sAciklama, tbSSinif10.sAciklama, tbStokFisiDetayi.sAciklama"))

            End If
            If sec_ozet.Checked = True Then
                ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CASE WHEN SUM(tbStokFisiDetayi.lGirisMiktar1)<>0 THEN ((SUM(tbStokFisiDetayi.lGirisTutar))/(SUM(tbStokFisiDetayi.lGirisMiktar1))) ELSE 0 END AS GirisFiyat, CASE WHEN SUM(tbStokFisiDetayi.lCikisMiktar1)<>0 THEN ((SUM(tbStokFisiDetayi.lCikisTutar))/(SUM(tbStokFisiDetayi.lCikisMiktar1))) ELSE 0 END AS CikisFiyat, SUM(tbStokFisiDetayi.lGirisMiktar1) AS lGiren,   SUM(tbStokFisiDetayi.lGirisTutar) AS lGirisTutar, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lCikan, SUM(tbStokFisiDetayi.lCikisTutar) AS lCikisTutar, SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) AS lKalan, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '1'), 0) AS StokFiyatý, SUM(tbStokFisiDetayi.lCikisTutar* (100 + tbStokFisiDetayi.nKdvOrani) / 100) - SUM(tbStokFisiDetayi.lCikisMiktar1) * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS lKar,  ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'),0) AS MALIYET,'' AS nOran,tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama  FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID  " & kriter & "  GROUP BY tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama"))
            End If
        End If
       
        'Dim dr As DataRow
        'Dim dr1 As DataRow
        'dr = DataSet1.Tables(0).NewRow
        'dr("Sýnýf") = "Baþlýk"
        'dr("Aciklama") = "AlýþVeriþ Þekli"
        'dr("MIKTAR") = "Adet"
        'dr("IZAHAT") = "BelgeTipi"
        'dr("col1") = "Brüt Satýþ"
        'dr("col2") = "Iskonto"
        'dr("col3") = "VadeFarký"
        'dr("col4") = "KdvMatrahý"
        'dr("col5") = "KdvTutarý"
        'dr("col6") = "NetTutar"
        ''dr("Status") = 0
        'DataSet1.Tables(0).Rows.Add(dr)
        'Dim miktar As Decimal = 0
        'Dim col1 As Decimal = 0
        'Dim col2 As Decimal = 0
        'Dim col3 As Decimal = 0
        'Dim col4 As Decimal = 0
        'Dim col5 As Decimal = 0
        'Dim col6 As Decimal = 0
        'For Each dr1 In ds1.Tables(0).Rows
        '    dr = DataSet1.Tables(0).NewRow
        '    dr("Sýnýf") = "Satýþlar"
        '    dr("Aciklama") = dr1("Aciklama")
        '    dr("MIKTAR") = FormatNumber(dr1("Miktar"), 2)
        '    If dr1("nGirisCikis") = 3 Then
        '        dr("IZAHAT") = "Normal"
        '    ElseIf dr1("nGirisCikis") = 4 Then
        '        dr("IZAHAT") = "Iade"
        '    ElseIf dr1("nGirisCikis") = 0 Then
        '        dr("IZAHAT") = "Toplam"
        '    End If
        '    'dr("IZAHAT") = dr1("nGirisCikis")
        '    dr("col1") = FormatNumber(dr1("Malbedeli"), 2)
        '    dr("col2") = FormatNumber(dr1("IskontoTutari"), 2)
        '    dr("col3") = FormatNumber(dr1("VadeFarki"), 2)
        '    dr("col4") = FormatNumber(dr1("KDVMatrahi"), 2)
        '    dr("col5") = FormatNumber(dr1("KdvTutari"), 2)
        '    dr("col6") = FormatNumber(dr1("NetTutar"), 2)
        '    dr("Status") = 1
        '    DataSet1.Tables(0).Rows.Add(dr)
        '    If dr1("nGirisCikis") <> 0 Then
        '        miktar += dr("MIKTAR")
        '        col1 += CType(dr("col1"), Decimal)
        '        col2 += CType(dr("col2"), Decimal)
        '        col3 += CType(dr("col3"), Decimal)
        '        col4 += CType(dr("col4"), Decimal)
        '        col5 += CType(dr("col5"), Decimal)
        '        col6 += CType(dr("col6"), Decimal)
        '    End If
        'Next
        'dr = DataSet1.Tables(0).NewRow
        'dr("Sýnýf") = "Satýþlar"
        'dr("Aciklama") = "GenelToplam"
        'dr("MIKTAR") = FormatNumber(miktar, 2)
        'dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(col1, 2)
        'dr("col2") = FormatNumber(col2, 2)
        'dr("col3") = FormatNumber(col3, 2)
        'dr("col4") = FormatNumber(col4, 2)
        'dr("col5") = FormatNumber(col5, 2)
        'dr("col6") = FormatNumber(col6, 2)
        'dr("Status") = 0
        'DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_odemesayisi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND b.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(DISTINCT lMakbuzNo) AS Sayi FROM         tbOdeme b WHERE     (nOdemeKodu = 2) " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Ödemeler"
            dr("Aciklama") = "ÖdemeYapanMüþteri"
            dr("MIKTAR") = dr1("Sayi")
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_yenikayitsayisi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS Sayi FROM         tbMusteri a WHERE     (CAST(CONVERT(char(10), dteKayitTarihi, 103) AS smalldatetime) BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Ödemeler"
            dr("Aciklama") = "YeniAçýlanMüþteri"
            dr("MIKTAR") = dr1("Sayi")
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        Next
        nakit = nakit - (masraf)
        dr = DataSet1.Tables(0).NewRow
        'dr("Sýnýf") = "Nakit"
        'dr("Aciklama") = "NakitleriToplamý"
        'dr("MIKTAR") = 0
        'dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        dr("col5") = "NakitKasa"
        dr("col6") = FormatNumber(nakit, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_Odemeler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (b.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND b.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT OdemeSekli, sAciklama1, nOdemeTipi, SUM(Odeme) AS Odeme, sFisTipi, nOdemeKodu, nGirisCikis FROM (SELECT CASE WHEN a.sFisTipi = 'KS' THEN 'Sli' ELSE substring(c.sAciklama , 1 , 3) END AS sAciklama , d.sAciklama AS sAciklama1 , SUM(b.lOdemeTutar) AS Odeme , b.sKasiyerRumuzu , tbKasiyer.sAdi , tbKasiyer.sSoyadi , CASE WHEN a.sFisTipi = 'KS' THEN 'S ' + d.sOdemeSekli ELSE d.sOdemeSekli END AS OdemeSekli , k.nOdemeTipi , b.lOdemeNo , a.sFisTipi , b.sDovizCinsi , k.sAciklama AS Expr2 , b.nOdemeKodu , a.nGirisCikis FROM tbOdemeKodu c INNER JOIN tbOdeme b ON c.nOdemeKodu = b.nOdemeKodu INNER JOIN tbOdemeSekli d ON b.sOdemeSekli = d.sOdemeSekli INNER JOIN tbAlisVeris a ON b.nAlisverisID = a.nAlisverisID INNER JOIN tbKasiyer ON b.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu INNER JOIN tbOdemeTipi k ON d.nOdemeTipi = k.nOdemeTipi INNER JOIN tbFisTipi f ON a.sFisTipi = f.sFisTipi WHERE (a.sFisTipi <> 'KA') " & kriter & " GROUP BY c.sAciklama , b.sKasiyerRumuzu , d.sAciklama , tbKasiyer.sAdi , tbKasiyer.sSoyadi , d.sOdemeSekli , k.nOdemeTipi , b.lOdemeNo , a.sFisTipi , b.sDovizCinsi , k.sAciklama , b.nOdemeKodu , a.nGirisCikis) TT GROUP BY OdemeSekli, sAciklama1, nOdemeTipi, sFisTipi, nOdemeKodu, nGirisCikis ORDER BY OdemeSekli, nGirisCikis, nOdemeKodu"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Status") = 1
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Baþlýk"
        dr("Aciklama") = "ÖdemeÞekli"
        dr("MIKTAR") = ""
        dr("IZAHAT") = "Kod"
        dr("col1") = "KR.Peþinatý"
        dr("col2") = "PeþinSatýþ"
        dr("col3") = "KK.Ödeme"
        dr("col4") = "KR.Iadesi"
        dr("col5") = "PeþinatIadesý"
        dr("col6") = "Toplam"
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        Dim miktar As Decimal = 0
        Dim col1 As Decimal = 0
        Dim col2 As Decimal = 0
        Dim col3 As Decimal = 0
        Dim col4 As Decimal = 0
        Dim col5 As Decimal = 0
        Dim col6 As Decimal = 0
        Dim Odeme As String = ""
        Dim odemeaciklama As String = ""
        'Dim nakit As Decimal = 0
        Dim kredi As Decimal = 0
        Dim kredipesinat As Decimal = 0
        Dim pesinsatis As Decimal = 0
        Dim krediodeme As Decimal = 0
        Dim krediiade As Decimal = 0
        Dim pesinatiade As Decimal = 0
        Dim sayi As Integer = 0
        Dim toplam As Integer = 0
        toplam = ds1.Tables(0).Rows.Count
        Dim top_kredipesinat As Decimal = 0
        Dim top_pesinpesinat As Decimal = 0
        Dim top_krediodeme As Decimal = 0
        Dim top_krediiade As Decimal = 0
        Dim top_pesinatiade As Decimal = 0
        Dim top_toplam As Decimal = 0
        For Each dr1 In ds1.Tables(0).Rows
            sayi += 1
            If sayi > 1 Then
                If Trim(dr1("OdemeSekli")) <> Odeme Then
                    dr = DataSet1.Tables(0).NewRow
                    dr("Sýnýf") = "Ödemeler"
                    dr("Aciklama") = odemeaciklama
                    dr("MIKTAR") = ""
                    dr("IZAHAT") = Odeme
                    dr("col1") = FormatNumber(kredipesinat, 2)
                    dr("col2") = FormatNumber(pesinsatis, 2)
                    dr("col3") = FormatNumber(krediodeme, 2)
                    dr("col4") = FormatNumber(krediiade, 2)
                    dr("col5") = FormatNumber(pesinatiade, 2)
                    dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                    If dr("IZAHAT") = "N" Then
                        nakit = CType(dr("col6"), Decimal)
                    End If
                    dr("Status") = 1
                    top_kredipesinat += CType(dr("col1"), Decimal)
                    top_pesinpesinat += CType(dr("col2"), Decimal)
                    top_krediodeme += CType(dr("col3"), Decimal)
                    top_krediiade += CType(dr("col4"), Decimal)
                    top_pesinatiade += CType(dr("col5"), Decimal)
                    top_toplam += CType(dr("col6"), Decimal)
                    DataSet1.Tables(0).Rows.Add(dr)
                    kredipesinat = 0
                    pesinsatis = 0
                    krediodeme = 0
                    krediiade = 0
                    pesinatiade = 0
                    Odeme = Trim(dr1("OdemeSekli"))
                    odemeaciklama = dr1("sAciklama1")
                End If
            Else
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
            'Nakitleri Toplam
            If dr1("nOdemeTipi") = 1 Then
                If Trim(dr1("OdemeSekli")) = "N" Then
                    'nakit += dr1("Odeme")
                End If
            ElseIf dr1("nOdemeTipi") = 2 Then
                kredi += dr1("Odeme")
            End If
            'Normal Ödemeleri Ayýkla
            If dr1("nGirisCikis") = 3 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Then
                        kredipesinat += dr1("Odeme")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinsatis += dr1("Odeme")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                    krediodeme += dr1("odeme")
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
                'Ýade Ödemeleri Ayýkla
            ElseIf dr1("nGirisCikis") = 4 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Then
                        krediiade += dr1("Odeme")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinatiade += dr1("Odeme")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
            End If
            If sayi = toplam Then
                dr = DataSet1.Tables(0).NewRow
                dr("Sýnýf") = "Ödemeler"
                dr("Aciklama") = odemeaciklama
                dr("MIKTAR") = ""
                dr("IZAHAT") = Odeme
                dr("col1") = FormatNumber(kredipesinat, 2)
                dr("col2") = FormatNumber(pesinsatis, 2)
                dr("col3") = FormatNumber(krediodeme, 2)
                dr("col4") = FormatNumber(krediiade, 2)
                dr("col5") = FormatNumber(pesinatiade, 2)
                dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                If dr("IZAHAT") = "N" Then
                    nakit = CType(dr("col6"), Decimal)
                End If
                dr("Status") = 1
                top_kredipesinat += CType(dr("col1"), Decimal)
                top_pesinpesinat += CType(dr("col2"), Decimal)
                top_krediodeme += CType(dr("col3"), Decimal)
                top_krediiade += CType(dr("col4"), Decimal)
                top_pesinatiade += CType(dr("col5"), Decimal)
                top_toplam += CType(dr("col6"), Decimal)
                DataSet1.Tables(0).Rows.Add(dr)
                kredipesinat = 0
                pesinsatis = 0
                krediodeme = 0
                krediiade = 0
                pesinatiade = 0
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Ödemeler"
        dr("Aciklama") = "ÖdemelerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        dr("col1") = FormatNumber(top_kredipesinat, 2)
        dr("col2") = FormatNumber(top_pesinpesinat, 2)
        dr("col3") = FormatNumber(top_krediodeme, 2)
        dr("col4") = FormatNumber(top_krediiade, 2)
        dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(top_toplam, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Nakit"
        dr("Aciklama") = "NakitlerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(nakit, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        'masraflar 
        dataload_masraflar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
    End Sub
    Private Sub dataload_masraflar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (a.dteMasrafTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND a.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND a.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND a.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select isnull(sum(a.lTutar), 0) as lTutar from tbMagazaMasrafi as a , tbParekendeKasa as b,tbKasiyer Where a.nKasaNo = b.nKasaNo and a.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu  " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        masraf = 0
        For Each dr1 In ds1.Tables(0).Rows
            masraf += dr1("lTutar")
        Next
        Dim lMasraf As Decimal
        If masraf <> 0 Then
            lMasraf = -(masraf)
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Masraf"
            dr("Aciklama") = "MasraflarýnToplamý"
            dr("MIKTAR") = 0
            dr("IZAHAT") = ""
            'dr("col1") = FormatNumber(top_kredipesinat, 2)
            'dr("col2") = FormatNumber(top_pesinpesinat, 2)
            'dr("col3") = FormatNumber(top_krediodeme, 2)
            'dr("col4") = FormatNumber(top_krediiade, 2)
            'dr("col5") = FormatNumber(top_pesinatiade, 2)
            dr("col6") = FormatNumber(lMasraf, 2)
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        End If
        dr = Nothing
        dr1 = Nothing
        lMasraf = Nothing
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        adapter = Nothing
        cmd = Nothing
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Hareket Raporu " & vbCrLf
        kriter += "Maðazalar:" & sec_depo.Text & sec_kasatipi.Text & " " & sec_kasakasiyer.Text & " HareketTipi: " & sec_harekettipi.Text & " FiþTipi: " & sec_fistipi.Text & "Satici: " & sec_satici.Text
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Financial Managment-Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eþittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim kriter As String = ""
        'If sec_konum.Text = "Kodu" Then
        '    kriter += " WHERE ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Adý" Then
        '    kriter += " WHERE ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Ýstihbarat" Then
        '    kriter += " WHERE (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Adres" Then
        '    kriter += " WHERE ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf1" Then
        '    kriter += " WHERE (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf2" Then
        '    kriter += " WHERE (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf3" Then
        '    kriter += " WHERE (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf4" Then
        '    kriter += " WHERE (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf5" Then
        '    kriter += " WHERE (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Adý+Soyadý" Then
        '    Dim adi As String = ""
        '    Dim soyadi As String = ""
        '    Dim x
        '    If CStr(ara.ToString) <> "" Then
        '        x = (ara).IndexOf(" ", 1, (ara.Length - 1))
        '        If x = -1 Then
        '            adi = ara
        '        Else
        '            adi = (ara).Substring(0, x)
        '            soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
        '            If IsNumeric(ara) Then
        '            Else
        '            End If
        '        End If
        '    End If
        '    'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
        '    If adi.ToString <> "" Then
        '        kriter += " WHERE ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
        '    End If
        '    If soyadi.ToString <> "" Then
        '        kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
        '    End If
        'Else
        'End If
        kriter += " AND tbFirma.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5 FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal satici As String)
        DataSet1.Clear()
        dataload_satislar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, satici)
        GridControl1.DataSource = ds1.Tables(0)
        GridControl1.DataMember = Nothing
        'dataload_Odemeler(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
        'dataload_odemesayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
        'dataload_yenikayitsayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
        'GridControl1.DataSource = DataSet1.Tables(0)
        'GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub stok_satis_detay()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nAlisverisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nMusteriID") > 0 Then
                Dim frm As New frm_musteri_karti
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.musterino = dr("sHesapKodu")
                frm.musteriID = dr("nMusteriID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            Else
                Dim frm As New frm_firma_kart
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.sKodu = dr("sHesapKodu")
                frm.nFirmaID = dr("nFirmaID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "[Tümü]"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.BeginEdit()
            dr.EndEdit()
            GridControl2.Focus()
            GridControl2.Select()
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text, sec_kasatipi.Text, sec_kasakasiyer.Text, sec_harekettipi.Text, sec_fistipi.Text, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_satici.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                'lbl_istihbarat.Text = dr("ISTIHBARAT").ToString
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                If GridView1.RowCount > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        sec_satici.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_fistipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_fistipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = sec_grid
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        sec_satici.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_fistipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_kasakasiyer_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_kasakasiyer.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = sec_grid
        sec_depo.Properties.PopupControl = Nothing
        sec_satici.Properties.PopupControl = Nothing
        If sec_kasatipi.Text = "Kasa:" Then
            GridControl2.DataSource = ds_kasa.Tables(0)
        ElseIf sec_kasatipi.Text = "Kasiyer:" Then
            GridControl2.DataSource = ds_kasiyer.Tables(0)
        End If
        'GridControl2.DataSource = ds_kasiyer.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_harekettipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_harekettipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = sec_grid
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        sec_satici.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_harekettipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        'If s.ToString <> "" Then
        '    e.Value = s.ToString
        'Else
        '    e.Value = "[Tümü]"
        'End If
        Return s.ToString
    End Function
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
    End Sub
    Private Sub sec_fistipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_fistipi.QueryResultValue
        Dim s As String = deger(ds_fistipi)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_harekettipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_harekettipi.QueryResultValue
        Dim s As String = deger(ds_harekettipi)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_kasakasiyer_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_kasakasiyer.QueryResultValue
        Dim s As String = ""
        If sec_kasatipi.Text = "Kasa:" Then
            s = deger(ds_kasa)
        ElseIf sec_kasatipi.Text = "Kasiyer:" Then
            s = deger(ds_kasiyer)
        End If
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
    End Sub
    Private Sub sec_depo_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryCloseUp
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.F4 Then
            ClosePopup()
        ElseIf e.KeyCode = Keys.Escape Then
            ClosePopup()
        End If
    End Sub
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents collGiren As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_satici As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara_stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_detayli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_dahil As DevExpress.XtraEditors.CheckEdit
    Private Sub sec_satici_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_satici.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        sec_satici.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_satici_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_satici.QueryResultValue
        Dim s As String = deger(ds_satici)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisVerisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesapKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesapAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_stok_karti()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        stok_fiyat()
    End Sub
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Private Sub MenuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If MenuItem26.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem26.Checked = True
        ElseIf MenuItem26.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem26.Checked = False
        End If
    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_pdf()
    End Sub
    Friend WithEvents collKar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnISK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnISK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnISK3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnISK4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAciklama5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikisFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_ozet As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colnStokFiyati As DevExpress.XtraGrid.Columns.GridColumn
End Class
