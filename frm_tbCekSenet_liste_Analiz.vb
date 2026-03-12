Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbCekSenet_liste_Analiz
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
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents txt_dteBordroTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBordroNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBordroNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteBordroTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sCekSenetTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilen_sayi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_secilen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ortvade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sBankaKodu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sEvrakNo2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sEvrakNo1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_sTarih As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents GridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldlCekSenetNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsCekSenetTipi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlTutar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteVadeTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsYil As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsHafta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsQuarter As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBankaKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBankaHesapNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsIl As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSemt As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBorclusu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBorcluVergiDairesi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBorcluVergiNumarasi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsNot As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsCekSenetKodu1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsCekSenetKodu2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBankaAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsOrjinalCekSenetNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsVerenFirmaKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsVerenFirmaAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnSonCekSenetIslem As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsIslem As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAlanFirmaKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAlanFirmaAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsHareketTipi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsDovizCinsi1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlDovizMiktari1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlDovizKuru1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteBordroTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlTahsilat As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlKalan As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKullaniciAdi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteKayitTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsGun As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_nCekSenetIslem As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_magaza As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents sec_nGorunum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbCekSenet_liste_Analiz))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_nCekSenetIslem = New DevExpress.XtraEditors.PopupContainerEdit
        Me.sec_sTarih = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sBankaKodu = New DevExpress.XtraEditors.LookUpEdit
        Me.txt_sEvrakNo2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sEvrakNo1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sCekSenetTipi = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lBordroNo2 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lBordroNo1 = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteBordroTarihi2 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteBordroTarihi1 = New DevExpress.XtraEditors.DateEdit
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.sec_nGorunum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_ortvade = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_secilen = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_secilen_sayi = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.fieldlCekSenetNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsCekSenetTipi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlTutar = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fielddteVadeTarihi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAy = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsYil = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsHafta = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsQuarter = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBankaKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBankaHesapNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsIl = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSemt = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBorclusu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBorcluVergiDairesi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBorcluVergiNumarasi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsNot = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsCekSenetKodu1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsCekSenetKodu2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsBankaAciklama = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsOrjinalCekSenetNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsVerenFirmaKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsVerenFirmaAciklama = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnSonCekSenetIslem = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsIslem = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAlanFirmaKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAlanFirmaAciklama = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsHareketTipi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsDovizCinsi1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlDovizMiktari1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlDovizKuru1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fielddteBordroTarihi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlTahsilat = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlKalan = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsKullaniciAdi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fielddteKayitTarihi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsGun = New DevExpress.XtraPivotGrid.PivotGridField
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
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.ds_magaza = New System.Data.DataSet
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_nCekSenetIslem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sTarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sBankaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvrakNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvrakNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sCekSenetTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lBordroNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lBordroNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_nGorunum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 164)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_nCekSenetIslem)
        Me.GroupControl1.Controls.Add(Me.sec_sTarih)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.sec_sBankaKodu)
        Me.GroupControl1.Controls.Add(Me.txt_sEvrakNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_sEvrakNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sec_sCekSenetTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_lBordroNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_lBordroNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_dteBordroTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_dteBordroTarihi1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(491, 160)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_nCekSenetIslem
        '
        Me.sec_nCekSenetIslem.EditValue = "[Tümü]"
        Me.sec_nCekSenetIslem.EnterMoveNextControl = True
        Me.sec_nCekSenetIslem.Location = New System.Drawing.Point(215, 23)
        Me.sec_nCekSenetIslem.Name = "sec_nCekSenetIslem"
        Me.sec_nCekSenetIslem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nCekSenetIslem.Properties.ShowPopupCloseButton = False
        Me.sec_nCekSenetIslem.Size = New System.Drawing.Size(100, 20)
        Me.sec_nCekSenetIslem.TabIndex = 1
        '
        'sec_sTarih
        '
        Me.sec_sTarih.EditValue = "Vade:"
        Me.sec_sTarih.Location = New System.Drawing.Point(15, 48)
        Me.sec_sTarih.Name = "sec_sTarih"
        Me.sec_sTarih.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sTarih.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sTarih.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sTarih.Properties.Appearance.Options.UseFont = True
        Me.sec_sTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_sTarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sTarih.Properties.Items.AddRange(New Object() {"Vade:", "Tarih:"})
        Me.sec_sTarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sTarih.Size = New System.Drawing.Size(54, 18)
        Me.sec_sTarih.TabIndex = 30
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(5, 111)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "Banka:"
        '
        'sec_sBankaKodu
        '
        Me.sec_sBankaKodu.EnterMoveNextControl = True
        Me.sec_sBankaKodu.Location = New System.Drawing.Point(71, 111)
        Me.sec_sBankaKodu.Name = "sec_sBankaKodu"
        Me.sec_sBankaKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sBankaKodu.Properties.DisplayMember = "sAciklama"
        Me.sec_sBankaKodu.Properties.NullText = "[Bankalar]"
        Me.sec_sBankaKodu.Properties.ValueMember = "sBankaKodu"
        Me.sec_sBankaKodu.Size = New System.Drawing.Size(244, 20)
        Me.sec_sBankaKodu.TabIndex = 8
        '
        'txt_sEvrakNo2
        '
        Me.txt_sEvrakNo2.EditValue = "zzzzzzzzz"
        Me.txt_sEvrakNo2.EnterMoveNextControl = True
        Me.txt_sEvrakNo2.Location = New System.Drawing.Point(215, 89)
        Me.txt_sEvrakNo2.Name = "txt_sEvrakNo2"
        Me.txt_sEvrakNo2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEvrakNo2.Properties.Appearance.Options.UseFont = True
        Me.txt_sEvrakNo2.Properties.MaxLength = 15
        Me.txt_sEvrakNo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_sEvrakNo2.TabIndex = 7
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(177, 90)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "ve"
        '
        'txt_sEvrakNo1
        '
        Me.txt_sEvrakNo1.EnterMoveNextControl = True
        Me.txt_sEvrakNo1.Location = New System.Drawing.Point(71, 89)
        Me.txt_sEvrakNo1.Name = "txt_sEvrakNo1"
        Me.txt_sEvrakNo1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEvrakNo1.Properties.Appearance.Options.UseFont = True
        Me.txt_sEvrakNo1.Properties.MaxLength = 15
        Me.txt_sEvrakNo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_sEvrakNo1.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(5, 90)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl9.TabIndex = 24
        Me.LabelControl9.Text = "EvrakNo:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(174, 23)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 20)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Durum:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "EvrakTipi:"
        '
        'sec_sCekSenetTipi
        '
        Me.sec_sCekSenetTipi.EnterMoveNextControl = True
        Me.sec_sCekSenetTipi.Location = New System.Drawing.Point(71, 23)
        Me.sec_sCekSenetTipi.Name = "sec_sCekSenetTipi"
        Me.sec_sCekSenetTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sCekSenetTipi.Properties.DisplayMember = "sCekSenetTipi"
        Me.sec_sCekSenetTipi.Properties.NullText = "[CekSenetTipi]"
        Me.sec_sCekSenetTipi.Properties.ValueMember = "sCekSenetTipi"
        Me.sec_sCekSenetTipi.Size = New System.Drawing.Size(100, 20)
        Me.sec_sCekSenetTipi.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(5, 133)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Hesap:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(317, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasýndaki"
        '
        'txt_lBordroNo2
        '
        Me.txt_lBordroNo2.EditValue = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txt_lBordroNo2.EnterMoveNextControl = True
        Me.txt_lBordroNo2.Location = New System.Drawing.Point(215, 67)
        Me.txt_lBordroNo2.Name = "txt_lBordroNo2"
        Me.txt_lBordroNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lBordroNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lBordroNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lBordroNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lBordroNo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lBordroNo2.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(177, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lBordroNo1
        '
        Me.txt_lBordroNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_lBordroNo1.EnterMoveNextControl = True
        Me.txt_lBordroNo1.Location = New System.Drawing.Point(71, 67)
        Me.txt_lBordroNo1.Name = "txt_lBordroNo1"
        Me.txt_lBordroNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBordroNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lBordroNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lBordroNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lBordroNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_lBordroNo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lBordroNo1.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(5, 68)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "PortföyNo:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(317, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Arasýndaki"
        '
        'txt_dteBordroTarihi2
        '
        Me.txt_dteBordroTarihi2.EditValue = Nothing
        Me.txt_dteBordroTarihi2.EnterMoveNextControl = True
        Me.txt_dteBordroTarihi2.Location = New System.Drawing.Point(215, 45)
        Me.txt_dteBordroTarihi2.Name = "txt_dteBordroTarihi2"
        Me.txt_dteBordroTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteBordroTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteBordroTarihi2.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteBordroTarihi2.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(177, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "ve"
        '
        'txt_dteBordroTarihi1
        '
        Me.txt_dteBordroTarihi1.EditValue = Nothing
        Me.txt_dteBordroTarihi1.EnterMoveNextControl = True
        Me.txt_dteBordroTarihi1.Location = New System.Drawing.Point(71, 45)
        Me.txt_dteBordroTarihi1.Name = "txt_dteBordroTarihi1"
        Me.txt_dteBordroTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteBordroTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteBordroTarihi1.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteBordroTarihi1.TabIndex = 2
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(217, 133)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adý"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 10
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(392, 133)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(317, 133)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 11
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(71, 133)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(146, 20)
        Me.txt_ara.TabIndex = 9
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(587, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(235, 160)
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.sec_nGorunum)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.lbl_ortvade)
        Me.PanelControl2.Controls.Add(Me.LabelControl16)
        Me.PanelControl2.Controls.Add(Me.lbl_gun)
        Me.PanelControl2.Controls.Add(Me.LabelControl17)
        Me.PanelControl2.Controls.Add(Me.lbl_secilen)
        Me.PanelControl2.Controls.Add(Me.LabelControl14)
        Me.PanelControl2.Controls.Add(Me.lbl_secilen_sayi)
        Me.PanelControl2.Controls.Add(Me.LabelControl13)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 367)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'sec_nGorunum
        '
        Me.sec_nGorunum.EditValue = "0"
        Me.sec_nGorunum.Location = New System.Drawing.Point(80, 6)
        Me.sec_nGorunum.Name = "sec_nGorunum"
        Me.sec_nGorunum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nGorunum.Properties.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.sec_nGorunum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_nGorunum.Size = New System.Drawing.Size(73, 20)
        Me.sec_nGorunum.TabIndex = 55
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(11, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 54
        Me.LabelControl2.Text = "GörünümTipi:"
        '
        'lbl_ortvade
        '
        Me.lbl_ortvade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ortvade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_ortvade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_ortvade.Location = New System.Drawing.Point(509, 23)
        Me.lbl_ortvade.Name = "lbl_ortvade"
        Me.lbl_ortvade.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ortvade.TabIndex = 30
        Me.lbl_ortvade.Text = "%"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(427, 23)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl16.TabIndex = 29
        Me.LabelControl16.Text = "OrtalamaVade:"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(509, 7)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(13, 13)
        Me.lbl_gun.TabIndex = 28
        Me.lbl_gun.Text = "%"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.Location = New System.Drawing.Point(427, 7)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl17.TabIndex = 27
        Me.LabelControl17.Text = "OrtalamaGün:"
        '
        'lbl_secilen
        '
        Me.lbl_secilen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen.Location = New System.Drawing.Point(368, 22)
        Me.lbl_secilen.Name = "lbl_secilen"
        Me.lbl_secilen.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilen.TabIndex = 26
        Me.lbl_secilen.Text = "%"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(294, 22)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl14.TabIndex = 25
        Me.LabelControl14.Text = "SeçilenTutar:"
        '
        'lbl_secilen_sayi
        '
        Me.lbl_secilen_sayi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_secilen_sayi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_secilen_sayi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_secilen_sayi.Location = New System.Drawing.Point(368, 8)
        Me.lbl_secilen_sayi.Name = "lbl_secilen_sayi"
        Me.lbl_secilen_sayi.Size = New System.Drawing.Size(13, 13)
        Me.lbl_secilen_sayi.TabIndex = 14
        Me.lbl_secilen_sayi.Text = "%"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(294, 8)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl13.TabIndex = 13
        Me.LabelControl13.Text = "SeçilenEvrak:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(128, 29)
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 164)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 203)
        Me.PanelControl3.TabIndex = 0
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(296, 29)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 4
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
        'GridControl1
        '
        Me.GridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldlCekSenetNo, Me.fieldsCekSenetTipi, Me.fieldlTutar, Me.fielddteVadeTarihi, Me.fieldsAy, Me.fieldsYil, Me.fieldsHafta, Me.fieldsQuarter, Me.fieldsBankaKodu, Me.fieldsBankaHesapNo, Me.fieldsIl, Me.fieldsSemt, Me.fieldsBorclusu, Me.fieldsBorcluVergiDairesi, Me.fieldsBorcluVergiNumarasi, Me.fieldsNot, Me.fieldsCekSenetKodu1, Me.fieldsCekSenetKodu2, Me.fieldsBankaAciklama, Me.fieldsOrjinalCekSenetNo, Me.fieldsVerenFirmaKodu, Me.fieldsVerenFirmaAciklama, Me.fieldnSonCekSenetIslem, Me.fieldsIslem, Me.fieldsAlanFirmaKodu, Me.fieldsAlanFirmaAciklama, Me.fieldsHareketTipi, Me.fieldsDovizCinsi1, Me.fieldlDovizMiktari1, Me.fieldlDovizKuru1, Me.fielddteBordroTarihi, Me.fieldlTahsilat, Me.fieldlKalan, Me.fieldsKullaniciAdi, Me.fielddteKayitTarihi, Me.fieldsGun})
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.GridControl1.OptionsDataField.AreaIndex = 0
        Me.GridControl1.Size = New System.Drawing.Size(820, 199)
        Me.GridControl1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem13, Me.MenuItem14, Me.MenuItem18, Me.MenuItem15, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem18.Text = "Fiþi Göster"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 6
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = False
        Me.MenuItem17.Index = 7
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Firma Hareketleri"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 9
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 11
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 12
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 14
        Me.MenuItem22.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 15
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 16
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 17
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 18
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 19
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 20
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 21
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'fieldlCekSenetNo
        '
        Me.fieldlCekSenetNo.AreaIndex = 0
        Me.fieldlCekSenetNo.Caption = "Portföy"
        Me.fieldlCekSenetNo.FieldName = "lCekSenetNo"
        Me.fieldlCekSenetNo.Name = "fieldlCekSenetNo"
        Me.fieldlCekSenetNo.Visible = False
        '
        'fieldsCekSenetTipi
        '
        Me.fieldsCekSenetTipi.AreaIndex = 2
        Me.fieldsCekSenetTipi.Caption = "CekSenetTipi"
        Me.fieldsCekSenetTipi.FieldName = "sCekSenetTipi"
        Me.fieldsCekSenetTipi.Name = "fieldsCekSenetTipi"
        Me.fieldsCekSenetTipi.Visible = False
        '
        'fieldlTutar
        '
        Me.fieldlTutar.AreaIndex = 0
        Me.fieldlTutar.Caption = "Tutar"
        Me.fieldlTutar.CellFormat.FormatString = "#,0.00"
        Me.fieldlTutar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTutar.FieldName = "lTutar"
        Me.fieldlTutar.GrandTotalCellFormat.FormatString = "#,0.00"
        Me.fieldlTutar.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTutar.Name = "fieldlTutar"
        Me.fieldlTutar.TotalCellFormat.FormatString = "#,0.00"
        Me.fieldlTutar.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTutar.TotalValueFormat.FormatString = "#,0.00"
        Me.fieldlTutar.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTutar.ValueFormat.FormatString = "#,0.00"
        Me.fieldlTutar.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTutar.Visible = False
        '
        'fielddteVadeTarihi
        '
        Me.fielddteVadeTarihi.AreaIndex = 4
        Me.fielddteVadeTarihi.Caption = "Vade"
        Me.fielddteVadeTarihi.FieldName = "dteVadeTarihi"
        Me.fielddteVadeTarihi.Name = "fielddteVadeTarihi"
        Me.fielddteVadeTarihi.Visible = False
        '
        'fieldsAy
        '
        Me.fieldsAy.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsAy.AreaIndex = 1
        Me.fieldsAy.Caption = "Ay"
        Me.fieldsAy.FieldName = "sAy"
        Me.fieldsAy.Name = "fieldsAy"
        '
        'fieldsYil
        '
        Me.fieldsYil.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsYil.AreaIndex = 0
        Me.fieldsYil.Caption = "Yýl"
        Me.fieldsYil.FieldName = "sYil"
        Me.fieldsYil.Name = "fieldsYil"
        '
        'fieldsHafta
        '
        Me.fieldsHafta.AreaIndex = 1
        Me.fieldsHafta.Caption = "Hafta"
        Me.fieldsHafta.FieldName = "sHafta"
        Me.fieldsHafta.Name = "fieldsHafta"
        '
        'fieldsQuarter
        '
        Me.fieldsQuarter.AreaIndex = 2
        Me.fieldsQuarter.Caption = "Quarter"
        Me.fieldsQuarter.FieldName = "sQuarter"
        Me.fieldsQuarter.Name = "fieldsQuarter"
        '
        'fieldsBankaKodu
        '
        Me.fieldsBankaKodu.AreaIndex = 8
        Me.fieldsBankaKodu.Caption = "Banka Kodu"
        Me.fieldsBankaKodu.FieldName = "sBankaKodu"
        Me.fieldsBankaKodu.Name = "fieldsBankaKodu"
        Me.fieldsBankaKodu.Visible = False
        '
        'fieldsBankaHesapNo
        '
        Me.fieldsBankaHesapNo.AreaIndex = 3
        Me.fieldsBankaHesapNo.Caption = "Hesap No"
        Me.fieldsBankaHesapNo.FieldName = "sBankaHesapNo"
        Me.fieldsBankaHesapNo.Name = "fieldsBankaHesapNo"
        '
        'fieldsIl
        '
        Me.fieldsIl.AreaIndex = 8
        Me.fieldsIl.Caption = "il"
        Me.fieldsIl.FieldName = "sIl"
        Me.fieldsIl.Name = "fieldsIl"
        Me.fieldsIl.Visible = False
        '
        'fieldsSemt
        '
        Me.fieldsSemt.AreaIndex = 8
        Me.fieldsSemt.Caption = "Semt"
        Me.fieldsSemt.FieldName = "sSemt"
        Me.fieldsSemt.Name = "fieldsSemt"
        Me.fieldsSemt.Visible = False
        '
        'fieldsBorclusu
        '
        Me.fieldsBorclusu.AreaIndex = 8
        Me.fieldsBorclusu.Caption = "Borçlusu"
        Me.fieldsBorclusu.FieldName = "sBorclusu"
        Me.fieldsBorclusu.Name = "fieldsBorclusu"
        Me.fieldsBorclusu.Visible = False
        '
        'fieldsBorcluVergiDairesi
        '
        Me.fieldsBorcluVergiDairesi.AreaIndex = 8
        Me.fieldsBorcluVergiDairesi.Caption = "Borçlu Vergi Dairesi"
        Me.fieldsBorcluVergiDairesi.FieldName = "sBorcluVergiDairesi"
        Me.fieldsBorcluVergiDairesi.Name = "fieldsBorcluVergiDairesi"
        Me.fieldsBorcluVergiDairesi.Visible = False
        '
        'fieldsBorcluVergiNumarasi
        '
        Me.fieldsBorcluVergiNumarasi.AreaIndex = 8
        Me.fieldsBorcluVergiNumarasi.Caption = "Borçlu Vergi No"
        Me.fieldsBorcluVergiNumarasi.FieldName = "sBorcluVergiNumarasi"
        Me.fieldsBorcluVergiNumarasi.Name = "fieldsBorcluVergiNumarasi"
        Me.fieldsBorcluVergiNumarasi.Visible = False
        '
        'fieldsNot
        '
        Me.fieldsNot.AreaIndex = 8
        Me.fieldsNot.Caption = "Not"
        Me.fieldsNot.FieldName = "sNot"
        Me.fieldsNot.Name = "fieldsNot"
        Me.fieldsNot.Visible = False
        '
        'fieldsCekSenetKodu1
        '
        Me.fieldsCekSenetKodu1.AreaIndex = 8
        Me.fieldsCekSenetKodu1.Caption = "Kod 1"
        Me.fieldsCekSenetKodu1.FieldName = "sCekSenetKodu1"
        Me.fieldsCekSenetKodu1.Name = "fieldsCekSenetKodu1"
        Me.fieldsCekSenetKodu1.Visible = False
        '
        'fieldsCekSenetKodu2
        '
        Me.fieldsCekSenetKodu2.AreaIndex = 8
        Me.fieldsCekSenetKodu2.Caption = "Kod 2"
        Me.fieldsCekSenetKodu2.FieldName = "sCekSenetKodu2"
        Me.fieldsCekSenetKodu2.Name = "fieldsCekSenetKodu2"
        Me.fieldsCekSenetKodu2.Visible = False
        '
        'fieldsBankaAciklama
        '
        Me.fieldsBankaAciklama.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsBankaAciklama.AreaIndex = 0
        Me.fieldsBankaAciklama.Caption = "Banka"
        Me.fieldsBankaAciklama.FieldName = "sBankaAciklama"
        Me.fieldsBankaAciklama.Name = "fieldsBankaAciklama"
        '
        'fieldsOrjinalCekSenetNo
        '
        Me.fieldsOrjinalCekSenetNo.AreaIndex = 21
        Me.fieldsOrjinalCekSenetNo.Caption = "Evrak No"
        Me.fieldsOrjinalCekSenetNo.FieldName = "sOrjinalCekSenetNo"
        Me.fieldsOrjinalCekSenetNo.Name = "fieldsOrjinalCekSenetNo"
        Me.fieldsOrjinalCekSenetNo.Visible = False
        '
        'fieldsVerenFirmaKodu
        '
        Me.fieldsVerenFirmaKodu.AreaIndex = 22
        Me.fieldsVerenFirmaKodu.Caption = "Firma Kodu"
        Me.fieldsVerenFirmaKodu.FieldName = "sVerenFirmaKodu"
        Me.fieldsVerenFirmaKodu.Name = "fieldsVerenFirmaKodu"
        Me.fieldsVerenFirmaKodu.Visible = False
        '
        'fieldsVerenFirmaAciklama
        '
        Me.fieldsVerenFirmaAciklama.AreaIndex = 23
        Me.fieldsVerenFirmaAciklama.Caption = "Firma Adý"
        Me.fieldsVerenFirmaAciklama.FieldName = "sVerenFirmaAciklama"
        Me.fieldsVerenFirmaAciklama.Name = "fieldsVerenFirmaAciklama"
        Me.fieldsVerenFirmaAciklama.Visible = False
        '
        'fieldnSonCekSenetIslem
        '
        Me.fieldnSonCekSenetIslem.AreaIndex = 24
        Me.fieldnSonCekSenetIslem.Caption = "Çek Senet Ýþlem"
        Me.fieldnSonCekSenetIslem.FieldName = "nSonCekSenetIslem"
        Me.fieldnSonCekSenetIslem.Name = "fieldnSonCekSenetIslem"
        Me.fieldnSonCekSenetIslem.Visible = False
        '
        'fieldsIslem
        '
        Me.fieldsIslem.AreaIndex = 25
        Me.fieldsIslem.Caption = "Durum"
        Me.fieldsIslem.FieldName = "sIslem"
        Me.fieldsIslem.Name = "fieldsIslem"
        Me.fieldsIslem.Visible = False
        '
        'fieldsAlanFirmaKodu
        '
        Me.fieldsAlanFirmaKodu.AreaIndex = 26
        Me.fieldsAlanFirmaKodu.Caption = "Alan Hesap Kodu"
        Me.fieldsAlanFirmaKodu.FieldName = "sAlanFirmaKodu"
        Me.fieldsAlanFirmaKodu.Name = "fieldsAlanFirmaKodu"
        Me.fieldsAlanFirmaKodu.Visible = False
        '
        'fieldsAlanFirmaAciklama
        '
        Me.fieldsAlanFirmaAciklama.AreaIndex = 27
        Me.fieldsAlanFirmaAciklama.Caption = "Alan Hesap Adý"
        Me.fieldsAlanFirmaAciklama.FieldName = "sAlanFirmaAciklama"
        Me.fieldsAlanFirmaAciklama.Name = "fieldsAlanFirmaAciklama"
        Me.fieldsAlanFirmaAciklama.Visible = False
        '
        'fieldsHareketTipi
        '
        Me.fieldsHareketTipi.AreaIndex = 28
        Me.fieldsHareketTipi.Caption = "HT"
        Me.fieldsHareketTipi.FieldName = "sHareketTipi"
        Me.fieldsHareketTipi.Name = "fieldsHareketTipi"
        Me.fieldsHareketTipi.Visible = False
        '
        'fieldsDovizCinsi1
        '
        Me.fieldsDovizCinsi1.AreaIndex = 29
        Me.fieldsDovizCinsi1.Caption = "Pb"
        Me.fieldsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.fieldsDovizCinsi1.Name = "fieldsDovizCinsi1"
        Me.fieldsDovizCinsi1.Visible = False
        '
        'fieldlDovizMiktari1
        '
        Me.fieldlDovizMiktari1.AreaIndex = 30
        Me.fieldlDovizMiktari1.Caption = "Döviz Tutar"
        Me.fieldlDovizMiktari1.CellFormat.FormatString = "#,0.00##"
        Me.fieldlDovizMiktari1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.fieldlDovizMiktari1.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlDovizMiktari1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizMiktari1.Name = "fieldlDovizMiktari1"
        Me.fieldlDovizMiktari1.TotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlDovizMiktari1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizMiktari1.TotalValueFormat.FormatString = "#,0.00##"
        Me.fieldlDovizMiktari1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizMiktari1.ValueFormat.FormatString = "#,0.00##"
        Me.fieldlDovizMiktari1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizMiktari1.Visible = False
        '
        'fieldlDovizKuru1
        '
        Me.fieldlDovizKuru1.AreaIndex = 31
        Me.fieldlDovizKuru1.Caption = "Kur"
        Me.fieldlDovizKuru1.CellFormat.FormatString = "#,0.00##"
        Me.fieldlDovizKuru1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizKuru1.FieldName = "lDovizKuru1"
        Me.fieldlDovizKuru1.GrandTotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlDovizKuru1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizKuru1.Name = "fieldlDovizKuru1"
        Me.fieldlDovizKuru1.TotalCellFormat.FormatString = "#,0.00##"
        Me.fieldlDovizKuru1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizKuru1.TotalValueFormat.FormatString = "#,0.00##"
        Me.fieldlDovizKuru1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizKuru1.ValueFormat.FormatString = "#,0.00##"
        Me.fieldlDovizKuru1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlDovizKuru1.Visible = False
        '
        'fielddteBordroTarihi
        '
        Me.fielddteBordroTarihi.AreaIndex = 32
        Me.fielddteBordroTarihi.Caption = "Bordro Tarihi"
        Me.fielddteBordroTarihi.FieldName = "dteBordroTarihi"
        Me.fielddteBordroTarihi.Name = "fielddteBordroTarihi"
        Me.fielddteBordroTarihi.Visible = False
        '
        'fieldlTahsilat
        '
        Me.fieldlTahsilat.AreaIndex = 32
        Me.fieldlTahsilat.Caption = "Tahsilat"
        Me.fieldlTahsilat.CellFormat.FormatString = "#,0.00"
        Me.fieldlTahsilat.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTahsilat.FieldName = "lTahsilat"
        Me.fieldlTahsilat.GrandTotalCellFormat.FormatString = "#,0.00"
        Me.fieldlTahsilat.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTahsilat.Name = "fieldlTahsilat"
        Me.fieldlTahsilat.TotalCellFormat.FormatString = "#,0.00"
        Me.fieldlTahsilat.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTahsilat.TotalValueFormat.FormatString = "#,0.00"
        Me.fieldlTahsilat.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTahsilat.ValueFormat.FormatString = "#,0.00"
        Me.fieldlTahsilat.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlTahsilat.Visible = False
        '
        'fieldlKalan
        '
        Me.fieldlKalan.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldlKalan.AreaIndex = 0
        Me.fieldlKalan.Caption = "Kalan"
        Me.fieldlKalan.CellFormat.FormatString = "#,0.00"
        Me.fieldlKalan.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.FieldName = "lKalan"
        Me.fieldlKalan.GrandTotalCellFormat.FormatString = "#,0.00"
        Me.fieldlKalan.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.Name = "fieldlKalan"
        Me.fieldlKalan.TotalCellFormat.FormatString = "#,0.00"
        Me.fieldlKalan.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.TotalValueFormat.FormatString = "#,0.00"
        Me.fieldlKalan.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlKalan.ValueFormat.FormatString = "#,0.00"
        Me.fieldlKalan.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldsKullaniciAdi
        '
        Me.fieldsKullaniciAdi.AreaIndex = 31
        Me.fieldsKullaniciAdi.Caption = "Kaydeden"
        Me.fieldsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.fieldsKullaniciAdi.Name = "fieldsKullaniciAdi"
        Me.fieldsKullaniciAdi.Visible = False
        '
        'fielddteKayitTarihi
        '
        Me.fielddteKayitTarihi.AreaIndex = 32
        Me.fielddteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.fielddteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.fielddteKayitTarihi.Name = "fielddteKayitTarihi"
        Me.fielddteKayitTarihi.Visible = False
        '
        'fieldsGun
        '
        Me.fieldsGun.AreaIndex = 0
        Me.fieldsGun.Caption = "Gün"
        Me.fieldsGun.FieldName = "sGun"
        Me.fieldsGun.Name = "fieldsGun"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nCekSenetID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lCekSenetNo"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sCekSenetTipi"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lTutar"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dteVadeTarihi"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sAy"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sYil"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sHafta"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sQuarter"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sBankaKodu"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sBankaHesapNo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sIl"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sSemt"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sBorclusu"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sBorcluVergiDairesi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sBorcluVergiNumarasi"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sNot"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nVerenID"
        Me.DataColumn18.DataType = GetType(Long)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sCekSenetKodu1"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sCekSenetKodu2"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sBankaAciklama"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sOrjinalCekSenetNo"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sVerenFirmaKodu"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sVerenFirmaAciklama"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "nSonCekSenetIslem"
        Me.DataColumn25.DataType = GetType(Long)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sIslem"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sAlanFirmaKodu"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sAlanFirmaAciklama"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sHareketTipi"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sDovizCinsi1"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "lDovizMiktari1"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "lDovizKuru1"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nBordroSatirID"
        Me.DataColumn33.DataType = GetType(Long)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "dteBordroTarihi"
        Me.DataColumn34.DataType = GetType(Date)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "lTahsilat"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "lKalan"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sKullaniciAdi"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "dteKayitTarihi"
        Me.DataColumn38.DataType = GetType(Date)
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Cek/Senet Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13})
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Excel"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Text"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Mail"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Çýkýþ"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem13.Name = "BarButtonItem13"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 415)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 415)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 415)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ekle,Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Düzelt,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Firma Kartý"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
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
        Me.BarButtonItem7.Caption = "Banka Kartý"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Banka Hareketleri"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Cek/Senet Hareketleri,F7"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'ds_magaza
        '
        Me.ds_magaza.DataSetName = "NewDataSet"
        Me.ds_magaza.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_magaza.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn49, Me.DataColumn50, Me.DataColumn51})
        Me.DataTable3.TableName = "Table1"
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
        'frm_tbCekSenet_liste_Analiz
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 440)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbCekSenet_liste_Analiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CekSenet Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_nCekSenetIslem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sTarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sBankaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvrakNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvrakNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sCekSenetTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lBordroNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lBordroNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_nGorunum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public nFirmaID As Int64 = 0
    Public islemstatus As Boolean = False
    Dim ds_tbCekSenetTipi As DataSet
    Dim ds_tbCekSenetIslem As DataSet
    Dim ds_tbBankaKodu As DataSet
    Public sCekSenetTipi As String = ""
    Public nCekSenetIslem As String = 0
    Public bCekSenetIslemGoster As Boolean = False
    Public sCekSenetIslem As String = ""
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridControl1.FieldsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridControl1.ExpandAllColumns()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridControl1.CollapseAllColumns()
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
        kriter += "EvrakTipi = " & sec_sCekSenetTipi.Text & vbTab & "Islem = " & sec_nCekSenetIslem.Text
        kriter += txt_dteBordroTarihi1.EditValue & " ve " & txt_dteBordroTarihi2.EditValue & " Tarihleri Arasýndaki" & vbCrLf
        kriter += "Portföy: " & txt_lBordroNo1.Text & " ve " & txt_lBordroNo1.Text & " Arasindaki " & "Evrakno = " & txt_sEvrakNo1.Text & " ve " & txt_sEvrakNo1.Text & "Arasindaki"
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Kambiyo Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\tbCekSenetListe\" & Me.Name.ToString & "\" & Trim(sec_sCekSenetTipi.EditValue) & "\" & sec_nGorunum.Text & "\")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridControl1.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridControl1.Appearance.HeaderArea.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridControl1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraPivotGrid.PivotGridField In GridControl1.Fields
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\tbCekSenetListe\" & Me.Name.ToString & "\" & Trim(sec_sCekSenetTipi.EditValue) & "\" & sec_nGorunum.Text & "\")
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
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub dataload_tbCekSenetTipi()
        ds_tbCekSenetTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCekSenetTipi,sAciklama FROM         tbCekSenetTipi"))
        sec_sCekSenetTipi.Properties.DataSource = ds_tbCekSenetTipi.Tables(0)
        If sCekSenetTipi.ToString <> "" Then
            sec_sCekSenetTipi.EditValue = sCekSenetTipi
            dataload_tbCekSenetIslem(Trim(sec_sCekSenetTipi.EditValue), sCekSenetIslem)
            'sec_sCekSenetTipi.Enabled = False
        Else
            sec_sCekSenetTipi.ItemIndex = 0
        End If
    End Sub
    Private Sub dataload_tbCekSenetIslem(Optional ByVal sCekSenetTipi As String = "AC", Optional ByVal sCekSenetIslem As String = "")
        Dim kriter As String = ""
        If sCekSenetIslem = "" Then
        Else
            kriter = " AND nCekSenetIslem IN(" & sCekSenetIslem & ") "
        End If
        If sCekSenetTipi = "AC" Or sCekSenetTipi = "AS" Then
            ds_tbCekSenetIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 AS nCekSenetIslem , '[Tümü]' AS sAciklama UNION ALL SELECT * FROM tbCekSenetIslem WHERE (nCekSenetIslem < 20) " & kriter & " "))
            ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nCekSenetIslem AS KOD, sAciklama AS ACIKLAMA FROM         tbCekSenetIslem  WHERE (nCekSenetIslem < 20) " & kriter & " ORDER BY nCekSenetIslem"))
        ElseIf sCekSenetTipi = "BC" Or sCekSenetTipi = "BS" Then
            ds_tbCekSenetIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 AS nCekSenetIslem , '[Tümü]' AS sAciklama UNION ALL SELECT * FROM tbCekSenetIslem WHERE (nCekSenetIslem >= 20)"))
            ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nCekSenetIslem AS KOD, sAciklama AS ACIKLAMA FROM         tbCekSenetIslem  WHERE (nCekSenetIslem >= 20)  ORDER BY nCekSenetIslem"))
        End If
        'sec_nCekSenetIslem.Properties.DataSource = ds_tbCekSenetIslem.Tables(0)
        If nCekSenetIslem = 0 Then
            'sec_nCekSenetIslem.ItemIndex = 0
        Else
            sec_nCekSenetIslem.EditValue = "'" + nCekSenetIslem.ToString + "'"
            sec_nCekSenetIslem.Enabled = bCekSenetIslemGoster
        End If
    End Sub
    Private Sub dataload_tbBankaKodu()
        ds_tbBankaKodu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sBankaKodu,sAciklama FROM         tbBanka"))
        sec_sBankaKodu.Properties.DataSource = ds_tbBankaKodu.Tables(0)
    End Sub
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sTarih As String) As DataSet
        Dim kriter As String = "WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "')"
        If sTarih = "Vade:" Then
            kriter += " AND tbCekSenet.dteVadeTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        ElseIf sTarih = "Tarih:" Then
            kriter += " AND tbCekSenetBordro.dteBordroTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        End If
        kriter += " and tbCekSenet.lCekSenetNo between '" & lBordroNo1 & "' and '" & lBordroNo2 & "'"
        kriter += " and tbCekSenet.sOrjinalCekSenetNo between '" & sEvrakNo1 & "' and '" & sEvrakNo2 & "'"
        If Trim(sBankaKodu) <> "" Then
            kriter += " And tbCekSenet.sBankaKodu = '" & sBankaKodu & "' "
        End If
        If nCekSenetIslem <> "[Tümü]" Then
            kriter += " and tbCekSenetBordro.nCekSenetIslem IN (" & nCekSenetIslem & ") "
        End If
        'If CStr(Trim(ara.ToString)) <> "" Then
        '    If sec_konum.Text = "Kodu" Then
        '        kriter += " AND   (tbFirma_1.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    ElseIf sec_konum.Text = "Adý" Then
        '        kriter += " AND  (tbFirma_1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    End If
        'End If
        If sec_nCekSenetIslem.EditValue = "'1'" Or sec_nCekSenetIslem.EditValue = "'6'" Then
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (Veren.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (Veren.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        Else
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbFirma_1.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adý" Then
                    kriter += " AND  (tbFirma_1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.sCekSenetTipi,tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, MONTH(tbCekSenet.dteVadeTarihi) AS sAy, DAY(tbCekSenet.dteVadeTarihi) AS sGun, YEAR(tbCekSenet.dteVadeTarihi) AS sYil, { fn WEEK(tbCekSenet.dteVadeTarihi) } AS sHafta, { fn QUARTER(tbCekSenet.dteVadeTarihi) } AS sQuarter,tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.nVerenID,tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, VEREN.sKodu AS sAlanFirmaKodu, VEREN.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi,(SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lTahsilat, tbCekSenet.lTutar - (SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lKalan,tbCekSenet.sKullaniciAdi,tbCekSenet.dteKayitTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.sCekSenetTipi,tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, MONTH(tbCekSenet.dteVadeTarihi) AS sAy, DAY(tbCekSenet.dteVadeTarihi) AS sGun, YEAR(tbCekSenet.dteVadeTarihi) AS sYil, { fn WEEK(tbCekSenet.dteVadeTarihi) } AS sHafta, { fn QUARTER(tbCekSenet.dteVadeTarihi) } AS sQuarter,tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.nVerenID,tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, tbFirma_1.sKodu AS sAlanFirmaKodu, tbFirma_1.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi,(SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lTahsilat, tbCekSenet.lTutar - (SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lKalan,tbCekSenet.sKullaniciAdi,tbCekSenet.dteKayitTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi")
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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sTarih As String)
        DataSet1 = stok(ara, konum, ara_kriter, sCekSenetTipi, nCekSenetIslem, nFirmaID, dteBordroTarihi1, dteBordroTarihi2, lBordroNo1, lBordroNo2, sEvrakNo1, sEvrakNo2, sBankaKodu, sHareketTipi, sTarih)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub analiz_fis()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_tbCekSenetBordro
        '    Dim nCekSenetIslem
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.sec_sCekSenetTipi.EditValue = dr("sCekSenetTipi")
        '    frm.sCekSenetTipi = dr("sCekSenetTipi")
        '    frm.sec_nCekSenetIslem.EditValue = dr("nCekSenetIslem")
        '    frm.nCekSenetIslem = dr("nCekSenetIslem")
        '    nCekSenetIslem = dr("nCekSenetIslem")
        '    If nCekSenetIslem = 1 Then
        '        frm.sCekSenetIslem = "Cüzdana Giriþ"
        '    ElseIf nCekSenetIslem = 2 Then
        '        frm.sCekSenetIslem = "Cüzdandan Ýade"
        '    ElseIf nCekSenetIslem = 3 Then
        '        frm.sCekSenetIslem = "Banka Tahsile Çýkýþ"
        '    ElseIf nCekSenetIslem = 4 Then
        '        frm.sCekSenetIslem = "Banka Teminata Çýkýþ"
        '    ElseIf nCekSenetIslem = 5 Then
        '        frm.sCekSenetIslem = "Üçüncü Þahsa Çýkýþ"
        '    ElseIf nCekSenetIslem = 6 Then
        '        frm.sCekSenetIslem = "Çýkýþ Ýadesi, Cüzdanda"
        '    ElseIf nCekSenetIslem = 7 Then
        '        frm.sCekSenetIslem = "Bankadan Tahsil"
        '    ElseIf nCekSenetIslem = 8 Then
        '        frm.sCekSenetIslem = "Cüzdandan Tahsilat"
        '    ElseIf nCekSenetIslem = 9 Then
        '        frm.sCekSenetIslem = "Protesto / Karþýlýksýz"
        '    ElseIf nCekSenetIslem = 10 Then
        '        frm.sCekSenetIslem = "3. Þahýstan Kapandý"
        '    ElseIf nCekSenetIslem = 20 Then
        '        frm.sCekSenetIslem = "Çýkýþ"
        '    ElseIf nCekSenetIslem = 21 Then
        '        frm.sCekSenetIslem = "Ödendi"
        '    ElseIf nCekSenetIslem = 22 Then
        '        frm.sCekSenetIslem = "Hatalý ,Ýptal , Ýade"
        '    ElseIf nCekSenetIslem = 23 Then
        '        frm.sCekSenetIslem = "Protesto / Karþýlýksýz"
        '    End If
        '    frm.txt_dteBordroTarihi.EditValue = dr("dteBordroTarihi")
        '    frm.txt_lBordroNo.EditValue = dr("lBordroNo")
        '    frm.sKodu = dr("sKodu")
        '    frm.txt_musteriNo.EditValue = frm.sKodu
        '    frm.nFirmaId = dr("nFirmaID")
        '    frm.lbl_Firma.Text = dr("sAciklama")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        If nCekSenetIslem <> 0 Then
            dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaID, txt_dteBordroTarihi1.EditValue, txt_dteBordroTarihi2.EditValue, txt_lBordroNo1.EditValue, txt_lBordroNo2.EditValue, txt_sEvrakNo1.EditValue, txt_sEvrakNo2.EditValue, sec_sBankaKodu.EditValue, "", sec_sTarih.Text)
        Else
            dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaID, txt_dteBordroTarihi1.EditValue, txt_dteBordroTarihi2.EditValue, txt_lBordroNo1.EditValue, txt_lBordroNo2.EditValue, txt_sEvrakNo1.EditValue, txt_sEvrakNo2.EditValue, sec_sBankaKodu.EditValue, "", sec_sTarih.Text)
        End If
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridControl1.ExportToXls(SaveFileDialog1.FileName.ToString)
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
                GridControl1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.rtf) |*.rtf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.rtf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridControl1.ExportToRtf(SaveFileDialog1.FileName.ToString)
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
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If DataSet1.Tables(0).Rows.Count > 0 Then
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
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub frm_tbMuhasebeFisi_liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_tbCekSenetTipi()
        'dataload_tbCekSenetIslem()
        dataload_tbBankaKodu()
        txt_dteBordroTarihi1.EditValue = dteSistemTarihi
        txt_dteBordroTarihi2.EditValue = "31/12/2078"
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        If txt_ara.Text.ToString <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        'txt_ara.EditValue = ""
        ara()
        'txt_dteFisTarihi1.Focus()
        'txt_dteFisTarihi1.Select()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteBordroTarihi1.Focus()
        txt_dteBordroTarihi1.Select()
    End Sub
    Private Sub sec_sCekSenetTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sCekSenetTipi.EditValueChanged
        dataload_tbCekSenetIslem(Trim(sec_sCekSenetTipi.EditValue))
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla_rtf()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Me.Close()
    End Sub
    Private Sub sec_nCekSenetIslem_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_nCekSenetIslem.QueryPopUp
        sec_nCekSenetIslem.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_nCekSenetIslem_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_nCekSenetIslem.QueryResultValue
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
    Private Sub sec_nGorunum_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nGorunum.SelectedIndexChanged
        gorunum_yukle()
    End Sub
End Class
