Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_liste_envanter_deger
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
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
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKisaAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBedenTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavalaTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKdvTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnTeminSuresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAsgariMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAzamiMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOzelNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFiyatlandirma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEksiyeDusebilirmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDefaultAsortiTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEksideUyarsinmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbOtvVar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOTVTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesiAV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_magaza As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_mevcut As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_grup As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colBekleyen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_Fiyattipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colmDeger As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbDeger As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_liste_envanter_deger))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sinifFiltre = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sec_Fiyattipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_MaliyetTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblMaliyet = New DevExpress.XtraEditors.LabelControl()
        Me.sec_grup = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_mevcut = New DevExpress.XtraEditors.ComboBoxEdit()
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
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
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
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKisaAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBedenTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavalaTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKdvTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnTeminSuresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAsgariMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAzamiMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOzelNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFiyatlandirma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEksiyeDusebilirmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDefaultAsortiTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEksideUyarsinmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbOtvVar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOTVTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesiAV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEK2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBekleyen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmDeger = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbDeger = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnBirimCarpan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.ds_magaza = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sinifFiltre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Fiyattipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_grup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_mevcut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 112)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_MaliyetTipi)
        Me.GroupControl1.Controls.Add(Me.lblMaliyet)
        Me.GroupControl1.Controls.Add(Me.sinifFiltre)
        Me.GroupControl1.Controls.Add(Me.sec_Fiyattipi)
        Me.GroupControl1.Controls.Add(Me.sec_grup)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_mevcut)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(726, 132)
        Me.GroupControl1.TabIndex = 39
        Me.GroupControl1.Text = "Ara"
        '
        'sinifFiltre
        '
        Me.sinifFiltre.EditValue = True
        Me.sinifFiltre.Location = New System.Drawing.Point(343, 39)
        Me.sinifFiltre.MenuManager = Me.BarManager1
        Me.sinifFiltre.Name = "sinifFiltre"
        Me.sinifFiltre.Properties.Caption = "Sýnýf Filtre"
        Me.sinifFiltre.Size = New System.Drawing.Size(97, 19)
        Me.sinifFiltre.TabIndex = 47

        '
        'sec_MaliyetTipi
        '
        Me.sec_MaliyetTipi.EditValue = "Fiyat Tipine Göre"
        Me.sec_MaliyetTipi.EnterMoveNextControl = True
        Me.sec_MaliyetTipi.Location = New System.Drawing.Point(64, 84)
        Me.sec_MaliyetTipi.Name = "sec_MaliyetTipi"
        Me.sec_MaliyetTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_MaliyetTipi.Properties.Items.AddRange(New Object() {"Fiyat Tipine Göre", "Maliyetlendirmeden (FIFO)"})
        Me.sec_MaliyetTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_MaliyetTipi.Size = New System.Drawing.Size(340, 20)
        Me.sec_MaliyetTipi.TabIndex = 20
        '
        'lblMaliyet
        '
        Me.lblMaliyet.Location = New System.Drawing.Point(22, 88)
        Me.lblMaliyet.Name = "lblMaliyet"
        Me.lblMaliyet.Size = New System.Drawing.Size(38, 13)
        Me.lblMaliyet.TabIndex = 21
        Me.lblMaliyet.Text = "Maliyet:"         '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Stok Kartý,F4"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Envanter,F6"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Stok Hareketleri,F7"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Excel"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Text"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Mail"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
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
        'sec_Fiyattipi
        '
        Me.sec_Fiyattipi.EnterMoveNextControl = True
        Me.sec_Fiyattipi.Location = New System.Drawing.Point(273, 60)
        Me.sec_Fiyattipi.Name = "sec_Fiyattipi"
        Me.sec_Fiyattipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_Fiyattipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_Fiyattipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_Fiyattipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_Fiyattipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_Fiyattipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Fiyattipi.Properties.DisplayMember = "sFiyatTipi"
        Me.sec_Fiyattipi.Properties.NullText = "[FiyatTipi]"
        Me.sec_Fiyattipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_Fiyattipi.Properties.ValueMember = "sFiyatTipi"
        Me.sec_Fiyattipi.Size = New System.Drawing.Size(64, 20)
        Me.sec_Fiyattipi.TabIndex = 6
        '
        'sec_grup
        '
        Me.sec_grup.EditValue = "R/B/K"
        Me.sec_grup.EnterMoveNextControl = True
        Me.sec_grup.Location = New System.Drawing.Point(337, 60)
        Me.sec_grup.Name = "sec_grup"
        Me.sec_grup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_grup.Properties.Items.AddRange(New Object() {"R/B/K", "Model", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5", "Sýnýf6", "Sýnýf7", "Sýnýf8", "Sýnýf9", "Sýnýf10", "Sýnýf11", "Sýnýf12", "Sýnýf13", "Sýnýf14", "Sýnýf15", "Depo"})
        Me.sec_grup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_grup.Size = New System.Drawing.Size(64, 20)
        Me.sec_grup.TabIndex = 7
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(64, 16)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(273, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(31, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "Tarih:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(20, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Mevcut:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(22, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Stoklar:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(133, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 43
        Me.LabelControl5.Text = "Maðaza:"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(181, 60)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.PopupControl = Me.sec_grid
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(92, 20)
        Me.sec_depo.TabIndex = 5
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(272, 25)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(232, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
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
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kod"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(181, 38)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(92, 20)
        Me.sec_konum.TabIndex = 2
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(273, 38)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Ýçermez", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 3
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(64, 38)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(120, 20)
        Me.txt_ara.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(401, 60)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(64, 20)
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_mevcut
        '
        Me.sec_mevcut.EditValue = "[Tümü]"
        Me.sec_mevcut.EnterMoveNextControl = True
        Me.sec_mevcut.Location = New System.Drawing.Point(64, 60)
        Me.sec_mevcut.Name = "sec_mevcut"
        Me.sec_mevcut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_mevcut.Properties.Items.AddRange(New Object() {"[Tümü]", "Artýlar", "Eksiler", "Bitenler"})
        Me.sec_mevcut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_mevcut.Size = New System.Drawing.Size(64, 20)
        Me.sec_mevcut.TabIndex = 4
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 108)
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 112)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 247)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(820, 243)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem19, Me.MenuItem16, Me.MenuItem18, Me.MenuItem21, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem17, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Stok Kartý"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Envanter"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Stok Hareketleri"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem21.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 7
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 8
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 9
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 10
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 11
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 12
        Me.MenuItem10.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 13
        Me.MenuItem17.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 14
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 15
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 16
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 17
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 18
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 19
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 20
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nStokID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sKodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sKisaAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "nStokTipi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sBedenTipi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sKavalaTipi"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sRenk"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sBeden"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sKavala"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sBirimCinsi1"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sBirimCinsi2"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nIskontoYuzdesi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sKdvTipi"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "nTeminSuresi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lAsgariMiktar"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lAzamiMiktar"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sOzelNot"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nFiyatlandirma"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sModel"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sKullaniciAdi"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "dteKayitTarihi"
        Me.DataColumn22.DataType = GetType(Date)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "bEksiyeDusebilirmi"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sDefaultAsortiTipi"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "bEksideUyarsinmi"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "bOtvVar"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sOTVTipi"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "nIskontoYuzdesiAV"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "bEK1"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "bEK2"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sBarkod"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "Sinif1"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "Sinif2"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Sinif3"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Sinif4"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Sinif5"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Sinif6"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Sinif7"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Sinif8"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "Sinif9"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "Sinif10"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "Sinif11"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "Sinif12"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "Sinif13"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "Sinif14"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "Sinif15"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "ISTIHBARAT"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "Mevcut"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.colsKisaAdi, Me.colnStokTipi, Me.colsBedenTipi, Me.colsKavalaTipi, Me.colsRenk, Me.colsBeden, Me.colsKavala, Me.colsBirimCinsi1, Me.colsBirimCinsi2, Me.colnIskontoYuzdesi, Me.colsKdvTipi, Me.colnTeminSuresi, Me.collAsgariMiktar, Me.collAzamiMiktar, Me.colsOzelNot, Me.colnFiyatlandirma, Me.colsModel, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colbEksiyeDusebilirmi, Me.colsDefaultAsortiTipi, Me.colbEksideUyarsinmi, Me.colbOtvVar, Me.colsOTVTipi, Me.colnIskontoYuzdesiAV, Me.colbEK1, Me.colbEK2, Me.colsBarkod, Me.colSinif1, Me.colSinif2, Me.colSinif3, Me.colSinif4, Me.colSinif5, Me.colSinif6, Me.colSinif7, Me.colSinif8, Me.colSinif9, Me.colSinif10, Me.colSinif11, Me.colSinif12, Me.colSinif13, Me.colSinif14, Me.colSinif15, Me.colISTIHBARAT, Me.colMevcut, Me.colBekleyen, Me.colmDeger, Me.colbDeger, Me.collMaliyet, Me.colnBirimCarpan})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", Nothing, "{0:#,0.##} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", Me.colMevcut, "{0:#,0.##}")})
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
        'colnStokID
        '
        Me.colnStokID.Caption = "Kayýt No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kod"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 76
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 175
        '
        'colsKisaAdi
        '
        Me.colsKisaAdi.Caption = "Kýsa Adý"
        Me.colsKisaAdi.FieldName = "sKisaAdi"
        Me.colsKisaAdi.Name = "colsKisaAdi"
        '
        'colnStokTipi
        '
        Me.colnStokTipi.Caption = "Stok Tipi"
        Me.colnStokTipi.FieldName = "nStokTipi"
        Me.colnStokTipi.Name = "colnStokTipi"
        '
        'colsBedenTipi
        '
        Me.colsBedenTipi.Caption = "Beden Tipi"
        Me.colsBedenTipi.FieldName = "sBedenTipi"
        Me.colsBedenTipi.Name = "colsBedenTipi"
        '
        'colsKavalaTipi
        '
        Me.colsKavalaTipi.Caption = "Kavala Tipi"
        Me.colsKavalaTipi.FieldName = "sKavalaTipi"
        Me.colsKavalaTipi.Name = "colsKavalaTipi"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.ColumnEdit = Me.sec_renk
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.Width = 107
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ValueMember = "sRenk"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsKavala
        '
        Me.colsKavala.Caption = "Kavala"
        Me.colsKavala.FieldName = "sKavala"
        Me.colsKavala.Name = "colsKavala"
        '
        'colsBirimCinsi1
        '
        Me.colsBirimCinsi1.Caption = "Birim 1"
        Me.colsBirimCinsi1.FieldName = "sBirimCinsi1"
        Me.colsBirimCinsi1.Name = "colsBirimCinsi1"
        '
        'colsBirimCinsi2
        '
        Me.colsBirimCinsi2.Caption = "Birim 2"
        Me.colsBirimCinsi2.FieldName = "sBirimCinsi2"
        Me.colsBirimCinsi2.Name = "colsBirimCinsi2"
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "Ýskonto Yüzdesi"
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        '
        'colsKdvTipi
        '
        Me.colsKdvTipi.Caption = "Kdv Tipi"
        Me.colsKdvTipi.FieldName = "sKdvTipi"
        Me.colsKdvTipi.Name = "colsKdvTipi"
        '
        'colnTeminSuresi
        '
        Me.colnTeminSuresi.Caption = "Temin Süresi"
        Me.colnTeminSuresi.FieldName = "nTeminSuresi"
        Me.colnTeminSuresi.Name = "colnTeminSuresi"
        '
        'collAsgariMiktar
        '
        Me.collAsgariMiktar.Caption = "Asgari Miktar"
        Me.collAsgariMiktar.FieldName = "lAsgariMiktar"
        Me.collAsgariMiktar.Name = "collAsgariMiktar"
        '
        'collAzamiMiktar
        '
        Me.collAzamiMiktar.Caption = "Azami Miktar"
        Me.collAzamiMiktar.FieldName = "lAzamiMiktar"
        Me.collAzamiMiktar.Name = "collAzamiMiktar"
        '
        'colsOzelNot
        '
        Me.colsOzelNot.Caption = "Özel Not"
        Me.colsOzelNot.FieldName = "sOzelNot"
        Me.colsOzelNot.Name = "colsOzelNot"
        '
        'colnFiyatlandirma
        '
        Me.colnFiyatlandirma.Caption = "Fiyatlandirma"
        Me.colnFiyatlandirma.FieldName = "nFiyatlandirma"
        Me.colnFiyatlandirma.Name = "colnFiyatlandirma"
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanýcý Adý"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colbEksiyeDusebilirmi
        '
        Me.colbEksiyeDusebilirmi.Caption = "Eksiye Düþebilirmi"
        Me.colbEksiyeDusebilirmi.FieldName = "bEksiyeDusebilirmi"
        Me.colbEksiyeDusebilirmi.Name = "colbEksiyeDusebilirmi"
        '
        'colsDefaultAsortiTipi
        '
        Me.colsDefaultAsortiTipi.Caption = "DefaultAsortiTipi"
        Me.colsDefaultAsortiTipi.FieldName = "sDefaultAsortiTipi"
        Me.colsDefaultAsortiTipi.Name = "colsDefaultAsortiTipi"
        '
        'colbEksideUyarsinmi
        '
        Me.colbEksideUyarsinmi.Caption = "Ekside Uyarsýnmý"
        Me.colbEksideUyarsinmi.FieldName = "bEksideUyarsinmi"
        Me.colbEksideUyarsinmi.Name = "colbEksideUyarsinmi"
        '
        'colbOtvVar
        '
        Me.colbOtvVar.Caption = "Otv Var"
        Me.colbOtvVar.FieldName = "bOtvVar"
        Me.colbOtvVar.Name = "colbOtvVar"
        '
        'colsOTVTipi
        '
        Me.colsOTVTipi.Caption = "OTV Tipi"
        Me.colsOTVTipi.FieldName = "sOTVTipi"
        Me.colsOTVTipi.Name = "colsOTVTipi"
        '
        'colnIskontoYuzdesiAV
        '
        Me.colnIskontoYuzdesiAV.Caption = "Ýskonto Yüzdesi AV"
        Me.colnIskontoYuzdesiAV.FieldName = "nIskontoYuzdesiAV"
        Me.colnIskontoYuzdesiAV.Name = "colnIskontoYuzdesiAV"
        '
        'colbEK1
        '
        Me.colbEK1.Caption = "EK1"
        Me.colbEK1.FieldName = "bEK1"
        Me.colbEK1.Name = "colbEK1"
        '
        'colbEK2
        '
        Me.colbEK2.Caption = "EK2"
        Me.colbEK2.FieldName = "bEK2"
        Me.colbEK2.Name = "colbEK2"
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        '
        'colSinif1
        '
        Me.colSinif1.Caption = "Sýnýf 1"
        Me.colSinif1.FieldName = "Sinif1"
        Me.colSinif1.Name = "colSinif1"
        Me.colSinif1.Width = 127
        '
        'colSinif2
        '
        Me.colSinif2.Caption = "Sýnýf 2"
        Me.colSinif2.FieldName = "Sinif2"
        Me.colSinif2.Name = "colSinif2"
        '
        'colSinif3
        '
        Me.colSinif3.Caption = "Sýnýf 3"
        Me.colSinif3.FieldName = "Sinif3"
        Me.colSinif3.Name = "colSinif3"
        '
        'colSinif4
        '
        Me.colSinif4.Caption = "Sýnýf 4"
        Me.colSinif4.FieldName = "Sinif4"
        Me.colSinif4.Name = "colSinif4"
        '
        'colSinif5
        '
        Me.colSinif5.Caption = "Sýnýf 5"
        Me.colSinif5.FieldName = "Sinif5"
        Me.colSinif5.Name = "colSinif5"
        '
        'colSinif6
        '
        Me.colSinif6.Caption = "Sýnýf 6"
        Me.colSinif6.FieldName = "Sinif6"
        Me.colSinif6.Name = "colSinif6"
        '
        'colSinif7
        '
        Me.colSinif7.Caption = "Sýnýf 7"
        Me.colSinif7.FieldName = "Sinif7"
        Me.colSinif7.Name = "colSinif7"
        '
        'colSinif8
        '
        Me.colSinif8.Caption = "Sýnýf 8"
        Me.colSinif8.FieldName = "Sinif8"
        Me.colSinif8.Name = "colSinif8"
        '
        'colSinif9
        '
        Me.colSinif9.Caption = "Sýnýf 9"
        Me.colSinif9.FieldName = "Sinif9"
        Me.colSinif9.Name = "colSinif9"
        '
        'colSinif10
        '
        Me.colSinif10.Caption = "Sýnýf 10"
        Me.colSinif10.FieldName = "Sinif10"
        Me.colSinif10.Name = "colSinif10"
        '
        'colSinif11
        '
        Me.colSinif11.Caption = "Sýnýf 11"
        Me.colSinif11.FieldName = "Sinif11"
        Me.colSinif11.Name = "colSinif11"
        '
        'colSinif12
        '
        Me.colSinif12.Caption = "Sýnýf 12"
        Me.colSinif12.FieldName = "Sinif12"
        Me.colSinif12.Name = "colSinif12"
        '
        'colSinif13
        '
        Me.colSinif13.Caption = "Sýnýf 13"
        Me.colSinif13.FieldName = "Sinif13"
        Me.colSinif13.Name = "colSinif13"
        '
        'colSinif14
        '
        Me.colSinif14.Caption = "Sýnýf 14"
        Me.colSinif14.FieldName = "Sinif14"
        Me.colSinif14.Name = "colSinif14"
        '
        'colSinif15
        '
        Me.colSinif15.Caption = "Sýnýf 15"
        Me.colSinif15.FieldName = "Sinif15"
        Me.colSinif15.Name = "colSinif15"
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "ISTIHBARAT"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        '
        'colMevcut
        '
        Me.colMevcut.Caption = "Mevcut"
        Me.colMevcut.DisplayFormat.FormatString = "#,0.####"
        Me.colMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMevcut.FieldName = "lMevcut"
        Me.colMevcut.Name = "colMevcut"
        Me.colMevcut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMevcut", "{0:#,0.####}")})
        Me.colMevcut.Visible = True
        Me.colMevcut.VisibleIndex = 2
        Me.colMevcut.Width = 76
        '
        'colBekleyen
        '
        Me.colBekleyen.Caption = "Bekleyen"
        Me.colBekleyen.DisplayFormat.FormatString = "#,0.####"
        Me.colBekleyen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBekleyen.FieldName = "lBekleyen"
        Me.colBekleyen.Name = "colBekleyen"
        Me.colBekleyen.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBekleyen", "{0:#,0.####}")})
        Me.colBekleyen.Visible = True
        Me.colBekleyen.VisibleIndex = 4
        Me.colBekleyen.Width = 82
        '
        'colmDeger
        '
        Me.colmDeger.Caption = "Mevcut Deðer"
        Me.colmDeger.DisplayFormat.FormatString = "#,0.00##"
        Me.colmDeger.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colmDeger.FieldName = "mDeger"
        Me.colmDeger.Name = "colmDeger"
        Me.colmDeger.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mDeger", "{0:#,0.00##}")})
        Me.colmDeger.Visible = True
        Me.colmDeger.VisibleIndex = 3
        Me.colmDeger.Width = 89
        '
        'colbDeger
        '
        Me.colbDeger.Caption = "Bekleyen Deðer"
        Me.colbDeger.DisplayFormat.FormatString = "#,0.00##"
        Me.colbDeger.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colbDeger.FieldName = "bDeger"
        Me.colbDeger.Name = "colbDeger"
        Me.colbDeger.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "bDeger", "{0:#,0.00##}")})
        Me.colbDeger.Visible = True
        Me.colbDeger.VisibleIndex = 5
        Me.colbDeger.Width = 84
        '
        'collMaliyet
        '
        Me.collMaliyet.Caption = "Fiyat"
        Me.collMaliyet.DisplayFormat.FormatString = "#,0.00"
        Me.collMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMaliyet.FieldName = "Maliyet"
        Me.collMaliyet.Name = "collMaliyet"
        '
        'colnBirimCarpan
        '
        Me.colnBirimCarpan.Caption = "Koli Ýçi"
        Me.colnBirimCarpan.DisplayFormat.FormatString = "#,0.##"
        Me.colnBirimCarpan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnBirimCarpan.FieldName = "nBirimCarpan"
        Me.colnBirimCarpan.Name = "colnBirimCarpan"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn49, Me.DataColumn50, Me.DataColumn51})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "SEC"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "KOD"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "ACIKLAMA"
        '
        'frm_stok_liste_envanter_deger
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
        Me.Name = "frm_stok_liste_envanter_deger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Envanter Raporlarý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sinifFiltre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Fiyattipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_grup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_mevcut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Dim ds_tbFiyatTipi As DataSet
    Public islemstatus As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        dataload_renk()
        dataload_tbFiyatTipi()
        DateEdit1.EditValue = dteSistemTarihi
        txt_ara.EditValue = ""
        'txt_ara.Focus()
        'txt_ara.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & "  Tarihindeki Mevcut Stoklar" & vbCrLf
        kriter += "Depo = " & sec_depo.Text & " Mevcut: " & sec_mevcut.Text & " Grup: " & sec_grup.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
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
    Private Sub dataload_renk()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi Where sFiyatTipi <>''"))
        sec_Fiyattipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_Fiyattipi.EditValue = sFiyatM
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
        cmd = Nothing
        adapter = Nothing
    End Function
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
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal mevcut As String, ByVal depo As String, ByVal sGrup As String, ByVal sFiyatTipi As String) As DataSet
        Dim kriter = "WHERE tbStok.sKodu <> '' and tbStok.nStokTipi < 5 "
        Dim kriter2 = ""
        Dim kriter_depo = ""
        Dim kriter_bDepo = ""
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter += " AND (tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
            ElseIf konum = "Sýnýf1" Then
                kriter += " AND ( tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf2" Then
                kriter += " AND ( tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf3" Then
                kriter += " AND ( tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf4" Then
                kriter += " AND ( tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf5" Then
                kriter += " AND ( tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf6" Then
                kriter += " AND ( tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf7" Then
                kriter += " AND ( tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf8" Then
                kriter += " AND ( tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf9" Then
                kriter += " AND ( tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf10" Then
                kriter += " AND ( tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf11" Then
                kriter += " AND ( tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf12" Then
                kriter += " AND ( tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf13" Then
                kriter += " AND ( tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf14" Then
                kriter += " AND ( tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf15" Then
                kriter += " AND ( tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        If sStokSinirla <> "" Then
            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
        End If
        'If depo <> "[Tümü]" Then
        '    kriter_depo += " AND tbStokFisiDetayi.sDepo IN ( " & depo & " )"
        '    kriter_bDepo += " AND tbAlisVeris.sMagaza IN ( " & depo & " )"
        'End If
        kriter_depo += " Where tbStokFisiDetayi.dteIslemTarihi < = '" & tarih1 & "' "
        If depo <> "[Tümü]" Then
            kriter_depo += " AND tbStokFisiDetayi.sDepo IN ( " & depo & " )"
            kriter_bDepo += " AND tbAlisVeris.sMagaza IN ( " & depo & " )"
        End If
        'If mevcut <> "" Then
        '    If mevcut = "[Tümü]" Then
        '    ElseIf mevcut = "Artýlar" Then
        '        kriter2 = " WHERE (tEnvanter.Mevcut > 0) "
        '    ElseIf mevcut = "Eksiler" Then
        '        kriter2 = " Where (tEnvanter.Mevcut < 0) "
        '    ElseIf mevcut = "Bitenler" Then
        '        kriter2 = " Where (tEnvanter.Mevcut = 0) "
        '    End If
        'End If
        If mevcut <> "" Then
            If sGrup = "Depo" Then
                If mevcut = "[Tümü]" Then
                ElseIf mevcut = "Artýlar" Then
                    kriter2 = " AND tbStok.nStokID IN (SELECT nStokID FROM tbStokFisiDetayi WHERE (dteIslemTarihi <= '" & tarih1 & "') GROUP BY nStokID HAVING (SUM(lGirisMiktar1 - lCikisMiktar1) > 0)) "
                ElseIf mevcut = "Eksiler" Then
                    kriter2 = " AND tbStok.nStokID IN (SELECT nStokID FROM tbStokFisiDetayi WHERE (dteIslemTarihi <= '" & tarih1 & "') GROUP BY nStokID HAVING (SUM(lGirisMiktar1 - lCikisMiktar1) < 0)) "
                ElseIf mevcut = "Bitenler" Then
                    kriter2 = " AND tbStok.nStokID IN (SELECT nStokID FROM tbStokFisiDetayi WHERE (dteIslemTarihi <= '" & tarih1 & "') GROUP BY nStokID HAVING (SUM(lGirisMiktar1 - lCikisMiktar1) = 0)) "
                End If
            Else
                If mevcut = "[Tümü]" Then
                ElseIf mevcut = "Artýlar" Then
                    kriter2 = " AND (TempMevcut.lMevcut > 0) "
                ElseIf mevcut = "Eksiler" Then
                    kriter2 = " AND (TempMevcut.lMevcut < 0) "
                ElseIf mevcut = "Bitenler" Then
                    kriter2 = " AND (TempMevcut.lMevcut = 0) "
                End If
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If sinifFiltre.Checked = True Then
            If sGrup = "R/B/K" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT lMevcut * Maliyet AS mDeger, lBekleyen * Maliyet AS bDeger, * FROM (SELECT tbStok.* , ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar ")
            ElseIf sGrup = "Model" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger,sModel AS sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi,nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2, Sinif1, Sinif2, Sinif3, Sinif4, Sinif5, Sinif6, Sinif7, Sinif8, Sinif9, Sinif10, Sinif11, Sinif12, Sinif13, Sinif14, Sinif15 FROM (SELECT tbStok.* , tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar Group BY sModel, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi,nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2, Sinif1, Sinif2, Sinif3, Sinif4, Sinif5, Sinif6, Sinif7, Sinif8, Sinif9, Sinif10, Sinif11, Sinif12, Sinif13, Sinif14, Sinif15")
            ElseIf sGrup = "Sýnýf1" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif1 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif1")
            ElseIf sGrup = "Sýnýf2" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif2 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif2")
            ElseIf sGrup = "Sýnýf3" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif3 FROM (SELECT tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif3")
            ElseIf sGrup = "Sýnýf4" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif4 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif4")
            ElseIf sGrup = "Sýnýf5" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif5 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif5")
            ElseIf sGrup = "Sýnýf6" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif6 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif6")
            ElseIf sGrup = "Sýnýf7" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif7 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif7")
            ElseIf sGrup = "Sýnýf8" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif8 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif8")
            ElseIf sGrup = "Sýnýf9" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif9 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif9")
            ElseIf sGrup = "Sýnýf10" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif10 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif10")
            ElseIf sGrup = "Sýnýf11" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif11 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif11")
            ElseIf sGrup = "Sýnýf12" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif12 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif12")
            ElseIf sGrup = "Sýnýf13" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif13 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif13")
            ElseIf sGrup = "Sýnýf14" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif14 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif14")
            ElseIf sGrup = "Sýnýf15" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif15 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif15")
            ElseIf sGrup = "Depo" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, sDepo as sKodu,sDepoAdi as sAciklama FROM (SELECT TempMevcut.sDepo,TempMevcut.sDepoAdi,tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , sDepo,(Select sAciklama from tbDepo Where tbDepo.sDepo = tbStokFisiDetayi.sDepo) as sDepoAdi,isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID,sDepo) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY sDepo,sDepoAdi")
            End If
        Else
            If sGrup = "R/B/K" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT lMevcut * Maliyet AS mDeger, lBekleyen * Maliyet AS bDeger, * FROM (SELECT tbStok.* , ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar ")
            ElseIf sGrup = "Model" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger,sModel AS sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi,nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2, Sinif1, Sinif2, Sinif3, Sinif4, Sinif5, Sinif6, Sinif7, Sinif8, Sinif9, Sinif10, Sinif11, Sinif12, Sinif13, Sinif14, Sinif15 FROM (SELECT tbStok.* , tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar Group BY sModel, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi,nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2, Sinif1, Sinif2, Sinif3, Sinif4, Sinif5, Sinif6, Sinif7, Sinif8, Sinif9, Sinif10, Sinif11, Sinif12, Sinif13, Sinif14, Sinif15")
            ElseIf sGrup = "Sýnýf1" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif1 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif1")
            ElseIf sGrup = "Sýnýf2" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif2 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif2")
            ElseIf sGrup = "Sýnýf3" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif3 FROM (SELECT tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif3")
            ElseIf sGrup = "Sýnýf4" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif4 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif4")
            ElseIf sGrup = "Sýnýf5" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif5 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif5")
            ElseIf sGrup = "Sýnýf6" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif6 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif6")
            ElseIf sGrup = "Sýnýf7" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif7 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif7")
            ElseIf sGrup = "Sýnýf8" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif8 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif8")
            ElseIf sGrup = "Sýnýf9" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif9 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif9")
            ElseIf sGrup = "Sýnýf10" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif10 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif10")
            ElseIf sGrup = "Sýnýf11" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif11 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif11")
            ElseIf sGrup = "Sýnýf12" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif12 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif12")
            ElseIf sGrup = "Sýnýf13" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif13 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif13")
            ElseIf sGrup = "Sýnýf14" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif14 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif14")
            ElseIf sGrup = "Sýnýf15" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, Sinif15 FROM (SELECT tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY Sinif15")
            ElseIf sGrup = "Depo" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lMevcut) as lMevcut,Sum(lBekleyen) as lBekleyen,SUM(lMevcut * Maliyet) AS mDeger, SUM(lBekleyen * Maliyet) AS bDeger, sDepo as sKodu,sDepoAdi as sAciklama FROM (SELECT TempMevcut.sDepo,TempMevcut.sDepoAdi,tbStokBarkodu.sBarkod AS sBarkod , tbSSinif1.sAciklama AS Sinif1 , tbSSinif2.sAciklama AS Sinif2 , tbSSinif3.sAciklama AS Sinif3 , tbSSinif4.sAciklama AS Sinif4 , tbSSinif5.sAciklama AS Sinif5 , tbSSinif6.sAciklama AS Sinif6 , tbSSinif7.sAciklama AS Sinif7 , tbSSinif8.sAciklama AS Sinif8 , tbSSinif9.sAciklama AS Sinif9 , tbSSinif10.sAciklama AS Sinif10 , tbSSinif11.sAciklama AS Sinif11 , tbSSinif12.sAciklama AS Sinif12 , tbSSinif13.sAciklama AS Sinif13 , tbSSinif14.sAciklama AS Sinif14 , tbSSinif15.sAciklama AS Sinif15 , ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10 , '') AS ISTIHBARAT , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "')) AS Maliyet , TempBekleyen.lBekleyen AS lBekleyen , TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu LEFT OUTER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu LEFT OUTER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu LEFT OUTER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu LEFT OUTER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu LEFT OUTER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu LEFT OUTER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu LEFT OUTER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu LEFT OUTER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu LEFT OUTER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu LEFT OUTER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu LEFT OUTER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID , sDepo,(Select sAciklama from tbDepo Where tbDepo.sDepo = tbStokFisiDetayi.sDepo) as sDepoAdi,isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) AS lMevcut FROM tbStokFisiDetayi " & kriter_depo & " GROUP BY nStokID,sDepo) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID LEFT OUTER JOIN (SELECT stok.nStokID , ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS lBekleyen FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_bDepo & " GROUP BY stok.nStokID) TempBekleyen ON tbStok.nStokID = TempBekleyen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & ") tbStoklar GROUP BY sDepo,sDepoAdi")
            End If
        End If
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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal mevcut As String, ByVal depo As String, ByVal sGrup As String, ByVal sFiyatTipi As String)
        DataSet1 = stok(ara, konum, ara_kriter, tarih1, mevcut, depo, sGrup, sFiyatTipi)
        ' Maliyetlendirmeden (FIFO) secildiyse - grid'e baglamadan ONCE hesapla
        If sec_MaliyetTipi.SelectedIndex = 1 Then
            If DataSet1 IsNot Nothing AndAlso DataSet1.Tables.Count > 0 AndAlso DataSet1.Tables(0).Columns.Contains("nStokID") Then
                For Each dr As DataRow In DataSet1.Tables(0).Rows
                    Try
                        Dim nStokID As Int64 = CLng(dr("nStokID"))
                        Dim lMevcut As Decimal = CDec(dr("lMevcut"))
                        Dim yeniMaliyet As Decimal = MaliyetHesaplayici.HesaplaFIFOEnvanter(nStokID, lMevcut)
                        dr("Maliyet") = yeniMaliyet
                        dr("mDeger") = lMevcut * yeniMaliyet
                        dr("bDeger") = CDec(dr("lBekleyen")) * yeniMaliyet
                    Catch
                    End Try
                Next
            End If
        End If
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, DateEdit1.EditValue, sec_mevcut.Text, sec_depo.Text, sec_grup.Text, sec_Fiyattipi.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
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
            frm.sec_giris.Text = "Çýkýþlar"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
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
            Dim frm As New frm_musteri_karti
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
    Private Sub analiz_stok_KarlilikAkisTablosu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Stok_Satis_Maliyetlendir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.txt_sStokKodu.Text = dr("sKodu")
            frm.bAnaliz = True
            If yetki_kontrol(kullanici, "frm_Stok_KarlilikAkisTablosu") = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
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
            SaveFileDialog1.FileName = "Ekstre.txt"
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
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
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
        stok_duzelt()
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
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
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
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
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
        Return s.ToString
    End Function
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.F4 Then
            ClosePopup()
        ElseIf e.KeyCode = Keys.Escape Then
            ClosePopup()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_pdf()
    End Sub
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If MenuItem17.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem17.Checked = True
        ElseIf MenuItem17.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem17.Checked = False
        End If
    End Sub
    Friend WithEvents collMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnBirimCarpan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_stok_hareket()
    End Sub
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        stok_duzelt()
    End Sub
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_stok_hareket()
    End Sub
    Friend WithEvents sinifFiltre As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_MaliyetTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblMaliyet As DevExpress.XtraEditors.LabelControl
End Class