Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_Yevmiye
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colnFisSiraID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHesapID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirenMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikanMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMasrafYontemi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKasaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCariHareketID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSatir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSubeMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSonKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSonUpdateTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesapKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesapAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCariIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents txt_dteFisTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lYevmiyeNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lYevmiyeNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collYevmiyeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtefisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMuhFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHangiUygulama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_sMuhFisTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colbKilitli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbMuhasebe_Yevmiye))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colbTamamlandi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_sDetay = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sSubeMagaza = New DevExpress.XtraEditors.PopupContainerEdit
        Me.sec_sMuhFisTipi = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lYevmiyeNo2 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lYevmiyeNo1 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lFisNo2 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lFisNo1 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteFisTarihi2 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteFisTarihi1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collYevmiyeNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldtefisTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsMuhFisTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsNot = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHangiUygulama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbKilitli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSube = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnFisSiraID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnHesapID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collGirenMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collCikanMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBorcTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAlacakTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsMasrafYontemi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnKasaID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCariHareketID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizMiktari2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizKuru2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnSatir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSubeMagaza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSonKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteSonUpdateTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFirmaAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHesapKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHesapAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsCariIslem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sDetay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sMuhFisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lYevmiyeNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lYevmiyeNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colbTamamlandi
        '
        Me.colbTamamlandi.Caption = "Tamamlandi?"
        Me.colbTamamlandi.FieldName = "bTamamlandi"
        Me.colbTamamlandi.Name = "colbTamamlandi"
        Me.colbTamamlandi.Width = 72
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 170)
        Me.PanelControl1.TabIndex = 3
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_istihbarat.Location = New System.Drawing.Point(567, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(255, 166)
        Me.lbl_istihbarat.TabIndex = 35
        Me.lbl_istihbarat.Text = "*"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_sDetay)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.sec_sSubeMagaza)
        Me.GroupControl1.Controls.Add(Me.sec_sMuhFisTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txt_lYevmiyeNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txt_lYevmiyeNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(471, 166)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_sDetay
        '
        Me.sec_sDetay.EditValue = "Tüm Hesaplar"
        Me.sec_sDetay.EnterMoveNextControl = True
        Me.sec_sDetay.Location = New System.Drawing.Point(201, 131)
        Me.sec_sDetay.Name = "sec_sDetay"
        Me.sec_sDetay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDetay.Properties.Items.AddRange(New Object() {"Sadece Ana Hesaplar", "Sadece Kullanıcının Girdiği Hesaplar", "Tüm Hesaplar", "Tüm Hesaplar Gruplara Kadar", "Tüm Hesaplar Sınıflara Kadar"})
        Me.sec_sDetay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sDetay.Size = New System.Drawing.Size(100, 20)
        Me.sec_sDetay.TabIndex = 28
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(40, 131)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(30, 20)
        Me.LabelControl12.TabIndex = 25
        Me.LabelControl12.Text = "Şube:"
        '
        'sec_sSubeMagaza
        '
        Me.sec_sSubeMagaza.EditValue = "[Tümü]"
        Me.sec_sSubeMagaza.EnterMoveNextControl = True
        Me.sec_sSubeMagaza.Location = New System.Drawing.Point(71, 131)
        Me.sec_sSubeMagaza.Name = "sec_sSubeMagaza"
        Me.sec_sSubeMagaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSubeMagaza.Properties.ShowPopupCloseButton = False
        Me.sec_sSubeMagaza.Size = New System.Drawing.Size(130, 20)
        Me.sec_sSubeMagaza.TabIndex = 27
        '
        'sec_sMuhFisTipi
        '
        Me.sec_sMuhFisTipi.EnterMoveNextControl = True
        Me.sec_sMuhFisTipi.Location = New System.Drawing.Point(71, 21)
        Me.sec_sMuhFisTipi.Name = "sec_sMuhFisTipi"
        Me.sec_sMuhFisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sMuhFisTipi.Properties.DisplayMember = "sAciklama"
        Me.sec_sMuhFisTipi.Properties.NullText = "[MuhFisTipi]"
        Me.sec_sMuhFisTipi.Properties.ValueMember = "sMuhFisTipi"
        Me.sec_sMuhFisTipi.Size = New System.Drawing.Size(229, 20)
        Me.sec_sMuhFisTipi.TabIndex = 21
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(5, 20)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl11.TabIndex = 20
        Me.LabelControl11.Text = "FişTipi:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(5, 109)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Hesap:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(302, 87)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Arasındaki"
        '
        'txt_lYevmiyeNo2
        '
        Me.txt_lYevmiyeNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lYevmiyeNo2.EnterMoveNextControl = True
        Me.txt_lYevmiyeNo2.Location = New System.Drawing.Point(200, 87)
        Me.txt_lYevmiyeNo2.Name = "txt_lYevmiyeNo2"
        Me.txt_lYevmiyeNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lYevmiyeNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lYevmiyeNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lYevmiyeNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lYevmiyeNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lYevmiyeNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lYevmiyeNo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lYevmiyeNo2.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(174, 80)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(24, 15)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "ve"
        '
        'txt_lYevmiyeNo1
        '
        Me.txt_lYevmiyeNo1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_lYevmiyeNo1.EnterMoveNextControl = True
        Me.txt_lYevmiyeNo1.Location = New System.Drawing.Point(71, 87)
        Me.txt_lYevmiyeNo1.Name = "txt_lYevmiyeNo1"
        Me.txt_lYevmiyeNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lYevmiyeNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lYevmiyeNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lYevmiyeNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lYevmiyeNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lYevmiyeNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lYevmiyeNo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lYevmiyeNo1.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(5, 87)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl9.TabIndex = 14
        Me.LabelControl9.Text = "YevmiyeNo:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(302, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasındaki"
        '
        'txt_lFisNo2
        '
        Me.txt_lFisNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lFisNo2.EnterMoveNextControl = True
        Me.txt_lFisNo2.Location = New System.Drawing.Point(200, 65)
        Me.txt_lFisNo2.Name = "txt_lFisNo2"
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lFisNo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo2.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(174, 59)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lFisNo1
        '
        Me.txt_lFisNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_lFisNo1.EnterMoveNextControl = True
        Me.txt_lFisNo1.Location = New System.Drawing.Point(71, 65)
        Me.txt_lFisNo1.Name = "txt_lFisNo1"
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lFisNo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lFisNo1.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(5, 65)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "FişNo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(302, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Arasındaki"
        '
        'txt_dteFisTarihi2
        '
        Me.txt_dteFisTarihi2.EditValue = Nothing
        Me.txt_dteFisTarihi2.EnterMoveNextControl = True
        Me.txt_dteFisTarihi2.Location = New System.Drawing.Point(200, 43)
        Me.txt_dteFisTarihi2.Name = "txt_dteFisTarihi2"
        Me.txt_dteFisTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteFisTarihi2.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteFisTarihi2.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(174, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "ve"
        '
        'txt_dteFisTarihi1
        '
        Me.txt_dteFisTarihi1.EditValue = Nothing
        Me.txt_dteFisTarihi1.EnterMoveNextControl = True
        Me.txt_dteFisTarihi1.Location = New System.Drawing.Point(71, 43)
        Me.txt_dteFisTarihi1.Name = "txt_dteFisTarihi1"
        Me.txt_dteFisTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteFisTarihi1.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteFisTarihi1.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(5, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Yevmiye:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(201, 109)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adı"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 7
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(300, 131)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(301, 109)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 8
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(71, 109)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(130, 20)
        ToolTipTitleItem1.Text = "Hesap Arama"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Ilgili Hesaplarda aramak için kullanılır, ismi tam olarak bilinmiyorsa Hesap seçm" & _
            "ek için F6 tuşuna basılır."
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "F6"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.txt_ara.SuperTip = SuperToolTip1
        Me.txt_ara.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 166)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 166)
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 358)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 170)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 188)
        Me.PanelControl3.TabIndex = 0
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl3)
        Me.sec_grid.Location = New System.Drawing.Point(182, 28)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(256, 128)
        Me.sec_grid.TabIndex = 26
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView4
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(256, 128)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.GridColumn6})
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.IndicatorWidth = 12
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsDetail.ShowDetailTabs = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
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
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Açıklama"
        Me.GridColumn6.FieldName = "ACIKLAMA"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 128
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 184)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem13, Me.MenuItem14, Me.MenuItem18, Me.MenuItem22, Me.MenuItem15, Me.MenuItem23, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem26, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem21.Text = "Ara"
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Fişi Göster"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem22.Text = "Detay Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = "-"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25})
        Me.MenuItem23.Text = "Kilit"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Text = "Kilitle"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Text = "Kilit Kaldır"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartı"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 8
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "İletişim Bilgileri"
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = False
        Me.MenuItem17.Index = 9
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Firma Hareketleri"
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
        Me.MenuItem2.Text = "Başlık Değiştir"
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
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 16
        Me.MenuItem26.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 17
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 18
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 19
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 20
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 21
        Me.MenuItem8.Text = "Satırları Kapat"
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
        Me.MenuItem9.Text = "Ekranı Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "lFisNo"
        Me.DataColumn1.DataType = GetType(Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lYevmiyeNo"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "dtefisTarihi"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sMuhFisTipi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sFis"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sAciklama"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lTutar"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sNot"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sHangiUygulama"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collFisNo, Me.collYevmiyeNo, Me.coldtefisTarihi, Me.colsMuhFisTipi, Me.colsFis, Me.colsAciklama, Me.collTutar, Me.colsNot, Me.colsHangiUygulama, Me.colbKilitli, Me.colbTamamlandi, Me.colsSube})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colbTamamlandi
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = False
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayıt")})
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiş No"
        Me.collFisNo.FieldName = "lFisno"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 3
        Me.collFisNo.Width = 82
        '
        'collYevmiyeNo
        '
        Me.collYevmiyeNo.Caption = "YevmiyeNo"
        Me.collYevmiyeNo.FieldName = "lYevmiyeNo"
        Me.collYevmiyeNo.Name = "collYevmiyeNo"
        Me.collYevmiyeNo.Visible = True
        Me.collYevmiyeNo.VisibleIndex = 4
        Me.collYevmiyeNo.Width = 82
        '
        'coldtefisTarihi
        '
        Me.coldtefisTarihi.Caption = "Fiş Tarihi"
        Me.coldtefisTarihi.FieldName = "dteFisTarihi"
        Me.coldtefisTarihi.Name = "coldtefisTarihi"
        Me.coldtefisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dtefisTarihi", "{0} Kayıt")})
        Me.coldtefisTarihi.Visible = True
        Me.coldtefisTarihi.VisibleIndex = 0
        Me.coldtefisTarihi.Width = 82
        '
        'colsMuhFisTipi
        '
        Me.colsMuhFisTipi.Caption = "FisTipi"
        Me.colsMuhFisTipi.FieldName = "sMuhFisTipi"
        Me.colsMuhFisTipi.Name = "colsMuhFisTipi"
        Me.colsMuhFisTipi.Visible = True
        Me.colsMuhFisTipi.VisibleIndex = 1
        Me.colsMuhFisTipi.Width = 82
        '
        'colsFis
        '
        Me.colsFis.Caption = "Fis"
        Me.colsFis.FieldName = "sFis"
        Me.colsFis.Name = "colsFis"
        Me.colsFis.Visible = True
        Me.colsFis.VisibleIndex = 2
        Me.colsFis.Width = 82
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açıklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 5
        Me.colsAciklama.Width = 82
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutar", "{0:#,0.00##}")})
        Me.collTutar.Visible = True
        Me.collTutar.VisibleIndex = 6
        Me.collTutar.Width = 82
        '
        'colsNot
        '
        Me.colsNot.Caption = "Not"
        Me.colsNot.FieldName = "sNot"
        Me.colsNot.Name = "colsNot"
        Me.colsNot.Visible = True
        Me.colsNot.VisibleIndex = 7
        Me.colsNot.Width = 133
        '
        'colsHangiUygulama
        '
        Me.colsHangiUygulama.Caption = "Hangi Uygulama"
        Me.colsHangiUygulama.FieldName = "sHangiUygulama"
        Me.colsHangiUygulama.Name = "colsHangiUygulama"
        '
        'colbKilitli
        '
        Me.colbKilitli.Caption = "Kilitli?"
        Me.colbKilitli.FieldName = "bKilitli"
        Me.colbKilitli.Name = "colbKilitli"
        Me.colbKilitli.Visible = True
        Me.colbKilitli.VisibleIndex = 9
        Me.colbKilitli.Width = 37
        '
        'colsSube
        '
        Me.colsSube.Caption = "Şube"
        Me.colsSube.FieldName = "sSubeMagaza"
        Me.colsSube.Name = "colsSube"
        Me.colsSube.Visible = True
        Me.colsSube.VisibleIndex = 8
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Yevmiye Defteri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel1.FloatSize = New System.Drawing.Size(245, 114)
        Me.DockPanel1.FloatVertical = True
        Me.DockPanel1.ID = New System.Guid("61f36abc-afa7-4227-b4bd-a5cd048748d3")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 211)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(824, 200)
        Me.DockPanel1.Text = "Detay"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GridControl2)
        Me.DockPanel1_Container.Controls.Add(Me.Label9)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 21)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(816, 175)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 16)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(816, 159)
        Me.GridControl2.TabIndex = 3
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView2})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnFisSiraID, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colnHesapID, Me.colsAciklama1, Me.collGirenMiktar, Me.collCikanMiktar, Me.collBorcTutar, Me.collAlacakTutar, Me.colsMasrafYontemi, Me.colnKasaID, Me.GridColumn5, Me.colsHareketTipi, Me.colnCariHareketID, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsDovizCinsi2, Me.collDovizMiktari2, Me.collDovizKuru2, Me.colnSatir, Me.colsSubeMagaza, Me.colsSonKullaniciAdi, Me.coldteSonUpdateTarihi, Me.colsFirmaKodu, Me.colsFirmaAciklama, Me.colsHesapKodu, Me.colsHesapAciklama, Me.coldteValorTarihi, Me.colsCariIslem, Me.colsEvrakNo})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(806, 475, 208, 168)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView3.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView3.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colnFisSiraID
        '
        Me.colnFisSiraID.Caption = "FisSiraID"
        Me.colnFisSiraID.FieldName = "nFisSiraID"
        Me.colnFisSiraID.Name = "colnFisSiraID"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Fiş Tarihi"
        Me.GridColumn1.FieldName = "dteFisTarihi"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "MuhFisTipi"
        Me.GridColumn2.FieldName = "sMuhFisTipi"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fiş No"
        Me.GridColumn3.FieldName = "lFisno"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "YevmiyeNo"
        Me.GridColumn4.FieldName = "lYevmiyeNo"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colnHesapID
        '
        Me.colnHesapID.Caption = "Hesap ID"
        Me.colnHesapID.FieldName = "nHesapID"
        Me.colnHesapID.Name = "colnHesapID"
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Açıklama"
        Me.colsAciklama1.FieldName = "sAciklama"
        Me.colsAciklama1.Name = "colsAciklama1"
        Me.colsAciklama1.Visible = True
        Me.colsAciklama1.VisibleIndex = 2
        Me.colsAciklama1.Width = 283
        '
        'collGirenMiktar
        '
        Me.collGirenMiktar.Caption = "GirenMiktar"
        Me.collGirenMiktar.FieldName = "lGirenMiktar"
        Me.collGirenMiktar.Name = "collGirenMiktar"
        Me.collGirenMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirenMiktar", "{0:#,0.00##}")})
        '
        'collCikanMiktar
        '
        Me.collCikanMiktar.Caption = "Çıkan Miktar"
        Me.collCikanMiktar.FieldName = "lCikanMiktar"
        Me.collCikanMiktar.Name = "collCikanMiktar"
        Me.collCikanMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikanMiktar", "{0:#,0.00##}")})
        '
        'collBorcTutar
        '
        Me.collBorcTutar.Caption = "Borç"
        Me.collBorcTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutar.FieldName = "lBorcTutar"
        Me.collBorcTutar.Name = "collBorcTutar"
        Me.collBorcTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00##}")})
        Me.collBorcTutar.Visible = True
        Me.collBorcTutar.VisibleIndex = 3
        Me.collBorcTutar.Width = 126
        '
        'collAlacakTutar
        '
        Me.collAlacakTutar.Caption = "Alacak"
        Me.collAlacakTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutar.FieldName = "lAlacakTutar"
        Me.collAlacakTutar.Name = "collAlacakTutar"
        Me.collAlacakTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", "{0:#,0.00##}")})
        Me.collAlacakTutar.Visible = True
        Me.collAlacakTutar.VisibleIndex = 4
        Me.collAlacakTutar.Width = 128
        '
        'colsMasrafYontemi
        '
        Me.colsMasrafYontemi.Caption = "MY"
        Me.colsMasrafYontemi.FieldName = "sMasrafYontemi"
        Me.colsMasrafYontemi.Name = "colsMasrafYontemi"
        Me.colsMasrafYontemi.Width = 35
        '
        'colnKasaID
        '
        Me.colnKasaID.Caption = "KasaID"
        Me.colnKasaID.FieldName = "nKasaID"
        Me.colnKasaID.Name = "colnKasaID"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Hangi Uygulama"
        Me.GridColumn5.FieldName = "sHangiUygulama"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "HT"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Width = 43
        '
        'colnCariHareketID
        '
        Me.colnCariHareketID.Caption = "Cari Hareket ID"
        Me.colnCariHareketID.FieldName = "nCariHareketID"
        Me.colnCariHareketID.Name = "colnCariHareketID"
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanıcı Adı"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Pb"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        Me.colsDovizCinsi1.Width = 44
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Doviz"
        Me.collDovizMiktari1.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        Me.collDovizMiktari1.Width = 103
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Kur"
        Me.collDovizKuru1.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizKuru1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        Me.collDovizKuru1.Width = 47
        '
        'colsDovizCinsi2
        '
        Me.colsDovizCinsi2.Caption = "Döviz Cinsi 2"
        Me.colsDovizCinsi2.FieldName = "sDovizCinsi2"
        Me.colsDovizCinsi2.Name = "colsDovizCinsi2"
        '
        'collDovizMiktari2
        '
        Me.collDovizMiktari2.Caption = "Döviz Miktarı 2"
        Me.collDovizMiktari2.FieldName = "lDovizMiktari2"
        Me.collDovizMiktari2.Name = "collDovizMiktari2"
        '
        'collDovizKuru2
        '
        Me.collDovizKuru2.Caption = "Döviz Kuru 2"
        Me.collDovizKuru2.FieldName = "lDovizKuru2"
        Me.collDovizKuru2.Name = "collDovizKuru2"
        '
        'colnSatir
        '
        Me.colnSatir.Caption = "Satir"
        Me.colnSatir.FieldName = "nSatir"
        Me.colnSatir.Name = "colnSatir"
        '
        'colsSubeMagaza
        '
        Me.colsSubeMagaza.Caption = "SubeMagaza"
        Me.colsSubeMagaza.FieldName = "sSubeMagaza"
        Me.colsSubeMagaza.Name = "colsSubeMagaza"
        '
        'colsSonKullaniciAdi
        '
        Me.colsSonKullaniciAdi.Caption = "Son Kullanıcı Adı"
        Me.colsSonKullaniciAdi.FieldName = "sSonKullaniciAdi"
        Me.colsSonKullaniciAdi.Name = "colsSonKullaniciAdi"
        '
        'coldteSonUpdateTarihi
        '
        Me.coldteSonUpdateTarihi.Caption = "UpdateTarihi"
        Me.coldteSonUpdateTarihi.FieldName = "dteSonUpdateTarihi"
        Me.coldteSonUpdateTarihi.Name = "coldteSonUpdateTarihi"
        '
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Firma Kodu"
        Me.colsFirmaKodu.FieldName = "sFirmaKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        '
        'colsFirmaAciklama
        '
        Me.colsFirmaAciklama.Caption = "Firma Açıklama"
        Me.colsFirmaAciklama.FieldName = "sFirmaAciklama"
        Me.colsFirmaAciklama.Name = "colsFirmaAciklama"
        '
        'colsHesapKodu
        '
        Me.colsHesapKodu.Caption = "Hesap Kodu"
        Me.colsHesapKodu.FieldName = "sHesapKodu"
        Me.colsHesapKodu.Name = "colsHesapKodu"
        Me.colsHesapKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sHesapKodu", "{0} Kayıt")})
        Me.colsHesapKodu.Visible = True
        Me.colsHesapKodu.VisibleIndex = 0
        Me.colsHesapKodu.Width = 104
        '
        'colsHesapAciklama
        '
        Me.colsHesapAciklama.Caption = "Hesap Açıklama"
        Me.colsHesapAciklama.FieldName = "sHesapAciklama"
        Me.colsHesapAciklama.Name = "colsHesapAciklama"
        Me.colsHesapAciklama.Visible = True
        Me.colsHesapAciklama.VisibleIndex = 1
        Me.colsHesapAciklama.Width = 171
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Width = 70
        '
        'colsCariIslem
        '
        Me.colsCariIslem.Caption = "İşlem"
        Me.colsCariIslem.FieldName = "sCariIslem"
        Me.colsCariIslem.Name = "colsCariIslem"
        Me.colsCariIslem.Width = 55
        '
        'colsEvrakNo
        '
        Me.colsEvrakNo.Caption = "Evrak No"
        Me.colsEvrakNo.FieldName = "sEvrakNo"
        Me.colsEvrakNo.Name = "colsEvrakNo"
        Me.colsEvrakNo.Width = 57
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(816, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Label9"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Ekle,Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Düzelt,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Yazdır,Ctrl+P"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        Me.BarButtonItem5.Caption = "Detay,F7"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem5.Name = "BarButtonItem5"
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
        'frm_tbMuhasebe_Yevmiye
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
        Me.Name = "frm_tbMuhasebe_Yevmiye"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yevmiye Fişleri..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_sDetay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sMuhFisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lYevmiyeNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lYevmiyeNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public sModul As String = "Cari"
    Public islemstatus As Boolean = False
    Dim ds_detay As DataSet
    Dim ds_tbsube As DataSet
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
        kriter += txt_dteFisTarihi1.EditValue & " ve " & txt_dteFisTarihi2.EditValue & " Tarihleri Arasındaki" & vbCrLf
        kriter += "FisNo: " & txt_lFisNo1.Text & " ve " & txt_lFisNo2.Text & " Arasindaki /" & "YevmiyeNo: " & txt_lYevmiyeNo1.Text & " ve " & txt_lYevmiyeNo2.Text & " Arasindaki "
        kriter += "Hesap: " & txt_ara.Text & " Konum : " & sec_konum.Text & " Kriter : " & sec_kriter.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal lFisBaslangic As Int64, ByVal lFisBitis As Int64, ByVal lYevmiyeBaslangic As Int64, ByVal lYevmiyeBitis As Int64, ByVal sMuhFisTipi As String, ByVal sSubeMagaza As String) As DataSet
        Dim kriter = " Where  a.dtefisTarihi between '" & tarih1 & "' and '" & tarih2 & "'"
        kriter += " AND a.lFisNo Between '" & lFisBaslangic & "' and '" & lFisBitis & "' "
        kriter += " AND a.lYevmiyeNo between '" & lYevmiyeBaslangic & "' and '" & lYevmiyeBitis & "' "
        If CStr(Trim(ara.ToString)) <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND a.nHesapID IN (Select nHesapID from tbHesapPlani WHERE (sKodu " & sorgu_kriter_string(ara, ara_kriter) & " ))"
            ElseIf sec_konum.Text = "Adı" Then
                kriter += " AND a.nHesapID IN (Select nHesapID from tbHesapPlani WHERE (sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " ))"
            End If
        End If
        kriter += " AND a.sMuhFisTipi ='" & sMuhFisTipi & "' "
        If Trim(sSubeMagaza) <> "" And sSubeMagaza <> "[Tümü]" Then
            kriter += " AND (a.sSubeMagaza IN (" & sSubeMagaza & ")) "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT a.lFisNo, lYevmiyeNo, a.dtefisTarihi, a.sMuhFisTipi, b.sAciklama AS sFis, b.sAciklama, lTutar = CASE WHEN SUM(lBorcTutar) <> 0 THEN SUM(lBorcTutar) ELSE - 1 * SUM(lAlacakTutar) END, ltrim(sAciklama1) + ' ' + ltrim(sAciklama2) + ' ' + ltrim(sAciklama3) + ' ' + ltrim(sAciklama4) + ' ' + ltrim(sAciklama5) AS sNot, sHangiUygulama = CASE WHEN sHangiUygulama = 'CHS' THEN 1 ELSE 0 END FROM tbMuhasebeFisiAciklamasi, tbMuhasebeFisi a, tbMuhFisTipi b WHERE tbMuhasebeFisiAciklamasi.dtefisTarihi = a.dtefisTarihi AND a.sMuhFisTipi = b.sMuhFisTipi AND tbMuhasebeFisiAciklamasi.lFisNo = a.lFisNo AND tbMuhasebeFisiAciklamasi.sMuhFisTipi = a.sMuhFisTipi " & kriter & " GROUP BY a.lFisNo, lYevmiyeNo, a.dtefisTarihi, a.sMuhFisTipi, b.sAciklama, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, CASE WHEN sHangiUygulama = 'CHS' THEN 1 ELSE 0 END ORDER BY a.dtefisTarihi, a.sMuhFisTipi, a.lFisNo")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT a.lFisno, a.lYevmiyeNo, a.dteFisTarihi, a.sMuhFisTipi, b.sAciklama AS sFis, a.sSubeMagaza,b.sAciklama, CASE WHEN SUM(lBorcTutar) <> 0 THEN SUM(lBorcTutar) ELSE - 1 * SUM(lAlacakTutar) END AS lTutar, LTRIM(tbMuhasebeFisiAciklamasi.sAciklama1) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama2) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama3) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama4) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama5) AS sNot, tbMuhasebeFisiAciklamasi.bKilitli,CASE WHEN sHangiUygulama = 'CHS' THEN 0 ELSE 1 END AS sHangiUygulama,bTamamlandi = CASE WHEN SUM(lBorcTutar - lAlacakTutar) = 0 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END FROM tbMuhFisTipi b INNER JOIN tbMuhasebeFisi a ON b.sMuhFisTipi = a.sMuhFisTipi LEFT OUTER JOIN tbMuhasebeFisiAciklamasi ON a.dteFisTarihi = tbMuhasebeFisiAciklamasi.dteFisTarihi AND a.lFisno = tbMuhasebeFisiAciklamasi.lFisno AND a.sMuhFisTipi = tbMuhasebeFisiAciklamasi.sMuhFisTipi " & kriter & " GROUP BY a.lFisno, a.lYevmiyeNo, a.dteFisTarihi, a.sMuhFisTipi, b.sAciklama,a.sSubeMagaza, tbMuhasebeFisiAciklamasi.sAciklama1, tbMuhasebeFisiAciklamasi.sAciklama2, tbMuhasebeFisiAciklamasi.sAciklama3, tbMuhasebeFisiAciklamasi.sAciklama4, tbMuhasebeFisiAciklamasi.sAciklama5,tbMuhasebeFisiAciklamasi.bKilitli, CASE WHEN sHangiUygulama = 'CHS' THEN 0 ELSE 1 END ORDER BY a.dteFisTarihi, a.sMuhFisTipi, a.sSubeMagaza,a.lFisno")
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisiAciklamasi SELECT DISTINCT dteFisTarihi, sMuhFisTipi, lFisno, '' AS sAciklama1, '' AS sAciklama2, '' AS sAciklama3, '' AS sAciklama4, '' AS sAciklama5, 0 AS bKilitli FROM tbMuhasebeFisi WHERE (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno NOT IN (SELECT lFisNo FROM tbMuhasebeFisiAciklamasi WHERE sMuhFisTipi = " & sMuhFisTipi & "))"
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT a.lFisno, a.lYevmiyeNo, a.dteFisTarihi, a.sMuhFisTipi, b.sAciklama AS sFis, a.sSubeMagaza,b.sAciklama, CASE WHEN SUM(lBorcTutar) <> 0 THEN SUM(lBorcTutar) ELSE - 1 * SUM(lAlacakTutar) END AS lTutar, LTRIM(tbMuhasebeFisiAciklamasi.sAciklama1) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama2) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama3) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama4) + ' ' + LTRIM(tbMuhasebeFisiAciklamasi.sAciklama5) AS sNot, tbMuhasebeFisiAciklamasi.bKilitli,CASE WHEN sHangiUygulama = 'CHS' THEN 0 ELSE 1 END AS sHangiUygulama,bTamamlandi = CASE WHEN SUM(lBorcTutar - lAlacakTutar) = 0 THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END FROM tbMuhFisTipi b INNER JOIN tbMuhasebeFisi a ON b.sMuhFisTipi = a.sMuhFisTipi LEFT OUTER JOIN tbMuhasebeFisiAciklamasi ON a.dteFisTarihi = tbMuhasebeFisiAciklamasi.dteFisTarihi AND a.lFisno = tbMuhasebeFisiAciklamasi.lFisno AND a.sMuhFisTipi = tbMuhasebeFisiAciklamasi.sMuhFisTipi " & kriter & " GROUP BY a.lFisno, a.lYevmiyeNo, a.dteFisTarihi, a.sMuhFisTipi, b.sAciklama,a.sSubeMagaza, tbMuhasebeFisiAciklamasi.sAciklama1, tbMuhasebeFisiAciklamasi.sAciklama2, tbMuhasebeFisiAciklamasi.sAciklama3, tbMuhasebeFisiAciklamasi.sAciklama4, tbMuhasebeFisiAciklamasi.sAciklama5,tbMuhasebeFisiAciklamasi.bKilitli, CASE WHEN sHangiUygulama = 'CHS' THEN 0 ELSE 1 END ORDER BY a.dteFisTarihi, a.sMuhFisTipi, a.sSubeMagaza,a.lFisno")
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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal lFisBaslangic As Int64, ByVal lFisBitis As Int64, ByVal lYevmiyeBaslangic As Int64, ByVal lYevmiyeBitis As Int64, ByVal sMuhFisTipi As String, ByVal sSubeMagaza As String)
        DataSet1 = stok(ara, konum, ara_kriter, tarih1, tarih2, lFisBaslangic, lFisBitis, lYevmiyeBaslangic, lYevmiyeBitis, sMuhFisTipi, sSubeMagaza)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
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
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_fis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbMuhasebeFisi
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.dteFisTarihi = dr("dtefisTarihi")
            frm.lFisNo = dr("lFisNo")
            frm.lYevmiyeNo = dr("lYevmiyeNo")
            frm.bMuhasabe = dr("sHangiUygulama")
            frm.sMuhFisTipi = dr("sMuhFisTipi")
            frm.kullanici = kullanici
            frm.sModul = sModul
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                Dim satir As String = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub tbMuhasebeFisi()
        Dim frm As New frm_tbMuhasebeFisi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.dteFisTarihi = Today
        frm.yeni = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sKodu")))) = True Then
                    frm.ShowDialog()
                End If
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
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
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
    Private Sub satir_fis_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Label9.Text = "Tarih: " & dr("dtefisTarihi") & vbTab & " BelgeNo: " & dr("lFisNo") & vbTab & " Tutar: " & dr("lTutar") & vbTab & " Not: " & dr("sNot")
            'ds_detay = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMuhasebeFisi.*, tbFirma.nFirmaID as nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS sCariIslem, tbFirmaHareketi.sEvrakNo AS sEvrakNo FROM tbMuhasebeFisi INNER JOIN tbFirma ON tbMuhasebeFisi.nHesapID = tbFirma.nHesapID INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID INNER JOIN tbFirmaHareketi ON tbMuhasebeFisi.nCariHareketID = tbFirmaHareketi.nHareketID WHERE (tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & ") AND (tbMuhasebeFisi.lFisno = " & dr("lFisNo") & ") AND (tbMuhasebeFisi.dteFisTarihi = '" & dr("dtefisTarihi") & "') ORDER BY nFisSiraID"))
            If sec_sDetay.Text = "Sadece Ana Hesaplar" Then
                'ds_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 1) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 1) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 1), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) ORDER BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 1)"))
                ds_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT * FROM (SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, tbMuhasebeFisi.sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbMuhasebeFisi.sAciklama,tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) ) tbYevmiye ORDER BY lFisNo, lYevmiyeNo, sHesapKodu"))
            ElseIf sec_sDetay.Text = "Sadece Kullanıcının Girdiği Hesaplar" Then
                ds_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMuhasebeFisi.*, tbFirma.nFirmaID AS nFirmaID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS sCariIslem, tbFirmaHareketi.sEvrakNo AS sEvrakNo FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN tbFirmaHareketi ON tbMuhasebeFisi.nCariHareketID = tbFirmaHareketi.nHareketID LEFT OUTER JOIN tbFirma ON tbMuhasebeFisi.nHesapID = tbFirma.nHesapID WHERE (tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & ") AND (tbMuhasebeFisi.lFisno = " & dr("lFisNo") & ") AND (tbMuhasebeFisi.dteFisTarihi = '" & dr("dteFisTarihi") & "') ORDER BY tbMuhasebeFisi.nFisSiraID"))
            ElseIf sec_sDetay.Text = "Tüm Hesaplar" Then
                ds_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT * FROM (SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 8) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 8) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 8), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 14) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, tbMuhasebeFisi.sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 14) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 14), tbtempKebir.sAciklamakebir, tbMuhasebeFisi.sAciklama, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999)) tbYevmiye ORDER BY nFisSiraID,lFisNo, lYevmiyeNo, sHesapKodu"))
            ElseIf sec_sDetay.Text = "Tüm Hesaplar Gruplara Kadar" Then
                ds_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT * FROM (SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 2) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 2) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 2), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 8) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 8) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 8), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 14) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, tbMuhasebeFisi.sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 14) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 14), tbtempKebir.sAciklamakebir, tbMuhasebeFisi.sAciklama, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999)) tbYevmiye ORDER BY nFisSiraID,lFisNo, lYevmiyeNo, sHesapKodu"))
            ElseIf sec_sDetay.Text = "Tüm Hesaplar Sınıflara Kadar" Then
                ds_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT * FROM (SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 1) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 1) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 1), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 2) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 2) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 2), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 8) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 8) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 8), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, SUBSTRING(tbHesapPlani.sKodu, 1, 14) AS sHesapKodu, tbtempKebir.sAciklamakebir AS sHesapAciklama, tbMuhasebeFisi.sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS nDurum,tbMuhasebeFisi.nFisSiraID FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 14) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dr("dteFisTarihi") & "' AND '" & dr("dteFisTarihi") & "') AND tbMuhasebeFisi.lFisNo = " & dr("lFisNo") & " AND tbMuhasebeFisi.sMuhFisTipi = " & dr("sMuhFisTipi") & " GROUP BY tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.nFisSiraID,SUBSTRING(tbHesapPlani.sKodu, 1, 14), tbtempKebir.sAciklamakebir, tbMuhasebeFisi.sAciklama, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999)) tbYevmiye ORDER BY nFisSiraID,lFisNo, lYevmiyeNo, sHesapKodu"))
            End If
            Dim dr1 As DataRow
            For Each dr1 In ds_detay.Tables(0).Rows
                If dr1("lBorcTutar") = 0 Then
                    dr1("sHesapKodu") = "" & vbTab & dr1("sHesapKodu")
                End If
            Next
            GridControl2.DataSource = ds_detay.Tables(0)
            GridControl2.DataMember = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.sModul = sModul
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            'nFirmaId = dr1("nFirmaID")
            'sKodu = dr1("sKodu")
            'lbl_Firma.Text = dr1("sAciklama")
            If sec_konum.Text = "Kodu" Then
                txt_ara.Text = dr1("sKodu")
            ElseIf sec_konum.Text = "Adı" Then
                txt_ara.Text = dr1("sAciklama")
            End If
            dr1 = Nothing
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If islemstatus = False Then
            If GridView1.RowCount > 0 Then
                analiz_fis()
            End If
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide Or DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            Try
                satir_fis_info()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("sNot").ToString
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lYevmiyeNo1.EditValue, txt_lYevmiyeNo2.EditValue)
        ara()
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
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lYevmiyeNo1.EditValue, txt_lYevmiyeNo2.EditValue, sec_sMuhFisTipi.EditValue, sec_sSubeMagaza.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
                    XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If islemstatus = False Then
                If GridView1.RowCount > 0 Then
                    analiz_fis()
                End If
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_fis()
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        dataload_sMuhFisTipi()
        dataload_tbSube()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lYevmiyeNo1.EditValue, txt_lYevmiyeNo2.EditValue, sec_sMuhFisTipi.EditValue, sec_sSubeMagaza.EditValue)
        'txt_dteFisTarihi1.Focus()
        'txt_dteFisTarihi1.Select()
    End Sub
    Private Sub dataload_sMuhFisTipi(Optional ByVal sMuhFisTipi As Integer = 3)
        sec_sMuhFisTipi.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMuhFisTipi Order by sMuhFisTipi DESC")).Tables(0)
        sec_sMuhFisTipi.EditValue = sMuhFisTipi
        sec_sMuhFisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbSube()
        If Trim(sSubeMagaza) = "D012" Or Trim(sDepo) = "D013" Then
            ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC,sSubeMagaza AS KOD,sAciklama  AS ACIKLAMA FROM         tbSubeMagaza Where sSubeMagaza IN ('012','013')"))
        Else
            ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC,sSubeMagaza AS KOD,sAciklama  AS ACIKLAMA FROM         tbSubeMagaza"))
        End If
        'sec_sSubeMagaza.Properties.DataSource = ds_tbsube.Tables(0)
        'sec_sSubeMagaza.ItemIndex = 1
        sec_sSubeMagaza.EditValue = "'" & sSubeMagaza & "'"
        If Trim(sSubeMagaza) = "001" Or Trim(sSubeMagaza) = "012" Or Trim(sSubeMagaza) = "013" Then
            sec_sSubeMagaza.Properties.ReadOnly = False
        ElseIf Trim(sSubeMagaza) = "" Then
            sec_sSubeMagaza.Properties.ReadOnly = False
        Else
            sec_sSubeMagaza.Properties.ReadOnly = True
        End If
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteFisTarihi1.Focus()
        txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        detay_goster()
    End Sub
    Private Sub detay_goster()
        If MenuItem22.Checked = False Then
            Try
                satir_fis_info()
            Catch ex As Exception
            End Try
            DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem22.Checked = True
        ElseIf MenuItem22.Checked = True Then
            DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem22.Checked = False
        End If
    End Sub
    Private Sub DockPanel1_VisibilityChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles DockPanel1.VisibilityChanged
        If DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem22.Checked = False
        ElseIf DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            MenuItem22.Checked = True
        End If
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.F4 Then
            firma_sec()
        ElseIf e.KeyCode = Keys.F6 Then
            firma_sec()
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        detay_goster()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        tbMuhasebeFisi()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_fis()
    End Sub
    Private Sub satirlar_kilit(ByVal bKilitli As Byte)
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                tbMuhasebeFisi_Kilit(dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), bKilitli)
            Next
        End If
        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        ara()
    End Sub
    Private Sub tbMuhasebeFisi_Kilit(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisNo As Int64, ByVal bKilitli As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbMuhasebeFisiAciklamasi set bKilitli = " & bKilitli & " where dteFisTarihi ='" & dteFisTarihi & "' and sMuhFisTipi ='" & sMuhFisTipi & "' and lFisNo =" & lFisNo & " ")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Fis Kayıtlarını Kilitlemek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(1)
            End If
        End If
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Bordro Kayıtlarının Kilitlerini Kaldırmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(0)
            End If
        End If
    End Sub
    Friend WithEvents colbTamamlandi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colsSube As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If MenuItem26.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem26.Checked = True
        ElseIf MenuItem26.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem26.Checked = False
        End If
    End Sub
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSubeMagaza As DevExpress.XtraEditors.PopupContainerEdit
    Private Sub sec_sSubeMagaza_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSubeMagaza.QueryPopUp
        sec_sSubeMagaza.Properties.PopupControl = sec_grid
        GridControl3.DataSource = ds_tbsube.Tables(0)
        GridControl3.DataMember = Nothing
    End Sub
    Private Sub sec_sSubeMagaza_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_sSubeMagaza.QueryResultValue
        Dim s As String = deger(ds_tbsube)
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
        Return s.ToString
    End Function
    Friend WithEvents sec_sDetay As DevExpress.XtraEditors.ComboBoxEdit
End Class
