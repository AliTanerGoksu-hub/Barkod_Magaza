Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Public Class frm_stok_satis_karliligi
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
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents colFISSAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_Siralama As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_nTop As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents sec_sTop As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_bSiniflandir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colsSINIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_nSinif As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMaliyetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents collKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_Logo_Xml As System.Data.DataSet
    Friend WithEvents DataTable7 As System.Data.DataTable
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
    Friend WithEvents DataTable8 As System.Data.DataTable
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_satis_karliligi))
        Me.colnOran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_nSinif = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.sec_bSiniflandir = New DevExpress.XtraEditors.CheckEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.sec_Siralama = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_nTop = New DevExpress.XtraEditors.SpinEdit
        Me.sec_sTop = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.sec_kasatipi = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.sec_fistipi = New DevExpress.XtraEditors.PopupContainerEdit
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenu
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_harekettipi = New DevExpress.XtraEditors.PopupContainerEdit
        Me.sec_kasakasiyer = New DevExpress.XtraEditors.PopupContainerEdit
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.bar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collIskonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMaliyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMaliyetTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFISSAYISI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSINIF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.ds_magaza = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.ds_kasa = New System.Data.DataSet
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.ds_kasiyer = New System.Data.DataSet
        Me.DataTable4 = New System.Data.DataTable
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.ds_harekettipi = New System.Data.DataSet
        Me.DataTable5 = New System.Data.DataTable
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.ds_fistipi = New System.Data.DataSet
        Me.DataTable6 = New System.Data.DataTable
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.ds_Logo_Xml = New System.Data.DataSet
        Me.DataTable7 = New System.Data.DataTable
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataTable8 = New System.Data.DataTable
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_nSinif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bSiniflandir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Siralama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.ds_Logo_Xml, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colnOran
        '
        Me.colnOran.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colnOran.AppearanceCell.Options.UseFont = True
        Me.colnOran.Caption = "Oran"
        Me.colnOran.DisplayFormat.FormatString = "p"
        Me.colnOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnOran.FieldName = "nOran"
        Me.colnOran.Name = "colnOran"
        Me.colnOran.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colnOran.Visible = True
        Me.colnOran.VisibleIndex = 11
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 174)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_nSinif)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.sec_bSiniflandir)
        Me.GroupControl1.Controls.Add(Me.sec_Siralama)
        Me.GroupControl1.Controls.Add(Me.txt_nTop)
        Me.GroupControl1.Controls.Add(Me.sec_sTop)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
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
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(499, 170)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_nSinif
        '
        Me.sec_nSinif.EditValue = "1"
        Me.sec_nSinif.EnterMoveNextControl = True
        Me.sec_nSinif.Location = New System.Drawing.Point(398, 121)
        Me.sec_nSinif.Name = "sec_nSinif"
        Me.sec_nSinif.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_nSinif.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_nSinif.Properties.Appearance.Options.UseBackColor = True
        Me.sec_nSinif.Properties.Appearance.Options.UseFont = True
        Me.sec_nSinif.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_nSinif.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nSinif.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.sec_nSinif.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_nSinif.Size = New System.Drawing.Size(29, 18)
        Me.sec_nSinif.TabIndex = 39
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(370, 123)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl12.TabIndex = 38
        Me.LabelControl12.Text = "Sinif:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(133, 123)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl11.TabIndex = 37
        Me.LabelControl11.Text = "Sýralama:"
        '
        'sec_bSiniflandir
        '
        Me.sec_bSiniflandir.Enabled = False
        Me.sec_bSiniflandir.Location = New System.Drawing.Point(251, 121)
        Me.sec_bSiniflandir.MenuManager = Me.BarManager1
        Me.sec_bSiniflandir.Name = "sec_bSiniflandir"
        Me.sec_bSiniflandir.Properties.Caption = "Gruplara Göre"
        Me.sec_bSiniflandir.Size = New System.Drawing.Size(91, 19)
        Me.sec_bSiniflandir.TabIndex = 36
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
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Text"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Mail"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Envanter,F6"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Stok Fiyatlarý ,Ctrl+F"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "XML"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Aktar"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 406)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 406)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 406)
        '
        'sec_Siralama
        '
        Me.sec_Siralama.EditValue = "Miktar"
        Me.sec_Siralama.Location = New System.Drawing.Point(183, 121)
        Me.sec_Siralama.Name = "sec_Siralama"
        Me.sec_Siralama.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_Siralama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_Siralama.Properties.Appearance.Options.UseBackColor = True
        Me.sec_Siralama.Properties.Appearance.Options.UseFont = True
        Me.sec_Siralama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_Siralama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Siralama.Properties.Items.AddRange(New Object() {"Miktar", "Tutar", "Musteri", "Kar"})
        Me.sec_Siralama.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_Siralama.Size = New System.Drawing.Size(62, 18)
        Me.sec_Siralama.TabIndex = 35
        '
        'txt_nTop
        '
        Me.txt_nTop.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nTop.Location = New System.Drawing.Point(72, 120)
        Me.txt_nTop.Name = "txt_nTop"
        Me.txt_nTop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_nTop.Size = New System.Drawing.Size(55, 20)
        Me.txt_nTop.TabIndex = 31
        '
        'sec_sTop
        '
        Me.sec_sTop.EditValue = "Ýlk"
        Me.sec_sTop.Location = New System.Drawing.Point(26, 120)
        Me.sec_sTop.Name = "sec_sTop"
        Me.sec_sTop.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sTop.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sTop.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sTop.Properties.Appearance.Options.UseFont = True
        Me.sec_sTop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_sTop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sTop.Properties.Items.AddRange(New Object() {"Ýlk", "Son"})
        Me.sec_sTop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sTop.Size = New System.Drawing.Size(40, 18)
        Me.sec_sTop.TabIndex = 30
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(41, 100)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl10.TabIndex = 29
        Me.LabelControl10.Text = "Stok:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Ad"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(202, 100)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Geliþmiþ", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5", "Sýnýf6", "Sýnýf7", "Sýnýf8", "Sýnýf9", "Sýnýf10", "Sýnýf11", "Sýnýf12", "Sýnýf13", "Sýnýf14", "Sýnýf15"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 8
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(301, 100)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(65, 20)
        Me.sec_kriter.TabIndex = 9
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(72, 100)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(131, 20)
        Me.txt_ara.TabIndex = 7
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
        Me.sec_kasatipi.Location = New System.Drawing.Point(-1, 59)
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
        Me.LabelControl6.Location = New System.Drawing.Point(49, 80)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "HT:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(25, 40)
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
        Me.sec_fistipi.Location = New System.Drawing.Point(202, 80)
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
        Me.sec_harekettipi.Location = New System.Drawing.Point(72, 80)
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
        Me.sec_kasakasiyer.Location = New System.Drawing.Point(72, 60)
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
        Me.LabelControl3.Location = New System.Drawing.Point(38, 21)
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
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(88, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(72, 140)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(230, 20)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "&Listele"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(595, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(227, 170)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.bar1)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 358)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'bar1
        '
        Me.bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bar1.Location = New System.Drawing.Point(2, 36)
        Me.bar1.Name = "bar1"
        Me.bar1.Properties.ShowTitle = True
        Me.bar1.Size = New System.Drawing.Size(820, 10)
        Me.bar1.TabIndex = 7
        Me.bar1.Visible = False
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
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 174)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 184)
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 180)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem19, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem21, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem14.Text = "Ara"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem16.Text = "Stok Kartý"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem19.Text = "Envanter"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 5
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem22.Text = "Stok Hareketleri"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem23.Text = "Stok Fiyatlarý"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 7
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem24.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 8
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem25.Text = "Yaninda Satilanlar"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 9
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 10
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 11
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 12
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 13
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 14
        Me.MenuItem10.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 15
        Me.MenuItem21.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 16
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 17
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 18
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 19
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 20
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 21
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 22
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn28})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Sýnýf"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Aciklama"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "IZAHAT"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MIKTAR"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "col1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "col2"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "col3"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "col4"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "col5"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "col6"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Status"
        Me.DataColumn11.DataType = GetType(Boolean)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "col7"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "col8"
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsKodu, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsStokAciklama, Me.collMiktar, Me.collIskonto, Me.collNetTutar, Me.collBrutTutar, Me.collMaliyet, Me.collMaliyetTutar, Me.collKar, Me.colnOran, Me.colsBarkod, Me.collKdvTutari, Me.colnKdvOrani, Me.collMevcut, Me.colFISSAYISI, Me.colsSINIF})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(609, 257, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colnOran
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.colsKodu, "{0: Kayýt}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", Me.collMiktar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskonto", Me.collIskonto, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Me.collNetTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", Me.collBrutTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMaliyetTutar", Me.collMaliyetTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKar", Me.collKar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKdvTutari", Me.collKdvTutari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "FISSAYISI", Me.colFISSAYISI, "{0:#}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, " Kayýt: {0: Kayýt}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", Nothing, "Miktar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskonto", Nothing, "Iskonto: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "NetTutar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", Nothing, "BrutTutar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMaliyetTutar", Nothing, "MaliyetTutar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKar", Nothing, "Kar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKdvTutari", Nothing, "KdvTutari: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "FISSAYISI", Nothing, "FisOrt: {0:#}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
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
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 85
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
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
        Me.colsRenkAdi.Width = 74
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.Visible = True
        Me.colsBeden.VisibleIndex = 3
        Me.colsBeden.Width = 57
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Açýklama"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 1
        Me.colsStokAciklama.Width = 197
        '
        'collMiktar
        '
        Me.collMiktar.Caption = "Miktar"
        Me.collMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktar.FieldName = "lMiktar"
        Me.collMiktar.Name = "collMiktar"
        Me.collMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", "{0:#,0.00}")})
        Me.collMiktar.Visible = True
        Me.collMiktar.VisibleIndex = 4
        '
        'collIskonto
        '
        Me.collIskonto.Caption = "Iskonto"
        Me.collIskonto.DisplayFormat.FormatString = "#,0.00"
        Me.collIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskonto.FieldName = "lIskonto"
        Me.collIskonto.Name = "collIskonto"
        Me.collIskonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskonto", "{0:#,0.00}")})
        Me.collIskonto.Visible = True
        Me.collIskonto.VisibleIndex = 5
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 6
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Brüt Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.00}")})
        Me.collBrutTutar.Visible = True
        Me.collBrutTutar.VisibleIndex = 7
        '
        'collMaliyet
        '
        Me.collMaliyet.Caption = "Maliyet"
        Me.collMaliyet.DisplayFormat.FormatString = "#,0.00"
        Me.collMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMaliyet.FieldName = "lMaliyet"
        Me.collMaliyet.Name = "collMaliyet"
        Me.collMaliyet.Visible = True
        Me.collMaliyet.VisibleIndex = 8
        '
        'collMaliyetTutar
        '
        Me.collMaliyetTutar.Caption = "Maliyet Tutarý"
        Me.collMaliyetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collMaliyetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMaliyetTutar.FieldName = "lMaliyetTutar"
        Me.collMaliyetTutar.Name = "collMaliyetTutar"
        Me.collMaliyetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMaliyetTutar", "{0:#,0.00}")})
        Me.collMaliyetTutar.Visible = True
        Me.collMaliyetTutar.VisibleIndex = 9
        '
        'collKar
        '
        Me.collKar.AppearanceCell.Options.UseFont = True
        Me.collKar.Caption = "Kar"
        Me.collKar.DisplayFormat.FormatString = "#,0.00"
        Me.collKar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKar.FieldName = "lKar"
        Me.collKar.Name = "collKar"
        Me.collKar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKar", "{0:#,0.00}")})
        Me.collKar.Visible = True
        Me.collKar.VisibleIndex = 10
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.Width = 92
        '
        'collKdvTutari
        '
        Me.collKdvTutari.Caption = "Kdv Tutarý"
        Me.collKdvTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKdvTutari.FieldName = "lKdvTutari"
        Me.collKdvTutari.Name = "collKdvTutari"
        Me.collKdvTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKdvTutari", "{0:#,0.00}")})
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv Oraný"
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        '
        'collMevcut
        '
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,0.###"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        '
        'colFISSAYISI
        '
        Me.colFISSAYISI.Caption = "Fis"
        Me.colFISSAYISI.FieldName = "FISSAYISI"
        Me.colFISSAYISI.Name = "colFISSAYISI"
        Me.colFISSAYISI.Visible = True
        Me.colFISSAYISI.VisibleIndex = 12
        '
        'colsSINIF
        '
        Me.colsSINIF.Caption = "Sýnýf"
        Me.colsSINIF.FieldName = "sSinif"
        Me.colsSINIF.Name = "colsSINIF"
        Me.colsSINIF.Visible = True
        Me.colsSINIF.VisibleIndex = 13
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
        'ds_Logo_Xml
        '
        Me.ds_Logo_Xml.DataSetName = "SALES_INVOICES"
        Me.ds_Logo_Xml.Tables.AddRange(New System.Data.DataTable() {Me.DataTable7, Me.DataTable8})
        '
        'DataTable7
        '
        Me.DataTable7.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45})
        Me.DataTable7.TableName = "TRANSACTIONS"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "TYPE"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "NUMBER"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "DATE"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "TIME"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "DOC_NUMBER"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ARP_CODE"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "GL_POSTED"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "POST_FLAGS"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "VAT_RATE"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "TOTAL_GROSS"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "TOTAL_NET"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "TC_NET"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "SALESMAN_CODE"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "CURRSEL_TOTALS"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "DATA_REFERENCE"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "TOTAL_VAT"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "DBOP"
        '
        'DataTable8
        '
        Me.DataTable8.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57})
        Me.DataTable8.TableName = "TRANSACTION"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "TYPE"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "MASTER_CODE"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "QUANTITY"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "PRICE"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "UNIT_CODE"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "UNIT_CONV1"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "UNIT_CONV2"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "VAT_RATE"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "VAT_AMOUNT"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "VAT_BASE"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "BILLED"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "TOTAL_NET"
        '
        'frm_stok_satis_karliligi
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
        Me.Name = "frm_stok_satis_karliligi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Satýþ Karlýlýðý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_nSinif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bSiniflandir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Siralama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ds_Logo_Xml, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Dim nFirmaNo = "001"
    Dim nDonemNo = "01"
    Public connection
    Public musterino
    Public kullanici
    Public nStokID As Int64 = 0
    Public islemstatus As Boolean = False
    Dim ds1 As DataSet
    Dim nakit As Decimal = 0
    Dim masraf As Decimal = 0
    Public pos As Boolean = False
    Public nPosIslem As Integer = 0
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If pos = False Then
            If nStokID = 0 Then
                DateEdit1.EditValue = dteSistemTarihi
                DateEdit2.EditValue = dteSistemTarihi
            End If
            dataload_depo()
        Else
            dataload_depo_pos()
        End If
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
        If pos = True Or nStokID <> 0 Then
            ara()
        End If
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub dataload_depo()
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        ds_kasiyer = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sKasiyerRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '') ORDER BY sAdi"))
        ds_kasa = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nKasaNo AS KOD, sAciklama AS ACIKLAMA FROM         tbParekendeKasa"))
        ds_harekettipi = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sHareketTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbHareketTipi WHERE     (sHareketTipi <> '') and (aktif = 1)"))
        ds_fistipi = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sFisTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbFisTipi WHERE     (sFisTipi IN ('CP', 'K', 'KS', 'KVF', 'P', 'PAD', 'PD', 'PTX', 'SK', 'SP','DC','FS'))"))
    End Sub
    Private Sub dataload_depo_pos()
        ds_magaza = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sMagazaKodu AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE sMagazaKodu <> '' and sKullanici = '" & kullanici & "' ORDER BY sMagazaKodu"))
        ds_kasiyer = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sKasiyerRumuzu AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE     (sKasiyerRumuzu <> '') and sKullanici = '" & kullanici & "' ORDER BY sKasiyerRumuzu"))
        ds_kasa = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sKasaNo AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE     (sKasaNo <> '') and sKullanici = '" & kullanici & "' ORDER BY sKasaNo"))
        ds_harekettipi = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sHareketTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbHareketTipi WHERE     (sHareketTipi <> '') and (aktif = 1)"))
        ds_fistipi = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sFisTipi AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE     sFisTipi <>'' and sKullanici = '" & kullanici & "' order by sFisTipi"))
    End Sub
    Private Sub dataload_satislar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal Top As String, ByVal nTop As Integer, ByVal sSiralama As String, ByVal bSiniflandir As Boolean, ByVal nSinifNo As Int64)
        Dim kriter_satis As String = ""
        Dim kriter_odeme As String = ""
        'kriter_satis = " Where tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        kriter_satis = ""
        kriter_odeme = " WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter_satis += " AND tbAlisVeris.nKasaNo IN ( " & kasiyer & " ) "
                kriter_odeme += " AND tbOdeme.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter_satis += " AND tbAlisVeris.sKasiyerRumuzu IN ( " & kasiyer & " ) "
                kriter_odeme += " AND tbOdeme.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter_satis += " AND tbStokFisiDetayi.sDepo IN ( " & sMagaza & " )"
            kriter_odeme += " AND tbOdeme.sMagaza IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter_satis += " AND tbAlisVeris.sHareketTipi IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter_satis += " AND tbStokFisiDetayi.sFisTipi IN ( " & fistipi & " )"
        End If
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter_satis += " AND( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter_satis += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter_satis += " AND (tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
            ElseIf konum = "Geliþmiþ" Then
                kriter_satis += " AND tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") or ( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & " ) "
            ElseIf konum = "Sýnýf1" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf2" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf3" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf4" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf5" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf6" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu WHERE tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf7" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu WHERE tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf8" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf9" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu WHERE tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf10" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif1.sSinifKodu WHERE tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf11" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu WHERE tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf12" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu WHERE tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf13" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu WHERE tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf14" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu WHERE tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf15" Then
                kriter_satis += "AND tbStok.nStokID IN (SELECT     tbStokSinifi.nStokID FROM         tbStokSinifi INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu WHERE tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        Dim satis_eslenik As String = ""
        Dim siparis_eslenik As String = ""
        If nStokID = 0 Then
        Else
            satis_eslenik = " AND tbAlisVeris.nAlisverisID IN (Select nAlisVerisID from tbStokFisiDetayi where nStokID IN (" & nStokID & ") and dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' and nAlisverisID <>'' ) "
            siparis_eslenik = " AND tbAlisVeris.nAlisverisID IN (SELECT     tbAlisVeris.nAlisVerisID FROM         tbAlisVeris INNER JOIN                       tbAlisverisSiparis ON tbAlisVeris.nAlisverisID = tbAlisverisSiparis.nAlisverisID where tbAlisverisSiparis.nStokID IN (" & nStokID & ") and tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "') "
        End If
        Dim sTopkriter As String = ""
        If nTop > 0 Then
            sTopkriter = " TOP " & nTop & " "
        End If
        'NOT     INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID
        If Top = "Ýlk" Then
            If sSiralama = "Miktar" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY SUM(lMiktar) DESC"))
            ElseIf sSiralama = "Tutar" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY SUM(lNetTutar) DESC"))
            ElseIf sSiralama = "Musteri" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY COUNT(DISTINCT nAlisverisID) DESC"))
            ElseIf sSiralama = "Kar" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY SUM(lNetTutar) - SUM(lMaliyet * lMiktar) DESC"))
            End If
        ElseIf Top = "Son" Then
            If sSiralama = "Miktar" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY SUM(lMiktar) ASC"))
            ElseIf sSiralama = "Tutar" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY SUM(lNetTutar) ASC"))
            ElseIf sSiralama = "Musteri" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY COUNT(DISTINCT nAlisverisID) ASC"))
            ElseIf sSiralama = "Kar" Then
                DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " sSinif,nStokID, sKodu, sModel, sBirimCinsi1,sRenk, sRenkAdi, sBeden,nKdvOrani, sStokAciklama, SUM(lMiktar) AS lMiktar, SUM(lIskonto) AS lIskonto, SUM(lNetTutar) AS lNetTutar, SUM(lBrutTutar) AS lBrutTutar, lMaliyet, SUM(lMaliyet * lMiktar) AS lMaliyetTutar, SUM(lNetTutar) - SUM(lMaliyet * lMiktar) AS lKar, SUM(lKdvTutari) as lKdvTutari,SUM(nOran) AS nOran, sBarkod,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbSatis.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,COUNT(DISTINCT nAlisverisID) AS FISSAYISI FROM (SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel ,tbStok.sBirimCinsi1, tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0)) AS lMiktar , SUM(ISNULL(tbStokFisiDetayi.lIskontoTutari , 0)) AS lIskonto , SUM(tbStokFisiDetayi.lCikisTutar * ( tbStokFisiDetayi.nKdvOrani) / 100) AS lKdvTutari,SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar , SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbStok RIGHT OUTER JOIN tbAlisVeris RIGHT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS' OR tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'P' OR tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'Ks' OR tbStokFisiDetayi.sFisTipi = 'PD' OR tbStokFisiDetayi.sFisTipi = 'PTX') " & kriter_satis & satis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sKodu , tbStok.sAciklama , tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi UNION ALL SELECT tbAlisVeris.nAlisverisID , tbSSinif" & nSinifNo & ".sAciklama as sSinif,tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel , tbStok.sBirimCinsi1,tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , tbStok.sAciklama AS sStokAciklama ,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, SUM(tbAlisverisSiparis.lGCMiktar) AS Miktar , SUM(tbAlisverisSiparis.lIskontoTutari) AS lIskonto , SUM(tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani) / 100) AS lKdvTutari,SUM(tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lNetTutar , SUM(tbAlisverisSiparis.lBrutTutar) AS lBrutTutar , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS lMaliyet , CAST(0 AS money) AS lMaliyetTutar , CAST(0 AS Money) AS lKar , CAST(0 AS Money) AS nOran , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif" & nSinifNo & " ON tbStokSinifi.sSinifKodu1" & nSinifNo & " = tbSSinif" & nSinifNo & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "') " & Replace(Replace(kriter_satis, "tbStokFisiDetayi", "tbAlisVeris"), "sDepo", "sMagaza") & siparis_eslenik & " GROUP BY tbAlisVeris.nAlisverisID , tbsSinif" & nSinifNo & ".sAciklama,tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , tbStok.sBirimCinsi1,tbStok.sRenk , tbStok.sBeden,tbStok.sKdvTipi) tbSatis GROUP BY sSinif,nStokID, sModel, sKodu, sStokAciklama, nKdvOrani,sBirimCinsi1,sRenk, sRenkAdi, sBeden, lMaliyet, sBarkod ORDER BY SUM(lNetTutar) - SUM(lMaliyet * lMiktar) ASC"))
            End If
        End If
        Dim dr As DataRow
        bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        bar1.Position = 0
        bar1.Visible = True
        bar1.Refresh()
        Dim lToplamKar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim nYuzdelik As Decimal = 0
        For Each dr In DataSet1.Tables(0).Rows
            Label2.Text = "StokKodu: " & dr("sKodu") & "Adý: " & dr("sStokAciklama")
            Label2.Refresh()
            Try
                dr("nOran") = (dr("lKar") / dr("lMaliyetTutar"))
            Catch ex As Exception
                dr("nOran") = 0
            End Try
            lToplamKar = lToplamKar + sorgu_sayi(dr("lKar"), 0)
            lToplamMaliyet = lToplamMaliyet + sorgu_sayi(dr("lMaliyetTutar"), 0)
            bar1.Position = bar1.Position + 1
            bar1.Refresh()
        Next
        Try
            nYuzdelik = (lToplamKar / lToplamMaliyet) * 100
        Catch ex As Exception
            nYuzdelik = 0
        End Try
        colnOran.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        lToplamKar = Nothing
        lToplamMaliyet = Nothing
        nYuzdelik = Nothing
        dr = Nothing
        bar1.Position = 0
        bar1.Visible = False
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandTimeout = Nothing
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
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += DateEdit1.EditValue.ToLongDateString & " ve " & DateEdit2.EditValue.ToLongDateString & " Tarihleri Arasýndaki Stok Satýþ Karlýlýðý" & vbCrLf
        kriter += "Maðazalar:" & sec_depo.Text & sec_kasatipi.Text & " " & sec_kasakasiyer.Text & " HareketTipi: " & sec_harekettipi.Text & " FiþTipi: " & sec_fistipi.Text
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
    Private Function sorgu_query_logo(ByVal query As String) As String
        query = Replace(query, "*!F", nFirmaNo.ToString)
        query = Replace(query, "!D", nDonemNo.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal Top As String, ByVal nTop As Integer, ByVal sSiralama As String, ByVal bSiniflandir As Boolean, ByVal nSinifNo As Int64)
        DataSet1.Tables(0).Clear()
        dataload_satislar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, ara, konum, ara_kriter, Top, nTop, sSiralama, bSiniflandir, nSinifNo)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub stok_odeme_detay()
        Dim frm As New frm_stok_cari_odeme
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.musterikodu = dr("FIRMAKODU")
        frm.tarih = dr("TARIH")
        frm.belgeno = dr("BELGENO")
        'frm.stokno = dr("ALISVERISNO")
        frm.fistipi = Trim(dr("IZAHAT").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
    End Sub
    Private Sub stok_satis_detay()
        Dim frm As New frm_Perakende_Satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.nAlisVerisID = dr("ALISVERISNO")
        frm.sFisTipi = Trim(dr("IZAHAT").ToString)
        frm.kullanici = kullanici
        frm.sMagaza = dr("MAGAZA")
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
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
        analiz_envanter()
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
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        DataSet1.Tables(0).Clear()
        dataload(DateEdit1.Text, DateEdit2.Text, sec_depo.Text, sec_kasatipi.Text, sec_kasakasiyer.Text, sec_harekettipi.Text, sec_fistipi.Text, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sTop.Text, txt_nTop.EditValue, sec_Siralama.Text, sec_bSiniflandir.Checked, sec_nSinif.EditValue)
        'Dim dr As DataRow
        'For Each dr In DataSet1.Tables(0).Rows
        '    dr("lNakit") = sorgu_AlisVeris_odeme(dr("ALISVERISNO"), 1)
        '    dr("lVisa") = sorgu_AlisVeris_odeme(dr("ALISVERISNO"), 2)
        '    dr("lDiger") = sorgu_AlisVeris_odeme(dr("ALISVERISNO"), 4)
        'Next
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Public Function sorgu_AlisVeris_odeme(ByVal nAlisVerisID As String, ByVal nOdemeTipi As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (tbOdeme.nAlisVerisID = '" & nAlisVerisID & "') AND (tbOdemeSekli.nOdemeTipi = " & nOdemeTipi & ")"
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lTutar FROM         tbOdeme INNER JOIN                       tbOdemeKodu ON tbOdeme.nOdemeKodu = tbOdemeKodu.nOdemeKodu INNER JOIN                       tbOdemeSekli ON tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
    End Function
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        stok_duzelt()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_fistipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_fistipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = sec_grid
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_fistipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_kasakasiyer_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_kasakasiyer.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = sec_grid
        sec_depo.Properties.PopupControl = Nothing
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
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_pdf()
    End Sub

    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        If MenuItem21.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem21.Checked = True
        ElseIf MenuItem21.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem21.Checked = False
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
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
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
            frm.collGirisFiyat.Visible = False
            frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collCikisFiyat.Visible = False
            frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutFiyat.Visible = False
            frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutTutar.Visible = False
            frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
            frm.colnKdvOrani.Visible = False
            frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
            frm.collIskontoTutari.Visible = False
            frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
            frm.colnGirisCikis.Visible = False
            frm.MenuItem16.Enabled = False
            frm.MenuItem17.Enabled = False
            frm.MenuItem20.Enabled = False
            frm.Label1.Text = dr("sStokAciklama") & vbCrLf & frm.Label1.Text
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
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        stok_fiyat()
    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = ds_Logo_Xml.Tables("TRANSACTIONS").NewRow
        dr("TYPE") = "7"
        dr("NUMBER") = "-92004"
        dr("DATE") = DateEdit2.EditValue
        dr("TIME") = "00:00:0"
        dr("DOC_NUMBER") = "-92004"
        dr("ARP_CODE") = "393.01.001"
        dr("GL_POSTED") = "0"
        dr("POST_FLAGS") = ""
        dr("VAT_RATE") = ""
        dr("TOTAL_GROSS") = "510.69"
        dr("TOTAL_NET") = "515.7969"
        dr("TC_NET") = "515.7969"
        dr("SALESMAN_CODE") = "001"
        dr("TOTAL_VAT") = "5.1069"
        dr("CURRSEL_TOTALS") = ""
        dr("DATA_REFERENCE") = ""
        dr("DBOP") = "INS"
        ds_Logo_Xml.Tables("TRANSACTIONS").Rows.Add(dr)
        For Each dr1 In DataSet1.Tables(0).Rows
            dr = ds_Logo_Xml.Tables("TRANSACTION").NewRow
            dr("TYPE") = 0
            dr("MASTER_CODE") = Trim(dr1("sKodu"))
            dr("QUANTITY") = dr1("lMiktar")
            dr("PRICE") = dr1("lNetTutar") / dr1("lMiktar")
            dr("UNIT_CODE") = Trim(dr1("sBirimCinsi1"))
            dr("UNIT_CONV1") = 1
            dr("UNIT_CONV2") = 1
            dr("VAT_RATE") = 1
            dr("VAT_AMOUNT") = dr1("lKdvTutari")
            dr("VAT_BASE") = dr1("lNetTutar") - dr1("lKdvTutari")
            dr("BILLED") = 1
            dr("TOTAL_NET") = dr1("lNetTutar")
            ds_Logo_Xml.Tables("TRANSACTION").Rows.Add(dr)
        Next
        ds_Logo_Xml.WriteXml("c:\Faturalar.xml")
        XtraMessageBox.Show("Dosya Baþarýyla Oluþturuldu..." & vbCrLf & "c:\Faturalar.xml")
        'DG.DataSource = ds_Logo_Xml.Tables("TRANSACTION")
    End Sub

    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        fis_aktar_logo()
    End Sub
    Private Sub fis_aktar_logo()
        Dim frm As New frm_fatura_kopyala
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sFisTipi = "FS "
        frm.nGirisCikis = 3
        frm.kapla = True
        frm.nFirmaID = 0
        frm.sKodu = "393.01.001"
        frm.txt_musteriNo.EditValue = frm.sKodu
        frm.lbl_Firma.Text = ""
        frm.txt_dteFisTarihi1.EditValue = dteSistemTarihi
        frm.bAktar = True
        frm.txt_lFisNo.Text = sayiuzunlukkontrol(1, 6)
        Dim enConnection = connection
        frm.bLogo = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            nFirmaNo = frm.txt_nFirmaNo.Text
            nDonemNo = frm.txt_nDonemNo.Text
            connection = frm.connection
            sConnection = frm.sConnection
            Dim dr As DataRow
            Dim lToplamTutar As Decimal = 27.78
            Dim lToplamKdv As Decimal = 2.22
            Dim lNetTutar As Decimal = 30
            Dim sSaat As String = "00"
            Dim sDakika As String = "00"
            Dim sSaniye As String = "00"
            Dim nSatirNo As Integer = 1
            For Each dr In DataSet1.Tables(0).Rows
                lToplamTutar = lToplamTutar + (dr("lNetTutar") - dr("lKdvTutari"))
                lToplamKdv = lToplamKdv + dr("lKdvTutari")
                lNetTutar = lNetTutar + dr("lNetTutar")
            Next
            Dim tarih As DateTime = frm.txt_dteFisTarihi1.EditValue
            Dim LOGICALREF As Int64 = 0
            Dim CLIENTREF As Int64 = 0
            Dim INVOICEREF As Int64 = 0
            Dim STOCKREF As Int64 = 0
            Dim STFICHEREF As Int64
            Dim ACCOUNTREF As Int64 = 0
            Dim VATACCREF As Int64 = 0
            Dim lMiktar As Decimal = 10
            Dim lFiyat As Decimal = 1
            Dim lTutar As Decimal = 10
            Dim nKdvOrani As Decimal = 8
            Dim lGirisTutar As Decimal = 9.25
            Dim lKdvTutari As Decimal = 0.74
            Dim sKodu As String = "000002"
            Dim sAciklama As String = "EKMEK IKILI"
            Dim sBarcode As String = "000002"
            Dim nAy As Int64 = tarih.Month
            Dim nYil As Int64 = tarih.Year
            sSaat = Now.ToLongTimeString.Substring(0, 2)
            sDakika = Now.ToLongTimeString.Substring(3, 2)
            sSaniye = Now.ToLongTimeString.Substring(6, 2)
            LOGICALREF = sorgula_nStokID(sorgu_query_logo("SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS Expr1 FROM         LG_*!F_!D_INVOICE"))
            'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LASTLREF, 0) + 1 AS LASTREF FROM         LG_*!F_!D_INVOICESEQ"))
            CLIENTREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS CLIENTREF  FROM         LG_*!F_CLCARD WHERE     (CODE = '" & Trim(frm.txt_musteriNo.EditValue) & "')"))
            INVOICEREF = INVOICE_kaydet_yeni(LOGICALREF, 2, 7, LOGICALREF, tarih, 271917385, "", "", "", CLIENTREF, 0, 0, 0, 0, 0, 0, 0, 0, 0, 247, 18, 0, 0, lToplamTutar, 0, 0, 0, 0, 0, 0, lToplamKdv, lToplamTutar, lNetTutar, "", "", "", "", 0, 0, 0, lNetTutar, 1, lNetTutar, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, tarih, sSaat, sDakika, sSaniye, 1, tarih, sSaat, sDakika, sSaniye, 0, 0, "", "", "", 2, 0, "", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, "", 0, 0, 0, 0, 0, 2, 3, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, "", "", 0, 0, 0, 0, "", 0, 0)
            'LASTREF_kaydet_DUZELT(LOGICALREF, sorgu_query_logo("LG_*!F_!D_INVOICESEQ"))
            'INVOICEREF = LOGICALREF
            'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS LOGICALREF FROM         LG_*!F_!D_STFICHE"))
            'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LASTLREF, 0) + 1 AS LASTREF FROM         LG_*!F_!D_STFICHESEQ"))
            STFICHEREF = STFICHE_kaydet_yeni(LOGICALREF, 2, 7, 3, LOGICALREF, tarih, 271917385, "", LOGICALREF, "", "", INVOICEREF, CLIENTREF, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, lToplamTutar, 0, 0, 0, 0, lToplamKdv, lToplamTutar, lNetTutar, "", "", "", "", 1, lNetTutar, 0, 0, 0, 1, 0, 1, tarih, sSaat, sDakika, sSaniye, 1, tarih, sSaat, sDakika, sSaniye, 0, 0, "", "", "", 2, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, "", 0, 0, 0, "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 3, 0, 1, 1, 0, 0)
            'STFICHEREF = LOGICALREF
            'LASTREF_kaydet_DUZELT(LOGICALREF, sorgu_query_logo("LG_*!F_!D_STFICHESEQ"))
            bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
            bar1.Position = 0
            bar1.Visible = True
            bar1.Refresh()
            For Each dr In DataSet1.Tables(0).Rows
                sKodu = Trim(dr("sKodu"))
                sAciklama = Trim(dr("sStokAciklama"))
                nKdvOrani = dr("nKdvOrani")
                lMiktar = dr("lMiktar")
                Try
                    lFiyat = dr("lNetTutar") / dr("lMiktar")
                Catch ex As Exception
                    lFiyat = 0
                End Try
                lTutar = dr("lNetTutar")
                lGirisTutar = dr("lNetTutar") - dr("lKdvTutari")
                lKdvTutari = dr("lKdvTutari")
                'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS LOGICALREF FROM         LG_*!F_!D_STLINE"))
                'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LASTLREF, 0) + 1 AS LASTREF FROM         LG_*!F_!D_STLINESEQ"))
                STOCKREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS STOCKF  FROM         LG_*!F_ITEMS WHERE     (CODE = '" & sKodu & "')"))
                If STOCKREF = 0 Or STOCKREF = 1 Then
                    'STOCKREF = sorgula_nStokID(sorgu_query_logo("SELECT     ISNULL(MAX(LOGICALREF),0)+1  AS LOGICALREF FROM         LG_*!F_ITEMS"))
                    'STOCKREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LASTLREF, 0) + 1 AS LASTREF FROM         LG_*!F_ITEMSSEQ"))
                    'ITEMS_kaydet_yeni(STOCKREF, 0, 1, sKodu, sAciklama, "", "", "", "", 0, 1, 1, 1, nKdvOrani, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 1, tarih, sSaat, sDakika, sSaniye, 1, tarih, sSaat, sDakika, sSaniye, 0, 1, 0, "", 1, 0, 0, 0, 0, 0, "", "", "", 0, 0, 0, 0, 3, 0, 0, nKdvOrani, nKdvOrani, "", 0, "", "", "", 0, 0, 0, 63, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, 0, sBarcode, "", 0, nKdvOrani, nKdvOrani, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, "", "", "", "", 0, "", "", 0, 0, 0, 0, 0, 0, 0)
                    STOCKREF = ITEMS_kaydet_yeni(STOCKREF, 0, 1, sKodu, sAciklama, "", "", "", "", 0, 1, 1, 1, nKdvOrani, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 1, tarih, sSaat, sDakika, sSaniye, 1, tarih, sSaat, sDakika, sSaniye, 0, 1, 0, "", 1, 0, 0, 0, 0, 0, "", "", "", 0, 0, 0, 0, 3, 0, 0, nKdvOrani, nKdvOrani, "", 0, "", "", "", 0, 0, 0, 63, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, 0, sBarcode, "", 0, nKdvOrani, nKdvOrani, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, "", "", "", "", 0, "", "")
                    'LASTREF_kaydet_DUZELT(LOGICALREF, sorgu_query_logo("LG_*!F_ITEMSSEQ"))
                End If
                ACCOUNTREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ACCOUNTREF FROM         LG_*!F_CRDACREF WHERE     (CARDREF = " & STOCKREF & ") AND (TYP = 3)"))
                If nKdvOrani = 1 Then
                    VATACCREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS LOGICALREF FROM         LG_*!F_EMUHACC WHERE     (CODE = '391.01.001')"))
                ElseIf nKdvOrani = 8 Then
                    VATACCREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS LOGICALREF FROM         LG_*!F_EMUHACC WHERE     (CODE = '391.01.002')"))
                ElseIf nKdvOrani = 18 Then
                    VATACCREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS LOGICALREF FROM         LG_*!F_EMUHACC WHERE     (CODE = '391.01.003')"))
                Else
                    VATACCREF = 0 'sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS LOGICALREF FROM         LG_*!F_EMUHACC WHERE     (CODE = '391')"))
                End If
                'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LASTLREF, 0) + 1 AS LASTREF FROM         LG_*!F_!D_STLINESEQ"))
                STLINE_kaydet_yeni(LOGICALREF, STOCKREF, 0, 0, 0, 0, 7, tarih, 271917385, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, STFICHEREF, nSatirNo, INVOICEREF, nSatirNo, CLIENTREF, 0, 0, 0, ACCOUNTREF, VATACCREF, 0, 0, 0, 0, 0, 0, 0, "", "", lMiktar, lFiyat, lTutar, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, "", 23, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, nKdvOrani, lKdvTutari, lGirisTutar, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, lGirisTutar, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, nAy, nYil, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0)
                'LASTREF_kaydet_DUZELT(LOGICALREF, sorgu_query_logo("LG_*!F_!D_STLINESEQ"))
                nSatirNo += 1
                bar1.Position = bar1.Position + 1
                bar1.Refresh()
            Next
            'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS LOGICALREF FROM         LG_*!F_!D_PAYTRANS"))
            'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LASTLREF, 0) + 1 AS LASTREF FROM         LG_*!F_!D_PAYTRANSSEQ"))
            PAYTRANS_kaydet_yeni(LOGICALREF, CLIENTREF, tarih, 4, 0, STFICHEREF, 0, 7, lNetTutar, 0, 0, 0, 0, 0, 0, tarih, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, tarih, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, "", "", "", "", "", "", "", 0)
            'LASTREF_kaydet_DUZELT(LOGICALREF, sorgu_query_logo("LG_*!F_!D_PAYTRANSSEQ"))
            'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS LOGICALREF FROM         LG_*!F_!D_CLFLINE"))
            'LOGICALREF = sorgula_nStokID(sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LASTLREF, 0) + 1 AS LASTREF FROM         LG_*!F_!D_CLFLINESEQ"))
            CLFLINE_kaydet_yeni(LOGICALREF, CLIENTREF, 0, 0, 0, 0, 0, INVOICEREF, tarih, 0, 0, 4, 37, 0, "", "", INVOICEREF, "", "", 0, 0, lNetTutar, 0, 0, lNetTutar, 1, lNetTutar, 0, 0, 0, 0, 1, tarih, sSaat, sDakika, sSaniye, 1, tarih, sSaat, sDakika, sSaat, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", 0, 0, 0, 0, nAy, nYil, 0, 0, 0, 0, 0, 1, 0, 0, "", "", 0, "")
            'LASTREF_kaydet_DUZELT(LOGICALREF, sorgu_query_logo("LG_*!F_!D_CLFLINESEQ"))
            XtraMessageBox.Show("Ýþlem Baþarýyla Tamamlandý...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection = enConnection
            dr = Nothing
        End If
        bar1.Position = 0
        bar1.Visible = False
        connection = enConnection
    End Sub
    Public Function sorgula_nStokID(ByVal query As String) As Int64
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Sub LASTREF_kaydet_DUZELT(ByVal LOGICALREF As Int64, ByVal sTable As String)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    " & sTable & " SET              LASTLREF = " & LOGICALREF & " WHERE ID = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function INVOICE_kaydet_yeni(ByVal LOGICALREF, ByVal GRPCODE, ByVal TRCODE, ByVal FICHENO, ByVal DATE_, ByVal TIME_, ByVal DOCODE, ByVal SPECODE, ByVal CYPHCODE, ByVal CLIENTREF, ByVal RECVREF, ByVal CENTERREF, ByVal ACCOUNTREF, ByVal SOURCEINDEX, ByVal SOURCECOSTGRP, ByVal CANCELLED, ByVal ACCOUNTED, ByVal PAIDINCASH, ByVal FROMKASA, ByVal ENTEGSET, ByVal VAT, ByVal ADDDISCOUNTS, ByVal TOTALDISCOUNTS, ByVal TOTALDISCOUNTED, ByVal ADDEXPENSES, ByVal TOTALEXPENSES, ByVal DISTEXPENSE, ByVal TOTALDEPOZITO, ByVal TOTALPROMOTIONS, ByVal VATINCGROSS, ByVal TOTALVAT, ByVal GROSSTOTAL, ByVal NETTOTAL, ByVal GENEXP1, ByVal GENEXP2, ByVal GENEXP3, ByVal GENEXP4, ByVal INTERESTAPP, ByVal TRCURR, ByVal TRRATE, ByVal TRNET, ByVal REPORTRATE, ByVal REPORTNET, ByVal ONLYONEPAYLINE, ByVal KASTRANSREF, ByVal PAYDEFREF, ByVal PRINTCNT, ByVal GVATINC, ByVal BRANCH, ByVal DEPARTMENT, ByVal ACCFICHEREF, ByVal ADDEXPACCREF, ByVal ADDEXPCENTREF, ByVal DECPRDIFF, ByVal CAPIBLOCK_CREATEDBY, ByVal CAPIBLOCK_CREADEDDATE, ByVal CAPIBLOCK_CREATEDHOUR, ByVal CAPIBLOCK_CREATEDMIN, ByVal CAPIBLOCK_CREATEDSEC, ByVal CAPIBLOCK_MODIFIEDBY, ByVal CAPIBLOCK_MODIFIEDDATE, ByVal CAPIBLOCK_MODIFIEDHOUR, ByVal CAPIBLOCK_MODIFIEDMIN, ByVal CAPIBLOCK_MODIFIEDSEC, ByVal SALESMANREF, ByVal CANCELLEDACC, ByVal SHPTYPCOD, ByVal SHPAGNCOD, ByVal TRACKNR, ByVal GENEXCTYP, ByVal LINEEXCTYP, ByVal TRADINGGRP, ByVal TEXTINC, ByVal SITEID, ByVal RECSTATUS, ByVal ORGLOGICREF, ByVal FACTORYNR, ByVal WFSTATUS, ByVal SHIPINFOREF, ByVal DISTORDERREF, ByVal SENDCNT, ByVal DLVCLIENT, ByVal COSTOFSALEFCREF, ByVal OPSTAT, ByVal DOCTRACKINGNR, ByVal TOTALADDTAX, ByVal PAYMENTTYPE, ByVal INFIDX, ByVal ACCOUNTEDCNT, ByVal ORGLOGOID, ByVal FROMEXIM, ByVal FRGTYPCOD, ByVal EXIMFCTYPE, ByVal FROMORDWITHPAY, ByVal PROJECTREF, ByVal WFLOWCRDREF, ByVal STATUS, ByVal DEDUCTIONPART1, ByVal DEDUCTIONPART2, ByVal TOTALEXADDTAX, ByVal EXACCOUNTED, ByVal FROMBANK, ByVal BNTRANSREF, ByVal AFFECTCOLLATRL, ByVal GRPFIRMTRANS, ByVal AFFECTRISK, ByVal CONTROLINFO, ByVal POSTRANSFERINFO, ByVal TAXFREECHX, ByVal PASSPORTNO, ByVal CREDITCARDNO, ByVal INEFFECTIVECOST, ByVal REFLECTED, ByVal REFLACCFICHEREF, ByVal CANCELLEDREFLACC, ByVal CREDITCARDNUM, ByVal APPROVE, ByVal CANTCREDEDUCT) As Int64
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_INVOICE( GRPCODE, TRCODE, FICHENO, DATE_, TIME_, DOCODE, SPECODE, CYPHCODE, CLIENTREF, RECVREF, CENTERREF, ACCOUNTREF, SOURCEINDEX, SOURCECOSTGRP, CANCELLED, ACCOUNTED, PAIDINCASH, FROMKASA, ENTEGSET, VAT, ADDDISCOUNTS, TOTALDISCOUNTS, TOTALDISCOUNTED, ADDEXPENSES, TOTALEXPENSES, DISTEXPENSE, TOTALDEPOZITO, TOTALPROMOTIONS, VATINCGROSS, TOTALVAT, GROSSTOTAL, NETTOTAL, GENEXP1, GENEXP2, GENEXP3, GENEXP4, INTERESTAPP, TRCURR, TRRATE, TRNET, REPORTRATE, REPORTNET, ONLYONEPAYLINE, KASTRANSREF, PAYDEFREF, PRINTCNT, GVATINC, BRANCH, DEPARTMENT, ACCFICHEREF, ADDEXPACCREF, ADDEXPCENTREF, DECPRDIFF, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SALESMANREF, CANCELLEDACC, SHPTYPCOD, SHPAGNCOD, TRACKNR, GENEXCTYP, LINEEXCTYP, TRADINGGRP, TEXTINC, SITEID, RECSTATUS, ORGLOGICREF, FACTORYNR, WFSTATUS, SHIPINFOREF, DISTORDERREF, SENDCNT, DLVCLIENT, COSTOFSALEFCREF, OPSTAT, DOCTRACKINGNR, TOTALADDTAX, PAYMENTTYPE, INFIDX, ACCOUNTEDCNT, ORGLOGOID, FROMEXIM, FRGTYPCOD, EXIMFCTYPE, FROMORDWITHPAY, PROJECTREF, WFLOWCRDREF, STATUS, DEDUCTIONPART1, DEDUCTIONPART2, TOTALEXADDTAX, EXACCOUNTED, FROMBANK, BNTRANSREF, AFFECTCOLLATRL, GRPFIRMTRANS, AFFECTRISK, CONTROLINFO, POSTRANSFERINFO, TAXFREECHX, PASSPORTNO, CREDITCARDNO, INEFFECTIVECOST, REFLECTED, REFLACCFICHEREF, CANCELLEDREFLACC, CREDITCARDNUM, APPROVE, CANTCREDEDUCT) VALUES (" & GRPCODE & ", " & TRCODE & ", '" & FICHENO & "', '" & DATE_ & "', '" & TIME_ & "', '" & DOCODE & "', '" & SPECODE & "', '" & CYPHCODE & "', " & CLIENTREF & ", " & RECVREF & ", " & CENTERREF & ", " & ACCOUNTREF & ", " & SOURCEINDEX & ", " & SOURCECOSTGRP & ", " & CANCELLED & ", " & ACCOUNTED & ", " & PAIDINCASH & ", " & FROMKASA & ", " & ENTEGSET & ", " & VAT & ", " & ADDDISCOUNTS & ", " & TOTALDISCOUNTS & ", " & TOTALDISCOUNTED & ", " & ADDEXPENSES & ", " & TOTALEXPENSES & ", " & DISTEXPENSE & ", " & TOTALDEPOZITO & ", " & TOTALPROMOTIONS & ", " & VATINCGROSS & ", " & TOTALVAT & ", " & GROSSTOTAL & ", " & NETTOTAL & ", '" & GENEXP1 & "', '" & GENEXP2 & "', '" & GENEXP3 & "', '" & GENEXP4 & "', " & INTERESTAPP & ", " & TRCURR & ", " & TRRATE & ", " & TRNET & ", " & REPORTRATE & ", " & REPORTNET & ", " & ONLYONEPAYLINE & ", " & KASTRANSREF & ", " & PAYDEFREF & ", " & PRINTCNT & ", " & GVATINC & ", " & BRANCH & ", " & DEPARTMENT & ", " & ACCFICHEREF & ", " & ADDEXPACCREF & ", " & ADDEXPCENTREF & ", " & DECPRDIFF & ", " & CAPIBLOCK_CREATEDBY & ", '" & CAPIBLOCK_CREADEDDATE & "' , " & CAPIBLOCK_CREATEDHOUR & ", " & CAPIBLOCK_CREATEDMIN & ", " & CAPIBLOCK_CREATEDSEC & ", " & CAPIBLOCK_MODIFIEDBY & ", '" & CAPIBLOCK_MODIFIEDDATE & "', " & CAPIBLOCK_MODIFIEDHOUR & ", " & CAPIBLOCK_MODIFIEDMIN & ", " & CAPIBLOCK_MODIFIEDSEC & ", " & SALESMANREF & ", " & CANCELLEDACC & ", '" & SHPTYPCOD & "', '" & SHPAGNCOD & "', '" & TRACKNR & "', " & GENEXCTYP & ", " & LINEEXCTYP & ", '" & TRADINGGRP & "', " & TEXTINC & ", " & SITEID & ", " & RECSTATUS & ", " & ORGLOGICREF & ", " & FACTORYNR & ", " & WFSTATUS & ", " & SHIPINFOREF & ", " & DISTORDERREF & ", " & SENDCNT & ", " & DLVCLIENT & ", " & COSTOFSALEFCREF & ", " & OPSTAT & ", '" & DOCTRACKINGNR & "', " & TOTALADDTAX & ", " & PAYMENTTYPE & ", " & INFIDX & ", " & ACCOUNTEDCNT & ", '" & ORGLOGOID & "', " & FROMEXIM & ", '" & FRGTYPCOD & "', " & EXIMFCTYPE & ", " & FROMORDWITHPAY & ", " & PROJECTREF & ", " & WFLOWCRDREF & ", " & STATUS & ", " & DEDUCTIONPART1 & ", " & DEDUCTIONPART2 & ", " & TOTALEXADDTAX & ", " & EXACCOUNTED & ", " & FROMBANK & ", " & BNTRANSREF & ", " & AFFECTCOLLATRL & ", " & GRPFIRMTRANS & ", " & AFFECTRISK & ", " & CONTROLINFO & ", " & POSTRANSFERINFO & ", " & TAXFREECHX & ", '" & PASSPORTNO & "', '" & CREDITCARDNO & "', " & INEFFECTIVECOST & ", " & REFLECTED & ", " & REFLACCFICHEREF & ", " & CANCELLEDREFLACC & ", '" & CREDITCARDNUM & "', " & APPROVE & ", " & CANTCREDEDUCT & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function STFICHE_kaydet_yeni(ByVal LOGICALREF, ByVal GRPCODE, ByVal TRCODE, ByVal IOCODE, ByVal FICHENO, ByVal DATE_, ByVal FTIME, ByVal DOCODE, ByVal INVNO, ByVal SPECODE, ByVal CYPHCODE, ByVal INVOICEREF, ByVal CLIENTREF, ByVal RECVREF, ByVal ACCOUNTREF, ByVal CENTERREF, ByVal PRODORDERREF, ByVal PORDERFICHENO, ByVal SOURCETYPE, ByVal SOURCEINDEX, ByVal SOURCEWSREF, ByVal SOURCEPOLNREF, ByVal SOURCECOSTGRP, ByVal DESTTYPE, ByVal DESTINDEX, ByVal DESTWSREF, ByVal DESTPOLNREF, ByVal DESTCOSTGRP, ByVal FACTORYNR, ByVal BRANCH, ByVal DEPARTMENT, ByVal COMPBRANCH, ByVal COMPDEPARTMENT, ByVal COMPFACTORY, ByVal PRODSTAT, ByVal DEVIR, ByVal CANCELLED, ByVal BILLED, ByVal ACCOUNTED, ByVal UPDCURR, ByVal INUSE, ByVal INVKIND, ByVal ADDDISCOUNTS, ByVal TOTALDISCOUNTS, ByVal TOTALDISCOUNTED, ByVal ADDEXPENSES, ByVal TOTALEXPENSES, ByVal TOTALDEPOZITO, ByVal TOTALPROMOTIONS, ByVal TOTALVAT, ByVal GROSSTOTAL, ByVal NETTOTAL, ByVal GENEXP1, ByVal GENEXP2, ByVal GENEXP3, ByVal GENEXP4, ByVal REPORTRATE, ByVal REPORTNET, ByVal EXTENREF, ByVal PAYDEFREF, ByVal PRINTCNT, ByVal FICHECNT, ByVal ACCFICHEREF, ByVal CAPIBLOCK_CREATEDBY, ByVal CAPIBLOCK_CREADEDDATE, ByVal CAPIBLOCK_CREATEDHOUR, ByVal CAPIBLOCK_CREATEDMIN, ByVal CAPIBLOCK_CREATEDSEC, ByVal CAPIBLOCK_MODIFIEDBY, ByVal CAPIBLOCK_MODIFIEDDATE, ByVal CAPIBLOCK_MODIFIEDHOUR, ByVal CAPIBLOCK_MODIFIEDMIN, ByVal CAPIBLOCK_MODIFIEDSEC, ByVal SALESMANREF, ByVal CANCELLEDACC, ByVal SHPTYPCOD, ByVal SHPAGNCOD, ByVal TRACKNR, ByVal GENEXCTYP, ByVal LINEEXCTYP, ByVal TRADINGGRP, ByVal TEXTINC, ByVal SITEID, ByVal RECSTATUS, ByVal ORGLOGICREF, ByVal WFSTATUS, ByVal SHIPINFOREF, ByVal DISTORDERREF, ByVal SENDCNT, ByVal DLVCLIENT, ByVal DOCTRACKINGNR, ByVal ADDTAXCALC, ByVal TOTALADDTAX, ByVal UGIRTRACKINGNO, ByVal QPRODFCREF, ByVal VAACCREF, ByVal VACENTERREF, ByVal ORGLOGOID, ByVal FROMEXIM, ByVal FRGTYPCOD, ByVal TRCURR, ByVal TRRATE, ByVal TRNET, ByVal EXIMWHFCREF, ByVal EXIMFCTYPE, ByVal MAINSTFCREF, ByVal FROMORDWITHPAY, ByVal PROJECTREF, ByVal WFLOWCRDREF, ByVal STATUS, ByVal UPDTRCURR, ByVal TOTALEXADDTAX, ByVal AFFECTCOLLATRL, ByVal DEDUCTIONPART1, ByVal DEDUCTIONPART2, ByVal GRPFIRMTRANS, ByVal AFFECTRISK, ByVal DISPSTATUS, ByVal APPROVE, ByVal CANTCREDEDUCT) As Int64
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_STFICHE( GRPCODE, TRCODE, IOCODE, FICHENO, DATE_, FTIME, DOCODE, INVNO, SPECODE, CYPHCODE, INVOICEREF, CLIENTREF, RECVREF, ACCOUNTREF, CENTERREF, PRODORDERREF, PORDERFICHENO, SOURCETYPE, SOURCEINDEX, SOURCEWSREF, SOURCEPOLNREF, SOURCECOSTGRP, DESTTYPE, DESTINDEX, DESTWSREF, DESTPOLNREF, DESTCOSTGRP, FACTORYNR, BRANCH, DEPARTMENT, COMPBRANCH, COMPDEPARTMENT, COMPFACTORY, PRODSTAT, DEVIR, CANCELLED, BILLED, ACCOUNTED, UPDCURR, INUSE, INVKIND, ADDDISCOUNTS, TOTALDISCOUNTS, TOTALDISCOUNTED, ADDEXPENSES, TOTALEXPENSES, TOTALDEPOZITO, TOTALPROMOTIONS, TOTALVAT, GROSSTOTAL, NETTOTAL, GENEXP1, GENEXP2, GENEXP3, GENEXP4, REPORTRATE, REPORTNET, EXTENREF, PAYDEFREF, PRINTCNT, FICHECNT, ACCFICHEREF, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SALESMANREF, CANCELLEDACC, SHPTYPCOD, SHPAGNCOD, TRACKNR, GENEXCTYP, LINEEXCTYP, TRADINGGRP, TEXTINC, SITEID, RECSTATUS, ORGLOGICREF, WFSTATUS, SHIPINFOREF, DISTORDERREF, SENDCNT, DLVCLIENT, DOCTRACKINGNR, ADDTAXCALC, TOTALADDTAX, UGIRTRACKINGNO, QPRODFCREF, VAACCREF, VACENTERREF, ORGLOGOID, FROMEXIM, FRGTYPCOD, TRCURR, TRRATE, TRNET, EXIMWHFCREF, EXIMFCTYPE, MAINSTFCREF, FROMORDWITHPAY, PROJECTREF, WFLOWCRDREF, STATUS, UPDTRCURR, TOTALEXADDTAX, AFFECTCOLLATRL, DEDUCTIONPART1, DEDUCTIONPART2, GRPFIRMTRANS, AFFECTRISK, DISPSTATUS, APPROVE, CANTCREDEDUCT) VALUES ( " & GRPCODE & "," & TRCODE & ", " & IOCODE & ", '" & FICHENO & "', '" & DATE_ & "', " & FTIME & ", '" & DOCODE & "', '" & INVNO & "', '" & SPECODE & "', '" & CYPHCODE & "', " & INVOICEREF & ", " & CLIENTREF & ", " & RECVREF & ", " & ACCOUNTREF & ", " & CENTERREF & ", " & PRODORDERREF & ", '" & PORDERFICHENO & "', " & SOURCETYPE & ", " & SOURCEINDEX & ", " & SOURCEWSREF & ", " & SOURCEPOLNREF & ", " & SOURCECOSTGRP & ", " & DESTTYPE & ", " & DESTINDEX & ", " & DESTWSREF & ", " & DESTPOLNREF & ", " & DESTCOSTGRP & ", " & FACTORYNR & ", " & BRANCH & ", " & DEPARTMENT & ", " & COMPBRANCH & ", " & COMPDEPARTMENT & ", " & COMPFACTORY & ", " & PRODSTAT & ", " & DEVIR & ", " & CANCELLED & ", " & BILLED & ", " & ACCOUNTED & ", " & UPDCURR & ", " & INUSE & ", " & INVKIND & ", " & ADDDISCOUNTS & ", " & TOTALDISCOUNTS & ", " & TOTALDISCOUNTED & ", " & ADDEXPENSES & ", " & TOTALEXPENSES & ", " & TOTALDEPOZITO & ", " & TOTALPROMOTIONS & ", " & TOTALVAT & ", " & GROSSTOTAL & ", " & NETTOTAL & ", '" & GENEXP1 & "', '" & GENEXP2 & "', '" & GENEXP3 & "', '" & GENEXP4 & "', " & REPORTRATE & ", " & REPORTNET & ", " & EXTENREF & ", " & PAYDEFREF & ", " & PRINTCNT & ", " & FICHECNT & ", " & ACCFICHEREF & ", " & CAPIBLOCK_CREATEDBY & ", '" & CAPIBLOCK_CREADEDDATE & "', " & CAPIBLOCK_CREATEDHOUR & ", " & CAPIBLOCK_CREATEDMIN & ", " & CAPIBLOCK_CREATEDSEC & ", " & CAPIBLOCK_MODIFIEDBY & ", '" & CAPIBLOCK_MODIFIEDDATE & "', " & CAPIBLOCK_MODIFIEDHOUR & ", " & CAPIBLOCK_MODIFIEDMIN & ", " & CAPIBLOCK_MODIFIEDSEC & ", " & SALESMANREF & ", " & CANCELLEDACC & ", '" & SHPTYPCOD & "', '" & SHPAGNCOD & "', '" & TRACKNR & "', " & GENEXCTYP & ", " & LINEEXCTYP & ", '" & TRADINGGRP & "', " & TEXTINC & ", " & SITEID & ", " & RECSTATUS & ", " & ORGLOGICREF & ", " & WFSTATUS & ", " & SHIPINFOREF & ", " & DISTORDERREF & ", " & SENDCNT & ", " & DLVCLIENT & ", '" & DOCTRACKINGNR & "', " & ADDTAXCALC & ", " & TOTALADDTAX & ", '" & UGIRTRACKINGNO & "', " & QPRODFCREF & ", " & VAACCREF & ", " & VACENTERREF & ", '" & ORGLOGOID & "', " & FROMEXIM & ", '" & FRGTYPCOD & "', " & TRCURR & ", " & TRRATE & ", " & TRNET & ", " & EXIMWHFCREF & ", " & EXIMFCTYPE & ", " & MAINSTFCREF & ", " & FROMORDWITHPAY & ", " & PROJECTREF & ", " & WFLOWCRDREF & ", " & STATUS & ", " & UPDTRCURR & ", " & TOTALEXADDTAX & ", " & AFFECTCOLLATRL & ", " & DEDUCTIONPART1 & ", " & DEDUCTIONPART2 & ", " & GRPFIRMTRANS & ", " & AFFECTRISK & ", " & DISPSTATUS & ", " & APPROVE & ", " & CANTCREDEDUCT & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function STLINE_kaydet_yeni(ByVal LOGICALREF, ByVal STOCKREF, ByVal LINETYPE, ByVal PREVLINEREF, ByVal PREVLINENO, ByVal DETLINE, ByVal TRCODE, ByVal DATE_, ByVal FTIME, ByVal GLOBTRANS, ByVal CALCTYPE, ByVal PRODORDERREF, ByVal SOURCETYPE, ByVal SOURCEINDEX, ByVal SOURCECOSTGRP, ByVal SOURCEWSREF, ByVal SOURCEPOLNREF, ByVal DESTTYPE, ByVal DESTINDEX, ByVal DESTCOSTGRP, ByVal DESTWSREF, ByVal DESTPOLNREF, ByVal FACTORYNR, ByVal IOCODE, ByVal STFICHEREF, ByVal STFICHELNNO, ByVal INVOICEREF, ByVal INVOICELNNO, ByVal CLIENTREF, ByVal ORDTRANSREF, ByVal ORDFICHEREF, ByVal CENTERREF, ByVal ACCOUNTREF, ByVal VATACCREF, ByVal VATCENTERREF, ByVal PRACCREF, ByVal PRCENTERREF, ByVal PRVATACCREF, ByVal PRVATCENREF, ByVal PROMREF, ByVal PAYDEFREF, ByVal SPECODE, ByVal DELVRYCODE, ByVal AMOUNT, ByVal PRICE, ByVal TOTAL, ByVal PRCURR, ByVal PRPRICE, ByVal TRCURR, ByVal TRRATE, ByVal REPORTRATE, ByVal DISTCOST, ByVal DISTDISC, ByVal DISTEXP, ByVal DISTPROM, ByVal DISCPER, ByVal LINEEXP, ByVal UOMREF, ByVal USREF, ByVal UINFO1, ByVal UINFO2, ByVal UINFO3, ByVal UINFO4, ByVal UINFO5, ByVal UINFO6, ByVal UINFO7, ByVal UINFO8, ByVal PLNAMOUNT, ByVal VATINC, ByVal VAT, ByVal VATAMNT, ByVal VATMATRAH, ByVal BILLEDITEM, ByVal BILLED, ByVal CPSTFLAG, ByVal RETCOSTTYPE, ByVal SOURCELINK, ByVal RETCOST, ByVal RETCOSTCURR, ByVal OUTCOST, ByVal OUTCOSTCURR, ByVal RETAMOUNT, ByVal FAREGREF, ByVal FAATTRIB, ByVal CANCELLED, ByVal LINENET, ByVal DISTADDEXP, ByVal FADACCREF, ByVal FADCENTERREF, ByVal FARACCREF, ByVal FARCENTERREF, ByVal DIFFPRICE, ByVal DIFFPRCOST, ByVal DECPRDIFF, ByVal LPRODSTAT, ByVal PRDEXPTOTAL, ByVal DIFFREPPRICE, ByVal DIFFPRCRCOST, ByVal SALESMANREF, ByVal FAPLACCREF, ByVal FAPLCENTERREF, ByVal OUTPUTIDCODE, ByVal DREF, ByVal COSTRATE, ByVal XPRICEUPD, ByVal XPRICE, ByVal XREPRATE, ByVal DISTCOEF, ByVal TRANSQCOK, ByVal SITEID, ByVal RECSTATUS, ByVal ORGLOGICREF, ByVal WFSTATUS, ByVal POLINEREF, ByVal PLNSTTRANSREF, ByVal NETDISCFLAG, ByVal NETDISCPERC, ByVal NETDISCAMNT, ByVal VATCALCDIFF, ByVal CONDITIONREF, ByVal DISTORDERREF, ByVal DISTORDLINEREF, ByVal CAMPAIGNREFS1, ByVal CAMPAIGNREFS2, ByVal CAMPAIGNREFS3, ByVal CAMPAIGNREFS4, ByVal CAMPAIGNREFS5, ByVal POINTCAMPREF, ByVal CAMPPOINT, ByVal PROMCLASITEMREF, ByVal CMPGLINEREF, ByVal PLNSTTRANSPERNR, ByVal PORDCLSPLNAMNT, ByVal VENDCOMM, ByVal PREVIOUSOUTCOST, ByVal COSTOFSALEACCREF, ByVal PURCHACCREF, ByVal COSTOFSALECNTREF, ByVal PURCHCENTREF, ByVal PREVOUTCOSTCURR, ByVal ABVATAMOUNT, ByVal ABVATSTATUS, ByVal PRRATE, ByVal ADDTAXRATE, ByVal ADDTAXCONVFACT, ByVal ADDTAXAMOUNT, ByVal ADDTAXPRCOST, ByVal ADDTAXRETCOST, ByVal ADDTAXRETCOSTCURR, ByVal GROSSUINFO1, ByVal GROSSUINFO2, ByVal ADDTAXPRCOSTCURR, ByVal ADDTAXACCREF, ByVal ADDTAXCENTERREF, ByVal ADDTAXAMNTISUPD, ByVal INFIDX, ByVal ADDTAXCOSACCREF, ByVal ADDTAXCOSCNTREF, ByVal PREVIOUSATAXPRCOST, ByVal PREVATAXPRCOSTCURR, ByVal PRDORDTOTCOEF, ByVal DEMPEGGEDAMNT, ByVal STDUNITCOST, ByVal STDRPUNITCOST, ByVal COSTDIFFACCREF, ByVal COSTDIFFCENREF, ByVal TEXTINC, ByVal ADDTAXDISCAMOUNT, ByVal ORGLOGOID, ByVal EXIMFICHENO, ByVal EXIMFCTYPE, ByVal TRANSEXPLINE, ByVal INSEXPLINE, ByVal EXIMWHFCREF, ByVal EXIMWHLNREF, ByVal EXIMFILEREF, ByVal EXIMPROCNR, ByVal EISRVDSTTYP, ByVal MAINSTLNREF, ByVal MADEOFSHRED, ByVal FROMORDWITHPAY, ByVal PROJECTREF, ByVal STATUS, ByVal DORESERVE, ByVal POINTCAMPREFS1, ByVal POINTCAMPREFS2, ByVal POINTCAMPREFS3, ByVal POINTCAMPREFS4, ByVal CAMPPOINTS1, ByVal CAMPPOINTS2, ByVal CAMPPOINTS3, ByVal CAMPPOINTS4, ByVal CMPGLINEREFS1, ByVal CMPGLINEREFS2, ByVal CMPGLINEREFS3, ByVal CMPGLINEREFS4, ByVal PRCLISTREF, ByVal PORDSYMOUTLN, ByVal MONTH_, ByVal YEAR_, ByVal EXADDTAXRATE, ByVal EXADDTAXCONVF, ByVal EXADDTAXAREF, ByVal EXADDTAXCREF, ByVal OTHRADDTAXAREF, ByVal OTHRADDTAXCREF, ByVal EXADDTAXAMNT, ByVal AFFECTCOLLATRL, ByVal ALTPROMFLAG, ByVal EIDISTFLNNR, ByVal EXIMTYPE, ByVal VARIANTREF, ByVal CANDEDUCT, ByVal OUTREMAMNT, ByVal OUTREMCOST, ByVal OUTREMCOSTCURR, ByVal REFLVATACCREF, ByVal REFLVATOTHACCREF, ByVal PARENTLNREF, ByVal AFFECTRISK, ByVal INEFFECTIVECOST, ByVal ADDTAXVATMATRAH, ByVal REFLACCREF, ByVal REFLOTHACCREF) As Int64
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_STLINE( STOCKREF, LINETYPE, PREVLINEREF, PREVLINENO, DETLINE, TRCODE, DATE_, FTIME, GLOBTRANS, CALCTYPE, PRODORDERREF, SOURCETYPE, SOURCEINDEX, SOURCECOSTGRP, SOURCEWSREF, SOURCEPOLNREF, DESTTYPE, DESTINDEX, DESTCOSTGRP, DESTWSREF, DESTPOLNREF, FACTORYNR, IOCODE, STFICHEREF, STFICHELNNO, INVOICEREF, INVOICELNNO, CLIENTREF, ORDTRANSREF, ORDFICHEREF, CENTERREF, ACCOUNTREF, VATACCREF, VATCENTERREF, PRACCREF, PRCENTERREF, PRVATACCREF, PRVATCENREF, PROMREF, PAYDEFREF, SPECODE, DELVRYCODE, AMOUNT, PRICE, TOTAL, PRCURR, PRPRICE, TRCURR, TRRATE, REPORTRATE, DISTCOST, DISTDISC, DISTEXP, DISTPROM, DISCPER, LINEEXP, UOMREF, USREF, UINFO1, UINFO2, UINFO3, UINFO4, UINFO5, UINFO6, UINFO7, UINFO8, PLNAMOUNT, VATINC, VAT, VATAMNT, VATMATRAH, BILLEDITEM, BILLED, CPSTFLAG, RETCOSTTYPE, SOURCELINK, RETCOST, RETCOSTCURR, OUTCOST, OUTCOSTCURR, RETAMOUNT, FAREGREF, FAATTRIB, CANCELLED, LINENET, DISTADDEXP, FADACCREF, FADCENTERREF, FARACCREF, FARCENTERREF, DIFFPRICE, DIFFPRCOST, DECPRDIFF, LPRODSTAT, PRDEXPTOTAL, DIFFREPPRICE, DIFFPRCRCOST, SALESMANREF, FAPLACCREF, FAPLCENTERREF, OUTPUTIDCODE, DREF, COSTRATE, XPRICEUPD, XPRICE, XREPRATE, DISTCOEF, TRANSQCOK, SITEID, RECSTATUS, ORGLOGICREF, WFSTATUS, POLINEREF, PLNSTTRANSREF, NETDISCFLAG, NETDISCPERC, NETDISCAMNT, VATCALCDIFF, CONDITIONREF, DISTORDERREF, DISTORDLINEREF, CAMPAIGNREFS1, CAMPAIGNREFS2, CAMPAIGNREFS3, CAMPAIGNREFS4, CAMPAIGNREFS5, POINTCAMPREF, CAMPPOINT, PROMCLASITEMREF, CMPGLINEREF, PLNSTTRANSPERNR, PORDCLSPLNAMNT, VENDCOMM, PREVIOUSOUTCOST, COSTOFSALEACCREF, PURCHACCREF, COSTOFSALECNTREF, PURCHCENTREF, PREVOUTCOSTCURR, ABVATAMOUNT, ABVATSTATUS, PRRATE, ADDTAXRATE, ADDTAXCONVFACT, ADDTAXAMOUNT, ADDTAXPRCOST, ADDTAXRETCOST, ADDTAXRETCOSTCURR, GROSSUINFO1, GROSSUINFO2, ADDTAXPRCOSTCURR, ADDTAXACCREF, ADDTAXCENTERREF, ADDTAXAMNTISUPD, INFIDX, ADDTAXCOSACCREF, ADDTAXCOSCNTREF, PREVIOUSATAXPRCOST, PREVATAXPRCOSTCURR, PRDORDTOTCOEF, DEMPEGGEDAMNT, STDUNITCOST, STDRPUNITCOST, COSTDIFFACCREF, COSTDIFFCENREF, TEXTINC, ADDTAXDISCAMOUNT, ORGLOGOID, EXIMFICHENO, EXIMFCTYPE, TRANSEXPLINE, INSEXPLINE, EXIMWHFCREF, EXIMWHLNREF, EXIMFILEREF, EXIMPROCNR, EISRVDSTTYP, MAINSTLNREF, MADEOFSHRED, FROMORDWITHPAY, PROJECTREF, STATUS, DORESERVE, POINTCAMPREFS1, POINTCAMPREFS2, POINTCAMPREFS3, POINTCAMPREFS4, CAMPPOINTS1, CAMPPOINTS2, CAMPPOINTS3, CAMPPOINTS4, CMPGLINEREFS1, CMPGLINEREFS2, CMPGLINEREFS3, CMPGLINEREFS4, PRCLISTREF, PORDSYMOUTLN, MONTH_, YEAR_, EXADDTAXRATE, EXADDTAXCONVF, EXADDTAXAREF, EXADDTAXCREF, OTHRADDTAXAREF, OTHRADDTAXCREF, EXADDTAXAMNT, AFFECTCOLLATRL, ALTPROMFLAG, EIDISTFLNNR, EXIMTYPE, VARIANTREF, CANDEDUCT, OUTREMAMNT, OUTREMCOST, OUTREMCOSTCURR, REFLVATACCREF, REFLVATOTHACCREF, PARENTLNREF, AFFECTRISK, INEFFECTIVECOST, ADDTAXVATMATRAH, REFLACCREF, REFLOTHACCREF) VALUES ( " & STOCKREF & " , " & LINETYPE & " , " & PREVLINEREF & " , " & PREVLINENO & " , " & DETLINE & " , " & TRCODE & " , " & DATE_ & " , " & FTIME & " , " & GLOBTRANS & " , " & CALCTYPE & " , " & PRODORDERREF & " , " & SOURCETYPE & " , " & SOURCEINDEX & " , " & SOURCECOSTGRP & " , " & SOURCEWSREF & " , " & SOURCEPOLNREF & " , " & DESTTYPE & " , " & DESTINDEX & " , " & DESTCOSTGRP & " , " & DESTWSREF & " , " & DESTPOLNREF & " , " & FACTORYNR & " , " & IOCODE & " , " & STFICHEREF & " , " & STFICHELNNO & " , " & INVOICEREF & " , " & INVOICELNNO & " , " & CLIENTREF & " , " & ORDTRANSREF & " , " & ORDFICHEREF & " , " & CENTERREF & " , " & ACCOUNTREF & " , " & VATACCREF & " , " & VATCENTERREF & " , " & PRACCREF & " , " & PRCENTERREF & " , " & PRVATACCREF & " , " & PRVATCENREF & " , " & PROMREF & " , " & PAYDEFREF & " , '" & SPECODE & "' , '" & DELVRYCODE & "' , " & AMOUNT & " , " & PRICE & " , " & TOTAL & " , " & PRCURR & " , " & PRPRICE & " , " & TRCURR & " , " & TRRATE & " , " & REPORTRATE & " , " & DISTCOST & " , " & DISTDISC & " , " & DISTEXP & " , " & DISTPROM & " , " & DISCPER & " , '" & LINEEXP & "' , " & UOMREF & " , " & USREF & " , " & UINFO1 & " , " & UINFO2 & " , " & UINFO3 & " , " & UINFO4 & " , " & UINFO5 & " , " & UINFO6 & " , " & UINFO7 & " , " & UINFO8 & " , " & PLNAMOUNT & " , " & VATINC & " , " & VAT & " , " & VATAMNT & " , " & VATMATRAH & " , " & BILLEDITEM & " , " & BILLED & " , " & CPSTFLAG & " , " & RETCOSTTYPE & " , " & SOURCELINK & " , " & RETCOST & " , " & RETCOSTCURR & " , " & OUTCOST & " , " & OUTCOSTCURR & " , " & RETAMOUNT & " , " & FAREGREF & " , " & FAATTRIB & " , " & CANCELLED & " , " & LINENET & " , " & DISTADDEXP & " , " & FADACCREF & " , " & FADCENTERREF & " , " & FARACCREF & " , " & FARCENTERREF & " , " & DIFFPRICE & " , " & DIFFPRCOST & " , " & DECPRDIFF & " , " & LPRODSTAT & " , " & PRDEXPTOTAL & " , " & DIFFREPPRICE & " , " & DIFFPRCRCOST & " , " & SALESMANREF & " , " & FAPLACCREF & " , " & FAPLCENTERREF & " , '" & OUTPUTIDCODE & "' , " & DREF & " , " & COSTRATE & " , " & XPRICEUPD & " , " & XPRICE & " , " & XREPRATE & " , " & DISTCOEF & " , " & TRANSQCOK & " , " & SITEID & " , " & RECSTATUS & " , " & ORGLOGICREF & " , " & WFSTATUS & " , " & POLINEREF & " , " & PLNSTTRANSREF & " , " & NETDISCFLAG & " , " & NETDISCPERC & " , " & NETDISCAMNT & " , " & VATCALCDIFF & " , " & CONDITIONREF & " , " & DISTORDERREF & " , " & DISTORDLINEREF & " , " & CAMPAIGNREFS1 & " , " & CAMPAIGNREFS2 & " , " & CAMPAIGNREFS3 & " , " & CAMPAIGNREFS4 & " , " & CAMPAIGNREFS5 & " , " & POINTCAMPREF & " , " & CAMPPOINT & " , " & PROMCLASITEMREF & " , " & CMPGLINEREF & " , " & PLNSTTRANSPERNR & " , " & PORDCLSPLNAMNT & " , " & VENDCOMM & " , " & PREVIOUSOUTCOST & " , " & COSTOFSALEACCREF & " , " & PURCHACCREF & " , " & COSTOFSALECNTREF & " , " & PURCHCENTREF & " , " & PREVOUTCOSTCURR & " , " & ABVATAMOUNT & " , " & ABVATSTATUS & " , " & PRRATE & " , " & ADDTAXRATE & " , " & ADDTAXCONVFACT & " , " & ADDTAXAMOUNT & " , " & ADDTAXPRCOST & " , " & ADDTAXRETCOST & " , " & ADDTAXRETCOSTCURR & " , " & GROSSUINFO1 & " , " & GROSSUINFO2 & " , " & ADDTAXPRCOSTCURR & " , " & ADDTAXACCREF & " , " & ADDTAXCENTERREF & " , " & ADDTAXAMNTISUPD & " , " & INFIDX & " , " & ADDTAXCOSACCREF & " , " & ADDTAXCOSCNTREF & " , " & PREVIOUSATAXPRCOST & " , " & PREVATAXPRCOSTCURR & " , " & PRDORDTOTCOEF & " , " & DEMPEGGEDAMNT & " , " & STDUNITCOST & " , " & STDRPUNITCOST & " , " & COSTDIFFACCREF & " , " & COSTDIFFCENREF & " , " & TEXTINC & " , " & ADDTAXDISCAMOUNT & " , '" & ORGLOGOID & "' , '" & EXIMFICHENO & "' , " & EXIMFCTYPE & " , " & TRANSEXPLINE & " , " & INSEXPLINE & " , " & EXIMWHFCREF & " , " & EXIMWHLNREF & " , " & EXIMFILEREF & " , " & EXIMPROCNR & " , " & EISRVDSTTYP & " , " & MAINSTLNREF & " , " & MADEOFSHRED & " , " & FROMORDWITHPAY & " , " & PROJECTREF & " , " & STATUS & " , " & DORESERVE & " , " & POINTCAMPREFS1 & " , " & POINTCAMPREFS2 & " , " & POINTCAMPREFS3 & " , " & POINTCAMPREFS4 & " , " & CAMPPOINTS1 & " , " & CAMPPOINTS2 & " , " & CAMPPOINTS3 & " , " & CAMPPOINTS4 & " , " & CMPGLINEREFS1 & " , " & CMPGLINEREFS2 & " , " & CMPGLINEREFS3 & " , " & CMPGLINEREFS4 & " , " & PRCLISTREF & " , " & PORDSYMOUTLN & " , " & MONTH_ & " , " & YEAR_ & " , " & EXADDTAXRATE & " , " & EXADDTAXCONVF & " , " & EXADDTAXAREF & " , " & EXADDTAXCREF & " , " & OTHRADDTAXAREF & " , " & OTHRADDTAXCREF & " , " & EXADDTAXAMNT & " , " & AFFECTCOLLATRL & " , " & ALTPROMFLAG & " , " & EIDISTFLNNR & " , " & EXIMTYPE & " , " & VARIANTREF & " , " & CANDEDUCT & " , " & OUTREMAMNT & " , " & OUTREMCOST & " , " & OUTREMCOSTCURR & " , " & REFLVATACCREF & " , " & REFLVATOTHACCREF & " , " & PARENTLNREF & " , " & AFFECTRISK & " , " & INEFFECTIVECOST & " , " & ADDTAXVATMATRAH & " , " & REFLACCREF & " , " & REFLOTHACCREF & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function PAYTRANS_kaydet_yeni(ByVal LOGICALREF, ByVal CARDREF, ByVal DATE_, ByVal MODULENR, ByVal SIGN, ByVal FICHEREF, ByVal FICHELINEREF, ByVal TRCODE, ByVal TOTAL, ByVal PAID, ByVal EARLYINTRATE, ByVal LATELYINTRATE, ByVal CROSSREF, ByVal PAIDINCASH, ByVal CANCELLED, ByVal PROCDATE, ByVal TRCURR, ByVal TRRATE, ByVal REPORTRATE, ByVal MODIFIED, ByVal REMINDLEV, ByVal REMINDSENT, ByVal CROSSCURR, ByVal CROSSTOTAL, ByVal DISCFLAG, ByVal SITEID, ByVal ORGLOGICREF, ByVal WFSTATUS, ByVal CLOSINGRATE, ByVal DISCDUEDATE, ByVal OPSTAT, ByVal RECSTATUS, ByVal INFIDX, ByVal PAYNO, ByVal DELAYTOTAL, ByVal LASTSENDREMLEV, ByVal POINTTRANS, ByVal POSCOMSN, ByVal POINTCOMSN, ByVal BANKACCREF, ByVal PAYMENTTYPE, ByVal CASHACCREF, ByVal TRNET, ByVal REPAYPLANREF, ByVal DUEDIFFCOMSN, ByVal CALCTYPE, ByVal NETTOTAL, ByVal REPYPLNAPPLIED, ByVal PAYTRCURR, ByVal PAYTRRATE, ByVal PAYTRNET, ByVal BNTRCREATED, ByVal BNFCHREF, ByVal BNFLNREF, ByVal INSTALTYPE, ByVal INSTALREF, ByVal MAININSTALREF, ByVal ORGLOGOID, ByVal STLINEREF, ByVal SPECODE, ByVal CREDITCARDNUM, ByVal RETREFNO, ByVal DOCODE, ByVal BATCHNUM, ByVal APPROVENUM, ByVal POSTERMINALNUM, ByVal CLDIFFINV) As Int64
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_PAYTRANS( CARDREF, DATE_, MODULENR, SIGN, FICHEREF, FICHELINEREF, TRCODE, TOTAL, PAID, EARLYINTRATE, LATELYINTRATE, CROSSREF, PAIDINCASH, CANCELLED, PROCDATE, TRCURR, TRRATE, REPORTRATE, MODIFIED, REMINDLEV, REMINDSENT, CROSSCURR, CROSSTOTAL, DISCFLAG, SITEID, ORGLOGICREF, WFSTATUS, CLOSINGRATE, DISCDUEDATE, OPSTAT, RECSTATUS, INFIDX, PAYNO, DELAYTOTAL, LASTSENDREMLEV, POINTTRANS, POSCOMSN, POINTCOMSN, BANKACCREF, PAYMENTTYPE, CASHACCREF, TRNET, REPAYPLANREF, DUEDIFFCOMSN, CALCTYPE, NETTOTAL, REPYPLNAPPLIED, PAYTRCURR, PAYTRRATE, PAYTRNET, BNTRCREATED, BNFCHREF, BNFLNREF, INSTALTYPE, INSTALREF, MAININSTALREF, ORGLOGOID, STLINEREF, SPECODE, CREDITCARDNUM, RETREFNO, DOCODE, BATCHNUM, APPROVENUM, POSTERMINALNUM, CLDIFFINV) VALUES ( " & CARDREF & " , '" & DATE_ & "' , " & MODULENR & " , " & SIGN & " , " & FICHEREF & " , " & FICHELINEREF & " , " & TRCODE & " , " & TOTAL & " , " & PAID & " , " & EARLYINTRATE & " , " & LATELYINTRATE & " , " & CROSSREF & " , " & PAIDINCASH & " , " & CANCELLED & " , '" & PROCDATE & "' , " & TRCURR & " , " & TRRATE & " , " & REPORTRATE & " , " & MODIFIED & " , " & REMINDLEV & " , " & REMINDSENT & " , " & CROSSCURR & " , " & CROSSTOTAL & " , " & DISCFLAG & " , " & SITEID & " , " & ORGLOGICREF & " , " & WFSTATUS & " , " & CLOSINGRATE & " , '" & DISCDUEDATE & "' , " & OPSTAT & " , " & RECSTATUS & " , " & INFIDX & " , " & PAYNO & " , " & DELAYTOTAL & " , " & LASTSENDREMLEV & " , " & POINTTRANS & " , " & POSCOMSN & " , " & POINTCOMSN & " , " & BANKACCREF & " , " & PAYMENTTYPE & " , " & CASHACCREF & " , " & TRNET & " , " & REPAYPLANREF & " , " & DUEDIFFCOMSN & " , " & CALCTYPE & " , " & NETTOTAL & " , " & REPYPLNAPPLIED & " , " & PAYTRCURR & " , " & PAYTRRATE & " , " & PAYTRNET & " , " & BNTRCREATED & " , " & BNFCHREF & " , " & BNFLNREF & " , " & INSTALTYPE & " , " & INSTALREF & " , " & MAININSTALREF & " , '" & ORGLOGOID & "' , " & STLINEREF & " , '" & SPECODE & "' , '" & CREDITCARDNUM & "' , '" & RETREFNO & "' , '" & DOCODE & "' , '" & BATCHNUM & "' , '" & APPROVENUM & "' , '" & POSTERMINALNUM & "' , " & CLDIFFINV & " )")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub PAYTRANS_190_kaydet_yeni(ByVal LOGICALREF, ByVal CARDREF, ByVal DATE_, ByVal MODULENR, ByVal SIGN, ByVal FICHEREF, ByVal FICHELINEREF, ByVal TRCODE, ByVal TOTAL, ByVal PAID, ByVal EARLYINTRATE, ByVal LATELYINTRATE, ByVal CROSSREF, ByVal PAIDINCASH, ByVal CANCELLED, ByVal PROCDATE, ByVal TRCURR, ByVal TRRATE, ByVal REPORTRATE, ByVal MODIFIED, ByVal REMINDLEV, ByVal REMINDSENT, ByVal CROSSCURR, ByVal CROSSTOTAL, ByVal DISCFLAG, ByVal SITEID, ByVal ORGLOGICREF, ByVal WFSTATUS, ByVal CLOSINGRATE, ByVal DISCDUEDATE, ByVal OPSTAT, ByVal RECSTATUS, ByVal INFIDX, ByVal PAYNO, ByVal DELAYTOTAL, ByVal LASTSENDREMLEV, ByVal POINTTRANS, ByVal POSCOMSN, ByVal POINTCOMSN, ByVal BANKACCREF, ByVal PAYMENTTYPE, ByVal CASHACCREF, ByVal TRNET, ByVal REPAYPLANREF, ByVal DUEDIFFCOMSN, ByVal CALCTYPE, ByVal NETTOTAL, ByVal REPYPLNAPPLIED, ByVal PAYTRCURR, ByVal PAYTRRATE, ByVal PAYTRNET, ByVal BNTRCREATED, ByVal BNFCHREF, ByVal BNFLNREF, ByVal INSTALTYPE, ByVal INSTALREF, ByVal MAININSTALREF, ByVal ORGLOGOID, ByVal STLINEREF, ByVal SPECODE, ByVal CREDITCARDNUM, ByVal RETREFNO, ByVal DOCODE, ByVal BATCHNUM, ByVal APPROVENUM, ByVal POSTERMINALNUM, ByVal CLDIFFINV, ByVal LINEEXP)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_PAYTRANS(LOGICALREF, CARDREF, DATE_, MODULENR, SIGN, FICHEREF, FICHELINEREF, TRCODE, TOTAL, PAID, EARLYINTRATE, LATELYINTRATE, CROSSREF, PAIDINCASH, CANCELLED, PROCDATE, TRCURR, TRRATE, REPORTRATE, MODIFIED, REMINDLEV, REMINDSENT, CROSSCURR, CROSSTOTAL, DISCFLAG, SITEID, ORGLOGICREF, WFSTATUS, CLOSINGRATE, DISCDUEDATE, OPSTAT, RECSTATUS, INFIDX, PAYNO, DELAYTOTAL, LASTSENDREMLEV, POINTTRANS, POSCOMSN, POINTCOMSN, BANKACCREF, PAYMENTTYPE, CASHACCREF, TRNET, REPAYPLANREF, DUEDIFFCOMSN, CALCTYPE, NETTOTAL, REPYPLNAPPLIED, PAYTRCURR, PAYTRRATE, PAYTRNET, BNTRCREATED, BNFCHREF, BNFLNREF, INSTALTYPE, INSTALREF, MAININSTALREF, ORGLOGOID, STLINEREF, SPECODE, CREDITCARDNUM, RETREFNO, DOCODE, BATCHNUM, APPROVENUM, POSTERMINALNUM, CLDIFFINV, LINEEXP) VALUES (" & LOGICALREF & " , " & CARDREF & " , '" & DATE_ & "' , " & MODULENR & " , " & SIGN & " , " & FICHEREF & " , " & FICHELINEREF & " , " & TRCODE & " , " & TOTAL & " , " & PAID & " , " & EARLYINTRATE & " , " & LATELYINTRATE & " , " & CROSSREF & " , " & PAIDINCASH & " , " & CANCELLED & " , '" & PROCDATE & "' , " & TRCURR & " , " & TRRATE & " , " & REPORTRATE & " , " & MODIFIED & " , " & REMINDLEV & " , " & REMINDSENT & " , " & CROSSCURR & " , " & CROSSTOTAL & " , " & DISCFLAG & " , " & SITEID & " , " & ORGLOGICREF & " , " & WFSTATUS & " , " & CLOSINGRATE & " , '" & DISCDUEDATE & "' , " & OPSTAT & " , " & RECSTATUS & " , " & INFIDX & " , " & PAYNO & " , " & DELAYTOTAL & " , " & LASTSENDREMLEV & " , " & POINTTRANS & " , " & POSCOMSN & " , " & POINTCOMSN & " , " & BANKACCREF & " , " & PAYMENTTYPE & " , " & CASHACCREF & " , " & TRNET & " , " & REPAYPLANREF & " , " & DUEDIFFCOMSN & " , " & CALCTYPE & " , " & NETTOTAL & " , " & REPYPLNAPPLIED & " , " & PAYTRCURR & " , " & PAYTRRATE & " , " & PAYTRNET & " , " & BNTRCREATED & " , " & BNFCHREF & " , " & BNFLNREF & " , " & INSTALTYPE & " , " & INSTALREF & " , " & MAININSTALREF & " , '" & ORGLOGOID & "' , " & STLINEREF & " , '" & SPECODE & "' , '" & CREDITCARDNUM & "' , '" & RETREFNO & "' , '" & DOCODE & "' , '" & BATCHNUM & "' , '" & APPROVENUM & "' , '" & POSTERMINALNUM & "' , " & CLDIFFINV & " , '" & LINEEXP & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function CLFLINE_kaydet_yeni(ByVal LOGICALREF, ByVal CLIENTREF, ByVal CLACCREF, ByVal CLCENTERREF, ByVal CASHCENTERREF, ByVal CASHACCOUNTREF, ByVal VIRMANREF, ByVal SOURCEFREF, ByVal DATE_, ByVal DEPARTMENT, ByVal BRANCH, ByVal MODULENR, ByVal TRCODE, ByVal LINENR, ByVal SPECODE, ByVal CYPHCODE, ByVal TRANNO, ByVal DOCODE, ByVal LINEEXP, ByVal ACCOUNTED, ByVal SIGN, ByVal AMOUNT, ByVal TRCURR, ByVal TRRATE, ByVal TRNET, ByVal REPORTRATE, ByVal REPORTNET, ByVal EXTENREF, ByVal PAYDEFREF, ByVal ACCFICHEREF, ByVal PRINTCNT, ByVal CAPIBLOCK_CREATEDBY, ByVal CAPIBLOCK_CREADEDDATE, ByVal CAPIBLOCK_CREATEDHOUR, ByVal CAPIBLOCK_CREATEDMIN, ByVal CAPIBLOCK_CREATEDSEC, ByVal CAPIBLOCK_MODIFIEDBY, ByVal CAPIBLOCK_MODIFIEDDATE, ByVal CAPIBLOCK_MODIFIEDHOUR, ByVal CAPIBLOCK_MODIFIEDMIN, ByVal CAPIBLOCK_MODIFIEDSEC, ByVal CANCELLED, ByVal TRGFLAG, ByVal TRADINGGRP, ByVal LINEEXCTYP, ByVal ONLYONEPAYLINE, ByVal DISCFLAG, ByVal DISCRATE, ByVal VATRATE, ByVal CASHAMOUNT, ByVal DISCACCREF, ByVal DISCCENREF, ByVal VATRACCREF, ByVal VATRCENREF, ByVal PAYMENTREF, ByVal VATAMOUNT, ByVal SITEID, ByVal RECSTATUS, ByVal ORGLOGICREF, ByVal INFIDX, ByVal POSCOMMACCREF, ByVal POSCOMMCENREF, ByVal POINTCOMMACCREF, ByVal POINTCOMMCENREF, ByVal CHEQINFO, ByVal CREDITCNO, ByVal CLPRJREF, ByVal STATUS, ByVal EXIMFILEREF, ByVal EXIMPROCNR, ByVal MONTH_, ByVal YEAR_, ByVal FUNDSHARERAT, ByVal AFFECTCOLLATRL, ByVal GRPFIRMTRANS, ByVal REFLVATACCREF, ByVal REFLVATOTHACCREF, ByVal AFFECTRISK, ByVal BATCHNR, ByVal APPROVENR, ByVal BATCHNUM, ByVal APPROVENUM, ByVal EUVATSTATUS, ByVal ORGLOGOID) As Int64
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_CLFLINE( CLIENTREF, CLACCREF, CLCENTERREF, CASHCENTERREF, CASHACCOUNTREF, VIRMANREF, SOURCEFREF, DATE_, DEPARTMENT, BRANCH, MODULENR, TRCODE, LINENR, SPECODE, CYPHCODE, TRANNO, DOCODE, LINEEXP, ACCOUNTED, SIGN, AMOUNT, TRCURR, TRRATE, TRNET, REPORTRATE, REPORTNET, EXTENREF, PAYDEFREF, ACCFICHEREF, PRINTCNT, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, CANCELLED, TRGFLAG, TRADINGGRP, LINEEXCTYP, ONLYONEPAYLINE, DISCFLAG, DISCRATE, VATRATE, CASHAMOUNT, DISCACCREF, DISCCENREF, VATRACCREF, VATRCENREF, PAYMENTREF, VATAMOUNT, SITEID, RECSTATUS, ORGLOGICREF, INFIDX, POSCOMMACCREF, POSCOMMCENREF, POINTCOMMACCREF, POINTCOMMCENREF, CHEQINFO, CREDITCNO, CLPRJREF, STATUS, EXIMFILEREF, EXIMPROCNR, MONTH_, YEAR_, FUNDSHARERAT, AFFECTCOLLATRL, GRPFIRMTRANS, REFLVATACCREF, REFLVATOTHACCREF, AFFECTRISK, BATCHNR, APPROVENR, BATCHNUM, APPROVENUM, EUVATSTATUS, ORGLOGOID) VALUES ( " & CLIENTREF & " , " & CLACCREF & " , " & CLCENTERREF & " , " & CASHCENTERREF & " , " & CASHACCOUNTREF & " , " & VIRMANREF & " , " & SOURCEFREF & " , '" & DATE_ & "' , " & DEPARTMENT & " , " & BRANCH & " , " & MODULENR & " , " & TRCODE & " , " & LINENR & " , '" & SPECODE & "' , '" & CYPHCODE & "' , " & TRANNO & " , '" & DOCODE & "' , '" & LINEEXP & "' , " & ACCOUNTED & " , " & SIGN & " , " & AMOUNT & " , " & TRCURR & " , " & TRRATE & " , " & TRNET & " , " & REPORTRATE & " , " & REPORTNET & " , " & EXTENREF & " , " & PAYDEFREF & " , " & ACCFICHEREF & " , " & PRINTCNT & " , " & CAPIBLOCK_CREATEDBY & " , '" & CAPIBLOCK_CREADEDDATE & "' , " & CAPIBLOCK_CREATEDHOUR & " , " & CAPIBLOCK_CREATEDMIN & " , " & CAPIBLOCK_CREATEDSEC & " , " & CAPIBLOCK_MODIFIEDBY & " , '" & CAPIBLOCK_MODIFIEDDATE & "' , " & CAPIBLOCK_MODIFIEDHOUR & " , " & CAPIBLOCK_MODIFIEDMIN & " , " & CAPIBLOCK_MODIFIEDSEC & " , " & CANCELLED & " , " & TRGFLAG & " , '" & TRADINGGRP & "' , " & LINEEXCTYP & " , " & ONLYONEPAYLINE & " , " & DISCFLAG & " , " & DISCRATE & " , " & VATRATE & " , " & CASHAMOUNT & " , " & DISCACCREF & " , " & DISCCENREF & " , " & VATRACCREF & " , " & VATRCENREF & " , " & PAYMENTREF & " , " & VATAMOUNT & " , " & SITEID & " , " & RECSTATUS & " , " & ORGLOGICREF & " , " & INFIDX & " , " & POSCOMMACCREF & " , " & POSCOMMCENREF & " , " & POINTCOMMACCREF & " , " & POINTCOMMCENREF & " , '" & CHEQINFO & "' , '" & CREDITCNO & "' , " & CLPRJREF & " , " & STATUS & " , " & EXIMFILEREF & " , " & EXIMPROCNR & " , " & MONTH_ & " , " & YEAR_ & " , " & FUNDSHARERAT & " , " & AFFECTCOLLATRL & " , " & GRPFIRMTRANS & " , " & REFLVATACCREF & " , " & REFLVATOTHACCREF & " , " & AFFECTRISK & " , " & BATCHNR & " , " & APPROVENR & " , '" & BATCHNUM & "' , '" & APPROVENUM & "' , " & EUVATSTATUS & " , '" & ORGLOGOID & "' )")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub CLFLINE_190_kaydet_yeni(ByVal LOGICALREF, ByVal CLIENTREF, ByVal CLACCREF, ByVal CLCENTERREF, ByVal CASHCENTERREF, ByVal CASHACCOUNTREF, ByVal VIRMANREF, ByVal SOURCEFREF, ByVal DATE_, ByVal DEPARTMENT, ByVal BRANCH, ByVal MODULENR, ByVal TRCODE, ByVal LINENR, ByVal SPECODE, ByVal CYPHCODE, ByVal TRANNO, ByVal DOCODE, ByVal LINEEXP, ByVal ACCOUNTED, ByVal SIGN, ByVal AMOUNT, ByVal TRCURR, ByVal TRRATE, ByVal TRNET, ByVal REPORTRATE, ByVal REPORTNET, ByVal EXTENREF, ByVal PAYDEFREF, ByVal ACCFICHEREF, ByVal PRINTCNT, ByVal CAPIBLOCK_CREATEDBY, ByVal CAPIBLOCK_CREADEDDATE, ByVal CAPIBLOCK_CREATEDHOUR, ByVal CAPIBLOCK_CREATEDMIN, ByVal CAPIBLOCK_CREATEDSEC, ByVal CAPIBLOCK_MODIFIEDBY, ByVal CAPIBLOCK_MODIFIEDDATE, ByVal CAPIBLOCK_MODIFIEDHOUR, ByVal CAPIBLOCK_MODIFIEDMIN, ByVal CAPIBLOCK_MODIFIEDSEC, ByVal CANCELLED, ByVal TRGFLAG, ByVal TRADINGGRP, ByVal LINEEXCTYP, ByVal ONLYONEPAYLINE, ByVal DISCFLAG, ByVal DISCRATE, ByVal VATRATE, ByVal CASHAMOUNT, ByVal DISCACCREF, ByVal DISCCENREF, ByVal VATRACCREF, ByVal VATRCENREF, ByVal PAYMENTREF, ByVal VATAMOUNT, ByVal SITEID, ByVal RECSTATUS, ByVal ORGLOGICREF, ByVal INFIDX, ByVal POSCOMMACCREF, ByVal POSCOMMCENREF, ByVal POINTCOMMACCREF, ByVal POINTCOMMCENREF, ByVal CHEQINFO, ByVal CREDITCNO, ByVal CLPRJREF, ByVal STATUS, ByVal EXIMFILEREF, ByVal EXIMPROCNR, ByVal MONTH_, ByVal YEAR_, ByVal FUNDSHARERAT, ByVal AFFECTCOLLATRL, ByVal GRPFIRMTRANS, ByVal REFLVATACCREF, ByVal REFLVATOTHACCREF, ByVal AFFECTRISK, ByVal BATCHNR, ByVal APPROVENR, ByVal BATCHNUM, ByVal APPROVENUM, ByVal EUVATSTATUS, ByVal ORGLOGOID, ByVal EXIMTYPE, ByVal EIDISTFLNNR, ByVal EISRVDSTTYP, ByVal EXIMDISTTYP, ByVal SALESMANREF, ByVal BANKACCREF, ByVal BNACCREF, ByVal BNCENTERREF)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_CLFLINE(LOGICALREF, CLIENTREF, CLACCREF, CLCENTERREF, CASHCENTERREF, CASHACCOUNTREF, VIRMANREF, SOURCEFREF, DATE_, DEPARTMENT, BRANCH, MODULENR, TRCODE, LINENR, SPECODE, CYPHCODE, TRANNO, DOCODE, LINEEXP, ACCOUNTED, SIGN, AMOUNT, TRCURR, TRRATE, TRNET, REPORTRATE, REPORTNET, EXTENREF, PAYDEFREF, ACCFICHEREF, PRINTCNT, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, CANCELLED, TRGFLAG, TRADINGGRP, LINEEXCTYP, ONLYONEPAYLINE, DISCFLAG, DISCRATE, VATRATE, CASHAMOUNT, DISCACCREF, DISCCENREF, VATRACCREF, VATRCENREF, PAYMENTREF, VATAMOUNT, SITEID, RECSTATUS, ORGLOGICREF, INFIDX, POSCOMMACCREF, POSCOMMCENREF, POINTCOMMACCREF, POINTCOMMCENREF, CHEQINFO, CREDITCNO, CLPRJREF, STATUS, EXIMFILEREF, EXIMPROCNR, MONTH_, YEAR_, FUNDSHARERAT, AFFECTCOLLATRL, GRPFIRMTRANS, REFLVATACCREF, REFLVATOTHACCREF, AFFECTRISK, BATCHNR, APPROVENR, BATCHNUM, APPROVENUM, EUVATSTATUS, ORGLOGOID, EXIMTYPE, EIDISTFLNNR, EISRVDSTTYP, EXIMDISTTYP, SALESMANREF, BANKACCREF, BNACCREF, BNCENTERREF) VALUES (" & LOGICALREF & " , " & CLIENTREF & " , " & CLACCREF & " , " & CLCENTERREF & " , " & CASHCENTERREF & " , " & CASHACCOUNTREF & " , " & VIRMANREF & " , " & SOURCEFREF & " , '" & DATE_ & "' , " & DEPARTMENT & " , " & BRANCH & " , " & MODULENR & " , " & TRCODE & " , " & LINENR & " , '" & SPECODE & "' , '" & CYPHCODE & "' , " & TRANNO & " , '" & DOCODE & "' , '" & LINEEXP & "' , " & ACCOUNTED & " , " & SIGN & " , " & AMOUNT & " , " & TRCURR & " , " & TRRATE & " , " & TRNET & " , " & REPORTRATE & " , " & REPORTNET & " , " & EXTENREF & " , " & PAYDEFREF & " , " & ACCFICHEREF & " , " & PRINTCNT & " , " & CAPIBLOCK_CREATEDBY & " , '" & CAPIBLOCK_CREADEDDATE & "' , " & CAPIBLOCK_CREATEDHOUR & " , " & CAPIBLOCK_CREATEDMIN & " , " & CAPIBLOCK_CREATEDSEC & " , " & CAPIBLOCK_MODIFIEDBY & " , '" & CAPIBLOCK_MODIFIEDDATE & "' , " & CAPIBLOCK_MODIFIEDHOUR & " , " & CAPIBLOCK_MODIFIEDMIN & " , " & CAPIBLOCK_MODIFIEDSEC & " , " & CANCELLED & " , " & TRGFLAG & " , '" & TRADINGGRP & "' , " & LINEEXCTYP & " , " & ONLYONEPAYLINE & " , " & DISCFLAG & " , " & DISCRATE & " , " & VATRATE & " , " & CASHAMOUNT & " , " & DISCACCREF & " , " & DISCCENREF & " , " & VATRACCREF & " , " & VATRCENREF & " , " & PAYMENTREF & " , " & VATAMOUNT & " , " & SITEID & " , " & RECSTATUS & " , " & ORGLOGICREF & " , " & INFIDX & " , " & POSCOMMACCREF & " , " & POSCOMMCENREF & " , " & POINTCOMMACCREF & " , " & POINTCOMMCENREF & " , '" & CHEQINFO & "' , '" & CREDITCNO & "' , " & CLPRJREF & " , " & STATUS & " , " & EXIMFILEREF & " , " & EXIMPROCNR & " , " & MONTH_ & " , " & YEAR_ & " , " & FUNDSHARERAT & " , " & AFFECTCOLLATRL & " , " & GRPFIRMTRANS & " , " & REFLVATACCREF & " , " & REFLVATOTHACCREF & " , " & AFFECTRISK & " , " & BATCHNR & " , " & APPROVENR & " , '" & BATCHNUM & "' , '" & APPROVENUM & "' , " & EUVATSTATUS & " , '" & ORGLOGOID & "' , " & EXIMTYPE & " , " & EIDISTFLNNR & " , " & EISRVDSTTYP & " , " & EXIMDISTTYP & " , " & SALESMANREF & " , " & BANKACCREF & " , " & BNACCREF & " , " & BNCENTERREF & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub ITEMS_190_kaydet_yeni(ByVal LOGICALREF, ByVal ACTIVE, ByVal CARDTYPE, ByVal CODE, ByVal NAME, ByVal STGRPCODE, ByVal PRODUCERCODE, ByVal SPECODE, ByVal CYPHCODE, ByVal CLASSTYPE, ByVal PURCHBRWS, ByVal SALESBRWS, ByVal MTRLBRWS, ByVal VAT, ByVal PAYMENTREF, ByVal TRACKTYPE, ByVal LOCTRACKING, ByVal TOOL, ByVal AUTOINCSL, ByVal DIVLOTSIZE, ByVal SHELFLIFE, ByVal SHELFDATE, ByVal DOMINANTREFS1, ByVal DOMINANTREFS2, ByVal DOMINANTREFS3, ByVal DOMINANTREFS4, ByVal DOMINANTREFS5, ByVal DOMINANTREFS6, ByVal DOMINANTREFS7, ByVal DOMINANTREFS8, ByVal DOMINANTREFS9, ByVal DOMINANTREFS10, ByVal DOMINANTREFS11, ByVal DOMINANTREFS12, ByVal IMAGEINC, ByVal TEXTINC, ByVal DEPRTYPE, ByVal DEPRRATE, ByVal DEPRDUR, ByVal SALVAGEVAL, ByVal REVALFLAG, ByVal REVDEPRFLAG, ByVal PARTDEP, ByVal DEPRTYPE2, ByVal DEPRRATE2, ByVal DEPRDUR2, ByVal REVALFLAG2, ByVal REVDEPRFLAG2, ByVal PARTDEP2, ByVal APPROVED, ByVal UNITSETREF, ByVal QCCSETREF, ByVal DISTAMOUNT, ByVal CAPIBLOCK_CREATEDBY, ByVal CAPIBLOCK_CREADEDDATE, ByVal CAPIBLOCK_CREATEDHOUR, ByVal CAPIBLOCK_CREATEDMIN, ByVal CAPIBLOCK_CREATEDSEC, ByVal CAPIBLOCK_MODIFIEDBY, ByVal CAPIBLOCK_MODIFIEDDATE, ByVal CAPIBLOCK_MODIFIEDHOUR, ByVal CAPIBLOCK_MODIFIEDMIN, ByVal CAPIBLOCK_MODIFIEDSEC, ByVal SITEID, ByVal RECSTATUS, ByVal ORGLOGICREF, ByVal UNIVID, ByVal DISTLOTUNITS, ByVal COMBLOTUNITS, ByVal WFSTATUS, ByVal DISTPOINT, ByVal CAMPPOINT, ByVal CANUSEINTRNS, ByVal ISONR, ByVal GROUPNR, ByVal PRODCOUNTRY, ByVal ADDTAXREF, ByVal QPRODAMNT, ByVal QPRODUOM, ByVal QPRODSRCINDEX, ByVal EXTACCESSFLAGS, ByVal PACKET, ByVal SALVAGEVAL2, ByVal SELLVAT, ByVal RETURNVAT, ByVal LOGOID, ByVal LIDCONFIRMED, ByVal GTIPCODE, ByVal EXPCTGNO, ByVal B2CCODE, ByVal MARKREF, ByVal IMAGE2INC, ByVal AVRWHDURATION, ByVal EXTCARDFLAGS, ByVal MINORDAMOUNT, ByVal FREIGHTPLACE, ByVal FREIGHTTYPCODE1, ByVal FREIGHTTYPCODE2, ByVal FREIGHTTYPCODE3, ByVal FREIGHTTYPCODE4, ByVal FREIGHTTYPCODE5, ByVal FREIGHTTYPCODE6, ByVal FREIGHTTYPCODE7, ByVal FREIGHTTYPCODE8, ByVal FREIGHTTYPCODE9, ByVal FREIGHTTYPCODE10, ByVal STATECODE, ByVal STATENAME, ByVal EXPCATEGORY, ByVal LOSTFACTOR, ByVal TEXTINCENG, ByVal EANBARCODE, ByVal DEPRCLASSTYPE, ByVal WFLOWCRDREF, ByVal SELLPRVAT, ByVal RETURNPRVAT, ByVal LOWLEVELCODES1, ByVal LOWLEVELCODES2, ByVal LOWLEVELCODES3, ByVal LOWLEVELCODES4, ByVal LOWLEVELCODES5, ByVal LOWLEVELCODES6, ByVal LOWLEVELCODES7, ByVal LOWLEVELCODES8, ByVal LOWLEVELCODES9, ByVal LOWLEVELCODES10, ByVal ORGLOGOID, ByVal QPRODDEPART, ByVal CANCONFIGURE, ByVal CHARSETREF, ByVal CANDEDUCT, ByVal CONSCODEREF, ByVal SPECODE2, ByVal SPECODE3, ByVal SPECODE4, ByVal SPECODE5, ByVal EXPENSE, ByVal ORIGIN, ByVal NAME2, ByVal COMPKDVUSE, ByVal USEDINPERIODS, ByVal EXIMTAX1, ByVal EXIMTAX2, ByVal EXIMTAX3, ByVal EXIMTAX4, ByVal EXIMTAX5)
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_ITEMS(LOGICALREF, ACTIVE, CARDTYPE, CODE, NAME, STGRPCODE, PRODUCERCODE, SPECODE, CYPHCODE, CLASSTYPE, PURCHBRWS, SALESBRWS, MTRLBRWS, VAT, PAYMENTREF, TRACKTYPE, LOCTRACKING, TOOL, AUTOINCSL, DIVLOTSIZE, SHELFLIFE, SHELFDATE, DOMINANTREFS1, DOMINANTREFS2, DOMINANTREFS3, DOMINANTREFS4, DOMINANTREFS5, DOMINANTREFS6, DOMINANTREFS7, DOMINANTREFS8, DOMINANTREFS9, DOMINANTREFS10, DOMINANTREFS11, DOMINANTREFS12, IMAGEINC, TEXTINC, DEPRTYPE, DEPRRATE, DEPRDUR, SALVAGEVAL, REVALFLAG, REVDEPRFLAG, PARTDEP, DEPRTYPE2, DEPRRATE2, DEPRDUR2, REVALFLAG2, REVDEPRFLAG2, PARTDEP2, APPROVED, UNITSETREF, QCCSETREF, DISTAMOUNT, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SITEID, RECSTATUS, ORGLOGICREF, UNIVID, DISTLOTUNITS, COMBLOTUNITS, WFSTATUS, DISTPOINT, CAMPPOINT, CANUSEINTRNS, ISONR, GROUPNR, PRODCOUNTRY, ADDTAXREF, QPRODAMNT, QPRODUOM, QPRODSRCINDEX, EXTACCESSFLAGS, PACKET, SALVAGEVAL2, SELLVAT, RETURNVAT, LOGOID, LIDCONFIRMED, GTIPCODE, EXPCTGNO, B2CCODE, MARKREF, IMAGE2INC, AVRWHDURATION, EXTCARDFLAGS, MINORDAMOUNT, FREIGHTPLACE, FREIGHTTYPCODE1, FREIGHTTYPCODE2, FREIGHTTYPCODE3, FREIGHTTYPCODE4, FREIGHTTYPCODE5, FREIGHTTYPCODE6, FREIGHTTYPCODE7, FREIGHTTYPCODE8, FREIGHTTYPCODE9, FREIGHTTYPCODE10, STATECODE, STATENAME, EXPCATEGORY, LOSTFACTOR, TEXTINCENG, EANBARCODE, DEPRCLASSTYPE, WFLOWCRDREF, SELLPRVAT, RETURNPRVAT, LOWLEVELCODES1, LOWLEVELCODES2, LOWLEVELCODES3, LOWLEVELCODES4, LOWLEVELCODES5, LOWLEVELCODES6, LOWLEVELCODES7, LOWLEVELCODES8, LOWLEVELCODES9, LOWLEVELCODES10, ORGLOGOID, QPRODDEPART, CANCONFIGURE, CHARSETREF, CANDEDUCT, CONSCODEREF, SPECODE2, SPECODE3, SPECODE4, SPECODE5, EXPENSE, ORIGIN, NAME2, COMPKDVUSE, USEDINPERIODS, EXIMTAX1, EXIMTAX2, EXIMTAX3, EXIMTAX4, EXIMTAX5) VALUES (" & LOGICALREF & " , " & ACTIVE & " , " & CARDTYPE & " , '" & CODE & "' , '" & NAME & "' , '" & STGRPCODE & "' , '" & PRODUCERCODE & "' , '" & SPECODE & "' , '" & CYPHCODE & "' , " & CLASSTYPE & " , " & PURCHBRWS & " , " & SALESBRWS & " , " & MTRLBRWS & " , " & VAT & " , " & PAYMENTREF & " , " & TRACKTYPE & " , " & LOCTRACKING & " , " & TOOL & " , " & AUTOINCSL & " , " & DIVLOTSIZE & " , " & SHELFLIFE & " , " & SHELFDATE & " , " & DOMINANTREFS1 & " , " & DOMINANTREFS2 & " , " & DOMINANTREFS3 & " , " & DOMINANTREFS4 & " , " & DOMINANTREFS5 & " , " & DOMINANTREFS6 & " , " & DOMINANTREFS7 & " , " & DOMINANTREFS8 & " , " & DOMINANTREFS9 & " , " & DOMINANTREFS10 & " , " & DOMINANTREFS11 & " , " & DOMINANTREFS12 & " , " & IMAGEINC & " , " & TEXTINC & " , " & DEPRTYPE & " , " & DEPRRATE & " , " & DEPRDUR & " , " & SALVAGEVAL & " , " & REVALFLAG & " , " & REVDEPRFLAG & " , " & PARTDEP & " , " & DEPRTYPE2 & " , " & DEPRRATE2 & " , " & DEPRDUR2 & " , " & REVALFLAG2 & " , " & REVDEPRFLAG2 & " , " & PARTDEP2 & " , " & APPROVED & " , " & UNITSETREF & " , " & QCCSETREF & " , " & DISTAMOUNT & " , " & CAPIBLOCK_CREATEDBY & " , '" & CAPIBLOCK_CREADEDDATE & "' , " & CAPIBLOCK_CREATEDHOUR & " , " & CAPIBLOCK_CREATEDMIN & " , " & CAPIBLOCK_CREATEDSEC & " , " & CAPIBLOCK_MODIFIEDBY & " , '" & CAPIBLOCK_MODIFIEDDATE & "' , " & CAPIBLOCK_MODIFIEDHOUR & " , " & CAPIBLOCK_MODIFIEDMIN & " , " & CAPIBLOCK_MODIFIEDSEC & " , " & SITEID & " , " & RECSTATUS & " , " & ORGLOGICREF & " , '" & UNIVID & "' , " & DISTLOTUNITS & " , " & COMBLOTUNITS & " , " & WFSTATUS & " , " & DISTPOINT & " , " & CAMPPOINT & " , " & CANUSEINTRNS & " , '" & ISONR & "' , '" & GROUPNR & "' , '" & PRODCOUNTRY & "' , " & ADDTAXREF & " , " & QPRODAMNT & " , " & QPRODUOM & " , " & QPRODSRCINDEX & " , " & EXTACCESSFLAGS & " , " & PACKET & " , " & SALVAGEVAL2 & " , " & SELLVAT & " , " & RETURNVAT & " , '" & LOGOID & "' , " & LIDCONFIRMED & " , '" & GTIPCODE & "' , '" & EXPCTGNO & "' , '" & B2CCODE & "' , " & MARKREF & " , " & IMAGE2INC & " , " & AVRWHDURATION & " , " & EXTCARDFLAGS & " , " & MINORDAMOUNT & " , '" & FREIGHTPLACE & "' , '" & FREIGHTTYPCODE1 & "' , '" & FREIGHTTYPCODE2 & "' , '" & FREIGHTTYPCODE3 & "' , '" & FREIGHTTYPCODE4 & "' , '" & FREIGHTTYPCODE5 & "' , '" & FREIGHTTYPCODE6 & "' , '" & FREIGHTTYPCODE7 & "' , '" & FREIGHTTYPCODE8 & "' , '" & FREIGHTTYPCODE9 & "' , '" & FREIGHTTYPCODE10 & "' , '" & STATECODE & "' , '" & STATENAME & "' , '" & EXPCATEGORY & "' , " & LOSTFACTOR & " , " & TEXTINCENG & " , '" & EANBARCODE & "' , '" & DEPRCLASSTYPE & "' , " & WFLOWCRDREF & " , " & SELLPRVAT & " , " & RETURNPRVAT & " , " & LOWLEVELCODES1 & " , " & LOWLEVELCODES2 & " , " & LOWLEVELCODES3 & " , " & LOWLEVELCODES4 & " , " & LOWLEVELCODES5 & " , " & LOWLEVELCODES6 & " , " & LOWLEVELCODES7 & " , " & LOWLEVELCODES8 & " , " & LOWLEVELCODES9 & " , " & LOWLEVELCODES10 & " , '" & ORGLOGOID & "' , " & QPRODDEPART & " , " & CANCONFIGURE & " , " & CHARSETREF & " , " & CANDEDUCT & " , " & CONSCODEREF & " , '" & SPECODE2 & "' , '" & SPECODE3 & "' , '" & SPECODE4 & "' , '" & SPECODE5 & "' , " & EXPENSE & " , '" & ORIGIN & "' , '" & NAME2 & "' , " & COMPKDVUSE & " , " & USEDINPERIODS & " , " & EXIMTAX1 & " , " & EXIMTAX2 & " , " & EXIMTAX3 & " , " & EXIMTAX4 & " , " & EXIMTAX5 & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function ITEMS_kaydet_yeni(ByVal LOGICALREF, ByVal ACTIVE, ByVal CARDTYPE, ByVal CODE, ByVal NAME, ByVal STGRPCODE, ByVal PRODUCERCODE, ByVal SPECODE, ByVal CYPHCODE, ByVal CLASSTYPE, ByVal PURCHBRWS, ByVal SALESBRWS, ByVal MTRLBRWS, ByVal VAT, ByVal PAYMENTREF, ByVal TRACKTYPE, ByVal LOCTRACKING, ByVal TOOL, ByVal AUTOINCSL, ByVal DIVLOTSIZE, ByVal SHELFLIFE, ByVal SHELFDATE, ByVal DOMINANTREFS1, ByVal DOMINANTREFS2, ByVal DOMINANTREFS3, ByVal DOMINANTREFS4, ByVal DOMINANTREFS5, ByVal DOMINANTREFS6, ByVal DOMINANTREFS7, ByVal DOMINANTREFS8, ByVal DOMINANTREFS9, ByVal DOMINANTREFS10, ByVal DOMINANTREFS11, ByVal DOMINANTREFS12, ByVal IMAGEINC, ByVal TEXTINC, ByVal DEPRTYPE, ByVal DEPRRATE, ByVal DEPRDUR, ByVal SALVAGEVAL, ByVal REVALFLAG, ByVal REVDEPRFLAG, ByVal PARTDEP, ByVal DEPRTYPE2, ByVal DEPRRATE2, ByVal DEPRDUR2, ByVal REVALFLAG2, ByVal REVDEPRFLAG2, ByVal PARTDEP2, ByVal APPROVED, ByVal UNITSETREF, ByVal QCCSETREF, ByVal DISTAMOUNT, ByVal CAPIBLOCK_CREATEDBY, ByVal CAPIBLOCK_CREADEDDATE, ByVal CAPIBLOCK_CREATEDHOUR, ByVal CAPIBLOCK_CREATEDMIN, ByVal CAPIBLOCK_CREATEDSEC, ByVal CAPIBLOCK_MODIFIEDBY, ByVal CAPIBLOCK_MODIFIEDDATE, ByVal CAPIBLOCK_MODIFIEDHOUR, ByVal CAPIBLOCK_MODIFIEDMIN, ByVal CAPIBLOCK_MODIFIEDSEC, ByVal SITEID, ByVal RECSTATUS, ByVal ORGLOGICREF, ByVal UNIVID, ByVal DISTLOTUNITS, ByVal COMBLOTUNITS, ByVal WFSTATUS, ByVal DISTPOINT, ByVal CAMPPOINT, ByVal CANUSEINTRNS, ByVal ISONR, ByVal GROUPNR, ByVal PRODCOUNTRY, ByVal ADDTAXREF, ByVal QPRODAMNT, ByVal QPRODUOM, ByVal QPRODSRCINDEX, ByVal EXTACCESSFLAGS, ByVal PACKET, ByVal SALVAGEVAL2, ByVal SELLVAT, ByVal RETURNVAT, ByVal LOGOID, ByVal LIDCONFIRMED, ByVal GTIPCODE, ByVal EXPCTGNO, ByVal B2CCODE, ByVal MARKREF, ByVal IMAGE2INC, ByVal AVRWHDURATION, ByVal EXTCARDFLAGS, ByVal MINORDAMOUNT, ByVal FREIGHTPLACE, ByVal FREIGHTTYPCODE1, ByVal FREIGHTTYPCODE2, ByVal FREIGHTTYPCODE3, ByVal FREIGHTTYPCODE4, ByVal FREIGHTTYPCODE5, ByVal FREIGHTTYPCODE6, ByVal FREIGHTTYPCODE7, ByVal FREIGHTTYPCODE8, ByVal FREIGHTTYPCODE9, ByVal FREIGHTTYPCODE10, ByVal STATECODE, ByVal STATENAME, ByVal EXPCATEGORY, ByVal LOSTFACTOR, ByVal TEXTINCENG, ByVal EANBARCODE, ByVal DEPRCLASSTYPE, ByVal WFLOWCRDREF, ByVal SELLPRVAT, ByVal RETURNPRVAT, ByVal LOWLEVELCODES1, ByVal LOWLEVELCODES2, ByVal LOWLEVELCODES3, ByVal LOWLEVELCODES4, ByVal LOWLEVELCODES5, ByVal LOWLEVELCODES6, ByVal LOWLEVELCODES7, ByVal LOWLEVELCODES8, ByVal LOWLEVELCODES9, ByVal LOWLEVELCODES10, ByVal ORGLOGOID, ByVal QPRODDEPART, ByVal CANCONFIGURE, ByVal CHARSETREF, ByVal CANDEDUCT, ByVal CONSCODEREF, ByVal SPECODE2, ByVal SPECODE3, ByVal SPECODE4, ByVal SPECODE5, ByVal EXPENSE, ByVal ORIGIN, ByVal NAME2) As Int64
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_logo("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_ITEMS( ACTIVE, CARDTYPE, CODE, NAME, STGRPCODE, PRODUCERCODE, SPECODE, CYPHCODE, CLASSTYPE, PURCHBRWS, SALESBRWS, MTRLBRWS, VAT, PAYMENTREF, TRACKTYPE, LOCTRACKING, TOOL, AUTOINCSL, DIVLOTSIZE, SHELFLIFE, SHELFDATE, DOMINANTREFS1, DOMINANTREFS2, DOMINANTREFS3, DOMINANTREFS4, DOMINANTREFS5, DOMINANTREFS6, DOMINANTREFS7, DOMINANTREFS8, DOMINANTREFS9, DOMINANTREFS10, DOMINANTREFS11, DOMINANTREFS12, IMAGEINC, TEXTINC, DEPRTYPE, DEPRRATE, DEPRDUR, SALVAGEVAL, REVALFLAG, REVDEPRFLAG, PARTDEP, DEPRTYPE2, DEPRRATE2, DEPRDUR2, REVALFLAG2, REVDEPRFLAG2, PARTDEP2, APPROVED, UNITSETREF, QCCSETREF, DISTAMOUNT, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SITEID, RECSTATUS, ORGLOGICREF, UNIVID, DISTLOTUNITS, COMBLOTUNITS, WFSTATUS, DISTPOINT, CAMPPOINT, CANUSEINTRNS, ISONR, GROUPNR, PRODCOUNTRY, ADDTAXREF, QPRODAMNT, QPRODUOM, QPRODSRCINDEX, EXTACCESSFLAGS, PACKET, SALVAGEVAL2, SELLVAT, RETURNVAT, LOGOID, LIDCONFIRMED, GTIPCODE, EXPCTGNO, B2CCODE, MARKREF, IMAGE2INC, AVRWHDURATION, EXTCARDFLAGS, MINORDAMOUNT, FREIGHTPLACE, FREIGHTTYPCODE1, FREIGHTTYPCODE2, FREIGHTTYPCODE3, FREIGHTTYPCODE4, FREIGHTTYPCODE5, FREIGHTTYPCODE6, FREIGHTTYPCODE7, FREIGHTTYPCODE8, FREIGHTTYPCODE9, FREIGHTTYPCODE10, STATECODE, STATENAME, EXPCATEGORY, LOSTFACTOR, TEXTINCENG, EANBARCODE, DEPRCLASSTYPE, WFLOWCRDREF, SELLPRVAT, RETURNPRVAT, LOWLEVELCODES1, LOWLEVELCODES2, LOWLEVELCODES3, LOWLEVELCODES4, LOWLEVELCODES5, LOWLEVELCODES6, LOWLEVELCODES7, LOWLEVELCODES8, LOWLEVELCODES9, LOWLEVELCODES10, ORGLOGOID, QPRODDEPART, CANCONFIGURE, CHARSETREF, CANDEDUCT, CONSCODEREF, SPECODE2, SPECODE3, SPECODE4, SPECODE5, EXPENSE, ORIGIN, NAME2) VALUES ( " & ACTIVE & " , " & CARDTYPE & " , '" & CODE & "' , '" & NAME & "' , '" & STGRPCODE & "' , '" & PRODUCERCODE & "' , '" & SPECODE & "' , '" & CYPHCODE & "' , " & CLASSTYPE & " , " & PURCHBRWS & " , " & SALESBRWS & " , " & MTRLBRWS & " , " & VAT & " , " & PAYMENTREF & " , " & TRACKTYPE & " , " & LOCTRACKING & " , " & TOOL & " , " & AUTOINCSL & " , " & DIVLOTSIZE & " , " & SHELFLIFE & " , " & SHELFDATE & " , " & DOMINANTREFS1 & " , " & DOMINANTREFS2 & " , " & DOMINANTREFS3 & " , " & DOMINANTREFS4 & " , " & DOMINANTREFS5 & " , " & DOMINANTREFS6 & " , " & DOMINANTREFS7 & " , " & DOMINANTREFS8 & " , " & DOMINANTREFS9 & " , " & DOMINANTREFS10 & " , " & DOMINANTREFS11 & " , " & DOMINANTREFS12 & " , " & IMAGEINC & " , " & TEXTINC & " , " & DEPRTYPE & " , " & DEPRRATE & " , " & DEPRDUR & " , " & SALVAGEVAL & " , " & REVALFLAG & " , " & REVDEPRFLAG & " , " & PARTDEP & " , " & DEPRTYPE2 & " , " & DEPRRATE2 & " , " & DEPRDUR2 & " , " & REVALFLAG2 & " , " & REVDEPRFLAG2 & " , " & PARTDEP2 & " , " & APPROVED & " , " & UNITSETREF & " , " & QCCSETREF & " , " & DISTAMOUNT & " , " & CAPIBLOCK_CREATEDBY & " , '" & CAPIBLOCK_CREADEDDATE & "' , " & CAPIBLOCK_CREATEDHOUR & " , " & CAPIBLOCK_CREATEDMIN & " , " & CAPIBLOCK_CREATEDSEC & " , " & CAPIBLOCK_MODIFIEDBY & " , '" & CAPIBLOCK_MODIFIEDDATE & "' , " & CAPIBLOCK_MODIFIEDHOUR & " , " & CAPIBLOCK_MODIFIEDMIN & " , " & CAPIBLOCK_MODIFIEDSEC & " , " & SITEID & " , " & RECSTATUS & " , " & ORGLOGICREF & " , '" & UNIVID & "' , " & DISTLOTUNITS & " , " & COMBLOTUNITS & " , " & WFSTATUS & " , " & DISTPOINT & " , " & CAMPPOINT & " , " & CANUSEINTRNS & " , '" & ISONR & "' , '" & GROUPNR & "' , '" & PRODCOUNTRY & "' , " & ADDTAXREF & " , " & QPRODAMNT & " , " & QPRODUOM & " , " & QPRODSRCINDEX & " , " & EXTACCESSFLAGS & " , " & PACKET & " , " & SALVAGEVAL2 & " , " & SELLVAT & " , " & RETURNVAT & " , '" & LOGOID & "' , " & LIDCONFIRMED & " , '" & GTIPCODE & "' , '" & EXPCTGNO & "' , '" & B2CCODE & "' , " & MARKREF & " , " & IMAGE2INC & " , " & AVRWHDURATION & " , " & EXTCARDFLAGS & " , " & MINORDAMOUNT & " , '" & FREIGHTPLACE & "' , '" & FREIGHTTYPCODE1 & "' , '" & FREIGHTTYPCODE2 & "' , '" & FREIGHTTYPCODE3 & "' , '" & FREIGHTTYPCODE4 & "' , '" & FREIGHTTYPCODE5 & "' , '" & FREIGHTTYPCODE6 & "' , '" & FREIGHTTYPCODE7 & "' , '" & FREIGHTTYPCODE8 & "' , '" & FREIGHTTYPCODE9 & "' , '" & FREIGHTTYPCODE10 & "' , '" & STATECODE & "' , '" & STATENAME & "' , '" & EXPCATEGORY & "' , " & LOSTFACTOR & " , " & TEXTINCENG & " , '" & EANBARCODE & "' , '" & DEPRCLASSTYPE & "' , " & WFLOWCRDREF & " , " & SELLPRVAT & " , " & RETURNPRVAT & " , " & LOWLEVELCODES1 & " , " & LOWLEVELCODES2 & " , " & LOWLEVELCODES3 & " , " & LOWLEVELCODES4 & " , " & LOWLEVELCODES5 & " , " & LOWLEVELCODES6 & " , " & LOWLEVELCODES7 & " , " & LOWLEVELCODES8 & " , " & LOWLEVELCODES9 & " , " & LOWLEVELCODES10 & " , '" & ORGLOGOID & "' , " & QPRODDEPART & " , " & CANCONFIGURE & " , " & CHARSETREF & " , " & CANDEDUCT & " , " & CONSCODEREF & " , '" & SPECODE2 & "' , '" & SPECODE3 & "' , '" & SPECODE4 & "' , '" & SPECODE5 & "' , " & EXPENSE & " , '" & ORIGIN & "' , '" & NAME2 & "' )")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        stok_satis_karliligi()
    End Sub
    Private Sub stok_satis_karliligi()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_satis_karliligi
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nStokID = dr("nStokID")
            frm.DateEdit1.EditValue = DateEdit1.EditValue
            frm.DateEdit2.EditValue = DateEdit2.EditValue
            frm.sec_depo.Text = sec_depo.Text
            frm.sec_kasatipi.Text = sec_kasatipi.Text
            frm.sec_kasakasiyer.Text = sec_kasakasiyer.Text
            frm.sec_harekettipi.Text = sec_harekettipi.Text
            frm.sec_fistipi.Text = sec_fistipi.Text
            frm.txt_ara.EditValue = ""
            frm.sec_konum.Text = "Ad"
            frm.sec_kriter.Text = "Baþlar"
            'frm.sec_sTop.Text , txt_nTop.EditValue, sec_Siralama.Text, sec_bSiniflandir.Checked, sec_nSinif.EditValue
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
End Class
