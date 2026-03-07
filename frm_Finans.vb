Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Alerter
Public Class frm_finans
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
    Friend WithEvents Panel_Kasiyer As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Panel_Baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_Taksitler As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel_Ara As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_sinif As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_odemeler As System.Data.DataSet
    Friend WithEvents ds_taksitler As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents M_Islem_SatisYap As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents M_Islem_AlisYap As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents M_Islem_IadeAl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents M_Islem_IadeEt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_musteri_adi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_bakiyeli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents btn_yenile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ımageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_dteKayitTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nFirmaID As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_sAciklama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sTelefon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdres2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdres1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sGSM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sVergiNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sVergiDairesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lKrediLimiti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lGeciken As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBakiye As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nIskonto2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nIskonto1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sFiyatTipi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panel_bilgi As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Analiz_SiparisAlinanlar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Kalan_Taksitler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Kalan_Satislar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Satislar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Odemeler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Ekstre_Ozet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Raporlar_Ekstre_Detayli As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Islem_SiparisVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_SiparisAl As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_CariCikis As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_CariGiris As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_IadeEt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_IadeAl As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_Alis_Yap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_SatisYap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Musteri_Duzelt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_Not As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_Kart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_Yeni As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_sec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Odemeler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colsYil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel_islem As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton23 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents kisayol_siparis As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_hareket As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton24 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton25 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btn_Islem_IrsaliyeVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_IrsaliyeAl As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton28 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirmaTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirmaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonelNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEventType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecurrenceInfo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReminderInfo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdendi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_gorev_personel As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colHesap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGelecekmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEski As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton29 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton30 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton31 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton32 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_durum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_tamamlandi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteGorevTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents printlink6 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents SimpleButton34 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton33 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sIl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSaticiRumuzu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nIskonto4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nIskonto3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_sYetkili As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nVadeGun As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sDovizCinsi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_tbFirma As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents colsFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIslemAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaHarAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDevirBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDevirAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDevir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIslemTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents M_Islem_SiparisAl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents M_Islem_SiparisVer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_SiparisVerilen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colsOzelKod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_SINIF5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SINIF4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SINIF3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SINIF2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SINIF1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents M_Analiz_CekSenet As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem35 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton18 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton17 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem36 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents sec_sSiparisTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton19 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_ekstre_tarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_ekstre_tarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatirAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIlkSevkiyatTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSipNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSiparisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSiparisIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisTutari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisTutari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSevkMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSevkTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalanMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalanTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsPartiKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collEnvanterMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collEnvanterTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFarkMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFarkTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKrediLimiti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnValorGun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbKapandimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimFiyati As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizFiyati As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSevkIadeMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamRisk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimFiyati1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimFiyati2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents sec_sIrsaliyeTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_irsaliye_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton20 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTransferDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFaturalasti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMuhasebelesti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamamlandi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHizmet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISKONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbPesinmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_info As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton22 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton21 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_finans))
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colGEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbPesinmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEski = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel_Kasiyer = New DevExpress.XtraEditors.PanelControl()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.M_Islem_SatisYap = New DevExpress.XtraBars.BarButtonItem()
        Me.M_Islem_AlisYap = New DevExpress.XtraBars.BarButtonItem()
        Me.M_Islem_IadeAl = New DevExpress.XtraBars.BarButtonItem()
        Me.M_Islem_IadeEt = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.M_Islem_SiparisAl = New DevExpress.XtraBars.BarButtonItem()
        Me.M_Islem_SiparisVer = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem36 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.M_Analiz_CekSenet = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem33 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem34 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem35 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.Panel_Baslik = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_info = New DevExpress.XtraEditors.HyperLinkEdit()
        Me.txt_SINIF5 = New DevExpress.XtraEditors.TextEdit()
        Me.ds_tbFirma = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
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
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
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
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SINIF4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SINIF3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SINIF2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SINIF1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nVadeGun = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sDovizCinsi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSaticiRumuzu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nIskonto4 = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_nIskonto3 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sIl = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sYetkili = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sFiyatTipi = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nIskonto1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSemt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lKrediLimiti = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nIskonto2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lGeciken = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lBakiye = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sVergiNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sVergiDairesi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sGSM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sTelefon = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sAdres2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sAdres1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAciklama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKodu = New DevExpress.XtraEditors.TextEdit()
        Me.txt_dteKayitTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nFirmaID = New DevExpress.XtraEditors.ButtonEdit()
        Me.Panel_Ara = New DevExpress.XtraEditors.PanelControl()
        Me.btn_yenile = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musterino = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_bakiyeli = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_musteri_adi = New DevExpress.XtraEditors.LabelControl()
        Me.Panel_Taksitler = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_Odemeler = New DevExpress.XtraEditors.SimpleButton()
        Me.ds_sinif = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_hareket = New System.Windows.Forms.ContextMenu()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.ds_odemeler = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIslemAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBorcTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacakTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaHarAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDevirBorc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDevirAlacak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDevir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIslemTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOzelKod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_siparis = New System.Windows.Forms.ContextMenu()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFirmaAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatirAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIlkSevkiyatTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSipNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteSiparisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSiparisIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisMiktari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisTutari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSiparisTutari2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSevkMiktari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSevkTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalanMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalanTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsPartiKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collEnvanterMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collEnvanterTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFarkMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFarkTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKrediLimiti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnValorGun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbKapandimi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBirimFiyati = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizFiyati = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSevkIadeMiktari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamRisk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBirimFiyati1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBirimFiyati2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton28 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton22 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton21 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label40 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sSiparisTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label39 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton19 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_ekstre_tarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_ekstre_tarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTransferDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFaturalasti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMuhasebelesti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTamamlandi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHizmet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton23 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_sIrsaliyeTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_irsaliye_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton20 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirmaTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirmaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonelNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEventType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecurrenceInfo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReminderInfo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdendi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_gorev_personel = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colHesap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGelecekmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton34 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton33 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton29 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton30 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton31 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_dteGorevTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton32 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_durum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_tamamlandi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ds_taksitler = New System.Data.DataSet()
        Me.Panel_islem = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton25 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton15 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_SiparisVerilen = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Kalan_Satislar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Satislar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Odemeler = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Kalan_Taksitler = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_SiparisAlinanlar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Ekstre_Ozet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Raporlar_Ekstre_Detayli = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_Islem_IrsaliyeVer = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_IrsaliyeAl = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton18 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton17 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton16 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_SiparisVer = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_SiparisAl = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_CariCikis = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_CariGiris = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_IadeEt = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_IadeAl = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_Alis_Yap = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_SatisYap = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton24 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Duzelt = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Not = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Kart = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Yeni = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_sec = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_bilgi = New DevExpress.XtraEditors.PanelControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink6 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.Panel_Kasiyer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Kasiyer.SuspendLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Baslik.SuspendLayout()
        CType(Me.lbl_info.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINIF5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINIF4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINIF3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINIF2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINIF1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nVadeGun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskonto4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskonto3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sYetkili.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskonto1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lKrediLimiti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskonto2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lGeciken.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lBakiye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sTelefon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdres2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdres1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKayitTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKayitTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nFirmaID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Ara.SuspendLayout()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bakiyeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Taksitler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Taksitler.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_sinif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_odemeler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.sec_sSiparisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.sec_sIrsaliyeTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_irsaliye_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_gorev_personel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_dteGorevTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteGorevTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_durum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tamamlandi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_taksitler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_islem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_islem.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.panel_bilgi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_bilgi.SuspendLayout()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink6.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colGEC
        '
        Me.colGEC.Caption = "Gün"
        Me.colGEC.DisplayFormat.FormatString = "#,0.##"
        Me.colGEC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGEC.FieldName = "GECIKME"
        Me.colGEC.Name = "colGEC"
        Me.colGEC.Visible = True
        Me.colGEC.VisibleIndex = 2
        Me.colGEC.Width = 45
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Bakiye"
        Me.GridColumn9.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "lBakiye"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'colbPesinmi
        '
        Me.colbPesinmi.Caption = "Kapali"
        Me.colbPesinmi.FieldName = "bPesinmi"
        Me.colbPesinmi.Name = "colbPesinmi"
        '
        'colEski
        '
        Me.colEski.Caption = "EskiGörev"
        Me.colEski.FieldName = "Eski"
        Me.colEski.Name = "colEski"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Tamamlandi?"
        Me.GridColumn10.FieldName = "Tamamlandi"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 12
        Me.GridColumn10.Width = 58
        '
        'Panel_Kasiyer
        '
        Me.Panel_Kasiyer.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_Kasiyer.Appearance.Options.UseBackColor = True
        Me.Panel_Kasiyer.Controls.Add(Me.sec_magaza)
        Me.Panel_Kasiyer.Controls.Add(Me.sec_kasa)
        Me.Panel_Kasiyer.Controls.Add(Me.DateEdit1)
        Me.Panel_Kasiyer.Controls.Add(Me.LabelControl6)
        Me.Panel_Kasiyer.Controls.Add(Me.LabelControl5)
        Me.Panel_Kasiyer.Controls.Add(Me.lbl_kasa)
        Me.Panel_Kasiyer.Controls.Add(Me.lbl_kasiyer)
        Me.Panel_Kasiyer.Controls.Add(Me.txt_kasiyer_kod)
        Me.Panel_Kasiyer.Controls.Add(Me.LabelControl2)
        Me.Panel_Kasiyer.Controls.Add(Me.LabelControl1)
        Me.Panel_Kasiyer.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Kasiyer.Location = New System.Drawing.Point(0, 32)
        Me.Panel_Kasiyer.Name = "Panel_Kasiyer"
        Me.Panel_Kasiyer.Size = New System.Drawing.Size(818, 62)
        Me.Panel_Kasiyer.TabIndex = 1
        '
        'sec_magaza
        '
        Me.sec_magaza.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sec_magaza.Location = New System.Drawing.Point(581, 36)
        Me.sec_magaza.Name = "sec_magaza"
        Me.sec_magaza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_magaza.Properties.Appearance.Options.UseFont = True
        Me.sec_magaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_magaza.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açıklama")})
        Me.sec_magaza.Properties.DisplayMember = "sAciklama"
        Me.sec_magaza.Properties.NullText = "[Mağaza]"
        Me.sec_magaza.Properties.ReadOnly = True
        Me.sec_magaza.Properties.ValueMember = "sDepo"
        Me.sec_magaza.Size = New System.Drawing.Size(216, 28)
        Me.sec_magaza.TabIndex = 11
        Me.sec_magaza.ToolTip = "Çalışılan Mağaza"
        '
        'sec_kasa
        '
        Me.sec_kasa.Location = New System.Drawing.Point(90, 31)
        Me.sec_kasa.Name = "sec_kasa"
        Me.sec_kasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nKasaNo", 5, "KasaNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", 40, "Açıklama")})
        Me.sec_kasa.Properties.DisplayMember = "nKasaNo"
        Me.sec_kasa.Properties.NullText = "[Kasa]"
        Me.sec_kasa.Properties.ValueMember = "nKasaNo"
        Me.sec_kasa.Size = New System.Drawing.Size(192, 26)
        Me.sec_kasa.TabIndex = 10
        Me.sec_kasa.ToolTip = "Çalışılan Kasa Numarası"
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(581, 4)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.NullText = "[Tarih]"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(216, 28)
        Me.DateEdit1.TabIndex = 8
        Me.DateEdit1.ToolTip = "Aktif İşlem Tarihi"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(520, 40)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 21)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Depo:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(520, 6)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 21)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Tarih:"
        '
        'lbl_kasa
        '
        Me.lbl_kasa.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kasa.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_kasa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_kasa.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_kasa.Location = New System.Drawing.Point(286, 40)
        Me.lbl_kasa.Name = "lbl_kasa"
        Me.lbl_kasa.Size = New System.Drawing.Size(22, 21)
        Me.lbl_kasa.TabIndex = 5
        Me.lbl_kasa.Text = "**"
        '
        'lbl_kasiyer
        '
        Me.lbl_kasiyer.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kasiyer.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_kasiyer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_kasiyer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_kasiyer.Location = New System.Drawing.Point(286, 10)
        Me.lbl_kasiyer.Name = "lbl_kasiyer"
        Me.lbl_kasiyer.Size = New System.Drawing.Size(11, 21)
        Me.lbl_kasiyer.TabIndex = 4
        Me.lbl_kasiyer.Text = "*"
        '
        'txt_kasiyer_kod
        '
        Me.txt_kasiyer_kod.Location = New System.Drawing.Point(90, 3)
        Me.txt_kasiyer_kod.Name = "txt_kasiyer_kod"
        Me.txt_kasiyer_kod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kasiyer_kod.Properties.NullText = "[Kasiyer]"
        Me.txt_kasiyer_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kasiyer_kod.Size = New System.Drawing.Size(192, 26)
        ToolTipTitleItem1.Text = "Kasiyer/Yetkili"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "İşlem Yapabilmek için Yetkili Personel Şifresini Girmeniz Gerekmektedir."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txt_kasiyer_kod.SuperTip = SuperToolTip1
        Me.txt_kasiyer_kod.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(40, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 21)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Kasa:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(16, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 21)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Kasiyer:"
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.CloseButtonAffectAllTabs = False
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.M_Islem_SatisYap, Me.M_Islem_AlisYap, Me.M_Islem_IadeAl, Me.M_Islem_IadeEt, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.M_Islem_SiparisAl, Me.M_Islem_SiparisVer, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarButtonItem28, Me.M_Analiz_CekSenet, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.BarButtonItem32, Me.BarButtonItem33, Me.BarButtonItem34, Me.BarButtonItem35, Me.BarButtonItem36})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 38
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Menü"
        Me.BarSubItem1.Enabled = False
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem5, "Hesap Ekle"), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem4, "Notlar"), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem3, "İletişim Bilgileri"), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.M_Islem_SatisYap, True), New DevExpress.XtraBars.LinkPersistInfo(Me.M_Islem_AlisYap), New DevExpress.XtraBars.LinkPersistInfo(Me.M_Islem_IadeAl), New DevExpress.XtraBars.LinkPersistInfo(Me.M_Islem_IadeEt), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.M_Islem_SiparisAl), New DevExpress.XtraBars.LinkPersistInfo(Me.M_Islem_SiparisVer), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.M_Analiz_CekSenet), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Notlar"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Hesap Kartı Sil"
        Me.BarButtonItem19.Id = 19
        Me.BarButtonItem19.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Müşteri Gir"
        Me.BarButtonItem18.Id = 18
        Me.BarButtonItem18.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Hesap Seç"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Açıklama"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Müşteri Kartı"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Hesabı Düzenle"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'M_Islem_SatisYap
        '
        Me.M_Islem_SatisYap.Caption = "Satış Yap"
        Me.M_Islem_SatisYap.Id = 7
        Me.M_Islem_SatisYap.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.M_Islem_SatisYap.Name = "M_Islem_SatisYap"
        '
        'M_Islem_AlisYap
        '
        Me.M_Islem_AlisYap.Caption = "Alış Yap"
        Me.M_Islem_AlisYap.Id = 8
        Me.M_Islem_AlisYap.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.M_Islem_AlisYap.Name = "M_Islem_AlisYap"
        '
        'M_Islem_IadeAl
        '
        Me.M_Islem_IadeAl.Caption = "İade Al"
        Me.M_Islem_IadeAl.Id = 9
        Me.M_Islem_IadeAl.Name = "M_Islem_IadeAl"
        '
        'M_Islem_IadeEt
        '
        Me.M_Islem_IadeEt.Caption = "İade Et"
        Me.M_Islem_IadeEt.Id = 10
        Me.M_Islem_IadeEt.Name = "M_Islem_IadeEt"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Cari Giriş Bordrosu"
        Me.BarButtonItem11.Id = 11
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F5))
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Cari Çıkış Bordrosu"
        Me.BarButtonItem22.Id = 22
        Me.BarButtonItem22.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F6))
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'M_Islem_SiparisAl
        '
        Me.M_Islem_SiparisAl.Caption = "Sipariş Al"
        Me.M_Islem_SiparisAl.Id = 24
        Me.M_Islem_SiparisAl.Name = "M_Islem_SiparisAl"
        '
        'M_Islem_SiparisVer
        '
        Me.M_Islem_SiparisVer.Caption = "Sipariş Ver"
        Me.M_Islem_SiparisVer.Id = 25
        Me.M_Islem_SiparisVer.Name = "M_Islem_SiparisVer"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Resim Göster"
        Me.BarButtonItem28.Id = 28
        Me.BarButtonItem28.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarButtonItem36
        '
        Me.BarButtonItem36.Caption = "Protokol"
        Me.BarButtonItem36.Id = 37
        Me.BarButtonItem36.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T))
        Me.BarButtonItem36.Name = "BarButtonItem36"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Hareket Gir"
        Me.BarButtonItem27.Id = 27
        Me.BarButtonItem27.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'M_Analiz_CekSenet
        '
        Me.M_Analiz_CekSenet.Caption = "Çek/Senet"
        Me.M_Analiz_CekSenet.Id = 29
        Me.M_Analiz_CekSenet.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem31, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem32), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem33), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem34), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem35)})
        Me.M_Analiz_CekSenet.Name = "M_Analiz_CekSenet"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Alınan Çekler"
        Me.BarButtonItem29.Id = 30
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Verilen Çekler"
        Me.BarButtonItem30.Id = 31
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "Ciro Edilen Çekler"
        Me.BarButtonItem31.Id = 32
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Takasa Verilen Çekler"
        Me.BarButtonItem32.Id = 33
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem33
        '
        Me.BarButtonItem33.Caption = "Teminata Verilen Çekler"
        Me.BarButtonItem33.Id = 34
        Me.BarButtonItem33.Name = "BarButtonItem33"
        '
        'BarButtonItem34
        '
        Me.BarButtonItem34.Caption = "Protesto/Karşılıksız Çekler"
        Me.BarButtonItem34.Id = 35
        Me.BarButtonItem34.Name = "BarButtonItem34"
        '
        'BarButtonItem35
        '
        Me.BarButtonItem35.Caption = "Parçalı Tahsilat Yapılan Çekler"
        Me.BarButtonItem35.Id = 36
        Me.BarButtonItem35.Name = "BarButtonItem35"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Ekstre Detaylı"
        Me.BarButtonItem12.Id = 12
        Me.BarButtonItem12.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Ekstre"
        Me.BarButtonItem13.Id = 13
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Risk"
        Me.BarButtonItem17.Id = 17
        Me.BarButtonItem17.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Karlılık Akış Tablosu"
        Me.BarButtonItem26.Id = 26
        Me.BarButtonItem26.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Masraflar"
        Me.BarButtonItem20.Id = 20
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Çıkış"
        Me.BarButtonItem23.Id = 23
        Me.BarButtonItem23.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(818, 32)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 746)
        Me.barDockControlBottom.Size = New System.Drawing.Size(818, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 32)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 714)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(818, 32)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 714)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.BarButtonItem1.Caption = "*"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Yapılan Ödemeler"
        Me.BarButtonItem14.Id = 14
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Yapılan Satışlar"
        Me.BarButtonItem15.Id = 15
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Kalan Ödemeler"
        Me.BarButtonItem16.Id = 16
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem21.Caption = "Status"
        Me.BarButtonItem21.Id = 21
        Me.BarButtonItem21.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem21.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Navy
        Me.BarButtonItem21.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem21.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'ToolTipController1
        '
        Me.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        '
        'Panel_Baslik
        '
        Me.Panel_Baslik.Appearance.BackColor = System.Drawing.Color.Silver
        Me.Panel_Baslik.Appearance.Options.UseBackColor = True
        Me.Panel_Baslik.Controls.Add(Me.lbl_info)
        Me.Panel_Baslik.Controls.Add(Me.txt_SINIF5)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl29)
        Me.Panel_Baslik.Controls.Add(Me.txt_SINIF4)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl28)
        Me.Panel_Baslik.Controls.Add(Me.txt_SINIF3)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl27)
        Me.Panel_Baslik.Controls.Add(Me.txt_SINIF2)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl25)
        Me.Panel_Baslik.Controls.Add(Me.txt_SINIF1)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl24)
        Me.Panel_Baslik.Controls.Add(Me.txt_nVadeGun)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl23)
        Me.Panel_Baslik.Controls.Add(Me.txt_sDovizCinsi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl17)
        Me.Panel_Baslik.Controls.Add(Me.txt_sSaticiRumuzu)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl13)
        Me.Panel_Baslik.Controls.Add(Me.txt_nIskonto4)
        Me.Panel_Baslik.Controls.Add(Me.txt_nIskonto3)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl10)
        Me.Panel_Baslik.Controls.Add(Me.txt_sIl)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl7)
        Me.Panel_Baslik.Controls.Add(Me.txt_sYetkili)
        Me.Panel_Baslik.Controls.Add(Me.txt_sFiyatTipi)
        Me.Panel_Baslik.Controls.Add(Me.txt_nIskonto1)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl31)
        Me.Panel_Baslik.Controls.Add(Me.txt_sSemt)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl26)
        Me.Panel_Baslik.Controls.Add(Me.txt_lKrediLimiti)
        Me.Panel_Baslik.Controls.Add(Me.txt_nIskonto2)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl20)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl14)
        Me.Panel_Baslik.Controls.Add(Me.txt_lGeciken)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl15)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl16)
        Me.Panel_Baslik.Controls.Add(Me.txt_lBakiye)
        Me.Panel_Baslik.Controls.Add(Me.txt_sVergiNo)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl12)
        Me.Panel_Baslik.Controls.Add(Me.txt_sVergiDairesi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl9)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl18)
        Me.Panel_Baslik.Controls.Add(Me.txt_sEmail)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl32)
        Me.Panel_Baslik.Controls.Add(Me.txt_sGSM)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl19)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl22)
        Me.Panel_Baslik.Controls.Add(Me.txt_sTelefon)
        Me.Panel_Baslik.Controls.Add(Me.txt_sAdres2)
        Me.Panel_Baslik.Controls.Add(Me.txt_sAdres1)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl21)
        Me.Panel_Baslik.Controls.Add(Me.txt_sAciklama)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl11)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl8)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKodu)
        Me.Panel_Baslik.Controls.Add(Me.txt_dteKayitTarihi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl3)
        Me.Panel_Baslik.Controls.Add(Me.txt_nFirmaID)
        Me.Panel_Baslik.Controls.Add(Me.Panel_Ara)
        Me.Panel_Baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Baslik.Enabled = False
        Me.Panel_Baslik.Location = New System.Drawing.Point(2, 2)
        Me.Panel_Baslik.Name = "Panel_Baslik"
        Me.Panel_Baslik.Size = New System.Drawing.Size(542, 300)
        Me.Panel_Baslik.TabIndex = 0
        '
        'lbl_info
        '
        Me.lbl_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_info.EditValue = "Bu Hesap için Girilmiş İstihbarat Notunuz Var...!!!"
        Me.lbl_info.Location = New System.Drawing.Point(2, 59)
        Me.lbl_info.MenuManager = Me.BarManager1
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_info.Properties.Appearance.Options.UseForeColor = True
        Me.lbl_info.Size = New System.Drawing.Size(538, 26)
        Me.lbl_info.TabIndex = 130
        Me.lbl_info.Visible = False
        '
        'txt_SINIF5
        '
        Me.txt_SINIF5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.SINIF5", True))
        Me.txt_SINIF5.EnterMoveNextControl = True
        Me.txt_SINIF5.Location = New System.Drawing.Point(878, 269)
        Me.txt_SINIF5.Name = "txt_SINIF5"
        Me.txt_SINIF5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_SINIF5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_SINIF5.Properties.Appearance.Options.UseFont = True
        Me.txt_SINIF5.Properties.Appearance.Options.UseForeColor = True
        Me.txt_SINIF5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF5.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF5.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_SINIF5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_SINIF5.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_SINIF5.Properties.MaxLength = 60
        Me.txt_SINIF5.Size = New System.Drawing.Size(144, 28)
        Me.txt_SINIF5.TabIndex = 128
        '
        'ds_tbFirma
        '
        Me.ds_tbFirma.DataSetName = "NewDataSet"
        Me.ds_tbFirma.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirma.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn56, Me.DataColumn57})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nFirmaID"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sKodu"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sAciklama"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nOzelIskontosu"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lKrediLimiti"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "dteMutabakatTarihi"
        Me.DataColumn18.DataType = GetType(Date)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nVadeGun"
        Me.DataColumn19.DataType = GetType(Long)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sHitap"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sAdres1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sAdres2"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sSemt"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sIl"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sUlke"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sPostaKodu"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sVergiDairesi"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sVergiNo"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "nHesapID"
        Me.DataColumn29.DataType = GetType(Long)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sOzelNot"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sKullaniciAdi"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "dteKayitTarihi"
        Me.DataColumn32.DataType = GetType(Date)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sFiyatTipi"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sMuhasebeKodu"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "sMuhasebeAciklama"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "nOzelIskontosu2"
        Me.DataColumn49.DataType = GetType(Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "nOzelIskontosu3"
        Me.DataColumn50.DataType = GetType(Decimal)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "nOzelIskontosu4"
        Me.DataColumn51.DataType = GetType(Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "bAktif"
        Me.DataColumn52.DataType = GetType(Boolean)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "bSatisYapilamaz"
        Me.DataColumn53.DataType = GetType(Boolean)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "bTahsilatYapilamaz"
        Me.DataColumn54.DataType = GetType(Boolean)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "sDovizCinsi"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "E-Mail"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Fax"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Gsm"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Telefon"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Web"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Yetkili"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "lGeciken"
        Me.DataColumn40.DataType = GetType(Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "lRisk"
        Me.DataColumn41.DataType = GetType(Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "lBakiye"
        Me.DataColumn42.DataType = GetType(Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "SINIF1"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "SINIF2"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "SINIF3"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "SINIF4"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "SINIF5"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl29.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl29.Location = New System.Drawing.Point(829, 269)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(46, 19)
        Me.LabelControl29.TabIndex = 129
        Me.LabelControl29.Text = "Sınıf5:"
        '
        'txt_SINIF4
        '
        Me.txt_SINIF4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.SINIF4", True))
        Me.txt_SINIF4.EnterMoveNextControl = True
        Me.txt_SINIF4.Location = New System.Drawing.Point(685, 269)
        Me.txt_SINIF4.Name = "txt_SINIF4"
        Me.txt_SINIF4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_SINIF4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_SINIF4.Properties.Appearance.Options.UseFont = True
        Me.txt_SINIF4.Properties.Appearance.Options.UseForeColor = True
        Me.txt_SINIF4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_SINIF4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_SINIF4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_SINIF4.Properties.MaxLength = 60
        Me.txt_SINIF4.Size = New System.Drawing.Size(144, 28)
        Me.txt_SINIF4.TabIndex = 126
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl28.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl28.Location = New System.Drawing.Point(637, 269)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(46, 19)
        Me.LabelControl28.TabIndex = 127
        Me.LabelControl28.Text = "Sınıf4:"
        '
        'txt_SINIF3
        '
        Me.txt_SINIF3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.SINIF3", True))
        Me.txt_SINIF3.EnterMoveNextControl = True
        Me.txt_SINIF3.Location = New System.Drawing.Point(493, 269)
        Me.txt_SINIF3.Name = "txt_SINIF3"
        Me.txt_SINIF3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_SINIF3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_SINIF3.Properties.Appearance.Options.UseFont = True
        Me.txt_SINIF3.Properties.Appearance.Options.UseForeColor = True
        Me.txt_SINIF3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_SINIF3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_SINIF3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_SINIF3.Properties.MaxLength = 60
        Me.txt_SINIF3.Size = New System.Drawing.Size(144, 28)
        Me.txt_SINIF3.TabIndex = 124
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl27.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl27.Location = New System.Drawing.Point(445, 269)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(46, 19)
        Me.LabelControl27.TabIndex = 125
        Me.LabelControl27.Text = "Sınıf3:"
        '
        'txt_SINIF2
        '
        Me.txt_SINIF2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.SINIF2", True))
        Me.txt_SINIF2.EnterMoveNextControl = True
        Me.txt_SINIF2.Location = New System.Drawing.Point(301, 269)
        Me.txt_SINIF2.Name = "txt_SINIF2"
        Me.txt_SINIF2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_SINIF2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_SINIF2.Properties.Appearance.Options.UseFont = True
        Me.txt_SINIF2.Properties.Appearance.Options.UseForeColor = True
        Me.txt_SINIF2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_SINIF2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_SINIF2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_SINIF2.Properties.MaxLength = 60
        Me.txt_SINIF2.Size = New System.Drawing.Size(144, 28)
        Me.txt_SINIF2.TabIndex = 122
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl25.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl25.Location = New System.Drawing.Point(253, 269)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(46, 19)
        Me.LabelControl25.TabIndex = 123
        Me.LabelControl25.Text = "Sınıf2:"
        '
        'txt_SINIF1
        '
        Me.txt_SINIF1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.SINIF1", True))
        Me.txt_SINIF1.EnterMoveNextControl = True
        Me.txt_SINIF1.Location = New System.Drawing.Point(109, 269)
        Me.txt_SINIF1.Name = "txt_SINIF1"
        Me.txt_SINIF1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_SINIF1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_SINIF1.Properties.Appearance.Options.UseFont = True
        Me.txt_SINIF1.Properties.Appearance.Options.UseForeColor = True
        Me.txt_SINIF1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SINIF1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_SINIF1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_SINIF1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_SINIF1.Properties.MaxLength = 60
        Me.txt_SINIF1.Size = New System.Drawing.Size(144, 28)
        Me.txt_SINIF1.TabIndex = 120
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl24.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl24.Location = New System.Drawing.Point(61, 269)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(46, 19)
        Me.LabelControl24.TabIndex = 121
        Me.LabelControl24.Text = "Sınıf1:"
        '
        'txt_nVadeGun
        '
        Me.txt_nVadeGun.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nVadeGun", True))
        Me.txt_nVadeGun.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nVadeGun.EnterMoveNextControl = True
        Me.txt_nVadeGun.Location = New System.Drawing.Point(960, 204)
        Me.txt_nVadeGun.Name = "txt_nVadeGun"
        Me.txt_nVadeGun.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nVadeGun.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nVadeGun.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nVadeGun.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nVadeGun.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nVadeGun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nVadeGun.Size = New System.Drawing.Size(62, 26)
        Me.txt_nVadeGun.TabIndex = 118
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl23.Location = New System.Drawing.Point(842, 204)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl23.TabIndex = 119
        Me.LabelControl23.Text = "Vade (Gün):"
        '
        'txt_sDovizCinsi
        '
        Me.txt_sDovizCinsi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sDovizCinsi", True))
        Me.txt_sDovizCinsi.EnterMoveNextControl = True
        Me.txt_sDovizCinsi.Location = New System.Drawing.Point(773, 204)
        Me.txt_sDovizCinsi.Name = "txt_sDovizCinsi"
        Me.txt_sDovizCinsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sDovizCinsi.Properties.Appearance.Options.UseFont = True
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sDovizCinsi.Properties.MaxLength = 60
        Me.txt_sDovizCinsi.Size = New System.Drawing.Size(62, 24)
        Me.txt_sDovizCinsi.TabIndex = 116
        Me.txt_sDovizCinsi.ToolTip = "5 Karakterden Küçükse FiyatTipi , 5 Karakterden Büyükise EhliyetNo olarak algılan" &
    "maktadır."
        Me.txt_sDovizCinsi.ToolTipTitle = "FiyatTipi/EhliyetNo"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.Location = New System.Drawing.Point(746, 204)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl17.TabIndex = 117
        Me.LabelControl17.Text = "Pb:"
        '
        'txt_sSaticiRumuzu
        '
        Me.txt_sSaticiRumuzu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sSaticiRumuzu", True))
        Me.txt_sSaticiRumuzu.EnterMoveNextControl = True
        Me.txt_sSaticiRumuzu.Location = New System.Drawing.Point(898, 233)
        Me.txt_sSaticiRumuzu.Name = "txt_sSaticiRumuzu"
        Me.txt_sSaticiRumuzu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSaticiRumuzu.Properties.Appearance.Options.UseFont = True
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSaticiRumuzu.Properties.MaxLength = 60
        Me.txt_sSaticiRumuzu.Size = New System.Drawing.Size(124, 24)
        Me.txt_sSaticiRumuzu.TabIndex = 114
        Me.txt_sSaticiRumuzu.ToolTip = "5 Karakterden Küçükse FiyatTipi , 5 Karakterden Büyükise EhliyetNo olarak algılan" &
    "maktadır."
        Me.txt_sSaticiRumuzu.ToolTipTitle = "FiyatTipi/EhliyetNo"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(845, 233)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl13.TabIndex = 115
        Me.LabelControl13.Text = "Satici:"
        '
        'txt_nIskonto4
        '
        Me.txt_nIskonto4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu4", True))
        Me.txt_nIskonto4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskonto4.EnterMoveNextControl = True
        Me.txt_nIskonto4.Location = New System.Drawing.Point(960, 176)
        Me.txt_nIskonto4.Name = "txt_nIskonto4"
        Me.txt_nIskonto4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskonto4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskonto4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskonto4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskonto4.Size = New System.Drawing.Size(62, 26)
        Me.txt_nIskonto4.TabIndex = 113
        '
        'txt_nIskonto3
        '
        Me.txt_nIskonto3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu3", True))
        Me.txt_nIskonto3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskonto3.EnterMoveNextControl = True
        Me.txt_nIskonto3.Location = New System.Drawing.Point(898, 176)
        Me.txt_nIskonto3.Name = "txt_nIskonto3"
        Me.txt_nIskonto3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskonto3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskonto3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskonto3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskonto3.Size = New System.Drawing.Size(62, 26)
        Me.txt_nIskonto3.TabIndex = 112
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(224, 239)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl10.TabIndex = 111
        Me.LabelControl10.Text = "İl:"
        '
        'txt_sIl
        '
        Me.txt_sIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sIl", True))
        Me.txt_sIl.EnterMoveNextControl = True
        Me.txt_sIl.Location = New System.Drawing.Point(254, 233)
        Me.txt_sIl.Name = "txt_sIl"
        Me.txt_sIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIl.Properties.MaxLength = 60
        Me.txt_sIl.Size = New System.Drawing.Size(127, 26)
        Me.txt_sIl.TabIndex = 110
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(40, 204)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl7.TabIndex = 109
        Me.LabelControl7.Text = "Adres2:"
        '
        'txt_sYetkili
        '
        Me.txt_sYetkili.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.Yetkili", True))
        Me.txt_sYetkili.EnterMoveNextControl = True
        Me.txt_sYetkili.Location = New System.Drawing.Point(482, 176)
        Me.txt_sYetkili.Name = "txt_sYetkili"
        Me.txt_sYetkili.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sYetkili.Properties.Appearance.Options.UseFont = True
        Me.txt_sYetkili.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sYetkili.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sYetkili.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sYetkili.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sYetkili.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sYetkili.Properties.MaxLength = 60
        Me.txt_sYetkili.Size = New System.Drawing.Size(220, 28)
        Me.txt_sYetkili.TabIndex = 108
        '
        'txt_sFiyatTipi
        '
        Me.txt_sFiyatTipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sFiyatTipi", True))
        Me.txt_sFiyatTipi.EnterMoveNextControl = True
        Me.txt_sFiyatTipi.Location = New System.Drawing.Point(773, 230)
        Me.txt_sFiyatTipi.Name = "txt_sFiyatTipi"
        Me.txt_sFiyatTipi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sFiyatTipi.Properties.Appearance.Options.UseFont = True
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sFiyatTipi.Properties.MaxLength = 60
        Me.txt_sFiyatTipi.Size = New System.Drawing.Size(62, 24)
        Me.txt_sFiyatTipi.TabIndex = 27
        Me.txt_sFiyatTipi.ToolTip = "5 Karakterden Küçükse FiyatTipi , 5 Karakterden Büyükise EhliyetNo olarak algılan" &
    "maktadır."
        Me.txt_sFiyatTipi.ToolTipTitle = "FiyatTipi/EhliyetNo"
        '
        'txt_nIskonto1
        '
        Me.txt_nIskonto1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu", True))
        Me.txt_nIskonto1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskonto1.EnterMoveNextControl = True
        Me.txt_nIskonto1.Location = New System.Drawing.Point(773, 176)
        Me.txt_nIskonto1.Name = "txt_nIskonto1"
        Me.txt_nIskonto1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskonto1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskonto1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskonto1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskonto1.Size = New System.Drawing.Size(62, 26)
        Me.txt_nIskonto1.TabIndex = 25
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl31.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl31.Location = New System.Drawing.Point(704, 230)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(66, 19)
        Me.LabelControl31.TabIndex = 107
        Me.LabelControl31.Text = "FiyatTipi:"
        '
        'txt_sSemt
        '
        Me.txt_sSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sSemt", True))
        Me.txt_sSemt.EnterMoveNextControl = True
        Me.txt_sSemt.Location = New System.Drawing.Point(109, 233)
        Me.txt_sSemt.Name = "txt_sSemt"
        Me.txt_sSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSemt.Properties.MaxLength = 60
        Me.txt_sSemt.Size = New System.Drawing.Size(105, 26)
        Me.txt_sSemt.TabIndex = 9
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl26.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl26.Location = New System.Drawing.Point(56, 233)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl26.TabIndex = 103
        Me.LabelControl26.Text = "Semt:"
        '
        'txt_lKrediLimiti
        '
        Me.txt_lKrediLimiti.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.lKrediLimiti", True))
        Me.txt_lKrediLimiti.EnterMoveNextControl = True
        Me.txt_lKrediLimiti.Location = New System.Drawing.Point(773, 147)
        Me.txt_lKrediLimiti.Name = "txt_lKrediLimiti"
        Me.txt_lKrediLimiti.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lKrediLimiti.Properties.Appearance.Options.UseFont = True
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lKrediLimiti.Size = New System.Drawing.Size(251, 28)
        Me.txt_lKrediLimiti.TabIndex = 21
        '
        'txt_nIskonto2
        '
        Me.txt_nIskonto2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu2", True))
        Me.txt_nIskonto2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskonto2.EnterMoveNextControl = True
        Me.txt_nIskonto2.Location = New System.Drawing.Point(835, 176)
        Me.txt_nIskonto2.Name = "txt_nIskonto2"
        Me.txt_nIskonto2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskonto2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskonto2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskonto2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskonto2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskonto2.Size = New System.Drawing.Size(63, 26)
        Me.txt_nIskonto2.TabIndex = 26
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl20.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl20.Location = New System.Drawing.Point(725, 176)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl20.TabIndex = 91
        Me.LabelControl20.Text = "İsk%:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(725, 147)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl14.TabIndex = 85
        Me.LabelControl14.Text = "Kredi:"
        '
        'txt_lGeciken
        '
        Me.txt_lGeciken.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.lGeciken", True))
        Me.txt_lGeciken.EnterMoveNextControl = True
        Me.txt_lGeciken.Location = New System.Drawing.Point(773, 119)
        Me.txt_lGeciken.Name = "txt_lGeciken"
        Me.txt_lGeciken.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lGeciken.Properties.Appearance.Options.UseFont = True
        Me.txt_lGeciken.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lGeciken.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lGeciken.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lGeciken.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lGeciken.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lGeciken.Size = New System.Drawing.Size(251, 28)
        Me.txt_lGeciken.TabIndex = 20
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.Location = New System.Drawing.Point(706, 119)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl15.TabIndex = 83
        Me.LabelControl15.Text = "Geciken:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(714, 90)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl16.TabIndex = 81
        Me.LabelControl16.Text = "Bakiye:"
        '
        'txt_lBakiye
        '
        Me.txt_lBakiye.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.lBakiye", True))
        Me.txt_lBakiye.EnterMoveNextControl = True
        Me.txt_lBakiye.Location = New System.Drawing.Point(773, 90)
        Me.txt_lBakiye.Name = "txt_lBakiye"
        Me.txt_lBakiye.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lBakiye.Properties.Appearance.Options.UseFont = True
        Me.txt_lBakiye.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBakiye.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBakiye.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lBakiye.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lBakiye.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lBakiye.Size = New System.Drawing.Size(251, 28)
        Me.txt_lBakiye.TabIndex = 19
        '
        'txt_sVergiNo
        '
        Me.txt_sVergiNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sVergiNo", True))
        Me.txt_sVergiNo.EnterMoveNextControl = True
        Me.txt_sVergiNo.Location = New System.Drawing.Point(482, 233)
        Me.txt_sVergiNo.Name = "txt_sVergiNo"
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiNo.Properties.MaxLength = 60
        Me.txt_sVergiNo.Size = New System.Drawing.Size(220, 26)
        Me.txt_sVergiNo.TabIndex = 16
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.Location = New System.Drawing.Point(411, 233)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl12.TabIndex = 77
        Me.LabelControl12.Text = "VergiNo:"
        '
        'txt_sVergiDairesi
        '
        Me.txt_sVergiDairesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sVergiDairesi", True))
        Me.txt_sVergiDairesi.EnterMoveNextControl = True
        Me.txt_sVergiDairesi.Location = New System.Drawing.Point(482, 204)
        Me.txt_sVergiDairesi.Name = "txt_sVergiDairesi"
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiDairesi.Properties.MaxLength = 60
        Me.txt_sVergiDairesi.Size = New System.Drawing.Size(220, 26)
        Me.txt_sVergiDairesi.TabIndex = 15
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(381, 204)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl9.TabIndex = 76
        Me.LabelControl9.Text = "VergiDairesi:"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl18.Location = New System.Drawing.Point(421, 176)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl18.TabIndex = 73
        Me.LabelControl18.Text = "Yetkili:"
        '
        'txt_sEmail
        '
        Me.txt_sEmail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.E-Mail", True))
        Me.txt_sEmail.EnterMoveNextControl = True
        Me.txt_sEmail.Location = New System.Drawing.Point(482, 147)
        Me.txt_sEmail.Name = "txt_sEmail"
        Me.txt_sEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEmail.Properties.Appearance.Options.UseFont = True
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEmail.Size = New System.Drawing.Size(220, 28)
        Me.txt_sEmail.TabIndex = 12
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl32.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl32.Location = New System.Drawing.Point(426, 147)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl32.TabIndex = 55
        Me.LabelControl32.Text = "E-Mail:"
        '
        'txt_sGSM
        '
        Me.txt_sGSM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.Gsm", True))
        Me.txt_sGSM.EnterMoveNextControl = True
        Me.txt_sGSM.Location = New System.Drawing.Point(482, 119)
        Me.txt_sGSM.Name = "txt_sGSM"
        Me.txt_sGSM.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sGSM.Properties.Appearance.Options.UseFont = True
        Me.txt_sGSM.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sGSM.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sGSM.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sGSM.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sGSM.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sGSM.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sGSM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sGSM.Properties.Mask.SaveLiteral = False
        Me.txt_sGSM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sGSM.Properties.MaxLength = 20
        Me.txt_sGSM.Size = New System.Drawing.Size(220, 28)
        Me.txt_sGSM.TabIndex = 11
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl19.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl19.Location = New System.Drawing.Point(438, 119)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl19.TabIndex = 53
        Me.LabelControl19.Text = "Gsm:"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl22.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl22.Location = New System.Drawing.Point(413, 90)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl22.TabIndex = 51
        Me.LabelControl22.Text = "Telefon:"
        '
        'txt_sTelefon
        '
        Me.txt_sTelefon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.Telefon", True))
        Me.txt_sTelefon.EnterMoveNextControl = True
        Me.txt_sTelefon.Location = New System.Drawing.Point(482, 90)
        Me.txt_sTelefon.Name = "txt_sTelefon"
        Me.txt_sTelefon.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sTelefon.Properties.Appearance.Options.UseFont = True
        Me.txt_sTelefon.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sTelefon.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sTelefon.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sTelefon.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sTelefon.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sTelefon.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sTelefon.Properties.Mask.SaveLiteral = False
        Me.txt_sTelefon.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sTelefon.Properties.MaxLength = 20
        Me.txt_sTelefon.Size = New System.Drawing.Size(220, 28)
        Me.txt_sTelefon.TabIndex = 10
        '
        'txt_sAdres2
        '
        Me.txt_sAdres2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAdres2", True))
        Me.txt_sAdres2.EnterMoveNextControl = True
        Me.txt_sAdres2.Location = New System.Drawing.Point(109, 204)
        Me.txt_sAdres2.Name = "txt_sAdres2"
        Me.txt_sAdres2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sAdres2.Properties.Appearance.Options.UseFont = True
        Me.txt_sAdres2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdres2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdres2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdres2.Properties.MaxLength = 60
        Me.txt_sAdres2.Size = New System.Drawing.Size(272, 28)
        Me.txt_sAdres2.TabIndex = 7
        '
        'txt_sAdres1
        '
        Me.txt_sAdres1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAdres1", True))
        Me.txt_sAdres1.EnterMoveNextControl = True
        Me.txt_sAdres1.Location = New System.Drawing.Point(109, 176)
        Me.txt_sAdres1.Name = "txt_sAdres1"
        Me.txt_sAdres1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sAdres1.Properties.Appearance.Options.UseFont = True
        Me.txt_sAdres1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdres1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdres1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdres1.Properties.MaxLength = 60
        Me.txt_sAdres1.Size = New System.Drawing.Size(272, 28)
        Me.txt_sAdres1.TabIndex = 6
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl21.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl21.Location = New System.Drawing.Point(40, 176)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl21.TabIndex = 50
        Me.LabelControl21.Text = "Adres1:"
        '
        'txt_sAciklama
        '
        Me.txt_sAciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAciklama", True))
        Me.txt_sAciklama.EnterMoveNextControl = True
        Me.txt_sAciklama.Location = New System.Drawing.Point(109, 147)
        Me.txt_sAciklama.Name = "txt_sAciklama"
        Me.txt_sAciklama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sAciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sAciklama.Properties.Appearance.Options.UseFont = True
        Me.txt_sAciklama.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAciklama.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAciklama.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAciklama.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAciklama.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAciklama.Properties.MaxLength = 60
        Me.txt_sAciklama.Size = New System.Drawing.Size(272, 28)
        Me.txt_sAciklama.TabIndex = 4
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(70, 147)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl11.TabIndex = 45
        Me.LabelControl11.Text = "Adı:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(56, 119)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl8.TabIndex = 10
        Me.LabelControl8.Text = "Kodu:"
        '
        'txt_sKodu
        '
        Me.txt_sKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sKodu", True))
        Me.txt_sKodu.Location = New System.Drawing.Point(109, 119)
        Me.txt_sKodu.MenuManager = Me.BarManager1
        Me.txt_sKodu.Name = "txt_sKodu"
        Me.txt_sKodu.Size = New System.Drawing.Size(272, 26)
        Me.txt_sKodu.TabIndex = 3
        '
        'txt_dteKayitTarihi
        '
        Me.txt_dteKayitTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.dteKayitTarihi", True))
        Me.txt_dteKayitTarihi.EditValue = Nothing
        Me.txt_dteKayitTarihi.Location = New System.Drawing.Point(203, 90)
        Me.txt_dteKayitTarihi.MenuManager = Me.BarManager1
        Me.txt_dteKayitTarihi.Name = "txt_dteKayitTarihi"
        Me.txt_dteKayitTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteKayitTarihi.Properties.ReadOnly = True
        Me.txt_dteKayitTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteKayitTarihi.Size = New System.Drawing.Size(178, 26)
        Me.txt_dteKayitTarihi.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(56, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 19)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Kayıt:"
        '
        'txt_nFirmaID
        '
        Me.txt_nFirmaID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nFirmaID", True))
        Me.txt_nFirmaID.Location = New System.Drawing.Point(109, 90)
        Me.txt_nFirmaID.MenuManager = Me.BarManager1
        Me.txt_nFirmaID.Name = "txt_nFirmaID"
        Me.txt_nFirmaID.Size = New System.Drawing.Size(94, 26)
        Me.txt_nFirmaID.TabIndex = 1
        '
        'Panel_Ara
        '
        Me.Panel_Ara.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Ara.Appearance.Options.UseBackColor = True
        Me.Panel_Ara.Controls.Add(Me.btn_yenile)
        Me.Panel_Ara.Controls.Add(Me.SimpleButton3)
        Me.Panel_Ara.Controls.Add(Me.SimpleButton4)
        Me.Panel_Ara.Controls.Add(Me.SimpleButton2)
        Me.Panel_Ara.Controls.Add(Me.SimpleButton1)
        Me.Panel_Ara.Controls.Add(Me.lbl_istihbarat)
        Me.Panel_Ara.Controls.Add(Me.txt_musterino)
        Me.Panel_Ara.Controls.Add(Me.LabelControl4)
        Me.Panel_Ara.Controls.Add(Me.sec_bakiyeli)
        Me.Panel_Ara.Controls.Add(Me.lbl_musteri_adi)
        Me.Panel_Ara.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Ara.Location = New System.Drawing.Point(2, 2)
        Me.Panel_Ara.Name = "Panel_Ara"
        Me.Panel_Ara.Size = New System.Drawing.Size(538, 57)
        Me.Panel_Ara.TabIndex = 0
        '
        'btn_yenile
        '
        Me.btn_yenile.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_yenile.Appearance.Options.UseFont = True
        Me.btn_yenile.Appearance.Options.UseTextOptions = True
        Me.btn_yenile.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.btn_yenile.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_yenile.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.btn_yenile.Image = Global.business_smart.My.Resources.Resources.replace2
        Me.btn_yenile.Location = New System.Drawing.Point(315, 3)
        Me.btn_yenile.Name = "btn_yenile"
        Me.btn_yenile.Size = New System.Drawing.Size(39, 28)
        ToolTipTitleItem2.Text = "Yenile"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Hesap Kartında Bilgileri Yeniler"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btn_yenile.SuperTip = SuperToolTip2
        Me.btn_yenile.TabIndex = 40
        Me.btn_yenile.Text = "Y"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.SimpleButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.media_end
        Me.SimpleButton3.Location = New System.Drawing.Point(469, 3)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(38, 28)
        ToolTipTitleItem3.Text = "Son Kayıt"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "En Son Girilmiş Olan Müşteri Kaydını Ekrana Getirir"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.SimpleButton3.SuperTip = SuperToolTip3
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = ">I"
        Me.SimpleButton3.ToolTip = "Son Kayit"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseTextOptions = True
        Me.SimpleButton4.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.SimpleButton4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleButton4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SimpleButton4.Image = Global.business_smart.My.Resources.Resources.nav_right_blue
        Me.SimpleButton4.Location = New System.Drawing.Point(430, 3)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(39, 28)
        ToolTipTitleItem4.Text = "Sonraki Kayıt"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Bir Sonraki Müşteri Kaydını Ekrana Getirir"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.SimpleButton4.SuperTip = SuperToolTip4
        Me.SimpleButton4.TabIndex = 10
        Me.SimpleButton4.Text = ">"
        Me.SimpleButton4.ToolTip = "Sonraki"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.SimpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.nav_left_blue
        Me.SimpleButton2.Location = New System.Drawing.Point(392, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(38, 28)
        ToolTipTitleItem5.Text = "Önceki Kayıt"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Bir Önceki Müşteri Kaydını Ekrana Getirir"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.SimpleButton2.SuperTip = SuperToolTip5
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "<"
        Me.SimpleButton2.ToolTip = "Onceki"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.SimpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.media_beginning
        Me.SimpleButton1.Location = New System.Drawing.Point(354, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 28)
        ToolTipTitleItem6.Text = "Ilk Kayıt"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Ilk Müşteri Kaydını Ekrana Getirir"
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.SimpleButton1.SuperTip = SuperToolTip6
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "I<"
        Me.SimpleButton1.ToolTip = "Ilk Kayit"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(22, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(514, 17)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "*"
        '
        'txt_musterino
        '
        Me.txt_musterino.EditValue = "0"
        Me.txt_musterino.Location = New System.Drawing.Point(102, 3)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_musterino.Properties.Appearance.Options.UseFont = True
        Me.txt_musterino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musterino.Properties.NullText = "[MüşteriNo]"
        Me.txt_musterino.Size = New System.Drawing.Size(175, 30)
        ToolTipTitleItem7.Text = "Müşteri No"
        ToolTipItem7.LeftIndent = 6
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.txt_musterino.SuperTip = SuperToolTip7
        Me.txt_musterino.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(13, 7)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 19)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "KayıtNo:"
        '
        'sec_bakiyeli
        '
        Me.sec_bakiyeli.Location = New System.Drawing.Point(280, 6)
        Me.sec_bakiyeli.Name = "sec_bakiyeli"
        Me.sec_bakiyeli.Properties.Caption = ""
        Me.sec_bakiyeli.Size = New System.Drawing.Size(35, 19)
        ToolTipTitleItem8.Text = "Bakiyeli Müşteriler"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Sadece Bakiyeli Müşterilerin Ekrana Gelmesi ve Izlenmesi istenidiği zaman Bu Kutu" &
    "cuk İşaretlenir"
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.sec_bakiyeli.SuperTip = SuperToolTip8
        Me.sec_bakiyeli.TabIndex = 7
        '
        'lbl_musteri_adi
        '
        Me.lbl_musteri_adi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_musteri_adi.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_musteri_adi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_musteri_adi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_musteri_adi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_musteri_adi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_musteri_adi.Location = New System.Drawing.Point(2, 35)
        Me.lbl_musteri_adi.Name = "lbl_musteri_adi"
        Me.lbl_musteri_adi.Size = New System.Drawing.Size(534, 20)
        Me.lbl_musteri_adi.TabIndex = 39
        Me.lbl_musteri_adi.Text = "*"
        '
        'Panel_Taksitler
        '
        Me.Panel_Taksitler.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Taksitler.Appearance.Options.UseBackColor = True
        Me.Panel_Taksitler.Controls.Add(Me.GroupControl1)
        Me.Panel_Taksitler.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Taksitler.Location = New System.Drawing.Point(465, 302)
        Me.Panel_Taksitler.Name = "Panel_Taksitler"
        Me.Panel_Taksitler.Size = New System.Drawing.Size(79, 348)
        Me.Panel_Taksitler.TabIndex = 3
        Me.Panel_Taksitler.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl1.Controls.Add(Me.GridControl3)
        Me.GroupControl1.Controls.Add(Me.btn_Odemeler)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(75, 344)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Kalan Ödemeler"
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 23)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(71, 286)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteTarihi, Me.colKALAN, Me.colGEC, Me.colsYil})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition6.Appearance.BackColor = System.Drawing.Color.Black
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition6.Appearance.Options.UseBackColor = True
        StyleFormatCondition6.Appearance.Options.UseFont = True
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.ApplyToRow = True
        StyleFormatCondition6.Column = Me.colGEC
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition6.Value1 = "0"
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition6})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 30
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'coldteTarihi
        '
        Me.coldteTarihi.Caption = "Vade"
        Me.coldteTarihi.DisplayFormat.FormatString = "D"
        Me.coldteTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", "{0} Taksit")})
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 0
        Me.coldteTarihi.Width = 149
        '
        'colKALAN
        '
        Me.colKALAN.Caption = "Tutar"
        Me.colKALAN.DisplayFormat.FormatString = "#,0.00"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.00}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 1
        Me.colKALAN.Width = 80
        '
        'colsYil
        '
        Me.colsYil.Caption = "Yil"
        Me.colsYil.FieldName = "sYil"
        Me.colsYil.Name = "colsYil"
        '
        'btn_Odemeler
        '
        Me.btn_Odemeler.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.btn_Odemeler.Appearance.Options.UseForeColor = True
        Me.btn_Odemeler.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Odemeler.Location = New System.Drawing.Point(2, 309)
        Me.btn_Odemeler.Name = "btn_Odemeler"
        Me.btn_Odemeler.Size = New System.Drawing.Size(71, 33)
        Me.btn_Odemeler.TabIndex = 1
        Me.btn_Odemeler.Text = "Aylık"
        '
        'ds_sinif
        '
        Me.ds_sinif.DataSetName = "NewDataSet"
        Me.ds_sinif.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_sinif.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sSinifTipi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sSinifKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sAciklama"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "bSatisYapilamaz"
        Me.DataColumn5.DataType = GetType(Boolean)
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 302)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(463, 348)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Hesap Hareketleri"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 23)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(459, 323)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(457, 284)
        Me.XtraTabPage1.Text = "Hareketler"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_hareket
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_odemeler
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(457, 284)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_hareket
        '
        Me.kisayol_hareket.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem8, Me.MenuItem9, Me.MenuItem15, Me.MenuItem11, Me.MenuItem10, Me.MenuItem6, Me.MenuItem18, Me.MenuItem27, Me.MenuItem7, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26})
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem5.Text = "Hesap Seç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem8.Text = "Firma Kartı"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem9.Text = "Hesap Hareketleri"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem15.Text = "Stoklu Ekstre"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 4
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem11.Text = "Stok Hareketleri"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem10.Text = "Firma Bakiyesi"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem6.Text = "İletişim Bilgileri"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 7
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.ShiftF6
        Me.MenuItem18.Text = "Firma Stokları"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 8
        Me.MenuItem27.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 9
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlF9
        Me.MenuItem7.Text = "ÖzelNot Gir"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 10
        Me.MenuItem19.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 11
        Me.MenuItem20.Text = "Sonraki Kart"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 12
        Me.MenuItem21.Text = "Önceki Kart"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 13
        Me.MenuItem22.Text = "Son Kart"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 14
        Me.MenuItem23.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 15
        Me.MenuItem24.Text = "Hızlı Filtre"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 16
        Me.MenuItem25.Text = "Görünümü Düzenle"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 17
        Me.MenuItem26.Text = "Görünümü Kaydet"
        '
        'ds_odemeler
        '
        Me.ds_odemeler.DataSetName = "NewDataSet"
        Me.ds_odemeler.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_odemeler.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "nAlisVerisID"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nTaksitID"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteTarihi"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "lTutari"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "dteValorTarihi"
        Me.DataColumn10.DataType = GetType(Date)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lOdemeTutar"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "nGun"
        Me.DataColumn12.DataType = GetType(Long)
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFirmaKodu, Me.colsFirmaAciklama, Me.coldteIslemTarihi, Me.coldteValorTarihi, Me.colIslemAciklama, Me.collFisNo, Me.collBorcTutar, Me.collAlacakTutar, Me.colBakiye, Me.colsFirmaHarAciklama, Me.colsHareketTipi, Me.collDevirBorc, Me.collDevirAlacak, Me.collDevir, Me.colIslemTipi, Me.colnStokFisiID, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsDovizCinsi2, Me.collDovizMiktari2, Me.collDovizKuru2, Me.coldteKayitTarihi, Me.colsIslem, Me.colsOzelKod, Me.colsAciklama1, Me.colnEvrakNo})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(588, 444, 208, 154)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Nothing, "Borc: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Nothing, "Alacak: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Me.collBorcTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Me.collAlacakTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", Me.coldteIslemTarihi, "{0:#} Kayıt")})
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Hesap Kodu"
        Me.colsFirmaKodu.FieldName = "sFirmaKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        '
        'colsFirmaAciklama
        '
        Me.colsFirmaAciklama.Caption = "HesapAdı"
        Me.colsFirmaAciklama.FieldName = "sFirmaAciklama"
        Me.colsFirmaAciklama.Name = "colsFirmaAciklama"
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "Tarih"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", "{0} Kayıt")})
        Me.coldteIslemTarihi.Visible = True
        Me.coldteIslemTarihi.VisibleIndex = 0
        Me.coldteIslemTarihi.Width = 51
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Vade"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Visible = True
        Me.coldteValorTarihi.VisibleIndex = 1
        Me.coldteValorTarihi.Width = 55
        '
        'colIslemAciklama
        '
        Me.colIslemAciklama.Caption = "İşlem"
        Me.colIslemAciklama.FieldName = "IslemAciklama"
        Me.colIslemAciklama.Name = "colIslemAciklama"
        Me.colIslemAciklama.Width = 47
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiş No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 3
        Me.collFisNo.Width = 51
        '
        'collBorcTutar
        '
        Me.collBorcTutar.Caption = "Borç"
        Me.collBorcTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutar.FieldName = "lBorcTutar"
        Me.collBorcTutar.Name = "collBorcTutar"
        Me.collBorcTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00}")})
        Me.collBorcTutar.Visible = True
        Me.collBorcTutar.VisibleIndex = 6
        Me.collBorcTutar.Width = 52
        '
        'collAlacakTutar
        '
        Me.collAlacakTutar.Caption = "Alacak"
        Me.collAlacakTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutar.FieldName = "lAlacakTutar"
        Me.collAlacakTutar.Name = "collAlacakTutar"
        Me.collAlacakTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", "{0:#,0.00}")})
        Me.collAlacakTutar.Visible = True
        Me.collAlacakTutar.VisibleIndex = 7
        Me.collAlacakTutar.Width = 56
        '
        'colBakiye
        '
        Me.colBakiye.Caption = "Bakiye"
        Me.colBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBakiye.FieldName = "Bakiye"
        Me.colBakiye.Name = "colBakiye"
        Me.colBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bakiye", "{0:#,0.00}")})
        Me.colBakiye.Visible = True
        Me.colBakiye.VisibleIndex = 8
        Me.colBakiye.Width = 52
        '
        'colsFirmaHarAciklama
        '
        Me.colsFirmaHarAciklama.Caption = "Açıklama"
        Me.colsFirmaHarAciklama.FieldName = "sAciklama"
        Me.colsFirmaHarAciklama.Name = "colsFirmaHarAciklama"
        Me.colsFirmaHarAciklama.Visible = True
        Me.colsFirmaHarAciklama.VisibleIndex = 5
        Me.colsFirmaHarAciklama.Width = 111
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "HT"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Width = 73
        '
        'collDevirBorc
        '
        Me.collDevirBorc.Caption = "Devir Borc"
        Me.collDevirBorc.FieldName = "lDevirBorc"
        Me.collDevirBorc.Name = "collDevirBorc"
        '
        'collDevirAlacak
        '
        Me.collDevirAlacak.Caption = "Devir Alacak"
        Me.collDevirAlacak.FieldName = "lDevirAlacak"
        Me.collDevirAlacak.Name = "collDevirAlacak"
        '
        'collDevir
        '
        Me.collDevir.Caption = "Devir"
        Me.collDevir.FieldName = "lDevir"
        Me.collDevir.Name = "collDevir"
        '
        'colIslemTipi
        '
        Me.colIslemTipi.Caption = "İşlem Tipi"
        Me.colIslemTipi.FieldName = "IslemTipi"
        Me.colIslemTipi.Name = "colIslemTipi"
        Me.colIslemTipi.Width = 79
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Stok Fişi ID"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Pb"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        Me.colsDovizCinsi1.Visible = True
        Me.colsDovizCinsi1.VisibleIndex = 9
        Me.colsDovizCinsi1.Width = 37
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarı"
        Me.collDovizMiktari1.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        Me.collDovizMiktari1.Width = 69
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru"
        Me.collDovizKuru1.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizKuru1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        Me.collDovizKuru1.Width = 64
        '
        'colsDovizCinsi2
        '
        Me.colsDovizCinsi2.Caption = "Döviz Cinsi 2"
        Me.colsDovizCinsi2.FieldName = "sDovizCinsi2"
        Me.colsDovizCinsi2.Name = "colsDovizCinsi2"
        '
        'collDovizMiktari2
        '
        Me.collDovizMiktari2.Caption = "HTutar"
        Me.collDovizMiktari2.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizMiktari2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari2.FieldName = "lDovizMiktari2"
        Me.collDovizMiktari2.Name = "collDovizMiktari2"
        '
        'collDovizKuru2
        '
        Me.collDovizKuru2.Caption = "HKur"
        Me.collDovizKuru2.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizKuru2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru2.FieldName = "lDovizKuru2"
        Me.collDovizKuru2.Name = "collDovizKuru2"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colsIslem
        '
        Me.colsIslem.Caption = "İşlem"
        Me.colsIslem.FieldName = "sIslem"
        Me.colsIslem.Name = "colsIslem"
        Me.colsIslem.Visible = True
        Me.colsIslem.VisibleIndex = 2
        Me.colsIslem.Width = 57
        '
        'colsOzelKod
        '
        Me.colsOzelKod.Caption = "Not"
        Me.colsOzelKod.FieldName = "sNot"
        Me.colsOzelKod.Name = "colsOzelKod"
        Me.colsOzelKod.Visible = True
        Me.colsOzelKod.VisibleIndex = 10
        Me.colsOzelKod.Width = 63
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "ÖzelNot"
        Me.colsAciklama1.FieldName = "sAciklama1"
        Me.colsAciklama1.Name = "colsAciklama1"
        Me.colsAciklama1.Visible = True
        Me.colsAciklama1.VisibleIndex = 11
        '
        'colnEvrakNo
        '
        Me.colnEvrakNo.Caption = "Evrak No"
        Me.colnEvrakNo.FieldName = "EvrakNo"
        Me.colnEvrakNo.Name = "colnEvrakNo"
        Me.colnEvrakNo.Visible = True
        Me.colnEvrakNo.VisibleIndex = 4
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(457, 284)
        Me.XtraTabPage2.Text = "Bakiye"
        '
        'GridControl4
        '
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(457, 284)
        Me.GridControl4.TabIndex = 1
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.GridColumn9
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.GridColumn9
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView4.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.IndicatorWidth = 12
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsDetail.ShowDetailTabs = False
        Me.GridView4.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Doviz"
        Me.GridColumn6.FieldName = "sDovizCinsi1"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Borç"
        Me.GridColumn7.DisplayFormat.FormatString = "#,0.00##"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "lBorcTutar"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Alacak"
        Me.GridColumn8.DisplayFormat.FormatString = "#,0.00##"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "lAlacakTutar"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl1)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(457, 284)
        Me.XtraTabPage3.Text = "Siparişler"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_siparis
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 81)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(457, 203)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_siparis
        '
        Me.kisayol_siparis.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem29, Me.MenuItem3, Me.MenuItem4, Me.MenuItem31, Me.MenuItem32, Me.MenuItem2, Me.MenuItem16, Me.MenuItem1, Me.MenuItem14, Me.MenuItem17, Me.MenuItem12, Me.MenuItem13, Me.MenuItem30})
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Text = "Siparişi Göster"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 1
        Me.MenuItem29.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Siparişi Kapat"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        Me.MenuItem31.Text = "Siparişleri Birleştir"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 5
        Me.MenuItem32.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem2.Text = "Envanter"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 7
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem16.Text = "Stok Hareketleri"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 8
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem1.Text = "Stok Fiyatları"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 9
        Me.MenuItem14.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 10
        Me.MenuItem17.Text = "Hızlı Filtre"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 11
        Me.MenuItem12.Text = "Görünümü Düzenle"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 12
        Me.MenuItem13.Text = "Görünümü Kaydet"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 13
        Me.MenuItem30.Text = "Görünümü Yazdır"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colsFirmaAdi, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsKavala, Me.colsAciklama, Me.colsSatirAciklama, Me.coldteIlkSevkiyatTarihi, Me.colsBirimCinsi, Me.colsSipNo, Me.coldteSiparisTarihi, Me.coldteTeslimTarihi, Me.colsSiparisIslem, Me.colSiparisMiktari, Me.colSiparisTutari, Me.colSiparisTutari1, Me.colSiparisTutari2, Me.collSevkMiktari, Me.collSevkTutari, Me.collKalanMiktar, Me.collKalanTutar, Me.colsPartiKodu, Me.collGirisMiktar, Me.collGirisTutar, Me.collEnvanterMiktar, Me.collEnvanterTutar, Me.collFarkMiktar, Me.collFarkTutar, Me.collKrediLimiti, Me.colnValorGun, Me.colbKapandimi, Me.collBirimFiyati, Me.colsDovizCinsi, Me.collDovizKuru, Me.collDovizFiyati, Me.collSevkIadeMiktari, Me.collBakiye, Me.collToplamRisk, Me.collBirimFiyati1, Me.collBirimFiyati2, Me.collMevcut})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(493, 378, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaKodu", Nothing, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", Nothing, "SiparisMiktari : {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", Nothing, "SevkMiktari {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", Nothing, "KalanMiktar: {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sModel", Me.colsModel, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", Me.colSiparisMiktari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", Me.collSevkMiktari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", Me.collKalanMiktar, "{0:#,0.00}")})
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Firma Kodu"
        Me.GridColumn1.FieldName = "sFirmaKodu"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colsFirmaAdi
        '
        Me.colsFirmaAdi.Caption = "Firma Adı"
        Me.colsFirmaAdi.FieldName = "sFirmaAdi"
        Me.colsFirmaAdi.Name = "colsFirmaAdi"
        Me.colsFirmaAdi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaAdi", "{0} Kayıt")})
        Me.colsFirmaAdi.Visible = True
        Me.colsFirmaAdi.VisibleIndex = 0
        '
        'colsModel
        '
        Me.colsModel.Caption = "Stok Kodu"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        Me.colsModel.Visible = True
        Me.colsModel.VisibleIndex = 1
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk Adı"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 3
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
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adı"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colsSatirAciklama
        '
        Me.colsSatirAciklama.Caption = "Açıklama"
        Me.colsSatirAciklama.FieldName = "sSatirAciklama"
        Me.colsSatirAciklama.Name = "colsSatirAciklama"
        '
        'coldteIlkSevkiyatTarihi
        '
        Me.coldteIlkSevkiyatTarihi.Caption = "İlk Sevkiyat Tarihi"
        Me.coldteIlkSevkiyatTarihi.FieldName = "dteIlkSevkiyatTarihi"
        Me.coldteIlkSevkiyatTarihi.Name = "coldteIlkSevkiyatTarihi"
        '
        'colsBirimCinsi
        '
        Me.colsBirimCinsi.Caption = "Birim"
        Me.colsBirimCinsi.FieldName = "sBirimCinsi"
        Me.colsBirimCinsi.Name = "colsBirimCinsi"
        '
        'colsSipNo
        '
        Me.colsSipNo.Caption = "Sipariş No"
        Me.colsSipNo.FieldName = "sSipNo"
        Me.colsSipNo.Name = "colsSipNo"
        Me.colsSipNo.Visible = True
        Me.colsSipNo.VisibleIndex = 4
        '
        'coldteSiparisTarihi
        '
        Me.coldteSiparisTarihi.Caption = "Sipariş Tarihi"
        Me.coldteSiparisTarihi.FieldName = "dteSiparisTarihi"
        Me.coldteSiparisTarihi.Name = "coldteSiparisTarihi"
        Me.coldteSiparisTarihi.Visible = True
        Me.coldteSiparisTarihi.VisibleIndex = 5
        '
        'coldteTeslimTarihi
        '
        Me.coldteTeslimTarihi.Caption = "Teslim Tarihi"
        Me.coldteTeslimTarihi.FieldName = "dteTeslimtarihi"
        Me.coldteTeslimTarihi.Name = "coldteTeslimTarihi"
        Me.coldteTeslimTarihi.Visible = True
        Me.coldteTeslimTarihi.VisibleIndex = 6
        '
        'colsSiparisIslem
        '
        Me.colsSiparisIslem.Caption = "Sipariş İşlem"
        Me.colsSiparisIslem.FieldName = "sSiparisIslem"
        Me.colsSiparisIslem.Name = "colsSiparisIslem"
        '
        'colSiparisMiktari
        '
        Me.colSiparisMiktari.Caption = "Miktar"
        Me.colSiparisMiktari.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisMiktari.FieldName = "SiparisMiktari"
        Me.colSiparisMiktari.Name = "colSiparisMiktari"
        Me.colSiparisMiktari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", "{0:#,0.00}")})
        Me.colSiparisMiktari.Visible = True
        Me.colSiparisMiktari.VisibleIndex = 7
        '
        'colSiparisTutari
        '
        Me.colSiparisTutari.Caption = "Sipariş Tutarı"
        Me.colSiparisTutari.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari.FieldName = "SiparisTutari"
        Me.colSiparisTutari.Name = "colSiparisTutari"
        Me.colSiparisTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisTutari", "{0:#,0.00}")})
        '
        'colSiparisTutari1
        '
        Me.colSiparisTutari1.Caption = "Sipariş Tutarı 1"
        Me.colSiparisTutari1.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari1.FieldName = "SiparisTutari1"
        Me.colSiparisTutari1.Name = "colSiparisTutari1"
        '
        'colSiparisTutari2
        '
        Me.colSiparisTutari2.Caption = "Sipariş Tutarı 2"
        Me.colSiparisTutari2.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari2.FieldName = "SiparisTutari2"
        Me.colSiparisTutari2.Name = "colSiparisTutari2"
        '
        'collSevkMiktari
        '
        Me.collSevkMiktari.Caption = "Gelen/Giden"
        Me.collSevkMiktari.DisplayFormat.FormatString = "#,0.00"
        Me.collSevkMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkMiktari.FieldName = "lSevkMiktari"
        Me.collSevkMiktari.Name = "collSevkMiktari"
        Me.collSevkMiktari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", "{0:#,0.00}")})
        Me.collSevkMiktari.Visible = True
        Me.collSevkMiktari.VisibleIndex = 8
        '
        'collSevkTutari
        '
        Me.collSevkTutari.Caption = "Sevk Tutarı"
        Me.collSevkTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collSevkTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkTutari.FieldName = "lSevkTutari"
        Me.collSevkTutari.Name = "collSevkTutari"
        '
        'collKalanMiktar
        '
        Me.collKalanMiktar.Caption = "Kalan"
        Me.collKalanMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collKalanMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalanMiktar.FieldName = "lKalanMiktar"
        Me.collKalanMiktar.Name = "collKalanMiktar"
        Me.collKalanMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", "{0:#,0.00}")})
        Me.collKalanMiktar.Visible = True
        Me.collKalanMiktar.VisibleIndex = 9
        '
        'collKalanTutar
        '
        Me.collKalanTutar.Caption = "Kalan Tutar"
        Me.collKalanTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collKalanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalanTutar.FieldName = "lKalanTutar"
        Me.collKalanTutar.Name = "collKalanTutar"
        '
        'colsPartiKodu
        '
        Me.colsPartiKodu.Caption = "Parti Kodu"
        Me.colsPartiKodu.FieldName = "sPartiKodu"
        Me.colsPartiKodu.Name = "colsPartiKodu"
        '
        'collGirisMiktar
        '
        Me.collGirisMiktar.Caption = "Giriş Miktarı"
        Me.collGirisMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar.FieldName = "lGirisMiktar"
        Me.collGirisMiktar.Name = "collGirisMiktar"
        '
        'collGirisTutar
        '
        Me.collGirisTutar.Caption = "Giriş Tutarı"
        Me.collGirisTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisTutar.FieldName = "lGirisTutar"
        Me.collGirisTutar.Name = "collGirisTutar"
        '
        'collEnvanterMiktar
        '
        Me.collEnvanterMiktar.Caption = "Envanter Miktarı"
        Me.collEnvanterMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collEnvanterMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEnvanterMiktar.FieldName = "lEnvanterMiktar"
        Me.collEnvanterMiktar.Name = "collEnvanterMiktar"
        '
        'collEnvanterTutar
        '
        Me.collEnvanterTutar.Caption = "Envanter Tutarı"
        Me.collEnvanterTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collEnvanterTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEnvanterTutar.FieldName = "lEnvanterTutar"
        Me.collEnvanterTutar.Name = "collEnvanterTutar"
        '
        'collFarkMiktar
        '
        Me.collFarkMiktar.Caption = "Fark Miktarı"
        Me.collFarkMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collFarkMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFarkMiktar.FieldName = "lFarkMiktar"
        Me.collFarkMiktar.Name = "collFarkMiktar"
        '
        'collFarkTutar
        '
        Me.collFarkTutar.Caption = "Fark Tutarı"
        Me.collFarkTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collFarkTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFarkTutar.FieldName = "lFarkTutar"
        Me.collFarkTutar.Name = "collFarkTutar"
        '
        'collKrediLimiti
        '
        Me.collKrediLimiti.Caption = "Kredi Limiti"
        Me.collKrediLimiti.DisplayFormat.FormatString = "#,0.00"
        Me.collKrediLimiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKrediLimiti.FieldName = "lKrediLimiti"
        Me.collKrediLimiti.Name = "collKrediLimiti"
        '
        'colnValorGun
        '
        Me.colnValorGun.Caption = "ValorGun"
        Me.colnValorGun.DisplayFormat.FormatString = "#,0.00"
        Me.colnValorGun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnValorGun.FieldName = "nValorGun"
        Me.colnValorGun.Name = "colnValorGun"
        '
        'colbKapandimi
        '
        Me.colbKapandimi.Caption = "Kapandımı"
        Me.colbKapandimi.FieldName = "bKapandimi"
        Me.colbKapandimi.Name = "colbKapandimi"
        '
        'collBirimFiyati
        '
        Me.collBirimFiyati.Caption = "Birim Fiyatı"
        Me.collBirimFiyati.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati.FieldName = "lBirimFiyati"
        Me.collBirimFiyati.Name = "collBirimFiyati"
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi.DisplayFormat.FormatString = "#,0.00"
        Me.colsDovizCinsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'collDovizKuru
        '
        Me.collDovizKuru.Caption = "Döviz Kuru"
        Me.collDovizKuru.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizKuru.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru.FieldName = "lDovizKuru"
        Me.collDovizKuru.Name = "collDovizKuru"
        '
        'collDovizFiyati
        '
        Me.collDovizFiyati.Caption = "Döviz Fiyatı"
        Me.collDovizFiyati.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizFiyati.FieldName = "lDovizFiyati"
        Me.collDovizFiyati.Name = "collDovizFiyati"
        '
        'collSevkIadeMiktari
        '
        Me.collSevkIadeMiktari.Caption = "Sevk İade Miktari"
        Me.collSevkIadeMiktari.DisplayFormat.FormatString = "#,0.00"
        Me.collSevkIadeMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkIadeMiktari.FieldName = "lSevkIadeMiktari"
        Me.collSevkIadeMiktari.Name = "collSevkIadeMiktari"
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        '
        'collToplamRisk
        '
        Me.collToplamRisk.Caption = "Toplam Risk"
        Me.collToplamRisk.DisplayFormat.FormatString = "#,0.00"
        Me.collToplamRisk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamRisk.FieldName = "lToplamRisk"
        Me.collToplamRisk.Name = "collToplamRisk"
        '
        'collBirimFiyati1
        '
        Me.collBirimFiyati1.Caption = "Birim Fiyatı 1"
        Me.collBirimFiyati1.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati1.FieldName = "lBirimFiyati1"
        Me.collBirimFiyati1.Name = "collBirimFiyati1"
        '
        'collBirimFiyati2
        '
        Me.collBirimFiyati2.Caption = "Birim Fiyatı 2"
        Me.collBirimFiyati2.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati2.FieldName = "lBirimFiyati2"
        Me.collBirimFiyati2.Name = "collBirimFiyati2"
        '
        'collMevcut
        '
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,0.##"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        Me.collMevcut.Visible = True
        Me.collMevcut.VisibleIndex = 10
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.SimpleButton28)
        Me.PanelControl5.Controls.Add(Me.SimpleButton22)
        Me.PanelControl5.Controls.Add(Me.SimpleButton21)
        Me.PanelControl5.Controls.Add(Me.Label40)
        Me.PanelControl5.Controls.Add(Me.sec_sSiparisTipi)
        Me.PanelControl5.Controls.Add(Me.sec_kriter)
        Me.PanelControl5.Controls.Add(Me.Label39)
        Me.PanelControl5.Controls.Add(Me.SimpleButton19)
        Me.PanelControl5.Controls.Add(Me.sec_ekstre_tarih2)
        Me.PanelControl5.Controls.Add(Me.sec_ekstre_tarih1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(457, 81)
        Me.PanelControl5.TabIndex = 1
        '
        'SimpleButton28
        '
        Me.SimpleButton28.Image = Global.business_smart.My.Resources.Resources.help
        Me.SimpleButton28.Location = New System.Drawing.Point(323, 50)
        Me.SimpleButton28.Name = "SimpleButton28"
        Me.SimpleButton28.Size = New System.Drawing.Size(141, 31)
        Me.SimpleButton28.TabIndex = 34
        Me.SimpleButton28.Text = "Birleştir"
        '
        'SimpleButton22
        '
        Me.SimpleButton22.Image = Global.business_smart.My.Resources.Resources.help
        Me.SimpleButton22.Location = New System.Drawing.Point(173, 50)
        Me.SimpleButton22.Name = "SimpleButton22"
        Me.SimpleButton22.Size = New System.Drawing.Size(141, 31)
        Me.SimpleButton22.TabIndex = 33
        Me.SimpleButton22.Text = "&Hareketler"
        '
        'SimpleButton21
        '
        Me.SimpleButton21.Image = Global.business_smart.My.Resources.Resources.help
        Me.SimpleButton21.Location = New System.Drawing.Point(26, 50)
        Me.SimpleButton21.Name = "SimpleButton21"
        Me.SimpleButton21.Size = New System.Drawing.Size(140, 31)
        Me.SimpleButton21.TabIndex = 32
        Me.SimpleButton21.Text = "&Envanter"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(389, 13)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(138, 19)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Tarihleri Arasındaki"
        '
        'sec_sSiparisTipi
        '
        Me.sec_sSiparisTipi.EditValue = "Alınan"
        Me.sec_sSiparisTipi.Location = New System.Drawing.Point(693, 13)
        Me.sec_sSiparisTipi.Name = "sec_sSiparisTipi"
        Me.sec_sSiparisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSiparisTipi.Properties.Items.AddRange(New Object() {"Alınan", "Verilen"})
        Me.sec_sSiparisTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sSiparisTipi.Size = New System.Drawing.Size(115, 26)
        Me.sec_sSiparisTipi.TabIndex = 29
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Açık"
        Me.sec_kriter.Location = New System.Drawing.Point(565, 13)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"[Tümü]", "Açık", "Kapalı"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(128, 26)
        Me.sec_kriter.TabIndex = 28
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(179, 13)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(16, 19)
        Me.Label39.TabIndex = 27
        Me.Label39.Text = "ve"
        '
        'SimpleButton19
        '
        Me.SimpleButton19.Image = CType(resources.GetObject("SimpleButton19.Image"), System.Drawing.Image)
        Me.SimpleButton19.Location = New System.Drawing.Point(808, 13)
        Me.SimpleButton19.Name = "SimpleButton19"
        Me.SimpleButton19.Size = New System.Drawing.Size(120, 31)
        Me.SimpleButton19.TabIndex = 30
        Me.SimpleButton19.Text = "&Listele"
        '
        'sec_ekstre_tarih2
        '
        Me.sec_ekstre_tarih2.EditValue = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.sec_ekstre_tarih2.EnterMoveNextControl = True
        Me.sec_ekstre_tarih2.Location = New System.Drawing.Point(230, 13)
        Me.sec_ekstre_tarih2.Name = "sec_ekstre_tarih2"
        Me.sec_ekstre_tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih2.Size = New System.Drawing.Size(154, 26)
        Me.sec_ekstre_tarih2.TabIndex = 24
        '
        'sec_ekstre_tarih1
        '
        Me.sec_ekstre_tarih1.EditValue = New Date(2007, 2, 1, 0, 0, 0, 0)
        Me.sec_ekstre_tarih1.EnterMoveNextControl = True
        Me.sec_ekstre_tarih1.Location = New System.Drawing.Point(26, 13)
        Me.sec_ekstre_tarih1.Name = "sec_ekstre_tarih1"
        Me.sec_ekstre_tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih1.Size = New System.Drawing.Size(140, 26)
        Me.sec_ekstre_tarih1.TabIndex = 23
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridControl5)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(457, 284)
        Me.XtraTabPage4.Text = "İrsaliyeler"
        '
        'GridControl5
        '
        Me.GridControl5.DataMember = "Table1"
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(0, 81)
        Me.GridControl5.MainView = Me.GridView5
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(457, 203)
        Me.GridControl5.TabIndex = 3
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteFisTarihi, Me.GridColumn2, Me.colnGirisCikis, Me.collToplamMiktar, Me.collNetTutar, Me.colsDepo, Me.colDepo, Me.colsKodu, Me.GridColumn3, Me.colsTransferDepo, Me.coltDepo, Me.colsFaturalasti, Me.colMuhasebelesti, Me.GridColumn4, Me.colsNot, Me.colTamamlandi, Me.collTevkifatKdvMatrahi, Me.collTevkifatKdv, Me.colHizmet, Me.colnFirmaID, Me.colsFisTipi, Me.GridColumn5, Me.colKdvTutari, Me.colKdvMatrahi, Me.collMalIskontoTutari, Me.collMalBedeli, Me.colEkMaliyet, Me.colISKONTO, Me.colEkOran, Me.colbPesinmi})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(796, 271, 208, 156)
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colbPesinmi
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Tag = True
        StyleFormatCondition3.Value1 = True
        Me.GridView5.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.GridView5.GridControl = Me.GridControl5
        Me.GridView5.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView5.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView5.OptionsNavigation.UseTabKey = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Tarih"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", "{0} Kayıt")})
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 0
        Me.coldteFisTarihi.Width = 65
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fiş No"
        Me.GridColumn2.FieldName = "lFisNo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 51
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriş/Çıkış"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Visible = True
        Me.colnGirisCikis.VisibleIndex = 3
        Me.colnGirisCikis.Width = 61
        '
        'collToplamMiktar
        '
        Me.collToplamMiktar.Caption = "Miktar"
        Me.collToplamMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collToplamMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamMiktar.FieldName = "lToplamMiktar"
        Me.collToplamMiktar.Name = "collToplamMiktar"
        Me.collToplamMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamMiktar", "{0:#,0.00}")})
        Me.collToplamMiktar.Visible = True
        Me.collToplamMiktar.VisibleIndex = 4
        Me.collToplamMiktar.Width = 53
        '
        'collNetTutar
        '
        Me.collNetTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collNetTutar.AppearanceCell.Options.UseFont = True
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 11
        Me.collNetTutar.Width = 65
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "DepoKodu"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colDepo
        '
        Me.colDepo.Caption = "DepoAdı"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Firma Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Width = 142
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Firma Adı"
        Me.GridColumn3.FieldName = "sAciklama"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Width = 147
        '
        'colsTransferDepo
        '
        Me.colsTransferDepo.Caption = "Transfer Depo"
        Me.colsTransferDepo.FieldName = "sTransferDepo"
        Me.colsTransferDepo.Name = "colsTransferDepo"
        '
        'coltDepo
        '
        Me.coltDepo.Caption = "Transfer Depo Adı"
        Me.coltDepo.FieldName = "tDepo"
        Me.coltDepo.Name = "coltDepo"
        '
        'colsFaturalasti
        '
        Me.colsFaturalasti.Caption = "Faturalaştı ?"
        Me.colsFaturalasti.FieldName = "sFaturalasti"
        Me.colsFaturalasti.Name = "colsFaturalasti"
        '
        'colMuhasebelesti
        '
        Me.colMuhasebelesti.Caption = "Muhasebeleşti"
        Me.colMuhasebelesti.FieldName = "Muhasebelesti"
        Me.colMuhasebelesti.Name = "colMuhasebelesti"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Hareket Tipi"
        Me.GridColumn4.FieldName = "sHareketTipi"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 67
        '
        'colsNot
        '
        Me.colsNot.Caption = "Notlar"
        Me.colsNot.FieldName = "sNot"
        Me.colsNot.Name = "colsNot"
        Me.colsNot.Visible = True
        Me.colsNot.VisibleIndex = 12
        Me.colsNot.Width = 255
        '
        'colTamamlandi
        '
        Me.colTamamlandi.Caption = "Tamamlandi?"
        Me.colTamamlandi.FieldName = "Tamamlandi"
        Me.colTamamlandi.Name = "colTamamlandi"
        Me.colTamamlandi.Width = 82
        '
        'collTevkifatKdvMatrahi
        '
        Me.collTevkifatKdvMatrahi.Caption = "Tevkifat Kdv Matrahı"
        Me.collTevkifatKdvMatrahi.FieldName = "lTevkifatKdvMatrahi"
        Me.collTevkifatKdvMatrahi.Name = "collTevkifatKdvMatrahi"
        '
        'collTevkifatKdv
        '
        Me.collTevkifatKdv.Caption = "Tevkifat Kdv"
        Me.collTevkifatKdv.FieldName = "lTevkifatKdv"
        Me.collTevkifatKdv.Name = "collTevkifatKdv"
        '
        'colHizmet
        '
        Me.colHizmet.Caption = "Hizmet?"
        Me.colHizmet.FieldName = "Hizmet"
        Me.colHizmet.Name = "colHizmet"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 1
        Me.colsFisTipi.Width = 49
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Kayıt No"
        Me.GridColumn5.FieldName = "nStokFisiID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'colKdvTutari
        '
        Me.colKdvTutari.Caption = "Kdv Tutarı"
        Me.colKdvTutari.DisplayFormat.FormatString = "#,#.##"
        Me.colKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvTutari.FieldName = "KdvTutari"
        Me.colKdvTutari.Name = "colKdvTutari"
        Me.colKdvTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvTutari", "{0:#,0.00}")})
        Me.colKdvTutari.Visible = True
        Me.colKdvTutari.VisibleIndex = 8
        Me.colKdvTutari.Width = 56
        '
        'colKdvMatrahi
        '
        Me.colKdvMatrahi.Caption = "Kdv Matrahı"
        Me.colKdvMatrahi.DisplayFormat.FormatString = "#,0.00"
        Me.colKdvMatrahi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvMatrahi.FieldName = "KdvMatrahi"
        Me.colKdvMatrahi.Name = "colKdvMatrahi"
        Me.colKdvMatrahi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvMatrahi", "{0:#,0.00}")})
        '
        'collMalIskontoTutari
        '
        Me.collMalIskontoTutari.Caption = "İskonto"
        Me.collMalIskontoTutari.DisplayFormat.FormatString = "#,#.##"
        Me.collMalIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalIskontoTutari.FieldName = "lIskontoTutari"
        Me.collMalIskontoTutari.Name = "collMalIskontoTutari"
        Me.collMalIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalIskontoTutari", "{0:#,0.00}")})
        Me.collMalIskontoTutari.Visible = True
        Me.collMalIskontoTutari.VisibleIndex = 6
        '
        'collMalBedeli
        '
        Me.collMalBedeli.Caption = "Brüt"
        Me.collMalBedeli.DisplayFormat.FormatString = "#,0.00"
        Me.collMalBedeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalBedeli.FieldName = "lMalBedeli"
        Me.collMalBedeli.Name = "collMalBedeli"
        Me.collMalBedeli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalBedeli", "{0:#,0.00}")})
        Me.collMalBedeli.Visible = True
        Me.collMalBedeli.VisibleIndex = 5
        Me.collMalBedeli.Width = 60
        '
        'colEkMaliyet
        '
        Me.colEkMaliyet.Caption = "Ek Maliyet"
        Me.colEkMaliyet.DisplayFormat.FormatString = "#,#.##"
        Me.colEkMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkMaliyet.FieldName = "EkMaliyet"
        Me.colEkMaliyet.Name = "colEkMaliyet"
        Me.colEkMaliyet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EkMaliyet", "{0:#,0.00}")})
        Me.colEkMaliyet.Visible = True
        Me.colEkMaliyet.VisibleIndex = 9
        Me.colEkMaliyet.Width = 56
        '
        'colISKONTO
        '
        Me.colISKONTO.Caption = "% İsk."
        Me.colISKONTO.DisplayFormat.FormatString = "P"
        Me.colISKONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISKONTO.FieldName = "ISKONTO"
        Me.colISKONTO.Name = "colISKONTO"
        Me.colISKONTO.Visible = True
        Me.colISKONTO.VisibleIndex = 7
        Me.colISKONTO.Width = 56
        '
        'colEkOran
        '
        Me.colEkOran.Caption = "% Ek Oran"
        Me.colEkOran.DisplayFormat.FormatString = "P"
        Me.colEkOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkOran.FieldName = "EkOran"
        Me.colEkOran.Name = "colEkOran"
        Me.colEkOran.Visible = True
        Me.colEkOran.VisibleIndex = 10
        Me.colEkOran.Width = 56
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.SimpleButton23)
        Me.PanelControl7.Controls.Add(Me.sec_sIrsaliyeTipi)
        Me.PanelControl7.Controls.Add(Me.sec_irsaliye_kriter)
        Me.PanelControl7.Controls.Add(Me.Label5)
        Me.PanelControl7.Controls.Add(Me.SimpleButton20)
        Me.PanelControl7.Controls.Add(Me.Label6)
        Me.PanelControl7.Controls.Add(Me.DateEdit2)
        Me.PanelControl7.Controls.Add(Me.DateEdit3)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(457, 81)
        Me.PanelControl7.TabIndex = 2
        '
        'SimpleButton23
        '
        Me.SimpleButton23.Image = Global.business_smart.My.Resources.Resources.help
        Me.SimpleButton23.Location = New System.Drawing.Point(26, 46)
        Me.SimpleButton23.Name = "SimpleButton23"
        Me.SimpleButton23.Size = New System.Drawing.Size(140, 31)
        Me.SimpleButton23.TabIndex = 34
        Me.SimpleButton23.Text = "&Faturalastir"
        '
        'sec_sIrsaliyeTipi
        '
        Me.sec_sIrsaliyeTipi.EditValue = "Alış"
        Me.sec_sIrsaliyeTipi.Location = New System.Drawing.Point(691, 13)
        Me.sec_sIrsaliyeTipi.Name = "sec_sIrsaliyeTipi"
        Me.sec_sIrsaliyeTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sIrsaliyeTipi.Properties.Items.AddRange(New Object() {"Alış", "Satış"})
        Me.sec_sIrsaliyeTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sIrsaliyeTipi.Size = New System.Drawing.Size(115, 26)
        Me.sec_sIrsaliyeTipi.TabIndex = 29
        '
        'sec_irsaliye_kriter
        '
        Me.sec_irsaliye_kriter.EditValue = "Açık"
        Me.sec_irsaliye_kriter.Location = New System.Drawing.Point(563, 13)
        Me.sec_irsaliye_kriter.Name = "sec_irsaliye_kriter"
        Me.sec_irsaliye_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_irsaliye_kriter.Properties.Items.AddRange(New Object() {"[Tümü]", "Açık", "Kapalı"})
        Me.sec_irsaliye_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_irsaliye_kriter.Size = New System.Drawing.Size(128, 26)
        Me.sec_irsaliye_kriter.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(179, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ve"
        '
        'SimpleButton20
        '
        Me.SimpleButton20.Image = CType(resources.GetObject("SimpleButton20.Image"), System.Drawing.Image)
        Me.SimpleButton20.Location = New System.Drawing.Point(806, 13)
        Me.SimpleButton20.Name = "SimpleButton20"
        Me.SimpleButton20.Size = New System.Drawing.Size(114, 33)
        Me.SimpleButton20.TabIndex = 30
        Me.SimpleButton20.Text = "&Listele"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(390, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tarihleri Arasındaki"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(230, 13)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(154, 26)
        Me.DateEdit2.TabIndex = 24
        '
        'DateEdit3
        '
        Me.DateEdit3.EditValue = New Date(2007, 2, 1, 0, 0, 0, 0)
        Me.DateEdit3.EnterMoveNextControl = True
        Me.DateEdit3.Location = New System.Drawing.Point(26, 13)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit3.Size = New System.Drawing.Size(140, 26)
        Me.DateEdit3.TabIndex = 23
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Appearance.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabPage5.Appearance.Header.Options.UseForeColor = True
        Me.XtraTabPage5.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabPage5.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage5.Controls.Add(Me.PanelControl3)
        Me.XtraTabPage5.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage5.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(457, 284)
        Me.XtraTabPage5.Text = "Görevler"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl6)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 53)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(457, 178)
        Me.PanelControl3.TabIndex = 2
        '
        'GridControl6
        '
        Me.GridControl6.DataMember = "Table1"
        Me.GridControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl6.Location = New System.Drawing.Point(2, 2)
        Me.GridControl6.MainView = Me.GridView6
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_gorev_personel})
        Me.GridControl6.Size = New System.Drawing.Size(453, 174)
        Me.GridControl6.TabIndex = 2
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colFirmaTipi, Me.colFirmaNo, Me.colPersonelNo, Me.colStatus, Me.colSubject, Me.colDescription, Me.colLabel, Me.colStartTime, Me.colEndTime, Me.colLocation, Me.colAllDay, Me.colEventType, Me.colRecurrenceInfo, Me.colReminderInfo, Me.colTutar, Me.colPb, Me.colOdendi, Me.GridColumn10, Me.colPersonel, Me.colHesap, Me.colGelecekmi, Me.colEski})
        Me.GridView6.DetailHeight = 160
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colEski
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Tag = True
        StyleFormatCondition4.Value1 = True
        StyleFormatCondition5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition5.Appearance.Options.UseFont = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.GridColumn10
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Tag = True
        StyleFormatCondition5.Value1 = True
        Me.GridView6.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition4, StyleFormatCondition5})
        Me.GridView6.GridControl = Me.GridControl6
        Me.GridView6.GroupFormat = "{0}: {1} {2}"
        Me.GridView6.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
        Me.GridView6.IndicatorWidth = 35
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsDetail.ShowDetailTabs = False
        Me.GridView6.OptionsSelection.MultiSelect = True
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "Kayıt No"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 69
        '
        'colFirmaTipi
        '
        Me.colFirmaTipi.Caption = "FirmaTipi"
        Me.colFirmaTipi.FieldName = "FirmaTipi"
        Me.colFirmaTipi.Name = "colFirmaTipi"
        '
        'colFirmaNo
        '
        Me.colFirmaNo.Caption = "Firma No"
        Me.colFirmaNo.FieldName = "FirmaNo"
        Me.colFirmaNo.Name = "colFirmaNo"
        '
        'colPersonelNo
        '
        Me.colPersonelNo.Caption = "PersonelNo"
        Me.colPersonelNo.FieldName = "PersonelNo"
        Me.colPersonelNo.Name = "colPersonelNo"
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colSubject
        '
        Me.colSubject.Caption = "Konu"
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Subject", "{0} Kayt")})
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 1
        Me.colSubject.Width = 61
        '
        'colDescription
        '
        Me.colDescription.Caption = "Açıklama"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        Me.colDescription.Width = 116
        '
        'colLabel
        '
        Me.colLabel.Caption = "Etiket"
        Me.colLabel.FieldName = "Label"
        Me.colLabel.Name = "colLabel"
        Me.colLabel.Visible = True
        Me.colLabel.VisibleIndex = 0
        Me.colLabel.Width = 33
        '
        'colStartTime
        '
        Me.colStartTime.Caption = "Başlama"
        Me.colStartTime.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm"
        Me.colStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colStartTime.FieldName = "StartTime"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.Visible = True
        Me.colStartTime.VisibleIndex = 6
        Me.colStartTime.Width = 74
        '
        'colEndTime
        '
        Me.colEndTime.Caption = "Bitiş"
        Me.colEndTime.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm"
        Me.colEndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEndTime.FieldName = "EndTime"
        Me.colEndTime.Name = "colEndTime"
        Me.colEndTime.Visible = True
        Me.colEndTime.VisibleIndex = 7
        Me.colEndTime.Width = 87
        '
        'colLocation
        '
        Me.colLocation.Caption = "Yer"
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 2
        Me.colLocation.Width = 49
        '
        'colAllDay
        '
        Me.colAllDay.Caption = "HerGün?"
        Me.colAllDay.FieldName = "AllDay"
        Me.colAllDay.Name = "colAllDay"
        Me.colAllDay.Width = 94
        '
        'colEventType
        '
        Me.colEventType.Caption = "EventType"
        Me.colEventType.FieldName = "EventType"
        Me.colEventType.Name = "colEventType"
        '
        'colRecurrenceInfo
        '
        Me.colRecurrenceInfo.Caption = "RecurrenceInfo"
        Me.colRecurrenceInfo.FieldName = "RecurrenceInfo"
        Me.colRecurrenceInfo.Name = "colRecurrenceInfo"
        '
        'colReminderInfo
        '
        Me.colReminderInfo.Caption = "ReminderInfo"
        Me.colReminderInfo.FieldName = "ReminderInfo"
        Me.colReminderInfo.Name = "colReminderInfo"
        '
        'colTutar
        '
        Me.colTutar.Caption = "Tutar"
        Me.colTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:#,0.00}")})
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 8
        Me.colTutar.Width = 39
        '
        'colPb
        '
        Me.colPb.Caption = "Pb"
        Me.colPb.FieldName = "Pb"
        Me.colPb.Name = "colPb"
        Me.colPb.Visible = True
        Me.colPb.VisibleIndex = 9
        Me.colPb.Width = 32
        '
        'colOdendi
        '
        Me.colOdendi.Caption = "Odendi?"
        Me.colOdendi.FieldName = "Odendi"
        Me.colOdendi.Name = "colOdendi"
        Me.colOdendi.Visible = True
        Me.colOdendi.VisibleIndex = 10
        Me.colOdendi.Width = 48
        '
        'colPersonel
        '
        Me.colPersonel.Caption = "Personel"
        Me.colPersonel.ColumnEdit = Me.sec_gorev_personel
        Me.colPersonel.FieldName = "PersonelNo"
        Me.colPersonel.Name = "colPersonel"
        Me.colPersonel.Visible = True
        Me.colPersonel.VisibleIndex = 3
        Me.colPersonel.Width = 66
        '
        'sec_gorev_personel
        '
        Me.sec_gorev_personel.AutoHeight = False
        Me.sec_gorev_personel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_gorev_personel.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Personeller")})
        Me.sec_gorev_personel.DisplayMember = "ACIKLAMA"
        Me.sec_gorev_personel.Name = "sec_gorev_personel"
        Me.sec_gorev_personel.NullText = "[Personeller...]"
        Me.sec_gorev_personel.ValueMember = "IND"
        '
        'colHesap
        '
        Me.colHesap.Caption = "Hesap"
        Me.colHesap.FieldName = "Firma"
        Me.colHesap.Name = "colHesap"
        Me.colHesap.Visible = True
        Me.colHesap.VisibleIndex = 4
        Me.colHesap.Width = 96
        '
        'colGelecekmi
        '
        Me.colGelecekmi.Caption = "Gelecekmi?"
        Me.colGelecekmi.FieldName = "Gelecekmi"
        Me.colGelecekmi.Name = "colGelecekmi"
        Me.colGelecekmi.Visible = True
        Me.colGelecekmi.VisibleIndex = 11
        Me.colGelecekmi.Width = 48
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton34)
        Me.PanelControl2.Controls.Add(Me.SimpleButton33)
        Me.PanelControl2.Controls.Add(Me.SimpleButton29)
        Me.PanelControl2.Controls.Add(Me.SimpleButton30)
        Me.PanelControl2.Controls.Add(Me.SimpleButton31)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 231)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(457, 53)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton34
        '
        Me.SimpleButton34.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton34.Location = New System.Drawing.Point(318, 13)
        Me.SimpleButton34.Name = "SimpleButton34"
        Me.SimpleButton34.Size = New System.Drawing.Size(154, 33)
        Me.SimpleButton34.TabIndex = 16
        Me.SimpleButton34.Text = "&Görev Sil"
        '
        'SimpleButton33
        '
        Me.SimpleButton33.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton33.Location = New System.Drawing.Point(165, 13)
        Me.SimpleButton33.Name = "SimpleButton33"
        Me.SimpleButton33.Size = New System.Drawing.Size(153, 33)
        Me.SimpleButton33.TabIndex = 15
        Me.SimpleButton33.Text = "&Görev Düzelt"
        '
        'SimpleButton29
        '
        Me.SimpleButton29.Image = CType(resources.GetObject("SimpleButton29.Image"), System.Drawing.Image)
        Me.SimpleButton29.Location = New System.Drawing.Point(613, 13)
        Me.SimpleButton29.Name = "SimpleButton29"
        Me.SimpleButton29.Size = New System.Drawing.Size(141, 33)
        Me.SimpleButton29.TabIndex = 14
        Me.SimpleButton29.Text = "&Yazdır"
        '
        'SimpleButton30
        '
        Me.SimpleButton30.Image = CType(resources.GetObject("SimpleButton30.Image"), System.Drawing.Image)
        Me.SimpleButton30.Location = New System.Drawing.Point(472, 13)
        Me.SimpleButton30.Name = "SimpleButton30"
        Me.SimpleButton30.Size = New System.Drawing.Size(141, 33)
        Me.SimpleButton30.TabIndex = 13
        Me.SimpleButton30.Text = "&Fihrist"
        '
        'SimpleButton31
        '
        Me.SimpleButton31.Image = CType(resources.GetObject("SimpleButton31.Image"), System.Drawing.Image)
        Me.SimpleButton31.Location = New System.Drawing.Point(11, 13)
        Me.SimpleButton31.Name = "SimpleButton31"
        Me.SimpleButton31.Size = New System.Drawing.Size(154, 33)
        Me.SimpleButton31.TabIndex = 12
        Me.SimpleButton31.Text = "&Görev Ekle"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txt_dteGorevTarihi)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton32)
        Me.PanelControl1.Controls.Add(Me.sec_durum)
        Me.PanelControl1.Controls.Add(Me.LabelControl30)
        Me.PanelControl1.Controls.Add(Me.sec_tamamlandi)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(457, 53)
        Me.PanelControl1.TabIndex = 0
        '
        'txt_dteGorevTarihi
        '
        Me.txt_dteGorevTarihi.EditValue = Nothing
        Me.txt_dteGorevTarihi.EnterMoveNextControl = True
        Me.txt_dteGorevTarihi.Location = New System.Drawing.Point(64, 17)
        Me.txt_dteGorevTarihi.Name = "txt_dteGorevTarihi"
        Me.txt_dteGorevTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteGorevTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteGorevTarihi.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteGorevTarihi.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Tarih:"
        '
        'SimpleButton32
        '
        Me.SimpleButton32.Image = CType(resources.GetObject("SimpleButton32.Image"), System.Drawing.Image)
        Me.SimpleButton32.Location = New System.Drawing.Point(579, 17)
        Me.SimpleButton32.Name = "SimpleButton32"
        Me.SimpleButton32.Size = New System.Drawing.Size(120, 29)
        Me.SimpleButton32.TabIndex = 54
        Me.SimpleButton32.Text = "&Listele"
        '
        'sec_durum
        '
        Me.sec_durum.EditValue = "[Tümü]"
        Me.sec_durum.EnterMoveNextControl = True
        Me.sec_durum.Location = New System.Drawing.Point(280, 17)
        Me.sec_durum.Name = "sec_durum"
        Me.sec_durum.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_durum.Properties.Appearance.Options.UseBackColor = True
        Me.sec_durum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_durum.Properties.Items.AddRange(New Object() {"[Tümü]", "Bekliyor", "Tamamlandı", "Ertelendi", "Görülüyor", "Cevap Bekleniyor", "İşlem Yaplıyor", "Ulaşılamyor", "İptal"})
        Me.sec_durum.Size = New System.Drawing.Size(160, 26)
        Me.sec_durum.TabIndex = 52
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl30.Location = New System.Drawing.Point(440, 17)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(35, 19)
        Me.LabelControl30.TabIndex = 55
        Me.LabelControl30.Text = "Bitti?"
        '
        'sec_tamamlandi
        '
        Me.sec_tamamlandi.EditValue = "Hayır"
        Me.sec_tamamlandi.EnterMoveNextControl = True
        Me.sec_tamamlandi.Location = New System.Drawing.Point(477, 17)
        Me.sec_tamamlandi.Name = "sec_tamamlandi"
        Me.sec_tamamlandi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_tamamlandi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_tamamlandi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tamamlandi.Properties.Items.AddRange(New Object() {"[Tümü]", "Evet", "Hayır"})
        Me.sec_tamamlandi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_tamamlandi.Size = New System.Drawing.Size(102, 26)
        Me.sec_tamamlandi.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(224, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Durum:"
        '
        'ımageList1
        '
        Me.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ımageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ds_taksitler
        '
        Me.ds_taksitler.DataSetName = "NewDataSet"
        Me.ds_taksitler.Locale = New System.Globalization.CultureInfo("tr-TR")
        '
        'Panel_islem
        '
        Me.Panel_islem.Appearance.BackColor = System.Drawing.Color.Black
        Me.Panel_islem.Appearance.Options.UseBackColor = True
        Me.Panel_islem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.Panel_islem.Controls.Add(Me.GroupControl7)
        Me.Panel_islem.Controls.Add(Me.GroupControl6)
        Me.Panel_islem.Controls.Add(Me.GroupControl5)
        Me.Panel_islem.Controls.Add(Me.GroupControl4)
        Me.Panel_islem.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_islem.Location = New System.Drawing.Point(0, 94)
        Me.Panel_islem.Name = "Panel_islem"
        Me.Panel_islem.Size = New System.Drawing.Size(272, 652)
        Me.Panel_islem.TabIndex = 15
        '
        'GroupControl7
        '
        Me.GroupControl7.Appearance.BackColor = System.Drawing.Color.Black
        Me.GroupControl7.Appearance.Options.UseBackColor = True
        Me.GroupControl7.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl7.AppearanceCaption.Options.UseFont = True
        Me.GroupControl7.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl7.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GroupControl7.Controls.Add(Me.SimpleButton9)
        Me.GroupControl7.Controls.Add(Me.SimpleButton25)
        Me.GroupControl7.Controls.Add(Me.SimpleButton15)
        Me.GroupControl7.Controls.Add(Me.SimpleButton14)
        Me.GroupControl7.Controls.Add(Me.SimpleButton13)
        Me.GroupControl7.Controls.Add(Me.SimpleButton12)
        Me.GroupControl7.Controls.Add(Me.SimpleButton11)
        Me.GroupControl7.Controls.Add(Me.SimpleButton10)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_SiparisVerilen)
        Me.GroupControl7.Controls.Add(Me.SimpleButton7)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Kalan_Satislar)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Satislar)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Odemeler)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Kalan_Taksitler)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_SiparisAlinanlar)
        Me.GroupControl7.Controls.Add(Me.SimpleButton8)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl7.Location = New System.Drawing.Point(2, 610)
        Me.GroupControl7.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(268, 40)
        Me.GroupControl7.TabIndex = 3
        Me.GroupControl7.Text = "Analiz"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton9.Appearance.Options.UseFont = True
        Me.SimpleButton9.Appearance.Options.UseTextOptions = True
        Me.SimpleButton9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton9.Location = New System.Drawing.Point(11, 187)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(122, 23)
        Me.SimpleButton9.TabIndex = 15
        Me.SimpleButton9.Text = "Stok Özeti"
        '
        'SimpleButton25
        '
        Me.SimpleButton25.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton25.Appearance.Options.UseFont = True
        Me.SimpleButton25.Appearance.Options.UseTextOptions = True
        Me.SimpleButton25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton25.Location = New System.Drawing.Point(11, 96)
        Me.SimpleButton25.Name = "SimpleButton25"
        Me.SimpleButton25.Size = New System.Drawing.Size(122, 23)
        Me.SimpleButton25.TabIndex = 14
        Me.SimpleButton25.Text = "Proformalar"
        '
        'SimpleButton15
        '
        Me.SimpleButton15.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton15.Appearance.Options.UseFont = True
        Me.SimpleButton15.Appearance.Options.UseTextOptions = True
        Me.SimpleButton15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton15.Location = New System.Drawing.Point(133, 141)
        Me.SimpleButton15.Name = "SimpleButton15"
        Me.SimpleButton15.Size = New System.Drawing.Size(121, 23)
        Me.SimpleButton15.TabIndex = 13
        Me.SimpleButton15.Text = "Hareket Gir"
        '
        'SimpleButton14
        '
        Me.SimpleButton14.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton14.Appearance.Options.UseFont = True
        Me.SimpleButton14.Appearance.Options.UseTextOptions = True
        Me.SimpleButton14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton14.Location = New System.Drawing.Point(133, 187)
        Me.SimpleButton14.Name = "SimpleButton14"
        Me.SimpleButton14.Size = New System.Drawing.Size(121, 23)
        Me.SimpleButton14.TabIndex = 12
        Me.SimpleButton14.Text = "Karlılık"
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton13.Appearance.Options.UseFont = True
        Me.SimpleButton13.Appearance.Options.UseTextOptions = True
        Me.SimpleButton13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton13.Location = New System.Drawing.Point(133, 164)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(121, 23)
        Me.SimpleButton13.TabIndex = 11
        Me.SimpleButton13.Text = "Faaliyet Raporu"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton12.Appearance.Options.UseFont = True
        Me.SimpleButton12.Appearance.Options.UseTextOptions = True
        Me.SimpleButton12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton12.Location = New System.Drawing.Point(11, 164)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(122, 23)
        Me.SimpleButton12.TabIndex = 10
        Me.SimpleButton12.Text = "Stok Hareketleri"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton11.Appearance.Options.UseFont = True
        Me.SimpleButton11.Appearance.Options.UseTextOptions = True
        Me.SimpleButton11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton11.Location = New System.Drawing.Point(11, 141)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(122, 23)
        Me.SimpleButton11.TabIndex = 9
        Me.SimpleButton11.Text = "Satış Kapat"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton10.Appearance.Options.UseFont = True
        Me.SimpleButton10.Appearance.Options.UseTextOptions = True
        Me.SimpleButton10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton10.Location = New System.Drawing.Point(133, 119)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(121, 22)
        Me.SimpleButton10.TabIndex = 8
        Me.SimpleButton10.Text = "Verilen Çekler"
        '
        'btn_Analiz_SiparisVerilen
        '
        Me.btn_Analiz_SiparisVerilen.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Analiz_SiparisVerilen.Appearance.Options.UseFont = True
        Me.btn_Analiz_SiparisVerilen.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_SiparisVerilen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_SiparisVerilen.Location = New System.Drawing.Point(133, 73)
        Me.btn_Analiz_SiparisVerilen.Name = "btn_Analiz_SiparisVerilen"
        Me.btn_Analiz_SiparisVerilen.Size = New System.Drawing.Size(121, 23)
        Me.btn_Analiz_SiparisVerilen.TabIndex = 7
        Me.btn_Analiz_SiparisVerilen.Text = "Verilen Siparişler"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.Appearance.Options.UseTextOptions = True
        Me.SimpleButton7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton7.Location = New System.Drawing.Point(133, 96)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(121, 23)
        Me.SimpleButton7.TabIndex = 5
        Me.SimpleButton7.Text = "SatınAlma Şartları"
        '
        'btn_Analiz_Kalan_Satislar
        '
        Me.btn_Analiz_Kalan_Satislar.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Analiz_Kalan_Satislar.Appearance.Options.UseFont = True
        Me.btn_Analiz_Kalan_Satislar.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Kalan_Satislar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Kalan_Satislar.Location = New System.Drawing.Point(133, 50)
        Me.btn_Analiz_Kalan_Satislar.Name = "btn_Analiz_Kalan_Satislar"
        Me.btn_Analiz_Kalan_Satislar.Size = New System.Drawing.Size(121, 23)
        Me.btn_Analiz_Kalan_Satislar.TabIndex = 2
        Me.btn_Analiz_Kalan_Satislar.Text = "Açık Borçlar"
        '
        'btn_Analiz_Satislar
        '
        Me.btn_Analiz_Satislar.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Analiz_Satislar.Appearance.Options.UseFont = True
        Me.btn_Analiz_Satislar.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Satislar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Satislar.Location = New System.Drawing.Point(133, 27)
        Me.btn_Analiz_Satislar.Name = "btn_Analiz_Satislar"
        Me.btn_Analiz_Satislar.Size = New System.Drawing.Size(121, 23)
        Me.btn_Analiz_Satislar.TabIndex = 1
        Me.btn_Analiz_Satislar.Text = "Borç Eşleştir"
        '
        'btn_Analiz_Odemeler
        '
        Me.btn_Analiz_Odemeler.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Analiz_Odemeler.Appearance.Options.UseFont = True
        Me.btn_Analiz_Odemeler.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Odemeler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Odemeler.Location = New System.Drawing.Point(11, 27)
        Me.btn_Analiz_Odemeler.Name = "btn_Analiz_Odemeler"
        Me.btn_Analiz_Odemeler.Size = New System.Drawing.Size(122, 23)
        Me.btn_Analiz_Odemeler.TabIndex = 0
        Me.btn_Analiz_Odemeler.Text = "Alacak Eşleştir"
        '
        'btn_Analiz_Kalan_Taksitler
        '
        Me.btn_Analiz_Kalan_Taksitler.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Analiz_Kalan_Taksitler.Appearance.Options.UseFont = True
        Me.btn_Analiz_Kalan_Taksitler.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Kalan_Taksitler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Kalan_Taksitler.Location = New System.Drawing.Point(11, 50)
        Me.btn_Analiz_Kalan_Taksitler.Name = "btn_Analiz_Kalan_Taksitler"
        Me.btn_Analiz_Kalan_Taksitler.Size = New System.Drawing.Size(122, 23)
        Me.btn_Analiz_Kalan_Taksitler.TabIndex = 3
        Me.btn_Analiz_Kalan_Taksitler.Text = "Açık Alacaklar"
        '
        'btn_Analiz_SiparisAlinanlar
        '
        Me.btn_Analiz_SiparisAlinanlar.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Analiz_SiparisAlinanlar.Appearance.Options.UseFont = True
        Me.btn_Analiz_SiparisAlinanlar.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_SiparisAlinanlar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_SiparisAlinanlar.Location = New System.Drawing.Point(11, 73)
        Me.btn_Analiz_SiparisAlinanlar.Name = "btn_Analiz_SiparisAlinanlar"
        Me.btn_Analiz_SiparisAlinanlar.Size = New System.Drawing.Size(122, 23)
        Me.btn_Analiz_SiparisAlinanlar.TabIndex = 4
        Me.btn_Analiz_SiparisAlinanlar.Text = "Alınan Siparişler"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton8.Appearance.Options.UseFont = True
        Me.SimpleButton8.Appearance.Options.UseTextOptions = True
        Me.SimpleButton8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton8.Location = New System.Drawing.Point(11, 119)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(122, 22)
        Me.SimpleButton8.TabIndex = 6
        Me.SimpleButton8.Text = "Alınan Çekler"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl6.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GroupControl6.Controls.Add(Me.SimpleButton6)
        Me.GroupControl6.Controls.Add(Me.btn_Ekstre_Ozet)
        Me.GroupControl6.Controls.Add(Me.btn_Raporlar_Ekstre_Detayli)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl6.Location = New System.Drawing.Point(2, 515)
        Me.GroupControl6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(268, 95)
        Me.GroupControl6.TabIndex = 2
        Me.GroupControl6.Text = "Raporlar"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Options.UseTextOptions = True
        Me.SimpleButton6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton6.Location = New System.Drawing.Point(11, 73)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(239, 23)
        Me.SimpleButton6.TabIndex = 2
        Me.SimpleButton6.Text = "Risk"
        '
        'btn_Ekstre_Ozet
        '
        Me.btn_Ekstre_Ozet.Appearance.Options.UseTextOptions = True
        Me.btn_Ekstre_Ozet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Ekstre_Ozet.Location = New System.Drawing.Point(11, 50)
        Me.btn_Ekstre_Ozet.Name = "btn_Ekstre_Ozet"
        Me.btn_Ekstre_Ozet.Size = New System.Drawing.Size(239, 23)
        Me.btn_Ekstre_Ozet.TabIndex = 1
        Me.btn_Ekstre_Ozet.Text = "Ekstre Özet              F7"
        '
        'btn_Raporlar_Ekstre_Detayli
        '
        Me.btn_Raporlar_Ekstre_Detayli.Appearance.Options.UseTextOptions = True
        Me.btn_Raporlar_Ekstre_Detayli.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Raporlar_Ekstre_Detayli.Location = New System.Drawing.Point(11, 27)
        Me.btn_Raporlar_Ekstre_Detayli.Name = "btn_Raporlar_Ekstre_Detayli"
        Me.btn_Raporlar_Ekstre_Detayli.Size = New System.Drawing.Size(239, 23)
        Me.btn_Raporlar_Ekstre_Detayli.TabIndex = 0
        Me.btn_Raporlar_Ekstre_Detayli.Text = "Ekstre Detaylı          Ctrl+S"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl5.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GroupControl5.Controls.Add(Me.btn_Islem_IrsaliyeVer)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_IrsaliyeAl)
        Me.GroupControl5.Controls.Add(Me.SimpleButton18)
        Me.GroupControl5.Controls.Add(Me.SimpleButton17)
        Me.GroupControl5.Controls.Add(Me.SimpleButton16)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_SiparisVer)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_SiparisAl)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_CariCikis)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_CariGiris)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_IadeEt)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_IadeAl)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_Alis_Yap)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_SatisYap)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl5.Location = New System.Drawing.Point(2, 190)
        Me.GroupControl5.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(268, 325)
        Me.GroupControl5.TabIndex = 1
        Me.GroupControl5.Text = "İşlemler"
        '
        'btn_Islem_IrsaliyeVer
        '
        Me.btn_Islem_IrsaliyeVer.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_IrsaliyeVer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_IrsaliyeVer.Location = New System.Drawing.Point(11, 301)
        Me.btn_Islem_IrsaliyeVer.Name = "btn_Islem_IrsaliyeVer"
        Me.btn_Islem_IrsaliyeVer.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_IrsaliyeVer.TabIndex = 12
        Me.btn_Islem_IrsaliyeVer.Text = "Satış irsaliyesi"
        '
        'btn_Islem_IrsaliyeAl
        '
        Me.btn_Islem_IrsaliyeAl.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_IrsaliyeAl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_IrsaliyeAl.Location = New System.Drawing.Point(11, 279)
        Me.btn_Islem_IrsaliyeAl.Name = "btn_Islem_IrsaliyeAl"
        Me.btn_Islem_IrsaliyeAl.Size = New System.Drawing.Size(239, 22)
        Me.btn_Islem_IrsaliyeAl.TabIndex = 11
        Me.btn_Islem_IrsaliyeAl.Text = "Alış İrsaliyesi"
        '
        'SimpleButton18
        '
        Me.SimpleButton18.Appearance.Options.UseTextOptions = True
        Me.SimpleButton18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton18.Location = New System.Drawing.Point(11, 256)
        Me.SimpleButton18.Name = "SimpleButton18"
        Me.SimpleButton18.Size = New System.Drawing.Size(239, 23)
        Me.SimpleButton18.TabIndex = 10
        Me.SimpleButton18.Text = "K.K ile Ödeme"
        '
        'SimpleButton17
        '
        Me.SimpleButton17.Appearance.Options.UseTextOptions = True
        Me.SimpleButton17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton17.Location = New System.Drawing.Point(11, 233)
        Me.SimpleButton17.Name = "SimpleButton17"
        Me.SimpleButton17.Size = New System.Drawing.Size(239, 23)
        Me.SimpleButton17.TabIndex = 9
        Me.SimpleButton17.Text = "K.K ile Tahsilat"
        '
        'SimpleButton16
        '
        Me.SimpleButton16.Appearance.Options.UseTextOptions = True
        Me.SimpleButton16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton16.Location = New System.Drawing.Point(11, 210)
        Me.SimpleButton16.Name = "SimpleButton16"
        Me.SimpleButton16.Size = New System.Drawing.Size(239, 23)
        Me.SimpleButton16.TabIndex = 8
        Me.SimpleButton16.Text = "Mahsup Fişi"
        '
        'btn_Islem_SiparisVer
        '
        Me.btn_Islem_SiparisVer.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_SiparisVer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_SiparisVer.Location = New System.Drawing.Point(11, 187)
        Me.btn_Islem_SiparisVer.Name = "btn_Islem_SiparisVer"
        Me.btn_Islem_SiparisVer.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_SiparisVer.TabIndex = 7
        Me.btn_Islem_SiparisVer.Text = "Sipariş Ver               "
        '
        'btn_Islem_SiparisAl
        '
        Me.btn_Islem_SiparisAl.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_SiparisAl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_SiparisAl.Location = New System.Drawing.Point(11, 164)
        Me.btn_Islem_SiparisAl.Name = "btn_Islem_SiparisAl"
        Me.btn_Islem_SiparisAl.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_SiparisAl.TabIndex = 6
        Me.btn_Islem_SiparisAl.Text = "Sipariş Al                 "
        '
        'btn_Islem_CariCikis
        '
        Me.btn_Islem_CariCikis.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_CariCikis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_CariCikis.Location = New System.Drawing.Point(11, 141)
        Me.btn_Islem_CariCikis.Name = "btn_Islem_CariCikis"
        Me.btn_Islem_CariCikis.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_CariCikis.TabIndex = 5
        Me.btn_Islem_CariCikis.Text = "Çıkış Bordrosu         Shift+F6"
        '
        'btn_Islem_CariGiris
        '
        Me.btn_Islem_CariGiris.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_CariGiris.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_CariGiris.Location = New System.Drawing.Point(11, 119)
        Me.btn_Islem_CariGiris.Name = "btn_Islem_CariGiris"
        Me.btn_Islem_CariGiris.Size = New System.Drawing.Size(239, 22)
        Me.btn_Islem_CariGiris.TabIndex = 4
        Me.btn_Islem_CariGiris.Text = "Giriş Bordrosu         Shift+F5"
        '
        'btn_Islem_IadeEt
        '
        Me.btn_Islem_IadeEt.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_IadeEt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_IadeEt.Location = New System.Drawing.Point(11, 96)
        Me.btn_Islem_IadeEt.Name = "btn_Islem_IadeEt"
        Me.btn_Islem_IadeEt.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_IadeEt.TabIndex = 3
        Me.btn_Islem_IadeEt.Text = "İade Et"
        '
        'btn_Islem_IadeAl
        '
        Me.btn_Islem_IadeAl.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_IadeAl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_IadeAl.Location = New System.Drawing.Point(11, 73)
        Me.btn_Islem_IadeAl.Name = "btn_Islem_IadeAl"
        Me.btn_Islem_IadeAl.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_IadeAl.TabIndex = 2
        Me.btn_Islem_IadeAl.Text = "İade Al"
        '
        'btn_Islem_Alis_Yap
        '
        Me.btn_Islem_Alis_Yap.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_Alis_Yap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_Alis_Yap.Location = New System.Drawing.Point(11, 50)
        Me.btn_Islem_Alis_Yap.Name = "btn_Islem_Alis_Yap"
        Me.btn_Islem_Alis_Yap.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_Alis_Yap.TabIndex = 1
        Me.btn_Islem_Alis_Yap.Text = "Alış Yap                   F6"
        '
        'btn_Islem_SatisYap
        '
        Me.btn_Islem_SatisYap.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_SatisYap.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_SatisYap.Location = New System.Drawing.Point(11, 27)
        Me.btn_Islem_SatisYap.Name = "btn_Islem_SatisYap"
        Me.btn_Islem_SatisYap.Size = New System.Drawing.Size(239, 23)
        Me.btn_Islem_SatisYap.TabIndex = 0
        Me.btn_Islem_SatisYap.Text = "Satış Yap                F5"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.GroupControl4.Controls.Add(Me.SimpleButton24)
        Me.GroupControl4.Controls.Add(Me.SimpleButton5)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Duzelt)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Not)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Kart)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Yeni)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_sec)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(268, 188)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Hesap Bilgileri"
        '
        'SimpleButton24
        '
        Me.SimpleButton24.Appearance.Options.UseTextOptions = True
        Me.SimpleButton24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton24.Location = New System.Drawing.Point(13, 164)
        Me.SimpleButton24.Name = "SimpleButton24"
        Me.SimpleButton24.Size = New System.Drawing.Size(238, 23)
        Me.SimpleButton24.TabIndex = 7
        Me.SimpleButton24.Text = "Yazışma"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Options.UseTextOptions = True
        Me.SimpleButton5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton5.Location = New System.Drawing.Point(11, 141)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(239, 23)
        Me.SimpleButton5.TabIndex = 6
        Me.SimpleButton5.Text = "SMS Gönder"
        '
        'btn_Musteri_Duzelt
        '
        Me.btn_Musteri_Duzelt.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Duzelt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Duzelt.Location = New System.Drawing.Point(11, 119)
        Me.btn_Musteri_Duzelt.Name = "btn_Musteri_Duzelt"
        Me.btn_Musteri_Duzelt.Size = New System.Drawing.Size(239, 22)
        Me.btn_Musteri_Duzelt.TabIndex = 4
        Me.btn_Musteri_Duzelt.Text = "İletişim Bilgileri        F8"
        '
        'btn_Musteri_Not
        '
        Me.btn_Musteri_Not.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Not.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Not.Location = New System.Drawing.Point(11, 96)
        Me.btn_Musteri_Not.Name = "btn_Musteri_Not"
        Me.btn_Musteri_Not.Size = New System.Drawing.Size(239, 23)
        Me.btn_Musteri_Not.TabIndex = 3
        Me.btn_Musteri_Not.Text = "Not                         F9"
        '
        'btn_Musteri_Kart
        '
        Me.btn_Musteri_Kart.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Kart.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Kart.Location = New System.Drawing.Point(11, 73)
        Me.btn_Musteri_Kart.Name = "btn_Musteri_Kart"
        Me.btn_Musteri_Kart.Size = New System.Drawing.Size(239, 23)
        Me.btn_Musteri_Kart.TabIndex = 2
        Me.btn_Musteri_Kart.Text = "Hesap Kartı            F4"
        '
        'btn_Musteri_Yeni
        '
        Me.btn_Musteri_Yeni.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Yeni.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Yeni.Location = New System.Drawing.Point(11, 50)
        Me.btn_Musteri_Yeni.Name = "btn_Musteri_Yeni"
        Me.btn_Musteri_Yeni.Size = New System.Drawing.Size(239, 23)
        Me.btn_Musteri_Yeni.TabIndex = 1
        Me.btn_Musteri_Yeni.Text = "Yeni Hesap             Insert"
        '
        'btn_Musteri_sec
        '
        Me.btn_Musteri_sec.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_sec.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_sec.Location = New System.Drawing.Point(11, 27)
        Me.btn_Musteri_sec.Name = "btn_Musteri_sec"
        Me.btn_Musteri_sec.Size = New System.Drawing.Size(239, 23)
        Me.btn_Musteri_sec.TabIndex = 0
        Me.btn_Musteri_sec.Text = "Hesap Seç              F3"
        '
        'panel_bilgi
        '
        Me.panel_bilgi.Controls.Add(Me.GroupControl3)
        Me.panel_bilgi.Controls.Add(Me.Panel_Taksitler)
        Me.panel_bilgi.Controls.Add(Me.Panel_Baslik)
        Me.panel_bilgi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_bilgi.Location = New System.Drawing.Point(272, 94)
        Me.panel_bilgi.Name = "panel_bilgi"
        Me.panel_bilgi.Size = New System.Drawing.Size(546, 652)
        Me.panel_bilgi.TabIndex = 16
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink6})
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Bekleyen Siparişler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink6
        '
        Me.printlink6.Component = Me.GridControl6
        '
        '
        '
        Me.printlink6.ImageCollection.ImageStream = CType(resources.GetObject("printlink6.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink6.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink6.Owner = Nothing
        Me.printlink6.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Görevler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Ajanda", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink6.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink6.PrintingSystem = Me.ps
        Me.printlink6.PrintingSystemBase = Me.ps
        '
        'frm_finans
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(818, 746)
        Me.Controls.Add(Me.panel_bilgi)
        Me.Controls.Add(Me.Panel_islem)
        Me.Controls.Add(Me.Panel_Kasiyer)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_finans"
        Me.Text = "Finans Yönetimi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Panel_Kasiyer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Kasiyer.ResumeLayout(False)
        Me.Panel_Kasiyer.PerformLayout()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Baslik.ResumeLayout(False)
        Me.Panel_Baslik.PerformLayout()
        CType(Me.lbl_info.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINIF5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINIF4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINIF3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINIF2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINIF1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nVadeGun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskonto4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskonto3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sYetkili.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskonto1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lKrediLimiti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskonto2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lGeciken.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lBakiye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sTelefon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdres2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdres1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKayitTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKayitTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nFirmaID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Ara.ResumeLayout(False)
        Me.Panel_Ara.PerformLayout()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bakiyeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Taksitler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Taksitler.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_sinif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_odemeler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.sec_sSiparisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.sec_sIrsaliyeTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_irsaliye_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_gorev_personel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_dteGorevTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteGorevTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_durum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tamamlandi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_taksitler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_islem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_islem.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.panel_bilgi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_bilgi.ResumeLayout(False)
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink6.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sModul As String = "Cari"
    Dim sKasiyerRumuzu As String = ""
    Dim sKasiyer As String
    Dim sMagaza As String
    Public nMusteriID As Int64 = 0
    Public nHesapID As Int64 = 0
    Public lKodu As String = 0
    Public sAdi As String = ""
    Public sDovizCinsi As String = ""
    Dim sSoyadi As String = ""
    Dim sAdres1 As String = ""
    Dim sAdres2 As String = ""
    Dim sIstihbarat As String = ""
    Dim bSatisYapilamaz As Boolean = False
    Dim bTahsilatYapilamaz As Boolean = False
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Dim ds_siparis As DataSet
    Dim ds_irsaliye As DataSet
    Dim ds_tbGorev As DataSet
    Dim dr_baslik As DataRow
    Dim bIptalYapabilirmi As Boolean = False
    Dim bVadeFarksizOdemeAlirmi As Boolean = False
    Dim nMaxIskontoYuzdesi As Decimal = 100
    Dim status As Boolean = False
    Dim sLoadsKodu As String = ""
    Dim sDepoFirma As String = ""
    Dim Dr1 As DataRow
    Private Sub frm_perakende_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If yetki_kontrol(kullanici, "frm_Finans_HareketlerTab_Goruntule", False) = True Then
            XtraTabPage1.PageVisible = True
        Else
            XtraTabPage1.PageVisible = False
        End If
        If yetki_kontrol(kullanici, "frm_Finans_BakiyeTab_Goruntule", False) = True Then
            XtraTabPage2.PageVisible = True
        Else
            XtraTabPage2.PageVisible = False
        End If
        txt_kasiyer_kod.Text = 1
        lbl_kasiyer.Text = kullaniciadi
        sKasiyerRumuzu = "VC"
        sKasiyer = "Admin"
        DateEdit1.EditValue = dteSistemTarihi 'sorgu_tarih_kontrol() 'dteSistemTarihi
        DateEdit1.Enabled = False
        sec_ekstre_tarih1.EditValue = "01/01/" + Today.Year.ToString
        sec_ekstre_tarih2.EditValue = "31/12/" + Today.Year.ToString
        DateEdit3.EditValue = "01/01/" + Today.Year.ToString
        DateEdit2.EditValue = "31/12/" + Today.Year.ToString
        txt_dteGorevTarihi.EditValue = dteSistemTarihi
        dataload_kasa()
        dataload_kasiyer()
        dataload_depo()
        kasiyer_kontrol()
        sec_magaza.EditValue = sDepo
        XtraTabPage1.Focus()
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub dataload(ByVal nMusteriID As Int64)
        colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString & "(-)"
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'lbl_istihbarat.Text = ""
        sIstihbarat = ""
        ds_tbFirma = tbMusteri(nMusteriID)
        dr_baslik = ds_tbFirma.Tables(0).Rows(0)
        Try
            If Trim(dr_baslik("ISTIHBARAT").ToString) <> "" Then
                sIstihbarat = Trim(dr_baslik("ISTIHBARAT").ToString)
                If sIstihbarat <> lbl_istihbarat.Text Then
                    lbl_info.Visible = True
                    Dim alertcontrol1 As New DevExpress.XtraBars.Alerter.AlertControl
                    alertcontrol1.Show(Me, Sorgu_sDil("İstihbarat", sDil), dr_baslik("ISTIHBARAT").ToString)
                    'MsgBox(Trim(dr_baslik("ISTIHBARAT").ToString), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'XtraMessageBox.Show("İstihbarat Notu Girilmiş Kontrol Etmeyi Unutmayınız...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                lbl_info.Visible = False
            End If
        Catch ex As Exception
            sIstihbarat = ""
        End Try
        Try
            sDepoFirma = dr_baslik("sDepo").ToString()
        Catch ex As Exception
            sDepoFirma = ""
        End Try
        'lbl_istihbarat.Text = sIstihbarat
        'VGrid_Genel.DataSource = ds_tbFirma.Tables(0)
        'VGrid_Genel.DataMember = Nothing
        sorgula_Decimal("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (sHangiUygulama IN ('IA', 'IS'))")
        dataload_tbMusteriSinifi(nMusteriID)
        If sAdi.Contains("PEŞİN") = False Then
            If sorgula_Decimal("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisverisID),0) AS nKayit FROM         tbAlisVeris Where nMusteriID = " & nMusteriID & "") <= 5000 Then
                'GroupControl2.Dock = DockStyle.Top
                GroupControl3.Visible = True
                dataload_odemeler(nMusteriID, "01/01/1900", "31/12/2078")
            Else
                'GroupControl2.Dock = DockStyle.Fill
                GroupControl3.Visible = False
            End If
            dataload_taksitler(nMusteriID)
        Else
            If sorgula_Decimal("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisverisID),0) AS nKayit FROM         tbAlisVeris Where nMusteriID = " & nMusteriID & "") <= 5000 Then
                'GroupControl2.Dock = DockStyle.Top
                GroupControl3.Visible = True
                dataload_odemeler(-1, "01/01/1900", "31/12/2078")
            Else
                'GroupControl2.Dock = DockStyle.Fill
                GroupControl3.Visible = False
            End If
            'dataload_odemeler(-1, "01/01/1900", "31/12/2078")
            dataload_taksitler(-1)
        End If
        Dim lBakiye As Decimal = dr_baslik("lBakiye")
        Dim lGeciken As Decimal = 0
        Dim gecikmistaksitsayisi As Integer = 0
        'For Each dr In ds_taksitler.Tables(0).Rows
        '    lBakiye += dr("KALAN")
        '    If dr("dteTarihi") < Today Then
        '        gecikmistaksitsayisi += 1
        '        lGeciken += dr("KALAN")
        '    End If
        'Next
        'colMAGAZA.SummaryItem.DisplayFormat = FormatNumber(Math.Abs(lBakiye), 2).ToString
        txt_nFirmaID.Text = dr_baslik("nFirmaID")
        txt_sKodu.Text = Trim(dr_baslik("sKodu"))
        txt_dteKayitTarihi.Text = dr_baslik("dteKayitTarihi")
        txt_sAciklama.Text = Trim(dr_baslik("sAciklama"))
        txt_sAdres1.Text = Trim(dr_baslik("sAdres1"))
        txt_sAdres2.Text = Trim(dr_baslik("sAdres2"))
        txt_sSemt.Text = Trim(dr_baslik("sSemt"))
        txt_sIl.Text = Trim(dr_baslik("sIl"))
        txt_sTelefon.Text = dr_baslik("Telefon").ToString
        txt_sGSM.Text = dr_baslik("Gsm").ToString
        txt_sEmail.Text = Trim(dr_baslik("E-Mail").ToString)
        txt_sYetkili.Text = dr_baslik("Yetkili").ToString
        txt_sVergiDairesi.Text = Trim(dr_baslik("sVergiDairesi").ToString)
        txt_sVergiNo.Text = Trim(dr_baslik("sVergiNo").ToString)
        txt_nIskonto1.Text = dr_baslik("nOzelIskontosu")
        txt_nIskonto2.Text = dr_baslik("nOzelIskontosu2")
        txt_nIskonto3.Text = dr_baslik("nOzelIskontosu3")
        txt_nIskonto4.Text = dr_baslik("nOzelIskontosu4")
        txt_sDovizCinsi.Text = dr_baslik("sDovizCinsi")
        txt_nVadeGun.Text = dr_baslik("nVadeGun")
        txt_sFiyatTipi.Text = Trim(dr_baslik("sFiyatTipi").ToString)
        txt_sSaticiRumuzu.Text = Trim(dr_baslik("sSaticiRumuzu").ToString)
        txt_SINIF1.Text = Trim(dr_baslik("SINIF1").ToString)
        txt_SINIF2.Text = Trim(dr_baslik("SINIF2").ToString)
        txt_SINIF3.Text = Trim(dr_baslik("SINIF3").ToString)
        txt_SINIF4.Text = Trim(dr_baslik("SINIF4").ToString)
        txt_SINIF5.Text = Trim(dr_baslik("SINIF5").ToString)
        bSatisYapilamaz = dr_baslik("bSatisYapilamaz")
        bTahsilatYapilamaz = dr_baslik("bTahsilatYapilamaz")
        If sorgu_sayi(lGeciken, 0) = 0 Then
            txt_lGeciken.Text = Format(sorgu_sayi(lGeciken, 0), "#,0.00")
        Else
            txt_lGeciken.Text = gecikmistaksitsayisi & " Adet : " & Format(sorgu_sayi(lGeciken, 0), "#,0.00")
        End If
        txt_lBakiye.Text = Format(sorgu_sayi(lBakiye, 0), "#,0.00")
        txt_lKrediLimiti.Text = Format(sorgu_sayi(dr_baslik("lKrediLimiti"), 0) - sorgu_sayi(lBakiye, 0), "#,0.00")
        If lGeciken > 0 Then
            BarButtonItem21.Caption = "Geciken Ödeme: " & gecikmistaksitsayisi & " Tutarı: " & FormatNumber(lGeciken, 2)
        Else
            BarButtonItem21.Caption = ""
        End If
        lBakiye = Nothing
        lGeciken = Nothing
        gecikmistaksitsayisi = Nothing
        If sLoadsKodu <> lKodu Then
            Dim nAlinanIrsaliye As Integer = 0
            Dim nVerilenIrsaliye As Integer = 0
            Dim sIrsaliyeSayi As String = ""
            nAlinanIrsaliye = irsaliyeler_sayi(lKodu, "01/01/1900", "31/12/2078", "Açık", "Alınan")
            nVerilenIrsaliye = irsaliyeler_sayi(lKodu, "01/01/1900", "31/12/2078", "Açık", "Verilen")
            If nAlinanIrsaliye > 0 Then
                sIrsaliyeSayi += " Faturalaşmamış Alış Irsaliye Sayisi : " & nAlinanIrsaliye
            End If
            If nVerilenIrsaliye > 0 Then
                sIrsaliyeSayi += vbCrLf & " Faturalaşmamış Satış Irsaliye Sayisi : " & nVerilenIrsaliye
            End If
            If sIrsaliyeSayi <> "" Then
                XtraMessageBox.Show(sIrsaliyeSayi & vbCrLf & Sorgu_sDil("Açık İrsaliyeler İçin [İrsaliyeler] tabından İrsaliyelerinize Ulaşabilirsiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            nAlinanIrsaliye = Nothing
            nVerilenIrsaliye = Nothing
            sIrsaliyeSayi = Nothing
            Dim nAlinanSiparis As Integer = 0
            Dim nVerilenSiparis As Integer = 0
            Dim sSiparisSayi As String = ""
            nAlinanSiparis = siparisler_sayi(lKodu, "01/01/1900", "31/12/2078", "Açık", "Alınan")
            nVerilenSiparis = siparisler_sayi(lKodu, "01/01/1900", "31/12/2078", "Açık", "Verilen")
            If nAlinanSiparis > 0 Then
                sSiparisSayi += " Açık Alınan Sipariş Sayisi : " & nAlinanSiparis
            End If
            If nVerilenSiparis > 0 Then
                sSiparisSayi += vbCrLf & " Açık Verilen Sipariş Sayisi : " & nVerilenSiparis
            End If
            If sSiparisSayi <> "" Then
                XtraMessageBox.Show(sSiparisSayi & vbCrLf & Sorgu_sDil("Açık Siparişler İçin [Siparişler] tabından Siparişlerinize Ulaşabilirsiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            nAlinanSiparis = Nothing
            nVerilenSiparis = Nothing
            sSiparisSayi = Nothing
            sLoadsKodu = lKodu
        End If
        BarButtonItem1.Caption = ""
        'Dogum Tarihi
        Dim ds_Yekun As DataSet
        ds_Yekun = yekun("01/01/1900", "31/12/2078", True)
        'lbl_istihbarat.Text = Trim(sIstihbarat.ToString)
        If GridView2.RowCount > 0 Then
            GridView2.ClearSelection()
            GridView2.FocusedRowHandle = GridView2.RowCount - 1
            GridView2.SelectRow(GridView2.FocusedRowHandle)
            GridControl2.Focus()
        End If
        GridControl4.DataSource = ds_Yekun.Tables(0)
        GridControl4.DataMember = Nothing
        GridControl2.Focus()
        GridControl2.Select()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Public Function yekun(ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean) As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi,tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.lBorcTutar AS lBorcTutar, tbFirmaHareketi.lAlacakTutar AS lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sAciklama AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, isnull(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, isnull(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, isnull(tbTempFirmahareketi.lDevir, 0) AS lDevir, 0 AS lBorcTutarORT, 0 AS lAlacakTutarORT, '' AS sStokKodu, '' AS sStokAciklama, 0 AS lGirenMiktar, 0 AS lCikanMiktar, 0 AS lGirenFiyat, 0 AS lCikanFiyat, tbFirmaHareketi.sHangiUygulama AS IslemTipi, 0 AS tip, 0 AS lBrutFiyat, '' AS sSatirAciklama, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0 AS lGirenTutar, 0 AS lCikanTutar, 0 AS lBrutTutar, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, isnull(tbstokfisiOdemePlani.nstokfisiID, 0) AS nStokFisiID, 0 AS lGirenMiktar2, 0 AS lCikanMiktar2, 0 AS SatirIsk, 0 AS DipIsk1, 0 AS DipIsk2, 0 AS NetFiyat, 0 AS NetTutar, '' AS FiyatTipi, '' AS BirimCinsi, 0 AS lBorcTutarORT1, 0 AS lAlacakTutarORT1, '' mintarihOrt1 FROM tbFirma, tbCariIslem, tbFirmaHareketi LEFT OUTER JOIN tbStokfisiOdemePlani ON tbStokfisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lDevirBorc, SUM(tbFirmaHareketi.lAlacakTutar) AS lDevirAlacak, SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir, 0 AS lBorcTutarORTDevir, 0 lAlacakTutarORTDevir, tbFirmaHareketi.nFirmaID FROM tbFirma, tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.sKodu like '" & Trim(sKodu) & "%' GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempFirmahareketi ON tbFirmaHareketi.nFirmaID = tbTempFirmahareketi.nFirmaID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2070' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem AND tbFirma.sKodu like '" & Trim(sKodu) & "%' ORDER BY year(dteIslemTarihi), month(dteIslemTarihi), day(dteIslemTarihi), dteIslemTarihi, year(dteValorTarihi), month(dteValorTarihi), day(dteValorTarihi), dteValorTarihi, tbFirmaHareketi.nHareketID ")
        If bDovizli = False Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lBorcTutar) AS lBorcTutar, SUM(lAlacakTutar) AS lAlacakTutar, SUM(lBakiye) AS lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1 , tbFirma.nFirmaID , lBorcTutar , lAlacakTutar , lBorcTutar - lAlacakTutar AS lBakiye FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu LIKE '" & Trim(sKodu) & "%')) TemDevir ")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lBorcTutar) AS lBorcTutar, SUM(lAlacakTutar) AS lAlacakTutar, SUM(lBakiye) AS lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1 , tbFirma.nFirmaID , lBorcTutar , lAlacakTutar , lBorcTutar - lAlacakTutar AS lBakiye FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu = '" & Trim(lKodu) & "')) TemDevir ")
        ElseIf bDovizli = True Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu LIKE '" & Trim(sKodu) & "%')) TemDevir GROUP BY sDovizCinsi1 ")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu = '" & Trim(lKodu) & "')) TemDevir GROUP BY sDovizCinsi1 ")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function irsaliyeler_sayi(ByVal sKodu As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sIrsaliyeTipi As String) As Integer
        Dim kriter As String = ""
        Dim sFisTipi As String = ""
        If sIrsaliyeTipi = "Alınan" Then
            sFisTipi = "IA"
        ElseIf sIrsaliyeTipi = "Verilen" Then
            sFisTipi = "IS"
        End If
        kriter = "WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        If sKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter += ""
        ElseIf secim = "Açık" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 0"
        ElseIf secim = "Kapalı" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 1"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) nKayit FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Close()
        cmd = Nothing
    End Function
    Public Function siparisler_sayi(ByVal sKodu As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sSiparisTipi As String) As Int64
        Dim kriter As String = ""
        Dim kriter2 = ""
        If sKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter2 = ""
        ElseIf secim = "Açık" Then
            kriter2 = " WHERE lKalanMiktar > 0"
        ElseIf secim = "Kapalı" Then
            kriter2 = " WHERE lKalanMiktar = 0"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If sSiparisTipi = "Verilen" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) nKayit FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, '' AS sKavala, tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))), 0) lSevkMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))), 0) lSevkTutari, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))), 0) lSevkIadeMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 2 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.sKodu, tbstok.sBeden, tbStok.sAciklama, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & "  ")
        ElseIf sSiparisTipi = "Alınan" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) nKayit FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, '' AS sKavala, tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 4))), 0) lSevkMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 4))), 0) lSevkTutari, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 3))), 0) lSevkIadeMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 3))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 1 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.sKodu, tbstok.sBeden, tbStok.sAciklama, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & "  ")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Close()
        cmd = Nothing
    End Function
    Private Sub dataload_kasa()
        sec_kasa.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nKasaNo,sAciklama  FROM         tbParekendeKasa ")).Tables(0)
        sec_kasa.ItemIndex = 0
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO,bIptalYapabilirmi, bVadeFarksizOdemeAlirmi, nMaxIskontoYuzdesi FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
        Dim dr As DataRow
        For Each dr In ds_kasiyer.Tables(0).Rows
            If Trim(dr("IND")) = "VC" Then
                txt_kasiyer_kod.Text = dr("SIFRE")
            End If
        Next
    End Sub
    Private Sub dataload_depo()
        sec_magaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
        sec_magaza.ItemIndex = 0
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function KayitSiniri_kontrol(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kısıtlı Kullanım.Maximum Kayıt Sınırını Aşamazsınız...!" & vbCrLf & "Lütfen Yetkili Satıcınızla Görüşün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                status = True
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub gorunum_kaydet()
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\Siparis\" & Me.Name.ToString & "")
            GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\Hareket\" & Me.Name.ToString & "")
            GridView5.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\Irsaliye\" & Me.Name.ToString & "")
        Else
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\" & sDil & "\Siparis\" & Me.Name.ToString & "")
            GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\" & sDil & "\Hareket\" & Me.Name.ToString & "")
            GridView5.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\" & sDil & "\Irsaliye\" & Me.Name.ToString & "")
        End If
        'Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("FontSize", SpinEdit1.EditValue)
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView5.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView5.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView5.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView5.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        Dim itm
        For Each itm In kisayol_siparis.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        For Each itm In kisayol_hareket.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        SimpleButton7.Text = Sorgu_sDil(SimpleButton7.Text, sDil)
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\Siparis\" & Me.Name.ToString & "")
            GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\Hareket\" & Me.Name.ToString & "")
            GridView5.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\Irsaliye\" & Me.Name.ToString & "")
        Else
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\" & sDil & "\Siparis\" & Me.Name.ToString & "")
            GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\" & sDil & "\Hareket\" & Me.Name.ToString & "")
            GridView5.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\Finans\" & sDil & "\Irsaliye\" & Me.Name.ToString & "")
        End If
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
    Public Function tbMusteri(ByVal nMusteriID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sDepo, tbFirma.sAciklama, tbFirma.sOzelNot, tbFirma.sSaticiRumuzu, tbFirma.nOzelIskontosu, tbFirma.nOzelIskontosu2, tbFirma.nOzelIskontosu3, tbFirma.nOzelIskontosu4, tbFirma.sFiyatTipi, tbFirma.lKrediLimiti, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.nVadeGun, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM(ISNULL((lBorcTutar - lAlacakTutar), 0.01) / lDovizKuru1), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, tbFirma.sDovizCinsi, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbFirma.dteKayitTarihi,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili], tbFirma.bSatisYapilamaz, tbFirma.bTahsilatYapilamaz, bAnaHesap = CASE WHEN RIGHT(tbFirma.sAciklama, 1) = '+' THEN 1 ELSE 0 END FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE tbFirma.nFirmaID ='" & nMusteriID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_tbMusteriSinifi(ByVal nFirmaID As Int64)
        'Dim kriter As String = ""
        'kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        'kriter += " SELECT tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi01 FROM tbParamCari) AS sSinifTipi, tbFSinif1.sSinifKodu, tbFSinif1.sAciklama, 0 bSatisYapilamaz FROM tbFirmaSinifi INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = " & nFirmaID & ")"
        'kriter += " UNION ALL"
        'kriter += " SELECT tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi02 FROM tbParamCari) AS sSinifTipi, tbFSinif2.sSinifKodu, tbFSinif2.sAciklama, 0 bSatisYapilamaz FROM tbFirmaSinifi INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = " & nFirmaID & ")"
        'kriter += " UNION ALL"
        'kriter += " SELECT tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi03 FROM tbParamCari) AS sSinifTipi, tbFSinif3.sSinifKodu, tbFSinif3.sAciklama, 0 bSatisYapilamaz FROM tbFirmaSinifi INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = " & nFirmaID & ")"
        'kriter += " UNION ALL"
        'kriter += " SELECT tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi04 FROM tbParamCari) AS sSinifTipi, tbFSinif4.sSinifKodu, tbFSinif4.sAciklama, 0 bSatisYapilamaz FROM tbFirmaSinifi INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = " & nFirmaID & ")"
        'kriter += " UNION ALL"
        'kriter += " SELECT tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi05 FROM tbParamCari) AS sSinifTipi, tbFSinif5.sSinifKodu, tbFSinif5.sAciklama, 0 bSatisYapilamaz FROM tbFirmaSinifi INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5= tbFSinif5.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = " & nFirmaID & ")"
        'ds_sinif = sorgu(sorgu_query("" & kriter & ""))
        'GridControl1.DataMember = Nothing
        'GridControl1.DataSource = ds_sinif.Tables(0)
    End Sub
    Private Sub dataload_odemeler(ByVal nFirmaID As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbCariIslem.sAciklama as sIslem,tbFirmaHareketi.sCariIslem AS IslemAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.lBorcTutar AS lBorcTutar, tbFirmaHareketi.lAlacakTutar AS lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sAciklama AS sFirmaHarAciklama, tbFirmaHareketi.sHareketTipi AS sHareketTipi, ISNULL(tbTempFirmahareketi.lDevirBorc, 0) AS lDevirBorc, ISNULL(tbTempFirmahareketi.lDevirAlacak, 0) AS lDevirAlacak, ISNULL(tbTempFirmahareketi.lDevir, 0) AS lDevir, tbFirmaHareketi.sHangiUygulama AS IslemTipi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.nHareketID, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID FROM (SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lDevirBorc , SUM(tbFirmaHareketi.lAlacakTutar) AS lDevirAlacak , SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , 0 AS lBorcTutarORTDevir , 0 lAlacakTutarORTDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.sKodu = '" & musterikodu & " ' GROUP BY tbFirmaHareketi.nFirmaID) tbTempFirmahareketi RIGHT OUTER JOIN tbCariIslem INNER JOIN tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID ON tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem LEFT OUTER JOIN tbStokFisiOdemePlani ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID ON tbTempFirmahareketi.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2070') AND (tbFirma.sKodu = '" & musterikodu & "') ORDER BY YEAR(tbFirmaHareketi.dteIslemTarihi), MONTH(tbFirmaHareketi.dteIslemTarihi), DAY(tbFirmaHareketi.dteIslemTarihi), tbFirmaHareketi.dteIslemTarihi, YEAR(tbFirmaHareketi.dteValorTarihi), MONTH(tbFirmaHareketi.dteValorTarihi), DAY(tbFirmaHareketi.dteValorTarihi), tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.nHareketID  ")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi,tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.sKodu LIKE '" & Trim(musterikodu) & "%' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu LIKE '" & Trim(musterikodu) & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078') ORDER BY tbFirmaHareketi.dteIslemTarihi ")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.nHareketID,tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi,tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT nCekSenetID FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.sKodu LIKE '" & Trim(musterikodu) & "%' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu LIKE '" & Trim(musterikodu) & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078') ORDER BY tbFirmaHareketi.dteIslemTarihi ")
        'lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END
        If Trim(sDovizCinsi) = "" Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.nHareketID,tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi,tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT nCekSenetID FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.nFirmaID = '" & Trim(nFirmaID) & "' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.nFirmaID = '" & Trim(nFirmaID) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078') ORDER BY tbFirmaHareketi.dteIslemTarihi ")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.nHareketID,tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sAciklama1,tbFirmaHareketi.sEvrakNo AS lFisNo, tbStokFisiMaster.nEvrakNo as EvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi,tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, ISNULL((SELECT (ISNULL(sAciklama1, '') + ' ' + ISNULL(sAciklama2, '') + ' ' + ISNULL(sAciklama3, '') + ' ' + ISNULL(sAciklama4, '') + ' ' + ISNULL(sAciklama5, '')) FROM tbStokFisiAciklamasi WHERE nStokFisiID = tbStokFisiOdemePlani.nStokFisiID), '') as sNot,tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT nCekSenetID FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.nFirmaID = '" & Trim(nFirmaID) & "' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.nFirmaID = '" & Trim(nFirmaID) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078') ORDER BY tbFirmaHareketi.dteIslemTarihi,tbFirmaHareketi.nHareketID ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.nHareketID,tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, Bakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama,tbFirmaHareketi.sAciklama1, tbFirmaHareketi.sEvrakNo AS lFisNo, tbStokFisiMaster.nEvrakNo as EvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi,tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, (SELECT     ISNULL(sAciklama1,'') FROM         tbStokFisiAciklamasi WHERE     nStokFisiID = tbStokFisiOdemePlani.nStokFisiID) sNot,tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT nCekSenetID FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.nFirmaID = '" & Trim(nFirmaID) & "' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.nFirmaID = '" & Trim(nFirmaID) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078') ORDER BY tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.dteIslemTarihi,tbFirmaHareketi.nHareketID ")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim bakiye = 0
        Dim bakiye_status = "-"
        colBakiye.SummaryItem.DisplayFormat = "(-)"
        Dim sDovizCinsi1 As String = ""
        Dim bDovizli As Boolean = True
        If Trim(sDovizCinsi) <> "" Then
            bDovizli = True
        Else
            bDovizli = False
        End If
        For Each dr In Datastoklar1.Tables(0).Rows
            If bDovizli = True Then
                If Trim(dr("sDovizCinsi1")) <> sDovizCinsi1 Then
                    bakiye = 0
                    bakiye = bakiye + dr("lDevir")
                    sDovizCinsi1 = Trim(dr("sDovizCinsi1"))
                End If
            End If
            bakiye = bakiye + (dr("lBorcTutar") - dr("lAlacakTutar"))
            dr("Bakiye") = bakiye 'Math.Abs(Convert.ToDecimal(bakiye))
            If bakiye < 0 Then
                'dr("STATUS") = "A"
                bakiye_status = "A"
            ElseIf bakiye = 0 Then
                'dr("STATUS") = "-"
                bakiye_status = "-"
            ElseIf bakiye > 0 Then
                'dr("STATUS") = "B"
                bakiye_status = "B"
            End If
            If dr("nGirisCikis") = 1 Then
            ElseIf dr("nGirisCikis") = 2 Then
                If Trim(dr("sHangiUygulama")) = "FA" Then
                    dr("sIslem") = "Alıştan İade"
                ElseIf Trim(dr("sHangiUygulama")) = "DG" Then
                    dr("sIslem") = "StokİadeEdilen"
                End If
            ElseIf dr("nGirisCikis") = 3 Then
            ElseIf dr("nGirisCikis") = 4 Then
                If Trim(dr("sHangiUygulama")) = "FS" Then
                    dr("sIslem") = "Satıştan İade"
                ElseIf Trim(dr("sHangiUygulama")) = "DC" Then
                    dr("sIslem") = "StokİadeAlınan"
                End If
            End If
        Next
        GridControl2.DataSource = Datastoklar1.Tables(0)
        colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
        If bDovizli = True Then
            GridView2.OptionsView.ShowFooter = False
            'printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.ReportFooter
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString & "(" & bakiye_status & ")"
            'collBorcTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'collAlacakTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'Gridview2.UpdateSummary()
            colsDovizCinsi1.Visible = True
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
            colsDovizCinsi1.Group()
        Else
            'printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.None
            GridView2.OptionsView.ShowFooter = True
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
            GridView2.UpdateSummary()
            colsDovizCinsi1.Visible = False
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            colsDovizCinsi1.UnGroup()
        End If
        GridView2.ExpandAllGroups()
    End Sub
    Private Sub dataload_taksitler(ByVal nMusteriID As Int64, Optional ByVal sAralik As String = "Gunluk")
        If sAralik = "Gunluk" Then
            colsYil.Visible = False
            btn_Odemeler.Text = "Aylik"
        ElseIf sAralik = "Aylik" Then
            colsYil.VisibleIndex = 0
            colsYil.Visible = True
            btn_Odemeler.Text = "Yillik"
        ElseIf sAralik = "Yillik" Then
            colsYil.VisibleIndex = 0
            colsYil.Visible = True
            btn_Odemeler.Text = "Gunluk"
        End If
        'ds_taksitler = sorgu_taksitler(nMusteriID, sAralik)
        'GridControl3.DataMember = Nothing
        'GridControl3.DataSource = ds_taksitler.Tables(0)
    End Sub
    Public Function sorgu_taksitler(ByVal nMusteriID As Int64, ByVal sAralik As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sAralik = "Gunluk" Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi, ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi, ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , tbTaksit.dteTarihi HAVING      (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) Order by tbTaksit.dteTarihi")
        ElseIf sAralik = "Aylik" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , YEAR(tbTaksit.dteTarihi) sYil,MONTH(tbTaksit.dteTarihi) dteTarihi, 0 AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ")  GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , YEAR(tbTaksit.dteTarihi),MONTH(tbTaksit.dteTarihi)) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY sYil,dteTarihi")
        ElseIf sAralik = "Yillik" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , YEAR(tbTaksit.dteTarihi) sYil,YEAR(tbTaksit.dteTarihi) dteTarihi, 0 AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ")  GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , YEAR(tbTaksit.dteTarihi),YEAR(tbTaksit.dteTarihi)) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY sYil,dteTarihi")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_lHediyeCeki_kontrol(ByVal nMusteriID As Int64) As Decimal
        Dim kriter
        Dim lHediyeCeki As Decimal = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(tbOdeme.lOdemeTutar),0) AS lHediyeCeki FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.sOdemeSekli = 'HC') AND (tbMusteri.nMusteriID = " & nMusteriID & ") ")
        lHediyeCeki = cmd.ExecuteScalar
        Return lHediyeCeki
    End Function
    Public Function sorgu_AvHediyeCeki_kontrol(ByVal nMusteriID As Int64) As Decimal
        Dim kriter
        Dim lHediyeCeki As Decimal = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKazanilanPuan - lHarcananPuan), 0) AS lKalanPuan FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , SUM(tbAVHediyeCeki.lTutar) AS lKazanilanPuan , 0 AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi = 'ParaPU_KAZ') and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu UNION ALL SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , 0 AS lKazanilanPuan , SUM(tbAVHediyeCeki.lTutar) AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi IN ('ParaPU_HAR','ParaPU_AL')) and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbPuan Where (nMusteriID = " & nMusteriID & ") ")
        lHediyeCeki = cmd.ExecuteScalar
        Return lHediyeCeki
    End Function
    Public Function sorgu_lBekleyen_kontrol(ByVal nMusteriID As Int64) As Int64
        Dim kriter
        Dim lHediyeCeki As Decimal = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(tbStok.sKodu),0) AS nKayit FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbDepo ON tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbMusteri.lKodu BETWEEN 0 AND 999999999) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbMusteri.nMusteriID = '" & nMusteriID & "') ")
        lHediyeCeki = cmd.ExecuteScalar
        Return lHediyeCeki
    End Function
    Public Function sorgu_bGecikmeIzinlimi(ByVal sMagazaKodu As String) As Boolean
        Dim bGecikmeIzinlimi As Boolean = False
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     bGecikmeIzinlimi FROM         tbParamAlisVeris WHERE     (sMagazaKodu = '" & sMagazaKodu & "') ")
        bGecikmeIzinlimi = cmd.ExecuteScalar
        Return bGecikmeIzinlimi
    End Function
    Private Sub kasiyer_kontrol(Optional ByVal bKontrol As Boolean = True)
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kasiyer_kod.Text Then
                sKasiyerRumuzu = dr("IND")
                sKasiyer = dr("KASIYER")
                sMagaza = dr("DEPO")
                bIptalYapabilirmi = dr("bIptalYapabilirmi")
                bVadeFarksizOdemeAlirmi = dr("bVadeFarksizOdemeAlirmi")
                nMaxIskontoYuzdesi = dr("nMaxIskontoYuzdesi")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            lbl_kasiyer.Text = sKasiyer
            sec_magaza.EditValue = sMagaza
            txt_kasiyer_kod.Enabled = False
            Panel_Baslik.Enabled = True
            BarSubItem1.Enabled = True
            Panel_islem.Enabled = True
            txt_musterino.Focus()
            txt_musterino.SelectAll()
            If bKontrol = True Then
                musteri_kontrol()
            Else
            End If
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf sonuc = False Then
            lbl_kasiyer.Text = ""
            txt_kasiyer_kod.Enabled = True
            txt_kasiyer_kod.EditValue = ""
            Panel_Baslik.Enabled = False
            BarSubItem1.Enabled = False
            Panel_islem.Enabled = False
            If XtraMessageBox.Show(Sorgu_sDil("Şifre Hatalı Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub Odeme()
        If txt_musterino.EditValue <> "" Then
            dataload_kasiyer()
            kasiyer_kontrol(False)
            If GridView3.RowCount > 0 Then
                Dim pass As Boolean = True
                If bVadeFarksizOdemeAlirmi = False Then
                    Dim dr As DataRow
                    For Each dr In ds_taksitler.Tables(0).Rows
                        If pass = True Then
                            If dr("GECIKME") > 1 Then
                                pass = False
                            Else
                                pass = True
                            End If
                        End If
                    Next
                Else
                    pass = True
                End If
                If pass = True Then
                    Dim frm As New frm_perakende_odeme
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.kullanici = kullanici
                    frm.sKasiyer = sKasiyer
                    frm.sKasiyerRumuzu = sKasiyerRumuzu
                    frm.sMagaza = sec_magaza.EditValue
                    frm.dteFisTarihi = DateEdit1.EditValue
                    frm.nMusteriID = nMusteriID
                    frm.lKodu = lKodu
                    frm.sMusteri = lbl_musteri_adi.Text
                    frm.nKasaNo = sec_kasa.EditValue
                    'If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                    dataload_taksitler(nMusteriID)
                    'End If
                ElseIf pass = False Then
                    XtraMessageBox.Show(Sorgu_sDil("Üzgünüm" & vbCrLf & "Gecikmiş Borcu Olan Müşterilerden Ödeme Alma Yetkiniz Yok...!" & vbCrLf & "Lütfen Sistem Yöneticinizle Görüşün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                pass = Nothing
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Bir Müşteri Hesabı Seçiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
    End Sub
    Private Sub musteri_sec()
        If Trim(sKasiyerRumuzu.ToString) <> "" Then
            Dim frm As New frm_firma_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.musterino = dr_baslik("FIRMAKODU")
            frm.islemstatus = True
            frm.kullanici = kullanici
            frm.sModul = sModul
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                nMusteriID = dr1("nFirmaID")
                lKodu = dr1("sKodu")
                'lbl_musteri_adi.Text = dr1("Musteri")
                txt_musterino.EditValue = nMusteriID
                musteri_kontrol()
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Kasiyer Bilgilerinizi Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_kasiyer_kod.Focus()
            txt_kasiyer_kod.SelectAll()
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musterino.Text).ToString <> "" And IsNumeric(Trim(txt_musterino.Text)) = True Then
            Dim kontrol = sorgu_cari_kontrol(txt_musterino.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musterino.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    lKodu = dr("sKodu")
                    nMusteriID = dr("nFirmaID")
                    nHesapID = dr("nHesapID")
                    lbl_musteri_adi.Text = dr("sAciklama")
                    sAdi = dr("sAciklama")
                    sSoyadi = ""
                    sAdres1 = dr("sAdres1")
                    sAdres2 = dr("sAdres2")
                    dataload(nMusteriID)
                Next
                dr = Nothing
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Sayısal Veri Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
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
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (nFirmaID = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_cari_no(ByVal nFirmaID As String, ByVal ops As String, ByVal siralama As String, ByVal bakiyeli As Boolean) As Int64
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        If Trim(nFirmaID.ToString) = "" Then
            nFirmaID = "0"
        End If
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If bakiyeli = False Then
            If ops = "I<" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFirmaID, 0) AS nFirmaID FROM         tbFirma  " & kriter & " ORDER BY nFirmaID " & siralama & " ")
            ElseIf ops = "<" Then
                kriter += " Where nFirmaID < " & nFirmaID & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFirmaID, 0) AS nFirmaID FROM         tbFirma  " & kriter & " ORDER BY nFirmaID " & siralama & " ")
            ElseIf ops = ">" Then
                kriter += " Where nFirmaID > " & nFirmaID & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFirmaID, 0) AS nFirmaID FROM         tbFirma  " & kriter & " ORDER BY nFirmaID " & siralama & " ")
            ElseIf ops = ">I" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFirmaID, 0) AS nFirmaID FROM         tbFirma  " & kriter & " ORDER BY nFirmaID " & siralama & " ")
            End If
        ElseIf bakiyeli = True Then
            If ops = "I<" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(FirmaID,0) FROM tbFirmaHareketi " & kriter & " GROUP BY nFirmaID HAVING (SUM(lBorcTutar - lAlacakTutar) <> 0) ORDER BY nFirmaID " & siralama & "")
            ElseIf ops = "<" Then
                kriter += " AND nFirmaID < " & nFirmaID & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(FirmaID,0) FROM tbFirmaHareketi " & kriter & " GROUP BY nFirmaID HAVING (SUM(lBorcTutar - lAlacakTutar) <> 0) ORDER BY nFirmaID " & siralama & "")
            ElseIf ops = ">" Then
                kriter += " AND nFirmaID > " & nFirmaID & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(FirmaID,0) FROM tbFirmaHareketi " & kriter & " GROUP BY nFirmaID HAVING (SUM(lBorcTutar - lAlacakTutar) <> 0) ORDER BY nFirmaID " & siralama & "")
            ElseIf ops = ">I" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(FirmaID,0) FROM tbFirmaHareketi " & kriter & " GROUP BY nFirmaID HAVING (SUM(lBorcTutar - lAlacakTutar) <> 0) ORDER BY nFirmaID " & siralama & "")
            End If
        End If
        If Trim(sSaticiRumuzu) <> "" Then
            kriter += " and tbFirma.sSaticiRumuzu IN  ( ''," & sSaticiRumuzu & " )"
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (nFirmaID = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nFirmaID, sKodu,sAciklama,sAdres1, sAdres2,nHesapID FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub analiz_bekleyen_siparis(ByVal nSiparisTipi As Integer)
        Dim frm As New frm_tbSiparis_bekleyen
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.txt_dteSiparisTarihi1.EditValue = "01/01/1900"
        frm.txt_dteSiparisTarihi2.EditValue = "31/12/2078"
        frm.txt_ara.Text = txt_sKodu.Text
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.sec_kriter.Enabled = False
        frm.nSiparisTipi = nSiparisTipi
        frm.nSiparisTipi = 1
        frm.sec_bKapandimi.Checked = False
        frm.sec_bKapandimi.Enabled = False
        If yetki_kontrol(kullanici, frm.Name.ToString) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_cari_liste_acik(ByVal sBakiye As String)
        Dim frm As New frm_firma_liste_acik
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.DateEdit1.EditValue = "01/01/1900"
        frm.DateEdit2.EditValue = "31/12/2078"
        frm.txt_ara.Text = txt_sKodu.Text
        frm.sec_konum.Text = "Kodu"
        frm.sec_islem.Text = "Detaylı"
        frm.sec_bakiye.Text = sBakiye
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbFirmaKapama(ByVal nFirmaID As Int64, ByVal bBakiye As Boolean)
        If nFirmaID > 0 Then
            Dim frm As New frm_tbFirmaKapama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = txt_sKodu.Text
            frm.nFirmaID = nFirmaID
            frm.kullanici = kullanici
            frm.bBakiye = bBakiye
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub tbFirmaKapama_Toplu()
        Dim frm As New frm_tbFirmaKapama_Toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.txt_ara.Text = txt_sKodu.Text
        frm.sec_konum.Text = "Kodu"
        frm.sec_kriter.Text = "Başlar"
        frm.GroupControl1.Enabled = False
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_risk(ByVal nFirmaID As Int64)
        If nFirmaID > 0 Then
            Dim frm As New frm_firma_risk
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = nFirmaID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim(ByVal nFirmaID As Int64)
        Dim frm As New frm_firma_iletisim
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = nFirmaID
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_stok_hareket(ByVal nFirmaID As Int64)
        If nFirmaID > 0 Then
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = 0
            frm.nFirmaID = nFirmaID
            frm.sec_firma.Checked = True
            frm.rStokCari = True
            frm.sec_giris.Text = "[Tümü]"
            frm.sec_firma.Enabled = False
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub tbStokTedarikcisi()
        Dim frm As New frm_tbStokTedarik
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.nFirmaID = nMusteriID
        frm.sFirmaKodu = txt_sKodu.Text
        frm.sFirmaAciklama = txt_sAciklama.Text
        frm.lbl_Firma.Text = txt_sAciklama.Text
        frm.txt_musteriNo.Text = txt_sKodu.Text
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If nMusteriID > 0 Then
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nFirmaId = nMusteriID
            frm.sKodu = lKodu
            frm.kullanici = kullanici
            frm.sFirmaAciklama = txt_sAciklama.Text
            frm.lbl_Firma.Text = txt_sAciklama.Text
            frm.txt_musteriNo.Text = lKodu
            frm.musterino = lKodu
            frm.sDovizCinsi = txt_sDovizCinsi.Text
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(lKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket_detayli()
        If nMusteriID > 0 Then
            Dim frm As New frm_cari_hareketler_detayli
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = lKodu
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            frm.sFirmaAciklama = txt_sAciklama.Text
            frm.lbl_Firma.Text = txt_sAciklama.Text
            frm.txt_musteriNo.Text = lKodu
            frm.musterino = lKodu
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.musterino))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_firma_KarlilikAkisTablosu(Optional ByVal islem As Integer = 2)
        If nMusteriID > 0 Then
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
            frm.kriter_musteriID = "AND tbStokFisiDetayi.nFirmaID = " & nMusteriID & " "
            If islem = 3 Then
                frm.kriter_fistipi = "'DC'"
                frm.islem = 2
            Else
                frm.islem = islem
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm = Nothing
        End If
    End Sub
    Private Sub tbFirmaHareketi()
        Dim frm As New frm_tbFirmaHareketi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.nFirmaID = nMusteriID
        frm.sKodu = lKodu
        frm.txt_musteriNo.EditValue = lKodu
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_protokol()
        'If sModul.Contains("Protokol") = True Then
        If nMusteriID > 0 Then
            Dim frm As New frm_tbStokCariProtokol
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = 0
            frm.nFirmaID = nMusteriID
            frm.txt_musteriNo.Text = lKodu
            frm.lbl_Firma.Text = sAdi
            frm.bFirma = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
        'End If
    End Sub
    Private Sub analiz_resim()
        Dim DR As DataRow
        Dim dsResim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     * FROM         tbFirmaResim WHERE     (nFirmaID = '" & nMusteriID & "') Order by nSira")
        If dsResim.Tables(0).Rows.Count > 0 Then
            DR = dsResim.Tables(0).Rows(0)
            Try
                Dim frm As New frm_tbResim
                frm.dsResim = dsResim
                frm.bTekResim = False
                frm.ShowDialog()
                frm.Close()
                frm.Dispose()
                frm = Nothing
            Catch ex As Exception
            End Try
            dsResim = Nothing
        End If
    End Sub
    Private Sub analiz_cari_bakiye()
        If nMusteriID > 0 Then
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = txt_sKodu.Text
            frm.txt_musteriNo.EditValue = txt_sKodu.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_genel()
        Dim frm As New frm_Firma_Genel
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sKodu = lKodu
        frm.txt_musteriNo.EditValue = nMusteriID
        frm.kullanici = kullanici
        'frm.sKriter = sKriter
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_Firma_karti(ByVal sKodu As String, ByVal nFirmaID As Int64)
        Dim frm As New frm_firma_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sKodu = sKodu
        frm.nFirmaID = nFirmaID
        frm.kullanici = kullanici
        frm.sModul = sModul
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub tbFirma(ByVal nFirmaID As Int64, ByVal yeni As Boolean)
        Dim frm As New frm_firma_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.yeni = yeni
        frm.nFirmaID = nFirmaID
        frm.sModul = sModul
        If yeni = True Then
            If KayitSiniri_kontrol("tbFirma", "", nKayitSinir) = True Then
                If yetki_kontrol(kullanici, "tbFirma_Kart_Yeni") = True Then
                    frm.Show()
                End If
            End If
        Else
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
        End If
    End Sub
    Private Sub tbFirma_sil(ByVal nFirmaID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If sorgu_nkayit_kontrol(nFirmaID) = 0 Then
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("set implicit_transactions on")
            cmd.ExecuteNonQuery()
            Try
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbFirmaSinifi where nFirmaID = " & nFirmaID & " ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbFirmaYetkilisi where nFirmaID = " & nFirmaID & " ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbFirmaIletisimi where nFirmaID = " & nFirmaID & " ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbFirmaAciklamasi where nFirmaID = " & nFirmaID & " ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbFirma where nFirmaID = " & nFirmaID & "")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sKodu,'') as sKodu FROM         tbFirma WHERE     (nFirmaID < '" & nFirmaID & "' ) ORDER BY sKodu DESC ")
                'sKodu = cmd.ExecuteScalar
                'txt_musteriNo.EditValue = sKodu
                'MsgBox(Sorgu_sDil("Kayıt Başarıyla Silindi...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
                'musteri_kontrol()
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüş Kaydı Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
                cmd.ExecuteNonQuery()
            End Try
            con.Close()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüş Kaydı Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Public Function sorgu_nkayit_kontrol(ByVal nFirmaID As String) As Int64
        Dim kriter
        kriter = "WHERE (nFirmaID = '" & nFirmaID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(count(nFirmaID),0) as nKayit from tbFirmaHareketi " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbFirma_notlari(ByVal nFirmaID As Int64, Optional ByVal sTable As String = "tbFirmaAciklamasi")
        Dim frm As New frm_musteri_karti_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = nFirmaID
        frm.kullanici = kullanici
        If sTable = "tbFirmaHareketi" Then
            frm.nStokFisiID = nFirmaID
            frm.tbFirmaHareketi = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                dr("sAciklama1") = frm.txt_aciklama1.Text
            End If
        Else
            frm.kayitno = nFirmaID
            frm.firma = True
            If sorgu_tbFirmaTablo_kontrol(nFirmaID, sTable) = 0 Then
                tbFirmaAciklamasi_kaydet_yeni(nFirmaID, "", "", "", "", "")
            End If
            frm.ShowDialog()
        End If
        'Firma Açıklaması Kontrol
    End Sub
    Public Function sorgu_tbFirmaTablo_kontrol(ByVal nFirmaID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nFirmaID = '" & nFirmaID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbFirmaAciklamasi_kaydet_yeni(ByVal nFirmaID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaAciklamasi (nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nFirmaID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub fis_duzelt()
        If GridView2.RowCount > 0 Then
            If yetki_kontrol(kullanici, "frm_Cari_Hareket_Duzelt") = True Then
                Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                If Trim(dr("IslemTipi")) = "FA" Or Trim(dr("IslemTipi")) = "FS" Or Trim(dr("IslemTipi")) = "DG" Or Trim(dr("IslemTipi")) = "DC" Or Trim(dr("IslemTipi")) = "HA" Or Trim(dr("IslemTipi")) = "HS" Or Trim(dr("IslemTipi")) = "MM" Or Trim(dr("IslemTipi")) = "T" Then
                    Dim bAc As Boolean = False
                    Dim dteIslemTarihi As DateTime = dr("dteIslemTarihi")
                    'MsgBox(dteIslemTarihi & vbTab & dteSonFaturaTarihi)
                    If Trim(dr("IslemTipi")) = "FA" And dteIslemTarihi > dteSonFaturaTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "HA" And dteIslemTarihi > dteSonFaturaTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "HS" And dteIslemTarihi > dteSonFaturaTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "FS" And dteIslemTarihi > dteSonFaturaTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "DG" And dteIslemTarihi > dteSonStokFisiTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "DC" And dteIslemTarihi > dteSonStokFisiTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "IA" And dteIslemTarihi > dteSonIrsaliyeTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "IS" And dteIslemTarihi > dteSonIrsaliyeTarihi Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "T" And dteIslemTarihi > dteSonIrsaliyeTarihi And (dr("lBorcTutar") - dr("lAlacakTutar")) > 0 Then
                        bAc = True
                    ElseIf Trim(dr("IslemTipi")) = "MM" And dteIslemTarihi > dteSonFaturaTarihi Then
                        bAc = True
                    End If
                    If bAc = True Then
                        Dim frm As New frm_fatura
                        frm.firmano = firmano
                        frm.donemno = donemno
                        frm.connection = connection
                        frm.lFisNo = dr("lFisNo")
                        frm.dteFisTarihi = dr("dteIslemTarihi")
                        frm.sFisTipi = dr("IslemTipi")
                        'frm.nFirmaID = dr("nFirmaID")
                        'frm.nGirisCikis = dr("nGirisCikis")
                        frm.nStokFisiID = dr("nStokFisiID")
                        frm.kullanici = kullanici
                        If yetki_kontrol(kullanici, frm.Name) = True Then
                            frm.ShowDialog()
                        End If
                        frm.Close()
                        frm.Dispose()
                        frm = Nothing
                        dr = Nothing
                        Dim satir = GridView2.FocusedRowHandle
                        dataload(nMusteriID)
                        GridView2.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    bAc = Nothing
                    dteIslemTarihi = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "MUH" Then
                    Dim frm As New frm_tbMuhasebeFisi
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.dteFisTarihi = dr("dteIslemTarihi")
                    frm.lFisNo = sorgu_sayi(dr("lFisNo"), 0)
                    'frm.txt_lYevmiyeNo.EditValue = dr("lYevmiyeNo")
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView2.FocusedRowHandle
                        dataload(nMusteriID)
                        GridView2.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "" Then
                    Dim frm As New frm_tbFirmaHareketi
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_dteTarih1.EditValue = dr("dteIslemTarihi")
                    frm.txt_dteTarih2.EditValue = dr("dteIslemTarihi")
                    frm.sKodu = lKodu
                    frm.txt_musteriNo.Text = lKodu
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    frm.nHareketID = dr("nHareketID")
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView2.FocusedRowHandle
                        dataload(nMusteriID)
                        GridView2.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "CG" Or Trim(dr("sHangiUygulama")) = "CC" Or Trim(dr("sHangiUygulama")) = "TCG" Or Trim(dr("sHangiUygulama")) = "TCC" Then
                    analiz_tbFirmaBordro(dr("nFirmaID"), dr("nHareketID"))
                    Dim satir As String = GridView2.FocusedRowHandle
                    dataload(nMusteriID)
                    GridView2.FocusedRowHandle = satir
                    satir = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "KASA" Then
                    Dim frm As New frm_tbNakitKasa
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_dteIslemTarihi1.EditValue = dr("dteIslemTarihi")
                    frm.txt_dteIslemTarihi2.EditValue = dr("dteIslemTarihi")
                    frm.nHareketID = dr("nHareketID")
                    frm.sFirmaKodu = lKodu
                    frm.nFirmaid = nMusteriID
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView2.FocusedRowHandle
                        dataload(nMusteriID)
                        GridView2.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "BC" Or Trim(dr("sHangiUygulama")) = "BS" Or Trim(dr("sHangiUygulama")) = "AC" Or Trim(dr("sHangiUygulama")) = "AS" Then
                    analiz_tbCekSenet_Hareket()
                End If
            End If
        End If
    End Sub
    Private Sub analiz_tbFirmaBordro(ByVal nFirmaID As Int64, ByVal nHareketID As Int64)
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim dr1 As DataRow
            Dim ds_tbFirmaBordroMaster As DataSet = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaBordroMaster.nBordroID, tbFirmaBordroMaster.dteBordroTarihi, tbFirmaBordroMaster.lBordroNo, tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster ON tbFirmaBordroDetay.nBordroID = tbFirmaBordroMaster.nBordroID WHERE (tbFirmaBordroDetay.nFirmaID = " & nFirmaID & ") and (tbFirmaBordroDetay.nHareketID = " & nHareketID & ")"))
            If ds_tbFirmaBordroMaster.Tables(0).Rows.Count > 0 Then
                dr1 = ds_tbFirmaBordroMaster.Tables(0).Rows(0)
                Dim frm As New frm_tbFirmaBordro
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.kullanici = kullanici
                frm.sFisTipi = dr1("sFisTipi")
                frm.nGirisCikis = dr1("nGirisCikis")
                frm.nBordroID = dr1("nBordroID")
                frm.sFisTipi = dr1("sFisTipi")
                frm.nGirisCikis = dr1("nGirisCikis")
                frm.sHareketID = nHareketID
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                    Dim satir As String = GridView2.FocusedRowHandle
                    GridView2.FocusedRowHandle = satir
                    satir = Nothing
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
                dr1 = Nothing
                ds_tbFirmaBordroMaster.Dispose()
                ds_tbFirmaBordroMaster = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_tbCekSenet_Hareket()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("nCekSenetID").ToString <> "" Then
                Dim frm As New frm_tbCekSenet_Hareketleri
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.nCekSenetID = dr("nCekSenetID").ToString
                frm.lCekSenetNo = dr("lFisNo").ToString
                frm.sCekSenetTipi = dr("sHangiUygulama").ToString
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
    Private Sub tbFis_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        Dim bDevam As Boolean = False
        If nGirisCikis = 1 Or nGirisCikis = 3 Then
            If bSatisYapilamaz = True Then
                XtraMessageBox.Show(Sorgu_sDil("Bu Hesaba Satış/Alış Yapılamaz..." & vbCrLf & "Lütfen Sistem Yöneticinizle Görüşünüz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Stop)
                bDevam = False
            Else
                bDevam = True
            End If
        ElseIf nGirisCikis = 2 Or nGirisCikis = 4 Then
            bDevam = True
        End If
        If bDevam = True Then
            If KayitSiniri_kontrol("tbStokFisiMaster", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True Then
                If yetki_kontrol(kullanici, sFisTipi) = True And yetki_kontrol(kullanici, Trim(sFisTipi) & "_IslemYapamaz", False, 0) = False Then
                    Dim frm As New frm_fatura
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.kullanici = kullanici
                    frm.nStokFisiID = ""
                    frm.nFirmaID = nMusteriID
                    frm.nOpsiyon = sorgu_sayi(txt_nVadeGun.Text, 0)
                    If Trim(txt_sDovizCinsi.Text) <> "" Then
                        frm.sDovizCinsi1 = Trim(txt_sDovizCinsi.Text)
                        frm.lDovizKuru1 = sorgu_lDovizKuru(txt_sDovizCinsi.Text.ToString)
                    End If
                    frm.sFisTipi = sFisTipi
                    If sFisTipi = "HS " Or sFisTipi = "HA " Then
                        frm.bHizmetFaturasimi = True
                    End If
                    Try
                        frm.cariDepo = sDepoFirma
                    Catch ex As Exception
                        frm.cariDepo = ""
                    End Try
                    frm.nGirisCikis = nGirisCikis
                    frm.dteFisTarihi = dteSistemTarihi
                    'frm.MdiParent = Me
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.Show()
                    End If
                    'frm.Close()
                    'frm.Dispose()
                    'frm = Nothing
                End If
            End If
        End If
    End Sub
    Private Sub tbFis_liste(ByVal sFisTipi As String, ByVal nGirisCikis As Int64, Optional ByVal kapla As Boolean = False)
        If KayitSiniri_kontrol("tbStokFisiMaster", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True Then
            If yetki_kontrol(kullanici, sFisTipi & "Liste") = True Then
                Dim frm As New frm_fatura_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.kullanici = kullanici
                frm.sFisTipi = sFisTipi
                frm.nGirisCikis = nGirisCikis
                If kapla = True Then
                    frm.MdiParent = Me
                    frm.WindowState = FormWindowState.Maximized
                Else
                    frm.WindowState = FormWindowState.Normal
                End If
                frm.kapla = kapla
                'frm.MdiParent = Me
                'frm.WindowState = FormWindowState.Normal
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.Show()
                End If
            End If
        End If
    End Sub
    Private Sub tbBordro_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer, Optional ByVal sModul As String = "Cari")
        Dim bDevam As Boolean = False
        If nGirisCikis = 1 Or nGirisCikis = 3 Then
            If bTahsilatYapilamaz = True Then
                XtraMessageBox.Show(Sorgu_sDil("Bu Hesaba Tahsilat/Ödeme Yapılamaz..." & vbCrLf & "Lütfen Sistem Yöneticinizle Görüşünüz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Stop)
                bDevam = False
            Else
                bDevam = True
            End If
        End If
        If bDevam = True Then
            If KayitSiniri_kontrol("tbFirmaBordroMaster", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True Then
                If yetki_kontrol(kullanici, sFisTipi) = True And yetki_kontrol(kullanici, Trim(sFisTipi) & "_IslemYapamaz", False, 0) = False Then
                    Dim frm As New frm_tbFirmaBordro
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.kullanici = kullanici
                    frm.sFisTipi = sFisTipi
                    frm.nGirisCikis = nGirisCikis
                    frm.sModul = sModul
                    frm.nFirmaID = nMusteriID
                    frm.sSaticiRumuzu = txt_sSaticiRumuzu.Text
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.Show()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub tbBordro_liste(ByVal sFisTipi As String, ByVal nGirisCikis As Integer, Optional ByVal sModul As String = "Cari")
        If KayitSiniri_kontrol("tbFirmaBordroMaster", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True Then
            If yetki_kontrol(kullanici, sFisTipi) = True Then
                Dim frm As New frm_tbFirmaBordro_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.kullanici = kullanici
                frm.sFisTipi = sFisTipi
                frm.nGirisCikis = nGirisCikis
                frm.sModul = sModul
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.Show()
                End If
            End If
        End If
    End Sub
    Private Sub tbSiparis(ByVal nSiparisTipi As String)
        Dim sSiparisTipi As String = ""
        If nSiparisTipi = 1 Then
            sSiparisTipi = "Alinan Siparis"
        ElseIf nSiparisTipi = 2 Then
            sSiparisTipi = "VerilenSiparis"
        ElseIf nSiparisTipi = 4 Then
            sSiparisTipi = "Proforma"
        End If
        If yetki_kontrol(kullanici, sSiparisTipi) = True Then
            Dim frm As New frm_tbSiparis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nFirmaID = nMusteriID
            frm.nSiparisTipi = nSiparisTipi
            frm.dteSiparisTarihi = dteSistemTarihi
            frm.islemstatus = False
            frm.yeni = True
            'frm.MdiParent = Me
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
            'frm.Close()
            'frm.Dispose()
            'frm = Nothing
        End If
    End Sub
    Private Sub tbSiparis_liste(ByVal nSiparisTipi As String)
        Dim sSiparisTipi As String = ""
        If nSiparisTipi = 1 Then
            sSiparisTipi = "Alinan Siparis"
        ElseIf nSiparisTipi = 2 Then
            sSiparisTipi = "VerilenSiparis"
        End If
        If yetki_kontrol(kullanici, sSiparisTipi) = True Then
            Dim frm As New frm_tbSiparis_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nSiparisTipi = nSiparisTipi
            frm.WindowState = FormWindowState.Normal
            frm.txt_ara.Text = txt_sKodu.Text
            frm.sKodu = txt_sKodu.Text
            frm.txt_dteSiparisTarihi1.EditValue = "01/01/1900"
            frm.txt_dteSiparisTarihi2.EditValue = "31/12/2078"
            frm.sec_konum.Text = "Kodu"
            frm.sec_kriter.Text = "Başlar"
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
        End If
    End Sub
    Private Sub analiz_siparis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbSiparis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.dteSiparisTarihi = dr("dteSiparisTarihi")
            frm.lSiparisNo = dr("lSiparisNo")
            frm.nFirmaID = dr("nFirmaID")
            'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
            frm.sSiparisiAlan = "" 'dr("sSiparisiAlan")
            frm.sSiparisiVeren = "" ' dr("sSiparisiVeren")
            frm.nSiparisTipi = dr("nSiparisTipi")
            frm.kullanici = kullanici
            frm.islemstatus = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            dataload_siparis(sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue, sec_kriter.Text, sec_sSiparisTipi.Text)
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub tbSiparis_bekleyen(ByVal nSiparisTipi As Integer, ByVal sFirmaKodu As String)
        Dim frm As New frm_tbSiparis_bekleyen
        frm.txt_dteSiparisTarihi1.EditValue = "01/01/1900"
        frm.txt_dteSiparisTarihi2.EditValue = "31/12/2078"
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.nSiparisTipi = nSiparisTipi
        frm.sec_sSiparisTipi.Enabled = True
        frm.txt_ara.Text = sFirmaKodu
        frm.sec_konum.Text = "Kodu"
        frm.sec_kriter.Text = "Başlar"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.sec_kriter.Enabled = False
        frm.coldteTeslimTarihi.Caption = "SonTarih"
        'frm.txt_dteBordroTarihi.EditValue = dteSistemTarihi
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub tbCekSenet_Liste(ByVal sCekSenetTipi As String, ByVal sKodu As String, Optional ByVal nCekSenetIslem As Integer = 1, Optional ByVal sCekSenetIslem As String = "")
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sCekSenetTipi
        If sCekSenetTipi = "AC" And sCekSenetIslem = "" Then
            frm.nCekSenetIslem = 1
            frm.sCekSenetIslem = "'1','6'"
        ElseIf sCekSenetTipi = "BC" And sCekSenetIslem = "" Then
            frm.nCekSenetIslem = 20
            frm.sCekSenetIslem = "'20'"
        Else
            frm.nCekSenetIslem = nCekSenetIslem
            frm.sCekSenetIslem = sCekSenetIslem
        End If
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.bCekSenetIslemGoster = True
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub tbMusteri_yeni()
        If KayitSiniri_kontrol("tbMusteri", "", nKayitSinir) = True Then
            Dim frm As New frm_musteri_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = 0
            frm.kullanici = kullanici
            frm.sMagaza = sec_magaza.EditValue
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    txt_musterino.Text = frm.txt_musteriNo.Text
                    musteri_kontrol()
                End If
            End If
        End If
    End Sub
    Private Sub tbMusteri_sil(ByVal nMusteriID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMusteriKefil1 where nMusteriID = " & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMusteriKefil2 where nMusteriID = " & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMusteriNufusu where nMusteriID =" & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMusteriSinifi where nMusteriID = " & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMusteriKredisi where nMusteriID =" & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbKefil1Nufusu where nMusteriID =" & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbKefil2Nufusu where nMusteriID =" & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMusteri where nMusteriID = " & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMusteri SET lMusteriNo = (SELECT TOP 1 ISNULL(lKodu,1) FROM tbMusteri ORDER BY cast(lKodu AS decimal) DESC)")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lKodu,0) as lKodu FROM         tbMusteri WHERE     (nMusteriID < " & nMusteriID & " ) ORDER BY lKodu DESC ")
            txt_musterino.EditValue = cmd.ExecuteScalar
            XtraMessageBox.Show(Sorgu_sDil("Kayıt Başarıyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            musteri_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüş Kaydı Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub SMS_Gonder()
        If XtraMessageBox.Show(Sorgu_sDil("SMS Göndermek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            If Trim(txt_sGSM.Text.ToString) <> "" Then
                Dim dr_baslik As DataRow = ds_tbFirma.Tables(0).Rows(0)
                Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                dr1("nIslemID") = 0
                dr1("sSMSID") = 0
                dr1("dteGonderimTarihi") = Today
                dr1("sMesaj") = ""
                dr1("nMusteriID") = txt_nFirmaID.Text
                dr1("lKodu") = txt_musterino.Text
                dr1("sAdi") = txt_sAciklama.Text
                dr1("sSoyadi") = ""
                dr1("sTelefon") = dr_baslik("Gsm").ToString
                dr1("dteUpdateTarihi") = Now
                dr1("lDurum") = 0
                dr1("lBakiye") = txt_lBakiye.Text
                frm.DataSet1.Tables(0).Rows.Add(dr1)
            End If
            'MsgBox(Sorgu_sDil("İşlem Tamamlandı...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            frm.ShowDialog()
        End If
    End Sub
    Private Sub txt_kasiyer_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kasiyer_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        ElseIf e.KeyCode = Keys.Space Then
            Dim deger = ""
            deger = InputBox("MüşteriNumarasını Okutun", "MüşteriKartOkut", "").ToString
            If deger.ToString <> "" Then
                txt_musterino.Text = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Decimal)
                musteri_kontrol()
            End If
            deger = Nothing
        End If
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Finans Yönetimi Ekranından Çıkmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        musteri_sec()
    End Sub
    Private Sub sec_kasa_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_kasa.EditValueChanged
        lbl_kasa.Text = sec_kasa.Text
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles M_Islem_IadeAl.ItemClick
        tbFis_ekle("FS ", 4)
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        tbFirma(0, True)
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Kaydı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nMusteriID)
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        txt_musterino.EditValue = sorgu_cari_no(txt_musterino.EditValue.ToString, "I<", "ASC", sec_bakiyeli.Checked)
        txt_musterino.Text = txt_musterino.EditValue
        musteri_kontrol()
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        txt_musterino.EditValue = sorgu_cari_no(txt_musterino.EditValue.ToString, "<", "DESC", sec_bakiyeli.Checked)
        txt_musterino.Text = txt_musterino.EditValue
        musteri_kontrol()
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        txt_musterino.EditValue = sorgu_cari_no(txt_musterino.EditValue.ToString, "I<", "DESC", sec_bakiyeli.Checked)
        txt_musterino.Text = txt_musterino.EditValue
        musteri_kontrol()
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        txt_musterino.EditValue = sorgu_cari_no(txt_musterino.EditValue.ToString, ">", "ASC", sec_bakiyeli.Checked)
        txt_musterino.Text = txt_musterino.EditValue
        musteri_kontrol()
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub btn_yenile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_yenile.Click
        musteri_kontrol()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Finans Ekranından Çıkmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btn_Musteri_sec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_sec.Click
        musteri_sec()
    End Sub
    Private Sub btn_Musteri_Yeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Yeni.Click
        tbFirma(0, True)
    End Sub
    Private Sub btn_Musteri_Kart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Kart.Click
        analiz_Firma_karti(txt_sKodu.Text, nMusteriID)
    End Sub
    Private Sub btn_Musteri_Not_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Not.Click
        tbFirma_notlari(nMusteriID)
    End Sub
    Private Sub btn_Musteri_Duzelt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Duzelt.Click
        analiz_iletisim(nMusteriID)
    End Sub
    Private Sub btn_Islem_Satis_Kredili_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_SatisYap.Click
        tbFis_ekle("FS ", 3)
    End Sub
    Private Sub btn_Islem_Satis_Pesin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_Alis_Yap.Click
        tbFis_ekle("FA ", 1)
    End Sub
    Private Sub btn_Islem_Siparis_Kredili_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_IadeAl.Click
        tbFis_ekle("FS ", 4)
    End Sub
    Private Sub btn_Islem_Siparis_Pesin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_IadeEt.Click
        tbFis_ekle("FA ", 2)
    End Sub
    Private Sub btn_Islem_Odeme_Al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_CariGiris.Click
        tbBordro_ekle("CG", 1)
    End Sub
    Private Sub btn_Islem_VadeFarki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_CariCikis.Click
        tbBordro_ekle("CC", 3)
    End Sub
    Private Sub btn_Raporlar_Ekstre_Detayli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Raporlar_Ekstre_Detayli.Click
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub btn_Ekstre_Ozet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ekstre_Ozet.Click
        analiz_cari_hareket()
    End Sub
    Private Sub btn_Analiz_Odemeler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Odemeler.Click
        tbFirmaKapama(nMusteriID, False)
    End Sub
    Private Sub GridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        fis_duzelt()
    End Sub
    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        End If
    End Sub
    Private Sub SimpleButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        SMS_Gonder()
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub btn_Musteri_Sozlesme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If XtraMessageBox.Show(Sorgu_sDil("Kaydı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nMusteriID)
        End If
    End Sub
    Private Sub btn_Islem_Teslimat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_SiparisAl.Click
        tbSiparis(1)
    End Sub
    Private Sub btn_Islem_VadeAyarla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_SiparisVer.Click
        tbSiparis(2)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_Firma_karti(lKodu, nMusteriID)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        tbFirma_notlari(nMusteriID)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_iletisim(nMusteriID)
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles M_Islem_SatisYap.ItemClick
        tbFis_ekle("FS ", 3)
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles M_Islem_AlisYap.ItemClick
        tbFis_ekle("FA ", 1)
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles M_Islem_IadeEt.ItemClick
        tbFis_ekle("FA ", 2)
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        tbBordro_ekle("CG", 1)
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        tbBordro_ekle("CC", 3)
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles M_Islem_SiparisAl.ItemClick
        tbSiparis(1)
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles M_Islem_SiparisVer.ItemClick
        tbSiparis(2)
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        analiz_risk(nMusteriID)
    End Sub
    Private Sub btn_Analiz_Satislar_Bekleyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_SiparisAlinanlar.Click
        tbSiparis_bekleyen(1, txt_sKodu.Text)
    End Sub
    Private Sub btn_Analiz_Kalan_Taksitler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Kalan_Taksitler.Click
        analiz_cari_liste_acik("Alacaklar")
    End Sub
    Private Sub btn_Analiz_Kalan_Satislar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Kalan_Satislar.Click
        analiz_cari_liste_acik("Borclar")
    End Sub
    Private Sub btn_Analiz_Satislar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Satislar.Click
        tbFirmaKapama(nMusteriID, True)
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        tbSiparis_bekleyen(3, txt_sKodu.Text)
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_SiparisVerilen.Click
        tbSiparis_bekleyen(2, txt_sKodu.Text)
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        tbCekSenet_Liste("AC", txt_sKodu.Text)
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        tbCekSenet_Liste("BC", txt_sKodu.Text)
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        tbFirmaKapama_Toplu()
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        analiz_stok_hareket(nMusteriID)
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        analiz_risk(nMusteriID)
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        analiz_cari_genel()
    End Sub
    
    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton14.Click
        analiz_firma_KarlilikAkisTablosu()
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        analiz_firma_KarlilikAkisTablosu()
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        tbFirmaHareketi()
    End Sub
    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton15.Click
        tbFirmaHareketi()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        analiz_resim()
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        tbCekSenet_Liste("AC", txt_sKodu.Text)
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        tbCekSenet_Liste("BC", txt_sKodu.Text)
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        tbCekSenet_Liste("AC", txt_sKodu.Text, 5, "'5'")
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        tbCekSenet_Liste("AC", txt_sKodu.Text, 3, "'3'")
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        tbCekSenet_Liste("AC", txt_sKodu.Text, 4, "'4'")
    End Sub
    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        tbCekSenet_Liste("AC", txt_sKodu.Text, 9, "'9'")
    End Sub
    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        tbCekSenet_Liste("AC", txt_sKodu.Text, 11, "'11'")
    End Sub
    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton16.Click
        tbMuhasebeFisi()
    End Sub
    Private Sub tbMuhasebeFisi_KrediKarti(ByVal sOdemeSekli As String)
        Dim bDevam As Boolean = False
        If bTahsilatYapilamaz = True Then
            XtraMessageBox.Show(Sorgu_sDil("Bu Hesaba Tahsilat/Ödeme Yapılamaz..." & vbCrLf & "Lütfen Sistem Yöneticinizle Görüşünüz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Stop)
            bDevam = False
        Else
            bDevam = True
        End If
        If bDevam = True Then
            Dim frm As New frm_tbMuhasebeFisi_KrediKarti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.dteFisTarihi = dteSistemTarihi
            frm.sec_sDefter.Text = sOdemeSekli
            frm.sMusteriKodu = lKodu
            frm.sMusteriAciklama = sAdi
            frm.nMusteriFirmaID = nMusteriID
            frm.nMusteriHesapID = nHesapID
            frm.txt_musterino.Text = lKodu
            frm.lbl_sMusteriAciklama.Text = sAdi
            frm.txt_lTutar.EditValue = Math.Abs(dr_baslik("lBakiye"))
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                dataload(nMusteriID)
            End If
        End If
    End Sub
    Private Sub tbMuhasebeFisi(Optional ByVal sMuhFisTipi As Integer = 3, Optional ByVal sFisAciklama As String = "", Optional ByVal bMuhasebe As Boolean = False, Optional ByVal sModul As String = "Cari")
        Dim frm As New frm_tbMuhasebeFisi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.dteFisTarihi = dteSistemTarihi
        frm.sMuhFisTipi = sMuhFisTipi
        frm.yeni = True
        frm.bMuhasabe = bMuhasebe
        frm.sFisAciklama = sFisAciklama
        frm.sModul = sModul
        If yetki_kontrol(kullanici, frm.Name) = True And yetki_kontrol(kullanici, frm.Name.ToString & "_IslemYapamaz", False, 0) = False Then
            If bMuhasebe = False Then
                frm.txt_ara.Text = lKodu
                frm.sKodu = lKodu
                frm.sModul = sModul
                frm.Show()
            End If
        ElseIf bMuhasebe = True Then
            frm.sKodu = dr1("sKodu")
            frm.nFirmaID = dr1("nFirmaID")
            frm.txt_sKodu.Text = dr1("sKodu")
            frm.sDovizCinsi = sorgu_string(dr1("sDovizCinsi").ToString, "")
            frm.txt_ara.Text = lKodu
            frm.sKodu = lKodu
            frm.sModul = sModul
            frm.Show()
        Else
            frm.Show()
        End If
    End Sub
    
    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click
        tbMuhasebeFisi_KrediKarti("Tahsilat")
    End Sub
    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        tbMuhasebeFisi_KrediKarti("Ödeme")
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        analiz_protokol()
    End Sub
    
    Private Sub SimpleButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton19.Click
        dataload_siparis(sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue, sec_kriter.Text, sec_sSiparisTipi.Text)
    End Sub
    Private Sub dataload_siparis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sSiparisTipi As String)
        ds_siparis = siparisler(tarih1, tarih2, secim, sSiparisTipi)
        GridControl1.DataSource = ds_siparis.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub dataload_irsaliye(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sIrsaliyeTipi As String)
        ds_irsaliye = irsaliyeler(tarih1, tarih2, secim, sIrsaliyeTipi)
        GridControl5.DataSource = ds_irsaliye.Tables(0)
        GridControl5.DataMember = Nothing
        GridControl5.Focus()
        GridControl5.Select()
    End Sub
    Public Function siparisler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sSiparisTipi As String) As DataSet
        Dim kriter As String = ""
        Dim kriter2 = ""
        If lKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & lKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter2 = ""
        ElseIf secim = "Açık" Then
            kriter2 = " WHERE lKalanMiktar > 0"
        ElseIf secim = "Kapalı" Then
            kriter2 = " WHERE lKalanMiktar = 0"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sSiparisTipi = "Verilen" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sSinifAciklama, nFirmaID,sFirmaKodu, sFirmaAdi, nStokID,sKodu,sModel, sRenk, sRenkAdi, sBeden, sKavala, lMevcut,sAciklama, sSatirAciklama, dteIlkSevkiyatTarihi, sBirimCinsi, sSipNo, dteSiparisTarihi, lSiparisNo,nSiparisTipi,nSiparisID,dteTeslimtarihi, sSiparisIslem, SiparisMiktari, SiparisTutari, SiparisTutari1, SiparisTutari2, lSevkMiktari, lSevkTutari, lReserveMiktari - lSevkMiktari + lsevkIadeMiktari, lKalanMiktar, KalanTutar, sPartiKodu, lGirisMiktar, lGirisTutar, lEnvanterMiktar, lEnvanterTutar, lFarkMiktar, lFarkTutar, lKrediLimiti, nValorGun, cast(bKapandimi AS int) bKapandimi, lBirimFiyati, sDovizCinsi, lDovizKuru, lDovizFiyati, lSevkIadeMiktari, lSevkIadeTutari, lBakiye, lToplamRisk, lBirimFiyati1, lBirimFiyati2 FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.nStokID,tbStok.sKodu,tbStok.sModel AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, tbStok.sKavala AS sKavala, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut,tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.lSiparisNo,tbSiparis.nSiparisTipi,tbSiparis.nSiparisID,tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))), 0) lSevkMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))), 0) lSevkTutari, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))), 0) lSevkIadeMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 2 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.nStokID,tbStok.sKodu, tbStok.sModel,tbstok.sBeden,tbStok.sKavala, tbStok.sAciklama, tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisTipi,tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & " ORDER BY sFirmaKodu, sModel, sRenk, sBeden, sKavala ")
        ElseIf sSiparisTipi = "Alınan" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sSinifAciklama, nFirmaID,sFirmaKodu, sFirmaAdi, nStokID,sKodu,sModel, sRenk, sRenkAdi, sBeden, sKavala, lMevcut,sAciklama, sSatirAciklama, dteIlkSevkiyatTarihi, sBirimCinsi, sSipNo, dteSiparisTarihi, lSiparisNo,nSiparisTipi,nSiparisID,dteTeslimtarihi, sSiparisIslem, SiparisMiktari, SiparisTutari, SiparisTutari1, SiparisTutari2, lSevkMiktari, lSevkTutari, lReserveMiktari - lSevkMiktari + lsevkIadeMiktari, lKalanMiktar, KalanTutar, sPartiKodu, lGirisMiktar, lGirisTutar, lEnvanterMiktar, lEnvanterTutar, lFarkMiktar, lFarkTutar, lKrediLimiti, nValorGun, cast(bKapandimi AS int) bKapandimi, lBirimFiyati, sDovizCinsi, lDovizKuru, lDovizFiyati, lSevkIadeMiktari, lSevkIadeTutari, lBakiye, lToplamRisk, lBirimFiyati1, lBirimFiyati2 FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.nStokID,tbStok.sKodu,tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, tbStok.sKavala AS sKavala, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut,tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.lSiparisNo,tbSiparis.nSiparisTipi,tbSiparis.nSiparisID,tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 4))), 0) lSevkMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 4))), 0) lSevkTutari, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 3))), 0) lSevkIadeMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 3))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 1 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.nStokID,tbStok.sKodu, tbStok.sModel,tbstok.sBeden, tbStok.sKavala,tbStok.sAciklama, tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisTipi,tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & " ORDER BY sFirmaKodu, sModel, sRenk, sBeden, sKavala ")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function siparisler_sayi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sSiparisTipi As String) As Int64
        Dim kriter As String = ""
        Dim kriter2 = ""
        If lKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & lKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter2 = ""
        ElseIf secim = "Açık" Then
            kriter2 = " WHERE lKalanMiktar > 0"
        ElseIf secim = "Kapalı" Then
            kriter2 = " WHERE lKalanMiktar = 0"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If sSiparisTipi = "Verilen" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) nKayit FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, '' AS sKavala, tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))), 0) lSevkMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))), 0) lSevkTutari, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))), 0) lSevkIadeMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 2 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.sKodu, tbstok.sBeden, tbStok.sAciklama, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & "  ")
        ElseIf sSiparisTipi = "Alınan" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) nKayit FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, '' AS sKavala, tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 4))), 0) lSevkMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 4))), 0) lSevkTutari, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 3))), 0) lSevkIadeMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 3))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 1 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.sKodu, tbstok.sBeden, tbStok.sAciklama, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & "  ")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Close()
        cmd = Nothing
    End Function
    Public Function irsaliyeler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sIrsaliyeTipi As String) As DataSet
        Dim kriter As String = ""
        Dim sFisTipi As String = ""
        If sIrsaliyeTipi = "Alış" Then
            sFisTipi = "IA"
        ElseIf sIrsaliyeTipi = "Satış" Then
            sFisTipi = "IS"
        End If
        kriter = "WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        If lKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & lKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter += ""
        ElseIf secim = "Açık" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 0"
        ElseIf secim = "Kapalı" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 1"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function irsaliyeler_sayi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sIrsaliyeTipi As String) As Integer
        Dim kriter As String = ""
        Dim sFisTipi As String = ""
        If sIrsaliyeTipi = "Alınan" Then
            sFisTipi = "IA"
        ElseIf sIrsaliyeTipi = "Verilen" Then
            sFisTipi = "IS"
        End If
        kriter = "WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        If lKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & lKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter += ""
        ElseIf secim = "Açık" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 0"
        ElseIf secim = "Kapalı" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 1"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) nKayit FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Close()
        cmd = Nothing
    End Function
    Private Sub irsaliye_duzelt()
        If GridView5.RowCount > 0 Then
            Dim dr As DataRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteFisTarihi")
            frm.sFisTipi = dr("sFisTipi")
            frm.nFirmaID = dr("nFirmaID")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokFisiID = dr("nStokFisiID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            Dim satir = GridView5.FocusedRowHandle
            dataload(nMusteriID)
            GridView5.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub SimpleButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton20.Click
        ara_irsaliye()
    End Sub
    Private Sub ara_irsaliye()
        dataload_irsaliye(DateEdit3.EditValue, DateEdit2.EditValue, sec_irsaliye_kriter.Text, sec_sIrsaliyeTipi.Text)
    End Sub
    Private Sub GridControl5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl5.DoubleClick
        irsaliye_duzelt()
    End Sub
    Private Sub GridControl5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl5.KeyDown
        If e.KeyCode = Keys.Enter Then
            irsaliye_duzelt()
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridControl2.Focus()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl4.Focus()
            GridControl4.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            GridControl5.Focus()
            GridControl5.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 4 Then
            GridControl6.Focus()
            GridControl6.Select()
        End If
    End Sub
    Private Sub lbl_info_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_info.Click
        tbFirma_notlari(nMusteriID)
    End Sub
    
    Private Sub SimpleButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton21.Click
        analiz_envanter()
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokID")
            frm.stokkodu = dr("sModel")
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
            frm.musterino = dr("sModel")
            frm.nFirmaID = txt_musterino.Text
            frm.sec_firma.Checked = True
            frm.sec_giris.Text = "[Tümü]"
            'frm.collGirisFiyat.Visible = False
            'frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
            'frm.collCikisFiyat.Visible = False
            'frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
            'frm.collBrutFiyat.Visible = False
            'frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
            'frm.collBrutTutar.Visible = False
            'frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
            'frm.colnKdvOrani.Visible = False
            'frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
            'frm.collIskontoTutari.Visible = False
            'frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
            'frm.colnGirisCikis.Visible = False
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
            frm.nStokID = dr("nStokID")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sModel")
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
            Dim satir = GridView1.FocusedRowHandle
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub irsaliyelestir_kontrol()
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        arr = GridView5.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView5.GetDataRow(s)
                If dr("sFaturalasti") <> True Then
                    If dr("nFirmaID").ToString <> nFirmaID.ToString Then
                        nFirmaID = dr("nFirmaID").ToString
                        sayi += 1
                    End If
                End If
            Next
        End If
        If sayi = 1 Then
            SimpleButton23.Visible = True
            SimpleButton23.Enabled = True
        Else
            SimpleButton23.Visible = False
            SimpleButton23.Enabled = False
        End If
    End Sub
    Private Sub fis_faturala()
        Dim frm As New frm_stok_cari_alis_aciklama
        frm.txt_tarih.EditValue = dteSistemTarihi
        frm.txt_belgeno.EditValue = 1
        Dim sFisTipi As String = ""
        Dim nGirisCikis As Integer = 3
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If sec_sIrsaliyeTipi.Text = "Alınan" Then
                sFisTipi = "IA "
                nGirisCikis = 1
            ElseIf sec_sIrsaliyeTipi.Text = "Verilen" Then
                sFisTipi = "IS "
                nGirisCikis = 3
            End If
            Dim arr As Integer()
            Dim i As Integer
            Dim nFirmaSayi As Integer = 0
            Dim sayi As Integer = 0
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim nFirmaID As String = ""
            Dim sFisNolari As String = ""
            Dim enStokFisiID As String = "("
            Dim nStokFisiID As String = ""
            Dim s As String = ""
            Dim dr As DataRow
            Dim lFisNo As Int64 = 1
            Dim dteFisTarihi As DateTime
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If dr("sFaturalasti") <> True Then
                        If dr("nFirmaID").ToString <> nFirmaID.ToString Then
                            nFirmaID = dr("nFirmaID")
                            nFirmaSayi += 1
                        End If
                        sFisNolari += dr("lFisNo") & vbCrLf
                        enStokFisiID += dr("nStokFisiID").ToString
                        sayi += 1
                        If sayi < toplamsayi Then
                            enStokFisiID += ","
                        ElseIf sayi = toplamsayi Then
                            enStokFisiID += ")"
                        End If
                    End If
                Next
            End If
            'sFisTipi = sec_sFisTipi.EditValue
            'nGirisCikis = sec_nGirisCikis.EditValue
            If XtraMessageBox.Show(sFisNolari & Sorgu_sDil(" Nolu Fişleri ", sDil) & frm.txt_tarih.EditValue & Sorgu_sDil(" Tarih ", sDil) & frm.txt_belgeno.EditValue & Sorgu_sDil(" Nolu Faturaya Dönüştürmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim esFisTipi = sFisTipi
                Dim enGirisCikis = nGirisCikis
                Dim enFirmaID = nFirmaID
                nStokFisiID = sorgu_nStokFisiID()
                nFirmaID = nFirmaID
                lFisNo = frm.txt_belgeno.EditValue
                If Trim(sFisTipi) = "IA" Then
                    sFisTipi = "FA"
                ElseIf Trim(sFisTipi) = "IS" Then
                    sFisTipi = "FS"
                End If
                dteFisTarihi = frm.txt_tarih.EditValue
                'Dim dr As DataRow
                'If sFisTipi = "FS " Or sFisTipi = "DC " Or sFisTipi = "HS " Then
                'ElseIf sFisTipi = "FA " Or sFisTipi = "DG " Or sFisTipi = "HA " Then
                'End If
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, "", dteFisTarihi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, 0, "", "", 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0)
                'tbStokFisiMaster_lFisno_degistir(nStokFisiID)
                tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, "", "", "", "", "")
                tbStokFisidetay_kaydet_faturala(sFisTipi, dteFisTarihi, lFisNo, sHareketTipi, nStokFisiID, enStokFisiID)
                'Fişi Göster
                Dim fm As New frm_fatura
                fm.firmano = firmano
                fm.donemno = donemno
                fm.connection = connection
                fm.lFisNo = lFisNo
                fm.dteFisTarihi = dteFisTarihi
                fm.sFisTipi = sFisTipi
                fm.nFirmaID = nFirmaID
                fm.nGirisCikis = nGirisCikis
                fm.nStokFisiID = nStokFisiID
                fm.kullanici = kullanici
                fm.aktarim = True
                fm.Text = "Fis#Faturalanmış"
                If yetki_kontrol(kullanici, fm.Name) = True Then
                    fm.ShowDialog()
                End If
                fm.Close()
                fm = Nothing
                ara_irsaliye()
            End If
            frm.Close()
            frm = Nothing
        End If
    End Sub
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisidetay_kaydet_faturala(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal sHareketTipi As String, ByVal nStokFisiID As String, ByVal enStokFisiID As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              bFaturayaDonustumu = 1, sHareketTipi = '" & sHareketTipi & "' WHERE     (nStokFisiID IN " & enStokFisiID & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', nStokFisiID = '" & nStokFisiID & "', lFisNo = " & lFisNo & ", sHareketTipi = '" & sHareketTipi & "' WHERE     (nStokFisiID IN " & enStokFisiID & ") ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (nHareketID IN (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      nStokFisiID IN " & enStokFisiID & "))")
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub SimpleButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton23.Click
        fis_faturala()
    End Sub
    Private Sub SimpleButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton22.Click
        analiz_stok_hareket()
    End Sub
    
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
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
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        musteri_sec()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        analiz_Firma_karti(txt_sKodu.Text, txt_musterino.Text)
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        analiz_stok_hareket(nMusteriID)
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            tbFirma_notlari(dr("nHareketID"), "tbFirmaHareketi")
            dr = Nothing
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        analiz_iletisim(nMusteriID)
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        tbStokTedarikcisi()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        txt_musterino.EditValue = sorgu_cari_no(txt_musterino.EditValue.ToString, ">", "ASC", sec_bakiyeli.Checked)
        txt_musterino.Text = txt_musterino.EditValue
        musteri_kontrol()
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_musterino.EditValue = sorgu_cari_no(txt_musterino.EditValue.ToString, "<", "DESC", sec_bakiyeli.Checked)
        txt_musterino.Text = txt_musterino.EditValue
        musteri_kontrol()
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        txt_musterino.EditValue = sorgu_cari_no(txt_musterino.EditValue.ToString, "I<", "DESC", sec_bakiyeli.Checked)
        txt_musterino.Text = txt_musterino.EditValue
        musteri_kontrol()
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        If MenuItem24.Checked = False Then
            GridView2.OptionsView.ShowAutoFilterRow = True
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView2.OptionsCustomization.AllowFilter = True
            MenuItem24.Checked = True
        ElseIf MenuItem24.Checked = True Then
            GridView2.OptionsView.ShowAutoFilterRow = False
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView2.OptionsCustomization.AllowFilter = False
            MenuItem24.Checked = False
        End If
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        gorunum_kaydet()
    End Sub
    Private Sub SimpleButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton24.Click
        raporla(0, 0)
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " "
        Dim OpenFileDialog1 As New System.Windows.Forms.OpenFileDialog
        OpenFileDialog1.Filter = "Rapor Dosyaları (*.frx) |*.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Mektup"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                report_create(file, kriter, islem)
            End If
        End If
        file = Nothing
        kriter = Nothing
    End Sub
    Private Sub report_create(ByVal sFile As String, ByVal kriter As String, ByVal nIslem As Integer, Optional ByVal bMiktarli As Integer = 1)
        Dim report As New FastReport.Report
        report.Load(sFile)
        
        report.RegisterData(ds_tbFirma, "tbFirma")
        Try
            report.RegisterData(ds_siparis, "tbSiparis")
            report.RegisterData(ds_irsaliye, "tbIrsaliye")
            report.RegisterData(ds_odemeler, "tbHareket")
        Catch ex As Exception
        End Try
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = FastReport.Language.Vb
        report.PrintSettings.Collate = False
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 2 Then
            report.Design()
        ElseIf nIslem = 1 Then
            report.PrintSettings.Copies = bMiktarli
            report.Print()
        ElseIf nIslem = 3 Then
            report.PrintSettings.Copies = bMiktarli
            report.PrintSettings.ShowDialog = False
            report.Print()
        End If
        report.Dispose()
        report = Nothing
    End Sub
    Private Sub SimpleButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton25.Click
        tbSiparis_liste(4)
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_siparis()
    End Sub
    
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        analiz_siparis()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            analiz_siparis()
        ElseIf e.KeyCode = Keys.F4 Then
            analiz_siparis()
        End If
    End Sub
    Private Sub tbSiparis_degistir(ByVal nSiparisID As String, ByVal bkapandimi As Integer, Optional ByVal uyari As Boolean = True)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparis SET              bKapandimi =" & bkapandimi & "  Where nSiparisID =" & nSiparisID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sModel,'') as sModel FROM         tbStok WHERE     (sModel < '" & sModel & "' ) ORDER BY sModel DESC ")
            'sModel = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sModel
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Başarıyla Degistirildi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'stok_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Islem Hatası Lutfen tekrar Deneyinizi...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub satir_degistir(Optional ByVal kapali As Boolean = False)
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayıtları Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim toplamsayi = GridView1.SelectedRowsCount
                Dim sayi = 0
                arr = GridView1.GetSelectedRows()
                Dim dr1 As DataRow
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    'bar.Properties.Maximum = GridView1.SelectedRowsCount
                    'panelstatus.Visible = True
                    'bar.Visible = True
                    'bar.Position = 0
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        tbSiparis_degistir(dr1("nSiparisID"), kapali, False)
                        'bar.Position += 1
                        'bar.Refresh()
                    Next
                    XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'panelstatus.Visible = False
                    'bar.Visible = False
                End If
                dr1 = Nothing
                dataload_siparis(sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue, sec_kriter.Text, sec_sSiparisTipi.Text)
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_degistir(True)
    End Sub
    Private Sub SimpleButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_IrsaliyeAl.Click
        tbFis_ekle("IA ", 1)
    End Sub
    Private Sub SimpleButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_IrsaliyeVer.Click
        tbFis_ekle("IS ", 3)
    End Sub
    Private Sub Siparis_Birlestir()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayıtları Yeni Fişte Birleştirmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dteSiparisTarihi As DateTime = dteSistemTarihi
                Dim lSiparisNo As Int64 = 0
                If sec_sSiparisTipi.SelectedIndex = 0 Then
                    lSiparisNo = sorgu_lSiparisNo(1)
                ElseIf sec_sSiparisTipi.SelectedIndex = 1 Then
                    lSiparisNo = sorgu_lSiparisNo(2)
                End If
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim toplamsayi = GridView1.SelectedRowsCount
                Dim sayi = 0
                arr = GridView1.GetSelectedRows()
                Dim dr1 As DataRow
                Dim dr As DataRow
                Dim ds_tbSiparis As DataSet
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        If sorgu_sayi(dr1("lSevkMiktari"), 0) = 0 And sorgu_sayi(dr1("lKalanMiktar"), 0) > 0 Then
                            ds_tbSiparis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.nSiparisID, tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.nFirmaID, tbSiparis.sDepo,tbSiparis.nStokID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, tbSiparis.sSiparisIslem, tbSiparis.nReceteNo, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbSiparis.sFiyatTipi, tbSiparis.lMiktari, tbSiparis.sAmbalaj,tbSiparis.sBirimCinsi,tbSiparis.lBirimMiktar, (tbSiparis.lMiktari / tbSiparis.lBirimMiktar) AS lMiktar, (tbSiparis.lFiyati * tbSiparis.lBirimMiktar) AS lFiyat,CAST( (tbSiparis.lFiyati*tbSiparis.lBirimMiktar) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,tbSiparis.lFiyati as lBrutFiyat,  (tbSiparis.lFiyati) AS lFiyat,tbSiparis.lFiyati,tbSiparis.lTutari, tbSiparis.sAsortiTipi, tbSiparis.sAsortiMiktari, tbSiparis.nKdvOrani, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari as lBrutTutar, CAST( (tbSiparis.lFiyati) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbSiparis.lFiyati * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbSiparis.lIskontosuzTutari * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,tbSiparis.sSaticiRumuzu,tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim=0) AS sBarkod,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1, tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbSiparis.bKapandimi, tbSiparis.lReserveMiktari, tbSiparis.nPartiID,tbSiparis.sHangiUygulama, tbParti.nPartiID, tbParti.sKodu AS sKodu, tbSiparis.sSatirAciklama, tbSiparis.nValorGun, tbSiparis.sDovizCinsi, tbSiparis.lDovizFiyati, tbSiparis.lDovizKuru, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)), 0) AS lKdvTutari,tbSiparis.lIskontosuzTutari-tbSiparis.lTutari as lIskontoTutari, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama,lDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru ELSE lIskontosuzTutari END, lDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN  ((tbSiparis.lFiyati)) / tbSiparis.lDovizKuru ELSE  (tbSiparis.lFiyati) END,lDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lFiyati / tbSiparis.lDovizKuru ELSE tbSiparis.lFiyati END, lDahilDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru) * (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lIskontosuzTutari)* (100 + tbSiparis.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN ((tbSiparis.lFiyati) / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE ((tbSiparis.lFiyati))* (100 + tbSiparis.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lFiyati / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lFiyati)* (100 + tbSiparis.nKdvOrani) / 100 END,(SELECT     ISNULL(SUM(MIKTAR),0) AS lYukleme FROM         ASTOKPAKETDETAY WHERE     (FISNO = tbSiparis.lSiparisNo) AND (FIRMANO = tbSiparis.nFirmaID) AND (IZAHAT = 'AS') AND (TARIH = tbSiparis.dteSiparisTarihi) AND (STOKNO = tbSiparis.nStokID)) as lYukleme,(SELECT     ABS(SUM(lGirisMiktar1) - SUM(lCikisMiktar1)) AS lSevkMiktari                            FROM          tbStokFisiDetayi                             WHERE      (nSiparisID IS NOT NULL) and tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID) as lSevkiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & txt_sFiyatTipi.Text & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,(tbSiparis.lTutari / tbSiparis.lMiktari) * (100 + tbSiparis.nKdvOrani) / 100 AS lNetFiyat FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID WHERE (tbSiparis.lSiparisNo = " & dr1("lSiparisNo") & ") AND (tbSiparis.nSiparisTipi = " & dr1("nSiparisTipi") & ") AND (tbSiparis.nFirmaID = " & dr1("nFirmaID") & ") AND (tbSiparis.dteSiparisTarihi = '" & dr1("dteSiparisTarihi") & "') AND (tbSiparis.nSiparisID = " & dr1("nSiparisID") & ") ORDER BY tbSiparis.nSiparisTipi, tbSiparis.nFirmaID, tbSiparis.lSiparisNo, tbSiparis.nSiparisID"))
                            For Each dr In ds_tbSiparis.Tables(0).Rows
                                dr("dteSiparisTarihi") = dteSiparisTarihi
                                dr("lSiparisNo") = lSiparisNo
                                tbSiparis_kaydet_duzelt(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem").ToString, dr("nReceteNo"), dr("sSiparisiAlan").ToString, dr("sSiparisiVeren").ToString, dr("sFiyatTipi").ToString, dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi").ToString, dr("sAsortiMiktari").ToString, dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama").ToString, dr("nPartiID"), dr("sSatirAciklama").ToString, dr("nValorGun"), dr("sDovizCinsi").ToString, dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu").ToString, dr("sDepo").ToString, dr("sBirimCinsi").ToString, dr("lBirimMiktar"), dr("sAmbalaj"))
                            Next
                            dr1("dteSiparisTarihi") = dteSiparisTarihi
                            dr1("lSiparisNo") = lSiparisNo
                        ElseIf sorgu_sayi(dr1("lSevkMiktari"), 0) > 0 And sorgu_sayi(dr1("lKalanMiktar"), 0) <> 0 Then
                            ds_tbSiparis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.nSiparisID, tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.nFirmaID, tbSiparis.sDepo,tbSiparis.nStokID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, tbSiparis.sSiparisIslem, tbSiparis.nReceteNo, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbSiparis.sFiyatTipi, tbSiparis.lMiktari, tbSiparis.sAmbalaj,tbSiparis.sBirimCinsi,tbSiparis.lBirimMiktar, (tbSiparis.lMiktari / tbSiparis.lBirimMiktar) AS lMiktar, (tbSiparis.lFiyati * tbSiparis.lBirimMiktar) AS lFiyat,CAST( (tbSiparis.lFiyati*tbSiparis.lBirimMiktar) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,tbSiparis.lFiyati as lBrutFiyat,  (tbSiparis.lFiyati) AS lFiyat,tbSiparis.lFiyati,tbSiparis.lTutari, tbSiparis.sAsortiTipi, tbSiparis.sAsortiMiktari, tbSiparis.nKdvOrani, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari as lBrutTutar, CAST( (tbSiparis.lFiyati) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbSiparis.lFiyati * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbSiparis.lIskontosuzTutari * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,tbSiparis.sSaticiRumuzu,tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim=0) AS sBarkod,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1, tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbSiparis.bKapandimi, tbSiparis.lReserveMiktari, tbSiparis.nPartiID,tbSiparis.sHangiUygulama, tbParti.nPartiID, tbParti.sKodu AS sKodu, tbSiparis.sSatirAciklama, tbSiparis.nValorGun, tbSiparis.sDovizCinsi, tbSiparis.lDovizFiyati, tbSiparis.lDovizKuru, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)), 0) AS lKdvTutari,tbSiparis.lIskontosuzTutari-tbSiparis.lTutari as lIskontoTutari, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama,lDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru ELSE lIskontosuzTutari END, lDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN  ((tbSiparis.lFiyati)) / tbSiparis.lDovizKuru ELSE  (tbSiparis.lFiyati) END,lDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lFiyati / tbSiparis.lDovizKuru ELSE tbSiparis.lFiyati END, lDahilDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru) * (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lIskontosuzTutari)* (100 + tbSiparis.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN ((tbSiparis.lFiyati) / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE ((tbSiparis.lFiyati))* (100 + tbSiparis.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lFiyati / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lFiyati)* (100 + tbSiparis.nKdvOrani) / 100 END,(SELECT     ISNULL(SUM(MIKTAR),0) AS lYukleme FROM         ASTOKPAKETDETAY WHERE     (FISNO = tbSiparis.lSiparisNo) AND (FIRMANO = tbSiparis.nFirmaID) AND (IZAHAT = 'AS') AND (TARIH = tbSiparis.dteSiparisTarihi) AND (STOKNO = tbSiparis.nStokID)) as lYukleme,(SELECT     ABS(SUM(lGirisMiktar1) - SUM(lCikisMiktar1)) AS lSevkMiktari                            FROM          tbStokFisiDetayi                             WHERE      (nSiparisID IS NOT NULL) and tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID) as lSevkiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & txt_sFiyatTipi.Text & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,(tbSiparis.lTutari / tbSiparis.lMiktari) * (100 + tbSiparis.nKdvOrani) / 100 AS lNetFiyat FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID WHERE (tbSiparis.lSiparisNo = " & dr1("lSiparisNo") & ") AND (tbSiparis.nSiparisTipi = " & dr1("nSiparisTipi") & ") AND (tbSiparis.nFirmaID = " & dr1("nFirmaID") & ") AND (tbSiparis.dteSiparisTarihi = '" & dr1("dteSiparisTarihi") & "') AND (tbSiparis.nSiparisID = " & dr1("nSiparisID") & ") ORDER BY tbSiparis.nSiparisTipi, tbSiparis.nFirmaID, tbSiparis.lSiparisNo, tbSiparis.nSiparisID"))
                            For Each dr In ds_tbSiparis.Tables(0).Rows
                                'Düzelt
                                dr("lTutari") = (dr("lTutari") / dr("lMiktari")) * dr1("lSevkMiktari")
                                dr("lBrutTutar") = (dr("lBrutTutar") / dr("lMiktari")) * dr1("lSevkMiktari")
                                dr("lMiktari") = dr1("lSevkMiktari")
                                tbSiparis_kaydet_duzelt(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem").ToString, dr("nReceteNo"), dr("sSiparisiAlan").ToString, dr("sSiparisiVeren").ToString, dr("sFiyatTipi").ToString, dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi").ToString, dr("sAsortiMiktari").ToString, dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama").ToString, dr("nPartiID"), dr("sSatirAciklama").ToString, dr("nValorGun"), dr("sDovizCinsi").ToString, dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu").ToString, dr("sDepo").ToString, dr("sBirimCinsi").ToString, dr("lBirimMiktar"), dr("sAmbalaj"))
                                'Ekle
                                dr("dteSiparisTarihi") = dteSiparisTarihi
                                dr("lSiparisNo") = lSiparisNo
                                dr("lTutari") = (dr("lTutari") / dr("lMiktari")) * dr1("lKalanMiktar")
                                dr("lBrutTutar") = (dr("lBrutTutar") / dr("lMiktari")) * dr1("lKalanMiktar")
                                dr("lMiktari") = dr1("lKalanMiktar")
                                dr("nSiparisID") = sorgu_nSiparisID()
                                tbSiparis_kaydet_yeni(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem").ToString, dr("nReceteNo"), dr("sSiparisiAlan").ToString, dr("sSiparisiVeren").ToString, dr("sFiyatTipi").ToString, dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi").ToString, dr("sAsortiMiktari").ToString, dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama").ToString, dr("nPartiID"), dr("sSatirAciklama").ToString, dr("nValorGun"), dr("sDovizCinsi").ToString, dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu").ToString, dr("sDepo").ToString, dr("sBirimCinsi").ToString, dr("lBirimMiktar"), dr("sAmbalaj"))
                                nSiparisID_degistir(dr("nSiparisID"))
                            Next
                            dr1("dteSiparisTarihi") = dteSiparisTarihi
                            dr1("lSiparisNo") = lSiparisNo
                        End If
                    Next
                    Refresh()
                    'XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                dr1 = Nothing
                analiz_siparis()
                dataload_siparis(sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue, sec_kriter.Text, sec_sSiparisTipi.Text)
            End If
        End If
    End Sub
    Public Function sorgu_lSiparisNo(ByVal nSiparisTipi As Int64) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If nSiparisTipi = 1 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamAlSiparis")
        ElseIf nSiparisTipi = 2 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 3 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 4 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nSiparisID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nSiparisID + 1, 1) AS nSiparisID FROM         tbSiparis ORDER BY nSiparisID DESC")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(nSiparisID) + 1, 1) AS nSiparisID FROM         tbSiparis")
        Dim kayitsayisi = cmd.ExecuteScalar
        If sorgu_sayi(kayitsayisi, 0) = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Private Sub nSiparisID_degistir(ByVal nSiparisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparisSiraNo SET              nSonID = '" & nSiparisID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    
    Private Sub tbSiparis_kaydet_yeni(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As String, ByVal nKdvOrani As Int64, ByVal nIskontoYuzdesi As Int64, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Integer, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal, ByVal sSaticiRumuzu As String, ByVal sDepo As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal sAmbalaj As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu,sDepo,sBirimCinsi,lBirimMiktar,sAmbalaj) VALUES (" & nSiparisID & ", " & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "','" & sDepo & "','" & sBirimCinsi & "'," & lBirimMiktar & ",'" & sAmbalaj & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu,sDepo,sBirimCinsi,lBirimMiktar,sAmbalaj) VALUES (" & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "','" & sDepo & "','" & sBirimCinsi & "'," & lBirimMiktar & ",'" & sAmbalaj & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbSiparis_kaydet_duzelt(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As String, ByVal nKdvOrani As Int64, ByVal nIskontoYuzdesi As Int64, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Integer, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal, ByVal sSaticiRumuzu As String, ByVal sDepo As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal sAmbalaj As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'If nSiparisTipi = 1 Or nSiparisTipi = 2 Then
        '    sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        'Else
        'End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparis SET              lSiparisNo = " & lSiparisNo & ", nFirmaID = " & nFirmaID & ", nStokID = " & nStokID & ", dteSiparisTarihi = '" & dteSiparisTarihi & "', dteTeslimTarihi = '" & dteTeslimTarihi & "', sSiparisIslem = '" & sSiparisIslem & "', nReceteNo = " & nReceteNo & ", sSiparisiAlan = '" & sSiparisiAlan & "', sSiparisiVeren = '" & sSiparisiVeren & "', sFiyatTipi = '" & sFiyatTipi & "', lMiktari = " & lMiktari & ", lFiyati = " & lFiyati & ", lTutari = " & lTutari & ", sAsortiTipi = '" & sAsortiTipi & "', sAsortiMiktari = '" & sAsortiMiktari & "', nKdvOrani = " & nKdvOrani & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontosuzTutari = " & lIskontosuzTutari & ", bKapandimi = " & bKapandimi & ", lReserveMiktari = " & lReserveMiktari & ", sHangiUygulama = '" & sHangiUygulama & "', nPartiID = " & nPartiID & ", sSatirAciklama = '" & sSatirAciklama & "', nValorGun = " & nValorGun & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyati = " & lDovizFiyati & ", lDovizKuru = " & lDovizKuru & ",sSaticiRumuzu='" & sSaticiRumuzu & "',sDepo ='" & sDepo & "',sBirimCinsi = '" & sBirimCinsi & "',lBirimMiktar = " & lBirimMiktar & ",sAmbalaj = '" & sAmbalaj & "' Where nSiparisID = " & nSiparisID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub dataload_gorev(ByVal tarih As DateTime, ByVal FirmaNo As Int64, ByVal durum As String, ByVal tamamlandi As String)
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        kriter += " WHERE StartTime between '" & Microsoft.VisualBasic.Left(tarih.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih.ToString, 10) + " 23:59:59" & "'  "
        'If personelno > 0 Then
        '    kriter += " AND PersonelNo =" & personelno & " "
        '    kriter2 += " AND PersonelNo =" & personelno & " "
        'End If
        If FirmaNo > 0 Then
            kriter += " AND FirmaNo =" & FirmaNo & " "
            kriter2 += " AND FirmaNo =" & FirmaNo & " "
        End If
        If tamamlandi = "[Tümü]" Then
        ElseIf tamamlandi = "Hayır" Then
            kriter += " AND Tamamlandi =0 "
        ElseIf tamamlandi = "Evet" Then
            kriter += " AND Tamamlandi =1 "
        End If
        ds_tbGorev = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY Select *,Cast ('1' as bit) as Eski From aEmirAjanda Where Tamamlandi=0 And StartTime < '" & tarih & "' " & kriter2 & "  UNION ALL Select *,Cast ('0' as bit) as Eski From aEmirAjanda" & kriter & " "))
        kriter = Nothing
        kriter2 = Nothing
        GridControl6.DataSource = ds_tbGorev.Tables(0)
        GridControl6.DataMember = Nothing
        If GridView6.RowCount > 0 Then
            GridView6.FocusedRowHandle = 0
            GridView6.SelectRow(GridView6.FocusedRowHandle)
        End If
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Siparis_Birlestir()
    End Sub
    
    Private Sub SimpleButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton28.Click
        Siparis_Birlestir()
    End Sub
    
    Private Sub SimpleButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton32.Click
        ara_gorev()
    End Sub
    Private Sub ara_gorev()
        dataload_gorev(txt_dteGorevTarihi.EditValue, txt_nFirmaID.Text, sec_durum.Text, sec_tamamlandi.Text)
    End Sub
    Private Sub gorev_ekle()
        Dim frm As New frm_emir_ajanda_gorev
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyerno = kullanici
        frm.kasiyer = kullaniciadi
        frm.kullanici = kullanici
        frm.txt_hesapno.Text = txt_nFirmaID.Text
        frm.txt_hesap.Text = txt_sAciklama.Text
        frm.sec_hesaptipi.Text = "Firma"
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        ara_gorev()
    End Sub
    Private Sub gorev_duzelt()
        If GridView6.RowCount > 0 Then
            Dim frm As New frm_emir_ajanda_gorev
            frm.firmano = firmano
            frm.donemno = donemno
            frm.kasiyer = kullaniciadi
            frm.kasiyerno = kullanici
            frm.connection = connection
            Dim satir = GridView6.FocusedRowHandle
            Dim dr As DataRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            frm.kayitno = dr("ID")
            frm.status = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            ara_gorev()
            GridView6.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub gorev_sil()
        If GridView6.RowCount > 0 Then
            Dim dr As DataRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            Dim satir = GridView6.FocusedRowHandle
            gorev_kayit_sil(dr("ID"))
            ara_gorev()
            GridView6.FocusedRowHandle = satir
            satir = Nothing
            GridControl6.Focus()
            GridControl6.Select()
        End If
    End Sub
    Private Sub gorev_kayit_sil(ByVal ID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirAjanda  WHERE ID= '" & ID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub fihrist()
        Dim frm As New frm_fihrist
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowInTaskbar = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub Stok_Ozetleri()
        Dim frm As New frm_fatura_kalemleri_ozet
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sFisTipi = "FS "
        frm.nGirisCikis = 3
        frm.bAktar = True
        frm.islemstatus = True
        frm.kapla = True
        Dim lIskontoTutar As Decimal = 0
        Dim lKdvTutari As Decimal = 0
        frm.txt_ara.Text = txt_sKodu.Text
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub
    Private Sub SimpleButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton31.Click
        gorev_ekle()
    End Sub
    Private Sub GridView6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView6.DoubleClick
        gorev_duzelt()
    End Sub
    Private Sub GridView6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView6.KeyDown
        If e.KeyCode = Keys.Enter Then
            gorev_duzelt()
        End If
    End Sub
    Private Sub SimpleButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton29.Click
        printlink6.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub SimpleButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton30.Click
        fihrist()
    End Sub
    Private Sub SimpleButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton33.Click
        gorev_duzelt()
    End Sub
    Private Sub SimpleButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton34.Click
        gorev_sil()
    End Sub
    Private Sub SimpleButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        Stok_Ozetleri()
    End Sub
    Friend WithEvents colnEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
