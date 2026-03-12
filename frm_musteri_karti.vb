Imports DevExpress.XtraEditors
Public Class frm_musteri_karti
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents ds_kefil As System.Data.DataSet
    Friend WithEvents ds_kimlik As System.Data.DataSet
    Friend WithEvents ds_sinif As System.Data.DataSet
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
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents ds_sozlesme As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataTable4 As System.Data.DataTable
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
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPesinat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKasaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsYaziIle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeslimatci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIadeAvInf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIslemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokOdeme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKalanTaksit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Tipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Tanimlama_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Kodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Adi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFis_Musteri_Soyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Fis_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Tarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaksit_Tutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlisveris_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri_Taksiti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdeme_tutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid_satis As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_satis_detay As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_satis_kapatma As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFis_Musteri_TanimlamaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdeme_Kodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdeme_Sekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdeme_Sekli_Aciklamasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlan_Kasiyer_Rumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlan_Kasiyer_Adi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlan_Kasiyer_Soyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDovizTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMakbuzNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlisveris_Tarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlisveris_FaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlisveris_HareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlisVeris_sFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECIKME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid_satis_odeme As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField20 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Grid_odemeler As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_odemeler_kalan As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilecek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOnayTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid_bekleyen As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_tanimlar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsYeriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAylikGelir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSonKullanmaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VGrid_kimlik As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rownMusteriID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsDin As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKutukIl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKutukIlce As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKutukMahalle As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKutukCiltNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKutukSiraNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteNufusCuzdanTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsCuzdanVerilenYer As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsCuzdanKayitNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAnneAdi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsBabaAdi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAileAdresi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAileTelefonu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsCuzdanVerNedeni As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents VGrid_sinif As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowSýnýf1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf9 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf11 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf12 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf13 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf14 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSýnýf15 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents EditorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents VGrid_genel As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents EditorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsMagaza As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKodu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAdi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsSoyadi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMusteri As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownCinsiyet As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row_lAylikGelir As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteKartAcilisTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownIskontoPesin As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownIskontoKredili As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsUnvan As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiDairesi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowbYazismaEvAdresinemi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsEmail As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsIsYeriAdi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsIsAdresi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsIsTelefonu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsEvAdresi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsEvTelefonu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsSigortaNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowbEvlimi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteEvlilikTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteDogumTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsDogumYeri As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsEhliyetNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKanGrubu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteKayitTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowISTIHBARAT As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsGSM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsFax As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categoryKimlikBilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAileBilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryEvBilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryÝþBilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryFinansman As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryÖzelBilgiler As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryFaturaBilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents Gridcontrol2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Context_bekleyen As System.Windows.Forms.ContextMenu
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink_bekleyen As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink_genel As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink_kefil As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink_sozlesme As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink_sinif As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink_kimlik As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink_musteri As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTakipTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTakipAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSonuc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIletisimTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIletisimSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIlgiliKisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIstihbarat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGelecekmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdendi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colErisimTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid_Takip As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_ekstre_tarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_ekstre_tarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn71 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn72 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn73 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTransferDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFaturalasti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMuhasebelesti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn74 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamamlandi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHizmet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn75 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn76 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn77 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbPesinmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOTV2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSayfa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn78 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn79 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbKilitli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn80 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn81 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn82 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn83 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn84 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOYADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTESLIMAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISKAYITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSure As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn85 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ds_tbMusteriResim As System.Data.DataSet
    Friend WithEvents DataTable11 As System.Data.DataTable
    Friend WithEvents DataColumn169 As System.Data.DataColumn
    Friend WithEvents DataColumn170 As System.Data.DataColumn
    Friend WithEvents DataColumn171 As System.Data.DataColumn
    Friend WithEvents DataColumn172 As System.Data.DataColumn
    Friend WithEvents DataColumn173 As System.Data.DataColumn
    Friend WithEvents DataColumn174 As System.Data.DataColumn
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpResim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_pResim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtekayitTarihi3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_karti))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colGECIKME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri_Taksiti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbPesinmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ds_kefil = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsYeriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAylikGelir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.VGrid_kimlik = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_kimlik = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
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
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.categoryKimlikBilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownMusteriID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsDin = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKutukIl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKutukIlce = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKutukMahalle = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKutukCiltNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKutukSiraNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteNufusCuzdanTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsCuzdanVerilenYer = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsCuzdanKayitNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsCuzdanVerNedeni = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryAileBilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsAnneAdi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsBabaAdi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAileAdresi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAileTelefonu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.VGrid_sinif = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_sinif = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.DataColumn79 = New System.Data.DataColumn()
        Me.DataColumn80 = New System.Data.DataColumn()
        Me.DataColumn81 = New System.Data.DataColumn()
        Me.rowSýnýf1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf11 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf12 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf13 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf14 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSýnýf15 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.EditorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Gridcontrol2 = New DevExpress.XtraGrid.GridControl()
        Me.ds_sozlesme = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteSonKullanmaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panel_tanimlar = New DevExpress.XtraEditors.PanelControl()
        Me.VGrid_genel = New DevExpress.XtraVerticalGrid.VGridControl()
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
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.EditorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteKayitTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsMagaza = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKodu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMusteri = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAdi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsSoyadi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryEvBilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsEvAdresi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsEvTelefonu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsGSM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsEmail = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbYazismaEvAdresinemi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteKartAcilisTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowISTIHBARAT = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryÝþBilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsIsYeriAdi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsIsAdresi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsIsTelefonu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsFax = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsSigortaNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row_lAylikGelir = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryFaturaBilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsUnvan = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsVergiDairesi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsVergiNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryFinansman = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownIskontoPesin = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownIskontoKredili = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryÖzelBilgiler = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownCinsiyet = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbEvlimi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteEvlilikTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteDogumTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsDogumYeri = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsEhliyetNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKanGrubu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.Grid_satis_detay = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeslimatci = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIadeAvInf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIslemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokOdeme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSevkAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKalanTaksit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.Grid_satis_odeme = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFis_Musteri_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdeme_Kodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdeme_Sekli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdeme_Sekli_Aciklamasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlan_Kasiyer_Rumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlan_Kasiyer_Adi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlan_Kasiyer_Soyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDovizTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMakbuzNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdemeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlisveris_Tarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlisveris_FaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlisveris_HareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlisVeris_sFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid_satis_kapatma = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFis_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Tipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Tanimlama_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Kodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Adi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFis_Musteri_Soyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Fis_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Tarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaksit_Tutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlisveris_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdeme_tutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Grid_satis = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPesinat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYaziIle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.grid_odemeler_kalan = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_odemeler = New DevExpress.XtraGrid.GridControl()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.Grid_bekleyen = New DevExpress.XtraGrid.GridControl()
        Me.Context_bekleyen = New System.Windows.Forms.ContextMenu()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilecek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.Grid_Takip = New DevExpress.XtraGrid.GridControl()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTakipTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTakipAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSonuc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIletisimTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIletisimSekli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIlgiliKisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIstihbarat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAciklama4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGelecekmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdendi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colErisimTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.Label39 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label40 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_ekstre_tarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_ekstre_tarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn71 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn72 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn73 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTransferDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFaturalasti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMuhasebelesti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn74 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTamamlandi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHizmet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn75 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn76 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn77 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOTV2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSayfa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn78 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn79 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbKilitli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn80 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn81 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn82 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn83 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn84 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOYADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESLIMAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISKAYITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSure = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn85 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl()
        Me.ds_tbMusteriResim = New System.Data.DataSet()
        Me.DataTable11 = New System.Data.DataTable()
        Me.DataColumn169 = New System.Data.DataColumn()
        Me.DataColumn170 = New System.Data.DataColumn()
        Me.DataColumn171 = New System.Data.DataColumn()
        Me.DataColumn172 = New System.Data.DataColumn()
        Me.DataColumn173 = New System.Data.DataColumn()
        Me.DataColumn174 = New System.Data.DataColumn()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpResim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pResim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtekayitTarihi3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink_bekleyen = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink_musteri = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.printlink_genel = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink_kefil = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink_sozlesme = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink_sinif = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink_kimlik = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl10.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kefil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.VGrid_kimlik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kimlik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.VGrid_sinif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_sinif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Gridcontrol2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_sozlesme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_tanimlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_tanimlar.SuspendLayout()
        CType(Me.VGrid_genel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.Grid_satis_detay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.Grid_satis_odeme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_satis_kapatma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.Grid_satis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.grid_odemeler_kalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.Grid_odemeler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.Grid_bekleyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.Grid_Takip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbMusteriResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink_bekleyen.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink_musteri.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink_genel.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink_kefil.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink_sozlesme.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink_sinif.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink_kimlik.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colGECIKME
        '
        Me.colGECIKME.Caption = "Geç"
        Me.colGECIKME.FieldName = "GECIKME"
        Me.colGECIKME.Name = "colGECIKME"
        Me.colGECIKME.Visible = True
        Me.colGECIKME.VisibleIndex = 4
        Me.colGECIKME.Width = 38
        '
        'colMusteri_Taksiti
        '
        Me.colMusteri_Taksiti.Caption = "Kalan"
        Me.colMusteri_Taksiti.DisplayFormat.FormatString = "#,#.##"
        Me.colMusteri_Taksiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMusteri_Taksiti.FieldName = "Musteri_Taksiti"
        Me.colMusteri_Taksiti.Name = "colMusteri_Taksiti"
        Me.colMusteri_Taksiti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Musteri_Taksiti", "{0:#,0.00}")})
        Me.colMusteri_Taksiti.Visible = True
        Me.colMusteri_Taksiti.VisibleIndex = 3
        Me.colMusteri_Taksiti.Width = 48
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Gecikme"
        Me.GridColumn30.FieldName = "GECIKME"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "GECIKME", "{0:#,0.00}")})
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 8
        Me.GridColumn30.Width = 65
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "Teslimatçý"
        Me.GridColumn45.FieldName = "Teslimatci"
        Me.GridColumn45.Name = "GridColumn45"
        '
        'colbPesinmi
        '
        Me.colbPesinmi.Caption = "Kapali"
        Me.colbPesinmi.FieldName = "bPesinmi"
        Me.colbPesinmi.Name = "colbPesinmi"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1475, 80)
        Me.PanelControl1.TabIndex = 2
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(960, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(513, 19)
        Me.lbl_istihbarat.TabIndex = 37
        Me.lbl_istihbarat.Text = "*"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Müþteri Kartý ve Analiz Bilgileri Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 883)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1475, 57)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(590, 11)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(167, 33)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "Hesap Düzelt"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(424, 11)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(166, 33)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "Açýklama Gir"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MüþteriNo:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(115, 11)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(247, 26)
        Me.txt_musteriNo.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1339, 11)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1219, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1475, 803)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1471, 799)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8, Me.XtraTabPage9})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl10)
        Me.XtraTabPage1.Controls.Add(Me.PanelControl9)
        Me.XtraTabPage1.Controls.Add(Me.panel_tanimlar)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage1.Text = "&GenelBilgiler"
        '
        'PanelControl10
        '
        Me.PanelControl10.Controls.Add(Me.GridControl1)
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl10.Location = New System.Drawing.Point(0, 240)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(1469, 292)
        Me.PanelControl10.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_kefil
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1465, 288)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ds_kefil
        '
        Me.ds_kefil.DataSetName = "NewDataSet"
        Me.ds_kefil.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kefil.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nMusteriID"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sAdi"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sUnvan"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sEmail"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sIsYeriAdi"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sIsAdresi"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "sIsTelefonu"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sEvAdresi"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "sEvTelefonu"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "lAylikGelir"
        Me.DataColumn42.DataType = GetType(Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "sKullaniciAdi"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "dteKayitTarihi"
        Me.DataColumn44.DataType = GetType(Date)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsAdi, Me.colsUnvan, Me.colsEmail, Me.colsIsYeriAdi, Me.colsIsAdresi, Me.colsIsTelefonu, Me.colsEvAdresi, Me.colsEvTelefonu, Me.collAylikGelir, Me.colsKullaniciAdi, Me.coldteKayitTarihi})
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "nMusteriID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adi"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAdi", "{0} Kayýt")})
        Me.colsAdi.Visible = True
        Me.colsAdi.VisibleIndex = 0
        Me.colsAdi.Width = 146
        '
        'colsUnvan
        '
        Me.colsUnvan.Caption = "sUnvan"
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        '
        'colsEmail
        '
        Me.colsEmail.Caption = "Email"
        Me.colsEmail.FieldName = "sEmail"
        Me.colsEmail.Name = "colsEmail"
        Me.colsEmail.Visible = True
        Me.colsEmail.VisibleIndex = 1
        Me.colsEmail.Width = 92
        '
        'colsIsYeriAdi
        '
        Me.colsIsYeriAdi.Caption = "IsYeriAdi"
        Me.colsIsYeriAdi.FieldName = "sIsYeriAdi"
        Me.colsIsYeriAdi.Name = "colsIsYeriAdi"
        Me.colsIsYeriAdi.Visible = True
        Me.colsIsYeriAdi.VisibleIndex = 2
        Me.colsIsYeriAdi.Width = 92
        '
        'colsIsAdresi
        '
        Me.colsIsAdresi.Caption = "IsAdresi"
        Me.colsIsAdresi.FieldName = "sIsAdresi"
        Me.colsIsAdresi.Name = "colsIsAdresi"
        Me.colsIsAdresi.Visible = True
        Me.colsIsAdresi.VisibleIndex = 3
        Me.colsIsAdresi.Width = 92
        '
        'colsIsTelefonu
        '
        Me.colsIsTelefonu.Caption = "IsTelefonu"
        Me.colsIsTelefonu.FieldName = "sIsTelefonu"
        Me.colsIsTelefonu.Name = "colsIsTelefonu"
        Me.colsIsTelefonu.Visible = True
        Me.colsIsTelefonu.VisibleIndex = 4
        Me.colsIsTelefonu.Width = 92
        '
        'colsEvAdresi
        '
        Me.colsEvAdresi.Caption = "EvAdresi"
        Me.colsEvAdresi.FieldName = "sEvAdresi"
        Me.colsEvAdresi.Name = "colsEvAdresi"
        Me.colsEvAdresi.Visible = True
        Me.colsEvAdresi.VisibleIndex = 5
        Me.colsEvAdresi.Width = 92
        '
        'colsEvTelefonu
        '
        Me.colsEvTelefonu.Caption = "EvTelefonu"
        Me.colsEvTelefonu.FieldName = "sEvTelefonu"
        Me.colsEvTelefonu.Name = "colsEvTelefonu"
        Me.colsEvTelefonu.Visible = True
        Me.colsEvTelefonu.VisibleIndex = 6
        Me.colsEvTelefonu.Width = 92
        '
        'collAylikGelir
        '
        Me.collAylikGelir.Caption = "AylikGelir"
        Me.collAylikGelir.FieldName = "lAylikGelir"
        Me.collAylikGelir.Name = "collAylikGelir"
        Me.collAylikGelir.Visible = True
        Me.collAylikGelir.VisibleIndex = 7
        Me.collAylikGelir.Width = 97
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "sKullaniciAdi"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "dteKayitTarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'PanelControl9
        '
        Me.PanelControl9.Controls.Add(Me.GroupControl3)
        Me.PanelControl9.Controls.Add(Me.GroupControl2)
        Me.PanelControl9.Controls.Add(Me.GroupControl1)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl9.Location = New System.Drawing.Point(0, 532)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(1469, 228)
        Me.PanelControl9.TabIndex = 1
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.VGrid_kimlik)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(447, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(649, 224)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "KimlikBilgileri"
        '
        'VGrid_kimlik
        '
        Me.VGrid_kimlik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_kimlik.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_kimlik.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_kimlik.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_kimlik.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_kimlik.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_kimlik.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_kimlik.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_kimlik.CustomizationFormBounds = New System.Drawing.Rectangle(489, 234, 208, 252)
        Me.VGrid_kimlik.DataMember = Nothing
        Me.VGrid_kimlik.DataSource = Me.ds_kimlik
        Me.VGrid_kimlik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_kimlik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_kimlik.Location = New System.Drawing.Point(2, 21)
        Me.VGrid_kimlik.Name = "VGrid_kimlik"
        Me.VGrid_kimlik.OptionsBehavior.Editable = False
        Me.VGrid_kimlik.RecordWidth = 63
        Me.VGrid_kimlik.RowHeaderWidth = 76
        Me.VGrid_kimlik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryKimlikBilgileri, Me.rownMusteriID, Me.rowsDin, Me.rowsKutukIl, Me.rowsKutukIlce, Me.rowsKutukMahalle, Me.rowsKutukCiltNo, Me.rowsKutukSiraNo, Me.rowdteNufusCuzdanTarihi, Me.rowsCuzdanVerilenYer, Me.rowsCuzdanKayitNo, Me.rowsCuzdanVerNedeni, Me.categoryAileBilgileri})
        Me.VGrid_kimlik.Size = New System.Drawing.Size(645, 201)
        Me.VGrid_kimlik.TabIndex = 0
        Me.VGrid_kimlik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_kimlik
        '
        Me.ds_kimlik.DataSetName = "NewDataSet"
        Me.ds_kimlik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kimlik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "nMusteriID"
        Me.DataColumn51.DataType = GetType(System.TimeSpan)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "sDin"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "sKutukIl"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "sKutukIlce"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "sKutukMahalle"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "sKutukCiltNo"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sKutukSiraNo"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "dteNufusCuzdanTarihi"
        Me.DataColumn58.DataType = GetType(Date)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "sCuzdanVerilenYer"
        Me.DataColumn59.DataType = GetType(System.TimeSpan)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "sCuzdanKayitNo"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "sAnneAdi"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "sBabaAdi"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "sAileAdresi"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "sAileTelefonu"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "sCuzdanVerNedeni"
        '
        'categoryKimlikBilgileri
        '
        Me.categoryKimlikBilgileri.Name = "categoryKimlikBilgileri"
        Me.categoryKimlikBilgileri.Properties.Caption = "KimlikBilgileri"
        '
        'rownMusteriID
        '
        Me.rownMusteriID.Name = "rownMusteriID"
        Me.rownMusteriID.Properties.Caption = "MüþteriNo"
        Me.rownMusteriID.Properties.FieldName = "nMusteriID"
        Me.rownMusteriID.Visible = False
        '
        'rowsDin
        '
        Me.rowsDin.Name = "rowsDin"
        Me.rowsDin.Properties.Caption = "Din"
        Me.rowsDin.Properties.FieldName = "sDin"
        '
        'rowsKutukIl
        '
        Me.rowsKutukIl.Height = 16
        Me.rowsKutukIl.Name = "rowsKutukIl"
        Me.rowsKutukIl.Properties.Caption = "Il"
        Me.rowsKutukIl.Properties.FieldName = "sKutukIl"
        '
        'rowsKutukIlce
        '
        Me.rowsKutukIlce.Name = "rowsKutukIlce"
        Me.rowsKutukIlce.Properties.Caption = "Ilce"
        Me.rowsKutukIlce.Properties.FieldName = "sKutukIlce"
        '
        'rowsKutukMahalle
        '
        Me.rowsKutukMahalle.Name = "rowsKutukMahalle"
        Me.rowsKutukMahalle.Properties.Caption = "Mahalle"
        Me.rowsKutukMahalle.Properties.FieldName = "sKutukMahalle"
        '
        'rowsKutukCiltNo
        '
        Me.rowsKutukCiltNo.Name = "rowsKutukCiltNo"
        Me.rowsKutukCiltNo.Properties.Caption = "CiltNo"
        Me.rowsKutukCiltNo.Properties.FieldName = "sKutukCiltNo"
        '
        'rowsKutukSiraNo
        '
        Me.rowsKutukSiraNo.Name = "rowsKutukSiraNo"
        Me.rowsKutukSiraNo.Properties.Caption = "SiraNo"
        Me.rowsKutukSiraNo.Properties.FieldName = "sKutukSiraNo"
        '
        'rowdteNufusCuzdanTarihi
        '
        Me.rowdteNufusCuzdanTarihi.Name = "rowdteNufusCuzdanTarihi"
        Me.rowdteNufusCuzdanTarihi.Properties.Caption = "CüzdanTarihi"
        Me.rowdteNufusCuzdanTarihi.Properties.FieldName = "dteNufusCuzdanTarihi"
        '
        'rowsCuzdanVerilenYer
        '
        Me.rowsCuzdanVerilenYer.Name = "rowsCuzdanVerilenYer"
        Me.rowsCuzdanVerilenYer.Properties.Caption = "VerilenYer"
        Me.rowsCuzdanVerilenYer.Properties.FieldName = "sCuzdanVerilenYer"
        '
        'rowsCuzdanKayitNo
        '
        Me.rowsCuzdanKayitNo.Height = 16
        Me.rowsCuzdanKayitNo.Name = "rowsCuzdanKayitNo"
        Me.rowsCuzdanKayitNo.Properties.Caption = "KayitNo"
        Me.rowsCuzdanKayitNo.Properties.FieldName = "sCuzdanKayitNo"
        '
        'rowsCuzdanVerNedeni
        '
        Me.rowsCuzdanVerNedeni.Name = "rowsCuzdanVerNedeni"
        Me.rowsCuzdanVerNedeni.Properties.Caption = "VerNedeni"
        Me.rowsCuzdanVerNedeni.Properties.FieldName = "sCuzdanVerNedeni"
        '
        'categoryAileBilgileri
        '
        Me.categoryAileBilgileri.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsAnneAdi, Me.rowsBabaAdi, Me.rowsAileAdresi, Me.rowsAileTelefonu})
        Me.categoryAileBilgileri.Name = "categoryAileBilgileri"
        Me.categoryAileBilgileri.Properties.Caption = "AileBilgileri"
        '
        'rowsAnneAdi
        '
        Me.rowsAnneAdi.Name = "rowsAnneAdi"
        Me.rowsAnneAdi.Properties.Caption = "AnneAdi"
        Me.rowsAnneAdi.Properties.FieldName = "sAnneAdi"
        '
        'rowsBabaAdi
        '
        Me.rowsBabaAdi.Name = "rowsBabaAdi"
        Me.rowsBabaAdi.Properties.Caption = "BabaAdi"
        Me.rowsBabaAdi.Properties.FieldName = "sBabaAdi"
        '
        'rowsAileAdresi
        '
        Me.rowsAileAdresi.Name = "rowsAileAdresi"
        Me.rowsAileAdresi.Properties.Caption = "AileAdresi"
        Me.rowsAileAdresi.Properties.FieldName = "sAileAdresi"
        '
        'rowsAileTelefonu
        '
        Me.rowsAileTelefonu.Name = "rowsAileTelefonu"
        Me.rowsAileTelefonu.Properties.Caption = "AileTelefonu"
        Me.rowsAileTelefonu.Properties.FieldName = "sAileTelefonu"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.VGrid_sinif)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(1096, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(371, 224)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Sýnýflandýrmalar"
        '
        'VGrid_sinif
        '
        Me.VGrid_sinif.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_sinif.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_sinif.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_sinif.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_sinif.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_sinif.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_sinif.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_sinif.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_sinif.CustomizationFormBounds = New System.Drawing.Rectangle(541, 405, 208, 252)
        Me.VGrid_sinif.DataMember = Nothing
        Me.VGrid_sinif.DataSource = Me.ds_sinif
        Me.VGrid_sinif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_sinif.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_sinif.Location = New System.Drawing.Point(2, 21)
        Me.VGrid_sinif.Name = "VGrid_sinif"
        Me.VGrid_sinif.OptionsBehavior.Editable = False
        Me.VGrid_sinif.RecordWidth = 138
        Me.VGrid_sinif.RowHeaderWidth = 62
        Me.VGrid_sinif.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSýnýf1, Me.rowSýnýf2, Me.rowSýnýf3, Me.rowSýnýf4, Me.rowSýnýf5, Me.rowSýnýf6, Me.rowSýnýf7, Me.rowSýnýf8, Me.rowSýnýf9, Me.rowSýnýf10, Me.rowSýnýf11, Me.rowSýnýf12, Me.rowSýnýf13, Me.rowSýnýf14, Me.rowSýnýf15, Me.EditorRow1})
        Me.VGrid_sinif.Size = New System.Drawing.Size(367, 201)
        Me.VGrid_sinif.TabIndex = 0
        '
        'ds_sinif
        '
        Me.ds_sinif.DataSetName = "NewDataSet"
        Me.ds_sinif.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_sinif.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "Sýnýf1"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "Sýnýf2"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "Sýnýf3"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "Sýnýf4"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "Sýnýf5"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "Sýnýf6"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "Sýnýf7"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "Sýnýf8"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "Sýnýf9"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "Sýnýf10"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "Sýnýf11"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "Sýnýf12"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "Sýnýf13"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "Sýnýf14"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "Sýnýf15"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "nMusteriID"
        Me.DataColumn81.DataType = GetType(Long)
        '
        'rowSýnýf1
        '
        Me.rowSýnýf1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf1.Appearance.Options.UseForeColor = True
        Me.rowSýnýf1.Name = "rowSýnýf1"
        Me.rowSýnýf1.Properties.Caption = "Sýnýf1"
        Me.rowSýnýf1.Properties.FieldName = "Sýnýf1"
        '
        'rowSýnýf2
        '
        Me.rowSýnýf2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf2.Appearance.Options.UseForeColor = True
        Me.rowSýnýf2.Name = "rowSýnýf2"
        Me.rowSýnýf2.Properties.Caption = "Sýnýf2"
        Me.rowSýnýf2.Properties.FieldName = "Sýnýf2"
        '
        'rowSýnýf3
        '
        Me.rowSýnýf3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf3.Appearance.Options.UseForeColor = True
        Me.rowSýnýf3.Name = "rowSýnýf3"
        Me.rowSýnýf3.Properties.Caption = "Sýnýf3"
        Me.rowSýnýf3.Properties.FieldName = "Sýnýf3"
        '
        'rowSýnýf4
        '
        Me.rowSýnýf4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf4.Appearance.Options.UseForeColor = True
        Me.rowSýnýf4.Height = 16
        Me.rowSýnýf4.Name = "rowSýnýf4"
        Me.rowSýnýf4.Properties.Caption = "Sýnýf4"
        Me.rowSýnýf4.Properties.FieldName = "Sýnýf4"
        '
        'rowSýnýf5
        '
        Me.rowSýnýf5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf5.Appearance.Options.UseForeColor = True
        Me.rowSýnýf5.Name = "rowSýnýf5"
        Me.rowSýnýf5.Properties.Caption = "Sýnýf5"
        Me.rowSýnýf5.Properties.FieldName = "Sýnýf5"
        '
        'rowSýnýf6
        '
        Me.rowSýnýf6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf6.Appearance.Options.UseForeColor = True
        Me.rowSýnýf6.Name = "rowSýnýf6"
        Me.rowSýnýf6.Properties.Caption = "Sýnýf6"
        Me.rowSýnýf6.Properties.FieldName = "Sýnýf6"
        '
        'rowSýnýf7
        '
        Me.rowSýnýf7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf7.Appearance.Options.UseForeColor = True
        Me.rowSýnýf7.Name = "rowSýnýf7"
        Me.rowSýnýf7.Properties.Caption = "Sýnýf7"
        Me.rowSýnýf7.Properties.FieldName = "Sýnýf7"
        '
        'rowSýnýf8
        '
        Me.rowSýnýf8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf8.Appearance.Options.UseForeColor = True
        Me.rowSýnýf8.Name = "rowSýnýf8"
        Me.rowSýnýf8.Properties.Caption = "Sýnýf8"
        Me.rowSýnýf8.Properties.FieldName = "Sýnýf8"
        '
        'rowSýnýf9
        '
        Me.rowSýnýf9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf9.Appearance.Options.UseForeColor = True
        Me.rowSýnýf9.Name = "rowSýnýf9"
        Me.rowSýnýf9.Properties.Caption = "Sýnýf9"
        Me.rowSýnýf9.Properties.FieldName = "Sýnýf9"
        '
        'rowSýnýf10
        '
        Me.rowSýnýf10.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf10.Appearance.Options.UseForeColor = True
        Me.rowSýnýf10.Name = "rowSýnýf10"
        Me.rowSýnýf10.Properties.Caption = "Sýnýf10"
        Me.rowSýnýf10.Properties.FieldName = "Sýnýf10"
        '
        'rowSýnýf11
        '
        Me.rowSýnýf11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf11.Appearance.Options.UseForeColor = True
        Me.rowSýnýf11.Name = "rowSýnýf11"
        Me.rowSýnýf11.Properties.Caption = "Sýnýf11"
        Me.rowSýnýf11.Properties.FieldName = "Sýnýf11"
        '
        'rowSýnýf12
        '
        Me.rowSýnýf12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf12.Appearance.Options.UseForeColor = True
        Me.rowSýnýf12.Name = "rowSýnýf12"
        Me.rowSýnýf12.Properties.Caption = "Sýnýf12"
        Me.rowSýnýf12.Properties.FieldName = "Sýnýf12"
        '
        'rowSýnýf13
        '
        Me.rowSýnýf13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf13.Appearance.Options.UseForeColor = True
        Me.rowSýnýf13.Name = "rowSýnýf13"
        Me.rowSýnýf13.Properties.Caption = "Sýnýf13"
        Me.rowSýnýf13.Properties.FieldName = "Sýnýf13"
        '
        'rowSýnýf14
        '
        Me.rowSýnýf14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf14.Appearance.Options.UseForeColor = True
        Me.rowSýnýf14.Name = "rowSýnýf14"
        Me.rowSýnýf14.Properties.Caption = "Sýnýf14"
        Me.rowSýnýf14.Properties.FieldName = "Sýnýf14"
        '
        'rowSýnýf15
        '
        Me.rowSýnýf15.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowSýnýf15.Appearance.Options.UseForeColor = True
        Me.rowSýnýf15.Name = "rowSýnýf15"
        Me.rowSýnýf15.Properties.Caption = "Sýnýf15"
        Me.rowSýnýf15.Properties.FieldName = "Sýnýf15"
        '
        'EditorRow1
        '
        Me.EditorRow1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.EditorRow1.Appearance.Options.UseForeColor = True
        Me.EditorRow1.Name = "EditorRow1"
        Me.EditorRow1.Properties.Caption = "nMusteriID"
        Me.EditorRow1.Properties.FieldName = "nMusteriID"
        Me.EditorRow1.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Gridcontrol2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(445, 224)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "SözleþmeBilgileri"
        '
        'Gridcontrol2
        '
        Me.Gridcontrol2.DataMember = Nothing
        Me.Gridcontrol2.DataSource = Me.ds_sozlesme
        Me.Gridcontrol2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gridcontrol2.Location = New System.Drawing.Point(2, 21)
        Me.Gridcontrol2.MainView = Me.GridView2
        Me.Gridcontrol2.Name = "Gridcontrol2"
        Me.Gridcontrol2.Size = New System.Drawing.Size(441, 201)
        Me.Gridcontrol2.TabIndex = 0
        Me.Gridcontrol2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ds_sozlesme
        '
        Me.ds_sozlesme.DataSetName = "NewDataSet"
        Me.ds_sozlesme.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_sozlesme.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "nMusteriID"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "nKartNo"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "sAciklama"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "dteSonKullanmaTarihi"
        Me.DataColumn48.DataType = GetType(Date)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "sKullaniciAdi"
        Me.DataColumn49.DataType = GetType(System.TimeSpan)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "dteKayitTarihi"
        Me.DataColumn50.DataType = GetType(Date)
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
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID1, Me.colnKartNo, Me.colsAciklama, Me.coldteSonKullanmaTarihi, Me.colsKullaniciAdi1, Me.coldteKayitTarihi1})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.Gridcontrol2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colnMusteriID1
        '
        Me.colnMusteriID1.Caption = "MüþteriNo"
        Me.colnMusteriID1.FieldName = "nMusteriID"
        Me.colnMusteriID1.Name = "colnMusteriID1"
        '
        'colnKartNo
        '
        Me.colnKartNo.Caption = "SözleþmeNo"
        Me.colnKartNo.FieldName = "nKartNo"
        Me.colnKartNo.Name = "colnKartNo"
        Me.colnKartNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nKartNo", "{0} Kayýt")})
        Me.colnKartNo.Visible = True
        Me.colnKartNo.VisibleIndex = 0
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        '
        'coldteSonKullanmaTarihi
        '
        Me.coldteSonKullanmaTarihi.Caption = "SonKulTar."
        Me.coldteSonKullanmaTarihi.FieldName = "dteSonKullanmaTarihi"
        Me.coldteSonKullanmaTarihi.Name = "coldteSonKullanmaTarihi"
        Me.coldteSonKullanmaTarihi.Visible = True
        Me.coldteSonKullanmaTarihi.VisibleIndex = 1
        '
        'colsKullaniciAdi1
        '
        Me.colsKullaniciAdi1.Caption = "Kaydeden"
        Me.colsKullaniciAdi1.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi1.Name = "colsKullaniciAdi1"
        '
        'coldteKayitTarihi1
        '
        Me.coldteKayitTarihi1.Caption = "KayýtTarihi"
        Me.coldteKayitTarihi1.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi1.Name = "coldteKayitTarihi1"
        Me.coldteKayitTarihi1.Visible = True
        Me.coldteKayitTarihi1.VisibleIndex = 2
        '
        'panel_tanimlar
        '
        Me.panel_tanimlar.Controls.Add(Me.VGrid_genel)
        Me.panel_tanimlar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_tanimlar.Location = New System.Drawing.Point(0, 0)
        Me.panel_tanimlar.Name = "panel_tanimlar"
        Me.panel_tanimlar.Size = New System.Drawing.Size(1469, 240)
        Me.panel_tanimlar.TabIndex = 0
        '
        'VGrid_genel
        '
        Me.VGrid_genel.CustomizationFormBounds = New System.Drawing.Rectangle(415, 236, 208, 252)
        Me.VGrid_genel.DataMember = Nothing
        Me.VGrid_genel.DataSource = Me.DataSet1
        Me.VGrid_genel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_genel.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_genel.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_genel.Name = "VGrid_genel"
        Me.VGrid_genel.OptionsBehavior.Editable = False
        Me.VGrid_genel.RowHeaderWidth = 102
        Me.VGrid_genel.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTanýmlar, Me.rowsAdi, Me.rowsSoyadi, Me.categoryEvBilgileri, Me.rowdteKartAcilisTarihi, Me.rowISTIHBARAT, Me.categoryÝþBilgileri, Me.categoryFaturaBilgileri, Me.categoryFinansman, Me.categoryÖzelBilgiler})
        Me.VGrid_genel.Size = New System.Drawing.Size(1465, 236)
        Me.VGrid_genel.TabIndex = 0
        Me.VGrid_genel.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32})
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
        Me.DataColumn6.ColumnName = "Musteri"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nCinsiyet"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = " lAylikGelir"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dteKartAcilisTarihi"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nIskontoPesin"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "nIskontoKredili"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sUnvan"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sVergiDairesi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sVergiNo"
        Me.DataColumn14.DataType = GetType(System.TimeSpan)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "bYazismaEvAdresinemi"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sEmail"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sIsYeriAdi"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sIsAdresi"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sIsTelefonu"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sEvAdresi"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sEvTelefonu"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sSigortaNo"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "bEvlimi"
        Me.DataColumn23.DataType = GetType(Boolean)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "dteEvlilikTarihi"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "dteDogumTarihi"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sDogumYeri"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sEhliyetNo"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sKanGrubu"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dteKayitTarihi"
        Me.DataColumn29.DataType = GetType(Date)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ISTIHBARAT"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sGSM"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sFax"
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.EditorRow2, Me.rowdteKayitTarihi, Me.rowsMagaza, Me.rowlKodu, Me.rowMusteri})
        Me.categoryTanýmlar.Name = "categoryTanýmlar"
        Me.categoryTanýmlar.Properties.Caption = "Tanýmlar"
        '
        'EditorRow2
        '
        Me.EditorRow2.Name = "EditorRow2"
        Me.EditorRow2.Properties.Caption = "KayýtNo"
        Me.EditorRow2.Properties.FieldName = "nMusteriID"
        '
        'rowdteKayitTarihi
        '
        Me.rowdteKayitTarihi.Name = "rowdteKayitTarihi"
        Me.rowdteKayitTarihi.Properties.Caption = "KayitTarihi"
        Me.rowdteKayitTarihi.Properties.FieldName = "dteKayitTarihi"
        '
        'rowsMagaza
        '
        Me.rowsMagaza.Name = "rowsMagaza"
        Me.rowsMagaza.Properties.Caption = "Magaza"
        Me.rowsMagaza.Properties.FieldName = "sMagaza"
        '
        'rowlKodu
        '
        Me.rowlKodu.Name = "rowlKodu"
        Me.rowlKodu.Properties.Caption = "MüþteriKodu"
        Me.rowlKodu.Properties.FieldName = "lKodu"
        '
        'rowMusteri
        '
        Me.rowMusteri.Name = "rowMusteri"
        Me.rowMusteri.Properties.Caption = "Musteri"
        Me.rowMusteri.Properties.FieldName = "Musteri"
        '
        'rowsAdi
        '
        Me.rowsAdi.Name = "rowsAdi"
        Me.rowsAdi.Properties.Caption = "Adi"
        Me.rowsAdi.Properties.FieldName = "sAdi"
        Me.rowsAdi.Visible = False
        '
        'rowsSoyadi
        '
        Me.rowsSoyadi.Name = "rowsSoyadi"
        Me.rowsSoyadi.Properties.Caption = "Soyadi"
        Me.rowsSoyadi.Properties.FieldName = "sSoyadi"
        Me.rowsSoyadi.Visible = False
        '
        'categoryEvBilgileri
        '
        Me.categoryEvBilgileri.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsEvAdresi, Me.rowsEvTelefonu, Me.rowsGSM, Me.rowsEmail, Me.rowbYazismaEvAdresinemi})
        Me.categoryEvBilgileri.Name = "categoryEvBilgileri"
        Me.categoryEvBilgileri.Properties.Caption = "EvBilgileri"
        '
        'rowsEvAdresi
        '
        Me.rowsEvAdresi.Name = "rowsEvAdresi"
        Me.rowsEvAdresi.Properties.Caption = "EvAdresi"
        Me.rowsEvAdresi.Properties.FieldName = "sEvAdresi"
        '
        'rowsEvTelefonu
        '
        Me.rowsEvTelefonu.Name = "rowsEvTelefonu"
        Me.rowsEvTelefonu.Properties.Caption = "EvTelefonu"
        Me.rowsEvTelefonu.Properties.FieldName = "sEvTelefonu"
        '
        'rowsGSM
        '
        Me.rowsGSM.Name = "rowsGSM"
        Me.rowsGSM.Properties.Caption = "GSM"
        Me.rowsGSM.Properties.FieldName = "sGSM"
        '
        'rowsEmail
        '
        Me.rowsEmail.Name = "rowsEmail"
        Me.rowsEmail.Properties.Caption = "Email"
        Me.rowsEmail.Properties.FieldName = "sEmail"
        '
        'rowbYazismaEvAdresinemi
        '
        Me.rowbYazismaEvAdresinemi.Name = "rowbYazismaEvAdresinemi"
        Me.rowbYazismaEvAdresinemi.Properties.Caption = "YazýþmaEvemi?"
        Me.rowbYazismaEvAdresinemi.Properties.FieldName = "bYazismaEvAdresinemi"
        '
        'rowdteKartAcilisTarihi
        '
        Me.rowdteKartAcilisTarihi.Name = "rowdteKartAcilisTarihi"
        Me.rowdteKartAcilisTarihi.Properties.Caption = "KartAçýlýþTarihi"
        Me.rowdteKartAcilisTarihi.Properties.FieldName = "dteKartAcilisTarihi"
        Me.rowdteKartAcilisTarihi.Visible = False
        '
        'rowISTIHBARAT
        '
        Me.rowISTIHBARAT.Name = "rowISTIHBARAT"
        Me.rowISTIHBARAT.Properties.Caption = "istihbarat"
        Me.rowISTIHBARAT.Properties.FieldName = "ISTIHBARAT"
        Me.rowISTIHBARAT.Visible = False
        '
        'categoryÝþBilgileri
        '
        Me.categoryÝþBilgileri.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsIsYeriAdi, Me.rowsIsAdresi, Me.rowsIsTelefonu, Me.rowsFax, Me.rowsSigortaNo, Me.row_lAylikGelir})
        Me.categoryÝþBilgileri.Name = "categoryÝþBilgileri"
        Me.categoryÝþBilgileri.Properties.Caption = "ÝþBilgileri"
        '
        'rowsIsYeriAdi
        '
        Me.rowsIsYeriAdi.Height = 16
        Me.rowsIsYeriAdi.Name = "rowsIsYeriAdi"
        Me.rowsIsYeriAdi.Properties.Caption = "IsYeriAdi"
        Me.rowsIsYeriAdi.Properties.FieldName = "sIsYeriAdi"
        '
        'rowsIsAdresi
        '
        Me.rowsIsAdresi.Name = "rowsIsAdresi"
        Me.rowsIsAdresi.Properties.Caption = "IsAdresi"
        Me.rowsIsAdresi.Properties.FieldName = "sIsAdresi"
        '
        'rowsIsTelefonu
        '
        Me.rowsIsTelefonu.Name = "rowsIsTelefonu"
        Me.rowsIsTelefonu.Properties.Caption = "IsTelefonu"
        Me.rowsIsTelefonu.Properties.FieldName = "sIsTelefonu"
        '
        'rowsFax
        '
        Me.rowsFax.Name = "rowsFax"
        Me.rowsFax.Properties.Caption = "Fax"
        Me.rowsFax.Properties.FieldName = "sFax"
        '
        'rowsSigortaNo
        '
        Me.rowsSigortaNo.Name = "rowsSigortaNo"
        Me.rowsSigortaNo.Properties.Caption = "SigortaNo"
        Me.rowsSigortaNo.Properties.FieldName = "sSigortaNo"
        '
        'row_lAylikGelir
        '
        Me.row_lAylikGelir.Name = "row_lAylikGelir"
        Me.row_lAylikGelir.Properties.Caption = " AylikGelir"
        Me.row_lAylikGelir.Properties.FieldName = " lAylikGelir"
        '
        'categoryFaturaBilgileri
        '
        Me.categoryFaturaBilgileri.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsUnvan, Me.rowsVergiDairesi, Me.rowsVergiNo})
        Me.categoryFaturaBilgileri.Name = "categoryFaturaBilgileri"
        Me.categoryFaturaBilgileri.Properties.Caption = "FaturaBilgileri"
        '
        'rowsUnvan
        '
        Me.rowsUnvan.Name = "rowsUnvan"
        Me.rowsUnvan.Properties.Caption = "Ünvan"
        Me.rowsUnvan.Properties.FieldName = "sUnvan"
        '
        'rowsVergiDairesi
        '
        Me.rowsVergiDairesi.Name = "rowsVergiDairesi"
        Me.rowsVergiDairesi.Properties.Caption = "VergiDairesi"
        Me.rowsVergiDairesi.Properties.FieldName = "sVergiDairesi"
        '
        'rowsVergiNo
        '
        Me.rowsVergiNo.Name = "rowsVergiNo"
        Me.rowsVergiNo.Properties.Caption = "VergiNo"
        Me.rowsVergiNo.Properties.FieldName = "sVergiNo"
        '
        'categoryFinansman
        '
        Me.categoryFinansman.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownIskontoPesin, Me.rownIskontoKredili})
        Me.categoryFinansman.Name = "categoryFinansman"
        Me.categoryFinansman.Properties.Caption = "Finansman"
        '
        'rownIskontoPesin
        '
        Me.rownIskontoPesin.Name = "rownIskontoPesin"
        Me.rownIskontoPesin.Properties.Caption = "PeþinÝskontosu"
        Me.rownIskontoPesin.Properties.FieldName = "nIskontoPesin"
        '
        'rownIskontoKredili
        '
        Me.rownIskontoKredili.Name = "rownIskontoKredili"
        Me.rownIskontoKredili.Properties.Caption = "KrediÝskontosu"
        Me.rownIskontoKredili.Properties.FieldName = "nIskontoKredili"
        '
        'categoryÖzelBilgiler
        '
        Me.categoryÖzelBilgiler.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownCinsiyet, Me.rowbEvlimi, Me.rowdteEvlilikTarihi, Me.rowdteDogumTarihi, Me.rowsDogumYeri, Me.rowsEhliyetNo, Me.rowsKanGrubu})
        Me.categoryÖzelBilgiler.Name = "categoryÖzelBilgiler"
        Me.categoryÖzelBilgiler.Properties.Caption = "ÖzelBilgiler"
        '
        'rownCinsiyet
        '
        Me.rownCinsiyet.Name = "rownCinsiyet"
        Me.rownCinsiyet.Properties.Caption = "Cinsiyet"
        Me.rownCinsiyet.Properties.FieldName = "nCinsiyet"
        '
        'rowbEvlimi
        '
        Me.rowbEvlimi.Name = "rowbEvlimi"
        Me.rowbEvlimi.Properties.Caption = "Evlimi?"
        Me.rowbEvlimi.Properties.FieldName = "bEvlimi"
        '
        'rowdteEvlilikTarihi
        '
        Me.rowdteEvlilikTarihi.Name = "rowdteEvlilikTarihi"
        Me.rowdteEvlilikTarihi.Properties.Caption = "EvlilikTarihi"
        Me.rowdteEvlilikTarihi.Properties.FieldName = "dteEvlilikTarihi"
        '
        'rowdteDogumTarihi
        '
        Me.rowdteDogumTarihi.Name = "rowdteDogumTarihi"
        Me.rowdteDogumTarihi.Properties.Caption = "DogumTarihi"
        Me.rowdteDogumTarihi.Properties.FieldName = "dteDogumTarihi"
        '
        'rowsDogumYeri
        '
        Me.rowsDogumYeri.Name = "rowsDogumYeri"
        Me.rowsDogumYeri.Properties.Caption = "DogumYeri"
        Me.rowsDogumYeri.Properties.FieldName = "sDogumYeri"
        '
        'rowsEhliyetNo
        '
        Me.rowsEhliyetNo.Name = "rowsEhliyetNo"
        Me.rowsEhliyetNo.Properties.Caption = "EhliyetNo"
        Me.rowsEhliyetNo.Properties.FieldName = "sEhliyetNo"
        '
        'rowsKanGrubu
        '
        Me.rowsKanGrubu.Name = "rowsKanGrubu"
        Me.rowsKanGrubu.Properties.Caption = "KanGrubu"
        Me.rowsKanGrubu.Properties.FieldName = "sKanGrubu"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage2.Text = "&Satýþ/Sipariþler"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.PanelControl7)
        Me.PanelControl5.Controls.Add(Me.PanelControl6)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 274)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1469, 486)
        Me.PanelControl5.TabIndex = 1
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.Grid_satis_detay)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(709, 482)
        Me.PanelControl7.TabIndex = 1
        '
        'Grid_satis_detay
        '
        Me.Grid_satis_detay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_detay.Location = New System.Drawing.Point(2, 2)
        Me.Grid_satis_detay.MainView = Me.GridView4
        Me.Grid_satis_detay.Name = "Grid_satis_detay"
        Me.Grid_satis_detay.Size = New System.Drawing.Size(705, 478)
        Me.Grid_satis_detay.TabIndex = 0
        Me.Grid_satis_detay.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
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
        Me.GridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView4.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collKodu, Me.collMusteriAdi, Me.coldteTarih, Me.colsFisTipi, Me.collNo, Me.colsKodu, Me.GridColumn4, Me.colMiktar, Me.colFiyat, Me.colIskonto, Me.collNetTutar, Me.colOdemeTutar, Me.colOdemeTipi, Me.colSaticiRumuzu, Me.colKasiyerRumuzu, Me.colTeslimatci, Me.colOdemeAciklama, Me.colGirisCikis, Me.colMalBedeli, Me.colIadeAvInf, Me.colsHareketTipi, Me.colnIslemId, Me.colStokOdeme, Me.colSevkAciklama, Me.colKalanTaksit, Me.colKayitTarihi, Me.colsFiyatTipi})
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.Grid_satis_detay
        Me.GridView4.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsNavigation.UseTabKey = False
        Me.GridView4.OptionsSelection.MultiSelect = True
        Me.GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        Me.GridView4.ViewCaption = "Satýþ Detaylarý"
        '
        'collKodu
        '
        Me.collKodu.Caption = "MüþteriKodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        '
        'collMusteriAdi
        '
        Me.collMusteriAdi.Caption = "Müþteri"
        Me.collMusteriAdi.FieldName = "lMusteriAdi"
        Me.collMusteriAdi.Name = "collMusteriAdi"
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Width = 67
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "Ýzahat"
        Me.colsFisTipi.FieldName = "fisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Width = 38
        '
        'collNo
        '
        Me.collNo.Caption = "FiþNo"
        Me.collNo.FieldName = "lNo"
        Me.collNo.Name = "collNo"
        Me.collNo.Width = 57
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "StokKodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Width = 66
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "StokAdý"
        Me.GridColumn4.FieldName = "sStokAciklama"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 141
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Miktar"
        Me.colMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.##}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 1
        Me.colMiktar.Width = 43
        '
        'colFiyat
        '
        Me.colFiyat.Caption = "Fiyat"
        Me.colFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 2
        Me.colFiyat.Width = 46
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Ýskonto"
        Me.colIskonto.DisplayFormat.FormatString = "#,0.00"
        Me.colIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        Me.colIskonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.##}")})
        Me.colIskonto.Width = 50
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "NetTutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 3
        Me.collNetTutar.Width = 56
        '
        'colOdemeTutar
        '
        Me.colOdemeTutar.Caption = "Ödenen"
        Me.colOdemeTutar.FieldName = "OdemeTutar"
        Me.colOdemeTutar.Name = "colOdemeTutar"
        Me.colOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OdemeTutar", "{0:#,0.##}")})
        '
        'colOdemeTipi
        '
        Me.colOdemeTipi.Caption = "ÖdemeTipi"
        Me.colOdemeTipi.FieldName = "OdemeTipi"
        Me.colOdemeTipi.Name = "colOdemeTipi"
        '
        'colSaticiRumuzu
        '
        Me.colSaticiRumuzu.Caption = "Satýcý"
        Me.colSaticiRumuzu.FieldName = "SaticiRumuzu"
        Me.colSaticiRumuzu.Name = "colSaticiRumuzu"
        Me.colSaticiRumuzu.Width = 49
        '
        'colKasiyerRumuzu
        '
        Me.colKasiyerRumuzu.Caption = "Kasiyer"
        Me.colKasiyerRumuzu.FieldName = "KasiyerRumuzu"
        Me.colKasiyerRumuzu.Name = "colKasiyerRumuzu"
        Me.colKasiyerRumuzu.Width = 79
        '
        'colTeslimatci
        '
        Me.colTeslimatci.Caption = "Teslimatçý"
        Me.colTeslimatci.FieldName = "Teslimatci"
        Me.colTeslimatci.Name = "colTeslimatci"
        '
        'colOdemeAciklama
        '
        Me.colOdemeAciklama.Caption = "ÖdemeAçýklamasý"
        Me.colOdemeAciklama.FieldName = "OdemeAciklama"
        Me.colOdemeAciklama.Name = "colOdemeAciklama"
        '
        'colGirisCikis
        '
        Me.colGirisCikis.Caption = "GiriþÇýkýþ"
        Me.colGirisCikis.FieldName = "GirisCikis"
        Me.colGirisCikis.Name = "colGirisCikis"
        '
        'colMalBedeli
        '
        Me.colMalBedeli.Caption = "ÜrünBedeli"
        Me.colMalBedeli.FieldName = "MalBedeli"
        Me.colMalBedeli.Name = "colMalBedeli"
        Me.colMalBedeli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MalBedeli", "{0:#,0.##}")})
        '
        'colIadeAvInf
        '
        Me.colIadeAvInf.Caption = "ÝadeÝnfo"
        Me.colIadeAvInf.FieldName = "IadeAvInf"
        Me.colIadeAvInf.Name = "colIadeAvInf"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "HareketTipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colnIslemId
        '
        Me.colnIslemId.Caption = "ÝþlemKayýtNo"
        Me.colnIslemId.FieldName = "nIslemId"
        Me.colnIslemId.Name = "colnIslemId"
        '
        'colStokOdeme
        '
        Me.colStokOdeme.Caption = "StokÖdeme"
        Me.colStokOdeme.FieldName = "StokOdeme"
        Me.colStokOdeme.Name = "colStokOdeme"
        '
        'colSevkAciklama
        '
        Me.colSevkAciklama.Caption = "SevkAciklama"
        Me.colSevkAciklama.FieldName = "SevkAciklama"
        Me.colSevkAciklama.Name = "colSevkAciklama"
        '
        'colKalanTaksit
        '
        Me.colKalanTaksit.Caption = "KalanTaksit"
        Me.colKalanTaksit.FieldName = "KalanTaksit"
        Me.colKalanTaksit.Name = "colKalanTaksit"
        '
        'colKayitTarihi
        '
        Me.colKayitTarihi.Caption = "KayýtTarihi"
        Me.colKayitTarihi.FieldName = "KayitTarihi"
        Me.colKayitTarihi.Name = "colKayitTarihi"
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 4
        Me.colsFiyatTipi.Width = 49
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.Grid_satis_odeme)
        Me.PanelControl6.Controls.Add(Me.Grid_satis_kapatma)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl6.Location = New System.Drawing.Point(711, 2)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(756, 482)
        Me.PanelControl6.TabIndex = 0
        '
        'Grid_satis_odeme
        '
        Me.Grid_satis_odeme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_odeme.Location = New System.Drawing.Point(370, 2)
        Me.Grid_satis_odeme.MainView = Me.GridView6
        Me.Grid_satis_odeme.Name = "Grid_satis_odeme"
        Me.Grid_satis_odeme.Size = New System.Drawing.Size(384, 478)
        Me.Grid_satis_odeme.TabIndex = 1
        Me.Grid_satis_odeme.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
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
        Me.GridView6.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView6.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFis_Musteri_TanimlamaNo, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.colOdeme_Kodu, Me.colOdeme_Sekli, Me.colOdeme_Sekli_Aciklamasi, Me.colAlan_Kasiyer_Rumuzu, Me.colAlan_Kasiyer_Adi, Me.colAlan_Kasiyer_Soyadi, Me.colTarihi, Me.colTutari, Me.colDovizCinsi, Me.colDovizTutari, Me.colMakbuzNo, Me.colOdemeNo, Me.colAlisveris_Tarihi, Me.colAlisveris_FaturaNo, Me.colAlisveris_HareketTipi, Me.colAlisVeris_sFisTipi, Me.GridColumn8, Me.colGECIKME})
        Me.GridView6.CustomizationFormBounds = New System.Drawing.Rectangle(492, 237, 208, 156)
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colGECIKME
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colGECIKME
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView6.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView6.GridControl = Me.Grid_satis_odeme
        Me.GridView6.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView6.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", Nothing, "Ödenen : {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", Nothing, "ToplamÖdenen: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", Me.GridColumn8, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", Me.colTutari, "{0:#,0.00}")})
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsNavigation.UseTabKey = False
        Me.GridView6.OptionsPrint.ExpandAllGroups = False
        Me.GridView6.OptionsSelection.MultiSelect = True
        Me.GridView6.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'colFis_Musteri_TanimlamaNo
        '
        Me.colFis_Musteri_TanimlamaNo.Caption = "MüþteriNo"
        Me.colFis_Musteri_TanimlamaNo.FieldName = "Fis_Musteri_TanimlamaNo"
        Me.colFis_Musteri_TanimlamaNo.Name = "colFis_Musteri_TanimlamaNo"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "MüþteriKodu"
        Me.GridColumn5.FieldName = "Fis_Musteri_Kodu"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fis_Musteri_Kodu", "{0} Kayýt")})
        Me.GridColumn5.Width = 57
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "MüþteriAdý"
        Me.GridColumn6.FieldName = "Fis_Musteri_Adi"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Width = 67
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "MüþteriSoyadý"
        Me.GridColumn7.FieldName = "Fis_Musteri_Soyadi"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'colOdeme_Kodu
        '
        Me.colOdeme_Kodu.Caption = "ÖdemeKodu"
        Me.colOdeme_Kodu.FieldName = "Odeme_Kodu"
        Me.colOdeme_Kodu.Name = "colOdeme_Kodu"
        '
        'colOdeme_Sekli
        '
        Me.colOdeme_Sekli.Caption = "ÖdemeÞekli"
        Me.colOdeme_Sekli.FieldName = "Odeme_Sekli"
        Me.colOdeme_Sekli.Name = "colOdeme_Sekli"
        '
        'colOdeme_Sekli_Aciklamasi
        '
        Me.colOdeme_Sekli_Aciklamasi.Caption = "Ödeme"
        Me.colOdeme_Sekli_Aciklamasi.FieldName = "Odeme_Sekli_Aciklamasi"
        Me.colOdeme_Sekli_Aciklamasi.Name = "colOdeme_Sekli_Aciklamasi"
        Me.colOdeme_Sekli_Aciklamasi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Odeme_Sekli_Aciklamasi", "{0} Kayýt")})
        Me.colOdeme_Sekli_Aciklamasi.Visible = True
        Me.colOdeme_Sekli_Aciklamasi.VisibleIndex = 0
        Me.colOdeme_Sekli_Aciklamasi.Width = 46
        '
        'colAlan_Kasiyer_Rumuzu
        '
        Me.colAlan_Kasiyer_Rumuzu.Caption = "KasiyerKodu"
        Me.colAlan_Kasiyer_Rumuzu.FieldName = "Alan_Kasiyer_Rumuzu"
        Me.colAlan_Kasiyer_Rumuzu.Name = "colAlan_Kasiyer_Rumuzu"
        Me.colAlan_Kasiyer_Rumuzu.Width = 108
        '
        'colAlan_Kasiyer_Adi
        '
        Me.colAlan_Kasiyer_Adi.Caption = "KasiyerAdý"
        Me.colAlan_Kasiyer_Adi.FieldName = "Alan_Kasiyer_Adi"
        Me.colAlan_Kasiyer_Adi.Name = "colAlan_Kasiyer_Adi"
        Me.colAlan_Kasiyer_Adi.Width = 69
        '
        'colAlan_Kasiyer_Soyadi
        '
        Me.colAlan_Kasiyer_Soyadi.Caption = "KasiyerSoyadý"
        Me.colAlan_Kasiyer_Soyadi.FieldName = "Alan_Kasiyer_Soyadi"
        Me.colAlan_Kasiyer_Soyadi.Name = "colAlan_Kasiyer_Soyadi"
        '
        'colTarihi
        '
        Me.colTarihi.Caption = "Tarih"
        Me.colTarihi.DisplayFormat.FormatString = "dd.MM.yy"
        Me.colTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTarihi.FieldName = "Tarihi"
        Me.colTarihi.GroupFormat.FormatString = "d"
        Me.colTarihi.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTarihi.Name = "colTarihi"
        Me.colTarihi.Visible = True
        Me.colTarihi.VisibleIndex = 2
        Me.colTarihi.Width = 58
        '
        'colTutari
        '
        Me.colTutari.Caption = "Tutar"
        Me.colTutari.DisplayFormat.FormatString = "#,0.00"
        Me.colTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutari.FieldName = "Tutari"
        Me.colTutari.Name = "colTutari"
        Me.colTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", "{0:#,0.00}")})
        Me.colTutari.Visible = True
        Me.colTutari.VisibleIndex = 3
        Me.colTutari.Width = 50
        '
        'colDovizCinsi
        '
        Me.colDovizCinsi.Caption = "pb"
        Me.colDovizCinsi.FieldName = "DovizCinsi"
        Me.colDovizCinsi.Name = "colDovizCinsi"
        Me.colDovizCinsi.Width = 108
        '
        'colDovizTutari
        '
        Me.colDovizTutari.Caption = "DövizTutar"
        Me.colDovizTutari.FieldName = "DovizTutari"
        Me.colDovizTutari.Name = "colDovizTutari"
        Me.colDovizTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DovizTutari", "{0:#,0.00}")})
        Me.colDovizTutari.Width = 111
        '
        'colMakbuzNo
        '
        Me.colMakbuzNo.Caption = "MakbuzNo"
        Me.colMakbuzNo.FieldName = "MakbuzNo"
        Me.colMakbuzNo.Name = "colMakbuzNo"
        Me.colMakbuzNo.Width = 50
        '
        'colOdemeNo
        '
        Me.colOdemeNo.Caption = "OdemeNo"
        Me.colOdemeNo.FieldName = "OdemeNo"
        Me.colOdemeNo.Name = "colOdemeNo"
        '
        'colAlisveris_Tarihi
        '
        Me.colAlisveris_Tarihi.Caption = "AlýþVeriþTarihi"
        Me.colAlisveris_Tarihi.FieldName = "Alisveris_Tarihi"
        Me.colAlisveris_Tarihi.Name = "colAlisveris_Tarihi"
        Me.colAlisveris_Tarihi.Width = 77
        '
        'colAlisveris_FaturaNo
        '
        Me.colAlisveris_FaturaNo.Caption = "AlýþveriþNo"
        Me.colAlisveris_FaturaNo.FieldName = "Alisveris_FaturaNo"
        Me.colAlisveris_FaturaNo.Name = "colAlisveris_FaturaNo"
        '
        'colAlisveris_HareketTipi
        '
        Me.colAlisveris_HareketTipi.Caption = "AlýþveriþHareketTipi"
        Me.colAlisveris_HareketTipi.FieldName = "Alisveris_HareketTipi"
        Me.colAlisveris_HareketTipi.Name = "colAlisveris_HareketTipi"
        '
        'colAlisVeris_sFisTipi
        '
        Me.colAlisVeris_sFisTipi.Caption = "AlisVerisFisTipi"
        Me.colAlisVeris_sFisTipi.FieldName = "AlisVeris_sFistipi"
        Me.colAlisVeris_sFisTipi.Name = "colAlisVeris_sFisTipi"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Vadesi"
        Me.GridColumn8.DisplayFormat.FormatString = "dd.MM"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn8.FieldName = "Taksit_Tarihi"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 42
        '
        'Grid_satis_kapatma
        '
        Me.Grid_satis_kapatma.Dock = System.Windows.Forms.DockStyle.Left
        Me.Grid_satis_kapatma.Location = New System.Drawing.Point(2, 2)
        Me.Grid_satis_kapatma.MainView = Me.GridView5
        Me.Grid_satis_kapatma.Name = "Grid_satis_kapatma"
        Me.Grid_satis_kapatma.Size = New System.Drawing.Size(368, 478)
        Me.Grid_satis_kapatma.TabIndex = 0
        Me.Grid_satis_kapatma.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
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
        Me.GridView5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView5.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFis_TanimlamaNo, Me.colFis_Tipi, Me.colFis_Musteri_Tanimlama_No, Me.colFis_Musteri_Kodu, Me.colFis_Musteri_Adi, Me.colFis_Musteri_Soyadi, Me.colTaksit_Fis_TanimlamaNo, Me.colTaksit_Tarihi, Me.colTaksit_Tutari, Me.colAlisveris_TanimlamaNo, Me.colMusteri_Taksiti, Me.colOdeme_tutar})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(556, 305, 208, 170)
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colMusteri_Taksiti
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition3.Tag = "0"
        StyleFormatCondition3.Value1 = "0"
        Me.GridView5.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.GridView5.GridControl = Me.Grid_satis_kapatma
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lToplamMiktar", Nothing, "{0:#,0.##} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lNetTutar", Nothing, "ToplamTutar : {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "Kalan  {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "Tutarý  : {0:#,0.00}")})
        Me.GridView5.IndicatorWidth = 12
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsPrint.ExpandAllGroups = False
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        Me.GridView5.ViewCaption = "Satýþa Yapýlan Taksitler"
        '
        'colFis_TanimlamaNo
        '
        Me.colFis_TanimlamaNo.Caption = "FiþNo"
        Me.colFis_TanimlamaNo.FieldName = "Fis_TanimlamaNo"
        Me.colFis_TanimlamaNo.Name = "colFis_TanimlamaNo"
        Me.colFis_TanimlamaNo.Width = 67
        '
        'colFis_Tipi
        '
        Me.colFis_Tipi.Caption = "FiþTipi"
        Me.colFis_Tipi.FieldName = "Fis_Tipi"
        Me.colFis_Tipi.Name = "colFis_Tipi"
        Me.colFis_Tipi.Width = 34
        '
        'colFis_Musteri_Tanimlama_No
        '
        Me.colFis_Musteri_Tanimlama_No.Caption = "MüþteriNo"
        Me.colFis_Musteri_Tanimlama_No.FieldName = "Fis_Musteri_Tanimlama_No"
        Me.colFis_Musteri_Tanimlama_No.Name = "colFis_Musteri_Tanimlama_No"
        '
        'colFis_Musteri_Kodu
        '
        Me.colFis_Musteri_Kodu.Caption = "MüþteriKodu"
        Me.colFis_Musteri_Kodu.FieldName = "Fis_Musteri_Kodu"
        Me.colFis_Musteri_Kodu.Name = "colFis_Musteri_Kodu"
        Me.colFis_Musteri_Kodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fis_Musteri_Kodu", "{0} Kayýt")})
        Me.colFis_Musteri_Kodu.Width = 67
        '
        'colFis_Musteri_Adi
        '
        Me.colFis_Musteri_Adi.Caption = "MüþteriAdý"
        Me.colFis_Musteri_Adi.FieldName = "Fis_Musteri_Adi"
        Me.colFis_Musteri_Adi.Name = "colFis_Musteri_Adi"
        Me.colFis_Musteri_Adi.Width = 77
        '
        'colFis_Musteri_Soyadi
        '
        Me.colFis_Musteri_Soyadi.Caption = "MüþteriSoyadý"
        Me.colFis_Musteri_Soyadi.FieldName = "Fis_Musteri_Soyadi"
        Me.colFis_Musteri_Soyadi.Name = "colFis_Musteri_Soyadi"
        Me.colFis_Musteri_Soyadi.Width = 94
        '
        'colTaksit_Fis_TanimlamaNo
        '
        Me.colTaksit_Fis_TanimlamaNo.Caption = "TaksitFiþNo"
        Me.colTaksit_Fis_TanimlamaNo.FieldName = "Taksit_Fis_TanimlamaNo"
        Me.colTaksit_Fis_TanimlamaNo.Name = "colTaksit_Fis_TanimlamaNo"
        '
        'colTaksit_Tarihi
        '
        Me.colTaksit_Tarihi.Caption = "Tarih"
        Me.colTaksit_Tarihi.DisplayFormat.FormatString = "dd.MM.yy"
        Me.colTaksit_Tarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTaksit_Tarihi.FieldName = "Taksit_Tarihi"
        Me.colTaksit_Tarihi.Name = "colTaksit_Tarihi"
        Me.colTaksit_Tarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", "{0} Kayýt")})
        Me.colTaksit_Tarihi.Visible = True
        Me.colTaksit_Tarihi.VisibleIndex = 0
        Me.colTaksit_Tarihi.Width = 52
        '
        'colTaksit_Tutari
        '
        Me.colTaksit_Tutari.Caption = "Tutar"
        Me.colTaksit_Tutari.DisplayFormat.FormatString = "#,0.00"
        Me.colTaksit_Tutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTaksit_Tutari.FieldName = "Taksit_Tutari"
        Me.colTaksit_Tutari.Name = "colTaksit_Tutari"
        Me.colTaksit_Tutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Taksit_Tutari", "{0:#,0.00}")})
        Me.colTaksit_Tutari.Visible = True
        Me.colTaksit_Tutari.VisibleIndex = 1
        Me.colTaksit_Tutari.Width = 47
        '
        'colAlisveris_TanimlamaNo
        '
        Me.colAlisveris_TanimlamaNo.Caption = "AlýþVeriþNo"
        Me.colAlisveris_TanimlamaNo.FieldName = "Alisveris_TanimlamaNo"
        Me.colAlisveris_TanimlamaNo.Name = "colAlisveris_TanimlamaNo"
        '
        'colOdeme_tutar
        '
        Me.colOdeme_tutar.Caption = "Ödenen"
        Me.colOdeme_tutar.DisplayFormat.FormatString = "#,0.00"
        Me.colOdeme_tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOdeme_tutar.FieldName = "Odeme_tutar"
        Me.colOdeme_tutar.Name = "colOdeme_tutar"
        Me.colOdeme_tutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Odeme_tutar", "{0:#,0.00}")})
        Me.colOdeme_tutar.Visible = True
        Me.colOdeme_tutar.VisibleIndex = 2
        Me.colOdeme_tutar.Width = 55
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.Grid_satis)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1469, 274)
        Me.PanelControl4.TabIndex = 0
        '
        'Grid_satis
        '
        Me.Grid_satis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis.Location = New System.Drawing.Point(2, 2)
        Me.Grid_satis.MainView = Me.GridView3
        Me.Grid_satis.Name = "Grid_satis"
        Me.Grid_satis.Size = New System.Drawing.Size(1465, 270)
        Me.Grid_satis.TabIndex = 0
        Me.Grid_satis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
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
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.coldteFaturaTarihi, Me.colnGirisCikis, Me.collToplamMiktar, Me.collPesinat, Me.GridColumn2, Me.collFaturaNo, Me.colsMagaza, Me.colsKasiyerRumuzu, Me.colnKasaNo, Me.GridColumn3, Me.colsYaziIle, Me.colnAlisverisID})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(680, 301, 208, 170)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.Grid_satis
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        Me.GridView3.ViewCaption = "Yapýlan Satýþlar"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Ýzah"
        Me.GridColumn1.FieldName = "sFisTipi"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 41
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.DisplayFormat.FormatString = "d"
        Me.coldteFaturaTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFaturaTarihi", "{0} Kayýt")})
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 62
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "BelgeTipi"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Visible = True
        Me.colnGirisCikis.VisibleIndex = 2
        Me.colnGirisCikis.Width = 62
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
        Me.collToplamMiktar.Width = 48
        '
        'collPesinat
        '
        Me.collPesinat.Caption = "Peþinat"
        Me.collPesinat.DisplayFormat.FormatString = "#,0.00"
        Me.collPesinat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPesinat.FieldName = "lPesinat"
        Me.collPesinat.Name = "collPesinat"
        Me.collPesinat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPesinat", "{0:#,0.00}")})
        Me.collPesinat.Visible = True
        Me.collPesinat.VisibleIndex = 5
        Me.collPesinat.Width = 61
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tutar"
        Me.GridColumn2.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "lNetTutar"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 50
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "FiþNo"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 3
        Me.collFaturaNo.Width = 71
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.Visible = True
        Me.colsMagaza.VisibleIndex = 11
        Me.colsMagaza.Width = 103
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Visible = True
        Me.colsKasiyerRumuzu.VisibleIndex = 8
        Me.colsKasiyerRumuzu.Width = 45
        '
        'colnKasaNo
        '
        Me.colnKasaNo.Caption = "KasaNo"
        Me.colnKasaNo.FieldName = "nKasaNo"
        Me.colnKasaNo.Name = "colnKasaNo"
        Me.colnKasaNo.Visible = True
        Me.colnKasaNo.VisibleIndex = 9
        Me.colnKasaNo.Width = 48
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Saat"
        Me.GridColumn3.DisplayFormat.FormatString = "HH:mm"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "dteKayitTarihi"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 7
        Me.GridColumn3.Width = 56
        '
        'colsYaziIle
        '
        Me.colsYaziIle.Caption = "YazýÝle"
        Me.colsYaziIle.FieldName = "sYaziIle"
        Me.colsYaziIle.Name = "colsYaziIle"
        Me.colsYaziIle.Visible = True
        Me.colsYaziIle.VisibleIndex = 10
        Me.colsYaziIle.Width = 148
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "KayýtNo"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupControl7)
        Me.XtraTabPage3.Controls.Add(Me.SplitterControl1)
        Me.XtraTabPage3.Controls.Add(Me.GroupControl6)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage3.Text = "&ÖdemelerAnalizi"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.grid_odemeler_kalan)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl7.Location = New System.Drawing.Point(755, 0)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(714, 760)
        Me.GroupControl7.TabIndex = 2
        Me.GroupControl7.Text = "Kalan Ödemeler"
        '
        'grid_odemeler_kalan
        '
        Me.grid_odemeler_kalan.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.grid_odemeler_kalan.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.grid_odemeler_kalan.Appearance.Empty.Options.UseBackColor = True
        Me.grid_odemeler_kalan.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.Silver
        Me.grid_odemeler_kalan.Appearance.FieldValueGrandTotal.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grid_odemeler_kalan.Appearance.FieldValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.grid_odemeler_kalan.Appearance.FieldValueGrandTotal.Options.UseBackColor = True
        Me.grid_odemeler_kalan.Appearance.FieldValueGrandTotal.Options.UseForeColor = True
        Me.grid_odemeler_kalan.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grid_odemeler_kalan.Appearance.GrandTotalCell.ForeColor = System.Drawing.Color.Black
        Me.grid_odemeler_kalan.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.grid_odemeler_kalan.Appearance.GrandTotalCell.Options.UseForeColor = True
        Me.grid_odemeler_kalan.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grid_odemeler_kalan.Appearance.TotalCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grid_odemeler_kalan.Appearance.TotalCell.ForeColor = System.Drawing.Color.Black
        Me.grid_odemeler_kalan.Appearance.TotalCell.Options.UseBackColor = True
        Me.grid_odemeler_kalan.Appearance.TotalCell.Options.UseForeColor = True
        Me.grid_odemeler_kalan.Cursor = System.Windows.Forms.Cursors.Default
        Me.grid_odemeler_kalan.DataMember = Nothing
        Me.grid_odemeler_kalan.DataSource = Me.DataSet1
        Me.grid_odemeler_kalan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_odemeler_kalan.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17, Me.PivotGridField18, Me.PivotGridField19, Me.PivotGridField20})
        Me.grid_odemeler_kalan.Location = New System.Drawing.Point(2, 21)
        Me.grid_odemeler_kalan.Name = "grid_odemeler_kalan"
        Me.grid_odemeler_kalan.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.grid_odemeler_kalan.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_odemeler_kalan.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_odemeler_kalan.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_odemeler_kalan.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_odemeler_kalan.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_odemeler_kalan.OptionsView.ShowColumnHeaders = False
        Me.grid_odemeler_kalan.OptionsView.ShowDataHeaders = False
        Me.grid_odemeler_kalan.Size = New System.Drawing.Size(710, 737)
        Me.grid_odemeler_kalan.TabIndex = 1
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "MüþteriNo"
        Me.PivotGridField1.FieldName = "nMusteriID"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "MüþteriKodu"
        Me.PivotGridField2.FieldName = "kodu"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.Visible = False
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Tutar"
        Me.PivotGridField3.CellFormat.FormatString = "#,0.00"
        Me.PivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField3.FieldName = "TUTAR"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.Width = 64
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.Caption = "Ödenen"
        Me.PivotGridField4.CellFormat.FormatString = "#,0.00"
        Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField4.FieldName = "TAHSILAT"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.Width = 60
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 2
        Me.PivotGridField5.Caption = "Kalan"
        Me.PivotGridField5.CellFormat.FormatString = "#,0.00"
        Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField5.FieldName = "KALAN"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.Width = 58
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField6.AreaIndex = 1
        Me.PivotGridField6.Caption = "Ay"
        Me.PivotGridField6.FieldName = "AY"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.Width = 83
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField7.AreaIndex = 0
        Me.PivotGridField7.Caption = "Yýl"
        Me.PivotGridField7.FieldName = "YIL"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.Width = 60
        '
        'PivotGridField8
        '
        Me.PivotGridField8.AreaIndex = 3
        Me.PivotGridField8.Caption = "Tarih"
        Me.PivotGridField8.FieldName = "dteTarihi"
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.Width = 37
        '
        'PivotGridField9
        '
        Me.PivotGridField9.AreaIndex = 1
        Me.PivotGridField9.Caption = "FiþTipi"
        Me.PivotGridField9.FieldName = "sFisTipi"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.AreaIndex = 2
        Me.PivotGridField10.Caption = "AlýþVeriþTarihi"
        Me.PivotGridField10.CellFormat.FormatString = "d"
        Me.PivotGridField10.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField10.FieldName = "dteFaturaTarihi"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.AreaIndex = 4
        Me.PivotGridField11.Caption = "FaturaNo"
        Me.PivotGridField11.FieldName = "lFaturaNo"
        Me.PivotGridField11.Name = "PivotGridField11"
        Me.PivotGridField11.Visible = False
        '
        'PivotGridField12
        '
        Me.PivotGridField12.AreaIndex = 4
        Me.PivotGridField12.Caption = "ToplamMiktar"
        Me.PivotGridField12.FieldName = "lToplamMiktar"
        Me.PivotGridField12.Name = "PivotGridField12"
        Me.PivotGridField12.Visible = False
        '
        'PivotGridField13
        '
        Me.PivotGridField13.AreaIndex = 4
        Me.PivotGridField13.Caption = "Peþinat"
        Me.PivotGridField13.FieldName = "lPesinat"
        Me.PivotGridField13.Name = "PivotGridField13"
        Me.PivotGridField13.Visible = False
        '
        'PivotGridField14
        '
        Me.PivotGridField14.AreaIndex = 8
        Me.PivotGridField14.Caption = "FaturaTutarý"
        Me.PivotGridField14.FieldName = "lNetTutar"
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.Visible = False
        '
        'PivotGridField15
        '
        Me.PivotGridField15.AreaIndex = 9
        Me.PivotGridField15.Caption = "YazýlÝle"
        Me.PivotGridField15.FieldName = "sYaziIle"
        Me.PivotGridField15.Name = "PivotGridField15"
        Me.PivotGridField15.Visible = False
        '
        'PivotGridField16
        '
        Me.PivotGridField16.AreaIndex = 10
        Me.PivotGridField16.Caption = "KasaNo"
        Me.PivotGridField16.FieldName = "nKasaNo"
        Me.PivotGridField16.Name = "PivotGridField16"
        Me.PivotGridField16.Visible = False
        '
        'PivotGridField17
        '
        Me.PivotGridField17.AreaIndex = 11
        Me.PivotGridField17.Caption = "KayýtSaati"
        Me.PivotGridField17.FieldName = "dteKayitTarihi"
        Me.PivotGridField17.Name = "PivotGridField17"
        Me.PivotGridField17.Visible = False
        '
        'PivotGridField18
        '
        Me.PivotGridField18.AreaIndex = 4
        Me.PivotGridField18.Caption = "AlýþVeriþNo"
        Me.PivotGridField18.FieldName = "nAlisverisID"
        Me.PivotGridField18.Name = "PivotGridField18"
        Me.PivotGridField18.Visible = False
        '
        'PivotGridField19
        '
        Me.PivotGridField19.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField19.AreaIndex = 0
        Me.PivotGridField19.Caption = "Ad"
        Me.PivotGridField19.FieldName = "sAdi"
        Me.PivotGridField19.Name = "PivotGridField19"
        '
        'PivotGridField20
        '
        Me.PivotGridField20.AreaIndex = 4
        Me.PivotGridField20.Caption = "Soyad"
        Me.PivotGridField20.FieldName = "sSoyadi"
        Me.PivotGridField20.Name = "PivotGridField20"
        Me.PivotGridField20.Visible = False
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(749, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 760)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.Grid_odemeler)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl6.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(749, 760)
        Me.GroupControl6.TabIndex = 0
        Me.GroupControl6.Text = "Yapýlan Ödemeler"
        '
        'Grid_odemeler
        '
        Me.Grid_odemeler.DataMember = "Table1"
        Me.Grid_odemeler.DataSource = Me.DataSet1
        Me.Grid_odemeler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_odemeler.Location = New System.Drawing.Point(2, 21)
        Me.Grid_odemeler.MainView = Me.GridView7
        Me.Grid_odemeler.Name = "Grid_odemeler"
        Me.Grid_odemeler.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.Grid_odemeler.Size = New System.Drawing.Size(745, 737)
        Me.Grid_odemeler.TabIndex = 1
        Me.Grid_odemeler.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
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
        Me.GridView7.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView7.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn65})
        Me.GridView7.CustomizationFormBounds = New System.Drawing.Rectangle(556, 371, 208, 156)
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.GridColumn30
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition4.Tag = "0"
        StyleFormatCondition4.Value1 = "0"
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.GridColumn30
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition5.Tag = "0"
        StyleFormatCondition5.Value1 = "0"
        Me.GridView7.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition4, StyleFormatCondition5})
        Me.GridView7.GridControl = Me.Grid_odemeler
        Me.GridView7.GroupCount = 1
        Me.GridView7.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView7.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", Nothing, "Ödenen : {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", Nothing, "ToplamÖdenen: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", Me.GridColumn29, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", Me.GridColumn20, "{0:#,0.00}")})
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsNavigation.UseTabKey = False
        Me.GridView7.OptionsPrint.ExpandAllGroups = False
        Me.GridView7.OptionsSelection.MultiSelect = True
        Me.GridView7.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowIndicator = False
        Me.GridView7.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn19, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "MüþteriNo"
        Me.GridColumn9.FieldName = "Fis_Musteri_TanimlamaNo"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "MüþteriKodu"
        Me.GridColumn10.FieldName = "Fis_Musteri_Kodu"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fis_Musteri_Kodu", "{0} Kayýt")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 57
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "MüþteriAdý"
        Me.GridColumn11.FieldName = "Fis_Musteri_Adi"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 67
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "MüþteriSoyadý"
        Me.GridColumn12.FieldName = "Fis_Musteri_Soyadi"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "ÖdemeKodu"
        Me.GridColumn13.FieldName = "Odeme_Kodu"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "ÖdemeÞekli"
        Me.GridColumn14.FieldName = "Odeme_Sekli"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Ödeme"
        Me.GridColumn15.FieldName = "Odeme_Sekli_Aciklamasi"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 4
        Me.GridColumn15.Width = 47
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "KasiyerKodu"
        Me.GridColumn16.FieldName = "Alan_Kasiyer_Rumuzu"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Width = 108
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "KasiyerAdý"
        Me.GridColumn17.FieldName = "Alan_Kasiyer_Adi"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 5
        Me.GridColumn17.Width = 69
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "KasiyerSoyadý"
        Me.GridColumn18.FieldName = "Alan_Kasiyer_Soyadi"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Tarih"
        Me.GridColumn19.DisplayFormat.FormatString = "D"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn19.FieldName = "Tarihi"
        Me.GridColumn19.GroupFormat.FormatString = "d"
        Me.GridColumn19.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Width = 69
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Tutar"
        Me.GridColumn20.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "Tutari"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", "{0:#,0.00}")})
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 7
        Me.GridColumn20.Width = 69
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "pb"
        Me.GridColumn21.FieldName = "DovizCinsi"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Width = 108
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "DövizTutar"
        Me.GridColumn22.FieldName = "DovizTutari"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DovizTutari", "{0:#,0.00}")})
        Me.GridColumn22.Width = 111
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "MakbuzNo"
        Me.GridColumn23.FieldName = "MakbuzNo"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 1
        Me.GridColumn23.Width = 50
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "OdemeNo"
        Me.GridColumn24.FieldName = "OdemeNo"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "AlýþVeriþTarihi"
        Me.GridColumn25.FieldName = "Alisveris_Tarihi"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 0
        Me.GridColumn25.Width = 77
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "AlýþveriþNo"
        Me.GridColumn26.FieldName = "Alisveris_FaturaNo"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "AlýþveriþHareketTipi"
        Me.GridColumn27.FieldName = "Alisveris_HareketTipi"
        Me.GridColumn27.Name = "GridColumn27"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "AlisVerisFisTipi"
        Me.GridColumn28.FieldName = "AlisVeris_sFistipi"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "TaksitTarihi"
        Me.GridColumn29.FieldName = "Taksit_Tarihi"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 6
        Me.GridColumn29.Width = 69
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "Saat"
        Me.GridColumn65.DisplayFormat.FormatString = "HH:mm"
        Me.GridColumn65.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn65.FieldName = "dteKayitTarihi"
        Me.GridColumn65.Name = "GridColumn65"
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_renk.ShowFooter = False
        Me.sec_renk.ShowHeader = False
        Me.sec_renk.ShowLines = False
        Me.sec_renk.ValueMember = "sRenk"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Grid_bekleyen)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage4.Text = "&BekleyenAlýþveriþler"
        '
        'Grid_bekleyen
        '
        Me.Grid_bekleyen.ContextMenu = Me.Context_bekleyen
        Me.Grid_bekleyen.DataMember = "Table1"
        Me.Grid_bekleyen.DataSource = Me.DataSet1
        Me.Grid_bekleyen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_bekleyen.Location = New System.Drawing.Point(0, 0)
        Me.Grid_bekleyen.MainView = Me.GridView8
        Me.Grid_bekleyen.Name = "Grid_bekleyen"
        Me.Grid_bekleyen.Size = New System.Drawing.Size(1469, 760)
        Me.Grid_bekleyen.TabIndex = 1
        Me.Grid_bekleyen.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'Context_bekleyen
        '
        Me.Context_bekleyen.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem14, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem15, Me.MenuItem10, Me.MenuItem11, Me.MenuItem16, Me.MenuItem12, Me.MenuItem13, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem5.Text = "Envanter"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "Görünümü Düzenle"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 4
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 5
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 6
        Me.MenuItem15.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 8
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 9
        Me.MenuItem16.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 10
        Me.MenuItem12.Text = "Satýrlarý Aç"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 11
        Me.MenuItem13.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 12
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 13
        Me.MenuItem17.Text = "Ekraný Kapla"
        '
        'GridView8
        '
        Me.GridView8.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView8.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView8.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView8.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView8.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView8.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.colMusteri, Me.GridColumn32, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsKavala, Me.GridColumn33, Me.GridColumn34, Me.collBrutFiyat, Me.colTutar, Me.colDepo, Me.GridColumn35, Me.GridColumn36, Me.coldteTeslimEdilecek, Me.coldteOnayTarihi, Me.coldteTeslimEdilen, Me.colIZAHAT})
        Me.GridView8.CustomizationFormBounds = New System.Drawing.Rectangle(342, 287, 208, 170)
        Me.GridView8.DetailHeight = 160
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.GridControl = Me.Grid_bekleyen
        Me.GridView8.GroupFormat = "{0}: {1} {2}"
        Me.GridView8.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView8.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.GridColumn32, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Me.GridColumn34, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Me.colTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, " :{0} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "Toplam : {0:#,0.##} Adet"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Nothing, "ToplamTutar: {0:#,0.00}")})
        Me.GridView8.IndicatorWidth = 12
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.Editable = False
        Me.GridView8.OptionsCustomization.AllowFilter = False
        Me.GridView8.OptionsCustomization.AllowGroup = False
        Me.GridView8.OptionsDetail.ShowDetailTabs = False
        Me.GridView8.OptionsPrint.ExpandAllGroups = False
        Me.GridView8.OptionsSelection.MultiSelect = True
        Me.GridView8.OptionsView.ShowFooter = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "MüþteriKodu"
        Me.GridColumn31.FieldName = "lKodu"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.GridColumn31.Width = 49
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Müþteri"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.Width = 81
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "StokKodu"
        Me.GridColumn32.FieldName = "sKodu"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 3
        Me.GridColumn32.Width = 114
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "RenkKodu"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "RenkAdi"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 5
        Me.colsRenkAdi.Width = 77
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
        'GridColumn33
        '
        Me.GridColumn33.Caption = "StokAdý"
        Me.GridColumn33.FieldName = "sAciklama"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 4
        Me.GridColumn33.Width = 161
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Miktar"
        Me.GridColumn34.DisplayFormat.FormatString = "#,0.##"
        Me.GridColumn34.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn34.FieldName = "Miktar"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.00}")})
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 6
        Me.GridColumn34.Width = 48
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "BirimFiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 7
        Me.collBrutFiyat.Width = 64
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
        '
        'colDepo
        '
        Me.colDepo.Caption = "Depo"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 9
        Me.colDepo.Width = 78
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "FiþNo"
        Me.GridColumn35.FieldName = "lFaturaNo"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 2
        Me.GridColumn35.Width = 63
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Tarih"
        Me.GridColumn36.FieldName = "dteFaturaTarihi"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 1
        Me.GridColumn36.Width = 65
        '
        'coldteTeslimEdilecek
        '
        Me.coldteTeslimEdilecek.Caption = "TerminTarihi"
        Me.coldteTeslimEdilecek.FieldName = "dteTeslimEdilecek"
        Me.coldteTeslimEdilecek.Name = "coldteTeslimEdilecek"
        '
        'coldteOnayTarihi
        '
        Me.coldteOnayTarihi.Caption = "OnayTarihi"
        Me.coldteOnayTarihi.FieldName = "dteOnayTarihi"
        Me.coldteOnayTarihi.Name = "coldteOnayTarihi"
        '
        'coldteTeslimEdilen
        '
        Me.coldteTeslimEdilen.Caption = "TeslimTarihi"
        Me.coldteTeslimEdilen.FieldName = "dteTeslimEdilen"
        Me.coldteTeslimEdilen.Name = "coldteTeslimEdilen"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Ýzahat"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 0
        Me.colIZAHAT.Width = 54
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.Grid_Takip)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage5.Text = "Takip&Emirleri"
        '
        'Grid_Takip
        '
        Me.Grid_Takip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Takip.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Takip.MainView = Me.GridView9
        Me.Grid_Takip.Name = "Grid_Takip"
        Me.Grid_Takip.Size = New System.Drawing.Size(1469, 760)
        Me.Grid_Takip.TabIndex = 0
        Me.Grid_Takip.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView9.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView9.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView9.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.GridColumn37, Me.colTakipTipi, Me.colTakipAciklama, Me.GridColumn38, Me.colsKasiyer, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.colsSoyadi, Me.GridColumn42, Me.colSonuc, Me.colIletisimTarihi, Me.colIletisimSekli, Me.colIlgiliKisi, Me.colIstihbarat, Me.colAciklama1, Me.colAciklama2, Me.colAciklama3, Me.colAciklama4, Me.colStatus, Me.colGelecekmi, Me.colGTarih, Me.GridColumn43, Me.colOdendi, Me.GridColumn44, Me.colErisimTarihi})
        Me.GridView9.DetailHeight = 160
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.GridControl = Me.Grid_Takip
        Me.GridView9.GroupFormat = "{0}: {1} {2}"
        Me.GridView9.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView9.IndicatorWidth = 12
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsCustomization.AllowGroup = False
        Me.GridView9.OptionsDetail.ShowDetailTabs = False
        Me.GridView9.OptionsPrint.ExpandAllGroups = False
        Me.GridView9.OptionsSelection.MultiSelect = True
        Me.GridView9.OptionsView.ShowFooter = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.OptionsView.ShowIndicator = False
        '
        'colIND
        '
        Me.colIND.Caption = "KayýtNo"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Tarih"
        Me.GridColumn37.FieldName = "dteTarih"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarih", "{0} Kayýt")})
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 0
        Me.GridColumn37.Width = 53
        '
        'colTakipTipi
        '
        Me.colTakipTipi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTakipTipi.AppearanceCell.Options.UseBackColor = True
        Me.colTakipTipi.Caption = "TakipTipi"
        Me.colTakipTipi.FieldName = "TakipTipi"
        Me.colTakipTipi.Name = "colTakipTipi"
        Me.colTakipTipi.Visible = True
        Me.colTakipTipi.VisibleIndex = 1
        Me.colTakipTipi.Width = 61
        '
        'colTakipAciklama
        '
        Me.colTakipAciklama.Caption = "TakipAciklama"
        Me.colTakipAciklama.FieldName = "TakipAciklama"
        Me.colTakipAciklama.Name = "colTakipAciklama"
        Me.colTakipAciklama.Visible = True
        Me.colTakipAciklama.VisibleIndex = 2
        Me.colTakipAciklama.Width = 125
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "PersonelNo"
        Me.GridColumn38.FieldName = "PersonelNo"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Width = 50
        '
        'colsKasiyer
        '
        Me.colsKasiyer.Caption = "Personel"
        Me.colsKasiyer.FieldName = "Personel"
        Me.colsKasiyer.Name = "colsKasiyer"
        Me.colsKasiyer.Visible = True
        Me.colsKasiyer.VisibleIndex = 3
        Me.colsKasiyer.Width = 61
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "MüþteriNo"
        Me.GridColumn39.FieldName = "nMusteriID"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Width = 50
        '
        'GridColumn40
        '
        Me.GridColumn40.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn40.AppearanceCell.Options.UseFont = True
        Me.GridColumn40.Caption = "MüþteriKodu"
        Me.GridColumn40.FieldName = "lKodu"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 4
        Me.GridColumn40.Width = 61
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Adý"
        Me.GridColumn41.FieldName = "sAdi"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Width = 50
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadý"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Width = 50
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Müþteri"
        Me.GridColumn42.FieldName = "Musteri"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 5
        Me.GridColumn42.Width = 61
        '
        'colSonuc
        '
        Me.colSonuc.Caption = "Sonuç"
        Me.colSonuc.FieldName = "Sonuc"
        Me.colSonuc.Name = "colSonuc"
        Me.colSonuc.Visible = True
        Me.colSonuc.VisibleIndex = 6
        Me.colSonuc.Width = 61
        '
        'colIletisimTarihi
        '
        Me.colIletisimTarihi.Caption = "IletisimTarihi"
        Me.colIletisimTarihi.FieldName = "IletisimTarihi"
        Me.colIletisimTarihi.Name = "colIletisimTarihi"
        Me.colIletisimTarihi.Visible = True
        Me.colIletisimTarihi.VisibleIndex = 7
        Me.colIletisimTarihi.Width = 61
        '
        'colIletisimSekli
        '
        Me.colIletisimSekli.Caption = "IletisimSekli"
        Me.colIletisimSekli.FieldName = "IletisimSekli"
        Me.colIletisimSekli.Name = "colIletisimSekli"
        Me.colIletisimSekli.Visible = True
        Me.colIletisimSekli.VisibleIndex = 8
        Me.colIletisimSekli.Width = 61
        '
        'colIlgiliKisi
        '
        Me.colIlgiliKisi.Caption = "IlgiliKisi"
        Me.colIlgiliKisi.FieldName = "IlgiliKisi"
        Me.colIlgiliKisi.Name = "colIlgiliKisi"
        Me.colIlgiliKisi.Visible = True
        Me.colIlgiliKisi.VisibleIndex = 9
        Me.colIlgiliKisi.Width = 70
        '
        'colIstihbarat
        '
        Me.colIstihbarat.Caption = "Istihbarat"
        Me.colIstihbarat.FieldName = "Istihbarat"
        Me.colIstihbarat.Name = "colIstihbarat"
        Me.colIstihbarat.Width = 50
        '
        'colAciklama1
        '
        Me.colAciklama1.Caption = "Aciklama1"
        Me.colAciklama1.FieldName = "Aciklama1"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Width = 73
        '
        'colAciklama2
        '
        Me.colAciklama2.Caption = "Aciklama2"
        Me.colAciklama2.FieldName = "Aciklama2"
        Me.colAciklama2.Name = "colAciklama2"
        Me.colAciklama2.Width = 124
        '
        'colAciklama3
        '
        Me.colAciklama3.Caption = "Aciklama3"
        Me.colAciklama3.FieldName = "Aciklama3"
        Me.colAciklama3.Name = "colAciklama3"
        Me.colAciklama3.Width = 50
        '
        'colAciklama4
        '
        Me.colAciklama4.Caption = "Aciklama4"
        Me.colAciklama4.FieldName = "Aciklama4"
        Me.colAciklama4.Name = "colAciklama4"
        Me.colAciklama4.Width = 50
        '
        'colStatus
        '
        Me.colStatus.Caption = "Tamamlandi?"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 57
        '
        'colGelecekmi
        '
        Me.colGelecekmi.Caption = "Gelecekmi?"
        Me.colGelecekmi.FieldName = "Gelecekmi"
        Me.colGelecekmi.Name = "colGelecekmi"
        '
        'colGTarih
        '
        Me.colGTarih.Caption = "GeleceðiTarih"
        Me.colGTarih.FieldName = "GTarih"
        Me.colGTarih.Name = "colGTarih"
        Me.colGTarih.Visible = True
        Me.colGTarih.VisibleIndex = 10
        Me.colGTarih.Width = 61
        '
        'GridColumn43
        '
        Me.GridColumn43.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn43.AppearanceCell.Options.UseFont = True
        Me.GridColumn43.Caption = "Tutar"
        Me.GridColumn43.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn43.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn43.FieldName = "Tutar"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 11
        Me.GridColumn43.Width = 71
        '
        'colOdendi
        '
        Me.colOdendi.Caption = "Odendi?"
        Me.colOdendi.FieldName = "Odendi"
        Me.colOdendi.Name = "colOdendi"
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "KayýtTarihi"
        Me.GridColumn44.DisplayFormat.FormatString = "dd.MM.yyy HH:mm"
        Me.GridColumn44.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn44.FieldName = "KayitTarihi"
        Me.GridColumn44.Name = "GridColumn44"
        '
        'colErisimTarihi
        '
        Me.colErisimTarihi.Caption = "EriþimTarihi"
        Me.colErisimTarihi.DisplayFormat.FormatString = "dd.MM.yyy HH:mm"
        Me.colErisimTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colErisimTarihi.FieldName = "ErisimTarihi"
        Me.colErisimTarihi.Name = "colErisimTarihi"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.PanelControl11)
        Me.XtraTabPage6.Controls.Add(Me.PanelControl8)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage6.Text = "Ek&stre"
        '
        'PanelControl11
        '
        Me.PanelControl11.Controls.Add(Me.GridControl3)
        Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl11.Location = New System.Drawing.Point(0, 54)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(1469, 706)
        Me.PanelControl11.TabIndex = 2
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.ContextMenu1
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.DataSet1
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView10
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1465, 702)
        Me.GridControl3.TabIndex = 2
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem22, Me.MenuItem21, Me.MenuItem20, Me.MenuItem19, Me.MenuItem4, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem1.Text = "Tamam"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem2.Text = "&Listele"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem23.Text = "Kefilin Hesabýný Bul"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 3
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem24.Text = "Açýklama Gir"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 4
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem25.Text = "Müþteri Kartý Düzenle"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 5
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem26.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 7
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.ShiftF1
        Me.MenuItem21.Text = "Hesap Makinasý"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 9
        Me.MenuItem19.Text = "Görünümü Yazdýr"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 10
        Me.MenuItem4.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 11
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem3.Text = "Ekraný Kapla"
        '
        'GridView10
        '
        Me.GridView10.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView10.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView10.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView10.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView10.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView10.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView10.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView10.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView10.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn46, Me.colsMusteriAdi, Me.GridColumn47, Me.colfisTipi, Me.GridColumn48, Me.GridColumn49, Me.colsStokAciklama, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52, Me.collNetTutar1, Me.GridColumn53, Me.GridColumn54, Me.GridColumn55, Me.GridColumn56, Me.GridColumn45, Me.colId, Me.GridColumn57, Me.colTipi, Me.GridColumn58, Me.GridColumn59, Me.collMalBedeli, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn66, Me.GridColumn67, Me.collBakiye})
        Me.GridView10.CustomizationFormBounds = New System.Drawing.Rectangle(477, 314, 208, 170)
        Me.GridView10.DetailHeight = 160
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.ApplyToRow = True
        StyleFormatCondition6.Column = Me.GridColumn45
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition6.Tag = "0"
        StyleFormatCondition6.Value1 = "0"
        Me.GridView10.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition6})
        Me.GridView10.GridControl = Me.GridControl3
        Me.GridView10.GroupFormat = "{0}: {1} {2}"
        Me.GridView10.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView10.IndicatorWidth = 12
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsBehavior.Editable = False
        Me.GridView10.OptionsCustomization.AllowFilter = False
        Me.GridView10.OptionsCustomization.AllowGroup = False
        Me.GridView10.OptionsDetail.ShowDetailTabs = False
        Me.GridView10.OptionsView.ShowFooter = True
        Me.GridView10.OptionsView.ShowGroupPanel = False
        Me.GridView10.OptionsView.ShowIndicator = False
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "MüþteriNo"
        Me.GridColumn46.FieldName = "lKodu"
        Me.GridColumn46.Name = "GridColumn46"
        '
        'colsMusteriAdi
        '
        Me.colsMusteriAdi.Caption = "Müþteri"
        Me.colsMusteriAdi.FieldName = "sMusteriAdi"
        Me.colsMusteriAdi.Name = "colsMusteriAdi"
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "Tarih"
        Me.GridColumn47.FieldName = "dteTarih"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 0
        Me.GridColumn47.Width = 74
        '
        'colfisTipi
        '
        Me.colfisTipi.Caption = "FiþTipi"
        Me.colfisTipi.FieldName = "fisTipi"
        Me.colfisTipi.Name = "colfisTipi"
        Me.colfisTipi.Visible = True
        Me.colfisTipi.VisibleIndex = 1
        Me.colfisTipi.Width = 53
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "FiþNo"
        Me.GridColumn48.FieldName = "lNo"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 2
        Me.GridColumn48.Width = 57
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "Kodu"
        Me.GridColumn49.FieldName = "sKodu"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 3
        Me.GridColumn49.Width = 115
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Açýklama"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 4
        Me.colsStokAciklama.Width = 220
        '
        'GridColumn50
        '
        Me.GridColumn50.Caption = "Miktar"
        Me.GridColumn50.DisplayFormat.FormatString = "#,#.##"
        Me.GridColumn50.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn50.FieldName = "Miktar"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.##}")})
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 5
        Me.GridColumn50.Width = 60
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "Fiyat"
        Me.GridColumn51.DisplayFormat.FormatString = "#,#.##"
        Me.GridColumn51.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn51.FieldName = "Fiyat"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 6
        Me.GridColumn51.Width = 50
        '
        'GridColumn52
        '
        Me.GridColumn52.Caption = "Iskonto"
        Me.GridColumn52.DisplayFormat.FormatString = "#,#.##"
        Me.GridColumn52.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn52.FieldName = "Iskonto"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.##}")})
        Me.GridColumn52.Width = 54
        '
        'collNetTutar1
        '
        Me.collNetTutar1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collNetTutar1.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.collNetTutar1.AppearanceCell.Options.UseFont = True
        Me.collNetTutar1.AppearanceCell.Options.UseForeColor = True
        Me.collNetTutar1.Caption = "SatýþTutarý"
        Me.collNetTutar1.DisplayFormat.FormatString = "#,#.##"
        Me.collNetTutar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar1.FieldName = "lNetTutar"
        Me.collNetTutar1.Name = "collNetTutar1"
        Me.collNetTutar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.##}")})
        Me.collNetTutar1.Visible = True
        Me.collNetTutar1.VisibleIndex = 7
        Me.collNetTutar1.Width = 64
        '
        'GridColumn53
        '
        Me.GridColumn53.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn53.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn53.AppearanceCell.Options.UseFont = True
        Me.GridColumn53.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn53.Caption = "OdemeTutarý"
        Me.GridColumn53.DisplayFormat.FormatString = "#,#.##"
        Me.GridColumn53.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn53.FieldName = "OdemeTutar"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OdemeTutar", "{0:#,0.##}")})
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 8
        Me.GridColumn53.Width = 88
        '
        'GridColumn54
        '
        Me.GridColumn54.Caption = "ÖdemeTipi"
        Me.GridColumn54.FieldName = "OdemeTipi"
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.Visible = True
        Me.GridColumn54.VisibleIndex = 9
        Me.GridColumn54.Width = 74
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "Satýcý"
        Me.GridColumn55.FieldName = "SaticiRumuzu"
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.Width = 58
        '
        'GridColumn56
        '
        Me.GridColumn56.Caption = "Kasiyer"
        Me.GridColumn56.FieldName = "KasiyerRumuzu"
        Me.GridColumn56.Name = "GridColumn56"
        Me.GridColumn56.Visible = True
        Me.GridColumn56.VisibleIndex = 10
        Me.GridColumn56.Width = 76
        '
        'colId
        '
        Me.colId.Caption = "KayýtNo"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "Açýklama"
        Me.GridColumn57.FieldName = "OdemeAciklama"
        Me.GridColumn57.Name = "GridColumn57"
        '
        'colTipi
        '
        Me.colTipi.Caption = "Tipi"
        Me.colTipi.FieldName = "Tipi"
        Me.colTipi.Name = "colTipi"
        '
        'GridColumn58
        '
        Me.GridColumn58.Caption = "GirisCikis"
        Me.GridColumn58.FieldName = "GirisCikis"
        Me.GridColumn58.Name = "GridColumn58"
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "IadeAvInf"
        Me.GridColumn59.FieldName = "IadeAvInf"
        Me.GridColumn59.Name = "GridColumn59"
        '
        'collMalBedeli
        '
        Me.collMalBedeli.Caption = "MalBedeli"
        Me.collMalBedeli.FieldName = "lMalBedeli"
        Me.collMalBedeli.Name = "collMalBedeli"
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "HareketTipi"
        Me.GridColumn60.FieldName = "sHareketTipi"
        Me.GridColumn60.Name = "GridColumn60"
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "SatýrKayýtNo"
        Me.GridColumn61.FieldName = "nIslemId"
        Me.GridColumn61.Name = "GridColumn61"
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "StokOdeme"
        Me.GridColumn62.FieldName = "StokOdeme"
        Me.GridColumn62.Name = "GridColumn62"
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "SevkAciklama"
        Me.GridColumn63.FieldName = "SevkAciklama"
        Me.GridColumn63.Name = "GridColumn63"
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "Saat"
        Me.GridColumn64.DisplayFormat.FormatString = "hh:mm"
        Me.GridColumn64.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn64.FieldName = "KayitTarihi"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.Width = 76
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "Satici"
        Me.GridColumn66.FieldName = "SaticiRumuzu"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.Visible = True
        Me.GridColumn66.VisibleIndex = 11
        '
        'GridColumn67
        '
        Me.GridColumn67.Caption = "FiyatTipi"
        Me.GridColumn67.FieldName = "sFiyatTipi"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 12
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 13
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.Label39)
        Me.PanelControl8.Controls.Add(Me.SimpleButton6)
        Me.PanelControl8.Controls.Add(Me.Label40)
        Me.PanelControl8.Controls.Add(Me.sec_ekstre_tarih2)
        Me.PanelControl8.Controls.Add(Me.sec_ekstre_tarih1)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(1469, 54)
        Me.PanelControl8.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(256, 11)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(16, 19)
        Me.Label39.TabIndex = 22
        Me.Label39.Text = "ve"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(845, 11)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(120, 33)
        Me.SimpleButton6.TabIndex = 21
        Me.SimpleButton6.Text = "&Listele"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(576, 11)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(219, 19)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "Tarihleri Arasýndaki Hareketleri"
        '
        'sec_ekstre_tarih2
        '
        Me.sec_ekstre_tarih2.EditValue = New Date(2048, 12, 31, 0, 0, 0, 0)
        Me.sec_ekstre_tarih2.EnterMoveNextControl = True
        Me.sec_ekstre_tarih2.Location = New System.Drawing.Point(307, 11)
        Me.sec_ekstre_tarih2.Name = "sec_ekstre_tarih2"
        Me.sec_ekstre_tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih2.Size = New System.Drawing.Size(256, 26)
        Me.sec_ekstre_tarih2.TabIndex = 19
        '
        'sec_ekstre_tarih1
        '
        Me.sec_ekstre_tarih1.EditValue = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.sec_ekstre_tarih1.EnterMoveNextControl = True
        Me.sec_ekstre_tarih1.Location = New System.Drawing.Point(13, 11)
        Me.sec_ekstre_tarih1.Name = "sec_ekstre_tarih1"
        Me.sec_ekstre_tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih1.Size = New System.Drawing.Size(243, 26)
        Me.sec_ekstre_tarih1.TabIndex = 18
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.GridControl4)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage7.Text = "Teslimatlar"
        '
        'GridControl4
        '
        Me.GridControl4.ContextMenu = Me.ContextMenu1
        Me.GridControl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridControl4.DataMember = "Table1"
        Me.GridControl4.DataSource = Me.DataSet1
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView11
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(1469, 760)
        Me.GridControl4.TabIndex = 1
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView11})
        '
        'GridView11
        '
        Me.GridView11.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView11.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView11.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView11.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView11.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView11.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteFisTarihi, Me.collFisNo, Me.GridColumn68, Me.GridColumn69, Me.GridColumn70, Me.colsDepo, Me.GridColumn71, Me.GridColumn72, Me.GridColumn73, Me.colsTransferDepo, Me.coltDepo, Me.colsFaturalasti, Me.colMuhasebelesti, Me.GridColumn74, Me.colsNot, Me.colTamamlandi, Me.collTevkifatKdvMatrahi, Me.collTevkifatKdv, Me.colHizmet, Me.colnFirmaID, Me.GridColumn75, Me.colnStokFisiID, Me.colKdvTutari, Me.colKdvMatrahi, Me.collMalIskontoTutari, Me.GridColumn76, Me.colEkMaliyet, Me.GridColumn77, Me.colEkOran, Me.colbPesinmi, Me.collOTV2, Me.colnSayfa, Me.GridColumn78, Me.GridColumn79, Me.colbKilitli})
        Me.GridView11.CustomizationFormBounds = New System.Drawing.Rectangle(796, 271, 208, 156)
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition7.Appearance.Options.UseFont = True
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.ApplyToRow = True
        StyleFormatCondition7.Column = Me.colbPesinmi
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition7.Tag = True
        StyleFormatCondition7.Value1 = True
        Me.GridView11.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition7})
        Me.GridView11.GridControl = Me.GridControl4
        Me.GridView11.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView11.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView11.OptionsBehavior.Editable = False
        Me.GridView11.OptionsCustomization.AllowFilter = False
        Me.GridView11.OptionsCustomization.AllowGroup = False
        Me.GridView11.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView11.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView11.OptionsNavigation.UseTabKey = False
        Me.GridView11.OptionsSelection.MultiSelect = True
        Me.GridView11.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView11.OptionsView.EnableAppearanceOddRow = True
        Me.GridView11.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView11.OptionsView.ShowFooter = True
        Me.GridView11.OptionsView.ShowGroupPanel = False
        Me.GridView11.OptionsView.ShowIndicator = False
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Tarih"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", "{0} Kayýt")})
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 0
        Me.coldteFisTarihi.Width = 92
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "FiþNo"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 2
        Me.collFisNo.Width = 48
        '
        'GridColumn68
        '
        Me.GridColumn68.Caption = "GirisCikis"
        Me.GridColumn68.FieldName = "nGirisCikis"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.Width = 55
        '
        'GridColumn69
        '
        Me.GridColumn69.Caption = "Miktar"
        Me.GridColumn69.DisplayFormat.FormatString = "#,0.##"
        Me.GridColumn69.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn69.FieldName = "lToplamMiktar"
        Me.GridColumn69.Name = "GridColumn69"
        Me.GridColumn69.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lToplamMiktar", "{0:#,0.00}")})
        Me.GridColumn69.Visible = True
        Me.GridColumn69.VisibleIndex = 3
        Me.GridColumn69.Width = 72
        '
        'GridColumn70
        '
        Me.GridColumn70.Caption = "NetTutar"
        Me.GridColumn70.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn70.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn70.FieldName = "lNetTutar"
        Me.GridColumn70.Name = "GridColumn70"
        Me.GridColumn70.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.GridColumn70.Visible = True
        Me.GridColumn70.VisibleIndex = 8
        Me.GridColumn70.Width = 131
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "DepoKodu"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'GridColumn71
        '
        Me.GridColumn71.Caption = "DepoAdý"
        Me.GridColumn71.FieldName = "Depo"
        Me.GridColumn71.Name = "GridColumn71"
        '
        'GridColumn72
        '
        Me.GridColumn72.Caption = "FirmaKodu"
        Me.GridColumn72.FieldName = "sKodu"
        Me.GridColumn72.Name = "GridColumn72"
        Me.GridColumn72.Width = 142
        '
        'GridColumn73
        '
        Me.GridColumn73.Caption = "FirmaAdý"
        Me.GridColumn73.FieldName = "sAciklama"
        Me.GridColumn73.Name = "GridColumn73"
        Me.GridColumn73.Visible = True
        Me.GridColumn73.VisibleIndex = 1
        Me.GridColumn73.Width = 147
        '
        'colsTransferDepo
        '
        Me.colsTransferDepo.Caption = "TransferDepo"
        Me.colsTransferDepo.FieldName = "sTransferDepo"
        Me.colsTransferDepo.Name = "colsTransferDepo"
        '
        'coltDepo
        '
        Me.coltDepo.Caption = "TransferDepoAdý"
        Me.coltDepo.FieldName = "tDepo"
        Me.coltDepo.Name = "coltDepo"
        '
        'colsFaturalasti
        '
        Me.colsFaturalasti.Caption = "Faturalasti?"
        Me.colsFaturalasti.FieldName = "sFaturalasti"
        Me.colsFaturalasti.Name = "colsFaturalasti"
        '
        'colMuhasebelesti
        '
        Me.colMuhasebelesti.Caption = "Muhasebelesti?"
        Me.colMuhasebelesti.FieldName = "Muhasebelesti"
        Me.colMuhasebelesti.Name = "colMuhasebelesti"
        '
        'GridColumn74
        '
        Me.GridColumn74.Caption = "HareketTipi"
        Me.GridColumn74.FieldName = "sHareketTipi"
        Me.GridColumn74.Name = "GridColumn74"
        Me.GridColumn74.Width = 67
        '
        'colsNot
        '
        Me.colsNot.Caption = "Notlar"
        Me.colsNot.FieldName = "sNot"
        Me.colsNot.Name = "colsNot"
        Me.colsNot.Visible = True
        Me.colsNot.VisibleIndex = 9
        Me.colsNot.Width = 187
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
        Me.collTevkifatKdvMatrahi.Caption = "TevkifatKdvMatrahi"
        Me.collTevkifatKdvMatrahi.FieldName = "lTevkifatKdvMatrahi"
        Me.collTevkifatKdvMatrahi.Name = "collTevkifatKdvMatrahi"
        '
        'collTevkifatKdv
        '
        Me.collTevkifatKdv.Caption = "TevkifatKdv"
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
        Me.colnFirmaID.Caption = "FirmaNo"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'GridColumn75
        '
        Me.GridColumn75.Caption = "FisTipi"
        Me.GridColumn75.FieldName = "sFisTipi"
        Me.GridColumn75.Name = "GridColumn75"
        Me.GridColumn75.Width = 44
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "KayýtNo"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colKdvTutari
        '
        Me.colKdvTutari.Caption = "KdvTutarý"
        Me.colKdvTutari.DisplayFormat.FormatString = "#,#.##"
        Me.colKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvTutari.FieldName = "KdvTutari"
        Me.colKdvTutari.Name = "colKdvTutari"
        Me.colKdvTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvTutari", "{0:#,0.00}")})
        Me.colKdvTutari.Visible = True
        Me.colKdvTutari.VisibleIndex = 7
        Me.colKdvTutari.Width = 73
        '
        'colKdvMatrahi
        '
        Me.colKdvMatrahi.Caption = "KdvMatrahý"
        Me.colKdvMatrahi.DisplayFormat.FormatString = "#,0.00"
        Me.colKdvMatrahi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvMatrahi.FieldName = "KdvMatrahi"
        Me.colKdvMatrahi.Name = "colKdvMatrahi"
        Me.colKdvMatrahi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvMatrahi", "{0:#,0.00}")})
        '
        'collMalIskontoTutari
        '
        Me.collMalIskontoTutari.Caption = "Ýskonto"
        Me.collMalIskontoTutari.DisplayFormat.FormatString = "#,#.##"
        Me.collMalIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalIskontoTutari.FieldName = "lIskontoTutari"
        Me.collMalIskontoTutari.Name = "collMalIskontoTutari"
        Me.collMalIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalIskontoTutari", "{0:#,0.00}")})
        Me.collMalIskontoTutari.Visible = True
        Me.collMalIskontoTutari.VisibleIndex = 5
        Me.collMalIskontoTutari.Width = 85
        '
        'GridColumn76
        '
        Me.GridColumn76.Caption = "Brut"
        Me.GridColumn76.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn76.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn76.FieldName = "lMalBedeli"
        Me.GridColumn76.Name = "GridColumn76"
        Me.GridColumn76.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalBedeli", "{0:#,0.00}")})
        Me.GridColumn76.Visible = True
        Me.GridColumn76.VisibleIndex = 4
        Me.GridColumn76.Width = 85
        '
        'colEkMaliyet
        '
        Me.colEkMaliyet.Caption = "EkMaliyet"
        Me.colEkMaliyet.DisplayFormat.FormatString = "#,#.##"
        Me.colEkMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkMaliyet.FieldName = "EkMaliyet"
        Me.colEkMaliyet.Name = "colEkMaliyet"
        Me.colEkMaliyet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EkMaliyet", "{0:#,0.00}")})
        Me.colEkMaliyet.Width = 52
        '
        'GridColumn77
        '
        Me.GridColumn77.Caption = "%Isk"
        Me.GridColumn77.DisplayFormat.FormatString = "P"
        Me.GridColumn77.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn77.FieldName = "ISKONTO"
        Me.GridColumn77.Name = "GridColumn77"
        Me.GridColumn77.Visible = True
        Me.GridColumn77.VisibleIndex = 6
        Me.GridColumn77.Width = 46
        '
        'colEkOran
        '
        Me.colEkOran.Caption = "%EkOran"
        Me.colEkOran.DisplayFormat.FormatString = "P"
        Me.colEkOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkOran.FieldName = "EkOran"
        Me.colEkOran.Name = "colEkOran"
        Me.colEkOran.Width = 66
        '
        'collOTV2
        '
        Me.collOTV2.Caption = "Yazdýrma"
        Me.collOTV2.FieldName = "lOTV2"
        Me.collOTV2.Name = "collOTV2"
        Me.collOTV2.Visible = True
        Me.collOTV2.VisibleIndex = 10
        Me.collOTV2.Width = 91
        '
        'colnSayfa
        '
        Me.colnSayfa.Caption = "Sayfa"
        Me.colnSayfa.FieldName = "nSayfa"
        Me.colnSayfa.Name = "colnSayfa"
        '
        'GridColumn78
        '
        Me.GridColumn78.Caption = "Kaydeden"
        Me.GridColumn78.FieldName = "sKullaniciAdi"
        Me.GridColumn78.Name = "GridColumn78"
        '
        'GridColumn79
        '
        Me.GridColumn79.Caption = "KayýtTarihi"
        Me.GridColumn79.DisplayFormat.FormatString = "dd/MM/yyyy HH:m:s t"
        Me.GridColumn79.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn79.FieldName = "dteKayitTarihi"
        Me.GridColumn79.Name = "GridColumn79"
        '
        'colbKilitli
        '
        Me.colbKilitli.Caption = "Kilitli?"
        Me.colbKilitli.FieldName = "bKilitli"
        Me.colbKilitli.Name = "colbKilitli"
        Me.colbKilitli.Visible = True
        Me.colbKilitli.VisibleIndex = 11
        Me.colbKilitli.Width = 48
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.GridControl5)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage8.Text = "PaketTeslimatý"
        '
        'GridControl5
        '
        Me.GridControl5.DataMember = "Table1"
        Me.GridControl5.DataSource = Me.DataSet1
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(0, 0)
        Me.GridControl5.MainView = Me.GridView12
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl5.Size = New System.Drawing.Size(1469, 760)
        Me.GridControl5.TabIndex = 1
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView12})
        '
        'GridView12
        '
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
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn80, Me.colTARIH, Me.colFIRMANO, Me.colFISNO, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colBELGENO, Me.GridColumn81, Me.GridColumn82, Me.colKOD1, Me.colKOD2, Me.colKOD3, Me.colKOD4, Me.colKOD5, Me.colACIKLAMA, Me.colUSERNO, Me.GridColumn83, Me.GridColumn84, Me.colADI, Me.colSOYADI, Me.colFISTARIHI, Me.colTESLIMAT, Me.colFISKAYITTARIHI, Me.colSure, Me.GridColumn85})
        Me.GridView12.CustomizationFormBounds = New System.Drawing.Rectangle(419, 321, 208, 156)
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.GridControl = Me.GridControl5
        Me.GridView12.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView12.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Me.GridColumn84, "{0:#,0.##}")})
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView12.OptionsBehavior.Editable = False
        Me.GridView12.OptionsCustomization.AllowFilter = False
        Me.GridView12.OptionsCustomization.AllowGroup = False
        Me.GridView12.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView12.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView12.OptionsNavigation.UseTabKey = False
        Me.GridView12.OptionsSelection.MultiSelect = True
        Me.GridView12.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView12.OptionsView.ShowFooter = True
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.OptionsView.ShowIndicator = False
        '
        'GridColumn80
        '
        Me.GridColumn80.Caption = "Kayýt No"
        Me.GridColumn80.FieldName = "IND"
        Me.GridColumn80.Name = "GridColumn80"
        Me.GridColumn80.Visible = True
        Me.GridColumn80.VisibleIndex = 0
        Me.GridColumn80.Width = 35
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", "{0} Kayýt")})
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 1
        Me.colTARIH.Width = 36
        '
        'colFIRMANO
        '
        Me.colFIRMANO.Caption = "Müþteri No"
        Me.colFIRMANO.FieldName = "FIRMANO"
        Me.colFIRMANO.Name = "colFIRMANO"
        '
        'colFISNO
        '
        Me.colFISNO.Caption = "Fiþ No"
        Me.colFISNO.FieldName = "FISNO"
        Me.colFISNO.Name = "colFISNO"
        Me.colFISNO.Visible = True
        Me.colFISNO.VisibleIndex = 5
        Me.colFISNO.Width = 52
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Müþteri Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 6
        Me.colFIRMAKODU.Width = 48
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Müþteri Adý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 7
        Me.colFIRMAADI.Width = 48
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Visible = True
        Me.colBELGENO.VisibleIndex = 2
        Me.colBELGENO.Width = 48
        '
        'GridColumn81
        '
        Me.GridColumn81.Caption = "Belge Tipi"
        Me.GridColumn81.FieldName = "IZAHAT"
        Me.GridColumn81.Name = "GridColumn81"
        Me.GridColumn81.Visible = True
        Me.GridColumn81.VisibleIndex = 4
        Me.GridColumn81.Width = 48
        '
        'GridColumn82
        '
        Me.GridColumn82.Caption = "Depo"
        Me.GridColumn82.FieldName = "DEPO"
        Me.GridColumn82.Name = "GridColumn82"
        Me.GridColumn82.Visible = True
        Me.GridColumn82.VisibleIndex = 8
        Me.GridColumn82.Width = 48
        '
        'colKOD1
        '
        Me.colKOD1.Caption = "1.ÖzelKod"
        Me.colKOD1.FieldName = "KOD1"
        Me.colKOD1.Name = "colKOD1"
        '
        'colKOD2
        '
        Me.colKOD2.Caption = "2.ÖzelKod"
        Me.colKOD2.FieldName = "KOD2"
        Me.colKOD2.Name = "colKOD2"
        '
        'colKOD3
        '
        Me.colKOD3.Caption = "3.ÖzelKod"
        Me.colKOD3.FieldName = "KOD3"
        Me.colKOD3.Name = "colKOD3"
        '
        'colKOD4
        '
        Me.colKOD4.Caption = "4.ÖzelKod"
        Me.colKOD4.FieldName = "KOD4"
        Me.colKOD4.Name = "colKOD4"
        '
        'colKOD5
        '
        Me.colKOD5.Caption = "5.ÖzelKod"
        Me.colKOD5.FieldName = "KOD5"
        Me.colKOD5.Name = "colKOD5"
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 9
        Me.colACIKLAMA.Width = 68
        '
        'colUSERNO
        '
        Me.colUSERNO.Caption = "Kaydeden"
        Me.colUSERNO.FieldName = "USERNO"
        Me.colUSERNO.Name = "colUSERNO"
        '
        'GridColumn83
        '
        Me.GridColumn83.Caption = "Kayýt Saati"
        Me.GridColumn83.DisplayFormat.FormatString = "T"
        Me.GridColumn83.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn83.FieldName = "KAYITTARIHI"
        Me.GridColumn83.Name = "GridColumn83"
        Me.GridColumn83.Visible = True
        Me.GridColumn83.VisibleIndex = 10
        Me.GridColumn83.Width = 59
        '
        'GridColumn84
        '
        Me.GridColumn84.Caption = "Miktar"
        Me.GridColumn84.DisplayFormat.FormatString = "#,0.##"
        Me.GridColumn84.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn84.FieldName = "MIKTAR"
        Me.GridColumn84.Name = "GridColumn84"
        Me.GridColumn84.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.##}")})
        Me.GridColumn84.Visible = True
        Me.GridColumn84.VisibleIndex = 11
        Me.GridColumn84.Width = 49
        '
        'colADI
        '
        Me.colADI.Caption = "Ad"
        Me.colADI.FieldName = "ADI"
        Me.colADI.Name = "colADI"
        '
        'colSOYADI
        '
        Me.colSOYADI.Caption = "Soyad"
        Me.colSOYADI.FieldName = "SOYADI"
        Me.colSOYADI.Name = "colSOYADI"
        '
        'colFISTARIHI
        '
        Me.colFISTARIHI.Caption = "FiþTarihi"
        Me.colFISTARIHI.FieldName = "FISTARIHI"
        Me.colFISTARIHI.Name = "colFISTARIHI"
        Me.colFISTARIHI.Visible = True
        Me.colFISTARIHI.VisibleIndex = 3
        Me.colFISTARIHI.Width = 48
        '
        'colTESLIMAT
        '
        Me.colTESLIMAT.Caption = "TeslimEdilen"
        Me.colTESLIMAT.DisplayFormat.FormatString = "#,0.##"
        Me.colTESLIMAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTESLIMAT.FieldName = "TESLIMAT"
        Me.colTESLIMAT.Name = "colTESLIMAT"
        Me.colTESLIMAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TESLIMAT", "{0:#,0.##}")})
        Me.colTESLIMAT.Visible = True
        Me.colTESLIMAT.VisibleIndex = 12
        Me.colTESLIMAT.Width = 69
        '
        'colFISKAYITTARIHI
        '
        Me.colFISKAYITTARIHI.Caption = "FiþKayýtSaati"
        Me.colFISKAYITTARIHI.DisplayFormat.FormatString = "T"
        Me.colFISKAYITTARIHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFISKAYITTARIHI.FieldName = "FISKAYITTARIHI"
        Me.colFISKAYITTARIHI.Name = "colFISKAYITTARIHI"
        '
        'colSure
        '
        Me.colSure.Caption = "Süre"
        Me.colSure.DisplayFormat.FormatString = "T"
        Me.colSure.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSure.FieldName = "Sure"
        Me.colSure.Name = "colSure"
        Me.colSure.Visible = True
        Me.colSure.VisibleIndex = 13
        Me.colSure.Width = 101
        '
        'GridColumn85
        '
        Me.GridColumn85.Caption = "Kilitli?"
        Me.GridColumn85.FieldName = "bKilitli"
        Me.GridColumn85.Name = "GridColumn85"
        Me.GridColumn85.Visible = True
        Me.GridColumn85.VisibleIndex = 14
        Me.GridColumn85.Width = 50
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "sRenkAdi"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ShowLines = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "sRenk"
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.GridControl6)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1469, 760)
        Me.XtraTabPage9.Text = "Dökümanlar"
        '
        'GridControl6
        '
        Me.GridControl6.DataMember = "Table1"
        Me.GridControl6.DataSource = Me.ds_tbMusteriResim
        Me.GridControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl6.Location = New System.Drawing.Point(0, 0)
        Me.GridControl6.MainView = Me.GridView13
        Me.GridControl6.MenuManager = Me.BarManager1
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_pResim})
        Me.GridControl6.Size = New System.Drawing.Size(1469, 760)
        Me.GridControl6.TabIndex = 1
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView13})
        '
        'ds_tbMusteriResim
        '
        Me.ds_tbMusteriResim.DataSetName = "NewDataSet"
        Me.ds_tbMusteriResim.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriResim.Tables.AddRange(New System.Data.DataTable() {Me.DataTable11})
        '
        'DataTable11
        '
        Me.DataTable11.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn169, Me.DataColumn170, Me.DataColumn171, Me.DataColumn172, Me.DataColumn173, Me.DataColumn174})
        Me.DataTable11.TableName = "Table1"
        '
        'DataColumn169
        '
        Me.DataColumn169.ColumnName = "nMusteriID"
        Me.DataColumn169.DataType = GetType(Long)
        '
        'DataColumn170
        '
        Me.DataColumn170.ColumnName = "pResim"
        Me.DataColumn170.DataType = GetType(Byte())
        '
        'DataColumn171
        '
        Me.DataColumn171.ColumnName = "sAciklama"
        '
        'DataColumn172
        '
        Me.DataColumn172.ColumnName = "dteKayitTarihi"
        Me.DataColumn172.DataType = GetType(Date)
        '
        'DataColumn173
        '
        Me.DataColumn173.AutoIncrement = True
        Me.DataColumn173.ColumnName = "nMusteriResimID"
        Me.DataColumn173.DataType = GetType(Long)
        '
        'DataColumn174
        '
        Me.DataColumn174.ColumnName = "sKullaniciAdi"
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID5, Me.colpResim, Me.colsAciklama2, Me.coldtekayitTarihi3})
        Me.GridView13.GridControl = Me.GridControl6
        Me.GridView13.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView13.IndicatorWidth = 35
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsBehavior.Editable = False
        Me.GridView13.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView13.OptionsCustomization.AllowFilter = False
        Me.GridView13.OptionsCustomization.AllowGroup = False
        Me.GridView13.OptionsView.ShowFooter = True
        Me.GridView13.OptionsView.ShowGroupPanel = False
        Me.GridView13.RowHeight = 100
        '
        'colnMusteriID5
        '
        Me.colnMusteriID5.Caption = "MusteriID"
        Me.colnMusteriID5.FieldName = "nMusteriID"
        Me.colnMusteriID5.Name = "colnMusteriID5"
        Me.colnMusteriID5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nMusteriID", "{0} Kayýt")})
        Me.colnMusteriID5.Width = 109
        '
        'colpResim
        '
        Me.colpResim.Caption = "Resim"
        Me.colpResim.ColumnEdit = Me.sec_pResim
        Me.colpResim.FieldName = "pResim"
        Me.colpResim.Name = "colpResim"
        Me.colpResim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "pResim", "{0} Kayýt")})
        Me.colpResim.Visible = True
        Me.colpResim.VisibleIndex = 0
        Me.colpResim.Width = 471
        '
        'sec_pResim
        '
        Me.sec_pResim.Name = "sec_pResim"
        Me.sec_pResim.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'colsAciklama2
        '
        Me.colsAciklama2.Caption = "Açýklama"
        Me.colsAciklama2.FieldName = "sAciklama"
        Me.colsAciklama2.Name = "colsAciklama2"
        Me.colsAciklama2.Visible = True
        Me.colsAciklama2.VisibleIndex = 1
        Me.colsAciklama2.Width = 304
        '
        'coldtekayitTarihi3
        '
        Me.coldtekayitTarihi3.Caption = "KayýtTarihi"
        Me.coldtekayitTarihi3.FieldName = "dteKayitTarihi"
        Me.coldtekayitTarihi3.Name = "coldtekayitTarihi3"
        Me.coldtekayitTarihi3.Width = 222
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Çýkýþ"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1475, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 940)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1475, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 940)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1475, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 940)
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink_bekleyen, Me.printlink_genel, Me.printlink_kefil, Me.printlink_sozlesme, Me.printlink_sinif, Me.printlink_kimlik, Me.printlink_musteri})
        '
        'printlink_bekleyen
        '
        Me.printlink_bekleyen.Component = Me.Grid_bekleyen
        '
        '
        '
        Me.printlink_bekleyen.ImageCollection.ImageStream = CType(resources.GetObject("printlink_bekleyen.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink_bekleyen.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink_bekleyen.Owner = Me.printlink_musteri
        Me.printlink_bekleyen.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink_bekleyen.PrintingSystem = Me.ps
        Me.printlink_bekleyen.PrintingSystemBase = Me.ps
        '
        'printlink_musteri
        '
        Me.printlink_musteri.BreakSpace = 1
        '
        '
        '
        Me.printlink_musteri.ImageCollection.ImageStream = CType(resources.GetObject("printlink_musteri.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink_musteri.Landscape = True
        Me.printlink_musteri.Links.AddRange(New Object() {Me.printlink_genel, Me.printlink_kefil, Me.printlink_sozlesme, Me.printlink_bekleyen})
        Me.printlink_musteri.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink_musteri.Owner = Nothing
        Me.printlink_musteri.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Müþteri Bilgileri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink_musteri.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink_musteri.PrintingSystem = Me.ps
        Me.printlink_musteri.PrintingSystemBase = Me.ps
        '
        'printlink_genel
        '
        Me.printlink_genel.Component = Me.VGrid_genel
        '
        '
        '
        Me.printlink_genel.ImageCollection.ImageStream = CType(resources.GetObject("printlink_genel.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink_genel.Landscape = True
        Me.printlink_genel.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink_genel.Owner = Me.printlink_musteri
        Me.printlink_genel.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Müþteri Genel Bilgileri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink_genel.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink_genel.PrintingSystem = Me.ps
        Me.printlink_genel.PrintingSystemBase = Me.ps
        '
        'printlink_kefil
        '
        Me.printlink_kefil.Component = Me.GridControl1
        '
        '
        '
        Me.printlink_kefil.ImageCollection.ImageStream = CType(resources.GetObject("printlink_kefil.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink_kefil.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink_kefil.Owner = Me.printlink_musteri
        Me.printlink_kefil.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink_kefil.PrintingSystem = Me.ps
        Me.printlink_kefil.PrintingSystemBase = Me.ps
        '
        'printlink_sozlesme
        '
        Me.printlink_sozlesme.Component = Me.Gridcontrol2
        '
        '
        '
        Me.printlink_sozlesme.ImageCollection.ImageStream = CType(resources.GetObject("printlink_sozlesme.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink_sozlesme.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink_sozlesme.Owner = Me.printlink_musteri
        Me.printlink_sozlesme.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink_sozlesme.PrintingSystem = Me.ps
        Me.printlink_sozlesme.PrintingSystemBase = Me.ps
        '
        'printlink_sinif
        '
        Me.printlink_sinif.Component = Me.VGrid_sinif
        '
        '
        '
        Me.printlink_sinif.ImageCollection.ImageStream = CType(resources.GetObject("printlink_sinif.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink_sinif.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink_sinif.Owner = Nothing
        Me.printlink_sinif.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink_sinif.PrintingSystem = Me.ps
        Me.printlink_sinif.PrintingSystemBase = Me.ps
        '
        'printlink_kimlik
        '
        Me.printlink_kimlik.Component = Me.VGrid_kimlik
        '
        '
        '
        Me.printlink_kimlik.ImageCollection.ImageStream = CType(resources.GetObject("printlink_kimlik.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink_kimlik.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink_kimlik.Owner = Nothing
        Me.printlink_kimlik.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink_kimlik.PrintingSystem = Me.ps
        Me.printlink_kimlik.PrintingSystemBase = Me.ps
        '
        'frm_musteri_karti
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1475, 970)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_musteri_karti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Kartý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl10.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kefil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.VGrid_kimlik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kimlik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.VGrid_sinif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_sinif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.Gridcontrol2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_sozlesme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_tanimlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_tanimlar.ResumeLayout(False)
        CType(Me.VGrid_genel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.Grid_satis_detay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.Grid_satis_odeme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_satis_kapatma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.Grid_satis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.grid_odemeler_kalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.Grid_odemeler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.Grid_bekleyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.Grid_Takip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.PanelControl8.PerformLayout()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage7.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbMusteriResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink_bekleyen.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink_musteri.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink_genel.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink_kefil.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink_sozlesme.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink_sinif.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink_kimlik.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public musteriID
    Public kullanici
    Dim ds_satislar As DataSet
    Dim ds_detay As DataSet
    Dim ds_kapatma As DataSet
    Dim ds_satis_odeme As DataSet
    Dim ds_odemeler As DataSet
    Dim ds_odemeler_kalan As DataSet
    Dim ds_bekleyenler As DataSet
    Dim ds_cari As DataSet
    Dim ds_takip As DataSet
    Dim ds_ekstre As DataSet
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private Sub frm_musteri_karti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If musterino = 0 Then
            musteri_sec()
        Else
            dataload()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
    Public Function stok() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nMusteriID, sMagaza, lKodu, sAdi, sSoyadi, sAdi + ' ' + sSoyadi AS Musteri, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, sEmail, sIsYeriAdi, sIsAdresi1 + ' ' + sIsAdresi2 + ' ' + sIsSemt + ' ' + sIsIl + ' ' + sIsPostaKodu AS sIsAdresi, sIsTelefonu, sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvSemt + ' ' + sEvPostaKodu + ' ' + sEvIl AS sEvAdresi, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, dteKayitTarihi, sAciklama1 + ' ' + sAciklama2 + ' ' + sAciklama3 + ' ' + sAciklama4 + ' ' + sAciklama5 AS ISTIHBARAT, sGSM, sFax FROM tbMusteri WHERE nMusteriID ='" & musteriID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function kefil(ByVal musteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT nMusteriID , sAdi + ' ' + sSoyadi AS sAdi , sUnvan , sEmail , sIsYeriAdi , sIsAdresi1 + ' ' + sIsAdresi2 + ' ' + sIsSemt + ' ' + sIsPostaKodu + ' ' + sIsIl AS sIsAdresi , sIsTelefonu , sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvSemt + ' ' + sEvPostaKodu + ' ' + sEvIl AS sEvAdresi , sEvTelefonu , lAylikGelir , sKullaniciAdi , dteKayitTarihi FROM tbMusteriKefil1 UNION SELECT nMusteriID , sAdi + ' ' + sSoyadi AS sAdi , sUnvan , sEmail , sIsYeriAdi , sIsAdresi1 + ' ' + sIsAdresi2 + ' ' + sIsSemt + ' ' + sIsPostaKodu + ' ' + sIsIl AS sIsAdresi , sIsTelefonu , sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvSemt + ' ' + sEvPostaKodu + ' ' + sEvIl AS sEvAdresi , sEvTelefonu , lAylikGelir , sKullaniciAdi , dteKayitTarihi FROM tbMusteriKefil2) TT WHERE nMusteriID ='" & musteriID & "' and sAdi <> ''")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Takip(ByVal musteriID As String) As DataSet
        Dim kriter As String = ""
        kriter += " Where nMusteriID = '" & musteriID & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT     *  FROM         aEmirMusteriTakip " & kriter & " ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sozlesme(ByVal musteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nMusteriID, nKartNo, sAciklama, dteSonKullanmaTarihi, sKullaniciAdi, dteKayitTarihi FROM tbMusteriKarti WHERE nMusteriID ='" & musteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function kimlik(ByVal musteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nMusteriID, sDin, sKutukIl, sKutukIlce, sKutukMahalle, sKutukCiltNo, sKutukSiraNo, dteNufusCuzdanTarihi, sCuzdanVerilenYer, sCuzdanVerNedeni, sCuzdanKayitNo, sAnneAdi, sBabaAdi, sAileAdresi1 + ' ' + sAileAdresi2 + ' ' + sAileSemt + ' ' + sAilePostaKodu + ' ' + sAileIl AS sAileAdresi, sAileTelefonu FROM tbMusteriNufusu WHERE nMusteriID ='" & musteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function odemeler_kalan(ByVal musteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, dbo.AYTOSTR(MONTH(tbTaksit.dteTarihi)) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi as Ad, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, tbMusteri.sSoyadi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musteriID & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi  , tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function bekleyenler(ByVal musteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu, rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama, (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbStok.sRenk = tbRenk.sRenk AND tbMusteri.lKodu BETWEEN 0 AND 999999999 AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "' AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK') AND tbAlisverisSiparis.dteOnayTarihi = '01/01/1900' AND tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048' " & kriter & " ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu, rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama, (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbStok.sRenk = tbRenk.sRenk AND tbMusteri.lKodu BETWEEN 0 AND 999999999 AND tbAlisveris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048' and tbMusteri.nMusteriID ='" & musteriID & "' AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK') AND tbAlisverisSiparis.dteOnayTarihi = '01/01/1900' AND tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048'  ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function odemeler(ByVal musteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED                           SELECT *, ROUND(CAST(cast(Tarihi AS INT) - (CAST(Taksit_Tarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT dbo.tbOdeme.nOdemeID AS Odeme_Tanimlama_No , dbo.tbMusteri.nMusteriID AS Fis_Musteri_TanimlamaNo , dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu , dbo.tbMusteri.sAdi AS Fis_Musteri_Adi , dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi , dbo.tbOdeme.nOdemeKodu AS Odeme_Kodu , dbo.tbOdeme.sOdemeSekli AS Odeme_Sekli , dbo.tbOdemeSekli.sAciklama AS Odeme_Sekli_Aciklamasi , dbo.tbKasiyer.sKasiyerRumuzu AS Alan_Kasiyer_Rumuzu , dbo.tbKasiyer.sAdi AS Alan_Kasiyer_Adi , dbo.tbKasiyer.sSoyadi AS Alan_Kasiyer_Soyadi , dbo.tbOdeme.dteOdemeTarihi AS Tarihi , dbo.tbOdeme.dteKayitTarihi,dbo.tbOdeme.lOdemeTutar AS Tutari , dbo.tbOdeme.sDovizCinsi AS DovizCinsi , dbo.tbOdeme.lDovizTutar AS DovizTutari , dbo.tbOdeme.lMakbuzNo AS MakbuzNo , dbo.tbOdeme.lOdemeNo AS OdemeNo , dbo.tbAlisVeris.dteFaturaTarihi AS Alisveris_Tarihi , dbo.tbAlisVeris.lFaturaNo AS Alisveris_FaturaNo , dbo.tbAlisVeris.sHareketTipi AS Alisveris_HareketTipi , dbo.tbAlisVeris.sFisTipi AS Alisveris_sFistipi , ISNULL(dbo.tbTaksit.dteTarihi , dbo.tbAlisVeris.dteFaturaTarihi) AS Taksit_Tarihi , dbo.tbAlisVeris.nAlisverisID FROM dbo.tbTaksit RIGHT OUTER JOIN dbo.tbKasiyer INNER JOIN dbo.tbAlisVeris INNER JOIN dbo.tbOdeme INNER JOIN dbo.tbOdemeSekli ON dbo.tbOdeme.sOdemeSekli = dbo.tbOdemeSekli.sOdemeSekli ON dbo.tbAlisVeris.nAlisverisID = dbo.tbOdeme.nAlisverisID ON dbo.tbKasiyer.sKasiyerRumuzu = dbo.tbOdeme.sKasiyerRumuzu INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbTaksit.nTaksitID = dbo.tbOdeme.nTaksitID WHERE (dbo.tbOdeme.nOdemeKodu = 2)) AS TT  WHERE  (Fis_Musteri_TanimlamaNo = " & musteriID & ") ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sinif(ByVal musteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteriSinifi.nMusteriID, tbMSinif1.sAciklama AS Sýnýf1, tbMSinif10.sAciklama AS Sýnýf10, tbMSinif11.sAciklama AS Sýnýf11, tbMSinif12.sAciklama AS Sýnýf12, tbMSinif13.sAciklama AS Sýnýf13, tbMSinif5.sAciklama AS Sýnýf5, tbMSinif14.sAciklama AS Sýnýf14, tbMSinif15.sAciklama AS Sýnýf15, tbMSinif2.sAciklama AS Sýnýf2, tbMSinif3.sAciklama AS Sýnýf3, tbMSinif4.sAciklama AS Sýnýf4, tbMSinif6.sAciklama AS Sýnýf6, tbMSinif7.sAciklama AS Sýnýf7, tbMSinif8.sAciklama AS Sýnýf8, tbMSinif9.sAciklama AS Sýnýf9 FROM tbMusteriSinifi INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif10 ON tbMusteriSinifi.sSinifKodu10 = tbMSinif10.sSinifKodu INNER JOIN tbMSinif11 ON tbMusteriSinifi.sSinifKodu11 = tbMSinif11.sSinifKodu INNER JOIN tbMSinif12 ON tbMusteriSinifi.sSinifKodu12 = tbMSinif12.sSinifKodu INNER JOIN tbMSinif13 ON tbMusteriSinifi.sSinifKodu13 = tbMSinif13.sSinifKodu INNER JOIN tbMSinif14 ON tbMusteriSinifi.sSinifKodu14 = tbMSinif14.sSinifKodu INNER JOIN tbMSinif15 ON tbMusteriSinifi.sSinifKodu15 = tbMSinif15.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu INNER JOIN tbMSinif6 ON tbMusteriSinifi.sSinifKodu6 = tbMSinif6.sSinifKodu INNER JOIN tbMSinif7 ON tbMusteriSinifi.sSinifKodu7 = tbMSinif7.sSinifKodu INNER JOIN tbMSinif8 ON tbMusteriSinifi.sSinifKodu8 = tbMSinif8.sSinifKodu INNER JOIN tbMSinif9 ON tbMusteriSinifi.sSinifKodu9 = tbMSinif9.sSinifKodu WHERE tbMusteriSinifi.nMusteriID ='" & musteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function satis_detay(ByVal fistipi As String, ByVal stokno As String) As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim sorgu As Boolean
        If fistipi = "K" Then
            sorgu = True
        ElseIf fistipi = "P" Then
            sorgu = True
        ElseIf fistipi = "Ks" Then
            sorgu = True
        ElseIf fistipi = "PD" Then
            sorgu = True
        ElseIf fistipi = "PTX" Then
            sorgu = True
        Else
            sorgu = False
        End If
        If sorgu = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID,tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi,tbStokFisiDetayi.sFiyatTipi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisVeris.nAlisverisID ='" & Trim(stokno) & "'")
        ElseIf sorgu = False Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID,tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lBrutTutar AS lNetTutar, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisverisSiparis.sIadeNedeni AS IadeAvInf, tbAlisverisSiparis.dteTeslimEdilecek AS Termin, tbAlisverisSiparis.dteTeslimEdilen AS Teslimat, tbAlisverisSiparis.bTeslimEdildi AS TeslimEdildi, tbAlisverisSiparis.dteOnayTarihi AS Onay, tbAlisVeris.sMagaza, tbStok.sRenk FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE  tbAlisVeris.nAlisverisID ='" & Trim(stokno) & "'")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function satis_kapatma(ByVal belgeno As String) As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dbo.tbMusteri.nMusteriID AS Fis_TanimlamaNo, dbo.tbAlisVeris.sFisTipi AS Fis_Tipi, dbo.tbMusteri.nMusteriID AS Fis_Musteri_Tanimlama_No, dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu, dbo.tbMusteri.sAdi AS Fis_Musteri_Adi, dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi, dbo.tbTaksit.nTaksitID AS Taksit_Fis_TanimlamaNo, dbo.tbTaksit.dteTarihi AS Taksit_Tarihi, dbo.tbTaksit.lTutari AS Taksit_Tutari, SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Odeme_tutar, dbo.tbAlisVeris.nAlisverisID AS Alisveris_TanimlamaNo, dbo.tbTaksit.lTutari - SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Musteri_Taksiti FROM dbo.tbOdeme RIGHT OUTER JOIN dbo.tbTaksit INNER JOIN dbo.tbAlisVeris ON dbo.tbTaksit.nAlisverisID = dbo.tbAlisVeris.nAlisverisID INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbOdeme.nTaksitID = dbo.tbTaksit.nTaksitID where tbAlisveris.nAlisverisID ='" & belgeno & "' GROUP BY dbo.tbMusteri.nMusteriID, dbo.tbAlisVeris.sFisTipi, dbo.tbMusteri.lKodu, dbo.tbMusteri.sAdi, dbo.tbMusteri.sSoyadi, dbo.tbTaksit.nTaksitID, dbo.tbTaksit.dteTarihi, dbo.tbTaksit.lTutari, dbo.tbAlisVeris.nAlisverisID ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function satis_odemeleri(ByVal belgeno As String) As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dbo.tbMusteri.nMusteriID AS Fis_TanimlamaNo, dbo.tbAlisVeris.sFisTipi AS Fis_Tipi, dbo.tbMusteri.nMusteriID AS Fis_Musteri_Tanimlama_No, dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu, dbo.tbMusteri.sAdi AS Fis_Musteri_Adi, dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi, dbo.tbTaksit.nTaksitID AS Taksit_Fis_TanimlamaNo, dbo.tbTaksit.dteTarihi AS Taksit_Tarihi, dbo.tbTaksit.lTutari AS Taksit_Tutari, SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Odeme_tutar, dbo.tbAlisVeris.nAlisverisID AS Alisveris_TanimlamaNo, dbo.tbTaksit.lTutari - SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Musteri_Taksiti FROM dbo.tbOdeme RIGHT OUTER JOIN dbo.tbTaksit INNER JOIN dbo.tbAlisVeris ON dbo.tbTaksit.nAlisverisID = dbo.tbAlisVeris.nAlisverisID INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbOdeme.nTaksitID = dbo.tbTaksit.nTaksitID where tbAlisveris.nAlisverisID ='" & belgeno & "' GROUP BY dbo.tbMusteri.nMusteriID, dbo.tbAlisVeris.sFisTipi, dbo.tbMusteri.lKodu, dbo.tbMusteri.sAdi, dbo.tbMusteri.sSoyadi, dbo.tbTaksit.nTaksitID, dbo.tbTaksit.dteTarihi, dbo.tbTaksit.lTutari, dbo.tbAlisVeris.nAlisverisID ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, ROUND(CAST(cast(Tarihi AS INT) - (CAST(Taksit_Tarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT dbo.tbOdeme.nOdemeID AS Odeme_Tanimlama_No , dbo.tbMusteri.nMusteriID AS Fis_Musteri_TanimlamaNo , dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu , dbo.tbMusteri.sAdi AS Fis_Musteri_Adi , dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi , dbo.tbOdeme.nOdemeKodu AS Odeme_Kodu , dbo.tbOdeme.sOdemeSekli AS Odeme_Sekli , dbo.tbOdemeSekli.sAciklama AS Odeme_Sekli_Aciklamasi , dbo.tbKasiyer.sKasiyerRumuzu AS Alan_Kasiyer_Rumuzu , dbo.tbKasiyer.sAdi AS Alan_Kasiyer_Adi , dbo.tbKasiyer.sSoyadi AS Alan_Kasiyer_Soyadi , dbo.tbOdeme.dteOdemeTarihi AS Tarihi , dbo.tbOdeme.lOdemeTutar AS Tutari , dbo.tbOdeme.sDovizCinsi AS DovizCinsi , dbo.tbOdeme.lDovizTutar AS DovizTutari , dbo.tbOdeme.lMakbuzNo AS MakbuzNo , dbo.tbOdeme.lOdemeNo AS OdemeNo , dbo.tbAlisVeris.dteFaturaTarihi AS Alisveris_Tarihi , dbo.tbAlisVeris.lFaturaNo AS Alisveris_FaturaNo , dbo.tbAlisVeris.sHareketTipi AS Alisveris_HareketTipi , dbo.tbAlisVeris.sFisTipi AS Alisveris_sFistipi , ISNULL(dbo.tbTaksit.dteTarihi , dbo.tbAlisVeris.dteFaturaTarihi) AS Taksit_Tarihi , dbo.tbAlisVeris.nAlisverisID FROM dbo.tbTaksit RIGHT OUTER JOIN dbo.tbKasiyer INNER JOIN dbo.tbAlisVeris INNER JOIN dbo.tbOdeme INNER JOIN dbo.tbOdemeSekli ON dbo.tbOdeme.sOdemeSekli = dbo.tbOdemeSekli.sOdemeSekli ON dbo.tbAlisVeris.nAlisverisID = dbo.tbOdeme.nAlisverisID ON dbo.tbKasiyer.sKasiyerRumuzu = dbo.tbOdeme.sKasiyerRumuzu INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbTaksit.nTaksitID = dbo.tbOdeme.nTaksitID WHERE (dbo.tbOdeme.nOdemeKodu IN (1,2))) AS TT WHERE (nAlisverisID = '" & belgeno & "') ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_satislar_detayli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nAlisverisID,sFisTipi, dteFaturaTarihi, nGirisCikis, lToplamMiktar, lNetTutar,lPesinat, lFaturaNo, sMagaza, sKasiyerRumuzu, nKasaNo, dteKayitTarihi, sYaziIle  FROM         tbAlisVeris  WHERE     (nMusteriID = " & musterino & ") ORDER BY dteFaturaTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_ekstre_detayli(ByVal musterino As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,CAST(0 as MONEY) as lBakiye FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi,tbStokFisiDetayi.sFiyatTipi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND lKodu = '" & musterino & "'  UNION ALL SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbalisverisSiparis.lGCMiktar, 0) AS Miktar, isnull(tbalisverisSiparis.lBrutFiyat, 0) AS Fiyat, isnull(tbalisverisSiparis.lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefaturaTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbalisverisSiparis.lBrutTutar - tbalisverisSiparis.lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, tbAlisverisSiparis.sIadeNedeni AS OdemeTipi, rtrim(tbalisverisSiparis.sSaticiRumuzu) + (CASE WHEN rtrim(tbalisverisSiparis.sSaticiRumuzu) <> '' THEN ' - ' ELSE '' END) + (CASE bTeslimEdildi WHEN 0 THEN CONVERT(char(10), dteTeslimEdilecek, 103) ELSE CONVERT(char(10), dteTeslimEdilen, 103) END) AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, bTeslimEdildi * (CASE bEkAlan2 WHEN '' THEN 1 ELSE 0 END) AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, 0 AS nIslemID, tbalisverisSiparis.sOdemeKodu AS StokOdeme, isnull(CONVERT(char(10), dteFisTarihi, 103) + ' - ' + ltrim(tbStokFisiDetayi.sFisTipi) + ' - ' + ltrim(str(tbStokFisiDetayi.lFisNo)), '') AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi,tbAlisVerisSiparis.sFiyatTipi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbalisverisSiparis ON tbalisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbalisverisSiparis.nStokID LEFT OUTER JOIN tbStokFisiDetayi ON tbalisverisSiparis.nStokIslemID = tbStokFisiDetayi.nIslemID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND lKodu = '" & musterino & "' UNION ALL SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, lNetTutar = CASE WHEN sFistipi = 'Pad' THEN lNetTutar ELSE lVadeFarki END, 0 AS OdemeTutar, '' AS OdemeTipi, '' AS SaticiRumuzu, sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi AS OdemeAciklama, 1 AS Tipi, tbAlisVeris.nGirisCikis AS nGirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM tbAlisVeris, tbMusteri WHERE tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'PAD' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND lKodu = '" & musterino & "' UNION ALL SELECT lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, SUM(OdemeTutar), OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, Id, TaksitTarihi, SUM(TaksitTutari), OdemeAciklama, Tipi, GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dteOdemeTarihi AS dteTarih, FisTipi = CASE WHEN nOdemekodu <> 1 THEN 'Z' ELSE tbAlisVeris.sFisTipi END, lNo = CASE WHEN nOdemekodu <> 1 THEN 0 ELSE tbalisveris.lFaturaNo END, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, 0 AS lNetTutar, lOdemeTutar AS OdemeTutar, tbOdeme.sOdemeSekli AS OdemeTipi, '' AS SaticiRumuzu, tbOdeme.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, '' AS AlisverisiYapan, Id = CASE WHEN nOdemekodu <> 1 THEN '0' ELSE tbOdeme.nAlisVerisId END, '01/01/2078' AS TaksitTarihi, cast(nOdemeKodu AS int) AS TaksitTutari, CONVERT(char(10), dteOdemeTarihi, 103) AS OdemeAciklama, 2 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM tbAlisVeris, tbMusteri, tbOdeme, tbOdemeSekli WHERE tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli AND TbOdeme.nAlisverisId = TbAlisveris.nAlisverisId AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND (nOdemeKodu < 3) AND dteOdemeTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'PAD' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND lKodu = '" & musterino & "') AS a GROUP BY GirisCikis, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, Id, TaksitTarihi, OdemeAciklama, Tipi UNION ALL SELECT lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, '0' Id, TaksitTarihi, SUM(TaksitTutari), OdemeAciklama, Tipi, 5 AS GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, '31/12/2078' AS dteTarih, '' AS fisTipi, 0 AS lNo, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, 0 AS lNetTutar, 0 AS OdemeTutar, '' AS OdemeTipi, '' AS SaticiRumuzu, '' AS KasiyerRumuzu, '' AS Teslimatci, '' AS AlisverisiYapan, tbTaksit.nTaksitId AS Id, dteTarihi AS TaksitTarihi, lTutari - SUM(Isnull(lOdemeTutar, 0)) AS TaksitTutari, '' AS OdemeAciklama, 3 AS Tipi, 5 AS GirisCikis, '' IadeAvInf, 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM tbMusteri INNER JOIN (SELECT DISTINCT tbAlisVeris.nMusteriID FROM tbAlisVeris, tbMusteri WHERE dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078 ' AND tbMusteri.nMusteriID = tbAlisVeris.nMusteriID AND lKodu = '" & musterino & "') AS tbTemp ON tbMusteri.nMusteriID = tbTemp.nMusteriID, tbAlisVeris, tbTaksit LEFT OUTER JOIN tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbMusteri.nMusteriID = tbAlisVeris.nMusteriID AND lKodu = '" & musterino & "' GROUP BY tbTaksit.nTaksitId, tbAlisVeris.nGirisCikis, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, dteTarihi, lTutari HAVING lTutari - IsNull(SUM(tbOdeme.lOdemeTutar), 0) <> 0) AS a GROUP BY GirisCikis, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, TaksitTarihi, OdemeAciklama, Tipi) AS TT WHERE     dteTarih <> '31.12.2078'  and dteTarih Between '" & tarih1 & "' and '" & tarih2 & "' ORDER BY lKodu, dteTarih, GirisCikis, fisTipi, lno, Tipi, TaksitTarihi, Id, nIslemId")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,CAST(0 as MONEY) as lBakiye FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, /*IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END,*/ lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi,tbStokFisiDetayi.sFiyatTipi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND lKodu = '" & musterino & "'  UNION ALL SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbalisverisSiparis.lGCMiktar, 0) AS Miktar, isnull(tbalisverisSiparis.lBrutFiyat, 0) AS Fiyat, isnull(tbalisverisSiparis.lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefaturaTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbalisverisSiparis.lBrutTutar - tbalisverisSiparis.lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, tbAlisverisSiparis.sIadeNedeni AS OdemeTipi, rtrim(tbalisverisSiparis.sSaticiRumuzu) + (CASE WHEN rtrim(tbalisverisSiparis.sSaticiRumuzu) <> '' THEN ' - ' ELSE '' END) + (CASE tbAlisverisSiparis.bTeslimEdildi WHEN 0 THEN CONVERT(char(10), dteTeslimEdilecek, 103) ELSE CONVERT(char(10), dteTeslimEdilen, 103) END) AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, tbAlisverisSiparis.bTeslimEdildi * (CASE bEkAlan2 WHEN '' THEN 1 ELSE 0 END) AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, /*IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END,*/ lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, 0 AS nIslemID, tbalisverisSiparis.sOdemeKodu AS StokOdeme, isnull(CONVERT(char(10), dteFisTarihi, 103) + ' - ' + ltrim(tbStokFisiDetayi.sFisTipi) + ' - ' + ltrim(str(tbStokFisiDetayi.lFisNo)), '') AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi,tbAlisVerisSiparis.sFiyatTipi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbalisverisSiparis ON tbalisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbalisverisSiparis.nStokID LEFT OUTER JOIN tbStokFisiDetayi ON tbalisverisSiparis.nStokIslemID = tbStokFisiDetayi.nIslemID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND lKodu = '" & musterino & "' UNION ALL SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, lNetTutar = CASE WHEN sFistipi = 'Pad' THEN lNetTutar ELSE lVadeFarki END, 0 AS OdemeTutar, '' AS OdemeTipi, '' AS SaticiRumuzu, sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi AS OdemeAciklama, 1 AS Tipi, tbAlisVeris.nGirisCikis AS nGirisCikis, /*'' as IadeAvInf,*/ 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM tbAlisVeris, tbMusteri WHERE tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'PAD' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND lKodu = '" & musterino & "' UNION ALL SELECT lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, SUM(OdemeTutar), OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, Id, TaksitTarihi, SUM(TaksitTutari), OdemeAciklama, Tipi, GirisCikis, /*'' as IadeAvInf,*/ 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dteOdemeTarihi AS dteTarih, FisTipi = CASE WHEN nOdemekodu <> 1 THEN 'Z' ELSE tbAlisVeris.sFisTipi END, lNo = CASE WHEN nOdemekodu <> 1 THEN 0 ELSE tbalisveris.lFaturaNo END, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, 0 AS lNetTutar, lOdemeTutar AS OdemeTutar, tbOdeme.sOdemeSekli AS OdemeTipi, '' AS SaticiRumuzu, tbOdeme.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, '' AS AlisverisiYapan, Id = CASE WHEN nOdemekodu <> 1 THEN '0' ELSE tbOdeme.nAlisVerisId END, '01/01/2078' AS TaksitTarihi, cast(nOdemeKodu AS int) AS TaksitTutari, CONVERT(char(10), dteOdemeTarihi, 103) AS OdemeAciklama, 2 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, /*'' as IadeAvInf,*/ 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM tbAlisVeris, tbMusteri, tbOdeme, tbOdemeSekli WHERE tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli AND TbOdeme.nAlisverisId = TbAlisveris.nAlisverisId AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND (nOdemeKodu < 3) AND dteOdemeTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'PAD' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND lKodu = '" & musterino & "') AS a GROUP BY GirisCikis, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, Id, TaksitTarihi, OdemeAciklama, Tipi UNION ALL SELECT lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, '0' Id, TaksitTarihi, SUM(TaksitTutari), OdemeAciklama, Tipi, 5 AS GirisCikis, /*'' as IadeAvInf,*/ 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM (SELECT tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, '31/12/2078' AS dteTarih, '' AS fisTipi, 0 AS lNo, '' AS sKodu, '' AS sStokAciklama, 0 AS Miktar, 0 AS Fiyat, 0 AS Iskonto, 0 AS lNetTutar, 0 AS OdemeTutar, '' AS OdemeTipi, '' AS SaticiRumuzu, '' AS KasiyerRumuzu, '' AS Teslimatci, '' AS AlisverisiYapan, tbTaksit.nTaksitId AS Id, dteTarihi AS TaksitTarihi, lTutari - SUM(Isnull(lOdemeTutar, 0)) AS TaksitTutari, '' AS OdemeAciklama, 3 AS Tipi, 5 AS GirisCikis, /*'' as IadeAvInf,*/ 0 AS lMalBedeli, '' AS sHareketTipi, 0 nIslemId, '' AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, '' AS KayitTarihi,'' sFiyatTipi FROM tbMusteri INNER JOIN (SELECT DISTINCT tbAlisVeris.nMusteriID FROM tbAlisVeris, tbMusteri WHERE dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078 ' AND tbMusteri.nMusteriID = tbAlisVeris.nMusteriID AND lKodu = '" & musterino & "') AS tbTemp ON tbMusteri.nMusteriID = tbTemp.nMusteriID, tbAlisVeris, tbTaksit LEFT OUTER JOIN tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbMusteri.nMusteriID = tbAlisVeris.nMusteriID AND lKodu = '" & musterino & "' GROUP BY tbTaksit.nTaksitId, tbAlisVeris.nGirisCikis, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, dteTarihi, lTutari HAVING lTutari - IsNull(SUM(tbOdeme.lOdemeTutar), 0) <> 0) AS a GROUP BY GirisCikis, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, OdemeTutar, OdemeTipi, SaticiRumuzu, KasiyerRumuzu, Teslimatci, AlisverisiYapan, TaksitTarihi, OdemeAciklama, Tipi) AS TT WHERE     dteTarih <> '31.12.2078'  and dteTarih Between '" & tarih1 & "' and '" & tarih2 & "' ORDER BY lKodu, dteTarih, GirisCikis, fisTipi, lno, Tipi, TaksitTarihi, Id, nIslemId")
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
    Private Sub dataload()
        XtraTabControl1.SelectedTabPageIndex = 0
        DataSet1 = stok()
        VGrid_genel.DataSource = DataSet1.Tables(0)
        VGrid_genel.DataMember = Nothing
        Me.Text = "Musteri Kartý"
        If DataSet1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = DataSet1.Tables(0).Rows(0)
            lbl_istihbarat.Text = dr("ISTIHBARAT")
            txt_musteriNo.EditValue = Trim(dr("lkodu"))
            Me.Text += ": " + dr("lKodu").ToString + " / "
            Me.Text += dr("Musteri").ToString
        Else
            lbl_istihbarat.Text = "*"
        End If
        ds_kefil = kefil(musteriID)
        GridControl1.DataSource = ds_kefil.Tables(0)
        GridControl1.DataMember = Nothing
        ds_sozlesme = sozlesme(musteriID)
        Gridcontrol2.DataSource = ds_sozlesme.Tables(0)
        Gridcontrol2.DataMember = Nothing
        ds_kimlik = kimlik(musteriID)
        VGrid_kimlik.DataSource = ds_kimlik.Tables(0)
        VGrid_kimlik.DataMember = Nothing
        ds_sinif = sinif(musteriID)
        VGrid_sinif.DataSource = ds_sinif.Tables(0)
        VGrid_sinif.DataMember = Nothing
        dataload_teslimatlar(txt_musteriNo.Text, "Kodu", "Eþittir", "PF", 3, "01/01/1900", "31/12/2078", 0, 999999999, 0, 999999999, "", "")
        dataload_paketler("01/01/1900", "31/12/2078", txt_musteriNo.Text, "Eþittir")
        ds_tbMusteriResim = Dataload_tbMusteriResim(musteriID)
        GridControl6.DataSource = ds_tbMusteriResim.Tables(0)
        GridControl6.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub dataload_teslimatlar(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String, Optional ByVal sSatir As Integer = 0)
        Dim query As String = ""
        Dim kriter As String = "WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        kriter += " and tbStokFisiMaster.lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'"
        kriter += " and tbStokFisiMaster.lNetTutar between '" & lNetTutar1 & "' and '" & lNetTutar2 & "'"
        If Trim(sDepo) <> "" Then
            kriter += " And tbStokFisiMaster.sDepo = '" & sDepo & "' "
        End If
        If Trim(sHareketTipi) <> "" Then
            kriter += " And tbStokFisiMaster.sHareketTipi = '" & sHareketTipi & "' "
        End If
        If nGirisCikis > 0 Then
            kriter += " and tbStokFisiMaster.nGirisCikis =" & nGirisCikis & " "
        End If
        If Trim(sFisTipi) = "PF" Then
            If CStr(Trim(ara.ToString)) <> "" Then
                If konum = "Kodu" Then
                    kriter += " AND (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf konum = "Adý" Then
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        Else
            If CStr(Trim(ara.ToString)) <> "" Then
                If konum = "Kodu" Then
                    kriter += " AND (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf konum = "Adý" Then
                    kriter += " AND (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        End If
        If Trim(sFisTipi) = "PF" Then
            query = ("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, CAST(tbStokFisiMaster.lToplamMiktar AS FLOAT) as lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, tbStokFisiMaster.bPesinmi,CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi , RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot, tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5 AS KdvTutari, tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5 AS KdvMatrahi, tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 AS EkMaliyet, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli, CAST(0 AS MONEY) AS ISKONTO, tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI, CAST(0 AS MONEY) AS EkOran, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari3, tbMusteri.nMusteriID, tbMusteri.lKodu AS sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAciklama FROM tbStokFisiMaster INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        Else
            query = ("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, CAST(tbStokFisiMaster.lToplamMiktar AS FLOAT) as lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        End If
        Dim ds_Teslimatlar As DataSet
        ds_Teslimatlar = sorgu(query)
        GridControl4.DataSource = ds_Teslimatlar.Tables(0)
    End Sub
    Public Sub dataload_paketler(ByVal ilktarih As DateTime, ByVal sontarih As DateTime, ByVal firmakodu As String, ByVal qfirmakodu As String)
        Dim kriter
        kriter = "WHERE (IND> 99) AND FIRMANO <> 0"
        kriter += " AND (TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        If firmakodu <> "" Then
            kriter += " AND (FIRMAKODU " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
        End If
        Dim Query As String = ""
        Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, KAYITTARIHI - FISKAYITTARIHI AS Sure FROM ASTOKPAKETBASLIK " & kriter & "")
        Dim ds_paketler As DataSet
        ds_paketler = sorgu(Query)
        GridControl5.DataSource = ds_paketler.Tables(0)
    End Sub
    Public Function Dataload_tbMusteriResim(ByVal nMusteriID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMusteriResim WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_satislar()
        ds_satislar = sorgu_satislar_detayli(musteriID)
        Grid_satis.DataSource = ds_satislar.Tables(0)
        Grid_satis.DataMember = Nothing
        'PanelControl3.Select()
        Grid_satis.Focus()
        Grid_satis.Select()
        GridView3.CollapseAllGroups()
    End Sub
    Private Sub dataload_odemeler()
        ds_odemeler = odemeler(musteriID)
        Grid_odemeler.DataSource = ds_odemeler.Tables(0)
        Grid_odemeler.DataMember = Nothing
        ds_odemeler_kalan = odemeler_kalan(musteriID)
        grid_odemeler_kalan.DataSource = ds_odemeler_kalan.Tables(0)
        grid_odemeler_kalan.DataMember = Nothing
        grid_odemeler_kalan.RefreshData()
        ''PanelControl3.Select()
        Grid_odemeler.Focus()
        Grid_odemeler.Select()
        GridView7.ExpandAllGroups()
    End Sub
    Private Sub dataload_bekleyenler()
        ds_bekleyenler = bekleyenler(musteriID)
        Grid_bekleyen.DataSource = ds_bekleyenler.Tables(0)
        Grid_bekleyen.DataMember = Nothing
        Grid_bekleyen.Focus()
        Grid_bekleyen.Select()
        GridView8.CollapseAllGroups()
    End Sub
    Private Sub dataload_takipler()
        ds_takip = Takip(musteriID)
        Grid_Takip.DataSource = ds_takip.Tables(0)
        Grid_Takip.DataMember = Nothing
        Grid_Takip.Focus()
        Grid_Takip.Select()
        GridView9.CollapseAllGroups()
    End Sub
    Private Sub dataload_detay()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            ds_detay = satis_detay(Trim(dr("sFistipi").ToString), dr("nAlisVerisID"))
            ds_kapatma = satis_kapatma(dr("nAlisVerisID"))
            ds_satis_odeme = satis_odemeleri(dr("nAlisVerisID"))
            Grid_satis_detay.DataSource = ds_detay.Tables(0)
            Grid_satis_detay.DataMember = Nothing
            Grid_satis_kapatma.DataSource = ds_kapatma.Tables(0)
            Grid_satis_kapatma.DataMember = Nothing
            Grid_satis_odeme.DataSource = ds_satis_odeme.Tables(0)
            Grid_satis_odeme.DataMember = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView8.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView8.GetDataRow(GridView8.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
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
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nMusteriID AS IND, lKodu AS MUSTERIKODU, sAdi + ' ' + sSoyadi AS MUSTERI FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        musteri_sec()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        ekran_kapla()
    End Sub
    Private Sub ekran_kapla()
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Try
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                'txt_stokkodu.Focus()
                'txt_stokkodu.SelectAll()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                If GridView3.RowCount = 0 Then
                    dataload_satislar()
                End If
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 2 Then
                If GridView7.RowCount = 0 Then
                    dataload_odemeler()
                End If
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 3 Then
                If GridView8.RowCount = 0 Then
                    dataload_bekleyenler()
                End If
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 4 Then
                If GridView9.RowCount = 0 Then
                    dataload_takipler()
                End If
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 7 Then
                GridControl4.Focus()
                GridControl4.Select()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 8 Then
                GridControl5.Focus()
                GridControl5.Select()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView3_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        dataload_detay()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView8.ColumnsCustomization()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        printlink_bekleyen.CreateDocument(ps)
        ps.PreviewFormEx.Show()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView8.ExpandAllGroups()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        GridView8.CollapseAllGroups()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        ekran_kapla()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If MenuItem10.Checked = False Then
            GridView8.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView8.OptionsCustomization.AllowFilter = True
            MenuItem10.Checked = True
        ElseIf MenuItem10.Checked = True Then
            GridView8.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView8.OptionsCustomization.AllowFilter = False
            MenuItem10.Checked = False
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If MenuItem11.Checked = False Then
            GridView8.OptionsView.ShowGroupPanel = True
            GridView8.OptionsCustomization.AllowGroup = True
            MenuItem11.Checked = True
        ElseIf MenuItem11.Checked = True Then
            GridView8.OptionsView.ShowGroupPanel = False
            GridView8.OptionsCustomization.AllowGroup = False
            MenuItem11.Checked = False
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink_musteri.CreateDocument(ps)
        ps.PreviewFormEx.Show()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim frm As New frm_calc
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
            Try
                ds_satislar.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_detay.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_kapatma.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_satis_odeme.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_odemeler.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_odemeler_kalan.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_bekleyenler.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_cari.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_takip.Clear()
            Catch ex As Exception
            End Try
            Try
                ds_ekstre.Clear()
            Catch ex As Exception
            End Try
            If kontrol = 0 Then
                XtraMessageBox.Show("Kayýt Bulunumadý...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    musterino = dr("MUSTERIKODU")
                    musteriID = dr("IND")
                    dataload()
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub kefil()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sAdi")
            frm.txt_ara.Text = frm.musterino
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            musteriID = dr1("nMusteriID")
            musterino = dr1("lKodu")
            txt_musteriNo.EditValue = musterino
            musteri_kontrol()
        End If
    End Sub
    Private Sub takip_duzelt()
        If GridView9.RowCount > 0 Then
            Dim frm As New frm_emir_musteri_takip_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.kasiyer = ""
            frm.kasiyerno = 0
            frm.connection = connection
            Dim dr As DataRow = GridView9.GetDataRow(GridView9.FocusedRowHandle)
            Dim satir = GridView1.FocusedRowHandle
            frm.kayitno = dr("IND")
            frm.status = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            ds_takip.Clear()
            dataload_takipler()
            GridView9.FocusedRowHandle = satir
            satir = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub incele()
        If musterino.ToString <> "" Then
            Dim dr As DataRow
            Dim bakiye As Decimal = 0
            Dim bakiye_status As String = 0
            ds_ekstre = sorgu_ekstre_detayli(musterino, sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue)
            For Each dr In ds_ekstre.Tables(0).Rows
                If dr("Tipi") <> 2 Then
                    dr("OdemeTutar") = 0
                    If Trim(dr("fisTipi").ToString) = "SK" Or Trim(dr("fisTipi").ToString) = "SP" Then
                        If Trim(dr("SevkAciklama")) <> "" Then
                            dr("Teslimatci") = "1"
                        Else
                            dr("Teslimatci") = "0"
                        End If
                    End If
                Else
                    Dim fistipi As String = Trim(dr("fisTipi").ToString)
                    If fistipi = "P" Then
                        dr("sKodu") = "Peþin Satýþ"
                        dr("sStokAciklama") = "Peþinat"
                    ElseIf fistipi = "Z" Then
                        dr("sKodu") = "Taksit"
                        dr("sStokAciklama") = "Ödeme"
                    ElseIf fistipi = "K" Then
                        dr("sKodu") = "Kredili Satýþ"
                        dr("sStokAciklama") = "Peþinat"
                    End If
                End If
                bakiye = bakiye + (dr("lNetTutar") - (dr("OdemeTutar")))
                dr("lBakiye") = bakiye 'Math.Abs(Convert.ToDecimal(bakiye))
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
            Next
            GridControl3.DataSource = ds_ekstre.Tables(0)
            GridControl3.DataMember = Nothing
            GridView10.OptionsView.ShowFooter = True
            collBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
            GridView1.UpdateSummary()
        End If
    End Sub
    Private Sub analiz_musteri_duzenle()
        Dim frm As New frm_musteri_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.lKodu = musterino
        frm.nMusteriID = musteriID
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        dataload()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_musteri_KarlilikAkisTablosu(Optional ByVal islem As Integer = 0)
        If musteriID > 0 Then
            Dim frm As New frm_stok_satis_karlilik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = dteSistemTarihi
            frm.txt_ara.Text = ""
            frm.txt_ara_stok.Text = ""
            frm.sec_MaliyetTipi.Text = "Stok Kartýndan"
            frm.kriter_musteriID = "AND tbMusteri.nMusteriID = " & musteriID & " "
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
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        musteri_sec()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        kefil()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        musteri_notlari()
    End Sub
    Private Sub musteri_notlari()
        Dim frm As New frm_musteri_karti_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = musteriID
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        dataload()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        musteri_notlari()
    End Sub
    Private Sub frm_musteri_karti_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'XtraTabControl1 = Nothing
        'XtraTabPage2 = Nothing
        'DataSet1 = Nothing
        'ds_kefil = Nothing
        'ds_kimlik = Nothing
        'ds_sinif = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn7 = Nothing
        'DataColumn8 = Nothing
        'DataColumn9 = Nothing
        'DataColumn10 = Nothing
        'DataColumn11 = Nothing
        'DataColumn12 = Nothing
        'DataColumn13 = Nothing
        'DataColumn14 = Nothing
        'DataColumn15 = Nothing
        'DataColumn16 = Nothing
        'DataColumn17 = Nothing
        'DataColumn18 = Nothing
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'DataColumn21 = Nothing
        'DataColumn22 = Nothing
        'DataColumn23 = Nothing
        'DataColumn24 = Nothing
        'DataColumn25 = Nothing
        'DataColumn26 = Nothing
        'DataColumn27 = Nothing
        'DataColumn28 = Nothing
        'DataColumn29 = Nothing
        'DataColumn30 = Nothing
        'DataColumn31 = Nothing
        'DataColumn32 = Nothing
        'DataTable2 = Nothing
        'DataColumn33 = Nothing
        'DataColumn34 = Nothing
        'DataColumn35 = Nothing
        'DataColumn36 = Nothing
        'DataColumn37 = Nothing
        'DataColumn38 = Nothing
        'DataColumn39 = Nothing
        'DataColumn40 = Nothing
        'DataColumn41 = Nothing
        'DataColumn42 = Nothing
        'DataColumn43 = Nothing
        'DataColumn44 = Nothing
        'ds_sozlesme = Nothing
        'DataTable3 = Nothing
        'DataColumn45 = Nothing
        'DataColumn46 = Nothing
        'DataColumn47 = Nothing
        'DataColumn48 = Nothing
        'DataColumn49 = Nothing
        'DataColumn50 = Nothing
        'DataTable4 = Nothing
        'DataColumn51 = Nothing
        'DataColumn52 = Nothing
        'DataColumn53 = Nothing
        'DataColumn54 = Nothing
        'DataColumn55 = Nothing
        'DataColumn56 = Nothing
        'DataColumn57 = Nothing
        'DataColumn58 = Nothing
        'DataColumn59 = Nothing
        'DataColumn60 = Nothing
        'DataColumn61 = Nothing
        'DataColumn62 = Nothing
        'DataColumn63 = Nothing
        'DataColumn64 = Nothing
        'DataColumn65 = Nothing
        'DataTable5 = Nothing
        'DataColumn66 = Nothing
        'DataColumn67 = Nothing
        'DataColumn68 = Nothing
        'DataColumn69 = Nothing
        'DataColumn70 = Nothing
        'DataColumn71 = Nothing
        'DataColumn72 = Nothing
        'DataColumn73 = Nothing
        'DataColumn74 = Nothing
        'DataColumn75 = Nothing
        'DataColumn76 = Nothing
        'DataColumn77 = Nothing
        'DataColumn78 = Nothing
        'DataColumn79 = Nothing
        'DataColumn80 = Nothing
        'DataColumn81 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'lbl_istihbarat = Nothing
        'PanelControl4 = Nothing
        'PanelControl5 = Nothing
        'GridView3 = Nothing
        'PanelControl6 = Nothing
        'PanelControl7 = Nothing
        'GridView4 = Nothing
        'GridView5 = Nothing
        'GridColumn1 = Nothing
        'coldteFaturaTarihi = Nothing
        'colnGirisCikis = Nothing
        'collToplamMiktar = Nothing
        'collPesinat = Nothing
        'GridColumn2 = Nothing
        'collFaturaNo = Nothing
        'colsMagaza = Nothing
        'colsKasiyerRumuzu = Nothing
        'colnKasaNo = Nothing
        'GridColumn3 = Nothing
        'colsYaziIle = Nothing
        'colnAlisverisID = Nothing
        'collKodu = Nothing
        'collMusteriAdi = Nothing
        'coldteTarih = Nothing
        'colsFisTipi = Nothing
        'collNo = Nothing
        'colsKodu = Nothing
        'GridColumn4 = Nothing
        'colMiktar = Nothing
        'colFiyat = Nothing
        'colIskonto = Nothing
        'collNetTutar = Nothing
        'colOdemeTutar = Nothing
        'colOdemeTipi = Nothing
        'colSaticiRumuzu = Nothing
        'colKasiyerRumuzu = Nothing
        'colTeslimatci = Nothing
        'colOdemeAciklama = Nothing
        'colGirisCikis = Nothing
        'colMalBedeli = Nothing
        'colIadeAvInf = Nothing
        'colsHareketTipi = Nothing
        'colnIslemId = Nothing
        'colStokOdeme = Nothing
        'colSevkAciklama = Nothing
        'colKalanTaksit = Nothing
        'colKayitTarihi = Nothing
        'colsFiyatTipi = Nothing
        'colFis_TanimlamaNo = Nothing
        'colFis_Tipi = Nothing
        'colFis_Musteri_Tanimlama_No = Nothing
        'colFis_Musteri_Kodu = Nothing
        'colFis_Musteri_Adi = Nothing
        'colFis_Musteri_Soyadi = Nothing
        'colTaksit_Fis_TanimlamaNo = Nothing
        'colTaksit_Tarihi = Nothing
        'colTaksit_Tutari = Nothing
        'colAlisveris_TanimlamaNo = Nothing
        'colMusteri_Taksiti = Nothing
        'colOdeme_tutar = Nothing
        'Grid_satis = Nothing
        'Grid_satis_detay = Nothing
        'Grid_satis_kapatma = Nothing
        'GridView6 = Nothing
        'colFis_Musteri_TanimlamaNo = Nothing
        'GridColumn5 = Nothing
        'GridColumn6 = Nothing
        'GridColumn7 = Nothing
        'colOdeme_Kodu = Nothing
        'colOdeme_Sekli = Nothing
        'colOdeme_Sekli_Aciklamasi = Nothing
        'colAlan_Kasiyer_Rumuzu = Nothing
        'colAlan_Kasiyer_Adi = Nothing
        'colAlan_Kasiyer_Soyadi = Nothing
        'colTarihi = Nothing
        'colTutari = Nothing
        'colDovizCinsi = Nothing
        'colDovizTutari = Nothing
        'colMakbuzNo = Nothing
        'colOdemeNo = Nothing
        'colAlisveris_Tarihi = Nothing
        'colAlisveris_FaturaNo = Nothing
        'colAlisveris_HareketTipi = Nothing
        'colAlisVeris_sFisTipi = Nothing
        'GridColumn8 = Nothing
        'colGECIKME = Nothing
        'Grid_satis_odeme = Nothing
        'XtraTabPage3 = Nothing
        'XtraTabPage4 = Nothing
        'GroupControl6 = Nothing
        'SplitterControl1 = Nothing
        'GroupControl7 = Nothing
        'GridView7 = Nothing
        'GridColumn9 = Nothing
        'GridColumn10 = Nothing
        'GridColumn11 = Nothing
        'GridColumn12 = Nothing
        'GridColumn13 = Nothing
        'GridColumn14 = Nothing
        'GridColumn15 = Nothing
        'GridColumn16 = Nothing
        'GridColumn17 = Nothing
        'GridColumn18 = Nothing
        'GridColumn19 = Nothing
        'GridColumn20 = Nothing
        'GridColumn21 = Nothing
        'GridColumn22 = Nothing
        'GridColumn23 = Nothing
        'GridColumn24 = Nothing
        'GridColumn25 = Nothing
        'GridColumn26 = Nothing
        'GridColumn27 = Nothing
        'GridColumn28 = Nothing
        'GridColumn29 = Nothing
        'GridColumn30 = Nothing
        'sec_renk = Nothing
        'PivotGridField1 = Nothing
        'PivotGridField2 = Nothing
        'PivotGridField3 = Nothing
        'PivotGridField4 = Nothing
        'PivotGridField5 = Nothing
        'PivotGridField6 = Nothing
        'PivotGridField7 = Nothing
        'PivotGridField8 = Nothing
        'PivotGridField9 = Nothing
        'PivotGridField10 = Nothing
        'PivotGridField11 = Nothing
        'PivotGridField12 = Nothing
        'PivotGridField13 = Nothing
        'PivotGridField14 = Nothing
        'PivotGridField15 = Nothing
        'PivotGridField16 = Nothing
        'PivotGridField17 = Nothing
        'PivotGridField18 = Nothing
        'PivotGridField19 = Nothing
        'PivotGridField20 = Nothing
        'Grid_odemeler = Nothing
        'grid_odemeler_kalan = Nothing
        'GridView8 = Nothing
        'GridColumn31 = Nothing
        'colMusteri = Nothing
        'GridColumn32 = Nothing
        'colsModel = Nothing
        'colsRenk = Nothing
        'colsRenkAdi = Nothing
        'colsBeden = Nothing
        'colsKavala = Nothing
        'GridColumn33 = Nothing
        'GridColumn34 = Nothing
        'collBrutFiyat = Nothing
        'colTutar = Nothing
        'colDepo = Nothing
        'GridColumn35 = Nothing
        'GridColumn36 = Nothing
        'coldteTeslimEdilecek = Nothing
        'coldteOnayTarihi = Nothing
        'coldteTeslimEdilen = Nothing
        'colIZAHAT = Nothing
        'Grid_bekleyen = Nothing
        'XtraTabPage1 = Nothing
        'PanelControl9 = Nothing
        'PanelControl10 = Nothing
        'panel_tanimlar = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'GroupControl1 = Nothing
        'GroupControl2 = Nothing
        'GroupControl3 = Nothing
        'colnMusteriID = Nothing
        'colsAdi = Nothing
        'colsUnvan = Nothing
        'colsEmail = Nothing
        'colsIsYeriAdi = Nothing
        'colsIsAdresi = Nothing
        'colsIsTelefonu = Nothing
        'colsEvAdresi = Nothing
        'colsEvTelefonu = Nothing
        'collAylikGelir = Nothing
        'colsKullaniciAdi = Nothing
        'coldteKayitTarihi = Nothing
        'GridView2 = Nothing
        'colnMusteriID1 = Nothing
        'colnKartNo = Nothing
        'colsAciklama = Nothing
        'coldteSonKullanmaTarihi = Nothing
        'colsKullaniciAdi1 = Nothing
        'coldteKayitTarihi1 = Nothing
        'VGrid_kimlik = Nothing
        'rownMusteriID = Nothing
        'rowsDin = Nothing
        'rowsKutukIl = Nothing
        'rowsKutukIlce = Nothing
        'rowsKutukMahalle = Nothing
        'rowsKutukCiltNo = Nothing
        'rowsKutukSiraNo = Nothing
        'rowdteNufusCuzdanTarihi = Nothing
        'rowsCuzdanVerilenYer = Nothing
        'rowsCuzdanKayitNo = Nothing
        'rowsAnneAdi = Nothing
        'rowsBabaAdi = Nothing
        'rowsAileAdresi = Nothing
        'rowsAileTelefonu = Nothing
        'rowsCuzdanVerNedeni = Nothing
        'VGrid_sinif = Nothing
        'rowSýnýf1 = Nothing
        'rowSýnýf2 = Nothing
        'rowSýnýf3 = Nothing
        'rowSýnýf4 = Nothing
        'rowSýnýf5 = Nothing
        'rowSýnýf6 = Nothing
        'rowSýnýf7 = Nothing
        'rowSýnýf8 = Nothing
        'rowSýnýf9 = Nothing
        'rowSýnýf10 = Nothing
        'rowSýnýf11 = Nothing
        'rowSýnýf12 = Nothing
        'rowSýnýf13 = Nothing
        'rowSýnýf14 = Nothing
        'rowSýnýf15 = Nothing
        'EditorRow1 = Nothing
        'VGrid_genel = Nothing
        'EditorRow2 = Nothing
        'rowsMagaza = Nothing
        'rowlKodu = Nothing
        'rowsAdi = Nothing
        'rowsSoyadi = Nothing
        'rowMusteri = Nothing
        'rownCinsiyet = Nothing
        'row_lAylikGelir = Nothing
        'rowdteKartAcilisTarihi = Nothing
        'rownIskontoPesin = Nothing
        'rownIskontoKredili = Nothing
        'rowsUnvan = Nothing
        'rowsVergiDairesi = Nothing
        'rowsVergiNo = Nothing
        'rowbYazismaEvAdresinemi = Nothing
        'rowsEmail = Nothing
        'rowsIsYeriAdi = Nothing
        'rowsIsAdresi = Nothing
        'rowsIsTelefonu = Nothing
        'rowsEvAdresi = Nothing
        'rowsEvTelefonu = Nothing
        'rowsSigortaNo = Nothing
        'rowbEvlimi = Nothing
        'rowdteEvlilikTarihi = Nothing
        'rowdteDogumTarihi = Nothing
        'rowsDogumYeri = Nothing
        'rowsEhliyetNo = Nothing
        'rowsKanGrubu = Nothing
        'rowdteKayitTarihi = Nothing
        'rowISTIHBARAT = Nothing
        'rowsGSM = Nothing
        'rowsFax = Nothing
        'categoryKimlikBilgileri = Nothing
        'categoryAileBilgileri = Nothing
        'categoryTanýmlar = Nothing
        'categoryEvBilgileri = Nothing
        'categoryÝþBilgileri = Nothing
        'categoryFinansman = Nothing
        'categoryÖzelBilgiler = Nothing
        'categoryFaturaBilgileri = Nothing
        'Gridcontrol2 = Nothing
        'Context_bekleyen = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem13 = Nothing
        'MenuItem14 = Nothing
        'MenuItem15 = Nothing
        'MenuItem16 = Nothing
        'MenuItem17 = Nothing
        'MenuItem18 = Nothing
        'ps = Nothing
        'printlink_bekleyen = Nothing
        'printlink_genel = Nothing
        'printlink_kefil = Nothing
        'printlink_sozlesme = Nothing
        'printlink_sinif = Nothing
        'printlink_kimlik = Nothing
        'printlink_musteri = Nothing
        'MenuItem19 = Nothing
        'MenuItem20 = Nothing
        'MenuItem21 = Nothing
        'MenuItem22 = Nothing
        'Label2 = Nothing
        'txt_musteriNo = Nothing
        'XtraTabPage5 = Nothing
        'MenuItem23 = Nothing
        'SimpleButton3 = Nothing
        'MenuItem24 = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub GridView9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView9.DoubleClick
        takip_duzelt()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        incele()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub GridView11_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView11.DoubleClick
        fis_duzelt()
    End Sub
    Private Sub GridView11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView11.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView11.RowCount > 0 Then
            Dim dr As DataRow = GridView11.GetDataRow(GridView11.FocusedRowHandle)
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
            Dim satir = GridView1.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                Try
                    frm.ShowDialog()
                Catch ex As Exception
                End Try
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub paket_duzelt()
        If GridView12.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView12.GetDataRow(GridView12.FocusedRowHandle)
            Dim frm As New frm_stok_paket
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.belgeind = dr("IND")
            frm.status = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub GridView12_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView12.DoubleClick
        paket_duzelt()
    End Sub
    Private Sub GridView12_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView12.KeyDown
        If e.KeyCode = Keys.Enter Then
            paket_duzelt()
        End If
    End Sub
    Private Sub GridView13_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView13.DoubleClick
        If GridView13.RowCount > 0 Then
            Dim satir = GridView13.FocusedRowHandle
            Dim dr As DataRow = GridView13.GetDataRow(GridView13.FocusedRowHandle)
            Dim frm As New frm_tbResim
            frm.PictureEdit1.EditValue = dr("pResim")
            frm.ShowDialog()
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
End Class