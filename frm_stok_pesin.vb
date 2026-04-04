Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System.IO
Public Class frm_stok_pesin
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
    Friend WithEvents categoryFiþTanýmlarý As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAdres As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryVergilendirme As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAçýklama As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents sec_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rowlToplamMiktar As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlMalBedeli As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlMalIskontoTutari As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownKdvOrani1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdvMatrahi1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdv1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownKdvOrani2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdvMatrahi2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdv2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownKdvOrani3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdvMatrahi3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdv3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownKdvOrani4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdvMatrahi4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdv4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownKdvOrani5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdvMatrahi5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKdv5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlPesinat As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownVadeFarkiYuzdesi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownVadeKdvOrani As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlVadeKdvMatrahi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlVadeKdv As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlVadeFarki As DevExpress.XtraVerticalGrid.Rows.EditorRow
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
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rownGirisCikis As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_baslik_nGirisCikis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sAdres As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowsFisTipi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_tutar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents BarButtonItem33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents e_tamam As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_etiket_ara As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents e_degistir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e20 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e19 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e18 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents e17 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarButtonItem34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarButtonItem35 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem36 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem37 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem38 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem39 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem40 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem41 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem42 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colnIslemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem43 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem44 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_lTutar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rowlPuan As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents BarButtonItem45 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem46 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_Yekun As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_pesin))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.sec_lTutar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Panel_toplam = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.label2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_Yekun = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
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
        Me.rowlToplamMiktar = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlMalBedeli = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlMalIskontoTutari = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownKdvOrani1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdvMatrahi1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdv1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownKdvOrani2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdvMatrahi2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdv2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownKdvOrani3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdvMatrahi3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdv3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownKdvOrani4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdvMatrahi4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdv4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownKdvOrani5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdvMatrahi5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKdv5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDipIskonto = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rownVadeFarkiYuzdesi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownVadeKdvOrani = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlVadeKdvMatrahi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlVadeKdv = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlVadeFarki = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlPesinat = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlPuan = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowlNetTutar = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
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
        Me.rowsSubeMagaza = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryFiþTanýmlarý = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
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
        Me.categoryAçýklama = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsAciklama = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.PanelEkle = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        Me.PanelHareket = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
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
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sFiyatTipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn127 = New System.Data.DataColumn()
        Me.DataColumn130 = New System.Data.DataColumn()
        Me.collGCMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_tutar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
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
        Me.colnStokIslemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStoksKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStoksAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIslemID = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem33 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem34 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem46 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem41 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem42 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem35 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem36 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem37 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem39 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem38 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem44 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem40 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem43 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem45 = New DevExpress.XtraBars.BarButtonItem()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ds_fiyattipi = New System.Data.DataSet()
        Me.ds_nGirisCikis = New System.Data.DataSet()
        CType(Me.sec_lTutar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.ds_fiyattipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_nGirisCikis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.Caption = "Dip Ýskonto"
        Me.MultiEditorRowProperties1.FieldName = "nDipIskontoYuzdesi1"
        Me.MultiEditorRowProperties1.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.FieldName = "lDipIskontoTutari1"
        Me.MultiEditorRowProperties2.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties2.Format.FormatType = DevExpress.Utils.FormatType.Numeric
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
        'sec_lTutar
        '
        Me.sec_lTutar.AutoHeight = False
        Me.sec_lTutar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_lTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.sec_lTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lTutar.EditFormat.FormatString = "#,0.00##"
        Me.sec_lTutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lTutar.Name = "sec_lTutar"
        '
        'Panel_toplam
        '
        Me.Panel_toplam.Controls.Add(Me.GroupControl4)
        Me.Panel_toplam.Controls.Add(Me.GroupControl3)
        Me.Panel_toplam.Controls.Add(Me.GroupControl2)
        Me.Panel_toplam.Controls.Add(Me.GroupControl1)
        Me.Panel_toplam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_toplam.Location = New System.Drawing.Point(0, 417)
        Me.Panel_toplam.Name = "Panel_toplam"
        Me.Panel_toplam.Size = New System.Drawing.Size(824, 152)
        Me.Panel_toplam.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Appearance.BackColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Controls.Add(Me.label2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 49)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(379, 101)
        Me.GroupControl4.TabIndex = 22
        Me.GroupControl4.Text = "Display;"
        '
        'label2
        '
        Me.label2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label2.Location = New System.Drawing.Point(2, 15)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(8, 16)
        Me.label2.TabIndex = 19
        Me.label2.Text = "*"
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Controls.Add(Me.lbl_Yekun)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl3.Location = New System.Drawing.Point(381, 49)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(130, 101)
        Me.GroupControl3.TabIndex = 21
        Me.GroupControl3.Text = "NetTutar;"
        '
        'lbl_Yekun
        '
        Me.lbl_Yekun.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Yekun.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.lbl_Yekun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Yekun.Location = New System.Drawing.Point(2, 15)
        Me.lbl_Yekun.Name = "lbl_Yekun"
        Me.lbl_Yekun.Size = New System.Drawing.Size(9, 25)
        Me.lbl_Yekun.TabIndex = 20
        Me.lbl_Yekun.Text = "*"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(509, 47)
        Me.GroupControl2.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(7, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "*"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.VGrid_toplam)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(511, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(311, 148)
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
        Me.VGrid_toplam.CustomizationFormBounds = New System.Drawing.Rectangle(713, 194, 208, 252)
        Me.VGrid_toplam.DataMember = Nothing
        Me.VGrid_toplam.DataSource = Me.ds_toplam
        Me.VGrid_toplam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_toplam.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_toplam.Location = New System.Drawing.Point(2, 15)
        Me.VGrid_toplam.Name = "VGrid_toplam"
        Me.VGrid_toplam.OptionsBehavior.UseTabKey = False
        Me.VGrid_toplam.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_lTutar})
        Me.VGrid_toplam.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowlToplamMiktar, Me.rowlMalBedeli, Me.rowlMalIskontoTutari, Me.rownKdvOrani1, Me.rowlKdvMatrahi1, Me.rowlKdv1, Me.rownKdvOrani2, Me.rowlKdvMatrahi2, Me.rowlKdv2, Me.rownKdvOrani3, Me.rowlKdvMatrahi3, Me.rowlKdv3, Me.rownKdvOrani4, Me.rowlKdvMatrahi4, Me.rowlKdv4, Me.rownKdvOrani5, Me.rowlKdvMatrahi5, Me.rowlKdv5, Me.rowDipIskonto, Me.rownVadeFarkiYuzdesi, Me.rownVadeKdvOrani, Me.rowlVadeKdvMatrahi, Me.rowlVadeKdv, Me.rowlVadeFarki, Me.rowlPesinat, Me.rowlPuan, Me.rowlNetTutar})
        Me.VGrid_toplam.Size = New System.Drawing.Size(307, 131)
        Me.VGrid_toplam.TabIndex = 0
        Me.VGrid_toplam.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar
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
        'rowlToplamMiktar
        '
        Me.rowlToplamMiktar.Name = "rowlToplamMiktar"
        Me.rowlToplamMiktar.OptionsRow.AllowFocus = False
        Me.rowlToplamMiktar.Properties.Caption = "Toplam Miktar"
        Me.rowlToplamMiktar.Properties.FieldName = "lToplamMiktar"
        Me.rowlToplamMiktar.Properties.Format.FormatString = "#,0.####"
        Me.rowlToplamMiktar.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlToplamMiktar.Visible = False
        '
        'rowlMalBedeli
        '
        Me.rowlMalBedeli.Name = "rowlMalBedeli"
        Me.rowlMalBedeli.OptionsRow.AllowFocus = False
        Me.rowlMalBedeli.Properties.Caption = "Mal Bedeli"
        Me.rowlMalBedeli.Properties.FieldName = "lMalBedeli"
        Me.rowlMalBedeli.Properties.Format.FormatString = "#,0.00"
        Me.rowlMalBedeli.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowlMalIskontoTutari
        '
        Me.rowlMalIskontoTutari.Name = "rowlMalIskontoTutari"
        Me.rowlMalIskontoTutari.OptionsRow.AllowFocus = False
        Me.rowlMalIskontoTutari.Properties.Caption = "Mal Ýskonto Tutarý"
        Me.rowlMalIskontoTutari.Properties.FieldName = "lMalIskontoTutari"
        Me.rowlMalIskontoTutari.Properties.Format.FormatString = "#,0.00"
        Me.rowlMalIskontoTutari.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rownKdvOrani1
        '
        Me.rownKdvOrani1.Name = "rownKdvOrani1"
        Me.rownKdvOrani1.Properties.Caption = "Kdv Oraný 1"
        Me.rownKdvOrani1.Properties.FieldName = "nKdvOrani1"
        Me.rownKdvOrani1.Properties.Format.FormatString = "#,0.00"
        Me.rownKdvOrani1.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rownKdvOrani1.Properties.ReadOnly = True
        Me.rownKdvOrani1.Visible = False
        '
        'rowlKdvMatrahi1
        '
        Me.rowlKdvMatrahi1.Name = "rowlKdvMatrahi1"
        Me.rowlKdvMatrahi1.Properties.Caption = "Kdv Matrahý 1"
        Me.rowlKdvMatrahi1.Properties.FieldName = "lKdvMatrahi1"
        Me.rowlKdvMatrahi1.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdvMatrahi1.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdvMatrahi1.Properties.ReadOnly = True
        Me.rowlKdvMatrahi1.Visible = False
        '
        'rowlKdv1
        '
        Me.rowlKdv1.Name = "rowlKdv1"
        Me.rowlKdv1.Properties.Caption = "Kdv1"
        Me.rowlKdv1.Properties.FieldName = "lKdv1"
        Me.rowlKdv1.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdv1.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdv1.Properties.ReadOnly = True
        Me.rowlKdv1.Visible = False
        '
        'rownKdvOrani2
        '
        Me.rownKdvOrani2.Name = "rownKdvOrani2"
        Me.rownKdvOrani2.Properties.Caption = "Kdv Oraný 2"
        Me.rownKdvOrani2.Properties.FieldName = "nKdvOrani2"
        Me.rownKdvOrani2.Properties.Format.FormatString = "#,0.00"
        Me.rownKdvOrani2.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rownKdvOrani2.Properties.ReadOnly = True
        Me.rownKdvOrani2.Visible = False
        '
        'rowlKdvMatrahi2
        '
        Me.rowlKdvMatrahi2.Name = "rowlKdvMatrahi2"
        Me.rowlKdvMatrahi2.Properties.Caption = "Kdv Matrahý 2"
        Me.rowlKdvMatrahi2.Properties.FieldName = "lKdvMatrahi2"
        Me.rowlKdvMatrahi2.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdvMatrahi2.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdvMatrahi2.Properties.ReadOnly = True
        Me.rowlKdvMatrahi2.Visible = False
        '
        'rowlKdv2
        '
        Me.rowlKdv2.Name = "rowlKdv2"
        Me.rowlKdv2.Properties.Caption = "Kdv2"
        Me.rowlKdv2.Properties.FieldName = "lKdv2"
        Me.rowlKdv2.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdv2.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdv2.Properties.ReadOnly = True
        Me.rowlKdv2.Visible = False
        '
        'rownKdvOrani3
        '
        Me.rownKdvOrani3.Name = "rownKdvOrani3"
        Me.rownKdvOrani3.Properties.Caption = "Kdv Oraný 3"
        Me.rownKdvOrani3.Properties.FieldName = "nKdvOrani3"
        Me.rownKdvOrani3.Properties.Format.FormatString = "#,0.00"
        Me.rownKdvOrani3.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rownKdvOrani3.Properties.ReadOnly = True
        Me.rownKdvOrani3.Visible = False
        '
        'rowlKdvMatrahi3
        '
        Me.rowlKdvMatrahi3.Name = "rowlKdvMatrahi3"
        Me.rowlKdvMatrahi3.Properties.Caption = "Kdv Matrahý 3"
        Me.rowlKdvMatrahi3.Properties.FieldName = "lKdvMatrahi3"
        Me.rowlKdvMatrahi3.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdvMatrahi3.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdvMatrahi3.Properties.ReadOnly = True
        Me.rowlKdvMatrahi3.Visible = False
        '
        'rowlKdv3
        '
        Me.rowlKdv3.Name = "rowlKdv3"
        Me.rowlKdv3.Properties.Caption = "Kdv3"
        Me.rowlKdv3.Properties.FieldName = "lKdv3"
        Me.rowlKdv3.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdv3.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdv3.Properties.ReadOnly = True
        Me.rowlKdv3.Visible = False
        '
        'rownKdvOrani4
        '
        Me.rownKdvOrani4.Name = "rownKdvOrani4"
        Me.rownKdvOrani4.Properties.Caption = "Kdv Oraný 4"
        Me.rownKdvOrani4.Properties.FieldName = "nKdvOrani4"
        Me.rownKdvOrani4.Properties.Format.FormatString = "#,0.00"
        Me.rownKdvOrani4.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rownKdvOrani4.Properties.ReadOnly = True
        Me.rownKdvOrani4.Visible = False
        '
        'rowlKdvMatrahi4
        '
        Me.rowlKdvMatrahi4.Name = "rowlKdvMatrahi4"
        Me.rowlKdvMatrahi4.Properties.Caption = "Kdv Matrahý 4"
        Me.rowlKdvMatrahi4.Properties.FieldName = "lKdvMatrahi4"
        Me.rowlKdvMatrahi4.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdvMatrahi4.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdvMatrahi4.Properties.ReadOnly = True
        Me.rowlKdvMatrahi4.Visible = False
        '
        'rowlKdv4
        '
        Me.rowlKdv4.Name = "rowlKdv4"
        Me.rowlKdv4.Properties.Caption = "Kdv4"
        Me.rowlKdv4.Properties.FieldName = "lKdv4"
        Me.rowlKdv4.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdv4.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdv4.Properties.ReadOnly = True
        Me.rowlKdv4.Visible = False
        '
        'rownKdvOrani5
        '
        Me.rownKdvOrani5.Name = "rownKdvOrani5"
        Me.rownKdvOrani5.Properties.Caption = "Kdv Oraný 5"
        Me.rownKdvOrani5.Properties.FieldName = "nKdvOrani5"
        Me.rownKdvOrani5.Properties.Format.FormatString = "#,0.00"
        Me.rownKdvOrani5.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rownKdvOrani5.Properties.ReadOnly = True
        Me.rownKdvOrani5.Visible = False
        '
        'rowlKdvMatrahi5
        '
        Me.rowlKdvMatrahi5.Name = "rowlKdvMatrahi5"
        Me.rowlKdvMatrahi5.Properties.Caption = "Kdv Matrahý 5"
        Me.rowlKdvMatrahi5.Properties.FieldName = "lKdvMatrahi5"
        Me.rowlKdvMatrahi5.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdvMatrahi5.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdvMatrahi5.Properties.ReadOnly = True
        Me.rowlKdvMatrahi5.Visible = False
        '
        'rowlKdv5
        '
        Me.rowlKdv5.Name = "rowlKdv5"
        Me.rowlKdv5.Properties.Caption = "Kdv5"
        Me.rowlKdv5.Properties.FieldName = "lKdv5"
        Me.rowlKdv5.Properties.Format.FormatString = "#,0.00"
        Me.rowlKdv5.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlKdv5.Properties.ReadOnly = True
        Me.rowlKdv5.Visible = False
        '
        'rowDipIskonto
        '
        Me.rowDipIskonto.Name = "rowDipIskonto"
        Me.rowDipIskonto.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties1, Me.MultiEditorRowProperties2})
        '
        'rownVadeFarkiYuzdesi
        '
        Me.rownVadeFarkiYuzdesi.Name = "rownVadeFarkiYuzdesi"
        Me.rownVadeFarkiYuzdesi.Properties.Caption = "VadeFarkiYuzdesi"
        Me.rownVadeFarkiYuzdesi.Properties.FieldName = "nVadeFarkiYuzdesi"
        Me.rownVadeFarkiYuzdesi.Properties.Format.FormatString = "#,0.00"
        Me.rownVadeFarkiYuzdesi.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rownVadeFarkiYuzdesi.Properties.ReadOnly = True
        Me.rownVadeFarkiYuzdesi.Visible = False
        '
        'rownVadeKdvOrani
        '
        Me.rownVadeKdvOrani.Name = "rownVadeKdvOrani"
        Me.rownVadeKdvOrani.Properties.Caption = "VadeKdvOrani"
        Me.rownVadeKdvOrani.Properties.FieldName = "nVadeKdvOrani"
        Me.rownVadeKdvOrani.Properties.Format.FormatString = "#,0.00"
        Me.rownVadeKdvOrani.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rownVadeKdvOrani.Properties.ReadOnly = True
        Me.rownVadeKdvOrani.Visible = False
        '
        'rowlVadeKdvMatrahi
        '
        Me.rowlVadeKdvMatrahi.Name = "rowlVadeKdvMatrahi"
        Me.rowlVadeKdvMatrahi.Properties.Caption = "VadeKdvMatrahi"
        Me.rowlVadeKdvMatrahi.Properties.FieldName = "lVadeKdvMatrahi"
        Me.rowlVadeKdvMatrahi.Properties.Format.FormatString = "#,0.00"
        Me.rowlVadeKdvMatrahi.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlVadeKdvMatrahi.Properties.ReadOnly = True
        Me.rowlVadeKdvMatrahi.Visible = False
        '
        'rowlVadeKdv
        '
        Me.rowlVadeKdv.Name = "rowlVadeKdv"
        Me.rowlVadeKdv.Properties.Caption = "VadeKdv"
        Me.rowlVadeKdv.Properties.FieldName = "lVadeKdv"
        Me.rowlVadeKdv.Properties.Format.FormatString = "#,0.00"
        Me.rowlVadeKdv.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlVadeKdv.Properties.ReadOnly = True
        Me.rowlVadeKdv.Visible = False
        '
        'rowlVadeFarki
        '
        Me.rowlVadeFarki.Name = "rowlVadeFarki"
        Me.rowlVadeFarki.Properties.Caption = "VadeFarki"
        Me.rowlVadeFarki.Properties.FieldName = "lVadeFarki"
        Me.rowlVadeFarki.Properties.Format.FormatString = "#,0.00"
        Me.rowlVadeFarki.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlVadeFarki.Properties.ReadOnly = True
        Me.rowlVadeFarki.Visible = False
        '
        'rowlPesinat
        '
        Me.rowlPesinat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.rowlPesinat.Appearance.Options.UseForeColor = True
        Me.rowlPesinat.Name = "rowlPesinat"
        Me.rowlPesinat.OptionsRow.AllowFocus = False
        Me.rowlPesinat.Properties.Caption = "Peþinat"
        Me.rowlPesinat.Properties.FieldName = "lPesinat"
        Me.rowlPesinat.Properties.Format.FormatString = "#,0.00"
        Me.rowlPesinat.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowlPuan
        '
        Me.rowlPuan.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.rowlPuan.Appearance.Options.UseForeColor = True
        Me.rowlPuan.Name = "rowlPuan"
        Me.rowlPuan.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties3, Me.MultiEditorRowProperties4})
        '
        'rowlNetTutar
        '
        Me.rowlNetTutar.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowlNetTutar.Appearance.Options.UseForeColor = True
        Me.rowlNetTutar.Name = "rowlNetTutar"
        Me.rowlNetTutar.OptionsRow.AllowFocus = False
        Me.rowlNetTutar.Properties.Caption = "Net Tutar"
        Me.rowlNetTutar.Properties.FieldName = "lNetTutar"
        Me.rowlNetTutar.Properties.Format.FormatString = "#,0.00"
        Me.rowlNetTutar.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PanelBaslik
        '
        Me.PanelBaslik.Controls.Add(Me.VGrid_baslik)
        Me.PanelBaslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBaslik.Location = New System.Drawing.Point(0, 22)
        Me.PanelBaslik.Name = "PanelBaslik"
        Me.PanelBaslik.Size = New System.Drawing.Size(824, 195)
        Me.PanelBaslik.TabIndex = 1
        '
        'VGrid_baslik
        '
        Me.VGrid_baslik.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(806, 406, 208, 252)
        Me.VGrid_baslik.DataMember = Nothing
        Me.VGrid_baslik.DataSource = Me.ds_adres
        Me.VGrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_baslik.Name = "VGrid_baslik"
        Me.VGrid_baslik.OptionsBehavior.UseTabKey = False
        Me.VGrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_aciklama, Me.sec_baslik_nGirisCikis, Me.sec_sAdres})
        Me.VGrid_baslik.RowHeaderWidth = 134
        Me.VGrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsSubeMagaza, Me.categoryFiþTanýmlarý, Me.categoryAdres, Me.categoryVergilendirme, Me.categoryAçýklama})
        Me.VGrid_baslik.Size = New System.Drawing.Size(820, 191)
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
        'rowsSubeMagaza
        '
        Me.rowsSubeMagaza.Name = "rowsSubeMagaza"
        Me.rowsSubeMagaza.Properties.Caption = "SubeMagaza"
        Me.rowsSubeMagaza.Properties.FieldName = "sSubeMagaza"
        Me.rowsSubeMagaza.Properties.ReadOnly = True
        Me.rowsSubeMagaza.Visible = False
        '
        'categoryFiþTanýmlarý
        '
        Me.categoryFiþTanýmlarý.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownAlisVerisID, Me.rowdteFaturaTarihi, Me.rowsFisTipi, Me.rownGirisCikis, Me.rowlFaturaNo, Me.rownMusteriID, Me.rowsAdi, Me.rowsSoyadi, Me.rowMusteri})
        Me.categoryFiþTanýmlarý.Name = "categoryFiþTanýmlarý"
        Me.categoryFiþTanýmlarý.Properties.Caption = "FiþTanýmlarý"
        '
        'rownAlisVerisID
        '
        Me.rownAlisVerisID.Name = "rownAlisVerisID"
        Me.rownAlisVerisID.Properties.Caption = "Kayýt No"
        Me.rownAlisVerisID.Properties.FieldName = "nAlisverisID"
        Me.rownAlisVerisID.Properties.ReadOnly = True
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
        Me.rownMusteriID.Properties.Caption = "Müþteri No"
        Me.rownMusteriID.Properties.FieldName = "lKodu"
        Me.rownMusteriID.Properties.ReadOnly = True
        '
        'rowsAdi
        '
        Me.rowsAdi.Height = 16
        Me.rowsAdi.Name = "rowsAdi"
        Me.rowsAdi.Properties.Caption = "Adý"
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
        'categoryAçýklama
        '
        Me.categoryAçýklama.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsAciklama})
        Me.categoryAçýklama.Name = "categoryAçýklama"
        Me.categoryAçýklama.Properties.Caption = "Açýklama"
        '
        'rowsAciklama
        '
        Me.rowsAciklama.Height = 92
        Me.rowsAciklama.Name = "rowsAciklama"
        Me.rowsAciklama.Properties.Caption = "Açýklama"
        Me.rowsAciklama.Properties.FieldName = "sAciklama"
        Me.rowsAciklama.Properties.RowEdit = Me.sec_aciklama
        '
        'PanelEkle
        '
        Me.PanelEkle.Controls.Add(Me.Label3)
        Me.PanelEkle.Controls.Add(Me.Label4)
        Me.PanelEkle.Controls.Add(Me.sec_kriter)
        Me.PanelEkle.Controls.Add(Me.txt_ara)
        Me.PanelEkle.Controls.Add(Me.lbl_ara)
        Me.PanelEkle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEkle.Location = New System.Drawing.Point(0, 393)
        Me.PanelEkle.Name = "PanelEkle"
        Me.PanelEkle.Size = New System.Drawing.Size(824, 24)
        Me.PanelEkle.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Okut="
        '
        'Label4
        '
        Me.Label4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(362, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(7, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "*"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.Location = New System.Drawing.Point(280, 2)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        ToolTipTitleItem1.Text = "Arama Kriteri Belirle"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = resources.GetString("ToolTipItem1.Text")
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.sec_kriter.SuperTip = SuperToolTip1
        Me.sec_kriter.TabIndex = 15
        '
        'txt_ara
        '
        Me.txt_ara.Location = New System.Drawing.Point(75, 2)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Silver
        Me.txt_ara.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Red
        Me.txt_ara.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ara.Properties.MaxLength = 30
        Me.txt_ara.Size = New System.Drawing.Size(198, 20)
        ToolTipTitleItem2.Text = "Otomatik Stok Sorgulama"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = resources.GetString("ToolTipItem2.Text")
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txt_ara.SuperTip = SuperToolTip2
        Me.txt_ara.TabIndex = 14
        '
        'lbl_ara
        '
        Me.lbl_ara.Location = New System.Drawing.Point(47, 2)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(6, 13)
        Me.lbl_ara.TabIndex = 13
        Me.lbl_ara.Text = "*"
        '
        'PanelHareket
        '
        Me.PanelHareket.Controls.Add(Me.GridControl1)
        Me.PanelHareket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelHareket.Location = New System.Drawing.Point(0, 217)
        Me.PanelHareket.Name = "PanelHareket"
        Me.PanelHareket.Size = New System.Drawing.Size(824, 176)
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 172)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem5, Me.MenuItem7, Me.MenuItem4, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Satýr Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Satýr Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Satýr Sil"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlM
        Me.MenuItem7.Text = "Miktar Hesapla"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.Ctrl9
        Me.MenuItem4.Text = "Deðer Yay"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "Ara"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnAlisverisID, Me.colsMagazaKodu, Me.colnSiparisID, Me.colnGirisCikis, Me.colnStokID, Me.colsKasiyerRumuzu, Me.colsSaticiRumuzu, Me.colsOdemeKodu, Me.collReyonFisNo, Me.colsFiyatTipi, Me.collGCMiktar, Me.collBrutFiyat, Me.collBrutTutar, Me.colnIskontoYuzdesi, Me.collIskontoTutari, Me.collFiyat, Me.collTutar, Me.colnKdvOrani, Me.colsIadeNedeni, Me.colnPartiID, Me.coldteTeslimEdilecek, Me.coldteTeslimEdilen, Me.colbTeslimEdildi, Me.colbMuhasebeyeIslendimi, Me.colsAciklama, Me.colbEkSoru, Me.colbEkAlan1, Me.colbEkAlan2, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsSonKullaniciAdi, Me.coldteSonUpdateTarihi, Me.colnStokIslemID, Me.coldteOnayTarihi, Me.colnStoksKodu, Me.colnStoksAciklama, Me.colsRenk, Me.colsBeden, Me.colnIslemID})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(361, 243, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "[Yeni Satýr]"
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
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "AlýþVeriþ No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        Me.colnAlisverisID.OptionsColumn.AllowEdit = False
        Me.colnAlisverisID.OptionsColumn.AllowFocus = False
        '
        'colsMagazaKodu
        '
        Me.colsMagazaKodu.Caption = "Maðaza"
        Me.colsMagazaKodu.FieldName = "sDepo"
        Me.colsMagazaKodu.Name = "colsMagazaKodu"
        Me.colsMagazaKodu.OptionsColumn.AllowEdit = False
        Me.colsMagazaKodu.OptionsColumn.AllowFocus = False
        '
        'colnSiparisID
        '
        Me.colnSiparisID.Caption = "Sipariþ No"
        Me.colnSiparisID.FieldName = "nSiparisID"
        Me.colnSiparisID.Name = "colnSiparisID"
        Me.colnSiparisID.OptionsColumn.AllowEdit = False
        Me.colnSiparisID.OptionsColumn.AllowFocus = False
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colnGirisCikis.AppearanceCell.Options.UseBackColor = True
        Me.colnGirisCikis.Caption = "SatýrTipi"
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
        Me.sec_nGirisCikis.NullText = "[SatýrTipi]"
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
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.OptionsColumn.AllowEdit = False
        Me.colsKasiyerRumuzu.OptionsColumn.AllowFocus = False
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satýcý"
        Me.colsSaticiRumuzu.ColumnEdit = Me.sec_sSatici
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        Me.colsSaticiRumuzu.Visible = True
        Me.colsSaticiRumuzu.VisibleIndex = 5
        Me.colsSaticiRumuzu.Width = 62
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
        'colsOdemeKodu
        '
        Me.colsOdemeKodu.Caption = "Ödeme"
        Me.colsOdemeKodu.ColumnEdit = Me.sec_sOdemeKodu
        Me.colsOdemeKodu.FieldName = "sOdemeKodu"
        Me.colsOdemeKodu.Name = "colsOdemeKodu"
        Me.colsOdemeKodu.Width = 55
        '
        'sec_sOdemeKodu
        '
        Me.sec_sOdemeKodu.AutoHeight = False
        Me.sec_sOdemeKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sOdemeKodu.DisplayMember = "sOdemeKodu"
        Me.sec_sOdemeKodu.Name = "sec_sOdemeKodu"
        Me.sec_sOdemeKodu.ValueMember = "sOdemeKodu"
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
        Me.colsFiyatTipi.ColumnEdit = Me.sec_sFiyatTipi
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
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
        Me.collGCMiktar.Width = 57
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
        Me.collBrutFiyat.VisibleIndex = 3
        Me.collBrutFiyat.Width = 63
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
        Me.collBrutTutar.VisibleIndex = 4
        Me.collBrutTutar.Width = 65
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colnIskontoYuzdesi.AppearanceCell.Options.UseForeColor = True
        Me.colnIskontoYuzdesi.Caption = "Isk1%"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatString = "#,#.##"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Visible = True
        Me.colnIskontoYuzdesi.VisibleIndex = 6
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
        Me.collIskontoTutari.Visible = True
        Me.collIskontoTutari.VisibleIndex = 7
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
        Me.coldteTeslimEdilen.OptionsColumn.AllowEdit = False
        Me.coldteTeslimEdilen.OptionsColumn.AllowFocus = False
        '
        'colbTeslimEdildi
        '
        Me.colbTeslimEdildi.Caption = "TeslimEdildi?"
        Me.colbTeslimEdildi.FieldName = "bTeslimEdildi"
        Me.colbTeslimEdildi.Name = "colbTeslimEdildi"
        Me.colbTeslimEdildi.OptionsColumn.AllowEdit = False
        Me.colbTeslimEdildi.OptionsColumn.AllowFocus = False
        '
        'colbMuhasebeyeIslendimi
        '
        Me.colbMuhasebeyeIslendimi.Caption = "Muhasebeye Ýþlendimi?"
        Me.colbMuhasebeyeIslendimi.FieldName = "bMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.Name = "colbMuhasebeyeIslendimi"
        Me.colbMuhasebeyeIslendimi.OptionsColumn.AllowEdit = False
        Me.colbMuhasebeyeIslendimi.OptionsColumn.AllowFocus = False
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
        Me.colbEkSoru.OptionsColumn.AllowEdit = False
        Me.colbEkSoru.OptionsColumn.AllowFocus = False
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
        Me.collDovizMiktari1.Caption = "Döviz Miktarý 1"
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
        Me.colsSonKullaniciAdi.Caption = "Son Kullanýcý Adý"
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
        'colnStokIslemID
        '
        Me.colnStokIslemID.Caption = "StokIslemID"
        Me.colnStokIslemID.FieldName = "nStokIslemID"
        Me.colnStokIslemID.Name = "colnStokIslemID"
        Me.colnStokIslemID.OptionsColumn.AllowEdit = False
        Me.colnStokIslemID.OptionsColumn.AllowFocus = False
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
        Me.colnStoksKodu.Width = 68
        '
        'colnStoksAciklama
        '
        Me.colnStoksAciklama.Caption = "Stok Adý"
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
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.OptionsColumn.AllowEdit = False
        Me.colsBeden.OptionsColumn.AllowFocus = False
        '
        'colnIslemID
        '
        Me.colnIslemID.Caption = "Kayýt No"
        Me.colnIslemID.FieldName = "nIslemID"
        Me.colnIslemID.Name = "colnIslemID"
        Me.colnIslemID.OptionsColumn.AllowEdit = False
        Me.colnIslemID.OptionsColumn.AllowFocus = False
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn65})
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarSubItem5, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarSubItem6, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.BarButtonItem32, Me.BarButtonItem33, Me.BarButtonItem34, Me.BarButtonItem41, Me.BarButtonItem42, Me.BarButtonItem35, Me.BarButtonItem36, Me.BarButtonItem37, Me.BarButtonItem38, Me.BarButtonItem39, Me.BarButtonItem40, Me.BarButtonItem43, Me.BarButtonItem44, Me.BarButtonItem45, Me.BarButtonItem46})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 52
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Yeni Fiþ"
        Me.BarButtonItem26.Enabled = False
        Me.BarButtonItem26.Id = 31
        Me.BarButtonItem26.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Müþteri Deðiþtir"
        Me.BarButtonItem27.Id = 32
        Me.BarButtonItem27.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5))
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Belge Önizle"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Belge Dizayn"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Belge Yazdýr"
        Me.BarButtonItem3.Id = 6
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Belgeyi Ýptal Et"
        Me.BarButtonItem4.Id = 7
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Çýkýþ"
        Me.BarButtonItem5.Id = 8
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Satýr"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19, True)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Satýr Ekle"
        Me.BarButtonItem6.Id = 9
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Satýr Düzenle"
        Me.BarButtonItem7.Id = 10
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Satýr Sil"
        Me.BarButtonItem8.Id = 11
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Hesap Makinasý"
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Araçlar"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem32), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem31), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem33), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem34)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Hesap Kapatma"
        Me.BarButtonItem17.Id = 22
        Me.BarButtonItem17.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Müþteri Kartý"
        Me.BarButtonItem22.Id = 27
        Me.BarButtonItem22.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Stok Kartý"
        Me.BarButtonItem23.Id = 28
        Me.BarButtonItem23.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Stok Fiyatlandýr"
        Me.BarButtonItem24.Id = 29
        Me.BarButtonItem24.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Barkod Okut"
        Me.BarButtonItem25.Id = 30
        Me.BarButtonItem25.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Fiyat Gör"
        Me.BarButtonItem28.Id = 33
        Me.BarButtonItem28.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Alt Toplamlar"
        Me.BarButtonItem32.Id = 37
        Me.BarButtonItem32.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Tutara Göre Miktar Hesapla"
        Me.BarButtonItem29.Id = 34
        Me.BarButtonItem29.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M))
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Satýcý Belirle"
        Me.BarButtonItem30.Id = 35
        Me.BarButtonItem30.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "FiyatTipi Belirle"
        Me.BarButtonItem31.Id = 36
        Me.BarButtonItem31.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarButtonItem33
        '
        Me.BarButtonItem33.Caption = "Etiket Tuslarý Göster"
        Me.BarButtonItem33.Id = 38
        Me.BarButtonItem33.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
        Me.BarButtonItem33.Name = "BarButtonItem33"
        '
        'BarButtonItem34
        '
        Me.BarButtonItem34.Caption = "Cariden Adres Al"
        Me.BarButtonItem34.Id = 39
        Me.BarButtonItem34.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
        Me.BarButtonItem34.Name = "BarButtonItem34"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Görünüm"
        Me.BarSubItem6.Id = 16
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18, True)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Baþlýk"
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
        Me.BarSubItem4.Caption = "Ekran"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21, True)})
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
        Me.BarButtonItem15.Caption = "Stok Adý"
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
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Stok Kartý"
        Me.BarButtonItem20.Id = 25
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Satýþlar"
        Me.BarButtonItem21.Id = 26
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Ekran"
        Me.BarSubItem5.Id = 13
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
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem46, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem41, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem42, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem35, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem36, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem37, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem39, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem38, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem44, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem40, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem43, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem45, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'BarButtonItem46
        '
        Me.BarButtonItem46.Caption = "SatirEkle"
        Me.BarButtonItem46.Id = 51
        Me.BarButtonItem46.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem46.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem46.Name = "BarButtonItem46"
        ToolTipTitleItem3.Text = "Yeni Stok Satiri Ekle"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Stoklardan Secerek Satis Yapmak icin Kullanýlýr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem4.LeftIndent = 6
        ToolTipTitleItem4.Text = "Insert"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip3.Items.Add(ToolTipTitleItem4)
        Me.BarButtonItem46.SuperTip = SuperToolTip3
        '
        'BarButtonItem41
        '
        Me.BarButtonItem41.Caption = "Satýr Sil"
        Me.BarButtonItem41.Hint = "Satir Sil,Ctrl+Del"
        Me.BarButtonItem41.Id = 16
        Me.BarButtonItem41.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem41.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem41.Name = "BarButtonItem41"
        ToolTipTitleItem5.Text = "Satýrý Sil"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Satistaki secili satir kaydini silmek icin kullanilir... " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem6.LeftIndent = 6
        ToolTipTitleItem6.Text = "Ctrl+Delete"
        SuperToolTip4.Items.Add(ToolTipTitleItem5)
        SuperToolTip4.Items.Add(ToolTipItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip4.Items.Add(ToolTipTitleItem6)
        Me.BarButtonItem41.SuperTip = SuperToolTip4
        '
        'BarButtonItem42
        '
        Me.BarButtonItem42.Caption = "Fis Sil"
        Me.BarButtonItem42.Id = 17
        Me.BarButtonItem42.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem42.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem42.Name = "BarButtonItem42"
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
        Me.BarButtonItem42.SuperTip = SuperToolTip5
        '
        'BarButtonItem35
        '
        Me.BarButtonItem35.Caption = "Yeni Fis"
        Me.BarButtonItem35.Id = 40
        Me.BarButtonItem35.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem35.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem35.Name = "BarButtonItem35"
        ToolTipTitleItem9.Text = "Yeni Fis"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Belgeyi Kaydedip Yeni Pesin Satis Fisi Açmak icin kullanilir. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem10.LeftIndent = 6
        ToolTipTitleItem10.Text = "F3"
        SuperToolTip6.Items.Add(ToolTipTitleItem9)
        SuperToolTip6.Items.Add(ToolTipItem6)
        SuperToolTip6.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip6.Items.Add(ToolTipTitleItem10)
        Me.BarButtonItem35.SuperTip = SuperToolTip6
        '
        'BarButtonItem36
        '
        Me.BarButtonItem36.Caption = "Hesap Kapat"
        Me.BarButtonItem36.Id = 41
        Me.BarButtonItem36.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem36.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem36.Name = "BarButtonItem36"
        ToolTipTitleItem11.Text = "Ödeme Al"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Yapilan Satis Islemi Karsiliginda Alinan Pesinatlar veya Taksitlendirmeler bu böl" &
    "ümden Yapýlýr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem12.LeftIndent = 6
        ToolTipTitleItem12.Text = "F9"
        SuperToolTip7.Items.Add(ToolTipTitleItem11)
        SuperToolTip7.Items.Add(ToolTipItem7)
        SuperToolTip7.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip7.Items.Add(ToolTipTitleItem12)
        Me.BarButtonItem36.SuperTip = SuperToolTip7
        '
        'BarButtonItem37
        '
        Me.BarButtonItem37.Caption = "Yazdýr"
        Me.BarButtonItem37.Id = 42
        Me.BarButtonItem37.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem37.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem37.Name = "BarButtonItem37"
        ToolTipTitleItem13.Text = "Fis Yazdir"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Satis isleminin Fis Türünden Ciktisini Almak icin kullanilir." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipTitleItem14.LeftIndent = 6
        ToolTipTitleItem14.Text = "F2"
        SuperToolTip8.Items.Add(ToolTipTitleItem13)
        SuperToolTip8.Items.Add(ToolTipItem8)
        SuperToolTip8.Items.Add(ToolTipSeparatorItem6)
        SuperToolTip8.Items.Add(ToolTipTitleItem14)
        Me.BarButtonItem37.SuperTip = SuperToolTip8
        '
        'BarButtonItem39
        '
        Me.BarButtonItem39.Caption = "Fatura Yazdýr"
        Me.BarButtonItem39.Id = 44
        Me.BarButtonItem39.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem39.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem39.Name = "BarButtonItem39"
        ToolTipTitleItem15.Text = "Fatura Yazdýr"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Satis isleminin Fatura Türünden Ciktisini Almak icin kullanilir."
        SuperToolTip9.Items.Add(ToolTipTitleItem15)
        SuperToolTip9.Items.Add(ToolTipItem9)
        Me.BarButtonItem39.SuperTip = SuperToolTip9
        '
        'BarButtonItem38
        '
        Me.BarButtonItem38.Caption = "Sanal Klavye"
        Me.BarButtonItem38.Id = 43
        Me.BarButtonItem38.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem38.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem38.Name = "BarButtonItem38"
        ToolTipTitleItem16.Text = "Sanal Klavye"
        ToolTipItem10.LeftIndent = 6
        ToolTipItem10.Text = "Dokunmatik Pc/Monitörler icin Sanal Ekran Klavyesini calistirir."
        SuperToolTip10.Items.Add(ToolTipTitleItem16)
        SuperToolTip10.Items.Add(ToolTipItem10)
        Me.BarButtonItem38.SuperTip = SuperToolTip10
        '
        'BarButtonItem44
        '
        Me.BarButtonItem44.Caption = "Musteri Sec"
        Me.BarButtonItem44.Id = 49
        Me.BarButtonItem44.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem44.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem44.Name = "BarButtonItem44"
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
        Me.BarButtonItem44.SuperTip = SuperToolTip11
        '
        'BarButtonItem40
        '
        Me.BarButtonItem40.Caption = "Yeni Musteri"
        Me.BarButtonItem40.Hint = "Yeni Musteri Kaydetmek"
        Me.BarButtonItem40.Id = 45
        Me.BarButtonItem40.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem40.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem40.Name = "BarButtonItem40"
        ToolTipTitleItem19.Text = "Yeni Musteri"
        ToolTipItem12.LeftIndent = 6
        ToolTipItem12.Text = "Yeni Musteri Kaydi Acilir, Istenirse Satis islemi acilan yeni hesaba Aktarilabili" &
    "r."
        SuperToolTip12.Items.Add(ToolTipTitleItem19)
        SuperToolTip12.Items.Add(ToolTipItem12)
        Me.BarButtonItem40.SuperTip = SuperToolTip12
        '
        'BarButtonItem43
        '
        Me.BarButtonItem43.Caption = "Puan"
        Me.BarButtonItem43.Hint = "Satisa Puan Vermek veya Satistan Puan Dusmek icin..."
        Me.BarButtonItem43.Id = 48
        Me.BarButtonItem43.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem43.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem43.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem43.Name = "BarButtonItem43"
        ToolTipTitleItem20.Text = "Puan"
        ToolTipItem13.LeftIndent = 6
        ToolTipItem13.Text = "Satis Tutarindan Oransal veya Tutarsal Bazli Musteriye Puan veya Hediye Ceki veri" &
    "lebilir. Istenirse Musteri Puan/Hediye Ceki Kullanarak Satis kapatýlabilir..."
        ToolTipTitleItem21.LeftIndent = 6
        ToolTipTitleItem21.Text = "Alt+P"
        SuperToolTip13.Items.Add(ToolTipTitleItem20)
        SuperToolTip13.Items.Add(ToolTipItem13)
        SuperToolTip13.Items.Add(ToolTipSeparatorItem8)
        SuperToolTip13.Items.Add(ToolTipTitleItem21)
        Me.BarButtonItem43.SuperTip = SuperToolTip13
        '
        'BarButtonItem45
        '
        Me.BarButtonItem45.Caption = "Yuvarla"
        Me.BarButtonItem45.Hint = "Satis Tutarinda Yuvarlama Yapmak/Otomatik Alt Iskonto Uygulamak icin"
        Me.BarButtonItem45.Id = 50
        Me.BarButtonItem45.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem45.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem45.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem45.Name = "BarButtonItem45"
        ToolTipTitleItem22.Text = "Tutar Yuvarla"
        ToolTipItem14.LeftIndent = 6
        ToolTipItem14.Text = "Satis Tutarinda Yuvarlama Yapmak veya Otomatik Iskonto Uygulamak icin kullanilir." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gelen Ekranda Net Satis Rakamý girildiðinde program otomatik olarak Net Satis " &
    "Tutari ni ayarlayacaktýr."
        ToolTipTitleItem23.LeftIndent = 6
        ToolTipTitleItem23.Text = "Alt+Y"
        SuperToolTip14.Items.Add(ToolTipTitleItem22)
        SuperToolTip14.Items.Add(ToolTipItem14)
        SuperToolTip14.Items.Add(ToolTipSeparatorItem9)
        SuperToolTip14.Items.Add(ToolTipTitleItem23)
        Me.BarButtonItem45.SuperTip = SuperToolTip14
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 569)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 547)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 547)
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
        Me.txt_etiket_ara.Size = New System.Drawing.Size(154, 20)
        Me.txt_etiket_ara.TabIndex = 20
        '
        'e_degistir
        '
        Me.e_degistir.Image = CType(resources.GetObject("e_degistir.Image"), System.Drawing.Image)
        Me.e_degistir.Location = New System.Drawing.Point(254, 299)
        Me.e_degistir.Name = "e_degistir"
        Me.e_degistir.Size = New System.Drawing.Size(74, 22)
        Me.e_degistir.TabIndex = 22
        Me.e_degistir.Text = "&Degistir"
        '
        'e_tamam
        '
        Me.e_tamam.Image = CType(resources.GetObject("e_tamam.Image"), System.Drawing.Image)
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
        'frm_stok_pesin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 591)
        Me.Controls.Add(Me.PanelHareket)
        Me.Controls.Add(Me.PanelEkle)
        Me.Controls.Add(Me.PanelBaslik)
        Me.Controls.Add(Me.Panel_toplam)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_pesin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perakende Satýþ"
        CType(Me.sec_lTutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplam.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
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
        CType(Me.sec_sFiyatTipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ds_fiyattipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_nGirisCikis, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim e_nMusteriID
    Dim e_sAdi
    Dim e_sSoyadi
    Dim e_sAdres1 = ""
    Dim e_sAdres2 = ""
    Dim dr As DataRow
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter

    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    Dim dr_toplam As DataRow
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
    Dim yuklendi As Boolean = False
    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Public sFiyatTipi = ""
    Dim sSaticiRumuzu = ""
    Dim sOdemeKodu = ""
    Dim bkapat As Boolean = False
    Dim info As Boolean = True
    Dim mevcut As Decimal = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Dim bCalcVadeDagilim As Boolean = False
    Public bIptalYapabilirmi As Boolean = False
    Public bVadeFarksizOdemeAlirmi As Boolean = False
    Public nMaxIskontoYuzdesi As Decimal = 100
    Dim islem As Integer = 0
    Private Sub frm_stok_pesin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub frm_stok_pesin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                tbAlisVerisSiparis_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), 0)
            Else
                tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lHarcananPuan"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), 0)
            End If
        Catch ex As Exception
        End Try
        If bkapat = False Then
            If FormatNumber(sorgu_sayi(dr_toplam("lNetTutar"), 0), 2) <> FormatNumber(sorgu_Kapatma_lTutari(dr_baslik("nAlisVerisID"), sorgu_sayi(dr_toplam("lNetTutar"), 0)), 2) Then
                e.Cancel = True
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Tutarý ile Kapatma Tutarýnýn Ayný Olmasý Gerekmektedir." & vbCrLf & "Þimdi Satýþ Kapatmasý Yapmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If dr_toplam("lNetTutar") > 0 Then
                        analiz_satis_kapatma()
                    ElseIf dr_toplam("lNetTutar") < 0 Then
                        analiz_satis_kapatma_iade()
                    ElseIf dr_toplam("lNetTutar") = 0 Then
                    End If
                End If
            End If
            If GridView1.RowCount = 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..." & "Belgeyi Ýptal Etmek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    tbAlisVeris_kaydet_sil(nAlisVerisID)
                Else
                    e.Cancel = True
                End If
            End If
        End If
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("Pesin").SetValue("Kriter", sec_kriter.Text)
    End Sub
    Private Sub frm_stok_pesin_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
    End Sub
    Private Sub frm_stok_pesin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        Try
            bCalcVadeDagilim = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("bCalcVadeDagilim").ToString
        Catch ex As Exception
            bCalcVadeDagilim = False
        End Try
        Try
            sec_kriter.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("Perakende").OpenSubKey("Pesin").GetValue("Kriter").ToString
        Catch ex As Exception
            sec_kriter.Text = "Baþlar"
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
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        yuklendi = True
        satir_info()

        ' === SESSIZ RISK BILDIRIMI (Pesin Satis Musteri) ===
        Try
            If CLng(nMusteriID) > 0 Then
                RiskBildirimModulu.RiskKontrolEkle(Me, connection, 0, CLng(nMusteriID), AddressOf sorgu_query)
            End If
        Catch : End Try
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            coldteTeslimEdilecek.Visible = True
        Else
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
    End Sub
    Private Sub loaded(Optional ByVal renew As Boolean = False, Optional ByVal e_sFisTpi As String = "")
        If renew = True Then
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
            ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi Where nAST =3 and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
            sec_sFiyatTipi.DataSource = ds_fiyattipi.Tables(0)
            ds_nGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN ('3','4')"))
            sec_nGirisCikis.DataSource = ds_nGirisCikis.Tables(0)
            dataload_satici()
            dataload_odemekodu(sFiyatTipi)
            dataload_tbDovizCinsi()
        End If
        Try
            sSaticiRumuzu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sSaticiRumuzu").ToString
        Catch ex As Exception
            sSaticiRumuzu = ""
        End Try
        Try
            If Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "K" Then
                sFiyatTipi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sKrediliFiyatTipi").ToString()
            ElseIf Trim(sFisTipi) = "SP" Or Trim(sFisTipi) = "P" Then
                sFiyatTipi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sPesinFiyatTipi").ToString
            End If
        Catch ex As Exception
        End Try
        If aktarim = True Then
            toplam_hesapla()
        End If
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
        lbl_Yekun.Text = FormatNumber(dr_toplam("lNetTutar"), 2)
    End Sub
    Private Sub yeni_fis(ByVal e_sFisTipi As String)
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
                tbAlisVeris_kaydet_sil(nAlisVerisID)
                loaded(True, e_sFisTipi)
            Else
                If FormatNumber(dr_toplam("lNetTutar"), 2) <> FormatNumber(sorgu_Kapatma_lTutari(nAlisVerisID, sorgu_sayi(dr_toplam("lNetTutar"), 0)), 2) Then
                    If dr_toplam("lNetTutar") > 0 Then
                        analiz_satis_kapatma()
                    ElseIf dr_toplam("lNetTutar") < 0 Then
                        analiz_satis_kapatma_iade()
                    End If
                    If yeni_fis_kontrol() = True Then
                        loaded(True, e_sFisTipi)
                    End If
                Else
                    loaded(True, e_sFisTipi)
                End If
            End If
        End If
    End Sub
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
                        analiz_satis_kapatma()
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
                If XtraMessageBox.Show(Sorgu_sDil("Satýþý Kredili Satýþa Çevirmek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
                'Ýskonto Güncelle
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
    Private Sub dataload_renk()
        'sec_Renk.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_satici()
        sec_sSatici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici  FROM         tbSatici where bAktif =1")).Tables(0)
    End Sub
    Private Sub dataload_odemekodu(Optional ByVal sFiyatTipi As String = "1")
        'sec_sOdemeKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbFiyatTipiOdemePlani.sOdemeKodu, tbOdemePlani.sAciklama FROM         tbFiyatTipiOdemePlani INNER JOIN                       tbOdemePlani ON tbFiyatTipiOdemePlani.sOdemeKodu = tbOdemePlani.sOdemeKodu WHERE     (tbFiyatTipiOdemePlani.sFiyatTipi = '" & sFiyatTipi & "') ORDER BY cast(tbFiyatTipiOdemePlani.sOdemeKodu as integer) ")).Tables(0)
        sec_sOdemeKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sOdemeKodu,sAciklama FROM         tbOdemePlani ")).Tables(0)
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
        End If
        ds_baslik.Tables(0).Clear()
        Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
        If kayitsayisi = 0 Then
            tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, "", sAdres1, sAdres2, "", "", "", "", "", "", "")
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
        VGrid_toplam.DataMember = "BASLIK"
        VGrid_toplam.Refresh()
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
    Private Sub stok_gor()
        Dim frm As New frm_stok_liste_fiyat
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        frm.Text = "Stok Gör..."
        frm.txt_ara.Text = ""
        frm.sec_konum.Text = "Geliþmiþ"
        frm.ShowDialog()
    End Sub
    Private Sub satir_ekle_stok(ByVal ara As String)
        Dim frm As New frm_stok_liste_fiyat
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.txt_ara.Text = ara
        frm.sec_konum.Text = "Geliþmiþ"
        frm.sec_kriter.Text = sec_kriter.Text
        frm.colFIYAT4.OptionsColumn.ShowInCustomizationForm = False
        info = False
        Dim stok_mevcut As Decimal = 0
        Dim islem As Integer = 0
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow
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
                                XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) düþüyor...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adý: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenk") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                islem = 3
                            End If
                        Else
                            islem = 1
                            XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) Düþemez...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adý: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenk") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut & vbCrLf & Sorgu_sDil("Lütfen Stoklarýnýzý Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                        dr("sAciklama") = dr1("sAciklama")
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
                        dr("sOdemeKodu") = sOdemeKodu
                        dr("dteIrsaliyeTarihi") = dr_baslik("dteFaturaTarihi")
                        dr("lIrsaliyeNo") = 0
                        dr("lGirisMiktar1") = 0
                        dr("lGirisMiktar2") = 0
                        dr("lGirisFiyat") = 0
                        dr("lGirisTutar") = 0
                        dr("lCikisMiktar1") = mevcut
                        dr("lCikisMiktar2") = 0
                        dr("sFiyatTipi") = sFiyatTipi
                        dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
                        dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
                        dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
                        If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                            dr("lBrutFiyat") = dr1("FIYAT1")
                            dr("lBrutTutar") = dr1("FIYAT1") * mevcut
                        ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                            dr("lBrutFiyat") = dr1("FIYAT2")
                            dr("lBrutTutar") = dr1("FIYAT2") * mevcut
                        ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                            dr("lBrutFiyat") = dr1("FIYAT3")
                            dr("lBrutTutar") = dr1("FIYAT3") * mevcut
                        ElseIf Trim(sFiyatTipi) = "HD" Then
                            dr("lBrutFiyat") = 0.01
                            dr("lBrutTutar") = 0.01 * mevcut
                        Else
                            sFiyatTipi = sFiyat1
                            dr("lBrutFiyat") = dr1("FIYAT1")
                            dr("lBrutTutar") = dr1("FIYAT1") * mevcut
                        End If
                        If dr("lBrutFiyat") = 0 Then
                            dr("lBrutFiyat") = 0.001
                            dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                        End If
                        dr("nKdvOrani") = dr1("nKdvOrani")
                        Dim lFiyat As Decimal = dr("lBrutFiyat")
                        Dim lTutar As Decimal = 0
                        lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
                        lTutar = lFiyat * dr("lCikisMiktar1")
                        dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
                        'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                        dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
                        dr("lMaliyetFiyat") = 0
                        dr("lMaliyetTutar") = 0
                        dr("lIlaveMaliyetTutar") = 0
                        dr("nIskontoYuzdesi") = 0
                        dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
                        dr("sDovizCinsi") = ""
                        dr("lDovizFiyat") = 0
                        dr("nReceteNo") = 0
                        dr("nHesapID") = 0
                        dr("sAciklama") = dr1("sAciklama")
                        dr("sHareketTipi") = dr_baslik("sHareketTipi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sKullaniciAdi") = kullanici
                        dr("dteKayitTarihi") = dr_baslik("dteFaturaTarihi") + " " + Now.ToLongTimeString
                        dr("sDovizCinsi1") = ""
                        dr("lDovizMiktari1") = 0
                        dr("lDovizKuru1") = 0
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
                        dr("sSonKullaniciAdi") = kullanici
                        dr("dteSonUpdateTarihi") = Now
                        If dr("lCikisMiktar1") = 0 Then
                            dr("lCikisMiktar1") = 1
                            dr("nGirisCikis") = 3
                        ElseIf dr("lCikisMiktar1") < 0 Then
                            dr("nGirisCikis") = 4
                        ElseIf dr("lCikisMiktar1") > 0 Then
                            dr("nGirisCikis") = 3
                        End If
                        dr("nIslemID") = tbStokFisidetay_kaydet_yeni(dr("nIslemID"), dr("nStokID"), dr("dteIslemTarihi"), dr("nFirmaID"), dr("nMusteriID"), dr("sFisTipi"), dr("dteFisTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), "", dr("nReceteNo"), "", "", dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), "", nAlisVerisID, 0, "", dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        fis_detay_fisno_degistir(dr("nIslemID"))
                        ds_hareket.Tables(0).Rows.Add(dr)
                    End If
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
        End If
        stok_mevcut = Nothing
        info = True
        satir_info()
    End Sub
    Private Sub satir_ekle_stok_tek(ByVal yeni As Boolean)
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr1 = ds_stok.Tables(0).Rows(0)
        Dim stok_mevcut As Decimal = 0
        stok_mevcut = sorgu_envanter(sMagaza, dr1("nStokID"))
        If mevcut > stok_mevcut Then
            If dr1("bEksiyeDusulebilirmi") = True Then
                If dr1("bEksideUyarsinmi") = True Then
                    islem = 2
                    XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) düþüyor...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adý: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenk") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    islem = 3
                End If
            Else
                islem = 1
                XtraMessageBox.Show(Sorgu_sDil("Stok Mevcudu -(Eksiye) Düþemez...!", sDil) & vbCrLf & Sorgu_sDil("Stok Kodu : ", sDil) & dr1("sKodu") & vbCrLf & Sorgu_sDil("Stok Adý: ", sDil) & dr1("sAciklama") & vbCrLf & Sorgu_sDil("Renk: ", sDil) & dr1("sRenk") & vbTab & Sorgu_sDil(" Beden: ", sDil) & dr1("sBeden") & vbCrLf & Sorgu_sDil("Stok Mevcudu: ", sDil) & stok_mevcut & vbCrLf & Sorgu_sDil("Lütfen Stoklarýnýzý Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            dr("sAciklama") = dr1("sAciklama")
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
            dr("sOdemeKodu") = sOdemeKodu
            dr("dteIrsaliyeTarihi") = dr_baslik("dteFaturaTarihi")
            dr("lIrsaliyeNo") = 0
            dr("lGirisMiktar1") = 0
            dr("lGirisMiktar2") = 0
            dr("lGirisFiyat") = 0
            dr("lGirisTutar") = 0
            dr("lCikisMiktar1") = mevcut
            dr("lCikisMiktar2") = 0
            dr("sFiyatTipi") = sFiyatTipi
            dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
            dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
            dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
            If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                dr("lBrutFiyat") = dr1("FIYAT1")
                dr("lBrutTutar") = dr1("FIYAT1") * mevcut
            ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                dr("lBrutFiyat") = dr1("FIYAT2")
                dr("lBrutTutar") = dr1("FIYAT2") * mevcut
            ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                dr("lBrutFiyat") = dr1("FIYAT3")
                dr("lBrutTutar") = dr1("FIYAT3") * mevcut
            ElseIf Trim(sFiyatTipi) = "HD" Then
                dr("lBrutFiyat") = 0.01
                dr("lBrutTutar") = 0.01 * mevcut
            Else
                sFiyatTipi = sFiyat1
                dr("lBrutFiyat") = dr1("FIYAT1")
                dr("lBrutTutar") = dr1("FIYAT1") * mevcut
            End If
            If dr("lBrutFiyat") = 0 Then
                dr("lBrutFiyat") = 0.001
                dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
            End If
            dr("nKdvOrani") = dr1("nKdvOrani")
            Dim lFiyat As Decimal = dr("lBrutFiyat")
            Dim lTutar As Decimal = 0
            lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
            lTutar = lFiyat * dr("lCikisMiktar1")
            dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
            'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
            dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
            dr("lMaliyetFiyat") = 0
            dr("lMaliyetTutar") = 0
            dr("lIlaveMaliyetTutar") = 0
            dr("nIskontoYuzdesi") = 0
            dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
            dr("sDovizCinsi") = ""
            dr("lDovizFiyat") = 0
            dr("nReceteNo") = 0
            dr("nHesapID") = 0
            dr("sAciklama") = dr1("sAciklama")
            dr("sHareketTipi") = dr_baslik("sHareketTipi")
            dr("bMuhasebeyeIslendimi") = 0
            dr("sKullaniciAdi") = "MUHASEBE"
            dr("dteKayitTarihi") = dr_baslik("dteFaturaTarihi") + " " + Now.ToLongTimeString
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
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
            dr("sSonKullaniciAdi") = "MUHASEBE"
            dr("dteSonUpdateTarihi") = Now
            If dr("lCikisMiktar1") = 0 Then
                dr("lCikisMiktar1") = 1
                dr("nGirisCikis") = 3
            ElseIf dr("lCikisMiktar1") < 0 Then
                dr("nGirisCikis") = 4
            ElseIf dr("lCikisMiktar1") > 0 Then
                dr("nGirisCikis") = 3
            End If
            dr("nIslemID") = tbStokFisidetay_kaydet_yeni(dr("nIslemID"), dr("nStokID"), dr("dteIslemTarihi"), dr("nFirmaID"), dr("nMusteriID"), dr("sFisTipi"), dr("dteFisTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), "", dr("nReceteNo"), "", "", dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), "", nAlisVerisID, 0, "", dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
            fis_detay_fisno_degistir(dr("nIslemID"))
            ds_hareket.Tables(0).Rows.Add(dr)
            Label4.Text = "Stok Satýra Ýþlendi...Yeni Ürün Okutun..."
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
    End Sub
    Private Sub satir_ekle_stok_siparis(ByVal ara As String)
        Dim frm As New frm_stok_liste_fiyat
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.txt_ara.Text = ara
        frm.sec_konum.Text = "Geliþmiþ"
        frm.sec_kriter.Text = sec_kriter.Text
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow
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
                    dr("sAciklama") = dr1("sAciklama")
                    dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
                    dr("sSaticiRumuzu") = sSaticiRumuzu
                    dr("sOdemeKodu") = ""
                    dr("lReyonFisNo") = 0
                    dr("sFiyatTipi") = sFiyatTipi
                    dr("lCikisMiktar1") = mevcut
                    dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
                    dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
                    dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
                    If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                        dr("lBrutFiyat") = dr1("FIYAT1")
                        dr("lBrutTutar") = dr1("FIYAT1") * mevcut
                    ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                        dr("lBrutFiyat") = dr1("FIYAT2")
                        dr("lBrutTutar") = dr1("FIYAT2") * mevcut
                    ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                        dr("lBrutFiyat") = dr1("FIYAT3")
                        dr("lBrutTutar") = dr1("FIYAT3") * mevcut
                    ElseIf Trim(sFiyatTipi) = "HD" Then
                        dr("lBrutFiyat") = 0.01
                        dr("lBrutTutar") = 0.01 * mevcut
                    Else
                        sFiyatTipi = sFiyat1
                        dr("lBrutFiyat") = dr1("FIYAT1")
                        dr("lBrutTutar") = dr1("FIYAT1") * mevcut
                    End If
                    If dr("lBrutFiyat") = 0 Then
                        dr("lBrutFiyat") = 0.001
                        dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                    End If
                    dr("nIskontoYuzdesi") = 0
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    Dim lFiyat As Decimal = dr("lBrutFiyat")
                    Dim lTutar As Decimal = 0
                    lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
                    lTutar = lFiyat * dr("lCikisMiktar1")
                    dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
                    'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                    dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
                    dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
                    dr("sIadeNedeni") = ""
                    dr("nPartiID") = 0
                    dr("dteTeslimEdilecek") = dr_baslik("dteFaturaTarihi")
                    dr("dteTeslimEdilen") = "01/01/1900"
                    dr("bTeslimEdildi") = 0
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sAciklama") = dr1("sAciklama")
                    dr("bEkSoru") = 0
                    dr("bEkAlan1") = 0
                    dr("bEkAlan2") = ""
                    dr("sDovizCinsi1") = ""
                    dr("lDovizMiktari1") = 0
                    dr("lDovizKuru1") = 0
                    dr("dteOnayTarihi") = "01/01/1900"
                    dr("sSonKullaniciAdi") = kullanici
                    dr("dteSonUpdateTarihi") = Now
                    If dr("lCikisMiktar1") = 0 Then
                        dr("lCikisMiktar1") = 1
                        dr("nGirisCikis") = 3
                    ElseIf dr("lCikisMiktar1") < 0 Then
                        dr("nGirisCikis") = 4
                    ElseIf dr("lCikisMiktar1") > 0 Then
                        dr("nGirisCikis") = 3
                    End If
                    tbAlisVerisSiparis_kaydet_yeni(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"))
                    tbAvSirano_degistir(5, nSiparisID, dr("sMagazaKodu"))
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
        End If
    End Sub
    Private Sub satir_ekle_stok_siparis_tek(ByVal yeni As Boolean)
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = ds_hareket.Tables(0).NewRow
        dr1 = ds_stok.Tables(0).Rows(0)
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
        dr("sAciklama") = dr1("sAciklama")
        dr("sKasiyerRumuzu") = dr_baslik("sKasiyerRumuzu")
        dr("sSaticiRumuzu") = sSaticiRumuzu
        dr("sOdemeKodu") = ""
        dr("lReyonFisNo") = 0
        dr("sFiyatTipi") = sFiyatTipi
        dr("lCikisMiktar1") = mevcut
        dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
        dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
        dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
        If Trim(sFiyatTipi) = Trim(sFiyat1) Then
            dr("lBrutFiyat") = dr1("FIYAT1")
            dr("lBrutTutar") = dr1("FIYAT1") * mevcut
        ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
            dr("lBrutFiyat") = dr1("FIYAT2")
            dr("lBrutTutar") = dr1("FIYAT2") * mevcut
        ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
            dr("lBrutFiyat") = dr1("FIYAT3")
            dr("lBrutTutar") = dr1("FIYAT3") * mevcut
        ElseIf Trim(sFiyatTipi) = "HD" Then
            dr("lBrutFiyat") = 0.01
            dr("lBrutTutar") = 0.01 * mevcut
        Else
            sFiyatTipi = sFiyat1
            dr("lBrutFiyat") = dr1("FIYAT1")
            dr("lBrutTutar") = dr1("FIYAT1") * mevcut
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
        lFiyat = lFiyat * ((100 - dr_toplam("nDipIskontoYuzdesi")) / 100)
        lTutar = lFiyat * dr("lCikisMiktar1")
        dr("lCikisFiyat") = lFiyat / ((100 + dr("nKdvOrani")) / 100)
        'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
        dr("lCikisTutar") = dr("lCikisMiktar1") * dr("lCikisFiyat")
        dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
        dr("sIadeNedeni") = ""
        dr("nPartiID") = 0
        dr("dteTeslimEdilecek") = dr_baslik("dteFaturaTarihi")
        dr("dteTeslimEdilen") = "01/01/1900"
        dr("bTeslimEdildi") = 0
        dr("bMuhasebeyeIslendimi") = 0
        dr("sAciklama") = dr1("sAciklama")
        dr("bEkSoru") = 0
        dr("bEkAlan1") = 0
        dr("bEkAlan2") = ""
        dr("sDovizCinsi1") = ""
        dr("lDovizMiktari1") = 0
        dr("lDovizKuru1") = 0
        dr("dteOnayTarihi") = "01/01/1900"
        dr("sSonKullaniciAdi") = kullanici
        dr("dteSonUpdateTarihi") = Now
        If dr("lCikisMiktar1") = 0 Then
            dr("lCikisMiktar1") = 1
            dr("nGirisCikis") = 3
        ElseIf dr("lCikisMiktar1") < 0 Then
            dr("nGirisCikis") = 4
        ElseIf dr("lCikisMiktar1") > 0 Then
            dr("nGirisCikis") = 3
        End If
        tbAlisVerisSiparis_kaydet_yeni(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"))
        tbAvSirano_degistir(5, nSiparisID, dr("sMagazaKodu"))
        ds_hareket.Tables(0).Rows.Add(dr)
        Label4.Text = "Stok Satýra Ýþlendi...Yeni Ürün Okutun..."
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
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    tbAlisVerisSiparis_kaydet_sil(nAlisVerisID, dr_hareket("nSiparisID"), dr_hareket("sMagazaKodu"))
                Else
                    tbStokFisidetay_kaydet_sil(nAlisVerisID, dr_hareket("nIslemID"))
                End If
                ds_hareket.Tables(0).Rows.Remove(dr_hareket)
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nSiparisID), 0) + 1 AS nSiparisID FROM         tbAlisverisSiparis Where sMagazaKodu ='" & sMagazaKodu & "'")
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
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        Dim kayitsayisi = cmd.ExecuteScalar
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
        Dim nDipIskontoYuzdesi As Decimal
        Dim lDipIskontoTutari As Decimal
        Dim lPesinat As Decimal
        Dim lNetTutar As Decimal
        For Each dr In ds_hareket.Tables(0).Rows
            lMiktar += dr("lCikisMiktar1")
            lMalbedeli += dr("lBrutTutar")
            lMalIskontoTutari += dr("lBrutTutar") * (dr("nIskontoYuzdesi") / 100)
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
        'If dr_toplam("lDipIskontoTutari") > 0 Then
        '    dr_toplam("nDipIskontoYuzdesi") = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari")) / (lMalbedeli - lMalIskontoTutari)
        'Else
        '    dr_toplam("nDipIskontoYuzdesi") = 0
        'End If
        lNetTutar = lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari")
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
            ds_alislar_kdv = sorgu(sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 5 nKdvOrani, SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdvMatrahi, SUM(lBrutTutar-lIskontoTutari) - SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdv, SUM(lBrutTutar-lIskontoTutari) AS lNetTutar FROM         tbAlisVerisSiparis WHERE     (nAlisverisID = '" & nAlisVerisID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        Else
            ds_alislar_kdv = sorgu(sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 5 nKdvOrani, SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdvMatrahi, SUM(lBrutTutar-lIskontoTutari) - SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdv, SUM(lBrutTutar-lIskontoTutari) AS lNetTutar FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        End If
        Dim dr1 As DataRow
        Dim sayi As Decimal = 0
        For Each dr1 In ds_alislar_kdv.Tables(0).Rows
            sayi += 1
            dr_toplam("nKdvOrani" & sayi & "") = dr1("nKdvOrani")
            dr_toplam("lKdvMatrahi" & sayi & "") = dr1("lKdvMatrahi")
            dr_toplam("lKdv" & sayi & "") = dr1("lKdv")
        Next
        tbAlisVeris_toplam_kaydet_degistir(nAlisVerisID, dr_toplam("nGirisCikis"), dr_toplam("lToplamMiktar"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), dr_toplam("nDipIskontoYuzdesi"), dr_toplam("lDipIskontoTutari"), dr_toplam("nKdvOrani1"), dr_toplam("lKdvMatrahi1"), dr_toplam("lKdv1"), dr_toplam("nKdvOrani2"), dr_toplam("lKdvMatrahi2"), dr_toplam("lKdv2"), dr_toplam("nKdvOrani3"), dr_toplam("lKdvMatrahi3"), dr_toplam("lKdv3"), dr_toplam("nKdvOrani4"), dr_toplam("lKdvMatrahi4"), dr_toplam("lKdv4"), dr_toplam("nKdvOrani5"), dr_toplam("lKdvMatrahi5"), dr_toplam("lKdv5"), dr_toplam("lPesinat"), dr_toplam("nVadeFarkiYuzdesi"), dr_toplam("nVadeKdvOrani"), dr_toplam("lVadeKdvMatrahi"), dr_toplam("lVadeKdv"), dr_toplam("lVadeFarki"), dr_toplam("lNetTutar"), dr_toplam("sYaziIle"))
        lbl_Yekun.Text = FormatNumber(dr_toplam("lNetTutar"), 2)
        dr = Nothing
        dr1 = Nothing
        lMiktar = Nothing
        lMalbedeli = Nothing
        lMalIskontoTutari = Nothing
        nDipIskontoYuzdesi = Nothing
        lDipIskontoTutari = Nothing
        lPesinat = Nothing
        lNetTutar = Nothing
    End Sub
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
                XtraMessageBox.Show(Sorgu_sDil("Yanlýþ Miktar Bilgisi Lütfen Miktarý Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
                lMiktar = dr("lGirisMiktar1")
            ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
                lMiktar = dr("lCikisMiktar1")
            End If
            If GridView1.FocusedColumn.Name.ToString = collDovizMiktari1.Name.ToString Then
                If dr("lDovizKuru1") <> 0 And dr("sDovizCinsi1") <> "" Then
                    dr("lBrutFiyat") = (dr("lDovizMiktari1") / lMiktar) * dr("lDovizKuru1")
                    dr("lBrutTutar") = dr("lBrutFiyat") * lMiktar
                Else
                    dr("lDovizKuru1") = 0
                    dr("lDovizMiktari1") = 0
                End If
            End If
            If GridView1.FocusedColumn.Name.ToString = collBrutTutar.Name.ToString Then
                If dr("lBrutTutar") = 0 Then
                    dr("lBrutTutar") = 0.001
                    dr("lBrutFiyat") = 0.001
                End If
                dr("lBrutFiyat") = dr("lBrutTutar") / dr("lCikisMiktar1")
            Else
                If dr("lBrutFiyat") = 0 Then
                    dr("lBrutFiyat") = 0.001
                    dr("lBrutTutar") = dr("lBrutFiyat") * mevcut
                End If
                dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
            End If
            dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
            'If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
            '    lMiktar = dr("lGirisMiktar1")
            'ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
            '    lMiktar = dr("lCikisMiktar1")
            'End If
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
            dr.EndEdit()
            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                tbAlisVerisSiparis_kaydet_duzelt(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"))
            Else
                tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
            End If
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
        Dim Ý As Integer
        Ý = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For Ý = 1 To TOPLAM
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
        Ý = Nothing
    End Sub
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.nMusteriID, tbAlisVeris.sMagaza, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.sHareketTipi, tbAlisVeris.bMuhasebeyeIslendimi, tbAlisVeris.nKasaNo, tbAlisVeris.sKullaniciAdi, tbAlisVeris.dteKayitTarihi, tbAlisVeris.sYaziIle, tbAlisVerisAdres.sAciklama, tbAlisVerisAdres.sAdres1, tbAlisVerisAdres.sAdres2, tbAlisVerisAdres.sSemt, tbAlisVerisAdres.sIl, tbAlisVerisAdres.sUlke, tbAlisVerisAdres.sPostaKodu, tbAlisVerisAdres.sVergiDairesi, tbAlisVerisAdres.sVergiNo, tbAlisVerisAdres.sSubeMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri,tbMusteri.sGsm,tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu,tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,(SELECT      CAST(bSatismi AS integer) AS bSatismi FROM          tbFisTipi WHERE      sFisTipi = tbAlisVeris.sFisTipi) AS nGCT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID WHERE (tbAlisVeris.nAlisverisID = '" & nAlisVerisID & "')")
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1 = CASE WHEN (lMalBedeli-lMalIskontoTutari) <> 0 THEN (lDipIskontoTutari - lHarcananPuan) / (lMalBedeli-lMalIskontoTutari) * 100 ELSE 0 END, lDipIskontoTutari - lHarcananPuan AS lDipIskontoTutari1, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, lKazanilanPuan, lHarcananPuan, nDipIskontoYuzdesi , lDipIskontoTutari  FROM (SELECT nAlisverisID, nGirisCikis, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lNetTutar, sYaziIle, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_KAZ' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lKazanilanPuan, (SELECT ISNULL(SUM(lTutar), 0) FROM tbAVHediyeCeki WHERE sHediyeCekiTipi = 'ParaPU_HAR' AND nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lHarcananPuan FROM tbAlisVeris WHERE (nAlisverisID = '" & nAlisVerisID & "')) tbToplam ")
        sorgu_txt_toplam = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
    End Function
    Private Function sorgu_harekets(ByVal sFisTipi As String, ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisverisSiparis.nAlisverisID, tbAlisverisSiparis.sMagazaKodu, tbAlisverisSiparis.nSiparisID, tbAlisverisSiparis.nGirisCikis, tbAlisverisSiparis.nStokID, tbAlisverisSiparis.sKasiyerRumuzu, tbAlisverisSiparis.sSaticiRumuzu, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.lReyonFisNo, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.lGCMiktar AS lCikisMiktar1, tbAlisverisSiparis.lBrutFiyat, tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.nIskontoYuzdesi, tbAlisverisSiparis.lIskontoTutari, tbAlisverisSiparis.lFiyat AS lCikisFiyat, 0 as lGirisFiyat,0 as lGirisTutar, tbAlisverisSiparis.lTutar AS lCikisTutar, tbAlisverisSiparis.nKdvOrani, tbAlisverisSiparis.sIadeNedeni, tbAlisverisSiparis.nPartiID, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisverisSiparis.dteTeslimEdilen, tbAlisverisSiparis.bTeslimEdildi, tbAlisverisSiparis.bMuhasebeyeIslendimi, tbAlisverisSiparis.sAciklama, tbAlisverisSiparis.bEkSoru, tbAlisverisSiparis.bEkAlan1, tbAlisverisSiparis.bEkAlan2, tbAlisverisSiparis.sDovizCinsi1, tbAlisverisSiparis.lDovizMiktari1, tbAlisverisSiparis.lDovizKuru1, tbAlisverisSiparis.sSonKullaniciAdi, tbAlisverisSiparis.dteSonUpdateTarihi, tbAlisverisSiparis.dteOnayTarihi, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, (SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sBeden, tbStok.sBirimCinsi1, tbStok.sModel FROM tbAlisverisSiparis INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID Where tbAlisVerisSiparis.nAlisverisID = '" & nAlisVerisID & "' ORDER BY tbAlisVerisSiparis.nSiparisID")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu, tbStok.sAciklama as sStokAciklama,tbStok.sBirimCinsi1,tbStok.sModel,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nKdvOrani / 100) as nKdvTutari FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE     (tbStokFisiDetayi.nAlisverisID = '" & nAlisVerisID & "') ORDER BY tbStokFisiDetayi.nIslemID")
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
    Private Sub tbAlisVeris_kaydet_sil(ByVal nAlisverisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim lOdemeTutar As Decimal = 0
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lOdemeTutar FROM tbAlisVeris INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu =2) and (tbAlisVeris.nAlisverisID = '" & nAlisverisID & "') OR (tbOdeme.nIadeAlisverisID = '" & nAlisverisID & "') ")
        lOdemeTutar = cmd.ExecuteScalar
        If lOdemeTutar = 0 Then
            Try
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("set implicit_transactions off")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVPromosyonIndirim where nAlisverisID = '" & nAlisverisID & "' ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count (a.nTaksitID) from tbTaksit a , tbOdeme b where a.nTaksitID=b.nTaksitID and a.nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("set implicit_transactions on")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSlip set bIptalmi = 0  where nAlisverisID =  ( Select top 1 nIadeAlisverisID from tbOdeme where nIadeAlisverisID <> ''    and nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVKartTaksit where nOdemeID in ( select nOdemeID from tbOdeme where nAlisverisID =  '" & nAlisverisID & "' )")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbOdeme where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbTaksit where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriPara set lPara = lPara - isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "' and sHediyeCekiTipi = 'ParaPU_KAZ'), 0)  + isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "' and sHediyeCekiTipi = 'ParaPU_HAR'), 0)  where nMusteriID in (select nMusteriID from tbAlisveris where nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAVIndirimKuponu set bKapandimi = 0 where sAlinanBasilan = 'B' and sKuponSeriNo in (select sKuponSeriNo from tbAVIndirimKuponu where sAlinanBasilan = 'A'  and nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVIndirimKuponu where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStokFisiDetayi where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisverisSiparis where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisverisSlip where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisVerisAdres where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisVeris where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                ds_hareket.Clear()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            XtraMessageBox.Show(Sorgu_sDil("Ödeme Alýnmýþ Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
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
    Private Sub tbAlisVeris_toplam_kaydet_degistir(ByVal nAlisVerisID As String, ByVal nGirisCikis As Int64, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal lNetTutar As Decimal, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVeris SET              nGirisCikis = " & nGirisCikis & ",lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi = " & nDipIskontoYuzdesi & ", lDipIskontoTutari = " & lDipIskontoTutari & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lPesinat = " & lPesinat & ", nVadeFarkiYuzdesi = " & nVadeFarkiYuzdesi & ", nVadeKdvOrani = " & nVadeKdvOrani & ", lVadeKdvMatrahi = " & lVadeKdvMatrahi & ", lVadeKdv = " & lVadeKdv & ", lVadeFarki = " & lVadeFarki & ", lNetTutar = " & lNetTutar & ", sYaziIle = '" & sYaziIle & "'  WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.ExecuteNonQuery()
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
    Private Sub tbAlisVerisSiparis_kaydet_yeni(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As Int64, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Decimal, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal bMuhasebeyeIslendimi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal dteOnayTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisverisSiparis (nAlisverisID, sMagazaKodu, nSiparisID, nGirisCikis, nStokID, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, lReyonFisNo, sFiyatTipi, lGCMiktar, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, nKdvOrani, sIadeNedeni, nPartiID, dteTeslimEdilecek, dteTeslimEdilen, bTeslimEdildi, bMuhasebeyeIslendimi, sAciklama, bEkSoru, bEkAlan1, bEkAlan2, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sSonKullaniciAdi, dteSonUpdateTarihi, dteOnayTarihi) VALUES     ('" & nAlisverisID & "', '" & sMagazaKodu & "', " & nSiparisID & ", " & nGirisCikis & ", " & nStokID & ", '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', " & lReyonFisNo & ", '" & sFiyatTipi & "', " & lGCMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", " & lFiyat & ", " & lTutar & ", " & nKdvOrani & ", '" & sIadeNedeni & "', " & nPartiID & ", '" & dteTeslimEdilecek & "', '" & dteTeslimEdilen & "', " & bTeslimEdildi & ", " & bMuhasebeyeIslendimi & ", N'" & sAciklama & "', " & bEkSoru & ", " & bEkAlan1 & ", '" & bEkAlan2 & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & dteOnayTarihi & "') ")
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbAlisverisSiparis Where nSiparisID = " & nSiparisID & " and nAlisVerisID = '" & nAlisverisID & "' AND sMagazaKodu ='" & sMagazaKodu & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVerisSiparis_kaydet_duzelt(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As Int64, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Decimal, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal bMuhasebeyeIslendimi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal dteOnayTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              nGirisCikis = " & nGirisCikis & ",sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', lReyonFisNo = " & lReyonFisNo & ", sFiyatTipi = '" & sFiyatTipi & "', lGCMiktar = " & lGCMiktar & ", lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", lFiyat = " & lFiyat & ", lTutar = " & lTutar & ", nKdvOrani = " & nKdvOrani & ", sIadeNedeni = '" & sIadeNedeni & "', nPartiID = " & nPartiID & ", dteTeslimEdilecek = '" & dteTeslimEdilecek & "', dteTeslimEdilen = '" & dteTeslimEdilen & "', bTeslimEdildi = " & bTeslimEdildi & ", bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sAciklama = N'" & sAciklama & "', bEkSoru = " & bEkSoru & ", bEkAlan1 = " & bEkAlan1 & ", bEkAlan2 = '" & bEkAlan2 & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "', dteOnayTarihi = '" & dteOnayTarihi & "' Where nSiparisID = " & nSiparisID & " AND nAlisVerisID = '" & nAlisverisID & "' and sMagazaKodu ='" & sMagazaKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisidetay_kaydet_degistir(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET               nStokID = '" & nStokID & "', dteIslemTarihi = '" & dteIslemTarihi & "', nFirmaID = " & nFirmaID & ", nMusteriID = " & nMusteriID & ", sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', lFisNo = '" & lFisNo & "', nGirisCikis = " & nGirisCikis & ", sDepo = '" & sDepo & "', lReyonFisNo = " & lReyonFisNo & ", sStokIslem = '" & sStokIslem & "', sKasiyerRumuzu = '" & sKasiyerRumuzu & "', sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', dteIrsaliyeTarihi = '" & dteIrsaliyeTarihi & "', lIrsaliyeNo = '" & lIrsaliyeNo & "', lGirisMiktar1 = " & lGirisMiktar1 & ", lGirisMiktar2 = " & lGirisMiktar2 & ", lGirisFiyat = " & lGirisFiyat & ", lGirisTutar = " & lGirisTutar & ", lCikisMiktar1 = " & lCikisMiktar1 & ", lCikisMiktar2 = " & lCikisMiktar2 & ", lCikisFiyat = " & lCikisFiyat & ", lCikisTutar = " & lCikisTutar & ", sFiyatTipi = '" & sFiyatTipi & "', lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", lMaliyetFiyat = " & lMaliyetFiyat & ", lMaliyetTutar = " & lMaliyetTutar & ", lIlaveMaliyetTutar = " & lIlaveMaliyetTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyat = " & lDovizFiyat & ", nReceteNo = " & nReceteNo & ", nKdvOrani = " & nKdvOrani & ", nHesapID = " & nHesapID & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "' , bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", nOTVOrani = " & nOTVOrani & ", sMasrafYontemi = '" & sMasrafYontemi & "', sHangiUygulama = '" & sHangiUygulama & "', nEkSaha1 = " & nEkSaha1 & ", nEkSaha2 = " & nEkSaha2 & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where nAlisVerisID = '" & nAlisverisID & "' and nIslemID = '" & nIslemID & "'")
        cmd.ExecuteNonQuery()
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
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim iskonto As Decimal = 100
        Dim nDipIskontoYuzdesi As Decimal = 0
        If index = 0 Then
            nDipIskontoYuzdesi = 0
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbStokFisiDetayi  Where nAlisVerisID = '" & nAlisVerisID & "' and nIslemID = '" & nIslemID & "'")
        cmd.ExecuteNonQuery()
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
    Private Function sorgu(ByVal query As String) As DataSet
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
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
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
        VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERAKENDE\" & Trim(sFisTipi) & "\BASLIK\" & Me.Name.ToString & "")
        VGrid_toplam.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERAKENDE\" & Trim(sFisTipi) & "\TOPLAM\" & Me.Name.ToString & "")
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERAKENDE\" & Trim(sFisTipi) & "\HAREKET\" & Me.Name.ToString & "")
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
                VGrid_baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                VGrid_baslik.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                VGrid_toplam.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                VGrid_toplam.Appearance.RowHeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERAKENDE\" & Trim(sFisTipi) & "\BASLIK\" & Me.Name.ToString & "")
        'VGrid_toplam.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERAKENDE\" & Trim(sFisTipi) & "\TOPLAM\" & Me.Name.ToString & "")
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERAKENDE\" & Trim(sFisTipi) & "\HAREKET\" & Me.Name.ToString & "")
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
    Private Sub analiz_satis_kapatma_iade()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_pesin_kapatma_iade
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.skasiyer = sKasiyerRumuzu
            frm.skasiyerRumuzu = dr_baslik("sKasiyerRumuzu")
            frm.sMagaza = dr_baslik("sMagaza")
            frm.nKasaNo = dr_baslik("nKasaNo")
            frm.dteFisTarihi = dr_baslik("dteFaturaTarihi")
            frm.nAlisVerisID = nAlisVerisID
            frm.nMusteriID = dr_baslik("nMusteriID")
            frm.sFisTipi = dr_baslik("sFisTipi")
            frm.lNetTutar = Math.Abs(dr_toplam("lNetTutar"))
            frm.sOdemeKodu = sOdemeKodu
            Me.Size = New System.Drawing.Size(Me.Size.Width - 190, Me.Size.Height)
            Me.Location = New System.Drawing.Size(Me.Location.X - 95, Me.Location.Y)
            frm.Location = New System.Drawing.Size(Me.Size.Width, Me.Location.Y)
            frm.StartPosition = FormStartPosition.Manual
            frm.Size = New System.Drawing.Size(frm.Size.Width, Me.Size.Height)
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
                stok_kontrol()
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
                XtraMessageBox.Show(Sorgu_sDil("Resmi Stok Kaydý Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        'frm.qstokkodu = "Eþittir"
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
        'frm.qstokkodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
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
            'frm.nFirmaID = dr("nMusteriID")
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "Çýkýþlar"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.islemstatus = True
                frm.bPerakende = True
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                    dr("lBrutFiyat") = dr1("lBrut")
                    dr("lBrutTutar") = dr("lCikisMiktar1") * dr("lBrutFiyat")
                    dr("nIskontoYuzdesi") = (dr1("lIskontoTutari") / Math.Abs(dr("lBrutTutar"))) * 100
                    dr("lIskontoTutari") = (dr("lBrutTutar") * dr("nIskontoYuzdesi")) / 100
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    dr("sSaticiRumuzu") = dr1("sSaticiRumuzu")
                    'dr("sFiyatTipi") = dr1("sFiyatTipi")
                    dr1 = Nothing
                    tutar_hesapla()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
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
            'frm.sec_giris.Text = "Giriþler"
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
            If info = True Then
                If GridView1.RowCount > 0 Then
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    ds_satir_stok = sorgu_stok_info(dr("sKodu"))
                    Dim dr1 As DataRow = ds_satir_stok.Tables(0).Rows(0)
                    If dr1("sRenkAdi").ToString <> "" Then
                        label2.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ")" & vbCrLf & "Giren: " & CType(dr1("GIREN"), Int64) & " Çýkan: " & CType(dr1("CIKAN"), Int64) & " Mevcut: " & CType(dr1("KALAN"), Int64) & " Bekleyen: " & CType(dr1("BEKLEYEN"), Int64)
                    ElseIf Trim(dr1("sBeden").ToString) <> "" Then
                        label2.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ") (Beden: " & Trim(dr1("sBeden")) & ")" & vbCrLf & "Giren: " & CType(dr1("GIREN"), Int64) & " Çýkan: " & CType(dr1("CIKAN"), Int64) & " Mevcut: " & CType(dr1("KALAN"), Int64) & " Bekleyen: " & CType(dr1("BEKLEYEN"), Int64)
                    Else
                        label2.Text = dr1("STOKADI") & vbCrLf & "Giren: " & CType(dr1("GIREN"), Int64) & " Çýkan: " & CType(dr1("CIKAN"), Int64) & " Mevcut: " & CType(dr1("KALAN"), Int64) & " Bekleyen: " & CType(dr1("BEKLEYEN"), Int64)
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
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer, Optional ByVal bFis As Boolean = False, Optional ByVal bFatura As Boolean = False)
        Dim file As String
        Dim kriter As String
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Perakende_satis*.fr3) |Perakende_satis*.fr3"
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
    Private Sub tbAVHediyeCeki()
        Dim frm As New frm_stok_pesin_puan
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.nAlisVerisID = dr_baslik("nAlisVerisID")
        frm.lAlisVerisTutari = dr_toplam("lNetTutar")
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
                    If XtraMessageBox.Show(Sorgu_sDil("Satisi Hesaba Aktarmak Ýster misiniz ? ", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        If Trim(dr_baslik("sFisTipi")) = "P" Then
                            If XtraMessageBox.Show(Sorgu_sDil("Satýþý Kredili Satýþa Çevirmek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
                            'Ýskonto Güncelle
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
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kýsýtlý Kullaným.Maximum Kayýt Sýnýrýný Aþamazsýnýz...!" & vbCrLf & "Lütfen Yetkili Satýcýnýzla Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Dim sIsim As String = ""
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
            sIsim = dr_baslik("sAdi") & " " & dr_baslik("sSoyadi")
            Dim gun_evlilik As String = ""
            Dim gun_dogum
            Dim yil
            Dim gun
            Dim ay
            If Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(3, 2) = "01" Then
            ElseIf Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            Else
                'lbl_isim.Text += "  Doðum Tarihi :" & dr("DOGUMTARIHI").ToLongDateString
                yil = Today.ToString.Substring(8, 2)
                gun = dr_baslik("DOGUMTARIHI").ToString.Substring(0, 2)
                ay = dr_baslik("DOGUMTARIHI").ToString.Substring(3, 2)
                sIsim += "  Doðum Günü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                If gun_dogum > 0 And gun_dogum < 30 Then
                    sIsim += " " & gun_dogum & " Gün Sonra Doðum Gününüz.Þimdiden Doðum Gününüz Kutlu Olsun..!"
                ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                    sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Doðum Gününüzmüþ...Nice Senelere..!"
                ElseIf gun_dogum = 0 Then
                    sIsim += "  Doðum Gününüz Kutlu Olsun...!"
                End If
            End If
            If Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(3, 2) = "01" Then
            ElseIf Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            Else
                sIsim += "  Evlilik Tarihi :" & dr("EVLILIKTARIHI")
                yil = Today.ToString.Substring(8, 2)
                gun = dr_baslik("EVLILIKTARIHI").ToString.Substring(0, 2)
                ay = dr_baslik("EVLILIKTARIHI").ToString.Substring(3, 2)
                sIsim += "  Evlilik Yýldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                If gun_dogum > 0 And gun_dogum < 30 Then
                    sIsim += " " & gun_dogum & " Gün Sonra Evlilik Yýldönümünüz.Þimdiden Evlilik Yýldönümünüz Kutlu Olsun..!"
                ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                    sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yýldönümünüzmüþ...Nice Senelere..!"
                ElseIf gun_dogum = 0 Then
                    sIsim += "  Evlilik Yýldönümünüz Kutlu Olsun...!"
                End If
            End If
            frx.SetVariable("Anons", "'" & sIsim & "'")
            If dr_toplam("lToplamMiktar") > 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satýþ'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satýþ'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peþin Satýþ'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    frx.SetVariable("BelgeTipi", "'Peþin Satýþ'")
                End If
            ElseIf dr_toplam("lToplamMiktar") <= 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satýþ Ýade/Deðiþim'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satýþ Ýade/Deðiþim'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peþin SatýþÝade/Deðiþim'")
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    frx.SetVariable("BelgeTipi", "'Peþin Satýþ Ýade/Deðiþim'")
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
            sIsim = dr_baslik("sAdi") & " " & dr_baslik("sSoyadi")
            Dim gun_evlilik As String = ""
            Dim gun_dogum
            Dim yil
            Dim gun
            Dim ay
            If Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(3, 2) = "01" Then
            ElseIf Trim(dr_baslik("DOGUMTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            Else
                'lbl_isim.Text += "  Doðum Tarihi :" & dr("DOGUMTARIHI").ToLongDateString
                yil = Today.ToString.Substring(8, 2)
                gun = dr_baslik("DOGUMTARIHI").ToString.Substring(0, 2)
                ay = dr_baslik("DOGUMTARIHI").ToString.Substring(3, 2)
                sIsim += "  Doðum Günü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                If gun_dogum > 0 And gun_dogum < 30 Then
                    sIsim += " " & gun_dogum & " Gün Sonra Doðum Gününüz.Þimdiden Doðum Gününüz Kutlu Olsun..!"
                ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                    sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Doðum Gününüzmüþ...Nice Senelere..!"
                ElseIf gun_dogum = 0 Then
                    sIsim += "  Doðum Gününüz Kutlu Olsun...!"
                End If
            End If
            If Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(3, 2) = "01" Then
            ElseIf Trim(dr_baslik("EVLILIKTARIHI")).ToString.Substring(0, 5) = "01/01" Then
            Else
                sIsim += "  Evlilik Tarihi :" & dr("EVLILIKTARIHI")
                yil = Today.ToString.Substring(8, 2)
                gun = dr_baslik("EVLILIKTARIHI").ToString.Substring(0, 2)
                ay = dr_baslik("EVLILIKTARIHI").ToString.Substring(3, 2)
                sIsim += "  Evlilik Yýldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                If gun_dogum > 0 And gun_dogum < 30 Then
                    sIsim += " " & gun_dogum & " Gün Sonra Evlilik Yýldönümünüz.Þimdiden Evlilik Yýldönümünüz Kutlu Olsun..!"
                ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                    sIsim += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yýldönümünüzmüþ...Nice Senelere..!"
                ElseIf gun_dogum = 0 Then
                    sIsim += "  Evlilik Yýldönümünüz Kutlu Olsun...!"
                End If
            End If
            args(14) = "Anons"
            args(15) = "'" & sIsim.ToString() & "'"
            If dr_toplam("lToplamMiktar") > 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Kredili Satýþ'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Kredili Satýþ'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Peþin Satýþ'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Peþin Satýþ'"
                End If
            ElseIf dr_toplam("lToplamMiktar") <= 0 Then
                If Trim(dr_baslik("sFisTipi")) = "K" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Kredili Satýþ Ýade/Deðiþim'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SK" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Kredili Satýþ Ýade/Deðiþim'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "SP" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Sonradan Teslim Peþin SatýþÝade/Deðiþim'"
                ElseIf Trim(dr_baslik("sFisTipi")) = "P" Then
                    args(16) = "BelgeTipi"
                    args(17) = "'Peþin Satýþ Ýade/Deðiþim'"
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
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
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
        If GridView1.SelectedRowsCount > 1 Then
            Label1.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label1.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label1.Text = ""
        End If
        Try
            Label1.Text += " / ToplamMiktar :" & FormatNumber(dr_toplam("lToplamMiktar"), 2)
        Catch ex As Exception
        End Try
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
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        baslik_degistir()
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
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If kapatma_kontrol() = True Then
            raporla(0, 0)
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla(0, 2)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If kapatma_kontrol() = True Then
            raporla(0, 1)
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            satir_ekle_stok_siparis("")
        Else
            satir_ekle_stok("")
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        If dr_toplam("lNetTutar") > 0 Then
            analiz_satis_kapatma()
        ElseIf dr_toplam("lNetTutar") < 0 Then
            analiz_satis_kapatma_iade()
        ElseIf dr_toplam("lNetTutar") = 0 Then
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Ýptal Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbAlisVeris_kaydet_sil(nAlisVerisID)
            bkapat = True
            Me.Close()
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
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
            satir_ekle_stok_siparis("")
        Else
            satir_ekle_stok("")
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                info = False
                degeryay(GridView1.FocusedColumn().FieldName)
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
            If XtraMessageBox.Show(Sorgu_sDil("Satýþ Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
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
        If VGrid_toplam.FocusedRecordCellIndex.ToString = 0 Then
        ElseIf VGrid_toplam.FocusedRecordCellIndex.ToString = 1 Then
            If dr_toplam("lDipIskontoTutari1") <> 0 Then
                dr_toplam("nDipIskontoYuzdesi1") = FormatNumber((dr_toplam("lDipIskontoTutari1") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100, 2)
            Else
                dr_toplam("nDipIskontoYuzdesi1") = 0
            End If
        End If
        'MsgBox(dr_toplam("nDipIskontoYuzdesi1"))
        If dr_toplam("nDipIskontoYuzdesi1") > nMaxIskontoYuzdesi Then
            dr_toplam("nDipIskontoYuzdesi1") = nMaxIskontoYuzdesi
        End If
        dr_toplam("lDipIskontoTutari") = FormatNumber(dr_toplam("lDipIskontoTutari1") + dr_toplam("lHarcananPuan"), 2)
        If dr_toplam("lDipIskontoTutari") <> 0 Then
            dr_toplam("nDipIskontoYuzdesi") = FormatNumber((dr_toplam("lDipIskontoTutari") / (dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"))) * 100, 2)
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
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        stok_fiyat()
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        If Len(txt_ara.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_ara.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_ara.Text = "" Then
                satir_ekle_stok("")
            Else
                stok_ara()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            GridView1.FocusedColumn = collGCMiktar
        End If
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýþ Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub stok_ara()
        If Trim(txt_ara.Text) <> "" Then
            Label4.Text = "Barkod Standardý Kontrol Ediliyor..."
            Label4.Refresh()
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If
                If Trim((Trim(txt_ara.Text)).Substring(0, 2)) = sBarcodeStd Then
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
                        If IsNumeric(Trim(txt_ara.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            Label4.Text = "Barkod Standardý Kontrolü Tamamlandý..."
            Label4.Refresh()
            stok_kontrol()
        End If
    End Sub
    Private Sub stok_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Stok Kartý Kontrolü Yapýlýyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_stok_kontrol(txt_ara.Text, sec_kriter.Text)
        If kontrol = 0 Then
            Label4.Text = "Stok Kaydý Bulunamadý!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
            If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý..." & vbCrLf & "Yeni Kayýt Eklemek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                stok_yeni(txt_ara.Text)
            End If
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Stok Kaydý Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayýt Tek...")
            dataload_stok(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Stok Bilgisi Yükleniyor... "
            Label4.Refresh()
            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                satir_ekle_stok_siparis_tek(False)
            Else
                satir_ekle_stok_tek(False)
            End If
        ElseIf kontrol > 1 Then
            If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                satir_ekle_stok_siparis(Trim(txt_ara.Text))
            Else
                satir_ekle_stok(Trim(txt_ara.Text))
            End If
            Label4.Text = "Stok Satýra Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter
        kriter = "WHERE (Stok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ") or (Stok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (Stok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") OR Stok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok Stok INNER JOIN  tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID and Barcode.nKisim =0 " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
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
    Private Sub dataload_stok(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT4, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
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
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        If BarButtonItem25.Caption = "Barkod Okut" Then
            txt_ara.Focus()
            txt_ara.Select()
            BarButtonItem25.Caption = "Veri Gir"
        ElseIf BarButtonItem25.Caption = "Veri Gir" Then
            GridControl1.Focus()
            GridControl1.Select()
            BarButtonItem25.Caption = "Barkod Okut"
        End If
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        'If Trim(dr_baslik("sFisTipi")) = "P" Then
        yeni_fis("P")
        'Else
        '    XtraMessageBox.Show(Sorgu_sDil("Ýþleminiz Sadece Peþin Satýþ Ýþlemlerinde Geçerlidir, Lütfen Belge Türünü Kontrol Ediniz...!",sDil), MessageBoxIcon.Warning, sorgu_sDil("Dikkat",sDil))
        'End If
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        musteri_sec()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        stok_gor()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        tutaragore_miktarhesapla()
    End Sub
    Private Sub tutaragore_miktarhesapla()
        Dim frm As New frm_calc
        frm.Text = "Tutara Göre MiktarHesapla..."
        frm.status = False
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If frm.tutar <> 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("lBrutTutar") = frm.tutar
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
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Satýcýlara Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi = 0
                For Each dr In ds_hareket.Tables(0).Rows
                    dr("sSaticiRumuzu") = frm.LookUpEdit1.EditValue
                    If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                        tbAlisVerisSiparis_kaydet_duzelt(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"))
                    Else
                        tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                    End If
                Next
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub sFiyatTipi_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi as sKod,sAciklama as sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"
        frm.lbl_sKod.Text = "KdvTipi:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" FiyatTipini Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
                            tbAlisVerisSiparis_kaydet_duzelt(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"))
                        Else
                            tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        End If
                    End If
                Next
                'Ýskonto Güncelle
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
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        tutaragore_miktarhesapla()
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        sSaticiRumuzu_toplu()
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        sFiyatTipi_toplu()
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        If BarButtonItem32.Caption = "Alt Toplamlar" Then
            VGrid_toplam.Focus()
            VGrid_toplam.FocusedRow = rowDipIskonto
            VGrid_toplam.FocusedRecordCellIndex = 0
            VGrid_toplam.Select()
            'txt_ara.Focus()
            'txt_ara.Select()
            BarButtonItem32.Caption = "Barkod Okut"
        ElseIf BarButtonItem32.Caption = "Barkod Okut" Then
            txt_ara.Focus()
            txt_ara.Select()
            BarButtonItem32.Caption = "Alt Toplamlar"
        End If
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        If BarButtonItem33.Caption = "Etiket Tuslarý Göster" Then
            TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            BarButtonItem33.Caption = "Etiket Tuslarý Gizle"
        ElseIf BarButtonItem33.Caption = "Etiket Tuslarý Gizle" Then
            TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            txt_ara.Focus()
            txt_ara.Select()
            BarButtonItem33.Caption = "Etiket Tuslarý Göster"
        End If
    End Sub
    Private Sub TusPanel_VisibilityChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles TusPanel.VisibilityChanged
        If TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.Select()
            BarButtonItem33.Caption = "Etiket Tuslarý Göster"
        ElseIf TusPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            etiket_tus_ara()
            BarButtonItem33.Caption = "Etiket Tuslarý Gizle"
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
    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        cari_sec()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        'If Trim(dr_baslik("sFisTipi")) = "P" Then
        yeni_fis("P")
        'Else
        '    XtraMessageBox.Show(Sorgu_sDil("Ýþleminiz Sadece Peþin Satýþ Ýþlemlerinde Geçerlidir, Lütfen Belge Türünü Kontrol Ediniz...!",sDil), MessageBoxIcon.Warning, sorgu_sDil("Dikkat",sDil))
        'End If
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        If dr_toplam("lNetTutar") > 0 Then
            analiz_satis_kapatma()
        ElseIf dr_toplam("lNetTutar") < 0 Then
            analiz_satis_kapatma_iade()
        ElseIf dr_toplam("lNetTutar") = 0 Then
        End If
    End Sub
    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        'If kapatma_kontrol() = True Then
        raporla(0, 1, True, False)
        'End If
    End Sub
    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        Process.Start("C:\Windows\system32\osk.exe")
    End Sub
    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        raporla(0, 1, False, True)
    End Sub
    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        tbMusteri_yeni()
    End Sub
    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem42_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Ýptal Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbAlisVeris_kaydet_sil(nAlisVerisID)
            bkapat = True
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem43_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        tbAVHediyeCeki()
    End Sub
    Private Sub BarButtonItem44_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        musteri_sec()
    End Sub
    Private Sub BarButtonItem45_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem45.ItemClick
        Dim deger = ""
        deger = InputBox("Net Satis Tutari", "Net Satis Tutari", dr_toplam("lNetTutar")).ToString
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
    Private Sub BarButtonItem46_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        satir_ekle_stok("")
    End Sub
    Private Sub VGrid_baslik_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGrid_baslik.KeyDown
        If e.KeyCode = Keys.Tab Then
            GridView1.Focus()
        End If
    End Sub
End Class
