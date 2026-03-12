Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Linq
Imports System.Collections.Generic
Imports System.Net
Imports System.Text
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Diagnostics
Imports System.Threading
Imports System.Data.SqlClient
Imports System.Globalization

'Imports PrinterClassDll
Public Class frm_Perakende_Satis
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    ' === KOLAYSOFT ENTEGRASYON ===
    Public Shared KolaysoftToken As String = Nothing
    Public Shared KolaysoftTokenAlinmaZamani As DateTime = Date.MinValue
    Public Shared KolaysoftCihazListesi As New List(Of String)
    Public Shared KolaysoftFirmaId As String = ""
    Private Shared SonFaturaIcerigi As String = ""
    Private Shared LogDosyaYolu As String = "C:\EFatura\Loglar\KolaysoftLog.txt"
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
    Friend WithEvents Panel_toplam As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelBaslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelEkle As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelHareket As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagazaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSiparisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOdemeKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collReyonFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents ds_toplam As System.Data.DataSet
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
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents DataColumn87 As System.Data.DataColumn
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents DataColumn98 As System.Data.DataColumn
    Friend WithEvents DataColumn99 As System.Data.DataColumn
    Friend WithEvents DataColumn100 As System.Data.DataColumn
    Friend WithEvents DataColumn101 As System.Data.DataColumn
    Friend WithEvents DataColumn102 As System.Data.DataColumn
    Friend WithEvents DataColumn103 As System.Data.DataColumn
    Friend WithEvents DataColumn104 As System.Data.DataColumn
    Friend WithEvents DataColumn105 As System.Data.DataColumn
    Friend WithEvents DataColumn106 As System.Data.DataColumn
    Friend WithEvents DataColumn107 As System.Data.DataColumn
    Friend WithEvents DataColumn108 As System.Data.DataColumn
    Friend WithEvents DataColumn109 As System.Data.DataColumn
    Friend WithEvents ds_adres As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn110 As System.Data.DataColumn
    Friend WithEvents DataColumn111 As System.Data.DataColumn
    Friend WithEvents DataColumn112 As System.Data.DataColumn
    Friend WithEvents DataColumn113 As System.Data.DataColumn
    Friend WithEvents DataColumn114 As System.Data.DataColumn
    Friend WithEvents DataColumn115 As System.Data.DataColumn
    Friend WithEvents DataColumn116 As System.Data.DataColumn
    Friend WithEvents DataColumn117 As System.Data.DataColumn
    Friend WithEvents DataColumn118 As System.Data.DataColumn
    Friend WithEvents DataColumn119 As System.Data.DataColumn
    Friend WithEvents DataColumn120 As System.Data.DataColumn
    Friend WithEvents DataColumn121 As System.Data.DataColumn
    Friend WithEvents DataColumn122 As System.Data.DataColumn
    Friend WithEvents DataColumn123 As System.Data.DataColumn
    Friend WithEvents DataColumn124 As System.Data.DataColumn
    Friend WithEvents DataColumn125 As System.Data.DataColumn
    Friend WithEvents DataColumn126 As System.Data.DataColumn
    Friend WithEvents DataColumn128 As System.Data.DataColumn
    Friend WithEvents DataColumn129 As System.Data.DataColumn
    Friend WithEvents rownAlisVerisID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAdres1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAdres2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsSemt As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsIl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsUlke As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsPostaKodu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiDairesi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsSubeMagaza As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownMusteriID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAdi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsSoyadi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMusteri As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteFaturaTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlFaturaNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAlisverisYapanAdi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAlisverisYapanSoyadi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categoryFişTanımları As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAdres As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryVergilendirme As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAçıklama As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents sec_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rowlMalIskontoTutari As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlPesinat As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlNetTutar As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDipIskonto As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btn_BelgeOnizle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_BelgeDizayn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_BelgeYazdir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FisSil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirEkle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirDuzelt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirSil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VGrid_toplam As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents VGrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ds_fiyattipi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn127 As System.Data.DataColumn
    Friend WithEvents DataColumn130 As System.Data.DataColumn
    Friend WithEvents ds_nGirisCikis As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn131 As System.Data.DataColumn
    Friend WithEvents DataColumn132 As System.Data.DataColumn
    Friend WithEvents sec_sFiyatTipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_nGirisCikis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sOdemeKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn133 As System.Data.DataColumn
    Friend WithEvents btn_HesapKapat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rownGirisCikis As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_baslik_nGirisCikis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sAdres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_MusteriKarti As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_StokKarti As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_StokFiyatlandir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowsFisTipi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_BarkodOkut As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FisYeni As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_MusteriSec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FiyatGor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_tutar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents btn_MiktarHesapla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SaticiBelirle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FiyatTipiBelirle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltToplamlar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents TusPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents e16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_EtiketTuslariGoster As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents e_tamam As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_etiket_ara As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents e_degistir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e20 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e19 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e18 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e17 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_CarilerdenAdresAl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_AltFisYeni As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltOdemeAl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltYazdirFis As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltKlavye As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltYazdirFatura As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltMusteriYeni As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltSatirSil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltFisSil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colnIslemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_AltPuan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltMusteriSec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowlPuan As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents btn_AltYuvarla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AltSatirEkle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_Yekun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Group_Satis As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Group_Kapatma As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl_Pesinat As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnOdemeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOdemeSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sOdemeSekli As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colnOdemeKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOdemeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents collDovizTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMakbuzNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnTaksitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIadeAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKasaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKartNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblTaksit_info As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_vade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taksit_tutari As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_taksit_sayisi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pesinat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Satis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl_Taksit As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnTaksitID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_taksit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sAralik As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_tutar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_sayi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ds_odeme As System.Data.DataSet
    Friend WithEvents DataTable7 As System.Data.DataTable
    Friend WithEvents DataColumn134 As System.Data.DataColumn
    Friend WithEvents DataColumn135 As System.Data.DataColumn
    Friend WithEvents DataColumn136 As System.Data.DataColumn
    Friend WithEvents DataColumn137 As System.Data.DataColumn
    Friend WithEvents DataColumn138 As System.Data.DataColumn
    Friend WithEvents DataColumn139 As System.Data.DataColumn
    Friend WithEvents DataColumn140 As System.Data.DataColumn
    Friend WithEvents DataColumn141 As System.Data.DataColumn
    Friend WithEvents DataColumn142 As System.Data.DataColumn
    Friend WithEvents DataColumn143 As System.Data.DataColumn
    Friend WithEvents DataColumn144 As System.Data.DataColumn
    Friend WithEvents DataColumn145 As System.Data.DataColumn
    Friend WithEvents DataColumn146 As System.Data.DataColumn
    Friend WithEvents DataColumn147 As System.Data.DataColumn
    Friend WithEvents DataColumn148 As System.Data.DataColumn
    Friend WithEvents DataColumn149 As System.Data.DataColumn
    Friend WithEvents DataColumn150 As System.Data.DataColumn
    Friend WithEvents DataColumn151 As System.Data.DataColumn
    Friend WithEvents DataColumn152 As System.Data.DataColumn
    Friend WithEvents DataColumn153 As System.Data.DataColumn
    Friend WithEvents ds_taksit As System.Data.DataSet
    Friend WithEvents DataTable8 As System.Data.DataTable
    Friend WithEvents DataColumn154 As System.Data.DataColumn
    Friend WithEvents DataColumn155 As System.Data.DataColumn
    Friend WithEvents DataColumn156 As System.Data.DataColumn
    Friend WithEvents DataColumn157 As System.Data.DataColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable9 As System.Data.DataTable
    Friend WithEvents DataColumn158 As System.Data.DataColumn
    Friend WithEvents DataColumn159 As System.Data.DataColumn
    Friend WithEvents DataColumn160 As System.Data.DataColumn
    Friend WithEvents kisayol_taksit As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_odeme As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents btn_SatisDon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lbl_lKalan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sListIade As System.Windows.Forms.ListBox
    Friend WithEvents Bar_DisGorunum As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem36 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem47 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem48 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem49 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem50 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem51 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem52 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem53 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem54 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem55 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem56 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem57 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem58 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem59 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem60 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem61 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem8 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents colsBirimCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_OtomatikEnter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_DirekYazdirTermal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem62 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_MusteriNotu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_lDipIskonto As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents rowISTIHBARAT As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowToplam As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents MultiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties10 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents rowToplamMiktar As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents rowMalBedeli As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties11 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties12 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties13 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties14 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties15 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties16 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents btn_SeriNumara As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents collHBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collHBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn161 As System.Data.DataColumn
    Friend WithEvents DataColumn162 As System.Data.DataColumn
    Friend WithEvents collHDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn163 As System.Data.DataColumn
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dteIlkTaksit As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents mnBekleyeniIadeAl As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colnPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrimTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem3 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem6 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem14 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem16 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem10 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip11 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem17 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem11 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem7 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem18 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip12 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem19 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem12 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip13 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem20 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem13 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem8 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem21 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip14 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem22 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem14 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem9 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem23 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Perakende_Satis))
        Dim SuperToolTip15 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem24 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem15 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem10 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem25 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip16 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem26 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem16 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem11 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem27 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip17 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem28 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem17 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem12 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem29 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip18 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem30 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem18 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem13 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem31 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip19 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem32 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem19 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem14 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem33 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.collGCMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_tutar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sFiyatTipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn127 = New System.Data.DataColumn()
        Me.DataColumn130 = New System.Data.DataColumn()
        Me.colnStokIslemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_lDipIskonto = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.Panel_toplam = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.label2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_Yekun = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.sListIade = New System.Windows.Forms.ListBox()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.VGrid_toplam = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_toplam = New System.Data.DataSet()
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
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn133 = New System.Data.DataColumn()
        Me.rowToplam = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties11 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties12 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowlMalIskontoTutari = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDipIskonto = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties13 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties14 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowlPesinat = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlPuan = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties15 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties16 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowlNetTutar = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlMalArtisTutari = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.MultiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.PanelBaslik = New DevExpress.XtraEditors.PanelControl()
        Me.VGrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_adres = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn110 = New System.Data.DataColumn()
        Me.DataColumn111 = New System.Data.DataColumn()
        Me.DataColumn112 = New System.Data.DataColumn()
        Me.DataColumn113 = New System.Data.DataColumn()
        Me.DataColumn114 = New System.Data.DataColumn()
        Me.DataColumn115 = New System.Data.DataColumn()
        Me.DataColumn116 = New System.Data.DataColumn()
        Me.DataColumn117 = New System.Data.DataColumn()
        Me.DataColumn118 = New System.Data.DataColumn()
        Me.DataColumn119 = New System.Data.DataColumn()
        Me.DataColumn120 = New System.Data.DataColumn()
        Me.DataColumn121 = New System.Data.DataColumn()
        Me.DataColumn122 = New System.Data.DataColumn()
        Me.DataColumn123 = New System.Data.DataColumn()
        Me.DataColumn124 = New System.Data.DataColumn()
        Me.DataColumn125 = New System.Data.DataColumn()
        Me.DataColumn126 = New System.Data.DataColumn()
        Me.DataColumn128 = New System.Data.DataColumn()
        Me.DataColumn129 = New System.Data.DataColumn()
        Me.sec_aciklama = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.sec_baslik_nGirisCikis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn131 = New System.Data.DataColumn()
        Me.DataColumn132 = New System.Data.DataColumn()
        Me.sec_sAdres = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.sec_Sinif2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.rowsSubeMagaza = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryFişTanımları = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownAlisVerisID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteFaturaTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsFisTipi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownGirisCikis = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlFaturaNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownMusteriID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAdi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsSoyadi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMusteri = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryAdres = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsAdres1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAdres2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsUlke = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsIl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsSemt = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsPostaKodu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryVergilendirme = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsAlisverisYapanAdi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAlisverisYapanSoyadi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsVergiDairesi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsVergiNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryAçıklama = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsAciklama = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSinif2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsMuhasebeFaturalasma = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowISTIHBARAT = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.PanelEkle = New DevExpress.XtraEditors.PanelControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.mnBekleyeniIadeAl = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        Me.PanelHareket = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagazaKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSiparisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_nGirisCikis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSatici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sOdemeKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.collReyonFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.sec_sDovizCinsi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSonKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteSonUpdateTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStoksKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStoksAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIslemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collHBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collHBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collHDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnPrim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrimTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ds_hareket = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn161 = New System.Data.DataColumn()
        Me.DataColumn162 = New System.Data.DataColumn()
        Me.DataColumn163 = New System.Data.DataColumn()
        Me.ds_baslik = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
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
        Me.DataColumn82 = New System.Data.DataColumn()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.DataColumn85 = New System.Data.DataColumn()
        Me.DataColumn86 = New System.Data.DataColumn()
        Me.DataColumn87 = New System.Data.DataColumn()
        Me.DataColumn88 = New System.Data.DataColumn()
        Me.DataColumn89 = New System.Data.DataColumn()
        Me.DataColumn90 = New System.Data.DataColumn()
        Me.DataColumn91 = New System.Data.DataColumn()
        Me.DataColumn92 = New System.Data.DataColumn()
        Me.DataColumn93 = New System.Data.DataColumn()
        Me.DataColumn94 = New System.Data.DataColumn()
        Me.DataColumn95 = New System.Data.DataColumn()
        Me.DataColumn96 = New System.Data.DataColumn()
        Me.DataColumn97 = New System.Data.DataColumn()
        Me.DataColumn98 = New System.Data.DataColumn()
        Me.DataColumn99 = New System.Data.DataColumn()
        Me.DataColumn100 = New System.Data.DataColumn()
        Me.DataColumn101 = New System.Data.DataColumn()
        Me.DataColumn102 = New System.Data.DataColumn()
        Me.DataColumn103 = New System.Data.DataColumn()
        Me.DataColumn104 = New System.Data.DataColumn()
        Me.DataColumn105 = New System.Data.DataColumn()
        Me.DataColumn106 = New System.Data.DataColumn()
        Me.DataColumn107 = New System.Data.DataColumn()
        Me.DataColumn108 = New System.Data.DataColumn()
        Me.DataColumn109 = New System.Data.DataColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.btn_FisYeni = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MusteriSec = New DevExpress.XtraBars.BarButtonItem()
        Me.muhasebelestir_button = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_BelgeOnizle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_BelgeDizayn = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_BelgeYazdir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FisSil = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.btn_SatirEkle = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirDuzelt = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirSil = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem62 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btn_HesapKapat = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MusteriKarti = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MusteriNotu = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_StokKarti = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_StokFiyatlandir = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_BarkodOkut = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FiyatGor = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltToplamlar = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MiktarHesapla = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SaticiBelirle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FiyatTipiBelirle = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_EtiketTuslariGoster = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_CarilerdenAdresAl = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatisDon = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_OtomatikEnter = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_DirekYazdirTermal = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SeriNumara = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar_DisGorunum = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem36 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem47 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem48 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem49 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem50 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem51 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem52 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem53 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem54 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem55 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem56 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem57 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem58 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem59 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem60 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem61 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btn_AltSatirEkle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltSatirSil = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltFisSil = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltFisYeni = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltOdemeAl = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltYazdirFis = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltYazdirFatura = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltKlavye = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltMusteriSec = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltMusteriYeni = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltPuan = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltYuvarla = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.TusPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.e20 = New DevExpress.XtraEditors.SimpleButton()
        Me.e19 = New DevExpress.XtraEditors.SimpleButton()
        Me.e18 = New DevExpress.XtraEditors.SimpleButton()
        Me.e17 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_etiket_ara = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.e_degistir = New DevExpress.XtraEditors.SimpleButton()
        Me.e_tamam = New DevExpress.XtraEditors.SimpleButton()
        Me.e16 = New DevExpress.XtraEditors.SimpleButton()
        Me.e15 = New DevExpress.XtraEditors.SimpleButton()
        Me.e14 = New DevExpress.XtraEditors.SimpleButton()
        Me.e13 = New DevExpress.XtraEditors.SimpleButton()
        Me.e12 = New DevExpress.XtraEditors.SimpleButton()
        Me.e11 = New DevExpress.XtraEditors.SimpleButton()
        Me.e10 = New DevExpress.XtraEditors.SimpleButton()
        Me.e9 = New DevExpress.XtraEditors.SimpleButton()
        Me.e8 = New DevExpress.XtraEditors.SimpleButton()
        Me.e7 = New DevExpress.XtraEditors.SimpleButton()
        Me.e6 = New DevExpress.XtraEditors.SimpleButton()
        Me.e5 = New DevExpress.XtraEditors.SimpleButton()
        Me.e4 = New DevExpress.XtraEditors.SimpleButton()
        Me.e3 = New DevExpress.XtraEditors.SimpleButton()
        Me.e2 = New DevExpress.XtraEditors.SimpleButton()
        Me.e1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem8 = New DevExpress.XtraBars.BarSubItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ds_fiyattipi = New System.Data.DataSet()
        Me.ds_nGirisCikis = New System.Data.DataSet()
        Me.Group_Kapatma = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl_Taksit = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_taksit = New System.Windows.Forms.ContextMenu()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnTaksitID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisverisID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_taksit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.dteIlkTaksit = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sAralik = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_tutar = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_sayi = New DevExpress.XtraEditors.SpinEdit()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_vade = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_gun = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_taksit_tutari = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_taksit_sayisi = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_pesinat = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Satis = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_lKalan = New DevExpress.XtraEditors.LabelControl()
        Me.lblTaksit_info = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl_Pesinat = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_odeme = New System.Windows.Forms.ContextMenu()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnOdemeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOdemeSekli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sOdemeSekli = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colnOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOdemeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.collDovizTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMakbuzNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOdemeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnTaksitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIadeAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKasaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKartNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Group_Satis = New DevExpress.XtraEditors.GroupControl()
        Me.ds_odeme = New System.Data.DataSet()
        Me.DataTable7 = New System.Data.DataTable()
        Me.DataColumn134 = New System.Data.DataColumn()
        Me.DataColumn135 = New System.Data.DataColumn()
        Me.DataColumn136 = New System.Data.DataColumn()
        Me.DataColumn137 = New System.Data.DataColumn()
        Me.DataColumn138 = New System.Data.DataColumn()
        Me.DataColumn139 = New System.Data.DataColumn()
        Me.DataColumn140 = New System.Data.DataColumn()
        Me.DataColumn141 = New System.Data.DataColumn()
        Me.DataColumn142 = New System.Data.DataColumn()
        Me.DataColumn143 = New System.Data.DataColumn()
        Me.DataColumn144 = New System.Data.DataColumn()
        Me.DataColumn145 = New System.Data.DataColumn()
        Me.DataColumn146 = New System.Data.DataColumn()
        Me.DataColumn147 = New System.Data.DataColumn()
        Me.DataColumn148 = New System.Data.DataColumn()
        Me.DataColumn149 = New System.Data.DataColumn()
        Me.DataColumn150 = New System.Data.DataColumn()
        Me.DataColumn151 = New System.Data.DataColumn()
        Me.DataColumn152 = New System.Data.DataColumn()
        Me.DataColumn153 = New System.Data.DataColumn()
        Me.ds_taksit = New System.Data.DataSet()
        Me.DataTable8 = New System.Data.DataTable()
        Me.DataColumn154 = New System.Data.DataColumn()
        Me.DataColumn155 = New System.Data.DataColumn()
        Me.DataColumn156 = New System.Data.DataColumn()
        Me.DataColumn157 = New System.Data.DataColumn()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable9 = New System.Data.DataTable()
        Me.DataColumn158 = New System.Data.DataColumn()
        Me.DataColumn159 = New System.Data.DataColumn()
        Me.DataColumn160 = New System.Data.DataColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rowToplamMiktar = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowMalBedeli = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_lDipIskonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_toplam.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.VGrid_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelBaslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBaslik.SuspendLayout()
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_adres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_nGirisCikis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sAdres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Sinif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelEkle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEkle.SuspendLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelHareket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHareket.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nGirisCikis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TusPanel.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.txt_etiket_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_fiyattipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_nGirisCikis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_Kapatma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Kapatma.SuspendLayout()
        CType(Me.GroupControl_Taksit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl_Taksit.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_taksit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_sAralik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sayi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl_Pesinat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl_Pesinat.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_Satis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Satis.SuspendLayout()
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_taksit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'collGCMiktar
        '
        Me.collGCMiktar.Caption = "Miktar"
        Me.collGCMiktar.ColumnEdit = Me.sec_tutar
        Me.collGCMiktar.DisplayFormat.FormatString = "#,0.####"
        Me.collGCMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGCMiktar.FieldName = "lCikisMiktar1"
        Me.collGCMiktar.Name = "collGCMiktar"
        Me.collGCMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGCMiktar", "{0:#,0.####}")})
        Me.collGCMiktar.Visible = True
        Me.collGCMiktar.VisibleIndex = 2
        Me.collGCMiktar.Width = 57
        '
        'sec_tutar
        '
        Me.sec_tutar.AutoHeight = False
        Me.sec_tutar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tutar.DisplayFormat.FormatString = "#,0.00"
        Me.sec_tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_tutar.EditFormat.FormatString = "#,0.00##"
        Me.sec_tutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_tutar.Name = "sec_tutar"
        Me.sec_tutar.NullText = "0.00"
        Me.sec_tutar.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsFiyatTipi.AppearanceCell.Options.UseBackColor = True
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.ColumnEdit = Me.sec_sFiyatTipi
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 3
        Me.colsFiyatTipi.Width = 58
        '
        'sec_sFiyatTipi
        '
        Me.sec_sFiyatTipi.AutoHeight = False
        Me.sec_sFiyatTipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi.DataSource = Me.DataTable5
        Me.sec_sFiyatTipi.DisplayMember = "sFiyatTipi"
        Me.sec_sFiyatTipi.Name = "sec_sFiyatTipi"
        Me.sec_sFiyatTipi.NullText = "[FiyatTipi]"
        Me.sec_sFiyatTipi.ValueMember = "sFiyatTipi"
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn127, Me.DataColumn130})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn127
        '
        Me.DataColumn127.ColumnName = "sFiyatTipi"
        '
        'DataColumn130
        '
        Me.DataColumn130.ColumnName = "sAciklama"
        '
        'colnStokIslemID
        '
        Me.colnStokIslemID.Caption = "StokIslemID"
        Me.colnStokIslemID.FieldName = "nStokIslemID"
        Me.colnStokIslemID.Name = "colnStokIslemID"
        Me.colnStokIslemID.OptionsColumn.AllowEdit = False
        Me.colnStokIslemID.OptionsColumn.AllowFocus = False
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.ShowInCustomizationForm = False
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.Caption = "Dip İskonto"
        Me.MultiEditorRowProperties1.FieldName = "nDipIskontoYuzdesi1"
        Me.MultiEditorRowProperties1.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties1.RowEdit = Me.sec_lDipIskonto
        '
        'sec_lDipIskonto
        '
        Me.sec_lDipIskonto.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_lDipIskonto.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_lDipIskonto.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_lDipIskonto.Appearance.Options.UseBackColor = True
        Me.sec_lDipIskonto.Appearance.Options.UseFont = True
        Me.sec_lDipIskonto.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_lDipIskonto.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_lDipIskonto.AppearanceFocused.Options.UseBackColor = True
        Me.sec_lDipIskonto.AutoHeight = False
        Me.sec_lDipIskonto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.sec_lDipIskonto.DisplayFormat.FormatString = "#,0.00"
        Me.sec_lDipIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lDipIskonto.Name = "sec_lDipIskonto"
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.FieldName = "lDipIskontoTutari1"
        Me.MultiEditorRowProperties2.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties2.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties2.RowEdit = Me.sec_lDipIskonto
        '
        'MultiEditorRowProperties3
        '
        Me.MultiEditorRowProperties3.Caption = "Puan"
        Me.MultiEditorRowProperties3.FieldName = "lKazanilanPuan"
        Me.MultiEditorRowProperties3.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties3.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties3.ReadOnly = True
        '
        'MultiEditorRowProperties4
        '
        Me.MultiEditorRowProperties4.FieldName = "lHarcananPuan"
        Me.MultiEditorRowProperties4.Format.FormatString = "#,0.00##"
        Me.MultiEditorRowProperties4.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties4.ReadOnly = True
        '
        'Panel_toplam
        '
        Me.Panel_toplam.Controls.Add(Me.GroupControl4)
        Me.Panel_toplam.Controls.Add(Me.GroupControl3)
        Me.Panel_toplam.Controls.Add(Me.GroupControl2)
        Me.Panel_toplam.Controls.Add(Me.GroupControl1)
        Me.Panel_toplam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_toplam.Location = New System.Drawing.Point(2, 688)
        Me.Panel_toplam.Name = "Panel_toplam"
        Me.Panel_toplam.Size = New System.Drawing.Size(1289, 240)
        Me.Panel_toplam.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Appearance.BackColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Controls.Add(Me.label2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 40)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(557, 198)
        Me.GroupControl4.TabIndex = 22
        '
        'label2
        '
        Me.label2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label2.Location = New System.Drawing.Point(2, 2)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(15, 29)
        Me.label2.TabIndex = 19
        Me.label2.Text = "*"
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Controls.Add(Me.lbl_Yekun)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl3.Location = New System.Drawing.Point(559, 40)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(229, 198)
        Me.GroupControl3.TabIndex = 21
        '
        'lbl_Yekun
        '
        Me.lbl_Yekun.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Yekun.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Yekun.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Yekun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Yekun.Location = New System.Drawing.Point(2, 2)
        Me.lbl_Yekun.Name = "lbl_Yekun"
        Me.lbl_Yekun.Size = New System.Drawing.Size(225, 194)
        Me.lbl_Yekun.TabIndex = 20
        Me.lbl_Yekun.Text = "*"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.sListIade)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(786, 38)
        Me.GroupControl2.TabIndex = 20
        '
        'sListIade
        '
        Me.sListIade.FormattingEnabled = True
        Me.sListIade.ItemHeight = 19
        Me.sListIade.Location = New System.Drawing.Point(331, 3)
        Me.sListIade.Name = "sListIade"
        Me.sListIade.Size = New System.Drawing.Size(104, 4)
        Me.sListIade.TabIndex = 19
        Me.sListIade.Visible = False
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "*"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.VGrid_toplam)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(788, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(499, 236)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Toplamlar"
        '
        'VGrid_toplam
        '
        Me.VGrid_toplam.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_toplam.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_toplam.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_toplam.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_toplam.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_toplam.CustomizationFormBounds = New System.Drawing.Rectangle(510, 307, 208, 252)
        Me.VGrid_toplam.DataMember = Nothing
        Me.VGrid_toplam.DataSource = Me.ds_toplam
        Me.VGrid_toplam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_toplam.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.VGrid_toplam.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_toplam.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_toplam.Name = "VGrid_toplam"
        Me.VGrid_toplam.OptionsBehavior.ResizeHeaderPanel = False
        Me.VGrid_toplam.OptionsBehavior.ResizeRowHeaders = False
        Me.VGrid_toplam.OptionsBehavior.ResizeRowValues = False
        Me.VGrid_toplam.OptionsBehavior.UseTabKey = False
        Me.VGrid_toplam.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_lDipIskonto})
        Me.VGrid_toplam.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowToplam, Me.rowlMalIskontoTutari, Me.rowDipIskonto, Me.rowlPesinat, Me.rowlPuan, Me.rowlNetTutar, Me.rowlMalArtisTutari})
        Me.VGrid_toplam.Size = New System.Drawing.Size(495, 232)
        Me.VGrid_toplam.TabIndex = 0
        '
        'ds_toplam
        '
        Me.ds_toplam.DataSetName = "NewDataSet"
        Me.ds_toplam.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_toplam.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn133})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "lToplamMiktar"
        Me.DataColumn1.DataType = GetType(Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lMalBedeli"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lMalIskontoTutari"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "nDipIskontoYuzdesi"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lDipIskontoTutari"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "nKdvOrani1"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lKdvMatrahi1"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lKdv1"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "nKdvOrani2"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "lKdvMatrahi2"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lKdv2"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "nKdvOrani3"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lKdvMatrahi3"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lKdv3"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "nKdvOrani4"
        Me.DataColumn15.DataType = GetType(System.TimeSpan)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lKdvMatrahi4"
        Me.DataColumn16.DataType = GetType(System.TimeSpan)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lKdv4"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nKdvOrani5"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "lKdvMatrahi5"
        Me.DataColumn56.DataType = GetType(Decimal)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "lKdv5"
        Me.DataColumn57.DataType = GetType(Decimal)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "lPesinat"
        Me.DataColumn58.DataType = GetType(Decimal)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "nVadeFarkiYuzdesi"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "nVadeKdvOrani"
        Me.DataColumn60.DataType = GetType(Decimal)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "lVadeKdvMatrahi"
        Me.DataColumn61.DataType = GetType(Decimal)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "lVadeKdv"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "lVadeFarki"
        Me.DataColumn63.DataType = GetType(Decimal)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "lNetTutar"
        Me.DataColumn64.DataType = GetType(Decimal)
        '
        'DataColumn133
        '
        Me.DataColumn133.ColumnName = "sYaziIle"
        '
        'rowToplam
        '
        Me.rowToplam.Name = "rowToplam"
        Me.rowToplam.OptionsRow.AllowFocus = False
        Me.rowToplam.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties11, Me.MultiEditorRowProperties12})
        '
        'MultiEditorRowProperties11
        '
        Me.MultiEditorRowProperties11.Caption = "Toplam"
        Me.MultiEditorRowProperties11.FieldName = "lToplamMiktar"
        Me.MultiEditorRowProperties11.Format.FormatString = "#,0.####"
        Me.MultiEditorRowProperties11.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'MultiEditorRowProperties12
        '
        Me.MultiEditorRowProperties12.FieldName = "lMalBedeli"
        Me.MultiEditorRowProperties12.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties12.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowlMalIskontoTutari
        '
        Me.rowlMalIskontoTutari.Name = "rowlMalIskontoTutari"
        Me.rowlMalIskontoTutari.OptionsRow.AllowFocus = False
        Me.rowlMalIskontoTutari.Properties.Caption = "Satır İskontosu"
        Me.rowlMalIskontoTutari.Properties.FieldName = "lMalIskontoTutari"
        Me.rowlMalIskontoTutari.Properties.Format.FormatString = "#,0.00"
        Me.rowlMalIskontoTutari.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowDipIskonto
        '
        Me.rowDipIskonto.Name = "rowDipIskonto"
        Me.rowDipIskonto.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties13, Me.MultiEditorRowProperties14})
        '
        'MultiEditorRowProperties13
        '
        Me.MultiEditorRowProperties13.Caption = "Dip İsk."
        Me.MultiEditorRowProperties13.FieldName = "nDipIskontoYuzdesi1"
        Me.MultiEditorRowProperties13.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties13.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties13.RowEdit = Me.sec_lDipIskonto
        '
        'MultiEditorRowProperties14
        '
        Me.MultiEditorRowProperties14.FieldName = "lDipIskontoTutari1"
        Me.MultiEditorRowProperties14.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties14.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties14.RowEdit = Me.sec_lDipIskonto
        '
        'rowlPesinat
        '
        Me.rowlPesinat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.rowlPesinat.Appearance.Options.UseForeColor = True
        Me.rowlPesinat.Name = "rowlPesinat"
        Me.rowlPesinat.OptionsRow.AllowFocus = False
        Me.rowlPesinat.Properties.Caption = "Peşinat"
        Me.rowlPesinat.Properties.FieldName = "lPesinat"
        Me.rowlPesinat.Properties.Format.FormatString = "#,0.00"
        Me.rowlPesinat.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowlPuan
        '
        Me.rowlPuan.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowlPuan.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.rowlPuan.Appearance.Options.UseFont = True
        Me.rowlPuan.Appearance.Options.UseForeColor = True
        Me.rowlPuan.Name = "rowlPuan"
        Me.rowlPuan.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties15, Me.MultiEditorRowProperties16})
        '
        'MultiEditorRowProperties15
        '
        Me.MultiEditorRowProperties15.Caption = "Puan"
        Me.MultiEditorRowProperties15.FieldName = "lKazanilanPuan"
        Me.MultiEditorRowProperties15.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties15.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'MultiEditorRowProperties16
        '
        Me.MultiEditorRowProperties16.FieldName = "lHarcananPuan"
        Me.MultiEditorRowProperties16.Format.FormatString = "#,0.00##"
        Me.MultiEditorRowProperties16.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowlNetTutar
        '
        Me.rowlNetTutar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowlNetTutar.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowlNetTutar.Appearance.Options.UseFont = True
        Me.rowlNetTutar.Appearance.Options.UseForeColor = True
        Me.rowlNetTutar.Height = 40
        Me.rowlNetTutar.Name = "rowlNetTutar"
        Me.rowlNetTutar.OptionsRow.AllowFocus = False
        Me.rowlNetTutar.Properties.Caption = "Net Tutar"
        Me.rowlNetTutar.Properties.FieldName = "lNetTutar"
        Me.rowlNetTutar.Properties.Format.FormatString = "#,0.00"
        Me.rowlNetTutar.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowlMalArtisTutari
        '
        Me.rowlMalArtisTutari.Name = "rowlMalArtisTutari"
        Me.rowlMalArtisTutari.Properties.Caption = "Fiyat Artış"
        Me.rowlMalArtisTutari.Properties.FieldName = "lMalArtisTutari"
        Me.rowlMalArtisTutari.Properties.Format.FormatString = "#,0.00"
        Me.rowlMalArtisTutari.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlMalArtisTutari.Properties.ReadOnly = True
        '
        'MultiEditorRowProperties5
        '
        Me.MultiEditorRowProperties5.Caption = "Toplam"
        Me.MultiEditorRowProperties5.FieldName = "lToplamMiktar"
        Me.MultiEditorRowProperties5.Format.FormatString = "#,0.####"
        Me.MultiEditorRowProperties5.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'MultiEditorRowProperties6
        '
        Me.MultiEditorRowProperties6.FieldName = "lMalBedeli"
        Me.MultiEditorRowProperties6.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties6.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'MultiEditorRowProperties7
        '
        Me.MultiEditorRowProperties7.Caption = "Dip İsk."
        Me.MultiEditorRowProperties7.FieldName = "nDipIskontoYuzdesi1"
        Me.MultiEditorRowProperties7.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties7.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties7.RowEdit = Me.sec_lDipIskonto
        '
        'MultiEditorRowProperties8
        '
        Me.MultiEditorRowProperties8.FieldName = "lDipIskontoTutari1"
        Me.MultiEditorRowProperties8.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties8.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties8.RowEdit = Me.sec_lDipIskonto
        '
        'MultiEditorRowProperties9
        '
        Me.MultiEditorRowProperties9.Caption = "Puan"
        Me.MultiEditorRowProperties9.FieldName = "lKazanilanPuan"
        Me.MultiEditorRowProperties9.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties9.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties9.ReadOnly = True
        '
        'MultiEditorRowProperties10
        '
        Me.MultiEditorRowProperties10.FieldName = "lHarcananPuan"
        Me.MultiEditorRowProperties10.Format.FormatString = "#,0.00##"
        Me.MultiEditorRowProperties10.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties10.ReadOnly = True
        '
        'PanelBaslik
        '
        Me.PanelBaslik.Controls.Add(Me.VGrid_baslik)
        Me.PanelBaslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBaslik.Location = New System.Drawing.Point(2, 21)
        Me.PanelBaslik.Name = "PanelBaslik"
        Me.PanelBaslik.Size = New System.Drawing.Size(1289, 280)
        Me.PanelBaslik.TabIndex = 1
        '
        'VGrid_baslik
        '
        Me.VGrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_baslik.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(530, 235, 208, 252)
        Me.VGrid_baslik.DataMember = Nothing
        Me.VGrid_baslik.DataSource = Me.ds_adres
        Me.VGrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_baslik.Name = "VGrid_baslik"
        Me.VGrid_baslik.OptionsBehavior.ResizeHeaderPanel = False
        Me.VGrid_baslik.OptionsBehavior.ResizeRowHeaders = False
        Me.VGrid_baslik.OptionsBehavior.ResizeRowValues = False
        Me.VGrid_baslik.OptionsBehavior.UseTabKey = False
        Me.VGrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_aciklama, Me.sec_baslik_nGirisCikis, Me.sec_sAdres, Me.sec_Sinif2})
        Me.VGrid_baslik.RowHeaderWidth = 133
        Me.VGrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsSubeMagaza, Me.categoryFişTanımları, Me.categoryAdres, Me.categoryVergilendirme, Me.categoryAçıklama, Me.rowISTIHBARAT})
        Me.VGrid_baslik.Size = New System.Drawing.Size(1285, 276)
        Me.VGrid_baslik.TabIndex = 0
        Me.VGrid_baslik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_adres
        '
        Me.ds_adres.DataSetName = "NewDataSet"
        Me.ds_adres.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_adres.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn110, Me.DataColumn111, Me.DataColumn112, Me.DataColumn113, Me.DataColumn114, Me.DataColumn115, Me.DataColumn116, Me.DataColumn117, Me.DataColumn118, Me.DataColumn119, Me.DataColumn120, Me.DataColumn121, Me.DataColumn122, Me.DataColumn123, Me.DataColumn124, Me.DataColumn125, Me.DataColumn126, Me.DataColumn128, Me.DataColumn129})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn110
        '
        Me.DataColumn110.ColumnName = "nAlisVerisID"
        '
        'DataColumn111
        '
        Me.DataColumn111.ColumnName = "sAciklama"
        '
        'DataColumn112
        '
        Me.DataColumn112.ColumnName = "sAdres1"
        '
        'DataColumn113
        '
        Me.DataColumn113.ColumnName = "sAdres2"
        '
        'DataColumn114
        '
        Me.DataColumn114.ColumnName = "sSemt"
        '
        'DataColumn115
        '
        Me.DataColumn115.ColumnName = "sIl"
        '
        'DataColumn116
        '
        Me.DataColumn116.ColumnName = "sUlke"
        '
        'DataColumn117
        '
        Me.DataColumn117.ColumnName = "sPostaKodu"
        '
        'DataColumn118
        '
        Me.DataColumn118.ColumnName = "sVergiDairesi"
        '
        'DataColumn119
        '
        Me.DataColumn119.ColumnName = "sVergiNo"
        '
        'DataColumn120
        '
        Me.DataColumn120.ColumnName = "sSubeMagaza"
        '
        'DataColumn121
        '
        Me.DataColumn121.ColumnName = "nMusteriID"
        Me.DataColumn121.DataType = GetType(Long)
        '
        'DataColumn122
        '
        Me.DataColumn122.ColumnName = "sAdi"
        '
        'DataColumn123
        '
        Me.DataColumn123.ColumnName = "sSoyadi"
        '
        'DataColumn124
        '
        Me.DataColumn124.ColumnName = "Musteri"
        '
        'DataColumn125
        '
        Me.DataColumn125.ColumnName = "dteFaturaTarihi"
        Me.DataColumn125.DataType = GetType(Date)
        '
        'DataColumn126
        '
        Me.DataColumn126.ColumnName = "lFaturaNo"
        Me.DataColumn126.DataType = GetType(Long)
        '
        'DataColumn128
        '
        Me.DataColumn128.ColumnName = "sAlisverisYapanAdi"
        '
        'DataColumn129
        '
        Me.DataColumn129.ColumnName = "sAlisverisYapanSoyadi"
        '
        'sec_aciklama
        '
        Me.sec_aciklama.Name = "sec_aciklama"
        Me.sec_aciklama.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'sec_baslik_nGirisCikis
        '
        Me.sec_baslik_nGirisCikis.AutoHeight = False
        Me.sec_baslik_nGirisCikis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_baslik_nGirisCikis.DataSource = Me.DataTable6
        Me.sec_baslik_nGirisCikis.DisplayMember = "sAciklama"
        Me.sec_baslik_nGirisCikis.Name = "sec_baslik_nGirisCikis"
        Me.sec_baslik_nGirisCikis.NullText = "[]"
        Me.sec_baslik_nGirisCikis.ValueMember = "nGirisCikis"
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn131, Me.DataColumn132})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn131
        '
        Me.DataColumn131.ColumnName = "nGirisCikis"
        Me.DataColumn131.DataType = GetType(Long)
        '
        'DataColumn132
        '
        Me.DataColumn132.ColumnName = "sAciklama"
        '
        'sec_sAdres
        '
        Me.sec_sAdres.AutoHeight = False
        Me.sec_sAdres.MaxLength = 60
        Me.sec_sAdres.Name = "sec_sAdres"
        '
        'sec_Sinif2
        '
        Me.sec_Sinif2.AutoHeight = False
        Me.sec_Sinif2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Sinif2.DisplayMember = "sAciklama"
        Me.sec_Sinif2.Name = "sec_Sinif2"
        Me.sec_Sinif2.NullText = "[]"
        Me.sec_Sinif2.ValueMember = "sSinifKodu"
        '
        'rowsSubeMagaza
        '
        Me.rowsSubeMagaza.Name = "rowsSubeMagaza"
        Me.rowsSubeMagaza.Properties.Caption = "SubeMagaza"
        Me.rowsSubeMagaza.Properties.FieldName = "sSubeMagaza"
        Me.rowsSubeMagaza.Properties.ReadOnly = True
        Me.rowsSubeMagaza.Visible = False
        '
        'categoryFişTanımları
        '
        Me.categoryFişTanımları.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownAlisVerisID, Me.rowdteFaturaTarihi, Me.rowsFisTipi, Me.rownGirisCikis, Me.rowlFaturaNo, Me.rownMusteriID, Me.rowsAdi, Me.rowsSoyadi, Me.rowMusteri})
        Me.categoryFişTanımları.Name = "categoryFişTanımları"
        Me.categoryFişTanımları.Properties.Caption = "FişTanımları"
        '
        'rownAlisVerisID
        '
        Me.rownAlisVerisID.Name = "rownAlisVerisID"
        Me.rownAlisVerisID.Properties.Caption = "Kayıt No"
        Me.rownAlisVerisID.Properties.FieldName = "nAlisverisID"
        Me.rownAlisVerisID.Properties.ReadOnly = True
        Me.rownAlisVerisID.Visible = False
        '
        'rowdteFaturaTarihi
        '
        Me.rowdteFaturaTarihi.Name = "rowdteFaturaTarihi"
        Me.rowdteFaturaTarihi.Properties.Caption = "FaturaTarihi"
        Me.rowdteFaturaTarihi.Properties.FieldName = "dteFaturaTarihi"
        '
        'rowsFisTipi
        '
        Me.rowsFisTipi.Name = "rowsFisTipi"
        Me.rowsFisTipi.Properties.Caption = "FisTipi"
        Me.rowsFisTipi.Properties.FieldName = "sFisTipi"
        Me.rowsFisTipi.Properties.ReadOnly = True
        '
        'rownGirisCikis
        '
        Me.rownGirisCikis.Name = "rownGirisCikis"
        Me.rownGirisCikis.Properties.Caption = "Belge Tipi"
        Me.rownGirisCikis.Properties.FieldName = "nGirisCikis"
        Me.rownGirisCikis.Properties.RowEdit = Me.sec_baslik_nGirisCikis
        '
        'rowlFaturaNo
        '
        Me.rowlFaturaNo.Name = "rowlFaturaNo"
        Me.rowlFaturaNo.Properties.Caption = "FaturaNo"
        Me.rowlFaturaNo.Properties.FieldName = "lFaturaNo"
        '
        'rownMusteriID
        '
        Me.rownMusteriID.Name = "rownMusteriID"
        Me.rownMusteriID.Properties.Caption = "Müşteri No"
        Me.rownMusteriID.Properties.FieldName = "lKodu"
        Me.rownMusteriID.Properties.ReadOnly = True
        '
        'rowsAdi
        '
        Me.rowsAdi.Height = 16
        Me.rowsAdi.Name = "rowsAdi"
        Me.rowsAdi.Properties.Caption = "Adı"
        Me.rowsAdi.Properties.FieldName = "sAdi"
        Me.rowsAdi.Properties.ReadOnly = True
        '
        'rowsSoyadi
        '
        Me.rowsSoyadi.Name = "rowsSoyadi"
        Me.rowsSoyadi.Properties.Caption = "Soyadi"
        Me.rowsSoyadi.Properties.FieldName = "sSoyadi"
        Me.rowsSoyadi.Properties.ReadOnly = True
        '
        'rowMusteri
        '
        Me.rowMusteri.Name = "rowMusteri"
        Me.rowMusteri.Properties.Caption = "Musteri"
        Me.rowMusteri.Properties.FieldName = "Musteri"
        Me.rowMusteri.Properties.ReadOnly = True
        '
        'categoryAdres
        '
        Me.categoryAdres.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsAdres1, Me.rowsAdres2, Me.rowsUlke, Me.rowsIl, Me.rowsSemt, Me.rowsPostaKodu})
        Me.categoryAdres.Name = "categoryAdres"
        Me.categoryAdres.Properties.Caption = "Adres"
        '
        'rowsAdres1
        '
        Me.rowsAdres1.Name = "rowsAdres1"
        Me.rowsAdres1.Properties.Caption = "Adres1"
        Me.rowsAdres1.Properties.FieldName = "sAdres1"
        Me.rowsAdres1.Properties.RowEdit = Me.sec_sAdres
        '
        'rowsAdres2
        '
        Me.rowsAdres2.Name = "rowsAdres2"
        Me.rowsAdres2.Properties.Caption = "Adres2"
        Me.rowsAdres2.Properties.FieldName = "sAdres2"
        Me.rowsAdres2.Properties.RowEdit = Me.sec_sAdres
        '
        'rowsUlke
        '
        Me.rowsUlke.Name = "rowsUlke"
        Me.rowsUlke.Properties.Caption = "Ulke"
        Me.rowsUlke.Properties.FieldName = "sUlke"
        '
        'rowsIl
        '
        Me.rowsIl.Name = "rowsIl"
        Me.rowsIl.Properties.Caption = "il"
        Me.rowsIl.Properties.FieldName = "sIl"
        '
        'rowsSemt
        '
        Me.rowsSemt.Name = "rowsSemt"
        Me.rowsSemt.Properties.Caption = "Semt"
        Me.rowsSemt.Properties.FieldName = "sSemt"
        '
        'rowsPostaKodu
        '
        Me.rowsPostaKodu.Name = "rowsPostaKodu"
        Me.rowsPostaKodu.Properties.Caption = "PostaKodu"
        Me.rowsPostaKodu.Properties.FieldName = "sPostaKodu"
        '
        'categoryVergilendirme
        '
        Me.categoryVergilendirme.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsAlisverisYapanAdi, Me.rowsAlisverisYapanSoyadi, Me.rowsVergiDairesi, Me.rowsVergiNo})
        Me.categoryVergilendirme.Name = "categoryVergilendirme"
        Me.categoryVergilendirme.Properties.Caption = "Vergilendirme"
        '
        'rowsAlisverisYapanAdi
        '
        Me.rowsAlisverisYapanAdi.Name = "rowsAlisverisYapanAdi"
        Me.rowsAlisverisYapanAdi.Properties.Caption = "Ad"
        Me.rowsAlisverisYapanAdi.Properties.FieldName = "sAlisverisYapanAdi"
        Me.rowsAlisverisYapanAdi.Properties.RowEdit = Me.sec_sAdres
        '
        'rowsAlisverisYapanSoyadi
        '
        Me.rowsAlisverisYapanSoyadi.Name = "rowsAlisverisYapanSoyadi"
        Me.rowsAlisverisYapanSoyadi.Properties.Caption = "Soyad"
        Me.rowsAlisverisYapanSoyadi.Properties.FieldName = "sAlisverisYapanSoyadi"
        Me.rowsAlisverisYapanSoyadi.Properties.RowEdit = Me.sec_sAdres
        '
        'rowsVergiDairesi
        '
        Me.rowsVergiDairesi.Name = "rowsVergiDairesi"
        Me.rowsVergiDairesi.Properties.Caption = "Vergi Dairesi"
        Me.rowsVergiDairesi.Properties.FieldName = "sVergiDairesi"
        Me.rowsVergiDairesi.Properties.RowEdit = Me.sec_sAdres
        '
        'rowsVergiNo
        '
        Me.rowsVergiNo.Name = "rowsVergiNo"
        Me.rowsVergiNo.Properties.Caption = "Vergi No"
        Me.rowsVergiNo.Properties.FieldName = "sVergiNo"
        Me.rowsVergiNo.Properties.RowEdit = Me.sec_sAdres
        '
        'categoryAçıklama
        '
        Me.categoryAçıklama.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsAciklama, Me.rowSinif2, Me.rowsMuhasebeFaturalasma})
        Me.categoryAçıklama.Name = "categoryAçıklama"
        Me.categoryAçıklama.Properties.Caption = "Açıklama"
        '
        'rowsAciklama
        '
        Me.rowsAciklama.Height = 75
        Me.rowsAciklama.Name = "rowsAciklama"
        Me.rowsAciklama.Properties.Caption = "Not"
        Me.rowsAciklama.Properties.FieldName = "sAciklama"
        Me.rowsAciklama.Properties.RowEdit = Me.sec_aciklama
        '
        'rowSinif2
        '
        Me.rowSinif2.Enabled = False
        Me.rowSinif2.Name = "rowSinif2"
        Me.rowSinif2.Properties.Caption = "Sınıf 2"
        Me.rowSinif2.Properties.FieldName = "Sinif2"
        Me.rowSinif2.Properties.RowEdit = Me.sec_Sinif2
        '
        'rowsMuhasebeFaturalasma
        '
        Me.rowsMuhasebeFaturalasma.Name = "rowsMuhasebeFaturalasma"
        Me.rowsMuhasebeFaturalasma.Properties.Caption = "Muhasebe Durumu"
        Me.rowsMuhasebeFaturalasma.Properties.FieldName = "sMuhasebeFaturalasma"
        Me.rowsMuhasebeFaturalasma.Properties.ReadOnly = True
        '
        'rowISTIHBARAT
        '
        Me.rowISTIHBARAT.Height = 60
        Me.rowISTIHBARAT.Name = "rowISTIHBARAT"
        Me.rowISTIHBARAT.Properties.Caption = "Istihbarat"
        Me.rowISTIHBARAT.Properties.FieldName = "ISTIHBARAT"
        Me.rowISTIHBARAT.Properties.ReadOnly = True
        Me.rowISTIHBARAT.Properties.RowEdit = Me.sec_aciklama
        '
        'PanelEkle
        '
        Me.PanelEkle.ContextMenu = Me.ContextMenu1
        Me.PanelEkle.Controls.Add(Me.Label3)
        Me.PanelEkle.Controls.Add(Me.Label4)
        Me.PanelEkle.Controls.Add(Me.sec_kriter)
        Me.PanelEkle.Controls.Add(Me.txt_ara)
        Me.PanelEkle.Controls.Add(Me.lbl_ara)
        Me.PanelEkle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEkle.Location = New System.Drawing.Point(2, 651)
        Me.PanelEkle.Name = "PanelEkle"
        Me.PanelEkle.Size = New System.Drawing.Size(1289, 37)
        Me.PanelEkle.TabIndex = 2
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem33, Me.MenuItem31, Me.mnBekleyeniIadeAl, Me.MenuItem5, Me.MenuItem7, Me.MenuItem30, Me.MenuItem6, Me.MenuItem19, Me.MenuItem9, Me.MenuItem32})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Satır Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Satır Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Satır Sil"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        Me.MenuItem33.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        Me.MenuItem31.Text = "Satılanı İade Al"
        '
        'mnBekleyeniIadeAl
        '
        Me.mnBekleyeniIadeAl.Index = 5
        Me.mnBekleyeniIadeAl.Text = "Bekleyeni İade Al"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 7
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlM
        Me.MenuItem7.Text = "Miktar Hesapla"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 8
        Me.MenuItem30.Text = "Fiyat Artır"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Text = "Ara"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 10
        Me.MenuItem19.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 11
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem9.Text = "Seri Numaralar"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 12
        Me.MenuItem32.Text = "İadenin Bekleyenini Belirle"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Okut="
        '
        'Label4
        '
        Me.Label4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(549, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "*"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.Location = New System.Drawing.Point(429, 3)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(120, 26)
        ToolTipTitleItem1.Text = "Arama Kriteri Belirle"
        ToolTipItem1.LeftIndent = 6
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.sec_kriter.SuperTip = SuperToolTip1
        Me.sec_kriter.TabIndex = 15
        '
        'txt_ara
        '
        Me.txt_ara.Location = New System.Drawing.Point(112, 3)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.Appearance.Options.UseForeColor = True
        Me.txt_ara.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_ara.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ara.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txt_ara.Properties.MaxLength = 30
        Me.txt_ara.Size = New System.Drawing.Size(317, 28)
        ToolTipTitleItem2.Text = "Otomatik Stok Sorgulama"
        ToolTipItem2.LeftIndent = 6
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txt_ara.SuperTip = SuperToolTip2
        Me.txt_ara.TabIndex = 14
        '
        'lbl_ara
        '
        Me.lbl_ara.Location = New System.Drawing.Point(74, 3)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(9, 19)
        Me.lbl_ara.TabIndex = 13
        Me.lbl_ara.Text = "*"
        '
        'PanelHareket
        '
        Me.PanelHareket.Controls.Add(Me.GridControl1)
        Me.PanelHareket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHareket.Location = New System.Drawing.Point(2, 301)
        Me.PanelHareket.Name = "PanelHareket"
        Me.PanelHareket.Size = New System.Drawing.Size(1289, 350)
        Me.PanelHareket.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sFiyatTipi, Me.sec_nGirisCikis, Me.sec_sSatici, Me.sec_sOdemeKodu, Me.sec_tutar, Me.sec_sDovizCinsi})
        Me.GridControl1.Size = New System.Drawing.Size(1285, 346)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.RoyalBlue
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.TopNewRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.TopNewRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnAlisverisID, Me.colsMagazaKodu, Me.colnSiparisID, Me.colnGirisCikis, Me.colnStokID, Me.colsKasiyerRumuzu, Me.colsSaticiRumuzu, Me.colsOdemeKodu, Me.collReyonFisNo, Me.colsFiyatTipi, Me.collGCMiktar, Me.collBrutFiyat, Me.collBrutTutar, Me.colnIskontoYuzdesi, Me.collIskontoTutari, Me.collFiyat, Me.collTutar, Me.colnKdvOrani, Me.colsIadeNedeni, Me.colnPartiID, Me.coldteTeslimEdilecek, Me.coldteTeslimEdilen, Me.colbTeslimEdildi, Me.colbMuhasebeyeIslendimi, Me.colsAciklama, Me.colbEkSoru, Me.colbEkAlan1, Me.colbEkAlan2, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsSonKullaniciAdi, Me.coldteSonUpdateTarihi, Me.colnStokIslemID, Me.coldteOnayTarihi, Me.colnStoksKodu, Me.colnStoksAciklama, Me.colsRenk, Me.colsBeden, Me.colnIslemID, Me.colsBirimCinsi1, Me.collHBrutFiyat, Me.collHBrutTutar, Me.collHDovizMiktari1, Me.colnPrim, Me.collPrimTutari})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(361, 243, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.collGCMiktar
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colsFiyatTipi
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "Pr"
        StyleFormatCondition3.Column = Me.colnStokIslemID
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colnStokIslemID
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "[Yeni Satır]"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "AlışVeriş No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        Me.colnAlisverisID.OptionsColumn.AllowEdit = False
        Me.colnAlisverisID.OptionsColumn.AllowFocus = False
        '
        'colsMagazaKodu
        '
        Me.colsMagazaKodu.Caption = "Mağaza"
        Me.colsMagazaKodu.FieldName = "sDepo"
        Me.colsMagazaKodu.Name = "colsMagazaKodu"
        Me.colsMagazaKodu.OptionsColumn.AllowEdit = False
        Me.colsMagazaKodu.OptionsColumn.AllowFocus = False
        '
        'colnSiparisID
        '
        Me.colnSiparisID.Caption = "Sipariş No"
        Me.colnSiparisID.FieldName = "nSiparisID"
        Me.colnSiparisID.Name = "colnSiparisID"
        Me.colnSiparisID.OptionsColumn.AllowEdit = False
        Me.colnSiparisID.OptionsColumn.AllowFocus = False
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colnGirisCikis.AppearanceCell.Options.UseBackColor = True
        Me.colnGirisCikis.Caption = "SatırTipi"
        Me.colnGirisCikis.ColumnEdit = Me.sec_nGirisCikis
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.OptionsColumn.AllowEdit = False
        Me.colnGirisCikis.OptionsColumn.AllowFocus = False
        Me.colnGirisCikis.Width = 53
        '
        'sec_nGirisCikis
        '
        Me.sec_nGirisCikis.AutoHeight = False
        Me.sec_nGirisCikis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nGirisCikis.DataSource = Me.DataTable6
        Me.sec_nGirisCikis.DisplayMember = "sAciklama"
        Me.sec_nGirisCikis.Name = "sec_nGirisCikis"
        Me.sec_nGirisCikis.NullText = "[SatırTipi]"
        Me.sec_nGirisCikis.ValueMember = "nGirisCikis"
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.OptionsColumn.AllowEdit = False
        Me.colnStokID.OptionsColumn.AllowFocus = False
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsKasiyerRumuzu.AppearanceCell.Options.UseBackColor = True
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.OptionsColumn.AllowEdit = False
        Me.colsKasiyerRumuzu.OptionsColumn.AllowFocus = False
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsSaticiRumuzu.AppearanceCell.Options.UseBackColor = True
        Me.colsSaticiRumuzu.Caption = "Satıcı"
        Me.colsSaticiRumuzu.ColumnEdit = Me.sec_sSatici
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        Me.colsSaticiRumuzu.Width = 62
        '
        'sec_sSatici
        '
        Me.sec_sSatici.AutoHeight = False
        Me.sec_sSatici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.DisplayMember = "sSaticiRumuzu"
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.NullText = "[Satıcı]"
        Me.sec_sSatici.ValueMember = "sSaticiRumuzu"
        '
        'colsOdemeKodu
        '
        Me.colsOdemeKodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsOdemeKodu.AppearanceCell.Options.UseBackColor = True
        Me.colsOdemeKodu.Caption = "Ödeme"
        Me.colsOdemeKodu.ColumnEdit = Me.sec_sOdemeKodu
        Me.colsOdemeKodu.FieldName = "sOdemeKodu"
        Me.colsOdemeKodu.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colsOdemeKodu.Name = "colsOdemeKodu"
        Me.colsOdemeKodu.Visible = True
        Me.colsOdemeKodu.VisibleIndex = 4
        Me.colsOdemeKodu.Width = 55
        '
        'sec_sOdemeKodu
        '
        Me.sec_sOdemeKodu.AutoHeight = False
        Me.sec_sOdemeKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeKodu.DisplayMember = "sOdemeKodu"
        Me.sec_sOdemeKodu.EditValueChangedDelay = 1
        Me.sec_sOdemeKodu.Name = "sec_sOdemeKodu"
        Me.sec_sOdemeKodu.SortColumnIndex = 1
        Me.sec_sOdemeKodu.ValueMember = "sOdemeKodu"
        '
        'collReyonFisNo
        '
        Me.collReyonFisNo.Caption = "Fiş No"
        Me.collReyonFisNo.FieldName = "lReyonFisNo"
        Me.collReyonFisNo.Name = "collReyonFisNo"
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Brüt Fiyat"
        Me.collBrutFiyat.ColumnEdit = Me.sec_tutar
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 5
        Me.collBrutFiyat.Width = 63
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Brüt Tutar"
        Me.collBrutTutar.ColumnEdit = Me.sec_tutar
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.00}")})
        Me.collBrutTutar.Visible = True
        Me.collBrutTutar.VisibleIndex = 6
        Me.collBrutTutar.Width = 65
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colnIskontoYuzdesi.AppearanceCell.Options.UseForeColor = True
        Me.colnIskontoYuzdesi.Caption = "Isk1%"
        Me.colnIskontoYuzdesi.ColumnEdit = Me.sec_tutar
        Me.colnIskontoYuzdesi.DisplayFormat.FormatString = "#,#.##"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Width = 51
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.collIskontoTutari.AppearanceCell.Options.UseForeColor = True
        Me.collIskontoTutari.Caption = "Iskonto"
        Me.collIskontoTutari.ColumnEdit = Me.sec_tutar
        Me.collIskontoTutari.DisplayFormat.FormatString = "#,#.##"
        Me.collIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.Width = 56
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
        Me.collTutar.FieldName = "lCikisTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.OptionsColumn.ReadOnly = True
        Me.collTutar.Width = 97
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
        Me.colsIadeNedeni.Caption = "İade Nedeni"
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
        Me.colnPartiID.OptionsColumn.AllowFocus = False
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
        Me.colbMuhasebeyeIslendimi.Caption = "Muhasebeye İşlendimi?"
        Me.colbMuhasebeyeIslendimi.FieldName = "bMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.Name = "colbMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.OptionsColumn.AllowEdit = False
        Me.colbMuhasebeyeIslendimi.OptionsColumn.AllowFocus = False
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açıklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        '
        'colbEkSoru
        '
        Me.colbEkSoru.Caption = "EkSoru"
        Me.colbEkSoru.FieldName = "bEkSoru"
        Me.colbEkSoru.Name = "colbEkSoru"
        Me.colbEkSoru.OptionsColumn.AllowEdit = False
        '
        'colbEkAlan1
        '
        Me.colbEkAlan1.Caption = "EkAlan1"
        Me.colbEkAlan1.FieldName = "bEkAlan1"
        Me.colbEkAlan1.Name = "colbEkAlan1"
        Me.colbEkAlan1.OptionsColumn.AllowEdit = False
        Me.colbEkAlan1.OptionsColumn.AllowFocus = False
        '
        'colbEkAlan2
        '
        Me.colbEkAlan2.Caption = "EkAlan2"
        Me.colbEkAlan2.FieldName = "bEkAlan2"
        Me.colbEkAlan2.Name = "colbEkAlan2"
        Me.colbEkAlan2.OptionsColumn.AllowEdit = False
        Me.colbEkAlan2.OptionsColumn.AllowFocus = False
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colsDovizCinsi1.AppearanceCell.Options.UseBackColor = True
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi 1"
        Me.colsDovizCinsi1.ColumnEdit = Me.sec_sDovizCinsi
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'sec_sDovizCinsi
        '
        Me.sec_sDovizCinsi.AutoHeight = False
        Me.sec_sDovizCinsi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDovizCinsi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDovizCinsi", "DovizCinsi"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Aciklama")})
        Me.sec_sDovizCinsi.DisplayMember = "sDovizCinsi"
        Me.sec_sDovizCinsi.Name = "sec_sDovizCinsi"
        Me.sec_sDovizCinsi.ValueMember = "sDovizCinsi"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarı 1"
        Me.collDovizMiktari1.ColumnEdit = Me.sec_tutar
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru 1"
        Me.collDovizKuru1.ColumnEdit = Me.sec_tutar
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'colsSonKullaniciAdi
        '
        Me.colsSonKullaniciAdi.Caption = "Son Kullanıcı Adı"
        Me.colsSonKullaniciAdi.FieldName = "sSonKullaniciAdi"
        Me.colsSonKullaniciAdi.Name = "colsSonKullaniciAdi"
        Me.colsSonKullaniciAdi.OptionsColumn.AllowEdit = False
        Me.colsSonKullaniciAdi.OptionsColumn.AllowFocus = False
        '
        'coldteSonUpdateTarihi
        '
        Me.coldteSonUpdateTarihi.Caption = "Son Güncelleme Tarihi"
        Me.coldteSonUpdateTarihi.FieldName = "dteSonUpdateTarihi"
        Me.coldteSonUpdateTarihi.Name = "coldteSonUpdateTarihi"
        Me.coldteSonUpdateTarihi.OptionsColumn.AllowEdit = False
        Me.coldteSonUpdateTarihi.OptionsColumn.AllowFocus = False
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
        Me.colnStoksKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStoksKodu", "{0} Kayıt")})
        Me.colnStoksKodu.Visible = True
        Me.colnStoksKodu.VisibleIndex = 0
        Me.colnStoksKodu.Width = 68
        '
        'colnStoksAciklama
        '
        Me.colnStoksAciklama.Caption = "Stok Adı"
        Me.colnStoksAciklama.FieldName = "sStokAciklama"
        Me.colnStoksAciklama.Name = "colnStoksAciklama"
        Me.colnStoksAciklama.OptionsColumn.AllowEdit = False
        Me.colnStoksAciklama.OptionsColumn.AllowFocus = False
        Me.colnStoksAciklama.Visible = True
        Me.colnStoksAciklama.VisibleIndex = 1
        Me.colnStoksAciklama.Width = 123
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenkAdi"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.OptionsColumn.AllowEdit = False
        Me.colsRenk.OptionsColumn.AllowFocus = False
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "xx"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.OptionsColumn.AllowEdit = False
        Me.colsBeden.OptionsColumn.AllowFocus = False
        '
        'colnIslemID
        '
        Me.colnIslemID.Caption = "Kayıt No"
        Me.colnIslemID.FieldName = "nIslemID"
        Me.colnIslemID.Name = "colnIslemID"
        Me.colnIslemID.OptionsColumn.AllowEdit = False
        Me.colnIslemID.OptionsColumn.AllowFocus = False
        '
        'colsBirimCinsi1
        '
        Me.colsBirimCinsi1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsBirimCinsi1.AppearanceCell.Options.UseBackColor = True
        Me.colsBirimCinsi1.Caption = "Birim"
        Me.colsBirimCinsi1.FieldName = "sBirimCinsi1"
        Me.colsBirimCinsi1.Name = "colsBirimCinsi1"
        Me.colsBirimCinsi1.OptionsColumn.AllowEdit = False
        Me.colsBirimCinsi1.OptionsColumn.ReadOnly = True
        '
        'collHBrutFiyat
        '
        Me.collHBrutFiyat.Caption = "BrutFiyatHariç"
        Me.collHBrutFiyat.ColumnEdit = Me.sec_tutar
        Me.collHBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collHBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collHBrutFiyat.FieldName = "lHBrutFiyat"
        Me.collHBrutFiyat.Name = "collHBrutFiyat"
        '
        'collHBrutTutar
        '
        Me.collHBrutTutar.Caption = "BrutTutarHariç"
        Me.collHBrutTutar.ColumnEdit = Me.sec_tutar
        Me.collHBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collHBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collHBrutTutar.FieldName = "lHBrutTutar"
        Me.collHBrutTutar.Name = "collHBrutTutar"
        '
        'collHDovizMiktari1
        '
        Me.collHDovizMiktari1.Caption = "DovizMiktari1Hariç"
        Me.collHDovizMiktari1.ColumnEdit = Me.sec_tutar
        Me.collHDovizMiktari1.DisplayFormat.FormatString = "#,0.00"
        Me.collHDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collHDovizMiktari1.FieldName = "lHDovizMiktari1"
        Me.collHDovizMiktari1.Name = "collHDovizMiktari1"
        '
        'colnPrim
        '
        Me.colnPrim.Caption = "Prim%"
        Me.colnPrim.DisplayFormat.FormatString = "#,0.00"
        Me.colnPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnPrim.FieldName = "nPrim"
        Me.colnPrim.Name = "colnPrim"
        '
        'collPrimTutari
        '
        Me.collPrimTutari.Caption = "PrimTutari"
        Me.collPrimTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collPrimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrimTutari.FieldName = "lPrimTutari"
        Me.collPrimTutari.Name = "collPrimTutari"
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn65, Me.DataColumn161, Me.DataColumn162, Me.DataColumn163})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nAlisverisID"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sMagazaKodu"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "nSiparisID"
        Me.DataColumn21.DataType = GetType(Long)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nGirisCikis"
        Me.DataColumn22.DataType = GetType(Long)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "nStokID"
        Me.DataColumn23.DataType = GetType(Long)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sOdemeKodu"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "lReyonFisNo"
        Me.DataColumn27.DataType = GetType(Long)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sFiyatTipi"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "lGCMiktar"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "lBrutFiyat"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "lBrutTutar"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "nIskontoYuzdesi"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "lIskontoTutari"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "lFiyat"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "lTutar"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "nKdvOrani"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sIadeNedeni"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "nPartiID"
        Me.DataColumn38.DataType = GetType(Long)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "dteTeslimEdilecek"
        Me.DataColumn39.DataType = GetType(Date)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "dteTeslimEdilen"
        Me.DataColumn40.DataType = GetType(Date)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "bTeslimEdildi"
        Me.DataColumn41.DataType = GetType(Boolean)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn42.DataType = GetType(Boolean)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "sAciklama"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "bEkSoru"
        Me.DataColumn44.DataType = GetType(Boolean)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "bEkAlan1"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "bEkAlan2"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "sDovizCinsi1"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "lDovizMiktari1"
        Me.DataColumn48.DataType = GetType(Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "lDovizKuru1"
        Me.DataColumn49.DataType = GetType(Decimal)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "sSonKullaniciAdi"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "dteSonUpdateTarihi"
        Me.DataColumn51.DataType = GetType(Date)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "nStokIslemID"
        Me.DataColumn52.DataType = GetType(Long)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "dteOnayTarihi"
        Me.DataColumn53.DataType = GetType(Date)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "nStoksKodu"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "nStoksAciklama"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "sDepo"
        '
        'DataColumn161
        '
        Me.DataColumn161.ColumnName = "lHBrutFiyat"
        Me.DataColumn161.DataType = GetType(Decimal)
        '
        'DataColumn162
        '
        Me.DataColumn162.ColumnName = "lHBrutTutar"
        Me.DataColumn162.DataType = GetType(Decimal)
        '
        'DataColumn163
        '
        Me.DataColumn163.ColumnName = "lHDovizMiktari1"
        Me.DataColumn163.DataType = GetType(Decimal)
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn96, Me.DataColumn97, Me.DataColumn98, Me.DataColumn99, Me.DataColumn100, Me.DataColumn101, Me.DataColumn102, Me.DataColumn103, Me.DataColumn104, Me.DataColumn105, Me.DataColumn106, Me.DataColumn107, Me.DataColumn108, Me.DataColumn109})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "nAlisverisID"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "sFisTipi"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "dteFaturaTarihi"
        Me.DataColumn68.DataType = GetType(Date)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "nGirisCikis"
        Me.DataColumn69.DataType = GetType(Long)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "lFaturaNo"
        Me.DataColumn70.DataType = GetType(Long)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "nMusteriID"
        Me.DataColumn71.DataType = GetType(Long)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "sMagaza"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "sAlisverisYapanAdi"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "sAlisverisYapanSoyadi"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "lToplamMiktar"
        Me.DataColumn76.DataType = GetType(Decimal)
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "lMalBedeli"
        Me.DataColumn77.DataType = GetType(Decimal)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "lMalIskontoTutari"
        Me.DataColumn78.DataType = GetType(Decimal)
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "nDipIskontoYuzdesi"
        Me.DataColumn79.DataType = GetType(Decimal)
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "lDipIskontoTutari"
        Me.DataColumn80.DataType = GetType(Decimal)
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "nKdvOrani1"
        Me.DataColumn81.DataType = GetType(Decimal)
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "lKdvMatrahi1"
        Me.DataColumn82.DataType = GetType(Decimal)
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "lKdv1"
        Me.DataColumn83.DataType = GetType(Decimal)
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "nKdvOrani2"
        Me.DataColumn84.DataType = GetType(Decimal)
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "lKdvMatrahi2"
        Me.DataColumn85.DataType = GetType(Decimal)
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "lKdv2"
        Me.DataColumn86.DataType = GetType(Decimal)
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "nKdvOrani3"
        Me.DataColumn87.DataType = GetType(Decimal)
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "lKdvMatrahi3"
        Me.DataColumn88.DataType = GetType(Decimal)
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "lKdv3"
        Me.DataColumn89.DataType = GetType(Decimal)
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "nKdvOrani4"
        Me.DataColumn90.DataType = GetType(Decimal)
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "lKdvMatrahi4"
        Me.DataColumn91.DataType = GetType(Decimal)
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "lKdv4"
        Me.DataColumn92.DataType = GetType(Decimal)
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "nKdvOrani5"
        Me.DataColumn93.DataType = GetType(Decimal)
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "lKdvMatrahi5"
        Me.DataColumn94.DataType = GetType(Decimal)
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "lKdv5"
        Me.DataColumn95.DataType = GetType(Decimal)
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "lPesinat"
        Me.DataColumn96.DataType = GetType(Decimal)
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "nVadeFarkiYuzdesi"
        Me.DataColumn97.DataType = GetType(Decimal)
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "nVadeKdvOrani"
        Me.DataColumn98.DataType = GetType(Decimal)
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "lVadeKdvMatrahi"
        Me.DataColumn99.DataType = GetType(Decimal)
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "lVadeKdv"
        Me.DataColumn100.DataType = GetType(Decimal)
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "lVadeFarki"
        Me.DataColumn101.DataType = GetType(Decimal)
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "sOdemeKodu"
        '
        'DataColumn103
        '
        Me.DataColumn103.ColumnName = "lNetTutar"
        Me.DataColumn103.DataType = GetType(Decimal)
        '
        'DataColumn104
        '
        Me.DataColumn104.ColumnName = "sHareketTipi"
        '
        'DataColumn105
        '
        Me.DataColumn105.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn105.DataType = GetType(Boolean)
        '
        'DataColumn106
        '
        Me.DataColumn106.ColumnName = "nKasaNo"
        '
        'DataColumn107
        '
        Me.DataColumn107.ColumnName = "sKullaniciAdi"
        '
        'DataColumn108
        '
        Me.DataColumn108.ColumnName = "dteKayitTarihi"
        Me.DataColumn108.DataType = GetType(Date)
        '
        'DataColumn109
        '
        Me.DataColumn109.ColumnName = "sYaziIle"
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.CloseButtonAffectAllTabs = False
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.btn_BelgeOnizle, Me.btn_BelgeDizayn, Me.btn_BelgeYazdir, Me.btn_FisSil, Me.BarButtonItem5, Me.btn_SatirEkle, Me.btn_SatirDuzelt, Me.btn_SatirSil, Me.BarButtonItem9, Me.BarSubItem5, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarSubItem6, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.btn_HesapKapat, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.btn_MusteriKarti, Me.btn_StokKarti, Me.btn_StokFiyatlandir, Me.btn_BarkodOkut, Me.btn_FisYeni, Me.btn_MusteriSec, Me.btn_FiyatGor, Me.btn_MiktarHesapla, Me.btn_SaticiBelirle, Me.btn_FiyatTipiBelirle, Me.btn_AltToplamlar, Me.btn_EtiketTuslariGoster, Me.btn_CarilerdenAdresAl, Me.btn_AltSatirSil, Me.btn_AltFisSil, Me.btn_AltFisYeni, Me.btn_AltOdemeAl, Me.btn_AltYazdirFis, Me.btn_AltKlavye, Me.btn_AltYazdirFatura, Me.btn_AltMusteriYeni, Me.btn_AltPuan, Me.btn_AltMusteriSec, Me.btn_AltYuvarla, Me.btn_AltSatirEkle, Me.btn_SatisDon, Me.Bar_DisGorunum, Me.BarButtonItem17, Me.BarButtonItem25, Me.BarButtonItem36, Me.BarSubItem8, Me.BarButtonItem47, Me.BarButtonItem48, Me.BarButtonItem49, Me.BarButtonItem50, Me.BarButtonItem51, Me.BarButtonItem52, Me.BarButtonItem53, Me.BarButtonItem54, Me.BarButtonItem55, Me.BarButtonItem56, Me.BarButtonItem57, Me.BarButtonItem58, Me.BarButtonItem59, Me.BarButtonItem60, Me.BarButtonItem61, Me.BarButtonItem62, Me.btn_MusteriNotu, Me.btn_OtomatikEnter, Me.btn_DirekYazdirTermal, Me.BarButtonItem1, Me.btn_SeriNumara, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarEditItem1, Me.BarButtonItem27, Me.BarButtonItem28, Me.muhasebelestir_button, Me.BarButtonItem29})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 91
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.BarManager1.ShowFullMenus = True
        Me.BarManager1.ShowFullMenusAfterDelay = False
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Bar_DisGorunum, True)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FisYeni), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_MusteriSec, True), New DevExpress.XtraBars.LinkPersistInfo(Me.muhasebelestir_button, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_BelgeOnizle, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_BelgeDizayn), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_BelgeYazdir), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FisSil, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btn_FisYeni
        '
        Me.btn_FisYeni.Caption = "Yeni Fiş"
        Me.btn_FisYeni.Enabled = False
        Me.btn_FisYeni.Id = 31
        Me.btn_FisYeni.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_FisYeni.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_FisYeni.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.btn_FisYeni.Name = "btn_FisYeni"
        '
        'btn_MusteriSec
        '
        Me.btn_MusteriSec.Caption = "Hesap Değiştir"
        Me.btn_MusteriSec.Id = 32
        Me.btn_MusteriSec.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_MusteriSec.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_MusteriSec.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.btn_MusteriSec.Name = "btn_MusteriSec"
        '
        'muhasebelestir_button
        '
        Me.muhasebelestir_button.Caption = "Muhasebeleştir"
        Me.muhasebelestir_button.Id = 89
        Me.muhasebelestir_button.Name = "muhasebelestir_button"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Belgeyi Kopyala"
        Me.BarButtonItem6.Id = 82
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'btn_BelgeOnizle
        '
        Me.btn_BelgeOnizle.Caption = "Belge Önizle"
        Me.btn_BelgeOnizle.Id = 4
        Me.btn_BelgeOnizle.Name = "btn_BelgeOnizle"
        '
        'btn_BelgeDizayn
        '
        Me.btn_BelgeDizayn.Caption = "Belge Dizayn"
        Me.btn_BelgeDizayn.Id = 5
        Me.btn_BelgeDizayn.Name = "btn_BelgeDizayn"
        '
        'btn_BelgeYazdir
        '
        Me.btn_BelgeYazdir.Caption = "Belge Yazdır"
        Me.btn_BelgeYazdir.Id = 6
        Me.btn_BelgeYazdir.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.btn_BelgeYazdir.Name = "btn_BelgeYazdir"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Termal Yazıcıya Yazdır"
        Me.BarButtonItem1.Id = 77
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2))
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btn_FisSil
        '
        Me.btn_FisSil.Caption = "Belgeyi İptal Et"
        Me.btn_FisSil.Id = 7
        Me.btn_FisSil.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.btn_FisSil.Name = "btn_FisSil"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Çıkış"
        Me.BarButtonItem5.Id = 8
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Satır"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirEkle), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirDuzelt), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirSil), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem62)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'btn_SatirEkle
        '
        Me.btn_SatirEkle.Caption = "Satır Ekle"
        Me.btn_SatirEkle.Id = 9
        Me.btn_SatirEkle.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.btn_SatirEkle.Name = "btn_SatirEkle"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Satır Ekle Cas Lp Satış Dosyasından"
        Me.BarButtonItem3.Id = 80
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Satır Ekle Silinen Fişlerden"
        Me.BarButtonItem28.Id = 88
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'btn_SatirDuzelt
        '
        Me.btn_SatirDuzelt.Caption = "Satır Düzenle"
        Me.btn_SatirDuzelt.Id = 10
        Me.btn_SatirDuzelt.Name = "btn_SatirDuzelt"
        '
        'btn_SatirSil
        '
        Me.btn_SatirSil.Caption = "Satır Sil"
        Me.btn_SatirSil.Id = 11
        Me.btn_SatirSil.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_SatirSil.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_SatirSil.Name = "btn_SatirSil"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Hesap Makinası"
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem62
        '
        Me.BarButtonItem62.Caption = "Etiket Yazdır"
        Me.BarButtonItem62.Id = 73
        Me.BarButtonItem62.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.BarButtonItem62.Name = "BarButtonItem62"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Araçlar"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_HesapKapat), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_MusteriKarti), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_MusteriNotu), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_StokKarti), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_StokFiyatlandir), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_BarkodOkut), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FiyatGor), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltToplamlar), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_MiktarHesapla), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SaticiBelirle), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FiyatTipiBelirle), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_EtiketTuslariGoster), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_CarilerdenAdresAl), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatisDon), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_OtomatikEnter), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DirekYazdirTermal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SeriNumara), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'btn_HesapKapat
        '
        Me.btn_HesapKapat.Caption = "Ödeme Al"
        Me.btn_HesapKapat.Id = 22
        Me.btn_HesapKapat.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_HesapKapat.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_HesapKapat.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.btn_HesapKapat.Name = "btn_HesapKapat"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Muhasebe Fişi"
        Me.BarButtonItem29.Id = 90
        Me.BarButtonItem29.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.M))
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'btn_MusteriKarti
        '
        Me.btn_MusteriKarti.Caption = "Müşteri Kartı"
        Me.btn_MusteriKarti.Id = 27
        Me.btn_MusteriKarti.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5))
        Me.btn_MusteriKarti.Name = "btn_MusteriKarti"
        '
        'btn_MusteriNotu
        '
        Me.btn_MusteriNotu.Caption = "Müşteri Notu"
        Me.btn_MusteriNotu.Id = 74
        Me.btn_MusteriNotu.Name = "btn_MusteriNotu"
        '
        'btn_StokKarti
        '
        Me.btn_StokKarti.Caption = "Stok Kartı"
        Me.btn_StokKarti.Id = 28
        Me.btn_StokKarti.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.btn_StokKarti.Name = "btn_StokKarti"
        '
        'btn_StokFiyatlandir
        '
        Me.btn_StokFiyatlandir.Caption = "Stok Fiyatlandır"
        Me.btn_StokFiyatlandir.Id = 29
        Me.btn_StokFiyatlandir.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.btn_StokFiyatlandir.Name = "btn_StokFiyatlandir"
        '
        'btn_BarkodOkut
        '
        Me.btn_BarkodOkut.Caption = "Barkod Okut"
        Me.btn_BarkodOkut.Id = 30
        Me.btn_BarkodOkut.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.btn_BarkodOkut.Name = "btn_BarkodOkut"
        '
        'btn_FiyatGor
        '
        Me.btn_FiyatGor.Caption = "Fiyat Gör"
        Me.btn_FiyatGor.Id = 33
        Me.btn_FiyatGor.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.btn_FiyatGor.Name = "btn_FiyatGor"
        '
        'btn_AltToplamlar
        '
        Me.btn_AltToplamlar.Caption = "Alt Toplamlar"
        Me.btn_AltToplamlar.Id = 37
        Me.btn_AltToplamlar.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.btn_AltToplamlar.Name = "btn_AltToplamlar"
        '
        'btn_MiktarHesapla
        '
        Me.btn_MiktarHesapla.Caption = "Tutara Göre Miktar Hesapla"
        Me.btn_MiktarHesapla.Id = 34
        Me.btn_MiktarHesapla.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M))
        Me.btn_MiktarHesapla.Name = "btn_MiktarHesapla"
        '
        'btn_SaticiBelirle
        '
        Me.btn_SaticiBelirle.Caption = "Satıcı Belirle"
        Me.btn_SaticiBelirle.Id = 35
        Me.btn_SaticiBelirle.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.btn_SaticiBelirle.Name = "btn_SaticiBelirle"
        '
        'btn_FiyatTipiBelirle
        '
        Me.btn_FiyatTipiBelirle.Caption = "FiyatTipi Belirle"
        Me.btn_FiyatTipiBelirle.Id = 36
        Me.btn_FiyatTipiBelirle.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F))
        Me.btn_FiyatTipiBelirle.Name = "btn_FiyatTipiBelirle"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Mağaza Belirle"
        Me.BarButtonItem7.Id = 83
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'btn_EtiketTuslariGoster
        '
        Me.btn_EtiketTuslariGoster.Caption = "Etiket Tusları Göster"
        Me.btn_EtiketTuslariGoster.Id = 38
        Me.btn_EtiketTuslariGoster.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
        Me.btn_EtiketTuslariGoster.Name = "btn_EtiketTuslariGoster"
        '
        'btn_CarilerdenAdresAl
        '
        Me.btn_CarilerdenAdresAl.Caption = "Cariden Adres Al"
        Me.btn_CarilerdenAdresAl.Id = 39
        Me.btn_CarilerdenAdresAl.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
        Me.btn_CarilerdenAdresAl.Name = "btn_CarilerdenAdresAl"
        '
        'btn_SatisDon
        '
        Me.btn_SatisDon.Caption = "Satışa Dön"
        Me.btn_SatisDon.Id = 52
        Me.btn_SatisDon.Name = "btn_SatisDon"
        '
        'btn_OtomatikEnter
        '
        Me.btn_OtomatikEnter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_OtomatikEnter.Caption = "Otomatik Enter Bas"
        Me.btn_OtomatikEnter.Id = 75
        Me.btn_OtomatikEnter.Name = "btn_OtomatikEnter"
        '
        'btn_DirekYazdirTermal
        '
        Me.btn_DirekYazdirTermal.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btn_DirekYazdirTermal.Caption = "Direkt Termal Yazdır"
        Me.btn_DirekYazdirTermal.Id = 76
        Me.btn_DirekYazdirTermal.Name = "btn_DirekYazdirTermal"
        '
        'btn_SeriNumara
        '
        Me.btn_SeriNumara.Caption = "Seri Numaralar"
        Me.btn_SeriNumara.Id = 78
        Me.btn_SeriNumara.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.btn_SeriNumara.Name = "btn_SeriNumara"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Fatura Bilgileri"
        Me.BarButtonItem4.Id = 81
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Görünüm"
        Me.BarSubItem6.Id = 16
        Me.BarSubItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18, True)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Başlık"
        Me.BarButtonItem12.Id = 17
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Hareketler"
        Me.BarButtonItem13.Id = 18
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Toplam"
        Me.BarButtonItem14.Id = 19
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Görünümü Kaydet"
        Me.BarButtonItem18.Id = 23
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Analiz"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21, True)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Envanter"
        Me.BarButtonItem9.Id = 12
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Stok Adı"
        Me.BarButtonItem15.Id = 20
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Stok Hareketleri"
        Me.BarButtonItem16.Id = 21
        Me.BarButtonItem16.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Teslimatlar"
        Me.BarButtonItem2.Id = 79
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F7))
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Stok Kartı"
        Me.BarButtonItem20.Id = 25
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Satışlar"
        Me.BarButtonItem21.Id = 26
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Ekran"
        Me.BarSubItem5.Id = 13
        Me.BarSubItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem10.Caption = "Tam Ekran"
        Me.BarButtonItem10.Id = 14
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'Bar_DisGorunum
        '
        Me.Bar_DisGorunum.Caption = "Dış Görünüm"
        Me.Bar_DisGorunum.Enabled = False
        Me.Bar_DisGorunum.Id = 53
        Me.Bar_DisGorunum.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Bar_DisGorunum.ItemAppearance.Normal.Options.UseFont = True
        Me.Bar_DisGorunum.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem47), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem48), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem49), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem50), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem51), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem52), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem53), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem54), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem55), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem56), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem57), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem58), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem59), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem60), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem61)})
        Me.Bar_DisGorunum.Name = "Bar_DisGorunum"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Flat"
        Me.BarButtonItem17.Id = 54
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Ultra Flat"
        Me.BarButtonItem25.Id = 55
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem36
        '
        Me.BarButtonItem36.Caption = "Style 3D"
        Me.BarButtonItem36.Id = 56
        Me.BarButtonItem36.Name = "BarButtonItem36"
        '
        'BarButtonItem47
        '
        Me.BarButtonItem47.Caption = "Office 2003"
        Me.BarButtonItem47.Id = 58
        Me.BarButtonItem47.Name = "BarButtonItem47"
        '
        'BarButtonItem48
        '
        Me.BarButtonItem48.Caption = "Caramel"
        Me.BarButtonItem48.Id = 59
        Me.BarButtonItem48.Name = "BarButtonItem48"
        '
        'BarButtonItem49
        '
        Me.BarButtonItem49.Caption = "Money Twins"
        Me.BarButtonItem49.Id = 60
        Me.BarButtonItem49.Name = "BarButtonItem49"
        '
        'BarButtonItem50
        '
        Me.BarButtonItem50.Caption = "Lilian"
        Me.BarButtonItem50.Id = 61
        Me.BarButtonItem50.Name = "BarButtonItem50"
        '
        'BarButtonItem51
        '
        Me.BarButtonItem51.Caption = "The Asphalt World"
        Me.BarButtonItem51.Id = 62
        Me.BarButtonItem51.Name = "BarButtonItem51"
        '
        'BarButtonItem52
        '
        Me.BarButtonItem52.Caption = "iMaginary"
        Me.BarButtonItem52.Id = 63
        Me.BarButtonItem52.Name = "BarButtonItem52"
        '
        'BarButtonItem53
        '
        Me.BarButtonItem53.Caption = "Coffee"
        Me.BarButtonItem53.Id = 64
        Me.BarButtonItem53.Name = "BarButtonItem53"
        '
        'BarButtonItem54
        '
        Me.BarButtonItem54.Caption = "Liquid Sky"
        Me.BarButtonItem54.Id = 65
        Me.BarButtonItem54.Name = "BarButtonItem54"
        '
        'BarButtonItem55
        '
        Me.BarButtonItem55.Caption = "London Liquid Sky"
        Me.BarButtonItem55.Id = 66
        Me.BarButtonItem55.Name = "BarButtonItem55"
        '
        'BarButtonItem56
        '
        Me.BarButtonItem56.Caption = "Glass Oceans"
        Me.BarButtonItem56.Id = 67
        Me.BarButtonItem56.Name = "BarButtonItem56"
        '
        'BarButtonItem57
        '
        Me.BarButtonItem57.Caption = "Stardust"
        Me.BarButtonItem57.Id = 68
        Me.BarButtonItem57.Name = "BarButtonItem57"
        '
        'BarButtonItem58
        '
        Me.BarButtonItem58.Caption = "Black"
        Me.BarButtonItem58.Id = 69
        Me.BarButtonItem58.Name = "BarButtonItem58"
        '
        'BarButtonItem59
        '
        Me.BarButtonItem59.Caption = "Blue"
        Me.BarButtonItem59.Id = 70
        Me.BarButtonItem59.Name = "BarButtonItem59"
        '
        'BarButtonItem60
        '
        Me.BarButtonItem60.Caption = "Office 2007 Black"
        Me.BarButtonItem60.Id = 71
        Me.BarButtonItem60.Name = "BarButtonItem60"
        '
        'BarButtonItem61
        '
        Me.BarButtonItem61.Caption = "Office 2007 Blue"
        Me.BarButtonItem61.Id = 72
        Me.BarButtonItem61.Name = "BarButtonItem61"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltSatirEkle, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltSatirSil, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltFisSil, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltFisYeni, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltOdemeAl, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltYazdirFis, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltYazdirFatura, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltKlavye, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltMusteriSec, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltMusteriYeni, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltPuan, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltYuvarla, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'btn_AltSatirEkle
        '
        Me.btn_AltSatirEkle.Caption = "SatirEkle"
        Me.btn_AltSatirEkle.Id = 51
        Me.btn_AltSatirEkle.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltSatirEkle.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltSatirEkle.Name = "btn_AltSatirEkle"
        ToolTipTitleItem3.Text = "Yeni Stok Satiri Ekle"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Stoklardan Secerek Satis Yapmak icin Kullanılır." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem4.LeftIndent = 6
        ToolTipTitleItem4.Text = "Insert"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip3.Items.Add(ToolTipTitleItem4)
        Me.btn_AltSatirEkle.SuperTip = SuperToolTip3
        '
        'btn_AltSatirSil
        '
        Me.btn_AltSatirSil.Caption = "Satır Sil"
        Me.btn_AltSatirSil.Hint = "Satir Sil,Ctrl+Del"
        Me.btn_AltSatirSil.Id = 16
        Me.btn_AltSatirSil.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltSatirSil.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltSatirSil.Name = "btn_AltSatirSil"
        ToolTipTitleItem5.Text = "Satırı Sil"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Satistaki secili satir kaydini silmek icin kullanilir... " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem6.LeftIndent = 6
        ToolTipTitleItem6.Text = "Ctrl+Delete"
        SuperToolTip4.Items.Add(ToolTipTitleItem5)
        SuperToolTip4.Items.Add(ToolTipItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip4.Items.Add(ToolTipTitleItem6)
        Me.btn_AltSatirSil.SuperTip = SuperToolTip4
        '
        'btn_AltFisSil
        '
        Me.btn_AltFisSil.Caption = "Fis Sil"
        Me.btn_AltFisSil.Id = 17
        Me.btn_AltFisSil.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltFisSil.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltFisSil.Name = "btn_AltFisSil"
        ToolTipTitleItem7.Text = "Fis Sil"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Satis Fisini Silmek icin kullanilir. Odemeler,Taksitler,Kazanilan Puan ve Harcana" &
    "n Puanlar Belge ile birlikte silinir."
        ToolTipTitleItem8.LeftIndent = 6
        ToolTipTitleItem8.Text = "Ctrl+Y"
        SuperToolTip5.Items.Add(ToolTipTitleItem7)
        SuperToolTip5.Items.Add(ToolTipItem5)
        SuperToolTip5.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip5.Items.Add(ToolTipTitleItem8)
        Me.btn_AltFisSil.SuperTip = SuperToolTip5
        '
        'btn_AltFisYeni
        '
        Me.btn_AltFisYeni.Caption = "Yeni Fis"
        Me.btn_AltFisYeni.Id = 40
        Me.btn_AltFisYeni.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltFisYeni.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltFisYeni.Name = "btn_AltFisYeni"
        ToolTipTitleItem9.Text = "Yeni Fis"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Belgeyi Kaydedip Yeni Pesin Satis Fisi Açmak icin kullanilir. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem10.LeftIndent = 6
        ToolTipTitleItem10.Text = "F3"
        SuperToolTip6.Items.Add(ToolTipTitleItem9)
        SuperToolTip6.Items.Add(ToolTipItem6)
        SuperToolTip6.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip6.Items.Add(ToolTipTitleItem10)
        Me.btn_AltFisYeni.SuperTip = SuperToolTip6
        '
        'btn_AltOdemeAl
        '
        Me.btn_AltOdemeAl.Caption = "Hesap Kapat"
        Me.btn_AltOdemeAl.Id = 41
        Me.btn_AltOdemeAl.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltOdemeAl.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltOdemeAl.Name = "btn_AltOdemeAl"
        ToolTipTitleItem11.Text = "Ödeme Al"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Yapilan Satis Islemi Karsiliginda Alinan Pesinatlar veya Taksitlendirmeler bu böl" &
    "ümden Yapılır." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem12.LeftIndent = 6
        ToolTipTitleItem12.Text = "F9"
        SuperToolTip7.Items.Add(ToolTipTitleItem11)
        SuperToolTip7.Items.Add(ToolTipItem7)
        SuperToolTip7.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip7.Items.Add(ToolTipTitleItem12)
        Me.btn_AltOdemeAl.SuperTip = SuperToolTip7
        '
        'btn_AltYazdirFis
        '
        Me.btn_AltYazdirFis.Caption = "Yazdır"
        Me.btn_AltYazdirFis.Id = 42
        Me.btn_AltYazdirFis.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltYazdirFis.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltYazdirFis.Name = "btn_AltYazdirFis"
        ToolTipTitleItem13.Text = "Fis Yazdir"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Satis isleminin Fis Türünden Ciktisini Almak icin kullanilir." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem14.LeftIndent = 6
        ToolTipTitleItem14.Text = "F2"
        SuperToolTip8.Items.Add(ToolTipTitleItem13)
        SuperToolTip8.Items.Add(ToolTipItem8)
        SuperToolTip8.Items.Add(ToolTipSeparatorItem6)
        SuperToolTip8.Items.Add(ToolTipTitleItem14)
        Me.btn_AltYazdirFis.SuperTip = SuperToolTip8
        '
        'btn_AltYazdirFatura
        '
        Me.btn_AltYazdirFatura.Caption = "Fatura Yazdır"
        Me.btn_AltYazdirFatura.Id = 44
        Me.btn_AltYazdirFatura.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltYazdirFatura.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltYazdirFatura.Name = "btn_AltYazdirFatura"
        ToolTipTitleItem15.Text = "Fatura Yazdır"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Satis isleminin Fatura Türünden Ciktisini Almak icin kullanilir."
        SuperToolTip9.Items.Add(ToolTipTitleItem15)
        SuperToolTip9.Items.Add(ToolTipItem9)
        Me.btn_AltYazdirFatura.SuperTip = SuperToolTip9
        '
        'btn_AltKlavye
        '
        Me.btn_AltKlavye.Caption = "Sanal Klavye"
        Me.btn_AltKlavye.Id = 43
        Me.btn_AltKlavye.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltKlavye.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltKlavye.Name = "btn_AltKlavye"
        ToolTipTitleItem16.Text = "Sanal Klavye"
        ToolTipItem10.LeftIndent = 6
        ToolTipItem10.Text = "Dokunmatik Pc/Monitörler icin Sanal Ekran Klavyesini calistirir."
        SuperToolTip10.Items.Add(ToolTipTitleItem16)
        SuperToolTip10.Items.Add(ToolTipItem10)
        Me.btn_AltKlavye.SuperTip = SuperToolTip10
        '
        'btn_AltMusteriSec
        '
        Me.btn_AltMusteriSec.Caption = "Veresiye At"
        Me.btn_AltMusteriSec.Id = 49
        Me.btn_AltMusteriSec.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltMusteriSec.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltMusteriSec.Name = "btn_AltMusteriSec"
        ToolTipTitleItem17.Text = "Musteri Sec"
        ToolTipItem11.LeftIndent = 6
        ToolTipItem11.Text = "Satis Fisini Musteri Hesabina Aktarmak icin kullanilir. Egerki Pesin Satis ise Ac" &
    "ik hesaba cevrilebilir." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem18.LeftIndent = 6
        ToolTipTitleItem18.Text = "Ctrl+F5"
        SuperToolTip11.Items.Add(ToolTipTitleItem17)
        SuperToolTip11.Items.Add(ToolTipItem11)
        SuperToolTip11.Items.Add(ToolTipSeparatorItem7)
        SuperToolTip11.Items.Add(ToolTipTitleItem18)
        Me.btn_AltMusteriSec.SuperTip = SuperToolTip11
        '
        'btn_AltMusteriYeni
        '
        Me.btn_AltMusteriYeni.Caption = "Yeni Musteri Kaydet"
        Me.btn_AltMusteriYeni.Hint = "Yeni Musteri Kaydetmek"
        Me.btn_AltMusteriYeni.Id = 45
        Me.btn_AltMusteriYeni.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltMusteriYeni.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltMusteriYeni.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Insert))
        Me.btn_AltMusteriYeni.Name = "btn_AltMusteriYeni"
        ToolTipTitleItem19.Text = "Yeni Musteri"
        ToolTipItem12.LeftIndent = 6
        ToolTipItem12.Text = "Yeni Musteri Kaydi Acilir, Istenirse Satis islemi acilan yeni hesaba Aktarilabili" &
    "r."
        SuperToolTip12.Items.Add(ToolTipTitleItem19)
        SuperToolTip12.Items.Add(ToolTipItem12)
        Me.btn_AltMusteriYeni.SuperTip = SuperToolTip12
        '
        'btn_AltPuan
        '
        Me.btn_AltPuan.Caption = "Puan"
        Me.btn_AltPuan.Hint = "Satisa Puan Vermek veya Satistan Puan Dusmek icin..."
        Me.btn_AltPuan.Id = 48
        Me.btn_AltPuan.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltPuan.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltPuan.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P))
        Me.btn_AltPuan.Name = "btn_AltPuan"
        ToolTipTitleItem20.Text = "Puan"
        ToolTipItem13.LeftIndent = 6
        ToolTipItem13.Text = "Satis Tutarindan Oransal veya Tutarsal Bazli Musteriye Puan veya Hediye Ceki veri" &
    "lebilir. Istenirse Musteri Puan/Hediye Ceki Kullanarak Satis kapatılabilir..."
        ToolTipTitleItem21.LeftIndent = 6
        ToolTipTitleItem21.Text = "Alt+P"
        SuperToolTip13.Items.Add(ToolTipTitleItem20)
        SuperToolTip13.Items.Add(ToolTipItem13)
        SuperToolTip13.Items.Add(ToolTipSeparatorItem8)
        SuperToolTip13.Items.Add(ToolTipTitleItem21)
        Me.btn_AltPuan.SuperTip = SuperToolTip13
        '
        'btn_AltYuvarla
        '
        Me.btn_AltYuvarla.Caption = "Yuvarla"
        Me.btn_AltYuvarla.Hint = "Satis Tutarinda Yuvarlama Yapmak/Otomatik Alt Iskonto Uygulamak icin"
        Me.btn_AltYuvarla.Id = 50
        Me.btn_AltYuvarla.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltYuvarla.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltYuvarla.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y))
        Me.btn_AltYuvarla.Name = "btn_AltYuvarla"
        ToolTipTitleItem22.Text = "Tutar Yuvarla"
        ToolTipItem14.LeftIndent = 6
        ToolTipItem14.Text = "Satis Tutarinda Yuvarlama Yapmak veya Otomatik Iskonto Uygulamak icin kullanilir." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gelen Ekranda Net Satis Rakamı girildiğinde program otomatik olarak Net Satis " &
    "Tutari ni ayarlayacaktır."
        ToolTipTitleItem23.LeftIndent = 6
        ToolTipTitleItem23.Text = "Alt+Y"
        SuperToolTip14.Items.Add(ToolTipTitleItem22)
        SuperToolTip14.Items.Add(ToolTipItem14)
        SuperToolTip14.Items.Add(ToolTipSeparatorItem9)
        SuperToolTip14.Items.Add(ToolTipTitleItem23)
        Me.btn_AltYuvarla.SuperTip = SuperToolTip14
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Ödeme Al"
        Me.BarButtonItem27.Id = 87
        Me.BarButtonItem27.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem27.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1765, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 958)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1765, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 930)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1765, 28)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 930)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.TusPanel})
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'TusPanel
        '
        Me.TusPanel.Controls.Add(Me.DockPanel1_Container)
        Me.TusPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.TusPanel.FloatLocation = New System.Drawing.Point(472, 191)
        Me.TusPanel.FloatSize = New System.Drawing.Size(342, 350)
        Me.TusPanel.ID = New System.Guid("14526dd7-1e35-48c4-a1df-3285c6d41dc8")
        Me.TusPanel.Location = New System.Drawing.Point(-32768, -32768)
        Me.TusPanel.Name = "TusPanel"
        Me.TusPanel.OriginalSize = New System.Drawing.Size(0, 0)
        Me.TusPanel.SavedIndex = 0
        Me.TusPanel.Size = New System.Drawing.Size(342, 350)
        Me.TusPanel.Text = "Etiket Tusu"
        Me.TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.e20)
        Me.DockPanel1_Container.Controls.Add(Me.e19)
        Me.DockPanel1_Container.Controls.Add(Me.e18)
        Me.DockPanel1_Container.Controls.Add(Me.e17)
        Me.DockPanel1_Container.Controls.Add(Me.txt_etiket_ara)
        Me.DockPanel1_Container.Controls.Add(Me.e_degistir)
        Me.DockPanel1_Container.Controls.Add(Me.e_tamam)
        Me.DockPanel1_Container.Controls.Add(Me.e16)
        Me.DockPanel1_Container.Controls.Add(Me.e15)
        Me.DockPanel1_Container.Controls.Add(Me.e14)
        Me.DockPanel1_Container.Controls.Add(Me.e13)
        Me.DockPanel1_Container.Controls.Add(Me.e12)
        Me.DockPanel1_Container.Controls.Add(Me.e11)
        Me.DockPanel1_Container.Controls.Add(Me.e10)
        Me.DockPanel1_Container.Controls.Add(Me.e9)
        Me.DockPanel1_Container.Controls.Add(Me.e8)
        Me.DockPanel1_Container.Controls.Add(Me.e7)
        Me.DockPanel1_Container.Controls.Add(Me.e6)
        Me.DockPanel1_Container.Controls.Add(Me.e5)
        Me.DockPanel1_Container.Controls.Add(Me.e4)
        Me.DockPanel1_Container.Controls.Add(Me.e3)
        Me.DockPanel1_Container.Controls.Add(Me.e2)
        Me.DockPanel1_Container.Controls.Add(Me.e1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(2, 24)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(338, 324)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'e20
        '
        Me.e20.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e20.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e20.Appearance.Options.UseFont = True
        Me.e20.Appearance.Options.UseForeColor = True
        Me.e20.Appearance.Options.UseTextOptions = True
        Me.e20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e20.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e20.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e20.Location = New System.Drawing.Point(254, 241)
        Me.e20.Name = "e20"
        Me.e20.Size = New System.Drawing.Size(74, 52)
        Me.e20.TabIndex = 19
        Me.e20.Text = "20"
        '
        'e19
        '
        Me.e19.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e19.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e19.Appearance.Options.UseFont = True
        Me.e19.Appearance.Options.UseForeColor = True
        Me.e19.Appearance.Options.UseTextOptions = True
        Me.e19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e19.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e19.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e19.Location = New System.Drawing.Point(174, 241)
        Me.e19.Name = "e19"
        Me.e19.Size = New System.Drawing.Size(74, 52)
        Me.e19.TabIndex = 18
        Me.e19.Text = "19"
        '
        'e18
        '
        Me.e18.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e18.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e18.Appearance.Options.UseFont = True
        Me.e18.Appearance.Options.UseForeColor = True
        Me.e18.Appearance.Options.UseTextOptions = True
        Me.e18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e18.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e18.Location = New System.Drawing.Point(94, 241)
        Me.e18.Name = "e18"
        Me.e18.Size = New System.Drawing.Size(74, 52)
        Me.e18.TabIndex = 17
        Me.e18.Text = "18"
        '
        'e17
        '
        Me.e17.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e17.Appearance.Options.UseFont = True
        Me.e17.Appearance.Options.UseForeColor = True
        Me.e17.Appearance.Options.UseTextOptions = True
        Me.e17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e17.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e17.Location = New System.Drawing.Point(14, 241)
        Me.e17.Name = "e17"
        Me.e17.Size = New System.Drawing.Size(74, 52)
        Me.e17.TabIndex = 16
        Me.e17.Text = "17"
        '
        'txt_etiket_ara
        '
        Me.txt_etiket_ara.EditValue = "1"
        Me.txt_etiket_ara.Location = New System.Drawing.Point(14, 301)
        Me.txt_etiket_ara.Name = "txt_etiket_ara"
        Me.txt_etiket_ara.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_etiket_ara.Properties.Appearance.Options.UseBackColor = True
        Me.txt_etiket_ara.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_etiket_ara.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.txt_etiket_ara.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_etiket_ara.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_etiket_ara.Size = New System.Drawing.Size(154, 26)
        Me.txt_etiket_ara.TabIndex = 20
        '
        'e_degistir
        '
        Me.e_degistir.Location = New System.Drawing.Point(254, 299)
        Me.e_degistir.Name = "e_degistir"
        Me.e_degistir.Size = New System.Drawing.Size(74, 22)
        Me.e_degistir.TabIndex = 22
        Me.e_degistir.Text = "&Degistir"
        '
        'e_tamam
        '
        Me.e_tamam.Location = New System.Drawing.Point(174, 299)
        Me.e_tamam.Name = "e_tamam"
        Me.e_tamam.Size = New System.Drawing.Size(74, 22)
        Me.e_tamam.TabIndex = 21
        Me.e_tamam.Text = "&Tamam"
        '
        'e16
        '
        Me.e16.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e16.Appearance.Options.UseFont = True
        Me.e16.Appearance.Options.UseForeColor = True
        Me.e16.Appearance.Options.UseTextOptions = True
        Me.e16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e16.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e16.Location = New System.Drawing.Point(254, 183)
        Me.e16.Name = "e16"
        Me.e16.Size = New System.Drawing.Size(74, 52)
        Me.e16.TabIndex = 15
        Me.e16.Text = "16"
        '
        'e15
        '
        Me.e15.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e15.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e15.Appearance.Options.UseFont = True
        Me.e15.Appearance.Options.UseForeColor = True
        Me.e15.Appearance.Options.UseTextOptions = True
        Me.e15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e15.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e15.Location = New System.Drawing.Point(174, 183)
        Me.e15.Name = "e15"
        Me.e15.Size = New System.Drawing.Size(74, 52)
        Me.e15.TabIndex = 14
        Me.e15.Text = "15"
        '
        'e14
        '
        Me.e14.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e14.Appearance.Options.UseFont = True
        Me.e14.Appearance.Options.UseForeColor = True
        Me.e14.Appearance.Options.UseTextOptions = True
        Me.e14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e14.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e14.Location = New System.Drawing.Point(94, 183)
        Me.e14.Name = "e14"
        Me.e14.Size = New System.Drawing.Size(74, 52)
        Me.e14.TabIndex = 13
        Me.e14.Text = "14"
        '
        'e13
        '
        Me.e13.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e13.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e13.Appearance.Options.UseFont = True
        Me.e13.Appearance.Options.UseForeColor = True
        Me.e13.Appearance.Options.UseTextOptions = True
        Me.e13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e13.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e13.Location = New System.Drawing.Point(14, 183)
        Me.e13.Name = "e13"
        Me.e13.Size = New System.Drawing.Size(74, 52)
        Me.e13.TabIndex = 12
        Me.e13.Text = "13"
        '
        'e12
        '
        Me.e12.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e12.Appearance.Options.UseFont = True
        Me.e12.Appearance.Options.UseForeColor = True
        Me.e12.Appearance.Options.UseTextOptions = True
        Me.e12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e12.Location = New System.Drawing.Point(254, 125)
        Me.e12.Name = "e12"
        Me.e12.Size = New System.Drawing.Size(74, 52)
        Me.e12.TabIndex = 11
        Me.e12.Text = "12"
        '
        'e11
        '
        Me.e11.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e11.Appearance.Options.UseFont = True
        Me.e11.Appearance.Options.UseForeColor = True
        Me.e11.Appearance.Options.UseTextOptions = True
        Me.e11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e11.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e11.Location = New System.Drawing.Point(174, 125)
        Me.e11.Name = "e11"
        Me.e11.Size = New System.Drawing.Size(74, 52)
        Me.e11.TabIndex = 10
        Me.e11.Text = "11"
        '
        'e10
        '
        Me.e10.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e10.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e10.Appearance.Options.UseFont = True
        Me.e10.Appearance.Options.UseForeColor = True
        Me.e10.Appearance.Options.UseTextOptions = True
        Me.e10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e10.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e10.Location = New System.Drawing.Point(94, 125)
        Me.e10.Name = "e10"
        Me.e10.Size = New System.Drawing.Size(74, 52)
        Me.e10.TabIndex = 9
        Me.e10.Text = "10"
        '
        'e9
        '
        Me.e9.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e9.Appearance.Options.UseFont = True
        Me.e9.Appearance.Options.UseForeColor = True
        Me.e9.Appearance.Options.UseTextOptions = True
        Me.e9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e9.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e9.Location = New System.Drawing.Point(14, 125)
        Me.e9.Name = "e9"
        Me.e9.Size = New System.Drawing.Size(74, 52)
        Me.e9.TabIndex = 8
        Me.e9.Text = "9"
        '
        'e8
        '
        Me.e8.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e8.Appearance.Options.UseFont = True
        Me.e8.Appearance.Options.UseForeColor = True
        Me.e8.Appearance.Options.UseTextOptions = True
        Me.e8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e8.Location = New System.Drawing.Point(254, 65)
        Me.e8.Name = "e8"
        Me.e8.Size = New System.Drawing.Size(74, 52)
        Me.e8.TabIndex = 7
        Me.e8.Text = "8"
        '
        'e7
        '
        Me.e7.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e7.Appearance.Options.UseFont = True
        Me.e7.Appearance.Options.UseForeColor = True
        Me.e7.Appearance.Options.UseTextOptions = True
        Me.e7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e7.Location = New System.Drawing.Point(174, 65)
        Me.e7.Name = "e7"
        Me.e7.Size = New System.Drawing.Size(74, 52)
        Me.e7.TabIndex = 6
        Me.e7.Text = "7"
        '
        'e6
        '
        Me.e6.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e6.Appearance.Options.UseFont = True
        Me.e6.Appearance.Options.UseForeColor = True
        Me.e6.Appearance.Options.UseTextOptions = True
        Me.e6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e6.Location = New System.Drawing.Point(94, 65)
        Me.e6.Name = "e6"
        Me.e6.Size = New System.Drawing.Size(74, 52)
        Me.e6.TabIndex = 5
        Me.e6.Text = "6"
        '
        'e5
        '
        Me.e5.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e5.Appearance.Options.UseFont = True
        Me.e5.Appearance.Options.UseForeColor = True
        Me.e5.Appearance.Options.UseTextOptions = True
        Me.e5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e5.Location = New System.Drawing.Point(14, 65)
        Me.e5.Name = "e5"
        Me.e5.Size = New System.Drawing.Size(74, 52)
        Me.e5.TabIndex = 4
        Me.e5.Text = "5"
        '
        'e4
        '
        Me.e4.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e4.Appearance.Options.UseFont = True
        Me.e4.Appearance.Options.UseForeColor = True
        Me.e4.Location = New System.Drawing.Point(254, 7)
        Me.e4.Name = "e4"
        Me.e4.Size = New System.Drawing.Size(74, 52)
        Me.e4.TabIndex = 3
        Me.e4.Text = "4"
        '
        'e3
        '
        Me.e3.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e3.Appearance.Options.UseFont = True
        Me.e3.Appearance.Options.UseForeColor = True
        Me.e3.Location = New System.Drawing.Point(174, 7)
        Me.e3.Name = "e3"
        Me.e3.Size = New System.Drawing.Size(74, 52)
        Me.e3.TabIndex = 2
        Me.e3.Text = "3"
        '
        'e2
        '
        Me.e2.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e2.Appearance.Options.UseFont = True
        Me.e2.Appearance.Options.UseForeColor = True
        Me.e2.Location = New System.Drawing.Point(94, 7)
        Me.e2.Name = "e2"
        Me.e2.Size = New System.Drawing.Size(74, 52)
        Me.e2.TabIndex = 1
        Me.e2.Text = "2"
        '
        'e1
        '
        Me.e1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.e1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.e1.Appearance.Options.UseFont = True
        Me.e1.Appearance.Options.UseForeColor = True
        Me.e1.Appearance.Options.UseTextOptions = True
        Me.e1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.e1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.e1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.e1.Location = New System.Drawing.Point(14, 7)
        Me.e1.Name = "e1"
        Me.e1.Size = New System.Drawing.Size(74, 52)
        Me.e1.TabIndex = 0
        Me.e1.Text = "1"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Okut"
        Me.BarButtonItem11.Id = 15
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarSubItem8
        '
        Me.BarSubItem8.Caption = "Office 2003"
        Me.BarSubItem8.Id = 57
        Me.BarSubItem8.Name = "BarSubItem8"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 85
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'ds_fiyattipi
        '
        Me.ds_fiyattipi.DataSetName = "NewDataSet"
        Me.ds_fiyattipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_fiyattipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'ds_nGirisCikis
        '
        Me.ds_nGirisCikis.DataSetName = "NewDataSet"
        Me.ds_nGirisCikis.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_nGirisCikis.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'Group_Kapatma
        '
        Me.Group_Kapatma.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Group_Kapatma.AppearanceCaption.Options.UseFont = True
        Me.Group_Kapatma.Controls.Add(Me.GroupControl_Taksit)
        Me.Group_Kapatma.Controls.Add(Me.PanelControl5)
        Me.Group_Kapatma.Controls.Add(Me.PanelControl2)
        Me.Group_Kapatma.Controls.Add(Me.GroupControl_Pesinat)
        Me.Group_Kapatma.Dock = System.Windows.Forms.DockStyle.Right
        Me.Group_Kapatma.Location = New System.Drawing.Point(1293, 28)
        Me.Group_Kapatma.Name = "Group_Kapatma"
        Me.Group_Kapatma.Size = New System.Drawing.Size(472, 930)
        Me.Group_Kapatma.TabIndex = 4
        Me.Group_Kapatma.Text = "KapatmaDetayı"
        Me.Group_Kapatma.Visible = False
        '
        'GroupControl_Taksit
        '
        Me.GroupControl_Taksit.Controls.Add(Me.GridControl3)
        Me.GroupControl_Taksit.Controls.Add(Me.PanelControl4)
        Me.GroupControl_Taksit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl_Taksit.Location = New System.Drawing.Point(2, 211)
        Me.GroupControl_Taksit.Name = "GroupControl_Taksit"
        Me.GroupControl_Taksit.Size = New System.Drawing.Size(468, 567)
        Me.GroupControl_Taksit.TabIndex = 4
        Me.GroupControl_Taksit.Text = "Taksitlendirme Bu Bölümde Yapılır..."
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.kisayol_taksit
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 84)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_taksit})
        Me.GridControl3.Size = New System.Drawing.Size(464, 481)
        Me.GridControl3.TabIndex = 1
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'kisayol_taksit
        '
        Me.kisayol_taksit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem10, Me.MenuItem11, Me.MenuItem22, Me.MenuItem12, Me.MenuItem13, Me.MenuItem16, Me.MenuItem15, Me.MenuItem17, Me.MenuItem21, Me.MenuItem20})
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem8.Text = "Satır Ekle"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem10.Text = "Değer Yay"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem11.Text = "Satır Sil"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 3
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.MenuItem22.Text = "Ödeme Planını Aktar"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 4
        Me.MenuItem12.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 5
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.AltF9
        Me.MenuItem13.Text = "Satırları Sil"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 6
        Me.MenuItem16.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 7
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem15.Text = "Pesinat Bolumu"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 8
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Toplu Taksitlendir"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 9
        Me.MenuItem21.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 10
        Me.MenuItem20.Text = "Diğer Taksitlerini Göster"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnTaksitID1, Me.colnAlisverisID1, Me.coldteTarihi, Me.collTutari, Me.colStatus})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colStatus
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Tag = "1"
        StyleFormatCondition5.Value1 = "1"
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition5})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 30
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colnTaksitID1
        '
        Me.colnTaksitID1.Caption = "TaksitID"
        Me.colnTaksitID1.FieldName = "nTaksitID"
        Me.colnTaksitID1.Name = "colnTaksitID1"
        Me.colnTaksitID1.OptionsColumn.AllowFocus = False
        '
        'colnAlisverisID1
        '
        Me.colnAlisverisID1.Caption = "Alışveriş ID"
        Me.colnAlisverisID1.FieldName = "nAlisverisID"
        Me.colnAlisverisID1.Name = "colnAlisverisID1"
        Me.colnAlisverisID1.OptionsColumn.AllowFocus = False
        '
        'coldteTarihi
        '
        Me.coldteTarihi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.coldteTarihi.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.coldteTarihi.AppearanceCell.Options.UseFont = True
        Me.coldteTarihi.AppearanceCell.Options.UseForeColor = True
        Me.coldteTarihi.Caption = "Tarih"
        Me.coldteTarihi.DisplayFormat.FormatString = "d"
        Me.coldteTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", "{0} Kayıt")})
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 0
        '
        'collTutari
        '
        Me.collTutari.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collTutari.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.collTutari.AppearanceCell.Options.UseFont = True
        Me.collTutari.AppearanceCell.Options.UseForeColor = True
        Me.collTutari.Caption = "Tutarı"
        Me.collTutari.ColumnEdit = Me.sec_taksit
        Me.collTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.collTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutari.FieldName = "lTutari"
        Me.collTutari.Name = "collTutari"
        Me.collTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTutari", "{0:#,0.00##}")})
        Me.collTutari.Visible = True
        Me.collTutari.VisibleIndex = 1
        '
        'sec_taksit
        '
        Me.sec_taksit.AutoHeight = False
        Me.sec_taksit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_taksit.DisplayFormat.FormatString = "#,0.00"
        Me.sec_taksit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_taksit.EditFormat.FormatString = "#,0.00##"
        Me.sec_taksit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_taksit.Name = "sec_taksit"
        Me.sec_taksit.NullText = "0.00"
        Me.sec_taksit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.dteIlkTaksit)
        Me.PanelControl4.Controls.Add(Me.LabelControl10)
        Me.PanelControl4.Controls.Add(Me.sec_sAralik)
        Me.PanelControl4.Controls.Add(Me.LabelControl9)
        Me.PanelControl4.Controls.Add(Me.LabelControl8)
        Me.PanelControl4.Controls.Add(Me.LabelControl11)
        Me.PanelControl4.Controls.Add(Me.btn_ekle)
        Me.PanelControl4.Controls.Add(Me.txt_tutar)
        Me.PanelControl4.Controls.Add(Me.txt_sayi)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 21)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(464, 63)
        Me.PanelControl4.TabIndex = 0
        '
        'dteIlkTaksit
        '
        Me.dteIlkTaksit.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dteIlkTaksit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteIlkTaksit.Location = New System.Drawing.Point(3, 30)
        Me.dteIlkTaksit.Name = "dteIlkTaksit"
        Me.dteIlkTaksit.Size = New System.Drawing.Size(119, 24)
        Me.dteIlkTaksit.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(200, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(70, 19)
        Me.LabelControl10.TabIndex = 11
        Me.LabelControl10.Text = "Aralık"
        '
        'sec_sAralik
        '
        Me.sec_sAralik.EditValue = "Ay"
        Me.sec_sAralik.EnterMoveNextControl = True
        Me.sec_sAralik.Location = New System.Drawing.Point(202, 29)
        Me.sec_sAralik.Name = "sec_sAralik"
        Me.sec_sAralik.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sAralik.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_sAralik.Properties.Appearance.Options.UseFont = True
        Me.sec_sAralik.Properties.Appearance.Options.UseForeColor = True
        Me.sec_sAralik.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sAralik.Properties.Items.AddRange(New Object() {"Gün", "Hafta", "Ay", "3Ay", "Yıl"})
        Me.sec_sAralik.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sAralik.Size = New System.Drawing.Size(70, 24)
        Me.sec_sAralik.TabIndex = 2
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(269, 6)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(102, 18)
        Me.LabelControl9.TabIndex = 9
        Me.LabelControl9.Text = "Tutar"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(122, 6)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 18)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "Sayı"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisPath
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(5, 6)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(113, 18)
        Me.LabelControl11.TabIndex = 7
        Me.LabelControl11.Text = "ilkTaksit"
        '
        'btn_ekle
        '
        Me.btn_ekle.Image = CType(resources.GetObject("btn_ekle.Image"), System.Drawing.Image)
        Me.btn_ekle.Location = New System.Drawing.Point(378, 29)
        Me.btn_ekle.Name = "btn_ekle"
        Me.btn_ekle.Size = New System.Drawing.Size(76, 28)
        Me.btn_ekle.TabIndex = 3
        Me.btn_ekle.Text = "Ekle"
        '
        'txt_tutar
        '
        Me.txt_tutar.EnterMoveNextControl = True
        Me.txt_tutar.Location = New System.Drawing.Point(272, 29)
        Me.txt_tutar.Name = "txt_tutar"
        Me.txt_tutar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_tutar.Properties.Appearance.Options.UseFont = True
        Me.txt_tutar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tutar.Properties.DisplayFormat.FormatString = "c"
        Me.txt_tutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tutar.Properties.EditFormat.FormatString = "c"
        Me.txt_tutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_tutar.Properties.NullText = "0.00"
        Me.txt_tutar.Size = New System.Drawing.Size(106, 24)
        Me.txt_tutar.TabIndex = 3
        '
        'txt_sayi
        '
        Me.txt_sayi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_sayi.EnterMoveNextControl = True
        Me.txt_sayi.Location = New System.Drawing.Point(122, 29)
        Me.txt_sayi.Name = "txt_sayi"
        Me.txt_sayi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sayi.Properties.Appearance.Options.UseFont = True
        Me.txt_sayi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sayi.Size = New System.Drawing.Size(80, 24)
        Me.txt_sayi.TabIndex = 1
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.lbl_vade)
        Me.PanelControl5.Controls.Add(Me.lbl_gun)
        Me.PanelControl5.Controls.Add(Me.lbl_taksit_tutari)
        Me.PanelControl5.Controls.Add(Me.lbl_taksit_sayisi)
        Me.PanelControl5.Controls.Add(Me.lbl_pesinat)
        Me.PanelControl5.Controls.Add(Me.lbl_Satis)
        Me.PanelControl5.Controls.Add(Me.LabelControl6)
        Me.PanelControl5.Controls.Add(Me.LabelControl5)
        Me.PanelControl5.Controls.Add(Me.LabelControl4)
        Me.PanelControl5.Controls.Add(Me.LabelControl3)
        Me.PanelControl5.Controls.Add(Me.LabelControl2)
        Me.PanelControl5.Controls.Add(Me.LabelControl7)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(2, 778)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(468, 57)
        Me.PanelControl5.TabIndex = 3
        '
        'lbl_vade
        '
        Me.lbl_vade.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_vade.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_vade.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_vade.Location = New System.Drawing.Point(389, 30)
        Me.lbl_vade.Name = "lbl_vade"
        Me.lbl_vade.Size = New System.Drawing.Size(12, 17)
        Me.lbl_vade.TabIndex = 25
        Me.lbl_vade.Text = "%"
        '
        'lbl_gun
        '
        Me.lbl_gun.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gun.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gun.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_gun.Location = New System.Drawing.Point(389, 7)
        Me.lbl_gun.Name = "lbl_gun"
        Me.lbl_gun.Size = New System.Drawing.Size(12, 17)
        Me.lbl_gun.TabIndex = 24
        Me.lbl_gun.Text = "%"
        '
        'lbl_taksit_tutari
        '
        Me.lbl_taksit_tutari.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_taksit_tutari.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_taksit_tutari.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_taksit_tutari.Location = New System.Drawing.Point(250, 30)
        Me.lbl_taksit_tutari.Name = "lbl_taksit_tutari"
        Me.lbl_taksit_tutari.Size = New System.Drawing.Size(12, 17)
        Me.lbl_taksit_tutari.TabIndex = 23
        Me.lbl_taksit_tutari.Text = "%"
        '
        'lbl_taksit_sayisi
        '
        Me.lbl_taksit_sayisi.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_taksit_sayisi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_taksit_sayisi.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_taksit_sayisi.Location = New System.Drawing.Point(250, 7)
        Me.lbl_taksit_sayisi.Name = "lbl_taksit_sayisi"
        Me.lbl_taksit_sayisi.Size = New System.Drawing.Size(12, 17)
        Me.lbl_taksit_sayisi.TabIndex = 22
        Me.lbl_taksit_sayisi.Text = "%"
        '
        'lbl_pesinat
        '
        Me.lbl_pesinat.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_pesinat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_pesinat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_pesinat.Location = New System.Drawing.Point(94, 30)
        Me.lbl_pesinat.Name = "lbl_pesinat"
        Me.lbl_pesinat.Size = New System.Drawing.Size(12, 17)
        Me.lbl_pesinat.TabIndex = 21
        Me.lbl_pesinat.Text = "%"
        '
        'lbl_Satis
        '
        Me.lbl_Satis.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Satis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_Satis.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Satis.Location = New System.Drawing.Point(94, 7)
        Me.lbl_Satis.Name = "lbl_Satis"
        Me.lbl_Satis.Size = New System.Drawing.Size(12, 17)
        Me.lbl_Satis.TabIndex = 20
        Me.lbl_Satis.Text = "%"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(317, 30)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 17)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "OrtVade:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(325, 7)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 17)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "OrtGün:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(160, 30)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "TaksitTutarı:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(157, 7)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 17)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "TaksitSayısı:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(32, 30)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 17)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Peşinat:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(11, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "SatışTutarı:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lbl_lKalan)
        Me.PanelControl2.Controls.Add(Me.lblTaksit_info)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(2, 835)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(468, 93)
        Me.PanelControl2.TabIndex = 2
        '
        'lbl_lKalan
        '
        Me.lbl_lKalan.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_lKalan.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_lKalan.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_lKalan.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.lbl_lKalan.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lbl_lKalan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_lKalan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_lKalan.Location = New System.Drawing.Point(2, 33)
        Me.lbl_lKalan.Name = "lbl_lKalan"
        Me.lbl_lKalan.Size = New System.Drawing.Size(464, 47)
        Me.lbl_lKalan.TabIndex = 7
        Me.lbl_lKalan.Text = "***"
        '
        'lblTaksit_info
        '
        Me.lblTaksit_info.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblTaksit_info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTaksit_info.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTaksit_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTaksit_info.Location = New System.Drawing.Point(2, 80)
        Me.lblTaksit_info.Name = "lblTaksit_info"
        Me.lblTaksit_info.Size = New System.Drawing.Size(464, 11)
        Me.lblTaksit_info.TabIndex = 6
        Me.lblTaksit_info.Text = "***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(2, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(464, 31)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "       Satışa Dön (F2)        "
        '
        'GroupControl_Pesinat
        '
        Me.GroupControl_Pesinat.Controls.Add(Me.GridControl2)
        Me.GroupControl_Pesinat.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl_Pesinat.Location = New System.Drawing.Point(2, 23)
        Me.GroupControl_Pesinat.Name = "GroupControl_Pesinat"
        Me.GroupControl_Pesinat.Size = New System.Drawing.Size(468, 188)
        Me.GroupControl_Pesinat.TabIndex = 1
        Me.GroupControl_Pesinat.Text = "Peşinatlar bu Bölüme Girilir..."
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_odeme
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 21)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sOdemeSekli, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemCalcEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(464, 165)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_odeme
        '
        Me.kisayol_odeme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem34, Me.MenuItem18, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29})
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 0
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem14.Text = "Satır Ekle"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 1
        Me.MenuItem34.Text = "Satır Ekle Peşinatlardan"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Satır Düzelt"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 3
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem23.Text = "Satır Sil"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 4
        Me.MenuItem24.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 5
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem25.Text = "Tamam"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 6
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem26.Text = "Vazgeç"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 7
        Me.MenuItem27.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 8
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem28.Text = "Taksit Bolumu"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 9
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem29.Text = "Toplu Taksitlendir"
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnOdemeID, Me.GridColumn1, Me.colsOdemeSekli, Me.colnOdemeKodu, Me.GridColumn2, Me.coldteOdemeTarihi, Me.coldteValorTarihi, Me.collOdemeTutar, Me.colsDovizCinsi, Me.collDovizTutar, Me.collMakbuzNo, Me.collOdemeNo, Me.colnTaksitID, Me.colnIadeAlisverisID, Me.GridColumn3, Me.colnKasaNo, Me.colsKartNo, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colsMagaza})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 30
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView2.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView2.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colnOdemeID
        '
        Me.colnOdemeID.Caption = "Ödeme ID"
        Me.colnOdemeID.FieldName = "nOdemeID"
        Me.colnOdemeID.Name = "colnOdemeID"
        Me.colnOdemeID.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Alışveriş ID"
        Me.GridColumn1.FieldName = "nAlisverisID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'colsOdemeSekli
        '
        Me.colsOdemeSekli.Caption = "Ödeme Şekli"
        Me.colsOdemeSekli.ColumnEdit = Me.sec_sOdemeSekli
        Me.colsOdemeSekli.FieldName = "sOdemeSekli"
        Me.colsOdemeSekli.Name = "colsOdemeSekli"
        Me.colsOdemeSekli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", "{0} Kayıt")})
        Me.colsOdemeSekli.Visible = True
        Me.colsOdemeSekli.VisibleIndex = 0
        '
        'sec_sOdemeSekli
        '
        Me.sec_sOdemeSekli.AutoHeight = False
        Me.sec_sOdemeSekli.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeSekli.DisplayMember = "sOdemeSekli"
        Me.sec_sOdemeSekli.Name = "sec_sOdemeSekli"
        Me.sec_sOdemeSekli.NullText = "[ÖdemeŞekli]"
        Me.sec_sOdemeSekli.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sOdemeSekli.ValueMember = "sOdemeSekli"
        '
        'colnOdemeKodu
        '
        Me.colnOdemeKodu.Caption = "Ödeme Kodu"
        Me.colnOdemeKodu.FieldName = "nOdemeKodu"
        Me.colnOdemeKodu.Name = "colnOdemeKodu"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "KasiyerRumuzu"
        Me.GridColumn2.FieldName = "sKasiyerRumuzu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'coldteOdemeTarihi
        '
        Me.coldteOdemeTarihi.Caption = "OdemeTarihi"
        Me.coldteOdemeTarihi.FieldName = "dteOdemeTarihi"
        Me.coldteOdemeTarihi.Name = "coldteOdemeTarihi"
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        '
        'collOdemeTutar
        '
        Me.collOdemeTutar.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collOdemeTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collOdemeTutar.AppearanceCell.Options.UseBackColor = True
        Me.collOdemeTutar.AppearanceCell.Options.UseFont = True
        Me.collOdemeTutar.Caption = "Ödeme Tutarı"
        Me.collOdemeTutar.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.collOdemeTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00##}")})
        Me.collOdemeTutar.Visible = True
        Me.collOdemeTutar.VisibleIndex = 1
        Me.collOdemeTutar.Width = 77
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "#,0.00"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "#,0.00##"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        Me.RepositoryItemCalcEdit1.NullText = "0.00"
        Me.RepositoryItemCalcEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        Me.colsDovizCinsi.Width = 66
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "sDovizCinsi"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "[Doviz]"
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit1.ValueMember = "sDovizCinsi"
        '
        'collDovizTutar
        '
        Me.collDovizTutar.Caption = "Döviz Tutar"
        Me.collDovizTutar.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.collDovizTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizTutar.FieldName = "lDovizTutar"
        Me.collDovizTutar.Name = "collDovizTutar"
        Me.collDovizTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lDovizTutar", "{0:#,0.00##}")})
        Me.collDovizTutar.Width = 69
        '
        'collMakbuzNo
        '
        Me.collMakbuzNo.Caption = "MakbuzNo"
        Me.collMakbuzNo.FieldName = "lMakbuzNo"
        Me.collMakbuzNo.Name = "collMakbuzNo"
        '
        'collOdemeNo
        '
        Me.collOdemeNo.Caption = "OdemeNo"
        Me.collOdemeNo.FieldName = "lOdemeNo"
        Me.collOdemeNo.Name = "collOdemeNo"
        '
        'colnTaksitID
        '
        Me.colnTaksitID.Caption = "TaksitID"
        Me.colnTaksitID.FieldName = "nTaksitID"
        Me.colnTaksitID.Name = "colnTaksitID"
        Me.colnTaksitID.OptionsColumn.AllowEdit = False
        '
        'colnIadeAlisverisID
        '
        Me.colnIadeAlisverisID.Caption = "IadeAlisverisID"
        Me.colnIadeAlisverisID.FieldName = "nIadeAlisverisID"
        Me.colnIadeAlisverisID.Name = "colnIadeAlisverisID"
        Me.colnIadeAlisverisID.OptionsColumn.AllowEdit = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Muhasebeye İşlendimi"
        Me.GridColumn3.FieldName = "bMuhasebeyeIslendimi"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'colnKasaNo
        '
        Me.colnKasaNo.Caption = "KasaNo"
        Me.colnKasaNo.FieldName = "nKasaNo"
        Me.colnKasaNo.Name = "colnKasaNo"
        Me.colnKasaNo.OptionsColumn.AllowEdit = False
        '
        'colsKartNo
        '
        Me.colsKartNo.Caption = "KartNo"
        Me.colsKartNo.FieldName = "sKartNo"
        Me.colsKartNo.Name = "colsKartNo"
        Me.colsKartNo.Visible = True
        Me.colsKartNo.VisibleIndex = 2
        Me.colsKartNo.Width = 131
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanıcı Adı"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Mağaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.OptionsColumn.AllowEdit = False
        '
        'Group_Satis
        '
        Me.Group_Satis.Controls.Add(Me.PanelHareket)
        Me.Group_Satis.Controls.Add(Me.PanelBaslik)
        Me.Group_Satis.Controls.Add(Me.PanelEkle)
        Me.Group_Satis.Controls.Add(Me.Panel_toplam)
        Me.Group_Satis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Group_Satis.Location = New System.Drawing.Point(0, 28)
        Me.Group_Satis.Name = "Group_Satis"
        Me.Group_Satis.Size = New System.Drawing.Size(1293, 930)
        Me.Group_Satis.TabIndex = 5
        Me.Group_Satis.Text = "SatışDetayı"
        '
        'ds_odeme
        '
        Me.ds_odeme.DataSetName = "NewDataSet"
        Me.ds_odeme.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_odeme.Tables.AddRange(New System.Data.DataTable() {Me.DataTable7})
        '
        'DataTable7
        '
        Me.DataTable7.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn134, Me.DataColumn135, Me.DataColumn136, Me.DataColumn137, Me.DataColumn138, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn145, Me.DataColumn146, Me.DataColumn147, Me.DataColumn148, Me.DataColumn149, Me.DataColumn150, Me.DataColumn151, Me.DataColumn152, Me.DataColumn153})
        Me.DataTable7.TableName = "Table1"
        '
        'DataColumn134
        '
        Me.DataColumn134.ColumnName = "nOdemeID"
        '
        'DataColumn135
        '
        Me.DataColumn135.ColumnName = "nAlisverisID"
        '
        'DataColumn136
        '
        Me.DataColumn136.ColumnName = "sOdemeSekli"
        '
        'DataColumn137
        '
        Me.DataColumn137.ColumnName = "nOdemeKodu"
        Me.DataColumn137.DataType = GetType(Long)
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn139
        '
        Me.DataColumn139.Caption = "dteOdemeTarihi"
        Me.DataColumn139.ColumnName = "dteOdemeTarihi"
        Me.DataColumn139.DataType = GetType(Date)
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "dteValorTarihi"
        Me.DataColumn140.DataType = GetType(Date)
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "lOdemeTutar"
        Me.DataColumn141.DataType = GetType(Decimal)
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "sDovizCinsi"
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "lDovizTutar"
        Me.DataColumn143.DataType = GetType(Decimal)
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "lMakbuzNo"
        '
        'DataColumn145
        '
        Me.DataColumn145.ColumnName = "lOdemeNo"
        '
        'DataColumn146
        '
        Me.DataColumn146.ColumnName = "nTaksitID"
        '
        'DataColumn147
        '
        Me.DataColumn147.ColumnName = "nIadeAlisverisID"
        '
        'DataColumn148
        '
        Me.DataColumn148.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn148.DataType = GetType(Boolean)
        '
        'DataColumn149
        '
        Me.DataColumn149.ColumnName = "nKasaNo"
        Me.DataColumn149.DataType = GetType(Long)
        '
        'DataColumn150
        '
        Me.DataColumn150.ColumnName = "sKartNo"
        '
        'DataColumn151
        '
        Me.DataColumn151.ColumnName = "sKullaniciAdi"
        '
        'DataColumn152
        '
        Me.DataColumn152.ColumnName = "dteKayitTarihi"
        Me.DataColumn152.DataType = GetType(Date)
        '
        'DataColumn153
        '
        Me.DataColumn153.ColumnName = "sMagaza"
        '
        'ds_taksit
        '
        Me.ds_taksit.DataSetName = "NewDataSet"
        Me.ds_taksit.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_taksit.Tables.AddRange(New System.Data.DataTable() {Me.DataTable8})
        '
        'DataTable8
        '
        Me.DataTable8.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn154, Me.DataColumn155, Me.DataColumn156, Me.DataColumn157})
        Me.DataTable8.TableName = "Table1"
        '
        'DataColumn154
        '
        Me.DataColumn154.ColumnName = "nTaksitID"
        '
        'DataColumn155
        '
        Me.DataColumn155.ColumnName = "nAlisverisID"
        '
        'DataColumn156
        '
        Me.DataColumn156.ColumnName = "dteTarihi"
        Me.DataColumn156.DataType = GetType(Date)
        '
        'DataColumn157
        '
        Me.DataColumn157.ColumnName = "lTutari"
        Me.DataColumn157.DataType = GetType(Decimal)
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable9})
        '
        'DataTable9
        '
        Me.DataTable9.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn158, Me.DataColumn159, Me.DataColumn160})
        Me.DataTable9.TableName = "Table1"
        '
        'DataColumn158
        '
        Me.DataColumn158.ColumnName = "dteTaksitTarihi"
        Me.DataColumn158.DataType = GetType(Date)
        '
        'DataColumn159
        '
        Me.DataColumn159.ColumnName = "lTutari"
        Me.DataColumn159.DataType = GetType(Decimal)
        '
        'DataColumn160
        '
        Me.DataColumn160.ColumnName = "nTaksit"
        Me.DataColumn160.DataType = GetType(Long)
        '
        'Timer1
        '
        '
        'rowToplamMiktar
        '
        Me.rowToplamMiktar.Caption = "Toplam"
        Me.rowToplamMiktar.FieldName = "lToplamMiktar"
        Me.rowToplamMiktar.Format.FormatString = "#,0.####"
        Me.rowToplamMiktar.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowToplamMiktar.ReadOnly = True
        '
        'rowMalBedeli
        '
        Me.rowMalBedeli.FieldName = "lMalBedeli"
        Me.rowMalBedeli.Format.FormatString = "#,0.00"
        Me.rowMalBedeli.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowMalBedeli.ReadOnly = True
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Puan"
        Me.BarButtonItem23.Hint = "Satisa Puan Vermek veya Satistan Puan Dusmek icin..."
        Me.BarButtonItem23.Id = 48
        Me.BarButtonItem23.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem23.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem23.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem23.Name = "BarButtonItem23"
        ToolTipTitleItem24.Text = "Puan"
        ToolTipItem15.LeftIndent = 6
        ToolTipItem15.Text = "Satis Tutarindan Oransal veya Tutarsal Bazli Musteriye Puan veya Hediye Ceki veri" &
    "lebilir. Istenirse Musteri Puan/Hediye Ceki Kullanarak Satis kapatılabilir..."
        ToolTipTitleItem25.LeftIndent = 6
        ToolTipTitleItem25.Text = "Alt+P"
        SuperToolTip15.Items.Add(ToolTipTitleItem24)
        SuperToolTip15.Items.Add(ToolTipItem15)
        SuperToolTip15.Items.Add(ToolTipSeparatorItem10)
        SuperToolTip15.Items.Add(ToolTipTitleItem25)
        Me.BarButtonItem23.SuperTip = SuperToolTip15
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Yuvarla"
        Me.BarButtonItem24.Hint = "Satis Tutarinda Yuvarlama Yapmak/Otomatik Alt Iskonto Uygulamak icin"
        Me.BarButtonItem24.Id = 50
        Me.BarButtonItem24.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem24.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem24.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem24.Name = "BarButtonItem24"
        ToolTipTitleItem26.Text = "Tutar Yuvarla"
        ToolTipItem16.LeftIndent = 6
        ToolTipItem16.Text = "Satis Tutarinda Yuvarlama Yapmak veya Otomatik Iskonto Uygulamak icin kullanilir." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gelen Ekranda Net Satis Rakamı girildiğinde program otomatik olarak Net Satis " &
    "Tutari ni ayarlayacaktır."
        ToolTipTitleItem27.LeftIndent = 6
        ToolTipTitleItem27.Text = "Alt+Y"
        SuperToolTip16.Items.Add(ToolTipTitleItem26)
        SuperToolTip16.Items.Add(ToolTipItem16)
        SuperToolTip16.Items.Add(ToolTipSeparatorItem11)
        SuperToolTip16.Items.Add(ToolTipTitleItem27)
        Me.BarButtonItem24.SuperTip = SuperToolTip16
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Yuvarla"
        Me.BarButtonItem8.Hint = "Satis Tutarinda Yuvarlama Yapmak/Otomatik Alt Iskonto Uygulamak icin"
        Me.BarButtonItem8.Id = 50
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        ToolTipTitleItem28.Text = "Tutar Yuvarla"
        ToolTipItem17.LeftIndent = 6
        ToolTipItem17.Text = "Satis Tutarinda Yuvarlama Yapmak veya Otomatik Iskonto Uygulamak icin kullanilir." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gelen Ekranda Net Satis Rakamı girildiğinde program otomatik olarak Net Satis " &
    "Tutari ni ayarlayacaktır."
        ToolTipTitleItem29.LeftIndent = 6
        ToolTipTitleItem29.Text = "Alt+Y"
        SuperToolTip17.Items.Add(ToolTipTitleItem28)
        SuperToolTip17.Items.Add(ToolTipItem17)
        SuperToolTip17.Items.Add(ToolTipSeparatorItem12)
        SuperToolTip17.Items.Add(ToolTipTitleItem29)
        Me.BarButtonItem8.SuperTip = SuperToolTip17
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Yuvarla"
        Me.BarButtonItem22.Hint = "Satis Tutarinda Yuvarlama Yapmak/Otomatik Alt Iskonto Uygulamak icin"
        Me.BarButtonItem22.Id = 50
        Me.BarButtonItem22.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem22.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem22.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem22.Name = "BarButtonItem22"
        ToolTipTitleItem30.Text = "Tutar Yuvarla"
        ToolTipItem18.LeftIndent = 6
        ToolTipItem18.Text = "Satis Tutarinda Yuvarlama Yapmak veya Otomatik Iskonto Uygulamak icin kullanilir." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gelen Ekranda Net Satis Rakamı girildiğinde program otomatik olarak Net Satis " &
    "Tutari ni ayarlayacaktır."
        ToolTipTitleItem31.LeftIndent = 6
        ToolTipTitleItem31.Text = "Alt+Y"
        SuperToolTip18.Items.Add(ToolTipTitleItem30)
        SuperToolTip18.Items.Add(ToolTipItem18)
        SuperToolTip18.Items.Add(ToolTipSeparatorItem13)
        SuperToolTip18.Items.Add(ToolTipTitleItem31)
        Me.BarButtonItem22.SuperTip = SuperToolTip18
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Yuvarla"
        Me.BarButtonItem26.Hint = "Satis Tutarinda Yuvarlama Yapmak/Otomatik Alt Iskonto Uygulamak icin"
        Me.BarButtonItem26.Id = 50
        Me.BarButtonItem26.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem26.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem26.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem26.Name = "BarButtonItem26"
        ToolTipTitleItem32.Text = "Tutar Yuvarla"
        ToolTipItem19.LeftIndent = 6
        ToolTipItem19.Text = "Satis Tutarinda Yuvarlama Yapmak veya Otomatik Iskonto Uygulamak icin kullanilir." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gelen Ekranda Net Satis Rakamı girildiğinde program otomatik olarak Net Satis " &
    "Tutari ni ayarlayacaktır."
        ToolTipTitleItem33.LeftIndent = 6
        ToolTipTitleItem33.Text = "Alt+Y"
        SuperToolTip19.Items.Add(ToolTipTitleItem32)
        SuperToolTip19.Items.Add(ToolTipItem19)
        SuperToolTip19.Items.Add(ToolTipSeparatorItem14)
        SuperToolTip19.Items.Add(ToolTipTitleItem33)
        Me.BarButtonItem26.SuperTip = SuperToolTip19
        '
        'frm_Perakende_Satis
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1765, 988)
        Me.Controls.Add(Me.Group_Satis)
        Me.Controls.Add(Me.Group_Kapatma)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Perakende_Satis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perakende Satış"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_lDipIskonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplam.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.VGrid_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelBaslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBaslik.ResumeLayout(False)
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_adres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_nGirisCikis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sAdres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Sinif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelEkle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEkle.ResumeLayout(False)
        Me.PanelEkle.PerformLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelHareket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHareket.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nGirisCikis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeKodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDovizCinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TusPanel.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.txt_etiket_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_fiyattipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_nGirisCikis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_Kapatma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Kapatma.ResumeLayout(False)
        CType(Me.GroupControl_Taksit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl_Taksit.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_taksit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.sec_sAralik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sayi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl_Pesinat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl_Pesinat.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sOdemeSekli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_Satis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Satis.ResumeLayout(False)
        CType(Me.ds_odeme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_taksit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public connection_resmi
    Public kasiyerno
    Public kullanici
    Public status As Boolean = False
    Public islemstatus As Boolean = False
    Public aktarim As Boolean = False
    Public nIslemID As Integer = 0
    Public bKopya As Boolean = False
    Public sinif2Bakma As Boolean = False
    Public nAlisVerisID
    Public sFisTipi
    Public dteFisTarihi
    Public lFaturaNo
    Public nMusteriID
    Public sAdi
    Public sSoyadi
    Public sMagaza
    Public sKasiyerRumuzu
    Public sKasiyer
    Public sHareketTipi
    Public nKasaNo
    Public sAdres1 As String = ""
    Public sAdres2 As String = ""
    Public sVergiDairesi As String = ""
    Public sVergiNo As String = ""
    Public fisNO As String = ""
    Public sinifBilgi2 As String = ""
    Public otomatikEkle As Boolean = False
    Dim e_nMusteriID
    Dim e_sAdi
    Dim e_sSoyadi
    Dim e_sAdres1 = ""
    Dim e_sAdres2 = ""
    Dim sAraKriter As String = ""
    Dim dr As DataRow
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    'Dim qr_hareket As New TfrxADOQuery
    'Dim qr_baslik As New TfrxADOQuery
    'Dim qr_toplam As New TfrxADOQuery
    'Dim qr_pesinat As New TfrxADOQuery
    'Dim qr_taksit As New TfrxADOQuery
    'Dim qr_kalan As New TfrxADOQuery
    'Dim qr_AVHediyeCeki As New TfrxADOQuery
    'Dim qr_KalanPuan As New TfrxADOQuery
    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    Dim dr_toplam As DataRow
    Dim dr_param As DataRow
    Dim ds_stok As DataSet
    Dim ds_stok_fisi As DataSet
    Dim ds_stok_barkod As DataSet
    Dim ds_stok_sinif As DataSet
    Dim ds_firma As DataSet
    Dim ds_renk As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_satici As DataSet
    Dim ds_alislar As DataSet
    Dim ds_alislar_kdv As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_satir_firma As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim ds_tbSatici As DataSet
    Dim yuklendi As Boolean = False
    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Public sFiyatTipi As String = ""
    'Dim sSaticiRumuzu = ""
    Dim sOdemeKodu = ""
    Dim nMaxTaksitSayisi As Integer = 1
    Dim bkapat As Boolean = False
    Public bYeniFis As Boolean = False
    Public bFisYenimi As Boolean = False
    Dim info As Boolean = True
    Dim mevcut As Decimal = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Dim sFiyat1DovizCinsi As String = ""
    Dim sFiyat1DovizKuru As String = ""
    Dim sFiyat2DovizKuru As String = ""
    Dim sFiyat3DovizKuru As String = ""
    Dim sFiyatADovizKuru As String = ""
    Dim sFiyatMDovizKuru As String = ""
    Dim sFiyat2DovizCinsi As String = ""
    Dim sFiyat3DovizCinsi As String = ""
    Dim sFiyatADovizCinsi As String = ""
    Dim sFiyatMDovizCinsi As String = ""
    Dim bCalcVadeDagilim As Boolean = False
    Public bIptalYapabilirmi As Boolean = False
    Public bVadeFarksizOdemeAlirmi As Boolean = False
    Public nMaxIskontoYuzdesi As Decimal = 100
    'Kapatma tanımları
    Public lNetTutar As Decimal = 0
    Dim lKalanTutar As Decimal = 0
    Dim lTaksitTutari As Decimal = 0
    Dim Pesinat As Decimal = 0
    Dim Taksit_tutari As Decimal = 0
    Dim taksit_sayisi As Int64 = 0
    Dim pesinat_sayisi As Int64 = 0
    Dim lOdenen As Decimal = 0
    Dim lVeresiye As Decimal = 0
    Dim lParaUstu As Decimal = 0
    Dim ds_taksit_info As DataSet
    Dim ds_tbDoviz As DataSet
    Dim nOdemeKodu = 1
    Dim lMakbuzNo = 0
    Public fatTarih
    'Dim bOtomatikTaksit As Boolean = False
    'Dim bOtomatikPesinatDuzelt As Boolean = False
    'Dim nTaksitGun As Integer = 0
    'Dim nTaksitBaslangic As Integer = 0
    'Dim nTaksitSayi As Integer = 0
    'Public sListIade As New ListBox
    Dim ds_tbParamAlisVeris As DataSet
    'Dim MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    'Dim MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    'rowDipIskonto.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {MultiEditorRowProperties1, MultiEditorRowProperties2})
    Dim bKilitli As Boolean = False
    Dim bEnter As Boolean = False
    Dim bOtomatikEnter As Boolean = False
    Dim bDirektYazdirTermal As Boolean = False
    'Dim w32prn As New Win32PrintClass()
    Dim ilkSor As Boolean = True
    Dim fiyatTipiZorunlumu As Boolean = False
    Dim belgeIptalOldu As Boolean = False
    Public perakendeFaturalama As Boolean = False
    Private KolaysoftCompanyId As String = ""
    Private Sub frm_stok_pesin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If yuklendi = True Then
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Private Function fiyatTipi_Kontrol() As Boolean
        Dim fiyatTipiBos As Boolean = False
        If fiyatTipiZorunlumu = True Then
            For Each dr In ds_hareket.Tables(0).Rows
                Try
                    If IsDBNull(dr("sFiyatTipi")) = False Then
                        If Trim(dr("sFiyatTipi")) = "" Then
                            fiyatTipiBos = True
                        End If
                    Else
                        fiyatTipiBos = True
                    End If
                Catch ex As Exception
                End Try
            Next
        End If
        Return fiyatTipiBos
    End Function
    Private Sub frm_stok_pesin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If GridView1.RowCount = 0 Then
                If otomatikEkle = True Then
                    bkapat = True
                    bKilitli = True
                    Me.Close()
                Else
                    If XtraMessageBox.Show(Sorgu_sDil("Boş Belge Kaydedemezsiniz..." & "Belgeyi İptal Etmek İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        tbAlisVeris_kaydet_sil()
                        belgeIptalOldu = True
                    Else
                        bkapat = True
                        bKilitli = True
                        Me.Close()
                    End If
                End If
            Else
                If belgeIptalOldu = False Then
                    If Trim(sDatabaseGenel) = "UGURLU" Then
                        If IsDBNull(dr_baslik("Sinif2")) = False Then
                            If Trim(dr_baslik("Sinif2")) = "" Then
                                If sinif2Bakma = False Then
                                    XtraMessageBox.Show(Sorgu_sDil("Müşteri Sınıf 2 alanını boş geçemezsiniz!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    e.Cancel = True
                                End If
                            Else
                                If fiyatTipi_Kontrol() = True Then
                                    XtraMessageBox.Show(Sorgu_sDil("Fiyat Tipi alanını boş geçemezsiniz!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    e.Cancel = True
                                Else
                                    If ilkSor = False Then
                                        Try
                                            tbFisKilit_sil(nAlisVerisID, sFisTipi, kullanici)
                                        Catch ex As Exception
                                        End Try
                                        Try
                                            sonKullaniciUpdate()
                                        Catch ex As Exception
                                        End Try
                                        If bKilitli = False Then
                                            If fis_kontrolleri() = True Then
                                                Try
                                                    toplam_hesapla()
                                                Catch ex As Exception
                                                End Try
                                                Try
                                                    If bCalcVadeDagilim = True Then
                                                        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                                                            tbAlisVerisSiparis_sOdemeKodu_kaydet_degistir(dr("nAlisVerisID"), sorgu_Kapatma_lSayi(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)))
                                                        Else
                                                            tbStokFisidetay_sOdemeKodu_kaydet_degistir(dr("nAlisVerisID"), sorgu_Kapatma_lSayi(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)))
                                                        End If
                                                    End If
                                                Catch ex As Exception
                                                End Try
                                                Try
                                                    tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), 0)
                                                Catch ex As Exception
                                                End Try
                                                If bkapat = False Then
                                                    If FormatNumber(sorgu_sayi(dr_toplam("lNetTutar"), 0), 2) <> FormatNumber(sorgu_Kapatma_lTutari(dr_baslik("nAlisVerisID").ToString, sorgu_sayi(dr_toplam("lNetTutar"), 0)), 2) Then
                                                        e.Cancel = True
                                                        If XtraMessageBox.Show(Sorgu_sDil("Satış Tutarı ile Kapatma Tutarının Aynı Olması Gerekmektedir." & vbCrLf & "Şimdi Satış Kapatması Yapmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                                            If dr_toplam("lNetTutar") > 0 Then
                                                                analiz_satis_kapatma_detayi()
                                                            ElseIf dr_toplam("lNetTutar") < 0 Then
                                                                analiz_satis_kapatma_iade()
                                                            ElseIf dr_toplam("lNetTutar") = 0 Then
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            Else
                                                e.Cancel = True
                                            End If
                                        End If
                                        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("Pesin").SetValue("Kriter", sec_kriter.Text)
                                    Else
                                        XtraMessageBox.Show(Sorgu_sDil("Müşteri Sınıf 2 alanını boş geçemezsiniz!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        e.Cancel = True
                                    End If
                                End If
                            End If
                        ElseIf IsDBNull(dr_baslik("Sinif2")) = True Then
                            If sinif2Bakma = False Then
                                XtraMessageBox.Show(Sorgu_sDil("Müşteri Sınıf 2 alanını boş geçemezsiniz!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                e.Cancel = True
                            End If
                        End If
                    Else
                        If fiyatTipi_Kontrol() = True Then
                            XtraMessageBox.Show(Sorgu_sDil("Fiyat Tipi alanını boş geçemezsiniz!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            e.Cancel = True
                        Else
                            Try
                                tbFisKilit_sil(nAlisVerisID, sFisTipi, kullanici)
                            Catch ex As Exception
                            End Try
                            Try
                                sonKullaniciUpdate()
                            Catch ex As Exception
                            End Try
                            If bKilitli = False Then
                                If fis_kontrolleri() = True Then
                                    Try
                                        toplam_hesapla()
                                    Catch ex As Exception
                                    End Try
                                    Try
                                        If bCalcVadeDagilim = True Then
                                            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                                                tbAlisVerisSiparis_sOdemeKodu_kaydet_degistir(dr("nAlisVerisID"), sorgu_Kapatma_lSayi(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)))
                                            Else
                                                tbStokFisidetay_sOdemeKodu_kaydet_degistir(dr("nAlisVerisID"), sorgu_Kapatma_lSayi(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)))
                                            End If
                                        End If
                                    Catch ex As Exception
                                    End Try
                                    Try
                                        tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), 0)
                                    Catch ex As Exception
                                    End Try
                                    If bkapat = False Then
                                        If FormatNumber(sorgu_sayi(dr_toplam("lNetTutar"), 0), 2) <> FormatNumber(sorgu_Kapatma_lTutari(dr_baslik("nAlisVerisID").ToString, sorgu_sayi(dr_toplam("lNetTutar"), 0)), 2) Then
                                            e.Cancel = True
                                            If otomatikEkle = True Then
                                                If dr_toplam("lNetTutar") > 0 Then
                                                    analiz_satis_kapatma_detayi()
                                                ElseIf dr_toplam("lNetTutar") < 0 Then
                                                    analiz_satis_kapatma_iade()
                                                ElseIf dr_toplam("lNetTutar") = 0 Then
                                                End If
                                                btn_ekle.PerformClick()
                                                Me.Close()
                                            Else
                                                If XtraMessageBox.Show(Sorgu_sDil("Satış Tutarı ile Kapatma Tutarının Aynı Olması Gerekmektedir." & vbCrLf & "Şimdi Satış Kapatması Yapmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                                    If dr_toplam("lNetTutar") > 0 Then
                                                        analiz_satis_kapatma_detayi()
                                                    ElseIf dr_toplam("lNetTutar") < 0 Then
                                                        analiz_satis_kapatma_iade()
                                                    ElseIf dr_toplam("lNetTutar") = 0 Then
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    e.Cancel = True
                                End If
                            End If
                            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("Pesin").SetValue("Kriter", sec_kriter.Text)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

        Dim nAlisveris As String = ""

        If dr IsNot Nothing AndAlso Not IsDBNull(dr("nAlisVerisID")) Then
            nAlisveris = Convert.ToString(dr("nAlisVerisID"))

            ' Muhasebeye işlendi mi kontrolü
            Dim Muhasebe As Boolean = False
            Dim dtAlisveris As DataTable = SQLCalistir(
                "SELECT ISNULL(bMuhasebeyeIslendimi,0) AS bMuh FROM tbAlisveris WHERE nAlisverisID = '" & nAlisveris & "'")

            If dtAlisveris IsNot Nothing AndAlso dtAlisveris.Rows.Count > 0 Then
                Dim r As DataRow = dtAlisveris.Rows(0)
                If r.RowState <> DataRowState.Deleted AndAlso r.RowState <> DataRowState.Detached Then
                    Muhasebe = Convert.ToBoolean(If(IsDBNull(r("bMuh")), 0, r("bMuh")))
                End If
            End If

            ' Parametre kontrolü
            Dim PosEntegre As Boolean = False
            Dim dtParam As DataTable = SQLCalistir("SELECT ISNULL(PosEntegre,0) AS PosEntegre FROM tbParamGenel")

            If dtParam IsNot Nothing AndAlso dtParam.Rows.Count > 0 Then
                Dim p As DataRow = dtParam.Rows(0)
                If p.RowState <> DataRowState.Deleted AndAlso p.RowState <> DataRowState.Detached Then
                    PosEntegre = Convert.ToBoolean(If(IsDBNull(p("PosEntegre")), 0, p("PosEntegre")))
                End If
            End If

            ' Gönderim
            If PosEntegre AndAlso Not Muhasebe Then
                SatisiKolaysoftaGonder(nAlisveris)
            End If
        End If

    End Sub
    Private Sub frm_stok_pesin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If bPerYerelMuh = True Then
            connection_resmi = connection
        Else
            connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        End If
        Try
            bDirektYazdirTermal = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bDirektYazdirTermal").ToString
        Catch ex As Exception
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bDirektYazdirTermal", bDirektYazdirTermal)
            bDirektYazdirTermal = False
        End Try
        If bDirektYazdirTermal = True Then
            btn_DirekYazdirTermal.Down = True
            'w32prn.SetPrinterName("FIS")
        End If
        Try
            bOtomatikEnter = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bOtomatikEnter").ToString
        Catch ex As Exception
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bOtomatikEnter", bOtomatikEnter)
            bOtomatikEnter = False
        End Try
        If bOtomatikEnter = True Then
            btn_OtomatikEnter.Down = True
        End If
        'Try
        'Catch ex As Exception
        '    bCalcVadeDagilim = False
        'End Try
        Try
            sec_kriter.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("Perakende").OpenSubKey("Pesin").GetValue("Kriter").ToString
        Catch ex As Exception
            sec_kriter.Text = "Başlar"
        End Try
        e_nMusteriID = nMusteriID
        e_sAdi = sAdi
        e_sSoyadi = sSoyadi
        e_sAdres1 = sAdres1
        e_sAdres2 = sAdres2
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        yuklendi = True
        satir_info()
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            coldteTeslimEdilecek.Visible = True
            colsMagazaKodu.FieldName = "sMagazaKodu"
        Else
            colsMagazaKodu.FieldName = "sDepo"
            coldteTeslimEdilecek.Visible = False
        End If
        If Trim(nIslemID) <> 0 Then
            GridView1.Columns("nIslemID").FilterInfo = New ColumnFilterInfo("[nIslemID] LIKE '" & nIslemID & "%'")
        End If
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.ClearColumnsFilter()
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
        'Try
        'Catch ex As Exception
        '    bOtomatikTaksit = False
        'End Try
        'Try
        'Catch ex As Exception
        '    bOtomatikPesinatDuzelt = False
        'End Try
        If sDatabaseGenel = "UGURLU" Then
            If sinif2Bakma = False Then
                If (Trim(sFisTipi) = "K") Or (Trim(sFisTipi) = "P") Or (Trim(sFisTipi) = "SP") Or (Trim(sFisTipi) = "SK") Then
                    rowSinif2.Enabled = True
                    sec_Sinif2.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbMSinif2")).Tables(0)
                    dr_baslik("Sinif2") = sinifBilgi2
                    ilkSor = True
                End If
            End If
        End If
        Try
            taksit_ilkTarih_Hesapla()
        Catch ex As Exception
            taksit_ilkTarih_Hesapla2()
        End Try
        If sListIade.Items.Count > 0 Then
            Dim drs
            For Each drs In sListIade.Items
                txt_ara.Text = drs
                stok_ara()
            Next
        End If
        If bKilitli = True Then
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsBehavior.ReadOnly = True
            rowdteFaturaTarihi.Properties.ReadOnly = True
            rowlFaturaNo.Properties.ReadOnly = True
            PanelEkle.Enabled = False
            btn_SatirEkle.Enabled = False
            btn_SatirSil.Enabled = False
            btn_EtiketTuslariGoster.Enabled = False
            btn_FisSil.Enabled = False
            btn_FisYeni.Enabled = False
            btn_FiyatTipiBelirle.Enabled = False
            btn_MiktarHesapla.Enabled = False
            'btn_musteriaktar.Enabled = False
            btn_MusteriSec.Enabled = False
            btn_SatirDuzelt.Enabled = False
            btn_AltFisSil.Enabled = False
            btn_AltFisYeni.Enabled = False
            btn_AltMusteriYeni.Enabled = False
            btn_AltMusteriSec.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            btn_AltToplamlar.Enabled = False
            btn_AltYuvarla.Enabled = False
            GroupControl_Pesinat.Enabled = False
            GroupControl_Pesinat.ContextMenu = Nothing
            GroupControl_Taksit.Enabled = False
            GroupControl_Taksit.ContextMenu = Nothing
            'btn_DovizCinsiBelirle.Enabled = False
            btn_SaticiBelirle.Enabled = False
            btn_FiyatTipiBelirle.Enabled = False
            btn_FisSil.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            GridControl1.ContextMenu = Nothing
            VGrid_toplam.OptionsBehavior.Editable = False
            'Me.Text = Me.Text + Sorgu_sDil("( Salt Okunur )", sDil)
            If bKilitli = True Then
                Me.Text = Me.Text + Sorgu_sDil("( Belge Kullanımda )", sDil)
            End If
        End If
        If bKopya = True Then
            Me.Text = Me.Text + "#Kopya"
        End If
        Try
            If otomatikEkle = True Then
                'MessageBox.Show("lNetTutar: " & dr_toplam("lNetTutar").ToString() & "lKalanTutar: " & lKalanTutar.ToString())
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("HATA")
        End Try

    End Sub
    Private Sub taksit_ilkTarih_Hesapla2()
        'Try
        'Catch ex As Exception
        '    nTaksitGun = 0
        'End Try
        'Try
        'Catch ex As Exception
        '    nTaksitBaslangic = 0
        'End Try
        ''Satış Kapatma
        'Try
        'Catch ex As Exception
        '    nTaksitSayi = 0
        'End Try
        Dim sGun As Int64 = nTaksitBaslangic
        Dim sAy As Int64 = Now.Month.ToString
        Dim sYil As Int64 = Now.Year
        Dim dteIlkTaksitTarihi As DateTime
        If nTaksitBaslangic <> 0 Then
            sGun = nTaksitBaslangic
            sAy = Now.Month.ToString
            sYil = Now.Year
            If Now.Month = 12 Then
                sYil = Now.Year + 1
                sAy = "01"
            Else
                sAy = (Now.Month + 1).ToString
            End If
            dteIlkTaksitTarihi = sGun.ToString + "/" + sAy.ToString + "/" + sYil.ToString
            dteIlkTaksit.Text = dteIlkTaksitTarihi
        Else
            dteIlkTaksitTarihi = dteSistemTarihi
            Try
                dteIlkTaksit.Value = dteIlkTaksitTarihi
            Catch ex As Exception
                dteIlkTaksit.Value = dteFisTarihi
            End Try
        End If
    End Sub
    Private Sub taksit_ilkTarih_Hesapla()
        'Try
        'Catch ex As Exception
        '    nTaksitGun = 0
        'End Try
        'Try
        'Catch ex As Exception
        '    nTaksitBaslangic = 0
        'End Try
        ''Satış Kapatma
        'Try
        'Catch ex As Exception
        '    nTaksitSayi = 0
        'End Try
        Dim sGun As Int64 = nTaksitBaslangic
        Dim sAy As Int64 = Now.Month.ToString
        Dim sYil As Int64 = Now.Year
        Dim dteIlkTaksitTarihi = dteSistemTarihi
        If nTaksitBaslangic <> 0 Then
            sGun = nTaksitBaslangic
            sAy = Now.Month.ToString
            sYil = Now.Year
            If Now.Month = 12 Then
                sYil = Now.Year + 1
                sAy = "01"
            Else
                sAy = (Now.Month + 1).ToString
            End If
            dteIlkTaksitTarihi = sGun.ToString + "/" + sAy.ToString + "/" + sYil.ToString
            dteIlkTaksit.Text = dteIlkTaksitTarihi
        Else
            dteIlkTaksitTarihi = dteSistemTarihi
            dteIlkTaksit.Text = dteIlkTaksitTarihi
        End If
        sGun = dr_baslik("dteFaturaTarihi").day.ToString
        sAy = dr_baslik("dteFaturaTarihi").month.ToString
        sYil = dr_baslik("dteFaturaTarihi").year.ToString
        If sGun <= dr_param("nAlisGun1") Then
            If dr_param("nOdemeGun1") <> 0 And dr_param("nOdemeTipi1") <> 0 Then
                If dr_param("nOdemeTipi1") = 0 Then
                    sAy += 1
                    If sAy > 12 Then
                        sAy = sAy - 12
                    End If
                    dteIlkTaksitTarihi = sGun.ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi1") = 1 Then
                    sAy += 1
                    If sAy = 13 Then
                        sAy = 1
                    End If
                    dteIlkTaksitTarihi = dr_param("nOdemeGun1").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi1") = 2 Then
                    sAy += 2
                    If sAy > 12 Then
                        sAy = sAy - 12
                    End If
                    dteIlkTaksitTarihi = dr_param("nOdemeGun1").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                ElseIf dr_param("nOdemeTipi1") = 3 Then
                    dteIlkTaksitTarihi = dr_param("nOdemeGun1").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                End If
            Else
                dteIlkTaksitTarihi = dteSistemTarihi
                dteIlkTaksit.Text = dteIlkTaksitTarihi
            End If
        ElseIf sGun > dr_param("nAlisGun1") And sGun <= dr_param("nAlisGun2") Then
            If dr_param("nOdemeGun2") <> 0 And dr_param("nOdemeTipi2") <> 0 Then
                If dr_param("nOdemeTipi2") = 0 Then
                    sAy += 1
                    If sAy > 12 Then
                        sAy = sAy - 12
                    End If
                    dteIlkTaksitTarihi = sGun.ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi2") = 1 Then
                    sAy += 1
                    If sAy = 13 Then
                        sAy = 1
                    End If
                    dteIlkTaksitTarihi = dr_param("nOdemeGun2").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi2") = 2 Then
                    sAy += 2
                    If sAy > 12 Then
                        sAy = sAy - 12
                    End If
                    dteIlkTaksitTarihi = dr_param("nOdemeGun2").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi1") = 3 Then
                    dteIlkTaksitTarihi = dr_param("nOdemeGun2").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                End If
            Else
                dteIlkTaksitTarihi = dteSistemTarihi
                dteIlkTaksit.Text = dteIlkTaksitTarihi
            End If
        ElseIf sGun > dr_param("nAlisGun2") And sGun <= dr_param("nAlisGun3") Then
            If dr_param("nOdemeGun3") <> 0 And dr_param("nOdemeTipi3") <> 0 Then
                If dr_param("nOdemeTipi3") = 0 Then
                    sAy += 1
                    If sAy > 12 Then
                        sAy = sAy - 12
                    End If
                    dteIlkTaksitTarihi = sGun.ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi3") = 1 Then
                    sAy += 1
                    If sAy = 13 Then
                        sAy = 1
                    End If
                    dteIlkTaksitTarihi = dr_param("nOdemeGun3").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi3") = 2 Then
                    sAy += 2
                    If sAy > 12 Then
                        sAy = sAy - 12
                    End If
                    dteIlkTaksitTarihi = dr_param("nOdemeGun3").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                ElseIf dr_param("nOdemeTipi3") = 3 Then
                    dteIlkTaksitTarihi = dr_param("nOdemeGun3").ToString + "/" + sAy.ToString + "/" + sYil.ToString
                    dteIlkTaksit.Text = dteIlkTaksitTarihi
                End If
            Else
                dteIlkTaksitTarihi = dteSistemTarihi
                dteIlkTaksit.Text = dteIlkTaksitTarihi
            End If
        Else
            dteIlkTaksitTarihi = dteSistemTarihi
            dteIlkTaksit.Text = dteIlkTaksitTarihi
        End If
        If nTaksitSayi <> 0 Then
            txt_sayi.EditValue = nTaksitSayi
        Else
            txt_sayi.EditValue = 1
        End If
        txt_tutar.EditValue = 0
    End Sub
    Private Sub dataload_tbParamAlisVeris()
        ds_tbParamAlisVeris = sorgu("Select * from tbParamAlisVeris Where sMagazaKodu='" & dr_baslik("sMagaza") & "' ")
        dr_param = ds_tbParamAlisVeris.Tables(0).Rows(0)
        If Trim(dr_baslik("sFisTipi")) = "K" Or Trim(dr_baslik("sFisTipi")) = "SK" Then
            sFiyatTipi = dr_param("sDefaultKrediFiyatTipi")
        ElseIf Trim(dr_baslik("sFisTipi")) = "P" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            sFiyatTipi = dr_param("sDefaultPesinFiyatTipi")
        End If
        fiyatTipiZorunlumu = dr_param("bFiyatTipiZorunlumu")
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If kullanici > 3 Then
            If dr_param("bMalBazindaOdemePlaniVarmi") = False Then
                colsOdemeKodu.Visible = False
                colsOdemeKodu.OptionsColumn.ReadOnly = True
                colsOdemeKodu.OptionsColumn.ShowInCustomizationForm = False
            Else
                If dr_param("bOdemePlaniDegistirilsinmi") = True Then
                    colsOdemeKodu.OptionsColumn.ReadOnly = False
                Else
                    colsOdemeKodu.OptionsColumn.ReadOnly = True
                    colsOdemeKodu.OptionsColumn.ShowInCustomizationForm = True
                End If
            End If
            If dr_param("bReyonFisnoVarmi") = False Then
                collReyonFisNo.Visible = False
                collReyonFisNo.OptionsColumn.ReadOnly = True
                collReyonFisNo.OptionsColumn.ShowInCustomizationForm = False
            End If
            If dr_param("bMiktarDegistirilsinmi") = True Then
                collGCMiktar.OptionsColumn.ReadOnly = False
            Else
                collGCMiktar.OptionsColumn.ReadOnly = True
            End If
            If dr_param("bDovizliGirisVar") = False Then
                colsDovizCinsi.Visible = False
                colsDovizCinsi.OptionsColumn.ReadOnly = True
            End If
            If dr_param("bKrediKartNoSorsun") = False Then
                colsKartNo.Visible = False
                colsKartNo.OptionsColumn.ShowInCustomizationForm = False
            End If
            If dr_param("bPartiVar") = False Then
                colnPartiID.Visible = False
                colnPartiID.OptionsColumn.ReadOnly = True
                colnPartiID.OptionsColumn.ShowInCustomizationForm = False
            End If
            If dr_param("bTarihDegistirilebilsinmi") = False Then
                rowdteFaturaTarihi.Properties.ReadOnly = True
            End If
            If dr_param("bEskilerIptalEdilsinmi") = False Then
                btn_AltFisSil.Enabled = False
                btn_FisSil.Enabled = False
            End If
            If dr_param("bMusteriNotuSatisaGelsin") = False Then
                rowISTIHBARAT.Visible = False
            End If
            If Trim(dr_baslik("sFisTipi")) = "K" Or Trim(dr_baslik("sFisTipi")) = "SK" Then
                sFiyatTipi = dr_param("sDefaultKrediFiyatTipi")
                If dr_param("bKFiyatTipiDegistrilsinmi") = False Then
                    sec_sFiyatTipi.ReadOnly = True
                End If
                If dr_param("bKFiyatDegistirilsinmi") = False Then
                    collBrutFiyat.OptionsColumn.ReadOnly = True
                    collBrutFiyat.OptionsColumn.AllowEdit = False
                    collBrutTutar.OptionsColumn.ReadOnly = True
                    collBrutFiyat.OptionsColumn.AllowEdit = False
                Else
                    collBrutFiyat.OptionsColumn.ReadOnly = False
                    collBrutFiyat.OptionsColumn.AllowEdit = True
                    collBrutTutar.OptionsColumn.ReadOnly = False
                    collBrutFiyat.OptionsColumn.AllowEdit = True
                End If
                If dr_param("bKrediMalIskontoVarmi") = False Then
                    colnIskontoYuzdesi.OptionsColumn.ReadOnly = True
                    colnIskontoYuzdesi.OptionsColumn.AllowEdit = False
                    collIskontoTutari.OptionsColumn.ReadOnly = True
                    collIskontoTutari.OptionsColumn.AllowEdit = False
                End If
                If dr_param("bKrediDipIskontoVarmi") = False Then
                    rowDipIskonto.Properties.ReadOnly = True
                    rowDipIskonto.Enabled = False
                    sec_lDipIskonto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
                End If
            ElseIf Trim(dr_baslik("sFisTipi")) = "P" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                sFiyatTipi = dr_param("sDefaultPesinFiyatTipi")
                If dr_param("bPFiyatTipiDegistrilsinmi") = False Then
                    sec_sFiyatTipi.ReadOnly = True
                End If
                If dr_param("bPFiyatDegistirilsinmi") = False Then
                    collBrutFiyat.OptionsColumn.ReadOnly = True
                    collBrutFiyat.OptionsColumn.AllowEdit = False
                    collBrutTutar.OptionsColumn.ReadOnly = True
                    collBrutFiyat.OptionsColumn.AllowEdit = False
                Else
                    collBrutFiyat.OptionsColumn.ReadOnly = False
                    collBrutFiyat.OptionsColumn.AllowEdit = True
                    collBrutTutar.OptionsColumn.ReadOnly = False
                    collBrutFiyat.OptionsColumn.AllowEdit = True
                End If
                If dr_param("bPesinMalIskontoVarmi") = False Then
                    colnIskontoYuzdesi.OptionsColumn.ReadOnly = True
                    colnIskontoYuzdesi.OptionsColumn.AllowEdit = False
                    collIskontoTutari.OptionsColumn.ReadOnly = True
                    collIskontoTutari.OptionsColumn.AllowEdit = False
                End If
                If dr_param("bPesinDipIskontoVarmi") = False Then
                    rowDipIskonto.Properties.ReadOnly = True
                    rowDipIskonto.Enabled = False
                    sec_lDipIskonto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
                End If
            End If
            If dr_param("bTaksitTutDegistirilsinmi") = False Then
                collTutari.OptionsColumn.ReadOnly = True
                collTutar.OptionsColumn.AllowEdit = False
            End If
            If dr_param("bTaksitTarDegistirilsinmi") = False Then
                coldteTarihi.OptionsColumn.ReadOnly = True
                coldteTarihi.OptionsColumn.AllowEdit = False
            End If
        End If
        If Trim(dr_baslik("sEhliyetNo")) <> "" And Len(Trim(dr_baslik("sEhliyetNo"))) < 5 Then
            sFiyatTipi = dr_baslik("sEhliyetNo")
        End If
    End Sub
    Private Sub loaded(Optional ByVal renew As Boolean = False, Optional ByVal e_sFisTpi As String = "")
        Try
            If renew = True Then
                TermalYazdir_toplam()
                Try
                    tbFisKilit_sil(nAlisVerisID, sFisTipi, kullanici)
                Catch ex As Exception
                End Try
                nAlisVerisID = ""
                sFisTipi = e_sFisTpi
                nMusteriID = e_nMusteriID
                sAdi = e_sAdi
                sSoyadi = e_sSoyadi
                sAdres1 = e_sAdres1
                sAdres2 = e_sAdres2
            End If
            dataload_baslik()
            dr_baslik = ds_baslik.Tables(0).Rows(0)
            dataload_harekets()
            GridControl1.Focus()
            GridControl1.Select()
            dr_baslik = ds_baslik.Tables(0).Rows(0)
            dr_toplam = ds_toplam.Tables(0).Rows(0)
            'kontrol_oran()
            If renew = False Then
                If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "SK" Then
                    ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFiyatTipi, sAciklama FROM tbFiyatTipi Where (nAST IN(3, 6)) and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
                ElseIf Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
                    ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFiyatTipi, sAciklama FROM tbFiyatTipi Where (nAST IN (3, 7)) and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
                Else
                    ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFiyatTipi, sAciklama FROM tbFiyatTipi Where (nAST = 3) and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
                End If
                'ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFiyatTipi, sAciklama FROM tbFiyatTipi Where nAST = 3"))
                ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * from tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
                sec_sFiyatTipi.DataSource = ds_fiyattipi.Tables(0)
                ds_nGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nGirisCikis, sAciklama FROM tbGirisCikis Where nGirisCikis IN ('3', '4')"))
                sec_nGirisCikis.DataSource = ds_nGirisCikis.Tables(0)
                dataload_satici()
                If GridView1.RowCount = 0 Then
                    dataload_odemekodu(sFiyatTipi)
                Else
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    dataload_odemekodu(dr("sFiyatTipi"))
                End If
                dataload_tbDovizCinsi()
            End If
            Try
                sSaticiRumuzu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sSaticiRumuzu").ToString
            Catch ex As Exception
                sSaticiRumuzu = ""
            End Try
            Try
                'Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
                If Trim(sFisTipi) = "K" Then
                    Me.Text = "Kredili Satış"
                    'Me.LookAndFeel.UseDefaultLookAndFeel = True
                    'Me.LookAndFeel.UseWindowsXPTheme = True
                    'Bar_DisGorunum.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                ElseIf Trim(sFisTipi) = "P" Then
                    'Bar_DisGorunum.Enabled = True
                    'Bar_DisGorunum.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Me.Text = "Peşin Satış"
                    'sFiyatTipi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sPesinFiyatTipi").ToString
                    'pesin_gorunum()
                ElseIf Trim(sFisTipi) = "SK" Then
                    Me.Text = "Sonradan Teslim Kredili Satış"
                ElseIf Trim(sFisTipi) = "SP" Then
                    Me.Text = "Sonradan Teslim Peşin Satış"
                End If
            Catch ex As Exception
            End Try
            If aktarim = True Then
                toplam_hesapla()
            End If
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
            If bYeniFis = False Then
                lbl_Yekun.Text = FormatNumber(dr_toplam("lNetTutar"), 2)
            End If
            baslik_text_kontrol()
            Try
                dataload_tbParamAlisVeris()
            Catch ex As Exception
            End Try
            Dim drs As DataRow
            For Each drs In ds_tbFiyatTipi.Tables(0).Rows
                If drs("sFiyatTipi") = sFiyat1 Then
                    sFiyat1DovizCinsi = drs("sDovizCinsi")
                    sFiyat1DovizKuru = drs("sHangiKur")
                ElseIf drs("sFiyatTipi") = sFiyat2 Then
                    sFiyat2DovizCinsi = drs("sDovizCinsi")
                    sFiyat2DovizKuru = drs("sHangiKur")
                ElseIf drs("sFiyatTipi") = sFiyat3 Then
                    sFiyat3DovizCinsi = drs("sDovizCinsi")
                    sFiyat3DovizKuru = drs("sHangiKur")
                ElseIf drs("sFiyatTipi") = sFiyatA Then
                    sFiyatADovizCinsi = drs("sDovizCinsi")
                    sFiyatADovizKuru = drs("sHangiKur")
                ElseIf drs("sFiyatTipi") = sFiyatM Then
                    sFiyatMDovizCinsi = drs("sDovizCinsi")
                    sFiyatMDovizKuru = drs("sHangiKur")
                End If
            Next
        Catch ex As Exception
        End Try
        yuklendi = True
    End Sub
    Private Sub pesin_gorunum()
        'Try
        '    Dim style = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STYLE").GetValue("sPesinSTYLE").ToString
        '    Dim skin = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STYLE").GetValue("sPesinSKIN").ToString
        '    If style = "Flat" Then
        '        LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        '        LookAndFeel.SkinName = skin
        '    ElseIf style = "UltraFlat" Then
        '        LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        '        LookAndFeel.SkinName = skin
        '    ElseIf style = "Style3D" Then
        '        LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        '        LookAndFeel.SkinName = skin
        '    ElseIf style = "Skin" Then
        '        LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        '        LookAndFeel.SkinName = skin
        '    ElseIf style = "Office2003" Then
        '        LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        '        LookAndFeel.SkinName = skin
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub gorunum_degistir(ByVal style As String)
        If style = "Flat" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        ElseIf style = "Ultra Flat" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        ElseIf style = "Style 3D" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        ElseIf style = "Office 2003" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        ElseIf style = "Caramel" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
            LookAndFeel.SkinName = "Caramel"
        ElseIf style = "Office 2007 Black" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
            LookAndFeel.SkinName = "Office 2007 Black"
        ElseIf style = "Office 2007 Blue" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
            LookAndFeel.SkinName = "Office 2007 Blue"
        ElseIf style = "Office 2007 Silver" Then
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
            LookAndFeel.SkinName = "Office 2007 Silver"
        Else
            LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
            LookAndFeel.SkinName = style
        End If
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STYLE").SetValue("sPesinSTYLE", LookAndFeel.Style.ToString)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STYLE").SetValue("sPesinSKIN", LookAndFeel.SkinName.ToString)
    End Sub
    Private Sub yeni_fis(ByVal e_sFisTipi As String)
        If KayitSiniri_kontrol("tbAlisVeris", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True And fis_kontrolleri() = True Then
            Try
                toplam_hesapla()
            Catch ex As Exception
            End Try
            Try
                If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), 0)
                Else
                    tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), 0)
                End If
            Catch ex As Exception
            End Try
            If bkapat = False Then
                If GridView1.RowCount = 0 Then
                    Try
                        tbAlisVeris_kaydet_sil()
                    Catch ex As Exception
                    End Try
                    Try
                        loaded(True, e_sFisTipi)
                    Catch ex As Exception
                    End Try
                Else
                    If FormatNumber(dr_toplam("lNetTutar"), 2) <> FormatNumber(sorgu_Kapatma_lTutari(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)), 2) Then
                        If dr_toplam("lNetTutar") > 0 Then
                            bYeniFis = True
                            Try
                                analiz_satis_kapatma_detayi()
                            Catch ex As Exception
                            End Try
                        ElseIf dr_toplam("lNetTutar") < 0 Then
                            Try
                                analiz_satis_kapatma_iade()
                            Catch ex As Exception
                            End Try
                        Else
                            If yeni_fis_kontrol() = True Then
                                Try
                                    loaded(True, e_sFisTipi)
                                Catch ex As Exception
                                End Try
                            End If
                        End If
                    Else
                        Try
                            loaded(True, e_sFisTipi)
                        Catch ex As Exception
                        End Try
                    End If
                End If
            End If
        End If

    End Sub
    Private Function fis_kontrolleri() As Boolean
        Dim pass As Boolean = False
        Dim bCikisIptal As Integer = -1
        Try
            If dr_param("bSaticiRumuzuVarmi") = True Then
                Dim drs As DataRow
                Dim sayi As Integer = -1
                For Each drs In ds_hareket.Tables(0).Rows
                    sayi += 1
                    If Trim(drs("sSaticiRumuzu")) = "" And bCikisIptal = -1 Then
                        bCikisIptal = sayi
                    End If
                Next
                drs = Nothing
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        Try
            If dr_param("bLimitAsimiIzinlimi") = False Then
                Dim ds_TaksitKalan As DataSet
                ds_TaksitKalan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi "), "KalanTaksit")
                Dim drk As DataRow
                Dim lBakiye As Decimal = 0
                For Each drk In ds_TaksitKalan.Tables(0).Rows
                    lBakiye += drk("KALAN")
                Next
                If lBakiye > dr_baslik("lKrediLimiti") And dr_baslik("lKrediLimiti") > 0 Then
                    bCikisIptal = -2
                End If
                lBakiye = Nothing
                drk = Nothing
                ds_TaksitKalan = Nothing
            End If
        Catch ex As Exception
        End Try
        If bCikisIptal >= 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Fişte Satıcı Bilgisini Boş Bırakamazsınız...!" & vbCrLf & "Lütfen Satıcı Bilgilerini Doldurunuz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.FocusedColumn = colsSaticiRumuzu
            GridView1.FocusedRowHandle = bCikisIptal
            GridView1.ClearSelection()
            GridView1.SelectRow(bCikisIptal)
        ElseIf bCikisIptal = -2 Then
            XtraMessageBox.Show(Sorgu_sDil("Müşteri Kredi Limitini Aşamazsınız..." & vbCrLf & "Lütfen Sistem Yöneticinizle Görüşün!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf bCikisIptal = -1 Then
            pass = True
        End If
        Return pass
    End Function
    Private Function kapatma_kontrol() As Boolean
        Dim pass As Boolean = False
        Try
            toplam_hesapla()
        Catch ex As Exception
        End Try
        If bkapat = False Then
            If GridView1.RowCount = 0 Then
                pass = True
            Else
                If FormatNumber(dr_toplam("lNetTutar"), 2) <> FormatNumber(sorgu_Kapatma_lTutari(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)), 2) Then
                    If dr_toplam("lNetTutar") > 0 Then
                        analiz_satis_kapatma_detayi()
                    ElseIf dr_toplam("lNetTutar") < 0 Then
                        analiz_satis_kapatma_iade()
                    End If
                    If yeni_fis_kontrol() = True Then
                        pass = True
                    End If
                Else
                    pass = True
                End If
            End If
        End If
        Return pass
    End Function
    Private Function yeni_fis_kontrol() As Boolean
        Dim pass As Boolean
        If FormatNumber(dr_toplam("lNetTutar"), 2) <> FormatNumber(sorgu_Kapatma_lTutari(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)), 2) Then
            pass = False
            'If dr_toplam("lNetTutar") > 0 Then
            '    analiz_satis_kapatma()
            'ElseIf dr_toplam("lNetTutar") < 0 Then
            '    analiz_satis_kapatma_iade()
            'End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.bSatis = True
        frm.kullanici = kullanici
        Dim lFaturaNo As Integer = dr_baslik("lFaturaNo")
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            If Trim(dr_baslik("sFisTipi")) = "P" Then
                If XtraMessageBox.Show(Sorgu_sDil("Satışı Kredili Satışa Çevirmek İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    sFisTipi = "K "
                    dr_param = ds_tbParamAlisVeris.Tables(0).Rows(0)
                    If Trim(dr_baslik("sFisTipi")) = "K" Or Trim(dr_baslik("sFisTipi")) = "SK" Then
                        sFiyatTipi = dr_param("sDefaultKrediFiyatTipi")
                    ElseIf Trim(dr_baslik("sFisTipi")) = "P" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                        sFiyatTipi = dr_param("sDefaultPesinFiyatTipi")
                    End If
                    lFaturaNo = sorgu_lFaturaNo(dr_baslik("sMagaza"), sFisTipi)
                Else
                End If
            Else
                'lFaturaNo = sorgu_lFaturaNo(dr_baslik("sMagaza"), dr_baslik("sFisTipi"))
                lFaturaNo = dr_baslik("lFaturaNo") 'sorgu_lFaturaNo(dr_baslik("sMagaza"), dr_baslik("sFisTipi"))
            End If
            Dim pass As Boolean = tbAlisVeris_musteri_degistir(nAlisVerisID, sFisTipi, lFaturaNo, dr1("nMusteriID"), dr1("sAdi").ToString, dr1("sSoyadi").ToString)
            If pass = True Then
                dr_baslik("sFisTipi") = sFisTipi
                dr_baslik("lFaturaNo") = lFaturaNo
                dr_baslik("nMusteriID") = dr1("nMusteriID")
                dr_baslik("sAlisverisYapanAdi") = dr1("sAdi")
                dr_baslik("sAlisverisYapanSoyadi") = dr1("sSoyadi")
                dr_baslik("sAdi") = dr1("sAdi")
                dr_baslik("sSoyadi") = dr1("sSoyadi")
                dr_baslik("Musteri") = dr1("Musteri")
                'İskonto Güncelle
                If Trim("sFisTipi") = "K" Then
                    dr_toplam("nDipIskontoYuzdesi") = dr1("nIskontoKredili")
                ElseIf Trim("sFisTipi") = "P" Then
                    dr_toplam("nDipIskontoYuzdesi") = dr1("nIskontoPesin")
                End If
                If dr_toplam("nDipIskontoYuzdesi") > nMaxIskontoYuzdesi Then
                    dr_toplam("nDipIskontoYuzdesi") = nMaxIskontoYuzdesi
                End If
                toplam_hesapla()
                If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                Else
                    tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                End If
                Dim satir = GridView1.FocusedRowHandle
                dataload_harekets()
                GridView1.FocusedRowHandle = satir
                toplam_hesapla()
            End If
            pass = Nothing
            dr1 = Nothing
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub musteri_notlari()
        Dim frm As New frm_musteri_karti_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = dr_baslik("nMusteriID")
        frm.kullanici = kullanici
        frm.firma = False
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub dataload_renk()
        'sec_Renk.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_satici()
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici,nPrim  FROM         tbSatici where bAktif =1"))
        sec_sSatici.DataSource = ds_tbSatici.Tables(0)
    End Sub
    Private Sub dataload_odemekodu(Optional ByVal sFiyatTipi As String = "1")
        sec_sOdemeKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFiyatTipiOdemePlani.sOdemeKodu, tbOdemePlani.sAciklama FROM tbFiyatTipiOdemePlani INNER JOIN tbOdemePlani ON tbFiyatTipiOdemePlani.sOdemeKodu = tbOdemePlani.sOdemeKodu WHERE (tbFiyatTipiOdemePlani.sFiyatTipi = '" & sFiyatTipi & "')")).Tables(0)
        Try
            GridView1.SetFocusedRowCellValue("sOdemeKodu", sec_sOdemeKodu.GetDataSourceValue("sOdemeKodu", 0))
        Catch ex As Exception
        End Try
        'sec_sOdemeKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sOdemeKodu,sAciklama FROM tbOdemePlani ")).Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_baslik()
        If nAlisVerisID = "" Then
            nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
            lFaturaNo = sorgu_lFaturaNo(sMagaza, sFisTipi)
            sHareketTipi = sorgu_sHareketTipi(sMagaza)
            tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAdi, sSoyadi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, sHareketTipi, 0, nKasaNo, kullanici, Now, "")
            tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
            lFaturaNo_degistir(lFaturaNo, sMagaza)
            nAlisVerisID = sMagaza & nAlisVerisID.ToString
            Try
                tbFisKilit_ekle(nAlisVerisID, sFisTipi, kullanici, Now)
            Catch ex As Exception
                bKilitli = False
            End Try
            TermalYazdir_baslik()
        Else
            bDirektYazdirTermal = False
            If sorgu_nKilit(nAlisVerisID, sFisTipi, kullanici) = 0 Then
                bKilitli = False
                Try
                    tbFisKilit_ekle(nAlisVerisID, sFisTipi, kullanici, Now)
                Catch ex As Exception
                    bKilitli = True
                End Try
            Else
                bKilitli = True
            End If
        End If
        ds_baslik.Tables(0).Clear()
        Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
        If kayitsayisi = 0 Then
            tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, "", sAdres1, sAdres2, "", "", "", "", sVergiDairesi, sVergiNo, "")
        Else
        End If
        ds_baslik = sorgu_baslik("")
        ds_toplam = sorgu_toplam("")
        'Dim dr1 As DataRow
        'For Each dr1 In ds_toplam.Tables(0).Rows
        '    Try
        '        dr1("ISKONTO") = (dr1("lMalIskontoTutari") + dr1("lDipIskontoTutari3")) / dr1("lMalBedeli")
        '        dr1("lMalIskontoTutari") = dr1("lMalIskontoTutari") + dr1("lDipIskontoTutari3")
        '        If CType(dr1("lEkmaliyet1"), Decimal) <> 0 Then
        '            dr1("EkOran") = CType(dr1("lEkmaliyet1"), Decimal) / CType(dr1("lMalBedeli") - dr1("lMalIskontoTutari"), Decimal)
        '        End If
        '    Catch ex As Exception
        '    End Try
        'Next
        'dr1 = Nothing
        VGrid_baslik.DataSource = ds_baslik
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
        'VGrid_masraf.DataSource = ds_masraf
        'VGrid_masraf.DataMember = "BASLIK"
        'VGrid_masraf.Refresh()
        'VGrid_iskonto.DataSource = ds_iskonto
        'VGrid_iskonto.DataMember = "BASLIK"
        'VGrid_iskonto.Refresh()
        VGrid_toplam.DataSource = ds_toplam
        VGrid_toplam.DataMember = "TOPLAM"
        VGrid_toplam.Refresh()
    End Sub
    Private Sub TermalYazdir_baslik()
        If bDirektYazdirTermal = True Then
            'Dim drP As DataRow = ds_tbParamGenel.Tables(0).Rows(0)
            'w32prn.SetPrinterName("FIS")
            'w32prn.OpenCashdrawer(2)    '' 2 pin cashdrawer
            'w32prn.OpenCashdrawer(5)    '' 5 pin cashdrawer			
            ' ''// Print Image
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("x")
            'w32prn.PrintText("G")       ''// 1st NV Image
            'w32prn.PrintText("H")       ''// 2nd NV Image
            ' ''// Print Receipt
            'w32prn.SetDeviceFont(9.5F, "FontA2x1", False, True)
            'w32prn.PrintText(drP("sFirmaKisaAdi"))
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, False)
            'w32prn.PrintText(drP("sFirmaAdresi"))
            'w32prn.PrintText("")
            'w32prn.SetDeviceFont(7.0F, "FontB2x1", False, True)
            'w32prn.PrintText(drP("sTelefon1"))
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("w")
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, False)
            ''w32prn.PrintText("Tarih : " & dteFisTarihi & "          FisNo : " & sayiuzunlukkontrol(lFaturaNo, 6) & "")
            ''w32prn.PrintText(degeruzunlukkontrol("Saat  : " & Now.ToShortTimeString, 42))
            'w32prn.PrintText("------------------------------------------")
            'w32prn.EndDoc()
        End If
    End Sub
    Private Sub Termalyazdir_hareket()
        If bDirektYazdirTermal = True Then
            'Dim dr As DataRow
            'For Each dr In ds_hareket.Tables(0).Rows
            '    w32prn.PrintText(degeruzunlukkontrol(dr("lCikisMiktar1"), 5) & " X " & degeruzunlukkontrol(dr("sStokAciklama"), 27) & sayiuzunlukkontrol("*" & FormatNumber(dr("lBrutTutar"), 2), 7, " "))
            'Next
            'w32prn.EndDoc()
        End If
    End Sub
    Private Sub TermalYazdir_toplam()
        If bDirektYazdirTermal = True Then
            'w32prn.PrintText("------------------------------------------")
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, True)
            'w32prn.PrintText(degeruzunlukkontrol("ToplamMiktar  :                   ", 30) & sayiuzunlukkontrol("*" & FormatNumber(dr_toplam("lToplamMiktar"), 2), 12, " "))
            'If (dr_toplam("lDipIskontoTutari") + dr_toplam("lMalIskontoTutari")) = 0 Then
            'Else
            '    w32prn.PrintText(degeruzunlukkontrol("Iskonto :", 12) & sayiuzunlukkontrol("*" & FormatNumber(dr_toplam("lDipIskontoTutari") + dr_toplam("lMalIskontoTutari"), 2), 9, " "))
            '    '((dr_toplam("lDipIskontoTutari") + dr_toplam("lMalIskontoTutari")) / dr_toplam("lMalBedeli")) * 100
            'End If
            'w32prn.SetDeviceFont(7.0F, "FontA2x1", False, True)
            'w32prn.PrintText(degeruzunlukkontrol("Toplam :", 12) & sayiuzunlukkontrol("*" & FormatNumber(dr_toplam("lNetTutar"), 2), 9, " "))
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, True)
            'w32prn.PrintText(degeruzunlukkontrol("Ödenen        :                   ", 30) & sayiuzunlukkontrol("*" & FormatNumber((lOdenen), 2), 12, " "))
            'If lVeresiye = 0 Then
            'Else
            '    w32prn.PrintText(degeruzunlukkontrol("Veresiye      :                   ", 30) & sayiuzunlukkontrol("*" & FormatNumber((lVeresiye), 2), 12, " "))
            'End If
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, False)
            'If lParaUstu = 0 Then
            'Else
            '    Me.label2.ForeColor = System.Drawing.Color.White
            '    label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
            '    label2.Text = "Ödenen   :  " & FormatNumber(lOdenen, 2) & vbCrLf
            '    label2.Text += "Para Üstü:  " & FormatNumber(-lParaUstu, 2)
            '    w32prn.PrintText(degeruzunlukkontrol("Para Üstü     :               ", 30) & sayiuzunlukkontrol("*" & FormatNumber(-lParaUstu, 2), 12, " "))
            'End If
            ''If (dr_toplam("lDipIskontoTutari") + dr_toplam("lMalIskontoTutari")) = 0 Then
            ''Else
            ''    w32prn.PrintText(degeruzunlukkontrol("Iskonto :", 12) & sayiuzunlukkontrol("*" & FormatNumber(dr_toplam("lDipIskontoTutari") + dr_toplam("lMalIskontoTutari"), 2), 9, " "))
            ''    '((dr_toplam("lDipIskontoTutari") + dr_toplam("lMalIskontoTutari")) / dr_toplam("lMalBedeli")) * 100
            ''End If
            'Dim sTutar As String = FormatNumber(dr_toplam("lNetTutar"), 2)
            'lbl_Yekun.Text = sTutar
            'w32prn.PrintText("------------------------------------------")
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("x")
            'w32prn.PrintText("r")
            'w32prn.SetDeviceFont(20.0F, "Code128", False, False)
            'w32prn.PrintText("{A{S" & Trim(nAlisVerisID) & "")
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, False)
            'w32prn.PrintText(degeruzunlukkontrol("Kodu  : " & dr_baslik("lKodu"), 42))
            'w32prn.PrintText(degeruzunlukkontrol("Adı   : " & dr_baslik("Musteri"), 42))
            'w32prn.PrintText(degeruzunlukkontrol("Bakiye: " & FormatNumber(sorgula_Decimal("SELECT     bakiye FROM         vwMusteriBakiyesi WHERE     (nMusteriID = " & dr_baslik("nMusteriID") & ")"), 2), 42))
            'w32prn.PrintText("")
            'w32prn.PrintText("Tarih : " & dteFisTarihi & "          FisNo : " & sayiuzunlukkontrol(dr_baslik("lFaturaNo"), 6) & "")
            'w32prn.PrintText(degeruzunlukkontrol("Saat  : " & Now.ToShortTimeString, 42))
            'w32prn.PrintText("Magaza: " & degeruzunlukkontrol(dr_baslik("sMagaza"), 5) & " KasaNo :" & sayiuzunlukkontrol(dr_baslik("nKasaNo"), 3) & " Kasiyer : " & degeruzunlukkontrol(dr_baslik("sKasiyerRumuzu"), 8) & "")
            ''w32prn.PrintText("Tarih : " & dr_baslik("dteFaturaTarihi") & "     Saat : " & Now.ToShortTimeString & "")
            ''w32prn.PrintText("FisNo : " & dr_baslik("lFaturaNo") & "")
            'w32prn.PrintText("")
            'w32prn.PrintText("")
            'w32prn.PrintText(".:: Tercihiniz için Tesekkür Ederiz ::. ")
            'w32prn.PrintText("*** Bu Belge Bilgi Amaçlidir... ***")
            'w32prn.PrintText("*** MALi DEGERi YOKTUR ***")
            ' ''// Print Image
            ' ''w32prn.PrintImage("c:\Formlar\free.bmp")
            ' ''//w32prn.PrintImage("sample2.bmp")		
            ''// Cut Receipt
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("P")
            ' ''// Print
            'w32prn.EndDoc()
        Else
            If lParaUstu = 0 Then
                Me.label2.ForeColor = System.Drawing.Color.White
                label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                label2.Text = "Ödenen   :  " & FormatNumber(lOdenen, 2) & vbCrLf
                label2.Text += "Para Üstü:  " & FormatNumber(-lParaUstu, 2)
            Else
                Me.label2.ForeColor = System.Drawing.Color.White
                label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                label2.Text = "Ödenen   :  " & FormatNumber(lOdenen, 2) & vbCrLf
                label2.Text += "Para Üstü:  " & FormatNumber(-lParaUstu, 2)
                'w32prn.PrintText(degeruzunlukkontrol("Para Üstü     :               ", 30) & sayiuzunlukkontrol("*" & FormatNumber(-lParaUstu, 2), 12, " "))
            End If
            Dim sTutar As String = FormatNumber(dr_toplam("lNetTutar"), 2)
            lbl_Yekun.Text = sTutar
        End If
    End Sub
    Private Sub TermalYazdir_iptal()
        If bDirektYazdirTermal = True Then
            'w32prn.PrintText("------------------------------------------")
            'w32prn.SetDeviceFont(7.5F, "FontA2x1", True, True)
            'w32prn.PrintText(" -Fis iptal Edildi- ")
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, False)
            'w32prn.PrintText("------------------------------------------")
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("x")
            'w32prn.PrintText("r")
            'w32prn.SetDeviceFont(20.0F, "Code128", False, False)
            'w32prn.PrintText("{A{S" & nAlisVerisID & "")
            'w32prn.SetDeviceFont(9.5F, "FontA1x1", False, False)
            'w32prn.PrintText("Tarih : " & dteFisTarihi & "          FisNo : " & sayiuzunlukkontrol(dr_baslik("lFaturaNo"), 6) & "")
            'w32prn.PrintText(degeruzunlukkontrol("Saat  : " & Now.ToShortTimeString, 42))
            'w32prn.PrintText("Magaza: " & degeruzunlukkontrol(dr_baslik("sMagaza"), 5) & " KasaNo :" & sayiuzunlukkontrol(dr_baslik("nKasaNo"), 3) & " Kasiyer : " & degeruzunlukkontrol(dr_baslik("sKasiyerRumuzu"), 8) & "")
            ''w32prn.PrintText("FisNo : " & dr_baslik("lFaturaNo") & "")
            'w32prn.PrintText("")
            'w32prn.PrintText("")
            'w32prn.PrintText(".:: Tercihiniz için Tesekkür Ederiz ::. ")
            'w32prn.PrintText("*** Bu Belge Bilgi Amaçlidir... ***")
            'w32prn.PrintText("*** MALi DEGERi YOKTUR ***")
            ' ''// Print Image
            ' ''w32prn.PrintImage("c:\Formlar\free.bmp")
            ' ''//w32prn.PrintImage("sample2.bmp")		
            ''// Cut Receipt
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("P")
            ' ''// Print
            'w32prn.EndDoc()
        End If
    End Sub
    Private Sub dataload_harekets()
        ds_hareket = sorgu_harekets(dr_baslik("sFisTipi"), "")
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        GridControl1.Select()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
    End Sub
    Public Function sorgu_alislar(ByVal tarih As DateTime, ByVal fisno As String, ByVal stokkodu As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < = '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') AND (tbStokFisiDetayi.lFisNo <> '" & fisno & "') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub calculator()
        Dim frm As New frm_calc
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub stok_gor(Optional ByVal sKonum As String = "Gelişmiş")
        Dim frm As New frm_stok_liste_fiyat
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        frm.Text = "Stok Gör..."
        frm.txt_ara.Text = ""
        frm.sec_konum.Text = sKonum
        frm.ShowDialog()
    End Sub
    Private Sub satir_ekle_stok(ByVal ara As String, Optional ByVal sKonum As String = "", Optional ByVal bEnvanterli As Boolean = False)
        'Dim frm As New frm_stok_liste_fiyat
        'frm.islemstatus = True
        'frm.connection = connection
        'frm.firmano = firmano
        'frm.donemno = donemno
        'frm.islemstatus = True
        'frm.kullanici = kullanici
        'If Trim(ara) <> "" Then
        '    frm.txt_ara.Text = ara
        '    frm.sec_konum.Text = sKonum
        '    frm.sec_kriter.Text = sec_kriter.Text
        'End If
        'frm.colFIYAT4.OptionsColumn.ShowInCustomizationForm = False
        'info = False
        'Dim stok_mevcut As Decimal = 0
        'Dim islem As Integer = 0
        'frm.sDepo = sMagaza
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.bFatura = True
        If bEnvanterli = True Then
            frm.secenek = "Artılar"
        End If
        If ara <> "" Then
            frm.qgelismis = sec_kriter.Text
            frm.gelismis = ara
            frm.status = True
            frm.mevcut = mevcut
        End If
        frm.kullanici = kullanici
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
        Dim isk5 As Decimal = 0
        Dim isk6 As Decimal = 0
        Dim isk7 As Decimal = 0
        Dim isk8 As Decimal = 0
        Dim lMiktar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        'Dim lFiyat As Decimal = 0
        Dim lGercekFiyat As Decimal = 0
        Dim lGercekToplam As Decimal = 0
        Dim lIsktutar As Decimal = 0
        Dim lkdvtutar As Decimal = 0
        Dim Prim As Decimal = 0
        frm.sFiyatTipi = sFiyatTipi 'Trim(dr_baslik("sFiyatTipi").ToString)
        Dim stok_mevcut As Decimal = 0
        Dim islem As Integer = 0
        frm.depo = sMagaza
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim lKur As Decimal = 0
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    stok_mevcut = sorgu_envanter(sMagaza, dr1("nStokID"))
                    If mevcut > stok_mevcut Then
                        If dr1("bEksiyeDusulebilirmi") = True Then
                            If dr1("bEksideUyarsinmi") = True Then
                                islem = 2
                                XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) düşüyor...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adı: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenk") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                islem = 3
                            End If
                        Else
                            islem = 1
                            XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) Düşemez...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adı: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenk") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut & vbCrLf & Sorgu_sDil("Lütfen Stoklarınızı Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        islem = 0
                    End If
                    If islem = 0 Or islem = 2 Or islem = 3 Then
                        dr = ds_hareket.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        Dim nIslemID As Int64 = sorgu_nStokIslemID()
                        dr("nIslemID") = nIslemID
                        dr("nStokID") = dr1("nStokId")
                        dr("sKodu") = dr1("sKodu")
                        dr("sStokAciklama") = dr1("sAciklama")
                        dr("sModel") = dr1("sModel")
                        dr("sRenkAdi") = dr1("sRenkAdi")
                        dr("sBeden") = dr1("sBeden")
                        dr("sKavala") = dr1("sKavala")
                        dr("sAciklama") = "" ' dr1("sAciklama")
                        dr("sDepo") = dr_baslik("sMagaza")
                        dr("dteIslemTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("nFirmaID") = 0
                        dr("nMusteriID") = dr_baslik("nMusteriID")
                        dr("sFisTipi") = dr_baslik("sFisTipi")
                        dr("dteFisTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("lFisNo") = dr_baslik("lFaturaNo")
                        If mevcut > 0 Then
                            dr("nGirisCikis") = 3
                        ElseIf mevcut < 0 Then
                            dr("nGirisCikis") = 4
                        End If
                        dr("sDepo") = dr_baslik("sMagaza")
                        dr("lReyonFisNo") = 0
                        dr("sStokIslem") = dr_baslik("sFisTipi")
                        dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
                        dr("sSaticiRumuzu") = sSaticiRumuzu
                        If sDatabaseGenel = "UGURLU" Then
                            If sFiyatTipi = sFiyat1 Then
                                dr("sOdemeKodu") = "0   "
                            ElseIf sFiyatTipi = sFiyat2 Then
                                dr("sOdemeKodu") = "6   "
                            ElseIf sFiyatTipi = sFiyat3 Then
                                dr("sOdemeKodu") = "10  "
                            Else
                                dr("sOdemeKodu") = sOdemeKodu
                            End If
                        Else
                            dr("sOdemeKodu") = sOdemeKodu
                        End If
                        dataload_odemekodu(sFiyatTipi)
                        dr("dteIrsaliyeTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("lIrsaliyeNo") = 0
                        dr("lGirisMiktar1") = 0
                        dr("lGirisMiktar2") = 0
                        dr("lGirisFiyat") = 0
                        dr("lGirisTutar") = 0
                        dr("lCikisMiktar1") = mevcut
                        dr("lCikisMiktar2") = 0
                        dr("sFiyatTipi") = sFiyatTipi
                        dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
                        dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
                        dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
                        dr("sDovizCinsi1") = ""
                        dr("lDovizMiktari1") = 0
                        dr("lDovizKuru1") = 0
                        If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                            If Trim(sFiyat1DovizCinsi) <> "" Then
                                lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                                dr("sDovizCinsi1") = sFiyat1DovizCinsi
                                dr("lDovizKuru1") = lKur
                                dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut * mevcut
                                dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                            Else
                                dr("lBrutFiyat") = dr1("lFiyat1")
                                dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                            End If
                        ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                            'dr("lBrutFiyat") = dr1("lFiyat2")
                            'dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                            If Trim(sFiyat2DovizCinsi) <> "" Then
                                lKur = sorgu_lDovizKuru(sFiyat2DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat2DovizKuru)
                                dr("sDovizCinsi1") = sFiyat2DovizCinsi
                                dr("lDovizKuru1") = lKur
                                dr("lDovizMiktari1") = dr1("lFiyat2") * mevcut
                                dr("lBrutFiyat") = dr1("lFiyat2") * lKur
                                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                            Else
                                dr("lBrutFiyat") = dr1("lFiyat2")
                                dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                            End If
                        ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                            'dr("lBrutFiyat") = dr1("lFiyat3")
                            'dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                            If Trim(sFiyat3DovizCinsi) <> "" Then
                                lKur = sorgu_lDovizKuru(sFiyat3DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat3DovizKuru)
                                dr("sDovizCinsi1") = sFiyat3DovizCinsi
                                dr("lDovizKuru1") = lKur
                                dr("lDovizMiktari1") = dr1("lFiyat3") * mevcut
                                dr("lBrutFiyat") = dr1("lFiyat3") * lKur
                                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                            Else
                                dr("lBrutFiyat") = dr1("lFiyat3")
                                dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                            End If
                        ElseIf Trim(sFiyatTipi) = "HD" Then
                            dr("lBrutFiyat") = 0.01
                            dr("lBrutTutar") = 0.01 * mevcut
                        Else
                            sFiyatTipi = sFiyat1
                            'dr("lBrutFiyat") = dr1("lFiyat1")
                            'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                            If Trim(sFiyat1DovizCinsi) <> "" Then
                                lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                                dr("sDovizCinsi1") = sFiyat1DovizCinsi
                                dr("lDovizKuru1") = lKur
                                dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                                dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                            Else
                                dr("lBrutFiyat") = dr1("lFiyat1")
                                dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                            End If
                        End If
                        If Trim(sFiyatTipi) <> Trim(sFiyat1) And Trim(dr_baslik("sEhliyetNo")) <> "" Then
                            If dr("lBrutFiyat") = 0 And dr1("lFiyat1") <> 0 Then
                                'dr("lBrutFiyat") = dr1("lFiyat1")
                                'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                                If Trim(sFiyat1DovizCinsi) <> "" Then
                                    lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                                    dr("sDovizCinsi1") = sFiyat1DovizCinsi
                                    dr("lDovizKuru1") = lKur
                                    dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                                    dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                                Else
                                    dr("lBrutFiyat") = dr1("lFiyat1")
                                    dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                                End If
                            End If
                        End If
                        If dr("lBrutFiyat") = 0 Then
                            dr("lBrutFiyat") = 0.001
                            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                        End If
                        dr("nKdvOrani") = dr1("nKdvOrani")
                        Dim lFiyat As Decimal = dr("lBrutFiyat")
                        Dim lTutar As Decimal = 0
                        If dr1("nIskontoYuzdesiAV") = 0 Then
                            If sFisTipi = "P" Or sFisTipi = "SP" Then
                                lFiyat = lFiyat * ((100 - dr_baslik("nIskontoPesin")) / 100)
                                dr("nIskontoYuzdesi") = dr_baslik("nIskontoPesin")
                            ElseIf sFisTipi = "K" Or sFisTipi = "SK" Then
                                lFiyat = lFiyat * ((100 - dr_baslik("nIskontoKredili")) / 100)
                                dr("nIskontoYuzdesi") = dr_baslik("nIskontoKredili")
                            End If
                        Else
                            lFiyat = lFiyat * ((100 - dr1("nIskontoYuzdesiAV")) / 100)
                            dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
                        End If
                        lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
                        lTutar = lFiyat * dr("lCikisMiktar1")
                        dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
                        'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                        dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
                        dr("lMaliyetFiyat") = dr1("MALIYET")
                        dr("lMaliyetTutar") = dr1("MALIYET") * mevcut
                        dr("lIlaveMaliyetTutar") = 0
                        dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
                        dr("sDovizCinsi") = ""
                        dr("lDovizFiyat") = 0
                        dr("nReceteNo") = 0
                        dr("nHesapID") = 0
                        dr("sAciklama") = "" 'dr1("sAciklama")
                        dr("sHareketTipi") = dr_baslik("sHareketTipi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = dr_baslik("dteFaturaTarihi") + " " + Now.ToLongTimeString
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("nOTVOrani") = 0
                        dr("nAlisverisID") = nAlisVerisID
                        dr("sMasrafYontemi") = ""
                        dr("sHangiUygulama") = ""
                        dr("nEkSaha1") = 0
                        dr("nEkSaha2") = 0
                        dr("bEkSoru1") = 0
                        dr("bEkSoru2") = 0
                        dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now
                        If dr("lCikisMiktar1") = 0 Then
                            dr("lCikisMiktar1") = 1
                            dr("nGirisCikis") = 3
                        ElseIf dr("lCikisMiktar1") < 0 Then
                            dr("nGirisCikis") = 4
                        ElseIf dr("lCikisMiktar1") > 0 Then
                            dr("nGirisCikis") = 3
                        End If
                        dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
                        dr("sBirimCinsi1") = dr1("sBirimCinsi1")
                        dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
                        dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
                        dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
                        dr("nPrim") = sorgu_sayi(sSaticiRumuzu_nPrim(dr("sSaticiRumuzu")), 0)
                        If dr("nPrim") = 0 Then
                            dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                        End If
                        If dr1("nPrim") <> 0 Then
                            dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                            Prim = sorgu_sayi(dr1("nPrim"), 0)
                        End If
                        dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)

                        dr("nIslemID") = tbStokFisidetay_kaydet_yeni(dr("nIslemID"), dr("nStokID"), dr("dteIslemTarihi"), dr("nFirmaID"), dr("nMusteriID"), dr("sFisTipi"), dr("dteFisTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), "", dr("nReceteNo"), "", "", dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), "", nAlisVerisID, 0, "", dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))

                        If bDirektYazdirTermal = True Then
                            'w32prn.PrintText(degeruzunlukkontrol(dr("lCikisMiktar1"), 5) & " X " & degeruzunlukkontrol(dr("sStokAciklama"), 27) & sayiuzunlukkontrol("*" & FormatNumber(dr("lBrutTutar"), 2), 7, " "))
                            'w32prn.EndDoc()
                        End If
                        fis_detay_fisno_degistir(dr("nIslemID"))
                        ds_hareket.Tables(0).Rows.Add(dr)
                        lKur = 0
                    End If
                    Me.Refresh()
                Next
                toplam_hesapla()
                Dim yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok("")
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelEkle.Focus()
                    GridControl1.Focus()
                End If
                GridView1.FocusedColumn = collGCMiktar
            End If
        Else
        End If
        stok_mevcut = Nothing
        info = True
        satir_info()
    End Sub
    Private Function satir_ekle_stok_tek(ByVal yeni As Boolean) As Int64
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr1 = ds_stok.Tables(0).Rows(0)
        Dim stok_mevcut As Decimal = 0
        Dim islem As Integer = 0
        Dim lKur As Decimal = 0
        Dim nIslemID As Int64 = 0
        'Dim lFiyat As Decimal = 0
        stok_mevcut = sorgu_envanter(sMagaza, dr1("nStokID"))
        If mevcut > stok_mevcut Then
            If dr1("bEksiyeDusulebilirmi") = True Then
                If dr1("bEksideUyarsinmi") = True Then
                    islem = 2
                    XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) düşüyor...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adı: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenkAdi") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    islem = 3
                End If
            Else
                islem = 1
                XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) Düşemez...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adı: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenkAdi") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut & vbCrLf & Sorgu_sDil("Lütfen Stoklarınızı Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            islem = 0
        End If
        If islem = 0 Or islem = 2 Or islem = 3 Then
            If Trim(dr1("sBirimCinsi2")) = "P" Then
                Dim frm As New frm_calc
                If frm.ShowDialog = DialogResult.OK Then
                    If frm.tutar <> 0 Then
                        dr1("lFiyat1") = sorgu_sayi(frm.CalcEdit1.EditValue, 1)
                    End If
                End If
            ElseIf Trim(dr1("sBirimCinsi2")) = "M" Then
                Dim frm As New frm_calc
                If frm.ShowDialog = DialogResult.OK Then
                    If frm.tutar <> 0 And sorgu_sayi(dr1("lFiyat1"), 1) <> 0 Then
                        mevcut = frm.tutar / sorgu_sayi(dr1("lFiyat1"), 1)
                    End If
                End If
            End If
        End If
        If islem = 0 Or islem = 2 Or islem = 3 Then
            dr = ds_hareket.Tables(0).NewRow
            nIslemID = sorgu_nStokIslemID()
            dr("nIslemID") = nIslemID
            dr("nStokID") = dr1("nStokId")
            dr("sKodu") = dr1("sKodu")
            dr("sStokAciklama") = dr1("sAciklama")
            dr("sModel") = dr1("sModel")
            dr("sRenkAdi") = dr1("sRenkAdi")
            dr("sBeden") = dr1("sBeden")
            dr("sKavala") = dr1("sKavala")
            dr("sAciklama") = "" 'dr1("sAciklama")
            dr("sDepo") = dr_baslik("sMagaza")
            dr("dteIslemTarihi") = dr_baslik("dteFaturaTarihi")
            dr("nFirmaID") = 0
            dr("nMusteriID") = dr_baslik("nMusteriID")
            dr("sFisTipi") = dr_baslik("sFisTipi")
            dr("dteFisTarihi") = dr_baslik("dteFaturaTarihi")
            dr("lFisNo") = dr_baslik("lFaturaNo")
            If mevcut > 0 Then
                dr("nGirisCikis") = 3
            ElseIf mevcut < 0 Then
                dr("nGirisCikis") = 4
            End If
            dr("sDepo") = dr_baslik("sMagaza")
            dr("lReyonFisNo") = 0
            dr("sStokIslem") = dr_baslik("sFisTipi")
            dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
            dr("sSaticiRumuzu") = sSaticiRumuzu
            If sDatabaseGenel = "UGURLU" Then
                If sFiyatTipi = sFiyat1 Then
                    dr("sOdemeKodu") = "0   "
                ElseIf sFiyatTipi = sFiyat2 Then
                    dr("sOdemeKodu") = "6   "
                ElseIf sFiyatTipi = sFiyat3 Then
                    dr("sOdemeKodu") = "10  "
                Else
                    dr("sOdemeKodu") = sOdemeKodu
                End If
            Else
                dr("sOdemeKodu") = sOdemeKodu
            End If
            dataload_odemekodu(sFiyatTipi)
            dr("dteIrsaliyeTarihi") = dr_baslik("dteFaturaTarihi")
            dr("lIrsaliyeNo") = 0
            dr("lGirisMiktar1") = 0
            dr("lGirisMiktar2") = 0
            dr("lGirisFiyat") = 0
            dr("lGirisTutar") = 0
            dr("lCikisMiktar1") = mevcut
            dr("lCikisMiktar2") = 0
            dr("sFiyatTipi") = sFiyatTipi
            dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
            dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
            dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                If Trim(sFiyat1DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                    dr("sDovizCinsi1") = sFiyat1DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat1")
                    dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                End If
            ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                'dr("lBrutFiyat") = dr1("lFiyat2")
                'dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                If Trim(sFiyat2DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat2DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat2DovizKuru)
                    dr("sDovizCinsi1") = sFiyat2DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat2") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat2") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat2")
                    dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                End If
            ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                'dr("lBrutFiyat") = dr1("lFiyat3")
                'dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                If Trim(sFiyat3DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat3DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat3DovizKuru)
                    dr("sDovizCinsi1") = sFiyat3DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat3") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat3") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat3")
                    dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                End If
            ElseIf Trim(sFiyatTipi) = "HD" Then
                dr("lBrutFiyat") = 0.01
                dr("lBrutTutar") = 0.01 * mevcut
            Else
                sFiyatTipi = sFiyat1
                'dr("lBrutFiyat") = dr1("lFiyat1")
                'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                If Trim(sFiyat1DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                    dr("sDovizCinsi1") = sFiyat1DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat1")
                    dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                End If
            End If
            If Trim(sFiyatTipi) <> Trim(sFiyat1) And Trim(dr_baslik("sEhliyetNo")) <> "" Then
                If dr("lBrutFiyat") = 0 And dr1("lFiyat1") <> 0 Then
                    'dr("lBrutFiyat") = dr1("lFiyat1")
                    'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                    If Trim(sFiyat1DovizCinsi) <> "" Then
                        lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                        dr("sDovizCinsi1") = sFiyat1DovizCinsi
                        dr("lDovizKuru1") = lKur
                        dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                        dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    Else
                        dr("lBrutFiyat") = dr1("lFiyat1")
                        dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                    End If
                End If
            End If
            If dr("lBrutFiyat") = 0 Then
                dr("lBrutFiyat") = 0.001
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            End If
            dr("nKdvOrani") = dr1("nKdvOrani")
            Dim lFiyat As Decimal = dr("lBrutFiyat")
            Dim lTutar As Decimal = 0
            If dr1("nIskontoYuzdesiAV") = 0 Then
                If sFisTipi = "P" Or sFisTipi = "SP" Then
                    lFiyat = lFiyat * ((100 - dr_baslik("nIskontoPesin")) / 100)
                    dr("nIskontoYuzdesi") = dr_baslik("nIskontoPesin")
                ElseIf sFisTipi = "K" Or sFisTipi = "SK" Then
                    lFiyat = lFiyat * ((100 - dr_baslik("nIskontoKredili")) / 100)
                    dr("nIskontoYuzdesi") = dr_baslik("nIskontoKredili")
                End If
            Else
                lFiyat = lFiyat * ((100 - dr1("nIskontoYuzdesiAV")) / 100)
                dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
            End If
            lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
            lTutar = lFiyat * dr("lCikisMiktar1")
            dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
            'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
            dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
            dr("lMaliyetFiyat") = dr1("MALIYET")
            dr("lMaliyetTutar") = dr1("MALIYET") * mevcut
            dr("lIlaveMaliyetTutar") = 0
            'dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
            dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
            dr("sDovizCinsi") = ""
            dr("lDovizFiyat") = 0
            dr("nReceteNo") = 0
            dr("nHesapID") = 0
            dr("sAciklama") = "" 'dr1("sAciklama")
            dr("sHareketTipi") = dr_baslik("sHareketTipi")
            dr("bMuhasebeyeIslendimi") = 0
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = dr_baslik("dteFaturaTarihi") + " " + Now.ToLongTimeString
            dr("sDovizCinsi2") = ""
            dr("lDovizMiktari2") = 0
            dr("lDovizKuru2") = 0
            dr("nOTVOrani") = 0
            dr("nAlisverisID") = nAlisVerisID
            dr("sMasrafYontemi") = ""
            dr("sHangiUygulama") = ""
            dr("nEkSaha1") = 0
            dr("nEkSaha2") = 0
            dr("bEkSoru1") = 0
            dr("bEkSoru2") = 0
            dr("sSonKullaniciAdi") = kullaniciadi
            dr("dteSonUpdateTarihi") = Now
            If dr("lCikisMiktar1") = 0 Then
                dr("lCikisMiktar1") = 1
                dr("nGirisCikis") = 3
            ElseIf dr("lCikisMiktar1") < 0 Then
                dr("nGirisCikis") = 4
            ElseIf dr("lCikisMiktar1") > 0 Then
                dr("nGirisCikis") = 3
            End If
            dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
            dr("sBirimCinsi1") = dr1("sBirimCinsi1")
            dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
            dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
            dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
            dr("nPrim") = sorgu_sayi(sSaticiRumuzu_nPrim(dr("sSaticiRumuzu")), 0)
            If dr("nPrim") = 0 Then
                dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
            End If
            If dr1("nPrim") <> 0 Then
                dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                Dim Prim = sorgu_sayi(dr1("nPrim"), 0)
            End If
            dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
            dr("nIslemID") = tbStokFisidetay_kaydet_yeni(dr("nIslemID"), dr("nStokID"), dr("dteIslemTarihi"), dr("nFirmaID"), dr("nMusteriID"), dr("sFisTipi"), dr("dteFisTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), sorgu_sayi(dr("lGirisMiktar1"), 0), sorgu_sayi(dr("lGirisMiktar2"), 0), sorgu_sayi(dr("lGirisFiyat"), 0), sorgu_sayi(dr("lGirisTutar"), 0), sorgu_sayi(dr("lCikisMiktar1"), 0), sorgu_sayi(dr("lCikisMiktar2"), 0), sorgu_sayi(dr("lCikisFiyat"), 0), sorgu_sayi(dr("lCikisTutar"), 0), dr("sFiyatTipi"), sorgu_sayi(dr("lBrutFiyat"), 0), sorgu_sayi(dr("lBrutTutar"), 0), sorgu_sayi(dr("lMaliyetFiyat"), 0), sorgu_sayi(dr("lMaliyetTutar"), 0), sorgu_sayi(dr("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr("nIskontoYuzdesi"), 0), sorgu_sayi(dr("lIskontoTutari"), 0), dr("sDovizCinsi"), sorgu_sayi(dr("lDovizFiyat"), 0), "", dr("nReceteNo"), "", "", sorgu_sayi(dr("nKdvOrani"), 0), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), sorgu_sayi(dr("lDovizMiktari1"), 0), sorgu_sayi(dr("lDovizKuru1"), 0), dr("sDovizCinsi2"), sorgu_sayi(dr("lDovizMiktari2"), 0), sorgu_sayi(dr("lDovizKuru2"), 0), dr("nOTVOrani"), "", nAlisVerisID, 0, "", dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))
            If bDirektYazdirTermal = True Then
                'w32prn.PrintText(degeruzunlukkontrol(dr("lCikisMiktar1"), 5) & " X " & degeruzunlukkontrol(dr("sStokAciklama"), 27) & sayiuzunlukkontrol("*" & FormatNumber(dr("lBrutTutar"), 2), 7, " "))
                'w32prn.EndDoc()
            End If
            fis_detay_fisno_degistir(dr("nIslemID"))
            ds_hareket.Tables(0).Rows.Add(dr)
            Label4.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
        End If
        Me.Refresh()
        toplam_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelEkle.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = collGCMiktar
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
        stok_mevcut = Nothing
        Return nIslemID
    End Function
    Private Sub satir_ekle_stok_koli(ByVal sKoliKodu As String)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lMevcut As Decimal = mevcut
        Dim stok_mevcut As Decimal = 0
        Dim lBirimMiktar As Decimal = 0
        Dim islem As Integer = 0
        Dim lKur As Decimal = 0
        Dim ds_tbKoliDagilim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'), 0) AS lAltFiyat, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbKoliDagilimi.lMiktar AS lMiktar,tbKoliDagilimi.sBirimCinsi,tbKoliDagilimi.lBirimMiktar,tbKoliDagilimi.lFiyat,tbKoliDagilimi.sFiyatTipi FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbKoliDagilimi ON tbStok.nStokID = tbKoliDagilimi.nStokID WHERE (tbKoliDagilimi.sKoliKodu = N'" & sKoliKodu & "')")
        For Each dr1 In ds_tbKoliDagilim.Tables(0).Rows
            mevcut = lMevcut * sorgu_sayi(dr1("lMiktar") * dr1("lBirimMiktar"), 1)
            lBirimMiktar = sorgu_sayi(dr1("lBirimMiktar"), 1)
            dr1("lFiyat") = dr1("lFiyat") / dr1("lBirimMiktar")
            stok_mevcut = sorgu_envanter(sMagaza, dr1("nStokID"))
            If mevcut > stok_mevcut Then
                If dr1("bEksiyeDusulebilirmi") = True Then
                    If dr1("bEksideUyarsinmi") = True Then
                        islem = 2
                        XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) düşüyor...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adı: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenkAdi") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        islem = 3
                    End If
                Else
                    islem = 1
                    XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) Düşemez...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adı: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenkAdi") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut & vbCrLf & Sorgu_sDil("Lütfen Stoklarınızı Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                islem = 0
            End If
            If islem = 0 Or islem = 2 Or islem = 3 Then
                dr = ds_hareket.Tables(0).NewRow
                Dim nIslemID As Int64 = sorgu_nStokIslemID()
                dr("nIslemID") = nIslemID
                dr("nStokID") = dr1("nStokId")
                dr("sKodu") = dr1("sKodu")
                dr("sStokAciklama") = dr1("sAciklama")
                dr("sModel") = dr1("sModel")
                dr("sRenkAdi") = dr1("sRenkAdi")
                dr("sBeden") = dr1("sBeden")
                dr("sKavala") = dr1("sKavala")
                dr("sAciklama") = "" 'dr1("sAciklama")
                dr("sDepo") = dr_baslik("sMagaza")
                dr("dteIslemTarihi") = dr_baslik("dteFaturaTarihi")
                dr("nFirmaID") = 0
                dr("nMusteriID") = dr_baslik("nMusteriID")
                dr("sFisTipi") = dr_baslik("sFisTipi")
                dr("dteFisTarihi") = dr_baslik("dteFaturaTarihi")
                dr("lFisNo") = dr_baslik("lFaturaNo")
                If mevcut > 0 Then
                    dr("nGirisCikis") = 3
                ElseIf mevcut < 0 Then
                    dr("nGirisCikis") = 4
                End If
                dr("sDepo") = dr_baslik("sMagaza")
                dr("lReyonFisNo") = 0
                dr("sStokIslem") = dr_baslik("sFisTipi")
                dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
                dr("sSaticiRumuzu") = sSaticiRumuzu
                If sDatabaseGenel = "UGURLU" Then
                    If sFiyatTipi = sFiyat1 Then
                        dr("sOdemeKodu") = "0   "
                    ElseIf sFiyatTipi = sFiyat2 Then
                        dr("sOdemeKodu") = "6   "
                    ElseIf sFiyatTipi = sFiyat3 Then
                        dr("sOdemeKodu") = "10  "
                    Else
                        dr("sOdemeKodu") = sOdemeKodu
                    End If
                Else
                    dr("sOdemeKodu") = sOdemeKodu
                End If
                dataload_odemekodu(sFiyatTipi)
                dr("dteIrsaliyeTarihi") = dr_baslik("dteFaturaTarihi")
                dr("lIrsaliyeNo") = 0
                dr("lGirisMiktar1") = 0
                dr("lGirisMiktar2") = 0
                dr("lGirisFiyat") = 0
                dr("lGirisTutar") = 0
                dr("lCikisMiktar1") = mevcut
                dr("lCikisMiktar2") = 0
                dr("sFiyatTipi") = sFiyatTipi
                dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
                dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
                dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
                dr("sDovizCinsi1") = ""
                dr("lDovizMiktari1") = 0
                dr("lDovizKuru1") = 0
                If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                    If Trim(sFiyat1DovizCinsi) <> "" Then
                        lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                        dr("sDovizCinsi1") = sFiyat1DovizCinsi
                        dr("lDovizKuru1") = lKur
                        dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                        dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    Else
                        dr("lBrutFiyat") = dr1("lFiyat1")
                        dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                    End If
                ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                    'dr("lBrutFiyat") = dr1("lFiyat2")
                    'dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                    If Trim(sFiyat2DovizCinsi) <> "" Then
                        lKur = sorgu_lDovizKuru(sFiyat2DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat2DovizKuru)
                        dr("sDovizCinsi1") = sFiyat2DovizCinsi
                        dr("lDovizKuru1") = lKur
                        dr("lDovizMiktari1") = dr1("lFiyat2") * mevcut
                        dr("lBrutFiyat") = dr1("lFiyat2") * lKur
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    Else
                        dr("lBrutFiyat") = dr1("lFiyat2")
                        dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                    End If
                ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                    'dr("lBrutFiyat") = dr1("lFiyat3")
                    'dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                    If Trim(sFiyat3DovizCinsi) <> "" Then
                        lKur = sorgu_lDovizKuru(sFiyat3DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat3DovizKuru)
                        dr("sDovizCinsi1") = sFiyat3DovizCinsi
                        dr("lDovizKuru1") = lKur
                        dr("lDovizMiktari1") = dr1("lFiyat3") * mevcut
                        dr("lBrutFiyat") = dr1("lFiyat3") * lKur
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    Else
                        dr("lBrutFiyat") = dr1("lFiyat3")
                        dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                    End If
                ElseIf Trim(sFiyatTipi) = "HD" Then
                    dr("lBrutFiyat") = 0.01
                    dr("lBrutTutar") = 0.01 * mevcut
                Else
                    sFiyatTipi = sFiyat1
                    'dr("lBrutFiyat") = dr1("lFiyat1")
                    'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                    If Trim(sFiyat1DovizCinsi) <> "" Then
                        lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                        dr("sDovizCinsi1") = sFiyat1DovizCinsi
                        dr("lDovizKuru1") = lKur
                        dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                        dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    Else
                        dr("lBrutFiyat") = dr1("lFiyat1")
                        dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                    End If
                End If
                If Trim(sFiyatTipi) <> Trim(sFiyat1) And Trim(dr_baslik("sEhliyetNo")) <> "" Then
                    If dr("lBrutFiyat") = 0 And dr1("lFiyat1") <> 0 Then
                        'dr("lBrutFiyat") = dr1("lFiyat1")
                        'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                        If Trim(sFiyat1DovizCinsi) <> "" Then
                            lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                            dr("sDovizCinsi1") = sFiyat1DovizCinsi
                            dr("lDovizKuru1") = lKur
                            dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                            dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                        Else
                            dr("lBrutFiyat") = dr1("lFiyat1")
                            dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                        End If
                    End If
                End If
                If dr1("lFiyat") = 0 Then
                Else
                    If Trim(sFiyat1DovizCinsi) <> "" Then
                        lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                        dr("sDovizCinsi1") = sFiyat1DovizCinsi
                        dr("lDovizKuru1") = lKur
                        dr("lDovizMiktari1") = dr1("lFiyat") * mevcut
                        dr("lBrutFiyat") = dr1("lFiyat") * lKur
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    Else
                        dr("lBrutFiyat") = dr1("lFiyat")
                        dr("lBrutTutar") = dr1("lFiyat") * mevcut
                    End If
                    If Trim(dr1("sFiyatTipi")) = "" Then
                        sFiyatTipi = sFiyat1
                    Else
                        sFiyatTipi = dr1("sFiyatTipi")
                    End If
                End If
                If dr("lBrutFiyat") = 0 Then
                    dr("lBrutFiyat") = 0.001
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                End If
                dr("nKdvOrani") = dr1("nKdvOrani")
                Dim lFiyat As Decimal = dr("lBrutFiyat")
                Dim lTutar As Decimal = 0
                If dr1("nIskontoYuzdesiAV") = 0 Then
                    If sFisTipi = "P" Or sFisTipi = "SP" Then
                        lFiyat = lFiyat * ((100 - dr_baslik("nIskontoPesin")) / 100)
                        dr("nIskontoYuzdesi") = dr_baslik("nIskontoPesin")
                    ElseIf sFisTipi = "K" Or sFisTipi = "SK" Then
                        lFiyat = lFiyat * ((100 - dr_baslik("nIskontoKredili")) / 100)
                        dr("nIskontoYuzdesi") = dr_baslik("nIskontoKredili")
                    End If
                Else
                    lFiyat = lFiyat * ((100 - dr1("nIskontoYuzdesiAV")) / 100)
                    dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
                End If
                lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
                lTutar = lFiyat * dr("lCikisMiktar1")
                dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
                'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
                dr("lMaliyetFiyat") = dr1("MALIYET")
                dr("lMaliyetTutar") = dr1("MALIYET") * mevcut
                dr("lIlaveMaliyetTutar") = 0
                'dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
                dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
                dr("sDovizCinsi") = ""
                dr("lDovizFiyat") = 0
                dr("nReceteNo") = 0
                dr("nHesapID") = 0
                dr("sAciklama") = "" 'dr1("sAciklama")
                dr("sHareketTipi") = dr_baslik("sHareketTipi")
                dr("bMuhasebeyeIslendimi") = 0
                dr("sKullaniciAdi") = kullaniciadi
                dr("dteKayitTarihi") = dr_baslik("dteFaturaTarihi") + " " + Now.ToLongTimeString
                dr("sDovizCinsi2") = ""
                dr("lDovizMiktari2") = 0
                dr("lDovizKuru2") = 0
                dr("nOTVOrani") = 0
                dr("nAlisverisID") = nAlisVerisID
                dr("sMasrafYontemi") = ""
                dr("sHangiUygulama") = ""
                dr("nEkSaha1") = 0
                dr("nEkSaha2") = 0
                dr("bEkSoru1") = 0
                dr("bEkSoru2") = 0
                dr("sSonKullaniciAdi") = kullaniciadi
                dr("dteSonUpdateTarihi") = Now
                If dr("lCikisMiktar1") = 0 Then
                    dr("lCikisMiktar1") = 1
                    dr("nGirisCikis") = 3
                ElseIf dr("lCikisMiktar1") < 0 Then
                    dr("nGirisCikis") = 4
                ElseIf dr("lCikisMiktar1") > 0 Then
                    dr("nGirisCikis") = 3
                End If
                dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
                dr("sBirimCinsi1") = dr1("sBirimCinsi1")
                dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
                dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
                dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
                dr("nPrim") = sorgu_sayi(sSaticiRumuzu_nPrim(dr("sSaticiRumuzu")), 0)
                If dr("nPrim") = 0 Then
                    dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                End If
                If dr1("nPrim") <> 0 Then
                    dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                    Dim Prim = sorgu_sayi(dr1("nPrim"), 0)
                End If
                dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
                dr("nIslemID") = tbStokFisidetay_kaydet_yeni(dr("nIslemID"), dr("nStokID"), dr("dteIslemTarihi"), dr("nFirmaID"), dr("nMusteriID"), dr("sFisTipi"), dr("dteFisTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), sorgu_sayi(dr("lGirisMiktar1"), 0), sorgu_sayi(dr("lGirisMiktar2"), 0), sorgu_sayi(dr("lGirisFiyat"), 0), sorgu_sayi(dr("lGirisTutar"), 0), sorgu_sayi(dr("lCikisMiktar1"), 0), sorgu_sayi(dr("lCikisMiktar2"), 0), sorgu_sayi(dr("lCikisFiyat"), 0), sorgu_sayi(dr("lCikisTutar"), 0), dr("sFiyatTipi"), sorgu_sayi(dr("lBrutFiyat"), 0), sorgu_sayi(dr("lBrutTutar"), 0), sorgu_sayi(dr("lMaliyetFiyat"), 0), sorgu_sayi(dr("lMaliyetTutar"), 0), sorgu_sayi(dr("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr("nIskontoYuzdesi"), 0), sorgu_sayi(dr("lIskontoTutari"), 0), dr("sDovizCinsi"), sorgu_sayi(dr("lDovizFiyat"), 0), "", dr("nReceteNo"), "", "", sorgu_sayi(dr("nKdvOrani"), 0), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), sorgu_sayi(dr("lDovizMiktari1"), 0), sorgu_sayi(dr("lDovizKuru1"), 0), dr("sDovizCinsi2"), sorgu_sayi(dr("lDovizMiktari2"), 0), sorgu_sayi(dr("lDovizKuru2"), 0), dr("nOTVOrani"), "", nAlisVerisID, 0, "", dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))
                fis_detay_fisno_degistir(dr("nIslemID"))
                ds_hareket.Tables(0).Rows.Add(dr)
                Label4.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
                Label4.Refresh()
            End If
        Next
        Me.Refresh()
        toplam_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelEkle.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = collGCMiktar
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
        stok_mevcut = Nothing
    End Sub
    Private Sub satir_ekle_stok_siparis(ByVal ara As String, Optional ByVal sKonum As String = "", Optional ByVal bEnvanterli As Boolean = False)
        'Dim frm As New frm_stok_liste_fiyat
        'frm.islemstatus = True
        'frm.connection = connection
        'frm.firmano = firmano
        'frm.donemno = donemno
        'frm.islemstatus = True
        'frm.kullanici = kullanici
        'If Trim(ara) <> "" Then
        '    frm.txt_ara.Text = ara
        '    frm.sec_konum.Text = sKonum
        '    frm.sec_kriter.Text = sec_kriter.Text
        'End If
        'frm.sDepo = sMagaza
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.bFatura = True
        If bEnvanterli = True Then
            frm.secenek = "Artılar"
        End If
        If ara <> "" Then
            frm.qgelismis = sec_kriter.Text
            frm.gelismis = ara
            frm.status = True
            frm.mevcut = mevcut
        End If
        frm.kullanici = kullanici
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
        Dim isk5 As Decimal = 0
        Dim isk6 As Decimal = 0
        Dim isk7 As Decimal = 0
        Dim isk8 As Decimal = 0
        Dim lMiktar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        'Dim lFiyat As Decimal = 0
        Dim lGercekFiyat As Decimal = 0
        Dim lGercekToplam As Decimal = 0
        Dim lIsktutar As Decimal = 0
        Dim lkdvtutar As Decimal = 0
        frm.sFiyatTipi = sFiyatTipi 'Trim(dr_baslik("sFiyatTipi").ToString)
        Dim stok_mevcut As Decimal = 0
        Dim islem As Integer = 0
        frm.depo = sMagaza
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim lKur As Decimal = 0
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_hareket.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    Dim nSiparisID As Int64 = sorgu_nSiparisID(dr_baslik("sMagaza"))
                    dr("nAlisVerisID") = nAlisVerisID
                    dr("sMagazaKodu") = dr_baslik("sMagaza")
                    dr("nSiparisID") = nSiparisID
                    dr("nGirisCikis") = dr_baslik("nGirisCikis")
                    dr("nStokID") = dr1("nStokId")
                    dr("sKodu") = dr1("sKodu")
                    dr("sStokAciklama") = dr1("sAciklama")
                    dr("sModel") = dr1("sModel")
                    dr("sRenkAdi") = dr1("sRenkAdi")
                    dr("sBeden") = dr1("sBeden")
                    dr("sKavala") = dr1("sKavala")
                    dr("sAciklama") = "" 'dr1("sAciklama")
                    dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
                    dr("sSaticiRumuzu") = sSaticiRumuzu
                    If sDatabaseGenel = "UGURLU" Then
                        If sFiyatTipi = sFiyat1 Then
                            dr("sOdemeKodu") = "0   "
                        ElseIf sFiyatTipi = sFiyat2 Then
                            dr("sOdemeKodu") = "6   "
                        ElseIf sFiyatTipi = sFiyat3 Then
                            dr("sOdemeKodu") = "10  "
                        Else
                            dr("sOdemeKodu") = sOdemeKodu
                        End If
                    Else
                        dr("sOdemeKodu") = sOdemeKodu
                    End If
                    dataload_odemekodu(sFiyatTipi)
                    dr("lReyonFisNo") = 0
                    dr("sFiyatTipi") = sFiyatTipi
                    dr("lCikisMiktar1") = mevcut
                    dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
                    dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
                    dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
                    dr("sDovizCinsi1") = ""
                    dr("lDovizMiktari1") = 0
                    dr("lDovizKuru1") = 0
                    If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                        'dr("lBrutFiyat") = dr1("lFiyat1")
                        'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                        If Trim(sFiyat1DovizCinsi) <> "" Then
                            lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                            dr("sDovizCinsi1") = sFiyat1DovizCinsi
                            dr("lDovizKuru1") = lKur
                            dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                            dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                        Else
                            dr("lBrutFiyat") = dr1("lFiyat1")
                            dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                        End If
                    ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                        'dr("lBrutFiyat") = dr1("lFiyat2")
                        'dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                        If Trim(sFiyat2DovizCinsi) <> "" Then
                            lKur = sorgu_lDovizKuru(sFiyat2DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat2DovizKuru)
                            dr("sDovizCinsi1") = sFiyat2DovizCinsi
                            dr("lDovizKuru1") = lKur
                            dr("lDovizMiktari1") = dr1("lFiyat2") * mevcut
                            dr("lBrutFiyat") = dr1("lFiyat2") * lKur
                            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                        Else
                            dr("lBrutFiyat") = dr1("lFiyat2")
                            dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                        End If
                    ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                        'dr("lBrutFiyat") = dr1("lFiyat3")
                        'dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                        If Trim(sFiyat3DovizCinsi) <> "" Then
                            lKur = sorgu_lDovizKuru(sFiyat3DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat3DovizKuru)
                            dr("sDovizCinsi1") = sFiyat3DovizCinsi
                            dr("lDovizKuru1") = lKur
                            dr("lDovizMiktari1") = dr1("lFiyat3") * mevcut
                            dr("lBrutFiyat") = dr1("lFiyat3") * lKur
                            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                        Else
                            dr("lBrutFiyat") = dr1("lFiyat3")
                            dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                        End If
                    ElseIf Trim(sFiyatTipi) = "HD" Then
                        dr("lBrutFiyat") = 0.01
                        dr("lBrutTutar") = 0.01 * mevcut
                    Else
                        sFiyatTipi = sFiyat1
                        'dr("lBrutFiyat") = dr1("lFiyat1")
                        'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                        If Trim(sFiyat1DovizCinsi) <> "" Then
                            lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                            dr("sDovizCinsi1") = sFiyat1DovizCinsi
                            dr("lDovizKuru1") = lKur
                            dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                            dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                        Else
                            dr("lBrutFiyat") = dr1("lFiyat1")
                            dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                        End If
                    End If
                    If Trim(sFiyatTipi) <> Trim(sFiyat1) And Trim(dr_baslik("sEhliyetNo")) <> "" Then
                        If dr("lBrutFiyat") = 0 And dr1("lFiyat1") <> 0 Then
                            'dr("lBrutFiyat") = dr1("lFiyat1")
                            'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                            If Trim(sFiyat1DovizCinsi) <> "" Then
                                lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                                dr("sDovizCinsi1") = sFiyat1DovizCinsi
                                dr("lDovizKuru1") = lKur
                                dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                                dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                            Else
                                dr("lBrutFiyat") = dr1("lFiyat1")
                                dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                            End If
                        End If
                    End If
                    If dr("lBrutFiyat") = 0 Then
                        dr("lBrutFiyat") = 0.001
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    End If
                    dr("nIskontoYuzdesi") = 0
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    Dim lFiyat As Decimal = dr("lBrutFiyat")
                    Dim lTutar As Decimal = 0
                    If dr1("nIskontoYuzdesiAV") = 0 Then
                        If sFisTipi = "P" Or sFisTipi = "SP" Then
                            lFiyat = lFiyat * ((100 - dr_baslik("nIskontoPesin")) / 100)
                            dr("nIskontoYuzdesi") = dr_baslik("nIskontoPesin")
                        ElseIf sFisTipi = "K" Or sFisTipi = "SK" Then
                            lFiyat = lFiyat * ((100 - dr_baslik("nIskontoKredili")) / 100)
                            dr("nIskontoYuzdesi") = dr_baslik("nIskontoKredili")
                        End If
                    Else
                        lFiyat = lFiyat * ((100 - dr1("nIskontoYuzdesiAV")) / 100)
                        dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
                    End If
                    lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
                    lTutar = lFiyat * dr("lCikisMiktar1")
                    dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
                    'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                    dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
                    dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
                    dr("sIadeNedeni") = ""
                    dr("nPartiID") = 0
                    Try
                        dr("dteTeslimEdilecek") = DateAdd(DateInterval.Day, dr_param("nTeslimatGunu"), dr_baslik("dteFaturaTarihi"))
                    Catch ex As Exception
                        dr("dteTeslimEdilecek") = DateAdd(DateInterval.Day, 1, dr_baslik("dteFaturaTarihi"))
                    End Try
                    dr("dteTeslimEdilen") = "01/01/1900"
                    dr("bTeslimEdildi") = 0
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sAciklama") = "" 'dr1("sAciklama")
                    dr("bEkSoru") = 0
                    dr("bEkAlan1") = 0
                    dr("bEkAlan2") = ""
                    'dr("sDovizCinsi1") = ""
                    'dr("lDovizMiktari1") = 0
                    'dr("lDovizKuru1") = 0
                    dr("dteOnayTarihi") = "01/01/1900"
                    dr("sSonKullaniciAdi") = kullaniciadi
                    dr("dteSonUpdateTarihi") = Now
                    If dr("lCikisMiktar1") = 0 Then
                        dr("lCikisMiktar1") = 1
                        dr("nGirisCikis") = 3
                    ElseIf dr("lCikisMiktar1") < 0 Then
                        dr("nGirisCikis") = 4
                    ElseIf dr("lCikisMiktar1") > 0 Then
                        dr("nGirisCikis") = 3
                    End If
                    dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
                    dr("sBirimCinsi1") = dr1("sBirimCinsi1")
                    dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
                    dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
                    dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
                    dr("nPrim") = sorgu_sayi(sSaticiRumuzu_nPrim(dr("sSaticiRumuzu")), 0)
                    If dr("nPrim") = 0 Then
                        dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                    End If
                    If dr1("nPrim") <> 0 Then
                        dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                        Dim Prim = sorgu_sayi(dr1("nPrim"), 0)
                    End If
                    dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
                    tbAlisVerisSiparis_kaydet_yeni(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), dr("nPrim"), dr("lPrimTutari"))
                    tbAvSirano_degistir(5, nSiparisID, dr("sMagazaKodu"))
                    ds_hareket.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                toplam_hesapla()
                Dim yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok("")
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelEkle.Focus()
                    GridControl1.Focus()
                End If
                GridView1.FocusedColumn = collGCMiktar
            End If
        Else
        End If
    End Sub
    Private Sub satir_ekle_stok_siparis_tek(ByVal yeni As Boolean)
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = ds_hareket.Tables(0).NewRow
        dr1 = ds_stok.Tables(0).Rows(0)
        Dim nSiparisID As Int64 = sorgu_nSiparisID(dr_baslik("sMagaza"))
        Dim lKur As Decimal = 0
        dr("nAlisVerisID") = nAlisVerisID
        dr("sMagazaKodu") = dr_baslik("sMagaza")
        dr("nSiparisID") = nSiparisID
        dr("nGirisCikis") = dr_baslik("nGirisCikis")
        dr("nStokID") = dr1("nStokId")
        dr("sKodu") = dr1("sKodu")
        dr("sStokAciklama") = dr1("sAciklama")
        dr("sModel") = dr1("sModel")
        dr("sRenkAdi") = dr1("sRenkAdi")
        dr("sBeden") = dr1("sBeden")
        dr("sKavala") = dr1("sKavala")
        dr("sAciklama") = "" 'dr1("sAciklama")
        dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
        dr("sSaticiRumuzu") = sSaticiRumuzu
        If sDatabaseGenel = "UGURLU" Then
            If sFiyatTipi = sFiyat1 Then
                dr("sOdemeKodu") = "0   "
            ElseIf sFiyatTipi = sFiyat2 Then
                dr("sOdemeKodu") = "6   "
            ElseIf sFiyatTipi = sFiyat3 Then
                dr("sOdemeKodu") = "10  "
            Else
                dr("sOdemeKodu") = sOdemeKodu
            End If
        Else
            dr("sOdemeKodu") = sOdemeKodu
        End If
        dataload_odemekodu(sFiyatTipi)
        dr("lReyonFisNo") = 0
        dr("sFiyatTipi") = sFiyatTipi
        dr("lCikisMiktar1") = mevcut
        dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
        dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
        dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
        dr("sDovizCinsi1") = ""
        dr("lDovizMiktari1") = 0
        dr("lDovizKuru1") = 0
        If Trim(sFiyatTipi) = Trim(sFiyat1) Then
            'dr("lBrutFiyat") = dr1("lFiyat1")
            'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
            If Trim(sFiyat1DovizCinsi) <> "" Then
                lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                dr("sDovizCinsi1") = sFiyat1DovizCinsi
                dr("lDovizKuru1") = lKur
                dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            Else
                dr("lBrutFiyat") = dr1("lFiyat1")
                dr("lBrutTutar") = dr1("lFiyat1") * mevcut
            End If
        ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
            'dr("lBrutFiyat") = dr1("lFiyat2")
            'dr("lBrutTutar") = dr1("lFiyat2") * mevcut
            If Trim(sFiyat2DovizCinsi) <> "" Then
                lKur = sorgu_lDovizKuru(sFiyat2DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat2DovizKuru)
                dr("sDovizCinsi1") = sFiyat2DovizCinsi
                dr("lDovizKuru1") = lKur
                dr("lDovizMiktari1") = dr1("lFiyat2") * mevcut
                dr("lBrutFiyat") = dr1("lFiyat2") * lKur
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            Else
                dr("lBrutFiyat") = dr1("lFiyat2")
                dr("lBrutTutar") = dr1("lFiyat2") * mevcut
            End If
        ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
            'dr("lBrutFiyat") = dr1("lFiyat3")
            'dr("lBrutTutar") = dr1("lFiyat3") * mevcut
            If Trim(sFiyat3DovizCinsi) <> "" Then
                lKur = sorgu_lDovizKuru(sFiyat3DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat3DovizKuru)
                dr("sDovizCinsi1") = sFiyat3DovizCinsi
                dr("lDovizKuru1") = lKur
                dr("lDovizMiktari1") = dr1("lFiyat3") * mevcut
                dr("lBrutFiyat") = dr1("lFiyat3") * lKur
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            Else
                dr("lBrutFiyat") = dr1("lFiyat3")
                dr("lBrutTutar") = dr1("lFiyat3") * mevcut
            End If
        ElseIf Trim(sFiyatTipi) = "HD" Then
            dr("lBrutFiyat") = 0.01
            dr("lBrutTutar") = 0.01 * mevcut
        Else
            sFiyatTipi = sFiyat1
            'dr("lBrutFiyat") = dr1("lFiyat1")
            'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
            If Trim(sFiyat1DovizCinsi) <> "" Then
                lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                dr("sDovizCinsi1") = sFiyat1DovizCinsi
                dr("lDovizKuru1") = lKur
                dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            Else
                dr("lBrutFiyat") = dr1("lFiyat1")
                dr("lBrutTutar") = dr1("lFiyat1") * mevcut
            End If
        End If
        If Trim(sFiyatTipi) <> Trim(sFiyat1) And Trim(dr_baslik("sEhliyetNo")) <> "" Then
            If dr("lBrutFiyat") = 0 And dr1("lFiyat1") <> 0 Then
                'dr("lBrutFiyat") = dr1("lFiyat1")
                'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                If Trim(sFiyat1DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                    dr("sDovizCinsi1") = sFiyat1DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat1")
                    dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                End If
            End If
        End If
        If dr("lBrutFiyat") = 0 Then
            dr("lBrutFiyat") = 0.001
            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
        End If
        dr("nIskontoYuzdesi") = 0
        dr("lIskontoTutari") = 0
        dr("nKdvOrani") = dr1("nKdvOrani")
        Dim lFiyat As Decimal = dr("lBrutFiyat")
        Dim lTutar As Decimal = 0
        If dr1("nIskontoYuzdesiAV") = 0 Then
            If sFisTipi = "P" Or sFisTipi = "SP" Then
                lFiyat = lFiyat * ((100 - dr_baslik("nIskontoPesin")) / 100)
                dr("nIskontoYuzdesi") = dr_baslik("nIskontoPesin")
            ElseIf sFisTipi = "K" Or sFisTipi = "SK" Then
                lFiyat = lFiyat * ((100 - dr_baslik("nIskontoKredili")) / 100)
                dr("nIskontoYuzdesi") = dr_baslik("nIskontoKredili")
            End If
        Else
            lFiyat = lFiyat * ((100 - dr1("nIskontoYuzdesiAV")) / 100)
            dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
        End If
        lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
        lTutar = lFiyat * dr("lCikisMiktar1")
        dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
        'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
        dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
        dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
        dr("sIadeNedeni") = ""
        dr("nPartiID") = 0
        Try
            dr("dteTeslimEdilecek") = DateAdd(DateInterval.Day, dr_param("nTeslimatGunu"), dr_baslik("dteFaturaTarihi"))
        Catch ex As Exception
            dr("dteTeslimEdilecek") = DateAdd(DateInterval.Day, 1, dr_baslik("dteFaturaTarihi"))
        End Try
        dr("dteTeslimEdilen") = "01/01/1900"
        dr("bTeslimEdildi") = 0
        dr("bMuhasebeyeIslendimi") = 0
        dr("sAciklama") = "" 'dr1("sAciklama")
        dr("bEkSoru") = 0
        dr("bEkAlan1") = 0
        dr("bEkAlan2") = ""
        'dr("sDovizCinsi1") = ""
        'dr("lDovizMiktari1") = 0
        'dr("lDovizKuru1") = 0
        dr("dteOnayTarihi") = "01/01/1900"
        dr("sSonKullaniciAdi") = kullaniciadi
        dr("dteSonUpdateTarihi") = Now
        If dr("lCikisMiktar1") = 0 Then
            dr("lCikisMiktar1") = 1
            dr("nGirisCikis") = 3
        ElseIf dr("lCikisMiktar1") < 0 Then
            dr("nGirisCikis") = 4
        ElseIf dr("lCikisMiktar1") > 0 Then
            dr("nGirisCikis") = 3
        End If
        dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
        dr("sBirimCinsi1") = dr1("sBirimCinsi1")
        dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
        dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
        dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
        dr("nPrim") = sorgu_sayi(sSaticiRumuzu_nPrim(dr("sSaticiRumuzu")), 0)
        If dr("nPrim") = 0 Then
            dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
        End If
        If dr1("nPrim") <> 0 Then
            dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
            Dim Prim = sorgu_sayi(dr1("nPrim"), 0)
        End If
        dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
        tbAlisVerisSiparis_kaydet_yeni(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), dr("nPrim"), dr("lPrimTutari"))
        tbAvSirano_degistir(5, nSiparisID, dr("sMagazaKodu"))
        ds_hareket.Tables(0).Rows.Add(dr)
        Label4.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
        Label4.Refresh()
        Me.Refresh()
        toplam_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelEkle.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = collGCMiktar
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_ekle_stok_siparis_koli(ByVal sKoliKodu As String)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lMevcut As Decimal = mevcut
        Dim stok_mevcut As Decimal = 0
        Dim lBirimMiktar As Decimal = 0
        Dim islem As Integer = 0
        Dim lKur As Decimal = 0
        Dim ds_tbKoliDagilim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'), 0) AS lAltFiyat, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbKoliDagilimi.lMiktar AS lMiktar,tbKoliDagilimi.sBirimCinsi,tbKoliDagilimi.lBirimMiktar,tbKoliDagilimi.lFiyat,tbKoliDagilimi.sFiyatTipi FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbKoliDagilimi ON tbStok.nStokID = tbKoliDagilimi.nStokID WHERE (tbKoliDagilimi.sKoliKodu = N'" & sKoliKodu & "')")
        For Each dr1 In ds_tbKoliDagilim.Tables(0).Rows
            'dr1 = ds_stok.Tables(0).Rows(0)
            mevcut = lMevcut * sorgu_sayi(dr1("lMiktar") * dr1("lBirimMiktar"), 1)
            lBirimMiktar = sorgu_sayi(dr1("lBirimMiktar"), 1)
            dr1("lFiyat") = dr1("lFiyat") / dr1("lBirimMiktar")
            dr = ds_hareket.Tables(0).NewRow
            Dim nSiparisID As Int64 = sorgu_nSiparisID(dr_baslik("sMagaza"))
            dr("nAlisVerisID") = nAlisVerisID
            dr("sMagazaKodu") = dr_baslik("sMagaza")
            dr("nSiparisID") = nSiparisID
            dr("nGirisCikis") = dr_baslik("nGirisCikis")
            dr("nStokID") = dr1("nStokId")
            dr("sKodu") = dr1("sKodu")
            dr("sStokAciklama") = dr1("sAciklama")
            dr("sModel") = dr1("sModel")
            dr("sRenkAdi") = dr1("sRenkAdi")
            dr("sBeden") = dr1("sBeden")
            dr("sKavala") = dr1("sKavala")
            dr("sAciklama") = "" 'dr1("sAciklama")
            dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
            dr("sSaticiRumuzu") = sSaticiRumuzu
            If sDatabaseGenel = "UGURLU" Then
                If sFiyatTipi = sFiyat1 Then
                    dr("sOdemeKodu") = "0   "
                ElseIf sFiyatTipi = sFiyat2 Then
                    dr("sOdemeKodu") = "6   "
                ElseIf sFiyatTipi = sFiyat3 Then
                    dr("sOdemeKodu") = "10  "
                Else
                    dr("sOdemeKodu") = sOdemeKodu
                End If
            Else
                dr("sOdemeKodu") = sOdemeKodu
            End If
            dataload_odemekodu(sFiyatTipi)
            dr("lReyonFisNo") = 0
            dr("sFiyatTipi") = sFiyatTipi
            dr("lCikisMiktar1") = mevcut
            dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
            dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
            dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                'dr("lBrutFiyat") = dr1("lFiyat1")
                'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                If Trim(sFiyat1DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                    dr("sDovizCinsi1") = sFiyat1DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat1")
                    dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                End If
            ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                'dr("lBrutFiyat") = dr1("lFiyat2")
                'dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                If Trim(sFiyat2DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat2DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat2DovizKuru)
                    dr("sDovizCinsi1") = sFiyat2DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat2") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat2") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat2")
                    dr("lBrutTutar") = dr1("lFiyat2") * mevcut
                End If
            ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                'dr("lBrutFiyat") = dr1("lFiyat3")
                'dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                If Trim(sFiyat3DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat3DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat3DovizKuru)
                    dr("sDovizCinsi1") = sFiyat3DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat3") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat3") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat3")
                    dr("lBrutTutar") = dr1("lFiyat3") * mevcut
                End If
            ElseIf Trim(sFiyatTipi) = "HD" Then
                dr("lBrutFiyat") = 0.01
                dr("lBrutTutar") = 0.01 * mevcut
            Else
                sFiyatTipi = sFiyat1
                'dr("lBrutFiyat") = dr1("lFiyat1")
                'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                If Trim(sFiyat1DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                    dr("sDovizCinsi1") = sFiyat1DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat1")
                    dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                End If
            End If
            If Trim(sFiyatTipi) <> Trim(sFiyat1) And Trim(dr_baslik("sEhliyetNo")) <> "" Then
                If dr("lBrutFiyat") = 0 And dr1("lFiyat1") <> 0 Then
                    'dr("lBrutFiyat") = dr1("lFiyat1")
                    'dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                    If Trim(sFiyat1DovizCinsi) <> "" Then
                        lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                        dr("sDovizCinsi1") = sFiyat1DovizCinsi
                        dr("lDovizKuru1") = lKur
                        dr("lDovizMiktari1") = dr1("lFiyat1") * mevcut
                        dr("lBrutFiyat") = dr1("lFiyat1") * lKur
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    Else
                        dr("lBrutFiyat") = dr1("lFiyat1")
                        dr("lBrutTutar") = dr1("lFiyat1") * mevcut
                    End If
                End If
            End If
            If dr("lBrutFiyat") = 0 Then
                dr("lBrutFiyat") = 0.001
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            End If
            dr("nIskontoYuzdesi") = 0
            dr("lIskontoTutari") = 0
            If dr1("lFiyat") = 0 Then
            Else
                If Trim(sFiyat1DovizCinsi) <> "" Then
                    lKur = sorgu_lDovizKuru(sFiyat1DovizCinsi, dr_baslik("dteFaturaTarihi"), sFiyat1DovizKuru)
                    dr("sDovizCinsi1") = sFiyat1DovizCinsi
                    dr("lDovizKuru1") = lKur
                    dr("lDovizMiktari1") = dr1("lFiyat") * mevcut
                    dr("lBrutFiyat") = dr1("lFiyat") * lKur
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                Else
                    dr("lBrutFiyat") = dr1("lFiyat")
                    dr("lBrutTutar") = dr1("lFiyat") * mevcut
                End If
                If Trim(dr1("sFiyatTipi")) = "" Then
                    sFiyatTipi = sFiyat1
                Else
                    sFiyatTipi = dr1("sFiyatTipi")
                End If
            End If
            If dr("lBrutFiyat") = 0 Then
                dr("lBrutFiyat") = 0.001
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            End If
            dr("nKdvOrani") = dr1("nKdvOrani")
            Dim lFiyat As Decimal = dr("lBrutFiyat")
            Dim lTutar As Decimal = 0
            If dr1("nIskontoYuzdesiAV") = 0 Then
                If sFisTipi = "P" Or sFisTipi = "SP" Then
                    lFiyat = lFiyat * ((100 - dr_baslik("nIskontoPesin")) / 100)
                    dr("nIskontoYuzdesi") = dr_baslik("nIskontoPesin")
                ElseIf sFisTipi = "K" Or sFisTipi = "SK" Then
                    lFiyat = lFiyat * ((100 - dr_baslik("nIskontoKredili")) / 100)
                    dr("nIskontoYuzdesi") = dr_baslik("nIskontoKredili")
                End If
            Else
                lFiyat = lFiyat * ((100 - dr1("nIskontoYuzdesiAV")) / 100)
                dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesiAV")
            End If
            lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
            lTutar = lFiyat * dr("lCikisMiktar1")
            dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
            'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
            dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
            dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
            dr("sIadeNedeni") = ""
            dr("nPartiID") = 0
            Try
                dr("dteTeslimEdilecek") = DateAdd(DateInterval.Day, dr_param("nTeslimatGunu"), dr_baslik("dteFaturaTarihi"))
            Catch ex As Exception
                dr("dteTeslimEdilecek") = DateAdd(DateInterval.Day, 1, dr_baslik("dteFaturaTarihi"))
            End Try
            dr("dteTeslimEdilen") = "01/01/1900"
            dr("bTeslimEdildi") = 0
            dr("bMuhasebeyeIslendimi") = 0
            dr("sAciklama") = "" 'dr1("sAciklama")
            dr("bEkSoru") = 0
            dr("bEkAlan1") = 0
            dr("bEkAlan2") = ""
            'dr("sDovizCinsi1") = ""
            'dr("lDovizMiktari1") = 0
            'dr("lDovizKuru1") = 0
            dr("dteOnayTarihi") = "01/01/1900"
            dr("sSonKullaniciAdi") = kullaniciadi
            dr("dteSonUpdateTarihi") = Now
            If dr("lCikisMiktar1") = 0 Then
                dr("lCikisMiktar1") = 1
                dr("nGirisCikis") = 3
            ElseIf dr("lCikisMiktar1") < 0 Then
                dr("nGirisCikis") = 4
            ElseIf dr("lCikisMiktar1") > 0 Then
                dr("nGirisCikis") = 3
            End If
            dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
            dr("sBirimCinsi1") = dr1("sBirimCinsi1")
            dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
            dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
            dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
            dr("nPrim") = sorgu_sayi(sSaticiRumuzu_nPrim(dr("sSaticiRumuzu")), 0)
            If dr("nPrim") = 0 Then
                dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
            End If
            If dr1("nPrim") <> 0 Then
                dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                Dim Prim = sorgu_sayi(dr1("nPrim"), 0)
            End If
            dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
            tbAlisVerisSiparis_kaydet_yeni(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), dr("nPrim"), dr("lPrimTutari"))
            tbAvSirano_degistir(5, nSiparisID, dr("sMagazaKodu"))
            ds_hareket.Tables(0).Rows.Add(dr)
        Next
        Label4.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
        Label4.Refresh()
        Me.Refresh()
        toplam_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelEkle.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = collGCMiktar
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        Try
            If Trim(deger.ToString) = "" Then
                deger = sonuc
            End If
        Catch ex As Exception
            deger = sonuc
        End Try
        Return deger
    End Function
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satırı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim bDevam As Boolean = False
                dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    If sorgu_sayi(dr_hareket("nStokIslemID").ToString, 0) = 0 Then
                        tbAlisVerisSiparis_kaydet_sil(nAlisVerisID, dr_hareket("nSiparisID"), dr_hareket("sMagazaKodu"))
                        If dr_hareket("bEkAlan2") = "" Then
                        Else
                            If Microsoft.VisualBasic.Left(dr_hareket("sAciklama"), 4) = "Iade" Then
                                Dim strArr() As String
                                Dim str As String
                                Dim count As Integer
                                Dim sIadeMagazasi As String = ""
                                str = dr_hareket("sAciklama")
                                strArr = str.Split(";")
                                For count = 0 To strArr.Length - 1
                                    If count = 1 Then
                                        sIadeMagazasi = Trim(strArr(count))
                                    End If
                                Next
                                tbAlisVerisSiparis_iade_kaydet_duzelt(sIadeMagazasi, dr_hareket("bEkAlan2"), dr_hareket("nStokID"), dr_hareket("sIadeNedeni"), "01/01/1900", 0, "Iade;" & dr_hareket("sMagazaKodu") & ";" & dr_hareket("nSiparisID") & ";" & dr_hareket("sKasiyerRumuzu"), 0, 0, dr_hareket("bEkAlan2"), "01/01/1900")
                            End If
                        End If
                        bDevam = True
                    Else
                        bDevam = False
                        XtraMessageBox.Show("Teslimatı Yapılmış Ürünü Silemezsiniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    tbStokFisidetay_kaydet_sil(nAlisVerisID, dr_hareket("nIslemID"))
                    bDevam = True
                End If
                If bDevam = True Then
                    ds_hareket.Tables(0).Rows.Remove(dr_hareket)
                    'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                End If
                GridControl1.Focus()
                GridControl1.Select()
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
                toplam_hesapla()
            End If
        End If
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nSiparisID(ByVal sMagazaKodu As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(nSiparisID), 0) + 1 AS nSiparisID FROM tbAlisverisSiparis Where sMagazaKodu = '" & sMagazaKodu & "'")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(nSiparisID), 0) + 1 AS nSiparisID FROM tbAlisverisSiparis")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
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
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sDefaultHareketTipi,'') as sHareketTipi FROM         tbParamAlisVeris WHERE     (sMagazaKodu = '" & sDepo & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lFaturaNo(ByVal sDepo As String, ByVal sFisTipi As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lFaturaNo), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (sMagaza = '" & sDepo & "') AND (nGirisCikis = 3) AND (sFisTipi IN ('" & sFisTipi & "'))")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lFaturaNo), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nGirisCikis = 3) AND (sFisTipi IN ('" & sFisTipi & "'))")
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
        conn.ConnectionString = connection
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
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Function tbAlisVeris_musteri_degistir(ByVal nAlisVerisID As String, ByVal sFisTipi As String, ByVal lFisNo As String, ByVal nMusteriID As String, ByVal sAlisVerisYapanAdi As String, ByVal sAlisVerisYapanSoyadi As String) As Boolean
        Dim pass As Boolean = False
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions on")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVeris SET              sFisTipi ='" & sFisTipi & "',lFaturaNo = '" & lFisNo & "',sAlisverisYapanAdi = '" & sAlisVerisYapanAdi & "', sAlisverisYapanSoyadi = '" & sAlisVerisYapanSoyadi & "', nMusteriID = " & nMusteriID & " Where nAlisVerisID = '" & nAlisVerisID & "' ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi ='" & sFisTipi & "',lFisNo = '" & lFisNo & "',nMusteriID = " & nMusteriID & " Where nAlisVerisID = '" & nAlisVerisID & "' ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            pass = True
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            pass = False
            XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        con.Close()
        Return pass
    End Function
    Public Function sorgu_lPesinat_lTutari(ByVal nAlisVerisID) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar), 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nTaksit_nSayisi(ByVal nAlisVerisID) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nTaksitID), 0) AS nKayit FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_Kapatma_lTutari(ByVal nAlisVerisID As String, ByVal lNetTutar As Decimal) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        cmd.CommandTimeout = False
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'If lNetTutar > 0 Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "') UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = '" & nAlisVerisID & "') as Kapatma")
        'ElseIf lNetTutar < 0 Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 3)) Kapatma")
        'Else
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "') UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = '" & nAlisVerisID & "' UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 3)) as Kapatma")
        'End If
        Dim kayitsayisi As Decimal = sorgu_sayi(cmd.ExecuteScalar, 0)
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_Kapatma_lSayi(ByVal nAlisVerisID As String, ByVal lNetTutar As Decimal) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        Dim kayitsayisi
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If lNetTutar > 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nTaksitID), 0) AS nKayit FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "')")
        ElseIf lNetTutar < 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  ISNULL(Count(nTaksitID),0) AS nKayit FROM tbOdeme WHERE (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 3)")
        Else
            kayitsayisi = 0
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "') UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = '" & nAlisVerisID & "') as Kapatma")
        End If
        kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        Dim lMiktar As Decimal
        Dim lMalbedeli As Decimal
        Dim lMalIskontoTutari As Decimal
        Dim lMalArtisTutari As Decimal
        Dim nDipIskontoYuzdesi As Decimal
        Dim lDipIskontoTutari As Decimal
        Dim lPesinat As Decimal
        Dim lNetTutar As Decimal
        For Each dr In ds_hareket.Tables(0).Rows
            Try
                lMiktar += dr("lCikisMiktar1")
                lMalbedeli += dr("lBrutTutar")
                lMalIskontoTutari += sorgu_sayi(dr("lBrutTutar"), 0) * (sorgu_sayi(dr("nIskontoYuzdesi"), 0) / 100)
            Catch ex As Exception
            End Try
        Next
        dr_toplam("lToplamMiktar") = lMiktar
        dr_toplam("lMalBedeli") = lMalbedeli
        If dr_toplam("nDipIskontoYuzdesi1") > 0 Then
            dr_toplam("lDipIskontoTutari1") = FormatNumber((lMalbedeli - lMalIskontoTutari) * (dr_toplam("nDipIskontoYuzdesi1") / 100), 2)
        Else
            dr_toplam("lDipIskontoTutari1") = 0
        End If
        dr_toplam("lDipIskontoTutari") = FormatNumber(dr_toplam("lDipIskontoTutari1") + dr_toplam("lHarcananPuan"), 2)
        If dr_toplam("lDipIskontoTutari") <> 0 Then
            dr_toplam("nDipIskontoYuzdesi") = FormatNumber((dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100, 2)
        Else
            dr_toplam("nDipIskontoYuzdesi") = 0
        End If
        lNetTutar = lMalbedeli - lMalIskontoTutari - sorgu_sayi(dr_toplam("lDipIskontoTutari"), 0) + dr_toplam("lMalArtisTutari")
        dr_toplam("lMalIskontoTutari") = FormatNumber(lMalIskontoTutari, 2)
        dr_toplam("lPesinat") = sorgu_lPesinat_lTutari(nAlisVerisID)
        dr_toplam("lNetTutar") = FormatNumber(lNetTutar, 2)
        If lNetTutar < 0 Then
            dr_toplam("nGirisCikis") = 4
            dr_baslik("nGirisCikis") = 4
        ElseIf lNetTutar > 0 Then
            dr_toplam("nGirisCikis") = 3
            dr_baslik("nGirisCikis") = 3
        End If
        dr_toplam("sYaziIle") = ygeneltoplam(Math.Abs(lNetTutar))
        dr_toplam("nKdvOrani1") = 0
        dr_toplam("lKdvMatrahi1") = 0
        dr_toplam("lKdv1") = 0
        dr_toplam("nKdvOrani2") = 0
        dr_toplam("lKdvMatrahi2") = 0
        dr_toplam("lKdv2") = 0
        dr_toplam("nKdvOrani3") = 0
        dr_toplam("lKdvMatrahi3") = 0
        dr_toplam("lKdv3") = 0
        dr_toplam("nKdvOrani4") = 0
        dr_toplam("lKdvMatrahi4") = 0
        dr_toplam("lKdv4") = 0
        dr_toplam("nKdvOrani5") = 0
        dr_toplam("lKdvMatrahi5") = 0
        dr_toplam("lKdv5") = 0
        dr_toplam("nVadeFarkiYuzdesi") = 0
        dr_toplam("nVadeKdvOrani") = 0
        dr_toplam("lVadeKdvMatrahi") = 0
        dr_toplam("lVadeKdv") = 0
        dr_toplam("lVadeFarki") = 0
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            ds_alislar_kdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 5 nKdvOrani, SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdvMatrahi, SUM(lBrutTutar-lIskontoTutari) - SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdv, SUM(lBrutTutar-lIskontoTutari) AS lNetTutar FROM tbAlisVerisSiparis WHERE (nAlisverisID = '" & nAlisVerisID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        Else
            ds_alislar_kdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 5 nKdvOrani, SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdvMatrahi, SUM(lBrutTutar-lIskontoTutari) - SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdv, SUM(lBrutTutar-lIskontoTutari) AS lNetTutar FROM tbStokFisiDetayi WHERE (nAlisverisID = '" & nAlisVerisID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        End If
        Dim dr1 As DataRow
        Dim sayi As Decimal = 0
        For Each dr1 In ds_alislar_kdv.Tables(0).Rows
            sayi += 1
            If dr1("nKdvOrani") = 0 Then
                dr_toplam("nKdvOrani1") = dr1("nKdvOrani")
                dr_toplam("lKdvMatrahi1") = dr1("lKdvMatrahi")
                dr_toplam("lKdv1") = dr1("lKdv")
            ElseIf dr1("nKdvOrani") = 1 Then
                dr_toplam("nKdvOrani2") = dr1("nKdvOrani")
                dr_toplam("lKdvMatrahi2") = dr1("lKdvMatrahi")
                dr_toplam("lKdv2") = dr1("lKdv")
            ElseIf dr1("nKdvOrani") = 8 Then
                dr_toplam("nKdvOrani3") = dr1("nKdvOrani")
                dr_toplam("lKdvMatrahi3") = dr1("lKdvMatrahi")
                dr_toplam("lKdv3") = dr1("lKdv")
            ElseIf dr1("nKdvOrani") = 18 Then
                dr_toplam("nKdvOrani4") = dr1("nKdvOrani")
                dr_toplam("lKdvMatrahi4") = dr1("lKdvMatrahi")
                dr_toplam("lKdv4") = dr1("lKdv")
            Else
                dr_toplam("nKdvOrani5") = dr1("nKdvOrani")
                dr_toplam("lKdvMatrahi5") = dr1("lKdvMatrahi")
                dr_toplam("lKdv5") = dr1("lKdv")
            End If
            'dr_toplam("nKdvOrani" & sayi & "") = dr1("nKdvOrani")
            'dr_toplam("lKdvMatrahi" & sayi & "") = dr1("lKdvMatrahi")
            'dr_toplam("lKdv" & sayi & "") = dr1("lKdv")
        Next
        If (Trim(sFisTipi) = "K") Or (Trim(sFisTipi) = "P") Or (Trim(sFisTipi) = "SP") Or (Trim(sFisTipi) = "SK") Then
            If sDatabaseGenel = "UGURLU" Then
                Dim sinif2K As String = ""
                If IsDBNull(dr_baslik("Sinif2")) Then
                    sinif2K = ""
                Else
                    sinif2K = dr_baslik("Sinif2")
                End If
                tbAlisVeris_toplam_kaydet_degistir(nAlisVerisID, dr_toplam("nGirisCikis"), dr_toplam("lToplamMiktar"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), dr_toplam("nDipIskontoYuzdesi"), dr_toplam("lDipIskontoTutari"), dr_toplam("nKdvOrani1"), dr_toplam("lKdvMatrahi1"), dr_toplam("lKdv1"), dr_toplam("nKdvOrani2"), dr_toplam("lKdvMatrahi2"), dr_toplam("lKdv2"), dr_toplam("nKdvOrani3"), dr_toplam("lKdvMatrahi3"), dr_toplam("lKdv3"), dr_toplam("nKdvOrani4"), dr_toplam("lKdvMatrahi4"), dr_toplam("lKdv4"), dr_toplam("nKdvOrani5"), dr_toplam("lKdvMatrahi5"), dr_toplam("lKdv5"), dr_toplam("lPesinat"), dr_toplam("nVadeFarkiYuzdesi"), dr_toplam("nVadeKdvOrani"), dr_toplam("lVadeKdvMatrahi"), dr_toplam("lVadeKdv"), dr_toplam("lVadeFarki"), dr_toplam("lNetTutar"), dr_toplam("sYaziIle"), sinif2K)
                If sinif2Bakma = False Then
                    musteri_Sinif2_Guncelle(sinif2K)
                End If
            Else
                tbAlisVeris_toplam_kaydet_degistir(nAlisVerisID, dr_toplam("nGirisCikis"), dr_toplam("lToplamMiktar"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), dr_toplam("nDipIskontoYuzdesi"), dr_toplam("lDipIskontoTutari"), dr_toplam("nKdvOrani1"), dr_toplam("lKdvMatrahi1"), dr_toplam("lKdv1"), dr_toplam("nKdvOrani2"), dr_toplam("lKdvMatrahi2"), dr_toplam("lKdv2"), dr_toplam("nKdvOrani3"), dr_toplam("lKdvMatrahi3"), dr_toplam("lKdv3"), dr_toplam("nKdvOrani4"), dr_toplam("lKdvMatrahi4"), dr_toplam("lKdv4"), dr_toplam("nKdvOrani5"), dr_toplam("lKdvMatrahi5"), dr_toplam("lKdv5"), dr_toplam("lPesinat"), dr_toplam("nVadeFarkiYuzdesi"), dr_toplam("nVadeKdvOrani"), dr_toplam("lVadeKdvMatrahi"), dr_toplam("lVadeKdv"), dr_toplam("lVadeFarki"), dr_toplam("lNetTutar"), dr_toplam("sYaziIle"))
            End If
        Else
            tbAlisVeris_toplam_kaydet_degistir(nAlisVerisID, dr_toplam("nGirisCikis"), dr_toplam("lToplamMiktar"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), dr_toplam("nDipIskontoYuzdesi"), dr_toplam("lDipIskontoTutari"), dr_toplam("nKdvOrani1"), dr_toplam("lKdvMatrahi1"), dr_toplam("lKdv1"), dr_toplam("nKdvOrani2"), dr_toplam("lKdvMatrahi2"), dr_toplam("lKdv2"), dr_toplam("nKdvOrani3"), dr_toplam("lKdvMatrahi3"), dr_toplam("lKdv3"), dr_toplam("nKdvOrani4"), dr_toplam("lKdvMatrahi4"), dr_toplam("lKdv4"), dr_toplam("nKdvOrani5"), dr_toplam("lKdvMatrahi5"), dr_toplam("lKdv5"), dr_toplam("lPesinat"), dr_toplam("nVadeFarkiYuzdesi"), dr_toplam("nVadeKdvOrani"), dr_toplam("lVadeKdvMatrahi"), dr_toplam("lVadeKdv"), dr_toplam("lVadeFarki"), dr_toplam("lNetTutar"), dr_toplam("sYaziIle"))
        End If
        If bYeniFis = False Then
            lbl_Yekun.Text = FormatNumber(dr_toplam("lNetTutar"), 2)
        End If
        dr = Nothing
        dr1 = Nothing
        lMiktar = Nothing
        lMalbedeli = Nothing
        lMalIskontoTutari = Nothing
        nDipIskontoYuzdesi = Nothing
        lDipIskontoTutari = Nothing
        lPesinat = Nothing
        lNetTutar = Nothing
        If dr_toplam("lDipIskontoTutari1") <> 0 Then
            collIskontoTutari.OptionsColumn.ReadOnly = True
            colnIskontoYuzdesi.OptionsColumn.ReadOnly = True
        Else
            Try
                If Trim(dr_baslik("sFisTipi")) = "K" Or Trim(dr_baslik("sFisTipi")) = "SK" Then
                    If dr_param("bKrediMalIskontoVarmi") = False Then
                        colnIskontoYuzdesi.OptionsColumn.ReadOnly = True
                        colnIskontoYuzdesi.OptionsColumn.AllowEdit = False
                        collIskontoTutari.OptionsColumn.ReadOnly = True
                        collIskontoTutari.OptionsColumn.AllowEdit = False
                    Else
                        collIskontoTutari.OptionsColumn.ReadOnly = False
                        colnIskontoYuzdesi.OptionsColumn.ReadOnly = False
                    End If
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    If dr_param("bPesinMalIskontoVarmi") = False Then
                        colnIskontoYuzdesi.OptionsColumn.ReadOnly = True
                        colnIskontoYuzdesi.OptionsColumn.AllowEdit = False
                        collIskontoTutari.OptionsColumn.ReadOnly = True
                        collIskontoTutari.OptionsColumn.AllowEdit = False
                    Else
                        collIskontoTutari.OptionsColumn.ReadOnly = False
                        colnIskontoYuzdesi.OptionsColumn.ReadOnly = False
                    End If
                End If
            Catch ex As Exception
            End Try
        End If
        baslik_text_kontrol()
    End Sub
    Private Sub musteri_Sinif2_Guncelle(ByVal sinif2 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriSinifi SET sSinifKodu2 = '" & sinif2 & "' where nMusteriID = " & nMusteriID & "")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub baslik_text_kontrol()
        If dr_toplam("lToplamMiktar") > 0 Then
            If Trim(dr_baslik("sFisTipi")) = "K" Then
                Me.Text = "Kredili Satış"
            ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                Me.Text = "Sonradan Teslim Kredili Satış"
            ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                Me.Text = "Sonradan Teslim Peşin Satış"
            ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                Me.Text = "Peşin Satış"
            End If
        ElseIf dr_toplam("lToplamMiktar") <= 0 Then
            If Trim(dr_baslik("sFisTipi")) = "K" Then
                Me.Text = "Kredili Satış İade/Değişim"
            ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                Me.Text = "Sonradan Teslim Kredili Satış İade/Değişim"
            ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                Me.Text = "Sonradan Teslim Peşin Satışİade/Değişim"
            ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                Me.Text = "Peşin Satış İade/Değişim"
            End If
        End If
    End Sub
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
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim isk1 As Decimal = 0
            Dim isk2 As Decimal = 0
            Dim isk3 As Decimal = 0
            Dim isk4 As Decimal = 0
            Dim isk5 As Decimal = 0
            Dim isk6 As Decimal = 0
            Dim isk7 As Decimal = 0
            Dim isk8 As Decimal = 0
            Dim lMiktar As Decimal = 0
            Dim lFiyat As Decimal = 0
            Dim lGercekFiyat As Decimal = 0
            Dim lGercekToplam As Decimal = 0
            Dim lIsktutar As Decimal = 0
            Dim lkdvtutar As Decimal = 0
            dr.BeginEdit()
            If dr("lCikisMiktar1") > 10000000 Then
                dr("lCikisMiktar1") = 1
                XtraMessageBox.Show(Sorgu_sDil("Yanlış Miktar Bilgisi Lütfen Miktarı Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
                lMiktar = dr("lGirisMiktar1")
            ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
                lMiktar = dr("lCikisMiktar1")
            End If
            If GridView1.FocusedColumn.Name.ToString = collDovizMiktari1.Name.ToString Or GridView1.FocusedColumn.Name.ToString = collDovizKuru1.Name.ToString Then
                dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
                If dr("lDovizKuru1") <> 0 And dr("sDovizCinsi1") <> "" Then
                    dr("lBrutFiyat") = (dr("lDovizMiktari1") / lMiktar) * dr("lDovizKuru1")
                    dr("lBrutTutar") = dr("lBrutFiyat") * lMiktar
                Else
                    dr("lDovizKuru1") = 0
                    dr("lDovizMiktari1") = 0
                End If
            ElseIf GridView1.FocusedColumn.Name.ToString = collHDovizMiktari1.Name.ToString Or GridView1.FocusedColumn.Name.ToString = collDovizKuru1.Name.ToString Then
                dr("lDovizMiktari1") = dr("lHDovizMiktari1") * ((dr("nKdvOrani") + 100) / 100)
                If dr("lDovizKuru1") <> 0 And dr("sDovizCinsi1") <> "" Then
                    dr("lBrutFiyat") = (dr("lDovizMiktari1") / lMiktar) * dr("lDovizKuru1")
                    dr("lBrutTutar") = dr("lBrutFiyat") * lMiktar
                Else
                    dr("lDovizKuru1") = 0
                    dr("lDovizMiktari1") = 0
                End If
            End If
            'Hariç
            If GridView1.FocusedColumn.Name.ToString = collHBrutTutar.Name.ToString Then
                If dr("lHBrutTutar") = 0 Then
                    dr("lHBrutTutar") = 0.001
                    dr("lHBrutFiyat") = 0.001
                    dr("lMaliyetFiyat") = dr("lMaliyetFiyat")
                    dr("lMaliyetTutar") = dr("lMaliyetTutar") * dr("lCikisMiktar1")
                End If
                dr("lHBrutFiyat") = dr("lHBrutTutar") / dr("lCikisMiktar1")
                dr("lBrutFiyat") = dr("lHBrutFiyat") * ((dr("nKdvOrani") + 100) / 100)
                dr("lMaliyetFiyat") = dr("lMaliyetFiyat")
                dr("lMaliyetTutar") = dr("lMaliyetTutar") * dr("lCikisMiktar1")
            ElseIf GridView1.FocusedColumn.Name.ToString = collHBrutFiyat.Name.ToString Then
                If dr("lHBrutFiyat") = 0 Then
                    dr("lHBrutFiyat") = 0.001
                    dr("lHBrutTutar") = dr("lHBrutFiyat") * dr("lCikisMiktar1")
                    dr("lMaliyetFiyat") = dr("lMaliyetFiyat")
                    dr("lMaliyetTutar") = dr("lMaliyetTutar") * dr("lCikisMiktar1")
                End If
                dr("lHBrutTutar") = dr("lCikisMiktar1") * dr("lHBrutFiyat")
                dr("lBrutTutar") = dr("lHBrutTutar") * ((dr("nKdvOrani") + 100) / 100)
                dr("lBrutFiyat") = dr("lHBrutFiyat") * ((dr("nKdvOrani") + 100) / 100)
                dr("lMaliyetFiyat") = dr("lMaliyetFiyat")
                dr("lMaliyetTutar") = dr("lMaliyetTutar") * dr("lCikisMiktar1")
            End If
            'Dahil
            If GridView1.FocusedColumn.Name.ToString = collBrutTutar.Name.ToString Then
                If dr("lBrutTutar") = 0 Then
                    dr("lBrutTutar") = 0.001
                    dr("lBrutFiyat") = 0.001
                    dr("lMaliyetFiyat") = dr("lMaliyetFiyat")
                    dr("lMaliyetTutar") = dr("lMaliyetTutar") * dr("lCikisMiktar1")
                End If
                dr("lBrutFiyat") = dr("lBrutTutar") / dr("lCikisMiktar1")
                dr("lHBrutFiyat") = dr("lBrutFiyat") - dr("lIskontoTutari") / ((dr("nKdvOrani") + 100) / 100)
                dr("lMaliyetFiyat") = dr("lMaliyetFiyat")
                dr("lMaliyetTutar") = dr("lMaliyetTutar") * dr("lCikisMiktar1")
            Else
                If dr("lBrutFiyat") = 0 Then
                    dr("lBrutFiyat") = 0.001
                    dr("lBrutTutar") = dr("lBrutFiyat") * dr("lCikisMiktar1")
                    dr("lMaliyetFiyat") = dr("lMaliyetFiyat")
                    dr("lMaliyetTutar") = dr("lMaliyetTutar") * dr("lCikisMiktar1")
                End If
                dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
                dr("lHBrutTutar") = dr("lBrutTutar") / ((100 + dr("nKdvOrani")) / 100)
            End If
            dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
            dr("lHBrutTutar") = dr("lBrutTutar") / ((100 + dr("nKdvOrani")) / 100)

            If dr("lDovizKuru1") <> 0 And dr("sDovizCinsi1") <> "" Then
                dr("lDovizMiktari1") = dr("lBrutTutar") / dr("lDovizKuru1")
            Else
                dr("lDovizKuru1") = 0
                dr("lDovizMiktari1") = 0
            End If
            If dr("lCikisMiktar1") = 0 Then
                dr("lCikisMiktar1") = 1
                dr("nGirisCikis") = 3
            ElseIf dr("lCikisMiktar1") < 0 Then
                dr("nGirisCikis") = 4
            ElseIf dr("lCikisMiktar1") > 0 Then
                dr("nGirisCikis") = 3
            End If
            lFiyat = dr("lBrutFiyat")
            If GridView1.FocusedColumn.Name.ToString = collIskontoTutari.Name.ToString Then
                If dr("lIskontoTutari") <> 0 Then
                    dr("nIskontoYuzdesi") = dr("lIskontoTutari") / dr("lBrutTutar") * 100
                    If dr("nIskontoYuzdesi") > nMaxIskontoYuzdesi Then
                        dr("nIskontoYuzdesi") = nMaxIskontoYuzdesi
                    End If
                Else
                    dr("nIskontoYuzdesi") = 0
                End If
                isk1 = lFiyat * ((100 - dr("nIskontoYuzdesi")) / 100)
            Else
                If dr("nIskontoYuzdesi") > nMaxIskontoYuzdesi Then
                    dr("nIskontoYuzdesi") = nMaxIskontoYuzdesi
                End If
                isk1 = lFiyat * ((100 - dr("nIskontoYuzdesi")) / 100)
            End If
            isk2 = isk1 * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
            isk3 = isk2
            dr("nIskontoYuzdesi") = ((dr("lBrutFiyat") - isk1) / dr("lBrutFiyat")) * 100
            lGercekFiyat = isk3
            lGercekToplam = isk3 * lMiktar
            lIsktutar = (lFiyat * lMiktar) - lGercekToplam
            lkdvtutar = (lGercekToplam * (dr("nKdvOrani") / 100))
            'MsgBox(lGercekToplam)
            'If GridView1.FocusedColumn.Name.ToString = collBrutTutar.Name.ToString Then
            '    dr("lBrutFiyat") = dr("lBrutTutar") / dr("lCikisMiktar1")
            'Else
            '    dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
            'End If
            'dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
            If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
                dr("lGirisFiyat") = lGercekFiyat / ((100 + dr("nKdvOrani")) / 100)
                dr("lGirisTutar") = lGercekToplam / ((100 + dr("nKdvOrani")) / 100)
                dr("lCikisFiyat") = 0
                dr("lCikisTutar") = 0
            ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
                dr("lGirisFiyat") = 0
                dr("lGirisTutar") = 0
                dr("lCikisFiyat") = lGercekFiyat / ((100 + dr("nKdvOrani")) / 100)
                dr("lCikisTutar") = lGercekToplam / ((100 + dr("nKdvOrani")) / 100)
            End If
            dr("lIskontoTutari") = dr("lBrutTutar") - lGercekToplam
            'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
            'dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
            dr("dteSonUpdateTarihi") = dr_baslik("dteFaturaTarihi") + " " + Now.ToLongTimeString
            If GridView1.FocusedColumn.Name.ToString = collPrimTutari.Name.ToString Then
                If dr("lPrimTutari") <> 0 Then
                    Try
                        dr("nPrim") = (dr("lPrimTutari") / dr("lHBrutTutar")) * 100
                    Catch ex As Exception
                        dr("nPrim") = 0
                    End Try
                End If
            Else
                'Burasıo

                dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
            End If
            If dr("lPrimTutari") = 0 Then
                dr("nPrim") = sSaticiRumuzu_nPrim(dr("sSaticiRumuzu"))
                dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
            End If
            dr.EndEdit()
            Try
                If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    tbAlisVerisSiparis_kaydet_duzelt(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), dr("nPrim"), dr("lPrimTutari"))
                Else
                    tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))
                End If
            Catch ex As Exception
            End Try
            satir_info()
            toplam_hesapla()
            dr = Nothing
            isk1 = Nothing
            isk2 = Nothing
            isk3 = Nothing
            isk4 = Nothing
            isk5 = Nothing
            isk6 = Nothing
            isk7 = Nothing
            isk8 = Nothing
            lMiktar = Nothing
            lFiyat = Nothing
            lGercekFiyat = Nothing
            lGercekToplam = Nothing
            lIsktutar = Nothing
            lkdvtutar = Nothing
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim İ As Integer
        İ = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For İ = 1 To TOPLAM
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            tutar_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        İ = Nothing
    End Sub
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.nMusteriID, tbAlisVeris.sMagaza, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.sHareketTipi, tbAlisVeris.bMuhasebeyeIslendimi, tbAlisVeris.nKasaNo, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisVeris.sYaziIle, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl, tbAlisVerisAdres.sUlke, tbAlisVerisAdres.sPostaKodu, tbAlisVerisAdres.sVergiDairesi, tbAlisVerisAdres.sVergiNo, tbAlisVerisAdres.sSubeMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri,tbMusteri.sGsm,tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu,tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,(SELECT      CAST(bSatismi AS integer) AS bSatismi FROM          tbFisTipi WHERE      sFisTipi = tbAlisVeris.sFisTipi) AS nGCT,tbMusteri.nIskontoPesin,tbMusteri.nIskontoKredili FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID WHERE (tbAlisVeris.nAlisverisID = '" & nAlisVerisID & "')")
        If (sFisTipi = "K") Or (sFisTipi = "P") Or (sFisTipi = "SP") Or (sFisTipi = "SK") Then
            If sDatabaseGenel = "UGURLU" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.nMusteriID, tbAlisVeris.Sinif2, tbAlisVeris.sMagaza, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.sHareketTipi, tbAlisVeris.bMuhasebeyeIslendimi, tbAlisVeris.nKasaNo, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisVeris.sYaziIle, ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl, tbAlisVerisAdres.sUlke, tbAlisVerisAdres.sPostaKodu, tbAlisVerisAdres.sVergiDairesi, tbAlisVerisAdres.sVergiNo, tbAlisVerisAdres.sSubeMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbMusteri.sGSM, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2,tbMusteri.sEvSemt,tbMusteri.sEvIl,tbMusteri.sEvPostaKodu,tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu, tbMusteri.dteDogumTarihi AS DOGUMTARIHI, tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI, (SELECT CAST(bSatismi AS integer) AS bSatismi FROM tbFisTipi WHERE sFisTipi = tbAlisVeris.sFisTipi) AS nGCT, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, ISNULL(tbMusteriKredisi.lKrediLimiti, 0) AS lKrediLimiti, ISNULL(tbMusteriKredisi.dteSonKullanmaTarihi, '31/12/2078') AS dteSonKullanmaTarihi,tbMusteri.sEhliyetNo,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT,tbMusteriNufusu.sCuzdanKayitNo FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbMusteriKredisi ON tbMusteri.nMusteriID = tbMusteriKredisi.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID LEFT OUTER JOIN tbMusteriNufusu ON tbMusteri.nMusteriID = tbMusteriNufusu.nMusteriID WHERE (tbAlisVeris.nAlisverisID = '" & nAlisVerisID & "')")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.nMusteriID, tbAlisVeris.sMagaza, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.sHareketTipi, tbAlisVeris.bMuhasebeyeIslendimi, tbAlisVeris.nKasaNo, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisVeris.sYaziIle, ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl, tbAlisVerisAdres.sUlke, tbAlisVerisAdres.sPostaKodu, tbAlisVerisAdres.sVergiDairesi, tbAlisVerisAdres.sVergiNo, tbAlisVerisAdres.sSubeMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbMusteri.sGSM, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2,tbMusteri.sEvSemt,tbMusteri.sEvIl,tbMusteri.sEvPostaKodu,tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu, tbMusteri.dteDogumTarihi AS DOGUMTARIHI, tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI, (SELECT CAST(bSatismi AS integer) AS bSatismi FROM tbFisTipi WHERE sFisTipi = tbAlisVeris.sFisTipi) AS nGCT, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, ISNULL(tbMusteriKredisi.lKrediLimiti, 0) AS lKrediLimiti, ISNULL(tbMusteriKredisi.dteSonKullanmaTarihi, '31/12/2078') AS dteSonKullanmaTarihi,tbMusteri.sEhliyetNo,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT,tbMusteriNufusu.sCuzdanKayitNo FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbMusteriKredisi ON tbMusteri.nMusteriID = tbMusteriKredisi.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID LEFT OUTER JOIN tbMusteriNufusu ON tbMusteri.nMusteriID = tbMusteriNufusu.nMusteriID WHERE (tbAlisVeris.nAlisverisID = '" & nAlisVerisID & "')")
            End If
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.nMusteriID, tbAlisVeris.sMagaza, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.sHareketTipi, tbAlisVeris.bMuhasebeyeIslendimi, tbAlisVeris.nKasaNo, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisVeris.sYaziIle, ISNULL(tbAlisVeris.sMuhasebeFaturalasma, '') as sMuhasebeFaturalasma, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl, tbAlisVerisAdres.sUlke, tbAlisVerisAdres.sPostaKodu, tbAlisVerisAdres.sVergiDairesi, tbAlisVerisAdres.sVergiNo, tbAlisVerisAdres.sSubeMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbMusteri.sGSM, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2,tbMusteri.sEvSemt,tbMusteri.sEvIl,tbMusteri.sEvPostaKodu,tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu, tbMusteri.dteDogumTarihi AS DOGUMTARIHI, tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI, (SELECT CAST(bSatismi AS integer) AS bSatismi FROM tbFisTipi WHERE sFisTipi = tbAlisVeris.sFisTipi) AS nGCT, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, ISNULL(tbMusteriKredisi.lKrediLimiti, 0) AS lKrediLimiti, ISNULL(tbMusteriKredisi.dteSonKullanmaTarihi, '31/12/2078') AS dteSonKullanmaTarihi,tbMusteri.sEhliyetNo,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT,tbMusteriNufusu.sCuzdanKayitNo FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbMusteriKredisi ON tbMusteri.nMusteriID = tbMusteriKredisi.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID LEFT OUTER JOIN tbMusteriNufusu ON tbMusteri.nMusteriID = tbMusteriNufusu.nMusteriID WHERE (tbAlisVeris.nAlisverisID = '" & nAlisVerisID & "')")
        End If
        sorgu_txt_baslik = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Function sorgu_stok_info(ByVal stokkodu As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(SUM(hareket.lGirisMiktar1), 0) AS MONEY) AS  GIREN, CAST(ISNULL(SUM(hareket.lCikisMiktar1), 0) AS MONEY) AS CIKAN, CAST(ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS MONEY) AS KALAN, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, 0 AS BEKLEYEN, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = Stok.sRenk) AS sRenkAdi FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID WHERE (stok.sKodu = '" & stokkodu & "') AND (hareket.sFisTipi <> 'T') GROUP BY stok.nStokID, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, CAST(SUM(TS.GIREN) AS MONEY) AS  GIREN, CAST(SUM(TS.CIKAN) AS MONEY) AS CIKAN, CAST(SUM(TS.KALAN) AS MONEY) AS KALAN, CAST(SUM(TS.BEKLEYEN) AS MONEY) AS  BEKLEYEN, tbRenk.sRenkAdi FROM (SELECT sAciklama , SUM(GIREN) AS GIREN , SUM(CIKAN) AS CIKAN , SUM(KALAN) AS KALAN , SUM(BEKLEYEN) AS BEKLEYEN , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel FROM (SELECT depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = '" & stokkodu & "') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY depo.sAciklama , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID WHERE (stok.sKodu = '" & stokkodu & "' and hareket.sFistipi <> 'T') GROUP BY depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sAciklama , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel) TS INNER JOIN tbRenk ON TS.sRenk COLLATE Turkish_CI_AS = tbRenk.sRenk GROUP BY TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, tbRenk.sRenkAdi")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Function sorgu_toplam(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nAlisverisID, nGirisCikis,lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2,lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat,nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar,sYaziIle,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_KAZ' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lKazanilanPuan, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_HAR' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lHarcananPuan FROM         tbAlisVeris where nAlisVerisID = '" & nAlisVerisID & "' ")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi = CASE WHEN lMalBedeli <> 0 THEN (lDipIskontoTutari - lHarcananPuan) / lMalBedeli ELSE 0 END, lDipIskontoTutari - lHarcananPuan AS lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, lKazanilanPuan, lHarcananPuan FROM (SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_KAZ' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lKazanilanPuan, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_HAR' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lHarcananPuan FROM tbAlisVeris WHERE (nAlisverisID = '" & nAlisVerisID & "')) tbToplam ")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, lMalArtisTutari, nDipIskontoYuzdesi1 = CASE WHEN (lMalBedeli-lMalIskontoTutari) <> 0 THEN (lDipIskontoTutari - lHarcananPuan) / (lMalBedeli-lMalIskontoTutari) * 100 ELSE 0 END, lDipIskontoTutari - lHarcananPuan AS lDipIskontoTutari1, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, lKazanilanPuan, lHarcananPuan, nDipIskontoYuzdesi, lDipIskontoTutari FROM (SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, lMalArtisTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_KAZ' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lKazanilanPuan, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_HAR' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lHarcananPuan FROM tbAlisVeris WHERE (nAlisverisID = '" & nAlisVerisID & "')) tbToplam ")
        sorgu_txt_toplam = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TOPLAM")
        con.Close()
        Return DS
    End Function
    Private Function sorgu_harekets(ByVal sFisTipi As String, ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.nAlisverisID, tbAlisverisSiparis.sMagazaKodu, tbAlisverisSiparis.nSiparisID, tbAlisverisSiparis.nGirisCikis, tbAlisverisSiparis.nStokID, tbAlisverisSiparis.sKasiyerRumuzu, tbAlisverisSiparis.sSaticiRumuzu, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.lReyonFisNo, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.lGCMiktar AS lCikisMiktar1, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.lBrutFiyat / ((100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lHBrutFiyat, tbAlisverisSiparis.lBrutTutar / ((100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lHBrutTutar,tbAlisverisSiparis.lDovizMiktari1 / ((100 + tbAlisverisSiparis.nKdvOrani) / 100) AS lHDovizMiktari1,tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari, tbAlisverisSiparis.lFiyat AS lCikisFiyat, 0 as lGirisFiyat,0 as lGirisTutar, tbAlisverisSiparis.lTutar AS lCikisTutar, tbAlisverisSiparis.nKdvOrani, tbAlisverisSiparis.sIadeNedeni, tbAlisverisSiparis.nPartiID,tbAlisVerisSiparis.nStokIslemID, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisverisSiparis.dteTeslimEdilen, tbAlisverisSiparis.bTeslimEdildi, tbAlisverisSiparis.bMuhasebeyeIslendimi, tbAlisverisSiparis.sAciklama, tbAlisverisSiparis.bEkSoru, tbAlisverisSiparis.bEkAlan1, tbAlisverisSiparis.bEkAlan2, tbAlisverisSiparis.sDovizCinsi1, tbAlisverisSiparis.lDovizMiktari1, tbAlisverisSiparis.lDovizKuru1, tbAlisverisSiparis.sSonKullaniciAdi, tbAlisverisSiparis.dteSonUpdateTarihi, tbAlisverisSiparis.dteOnayTarihi, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbStok.sKisaAdi,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sBeden, tbStok.sKavala,tbStok.sBirimCinsi1, tbStok.sModel,tbAlisVerisSiparis.nPrim,tbAlisVerisSiparis.lPrimTutari FROM tbAlisverisSiparis INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID Where tbAlisVerisSiparis.nAlisverisID = '" & nAlisVerisID & "' ORDER BY tbAlisVerisSiparis.nSiparisID")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,tbStok.sModel,tbStok.sKisaAdi,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStok.sKavala,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari,tbStokFisiDetayi.lBrutFiyat / ((100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lHBrutFiyat, tbStokFisiDetayi.lBrutTutar / ((100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lHBrutTutar,tbStokFisiDetayi.lDovizMiktari1 / ((100 + tbStokFisiDetayi.nKdvOrani) / 100) AS lHDovizMiktari1 FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE     (tbStokFisiDetayi.nAlisverisID = '" & nAlisVerisID & "') ORDER BY tbStokFisiDetayi.nIslemID")
        End If
        sorgu_txt_hareket = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Public Function sorgu_nStokID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgula_nStokID(ByVal query As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String) As Int64
        Dim kriter
        kriter = "WHERE (nAlisVerisID = '" & nAlisVerisID & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
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
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisAdres_kaydet_degistir(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVerisAdres SET              sAciklama = N'" & sAciklama & "', sAdres1 = '" & sAdres1 & "', sAdres2 = '" & sAdres2 & "', sSemt = '" & sSemt & "', sIl = '" & sIl & "', sUlke = '" & sUlke & "', sPostaKodu = '" & sPostaKodu & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', sSubeMagaza = '" & sSubeMagaza & "' WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVeris_kaydet_yeni(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal sOdemeKodu As String, ByVal lNetTutar As Decimal, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Integer, ByVal nKasaNo As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVeris (nAlisverisID, sFisTipi, dteFaturaTarihi, nGirisCikis, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAlisverisYapanAdi, sAlisverisYapanSoyadi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, sOdemeKodu, lNetTutar, sHareketTipi, bMuhasebeyeIslendimi, nKasaNo, sKullaniciAdi, dteKayitTarihi, sYaziIle) VALUES     ('" & nAlisverisID & "', '" & sFisTipi & "', '" & dteFaturaTarihi & "', " & nGirisCikis & ", '" & lFaturaNo & "', " & nMusteriID & ", '" & sMagaza & "', '" & sKasiyerRumuzu & "', '" & sAlisverisYapanAdi & "', '" & sAlisverisYapanSoyadi & "', " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & nDipIskontoYuzdesi & ", " & lDipIskontoTutari & ", " & nKdvOrani1 & ", " & lKdvMatrahi1 & ", " & lKdv1 & ", " & nKdvOrani2 & ", " & lKdvMatrahi2 & ", " & lKdv2 & ", " & nKdvOrani3 & ", " & lKdvMatrahi3 & ", " & lKdv3 & ", " & nKdvOrani4 & ", " & lKdvMatrahi4 & ", " & lKdv4 & ", " & nKdvOrani5 & ", " & lKdvMatrahi5 & ", " & lKdv5 & ", " & lPesinat & ", " & nVadeFarkiYuzdesi & ", " & nVadeKdvOrani & ", " & lVadeKdvMatrahi & ", " & lVadeKdv & ", " & lVadeFarki & ", '" & sOdemeKodu & "', " & lNetTutar & ", '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKullaniciAdi & "',  '" & dteKayitTarihi & "', '" & sYaziIle & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function sonKullaniciUpdate()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim sorgu As String = ""
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            If Trim(perakendeSKasiyer) = "" Then
                sorgu = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET sMuhasebeFaturalasma = '" & dr_baslik("sMuhasebeFaturalasma").ToString() & "', sKullaniciUpdate = 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "' WHERE (lFaturaNo = '" & dr_baslik("lFaturaNo") & "') AND (nAlisverisID = '" & dr_baslik("nAlisverisID") & "')"
            Else
                sorgu = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET sMuhasebeFaturalasma = '" & dr_baslik("sMuhasebeFaturalasma").ToString() & "', sKullaniciUpdate = 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & ", Kasiyer: " & perakendeSKasiyer & ", Rumuz: " & perakendeSKasiyerRumuzu & "' WHERE (lFaturaNo = '" & dr_baslik("lFaturaNo") & "') AND (nAlisverisID = '" & dr_baslik("nAlisverisID") & "')"
            End If
            cmd.CommandText = sorgu_query(sorgu)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Son Kullanıcı Kayıt Edilemedi.", "Business Smart")
        End Try
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
    Dim trd As Threading.Thread
    Private Sub tbAlisVeris_kaydet_sil()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        trd = New Threading.Thread(AddressOf tbAlisVeris_kaydet_silme)
        trd.IsBackground = True
        trd.Start()
    End Sub
    Private Sub tbAlisVeris_kaydet_silme()
        Dim bDevam As Boolean = True
        Dim sFisTipiC As String = ""
        Try
            If IsDBNull(dr_baslik("sFisTipi")) Then
                sFisTipiC = ""
            Else
                sFisTipiC = dr_baslik("sFisTipi")
            End If
        Catch ex As Exception
            sFisTipiC = ""
        End Try
        If Trim(sFisTipiC) = "SK" Or Trim(sFisTipiC) = "SP" Then
            For Each dr In ds_hareket.Tables(0).Rows
                If bDevam = True Then
                    If sorgu_sayi(dr("nStokIslemID").ToString, 0) = 0 Then
                    Else
                        bDevam = False
                    End If
                End If
            Next
        End If
        If bDevam = True Then
            Dim con As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim lOdemeTutar As Decimal = 0
            cmd.Connection = con
            con.ConnectionString = connection
            cmd.CommandTimeout = False
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lOdemeTutar FROM tbAlisVeris INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu =2) and (tbAlisVeris.nAlisverisID = '" & nAlisVerisID & "') OR (tbOdeme.nIadeAlisverisID = '" & nAlisVerisID & "') ")
            lOdemeTutar = cmd.ExecuteScalar
            If lOdemeTutar = 0 Then
                Try
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("set implicit_transactions off")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAVPromosyonIndirim where nAlisverisID = '" & nAlisVerisID & "' ")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count (a.nTaksitID) from tbTaksit a , tbOdeme b where a.nTaksitID=b.nTaksitID and a.nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("set implicit_transactions on")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSlip set bIptalmi = 0  where nAlisverisID =  ( Select top 1 nIadeAlisverisID from tbOdeme where nIadeAlisverisID <> ''    and nAlisverisID = '" & nAlisVerisID & "')")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAVKartTaksit where nOdemeID in ( select nOdemeID from tbOdeme where nAlisverisID =  '" & nAlisVerisID & "' )")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbOdeme where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbTaksit where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriPara set lPara = lPara - isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisVerisID & "' and sHediyeCekiTipi = 'ParaPU_KAZ'), 0)  + isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisVerisID & "' and sHediyeCekiTipi = 'ParaPU_HAR'), 0)  where nMusteriID in (select nMusteriID from tbAlisveris where nAlisverisID = '" & nAlisVerisID & "')")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAVIndirimKuponu set bKapandimi = 0 where sAlinanBasilan = 'B' and sKuponSeriNo in (select sKuponSeriNo from tbAVIndirimKuponu where sAlinanBasilan = 'A'  and nAlisverisID = '" & nAlisVerisID & "')")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAVIndirimKuponu where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbStokFisiDetayi where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAlisverisSiparis where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAVHediyeCeki where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAlisverisSlip where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAlisVerisAdres where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("delete tbAlisVeris where nAlisverisID = '" & nAlisVerisID & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                    cmd.ExecuteNonQuery()
                    'If bFisYenimi = True Then
                    '    cmd.CommandText = sorgu_query("DELETE FROM         auAlisVeris WHERE     (nKayitTipi = 3) AND (nAlisverisID = '" & nAlisverisID & "')")
                    '    cmd.ExecuteNonQuery()
                    'End If
                    For Each dr In ds_hareket.Tables(0).Rows
                        If Microsoft.VisualBasic.Left(dr("sAciklama"), 4) = "Iade" Then
                            Dim strArr() As String
                            Dim str As String
                            Dim count As Integer
                            Dim sIadeMagazasi As String = ""
                            str = dr("sAciklama")
                            strArr = str.Split(";")
                            For count = 0 To strArr.Length - 1
                                If count = 1 Then
                                    sIadeMagazasi = Trim(strArr(count))
                                End If
                            Next
                            tbAlisVerisSiparis_iade_kaydet_duzelt(sIadeMagazasi, dr("bEkAlan2"), dr("nStokID"), dr("sIadeNedeni"), "01/01/1900", 0, "Iade;" & dr("sMagazaKodu") & ";" & dr("nSiparisID") & ";" & dr("sKasiyerRumuzu"), 0, 0, dr("bEkAlan2"), "01/01/1900")
                        End If
                    Next
                    ds_hareket.Clear()
                Catch ex As Exception
                    cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                XtraMessageBox.Show(Sorgu_sDil("Ödeme Alınmış Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
            TermalYazdir_iptal()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Satış Satır/larında Teslimatı Yapılmış Ürünler var. Fiş Silme İşlemi Yapamazsınız...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub tbAlisVeris_Depo_Degistir(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal sMagaza As String, ByVal sMagazaYeni As String)
        Dim bDevam As Boolean = True
        If bDevam = True Then
            Dim con As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim lOdemeTutar As Decimal = 0
            cmd.Connection = con
            con.ConnectionString = connection
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            If lOdemeTutar = 0 Then
                Try
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("set implicit_transactions off")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  select count(nAlisverisID) from tbAlisveris  Where sMagaza = '" & sMagaza & "' and        nAlisverisID = '" & nAlisverisID & "' ")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("set implicit_transactions on")
                    cmd.ExecuteNonQuery()
                    If Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbAlisverisSiparis set sMagazaKodu = '" & sMagazaYeni & "' where sMagazaKodu = '" & sMagaza & "' and     isnull(tbAlisverisSiparis.nStokIslemID,0) = 0 and   nAlisverisID = '" & nAlisverisID & "'  ")
                        cmd.ExecuteNonQuery()
                    Else
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFisiDetayi set sDepo = '" & sMagazaYeni & "' where sDepo = '" & sMagaza & "' and  nAlisverisID = '" & nAlisverisID & "' ")
                        cmd.ExecuteNonQuery()
                    End If
                    cmd.CommandText = sorgu_query("update tbOdeme set sMagaza = '" & sMagazaYeni & "' where sMagaza = '" & sMagaza & "' and    nOdemeKodu <> 2 and   nAlisverisID = '" & nAlisverisID & "' ")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("update tbOdeme set sMagaza = '" & sMagazaYeni & "' where sMagaza = '" & sMagaza & "' and      nOdemeKodu = 2 and        nAlisverisID = '" & nAlisverisID & "' ")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("update tbAlisveris set sMagaza = '" & sMagazaYeni & "' where sMagaza = '" & sMagaza & "' and  nAlisverisID = '" & nAlisverisID & "' ")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                    cmd.ExecuteNonQuery()
                    XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                XtraMessageBox.Show(Sorgu_sDil("Ödeme Alınmış Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Satış Satır/larında Teslimatı Yapılmış Ürünler var. Fiş Silme İşlemi Yapamazsınız...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub tbAlisVeris_kaydet_degistir(ByVal nAlisVerisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVeris SET              sAlisverisYapanAdi = '" & sAlisverisYapanAdi & "', sAlisverisYapanSoyadi = '" & sAlisverisYapanSoyadi & "' WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVeris SET              sFisTipi = '" & sFisTipi & "', dteFaturaTarihi = '" & dteFaturaTarihi & "', nGirisCikis = " & nGirisCikis & ", lFaturaNo = '" & lFaturaNo & "', sAlisverisYapanAdi = '" & sAlisverisYapanAdi & "',  sAlisverisYapanSoyadi = '" & sAlisverisYapanSoyadi & "' WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.ExecuteNonQuery()
        'If bFisYenimi = True Then
        '    cmd.CommandText = sorgu_query("DELETE FROM         auAlisVeris WHERE     (nKayitTipi = 2) AND (nAlisverisID = '" & nAlisVerisID & "')")
        '    cmd.ExecuteNonQuery()
        'End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVeris_detay_kaydet_degistir(ByVal nAlisVerisID As String, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As String, ByVal dteIslemTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVeris SET              sAlisverisYapanAdi = '" & sAlisverisYapanAdi & "', sAlisverisYapanSoyadi = '" & sAlisverisYapanSoyadi & "' WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', nGirisCikis = " & nGirisCikis & ", lFisNo = '" & lFisNo & "', dteIslemTarihi = '" & dteIslemTarihi & "' WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVeris_toplam_kaydet_degistir(ByVal nAlisVerisID As String, ByVal nGirisCikis As Int64, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal lNetTutar As Decimal, ByVal sYaziIle As String, Optional ByVal sinif2 As String = "")
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If (sFisTipi = "K") Or (sFisTipi = "P") Or (sFisTipi = "SP") Or (sFisTipi = "SK") Then
            If sDatabaseGenel = "UGURLU" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET sinif2 = '" & sinif2 & "', nGirisCikis = " & nGirisCikis & ",lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi = " & nDipIskontoYuzdesi & ", lDipIskontoTutari = " & lDipIskontoTutari & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lPesinat = " & lPesinat & ", nVadeFarkiYuzdesi = " & nVadeFarkiYuzdesi & ", nVadeKdvOrani = " & nVadeKdvOrani & ", lVadeKdvMatrahi = " & lVadeKdvMatrahi & ", lVadeKdv = " & lVadeKdv & ", lVadeFarki = " & lVadeFarki & ", lNetTutar = " & lNetTutar & ", sYaziIle = '" & sYaziIle & "'  WHERE nAlisVerisID = '" & nAlisVerisID & "'")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET nGirisCikis = " & nGirisCikis & ",lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi = " & nDipIskontoYuzdesi & ", lDipIskontoTutari = " & lDipIskontoTutari & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lPesinat = " & lPesinat & ", nVadeFarkiYuzdesi = " & nVadeFarkiYuzdesi & ", nVadeKdvOrani = " & nVadeKdvOrani & ", lVadeKdvMatrahi = " & lVadeKdvMatrahi & ", lVadeKdv = " & lVadeKdv & ", lVadeFarki = " & lVadeFarki & ", lNetTutar = " & lNetTutar & ", sYaziIle = '" & sYaziIle & "'  WHERE nAlisVerisID = '" & nAlisVerisID & "'")
            End If
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET nGirisCikis = " & nGirisCikis & ",lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi = " & nDipIskontoYuzdesi & ", lDipIskontoTutari = " & lDipIskontoTutari & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lPesinat = " & lPesinat & ", nVadeFarkiYuzdesi = " & nVadeFarkiYuzdesi & ", nVadeKdvOrani = " & nVadeKdvOrani & ", lVadeKdvMatrahi = " & lVadeKdvMatrahi & ", lVadeKdv = " & lVadeKdv & ", lVadeFarki = " & lVadeFarki & ", lNetTutar = " & lNetTutar & ", sYaziIle = '" & sYaziIle & "'  WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        End If
        cmd.ExecuteNonQuery()
        'If bFisYenimi = True Then
        '    cmd.CommandText = sorgu_query("DELETE FROM         auAlisVeris WHERE     (nKayitTipi = 2) AND (nAlisverisID = '" & nAlisVerisID & "')")
        '    cmd.ExecuteNonQuery()
        'End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbMusteri_kaydet_yeni(ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteri (sMagaza, lKodu, sAdi, sSoyadi, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsIl, sIsPostaKodu, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, sHitap, sKullaniciAdi, dteKayitTarihi, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sGSM, sFax, sResimAdi) VALUES     ('" & sMagaza & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", " & lAylikGelir & ", '" & dteKartAcilisTarihi & ", " & nIskontoPesin & ", " & nIskontoKredili & ", '" & sUnvan & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bYazismaEvAdresinemi & ", '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsIl & "', '" & sIsPostaKodu & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sSigortaNo & "', " & bEvlimi & ", '" & dteEvlilikTarihi & "', '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sEhliyetNo & "', '" & sKanGrubu & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sGSM & "', '" & sFax & "', '" & sResimAdi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbtbAVHediyeCeki_kaydet_yeni(ByVal nAlisverisID As String, ByVal sAlinanBasilan As String, ByVal sHediyeCekiSeriNo As String, ByVal sHediyeCekiTipi As String, ByVal lTutar As Decimal, ByVal dteGecerliBaslangicTarih As DateTime, ByVal dteGecerliBitisTarih As DateTime, ByVal lUzerindekiTutar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAVHediyeCeki (nAlisverisID, sAlinanBasilan, sHediyeCekiSeriNo, sHediyeCekiTipi, lTutar, dteGecerliBaslangicTarih, dteGecerliBitisTarih, lUzerindekiTutar) VALUES     ('" & nAlisverisID & "', '" & sAlinanBasilan & "', '" & sHediyeCekiSeriNo & "', '" & sHediyeCekiTipi & "', " & lTutar & ", '" & dteGecerliBaslangicTarih & "', '" & dteGecerliBitisTarih & "', " & lUzerindekiTutar & ") ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbtbAVHediyeCeki_kaydet_duzelt(ByVal nAlisverisID As String, ByVal sAlinanBasilan As String, ByVal sHediyeCekiSeriNo As String, ByVal sHediyeCekiTipi As String, ByVal lTutar As Decimal, ByVal dteGecerliBaslangicTarih As DateTime, ByVal dteGecerliBitisTarih As DateTime, ByVal lUzerindekiTutar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVHediyeCeki SET              sAlinanBasilan = '" & sAlinanBasilan & "', sHediyeCekiSeriNo = '" & sHediyeCekiSeriNo & "', sHediyeCekiTipi = '" & sHediyeCekiTipi & "',  lTutar = " & lTutar & ", dteGecerliBaslangicTarih = '" & dteGecerliBaslangicTarih & "', dteGecerliBitisTarih = '" & dteGecerliBitisTarih & "', lUzerindekiTutar = " & lUzerindekiTutar & " Where nAlisverisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbMusteriSinifi_kaydet_yeni(ByVal nMusteriID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriSinifi (nMusteriID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nMusteriID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisSiparis_kaydet_yeni(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As Int64, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Decimal, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal bMuhasebeyeIslendimi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal dteOnayTarihi As DateTime, ByVal nPrim As Decimal, ByVal lPrimTutari As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim sayi As New Integer
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select count(*) from tbAlisverisSiparis where nSiparisID = " & nSiparisID & "")
        sayi = Integer.Parse(cmd.ExecuteScalar.ToString())
        If sayi > 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select max(nSiparisID) + 1 from tbAlisverisSiparis where sMagazaKodu = '" & sMagazaKodu & "'")
            nSiparisID = Integer.Parse(cmd.ExecuteScalar.ToString())
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisverisSiparis (nAlisverisID, sMagazaKodu, nSiparisID, nGirisCikis, nStokID, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, lReyonFisNo, sFiyatTipi, lGCMiktar, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, nKdvOrani, sIadeNedeni, nPartiID, dteTeslimEdilecek, dteTeslimEdilen, bTeslimEdildi, bMuhasebeyeIslendimi, sAciklama, bEkSoru, bEkAlan1, bEkAlan2, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sSonKullaniciAdi, dteSonUpdateTarihi, dteOnayTarihi,nPrim,lPrimTutari) VALUES     ('" & nAlisverisID & "', '" & sMagazaKodu & "', " & nSiparisID & ", " & nGirisCikis & ", " & nStokID & ", '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', " & lReyonFisNo & ", '" & sFiyatTipi & "', " & lGCMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", " & lFiyat & ", " & lTutar & ", " & nKdvOrani & ", '" & sIadeNedeni & "', " & nPartiID & ", '" & dteTeslimEdilecek & "', '" & dteTeslimEdilen & "', " & bTeslimEdildi & ", " & bMuhasebeyeIslendimi & ", N'" & sAciklama & "', " & bEkSoru & ", " & bEkAlan1 & ", '" & bEkAlan2 & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & dteOnayTarihi & "'," & nPrim & "," & lPrimTutari & ") ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisSiparis_kaydet_sil(ByVal nAlisverisID As String, ByVal nSiparisID As Int64, ByVal sMagazaKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbAlisverisSiparis Where nSiparisID = " & nSiparisID & " and nAlisVerisID ='" & nAlisverisID & "' and sMagazaKodu = '" & sMagazaKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisSiparis_kaydet_duzelt(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As Int64, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Decimal, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal bMuhasebeyeIslendimi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal dteOnayTarihi As DateTime, ByVal nPrim As Decimal, ByVal lPrimTutari As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              nGirisCikis = " & nGirisCikis & ",sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', lReyonFisNo = " & lReyonFisNo & ", sFiyatTipi = '" & sFiyatTipi & "', lGCMiktar = " & lGCMiktar & ", lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", lFiyat = " & lFiyat & ", lTutar = " & lTutar & ", nKdvOrani = " & nKdvOrani & ", sIadeNedeni = '" & sIadeNedeni & "', nPartiID = " & nPartiID & ", dteTeslimEdilecek = '" & dteTeslimEdilecek & "', dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sAciklama = N'" & sAciklama & "', bEkSoru = " & bEkSoru & ", bEkAlan1 = " & bEkAlan1 & ", bEkAlan2 = '" & bEkAlan2 & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "', dteOnayTarihi = '" & dteOnayTarihi & "',nPrim = " & nPrim & ",lPrimTutari = " & lPrimTutari & " Where nSiparisID = " & nSiparisID & " AND nAlisVerisID = '" & nAlisverisID & "' AND sMagazaKodu ='" & sMagazaKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisSiparis_iade_kaydet_duzelt(ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nStokID As Int64, ByVal sIadeNedeni As String, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal dteOnayTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If dteTeslimEdilen = "01/01/1900" Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", bEkAlan1 = " & bEkAlan1 & ", sAciklama = '' WHERE     (nSiparisID = " & nSiparisID & ") AND (sMagazaKodu = '" & sMagazaKodu & "') and (nStokID = " & nStokID & ") and (sAciklama like 'Iade%')")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", bEkAlan1 = " & bEkAlan1 & ", sAciklama = '' WHERE     (nSiparisID = " & nSiparisID & ") /*AND (sMagazaKodu = '" & sMagazaKodu & "')*/ and (nStokID = " & nStokID & ") and (sAciklama like 'Iade%')")
        Else
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", bEkAlan1 = " & bEkAlan1 & ", sAciklama = '" & sAciklama & "' WHERE     (nSiparisID = " & nSiparisID & ") AND (sMagazaKodu = '" & sMagazaKodu & "') and (nStokID = " & nStokID & ")")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", bEkAlan1 = " & bEkAlan1 & ", sAciklama = '" & sAciklama & "' WHERE     (nSiparisID = " & nSiparisID & ") /*AND (sMagazaKodu = '" & sMagazaKodu & "')*/ and (nStokID = " & nStokID & ")")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal nPrim As Decimal, ByVal lPrimTutari As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "'," & nPrim & "," & lPrimTutari & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisidetay_kaydet_degistir(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal nPrim As Decimal, ByVal lPrimTutari As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET               nStokID = '" & nStokID & "', dteIslemTarihi = '" & dteIslemTarihi & "', nFirmaID = " & nFirmaID & ", nMusteriID = " & nMusteriID & ", sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', lFisNo = '" & lFisNo & "', nGirisCikis = " & nGirisCikis & ", sDepo = '" & sDepo & "', lReyonFisNo = " & lReyonFisNo & ", sStokIslem = '" & sStokIslem & "', sKasiyerRumuzu = '" & sKasiyerRumuzu & "', sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', dteIrsaliyeTarihi = '" & dteIrsaliyeTarihi & "', lIrsaliyeNo = '" & lIrsaliyeNo & "', lGirisMiktar1 = " & lGirisMiktar1 & ", lGirisMiktar2 = " & lGirisMiktar2 & ", lGirisFiyat = " & lGirisFiyat & ", lGirisTutar = " & lGirisTutar & ", lCikisMiktar1 = " & lCikisMiktar1 & ", lCikisMiktar2 = " & lCikisMiktar2 & ", lCikisFiyat = " & lCikisFiyat & ", lCikisTutar = " & lCikisTutar & ", sFiyatTipi = '" & sFiyatTipi & "', lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", lMaliyetFiyat = " & lMaliyetFiyat & ", lMaliyetTutar = " & lMaliyetTutar & ", lIlaveMaliyetTutar = " & lIlaveMaliyetTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyat = " & lDovizFiyat & ", nReceteNo = " & nReceteNo & ", nKdvOrani = " & nKdvOrani & ", nHesapID = " & nHesapID & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "' , bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", nOTVOrani = " & nOTVOrani & ", sMasrafYontemi = '" & sMasrafYontemi & "', sHangiUygulama = '" & sHangiUygulama & "', nEkSaha1 = " & nEkSaha1 & ", nEkSaha2 = " & nEkSaha2 & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "',nPrim = " & nPrim & ",lPrimTutari = " & lPrimTutari & "  Where nAlisVerisID = '" & nAlisverisID & "' and nIslemID = '" & nIslemID & "'")
        cmd.ExecuteNonQuery()
        'If bFisYenimi = True Then
        '    cmd.CommandText = sorgu_query("DELETE  FROM         auStokFisiDetayi WHERE     (nKayitTipi = 2) AND (nIslemID = '" & nIslemID & "')")
        '    cmd.ExecuteNonQuery()
        'End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisidetay_kaydet_degistir1(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal nPrim As Decimal, ByVal lPrimTutari As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET               nStokID = '" & nStokID & "', dteIslemTarihi = '" & dteIslemTarihi & "', nFirmaID = " & nFirmaID & ", nMusteriID = " & nMusteriID & ", sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', lFisNo = '" & lFisNo & "', nGirisCikis = " & nGirisCikis & ", sDepo = '" & sDepo & "', lReyonFisNo = " & lReyonFisNo & ", sStokIslem = '" & sStokIslem & "', sKasiyerRumuzu = '" & sKasiyerRumuzu & "', sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', dteIrsaliyeTarihi = '" & dteIrsaliyeTarihi & "', lIrsaliyeNo = '" & lIrsaliyeNo & "', lGirisMiktar1 = " & lGirisMiktar1 & ", lGirisMiktar2 = " & lGirisMiktar2 & ", lGirisFiyat = " & lGirisFiyat & ", lGirisTutar = " & lGirisTutar & ", lCikisMiktar1 = " & lCikisMiktar1 & ", lCikisMiktar2 = " & lCikisMiktar2 & ", lCikisFiyat = " & lCikisFiyat & ", lCikisTutar = " & lCikisTutar & ", sFiyatTipi = '" & sFiyatTipi & "', lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", lMaliyetFiyat = " & lMaliyetFiyat & ", lMaliyetTutar = " & lMaliyetTutar & ", lIlaveMaliyetTutar = " & lIlaveMaliyetTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyat = " & lDovizFiyat & ", nReceteNo = " & nReceteNo & ", nKdvOrani = " & nKdvOrani & ", nHesapID = " & nHesapID & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "' , bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", nOTVOrani = " & nOTVOrani & ", sMasrafYontemi = '" & sMasrafYontemi & "', sHangiUygulama = '" & sHangiUygulama & "', nEkSaha1 = " & nEkSaha1 & ", nEkSaha2 = " & nEkSaha2 & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "',nPrim = " & nPrim & ",lPrimTutari = " & lPrimTutari & " Where nAlisVerisID = '" & nAlisverisID & "' and nIslemID = '" & nIslemID & "'")
        cmd.ExecuteNonQuery()
        'If bFisYenimi = True Then
        '    cmd.CommandText = sorgu_query("DELETE  FROM         auStokFisiDetayi WHERE     (nKayitTipi = 2) AND (nIslemID = '" & nIslemID & "')")
        '    cmd.ExecuteNonQuery()
        'End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisidetay_sOdemeKodu_kaydet_degistir(ByVal nAlisVerisID As String, ByVal sOdemeKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sOdemeKodu = '" & sOdemeKodu & "'  Where nAlisVerisID = '" & nAlisVerisID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisSiparis_sOdemeKodu_kaydet_degistir(ByVal nAlisVerisID As String, ByVal sOdemeKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVerisSiparis SET              sOdemeKodu = '" & sOdemeKodu & "'  Where nAlisVerisID = '" & nAlisVerisID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiDetayi_DipIskonto_kaydet_duzelt(ByVal nStokFisiID As String, ByVal nGCT As Integer, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal nDipIskontoYuzdesi3 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lHarcananPuan As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal index As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim iskonto As Decimal = 100
        If index = 0 Then
        ElseIf index = 1 Then
            'nDipIskontoYuzdesi1 = lDipIskontoTutari3 / (lMalBedeli - lMalIskontoTutari + lHarcananPuan) * 100
            nDipIskontoYuzdesi1 = lDipIskontoTutari3 / (lMalBedeli - lMalIskontoTutari) * 100
        End If
        iskonto = iskonto - (iskonto * nDipIskontoYuzdesi1) / 100
        iskonto = iskonto - (iskonto * nDipIskontoYuzdesi2) / 100
        iskonto = iskonto - (iskonto * nDipIskontoYuzdesi3) / 100
        iskonto = iskonto / 100
        If nGCT = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lCikisTutar = 0, lCikisFiyat = 0, lIskontoTutari = SIGN(lGirisMiktar1) * ROUND(ABS(lBrutTutar) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2), lGirisTutar = SIGN(lGirisMiktar1) * (ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) - ROUND(ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2)), lGirisFiyat = SIGN(lGirisMiktar1) * ROUND((ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lGirisMiktar1) - ROUND(ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lGirisMiktar1) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2)) / ABS(lGirisMiktar1), 4) WHERE (nAlisVerisID = '" & nStokFisiID & "')")
        ElseIf nGCT = 1 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lGirisTutar = 0, lGirisFiyat = 0, lIskontoTutari = SIGN(lCikisMiktar1) * ROUND(ABS(lBrutTutar) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & " ), 2), lCikisTutar = SIGN(lCikisMiktar1) * (ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) - ROUND(ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & " ), 2)), lCikisFiyat = SIGN(lCikisMiktar1) * ROUND((ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lCikisMiktar1) - ROUND(ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lCikisMiktar1) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2)) / ABS(lCikisMiktar1), 4) WHERE (nAlisVerisID = '" & nStokFisiID & "')")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(ByVal nStokFisiID As String, ByVal nGCT As Integer, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal nDipIskontoYuzdesi3 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lHarcananPuan As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal index As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim nDipIskontoYuzdesi As Decimal = 0
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim iskonto As Decimal = 100
        If index = 0 Then
        ElseIf index = 1 Then
            'nDipIskontoYuzdesi = lDipIskontoTutari3 / (lMalBedeli - lMalIskontoTutari + lHarcananPuan) * 100
            nDipIskontoYuzdesi = lDipIskontoTutari3 / (lMalBedeli - lMalIskontoTutari) * 100
        End If
        iskonto = iskonto - (iskonto * nDipIskontoYuzdesi1) / 100
        iskonto = iskonto - (iskonto * nDipIskontoYuzdesi2) / 100
        iskonto = iskonto - (iskonto * nDipIskontoYuzdesi3) / 100
        iskonto = iskonto / 100
        If nGCT = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVerisSiparis SET lIskontoTutari = SIGN(lGCMiktar) * ROUND(ABS(lBrutTutar) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2), lTutar = SIGN(lGCMiktar) * (ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) - ROUND(ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2)), lFiyat = SIGN(lGCMiktar) * ROUND((ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lGCMiktar) - ROUND(ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lGCMiktar) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2)) / ABS(lGCMiktar), 4) WHERE (nAlisVerisID = '" & nStokFisiID & "')")
        ElseIf nGCT = 1 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVerisSiparis SET lIskontoTutari = SIGN(lGCMiktar) * ROUND(ABS(lBrutTutar) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & " ), 2), lTutar = SIGN(lGCMiktar) * (ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) - ROUND(ABS(lBrutTutar / ((100 + nKdvOrani) / 100)) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & " ), 2)), lFiyat = SIGN(lGCMiktar) * ROUND((ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lGCMiktar) - ROUND(ABS((lBrutFiyat / ((100 + nKdvOrani) / 100)) * lGCMiktar) * (1 - (1 - nIskontoYuzdesi * 0.01) * " & iskonto & "), 2)) / ABS(lGCMiktar), 4) WHERE (nAlisVerisID = '" & nStokFisiID & "')")
        End If
        'If bFisYenimi = True Then
        '    cmd.CommandText = sorgu_query("DELETE FROM         auAlisVeris WHERE     (nKayitTipi = 2) AND (nAlisverisID = '" & nAlisVerisID & "')")
        '    cmd.ExecuteNonQuery()
        'End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisidetay_kaydet_sil(ByVal nAlisVerisID As String, ByVal nIslemID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiSeriNo WHERE nStokFisiID = '" & nAlisVerisID & "' AND nIslemID = " & nIslemID & " ")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbStokFisiDetayi  Where nAlisVerisID = '" & nAlisVerisID & "' and nIslemID = '" & nIslemID & "'")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiSeriNo WHERE nStokFisiID = '" & nAlisVerisID & "' AND nIslemID = " & nIslemID & " ")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        'If bFisYenimi = True Then
        '    cmd.CommandText = sorgu_query("DELETE FROM         auStokFisiDetayi WHERE     (nKayitTipi = 3) AND (nIslemID = '" & nIslemID & "')")
        '    cmd.ExecuteNonQuery()
        'End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_stok_sAciklama(ByVal kod As String) As String
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sAciklama, 0) AS sAciklama FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu(ByVal query As String, Optional ByVal sTableName As String = "TABLE1") As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTableName)
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub gorunum_kaydet()
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
                VGrid_baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                VGrid_baslik.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_toplam.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_toplam.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
    End Sub
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Sub analiz_satis_kapatma()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_pesin_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.skasiyer = sKasiyerRumuzu
            frm.skasiyerRumuzu = dr_baslik("sKasiyerRumuzu")
            frm.sMagaza = dr_baslik("sMagaza")
            frm.nKasaNo = dr_baslik("nKasaNo")
            frm.dteFisTarihi = dr_baslik("dteFaturaTarihi")
            frm.nAlisVerisID = nAlisVerisID
            frm.lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
            frm.sOdemeKodu = sOdemeKodu
            frm.sFisTipi = Trim(dr_baslik("sFisTipi"))
            If Me.WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
            End If
            Me.Size = New System.Drawing.Size(Me.Size.Width - 190, Me.Size.Height)
            Me.Location = New System.Drawing.Size(Me.Location.X - 95, Me.Location.Y)
            Me.Refresh()
            frm.Location = New System.Drawing.Size(Me.Size.Width, Me.Location.Y)
            frm.StartPosition = FormStartPosition.Manual
            If Trim(dr_baslik("sFisTipi")) = "P" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                frm.GroupControl2.Visible = False
                frm.BarButtonItem3.Enabled = False
                frm.BarButtonItem4.Enabled = False
                frm.BarButtonItem5.Enabled = False
                frm.BarButtonItem6.Enabled = False
                frm.BarButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                frm.BarButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                frm.BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                frm.BarButtonItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                frm.Size = New System.Drawing.Size(frm.Size.Width, 345)
            Else
                frm.Size = New System.Drawing.Size(frm.Size.Width, Me.Size.Height)
                frm.GroupControl2.Visible = True
            End If
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                XtraMessageBox.Show(Sorgu_sDil("Kontrol Ediliyor...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Me.Size = New System.Drawing.Size(Me.Size.Width + 190, Me.Size.Height)
            Me.Location = New System.Drawing.Size(Me.Location.X + 95, Me.Location.Y)
            toplam_hesapla()
        End If
    End Sub
    Private Sub analiz_satis_kapatma_detayi()
        sKasiyerRumuzu = dr_baslik("sKasiyerRumuzu")
        sMagaza = dr_baslik("sMagaza")
        nKasaNo = dr_baslik("nKasaNo")
        dteFisTarihi = dr_baslik("dteFaturaTarihi")
        Group_Kapatma.Visible = True
        Group_Kapatma.Enabled = True
        Group_Satis.Enabled = False
        'buton kontrolleri
        btn_AltFisSil.Enabled = False
        btn_AltFisYeni.Enabled = False
        btn_AltMusteriSec.Enabled = False
        btn_AltMusteriYeni.Enabled = False
        btn_AltOdemeAl.Enabled = False
        btn_AltSatirEkle.Enabled = False
        btn_AltSatirSil.Enabled = False
        btn_AltYuvarla.Enabled = False
        btn_FisSil.Enabled = False
        'btn_FisYeni.Enabled = False
        btn_SatirEkle.Enabled = False
        btn_SatirSil.Enabled = False
        btn_MusteriSec.Enabled = False
        'btn_musteriaktar.Visible = False
        Me.btn_HesapKapat.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.None)
        Me.btn_BarkodOkut.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.None)
        Me.btn_SatisDon.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
        dataload_tbOdemeSekli()
        dataload_tbDovizCinsi()
        dataload_pesinat(nAlisVerisID)
        dataload_taksit(nAlisVerisID)
        If dr_toplam("lNetTutar") > 0 Then
            collTutari.FieldName = "lTutari"
            collTutari.SummaryItem.FieldName = "lTutari"
            dteIlkTaksit.Enabled = True
            txt_sayi.Enabled = True
            sec_sAralik.Enabled = True
            txt_tutar.Enabled = True
        ElseIf dr_toplam("lNetTutar") < 0 Then
            collTutari.FieldName = "lOdemeTutar"
            collTutari.SummaryItem.FieldName = "lOdemeTutar"
            dteIlkTaksit.Enabled = False
            txt_sayi.Enabled = True
            sec_sAralik.Enabled = False
            txt_tutar.Enabled = True
        End If
        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
            'lMakbuzNo = sorgu_lMakbuzNo(sDepo)
            'lMakbuzNo_degistir(lMakbuzNo, sDepo)
        End If
        If Trim(dr_baslik("sFisTipi")) = "P" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            GroupControl_Taksit.Visible = False
            GroupControl_Pesinat.Dock = DockStyle.Fill
        Else
            GroupControl_Pesinat.Dock = DockStyle.Top
            GroupControl_Taksit.Visible = True
        End If
        If kullanici > 3 Then
            dteIlkTaksit.MinDate = dr_baslik("dteFaturaTarihi")
        Else
            dteIlkTaksit.MinDate = "01/01/1900"
        End If
        Try
            taksit_ilkTarih_Hesapla()
        Catch ex As Exception
            taksit_ilkTarih_Hesapla2()
        End Try
        toplam_hesapla_kapatma()
        If kullanici > 3 Then
            Try
                dteIlkTaksit.MaxDate = DateAdd(DateInterval.Day, dr_param("nITMAXG"), dr_baslik("dteFaturaTarihi"))
            Catch ex As Exception
                dteIlkTaksit.MaxDate = DateAdd(DateInterval.Day, 45, dr_baslik("dteFaturaTarihi"))
            End Try
            dteIlkTaksit.Text = dteIlkTaksit.MaxDate
        Else
            dteIlkTaksit.MaxDate = "31/12/2078"
            dteIlkTaksit.Text = dr_baslik("dteFaturaTarihi")
        End If
        Try
            txt_sayi.Text = OdemePlani_Maximum(dr_baslik("sFisTipi"), dr_baslik("nAlisVerisID"))
            txt_sayi.Properties.MaxValue = txt_sayi.Text
        Catch ex As Exception
            txt_sayi.Text = 1
            txt_sayi.Properties.MaxValue = 999
            nMaxTaksitSayisi = 999
        End Try
        If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
            If Pesinat = 0 And lKalanTutar > 0 Then
                pesinat_satir_ekle()
                toplam_hesapla_kapatma()
            End If
            GridControl2.Focus()
            GridControl2.Select()
            GridView2.FocusedColumn = collOdemeTutar
        Else
            If Pesinat + Taksit_tutari = 0 Then
                If bOtomatikTaksit = True Then
                    tbTaksit_ekle_toplu(DateAdd(DateInterval.Day, nTaksitGun, dteFisTarihi), 1, "Ay", lKalanTutar)
                    toplam_hesapla_kapatma()
                Else
                    dteIlkTaksit.Focus()
                    dteIlkTaksit.Select()
                End If
            ElseIf taksit_sayisi = 1 Then
                Dim dr_taksit As DataRow = ds_taksit.Tables(0).Rows(0)
                dr_taksit("lTutari") = dr_taksit("lTutari") + lKalanTutar
                dr_taksit = Nothing
                toplam_hesapla_kapatma()
                dteIlkTaksit.Focus()
                dteIlkTaksit.Select()
            Else
                dteIlkTaksit.Focus()
                dteIlkTaksit.Select()
            End If
            If dr_toplam("lNetTutar") > 0 Then
                tbTaksit_hesapla()
            ElseIf dr_toplam("lNetTutar") < 0 Then
                tbTaksitIade_hesapla()
            End If
            GridControl2.Focus()
            GridControl2.Select()
            GridView2.FocusedColumn = collOdemeTutar
        End If
    End Sub
    Private Sub toplam_hesapla_kapatma()
        lbl_Satis.Text = lNetTutar
        Dim dr_pesinat As DataRow
        Dim dr_taksit As DataRow
        Pesinat = 0
        Taksit_tutari = 0
        taksit_sayisi = 0
        pesinat_sayisi = 0
        'Dim taksit_sayisi As Int64 = 0
        'Dim taksit_tutari As Decimal = 0
        For Each dr_pesinat In ds_odeme.Tables(0).Rows
            Pesinat += dr_pesinat("lOdemeTutar")
            pesinat_sayisi += 1
        Next
        lbl_pesinat.Text = Pesinat
        For Each dr_taksit In ds_taksit.Tables(0).Rows
            taksit_sayisi += 1
            If dr_toplam("lNetTutar") > 0 Then
                Taksit_tutari += sorgu_sayi(dr_taksit("lTutari"), 0)
            ElseIf dr_toplam("lNetTutar") < 0 Then
                Taksit_tutari += sorgu_sayi(dr_taksit("lOdemeTutar"), 0)
            End If
        Next
        lbl_taksit_sayisi.Text = FormatNumber(taksit_sayisi, 1)
        lbl_taksit_tutari.Text = FormatNumber(Taksit_tutari, 2)
        lKalanTutar = lNetTutar - (Pesinat + Taksit_tutari)
        If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
            If lKalanTutar = 0 Then
                lbl_lKalan.Text = ""
            ElseIf lKalanTutar < 0 Then
                lbl_lKalan.Text = "Para Üstü: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            ElseIf lKalanTutar > 0 Then
                lbl_lKalan.Text = "Eksik Para: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            End If
        Else
            If lKalanTutar = 0 Then
                lbl_lKalan.Text = ""
            ElseIf lKalanTutar < 0 Then
                lbl_lKalan.Text = "Fazla: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            ElseIf lKalanTutar > 0 Then
                lbl_lKalan.Text = "Eksik: " & FormatNumber(Math.Abs(lKalanTutar), 2)
            End If
        End If
        vade_hesapla_kapatma()
        dr_pesinat = Nothing
        dr_taksit = Nothing
        GridView3.BestFitColumns()
        'taksit_sayisi = Nothing
        'taksit_tutari = Nothing
    End Sub
    Private Sub vade_hesapla_kapatma()
        Dim s As String
        Dim i As Integer
        Dim tutar = 0
        Dim vade
        Dim dr As DataRow
        Dim gun As Decimal = 0
        Dim tutarvade As Decimal = 0
        Dim ortvade As Decimal = 0
        Dim ortgun As Decimal = 0
        For Each dr In ds_taksit.Tables(0).Rows
            tutar = tutar + dr("lTutari")
            Try
                gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteTarihi"))
            Catch ex As Exception
                gun = 0
            End Try
            tutarvade = tutarvade + (dr("lTutari") * gun)
        Next
        Try
            ortvade = tutarvade / tutar
            lbl_gun.Text = CInt(ortvade)
            lbl_vade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_gun.Text = CInt(ortvade)
            lbl_vade.Text = ""
        End Try
        dr = Nothing
        s = Nothing
        i = Nothing
        tutar = Nothing
        vade = Nothing
        gun = Nothing
    End Sub
    Private Sub pesinat_satir_info()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("lMakbuzNo") <> lMakbuzNo Then
                lMakbuzNo = dr("lMakbuzNo")
            End If
            dr = Nothing
        Else
            lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
        End If
    End Sub
    Private Sub taksit_satir_info()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            ds_taksit_info = sorgu(sorgu_query("SELECT *, (SELECT ISNULL(SUM(lOdemeTutar) , 0) FROM tbOdeme WHERE nTaksitID = tbTaksit.nTaksitID) AS Tahsilat FROM tbTaksit Where nTaksitID ='" & dr("nTaksitID") & "'"))
            dr = Nothing
            Dim dr_taksit As DataRow
            Try
                dr_taksit = ds_taksit_info.Tables(0).Rows(0)
                If dr_taksit("Tahsilat") <> 0 Then
                    If dr_toplam("lNetTutar") > 0 Then
                        coldteTarihi.OptionsColumn.AllowEdit = False
                        collTutari.OptionsColumn.AllowEdit = False
                        MenuItem11.Enabled = False
                    ElseIf dr_toplam("lNetTutar") < 0 Then
                        coldteTarihi.OptionsColumn.AllowEdit = False
                        coldteTarihi.OptionsColumn.AllowFocus = False
                        MenuItem11.Enabled = True
                    End If
                    'dr_taksit("Status") = 1
                Else
                    coldteTarihi.OptionsColumn.AllowEdit = True
                    collTutari.OptionsColumn.AllowEdit = True
                    coldteTarihi.OptionsColumn.AllowEdit = True
                    coldteTarihi.OptionsColumn.AllowFocus = True
                    MenuItem11.Enabled = True
                    'dr_taksit("Status") = 0
                End If
                'lblTaksit_info.Text = "Tarihi: " & dr_taksit("dteTarihi") & " Tutarı: " & dr_taksit("lTutari") & " Tahsilat: " & dr_taksit("Tahsilat") & " Kalan: " & dr_taksit("lTutari") - dr_taksit("Tahsilat")
                lblTaksit_info.Text = "Vade: " & dr_taksit("dteTarihi") & " Tutar: " & dr_taksit("lTutari") & " Kalan: " & dr_taksit("lTutari") - dr_taksit("Tahsilat")
            Catch ex As Exception
                lblTaksit_info.Text = "***"
            End Try
            dr_taksit = Nothing
            dr = Nothing
            If kullanici > 3 Then
                If dr_param("bTaksitTutDegistirilsinmi") = False Then
                    collTutari.OptionsColumn.ReadOnly = True
                    collTutar.OptionsColumn.AllowEdit = False
                End If
                If dr_param("bTaksitTarDegistirilsinmi") = False Then
                    coldteTarihi.OptionsColumn.ReadOnly = True
                    coldteTarihi.OptionsColumn.AllowEdit = False
                End If
            End If
        End If
    End Sub
    Private Sub dataload_tbOdemeSekli()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbOdemeSekli Order by sOdemeSekli ")).Tables(0)
    End Sub
    Private Sub dataload_pesinat(ByVal nAlisVerisID As String)
        'ds_odeme = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID "))
        ds_odeme = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, ABS(lOdemeTutar) AS lOdemeTutar,sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID "))
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_odeme.Tables(0)
    End Sub
    Private Sub dataload_taksit(ByVal nAlisVerisID As String)
        If dr_toplam("lNetTutar") > 0 Then
            ds_taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "))
        ElseIf dr_toplam("lNetTutar") < 0 Then
            ds_taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbOdeme.*, tbTaksit.dteTarihi, tbTaksit.lTutari FROM         tbOdeme INNER JOIN                       tbTaksit ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE     (tbOdeme.nAlisverisID = '" & nAlisVerisID & "') AND (tbOdeme.nOdemeKodu = 3) "))
        End If
        GridControl3.DataMember = Nothing
        GridControl3.DataSource = ds_taksit.Tables(0)
    End Sub
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo,0) + 1 lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=1 ORDER BY  lMakbuzNo DESC")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lPerakendeFatura1,0)+1 FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo_varmi(ByVal sDepo As String, ByVal nAlisVerisID As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo, 0) AS lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        nSonID += 1
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nTaksitID_lKalan(ByVal nTaksitID As String) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lTutari - (SELECT ISNULL(SUM(lOdemeTutar) , 0) FROM tbOdeme WHERE nTaksitID = tbTaksit.nTaksitID), 0) AS Kalan FROM tbTaksit Where nTaksitID = '" & nTaksitID & "' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAvSiraNo_kaydet_degistir(ByVal sMagaza As String, ByVal nSiraIndex As Int64, ByVal nSonID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVSiraNo SET              nSonID = nSonID WHERE     (sDepo = '" & sMagaza & "') AND (nSiraIndex = " & nSiraIndex & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub pesinat_satir_ekle(Optional ByVal lTutar As Decimal = 0, Optional ByVal bEkle As Boolean = False)
        If lKalanTutar > 0 Then
            pesinat_satir_info()
            If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
                lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
                lMakbuzNo_degistir(lMakbuzNo, sMagaza)
            End If
            Dim dr As DataRow = ds_odeme.Tables(0).NewRow
            Dim nOdemeID = sorgu_nOdemeID(sMagaza).ToString
            dr("nOdemeID") = sMagaza & nOdemeID.ToString
            dr("nAlisverisID") = nAlisVerisID
            dr("sOdemeSekli") = "N   "
            dr("nOdemeKodu") = 1
            dr("sKasiyerRumuzu") = sKasiyerRumuzu
            dr("dteOdemeTarihi") = dteFisTarihi
            dr("dteValorTarihi") = dteFisTarihi
            If bEkle = False Then
                dr("lOdemeTutar") = lKalanTutar
            Else
                dr("lOdemeTutar") = lTutar
            End If
            dr("sDovizCinsi") = ""
            dr("lDovizTutar") = 0
            dr("lMakbuzNo") = lMakbuzNo
            dr("lOdemeNo") = lMakbuzNo
            dr("nTaksitID") = ""
            dr("nIadeAlisverisID") = ""
            dr("bMuhasebeyeIslendimi") = 0
            dr("nKasaNo") = nKasaNo
            dr("sKartNo") = ""
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("sMagaza") = sMagaza
            If dr_toplam("lNetTutar") > 0 Then
                tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            ElseIf dr_toplam("lNetTutar") < 0 Then
                tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), -dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            End If
            ds_odeme.Tables(0).Rows.Add(dr)
            tbAvSirano_degistir(2, nOdemeID, sMagaza)
            nOdemeID = Nothing
            toplam_hesapla_kapatma()
            GridControl2.Focus()
            GridControl2.Select()
            GridView2.FocusedColumn = collOdemeTutar
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kapatılacak Tutar Kalmamış", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub pesinat_satir_sil()
        If GridView2.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Peşinat Satırını Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                If dr("sKartNo").ToString = sorgu_sayi(dr_baslik("nMusteriID"), 0).ToString Then
                    pesinat_duzelt(dr("nOdemeID"), "")
                    dataload_pesinat(dr_baslik("nAlisVerisID"))
                Else
                    tbOdeme_kaydet_sil(dr("nOdemeID"))
                    ds_odeme.Tables(0).Rows.Remove(dr)
                    GridControl2.Focus()
                    GridControl2.Select()
                    If GridView2.RowCount > 0 Then
                        GridView2.SelectRow(GridView2.FocusedRowHandle)
                    End If
                End If
                toplam_hesapla_kapatma()
            End If
        End If
    End Sub
    Private Sub taksit_satir_sil()
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Taksit Satırını Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                Dim bDevam As Boolean = False
                If dr_toplam("lNetTutar") > 0 Then
                    bDevam = tbTaksit_kaydet_sil(dr("nTaksitID"), nAlisVerisID)
                ElseIf dr_toplam("lNetTutar") < 0 Then
                    bDevam = tbOdeme_kaydet_sil(dr("nOdemeID"))
                End If
                If bDevam = True Then
                    ds_taksit.Tables(0).Rows.Remove(dr)
                End If
                GridControl3.Focus()
                GridControl3.Select()
                If GridView3.RowCount > 0 Then
                    GridView3.SelectRow(GridView3.FocusedRowHandle)
                Else
                    dteIlkTaksit.Focus()
                    dteIlkTaksit.Select()
                End If
                toplam_hesapla_kapatma()
            End If
        End If
    End Sub
    Private Sub taksit_satir_sil_toplu()
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Taksit Satırlarını Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr1 As DataRow
                For Each dr1 In ds_taksit.Tables(0).Rows
                    If dr_toplam("lNetTutar") > 0 Then
                        tbTaksit_kaydet_sil(dr1("nTaksitID"), nAlisVerisID)
                    ElseIf dr_toplam("lNetTutar") < 0 Then
                        tbOdeme_kaydet_sil(dr1("nOdemeID"))
                    End If
                Next
                dataload_taksit(nAlisVerisID)
                toplam_hesapla_kapatma()
                If GridView3.RowCount > 0 Then
                    GridView3.SelectRow(GridView3.FocusedRowHandle)
                Else
                    dteIlkTaksit.Focus()
                    dteIlkTaksit.Select()
                End If
            End If
        End If
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbOdeme                       (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('" & nOdemeID & "', '" & nAlisverisID & "', '" & sOdemeSekli & "', " & nOdemeKodu & ", '" & sKasiyerRumuzu & "', '" & dteOdemeTarihi & "', '" & dteValorTarihi & "', " & lOdemeTutar & ", '" & sDovizCinsi & "', " & lDovizTutar & ", " & lMakbuzNo & ", " & lOdemeNo & ", '" & nTaksitID & "', '" & nIadeAlisverisID & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKartNo & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbOdeme_kaydet_degistir(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbOdeme SET              nAlisverisID = '" & nAlisverisID & "', sOdemeSekli = '" & sOdemeSekli & "', nOdemeKodu = " & nOdemeKodu & ", sKasiyerRumuzu = '" & sKasiyerRumuzu & "', dteOdemeTarihi = '" & dteOdemeTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', lOdemeTutar = " & lOdemeTutar & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizTutar = " & lDovizTutar & ", lMakbuzNo = '" & lMakbuzNo & "', lOdemeNo = '" & lOdemeNo & "', nTaksitID = '" & nTaksitID & "', nIadeAlisverisID = '" & nIadeAlisverisID & "', bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", nKasaNo = " & nKasaNo & ", sKartNo = '" & sKartNo & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sMagaza = '" & sMagaza & "' Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        'If bFisYenimi = True Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM         auOdeme WHERE     (nOdemeID = '" & nOdemeID & "') AND (nKayitTipi = 2)")
        '    cmd.ExecuteNonQuery()
        'End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbOdeme_kaydet_sil(ByVal nOdemeID As String) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim bDevam As Boolean = False
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbOdeme  Where nOdemeID = '" & nOdemeID & "'")
            cmd.ExecuteNonQuery()
            bDevam = True
            'If bFisYenimi = True Then
            '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM         auOdeme WHERE     (nOdemeID = '" & nOdemeID & "') AND (nKayitTipi = 3)")
            '    cmd.ExecuteNonQuery()
            'End If
            bDevam = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            bDevam = False
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
        Return bDevam
    End Function
    Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_degistir(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbTaksit SET              dteTarihi = '" & dteTarihi & "', lTutari = " & lTutari & " Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbTaksit_kaydet_sil(ByVal nTaksitID As String, ByVal nAlisverisID As String) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim bDevam As Boolean = False
        Dim nKayit As Integer = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(nTaksitID) from tbOdeme Where nTaksitID = '" & nTaksitID & "'")
        If nKayit = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbTaksit Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
            cmd.ExecuteNonQuery()
            bDevam = True
        Else
            bDevam = False
            XtraMessageBox.Show("İşlem Görmüş Taksit Kaydını Silemezsiniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        con.Close()
        cmd = Nothing
        con = Nothing
        Return bDevam
    End Function
    Private Sub tbOdeme_hesapla()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr("lOdemeTutar") = sorgu_sayi(dr("lOdemeTutar"), lNetTutar)
            If dr("lOdemeTutar") = 0 Then
                dr("lOdemeTutar") = 0.01
            ElseIf dr("lOdemeTutar") < 0 Then
                dr("lOdemeTutar") = Math.Abs(dr("lOdemeTutar"))
            End If
            dr.EndEdit()
            If dr_toplam("lNetTutar") > 0 Then
                tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            ElseIf dr_toplam("lNetTutar") < 0 Then
                tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), -dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            End If
        End If
    End Sub
    Private Sub tbTaksitIade_hesapla()
        If GridView3.RowCount > 0 Then
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            If dr("lOdemeTutar") > sorgu_sayi(dr("lTutari"), 0) Then
                dr("lOdemeTutar") = dr("lTutari")
            End If
            dr("lOdemeTutar") = sorgu_sayi(dr("lOdemeTutar"), 0.01)
            If dr("lOdemeTutar") = 0 Then
                dr("lOdemeTutar") = 0.01
            ElseIf dr("lOdemeTutar") < 0 Then
                dr("lOdemeTutar") = Math.Abs(dr("lOdemeTutar"))
            End If
            dr.EndEdit()
            tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            Dim lKalanTaksit = sorgu_nTaksitID_lKalan(dr("nTaksitID"))
            If lKalanTaksit < 0 Then
                dr("lOdemeTutar") = dr("lOdemeTutar") - (Math.Abs(lKalanTaksit))
            End If
            dr.EndEdit()
            tbOdeme_kaydet_degistir(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
            taksit_satir_info()
        End If
    End Sub
    Private Sub tbTaksit_hesapla(Optional ByVal bSatir As Integer = -1)
        If GridView3.RowCount > 0 Then
            GridView3.PostEditor()
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            If bSatir = -1 Then
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Else
                dr = GridView3.GetDataRow(bSatir)
            End If
            Dim satir = GridView3.FocusedRowHandle
            If dr("lTutari") = 0 Then
                dr("lTutari") = 0.01
            End If
            If dr("dteTarihi") < dteFisTarihi Then
                dr("dteTarihi") = dteFisTarihi
            End If
            If GridView3.FocusedRowHandle = 0 Then
                Try
                    If dr("dteTarihi") > DateAdd(DateInterval.Day, dr_param("nITMAXG"), dteFisTarihi) Then
                        dr("dteTarihi") = DateAdd(DateInterval.Day, dr_param("nITMAXG"), dteFisTarihi)
                    End If
                Catch ex As Exception
                    If dr("dteTarihi") > DateAdd(DateInterval.Day, 45, dteFisTarihi) Then
                        dr("dteTarihi") = DateAdd(DateInterval.Day, 45, dteFisTarihi)
                    End If
                End Try
            Else
                Dim dr_ilk As DataRow = GridView3.GetDataRow(0)
                Dim ilktarih As DateTime = dr_ilk("dteTarihi")
                If dr("dteTarihi") > DateAdd(DateInterval.Month, (GridView3.FocusedRowHandle + 1), ilktarih) Then
                    'dr("dteTarihi") = DateAdd(DateInterval.Month, (GridView2.FocusedRowHandle + 1), ilktarih)
                End If
                dr_ilk = Nothing
                ilktarih = Nothing
            End If
            dr.EndEdit()
            tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            toplam_hesapla_kapatma()
            If lKalanTutar < 0 Then
                GridView3.FocusedRowHandle = GridView3.RowCount - 1
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("lTutari") = lKalanTutar + dr("lTutari")
                dr.EndEdit()
                tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            ElseIf lKalanTutar > 0 Then
                GridView3.FocusedRowHandle = GridView3.RowCount - 1
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("lTutari") = lKalanTutar + dr("lTutari")
                dr.EndEdit()
                tbTaksit_kaydet_degistir(dr("nTaksitID"), nAlisVerisID, dr("dteTarihi"), dr("lTutari"))
            End If
            toplam_hesapla_kapatma()
            GridView3.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub degeryay_kapatma(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView3.RowCount  'kl.Count
        Dim satir = GridView3.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView3.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim İ As Integer
        İ = 0
        dr_hareket = GridView3.GetDataRow(GridView3.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For İ = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            If columnkriter = "dteTarihi" Then
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                If t > 1 Then
                    durum = DateAdd(DateInterval.Month, 1, durum)
                Else
                    durum = durum
                End If
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            ElseIf columnkriter = "lTutari" Then
                GridView3.PostEditor()
                dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            End If
            tbTaksit_hesapla()
            toplam_hesapla_kapatma()
            GridView3.FocusedRowHandle += 1
        Next
        GridView3.FocusedRowHandle = satir
        GridView3.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        İ = Nothing
    End Sub
    Private Sub taksit_satir_ekle(ByVal dteBaslangic As DateTime, ByVal TaksitSayisi As Int64, ByVal sAralik As String, ByVal TaksitTutari As Decimal)
        Dim frm As New frm_cari_faturalar_acik
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("nMusteriID")
        frm.kullanici = kullanici
        frm.status = True
        frm.fisNO = fisNO
        If Trim(fatTarih) <> "" Then
            frm.fatTarih = fatTarih
        Else
            Try
                frm.fatTarih = dr_baslik("dteFaturaTarihi")
            Catch ex As Exception
            End Try
        End If
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
                    'pesinat_satir_info()
                    If lKalanTutar > 0 Then
                        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
                            lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
                            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                        End If
                        If TaksitTutari > 0 Then
                            dr1("KALAN") = TaksitTutari
                        End If
                        If dr1("KALAN") > lKalanTutar Then
                            dr1("KALAN") = lKalanTutar
                        End If
                        dr = ds_taksit.Tables(0).NewRow
                        Dim nOdemeID = sorgu_nOdemeID(sMagaza).ToString()
                        dr("nOdemeID") = sMagaza & nOdemeID.ToString()
                        dr("nAlisverisID") = nAlisVerisID
                        dr("sOdemeSekli") = "N   "
                        dr("nOdemeKodu") = 3
                        dr("sKasiyerRumuzu") = sKasiyerRumuzu
                        dr("dteOdemeTarihi") = dteFisTarihi
                        dr("dteValorTarihi") = dteFisTarihi
                        dr("lOdemeTutar") = dr1("KALAN")
                        dr("sDovizCinsi") = ""
                        dr("lDovizTutar") = 0
                        dr("lMakbuzNo") = lMakbuzNo
                        dr("lOdemeNo") = lMakbuzNo
                        dr("dteTarihi") = dr1("dteTarihi")
                        dr("lTutari") = dr1("TUTAR")
                        dr("nTaksitID") = dr1("nTaksitID")
                        dr("nIadeAlisverisID") = dr1("nAlisVerisID")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("nKasaNo") = nKasaNo
                        dr("sKartNo") = ""
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("sMagaza") = sMagaza
                        tbOdeme_kaydet_yeni(dr("nOdemeID"), nAlisVerisID, dr("sOdemeSekli"), dr("nOdemeKodu"), dr("sKasiyerRumuzu"), dr("dteOdemeTarihi"), dr("dteValorTarihi"), dr("lOdemeTutar"), dr("sDovizCinsi"), dr("lDovizTutar"), dr("lMakbuzNo"), dr("lOdemeNo"), dr("nTaksitID"), dr("nIadeAlisVerisID"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), dr("sKartNo"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sMagaza"))
                        tbAvSirano_degistir(2, nOdemeID, sMagaza)
                        ds_taksit.Tables(0).Rows.Add(dr)
                        toplam_hesapla_kapatma()
                        Me.Refresh()
                    End If
                Next
            End If
        End If
        'End If
        dr = Nothing
        dr1 = Nothing
        frm.Close()
        frm.Dispose()
        frm = Nothing
        txt_sayi.EditValue = 1
        txt_tutar.EditValue = 0
        GridControl3.Focus()
        GridControl3.Select()
    End Sub
    Private Sub tbTaksit_ekle_toplu(ByVal dteBaslangic As DateTime, ByVal TaksitSayisi As Int64, ByVal sAralik As String, ByVal TaksitTutari As Decimal)
        Dim i As Integer
        Dim dteTarihi As DateTime
        Dim nTaksitID As String = ""
        For i = 1 To TaksitSayisi
            If lKalanTutar > 0 Then
                If TaksitTutari > lKalanTutar Then
                    TaksitTutari = lKalanTutar
                End If
                dr = ds_taksit.Tables(0).NewRow
                If i > 1 Then
                    If sAralik = "Gün" Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    ElseIf sAralik = "Hafta" Then
                        dteTarihi = DateAdd(DateInterval.Day, 7, dteTarihi)
                    ElseIf sAralik = "Ay" Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    ElseIf sAralik = "3Ay" Then
                        dteTarihi = DateAdd(DateInterval.Quarter, 1, dteTarihi)
                    ElseIf sAralik = "Yıl" Then
                        dteTarihi = DateAdd(DateInterval.Year, 1, dteTarihi)
                    End If
                    'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                Else
                    dteTarihi = dteBaslangic
                End If
                nTaksitID = sorgu_nTaksitID(sMagaza)
                dr("nTaksitID") = sMagaza & nTaksitID
                dr("nAlisVerisID") = nAlisVerisID
                dr("dteTarihi") = dteTarihi
                dr("lTutari") = TaksitTutari
                tbTaksit_kaydet_yeni(dr("nTaksitID"), dr("nAlisVerisID"), dr("dteTarihi"), dr("lTutari"))
                ds_taksit.Tables(0).Rows.Add(dr)
                tbAvSirano_degistir(3, nTaksitID, sMagaza)
                toplam_hesapla_kapatma()
            End If
        Next
        txt_sayi.EditValue = 1
        txt_tutar.EditValue = 0
    End Sub
    Private Function OdemePlani_Maximum(ByVal sFisTipi As String, ByVal nAlisVerisID As String) As Int64
        Dim nMaximum As Int64 = 0
        If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
            nMaximum = sorgu_sayi(sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT MAX(CAST(sOdemeKodu AS INTEGER)) AS sOdemeKodu FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sOdemeKodu <> '')"), 0)
        ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
            nMaximum = sorgu_sayi(sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT MAX(CAST(sOdemeKodu AS INTEGER)) AS sOdemeKodu FROM     tbAlisVerisSiparis WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sOdemeKodu <> '')"), 0)
        End If
        Return nMaximum
    End Function
    Private Sub OdemePlani_Aktar(ByVal sFisTipi As String, ByVal nAlisVerisID As String, ByVal dteBaslangic As DateTime, ByVal sAralik As String)
        taksit_satir_sil_toplu()
        Dim ds_OdemePlani As New DataSet
        'ds_OdemePlani = sorgu(sorgu_query("SELECT     CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sFisTipi = '" & sFisTipi & "') and sOdemeKodu <> ''"))
        'If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
        '    ds_OdemePlani = sorgu(sorgu_query("SELECT     CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sFisTipi = '" & sFisTipi & "') and sOdemeKodu <> ''"))
        'ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
        '    ds_OdemePlani = sorgu(sorgu_query("SELECT     CAST(lTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbAlisVerisSiparis WHERE     (nAlisverisID = '" & nAlisVerisID & "') and sOdemeKodu <> '' "))
        'End If
        If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
            ds_OdemePlani = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED   SELECT     CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sFisTipi = '" & sFisTipi & "') "))
        ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
            ds_OdemePlani = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED   SELECT     CAST(lTutar * (100 + nKdvOrani) / 100 AS MONEY) lTutar, sOdemeKodu FROM         tbAlisVerisSiparis WHERE     (nAlisverisID = '" & nAlisVerisID & "')  "))
        End If
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim lOdemePesinat As Decimal = 0
        Dim sOdemePlaniKodu As Int64 = 0
        For Each dr1 In ds_OdemePlani.Tables(0).Rows
            dr1("sOdemeKodu") = sorgu_sayi(dr1("sOdemeKodu"), 0)
            Try
                sOdemePlaniKodu = sorgu_sayi(dr1("sOdemeKodu"), 0)
            Catch ex As Exception
                sOdemePlaniKodu = 0
            End Try
            If sOdemePlaniKodu > 0 Then
                Dim TaksitSayisi As Integer = 0
                Dim dteTarihi As DateTime
                Dim i As Integer = 0
                If sOdemePlaniKodu = 0 Then
                    TaksitSayisi = 1
                Else
                    TaksitSayisi = sOdemePlaniKodu
                End If
                For i = 1 To TaksitSayisi
                    If i > 1 Then
                        If sAralik = "Gün" Then
                            dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                        ElseIf sAralik = "Hafta" Then
                            dteTarihi = DateAdd(DateInterval.Day, 7, dteTarihi)
                        ElseIf sAralik = "Ay" Then
                            dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                        ElseIf sAralik = "3Ay" Then
                            dteTarihi = DateAdd(DateInterval.Quarter, 1, dteTarihi)
                        ElseIf sAralik = "Yıl" Then
                            dteTarihi = DateAdd(DateInterval.Year, 1, dteTarihi)
                        End If
                        'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    Else
                        dteTarihi = dteBaslangic
                    End If
                    Dim nTaksitID As String = ""
                    If ds_taksit.Tables(0).Rows.Count < i Then
                        'dr2 = DataSet1.Tables(0).NewRow
                        'dr2("dteTaksitTarihi") = dteTarihi
                        'dr2("lTutari") = dr1("lTutar") / TaksitSayisi
                        'dr2("nTaksit") = i
                        'DataSet1.Tables(0).Rows.Add(dr2)
                        dr2 = ds_taksit.Tables(0).NewRow
                        nTaksitID = sorgu_nTaksitID(sMagaza)
                        dr2("nTaksitID") = sMagaza & nTaksitID
                        dr2("nAlisVerisID") = nAlisVerisID
                        dr2("dteTarihi") = dteTarihi
                        dr2("lTutari") = FormatNumber(dr1("lTutar") / TaksitSayisi, 2)
                        tbTaksit_kaydet_yeni(dr2("nTaksitID"), dr2("nAlisVerisID"), dr2("dteTarihi"), dr2("lTutari"))
                        ds_taksit.Tables(0).Rows.Add(dr2)
                        tbAvSirano_degistir(3, nTaksitID, sMagaza)
                        toplam_hesapla_kapatma()
                    Else
                        dr2 = ds_taksit.Tables(0).Rows(i - 1)
                        dr2("lTutari") = FormatNumber(dr2("lTutari") + (dr1("lTutar") / TaksitSayisi), 2)
                        dr2.EndEdit()
                        tbTaksit_kaydet_degistir(dr2("nTaksitID"), nAlisVerisID, dr2("dteTarihi"), dr2("lTutari"))
                        toplam_hesapla_kapatma()
                    End If
                Next
            ElseIf sOdemePlaniKodu = 0 Then
                lOdemePesinat += dr1("lTutar")
            End If
        Next
        If lOdemePesinat > 0 Then
            pesinat_satir_ekle(lOdemePesinat)
        End If
        lOdemePesinat = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub analiz_satis_kapatma_iade()
        analiz_satis_kapatma_detayi()
        'If GridView1.RowCount > 0 Then
        '    Dim frm As New frm_stok_pesin_kapatma_iade
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.skasiyer = sKasiyerRumuzu
        '    frm.skasiyerRumuzu = dr_baslik("sKasiyerRumuzu")
        '    frm.sMagaza = dr_baslik("sMagaza")
        '    frm.nKasaNo = dr_baslik("nKasaNo")
        '    frm.dteFisTarihi = dr_baslik("dteFaturaTarihi")
        '    frm.nAlisVerisID = nAlisVerisID
        '    frm.nMusteriID = dr_baslik("nMusteriID")
        '    frm.sFisTipi = dr_baslik("sFisTipi")
        '    frm.lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
        '    frm.sOdemeKodu = sOdemeKodu
        '    Me.Size = New System.Drawing.Size(Me.Size.Width - 190, Me.Size.Height)
        '    Me.Location = New System.Drawing.Size(Me.Location.X - 95, Me.Location.Y)
        '    frm.Location = New System.Drawing.Size(Me.Size.Width, Me.Location.Y)
        '    frm.StartPosition = FormStartPosition.Manual
        '    frm.Size = New System.Drawing.Size(frm.Size.Width, Me.Size.Height)
        '    If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '        XtraMessageBox.Show(Sorgu_sDil("Kontrol Ediliyor...")
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        '    Me.Size = New System.Drawing.Size(Me.Size.Width + 190, Me.Size.Height)
        '    Me.Location = New System.Drawing.Size(Me.Location.X + 95, Me.Location.Y)
        '    toplam_hesapla()
        'End If
    End Sub
    Private Sub analiz_envanter()
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
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
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
    Private Sub stok_yeni(Optional ByVal sBarkod As String = "")
        Dim frm As New frm_stok_kart_kisa
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sModel = ""
        frm.nStokID = 0
        frm.sKodu = ""
        frm.txt_sKodu.Text = sBarkod
        frm.txt_sBarkod.Text = sBarkod
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                txt_ara.Text = frm.sModel
                stok_kontrol(sBarkod)
            End If
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            'frm.sRenk = dr("sRenk")
            'frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            frm.nAST = 3
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
            frm.lKodu = dr_baslik("lKodu")
            frm.nMusteriID = dr_baslik("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                loaded()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_adi()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim stok_kayit_sayisi As Int64 = 0
            stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr("sKodu")), sec_kriter.Text)
            If stok_kayit_sayisi = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Resmi Stok Kaydı Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim frm As New frm_stok_karti_adi
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.connection_resmi = connection_resmi
                frm.nStokID = dr("nStokId")
                frm.txt_stokkodu.Text = dr("sKodu")
                frm.txt_aciklama1.Text = dr("sAciklama")
                frm.nStokID_resmi = sorgu_nStokID(Trim(dr("sKodu")))
                frm.txt_aciklama2.Text = sorgu_stok_sAciklama(Trim(dr("sKodu")))
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
    Private Sub analiz_bekleyen(ByVal stoklar As String)
        Dim frm As New frm_satis_bekleyen_onaysiz
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.kasiyerno = kasiyerno
        'frm.kasiyer = kasiyer
        'frm.stokkodu = stokkodu
        frm.stoklar = stoklar
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        'frm.qstokkodu = "Eşittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_bekleyen_stok_durum(ByVal stoklar As String)
        Dim frm As New frm_satis_bekleyen_stok_durum
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokkodu = stokkodu
        frm.status = True
        frm.stoklar = stoklar
        frm.islemstatus = False
        'frm.tarih1 = "01/01/1900"
        'frm.tarih2 = "31/12/2048"
        'frm.qstokkodu = "Eşittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_stok_teslimatlari()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.bPerakende = True
            frm.nFirmaID = dr_baslik("nMusteriID")
            frm.sec_firma.Checked = True
            frm.sec_giris.Text = "Teslimatlar"
            frm.kullanici = kullanici
            frm.islemstatus = True
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
            Dim frm As New frm_stok_satis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = dr_baslik("nMusteriID")
            frm.nStokID = dr("nStokID")
            frm.kullanici = kullanici
            frm.islemstatus = True
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("lBrutFiyat") = Math.Abs(dr1("Fiyat"))
                dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
                dr("nIskontoYuzdesi") = (dr1("Iskonto") / Math.Abs(dr("lBrutTutar"))) * 100
                dr("lIskontoTutari") = (dr("lBrutTutar") * dr("nIskontoYuzdesi")) / 100
                dr("sFiyatTipi") = dr1("sFiyatTipi")
                'dr("nKdvOrani") = dr1("nKdvOrani")
                dr("sSaticiRumuzu") = dr1("sSaticiRumuzu")
                'dr("sFiyatTipi") = dr1("sFiyatTipi")
                dr1 = Nothing
                tutar_hesapla()
            End If
        End If
    End Sub
    Private Sub analiz_stok_hareket_iade_belirle()
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If GridView1.RowCount > 0 And Trim(dr("bEkAlan2")) = "" Then
                Dim frm As New frm_stok_satis
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.nMusteriID = dr_baslik("nMusteriID")
                frm.nStokID = dr("nStokID")
                frm.kullanici = kullanici
                frm.islemstatus = True
                frm.DateEdit1.EditValue = "01/01/1900"
                frm.DateEdit2.EditValue = "31/12/2078"
                frm.bBekleyen = True
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                    dr("lCikisMiktar1") = -dr("lCikisMiktar1")
                    dr("nGirisCikis") = 4
                    dr("lBrutFiyat") = Math.Abs(dr1("lBrutFiyat"))
                    dr("lBrutTutar") = dr1("lBrutTutar")
                    dr("sFiyatTipi") = dr1("sFiyatTipi")
                    dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesi")
                    dr("lIskontoTutari") = dr1("lIskontoTutari")
                    dr("sFiyatTipi") = dr1("sFiyatTipi")
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    dr("sSaticiRumuzu") = dr1("sSaticiRumuzu")
                    dr("lCikisFiyat") = Math.Abs(dr1("lFiyat"))
                    dr("lCikisTutar") = dr1("lTutar")
                    dr("dteTeslimEdilen") = dr_baslik("dteFaturaTarihi")
                    dr("bTeslimEdildi") = 1
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sAciklama") = "IadeAl;" & dr1("sMagaza") & ";" & dr1("nSiparisID") & ";" & dr1("KasiyerRumuzu") & ";" & dr1("dteTarih") & ";" & dr1("nAlisVerisID")
                    dr("bEkSoru") = 0
                    dr("bEkAlan1") = 1
                    dr("bEkAlan2") = dr1("nSiparisID")
                    dr("dteOnayTarihi") = dr_baslik("dteFaturaTarihi")
                    tutar_hesapla()
                    tbAlisVerisSiparis_iade_kaydet_duzelt(dr1("sMagaza"), dr("bEkAlan2"), dr("nStokID"), dr("sIadeNedeni"), dr("dteTeslimEdilen"), CType(dr("bTeslimEdildi"), Byte), "IadeEt;" & dr("sMagazaKodu") & ";" & dr("nSiparisID") & ";" & dr("sKasiyerRumuzu") & ";" & dr_baslik("dteFaturaTarihi") & ";" & dr_baslik("nAlisVerisID"), dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("dteOnayTarihi"))
                    dr1 = Nothing
                    XtraMessageBox.Show("İade Satırı Belirleme İşlemi Başarıyla Tamamlandı...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub satir_ekle_stok_iade()
        If Trim(dr_baslik("sFisTipi")) = "K" Or Trim(dr_baslik("sFisTipi")) = "P" Then
            Dim frm As New frm_stok_satis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = dr_baslik("nMusteriID")
            frm.kullanici = kullanici
            frm.islemstatus = True
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            frm.bSatilan = True
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                Dim dr1 As DataRow
                Dim lKur As Decimal = 0
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_hareket.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        Dim nIslemID As Int64 = sorgu_nStokIslemID()
                        dr("nIslemID") = nIslemID
                        dr("nStokID") = dr1("nStokId")
                        dr("sKodu") = dr1("sKodu")
                        dr("sStokAciklama") = dr1("sStokAciklama")
                        dr("sModel") = dr1("sModel")
                        dr("sRenkAdi") = dr1("sRenkAdi")
                        dr("sBeden") = dr1("sBeden")
                        'dr("sKavala") = dr1("sKavala")
                        dr("sAciklama") = "" ' dr1("sAciklama")
                        dr("sDepo") = dr_baslik("sMagaza")
                        dr("dteIslemTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("nFirmaID") = 0
                        dr("nMusteriID") = dr_baslik("nMusteriID")
                        dr("sFisTipi") = dr_baslik("sFisTipi")
                        dr("dteFisTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("lFisNo") = dr_baslik("lFaturaNo")
                        dr("sDepo") = dr_baslik("sMagaza")
                        dr("lReyonFisNo") = 0
                        dr("sStokIslem") = dr_baslik("sFisTipi")
                        dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
                        dr("sSaticiRumuzu") = dr1("sSaticiRumuzu")
                        If sDatabaseGenel = "UGURLU" Then
                            If sFiyatTipi = sFiyat1 Then
                                dr("sOdemeKodu") = "0   "
                            ElseIf sFiyatTipi = sFiyat2 Then
                                dr("sOdemeKodu") = "6   "
                            ElseIf sFiyatTipi = sFiyat3 Then
                                dr("sOdemeKodu") = "10  "
                            Else
                                dr("sOdemeKodu") = sOdemeKodu
                            End If
                        Else
                            dr("sOdemeKodu") = sOdemeKodu
                        End If
                        dataload_odemekodu(sFiyatTipi)
                        dr("dteIrsaliyeTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("lIrsaliyeNo") = 0
                        dr("lGirisMiktar1") = 0
                        dr("lGirisMiktar2") = 0
                        dr("lGirisFiyat") = 0
                        dr("lGirisTutar") = 0
                        dr("lCikisMiktar1") = -dr1("Miktar")
                        dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
                        dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
                        dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
                        dr("lBrutFiyat") = dr1("lBrutFiyat")
                        dr("lBrutTutar") = -dr1("lBrutTutar")
                        dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                        dr("lDovizKuru1") = dr1("lDovizKuru1")
                        dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                        dr("sDovizCinsi2") = ""
                        dr("lDovizKuru2") = 0
                        dr("lDovizMiktari2") = 0
                        dr("sFiyatTipi") = dr1("sFiyatTipi")
                        dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesi")
                        dr("nKdvOrani") = dr1("nKdvOrani")
                        dr("lCikisFiyat") = dr1("lFiyat")
                        dr("lCikisTutar") = -dr1("lTutar")
                        dr("lIskontoTutari") = -dr1("lIskontoTutari")
                        ''dr("sIadeNedeni") = ""
                        ''dr("nPartiID") = 0
                        ''dr("dteTeslimEdilecek") = dr_baslik("dteFaturaTarihi")
                        ''dr("dteTeslimEdilen") = dr_baslik("dteFaturaTarihi")
                        ''dr("bTeslimEdildi") = 1
                        'dr("bMuhasebeyeIslendimi") = 0
                        'dr("sAciklama") = dr1("sStokAciklama")
                        ''dr("bEkSoru") = 0
                        'dr("bEkAlan1") = 0
                        'dr("bEkAlan2") = 0
                        ''dr("dteOnayTarihi") = "01/01/1900"
                        'dr("sSonKullaniciAdi") = kullaniciadi
                        'dr("dteSonUpdateTarihi") = Now
                        'dr("nGirisCikis") = 4
                        'dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
                        'dr("sBirimCinsi1") = dr1("sBirimCinsi1")
                        'dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
                        'dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
                        'dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
                        dr("lMaliyetFiyat") = dr1("MALIYET")
                        dr("lMaliyetTutar") = dr1("MALIYET") * mevcut
                        dr("lIlaveMaliyetTutar") = 0
                        dr("sDovizCinsi") = ""
                        dr("lDovizFiyat") = 0
                        dr("nReceteNo") = 0
                        dr("nHesapID") = 0
                        dr("sAciklama") = "" 'dr1("sAciklama")
                        dr("sHareketTipi") = dr_baslik("sHareketTipi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = dr_baslik("dteFaturaTarihi") + " " + Now.ToLongTimeString
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("nOTVOrani") = 0
                        dr("nAlisverisID") = nAlisVerisID
                        dr("sMasrafYontemi") = ""
                        dr("sHangiUygulama") = ""
                        dr("nEkSaha1") = 0
                        dr("nEkSaha2") = 0
                        dr("bEkSoru1") = 0
                        dr("bEkSoru2") = 0
                        dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now
                        If dr("lCikisMiktar1") = 0 Then
                            dr("lCikisMiktar1") = 1
                            dr("nGirisCikis") = 3
                        ElseIf dr("lCikisMiktar1") < 0 Then
                            dr("nGirisCikis") = 4
                        ElseIf dr("lCikisMiktar1") > 0 Then
                            dr("nGirisCikis") = 3
                        End If
                        dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
                        dr("sBirimCinsi1") = dr1("sBirimCinsi1")
                        dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
                        dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
                        dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
                        dr("nPrim") = sorgu_sayi(sSaticiRumuzu_nPrim(dr("sSaticiRumuzu")), 0)
                        If dr("nPrim") = 0 Then
                            dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                        End If
                        'If dr1("nPrim") <> 0 Then
                        '    dr("nPrim") = sorgu_sayi(dr1("nPrim"), 0)
                        'End If
                        dr("lPrimTutari") = dr("lCikisTutar") * ((dr("nPrim")) / 100)
                        dr("nIslemID") = tbStokFisidetay_kaydet_yeni(dr("nIslemID"), dr("nStokID"), dr("dteIslemTarihi"), dr("nFirmaID"), dr("nMusteriID"), dr("sFisTipi"), dr("dteFisTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), sorgu_sayi(dr("lGirisMiktar1"), 0), sorgu_sayi(dr("lGirisMiktar2"), 0), sorgu_sayi(dr("lGirisFiyat"), 0), sorgu_sayi(dr("lGirisTutar"), 0), sorgu_sayi(dr("lCikisMiktar1"), 0), sorgu_sayi(dr("lCikisMiktar2"), 0), sorgu_sayi(dr("lCikisFiyat"), 0), sorgu_sayi(dr("lCikisTutar"), 0), dr("sFiyatTipi"), sorgu_sayi(dr("lBrutFiyat"), 0), sorgu_sayi(dr("lBrutTutar"), 0), sorgu_sayi(dr("lMaliyetFiyat"), 0), sorgu_sayi(dr("lMaliyetTutar"), 0), sorgu_sayi(dr("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr("nIskontoYuzdesi"), 0), sorgu_sayi(dr("lIskontoTutari"), 0), dr("sDovizCinsi"), sorgu_sayi(dr("lDovizFiyat"), 0), "", dr("nReceteNo"), "", "", sorgu_sayi(dr("nKdvOrani"), 0), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), sorgu_sayi(dr("lDovizMiktari1"), 0), sorgu_sayi(dr("lDovizKuru1"), 0), dr("sDovizCinsi2"), sorgu_sayi(dr("lDovizMiktari2"), 0), sorgu_sayi(dr("lDovizKuru2"), 0), sorgu_sayi(dr("nOTVOrani"), 0), "", nAlisVerisID, 0, "", dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), 0, 0)
                        ds_hareket.Tables(0).Rows.Add(dr)
                        fis_detay_fisno_degistir(dr("nIslemID"))
                        Me.Refresh()
                    Next
                    toplam_hesapla()
                    If GridView1.RowCount > 0 Then
                        GridView1.ClearSelection()
                        GridView1.SelectRow(GridView1.RowCount - 1)
                        PanelEkle.Focus()
                        GridControl1.Focus()
                    End If
                    GridView1.FocusedColumn = collGCMiktar
                End If
            Else
                'tutar_hesapla()
            End If
        End If
    End Sub
    Private Sub analiz_stok_hareket_iade()
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            Dim frm As New frm_stok_satis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = dr_baslik("nMusteriID")
            frm.kullanici = kullanici
            frm.islemstatus = True
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            frm.bBekleyen = True
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                Dim dr1 As DataRow
                Dim lKur As Decimal = 0
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString()
                        dr = ds_hareket.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        Dim nSiparisID As Int64 = sorgu_nSiparisID(dr_baslik("sMagaza"))
                        fatTarih = dr1("dteTarih")
                        dr("nAlisVerisID") = nAlisVerisID
                        dr("sMagazaKodu") = dr_baslik("sMagaza")
                        dr("nSiparisID") = nSiparisID
                        dr("nGirisCikis") = 4
                        dr("nStokID") = dr1("nStokID")
                        dr("sKodu") = dr1("sKodu")
                        dr("sStokAciklama") = dr1("sStokAciklama")
                        dr("sModel") = dr1("sModel")
                        dr("sRenkAdi") = dr1("sRenkAdi")
                        dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
                        dr("sSaticiRumuzu") = dr1("sSaticiRumuzu")
                        dr("sOdemeKodu") = dr1("sOdemeKodu")
                        dataload_odemekodu(sFiyatTipi)
                        dr("lReyonFisNo") = 0
                        dr("sFiyatTipi") = sFiyatTipi
                        dr("lCikisMiktar1") = -dr1("Miktar")
                        dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
                        dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
                        dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
                        dr("lBrutFiyat") = dr1("lBrutFiyat")
                        dr("lBrutTutar") = -dr1("lBrutTutar")
                        dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                        dr("lDovizKuru1") = dr1("lDovizKuru1")
                        dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                        dr("sFiyatTipi") = dr1("sFiyatTipi")
                        dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesi")
                        dr("nKdvOrani") = dr1("nKdvOrani")
                        dr("lCikisFiyat") = dr1("lFiyat")
                        dr("lCikisTutar") = -dr1("lTutar")
                        dr("lIskontoTutari") = -dr1("lIskontoTutari")
                        dr("sIadeNedeni") = ""
                        dr("nPartiID") = 0
                        dr("dteTeslimEdilecek") = dr_baslik("dteFaturaTarihi")
                        dr("dteTeslimEdilen") = dr_baslik("dteFaturaTarihi")
                        dr("bTeslimEdildi") = 1
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sAciklama") = "IadeAl;" & dr1("sMagaza") & ";" & dr1("nSiparisID") & ";" & dr1("KasiyerRumuzu") & ";" & dr1("dteTarih") & ";" & dr1("nAlisVerisID")
                        dr("bEkSoru") = 0
                        dr("bEkAlan1") = Math.Abs(dr1("Miktar"))
                        dr("bEkAlan2") = dr1("nSiparisID")
                        dr("dteOnayTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now
                        dr("nGirisCikis") = 4
                        dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
                        dr("sBirimCinsi1") = dr1("sBirimCinsi1")
                        dr("lHBrutFiyat") = dr("lBrutFiyat") / ((dr("nKdvOrani") + 100) / 100)
                        dr("lHBrutTutar") = dr("lBrutTutar") / ((dr("nKdvOrani") + 100) / 100)
                        dr("lHDovizMiktari1") = dr("lDovizMiktari1") / ((dr("nKdvOrani") + 100) / 100)
                        tbAlisVerisSiparis_kaydet_yeni(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), sorgu_sayi(dr("nPrim"), 0), sorgu_sayi(dr("lPrimTutari"), 0))
                        tbAlisVerisSiparis_iade_kaydet_duzelt(dr1("sMagaza"), dr("bEkAlan2"), dr("nStokID"), dr("sIadeNedeni"), dr("dteTeslimEdilen"), CType(dr("bTeslimEdildi"), Byte), "IadeEt;" & dr("sMagazaKodu") & ";" & dr("nSiparisID") & ";" & dr("sKasiyerRumuzu") & ";" & dr_baslik("dteFaturaTarihi") & ";" & dr_baslik("nAlisVerisID"), dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("dteOnayTarihi"))
                        tbAvSirano_degistir(5, nSiparisID, dr1("sMagaza"))
                        ds_hareket.Tables(0).Rows.Add(dr)
                        Me.Refresh()
                    Next
                    toplam_hesapla()
                    If GridView1.RowCount > 0 Then
                        GridView1.ClearSelection()
                        GridView1.SelectRow(GridView1.RowCount - 1)
                        PanelEkle.Focus()
                        GridControl1.Focus()
                    End If
                    GridView1.FocusedColumn = collGCMiktar
                End If
            Else
                'tutar_hesapla()
            End If
        End If
    End Sub
    Private Sub analiz_siparis_bekleyen_tumu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_siparis_verilen_bekleyen
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr_baslik("sKodu")
            'frm.nFirmaID = dr("nFirmaID")
            'frm.sec_firma.Checked = True
            'frm.sec_giris.Text = "Girişler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_satislar()
        Dim frm As New frm_stok_satis
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.musterino = dr_baslik("nMusteriID")
        frm.txt_ara.Text = dr_baslik("lKodu")
        'frm.firmatipi = firmatipi
        frm.sec_konum.Text = "Kodu"
        frm.kullanici = kullanici
        frm.Show()
    End Sub
    Private Sub satir_info()
        Try
            If info = True And dr_param("bEnvanterGosterilsinmi") = True Then
                If GridView1.RowCount > 0 Then
                    Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    ds_satir_stok = sorgu_stok_info(dr("sKodu"))
                    Dim dr1 As DataRow = ds_satir_stok.Tables(0).Rows(0)
                    If dr1("sRenkAdi").ToString <> "" Then
                        label2.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ")" & vbCrLf & "Giren: " & CType(dr1("GIREN"), Int64) & " Çıkan: " & CType(dr1("CIKAN"), Int64) & " Mevcut: " & CType(dr1("KALAN"), Int64) & " Bekleyen: " & CType(dr1("BEKLEYEN"), Int64)
                    ElseIf Trim(dr1("sBeden").ToString) <> "" Then
                        label2.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ") (Beden: " & Trim(dr1("sBeden")) & ")" & vbCrLf & "Giren: " & CType(dr1("GIREN"), Int64) & " Çıkan: " & CType(dr1("CIKAN"), Int64) & " Mevcut: " & CType(dr1("KALAN"), Int64) & " Bekleyen: " & CType(dr1("BEKLEYEN"), Int64)
                    Else
                        label2.Text = dr1("STOKADI") & vbCrLf & "Giren: " & CType(dr1("GIREN"), Int64) & " Çıkan: " & CType(dr1("CIKAN"), Int64) & " Mevcut: " & CType(dr1("KALAN"), Int64) & " Bekleyen: " & CType(dr1("BEKLEYEN"), Int64)
                    End If
                    label2.Text += vbCrLf & "Miktar: " & CType(dr("lCikisMiktar1"), Int64) & " Tutar : " & FormatNumber(dr("lBrutTutar"), 2)
                    label2.Refresh()
                    If dr1("KALAN") > 0 Then
                        Me.label2.ForeColor = System.Drawing.Color.White
                    ElseIf dr1("KALAN") < 0 Then
                        Me.label2.ForeColor = System.Drawing.Color.Red
                    ElseIf dr1("KALAN") = 0 Then
                        Me.label2.ForeColor = System.Drawing.Color.GreenYellow
                    End If
                    dr1 = Nothing
                End If
                If dr("sFiyatTipi") <> sFiyatTipi Then
                    sFiyatTipi = dr("sFiyatTipi")
                    dataload_odemekodu(sFiyatTipi)
                End If
                If dr("sSaticiRumuzu") <> sSaticiRumuzu Then
                    sSaticiRumuzu = dr("sSaticiRumuzu")
                End If
                If dr("sOdemeKodu") <> sOdemeKodu Then
                    sOdemeKodu = dr("sOdemeKodu")
                End If
            Else
                label2.Text = ""
            End If
        Catch ex As Exception
            'sFiyatTipi = "PS"
            'sSaticiRumuzu = ""
            'sOdemeKodu = ""
        End Try
    End Sub
    Private Function satir_kontrol(Optional ByVal etiket As Boolean = False)
        Dim satir As String = " ("
        If etiket = True Then
            satir = "WHERE stok.nStokId IN ("
        End If
        Dim toplamsayi = GridView1.RowCount
        Dim sayi = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_hareket.Tables(0).Rows
            satir += dr1("nStokID").ToString
            sayi += 1
            If sayi < toplamsayi Then
                satir += ","
            ElseIf sayi = toplamsayi Then
                satir += ")"
            End If
        Next
        Return satir
    End Function
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat, 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lDovizKuru(ByVal sDovizCinsi As String, ByVal dteKurTarihi As DateTime, ByVal sKur As String) As Decimal
        If sKur = "Alış" Then
            sKur = "lAlisKuru"
        ElseIf sKur = "Satış" Then
            sKur = "lSatisKuru"
        ElseIf sKur = "Efektif Alış" Then
            sKur = "lEfektifAlisKuru"
        ElseIf sKur = "Efektif Satış" Then
            sKur = "lEfektifSatisKuru"
        ElseIf sKur = "Merkez Bankası Alış" Then
            sKur = "lMerkezBankasiAlisKuru"
        ElseIf sKur = "Merkez Bankası Satış" Then
            sKur = "lMerkezBankasiSatisKuru"
        End If
        Dim kriter
        kriter = "WHERE     (sDovizCinsi = '" & sDovizCinsi & "') AND (dteKurTarihi = '" & dteKurTarihi & "')"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(" & sKur & ",0)  FROM         tbDovizKuru " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(" & sKur & ",0)  FROM         tbDovizKuru Where sDovizCinsi ='" & sDovizCinsi & "' Order by dteKurTarihi DESC")
            kayitsayisi = cmd.ExecuteScalar
        End If
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub raporla(ByVal rapor As Integer, ByVal nIslem As Integer, Optional ByVal bFis As Boolean = False, Optional ByVal bFatura As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        Dim hizliIslem As Boolean = dr_param("bHizliYazdir")
        OpenFileDialog1.Title = "Rapor Seç..."
        If bFatura = False Then
            If hizliIslem = True Then
                OpenFileDialog1.Filter = "Rapor Dosyaları (PerakendeSatis_Termal*.fr*) |PerakendeSatis_Termal*.fr*"
                OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis_Termal" & sRaporUzanti & ""
            Else
                OpenFileDialog1.Filter = "Rapor Dosyaları (PerakendeSatis*.fr*) |PerakendeSatis*.fr*"
                OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis" & sRaporUzanti & ""
            End If
        Else
            If hizliIslem = True Then
                OpenFileDialog1.Filter = "Rapor Dosyaları (PerakendeSatis_Termal*.fr*) |PerakendeSatis_Termal*.fr*"
                OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis_Termal" & sRaporUzanti & ""
            Else
                OpenFileDialog1.Filter = "Rapor Dosyaları (PerakendeSatis*.fr*) |PerakendeSatis*.fr*"
                OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis_Fatura" & sRaporUzanti & ""
            End If
        End If
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        Dim sFile = OpenFileDialog1.FileName.ToString
        If bFatura = True Then
            sFile = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis_fatura" & sRaporUzanti & ""
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                report_create_stok(sFile, "", nIslem)
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                report_create(sFile, "", nIslem)
            End If
            'report_create_stok(sFile, "", nIslem)
        ElseIf bFis = True Then
            If hizliIslem = True Then
                sFile = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis_Termal" & sRaporUzanti & ""
            Else
                sFile = "c:\Formlar\Raporlar\Dokumler\PerakendeSatis" & sRaporUzanti & ""
            End If
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                report_create_stok(sFile, "", nIslem)
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                report_create(sFile, "", nIslem)
            End If
            'report_create_stok(sFile, "", nIslem)
        Else
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sFile = OpenFileDialog1.FileName.ToString
                If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                    report_create_stok(sFile, "", nIslem)
                ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                    report_create(sFile, "", nIslem)
                End If
            End If
        End If
    End Sub
    Private Sub report_create(ByVal sFile As String, ByVal kriter As String, ByVal nIslem As Integer)
        Dim report As New FastReport.Report
        report.Load(sFile)
        ds_baslik = sorgu_baslik("")
        ds_toplam = sorgu_toplam("")
        ds_hareket = sorgu_harekets(dr_baslik("sFisTipi"), "")
        report.RegisterData(ds_baslik)
        report.RegisterData(ds_hareket)
        report.RegisterData(ds_toplam)
        report.SetParameterValue("dteFaturaTarihi", dr_baslik("dteFaturaTarihi"))
        report.SetParameterValue("lFaturaNo", dr_baslik("lFaturaNo"))
        report.SetParameterValue("sFisTipi", dr_baslik("sFisTipi"))
        Dim sIsim As String = ""
        sIsim = dr_baslik("sAdi") & " " & dr_baslik("sSoyadi")
        Dim gun_evlilik As String = ""
        'Dim gun_dogum
        'Dim yil
        'Dim gun
        'Dim ay
        'If Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(3, 2) = "01" Then
        'ElseIf Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 5) = "01/01" Then
        'Else
        '    sIsim += "  Evlilik Tarihi :" & dr("EVLILIKTARIHI")
        '    yil = Today.ToString.Substring(8, 2)
        '    gun = dr_baslik("EVLILIKTARIHI").ToString.Substring(0, 2)
        '    ay = dr_baslik("EVLILIKTARIHI").ToString.Substring(3, 2)
        '    sIsim += "  Evlilik Yıldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
        '    gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
        '    If gun_dogum > 0 And gun_dogum < 30 Then
        '        sIsim += " " & gun_dogum & " Gün Sonra Evlilik Yıldönümünüz.Şimdiden Evlilik Yıldönümünüz Kutlu Olsun..!"
        '    ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
        '        sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yıldönümünüzmüş...Nice Senelere..!"
        '    ElseIf gun_dogum = 0 Then
        '        sIsim += "  Evlilik Yıldönümünüz Kutlu Olsun...!"
        '    End If
        'End If
        report.SetParameterValue("Anons", "" & sIsim & "")
        If dr_toplam("lToplamMiktar") > 0 Then
            If Trim(dr_baslik("sFisTipi")) = "K" Then
                report.SetParameterValue("BelgeTipi", "Kredili Satış")
            ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Kredili Satış")
            ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Peşin Satış")
            ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                report.SetParameterValue("BelgeTipi", "Peşin Satış")
            End If
        ElseIf dr_toplam("lToplamMiktar") <= 0 Then
            If Trim(dr_baslik("sFisTipi")) = "K" Then
                report.SetParameterValue("BelgeTipi", "Kredili Satış İade/Değişim")
            ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Kredili Satış İade/Değişim")
            ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Peşin Satışİade/Değişim")
            ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                report.SetParameterValue("BelgeTipi", "Peşin Satış İade/Değişim")
            End If
        End If
        report.SetParameterValue("lParaUstu", lParaUstu)
        report.SetParameterValue("lOdenen", lOdenen)
        report.SetParameterValue("lVeresiye", lVeresiye)
        Dim ds_pesinat As DataSet
        Dim ds_taksit As DataSet
        Dim ds_AVHediyeCeki As DataSet
        Dim ds_KalanPuan As DataSet
        Dim ds_TaksitKalan As DataSet
        Dim ds_Kampanya As DataSet
        Dim ds_Anons As DataSet
        Dim ds_MusteriKefil1 As DataSet
        ds_pesinat = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID "), "Pesinat")
        ds_taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
        ds_AVHediyeCeki = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, sAlinanBasilan, sHediyeCekiSeriNo, sHediyeCekiTipi, lTutar, dteGecerliBaslangicTarih, dteGecerliBitisTarih, lUzerindekiTutar, " & dr_toplam("lNetTutar") & " AS lAlisVerisTutari, lTutar / " & dr_toplam("lNetTutar") & "   * 100 AS nOran FROM tbAVHediyeCeki WHERE nAlisVerisID = '" & dr_baslik("nAlisVerisID") & "' "), "AVHediyeCeki")
        ds_KalanPuan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKazanilanPuan - lHarcananPuan), 0) AS lKalanPuan FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , SUM(tbAVHediyeCeki.lTutar) AS lKazanilanPuan , 0 AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi = 'ParaPU_KAZ') and tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu UNION ALL SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , 0 AS lKazanilanPuan , SUM(tbAVHediyeCeki.lTutar) AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi IN ('ParaPU_HAR','ParaPU_AL')) and tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbPuan Where (nMusteriID = " & dr_baslik("nMusteriID") & ") "), "KalanPuan")
        ds_TaksitKalan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi "), "KalanTaksit")
        ds_MusteriKefil1 = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteriKefil1 WHERE nMusteriID  = " & dr_baslik("nMusteriID") & "", "Kefil1")
        ds_Kampanya = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ATBLDOKUMKAMPANYA", "KAMPANYA")
        ds_Anons = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ATBLDOKUMANONS", "ANONS")
        report.RegisterData(ds_pesinat)
        report.RegisterData(ds_taksit)
        report.RegisterData(ds_AVHediyeCeki)
        report.RegisterData(ds_KalanPuan)
        report.RegisterData(ds_TaksitKalan)
        report.RegisterData(ds_MusteriKefil1)
        report.RegisterData(ds_Kampanya)
        report.RegisterData(ds_Anons)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 2 Then
            report.Design()
        ElseIf nIslem = 1 Then
            If dr_param("bDokumdeYaziciSorsun") = True Then
                report.Print()
            Else
                report.PrintSettings.ShowDialog = False
                report.Print()
            End If
        End If
        ds_pesinat = Nothing
        ds_taksit = Nothing
        ds_AVHediyeCeki = Nothing
        ds_KalanPuan = Nothing
        ds_TaksitKalan = Nothing
        report.Dispose()
        report = Nothing
    End Sub
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer, Optional ByVal bFis As Boolean = False, Optional ByVal bFatura As Boolean = False)
        Dim file As String
        Dim kriter As String
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Perakende_satis*.fr3) |Perakende_satis*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Perakende_satis.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        kriter = ""
        toplam_hesapla()
        If bFatura = True Then
            file = "c:\Formlar\Raporlar\Dokumler\Perakende_satis_fatura.fr3"
            report_create_stok(file, kriter, islem)
        ElseIf bFis = True Then
            file = "c:\Formlar\Raporlar\Dokumler\Perakende_satis.fr3"
            report_create_stok(file, kriter, islem)
        Else
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                file = OpenFileDialog1.FileName.ToString
                report_create_stok(file, kriter, islem)
            End If
        End If
    End Sub
    Private Sub raporla_etiket(ByVal islem As Integer, Optional ByVal carpan As Int64 = 1)
        Dim file As String
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyaları(*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If islem = 3 Then
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
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        file = OpenFileDialog1.FileName.ToString
                        fiyat1 = 0 'dr("FIYAT1")
                        fiyat2 = 0 'dr("FIYAT2")
                        fiyat3 = 0 'dr("FIYAT3")
                        miktar = Math.Abs(dr1("lCikisMiktar1")) * carpan
                        'report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        If Microsoft.VisualBasic.Right(file, 3) = "fr3" Then
                            report_create_etiket(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        ElseIf Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                            report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        End If
                    Next
                End If
            Else
                file = OpenFileDialog1.FileName.ToString
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                fiyat1 = 0 'dr("FIYAT1")
                fiyat2 = 0 'dr("FIYAT2")
                fiyat3 = 0 'dr("FIYAT3")
                miktar = Math.Abs(dr("lCikisMiktar1")) * carpan
                'report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                If Microsoft.VisualBasic.Right(file, 3) = "fr3" Then
                    report_create_etiket(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                ElseIf Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                    report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                End If
            End If
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        miktar = Nothing
        file = Nothing
    End Sub
    Private Function satir_kontrol_etiket()
        Dim satir As String = "WHERE stok.nStokId IN ("
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
            For Each i In arr
                s = i.ToString
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("nStokID").ToString
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
    End Function
    Private Sub report_create_etiket(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("FIYAT1", "" & fiyat1 & "")
            frx.SetVariable("lFiyat2", "" & fiyat2 & "")
            frx.SetVariable("lFiyat3", "" & fiyat3 & "")
            frx.SetVariable("FIYAT", "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
                frx.PrintReport()
            ElseIf status = 2 Then
                'frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "8"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "lFiyat1"
            args(15) = "" & fiyat1.ToString() & ""
            args(16) = "lFiyat2"
            args(17) = "" & fiyat2.ToString() & ""
            args(18) = "lFiyat3"
            args(19) = "" & fiyat3.ToString() & ""
            args(20) = "FIYAT"
            args(21) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)).ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 21
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub report_create_etiketX(ByVal sFile As String, ByVal kriter As String, ByVal nIslem As Integer, ByVal bMiktarli As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 2 Then
            report.Design()
        ElseIf nIslem = 1 Then
            report.Print()
        ElseIf nIslem = 3 Then
            report.PrintSettings.Copies = bMiktarli
            report.PrintSettings.ShowDialog = False
            report.Print()
        End If
        ds_etiket = Nothing
        report.Dispose()
        report = Nothing
    End Sub
    Private Function fiyat_gizle(ByVal deger As String) As String
        Dim x
        Dim mevcut
        Dim deger1 As String = ""
        Dim fiyat As String = FormatNumber(deger, 2)
        If CStr(fiyat) <> "" Then
            x = (fiyat).IndexOf(".", 1, (fiyat).Length - 1)
            If x = -1 Then
                mevcut = 1
            Else
                mevcut = (fiyat).Substring(0, x)
                deger1 = (fiyat).Substring((x + 1), (fiyat).Length - (x + 1)).ToString + "." + mevcut.ToString
            End If
        End If
        Return deger1.ToString
        x = Nothing
        mevcut = Nothing
        fiyat = Nothing
    End Function
    Private Function fiyat_gizle_tumu(ByVal fiyat1 As String, ByVal fiyat2 As String, ByVal fiyat3 As String)
        Dim deger1 As String = ""
        Dim deger2 As String = ""
        Dim deger3 As String = ""
        deger1 = fiyat_gizle(FormatNumber(fiyat1, 2)).ToString
        deger2 = fiyat_gizle(FormatNumber(fiyat2, 2)).ToString
        deger3 = fiyat_gizle(FormatNumber(fiyat3, 2)).ToString
        Return deger1 + "-" + deger2 + "-" + deger3
        deger1 = Nothing
        deger2 = Nothing
        deger3 = Nothing
    End Function
    Private Sub tbAVHediyeCeki()
        Dim frm As New frm_stok_pesin_puan
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.nAlisVerisID = dr_baslik("nAlisVerisID")
        frm.lAlisVerisTutari = dr_toplam("lNetTutar")
        frm.nMusteriID = dr_baslik("nMusteriID")
        frm.lPuanTutari = 0
        Dim sayi As Integer = 0
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            dr_toplam("lHarcananPuan") = frm.lPuanTutari
            dr_toplam("lKazanilanPuan") = frm.lKazanilanPuan
            'dr_toplam("lDipIskontoTutari") = frm.lPuanTutari
            'dr_toplam("nDipIskontoYuzdesi") = (dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100
            dr_toplam("lDipIskontoTutari") = dr_toplam("lDipIskontoTutari1") + dr_toplam("lHarcananPuan")
            If dr_toplam("lDipIskontoTutari") <> 0 Then
                dr_toplam("nDipIskontoYuzdesi") = (dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100
            Else
                dr_toplam("nDipIskontoYuzdesi") = 0
            End If
            VGrid_toplam.UpdateFocusedRecord()
            VGrid_toplam.CloseEditor()
            VGridToplam_degistir()
            sayi = 1
        End If
        If sayi = 0 Then
            dr_toplam("lHarcananPuan") = frm.lPuanTutari
            dr_toplam("lKazanilanPuan") = frm.lKazanilanPuan
            dr_toplam("lDipIskontoTutari") = dr_toplam("lDipIskontoTutari1") + dr_toplam("lHarcananPuan")
            If dr_toplam("lDipIskontoTutari") <> 0 Then
                dr_toplam("nDipIskontoYuzdesi") = (dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100
            Else
                dr_toplam("nDipIskontoYuzdesi") = 0
            End If
            'dr_toplam("lDipIskontoTutari") = frm.lPuanTutari
            'dr_toplam("nDipIskontoYuzdesi") = (dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100
            VGrid_toplam.UpdateFocusedRecord()
            VGrid_toplam.CloseEditor()
            VGridToplam_degistir()
            toplam_hesapla()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub tbMusteri_yeni()
        If KayitSiniri_kontrol("tbMusteri", "", nKayitSinir) = True Then
            Dim frm As New frm_musteri_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = 0
            frm.kullanici = kullanici
            frm.sMagaza = dr_baslik("sMagaza")
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    'txt_musterino.Text = frm.txt_musteriNo.Text
                    If XtraMessageBox.Show(Sorgu_sDil("Satisi Hesaba Aktarmak İster misiniz ? ", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        If Trim(dr_baslik("sFisTipi")) = "P" Then
                            If XtraMessageBox.Show(Sorgu_sDil("Satışı Kredili Satışa Çevirmek İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                                sFisTipi = "K "
                                If Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "K" Then
                                    sFiyatTipi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sKrediliFiyatTipi").ToString()
                                ElseIf Trim(sFisTipi) = "SP" Or Trim(sFisTipi) = "P" Then
                                    sFiyatTipi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sPesinFiyatTipi").ToString
                                End If
                                lFaturaNo = sorgu_lFaturaNo(dr_baslik("sMagaza"), dr_baslik("sFisTipi"))
                            End If
                        Else
                            'lFaturaNo = sorgu_lFaturaNo(dr_baslik("sMagaza"), dr_baslik("sFisTipi"))
                            lFaturaNo = dr_baslik("lFaturaNo") 'sorgu_lFaturaNo(dr_baslik("sMagaza"), dr_baslik("sFisTipi"))
                        End If
                        Dim pass As Boolean = tbAlisVeris_musteri_degistir(nAlisVerisID, sFisTipi, lFaturaNo, frm.nMusteriID, Trim(frm.txt_sAdi.Text), Trim(frm.txt_sSoyadi.Text))
                        If pass = True Then
                            dr_baslik("sFisTipi") = sFisTipi
                            dr_baslik("lFaturaNo") = lFaturaNo
                            dr_baslik("nMusteriID") = frm.nMusteriID
                            dr_baslik("sAlisverisYapanAdi") = frm.txt_sAdi.Text
                            dr_baslik("sAlisverisYapanSoyadi") = frm.txt_sSoyadi.Text
                            dr_baslik("sAdi") = frm.txt_sAdi.Text
                            dr_baslik("sSoyadi") = frm.txt_sSoyadi.Text
                            dr_baslik("Musteri") = frm.txt_sAdi.Text + " " + frm.txt_sSoyadi.Text
                            'İskonto Güncelle
                            'If Trim("sFisTipi") = "K" Then
                            '    dr_toplam("nDipIskontoYuzdesi") = dr1("nIskontoKredili")
                            'ElseIf Trim("sFisTipi") = "P" Then
                            '    dr_toplam("nDipIskontoYuzdesi") = dr1("nIskontoPesin")
                            'End If
                            If dr_toplam("nDipIskontoYuzdesi") > nMaxIskontoYuzdesi Then
                                dr_toplam("nDipIskontoYuzdesi") = nMaxIskontoYuzdesi
                            End If
                            toplam_hesapla()
                            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                                tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                            Else
                                tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                            End If
                            Dim satir = GridView1.FocusedRowHandle
                            dataload_harekets()
                            GridView1.FocusedRowHandle = satir
                            toplam_hesapla()
                        End If
                        pass = Nothing
                    End If
                End If
            End If
        End If
    End Sub
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
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_toplam As New TfrxADOQuery
            Dim qr_pesinat As New TfrxADOQuery
            Dim qr_taksit As New TfrxADOQuery
            Dim qr_kalan As New TfrxADOQuery
            Dim qr_AVHediyeCeki As New TfrxADOQuery
            Dim qr_KalanPuan As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            Dim sIsim As String = ""
            sIsim = dr_baslik("sAdi") & " " & dr_baslik("sSoyadi")
            Dim gun_evlilik As String = ""
            Dim gun_dogum As String = ""
            Dim yil As String = ""
            Dim gun As String = ""
            Dim ay As String = ""
            'If Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(3, 2) = "01" Then
            'ElseIf Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            'Else
            '    'lbl_isim.Text += "  Doğum Tarihi :" & dr("DOGUMTARIHI").ToLongDateString
            '    yil = Today.ToString.Substring(8, 2)
            '    gun = dr_baslik("DOGUMTARIHI").ToString.Substring(0, 2)
            '    ay = dr_baslik("DOGUMTARIHI").ToString.Substring(3, 2)
            '    sIsim += "  Doğum Günü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
            '    gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
            '    If gun_dogum > 0 And gun_dogum < 30 Then
            '        sIsim += " " & gun_dogum & " Gün Sonra Doğum Gününüz.Şimdiden Doğum Gününüz Kutlu Olsun..!"
            '    ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
            '        sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Doğum Gününüzmüş...Nice Senelere..!"
            '    ElseIf gun_dogum = 0 Then
            '        sIsim += "  Doğum Gününüz Kutlu Olsun...!"
            '    End If
            'End If
            'If Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(3, 2) = "01" Then
            'ElseIf Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            'Else
            '    sIsim += "  Evlilik Tarihi :" & dr("EVLILIKTARIHI")
            '    yil = Today.ToString.Substring(8, 2)
            '    gun = dr_baslik("EVLILIKTARIHI").ToString.Substring(0, 2)
            '    ay = dr_baslik("EVLILIKTARIHI").ToString.Substring(3, 2)
            '    sIsim += "  Evlilik Yıldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
            '    gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
            '    If gun_dogum > 0 And gun_dogum < 30 Then
            '        sIsim += " " & gun_dogum & " Gün Sonra Evlilik Yıldönümünüz.Şimdiden Evlilik Yıldönümünüz Kutlu Olsun..!"
            '    ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
            '        sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yıldönümünüzmüş...Nice Senelere..!"
            '    ElseIf gun_dogum = 0 Then
            '        sIsim += "  Evlilik Yıldönümünüz Kutlu Olsun...!"
            '    End If
            'End If
            frx.SetVariable("Anons", "'" & sIsim & "'")
            If dr_toplam("lToplamMiktar") > 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satış'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satış'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peşin Satış'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    frx.SetVariable("BelgeTipi", "'Peşin Satış'")
                End If
            ElseIf dr_toplam("lToplamMiktar") <= 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satış İade/Değişim'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satış İade/Değişim'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peşin Satışİade/Değişim'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    frx.SetVariable("BelgeTipi", "'Peşin Satış İade/Değişim'")
                End If
            End If
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_txt_baslik
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_txt_hareket
            qr_toplam = frx.FindObject("qr_toplam")
            qr_toplam.Query = sorgu_txt_toplam
            qr_pesinat = frx.FindObject("qr_pesinat")
            qr_pesinat.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID ")
            qr_taksit = frx.FindObject("qr_taksit")
            qr_taksit.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID ")
            Try
                qr_AVHediyeCeki = frx.FindObject("qr_AVHediyeCeki")
                qr_AVHediyeCeki.Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, sAlinanBasilan, sHediyeCekiSeriNo, sHediyeCekiTipi, lTutar, dteGecerliBaslangicTarih, dteGecerliBitisTarih, lUzerindekiTutar, " & dr_toplam("lNetTutar") & " AS lAlisVerisTutari, lTutar / " & dr_toplam("lNetTutar") & "   * 100 AS nOran FROM tbAVHediyeCeki WHERE nAlisVerisID = '" & dr_baslik("nAlisVerisID") & "' ")
            Catch ex As Exception
            End Try
            Try
                qr_KalanPuan = frx.FindObject("qr_KalanPuan")
                qr_KalanPuan.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKazanilanPuan - lHarcananPuan), 0) AS lKalanPuan FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , SUM(tbAVHediyeCeki.lTutar) AS lKazanilanPuan , 0 AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi = 'ParaPU_KAZ') and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu UNION ALL SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , 0 AS lKazanilanPuan , SUM(tbAVHediyeCeki.lTutar) AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi IN ('ParaPU_HAR','ParaPU_AL')) and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbPuan Where (nMusteriID = " & dr_baslik("nMusteriID") & ") ")
            Catch ex As Exception
            End Try
            qr_taksit = frx.FindObject("qr_kalan")
            qr_taksit.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi ")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            qr_toplam.DataBase = qr_connection
            qr_pesinat.DataBase = qr_connection
            qr_taksit.DataBase = qr_connection
            frx.OldStyleProgress = True
            If status = 0 Then
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.DisableDialogs = True
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.DesignReport()
            ElseIf status = 3 Then
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(4) = "" & status.ToString() & ""
            args(5) = "6"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            Dim sIsim As String = ""
            sIsim = dr_baslik("sAdi") & " " & dr_baslik("sSoyadi")
            Dim gun_evlilik As String = ""
            Dim gun_dogum As String = ""
            Dim yil As String = ""
            Dim gun As String = ""
            Dim ay As String = ""
            args(14) = "Anons"
            args(15) = "'" & sIsim & "'"
            If dr_toplam("lToplamMiktar") > 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Kredili Satış'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Kredili Satış'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Peşin Satış'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Peşin Satış'"
                End If
            ElseIf dr_toplam("lToplamMiktar") <= 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Kredili Satış İade/Değişim'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Kredili Satış İade/Değişim'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Peşin Satışİade/Değişim'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Peşin Satış İade/Değişim'"
                End If
            End If
            args(2) = "" & sorgu_txt_baslik & "é" & sorgu_txt_hareket & "é" & sorgu_txt_toplam & "é" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbOdeme WHERE (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID ") & "é" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbTaksit WHERE (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID ") & "é" & sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, sAlinanBasilan, sHediyeCekiSeriNo, sHediyeCekiTipi, lTutar, dteGecerliBaslangicTarih, dteGecerliBitisTarih, lUzerindekiTutar, " & dr_toplam("lNetTutar") & " AS lAlisVerisTutari, lTutar / " & dr_toplam("lNetTutar") & "   * 100 AS nOran FROM tbAVHediyeCeki WHERE nAlisVerisID = '" & dr_baslik("nAlisVerisID") & "' ") & "é" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKazanilanPuan - lHarcananPuan), 0) AS lKalanPuan FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , SUM(tbAVHediyeCeki.lTutar) AS lKazanilanPuan , 0 AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi = 'ParaPU_KAZ') and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu UNION ALL SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , 0 AS lKazanilanPuan , SUM(tbAVHediyeCeki.lTutar) AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi IN ('ParaPU_HAR','ParaPU_AL')) and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbPuan Where (nMusteriID = " & dr_baslik("nMusteriID") & ") ") & "é" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi ") & ""
            args(3) = "qr_baslikéqr_hareketéqr_toplaméqr_pesinatéqr_taksitéqr_AVHediyeCekiéqr_KalanPuanéqr_kalan"
            processYol = args(0)
            For i As Integer = 1 To 17
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Down Then
            If GridView1.FocusedRowHandle = GridView1.RowCount - 1 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            ElseIf GridView1.RowCount = 0 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If GridView1.RowCount = 0 Then
                VGrid_baslik.Focus()
            ElseIf GridView1.FocusedRowHandle + 1 = 0 Then
                VGrid_baslik.Focus()
            End If
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Try
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sFiyatTipi")) = "HD" Or Decimal.Parse(Trim(dr("lBrutFiyat"))) < 0.25 Or Decimal.Parse(Trim(dr("lBrutTutar"))) < 0.25 Then
                MenuItem30.Enabled = False
            Else
                MenuItem30.Enabled = True
            End If
        Catch ex As Exception
        End Try
        If yuklendi = True Then
            Try
                dataload_odemekodu(dr("sFiyatTipi"))
            Catch ex As Exception
            End Try
            If GridView1.SelectedRowsCount > 1 Then
                Label1.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label1.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
            Else
                Label1.Text = ""
            End If
            Try
                Label1.Text += " / ToplamMiktar :" & FormatNumber(dr_toplam("lToplamMiktar"), 2)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If yuklendi = True Then
                Try
                    satir_info()
                Catch ex As Exception
                End Try
            End If
            'satir_info()
        Catch ex As Exception
            label2.Text = "*"
        End Try
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        analiz_stok_adi()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub baslik_degistir()
        Try
            'Vgrid_baslik.PostEditor()
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            tbAlisVerisAdres_kaydet_degistir(nAlisVerisID, dr_baslik("sAciklama"), dr_baslik("sAdres1"), dr_baslik("sAdres2"), dr_baslik("sSemt"), dr_baslik("sIl"), dr_baslik("sUlke"), dr_baslik("sPostaKodu"), dr_baslik("sVergiDairesi"), dr_baslik("sVergiNo"), "")
            tbAlisVeris_kaydet_degistir(nAlisVerisID, dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("nGirisCikis"), dr_baslik("lFaturaNo"), dr_baslik("sAlisVerisYapanAdi"), dr_baslik("sAlisVerisYapanSoyadi"))
            tbAlisVeris_detay_kaydet_degistir(nAlisVerisID, dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("nGirisCikis"), dr_baslik("lFaturaNo"), dr_baslik("dteFaturaTarihi"))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_BelgeOnizle.ItemClick
        If kapatma_kontrol() = True Then
            raporla(0, 0)
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_BelgeDizayn.ItemClick
        raporla(0, 2)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_BelgeYazdir.ItemClick
        If Group_Satis.Enabled = True Then
            If kapatma_kontrol() = True Then
                raporla(0, 1)
            End If
        Else
            analiz_satis_don()
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sFiyatTipi")) = "HD" Or Decimal.Parse(Trim(dr("lBrutFiyat"))) < 0.25 Or Decimal.Parse(Trim(dr("lBrutTutar"))) < 0.25 Then
                MenuItem30.Enabled = False
            Else
                MenuItem30.Enabled = True
            End If
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkle.ItemClick
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            mevcut = 1
            satir_ekle_stok_siparis("")
        Else
            mevcut = 1
            satir_ekle_stok("")
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FisSil.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi İptal Etmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim fisSayisi As Integer = PerakendeMuhasebeFisiVarMi(dr_baslik("lFaturaNo").ToString(), "3", 2)
            If fisSayisi > 0 Then
                If yetki_kontrol(kullanici, "frm_Perakende_MuhasebeFisliBelge_Silme") = True Then
                    If XtraMessageBox.Show(Sorgu_sDil("Bu belge Muhasebeleşmiştir, İptal Etmek İstediğinize Emin Misiniz?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        PerakendeMuhasebeFisiSil(dr_baslik("lFaturaNo").ToString(), dr_baslik("lFaturaNo").ToString(), dr_baslik("nAlisverisID").ToString(), "3", fisSayisi)
                        Try
                            sonKullaniciUpdate()
                        Catch ex As Exception
                        End Try
                        tbAlisVeris_kaydet_sil()
                        belgeIptalOldu = True
                        bkapat = True
                        Me.Close()
                    End If
                End If
            Else
                Try
                    sonKullaniciUpdate()
                Catch ex As Exception
                End Try
                tbAlisVeris_kaydet_sil()
                belgeIptalOldu = True
                bkapat = True
                Me.Close()
            End If
        End If
    End Sub
    Private Sub sec_sFiyatTipi_CloseUp(sender As System.Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles sec_sFiyatTipi.CloseUp
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If Trim(dr("sFiyatTipi")) = "HD" Or Decimal.Parse(Trim(dr("lBrutFiyat"))) < 0.25 Or Decimal.Parse(Trim(dr("lBrutTutar"))) < 0.25 Then
            MenuItem30.Enabled = False
        Else
            MenuItem30.Enabled = True
        End If
    End Sub
    Private Sub sec_sFiyatTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFiyatTipi.EditValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("lBrutFiyat") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID"))
            dataload_odemekodu(dr("sFiyatTipi"))
            tutar_hesapla()
            dr.EndEdit()
            If Trim(dr("sFiyatTipi")) = "HD" Or Decimal.Parse(Trim(dr("lBrutFiyat"))) < 0.25 Or Decimal.Parse(Trim(dr("lBrutTutar"))) < 0.25 Then
                MenuItem30.Enabled = False
            Else
                MenuItem30.Enabled = True
            End If
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            mevcut = 1
            satir_ekle_stok_siparis("")
        Else
            mevcut = 1
            satir_ekle_stok("")
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName)
                Cursor.Current = Cursors.Default
                Cursor.Hide()
                info = True
            End If
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        VGrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        VGrid_toplam.RowsCustomization()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Dim frm As New frm_calc
        frm.Show()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        analiz_satislar()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Satış Ekranını Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_StokKarti.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MusteriKarti.ItemClick
        analiz_musteri_duzenle()
    End Sub
    Private Sub VGrid_toplam_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_toplam.CellValueChanged
        Try
            'VGrid_baslik.PostEditor()
            VGrid_toplam.UpdateFocusedRecord()
            VGrid_toplam.CloseEditor()
            VGridToplam_degistir()
            'If VGrid_toplam.FocusedRecordCellIndex.ToString = 0 Then
            'ElseIf VGrid_toplam.FocusedRecordCellIndex.ToString = 1 Then
            '    If dr_toplam("lDipIskontoTutari1") <> 0 Then
            '        dr_toplam("nDipIskontoYuzdesi1") = FormatNumber((dr_toplam("lDipIskontoTutari1") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100, 2)
            '    Else
            '        dr_toplam("nDipIskontoYuzdesi1") = 0
            '    End If
            'End If
            ''MsgBox(dr_toplam("nDipIskontoYuzdesi1"))
            'If dr_toplam("nDipIskontoYuzdesi1") > nMaxIskontoYuzdesi Then
            '    dr_toplam("nDipIskontoYuzdesi1") = nMaxIskontoYuzdesi
            'End If
            'dr_toplam("lDipIskontoTutari") = FormatNumber(dr_toplam("lDipIskontoTutari1") + dr_toplam("lHarcananPuan"), 2)
            'If dr_toplam("lDipIskontoTutari") <> 0 Then
            '    dr_toplam("nDipIskontoYuzdesi") = FormatNumber((dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100, 2)
            'Else
            '    dr_toplam("nDipIskontoYuzdesi") = 0
            'End If
            'toplam_hesapla()
            'If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            '    tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
            'Else
            '    tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
            'End If
            'Dim satir = GridView1.FocusedRowHandle
            'dataload_harekets()
            'GridView1.FocusedRowHandle = satir
            'toplam_hesapla()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub VGridToplam_degistir()
        'VGrid_baslik.PostEditor()
        VGrid_toplam.UpdateFocusedRecord()
        VGrid_toplam.CloseEditor()
        Dim nIskontoYuzdesi As Decimal = 0
        If VGrid_toplam.FocusedRecordCellIndex.ToString = 0 Then
            dr_toplam("nDipIskontoYuzdesi1") = sorgu_sayi(dr_toplam("nDipIskontoYuzdesi1"), 0)
            dr_toplam("lDipIskontoTutari1") = sorgu_sayi(dr_toplam("lDipIskontoTutari1"), 0)
            dr_toplam("lDipIskontoTutari") = sorgu_sayi(dr_toplam("lDipIskontoTutari"), 0)
            If dr_toplam("nDipIskontoYuzdesi1") > 0 Then
                dr_toplam("lDipIskontoTutari1") = FormatNumber((dr_toplam("lMalbedeli") - dr_toplam("lMalIskontoTutari")) * (dr_toplam("nDipIskontoYuzdesi1") / 100), 2)
            Else
                dr_toplam("lDipIskontoTutari1") = 0
            End If
        ElseIf VGrid_toplam.FocusedRecordCellIndex.ToString = 1 Then
            If dr_toplam("lDipIskontoTutari1") <> 0 Then
                dr_toplam("nDipIskontoYuzdesi1") = FormatNumber((dr_toplam("lDipIskontoTutari1") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100, 2)
            Else
                dr_toplam("nDipIskontoYuzdesi1") = 0
            End If
        End If
        If dr_toplam("nDipIskontoYuzdesi1") > nMaxIskontoYuzdesi Then
            dr_toplam("nDipIskontoYuzdesi1") = nMaxIskontoYuzdesi
        End If
        dr_toplam("lDipIskontoTutari") = FormatNumber(dr_toplam("lDipIskontoTutari1") + dr_toplam("lHarcananPuan"), 2)
        If dr_toplam("lDipIskontoTutari") <> 0 Then
            dr_toplam("nDipIskontoYuzdesi") = FormatNumber((dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100, 2)
        Else
            dr_toplam("nDipIskontoYuzdesi") = 0
        End If
        nIskontoYuzdesi = ((dr_toplam("lDipIskontoTutari") + dr_toplam("lMalIskontoTutari")) / dr_toplam("lMalBedeli")) * 100
        If nIskontoYuzdesi > nMaxIskontoYuzdesi Then
            Dim lMaxIskonto As Decimal = FormatNumber(((dr_toplam("lMalBedeli") * nMaxIskontoYuzdesi) / 100) - FormatNumber(dr_toplam("lMalIskontoTutari"), 2), 2)
            dr_toplam("lDipIskontoTutari") = lMaxIskonto
            dr_toplam("lDipIskontoTutari1") = lMaxIskonto
            If dr_toplam("lDipIskontoTutari") <> 0 Then
                dr_toplam("nDipIskontoYuzdesi") = FormatNumber((dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - FormatNumber(dr_toplam("lMalIskontoTutari"), 2))) * 100, 2)
                dr_toplam("nDipIskontoYuzdesi1") = dr_toplam("nDipIskontoYuzdesi")
            Else
                dr_toplam("nDipIskontoYuzdesi") = 0
                dr_toplam("nDipIskontoYuzdesi1") = dr_toplam("nDipIskontoYuzdesi")
            End If
            XtraMessageBox.Show(Sorgu_sDil("Maximum İskonto Sınırını Aşamazsınız...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        toplam_hesapla()
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
        Else
            tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
        End If
        Dim satir = GridView1.FocusedRowHandle
        dataload_harekets()
        GridView1.FocusedRowHandle = satir
        toplam_hesapla()
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_StokFiyatlandir.ItemClick
        stok_fiyat()
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        Try
            If Len(txt_ara.EditValue.ToString) <> 0 Then
                lbl_ara.Text = Len(txt_ara.EditValue.ToString)
            Else
                lbl_ara.Text = "*"
            End If
        Catch ex As Exception
            lbl_ara.Text = "*"
        End Try
        If Len(txt_ara.Text) = 1 Then
            If bOtomatikEnter = True Then
                If txt_ara.Text = "\" Then
                    Try
                        toplam_hesapla()
                    Catch ex As Exception
                    End Try
                    lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
                    dataload_tbOdemeSekli()
                    dataload_tbDovizCinsi()
                    dataload_pesinat(nAlisVerisID)
                    dataload_taksit(nAlisVerisID)
                    toplam_hesapla_kapatma()
                    If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
                        If Pesinat = 0 And lKalanTutar > 0 Then
                            pesinat_satir_ekle(mevcut, True)
                        End If
                        GridControl2.Focus()
                        GridControl2.Select()
                        GridView2.FocusedColumn = collOdemeTutar
                        bOtomatikPesinatDuzelt = True
                        analiz_satis_don()
                    End If
                    yeni_fis("P")
                ElseIf txt_ara.Text = "y" Then
                    If dr_toplam("lNetTutar") > 0 Then
                        analiz_satis_kapatma_detayi()
                    ElseIf dr_toplam("lNetTutar") < 0 Then
                        analiz_satis_kapatma_iade()
                    ElseIf dr_toplam("lNetTutar") = 0 Then
                    End If
                ElseIf txt_ara.Text = "h" Then
                    musteri_sec()
                ElseIf txt_ara.Text = "n" Then
                    stok_gor("Barkod")
                ElseIf txt_ara.Text = "o" Then
                    stok_gor("Ad")
                ElseIf txt_ara.Text = "e" Then
                    If GridView1.RowCount > 0 Then
                        Dim dr As DataRow
                        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                        txt_ara.Text = -Math.Abs(dr("lCikisMiktar1")) & "*" & dr("sKodu").ToString
                        stok_ara()
                    End If
                End If
            End If
        Else
            If Len(txt_ara.Text) < 5 Then
                If txt_ara.Text.Contains("\") = True Then
                    Dim sAra As String = txt_ara.Text
                    x = (Trim(sAra)).IndexOf("\", 1, (Trim(sAra)).Length - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(sAra)).Substring(0, x)
                        sAra = (Trim(sAra)).Substring((x + 1), (Trim(sAra)).Length - (x + 1))
                        txt_ara.Text = ""
                        Try
                            toplam_hesapla()
                        Catch ex As Exception
                        End Try
                        lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
                        dataload_tbOdemeSekli()
                        dataload_tbDovizCinsi()
                        dataload_pesinat(nAlisVerisID)
                        dataload_taksit(nAlisVerisID)
                        toplam_hesapla_kapatma()
                        If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
                            If Pesinat = 0 And lKalanTutar > 0 Then
                                pesinat_satir_ekle(mevcut)
                            End If
                            GridControl2.Focus()
                            GridControl2.Select()
                            GridView2.FocusedColumn = collOdemeTutar
                            bOtomatikPesinatDuzelt = True
                            analiz_satis_don()
                        End If
                        yeni_fis("P")
                    End If
                End If
            End If
        End If
        If Len(txt_ara.Text) > 4 Then
            Dim sAra As String = txt_ara.Text
            If IsNumeric(Trim(sAra)) = True Then
                If Len(Trim(sAra).ToString) < 2 Then
                    sAra = Trim(sAra) + "  "
                End If
                If Trim((Trim(sAra)).Substring(0, 2)) = sBarcodeStd And Len(sAra) = 13 Then
                    Dim deger = Trim(Trim(sAra))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        sAra = deger.substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(sAra).ToString) <> "" Then
                    x = (Trim(sAra)).IndexOf("*", 1, (Trim(sAra)).Length - 1)
                    If x = -1 Then
                        'x = (Trim(sAra)).IndexOf("\", 1, (Trim(sAra)).Length - 1)
                        'mevcut = (Trim(sAra)).Substring(0, x)
                        'sAra = (Trim(sAra)).Substring((x + 1), (Trim(sAra)).Length - (x + 1))
                        'txt_ara.Text = "\"
                        'mevcut = 1
                    Else
                        mevcut = (Trim(sAra)).Substring(0, x)
                        sAra = (Trim(sAra)).Substring((x + 1), (Trim(sAra)).Length - (x + 1))
                        If IsNumeric(Trim(sAra)) Then
                        Else
                        End If
                    End If
                End If
            End If
            If Len(sAra) = 5 Or Len(sAra) = 7 Or Len(sAra) = 8 Or Len(sAra) = 12 Or Len(sAra) = 13 Then
                If IsNumeric(Trim(sAra)) = True Then
                    'lbl_ara.Text = "Enter'a Bas"
                    If bOtomatikEnter = True Then
                        If txt_ara.Text.Contains("+") = False Then
                            Timer1.Enabled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim bCancel As Boolean = False
            bEnter = False
            txt_ara.Update()
            txt_ara.Refresh()
            Try
                x = (Trim(txt_ara.Text)).IndexOf(",", 1, (Trim(txt_ara.Text)).Length - 1)
                If x = -1 Then
                Else
                    txt_ara.Text = Microsoft.VisualBasic.Replace(txt_ara.Text, ",", ".")
                    txt_ara.ScrollToCaret()
                End If
            Catch ex As Exception
            End Try
            If txt_ara.Text.Contains("/") = True Then
                Dim sAra As String = txt_ara.Text
                x = (Trim(sAra)).IndexOf("/", 1, (Trim(sAra)).Length - 1)
                If x = -1 Then
                    Try
                        toplam_hesapla()
                    Catch ex As Exception
                    End Try
                    lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
                    dataload_tbOdemeSekli()
                    dataload_tbDovizCinsi()
                    dataload_pesinat(nAlisVerisID)
                    dataload_taksit(nAlisVerisID)
                    toplam_hesapla_kapatma()
                    If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
                        If Pesinat = 0 And lKalanTutar > 0 Then
                            pesinat_satir_ekle(mevcut)
                            toplam_hesapla_kapatma()
                        End If
                        GridControl2.Focus()
                        GridControl2.Select()
                        GridView2.FocusedColumn = collOdemeTutar
                        bOtomatikPesinatDuzelt = True
                        analiz_satis_don()
                    End If
                    yeni_fis("P")
                    bCancel = True
                Else
                    mevcut = (Trim(sAra)).Substring(0, x)
                    sAra = (Trim(sAra)).Substring((x + 1), (Trim(sAra)).Length - (x + 1))
                    txt_ara.Text = "/"
                    Try
                        toplam_hesapla()
                    Catch ex As Exception
                    End Try
                    lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
                    dataload_tbOdemeSekli()
                    dataload_tbDovizCinsi()
                    dataload_pesinat(nAlisVerisID)
                    dataload_taksit(nAlisVerisID)
                    toplam_hesapla_kapatma()
                    If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
                        If Pesinat = 0 And lKalanTutar > 0 Then
                            pesinat_satir_ekle(mevcut, True)
                            toplam_hesapla_kapatma()
                        End If
                        GridControl2.Focus()
                        GridControl2.Select()
                        GridView2.FocusedColumn = collOdemeTutar
                        bOtomatikPesinatDuzelt = True
                        analiz_satis_don()
                    End If
                    yeni_fis("P")
                    bCancel = True
                End If
            End If
            If bCancel = False Then
                If txt_ara.Text = "" Then
                    mevcut = 1
                    If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
                        satir_ekle_stok("")
                    ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
                        satir_ekle_stok_siparis("")
                    End If
                Else
                    If Len(txt_ara.Text) > 2 Then
                        mevcut = 1
                        Dim sAra As String = txt_ara.Text
                        If CStr(Trim(sAra).ToString) <> "" Then
                            x = (Trim(sAra)).IndexOf("*", 1, (Trim(sAra)).Length - 1)
                            If x = -1 Then
                                mevcut = 1
                            Else
                                mevcut = (Trim(sAra)).Substring(0, x)
                                sAra = (Trim(sAra)).Substring((x + 1), (Trim(sAra)).Length - (x + 1))
                                If IsNumeric(Trim(sAra)) Then
                                Else
                                End If
                            End If
                        End If
                        sAra = Microsoft.VisualBasic.Replace(sAra, "+", "")
                        Dim sSeriID As String = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT DISTINCT ISNULL(tbStok.nStokID, '') AS nKayit FROM tbStokFisiSeriNo INNER JOIN tbStok ON tbStokFisiSeriNo.nStokID = tbStok.nStokID WHERE (tbStokFisiSeriNo.sSeri = '" & sAra & "') GROUP BY tbStok.nStokID HAVING (SUM(tbStokFisiSeriNo.nMiktar) > 0)")
                        If sSeriID <> "" Then
                            'sAra = sSeri
                            Dim kriter As String = ""
                            Dim ara As String = sSeriID
                            Dim ara_kriter As String = "Eşittir"
                            kriter = "Where (tbStok.nStokID " & sorgu_kriter_string(ara, ara_kriter) & ")"
                            If sStokSinirla <> "" Then
                                kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                            End If
                            'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
                            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,CAST(0 AS Money) AS lMiktar,tbStok.nPrim FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
                            If Trim(dr_baslik("sFisTipi")) = "K" Or Trim(dr_baslik("sFisTipi")) = "P" Then
                                Dim nIslemID As Int64 = satir_ekle_stok_tek(False)
                                tbStokFisiSeriNo_kaydet_yeni(dr_baslik("nAlisVerisID"), nIslemID, sSeriID, sAra, "", -1)
                            ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                                satir_ekle_stok_siparis_tek(False)
                            End If
                        Else
                            If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoliDagilimi WHERE     (sKoliKodu = '" & sAra & "')") = 0 Then
                                stok_ara()
                            Else
                                If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
                                    satir_ekle_stok_koli(sAra)
                                ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
                                    satir_ekle_stok_siparis_koli(sAra)
                                End If
                                'satir_ekle_stok_koli(txt_ara.Text)
                            End If
                        End If
                    Else
                        If IsNumeric(Trim(txt_ara.Text)) = True Then
                            txt_ara.Text = sayiuzunlukkontrol(Trim(txt_ara.Text), 6)
                            stok_ara()
                        Else
                            If Trim(txt_ara.Text) = "+" Then
                                If GridView1.RowCount > 0 Then
                                    Dim dr As DataRow
                                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                                    txt_ara.Text = "1" & "*" & dr("sKodu").ToString
                                    stok_ara()
                                End If
                            ElseIf Trim(txt_ara.Text) = "-" Then
                                If GridView1.RowCount > 0 Then
                                    Dim dr As DataRow
                                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                                    txt_ara.Text = -Math.Abs(dr("lCikisMiktar1")) & "*" & dr("sKodu").ToString
                                    stok_ara()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            GridView1.FocusedColumn = collGCMiktar
        Else
            bEnter = True
        End If
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Satış Ekranını Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub stok_ara()
        If Trim(txt_ara.Text) <> "" Then
            Label4.Text = "Barkod Standardı Kontrol Ediliyor..."
            Label4.Refresh()
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If
                If Trim((Trim(txt_ara.Text)).Substring(0, 2)) = sBarcodeStd And Len(Trim(txt_ara.Text)) = 13 Then
                    Dim deger = Trim(Trim(txt_ara.Text))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        txt_ara.Text = deger.substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(txt_ara.Text).ToString) <> "" Then
                    x = (Trim(txt_ara.Text)).IndexOf("*", 1, (Trim(txt_ara.Text)).Length - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(txt_ara.Text)).Substring(0, x)
                        txt_ara.Text = (Trim(txt_ara.Text)).Substring((x + 1), (Trim(txt_ara.Text)).Length - (x + 1))
                        If Len(Trim(txt_ara.Text)) < 3 Then
                            txt_ara.Text = sayiuzunlukkontrol(Trim(txt_ara.Text), 6)
                        End If
                        If IsNumeric(Trim(txt_ara.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            Label4.Text = "Barkod Standardı Kontrolü Tamamlandı..."
            Label4.Refresh()
            stok_kontrol(txt_ara.Text)
        End If
    End Sub
    Private Sub stok_kontrol(ByVal sAra As String)
        txt_ara.Text = ""
        If IsNumeric(Trim(sAra)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Stok Kartı Kontrolü Yapılıyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_stok_kontrol(sAra, sec_kriter.Text)
        If kontrol = 0 Then
            Label4.Text = "Stok Kaydı Bulunamadı!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
            If XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı..." & vbCrLf & "Yeni Kayıt Eklemek İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                stok_yeni(sAra)
            End If
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Stok Kaydı Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayıt Tek...")
            'dataload_stok(Trim(sAra), sec_kriter.Text)
            Label4.Text = "Stok Bilgisi Yükleniyor... "
            Label4.Refresh()
            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                satir_ekle_stok_siparis_tek(False)
            Else
                satir_ekle_stok_tek(False)
            End If
        ElseIf kontrol > 1 Then
            If IsDBNull(dr_baslik("sFisTipi")) = False Then
                If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    satir_ekle_stok_siparis(Trim(sAra), sAraKriter)
                Else
                    satir_ekle_stok(Trim(sAra), sAraKriter)
                End If
            End If
            Label4.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            sAra = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter As String
        Dim kayitsayisi As Integer = 0
        Dim nKayitSayisi As Integer = 0
        Dim nBarkodSayisi As Integer = 0
        Dim nKodSayisi As Integer = 0
        Dim nAciklamaSayisi As Integer = 0
        nBarkodSayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(COUNT(nStokID),0) from tbStokBarkodu Where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & "")
        If nBarkodSayisi = 1 Then
            kriter = " WHERE tbStok.nStokID IN(Select nStokID from tbStokBarkodu Where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,CAST(0 AS Money) AS lMiktar,tbStok.nPrim FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
            kayitsayisi = 1
        ElseIf nBarkodSayisi = 0 Or nBarkodSayisi > 1 Then
            'kriter = "WHERE (Stok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ") or (Stok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (Stok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") "
            kriter = "Where (sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            If sStokSinirla <> "" Then
                kriter += " AND (sKodu like '" & sStokSinirla & "%') "
            End If
            nKodSayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nStokID),0) From tbStok " & kriter & "")
            If nKodSayisi = 1 Then
                kriter = "Where (tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                If sStokSinirla <> "" Then
                    kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                End If
                ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,CAST(0 AS Money) AS lMiktar,tbStok.nPrim FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
                kayitsayisi = 1
            ElseIf nKodSayisi = 0 Then
                kriter = "Where (sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
                If sStokSinirla <> "" Then
                    kriter += " AND (sKodu like '" & sStokSinirla & "%') "
                End If
                nAciklamaSayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nStokID),0) From tbStok " & kriter & "")
                If nAciklamaSayisi = 1 Then
                    kriter = "Where (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
                    If sStokSinirla <> "" Then
                        kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                    End If
                    ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,CAST(0 AS Money) AS lMiktar,tbStok.nPrim FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
                    kayitsayisi = 1
                ElseIf nAciklamaSayisi = 0 Then
                    kayitsayisi = 0
                ElseIf nAciklamaSayisi > 1 Then
                    kayitsayisi = nAciklamaSayisi
                    sAraKriter = "Ad"
                End If
            ElseIf nKodSayisi > 1 Then
                kayitsayisi = nKodSayisi
                sAraKriter = "Kod"
            End If
            If kayitsayisi = 0 Then
                If nKodSayisi = 0 And nAciklamaSayisi = 0 And nBarkodSayisi > 1 Then
                    kayitsayisi = nBarkodSayisi
                    sAraKriter = "Barkod"
                Else
                    kayitsayisi = 0
                End If
            End If
        End If
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok Stok INNER JOIN  tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID and Barcode.nKisim =0 " & kriter & "")
        'kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
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
    Private Sub dataload_stok(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        If sStokSinirla <> "" Then
            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
        End If
        'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT4, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
    End Sub
    Public Function sorgu_envanter(ByVal depo As String, ByVal nStokID As String) As Decimal
        Dim kriter
        kriter = "WHERE (sDepo = '" & depo & "')  and (nStokID = '" & nStokID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) AS Mevcut FROM         tbStokFisiDetayi " & kriter & "")
        Dim kayitsayisi As Decimal = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_BarkodOkut.ItemClick
        If Group_Satis.Enabled = True Then
            If btn_BarkodOkut.Caption = "Barkod Okut" Then
                txt_ara.Focus()
                txt_ara.Select()
                btn_BarkodOkut.Caption = "Veri Gir"
            ElseIf btn_BarkodOkut.Caption = "Veri Gir" Then
                GridControl1.Focus()
                GridControl1.Select()
                btn_BarkodOkut.Caption = "Barkod Okut"
            End If
        Else
            If GridControl2.Focus = True Then
                GridControl3.Focus()
                GridControl3.Select()
            ElseIf GridControl3.Focus = True Then
                GridControl2.Focus()
                GridControl2.Select()
            End If
        End If
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FisYeni.ItemClick
        If Group_Satis.Enabled = True Then
            yeni_fis("P")
        Else
            analiz_satis_don()
        End If
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MusteriSec.ItemClick
        musteri_sec()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FiyatGor.ItemClick
        stok_gor()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        tutaragore_miktarhesapla()
    End Sub
    Private Sub tutaragore_miktarhesapla()
        Dim frm As New frm_calc
        frm.Text = "Tutara Göre MiktarHesapla..."
        'frm.status = False
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If frm.CalcEdit1.EditValue <> 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("lBrutTutar") = frm.CalcEdit1.EditValue
                dr("lCikisMiktar1") = dr("lBrutTutar") / dr("lBrutFiyat")
                dr = Nothing
                tutar_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub sSaticiRumuzu_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu as sKod,sAdi as sAciklama FROM         tbSatici where bAktif =1"
        frm.lbl_sKod.Text = "Satici:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Satıcılara Atamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi = 0
                For Each dr In ds_hareket.Tables(0).Rows
                    dr("sSaticiRumuzu") = frm.LookUpEdit1.EditValue
                    Dim Primx = sSaticiRumuzu_nPrim(dr("sSaticiRumuzu"))
                    If Primx = 0 Then
                        dr("nPrim") = sorgu_sayi(dr("nPrim"), 0)
                    Else
                        dr("nPrim") = Primx
                    End If
                    dr("lPrimTutari") = (dr("lCikisTutar") * (dr("nPrim") / 100))
                    If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                        tbAlisVerisSiparis_kaydet_duzelt(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), dr("nPrim"), dr("lPrimTutari"))
                    ElseIf dr("nPrim") = 0 Then
                        tbStokFisidetay_kaydet_degistir1(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))
                    ElseIf dr("nPrim") > 0 Then
                        tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))

                    End If
                Next
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Function sSaticiRumuzu_nPrim(ByVal sSaticiRumuzu As String) As Decimal
        Dim dr As DataRow
        Dim nPrim As Decimal = 0
        For Each dr In ds_tbSatici.Tables(0).Rows
            If dr("sSaticiRumuzu") = sSaticiRumuzu Then
                nPrim = dr("nPrim")
            End If
        Next
        Return nPrim
    End Function
    Private Function Stok_nPrim(ByVal sSaticiRumuzu As String, ByVal nPrimx As Integer) As Decimal
        Dim dr As DataRow
        Dim nPrim As Decimal = 0
        For Each dr In ds_tbSatici.Tables(0).Rows
            If dr("sSaticiRumuzu") = sSaticiRumuzu Then
                nPrim = nPrimx
            End If
        Next
        Return nPrim
    End Function
    Private Sub sDepo_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo as sKod,sAciklama FROM         tbDepo where sDepo<> = '" & dr_baslik("sMagaza") & "'"
        frm.lbl_sKod.Text = "Depo:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Mağaza Kodu Olarak Atamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi = 0
                tbAlisVeris_Depo_Degistir(dr_baslik("nAlisVerisID"), dr_baslik("sFisTipi"), dr_baslik("sMagaza"), frm.LookUpEdit1.EditValue)
                sMagaza = frm.LookUpEdit1.EditValue
                loaded()
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub sFiyatTipi_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFiyatTipi as sKod, sAciklama as sAciklama FROM tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"
        frm.lbl_sKod.Text = "FiyatTipi:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Fiyat Tipini Atamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi = 0
                Dim Fiyat As Decimal = 0
                Dim dr As DataRow
                Dim lIskontoYuzdesi = dr_toplam("nDipIskontoYuzdesi")
                For Each dr In ds_hareket.Tables(0).Rows
                    Fiyat = sorgu_stok_fiyat(frm.LookUpEdit1.EditValue, dr("nStokID"))
                    If Fiyat <> 0 Then
                        sayi += 1
                        dr("sFiyatTipi") = frm.LookUpEdit1.EditValue
                        dr("lBrutFiyat") = Fiyat
                        dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
                        dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                        dr("lCikisTutar") = dr("lBrutTutar") / ((100 + dr("nKdvOrani")) / 100)
                        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                            tbAlisVerisSiparis_kaydet_duzelt(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), dr("nPrim"), dr("lPrimTutari"))
                        Else
                            tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))
                        End If
                    End If
                Next
                'İskonto Güncelle
                If Trim("sFisTipi") = "K" Then
                    dr_toplam("nDipIskontoYuzdesi") = lIskontoYuzdesi
                ElseIf Trim("sFisTipi") = "P" Then
                    dr_toplam("nDipIskontoYuzdesi") = lIskontoYuzdesi
                End If
                If dr_toplam("nDipIskontoYuzdesi") > nMaxIskontoYuzdesi Then
                    dr_toplam("nDipIskontoYuzdesi") = nMaxIskontoYuzdesi
                End If
                toplam_hesapla()
                If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                Else
                    tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                End If
                Dim satir = GridView1.FocusedRowHandle
                dataload_harekets()
                GridView1.FocusedRowHandle = satir
                toplam_hesapla()
                dr = Nothing
                sayi = Nothing
                If sayi > 0 Then
                    sFiyatTipi = frm.LookUpEdit1.EditValue
                End If
                XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub cari_sec()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr_baslik("sAdres1") = dr1("sAdres1")
            dr_baslik("sAdres2") = dr1("sAdres2")
            dr_baslik("sVergiDairesi") = dr1("sVergiDairesi")
            dr_baslik("sVergiNo") = dr1("sVergiNo")
            dr_baslik("sSemt") = dr1("sSemt")
            dr_baslik("sUlke") = dr1("sUlke")
            dr_baslik("sPostaKodu") = dr1("sPostaKodu")
            dr_baslik("sAlisVerisYapanAdi") = dr1("sAciklama")
            dr_baslik("sAlisVerisYapanSoyadi") = ""
            baslik_degistir()
        End If
    End Sub
    Private Sub etiket_tusu_ata(ByVal tus As Integer)
        Dim frm As New frm_stok_liste_fiyat
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            If tus = 1 Then
                e1.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 2 Then
                e2.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 3 Then
                e3.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 4 Then
                e4.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 5 Then
                e5.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 6 Then
                e6.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 7 Then
                e7.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 8 Then
                e8.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 9 Then
                e9.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 10 Then
                e10.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 11 Then
                e11.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 12 Then
                e12.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 13 Then
                e13.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 14 Then
                e14.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 15 Then
                e15.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 16 Then
                e16.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 17 Then
                e17.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 18 Then
                e18.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 19 Then
                e19.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            ElseIf tus = 20 Then
                e20.Text = Trim(dr("sKodu").ToString) & vbCrLf & Trim(dr("sAciklama"))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", Trim(dr("sKodu").ToString))
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", Trim(dr("sAciklama").ToString))
            End If
            dr = Nothing
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub etiket_tus_ara()
        Dim tus As Integer = 0
        Dim eKod As String = ""
        Dim eAciklama As String = ""
        For tus = 1 To 20
            Try
                eKod = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").OpenSubKey("TUS").GetValue("eKod" & tus & "").ToString
                eAciklama = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").OpenSubKey("TUS").GetValue("eAciklama" & tus & "").ToString
            Catch ex As Exception
                eKod = tus.ToString
                eAciklama = ""
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eKod" & tus & "", tus.ToString)
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").CreateSubKey("TUS").SetValue("eAciklama" & tus & "", "")
            End Try
            If tus = 1 Then
                e1.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 2 Then
                e2.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 3 Then
                e3.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 4 Then
                e4.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 5 Then
                e5.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 6 Then
                e6.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 7 Then
                e7.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 8 Then
                e8.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 9 Then
                e9.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 10 Then
                e10.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 11 Then
                e11.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 12 Then
                e12.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 13 Then
                e13.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 14 Then
                e14.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 15 Then
                e15.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 16 Then
                e16.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 17 Then
                e17.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 18 Then
                e18.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 19 Then
                e19.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            ElseIf tus = 20 Then
                e20.Text = Trim(eKod.ToString) & vbCrLf & Trim(eAciklama.ToString)
            End If
        Next
    End Sub
    Private Sub etiket_tus_stok(ByVal tus As Integer)
        txt_etiket_ara.Text = tus
        txt_ara.Text += Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").OpenSubKey("TUS").GetValue("eKod" & tus & "").ToString()
        stok_ara()
        tus = Nothing
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MiktarHesapla.ItemClick
        tutaragore_miktarhesapla()
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SaticiBelirle.ItemClick
        sSaticiRumuzu_toplu()
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FiyatTipiBelirle.ItemClick
        sFiyatTipi_toplu()
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltToplamlar.ItemClick
        If btn_AltToplamlar.Caption = "Alt Toplamlar" Then
            VGrid_toplam.Focus()
            VGrid_toplam.FocusedRow = rowDipIskonto
            VGrid_toplam.FocusedRecordCellIndex = 0
            VGrid_toplam.Select()
            'txt_ara.Focus()
            'txt_ara.Select()
            btn_AltToplamlar.Caption = "Barkod Okut"
        ElseIf btn_AltToplamlar.Caption = "Barkod Okut" Then
            txt_ara.Focus()
            txt_ara.Select()
            btn_AltToplamlar.Caption = "Alt Toplamlar"
        End If
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_EtiketTuslariGoster.ItemClick
        If btn_EtiketTuslariGoster.Caption = "Etiket Tusları Göster" Then
            TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            btn_EtiketTuslariGoster.Caption = "Etiket Tusları Gizle"
        ElseIf btn_EtiketTuslariGoster.Caption = "Etiket Tusları Gizle" Then
            TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            txt_ara.Focus()
            txt_ara.Select()
            btn_EtiketTuslariGoster.Caption = "Etiket Tusları Göster"
        End If
    End Sub
    Private Sub TusPanel_VisibilityChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles TusPanel.VisibilityChanged
        If TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.Select()
            btn_EtiketTuslariGoster.Caption = "Etiket Tusları Göster"
        ElseIf TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            etiket_tus_ara()
            btn_EtiketTuslariGoster.Caption = "Etiket Tusları Gizle"
            'txt_etiket_ara.Text = ""
            txt_etiket_ara.Focus()
            txt_etiket_ara.Select()
        End If
    End Sub
    Private Sub e1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e1.Click
        etiket_tus_stok(1)
    End Sub
    Private Sub e_degistir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e_degistir.Click
        etiket_tusu_ata(txt_etiket_ara.Text)
    End Sub
    Private Sub e2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e2.Click
        etiket_tus_stok(2)
    End Sub
    Private Sub e3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e3.Click
        etiket_tus_stok(3)
    End Sub
    Private Sub e4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e4.Click
        etiket_tus_stok(4)
    End Sub
    Private Sub e5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e5.Click
        etiket_tus_stok(5)
    End Sub
    Private Sub e6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e6.Click
        etiket_tus_stok(6)
    End Sub
    Private Sub e7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e7.Click
        etiket_tus_stok(7)
    End Sub
    Private Sub e8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e8.Click
        etiket_tus_stok(8)
    End Sub
    Private Sub e9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e9.Click
        etiket_tus_stok(9)
    End Sub
    Private Sub e10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e10.Click
        etiket_tus_stok(10)
    End Sub
    Private Sub e11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e11.Click
        etiket_tus_stok(11)
    End Sub
    Private Sub e12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e12.Click
        etiket_tus_stok(12)
    End Sub
    Private Sub e13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e13.Click
        etiket_tus_stok(13)
    End Sub
    Private Sub e14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e14.Click
        etiket_tus_stok(14)
    End Sub
    Private Sub e15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e15.Click
        etiket_tus_stok(15)
    End Sub
    Private Sub e16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e16.Click
        etiket_tus_stok(16)
    End Sub
    Private Sub e17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e17.Click
        etiket_tus_stok(17)
    End Sub
    Private Sub e18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e18.Click
        etiket_tus_stok(18)
    End Sub
    Private Sub e19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e19.Click
        etiket_tus_stok(19)
    End Sub
    Private Sub e20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles e20.Click
        etiket_tus_stok(20)
    End Sub
    Private Sub txt_etiket_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_etiket_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            etiket_tus_stok(txt_etiket_ara.Text)
            e20.Focus()
            e20.Select()
            txt_etiket_ara.Focus()
            txt_etiket_ara.Select()
        End If
    End Sub
    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_CarilerdenAdresAl.ItemClick
        cari_sec()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltFisYeni.ItemClick
        'If Trim(dr_baslik("sFisTipi")) = "P" Then
        yeni_fis("P")
        'Else
        '    XtraMessageBox.Show(Sorgu_sDil("İşleminiz Sadece Peşin Satış İşlemlerinde Geçerlidir, Lütfen Belge Türünü Kontrol Ediniz...!",sDil), MessageBoxIcon.Warning, sorgu_sDil("Dikkat",sDil))
        'End If
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltOdemeAl.ItemClick
        If Group_Satis.Enabled = True Then
            If dr_toplam("lNetTutar") > 0 Then
                analiz_satis_kapatma_detayi()
            ElseIf dr_toplam("lNetTutar") < 0 Then
                analiz_satis_kapatma_iade()
            ElseIf dr_toplam("lNetTutar") = 0 Then
            End If
        Else
            If GridView3.RowCount > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("[" & GridView3.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    degeryay_kapatma(GridView3.FocusedColumn().FieldName)
                    Cursor.Current = Cursors.Default
                    Cursor.Hide()
                End If
            End If
        End If
    End Sub
    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltYazdirFis.ItemClick
        If kapatma_kontrol() = True Then
            raporla(0, 1, True, False)
        End If
    End Sub
    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltKlavye.ItemClick
        Process.Start("C:\Windows\system32\osk.exe")
    End Sub
    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltYazdirFatura.ItemClick
        raporla(0, 1, False, True)
    End Sub
    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltMusteriYeni.ItemClick
        tbMusteri_yeni()
    End Sub
    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem42_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltFisSil.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi İptal Etmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbAlisVeris_kaydet_sil()
            bkapat = True
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem43_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltPuan.ItemClick
        tbAVHediyeCeki()
    End Sub
    Private Sub BarButtonItem44_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltMusteriSec.ItemClick
        musteri_sec()
    End Sub
    Private Sub BarButtonItem45_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltYuvarla.ItemClick
        Dim deger = ""
        deger = InputBox("Net Satis Tutari", "Net Satis Tutari", dr_toplam("lNetTutar")).ToString
        If deger.ToString <> "" Then
            If dr_toplam("lNetTutar") - deger > dr_param("lPesinatYuvarlama") And dr_param("lPesinatYuvarlama") Then
                XtraMessageBox.Show(Sorgu_sDil("Yuvarlama Tutar Sınırını Aşamazsınız...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                deger = ""
            End If
        End If
        If deger.ToString <> "" Then
            VGrid_toplam.UpdateFocusedRecord()
            VGrid_toplam.CloseEditor()
            dr_toplam("lDipIskontoTutari1") = dr_toplam("lDipIskontoTutari1") + (dr_toplam("lNetTutar") - CDec(deger))
            'MsgBox(CDec(deger))
            If dr_toplam("lDipIskontoTutari1") <> 0 Then
                dr_toplam("nDipIskontoYuzdesi1") = (dr_toplam("lDipIskontoTutari1") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100
            Else
                dr_toplam("nDipIskontoYuzdesi1") = 0
            End If
            If dr_toplam("nDipIskontoYuzdesi1") > nMaxIskontoYuzdesi Then
                dr_toplam("nDipIskontoYuzdesi1") = nMaxIskontoYuzdesi
            End If
            dr_toplam("lDipIskontoTutari") = dr_toplam("lDipIskontoTutari1") + dr_toplam("lHarcananPuan")
            If dr_toplam("lDipIskontoTutari") <> 0 Then
                dr_toplam("nDipIskontoYuzdesi") = (dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100
            Else
                dr_toplam("nDipIskontoYuzdesi") = 0
            End If
            toplam_hesapla()
            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
            Else
                tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
            End If
            Dim satir = GridView1.FocusedRowHandle
            dataload_harekets()
            GridView1.FocusedRowHandle = satir
            toplam_hesapla()
        End If
        deger = Nothing
    End Sub
    Private Sub BarButtonItem46_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirEkle.ItemClick
        satir_ekle_stok("")
    End Sub
    Private Sub VGrid_baslik_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGrid_baslik.KeyDown
        If e.KeyCode = Keys.Tab Then
            GridView1.Focus()
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            tbOdeme_hesapla()
            toplam_hesapla_kapatma()
        End If
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            GridView3.PostEditor()
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            dr.EndEdit()
            If dr_toplam("lNetTutar") > 0 Then
                tbTaksit_hesapla()
            ElseIf dr_toplam("lNetTutar") < 0 Then
                tbTaksitIade_hesapla()
            End If
            toplam_hesapla_kapatma()
        End If
    End Sub
    Private Sub btn_ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ekle.Click
        If dr_toplam("lNetTutar") > 0 Then
            If sDatabaseGenel = "UGURLU" And txt_tutar.EditValue = 0 Then
                If lKalanTutar > 0 Then
                    OdemePlani_Aktar(sFisTipi, nAlisVerisID, dteIlkTaksit.Text, sec_sAralik.Text)
                End If
            Else
                If lKalanTutar > 0 Then
                    If txt_tutar.EditValue = 0 And txt_sayi.EditValue > 0 Then
                        txt_tutar.EditValue = lKalanTutar / txt_sayi.EditValue
                    End If
                    tbTaksit_ekle_toplu(dteIlkTaksit.Text, txt_sayi.EditValue, sec_sAralik.Text, txt_tutar.EditValue)
                End If
            End If
        ElseIf dr_toplam("lNetTutar") < 0 Then
            taksit_satir_ekle(dteIlkTaksit.Text, txt_sayi.EditValue, sec_sAralik.Text, txt_tutar.EditValue)
        End If
        GridControl3.Focus()
        GridControl3.Select()
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView3_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        Try
            taksit_satir_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If dr_toplam("lNetTutar") > 0 Then
            tbTaksit_ekle_toplu(dteIlkTaksit.Text, 1, sec_sAralik.Text, lKalanTutar)
        ElseIf dr_toplam("lNetTutar") < 0 Then
            taksit_satir_ekle(dteIlkTaksit.Text, txt_sayi.EditValue, sec_sAralik.Text, txt_tutar.EditValue)
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If GridView3.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView3.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay_kapatma(GridView3.FocusedColumn().FieldName)
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        taksit_satir_sil()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If XtraMessageBox.Show(Sorgu_sDil("Oluşturulmuş Taksitleri Silip, Fişte Tanımlanmış Ödeme Koduna Göre Taksitlendirme Yapmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            OdemePlani_Aktar(sFisTipi, nAlisVerisID, dteIlkTaksit.Text, sec_sAralik.Text)
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        taksit_satir_sil_toplu()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        dteIlkTaksit.Focus()
        dteIlkTaksit.Select()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        pesinat_satir_ekle()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        pesinat_satir_sil()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        GridControl3.Focus()
        GridControl3.Select()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        dteIlkTaksit.Focus()
        dteIlkTaksit.Select()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Group_Kapatma.Visible = False
        Group_Satis.Enabled = True
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        analiz_satis_don()
    End Sub
    Private Sub analiz_satis_don()
        toplam_hesapla_kapatma()
        If bOtomatikPesinatDuzelt = True Then
            lOdenen = Pesinat
            lVeresiye = Taksit_tutari
            lParaUstu = lKalanTutar
            If Trim(sFisTipi) = "P" Or Trim(sFisTipi) = "SP" Then
                If pesinat_sayisi = 1 Then
                    Dim dr_pesinat As DataRow = ds_odeme.Tables(0).Rows(0)
                    dr_pesinat("lOdemeTutar") = dr_pesinat("lOdemeTutar") + lKalanTutar
                    dr_pesinat = Nothing
                    tbOdeme_hesapla()
                    toplam_hesapla_kapatma()
                End If
            End If
        End If
        Group_Kapatma.Visible = False
        Group_Satis.Enabled = True
        btn_AltFisSil.Enabled = True
        btn_AltFisYeni.Enabled = True
        btn_AltMusteriSec.Enabled = True
        btn_AltMusteriYeni.Enabled = True
        btn_AltOdemeAl.Enabled = True
        btn_AltSatirEkle.Enabled = True
        btn_AltSatirSil.Enabled = True
        btn_AltYuvarla.Enabled = True
        btn_FisSil.Enabled = True
        btn_FisYeni.Enabled = True
        btn_SatirEkle.Enabled = True
        btn_SatirSil.Enabled = True
        btn_MusteriSec.Enabled = True
        'btn_musteriaktar.Visible = True
        Try
            If dr_param("bEskilerIptalEdilsinmi") = False Then
                btn_AltFisSil.Enabled = False
                btn_FisSil.Enabled = False
            End If
        Catch ex As Exception
        End Try
        Try
            ds_odeme.Clear()
        Catch ex As Exception
        End Try
        Try
            ds_taksit.Clear()
        Catch ex As Exception
        End Try
        Try
            ds_taksit_info.Clear()
        Catch ex As Exception
        End Try
        Me.btn_HesapKapat.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.btn_BarkodOkut.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.btn_SatisDon.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.None)
        toplam_hesapla()
        txt_ara.Focus()
        txt_ara.SelectAll()
        If bYeniFis = True Then
            If yeni_fis_kontrol() = True Then
                loaded(True, "P")
                bYeniFis = False
                bFisYenimi = True
            End If
        End If
    End Sub
    Private Sub btn_HesapKapat_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_HesapKapat.ItemClick
        If dr_toplam("lNetTutar") > 0 Then
            analiz_satis_kapatma_detayi()
        ElseIf dr_toplam("lNetTutar") < 0 Then
            analiz_satis_kapatma_iade()
        ElseIf dr_toplam("lNetTutar") = 0 Then
        End If
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatisDon.ItemClick
        If Group_Kapatma.Enabled = True Then
            analiz_satis_don()
        End If
    End Sub
    Private Sub BarButtonItem17_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        gorunum_degistir(BarButtonItem17.Caption)
    End Sub
    Private Sub BarButtonItem25_ItemClick1(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        gorunum_degistir(BarButtonItem15.Caption)
    End Sub
    Private Sub BarButtonItem36_ItemClick1(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        gorunum_degistir(BarButtonItem36.Caption)
    End Sub
    Private Sub BarButtonItem47_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        gorunum_degistir(BarButtonItem47.Caption)
    End Sub
    Private Sub BarButtonItem48_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        gorunum_degistir(BarButtonItem48.Caption)
    End Sub
    Private Sub BarButtonItem49_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem49.ItemClick
        gorunum_degistir(BarButtonItem49.Caption)
    End Sub
    Private Sub BarButtonItem50_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem50.ItemClick
        gorunum_degistir(BarButtonItem50.Caption)
    End Sub
    Private Sub BarButtonItem51_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem51.ItemClick
        gorunum_degistir(BarButtonItem51.Caption)
    End Sub
    Private Sub BarButtonItem52_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem52.ItemClick
        gorunum_degistir(BarButtonItem52.Caption)
    End Sub
    Private Sub BarButtonItem53_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem53.ItemClick
        gorunum_degistir(BarButtonItem53.Caption)
    End Sub
    Private Sub BarButtonItem54_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem54.ItemClick
        gorunum_degistir(BarButtonItem54.Caption)
    End Sub
    Private Sub BarButtonItem55_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem55.ItemClick
        gorunum_degistir(BarButtonItem55.Caption)
    End Sub
    Private Sub BarButtonItem56_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem56.ItemClick
        gorunum_degistir(BarButtonItem56.Caption)
    End Sub
    Private Sub BarButtonItem57_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem57.ItemClick
        gorunum_degistir(BarButtonItem57.Caption)
    End Sub
    Private Sub BarButtonItem58_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem58.ItemClick
        gorunum_degistir(BarButtonItem58.Caption)
    End Sub
    Private Sub BarButtonItem59_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem59.ItemClick
        gorunum_degistir(BarButtonItem59.Caption)
    End Sub
    Private Sub BarButtonItem60_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem60.ItemClick
        gorunum_degistir(BarButtonItem60.Caption)
    End Sub
    Private Sub BarButtonItem61_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem61.ItemClick
        gorunum_degistir(BarButtonItem61.Caption)
    End Sub
    Private Sub BarButtonItem62_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem62.ItemClick
        raporla_etiket(0, 0)
    End Sub

    Private Sub BarButtonItem4_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MusteriNotu.ItemClick
        musteri_notlari()
    End Sub
    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        musteri_sec()
    End Sub
    Private Sub txt_ara_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.TextChanged
        Try
            x = (Trim(txt_ara.Text)).IndexOf(",", 1, (Trim(txt_ara.Text)).Length - 1)
            If x = -1 Then
            Else
                txt_ara.EditValue = Microsoft.VisualBasic.Replace(txt_ara.EditValue, ",", ".")
                txt_ara.ScrollToCaret()
            End If
        Catch ex As Exception
        End Try
        'Try
        '    txt_ara.EditValue = Microsoft.VisualBasic.Replace(txt_ara.EditValue, ",", ".")
        '    txt_ara.Select(Trim(Len(txt_ara.EditValue.Text)) - 0, 1)
        '    txt_ara.ScrollToCaret()
        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Dim sAra As String = txt_ara.Text
        If IsNumeric(Trim(sAra)) = True Then
            If Len(Trim(sAra).ToString) < 2 Then
                sAra = Trim(sAra) + "  "
            End If
            If Trim((Trim(sAra)).Substring(0, 2)) = sBarcodeStd And Len(sAra) = 13 Then
                Dim deger = Trim(Trim(sAra))
                If IsNumeric(deger) = True Then
                    mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                    sAra = deger.substring(2, 5)
                End If
            Else
                mevcut = 1
            End If
        Else
            If CStr(Trim(sAra).ToString) <> "" Then
                x = (Trim(sAra)).IndexOf("*", 1, (Trim(sAra)).Length - 1)
                If x = -1 Then
                    mevcut = 1
                Else
                    mevcut = (Trim(sAra)).Substring(0, x)
                    sAra = (Trim(sAra)).Substring((x + 1), (Trim(sAra)).Length - (x + 1))
                    If IsNumeric(Trim(sAra)) Then
                    Else
                    End If
                End If
            End If
        End If
        If Len(sAra) = 5 Or Len(sAra) = 7 Or Len(sAra) = 8 Or Len(sAra) = 12 Or Len(sAra) = 13 Then
            If bEnter = True Then
                bEnter = False
                stok_ara()
            End If
        End If
    End Sub
    Private Sub btn_OtomatikEnter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_OtomatikEnter.ItemClick
        If btn_OtomatikEnter.Down = True Then
            bOtomatikEnter = True
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bOtomatikEnter", bOtomatikEnter)
        Else
            bOtomatikEnter = False
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bOtomatikEnter", bOtomatikEnter)
        End If
        'Try
        '    sec_bMessageCheck.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bMessageCheck").ToString
        'Catch ex As Exception
        '    sec_bMessageCheck.Checked = False
        'End Try
    End Sub
    Private Sub btn_DirekYazdirTermal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DirekYazdirTermal.ItemClick
        If btn_DirekYazdirTermal.Down = True Then
            bDirektYazdirTermal = True
            If bDirektYazdirTermal = True Then
                'w32prn.SetPrinterName("FIS")
                TermalYazdir_baslik()
                Termalyazdir_hareket()
            End If
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bDirektYazdirTermal", bDirektYazdirTermal)
        Else
            bDirektYazdirTermal = False
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bDirektYazdirTermal", bDirektYazdirTermal)
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If bDirektYazdirTermal = False Then
            bDirektYazdirTermal = True
            'w32prn.SetPrinterName("FIS")
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("P")
            'w32prn.EndDoc()
            TermalYazdir_baslik()
            Termalyazdir_hareket()
            TermalYazdir_toplam()
            bDirektYazdirTermal = False
        ElseIf bDirektYazdirTermal = True Then
            'w32prn.SetPrinterName("FIS")
            'w32prn.SetDeviceFont(9.5F, "FontControl", False, False)
            'w32prn.PrintText("P")
            'w32prn.EndDoc()
            'TermalYazdir_baslik()
            'Termalyazdir_hareket()
            TermalYazdir_toplam()
            TermalYazdir_baslik()
            Termalyazdir_hareket()
            TermalYazdir_toplam()
        End If
    End Sub
    Private Sub tbStokFisiSeriNo_kaydet_yeni(ByVal nStokFisiID As String, ByVal nIslemID As Integer, ByVal nStokID As Integer, ByVal sSeri As String, ByVal sSeriAciklama As String, ByVal nMiktar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiSeriNo                       (nStokFisiID, nIslemID, nStokID, sSeri, sSeriAciklama, nMiktar) VALUES     ('" & nStokFisiID & "', " & nIslemID & ", " & nStokID & ", '" & sSeri & "', '" & sSeriAciklama & "', " & nMiktar & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokFisiSerino()
        If GridView1.RowCount > 0 And Trim(dr_baslik("sFisTipi")) = "K" Or Trim(dr_baslik("sFisTipi")) = "P" Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura_SeriNo
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.nStokFisiID = nAlisVerisID
            frm.sFisTipi = dr_baslik("sFisTipi")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokID = dr("nStokID")
            frm.nIslemID = dr("nIslemID")
            frm.ShowDialog()
        End If
    End Sub
    Private Sub Cari_bakiye()
        Dim frm As New frm_Musteri_Bakiye
        frm.FirmaNo = firmano
        frm.DonemNo = donemno
        frm.sConnection = connection
        frm.nAlisVerisID = dr_baslik("nAlisVerisID")
        frm.sKodu = dr_baslik("nMusteriID")
        frm.lbl_sKodu.Text = dr_baslik("lKodu")
        frm.lbl_sAciklama.Text = dr_baslik("Musteri")
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub btn_SeriNumara_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SeriNumara.ItemClick
        tbStokFisiSerino()
    End Sub
    Private Sub dteIlkTaksit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dteIlkTaksit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sayi.Focus()
            txt_sayi.SelectAll()
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        tbStokFisiSerino()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Cari_bakiye()
    End Sub
    Private Sub BarButtonItem2_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_stok_teslimatlari()
    End Sub
    Private Sub dteIlkTaksit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dteIlkTaksit.Validating
        If kullanici > 3 Then
            Try
                If dteIlkTaksit.Text > DateAdd(DateInterval.Day, dr_param("nITMAXG"), dteFisTarihi) Then
                    dteIlkTaksit.Text = DateAdd(DateInterval.Day, dr_param("nITMAXG"), dteFisTarihi)
                End If
            Catch ex As Exception
                If dteIlkTaksit.Text > DateAdd(DateInterval.Day, 45, dteFisTarihi) Then
                    dteIlkTaksit.Text = DateAdd(DateInterval.Day, 45, dteFisTarihi)
                End If
            End Try
        End If
        If kullanici > 3 Then
            If dteIlkTaksit.Text < dteSistemTarihi Then
                Try
                    dteIlkTaksit.Text = dteSistemTarihi
                Catch ex As Exception
                    dteIlkTaksit.Text = dteFisTarihi
                End Try
            End If
        End If
    End Sub
    Public Sub calc_artir()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim deger = ""
            deger = InputBox("Satış Fiyatı", "Satış Fiyatı", sorgu_sayi(dr("lBrutFiyat"), 0)).ToString
            If deger.ToString <> "" Then
                If CType(deger, Decimal) > dr(collBrutFiyat.FieldName.ToString) Then
                    dr(collBrutFiyat.FieldName.ToCharArray) = deger
                    GridView1.FocusedColumn = colsSaticiRumuzu
                    tutar_hesapla()
                Else
                    XtraMessageBox.Show("Düşük Fiyat Yazamazsınız...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                End If
            End If
        End If
    End Sub
    Dim i As Integer = 0
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        calc_artir()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBekleyeniIadeAl.Click
        analiz_stok_hareket_iade()
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        analiz_stok_hareket_iade_belirle()
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub MenuItem31_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        satir_ekle_stok_iade()
    End Sub
    Private Sub BarButtonItem3_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        OpenFileDialog1.Filter = "SatisDosyalari(*.xls) |*.xls"
        OpenFileDialog1.InitialDirectory = "c:\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(OpenFileDialog1.FileName.ToString & " İsimli Dosyayi Okumak Istediginize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                oku_xlsSatislar(OpenFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub oku_xlsSatislar(ByVal dosya As String)
        Dim connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;" &
   "Data Source=" & dosya & " ;Extended Properties=""Excel 8.0;HDR=YES;"""
        Dim pram As OleDb.OleDbParameter
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim DS As New DataSet
        Dim olecon As OleDb.OleDbConnection
        Dim olecomm As OleDb.OleDbCommand
        'Dim olecomm1 As OleDb.OleDbCommand
        Dim oleadpt As OleDb.OleDbDataAdapter
        olecon = New OleDb.OleDbConnection
        Try
            olecon.ConnectionString = connstring
            olecomm = New OleDb.OleDbCommand
            olecomm.CommandText = "Select REPORT_PLU_PLU,REPORT_PLU_WEIGHT,REPORT_PLU_VOLUME from [Report_Plu$]"
            olecomm.Connection = olecon
            oleadpt = New OleDb.OleDbDataAdapter(olecomm)
            'ds1 = New DataSet
            olecon.Open()
            oleadpt.Fill(DS, "Satislar")
            If IsNothing(DS) = False Then
            Else
            End If
            Dim s As String = ""
            Dim nSatir As Int64 = 0
            For Each dr In DS.Tables(0).Rows
                s += dr(0) & vbTab & dr(1) & vbTab & dr(2) & vbCrLf
                txt_ara.Text = sBarcodeStd & sayiuzunlukkontrol(dr(0), 5, "0") & sayiuzunlukkontrol(dr(1), 5, "0") & "0"
                nSatir = ds_hareket.Tables(0).Rows.Count
                stok_ara()
                If ds_hareket.Tables(0).Rows.Count > nSatir Then
                    GridView1.FocusedColumn = collBrutTutar
                    dr1 = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    dr1("lBrutTutar") = dr(2)
                    tutar_hesapla()
                End If
            Next
            'MsgBox(s)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
        Finally
            olecon.Close()
            olecon = Nothing
            olecomm = Nothing
            oleadpt = Nothing
            DS = Nothing
            dr = Nothing
            dr1 = Nothing
            pram = Nothing
        End Try
    End Sub
    Private Sub BarButtonItem4_ItemClick_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_tbStokFisiAdres()
    End Sub
    Private Sub BarButtonItem6_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        fis_kopyala()
    End Sub
    Private Sub fis_kopyala()
        Dim frm As New frm_fatura_kopyala
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sFisTipi = dr_baslik("sFisTipi")
        frm.nGirisCikis = dr_baslik("nGirisCikis")
        frm.kapla = True
        frm.nFirmaID = dr_baslik("nMusteriID")
        frm.sKodu = dr_baslik("lKodu")
        frm.txt_musteriNo.EditValue = dr_baslik("lKodu")
        frm.lbl_Firma.Text = dr_baslik("Musteri")
        frm.txt_dteFisTarihi1.EditValue = dr_baslik("dteFaturaTarihi")
        frm.txt_lFisNo.Text = dr_baslik("lFaturaNo")
        frm.sAdi = sAdi
        frm.sSoyadi = sSoyadi
        frm.sVergiDairesi = sVergiDairesi
        frm.sVergiNo = sVergiNo
        frm.sAdres1 = sAdres1
        frm.sAdres2 = sAdres2
        frm.bPerakende = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(dr_baslik("lFaturaNo") & Sorgu_sDil(" Nolu Fişi ", sDil) & frm.lbl_Firma.Text & Sorgu_sDil(" Hesabına Kopyalamaya Başlamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim es_nAlisVerisID As String = nAlisVerisID
                Dim es_lFaturaNo As Int64 = lFaturaNo
                Dim es_sFisTipi As String = sFisTipi
                Dim es_dteFisTarihi As DateTime = dteFisTarihi
                Dim es_nMusteriID = nMusteriID
                Dim es_sAdi As String = sAdi
                Dim es_sSoyadi As String = sSoyadi
                Dim es_sAdres1 As String = sAdres1
                Dim es_sAdres2 As String = sAdres2
                Dim es_sVergiDairesi As String = sVergiDairesi
                Dim es_sVergiNo As String = sVergiNo
                dteFisTarihi = frm.txt_dteFisTarihi1.EditValue
                sFisTipi = frm.sec_sFisTipi.EditValue
                nMusteriID = frm.nFirmaID
                sAdi = frm.sAdi
                sSoyadi = frm.sSoyadi
                sAdres1 = frm.sAdres1
                sAdres2 = frm.sAdres2
                sVergiDairesi = frm.sVergiDairesi
                sVergiNo = frm.sVergiNo
                nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
                lFaturaNo = sorgu_lFaturaNo(sMagaza, sFisTipi)
                sHareketTipi = sorgu_sHareketTipi(sMagaza)
                tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, dr_baslik("sKasiyerRumuzu"), sAdi, sSoyadi, dr_toplam("lToplamMiktar"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), dr_toplam("nDipIskontoYuzdesi"), dr_toplam("lDipIskontoTutari"), dr_toplam("nKdvOrani1"), dr_toplam("lKdvMatrahi1"), dr_toplam("lKdv1"), dr_toplam("nKdvOrani2"), dr_toplam("lKdvMatrahi2"), dr_toplam("lKdv2"), dr_toplam("nKdvOrani3"), dr_toplam("lKdvMatrahi3"), dr_toplam("lKdv3"), dr_toplam("nKdvOrani4"), dr_toplam("lKdvMatrahi4"), dr_toplam("lKdv4"), dr_toplam("nKdvOrani5"), dr_toplam("lKdvMatrahi5"), dr_toplam("lKdv5"), 0, 0, 0, 0, 0, 0, "", dr_toplam("lNetTutar"), dr_baslik("sHareketTipi"), 0, dr_baslik("nKasaNo"), kullaniciadi, Now, dr_toplam("sYaziIle"))
                tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
                lFaturaNo_degistir(lFaturaNo, sMagaza)
                nAlisVerisID = sMagaza & nAlisVerisID.ToString
                Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
                If kayitsayisi = 0 Then
                    tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, "", sAdres1, sAdres2, "", "", "", "", sVergiDairesi, sVergiNo, "")
                Else
                End If
                'Hareket Kaydet
                For Each dr In ds_hareket.Tables(0).Rows
                    If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
                        Dim nIslemID As Int64 = sorgu_nStokIslemID()
                        nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, dr("nStokID"), dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, dr("nGirisCikis"), dr_baslik("sMagaza"), dr("lReyonFisNo"), sFisTipi, dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dteFisTarihi, 0, 0, 0, 0, 0, dr("lCikisMiktar1"), 0, dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), 0, 0, 0, dr("nIskontoYuzdesi"), dr("lIskontoTutari"), "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("sAciklama"), dr_baslik("sHareketTipi"), 0, dr("sAciklama"), Now, dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), "", 0, 0, 0, "", nAlisVerisID, 0, "", "", sFisTipi, 0, 0, 0, 0, kullaniciadi, Now, dr("nPrim"), dr("lPrimTutari"))
                        fis_detay_fisno_degistir(nIslemID)
                    ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
                        Dim nSiparisID As Int64 = sorgu_nSiparisID(dr_baslik("sMagaza"))
                        tbAlisVerisSiparis_kaydet_yeni(nAlisVerisID, dr_baslik("sMagaza"), nSiparisID, dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), "", 0, dteFisTarihi, "01/01/1900", 0, 0, dr("sAciklama").ToString, 0, 0, 0, dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullaniciadi, Now, "01/01/1900", dr("nPrim"), dr("lPrimTutari"))
                        tbAvSirano_degistir(5, nSiparisID, dr_baslik("sMagaza"))
                    End If
                Next
                stok_satis_detay(nAlisVerisID, sFisTipi, sMagaza, True)
                nAlisVerisID = es_nAlisVerisID
                sFisTipi = es_sFisTipi
                lFaturaNo = es_lFaturaNo
                dteFisTarihi = es_dteFisTarihi
                nMusteriID = es_nMusteriID
                sAdi = es_sAdi
                sSoyadi = es_sSoyadi
                sAdres1 = es_sAdres1
                sAdres2 = es_sAdres2
                sVergiDairesi = es_sVergiDairesi
                sVergiNo = es_sVergiNo
            End If
        End If
    End Sub
    Private Sub stok_satis_detay(ByVal nAlisVerisID As String, ByVal sFisTipi As String, ByVal sMagaza As String, Optional ByVal bKopya As Boolean = False)
        If sorgu_nAlisVerisID_lSayi(nAlisVerisID) > 0 Then
            Dim frm As New frm_Perakende_Satis
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.nAlisVerisID = nAlisVerisID
            frm.sFisTipi = Trim(sFisTipi.ToString)
            frm.kullanici = kullanici
            frm.sMagaza = sMagaza
            frm.bKopya = bKopya
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
            'frm.Close()
            'frm.Dispose()
            'frm = Nothing
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    Private Sub analiz_tbStokFisiAdres()
        Dim frm As New frm_tbAlisVerisAdres
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.bParekende = True
        frm.nAlisVerisID = dr_baslik("nAlisVerisID")
        'Firma Açıklaması Kontrol
        Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(dr_baslik("nAlisVerisID"))
        If kayitsayisi = 0 Then
            tbAlisVerisAdres_kaydet_yeni(dr_baslik("nAlisVerisID"), dr_baslik("Musteri"), dr_baslik("sEvAdresi1"), dr_baslik("sAEvdresi2"), dr_baslik("sEvSemt"), dr_baslik("sEvIl"), "", dr_baslik("sEvPostaKodu"), dr_baslik("sVergiDairesi"), dr_baslik("sVergiNo"), sSubeMagaza)
        Else
        End If
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If kullanici <= 3 Then
            sDepo_toplu()
        End If
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        Dim frm As New frm_Perakende_Pesinatlar
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.status = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                pesinat_duzelt(dr1("nOdemeID"), dr_baslik("nAlisVerisID"))
                dataload_pesinat(dr_baslik("nAlisVerisID"))
                toplam_hesapla()
                toplam_hesapla_kapatma()
            End If
        End If
    End Sub
    Private Sub pesinat_duzelt(ByVal nOdemeID As String, ByVal nAlisVerisID As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbOdeme Set nAlisVerisID = '" & nAlisVerisID & "' Where nOdemeID = '" & nOdemeID & "' ")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("sKartNo").ToString = sorgu_sayi(dr_baslik("nMusteriID"), 0).ToString Then
                GridView2.OptionsBehavior.Editable = False
            Else
                GridView2.OptionsBehavior.Editable = True
            End If
        End If
    End Sub
    Friend WithEvents sec_Sinif2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rowSinif2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        baslik_degistir()
    End Sub
    Private Sub sec_Sinif2_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles sec_Sinif2.ListChanged
        ilkSor = False
    End Sub
    Friend WithEvents rowlMalArtisTutari As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem27_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Dim frm As New frm_perakende_odeme
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sKasiyer = sKasiyer
        frm.sKasiyerRumuzu = sKasiyerRumuzu
        frm.nMusteriID = nMusteriID
        frm.nOdemeKodu = nOdemeKodu
        frm.nKasaNo = nKasaNo
        frm.lKodu = 0
        frm.sMagaza = sMagaza
        frm.dteFisTarihi = dteFisTarihi
        'frm.sMusteri = lbl_musteri_adi.Text
        'If yetki_kontrol(kullanici, frm.Name) = True Then
        frm.ShowDialog()
        'End If
    End Sub
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    'Private Sub satir_ekle_silinen()
    '    Dim frm As New frm_Perakende_SilinenKayitlar
    '    frm.firmano = firmano
    '    frm.donemno = donemno
    '    frm.connection = connection
    '    frm.kullanici = kullanici
    '    frm.silinenEkle = True
    '    frm.sec_Tarihtipi.Text = "Fişler:"
    '    If yetki_kontrol(kullanici, Replace("frm_tbSilinen_Fişler:", ":", "")) = True Then
    '        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '            Dim s As String
    '            Dim arr As Integer()
    '            Dim i As Integer
    '            Dim dr1 As DataRow
    '            arr = frm.GridView1.GetSelectedRows()
    '            If arr Is Nothing Then
    '            Else
    '                Array.Sort(arr)
    '                For Each i In arr
    '                    s = i.ToString
    '                    dr1 = frm.GridView1.GetDataRow(s)
    '                    Dim nIslemID As Int64 = sorgu_nStokIslemID()
    '                    Dim silinenDataSet As DataSet = silinenStok(dr1("nAlisVerisID"))
    '                    Dim silinenRow As DataRow
    '                    For i1 As Integer = 0 To silinenDataSet.Tables(0).Rows.Count - 1
    '                        silinenRow = silinenDataSet.Tables(0).Rows(i1)
    '                        tbStokFisidetay_kaydet_yeni(nIslemID, silinenRow("nStokID"), dr_baslik("dteFaturaTarihi"), 0, dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr_baslik("lFaturaNo"), dr_baslik("nGirisCikis"), silinenRow("sDepo"), silinenRow("lReyonFisNo"), silinenRow("sStokIslem"), silinenRow("sKasiyerRumuzu"), silinenRow("sSaticiRumuzu"), silinenRow("sOdemeKodu"), "01/01/1900", 0, silinenRow("lGirisMiktar1"), silinenRow("lGirisMiktar2"), silinenRow("lGirisFiyat"), silinenRow("lGirisTutar"), silinenRow("lCikisMiktar1"), silinenRow("lCikisMiktar2"), silinenRow("lCikisFiyat"), silinenRow("lCikisTutar"), silinenRow("sFiyatTipi"), silinenRow("lBrutFiyat"), silinenRow("lBrutTutar"), silinenRow("lMaliyetFiyat"), silinenRow("lMaliyetTutar"), silinenRow("lIlaveMaliyetTutar"), silinenRow("nIskontoYuzdesi"), silinenRow("lIskontoTutari"), silinenRow("sDovizCinsi"), silinenRow("lDovizFiyat"), "", silinenRow("nReceteNo"), "", "", silinenRow("nKdvOrani"), silinenRow("nHesapID"), silinenRow("sAciklama"), dr_baslik("sHareketTipi"), dr_baslik("bMuhasebeyeIslendimi"), kullaniciadi, Now, silinenRow("sDovizCinsi1"), silinenRow("lDovizMiktari1"), silinenRow("lDovizKuru1"), silinenRow("sDovizCinsi2"), silinenRow("lDovizMiktari2"), silinenRow("lDovizKuru2"), silinenRow("nOTVOrani"), "", nAlisVerisID, 0, "", silinenRow("sMasrafYontemi"), "", silinenRow("nEksaha1"), silinenRow("nEkSaha2"), silinenRow("bEkSoru1"), silinenRow("bEkSoru2"), silinenRow("sSonKullaniciAdi"), Now, 0, 0)
    '                    Next
    '                    fis_detay_fisno_degistir(nIslemID)
    '                Next
    '            End If
    '            loaded()
    '            toplam_hesapla()
    '        End If
    '    End If
    'End Sub
    Private Function silinenStok(ByVal alisverisID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * from auStokFisiDetayi where nAlisVerisID = '" & alisverisID & "'")
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    'Private Sub BarButtonItem28_ItemClick_1(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
    '    satir_ekle_silinen()
    'End Sub
    Friend WithEvents muhasebelestir_button As DevExpress.XtraBars.BarButtonItem
    Private Function fatura_Muhasebelestir(ByVal FisTur As String) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim MuhsHareketTipi As String = ""
        'If Trim(dr_baslik("sHareketTipi").ToString()) = "" Then
        MuhsHareketTipi = Trim(sDepo)
        'Else
        'MuhsHareketTipi = Trim(dr_baslik("sHareketTipi").ToString())
        'End If
        Dim nSubeMagazaHesapTipi As Integer = 0
        If Trim(dr_baslik("nGirisCikis").ToString()) = "3" Then
            nSubeMagazaHesapTipi = 20
        ElseIf Trim(dr_baslik("nGirisCikis").ToString()) = "4" Then
            nSubeMagazaHesapTipi = 21
        End If
        Dim nSubeMagazaHesapTipiKdv As Integer = 0
        If Trim(dr_baslik("nGirisCikis").ToString()) = "3" Then
            nSubeMagazaHesapTipiKdv = 42
        ElseIf Trim(dr_baslik("nGirisCikis").ToString()) = "4" Then
            nSubeMagazaHesapTipiKdv = 43
        End If
        Dim SonYevmiyeNo As Integer = SonYevmiyeNoBul("3")
        Dim nHesapID As Integer = KasaMuhasebeKoduBul(Trim(sSubeMagaza), MuhsHareketTipi)
        Dim sorgu As String = ""
        Dim basarili As Boolean = False
        Dim fisSayisi As Integer = 0
        Dim lFaturaNo As String = ""
        Dim dteFaturaTarihi As String = ""
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If sorgu_sayi(dr_toplam("lNetTutar"), 0) > 0 Then
                fisSayisi = PerakendeMuhasebeFisiVarMi(dr_baslik("lFaturaNo").ToString(), "3", 2)
                If fisSayisi > 0 Then
                    If fisSayisi > 1 Then
                        lFaturaNo = PerakendeCokluFisBilgiSorgula(dr_baslik("nAlisverisID").ToString(), "3", 0)
                        dteFaturaTarihi = PerakendeCokluFisBilgiSorgula(dr_baslik("nAlisverisID").ToString(), "3", 1)
                        SonYevmiyeNo = Integer.Parse(PerakendeCokluFisBilgiSorgula(dr_baslik("nAlisverisID").ToString(), "3", 2))
                    End If
                    PerakendeMuhasebeFisiSil(dr_baslik("lFaturaNo").ToString(), dr_baslik("lFaturaNo").ToString(), dr_baslik("nAlisverisID").ToString(), "3", fisSayisi)
                Else
                    lFaturaNo = dr_baslik("lFaturaNo").ToString()
                    dteFaturaTarihi = dr_baslik("dteFaturaTarihi").ToString()
                End If
                sorgu = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & dr_baslik("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", " & nHesapID & ", N'Evrak No:" & dr_baslik("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, " & sorgu_sayi(dr_toplam("lNetTutar"), 0) & ", 0, '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '', 0, 0, '', 0, 0, 0, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '" & Trim(dr_baslik("sFisTipi").ToString()) & "', '0', '" & Trim(dr_baslik("nGirisCikis").ToString()) & "', '0', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "', '" & Trim(dr_baslik("nMusteriID").ToString()) & "') ")
                If sorgu_sayi(dr_toplam("lKdv1").ToString(), 0) > 0 Then
                    sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & dr_baslik("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(dr_toplam("nKdvOrani1").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & dr_baslik("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(dr_toplam("lKdv1"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '" & Trim(dr_baslik("sFisTipi").ToString()) & "', '0', '" & Trim(dr_baslik("nGirisCikis").ToString()) & "', '0', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "', '" & Trim(dr_baslik("nMusteriID").ToString()) & "') ")
                End If
                If sorgu_sayi(dr_toplam("lKdv2").ToString(), 0) > 0 Then
                    sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & dr_baslik("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(dr_toplam("nKdvOrani2").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & dr_baslik("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(dr_toplam("lKdv2"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '" & Trim(dr_baslik("sFisTipi").ToString()) & "', '0', '" & Trim(dr_baslik("nGirisCikis").ToString()) & "', '0', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "', '" & Trim(dr_baslik("nMusteriID").ToString()) & "') ")
                End If
                If sorgu_sayi(dr_toplam("lKdv3").ToString(), 0) > 0 Then
                    sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & dr_baslik("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(dr_toplam("nKdvOrani3").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & dr_baslik("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(dr_toplam("lKdv3"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '" & Trim(dr_baslik("sFisTipi").ToString()) & "', '0', '" & Trim(dr_baslik("nGirisCikis").ToString()) & "', '0', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "', '" & Trim(dr_baslik("nMusteriID").ToString()) & "') ")
                End If
                If sorgu_sayi(dr_toplam("lKdv4").ToString(), 0) > 0 Then
                    sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & dr_baslik("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(dr_toplam("nKdvOrani4").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & dr_baslik("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(dr_toplam("lKdv4"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '" & Trim(dr_baslik("sFisTipi").ToString()) & "', '0', '" & Trim(dr_baslik("nGirisCikis").ToString()) & "', '0', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "', '" & Trim(dr_baslik("nMusteriID").ToString()) & "') ")
                End If
                If sorgu_sayi(dr_toplam("lKdv5").ToString(), 0) > 0 Then
                    sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & dr_baslik("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(dr_toplam("nKdvOrani5").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & dr_baslik("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(dr_toplam("lKdv5"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '" & Trim(dr_baslik("sFisTipi").ToString()) & "', '0', '" & Trim(dr_baslik("nGirisCikis").ToString()) & "', '0', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "', '" & Trim(dr_baslik("nMusteriID").ToString()) & "') ")
                End If
                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & dr_baslik("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaHesaplari where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & ")), N'Evrak No:" & dr_baslik("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & (sorgu_sayi(dr_toplam("lNetTutar"), 0) - (sorgu_sayi(dr_toplam("lKdv1"), 0) + sorgu_sayi(dr_toplam("lKdv2"), 0) + sorgu_sayi(dr_toplam("lKdv3"), 0) + sorgu_sayi(dr_toplam("lKdv4"), 0) + sorgu_sayi(dr_toplam("lKdv5"), 0))) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '', 0, 0, '', 0, 0, 2, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & dr_baslik("dteKayitTarihi").ToString() & "', '" & Trim(dr_baslik("sFisTipi").ToString()) & "', '0', '" & Trim(dr_baslik("nGirisCikis").ToString()) & "', '0', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "', '" & Trim(dr_baslik("nMusteriID").ToString()) & "') ")
                If fisSayisi < 2 Then
                    sorgu += sorgu_query("INSERT INTO tbMuhasebeFisiAciklamasi(dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, bKilitli) VALUES('" & dr_baslik("dteFaturaTarihi").ToString() & "', '3', " & dr_baslik("lFaturaNo").ToString() & ", '', '" & Trim(dr_baslik("nAlisverisID").ToString()) & "-" & Trim(dr_baslik("sAlisverisYapanAdi").ToString()) & " " & Trim(dr_baslik("sAlisverisYapanSoyadi").ToString()) & "', '', '', '', 1)")
                End If
                cmd.CommandText = sorgu
                cmd.ExecuteNonQuery()
                basarili = True
                dr_baslik("sMuhasebeFaturalasma") = "Muhasebeleşti"
            End If
            XtraMessageBox.Show(Sorgu_sDil("Perakende Muhasebeleştirme İşlemi Başarılı.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            analiz_Muhasebe_fis("3")
        Catch ex As Exception
            dr_baslik("sMuhasebeFaturalasma") = "Bekliyor"
            XtraMessageBox.Show(Sorgu_sDil("Perakende Muhasebeleştirme İşlemi Başarısız!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
        Return basarili
    End Function
    Private Sub muhasebelestir_button_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles muhasebelestir_button.ItemClick
        'If Trim(dr_baslik("sFisTipi").ToString()) = "P" Then
        If yetki_kontrol(kullanici, "frm_Perakende_Muhasebelestirme") = True Then
            fatura_Muhasebelestir("P")
        End If
        'End If
    End Sub
    Friend WithEvents rowsMuhasebeFaturalasma As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Private Sub analiz_Muhasebe_fis(ByVal sMuhFisTipi As String)
        If PerakendeMuhasebeFisiVarMi(dr_baslik("lFaturaNo").ToString(), sMuhFisTipi, 1) > 0 Then
            Dim frm As New frm_tbMuhasebeFisi
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.dteFisTarihi = dr_baslik("dteFaturaTarihi")
            frm.lFisNo = dr_baslik("lFaturaNo")
            frm.bMuhasabe = True
            frm.sMuhFisTipi = sMuhFisTipi
            frm.kullanici = kullanici
            frm.PerakendeMi = True
            If yetki_kontrol(kullanici, "frm_Perakende_MuhasebeFisi_Onizleme") = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub

    Public Sub InitKolaysoftTokenVeCihaz(sDepo As String)
        Try
            KolaysoftToken = GetAuthenticationToken()
            KolaysoftTokenAlinmaZamani = Now
            If Not String.IsNullOrEmpty(KolaysoftFirmaId) Then
                Dim tumCihazlar = GetPosCihazListesi(KolaysoftFirmaId, KolaysoftToken, sDepo)
                If tumCihazlar.Count = 0 Then
                    ' Gönderim iptal et
                    KolaysoftCihazListesi = New List(Of String)
                    Return
                End If
                Dim sorgu = "SELECT sPosSeri FROM tbDepo WHERE sDepo = ?"
                Dim hedefPosSeri = String.Empty
                Dim cmd As New OleDb.OleDbCommand
                Dim con As New OleDb.OleDbConnection
                con.ConnectionString = connection
                cmd.CommandText = sorgu
                cmd.CommandTimeout = Nothing
                cmd.Connection = con
                cmd.Parameters.AddWithValue("?", sDepo)
                con.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then hedefPosSeri = result.ToString()
                con.Close()
                If Not String.IsNullOrEmpty(hedefPosSeri) AndAlso tumCihazlar.Contains(hedefPosSeri) Then
                    KolaysoftCihazListesi = New List(Of String) From {hedefPosSeri}
                Else
                    KolaysoftCihazListesi = New List(Of String)
                End If
            End If
        Catch ex As Exception
            LogYaz("InitKolaysoftTokenVeCihaz", ex.ToString())
            MessageBox.Show("Kolaysoft bağlantısı kurulamadı: " & ex.Message)
        End Try
    End Sub
    Private Function GetAuthenticationToken() As String
        Dim dtParam As DataTable = SQLCalistir("SELECT PosKullanici, PosSifre FROM tbParamGenel")
        If dtParam.Rows.Count = 0 Then Throw New Exception("tbParamGenel tablosunda kullanıcı bilgisi yok.")
        Dim username As String = dtParam.Rows(0)("PosKullanici").ToString().Trim()
        Dim password As String = dtParam.Rows(0)("PosSifre").ToString().Trim()
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then Throw New Exception("Kullanıcı adı veya şifre boş.")

        Dim jsonBody As String = JsonConvert.SerializeObject(New With {.username = username, .password = password})
        Dim request As HttpWebRequest = CType(WebRequest.Create("https://service.kolaysoftpos.com/api/erp-authenticate"), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim data As Byte() = Encoding.UTF8.GetBytes(jsonBody)
        request.ContentLength = data.Length
        Using stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
        End Using

        Dim responseContent As String = String.Empty
        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    responseContent = reader.ReadToEnd()
                    Dim parsed = JObject.Parse(responseContent)
                    Dim token = parsed("id_token")?.ToString()
                    If String.IsNullOrEmpty(token) Then Throw New Exception("Token alınamadı.")
                    KolaysoftFirmaId = parsed("companyId")?.ToString()
                    If String.IsNullOrEmpty(KolaysoftFirmaId) Then Throw New Exception("Firma ID'si alınamadı.")
                    Return token
                End Using
            End Using
        Catch webEx As WebException
            responseContent = New StreamReader(webEx.Response.GetResponseStream()).ReadToEnd()
            Throw New Exception("API isteği başarısız: " & webEx.Message & vbCrLf & "Yanıt: " & responseContent)
        End Try
    End Function
    Private Function GetPosCihazListesi(companyId As String, token As String, sDepo As String) As List(Of String)
        Dim cihazlar As New List(Of String)
        If String.IsNullOrEmpty(companyId) OrElse String.IsNullOrEmpty(token) OrElse String.IsNullOrEmpty(sDepo) Then
            Throw New Exception("companyId, token veya sDepo boş olamaz.")
        End If
        Dim url As String = "https://service.kolaysoftpos.com/services/pos/api/erp/pos-devices?companyId=" & companyId
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.Headers.Add("Authorization", "Bearer " & token)
        Dim responseContent As String = String.Empty
        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    responseContent = reader.ReadToEnd()
                    If String.IsNullOrEmpty(responseContent) Then Throw New Exception("API yanıtı boş.")
                    Dim jArray As JArray
                    Try
                        jArray = JArray.Parse(responseContent)
                    Catch ex As JsonException
                        Dim jObject = jObject.Parse(responseContent)
                        Dim terminalSerialNumberToken = jObject("terminalSerialNumber")
                        If terminalSerialNumberToken IsNot Nothing AndAlso TypeOf terminalSerialNumberToken Is JArray Then
                            jArray = DirectCast(terminalSerialNumberToken, JArray)
                        ElseIf terminalSerialNumberToken IsNot Nothing AndAlso TypeOf terminalSerialNumberToken Is JValue Then
                            jArray = New JArray(terminalSerialNumberToken.ToString())
                        Else
                            jArray = New JArray()
                        End If
                    End Try
                    If Not jArray.AsQueryable().Any() Then Throw New Exception("terminalSerialNumber dizisi bulunamadı veya boş.")
                    For Each cihaz As JToken In jArray
                        Dim serial = If(cihaz?.ToString(), String.Empty)
                        If Not String.IsNullOrEmpty(serial) Then cihazlar.Add(serial)
                    Next
                End Using
            End Using
        Catch webEx As WebException
            responseContent = New StreamReader(webEx.Response.GetResponseStream()).ReadToEnd()
            Throw New Exception("POS cihaz listesi alınamadı: " & webEx.Message & vbCrLf & "Yanıt: " & responseContent)
        Catch jsonEx As JsonException
            Throw New Exception("JSON ayrıştırma hatası: " & jsonEx.Message & vbCrLf & "Yanıt: " & responseContent)
        End Try
        ' Veritabanından sPosSeri sorgula ve filtrele
        Dim sorgu = "SELECT sPosSeri FROM tbDepo WHERE sDepo = ?"
        Dim hedefPosSeri = String.Empty
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandText = sorgu
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        cmd.Parameters.AddWithValue("?", sDepo)
        con.Open()
        Dim result = cmd.ExecuteScalar()
        If result IsNot Nothing Then hedefPosSeri = result.ToString()
        con.Close()
        If Not String.IsNullOrEmpty(hedefPosSeri) Then
            cihazlar = cihazlar.Where(Function(c) c = hedefPosSeri).ToList()
        End If
        Return cihazlar
    End Function
    Private Function SQLCalistir(sql As String) As DataTable
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        con.ConnectionString = connection ' connection değişkenini tanımla
        cmd.CommandText = sql ' SQL sorgusu ekle
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Dim dt As New DataTable()
        Try
            con.Open()
            adapter.Fill(dt)
        Catch ex As Exception
            LogYaz("SQLCalistir", ex.ToString())
            MessageBox.Show("SQL çalıştırma hatası: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return dt
    End Function
    Private Sub LogYaz(islem As String, mesaj As String)
        Try
            Using sw As New StreamWriter(LogDosyaYolu, True, Encoding.UTF8)
                sw.WriteLine(Now.ToString("yyyy-MM-dd HH:mm:ss") & " [" & islem & "] " & mesaj)
            End Using
        Catch ex As Exception
            Debug.WriteLine("Log yazma hatası: " & ex.Message)
        End Try
    End Sub
    'Private Function JsonOlustur(nAlisverisID As String, cihazId As String) As String
    '    Dim Round2 As Func(Of Decimal, Decimal) = Function(x) Math.Round(x, 2, MidpointRounding.AwayFromZero)
    '    Dim EPS As Decimal = 0.01D

    '    Dim nAlisverisID_SQL As String = "'" & dr_baslik("nAlisVerisID").ToString() & "'"

    '    ' --- Başlık ---
    '    Dim dtFis = SQLCalistir("SELECT * FROM tbAlisveris WHERE nAlisverisID = " & nAlisverisID_SQL)
    '    If dtFis Is Nothing OrElse dtFis.Rows.Count = 0 Then Throw New Exception("Satış bulunamadı.")
    '    Dim fis As DataRow = dtFis.Rows(0)
    '    Dim headerNet As Decimal = 0D
    '    If Not IsDBNull(fis("lNetTutar")) Then headerNet = Round2(Convert.ToDecimal(fis("lNetTutar")))

    '    ' --- Detay ---
    '    Dim dtDetay = SQLCalistir("
    '    SELECT d.*, s.sAciklama AS StokAdi, b.sBarkod, k.nKdvOrani 
    '    FROM tbStokFisiDetayi d
    '    LEFT JOIN tbStok s ON d.nStokID = s.nStokID
    '    LEFT JOIN tbKdv k ON s.sKdvTipi = k.sKdvTipi
    '    LEFT JOIN tbStokBarkodu b ON d.nStokID = b.nStokID AND b.nKisim = 0
    '    WHERE d.nAlisverisID = " & nAlisverisID_SQL)

    '    If dtDetay Is Nothing OrElse dtDetay.Rows.Count = 0 Then
    '        Throw New Exception("Satır bulunamadı.")
    '    End If

    '    ' --- Müşteri ---
    '    Dim dtMusteri = SQLCalistir("SELECT m.*, n.sCuzdanKayitNo AS TC " &
    '                            "FROM tbMusteri m INNER JOIN tbMusteriNufusu n ON m.nMusteriID = n.nMusteriID " &
    '                            "WHERE m.nMusteriID = " & fis("nMusteriID"))
    '    Dim mus As DataRow = If(dtMusteri IsNot Nothing AndAlso dtMusteri.Rows.Count > 0, dtMusteri.Rows(0), Nothing)

    '    Dim vkn As String = ""
    '    If mus IsNot Nothing Then
    '        If Not IsDBNull(mus("sVergiNo")) AndAlso mus("sVergiNo") IsNot Nothing Then vkn = mus("sVergiNo").ToString().Trim()
    '        If String.IsNullOrEmpty(vkn) Then
    '            If Not IsDBNull(mus("TC")) AndAlso mus("TC") IsNot Nothing Then vkn = mus("TC").ToString().Trim()
    '        End If
    '    End If
    '    Dim ad As String = If(mus IsNot Nothing AndAlso Not IsDBNull(mus("sAdi")), mus("sAdi").ToString().Trim(), "")
    '    Dim soyad As String = If(mus IsNot Nothing AndAlso Not IsDBNull(mus("sSoyAdi")), mus("sSoyAdi").ToString().Trim(), "")
    '    Dim email As String = ""
    '    If mus IsNot Nothing Then
    '        If Not IsDBNull(mus("sEmail")) Then email = mus("sEmail").ToString().Trim()
    '    End If

    '    ' --- Ödemeler ---
    '    Dim dtOdeme = SQLCalistir("SELECT o.lOdemeTutar, o.sOdemeSekli, s.nOdemeTipi FROM tbOdeme o " &
    '                          "LEFT JOIN tbOdemeSekli s ON o.sOdemeSekli = s.sOdemeSekli " &
    '                          "WHERE o.nAlisverisID = " & nAlisverisID_SQL)

    '    Dim cash As Decimal = 0D, credit1 As Decimal = 0D, credit2 As Decimal = 0D, eft As Decimal = 0D
    '    Dim krediSayac As Integer = 0
    '    If dtOdeme IsNot Nothing AndAlso dtOdeme.Rows.Count > 0 Then
    '        For Each odeme As DataRow In dtOdeme.Rows
    '            Dim tutar As Decimal = If(IsDBNull(odeme("lOdemeTutar")), 0D, Convert.ToDecimal(odeme("lOdemeTutar")))
    '            Dim tip As Integer = If(IsDBNull(odeme("nOdemeTipi")), -1, Convert.ToInt32(odeme("nOdemeTipi")))
    '            Select Case tip
    '                Case 1 ' Nakit
    '                    cash += tutar
    '                Case 2 ' Kredi kartı (çoklu kart 2. karta yığılır)
    '                    If krediSayac = 0 Then credit1 += tutar Else credit2 += tutar
    '                    krediSayac += 1
    '                Case 4 ' EFT/Havale
    '                    eft += tutar
    '                Case Else
    '                    ' Diğer tipler varsa gereğine göre ekle
    '            End Select
    '        Next
    '    End If
    '    ' 2 ondalığa yuvarla (kırpma değil, parasal doğru yuvarlama)
    '    cash = Round2(cash) : credit1 = Round2(credit1) : credit2 = Round2(credit2) : eft = Round2(eft)

    '    ' --- Satırları oluştur (KDV dahil) ---
    '    Dim urunler As New List(Of Dictionary(Of String, Object))()
    '    Dim sumLines As Decimal = 0D

    '    For Each dr As DataRow In dtDetay.Rows
    '        Dim miktar As Decimal = If(IsDBNull(dr("lBirimMiktar")), 0D, Convert.ToDecimal(dr("lBirimMiktar")))
    '        Dim kdvOrani As Decimal = If(IsDBNull(dr("nKdvOrani")), 0D, Convert.ToDecimal(dr("nKdvOrani")))
    '        Dim stokAdi As String = If(IsDBNull(dr("StokAdi")), "", dr("StokAdi").ToString())
    '        Dim barkod As String = If(IsDBNull(dr("sBarkod")), "", dr("sBarkod").ToString())

    '        Dim taxedTotal As Decimal = 0D

    '        ' Öncelik: tabloda KDV DAHİL satır toplamı varsa onu kullan
    '        If dr.Table.Columns.Contains("lSatirToplamKDVDahil") AndAlso Not IsDBNull(dr("lSatirToplamKDVDahil")) Then
    '            taxedTotal = Round2(Convert.ToDecimal(dr("lSatirToplamKDVDahil")))
    '        ElseIf dr.Table.Columns.Contains("lNetTutar") AndAlso Not IsDBNull(dr("lNetTutar")) Then
    '            taxedTotal = Round2(Convert.ToDecimal(dr("lNetTutar"))) ' şemanızda KDV dahil ise
    '        Else
    '            ' Hesapla (en son çare): (vergisiz birim fiyat * miktar - vergisiz indirimler) * (1+KDV)
    '            Dim unitExcl As Decimal = 0D
    '            If dr.Table.Columns.Contains("lBirimFiyat") AndAlso Not IsDBNull(dr("lBirimFiyat")) Then
    '                unitExcl = Convert.ToDecimal(dr("lBirimFiyat"))
    '            End If
    '            Dim discExcl As Decimal = 0D
    '            If dr.Table.Columns.Contains("SatirIskonto1") AndAlso Not IsDBNull(dr("SatirIskonto1")) Then discExcl += Convert.ToDecimal(dr("SatirIskonto1"))
    '            If dr.Table.Columns.Contains("SatirIskonto2") AndAlso Not IsDBNull(dr("SatirIskonto2")) Then discExcl += Convert.ToDecimal(dr("SatirIskonto2"))
    '            If dr.Table.Columns.Contains("SatirIskonto3") AndAlso Not IsDBNull(dr("SatirIskonto3")) Then discExcl += Convert.ToDecimal(dr("SatirIskonto3"))
    '            If dr.Table.Columns.Contains("SatirIskonto4") AndAlso Not IsDBNull(dr("SatirIskonto4")) Then discExcl += Convert.ToDecimal(dr("SatirIskonto4"))

    '            Dim excl As Decimal = unitExcl * miktar - discExcl
    '            If excl < 0D Then excl = 0D
    '            taxedTotal = Round2(excl * (1D + (kdvOrani / 100D)))
    '        End If

    '        sumLines += taxedTotal

    '        Dim prod As New Dictionary(Of String, Object) From {
    '        {"quantity", miktar},
    '        {"taxedTotalAmount", taxedTotal},
    '        {"productName", stokAdi},
    '        {"productBarcode", barkod},
    '        {"taxes", New Object() {New With {.taxRate = kdvOrani}}}
    '    }
    '        urunler.Add(prod)
    '    Next

    '    sumLines = Round2(sumLines)

    '    ' --- Toplamı eşitleme (kuruş farkını son satıra ekle) ---
    '    Dim totalAmountInvoice As Decimal
    '    If headerNet > 0D Then
    '        totalAmountInvoice = Round2(headerNet)
    '    Else
    '        totalAmountInvoice = sumLines
    '    End If

    '    Dim delta As Decimal = Round2(totalAmountInvoice - sumLines)
    '    If Math.Abs(delta) >= EPS Then
    '        ' Son satıra farkı ekle/çıkar (negatif olabilir), 0 altına düşürme
    '        Dim last = urunler(urunler.Count - 1)
    '        Dim lastVal As Decimal = Convert.ToDecimal(last("taxedTotalAmount"))
    '        Dim adjusted As Decimal = Round2(lastVal + delta)
    '        If adjusted < 0D Then adjusted = 0D
    '        last("taxedTotalAmount") = adjusted
    '        ' Toplamı yeniden hesapla
    '        sumLines = 0D
    '        For Each prod As Dictionary(Of String, Object) In urunler
    '            sumLines += Convert.ToDecimal(prod("taxedTotalAmount"))
    '        Next
    '        sumLines = Round2(sumLines)
    '        totalAmountInvoice = sumLines
    '    End If

    '    ' --- Ödeme doğrulama (KIRPMA YOK) ---
    '    Dim sumPays As Decimal = Round2(cash + credit1 + credit2 + eft)
    '    If sumPays > totalAmountInvoice + EPS Then
    '        ' Kırpmak yerine yanlış veriyi engelle
    '        Throw New Exception("Ödeme miktarları toplamı fatura toplamını aşıyor. Ödemeler=" &
    '                        sumPays.ToString("0.00") & "  Fatura=" & totalAmountInvoice.ToString("0.00") &
    '                        ". tbOdeme kayıtlarını / yuvarlamaları kontrol edin.")
    '    End If

    '    ' Veresiye = max(0, total - ödenen)
    '    Dim openAcc As Decimal = Round2(totalAmountInvoice - sumPays)
    '    If openAcc < 0D AndAlso Math.Abs(openAcc) <= EPS Then openAcc = 0D
    '    If openAcc < 0D Then openAcc = 0D

    '    ' --- JSON ---
    '    Dim faturaJson As New Dictionary(Of String, Object) From {
    '    {"totalAmount", totalAmountInvoice},
    '    {"companyId", KolaysoftFirmaId},
    '    {"currentIdentifier", vkn},
    '    {"currentFirstName", ad},
    '    {"currentLastName", soyad},
    '    {"currentTitle", Nothing},
    '    {"currentCity", Nothing},
    '    {"currentDistrict", Nothing},
    '    {"currentEmail", email},
    '    {"currentTaxOfficeCode", Nothing},
    '    {"currentStreet", Nothing},
    '    {"source", "ERP_RETAIL"},
    '    {"cashAmount", If(cash > 0D, CType(cash, Decimal?), Nothing)},
    '    {"creditCardFirstAmount", If(credit1 > 0D, CType(credit1, Decimal?), Nothing)},
    '    {"creditCardSecondAmount", If(credit2 > 0D, CType(credit2, Decimal?), Nothing)},
    '    {"openAccountAmount", If(openAcc > 0D, CType(openAcc, Decimal?), Nothing)},
    '    {"eftTransferAmount", If(eft > 0D, CType(eft, Decimal?), Nothing)},
    '    {"terminalSerialNumber", cihazId},
    '    {"explanation", Nothing},
    '    {"products", urunler}
    '}

    '    Dim jsonText As String = JsonConvert.SerializeObject(faturaJson, Newtonsoft.Json.Formatting.Indented)

    '    ' --- Dosyaya yaz ---
    '    Try
    '        Dim baseDir As String = "C:\EFatura\Json"
    '        If Not System.IO.Directory.Exists(baseDir) Then
    '            System.IO.Directory.CreateDirectory(baseDir)
    '        End If

    '        ' Örn: Fatura_12345_20251110_111530.json
    '        Dim fileName As String = $"Fatura_{nAlisverisID}_{DateTime.Now:yyyyMMdd_HHmmss}.json"
    '        Dim fullPath As String = System.IO.Path.Combine(baseDir, fileName)

    '        System.IO.File.WriteAllText(fullPath, jsonText, System.Text.Encoding.UTF8)
    '    Catch ex As Exception
    '        ' İsteğe bağlı: loglayın; JSON yine de döndürülür.
    '        ' Örn: LogYaz("JSON yazma hatası: " & ex.Message)
    '    End Try

    '    Return jsonText
    'End Function
    Private Function Round2(x As Decimal) As Decimal
        Return Math.Round(x, 2, MidpointRounding.AwayFromZero)
    End Function

    Private Function TryToDecimal(obj As Object, ByRef value As Decimal) As Boolean
        If obj Is Nothing OrElse IsDBNull(obj) Then Return False
        Try
            If TypeOf obj Is Decimal OrElse TypeOf obj Is Double OrElse TypeOf obj Is Single _
           OrElse TypeOf obj Is Integer OrElse TypeOf obj Is Long OrElse TypeOf obj Is Short Then
                value = Convert.ToDecimal(obj)
                Return True
            End If
            If TypeOf obj Is String Then
                Dim s As String = DirectCast(obj, String).Trim()
                If s.Length = 0 Then Return False
                If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, value) Then Return True
                If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, value) Then Return True
            End If
        Catch
        End Try
        Return False
    End Function

    Private Function GetDec(dr As DataRow, colName As String) As Decimal
        Dim v As Decimal
        If dr.Table.Columns.Contains(colName) AndAlso TryToDecimal(dr(colName), v) Then
            Return v
        End If
        Return 0D
    End Function

    '----------------- Ana Fonksiyon -----------------
    Private Function JsonOlustur(nAlisverisID As String, cihazId As String) As String
        Dim EPS As Decimal = 0.01D

        ' Mevcut akış: dr_baslik kullanılıyor
        Dim nAlisverisID_SQL As String = "'" & dr_baslik("nAlisVerisID").ToString() & "'"

        ' --- Başlık ---
        Dim dtFis As DataTable = SQLCalistir("SELECT * FROM tbAlisveris WHERE nAlisverisID = " & nAlisverisID_SQL)
        If dtFis Is Nothing OrElse dtFis.Rows.Count = 0 Then Throw New Exception("Satış bulunamadı.")
        Dim fis As DataRow = dtFis.Rows(0)
        Dim headerNet As Decimal = 0D
        If Not IsDBNull(fis("lNetTutar")) Then headerNet = Round2(Convert.ToDecimal(fis("lNetTutar")))

        ' --- Detay (yalnızca gereken kolonlar + gösterim alanları) ---
        Dim dtDetay As DataTable = SQLCalistir("
        SELECT 
            d.lCikismiktar1,          -- miktar
            d.lCikisFiyat,            -- KDV hariç birim fiyat
            d.lBrutFiyat,             -- KDV dahil birim fiyat
            d.lCikisTutar,            -- KDV hariç satır toplam
            d.lBrutTutar,             -- KDV dahil satır toplam
            d.lIskontoTutari,         -- satır indirimi
            d.nkdvOrani,              -- KDV oranı (%)
            s.sAciklama AS StokAdi, 
            b.sBarkod
        FROM tbStokFisiDetayi d
        LEFT JOIN tbStok s         ON d.nStokID = s.nStokID
        LEFT JOIN tbStokBarkodu b  ON d.nStokID = b.nStokID AND b.nKisim = 0
        WHERE d.nAlisverisID = " & nAlisverisID_SQL)

        If dtDetay Is Nothing OrElse dtDetay.Rows.Count = 0 Then Throw New Exception("Satır bulunamadı.")

        ' --- Müşteri (VKN/TCKN, ad-soyad, e-posta) ---
        Dim dtMusteri As DataTable = SQLCalistir("
        SELECT m.*, ISNULL(n.sCuzdanKayitNo,'') AS TC
        FROM tbMusteri m 
        LEFT JOIN tbMusteriNufusu n ON m.nMusteriID = n.nMusteriID
        WHERE m.nMusteriID = " & fis("nMusteriID"))

        Dim mus As DataRow = If(dtMusteri IsNot Nothing AndAlso dtMusteri.Rows.Count > 0, dtMusteri.Rows(0), Nothing)

        Dim vkn As String = ""
        If mus IsNot Nothing Then
            If Not IsDBNull(mus("sVergiNo")) AndAlso mus("sVergiNo") IsNot Nothing Then vkn = mus("sVergiNo").ToString().Trim()
            If String.IsNullOrEmpty(vkn) Then
                If Not IsDBNull(mus("TC")) AndAlso mus("TC") IsNot Nothing Then vkn = mus("TC").ToString().Trim()
            End If
        End If
        Dim ad As String = If(mus IsNot Nothing AndAlso Not IsDBNull(mus("sAdi")), mus("sAdi").ToString().Trim(), "")
        Dim soyad As String = If(mus IsNot Nothing AndAlso Not IsDBNull(mus("sSoyAdi")), mus("sSoyAdi").ToString().Trim(), "")
        Dim email As String = If(mus IsNot Nothing AndAlso Not IsDBNull(mus("sEmail")), mus("sEmail").ToString().Trim(), "")

        ' Firma ünvanı: Sadece sUnvan alanında FARKLI bir değer varsa kullan
        ' Bireysel müşterilerde (sUnvan boş veya ad+soyad ile aynı) currentTitle boş kalacak
        Dim unvan As String = ""
        If mus IsNot Nothing AndAlso Not IsDBNull(mus("sUnvan")) AndAlso mus("sUnvan") IsNot Nothing Then
            Dim tempUnvan As String = mus("sUnvan").ToString().Trim()
            Dim adSoyad As String = (ad & " " & soyad).Trim()
            ' sUnvan, ad+soyad ile aynı DEĞİLSE kullan (firma müşterisi)
            If Not String.IsNullOrEmpty(tempUnvan) AndAlso 
               tempUnvan.ToUpperInvariant() <> adSoyad.ToUpperInvariant() AndAlso
               tempUnvan.ToUpperInvariant() <> ad.ToUpperInvariant() AndAlso
               tempUnvan.ToUpperInvariant() <> soyad.ToUpperInvariant() Then
                unvan = tempUnvan
            End If
        End If

        ' Vergi Dairesi Kodu
        Dim vergiDairesi As String = ""
        If mus IsNot Nothing AndAlso Not IsDBNull(mus("sVergiDairesi")) AndAlso mus("sVergiDairesi") IsNot Nothing Then
            vergiDairesi = mus("sVergiDairesi").ToString().Trim()
        End If
        ' Bireysel müşteri için varsayılan vergi dairesi
        If String.IsNullOrEmpty(vergiDairesi) Then
            vergiDairesi = "0"
        End If

        ' *** 5000₺ ÜSTÜ SATIŞLARDA MÜŞTERİ BİLGİSİ ZORUNLU ***
        ' *** MÜŞTERİ BİLGİSİ KONTROLÜ - En az ad veya soyad olmalı ***
        If String.IsNullOrEmpty(ad) AndAlso String.IsNullOrEmpty(soyad) AndAlso String.IsNullOrEmpty(unvan) Then
            Throw New Exception("MUSTERI BILGISI EKSIK!" & vbCrLf & vbCrLf &
                "Musteri kartinda Firma Unvani veya Ad-Soyad bilgisi bulunamiyor." & vbCrLf & vbCrLf &
                "Lutfen kontrol edin:" & vbCrLf &
                "- Cari hesap kartinda Firma Unvani veya Ad/Soyad alanlarini doldurun" & vbCrLf &
                "- Musteri seciminin dogru yapildigindan emin olun")
        End If

        ' *** 5000 TL USTU SATISLARDA MUSTERI BILGISI ZORUNLU ***
        If headerNet >= 5000 AndAlso String.IsNullOrEmpty(vkn) Then
            Throw New Exception("5000₺ ve üzeri satışlarda müşteri VKN/TCKN bilgisi zorunludur!" & vbCrLf & vbCrLf &
                "Lütfen müşteri kartında Vergi No veya TC Kimlik No bilgisini giriniz.")
        End If

        ' --- Ödemeler ---
        Dim dtOdeme As DataTable = SQLCalistir("
        SELECT o.lOdemeTutar, s.nOdemeTipi
        FROM tbOdeme o
        LEFT JOIN tbOdemeSekli s ON o.sOdemeSekli = s.sOdemeSekli
        WHERE o.nAlisverisID = " & nAlisverisID_SQL)

        Dim cash As Decimal = 0D, credit1 As Decimal = 0D, credit2 As Decimal = 0D, eft As Decimal = 0D
        Dim krediSayac As Integer = 0
        If dtOdeme IsNot Nothing AndAlso dtOdeme.Rows.Count > 0 Then
            For Each od As DataRow In dtOdeme.Rows
                Dim tutar As Decimal = If(IsDBNull(od("lOdemeTutar")), 0D, Convert.ToDecimal(od("lOdemeTutar")))
                Dim tip As Integer = If(IsDBNull(od("nOdemeTipi")), -1, Convert.ToInt32(od("nOdemeTipi")))
                Select Case tip
                    Case 1 : cash += tutar                    ' Nakit
                    Case 2 : If krediSayac = 0 Then credit1 += tutar Else credit2 += tutar : krediSayac += 1
                    Case 4 : eft += tutar                     ' EFT/Havale
                End Select
            Next
        End If
        cash = Round2(cash) : credit1 = Round2(credit1) : credit2 = Round2(credit2) : eft = Round2(eft)

        ' --- Satırlar ---
        Dim urunler As New List(Of Dictionary(Of String, Object))()
        Dim sumLines As Decimal = 0D

        For Each dr As DataRow In dtDetay.Rows
            Dim qty As Decimal = Round2(GetDec(dr, "lCikismiktar1"))
            Dim unitExcl As Decimal = Round2(GetDec(dr, "lCikisFiyat"))
            Dim unitIncl As Decimal = Round2(GetDec(dr, "lBrutFiyat"))
            Dim lineExcl As Decimal = Round2(GetDec(dr, "lCikisTutar"))
            Dim lineIncl As Decimal = Round2(GetDec(dr, "lBrutTutar"))
            Dim disc As Decimal = Math.Abs(Round2(GetDec(dr, "lIskontoTutari"))) ' KDV DAHİL iskonto (her zaman +)
            Dim rate As Decimal = GetDec(dr, "nkdvOrani") ' yüzde

            Dim taxedTotal As Decimal = 0D

            If lineIncl > 0D Then
                ' 1) KDV dahil satır toplamı - KDV dahil iskonto
                taxedTotal = Math.Max(0D, Round2(lineIncl - disc))

            ElseIf lineExcl > 0D Then
                ' 2) KDV hariç satır toplamı → KDV ekle (iskonto KDV DAHİL olduğundan KDV hariçe çevirip düş)
                Dim discExcl As Decimal = If(rate > 0D, Round2(disc / (1D + (rate / 100D))), disc)
                Dim excl As Decimal = Math.Max(0D, lineExcl - discExcl)
                taxedTotal = Round2(excl * (1D + (rate / 100D)))

            Else
                ' 3) Birim fiyat * miktar - iskonto
                Dim base As Decimal = 0D

                If unitIncl > 0D Then
                    ' Birim fiyat KDV dahil
                    base = Math.Max(0D, (unitIncl * qty) - disc)
                    taxedTotal = Round2(base)
                Else
                    ' Birim fiyat KDV hariç (iskonto KDV dahil → KDV hariçe çevirip düş)
                    Dim discExcl As Decimal = If(rate > 0D, Round2(disc / (1D + (rate / 100D))), disc)
                    base = Math.Max(0D, (unitExcl * qty) - discExcl)
                    taxedTotal = Round2(base * (1D + (rate / 100D)))
                End If
            End If

            Dim name As String = If(dr.Table.Columns.Contains("StokAdi") AndAlso Not IsDBNull(dr("StokAdi")), dr("StokAdi").ToString(), "")
            Dim barkod As String = If(dr.Table.Columns.Contains("sBarkod") AndAlso Not IsDBNull(dr("sBarkod")), dr("sBarkod").ToString(), "")

            sumLines += taxedTotal

            Dim prod As New Dictionary(Of String, Object) From {
            {"quantity", qty},
            {"taxedTotalAmount", taxedTotal},
            {"productName", name},
            {"productBarcode", barkod},
            {"taxes", New Object() {New With {.taxRate = rate}}}
        }
            urunler.Add(prod)
        Next

        sumLines = Round2(sumLines)

        ' --- Başlık toplamıyla eşitle (kuruş farkını son satıra yaz) ---
        Dim totalAmountInvoice As Decimal = If(headerNet > 0D, Round2(headerNet), sumLines)
        Dim delta As Decimal = Round2(totalAmountInvoice - sumLines)
        If urunler.Count > 0 AndAlso Math.Abs(delta) >= EPS Then
            Dim last As Dictionary(Of String, Object) = urunler(urunler.Count - 1)
            Dim lastVal As Decimal = Convert.ToDecimal(last("taxedTotalAmount"))
            Dim adjusted As Decimal = Round2(Math.Max(0D, lastVal + delta))
            last("taxedTotalAmount") = adjusted

            ' sumLines güncelle
            sumLines = 0D
            For Each it As Dictionary(Of String, Object) In urunler
                sumLines += Convert.ToDecimal(it("taxedTotalAmount"))
            Next
            sumLines = Round2(sumLines)
            totalAmountInvoice = sumLines
        End If

        ' --- Ödeme doğrulama (opsiyonel güvenlik) ---
        Dim sumPays As Decimal = Round2(cash + credit1 + credit2 + eft)
        If sumPays > totalAmountInvoice + EPS Then
            Throw New Exception("Ödeme toplamı fatura toplamını aşıyor. Ödemeler=" &
                            sumPays.ToString("0.00") & "  Fatura=" & totalAmountInvoice.ToString("0.00") &
                            ". Ödeme kayıtlarını/yuvarlamaları kontrol edin.")
        End If

        ' --- Veresiye ---
        Dim openAcc As Decimal = Round2(totalAmountInvoice - sumPays)
        If openAcc < 0D AndAlso Math.Abs(openAcc) <= EPS Then openAcc = 0D
        If openAcc < 0D Then openAcc = 0D

        ' --- JSON ---
        Dim faturaJson As New Dictionary(Of String, Object) From {
        {"totalAmount", totalAmountInvoice},
        {"companyId", KolaysoftFirmaId},
        {"currentIdentifier", vkn},
        {"currentFirstName", ad},
        {"currentLastName", soyad},
        {"currentTitle", unvan},
        {"currentCity", Nothing},
        {"currentDistrict", Nothing},
        {"currentEmail", email},
        {"currentTaxOfficeCode", vergiDairesi},
        {"currentStreet", Nothing},
        {"source", "ERP_RETAIL"},
        {"cashAmount", If(cash > 0D, CType(cash, Decimal?), Nothing)},
        {"creditCardFirstAmount", If(credit1 > 0D, CType(credit1, Decimal?), Nothing)},
        {"creditCardSecondAmount", If(credit2 > 0D, CType(credit2, Decimal?), Nothing)},
        {"openAccountAmount", If(openAcc > 0D, CType(openAcc, Decimal?), Nothing)},
        {"eftTransferAmount", If(eft > 0D, CType(eft, Decimal?), Nothing)},
        {"terminalSerialNumber", cihazId},
        {"explanation", Nothing},
        {"products", urunler}
    }

        Dim jsonText As String = JsonConvert.SerializeObject(faturaJson, Formatting.Indented)

        ' --- Dosyaya yaz (C:\EFatura\Json) ---
        Try
            Dim baseDir As String = "C:\EFatura\Json"
            If Not System.IO.Directory.Exists(baseDir) Then System.IO.Directory.CreateDirectory(baseDir)

            Dim safeId As String = If(String.IsNullOrWhiteSpace(nAlisverisID), dr_baslik("nAlisVerisID").ToString().Trim(), nAlisverisID)
            Dim fileName As String = $"Fatura_{safeId}_{DateTime.Now:yyyyMMdd_HHmmss}.json"
            Dim fullPath As String = System.IO.Path.Combine(baseDir, fileName)

            System.IO.File.WriteAllText(fullPath, jsonText, System.Text.Encoding.UTF8)
        Catch
            ' log isteğe bağlı
        End Try

        Return jsonText
    End Function

    Public Sub SatisiKolaysoftaGonder(nAlisverisID As String, Optional cihazId As String = "")
        Dim responseContent As String = String.Empty
        Try
            InitKolaysoftTokenVeCihaz(sDepo)


            ' CihazId boşsa mevcut cihaz listesinden al
            Dim cihazKodu As String = cihazId
            If String.IsNullOrEmpty(cihazKodu) Then
                If KolaysoftCihazListesi Is Nothing OrElse KolaysoftCihazListesi.Count = 0 Then
                    If Not String.IsNullOrEmpty(KolaysoftFirmaId) Then
                        KolaysoftCihazListesi = GetPosCihazListesi(KolaysoftFirmaId, KolaysoftToken, sDepo)
                    End If
                End If
                If KolaysoftCihazListesi IsNot Nothing AndAlso KolaysoftCihazListesi.Count > 0 Then
                    cihazKodu = KolaysoftCihazListesi(0)
                Else
                    Throw New Exception("POS cihazı bulunamadı. Cihaz ID zorunludur.")
                End If
            End If

            ' 1) Satışı cihaza gönder (UI bloklamaz — sadece gönderim)
            Dim jsonBody = JsonOlustur("'" & nAlisverisID & "'", cihazKodu)

            ServicePointManager.Expect100Continue = False
            ServicePointManager.DefaultConnectionLimit = 100

            Dim req = CType(WebRequest.Create("https://service.kolaysoftpos.com/services/pos/api/erp/invoices"), HttpWebRequest)
            req.Method = "POST"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            req.Headers.Add("Authorization", "Bearer " & KolaysoftToken)
            req.Timeout = 30000
            req.ReadWriteTimeout = 30000
            req.KeepAlive = False
            req.Proxy = Nothing
            req.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate

            Dim data = Encoding.UTF8.GetBytes(jsonBody)
            req.ContentLength = data.Length
            Using s = req.GetRequestStream()
                s.Write(data, 0, data.Length)
            End Using

            Dim posPaymentId As String = Nothing
            Dim invoiceId As String = Nothing

            ' 2) posPaymentId / invoiceId yakala (güvenli)
            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8, detectEncodingFromByteOrderMarks:=True)
                    Dim sonuc As String = reader.ReadToEnd()
                    SonFaturaIcerigi = sonuc

                    Dim sTrim As String = sonuc.TrimStart(ChrW(&HFEFF)).Trim()
                    If Not (sTrim.StartsWith("{") OrElse sTrim.StartsWith("[")) Then
                        Throw New Exception("POS API JSON yerine farklı içerik döndü (muhtemelen HTML).")
                    End If

                    Dim tok As JToken = JToken.Parse(sTrim)
                    If tok.Type = JTokenType.Object Then
                        posPaymentId = CStr(tok.SelectToken("posPaymentId"))
                        If String.IsNullOrEmpty(posPaymentId) Then posPaymentId = CStr(tok.SelectToken("id"))
                        invoiceId = CStr(tok.SelectToken("invoiceId"))
                    ElseIf tok.Type = JTokenType.Array Then
                        Dim arr = CType(tok, JArray)
                        If arr.Count > 0 AndAlso TypeOf arr(0) Is JObject Then
                            Dim first = CType(arr(0), JObject)
                            posPaymentId = CStr(first.SelectToken("posPaymentId"))
                            If String.IsNullOrEmpty(posPaymentId) Then posPaymentId = CStr(first.SelectToken("id"))
                            invoiceId = CStr(first.SelectToken("invoiceId"))
                        End If
                    Else
                        Throw New Exception("Beklenmeyen JSON tipi: " & tok.Type.ToString())
                    End If
                End Using
            End Using

            ' Güvenlik
            If String.IsNullOrEmpty(posPaymentId) AndAlso String.IsNullOrEmpty(invoiceId) Then
                Throw New Exception("InvoiceCreate sonrası posPaymentId/invoiceId alınamadı.")
            End If

            ' 3) ARKA PLANDA belge numarası bul/güncelle (UI donmaz)
            StartDocumentNoWorker(KolaysoftFirmaId, posPaymentId, invoiceId, nAlisverisID)

            ' Kullanıcıyı serbest bırak (fişi kapatabilirsin)
            'MessageBox.Show("✅ Satış gönderildi. Belge numarası arka planda alınacak ve sisteme işlenecek.")

        Catch ex As WebException
            If ex.Response IsNot Nothing Then
                responseContent = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
            End If
            LogYaz("SatisiKolaysoftaGonder", "Hata: " & ex.Message & vbCrLf & "Yanıt: " & responseContent)

            ' Kullanıcı dostu hata mesajı oluıtur
            Dim kullaniciMesaji As String = KolaysoftHataCevir(responseContent, ex.Message)
            MessageBox.Show(kullaniciMesaji, "Kolaysoft Fatura Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            LogYaz("SatisiKolaysoftaGonder", "Hata: " & ex.Message & vbCrLf & "Yanıt: " & responseContent)

            Dim kullaniciMesaji As String = KolaysoftHataCevir(responseContent, ex.Message)
            MessageBox.Show(kullaniciMesaji, "Kolaysoft Fatura Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' Kolaysoft API hatalarini kullanici dostu mesajlara cevirir
    Private Function KolaysoftHataCevir(apiYanit As String, exMessage As String) As String
        Dim mesaj As String = ""
        Try
            If Not String.IsNullOrEmpty(apiYanit) Then
                If apiYanit.Contains("Firma") AndAlso apiYanit.Contains("olamaz") Then
                    mesaj = "MUSTERI BILGISI EKSIK" & vbCrLf & vbCrLf & "Fatura gonderilemedi cunku musteri firma unvani bos." & vbCrLf & vbCrLf & "Cozum: Cari hesap kartinda Firma Unvani alanini doldurun"
                ElseIf apiYanit.Contains("Odeme") OrElse apiYanit.Contains("fatura toplam") Then
                    mesaj = "ODEME TUTARI HATASI" & vbCrLf & vbCrLf & "Odeme tutari fatura toplamindan fazla." & vbCrLf & vbCrLf & "Cozum: Odeme tutarlarini kontrol edin"
                ElseIf apiYanit.Contains("404") OrElse apiYanit.Contains("Not Found") Then
                    mesaj = "BAGLANTI HATASI - Kolaysoft servisi erisilemez. Internet baglantinizi kontrol edin."
                ElseIf apiYanit.Contains("401") OrElse apiYanit.Contains("Unauthorized") Then
                    mesaj = "YETKILENDIRME HATASI - Kolaysoft oturumu sona ermis. Programi yeniden baslatin."
                ElseIf apiYanit.Contains("500") OrElse apiYanit.Contains("Internal Server Error") Then
                    mesaj = "SUNUCU HATASI - Kolaysoft sunucusunda sorun var. Birkac dakika bekleyip tekrar deneyin."
                Else
                    mesaj = "FATURA HATASI" & vbCrLf & apiYanit
                End If
            Else
                If exMessage.Contains("imeout") Then
                    mesaj = "ZAMAN ASIMI - Kolaysoft sunucusu yanit vermedi. Tekrar deneyin."
                Else
                    mesaj = "HATA: " & exMessage
                End If
            End If
        Catch
            mesaj = "HATA: " & exMessage
        End Try
        Return mesaj
    End Function

    Private Sub StartDocumentNoWorker(companyId As String, posPaymentId As String, invoiceId As String, nAlisverisID As String)
        Dim th As New Thread(
        Sub()
            Try
                ' 1) Önce POS PAYMENTS (satış ödemesi) üzerinden ara
                Dim documentNo As String = PollDocumentNo_PosPayments(companyId, posPaymentId, invoiceId)

                ' 2) Bulunamazsa, yedek olarak CURRENT POS PAYMENTS (cari/veresiye) üzerinden de dene
                If String.IsNullOrEmpty(documentNo) Then
                    documentNo = PollDocumentNo_PosPayments(companyId, posPaymentId, invoiceId)
                End If

                If Not String.IsNullOrEmpty(documentNo) Then
                    Dim nAlisverisID_SQL As String = "'" & nAlisverisID.Replace("'", "''") & "'"
                    Dim doc_SQL As String = "'" & documentNo.Replace("'", "''") & "'"

                    Dim doc_SQL_N As String = "N" & doc_SQL

                    Dim sql As New StringBuilder()
                    sql.AppendLine("BEGIN TRAN;")
                    sql.AppendLine("UPDATE tbAlisveris")
                    sql.AppendLine("SET PosFisNo = " & doc_SQL_N & ",")
                    sql.AppendLine("    bMuhasebeyeIslendimi = 1,")
                    sql.AppendLine("    sMuhasebeFaturalasma = N'POS cihazına gönderildi'")
                    sql.AppendLine("WHERE nAlisverisID = " & nAlisverisID_SQL & ";")
                    sql.AppendLine("COMMIT TRAN;")
                    SQLCalistir(sql.ToString())

                    SQLCalistir(sql.ToString())
                    LogYaz("StartDocumentNoWorker", "Belge no işlendi: " & documentNo)

                    Try
                        If Application.OpenForms.Count > 0 Then
                            Dim f = Application.OpenForms(0)
                            If f IsNot Nothing AndAlso f.IsHandleCreated Then
                                f.BeginInvoke(CType(Sub()
                                                        'MessageBox.Show("✅ Belge no alındı ve işlendi: " & documentNo)
                                                    End Sub, Action))
                            End If
                        End If
                    Catch
                    End Try
                Else
                    LogYaz("StartDocumentNoWorker", "Belge no alınamadı (timeout veya SUCCESS olmadı).")
                End If

            Catch ex As Exception
                LogYaz("StartDocumentNoWorker", "Hata: " & ex.Message)
            End Try
        End Sub)
        th.IsBackground = True
        th.Start()
    End Sub
    Private Function PollDocumentNo_PosPayments(companyId As String, posPaymentId As String, invoiceId As String) As String
        Dim maxTries As Integer = 20      ' ~5 dakika (30sn x 10)
        Dim delaySec As Integer = 30

        For i = 1 To maxTries
            Try
                Dim sb As New StringBuilder("https://service.kolaysoftpos.com/services/pos/api/erp/pos-payments?")
                sb.Append("size=1&sort=id,desc")
                sb.Append("&companyId.equals=").Append(Uri.EscapeDataString(companyId))
                If Not String.IsNullOrEmpty(posPaymentId) Then
                    sb.Append("&id.in=").Append(Uri.EscapeDataString(posPaymentId))
                ElseIf Not String.IsNullOrEmpty(invoiceId) Then
                    sb.Append("&invoiceId.in=").Append(Uri.EscapeDataString(invoiceId))
                End If

                Dim req = CType(WebRequest.Create(sb.ToString()), HttpWebRequest)
                req.Method = "GET"
                req.Accept = "application/json"
                req.Headers.Add("Authorization", "Bearer " & KolaysoftToken)
                req.Timeout = 30000
                req.ReadWriteTimeout = 30000
                req.KeepAlive = False
                req.Proxy = Nothing
                req.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate

                Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8, detectEncodingFromByteOrderMarks:=True)
                        Dim txt As String = reader.ReadToEnd()
                        Dim s As String = txt.TrimStart(ChrW(&HFEFF)).Trim()

                        Dim logPreview As String = If(s.Length > 400, s.Substring(0, 400) & "...", s)
                        LogYaz("PollDocumentNo_PosPayments", $"Yanıt[{i}]: {logPreview}")

                        If String.IsNullOrWhiteSpace(s) OrElse Not (s.StartsWith("{") OrElse s.StartsWith("[")) Then
                            Throw New Exception("Geçersiz JSON yanıtı.")
                        End If

                        Dim tok As JToken = JToken.Parse(s)
                        Dim arr As JArray = If(tok.Type = JTokenType.Array, CType(tok, JArray), New JArray(tok))
                        If arr.Count > 0 AndAlso TypeOf arr(0) Is JObject Then
                            Dim first As JObject = CType(arr(0), JObject)
                            Dim status As String = CStr(first.SelectToken("status"))
                            Dim documentNo As String = CStr(first.SelectToken("documentNo"))
                            LogYaz("PollDocumentNo_PosPayments", $"Status[{i}]: {status}, DocNo: {documentNo}")

                            If Not String.IsNullOrEmpty(status) Then
                                Select Case status.ToUpperInvariant()
                                    Case "SUCCESS"
                                        If Not String.IsNullOrEmpty(documentNo) Then
                                            Return documentNo ' ✅ E-belge no
                                        End If
                                    Case "FAILED", "CANCELLED", "ABORTED", "SALE_CANCEL_FAILED"
                                        LogYaz("PollDocumentNo_PosPayments", "Ödeme sonlandı: " & status)
                                        Return Nothing
                                    Case Else
                                        ' PENDING, ON_TERMINAL, IN_PROGRESS... beklemeye devam
                                End Select
                            End If
                        End If
                    End Using
                End Using

            Catch ex As WebException
                LogYaz("PollDocumentNo_PosPayments", "Hata: " & ex.Message)
                ' 500 gibi durumlarda logla ve tekrar dene
            Catch ex As Exception
                LogYaz("PollDocumentNo_PosPayments", "Hata: " & ex.Message)
            End Try

            Threading.Thread.Sleep(TimeSpan.FromSeconds(delaySec))
        Next

        Return Nothing
    End Function

    'Private Sub Yazdir()
    '    Dim doc As New PrintDocument()
    '    AddHandler doc.PrintPage, AddressOf PrintPageHandler
    '    doc.Print()
    'End Sub
    Private Sub BarButtonItem29_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        analiz_Muhasebe_fis("3")
    End Sub

    Private Sub ContextMenu1_Popup(sender As Object, e As EventArgs) Handles ContextMenu1.Popup

    End Sub
End Class
