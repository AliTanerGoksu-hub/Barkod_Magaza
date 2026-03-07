Imports DevExpress.XtraEditors
Public Class frm_Musteri_Referans_Kontrol
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_kefil As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
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
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
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
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCinsiyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAylikGelir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKartAcilisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoPesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoKredili As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbYazismaEvAdresinemi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsYeriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsAdresi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsAdresi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsIl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsPostaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvSemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvPostaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvIl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSigortaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEvlimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteEvlilikTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteDogumTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDogumYeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEhliyetNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKanGrubu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHitap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsResimAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOZLESME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKefilSayisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKrediLimiti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSonKullanmaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSinifKodu1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu13 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu14 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinifKodu15 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sIl As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sUnvan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sHitap As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sResimAdi As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents sec_sDepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sCinsiyet As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Musteri_Referans_Kontrol))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lPrimLimit = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nPrimOran4 = New DevExpress.XtraEditors.TextEdit
        Me.txt_nPrimOran3 = New DevExpress.XtraEditors.TextEdit
        Me.txt_nPrimOran2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_nPrimOran1 = New DevExpress.XtraEditors.TextEdit
        Me.txt_nPrimOran = New DevExpress.XtraEditors.TextEdit
        Me.sec_kefil = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Bar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl
        Me.barlabel = New DevExpress.XtraEditors.LabelControl
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
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
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
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
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sDepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCinsiyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sCinsiyet = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.collAylikGelir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteKartAcilisTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnIskontoPesin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnIskontoKredili = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sUnvan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsVergiNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbYazismaEvAdresinemi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEmail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIsYeriAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIsAdresi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIsAdresi2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIsSemt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIsIl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sIl = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsIsPostaKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIsTelefonu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvAdresi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvAdresi2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvSemt = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvPostaKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvIl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEvTelefonu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSigortaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbEvlimi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteEvlilikTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteDogumTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDogumYeri = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEhliyetNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKanGrubu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHitap = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sHitap = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsGSM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsResimAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSOZLESME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKefilSayisi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSinifKodu1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu13 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu14 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsSinifKodu15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sSinifKodu15 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKrediLimiti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteSonKullanmaTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSatis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSatisPrim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatis1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatis2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatis3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatis4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatisPrim1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatisPrim2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatisPrim3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBasamakSatisPrim4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collToplamSatis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collToplamSatisPrim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sResimAdi = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_lPrimLimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nPrimOran4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nPrimOran3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nPrimOran2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nPrimOran1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nPrimOran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kefil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.Bar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sCinsiyet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sUnvan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sIl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHitap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sResimAdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 131)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txt_lPrimLimit)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txt_nPrimOran4)
        Me.GroupControl1.Controls.Add(Me.txt_nPrimOran3)
        Me.GroupControl1.Controls.Add(Me.txt_nPrimOran2)
        Me.GroupControl1.Controls.Add(Me.txt_nPrimOran1)
        Me.GroupControl1.Controls.Add(Me.txt_nPrimOran)
        Me.GroupControl1.Controls.Add(Me.sec_kefil)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(434, 127)
        Me.GroupControl1.TabIndex = 35
        Me.GroupControl1.Text = "Ara"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(133, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Limit:"
        '
        'txt_lPrimLimit
        '
        Me.txt_lPrimLimit.EditValue = "300"
        Me.txt_lPrimLimit.EnterMoveNextControl = True
        Me.txt_lPrimLimit.Location = New System.Drawing.Point(175, 65)
        Me.txt_lPrimLimit.Name = "txt_lPrimLimit"
        Me.txt_lPrimLimit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lPrimLimit.Properties.Appearance.Options.UseFont = True
        Me.txt_lPrimLimit.Properties.MaxLength = 15
        Me.txt_lPrimLimit.Size = New System.Drawing.Size(99, 20)
        Me.txt_lPrimLimit.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Prim1,2,3,4:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(48, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Prim:"
        '
        'txt_nPrimOran4
        '
        Me.txt_nPrimOran4.EditValue = "0"
        Me.txt_nPrimOran4.EnterMoveNextControl = True
        Me.txt_nPrimOran4.Location = New System.Drawing.Point(225, 87)
        Me.txt_nPrimOran4.Name = "txt_nPrimOran4"
        Me.txt_nPrimOran4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nPrimOran4.Properties.Appearance.Options.UseFont = True
        Me.txt_nPrimOran4.Properties.MaxLength = 15
        Me.txt_nPrimOran4.Size = New System.Drawing.Size(49, 20)
        Me.txt_nPrimOran4.TabIndex = 12
        '
        'txt_nPrimOran3
        '
        Me.txt_nPrimOran3.EditValue = "0.2"
        Me.txt_nPrimOran3.EnterMoveNextControl = True
        Me.txt_nPrimOran3.Location = New System.Drawing.Point(176, 87)
        Me.txt_nPrimOran3.Name = "txt_nPrimOran3"
        Me.txt_nPrimOran3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nPrimOran3.Properties.Appearance.Options.UseFont = True
        Me.txt_nPrimOran3.Properties.MaxLength = 15
        Me.txt_nPrimOran3.Size = New System.Drawing.Size(49, 20)
        Me.txt_nPrimOran3.TabIndex = 11
        '
        'txt_nPrimOran2
        '
        Me.txt_nPrimOran2.EditValue = "0.5"
        Me.txt_nPrimOran2.EnterMoveNextControl = True
        Me.txt_nPrimOran2.Location = New System.Drawing.Point(127, 87)
        Me.txt_nPrimOran2.Name = "txt_nPrimOran2"
        Me.txt_nPrimOran2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nPrimOran2.Properties.Appearance.Options.UseFont = True
        Me.txt_nPrimOran2.Properties.MaxLength = 15
        Me.txt_nPrimOran2.Size = New System.Drawing.Size(49, 20)
        Me.txt_nPrimOran2.TabIndex = 10
        '
        'txt_nPrimOran1
        '
        Me.txt_nPrimOran1.EditValue = "1"
        Me.txt_nPrimOran1.EnterMoveNextControl = True
        Me.txt_nPrimOran1.Location = New System.Drawing.Point(78, 87)
        Me.txt_nPrimOran1.Name = "txt_nPrimOran1"
        Me.txt_nPrimOran1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nPrimOran1.Properties.Appearance.Options.UseFont = True
        Me.txt_nPrimOran1.Properties.MaxLength = 15
        Me.txt_nPrimOran1.Size = New System.Drawing.Size(49, 20)
        Me.txt_nPrimOran1.TabIndex = 9
        '
        'txt_nPrimOran
        '
        Me.txt_nPrimOran.EditValue = "2"
        Me.txt_nPrimOran.EnterMoveNextControl = True
        Me.txt_nPrimOran.Location = New System.Drawing.Point(78, 65)
        Me.txt_nPrimOran.Name = "txt_nPrimOran"
        Me.txt_nPrimOran.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nPrimOran.Properties.Appearance.Options.UseFont = True
        Me.txt_nPrimOran.Properties.MaxLength = 15
        Me.txt_nPrimOran.Size = New System.Drawing.Size(49, 20)
        Me.txt_nPrimOran.TabIndex = 7
        '
        'sec_kefil
        '
        Me.sec_kefil.EditValue = "[Tümü]"
        Me.sec_kefil.EnterMoveNextControl = True
        Me.sec_kefil.Location = New System.Drawing.Point(335, 21)
        Me.sec_kefil.Name = "sec_kefil"
        Me.sec_kefil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kefil.Properties.Items.AddRange(New Object() {"[Tümü]", "Kefil Yok", "Kefil Var"})
        Me.sec_kefil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kefil.Size = New System.Drawing.Size(78, 20)
        Me.sec_kefil.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(21, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Müşteriler:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(275, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "arasındaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(44, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(190, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(78, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adı+Soyadı"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(190, 43)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adı+Soyadı", "Kodu", "Adı", "Soyadı", "İstihbarat", "EvAdresi", "İşAdresi", "EvTelefonu", "İşTelefonu", "Gsm", "DoğumYeri", "1.Kefil Adı", "2.Kefil Adı", "Sınıf1", "Sınıf2", "Sınıf3", "Sınıf4", "Sınıf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 4
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(337, 43)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 21)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(273, 43)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 5
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(78, 43)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(172, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "ve"
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(530, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(292, 13)
        Me.lbl_istihbarat.TabIndex = 36
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Bar1)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 418)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Bar1
        '
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.Location = New System.Drawing.Point(2, 36)
        Me.Bar1.MenuManager = Me.BarManager1
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Properties.ShowTitle = True
        Me.Bar1.Size = New System.Drawing.Size(820, 10)
        Me.Bar1.TabIndex = 7
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.Appearance.Options.UseFont = True
        Me.BarButtonItem11.Caption = "Detay"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Musteri Karti,F4"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Satışlar ,F7"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Kalan Satışlar,F6"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Kalan Taksitler,F8"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        Me.BarButtonItem5.Caption = "Ekstre"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.Appearance.Options.UseFont = True
        Me.BarButtonItem6.Caption = "Notlar ,F9"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.Appearance.Options.UseFont = True
        Me.BarButtonItem7.Caption = "Yazdır,Ctrl+P"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.Appearance.Options.UseFont = True
        Me.BarButtonItem8.Caption = "Excel"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.Appearance.Options.UseFont = True
        Me.BarButtonItem9.Caption = "Text"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.Appearance.Options.UseFont = True
        Me.BarButtonItem10.Caption = "Mail"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.Name = "BarButtonItem10"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 466)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 466)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 466)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
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
        Me.PanelControl3.Controls.Add(Me.Panelstatus)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 131)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 287)
        Me.PanelControl3.TabIndex = 0
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(176, 111)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(472, 64)
        Me.Panelstatus.TabIndex = 2
        Me.Panelstatus.Visible = False
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 14)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 3
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 33)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(456, 18)
        Me.bar.TabIndex = 2
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSinifKodu1, Me.sec_sSinifKodu2, Me.sec_sSinifKodu3, Me.sec_sSinifKodu4, Me.sec_sSinifKodu5, Me.sec_sSinifKodu6, Me.sec_sSinifKodu7, Me.sec_sSinifKodu8, Me.sec_sSinifKodu9, Me.sec_sSinifKodu10, Me.sec_sSinifKodu11, Me.sec_sSinifKodu12, Me.sec_sSinifKodu13, Me.sec_sSinifKodu14, Me.sec_sSinifKodu15, Me.sec_sIl, Me.sec_sUnvan, Me.sec_sHitap, Me.sec_sResimAdi, Me.sec_sDepo, Me.sec_sCinsiyet})
        Me.GridControl1.Size = New System.Drawing.Size(820, 283)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem27, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem23, Me.MenuItem29, Me.MenuItem22, Me.MenuItem21, Me.MenuItem28, Me.MenuItem20, Me.MenuItem2, Me.MenuItem1, Me.MenuItem3, Me.MenuItem4, Me.MenuItem24, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem27.Text = "Değer Yay"
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
        Me.MenuItem16.Text = "Kalan Taksitler"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 5
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Kalan Satışlar"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 6
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Satışlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müşteri Kartı"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 8
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem23.Text = "Müşteri Düzenle"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 9
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem29.Text = "Karlılık Akış Tablosu"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 10
        Me.MenuItem22.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 11
        Me.MenuItem21.Text = "Takibe Al"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 12
        Me.MenuItem28.Text = "SMS Gönder"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 13
        Me.MenuItem20.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 14
        Me.MenuItem2.Text = "Hızlı Filtre"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 15
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 16
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 17
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 18
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem24.Text = "Raporla"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Text = "Excel"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Text = "Text"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 19
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 20
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 21
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 22
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 23
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 24
        Me.MenuItem8.Text = "Satırları Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 25
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 26
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sMagaza"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKodu"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sSoyadi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "nCinsiyet"
        Me.DataColumn6.DataType = GetType(Long)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lAylikGelir"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteKartAcilisTarihi"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "nIskontoPesin"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nIskontoKredili"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sUnvan"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sVergiDairesi"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sVergiNo"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "bYazismaEvAdresinemi"
        Me.DataColumn14.DataType = GetType(Byte)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sEmail"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sIsYeriAdi"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sIsAdresi1"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sIsAdresi2"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sIsSemt"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sIsIl"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sIsPostaKodu"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sIsTelefonu"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sEvAdresi1"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sEvAdresi2"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sEvSemt"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sEvPostaKodu"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sEvIl"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sEvTelefonu"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sSigortaNo"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "bEvlimi"
        Me.DataColumn30.DataType = GetType(Byte)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "dteEvlilikTarihi"
        Me.DataColumn31.DataType = GetType(Date)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "dteDogumTarihi"
        Me.DataColumn32.DataType = GetType(Date)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sDogumYeri"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sEhliyetNo"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sKanGrubu"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sHitap"
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
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "sAciklama1"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sAciklama2"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "sAciklama3"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "sAciklama4"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "sAciklama5"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "sGSM"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "sFax"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sResimAdi"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "ISTIHBARAT"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "SOZLESME"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "KefilSayisi"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "sSinifKodu1"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "sSinifKodu2"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "sSinifKodu3"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "sSinifKodu4"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "sSinifKodu5"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "sSinifKodu6"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "sSinifKodu7"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sSinifKodu8"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "sSinifKodu9"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "sSinifKodu10"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "sSinifKodu11"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "sSinifKodu12"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "sSinifKodu13"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "sSinifKodu14"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "sSinifKodu15"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "lBakiye"
        Me.DataColumn65.DataType = GetType(Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "lKrediLimiti"
        Me.DataColumn66.DataType = GetType(Decimal)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "dteSonKullanmaTarihi"
        Me.DataColumn67.DataType = GetType(Date)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsMagaza, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colnCinsiyet, Me.collAylikGelir, Me.coldteKartAcilisTarihi, Me.colnIskontoPesin, Me.colnIskontoKredili, Me.colsUnvan, Me.colsVergiDairesi, Me.colsVergiNo, Me.colbYazismaEvAdresinemi, Me.colsEmail, Me.colsIsYeriAdi, Me.colsIsAdresi1, Me.colsIsAdresi2, Me.colsIsSemt, Me.colsIsIl, Me.colsIsPostaKodu, Me.colsIsTelefonu, Me.colsEvAdresi1, Me.colsEvAdresi2, Me.colsEvSemt, Me.colsEvPostaKodu, Me.colsEvIl, Me.colsEvTelefonu, Me.colsSigortaNo, Me.colbEvlimi, Me.coldteEvlilikTarihi, Me.coldteDogumTarihi, Me.colsDogumYeri, Me.colsEhliyetNo, Me.colsKanGrubu, Me.colsHitap, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colsAciklama1, Me.colsAciklama2, Me.colsAciklama3, Me.colsAciklama4, Me.colsAciklama5, Me.colsGSM, Me.colsFax, Me.colsResimAdi, Me.colISTIHBARAT, Me.colSOZLESME, Me.colKefilSayisi, Me.colsSinifKodu1, Me.colsSinifKodu2, Me.colsSinifKodu3, Me.colsSinifKodu4, Me.colsSinifKodu5, Me.colsSinifKodu6, Me.colsSinifKodu7, Me.colsSinifKodu8, Me.colsSinifKodu9, Me.colsSinifKodu10, Me.colsSinifKodu11, Me.colsSinifKodu12, Me.colsSinifKodu13, Me.colsSinifKodu14, Me.colsSinifKodu15, Me.collBakiye, Me.collKrediLimiti, Me.coldteSonKullanmaTarihi, Me.collSatis, Me.collSatisPrim, Me.collBasamakSatis1, Me.collBasamakSatis2, Me.collBasamakSatis3, Me.collBasamakSatis4, Me.collBasamakSatisPrim1, Me.collBasamakSatisPrim2, Me.collBasamakSatisPrim3, Me.collBasamakSatisPrim4, Me.collToplamSatis, Me.collToplamSatisPrim})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(473, 244, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayıt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colnMusteriID.AppearanceCell.Options.UseBackColor = True
        Me.colnMusteriID.Caption = "Kayıt No"
        Me.colnMusteriID.DisplayFormat.FormatString = "#,#.##"
        Me.colnMusteriID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Mağaza"
        Me.colsMagaza.ColumnEdit = Me.sec_sDepo
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        '
        'sec_sDepo
        '
        Me.sec_sDepo.AutoHeight = False
        Me.sec_sDepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDepo.DisplayMember = "sAciklama"
        Me.sec_sDepo.Name = "sec_sDepo"
        Me.sec_sDepo.ValueMember = "sDepo"
        '
        'collKodu
        '
        Me.collKodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.collKodu.AppearanceCell.Options.UseBackColor = True
        Me.collKodu.Caption = "Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.OptionsColumn.AllowEdit = False
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayıt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 0
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adı"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Visible = True
        Me.colsAdi.VisibleIndex = 1
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadi"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Visible = True
        Me.colsSoyadi.VisibleIndex = 2
        '
        'colnCinsiyet
        '
        Me.colnCinsiyet.Caption = "Cinsiyet"
        Me.colnCinsiyet.ColumnEdit = Me.sec_sCinsiyet
        Me.colnCinsiyet.FieldName = "nCinsiyet"
        Me.colnCinsiyet.Name = "colnCinsiyet"
        '
        'sec_sCinsiyet
        '
        Me.sec_sCinsiyet.AutoHeight = False
        Me.sec_sCinsiyet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sCinsiyet.DisplayMember = "sAciklama"
        Me.sec_sCinsiyet.Name = "sec_sCinsiyet"
        Me.sec_sCinsiyet.ValueMember = "nCinsiyet"
        '
        'collAylikGelir
        '
        Me.collAylikGelir.Caption = "Aylık Gelir"
        Me.collAylikGelir.FieldName = "lAylikGelir"
        Me.collAylikGelir.Name = "collAylikGelir"
        '
        'coldteKartAcilisTarihi
        '
        Me.coldteKartAcilisTarihi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.coldteKartAcilisTarihi.AppearanceCell.Options.UseBackColor = True
        Me.coldteKartAcilisTarihi.Caption = "Kart Açılış Tarihi"
        Me.coldteKartAcilisTarihi.FieldName = "dteKartAcilisTarihi"
        Me.coldteKartAcilisTarihi.Name = "coldteKartAcilisTarihi"
        Me.coldteKartAcilisTarihi.OptionsColumn.AllowEdit = False
        '
        'colnIskontoPesin
        '
        Me.colnIskontoPesin.Caption = "İskonto Peşin"
        Me.colnIskontoPesin.FieldName = "nIskontoPesin"
        Me.colnIskontoPesin.Name = "colnIskontoPesin"
        '
        'colnIskontoKredili
        '
        Me.colnIskontoKredili.Caption = "İskonto Kredili"
        Me.colnIskontoKredili.FieldName = "nIskontoKredili"
        Me.colnIskontoKredili.Name = "colnIskontoKredili"
        '
        'colsUnvan
        '
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.ColumnEdit = Me.sec_sUnvan
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        '
        'sec_sUnvan
        '
        Me.sec_sUnvan.AutoHeight = False
        Me.sec_sUnvan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sUnvan.DisplayMember = "sAciklama"
        Me.sec_sUnvan.Name = "sec_sUnvan"
        Me.sec_sUnvan.ValueMember = "sUnvan"
        '
        'colsVergiDairesi
        '
        Me.colsVergiDairesi.Caption = "Vergi Dairesi"
        Me.colsVergiDairesi.FieldName = "sVergiDairesi"
        Me.colsVergiDairesi.Name = "colsVergiDairesi"
        '
        'colsVergiNo
        '
        Me.colsVergiNo.Caption = "Vergi No"
        Me.colsVergiNo.FieldName = "sVergiNo"
        Me.colsVergiNo.Name = "colsVergiNo"
        '
        'colbYazismaEvAdresinemi
        '
        Me.colbYazismaEvAdresinemi.Caption = "YazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.FieldName = "bYazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.Name = "colbYazismaEvAdresinemi"
        '
        'colsEmail
        '
        Me.colsEmail.Caption = "Email"
        Me.colsEmail.FieldName = "sEmail"
        Me.colsEmail.Name = "colsEmail"
        '
        'colsIsYeriAdi
        '
        Me.colsIsYeriAdi.Caption = "İş Yeri Adı"
        Me.colsIsYeriAdi.FieldName = "sIsYeriAdi"
        Me.colsIsYeriAdi.Name = "colsIsYeriAdi"
        '
        'colsIsAdresi1
        '
        Me.colsIsAdresi1.Caption = "İş Adresi 1"
        Me.colsIsAdresi1.FieldName = "sIsAdresi1"
        Me.colsIsAdresi1.Name = "colsIsAdresi1"
        '
        'colsIsAdresi2
        '
        Me.colsIsAdresi2.Caption = "İş Adresi 2"
        Me.colsIsAdresi2.FieldName = "sIsAdresi2"
        Me.colsIsAdresi2.Name = "colsIsAdresi2"
        '
        'colsIsSemt
        '
        Me.colsIsSemt.Caption = "İş Semt"
        Me.colsIsSemt.FieldName = "sIsSemt"
        Me.colsIsSemt.Name = "colsIsSemt"
        '
        'colsIsIl
        '
        Me.colsIsIl.Caption = "İş İl"
        Me.colsIsIl.ColumnEdit = Me.sec_sIl
        Me.colsIsIl.FieldName = "sIsIl"
        Me.colsIsIl.Name = "colsIsIl"
        '
        'sec_sIl
        '
        Me.sec_sIl.AutoHeight = False
        Me.sec_sIl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sIl.DisplayMember = "sIl"
        Me.sec_sIl.Name = "sec_sIl"
        Me.sec_sIl.ValueMember = "sIl"
        '
        'colsIsPostaKodu
        '
        Me.colsIsPostaKodu.Caption = "İş Posta Kodu"
        Me.colsIsPostaKodu.FieldName = "sIsPostaKodu"
        Me.colsIsPostaKodu.Name = "colsIsPostaKodu"
        '
        'colsIsTelefonu
        '
        Me.colsIsTelefonu.Caption = "İş Telefonu"
        Me.colsIsTelefonu.FieldName = "sIsTelefonu"
        Me.colsIsTelefonu.Name = "colsIsTelefonu"
        '
        'colsEvAdresi1
        '
        Me.colsEvAdresi1.Caption = "Ev Adresi 1"
        Me.colsEvAdresi1.FieldName = "sEvAdresi1"
        Me.colsEvAdresi1.Name = "colsEvAdresi1"
        '
        'colsEvAdresi2
        '
        Me.colsEvAdresi2.Caption = "Ev Adresi 2"
        Me.colsEvAdresi2.FieldName = "sEvAdresi2"
        Me.colsEvAdresi2.Name = "colsEvAdresi2"
        '
        'colsEvSemt
        '
        Me.colsEvSemt.Caption = "Ev Semti"
        Me.colsEvSemt.FieldName = "sEvSemt"
        Me.colsEvSemt.Name = "colsEvSemt"
        '
        'colsEvPostaKodu
        '
        Me.colsEvPostaKodu.Caption = "Ev Posta Kodu"
        Me.colsEvPostaKodu.FieldName = "sEvPostaKodu"
        Me.colsEvPostaKodu.Name = "colsEvPostaKodu"
        '
        'colsEvIl
        '
        Me.colsEvIl.Caption = "Ev İl"
        Me.colsEvIl.ColumnEdit = Me.sec_sIl
        Me.colsEvIl.FieldName = "sEvIl"
        Me.colsEvIl.Name = "colsEvIl"
        '
        'colsEvTelefonu
        '
        Me.colsEvTelefonu.Caption = "Ev Telefonu"
        Me.colsEvTelefonu.FieldName = "sEvTelefonu"
        Me.colsEvTelefonu.Name = "colsEvTelefonu"
        '
        'colsSigortaNo
        '
        Me.colsSigortaNo.Caption = "Sigorta No"
        Me.colsSigortaNo.FieldName = "sSigortaNo"
        Me.colsSigortaNo.Name = "colsSigortaNo"
        '
        'colbEvlimi
        '
        Me.colbEvlimi.Caption = "Evlimi"
        Me.colbEvlimi.FieldName = "bEvlimi"
        Me.colbEvlimi.Name = "colbEvlimi"
        '
        'coldteEvlilikTarihi
        '
        Me.coldteEvlilikTarihi.Caption = "Evlilik Tarihi"
        Me.coldteEvlilikTarihi.FieldName = "dteEvlilikTarihi"
        Me.coldteEvlilikTarihi.Name = "coldteEvlilikTarihi"
        '
        'coldteDogumTarihi
        '
        Me.coldteDogumTarihi.Caption = "Doğum Tarihi"
        Me.coldteDogumTarihi.FieldName = "dteDogumTarihi"
        Me.coldteDogumTarihi.Name = "coldteDogumTarihi"
        '
        'colsDogumYeri
        '
        Me.colsDogumYeri.Caption = "Doğum Yeri"
        Me.colsDogumYeri.FieldName = "sDogumYeri"
        Me.colsDogumYeri.Name = "colsDogumYeri"
        '
        'colsEhliyetNo
        '
        Me.colsEhliyetNo.Caption = "Ehliyet No"
        Me.colsEhliyetNo.FieldName = "sEhliyetNo"
        Me.colsEhliyetNo.Name = "colsEhliyetNo"
        '
        'colsKanGrubu
        '
        Me.colsKanGrubu.Caption = "Kan Grubu"
        Me.colsKanGrubu.FieldName = "sKanGrubu"
        Me.colsKanGrubu.Name = "colsKanGrubu"
        '
        'colsHitap
        '
        Me.colsHitap.Caption = "Hitap"
        Me.colsHitap.ColumnEdit = Me.sec_sHitap
        Me.colsHitap.FieldName = "sHitap"
        Me.colsHitap.Name = "colsHitap"
        '
        'sec_sHitap
        '
        Me.sec_sHitap.AutoHeight = False
        Me.sec_sHitap.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sHitap.DisplayMember = "sHitap"
        Me.sec_sHitap.Name = "sec_sHitap"
        Me.sec_sHitap.ValueMember = "sHitap"
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colsKullaniciAdi.AppearanceCell.Options.UseBackColor = True
        Me.colsKullaniciAdi.Caption = "Kullanıcı Adı"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.coldteKayitTarihi.AppearanceCell.Options.UseBackColor = True
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Açıklama 1"
        Me.colsAciklama1.FieldName = "sAciklama1"
        Me.colsAciklama1.Name = "colsAciklama1"
        '
        'colsAciklama2
        '
        Me.colsAciklama2.Caption = "Açıklama 2"
        Me.colsAciklama2.FieldName = "sAciklama2"
        Me.colsAciklama2.Name = "colsAciklama2"
        '
        'colsAciklama3
        '
        Me.colsAciklama3.Caption = "Açıklama 3"
        Me.colsAciklama3.FieldName = "sAciklama3"
        Me.colsAciklama3.Name = "colsAciklama3"
        '
        'colsAciklama4
        '
        Me.colsAciklama4.Caption = "Açıklama 4"
        Me.colsAciklama4.FieldName = "sAciklama4"
        Me.colsAciklama4.Name = "colsAciklama4"
        '
        'colsAciklama5
        '
        Me.colsAciklama5.Caption = "Açıklama 5"
        Me.colsAciklama5.FieldName = "sAciklama5"
        Me.colsAciklama5.Name = "colsAciklama5"
        '
        'colsGSM
        '
        Me.colsGSM.Caption = "GSM"
        Me.colsGSM.FieldName = "sGSM"
        Me.colsGSM.Name = "colsGSM"
        '
        'colsFax
        '
        Me.colsFax.Caption = "Fax"
        Me.colsFax.FieldName = "sFax"
        Me.colsFax.Name = "colsFax"
        '
        'colsResimAdi
        '
        Me.colsResimAdi.Caption = "Resim Adı"
        Me.colsResimAdi.FieldName = "sResimAdi"
        Me.colsResimAdi.Name = "colsResimAdi"
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colISTIHBARAT.AppearanceCell.Options.UseBackColor = True
        Me.colISTIHBARAT.Caption = "ISTIHBARAT"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        Me.colISTIHBARAT.OptionsColumn.AllowEdit = False
        '
        'colSOZLESME
        '
        Me.colSOZLESME.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colSOZLESME.AppearanceCell.Options.UseBackColor = True
        Me.colSOZLESME.Caption = "Sözleşme"
        Me.colSOZLESME.FieldName = "SOZLESME"
        Me.colSOZLESME.Name = "colSOZLESME"
        Me.colSOZLESME.OptionsColumn.AllowEdit = False
        '
        'colKefilSayisi
        '
        Me.colKefilSayisi.Caption = "Kefil Sayısı"
        Me.colKefilSayisi.FieldName = "KefilSayisi"
        Me.colKefilSayisi.Name = "colKefilSayisi"
        '
        'colsSinifKodu1
        '
        Me.colsSinifKodu1.Caption = "Sınıf Kodu 1"
        Me.colsSinifKodu1.ColumnEdit = Me.sec_sSinifKodu1
        Me.colsSinifKodu1.FieldName = "sSinifKodu1"
        Me.colsSinifKodu1.Name = "colsSinifKodu1"
        '
        'sec_sSinifKodu1
        '
        Me.sec_sSinifKodu1.AutoHeight = False
        Me.sec_sSinifKodu1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu1.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu1.Name = "sec_sSinifKodu1"
        Me.sec_sSinifKodu1.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu2
        '
        Me.colsSinifKodu2.Caption = "Sınıf Kodu 2"
        Me.colsSinifKodu2.ColumnEdit = Me.sec_sSinifKodu2
        Me.colsSinifKodu2.FieldName = "sSinifKodu2"
        Me.colsSinifKodu2.Name = "colsSinifKodu2"
        '
        'sec_sSinifKodu2
        '
        Me.sec_sSinifKodu2.AutoHeight = False
        Me.sec_sSinifKodu2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu2.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu2.Name = "sec_sSinifKodu2"
        Me.sec_sSinifKodu2.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu3
        '
        Me.colsSinifKodu3.Caption = "Sınıf Kodu 3"
        Me.colsSinifKodu3.ColumnEdit = Me.sec_sSinifKodu3
        Me.colsSinifKodu3.FieldName = "sSinifKodu3"
        Me.colsSinifKodu3.Name = "colsSinifKodu3"
        '
        'sec_sSinifKodu3
        '
        Me.sec_sSinifKodu3.AutoHeight = False
        Me.sec_sSinifKodu3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu3.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu3.Name = "sec_sSinifKodu3"
        Me.sec_sSinifKodu3.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu4
        '
        Me.colsSinifKodu4.Caption = "Sınıf Kodu 4"
        Me.colsSinifKodu4.ColumnEdit = Me.sec_sSinifKodu4
        Me.colsSinifKodu4.FieldName = "sSinifKodu4"
        Me.colsSinifKodu4.Name = "colsSinifKodu4"
        '
        'sec_sSinifKodu4
        '
        Me.sec_sSinifKodu4.AutoHeight = False
        Me.sec_sSinifKodu4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu4.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu4.Name = "sec_sSinifKodu4"
        Me.sec_sSinifKodu4.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu5
        '
        Me.colsSinifKodu5.Caption = "Sınıf Kodu 5"
        Me.colsSinifKodu5.ColumnEdit = Me.sec_sSinifKodu5
        Me.colsSinifKodu5.FieldName = "sSinifKodu5"
        Me.colsSinifKodu5.Name = "colsSinifKodu5"
        '
        'sec_sSinifKodu5
        '
        Me.sec_sSinifKodu5.AutoHeight = False
        Me.sec_sSinifKodu5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu5.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu5.Name = "sec_sSinifKodu5"
        Me.sec_sSinifKodu5.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu6
        '
        Me.colsSinifKodu6.Caption = "Sınıf Kodu 6"
        Me.colsSinifKodu6.ColumnEdit = Me.sec_sSinifKodu6
        Me.colsSinifKodu6.FieldName = "sSinifKodu6"
        Me.colsSinifKodu6.Name = "colsSinifKodu6"
        '
        'sec_sSinifKodu6
        '
        Me.sec_sSinifKodu6.AutoHeight = False
        Me.sec_sSinifKodu6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu6.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu6.Name = "sec_sSinifKodu6"
        Me.sec_sSinifKodu6.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu7
        '
        Me.colsSinifKodu7.Caption = "Sınıf Kodu 7"
        Me.colsSinifKodu7.ColumnEdit = Me.sec_sSinifKodu7
        Me.colsSinifKodu7.FieldName = "sSinifKodu7"
        Me.colsSinifKodu7.Name = "colsSinifKodu7"
        '
        'sec_sSinifKodu7
        '
        Me.sec_sSinifKodu7.AutoHeight = False
        Me.sec_sSinifKodu7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu7.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu7.Name = "sec_sSinifKodu7"
        Me.sec_sSinifKodu7.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu8
        '
        Me.colsSinifKodu8.Caption = "Sınıf Kodu 8"
        Me.colsSinifKodu8.ColumnEdit = Me.sec_sSinifKodu8
        Me.colsSinifKodu8.FieldName = "sSinifKodu8"
        Me.colsSinifKodu8.Name = "colsSinifKodu8"
        '
        'sec_sSinifKodu8
        '
        Me.sec_sSinifKodu8.AutoHeight = False
        Me.sec_sSinifKodu8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu8.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu8.Name = "sec_sSinifKodu8"
        Me.sec_sSinifKodu8.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu9
        '
        Me.colsSinifKodu9.Caption = "Sınıf Kodu 9"
        Me.colsSinifKodu9.ColumnEdit = Me.sec_sSinifKodu9
        Me.colsSinifKodu9.FieldName = "sSinifKodu9"
        Me.colsSinifKodu9.Name = "colsSinifKodu9"
        '
        'sec_sSinifKodu9
        '
        Me.sec_sSinifKodu9.AutoHeight = False
        Me.sec_sSinifKodu9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu9.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu9.Name = "sec_sSinifKodu9"
        Me.sec_sSinifKodu9.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu10
        '
        Me.colsSinifKodu10.Caption = "Sınıf Kodu 10"
        Me.colsSinifKodu10.ColumnEdit = Me.sec_sSinifKodu10
        Me.colsSinifKodu10.FieldName = "sSinifKodu10"
        Me.colsSinifKodu10.Name = "colsSinifKodu10"
        '
        'sec_sSinifKodu10
        '
        Me.sec_sSinifKodu10.AutoHeight = False
        Me.sec_sSinifKodu10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu10.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu10.Name = "sec_sSinifKodu10"
        Me.sec_sSinifKodu10.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu11
        '
        Me.colsSinifKodu11.Caption = "Sınıf Kodu 11"
        Me.colsSinifKodu11.ColumnEdit = Me.sec_sSinifKodu11
        Me.colsSinifKodu11.FieldName = "sSinifKodu11"
        Me.colsSinifKodu11.Name = "colsSinifKodu11"
        '
        'sec_sSinifKodu11
        '
        Me.sec_sSinifKodu11.AutoHeight = False
        Me.sec_sSinifKodu11.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu11.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu11.Name = "sec_sSinifKodu11"
        Me.sec_sSinifKodu11.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu12
        '
        Me.colsSinifKodu12.Caption = "Sınıf Kodu 12"
        Me.colsSinifKodu12.ColumnEdit = Me.sec_sSinifKodu12
        Me.colsSinifKodu12.FieldName = "sSinifKodu12"
        Me.colsSinifKodu12.Name = "colsSinifKodu12"
        '
        'sec_sSinifKodu12
        '
        Me.sec_sSinifKodu12.AutoHeight = False
        Me.sec_sSinifKodu12.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu12.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu12.Name = "sec_sSinifKodu12"
        Me.sec_sSinifKodu12.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu13
        '
        Me.colsSinifKodu13.Caption = "Sınıf Kodu 13"
        Me.colsSinifKodu13.ColumnEdit = Me.sec_sSinifKodu13
        Me.colsSinifKodu13.FieldName = "sSinifKodu13"
        Me.colsSinifKodu13.Name = "colsSinifKodu13"
        '
        'sec_sSinifKodu13
        '
        Me.sec_sSinifKodu13.AutoHeight = False
        Me.sec_sSinifKodu13.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu13.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu13.Name = "sec_sSinifKodu13"
        Me.sec_sSinifKodu13.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu14
        '
        Me.colsSinifKodu14.Caption = "Sınıf Kodu 14"
        Me.colsSinifKodu14.ColumnEdit = Me.sec_sSinifKodu14
        Me.colsSinifKodu14.FieldName = "sSinifKodu14"
        Me.colsSinifKodu14.Name = "colsSinifKodu14"
        '
        'sec_sSinifKodu14
        '
        Me.sec_sSinifKodu14.AutoHeight = False
        Me.sec_sSinifKodu14.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu14.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu14.Name = "sec_sSinifKodu14"
        Me.sec_sSinifKodu14.ValueMember = "sSinifKodu"
        '
        'colsSinifKodu15
        '
        Me.colsSinifKodu15.Caption = "Sınıf Kodu 15"
        Me.colsSinifKodu15.ColumnEdit = Me.sec_sSinifKodu15
        Me.colsSinifKodu15.FieldName = "sSinifKodu15"
        Me.colsSinifKodu15.Name = "colsSinifKodu15"
        '
        'sec_sSinifKodu15
        '
        Me.sec_sSinifKodu15.AutoHeight = False
        Me.sec_sSinifKodu15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu15.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu15.Name = "sec_sSinifKodu15"
        Me.sec_sSinifKodu15.ValueMember = "sSinifKodu"
        '
        'collBakiye
        '
        Me.collBakiye.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.collBakiye.AppearanceCell.Options.UseBackColor = True
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.OptionsColumn.AllowEdit = False
        Me.collBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBakiye", "{0:#,0.00}")})
        '
        'collKrediLimiti
        '
        Me.collKrediLimiti.Caption = "Kredi Limiti"
        Me.collKrediLimiti.FieldName = "lKrediLimiti"
        Me.collKrediLimiti.Name = "collKrediLimiti"
        '
        'coldteSonKullanmaTarihi
        '
        Me.coldteSonKullanmaTarihi.Caption = "Son Kullanma Tarihi"
        Me.coldteSonKullanmaTarihi.FieldName = "dteSonKullanmaTarihi"
        Me.coldteSonKullanmaTarihi.Name = "coldteSonKullanmaTarihi"
        '
        'collSatis
        '
        Me.collSatis.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collSatis.AppearanceCell.Options.UseBackColor = True
        Me.collSatis.Caption = "Satis"
        Me.collSatis.DisplayFormat.FormatString = "#,0.00"
        Me.collSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSatis.FieldName = "lSatis"
        Me.collSatis.Name = "collSatis"
        Me.collSatis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSatis", "{0:#,0.00}")})
        Me.collSatis.Visible = True
        Me.collSatis.VisibleIndex = 3
        '
        'collSatisPrim
        '
        Me.collSatisPrim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collSatisPrim.AppearanceCell.Options.UseBackColor = True
        Me.collSatisPrim.Caption = "SatisPrim"
        Me.collSatisPrim.DisplayFormat.FormatString = "#,0.00"
        Me.collSatisPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSatisPrim.FieldName = "lSatisPrim"
        Me.collSatisPrim.Name = "collSatisPrim"
        Me.collSatisPrim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSatisPrim", "{0:#,0.00}")})
        Me.collSatisPrim.Visible = True
        Me.collSatisPrim.VisibleIndex = 4
        '
        'collBasamakSatis1
        '
        Me.collBasamakSatis1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collBasamakSatis1.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatis1.Caption = "1.BSatis"
        Me.collBasamakSatis1.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatis1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatis1.FieldName = "lBasamakSatis1"
        Me.collBasamakSatis1.Name = "collBasamakSatis1"
        Me.collBasamakSatis1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatis1", "{0:#,0.00}")})
        Me.collBasamakSatis1.Visible = True
        Me.collBasamakSatis1.VisibleIndex = 5
        '
        'collBasamakSatis2
        '
        Me.collBasamakSatis2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collBasamakSatis2.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatis2.Caption = "2.BSatis"
        Me.collBasamakSatis2.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatis2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatis2.FieldName = "lBasamakSatis2"
        Me.collBasamakSatis2.Name = "collBasamakSatis2"
        Me.collBasamakSatis2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatis2", "{0:#,0.00}")})
        Me.collBasamakSatis2.Visible = True
        Me.collBasamakSatis2.VisibleIndex = 6
        '
        'collBasamakSatis3
        '
        Me.collBasamakSatis3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collBasamakSatis3.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatis3.Caption = "3.BSatis"
        Me.collBasamakSatis3.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatis3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatis3.FieldName = "lBasamakSatis3"
        Me.collBasamakSatis3.Name = "collBasamakSatis3"
        Me.collBasamakSatis3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatis3", "{0:#,0.00}")})
        Me.collBasamakSatis3.Visible = True
        Me.collBasamakSatis3.VisibleIndex = 7
        '
        'collBasamakSatis4
        '
        Me.collBasamakSatis4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collBasamakSatis4.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatis4.Caption = "4.BSatis"
        Me.collBasamakSatis4.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatis4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatis4.FieldName = "lBasamakSatis4"
        Me.collBasamakSatis4.Name = "collBasamakSatis4"
        Me.collBasamakSatis4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatis4", "{0:#,0.00}")})
        Me.collBasamakSatis4.Visible = True
        Me.collBasamakSatis4.VisibleIndex = 8
        '
        'collBasamakSatisPrim1
        '
        Me.collBasamakSatisPrim1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.collBasamakSatisPrim1.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatisPrim1.Caption = "1.BSatisPrim"
        Me.collBasamakSatisPrim1.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatisPrim1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatisPrim1.FieldName = "lBasamakSatisPrim1"
        Me.collBasamakSatisPrim1.Name = "collBasamakSatisPrim1"
        Me.collBasamakSatisPrim1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatisPrim1", "{0:#,0.00}")})
        Me.collBasamakSatisPrim1.Visible = True
        Me.collBasamakSatisPrim1.VisibleIndex = 9
        '
        'collBasamakSatisPrim2
        '
        Me.collBasamakSatisPrim2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.collBasamakSatisPrim2.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatisPrim2.Caption = "2.BSatisPrim"
        Me.collBasamakSatisPrim2.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatisPrim2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatisPrim2.FieldName = "lBasamakSatisPrim2"
        Me.collBasamakSatisPrim2.Name = "collBasamakSatisPrim2"
        Me.collBasamakSatisPrim2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatisPrim2", "{0:#,0.00}")})
        Me.collBasamakSatisPrim2.Visible = True
        Me.collBasamakSatisPrim2.VisibleIndex = 10
        '
        'collBasamakSatisPrim3
        '
        Me.collBasamakSatisPrim3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.collBasamakSatisPrim3.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatisPrim3.Caption = "3.BSatisPrim"
        Me.collBasamakSatisPrim3.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatisPrim3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatisPrim3.FieldName = "lBasamakSatisPrim3"
        Me.collBasamakSatisPrim3.Name = "collBasamakSatisPrim3"
        Me.collBasamakSatisPrim3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatisPrim3", "{0:#,0.00}")})
        Me.collBasamakSatisPrim3.Visible = True
        Me.collBasamakSatisPrim3.VisibleIndex = 11
        '
        'collBasamakSatisPrim4
        '
        Me.collBasamakSatisPrim4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.collBasamakSatisPrim4.AppearanceCell.Options.UseBackColor = True
        Me.collBasamakSatisPrim4.Caption = "4.BSatisPrim"
        Me.collBasamakSatisPrim4.DisplayFormat.FormatString = "#,#.##"
        Me.collBasamakSatisPrim4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBasamakSatisPrim4.FieldName = "lBasamakSatisPrim4"
        Me.collBasamakSatisPrim4.Name = "collBasamakSatisPrim4"
        Me.collBasamakSatisPrim4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBasamakSatisPrim4", "{0:#,0.00}")})
        Me.collBasamakSatisPrim4.Visible = True
        Me.collBasamakSatisPrim4.VisibleIndex = 12
        '
        'collToplamSatis
        '
        Me.collToplamSatis.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collToplamSatis.AppearanceCell.Options.UseBackColor = True
        Me.collToplamSatis.Caption = "ToplamSatis"
        Me.collToplamSatis.DisplayFormat.FormatString = "#,0.00"
        Me.collToplamSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamSatis.FieldName = "lToplamSatis"
        Me.collToplamSatis.Name = "collToplamSatis"
        Me.collToplamSatis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamSatis", "{0:#,0.00}")})
        Me.collToplamSatis.Visible = True
        Me.collToplamSatis.VisibleIndex = 13
        '
        'collToplamSatisPrim
        '
        Me.collToplamSatisPrim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collToplamSatisPrim.AppearanceCell.Options.UseBackColor = True
        Me.collToplamSatisPrim.Caption = "ToplamPrim"
        Me.collToplamSatisPrim.DisplayFormat.FormatString = "#,0.00"
        Me.collToplamSatisPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamSatisPrim.FieldName = "lToplamSatisPrim"
        Me.collToplamSatisPrim.Name = "collToplamSatisPrim"
        Me.collToplamSatisPrim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamSatisPrim", "{0:#,0.00}")})
        Me.collToplamSatisPrim.Visible = True
        Me.collToplamSatisPrim.VisibleIndex = 14
        '
        'sec_sResimAdi
        '
        Me.sec_sResimAdi.AutoHeight = False
        Me.sec_sResimAdi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sec_sResimAdi.Name = "sec_sResimAdi"
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
        Me.printlink1.Landscape = True
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Referans Kayıtları Kontrol", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müşteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_Musteri_Referans_Kontrol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 489)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Musteri_Referans_Kontrol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Referans Kayıtları"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_lPrimLimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nPrimOran4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nPrimOran3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nPrimOran2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nPrimOran1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nPrimOran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kefil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.Bar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sCinsiyet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sUnvan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sIl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHitap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sResimAdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public kasiyer
    Public kasiyerno
    Dim loaded As Boolean = False
    Dim status As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        DateEdit1.Focus()
        DateEdit1.Select()
        txt_ara.EditValue = ""
        dataload_sinif()
    End Sub
    Private Sub dataload_sinif()
        sec_sSinifKodu1.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif1 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu2.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif2 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu3.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif3 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu4.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif4 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu5.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif5 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu6.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif6 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu7.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif7 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu8.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif8 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu9.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif9 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu10.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif10 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu11.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif11 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu12.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif12 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu13.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif13 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu14.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif14 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinifKodu15.DataSource = sorgu(sorgu_query("SELECT     sSinifKodu, sAciklama  FROM         tbMSinif15 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sUnvan.DataSource = sorgu(sorgu_query("SELECT     * FROM         tbUnvan")).Tables(0) 'DataSet2.Tables(0)
        sec_sHitap.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHitap")).Tables(0)
        sec_sIl.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl order by sIl")).Tables(0)
        sec_sCinsiyet.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbCinsiyet")).Tables(0)
        sec_sDepo.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama from tbDepo order by sDepo")).Tables(0)
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasındaki Referanslı Satışlar" & vbCrLf
        kriter += "Prim %= " & txt_nPrimOran.Text & " Limit = " & txt_lPrimLimit.EditValue & "- ve Üzeri Refere Müşteriler için Prim1 %=" & txt_nPrimOran1.Text & " Prim2 %=" & txt_nPrimOran2.Text & " Prim3 %=" & txt_nPrimOran3.Text & " Prim4 %=" & txt_nPrimOran4.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müşteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kefil_kriter As String) As DataSet
        Dim kriter As String = "Where lKodu > 0 "
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND ( tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adı" Then
                kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Soyadı" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "İstihbarat" Then
                kriter += " AND (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "İşAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvTelefonu" Then
                kriter += " AND ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "İşTelefonu" Then
                kriter += " AND ( tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Gsm" Then
                kriter += " AND ( tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "DoğumYeri" Then
                kriter += " AND ( tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "1.Kefil Adı" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "2.Kefil Adı" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf1" Then
                'kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += " ND tbMusteri.nMusteriID IN (SELECT     tbMusteriSinifi.nMusteriID FROM         tbMusteriSinifi INNER JOIN                       tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu WHERE     tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf2" Then
                'kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += " ND tbMusteri.nMusteriID IN (SELECT     tbMusteriSinifi.nMusteriID FROM         tbMusteriSinifi INNER JOIN                       tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE     tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf3" Then
                'kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += " ND tbMusteri.nMusteriID IN (SELECT     tbMusteriSinifi.nMusteriID FROM         tbMusteriSinifi INNER JOIN                       tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu WHERE     tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf4" Then
                'kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += " ND tbMusteri.nMusteriID IN (SELECT     tbMusteriSinifi.nMusteriID FROM         tbMusteriSinifi INNER JOIN                       tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu WHERE     tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf5" Then
                'kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += " ND tbMusteri.nMusteriID IN (SELECT     tbMusteriSinifi.nMusteriID FROM         tbMusteriSinifi INNER JOIN                       tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu WHERE     tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adı+Soyadı" Then
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
        If kefil_kriter = "[Tümü]" Then
        ElseIf kefil_kriter = "Kefil Var" Then
            kriter += " AND tbMusteri.nMusteriID IN (SELECT nMusteriID FROM (SELECT * FROM tbMusteriKefil1 WHERE sAdi <> '' UNION ALL SELECT * FROM tbMusteriKefil2 WHERE sAdi <> '') Kefil)  "
        ElseIf kefil_kriter = "Kefil Yok" Then
            kriter += " AND tbMusteri.nMusteriID NOT IN (SELECT nMusteriID FROM (SELECT * FROM tbMusteriKefil1 WHERE sAdi <> '' UNION ALL SELECT * FROM tbMusteriKefil2 WHERE sAdi <> '') Kefil)  "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.sMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbMusteri.nCinsiyet, tbMusteri.lAylikGelir, tbMusteri.dteKartAcilisTarihi, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, tbMusteri.sUnvan, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu, tbMusteri.sSigortaNo, tbMusteri.bEvlimi, tbMusteri.dteEvlilikTarihi, tbMusteri.dteDogumTarihi, tbMusteri.sDogumYeri, tbMusteri.sEhliyetNo, tbMusteri.sKanGrubu, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteri.sGSM, tbMusteri.sFax, (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME, tbMSinif1.sAciklama AS Sınıf1, tbMSinif2.sAciklama AS Sınıf2, tbMSinif3.sAciklama AS Sınıf3, tbMSinif4.sAciklama AS Sınıf4, tbMSinif5.sAciklama AS Sınıf5,(SELECT ISNULL(COUNT(*),0) AS KefilSayisi FROM (SELECT * FROM tbMusteriKefil1 WHERE sAdi <> '' UNION ALL SELECT * FROM tbMusteriKefil2 WHERE sAdi <> '') Kefil WHERE (nMusteriID = tbMusteri.nMusteriID)) as KefilSayisi FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu " & kriter & " ")
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.*, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME, (SELECT ISNULL(COUNT(*),0) AS KefilSayisi FROM (SELECT * FROM tbMusteriKefil1 WHERE sAdi <> '' UNION ALL SELECT * FROM tbMusteriKefil2 WHERE sAdi <> '') Kefil WHERE (nMusteriID = tbMusteri.nMusteriID)) as KefilSayisi,tbMusteriSinifi.sSinifKodu1, tbMusteriSinifi.sSinifKodu2, tbMusteriSinifi.sSinifKodu3, tbMusteriSinifi.sSinifKodu4, tbMusteriSinifi.sSinifKodu5, tbMusteriSinifi.sSinifKodu6, tbMusteriSinifi.sSinifKodu7, tbMusteriSinifi.sSinifKodu8, tbMusteriSinifi.sSinifKodu9, tbMusteriSinifi.sSinifKodu10, tbMusteriSinifi.sSinifKodu11, tbMusteriSinifi.sSinifKodu12, tbMusteriSinifi.sSinifKodu13, tbMusteriSinifi.sSinifKodu14, tbMusteriSinifi.sSinifKodu15, tbMusteriKredisi.lKrediLimiti, tbMusteriKredisi.dteSonKullanmaTarihi,tbMusteriKredisi.bOzelMusterimi,Cast(0 as money) as lSatis,Cast(0 as Money) as lSatisPrim,Cast(0 as money) as lBasamakSatis1,Cast(0 as money) as lBasamakSatis2,Cast(0 as money) as lBasamakSatis3,Cast(0 as money) as lBasamakSatis4,Cast(0 as money) as lBasamakSatisPrim1,Cast(0 as money) as lBasamakSatisPrim2,Cast(0 as money) as lBasamakSatisPrim3,Cast(0 as money) as lBasamakSatisPrim4,Cast(0 as money) as lToplamSatis,Cast(0 as money) as lToplamSatisPrim FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMusteriKredisi ON tbMusteri.nMusteriID = tbMusteriKredisi.nMusteriID " & kriter & " ")
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kefil_kriter As String)
        loaded = False
        DataSet1 = stok(tarih1, tarih2, ara, konum, ara_kriter, kefil_kriter)
        txt_nPrimOran.Text = sorgu_sayi(txt_nPrimOran.Text, 0)
        txt_nPrimOran1.Text = sorgu_sayi(txt_nPrimOran1.Text, 0)
        txt_nPrimOran2.Text = sorgu_sayi(txt_nPrimOran2.Text, 0)
        txt_nPrimOran3.Text = sorgu_sayi(txt_nPrimOran3.Text, 0)
        txt_nPrimOran4.Text = sorgu_sayi(txt_nPrimOran4.Text, 0)
        Dim dr As DataRow
        Bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        Bar1.Position = 0
        Bar1.Refresh()
        Dim bPrimUygula As Boolean = False
        For Each dr In DataSet1.Tables(0).Rows
            'dr("lSatis") = sorgula_Decimal("SELECT SUM(lNetTutar) AS lSatis FROM tbAlisVeris WHERE (nMusteriID = '" & dr("nMusteriID") & "')")
            'dr("lSatisPrim") = (dr("lSatis") * txt_nPrimOran.Text) / 100
            'dr("lBasamakSatis1") = sorgula_Decimal("SELECT SUM(lNetTutar) AS lSatis FROM tbAlisVeris WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' and (nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE  nRefID = " & dr("nMusteriID") & "))")
            'dr("lBasamakSatisPrim1") = (dr("lBasamakSatis1") * txt_nPrimOran1.Text) / 100
            'dr("lBasamakSatis2") = sorgula_Decimal("SELECT SUM(lNetTutar) AS lSatis FROM tbAlisVeris WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' and (nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID = '" & dr("nMusteriID") & "')))")
            'dr("lBasamakSatisPrim2") = (dr("lBasamakSatis2") * txt_nPrimOran2.Text) / 100
            'dr("lBasamakSatis3") = sorgula_Decimal("SELECT SUM(lNetTutar) AS lSatis FROM tbAlisVeris WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' and (nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID = '" & dr("nMusteriID") & "'))))")
            'dr("lBasamakSatisPrim3") = (dr("lBasamakSatis3") * txt_nPrimOran3.Text) / 100
            'dr("lBasamakSatis4") = sorgula_Decimal("SELECT SUM(lNetTutar) AS lSatis FROM tbAlisVeris WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' and (nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID = '" & dr("nMusteriID") & "')))))")
            'dr("lBasamakSatisPrim4") = (dr("lBasamakSatis4") * txt_nPrimOran4.Text) / 100
            dr("lSatis") = sorgula_Decimal("SELECT SUM(tbStokFisiDetayi.lBrutTutar) AS lSatis FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.nKdvOrani <> 0) and  (tbAlisVeris.nMusteriID = '" & dr("nMusteriID") & "')")
            dr("lSatisPrim") = (dr("lSatis") * txt_nPrimOran.Text) / 100
            If dr("lSatis") >= txt_lPrimLimit.Text Then
                bPrimUygula = True
            Else
                bPrimUygula = False
            End If
            dr("lBasamakSatis1") = sorgula_Decimal("SELECT SUM(tbStokFisiDetayi.lBrutTutar) AS lSatis FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.nKdvOrani <> 0) and (tbAlisVeris.nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE  nRefID = " & dr("nMusteriID") & "))")
            dr("lBasamakSatis2") = sorgula_Decimal("SELECT SUM(tbStokFisiDetayi.lBrutTutar) AS lSatis FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.nKdvOrani <> 0) and (tbAlisVeris.nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID = '" & dr("nMusteriID") & "')))")
            dr("lBasamakSatis3") = sorgula_Decimal("SELECT SUM(tbStokFisiDetayi.lBrutTutar) AS lSatis FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.nKdvOrani <> 0) and (tbAlisVeris.nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID = '" & dr("nMusteriID") & "'))))")
            dr("lBasamakSatis4") = sorgula_Decimal("SELECT SUM(tbStokFisiDetayi.lBrutTutar) AS lSatis FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.nKdvOrani <> 0) and (tbAlisVeris.nMusteriID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID IN (SELECT nMusteriID FROM tbMusteriReferans WHERE nRefID = '" & dr("nMusteriID") & "')))))")
            If bPrimUygula = True Then
                dr("lBasamakSatisPrim1") = (dr("lBasamakSatis1") * txt_nPrimOran1.Text) / 100
                dr("lBasamakSatisPrim2") = (dr("lBasamakSatis2") * txt_nPrimOran2.Text) / 100
                dr("lBasamakSatisPrim3") = (dr("lBasamakSatis3") * txt_nPrimOran3.Text) / 100
                dr("lBasamakSatisPrim4") = (dr("lBasamakSatis4") * txt_nPrimOran4.Text) / 100
            Else
                dr("lBasamakSatisPrim1") = 0
                dr("lBasamakSatisPrim2") = 0
                dr("lBasamakSatisPrim3") = 0
                dr("lBasamakSatisPrim4") = 0
            End If
            dr("lToplamSatis") = dr("lSatis") + dr("lBasamakSatis1") + dr("lBasamakSatis2") + dr("lBasamakSatis3") + dr("lBasamakSatis4")
            dr("lToplamSatisPrim") = dr("lSatisPrim") + dr("lBasamakSatisPrim1") + dr("lBasamakSatisPrim2") + dr("lBasamakSatisPrim3") + dr("lBasamakSatisPrim4")
            Bar1.Position += 1
            Bar1.Refresh()
        Next
        Bar1.Properties.Maximum = 0
        Bar1.Position = 0
        Bar1.Refresh()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        loaded = True
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
    Private Sub analiz_musteri_duzenle()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lKodu = dr("lKodu")
            frm.nMusteriID = dr("nMusteriID")
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
    Private Sub musteri_notlari()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti_aciklama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kayitno = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_refere_detay()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Musteri_Referans_Kontrol_Detay
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = dr("nMusteriID")
            frm.tarih1 = DateEdit1.EditValue
            frm.tarih2 = DateEdit2.EditValue
            frm.kullanici = kullanici
            frm.status = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub tutar_hesapla()
        If loaded = True Then
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                If dr("bEvlimi") = False Then
                    dr("dteEvlilikTarihi") = "01/01/1900"
                End If
                dr.EndEdit()
                'Müşteri
                tbMusteri_kaydet_duzelt(dr("nMusteriID"), dr("sMagaza"), dr("lKodu"), dr("sAdi"), dr("sSoyadi"), dr("nCinsiyet"), dr("lAylikGelir"), dr("dteKartAcilisTarihi"), dr("nIskontoPesin"), dr("nIskontoKredili"), dr("sUnvan"), dr("sVergiDairesi"), dr("sVergiNo"), dr("bYazismaEvAdresinemi"), dr("sEmail"), dr("sIsYeriAdi"), dr("sIsAdresi1"), dr("sIsAdresi2"), dr("sIsSemt"), dr("sIsIl"), dr("sIsPostaKodu"), dr("sIsTelefonu"), dr("sEvAdresi1"), dr("sEvAdresi2"), dr("sEvSemt"), dr("sEvPostaKodu"), dr("sEvIl"), dr("sEvTelefonu"), dr("sSigortaNo"), dr("bEvlimi"), dr("dteEvlilikTarihi"), dr("dteDogumTarihi"), dr("sDogumYeri"), dr("sEhliyetNo"), dr("sKanGrubu"), dr("sHitap"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sAciklama1"), dr("sAciklama2"), dr("sAciklama3"), dr("sAciklama4"), dr("sAciklama5"), dr("sGSM"), dr("sFax"), dr("sResimAdi"))
                'Müşteri Kredisi
                tbMusteriKredisi_kaydet_duzelt(dr("nMusteriID"), dr("lKrediLimiti"), dr("dteSonKullanmaTarihi"), dr("bOzelMusterimi"))
                'Müşteri Sınıfı
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu1"), 1)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu2"), 2)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu4"), 3)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu4"), 4)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu5"), 5)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu6"), 6)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu7"), 7)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu8"), 8)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu9"), 9)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu10"), 10)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu11"), 11)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu12"), 12)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu13"), 13)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu14"), 14)
                tbMusteriSinifi_kaydet_duzelt(dr("nMusteriID"), dr("sSinifKodu15"), 15)
            End If
        End If
    End Sub
    Private Sub tbMusteri_kaydet_duzelt(ByVal nMusteriID As String, ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteri SET              sMagaza = '" & sMagaza & "', lKodu = '" & lKodu & "', sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', nCinsiyet = " & nCinsiyet & ", lAylikGelir = " & lAylikGelir & ", dteKartAcilisTarihi = '" & dteKartAcilisTarihi & "', nIskontoPesin = " & nIskontoPesin & ", nIskontoKredili = " & nIskontoKredili & ", sUnvan = '" & sUnvan & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', bYazismaEvAdresinemi = " & bYazismaEvAdresinemi & ", sEmail = '" & sEmail & "', sIsYeriAdi = '" & sIsYeriAdi & "', sIsAdresi1 = '" & sIsAdresi1 & "', sIsAdresi2 = '" & sIsAdresi2 & "', sIsSemt = '" & sIsSemt & "', sIsIl = '" & sIsIl & "', sIsPostaKodu = '" & sIsPostaKodu & "', sIsTelefonu = '" & sIsTelefonu & "', sEvAdresi1 = '" & sEvAdresi1 & "', sEvAdresi2 = '" & sEvAdresi2 & "', sEvSemt = '" & sEvSemt & "', sEvPostaKodu = '" & sEvPostaKodu & "', sEvIl = '" & sEvIl & "', sEvTelefonu = '" & sEvTelefonu & "', sSigortaNo = '" & sSigortaNo & "', bEvlimi = " & bEvlimi & ", dteEvlilikTarihi = '" & dteEvlilikTarihi & "', dteDogumTarihi = '" & dteDogumTarihi & "', sDogumYeri = '" & sDogumYeri & "', sEhliyetNo = '" & sEhliyetNo & "', sKanGrubu = '" & sKanGrubu & "', sHitap = '" & sHitap & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sGSM = '" & sGSM & "', sFax = '" & sFax & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriSinifi_kaydet_duzelt(ByVal nMusteriID As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriSinifi SET              sSinifKodu" & sSinifNo & " = '" & sSinifKodu & "' where  nMusteriID = '" & nMusteriID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKredisi_kaydet_duzelt(ByVal nMusteriID As String, ByVal lKrediLimiti As String, ByVal dteSonKullanmaTarihi As DateTime, ByVal bOzelMusterimi As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriKredisi SET              lKrediLimiti = " & lKrediLimiti & ", dteKrediLimitiTarihi = '" & dteKrediLimitiTarihi & "', dteKrediAcilisTarihi = '" & dteKrediAcilisTarihi & "', dteSonKullanmaTarihi = '" & dteSonKullanmaTarihi & "', bOzelMusterimi = " & bOzelMusterimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "' Where nMusteriID = '" & nMusteriID & "' ")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriKredisi SET              lKrediLimiti = " & lKrediLimiti & ", dteSonKullanmaTarihi = '" & dteSonKullanmaTarihi & "', bOzelMusterimi = " & bOzelMusterimi & " Where nMusteriID = '" & nMusteriID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub deger_yay()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                status = True
                degeryay(GridView1.FocusedColumn().FieldName)
                status = False
            End If
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        'kl = CType(Me.BindingContext(DataView1), CurrencyManager)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim İ As Integer
        İ = 0
        Dim dr_hareket As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        'kl.Position += 1
        For İ = 1 To TOPLAM
            dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr_hareket.BeginEdit()
            dr_hareket("" & columnkriter & "") = durum
            dr_hareket.EndEdit()
            tutar_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        'kl.Position = satir
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        İ = Nothing
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
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
                lbl_istihbarat.Text = dr("ISTIHBARAT")
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        analiz_refere_detay()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        ElseIf e.KeyCode = Keys.Enter Then
            analiz_refere_detay()
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_kefil.Text)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub SMS_Gonder()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayıtlara SMS Göndermek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If Trim(dr("sGSM")) <> "" Then
                        Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                        dr1("nIslemID") = 0
                        dr1("sSMSID") = 0
                        dr1("dteGonderimTarihi") = Today
                        dr1("sMesaj") = ""
                        dr1("nMusteriID") = dr("nMusteriID")
                        dr1("lKodu") = dr("lKodu")
                        dr1("sAdi") = dr("sAdi")
                        dr1("sSoyadi") = dr("sSoyadi")
                        dr1("sTelefon") = dr("sGSM")
                        dr1("dteUpdateTarihi") = Now
                        dr1("lDurum") = 0
                        dr1("lBakiye") = 0
                        frm.DataSet1.Tables(0).Rows.Add(dr1)
                    End If
                Next
            End If
            'MsgBox(Sorgu_sDil("İşlem Tamamlandı...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_musteri_KarlilikAkisTablosu(Optional ByVal islem As Integer = 0)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_satis_karlilik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = dteSistemTarihi
            frm.txt_ara.Text = ""
            frm.txt_ara_stok.Text = ""
            frm.sec_MaliyetTipi.Text = "Stok Kartından"
            frm.kriter_musteriID = "AND tbMusteri.nMusteriID = " & dr("nMusteriID") & " "
            If islem = 3 Then
                frm.kriter_fistipi = "'DC'"
                frm.islem = 2
            Else
                frm.islem = islem
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub takibe_al()
        Dim frm As New frm_emir_musteri_takip_toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyerno = kasiyerno
        frm.kasiyer = kasiyer
        frm.txt_takip_aciklama.Text = "Yeni Müşteri Kayıtları..."
        frm.status = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim sayi = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                Panelstatus.Visible = True
                bar.Properties.Maximum = GridView1.SelectedRowsCount
                barlabel.Text = "Toplam Satır Sayısı : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüşteriKodu:" & dr("lKodu").ToString & vbTab & "Adı:" & dr("Musteri").ToString
                    barlabel.Refresh()
                    takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text, frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("lKodu"), dr("sAdi"), dr("sSoyadi"), Microsoft.VisualBasic.Left(dr("Musteri"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", 0, False, "", "", "", "", "", False)
                    bar.Position = bar.Position + 1
                    bar.Refresh()
                Next
                bar.Position = 0
                Panelstatus.Visible = False
                dr = Nothing
            End If
            frm.Dispose()
            frm.Close()
            System.GC.SuppressFinalize(frm)
            frm = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub takib_ekle(ByVal dteTarih As DateTime, ByVal TakipTipi As String, ByVal TakipAciklama As String, ByVal PersonelNo As Int64, ByVal Personel As String, ByVal nMusteriID As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal Musteri As String, ByVal Sonuc As String, ByVal IletisimTarihi As DateTime, ByVal IletisimSekli As String, ByVal IlgiliKisi As String, ByVal Gelecekmi As Byte, ByVal GTarih As DateTime, ByVal Tutar As Decimal, ByVal Odendi As Byte, ByVal Istihbarat As String, ByVal Aciklama1 As String, ByVal Aciklama2 As String, ByVal Aciklama3 As String, ByVal Aciklama4 As String, ByVal Status As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'Dim ilk_personel As Decimal = 0
        'ilk_personel = sorgu_ilkpersonelno(nMusteriID).ToString
        'If ilk_personel > 0 Then
        '    PersonelNo = ilk_personel
        '    Personel = sorgu_ilkpersoneladi(ilk_personel)
        'Else
        'End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirMusteriTakip                       (dteTarih, TakipTipi, TakipAciklama, PersonelNo, Personel, nMusteriID,lKodu, sAdi, sSoyadi, Musteri, Sonuc, IletisimTarihi, IletisimSekli, IlgiliKisi, Gelecekmi, GTarih, Tutar, Odendi, Istihbarat, Aciklama1, Aciklama2, Aciklama3, Aciklama4, Status,KayitTarihi,ErisimTarihi) VALUES     ('" & dteTarih & "', '" & TakipTipi & "', '" & TakipAciklama & "', " & PersonelNo & ", '" & Personel & "','" & nMusteriID & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & Musteri & "', '" & Sonuc & "', '" & IletisimTarihi & "', '" & IletisimSekli & "', '" & IlgiliKisi & "', " & Gelecekmi & ", '" & GTarih & "', " & Tutar & " , " & Odendi & ", '" & Istihbarat & "', '" & Aciklama1 & "', '" & Aciklama2 & "', '" & Aciklama3 & "', '" & Aciklama4 & "', " & Status & " ,'" & Now & "','" & Now & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        'ilk_personel = Nothing
    End Sub
    Public Function sorgu_ilkpersonelno(ByVal nMusteriID) As Int64
        Dim kriter
        kriter = "WHERE (nMusteriID = '" & nMusteriID & "') and TakipTipi <> 'Teslimat' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(PersonelNo, 0) AS PersonelNo FROM         aEmirMusteriTakip " & kriter & " ORDER BY IND DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_ilkpersoneladi(ByVal PersonelNo As Int64) As String
        Dim kriter
        kriter = "WHERE (IND = '" & PersonelNo & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     PERSONELADI FROM         APERSONEL        " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        takibe_al()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If MenuItem2.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem2.Checked = True
        ElseIf MenuItem2.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem2.Checked = False
        End If
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Musteri.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Musteri.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        musteri_notlari()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_pdf()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        deger_yay()
    End Sub
    Friend WithEvents Bar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents collSatis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSatisPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatis1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatis2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatis3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatis4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatisPrim1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatisPrim2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatisPrim3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBasamakSatisPrim4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamSatis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamSatisPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nPrimOran4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nPrimOran3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nPrimOran2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nPrimOran1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nPrimOran As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lPrimLimit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        analiz_refere_detay()
    End Sub
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        SMS_Gonder()
    End Sub
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
End Class
