Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_perakende
    Inherits DevExpress.XtraEditors.XtraForm

    ' === PERAKENDE RISK GOSTERGESI ===
    Private pnlPerakendeRisk As Panel
    Private lblPerakendeRisk As Label
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
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Panel_Baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_Taksitler As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSatisYapilamaz As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents ýmageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sMagaza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_dteKayitTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nMusteriID As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_sSoyadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sEvTelefonu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvAdresi2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvAdresi1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sGSM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sVergiNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sVergiDairesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteSonKullanmaTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_dteKrediLimitiTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_dteKrediAcilisTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_lKrediLimiti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lGeciken As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBakiye As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sUnvan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nIskontoPesin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nIskontoKredili As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_Musteri As System.Data.DataSet
    Friend WithEvents DataTable7 As System.Data.DataTable
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
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents txt_sDogumYeri As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteDogumTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteEvlilikTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_bEvlimi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lAylikGelir As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sEhliyetNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panel_bilgi As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Analiz_Satislar_Bekleyen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Kalan_Taksitler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Kalan_Satislar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Satislar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Analiz_Odemeler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Ekstre_Ozet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Raporlar_Ekstre_Detayli As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Islem_VadeAyarla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_Teslimat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_VadeFarki As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_Odeme_Al As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_Siparis_Pesin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_Siparis_Kredili As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_Satis_Pesin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Islem_Satis_Kredili As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Musteri_Sozlesme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_Duzelt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_Not As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_Kart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_Yeni As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Musteri_sec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTAHSILAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAGAZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASIYER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Odemeler As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colsYil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_sCuzdanKayitNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_sKefil2Kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents txt_sKefil1Kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_sKefil2Aciklama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKefil1Aciklama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_KimlikTara As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_sKefil4Kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_sKefil3Kod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_sKefil4Aciklama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKefil3Aciklama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_KartNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Panel_islem As DevExpress.XtraEditors.PanelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perakende))
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colGEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel_Kasiyer = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
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
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.Panel_Baslik = New DevExpress.XtraEditors.PanelControl()
        Me.txt_KartNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.ds_Musteri = New System.Data.DataSet()
        Me.DataTable7 = New System.Data.DataTable()
        Me.DataColumn102 = New System.Data.DataColumn()
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
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKefil4Kod = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_sKefil3Kod = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_sKefil4Aciklama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKefil3Aciklama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKefil2Kod = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_sKefil1Kod = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_sKefil2Aciklama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKefil1Aciklama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sCuzdanKayitNo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sEhliyetNo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nIskontoKredili = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_lAylikGelir = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sDogumYeri = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteDogumTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteEvlilikTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lKrediLimiti = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nIskontoPesin = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteSonKullanmaTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.txt_dteKrediLimitiTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lGeciken = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lBakiye = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sUnvan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
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
        Me.txt_sEvTelefonu = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sEvAdresi2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sEvAdresi1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sSoyadi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sMagaza = New DevExpress.XtraEditors.TextEdit()
        Me.txt_dteKayitTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nMusteriID = New DevExpress.XtraEditors.ButtonEdit()
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
        Me.txt_dteKrediAcilisTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.txt_bEvlimi = New DevExpress.XtraEditors.CheckEdit()
        Me.Panel_Taksitler = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldteTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_Odemeler = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ds_sinif = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbSatisYapilamaz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
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
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTAHSILAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAGAZA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASIYER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAYIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ýmageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ds_taksitler = New System.Data.DataSet()
        Me.Panel_islem = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Satislar_Bekleyen = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Kalan_Taksitler = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Kalan_Satislar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Satislar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Analiz_Odemeler = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_Ekstre_Ozet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Raporlar_Ekstre_Detayli = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_VadeAyarla = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_Teslimat = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_VadeFarki = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_Odeme_Al = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_Siparis_Pesin = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_Siparis_Kredili = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_Satis_Pesin = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Islem_Satis_Kredili = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_KimlikTara = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Sozlesme = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Duzelt = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Not = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Kart = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_Yeni = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Musteri_sec = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_bilgi = New DevExpress.XtraEditors.PanelControl()
        CType(Me.Panel_Kasiyer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Kasiyer.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Baslik.SuspendLayout()
        CType(Me.txt_KartNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_Musteri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil4Kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil3Kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil4Aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil3Aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil2Kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil1Kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil2Aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKefil1Aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sCuzdanKayitNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEhliyetNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskontoKredili.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lAylikGelir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sDogumYeri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteDogumTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteDogumTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteEvlilikTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteEvlilikTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lKrediLimiti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskontoPesin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSonKullanmaTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteSonKullanmaTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKrediLimitiTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKrediLimitiTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lGeciken.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lBakiye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sUnvan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvTelefonu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvAdresi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvAdresi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKayitTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKayitTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nMusteriID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Ara.SuspendLayout()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bakiyeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKrediAcilisTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteKrediAcilisTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bEvlimi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Taksitler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Taksitler.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_sinif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_odemeler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.colGEC.Width = 47
        '
        'Panel_Kasiyer
        '
        Me.Panel_Kasiyer.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel_Kasiyer.Appearance.Options.UseBackColor = True
        Me.Panel_Kasiyer.Controls.Add(Me.LabelControl35)
        Me.Panel_Kasiyer.Controls.Add(Me.TextEdit1)
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
        Me.Panel_Kasiyer.Size = New System.Drawing.Size(1365, 63)
        Me.Panel_Kasiyer.TabIndex = 1
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(384, 34)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(66, 19)
        Me.LabelControl35.TabIndex = 42
        Me.LabelControl35.Text = "Hýzlý Ara:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(464, 30)
        Me.TextEdit1.MenuManager = Me.BarManager1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(234, 26)
        Me.TextEdit1.TabIndex = 41
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
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 26
        Me.BarManager1.StatusBar = Me.Bar3
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
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23)})
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
        Me.BarButtonItem19.Caption = "Müþteri Kartý Sil"
        Me.BarButtonItem19.Id = 19
        Me.BarButtonItem19.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Müþteri Gir"
        Me.BarButtonItem18.Id = 18
        Me.BarButtonItem18.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Müþteri Seç"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Müþteri Kartý"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Açýklama"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Müþteri Düzenle"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Kredili Satýþ"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Peþin Satýþ"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Ödeme"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Vade Farký Ödeme"
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Slip Satýþ"
        Me.BarButtonItem11.Id = 11
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Vade Ayarla"
        Me.BarButtonItem22.Id = 22
        Me.BarButtonItem22.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Taksit Durumu"
        Me.BarButtonItem12.Id = 12
        Me.BarButtonItem12.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F8))
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Ekstre"
        Me.BarButtonItem13.Id = 13
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F8))
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Yapýlan Ödemeler"
        Me.BarButtonItem14.Id = 14
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F5))
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Yapýlan Satýþlar"
        Me.BarButtonItem15.Id = 15
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F6))
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Kalan Ödemeler"
        Me.BarButtonItem16.Id = 16
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Kalan Taksitler"
        Me.BarButtonItem17.Id = 17
        Me.BarButtonItem17.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F7))
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Karlýlýk Akýþ Tablosu"
        Me.BarButtonItem24.Id = 24
        Me.BarButtonItem24.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Alýnan Peþinatlar"
        Me.BarButtonItem25.Id = 25
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Masraflar"
        Me.BarButtonItem20.Id = 20
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Çýkýþ"
        Me.BarButtonItem23.Id = 23
        Me.BarButtonItem23.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status"
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1365, 32)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1008)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1365, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 32)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 976)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1365, 32)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 976)
        '
        'sec_magaza
        '
        Me.sec_magaza.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sec_magaza.Location = New System.Drawing.Point(1130, 36)
        Me.sec_magaza.Name = "sec_magaza"
        Me.sec_magaza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_magaza.Properties.Appearance.Options.UseFont = True
        Me.sec_magaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_magaza.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açýklama")})
        Me.sec_magaza.Properties.DisplayMember = "sAciklama"
        Me.sec_magaza.Properties.NullText = "[Maðaza]"
        Me.sec_magaza.Properties.ReadOnly = True
        Me.sec_magaza.Properties.ValueMember = "sDepo"
        Me.sec_magaza.Size = New System.Drawing.Size(215, 28)
        Me.sec_magaza.TabIndex = 11
        Me.sec_magaza.ToolTip = "Çalýþýlan Maðaza"
        '
        'sec_kasa
        '
        Me.sec_kasa.Location = New System.Drawing.Point(90, 31)
        Me.sec_kasa.Name = "sec_kasa"
        Me.sec_kasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasa.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nKasaNo", 5, "KasaNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", 40, "Açýklama")})
        Me.sec_kasa.Properties.DisplayMember = "nKasaNo"
        Me.sec_kasa.Properties.NullText = "[Kasa]"
        Me.sec_kasa.Properties.ValueMember = "nKasaNo"
        Me.sec_kasa.Size = New System.Drawing.Size(192, 26)
        Me.sec_kasa.TabIndex = 10
        Me.sec_kasa.ToolTip = "Çalýþýlan Kasa Numarasý"
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(1130, 4)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.NullText = "[Tarih]"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(215, 28)
        Me.DateEdit1.TabIndex = 8
        Me.DateEdit1.ToolTip = "Aktif Ýþlem Tarihi"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(1041, 36)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(71, 21)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Maðaza:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(1053, 4)
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
        ToolTipTitleItem8.Text = "Kasiyer/Yetkili"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Ýþlem Yapabilmek için Yetkili Personel Þifresini Girmeniz Gerekmektedir."
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.txt_kasiyer_kod.SuperTip = SuperToolTip8
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
        'ToolTipController1
        '
        Me.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        '
        'Panel_Baslik
        '
        Me.Panel_Baslik.Appearance.BackColor = System.Drawing.Color.Silver
        Me.Panel_Baslik.Appearance.Options.UseBackColor = True
        Me.Panel_Baslik.Controls.Add(Me.txt_KartNo)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl36)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil4Kod)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil3Kod)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil4Aciklama)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl33)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil3Aciklama)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl34)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil2Kod)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil1Kod)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil2Aciklama)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl28)
        Me.Panel_Baslik.Controls.Add(Me.txt_sKefil1Aciklama)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl7)
        Me.Panel_Baslik.Controls.Add(Me.txt_sCuzdanKayitNo)
        Me.Panel_Baslik.Controls.Add(Me.txt_sEhliyetNo)
        Me.Panel_Baslik.Controls.Add(Me.txt_nIskontoKredili)
        Me.Panel_Baslik.Controls.Add(Me.txt_lAylikGelir)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl31)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl30)
        Me.Panel_Baslik.Controls.Add(Me.txt_sDogumYeri)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl26)
        Me.Panel_Baslik.Controls.Add(Me.txt_dteDogumTarihi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl27)
        Me.Panel_Baslik.Controls.Add(Me.txt_dteEvlilikTarihi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl29)
        Me.Panel_Baslik.Controls.Add(Me.txt_lKrediLimiti)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl25)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl24)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl23)
        Me.Panel_Baslik.Controls.Add(Me.txt_nIskontoPesin)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl17)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl20)
        Me.Panel_Baslik.Controls.Add(Me.txt_dteSonKullanmaTarihi)
        Me.Panel_Baslik.Controls.Add(Me.txt_dteKrediLimitiTarihi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl14)
        Me.Panel_Baslik.Controls.Add(Me.txt_lGeciken)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl15)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl16)
        Me.Panel_Baslik.Controls.Add(Me.txt_lBakiye)
        Me.Panel_Baslik.Controls.Add(Me.txt_sUnvan)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl13)
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
        Me.Panel_Baslik.Controls.Add(Me.txt_sEvTelefonu)
        Me.Panel_Baslik.Controls.Add(Me.txt_sEvAdresi2)
        Me.Panel_Baslik.Controls.Add(Me.txt_sEvAdresi1)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl21)
        Me.Panel_Baslik.Controls.Add(Me.txt_sSoyadi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl10)
        Me.Panel_Baslik.Controls.Add(Me.txt_sAdi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl11)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl8)
        Me.Panel_Baslik.Controls.Add(Me.txt_sMagaza)
        Me.Panel_Baslik.Controls.Add(Me.txt_dteKayitTarihi)
        Me.Panel_Baslik.Controls.Add(Me.LabelControl3)
        Me.Panel_Baslik.Controls.Add(Me.txt_nMusteriID)
        Me.Panel_Baslik.Controls.Add(Me.Panel_Ara)
        Me.Panel_Baslik.Controls.Add(Me.txt_dteKrediAcilisTarihi)
        Me.Panel_Baslik.Controls.Add(Me.txt_bEvlimi)
        Me.Panel_Baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Baslik.Enabled = False
        Me.Panel_Baslik.Location = New System.Drawing.Point(2, 2)
        Me.Panel_Baslik.Name = "Panel_Baslik"
        Me.Panel_Baslik.Size = New System.Drawing.Size(1091, 398)
        Me.Panel_Baslik.TabIndex = 0
        '
        'txt_KartNo
        '
        Me.txt_KartNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.KartNo", True))
        Me.txt_KartNo.Location = New System.Drawing.Point(123, 67)
        Me.txt_KartNo.MenuManager = Me.BarManager1
        Me.txt_KartNo.Name = "txt_KartNo"
        Me.txt_KartNo.Properties.ReadOnly = True
        Me.txt_KartNo.Size = New System.Drawing.Size(272, 26)
        Me.txt_KartNo.TabIndex = 123
        '
        'ds_Musteri
        '
        Me.ds_Musteri.DataSetName = "NewDataSet"
        Me.ds_Musteri.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_Musteri.Tables.AddRange(New System.Data.DataTable() {Me.DataTable7})
        '
        'DataTable7
        '
        Me.DataTable7.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn102, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn96, Me.DataColumn97, Me.DataColumn98, Me.DataColumn99, Me.DataColumn100, Me.DataColumn101, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.DataTable7.TableName = "Table1"
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "KartNo"
        Me.DataColumn102.DataType = GetType(Long)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "nMusteriID"
        Me.DataColumn56.DataType = GetType(Long)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sMagaza"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "lKodu"
        Me.DataColumn58.DataType = GetType(Long)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "sAdi"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "sSoyadi"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "nCinsiyet"
        Me.DataColumn61.DataType = GetType(Long)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "lAylikGelir"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "dteKartAcilisTarihi"
        Me.DataColumn63.DataType = GetType(Date)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "nIskontoPesin"
        Me.DataColumn64.DataType = GetType(Decimal)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "nIskontoKredili"
        Me.DataColumn65.DataType = GetType(Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "sUnvan"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "sVergiDairesi"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "sVergiNo"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "bYazismaEvAdresinemi"
        Me.DataColumn69.DataType = GetType(Boolean)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "sEmail"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "sIsYeriAdi"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "sIsAdresi1"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "sIsAdresi2"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "sIsSemt"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "sIsIl"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "sIsPostaKodu"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "sIsTelefonu"
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "sEvAdresi1"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "sEvAdresi2"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "sEvSemt"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "sEvPostaKodu"
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "sEvIl"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "sEvTelefonu"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "sSigortaNo"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "bEvlimi"
        Me.DataColumn85.DataType = GetType(Boolean)
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "dteEvlilikTarihi"
        Me.DataColumn86.DataType = GetType(Date)
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "dteDogumTarihi"
        Me.DataColumn87.DataType = GetType(Date)
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "sDogumYeri"
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "sEhliyetNo"
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "sKanGrubu"
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "sHitap"
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "sKullaniciAdi"
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "dteKayitTarihi"
        Me.DataColumn93.DataType = GetType(Date)
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "sAciklama1"
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "sAciklama2"
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "sAciklama3"
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "sAciklama4"
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "sAciklama5"
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "sGSM"
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "sFax"
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "sResimAdi"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lKrediLimiti"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "kredidteKayitTarihi"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "lBakiye"
        Me.DataColumn15.DataType = GetType(Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lGeciken"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "dteSonKullanmaTarihi"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "dteKrediAcilisTarihi"
        Me.DataColumn18.DataType = GetType(Date)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sCuzdanKayitNo"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sKefil1Kod"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sKefil1Aciklama"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sKefil2Kod"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sKefil2Aciklama"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sKefil3Kod"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sKefil3Aciklama"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sKefil4Kod"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sKefil4Aciklama"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl36.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl36.Location = New System.Drawing.Point(50, 73)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(59, 19)
        Me.LabelControl36.TabIndex = 122
        Me.LabelControl36.Text = "Kart No:"
        '
        'txt_sKefil4Kod
        '
        Me.txt_sKefil4Kod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil4Kod", True))
        Me.txt_sKefil4Kod.Location = New System.Drawing.Point(494, 327)
        Me.txt_sKefil4Kod.MenuManager = Me.BarManager1
        Me.txt_sKefil4Kod.Name = "txt_sKefil4Kod"
        Me.txt_sKefil4Kod.Properties.ReadOnly = True
        Me.txt_sKefil4Kod.Size = New System.Drawing.Size(64, 26)
        Me.txt_sKefil4Kod.TabIndex = 120
        '
        'txt_sKefil3Kod
        '
        Me.txt_sKefil3Kod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil3Kod", True))
        Me.txt_sKefil3Kod.Location = New System.Drawing.Point(123, 361)
        Me.txt_sKefil3Kod.MenuManager = Me.BarManager1
        Me.txt_sKefil3Kod.Name = "txt_sKefil3Kod"
        Me.txt_sKefil3Kod.Properties.ReadOnly = True
        Me.txt_sKefil3Kod.Size = New System.Drawing.Size(95, 26)
        Me.txt_sKefil3Kod.TabIndex = 119
        '
        'txt_sKefil4Aciklama
        '
        Me.txt_sKefil4Aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil4Aciklama", True))
        Me.txt_sKefil4Aciklama.EnterMoveNextControl = True
        Me.txt_sKefil4Aciklama.Location = New System.Drawing.Point(555, 327)
        Me.txt_sKefil4Aciklama.Name = "txt_sKefil4Aciklama"
        Me.txt_sKefil4Aciklama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sKefil4Aciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sKefil4Aciklama.Properties.Appearance.Options.UseFont = True
        Me.txt_sKefil4Aciklama.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sKefil4Aciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil4Aciklama.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil4Aciklama.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil4Aciklama.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil4Aciklama.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil4Aciklama.Properties.MaxLength = 60
        Me.txt_sKefil4Aciklama.Properties.ReadOnly = True
        Me.txt_sKefil4Aciklama.Size = New System.Drawing.Size(160, 28)
        Me.txt_sKefil4Aciklama.TabIndex = 117
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl33.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl33.Location = New System.Drawing.Point(437, 331)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl33.TabIndex = 118
        Me.LabelControl33.Text = "Kefil4:"
        '
        'txt_sKefil3Aciklama
        '
        Me.txt_sKefil3Aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil3Aciklama", True))
        Me.txt_sKefil3Aciklama.EnterMoveNextControl = True
        Me.txt_sKefil3Aciklama.Location = New System.Drawing.Point(218, 361)
        Me.txt_sKefil3Aciklama.Name = "txt_sKefil3Aciklama"
        Me.txt_sKefil3Aciklama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sKefil3Aciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sKefil3Aciklama.Properties.Appearance.Options.UseFont = True
        Me.txt_sKefil3Aciklama.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sKefil3Aciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil3Aciklama.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil3Aciklama.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil3Aciklama.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil3Aciklama.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil3Aciklama.Properties.MaxLength = 60
        Me.txt_sKefil3Aciklama.Properties.ReadOnly = True
        Me.txt_sKefil3Aciklama.Size = New System.Drawing.Size(177, 28)
        Me.txt_sKefil3Aciklama.TabIndex = 115
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl34.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl34.Location = New System.Drawing.Point(66, 366)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl34.TabIndex = 116
        Me.LabelControl34.Text = "Kefil3:"
        '
        'txt_sKefil2Kod
        '
        Me.txt_sKefil2Kod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil2Kod", True))
        Me.txt_sKefil2Kod.Location = New System.Drawing.Point(494, 299)
        Me.txt_sKefil2Kod.MenuManager = Me.BarManager1
        Me.txt_sKefil2Kod.Name = "txt_sKefil2Kod"
        Me.txt_sKefil2Kod.Properties.ReadOnly = True
        Me.txt_sKefil2Kod.Size = New System.Drawing.Size(64, 26)
        Me.txt_sKefil2Kod.TabIndex = 114
        '
        'txt_sKefil1Kod
        '
        Me.txt_sKefil1Kod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil1Kod", True))
        Me.txt_sKefil1Kod.Location = New System.Drawing.Point(123, 333)
        Me.txt_sKefil1Kod.MenuManager = Me.BarManager1
        Me.txt_sKefil1Kod.Name = "txt_sKefil1Kod"
        Me.txt_sKefil1Kod.Properties.ReadOnly = True
        Me.txt_sKefil1Kod.Size = New System.Drawing.Size(95, 26)
        Me.txt_sKefil1Kod.TabIndex = 113
        '
        'txt_sKefil2Aciklama
        '
        Me.txt_sKefil2Aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil2Aciklama", True))
        Me.txt_sKefil2Aciklama.EnterMoveNextControl = True
        Me.txt_sKefil2Aciklama.Location = New System.Drawing.Point(555, 299)
        Me.txt_sKefil2Aciklama.Name = "txt_sKefil2Aciklama"
        Me.txt_sKefil2Aciklama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sKefil2Aciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sKefil2Aciklama.Properties.Appearance.Options.UseFont = True
        Me.txt_sKefil2Aciklama.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sKefil2Aciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil2Aciklama.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil2Aciklama.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil2Aciklama.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil2Aciklama.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil2Aciklama.Properties.MaxLength = 60
        Me.txt_sKefil2Aciklama.Properties.ReadOnly = True
        Me.txt_sKefil2Aciklama.Size = New System.Drawing.Size(160, 28)
        Me.txt_sKefil2Aciklama.TabIndex = 111
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl28.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl28.Location = New System.Drawing.Point(437, 303)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl28.TabIndex = 112
        Me.LabelControl28.Text = "Kefil2:"
        '
        'txt_sKefil1Aciklama
        '
        Me.txt_sKefil1Aciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sKefil1Aciklama", True))
        Me.txt_sKefil1Aciklama.EnterMoveNextControl = True
        Me.txt_sKefil1Aciklama.Location = New System.Drawing.Point(218, 333)
        Me.txt_sKefil1Aciklama.Name = "txt_sKefil1Aciklama"
        Me.txt_sKefil1Aciklama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sKefil1Aciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sKefil1Aciklama.Properties.Appearance.Options.UseFont = True
        Me.txt_sKefil1Aciklama.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sKefil1Aciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil1Aciklama.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKefil1Aciklama.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKefil1Aciklama.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKefil1Aciklama.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKefil1Aciklama.Properties.MaxLength = 60
        Me.txt_sKefil1Aciklama.Properties.ReadOnly = True
        Me.txt_sKefil1Aciklama.Size = New System.Drawing.Size(177, 28)
        Me.txt_sKefil1Aciklama.TabIndex = 109
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(66, 337)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl7.TabIndex = 110
        Me.LabelControl7.Text = "Kefil1:"
        '
        'txt_sCuzdanKayitNo
        '
        Me.txt_sCuzdanKayitNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sCuzdanKayitNo", True))
        Me.txt_sCuzdanKayitNo.EnterMoveNextControl = True
        Me.txt_sCuzdanKayitNo.Location = New System.Drawing.Point(494, 156)
        Me.txt_sCuzdanKayitNo.Name = "txt_sCuzdanKayitNo"
        Me.txt_sCuzdanKayitNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sCuzdanKayitNo.Properties.Appearance.Options.UseFont = True
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sCuzdanKayitNo.Properties.MaxLength = 60
        Me.txt_sCuzdanKayitNo.Properties.ReadOnly = True
        Me.txt_sCuzdanKayitNo.Size = New System.Drawing.Size(221, 28)
        Me.txt_sCuzdanKayitNo.TabIndex = 108
        '
        'txt_sEhliyetNo
        '
        Me.txt_sEhliyetNo.EnterMoveNextControl = True
        Me.txt_sEhliyetNo.Location = New System.Drawing.Point(806, 270)
        Me.txt_sEhliyetNo.Name = "txt_sEhliyetNo"
        Me.txt_sEhliyetNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEhliyetNo.Properties.Appearance.Options.UseFont = True
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEhliyetNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEhliyetNo.Properties.MaxLength = 60
        Me.txt_sEhliyetNo.Size = New System.Drawing.Size(63, 24)
        Me.txt_sEhliyetNo.TabIndex = 27
        Me.txt_sEhliyetNo.ToolTip = "5 Karakterden Küçükse FiyatTipi , 5 Karakterden Büyükise EhliyetNo olarak algýlan" &
    "maktadýr."
        Me.txt_sEhliyetNo.ToolTipTitle = "FiyatTipi/EhliyetNo"
        '
        'txt_nIskontoKredili
        '
        Me.txt_nIskontoKredili.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.nIskontoKredili", True))
        Me.txt_nIskontoKredili.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskontoKredili.EnterMoveNextControl = True
        Me.txt_nIskontoKredili.Location = New System.Drawing.Point(806, 241)
        Me.txt_nIskontoKredili.Name = "txt_nIskontoKredili"
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskontoKredili.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskontoKredili.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskontoKredili.Properties.ReadOnly = True
        Me.txt_nIskontoKredili.Size = New System.Drawing.Size(63, 26)
        Me.txt_nIskontoKredili.TabIndex = 25
        '
        'txt_lAylikGelir
        '
        Me.txt_lAylikGelir.EnterMoveNextControl = True
        Me.txt_lAylikGelir.Location = New System.Drawing.Point(912, 270)
        Me.txt_lAylikGelir.Name = "txt_lAylikGelir"
        Me.txt_lAylikGelir.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAylikGelir.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAylikGelir.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lAylikGelir.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lAylikGelir.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lAylikGelir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lAylikGelir.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.txt_lAylikGelir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lAylikGelir.Size = New System.Drawing.Size(112, 26)
        Me.txt_lAylikGelir.TabIndex = 28
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl31.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl31.Location = New System.Drawing.Point(733, 270)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(66, 19)
        Me.LabelControl31.TabIndex = 107
        Me.LabelControl31.Text = "FiyatTipi:"
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl30.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl30.Location = New System.Drawing.Point(874, 270)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(39, 19)
        Me.LabelControl30.TabIndex = 105
        Me.LabelControl30.Text = "Gelir:"
        '
        'txt_sDogumYeri
        '
        Me.txt_sDogumYeri.EnterMoveNextControl = True
        Me.txt_sDogumYeri.Location = New System.Drawing.Point(123, 304)
        Me.txt_sDogumYeri.Name = "txt_sDogumYeri"
        Me.txt_sDogumYeri.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDogumYeri.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDogumYeri.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sDogumYeri.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sDogumYeri.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sDogumYeri.Properties.MaxLength = 60
        Me.txt_sDogumYeri.Properties.ReadOnly = True
        Me.txt_sDogumYeri.Size = New System.Drawing.Size(272, 26)
        Me.txt_sDogumYeri.TabIndex = 9
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl26.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl26.Location = New System.Drawing.Point(27, 304)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl26.TabIndex = 103
        Me.LabelControl26.Text = "DoðumYeri:"
        '
        'txt_dteDogumTarihi
        '
        Me.txt_dteDogumTarihi.EditValue = Nothing
        Me.txt_dteDogumTarihi.EnterMoveNextControl = True
        Me.txt_dteDogumTarihi.Location = New System.Drawing.Point(123, 276)
        Me.txt_dteDogumTarihi.Name = "txt_dteDogumTarihi"
        Me.txt_dteDogumTarihi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_dteDogumTarihi.Properties.Appearance.Options.UseFont = True
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteDogumTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteDogumTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteDogumTarihi.Properties.ReadOnly = True
        Me.txt_dteDogumTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteDogumTarihi.Size = New System.Drawing.Size(272, 28)
        Me.txt_dteDogumTarihi.TabIndex = 8
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl27.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl27.Location = New System.Drawing.Point(14, 276)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl27.TabIndex = 102
        Me.LabelControl27.Text = "DoðumTarihi:"
        '
        'txt_dteEvlilikTarihi
        '
        Me.txt_dteEvlilikTarihi.EditValue = Nothing
        Me.txt_dteEvlilikTarihi.EnterMoveNextControl = True
        Me.txt_dteEvlilikTarihi.Location = New System.Drawing.Point(555, 270)
        Me.txt_dteEvlilikTarihi.Name = "txt_dteEvlilikTarihi"
        Me.txt_dteEvlilikTarihi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_dteEvlilikTarihi.Properties.Appearance.Options.UseFont = True
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteEvlilikTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteEvlilikTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteEvlilikTarihi.Properties.ReadOnly = True
        Me.txt_dteEvlilikTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteEvlilikTarihi.Size = New System.Drawing.Size(160, 28)
        Me.txt_dteEvlilikTarihi.TabIndex = 18
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl29.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl29.Location = New System.Drawing.Point(400, 270)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl29.TabIndex = 100
        Me.LabelControl29.Text = "MedeniHali:"
        '
        'txt_lKrediLimiti
        '
        Me.txt_lKrediLimiti.EnterMoveNextControl = True
        Me.txt_lKrediLimiti.Location = New System.Drawing.Point(806, 127)
        Me.txt_lKrediLimiti.Name = "txt_lKrediLimiti"
        Me.txt_lKrediLimiti.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lKrediLimiti.Properties.Appearance.Options.UseFont = True
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lKrediLimiti.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lKrediLimiti.Properties.ReadOnly = True
        Me.txt_lKrediLimiti.Size = New System.Drawing.Size(218, 28)
        Me.txt_lKrediLimiti.TabIndex = 21
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl25.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl25.Location = New System.Drawing.Point(739, 213)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(60, 19)
        Me.LabelControl25.TabIndex = 95
        Me.LabelControl25.Text = "SonKul.:"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl24.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl24.Location = New System.Drawing.Point(722, 184)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl24.TabIndex = 94
        Me.LabelControl24.Text = "KrediLimiti:"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl23.Location = New System.Drawing.Point(722, 156)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl23.TabIndex = 93
        Me.LabelControl23.Text = "KrediAcilis:"
        '
        'txt_nIskontoPesin
        '
        Me.txt_nIskontoPesin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.nIskontoPesin", True))
        Me.txt_nIskontoPesin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskontoPesin.EnterMoveNextControl = True
        Me.txt_nIskontoPesin.Location = New System.Drawing.Point(957, 241)
        Me.txt_nIskontoPesin.Name = "txt_nIskontoPesin"
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskontoPesin.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskontoPesin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskontoPesin.Properties.ReadOnly = True
        Me.txt_nIskontoPesin.Size = New System.Drawing.Size(67, 26)
        Me.txt_nIskontoPesin.TabIndex = 26
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.Location = New System.Drawing.Point(870, 246)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(85, 19)
        Me.LabelControl17.TabIndex = 92
        Me.LabelControl17.Text = "Ýsk.Peþin%:"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl20.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl20.Location = New System.Drawing.Point(720, 241)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(84, 19)
        Me.LabelControl20.TabIndex = 91
        Me.LabelControl20.Text = "Ýsk.Kredi%:"
        '
        'txt_dteSonKullanmaTarihi
        '
        Me.txt_dteSonKullanmaTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.dteSonKullanmaTarihi", True))
        Me.txt_dteSonKullanmaTarihi.EditValue = Nothing
        Me.txt_dteSonKullanmaTarihi.Location = New System.Drawing.Point(806, 213)
        Me.txt_dteSonKullanmaTarihi.MenuManager = Me.BarManager1
        Me.txt_dteSonKullanmaTarihi.Name = "txt_dteSonKullanmaTarihi"
        Me.txt_dteSonKullanmaTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteSonKullanmaTarihi.Properties.ReadOnly = True
        Me.txt_dteSonKullanmaTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteSonKullanmaTarihi.Size = New System.Drawing.Size(218, 26)
        Me.txt_dteSonKullanmaTarihi.TabIndex = 24
        '
        'txt_dteKrediLimitiTarihi
        '
        Me.txt_dteKrediLimitiTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.kredidteKayitTarihi", True))
        Me.txt_dteKrediLimitiTarihi.EditValue = Nothing
        Me.txt_dteKrediLimitiTarihi.Location = New System.Drawing.Point(806, 184)
        Me.txt_dteKrediLimitiTarihi.MenuManager = Me.BarManager1
        Me.txt_dteKrediLimitiTarihi.Name = "txt_dteKrediLimitiTarihi"
        Me.txt_dteKrediLimitiTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteKrediLimitiTarihi.Properties.ReadOnly = True
        Me.txt_dteKrediLimitiTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteKrediLimitiTarihi.Size = New System.Drawing.Size(218, 26)
        Me.txt_dteKrediLimitiTarihi.TabIndex = 23
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(758, 127)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(42, 19)
        Me.LabelControl14.TabIndex = 85
        Me.LabelControl14.Text = "Kredi:"
        '
        'txt_lGeciken
        '
        Me.txt_lGeciken.EnterMoveNextControl = True
        Me.txt_lGeciken.Location = New System.Drawing.Point(806, 99)
        Me.txt_lGeciken.Name = "txt_lGeciken"
        Me.txt_lGeciken.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lGeciken.Properties.Appearance.Options.UseFont = True
        Me.txt_lGeciken.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lGeciken.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lGeciken.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lGeciken.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lGeciken.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lGeciken.Properties.ReadOnly = True
        Me.txt_lGeciken.Size = New System.Drawing.Size(218, 28)
        Me.txt_lGeciken.TabIndex = 20
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.Location = New System.Drawing.Point(738, 101)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl15.TabIndex = 83
        Me.LabelControl15.Text = "Geciken:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(747, 70)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl16.TabIndex = 81
        Me.LabelControl16.Text = "Bakiye:"
        '
        'txt_lBakiye
        '
        Me.txt_lBakiye.EnterMoveNextControl = True
        Me.txt_lBakiye.Location = New System.Drawing.Point(806, 70)
        Me.txt_lBakiye.Name = "txt_lBakiye"
        Me.txt_lBakiye.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lBakiye.Properties.Appearance.Options.UseFont = True
        Me.txt_lBakiye.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBakiye.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBakiye.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lBakiye.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lBakiye.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lBakiye.Properties.ReadOnly = True
        Me.txt_lBakiye.Size = New System.Drawing.Size(218, 28)
        Me.txt_lBakiye.TabIndex = 19
        '
        'txt_sUnvan
        '
        Me.txt_sUnvan.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sUnvan", True))
        Me.txt_sUnvan.EnterMoveNextControl = True
        Me.txt_sUnvan.Location = New System.Drawing.Point(494, 184)
        Me.txt_sUnvan.Name = "txt_sUnvan"
        Me.txt_sUnvan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sUnvan.Properties.Appearance.Options.UseFont = True
        Me.txt_sUnvan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sUnvan.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sUnvan.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sUnvan.Properties.MaxLength = 60
        Me.txt_sUnvan.Properties.ReadOnly = True
        Me.txt_sUnvan.Size = New System.Drawing.Size(221, 28)
        Me.txt_sUnvan.TabIndex = 14
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(434, 184)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl13.TabIndex = 79
        Me.LabelControl13.Text = "Ünvan:"
        '
        'txt_sVergiNo
        '
        Me.txt_sVergiNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sVergiNo", True))
        Me.txt_sVergiNo.EnterMoveNextControl = True
        Me.txt_sVergiNo.Location = New System.Drawing.Point(494, 241)
        Me.txt_sVergiNo.Name = "txt_sVergiNo"
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiNo.Properties.MaxLength = 60
        Me.txt_sVergiNo.Properties.ReadOnly = True
        Me.txt_sVergiNo.Size = New System.Drawing.Size(221, 26)
        Me.txt_sVergiNo.TabIndex = 16
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.Location = New System.Drawing.Point(424, 241)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl12.TabIndex = 77
        Me.LabelControl12.Text = "VergiNo:"
        '
        'txt_sVergiDairesi
        '
        Me.txt_sVergiDairesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sVergiDairesi", True))
        Me.txt_sVergiDairesi.EnterMoveNextControl = True
        Me.txt_sVergiDairesi.Location = New System.Drawing.Point(494, 213)
        Me.txt_sVergiDairesi.Name = "txt_sVergiDairesi"
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sVergiDairesi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sVergiDairesi.Properties.MaxLength = 60
        Me.txt_sVergiDairesi.Properties.ReadOnly = True
        Me.txt_sVergiDairesi.Size = New System.Drawing.Size(221, 26)
        Me.txt_sVergiDairesi.TabIndex = 15
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(394, 213)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl9.TabIndex = 76
        Me.LabelControl9.Text = "VergiDairesi:"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl18.Location = New System.Drawing.Point(434, 156)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl18.TabIndex = 73
        Me.LabelControl18.Text = "TC NO:"
        '
        'txt_sEmail
        '
        Me.txt_sEmail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sEmail", True))
        Me.txt_sEmail.EnterMoveNextControl = True
        Me.txt_sEmail.Location = New System.Drawing.Point(494, 127)
        Me.txt_sEmail.Name = "txt_sEmail"
        Me.txt_sEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEmail.Properties.Appearance.Options.UseFont = True
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEmail.Properties.ReadOnly = True
        Me.txt_sEmail.Size = New System.Drawing.Size(221, 28)
        Me.txt_sEmail.TabIndex = 12
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl32.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl32.Location = New System.Drawing.Point(438, 127)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl32.TabIndex = 55
        Me.LabelControl32.Text = "E-Mail:"
        '
        'txt_sGSM
        '
        Me.txt_sGSM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sGSM", True))
        Me.txt_sGSM.EnterMoveNextControl = True
        Me.txt_sGSM.Location = New System.Drawing.Point(494, 99)
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
        Me.txt_sGSM.Properties.ReadOnly = True
        Me.txt_sGSM.Size = New System.Drawing.Size(221, 28)
        Me.txt_sGSM.TabIndex = 11
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl19.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl19.Location = New System.Drawing.Point(451, 99)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl19.TabIndex = 53
        Me.LabelControl19.Text = "Gsm:"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl22.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl22.Location = New System.Drawing.Point(406, 70)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl22.TabIndex = 51
        Me.LabelControl22.Text = "EvTelefon:"
        '
        'txt_sEvTelefonu
        '
        Me.txt_sEvTelefonu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sEvTelefonu", True))
        Me.txt_sEvTelefonu.EnterMoveNextControl = True
        Me.txt_sEvTelefonu.Location = New System.Drawing.Point(494, 70)
        Me.txt_sEvTelefonu.Name = "txt_sEvTelefonu"
        Me.txt_sEvTelefonu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEvTelefonu.Properties.Appearance.Options.UseFont = True
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvTelefonu.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sEvTelefonu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sEvTelefonu.Properties.Mask.SaveLiteral = False
        Me.txt_sEvTelefonu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sEvTelefonu.Properties.MaxLength = 20
        Me.txt_sEvTelefonu.Properties.ReadOnly = True
        Me.txt_sEvTelefonu.Size = New System.Drawing.Size(221, 28)
        Me.txt_sEvTelefonu.TabIndex = 10
        '
        'txt_sEvAdresi2
        '
        Me.txt_sEvAdresi2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sEvAdresi2", True))
        Me.txt_sEvAdresi2.EnterMoveNextControl = True
        Me.txt_sEvAdresi2.Location = New System.Drawing.Point(123, 247)
        Me.txt_sEvAdresi2.Name = "txt_sEvAdresi2"
        Me.txt_sEvAdresi2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEvAdresi2.Properties.Appearance.Options.UseFont = True
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvAdresi2.Properties.MaxLength = 60
        Me.txt_sEvAdresi2.Properties.ReadOnly = True
        Me.txt_sEvAdresi2.Size = New System.Drawing.Size(272, 28)
        Me.txt_sEvAdresi2.TabIndex = 7
        '
        'txt_sEvAdresi1
        '
        Me.txt_sEvAdresi1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sEvAdresi1", True))
        Me.txt_sEvAdresi1.EnterMoveNextControl = True
        Me.txt_sEvAdresi1.Location = New System.Drawing.Point(123, 219)
        Me.txt_sEvAdresi1.Name = "txt_sEvAdresi1"
        Me.txt_sEvAdresi1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEvAdresi1.Properties.Appearance.Options.UseFont = True
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvAdresi1.Properties.MaxLength = 60
        Me.txt_sEvAdresi1.Properties.ReadOnly = True
        Me.txt_sEvAdresi1.Size = New System.Drawing.Size(272, 28)
        Me.txt_sEvAdresi1.TabIndex = 6
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl21.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl21.Location = New System.Drawing.Point(45, 219)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(64, 19)
        Me.LabelControl21.TabIndex = 50
        Me.LabelControl21.Text = "EvAdres:"
        '
        'txt_sSoyadi
        '
        Me.txt_sSoyadi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sSoyadi", True))
        Me.txt_sSoyadi.EnterMoveNextControl = True
        Me.txt_sSoyadi.Location = New System.Drawing.Point(123, 190)
        Me.txt_sSoyadi.Name = "txt_sSoyadi"
        Me.txt_sSoyadi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sSoyadi.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sSoyadi.Properties.Appearance.Options.UseFont = True
        Me.txt_sSoyadi.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sSoyadi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSoyadi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSoyadi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSoyadi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSoyadi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSoyadi.Properties.MaxLength = 60
        Me.txt_sSoyadi.Properties.ReadOnly = True
        Me.txt_sSoyadi.Size = New System.Drawing.Size(272, 28)
        Me.txt_sSoyadi.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(58, 190)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(53, 19)
        Me.LabelControl10.TabIndex = 46
        Me.LabelControl10.Text = "Soyadý:"
        '
        'txt_sAdi
        '
        Me.txt_sAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sAdi", True))
        Me.txt_sAdi.EnterMoveNextControl = True
        Me.txt_sAdi.Location = New System.Drawing.Point(123, 161)
        Me.txt_sAdi.Name = "txt_sAdi"
        Me.txt_sAdi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sAdi.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sAdi.Properties.Appearance.Options.UseFont = True
        Me.txt_sAdi.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdi.Properties.MaxLength = 60
        Me.txt_sAdi.Properties.ReadOnly = True
        Me.txt_sAdi.Size = New System.Drawing.Size(272, 28)
        Me.txt_sAdi.TabIndex = 4
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(85, 161)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl11.TabIndex = 45
        Me.LabelControl11.Text = "Adý:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(50, 133)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl8.TabIndex = 10
        Me.LabelControl8.Text = "Magaza:"
        '
        'txt_sMagaza
        '
        Me.txt_sMagaza.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.sMagaza", True))
        Me.txt_sMagaza.Location = New System.Drawing.Point(123, 133)
        Me.txt_sMagaza.MenuManager = Me.BarManager1
        Me.txt_sMagaza.Name = "txt_sMagaza"
        Me.txt_sMagaza.Properties.ReadOnly = True
        Me.txt_sMagaza.Size = New System.Drawing.Size(272, 26)
        Me.txt_sMagaza.TabIndex = 3
        '
        'txt_dteKayitTarihi
        '
        Me.txt_dteKayitTarihi.EditValue = Nothing
        Me.txt_dteKayitTarihi.Location = New System.Drawing.Point(218, 104)
        Me.txt_dteKayitTarihi.MenuManager = Me.BarManager1
        Me.txt_dteKayitTarihi.Name = "txt_dteKayitTarihi"
        Me.txt_dteKayitTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteKayitTarihi.Properties.ReadOnly = True
        Me.txt_dteKayitTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteKayitTarihi.Size = New System.Drawing.Size(177, 26)
        Me.txt_dteKayitTarihi.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(70, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 19)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Kayýt:"
        '
        'txt_nMusteriID
        '
        Me.txt_nMusteriID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.nMusteriID", True))
        Me.txt_nMusteriID.Location = New System.Drawing.Point(123, 104)
        Me.txt_nMusteriID.MenuManager = Me.BarManager1
        Me.txt_nMusteriID.Name = "txt_nMusteriID"
        Me.txt_nMusteriID.Properties.ReadOnly = True
        Me.txt_nMusteriID.Size = New System.Drawing.Size(95, 26)
        Me.txt_nMusteriID.TabIndex = 1
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
        Me.Panel_Ara.Size = New System.Drawing.Size(1087, 61)
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
        Me.btn_yenile.Image = CType(resources.GetObject("btn_yenile.Image"), System.Drawing.Image)
        Me.btn_yenile.Location = New System.Drawing.Point(315, 3)
        Me.btn_yenile.Name = "btn_yenile"
        Me.btn_yenile.Size = New System.Drawing.Size(39, 28)
        ToolTipTitleItem1.Text = "Yenile"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Hesap Kartýnda Bilgileri Yeniler"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btn_yenile.SuperTip = SuperToolTip1
        Me.btn_yenile.TabIndex = 40
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.SimpleButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(469, 3)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(38, 28)
        ToolTipTitleItem2.Text = "Son Kayýt"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "En Son Girilmiþ Olan Müþteri Kaydýný Ekrana Getirir"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.SimpleButton3.SuperTip = SuperToolTip2
        Me.SimpleButton3.TabIndex = 11
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
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(430, 3)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(39, 28)
        ToolTipTitleItem3.Text = "Sonraki Kayýt"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Bir Sonraki Müþteri Kaydýný Ekrana Getirir"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.SimpleButton4.SuperTip = SuperToolTip3
        Me.SimpleButton4.TabIndex = 10
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
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(392, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(38, 28)
        ToolTipTitleItem4.Text = "Önceki Kayýt"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Bir Önceki Müþteri Kaydýný Ekrana Getirir"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.SimpleButton2.SuperTip = SuperToolTip4
        Me.SimpleButton2.TabIndex = 9
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
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(354, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 28)
        ToolTipTitleItem5.Text = "Ilk Kayýt"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Ilk Müþteri Kaydýný Ekrana Getirir"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.SimpleButton1.SuperTip = SuperToolTip5
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.ToolTip = "Ilk Kayit"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(570, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(515, 17)
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
        Me.txt_musterino.Properties.NullText = "[MüþteriNo]"
        Me.txt_musterino.Size = New System.Drawing.Size(175, 30)
        ToolTipTitleItem6.Text = "Müþteri No"
        ToolTipItem6.LeftIndent = 6
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.txt_musterino.SuperTip = SuperToolTip6
        Me.txt_musterino.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(13, 7)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(77, 19)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "MüþteriNo:"
        '
        'sec_bakiyeli
        '
        Me.sec_bakiyeli.Location = New System.Drawing.Point(280, 6)
        Me.sec_bakiyeli.Name = "sec_bakiyeli"
        Me.sec_bakiyeli.Properties.Caption = ""
        Me.sec_bakiyeli.Size = New System.Drawing.Size(35, 19)
        ToolTipTitleItem7.Text = "Bakiyeli Müþteriler"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Sadece Bakiyeli Müþterilerin Ekrana Gelmesi ve Izlenmesi istenidiði zaman Bu Kutu" &
    "cuk Ýþaretlenir"
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.sec_bakiyeli.SuperTip = SuperToolTip7
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
        Me.lbl_musteri_adi.Location = New System.Drawing.Point(2, 39)
        Me.lbl_musteri_adi.Name = "lbl_musteri_adi"
        Me.lbl_musteri_adi.Size = New System.Drawing.Size(1083, 20)
        Me.lbl_musteri_adi.TabIndex = 39
        Me.lbl_musteri_adi.Text = "*"
        '
        'txt_dteKrediAcilisTarihi
        '
        Me.txt_dteKrediAcilisTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_Musteri, "Table1.dteKrediAcilisTarihi", True))
        Me.txt_dteKrediAcilisTarihi.EditValue = Nothing
        Me.txt_dteKrediAcilisTarihi.Location = New System.Drawing.Point(806, 156)
        Me.txt_dteKrediAcilisTarihi.MenuManager = Me.BarManager1
        Me.txt_dteKrediAcilisTarihi.Name = "txt_dteKrediAcilisTarihi"
        Me.txt_dteKrediAcilisTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteKrediAcilisTarihi.Properties.ReadOnly = True
        Me.txt_dteKrediAcilisTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteKrediAcilisTarihi.Size = New System.Drawing.Size(218, 26)
        Me.txt_dteKrediAcilisTarihi.TabIndex = 22
        '
        'txt_bEvlimi
        '
        Me.txt_bEvlimi.Location = New System.Drawing.Point(491, 270)
        Me.txt_bEvlimi.Name = "txt_bEvlimi"
        Me.txt_bEvlimi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bEvlimi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bEvlimi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_bEvlimi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_bEvlimi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_bEvlimi.Properties.Caption = "Evli"
        Me.txt_bEvlimi.Size = New System.Drawing.Size(67, 24)
        Me.txt_bEvlimi.TabIndex = 17
        '
        'Panel_Taksitler
        '
        Me.Panel_Taksitler.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Taksitler.Appearance.Options.UseBackColor = True
        Me.Panel_Taksitler.Controls.Add(Me.GroupControl1)
        Me.Panel_Taksitler.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Taksitler.Location = New System.Drawing.Point(690, 400)
        Me.Panel_Taksitler.Name = "Panel_Taksitler"
        Me.Panel_Taksitler.Size = New System.Drawing.Size(403, 511)
        Me.Panel_Taksitler.TabIndex = 3
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
        Me.GroupControl1.Size = New System.Drawing.Size(399, 507)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Kalan Ödemeler"
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 23)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(395, 449)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
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
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Black
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colGEC
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
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
        Me.coldteTarihi.FieldName = "dteTarihi"
        Me.coldteTarihi.Name = "coldteTarihi"
        Me.coldteTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", "{0} Taksit")})
        Me.coldteTarihi.Visible = True
        Me.coldteTarihi.VisibleIndex = 0
        Me.coldteTarihi.Width = 81
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
        Me.colKALAN.Width = 78
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
        Me.btn_Odemeler.Location = New System.Drawing.Point(2, 472)
        Me.btn_Odemeler.Name = "btn_Odemeler"
        Me.btn_Odemeler.Size = New System.Drawing.Size(395, 33)
        Me.btn_Odemeler.TabIndex = 1
        Me.btn_Odemeler.Text = "Aylýk"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(2, 400)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(688, 135)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Müþterinin Gruplandýrmasý"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_sinif
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 29)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(684, 104)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsSinifTipi, Me.colsSinifKodu, Me.colsAciklama, Me.colbSatisYapilamaz})
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
        '
        'colsSinifTipi
        '
        Me.colsSinifTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsSinifTipi.AppearanceCell.Options.UseFont = True
        Me.colsSinifTipi.Caption = "Tip"
        Me.colsSinifTipi.FieldName = "sSinifTipi"
        Me.colsSinifTipi.Name = "colsSinifTipi"
        Me.colsSinifTipi.Visible = True
        Me.colsSinifTipi.VisibleIndex = 0
        '
        'colsSinifKodu
        '
        Me.colsSinifKodu.Caption = "Kod"
        Me.colsSinifKodu.FieldName = "sSinifKodu"
        Me.colsSinifKodu.Name = "colsSinifKodu"
        Me.colsSinifKodu.Visible = True
        Me.colsSinifKodu.VisibleIndex = 1
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colbSatisYapilamaz
        '
        Me.colbSatisYapilamaz.Caption = "Satýþ Yapýlamaz"
        Me.colbSatisYapilamaz.FieldName = "bSatisYapilamaz"
        Me.colbSatisYapilamaz.Name = "colbSatisYapilamaz"
        Me.colbSatisYapilamaz.Visible = True
        Me.colbSatisYapilamaz.VisibleIndex = 3
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.Controls.Add(Me.GridControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 535)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(688, 376)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Hesap Hareketleri"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_odemeler
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 23)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(684, 351)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
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
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTARIH, Me.colIZAHAT, Me.colBELGENO, Me.colMIKTAR, Me.colTUTAR, Me.colTAHSILAT, Me.colMAGAZA, Me.colKASIYER, Me.colKAYIT, Me.collBakiye})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(588, 444, 208, 154)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
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
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.DisplayFormat.FormatString = "dd/MM/yy"
        Me.colTARIH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", "{0} Kayýt")})
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 51
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "FisTipi"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 1
        Me.colIZAHAT.Width = 31
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "FisNo"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Visible = True
        Me.colBELGENO.VisibleIndex = 2
        Me.colBELGENO.Width = 36
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,#.##"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,#.##}")})
        '
        'colTUTAR
        '
        Me.colTUTAR.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colTUTAR.AppearanceCell.Options.UseForeColor = True
        Me.colTUTAR.Caption = "Satýþ"
        Me.colTUTAR.DisplayFormat.FormatString = "#,#.##"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,#.##}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 3
        Me.colTUTAR.Width = 44
        '
        'colTAHSILAT
        '
        Me.colTAHSILAT.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.colTAHSILAT.AppearanceCell.Options.UseForeColor = True
        Me.colTAHSILAT.Caption = "Tahsilat"
        Me.colTAHSILAT.DisplayFormat.FormatString = "#,#.##"
        Me.colTAHSILAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTAHSILAT.FieldName = "TAHSILAT"
        Me.colTAHSILAT.Name = "colTAHSILAT"
        Me.colTAHSILAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", "{0:#,#.##}")})
        Me.colTAHSILAT.Visible = True
        Me.colTAHSILAT.VisibleIndex = 4
        Me.colTAHSILAT.Width = 47
        '
        'colMAGAZA
        '
        Me.colMAGAZA.Caption = "Maðaza"
        Me.colMAGAZA.FieldName = "MAGAZA"
        Me.colMAGAZA.Name = "colMAGAZA"
        Me.colMAGAZA.Visible = True
        Me.colMAGAZA.VisibleIndex = 6
        Me.colMAGAZA.Width = 45
        '
        'colKASIYER
        '
        Me.colKASIYER.Caption = "Kasiyer"
        Me.colKASIYER.FieldName = "KASIYER"
        Me.colKASIYER.Name = "colKASIYER"
        Me.colKASIYER.Visible = True
        Me.colKASIYER.VisibleIndex = 7
        Me.colKASIYER.Width = 47
        '
        'colKAYIT
        '
        Me.colKAYIT.Caption = "Saat"
        Me.colKAYIT.DisplayFormat.FormatString = "HH:mm"
        Me.colKAYIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKAYIT.FieldName = "KAYIT"
        Me.colKAYIT.Name = "colKAYIT"
        Me.colKAYIT.Visible = True
        Me.colKAYIT.VisibleIndex = 8
        Me.colKAYIT.Width = 35
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "lKalan", "")})
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 5
        Me.collBakiye.Width = 51
        '
        'ýmageList1
        '
        Me.ýmageList1.ImageStream = CType(resources.GetObject("ýmageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ýmageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ýmageList1.Images.SetKeyName(0, "businessman_preferences.png")
        Me.ýmageList1.Images.SetKeyName(1, "businessman_add.png")
        Me.ýmageList1.Images.SetKeyName(2, "id_card_information.png")
        Me.ýmageList1.Images.SetKeyName(3, "note_pinned.png")
        Me.ýmageList1.Images.SetKeyName(4, "id_card_ok.png")
        Me.ýmageList1.Images.SetKeyName(5, "outbox.png")
        Me.ýmageList1.Images.SetKeyName(6, "money2.png")
        Me.ýmageList1.Images.SetKeyName(7, "money_envelope.png")
        Me.ýmageList1.Images.SetKeyName(8, "shoppingcart_full.png")
        Me.ýmageList1.Images.SetKeyName(9, "column.png")
        Me.ýmageList1.Images.SetKeyName(10, "index_view.png")
        '
        'ds_taksitler
        '
        Me.ds_taksitler.DataSetName = "NewDataSet"
        Me.ds_taksitler.Locale = New System.Globalization.CultureInfo("tr-TR")
        '
        'Panel_islem
        '
        Me.Panel_islem.Controls.Add(Me.GroupControl7)
        Me.Panel_islem.Controls.Add(Me.GroupControl6)
        Me.Panel_islem.Controls.Add(Me.GroupControl5)
        Me.Panel_islem.Controls.Add(Me.GroupControl4)
        Me.Panel_islem.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_islem.Enabled = False
        Me.Panel_islem.Location = New System.Drawing.Point(0, 95)
        Me.Panel_islem.Name = "Panel_islem"
        Me.Panel_islem.Size = New System.Drawing.Size(270, 913)
        Me.Panel_islem.TabIndex = 15
        '
        'GroupControl7
        '
        Me.GroupControl7.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl7.AppearanceCaption.Options.UseFont = True
        Me.GroupControl7.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl7.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl7.Controls.Add(Me.SimpleButton6)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Satislar_Bekleyen)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Kalan_Taksitler)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Kalan_Satislar)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Satislar)
        Me.GroupControl7.Controls.Add(Me.btn_Analiz_Odemeler)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl7.Location = New System.Drawing.Point(2, 566)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(266, 345)
        Me.GroupControl7.TabIndex = 3
        Me.GroupControl7.Text = "Analiz"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Options.UseTextOptions = True
        Me.SimpleButton6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton6.Location = New System.Drawing.Point(11, 149)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(239, 24)
        Me.SimpleButton6.TabIndex = 5
        Me.SimpleButton6.Text = "Karlýlýk Akýþ Tablosu   Ctrl+Z"
        '
        'btn_Analiz_Satislar_Bekleyen
        '
        Me.btn_Analiz_Satislar_Bekleyen.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Satislar_Bekleyen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Satislar_Bekleyen.Location = New System.Drawing.Point(11, 124)
        Me.btn_Analiz_Satislar_Bekleyen.Name = "btn_Analiz_Satislar_Bekleyen"
        Me.btn_Analiz_Satislar_Bekleyen.Size = New System.Drawing.Size(239, 25)
        Me.btn_Analiz_Satislar_Bekleyen.TabIndex = 4
        Me.btn_Analiz_Satislar_Bekleyen.Text = "Bekleyen Alýþveriþler"
        '
        'btn_Analiz_Kalan_Taksitler
        '
        Me.btn_Analiz_Kalan_Taksitler.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Kalan_Taksitler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Kalan_Taksitler.Location = New System.Drawing.Point(11, 100)
        Me.btn_Analiz_Kalan_Taksitler.Name = "btn_Analiz_Kalan_Taksitler"
        Me.btn_Analiz_Kalan_Taksitler.Size = New System.Drawing.Size(239, 24)
        Me.btn_Analiz_Kalan_Taksitler.TabIndex = 3
        Me.btn_Analiz_Kalan_Taksitler.Text = "Kalan Taksitler           Alt+F7"
        '
        'btn_Analiz_Kalan_Satislar
        '
        Me.btn_Analiz_Kalan_Satislar.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Kalan_Satislar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Kalan_Satislar.Location = New System.Drawing.Point(11, 76)
        Me.btn_Analiz_Kalan_Satislar.Name = "btn_Analiz_Kalan_Satislar"
        Me.btn_Analiz_Kalan_Satislar.Size = New System.Drawing.Size(239, 24)
        Me.btn_Analiz_Kalan_Satislar.TabIndex = 2
        Me.btn_Analiz_Kalan_Satislar.Text = "Kalan Satýþlar"
        '
        'btn_Analiz_Satislar
        '
        Me.btn_Analiz_Satislar.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Satislar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Satislar.Location = New System.Drawing.Point(11, 51)
        Me.btn_Analiz_Satislar.Name = "btn_Analiz_Satislar"
        Me.btn_Analiz_Satislar.Size = New System.Drawing.Size(239, 25)
        Me.btn_Analiz_Satislar.TabIndex = 1
        Me.btn_Analiz_Satislar.Text = "Yapýlan Satýþlar          Alt+F6"
        '
        'btn_Analiz_Odemeler
        '
        Me.btn_Analiz_Odemeler.Appearance.Options.UseTextOptions = True
        Me.btn_Analiz_Odemeler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Analiz_Odemeler.Location = New System.Drawing.Point(11, 27)
        Me.btn_Analiz_Odemeler.Name = "btn_Analiz_Odemeler"
        Me.btn_Analiz_Odemeler.Size = New System.Drawing.Size(239, 24)
        Me.btn_Analiz_Odemeler.TabIndex = 0
        Me.btn_Analiz_Odemeler.Text = "Alýnan Ödemeler        Alt+F5"
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl6.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl6.Controls.Add(Me.btn_Ekstre_Ozet)
        Me.GroupControl6.Controls.Add(Me.btn_Raporlar_Ekstre_Detayli)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl6.Location = New System.Drawing.Point(2, 476)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(266, 90)
        Me.GroupControl6.TabIndex = 2
        Me.GroupControl6.Text = "Raporlar"
        '
        'btn_Ekstre_Ozet
        '
        Me.btn_Ekstre_Ozet.Appearance.Options.UseTextOptions = True
        Me.btn_Ekstre_Ozet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Ekstre_Ozet.Location = New System.Drawing.Point(11, 51)
        Me.btn_Ekstre_Ozet.Name = "btn_Ekstre_Ozet"
        Me.btn_Ekstre_Ozet.Size = New System.Drawing.Size(239, 25)
        Me.btn_Ekstre_Ozet.TabIndex = 1
        Me.btn_Ekstre_Ozet.Text = "Ekstre Özet"
        '
        'btn_Raporlar_Ekstre_Detayli
        '
        Me.btn_Raporlar_Ekstre_Detayli.Appearance.Options.UseTextOptions = True
        Me.btn_Raporlar_Ekstre_Detayli.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Raporlar_Ekstre_Detayli.Location = New System.Drawing.Point(11, 27)
        Me.btn_Raporlar_Ekstre_Detayli.Name = "btn_Raporlar_Ekstre_Detayli"
        Me.btn_Raporlar_Ekstre_Detayli.Size = New System.Drawing.Size(239, 24)
        Me.btn_Raporlar_Ekstre_Detayli.TabIndex = 0
        Me.btn_Raporlar_Ekstre_Detayli.Text = "Ekstre Detaylý           Ctrl+F8"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl5.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl5.Controls.Add(Me.SimpleButton7)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_VadeAyarla)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_Teslimat)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_VadeFarki)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_Odeme_Al)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_Siparis_Pesin)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_Siparis_Kredili)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_Satis_Pesin)
        Me.GroupControl5.Controls.Add(Me.btn_Islem_Satis_Kredili)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl5.Location = New System.Drawing.Point(2, 229)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(266, 247)
        Me.GroupControl5.TabIndex = 1
        Me.GroupControl5.Text = "Ýþlemler"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Options.UseTextOptions = True
        Me.SimpleButton7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton7.Location = New System.Drawing.Point(11, 221)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(239, 25)
        Me.SimpleButton7.TabIndex = 8
        Me.SimpleButton7.Text = "Peþinat Al"
        '
        'btn_Islem_VadeAyarla
        '
        Me.btn_Islem_VadeAyarla.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_VadeAyarla.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_VadeAyarla.Location = New System.Drawing.Point(11, 197)
        Me.btn_Islem_VadeAyarla.Name = "btn_Islem_VadeAyarla"
        Me.btn_Islem_VadeAyarla.Size = New System.Drawing.Size(239, 24)
        Me.btn_Islem_VadeAyarla.TabIndex = 7
        Me.btn_Islem_VadeAyarla.Text = "Vade Ayarla              F11"
        '
        'btn_Islem_Teslimat
        '
        Me.btn_Islem_Teslimat.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_Teslimat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_Teslimat.Location = New System.Drawing.Point(11, 173)
        Me.btn_Islem_Teslimat.Name = "btn_Islem_Teslimat"
        Me.btn_Islem_Teslimat.Size = New System.Drawing.Size(239, 24)
        Me.btn_Islem_Teslimat.TabIndex = 6
        Me.btn_Islem_Teslimat.Text = "Teslimat Yap"
        '
        'btn_Islem_VadeFarki
        '
        Me.btn_Islem_VadeFarki.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_VadeFarki.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_VadeFarki.Location = New System.Drawing.Point(11, 149)
        Me.btn_Islem_VadeFarki.Name = "btn_Islem_VadeFarki"
        Me.btn_Islem_VadeFarki.Size = New System.Drawing.Size(239, 24)
        Me.btn_Islem_VadeFarki.TabIndex = 5
        Me.btn_Islem_VadeFarki.Text = "Vade Farký Hesapla"
        '
        'btn_Islem_Odeme_Al
        '
        Me.btn_Islem_Odeme_Al.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_Odeme_Al.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_Odeme_Al.Location = New System.Drawing.Point(11, 124)
        Me.btn_Islem_Odeme_Al.Name = "btn_Islem_Odeme_Al"
        Me.btn_Islem_Odeme_Al.Size = New System.Drawing.Size(239, 25)
        Me.btn_Islem_Odeme_Al.TabIndex = 4
        Me.btn_Islem_Odeme_Al.Text = "Ödeme Al                  F7"
        '
        'btn_Islem_Siparis_Pesin
        '
        Me.btn_Islem_Siparis_Pesin.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_Siparis_Pesin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_Siparis_Pesin.Location = New System.Drawing.Point(11, 100)
        Me.btn_Islem_Siparis_Pesin.Name = "btn_Islem_Siparis_Pesin"
        Me.btn_Islem_Siparis_Pesin.Size = New System.Drawing.Size(239, 24)
        Me.btn_Islem_Siparis_Pesin.TabIndex = 3
        Me.btn_Islem_Siparis_Pesin.Text = "Sonradan Teslim Peþin  Satýþ"
        '
        'btn_Islem_Siparis_Kredili
        '
        Me.btn_Islem_Siparis_Kredili.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_Siparis_Kredili.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_Siparis_Kredili.Location = New System.Drawing.Point(11, 76)
        Me.btn_Islem_Siparis_Kredili.Name = "btn_Islem_Siparis_Kredili"
        Me.btn_Islem_Siparis_Kredili.Size = New System.Drawing.Size(239, 24)
        Me.btn_Islem_Siparis_Kredili.TabIndex = 2
        Me.btn_Islem_Siparis_Kredili.Text = "Sonradan Teslim Kredili Satýþ"
        '
        'btn_Islem_Satis_Pesin
        '
        Me.btn_Islem_Satis_Pesin.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_Satis_Pesin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_Satis_Pesin.Location = New System.Drawing.Point(11, 51)
        Me.btn_Islem_Satis_Pesin.Name = "btn_Islem_Satis_Pesin"
        Me.btn_Islem_Satis_Pesin.Size = New System.Drawing.Size(239, 25)
        Me.btn_Islem_Satis_Pesin.TabIndex = 1
        Me.btn_Islem_Satis_Pesin.Text = "Peþin Satýþ                F6"
        '
        'btn_Islem_Satis_Kredili
        '
        Me.btn_Islem_Satis_Kredili.Appearance.Options.UseTextOptions = True
        Me.btn_Islem_Satis_Kredili.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Islem_Satis_Kredili.Location = New System.Drawing.Point(11, 27)
        Me.btn_Islem_Satis_Kredili.Name = "btn_Islem_Satis_Kredili"
        Me.btn_Islem_Satis_Kredili.Size = New System.Drawing.Size(239, 24)
        Me.btn_Islem_Satis_Kredili.TabIndex = 0
        Me.btn_Islem_Satis_Kredili.Text = "Kredili Satýþ               F5"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl4.Controls.Add(Me.btn_KimlikTara)
        Me.GroupControl4.Controls.Add(Me.SimpleButton5)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Sozlesme)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Duzelt)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Not)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Kart)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_Yeni)
        Me.GroupControl4.Controls.Add(Me.btn_Musteri_sec)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(266, 227)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Müþteri Bilgileri"
        '
        'btn_KimlikTara
        '
        Me.btn_KimlikTara.Appearance.Options.UseTextOptions = True
        Me.btn_KimlikTara.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_KimlikTara.Location = New System.Drawing.Point(11, 197)
        Me.btn_KimlikTara.Name = "btn_KimlikTara"
        Me.btn_KimlikTara.Size = New System.Drawing.Size(239, 24)
        Me.btn_KimlikTara.TabIndex = 7
        Me.btn_KimlikTara.Text = "Kimlik Tara"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Options.UseTextOptions = True
        Me.SimpleButton5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.SimpleButton5.Location = New System.Drawing.Point(11, 173)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(239, 24)
        Me.SimpleButton5.TabIndex = 6
        Me.SimpleButton5.Text = "SMS Gönder"
        '
        'btn_Musteri_Sozlesme
        '
        Me.btn_Musteri_Sozlesme.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Sozlesme.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Sozlesme.Location = New System.Drawing.Point(11, 149)
        Me.btn_Musteri_Sozlesme.Name = "btn_Musteri_Sozlesme"
        Me.btn_Musteri_Sozlesme.Size = New System.Drawing.Size(239, 24)
        Me.btn_Musteri_Sozlesme.TabIndex = 5
        Me.btn_Musteri_Sozlesme.Text = "Sözleþme"
        '
        'btn_Musteri_Duzelt
        '
        Me.btn_Musteri_Duzelt.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Duzelt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Duzelt.Location = New System.Drawing.Point(11, 124)
        Me.btn_Musteri_Duzelt.Name = "btn_Musteri_Duzelt"
        Me.btn_Musteri_Duzelt.Size = New System.Drawing.Size(239, 25)
        Me.btn_Musteri_Duzelt.TabIndex = 4
        Me.btn_Musteri_Duzelt.Text = "Müþteri Düzenle        Ctrl+F4"
        '
        'btn_Musteri_Not
        '
        Me.btn_Musteri_Not.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Not.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Not.Location = New System.Drawing.Point(11, 100)
        Me.btn_Musteri_Not.Name = "btn_Musteri_Not"
        Me.btn_Musteri_Not.Size = New System.Drawing.Size(239, 24)
        Me.btn_Musteri_Not.TabIndex = 3
        Me.btn_Musteri_Not.Text = "Not                            F9"
        '
        'btn_Musteri_Kart
        '
        Me.btn_Musteri_Kart.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Kart.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Kart.Location = New System.Drawing.Point(11, 76)
        Me.btn_Musteri_Kart.Name = "btn_Musteri_Kart"
        Me.btn_Musteri_Kart.Size = New System.Drawing.Size(239, 24)
        Me.btn_Musteri_Kart.TabIndex = 2
        Me.btn_Musteri_Kart.Text = "Müþteri Kartý              F4"
        '
        'btn_Musteri_Yeni
        '
        Me.btn_Musteri_Yeni.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_Yeni.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_Yeni.Location = New System.Drawing.Point(11, 51)
        Me.btn_Musteri_Yeni.Name = "btn_Musteri_Yeni"
        Me.btn_Musteri_Yeni.Size = New System.Drawing.Size(239, 25)
        Me.btn_Musteri_Yeni.TabIndex = 1
        Me.btn_Musteri_Yeni.Text = "Yeni Müþteri              Insert"
        '
        'btn_Musteri_sec
        '
        Me.btn_Musteri_sec.Appearance.Options.UseTextOptions = True
        Me.btn_Musteri_sec.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.btn_Musteri_sec.Location = New System.Drawing.Point(11, 27)
        Me.btn_Musteri_sec.Name = "btn_Musteri_sec"
        Me.btn_Musteri_sec.Size = New System.Drawing.Size(239, 24)
        Me.btn_Musteri_sec.TabIndex = 0
        Me.btn_Musteri_sec.Text = "Müþteri Seç               F3"
        '
        'panel_bilgi
        '
        Me.panel_bilgi.Controls.Add(Me.GroupControl3)
        Me.panel_bilgi.Controls.Add(Me.GroupControl2)
        Me.panel_bilgi.Controls.Add(Me.Panel_Taksitler)
        Me.panel_bilgi.Controls.Add(Me.Panel_Baslik)
        Me.panel_bilgi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_bilgi.Location = New System.Drawing.Point(270, 95)
        Me.panel_bilgi.Name = "panel_bilgi"
        Me.panel_bilgi.Size = New System.Drawing.Size(1095, 913)
        Me.panel_bilgi.TabIndex = 16
        '
        'frm_perakende
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1365, 1038)
        Me.Controls.Add(Me.panel_bilgi)
        Me.Controls.Add(Me.Panel_islem)
        Me.Controls.Add(Me.Panel_Kasiyer)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_perakende"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peþin ve Kredili Satýþ,Ýade ve Ödeme Formu"
        CType(Me.Panel_Kasiyer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Kasiyer.ResumeLayout(False)
        Me.Panel_Kasiyer.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Baslik.ResumeLayout(False)
        Me.Panel_Baslik.PerformLayout()
        CType(Me.txt_KartNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_Musteri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil4Kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil3Kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil4Aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil3Aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil2Kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil1Kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil2Aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKefil1Aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sCuzdanKayitNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEhliyetNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskontoKredili.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lAylikGelir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sDogumYeri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteDogumTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteDogumTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteEvlilikTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteEvlilikTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lKrediLimiti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskontoPesin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSonKullanmaTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteSonKullanmaTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKrediLimitiTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKrediLimitiTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lGeciken.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lBakiye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sUnvan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sVergiNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sVergiDairesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sGSM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvTelefonu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvAdresi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvAdresi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKayitTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKayitTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nMusteriID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Ara.ResumeLayout(False)
        Me.Panel_Ara.PerformLayout()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bakiyeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKrediAcilisTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteKrediAcilisTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bEvlimi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Taksitler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Taksitler.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_sinif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_odemeler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim sKasiyerRumuzu As String = ""
    Dim sKasiyer As String
    Dim sMagaza As String
    Dim KartNo As String
    Dim nMusteriID As Int64 = 0
    Dim lKodu As String = 0
    Dim sAdi As String = ""
    Dim sSoyadi As String = ""
    Dim sAdres1 As String = ""
    Dim sAdres2 As String = ""
    Dim sVergiDairesi As String = ""
    Dim sVergiNo As String = ""
    Dim sIstihbarat As String = ""
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Dim bIptalYapabilirmi As Boolean = False
    Dim bVadeFarksizOdemeAlirmi As Boolean = False
    Dim nMaxIskontoYuzdesi As Decimal = 100
    Dim status As Boolean = False
    Dim sinifBilgi2 As String = ""
    Private Sub frm_perakende_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi 'sorgu_tarih_kontrol() 'dteSistemTarihi
        DateEdit1.Enabled = False
        dataload_kasa()
        dataload_kasiyer()
        dataload_depo()
    End Sub
    Private Sub dataload(ByVal nMusteriID As Int64)
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        txt_KartNo.Text = ""
        lbl_istihbarat.Text = ""
        sIstihbarat = ""
        ds_Musteri = tbMusteri(nMusteriID)
        Dim dr_baslik As DataRow = ds_Musteri.Tables(0).Rows(0)
        Try
            If Trim(dr_baslik("ISTIHBARAT").ToString) <> "" Then
                XtraMessageBox.Show(Trim(dr_baslik("ISTIHBARAT").ToString), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                sIstihbarat = Trim(dr_baslik("ISTIHBARAT").ToString)
            End If
        Catch ex As Exception
            sIstihbarat = ""
        End Try
        'VGrid_Genel.DataSource = ds_musteri.Tables(0)
        'VGrid_Genel.DataMember = Nothing
        dataload_tbMusteriSinifi(nMusteriID)
        dataload_tbMusteriSinif2(nMusteriID)
        If sAdi.Contains("PEÞÝN") = False And txt_musterino.Text <> 0 Then
            If sorgula_Decimal("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nAlisverisID), 0) AS nKayit FROM tbAlisVeris Where nMusteriID = " & nMusteriID & "") <= 50 Then
                GroupControl2.Dock = DockStyle.Top
                GroupControl3.Visible = True
                dataload_odemeler(nMusteriID, "01/01/1900", "31/12/2078")
            Else
                GroupControl2.Dock = DockStyle.Fill
                GroupControl3.Visible = False
            End If
            dataload_taksitler(nMusteriID)
        Else
            If sorgula_Decimal("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nAlisverisID), 0) AS nKayit FROM tbAlisVeris Where nMusteriID = " & nMusteriID & "") <= 50 Then
                GroupControl2.Dock = DockStyle.Top
                GroupControl3.Visible = True
                dataload_odemeler(-1, "01/01/1900", "31/12/2078")
            Else
                GroupControl2.Dock = DockStyle.Fill
                GroupControl3.Visible = False
            End If
            'dataload_odemeler(-1, "01/01/1900", "31/12/2078")
            dataload_taksitler(-1)
        End If
        Dim dr As DataRow
        Dim lBakiye As Decimal = 0
        Dim lGeciken As Decimal = 0
        Dim gecikmistaksitsayisi As Integer = 0
        For Each dr In ds_taksitler.Tables(0).Rows
            lBakiye += dr("KALAN")
            If dr("dteTarihi") < Today Then
                gecikmistaksitsayisi += 1
                lGeciken += dr("KALAN")
            End If
        Next
        'colMAGAZA.SummaryItem.DisplayFormat = FormatNumber(Math.Abs(lBakiye), 2).ToString
        txt_KartNo.Text = dr_baslik("KartNo")
        txt_nMusteriID.Text = dr_baslik("nMusteriID")
        txt_sMagaza.Text = Trim(dr_baslik("sMagaza"))
        txt_dteKayitTarihi.Text = dr_baslik("dteKayitTarihi")
        txt_sAdi.Text = Trim(dr_baslik("sAdi"))
        txt_sSoyadi.Text = Trim(dr_baslik("sSoyadi"))
        txt_sEvAdresi1.Text = Trim(dr_baslik("sEvAdresi1"))
        txt_sEvAdresi2.Text = Trim(dr_baslik("sEvAdresi2"))
        txt_dteDogumTarihi.Text = dr_baslik("dteDogumTarihi")
        txt_sDogumYeri.Text = Trim(dr_baslik("sDogumYeri"))
        txt_bEvlimi.Checked = dr_baslik("bEvlimi")
        txt_dteEvlilikTarihi.Text = dr_baslik("dteEvlilikTarihi")
        txt_sEvTelefonu.Text = dr_baslik("sEvTelefonu")
        txt_sGSM.Text = dr_baslik("sGSM")
        txt_sEmail.Text = Trim(dr_baslik("sEmail"))
        'txt_bYazismaEvAdresinemi.Checked = dr_baslik("bYazismaEvAdresinemi")
        txt_sCuzdanKayitNo.Text = dr_baslik("sCuzdanKayitNo").ToString
        txt_sUnvan.Text = Trim(dr_baslik("sUnvan"))
        txt_sVergiDairesi.Text = Trim(dr_baslik("sVergiDairesi"))
        txt_sVergiNo.Text = Trim(dr_baslik("sVergiNo"))
        txt_dteKrediAcilisTarihi.EditValue = dr_baslik("dteKrediAcilisTarihi")
        txt_dteKrediLimitiTarihi.EditValue = dr_baslik("kredidteKayitTarihi")
        txt_dteSonKullanmaTarihi.EditValue = dr_baslik("dteSonKullanmaTarihi")
        txt_nIskontoKredili.Text = dr_baslik("nIskontoKredili")
        txt_nIskontoPesin.Text = dr_baslik("nIskontoPesin")
        txt_lAylikGelir.Text = dr_baslik("lAylikGelir")
        txt_sEhliyetNo.Text = Trim(dr_baslik("sEhliyetNo"))
        txt_sKefil1Kod.Text = Trim(dr_baslik("sKefil1Kod").ToString)
        txt_sKefil1Aciklama.Text = Trim(dr_baslik("sKefil1Aciklama").ToString)
        txt_sKefil2Kod.Text = Trim(dr_baslik("sKefil2Kod").ToString)
        txt_sKefil2Aciklama.Text = Trim(dr_baslik("sKefil2Aciklama").ToString)
        txt_sKefil3Kod.Text = Trim(dr_baslik("sKefil3Kod").ToString)
        txt_sKefil3Aciklama.Text = Trim(dr_baslik("sKefil3Aciklama").ToString)
        txt_sKefil4Kod.Text = Trim(dr_baslik("sKefil4Kod").ToString)
        txt_sKefil4Aciklama.Text = Trim(dr_baslik("sKefil4Aciklama").ToString)
        If sorgu_sayi(lGeciken, 0) = 0 Then
            txt_lGeciken.Text = Format(sorgu_sayi(lGeciken, 0), "#,0.00")
        Else
            txt_lGeciken.Text = gecikmistaksitsayisi & " Adet : " & Format(sorgu_sayi(lGeciken, 0), "#,0.00")
        End If
        txt_lBakiye.Text = Format(sorgu_sayi(lBakiye, 0), "#,0.00")
        txt_lKrediLimiti.Text = Format(sorgu_sayi(dr_baslik("lKrediLimiti"), 0) - sorgu_sayi(lBakiye, 0), "#,0.00")
        If lGeciken > 0 Then
            BarButtonItem21.Caption = "Geciken Ödeme: " & gecikmistaksitsayisi & " Tutarý: " & FormatNumber(lGeciken, 2)
        Else
            BarButtonItem21.Caption = ""
        End If
        lBakiye = Nothing
        lGeciken = Nothing
        gecikmistaksitsayisi = Nothing
        BarButtonItem1.Caption = ""
        'Dogum Tarihi
        Dim gun_evlilik As String = ""
        Dim gun_dogum
        Dim yil
        Dim gun
        Dim ay
        If Trim(dr_baslik("dteDogumTarihi")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("dteDogumTarihi")).ToString.Substring(3, 2) = "01" Then
        ElseIf Trim(dr_baslik("dteDogumTarihi")).ToString.Substring(0, 5) = "01/01" Then
        Else
            'lbl_isim.Text += "  Doðum Tarihi :" & dr("DOGUMTARIHI").ToLongDateString
            yil = Today.ToString.Substring(8, 2)
            gun = dr_baslik("dteDogumTarihi").ToString.Substring(0, 2)
            ay = dr_baslik("dteDogumTarihi").ToString.Substring(3, 2)
            BarButtonItem1.Caption += "  Doðum Günü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
            gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
            If gun_dogum > 0 And gun_dogum < 30 Then
                BarButtonItem1.Caption += " " & gun_dogum & " Gün Sonra Doðum Gününüz.Þimdiden Doðum Gününüz Kutlu Olsun..!"
            ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                BarButtonItem1.Caption += " " & Math.Abs(gun_dogum) & " Gün Önce Doðum Gününüzmüþ...Nice Senelere..!"
            ElseIf gun_dogum = 0 Then
                BarButtonItem1.Caption += "  Doðum Gününüz Kutlu Olsun...!"
            End If
        End If
        'Evlilik Tarihi
        If Trim(dr_baslik("dteEvlilikTarihi")).ToString.Substring(0, 2) = "01" And Trim(dr_baslik("dteEvlilikTarihi")).ToString.Substring(3, 2) = "01" Then
        ElseIf Trim(dr_baslik("dteEvlilikTarihi")).ToString.Substring(0, 5) = "01/01" Then
        Else
            BarButtonItem1.Caption += "  Evlilik Tarihi :" & dr_baslik("dteEvlilikTarihi")
            yil = Today.ToString.Substring(8, 2)
            gun = dr_baslik("dteEvlilikTarihi").ToString.Substring(0, 2)
            ay = dr_baslik("dteEvlilikTarihi").ToString.Substring(3, 2)
            BarButtonItem1.Caption += "  Evlilik Yýldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
            gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
            If gun_dogum > 0 And gun_dogum < 30 Then
                BarButtonItem1.Caption += " " & gun_dogum & " Gün Sonra Evlilik Yýldönümünüz.Þimdiden Evlilik Yýldönümünüz Kutlu Olsun..!"
            ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                BarButtonItem1.Caption += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yýldönümünüzmüþ...Nice Senelere..!"
            ElseIf gun_dogum = 0 Then
                BarButtonItem1.Caption += " Evlilik Yýldönümünüz Kutlu Olsun...!"
            End If
        End If
        lbl_istihbarat.Text = Trim(sIstihbarat.ToString)
        Dim lHediyeCeki As Decimal = sorgu_lHediyeCeki_kontrol(nMusteriID)
        Dim lBekleyen As Int64 = sorgu_lBekleyen_kontrol(nMusteriID)
        Dim lPuan As Decimal = sorgu_AvHediyeCeki_kontrol(nMusteriID)
        If lBekleyen > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Müþterinin [" & lBekleyen & "] Adet Bekleyen Ürünü Var.." & vbCrLf & "Müþterinin Bekleyen Ürünlerini Görmek Ýster misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = MsgBoxResult.Yes Then
                analiz_bekleyen()
            End If
        End If
        If lHediyeCeki < 0 Then
            XtraMessageBox.Show(FormatNumber(Math.Abs(lHediyeCeki), 2) & Sorgu_sDil(" Tutarýnda Müþteri Alacaðý Bulunmaktadýr...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lbl_istihbarat.Text += vbCrLf & FormatNumber(Math.Abs(lHediyeCeki), 2) & " Tutarýnda Müþteri Alacaklý"
        ElseIf lHediyeCeki = 0 Then
        Else
            lbl_istihbarat.Text += vbCrLf & FormatNumber(Math.Abs(lHediyeCeki), 2) & " Tutarýnda Fazla Hediye Çeki Giriþi Yapýlmýþ"
        End If
        If lPuan > 0 Then
            XtraMessageBox.Show(FormatNumber(Math.Abs(lPuan), 2) & Sorgu_sDil(" Tutarinda Alisveris Puani Bulunmaktadýr...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            lbl_istihbarat.Text += vbCrLf & FormatNumber(Math.Abs(lPuan), 2) & " Tutarýnda AlisVeris Puani"
        End If
        lHediyeCeki = Nothing
        lPuan = Nothing
        lBekleyen = Nothing
        coldteTarihi.BestFit()
        PerakendeRiskGoster(nMusteriID)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub dataload_kasa()
        sec_kasa.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nKasaNo,sAciklama FROM tbParekendeKasa ")).Tables(0)
        sec_kasa.ItemIndex = 0
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO,bIptalYapabilirmi, bVadeFarksizOdemeAlirmi, nMaxIskontoYuzdesi FROM tbKasiyer WHERE (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_depo()
        sec_magaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDepo, sAciklama FROM tbDepo Where sDepo <> '' ")).Tables(0)
        sec_magaza.ItemIndex = 0
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim DS As New DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        adapter.Fill(DS, "TABLE1")
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
    Public Function tbMusteri(ByVal nMusteriID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.sMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbMusteri.nCinsiyet, tbMusteri.lAylikGelir, tbMusteri.dteKartAcilisTarihi, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, tbMusteri.sUnvan, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2,tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu, tbMusteri.sSigortaNo, tbMusteri.bEvlimi, tbMusteri.dteEvlilikTarihi, tbMusteri.dteDogumTarihi, tbMusteri.sDogumYeri, tbMusteri.sEhliyetNo, tbMusteri.sKanGrubu, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteri.sGSM, tbMusteri.sFax, tbMusteriKredisi.lKrediLimiti, tbMusteriKredisi.dteKrediLimitiTarihi, tbMusteriKredisi.dteKrediAcilisTarihi, tbMusteriKredisi.dteSonKullanmaTarihi, tbMusteriKredisi.bOzelMusterimi, tbMusteriKredisi.sKullaniciAdi, tbMusteriKredisi.dteKayitTarihi AS kredidteKayitTarihi, CAST(0 AS Money) AS lBakiye, CAST(0 AS Money) AS lGeciken,tbMusteriNufusu.sCuzdanKayitNo FROM tbMusteri LEFT OUTER JOIN tbMusteriKredisi ON tbMusteri.nMusteriID = tbMusteriKredisi.nMusteriID  LEFT OUTER JOIN tbMusteriNufusu ON tbMusteri.nMusteriID = tbMusteriNufusu.nMusteriID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ")")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.sMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbMusteri.nCinsiyet, tbMusteri.lAylikGelir, tbMusteri.dteKartAcilisTarihi, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, tbMusteri.sUnvan, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu, tbMusteri.sSigortaNo, tbMusteri.bEvlimi, tbMusteri.dteEvlilikTarihi, tbMusteri.dteDogumTarihi, tbMusteri.sDogumYeri, tbMusteri.sEhliyetNo, tbMusteri.sKanGrubu, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteri.sGSM, tbMusteri.sFax, ISNULL (tbMusteriKarti.nKartNo, ' ') as KartNo, tbMusteriKredisi.lKrediLimiti, tbMusteriKredisi.dteKrediLimitiTarihi, tbMusteriKredisi.dteKrediAcilisTarihi, tbMusteriKredisi.dteSonKullanmaTarihi, tbMusteriKredisi.bOzelMusterimi, tbMusteriKredisi.sKullaniciAdi, tbMusteriKredisi.dteKayitTarihi AS kredidteKayitTarihi, CAST(0 AS Money) AS lBakiye, CAST(0 AS Money) AS lGeciken, tbMusteriNufusu.sCuzdanKayitNo, tbMusteriKefil1.sSigortaNo AS sKefil1Kod, tbMusteriKefil1.sAdi + ' ' + tbMusteriKefil1.sSoyadi AS sKefil1Aciklama, tbMusteriKefil2.sSigortaNo AS sKefil2Kod, tbMusteriKefil2.sAdi + ' ' + tbMusteriKefil2.sSoyadi AS sKefil2Aciklama, tbMusteriKefil3.sSigortaNo AS sKefil3Kod, tbMusteriKefil3.sAdi + ' ' + tbMusteriKefil3.sSoyadi AS sKefil3Aciklama, tbMusteriKefil4.sSigortaNo AS sKefil4Kod, tbMusteriKefil4.sAdi + ' ' + tbMusteriKefil4.sSoyadi AS sKefil4Aciklama FROM tbMusteri LEFT OUTER JOIN tbMusteriKefil1 ON tbMusteri.nMusteriID = tbMusteriKefil1.nMusteriID LEFT OUTER JOIN tbMusteriKefil2 ON tbMusteri.nMusteriID = tbMusteriKefil2.nMusteriID LEFT OUTER JOIN tbMusteriKefil3 ON tbMusteri.nMusteriID = tbMusteriKefil3.nMusteriID LEFT OUTER JOIN tbMusteriKefil4 ON tbMusteri.nMusteriID = tbMusteriKefil4.nMusteriID LEFT OUTER JOIN tbMusteriKredisi ON tbMusteri.nMusteriID = tbMusteriKredisi.nMusteriID LEFT OUTER JOIN tbMusteriNufusu ON tbMusteri.nMusteriID = tbMusteriNufusu.nMusteriID LEFT OUTER JOIN tbMusteriKarti ON tbMusteri.nMusteriID = tbMusteriKarti.nMusteriID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ")")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_tbMusteriSinifi(ByVal nMusteriID As Int64)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi01 FROM tbParamMusteri) AS sSinifTipi, tbMSinif1.sSinifKodu, tbMSinif1.sAciklama, tbMSinif1.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi02 FROM tbParamMusteri) AS sSinifTipi, tbMSinif2.sSinifKodu, tbMSinif2.sAciklama, tbMSinif2.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi03 FROM tbParamMusteri) AS sSinifTipi, tbMSinif3.sSinifKodu, tbMSinif3.sAciklama, tbMSinif3.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi04 FROM tbParamMusteri) AS sSinifTipi, tbMSinif4.sSinifKodu, tbMSinif4.sAciklama, tbMSinif4.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi05 FROM tbParamMusteri) AS sSinifTipi, tbMSinif5.sSinifKodu, tbMSinif5.sAciklama, tbMSinif5.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5= tbMSinif5.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi06 FROM tbParamMusteri) AS sSinifTipi, tbMSinif6.sSinifKodu, tbMSinif6.sAciklama, tbMSinif6.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif6 ON tbMusteriSinifi.sSinifKodu6 = tbMSinif6.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi07 FROM tbParamMusteri) AS sSinifTipi, tbMSinif7.sSinifKodu, tbMSinif7.sAciklama, tbMSinif7.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif7 ON tbMusteriSinifi.sSinifKodu7 = tbMSinif7.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi08 FROM tbParamMusteri) AS sSinifTipi, tbMSinif8.sSinifKodu, tbMSinif8.sAciklama, tbMSinif8.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif8 ON tbMusteriSinifi.sSinifKodu8 = tbMSinif8.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi09 FROM tbParamMusteri) AS sSinifTipi, tbMSinif9.sSinifKodu, tbMSinif9.sAciklama, tbMSinif9.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif9 ON tbMusteriSinifi.sSinifKodu9 = tbMSinif9.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi10 FROM tbParamMusteri) AS sSinifTipi, tbMSinif10.sSinifKodu, tbMSinif10.sAciklama, tbMSinif10.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif10 ON tbMusteriSinifi.sSinifKodu10 = tbMSinif10.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi11 FROM tbParamMusteri) AS sSinifTipi, tbMSinif11.sSinifKodu, tbMSinif11.sAciklama, tbMSinif11.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif11 ON tbMusteriSinifi.sSinifKodu11 = tbMSinif11.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi12 FROM tbParamMusteri) AS sSinifTipi, tbMSinif12.sSinifKodu, tbMSinif12.sAciklama, tbMSinif12.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif12 ON tbMusteriSinifi.sSinifKodu12 = tbMSinif12.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi13 FROM tbParamMusteri) AS sSinifTipi, tbMSinif13.sSinifKodu, tbMSinif13.sAciklama, tbMSinif13.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif13 ON tbMusteriSinifi.sSinifKodu13 = tbMSinif13.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi14 FROM tbParamMusteri) AS sSinifTipi, tbMSinif14.sSinifKodu, tbMSinif14.sAciklama, tbMSinif14.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif14 ON tbMusteriSinifi.sSinifKodu14 = tbMSinif14.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        kriter += " UNION ALL"
        kriter += " SELECT tbMusteriSinifi.nMusteriID, (SELECT sSinifTipi15 FROM tbParamMusteri) AS sSinifTipi, tbMSinif15.sSinifKodu, tbMSinif15.sAciklama, tbMSinif15.bSatisYapilamaz FROM tbMusteriSinifi INNER JOIN tbMSinif15 ON tbMusteriSinifi.sSinifKodu15 = tbMSinif15.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        ds_sinif = sorgu(sorgu_query("" & kriter & ""))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_sinif.Tables(0)
    End Sub
    Private Sub dataload_tbMusteriSinif2(ByVal nMusteriID As Int64)
        Dim sinifI2 As String = ""
        Dim kriter = "SELECT tbMSinif2.sSinifKodu FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = " & nMusteriID & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query(kriter)
        sinifBilgi2 = cmd.ExecuteScalar.ToString()
    End Sub
    Private Sub dataload_odemeler(ByVal nMusteriID As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'ds_odemeler = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbTaksit.nAlisverisID, tbTaksit.nTaksitID, tbTaksit.dteTarihi, tbTaksit.lTutari, tbOdeme.dteValorTarihi, tbOdeme.lOdemeTutar, DATEDIFF([day], tbTaksit.dteTarihi, tbOdeme.dteValorTarihi) AS nGun FROM tbTaksit INNER JOIN tbOdeme ON tbTaksit.nTaksitID = tbOdeme.nTaksitID INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (DATEDIFF([day], tbTaksit.dteTarihi, tbOdeme.dteValorTarihi) > 0) AND (tbAlisVeris.nMusteriID = " & nMusteriID & ") ORDER BY tbTaksit.dteTarihi DESC, tbTaksit.nTaksitID")) kriter_musteri = " AND tbMusteri.lKodu = '" & Trim(musterino) & "' "
        Dim kriter_musteri As String = ""
        kriter_musteri = " AND tbMusteri.nMusteriID = '" & nMusteriID & "' "
        'ds_odemeler = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = tbAlisVeris.nAlisVerisID) AND (nOdemeKodu = 3)) Kapatma) AS TAHSILAT,CAST(0 AS MONEY) as lBakiye,tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & "  AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION ALL SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR ,SUM(TAHSILAT) AS TAHSILAT, CAST(0 AS MONEY) as lBakiye,'0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , 0 AS TUTAR ,SUM(tbOdeme.lOdemeTutar) AS TAHSILAT , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & " GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY TARIH,IZAHAT, BELGENO"))
        ds_odemeler = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) ) Kapatma) AS TAHSILAT,CAST(0 AS MONEY) as lBakiye,tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & "  AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION ALL SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR ,SUM(TAHSILAT) AS TAHSILAT, CAST(0 AS MONEY) as lBakiye,'0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , 0 AS TUTAR ,SUM(tbOdeme.lOdemeTutar) AS TAHSILAT , CAST(0 AS MONEY) as lBakiye,tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & " GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY TARIH,IZAHAT, BELGENO"))
        Dim dr As DataRow
        Dim bakiye As Decimal = 0
        Dim bakiye_status As String = 0
        For Each dr In ds_odemeler.Tables(0).Rows
            bakiye = bakiye + (dr("TUTAR") - (dr("TAHSILAT")))
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
        GridView2.OptionsView.ShowFooter = True
        collBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
        GridView2.UpdateSummary()
        dr = Nothing
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_odemeler.Tables(0)
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
        ds_taksitler = sorgu_taksitler(nMusteriID, sAralik)
        GridControl3.DataMember = Nothing
        GridControl3.DataSource = ds_taksitler.Tables(0)
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
            perakendeSKasiyer = sKasiyer
            perakendeSKasiyerRumuzu = sKasiyerRumuzu
            lbl_kasiyer.Text = sKasiyer
            sec_magaza.EditValue = sMagaza
            txt_kasiyer_kod.Enabled = False
            GridControl1.Enabled = True
            GridControl1.Focus()
            GridControl1.Select()
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
            GridControl1.Enabled = False
            Panel_Baslik.Enabled = False
            BarSubItem1.Enabled = False
            Panel_islem.Enabled = False
            If XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub Odeme(Optional ByVal nOdemeKodu = 2)
        If txt_musterino.EditValue <> "" Then
            dataload_kasiyer()
            kasiyer_kontrol(False)
            Dim pass As Boolean = True
            If GridView3.RowCount > 0 Or nOdemeKodu = 4 Then
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
                    frm.nOdemeKodu = nOdemeKodu
                    'If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                    dataload_taksitler(nMusteriID)
                    'End If
                ElseIf pass = False Then
                    XtraMessageBox.Show(Sorgu_sDil("Üzgünüm" & vbCrLf & "Gecikmiþ Borcu Olan Müþterilerden Ödeme Alma Yetkiniz Yok...!" & vbCrLf & "Lütfen Sistem Yöneticinizle Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                pass = Nothing
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Bir Müþteri Hesabý Seçiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
    End Sub
    Private Sub Satis(ByVal sFisTipi As String)
        If KayitSiniri_kontrol("tbAlisVeris", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True Then
            If txt_musterino.Text.ToString <> "" Then
                dataload_kasiyer()
                kasiyer_kontrol(False)
                Dim pass As Boolean = True
                Dim dr As DataRow
                If sFisTipi = "K" Or sFisTipi = "SK" Then
                    For Each dr In ds_sinif.Tables(0).Rows
                        If pass = True Then
                            If dr("bSatisYapilamaz") = True Then
                                pass = False
                            End If
                        End If
                    Next
                    If pass = True Then
                        For Each dr In ds_taksitler.Tables(0).Rows
                            If pass = True Then
                                If dr("GECIKME") > 1 Then
                                    pass = False
                                Else
                                    pass = True
                                End If
                            End If
                        Next
                        If pass = False Then
                            pass = sorgu_bGecikmeIzinlimi(sec_magaza.EditValue)
                        End If
                    End If
                Else
                    pass = True
                End If
                If pass = True Then
                    Dim frm As New frm_Perakende_Satis
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.kullanici = kullanici
                    frm.sKasiyer = sKasiyer
                    frm.sKasiyerRumuzu = sKasiyerRumuzu
                    frm.sMagaza = sec_magaza.EditValue
                    frm.dteFisTarihi = DateEdit1.EditValue
                    frm.nMusteriID = nMusteriID
                    frm.nKasaNo = sec_kasa.EditValue
                    frm.sAdi = sAdi
                    frm.sSoyadi = sSoyadi
                    frm.sAdres1 = sAdres1
                    frm.sAdres2 = sAdres2
                    frm.sVergiDairesi = sVergiDairesi
                    frm.sVergiNo = sVergiNo
                    frm.sFisTipi = sFisTipi
                    frm.nAlisVerisID = ""
                    frm.bFisYenimi = True
                    frm.btn_FisYeni.Enabled = True
                    frm.bIptalYapabilirmi = bIptalYapabilirmi
                    frm.bVadeFarksizOdemeAlirmi = bVadeFarksizOdemeAlirmi
                    frm.nMaxIskontoYuzdesi = nMaxIskontoYuzdesi
                    If sDatabaseGenel = "UGURLU" Then
                        frm.sinifBilgi2 = ""
                        If sFisTipi = "K" Then
                            frm.Text = "Kredili Perakende Satýþ..."
                            frm.sFiyatTipi = sKrediliFiyat
                            frm.sinifBilgi2 = sinifBilgi2
                        ElseIf sFisTipi = "P" Then
                            frm.Text = "Peþin Perakende Satýþ..."
                            frm.sFiyatTipi = sPesinFiyat
                            frm.sinifBilgi2 = sinifBilgi2
                        ElseIf sFisTipi = "SP" Then
                            frm.Text = "Peþin Perakende Sipariþ..."
                            frm.sFiyatTipi = sPesinFiyat
                            frm.sinifBilgi2 = sinifBilgi2
                        ElseIf sFisTipi = "SK" Then
                            frm.Text = "Kredili Perakende Sipariþ..."
                            frm.sFiyatTipi = sKrediliFiyat
                            frm.sinifBilgi2 = sinifBilgi2
                        End If
                    Else
                        If sFisTipi = "K" Then
                            frm.Text = "Kredili Perakende Satýþ..."
                            frm.sFiyatTipi = sKrediliFiyat
                        ElseIf sFisTipi = "P" Then
                            frm.Text = "Peþin Perakende Satýþ..."
                            frm.sFiyatTipi = sPesinFiyat
                        ElseIf sFisTipi = "SP" Then
                            frm.Text = "Peþin Perakende Sipariþ..."
                            frm.sFiyatTipi = sPesinFiyat
                        ElseIf sFisTipi = "SK" Then
                            frm.Text = "Kredili Perakende Sipariþ..."
                            frm.sFiyatTipi = sKrediliFiyat
                        End If
                    End If
                    'If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.Show()
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Üzgünüm" & vbCrLf & "Müþteri Hesabýna Satýþ Yetkisi Yok...!" & vbCrLf & "Lütfen Sistem Yöneticinizle Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Lütfen Bir Müþteri Hesabý Seçiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
                txt_musterino.Focus()
                txt_musterino.SelectAll()
            End If
        End If
    End Sub
    Private Sub Teslimat()
        If txt_musterino.EditValue <> "" Then
            Dim frm As New frm_Perakende_Teslimat
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.sKasiyer = sKasiyer
            frm.sKasiyerRumuzu = sKasiyerRumuzu
            frm.sMagaza = sec_magaza.EditValue
            frm.txt_kasiyer_kod.EditValue = txt_kasiyer_kod.EditValue
            frm.lbl_kasiyer.Text = lbl_kasiyer.Text
            frm.sec_magaza.EditValue = sec_magaza.EditValue
            frm.nMusteriID = nMusteriID
            frm.txt_musterino.EditValue = txt_musterino.EditValue
            frm.lbl_musteri_adi.Text = lbl_musteri_adi.Text
            frm.sAdi = sAdi
            frm.sSoyadi = sSoyadi
            frm.sAdres1 = sAdres1
            frm.sAdres2 = sAdres2
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Bir Müþteri Hesabý Seçiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
    End Sub
    Private Sub masraflar()
        Dim frm As New frm_perakende_masraf
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sKasiyer = sKasiyer
        frm.sKasiyerRumuzu = sKasiyerRumuzu
        frm.sMagaza = sec_magaza.EditValue
        frm.txt_kasiyer_kod.EditValue = txt_kasiyer_kod.EditValue
        frm.lbl_kasiyer.Text = lbl_kasiyer.Text
        frm.sec_magaza.EditValue = sec_magaza.EditValue
        frm.nKasaNo = sec_kasa.EditValue
        frm.DateEdit1.EditValue = DateEdit1.EditValue
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub VadeDuzenle()
        Dim frm As New frm_Perakende_VadeDuzenle
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.nMusteriID = nMusteriID
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub VadeFarki()
        Dim frm As New frm_Perakende_VadeFarki
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sKasiyer = sKasiyer
        frm.sKasiyerRumuzu = sKasiyerRumuzu
        frm.sMagaza = sec_magaza.EditValue
        'frm.txt_kasiyer_kod.EditValue = txt_kasiyer_kod.EditValue
        'frm.lbl_kasiyer.Text = lbl_kasiyer.Text
        'frm.sec_magaza.EditValue = sec_magaza.EditValue
        frm.nKasaNo = sec_kasa.EditValue
        'frm.DateEdit1.EditValue = DateEdit1.EditValue
        Dim pass As Boolean = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            For Each dr In ds_taksitler.Tables(0).Rows
                If dr("GECIKME") > 0 Then
                    dr1 = frm.DataSet1.Tables(0).NewRow
                    dr1(0) = DateEdit1.EditValue
                    dr1(1) = dr("dteTarihi")
                    dr1(2) = dr("KALAN")
                    dr1(3) = dr("GECIKME")
                    dr1(4) = ((dr("KALAN") * 10) / 100) * (dr("GECIKME") / 30)
                    dr1(5) = dr1(2) + dr1(4)
                    frm.DataSet1.Tables(0).Rows.Add(dr1)
                End If
            Next
            frm.ShowDialog()
        End If
    End Sub
    Private Sub musteri_sec()
        If Trim(sKasiyerRumuzu.ToString) <> "" Then
            Dim frm As New frm_musteri_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.musterino = dr_baslik("FIRMAKODU")
            frm.islemstatus = True
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                nMusteriID = dr1("nMusteriID")
                lKodu = dr1("lKodu")
                'lbl_musteri_adi.Text = dr1("Musteri")
                txt_musterino.EditValue = lKodu
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
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musterino.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    lKodu = dr("MUSTERIKODU")
                    nMusteriID = dr("IND")
                    lbl_musteri_adi.Text = dr("MUSTERI")
                    sAdi = dr("sAdi").ToString
                    sSoyadi = dr("sSoyadi").ToString
                    sAdres1 = dr("sAdres1").ToString
                    sAdres2 = dr("sAdres2").ToString
                    sVergiDairesi = dr("sVergiDairesi").ToString
                    sVergiNo = dr("sVergiNo").ToString
                    dataload(nMusteriID)
                Next
                dr = Nothing
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Sayýsal Veri Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        kriter = "WHERE (lKodu = '" & kod & "') and (bMusteriAktif = 1)"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS KAYIT FROM tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_cari_no(ByVal lKodu As String, ByVal ops As String, ByVal siralama As String, ByVal bakiyeli As Boolean) As Int64
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        If Trim(lKodu.ToString) = "" Then
            lKodu = "0"
        End If
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If bakiyeli = False Then
            If ops = "I<" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lKodu, 0) AS lKodu FROM         tbMusteri  " & kriter & " ORDER BY lKodu " & siralama & " ")
            ElseIf ops = "<" Then
                kriter += " Where lKodu < " & lKodu & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lKodu, 0) AS lKodu FROM         tbMusteri  " & kriter & " ORDER BY lKodu " & siralama & " ")
            ElseIf ops = ">" Then
                kriter += " Where lKodu > " & lKodu & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lKodu, 0) AS lKodu FROM         tbMusteri  " & kriter & " ORDER BY lKodu " & siralama & " ")
            ElseIf ops = ">I" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lKodu, 0) AS lKodu FROM         tbMusteri  " & kriter & " ORDER BY lKodu " & siralama & " ")
            End If
        ElseIf bakiyeli = True Then
            If ops = "I<" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(dbo.tbMusteri.lKodu, 0) AS lKodu FROM dbo.tbMusteri LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lNetTutar - lPesinat) , 0) + isnull(SUM(lVadeFarki) , 0) AS ToplamAlisveris FROM tbAlisVeris WHERE (sFisTipi = 'K' OR sFisTipi = 'SK' OR sFistipi = 'KVF' OR sFistipi = 'PAD') AND nGirisCikis = 3 GROUP BY nMusteriID) TEMPAlisveris ON TEMPAlisveris.nMusteriID = dbo.tbMusteri.nMusteriID LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lOdemeTutar) , 0) AS ToplamOdeme FROM tbAlisVeris , tbOdeme WHERE tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID AND nOdemeKodu <> 1 GROUP BY nMusteriID) TEMPOdeme ON TEMPOdeme.nMusteriID = dbo.tbMusteri.nMusteriID WHERE (ISNULL(TEMPAlisveris.ToplamAlisveris, 0) - ISNULL(TEMPOdeme.ToplamOdeme, 0) <> 0) " & kriter & " ORDER BY tbMusteri.nMusteriID " & siralama & "")
            ElseIf ops = "<" Then
                kriter += " AND tbMusteri.lKodu < " & lKodu & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(dbo.tbMusteri.lKodu, 0) AS lKodu FROM dbo.tbMusteri LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lNetTutar - lPesinat) , 0) + isnull(SUM(lVadeFarki) , 0) AS ToplamAlisveris FROM tbAlisVeris WHERE (sFisTipi = 'K' OR sFisTipi = 'SK' OR sFistipi = 'KVF' OR sFistipi = 'PAD') AND nGirisCikis = 3 GROUP BY nMusteriID) TEMPAlisveris ON TEMPAlisveris.nMusteriID = dbo.tbMusteri.nMusteriID LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lOdemeTutar) , 0) AS ToplamOdeme FROM tbAlisVeris , tbOdeme WHERE tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID AND nOdemeKodu <> 1 GROUP BY nMusteriID) TEMPOdeme ON TEMPOdeme.nMusteriID = dbo.tbMusteri.nMusteriID WHERE (ISNULL(TEMPAlisveris.ToplamAlisveris, 0) - ISNULL(TEMPOdeme.ToplamOdeme, 0) <> 0) " & kriter & " ORDER BY tbMusteri.nMusteriID " & siralama & "")
            ElseIf ops = ">" Then
                kriter += " AND tbMusteri.lKodu > " & lKodu & " "
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(dbo.tbMusteri.lKodu, 0) AS lKodu FROM dbo.tbMusteri LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lNetTutar - lPesinat) , 0) + isnull(SUM(lVadeFarki) , 0) AS ToplamAlisveris FROM tbAlisVeris WHERE (sFisTipi = 'K' OR sFisTipi = 'SK' OR sFistipi = 'KVF' OR sFistipi = 'PAD') AND nGirisCikis = 3 GROUP BY nMusteriID) TEMPAlisveris ON TEMPAlisveris.nMusteriID = dbo.tbMusteri.nMusteriID LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lOdemeTutar) , 0) AS ToplamOdeme FROM tbAlisVeris , tbOdeme WHERE tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID AND nOdemeKodu <> 1 GROUP BY nMusteriID) TEMPOdeme ON TEMPOdeme.nMusteriID = dbo.tbMusteri.nMusteriID WHERE (ISNULL(TEMPAlisveris.ToplamAlisveris, 0) - ISNULL(TEMPOdeme.ToplamOdeme, 0) <> 0) " & kriter & " ORDER BY tbMusteri.nMusteriID " & siralama & "")
            ElseIf ops = ">I" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(dbo.tbMusteri.lKodu, 0) AS lKodu FROM dbo.tbMusteri LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lNetTutar - lPesinat) , 0) + isnull(SUM(lVadeFarki) , 0) AS ToplamAlisveris FROM tbAlisVeris WHERE (sFisTipi = 'K' OR sFisTipi = 'SK' OR sFistipi = 'KVF' OR sFistipi = 'PAD') AND nGirisCikis = 3 GROUP BY nMusteriID) TEMPAlisveris ON TEMPAlisveris.nMusteriID = dbo.tbMusteri.nMusteriID LEFT OUTER JOIN (SELECT nMusteriID , isnull(SUM(lOdemeTutar) , 0) AS ToplamOdeme FROM tbAlisVeris , tbOdeme WHERE tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID AND nOdemeKodu <> 1 GROUP BY nMusteriID) TEMPOdeme ON TEMPOdeme.nMusteriID = dbo.tbMusteri.nMusteriID WHERE (ISNULL(TEMPAlisveris.ToplamAlisveris, 0) - ISNULL(TEMPOdeme.ToplamOdeme, 0) <> 0) " & kriter & " ORDER BY tbMusteri.nMusteriID " & siralama & "")
            End If
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nMusteriID AS IND, lKodu AS MUSTERIKODU,sAdi,sSoyadi, sAdi + ' ' + sSoyadi AS MUSTERI,sEvAdresi1 as sAdres1, sEvAdresi2 as sAdres2,sVergiDairesi,sVergiNo FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub analiz_acik_faturalar()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = nMusteriID
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
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = nMusteriID
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
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = lKodu
            frm.musteriID = nMusteriID
            frm.kullanici = kullanici
            frm.lbl_Firma.Text = lbl_musteri_adi.Text
            frm.sKasiyer = sKasiyer
            frm.sKasiyerRumuzu = sKasiyerRumuzu
            frm.sMagaza = sec_magaza.EditValue
            frm.nMusteriID = nMusteriID
            frm.nKasaNo = sec_kasa.EditValue
            frm.sAdi = sAdi
            frm.sSoyadi = sSoyadi
            frm.sAdres1 = sAdres1
            frm.sAdres2 = sAdres2
            frm.bIptalYapabilirmi = bIptalYapabilirmi
            frm.bVadeFarksizOdemeAlirmi = bVadeFarksizOdemeAlirmi
            frm.nMaxIskontoYuzdesi = nMaxIskontoYuzdesi
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre_ozet()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = lKodu
            frm.musteriID = nMusteriID
            frm.kullanici = kullanici
            frm.lbl_Firma.Text = lbl_musteri_adi.Text
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = lKodu
            frm.musteriID = nMusteriID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = lKodu
            frm.musteriID = nMusteriID
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
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lKodu = lKodu
            frm.nMusteriID = nMusteriID
            frm.kullanici = kullanici
            'If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
            'End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_bekleyen()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_satis_bekleyen_onaysiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.firmakodu = lKodu
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eþittir"
            frm.islemstatus = True
            frm.kullanici = kullanici
            frm.ShowDialog()
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_KarlilikAkisTablosu(Optional ByVal islem As Integer = 0)
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
            frm.sec_MaliyetTipi.Text = "Stok Kartýndan"
            frm.kriter_musteriID = "AND tbMusteri.nMusteriID = " & nMusteriID & " "
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
    Private Sub analiz_musteri_pesinatlar()
        If nMusteriID >= 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Perakende_Pesinatlar
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = nMusteriID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub incele_fis()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If Trim(dr("IZAHAT")).ToString = "OD" Then
                stok_odeme_detay()
            Else
                stok_satis_detay()
            End If
        End If
    End Sub
    Private Sub stok_satis_detay()
        Dim frm As New frm_stok_cari_satis
        Dim dr As DataRow
        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.stokno = dr("ALISVERISNO")
        frm.fistipi = Trim(dr("IZAHAT").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        dr = Nothing
    End Sub
    Private Sub stok_odeme_detay()
        Dim frm As New frm_stok_cari_odeme
        Dim dr As DataRow
        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.musterikodu = dr("FIRMAKODU")
        frm.tarih = dr("TARIH")
        frm.belgeno = dr("BELGENO")
        'frm.stokno = dr("ALISVERISNO")
        frm.fistipi = Trim(dr("IZAHAT").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        dr = Nothing
    End Sub
    Private Sub musteri_notlari()
        Dim frm As New frm_musteri_karti_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = nMusteriID
        frm.kullanici = kullanici
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
                    txt_musterino.Text = frm.yeniMusteriKodu
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
            cmd.CommandText = sorgu_query("delete from tbMusteriKefil3 where nMusteriID = " & nMusteriID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMusteriKefil4 where nMusteriID = " & nMusteriID & "")
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
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            musteri_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub stok_odeme_detay_tumu()
        If nMusteriID >= 0 Then
            Dim frm As New frm_stok_cari_odeme
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.musterikodu = lKodu
            frm.tarih = Today
            frm.belgeno = 1
            frm.tumu = True
            'frm.stokno = dr("ALISVERISNO")
            'frm.fistipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub SMS_Gonder()
        If XtraMessageBox.Show(Sorgu_sDil("SMS Göndermek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            If Trim(txt_sGSM.Text.ToString) <> "" Then
                Dim dr_baslik As DataRow = ds_Musteri.Tables(0).Rows(0)
                Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                dr1("nIslemID") = 0
                dr1("sSMSID") = 0
                dr1("dteGonderimTarihi") = Today
                dr1("sMesaj") = ""
                dr1("nMusteriID") = txt_nMusteriID.Text
                dr1("lKodu") = txt_musterino.Text
                dr1("sAdi") = txt_sAdi.Text
                dr1("sSoyadi") = txt_sSoyadi.Text
                dr1("sTelefon") = dr_baslik("sGSM")
                dr1("dteUpdateTarihi") = Now
                dr1("lDurum") = 0
                dr1("lBakiye") = txt_lBakiye.Text
                frm.DataSet1.Tables(0).Rows.Add(dr1)
            End If
            'MsgBox(Sorgu_sDil("Ýþlem Tamamlandý...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
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
            deger = InputBox("MüþteriNumarasýný Okutun", "MüþteriKartOkut", "").ToString
            If deger.ToString <> "" Then
                txt_musterino.Text = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Decimal)
                musteri_kontrol()
            End If
            deger = Nothing
        End If
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Perakende Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        musteri_sec()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        musteri_notlari()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_musteri_duzenle()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        stok_odeme_detay_tumu()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        stok_odeme_detay_tumu()
    End Sub
    Private Sub sec_kasa_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_kasa.EditValueChanged
        lbl_kasa.Text = sec_kasa.Text
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Odeme()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Satis("K")
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Satis("P")
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        tbMusteri_yeni()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbMusteri_sil(nMusteriID)
        End If
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        masraflar()
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
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        VadeFarki()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        VadeDuzenle()
    End Sub
    Private Sub btn_yenile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_yenile.Click
        musteri_kontrol()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Perakende Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btn_Musteri_sec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_sec.Click
        musteri_sec()
    End Sub
    Private Sub btn_Musteri_Yeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Yeni.Click
        tbMusteri_yeni()
    End Sub
    Private Sub btn_Musteri_Kart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Kart.Click
        analiz_musteri_karti()
    End Sub
    Private Sub btn_Musteri_Not_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Not.Click
        musteri_notlari()
    End Sub
    Private Sub btn_Musteri_Duzelt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Musteri_Duzelt.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub btn_Islem_Satis_Kredili_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_Satis_Kredili.Click
        Satis("K") 'Kredili Satis
    End Sub
    Private Sub btn_Islem_Satis_Pesin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_Satis_Pesin.Click
        Satis("P") 'Pesin Satis
    End Sub
    Private Sub btn_Islem_Siparis_Kredili_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_Siparis_Kredili.Click
        Satis("SK") 'Sonradan Teslim Kredili Satis
    End Sub
    Private Sub btn_Islem_Siparis_Pesin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_Siparis_Pesin.Click
        Satis("SP") 'Sonradan Teslim Pesin Satis
    End Sub
    Private Sub btn_Islem_Odeme_Al_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_Odeme_Al.Click
        Odeme()
    End Sub
    Private Sub btn_Islem_VadeFarki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_VadeFarki.Click
        VadeFarki()
    End Sub
    Private Sub btn_Islem_Teslimat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_Teslimat.Click
        Teslimat()
    End Sub
    Private Sub btn_Islem_VadeAyarla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Islem_VadeAyarla.Click
        VadeDuzenle()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub btn_Raporlar_Ekstre_Detayli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Raporlar_Ekstre_Detayli.Click
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub btn_Ekstre_Ozet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ekstre_Ozet.Click
        analiz_musteri_hareket_ekstre_ozet()
    End Sub
    Private Sub btn_Analiz_Odemeler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Odemeler.Click
        stok_odeme_detay_tumu()
    End Sub
    Private Sub btn_Analiz_Kalan_Satislar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Kalan_Satislar.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub btn_Analiz_Kalan_Taksitler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Kalan_Taksitler.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub btn_Analiz_Satislar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Satislar.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub btn_Analiz_Satislar_Bekleyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Analiz_Satislar_Bekleyen.Click
        analiz_bekleyen()
    End Sub
    Private Sub GridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        incele_fis()
    End Sub
    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Enter Then
            incele_fis()
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Odemeler.Click
        dataload_taksitler(nMusteriID, btn_Odemeler.Text)
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        analiz_acik_faturalar_analiz()
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
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
    Private Sub txt_sKefil1Kod_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sKefil1Kod.DoubleClick
        If txt_sKefil1Kod.Text = "" Then
        Else
            If IsNumeric(txt_sKefil1Kod.Text) = True Then
                txt_musterino.Text = txt_sKefil1Kod.Text
                musteri_kontrol()
                txt_musterino.Focus()
                txt_musterino.SelectAll()
            End If
        End If
    End Sub
    Private Sub txt_sKefil2Kod_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sKefil2Kod.DoubleClick
        If txt_sKefil2Kod.Text = "" Then
        Else
            If IsNumeric(txt_sKefil2Kod.Text) = True Then
                txt_musterino.Text = txt_sKefil2Kod.Text
                musteri_kontrol()
                txt_musterino.Focus()
                txt_musterino.SelectAll()
            End If
        End If
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Odeme(4)
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        analiz_musteri_pesinatlar()
    End Sub
    Private Sub frm_perakende_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        perakendeSKasiyer = ""
        perakendeSKasiyerRumuzu = ""
    End Sub
    Private Sub TextEdit1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(sKasiyerRumuzu.ToString) <> "" Then
                Dim frm As New frm_musteri_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                'frm.musterino = dr_baslik("FIRMAKODU")
                frm.islemstatus = True
                frm.kullanici = kullanici
                frm.txt_ara.EditValue = TextEdit1.EditValue
                frm.goster = True
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim dr1 As DataRow
                    dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                    nMusteriID = dr1("nMusteriID")
                    lKodu = dr1("lKodu")
                    'lbl_musteri_adi.Text = dr1("Musteri")
                    txt_musterino.EditValue = lKodu
                    musteri_kontrol()
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Lütfen Kasiyer Bilgilerinizi Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
    End Sub

    ' === PERAKENDE RISK GOSTERGESI METODU ===
    Private Sub PerakendeRiskGoster(ByVal nMusteriID As Int64)
        Try
            If nMusteriID <= 0 Then Exit Sub

            ' Parametrik kontrol
            Dim connRisk As New OleDb.OleDbConnection(connection)
            connRisk.Open()
            Dim cmdRisk As New OleDb.OleDbCommand(sorgu_query("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu='PERAKENDE_RISK_AKTIF'"), connRisk)
            Dim sPerakendeRiskAktif As String = ""
            Try : sPerakendeRiskAktif = cmdRisk.ExecuteScalar().ToString() : Catch : End Try
            If sPerakendeRiskAktif <> "1" Then
                connRisk.Close()
                If pnlPerakendeRisk IsNot Nothing Then pnlPerakendeRisk.Visible = False
                Exit Sub
            End If

            ' Bakiye hesapla
            cmdRisk.CommandText = sorgu_query("SELECT ISNULL(SUM(lNetTutar),0) FROM tbAlisVeris WHERE nMusteriID=" & nMusteriID & " AND nGirisCikis=2")
            Dim bakiyeBorc As Decimal = CDec(cmdRisk.ExecuteScalar())
            cmdRisk.CommandText = sorgu_query("SELECT ISNULL(SUM(o.lOdemeTutar),0) FROM tbOdeme o INNER JOIN tbAlisVeris a ON o.nAlisverisID = a.nAlisverisID WHERE a.nMusteriID=" & nMusteriID)
            Dim bakiyeAlacak As Decimal = CDec(cmdRisk.ExecuteScalar())
            Dim bakiye As Decimal = bakiyeBorc - bakiyeAlacak

            ' Kredi limiti
            cmdRisk.CommandText = sorgu_query("SELECT ISNULL(lKrediLimiti,0) FROM tbMusteriKredisi WHERE nMusteriID=" & nMusteriID)
            Dim krediLimiti As Decimal = CDec(cmdRisk.ExecuteScalar())

            ' Risk hesapla
            Dim limitKullanim As Decimal = If(krediLimiti > 0, bakiye / krediLimiti, 0)
            Dim skor As Integer = 100
            If limitKullanim > 0.9D Then skor -= 25
            If limitKullanim > 0.7D Then skor -= 10
            If bakiye > krediLimiti AndAlso krediLimiti > 0 Then skor -= 20
            skor = Math.Max(0, Math.Min(100, skor))

            Dim seviye As String = If(skor >= 70, "GUVENLI", If(skor >= 40, "DIKKAT", "KRITIK"))
            Dim renk As Color = If(skor >= 70, Color.FromArgb(39, 174, 96), If(skor >= 40, Color.FromArgb(243, 156, 18), Color.FromArgb(231, 76, 60)))

            If pnlPerakendeRisk Is Nothing Then
                pnlPerakendeRisk = New Panel()
                pnlPerakendeRisk.Dock = DockStyle.Bottom
                pnlPerakendeRisk.Height = 30
                pnlPerakendeRisk.Padding = New Padding(8, 4, 8, 4)

                lblPerakendeRisk = New Label()
                lblPerakendeRisk.AutoSize = True
                lblPerakendeRisk.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                lblPerakendeRisk.ForeColor = Color.White
                lblPerakendeRisk.Location = New Point(8, 6)

                pnlPerakendeRisk.Controls.Add(lblPerakendeRisk)
                Me.Controls.Add(pnlPerakendeRisk)
            End If

            pnlPerakendeRisk.BackColor = renk
            lblPerakendeRisk.Text = "Risk: " & skor & "/100 (" & seviye & ") | Bakiye: " & bakiye.ToString("N2") & " TL" & _
                If(krediLimiti > 0, " | Limit: %" & Math.Round(limitKullanim * 100, 0), "")
            pnlPerakendeRisk.Visible = True
            connRisk.Close()
        Catch ex As Exception
            ' Hata risk gostergesini engellemez
            If pnlPerakendeRisk IsNot Nothing Then pnlPerakendeRisk.Visible = False
        End Try
    End Sub
End Class