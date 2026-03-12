Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_perakende_entegre
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
    Friend WithEvents sec_magaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_kasa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kasa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_kasiyer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kasiyer_kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_belgeno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sec_fistipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_depo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents collMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagazaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSiparisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_nGirisCikis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colsOdemeKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sOdemeKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents collReyonFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sFiyatTipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents collGCMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIadeNedeni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnPartiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilecek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbTeslimEdildi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbMuhasebeyeIslendimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEkSoru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEkAlan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEkAlan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSonKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSonUpdateTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokIslemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOnayTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStoksKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStoksAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents kisayol_baslik As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents kisayol_detay As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_toplu As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_Adres As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colsAlisVerisYapanAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAlisVerisYapanSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdres1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdres2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bMusteriAdresi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_sFisTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colsMuhasebeFaturalasma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perakende_entegre))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_magaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_kasa = New DevExpress.XtraEditors.LookUpEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_kasa = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_kasiyer = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kasiyer_kod = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_sFisTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_toplu = New DevExpress.XtraEditors.CheckEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_belgeno = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_fistipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_musterino = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_depo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.lbl_Adres = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_bMusteriAdresi = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_detay = New System.Windows.Forms.ContextMenu()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagazaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSiparisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collReyonFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGCMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIadeNedeni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnPartiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilecek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbTeslimEdildi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbMuhasebeyeIslendimi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEkSoru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEkAlan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEkAlan2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSonKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteSonUpdateTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokIslemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStoksKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStoksAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sFiyatTipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_nGirisCikis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_sSatici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_sOdemeKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_baslik = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.ds_baslik = New System.Data.DataSet()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisVerisYapanAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisVerisYapanSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdres1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdres2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMuhasebeFaturalasma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_toplu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_bMusteriAdresi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nGirisCikis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.sec_magaza)
        Me.PanelControl1.Controls.Add(Me.sec_kasa)
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.lbl_kasa)
        Me.PanelControl1.Controls.Add(Me.lbl_kasiyer)
        Me.PanelControl1.Controls.Add(Me.txt_kasiyer_kod)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl1.TabIndex = 2
        '
        'sec_magaza
        '
        Me.sec_magaza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sec_magaza.Location = New System.Drawing.Point(648, 23)
        Me.sec_magaza.Name = "sec_magaza"
        Me.sec_magaza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_magaza.Properties.Appearance.Options.UseFont = True
        Me.sec_magaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_magaza.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açýklama")})
        Me.sec_magaza.Properties.DisplayMember = "sAciklama"
        Me.sec_magaza.Properties.NullText = "[Maðaza]"
        Me.sec_magaza.Properties.ReadOnly = True
        Me.sec_magaza.Properties.ValueMember = "sDepo"
        Me.sec_magaza.Size = New System.Drawing.Size(168, 20)
        Me.sec_magaza.TabIndex = 11
        '
        'sec_kasa
        '
        Me.sec_kasa.Location = New System.Drawing.Point(56, 23)
        Me.sec_kasa.Name = "sec_kasa"
        Me.sec_kasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nKasaNo", 5, "KasaNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", 40, "Açýklama")})
        Me.sec_kasa.Properties.DisplayMember = "nKasaNo"
        Me.sec_kasa.Properties.NullText = "[Kasa]"
        Me.sec_kasa.Properties.ValueMember = "nKasaNo"
        Me.sec_kasa.Size = New System.Drawing.Size(120, 20)
        Me.sec_kasa.TabIndex = 10
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(648, 4)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.NullText = "[Tarih]"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(168, 20)
        Me.DateEdit1.TabIndex = 8
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(601, 31)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Maðaza:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(614, 9)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Tarih:"
        '
        'lbl_kasa
        '
        Me.lbl_kasa.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kasa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_kasa.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_kasa.Location = New System.Drawing.Point(178, 28)
        Me.lbl_kasa.Name = "lbl_kasa"
        Me.lbl_kasa.Size = New System.Drawing.Size(14, 13)
        Me.lbl_kasa.TabIndex = 5
        Me.lbl_kasa.Text = "**"
        '
        'lbl_kasiyer
        '
        Me.lbl_kasiyer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kasiyer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_kasiyer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_kasiyer.Location = New System.Drawing.Point(179, 9)
        Me.lbl_kasiyer.Name = "lbl_kasiyer"
        Me.lbl_kasiyer.Size = New System.Drawing.Size(7, 13)
        Me.lbl_kasiyer.TabIndex = 4
        Me.lbl_kasiyer.Text = "*"
        '
        'txt_kasiyer_kod
        '
        Me.txt_kasiyer_kod.Location = New System.Drawing.Point(56, 4)
        Me.txt_kasiyer_kod.Name = "txt_kasiyer_kod"
        Me.txt_kasiyer_kod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kasiyer_kod.Properties.NullText = "[Kasiyer]"
        Me.txt_kasiyer_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kasiyer_kod.Size = New System.Drawing.Size(120, 20)
        Me.txt_kasiyer_kod.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(22, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Kasa:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(10, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Kasiyer:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Controls.Add(Me.lbl_Adres)
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 48)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 120)
        Me.PanelControl2.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.sec_sFisTipi)
        Me.GroupControl1.Controls.Add(Me.sec_toplu)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.sec_resmi)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txt_belgeno)
        Me.GroupControl1.Controls.Add(Me.sec_fistipi)
        Me.GroupControl1.Controls.Add(Me.txt_musterino)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(534, 116)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Ara"
        '
        'sec_sFisTipi
        '
        Me.sec_sFisTipi.EditValue = "[Tümü]"
        Me.sec_sFisTipi.Location = New System.Drawing.Point(184, 84)
        Me.sec_sFisTipi.Name = "sec_sFisTipi"
        Me.sec_sFisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFisTipi.Properties.Items.AddRange(New Object() {"[Tümü]", "Normal", "Sonradan Teslim"})
        Me.sec_sFisTipi.Size = New System.Drawing.Size(80, 20)
        Me.sec_sFisTipi.TabIndex = 60
        '
        'sec_toplu
        '
        Me.sec_toplu.Enabled = False
        Me.sec_toplu.Location = New System.Drawing.Point(322, 46)
        Me.sec_toplu.Name = "sec_toplu"
        Me.sec_toplu.Properties.Caption = "t"
        Me.sec_toplu.Size = New System.Drawing.Size(32, 19)
        Me.sec_toplu.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(33, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Belge:"
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(322, 68)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(264, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Belge Nolu"
        '
        'txt_belgeno
        '
        Me.txt_belgeno.EnterMoveNextControl = True
        Me.txt_belgeno.Location = New System.Drawing.Point(184, 64)
        Me.txt_belgeno.Name = "txt_belgeno"
        Me.txt_belgeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_belgeno.Size = New System.Drawing.Size(80, 20)
        Me.txt_belgeno.TabIndex = 55
        '
        'sec_fistipi
        '
        Me.sec_fistipi.EditValue = "[Tümü]"
        Me.sec_fistipi.EnterMoveNextControl = True
        Me.sec_fistipi.Location = New System.Drawing.Point(69, 44)
        Me.sec_fistipi.Name = "sec_fistipi"
        Me.sec_fistipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fistipi.Properties.Items.AddRange(New Object() {"[Tümü]", "K", "P", "PF", "SK", "SP"})
        Me.sec_fistipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_fistipi.Size = New System.Drawing.Size(195, 20)
        Me.sec_fistipi.TabIndex = 54
        '
        'txt_musterino
        '
        Me.txt_musterino.EnterMoveNextControl = True
        Me.txt_musterino.Location = New System.Drawing.Point(69, 64)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musterino.Size = New System.Drawing.Size(91, 20)
        Me.txt_musterino.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Müþteri:"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.Enabled = False
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(69, 84)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.Items.AddRange(New Object() {"[Tümü]", "D001", "D002", "D003", "D004", "D005", "D006", "D007", "D008", "D009", "D010", "AKAT", "BKAT", "GKAT", "1KAT", "2KAT", "3KAT", "4KAT", "5KAT", "6KAT", "7KAT", "8KAT", "9KAT", "", ""})
        Me.sec_depo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_depo.Size = New System.Drawing.Size(91, 20)
        Me.sec_depo.TabIndex = 40
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Enabled = False
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(264, 84)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton5.TabIndex = 44
        Me.SimpleButton5.Text = "&Listele"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(34, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Depo:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(273, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(165, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "ve"
        '
        'DateEdit3
        '
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.EnterMoveNextControl = True
        Me.DateEdit3.Location = New System.Drawing.Point(184, 24)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.ReadOnly = True
        Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit3.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit3.TabIndex = 38
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(69, 24)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(90, 20)
        Me.DateEdit2.TabIndex = 37
        '
        'lbl_Adres
        '
        Me.lbl_Adres.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Adres.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_Adres.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Adres.Location = New System.Drawing.Point(536, 2)
        Me.lbl_Adres.Name = "lbl_Adres"
        Me.lbl_Adres.Size = New System.Drawing.Size(6, 11)
        Me.lbl_Adres.TabIndex = 59
        Me.lbl_Adres.Text = "*"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lbl_istihbarat)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(542, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(280, 116)
        Me.GroupControl2.TabIndex = 25
        Me.GroupControl2.Text = "Ýstihbarat"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_istihbarat.Location = New System.Drawing.Point(2, 15)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(276, 13)
        Me.lbl_istihbarat.TabIndex = 0
        Me.lbl_istihbarat.Text = "Ýstihbarat..."
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.sec_bMusteriAdresi)
        Me.PanelControl3.Controls.Add(Me.SimpleButton3)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.Label5)
        Me.PanelControl3.Controls.Add(Me.SimpleButton2)
        Me.PanelControl3.Controls.Add(Me.SimpleButton1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 526)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl3.TabIndex = 4
        '
        'sec_bMusteriAdresi
        '
        Me.sec_bMusteriAdresi.Location = New System.Drawing.Point(126, 14)
        Me.sec_bMusteriAdresi.Name = "sec_bMusteriAdresi"
        Me.sec_bMusteriAdresi.Properties.Caption = "Müþteri Adresini Kullan"
        Me.sec_bMusteriAdresi.Size = New System.Drawing.Size(140, 19)
        Me.sec_bMusteriAdresi.TabIndex = 58
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(112, 24)
        Me.SimpleButton3.TabIndex = 16
        Me.SimpleButton3.Text = "&Faturasýný Kes"
        '
        'Label2
        '
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(256, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'Label5
        '
        Me.Label5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(256, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 16)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 13
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GroupControl4)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 326)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(824, 200)
        Me.PanelControl4.TabIndex = 5
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Purple
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.GridControl2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(820, 196)
        Me.GroupControl4.TabIndex = 1
        Me.GroupControl4.Text = "Seçili Satýþlarýn Detayý"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_detay
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 15)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sFiyatTipi, Me.sec_nGirisCikis, Me.sec_sSatici, Me.sec_sOdemeKodu})
        Me.GridControl2.Size = New System.Drawing.Size(816, 179)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_detay
        '
        Me.kisayol_detay.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41, Me.MenuItem42, Me.MenuItem43, Me.MenuItem44, Me.MenuItem45})
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem25.Text = "Düzenle"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem28.Text = "Fiyat Düzenle"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem29.Text = "Envanter"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 4
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem30.Text = "Model Envanter"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 5
        Me.MenuItem31.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem31.Text = "Stok Hareketleri"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 6
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem32.Text = "Transfer Hareketleri"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 7
        Me.MenuItem37.Text = "-"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 8
        Me.MenuItem38.Text = "Görünüm Düzenle"
        '
        'MenuItem39
        '
        Me.MenuItem39.Enabled = False
        Me.MenuItem39.Index = 9
        Me.MenuItem39.Text = "Görünümü Kaydet"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 10
        Me.MenuItem40.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem40.Text = "Görünümü Yazdýr"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 11
        Me.MenuItem41.Text = "-"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 12
        Me.MenuItem42.Text = "Filtrele"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 13
        Me.MenuItem43.Text = "Gruplandýr"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 14
        Me.MenuItem44.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 15
        Me.MenuItem45.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem45.Text = "Tam Ekran"
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HorzLine.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HorzLine.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.HorzLine.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView2.Appearance.TopNewRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnAlisverisID, Me.colsMagazaKodu, Me.colnSiparisID, Me.GridColumn1, Me.colnStokID, Me.GridColumn2, Me.colsSaticiRumuzu, Me.colsOdemeKodu, Me.collReyonFisNo, Me.colsFiyatTipi, Me.collGCMiktar, Me.collBrutFiyat, Me.collBrutTutar, Me.colnIskontoYuzdesi, Me.collIskontoTutari, Me.collFiyat, Me.collTutar, Me.colnKdvOrani, Me.colsIadeNedeni, Me.colnPartiID, Me.coldteTeslimEdilecek, Me.coldteTeslimEdilen, Me.colbTeslimEdildi, Me.colbMuhasebeyeIslendimi, Me.colsAciklama, Me.colbEkSoru, Me.colbEkAlan1, Me.colbEkAlan2, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsSonKullaniciAdi, Me.coldteSonUpdateTarihi, Me.colnStokIslemID, Me.coldteOnayTarihi, Me.colnStoksKodu, Me.colnStoksAciklama})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(361, 243, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 35
        Me.GridView2.Name = "GridView2"
        Me.GridView2.NewItemRowText = "[Yeni Satýr]"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsNavigation.UseTabKey = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "AlýþVeriþ No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        Me.colnAlisverisID.OptionsColumn.AllowEdit = False
        '
        'colsMagazaKodu
        '
        Me.colsMagazaKodu.Caption = "Maðaza"
        Me.colsMagazaKodu.FieldName = "sMagazaKodu"
        Me.colsMagazaKodu.Name = "colsMagazaKodu"
        Me.colsMagazaKodu.OptionsColumn.AllowEdit = False
        '
        'colnSiparisID
        '
        Me.colnSiparisID.Caption = "Sipariþ No"
        Me.colnSiparisID.FieldName = "nSiparisID"
        Me.colnSiparisID.Name = "colnSiparisID"
        Me.colnSiparisID.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.Caption = "SatýrTipi"
        Me.GridColumn1.FieldName = "nGirisCikis"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 48
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Kasiyer"
        Me.GridColumn2.FieldName = "sKasiyerRumuzu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satýcý"
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        Me.colsSaticiRumuzu.Visible = True
        Me.colsSaticiRumuzu.VisibleIndex = 7
        Me.colsSaticiRumuzu.Width = 39
        '
        'colsOdemeKodu
        '
        Me.colsOdemeKodu.Caption = "Ödeme"
        Me.colsOdemeKodu.FieldName = "sOdemeKodu"
        Me.colsOdemeKodu.Name = "colsOdemeKodu"
        Me.colsOdemeKodu.Visible = True
        Me.colsOdemeKodu.VisibleIndex = 8
        Me.colsOdemeKodu.Width = 52
        '
        'collReyonFisNo
        '
        Me.collReyonFisNo.Caption = "Fiþ No"
        Me.collReyonFisNo.FieldName = "lReyonFisNo"
        Me.collReyonFisNo.Name = "collReyonFisNo"
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 4
        Me.colsFiyatTipi.Width = 52
        '
        'collGCMiktar
        '
        Me.collGCMiktar.Caption = "Miktar"
        Me.collGCMiktar.DisplayFormat.FormatString = "#,0.####"
        Me.collGCMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGCMiktar.FieldName = "lCikisMiktar1"
        Me.collGCMiktar.Name = "collGCMiktar"
        Me.collGCMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGCMiktar", "{0:#,0.####}")})
        Me.collGCMiktar.Visible = True
        Me.collGCMiktar.VisibleIndex = 2
        Me.collGCMiktar.Width = 42
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Brüt Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 5
        Me.collBrutFiyat.Width = 52
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
        Me.collBrutTutar.VisibleIndex = 6
        Me.collBrutTutar.Width = 55
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "Isk1%"
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        Me.colnIskontoYuzdesi.OptionsColumn.AllowFocus = False
        Me.colnIskontoYuzdesi.Width = 34
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Iskonto"
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.OptionsColumn.AllowFocus = False
        Me.collIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskontoTutari", "{0:#,0.00##}")})
        Me.collIskontoTutari.Width = 31
        '
        'collFiyat
        '
        Me.collFiyat.Caption = "Fiyat"
        Me.collFiyat.FieldName = "lFiyat"
        Me.collFiyat.Name = "collFiyat"
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lBrutTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.00##}")})
        Me.collTutar.Width = 78
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.####"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        '
        'colsIadeNedeni
        '
        Me.colsIadeNedeni.Caption = "Ýade Nedeni"
        Me.colsIadeNedeni.FieldName = "sIadeNedeni"
        Me.colsIadeNedeni.Name = "colsIadeNedeni"
        Me.colsIadeNedeni.Width = 173
        '
        'colnPartiID
        '
        Me.colnPartiID.Caption = "PartiID"
        Me.colnPartiID.FieldName = "nPartiID"
        Me.colnPartiID.Name = "colnPartiID"
        Me.colnPartiID.OptionsColumn.AllowEdit = False
        '
        'coldteTeslimEdilecek
        '
        Me.coldteTeslimEdilecek.Caption = "Termin"
        Me.coldteTeslimEdilecek.FieldName = "dteTeslimEdilecek"
        Me.coldteTeslimEdilecek.Name = "coldteTeslimEdilecek"
        '
        'coldteTeslimEdilen
        '
        Me.coldteTeslimEdilen.Caption = "Teslim Tarihi"
        Me.coldteTeslimEdilen.FieldName = "dteTeslimEdilen"
        Me.coldteTeslimEdilen.Name = "coldteTeslimEdilen"
        '
        'colbTeslimEdildi
        '
        Me.colbTeslimEdildi.Caption = "TeslimEdildi?"
        Me.colbTeslimEdildi.FieldName = "bTeslimEdildi"
        Me.colbTeslimEdildi.Name = "colbTeslimEdildi"
        '
        'colbMuhasebeyeIslendimi
        '
        Me.colbMuhasebeyeIslendimi.Caption = "Muhasebeye Ýþlendimi?"
        Me.colbMuhasebeyeIslendimi.FieldName = "bMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.Name = "colbMuhasebeyeIslendimi"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        '
        'colbEkSoru
        '
        Me.colbEkSoru.Caption = "EkSoru"
        Me.colbEkSoru.FieldName = "bEkSoru"
        Me.colbEkSoru.Name = "colbEkSoru"
        '
        'colbEkAlan1
        '
        Me.colbEkAlan1.Caption = "EkAlan1"
        Me.colbEkAlan1.FieldName = "bEkAlan1"
        Me.colbEkAlan1.Name = "colbEkAlan1"
        '
        'colbEkAlan2
        '
        Me.colbEkAlan2.Caption = "EkAlan2"
        Me.colbEkAlan2.FieldName = "bEkAlan2"
        Me.colbEkAlan2.Name = "colbEkAlan2"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi 1"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarý 1"
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru 1"
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'colsSonKullaniciAdi
        '
        Me.colsSonKullaniciAdi.Caption = "Son Kullanýcý Adý"
        Me.colsSonKullaniciAdi.FieldName = "sSonKullaniciAdi"
        Me.colsSonKullaniciAdi.Name = "colsSonKullaniciAdi"
        '
        'coldteSonUpdateTarihi
        '
        Me.coldteSonUpdateTarihi.Caption = "Son Güncelleme Tarihi"
        Me.coldteSonUpdateTarihi.FieldName = "dteSonUpdateTarihi"
        Me.coldteSonUpdateTarihi.Name = "coldteSonUpdateTarihi"
        '
        'colnStokIslemID
        '
        Me.colnStokIslemID.Caption = "StokIslemID"
        Me.colnStokIslemID.FieldName = "nStokIslemID"
        Me.colnStokIslemID.Name = "colnStokIslemID"
        '
        'coldteOnayTarihi
        '
        Me.coldteOnayTarihi.Caption = "Onay Tarihi"
        Me.coldteOnayTarihi.FieldName = "dteOnayTarihi"
        Me.coldteOnayTarihi.Name = "coldteOnayTarihi"
        '
        'colnStoksKodu
        '
        Me.colnStoksKodu.Caption = "Stok Kodu"
        Me.colnStoksKodu.FieldName = "sKodu"
        Me.colnStoksKodu.Name = "colnStoksKodu"
        Me.colnStoksKodu.OptionsColumn.AllowFocus = False
        Me.colnStoksKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStoksKodu", "{0} Kayýt")})
        Me.colnStoksKodu.Visible = True
        Me.colnStoksKodu.VisibleIndex = 0
        Me.colnStoksKodu.Width = 131
        '
        'colnStoksAciklama
        '
        Me.colnStoksAciklama.Caption = "Stok Adý"
        Me.colnStoksAciklama.FieldName = "sStokAciklama"
        Me.colnStoksAciklama.Name = "colnStoksAciklama"
        Me.colnStoksAciklama.OptionsColumn.AllowFocus = False
        Me.colnStoksAciklama.Visible = True
        Me.colnStoksAciklama.VisibleIndex = 1
        Me.colnStoksAciklama.Width = 133
        '
        'sec_sFiyatTipi
        '
        Me.sec_sFiyatTipi.AutoHeight = False
        Me.sec_sFiyatTipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi.DisplayMember = "sFiyatTipi"
        Me.sec_sFiyatTipi.Name = "sec_sFiyatTipi"
        Me.sec_sFiyatTipi.NullText = "[FiyatTipi]"
        Me.sec_sFiyatTipi.ValueMember = "sFiyatTipi"
        '
        'sec_nGirisCikis
        '
        Me.sec_nGirisCikis.AutoHeight = False
        Me.sec_nGirisCikis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nGirisCikis.DisplayMember = "sAciklama"
        Me.sec_nGirisCikis.Name = "sec_nGirisCikis"
        Me.sec_nGirisCikis.NullText = "[SatýrTipi]"
        Me.sec_nGirisCikis.ValueMember = "nGirisCikis"
        '
        'sec_sSatici
        '
        Me.sec_sSatici.AutoHeight = False
        Me.sec_sSatici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.DisplayMember = "sSaticiRumuzu"
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.NullText = "[Satýcý]"
        Me.sec_sSatici.ValueMember = "sSaticiRumuzu"
        '
        'sec_sOdemeKodu
        '
        Me.sec_sOdemeKodu.AutoHeight = False
        Me.sec_sOdemeKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeKodu.DisplayMember = "sOdemeKodu"
        Me.sec_sOdemeKodu.Name = "sec_sOdemeKodu"
        Me.sec_sOdemeKodu.ValueMember = "sOdemeKodu"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GroupControl3)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 168)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(824, 158)
        Me.PanelControl5.TabIndex = 6
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(820, 154)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Yapýlan Satýþlarýn Listesi"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_baslik
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_baslik
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 15)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(816, 137)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_baslik
        '
        Me.kisayol_baslik.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem23, Me.MenuItem20, Me.MenuItem2, Me.MenuItem1, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Kalan Taksitler"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Kalan Satýþlar"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Satýþlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 7
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem23.Text = "Müþteri Düzenle"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 9
        Me.MenuItem2.Text = "Hýzlý Filtre"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 10
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = False
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
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "lMiktar"
        Me.DataColumn1.DataType = GetType(Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lNetTutar"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nMusteriID"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "lKodu"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAdi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sSoyadi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Musteri"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteFisTarihi"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "lFisNo"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nGirisCikis"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sFisTipi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sDepo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "ISTIHBARAT"
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
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collMiktar, Me.collNetTutar, Me.colnMusteriID, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colMusteri, Me.coldteFisTarihi, Me.collFisNo, Me.colnGirisCikis, Me.colsFisTipi, Me.colsDepo, Me.colsKasiyerRumuzu, Me.colISTIHBARAT, Me.colsAlisVerisYapanAdi, Me.colsAlisVerisYapanSoyadi, Me.colsAdres1, Me.colsAdres2, Me.colsVergiDairesi, Me.colsVergiNo, Me.colsNot, Me.colsMuhasebeFaturalasma})
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
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
        'collMiktar
        '
        Me.collMiktar.Caption = "Miktar"
        Me.collMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktar.FieldName = "lMiktar"
        Me.collMiktar.Name = "collMiktar"
        Me.collMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", "{0:#,0.##}")})
        Me.collMiktar.Visible = True
        Me.collMiktar.VisibleIndex = 9
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
        Me.collNetTutar.VisibleIndex = 10
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "MusteriID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        '
        'collKodu
        '
        Me.collKodu.Caption = "Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 0
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adý"
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
        'colMusteri
        '
        Me.colMusteri.Caption = "Musteri"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Fiþ Tarihi"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 3
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 4
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Visible = True
        Me.colnGirisCikis.VisibleIndex = 5
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 6
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.Visible = True
        Me.colsDepo.VisibleIndex = 7
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "KasiyerRumuzu"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Visible = True
        Me.colsKasiyerRumuzu.VisibleIndex = 8
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "ISTIHBARAT"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        '
        'colsAlisVerisYapanAdi
        '
        Me.colsAlisVerisYapanAdi.Caption = "A.Adi"
        Me.colsAlisVerisYapanAdi.FieldName = "sAlisVerisYapanAdi"
        Me.colsAlisVerisYapanAdi.Name = "colsAlisVerisYapanAdi"
        Me.colsAlisVerisYapanAdi.Visible = True
        Me.colsAlisVerisYapanAdi.VisibleIndex = 11
        '
        'colsAlisVerisYapanSoyadi
        '
        Me.colsAlisVerisYapanSoyadi.Caption = "A.Soyadi"
        Me.colsAlisVerisYapanSoyadi.FieldName = "sAlisVerisYapanSoyadi"
        Me.colsAlisVerisYapanSoyadi.Name = "colsAlisVerisYapanSoyadi"
        Me.colsAlisVerisYapanSoyadi.Visible = True
        Me.colsAlisVerisYapanSoyadi.VisibleIndex = 12
        '
        'colsAdres1
        '
        Me.colsAdres1.Caption = "Adres1"
        Me.colsAdres1.FieldName = "sAdres1"
        Me.colsAdres1.Name = "colsAdres1"
        '
        'colsAdres2
        '
        Me.colsAdres2.Caption = "Adres2"
        Me.colsAdres2.FieldName = "sAdres2"
        Me.colsAdres2.Name = "colsAdres2"
        '
        'colsVergiDairesi
        '
        Me.colsVergiDairesi.Caption = "VergiDairesi"
        Me.colsVergiDairesi.FieldName = "sVergiDairesi"
        Me.colsVergiDairesi.Name = "colsVergiDairesi"
        '
        'colsVergiNo
        '
        Me.colsVergiNo.Caption = "VergiNo"
        Me.colsVergiNo.FieldName = "sVergiNo"
        Me.colsVergiNo.Name = "colsVergiNo"
        '
        'colsNot
        '
        Me.colsNot.Caption = "Not"
        Me.colsNot.FieldName = "sAciklama"
        Me.colsNot.Name = "colsNot"
        '
        'colsMuhasebeFaturalasma
        '
        Me.colsMuhasebeFaturalasma.Caption = "Muh.Durum"
        Me.colsMuhasebeFaturalasma.FieldName = "sMuhasebeFaturalasma"
        Me.colsMuhasebeFaturalasma.Name = "colsMuhasebeFaturalasma"
        Me.colsMuhasebeFaturalasma.Visible = True
        Me.colsMuhasebeFaturalasma.VisibleIndex = 13
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Entegrasyon listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Perakende Entegrasyon", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_perakende_entegre
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 574)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_perakende_entegre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entegrasyon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_toplu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.sec_bMusteriAdresi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nGirisCikis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeKodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public connection_resmi
    Public connection_orj
    Public connection_resmi1
    Public kullanici
    Dim sKasiyerRumuzu As String = ""
    Dim sKasiyer As String = ""
    Dim sMagaza As String = ""
    Dim nMusteriID As Int64 = 0
    Dim lKodu As String = 0
    Dim sAdi As String = ""
    Dim sSoyadi As String = ""
    Dim sAdres1 As String = ""
    Dim sAdres2 As String = ""
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Dim ds_tbMusteri As DataSet
    Dim ds_tbMusteriNufusu As DataSet
    Dim ds_tbStok As DataSet
    Dim dr_baslik As DataRow
    Dim dr_Musteri As DataRow
    Dim dr_hareket As DataRow
    Dim ds_hareket As DataSet
    Dim ds_stok As DataSet
    Dim ds_stok_fisi As DataSet
    Dim ds_stok_barkod As DataSet
    Dim ds_stok_sinif As DataSet
    Dim ds_renk As DataSet
    Dim kasiyerno As String = ""
    Private Sub frm_perakende_entegre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_orj = connection
        If bPerYerelMuh = True Then
            connection_resmi = connection
            SimpleButton3.Enabled = False
        Else
            connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        End If
        DateEdit1.EditValue = sorgu_tarih_kontrol()
        DateEdit2.EditValue = dteSistemTarihi
        DateEdit3.EditValue = dteSistemTarihi
        dataload_kasa()
        dataload_kasiyer()
        dataload_depo()
        dataload_satici()
        dataload_odemekodu()
    End Sub
    Public Function sorgu_tarih_kontrol() As DateTime
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select convert(char(10), getdate() , 104)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_kasa()
        sec_kasa.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nKasaNo,sAciklama  FROM         tbParekendeKasa ")).Tables(0)
        sec_kasa.ItemIndex = 0
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_depo()
        sec_magaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
        sec_magaza.ItemIndex = 0
    End Sub
    Private Sub dataload_satici()
        sec_sSatici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici  FROM         tbSatici where (bAktif = 1)")).Tables(0)
    End Sub
    Private Sub dataload_odemekodu(Optional ByVal sFiyatTipi As String = "PS")
        sec_sOdemeKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbFiyatTipiOdemePlani.sOdemeKodu, tbOdemePlani.sAciklama FROM         tbFiyatTipiOdemePlani INNER JOIN                       tbOdemePlani ON tbFiyatTipiOdemePlani.sOdemeKodu = tbOdemePlani.sOdemeKodu WHERE     (tbFiyatTipiOdemePlani.sFiyatTipi = '" & sFiyatTipi & "') ORDER BY cast(tbFiyatTipiOdemePlani.sOdemeKodu as integer) ")).Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub sorgu_toplu(ByVal query As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(ds_hareket.Tables(0))
        con.Close()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasiyerno As String, ByVal musterikodu As String, ByVal belgeno As String, ByVal sDepo As String, ByVal sFisTipi As String)
        Dim kriter_musteri = ""
        Dim kriter_belgeno = ""
        Dim kasiyer_satis = ""
        Dim kasiyer_odeme = ""
        Dim kriter As String = ""
        Dim kriter_siparis As String = ""
        kriter += " WHERE (tbStokFisiDetayi.sFisTipi IN ('K', 'P', 'PF')) AND tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' "
        kriter_siparis += " WHERE (tbAlisVeris.sFisTipi IN ('SK','SP')) AND tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' "
        If Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "VC" Then
        Else
            kasiyer_satis = " AND tbAlisVeris.sKasiyerRumuzu ='" & kasiyerno & "' "
            kasiyer_odeme = " AND tbOdeme.sKasiyerRumuzu ='" & kasiyerno & "' "
        End If
        If musterikodu <> "" Then
            kriter += " AND tbMusteri.lKodu = '" & Trim(musterikodu) & "' "
            kriter_siparis += " AND tbMusteri.lKodu = '" & Trim(musterikodu) & "' "
        End If
        If Trim(belgeno) <> "" Then
            kriter += " AND tbStokFisiDetayi.lFisNo = '" & Trim(belgeno) & "' "
            kriter_siparis += " AND tbAlisVeris.lFaturaNo = '" & Trim(belgeno) & "' "
        End If
        If Trim(sDepo) <> "" Then
            If Trim(sDepo) <> "[Tümü]" Then
                kriter += " AND tbStokFisiDetayi.sDepo = '" & sDepo & "' "
                kriter_siparis += " AND tbAlisVeris.sMagaza = '" & sDepo & "' "
            End If
        End If
        If Trim(sFisTipi) <> "" Then
            If Trim(sFisTipi) <> "[Tümü]" Then
                kriter += " AND tbStokFisiDetayi.sFisTipi = '" & sFisTipi & "' "
                kriter_siparis += " AND tbAlisVeris.sFisTipi = '" & sFisTipi & "' "
            End If
        End If
        'ds_baslik = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lCikisMiktar1) AS lMiktar, SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT,tbMusteri.sEvAdresi1 as sAdres1,tbMusteri.sEvAdresi2 as sAdres2,tbMusteri.sVergiDairesi,tbMusteri.sVergiNo FROM tbStokFisiDetayi INNER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID " & kriter & " GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5,tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2, tbMusteri.sVergiDairesi,tbMusteri.sVergiNo,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu ORDER BY tbStokFisiDetayi.dteFisTarihi"))
        'ds_baslik = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lCikisMiktar1) AS lMiktar, SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteri.sEvAdresi1 AS sAdres1, tbMusteri.sEvAdresi2 AS sAdres2, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo FROM tbAlisVerisAdres RIGHT OUTER JOIN                       tbAlisVeris ON tbAlisVerisAdres.nAlisVerisID = tbAlisVeris.nAlisverisID RIGHT OUTER JOIN                       tbStokFisiDetayi INNER JOIN                       tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID " & kriter & " GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu UNION ALL SELECT tbAlisVeris.lToplamMiktar AS lMiktar, tbAlisVeris.lNetTutar AS lNetTutar, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbAlisVeris.dteFaturaTarihi AS dteFisTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo AS lFisNo, tbAlisVeris.nGirisCikis, tbAlisVeris.sMagaza AS sDepo, tbAlisVeris.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteri.sEvAdresi1 AS sAdres1, tbMusteri.sEvAdresi2 AS sAdres2, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN                       tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter_siparis & " ORDER BY dteFisTarihi"))
        If sec_sFisTipi.SelectedIndex = 0 Then
            ds_baslik = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lCikisMiktar1) AS lMiktar, SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar, tbStokFisiDetayi.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo, ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma FROM tbAlisVerisAdres RIGHT OUTER JOIN                       tbAlisVeris ON tbAlisVerisAdres.nAlisVerisID = tbAlisVeris.nAlisverisID RIGHT OUTER JOIN                       tbStokFisiDetayi INNER JOIN                       tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID " & kriter & " GROUP BY tbStokFisiDetayi.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo, tbAlisVeris.sMuhasebeFaturalasma, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu UNION ALL SELECT tbAlisVeris.lToplamMiktar AS lMiktar, tbAlisVeris.lNetTutar AS lNetTutar, tbAlisVeris.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbAlisVeris.dteFaturaTarihi AS dteFisTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo AS lFisNo, tbAlisVeris.nGirisCikis, tbAlisVeris.sMagaza AS sDepo, tbAlisVeris.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt,tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo, ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN                       tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter_siparis & " ORDER BY dteFisTarihi"))
        ElseIf sec_sFisTipi.SelectedIndex = 1 Then
            ds_baslik = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lCikisMiktar1) AS lMiktar, SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar, tbStokFisiDetayi.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo, ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma FROM tbAlisVerisAdres RIGHT OUTER JOIN                       tbAlisVeris ON tbAlisVerisAdres.nAlisVerisID = tbAlisVeris.nAlisverisID RIGHT OUTER JOIN                       tbStokFisiDetayi INNER JOIN                       tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID " & kriter & " GROUP BY tbStokFisiDetayi.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo, tbAlisVeris.sMuhasebeFaturalasma, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu  ORDER BY dteFisTarihi"))
        ElseIf sec_sFisTipi.SelectedIndex = 2 Then
            ds_baslik = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.lToplamMiktar AS lMiktar, tbAlisVeris.lNetTutar AS lNetTutar, tbAlisVeris.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbAlisVeris.dteFaturaTarihi AS dteFisTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo AS lFisNo, tbAlisVeris.nGirisCikis, tbAlisVeris.sMagaza AS sDepo, tbAlisVeris.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt,tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo, ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN                       tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter_siparis & " ORDER BY dteFisTarihi"))
        End If
        'ds_baslik = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lCikisMiktar1) AS lMiktar, SUM(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lNetTutar, tbStokFisiDetayi.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo FROM tbAlisVerisAdres RIGHT OUTER JOIN                       tbAlisVeris ON tbAlisVerisAdres.nAlisVerisID = tbAlisVeris.nAlisverisID RIGHT OUTER JOIN                       tbStokFisiDetayi INNER JOIN                       tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID " & kriter & " GROUP BY tbStokFisiDetayi.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sKasiyerRumuzu UNION ALL SELECT tbAlisVeris.lToplamMiktar AS lMiktar, tbAlisVeris.lNetTutar AS lNetTutar, tbAlisVeris.nAlisVerisID,tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbAlisVeris.sAlisverisYapanAdi,tbAlisVeris.sAlisverisYapanSoyadi,tbAlisVeris.dteFaturaTarihi AS dteFisTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo AS lFisNo, tbAlisVeris.nGirisCikis, tbAlisVeris.sMagaza AS sDepo, tbAlisVeris.sKasiyerRumuzu, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sVergiDairesi,tbAlisVerisAdres.sSemt,tbAlisVerisAdres.sIl,tbAlisVerisAdres.sVergiNo FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN                       tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter_siparis & " ORDER BY dteFisTarihi"))
        GridControl1.DataSource = ds_baslik.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub dataload_hareket(ByVal tarih As DateTime, ByVal nMusteriID As String, ByVal sFisTipi As String, ByVal lFisNo As String)
        Dim kriter_musteri = ""
        Dim kriter_belgeno = ""
        Dim kasiyer_satis = ""
        Dim kasiyer_odeme = ""
        Dim kriter As String = ""
        Dim kriter_siparis As String = ""
        kriter += " WHERE (tbStokFisiDetayi.nMusteriID = '" & nMusteriID & "') AND (tbStokFisiDetayi.sFisTipi = '" & sFisTipi & "') AND (tbStokFisiDetayi.dteFisTarihi = '" & tarih & "') and (tbStokFisiDetayi.lFisNo= '" & lFisNo & "') "
        kriter_siparis += " WHERE (tbAlisVeris.nMusteriID = '" & nMusteriID & "') AND (tbAlisVeris.sFisTipi = '" & sFisTipi & "') AND (tbAlisVeris.dteFaturaTarihi = '" & tarih & "') and (tbAlisVeris.lFaturaNo= '" & lFisNo & "') "
        If GridView1.SelectedRowsCount = 1 Then
            ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
            'sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
            sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.nSiparisID AS nIslemID, tbAlisverisSiparis.nStokID, tbAlisVeris.dteFaturaTarihi AS dteIslemTarihi, 0 AS nFirmaID, tbAlisVeris.nMusteriID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi AS dteFisTarihi, tbAlisVeris.lFaturaNo AS lFisNo, tbAlisVeris.nGirisCikis, tbAlisVeris.sMagaza AS sDepo, 0 AS lReyonFisNo, tbAlisVeris.sFisTipi AS sStokIslem, tbAlisVeris.sKasiyerRumuzu, tbAlisverisSiparis.sSaticiRumuzu, tbAlisverisSiparis.sOdemeKodu, tbAlisVeris.dteFaturaTarihi AS dteIrsaliyeTarihi, 0 AS lIrsaliyeNo, 0 AS lGirisMiktar1, 0 AS lGirisMiktar2, 0 AS lGirisFiyat, 0 AS lGirisTutar, tbAlisverisSiparis.lGCMiktar AS lCikisMiktar1, 0 AS lCikisMiktar2, tbAlisverisSiparis.lFiyat AS lCikisFiyat, tbAlisverisSiparis.lTutar AS lCikisTutar, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar, 0 AS lMaliyetFiyat, 0 AS lMaliyetTutar, 0 AS lIlaveMaliyetTutar, tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari, tbAlisverisSiparis.sDovizCinsi1 AS sDovizCinsi, tbAlisverisSiparis.lDovizMiktari1 AS lDovizFiyat, 0 AS nSiparisID, 0 AS nReceteNo, 0 AS nTransferID, '' AS sTransferDepo, tbAlisverisSiparis.nKdvOrani, 0 AS nHesapID, '' AS sAciklama, '' AS sHareketTipi, 0 AS bMuhasebeyeIslendimi, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisverisSiparis.sDovizCinsi1, tbAlisverisSiparis.lDovizMiktari1, tbAlisverisSiparis.lDovizKuru1, tbAlisverisSiparis.sDovizCinsi1 AS sDovizCinsi2, tbAlisverisSiparis.lDovizMiktari1 AS lDovizMiktari2, tbAlisverisSiparis.lDovizKuru1 AS lDovizKuru2, 0 AS nOtvOrani, 0 AS nTransferFirmaID, tbAlisverisSiparis.nAlisverisID, 0 AS nStokFisiID, 0 AS nIrsaliyeFisiID, '' AS sMasrfaYontemi, '' AS sHangiUygulama, 0 AS nEkSaha1, 0 AS nEkSaha2, 0 AS bEkSoru1, 0 AS bEkSoru2, tbAlisverisSiparis.sSonKullaniciAdi, tbAlisverisSiparis.dteSonUpdateTarihi, '' AS sBirimCinsi, 1 AS lBirimMiktar, 0 AS nPirim, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbStok.sBirimCinsi1, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk, tbStok.sBeden, tbStok.sModel, tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani / 100) AS nKdvTutari FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID " & kriter_siparis & " "))
        ElseIf GridView1.SelectedRowsCount > 1 Then
            sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
            sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.nSiparisID AS nIslemID, tbAlisverisSiparis.nStokID, tbAlisVeris.dteFaturaTarihi AS dteIslemTarihi, 0 AS nFirmaID, tbAlisVeris.nMusteriID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi AS dteFisTarihi, tbAlisVeris.lFaturaNo AS lFisNo, tbAlisVeris.nGirisCikis, tbAlisVeris.sMagaza AS sDepo, 0 AS lReyonFisNo, tbAlisVeris.sFisTipi AS sStokIslem, tbAlisVeris.sKasiyerRumuzu, tbAlisverisSiparis.sSaticiRumuzu, tbAlisverisSiparis.sOdemeKodu, tbAlisVeris.dteFaturaTarihi AS dteIrsaliyeTarihi, 0 AS lIrsaliyeNo, 0 AS lGirisMiktar1, 0 AS lGirisMiktar2, 0 AS lGirisFiyat, 0 AS lGirisTutar, tbAlisverisSiparis.lGCMiktar AS lCikisMiktar1, 0 AS lCikisMiktar2, tbAlisverisSiparis.lFiyat AS lCikisFiyat, tbAlisverisSiparis.lTutar AS lCikisTutar, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar, 0 AS lMaliyetFiyat, 0 AS lMaliyetTutar, 0 AS lIlaveMaliyetTutar, tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari, tbAlisverisSiparis.sDovizCinsi1 AS sDovizCinsi, tbAlisverisSiparis.lDovizMiktari1 AS lDovizFiyat, 0 AS nSiparisID, 0 AS nReceteNo, 0 AS nTransferID, '' AS sTransferDepo, tbAlisverisSiparis.nKdvOrani, 0 AS nHesapID, '' AS sAciklama, '' AS sHareketTipi, 0 AS bMuhasebeyeIslendimi, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisverisSiparis.sDovizCinsi1, tbAlisverisSiparis.lDovizMiktari1, tbAlisverisSiparis.lDovizKuru1, tbAlisverisSiparis.sDovizCinsi1 AS sDovizCinsi2, tbAlisverisSiparis.lDovizMiktari1 AS lDovizMiktari2, tbAlisverisSiparis.lDovizKuru1 AS lDovizKuru2, 0 AS nOtvOrani, 0 AS nTransferFirmaID, tbAlisverisSiparis.nAlisverisID, 0 AS nStokFisiID, 0 AS nIrsaliyeFisiID, '' AS sMasrfaYontemi, '' AS sHangiUygulama, 0 AS nEkSaha1, 0 AS nEkSaha2, 0 AS bEkSoru1, 0 AS bEkSoru2, tbAlisverisSiparis.sSonKullaniciAdi, tbAlisverisSiparis.dteSonUpdateTarihi, '' AS sBirimCinsi, 1 AS lBirimMiktar, 0 AS nPirim, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbStok.sBirimCinsi1, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk, tbStok.sBeden, tbStok.sModel, tbAlisverisSiparis.lTutar * (tbAlisverisSiparis.nKdvOrani / 100) AS nKdvTutari FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID " & kriter_siparis & " "))
        End If
        'If sec_toplu.Checked = True Then
        '    If GridView1.SelectedRowsCount = 1 Then
        '        ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        '    ElseIf GridView1.SelectedRowsCount > 1 Then
        '        sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        '    End If
        'Else
        '    ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        'End If
        GridControl2.DataSource = ds_hareket.Tables(0)
        GridControl2.DataMember = Nothing
        If GridView2.RowCount > 0 Then
            If GridView2.SelectedRowsCount > 1 Then
                Label2.Text = "Hareket Kayýt Sayýsý :" & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView2.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = "Hareket Kayýt Sayýsý :" & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
        End If
        Dim dr1 As DataRow
        For Each dr1 In ds_hareket.Tables(0).Rows
            dr1("lBrutFiyat") = dr1("lCikisFiyat") * ((100 + dr1("nKdvOrani")) / 100)
            dr1("lBrutTutar") = dr1("lBrutFiyat") * dr1("lCikisMiktar1")
        Next
        dr1 = Nothing
    End Sub
    Private Sub dataload_hareket_ler(ByVal tarih As DateTime, ByVal nMusteriID As String, ByVal sFisTipi As String, ByVal lFisNo As String)
        Dim kriter_musteri = ""
        Dim kriter_belgeno = ""
        Dim kasiyer_satis = ""
        Dim kasiyer_odeme = ""
        Dim kriter As String = ""
        kriter += " WHERE (tbStokFisiDetayi.nMusteriID = '" & nMusteriID & "') AND (tbStokFisiDetayi.sFisTipi = '" & sFisTipi & "') AND (tbStokFisiDetayi.dteFisTarihi = '" & tarih & "') and (tbStokFisiDetayi.lFisNo= '" & lFisNo & "') "
        If sec_toplu.Checked = True Then
            If GridView1.SelectedRowsCount = 1 Then
                ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
            ElseIf GridView1.SelectedRowsCount > 1 Then
                sorgu_toplu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
            End If
            'ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        Else
            ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        End If
        'ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sRenk,tbStok.sBeden,tbStok.sModel,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " "))
        GridControl2.DataSource = ds_hareket.Tables(0)
        GridControl2.DataMember = Nothing
        If GridView2.RowCount > 0 Then
            If GridView2.SelectedRowsCount > 1 Then
                Label2.Text = "Hareket Kayýt Sayýsý :" & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView2.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = "Hareket Kayýt Sayýsý :" & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
        End If
        Dim dr1 As DataRow
        For Each dr1 In ds_hareket.Tables(0).Rows
            dr1("lBrutFiyat") = dr1("lCikisFiyat") * ((100 + dr1("nKdvOrani")) / 100)
            dr1("lBrutTutar") = dr1("lBrutFiyat") * dr1("lCikisMiktar1")
        Next
        dr1 = Nothing
    End Sub
    Public Function sorgu_musteri_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nfirmaID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nMusteriID,0) AS nMusteriID FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_tbMusteri(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_tbMusteri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub dataload_tbMusteriNufusu(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (tbMusteri.lKodu = '" & kod & "') "
        ds_tbMusteriNufusu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbMusteriNufusu.* FROM         tbMusteriNufusu INNER JOIN                       tbMusteri ON tbMusteriNufusu.nMusteriID = tbMusteri.nMusteriID " & kriter & ""))
    End Sub
    Private Function tbMusteri_kaydet_yeni(ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteri (sMagaza, lKodu, sAdi, sSoyadi, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsIl, sIsPostaKodu, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, sHitap, sKullaniciAdi, dteKayitTarihi, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sGSM, sFax, sResimAdi) VALUES     ('" & sMagaza & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", " & lAylikGelir & ", '" & dteKartAcilisTarihi & "', " & nIskontoPesin & ", " & nIskontoKredili & ", '" & sUnvan & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bYazismaEvAdresinemi & ", '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsIl & "', '" & sIsPostaKodu & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sSigortaNo & "', " & bEvlimi & ", '" & dteEvlilikTarihi & "', '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sEhliyetNo & "', '" & sKanGrubu & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sGSM & "', '" & sFax & "', '" & sResimAdi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbMusteri_kaydet_duzelt(ByVal nMusteriID As String, ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteri SET              sMagaza = '" & sMagaza & "', lKodu = '" & lKodu & "', sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', nCinsiyet = " & nCinsiyet & ", lAylikGelir = " & lAylikGelir & ", dteKartAcilisTarihi = '" & dteKartAcilisTarihi & "', nIskontoPesin = " & nIskontoPesin & ", nIskontoKredili = " & nIskontoKredili & ", sUnvan = '" & sUnvan & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', bYazismaEvAdresinemi = " & bYazismaEvAdresinemi & ", sEmail = '" & sEmail & "', sIsYeriAdi = '" & sIsYeriAdi & "', sIsAdresi1 = '" & sIsAdresi1 & "', sIsAdresi2 = '" & sIsAdresi2 & "', sIsSemt = '" & sIsSemt & "', sIsIl = '" & sIsIl & "', sIsPostaKodu = '" & sIsPostaKodu & "', sIsTelefonu = '" & sIsTelefonu & "', sEvAdresi1 = '" & sEvAdresi1 & "', sEvAdresi2 = '" & sEvAdresi2 & "', sEvSemt = '" & sEvSemt & "', sEvPostaKodu = '" & sEvPostaKodu & "', sEvIl = '" & sEvIl & "', sEvTelefonu = '" & sEvTelefonu & "', sSigortaNo = '" & sSigortaNo & "', bEvlimi = " & bEvlimi & ", dteEvlilikTarihi = '" & dteEvlilikTarihi & "', dteDogumTarihi = '" & dteDogumTarihi & "', sDogumYeri = '" & sDogumYeri & "', sEhliyetNo = '" & sEhliyetNo & "', sKanGrubu = '" & sKanGrubu & "', sHitap = '" & sHitap & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sGSM = '" & sGSM & "', sFax = '" & sFax & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriNufusu_kaydet_duzelt(ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriNufusu SET              sDin = '" & sDin & "', sKutukIl = '" & sKutukIl & "', sKutukIlce = '" & sKutukIlce & "', sKutukMahalle = '" & sKutukMahalle & "', sKutukCiltNo = '" & sKutukCiltNo & "', sKutukSiraNo = '" & sKutukSiraNo & "', dteNufusCuzdanTarihi = '" & dteNufusCuzdanTarihi & "', sCuzdanVerilenYer = '" & sCuzdanVerilenYer & "', sCuzdanVerNedeni = '" & sCuzdanVerNedeni & "', sCuzdanKayitNo = '" & sCuzdanKayitNo & "', sAnneAdi = '" & sAnneAdi & "', sBabaAdi = '" & sBabaAdi & "', sAileAdresi1 = '" & sAileAdresi1 & "', sAileAdresi2 = '" & sAileAdresi2 & "', sAileSemt = '" & sAileSemt & "', sAilePostaKodu = '" & sAilePostaKodu & "', sAileIl = '" & sAileIl & "', sAileTelefonu = '" & sAileTelefonu & "', sHitapAnne = '" & sHitapAnne & "', sHitapBaba = '" & sHitapBaba & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriSinifi_kaydet_yeni(ByVal nMusteriID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriSinifi (nMusteriID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nMusteriID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriNufusu_kaydet_yeni(ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriNufusu (nMusteriID, sDin, sKutukIl, sKutukIlce, sKutukMahalle, sKutukCiltNo, sKutukSiraNo, dteNufusCuzdanTarihi, sCuzdanVerilenYer, sCuzdanVerNedeni, sCuzdanKayitNo, sAnneAdi, sBabaAdi, sAileAdresi1, sAileAdresi2, sAileSemt, sAilePostaKodu, sAileIl, sAileTelefonu, sHitapAnne, sHitapBaba) VALUES     ('" & nMusteriID & "', '" & sDin & "', '" & sKutukIl & "', '" & sKutukIlce & "', '" & sKutukMahalle & "', '" & sKutukCiltNo & "', '" & sKutukSiraNo & "', '" & dteNufusCuzdanTarihi & "','" & sCuzdanVerilenYer & "', '" & sCuzdanVerNedeni & "', '" & sCuzdanKayitNo & "', '" & sAnneAdi & "', '" & sBabaAdi & "', '" & sAileAdresi1 & "', '" & sAileAdresi2 & "', '" & sAileSemt & "', '" & sAilePostaKodu & "', '" & sAileIl & "', '" & sAileTelefonu & "', '" & sHitapAnne & "', '" & sHitapBaba & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nStokID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub dataload_stok_barkod(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_barkod = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokBarkodu " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokSinifi " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif1(ByVal sStokSinifi As String, ByVal sinifno As Integer)
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sStokSinifi & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM          tbSSinif" & sinifno & " " & kriter & ""))
    End Sub
    Private Sub dataload_sRenk(ByVal sRenk As String)
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "') "
        ds_renk = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbRenk " & kriter & ""))
    End Sub
    Public Function sorgu_Renk_kontrol(ByVal sRenk As String) As Int64
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbRenk " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_Sinif_kontrol(ByVal sSinifKodu As String, ByVal sinifno As Integer) As Int64
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM          tbSSinif" & sinifno & " " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function stok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStok                       (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', '" & nStokTipi & "', '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi2 & "', " & nIskontoYuzdesi & " , '" & sKdvTipi & "', " & nTeminSuresi & " , " & lAsgariMiktar & " , " & lAzamiMiktar & " , '" & sOzelNot & "', '" & nFiyatlandirma & "', '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & " , '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & " , " & bOTVVar & " , '" & sOTVTipi & "' , '" & nIskontoYuzdesiAV & "', '" & bEk1 & "', '" & nEk2 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub stok_renk_kaydet_yeni(ByVal sRenk As String, ByVal sRenkAdi As String, ByVal lRenkNo As String)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbRenk                       (sRenk, sRenkAdi, lRenkNo) VALUES     ('" & sRenk & "', '" & sRenkAdi & "', '" & lRenkNo & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_sinif_kaydet_yeni(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSSinif" & sinifno & "                       (sSinifKodu, sAciklama) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_barkod_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As String, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu                       (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     ('" & nStokID & "', '" & sBarkod & "', '" & nKisim & "', '" & nFirmaID & "', '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_siniflari_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi                       (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     ('" & nStokID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "', '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kasiyer_kod.Text Then
                kasiyerno = dr("IND")
                sKasiyerRumuzu = dr("IND")
                sKasiyer = dr("KASIYER")
                sMagaza = dr("DEPO")
                sonuc = True
            End If
        Next
        DateEdit1.Properties.ReadOnly = True
        DateEdit2.Properties.ReadOnly = True
        DateEdit3.Properties.ReadOnly = True
        SimpleButton5.Enabled = False
        If Trim(kasiyerno) = "VC" Or Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Then
            DateEdit1.Properties.ReadOnly = False
            DateEdit2.Properties.ReadOnly = False
            DateEdit3.Properties.ReadOnly = False
            SimpleButton5.Enabled = True
        End If
        If sonuc = True Then
            lbl_kasiyer.Text = sKasiyer
            sec_magaza.EditValue = sMagaza
            txt_kasiyer_kod.Enabled = False
            GridControl1.Focus()
            GridControl1.Select()
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf sonuc = False Then
            lbl_kasiyer.Text = ""
            txt_kasiyer_kod.Enabled = True
            txt_kasiyer_kod.EditValue = ""
            If XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nMusteriID = dr1("nMusteriID")
            lKodu = dr1("lKodu")
            txt_musterino.EditValue = lKodu
        End If
    End Sub
    Private Sub musteri_toplu_kontrol()
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nMusteriID As String = ""
        Dim s As String
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                If dr("nMusteriID").ToString <> nMusteriID.ToString Then
                    lKodu = dr("nMusteriID").ToString
                    sayi += 1
                End If
            Next
        End If
        If sayi = 1 Then
            sec_toplu.Checked = False
        ElseIf sayi > 1 Then
            sec_toplu.Checked = True
        End If
        'If sayi = 1 Then
        '    If sec_sFisTipi.EditValue = "IA" Or sec_sFisTipi.EditValue = "IS" Then
        '        MenuItem13.Visible = True
        '        MenuItem13.Enabled = True
        '    End If
        'Else
        '    MenuItem13.Visible = False
        '    MenuItem13.Enabled = False
        'End If
    End Sub
    Private Sub txt_kasiyer_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kasiyer_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        stok_satis_detay()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        'If GridView1.RowCount > 0 Then
        '    dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    dataload_hareket(dr_baslik("dteFisTarihi"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("lFisNo"))
        '    lbl_istihbarat.Text = dr_baslik("ISTIHBARAT").ToString
        '    If GridView1.SelectedRowsCount > 1 Then
        '        Label5.Text = "Belge Kayýt Sayýsý :" & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        '    ElseIf GridView1.SelectedRowsCount = 1 Then
        '        Label5.Text = "Belge Kayýt Sayýsý :" & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        '    Else
        '        Label5.Text = ""
        '    End If
        'End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        dataload(DateEdit2.EditValue, DateEdit3.EditValue, kullanici, txt_musterino.EditValue, txt_belgeno.EditValue, sec_depo.EditValue, sec_fistipi.Text)
        Try
            If GridView1.RowCount > 0 Then
                dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dataload_hareket(dr_baslik("dteFisTarihi"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("lFisNo"))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount > 0 Then
            If GridView2.SelectedRowsCount > 1 Then
                Label2.Text = "Hareket Kayýt Sayýsý :" & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView2.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = "Hareket Kayýt Sayýsý :" & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If XtraMessageBox.Show(Sorgu_sDil("Faturalama Ýþlemine Baþlamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim nStokID As Int64 = 0
            Dim nMusteriID As Int64 = 0
            Dim nAlisVerisID As String = ""
            Dim nIslemID As Int64 = 0
            Dim nHareketID As Int64 = 0
            Dim musteri_kayit_sayisi As Int64 = 0
            Dim stok_kayit_sayisi As Int64 = 0
            musteri_kayit_sayisi = sorgu_musteri_kontrol(dr_baslik("lKodu"))
            If musteri_kayit_sayisi = 0 Then
                dataload_tbMusteri(dr_baslik("lKodu"))
                dataload_tbMusteriNufusu(dr_baslik("lKodu"))
                dr_Musteri = ds_tbMusteri.Tables(0).Rows(0)
                nMusteriID = tbMusteri_kaydet_yeni(dr_Musteri("sMagaza"), dr_Musteri("lKodu"), dr_Musteri("sAdi"), dr_Musteri("sSoyadi"), dr_Musteri("nCinsiyet"), dr_Musteri("lAylikGelir"), dr_Musteri("dteKartAcilisTarihi"), dr_Musteri("nIskontoPesin"), dr_Musteri("nIskontoKredili"), dr_Musteri("sUnvan"), dr_Musteri("sVergiDairesi"), dr_Musteri("sVergiNo"), dr_Musteri("bYazismaEvAdresinemi"), dr_Musteri("sEmail"), dr_Musteri("sIsYeriAdi"), dr_Musteri("sIsAdresi1"), dr_Musteri("sIsAdresi2"), dr_Musteri("sIsSemt"), dr_Musteri("sIsIl"), dr_Musteri("sIsPostaKodu"), dr_Musteri("sIsTelefonu"), dr_Musteri("sEvAdresi1"), dr_Musteri("sEvAdresi2"), dr_Musteri("sEvSemt"), dr_Musteri("sEvPostaKodu"), dr_Musteri("sEvIl"), dr_Musteri("sEvTelefonu"), dr_Musteri("sSigortaNo"), dr_Musteri("bEvlimi"), dr_Musteri("dteEvlilikTarihi"), dr_Musteri("dteDogumTarihi"), dr_Musteri("sDogumYeri"), dr_Musteri("sEhliyetNo"), dr_Musteri("sKanGrubu"), dr_Musteri("sHitap"), dr_Musteri("sKullaniciAdi"), dr_Musteri("dteKayitTarihi"), dr_Musteri("sAciklama1"), dr_Musteri("sAciklama2"), dr_Musteri("sAciklama3"), dr_Musteri("sAciklama4"), dr_Musteri("sAciklama5"), dr_Musteri("sGSM"), dr_Musteri("sFax"), dr_Musteri("sResimAdi"))
                tbMusteriSinifi_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                Dim drn As DataRow
                For Each drn In ds_tbMusteriNufusu.Tables(0).Rows
                    tbMusteriNufusu_kaydet_yeni(nMusteriID, drn("sDin"), drn("sKutukIl"), drn("sKutukIlce"), drn("sKutukMahalle"), drn("sKutukCiltNo"), drn("sKutukSiraNo"), drn("dteNufusCuzdanTarihi"), drn("sCuzdanVerilenYer"), drn("sCuzdanVerNedeni"), drn("sCuzdanKayitNo"), drn("sAnneAdi"), drn("sBabaAdi"), drn("sAileAdresi1"), drn("sAileAdresi2"), drn("sAileSemt"), drn("sAilePostaKodu"), drn("sAileIl"), drn("sAileTelefonu"), drn("sHitapAnne"), drn("sHitapBaba"))
                Next
                drn = Nothing
            ElseIf musteri_kayit_sayisi = 1 Then
                nMusteriID = sorgu_nfirmaID(dr_baslik("lKodu"))
                dataload_tbMusteri(dr_baslik("lKodu"))
                dataload_tbMusteriNufusu(dr_baslik("lKodu"))
                dr_Musteri = ds_tbMusteri.Tables(0).Rows(0)
                tbMusteri_kaydet_duzelt(nMusteriID, dr_Musteri("sMagaza"), dr_Musteri("lKodu"), dr_Musteri("sAdi"), dr_Musteri("sSoyadi"), dr_Musteri("nCinsiyet"), dr_Musteri("lAylikGelir"), dr_Musteri("dteKartAcilisTarihi"), dr_Musteri("nIskontoPesin"), dr_Musteri("nIskontoKredili"), dr_Musteri("sUnvan"), dr_Musteri("sVergiDairesi"), dr_Musteri("sVergiNo"), dr_Musteri("bYazismaEvAdresinemi"), dr_Musteri("sEmail"), dr_Musteri("sIsYeriAdi"), dr_Musteri("sIsAdresi1"), dr_Musteri("sIsAdresi2"), dr_Musteri("sIsSemt"), dr_Musteri("sIsIl"), dr_Musteri("sIsPostaKodu"), dr_Musteri("sIsTelefonu"), dr_Musteri("sEvAdresi1"), dr_Musteri("sEvAdresi2"), dr_Musteri("sEvSemt"), dr_Musteri("sEvPostaKodu"), dr_Musteri("sEvIl"), dr_Musteri("sEvTelefonu"), dr_Musteri("sSigortaNo"), dr_Musteri("bEvlimi"), dr_Musteri("dteEvlilikTarihi"), dr_Musteri("dteDogumTarihi"), dr_Musteri("sDogumYeri"), dr_Musteri("sEhliyetNo"), dr_Musteri("sKanGrubu"), dr_Musteri("sHitap"), dr_Musteri("sKullaniciAdi"), dr_Musteri("dteKayitTarihi"), dr_Musteri("sAciklama1"), dr_Musteri("sAciklama2"), dr_Musteri("sAciklama3"), dr_Musteri("sAciklama4"), dr_Musteri("sAciklama5"), dr_Musteri("sGSM"), dr_Musteri("sFax"), dr_Musteri("sResimAdi"))
                Dim drn As DataRow
                For Each drn In ds_tbMusteriNufusu.Tables(0).Rows
                    tbMusteriNufusu_kaydet_duzelt(nMusteriID, drn("sDin"), drn("sKutukIl"), drn("sKutukIlce"), drn("sKutukMahalle"), drn("sKutukCiltNo"), drn("sKutukSiraNo"), drn("dteNufusCuzdanTarihi"), drn("sCuzdanVerilenYer"), drn("sCuzdanVerNedeni"), drn("sCuzdanKayitNo"), drn("sAnneAdi"), drn("sBabaAdi"), drn("sAileAdresi1"), drn("sAileAdresi2"), drn("sAileSemt"), drn("sAilePostaKodu"), drn("sAileIl"), drn("sAileTelefonu"), drn("sHitapAnne"), drn("sHitapBaba"))
                Next
            End If
            tbKasiyer_kontrol()
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr_stok As DataRow
            'Dim dr_stok_barkod As DataRow
            Dim barkod_var As Boolean = False
            Dim dr_stok_sinif As DataRow
            Dim dr_renk As DataRow
            Dim dr_stok_sinifi As DataRow
            Dim renk_kayit_sayisi As Int64 = 0
            Dim sinif_kayit_sayisi As Int64 = 0
            arr = GridView2.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView2.GetDataRow(s)
                    stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr("sKodu")))
                    If stok_kayit_sayisi = 0 Then
                        'MsgBox(dr("sKodu") & " Kodlu Stok Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
                        'Stok Bilgini Çek
                        dataload_stok(dr("sKodu"))
                        'Stok Barkod Bilgisini Çek
                        dataload_stok_barkod(dr("nStokID"))
                        Dim dr_stok_barkod As DataRow
                        If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                            barkod_var = True
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        Else
                            barkod_var = False
                        End If
                        'Sýnýf Bilgisini Çek
                        dataload_stok_sinif(dr("nStokID"))
                        'datarowa yükle
                        dr_stok = ds_stok.Tables(0).Rows(0)
                        'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                        renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                        If renk_kayit_sayisi = 0 Then
                            dataload_sRenk(dr_stok("sRenk"))
                            dr_renk = ds_renk.Tables(0).Rows(0)
                            stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                        End If
                        'Sýnýf Kayýtlarýný Kontrol Et
                        For ý As Integer = 1 To 15
                            'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                            sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ý & ""), ý)
                            If sinif_kayit_sayisi = 0 Then
                                dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ý & ""), ý)
                                dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                                stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ý)
                            End If
                        Next
                        'Stoðu Kaydet
                        nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                        'barkodu kaydet
                        If barkod_var = True Then
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                        End If
                        'sýnýflarý kaydet
                        stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                    Else
                        nStokID = sorgu_nStokID(Trim(dr("sKodu")))
                    End If
                Next
            End If
            Faturala()
        End If
    End Sub
    Private Sub tbKasiyer_kontrol()
        Dim ds_tbkasiyer As DataSet = sorgu(sorgu_query("Select * from tbKasiyer"))
        Dim dr As DataRow
        For Each dr In ds_tbkasiyer.Tables(0).Rows
            If sorgu_sKasiyerRumuzu_kontrol(dr("sKasiyerRumuzu")) = True Then
                Try
                    tbKasiyer_kaydet_yeni(dr("sKasiyerRumuzu"), dr("sAdi"), dr("sSoyadi"), dr("sSifresi"), dr("sDepo"), dr("bIptalYapabilirmi"), dr("bVadeFarksizOdemeAlirmi"), dr("nMaxIskontoYuzdesi"))
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub
    Private Sub tbKasiyer_kaydet_yeni(ByVal sKasiyerRumuzu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sSifresi As String, ByVal sDepo As String, ByVal bIptalYapabilirmi As Byte, ByVal bVadeFarksizOdemeAlirmi As Byte, ByVal nMaxIskontoYuzdesi As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKasiyer (sKasiyerRumuzu, sAdi, sSoyadi, sSifresi, sDepo, bIptalYapabilirmi, bVadeFarksizOdemeAlirmi, nMaxIskontoYuzdesi) VALUES('" & sKasiyerRumuzu & "', '" & sAdi & "', '" & sSoyadi & "', '" & sSifresi & "', '" & sDepo & "', " & bIptalYapabilirmi & ", " & bVadeFarksizOdemeAlirmi & ", " & nMaxIskontoYuzdesi & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sKasiyerRumuzu_kontrol(ByVal sKasiyerRumuzu As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKasiyerRumuzu), 0) AS nKayit FROM         tbKasiyer WHERE     (sKasiyerRumuzu = '" & sKasiyerRumuzu & "')  ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub Faturala()
        sorgula_Decimal("DELETE FROM tbAlisVerisAdres WHERE (nAlisVerisID NOT IN (SELECT nAlisVerisID FROM tbAlisVeris))")
        dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim nAlisVerisID As String = ""
        Dim sFisTipi = "P"
        Dim dteFisTarihi = DateEdit1.EditValue
        Dim lFaturaNo = 0
        Dim nMusteriID = 0
        Dim sAdi = dr_baslik("sAlisverisYapanAdi").ToString
        Dim sSoyadi = dr_baslik("sAlisverisYapanSoyadi").ToString
        Dim sVergiDairesi As String = dr_baslik("sVergiDairesi").ToString
        Dim sVergiNo As String = dr_baslik("sVergiNo").ToString
        Dim sMagaza = sec_magaza.EditValue
        'Dim sKasiyerRumuzu = sKasiyerRumuzu
        'Dim sKasiyer = sKasiyer
        Dim sHareketTipi = ""
        Dim nKasaNo = sec_kasa.EditValue
        Dim sAdresAciklama As String = dr_baslik("sAciklama").ToString
        Dim sAdres1 As String = dr_baslik("sAdres1").ToString
        Dim sAdres2 As String = dr_baslik("sAdres2").ToString
        Dim sIl As String = dr_baslik("sIl").ToString
        Dim sSemt As String = dr_baslik("sSemt").ToString
        nMusteriID = sorgu_nfirmaID(dr_baslik("lKodu"))
        If Trim(sAdres1) = "" Or sec_bMusteriAdresi.Checked = True Then
            Dim ds_musteri As DataSet = sorgu(sorgu_query("Select * from tbMusteri Where lKodu = " & dr_baslik("lKodu") & " "))
            Dim dr3 As DataRow = ds_musteri.Tables(0).Rows(0)
            sAdres1 = dr3("sEvAdresi1").ToString
            sAdres2 = dr3("sEvAdresi2").ToString
            sVergiDairesi = dr3("sVergiDairesi").ToString
            sVergiNo = dr3("sVergiNo").ToString
            sIl = dr3("sEvIl").ToString
            sSemt = dr3("sEvSemt").ToString
            dr3 = Nothing
            ds_musteri = Nothing
        End If
        If nAlisVerisID = "" Then
            nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
            lFaturaNo = sorgu_lFaturaNo(sMagaza)
            sHareketTipi = sorgu_sHareketTipi(sMagaza)
            tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAdi, sSoyadi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, sHareketTipi, 0, nKasaNo, kullanici, Now, "")
            tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
            lFaturaNo_degistir(lFaturaNo, sMagaza)
            nAlisVerisID = sMagaza & nAlisVerisID.ToString
            Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
            If kayitsayisi = 0 Then
                tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, sAdresAciklama, sAdres1, sAdres2, sSemt, sIl, "", "", sVergiDairesi, sVergiNo, "")
            End If
        End If
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim dr As DataRow
        arr = GridView2.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView2.GetDataRow(s)
                Dim nIslemID As Int64 = sorgu_nStokIslemID()
                Dim nStokID As Int64 = 0
                nStokID = sorgu_nStokID(Trim(dr("sKodu")))
                nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, dr("nGirisCikis"), sMagaza, dr("lReyonFisNo").ToString, sFisTipi, dr("sKasiyerRumuzu").ToString, dr("sSaticiRumuzu").ToString, dr("sOdemeKodu").ToString, dteFisTarihi, dr("lIrsaliyeNo").ToString, dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi").ToString, dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi").ToString, dr("lDovizFiyat"), "", dr("nReceteNo").ToString, "", "", dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama").ToString, dr("sHareketTipi").ToString, dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi").ToString, Now, dr("sDovizCinsi1").ToString, dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2").ToString, dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), "", nAlisVerisID, 0, "", dr("sMasrafYontemi").ToString, dr("sHangiUygulama").ToString, dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi").ToString, Now)
                'tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, dr("nGirisCikis"), sMagaza, dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dteFisTarihi, dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lCikisFiyat") * ((100 + dr("nKdvOrani")) / 100), dr("lCikisTutar") * ((100 + dr("nKdvOrani")) / 100), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), "", dr("nReceteNo"), "", "", dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), Now, dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), "", nAlisVerisID, 0, "", dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), Now)
                fis_detay_fisno_degistir(nIslemID)
            Next
        End If
        Try
            fatura_detay(nAlisVerisID, sFisTipi)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub fatura_detay(ByVal nAlisVerisID As String, ByVal sFisTipi As String)
        Dim frm As New frm_Perakende_Satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection_resmi
        frm.islemstatus = True
        frm.aktarim = True
        frm.nAlisVerisID = nAlisVerisID
        frm.sFisTipi = Trim(sFisTipi.ToString)
        frm.kullanici = kullanici
        frm.sinif2Bakma = True
        frm.perakendeFaturalama = True
        'If yetki_kontrol(kullanici, frm.Name) = True Then
        frm.Show()
        'End If
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection_resmi
        'cmd.Connection = conn
        'If conn.State = ConnectionState.Closed Then
        '    conn.Open()
        'End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        'cmd = Nothing
        'adapter = Nothing
        Return 1
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nAlisVerisID  like '" & sDepo & "%') ORDER BY CAST(ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) AS DECIMAL) DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_sHareketTipi(ByVal sDepo As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(sDefaultHareketTipi,'') as sHareketTipi FROM tbParamAlisVeris WHERE     (sMagazaKodu = '" & sDepo & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lFaturaNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lFaturaNo, 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (sMagaza = '" & sDepo & "') AND (nGirisCikis = 3) AND (sFisTipi IN ('K', 'P')) ORDER BY lFaturaNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub lFaturaNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String) As Int64
        Dim kriter As String = ""
        kriter = "WHERE (nAlisVerisID = '" & nAlisVerisID & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbAlisVerisAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVeris_kaydet_yeni(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal sOdemeKodu As String, ByVal lNetTutar As Decimal, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Integer, ByVal nKasaNo As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVeris (nAlisverisID, sFisTipi, dteFaturaTarihi, nGirisCikis, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAlisverisYapanAdi, sAlisverisYapanSoyadi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, sOdemeKodu, lNetTutar, sHareketTipi, bMuhasebeyeIslendimi, nKasaNo, sKullaniciAdi, dteKayitTarihi, sYaziIle) VALUES     ('" & nAlisverisID & "', '" & sFisTipi & "', '" & dteFaturaTarihi & "', " & nGirisCikis & ", '" & lFaturaNo & "', " & nMusteriID & ", '" & sMagaza & "', '" & sKasiyerRumuzu & "', '" & sAlisverisYapanAdi & "', '" & sAlisverisYapanSoyadi & "', " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & nDipIskontoYuzdesi & ", " & lDipIskontoTutari & ", " & nKdvOrani1 & ", " & lKdvMatrahi1 & ", " & lKdv1 & ", " & nKdvOrani2 & ", " & lKdvMatrahi2 & ", " & lKdv2 & ", " & nKdvOrani3 & ", " & lKdvMatrahi3 & ", " & lKdv3 & ", " & nKdvOrani4 & ", " & lKdvMatrahi4 & ", " & lKdv4 & ", " & nKdvOrani5 & ", " & lKdvMatrahi5 & ", " & lKdv5 & ", " & lPesinat & ", " & nVadeFarkiYuzdesi & ", " & nVadeKdvOrani & ", " & lVadeKdvMatrahi & ", " & lVadeKdv & ", " & lVadeFarki & ", '" & sOdemeKodu & "', " & lNetTutar & ", '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKullaniciAdi & "',  '" & dteKayitTarihi & "', '" & sYaziIle & "')")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Business Smart")
        End Try
        con.Close()
    End Sub
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
    End Function
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Private Sub stok_satis_detay()
    '    If GridView1.RowCount > 0 Then
    '        Dim frm As New frm_stok_cari_satis
    '        Dim dr As DataRow
    '        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
    '        frm.status = True
    '        frm.firmano = 100
    '        frm.donemno = 1
    '        frm.connection = connection
    '        frm.islemstatus = True
    '        frm.stokno = dr("nAlisverisID")
    '        frm.fistipi = Trim(dr("sFisTipi").ToString)
    '        frm.kullanici = kullanici
    '        If yetki_kontrol(kullanici, frm.Name) = True Then
    '            frm.ShowDialog()
    '        End If
    '        frm.Close()
    '        dr = Nothing
    '    End If
    'End Sub
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
    Private Sub stok_duzelt()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
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
            Dim satir = GridView2.FocusedRowHandle
            GridView2.FocusedRowHandle = satir
            satir = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
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
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
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
            frm.Label1.Text = dr("sAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_envanter_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.modelno = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
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
            Dim satir = GridView2.FocusedRowHandle
            GridView2.FocusedRowHandle = satir
            satir = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            dataload(DateEdit2.EditValue, DateEdit3.EditValue, kullanici, txt_musterino.EditValue, txt_belgeno.EditValue, sec_depo.EditValue, sec_fistipi.Text)
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            dataload(DateEdit2.EditValue, DateEdit3.EditValue, kullanici, txt_musterino.EditValue, txt_belgeno.EditValue, sec_depo.EditValue, sec_fistipi.Text)
        End If
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
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
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If MenuItem5.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem5.Checked = True
        ElseIf MenuItem5.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem5.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem6.Checked = False
        End If
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
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        If MenuItem42.Checked = False Then
            GridView2.OptionsCustomization.AllowFilter = True
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem42.Checked = True
        ElseIf MenuItem42.Checked = True Then
            GridView2.OptionsCustomization.AllowFilter = False
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem42.Checked = False
        End If
    End Sub
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        If MenuItem43.Checked = False Then
            GridView2.OptionsCustomization.AllowGroup = True
            GridView2.OptionsView.ShowGroupPanel = True
            MenuItem43.Checked = True
        ElseIf MenuItem43.Checked = True Then
            GridView2.OptionsCustomization.AllowGroup = False
            GridView2.OptionsView.ShowGroupPanel = False
            MenuItem43.Checked = False
        End If
    End Sub
    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            stok_satis_detay()
        End If
    End Sub
    Private Sub stok_satis_detay()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If sorgu_nAlisVerisID_lSayi(dr("nAlisVerisID").ToString()) > 0 Then
            Dim frm As New frm_Perakende_Satis
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.nAlisVerisID = dr("nAlisVerisID")
            frm.sFisTipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            'frm.sMagaza = dr("sMagaza")
            If Trim(kasiyerno) = "VC" Or Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Then
                frm.Show()
            End If
            'frm.Close()
            'frm.Dispose()
            'frm = Nothing
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        dr = Nothing
    End Sub
    Public Function sorgu_nAlisVerisID_lSayi(ByVal nAlisVerisID As String) As Integer
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        Dim kayitsayisi
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisVerisID), 0) AS nKayit FROM         tbAlisVeris WHERE     (nAlisverisID = '" & nAlisVerisID & "')")
        kayitsayisi = 0
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "') UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = '" & nAlisVerisID & "') as Kapatma")
        kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Try
            musteri_toplu_kontrol()
            If sec_toplu.Checked = True Then
                Dim arr As Integer()
                Dim i As Integer
                Dim sayi As Integer = 0
                Dim nMusteriID As String = ""
                Dim s As String = ""
                arr = GridView1.GetSelectedRows()
                If GridView1.SelectedRowsCount > 1 Then
                    ds_hareket.Clear()
                    If arr Is Nothing Then
                    Else
                        Array.Sort(arr)
                        For Each i In arr
                            s = i.ToString
                            dr_baslik = GridView1.GetDataRow(s)
                            dataload_hareket(dr_baslik("dteFisTarihi"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("lFisNo"))
                        Next
                    End If
                End If
            Else
                If GridView1.RowCount > 0 Then
                    dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    dataload_hareket(dr_baslik("dteFisTarihi"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("lFisNo"))
                    lbl_istihbarat.Text = dr_baslik("ISTIHBARAT").ToString
                    lbl_Adres.Text = dr_baslik("sAlisVerisYapanAdi") & " " & dr_baslik("sAlisVerisYapanSoyadi") & vbCrLf
                    lbl_Adres.Text += dr_baslik("sAdres1") & vbCrLf
                    lbl_Adres.Text += dr_baslik("sAdres2") & vbCrLf
                    lbl_Adres.Text += dr_baslik("sVergiDairesi") & vbCrLf
                    lbl_Adres.Text += dr_baslik("sVergiNo") & vbCrLf
                    lbl_Adres.Text += "Not: " & dr_baslik("sAciklama") & vbCrLf
                    If GridView1.SelectedRowsCount > 1 Then
                        Label5.Text = "Belge Kayýt Sayýsý :" & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
                    ElseIf GridView1.SelectedRowsCount = 1 Then
                        Label5.Text = "Belge Kayýt Sayýsý :" & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
                    Else
                        Label5.Text = ""
                    End If
                End If
            End If
            GridView2.SelectAll()
            If GridView1.RowCount > 0 Then
                'dr_baslik = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                'dataload_hareket(dr_baslik("dteFisTarihi"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("lFisNo"))
                'lbl_istihbarat.Text = dr_baslik("ISTIHBARAT").ToString
                If GridView1.SelectedRowsCount > 1 Then
                    Label5.Text = "Belge Kayýt Sayýsý :" & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
                ElseIf GridView1.SelectedRowsCount = 1 Then
                    Label5.Text = "Belge Kayýt Sayýsý :" & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
                Else
                    Label5.Text = ""
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_musterino_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_musterino.EditValueChanged
        If Trim(kasiyerno) = "VC" Or Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Then
            SimpleButton5.Enabled = True
        Else
            If Trim(txt_musterino.Text) = "" Then
                SimpleButton5.Enabled = False
            Else
                SimpleButton5.Enabled = True
            End If
        End If
    End Sub
End Class
