Imports Microsoft.Win32
Imports System.Windows.Forms
Imports FastReport
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_kasiyer_dokum_liste_kontrol
    Inherits DevExpress.XtraEditors.XtraForm
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_ts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_to As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_dotmatrix As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_goster As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_analiz As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kasiyer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents btn_baglan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_belgeno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents lbl_isim As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOYADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALISVERISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVADEFARKI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAGAZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASIYER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYAZI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOGUMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVLILIKTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYAZDIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOZLESME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl3 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_satis_kapatma As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents Grid_odemeler As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents grid_odemeler_kalan As DevExpress.XtraPivotGrid.PivotGridControl
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
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents panel_info As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_alt As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_hareket As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_hareketler As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Context_satis As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Context_odeme As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents printlink3 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsOdemeSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid_satis_pesinat As DevExpress.XtraGrid.GridControl
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKalanTaksit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSevkAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokOdeme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIslemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIadeAvInf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeslimatci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitterControl4 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_satis_detay As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_alisveris As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ustlimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_altlimit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents sec_belgetipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_renkadi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_kasiyer_dokum_liste_kontrol))
        Me.panel_info = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.panel_alt = New DevExpress.XtraEditors.PanelControl
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.panel_hareket = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.Grid_satis_detay = New DevExpress.XtraGrid.GridControl
        Me.Context_satis = New System.Windows.Forms.ContextMenu
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_renkadi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SplitterControl4 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.Grid_satis_pesinat = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsOdemeSekli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.Grid_satis_kapatma = New DevExpress.XtraGrid.GridControl
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFis_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFis_Tipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFis_Musteri_Tanimlama_No = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFis_Musteri_Kodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFis_Musteri_Adi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFis_Musteri_Soyadi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTaksit_Fis_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTaksit_Tarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTaksit_Tutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAlisveris_TanimlamaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMusteri_Taksiti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOdeme_tutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.Grid_odemeler = New DevExpress.XtraGrid.GridControl
        Me.Context_odeme = New System.Windows.Forms.ContextMenu
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
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
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SplitterControl3 = New DevExpress.XtraEditors.SplitterControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.grid_odemeler_kalan = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.Panel_hareketler = New DevExpress.XtraEditors.PanelControl
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl
        Me.barlabel = New DevExpress.XtraEditors.LabelControl
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colADI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSOYADI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colALISVERISNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVADEFARKI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMAGAZA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKASIYER = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYAZI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDOGUMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEVLILIKTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYAZDIRMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKAYIT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSOZLESME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_goster = New DevExpress.XtraEditors.CheckEdit
        Me.sec_analiz = New DevExpress.XtraEditors.CheckEdit
        Me.sec_ts = New DevExpress.XtraEditors.CheckEdit
        Me.sec_to = New DevExpress.XtraEditors.CheckEdit
        Me.sec_dotmatrix = New DevExpress.XtraEditors.CheckEdit
        Me.Label10 = New DevExpress.XtraEditors.LabelControl
        Me.txt_ustlimit = New DevExpress.XtraEditors.CalcEdit
        Me.Label11 = New DevExpress.XtraEditors.LabelControl
        Me.txt_altlimit = New DevExpress.XtraEditors.CalcEdit
        Me.sec_belgetipi = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.sec_alisveris = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.lbl_isim = New DevExpress.XtraEditors.LabelControl
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_belgeno = New DevExpress.XtraEditors.ButtonEdit
        Me.txt_musterino = New DevExpress.XtraEditors.ButtonEdit
        Me.btn_baglan = New DevExpress.XtraEditors.SimpleButton
        Me.txt_kasiyer = New DevExpress.XtraEditors.TextEdit
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKalanTaksit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSevkAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStokOdeme = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnIslemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIadeAvInf = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOdemeAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTeslimatci = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOdemeTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.panel_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_info.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_alt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_alt.SuspendLayout()
        CType(Me.panel_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_hareket.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Grid_satis_detay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renkadi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.Grid_satis_pesinat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Grid_satis_kapatma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.Grid_odemeler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grid_odemeler_kalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_hareketler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_hareketler.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_goster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_analiz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_to.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_dotmatrix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ustlimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_altlimit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_belgetipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_alisveris.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_info
        '
        Me.panel_info.Controls.Add(Me.Label1)
        Me.panel_info.Controls.Add(Me.PictureBox1)
        Me.panel_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_info.Location = New System.Drawing.Point(0, 22)
        Me.panel_info.Name = "panel_info"
        Me.panel_info.Size = New System.Drawing.Size(896, 56)
        Me.panel_info.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Aþaðýda Döküm Emirlerini Görmektesiniz. Ýþlem Yapmak Ýstediðiniz Emri seçmek için" & _
            " Ýlgili kaydýn üstüne geliniz..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'panel_alt
        '
        Me.panel_alt.Controls.Add(Me.Label5)
        Me.panel_alt.Controls.Add(Me.SimpleButton5)
        Me.panel_alt.Controls.Add(Me.SimpleButton4)
        Me.panel_alt.Controls.Add(Me.SimpleButton2)
        Me.panel_alt.Controls.Add(Me.SimpleButton1)
        Me.panel_alt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_alt.Location = New System.Drawing.Point(0, 630)
        Me.panel_alt.Name = "panel_alt"
        Me.panel_alt.Size = New System.Drawing.Size(896, 48)
        Me.panel_alt.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(91, 16)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton5.TabIndex = 6
        Me.SimpleButton5.Text = "&Yazdýr"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(16, 16)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "&Yenile"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(808, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(728, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'panel_hareket
        '
        Me.panel_hareket.Controls.Add(Me.PanelControl5)
        Me.panel_hareket.Controls.Add(Me.PanelControl4)
        Me.panel_hareket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_hareket.Location = New System.Drawing.Point(0, 78)
        Me.panel_hareket.Name = "panel_hareket"
        Me.panel_hareket.Size = New System.Drawing.Size(896, 552)
        Me.panel_hareket.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl5.Controls.Add(Me.SplitterControl1)
        Me.PanelControl5.Controls.Add(Me.Panel_hareketler)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 122)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(892, 428)
        Me.PanelControl5.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 190)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(888, 236)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage1.Controls.Add(Me.SplitterControl4)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl6)
        Me.XtraTabPage1.Controls.Add(Me.SplitterControl2)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(886, 203)
        Me.XtraTabPage1.Text = "Satýþ/Sipariþ Detayý"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.Grid_satis_detay)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(418, 203)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Ürün Detaylarý"
        '
        'Grid_satis_detay
        '
        Me.Grid_satis_detay.ContextMenu = Me.Context_satis
        Me.Grid_satis_detay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_detay.Location = New System.Drawing.Point(2, 15)
        Me.Grid_satis_detay.MainView = Me.GridView3
        Me.Grid_satis_detay.Name = "Grid_satis_detay"
        Me.Grid_satis_detay.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renkadi})
        Me.Grid_satis_detay.Size = New System.Drawing.Size(414, 186)
        Me.Grid_satis_detay.TabIndex = 2
        Me.Grid_satis_detay.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'Context_satis
        '
        Me.Context_satis.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39})
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem28.Text = "Envanter"
        '
        'MenuItem29
        '
        Me.MenuItem29.Enabled = False
        Me.MenuItem29.Index = 1
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem29.Text = "Model Envanter"
        '
        'MenuItem30
        '
        Me.MenuItem30.Enabled = False
        Me.MenuItem30.Index = 2
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem30.Text = "Taksitler"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 3
        Me.MenuItem31.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 4
        Me.MenuItem32.Text = "Görünüm Düzenle"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 5
        Me.MenuItem33.Text = "Görünümü Kaydet"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 6
        Me.MenuItem34.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem34.Text = "Görünümü Yazdýr"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 7
        Me.MenuItem35.Text = "-"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 8
        Me.MenuItem36.Text = "Filtrele"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 9
        Me.MenuItem37.Text = "Gruplandýr"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 10
        Me.MenuItem38.Text = "-"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 11
        Me.MenuItem39.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem39.Text = "Tam Ekran"
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
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.colsRenkAdi})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.Grid_satis_detay
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 35
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.ViewCaption = "Satýþ Detaylarý"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Müþteri Kodu"
        Me.GridColumn2.FieldName = "lKodu"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Müþteri"
        Me.GridColumn3.FieldName = "lMusteriAdi"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tarih"
        Me.GridColumn5.FieldName = "dteTarih"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 67
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ýzahat"
        Me.GridColumn6.FieldName = "fisTipi"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Width = 38
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fiþ No"
        Me.GridColumn7.FieldName = "lNo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 57
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Stok Kodu"
        Me.GridColumn8.FieldName = "sKodu"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.GridColumn8.Width = 69
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Stok Adý"
        Me.GridColumn31.FieldName = "sStokAciklama"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 0
        Me.GridColumn31.Width = 186
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Miktar"
        Me.GridColumn32.DisplayFormat.FormatString = "#,0.##"
        Me.GridColumn32.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn32.FieldName = "Miktar"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.##}")})
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 1
        Me.GridColumn32.Width = 56
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Fiyat"
        Me.GridColumn33.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn33.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn33.FieldName = "Fiyat"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 2
        Me.GridColumn33.Width = 60
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Ýskonto"
        Me.GridColumn34.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn34.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn34.FieldName = "Iskonto"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.##}")})
        Me.GridColumn34.Width = 50
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Net Tutar"
        Me.GridColumn35.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn35.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn35.FieldName = "lNetTutar"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 3
        Me.GridColumn35.Width = 73
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Ödenen"
        Me.GridColumn36.FieldName = "OdemeTutar"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OdemeTutar", "{0:#,0.##}")})
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "ÖdemeTipi"
        Me.GridColumn37.FieldName = "OdemeTipi"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Satýcý"
        Me.GridColumn38.FieldName = "SaticiRumuzu"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 5
        Me.GridColumn38.Width = 49
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "Kasiyer"
        Me.GridColumn39.FieldName = "KasiyerRumuzu"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Width = 79
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Teslimatçý"
        Me.GridColumn40.FieldName = "Teslimatci"
        Me.GridColumn40.Name = "GridColumn40"
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "ÖdemeAçýklamasý"
        Me.GridColumn41.FieldName = "OdemeAciklama"
        Me.GridColumn41.Name = "GridColumn41"
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "GiriþÇýkýþ"
        Me.GridColumn42.FieldName = "GirisCikis"
        Me.GridColumn42.Name = "GridColumn42"
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "ÜrünBedeli"
        Me.GridColumn43.FieldName = "MalBedeli"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MalBedeli", "{0:#,0.##}")})
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "ÝadeÝnfo"
        Me.GridColumn44.FieldName = "IadeAvInf"
        Me.GridColumn44.Name = "GridColumn44"
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "Hareket Tipi"
        Me.GridColumn45.FieldName = "sHareketTipi"
        Me.GridColumn45.Name = "GridColumn45"
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "ÝþlemKayýtNo"
        Me.GridColumn46.FieldName = "nIslemId"
        Me.GridColumn46.Name = "GridColumn46"
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "StokÖdeme"
        Me.GridColumn47.FieldName = "StokOdeme"
        Me.GridColumn47.Name = "GridColumn47"
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "SevkAciklama"
        Me.GridColumn48.FieldName = "SevkAciklama"
        Me.GridColumn48.Name = "GridColumn48"
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "KalanTaksit"
        Me.GridColumn49.FieldName = "KalanTaksit"
        Me.GridColumn49.Name = "GridColumn49"
        '
        'GridColumn50
        '
        Me.GridColumn50.Caption = "Kayýt Tarihi"
        Me.GridColumn50.FieldName = "KayitTarihi"
        Me.GridColumn50.Name = "GridColumn50"
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "FiyatTipi"
        Me.GridColumn51.FieldName = "sFiyatTipi"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 4
        Me.GridColumn51.Width = 69
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk"
        Me.colsRenkAdi.ColumnEdit = Me.sec_renkadi
        Me.colsRenkAdi.FieldName = "sRenk"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        '
        'sec_renkadi
        '
        Me.sec_renkadi.AutoHeight = False
        Me.sec_renkadi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renkadi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenk", "sRenk"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "sRenkAdi")})
        Me.sec_renkadi.DisplayMember = "sRenkAdi"
        Me.sec_renkadi.Name = "sec_renkadi"
        Me.sec_renkadi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_renkadi.ShowFooter = False
        Me.sec_renkadi.ShowHeader = False
        Me.sec_renkadi.ShowLines = False
        Me.sec_renkadi.ValueMember = "sRenk"
        '
        'SplitterControl4
        '
        Me.SplitterControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitterControl4.Location = New System.Drawing.Point(418, 0)
        Me.SplitterControl4.Name = "SplitterControl4"
        Me.SplitterControl4.Size = New System.Drawing.Size(6, 203)
        Me.SplitterControl4.TabIndex = 2
        Me.SplitterControl4.TabStop = False
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl6.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.Grid_satis_pesinat)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl6.Location = New System.Drawing.Point(424, 0)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(176, 203)
        Me.GroupControl6.TabIndex = 1
        Me.GroupControl6.Text = "Peþinat"
        '
        'Grid_satis_pesinat
        '
        Me.Grid_satis_pesinat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_pesinat.Location = New System.Drawing.Point(2, 15)
        Me.Grid_satis_pesinat.MainView = Me.GridView2
        Me.Grid_satis_pesinat.Name = "Grid_satis_pesinat"
        Me.Grid_satis_pesinat.Size = New System.Drawing.Size(172, 186)
        Me.Grid_satis_pesinat.TabIndex = 0
        Me.Grid_satis_pesinat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsOdemeSekli, Me.collOdemeTutar, Me.colsKasiyerRumuzu})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.Grid_satis_pesinat
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 35
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colsOdemeSekli
        '
        Me.colsOdemeSekli.Caption = "Ýzahat"
        Me.colsOdemeSekli.FieldName = "sOdemeSekli"
        Me.colsOdemeSekli.Name = "colsOdemeSekli"
        Me.colsOdemeSekli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", "{0} Kayýt")})
        Me.colsOdemeSekli.Visible = True
        Me.colsOdemeSekli.VisibleIndex = 0
        Me.colsOdemeSekli.Width = 68
        '
        'collOdemeTutar
        '
        Me.collOdemeTutar.Caption = "Tutar"
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00}")})
        Me.collOdemeTutar.Visible = True
        Me.collOdemeTutar.VisibleIndex = 1
        Me.collOdemeTutar.Width = 61
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Visible = True
        Me.colsKasiyerRumuzu.VisibleIndex = 2
        Me.colsKasiyerRumuzu.Width = 48
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitterControl2.Location = New System.Drawing.Point(600, 0)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(6, 203)
        Me.SplitterControl2.TabIndex = 1
        Me.SplitterControl2.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.Grid_satis_kapatma)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(606, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(280, 203)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Ödeme Planý"
        '
        'Grid_satis_kapatma
        '
        Me.Grid_satis_kapatma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_kapatma.Location = New System.Drawing.Point(2, 15)
        Me.Grid_satis_kapatma.MainView = Me.GridView5
        Me.Grid_satis_kapatma.Name = "Grid_satis_kapatma"
        Me.Grid_satis_kapatma.Size = New System.Drawing.Size(276, 186)
        Me.Grid_satis_kapatma.TabIndex = 1
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
        Me.GridView5.GridControl = Me.Grid_satis_kapatma
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lToplamMiktar", Nothing, "{0:#,0.##} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "lNetTutar", Nothing, "ToplamTutar : {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarihi", Nothing, "Kalan  {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Nothing, "Tutarý  : {0:#,0.00}")})
        Me.GridView5.IndicatorWidth = 35
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsPrint.ExpandAllGroups = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.ViewCaption = "Satýþa Yapýlan Taksitler"
        '
        'colFis_TanimlamaNo
        '
        Me.colFis_TanimlamaNo.Caption = "Fiþ No"
        Me.colFis_TanimlamaNo.FieldName = "Fis_TanimlamaNo"
        Me.colFis_TanimlamaNo.Name = "colFis_TanimlamaNo"
        Me.colFis_TanimlamaNo.Width = 67
        '
        'colFis_Tipi
        '
        Me.colFis_Tipi.Caption = "Fiþ Tipi"
        Me.colFis_Tipi.FieldName = "Fis_Tipi"
        Me.colFis_Tipi.Name = "colFis_Tipi"
        Me.colFis_Tipi.Width = 34
        '
        'colFis_Musteri_Tanimlama_No
        '
        Me.colFis_Musteri_Tanimlama_No.Caption = "Müþteri No"
        Me.colFis_Musteri_Tanimlama_No.FieldName = "Fis_Musteri_Tanimlama_No"
        Me.colFis_Musteri_Tanimlama_No.Name = "colFis_Musteri_Tanimlama_No"
        '
        'colFis_Musteri_Kodu
        '
        Me.colFis_Musteri_Kodu.Caption = "Müþteri Kodu"
        Me.colFis_Musteri_Kodu.FieldName = "Fis_Musteri_Kodu"
        Me.colFis_Musteri_Kodu.Name = "colFis_Musteri_Kodu"
        Me.colFis_Musteri_Kodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fis_Musteri_Kodu", "{0} Kayýt")})
        Me.colFis_Musteri_Kodu.Width = 67
        '
        'colFis_Musteri_Adi
        '
        Me.colFis_Musteri_Adi.Caption = "Müþteri Adý"
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
        Me.colTaksit_Tarihi.DisplayFormat.FormatString = "D"
        Me.colTaksit_Tarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTaksit_Tarihi.FieldName = "Taksit_Tarihi"
        Me.colTaksit_Tarihi.Name = "colTaksit_Tarihi"
        Me.colTaksit_Tarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", "{0} Kayýt")})
        Me.colTaksit_Tarihi.Visible = True
        Me.colTaksit_Tarihi.VisibleIndex = 0
        Me.colTaksit_Tarihi.Width = 122
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
        Me.colTaksit_Tutari.Width = 69
        '
        'colAlisveris_TanimlamaNo
        '
        Me.colAlisveris_TanimlamaNo.Caption = "AlýþVeriþ No"
        Me.colAlisveris_TanimlamaNo.FieldName = "Alisveris_TanimlamaNo"
        Me.colAlisveris_TanimlamaNo.Name = "colAlisveris_TanimlamaNo"
        '
        'colMusteri_Taksiti
        '
        Me.colMusteri_Taksiti.Caption = "Kalan"
        Me.colMusteri_Taksiti.DisplayFormat.FormatString = "#,0.00"
        Me.colMusteri_Taksiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMusteri_Taksiti.FieldName = "Musteri_Taksiti"
        Me.colMusteri_Taksiti.Name = "colMusteri_Taksiti"
        Me.colMusteri_Taksiti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Musteri_Taksiti", "{0:#,0.00}")})
        Me.colMusteri_Taksiti.Visible = True
        Me.colMusteri_Taksiti.VisibleIndex = 3
        Me.colMusteri_Taksiti.Width = 74
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
        Me.colOdeme_tutar.Width = 79
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage2.Controls.Add(Me.SplitterControl3)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(886, 203)
        Me.XtraTabPage2.Text = "ÖdemeDetayý"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl5.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.Grid_odemeler)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(536, 203)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Ödeme Detayý"
        '
        'Grid_odemeler
        '
        Me.Grid_odemeler.ContextMenu = Me.Context_odeme
        Me.Grid_odemeler.DataMember = "Table1"
        Me.Grid_odemeler.DataSource = Me.DataSet1
        Me.Grid_odemeler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_odemeler.Location = New System.Drawing.Point(2, 15)
        Me.Grid_odemeler.MainView = Me.GridView7
        Me.Grid_odemeler.Name = "Grid_odemeler"
        Me.Grid_odemeler.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.Grid_odemeler.Size = New System.Drawing.Size(532, 186)
        Me.Grid_odemeler.TabIndex = 2
        Me.Grid_odemeler.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'Context_odeme
        '
        Me.Context_odeme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem40, Me.MenuItem42, Me.MenuItem43, Me.MenuItem44, Me.MenuItem45, Me.MenuItem46, Me.MenuItem47, Me.MenuItem48, Me.MenuItem49, Me.MenuItem50, Me.MenuItem51, Me.MenuItem52, Me.MenuItem53})
        '
        'MenuItem40
        '
        Me.MenuItem40.DefaultItem = True
        Me.MenuItem40.Index = 0
        Me.MenuItem40.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem40.Text = "Satýþý Göster"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Text = "-"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 2
        Me.MenuItem43.Text = "Görünüm Düzenle"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 3
        Me.MenuItem44.Text = "Görünümü Kaydet"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 4
        Me.MenuItem45.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem45.Text = "Görünümü Yazdýr"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 5
        Me.MenuItem46.Text = "-"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 6
        Me.MenuItem47.Text = "Filtrele"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 7
        Me.MenuItem48.Text = "Gruplandýr"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 8
        Me.MenuItem49.Text = "-"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 9
        Me.MenuItem50.Text = "Satýrlarý Aç"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 10
        Me.MenuItem51.Text = "Satýrlarý Kapat"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 11
        Me.MenuItem52.Text = "-"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 12
        Me.MenuItem53.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem53.Text = "Tam Ekran"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "FIRMAKODU"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ADI"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "SOYADI"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "BELGENO"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "TARIH"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "MIKTAR"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "TUTAR"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ALISVERISNO"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "IZAHAT"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "VADEFARKI"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "MAGAZA"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "KASIYER"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "GIRIS"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "YAZI"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "DOGUMTARIHI"
        Me.DataColumn15.DataType = GetType(Date)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "EVLILIKTARIHI"
        Me.DataColumn16.DataType = GetType(Date)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "YAZDIRMA"
        Me.DataColumn17.DataType = GetType(Long)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "MEKTUPSAYISI"
        Me.DataColumn18.DataType = GetType(Long)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "SONSATISTARIHI"
        Me.DataColumn19.DataType = GetType(Date)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "SONTAHSILATTARIHI"
        Me.DataColumn20.DataType = GetType(Date)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "SATISTUTARI"
        Me.DataColumn21.DataType = GetType(Decimal)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "SATISMIKTARI"
        Me.DataColumn22.DataType = GetType(Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "IADETUTARI"
        Me.DataColumn23.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "IADEMIKTARI"
        Me.DataColumn24.DataType = GetType(Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "TOPLAMSATISTUTARI"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "TOPLAMSATISMIKTARI"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "TOPLAMPESINAT"
        Me.DataColumn27.DataType = GetType(Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "TOPLAMTAKSIT"
        Me.DataColumn28.DataType = GetType(Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "GECIKENILKTAKSITTARIHI"
        Me.DataColumn29.DataType = GetType(Date)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "GECIKENILKTAKSITTUTARI"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "TOPLAMTAHSILAT"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "TOPLAMKALAN"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "GECIKMISKALAN"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "GECIKMISTAKSIT"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "KALANTAKSITSAYISI"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "SATISSAYISI"
        Me.DataColumn36.DataType = GetType(Long)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "IADESAYISI"
        Me.DataColumn37.DataType = GetType(Long)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "SONSATISTUTARI"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "SONTAHSILATTUTARI"
        Me.DataColumn39.DataType = GetType(Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "GUNUNDE"
        Me.DataColumn40.DataType = GetType(Long)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "ERKEN"
        Me.DataColumn41.DataType = GetType(Long)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "GECIKMIS"
        Me.DataColumn42.DataType = GetType(Long)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "TOPLAM"
        Me.DataColumn43.DataType = GetType(Long)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "STATUS"
        Me.DataColumn44.DataType = GetType(Boolean)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "KAYIT"
        Me.DataColumn45.DataType = GetType(Date)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "SOZLESME"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "ISTIHBARAT"
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
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30})
        Me.GridView7.CustomizationFormBounds = New System.Drawing.Rectangle(556, 371, 208, 156)
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.GridControl = Me.Grid_odemeler
        Me.GridView7.GroupCount = 1
        Me.GridView7.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView7.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", Nothing, "Ödenen : {0} Taksit"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", Nothing, "ToplamÖdenen: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Taksit_Tarihi", Me.GridColumn29, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutari", Me.GridColumn20, "{0:#,0.00}")})
        Me.GridView7.IndicatorWidth = 35
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsCustomization.AllowGroup = False
        Me.GridView7.OptionsNavigation.UseTabKey = False
        Me.GridView7.OptionsPrint.ExpandAllGroups = False
        Me.GridView7.OptionsSelection.MultiSelect = True
        Me.GridView7.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn19, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Müþteri No"
        Me.GridColumn9.FieldName = "Fis_Musteri_TanimlamaNo"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Müþteri Kodu"
        Me.GridColumn10.FieldName = "Fis_Musteri_Kodu"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Fis_Musteri_Kodu", "{0} Kayýt")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 57
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Müþteri Adý"
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
        Me.GridColumn13.Caption = "Ödeme Kodu"
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
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 7
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
        Me.GridColumn22.Caption = "Döviz Tutar"
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
        Me.GridColumn26.Caption = "AlýþVeriþ No"
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
        Me.GridColumn29.Caption = "Taksit Tarihi"
        Me.GridColumn29.FieldName = "Taksit_Tarihi"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 6
        Me.GridColumn29.Width = 69
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Gecikme"
        Me.GridColumn30.DisplayFormat.FormatString = "{0:#,#0(Geç);#,#0(Erken);-}"
        Me.GridColumn30.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn30.FieldName = "GECIKME"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "GECIKME", "Ort.{0:#,#0.##(Geç);#,#0.##(Erken);-}")})
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 8
        Me.GridColumn30.Width = 65
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
        'SplitterControl3
        '
        Me.SplitterControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitterControl3.Location = New System.Drawing.Point(536, 0)
        Me.SplitterControl3.Name = "SplitterControl3"
        Me.SplitterControl3.Size = New System.Drawing.Size(6, 203)
        Me.SplitterControl3.TabIndex = 1
        Me.SplitterControl3.TabStop = False
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.grid_odemeler_kalan)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl4.Location = New System.Drawing.Point(542, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(344, 203)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Kalan Ödemeleri"
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
        Me.grid_odemeler_kalan.Location = New System.Drawing.Point(2, 15)
        Me.grid_odemeler_kalan.Name = "grid_odemeler_kalan"
        Me.grid_odemeler_kalan.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.grid_odemeler_kalan.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_odemeler_kalan.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_odemeler_kalan.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_odemeler_kalan.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_odemeler_kalan.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_odemeler_kalan.OptionsView.ShowColumnHeaders = False
        Me.grid_odemeler_kalan.OptionsView.ShowDataHeaders = False
        Me.grid_odemeler_kalan.OptionsView.ShowFilterHeaders = False
        Me.grid_odemeler_kalan.Size = New System.Drawing.Size(340, 186)
        Me.grid_odemeler_kalan.TabIndex = 2
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Müþteri No"
        Me.PivotGridField1.FieldName = "nMusteriID"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Müþteri Kodu"
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
        Me.PivotGridField6.Width = 86
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField7.AreaIndex = 0
        Me.PivotGridField7.Caption = "Yýl"
        Me.PivotGridField7.FieldName = "YIL"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.Width = 50
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
        Me.PivotGridField9.Caption = "Fiþ Tipi"
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
        Me.PivotGridField12.Caption = "Toplam Miktar"
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
        Me.PivotGridField17.Caption = "Kayýt Saati"
        Me.PivotGridField17.FieldName = "dteKayitTarihi"
        Me.PivotGridField17.Name = "PivotGridField17"
        Me.PivotGridField17.Visible = False
        '
        'PivotGridField18
        '
        Me.PivotGridField18.AreaIndex = 4
        Me.PivotGridField18.Caption = "AlýþVeriþ No"
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
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(2, 184)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(888, 6)
        Me.SplitterControl1.TabIndex = 6
        Me.SplitterControl1.TabStop = False
        '
        'Panel_hareketler
        '
        Me.Panel_hareketler.Controls.Add(Me.Panelstatus)
        Me.Panel_hareketler.Controls.Add(Me.GridControl1)
        Me.Panel_hareketler.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_hareketler.Location = New System.Drawing.Point(2, 2)
        Me.Panel_hareketler.Name = "Panel_hareketler"
        Me.Panel_hareketler.Size = New System.Drawing.Size(888, 182)
        Me.Panel_hareketler.TabIndex = 5
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panelstatus.Appearance.Options.UseBackColor = True
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(176, 48)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(533, 106)
        Me.Panelstatus.TabIndex = 5
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(10, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(509, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 49)
        Me.barlabel2.Name = "barlabel2"
        Me.barlabel2.Size = New System.Drawing.Size(53, 13)
        Me.barlabel2.TabIndex = 2
        Me.barlabel2.Text = "barlabel2"
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 3)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 22)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(509, 18)
        Me.bar.TabIndex = 0
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
        Me.GridControl1.Size = New System.Drawing.Size(884, 178)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem24, Me.MenuItem14, Me.MenuItem3, Me.MenuItem2, Me.MenuItem4, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem57, Me.MenuItem54, Me.MenuItem41, Me.MenuItem55, Me.MenuItem20, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem56, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem24
        '
        Me.MenuItem24.DefaultItem = True
        Me.MenuItem24.Index = 1
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem24.Text = "Ýncele"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem3.Text = "Kalan Taksitler"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem2.Text = "Fatura Bazlý Kalan Taksitler"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem4.Text = "Yapýlan Ödemeler"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 6
        Me.MenuItem25.Text = "Müþteri Hareket Ekstresi"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 7
        Me.MenuItem26.Text = "Satýþlar"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 8
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem27.Text = "Müþteri Kartý"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 9
        Me.MenuItem57.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem57.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 10
        Me.MenuItem54.Text = "-"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 11
        Me.MenuItem41.Text = "Takibe Al"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 12
        Me.MenuItem55.Text = "Ýlk Taksit Ödemesi Takip Et"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 13
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 14
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem19.Text = "Raporla"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem21.Text = "Önizle"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "Dizayn"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "Yazdýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 15
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 16
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 17
        Me.MenuItem6.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 18
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 19
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 20
        Me.MenuItem16.Text = "-"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 21
        Me.MenuItem56.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 22
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 23
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 24
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 25
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 26
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 27
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 28
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem13.Text = "Ekraný Kapla"
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRMAKODU, Me.colADI, Me.colSOYADI, Me.colBELGENO, Me.colTARIH, Me.colMIKTAR, Me.colTUTAR, Me.colALISVERISNO, Me.colIZAHAT, Me.colVADEFARKI, Me.colMAGAZA, Me.colKASIYER, Me.colGIRIS, Me.colYAZI, Me.colDOGUMTARIHI, Me.colEVLILIKTARIHI, Me.colYAZDIRMA, Me.colKAYIT, Me.colSOZLESME})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(609, 257, 208, 170)
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
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Müþteri Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FIRMAKODU", "{0} Kayýt")})
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 3
        '
        'colADI
        '
        Me.colADI.Caption = "Ad"
        Me.colADI.FieldName = "ADI"
        Me.colADI.Name = "colADI"
        Me.colADI.Visible = True
        Me.colADI.VisibleIndex = 4
        '
        'colSOYADI
        '
        Me.colSOYADI.Caption = "Soyad"
        Me.colSOYADI.FieldName = "SOYADI"
        Me.colSOYADI.Name = "colSOYADI"
        Me.colSOYADI.Visible = True
        Me.colSOYADI.VisibleIndex = 5
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Visible = True
        Me.colBELGENO.VisibleIndex = 2
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.00}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 6
        '
        'colTUTAR
        '
        Me.colTUTAR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colTUTAR.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colTUTAR.AppearanceCell.Options.UseFont = True
        Me.colTUTAR.AppearanceCell.Options.UseForeColor = True
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 7
        '
        'colALISVERISNO
        '
        Me.colALISVERISNO.Caption = "AlýþVeriþ No"
        Me.colALISVERISNO.FieldName = "ALISVERISNO"
        Me.colALISVERISNO.Name = "colALISVERISNO"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Belge Tipi"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 1
        '
        'colVADEFARKI
        '
        Me.colVADEFARKI.Caption = "VadeFarký"
        Me.colVADEFARKI.DisplayFormat.FormatString = "#,0.00"
        Me.colVADEFARKI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVADEFARKI.FieldName = "VADEFARKI"
        Me.colVADEFARKI.Name = "colVADEFARKI"
        '
        'colMAGAZA
        '
        Me.colMAGAZA.Caption = "Maðaza"
        Me.colMAGAZA.FieldName = "MAGAZA"
        Me.colMAGAZA.Name = "colMAGAZA"
        '
        'colKASIYER
        '
        Me.colKASIYER.Caption = "Kasiyer"
        Me.colKASIYER.FieldName = "KASIYER"
        Me.colKASIYER.Name = "colKASIYER"
        '
        'colGIRIS
        '
        Me.colGIRIS.Caption = "Giriþ"
        Me.colGIRIS.FieldName = "GIRIS"
        Me.colGIRIS.Name = "colGIRIS"
        '
        'colYAZI
        '
        Me.colYAZI.Caption = "Yazý"
        Me.colYAZI.FieldName = "YAZI"
        Me.colYAZI.Name = "colYAZI"
        '
        'colDOGUMTARIHI
        '
        Me.colDOGUMTARIHI.Caption = "Doðum Tarihi"
        Me.colDOGUMTARIHI.FieldName = "DOGUMTARIHI"
        Me.colDOGUMTARIHI.Name = "colDOGUMTARIHI"
        '
        'colEVLILIKTARIHI
        '
        Me.colEVLILIKTARIHI.Caption = "Evlilik Tarihi"
        Me.colEVLILIKTARIHI.FieldName = "EVLILIKTARIHI"
        Me.colEVLILIKTARIHI.Name = "colEVLILIKTARIHI"
        '
        'colYAZDIRMA
        '
        Me.colYAZDIRMA.Caption = "Yazýlan"
        Me.colYAZDIRMA.FieldName = "YAZDIRMA"
        Me.colYAZDIRMA.Name = "colYAZDIRMA"
        '
        'colKAYIT
        '
        Me.colKAYIT.Caption = "Kayýt Saati"
        Me.colKAYIT.DisplayFormat.FormatString = "HH:mm"
        Me.colKAYIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKAYIT.FieldName = "KAYIT"
        Me.colKAYIT.Name = "colKAYIT"
        Me.colKAYIT.Visible = True
        Me.colKAYIT.VisibleIndex = 8
        '
        'colSOZLESME
        '
        Me.colSOZLESME.Caption = "Sözleþme"
        Me.colSOZLESME.FieldName = "SOZLESME"
        Me.colSOZLESME.Name = "colSOZLESME"
        Me.colSOZLESME.Visible = True
        Me.colSOZLESME.VisibleIndex = 9
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.SimpleButton6)
        Me.PanelControl4.Controls.Add(Me.sec_goster)
        Me.PanelControl4.Controls.Add(Me.sec_analiz)
        Me.PanelControl4.Controls.Add(Me.sec_ts)
        Me.PanelControl4.Controls.Add(Me.sec_to)
        Me.PanelControl4.Controls.Add(Me.sec_dotmatrix)
        Me.PanelControl4.Controls.Add(Me.Label10)
        Me.PanelControl4.Controls.Add(Me.txt_ustlimit)
        Me.PanelControl4.Controls.Add(Me.Label11)
        Me.PanelControl4.Controls.Add(Me.txt_altlimit)
        Me.PanelControl4.Controls.Add(Me.sec_belgetipi)
        Me.PanelControl4.Controls.Add(Me.Label9)
        Me.PanelControl4.Controls.Add(Me.sec_alisveris)
        Me.PanelControl4.Controls.Add(Me.Label8)
        Me.PanelControl4.Controls.Add(Me.sec_kriter)
        Me.PanelControl4.Controls.Add(Me.Label7)
        Me.PanelControl4.Controls.Add(Me.Label6)
        Me.PanelControl4.Controls.Add(Me.DateEdit2)
        Me.PanelControl4.Controls.Add(Me.DateEdit1)
        Me.PanelControl4.Controls.Add(Me.GroupControl1)
        Me.PanelControl4.Controls.Add(Me.lbl_isim)
        Me.PanelControl4.Controls.Add(Me.Label4)
        Me.PanelControl4.Controls.Add(Me.Label3)
        Me.PanelControl4.Controls.Add(Me.txt_belgeno)
        Me.PanelControl4.Controls.Add(Me.txt_musterino)
        Me.PanelControl4.Controls.Add(Me.btn_baglan)
        Me.PanelControl4.Controls.Add(Me.txt_kasiyer)
        Me.PanelControl4.Controls.Add(Me.txt_kod)
        Me.PanelControl4.Controls.Add(Me.Label2)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(892, 120)
        Me.PanelControl4.TabIndex = 0
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(640, 67)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(64, 21)
        Me.SimpleButton6.TabIndex = 22
        Me.SimpleButton6.Text = "&Listele"
        '
        'sec_goster
        '
        Me.sec_goster.EditValue = True
        Me.sec_goster.Location = New System.Drawing.Point(380, 88)
        Me.sec_goster.Name = "sec_goster"
        Me.sec_goster.Properties.Caption = "Döküm Göster?"
        Me.sec_goster.Size = New System.Drawing.Size(94, 19)
        Me.sec_goster.TabIndex = 62
        '
        'sec_analiz
        '
        Me.sec_analiz.EditValue = True
        Me.sec_analiz.Location = New System.Drawing.Point(473, 88)
        Me.sec_analiz.Name = "sec_analiz"
        Me.sec_analiz.Properties.Caption = "Müþteri Analizi?"
        Me.sec_analiz.Size = New System.Drawing.Size(95, 19)
        Me.sec_analiz.TabIndex = 61
        '
        'sec_ts
        '
        Me.sec_ts.Location = New System.Drawing.Point(679, 88)
        Me.sec_ts.Name = "sec_ts"
        Me.sec_ts.Properties.Caption = "tS"
        Me.sec_ts.Size = New System.Drawing.Size(45, 19)
        Me.sec_ts.TabIndex = 60
        '
        'sec_to
        '
        Me.sec_to.Location = New System.Drawing.Point(646, 88)
        Me.sec_to.Name = "sec_to"
        Me.sec_to.Properties.Caption = "tO"
        Me.sec_to.Size = New System.Drawing.Size(40, 19)
        Me.sec_to.TabIndex = 59
        '
        'sec_dotmatrix
        '
        Me.sec_dotmatrix.Location = New System.Drawing.Point(570, 88)
        Me.sec_dotmatrix.Name = "sec_dotmatrix"
        Me.sec_dotmatrix.Properties.Caption = "Dot Matrix?"
        Me.sec_dotmatrix.Size = New System.Drawing.Size(77, 19)
        Me.sec_dotmatrix.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(351, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Limit:"
        '
        'txt_ustlimit
        '
        Me.txt_ustlimit.EditValue = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txt_ustlimit.EnterMoveNextControl = True
        Me.txt_ustlimit.Location = New System.Drawing.Point(540, 68)
        Me.txt_ustlimit.Name = "txt_ustlimit"
        Me.txt_ustlimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_ustlimit.Properties.NullText = "0.00"
        Me.txt_ustlimit.Size = New System.Drawing.Size(100, 20)
        Me.txt_ustlimit.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(496, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "ve"
        '
        'txt_altlimit
        '
        Me.txt_altlimit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_altlimit.EnterMoveNextControl = True
        Me.txt_altlimit.Location = New System.Drawing.Point(382, 68)
        Me.txt_altlimit.Name = "txt_altlimit"
        Me.txt_altlimit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_altlimit.Properties.NullText = "0.00"
        Me.txt_altlimit.Size = New System.Drawing.Size(100, 20)
        Me.txt_altlimit.TabIndex = 20
        '
        'sec_belgetipi
        '
        Me.sec_belgetipi.EditValue = "[Tümü]"
        Me.sec_belgetipi.EnterMoveNextControl = True
        Me.sec_belgetipi.Location = New System.Drawing.Point(640, 48)
        Me.sec_belgetipi.Name = "sec_belgetipi"
        Me.sec_belgetipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_belgetipi.Properties.Items.AddRange(New Object() {"[Tümü]", "Normal", "Ýade"})
        Me.sec_belgetipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_belgetipi.Size = New System.Drawing.Size(64, 20)
        Me.sec_belgetipi.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(491, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "AlýþVeriþ:"
        '
        'sec_alisveris
        '
        Me.sec_alisveris.EditValue = "[Tümü]"
        Me.sec_alisveris.EnterMoveNextControl = True
        Me.sec_alisveris.Location = New System.Drawing.Point(540, 48)
        Me.sec_alisveris.Name = "sec_alisveris"
        Me.sec_alisveris.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_alisveris.Properties.Items.AddRange(New Object() {"[Tümü]", "Kredili Satýþlar", "Kredili", "Sonradan Teslim Kredili", "Peþin", "Peþin Satýþlar", "Sonradan Teslim Peþin", "Satýþlar", "Ödemeler"})
        Me.sec_alisveris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_alisveris.Size = New System.Drawing.Size(100, 20)
        Me.sec_alisveris.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(337, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Müþteri:"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Tüm Kayýtlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(382, 48)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Tüm Kayýtlar", "Yeni Müþteri Kayýtlarý"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(100, 20)
        Me.sec_kriter.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(348, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Tarih:"
        '
        'Label6
        '
        Me.Label6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(484, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(540, 8)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 14
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(382, 8)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 13
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lbl_istihbarat)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(714, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(176, 116)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "Ýstihbarat"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_istihbarat.Location = New System.Drawing.Point(2, 15)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(172, 13)
        Me.lbl_istihbarat.TabIndex = 41
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'lbl_isim
        '
        Me.lbl_isim.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_isim.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_isim.Location = New System.Drawing.Point(2, 90)
        Me.lbl_isim.Name = "lbl_isim"
        Me.lbl_isim.Size = New System.Drawing.Size(6, 13)
        Me.lbl_isim.TabIndex = 22
        Me.lbl_isim.Text = "*"
        '
        'Label4
        '
        Me.Label4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(491, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "BelgeNo:"
        '
        'Label3
        '
        Me.Label3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(337, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Müþteri:"
        '
        'txt_belgeno
        '
        Me.txt_belgeno.EnterMoveNextControl = True
        Me.txt_belgeno.Location = New System.Drawing.Point(540, 28)
        Me.txt_belgeno.Name = "txt_belgeno"
        Me.txt_belgeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_belgeno.Size = New System.Drawing.Size(100, 20)
        Me.txt_belgeno.TabIndex = 16
        '
        'txt_musterino
        '
        Me.txt_musterino.EnterMoveNextControl = True
        Me.txt_musterino.Location = New System.Drawing.Point(382, 28)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_musterino.Size = New System.Drawing.Size(100, 20)
        Me.txt_musterino.TabIndex = 15
        '
        'btn_baglan
        '
        Me.btn_baglan.Location = New System.Drawing.Point(64, 30)
        Me.btn_baglan.Name = "btn_baglan"
        Me.btn_baglan.Size = New System.Drawing.Size(224, 23)
        Me.btn_baglan.TabIndex = 11
        Me.btn_baglan.Text = "&Baðlan"
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(136, 8)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(153, 20)
        Me.txt_kasiyer.TabIndex = 10
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(64, 8)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(72, 20)
        Me.txt_kod.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kasiyer:"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.printlink3})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Döküm Emirleri Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Ýþ Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Detayý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'printlink3
        '
        Me.printlink3.Component = Me.Grid_odemeler
        '
        '
        '
        Me.printlink3.ImageCollection.ImageStream = CType(resources.GetObject("printlink3.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink3.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink3.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Ödeme Detayý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink3.PrintingSystem = Me.ps
        Me.printlink3.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.BarManager1.MainMenu = Me.Bar3
        Me.BarManager1.MaxItemId = 4
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 3"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True)})
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Tanýmlar"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Anons"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Kampanya"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(896, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 678)
        Me.barDockControlBottom.Size = New System.Drawing.Size(896, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 656)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(896, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 656)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 4
        Me.colsFiyatTipi.Width = 69
        '
        'colKayitTarihi
        '
        Me.colKayitTarihi.Caption = "Kayýt Tarihi"
        Me.colKayitTarihi.FieldName = "KayitTarihi"
        Me.colKayitTarihi.Name = "colKayitTarihi"
        '
        'colKalanTaksit
        '
        Me.colKalanTaksit.Caption = "KalanTaksit"
        Me.colKalanTaksit.FieldName = "KalanTaksit"
        Me.colKalanTaksit.Name = "colKalanTaksit"
        '
        'colSevkAciklama
        '
        Me.colSevkAciklama.Caption = "SevkAciklama"
        Me.colSevkAciklama.FieldName = "SevkAciklama"
        Me.colSevkAciklama.Name = "colSevkAciklama"
        '
        'colStokOdeme
        '
        Me.colStokOdeme.Caption = "StokÖdeme"
        Me.colStokOdeme.FieldName = "StokOdeme"
        Me.colStokOdeme.Name = "colStokOdeme"
        '
        'colnIslemId
        '
        Me.colnIslemId.Caption = "ÝþlemKayýtNo"
        Me.colnIslemId.FieldName = "nIslemId"
        Me.colnIslemId.Name = "colnIslemId"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colIadeAvInf
        '
        Me.colIadeAvInf.Caption = "ÝadeÝnfo"
        Me.colIadeAvInf.FieldName = "IadeAvInf"
        Me.colIadeAvInf.Name = "colIadeAvInf"
        '
        'colMalBedeli
        '
        Me.colMalBedeli.Caption = "ÜrünBedeli"
        Me.colMalBedeli.FieldName = "MalBedeli"
        Me.colMalBedeli.Name = "colMalBedeli"
        Me.colMalBedeli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MalBedeli", "{0:#,0.##}")})
        '
        'colGirisCikis
        '
        Me.colGirisCikis.Caption = "GiriþÇýkýþ"
        Me.colGirisCikis.FieldName = "GirisCikis"
        Me.colGirisCikis.Name = "colGirisCikis"
        '
        'colOdemeAciklama
        '
        Me.colOdemeAciklama.Caption = "ÖdemeAçýklamasý"
        Me.colOdemeAciklama.FieldName = "OdemeAciklama"
        Me.colOdemeAciklama.Name = "colOdemeAciklama"
        '
        'colTeslimatci
        '
        Me.colTeslimatci.Caption = "Teslimatçý"
        Me.colTeslimatci.FieldName = "Teslimatci"
        Me.colTeslimatci.Name = "colTeslimatci"
        '
        'colKasiyerRumuzu
        '
        Me.colKasiyerRumuzu.Caption = "Kasiyer"
        Me.colKasiyerRumuzu.FieldName = "KasiyerRumuzu"
        Me.colKasiyerRumuzu.Name = "colKasiyerRumuzu"
        Me.colKasiyerRumuzu.Width = 79
        '
        'colSaticiRumuzu
        '
        Me.colSaticiRumuzu.Caption = "Satýcý"
        Me.colSaticiRumuzu.FieldName = "SaticiRumuzu"
        Me.colSaticiRumuzu.Name = "colSaticiRumuzu"
        Me.colSaticiRumuzu.Visible = True
        Me.colSaticiRumuzu.VisibleIndex = 5
        Me.colSaticiRumuzu.Width = 49
        '
        'colOdemeTipi
        '
        Me.colOdemeTipi.Caption = "ÖdemeTipi"
        Me.colOdemeTipi.FieldName = "OdemeTipi"
        Me.colOdemeTipi.Name = "colOdemeTipi"
        '
        'colOdemeTutar
        '
        Me.colOdemeTutar.Caption = "Ödenen"
        Me.colOdemeTutar.FieldName = "OdemeTutar"
        Me.colOdemeTutar.Name = "colOdemeTutar"
        Me.colOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OdemeTutar", "{0:#,0.##}")})
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
        Me.collNetTutar.VisibleIndex = 3
        Me.collNetTutar.Width = 73
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
        'colFiyat
        '
        Me.colFiyat.Caption = "Fiyat"
        Me.colFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 2
        Me.colFiyat.Width = 60
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Miktar"
        Me.GridColumn1.DisplayFormat.FormatString = "#,0.##"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Miktar"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.##}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 56
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Stok Adý"
        Me.GridColumn4.FieldName = "sStokAciklama"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 186
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Width = 69
        '
        'collNo
        '
        Me.collNo.Caption = "Fiþ No"
        Me.collNo.FieldName = "lNo"
        Me.collNo.Name = "collNo"
        Me.collNo.Width = 57
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "Ýzahat"
        Me.colsFisTipi.FieldName = "fisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Width = 38
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Width = 67
        '
        'collMusteriAdi
        '
        Me.collMusteriAdi.Caption = "Müþteri"
        Me.collMusteriAdi.FieldName = "lMusteriAdi"
        Me.collMusteriAdi.Name = "collMusteriAdi"
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
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
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
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
        'frm_kasiyer_dokum_liste_kontrol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(896, 678)
        Me.Controls.Add(Me.panel_hareket)
        Me.Controls.Add(Me.panel_alt)
        Me.Controls.Add(Me.panel_info)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_kasiyer_dokum_liste_kontrol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlýþVeriþKontrol Emirleri"
        CType(Me.panel_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_info.ResumeLayout(False)
        Me.panel_info.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_alt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_alt.ResumeLayout(False)
        Me.panel_alt.PerformLayout()
        CType(Me.panel_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_hareket.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.Grid_satis_detay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renkadi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.Grid_satis_pesinat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Grid_satis_kapatma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.Grid_odemeler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grid_odemeler_kalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_hareketler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hareketler.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.sec_goster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_analiz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_to.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_dotmatrix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ustlimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_altlimit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_belgetipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_alisveris.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kasiyerno
    Public kasiyer
    Public kasiyer_depo As String = ""
    Public personelno As Int64 = 0
    Public kullanici
    Public personel As String = ""
    Dim ds_kasiyer As DataSet
    Dim ds_satici As DataSet
    Dim ds_fiyattipi As DataSet
    Dim dr As DataRow
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    Dim ds_taksit_kalan As DataSet
    Dim ds_taksitler As DataSet
    Dim ds_satislar As DataSet
    Dim ds_satislar_detayli As DataSet
    Dim ds_tahsilatlar As DataSet
    Dim ds_odemeler As DataSet
    Public frf_islem As String = "mektup"
    Dim ds_detay As DataSet
    Dim ds_kapatma As DataSet
    Dim ds_pesinat As DataSet
    Dim ds_satis_odeme As DataSet
    Dim ds_odemeler_kalan As DataSet
    Dim sPrinter_Depo As String = ""
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_kasiyer_stok_fiyatlandir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU")
        'If connection = "" Then
        '    connection = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=BARKOD;Data Source=(local)"
        '    Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection)
        'End If
        firmano = 100
        donemno = 1
        dataload_kasiyer()
        dataload_satici()
        dataload_fiyattipi()
        dataload_renk()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        GridControl1.Enabled = False
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_satici()
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu AS IND, sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici WHERE     (sSaticiRumuzu <> '') and (bAktif = 1)"))
    End Sub
    Private Sub dataload_fiyattipi()
        ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi, sAciklama FROM         tbFiyatTipi WHERE     (sFiyatTipi IN ('6 AY', '10AY', 'PS', 'HD')) ORDER BY sFiyatTipi DESC"))
    End Sub
    Private Sub dataload_renk()
        sec_renkadi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView5.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView7.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasiyerno As String, ByVal musterikodu As String, ByVal belgeno As String, ByVal kriter_sorgu As String, ByVal alisveris As String, ByVal alisveristipi As String, ByVal limitalt As Decimal, ByVal limitust As Decimal)
        Dim kriter_musteri = ""
        Dim kriter_alisveris = "WHERE IZAHAT <> ''"
        Dim kasiyer_satis = ""
        Dim kasiyer_odeme = ""
        Dim kriter_musteri_kayit = ""
        'kriter += " WHERE Tarih ='" & tarih & "' "
        If Trim(kasiyerno) = "VC" Then
        ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
        ElseIf Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "ÝBO" Then
            kasiyer_satis = " AND tbAlisVeris.sMagaza ='" & kasiyer_depo & "' "
            kasiyer_odeme = " AND tbOdeme.sMagaza ='" & kasiyer_depo & "' "
        Else
            kasiyer_satis = " AND tbAlisVeris.sKasiyerRumuzu ='" & kasiyerno & "' "
            kasiyer_odeme = " AND tbOdeme.sKasiyerRumuzu ='" & kasiyerno & "' "
        End If
        If musterikodu <> "" Then
            kriter_musteri = " AND tbMusteri.lKodu = '" & Trim(musterikodu) & "' "
        End If
        If kriter_sorgu = "Tüm Kayýtlar" Then
        ElseIf kriter_sorgu = "Yeni Müþteri Kayýtlarý" Then
            kriter_musteri_kayit = " AND tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        End If
        If alisveris = "[Tümü]" Then
        ElseIf alisveris = "Kredili Satýþlar" Then
            kriter_alisveris += " AND IZAHAT IN ('K','SK') "
        ElseIf alisveris = "Kredili" Then
            kriter_alisveris += " AND IZAHAT IN ('K') "
        ElseIf alisveris = "Sonradan Teslim Kredili" Then
            kriter_alisveris += " AND IZAHAT IN ('SK') "
        ElseIf alisveris = "Peþin Satýþlar" Then
            kriter_alisveris += " AND IZAHAT IN ('P','SP') "
        ElseIf alisveris = "Peþin" Then
            kriter_alisveris += " AND IZAHAT IN ('P') "
        ElseIf alisveris = "Sonradan Teslim Peþin" Then
            kriter_alisveris += " AND IZAHAT IN ('SP') "
        ElseIf alisveris = "Ödemeler" Then
            kriter_alisveris += " AND IZAHAT IN ('OD') "
        ElseIf alisveris = "Satýþlar" Then
            kriter_alisveris += " AND IZAHAT NOT IN ('OD') "
        End If
        If alisveristipi = "[Tümü]" Then
        ElseIf alisveristipi = "Normal" Then
            kriter_alisveris += " AND GIRIS IN (3) "
        ElseIf alisveristipi = "Ýade" Then
            kriter_alisveris += " AND GIRIS IN (4) "
        End If
        kriter_alisveris += " AND ABS(TUTAR) BETWEEN " & limitalt & " and " & limitust & " "
        DataSet1.Clear()
        'sorgu_dokumler(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_satis & " AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR , '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , SUM(tbOdeme.lOdemeTutar) AS TUTAR , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbOdeme.dteOdemeTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_odeme & "  GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT) T ORDER BY IZAHAT, BELGENO"))
        'sorgu_dokumler(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_satis & " AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR , '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , SUM(tbOdeme.lOdemeTutar) AS TUTAR , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbOdeme.dteOdemeTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_odeme & "  GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME) T ORDER BY IZAHAT, BELGENO"))
        sorgu_dokumler(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & " " & kriter_musteri_kayit & " " & kasiyer_satis & " AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR , '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,MAX(KAYIT) KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , SUM(tbOdeme.lOdemeTutar) AS TUTAR , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & " " & kriter_musteri_kayit & " " & kasiyer_odeme & "  GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,SOZLESME,ISTIHBARAT) T " & kriter_alisveris & " ORDER BY IZAHAT, BELGENO"))
        'ds_kasiyer = sorgu(sorgu_query("SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = 0
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            'GridView1.FocusedRowHandle = 0
        End If
    End Sub
    Private Sub sorgu_dokumler(ByVal query As String)
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        DS = Nothing
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baglan.Click
        If btn_baglan.Text = "Baðlan" Then
            kasiyer_kontrol()
        ElseIf btn_baglan.Text = "Baðlantýyý Kes" Then
            Dim sayi As Int64
            'sayi = kayit_kontrol()
            If sayi = 0 Then
                txt_kasiyer.EditValue = ""
                txt_kod.Enabled = True
                txt_kod.EditValue = ""
                GridControl1.Enabled = False
                DataSet1.Clear()
                txt_kod.Focus()
                txt_kod.SelectAll()
            ElseIf sayi = 1 Then
                XtraMessageBox.Show(Sorgu_sDil("Bekleyen Ýþlemleriniz Var...Lütfen Bekleyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kod.Text Then
                kasiyerno = dr("IND")
                kasiyer = dr("KASIYER")
                kasiyer_depo = dr("DEPO")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            txt_kasiyer.EditValue = kasiyer
            txt_kod.Enabled = False
            GridControl1.Enabled = True
            btn_baglan.Text = "Baðlantýyý Kes"
            GridControl1.Focus()
            GridControl1.Select()
            'dataload(Today, kasiyerno)
            txt_musterino.Enabled = True
            txt_belgeno.Enabled = True
            SimpleButton5.Enabled = True
            DateEdit1.Select()
            DateEdit1.SelectAll()
            'txt_musterino.Select()
            'txt_musterino.SelectAll()
            status = True
        ElseIf sonuc = False Then
            txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            'txt_kasiyer.Enabled = True
            GridControl1.Enabled = False
            btn_baglan.Text = "Baðlan"
            txt_kod.Focus()
            txt_kod.SelectAll()
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ekle()
        If status = True And Trim(kasiyerno) <> "" Then
            Dim frm As New frm_kasiyer_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kasiyerno = kasiyerno
            frm.kasiyer = kasiyer
            frm.ds_satici = ds_satici
            frm.ds_fiyattipi = ds_fiyattipi
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
        End If
    End Sub
    Private Sub duzelt_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt2(ByVal ind As Int64, ByVal sonuc As String, ByVal status As Integer, ByVal aciklama As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    AEMIRKASIYERSTOKFIYAT SET              Sonuc = '" & sonuc & "', Status = " & status & ", Aciklama = '" & aciklama & "',DegisimTarihi = getdate() WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub taksit_kontrol_satirlar()
        Dim dr As DataRow
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
            Panelstatus.Visible = True
            bar.Properties.Maximum = GridView1.SelectedRowsCount
            barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
            bar.Position = 0
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                'Panelstatus.Visible = True
                'bar.Properties.Maximum = GridView1.SelectedRowsCount
                'barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                'bar.Position = 0
                'Satýr Oku
                barlabel.Text = "MüþteriKodu:" & dr("FIRMAKODU").ToString & vbTab & "Adý:" & dr("ADI").ToString
                barlabel.Refresh()
                If Trim(dr("FIRMAKODU")).ToString <> "999999" Then
                    ds_taksit_kalan = sorgu_taksitler_kalanli(dr("nMusteriId"))
                    For Each dr1 In ds_taksit_kalan.Tables(0).Rows
                        dr("TOPLAMTAKSIT") = dr1("TUTAR")
                        dr("TOPLAMTAHSILAT") = dr1("TAHSILAT")
                        dr("TOPLAMKALAN") = dr1("KALAN")
                    Next
                    ds_taksitler = sorgu_taksitler(dr("nMusteriID"))
                    Dim ilktaksit As DateTime
                    Dim ilktaksittutar As Decimal
                    Dim gecikmistaksitsayisi As Int64 = 0
                    Dim gecikmistaksittutari As Decimal = 0
                    Dim kalantaksitsayisi As Int64 = 0
                    barlabel2.Text = "Taksitler Okunuyor...Toplam Satýr Sayýsý : " & ds_taksitler.Tables(0).Rows.Count
                    bar2.Properties.Maximum = ds_taksitler.Tables(0).Rows.Count
                    bar2.Position = 0
                    barlabel2.Refresh()
                    sayi = 0
                    For Each dr1 In ds_taksitler.Tables(0).Rows
                        sayi += 1
                        If sayi = 1 Then
                            ilktaksit = dr1("dteTarihi")
                            ilktaksittutar = dr1("KALAN")
                        End If
                        If dr1("dteTarihi") <= Today Then
                            gecikmistaksitsayisi += 1
                            gecikmistaksittutari += dr1("KALAN")
                        End If
                        kalantaksitsayisi += 1
                        bar2.Position = bar2.Position + 1
                        bar2.Refresh()
                    Next
                    dr("GECIKENILKTAKSITTARIHI") = ilktaksit
                    dr("GECIKENILKTAKSITTUTARI") = ilktaksittutar
                    dr("GECIKMISTAKSIT") = gecikmistaksitsayisi
                    dr("GECIKMISKALAN") = gecikmistaksittutari
                    dr("KALANTAKSITSAYISI") = kalantaksitsayisi
                    'Satýþlar
                    ds_satislar_detayli = sorgu_satislar_detayli(dr("nMusteriID"))
                    Dim toplammiktar As Decimal = 0
                    Dim toplamsatistutari As Decimal = 0
                    Dim toplampesinattutari As Decimal = 0
                    Dim iademiktar As Decimal = 0
                    Dim iadetutari As Decimal = 0
                    Dim satissayisi As Int64 = 0
                    Dim satismiktar As Decimal = 0
                    Dim satistutari As Decimal = 0
                    Dim iadesayisi As Int64 = 0
                    Dim sonsatistutari As Decimal = 0
                    Dim sonsatistarihi As DateTime
                    sayi = 0
                    barlabel2.Text = "Satýþlar Okunuyor...Toplam Satýr Sayýsý : " & ds_satislar_detayli.Tables(0).Rows.Count
                    bar2.Position = 0
                    barlabel2.Refresh()
                    For Each dr1 In ds_satislar_detayli.Tables(0).Rows
                        If dr1("nGirisCikis") = 3 Then
                            satismiktar += dr1("lToplamMiktar")
                            satistutari += dr1("lNetTutar")
                            toplampesinattutari = dr1("lPesinat")
                            satissayisi += 1
                            sayi += 1
                            If sayi = 1 Then
                                sonsatistutari += dr1("lNetTutar")
                                sonsatistarihi = dr1("dteFaturaTarihi")
                            End If
                        ElseIf dr1("nGirisCikis") = 4 Then
                            iademiktar += Math.Abs(dr1("lToplamMiktar"))
                            iadetutari += Math.Abs(dr1("lNetTutar"))
                            iadesayisi += 1
                        End If
                        toplammiktar += dr1("lToplamMiktar")
                        toplamsatistutari += dr1("lNetTutar")
                        bar2.Position = bar2.Position + 1
                        bar2.Refresh()
                    Next
                    dr("SATISSAYISI") = satissayisi
                    dr("IADESAYISI") = iadesayisi
                    dr("SATISTUTARI") = satistutari
                    dr("SATISMIKTARI") = satismiktar
                    dr("IADETUTARI") = iadetutari
                    dr("IADEMIKTARI") = iademiktar
                    dr("TOPLAMSATISTUTARI") = toplamsatistutari
                    dr("TOPLAMSATISMIKTARI") = toplammiktar
                    dr("TOPLAMPESINAT") = toplampesinattutari
                    dr("SONSATISTUTARI") = sonsatistutari
                    dr("SONSATISTARIHI") = sonsatistarihi
                    'Tahsilatlar
                    ds_tahsilatlar = sorgu_tahsilatlar_toplam(dr("nMusteriID"))
                    bar2.Properties.Maximum = ds_tahsilatlar.Tables(0).Rows.Count
                    barlabel2.Text = "Tahsilatlar Okunuyor...Toplam Satýr Sayýsý : " & ds_tahsilatlar.Tables(0).Rows.Count
                    bar2.Position = 0
                    barlabel2.Refresh()
                    Dim sontahsilattarihi As DateTime
                    Dim sontahsilattutari As Decimal = 0
                    For Each dr1 In ds_tahsilatlar.Tables(0).Rows
                        sontahsilattarihi = dr1("dteOdemeTarihi")
                        sontahsilattutari = dr1("TAHSILAT")
                        bar2.Position = bar2.Position + 1
                        bar2.Refresh()
                    Next
                    dr("SONTAHSILATTARIHI") = sontahsilattarihi
                    dr("SONTAHSILATTUTARI") = sontahsilattutari
                    dr("STATUS") = 1
                    Try
                        dr("GUNUNDE") = sorgu_odemeler_sayi_gununde(dr("nMusteriID"))
                        dr("GECIKMIS") = sorgu_odemeler_sayi_gecikmis(dr("nMusteriID"))
                        dr("ERKEN") = sorgu_odemeler_sayi_erken(dr("nMusteriID"))
                        dr("TOPLAM") = dr("GUNUNDE") + dr("GECIKMIS") + dr("ERKEN")
                    Catch ex As Exception
                        dr("GUNUNDE") = 0
                        dr("GECIKMIS") = 0
                        dr("ERKEN") = 0
                        dr("TOPLAM") = 0
                    End Try
                    'Try
                    '    ds_odemeler = sorgu_odemeler_sayi(dr("nMusteriID"))
                    '    Dim gununde As Int64 = 0
                    '    Dim erken As Int64 = 0
                    '    Dim gecikmis As Int64 = 0
                    '    Dim toplam As Int64 = 0
                    '    bar2.Properties.Maximum = ds_odemeler.Tables(0).Rows.Count
                    '    barlabel2.Text = "ÖdemeAnalizi Okunuyor...Toplam Satýr Sayýsý : " & ds_odemeler.Tables(0).Rows.Count
                    '    bar2.Position = 0
                    '    barlabel2.Refresh()
                    '    For Each dr1 In ds_odemeler.Tables(0).Rows
                    '        gecikmis = dr1("GECIKMIS")
                    '        erken = dr1("ERKEN")
                    '        gununde = dr1("GUNUNDE")
                    '        bar2.Position = bar2.Position + 1
                    '        bar2.Refresh()
                    '    Next
                    '    dr("GUNUNDE") = gununde
                    '    dr("GECIKMIS") = gecikmis
                    '    dr("ERKEN") = erken
                    '    dr("TOPLAM") = gununde + gecikmis + erken
                    'Catch ex As Exception
                    '    dr("GUNUNDE") = 0
                    '    dr("GECIKMIS") = 0
                    '    dr("ERKEN") = 0
                    '    dr("TOPLAM") = 0
                    'End Try
                ElseIf Trim(dr("FIRMAKODU")).ToString = "999999" Then
                    dr("TOPLAMTAKSIT") = 0
                    dr("TOPLAMTAHSILAT") = 0
                    dr("TOPLAMKALAN") = 0
                    dr("GECIKENILKTAKSITTARIHI") = Today
                    dr("GECIKENILKTAKSITTUTARI") = 0
                    dr("GECIKMISTAKSIT") = 0
                    dr("GECIKMISKALAN") = 0
                    dr("KALANTAKSITSAYISI") = 0
                    dr("SATISSAYISI") = 0
                    dr("IADESAYISI") = 0
                    dr("SATISTUTARI") = 0
                    dr("SATISMIKTARI") = 0
                    dr("IADETUTARI") = 0
                    dr("IADEMIKTARI") = 0
                    dr("TOPLAMSATISTUTARI") = 0
                    dr("TOPLAMSATISMIKTARI") = 0
                    dr("TOPLAMPESINAT") = 0
                    dr("SONSATISTUTARI") = 0
                    dr("SONSATISTARIHI") = Today
                    dr("SONTAHSILATTARIHI") = Today
                    dr("SONTAHSILATTUTARI") = 0
                    dr("STATUS") = 1
                    dr("GUNUNDE") = 0
                    dr("GECIKMIS") = 0
                    dr("ERKEN") = 0
                    dr("TOPLAM") = 0
                End If
                'Satýr Bitir
                bar.Position = bar.Position + 1
                bar.Refresh()
            Next
        End If
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Function sorgu_kalan_taksit(ByVal musterino As Int64) As Decimal
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     isnull(Tutar,0)  FROM         vwMusteriKalan  Where nMusteriId = " & musterino & "")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = 35265) GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu")
        Dim tutar As Decimal = cmd.ExecuteScalar
        con.Close()
        Return tutar
    End Function
    Public Function sorgu_taksitler_kalanli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_taksitler(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_satislar_toplam(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     SUM(lToplamMiktar) AS MIKTAR, SUM(lNetTutar) AS TUTAR, SUM(lPesinat) AS PESINAT FROM         tbAlisVeris WHERE     (nMusteriID = " & musterino & ")")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_tahsilatlar_toplam(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 SUM(tbOdeme.lOdemeTutar) AS TAHSILAT, tbOdeme.dteOdemeTarihi, tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & musterino & ") GROUP BY tbAlisVeris.nMusteriID, tbOdeme.dteOdemeTarihi ORDER BY tbOdeme.dteOdemeTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_odemeler_sayi(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nMusteriID, SUM(GECIKMIS) AS GECIKMIS, SUM(ERKEN) AS ERKEN, SUM(GUNUNDE) AS GUNUNDE FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkGecikmis > 0) GROUP BY Musteri_TanimlamaNo UNION SELECT Musteri_TanimlamaNo AS nMusteriID , 0 AS GECIKMIS , COUNT(*) AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken > 0) GROUP BY Musteri_TanimlamaNo UNION SELECT Musteri_TanimlamaNo AS nMusteriID , 0 AS GECIKMIS , 0 AS ERKEN , COUNT(*) AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken = 0) AND (NFarkGecikmis = 0) GROUP BY Musteri_TanimlamaNo) T GROUP BY nMusteriID")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_odemeler_sayi_gecikmis(ByVal musterino As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Int64
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(GECIKMIS),0) AS GECIKMIS FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkGecikmis > 0) GROUP BY Musteri_TanimlamaNo ) T GROUP BY nMusteriID")
        sayi = cmd.ExecuteScalar
        conn.Close()
        Return sayi
        sayi = Nothing
    End Function
    Public Function sorgu_odemeler_sayi_erken(ByVal musterino As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Int64
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(GECIKMIS),0) AS GECIKMIS FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken > 0) GROUP BY Musteri_TanimlamaNo ) T GROUP BY nMusteriID")
        sayi = cmd.ExecuteScalar
        conn.Close()
        Return sayi
        sayi = Nothing
    End Function
    Public Function sorgu_odemeler_sayi_gununde(ByVal musterino As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sayi As Int64
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(GECIKMIS),0) AS GECIKMIS FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken = 0) AND (NFarkGecikmis = 0) GROUP BY Musteri_TanimlamaNo ) T GROUP BY nMusteriID")
        sayi = cmd.ExecuteScalar
        conn.Close()
        Return sayi
        sayi = Nothing
    End Function
    Private Sub txt_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ekle()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ekle()
    End Sub
    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If btn_baglan.Text = "Baðlantýyý Kes" Then
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, sec_kriter.Text, sec_alisveris.Text, sec_belgetipi.Text, txt_altlimit.EditValue, txt_ustlimit.EditValue)
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If MenuItem9.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem9.Checked = True
        ElseIf MenuItem9.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem9.Checked = False
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If MenuItem10.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem10.Checked = True
        ElseIf MenuItem10.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem10.Checked = False
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        ekran_kapla()
    End Sub
    Private Sub ekran_kapla()
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub frm_kasiyer_stok_fiyatlandir_liste_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl4 = Nothing
        'PanelControl5 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'txt_kod = Nothing
        'txt_kasiyer = Nothing
        'DataSet1 = Nothing
        'DataTable1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem14 = Nothing
        'MenuItem20 = Nothing
        'MenuItem19 = Nothing
        'MenuItem21 = Nothing
        'MenuItem22 = Nothing
        'MenuItem23 = Nothing
        'MenuItem15 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem16 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem17 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem18 = Nothing
        'MenuItem13 = Nothing
        'btn_baglan = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'Label2 = Nothing
        'ps = Nothing
        'printlink1 = Nothing
        'SimpleButton4 = Nothing
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
        'SimpleButton5 = Nothing
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
        'OpenFileDialog1 = Nothing
        'SimpleButton6 = Nothing
        'Label3 = Nothing
        'Label4 = Nothing
        'txt_musterino = Nothing
        'txt_belgeno = Nothing
        'DataColumn44 = Nothing
        'lbl_isim = Nothing
        'DataColumn45 = Nothing
        'BarManager1 = Nothing
        'barDockControlTop = Nothing
        'barDockControlBottom = Nothing
        'barDockControlLeft = Nothing
        'barDockControlRight = Nothing
        'Bar3 = Nothing
        'BarSubItem1 = Nothing
        'BarButtonItem1 = Nothing
        'BarButtonItem2 = Nothing
        'BarButtonItem3 = Nothing
        'DataColumn46 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'DataColumn47 = Nothing
        'GroupControl1 = Nothing
        'lbl_istihbarat = Nothing
        'MenuItem24 = Nothing
        'MenuItem25 = Nothing
        'MenuItem26 = Nothing
        'Label5 = Nothing
        'MenuItem27 = Nothing
        'DateEdit1 = Nothing
        'DateEdit2 = Nothing
        'Label6 = Nothing
        'Label7 = Nothing
        'Label8 = Nothing
        'sec_kriter = Nothing
        'SplitterControl1 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'colFIRMAKODU = Nothing
        'colADI = Nothing
        'colSOYADI = Nothing
        'colBELGENO = Nothing
        'colTARIH = Nothing
        'colMIKTAR = Nothing
        'colTUTAR = Nothing
        'colALISVERISNO = Nothing
        'colIZAHAT = Nothing
        'colVADEFARKI = Nothing
        'colMAGAZA = Nothing
        'colKASIYER = Nothing
        'colGIRIS = Nothing
        'colYAZI = Nothing
        'colDOGUMTARIHI = Nothing
        'colEVLILIKTARIHI = Nothing
        'colYAZDIRMA = Nothing
        'colKAYIT = Nothing
        'colSOZLESME = Nothing
        'XtraTabControl1 = Nothing
        'XtraTabPage1 = Nothing
        'XtraTabPage2 = Nothing
        'GroupControl2 = Nothing
        'SplitterControl2 = Nothing
        'GroupControl4 = Nothing
        'SplitterControl3 = Nothing
        'GroupControl5 = Nothing
        'Grid_satis_kapatma = Nothing
        'GridView5 = Nothing
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
        'Grid_odemeler = Nothing
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
        'grid_odemeler_kalan = Nothing
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
        'Panelstatus = Nothing
        'bar2 = Nothing
        'barlabel2 = Nothing
        'barlabel = Nothing
        'bar = Nothing
        'panel_info = Nothing
        'panel_alt = Nothing
        'panel_hareket = Nothing
        'Panel_hareketler = Nothing
        'Context_satis = Nothing
        'MenuItem28 = Nothing
        'MenuItem29 = Nothing
        'MenuItem30 = Nothing
        'MenuItem31 = Nothing
        'MenuItem32 = Nothing
        'MenuItem33 = Nothing
        'MenuItem34 = Nothing
        'MenuItem35 = Nothing
        'MenuItem36 = Nothing
        'MenuItem37 = Nothing
        'MenuItem38 = Nothing
        'MenuItem39 = Nothing
        'printlink2 = Nothing
        'Context_odeme = Nothing
        'MenuItem40 = Nothing
        'MenuItem42 = Nothing
        'MenuItem43 = Nothing
        'MenuItem44 = Nothing
        'MenuItem45 = Nothing
        'MenuItem46 = Nothing
        'MenuItem47 = Nothing
        'MenuItem48 = Nothing
        'MenuItem49 = Nothing
        'MenuItem50 = Nothing
        'MenuItem51 = Nothing
        'MenuItem52 = Nothing
        'MenuItem53 = Nothing
        'printlink3 = Nothing
        'GroupControl6 = Nothing
        'GridView2 = Nothing
        'colsOdemeSekli = Nothing
        'collOdemeTutar = Nothing
        'colsKasiyerRumuzu = Nothing
        'Grid_satis_pesinat = Nothing
        'colsFiyatTipi = Nothing
        'colKayitTarihi = Nothing
        'colKalanTaksit = Nothing
        'colSevkAciklama = Nothing
        'colStokOdeme = Nothing
        'colnIslemId = Nothing
        'colsHareketTipi = Nothing
        'colIadeAvInf = Nothing
        'colMalBedeli = Nothing
        'colGirisCikis = Nothing
        'colOdemeAciklama = Nothing
        'colTeslimatci = Nothing
        'colKasiyerRumuzu = Nothing
        'colSaticiRumuzu = Nothing
        'colOdemeTipi = Nothing
        'colOdemeTutar = Nothing
        'collNetTutar = Nothing
        'colIskonto = Nothing
        'colFiyat = Nothing
        'GridColumn1 = Nothing
        'GridColumn4 = Nothing
        'colsKodu = Nothing
        'collNo = Nothing
        'colsFisTipi = Nothing
        'coldteTarih = Nothing
        'collMusteriAdi = Nothing
        'collKodu = Nothing
        'GridView4 = Nothing
        'SplitterControl4 = Nothing
        'GroupControl3 = Nothing
        'Grid_satis_detay = Nothing
        'GridView3 = Nothing
        'GridColumn2 = Nothing
        'GridColumn3 = Nothing
        'GridColumn5 = Nothing
        'GridColumn6 = Nothing
        'GridColumn7 = Nothing
        'GridColumn8 = Nothing
        'GridColumn31 = Nothing
        'GridColumn32 = Nothing
        'GridColumn33 = Nothing
        'GridColumn34 = Nothing
        'GridColumn35 = Nothing
        'GridColumn36 = Nothing
        'GridColumn37 = Nothing
        'GridColumn38 = Nothing
        'GridColumn39 = Nothing
        'GridColumn40 = Nothing
        'GridColumn41 = Nothing
        'GridColumn42 = Nothing
        'GridColumn43 = Nothing
        'GridColumn44 = Nothing
        'GridColumn45 = Nothing
        'GridColumn46 = Nothing
        'GridColumn47 = Nothing
        'GridColumn48 = Nothing
        'GridColumn49 = Nothing
        'GridColumn50 = Nothing
        'GridColumn51 = Nothing
        'Label9 = Nothing
        'sec_alisveris = Nothing
        'Label10 = Nothing
        'txt_ustlimit = Nothing
        'Label11 = Nothing
        'txt_altlimit = Nothing
        'sec_belgetipi = Nothing
        'MenuItem41 = Nothing
        'MenuItem54 = Nothing
        'MenuItem55 = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Function kayit_kontrol() As Int64
        Dim sayi As Integer = 0
        'dataload(Today, kasiyerno)
        'For Each dr In DataSet1.Tables(0).Rows
        '    'If dr(sorgu_sDil("Dikkat",sDil)) = "Bekliyor..." Then
        '    '    sayi = 1
        '    'End If
        'Next
        Return sayi
        sayi = Nothing
    End Function
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(kasiyerno) = "VC" Then
                If XtraMessageBox.Show(dr("StokKodu") & Sorgu_sDil("  Kodlu Stoðun Fiyatýný Eski Fiyatý Ýle Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("eFiyat"))
                    duzelt2(dr("IND"), Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, sec_kriter.Text, sec_alisveris.Text, sec_belgetipi.Text, txt_altlimit.EditValue, txt_ustlimit.EditValue)
                End If
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
                If XtraMessageBox.Show(dr("StokKodu") & Sorgu_sDil("  Kodlu Stoðun Fiyatýný Eski Fiyatý Ýle Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("eFiyat"))
                    duzelt2(dr("IND"), Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, sec_kriter.Text, sec_alisveris.Text, sec_belgetipi.Text, txt_altlimit.EditValue, txt_ustlimit.EditValue)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Yetkiniz Yok...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub raporla_dosya_sec(ByVal islem As Integer)
        Dim file As String
        Dim dr As DataRow
        Dim musterino As Int64
        Dim sontahsilattarihi As DateTime
        Dim sontahsilattutari As Decimal
        Dim sonsatistarihi As DateTime
        Dim sonsatistutari As Decimal
        Dim gecikmistaksitsayisi As Int64
        Dim gecikmistaksittutari As Decimal
        Dim toplamkalantaksitsayisi As Int64
        Dim toplamkalantaksittutari As Decimal = 0
        Dim gecikmisodeme As Int64 = 0
        Dim gunundeodeme As Int64 = 0
        Dim erkenodeme As Int64 = 0
        Dim odemesayisi As Int64 = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            musterino = dr("nMusteriID")
            gecikmistaksitsayisi = sorgu_sayi(dr("GECIKMISTAKSIT"), 0)
            gecikmistaksittutari = sorgu_sayi(dr("GECIKMISKALAN"), 0)
            sonsatistutari = sorgu_sayi(dr("SONSATISTUTARI"), 0)
            sonsatistarihi = dr("SONSATISTARIHI")
            sontahsilattarihi = dr("SONTAHSILATTARIHI")
            sontahsilattutari = sorgu_sayi(dr("SONTAHSILATTUTARI"), 0)
            toplamkalantaksitsayisi = sorgu_sayi(dr("KALANTAKSITSAYISI"), 0)
            toplamkalantaksittutari = sorgu_sayi(dr("TOPLAMKALAN"), 0)
            Try
                gecikmisodeme = dr("GECIKMIS")
                gunundeodeme = dr("GUNUNDE")
                erkenodeme = dr("ERKEN")
                odemesayisi = dr("TOPLAM")
            Catch ex As Exception
                gecikmisodeme = 0
                gunundeodeme = 0
                erkenodeme = 0
                odemesayisi = 0
            End Try
            'report_create_stok(file, satir_kontrol, islem, musterino, sontahsilattarihi, sontahsilattutari, sonsatistarihi, sonsatistutari, gecikmistaksitsayisi, gecikmistaksittutari, toplamkalantaksitsayisi, toplamkalantaksittutari, gecikmisodeme, gunundeodeme, erkenodeme, odemesayisi)
        End If
        dr = Nothing
    End Sub
    Private Sub raporla(ByVal islem As Integer, Optional ByVal bDepoya As Boolean = False)
        Dim file As String = ""
        Dim dr As DataRow
        Dim musterino As Int64
        Dim sontahsilattarihi 'As DateTime
        Dim sontahsilattutari As Decimal
        Dim sonsatistarihi 'As DateTime
        Dim sonsatistutari As Decimal
        Dim gecikmistaksitsayisi As Int64
        Dim gecikmistaksittutari As Decimal
        Dim toplamkalantaksitsayisi As Int64
        Dim toplamkalantaksittutari As Decimal = 0
        Dim gecikmisodeme As Int64 = 0
        Dim gunundeodeme As Int64 = 0
        Dim erkenodeme As Int64 = 0
        Dim odemesayisi As Int64 = 0
        Dim izahat As String
        Dim tarih As DateTime
        Dim belgeno As String
        Dim musterikodu As String
        Dim miktar As Decimal
        Dim tutar As Decimal
        OpenFileDialog1.Filter = "EtiketDosyalarý(*" & sRaporUzanti & ") |" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        izahat = dr("IZAHAT")
        If Trim(dr("IZAHAT")).ToString = "OD" Then
            If sec_dotmatrix.Checked = True Then
                file = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme_dot.fr3"
            ElseIf sec_to.Checked = True Then
                file = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme_termal" & sRaporUzanti & ""
            Else
                file = "C:\Formlar\Raporlar\Dokumler\Perakende_Odeme" & sRaporUzanti & ""
            End If
            'file = "c:\Formlar\Raporlar\Dokumler\Perakende_Odeme.fr3"
        ElseIf Trim(dr("IZAHAT")).ToString = "K" Or Trim(dr("IZAHAT")).ToString = "P" Then
            If bDepoya = True Then
                file = "C:\Formlar\Raporlar\Dokumler\Perakende_Fatura_depo" & sRaporUzanti & ""
            Else
                If sec_dotmatrix.Checked = True Then
                    file = "C:\Formlar\Raporlar\Dokumler\Perakende_Fatura_dot.fr3"
                Else
                    file = "C:\Formlar\Raporlar\Dokumler\Perakende_Fatura" & sRaporUzanti & ""
                End If
            End If
        ElseIf Trim(dr("IZAHAT")).ToString = "SP" Or Trim(dr("IZAHAT")).ToString = "SK" Then
            If bDepoya = True Then
                file = "C:\Formlar\Raporlar\Dokumler\Perakende_Siparis_depo" & sRaporUzanti & ""
            Else
                If sec_dotmatrix.Checked = True Then
                    file = "C:\Formlar\Raporlar\Dokumler\Perakende_Siparis_dot.fr3"
                Else
                    file = "C:\Formlar\Raporlar\Dokumler\Perakende_Siparis" & sRaporUzanti & ""
                End If
            End If
            'file = "c:\Formlar\Raporlar\Dokumler\Perakende_Siparis.fr3"
        End If
        'file = OpenFileDialog1.FileName.ToString
        musterino = dr("nMusteriID")
        gecikmistaksitsayisi = sorgu_sayi(dr("GECIKMISTAKSIT"), 0)
        gecikmistaksittutari = sorgu_sayi(dr("GECIKMISKALAN"), 0)
        sonsatistutari = sorgu_sayi(dr("SONSATISTUTARI"), 0)
        If sec_analiz.Checked = True Then
            sonsatistarihi = sorgu_tarih(dr("SONSATISTARIHI"), "01/01/1900")
            sontahsilattarihi = sorgu_tarih(dr("SONTAHSILATTARIHI"), "01/01/1900")
        Else
            sonsatistarihi = "01/01/1900"
            sontahsilattarihi = "01/01/1900"
        End If
        sontahsilattutari = sorgu_sayi(dr("SONTAHSILATTUTARI"), 0)
        toplamkalantaksitsayisi = sorgu_sayi(dr("KALANTAKSITSAYISI"), 0)
        toplamkalantaksittutari = sorgu_sayi(dr("TOPLAMKALAN"), 0)
        tarih = dr("TARIH")
        belgeno = dr("BELGENO")
        musterikodu = dr("FIRMAKODU")
        miktar = dr("MIKTAR")
        tutar = dr("TUTAR")
        Try
            gecikmisodeme = dr("GECIKMIS")
            gunundeodeme = dr("GUNUNDE")
            erkenodeme = dr("ERKEN")
            odemesayisi = dr("TOPLAM")
        Catch ex As Exception
            gecikmisodeme = 0
            gunundeodeme = 0
            erkenodeme = 0
            odemesayisi = 0
        End Try
        If sec_dotmatrix.Checked = True Then
            report_create_stok(file, satir_kontrol, izahat, islem, musterikodu, tarih, belgeno, miktar, tutar, musterino, sontahsilattarihi, sontahsilattutari, sonsatistarihi, sonsatistutari, gecikmistaksitsayisi, gecikmistaksittutari, toplamkalantaksitsayisi, toplamkalantaksittutari, gecikmisodeme, gunundeodeme, erkenodeme, odemesayisi, bDepoya)
        Else
            If sRaporUzanti = ".fr3" Then
                report_create_stok(file, satir_kontrol, izahat, islem, musterikodu, tarih, belgeno, miktar, tutar, musterino, sontahsilattarihi, sontahsilattutari, sonsatistarihi, sonsatistutari, gecikmistaksitsayisi, gecikmistaksittutari, toplamkalantaksitsayisi, toplamkalantaksittutari, gecikmisodeme, gunundeodeme, erkenodeme, odemesayisi, bDepoya)
            ElseIf sRaporUzanti = ".frx" Then
                report_create(file, satir_kontrol, izahat, islem, musterikodu, tarih, belgeno, miktar, tutar, musterino, sontahsilattarihi, sontahsilattutari, sonsatistarihi, sonsatistutari, gecikmistaksitsayisi, gecikmistaksittutari, toplamkalantaksitsayisi, toplamkalantaksittutari, gecikmisodeme, gunundeodeme, erkenodeme, odemesayisi, bDepoya)
            End If
        End If
        dr = Nothing
    End Sub
    Private Function satir_kontrol()
        Dim dr As DataRow
        Dim satir As String = "WHERE tbMusteri.nMusteriId IN ("
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
                dr = DataSet1.Tables(0).NewRow
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("nMusteriID").ToString
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
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal izahat As String, ByVal status As Integer, ByVal musterikodu As String, ByVal tarih As DateTime, ByVal belgeno As String, ByVal miktar As Decimal, ByVal tutar As Decimal, ByVal musterino As Int64, ByVal sontahsilattarihi As DateTime, ByVal sontahsilattutari As Decimal, ByVal sonsatistarihi As DateTime, ByVal sonsatistutari As Decimal, ByVal gecikmistaksitsayisi As Int64, ByVal gecikmistaksittutari As Decimal, ByVal kalantaksitsayisi As Int64, ByVal kalantaksittutari As Decimal, ByVal gecikmisodeme As Int64, ByVal gunundeodeme As Int64, ByVal erkenodeme As Int64, ByVal toplamodeme As Int64, Optional ByVal bDepoya As Boolean = False)
        Dim stokno = 0
        Dim satir_line = "100"
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'frx.PrintOptions.Copies = dr("MIKTAR")
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("GecikmisTaksitSayisi", "" & gecikmistaksitsayisi & "")
            frx.SetVariable("GecikmisTaksitTutari", "" & gecikmistaksittutari & "")
            frx.SetVariable("SonTahsilatTutari", "" & sontahsilattutari & "")
            frx.SetVariable("SonSatisTutari", "" & sonsatistutari & "")
            frx.SetVariable("SonTahsilatTarihi", "'" & sontahsilattarihi & "'")
            frx.SetVariable("SonSatisTarihi", "'" & sonsatistarihi & "'")
            frx.SetVariable("KalanTaksitSayisi", "" & kalantaksitsayisi & "")
            frx.SetVariable("KalanTaksitTutari", "" & kalantaksittutari & "")
            frx.SetVariable("GecikmisOdeme", "" & gecikmisodeme & "")
            frx.SetVariable("GunundeOdeme", "" & gunundeodeme & "")
            frx.SetVariable("ErkenOdeme", "" & erkenodeme & "")
            frx.SetVariable("ToplamOdeme", "" & toplamodeme & "")
            frx.SetVariable("FisMiktari", "" & miktar & "")
            frx.SetVariable("FisTutari", "" & tutar & "")
            frx.SetVariable("Anons", "'" & lbl_isim.Text & "'")
            If Trim(izahat) = "OD" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         vwParekendeOdeme WHERE     (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')")
                frx.SetVariable("BelgeTipi", "'Tahsilat'")
            ElseIf Trim(izahat) = "K" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satýþ Ýade/Deðiþim'")
                End If
            ElseIf Trim(izahat) = "P" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Peþin Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Peþin Satýþ Ýade/Deðiþim'")
                End If
            ElseIf Trim(izahat) = "SP" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peþin Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peþin Satýþ Ýade/Deðiþim'")
                End If
            ElseIf Trim(izahat) = "SK" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satýþ Ýade/Deðiþim'")
                End If
            End If
            '        qr_hareket = frx.FindObject("qr_musteri")
            '       qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu, (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) AS MUSTERI,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteriSinifi.sSinifKodu1 AS KOD1, tbMusteriSinifi.sSinifKodu2 AS KOD2, tbMusteriSinifi.sSinifKodu3 AS KOD3, tbMusteriSinifi.sSinifKodu4 AS KOD4, tbMusteriSinifi.sSinifKodu5 AS KOD5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID Where TbMusteri.nMusteriID =" & musterino & " Order By TbMusteri.lKodu")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                'frx.PrepareReport(True)
                frx.DisableDialogs = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.ShowDialog = False
                frx.PrintOptions.Copies = 1
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
            args(4) = "" & status.ToString() & ""
            args(5) = "20"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "GecikmisTaksitSayisi"
            args(15) = "" & gecikmistaksitsayisi.ToString() & ""
            args(16) = "GecikmisTaksitTutari"
            args(17) = "" & gecikmistaksittutari.ToString() & ""
            args(18) = "SonTahsilatTutari"
            args(19) = "" & sontahsilattutari.ToString() & ""
            args(20) = "SonSatisTutari"
            args(21) = "" & sonsatistutari.ToString() & ""
            args(22) = "SonTahsilatTarihi"
            args(23) = "'" & sontahsilattarihi.ToString() & "'"
            args(24) = "SonSatisTarihi"
            args(25) = "'" & sonsatistarihi.ToString() & "'"
            args(26) = "KalanTaksitSayisi"
            args(27) = "" & kalantaksitsayisi.ToString() & ""
            args(28) = "KalanTaksitTutari"
            args(29) = "" & kalantaksittutari.ToString() & ""
            args(30) = "GecikmisOdeme"
            args(31) = "" & gecikmisodeme.ToString() & ""
            args(32) = "GunundeOdeme"
            args(33) = "" & gunundeodeme.ToString() & ""
            args(34) = "ErkenOdeme"
            args(35) = "" & erkenodeme.ToString() & ""
            args(36) = "ToplamOdeme"
            args(37) = "" & toplamodeme.ToString() & ""
            args(38) = "FisMiktari"
            args(39) = "" & miktar.ToString() & ""
            args(40) = "FisTutari"
            args(41) = "" & tutar.ToString() & ""
            args(42) = "Anons"
            args(43) = "'" & lbl_isim.Text & "'"
            If Trim(izahat) = "OD" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         vwParekendeOdeme WHERE     (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')") & ""
                args(44) = "BelgeTipi"
                args(45) = "'Tahsilat'"
            ElseIf Trim(izahat) = "K" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Kredili Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Kredili Satýþ Ýade/Deðiþim'"
                End If
            ElseIf Trim(izahat) = "P" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Peþin Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Peþin Satýþ Ýade/Deðiþim'"
                End If
            ElseIf Trim(izahat) = "SP" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Peþin Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Peþin Satýþ Ýade/Deðiþim'"
                End If
            ElseIf Trim(izahat) = "SK" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Kredili Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Kredili Satýþ Ýade/Deðiþim'"
                End If
            End If
            processYol = args(0)
            For i As Integer = 1 To 45
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
    Private Sub report_create(ByVal dosya As String, ByVal kriter As String, ByVal izahat As String, ByVal status As Integer, ByVal musterikodu As String, ByVal tarih As DateTime, ByVal belgeno As String, ByVal miktar As Decimal, ByVal tutar As Decimal, ByVal musterino As Int64, ByVal sontahsilattarihi As DateTime, ByVal sontahsilattutari As Decimal, ByVal sonsatistarihi As DateTime, ByVal sonsatistutari As Decimal, ByVal gecikmistaksitsayisi As Int64, ByVal gecikmistaksittutari As Decimal, ByVal kalantaksitsayisi As Int64, ByVal kalantaksittutari As Decimal, ByVal gecikmisodeme As Int64, ByVal gunundeodeme As Int64, ByVal erkenodeme As Int64, ByVal toplamodeme As Int64, Optional ByVal bDepoya As Boolean = False)
        Dim report As New FastReport.Report
        report.Load(dosya)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim nAlisVerisID As String = dr("ALISVERISNO")
        report.SetParameterValue("FIRMANO", "" & firmano & "")
        report.SetParameterValue("DONEMNO", "" & donemno & "")
        report.SetParameterValue("GecikmisTaksitSayisi", "" & gecikmistaksitsayisi & "")
        report.SetParameterValue("GecikmisTaksitTutari", "" & gecikmistaksittutari & "")
        report.SetParameterValue("SonTahsilatTutari", "" & sontahsilattutari & "")
        report.SetParameterValue("SonSatisTutari", "" & sonsatistutari & "")
        report.SetParameterValue("SonTahsilatTarihi", "" & sontahsilattarihi & "")
        report.SetParameterValue("SonSatisTarihi", "" & sonsatistarihi & "")
        report.SetParameterValue("KalanTaksitSayisi", "" & kalantaksitsayisi & "")
        report.SetParameterValue("KalanTaksitTutari", "" & kalantaksittutari & "")
        report.SetParameterValue("GecikmisOdeme", "" & gecikmisodeme & "")
        report.SetParameterValue("GunundeOdeme", "" & gunundeodeme & "")
        report.SetParameterValue("ErkenOdeme", "" & erkenodeme & "")
        report.SetParameterValue("ToplamOdeme", "" & toplamodeme & "")
        report.SetParameterValue("FisMiktari", "" & miktar & "")
        report.SetParameterValue("FisTutari", "" & tutar & "")
        report.SetParameterValue("Anons", "" & lbl_isim.Text & "")
        report.SetParameterValue("sYaziIle", dr("YAZI"))
        report.SetParameterValue("TUTAR", dr("TUTAR"))
        Dim ds_HAREKET As DataSet
        Dim ds_TOPLAM As DataSet
        Dim ds_Taksit As DataSet
        Dim ds_TaksitKalan As DataSet
        Dim ds_KAMPANYA As DataSet
        Dim ds_ANONS As DataSet
        If Trim(izahat) = "OD" Then
            ds_TOPLAM = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sum(tutari) as nToplamTutar FROM         vwParekendeOdeme WHERE     (MakbuzNo = " & belgeno & ") AND  (Fis_Musteri_Kodu = " & musterikodu & ") "), "TOPLAM")
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         vwParekendeOdeme WHERE     (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')"), "TAHSILAT")
            report.RegisterData(ds_HAREKET)
            report.RegisterData(ds_TOPLAM)
            report.SetParameterValue("BelgeTipi", "Tahsilat")
        ElseIf Trim(izahat) = "K" Then
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')"), "HAREKET")
            ds_Taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
            report.RegisterData(ds_HAREKET)
            report.RegisterData(ds_Taksit)
            If miktar > 0 Then
                report.SetParameterValue("BelgeTipi", "Kredili Satýþ")
            ElseIf miktar < 0 Then
                report.SetParameterValue("BelgeTipi", "Kredili Satýþ Ýade/Deðiþim")
            End If
        ElseIf Trim(izahat) = "P" Then
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')"), "HAREKET")
            ds_Taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
            report.RegisterData(ds_HAREKET)
            report.RegisterData(ds_Taksit)
            If miktar > 0 Then
                report.SetParameterValue("BelgeTipi", "Peþin Satýþ")
            ElseIf miktar < 0 Then
                report.SetParameterValue("BelgeTipi", "Peþin Satýþ Ýade/Deðiþim")
            End If
        ElseIf Trim(izahat) = "SP" Then
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')"), "HAREKET")
            ds_Taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
            report.RegisterData(ds_HAREKET)
            report.RegisterData(ds_Taksit)
            If miktar > 0 Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Peþin Satýþ")
            ElseIf miktar < 0 Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Peþin Satýþ Ýade/Deðiþim")
            End If
        ElseIf Trim(izahat) = "SK" Then
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')"), "HAREKET")
            ds_Taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
            report.RegisterData(ds_HAREKET)
            report.RegisterData(ds_Taksit)
            If miktar > 0 Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Kredili Satýþ")
            ElseIf miktar < 0 Then
                report.SetParameterValue("BelgeTipi", "Sonradan Teslim Kredili Satýþ Ýade/Deðiþim")
            End If
        End If
        ds_TaksitKalan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi "), "KalanTaksit")
        ds_KAMPANYA = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ATBLDOKUMKAMPANYA", "KAMPANYA")
        ds_ANONS = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ATBLDOKUMANONS", "ANONS")
        report.RegisterData(ds_TaksitKalan)
        report.RegisterData(ds_KAMPANYA)
        report.RegisterData(ds_ANONS)
        report.RegisterData(ds_tbParamGenel)
        Dim ara As String
        Try
            ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
        Catch ex As Exception
            ara = ""
        End Try
        'MsgBox(ara)
        Dim adi As String = ""
        Dim soyadi As String = ""
        Dim x
        If CStr(ara.ToString) <> "" Then
            x = (ara).IndexOf(",", 1, (ara.Length - 1))
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
        'MsgBox(adi)
        If Trim(izahat) = "OD" Then
            If sec_to.Checked = True Then
                Try
                    adi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterTermal").ToString
                Catch ex As Exception
                    adi = ""
                End Try
                If status = 0 Then
                    status = 1
                End If
            Else
                If adi.ToString <> "" Then
                    report.PrintSettings.Printer = adi
                End If
                If status <> 2 Then
                    If sec_goster.Checked = True Then
                        status = 0
                    ElseIf sec_goster.Checked = False Then
                        status = 1
                    End If
                End If
            End If
        End If
        If bDepoya = True Then
            report.PrintSettings.Printer = sPrinter_Depo
            status = 1
        Else
            If adi.ToString <> "" Then
                report.PrintSettings.Printer = adi
            End If
        End If
        report.ScriptLanguage = Language.Vb
        If status = 0 Then
            report.Show()
        ElseIf status = 2 Then
            report.Design()
        ElseIf status = 1 Then
            report.Print()
        End If
        report.Dispose()
        report = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_tarih(ByVal deger As Object, ByVal sonuc As DateTime) As DateTime
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("STATUS") = "False" Then
                taksit_kontrol_satirlar()
                raporla(0)
            Else
                raporla(0)
            End If
        End If
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("STATUS") = "False" Then
                taksit_kontrol_satirlar()
                raporla(2)
            Else
                raporla(2)
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("STATUS") = "False" Then
                taksit_kontrol_satirlar()
                raporla(0)
            Else
                raporla(0)
            End If
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Label5.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label5.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, sec_kriter.Text, sec_alisveris.Text, sec_belgetipi.Text, txt_altlimit.EditValue, txt_ustlimit.EditValue)
        Label5.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label5.Refresh()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim frm As New frm_kasiyer_dokum_anons
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
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
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("FIRMAKODU")
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
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("FIRMAKODU")
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
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("FIRMAKODU")
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
    Private Sub stok_odeme_detay_tumu()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_odeme
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.musterikodu = dr("FIRMAKODU")
            frm.tarih = dr("TARIH")
            frm.belgeno = dr("BELGENO")
            frm.tumu = True
            'frm.stokno = dr("ALISVERISNO")
            frm.fistipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub stok_satis_detay(ByVal alisverisno As String, ByVal izahat As String)
        Dim frm As New frm_stok_cari_satis
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.stokno = alisverisno
        frm.fistipi = izahat
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
    End Sub
    Private Sub stok_odeme_detay()
        Dim frm As New frm_stok_cari_odeme
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
    Private Sub incele()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("IZAHAT")).ToString = "OD" Then
                stok_odeme_detay()
            Else
                stok_satis_detay(dr("ALISVERISNO"), Trim(dr("IZAHAT").ToString))
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub musteri()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        stok_odeme_detay_tumu()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        incele()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        analiz_musteri_karti()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Try
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_isim.Text = dr("ADI") & " " & dr("SOYADI")
                Dim gun_dogum
                Dim yil
                Dim gun
                Dim ay
                If Trim(dr("DOGUMTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr("DOGUMTARIHI")).ToString.Substring(3, 2) = "01" Then
                ElseIf Trim(dr("DOGUMTARIHI")).ToString.Substring(0, 5) = "01/01" Then
                Else
                    'lbl_isim.Text += "  Doðum Tarihi :" & dr("DOGUMTARIHI").ToLongDateString
                    yil = Today.ToString.Substring(8, 2)
                    gun = dr("DOGUMTARIHI").ToString.Substring(0, 2)
                    ay = dr("DOGUMTARIHI").ToString.Substring(3, 2)
                    lbl_isim.Text += "  Doðum Günü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                    gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                    If gun_dogum > 0 And gun_dogum < 30 Then
                        lbl_isim.Text += " " & gun_dogum & " Gün Sonra Doðum Gününüz.Þimdiden Doðum Gününüz Kutlu Olsun..!"
                    ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                        lbl_isim.Text += " " & Math.Abs(gun_dogum) & " Gün Önce Doðum Gününüzmüþ...Nice Senelere..!"
                    ElseIf gun_dogum = 0 Then
                        lbl_isim.Text += "  Doðum Gününüz Kutlu Olsun...!"
                    End If
                End If
                lbl_istihbarat.Text = dr("ISTIHBARAT")
                If Trim(dr("EVLILIKTARIHI")).ToString.Substring(0, 2) = "01" And Trim(dr("EVLILIKTARIHI")).ToString.Substring(3, 2) = "01" Then
                ElseIf Trim(dr("EVLILIKTARIHI")).ToString.Substring(0, 5) = "01/01" Then
                Else
                    lbl_isim.Text += "  Evlilik Tarihi :" & dr("EVLILIKTARIHI")
                    yil = Today.ToString.Substring(8, 2)
                    gun = dr("EVLILIKTARIHI").ToString.Substring(0, 2)
                    ay = dr("EVLILIKTARIHI").ToString.Substring(3, 2)
                    lbl_isim.Text += "  Evlilik Yýldönümü :" & CDate(gun + "." + ay + "." + yil).ToLongDateString
                    gun_dogum = DateDiff(DateInterval.Day, Today, CDate(gun + "." + ay + "." + yil))
                    If gun_dogum > 0 And gun_dogum < 30 Then
                        lbl_isim.Text += " " & gun_dogum & " Gün Sonra Evlilik Yýldönümünüz.Þimdiden Evlilik Yýldönümünüz Kutlu Olsun..!"
                    ElseIf gun_dogum < 0 And Math.Abs(gun_dogum) < 30 Then
                        lbl_isim.Text += " " & Math.Abs(gun_dogum) & " Gün Önce Evlilik Yýldönümünüzmüþ...Nice Senelere..!"
                    ElseIf gun_dogum = 0 Then
                        lbl_isim.Text += "  Evlilik Yýldönümünüz Kutlu Olsun...!"
                    End If
                End If
            Catch ex As Exception
                Label2.Text = "*"
            End Try
        Else
            Label2.Text = "*"
        End If
        If GridView1.SelectedRowsCount > 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label5.Text = ""
        End If
    End Sub
    Private Sub dataload_detay()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_detay = satis_detay(Trim(dr("IZAHAT").ToString), dr("ALISVERISNO"))
            ds_kapatma = satis_kapatma(dr("ALISVERISNO"))
            ds_pesinat = satis_odemeleri_pesinat(dr("ALISVERISNO"))
            'ds_satis_odeme = satis_odemeleri(dr("ALISVERISNO"))
            Grid_satis_detay.DataSource = ds_detay.Tables(0)
            Grid_satis_detay.DataMember = Nothing
            Grid_satis_kapatma.DataSource = ds_kapatma.Tables(0)
            Grid_satis_kapatma.DataMember = Nothing
            Grid_satis_pesinat.DataSource = ds_pesinat.Tables(0)
            Grid_satis_pesinat.DataMember = Nothing
            'Grid_satis_odeme.DataSource = ds_satis_odeme.Tables(0)
            'Grid_satis_odeme.DataMember = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub dataload_odemeler()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_odemeler = odemeler(dr("nMusteriID"), dr("TARIH"), dr("BELGENO"))
            Grid_odemeler.DataSource = ds_odemeler.Tables(0)
            Grid_odemeler.DataMember = Nothing
            ds_odemeler_kalan = odemeler_kalan(dr("nMusteriID"))
            grid_odemeler_kalan.DataSource = ds_odemeler_kalan.Tables(0)
            grid_odemeler_kalan.DataMember = Nothing
            grid_odemeler_kalan.RefreshData()
            ''PanelControl3.Select()
            'Grid_odemeler.Focus()
            'Grid_odemeler.Select()
            GridView7.ExpandAllGroups()
            dr = Nothing
        End If
    End Sub
    Public Function odemeler(ByVal musteriID As String, ByVal tarih As DateTime, ByVal belgeno As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED                           SELECT *, ROUND(CAST(cast(Tarihi AS INT) - (CAST(Taksit_Tarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT dbo.tbOdeme.nOdemeID AS Odeme_Tanimlama_No , dbo.tbMusteri.nMusteriID AS Fis_Musteri_TanimlamaNo , dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu , dbo.tbMusteri.sAdi AS Fis_Musteri_Adi , dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi , dbo.tbOdeme.nOdemeKodu AS Odeme_Kodu , dbo.tbOdeme.sOdemeSekli AS Odeme_Sekli , dbo.tbOdemeSekli.sAciklama AS Odeme_Sekli_Aciklamasi , dbo.tbKasiyer.sKasiyerRumuzu AS Alan_Kasiyer_Rumuzu , dbo.tbKasiyer.sAdi AS Alan_Kasiyer_Adi , dbo.tbKasiyer.sSoyadi AS Alan_Kasiyer_Soyadi , dbo.tbOdeme.dteOdemeTarihi AS Tarihi , dbo.tbOdeme.lOdemeTutar AS Tutari , dbo.tbOdeme.sDovizCinsi AS DovizCinsi , dbo.tbOdeme.lDovizTutar AS DovizTutari , dbo.tbOdeme.lMakbuzNo AS MakbuzNo , dbo.tbOdeme.lOdemeNo AS OdemeNo , dbo.tbAlisVeris.dteFaturaTarihi AS Alisveris_Tarihi , dbo.tbAlisVeris.lFaturaNo AS Alisveris_FaturaNo , dbo.tbAlisVeris.sHareketTipi AS Alisveris_HareketTipi , dbo.tbAlisVeris.sFisTipi AS Alisveris_sFistipi , ISNULL(dbo.tbTaksit.dteTarihi , dbo.tbAlisVeris.dteFaturaTarihi) AS Taksit_Tarihi , dbo.tbAlisVeris.nAlisverisID FROM dbo.tbTaksit RIGHT OUTER JOIN dbo.tbKasiyer INNER JOIN dbo.tbAlisVeris INNER JOIN dbo.tbOdeme INNER JOIN dbo.tbOdemeSekli ON dbo.tbOdeme.sOdemeSekli = dbo.tbOdemeSekli.sOdemeSekli ON dbo.tbAlisVeris.nAlisverisID = dbo.tbOdeme.nAlisverisID ON dbo.tbKasiyer.sKasiyerRumuzu = dbo.tbOdeme.sKasiyerRumuzu INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbTaksit.nTaksitID = dbo.tbOdeme.nTaksitID WHERE (dbo.tbOdeme.nOdemeKodu = 2)) AS TT  WHERE  (Fis_Musteri_TanimlamaNo = " & musteriID & ") ")
        cmd.CommandText = sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED                           SELECT *, ROUND(CAST(cast(Tarihi AS INT) - (CAST(Taksit_Tarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT dbo.tbOdeme.nOdemeID AS Odeme_Tanimlama_No , dbo.tbMusteri.nMusteriID AS Fis_Musteri_TanimlamaNo , dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu , dbo.tbMusteri.sAdi AS Fis_Musteri_Adi , dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi , dbo.tbOdeme.nOdemeKodu AS Odeme_Kodu , dbo.tbOdeme.sOdemeSekli AS Odeme_Sekli , dbo.tbOdemeSekli.sAciklama AS Odeme_Sekli_Aciklamasi , dbo.tbKasiyer.sKasiyerRumuzu AS Alan_Kasiyer_Rumuzu , dbo.tbKasiyer.sAdi AS Alan_Kasiyer_Adi , dbo.tbKasiyer.sSoyadi AS Alan_Kasiyer_Soyadi , dbo.tbOdeme.dteOdemeTarihi AS Tarihi , dbo.tbOdeme.lOdemeTutar AS Tutari , dbo.tbOdeme.sDovizCinsi AS DovizCinsi , dbo.tbOdeme.lDovizTutar AS DovizTutari , dbo.tbOdeme.lMakbuzNo AS MakbuzNo , dbo.tbOdeme.lOdemeNo AS OdemeNo , dbo.tbAlisVeris.dteFaturaTarihi AS Alisveris_Tarihi , dbo.tbAlisVeris.lFaturaNo AS Alisveris_FaturaNo , dbo.tbAlisVeris.sHareketTipi AS Alisveris_HareketTipi , dbo.tbAlisVeris.sFisTipi AS Alisveris_sFistipi , ISNULL(dbo.tbTaksit.dteTarihi , dbo.tbAlisVeris.dteFaturaTarihi) AS Taksit_Tarihi , dbo.tbAlisVeris.nAlisverisID FROM dbo.tbTaksit RIGHT OUTER JOIN dbo.tbKasiyer INNER JOIN dbo.tbAlisVeris INNER JOIN dbo.tbOdeme INNER JOIN dbo.tbOdemeSekli ON dbo.tbOdeme.sOdemeSekli = dbo.tbOdemeSekli.sOdemeSekli ON dbo.tbAlisVeris.nAlisverisID = dbo.tbOdeme.nAlisverisID ON dbo.tbKasiyer.sKasiyerRumuzu = dbo.tbOdeme.sKasiyerRumuzu INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbTaksit.nTaksitID = dbo.tbOdeme.nTaksitID WHERE (dbo.tbOdeme.nOdemeKodu = 2)) AS TT  WHERE (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_TanimlamaNo = " & musteriID & ") ")
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN,  CAST(MONTH(dteTarihi) AS VARCHAR(2)) + '.' + DATENAME(month, dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi as Ad, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, tbMusteri.sSoyadi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musteriID & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi  , tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
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
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID,tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sRenk, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT TOP 1 CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi,tbStokFisiDetayi.sFiyatTipi FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisVeris.nAlisverisID ='" & Trim(stokno) & "'")
        ElseIf sorgu = False Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID,tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lBrutTutar AS lNetTutar, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisverisSiparis.sIadeNedeni AS IadeAvInf, tbAlisverisSiparis.dteTeslimEdilecek AS Termin, tbAlisverisSiparis.dteTeslimEdilen AS Teslimat, tbAlisverisSiparis.bTeslimEdildi AS TeslimEdildi, tbAlisverisSiparis.dteOnayTarihi AS Onay, tbAlisVeris.sMagaza, tbStok.sRenk FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE  tbAlisVeris.nAlisverisID ='" & Trim(stokno) & "'")
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
        cmd.CommandText = sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED                           SELECT *, ROUND(CAST(cast(Tarihi AS INT) - (CAST(Taksit_Tarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT dbo.tbOdeme.nOdemeID AS Odeme_Tanimlama_No , dbo.tbMusteri.nMusteriID AS Fis_Musteri_TanimlamaNo , dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu , dbo.tbMusteri.sAdi AS Fis_Musteri_Adi , dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi , dbo.tbOdeme.nOdemeKodu AS Odeme_Kodu , dbo.tbOdeme.sOdemeSekli AS Odeme_Sekli , dbo.tbOdemeSekli.sAciklama AS Odeme_Sekli_Aciklamasi , dbo.tbKasiyer.sKasiyerRumuzu AS Alan_Kasiyer_Rumuzu , dbo.tbKasiyer.sAdi AS Alan_Kasiyer_Adi , dbo.tbKasiyer.sSoyadi AS Alan_Kasiyer_Soyadi , dbo.tbOdeme.dteOdemeTarihi AS Tarihi , dbo.tbOdeme.lOdemeTutar AS Tutari , dbo.tbOdeme.sDovizCinsi AS DovizCinsi , dbo.tbOdeme.lDovizTutar AS DovizTutari , dbo.tbOdeme.lMakbuzNo AS MakbuzNo , dbo.tbOdeme.lOdemeNo AS OdemeNo , dbo.tbAlisVeris.dteFaturaTarihi AS Alisveris_Tarihi , dbo.tbAlisVeris.lFaturaNo AS Alisveris_FaturaNo , dbo.tbAlisVeris.sHareketTipi AS Alisveris_HareketTipi , dbo.tbAlisVeris.sFisTipi AS Alisveris_sFistipi , ISNULL(dbo.tbTaksit.dteTarihi , dbo.tbAlisVeris.dteFaturaTarihi) AS Taksit_Tarihi , dbo.tbAlisVeris.nAlisverisID FROM dbo.tbTaksit RIGHT OUTER JOIN dbo.tbKasiyer INNER JOIN dbo.tbAlisVeris INNER JOIN dbo.tbOdeme INNER JOIN dbo.tbOdemeSekli ON dbo.tbOdeme.sOdemeSekli = dbo.tbOdemeSekli.sOdemeSekli ON dbo.tbAlisVeris.nAlisverisID = dbo.tbOdeme.nAlisverisID ON dbo.tbKasiyer.sKasiyerRumuzu = dbo.tbOdeme.sKasiyerRumuzu INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbTaksit.nTaksitID = dbo.tbOdeme.nTaksitID WHERE (dbo.tbOdeme.nOdemeKodu = 2)) AS TT  WHERE  (nAlisverisID = '" & belgeno & "') ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function satis_odemeleri_pesinat(ByVal belgeno As String) As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dbo.tbMusteri.nMusteriID AS Fis_TanimlamaNo, dbo.tbAlisVeris.sFisTipi AS Fis_Tipi, dbo.tbMusteri.nMusteriID AS Fis_Musteri_Tanimlama_No, dbo.tbMusteri.lKodu AS Fis_Musteri_Kodu, dbo.tbMusteri.sAdi AS Fis_Musteri_Adi, dbo.tbMusteri.sSoyadi AS Fis_Musteri_Soyadi, dbo.tbTaksit.nTaksitID AS Taksit_Fis_TanimlamaNo, dbo.tbTaksit.dteTarihi AS Taksit_Tarihi, dbo.tbTaksit.lTutari AS Taksit_Tutari, SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Odeme_tutar, dbo.tbAlisVeris.nAlisverisID AS Alisveris_TanimlamaNo, dbo.tbTaksit.lTutari - SUM(ISNULL(dbo.tbOdeme.lOdemeTutar, 0)) AS Musteri_Taksiti FROM dbo.tbOdeme RIGHT OUTER JOIN dbo.tbTaksit INNER JOIN dbo.tbAlisVeris ON dbo.tbTaksit.nAlisverisID = dbo.tbAlisVeris.nAlisverisID INNER JOIN dbo.tbMusteri ON dbo.tbAlisVeris.nMusteriID = dbo.tbMusteri.nMusteriID ON dbo.tbOdeme.nTaksitID = dbo.tbTaksit.nTaksitID where tbAlisveris.nAlisverisID ='" & belgeno & "' GROUP BY dbo.tbMusteri.nMusteriID, dbo.tbAlisVeris.sFisTipi, dbo.tbMusteri.lKodu, dbo.tbMusteri.sAdi, dbo.tbMusteri.sSoyadi, dbo.tbTaksit.nTaksitID, dbo.tbTaksit.dteTarihi, dbo.tbTaksit.lTutari, dbo.tbAlisVeris.nAlisverisID ")
        cmd.CommandText = sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED                           SELECT     sOdemeSekli, lOdemeTutar, sKasiyerRumuzu FROM         tbOdeme   WHERE  (nAlisverisID = '" & belgeno & "') ")
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
    Private Sub analiz_envanter()
        If GridView3.RowCount > 0 Then
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
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
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Try
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Trim(dr("IZAHAT")).ToString = "OD" Then
                    XtraTabPage2.PageVisible = True
                    XtraTabPage1.PageVisible = False
                    dataload_odemeler()
                Else
                    XtraTabPage2.PageVisible = False
                    XtraTabPage1.PageVisible = True
                    dataload_detay()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        GridView4.ColumnsCustomization()
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        printlink2.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        If MenuItem36.Checked = False Then
            GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView4.OptionsCustomization.AllowFilter = True
            MenuItem36.Checked = True
        ElseIf MenuItem36.Checked = True Then
            GridView4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView4.OptionsCustomization.AllowFilter = False
            MenuItem36.Checked = False
        End If
    End Sub
    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        If MenuItem37.Checked = False Then
            GridView4.OptionsView.ShowGroupPanel = True
            GridView4.OptionsCustomization.AllowGroup = True
            MenuItem37.Checked = True
        ElseIf MenuItem37.Checked = True Then
            GridView4.OptionsView.ShowGroupPanel = False
            GridView4.OptionsCustomization.AllowGroup = False
            MenuItem37.Checked = False
        End If
    End Sub
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        ekran_kapla()
    End Sub
    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        If GridView7.RowCount > 0 Then
            Dim dr As DataRow = GridView7.GetDataRow(GridView7.FocusedRowHandle)
            stok_satis_detay(dr("nAlisverisID"), Trim(dr("Alisveris_sFistipi").ToString))
            dr = Nothing
        End If
    End Sub
    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        GridView7.ExpandAllGroups()
    End Sub
    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        GridView7.CollapseAllGroups()
    End Sub
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        GridView7.ColumnsCustomization()
    End Sub
    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        printlink3.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        If MenuItem47.Checked = False Then
            GridView7.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView7.OptionsCustomization.AllowFilter = True
            MenuItem47.Checked = True
        ElseIf MenuItem47.Checked = True Then
            GridView7.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView7.OptionsCustomization.AllowFilter = False
            MenuItem47.Checked = False
        End If
    End Sub
    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        If MenuItem48.Checked = False Then
            GridView7.OptionsView.ShowGroupPanel = True
            GridView7.OptionsCustomization.AllowGroup = True
            MenuItem48.Checked = True
        ElseIf MenuItem48.Checked = True Then
            GridView7.OptionsView.ShowGroupPanel = False
            GridView7.OptionsCustomization.AllowGroup = False
            MenuItem48.Checked = False
        End If
    End Sub
    Private Sub txt_musterino_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonPressed
        musteri()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.F6 Then
            musteri()
        ElseIf e.KeyCode = Keys.Space Then
            If Trim(txt_musterino.Text) = "" Then
                musteri()
            End If
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
            frm.sec_MaliyetTipi.Text = "Stok Kartýndan"
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
    Private Sub takibe_al(Optional ByVal ajanda As Boolean = False)
        Dim frm As New frm_emir_musteri_takip_toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyerno = personelno
        frm.kasiyer = personel
        frm.txt_takip_aciklama.Text = "AlýþVeriþ Kontrol Listesi..."
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
                barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüþteriKodu:" & dr("FIRMAKODU").ToString & vbTab & "Adý:" & dr("ADI").ToString
                    barlabel.Refresh()
                    If ajanda = False Then
                        takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text & " ( " & dr("IZAHAT") & " ) ", frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("FIRMAKODU"), dr("ADI"), dr("SOYADI"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", dr("TUTAR"), False, "", "", "", "", "", False)
                    ElseIf ajanda = True Then
                        gorev_ekle(1, dr("nMusteriID"), Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50), frm.sec_personel.EditValue, 2, "Müþteri Takip Emri-ÝlkTaksitÖdemesi", frm.txt_takip_aciklama.Text & vbCrLf & dr("FIRMAKODU") + "-" + Microsoft.VisualBasic.Left(dr("ADI") + " " + dr("SOYADI"), 50) & vbCrLf & "AlýþVeriþTarihi : " & dr("TARIH") & " AlýþVeriþBelgeTipi: " & dr("IZAHAT") & " Kasiyer: " & dr("KASIYER") & " Miktar: " & FormatNumber(dr("MIKTAR"), 2) & " Tutar: " & dr("TUTAR") & vbCrLf & "ÝlkTaksitTarihi: " & dr("GECIKENILKTAKSITTARIHI") & " TaksitTutarý: " & dr("GECIKENILKTAKSITTUTARI"), 0, Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "17:00:00", Microsoft.VisualBasic.Left((dr("GECIKENILKTAKSITTARIHI")).ToString, 10) + " " + "21:00:00", "Kredi", False, 0, "", "", dr("GECIKENILKTAKSITTUTARI"), "", 0, True, False, 0)
                    End If
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
    Private Sub gorev_ekle(ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte, ByVal kayitno As Int64)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", '" & RecurrenceInfo & "','" & ReminderInfo & "', " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi,MusteriTakipIND) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", NULL,NULL, " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & "," & kayitno & ")")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        takibe_al()
    End Sub
    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr("STATUS") = "False" Then
            taksit_kontrol_satirlar()
            takibe_al(True)
        Else
            takibe_al(True)
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Label5.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label5.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue, sec_kriter.Text, sec_alisveris.Text, sec_belgetipi.Text, txt_altlimit.EditValue, txt_ustlimit.EditValue)
        Label5.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label5.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        If MenuItem56.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem56.Checked = True
        ElseIf MenuItem56.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem56.Checked = False
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView4_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView4.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView5_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView5.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView7_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView7.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        analiz_musteri_karlilikakistablosu()
    End Sub
End Class
