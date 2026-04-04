Imports FastReport
Imports System.IO
Imports DevExpress.XtraEditors
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Net
Imports System.Configuration
Public Class frm_firma_kart
    Inherits DevExpress.XtraEditors.XtraForm

    ' === RISK GOSTERGESI ===
    Private pnlRisk As Panel
    Private lblRiskSkor As Label
    Private lblRiskAciklama As Label
    Private btnRiskDetay As Button
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_HesapKodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ds_tbFirma As System.Data.DataSet
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
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents ds_tbFirmaYetkilisi As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents ds_tbFirmaIletisimi As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents ds_tbFirmaAyYekunleri As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Iskonto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sVergiNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_VergiNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sVergiDairesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_VergiDairesi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sHitap1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSinifKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSatisYapilamaz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnYetkiliID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHitap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdiSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnIletisimID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIletisimAraci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIletisimAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnAy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnYil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSayi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_sFiyatTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_dteMutabakatTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_lKrediLimiti As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_sOzelNot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nVadeGun As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nOzelIskontosu As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btn_MuhasebeAc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_sMuhasebeKodu As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_sPostaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdres2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdres1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_sHitap1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sUnvan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ds_tbFirmaSinifi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_tbFirmaBakiyesi As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents collNetBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kisayol_yetkili As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_iletisim As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_aylik As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents kisayol_ana As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FirmaHareketleriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirmaBakiyeleriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HareketGirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AçýklamaGirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_sKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents EkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SonKodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokluEkstreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sec_siniflar As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_nOzelIskontosu4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nOzelIskontosu3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nOzelIskontosu2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_sSaticiRumuzu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents txt_sIl As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sUlke As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_bAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnl_yetkililer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnl_yetkili_status As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_yetkili_yazdir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_yetkili_sil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_yetkili_ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl_iletisim As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnl_iletisim_status As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_iletisim_yazdir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_iletisim_sil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_iletisim_ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_bTahsilatYapilamaz As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bSatisYapilamaz As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsModul As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents colsPaket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModulAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsOnayKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsParametre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsManufactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSystemType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCpuID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBiosVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHddSerial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsParametre2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kisayol_moduller As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_lisanslar As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents colsVersion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupLisans As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sOnayKodu As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sCpuID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSystemType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sManufactor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sParametre2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sParametre1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sHddSerial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sBiosVersion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sDovizCinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteGecerlilikTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ds_tbFirmaResim As System.Data.DataSet
    Friend WithEvents DataTable9 As System.Data.DataTable
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents GridControl7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnFirmaResimID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpResim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_pResim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSira As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents KarlýlýkAkýþTablosuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HesapKodunuDeðiþtirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_KodBul As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_sAyrac As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sKod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Vazgec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Kaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sSifreyiAlan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nBayiID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents txt_nPeriyod As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sSinifKodu1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sec_sSinifKodu2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sec_sSinifKodu3 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sec_sSinifKodu4 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents txt_sMagaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_Sinif As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldteGecerlilikTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sSifreyiAlan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBilgisayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOturum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_TC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents sec_bSipariseKapali As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents efatura As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_IletisimAraci As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_firma_kart))
        Dim SuperToolTip33 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem24 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem33 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip21 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem23 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem21 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip34 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem40 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem34 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip36 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem42 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem36 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip35 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem41 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem35 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip37 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem43 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem37 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip40 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem48 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem40 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip38 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem44 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem38 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem45 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip39 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem46 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem39 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem47 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip32 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem38 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem32 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip23 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem27 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem23 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem10 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip11 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem11 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip12 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem14 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem12 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip13 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem13 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem39 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip14 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem16 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem14 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem28 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip15 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem17 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem15 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip16 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem18 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem16 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip17 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem19 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem17 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip18 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem20 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem18 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip19 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem21 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem19 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip20 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem22 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem20 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sAyrac = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sKod = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Vazgec = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Kaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_sSinifKodu1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sec_sSinifKodu2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sec_sSinifKodu3 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sec_sSinifKodu4 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.ds_tbFirma = New System.Data.DataSet()
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
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.lbl_HesapKodu = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.kisayol_ana = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FirmaHareketleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokluEkstreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirmaBakiyeleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KarlýlýkAkýþTablosuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HareketGirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçýklamaGirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SonKodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HesapKodunuDeðiþtirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.efatura = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bSipariseKapali = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_TC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sMagaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit7 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit6 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit5 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_KodBul = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sDovizCinsi = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_bTahsilatYapilamaz = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bSatisYapilamaz = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_sUlke = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sSaticiRumuzu = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nOzelIskontosu4 = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_nOzelIskontosu3 = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_nOzelIskontosu2 = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_sKodu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sFiyatTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteMutabakatTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lKrediLimiti = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sOzelNot = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nVadeGun = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nOzelIskontosu = New DevExpress.XtraEditors.SpinEdit()
        Me.lbl_Iskonto = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sVergiNo = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_VergiNo = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sVergiDairesi = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_VergiDairesi = New DevExpress.XtraEditors.LabelControl()
        Me.btn_MuhasebeAc = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sMuhasebeKodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sPostaKodu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSemt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAdres2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAdres1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sHitap1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nPeriyod = New DevExpress.XtraEditors.SpinEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ds_tbFirmaSinifi = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_Sinif = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbSatisYapilamaz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinifKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_siniflar = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.pnl_yetkililer = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_yetkili = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.ds_tbFirmaYetkilisi = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnYetkiliID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sUnvan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsHitap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sHitap1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsAdiSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnl_yetkili_status = New DevExpress.XtraEditors.PanelControl()
        Me.btn_yetkili_yazdir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_yetkili_sil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_yetkili_ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.pnl_iletisim = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_iletisim = New System.Windows.Forms.ContextMenu()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.ds_tbFirmaIletisimi = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnIletisimID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIletisimAraci = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_IletisimAraci = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsIletisimAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnl_iletisim_status = New DevExpress.XtraEditors.PanelControl()
        Me.btn_iletisim_yazdir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_iletisim_sil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_iletisim_ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl8 = New DevExpress.XtraGrid.GridControl()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_aylik = New System.Windows.Forms.ContextMenu()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.ds_tbFirmaAyYekunleri = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnAy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnYil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSayi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBorc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_moduller = New System.Windows.Forms.ContextMenu()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsModul = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsPaket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModulAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupLisans = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nBayiID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSifreyiAlan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteGecerlilikTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sHddSerial = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sBiosVersion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sCpuID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sSystemType = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sModel = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sManufactor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sParametre2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sParametre1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sOnayKodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_lisanslar = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsOnayKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsParametre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsParametre2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsManufactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSystemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCpuID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBiosVersion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHddSerial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteGecerlilikTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sSifreyiAlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBilgisayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOturum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl7 = New DevExpress.XtraGrid.GridControl()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnFirmaResimID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpResim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pResim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.ds_tbFirmaBakiyesi = New System.Data.DataSet()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.ds_tbFirmaResim = New System.Data.DataSet()
        Me.DataTable9 = New System.Data.DataTable()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_sAyrac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.kisayol_ana.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.efatura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bSipariseKapali.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bTahsilatYapilamaz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bSatisYapilamaz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sUlke.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nOzelIskontosu4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nOzelIskontosu3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nOzelIskontosu2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteMutabakatTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteMutabakatTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lKrediLimiti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sOzelNot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nVadeGun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nOzelIskontosu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sMuhasebeKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sPostaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdres2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdres1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nPeriyod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaSinifi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Sinif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_siniflar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.pnl_yetkililer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_yetkililer.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaYetkilisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sUnvan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHitap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_yetkili_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_yetkili_status.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.pnl_iletisim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_iletisim.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaIletisimi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_IletisimAraci, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_iletisim_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_iletisim_status.SuspendLayout()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaAyYekunleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.GroupLisans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupLisans.SuspendLayout()
        CType(Me.txt_nBayiID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSifreyiAlan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteGecerlilikTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteGecerlilikTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sHddSerial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sBiosVersion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sCpuID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSystemType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sManufactor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sParametre2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sParametre1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sOnayKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaBakiyesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1317, 80)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(154, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hesap Kartý Tanýmlarý Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_sAyrac)
        Me.GroupControl2.Controls.Add(Me.LabelControl34)
        Me.GroupControl2.Controls.Add(Me.lbl_sKod)
        Me.GroupControl2.Controls.Add(Me.LabelControl35)
        Me.GroupControl2.Controls.Add(Me.LabelControl36)
        Me.GroupControl2.Controls.Add(Me.LabelControl37)
        Me.GroupControl2.Controls.Add(Me.LabelControl38)
        Me.GroupControl2.Controls.Add(Me.btn_Vazgec)
        Me.GroupControl2.Controls.Add(Me.btn_Kaydet)
        Me.GroupControl2.Controls.Add(Me.sec_sSinifKodu1)
        Me.GroupControl2.Controls.Add(Me.sec_sSinifKodu2)
        Me.GroupControl2.Controls.Add(Me.sec_sSinifKodu3)
        Me.GroupControl2.Controls.Add(Me.sec_sSinifKodu4)
        Me.GroupControl2.Location = New System.Drawing.Point(693, 59)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(510, 277)
        Me.GroupControl2.TabIndex = 107
        Me.GroupControl2.Text = "Sýnýflandýrma Parametreleri"
        Me.GroupControl2.Visible = False
        '
        'txt_sAyrac
        '
        Me.txt_sAyrac.EditValue = "-"
        Me.txt_sAyrac.Location = New System.Drawing.Point(125, 156)
        Me.txt_sAyrac.Name = "txt_sAyrac"
        Me.txt_sAyrac.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sAyrac.Properties.Appearance.Options.UseFont = True
        Me.txt_sAyrac.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sAyrac.Properties.Items.AddRange(New Object() {"", "-"})
        Me.txt_sAyrac.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_sAyrac.Size = New System.Drawing.Size(256, 28)
        Me.txt_sAyrac.TabIndex = 102
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl34.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl34.Location = New System.Drawing.Point(10, 161)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(46, 19)
        Me.LabelControl34.TabIndex = 107
        Me.LabelControl34.Text = "Ayraç:"
        '
        'lbl_sKod
        '
        Me.lbl_sKod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_sKod.Location = New System.Drawing.Point(125, 187)
        Me.lbl_sKod.Name = "lbl_sKod"
        Me.lbl_sKod.Size = New System.Drawing.Size(256, 19)
        Me.lbl_sKod.TabIndex = 103
        Me.lbl_sKod.Text = "*"
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl35.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl35.Location = New System.Drawing.Point(13, 131)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(94, 19)
        Me.LabelControl35.TabIndex = 102
        Me.LabelControl35.Text = "Detay Hesap:"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl36.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl36.Location = New System.Drawing.Point(5, 100)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(104, 19)
        Me.LabelControl36.TabIndex = 100
        Me.LabelControl36.Text = "Muavin Hesap:"
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl37.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl37.Location = New System.Drawing.Point(34, 69)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl37.TabIndex = 98
        Me.LabelControl37.Text = "Tali Hesap:"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl38.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl38.Location = New System.Drawing.Point(24, 37)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl38.TabIndex = 96
        Me.LabelControl38.Text = "Ana Hesap :"
        '
        'btn_Vazgec
        '
        Me.btn_Vazgec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Vazgec.Image = CType(resources.GetObject("btn_Vazgec.Image"), System.Drawing.Image)
        Me.btn_Vazgec.Location = New System.Drawing.Point(378, 229)
        Me.btn_Vazgec.Name = "btn_Vazgec"
        Me.btn_Vazgec.Size = New System.Drawing.Size(120, 34)
        Me.btn_Vazgec.TabIndex = 105
        Me.btn_Vazgec.Text = "&Vazgeç"
        '
        'btn_Kaydet
        '
        Me.btn_Kaydet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Kaydet.Image = CType(resources.GetObject("btn_Kaydet.Image"), System.Drawing.Image)
        Me.btn_Kaydet.Location = New System.Drawing.Point(258, 229)
        Me.btn_Kaydet.Name = "btn_Kaydet"
        Me.btn_Kaydet.Size = New System.Drawing.Size(120, 34)
        Me.btn_Kaydet.TabIndex = 103
        Me.btn_Kaydet.Text = "&Onayla"
        '
        'sec_sSinifKodu1
        '
        Me.sec_sSinifKodu1.Location = New System.Drawing.Point(125, 31)
        Me.sec_sSinifKodu1.MenuManager = Me.BarManager1
        Me.sec_sSinifKodu1.Name = "sec_sSinifKodu1"
        Me.sec_sSinifKodu1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu1.Properties.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu1.Properties.NullText = "[Sýnýf]"
        Me.sec_sSinifKodu1.Properties.ValueMember = "sSinifKodu"
        Me.sec_sSinifKodu1.Properties.View = Me.SearchLookUpEdit1View
        Me.sec_sSinifKodu1.Size = New System.Drawing.Size(256, 26)
        Me.sec_sSinifKodu1.TabIndex = 96
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14})
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Ara ,F3"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        ToolTipTitleItem24.Text = "Ara"
        ToolTipItem33.LeftIndent = 6
        ToolTipItem33.Text = "Farklý bir hesap kartini ekrana getirmek icin kullanilir."
        SuperToolTip33.Items.Add(ToolTipTitleItem24)
        SuperToolTip33.Items.Add(ToolTipItem33)
        Me.BarButtonItem4.SuperTip = SuperToolTip33
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ekle,Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        ToolTipTitleItem23.Text = "Sil"
        ToolTipItem21.LeftIndent = 6
        ToolTipItem21.Text = "Hesap Kartýný Silmek icin Kullanilir. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hesap kartýný silebilmek icin Hareket gör" &
    "memiþ olmasý gerekmektedir. Hareket gören Hesap kartlarý silinemez, pasif yapýla" &
    "bilir."
        SuperToolTip21.Items.Add(ToolTipTitleItem23)
        SuperToolTip21.Items.Add(ToolTipItem21)
        Me.BarButtonItem3.SuperTip = SuperToolTip21
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Ekstre,F7"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        ToolTipTitleItem40.Text = "Ekstre"
        ToolTipItem34.LeftIndent = 6
        ToolTipItem34.Text = "Hesap kartina ait hesap hareketleri dökümü icin kullanilir. Dövizli veya Yerli pa" &
    "ra birimi cinsinden alinabilir. Fis Hareketleri Özet, Diger Hesap hareketleri De" &
    "tayli olarak listelenir."
        SuperToolTip34.Items.Add(ToolTipTitleItem40)
        SuperToolTip34.Items.Add(ToolTipItem34)
        Me.BarButtonItem5.SuperTip = SuperToolTip34
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Stoklu Ekstre,Ctrl+S"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        ToolTipTitleItem42.Text = "Stoklu Ekstre"
        ToolTipItem36.LeftIndent = 6
        ToolTipItem36.Text = "Hesap kartýna ait hareket dökümü alýnýr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tüm hesap hareketleri detaylý olarak li" &
    "stelenir." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fis Hareketlerinde Stok detaylarý izlenebilmektedir."
        SuperToolTip36.Items.Add(ToolTipTitleItem42)
        SuperToolTip36.Items.Add(ToolTipItem36)
        Me.BarButtonItem7.SuperTip = SuperToolTip36
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Bakiye,F6"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        ToolTipTitleItem41.Text = "Bakiye"
        ToolTipItem35.LeftIndent = 6
        ToolTipItem35.Text = "Hesap Kartýnýn Bakiye Analizi Ekrana gelir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Farklý Hareket Tiplerine Göre Bakiye " &
    "Toplamlarý alýnabilir."
        SuperToolTip35.Items.Add(ToolTipTitleItem41)
        SuperToolTip35.Items.Add(ToolTipItem35)
        Me.BarButtonItem6.SuperTip = SuperToolTip35
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Notlar,F8"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        ToolTipTitleItem43.Text = "Notlar"
        ToolTipItem37.LeftIndent = 6
        SuperToolTip37.Items.Add(ToolTipTitleItem43)
        SuperToolTip37.Items.Add(ToolTipItem37)
        Me.BarButtonItem8.SuperTip = SuperToolTip37
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Sýnýflar,F9"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        ToolTipTitleItem48.Text = "Sýnýflar"
        ToolTipItem40.LeftIndent = 6
        SuperToolTip40.Items.Add(ToolTipTitleItem48)
        SuperToolTip40.Items.Add(ToolTipItem40)
        Me.BarButtonItem11.SuperTip = SuperToolTip40
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Son Kod ,F11"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        ToolTipTitleItem44.Text = "Son Kod"
        ToolTipItem38.LeftIndent = 6
        ToolTipTitleItem45.LeftIndent = 6
        ToolTipTitleItem45.Text = "Kayýt Numaralarýnda nerede kalýndýðý listelenir."
        SuperToolTip38.Items.Add(ToolTipTitleItem44)
        SuperToolTip38.Items.Add(ToolTipItem38)
        SuperToolTip38.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip38.Items.Add(ToolTipTitleItem45)
        Me.BarButtonItem9.SuperTip = SuperToolTip38
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "&Hareket Gir,F12"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        ToolTipTitleItem46.Text = "Hareket Gir"
        ToolTipItem39.LeftIndent = 6
        ToolTipTitleItem47.LeftIndent = 6
        ToolTipTitleItem47.Text = "Hýzlý Hesap Hareketleri Isle"
        SuperToolTip39.Items.Add(ToolTipTitleItem46)
        SuperToolTip39.Items.Add(ToolTipItem39)
        SuperToolTip39.Items.Add(ToolTipTitleItem47)
        Me.BarButtonItem10.SuperTip = SuperToolTip39
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Çýkýþ"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Risk"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Sipariþler"
        Me.BarButtonItem14.Id = 13
        Me.BarButtonItem14.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem14.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1317, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 621)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1317, 31)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 621)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1317, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 621)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Düzelt,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsBehavior.AllowIncrementalSearch = True
        Me.SearchLookUpEdit1View.OptionsBehavior.Editable = False
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'sec_sSinifKodu2
        '
        Me.sec_sSinifKodu2.Location = New System.Drawing.Point(125, 61)
        Me.sec_sSinifKodu2.MenuManager = Me.BarManager1
        Me.sec_sSinifKodu2.Name = "sec_sSinifKodu2"
        Me.sec_sSinifKodu2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu2.Properties.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu2.Properties.NullText = "[Sýnýf]"
        Me.sec_sSinifKodu2.Properties.ValueMember = "sSinifKodu"
        Me.sec_sSinifKodu2.Properties.View = Me.GridView13
        Me.sec_sSinifKodu2.Size = New System.Drawing.Size(256, 26)
        Me.sec_sSinifKodu2.TabIndex = 97
        '
        'GridView13
        '
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView13.OptionsBehavior.Editable = False
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowAutoFilterRow = True
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'sec_sSinifKodu3
        '
        Me.sec_sSinifKodu3.Location = New System.Drawing.Point(125, 93)
        Me.sec_sSinifKodu3.MenuManager = Me.BarManager1
        Me.sec_sSinifKodu3.Name = "sec_sSinifKodu3"
        Me.sec_sSinifKodu3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu3.Properties.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu3.Properties.NullText = "[Sýnýf]"
        Me.sec_sSinifKodu3.Properties.ValueMember = "sSinifKodu"
        Me.sec_sSinifKodu3.Properties.View = Me.GridView9
        Me.sec_sSinifKodu3.Size = New System.Drawing.Size(256, 26)
        Me.sec_sSinifKodu3.TabIndex = 98
        '
        'GridView9
        '
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowAutoFilterRow = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'sec_sSinifKodu4
        '
        Me.sec_sSinifKodu4.Location = New System.Drawing.Point(125, 126)
        Me.sec_sSinifKodu4.MenuManager = Me.BarManager1
        Me.sec_sSinifKodu4.Name = "sec_sSinifKodu4"
        Me.sec_sSinifKodu4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu4.Properties.DisplayMember = "sAciklama"
        Me.sec_sSinifKodu4.Properties.NullText = "[Sýnýf]"
        Me.sec_sSinifKodu4.Properties.ValueMember = "sSinifKodu"
        Me.sec_sSinifKodu4.Properties.View = Me.GridView10
        Me.sec_sSinifKodu4.Size = New System.Drawing.Size(256, 26)
        Me.sec_sSinifKodu4.TabIndex = 99
        '
        'GridView10
        '
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView10.OptionsBehavior.Editable = False
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowAutoFilterRow = True
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.TextEdit4)
        Me.PanelControl2.Controls.Add(Me.lbl_HesapKodu)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 553)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1317, 68)
        Me.PanelControl2.TabIndex = 1
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAciklama", True))
        Me.TextEdit4.EditValue = "*"
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(347, 24)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.EditFormat.FormatString = "#,0.00##"
        Me.TextEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.MaxLength = 60
        Me.TextEdit4.Properties.NullText = "0.00"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit4.Size = New System.Drawing.Size(607, 26)
        Me.TextEdit4.TabIndex = 62
        '
        'ds_tbFirma
        '
        Me.ds_tbFirma.DataSetName = "NewDataSet"
        Me.ds_tbFirma.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirma.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
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
        Me.DataColumn4.ColumnName = "nOzelIskontosu"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lKrediLimiti"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "dteMutabakatTarihi"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nVadeGun"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sHitap"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAdres1"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sAdres2"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sSemt"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sIl"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sUlke"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sPostaKodu"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sVergiDairesi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sVergiNo"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "nHesapID"
        Me.DataColumn17.DataType = GetType(Long)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sOzelNot"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sKullaniciAdi"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "dteKayitTarihi"
        Me.DataColumn20.DataType = GetType(Date)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sFiyatTipi"
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
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "nEnlem"
        Me.DataColumn56.DataType = GetType(Decimal)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "nBoylam"
        Me.DataColumn57.DataType = GetType(Decimal)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "nZiyaret"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "nPeriyod"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "sDepo"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "TC"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "sCariHesapTuru"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "bSipariseKapali"
        Me.DataColumn63.DataType = GetType(Boolean)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "sEfatura"
        Me.DataColumn64.DataType = GetType(Boolean)
        '
        'lbl_HesapKodu
        '
        Me.lbl_HesapKodu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_HesapKodu.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_HesapKodu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_HesapKodu.Location = New System.Drawing.Point(22, 19)
        Me.lbl_HesapKodu.Name = "lbl_HesapKodu"
        Me.lbl_HesapKodu.Size = New System.Drawing.Size(101, 28)
        Me.lbl_HesapKodu.TabIndex = 61
        Me.lbl_HesapKodu.Text = "Firma Kodu:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(133, 19)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(205, 26)
        Me.txt_musteriNo.TabIndex = 59
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1172, 19)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton2.TabIndex = 58
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1052, 19)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton1.TabIndex = 57
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1317, 473)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Navy
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = True
        Me.XtraTabControl1.ContextMenuStrip = Me.kisayol_ana
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1313, 412)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage9, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'kisayol_ana
        '
        Me.kisayol_ana.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.kisayol_ana.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EkleToolStripMenuItem, Me.SilToolStripMenuItem, Me.AraToolStripMenuItem, Me.ToolStripSeparator2, Me.FirmaHareketleriToolStripMenuItem, Me.StokluEkstreToolStripMenuItem, Me.FirmaBakiyeleriToolStripMenuItem, Me.KarlýlýkAkýþTablosuToolStripMenuItem, Me.ToolStripSeparator1, Me.HareketGirToolStripMenuItem, Me.AçýklamaGirToolStripMenuItem, Me.SonKodToolStripMenuItem, Me.HesapKodunuDeðiþtirToolStripMenuItem})
        Me.kisayol_ana.Name = "kisayol_ana"
        Me.kisayol_ana.Size = New System.Drawing.Size(299, 368)
        '
        'EkleToolStripMenuItem
        '
        Me.EkleToolStripMenuItem.Name = "EkleToolStripMenuItem"
        Me.EkleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert
        Me.EkleToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.EkleToolStripMenuItem.Text = "Ekle"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'AraToolStripMenuItem
        '
        Me.AraToolStripMenuItem.Name = "AraToolStripMenuItem"
        Me.AraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.AraToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.AraToolStripMenuItem.Text = "Ara"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(295, 6)
        '
        'FirmaHareketleriToolStripMenuItem
        '
        Me.FirmaHareketleriToolStripMenuItem.Name = "FirmaHareketleriToolStripMenuItem"
        Me.FirmaHareketleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.FirmaHareketleriToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.FirmaHareketleriToolStripMenuItem.Text = "Ekstre"
        '
        'StokluEkstreToolStripMenuItem
        '
        Me.StokluEkstreToolStripMenuItem.Name = "StokluEkstreToolStripMenuItem"
        Me.StokluEkstreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StokluEkstreToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.StokluEkstreToolStripMenuItem.Text = "Stoklu Ekstre"
        '
        'FirmaBakiyeleriToolStripMenuItem
        '
        Me.FirmaBakiyeleriToolStripMenuItem.Name = "FirmaBakiyeleriToolStripMenuItem"
        Me.FirmaBakiyeleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.FirmaBakiyeleriToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.FirmaBakiyeleriToolStripMenuItem.Text = "Bakiye Analizi"
        '
        'KarlýlýkAkýþTablosuToolStripMenuItem
        '
        Me.KarlýlýkAkýþTablosuToolStripMenuItem.Name = "KarlýlýkAkýþTablosuToolStripMenuItem"
        Me.KarlýlýkAkýþTablosuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.KarlýlýkAkýþTablosuToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.KarlýlýkAkýþTablosuToolStripMenuItem.Text = "Karlýlýk Akýþ Tablosu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(295, 6)
        '
        'HareketGirToolStripMenuItem
        '
        Me.HareketGirToolStripMenuItem.Name = "HareketGirToolStripMenuItem"
        Me.HareketGirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.HareketGirToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.HareketGirToolStripMenuItem.Text = "Hareket Gir"
        '
        'AçýklamaGirToolStripMenuItem
        '
        Me.AçýklamaGirToolStripMenuItem.Name = "AçýklamaGirToolStripMenuItem"
        Me.AçýklamaGirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.AçýklamaGirToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.AçýklamaGirToolStripMenuItem.Text = "Açýklama Gir"
        '
        'SonKodToolStripMenuItem
        '
        Me.SonKodToolStripMenuItem.Name = "SonKodToolStripMenuItem"
        Me.SonKodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.SonKodToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.SonKodToolStripMenuItem.Text = "Son Kod"
        '
        'HesapKodunuDeðiþtirToolStripMenuItem
        '
        Me.HesapKodunuDeðiþtirToolStripMenuItem.Name = "HesapKodunuDeðiþtirToolStripMenuItem"
        Me.HesapKodunuDeðiþtirToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.HesapKodunuDeðiþtirToolStripMenuItem.Text = "Hesap Kodunu Deðiþtir"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Image = CType(resources.GetObject("XtraTabPage1.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage1.Text = "Genel"
        Me.XtraTabPage1.Tooltip = "Genel Bilgiler Bu Bölümden Takip Edilir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.efatura)
        Me.GroupControl1.Controls.Add(Me.sec_bSipariseKapali)
        Me.GroupControl1.Controls.Add(Me.LabelControl44)
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl1.Controls.Add(Me.txt_TC)
        Me.GroupControl1.Controls.Add(Me.LabelControl43)
        Me.GroupControl1.Controls.Add(Me.txt_sMagaza)
        Me.GroupControl1.Controls.Add(Me.LabelControl42)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.CheckEdit7)
        Me.GroupControl1.Controls.Add(Me.CheckEdit6)
        Me.GroupControl1.Controls.Add(Me.CheckEdit5)
        Me.GroupControl1.Controls.Add(Me.CheckEdit4)
        Me.GroupControl1.Controls.Add(Me.CheckEdit3)
        Me.GroupControl1.Controls.Add(Me.CheckEdit2)
        Me.GroupControl1.Controls.Add(Me.CheckEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.btn_KodBul)
        Me.GroupControl1.Controls.Add(Me.LabelControl32)
        Me.GroupControl1.Controls.Add(Me.txt_sDovizCinsi)
        Me.GroupControl1.Controls.Add(Me.sec_bTahsilatYapilamaz)
        Me.GroupControl1.Controls.Add(Me.sec_bSatisYapilamaz)
        Me.GroupControl1.Controls.Add(Me.sec_bAktif)
        Me.GroupControl1.Controls.Add(Me.txt_sUlke)
        Me.GroupControl1.Controls.Add(Me.txt_sIl)
        Me.GroupControl1.Controls.Add(Me.txt_sSaticiRumuzu)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.txt_nOzelIskontosu4)
        Me.GroupControl1.Controls.Add(Me.txt_nOzelIskontosu3)
        Me.GroupControl1.Controls.Add(Me.txt_nOzelIskontosu2)
        Me.GroupControl1.Controls.Add(Me.txt_sKodu)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.txt_sFiyatTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txt_dteMutabakatTarihi)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txt_lKrediLimiti)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txt_sOzelNot)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.txt_nVadeGun)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.txt_nOzelIskontosu)
        Me.GroupControl1.Controls.Add(Me.lbl_Iskonto)
        Me.GroupControl1.Controls.Add(Me.txt_sVergiNo)
        Me.GroupControl1.Controls.Add(Me.lbl_VergiNo)
        Me.GroupControl1.Controls.Add(Me.txt_sVergiDairesi)
        Me.GroupControl1.Controls.Add(Me.lbl_VergiDairesi)
        Me.GroupControl1.Controls.Add(Me.btn_MuhasebeAc)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_sMuhasebeKodu)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl25)
        Me.GroupControl1.Controls.Add(Me.txt_sPostaKodu)
        Me.GroupControl1.Controls.Add(Me.LabelControl24)
        Me.GroupControl1.Controls.Add(Me.txt_sSemt)
        Me.GroupControl1.Controls.Add(Me.LabelControl23)
        Me.GroupControl1.Controls.Add(Me.txt_sAdres2)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txt_sAdres1)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_sHitap1)
        Me.GroupControl1.Controls.Add(Me.txt_sAdi)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl41)
        Me.GroupControl1.Controls.Add(Me.txt_nPeriyod)
        Me.GroupControl1.Controls.Add(Me.TextEdit6)
        Me.GroupControl1.Controls.Add(Me.TextEdit5)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1307, 376)
        Me.GroupControl1.TabIndex = 0
        '
        'efatura
        '
        Me.efatura.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sEfatura", True))
        Me.efatura.Location = New System.Drawing.Point(1093, 227)
        Me.efatura.Name = "efatura"
        Me.efatura.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.efatura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.efatura.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.efatura.Properties.Appearance.Options.UseBackColor = True
        Me.efatura.Properties.Appearance.Options.UseFont = True
        Me.efatura.Properties.Appearance.Options.UseForeColor = True
        Me.efatura.Properties.Caption = "E-Fatura"
        Me.efatura.Size = New System.Drawing.Size(184, 22)
        Me.efatura.TabIndex = 129
        '
        'sec_bSipariseKapali
        '
        Me.sec_bSipariseKapali.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.bSipariseKapali", True))
        Me.sec_bSipariseKapali.Location = New System.Drawing.Point(581, 304)
        Me.sec_bSipariseKapali.Name = "sec_bSipariseKapali"
        Me.sec_bSipariseKapali.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_bSipariseKapali.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_bSipariseKapali.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.sec_bSipariseKapali.Properties.Appearance.Options.UseBackColor = True
        Me.sec_bSipariseKapali.Properties.Appearance.Options.UseFont = True
        Me.sec_bSipariseKapali.Properties.Appearance.Options.UseForeColor = True
        Me.sec_bSipariseKapali.Properties.Caption = "Sipariþe Kapalý"
        Me.sec_bSipariseKapali.Size = New System.Drawing.Size(184, 22)
        Me.sec_bSipariseKapali.TabIndex = 128
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(285, 304)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(106, 19)
        Me.LabelControl44.TabIndex = 127
        Me.LabelControl44.Text = "Cari Kart Türü:"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sCariHesapTuru", True))
        Me.ComboBoxEdit1.EditValue = "Cari"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(411, 300)
        Me.ComboBoxEdit1.MenuManager = Me.BarManager1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Cari", "Banka", "Kasa", "Gider", "K.Kartý"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(160, 26)
        Me.ComboBoxEdit1.TabIndex = 126
        '
        'txt_TC
        '
        Me.txt_TC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.TC", True))
        Me.txt_TC.EnterMoveNextControl = True
        Me.txt_TC.Location = New System.Drawing.Point(115, 43)
        Me.txt_TC.Name = "txt_TC"
        Me.txt_TC.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_TC.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_TC.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_TC.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_TC.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_TC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_TC.Properties.Mask.EditMask = "000 000 000 00"
        Me.txt_TC.Properties.MaxLength = 11
        Me.txt_TC.Size = New System.Drawing.Size(215, 26)
        Me.txt_TC.TabIndex = 124
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl43.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl43.Location = New System.Drawing.Point(77, 49)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl43.TabIndex = 125
        Me.LabelControl43.Text = "TC:"
        '
        'txt_sMagaza
        '
        Me.txt_sMagaza.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sDepo", True))
        Me.txt_sMagaza.EnterMoveNextControl = True
        Me.txt_sMagaza.Location = New System.Drawing.Point(115, 300)
        Me.txt_sMagaza.Name = "txt_sMagaza"
        Me.txt_sMagaza.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMagaza.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMagaza.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sMagaza.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sMagaza.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sMagaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sMagaza.Properties.DisplayMember = "sDepo"
        Me.txt_sMagaza.Properties.NullText = "[Depo]"
        Me.txt_sMagaza.Properties.ValueMember = "sDepo"
        Me.txt_sMagaza.Size = New System.Drawing.Size(160, 26)
        Me.txt_sMagaza.TabIndex = 122
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl42.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl42.Location = New System.Drawing.Point(58, 304)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl42.TabIndex = 123
        Me.LabelControl42.Text = "Depo:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(806, 309)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl14.TabIndex = 119
        Me.LabelControl14.Text = "Ziyaret:"
        '
        'CheckEdit7
        '
        Me.CheckEdit7.Location = New System.Drawing.Point(1232, 306)
        Me.CheckEdit7.Name = "CheckEdit7"
        Me.CheckEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CheckEdit7.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit7.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit7.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit7.Properties.Caption = "Paz"
        Me.CheckEdit7.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit7.TabIndex = 118
        '
        'CheckEdit6
        '
        Me.CheckEdit6.Location = New System.Drawing.Point(1176, 306)
        Me.CheckEdit6.Name = "CheckEdit6"
        Me.CheckEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit6.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CheckEdit6.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit6.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit6.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit6.Properties.Caption = "Cmt"
        Me.CheckEdit6.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit6.TabIndex = 117
        '
        'CheckEdit5
        '
        Me.CheckEdit5.Location = New System.Drawing.Point(1120, 306)
        Me.CheckEdit5.Name = "CheckEdit5"
        Me.CheckEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CheckEdit5.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit5.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit5.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit5.Properties.Caption = "Cum"
        Me.CheckEdit5.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit5.TabIndex = 116
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(1064, 306)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CheckEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit4.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit4.Properties.Caption = "Per"
        Me.CheckEdit4.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit4.TabIndex = 115
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(1008, 306)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CheckEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit3.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit3.Properties.Caption = "Car"
        Me.CheckEdit3.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit3.TabIndex = 114
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(952, 306)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CheckEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit2.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit2.Properties.Caption = "Sal"
        Me.CheckEdit2.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit2.TabIndex = 113
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(896, 306)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CheckEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Pzt"
        Me.CheckEdit1.Size = New System.Drawing.Size(56, 19)
        Me.CheckEdit1.TabIndex = 112
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.Location = New System.Drawing.Point(1011, 277)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl12.TabIndex = 110
        Me.LabelControl12.Text = "Boylam:"
        '
        'btn_KodBul
        '
        Me.btn_KodBul.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_KodBul.Enabled = False
        Me.btn_KodBul.Image = Global.business_smart.My.Resources.Resources.help
        Me.btn_KodBul.Location = New System.Drawing.Point(332, 14)
        Me.btn_KodBul.Name = "btn_KodBul"
        Me.btn_KodBul.Size = New System.Drawing.Size(98, 31)
        Me.btn_KodBul.TabIndex = 106
        Me.btn_KodBul.Text = "Kod &Bul"
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl32.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl32.Location = New System.Drawing.Point(1011, 117)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl32.TabIndex = 94
        Me.LabelControl32.Text = "Pb:"
        '
        'txt_sDovizCinsi
        '
        Me.txt_sDovizCinsi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sDovizCinsi", True))
        Me.txt_sDovizCinsi.EnterMoveNextControl = True
        Me.txt_sDovizCinsi.Location = New System.Drawing.Point(1093, 119)
        Me.txt_sDovizCinsi.Name = "txt_sDovizCinsi"
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sDovizCinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sDovizCinsi.Properties.DisplayMember = "sDovizCinsi"
        Me.txt_sDovizCinsi.Properties.NullText = "[DovizCinsi]"
        Me.txt_sDovizCinsi.Properties.ValueMember = "sDovizCinsi"
        Me.txt_sDovizCinsi.Size = New System.Drawing.Size(165, 26)
        ToolTipTitleItem38.Text = "Satici"
        ToolTipItem32.LeftIndent = 6
        ToolTipItem32.Text = "Stok Fiþlerinde ve Raporlarda geçerli olmasý istenen Satici Personel buradan seçi" &
    "lir."
        SuperToolTip32.Items.Add(ToolTipTitleItem38)
        SuperToolTip32.Items.Add(ToolTipItem32)
        Me.txt_sDovizCinsi.SuperTip = SuperToolTip32
        Me.txt_sDovizCinsi.TabIndex = 17
        '
        'sec_bTahsilatYapilamaz
        '
        Me.sec_bTahsilatYapilamaz.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.bTahsilatYapilamaz", True))
        Me.sec_bTahsilatYapilamaz.Location = New System.Drawing.Point(1093, 200)
        Me.sec_bTahsilatYapilamaz.Name = "sec_bTahsilatYapilamaz"
        Me.sec_bTahsilatYapilamaz.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_bTahsilatYapilamaz.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_bTahsilatYapilamaz.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.sec_bTahsilatYapilamaz.Properties.Appearance.Options.UseBackColor = True
        Me.sec_bTahsilatYapilamaz.Properties.Appearance.Options.UseFont = True
        Me.sec_bTahsilatYapilamaz.Properties.Appearance.Options.UseForeColor = True
        Me.sec_bTahsilatYapilamaz.Properties.Caption = "TahsilatYapýlmasýn"
        Me.sec_bTahsilatYapilamaz.Size = New System.Drawing.Size(184, 22)
        Me.sec_bTahsilatYapilamaz.TabIndex = 24
        '
        'sec_bSatisYapilamaz
        '
        Me.sec_bSatisYapilamaz.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.bSatisYapilamaz", True))
        Me.sec_bSatisYapilamaz.Location = New System.Drawing.Point(1093, 173)
        Me.sec_bSatisYapilamaz.Name = "sec_bSatisYapilamaz"
        Me.sec_bSatisYapilamaz.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_bSatisYapilamaz.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_bSatisYapilamaz.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.sec_bSatisYapilamaz.Properties.Appearance.Options.UseBackColor = True
        Me.sec_bSatisYapilamaz.Properties.Appearance.Options.UseFont = True
        Me.sec_bSatisYapilamaz.Properties.Appearance.Options.UseForeColor = True
        Me.sec_bSatisYapilamaz.Properties.Caption = "SatýþYapýlmasýn"
        Me.sec_bSatisYapilamaz.Size = New System.Drawing.Size(184, 22)
        Me.sec_bSatisYapilamaz.TabIndex = 23
        '
        'sec_bAktif
        '
        Me.sec_bAktif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.bAktif", True))
        Me.sec_bAktif.EditValue = True
        Me.sec_bAktif.Location = New System.Drawing.Point(1093, 146)
        Me.sec_bAktif.Name = "sec_bAktif"
        Me.sec_bAktif.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_bAktif.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_bAktif.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.sec_bAktif.Properties.Appearance.Options.UseBackColor = True
        Me.sec_bAktif.Properties.Appearance.Options.UseFont = True
        Me.sec_bAktif.Properties.Appearance.Options.UseForeColor = True
        Me.sec_bAktif.Properties.Caption = "Aktif Hesap"
        Me.sec_bAktif.Size = New System.Drawing.Size(184, 22)
        Me.sec_bAktif.TabIndex = 22
        '
        'txt_sUlke
        '
        Me.txt_sUlke.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sUlke", True))
        Me.txt_sUlke.EnterMoveNextControl = True
        Me.txt_sUlke.Location = New System.Drawing.Point(115, 243)
        Me.txt_sUlke.Name = "txt_sUlke"
        Me.txt_sUlke.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUlke.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUlke.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sUlke.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sUlke.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sUlke.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sUlke.Properties.DisplayMember = "sUlke"
        Me.txt_sUlke.Properties.NullText = "[Ulke]"
        Me.txt_sUlke.Properties.ValueMember = "sUlke"
        Me.txt_sUlke.Size = New System.Drawing.Size(154, 26)
        Me.txt_sUlke.TabIndex = 7
        '
        'txt_sIl
        '
        Me.txt_sIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sIl", True))
        Me.txt_sIl.EnterMoveNextControl = True
        Me.txt_sIl.Location = New System.Drawing.Point(115, 214)
        Me.txt_sIl.Name = "txt_sIl"
        Me.txt_sIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sIl.Properties.DisplayMember = "sIl"
        Me.txt_sIl.Properties.NullText = "[Il]"
        Me.txt_sIl.Properties.ValueMember = "sIl"
        Me.txt_sIl.Size = New System.Drawing.Size(154, 26)
        Me.txt_sIl.TabIndex = 6
        '
        'txt_sSaticiRumuzu
        '
        Me.txt_sSaticiRumuzu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sSaticiRumuzu", True))
        Me.txt_sSaticiRumuzu.EnterMoveNextControl = True
        Me.txt_sSaticiRumuzu.Location = New System.Drawing.Point(899, 231)
        Me.txt_sSaticiRumuzu.Name = "txt_sSaticiRumuzu"
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSaticiRumuzu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSaticiRumuzu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sSaticiRumuzu.Properties.DisplayMember = "sSaticiRumuzu"
        Me.txt_sSaticiRumuzu.Properties.NullText = "[SaticiRumuzu]"
        Me.txt_sSaticiRumuzu.Properties.ValueMember = "sSaticiRumuzu"
        Me.txt_sSaticiRumuzu.Size = New System.Drawing.Size(192, 26)
        ToolTipTitleItem27.Text = "Satici"
        ToolTipItem23.LeftIndent = 6
        ToolTipItem23.Text = "Stok Fiþlerinde ve Raporlarda geçerli olmasý istenen Satici Personel buradan seçi" &
    "lir."
        SuperToolTip23.Items.Add(ToolTipTitleItem27)
        SuperToolTip23.Items.Add(ToolTipItem23)
        Me.txt_sSaticiRumuzu.SuperTip = SuperToolTip23
        Me.txt_sSaticiRumuzu.TabIndex = 21
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl20.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl20.Location = New System.Drawing.Point(821, 231)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl20.TabIndex = 90
        Me.LabelControl20.Text = "Satici:"
        '
        'txt_nOzelIskontosu4
        '
        Me.txt_nOzelIskontosu4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu4", True))
        Me.txt_nOzelIskontosu4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nOzelIskontosu4.EnterMoveNextControl = True
        Me.txt_nOzelIskontosu4.Location = New System.Drawing.Point(1179, 89)
        Me.txt_nOzelIskontosu4.Name = "txt_nOzelIskontosu4"
        Me.txt_nOzelIskontosu4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nOzelIskontosu4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nOzelIskontosu4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nOzelIskontosu4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nOzelIskontosu4.Size = New System.Drawing.Size(80, 26)
        ToolTipTitleItem12.Text = "Iskonto"
        ToolTipItem10.LeftIndent = 6
        SuperToolTip10.Items.Add(ToolTipTitleItem12)
        SuperToolTip10.Items.Add(ToolTipItem10)
        Me.txt_nOzelIskontosu4.SuperTip = SuperToolTip10
        Me.txt_nOzelIskontosu4.TabIndex = 15
        '
        'txt_nOzelIskontosu3
        '
        Me.txt_nOzelIskontosu3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu3", True))
        Me.txt_nOzelIskontosu3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nOzelIskontosu3.EnterMoveNextControl = True
        Me.txt_nOzelIskontosu3.Location = New System.Drawing.Point(1093, 89)
        Me.txt_nOzelIskontosu3.Name = "txt_nOzelIskontosu3"
        Me.txt_nOzelIskontosu3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nOzelIskontosu3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nOzelIskontosu3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nOzelIskontosu3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nOzelIskontosu3.Size = New System.Drawing.Size(85, 26)
        ToolTipTitleItem13.Text = "Iskonto"
        ToolTipItem11.LeftIndent = 6
        SuperToolTip11.Items.Add(ToolTipTitleItem13)
        SuperToolTip11.Items.Add(ToolTipItem11)
        Me.txt_nOzelIskontosu3.SuperTip = SuperToolTip11
        Me.txt_nOzelIskontosu3.TabIndex = 14
        '
        'txt_nOzelIskontosu2
        '
        Me.txt_nOzelIskontosu2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu2", True))
        Me.txt_nOzelIskontosu2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nOzelIskontosu2.EnterMoveNextControl = True
        Me.txt_nOzelIskontosu2.Location = New System.Drawing.Point(1002, 89)
        Me.txt_nOzelIskontosu2.Name = "txt_nOzelIskontosu2"
        Me.txt_nOzelIskontosu2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nOzelIskontosu2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nOzelIskontosu2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nOzelIskontosu2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nOzelIskontosu2.Size = New System.Drawing.Size(91, 26)
        ToolTipTitleItem14.Text = "Iskonto"
        ToolTipItem12.LeftIndent = 6
        SuperToolTip12.Items.Add(ToolTipTitleItem14)
        SuperToolTip12.Items.Add(ToolTipItem12)
        Me.txt_nOzelIskontosu2.SuperTip = SuperToolTip12
        Me.txt_nOzelIskontosu2.TabIndex = 13
        '
        'txt_sKodu
        '
        Me.txt_sKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sKodu", True))
        Me.txt_sKodu.EditValue = ""
        Me.txt_sKodu.Enabled = False
        Me.txt_sKodu.EnterMoveNextControl = True
        Me.txt_sKodu.Location = New System.Drawing.Point(115, 13)
        Me.txt_sKodu.Name = "txt_sKodu"
        Me.txt_sKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKodu.Properties.MaxLength = 20
        Me.txt_sKodu.Size = New System.Drawing.Size(215, 26)
        ToolTipTitleItem15.Text = "Hesap Kodlarý Açýlýmý"
        ToolTipItem13.LeftIndent = 6
        ToolTipTitleItem39.LeftIndent = 6
        ToolTipTitleItem39.Text = "Muhasebe Yönetimi"
        SuperToolTip13.Items.Add(ToolTipTitleItem15)
        SuperToolTip13.Items.Add(ToolTipItem13)
        SuperToolTip13.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip13.Items.Add(ToolTipTitleItem39)
        Me.txt_sKodu.SuperTip = SuperToolTip13
        Me.txt_sKodu.TabIndex = 0
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl19.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl19.Location = New System.Drawing.Point(59, 17)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl19.TabIndex = 85
        Me.LabelControl19.Text = "Kodu:"
        '
        'txt_sFiyatTipi
        '
        Me.txt_sFiyatTipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sFiyatTipi", True))
        Me.txt_sFiyatTipi.EnterMoveNextControl = True
        Me.txt_sFiyatTipi.Location = New System.Drawing.Point(899, 203)
        Me.txt_sFiyatTipi.Name = "txt_sFiyatTipi"
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sFiyatTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sFiyatTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sFiyatTipi.Properties.DisplayMember = "sFiyatTipi"
        Me.txt_sFiyatTipi.Properties.NullText = "[FiyatTipi]"
        Me.txt_sFiyatTipi.Properties.ValueMember = "sFiyatTipi"
        Me.txt_sFiyatTipi.Size = New System.Drawing.Size(192, 26)
        ToolTipTitleItem16.Text = "Hesap Kodlarý Açýlýmý"
        ToolTipItem14.LeftIndent = 6
        ToolTipItem14.Text = "Stok Fiþlerinde geçerli olmasý istenen Fiyat Tipi burdan belirlenir."
        ToolTipTitleItem28.LeftIndent = 6
        ToolTipTitleItem28.Text = "Fiyat Tipi"
        SuperToolTip14.Items.Add(ToolTipTitleItem16)
        SuperToolTip14.Items.Add(ToolTipItem14)
        SuperToolTip14.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip14.Items.Add(ToolTipTitleItem28)
        Me.txt_sFiyatTipi.SuperTip = SuperToolTip14
        Me.txt_sFiyatTipi.TabIndex = 20
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(792, 203)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl7.TabIndex = 83
        Me.LabelControl7.Text = "Fiyat Tipi:"
        '
        'txt_dteMutabakatTarihi
        '
        Me.txt_dteMutabakatTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.dteMutabakatTarihi", True))
        Me.txt_dteMutabakatTarihi.EditValue = Nothing
        Me.txt_dteMutabakatTarihi.EnterMoveNextControl = True
        Me.txt_dteMutabakatTarihi.Location = New System.Drawing.Point(899, 174)
        Me.txt_dteMutabakatTarihi.Name = "txt_dteMutabakatTarihi"
        Me.txt_dteMutabakatTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteMutabakatTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteMutabakatTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteMutabakatTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteMutabakatTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteMutabakatTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteMutabakatTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteMutabakatTarihi.Size = New System.Drawing.Size(192, 26)
        ToolTipTitleItem17.Text = "Mutabakat Tarihi"
        ToolTipItem15.LeftIndent = 6
        SuperToolTip15.Items.Add(ToolTipTitleItem17)
        SuperToolTip15.Items.Add(ToolTipItem15)
        Me.txt_dteMutabakatTarihi.SuperTip = SuperToolTip15
        Me.txt_dteMutabakatTarihi.TabIndex = 19
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(733, 174)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(124, 19)
        Me.LabelControl9.TabIndex = 81
        Me.LabelControl9.Text = "Mutabakat Tarihi:"
        '
        'txt_lKrediLimiti
        '
        Me.txt_lKrediLimiti.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.lKrediLimiti", True))
        Me.txt_lKrediLimiti.Enabled = False
        Me.txt_lKrediLimiti.EnterMoveNextControl = True
        Me.txt_lKrediLimiti.Location = New System.Drawing.Point(899, 146)
        Me.txt_lKrediLimiti.Name = "txt_lKrediLimiti"
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lKrediLimiti.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lKrediLimiti.Size = New System.Drawing.Size(192, 26)
        ToolTipTitleItem18.Text = "Kredi Limiti"
        ToolTipItem16.LeftIndent = 6
        ToolTipItem16.Text = "Hesaplarda Kredi Limiti kontrolü istendiðinde limit tutarý buraya girilir. Kredi " &
    "Limiti aþýldýðýnda veya yaklaþýldýðýnda sistem otomatik uyarmakta veya istendiði" &
    "nde iþlem engellenmektedir."
        SuperToolTip16.Items.Add(ToolTipTitleItem18)
        SuperToolTip16.Items.Add(ToolTipItem16)
        Me.txt_lKrediLimiti.SuperTip = SuperToolTip16
        Me.txt_lKrediLimiti.TabIndex = 18
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(781, 146)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl13.TabIndex = 79
        Me.LabelControl13.Text = "Kredi Limiti:"
        '
        'txt_sOzelNot
        '
        Me.txt_sOzelNot.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sOzelNot", True))
        Me.txt_sOzelNot.EnterMoveNextControl = True
        Me.txt_sOzelNot.Location = New System.Drawing.Point(899, 60)
        Me.txt_sOzelNot.Name = "txt_sOzelNot"
        Me.txt_sOzelNot.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sOzelNot.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sOzelNot.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sOzelNot.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sOzelNot.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sOzelNot.Properties.MaxLength = 60
        Me.txt_sOzelNot.Size = New System.Drawing.Size(359, 26)
        Me.txt_sOzelNot.TabIndex = 11
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(795, 60)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl16.TabIndex = 77
        Me.LabelControl16.Text = "Özel Not:"
        '
        'txt_nVadeGun
        '
        Me.txt_nVadeGun.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nVadeGun", True))
        Me.txt_nVadeGun.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nVadeGun.EnterMoveNextControl = True
        Me.txt_nVadeGun.Location = New System.Drawing.Point(899, 117)
        Me.txt_nVadeGun.Name = "txt_nVadeGun"
        Me.txt_nVadeGun.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nVadeGun.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nVadeGun.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nVadeGun.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nVadeGun.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nVadeGun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nVadeGun.Size = New System.Drawing.Size(103, 26)
        ToolTipTitleItem19.Text = "Vade"
        ToolTipItem17.LeftIndent = 6
        ToolTipItem17.Text = "Otomatik Vade Tarihi Atýlmasý istendiðinde buraya Vade Gün sayýsý girilir. Sistem" &
    " buraya girilmis veri doðrultusunda Stok fislerinde Vade Tarihini otomatik girme" &
    "ktedir."
        SuperToolTip17.Items.Add(ToolTipTitleItem19)
        SuperToolTip17.Items.Add(ToolTipItem17)
        Me.txt_nVadeGun.SuperTip = SuperToolTip17
        Me.txt_nVadeGun.TabIndex = 16
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.Location = New System.Drawing.Point(774, 117)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl15.TabIndex = 76
        Me.LabelControl15.Text = "Vade (Gün):"
        '
        'txt_nOzelIskontosu
        '
        Me.txt_nOzelIskontosu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nOzelIskontosu", True))
        Me.txt_nOzelIskontosu.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nOzelIskontosu.EnterMoveNextControl = True
        Me.txt_nOzelIskontosu.Location = New System.Drawing.Point(899, 89)
        Me.txt_nOzelIskontosu.Name = "txt_nOzelIskontosu"
        Me.txt_nOzelIskontosu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOzelIskontosu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nOzelIskontosu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nOzelIskontosu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nOzelIskontosu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nOzelIskontosu.Size = New System.Drawing.Size(103, 26)
        ToolTipTitleItem20.Text = "Iskonto"
        ToolTipItem18.LeftIndent = 6
        SuperToolTip18.Items.Add(ToolTipTitleItem20)
        SuperToolTip18.Items.Add(ToolTipItem18)
        Me.txt_nOzelIskontosu.SuperTip = SuperToolTip18
        Me.txt_nOzelIskontosu.TabIndex = 12
        '
        'lbl_Iskonto
        '
        Me.lbl_Iskonto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Iskonto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Iskonto.Location = New System.Drawing.Point(803, 89)
        Me.lbl_Iskonto.Name = "lbl_Iskonto"
        Me.lbl_Iskonto.Size = New System.Drawing.Size(59, 19)
        Me.lbl_Iskonto.TabIndex = 75
        Me.lbl_Iskonto.Text = "Ýskonto:"
        '
        'txt_sVergiNo
        '
        Me.txt_sVergiNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sVergiNo", True))
        Me.txt_sVergiNo.EnterMoveNextControl = True
        Me.txt_sVergiNo.Location = New System.Drawing.Point(899, 31)
        Me.txt_sVergiNo.Name = "txt_sVergiNo"
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiNo.Properties.MaxLength = 60
        Me.txt_sVergiNo.Size = New System.Drawing.Size(359, 26)
        Me.txt_sVergiNo.TabIndex = 10
        '
        'lbl_VergiNo
        '
        Me.lbl_VergiNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_VergiNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_VergiNo.Location = New System.Drawing.Point(797, 31)
        Me.lbl_VergiNo.Name = "lbl_VergiNo"
        Me.lbl_VergiNo.Size = New System.Drawing.Size(68, 19)
        Me.lbl_VergiNo.TabIndex = 74
        Me.lbl_VergiNo.Text = "Vergi No:"
        '
        'txt_sVergiDairesi
        '
        Me.txt_sVergiDairesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sVergiDairesi", True))
        Me.txt_sVergiDairesi.EnterMoveNextControl = True
        Me.txt_sVergiDairesi.Location = New System.Drawing.Point(899, 3)
        Me.txt_sVergiDairesi.Name = "txt_sVergiDairesi"
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiDairesi.Properties.MaxLength = 60
        Me.txt_sVergiDairesi.Size = New System.Drawing.Size(359, 26)
        Me.txt_sVergiDairesi.TabIndex = 9
        '
        'lbl_VergiDairesi
        '
        Me.lbl_VergiDairesi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_VergiDairesi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_VergiDairesi.Location = New System.Drawing.Point(766, 3)
        Me.lbl_VergiDairesi.Name = "lbl_VergiDairesi"
        Me.lbl_VergiDairesi.Size = New System.Drawing.Size(96, 19)
        Me.lbl_VergiDairesi.TabIndex = 73
        Me.lbl_VergiDairesi.Text = "Vergi Dairesi:"
        '
        'btn_MuhasebeAc
        '
        Me.btn_MuhasebeAc.Image = CType(resources.GetObject("btn_MuhasebeAc.Image"), System.Drawing.Image)
        Me.btn_MuhasebeAc.Location = New System.Drawing.Point(482, 271)
        Me.btn_MuhasebeAc.Name = "btn_MuhasebeAc"
        Me.btn_MuhasebeAc.Size = New System.Drawing.Size(166, 29)
        Me.btn_MuhasebeAc.TabIndex = 59
        Me.btn_MuhasebeAc.Text = "Muhasebede Aç"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(19, 276)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl6.TabIndex = 58
        Me.LabelControl6.Text = "Muhasebe:"
        '
        'txt_sMuhasebeKodu
        '
        Me.txt_sMuhasebeKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sMuhasebeKodu", True))
        Me.txt_sMuhasebeKodu.EnterMoveNextControl = True
        Me.txt_sMuhasebeKodu.Location = New System.Drawing.Point(115, 271)
        Me.txt_sMuhasebeKodu.Name = "txt_sMuhasebeKodu"
        Me.txt_sMuhasebeKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMuhasebeKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMuhasebeKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sMuhasebeKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sMuhasebeKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sMuhasebeKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sMuhasebeKodu.Size = New System.Drawing.Size(357, 26)
        Me.txt_sMuhasebeKodu.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(66, 247)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 19)
        Me.LabelControl5.TabIndex = 56
        Me.LabelControl5.Text = "Ülke:"
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl25.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl25.Location = New System.Drawing.Point(88, 219)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(16, 19)
        Me.LabelControl25.TabIndex = 54
        Me.LabelControl25.Text = "Ýl:"
        '
        'txt_sPostaKodu
        '
        Me.txt_sPostaKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sPostaKodu", True))
        Me.txt_sPostaKodu.EnterMoveNextControl = True
        Me.txt_sPostaKodu.Location = New System.Drawing.Point(115, 186)
        Me.txt_sPostaKodu.Name = "txt_sPostaKodu"
        Me.txt_sPostaKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sPostaKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sPostaKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sPostaKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sPostaKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sPostaKodu.Properties.MaxLength = 20
        Me.txt_sPostaKodu.Size = New System.Drawing.Size(154, 26)
        Me.txt_sPostaKodu.TabIndex = 5
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl24.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl24.Location = New System.Drawing.Point(11, 190)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(85, 19)
        Me.LabelControl24.TabIndex = 53
        Me.LabelControl24.Text = "Posta Kodu:"
        '
        'txt_sSemt
        '
        Me.txt_sSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sSemt", True))
        Me.txt_sSemt.EnterMoveNextControl = True
        Me.txt_sSemt.Location = New System.Drawing.Point(115, 157)
        Me.txt_sSemt.Name = "txt_sSemt"
        Me.txt_sSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSemt.Properties.MaxLength = 60
        Me.txt_sSemt.Size = New System.Drawing.Size(359, 26)
        Me.txt_sSemt.TabIndex = 4
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl23.Location = New System.Drawing.Point(59, 161)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl23.TabIndex = 52
        Me.LabelControl23.Text = "Semt:"
        '
        'txt_sAdres2
        '
        Me.txt_sAdres2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAdres2", True))
        Me.txt_sAdres2.EnterMoveNextControl = True
        Me.txt_sAdres2.Location = New System.Drawing.Point(115, 129)
        Me.txt_sAdres2.Name = "txt_sAdres2"
        Me.txt_sAdres2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdres2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdres2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdres2.Properties.MaxLength = 60
        Me.txt_sAdres2.Size = New System.Drawing.Size(507, 26)
        Me.txt_sAdres2.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(38, 133)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Adres 2:"
        '
        'txt_sAdres1
        '
        Me.txt_sAdres1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAdres1", True))
        Me.txt_sAdres1.EnterMoveNextControl = True
        Me.txt_sAdres1.Location = New System.Drawing.Point(115, 100)
        Me.txt_sAdres1.Name = "txt_sAdres1"
        Me.txt_sAdres1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdres1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdres1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdres1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdres1.Properties.MaxLength = 60
        Me.txt_sAdres1.Size = New System.Drawing.Size(507, 26)
        Me.txt_sAdres1.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(38, 104)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl1.TabIndex = 46
        Me.LabelControl1.Text = "Adres 1:"
        '
        'txt_sHitap1
        '
        Me.txt_sHitap1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sHitap", True))
        Me.txt_sHitap1.EnterMoveNextControl = True
        Me.txt_sHitap1.Location = New System.Drawing.Point(496, 13)
        Me.txt_sHitap1.Name = "txt_sHitap1"
        Me.txt_sHitap1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap1.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap1.Properties.NullText = "[Hitap]"
        Me.txt_sHitap1.Properties.ValueMember = "sHitap"
        Me.txt_sHitap1.Size = New System.Drawing.Size(126, 26)
        ToolTipTitleItem21.Text = "Hitap"
        ToolTipItem19.LeftIndent = 6
        ToolTipItem19.Text = "Yazýþmalarda Kullanýlacak Hitap Sekli Burdan belirlenir." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sayýn Ahmet Bey" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bay..." &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bayan..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Müdür..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ".........."
        SuperToolTip19.Items.Add(ToolTipTitleItem21)
        SuperToolTip19.Items.Add(ToolTipItem19)
        Me.txt_sHitap1.SuperTip = SuperToolTip19
        Me.txt_sHitap1.TabIndex = 0
        '
        'txt_sAdi
        '
        Me.txt_sAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAciklama", True))
        Me.txt_sAdi.EnterMoveNextControl = True
        Me.txt_sAdi.Location = New System.Drawing.Point(115, 71)
        Me.txt_sAdi.Name = "txt_sAdi"
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdi.Properties.MaxLength = 60
        Me.txt_sAdi.Size = New System.Drawing.Size(507, 26)
        Me.txt_sAdi.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(74, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl3.TabIndex = 44
        Me.LabelControl3.Text = "Adý:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(440, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl2.TabIndex = 43
        Me.LabelControl2.Text = "Hitap:"
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl41.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl41.Location = New System.Drawing.Point(1099, 254)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl41.TabIndex = 120
        Me.LabelControl41.Text = "Periyod:"
        '
        'txt_nPeriyod
        '
        Me.txt_nPeriyod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nPeriyod", True))
        Me.txt_nPeriyod.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nPeriyod.EnterMoveNextControl = True
        Me.txt_nPeriyod.Location = New System.Drawing.Point(1224, 263)
        Me.txt_nPeriyod.Name = "txt_nPeriyod"
        Me.txt_nPeriyod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nPeriyod.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nPeriyod.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nPeriyod.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nPeriyod.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nPeriyod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nPeriyod.Size = New System.Drawing.Size(80, 26)
        ToolTipTitleItem22.Text = "Iskonto"
        ToolTipItem20.LeftIndent = 6
        SuperToolTip20.Items.Add(ToolTipTitleItem22)
        SuperToolTip20.Items.Add(ToolTipItem20)
        Me.txt_nPeriyod.SuperTip = SuperToolTip20
        Me.txt_nPeriyod.TabIndex = 121
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nBoylam", True))
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(1096, 277)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "#,0.######"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.MaxLength = 60
        Me.TextEdit6.Size = New System.Drawing.Size(102, 26)
        Me.TextEdit6.TabIndex = 111
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.nEnlem", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(899, 277)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "#,0.######"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.MaxLength = 60
        Me.TextEdit5.Size = New System.Drawing.Size(103, 26)
        Me.TextEdit5.TabIndex = 108
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(816, 277)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(50, 19)
        Me.LabelControl11.TabIndex = 109
        Me.LabelControl11.Text = "Enlem:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Image = CType(resources.GetObject("XtraTabPage2.Image"), System.Drawing.Image)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage2.Text = "Sýnýflandýrma"
        Me.XtraTabPage2.Tooltip = "Hesaplarý Sýnýflandýrma Ýþlemi Buradan Yapýlýr"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbFirmaSinifi
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSinifKodu, Me.sec_siniflar, Me.sec_Sinif})
        Me.GridControl1.Size = New System.Drawing.Size(1307, 376)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ds_tbFirmaSinifi
        '
        Me.ds_tbFirmaSinifi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaSinifi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaSinifi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "nFirmaID"
        Me.DataColumn37.DataType = GetType(Long)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sSinifTipi"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "sSinifKodu"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sAciklama"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "bSatisYapilamaz"
        Me.DataColumn41.DataType = GetType(Boolean)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsSinifTipi, Me.colsSinifKodu, Me.colsAciklama, Me.colbSatisYapilamaz})
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müþteri ID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        Me.colnMusteriID.OptionsColumn.AllowFocus = False
        '
        'colsSinifTipi
        '
        Me.colsSinifTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsSinifTipi.AppearanceCell.Options.UseFont = True
        Me.colsSinifTipi.Caption = "Sýnýf Tipi"
        Me.colsSinifTipi.FieldName = "sSinifTipi"
        Me.colsSinifTipi.Name = "colsSinifTipi"
        Me.colsSinifTipi.OptionsColumn.AllowEdit = False
        Me.colsSinifTipi.OptionsColumn.AllowFocus = False
        Me.colsSinifTipi.Visible = True
        Me.colsSinifTipi.VisibleIndex = 0
        '
        'colsSinifKodu
        '
        Me.colsSinifKodu.Caption = "Sýnýfý"
        Me.colsSinifKodu.ColumnEdit = Me.sec_Sinif
        Me.colsSinifKodu.FieldName = "sSinifKodu"
        Me.colsSinifKodu.Name = "colsSinifKodu"
        Me.colsSinifKodu.Visible = True
        Me.colsSinifKodu.VisibleIndex = 1
        '
        'sec_Sinif
        '
        Me.sec_Sinif.AutoHeight = False
        Me.sec_Sinif.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Sinif.DisplayMember = "sSinifKodu"
        Me.sec_Sinif.Name = "sec_Sinif"
        Me.sec_Sinif.NullText = "[Sinif]"
        Me.sec_Sinif.ValueMember = "sSinifKodu"
        Me.sec_Sinif.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colsAciklama
        '
        Me.colsAciklama.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsAciklama.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colsAciklama.AppearanceCell.Options.UseFont = True
        Me.colsAciklama.AppearanceCell.Options.UseForeColor = True
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowEdit = False
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colbSatisYapilamaz
        '
        Me.colbSatisYapilamaz.Caption = "Satýþ Yapýlamaz"
        Me.colbSatisYapilamaz.FieldName = "bSatisYapilamaz"
        Me.colbSatisYapilamaz.Name = "colbSatisYapilamaz"
        Me.colbSatisYapilamaz.OptionsColumn.AllowEdit = False
        Me.colbSatisYapilamaz.OptionsColumn.AllowFocus = False
        '
        'sec_sSinifKodu
        '
        Me.sec_sSinifKodu.AutoHeight = False
        Me.sec_sSinifKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu.DisplayMember = "sSinifKodu"
        Me.sec_sSinifKodu.Name = "sec_sSinifKodu"
        Me.sec_sSinifKodu.NullText = "[Sýnýflar]"
        Me.sec_sSinifKodu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.sec_sSinifKodu.ValueMember = "sSinifKodu"
        '
        'sec_siniflar
        '
        Me.sec_siniflar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_siniflar.DisplayMember = "sSinifKodu"
        Me.sec_siniflar.Name = "sec_siniflar"
        Me.sec_siniflar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.sec_siniflar.ValueMember = "sSinifKodu"
        Me.sec_siniflar.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.RepositoryItemGridLookUpEdit1View.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsFilter.UseNewCustomFilterDialog = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsFind.AlwaysVisible = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsPrint.EnableAppearanceEvenRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.pnl_yetkililer)
        Me.XtraTabPage3.Controls.Add(Me.pnl_yetkili_status)
        Me.XtraTabPage3.Image = CType(resources.GetObject("XtraTabPage3.Image"), System.Drawing.Image)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage3.Text = "Yetkililer"
        Me.XtraTabPage3.Tooltip = "Hesap Kartý Yetkilileri Buradan Tanýmlanýr"
        '
        'pnl_yetkililer
        '
        Me.pnl_yetkililer.Controls.Add(Me.GridControl2)
        Me.pnl_yetkililer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_yetkililer.Location = New System.Drawing.Point(0, 0)
        Me.pnl_yetkililer.Name = "pnl_yetkililer"
        Me.pnl_yetkililer.Size = New System.Drawing.Size(1307, 326)
        Me.pnl_yetkililer.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_yetkili
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_tbFirmaYetkilisi
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sHitap1, Me.sec_sUnvan})
        Me.GridControl2.Size = New System.Drawing.Size(1303, 322)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_yetkili
        '
        Me.kisayol_yetkili.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
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
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        Me.MenuItem3.Visible = False
        '
        'ds_tbFirmaYetkilisi
        '
        Me.ds_tbFirmaYetkilisi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaYetkilisi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaYetkilisi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nYetkiliID"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "nFirmaID"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sUnvan"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sHitap"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sAdiSoyadi"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnYetkiliID, Me.colnFirmaID, Me.colsUnvan, Me.colsHitap, Me.colsAdiSoyadi})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colnYetkiliID
        '
        Me.colnYetkiliID.Caption = "Yetkili ID"
        Me.colnYetkiliID.FieldName = "nYetkiliID"
        Me.colnYetkiliID.Name = "colnYetkiliID"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma ID"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colsUnvan
        '
        Me.colsUnvan.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlDark
        Me.colsUnvan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsUnvan.AppearanceCell.Options.UseBackColor = True
        Me.colsUnvan.AppearanceCell.Options.UseFont = True
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.ColumnEdit = Me.sec_sUnvan
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        Me.colsUnvan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sUnvan", "{0} Kayýt")})
        Me.colsUnvan.Visible = True
        Me.colsUnvan.VisibleIndex = 0
        '
        'sec_sUnvan
        '
        Me.sec_sUnvan.AutoHeight = False
        Me.sec_sUnvan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sUnvan.DisplayMember = "sUnvan"
        Me.sec_sUnvan.Name = "sec_sUnvan"
        Me.sec_sUnvan.NullText = "[Unvan]"
        Me.sec_sUnvan.ValueMember = "sUnvan"
        '
        'colsHitap
        '
        Me.colsHitap.Caption = "Hitap"
        Me.colsHitap.ColumnEdit = Me.sec_sHitap1
        Me.colsHitap.FieldName = "sHitap"
        Me.colsHitap.Name = "colsHitap"
        Me.colsHitap.Visible = True
        Me.colsHitap.VisibleIndex = 1
        '
        'sec_sHitap1
        '
        Me.sec_sHitap1.AutoHeight = False
        Me.sec_sHitap1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sHitap1.DisplayMember = "sHitap"
        Me.sec_sHitap1.Name = "sec_sHitap1"
        Me.sec_sHitap1.NullText = "[Hitap]"
        Me.sec_sHitap1.ValueMember = "sHitap"
        '
        'colsAdiSoyadi
        '
        Me.colsAdiSoyadi.Caption = "Adý Soyadý"
        Me.colsAdiSoyadi.FieldName = "sAdiSoyadi"
        Me.colsAdiSoyadi.Name = "colsAdiSoyadi"
        Me.colsAdiSoyadi.Visible = True
        Me.colsAdiSoyadi.VisibleIndex = 2
        '
        'pnl_yetkili_status
        '
        Me.pnl_yetkili_status.Controls.Add(Me.btn_yetkili_yazdir)
        Me.pnl_yetkili_status.Controls.Add(Me.btn_yetkili_sil)
        Me.pnl_yetkili_status.Controls.Add(Me.btn_yetkili_ekle)
        Me.pnl_yetkili_status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_yetkili_status.Location = New System.Drawing.Point(0, 326)
        Me.pnl_yetkili_status.Name = "pnl_yetkili_status"
        Me.pnl_yetkili_status.Size = New System.Drawing.Size(1307, 50)
        Me.pnl_yetkili_status.TabIndex = 1
        '
        'btn_yetkili_yazdir
        '
        Me.btn_yetkili_yazdir.Image = CType(resources.GetObject("btn_yetkili_yazdir.Image"), System.Drawing.Image)
        Me.btn_yetkili_yazdir.Location = New System.Drawing.Point(248, 10)
        Me.btn_yetkili_yazdir.Name = "btn_yetkili_yazdir"
        Me.btn_yetkili_yazdir.Size = New System.Drawing.Size(120, 33)
        Me.btn_yetkili_yazdir.TabIndex = 2
        Me.btn_yetkili_yazdir.Text = "&Yazdýr"
        '
        'btn_yetkili_sil
        '
        Me.btn_yetkili_sil.Image = CType(resources.GetObject("btn_yetkili_sil.Image"), System.Drawing.Image)
        Me.btn_yetkili_sil.Location = New System.Drawing.Point(128, 10)
        Me.btn_yetkili_sil.Name = "btn_yetkili_sil"
        Me.btn_yetkili_sil.Size = New System.Drawing.Size(120, 33)
        Me.btn_yetkili_sil.TabIndex = 1
        Me.btn_yetkili_sil.Text = "&Sil"
        '
        'btn_yetkili_ekle
        '
        Me.btn_yetkili_ekle.Image = CType(resources.GetObject("btn_yetkili_ekle.Image"), System.Drawing.Image)
        Me.btn_yetkili_ekle.Location = New System.Drawing.Point(8, 10)
        Me.btn_yetkili_ekle.Name = "btn_yetkili_ekle"
        Me.btn_yetkili_ekle.Size = New System.Drawing.Size(120, 33)
        Me.btn_yetkili_ekle.TabIndex = 0
        Me.btn_yetkili_ekle.Text = "&Ekle"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.pnl_iletisim)
        Me.XtraTabPage4.Controls.Add(Me.pnl_iletisim_status)
        Me.XtraTabPage4.Image = CType(resources.GetObject("XtraTabPage4.Image"), System.Drawing.Image)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage4.Text = "Ýletiþim"
        Me.XtraTabPage4.Tooltip = "Hesap Kartý Iletiþim Bilgileri Buradan Takip Edilir"
        '
        'pnl_iletisim
        '
        Me.pnl_iletisim.Controls.Add(Me.GridControl3)
        Me.pnl_iletisim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_iletisim.Location = New System.Drawing.Point(0, 0)
        Me.pnl_iletisim.Name = "pnl_iletisim"
        Me.pnl_iletisim.Size = New System.Drawing.Size(1307, 326)
        Me.pnl_iletisim.TabIndex = 2
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.kisayol_iletisim
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.ds_tbFirmaIletisimi
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_IletisimAraci})
        Me.GridControl3.Size = New System.Drawing.Size(1303, 322)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'kisayol_iletisim
        '
        Me.kisayol_iletisim.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem4.Text = "Ekle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem5.Text = "Düzelt"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem6.Text = "Sil"
        '
        'ds_tbFirmaIletisimi
        '
        Me.ds_tbFirmaIletisimi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaIletisimi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaIletisimi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "nIletisimID"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "nFirmaID"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sIletisimAraci"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sIletisimAdresi"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnIletisimID, Me.colnFirmaID1, Me.colsIletisimAraci, Me.colsIletisimAdresi})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colnIletisimID
        '
        Me.colnIletisimID.Caption = "Ýletiþim ID"
        Me.colnIletisimID.FieldName = "nIletisimID"
        Me.colnIletisimID.Name = "colnIletisimID"
        '
        'colnFirmaID1
        '
        Me.colnFirmaID1.Caption = "Firma ID"
        Me.colnFirmaID1.FieldName = "nFirmaID"
        Me.colnFirmaID1.Name = "colnFirmaID1"
        '
        'colsIletisimAraci
        '
        Me.colsIletisimAraci.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlDark
        Me.colsIletisimAraci.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsIletisimAraci.AppearanceCell.Options.UseBackColor = True
        Me.colsIletisimAraci.AppearanceCell.Options.UseFont = True
        Me.colsIletisimAraci.Caption = "Ýletiþim Aracý"
        Me.colsIletisimAraci.ColumnEdit = Me.sec_IletisimAraci
        Me.colsIletisimAraci.FieldName = "sIletisimAraci"
        Me.colsIletisimAraci.Name = "colsIletisimAraci"
        Me.colsIletisimAraci.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sIletisimAraci", "{0} Kayýt")})
        Me.colsIletisimAraci.Visible = True
        Me.colsIletisimAraci.VisibleIndex = 0
        '
        'sec_IletisimAraci
        '
        Me.sec_IletisimAraci.AutoHeight = False
        Me.sec_IletisimAraci.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_IletisimAraci.DisplayMember = "sIletisimAraci"
        Me.sec_IletisimAraci.Name = "sec_IletisimAraci"
        Me.sec_IletisimAraci.NullText = "[IletisimAracý]"
        Me.sec_IletisimAraci.ValueMember = "sIletisimAraci"
        '
        'colsIletisimAdresi
        '
        Me.colsIletisimAdresi.Caption = "Ýletiþim Adresi"
        Me.colsIletisimAdresi.FieldName = "sIletisimAdresi"
        Me.colsIletisimAdresi.Name = "colsIletisimAdresi"
        Me.colsIletisimAdresi.Visible = True
        Me.colsIletisimAdresi.VisibleIndex = 1
        '
        'pnl_iletisim_status
        '
        Me.pnl_iletisim_status.Controls.Add(Me.btn_iletisim_yazdir)
        Me.pnl_iletisim_status.Controls.Add(Me.btn_iletisim_sil)
        Me.pnl_iletisim_status.Controls.Add(Me.btn_iletisim_ekle)
        Me.pnl_iletisim_status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_iletisim_status.Location = New System.Drawing.Point(0, 326)
        Me.pnl_iletisim_status.Name = "pnl_iletisim_status"
        Me.pnl_iletisim_status.Size = New System.Drawing.Size(1307, 50)
        Me.pnl_iletisim_status.TabIndex = 1
        '
        'btn_iletisim_yazdir
        '
        Me.btn_iletisim_yazdir.Image = CType(resources.GetObject("btn_iletisim_yazdir.Image"), System.Drawing.Image)
        Me.btn_iletisim_yazdir.Location = New System.Drawing.Point(248, 10)
        Me.btn_iletisim_yazdir.Name = "btn_iletisim_yazdir"
        Me.btn_iletisim_yazdir.Size = New System.Drawing.Size(120, 33)
        Me.btn_iletisim_yazdir.TabIndex = 2
        Me.btn_iletisim_yazdir.Text = "&Yazdir"
        '
        'btn_iletisim_sil
        '
        Me.btn_iletisim_sil.Image = CType(resources.GetObject("btn_iletisim_sil.Image"), System.Drawing.Image)
        Me.btn_iletisim_sil.Location = New System.Drawing.Point(128, 10)
        Me.btn_iletisim_sil.Name = "btn_iletisim_sil"
        Me.btn_iletisim_sil.Size = New System.Drawing.Size(120, 33)
        Me.btn_iletisim_sil.TabIndex = 1
        Me.btn_iletisim_sil.Text = "&Sil"
        '
        'btn_iletisim_ekle
        '
        Me.btn_iletisim_ekle.Image = CType(resources.GetObject("btn_iletisim_ekle.Image"), System.Drawing.Image)
        Me.btn_iletisim_ekle.Location = New System.Drawing.Point(8, 10)
        Me.btn_iletisim_ekle.Name = "btn_iletisim_ekle"
        Me.btn_iletisim_ekle.Size = New System.Drawing.Size(120, 33)
        Me.btn_iletisim_ekle.TabIndex = 0
        Me.btn_iletisim_ekle.Text = "&Ekle"
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage9.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage9.Image = Global.business_smart.My.Resources.Resources.signpost
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage9.Text = "Adresler"
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.GridControl8)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(1307, 326)
        Me.PanelControl7.TabIndex = 1
        '
        'GridControl8
        '
        Me.GridControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl8.Location = New System.Drawing.Point(2, 2)
        Me.GridControl8.MainView = Me.GridView12
        Me.GridControl8.MenuManager = Me.BarManager1
        Me.GridControl8.Name = "GridControl8"
        Me.GridControl8.Size = New System.Drawing.Size(1303, 322)
        Me.GridControl8.TabIndex = 0
        Me.GridControl8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView12})
        '
        'GridView12
        '
        Me.GridView12.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView12.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView12.Appearance.Empty.Options.UseBackColor = True
        Me.GridView12.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView12.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView12.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView12.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView12.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView12.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView12.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView12.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView12.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView12.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.GridControl = Me.GridControl8
        Me.GridView12.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsBehavior.Editable = False
        Me.GridView12.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView12.OptionsCustomization.AllowFilter = False
        Me.GridView12.OptionsCustomization.AllowGroup = False
        Me.GridView12.OptionsView.ShowFooter = True
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Aciklama"
        Me.GridColumn1.FieldName = "sAciklama"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 134
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Adres1"
        Me.GridColumn2.FieldName = "sAdres1"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 255
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Adres2"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 285
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Semt"
        Me.GridColumn4.FieldName = "sSemt"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 92
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Il"
        Me.GridColumn5.FieldName = "sIl"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 63
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ulke"
        Me.GridColumn6.FieldName = "sUlke"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 63
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "sPostaKodu"
        Me.GridColumn7.FieldName = "PostaKodu"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 89
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "VergiDairesi"
        Me.GridColumn8.FieldName = "sVergiDairesi"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 82
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "VergiNo"
        Me.GridColumn9.FieldName = "sVergiNo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 103
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "SubeMagaza"
        Me.GridColumn10.FieldName = "sSubeMagaza"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 104
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.SimpleButton8)
        Me.PanelControl6.Controls.Add(Me.SimpleButton5)
        Me.PanelControl6.Controls.Add(Me.SimpleButton6)
        Me.PanelControl6.Controls.Add(Me.SimpleButton7)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl6.Location = New System.Drawing.Point(0, 326)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1307, 50)
        Me.PanelControl6.TabIndex = 0
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Image = CType(resources.GetObject("SimpleButton8.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(128, 9)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(120, 32)
        Me.SimpleButton8.TabIndex = 6
        Me.SimpleButton8.Text = "&Düzelt"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(368, 9)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(120, 32)
        Me.SimpleButton5.TabIndex = 5
        Me.SimpleButton5.Text = "&Yazdir"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(248, 9)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(120, 32)
        Me.SimpleButton6.TabIndex = 4
        Me.SimpleButton6.Text = "&Sil"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(8, 9)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(120, 32)
        Me.SimpleButton7.TabIndex = 3
        Me.SimpleButton7.Text = "&Ekle"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GridControl4)
        Me.XtraTabPage5.Image = CType(resources.GetObject("XtraTabPage5.Image"), System.Drawing.Image)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage5.Text = "Aylýk Toplamlar"
        Me.XtraTabPage5.Tooltip = "Hesap Kartýnýn Yýl ve Aylar Ýtibariyle Bakiye Analizi Buradan Takip Edilir. Liste" &
    "lemek için F5 Tuþuna Basýnýz."
        '
        'GridControl4
        '
        Me.GridControl4.ContextMenu = Me.kisayol_aylik
        Me.GridControl4.DataMember = "Table1"
        Me.GridControl4.DataSource = Me.ds_tbFirmaAyYekunleri
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView5
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(1307, 376)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView4})
        '
        'kisayol_aylik
        '
        Me.kisayol_aylik.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem9, Me.MenuItem8})
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem7.Text = "Göster"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'ds_tbFirmaAyYekunleri
        '
        Me.ds_tbFirmaAyYekunleri.DataSetName = "NewDataSet"
        Me.ds_tbFirmaAyYekunleri.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaAyYekunleri.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "nAy"
        Me.DataColumn31.DataType = GetType(Long)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "nYil"
        Me.DataColumn32.DataType = GetType(Long)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nSayi"
        Me.DataColumn33.DataType = GetType(Long)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "lBorc"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "lAlacak"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "lBakiye"
        Me.DataColumn36.DataType = GetType(Decimal)
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
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnAy, Me.colnYil, Me.colnSayi, Me.collBorc, Me.collAlacak, Me.collBakiye, Me.collNetBakiye})
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.GridControl4
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.IndicatorWidth = 12
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colnAy
        '
        Me.colnAy.Caption = "Ay"
        Me.colnAy.FieldName = "sAy"
        Me.colnAy.Name = "colnAy"
        Me.colnAy.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAy", "{0} Kayýt")})
        Me.colnAy.Visible = True
        Me.colnAy.VisibleIndex = 1
        '
        'colnYil
        '
        Me.colnYil.Caption = "Yil"
        Me.colnYil.FieldName = "nYil"
        Me.colnYil.Name = "colnYil"
        Me.colnYil.Visible = True
        Me.colnYil.VisibleIndex = 0
        '
        'colnSayi
        '
        Me.colnSayi.Caption = "Kayýt"
        Me.colnSayi.FieldName = "nSayi"
        Me.colnSayi.Name = "colnSayi"
        Me.colnSayi.Visible = True
        Me.colnSayi.VisibleIndex = 2
        '
        'collBorc
        '
        Me.collBorc.Caption = "Borç"
        Me.collBorc.DisplayFormat.FormatString = "#,0.00"
        Me.collBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorc.FieldName = "lBorc"
        Me.collBorc.Name = "collBorc"
        Me.collBorc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorc", "{0:#,0.00}")})
        Me.collBorc.Visible = True
        Me.collBorc.VisibleIndex = 3
        '
        'collAlacak
        '
        Me.collAlacak.Caption = "Alacak"
        Me.collAlacak.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacak.FieldName = "lAlacak"
        Me.collAlacak.Name = "collAlacak"
        Me.collAlacak.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacak", "{0:#,0.00}")})
        Me.collAlacak.Visible = True
        Me.collAlacak.VisibleIndex = 4
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Aylýk Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBakiye", "{0:#,#0.00(B);#,#0.00(A);-}")})
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 5
        '
        'collNetBakiye
        '
        Me.collNetBakiye.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collNetBakiye.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.collNetBakiye.AppearanceCell.Options.UseFont = True
        Me.collNetBakiye.AppearanceCell.Options.UseForeColor = True
        Me.collNetBakiye.Caption = "Bakiye"
        Me.collNetBakiye.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.collNetBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetBakiye.FieldName = "lNetBakiye"
        Me.collNetBakiye.Name = "collNetBakiye"
        Me.collNetBakiye.Visible = True
        Me.collNetBakiye.VisibleIndex = 6
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.GridControl5)
        Me.XtraTabPage6.Image = Global.business_smart.My.Resources.Resources.signpost
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.PageVisible = False
        Me.XtraTabPage6.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage6.Text = "Modüller"
        '
        'GridControl5
        '
        Me.GridControl5.ContextMenu = Me.kisayol_moduller
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(0, 0)
        Me.GridControl5.MainView = Me.GridView6
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(1307, 376)
        Me.GridControl5.TabIndex = 0
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'kisayol_moduller
        '
        Me.kisayol_moduller.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem16, Me.MenuItem17})
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem10.Text = "Ekle"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem11.Text = "Düzelt"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem12.Text = "Sil"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Text = "Deðer Yay"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem19, Me.MenuItem20})
        Me.MenuItem17.Text = "Raporla"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Text = "Önizle"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Text = "Dizayn"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Text = "Yazdýr"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsModul, Me.colsPaket, Me.colsModulAciklama, Me.coldteTarih, Me.colsVersion})
        Me.GridView6.DetailHeight = 160
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.GridControl = Me.GridControl5
        Me.GridView6.GroupFormat = "{0}: {1} {2}"
        Me.GridView6.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView6.IndicatorWidth = 12
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsCustomization.AllowSort = False
        Me.GridView6.OptionsDetail.ShowDetailTabs = False
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'colsModul
        '
        Me.colsModul.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colsModul.AppearanceCell.Options.UseBackColor = True
        Me.colsModul.Caption = "Modul"
        Me.colsModul.FieldName = "sModul"
        Me.colsModul.Name = "colsModul"
        Me.colsModul.OptionsColumn.AllowFocus = False
        Me.colsModul.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sModul", "{0} Modul")})
        Me.colsModul.Visible = True
        Me.colsModul.VisibleIndex = 0
        Me.colsModul.Width = 221
        '
        'colsPaket
        '
        Me.colsPaket.Caption = "Paket"
        Me.colsPaket.FieldName = "sPaket"
        Me.colsPaket.Name = "colsPaket"
        Me.colsPaket.Visible = True
        Me.colsPaket.VisibleIndex = 2
        Me.colsPaket.Width = 254
        '
        'colsModulAciklama
        '
        Me.colsModulAciklama.Caption = "Açýklama"
        Me.colsModulAciklama.FieldName = "sAciklama"
        Me.colsModulAciklama.Name = "colsModulAciklama"
        Me.colsModulAciklama.Visible = True
        Me.colsModulAciklama.VisibleIndex = 3
        Me.colsModulAciklama.Width = 254
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Visible = True
        Me.coldteTarih.VisibleIndex = 4
        Me.coldteTarih.Width = 255
        '
        'colsVersion
        '
        Me.colsVersion.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsVersion.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsVersion.AppearanceCell.Options.UseBackColor = True
        Me.colsVersion.AppearanceCell.Options.UseFont = True
        Me.colsVersion.AppearanceCell.Options.UseTextOptions = True
        Me.colsVersion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsVersion.Caption = "Version"
        Me.colsVersion.FieldName = "sVersion"
        Me.colsVersion.Name = "colsVersion"
        Me.colsVersion.Visible = True
        Me.colsVersion.VisibleIndex = 1
        Me.colsVersion.Width = 121
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.GroupLisans)
        Me.XtraTabPage7.Controls.Add(Me.GridControl6)
        Me.XtraTabPage7.Image = Global.business_smart.My.Resources.Resources.nav_right_blue
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.PageVisible = False
        Me.XtraTabPage7.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage7.Text = "Lisanslar"
        '
        'GroupLisans
        '
        Me.GroupLisans.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupLisans.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupLisans.Controls.Add(Me.SimpleButton10)
        Me.GroupLisans.Controls.Add(Me.LabelControl40)
        Me.GroupLisans.Controls.Add(Me.txt_nBayiID)
        Me.GroupLisans.Controls.Add(Me.LabelControl39)
        Me.GroupLisans.Controls.Add(Me.txt_sSifreyiAlan)
        Me.GroupLisans.Controls.Add(Me.LabelControl33)
        Me.GroupLisans.Controls.Add(Me.txt_dteGecerlilikTarihi)
        Me.GroupLisans.Controls.Add(Me.SimpleButton3)
        Me.GroupLisans.Controls.Add(Me.SimpleButton4)
        Me.GroupLisans.Controls.Add(Me.LabelControl30)
        Me.GroupLisans.Controls.Add(Me.LabelControl31)
        Me.GroupLisans.Controls.Add(Me.txt_sHddSerial)
        Me.GroupLisans.Controls.Add(Me.txt_sBiosVersion)
        Me.GroupLisans.Controls.Add(Me.LabelControl29)
        Me.GroupLisans.Controls.Add(Me.LabelControl28)
        Me.GroupLisans.Controls.Add(Me.LabelControl27)
        Me.GroupLisans.Controls.Add(Me.LabelControl26)
        Me.GroupLisans.Controls.Add(Me.txt_sCpuID)
        Me.GroupLisans.Controls.Add(Me.txt_sSystemType)
        Me.GroupLisans.Controls.Add(Me.txt_sModel)
        Me.GroupLisans.Controls.Add(Me.txt_sManufactor)
        Me.GroupLisans.Controls.Add(Me.LabelControl22)
        Me.GroupLisans.Controls.Add(Me.txt_sParametre2)
        Me.GroupLisans.Controls.Add(Me.LabelControl21)
        Me.GroupLisans.Controls.Add(Me.txt_sParametre1)
        Me.GroupLisans.Controls.Add(Me.LabelControl8)
        Me.GroupLisans.Controls.Add(Me.txt_sOnayKodu)
        Me.GroupLisans.Location = New System.Drawing.Point(5, 40)
        Me.GroupLisans.LookAndFeel.SkinName = "Black"
        Me.GroupLisans.Name = "GroupLisans"
        Me.GroupLisans.Size = New System.Drawing.Size(779, 290)
        Me.GroupLisans.TabIndex = 1
        Me.GroupLisans.Text = "Lisans"
        Me.GroupLisans.Visible = False
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Location = New System.Drawing.Point(43, 249)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(165, 34)
        Me.SimpleButton10.TabIndex = 26
        Me.SimpleButton10.Text = "Mobile Temizle"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(21, 213)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(52, 19)
        Me.LabelControl40.TabIndex = 25
        Me.LabelControl40.Text = "BayiID:"
        '
        'txt_nBayiID
        '
        Me.txt_nBayiID.EnterMoveNextControl = True
        Me.txt_nBayiID.Location = New System.Drawing.Point(118, 213)
        Me.txt_nBayiID.Name = "txt_nBayiID"
        Me.txt_nBayiID.Size = New System.Drawing.Size(247, 26)
        Me.txt_nBayiID.TabIndex = 9
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(370, 213)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl39.TabIndex = 23
        Me.LabelControl39.Text = "SifreyiAlan:"
        '
        'txt_sSifreyiAlan
        '
        Me.txt_sSifreyiAlan.EnterMoveNextControl = True
        Me.txt_sSifreyiAlan.Location = New System.Drawing.Point(467, 213)
        Me.txt_sSifreyiAlan.Name = "txt_sSifreyiAlan"
        Me.txt_sSifreyiAlan.Size = New System.Drawing.Size(247, 26)
        Me.txt_sSifreyiAlan.TabIndex = 10
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(378, 46)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl33.TabIndex = 21
        Me.LabelControl33.Text = "Bitiþ Tarihi:"
        '
        'txt_dteGecerlilikTarihi
        '
        Me.txt_dteGecerlilikTarihi.EditValue = Nothing
        Me.txt_dteGecerlilikTarihi.EnterMoveNextControl = True
        Me.txt_dteGecerlilikTarihi.Location = New System.Drawing.Point(466, 41)
        Me.txt_dteGecerlilikTarihi.Name = "txt_dteGecerlilikTarihi"
        Me.txt_dteGecerlilikTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteGecerlilikTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteGecerlilikTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteGecerlilikTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteGecerlilikTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteGecerlilikTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteGecerlilikTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteGecerlilikTarihi.Size = New System.Drawing.Size(248, 26)
        Me.txt_dteGecerlilikTarihi.TabIndex = 20
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(466, 249)
        Me.SimpleButton3.LookAndFeel.SkinName = "Black"
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(248, 34)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "&Vazgeç"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(218, 249)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(238, 34)
        Me.SimpleButton4.TabIndex = 9
        Me.SimpleButton4.Text = "&Kaydet"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(378, 184)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl30.TabIndex = 18
        Me.LabelControl30.Text = "HddSerial:"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(18, 184)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(88, 19)
        Me.LabelControl31.TabIndex = 17
        Me.LabelControl31.Text = "BiosVersion:"
        '
        'txt_sHddSerial
        '
        Me.txt_sHddSerial.EnterMoveNextControl = True
        Me.txt_sHddSerial.Location = New System.Drawing.Point(467, 184)
        Me.txt_sHddSerial.Name = "txt_sHddSerial"
        Me.txt_sHddSerial.Size = New System.Drawing.Size(247, 26)
        Me.txt_sHddSerial.TabIndex = 8
        '
        'txt_sBiosVersion
        '
        Me.txt_sBiosVersion.EnterMoveNextControl = True
        Me.txt_sBiosVersion.Location = New System.Drawing.Point(118, 184)
        Me.txt_sBiosVersion.Name = "txt_sBiosVersion"
        Me.txt_sBiosVersion.Size = New System.Drawing.Size(247, 26)
        Me.txt_sBiosVersion.TabIndex = 7
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(400, 156)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl29.TabIndex = 14
        Me.LabelControl29.Text = "CpuID:"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(18, 156)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(92, 19)
        Me.LabelControl28.TabIndex = 13
        Me.LabelControl28.Text = "SystemType:"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(403, 127)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(48, 19)
        Me.LabelControl27.TabIndex = 12
        Me.LabelControl27.Text = "Model:"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(22, 127)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(84, 19)
        Me.LabelControl26.TabIndex = 11
        Me.LabelControl26.Text = "Manufactor:"
        '
        'txt_sCpuID
        '
        Me.txt_sCpuID.EnterMoveNextControl = True
        Me.txt_sCpuID.Location = New System.Drawing.Point(467, 156)
        Me.txt_sCpuID.Name = "txt_sCpuID"
        Me.txt_sCpuID.Size = New System.Drawing.Size(247, 26)
        Me.txt_sCpuID.TabIndex = 6
        '
        'txt_sSystemType
        '
        Me.txt_sSystemType.EnterMoveNextControl = True
        Me.txt_sSystemType.Location = New System.Drawing.Point(118, 156)
        Me.txt_sSystemType.Name = "txt_sSystemType"
        Me.txt_sSystemType.Size = New System.Drawing.Size(247, 26)
        Me.txt_sSystemType.TabIndex = 5
        '
        'txt_sModel
        '
        Me.txt_sModel.EnterMoveNextControl = True
        Me.txt_sModel.Location = New System.Drawing.Point(467, 127)
        Me.txt_sModel.Name = "txt_sModel"
        Me.txt_sModel.Size = New System.Drawing.Size(247, 26)
        Me.txt_sModel.TabIndex = 4
        '
        'txt_sManufactor
        '
        Me.txt_sManufactor.EnterMoveNextControl = True
        Me.txt_sManufactor.Location = New System.Drawing.Point(118, 127)
        Me.txt_sManufactor.Name = "txt_sManufactor"
        Me.txt_sManufactor.Size = New System.Drawing.Size(247, 26)
        Me.txt_sManufactor.TabIndex = 3
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(22, 99)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl22.TabIndex = 6
        Me.LabelControl22.Text = "Parametre2:"
        '
        'txt_sParametre2
        '
        Me.txt_sParametre2.EnterMoveNextControl = True
        Me.txt_sParametre2.Location = New System.Drawing.Point(118, 99)
        Me.txt_sParametre2.Name = "txt_sParametre2"
        Me.txt_sParametre2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sParametre2.Size = New System.Drawing.Size(596, 26)
        Me.txt_sParametre2.TabIndex = 2
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(22, 70)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl21.TabIndex = 4
        Me.LabelControl21.Text = "Parametre1:"
        '
        'txt_sParametre1
        '
        Me.txt_sParametre1.EnterMoveNextControl = True
        Me.txt_sParametre1.Location = New System.Drawing.Point(118, 70)
        Me.txt_sParametre1.Name = "txt_sParametre1"
        Me.txt_sParametre1.Size = New System.Drawing.Size(596, 26)
        Me.txt_sParametre1.TabIndex = 1
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(22, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl8.TabIndex = 1
        Me.LabelControl8.Text = "OnayKodu:"
        '
        'txt_sOnayKodu
        '
        Me.txt_sOnayKodu.Enabled = False
        Me.txt_sOnayKodu.EnterMoveNextControl = True
        Me.txt_sOnayKodu.Location = New System.Drawing.Point(118, 41)
        Me.txt_sOnayKodu.Name = "txt_sOnayKodu"
        Me.txt_sOnayKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sOnayKodu.Size = New System.Drawing.Size(247, 26)
        Me.txt_sOnayKodu.TabIndex = 0
        '
        'GridControl6
        '
        Me.GridControl6.ContextMenu = Me.kisayol_lisanslar
        Me.GridControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl6.Location = New System.Drawing.Point(0, 0)
        Me.GridControl6.MainView = Me.GridView7
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.Size = New System.Drawing.Size(1307, 376)
        Me.GridControl6.TabIndex = 0
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'kisayol_lisanslar
        '
        Me.kisayol_lisanslar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15})
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem13.Text = "Ekle"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem14.Text = "Düzelt"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem15.Text = "Sil"
        '
        'GridView7
        '
        Me.GridView7.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView7.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView7.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView7.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsOnayKodu, Me.colsParametre1, Me.colsParametre2, Me.colsManufactor, Me.colsModel, Me.colsSystemType, Me.colsCpuID, Me.colsBiosVersion, Me.colsHddSerial, Me.coldteGecerlilikTarihi, Me.sSifreyiAlan, Me.colsBilgisayar, Me.colsOturum, Me.colsOS, Me.colsVer, Me.colsIP})
        Me.GridView7.DetailHeight = 160
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.GridControl = Me.GridControl6
        Me.GridView7.GroupFormat = "{0}: {1} {2}"
        Me.GridView7.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView7.IndicatorWidth = 12
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsCustomization.AllowGroup = False
        Me.GridView7.OptionsDetail.ShowDetailTabs = False
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'colsOnayKodu
        '
        Me.colsOnayKodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colsOnayKodu.AppearanceCell.Options.UseBackColor = True
        Me.colsOnayKodu.Caption = "Onay Kodu"
        Me.colsOnayKodu.FieldName = "sOnayKodu"
        Me.colsOnayKodu.Name = "colsOnayKodu"
        Me.colsOnayKodu.OptionsColumn.AllowFocus = False
        Me.colsOnayKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOnayKodu", "{0} Lisans")})
        Me.colsOnayKodu.Visible = True
        Me.colsOnayKodu.VisibleIndex = 0
        Me.colsOnayKodu.Width = 89
        '
        'colsParametre1
        '
        Me.colsParametre1.Caption = "Parametre1"
        Me.colsParametre1.FieldName = "sParametre1"
        Me.colsParametre1.Name = "colsParametre1"
        Me.colsParametre1.Visible = True
        Me.colsParametre1.VisibleIndex = 1
        Me.colsParametre1.Width = 133
        '
        'colsParametre2
        '
        Me.colsParametre2.Caption = "Parametre2"
        Me.colsParametre2.FieldName = "sParametre2"
        Me.colsParametre2.Name = "colsParametre2"
        Me.colsParametre2.Visible = True
        Me.colsParametre2.VisibleIndex = 2
        Me.colsParametre2.Width = 140
        '
        'colsManufactor
        '
        Me.colsManufactor.Caption = "Manufactor"
        Me.colsManufactor.FieldName = "sManufactor"
        Me.colsManufactor.Name = "colsManufactor"
        Me.colsManufactor.Visible = True
        Me.colsManufactor.VisibleIndex = 3
        Me.colsManufactor.Width = 86
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        Me.colsModel.Visible = True
        Me.colsModel.VisibleIndex = 4
        Me.colsModel.Width = 69
        '
        'colsSystemType
        '
        Me.colsSystemType.Caption = "SystemType"
        Me.colsSystemType.FieldName = "sSystemType"
        Me.colsSystemType.Name = "colsSystemType"
        Me.colsSystemType.Visible = True
        Me.colsSystemType.VisibleIndex = 5
        Me.colsSystemType.Width = 69
        '
        'colsCpuID
        '
        Me.colsCpuID.Caption = "CpuID"
        Me.colsCpuID.FieldName = "sCpuID"
        Me.colsCpuID.Name = "colsCpuID"
        Me.colsCpuID.Width = 69
        '
        'colsBiosVersion
        '
        Me.colsBiosVersion.Caption = "BiosVersion"
        Me.colsBiosVersion.FieldName = "sBiosVersion"
        Me.colsBiosVersion.Name = "colsBiosVersion"
        Me.colsBiosVersion.Visible = True
        Me.colsBiosVersion.VisibleIndex = 6
        Me.colsBiosVersion.Width = 69
        '
        'colsHddSerial
        '
        Me.colsHddSerial.Caption = "HddSerial"
        Me.colsHddSerial.FieldName = "sHddSerial"
        Me.colsHddSerial.Name = "colsHddSerial"
        Me.colsHddSerial.Visible = True
        Me.colsHddSerial.VisibleIndex = 7
        Me.colsHddSerial.Width = 80
        '
        'coldteGecerlilikTarihi
        '
        Me.coldteGecerlilikTarihi.Caption = "GecerlilikTarihi"
        Me.coldteGecerlilikTarihi.FieldName = "dteGecerlilikTarihi"
        Me.coldteGecerlilikTarihi.Name = "coldteGecerlilikTarihi"
        Me.coldteGecerlilikTarihi.Visible = True
        Me.coldteGecerlilikTarihi.VisibleIndex = 14
        '
        'sSifreyiAlan
        '
        Me.sSifreyiAlan.Caption = "SifreyiAlan"
        Me.sSifreyiAlan.FieldName = "sSifreyiAlan"
        Me.sSifreyiAlan.Name = "sSifreyiAlan"
        Me.sSifreyiAlan.Visible = True
        Me.sSifreyiAlan.VisibleIndex = 13
        '
        'colsBilgisayar
        '
        Me.colsBilgisayar.Caption = "Bilgisayar"
        Me.colsBilgisayar.FieldName = "sBilgisayar"
        Me.colsBilgisayar.Name = "colsBilgisayar"
        Me.colsBilgisayar.Visible = True
        Me.colsBilgisayar.VisibleIndex = 8
        '
        'colsOturum
        '
        Me.colsOturum.Caption = "Oturum"
        Me.colsOturum.FieldName = "sOturum"
        Me.colsOturum.Name = "colsOturum"
        Me.colsOturum.Visible = True
        Me.colsOturum.VisibleIndex = 9
        '
        'colsOS
        '
        Me.colsOS.Caption = "OS"
        Me.colsOS.FieldName = "sOS"
        Me.colsOS.Name = "colsOS"
        Me.colsOS.Visible = True
        Me.colsOS.VisibleIndex = 10
        '
        'colsVer
        '
        Me.colsVer.Caption = "Versiyon"
        Me.colsVer.FieldName = "sVer"
        Me.colsVer.Name = "colsVer"
        Me.colsVer.Visible = True
        Me.colsVer.VisibleIndex = 11
        '
        'colsIP
        '
        Me.colsIP.Caption = "IP"
        Me.colsIP.FieldName = "sIP"
        Me.colsIP.Name = "colsIP"
        Me.colsIP.Visible = True
        Me.colsIP.VisibleIndex = 12
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.GridControl7)
        Me.XtraTabPage8.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage8.Image = Global.business_smart.My.Resources.Resources.replace2
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1307, 376)
        Me.XtraTabPage8.Text = "Dökümanlar"
        '
        'GridControl7
        '
        Me.GridControl7.DataMember = "Table1"
        Me.GridControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl7.Location = New System.Drawing.Point(0, 0)
        Me.GridControl7.MainView = Me.GridView8
        Me.GridControl7.MenuManager = Me.BarManager1
        Me.GridControl7.Name = "GridControl7"
        Me.GridControl7.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_pResim})
        Me.GridControl7.Size = New System.Drawing.Size(1307, 316)
        Me.GridControl7.TabIndex = 3
        Me.GridControl7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnFirmaResimID, Me.colsnFirmaID, Me.colpResim, Me.colsAciklama2, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colnSira})
        Me.GridView8.GridControl = Me.GridControl7
        Me.GridView8.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView8.IndicatorWidth = 35
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView8.OptionsCustomization.AllowFilter = False
        Me.GridView8.OptionsCustomization.AllowGroup = False
        Me.GridView8.OptionsView.ShowFooter = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        Me.GridView8.RowHeight = 135
        '
        'colnFirmaResimID
        '
        Me.colnFirmaResimID.Caption = "FirmaResimID"
        Me.colnFirmaResimID.FieldName = "nFirmaResimID"
        Me.colnFirmaResimID.Name = "colnFirmaResimID"
        Me.colnFirmaResimID.OptionsColumn.AllowEdit = False
        Me.colnFirmaResimID.OptionsColumn.AllowFocus = False
        '
        'colsnFirmaID
        '
        Me.colsnFirmaID.Caption = "FirmaID"
        Me.colsnFirmaID.FieldName = "nFirmaID"
        Me.colsnFirmaID.Name = "colsnFirmaID"
        Me.colsnFirmaID.OptionsColumn.AllowEdit = False
        Me.colsnFirmaID.OptionsColumn.AllowFocus = False
        '
        'colpResim
        '
        Me.colpResim.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colpResim.AppearanceCell.Options.UseBackColor = True
        Me.colpResim.Caption = "Resim"
        Me.colpResim.ColumnEdit = Me.sec_pResim
        Me.colpResim.FieldName = "pResim"
        Me.colpResim.Name = "colpResim"
        Me.colpResim.OptionsColumn.AllowEdit = False
        Me.colpResim.OptionsColumn.AllowFocus = False
        Me.colpResim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "pResim", "{0} Kayýt")})
        Me.colpResim.Visible = True
        Me.colpResim.VisibleIndex = 0
        Me.colpResim.Width = 368
        '
        'sec_pResim
        '
        Me.sec_pResim.Name = "sec_pResim"
        Me.sec_pResim.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'colsAciklama2
        '
        Me.colsAciklama2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsAciklama2.AppearanceCell.Options.UseBackColor = True
        Me.colsAciklama2.Caption = "Açýklama"
        Me.colsAciklama2.FieldName = "sAciklama"
        Me.colsAciklama2.Name = "colsAciklama2"
        Me.colsAciklama2.Visible = True
        Me.colsAciklama2.VisibleIndex = 2
        Me.colsAciklama2.Width = 387
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kaydeden"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        Me.colsKullaniciAdi.OptionsColumn.AllowFocus = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "KayitTarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        Me.coldteKayitTarihi.OptionsColumn.AllowFocus = False
        '
        'colnSira
        '
        Me.colnSira.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colnSira.AppearanceCell.Options.UseBackColor = True
        Me.colnSira.Caption = "Sira"
        Me.colnSira.FieldName = "nSira"
        Me.colnSira.Name = "colnSira"
        Me.colnSira.Visible = True
        Me.colnSira.VisibleIndex = 1
        Me.colnSira.Width = 33
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.SimpleButton13)
        Me.PanelControl5.Controls.Add(Me.SimpleButton9)
        Me.PanelControl5.Controls.Add(Me.SimpleButton12)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(0, 316)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1307, 60)
        Me.PanelControl5.TabIndex = 2
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton13.Image = CType(resources.GetObject("SimpleButton13.Image"), System.Drawing.Image)
        Me.SimpleButton13.Location = New System.Drawing.Point(262, 9)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton13.TabIndex = 16
        Me.SimpleButton13.Text = "&Yazdýr"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton9.Image = CType(resources.GetObject("SimpleButton9.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(142, 9)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton9.TabIndex = 15
        Me.SimpleButton9.Text = "&Sil"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton12.Image = CType(resources.GetObject("SimpleButton12.Image"), System.Drawing.Image)
        Me.SimpleButton12.Location = New System.Drawing.Point(22, 9)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton12.TabIndex = 14
        Me.SimpleButton12.Text = "&Ekle"
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.Black
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.Controls.Add(Me.LabelControl18)
        Me.PanelControl4.Controls.Add(Me.LabelControl17)
        Me.PanelControl4.Controls.Add(Me.LabelControl10)
        Me.PanelControl4.Controls.Add(Me.TextEdit3)
        Me.PanelControl4.Controls.Add(Me.TextEdit2)
        Me.PanelControl4.Controls.Add(Me.TextEdit1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 414)
        Me.PanelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1313, 57)
        Me.PanelControl4.TabIndex = 0
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl18.Location = New System.Drawing.Point(931, 6)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(304, 18)
        Me.LabelControl18.TabIndex = 65
        Me.LabelControl18.Text = "Bakiye"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.Location = New System.Drawing.Point(627, 6)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(304, 18)
        Me.LabelControl17.TabIndex = 64
        Me.LabelControl17.Text = "Alacak"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(323, 6)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(304, 18)
        Me.LabelControl10.TabIndex = 63
        Me.LabelControl10.Text = "Borç"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lBakiye", True))
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(928, 24)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.EditFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.TextEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.MaxLength = 60
        Me.TextEdit3.Properties.NullText = "0.00"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit3.Size = New System.Drawing.Size(309, 26)
        Me.TextEdit3.TabIndex = 62
        '
        'ds_tbFirmaBakiyesi
        '
        Me.ds_tbFirmaBakiyesi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaBakiyesi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaBakiyesi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "nFirmaID"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "lBorc"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "lAlacak"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "lBakiye"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lAlacak", True))
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(624, 24)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.EditFormat.FormatString = "#,0.00##"
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.MaxLength = 60
        Me.TextEdit2.Properties.NullText = "0.00"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit2.Size = New System.Drawing.Size(304, 26)
        Me.TextEdit2.TabIndex = 61
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lBorc", True))
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(320, 24)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatString = "#,0.00##"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.MaxLength = 60
        Me.TextEdit1.Properties.NullText = "0.00"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit1.Size = New System.Drawing.Size(304, 26)
        Me.TextEdit1.TabIndex = 60
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl4
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Aylýk Hesap Ýcmali", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Account Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'ds_tbFirmaResim
        '
        Me.ds_tbFirmaResim.DataSetName = "NewDataSet"
        Me.ds_tbFirmaResim.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaResim.Tables.AddRange(New System.Data.DataTable() {Me.DataTable9})
        '
        'DataTable9
        '
        Me.DataTable9.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78})
        Me.DataTable9.TableName = "Table1"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "nFirmaResimID"
        Me.DataColumn72.DataType = GetType(Long)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "nFirmaID"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "pResim"
        Me.DataColumn74.DataType = GetType(Byte())
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "sAciklama"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "sKullaniciAdi"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "dteKayitTarihi"
        Me.DataColumn77.DataType = GetType(Date)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "nSira"
        Me.DataColumn78.DataType = GetType(Long)
        '
        'frm_firma_kart
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1317, 652)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_firma_kart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hesap Kartý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txt_sAyrac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.kisayol_ana.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.efatura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bSipariseKapali.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bTahsilatYapilamaz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bSatisYapilamaz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sUlke.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSaticiRumuzu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nOzelIskontosu4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nOzelIskontosu3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nOzelIskontosu2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteMutabakatTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteMutabakatTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lKrediLimiti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sOzelNot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nVadeGun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nOzelIskontosu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sMuhasebeKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sPostaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdres2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdres1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nPeriyod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaSinifi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Sinif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_siniflar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.pnl_yetkililer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_yetkililer.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaYetkilisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sUnvan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHitap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_yetkili_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_yetkili_status.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.pnl_iletisim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_iletisim.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaIletisimi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_IletisimAraci, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_iletisim_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_iletisim_status.ResumeLayout(False)
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaAyYekunleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage7.ResumeLayout(False)
        CType(Me.GroupLisans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupLisans.ResumeLayout(False)
        Me.GroupLisans.PerformLayout()
        CType(Me.txt_nBayiID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSifreyiAlan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteGecerlilikTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteGecerlilikTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sHddSerial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sBiosVersion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sCpuID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSystemType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sManufactor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sParametre2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sParametre1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sOnayKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaBakiyesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nFirmaID
    Dim nHesapID
    Public sKodu As String = "0"
    Public sMuhasebeKodu As String = ""
    Public kullanici
    Public sModul As String = "Cari"
    Public sAltHesap As String = ""
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Dim ds_tbUnvan As DataSet
    Dim ds_tbHitap As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim ds_tbIl As DataSet
    Dim ds_tbUlke As DataSet
    Dim ds_tbSaticiRumuzu As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbFirmaModulu As DataSet
    Dim ds_tbFirmaLisans As DataSet
    Dim ds_tbFirmaAdresi As DataSet
    Public yeni As Boolean = False
    Dim sSinifKodu1 As String = ""
    Dim sSinifKodu2 As String = ""
    Dim sSinifKodu3 As String = ""
    Dim sSinifKodu4 As String = ""
    Dim sSinifKodu5 As String = ""
    Private Sub frm_firma_kart_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If yeni = True Then
            If sModul = "Banka" Then
                txt_sKodu.Text = "102"
                lbl_VergiDairesi.Text = Sorgu_sDil("Þube:", sDil)
                lbl_VergiNo.Text = Sorgu_sDil("HesapNo:", sDil)
                lbl_Iskonto.Text = Sorgu_sDil("Kesinti:", sDil)
            End If
            If sKodu <> "" Then
                txt_sKodu.Text = txt_sKodu.Text
            End If
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        End If

    End Sub
    Private Sub frm_firma_kart_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dr As DataRow
        Dim sUyari As String = ""
        sUyari = sUyariKontrol()
        dr = ds_tbFirma.Tables(0).Rows(0)
        If sUyari = "" Then
            Dispose()
        Else

            XtraMessageBox.Show(sUyari, Sorgu_sDil("Dikkat", sDil))
            e.Cancel = True
        End If
    End Sub
    Private Sub frm_firma_kart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            gorunum_yukle()
        Catch ex As Exception
        End Try
        If yetki_kontrol(kullanici, "frm_firma_kartý_limiti") = True Then
            Dim conn As New OleDb.OleDbConnection(sConnection)
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select * from aPersonelYetki  where  PersonelNo='" + kullanici + "' and Form='frm_firma_kartý_limiti'", conn)
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = cmd.ExecuteReader()
            While dr1.Read()
                If Convert.ToBoolean((dr1.Item("Yetki"))) = False Then

                    txt_lKrediLimiti.Enabled = False

                Else
                    txt_lKrediLimiti.Enabled = True


                End If

            End While
            conn.Close()
        End If
        If yetki_kontrol(kullanici, "frm_Firma_HesapTuru_Duzenleme", False) = True Then
            ComboBoxEdit1.Enabled = True
        Else
            ComboBoxEdit1.Enabled = False
        End If
        dataload_tbUnvan()
        dataload_tbHitap()
        dataload_tbDepo()
        dataload_tbFiyatTipi()
        dataload_tbSaticiRumuzu()
        dataload_tbDovizCinsi()
        dataload_tbIl()
        dataload_tbUlke()
        dataload_tbFSinif(1)
        dataload_tbIletisimAraci()
        If nFirmaID = 0 Then
            If yeni = False Then
                'firma_sec()
            ElseIf yeni = True Then
                txt_sMagaza.Text = sDepo
                dataload(nFirmaID)
                SimpleButton1.Text = "&Kaydet"
                XtraTabPage2.PageEnabled = False
                XtraTabPage3.PageEnabled = False
                XtraTabPage4.PageEnabled = False
                XtraTabPage5.PageEnabled = False
                XtraTabPage9.PageEnabled = False
                txt_sKodu.Enabled = True
                sec_bAktif.Checked = True
            End If
        Else
            txt_musteriNo.EditValue = sKodu
            dataload(nFirmaID)
            RiskGostergesiniGuncelle()
        End If
        txt_sHitap1.Focus()
        txt_sHitap1.SelectAll()
        'dataload_tbMSinif(1)
        If yeni = True Then
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        Else
            XtraTabControl1.SelectedTabPageIndex = 0
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        End If
        If sModul = "Lisanslama" Then
            XtraTabPage6.PageVisible = True
            XtraTabPage7.PageVisible = True
        End If
        If sModul = "Lisanslama" And kullaniciadi <> "Admin" Then
            Me.MenuItem13.Visible = False
            Me.MenuItem10.Visible = False
            Me.MenuItem11.Visible = False
            txt_sAdi.Enabled = False

        End If
    End Sub
    Private Sub gorunum_yukle()
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView4.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView5.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView6.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView7.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        Label1.Text = Sorgu_sDil(Label1.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        LabelControl6.Text = Sorgu_sDil(LabelControl6.Text, sDil)
        LabelControl7.Text = Sorgu_sDil(LabelControl7.Text, sDil)
        LabelControl8.Text = Sorgu_sDil(LabelControl8.Text, sDil)
        LabelControl9.Text = Sorgu_sDil(LabelControl9.Text, sDil)
        LabelControl10.Text = Sorgu_sDil(LabelControl10.Text, sDil)
        lbl_VergiDairesi.Text = Sorgu_sDil(lbl_VergiDairesi.Text, sDil)
        lbl_VergiNo.Text = Sorgu_sDil(lbl_VergiNo.Text, sDil)
        LabelControl13.Text = Sorgu_sDil(LabelControl13.Text, sDil)
        lbl_Iskonto.Text = Sorgu_sDil(lbl_Iskonto.Text, sDil)
        LabelControl15.Text = Sorgu_sDil(LabelControl15.Text, sDil)
        LabelControl16.Text = Sorgu_sDil(LabelControl16.Text, sDil)
        LabelControl17.Text = Sorgu_sDil(LabelControl17.Text, sDil)
        LabelControl18.Text = Sorgu_sDil(LabelControl18.Text, sDil)
        LabelControl19.Text = Sorgu_sDil(LabelControl19.Text, sDil)
        LabelControl20.Text = Sorgu_sDil(LabelControl20.Text, sDil)
        LabelControl21.Text = Sorgu_sDil(LabelControl21.Text, sDil)
        LabelControl22.Text = Sorgu_sDil(LabelControl22.Text, sDil)
        LabelControl23.Text = Sorgu_sDil(LabelControl23.Text, sDil)
        LabelControl24.Text = Sorgu_sDil(LabelControl24.Text, sDil)
        LabelControl25.Text = Sorgu_sDil(LabelControl25.Text, sDil)
        LabelControl26.Text = Sorgu_sDil(LabelControl26.Text, sDil)
        LabelControl27.Text = Sorgu_sDil(LabelControl27.Text, sDil)
        LabelControl28.Text = Sorgu_sDil(LabelControl28.Text, sDil)
        LabelControl29.Text = Sorgu_sDil(LabelControl29.Text, sDil)
        LabelControl30.Text = Sorgu_sDil(LabelControl30.Text, sDil)
        LabelControl31.Text = Sorgu_sDil(LabelControl31.Text, sDil)
        LabelControl32.Text = Sorgu_sDil(LabelControl32.Text, sDil)
        lbl_HesapKodu.Text = Sorgu_sDil(lbl_HesapKodu.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    End Sub
    Private Sub dataload_tbUnvan()
        ds_tbUnvan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbUnvan"))
        sec_sUnvan.DataSource = ds_tbUnvan.Tables(0)
    End Sub
    Private Sub dataload_tbHitap()
        ds_tbHitap = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHitap"))
        txt_sHitap1.Properties.DataSource = ds_tbHitap.Tables(0)
        sec_sHitap1.DataSource = ds_tbHitap.Tables(0)
    End Sub
    Private Sub dataload_tbDepo()
        txt_sMagaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo ")).Tables(0)
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi, sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        txt_sFiyatTipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
    End Sub
    Private Sub dataload_tbSaticiRumuzu()
        ds_tbSaticiRumuzu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi, sSoyadi FROM         tbSatici Where (bAktif = 1) ORDER BY sSaticiRumuzu"))
        txt_sSaticiRumuzu.Properties.DataSource = ds_tbSaticiRumuzu.Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi, sAciklama FROM         tbDovizCinsi ORDER BY sDovizCinsi"))
        txt_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl order by sIl"))
        txt_sIl.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbUlke()
        ds_tbUlke = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sUlke FROM         tbUlke Order by sUlke"))
        txt_sUlke.Properties.DataSource = ds_tbUlke.Tables(0)
    End Sub
    Private Sub dataload_tbFSinif(Optional ByVal sSinifNo As Integer = 1)
        sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFSinif" & sSinifNo & "")).Tables(0)
        sec_Sinif.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFSinif" & sSinifNo & "")).Tables(0)
        If yeni = True Then
            sec_sSinifKodu1.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFSinif1 Order by sSinifKodu")).Tables(0)
            sec_sSinifKodu2.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFSinif2 Order by sSinifKodu")).Tables(0)
            sec_sSinifKodu3.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFSinif3 Order by sSinifKodu")).Tables(0)
            sec_sSinifKodu4.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFSinif4 Order by sSinifKodu")).Tables(0)
            sec_sSinifKodu1.EditValue = ""
            sec_sSinifKodu2.EditValue = ""
            sec_sSinifKodu3.EditValue = ""
            sec_sSinifKodu4.EditValue = ""
            btn_KodBul.Enabled = True
        End If
    End Sub
    Private Sub dataload_tbIletisimAraci()
        sec_IletisimAraci.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbIletisimAraci")).Tables(0)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
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
    Public Function sorgu_sGuid(ByVal nGuidHane As Integer) As String
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     REPLACE(RIGHT(NEWID(), " & nGuidHane & "), '-', '') AS sGuiD")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
    End Function
    Public Function sorgu_sKodu_kontrol(ByVal kod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKodu), 0) AS nKayit FROM         tbFirma WHERE     (sKodu = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function Dataload_tbFirmaResim(ByVal nFirmaID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM           tbFirmaResim WHERE nFirmaID ='" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub firma_sec()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            yeni = False
            SimpleButton1.Text = "&Tamam"
            XtraTabPage2.PageEnabled = True
            XtraTabPage3.PageEnabled = True
            XtraTabPage4.PageEnabled = True
            XtraTabPage5.PageEnabled = True
            XtraTabPage9.PageEnabled = True
            txt_sKodu.Enabled = False
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            txt_musteriNo.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nFirmaID = dr("nFirmaID")
                    dataload(nFirmaID)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
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
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nFirmaId,sKodu,sAciklama FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal nFirmaID As String)
        Dataload_tbFirma(nFirmaID)
        Dataload_tbFirmaBakiyesi(nFirmaID, sorgu_string(txt_sDovizCinsi.EditValue, ""))
        'Müþteri Sýnýflandýrma Kontrol
        If sorgu_tbFirmaTablo_kontrol(nFirmaID, "tbFirmaSinifi") = 0 Then
            tbFirmaSinifi_kaydet_yeni(nFirmaID, "", "", "", "", "")
        End If
        Dataload_tbFirmaSinifi(nFirmaID)
        'Firma Açýklamasý Kontrol
        If sorgu_tbFirmaTablo_kontrol(nFirmaID, "tbFirmaAciklamasi") = 0 Then
            tbFirmaAciklamasi_kaydet_yeni(nFirmaID, "", "", "", "", "", "", "", "", "", "")
        End If
        Dataload_tbFirmaAciklamasi(nFirmaID)
        ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nFirmaID)
        GridControl2.DataSource = ds_tbFirmaYetkilisi.Tables(0)
        GridControl2.DataMember = Nothing
        ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nFirmaID)
        GridControl3.DataSource = ds_tbFirmaIletisimi.Tables(0)
        GridControl3.DataMember = Nothing
        ds_tbFirmaAdresi = Dataload_tbFirmaAdresi(nFirmaID)
        GridControl8.DataSource = ds_tbFirmaAdresi.Tables(0)
        GridControl8.DataMember = Nothing
        'ds_tbFirmaAyYekunleri = Dataload_tbFirmaAyYekunleri(nFirmaID)
        'GridControl4.DataSource = ds_tbFirmaAyYekunleri.Tables(0)
        'GridControl4.DataMember = Nothing
        ds_tbFirmaResim = Dataload_tbFirmaResim(nFirmaID)
        GridControl7.DataSource = ds_tbFirmaResim.Tables(0)
        GridControl7.DataMember = Nothing
        If sModul = "Lisanslama" Then
            ds_tbFirmaModulu = Dataload_tbFirmaModulu(nFirmaID)
            GridControl5.DataMember = Nothing
            GridControl5.DataSource = ds_tbFirmaModulu.Tables(0)
            ds_tbFirmaLisans = Dataload_tbFirmaLisans(nFirmaID)
            GridControl6.DataMember = Nothing
            GridControl6.DataSource = ds_tbFirmaLisans.Tables(0)
        End If
        Dim dr As DataRow
        dr = ds_tbFirma.Tables(0).Rows(0)
        Try
            If Len(dr("nZiyaret")) = 7 Then
                CheckEdit1.Checked = dr("nZiyaret").ToString.Substring(0, 1)
                CheckEdit2.Checked = dr("nZiyaret").ToString.Substring(1, 1)
                CheckEdit3.Checked = dr("nZiyaret").ToString.Substring(2, 1)
                CheckEdit4.Checked = dr("nZiyaret").ToString.Substring(3, 1)
                CheckEdit5.Checked = dr("nZiyaret").ToString.Substring(4, 1)
                CheckEdit6.Checked = dr("nZiyaret").ToString.Substring(5, 1)
                CheckEdit7.Checked = dr("nZiyaret").ToString.Substring(6, 1)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Dataload_tbFirma(ByVal nFirmaID As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbFirma.*, tbHesapPlani.sKodu AS sMuhasebeKodu FROM         tbFirma INNER JOIN                       tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID WHERE tbFirma.nFirmaID ='" & nFirmaID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbFirmaBakiyesi(ByVal nFirmaID As String, ByVal sDovizCinsi As String)
        Try
            ds_tbFirmaBakiyesi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If Trim(sDovizCinsi) <> "" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, ISNULL(SUM(lBorcTutar/lDovizKuru1), 0) AS lBorc, ISNULL(SUM(lAlacakTutar/lDovizKuru1), 0) AS lAlacak, ISNULL(SUM((lBorcTutar - lAlacakTutar)/lDovizKuru1), 0) AS lBakiye FROM tbFirmaHareketi WHERE (nFirmaID = '" & nFirmaID & "') and (sDovizCinsi1 ='" & sDovizCinsi & "') GROUP BY nFirmaID")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, ISNULL(SUM(lBorcTutar), 0) AS lBorc, ISNULL(SUM(lAlacakTutar), 0) AS lAlacak, ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE (nFirmaID = '" & nFirmaID & "') GROUP BY nFirmaID")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirmaBakiyesi, "Table1")
        conn.Close()
    End Sub
    Private Sub Dataload_tbFirmaSinifi(ByVal nMusteriID As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT 1 AS sSinifNo, tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi01 FROM tbParamCari) AS sSinifTipi, tbFSinif1.sSinifKodu, tbFSinif1.sAciklama FROM tbFirmaSinifi INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = '" & nFirmaID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 2 AS sSinifNo, tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi02 FROM tbParamCari) AS sSinifTipi, tbFSinif2.sSinifKodu, tbFSinif2.sAciklama FROM tbFirmaSinifi INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = '" & nFirmaID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 3 AS sSinifNo, tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi03 FROM tbParamCari) AS sSinifTipi, tbFSinif3.sSinifKodu, tbFSinif3.sAciklama FROM tbFirmaSinifi INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = '" & nFirmaID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 4 AS sSinifNo, tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi04 FROM tbParamCari) AS sSinifTipi, tbFSinif4.sSinifKodu, tbFSinif4.sAciklama FROM tbFirmaSinifi INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = '" & nFirmaID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 5 AS sSinifNo, tbFirmaSinifi.nFirmaID, (SELECT sSinifTipi05 FROM tbParamCari) AS sSinifTipi, tbFSinif5.sSinifKodu, tbFSinif5.sAciklama FROM tbFirmaSinifi INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu WHERE (tbFirmaSinifi.nFirmaID = '" & nFirmaID & "')"
        ds_tbFirmaSinifi = sorgu(sorgu_query("" & kriter & ""))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbFirmaSinifi.Tables(0)
    End Sub
    Public Function Dataload_tbFirmaAciklamasi(ByVal nFirmaID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaAciklamasi WHERE nFirmaID ='" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaYetkilisi(ByVal nFirmaID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaYetkilisi WHERE nFirmaID ='" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaModulu(ByVal nFirmaID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaModulu WHERE nFirmaID ='" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaLisans(ByVal nFirmaID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaLisans WHERE nFirmaID ='" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaIletisimi(ByVal nFirmaID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaIletisimi WHERE nFirmaID ='" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaAdresi(ByVal nFirmaID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaAdresi WHERE nFirmaID ='" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaAyYekunleri(ByVal nFirmaID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DATENAME([month], dteIslemTarihi) AS sAy, YEAR(dteIslemTarihi) AS nYil, COUNT(dteIslemTarihi) AS nSayi, SUM(lBorcTutar) AS lBorc, SUM(lAlacakTutar) AS lAlacak, SUM(lBorcTutar) - SUM(lAlacakTutar) AS lBakiye, CAST(0 AS MONEY) AS lNetBakiye FROM tbFirmaHareketi WHERE (nFirmaID = '" & nFirmaID & "') GROUP BY DATENAME([month], dteIslemTarihi), MONTH(dteIslemTarihi),YEAR(dteIslemTarihi) ORDER BY YEAR(dteIslemTarihi), MONTH(dteIslemTarihi) ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim bakiye As Decimal = 0
        For Each dr In Datastoklar1.Tables(0).Rows
            bakiye = bakiye + (dr("lBorc") - dr("lAlacak"))
            dr("lNetBakiye") = bakiye
        Next
        Return Datastoklar1
    End Function
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
    Private Function tbFirma_kaydet_yeni(ByVal nFirmaID As String, ByVal sKodu As String, ByVal sAciklama As String, ByVal TC As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String, ByVal sSaticiRumuzu As String, ByVal nOzelIskontosu2 As Decimal, ByVal nOzelIskontosu3 As Decimal, ByVal nOzelIskontosu4 As Decimal, ByVal bAktif As Integer, ByVal bSatisYapilamaz As Byte, ByVal bSipariseKapali As Byte, ByVal bTahsilatYapilamaz As Byte, ByVal sDovizCinsi As String, ByVal nEnlem As Decimal, ByVal nBoylam As Decimal, ByVal nZiyaret As String, ByVal nPeriyod As Int64, ByVal sDepo As String, ByVal sCariHesapTuru As String, ByVal sEfatura As Boolean) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If efatura.Checked = True Then
            sEfatura = True
        Else
            sEfatura = False
        End If
        bAktif = 1
        If Trim(TC) = "" Then
            TC = "00000000000"
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirma (sKodu, sAciklama, TC, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi,sSaticiRumuzu,nOzelIskontosu2,nOzelIskontosu3,nOzelIskontosu4,bAktif,bSatisYapilamaz,bSipariseKapali, bTahsilatYapilamaz,sDovizCinsi,nEnlem,nBoylam,nZiyaret,nPeriyod,sDepo, sCariHesapTuru, sEfatura) VALUES ('" & sKodu & "', N'" & sAciklama & "', " & TC & ", " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & ", N'" & sHitap & "', N'" & sAdres1 & "', N'" & sAdres2 & "', N'" & sSemt & "', N'" & sIl & "', N'" & sUlke & "', N'" & sPostaKodu & "', N'" & sVergiDairesi & "', N'" & sVergiNo & "', " & nHesapID & ", N'" & sOzelNot & "', '" & sKullaniciAdi & "','" & dteKayitTarihi & "', N'" & sFiyatTipi & "',N'" & sSaticiRumuzu & "'," & nOzelIskontosu2 & "," & nOzelIskontosu3 & "," & nOzelIskontosu4 & "," & bAktif & "," & bSatisYapilamaz & ", " & bSipariseKapali & ", " & bTahsilatYapilamaz & ",N'" & sDovizCinsi & "'," & nEnlem & "," & nBoylam & "," & nZiyaret & "," & nPeriyod & ",N'" & sDepo & "', '" & sCariHesapTuru & "','" & sEfatura & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Function tbHesapPlani_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '" & sKodu & "' ")
        Dim kayitno As String = cmd.ExecuteScalar
        If kayitno = "0" Or kayitno = "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sAlterneAciklama & "', " & lBilancoSatiri & ", '" & sAktifPasif & "', " & lKarZararSatiri & ", '" & sKarZararGelirGider & "', '" & sMasrafYontemi & "', " & bMiktarVar & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
            kayitno = cmd.ExecuteScalar
        End If
        con.Close()
        Return kayitno
    End Function
    Private Sub tbFirma_kaydet_duzelt(ByVal nFirmaID As String, ByVal sKodu As String, ByVal sAciklama As String, ByVal TC As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String, ByVal sSaticiRumuzu As String, ByVal nOzelIskontosu2 As Decimal, ByVal nOzelIskontosu3 As Decimal, ByVal nOzelIskontosu4 As Decimal, ByVal bAktif As Integer, ByVal bSatisYapilamaz As Byte, ByVal bSipariseKapali As Byte, ByVal bTahsilatYapilamaz As Byte, ByVal sDovizCinsi As String, ByVal nEnlem As Decimal, ByVal nBoylam As Decimal, ByVal nZiyaret As String, ByVal nPeriyod As Integer, ByVal sDepo As String, ByVal sCariHesapTuru As String, ByVal sEfatura As Boolean)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If Trim(TC) = "" Then
            TC = "00000000000"
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbFirma SET sAciklama = N'" & sAciklama & "', TC = " & TC & ", nOzelIskontosu = " & nOzelIskontosu & ",nOzelIskontosu2 = " & nOzelIskontosu2 & ", nOzelIskontosu3 = " & nOzelIskontosu3 & ",nOzelIskontosu4 = " & nOzelIskontosu4 & ",sSaticiRumuzu = '" & sSaticiRumuzu & "' ,lKrediLimiti = " & lKrediLimiti & ", dteMutabakatTarihi = '" & dteMutabakatTarihi & "', nVadeGun = " & nVadeGun & ", sHitap = N'" & sHitap & "', sAdres1 = N'" & sAdres1 & "', sAdres2 = N'" & sAdres2 & "', sSemt = N'" & sSemt & "', sIl = N'" & sIl & "', sUlke = N'" & sUlke & "', sPostaKodu = N'" & sPostaKodu & "', sVergiDairesi = N'" & sVergiDairesi & "', sVergiNo = N'" & sVergiNo & "',  sOzelNot = N'" & sOzelNot & "', sFiyatTipi = '" & sFiyatTipi & "',bAktif = " & bAktif & ",bSatisYapilamaz=" & bSatisYapilamaz & ", bSipariseKapali = " & bSipariseKapali & ", bTahsilatYapilamaz=" & bTahsilatYapilamaz & ",sDovizCinsi ='" & sDovizCinsi & "',nEnlem = " & nEnlem & ",nBoylam = " & nBoylam & ",nZiyaret  = '" & nZiyaret & "',nPeriyod = " & nPeriyod & ",sDepo = N'" & sDepo & "', sCariHesapTuru = '" & sCariHesapTuru & "', sEfatura = '" & sEfatura & "'  Where nFirmaID = '" & nFirmaID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbFirmaSinifi_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     (" & nFirmaID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaSinifi_kaydet_duzelt(ByVal nFirmaID As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaSinifi SET              sSinifKodu" & sSinifNo & " = '" & sSinifKodu & "' where nFirmaID = '" & nFirmaID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaAciklamasi_kaydet_yeni(ByVal nFirmaID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sAciklama6 As String, ByVal sAciklama7 As String, ByVal sAciklama8 As String, ByVal sAciklama9 As String, ByVal sAciklama10 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaAciklamasi (nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sAciklama6, sAciklama7, sAciklama8, sAciklama9, sAciklama10) VALUES     ('" & nFirmaID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sAciklama6 & "', '" & sAciklama7 & "', '" & sAciklama8 & "', '" & sAciklama9 & "', '" & sAciklama10 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaYetkilisi_kaydet_yeni(ByVal nFirmaID As String, ByVal sUnvan As String, ByVal sHitap As String, ByVal sAdiSoyadi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaYetkilisi (nFirmaID, sUnvan, sHitap, sAdiSoyadi) VALUES     ('" & nFirmaID & "', '" & sUnvan & "', '" & sHitap & "', '" & sAdiSoyadi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaYetkilisi_kaydet_duzelt(ByVal nYetkiliID As String, ByVal nFirmaID As String, ByVal sUnvan As String, ByVal sHitap As String, ByVal sAdiSoyadi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaYetkilisi SET              sUnvan = '" & sUnvan & "', sHitap = '" & sHitap & "', sAdiSoyadi = '" & sAdiSoyadi & "' Where nYetkiliID = '" & nYetkiliID & "' and nFirmaID ='" & nFirmaID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaYetkilisi_Satir_sil()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            satir = GridView2.FocusedRowHandle
            If XtraMessageBox.Show(dr("sAdiSoyadi") & vbTab & Sorgu_sDil(" Ýsimli Yetkili Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaYetkilisi_kaydet_sil(dr("nYetkiliID"), dr("nFirmaID"))
            End If
            ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nFirmaID)
            GridControl2.DataSource = ds_tbFirmaYetkilisi.Tables(0)
            GridControl2.DataMember = Nothing
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaYetkilisi_kaydet_sil(ByVal nYetkiliID As String, ByVal nFirmaID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirmaYetkilisi  Where nYetkiliID = '" & nYetkiliID & "' and nFirmaID ='" & nFirmaID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaIletisimi_kaydet_yeni(ByVal nFirmaID As String, ByVal sIletisimAraci As String, ByVal sIletisimAdresi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES     ('" & nFirmaID & "', '" & sIletisimAraci & "', '" & sIletisimAdresi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaIletisimi_kaydet_duzelt(ByVal nIletisimID As String, ByVal nFirmaID As String, ByVal sIletisimAraci As String, ByVal sIletisimAdresi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaIletisimi SET              sIletisimAraci = '" & sIletisimAraci & "', sIletisimAdresi = '" & sIletisimAdresi & "' Where nIletisimID = '" & nIletisimID & "' and nFirmaID = '" & nFirmaID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaAdresi_kaydet_yeni(ByVal nAdresID As Int64, ByVal nFirmaID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String, ByVal sTelefon1 As String, ByVal sTelefon2 As String, ByVal sTelefon3 As String, ByVal sFaks As String, ByVal sMail As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaAdresi (nFirmaID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza,sTelefon1,sTelefon2,sTelefon3,sFaks,sMail) VALUES     (" & nFirmaID & ", N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "','" & sTelefon1 & "','" & sTelefon2 & "','" & sTelefon3 & "','" & sFaks & "','" & sMail & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaModulu_kaydet_yeni(ByVal nFirmaID As String, ByVal sModul As String, ByVal sPaket As String, ByVal sVersion As String, ByVal sAciklama As String, ByVal dteTarih As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaModulu                       (nFirmaID, sModul, sPaket, sVersion,sAciklama, dteTarih) VALUES     (" & nFirmaID & ", '" & sModul & "', '" & sPaket & "', '" & sVersion & "','" & sAciklama & "', '" & dteTarih & "' )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaModulu_kaydet_duzelt(ByVal nFirmaID As String, ByVal sModul As String, ByVal sPaket As String, ByVal sVersion As String, ByVal sAciklama As String, ByVal dteTarih As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaModulu SET              sPaket = '" & sPaket & "', sVersion ='" & sVersion & "',sAciklama = N'" & sAciklama & "', dteTarih = '" & dteTarih & "' where nFirmaID = " & nFirmaID & " and  sModul = '" & sModul & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaModulu_kaydet_sil(ByVal nFirmaID As String, ByVal sModul As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirmaModulu where nFirmaID = " & nFirmaID & " and  sModul = '" & sModul & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaLisans_kaydet_yeni(ByVal nFirmaID As String, ByVal sOnayKodu As String, ByVal sParametre1 As String, ByVal sParametre2 As String, ByVal sManufactor As String, ByVal sModel As String, ByVal sSystemType As String, ByVal sCpuID As String, ByVal sBiosVersion As String, ByVal sHddSerial As String, ByVal sMacID As String, ByVal sBilgisayar As String, ByVal sOturum As String, ByVal sOS As String, ByVal sVer As String, ByVal sIP As String, ByVal sUlke As String, ByVal sBolge As String, ByVal sSifreyiAlan As String, ByVal dteGecerlilikTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaLisans (nFirmaID, sOnayKodu, sParametre1, sParametre2, sManufactor, sModel, sSystemType, sCpuID, sBiosVersion, sHddSerial, sMacID, sBilgisayar, sOturum, sOs, sVer, sIP, sUlke, sBolge, sSifreyiAlan, dteGecerlilikTarihi, MobileDeviceID) VALUES (" & nFirmaID & ", '" & sOnayKodu & "', '" & sParametre1 & "', '" & sParametre2 & "', '" & sManufactor & "', '" & sModel & "', '" & sSystemType & "', '" & sCpuID & "', '" & sBiosVersion & "', '" & sHddSerial & "', '" & sMacID & "', '" & sBilgisayar & "', '" & sOturum & "', '" & sOS & "', '" & sVer & "', '" & sIP & "', '" & sUlke & "', '" & sBolge & "', '" & sSifreyiAlan & "', '" & dteGecerlilikTarihi & "', '')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaLisans_kaydet_Duzelt(ByVal nFirmaID As String, ByVal sOnayKodu As String, ByVal sParametre1 As String, ByVal sParametre2 As String, ByVal sManufactor As String, ByVal sModel As String, ByVal sSystemType As String, ByVal sCpuID As String, ByVal sBiosVersion As String, ByVal sHddSerial As String, ByVal dteGecerlilikTarihi As DateTime, ByVal nBayiID As Int64, ByVal sSifreyiAlan As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaLisans SET              sParametre1 = '" & sParametre1 & "', sParametre2 = '" & sParametre2 & "', sManufactor = '" & sManufactor & "',  sModel = '" & sModel & "', sSystemType = '" & sSystemType & "', sCpuID = '" & sCpuID & "', sBiosVersion = '" & sBiosVersion & "', sHddSerial = '" & sHddSerial & "',dteGecerlilikTarihi = '" & dteGecerlilikTarihi & "',nBayiID = " & nBayiID & ",sSifreyiAlan = '" & sSifreyiAlan & "' Where nFirmaID = " & nFirmaID & " and sOnayKodu = '" & sOnayKodu & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaLisans_kaydet_Sil(ByVal nFirmaID As String, ByVal sOnayKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirmaLisans  Where nFirmaID = " & nFirmaID & " and sOnayKodu = '" & sOnayKodu & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaIletisimi_Satir_sil()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            satir = GridView3.FocusedRowHandle
            If XtraMessageBox.Show(dr("sIletisimAdresi") & vbTab & Sorgu_sDil(" Ýletiþim Adres Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaIletisimi_kaydet_sil(dr("nIletisimID"), dr("nFirmaID"))
            End If
            ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nFirmaID)
            GridControl3.DataSource = ds_tbFirmaIletisimi.Tables(0)
            GridControl3.DataMember = Nothing
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaAdresi_Satir_sil()
        If GridView12.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView12.GetDataRow(GridView12.FocusedRowHandle)
            satir = GridView12.FocusedRowHandle
            If XtraMessageBox.Show(dr("sAciklama") & vbTab & Sorgu_sDil(" Adres Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaAdresi_kaydet_sil(dr("nAdresID"), dr("nFirmaID"))
            End If
            ds_tbFirmaAdresi = Dataload_tbFirmaAdresi(nFirmaID)
            GridControl8.DataSource = ds_tbFirmaAdresi.Tables(0)
            GridControl8.DataMember = Nothing
            GridView12.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaModulu_Satir_sil()
        If GridView6.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            satir = GridView6.FocusedRowHandle
            If XtraMessageBox.Show(dr("sModul") & vbTab & Sorgu_sDil(" Modul Paket Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaModulu_kaydet_sil(dr("nFirmaID"), dr("sModul"))
            End If
            ds_tbFirmaModulu = Dataload_tbFirmaModulu(nFirmaID)
            GridControl5.DataSource = ds_tbFirmaModulu.Tables(0)
            GridControl5.DataMember = Nothing
            GridView6.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaLisans_Satir_sil()
        If GridView7.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView7.GetDataRow(GridView7.FocusedRowHandle)
            satir = GridView7.FocusedRowHandle
            If XtraMessageBox.Show(dr("sOnayKodu") & vbTab & Sorgu_sDil(" Onaylý Lisans Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaLisans_kaydet_Sil(dr("nFirmaID"), dr("sOnayKodu"))
            End If
            ds_tbFirmaLisans = Dataload_tbFirmaLisans(nFirmaID)
            GridControl6.DataSource = ds_tbFirmaLisans.Tables(0)
            GridControl6.DataMember = Nothing
            GridView7.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaIletisimi_kaydet_sil(ByVal nIletisimID As String, ByVal nFirmaID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirmaIletisimi  Where nIletisimID = '" & nIletisimID & "' and nFirmaID = '" & nFirmaID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaAdresi_kaydet_sil(ByVal nAdresID As String, ByVal nFirmaID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirmaAdresi  Where nAdresID = '" & nAdresID & "' and nFirmaID = '" & nFirmaID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sUyariKontrol() As String
        Dim sUyari As String = ""
        Dim dr As DataRow
        For Each dr In ds_tbFirmaSinifi.Tables(0).Rows
            If dr("sSinifNo") = 1 Then
                sSinifKodu1 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 2 Then
                sSinifKodu2 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 3 Then
                sSinifKodu3 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 4 Then
                sSinifKodu4 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 5 Then
                sSinifKodu5 = Trim(dr("sSinifKodu"))
            End If
        Next
        dr = ds_tbFirma.Tables(0).Rows(0)
        Dim nZiyaret As String = ""
        If CheckEdit1.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit2.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit3.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit4.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit5.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit6.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit7.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If Trim(dr("sOzelNot")) = "" Then
            dr("sOzelNot") = nZiyaret
        End If
        If bCariAciklamaZorunlumu = True And Trim(txt_sAdi.Text) = "" Then
            sUyari += Sorgu_sDil("Açýklama Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sAdi.Focus()
        End If
        If bCariTCZorunlumu = True And Trim(txt_TC.Text) = "" Then
            sUyari += Sorgu_sDil("TC Kimlik NO Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_TC.Focus()
        End If
        If bCariAdres1Zorunlumu = True And Trim(txt_sAdres1.Text) = "" Then
            sUyari += Sorgu_sDil("Adres1 Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sAdres1.Focus()
        End If
        If bCariAdres2Zorunlumu = True And Trim(txt_sAdres2.Text) = "" Then
            sUyari += Sorgu_sDil("Adres2 Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sAdres2.Focus()
        End If
        If bCariSemtZorunlumu = True And Trim(txt_sSemt.Text) = "" Then
            sUyari += Sorgu_sDil("Semt Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sSemt.Focus()
        End If
        If bCariPostaKoduZorunlumu = True And Trim(txt_sPostaKodu.Text) = "" Then
            sUyari += Sorgu_sDil("Postakodu Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sPostaKodu.Focus()
        End If
        If bCariIlZorunlumu = True And Trim(txt_sIl.Text) = "" Then
            sUyari += Sorgu_sDil("Ýl Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sAdi.Focus()
        End If
        If bCariUlkeZorunlumu = True And Trim(txt_sUlke.Text) = "" Then
            sUyari += Sorgu_sDil("Ülke Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sUlke.Focus()
        End If
        If bCariDepoZorunlumu = True And Trim(txt_sMagaza.EditValue) = "" Then
            sUyari += Sorgu_sDil("Depo Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sMagaza.Focus()
        End If
        If bCariSaticiZorunlumu = True And Trim(txt_sSaticiRumuzu.EditValue) = "" Then
            sUyari += Sorgu_sDil("Satýcý Alanýný Boþ Býrakamazsýnýz...!", sDil)
            txt_sSaticiRumuzu.Focus()
        End If
        If bCariVergiDairesiZorunlumu = True And Trim(txt_sVergiDairesi.Text) = "" Then
            sUyari += Sorgu_sDil("VergiDairesi Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sVergiDairesi.Focus()
        End If
        If bCariVergiNoZorunlumu = True And Trim(txt_sVergiNo.Text) = "" Then
            sUyari += Sorgu_sDil("VergiNo Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sVergiNo.Focus()
        End If
        If bCariOzelNotZorunlumu = True And Trim(txt_sOzelNot.Text) = "" Then
            sUyari += Sorgu_sDil("ÖzelNot Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
            txt_sOzelNot.Focus()
        End If
        If yeni = False Then
            If sSinifKodu1 = "" And bCariSinifKodu1Zorunlumu = True Then
                sUyari += Sorgu_sDil("Sýnýf1 Alanýný Boþ Býrakamazsýnýz...!", sDil)
            End If
            If sSinifKodu2 = "" And bCariSinifKodu2Zorunlumu = True Then
                sUyari += Sorgu_sDil("Sýnýf2 Alanýný Boþ Býrakamazsýnýz...!", sDil)
            End If
            If sSinifKodu3 = "" And bCariSinifKodu3Zorunlumu = True Then
                sUyari += Sorgu_sDil("Sýnýf3 Alanýný Boþ Býrakamazsýnýz...!", sDil)
            End If
            If sSinifKodu4 = "" And bCariSinifKodu4Zorunlumu = True Then
                sUyari += Sorgu_sDil("Sýnýf4 Alanýný Boþ Býrakamazsýnýz...!", sDil)
            End If
            If sSinifKodu5 = "" And bCariSinifKodu5Zorunlumu = True Then
                sUyari += Sorgu_sDil("Sýnýf5 Alanýný Boþ Býrakamazsýnýz...!", sDil)
            End If
            If bCariYetkiliZorunlumu = True And GridView2.RowCount = 0 Then
                sUyari += Sorgu_sDil("Yetkili Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
                GridControl2.Focus()
            End If
            If bCariIletisimZorunlumu = True And GridView3.RowCount = 0 Then
                sUyari += Sorgu_sDil("Ýletiþim Alanýný Boþ Býrakamazsýnýz...!", sDil) & vbCrLf
                GridControl3.Focus()
            End If
        End If
        Return sUyari
    End Function
    Private Function nullCevir(ByVal dbn As Object, ByVal tur As Integer) As Object
        If IsDBNull(dbn) Then
            If tur = 1 Then
                dbn = ""
            ElseIf tur = 2 Then
                dbn = 0
            End If
        End If
        Return dbn
    End Function
    Private Sub kaydet_tumu()
        Dim dr As DataRow
        Dim sUyari As String = ""
        sUyari = sUyariKontrol()
        dr = ds_tbFirma.Tables(0).Rows(0)
        If sUyari = "" Then
        Else
            XtraMessageBox.Show(sUyari, Sorgu_sDil("Dikkat", sDil))
            Exit Sub
        End If
        Dim nZiyaret As String = ""
        If CheckEdit1.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit2.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit3.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit4.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit5.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit6.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If CheckEdit7.Checked = True Then
            nZiyaret += "1"
        Else
            nZiyaret += "0"
        End If
        If efatura.Checked = True Then
            dr("sEfatura") = True
        Else
            dr("sEfatura") = False
        End If
        If yeni = False Then
            tbFirma_kaydet_duzelt(nFirmaID, Trim(dr("sKodu")), Trim(dr("sAciklama")), nullCevir(dr("TC"), 2), dr("nOzelIskontosu"), dr("lKrediLimiti"), dr("dteMutabakatTarihi"), dr("nVadeGun"), dr("sHitap"), Trim(dr("sAdres1")), Trim(dr("sAdres2")), Trim(dr("sSemt")), dr("sIl"), dr("sUlke"), Trim(dr("sPostaKodu")), Trim(dr("sVergiDairesi")), Trim(dr("sVergiNo")), dr("nHesapID"), Trim(dr("sOzelNot")), Trim(dr("sKullaniciAdi")), dr("dteKayitTarihi"), dr("sFiyatTipi"), dr("sSaticiRumuzu").ToString, sorgu_sayi(dr("nOzelIskontosu2"), 0), sorgu_sayi(dr("nOzelIskontosu3"), 0), sorgu_sayi(dr("nOzelIskontosu4"), 0), Math.Abs(sorgu_sayi(dr("bAktif"), 0)), Math.Abs(sorgu_sayi(dr("bSatisYapilamaz"), 0)), Math.Abs(sorgu_sayi(dr("bSipariseKapali"), 0)), Math.Abs(sorgu_sayi(dr("bTahsilatYapilamaz"), 0)), dr("sDovizCinsi").ToString, sorgu_sayi(dr("nEnlem"), 0), sorgu_sayi(dr("nBoylam"), 0), nZiyaret, sorgu_sayi(dr("nPeriyod"), 0), dr("sDepo"), dr("sCariHesapTuru"), dr("sEfatura"))
            Me.Close()
        ElseIf yeni = True Then
            nHesapID = tbHesapPlani_kaydet_yeni(txt_sMuhasebeKodu.EditValue, txt_sAdi.EditValue, "", 0, "", 0, "", "", 0, kullanici, Now)
            nFirmaID = tbFirma_kaydet_yeni(nFirmaID, txt_sKodu.EditValue.ToString, dr("sAciklama"), nullCevir(dr("TC"), 2), dr("nOzelIskontosu"), dr("lKrediLimiti"), dr("dteMutabakatTarihi"), dr("nVadeGun"), dr("sHitap"), dr("sAdres1"), dr("sAdres2"), dr("sSemt"), dr("sIl"), dr("sUlke"), dr("sPostaKodu"), dr("sVergiDairesi"), dr("sVergiNo"), nHesapID, dr("sOzelNot"), dr("sKullaniciAdi"), Now, dr("sFiyatTipi"), dr("sSaticiRumuzu").ToString, sorgu_sayi(dr("nOzelIskontosu2"), 0), sorgu_sayi(dr("nOzelIskontosu3"), 0), sorgu_sayi(dr("nOzelIskontosu4"), 0), Math.Abs(sorgu_sayi(dr("bAktif"), 0)), Math.Abs(sorgu_sayi(dr("bSatisYapilamaz"), 0)), Math.Abs(sorgu_sayi(dr("bSipariseKapali"), 0)), Math.Abs(sorgu_sayi(dr("bTahsilatYapilamaz"), 0)), dr("sDovizCinsi").ToString, sorgu_sayi(dr("nEnlem"), 0), sorgu_sayi(dr("nBoylam"), 0), nZiyaret, sorgu_sayi(dr("nPeriyod"), 0), dr("sDepo"), dr("sCariHesapTuru"), dr("sEfatura")).ToString
            tbFirmaSinifi_kaydet_yeni(nFirmaID, "", "", "", "", "")
            tbFirmaAciklamasi_kaydet_yeni(nFirmaID, "", "", "", "", "", "", "", "", "", "")
            sKodu = txt_sKodu.EditValue.ToString
            yeni = False
            SimpleButton1.Text = "&Tamam"
            txt_sKodu.Enabled = False
            XtraTabPage2.PageEnabled = True
            XtraTabPage3.PageEnabled = True
            XtraTabPage4.PageEnabled = True
            XtraTabPage5.PageEnabled = True
            XtraTabPage9.PageEnabled = True
            dataload(nFirmaID)
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
            btn_KodBul.Enabled = False
        End If
    End Sub
    Private Function yeni_cari_kayit_formu_kontrol() As Boolean
        If (txt_sAdi.Text.Trim.Length = 0) Or (txt_sAdres1.Text.Trim.Length = 0) Or (txt_sSemt.Text.Trim.Length = 0) Or (txt_sIl.Text.Trim.Length = 0) Or (txt_sUlke.Text.Trim.Length = 0) Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub tbFirma_Ekle()
        nFirmaID = 0
        nHesapID = 0
        sKodu = 0
        yeni = True
        dataload(nFirmaID)
        SimpleButton1.Text = "&Kaydet"
        XtraTabPage2.PageEnabled = False
        XtraTabPage3.PageEnabled = False
        XtraTabPage4.PageEnabled = False
        XtraTabPage5.PageEnabled = False
        XtraTabPage9.PageEnabled = False
        txt_sKodu.Enabled = True
        txt_musteriNo.EditValue = ""
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
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
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sKodu,'') as sKodu FROM         tbFirma WHERE     (nFirmaID < '" & nFirmaID & "' ) ORDER BY sKodu DESC ")
                sKodu = cmd.ExecuteScalar
                txt_musteriNo.EditValue = sKodu
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                musteri_kontrol()
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
                cmd.ExecuteNonQuery()
            End Try
            con.Close()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub tbFirma_notlari()
        Dim frm As New frm_musteri_karti_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = nFirmaID
        frm.firma = True
        frm.kullanici = kullanici
        'Firma Açýklamasý Kontrol
        If sorgu_tbFirmaTablo_kontrol(nFirmaID, "tbFirmaAciklamasi") = 0 Then
            tbFirmaAciklamasi_kaydet_yeni(nFirmaID, "", "", "", "", "", "", "", "", "", "")
        End If
        frm.ShowDialog()
    End Sub
    Private Sub tbFirmaHareketi()
        Dim frm As New frm_tbFirmaHareketi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.nFirmaID = nFirmaID
        frm.sKodu = sKodu
        frm.txt_musteriNo.EditValue = sKodu
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbSonKod()
        Dim frm As New frm_tbSonKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islem = "tbFirma"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim kod As String = frm.lbl_Kod.Text
            If IsNumeric(Microsoft.VisualBasic.Right(kod, 2)) = True Then
                Dim nSayi = Len(kod)
            End If
            txt_sKodu.EditValue = frm.lbl_Kod.Text
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub tbSinif(ByVal tablo As String)
        Dim fr As New frm_tbSinif
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.kullanici = kullanici
        fr.Table = tablo
        If yetki_kontrol(kullanici, fr.Name) = True Then
            fr.Show()
        End If
    End Sub
    Private Sub analiz_risk()
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
    Private Sub analiz_cari_bakiye()
        If nFirmaID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = sKodu
            frm.txt_musteriNo.EditValue = sKodu
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
    Private Sub analiz_cari_hareket()
        If nFirmaID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = sKodu
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket_detayli()
        If nFirmaID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_detayli
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = sKodu
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/2018"
            frm.DateEdit2.EditValue = "31/12/2078"
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
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_satis_karlilik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/2018"
            frm.DateEdit2.EditValue = dteSistemTarihi
            frm.txt_ara.Text = ""
            frm.txt_ara_stok.Text = ""
            frm.sec_MaliyetTipi.Text = "Stok Kartýndan"
            frm.kriter_musteriID = "AND tbStokFisiDetayi.nFirmaID = " & nFirmaID & " "
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
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            dr.EndEdit()
            tbFirmaSinifi_kaydet_duzelt(nFirmaID, dr("sSinifKodu").ToString, dr("sSinifNo"))
            Dataload_tbFirmaSinifi(nFirmaID)
            GridView1.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Try
                dataload_tbFSinif(dr("sSinifNo"))
            Catch ex As Exception
            End Try
            dr = Nothing
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If sModul = "Banka" Then
            If Microsoft.VisualBasic.Left(txt_sKodu.Text, 3) = "102" Then
                kaydet_tumu()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Hesap Kodlarý [102] ile baþlamalýdýr.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_sKodu.Focus()
                txt_sKodu.Select()
            End If
        Else
            'If yeni_cari_kayit_formu_kontrol() = True Then
            kaydet_tumu()
            'Else
            'MessageBox.Show("Lütfen Zorunlu Alanlarý Doldurunuz!", "Business Smart", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            txt_sHitap1.Focus()
            txt_sHitap1.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            GridControl2.Focus()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            GridControl3.Focus()
            GridControl3.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 4 Then
            ds_tbFirmaAyYekunleri = Dataload_tbFirmaAyYekunleri(nFirmaID)
            GridControl4.DataSource = ds_tbFirmaAyYekunleri.Tables(0)
            GridControl4.DataMember = Nothing
            GridControl4.Focus()
            GridControl4.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 5 Then
            GridControl5.Focus()
            GridControl5.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 6 Then
            GridControl6.Focus()
            GridControl6.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 7 Then
            GridControl7.Focus()
            GridControl7.Select()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

        yetkili_ekle()
    End Sub
    Private Sub yetkili_ekle()
        tbFirmaYetkilisi_kaydet_yeni(nFirmaID, "", "", "")
        ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nFirmaID)
        GridControl2.DataSource = ds_tbFirmaYetkilisi.Tables(0)
        GridControl2.DataMember = Nothing
        GridView2.FocusedRowHandle = GridView2.RowCount - 1
        GridControl2.Focus()
        GridControl2.Select()
        GridView2.FocusedColumn = colsAdiSoyadi
    End Sub
    Private Sub yetkili_sil()
        tbFirmaYetkilisi_Satir_sil()
    End Sub
    Private Sub yetkili_yazdir()
        GridControl2.ShowPrintPreview()
    End Sub
    Private Sub Moduller_Ekle()
        Dim frm As New frm_tbToplam
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.sIslem = "Modul"
        frm.sKodu = nFirmaID
        frm.GridView1.OptionsView.ShowAutoFilterRow = True
        frm.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        frm.GridView1.OptionsFilter.AllowFilterEditor = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbFirmaModulu.Tables(0).NewRow
                    dr("nFirmaID") = nFirmaID
                    dr("sModul") = dr1("sModul")
                    dr("sPaket") = ""
                    dr("sAciklama") = ""
                    dr("sVersion") = ""
                    dr("dteTarih") = Today
                    tbFirmaModulu_kaydet_yeni(dr("nFirmaID"), dr("sModul"), dr("sPaket"), dr("sVersion"), dr("sAciklama"), dr("dteTarih"))
                    ds_tbFirmaModulu.Tables(0).Rows.Add(dr)
                Next
            End If
        End If
        ds_tbFirmaModulu = Dataload_tbFirmaModulu(nFirmaID)
        GridControl5.DataMember = Nothing
        GridControl5.DataSource = ds_tbFirmaModulu.Tables(0)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        yetkili_sil()
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            Dim satir = GridView2.FocusedRowHandle
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            GridView2.PostEditor()
            dr.EndEdit()
            Try
                tbFirmaYetkilisi_kaydet_duzelt(dr("nYetkiliID"), dr("nFirmaID"), dr("sUnvan"), dr("sHitap"), dr("sAdiSoyadi"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Ýçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nFirmaID)
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        iletisim_ekle()
    End Sub
    Private Sub iletisim_ekle()
        tbFirmaIletisimi_kaydet_yeni(nFirmaID, "Telefon", "")
        ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nFirmaID)
        GridControl3.DataSource = ds_tbFirmaIletisimi.Tables(0)
        GridControl3.DataMember = Nothing
        GridView3.FocusedRowHandle = GridView3.RowCount - 1
    End Sub
    Private Sub iletisim_sil()
        tbFirmaIletisimi_Satir_sil()
    End Sub
    Private Sub iletisim_yazdir()
        GridControl3.ShowPrintPreview()
    End Sub
    Private Sub adres_ekle()
        tbFirmaAdresi_kaydet_yeni(0, nFirmaID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        ds_tbFirmaAdresi = Dataload_tbFirmaAdresi(nFirmaID)
        GridControl8.DataSource = ds_tbFirmaAdresi.Tables(0)
        GridControl8.DataMember = Nothing
        GridView12.FocusedRowHandle = GridView12.RowCount - 1
        adres_duzelt()
    End Sub
    Private Sub adres_sil()
        tbFirmaAdresi_Satir_sil()
    End Sub
    Private Sub adres_duzelt()
        If GridView12.RowCount > 0 Then
            Dim dr As DataRow = GridView12.GetDataRow(GridView12.FocusedRowHandle)
            Dim frm As New frm_tbAlisVerisAdres
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.bAdres = True
            frm.nStokFisiID = dr("nAdresID")
            frm.nFirmaID = nFirmaID
            'Firma Açýklamasý Kontrol
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                ds_tbFirmaAdresi = Dataload_tbFirmaAdresi(nFirmaID)
                GridControl8.DataSource = ds_tbFirmaAdresi.Tables(0)
                GridControl8.DataMember = Nothing
            End If
        End If
    End Sub
    Private Sub adres_yazdir()
        GridControl8.ShowPrintPreview()
    End Sub
    Private Sub lisans_ekle()
        'tbFirmaIletisimi_kaydet_yeni(nFirmaID, "Telefon", "")
        Dim dteGecerlilikTarihi As DateTime = DateAdd(DateInterval.Day, 45, Today)
        tbFirmaLisans_kaydet_yeni(nFirmaID, sorgu_sGuid(8), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", dteGecerlilikTarihi)
        ds_tbFirmaLisans = Dataload_tbFirmaLisans(nFirmaID)
        GridControl6.DataSource = ds_tbFirmaLisans.Tables(0)
        GridControl6.DataMember = Nothing
        GridView7.FocusedRowHandle = GridView7.RowCount - 1
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        tbFirmaIletisimi_Satir_sil()
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            Try
                tbFirmaIletisimi_kaydet_duzelt(dr("nIletisimID"), dr("nFirmaID"), dr("sIletisimAraci"), dr("sIletisimAdresi"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Ýçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nFirmaID)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        ds_tbFirmaAyYekunleri = Dataload_tbFirmaAyYekunleri(nFirmaID)
        GridControl4.DataSource = ds_tbFirmaAyYekunleri.Tables(0)
        GridControl4.DataMember = Nothing
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirma_notlari()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirmaHareketi()
    End Sub
    Private Sub AraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AraToolStripMenuItem.Click
        firma_sec()
    End Sub
    Private Sub FirmaHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaHareketleriToolStripMenuItem.Click
        analiz_cari_hareket()
    End Sub
    Private Sub FirmaBakiyeleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaBakiyeleriToolStripMenuItem.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub HareketGirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HareketGirToolStripMenuItem.Click
        tbFirmaHareketi()
    End Sub
    Private Sub AçýklamaGirToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AçýklamaGirToolStripMenuItem.Click
        tbFirma_notlari()
    End Sub
    Private Sub txt_sKodu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sKodu.EditValueChanged
        If yeni = True Then
            txt_sMuhasebeKodu.EditValue = txt_sKodu.EditValue
        End If
    End Sub
    Private Sub txt_sKodu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sKodu.Validating
        If yeni = True Then
            txt_sKodu.EditValue = Trim(txt_sKodu.EditValue)
            If sorgu_sKodu_kontrol(txt_sKodu.EditValue) = False Then
                txt_sKodu.ErrorText = txt_sKodu.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                e.Cancel = True
                txt_sKodu.Focus()
                txt_sKodu.SelectAll()
            End If
        End If
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nFirmaID)
        End If
    End Sub
    Private Sub btn_MuhasebeAc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MuhasebeAc.Click
    End Sub
    Private Sub SonKodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SonKodToolStripMenuItem.Click
        tbSonKod()
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        tbFirma_Ekle()
    End Sub
    Private Sub StokluEkstreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokluEkstreToolStripMenuItem.Click
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub btn_ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirma_Ekle()
    End Sub
    Private Sub btn_sil_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nFirmaID)
        End If
    End Sub
    Private Sub btn_ara_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        firma_sec()
    End Sub
    Private Sub btn_firmahareket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_hareket()
    End Sub
    Private Sub btn_FirmaBakiye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_bakiye()
    End Sub
    Private Sub btn_HareketGir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirmaHareketi()
    End Sub
    Private Sub btn_AciklamaGir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tbFirma_notlari()
    End Sub
    Private Sub btn_SonKod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbSonKod()
    End Sub
    Private Sub btn_StokluEkstre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        firma_sec()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        tbFirma_Ekle()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_cari_bakiye()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        tbFirma_notlari()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nFirmaID)
        End If
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        tbSonKod()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbFirmaHareketi()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        tbSinif("tbFSinif")
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Me.Close()
    End Sub
    Private Sub btn_yetkili_ekle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_yetkili_ekle.Click
        yetkili_ekle()
    End Sub
    Private Sub btn_yetkili_sil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_yetkili_sil.Click
        yetkili_sil()
    End Sub
    Private Sub btn_yetkili_yazdir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_yetkili_yazdir.Click
        yetkili_yazdir()
    End Sub
    Private Sub btn_iletisim_ekle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_iletisim_ekle.Click
        iletisim_ekle()
    End Sub
    Private Sub btn_iletisim_sil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_iletisim_sil.Click
        iletisim_sil()
    End Sub
    Private Sub btn_iletisim_yazdir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_iletisim_yazdir.Click
        iletisim_yazdir()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        analiz_risk()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Moduller_Ekle()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        tbFirmaModulu_Satir_sil()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        If kullaniciadi = "Admin" Then
            lisans_ekle()
        Else
        End If
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        If kullaniciadi = "Admin" Then
            tbFirmaLisans_Satir_sil()
        Else
        End If
    End Sub
    Private Sub GridView6_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView6.CellValueChanged
        modul_duzelt()
    End Sub
    Private Sub modul_duzelt()
        If GridView6.RowCount > 0 Then
            Dim satir = GridView6.FocusedRowHandle
            Dim dr As DataRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            GridView6.PostEditor()
            dr.EndEdit()
            Try
                tbFirmaModulu_kaydet_duzelt(dr("nFirmaID"), dr("sModul"), dr("sPaket"), dr("sVersion"), dr("sAciklama"), dr("dteTarih"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Ýçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbFirmaModulu = Dataload_tbFirmaModulu(nFirmaID)
            GridView6.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub lisans_duzelt()
        If GridView7.RowCount > 0 Then
            Dim satir = GridView7.FocusedRowHandle
            Dim dr As DataRow = GridView7.GetDataRow(GridView7.FocusedRowHandle)
            GridView7.PostEditor()
            dr.EndEdit()
            Try
                dr("sParametre1") = txt_sParametre1.Text
                dr("sParametre2") = txt_sParametre2.Text
                dr("sManufactor") = txt_sManufactor.Text
                dr("sModel") = txt_sModel.Text
                dr("sSystemType") = txt_sSystemType.Text
                dr("sCpuID") = txt_sCpuID.Text
                dr("sBiosVersion") = txt_sBiosVersion.Text
                dr("sHddSerial") = txt_sHddSerial.Text
                dr("dteGecerlilikTarihi") = txt_dteGecerlilikTarihi.EditValue
                dr("nBayiID") = sorgu_sayi(txt_nBayiID.Text, 0)
                dr("sSifreyiAlan") = txt_sSifreyiAlan.Text
                tbFirmaLisans_kaydet_Duzelt(dr("nFirmaID"), dr("sOnayKodu").ToString, dr("sParametre1").ToString, dr("sParametre2").ToString, dr("sManufactor").ToString, dr("sModel").ToString, dr("sSystemType").ToString, dr("sCpuID").ToString, dr("sBiosVersion").ToString, dr("sHddSerial").ToString, txt_dteGecerlilikTarihi.EditValue, dr("nBayiID").ToString, txt_sSifreyiAlan.Text)
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Ýçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbFirmaLisans = Dataload_tbFirmaLisans(nFirmaID)
            GridView7.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
            GroupLisans.Visible = False
        End If
    End Sub
    Private Sub degeryay_modul(ByVal columnkriter As String)
        Dim dr As DataRow
        Dim durum
        Dim sayi = GridView6.RowCount
        Dim satir = GridView6.FocusedRowHandle
        Dim TOPLAM = sayi - GridView6.FocusedRowHandle
        Dim Ý As Integer
        Ý = 0
        dr = GridView6.GetDataRow(GridView6.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            dr = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            dr.BeginEdit()
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            modul_duzelt()
            GridView6.FocusedRowHandle += 1
        Next
        GridView6.FocusedRowHandle = satir
        GridView6.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        If GridView6.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView6.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay_modul(GridView6.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        GroupLisans.Visible = False
        GridControl6.Focus()
        GridControl6.Select()
    End Sub
    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        lisans_duzelt()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        If GridView7.RowCount > 0 Then
            Dim satir = GridView7.FocusedRowHandle
            Dim dr As DataRow = GridView7.GetDataRow(GridView7.FocusedRowHandle)
            txt_sOnayKodu.Text = Trim(dr("sOnayKodu"))
            txt_sParametre1.Text = Trim(dr("sParametre1"))
            txt_sParametre2.Text = Trim(dr("sParametre2"))
            txt_sManufactor.Text = Trim(dr("sManufactor"))
            txt_sModel.Text = Trim(dr("sModel"))
            txt_sSystemType.Text = Trim(dr("sSystemType"))
            txt_sCpuID.Text = Trim(dr("sCpuID"))
            txt_sBiosVersion.Text = Trim(dr("sBiosVersion"))
            txt_sHddSerial.Text = Trim(dr("sHddSerial"))
            txt_dteGecerlilikTarihi.Text = dr("dteGecerlilikTarihi")
            txt_nBayiID.Text = dr("nBayiID")
            txt_sSifreyiAlan.Text = dr("sSifreyiAlan")
            GroupLisans.Visible = True
            txt_sParametre1.Focus()
            txt_sParametre2.SelectAll()
        End If
    End Sub
    Private Sub txt_sParametre2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sParametre2.ButtonClick
        txt_sParametre2.Text = FormatKeyCode(DigestStrToHexStr(txt_sParametre1.Text), 4)
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Lisans*.frx) |Lisans*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Lisans.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            report.RegisterData(ds_tbFirma, "tbFirma")
            report.RegisterData(ds_tbFirmaSinifi, "tbFirmaSinifi")
            report.RegisterData(ds_tbFirmaYetkilisi, "tbFirmaYetkilisi")
            report.RegisterData(ds_tbFirmaIletisimi, "tbFirmaIletisimi")
            report.RegisterData(ds_tbFirmaModulu, "tbFirmaModulu")
            report.RegisterData(ds_tbFirmaLisans, "tbFirmaLisans")
            report.RegisterData(ds_tbParamGenel, "tbParemeGenel")
            'report.SetParameterValue("Kriter", "Barkod Yazýlýmevi)
            report.ScriptLanguage = Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub satir_ekle_siparisten(ByVal ara As String)
        Dim frm As New frm_tbSiparis_bekleyen
        'frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.txt_dteSiparisTarihi1.EditValue = "01/01/1900"
        frm.txt_dteSiparisTarihi2.EditValue = "31/12/2078"
        frm.txt_ara.Text = txt_musteriNo.Text
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.sec_kriter.Enabled = False
        'If dr_baslik("nGirisCikis") = 1 Then
        '    frm.nSiparisTipi = 2
        'ElseIf dr_baslik("nGirisCikis") = 3 Then
        frm.nSiparisTipi = 1
        'End If
        frm.sec_bKapandimi.Checked = False
        frm.sec_bKapandimi.Enabled = False
        frm.sec_sSiparisTipi.Enabled = True
        frm.ShowDialog()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        raporla(0)
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        raporla(1)
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        raporla(2)
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        satir_ekle_siparisten("")
    End Sub
    'Private Sub txt_sVergiNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sVergiNo.Validating
    '    txt_sVergiNo.EditValue = Trim(txt_sVergiNo.Text.ToString)
    '    If Trim(txt_sVergiNo.EditValue) <> "" Then
    '        If sorgu_sVergiNo_kontrol(txt_sVergiNo.Text.ToString, nFirmaID, yeni) = False Then
    '            'txt_sSoyadi.ErrorText = txt_sSoyadi.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
    '            If XtraMessageBox.Show(txt_sVergiNo.Text & Sorgu_sDil("  Vergi No Daha Once Kayit Yapilmis...", sDil) & vbCrLf & Sorgu_sDil("Kayýtlarý Görmek Ýster misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
    '                Dim frm As New frm_firma_liste
    '                frm.firmano = firmano
    '                frm.donemno = donemno
    '                frm.connection = connection
    '                frm.sModul = sModul
    '                frm.txt_ara.Text = txt_sVergiNo.EditValue
    '                frm.sec_konum.Text = "VergiNo"
    '                frm.sec_kriter.Text = "Eþittir"
    '                frm.ShowDialog()
    '                'e.Cancel = True
    '                'txt_sSoyadi.Focus()
    '                'txt_sSoyadi.SelectAll()
    '            End If
    '        End If
    '    End If
    'End Sub
    Public Function sorgu_sVergiNo_kontrol(ByVal sVergiNo As String, ByVal nFirmaID As Int64, ByVal yeni As Boolean) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sVergiNo), 0) AS nKayit FROM         tbFirma WHERE     (sVergiNo = '" & sVergiNo & "') and nFirmaID <> " & nFirmaID & "  ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sAdi_kontrol(ByVal sAdi As String, ByVal nFirmaID As Int64, ByVal yeni As Boolean) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sAciklama), 0) AS nKayit FROM tbFirma WHERE (sAciklama = '" & sAdi & "') and nFirmaID <> " & nFirmaID & "  ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub txt_sAdi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sAdi.Validating
        txt_sAdi.EditValue = Trim(txt_sAdi.Text.ToString)
        If Trim(txt_sAdi.EditValue) <> "" Then
            If sorgu_sAdi_kontrol(txt_sAdi.Text.ToString, nFirmaID, yeni) = False Then
                'txt_sSoyadi.ErrorText = txt_sSoyadi.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                If XtraMessageBox.Show(txt_sAdi.Text & Sorgu_sDil("  Adý Daha Once Kayit Yapilmis...", sDil) & vbCrLf & Sorgu_sDil("Kayýtlarý Görmek Ýster misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                    Dim frm As New frm_firma_liste
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.sModul = sModul
                    frm.txt_ara.Text = txt_sAdi.EditValue
                    frm.sec_konum.Text = "Adý"
                    frm.sec_kriter.Text = "Eþittir"
                    frm.ShowDialog()
                    'e.Cancel = True
                    'txt_sSoyadi.Focus()
                    'txt_sSoyadi.SelectAll()
                End If
            End If
        End If
    End Sub
    Public Function sorgu_TC_kontrol(ByVal TC As String, ByVal nFirmaID As Int64, ByVal yeni As Boolean) As Boolean
        Dim pass As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(TC), 0) AS nKayit FROM tbFirma WHERE (TC = " & TC & ") and nFirmaID <> " & nFirmaID & "  ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    'Private Sub txt_TC_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_TC.Validating
    '    txt_TC.EditValue = Trim(txt_TC.Text.ToString)
    '    If Trim(txt_TC.EditValue) <> "" Then
    '        If txt_TC.Text.Length = 11 Then
    '            If sorgu_TC_kontrol(txt_TC.Text.ToString, nFirmaID, yeni) = False Then
    '                XtraMessageBox.Show(txt_TC.Text & Sorgu_sDil(" TC'si ile Daha Once Kayit Yapilmistýr!", sDil), Sorgu_sDil("Dikkat", sDil))
    '                txt_TC.Text = ""
    '                txt_TC.Focus()
    '            End If
    '        Else
    '            XtraMessageBox.Show("TC kimlik numarasý 11 haneden az olamaz!", "Dikkat")
    '            txt_TC.Text = ""
    '            txt_TC.Focus()
    '        End If
    '    End If
    'End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        Dim dr As DataRow
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fs As New FileStream(OpenFileDialog1.FileName.ToString, FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)
            fs.Close()
            dr = ds_tbFirmaResim.Tables(0).NewRow
            dr("nFirmaID") = nFirmaID
            dr("pResim") = MyData
            dr("sAciklama") = ""
            dr("nSira") = 0
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            ds_tbFirmaResim.Tables(0).Rows.Add(dr)
            'ds_tbMusteriResim.AcceptChanges()
            Dim ds As New DataSet
            ds = ds_tbFirmaResim
            Dim da As New OleDb.OleDbDataAdapter
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            da.InsertCommand = cmd
            cmd.Connection = con
            con.ConnectionString = connection
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaResim                       (nFirmaID,pResim,sAciklama,nSira,sKullaniciAdi,dteKayitTarihi) VALUES     (?,?,?,?,?,?) "
            cmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("nFirmaID", System.Data.OleDb.OleDbType.[Integer], 0, "nFirmaID"), New System.Data.OleDb.OleDbParameter("pResim", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "pResim"), New System.Data.OleDb.OleDbParameter("sAciklama", System.Data.OleDb.OleDbType.[Char], 0, "sAciklama"), New System.Data.OleDb.OleDbParameter("nSira", System.Data.OleDb.OleDbType.[Integer], 0, "nSira"), New System.Data.OleDb.OleDbParameter("sKullaniciAdi", System.Data.OleDb.OleDbType.[Char], 0, "sKullaniciAdi"), New System.Data.OleDb.OleDbParameter("dteKayitTarihi", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "dteKayitTarihi")})
            da.Update(ds_tbFirmaResim.Tables(0))
            da = Nothing
        End If
        dr = Nothing
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        GridControl7.ShowPrintPreview()
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        tbFirmaResim_Satir_sil()
    End Sub
    Private Sub tbFirmaResim_Satir_sil()
        If GridView8.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView8.GetDataRow(GridView8.FocusedRowHandle)
            satir = GridView8.FocusedRowHandle
            If XtraMessageBox.Show(dr("dteKayitTarihi") & vbTab & Sorgu_sDil(" Tarihli Resmi Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaResim_kaydet_Sil(nFirmaID, dr("nFirmaResimID"))
            End If
            ds_tbFirmaResim = Dataload_tbFirmaResim(nFirmaID)
            GridControl7.DataSource = ds_tbFirmaResim.Tables(0)
            GridControl7.DataMember = Nothing
            GridView8.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaResim_kaydet_duzelt(ByVal nFirmaResimID As Int64, ByVal nFirmaID As Int64, ByVal sAciklama As String, ByVal nSira As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaResim SET              sAciklama = N'" & sAciklama & "',nSira = " & nSira & " Where nFirmaID = '" & nFirmaID & "' and nFirmaResimID = '" & nFirmaResimID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaResim_kaydet_Sil(ByVal nFirmaID As Int64, ByVal nStokResimID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete From    tbFirmaResim  Where nFirmaID = '" & nFirmaID & "' and nFirmaResimID = " & nStokResimID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub GridView8_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView8.CellValueChanged
        If GridView8.RowCount > 0 Then
            Dim satir = GridView8.FocusedRowHandle
            Dim dr As DataRow = GridView8.GetDataRow(GridView8.FocusedRowHandle)
            GridView8.PostEditor()
            dr.EndEdit()
            Try
                tbFirmaResim_kaydet_duzelt(dr("nFirmaResimID"), dr("nFirmaID"), dr("sAciklama"), dr("nSira"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Ýçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbFirmaResim = Dataload_tbFirmaResim(nFirmaID)
            GridControl7.DataSource = ds_tbFirmaResim.Tables(0)
            GridControl7.DataMember = Nothing
            GridView8.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub GridView8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView8.DoubleClick
        If GridView8.RowCount > 0 Then
            Dim satir = GridView8.FocusedRowHandle
            Dim dr As DataRow = GridView8.GetDataRow(GridView8.FocusedRowHandle)
            Dim frm As New frm_tbResim
            frm.PictureEdit1.EditValue = dr("pResim")
            frm.ShowDialog()
        End If
    End Sub
    Private Sub KarlýlýkAkýþTablosuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KarlýlýkAkýþTablosuToolStripMenuItem.Click
        analiz_firma_KarlilikAkisTablosu()
    End Sub
    Private Sub HesapKodunuDeðiþtirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HesapKodunuDeðiþtirToolStripMenuItem.Click
        tbFirma_KodDegistir()
    End Sub
    Private Sub tbFirma_KodDegistir()
        Dim deger As String = ""
        deger = InputBox("Yeni Hesap Kodu", "Hesap Kodu", "").ToString
        If deger.ToString <> "" Then
            If sorgu_sKodu_kontrol(deger) = False Then
                XtraMessageBox.Show(deger & vbTab & "Kodu  Daha Önce Kullanýlmýþ", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                tbFirmaKod_kaydet_duzelt(nFirmaID, deger)
                sKodu = deger
                txt_sKodu.Text = deger
                txt_musteriNo.EditValue = sKodu
            End If
        End If
    End Sub
    Private Sub tbFirmaKod_kaydet_duzelt(ByVal nFirmaID As String, ByVal sKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirma SET              sKodu = N'" & sKodu & "' where nFirmaID = N'" & nFirmaID & "' ")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbHesapPlani SET              sKodu = N'" & sKodu & "' Where nHesapID IN (Select nHesapID FROM tbFirma where nFirmaID = N'" & nFirmaID & "') and nHesapID > 0 ")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub HesapPlani_sec(ByVal sAra As String)
        Dim frm As New frm_HesapPlani_liste
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If sAra <> "" Then
            frm.txt_ara.Text = sAra
            frm.sec_konum.Text = "Geliþmiþ"
            frm.sec_kriter.Text = "Baþlar"
        End If
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nHesapID = dr1("nHesapID")
            sMuhasebeKodu = dr1("sKodu")
            txt_sMuhasebeKodu.Text = sKodu
            Dim dr As DataRow
            dr = ds_tbFirma.Tables(0).Rows(0)
            dr("nHesapID") = nHesapID
            dr1 = Nothing
        End If
    End Sub
    Private Sub txt_sMuhasebeKodu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sMuhasebeKodu.ButtonClick
        HesapPlani_sec(Trim(txt_sMuhasebeKodu.Text))
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KodBul.Click
        GroupControl2.Visible = True
        sec_sSinifKodu1.Focus()
        sec_sSinifKodu1.Select()
    End Sub
    Private Sub btn_Kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Kaydet.Click
        txt_sKodu.Text = lbl_sKod.Text
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
        GroupControl2.Visible = False
    End Sub
    Private Sub btn_Vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Vazgec.Click
        GroupControl2.Visible = False
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
    End Sub
    Public Function sorgu_sKodu_bul(ByVal islem As String, ByVal bModel As Boolean, ByVal kod As String, ByVal sAyrac As String) As String
        Dim sKod As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If islem = "tbFirma" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKodu), '') AS sKod FROM         tbFirma WHERE     (sKodu LIKE '" & kod & "%') ")
        ElseIf islem = "tbHesapPlani" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKodu), '') AS sKod FROM         tbHesapPlani WHERE     (sKodu LIKE '" & kod & "%') ")
        ElseIf islem = "tbStok" Then
            If bModel = True Then
                If sAyrac = "" Then
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sModel), '') AS sKod FROM         tbStok WHERE     (sModel LIKE '" & kod & "%') and sModel NOT LIKE '%-%'")
                Else
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sModel), '') AS sKod FROM         tbStok WHERE     (sModel LIKE '" & kod & "%') ")
                End If
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKodu), '') AS sKod FROM         tbStok WHERE     (sKodu LIKE '" & kod & "%') ")
            End If
        ElseIf islem = "sKisaAdi" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKisaAdi), '') AS sKod FROM         tbStok WHERE     (sKisaAdi LIKE '" & kod & "%') ")
        ElseIf islem = "tbKoli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKoliKodu), '') AS sKod FROM         tbKoli WHERE     (sKoliKodu LIKE '" & kod & "%') ")
        End If
        sKod = Trim(cmd.ExecuteScalar)
        conn.Close()
        Return sKod
    End Function
    Private Sub kod_bul()
        Dim sKod As String = ""
        Dim nUzunluk As Integer = 7
        If Trim(sec_sSinifKodu1.Text) <> "" Then
            sKod = Trim(sec_sSinifKodu1.EditValue.ToString)
            'sec_sSinifKodu.EditValue = sKod
            sKod += txt_sAyrac.Text
            nUzunluk = 9
        End If
        If Trim(sec_sSinifKodu2.Text) <> "" Then
            sKod += Trim(sec_sSinifKodu2.EditValue.ToString)
            sKod += txt_sAyrac.Text
            nUzunluk = 13
        End If
        If Trim(sec_sSinifKodu3.Text) <> "" Then
            sKod += Trim(sec_sSinifKodu3.EditValue.ToString)
            sKod += txt_sAyrac.Text
            nUzunluk = 12
        End If
        If Trim(sec_sSinifKodu4.Text) <> "" Then
            sKod += Trim(sec_sSinifKodu4.EditValue.ToString)
            sKod += txt_sAyrac.Text
            nUzunluk = 15
        End If
        'sKod += txt_sAyrac.Text
        Dim lKod As Integer = 1
        lbl_sKod.Text = sorgu_sKodu_bul("tbFirma", True, sKod, txt_sAyrac.Text)
        Try
            lKod = sorgu_sayi(lbl_sKod.Text.Replace(sKod, ""), 0) + 1
            lKod = sayiuzunlukkontrol(lKod, nUzunluk - Len(Trim(sKod)))
        Catch ex As Exception
            lKod = 1
        End Try
        If Trim(lbl_sKod.Text) = "" Then
            lbl_sKod.Text = sKod
        End If
        lbl_sKod.Text = sKod + sayiuzunlukkontrol(lKod, nUzunluk - Len(Trim(sKod)))
    End Sub
    Private Sub sec_sSinifKodu1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu1.Validating
        kod_bul()
    End Sub
    Private Sub sec_sSinifKodu2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu2.Validating
        kod_bul()
    End Sub
    Private Sub sec_sSinifKodu3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu3.Validating
        kod_bul()
    End Sub
    Private Sub sec_sSinifKodu4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu4.Validating
        kod_bul()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        adres_ekle()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        adres_sil()
    End Sub
    Private Sub SimpleButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        adres_yazdir()
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        adres_duzelt()
    End Sub
    Private Sub GridControl8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl8.DoubleClick
        adres_duzelt()
    End Sub
    Private Sub txt_musteriNo_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonPressed
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
        End If
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        If XtraMessageBox.Show(txt_sOnayKodu.Text & Sorgu_sDil(" Onay Numaralý Lisans Kaydýný Sýfýrlamak istediðinize Emin misiniz?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            cmd.Connection = con
            con.ConnectionString = connection
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbFirmaLisans Set sOs = '', sBolge = '', sSifreyiAlan = '', MobileDeviceID = '' Where (nFirmaID = " & nFirmaID & ") AND (sOnayKodu = '" & txt_sOnayKodu.Text & "')")
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub
    Private Sub QueryGibUsers(vknTckn As String)
        Dim mevcutKodu As String = txt_sKodu.Text
        Try
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

            vknTckn = vknTckn.Trim()
            If Not IsNumeric(vknTckn) OrElse (vknTckn.Length <> 10 AndAlso vknTckn.Length <> 11) Then Exit Sub

            ' Gib kullanýcý adý ve þifreyi OleDb ile çek
            Dim gibKullanici As String = ""
            Dim gibSifre As String = ""

            Dim con As New OleDb.OleDbConnection()
            con.ConnectionString = connection

            Dim cmd As New OleDb.OleDbCommand("SELECT TOP 1 GibKullanici, GibSifre FROM tbParamGenel", con)

            con.Open()
            Dim rdr As OleDb.OleDbDataReader = cmd.ExecuteReader()
            If rdr.Read() Then
                gibKullanici = rdr("GibKullanici").ToString().Trim()
                gibSifre = rdr("GibSifre").ToString().Trim()
            End If
            rdr.Close()
            con.Close()

            If gibKullanici = "" OrElse gibSifre = "" Then Exit Sub

            ' Servis istemcisi ve header
            Dim client As New GibSorgula.QueryDocumentWSClient()
            Dim prop As New HttpRequestMessageProperty()
            prop.Headers.Add("Username", gibKullanici)
            prop.Headers.Add("Password", gibSifre)

            Using scope As New OperationContextScope(CType(client.InnerChannel, IClientChannel))
                OperationContext.Current.OutgoingMessageProperties(HttpRequestMessageProperty.Name) = prop

                Dim response = client.QueryUsers(vkn_tckn:=vknTckn, startdate:="", finishDate:="")

                If response IsNot Nothing AndAlso response.queryState = 0 AndAlso response.users IsNot Nothing AndAlso response.users.Length > 0 Then
                    Dim user = response.users(0)
                    txt_sVergiNo.Text = user.vkn_tckn
                    txt_sAdi.Text = user.unvan_ad
                    efatura.Checked = True
                End If
            End Using
            txt_sKodu.Text = mevcutKodu
        Catch ex As Exception
            MsgBox("GÝB sorgusu sýrasýnda hata oluþtu: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    ' txt_sVergiNo_Validating olayý
    Private Sub txt_sVergiNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_sVergiNo.Validating
        txt_sVergiNo.EditValue = Trim(txt_sVergiNo.Text.ToString)
        If Trim(txt_sVergiNo.EditValue) <> "" Then
            ' Mevcut kontrol
            If sorgu_sVergiNo_kontrol(txt_sVergiNo.Text.ToString, nFirmaID, yeni) = False Then
                If XtraMessageBox.Show(txt_sVergiNo.Text & Sorgu_sDil("  Vergi No Daha Önce Kayýt Yapýlmýþ...", sDil) & vbCrLf &
                                       Sorgu_sDil("Kayýtlarý Görmek Ýster misiniz..?", sDil),
                                       Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                    Dim frm As New frm_firma_liste
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.sModul = sModul
                    frm.txt_ara.Text = txt_sVergiNo.EditValue
                    frm.sec_konum.Text = "VergiNo"
                    frm.sec_kriter.Text = "Eþittir"
                    frm.ShowDialog()
                End If
            End If

            ' GÝB sorgusu
            QueryGibUsers(txt_sVergiNo.Text)
        End If
    End Sub
    ' txt_TC_Validating olayý
    Private Sub txt_TC_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_TC.Validating
        txt_TC.EditValue = Trim(txt_TC.Text.ToString)
        If Trim(txt_TC.EditValue) <> "" Then
            If txt_TC.Text.Length = 11 Then
                If sorgu_TC_kontrol(txt_TC.Text.ToString, nFirmaID, yeni) = False Then
                    XtraMessageBox.Show(txt_TC.Text & Sorgu_sDil(" TC'si ile Daha Önce Kayýt Yapýlmýþtýr!", sDil), Sorgu_sDil("Dikkat", sDil))
                    'txt_TC.Text = ""
                    'txt_TC.Focus()
                Else
                    ' GÝB sorgusu
                    QueryGibUsers(txt_TC.Text)
                End If
            Else
                XtraMessageBox.Show("TC kimlik numarasý 11 haneden az olamaz!", "Dikkat")
                txt_TC.Text = ""
                txt_TC.Focus()
            End If
        End If
    End Sub


    ' === RISK GOSTERGESI METODU ===
    Private Sub RiskGostergesiniGuncelle()
        Try
            ' Parametrik kontrol
            Dim conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            Dim cmdAyar As New OleDb.OleDbCommand
            cmdAyar.Connection = conn

            ' RISK_SKORU_AKTIF kontrolu
            cmdAyar.CommandText = sorgu_query("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu='RISK_SKORU_AKTIF'")
            Dim sRiskAktif As String = ""
            Try : sRiskAktif = cmdAyar.ExecuteScalar().ToString() : Catch : End Try
            If sRiskAktif <> "1" Then
                conn.Close()
                Exit Sub
            End If

            ' Yetki kontrolu
            If yetki_kontrol(kullanici, "ai_risk_skoru_gor") = False Then
                conn.Close()
                Exit Sub
            End If

            ' Bakiye + Gecikme bilgisi
            cmdAyar.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & _
                "ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS Bakiye, " & _
                "ISNULL(SUM(lBorcTutar), 0) AS ToplamBorc, " & _
                "ISNULL(SUM(lAlacakTutar), 0) AS ToplamAlacak, " & _
                "ISNULL(SUM(CASE WHEN lBorcTutar > 0 AND dteValorTarihi < GETDATE() THEN lBorcTutar - lAlacakTutar ELSE 0 END), 0) AS VadesiGecmis, " & _
                "ISNULL(MAX(CASE WHEN lBorcTutar > 0 AND dteValorTarihi < GETDATE() THEN DATEDIFF(DAY, dteValorTarihi, GETDATE()) ELSE 0 END), 0) AS MaxGecikmeGun " & _
                "FROM tbFirmaHareketi WHERE nFirmaID=" & nFirmaID)

            Dim dr As OleDb.OleDbDataReader = cmdAyar.ExecuteReader()
            Dim bakiye As Decimal = 0
            Dim vadesiGecmis As Decimal = 0
            Dim maxGecikmeGun As Integer = 0
            If dr.Read() Then
                bakiye = CDec(dr("Bakiye"))
                vadesiGecmis = CDec(dr("VadesiGecmis"))
                maxGecikmeGun = CInt(dr("MaxGecikmeGun"))
            End If
            dr.Close()

            ' Kredi limiti
            cmdAyar.CommandText = sorgu_query("SELECT ISNULL(lKrediLimiti,0) FROM tbFirma WHERE nFirmaID=" & nFirmaID)
            Dim krediLimiti As Decimal = 0
            Try : krediLimiti = CDec(cmdAyar.ExecuteScalar()) : Catch : End Try

            ' Bekleyen siparisler (tbSiparis - kapanmamis)
            cmdAyar.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " & _
                "SELECT ISNULL(COUNT(DISTINCT lSiparisNo),0) AS SiparisAdet, ISNULL(SUM(lTutari),0) AS SiparisTutar " & _
                "FROM tbSiparis WHERE nFirmaID=" & nFirmaID & " AND ISNULL(bKapandimi,0)=0")
            Dim drSip As OleDb.OleDbDataReader = cmdAyar.ExecuteReader()
            Dim bekleyenSiparisAdet As Integer = 0
            Dim bekleyenSiparisTutar As Decimal = 0
            If drSip.Read() Then
                bekleyenSiparisAdet = CInt(drSip("SiparisAdet"))
                bekleyenSiparisTutar = CDec(drSip("SiparisTutar"))
            End If
            drSip.Close()

            ' Odeme aliskanligi: Son 6 ayda ortalama odeme suresi
            cmdAyar.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " & _
                "SELECT ISNULL(AVG(DATEDIFF(DAY, dteValorTarihi, dteIslemTarihi)),0) " & _
                "FROM tbFirmaHareketi WHERE nFirmaID=" & nFirmaID & " " & _
                "AND lAlacakTutar > 0 AND dteIslemTarihi >= DATEADD(MONTH, -6, GETDATE())")
            Dim ortOdemeSuresi As Integer = 0
            Try : ortOdemeSuresi = CInt(cmdAyar.ExecuteScalar()) : Catch : End Try

            conn.Close()

            ' === RISK SKORU HESAPLA ===
            Dim skor As Integer = 100

            ' Gecikme cezasi (max -40)
            If maxGecikmeGun > 90 Then
                skor -= 40
            ElseIf maxGecikmeGun > 60 Then
                skor -= 30
            ElseIf maxGecikmeGun > 30 Then
                skor -= 20
            ElseIf maxGecikmeGun > 0 Then
                skor -= 10
            End If

            ' Vadesi gecmis oran (max -15)
            If bakiye > 0 AndAlso vadesiGecmis > 0 Then
                Dim gecikmeOrani As Decimal = vadesiGecmis / bakiye
                If gecikmeOrani > 0.5D Then skor -= 15
                If gecikmeOrani > 0.3D Then skor -= 10
            End If

            ' Limit asimi (bekleyen siparislerle birlikte) (max -20)
            If krediLimiti > 0 Then
                Dim toplamYuk As Decimal = bakiye + bekleyenSiparisTutar
                If toplamYuk > krediLimiti Then
                    skor -= 20
                ElseIf toplamYuk / krediLimiti > 0.9D Then
                    skor -= 15
                ElseIf toplamYuk / krediLimiti > 0.7D Then
                    skor -= 5
                End If
            End If

            ' Odeme aliskanligi (max -15)
            If ortOdemeSuresi > 30 Then
                skor -= 15
            ElseIf ortOdemeSuresi > 15 Then
                skor -= 10
            ElseIf ortOdemeSuresi > 5 Then
                skor -= 5
            End If

            skor = Math.Max(0, Math.Min(100, skor))

            Dim seviye As String = If(skor >= 70, "GUVENLI", If(skor >= 40, "DIKKAT", "KRITIK"))
            Dim renk As Color = If(skor >= 70, Color.FromArgb(39, 174, 96), If(skor >= 40, Color.FromArgb(243, 156, 18), Color.FromArgb(231, 76, 60)))

            ' Risk paneli olustur
            If pnlRisk Is Nothing Then
                pnlRisk = New Panel()
                pnlRisk.Dock = DockStyle.Top
                pnlRisk.Height = 36
                pnlRisk.BackColor = renk
                pnlRisk.Padding = New Padding(8, 4, 8, 4)
                pnlRisk.Visible = True

                lblRiskSkor = New Label()
                lblRiskSkor.AutoSize = True
                lblRiskSkor.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                lblRiskSkor.ForeColor = Color.White
                lblRiskSkor.Location = New Point(8, 8)

                lblRiskAciklama = New Label()
                lblRiskAciklama.AutoSize = True
                lblRiskAciklama.Font = New Font("Segoe UI", 9)
                lblRiskAciklama.ForeColor = Color.White
                lblRiskAciklama.Location = New Point(220, 10)

                btnRiskDetay = New Button()
                btnRiskDetay.Text = "AI Detay"
                btnRiskDetay.FlatStyle = FlatStyle.Flat
                btnRiskDetay.FlatAppearance.BorderColor = Color.White
                btnRiskDetay.FlatAppearance.BorderSize = 1
                btnRiskDetay.ForeColor = Color.White
                btnRiskDetay.BackColor = Color.Transparent
                btnRiskDetay.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                btnRiskDetay.Size = New Size(80, 28)
                btnRiskDetay.Dock = DockStyle.Right
                btnRiskDetay.Cursor = Cursors.Hand
                AddHandler btnRiskDetay.Click, AddressOf btnRiskDetay_Click

                Dim btnSatisOneri As New Button()
                btnSatisOneri.Text = "Satis Oneri"
                btnSatisOneri.FlatStyle = FlatStyle.Flat
                btnSatisOneri.FlatAppearance.BorderColor = Color.White
                btnSatisOneri.FlatAppearance.BorderSize = 1
                btnSatisOneri.ForeColor = Color.White
                btnSatisOneri.BackColor = Color.Transparent
                btnSatisOneri.Font = New Font("Segoe UI", 8, FontStyle.Bold)
                btnSatisOneri.Size = New Size(90, 28)
                btnSatisOneri.Dock = DockStyle.Right
                btnSatisOneri.Cursor = Cursors.Hand
                AddHandler btnSatisOneri.Click, Sub()
                                                    Try
                                                        Dim firmaAdi As String = ""
                                                        Try : firmaAdi = TextEdit4.Text : Catch : End Try
                                                        Dim frm As New frm_AISatisOneri(CInt(nFirmaID), firmaAdi)
                                                        frm.Show()
                                                    Catch ex As Exception
                                                        MessageBox.Show("Satis Oneri formu acilamadi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                    End Try
                                                End Sub

                pnlRisk.Controls.Add(btnSatisOneri)
                pnlRisk.Controls.Add(btnRiskDetay)
                pnlRisk.Controls.Add(lblRiskSkor)
                pnlRisk.Controls.Add(lblRiskAciklama)
                Me.Controls.Add(pnlRisk)
                pnlRisk.BringToFront()
            End If

            ' Metin olustur
            Dim detay As String = "Bakiye: " & bakiye.ToString("N2") & " TL"
            If vadesiGecmis > 0 Then detay &= " | Geciken: " & vadesiGecmis.ToString("N2") & " (" & maxGecikmeGun & " gun)"
            If krediLimiti > 0 Then detay &= " | Limit: %" & Math.Round(bakiye / krediLimiti * 100, 0)
            If bekleyenSiparisAdet > 0 Then detay &= " | Bekleyen Sip: " & bekleyenSiparisAdet & " adet " & bekleyenSiparisTutar.ToString("N2") & " TL"
            If ortOdemeSuresi > 5 Then detay &= " | Ort.Odeme: " & ortOdemeSuresi & " gun"

            pnlRisk.BackColor = renk
            lblRiskSkor.Text = "Risk: " & skor & "/100 (" & seviye & ")"
            lblRiskAciklama.Text = detay
            pnlRisk.Visible = True

        Catch ex As Exception
            ' Risk gostergesi hatasi formu engellemez
        End Try
    End Sub

    ' === AI RISK DETAY BUTONU CLICK ===
    Private Sub btnRiskDetay_Click(sender As Object, e As EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim apiUrl As String = "https://desktop.barkodyazilimevi.com"
            Dim wc As New System.Net.WebClient()
            wc.Encoding = System.Text.Encoding.UTF8
            wc.Headers.Add("Content-Type", "application/json")
            wc.Headers.Add("X-Api-Key", "BSmart2024Desktop!@#SecureKey")

            Dim firmaAdi As String = ""
            Try : firmaAdi = TextEdit4.Text.Replace(Chr(34), "'") : Catch : End Try

            Dim jsonData As String = "{""firmaId"":" & nFirmaID & "}"
            Dim result As String = wc.UploadString(apiUrl & "/api/ai/risk-aciklama", jsonData)

            ' Parse response fields
            Dim aciklama As String = ParseAIJsonField(result, "aciklama")
            Dim oneriler As String = ParseAIJsonField(result, "oneriler")
            Dim satisKarari As String = ParseAIJsonField(result, "satisKarari")
            Dim aiAciklama As String = ParseAIJsonField(result, "aiAciklama")
            Dim skorStr As String = ParseAIJsonField(result, "riskSkor")
            Dim seviye As String = ParseAIJsonField(result, "seviye")

            Dim mesaj As String = "Risk Skoru: " & skorStr & "/100 (" & seviye.ToUpper() & ")" & vbCrLf & vbCrLf
            mesaj &= "KURAL BAZLI ANALIZ:" & vbCrLf & aciklama.Replace("
", vbCrLf) & vbCrLf & vbCrLf
            If oneriler <> "" Then mesaj &= "ONERILER:" & vbCrLf & oneriler.Replace("
", vbCrLf) & vbCrLf & vbCrLf
            If satisKarari <> "" Then mesaj &= "SATIS KARARI: " & satisKarari & vbCrLf & vbCrLf
            If aiAciklama <> "" Then mesaj &= "AI ANALIZI:" & vbCrLf & aiAciklama.Replace("
", vbCrLf)

            Me.Cursor = Cursors.Default
            MessageBox.Show(mesaj, "AI Risk Analizi - " & firmaAdi, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("AI servisine baglanilamadi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function ParseAIJsonField(json As String, fieldName As String) As String
        Try
            Dim key As String = Chr(34) & fieldName & Chr(34)
            Dim keyIdx As Integer = json.IndexOf(key)
            If keyIdx < 0 Then Return ""
            Dim colonIdx As Integer = json.IndexOf(":", keyIdx + key.Length)
            If colonIdx < 0 Then Return ""
            Dim afterColon As String = json.Substring(colonIdx + 1).TrimStart()
            If afterColon.StartsWith(Chr(34)) Then
                Dim valueStart As Integer = 1
                Dim valueEnd As Integer = valueStart
                While valueEnd < afterColon.Length
                    If afterColon(valueEnd) = "" AndAlso valueEnd + 1 < afterColon.Length Then
                        valueEnd += 2
                    ElseIf afterColon(valueEnd) = Chr(34) Then
                        Exit While
                    Else
                        valueEnd += 1
                    End If
                End While
                Return afterColon.Substring(valueStart, valueEnd - valueStart).Replace("
", vbCrLf).Replace("\", "")
            Else
                ' Numeric or boolean
                Dim endIdx As Integer = afterColon.IndexOfAny(New Char() {","c, "}"c})
                If endIdx < 0 Then endIdx = afterColon.Length
                Return afterColon.Substring(0, endIdx).Trim()
            End If
        Catch
            Return ""
        End Try
    End Function
End Class