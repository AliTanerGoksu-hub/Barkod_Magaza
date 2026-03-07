Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_cari_yonetimi
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
    Friend WithEvents PanelControl1 As PanelControl
    Friend WithEvents PanelControl2 As PanelControl
    Friend WithEvents PanelControl3 As PanelControl
    Friend WithEvents SplitterControl1 As SplitterControl
    Friend WithEvents PanelControl4 As PanelControl
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
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
    Friend WithEvents rownFirmaID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKodu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownOzelIskontosu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKrediLimiti As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteMutabakatTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownVadeGun As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsHitap As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAdres1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAdres2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsSemt As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsIl As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsUlke As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsPostaKodu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiDairesi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownHesapID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsOzelNot As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKullaniciAdi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteKayitTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsFiyatTipi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSinif1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSinif2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSinif3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSinif4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSinif5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryÝletiþim As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryFinansman As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categorySýnýflandýrma As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryVergi_Bilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryEk_Bilgiler As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents VGrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents SimpleButton3 As SimpleButton
    Friend WithEvents lbl_HesapKodu As LabelControl
    Friend WithEvents txt_sKodu As ButtonEdit
    Friend WithEvents Label1 As LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents PanelControl5 As PanelControl
    Friend WithEvents PanelControl6 As PanelControl
    Friend WithEvents Label39 As LabelControl
    Friend WithEvents SimpleButton6 As SimpleButton
    Friend WithEvents Label40 As LabelControl
    Friend WithEvents sec_ekstre_tarih2 As DateEdit
    Friend WithEvents sec_ekstre_tarih1 As DateEdit
    Friend WithEvents Label3 As LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents sec_kriter As ComboBoxEdit
    Friend WithEvents SimpleButton2 As SimpleButton
    Friend WithEvents SimpleButton4 As SimpleButton
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sSiparisTipi As ComboBoxEdit
    Friend WithEvents SimpleButton5 As SimpleButton
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl7 As PanelControl
    Friend WithEvents sec_sIrsaliyeTipi As ComboBoxEdit
    Friend WithEvents Label4 As LabelControl
    Friend WithEvents sec_irsaliye_kriter As ComboBoxEdit
    Friend WithEvents Label5 As LabelControl
    Friend WithEvents SimpleButton7 As SimpleButton
    Friend WithEvents Label6 As LabelControl
    Friend WithEvents DateEdit2 As DateEdit
    Friend WithEvents DateEdit1 As DateEdit
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents lbl_istihbarat As LabelControl
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton8 As SimpleButton
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents colsIslem As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_KapatBorc As SimpleButton
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AlacaklarAcik As SimpleButton
    Friend WithEvents btn_KapatSatis As SimpleButton
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents btn_GenelHareketler As SimpleButton
    Friend WithEvents sec_sNot As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents rowsDovizCinsi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari_yonetimi))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem3 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem14 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem6 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbPesinmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.VGrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.sec_sNot = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownFirmaID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKodu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAciklama = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsHitap = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsDovizCinsi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryÝletiþim = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsAdres1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAdres2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsSemt = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsIl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsUlke = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsPostaKodu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryFinansman = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownOzelIskontosu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKrediLimiti = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteMutabakatTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownVadeGun = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsFiyatTipi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categorySýnýflandýrma = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowSinif1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSinif2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSinif3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSinif4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSinif5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryVergi_Bilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsVergiDairesi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsVergiNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryEk_Bilgiler = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownHesapID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKullaniciAdi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteKayitTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsOzelNot = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_sKodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.btn_GenelHareketler = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_KapatSatis = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_AlacaklarAcik = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_KapatBorc = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_HesapKodu = New DevExpress.XtraEditors.LabelControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ds_hareket = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_sSiparisTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label39 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label40 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_ekstre_tarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_ekstre_tarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.sec_sIrsaliyeTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_irsaliye_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sNot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.sec_sSiparisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.sec_sIrsaliyeTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_irsaliye_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1276, 72)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelControl1.Location = New System.Drawing.Point(915, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(314, 68)
        Me.LabelControl1.TabIndex = 38
        Me.LabelControl1.Text = "***"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(1229, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(45, 13)
        Me.lbl_istihbarat.TabIndex = 37
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Firma Kartý ve Analiz Bilgileri Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 72)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1276, 168)
        Me.PanelControl2.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.VGrid_baslik)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1272, 164)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Hesap Kartý Genel Bilgiler"
        '
        'VGrid_baslik
        '
        Me.VGrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(398, 289, 208, 252)
        Me.VGrid_baslik.DataMember = Nothing
        Me.VGrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_baslik.Location = New System.Drawing.Point(2, 15)
        Me.VGrid_baslik.Name = "VGrid_baslik"
        Me.VGrid_baslik.OptionsBehavior.Editable = False
        Me.VGrid_baslik.OptionsBehavior.UseTabKey = False
        Me.VGrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sNot})
        Me.VGrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTanýmlar, Me.categoryÝletiþim, Me.categoryFinansman, Me.categorySýnýflandýrma, Me.categoryVergi_Bilgileri, Me.categoryEk_Bilgiler})
        Me.VGrid_baslik.Size = New System.Drawing.Size(1268, 147)
        Me.VGrid_baslik.TabIndex = 0
        Me.VGrid_baslik.ToolTipController = Me.ToolTipController1
        Me.VGrid_baslik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'sec_sNot
        '
        Me.sec_sNot.Name = "sec_sNot"
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownFirmaID, Me.rowsKodu, Me.rowsAciklama, Me.rowsHitap, Me.rowsDovizCinsi})
        Me.categoryTanýmlar.Name = "categoryTanýmlar"
        Me.categoryTanýmlar.Properties.Caption = "Tanýmlar"
        '
        'rownFirmaID
        '
        Me.rownFirmaID.Name = "rownFirmaID"
        Me.rownFirmaID.Properties.Caption = "Kayýt No"
        Me.rownFirmaID.Properties.FieldName = "nFirmaID"
        '
        'rowsKodu
        '
        Me.rowsKodu.Name = "rowsKodu"
        Me.rowsKodu.Properties.Caption = "Hesap Kodu"
        Me.rowsKodu.Properties.FieldName = "sKodu"
        '
        'rowsAciklama
        '
        Me.rowsAciklama.Name = "rowsAciklama"
        Me.rowsAciklama.Properties.Caption = "HesapAdý"
        Me.rowsAciklama.Properties.FieldName = "sAciklama"
        '
        'rowsHitap
        '
        Me.rowsHitap.Name = "rowsHitap"
        Me.rowsHitap.Properties.Caption = "Hitap"
        Me.rowsHitap.Properties.FieldName = "sHitap"
        Me.rowsHitap.Visible = False
        '
        'rowsDovizCinsi
        '
        Me.rowsDovizCinsi.Name = "rowsDovizCinsi"
        Me.rowsDovizCinsi.Properties.Caption = "Döviz Cinsi"
        Me.rowsDovizCinsi.Properties.FieldName = "sDovizCinsi"
        '
        'categoryÝletiþim
        '
        Me.categoryÝletiþim.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsAdres1, Me.rowsAdres2, Me.rowsSemt, Me.rowsIl, Me.rowsUlke, Me.rowsPostaKodu})
        Me.categoryÝletiþim.Name = "categoryÝletiþim"
        Me.categoryÝletiþim.Properties.Caption = "Ýletiþim"
        '
        'rowsAdres1
        '
        Me.rowsAdres1.Name = "rowsAdres1"
        Me.rowsAdres1.Properties.Caption = "Adres1"
        Me.rowsAdres1.Properties.FieldName = "sAdres1"
        '
        'rowsAdres2
        '
        Me.rowsAdres2.Name = "rowsAdres2"
        Me.rowsAdres2.Properties.Caption = "Adres2"
        Me.rowsAdres2.Properties.FieldName = "sAdres2"
        '
        'rowsSemt
        '
        Me.rowsSemt.Name = "rowsSemt"
        Me.rowsSemt.Properties.Caption = "Semt"
        Me.rowsSemt.Properties.FieldName = "sSemt"
        '
        'rowsIl
        '
        Me.rowsIl.Name = "rowsIl"
        Me.rowsIl.Properties.Caption = "il"
        Me.rowsIl.Properties.FieldName = "sIl"
        '
        'rowsUlke
        '
        Me.rowsUlke.Name = "rowsUlke"
        Me.rowsUlke.Properties.Caption = "Ulke"
        Me.rowsUlke.Properties.FieldName = "sUlke"
        '
        'rowsPostaKodu
        '
        Me.rowsPostaKodu.Name = "rowsPostaKodu"
        Me.rowsPostaKodu.Properties.Caption = "PostaKodu"
        Me.rowsPostaKodu.Properties.FieldName = "sPostaKodu"
        '
        'categoryFinansman
        '
        Me.categoryFinansman.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownOzelIskontosu, Me.rowlKrediLimiti, Me.rowdteMutabakatTarihi, Me.rownVadeGun, Me.rowsFiyatTipi})
        Me.categoryFinansman.Name = "categoryFinansman"
        Me.categoryFinansman.Properties.Caption = "Finansman"
        '
        'rownOzelIskontosu
        '
        Me.rownOzelIskontosu.Name = "rownOzelIskontosu"
        Me.rownOzelIskontosu.Properties.Caption = "Iskonto"
        Me.rownOzelIskontosu.Properties.FieldName = "nOzelIskontosu"
        '
        'rowlKrediLimiti
        '
        Me.rowlKrediLimiti.Name = "rowlKrediLimiti"
        Me.rowlKrediLimiti.Properties.Caption = "Kredi Limiti"
        Me.rowlKrediLimiti.Properties.FieldName = "lKrediLimiti"
        '
        'rowdteMutabakatTarihi
        '
        Me.rowdteMutabakatTarihi.Name = "rowdteMutabakatTarihi"
        Me.rowdteMutabakatTarihi.Properties.Caption = "Mutabakat Tarihi"
        Me.rowdteMutabakatTarihi.Properties.FieldName = "dteMutabakatTarihi"
        '
        'rownVadeGun
        '
        Me.rownVadeGun.Name = "rownVadeGun"
        Me.rownVadeGun.Properties.Caption = "VadeGun"
        Me.rownVadeGun.Properties.FieldName = "nVadeGun"
        '
        'rowsFiyatTipi
        '
        Me.rowsFiyatTipi.Name = "rowsFiyatTipi"
        Me.rowsFiyatTipi.Properties.Caption = "FiyatTipi"
        Me.rowsFiyatTipi.Properties.FieldName = "sFiyatTipi"
        '
        'categorySýnýflandýrma
        '
        Me.categorySýnýflandýrma.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSinif1, Me.rowSinif2, Me.rowSinif3, Me.rowSinif4, Me.rowSinif5})
        Me.categorySýnýflandýrma.Name = "categorySýnýflandýrma"
        Me.categorySýnýflandýrma.Properties.Caption = "Sýnýflandýrma"
        '
        'rowSinif1
        '
        Me.rowSinif1.Name = "rowSinif1"
        Me.rowSinif1.Properties.Caption = "Sýnýf 1"
        Me.rowSinif1.Properties.FieldName = "Sinif1"
        '
        'rowSinif2
        '
        Me.rowSinif2.Name = "rowSinif2"
        Me.rowSinif2.Properties.Caption = "Sýnýf 2"
        Me.rowSinif2.Properties.FieldName = "Sinif2"
        '
        'rowSinif3
        '
        Me.rowSinif3.Name = "rowSinif3"
        Me.rowSinif3.Properties.Caption = "Sýnýf 3"
        Me.rowSinif3.Properties.FieldName = "Sinif3"
        '
        'rowSinif4
        '
        Me.rowSinif4.Name = "rowSinif4"
        Me.rowSinif4.Properties.Caption = "Sýnýf 4"
        Me.rowSinif4.Properties.FieldName = "Sinif4"
        '
        'rowSinif5
        '
        Me.rowSinif5.Name = "rowSinif5"
        Me.rowSinif5.Properties.Caption = "Sýnýf 5"
        Me.rowSinif5.Properties.FieldName = "Sinif5"
        '
        'categoryVergi_Bilgileri
        '
        Me.categoryVergi_Bilgileri.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsVergiDairesi, Me.rowsVergiNo})
        Me.categoryVergi_Bilgileri.Name = "categoryVergi_Bilgileri"
        Me.categoryVergi_Bilgileri.Properties.Caption = "Vergi Bilgileri"
        '
        'rowsVergiDairesi
        '
        Me.rowsVergiDairesi.Name = "rowsVergiDairesi"
        Me.rowsVergiDairesi.Properties.Caption = "Vergi Dairesi"
        Me.rowsVergiDairesi.Properties.FieldName = "sVergiDairesi"
        '
        'rowsVergiNo
        '
        Me.rowsVergiNo.Name = "rowsVergiNo"
        Me.rowsVergiNo.Properties.Caption = "Vergi No"
        Me.rowsVergiNo.Properties.FieldName = "sVergiNo"
        '
        'categoryEk_Bilgiler
        '
        Me.categoryEk_Bilgiler.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownHesapID, Me.rowsKullaniciAdi, Me.rowdteKayitTarihi, Me.rowsOzelNot})
        Me.categoryEk_Bilgiler.Name = "categoryEk_Bilgiler"
        Me.categoryEk_Bilgiler.Properties.Caption = "Ek Bilgiler"
        '
        'rownHesapID
        '
        Me.rownHesapID.Name = "rownHesapID"
        Me.rownHesapID.Properties.Caption = "MuhasebeKayýtNo"
        Me.rownHesapID.Properties.FieldName = "nHesapID"
        '
        'rowsKullaniciAdi
        '
        Me.rowsKullaniciAdi.Height = 16
        Me.rowsKullaniciAdi.Name = "rowsKullaniciAdi"
        Me.rowsKullaniciAdi.Properties.Caption = "Kaydeden"
        Me.rowsKullaniciAdi.Properties.FieldName = "sKullaniciAdi"
        Me.rowsKullaniciAdi.Visible = False
        '
        'rowdteKayitTarihi
        '
        Me.rowdteKayitTarihi.Name = "rowdteKayitTarihi"
        Me.rowdteKayitTarihi.Properties.Caption = "Kayýt Tarihi"
        Me.rowdteKayitTarihi.Properties.FieldName = "dteKayitTarihi"
        '
        'rowsOzelNot
        '
        Me.rowsOzelNot.Height = 154
        Me.rowsOzelNot.Name = "rowsOzelNot"
        Me.rowsOzelNot.Properties.Caption = "Özel Not"
        Me.rowsOzelNot.Properties.FieldName = "sOzelNot"
        Me.rowsOzelNot.Properties.RowEdit = Me.sec_sNot
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txt_sKodu)
        Me.PanelControl3.Controls.Add(Me.btn_GenelHareketler)
        Me.PanelControl3.Controls.Add(Me.btn_KapatSatis)
        Me.PanelControl3.Controls.Add(Me.btn_AlacaklarAcik)
        Me.PanelControl3.Controls.Add(Me.btn_KapatBorc)
        Me.PanelControl3.Controls.Add(Me.SimpleButton8)
        Me.PanelControl3.Controls.Add(Me.SimpleButton5)
        Me.PanelControl3.Controls.Add(Me.SimpleButton2)
        Me.PanelControl3.Controls.Add(Me.SimpleButton4)
        Me.PanelControl3.Controls.Add(Me.SimpleButton3)
        Me.PanelControl3.Controls.Add(Me.lbl_HesapKodu)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl3.Location = New System.Drawing.Point(0, 512)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1276, 40)
        Me.PanelControl3.TabIndex = 2
        '
        'txt_sKodu
        '
        Me.txt_sKodu.Location = New System.Drawing.Point(72, 8)
        Me.txt_sKodu.Name = "txt_sKodu"
        Me.txt_sKodu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKodu.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKodu.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sKodu.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sKodu.Size = New System.Drawing.Size(161, 20)
        Me.txt_sKodu.TabIndex = 7
        '
        'btn_GenelHareketler
        '
        Me.btn_GenelHareketler.Image = CType(resources.GetObject("btn_GenelHareketler.Image"), System.Drawing.Image)
        Me.btn_GenelHareketler.Location = New System.Drawing.Point(838, 8)
        Me.btn_GenelHareketler.Name = "btn_GenelHareketler"
        Me.btn_GenelHareketler.Size = New System.Drawing.Size(100, 22)
        ToolTipTitleItem1.Text = "Genel Hareketler"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Ýþlem Türlerine Göre Bakiye Analizi"
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Alt+G"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.btn_GenelHareketler.SuperTip = SuperToolTip1
        Me.btn_GenelHareketler.TabIndex = 68
        Me.btn_GenelHareketler.Text = "&Genel Hareket"
        '
        'btn_KapatSatis
        '
        Me.btn_KapatSatis.Image = CType(resources.GetObject("btn_KapatSatis.Image"), System.Drawing.Image)
        Me.btn_KapatSatis.Location = New System.Drawing.Point(638, 8)
        Me.btn_KapatSatis.Name = "btn_KapatSatis"
        Me.btn_KapatSatis.Size = New System.Drawing.Size(100, 22)
        ToolTipTitleItem3.Text = "Satýþ Kapat"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Seçili Hesap hareketine yapýlmýþ olan satýþlar karþýlýðýnda alýnan ödemelerin eþl" & _
    "eþtirmesi sistem tarafýndan sýralý olarak otomatik yapýlýr."
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btn_KapatSatis.SuperTip = SuperToolTip2
        Me.btn_KapatSatis.TabIndex = 67
        Me.btn_KapatSatis.Text = "&SatýþKapat"
        '
        'btn_AlacaklarAcik
        '
        Me.btn_AlacaklarAcik.Image = CType(resources.GetObject("btn_AlacaklarAcik.Image"), System.Drawing.Image)
        Me.btn_AlacaklarAcik.Location = New System.Drawing.Point(738, 8)
        Me.btn_AlacaklarAcik.Name = "btn_AlacaklarAcik"
        Me.btn_AlacaklarAcik.Size = New System.Drawing.Size(100, 22)
        ToolTipTitleItem4.Text = "Açýk Faturalar"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Seçili Hesap hareketine yapýlmýþ satýþlardan henüz ödemesi bitmemiþ olanlar liste" & _
    "lenir, varsa vade farký ve gecikme günleri bu ekranda özet veya detaylý olarak l" & _
    "istelenir."
        ToolTipTitleItem5.LeftIndent = 6
        ToolTipTitleItem5.Text = "Alt+A"
        SuperToolTip3.Items.Add(ToolTipTitleItem4)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip3.Items.Add(ToolTipTitleItem5)
        Me.btn_AlacaklarAcik.SuperTip = SuperToolTip3
        Me.btn_AlacaklarAcik.TabIndex = 66
        Me.btn_AlacaklarAcik.Text = "&Açýk Alacaklar"
        '
        'btn_KapatBorc
        '
        Me.btn_KapatBorc.Image = CType(resources.GetObject("btn_KapatBorc.Image"), System.Drawing.Image)
        Me.btn_KapatBorc.Location = New System.Drawing.Point(538, 8)
        Me.btn_KapatBorc.Name = "btn_KapatBorc"
        Me.btn_KapatBorc.Size = New System.Drawing.Size(100, 22)
        ToolTipTitleItem6.Text = "Borç Kapat"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Seçili hesap hareketine yapýlmýþ satýþlarýn karþýlýðýnda alýnmýþ olan ödemelerin " & _
    "eþleþtirmesi bu ekrandan yapýlýr. istenirse yapýlmýþ eþleþtirmeler deðiþtirilebi" & _
    "lir."
        SuperToolTip4.Items.Add(ToolTipTitleItem6)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btn_KapatBorc.SuperTip = SuperToolTip4
        Me.btn_KapatBorc.TabIndex = 64
        Me.btn_KapatBorc.Text = "&Borç Kapat"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Image = CType(resources.GetObject("SimpleButton8.Image"), System.Drawing.Image)
        Me.SimpleButton8.Location = New System.Drawing.Point(338, 8)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(100, 22)
        ToolTipTitleItem7.Text = "Hesap Hareketi Ekle"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Hesap kartýna Hareket iþlemenize veya Hesap hareketlerinde Deðiþiklik Yapmanýza Y" & _
    "ardýmcý olur."
        ToolTipTitleItem8.LeftIndent = 6
        ToolTipTitleItem8.Text = "F12"
        SuperToolTip5.Items.Add(ToolTipTitleItem7)
        SuperToolTip5.Items.Add(ToolTipItem5)
        SuperToolTip5.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip5.Items.Add(ToolTipTitleItem8)
        Me.SimpleButton8.SuperTip = SuperToolTip5
        Me.SimpleButton8.TabIndex = 63
        Me.SimpleButton8.Text = "&Hareket Gir"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(438, 8)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(100, 22)
        ToolTipTitleItem9.Text = "Hesap Hareketlerini Yenile"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Seçili hesap hareketlerini varsa deðiþikliklerle birlikte listeler."
        SuperToolTip6.Items.Add(ToolTipTitleItem9)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.SimpleButton5.SuperTip = SuperToolTip6
        Me.SimpleButton5.TabIndex = 13
        Me.SimpleButton5.Text = "&Yenile"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1240, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(24, 23)
        ToolTipTitleItem10.Text = "Sonraki Hesap"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Bir Sonraki Hesap Kartýný Getirir"
        ToolTipTitleItem11.LeftIndent = 6
        ToolTipTitleItem11.Text = "Ctrl+Right"
        SuperToolTip7.Items.Add(ToolTipTitleItem10)
        SuperToolTip7.Items.Add(ToolTipItem7)
        SuperToolTip7.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip7.Items.Add(ToolTipTitleItem11)
        Me.SimpleButton2.SuperTip = SuperToolTip7
        Me.SimpleButton2.TabIndex = 12
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(1216, 8)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(24, 23)
        ToolTipTitleItem12.Text = "Önceki Hesap Kartý"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Bir Önceki Hesap Kartýný Getirir"
        ToolTipTitleItem13.LeftIndent = 6
        ToolTipTitleItem13.Text = "Ctrl+Left"
        SuperToolTip8.Items.Add(ToolTipTitleItem12)
        SuperToolTip8.Items.Add(ToolTipItem8)
        SuperToolTip8.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip8.Items.Add(ToolTipTitleItem13)
        Me.SimpleButton4.SuperTip = SuperToolTip8
        Me.SimpleButton4.TabIndex = 11
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(238, 8)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(100, 22)
        ToolTipTitleItem14.Text = "Not Düþ"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Hesap kartýna Not Düþmenize yardýmcý olur. Hesap kartý iþlem gördüðünde veya list" & _
    "elendiðinde program size Belirtmiþ oluduðunuz Notlarý iletecektir."
        ToolTipTitleItem15.LeftIndent = 6
        ToolTipTitleItem15.Text = "F9"
        SuperToolTip9.Items.Add(ToolTipTitleItem14)
        SuperToolTip9.Items.Add(ToolTipItem9)
        SuperToolTip9.Items.Add(ToolTipSeparatorItem6)
        SuperToolTip9.Items.Add(ToolTipTitleItem15)
        Me.SimpleButton3.SuperTip = SuperToolTip9
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "&Notlar"
        '
        'lbl_HesapKodu
        '
        Me.lbl_HesapKodu.Location = New System.Drawing.Point(5, 8)
        Me.lbl_HesapKodu.Name = "lbl_HesapKodu"
        Me.lbl_HesapKodu.Size = New System.Drawing.Size(58, 13)
        Me.lbl_HesapKodu.TabIndex = 8
        Me.lbl_HesapKodu.Text = "HesapKodu:"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1276, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 552)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1276, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 552)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1276, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 552)
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 240)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(1276, 6)
        Me.SplitterControl1.TabIndex = 3
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 246)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1276, 266)
        Me.PanelControl4.TabIndex = 4
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.Options.UseBackColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1272, 262)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1270, 229)
        Me.XtraTabPage1.Text = "Hesap Hareketleri"
        Me.XtraTabPage1.Tooltip = "Hesap Hareketleri Burada Listelenir. Hesap Hareketlerinin Detayýný görmek için üz" & _
    "erinde iken Enter Tuþuna basmanýz yeterli olacaktýr."
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1270, 229)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sFirmaKodu"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sFirmaAciklama"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dteIslemTarihi"
        Me.DataColumn29.DataType = GetType(Date)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "dteValorTarihi"
        Me.DataColumn30.DataType = GetType(Date)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "IslemAciklama"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "lFisNo"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "lBorcTutar"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "lAlacakTutar"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Bakiye"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sFirmaHarAciklama"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sHareketTipi"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "lDevirBorc"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "lDevirAlacak"
        Me.DataColumn39.DataType = GetType(Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "lDevir"
        Me.DataColumn40.DataType = GetType(Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "IslemTipi"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "nStokFisiID"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "sDovizCinsi1"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "lDovizMiktari1"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "lDovizKuru1"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sDovizCinsi2"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "lDovizMiktari2"
        Me.DataColumn47.DataType = GetType(Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "lDovizKuru2"
        Me.DataColumn48.DataType = GetType(Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "dteKayitTarihi"
        Me.DataColumn49.DataType = GetType(Date)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "nHareketID"
        Me.DataColumn50.DataType = GetType(Long)
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
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFirmaKodu, Me.colsFirmaAciklama, Me.coldteIslemTarihi, Me.coldteValorTarihi, Me.colIslemAciklama, Me.collFisNo, Me.collBorcTutar, Me.collAlacakTutar, Me.colBakiye, Me.colsFirmaHarAciklama, Me.colsHareketTipi, Me.collDevirBorc, Me.collDevirAlacak, Me.collDevir, Me.colIslemTipi, Me.colnStokFisiID, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsDovizCinsi2, Me.collDovizMiktari2, Me.collDovizKuru2, Me.coldteKayitTarihi, Me.colsIslem})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(723, 396, 208, 173)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Nothing, "Borc: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Nothing, "Alacak: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Me.collBorcTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", Me.collAlacakTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", Me.coldteIslemTarihi, "{0:#} Kayýt")})
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Hesap Kodu"
        Me.colsFirmaKodu.FieldName = "sFirmaKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        '
        'colsFirmaAciklama
        '
        Me.colsFirmaAciklama.Caption = "HesapAdý"
        Me.colsFirmaAciklama.FieldName = "sFirmaAciklama"
        Me.colsFirmaAciklama.Name = "colsFirmaAciklama"
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "Tarih"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", "{0} Kayýt")})
        Me.coldteIslemTarihi.Visible = True
        Me.coldteIslemTarihi.VisibleIndex = 0
        Me.coldteIslemTarihi.Width = 99
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Vade"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        Me.coldteValorTarihi.Visible = True
        Me.coldteValorTarihi.VisibleIndex = 1
        Me.coldteValorTarihi.Width = 105
        '
        'colIslemAciklama
        '
        Me.colIslemAciklama.Caption = "Ýþlem"
        Me.colIslemAciklama.FieldName = "IslemAciklama"
        Me.colIslemAciklama.Name = "colIslemAciklama"
        Me.colIslemAciklama.Width = 47
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 5
        Me.collFisNo.Width = 126
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
        Me.collBorcTutar.VisibleIndex = 7
        Me.collBorcTutar.Width = 126
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
        Me.collAlacakTutar.VisibleIndex = 8
        Me.collAlacakTutar.Width = 126
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
        Me.colBakiye.VisibleIndex = 9
        Me.colBakiye.Width = 133
        '
        'colsFirmaHarAciklama
        '
        Me.colsFirmaHarAciklama.Caption = "Açýklama"
        Me.colsFirmaHarAciklama.FieldName = "sAciklama"
        Me.colsFirmaHarAciklama.Name = "colsFirmaHarAciklama"
        Me.colsFirmaHarAciklama.Visible = True
        Me.colsFirmaHarAciklama.VisibleIndex = 6
        Me.colsFirmaHarAciklama.Width = 280
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Visible = True
        Me.colsHareketTipi.VisibleIndex = 2
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
        Me.colIslemTipi.Caption = "Ýþlem Tipi"
        Me.colIslemTipi.FieldName = "IslemTipi"
        Me.colIslemTipi.Name = "colIslemTipi"
        Me.colIslemTipi.Visible = True
        Me.colIslemTipi.VisibleIndex = 3
        Me.colIslemTipi.Width = 79
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Stok Fiþi ID"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        Me.colsDovizCinsi1.Width = 62
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarý"
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
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colsIslem
        '
        Me.colsIslem.Caption = "Ýþlem"
        Me.colsIslem.FieldName = "sIslem"
        Me.colsIslem.Name = "colsIslem"
        Me.colsIslem.Visible = True
        Me.colsIslem.VisibleIndex = 4
        Me.colsIslem.Width = 115
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1270, 229)
        Me.XtraTabPage2.Text = "Bakiye Analizi"
        Me.XtraTabPage2.Tooltip = "Farklý Parabirimleri cinsinden Hesabýn Bakiyeleri listelenir."
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1270, 229)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Bakiye Analizi"
        '
        'GridControl4
        '
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(2, 15)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(1266, 212)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.Empty.Options.UseBackColor = True
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
        Me.GridView4.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
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
        Me.XtraTabPage3.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage3.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1270, 229)
        Me.XtraTabPage3.Text = "Sipariþler"
        Me.XtraTabPage3.Tooltip = "Hesap kartýndan iþlenmiþ Sipariþlerinin belirlenen tarihler arasýndaki analizi li" & _
    "stelenir. Açýk Sipariþler için [Açýk] kapanmýþ sipariþler için [Kapalý] seçeneði" & _
    " kullanýlýr."
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.GridControl2)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(0, 40)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1270, 189)
        Me.PanelControl6.TabIndex = 1
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextMenu1
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1266, 185)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem8, Me.MenuItem9, Me.MenuItem15, Me.MenuItem11, Me.MenuItem10, Me.MenuItem7, Me.MenuItem2, Me.MenuItem16, Me.MenuItem5, Me.MenuItem3, Me.MenuItem4, Me.MenuItem6, Me.MenuItem14, Me.MenuItem17, Me.MenuItem12, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Hesap Seç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem8.Text = "Firma Kartý"
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
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem7.Text = "Açýklama Gir"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 7
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem2.Text = "Ýletiþim Bilgileri"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 8
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.ShiftF6
        Me.MenuItem16.Text = "Firma Stoklarý"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 9
        Me.MenuItem5.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 10
        Me.MenuItem3.Text = "Sonraki Kart"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 11
        Me.MenuItem4.Text = "Önceki Kart"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 12
        Me.MenuItem6.Text = "Son Kart"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 13
        Me.MenuItem14.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 14
        Me.MenuItem17.Text = "Hýzlý Filtre"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 15
        Me.MenuItem12.Text = "Görünümü Düzenle"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 16
        Me.MenuItem13.Text = "Görünümü Kaydet"
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colsFirmaAdi, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsKavala, Me.colsAciklama, Me.colsSatirAciklama, Me.coldteIlkSevkiyatTarihi, Me.colsBirimCinsi, Me.colsSipNo, Me.coldteSiparisTarihi, Me.coldteTeslimTarihi, Me.colsSiparisIslem, Me.colSiparisMiktari, Me.colSiparisTutari, Me.colSiparisTutari1, Me.colSiparisTutari2, Me.collSevkMiktari, Me.collSevkTutari, Me.collKalanMiktar, Me.collKalanTutar, Me.colsPartiKodu, Me.collGirisMiktar, Me.collGirisTutar, Me.collEnvanterMiktar, Me.collEnvanterTutar, Me.collFarkMiktar, Me.collFarkTutar, Me.collKrediLimiti, Me.colnValorGun, Me.colbKapandimi, Me.collBirimFiyati, Me.colsDovizCinsi, Me.collDovizKuru, Me.collDovizFiyati, Me.collSevkIadeMiktari, Me.collBakiye, Me.collToplamRisk, Me.collBirimFiyati1, Me.collBirimFiyati2})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(493, 378, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", Nothing, "SiparisMiktari : {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", Nothing, "SevkMiktari {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", Nothing, "KalanMiktar: {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sModel", Me.colsModel, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", Me.colSiparisMiktari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", Me.collSevkMiktari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", Me.collKalanMiktar, "{0:#,0.00}")})
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsPrint.ExpandAllGroups = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Firma Kodu"
        Me.GridColumn1.FieldName = "sFirmaKodu"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colsFirmaAdi
        '
        Me.colsFirmaAdi.Caption = "Firma Adý"
        Me.colsFirmaAdi.FieldName = "sFirmaAdi"
        Me.colsFirmaAdi.Name = "colsFirmaAdi"
        Me.colsFirmaAdi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaAdi", "{0} Kayýt")})
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
        Me.colsRenkAdi.Caption = "Renk Adý"
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
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colsSatirAciklama
        '
        Me.colsSatirAciklama.Caption = "Açýklama"
        Me.colsSatirAciklama.FieldName = "sSatirAciklama"
        Me.colsSatirAciklama.Name = "colsSatirAciklama"
        '
        'coldteIlkSevkiyatTarihi
        '
        Me.coldteIlkSevkiyatTarihi.Caption = "Ýlk Sevkiyat Tarihi"
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
        Me.colsSipNo.Caption = "Sipariþ No"
        Me.colsSipNo.FieldName = "sSipNo"
        Me.colsSipNo.Name = "colsSipNo"
        Me.colsSipNo.Visible = True
        Me.colsSipNo.VisibleIndex = 4
        '
        'coldteSiparisTarihi
        '
        Me.coldteSiparisTarihi.Caption = "Sipariþ Tarihi"
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
        Me.colsSiparisIslem.Caption = "Sipariþ Ýþlem"
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
        Me.colSiparisTutari.Caption = "Sipariþ Tutarý"
        Me.colSiparisTutari.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari.FieldName = "SiparisTutari"
        Me.colSiparisTutari.Name = "colSiparisTutari"
        Me.colSiparisTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisTutari", "{0:#,0.00}")})
        '
        'colSiparisTutari1
        '
        Me.colSiparisTutari1.Caption = "Sipariþ Tutarý 1"
        Me.colSiparisTutari1.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari1.FieldName = "SiparisTutari1"
        Me.colSiparisTutari1.Name = "colSiparisTutari1"
        '
        'colSiparisTutari2
        '
        Me.colSiparisTutari2.Caption = "Sipariþ Tutarý 2"
        Me.colSiparisTutari2.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari2.FieldName = "SiparisTutari2"
        Me.colSiparisTutari2.Name = "colSiparisTutari2"
        '
        'collSevkMiktari
        '
        Me.collSevkMiktari.Caption = "Gelen"
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
        Me.collSevkTutari.Caption = "Sevk Tutarý"
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
        Me.collGirisMiktar.Caption = "Giriþ Miktarý"
        Me.collGirisMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar.FieldName = "lGirisMiktar"
        Me.collGirisMiktar.Name = "collGirisMiktar"
        '
        'collGirisTutar
        '
        Me.collGirisTutar.Caption = "Giriþ Tutarý"
        Me.collGirisTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisTutar.FieldName = "lGirisTutar"
        Me.collGirisTutar.Name = "collGirisTutar"
        '
        'collEnvanterMiktar
        '
        Me.collEnvanterMiktar.Caption = "Envanter Miktarý"
        Me.collEnvanterMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collEnvanterMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEnvanterMiktar.FieldName = "lEnvanterMiktar"
        Me.collEnvanterMiktar.Name = "collEnvanterMiktar"
        '
        'collEnvanterTutar
        '
        Me.collEnvanterTutar.Caption = "Envanter Tutarý"
        Me.collEnvanterTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collEnvanterTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEnvanterTutar.FieldName = "lEnvanterTutar"
        Me.collEnvanterTutar.Name = "collEnvanterTutar"
        '
        'collFarkMiktar
        '
        Me.collFarkMiktar.Caption = "Fark Miktarý"
        Me.collFarkMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collFarkMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFarkMiktar.FieldName = "lFarkMiktar"
        Me.collFarkMiktar.Name = "collFarkMiktar"
        '
        'collFarkTutar
        '
        Me.collFarkTutar.Caption = "Fark Tutarý"
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
        Me.colbKapandimi.Caption = "Kapandýmý"
        Me.colbKapandimi.FieldName = "bKapandimi"
        Me.colbKapandimi.Name = "colbKapandimi"
        '
        'collBirimFiyati
        '
        Me.collBirimFiyati.Caption = "Birim Fiyatý"
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
        Me.collDovizFiyati.Caption = "Döviz Fiyatý"
        Me.collDovizFiyati.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizFiyati.FieldName = "lDovizFiyati"
        Me.collDovizFiyati.Name = "collDovizFiyati"
        '
        'collSevkIadeMiktari
        '
        Me.collSevkIadeMiktari.Caption = "Sevk Ýade Miktari"
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
        Me.collBirimFiyati1.Caption = "Birim Fiyatý 1"
        Me.collBirimFiyati1.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati1.FieldName = "lBirimFiyati1"
        Me.collBirimFiyati1.Name = "collBirimFiyati1"
        '
        'collBirimFiyati2
        '
        Me.collBirimFiyati2.Caption = "Birim Fiyatý 2"
        Me.collBirimFiyati2.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati2.FieldName = "lBirimFiyati2"
        Me.collBirimFiyati2.Name = "collBirimFiyati2"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.sec_sSiparisTipi)
        Me.PanelControl5.Controls.Add(Me.Label3)
        Me.PanelControl5.Controls.Add(Me.sec_kriter)
        Me.PanelControl5.Controls.Add(Me.Label39)
        Me.PanelControl5.Controls.Add(Me.SimpleButton6)
        Me.PanelControl5.Controls.Add(Me.Label40)
        Me.PanelControl5.Controls.Add(Me.sec_ekstre_tarih2)
        Me.PanelControl5.Controls.Add(Me.sec_ekstre_tarih1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1270, 40)
        Me.PanelControl5.TabIndex = 0
        '
        'sec_sSiparisTipi
        '
        Me.sec_sSiparisTipi.EditValue = "Alýnan"
        Me.sec_sSiparisTipi.Location = New System.Drawing.Point(438, 9)
        Me.sec_sSiparisTipi.Name = "sec_sSiparisTipi"
        Me.sec_sSiparisTipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sSiparisTipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sSiparisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSiparisTipi.Properties.Items.AddRange(New Object() {"Alýnan", "Verilen"})
        Me.sec_sSiparisTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sSiparisTipi.Size = New System.Drawing.Size(72, 20)
        Me.sec_sSiparisTipi.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(516, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Sipariþleri"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Açýk"
        Me.sec_kriter.Location = New System.Drawing.Point(352, 9)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"[Tümü]", "Açýk", "Kapalý"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(80, 20)
        Me.sec_kriter.TabIndex = 28
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(112, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(12, 13)
        Me.Label39.TabIndex = 27
        Me.Label39.Text = "ve"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(594, 8)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton6.TabIndex = 30
        Me.SimpleButton6.Text = "&Oku"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(248, 9)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(90, 13)
        Me.Label40.TabIndex = 25
        Me.Label40.Text = "Tarihleri Arasýndaki"
        '
        'sec_ekstre_tarih2
        '
        Me.sec_ekstre_tarih2.EditValue = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.sec_ekstre_tarih2.EnterMoveNextControl = True
        Me.sec_ekstre_tarih2.Location = New System.Drawing.Point(144, 9)
        Me.sec_ekstre_tarih2.Name = "sec_ekstre_tarih2"
        Me.sec_ekstre_tarih2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_ekstre_tarih2.Properties.Appearance.Options.UseBackColor = True
        Me.sec_ekstre_tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih2.Size = New System.Drawing.Size(96, 20)
        Me.sec_ekstre_tarih2.TabIndex = 24
        '
        'sec_ekstre_tarih1
        '
        Me.sec_ekstre_tarih1.EditValue = New Date(2007, 2, 1, 0, 0, 0, 0)
        Me.sec_ekstre_tarih1.EnterMoveNextControl = True
        Me.sec_ekstre_tarih1.Location = New System.Drawing.Point(16, 9)
        Me.sec_ekstre_tarih1.Name = "sec_ekstre_tarih1"
        Me.sec_ekstre_tarih1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_ekstre_tarih1.Properties.Appearance.Options.UseBackColor = True
        Me.sec_ekstre_tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih1.Size = New System.Drawing.Size(88, 20)
        Me.sec_ekstre_tarih1.TabIndex = 23
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridControl3)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1270, 229)
        Me.XtraTabPage4.Text = "Ýrsaliyeler"
        Me.XtraTabPage4.Tooltip = "Hesap kartýndan iþlenmiþ irsaliyelerin belirlenen tarihler arasýndaki analizi lis" & _
    "telenir. Faturalarþmýþ Ýrsaliyeler için [Kapalý] , Faturalaþmamýþ irsaliyeler iç" & _
    "in [Açýk] seçeneði kullanýlýr."
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.ContextMenu1
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 40)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1270, 189)
        Me.GridControl3.TabIndex = 2
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
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
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteFisTarihi, Me.GridColumn2, Me.colnGirisCikis, Me.collToplamMiktar, Me.collNetTutar, Me.colsDepo, Me.colDepo, Me.colsKodu, Me.GridColumn3, Me.colsTransferDepo, Me.coltDepo, Me.colsFaturalasti, Me.colMuhasebelesti, Me.GridColumn4, Me.colsNot, Me.colTamamlandi, Me.collTevkifatKdvMatrahi, Me.collTevkifatKdv, Me.colHizmet, Me.colnFirmaID, Me.colsFisTipi, Me.GridColumn5, Me.colKdvTutari, Me.colKdvMatrahi, Me.collMalIskontoTutari, Me.collMalBedeli, Me.colEkMaliyet, Me.colISKONTO, Me.colEkOran, Me.colbPesinmi})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(796, 271, 208, 156)
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colbPesinmi
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Tag = True
        StyleFormatCondition3.Value1 = True
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView3.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Tarih"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", "{0} Kayýt")})
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 0
        Me.coldteFisTarihi.Width = 65
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Fiþ No"
        Me.GridColumn2.FieldName = "lFisNo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 51
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriþ/Çýkýþ"
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
        Me.colDepo.Caption = "DepoAdý"
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
        Me.GridColumn3.Caption = "Firma Adý"
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
        Me.coltDepo.Caption = "Transfer Depo Adý"
        Me.coltDepo.FieldName = "tDepo"
        Me.coltDepo.Name = "coltDepo"
        '
        'colsFaturalasti
        '
        Me.colsFaturalasti.Caption = "Faturalaþtý ?"
        Me.colsFaturalasti.FieldName = "sFaturalasti"
        Me.colsFaturalasti.Name = "colsFaturalasti"
        '
        'colMuhasebelesti
        '
        Me.colMuhasebelesti.Caption = "Muhasebeleþti"
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
        Me.collTevkifatKdvMatrahi.Caption = "Tevkifat Kdv Matrahý"
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
        Me.GridColumn5.Caption = "Kayýt No"
        Me.GridColumn5.FieldName = "nStokFisiID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'colKdvTutari
        '
        Me.colKdvTutari.Caption = "Kdv Tutarý"
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
        Me.colKdvMatrahi.Caption = "Kdv Matrahý"
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
        Me.colISKONTO.Caption = "% Ýsk."
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
        Me.PanelControl7.Controls.Add(Me.sec_sIrsaliyeTipi)
        Me.PanelControl7.Controls.Add(Me.Label4)
        Me.PanelControl7.Controls.Add(Me.sec_irsaliye_kriter)
        Me.PanelControl7.Controls.Add(Me.Label5)
        Me.PanelControl7.Controls.Add(Me.SimpleButton7)
        Me.PanelControl7.Controls.Add(Me.Label6)
        Me.PanelControl7.Controls.Add(Me.DateEdit2)
        Me.PanelControl7.Controls.Add(Me.DateEdit1)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(1270, 40)
        Me.PanelControl7.TabIndex = 1
        '
        'sec_sIrsaliyeTipi
        '
        Me.sec_sIrsaliyeTipi.EditValue = "Alýnan"
        Me.sec_sIrsaliyeTipi.Location = New System.Drawing.Point(438, 9)
        Me.sec_sIrsaliyeTipi.Name = "sec_sIrsaliyeTipi"
        Me.sec_sIrsaliyeTipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sIrsaliyeTipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sIrsaliyeTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sIrsaliyeTipi.Properties.Items.AddRange(New Object() {"Alýnan", "Verilen"})
        Me.sec_sIrsaliyeTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sIrsaliyeTipi.Size = New System.Drawing.Size(72, 20)
        Me.sec_sIrsaliyeTipi.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(516, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Ýrsaliyeleri"
        '
        'sec_irsaliye_kriter
        '
        Me.sec_irsaliye_kriter.EditValue = "Açýk"
        Me.sec_irsaliye_kriter.Location = New System.Drawing.Point(352, 9)
        Me.sec_irsaliye_kriter.Name = "sec_irsaliye_kriter"
        Me.sec_irsaliye_kriter.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_irsaliye_kriter.Properties.Appearance.Options.UseBackColor = True
        Me.sec_irsaliye_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_irsaliye_kriter.Properties.Items.AddRange(New Object() {"[Tümü]", "Açýk", "Kapalý"})
        Me.sec_irsaliye_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_irsaliye_kriter.Size = New System.Drawing.Size(80, 20)
        Me.sec_irsaliye_kriter.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(112, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ve"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(594, 8)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton7.TabIndex = 30
        Me.SimpleButton7.Text = "&Oku"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(248, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tarihleri Arasýndaki"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(144, 9)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit2.TabIndex = 24
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2007, 2, 1, 0, 0, 0, 0)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(16, 9)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(88, 20)
        Me.DateEdit1.TabIndex = 23
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
        Me.DataColumn1.DataType = GetType(Long)
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
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "Sinif1"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "Sinif2"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "Sinif3"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "Sinif4"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "Sinif5"
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Ara,F3"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Yeni,Insert"
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
        Me.BarButtonItem3.Enabled = False
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Hesap Hareketleri,F7"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Stoklu Ekstre,Ctrl+S"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Stok Hareketleri,Ctrl+F7"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Bakiyesi,F6"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Notlar"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Ýletiþim,F8"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Firma Stoklarý"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Risk"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Satýn Alma Þartlarý"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Çýkýþ"
        Me.BarButtonItem14.Id = 13
        Me.BarButtonItem14.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem14.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'frm_cari_yonetimi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1276, 574)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cari_yonetimi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Ýþlemleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sNot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        Me.PanelControl7.PerformLayout()
        CType(Me.sec_sIrsaliyeTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_irsaliye_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public sKodu As String = ""
    Public nFirmaID = 0
    Public kullanici
    Public sModul As String = "Cari"
    Dim sFirmaAciklama As String = ""
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Dim ds_alis As DataSet
    Dim ds_siparis As DataSet
    Dim ds_irsaliye As DataSet
    Dim bLoad As Boolean = False
    Dim sLoadsKodu As String = ""
    Dim bKapat As Boolean = False
    Dim status As Boolean = False
    Public sDovizCinsi As String = ""
    Private Sub frm_cari_yonetimi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frm_cari_yonetimi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        sec_ekstre_tarih1.EditValue = "01/01/" + Today.Year.ToString
        sec_ekstre_tarih2.EditValue = "31/12/" + Today.Year.ToString
        DateEdit1.EditValue = "01/01/" + Today.Year.ToString
        DateEdit2.EditValue = "31/12/" + Today.Year.ToString
        If sModul = "Banka" Then
            XtraTabPage3.PageVisible = False
            XtraTabPage4.PageVisible = False
            btn_AlacaklarAcik.Visible = False
            btn_GenelHareketler.Visible = False
            btn_KapatBorc.Visible = False
            'btn_KapatAlacak.Visible = False
            btn_KapatSatis.Visible = False
        End If
        If sKodu = "0" Then
            musteri_sec()
        Else
            musteri_kontrol()
        End If
        'SpinEdit1.EditValue = GridView1.Appearance.Row.Font.Size
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView4.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim row As Object
        For Each row In VGrid_baslik.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In categoryFinansman.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In categoryTanýmlar.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In categoryEk_Bilgiler.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In categoryÝletiþim.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In categorySýnýflandýrma.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In categoryVergi_Bilgileri.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        SimpleButton7.Text = Sorgu_sDil(SimpleButton7.Text, sDil)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Function cari() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.*, tbFSinif1.sAciklama AS Sinif1, tbFSinif2.sAciklama AS Sinif2, tbFSinif3.sAciklama AS Sinif3, tbFSinif4.sAciklama AS Sinif4, tbFSinif5.sAciklama AS Sinif5, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT FROM tbFirma INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu  LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function hareket(ByVal musterikodu As String) As DataSet
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
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.nHareketID,tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS Bakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi,tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT nCekSenetID FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.sKodu LIKE '" & Trim(musterikodu) & "%' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu = '" & Trim(musterikodu) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078') ORDER BY tbFirmaHareketi.dteIslemTarihi ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.nHareketID,tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, Bakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi,tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT nCekSenetID FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '01/01/1900' AND tbFirma.sKodu LIKE '" & Trim(musterikodu) & "%' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu = '" & Trim(musterikodu) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078') ORDER BY tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.dteIslemTarihi ")
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
                    dr("sIslem") = "Alýþtan Ýade"
                ElseIf Trim(dr("sHangiUygulama")) = "DG" Then
                    dr("sIslem") = "StokÝadeEdilen"
                End If
            ElseIf dr("nGirisCikis") = 3 Then
            ElseIf dr("nGirisCikis") = 4 Then
                If Trim(dr("sHangiUygulama")) = "FS" Then
                    dr("sIslem") = "Satýþtan Ýade"
                ElseIf Trim(dr("sHangiUygulama")) = "DC" Then
                    dr("sIslem") = "StokÝadeAlýnan"
                End If
            End If
        Next
        colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
        If bDovizli = True Then
            GridView1.OptionsView.ShowFooter = False
            'printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.ReportFooter
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString & "(" & bakiye_status & ")"
            'collBorcTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'collAlacakTutar.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(0), 2).ToString
            'GridView1.UpdateSummary()
            colsDovizCinsi1.Visible = True
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
            colsDovizCinsi1.Group()
        Else
            'printlink1.SkipArea = DevExpress.XtraPrinting.BrickModifier.None
            GridView1.OptionsView.ShowFooter = True
            colBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
            GridView1.UpdateSummary()
            colsDovizCinsi1.Visible = False
            colsDovizCinsi1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
            colsDovizCinsi1.UnGroup()
        End If
        GridView1.ExpandAllGroups()
        Return Datastoklar1
    End Function
    Public Function siparisler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sSiparisTipi As String) As DataSet
        Dim kriter As String = ""
        Dim kriter2 = ""
        If sKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter2 = ""
        ElseIf secim = "Açýk" Then
            kriter2 = " WHERE lKalanMiktar > 0"
        ElseIf secim = "Kapalý" Then
            kriter2 = " WHERE lKalanMiktar = 0"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sSiparisTipi = "Verilen" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sSinifAciklama, sFirmaKodu, sFirmaAdi, sModel, sRenk, sRenkAdi, sBeden, sKavala, sAciklama, sSatirAciklama, dteIlkSevkiyatTarihi, sBirimCinsi, sSipNo, dteSiparisTarihi, dteTeslimtarihi, sSiparisIslem, SiparisMiktari, SiparisTutari, SiparisTutari1, SiparisTutari2, lSevkMiktari, lSevkTutari, lReserveMiktari - lSevkMiktari + lsevkIadeMiktari, lKalanMiktar, KalanTutar, sPartiKodu, lGirisMiktar, lGirisTutar, lEnvanterMiktar, lEnvanterTutar, lFarkMiktar, lFarkTutar, lKrediLimiti, nValorGun, cast(bKapandimi AS int) bKapandimi, lBirimFiyati, sDovizCinsi, lDovizKuru, lDovizFiyati, lSevkIadeMiktari, lSevkIadeTutari, lBakiye, lToplamRisk, lBirimFiyati1, lBirimFiyati2 FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, '' AS sKavala, tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))), 0) lSevkMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))), 0) lSevkTutari, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))), 0) lSevkIadeMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 2 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.sKodu, tbstok.sBeden, tbStok.sAciklama, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & " ORDER BY sFirmaKodu, sModel, sRenk, sBeden, sKavala ")
        ElseIf sSiparisTipi = "Alýnan" Then
            cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sSinifAciklama, sFirmaKodu, sFirmaAdi, sModel, sRenk, sRenkAdi, sBeden, sKavala, sAciklama, sSatirAciklama, dteIlkSevkiyatTarihi, sBirimCinsi, sSipNo, dteSiparisTarihi, dteTeslimtarihi, sSiparisIslem, SiparisMiktari, SiparisTutari, SiparisTutari1, SiparisTutari2, lSevkMiktari, lSevkTutari, lReserveMiktari - lSevkMiktari + lsevkIadeMiktari, lKalanMiktar, KalanTutar, sPartiKodu, lGirisMiktar, lGirisTutar, lEnvanterMiktar, lEnvanterTutar, lFarkMiktar, lFarkTutar, lKrediLimiti, nValorGun, cast(bKapandimi AS int) bKapandimi, lBirimFiyati, sDovizCinsi, lDovizKuru, lDovizFiyati, lSevkIadeMiktari, lSevkIadeTutari, lBakiye, lToplamRisk, lBirimFiyati1, lBirimFiyati2 FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, '' AS sKavala, tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 4))), 0) lSevkMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 4))), 0) lSevkTutari, isnull(abs(SUM(lCikisMiktar1 * (nGirisCikis - 3))), 0) lSevkIadeMiktari, isnull(abs(SUM(lCikisTutar * (nGirisCikis - 3))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 1 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.sKodu, tbstok.sBeden, tbStok.sAciklama, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & " ORDER BY sFirmaKodu, sModel, sRenk, sBeden, sKavala ")
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
        If sKodu.ToString <> "" Then
            kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        Else
            'kriter += " AND tbFirma.sKodu = '" & sKodu & "'"
        End If
        If secim = "[Tümü]" Then
            kriter2 = ""
        ElseIf secim = "Açýk" Then
            kriter2 = " WHERE lKalanMiktar > 0"
        ElseIf secim = "Kapalý" Then
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
        ElseIf sSiparisTipi = "Alýnan" Then
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
        If sIrsaliyeTipi = "Alýnan" Then
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
        ElseIf secim = "Açýk" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 0"
        ElseIf secim = "Kapalý" Then
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
        If sIrsaliyeTipi = "Alýnan" Then
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
        ElseIf secim = "Açýk" Then
            kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 0"
        ElseIf secim = "Kapalý" Then
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
    Private Sub dataload()
        XtraTabControl1.SelectedTabPageIndex = 0
        ds_baslik = cari()
        VGrid_baslik.DataSource = ds_baslik.Tables(0)
        VGrid_baslik.DataMember = Nothing
        Me.Text = sModul & " Hesap Kartý"
        If ds_baslik.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = ds_baslik.Tables(0).Rows(0)
            lbl_istihbarat.Text = dr("ISTIHBARAT").ToString
            'txt_sKodu.EditValue = Trim(dr("lkodu"))
            Me.Text += ": " + Trim(dr("sKodu").ToString) + " / "
            Me.Text += dr("sAciklama").ToString
            LabelControl1.Text = Trim(dr("sKodu").ToString) & vbCrLf
            LabelControl1.Text += Trim(dr("sAciklama").ToString)
            sFirmaAciklama = Trim(dr("sAciklama").ToString)
            If Trim(dr("ISTIHBARAT").ToString) <> "" Then
                XtraMessageBox.Show(Trim(dr("ISTIHBARAT").ToString), Sorgu_sDil("sDil", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If sLoadsKodu <> sKodu Then
                Dim nAlinanIrsaliye As Integer = 0
                Dim nVerilenIrsaliye As Integer = 0
                Dim sIrsaliyeSayi As String = ""
                nAlinanIrsaliye = irsaliyeler_sayi("01/01/1900", "31/12/2078", "Açýk", "Alýnan")
                nVerilenIrsaliye = irsaliyeler_sayi("01/01/1900", "31/12/2078", "Açýk", "Verilen")
                If nAlinanIrsaliye > 0 Then
                    sIrsaliyeSayi += " Faturalaþmamýþ Alýþ Irsaliye Sayisi : " & nAlinanIrsaliye
                End If
                If nVerilenIrsaliye > 0 Then
                    sIrsaliyeSayi += vbCrLf & " Faturalaþmamýþ Satýþ Irsaliye Sayisi : " & nVerilenIrsaliye
                End If
                If sIrsaliyeSayi <> "" Then
                    XtraMessageBox.Show(sIrsaliyeSayi & vbCrLf & Sorgu_sDil("Açýk Ýrsaliyeler Ýçin [Ýrsaliyeler] tabýndan Ýrsaliyelerinize Ulaþabilirsiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                nAlinanIrsaliye = Nothing
                nVerilenIrsaliye = Nothing
                sIrsaliyeSayi = Nothing
                Dim nAlinanSiparis As Integer = 0
                Dim nVerilenSiparis As Integer = 0
                Dim sSiparisSayi As String = ""
                nAlinanSiparis = siparisler_sayi("01/01/1900", "31/12/2078", "Açýk", "Alýnan")
                nVerilenSiparis = siparisler_sayi("01/01/1900", "31/12/2078", "Açýk", "Verilen")
                If nAlinanSiparis > 0 Then
                    sSiparisSayi += " Açýk Alýnan Sipariþ Sayisi : " & nAlinanSiparis
                End If
                If nVerilenSiparis > 0 Then
                    sSiparisSayi += vbCrLf & " Açýk Verilen Sipariþ Sayisi : " & nVerilenSiparis
                End If
                If sSiparisSayi <> "" Then
                    XtraMessageBox.Show(sSiparisSayi & vbCrLf & Sorgu_sDil("Açýk Sipariþler Ýçin [Sipariþler] tabýndan Sipariþlerinize Ulaþabilirsiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                nAlinanSiparis = Nothing
                nVerilenSiparis = Nothing
                sSiparisSayi = Nothing
                sLoadsKodu = sKodu
            End If
        Else
            lbl_istihbarat.Text = "*"
        End If
        ds_hareket = hareket(sKodu)
        Dim dataset2 As DataSet
        dataset2 = yekun("01/01/1900", "31/12/2078", True)
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            GridControl1.Focus()
        End If
        GridControl4.DataSource = dataset2.Tables(0)
        GridControl4.DataMember = Nothing
        GridView1.ExpandAllGroups()
        If sModul = "Banka" Then
            colsFirmaKodu.Caption = "Banka Kodu"
            colsFirmaAciklama.Caption = "Banka Adý"
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
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(lBorcTutar) AS lBorcTutar, SUM(lAlacakTutar) AS lAlacakTutar, SUM(lBakiye) AS lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1 , tbFirma.nFirmaID , lBorcTutar , lAlacakTutar , lBorcTutar - lAlacakTutar AS lBakiye FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu = '" & Trim(sKodu) & "')) TemDevir ")
        ElseIf bDovizli = True Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu LIKE '" & Trim(sKodu) & "%')) TemDevir GROUP BY sDovizCinsi1 ")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '" & dteIslemTarihi2 & "') AND (tbFirma.sKodu = '" & Trim(sKodu) & "')) TemDevir GROUP BY sDovizCinsi1 ")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_cari(ByVal kod As String, Optional ByVal no As Int64 = 0)
        Dim kriter
        If no = 0 Then
            kriter = "WHERE (sKodu = '" & kod & "') "
        Else
            kriter = "WHERE (nFirmaID = '" & no & "') "
        End If
        ds_cari = sorgu(sorgu_query("SELECT     nFirmaID AS IND, sKodu AS MUSTERIKODU, sAciklama AS MUSTERI FROM         tbFirma " & kriter & ""))
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
    Private Sub musteri_kontrol(Optional ByVal no As Int64 = 0)
        If Trim(txt_sKodu.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_sKodu.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                Try
                    ds_baslik.Clear()
                    ds_hareket.Clear()
                    ds_siparis.Clear()
                    ds_irsaliye.Clear()
                Catch ex As Exception
                End Try
                dataload_cari(txt_sKodu.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("MUSTERIKODU")
                    nFirmaID = dr("IND")
                    dataload()
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub musteri_kontrol_kayit(Optional ByVal no As Int64 = 0)
        If no = 0 Then
        Else
            Try
                ds_baslik.Clear()
                ds_hareket.Clear()
                ds_siparis.Clear()
                ds_irsaliye.Clear()
            Catch ex As Exception
            End Try
            dataload_cari("", no)
            Dim dr As DataRow
            For Each dr In ds_cari.Tables(0).Rows
                'txt_Musteri.EditValue = dr("MUSTERI")
                sKodu = dr("MUSTERIKODU")
                txt_sKodu.Text = sKodu
                nFirmaID = dr("IND")
                dataload()
            Next
            dr = Nothing
        End If
    End Sub
    Private Sub musteri_sec()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.sKodu = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.sModul = sModul
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            sDovizCinsi = sorgu_string(dr1("sDovizCinsi").ToString, "")
            txt_sKodu.EditValue = sKodu
            musteri_kontrol()
            bLoad = True
            bKapat = False
        Else
            If bLoad = False Then
                bKapat = True
                'Me.Close()
            End If
        End If
    End Sub
    Private Sub analiz_iletisim()
        If nFirmaID > 0 Then
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
        frm.sec_kriter.Text = "Baþlar"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.sec_kriter.Enabled = False
        frm.coldteTeslimTarihi.Caption = "SonTarih"
        'frm.txt_dteBordroTarihi.EditValue = dteSistemTarihi
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_cari_liste_acik()
        Dim frm As New frm_firma_liste_acik
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.DateEdit1.EditValue = "01/01/1900"
        frm.DateEdit2.EditValue = "31/12/2078"
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.sec_islem.Text = "Detaylý"
        frm.sec_bakiye.Text = "Alacaklar"
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbFirmaKapama_Toplu()
        Dim frm As New frm_tbFirmaKapama_Toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.sec_kriter.Text = "Baþlar"
        frm.GroupControl1.Enabled = False
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_Firma_karti()
        If nFirmaID > 0 Then
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = sKodu
            frm.nFirmaID = nFirmaID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub tbFirmaKapama(ByVal bBakiye As Boolean)
        If nFirmaID > 0 Then
            Dim frm As New frm_tbFirmaKapama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = sKodu
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
    Private Sub tbFirma(ByVal nFirmaID As Int64, ByVal yeni As Boolean)
        Dim frm As New frm_firma_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.yeni = yeni
        frm.nFirmaID = nFirmaID
        If yeni = True Then
            If KayitSiniri_kontrol("tbFirma", "", nKayitSinir) = True Then
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.Show()
                End If
            End If
        Else
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
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
        cmd.CommandTimeout = Nothing
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
    Private Sub analiz_cari_hareket()
        If nFirmaID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nFirmaId = nFirmaID
            frm.sKodu = sKodu
            frm.kullanici = kullanici
            frm.sFirmaAciklama = sFirmaAciklama
            frm.lbl_Firma.Text = sFirmaAciklama
            frm.txt_musteriNo.Text = sKodu
            frm.musterino = sKodu
            frm.sDovizCinsi = sDovizCinsi
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
            frm.sKodu = sKodu
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            frm.sFirmaAciklama = sFirmaAciklama
            frm.lbl_Firma.Text = sFirmaAciklama
            frm.txt_musteriNo.Text = sKodu
            frm.musterino = sKodu
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
    Private Sub analiz_stok_hareket()
        If nFirmaID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
    Private Sub analiz_cari_genel()
        If nFirmaID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_Genel
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = sKodu
            frm.txt_musteriNo.EditValue = sKodu
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub dataload_alis(ByVal ilktarih As DateTime, ByVal sontarih As DateTime, ByVal lFisno As String, ByVal nFirmaID As Int64)
        Dim kriter As String = ""
        kriter += " and tbStokFisiMaster.lFisNo = '" & lFisno & "' and tbFirma.nFirmaID = '" & nFirmaID & "'"
        'ds_alis = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CONVERT (char(10), tbStokFisiMaster.dteFisTarihi, 103) AS dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, CONVERT (char(1), tbStokFisiMaster.bFaturayaDonustumu) AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = 'FA') AND (tbStokFisiMaster.nGirisCikis = 1 OR tbStokFisiMaster.nGirisCikis = 2) AND (tbStokFisiMaster.dteFisTarihi BETWEEN '" & ilktarih & "' AND '" & sontarih & "') AND (tbStokFisiMaster.lFisNo BETWEEN 0 AND 999999999) AND (tbStokFisiMaster.lNetTutar BETWEEN - 999999999999.99 AND 999999999999.99) " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo"))
        ds_alis = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CONVERT (char(10), tbStokFisiMaster.dteFisTarihi, 103) AS dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, CONVERT (char(1), tbStokFisiMaster.bFaturayaDonustumu) AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = 'FA') AND (tbStokFisiMaster.nGirisCikis = 1 OR tbStokFisiMaster.nGirisCikis = 2) AND (tbStokFisiMaster.dteFisTarihi BETWEEN '" & ilktarih & "' AND '" & sontarih & "') AND (tbStokFisiMaster.lFisNo BETWEEN 0 AND 999999999) AND (tbStokFisiMaster.lNetTutar BETWEEN - 999999999999.99 AND 999999999999.99) " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo"))
    End Sub
    Private Sub analiz_alis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("IslemAciklama").ToString) = "FA" Or Trim(dr("IslemAciklama").ToString) = "FS" Or Trim(dr("IslemAciklama").ToString) = "HA" Or Trim(dr("IslemAciklama").ToString) = "HS" Or Trim(dr("IslemAciklama").ToString) = "DG" Or Trim(dr("IslemAciklama").ToString) = "DC" Then
                Dim frm As New frm_stok_cari_alis
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                Dim dr1 As DataRow
                dataload_alis(dr("dteIslemTarihi"), dr("dteIslemTarihi"), dr("lFisNo"), nFirmaID)
                dr1 = ds_alis.Tables(0).Rows(0)
                'frm.sKodu = dr("sKodu")
                frm.fisno = dr1("lFisNo")
                frm.tarih = dr1("dteFisTarihi")
                frm.fistipi = dr1("sFisTipi")
                frm.firmaID = dr1("nFirmaID")
                frm.ngiriscikis = dr1("nGirisCikis")
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
    Private Function carino_bul(ByVal carino As Integer, ByVal kriter As String, ByVal kriter2 As String) As Integer
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nFirmaID,0) AS IND  FROM tbFirma WHERE nFirmaID > 0 AND nFirmaID " & kriter & " " & carino & " ORDER BY IND " & kriter2 & "")
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub sonraki_kart()
        nFirmaID = carino_bul(nFirmaID, ">", "ASC")
        musteri_kontrol_kayit(nFirmaID)
    End Sub
    Private Sub onceki_kart()
        nFirmaID = carino_bul(nFirmaID, "<", "DESC")
        musteri_kontrol_kayit(nFirmaID)
    End Sub
    Private Sub son_kart()
        nFirmaID = carino_bul(nFirmaID, ">", "DESC")
        musteri_kontrol_kayit(nFirmaID)
    End Sub
    Private Sub musteri_notlari()
        Dim frm As New frm_musteri_karti_aciklama
        frm.firma = True
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = nFirmaID
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        dataload()
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
            frm.ShowDialog()
        End If
        dataload()
    End Sub
    Private Sub tbStokTedarikcisi()
        Dim frm As New frm_tbStokTedarik
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.nFirmaID = nFirmaID
        frm.sFirmaKodu = sKodu
        frm.sFirmaAciklama = sFirmaAciklama
        frm.lbl_Firma.Text = sFirmaAciklama
        frm.txt_musteriNo.Text = sKodu
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            If yetki_kontrol(kullanici, "frm_Cari_Hareket_Duzelt") = True Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
                        Dim satir = GridView1.FocusedRowHandle
                        dataload()
                        GridView1.FocusedRowHandle = satir
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
                        Dim satir As String = GridView1.FocusedRowHandle
                        dataload()
                        GridView1.FocusedRowHandle = satir
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
                    frm.sKodu = sKodu
                    frm.txt_musteriNo.Text = sKodu
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    frm.nHareketID = dr("nHareketID")
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        dataload()
                        GridView1.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "CG" Or Trim(dr("sHangiUygulama")) = "CC" Or Trim(dr("sHangiUygulama")) = "TCG" Or Trim(dr("sHangiUygulama")) = "TCC" Then
                    analiz_tbFirmaBordro(dr("nFirmaID"), dr("nHareketID"))
                    Dim satir As String = GridView1.FocusedRowHandle
                    dataload()
                    GridView1.FocusedRowHandle = satir
                    satir = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "KASA" Then
                    Dim frm As New frm_tbNakitKasa
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_dteIslemTarihi1.EditValue = dr("dteIslemTarihi")
                    frm.txt_dteIslemTarihi2.EditValue = dr("dteIslemTarihi")
                    frm.nHareketID = dr("nHareketID")
                    frm.sFirmaKodu = sKodu
                    frm.nFirmaid = nFirmaID
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        dataload()
                        GridView1.FocusedRowHandle = satir
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
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow
            Dim ds_tbFirmaBordroMaster As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaBordroMaster.nBordroID, tbFirmaBordroMaster.dteBordroTarihi, tbFirmaBordroMaster.lBordroNo, tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster ON tbFirmaBordroDetay.nBordroID = tbFirmaBordroMaster.nBordroID WHERE (tbFirmaBordroDetay.nFirmaID = " & nFirmaID & ") and (tbFirmaBordroDetay.nHareketID = " & nHareketID & ")"))
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
                    Dim satir As String = GridView1.FocusedRowHandle
                    GridView1.FocusedRowHandle = satir
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
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
    Private Sub irsaliye_duzelt()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
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
            Dim satir = GridView3.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub dataload_siparis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sSiparisTipi As String)
        ds_siparis = siparisler(tarih1, tarih2, secim, sSiparisTipi)
        GridControl2.DataSource = ds_siparis.Tables(0)
        GridControl2.DataMember = Nothing
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub dataload_irsaliye(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal secim As String, ByVal sIrsaliyeTipi As String)
        ds_irsaliye = irsaliyeler(tarih1, tarih2, secim, sIrsaliyeTipi)
        GridControl3.DataSource = ds_irsaliye.Tables(0)
        GridControl3.DataMember = Nothing
        GridControl3.Focus()
        GridControl3.Select()
    End Sub
    Private Sub txt_sKodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sKodu.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        End If
    End Sub
    Private Sub txt_sKodu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sKodu.ButtonClick
        musteri_sec()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        musteri_sec()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_iletisim()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        analiz_iletisim()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        fis_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        ElseIf e.KeyCode = Keys.F4 Then
            fis_duzelt()
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        musteri_notlari()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        dataload_siparis(sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue, sec_kriter.Text, sec_sSiparisTipi.Text)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        sonraki_kart()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        onceki_kart()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        sonraki_kart()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        onceki_kart()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        son_kart()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        musteri_notlari()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekraný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Close()
            End If
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        analiz_Firma_karti()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        gorunum_kaydet()
    End Sub
    Private Sub SpinEdit1_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If sKodu = "0" Then
            musteri_sec()
        Else
            musteri_kontrol()
        End If
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        dataload_irsaliye(DateEdit1.EditValue, DateEdit2.EditValue, sec_irsaliye_kriter.Text, sec_sIrsaliyeTipi.Text)
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        tbFirmaHareketi()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        tbStokTedarikcisi()
    End Sub
    Private Sub GridView3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView3.KeyDown
        If e.KeyCode = Keys.Enter Then
            irsaliye_duzelt()
        End If
    End Sub
    Private Sub GridControl3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl3.DoubleClick
        irsaliye_duzelt()
    End Sub
    Private Sub VGrid_baslik_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGrid_baslik.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekraný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        tbFirma(0, True)
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        musteri_sec()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_cari_bakiye()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        musteri_notlari()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbStokTedarikcisi()
    End Sub
    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KapatBorc.Click
        tbFirmaKapama(False)
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        analiz_risk()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        tbSiparis_bekleyen(3, sKodu)
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Ekraný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AlacaklarAcik.Click
        analiz_cari_liste_acik()
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_KapatSatis.Click
        tbFirmaKapama_Toplu()
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GenelHareketler.Click
        analiz_cari_genel()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl4.Focus()
            GridControl4.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            GridControl2.Focus()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            GridControl3.Focus()
            GridControl3.Select()
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If MenuItem17.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem17.Checked = True
        ElseIf MenuItem17.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem17.Checked = False
        End If
    End Sub
End Class
