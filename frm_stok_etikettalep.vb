Imports FastReport
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.Win32
Imports System.IO
Public Class frm_stok_etikettalep
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
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
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
    Friend WithEvents Vgrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel_baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_toplamlar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_hareketler As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_toplam As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_depo_info As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_satis_info As DevExpress.XtraEditors.PanelControl
    Friend WithEvents VGrid_toplam As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents VGrid_depo_info As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FisIptal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirEkle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirSil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBELGENO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowACIKLAMA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKAYITTARIHI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAçýklama As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents kisayol_hareket As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_SatirEkle As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_SatirSil As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_DegerYay As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_depo_baslik As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_depo_hareket As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ds_belgetipi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents sec_baslik_belgetipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ds_detay As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_fiyat As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents sec_oran As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents rowSONUC As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDEPO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBEDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETIKET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_baslik_sonuc As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents sec_etiket As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_SatirEkleEnvanterli As System.Windows.Forms.MenuItem
    Friend WithEvents Panel_Ara As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_fiyattipi As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowTDEPO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_tdepo_baslik As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents btn_SatirEkleTransfer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirEkleAlis As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink3 As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowHESAPADI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents Menu_SatirEkleYeniler As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_SatirEkleDegisenler As System.Windows.Forms.MenuItem
    Friend WithEvents btn_SatirEklePaket As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem35 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem36 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem37 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem38 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colsBirimCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sBirimCinsi As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BarButtonItem39 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowbKilitli As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colnBirimCarpan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem40 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents BarButtonItem41 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem42 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents colFIYAT4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents colBekleyen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem43 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_etikettalep))
        Me.Panel_baslik = New DevExpress.XtraEditors.PanelControl()
        Me.Vgrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_baslik = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.sec_depo_baslik = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_baslik_belgetipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.sec_baslik_sonuc = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.sec_tdepo_baslik = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.rowbKilitli = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBELGENO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKAYITTARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryAçýklama = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSONUC = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDEPO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTDEPO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowHESAPADI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.Panel_toplamlar = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_satis_info = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel_depo_info = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.VGrid_depo_info = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.Panel_toplam = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.VGrid_toplam = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.Panel_hareketler = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_hareket = New System.Windows.Forms.ContextMenu()
        Me.Menu_SatirEkle = New System.Windows.Forms.MenuItem()
        Me.Menu_SatirEkleEnvanterli = New System.Windows.Forms.MenuItem()
        Me.Menu_SatirEkleYeniler = New System.Windows.Forms.MenuItem()
        Me.Menu_SatirEkleDegisenler = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.Menu_SatirSil = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Menu_DegerYay = New System.Windows.Forms.MenuItem()
        Me.ds_hareket = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBEDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETIKET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_etiket = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_depo_hareket = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyat = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colFIYAT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyattipi = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colsBirimCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sBirimCinsi = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.collBirimMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnBirimCarpan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBekleyen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_oran = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Panel_Ara = New DevExpress.XtraEditors.PanelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        Me.ds_detay = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem39 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem42 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FisIptal = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btn_SatirEkle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirEkleTransfer = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirEkleAlis = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirEklePaket = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirSil = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem43 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem38 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem33 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem37 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem35 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem36 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem41 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem34 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem40 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.ds_belgetipi = New System.Data.DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink3 = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_baslik.SuspendLayout()
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_sonuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tdepo_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_toplamlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_toplamlar.SuspendLayout()
        CType(Me.Panel_satis_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_satis_info.SuspendLayout()
        CType(Me.Panel_depo_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_depo_info.SuspendLayout()
        CType(Me.VGrid_depo_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_toplam.SuspendLayout()
        CType(Me.VGrid_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_hareketler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_hareketler.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_etiket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyattipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sBirimCinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_oran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelstatus.SuspendLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Ara.SuspendLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_baslik
        '
        Me.Panel_baslik.Controls.Add(Me.Vgrid_baslik)
        Me.Panel_baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_baslik.Location = New System.Drawing.Point(0, 22)
        Me.Panel_baslik.Name = "Panel_baslik"
        Me.Panel_baslik.Size = New System.Drawing.Size(824, 160)
        Me.Panel_baslik.TabIndex = 0
        '
        'Vgrid_baslik
        '
        Me.Vgrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.Vgrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.Vgrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(648, 330, 208, 252)
        Me.Vgrid_baslik.DataMember = Nothing
        Me.Vgrid_baslik.DataSource = Me.ds_baslik
        Me.Vgrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vgrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.Vgrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.Vgrid_baslik.Name = "Vgrid_baslik"
        Me.Vgrid_baslik.OptionsBehavior.UseTabKey = False
        Me.Vgrid_baslik.RecordWidth = 183
        Me.Vgrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_depo_baslik, Me.sec_baslik_belgetipi, Me.sec_baslik_sonuc, Me.sec_tdepo_baslik})
        Me.Vgrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowbKilitli, Me.categoryTanýmlar, Me.categoryAçýklama, Me.rowSONUC, Me.rowDEPO, Me.rowTDEPO, Me.rowHESAPADI})
        Me.Vgrid_baslik.Size = New System.Drawing.Size(820, 156)
        Me.Vgrid_baslik.TabIndex = 0
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn7, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn17, Me.DataColumn60, Me.DataColumn61, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TARIH"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "BELGENO"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KOD1"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KOD2"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "KOD3"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KOD4"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "KOD5"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ACIKLAMA"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KAYITTARIHI"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "DEPO"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "SONUC"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "TDEPO"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "AKTIF"
        Me.DataColumn28.DataType = GetType(Boolean)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "TRANSFER"
        Me.DataColumn29.DataType = GetType(Boolean)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "HESAPNO"
        Me.DataColumn30.DataType = GetType(Long)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "HESAPADI"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "bKilitli"
        Me.DataColumn32.DataType = GetType(Byte)
        '
        'sec_depo_baslik
        '
        Me.sec_depo_baslik.AutoHeight = False
        Me.sec_depo_baslik.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo_baslik.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOKODU", "DEPOKODU"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOADI", "DEPOADI")})
        Me.sec_depo_baslik.DisplayMember = "DEPOADI"
        Me.sec_depo_baslik.Name = "sec_depo_baslik"
        Me.sec_depo_baslik.NullText = "[Depo Seç]"
        Me.sec_depo_baslik.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_depo_baslik.ShowFooter = False
        Me.sec_depo_baslik.ShowHeader = False
        Me.sec_depo_baslik.ShowLines = False
        Me.sec_depo_baslik.ValueMember = "DEPOKODU"
        '
        'sec_baslik_belgetipi
        '
        Me.sec_baslik_belgetipi.AutoHeight = False
        Me.sec_baslik_belgetipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_baslik_belgetipi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "IND"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "ACIKLAMA")})
        Me.sec_baslik_belgetipi.DataSource = Me.DataTable5
        Me.sec_baslik_belgetipi.DisplayMember = "ACIKLAMA"
        Me.sec_baslik_belgetipi.Name = "sec_baslik_belgetipi"
        Me.sec_baslik_belgetipi.NullText = "[BelgeTipi Seç]"
        Me.sec_baslik_belgetipi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_baslik_belgetipi.ShowFooter = False
        Me.sec_baslik_belgetipi.ValueMember = "IND"
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn83, Me.DataColumn84})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "IND"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "ACIKLAMA"
        '
        'sec_baslik_sonuc
        '
        Me.sec_baslik_sonuc.AutoHeight = False
        Me.sec_baslik_sonuc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_baslik_sonuc.Items.AddRange(New Object() {"Bekliyor...", "Tamamlandý...", "Ýptal Edildi...", "Ürün Talebi...", "Sipariþ Talebi...", "Sayým...", "Takip..."})
        Me.sec_baslik_sonuc.Name = "sec_baslik_sonuc"
        Me.sec_baslik_sonuc.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_baslik_sonuc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'sec_tdepo_baslik
        '
        Me.sec_tdepo_baslik.AutoHeight = False
        Me.sec_tdepo_baslik.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tdepo_baslik.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOKODU", "DEPOKODU"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOADI", "DEPOADI")})
        Me.sec_tdepo_baslik.DisplayMember = "DEPOADI"
        Me.sec_tdepo_baslik.Name = "sec_tdepo_baslik"
        Me.sec_tdepo_baslik.NullText = "[GiriþDeposu Seç]"
        Me.sec_tdepo_baslik.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_tdepo_baslik.ShowFooter = False
        Me.sec_tdepo_baslik.ShowHeader = False
        Me.sec_tdepo_baslik.ShowLines = False
        Me.sec_tdepo_baslik.ValueMember = "DEPOKODU"
        '
        'rowbKilitli
        '
        Me.rowbKilitli.Name = "rowbKilitli"
        Me.rowbKilitli.Properties.Caption = "Kilitli?"
        Me.rowbKilitli.Properties.FieldName = "bKilitli"
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIND, Me.rowBELGENO, Me.rowKAYITTARIHI, Me.rowTARIH})
        Me.categoryTanýmlar.Name = "categoryTanýmlar"
        Me.categoryTanýmlar.Properties.Caption = "Tanýmlar"
        '
        'rowIND
        '
        Me.rowIND.Name = "rowIND"
        Me.rowIND.Properties.Caption = "Kayýt No"
        Me.rowIND.Properties.FieldName = "IND"
        Me.rowIND.Properties.ReadOnly = True
        '
        'rowBELGENO
        '
        Me.rowBELGENO.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rowBELGENO.Appearance.Options.UseBackColor = True
        Me.rowBELGENO.Name = "rowBELGENO"
        Me.rowBELGENO.Properties.Caption = "Belge No"
        Me.rowBELGENO.Properties.FieldName = "BELGENO"
        '
        'rowKAYITTARIHI
        '
        Me.rowKAYITTARIHI.Enabled = False
        Me.rowKAYITTARIHI.Name = "rowKAYITTARIHI"
        Me.rowKAYITTARIHI.Properties.Caption = "Kayýt Tarihi"
        Me.rowKAYITTARIHI.Properties.FieldName = "KAYITTARIHI"
        Me.rowKAYITTARIHI.Properties.ReadOnly = True
        Me.rowKAYITTARIHI.Visible = False
        '
        'rowTARIH
        '
        Me.rowTARIH.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rowTARIH.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowTARIH.Appearance.Options.UseBackColor = True
        Me.rowTARIH.Appearance.Options.UseFont = True
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.Properties.Caption = "BelgeTarihi"
        Me.rowTARIH.Properties.FieldName = "TARIH"
        '
        'categoryAçýklama
        '
        Me.categoryAçýklama.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowKOD1, Me.rowACIKLAMA, Me.rowKOD2, Me.rowKOD3, Me.rowKOD4, Me.rowKOD5})
        Me.categoryAçýklama.Name = "categoryAçýklama"
        Me.categoryAçýklama.Properties.Caption = "Açýklama"
        '
        'rowKOD1
        '
        Me.rowKOD1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rowKOD1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowKOD1.Appearance.Options.UseBackColor = True
        Me.rowKOD1.Appearance.Options.UseFont = True
        Me.rowKOD1.Name = "rowKOD1"
        Me.rowKOD1.Properties.Caption = "1.ÖzelKod"
        Me.rowKOD1.Properties.FieldName = "KOD1"
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rowACIKLAMA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowACIKLAMA.Appearance.Options.UseBackColor = True
        Me.rowACIKLAMA.Appearance.Options.UseFont = True
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.Properties.Caption = "Açýklama"
        Me.rowACIKLAMA.Properties.FieldName = "ACIKLAMA"
        '
        'rowKOD2
        '
        Me.rowKOD2.Name = "rowKOD2"
        Me.rowKOD2.Properties.Caption = "2.ÖzelKod"
        Me.rowKOD2.Properties.FieldName = "KOD2"
        '
        'rowKOD3
        '
        Me.rowKOD3.Name = "rowKOD3"
        Me.rowKOD3.Properties.Caption = "3.ÖzelKod"
        Me.rowKOD3.Properties.FieldName = "KOD3"
        '
        'rowKOD4
        '
        Me.rowKOD4.Name = "rowKOD4"
        Me.rowKOD4.Properties.Caption = "4.ÖzelKod"
        Me.rowKOD4.Properties.FieldName = "KOD4"
        '
        'rowKOD5
        '
        Me.rowKOD5.Name = "rowKOD5"
        Me.rowKOD5.Properties.Caption = "5.ÖzelKod"
        Me.rowKOD5.Properties.FieldName = "KOD5"
        Me.rowKOD5.Properties.ReadOnly = True
        '
        'rowSONUC
        '
        Me.rowSONUC.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rowSONUC.Appearance.Options.UseBackColor = True
        Me.rowSONUC.Name = "rowSONUC"
        Me.rowSONUC.Properties.Caption = "Sonuç"
        Me.rowSONUC.Properties.FieldName = "SONUC"
        Me.rowSONUC.Properties.RowEdit = Me.sec_baslik_sonuc
        '
        'rowDEPO
        '
        Me.rowDEPO.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rowDEPO.Appearance.Options.UseBackColor = True
        Me.rowDEPO.Name = "rowDEPO"
        Me.rowDEPO.Properties.Caption = "Depo"
        Me.rowDEPO.Properties.FieldName = "DEPO"
        Me.rowDEPO.Properties.RowEdit = Me.sec_depo_baslik
        '
        'rowTDEPO
        '
        Me.rowTDEPO.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rowTDEPO.Appearance.Options.UseBackColor = True
        Me.rowTDEPO.Name = "rowTDEPO"
        Me.rowTDEPO.Properties.Caption = "GiriþDeposu"
        Me.rowTDEPO.Properties.FieldName = "TDEPO"
        Me.rowTDEPO.Properties.RowEdit = Me.sec_tdepo_baslik
        Me.rowTDEPO.Visible = False
        '
        'rowHESAPADI
        '
        Me.rowHESAPADI.Name = "rowHESAPADI"
        Me.rowHESAPADI.Properties.Caption = "Hesap"
        Me.rowHESAPADI.Properties.FieldName = "HESAPADI"
        Me.rowHESAPADI.Visible = False
        '
        'Panel_toplamlar
        '
        Me.Panel_toplamlar.Controls.Add(Me.Panel_satis_info)
        Me.Panel_toplamlar.Controls.Add(Me.Panel_depo_info)
        Me.Panel_toplamlar.Controls.Add(Me.Panel_toplam)
        Me.Panel_toplamlar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_toplamlar.Location = New System.Drawing.Point(0, 420)
        Me.Panel_toplamlar.Name = "Panel_toplamlar"
        Me.Panel_toplamlar.Size = New System.Drawing.Size(824, 56)
        Me.Panel_toplamlar.TabIndex = 3
        '
        'Panel_satis_info
        '
        Me.Panel_satis_info.Controls.Add(Me.Label1)
        Me.Panel_satis_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_satis_info.Location = New System.Drawing.Point(208, 2)
        Me.Panel_satis_info.Name = "Panel_satis_info"
        Me.Panel_satis_info.Size = New System.Drawing.Size(374, 52)
        Me.Panel_satis_info.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*"
        '
        'Panel_depo_info
        '
        Me.Panel_depo_info.Controls.Add(Me.Label3)
        Me.Panel_depo_info.Controls.Add(Me.VGrid_depo_info)
        Me.Panel_depo_info.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_depo_info.Location = New System.Drawing.Point(2, 2)
        Me.Panel_depo_info.Name = "Panel_depo_info"
        Me.Panel_depo_info.Size = New System.Drawing.Size(206, 52)
        Me.Panel_depo_info.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "*"
        '
        'VGrid_depo_info
        '
        Me.VGrid_depo_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_depo_info.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_depo_info.Name = "VGrid_depo_info"
        Me.VGrid_depo_info.Size = New System.Drawing.Size(202, 48)
        Me.VGrid_depo_info.TabIndex = 0
        '
        'Panel_toplam
        '
        Me.Panel_toplam.Controls.Add(Me.Label2)
        Me.Panel_toplam.Controls.Add(Me.VGrid_toplam)
        Me.Panel_toplam.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_toplam.Location = New System.Drawing.Point(582, 2)
        Me.Panel_toplam.Name = "Panel_toplam"
        Me.Panel_toplam.Size = New System.Drawing.Size(240, 52)
        Me.Panel_toplam.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*"
        '
        'VGrid_toplam
        '
        Me.VGrid_toplam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_toplam.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_toplam.Name = "VGrid_toplam"
        Me.VGrid_toplam.Size = New System.Drawing.Size(236, 48)
        Me.VGrid_toplam.TabIndex = 0
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 182)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 6)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'Panel_hareketler
        '
        Me.Panel_hareketler.Controls.Add(Me.XtraTabControl1)
        Me.Panel_hareketler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_hareketler.Location = New System.Drawing.Point(0, 188)
        Me.Panel_hareketler.Name = "Panel_hareketler"
        Me.Panel_hareketler.Size = New System.Drawing.Size(824, 232)
        Me.Panel_hareketler.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 228)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Controls.Add(Me.panelstatus)
        Me.XtraTabPage1.Controls.Add(Me.Panel_Ara)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 195)
        Me.XtraTabPage1.Text = "Stoklar"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_hareket
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_depo_hareket, Me.sec_fiyat, Me.sec_oran, Me.sec_etiket, Me.sec_fiyattipi, Me.sec_sBirimCinsi})
        Me.GridControl1.Size = New System.Drawing.Size(818, 153)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_hareket
        '
        Me.kisayol_hareket.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_SatirEkle, Me.Menu_SatirEkleEnvanterli, Me.Menu_SatirEkleYeniler, Me.Menu_SatirEkleDegisenler, Me.MenuItem1, Me.MenuItem2, Me.Menu_SatirSil, Me.MenuItem5, Me.Menu_DegerYay})
        '
        'Menu_SatirEkle
        '
        Me.Menu_SatirEkle.Index = 0
        Me.Menu_SatirEkle.Text = "Satýr Ekle"
        '
        'Menu_SatirEkleEnvanterli
        '
        Me.Menu_SatirEkleEnvanterli.Index = 1
        Me.Menu_SatirEkleEnvanterli.Shortcut = System.Windows.Forms.Shortcut.CtrlIns
        Me.Menu_SatirEkleEnvanterli.Text = "Satýr Ekle Envanterli"
        '
        'Menu_SatirEkleYeniler
        '
        Me.Menu_SatirEkleYeniler.Index = 2
        Me.Menu_SatirEkleYeniler.Text = "Satýr Ekle Yeniler"
        '
        'Menu_SatirEkleDegisenler
        '
        Me.Menu_SatirEkleDegisenler.Index = 3
        Me.Menu_SatirEkleDegisenler.Text = "Satýr Ekle Deðiþenler"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Text = "Satýr Deðiþtir"
        '
        'Menu_SatirSil
        '
        Me.Menu_SatirSil.Index = 6
        Me.Menu_SatirSil.Text = "Satýr Sil"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 7
        Me.MenuItem5.Text = "-"
        '
        'Menu_DegerYay
        '
        Me.Menu_DegerYay.Index = 8
        Me.Menu_DegerYay.Text = "Deðer Yay"
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn8, Me.DataColumn9, Me.DataColumn16, Me.DataColumn18, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "IND"
        Me.DataColumn19.DataType = GetType(Long)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "EVRAKNO"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "STOKNO"
        Me.DataColumn21.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "STOKKODU"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MALINCINSI"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "BARCODE"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "RENK"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "BEDEN"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "MODEL"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ETIKET"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ACIKLAMA"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "DEPO"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "MIKTAR"
        Me.DataColumn23.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "FIYAT1"
        Me.DataColumn24.DataType = GetType(Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "FIYAT2"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "FIYAT3"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nBirimCarpan"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.Caption = "FIYAT4"
        Me.DataColumn34.ColumnName = "FIYAT4"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "FIYAT5"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colEVRAKNO, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colBARCODE, Me.colRENK, Me.colBEDEN, Me.colMODEL, Me.colETIKET, Me.colACIKLAMA, Me.colDEPO, Me.colMIKTAR, Me.colFIYAT1, Me.colFIYAT2, Me.colFIYAT3, Me.colsFiyatTipi, Me.colsBirimCinsi, Me.collBirimMiktar, Me.colnBirimCarpan, Me.colFIYAT4, Me.colFIYAT5, Me.colBekleyen})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(596, 267, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.OptionsColumn.AllowFocus = False
        Me.colIND.OptionsColumn.ReadOnly = True
        '
        'colEVRAKNO
        '
        Me.colEVRAKNO.Caption = "Evrak No"
        Me.colEVRAKNO.FieldName = "EVRAKNO"
        Me.colEVRAKNO.Name = "colEVRAKNO"
        Me.colEVRAKNO.OptionsColumn.AllowFocus = False
        Me.colEVRAKNO.OptionsColumn.ReadOnly = True
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        Me.colSTOKNO.OptionsColumn.AllowFocus = False
        Me.colSTOKNO.OptionsColumn.ReadOnly = True
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.OptionsColumn.AllowFocus = False
        Me.colSTOKKODU.OptionsColumn.ReadOnly = True
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 0
        Me.colSTOKKODU.Width = 56
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.OptionsColumn.AllowFocus = False
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 1
        Me.colMALINCINSI.Width = 110
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barcode"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        Me.colBARCODE.OptionsColumn.AllowFocus = False
        Me.colBARCODE.OptionsColumn.ReadOnly = True
        '
        'colRENK
        '
        Me.colRENK.Caption = "Renk"
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.Name = "colRENK"
        Me.colRENK.OptionsColumn.AllowFocus = False
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 2
        Me.colRENK.Width = 60
        '
        'colBEDEN
        '
        Me.colBEDEN.Caption = "Beden"
        Me.colBEDEN.FieldName = "BEDEN"
        Me.colBEDEN.Name = "colBEDEN"
        Me.colBEDEN.OptionsColumn.AllowFocus = False
        '
        'colMODEL
        '
        Me.colMODEL.Caption = "Model"
        Me.colMODEL.FieldName = "MODEL"
        Me.colMODEL.Name = "colMODEL"
        Me.colMODEL.OptionsColumn.AllowFocus = False
        '
        'colETIKET
        '
        Me.colETIKET.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colETIKET.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colETIKET.AppearanceCell.Options.UseFont = True
        Me.colETIKET.AppearanceCell.Options.UseForeColor = True
        Me.colETIKET.Caption = "Etiket"
        Me.colETIKET.ColumnEdit = Me.sec_etiket
        Me.colETIKET.FieldName = "ETIKET"
        Me.colETIKET.Name = "colETIKET"
        Me.colETIKET.Visible = True
        Me.colETIKET.VisibleIndex = 7
        Me.colETIKET.Width = 45
        '
        'sec_etiket
        '
        Me.sec_etiket.AutoHeight = False
        Me.sec_etiket.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_etiket.Items.AddRange(New Object() {"Fiyatlý", "Fiyatsýz", "Gizli Fiyat", "Kampanya Etiketi", "Þiþe/Barkak Etiketi", "A4 Dikey", "A4 Yatay", "A3 Dikey", "A3 Yatay", "Promosyon Etiketi"})
        Me.sec_etiket.Name = "sec_etiket"
        Me.sec_etiket.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.AppearanceCell.ForeColor = System.Drawing.Color.Magenta
        Me.colACIKLAMA.AppearanceCell.Options.UseForeColor = True
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 8
        Me.colACIKLAMA.Width = 58
        '
        'colDEPO
        '
        Me.colDEPO.Caption = "Depo"
        Me.colDEPO.ColumnEdit = Me.sec_depo_hareket
        Me.colDEPO.FieldName = "DEPO"
        Me.colDEPO.Name = "colDEPO"
        Me.colDEPO.Visible = True
        Me.colDEPO.VisibleIndex = 9
        Me.colDEPO.Width = 60
        '
        'sec_depo_hareket
        '
        Me.sec_depo_hareket.AutoHeight = False
        Me.sec_depo_hareket.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo_hareket.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOADI", "DEPOADI")})
        Me.sec_depo_hareket.DisplayMember = "DEPOADI"
        Me.sec_depo_hareket.Name = "sec_depo_hareket"
        Me.sec_depo_hareket.ValueMember = "DEPOKODU"
        '
        'colMIKTAR
        '
        Me.colMIKTAR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMIKTAR.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMIKTAR.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colMIKTAR.AppearanceCell.Options.UseBackColor = True
        Me.colMIKTAR.AppearanceCell.Options.UseForeColor = True
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "lMiktar"
        Me.colMIKTAR.GroupFormat.FormatString = "#,0.00"
        Me.colMIKTAR.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.##}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        Me.colMIKTAR.Width = 47
        '
        'colFIYAT1
        '
        Me.colFIYAT1.Caption = "1.Fiyat"
        Me.colFIYAT1.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT1.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT1.FieldName = "FIYAT1"
        Me.colFIYAT1.GroupFormat.FormatString = "#,0.00"
        Me.colFIYAT1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT1.Name = "colFIYAT1"
        Me.colFIYAT1.OptionsColumn.ReadOnly = True
        Me.colFIYAT1.Visible = True
        Me.colFIYAT1.VisibleIndex = 4
        Me.colFIYAT1.Width = 45
        '
        'sec_fiyat
        '
        Me.sec_fiyat.AutoHeight = False
        Me.sec_fiyat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyat.DisplayFormat.FormatString = "#,0.00"
        Me.sec_fiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat.EditFormat.FormatString = "#,0.00"
        Me.sec_fiyat.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat.Name = "sec_fiyat"
        '
        'colFIYAT2
        '
        Me.colFIYAT2.Caption = "2.Fiyat"
        Me.colFIYAT2.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT2.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT2.FieldName = "FIYAT2"
        Me.colFIYAT2.GroupFormat.FormatString = "#,0.00"
        Me.colFIYAT2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT2.Name = "colFIYAT2"
        Me.colFIYAT2.OptionsColumn.ReadOnly = True
        Me.colFIYAT2.Visible = True
        Me.colFIYAT2.VisibleIndex = 5
        Me.colFIYAT2.Width = 45
        '
        'colFIYAT3
        '
        Me.colFIYAT3.Caption = "3.Fiyat"
        Me.colFIYAT3.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT3.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT3.FieldName = "FIYAT3"
        Me.colFIYAT3.GroupFormat.FormatString = "#,0.00"
        Me.colFIYAT3.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT3.Name = "colFIYAT3"
        Me.colFIYAT3.OptionsColumn.ReadOnly = True
        Me.colFIYAT3.Visible = True
        Me.colFIYAT3.VisibleIndex = 6
        Me.colFIYAT3.Width = 45
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.ColumnEdit = Me.sec_fiyattipi
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 10
        Me.colsFiyatTipi.Width = 68
        '
        'sec_fiyattipi
        '
        Me.sec_fiyattipi.AutoHeight = False
        Me.sec_fiyattipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyattipi.Items.AddRange(New Object() {"PS", "6", "10", "HD"})
        Me.sec_fiyattipi.Name = "sec_fiyattipi"
        '
        'colsBirimCinsi
        '
        Me.colsBirimCinsi.Caption = "Birim"
        Me.colsBirimCinsi.ColumnEdit = Me.sec_sBirimCinsi
        Me.colsBirimCinsi.FieldName = "sBirimCinsi"
        Me.colsBirimCinsi.Name = "colsBirimCinsi"
        '
        'sec_sBirimCinsi
        '
        Me.sec_sBirimCinsi.AutoHeight = False
        Me.sec_sBirimCinsi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_sBirimCinsi.Name = "sec_sBirimCinsi"
        Me.sec_sBirimCinsi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'collBirimMiktar
        '
        Me.collBirimMiktar.Caption = "Birim Miktar"
        Me.collBirimMiktar.FieldName = "lBirimMiktar"
        Me.collBirimMiktar.Name = "collBirimMiktar"
        '
        'colnBirimCarpan
        '
        Me.colnBirimCarpan.Caption = "Koli Ýçi"
        Me.colnBirimCarpan.DisplayFormat.FormatString = "#,0.####"
        Me.colnBirimCarpan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnBirimCarpan.FieldName = "nBirimCarpan"
        Me.colnBirimCarpan.Name = "colnBirimCarpan"
        '
        'colFIYAT4
        '
        Me.colFIYAT4.Caption = "4.Fiyat"
        Me.colFIYAT4.FieldName = "FIYAT4"
        Me.colFIYAT4.Name = "colFIYAT4"
        Me.colFIYAT4.Visible = True
        Me.colFIYAT4.VisibleIndex = 11
        '
        'colFIYAT5
        '
        Me.colFIYAT5.Caption = "5.Fiyat"
        Me.colFIYAT5.FieldName = "FIYAT5"
        Me.colFIYAT5.Name = "colFIYAT5"
        Me.colFIYAT5.Visible = True
        Me.colFIYAT5.VisibleIndex = 12
        '
        'colBekleyen
        '
        Me.colBekleyen.Caption = "Bekleyen"
        Me.colBekleyen.FieldName = "Bekleyen"
        Me.colBekleyen.Name = "colBekleyen"
        '
        'sec_oran
        '
        Me.sec_oran.AutoHeight = False
        Me.sec_oran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_oran.DisplayFormat.FormatString = "#,0.00"
        Me.sec_oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_oran.EditFormat.FormatString = "#,0.00"
        Me.sec_oran.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_oran.Name = "sec_oran"
        '
        'panelstatus
        '
        Me.panelstatus.Controls.Add(Me.bar)
        Me.panelstatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelstatus.Location = New System.Drawing.Point(0, 153)
        Me.panelstatus.Name = "panelstatus"
        Me.panelstatus.Size = New System.Drawing.Size(818, 10)
        Me.panelstatus.TabIndex = 11
        Me.panelstatus.Visible = False
        '
        'bar
        '
        Me.bar.AllowDrop = True
        Me.bar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bar.Location = New System.Drawing.Point(2, 2)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(814, 6)
        Me.bar.TabIndex = 0
        '
        'Panel_Ara
        '
        Me.Panel_Ara.Controls.Add(Me.Label5)
        Me.Panel_Ara.Controls.Add(Me.Label4)
        Me.Panel_Ara.Controls.Add(Me.SimpleButton3)
        Me.Panel_Ara.Controls.Add(Me.sec_kriter)
        Me.Panel_Ara.Controls.Add(Me.txt_ara)
        Me.Panel_Ara.Controls.Add(Me.lbl_ara)
        Me.Panel_Ara.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Ara.Location = New System.Drawing.Point(0, 163)
        Me.Panel_Ara.Name = "Panel_Ara"
        Me.Panel_Ara.Size = New System.Drawing.Size(818, 32)
        Me.Panel_Ara.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Location = New System.Drawing.Point(809, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(7, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(370, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(7, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "*"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(300, 7)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(70, 20)
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.Location = New System.Drawing.Point(225, 7)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 10
        '
        'txt_ara
        '
        Me.txt_ara.Location = New System.Drawing.Point(27, 7)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Red
        Me.txt_ara.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ara.Properties.MaxLength = 30
        Me.txt_ara.Size = New System.Drawing.Size(198, 20)
        Me.txt_ara.TabIndex = 9
        '
        'lbl_ara
        '
        Me.lbl_ara.Location = New System.Drawing.Point(3, 8)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(6, 13)
        Me.lbl_ara.TabIndex = 8
        Me.lbl_ara.Text = "*"
        '
        'ds_detay
        '
        Me.ds_detay.DataSetName = "NewDataSet"
        Me.ds_detay.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_detay.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "IND"
        Me.DataColumn36.DataType = GetType(Long)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "TARIH"
        Me.DataColumn37.DataType = GetType(Date)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "FISNO"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "FIRMAKODU"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "ADI"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "SOYADI"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "DEPONO"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "STOKKODU"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "MALINCINSI"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "BARKOD"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "RENK"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "MIKTAR"
        Me.DataColumn47.DataType = GetType(Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "MODEL"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "IZAHAT"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "SATICI"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "KASIYER"
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.btn_FisIptal, Me.btn_SatirEkle, Me.BarButtonItem6, Me.btn_SatirSil, Me.BarButtonItem8, Me.BarSubItem4, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarSubItem5, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarSubItem6, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.btn_SatirEkleTransfer, Me.btn_SatirEkleAlis, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.BarButtonItem32, Me.BarButtonItem33, Me.btn_SatirEklePaket, Me.BarButtonItem35, Me.BarButtonItem36, Me.BarButtonItem37, Me.BarButtonItem38, Me.BarButtonItem39, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem7, Me.BarSubItem7, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem34, Me.BarButtonItem40, Me.BarButtonItem41, Me.BarButtonItem42, Me.BarButtonItem43})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 57
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem39), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem42, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FisIptal, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem39
        '
        Me.BarButtonItem39.Caption = "Dosyadan Oku"
        Me.BarButtonItem39.Id = 44
        Me.BarButtonItem39.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T))
        Me.BarButtonItem39.Name = "BarButtonItem39"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kaydet Yeni Belge"
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem42
        '
        Me.BarButtonItem42.Caption = "Belge Kopyala"
        Me.BarButtonItem42.Id = 55
        Me.BarButtonItem42.Name = "BarButtonItem42"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Belge Dizayn"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Belge Önizle"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Belge Yazdýr"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Belgeyi Direkt Yazdýr"
        Me.BarButtonItem22.Id = 27
        Me.BarButtonItem22.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'btn_FisIptal
        '
        Me.btn_FisIptal.Caption = "Belgeyi Ýptal Et"
        Me.btn_FisIptal.Id = 6
        Me.btn_FisIptal.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.btn_FisIptal.Name = "btn_FisIptal"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Satýr"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirEkle), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirEkleTransfer), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirEkleAlis), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirEklePaket), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirSil), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem26, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem43)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'btn_SatirEkle
        '
        Me.btn_SatirEkle.Caption = "Satýr Ekle"
        Me.btn_SatirEkle.Id = 7
        Me.btn_SatirEkle.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.btn_SatirEkle.Name = "btn_SatirEkle"
        '
        'btn_SatirEkleTransfer
        '
        Me.btn_SatirEkleTransfer.Caption = "Satýr Ekle Transfer Fiþlerinden"
        Me.btn_SatirEkleTransfer.Id = 32
        Me.btn_SatirEkleTransfer.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Insert))
        Me.btn_SatirEkleTransfer.Name = "btn_SatirEkleTransfer"
        '
        'btn_SatirEkleAlis
        '
        Me.btn_SatirEkleAlis.Caption = "Satýr Ekle Alýþ Faturalarýndan"
        Me.btn_SatirEkleAlis.Id = 33
        Me.btn_SatirEkleAlis.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Insert))
        Me.btn_SatirEkleAlis.Name = "btn_SatirEkleAlis"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Satýr Ekle Satýþ Faturalarýndan"
        Me.BarButtonItem4.Id = 45
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'btn_SatirEklePaket
        '
        Me.btn_SatirEklePaket.Caption = "Satýr Ekle Paket Aktarýmýndan"
        Me.btn_SatirEklePaket.Id = 39
        Me.btn_SatirEklePaket.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Insert))
        Me.btn_SatirEklePaket.Name = "btn_SatirEklePaket"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Düzelt"
        Me.BarButtonItem6.Id = 8
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'btn_SatirSil
        '
        Me.btn_SatirSil.Caption = "Satýr Sil"
        Me.btn_SatirSil.Id = 9
        Me.btn_SatirSil.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.btn_SatirSil.Name = "btn_SatirSil"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Envanter Analizi"
        Me.BarButtonItem16.Id = 21
        Me.BarButtonItem16.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Model Envanter Analizi"
        Me.BarButtonItem17.Id = 22
        Me.BarButtonItem17.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Barkod Okut"
        Me.BarButtonItem24.Id = 29
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Satýrlarý Yenile"
        Me.BarButtonItem26.Id = 31
        Me.BarButtonItem26.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem43
        '
        Me.BarButtonItem43.Caption = "Bekleyenleri Görüntüle"
        Me.BarButtonItem43.Id = 56
        Me.BarButtonItem43.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B))
        Me.BarButtonItem43.Name = "BarButtonItem43"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Etiket Onayla"
        Me.BarSubItem4.Id = 11
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21, True)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Etiket Önizle"
        Me.BarButtonItem18.Id = 23
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Etiket Dizayn"
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Etiket Yazdýr"
        Me.BarButtonItem20.Id = 25
        Me.BarButtonItem20.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Etiketleri Direkt Yazdýr"
        Me.BarButtonItem21.Id = 26
        Me.BarButtonItem21.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2))
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Görünüm"
        Me.BarSubItem5.Id = 15
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem31, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem38)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Baþlýk"
        Me.BarButtonItem12.Id = 16
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Hareketler"
        Me.BarButtonItem13.Id = 17
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "Görünümü Yazdýr"
        Me.BarButtonItem31.Id = 36
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarButtonItem38
        '
        Me.BarButtonItem38.Caption = "Görünümü Kaydet"
        Me.BarButtonItem38.Id = 43
        Me.BarButtonItem38.Name = "BarButtonItem38"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Araçlar"
        Me.BarSubItem6.Id = 19
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem32), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem33, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem37), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem35, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Hesap Makinesi"
        Me.BarButtonItem15.Id = 20
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Tamamla"
        Me.BarButtonItem23.Id = 28
        Me.BarButtonItem23.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Stok Bak"
        Me.BarButtonItem25.Id = 30
        Me.BarButtonItem25.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Entegre Et"
        Me.BarButtonItem29.Id = 34
        Me.BarButtonItem29.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Entegrasyonu Kaldýr"
        Me.BarButtonItem30.Id = 35
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Dot Matrix Onayý"
        Me.BarButtonItem32.Id = 37
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem33
        '
        Me.BarButtonItem33.Caption = "Stok Mevcutlarý ve Bekleyenleri"
        Me.BarButtonItem33.Id = 38
        Me.BarButtonItem33.Name = "BarButtonItem33"
        '
        'BarButtonItem37
        '
        Me.BarButtonItem37.Caption = "Satýþ Takip"
        Me.BarButtonItem37.Id = 42
        Me.BarButtonItem37.Name = "BarButtonItem37"
        '
        'BarButtonItem35
        '
        Me.BarButtonItem35.Caption = "Satýrlarda Ara"
        Me.BarButtonItem35.Id = 40
        Me.BarButtonItem35.Name = "BarButtonItem35"
        '
        'BarButtonItem36
        '
        Me.BarButtonItem36.Caption = "Satýrlarý Birleþtir"
        Me.BarButtonItem36.Id = 41
        Me.BarButtonItem36.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
        Me.BarButtonItem36.Name = "BarButtonItem36"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Transferler ile Karþýlaþtýr"
        Me.BarButtonItem5.Id = 46
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Transfer Entegre Fiþini Göster"
        Me.BarButtonItem7.Id = 47
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "Ýþlemler"
        Me.BarSubItem7.Id = 48
        Me.BarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem41), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem34), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem40)})
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarButtonItem41
        '
        Me.BarButtonItem41.Caption = "Sýnýf Tanýmla"
        Me.BarButtonItem41.Id = 54
        Me.BarButtonItem41.Name = "BarButtonItem41"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Fiyat Tanýmla"
        Me.BarButtonItem28.Id = 50
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarButtonItem34
        '
        Me.BarButtonItem34.Caption = "Kdv Tanýmla"
        Me.BarButtonItem34.Id = 51
        Me.BarButtonItem34.Name = "BarButtonItem34"
        '
        'BarButtonItem40
        '
        Me.BarButtonItem40.Caption = "Stoklarý Sil"
        Me.BarButtonItem40.Id = 52
        Me.BarButtonItem40.Name = "BarButtonItem40"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 476)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 454)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 454)
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "deneme"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Bilgileri Güncelle"
        Me.BarButtonItem9.Id = 12
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Stok Maliyetlerini Deðiþtir"
        Me.BarButtonItem10.Id = 13
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Stok Fiyatlarýný Deðiþtir"
        Me.BarButtonItem11.Id = 14
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "BarButtonItem14"
        Me.BarButtonItem14.Id = 18
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Sýnýf Tanýmla"
        Me.BarButtonItem27.Id = 49
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'ds_belgetipi
        '
        Me.ds_belgetipi.DataSetName = "NewDataSet"
        Me.ds_belgetipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_belgetipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.printlink3})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.Vgrid_baslik
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Me.printlink3
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink3
        '
        '
        '
        '
        Me.printlink3.ImageCollection.ImageStream = CType(resources.GetObject("printlink3.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink3.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        Me.printlink3.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink3.Owner = Nothing
        Me.printlink3.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Talep Emirleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Talep Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink3.PrintingSystem = Me.ps
        Me.printlink3.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.GridControl1
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.Owner = Me.printlink3
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'frm_stok_etikettalep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 498)
        Me.Controls.Add(Me.Panel_hareketler)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.Panel_toplamlar)
        Me.Controls.Add(Me.Panel_baslik)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_etikettalep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Talep Formu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_baslik.ResumeLayout(False)
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_sonuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tdepo_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplamlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplamlar.ResumeLayout(False)
        CType(Me.Panel_satis_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satis_info.ResumeLayout(False)
        Me.Panel_satis_info.PerformLayout()
        CType(Me.Panel_depo_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_depo_info.ResumeLayout(False)
        Me.Panel_depo_info.PerformLayout()
        CType(Me.VGrid_depo_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplam.ResumeLayout(False)
        Me.Panel_toplam.PerformLayout()
        CType(Me.VGrid_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_hareketler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hareketler.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_etiket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyattipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sBirimCinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_oran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelstatus.ResumeLayout(False)
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Ara.ResumeLayout(False)
        Me.Panel_Ara.PerformLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean
    Public connection
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Public kullaniciNo
    Public kasiyer
    Public kasiyerno
    Public yeniYetki As Boolean = False
    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    'Dim cmd As New OleDb.OleDbCommand
    'Dim con As New OleDb.OleDbConnection
    'Dim adapter As New OleDb.OleDbDataAdapter
    Public belgeind As Int64
    Public miktar As Decimal = 0
    Public detay_miktar As Decimal = 0
    Dim sAraKriter As String = ""
    Dim depokodu As String
    Dim dr As DataRow
    Dim mevcut As Decimal = 0
    Public x
    Dim okut As Boolean = False
    Dim ds_stok As DataSet
    Public belgetipi As Integer
    Dim ds_satici As DataSet
    Dim ds_alislar As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_satir_firma As DataSet
    Public fistipi As String
    Public tarih As DateTime
    Public firmaID As String
    Public fisno As String
    Public ngiriscikis As String
    Dim ds_stok_fisi As DataSet
    Dim ds_stok_barkod As DataSet
    Dim ds_stok_sinif As DataSet
    Dim ds_firma As DataSet
    Dim ds_renk As DataSet
    Dim listbox1 As New ListBox
    'Dim bTransferEnvanterKontrol As Boolean = False
    Dim sorgu_txt_hareket As String = ""
    Dim bImport As Boolean = False
    Dim bIFiyati As Decimal = 0
    Dim bITutari As Decimal = 0
    Dim bImport_Fiyat As Boolean = False
    Dim bImport_Tutari As Boolean = False
    Dim nFontSize As Decimal = 8.25
    Public bSayim As Boolean = False
    Public sStokAciklama As String = ""
    Public sStokKonum As String = ""
    Public sStokKriter As String = "Baþlar"
    Dim bKilitli As Boolean = False
    Public bKilitliMi As Boolean = False
    Private Sub frm_stok_etikettalep_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("Talep").SetValue("Kriter", sec_kriter.Text)
        Try
            tbFisKilit_sil(belgeind, belgetipi, kullanici)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frm_stok_paket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sec_kriter.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("Perakende").OpenSubKey("Talep").GetValue("Kriter").ToString
        Catch ex As Exception
            sec_kriter.Text = "Baþlar"
        End Try
        'Try
        '    bTransferEnvanterKontrol = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bTransferEnvanterKontrol").ToString
        'Catch ex As Exception
        '    bTransferEnvanterKontrol = False
        'End Try
        Try
            bTransferTeslimatYok = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bTransferTeslimatYok").ToString
        Catch ex As Exception
            bTransferTeslimatYok = False
        End Try
        BarButtonItem8.Enabled = yeniYetki
        belgetipleri()
        baslik()
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        Try
            'gorunum_yukle()
        Catch ex As Exception
        End Try
        Try
            dataload_hareket()
        Catch ex As Exception
        End Try
        Timer1.Enabled = True
        'connection = connection
        If belgetipi = 2 Then
            fis_resmi_kayit_kontrol(True)
        ElseIf belgetipi = 0 Then
            If dr_baslik("SONUC") = "Sipariþ Talebi..." Then
                siparis_kayit_kontrol(True)
            End If
        End If
        listbox1.Items.Add("D001")
        listbox1.Items.Add("D002")
        listbox1.Items.Add("D003")
        listbox1.Items.Add("D004")
        listbox1.Items.Add("D005")
        listbox1.Items.Add("D006")
        listbox1.Items.Add("D007")
        listbox1.Items.Add("D008")
        listbox1.Items.Add("D009")
        listbox1.Items.Add("D010")
        listbox1.Items.Add("D011")
        listbox1.Items.Add("D012")
        listbox1.Items.Add("D013")
        listbox1.Items.Add("D014")
        listbox1.Items.Add("D015")
        listbox1.Items.Add("D016")
        listbox1.Items.Add("D017")
        listbox1.Items.Add("D018")
        listbox1.Items.Add("D019")
        listbox1.Items.Add("D020")
        listbox1.Items.Add("D021")
        listbox1.Items.Add("D022")
        listbox1.Items.Add("D023")
        listbox1.Items.Add("D024")
        listbox1.Items.Add("D025")
        listbox1.Items.Add("D026")
        listbox1.Items.Add("D027")
        listbox1.Items.Add("D028")
        listbox1.Items.Add("D029")
        listbox1.Items.Add("D030")
        listbox1.Items.Add("D031")
        listbox1.Items.Add("D032")
        listbox1.Items.Add("D033")
        listbox1.Items.Add("D034")
        listbox1.Items.Add("D035")
        listbox1.Items.Add("D036")
        listbox1.Items.Add("D037")
        listbox1.Items.Add("D038")
        listbox1.Items.Add("D039")
        listbox1.Items.Add("D040")
        listbox1.Items.Add("D041")
        listbox1.Items.Add("D042")
        listbox1.Items.Add("D043")
        listbox1.Items.Add("D044")
        listbox1.Items.Add("D045")
        listbox1.Items.Add("D046")
        listbox1.Items.Add("D047")
        listbox1.Items.Add("D048")
        listbox1.Items.Add("D049")
        listbox1.Items.Add("D050")
        
        If kullanici > 3 Then
            rowTARIH.Properties.ReadOnly = True
            rowbKilitli.Properties.ReadOnly = True
        Else
            rowTARIH.Properties.ReadOnly = False
            rowbKilitli.Properties.ReadOnly = False
        End If
        If dr_baslik("bKilitli") = True Or bKilitli = True Or bKilitliMi = True Then
            GridView1.OptionsBehavior.Editable = False
            Menu_DegerYay.Enabled = False
            Menu_SatirEkle.Enabled = False
            Menu_SatirEkleDegisenler.Enabled = False
            Menu_SatirEkleEnvanterli.Enabled = False
            Menu_SatirEkleYeniler.Enabled = False
            Menu_SatirSil.Enabled = False
            btn_FisIptal.Enabled = False
            Menu_SatirEkle.Enabled = False
            Menu_SatirEkleDegisenler.Enabled = False
            Menu_SatirEkleEnvanterli.Enabled = False
            Menu_SatirEkleYeniler.Enabled = False
            Menu_SatirSil.Enabled = False
            Panel_Ara.Enabled = False
            Me.Text += " (Salt Okunur) "
            If bKilitli = True Then
                Me.Text += " (Belge Kullanimda)"
            End If
        End If
        If Trim(sStokAciklama) <> "" Then
            GridView1.ClearColumnsFilter()
            If sStokKonum = "Kod" Then
                GridView1.Columns("STOKKODU").FilterInfo = New ColumnFilterInfo("[STOKKODU] " & sorgu_kriter_string(sStokAciklama, sStokKriter) & "")
            ElseIf sStokKonum = "Ad" Then
                GridView1.Columns("MALINCINSI").FilterInfo = New ColumnFilterInfo("[MALINCINSI] " & sorgu_kriter_string(sStokAciklama, sStokKriter) & "")
            ElseIf sStokKonum = "Barkod" Then
                GridView1.Columns("BARCODE").FilterInfo = New ColumnFilterInfo("[BARCODE] " & sorgu_kriter_string(sStokAciklama, sStokKriter) & "")
            End If
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
        Else
            GridView1.ClearColumnsFilter()
        End If
        If belgetipi = 2 Then
            If yetki_kontrol1(kullanici, "Frm_Transfer_Tarih_Degistir") = True Then
                rowTARIH.Enabled = True
            Else
                rowTARIH.Enabled = False
            End If
        Else
            rowTARIH.Enabled = True
        End If


    End Sub
    Private Sub loaded()
        dataload_baslik()
        dataload_harekets()
        GridControl1.Focus()
        GridControl1.Select()
        sec_depo_baslik.DataSource = sorgu_s(sorgu_query("SELECT sDepo AS DEPOKODU, sAciklama AS DEPOADI FROM tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        sec_tdepo_baslik.DataSource = sorgu_s(sorgu_query("SELECT sDepo AS DEPOKODU, sAciklama AS DEPOADI FROM tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        sec_depo_hareket.DataSource = sorgu_s(sorgu_query("SELECT sDepo AS DEPOKODU, sAciklama AS DEPOADI FROM tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If belgetipi <> 0 Then
            colETIKET.Visible = False
            rowKOD1.Properties.Caption = "Satýcý"
            rowKOD5.Properties.Caption = "Döküm?"
            rowACIKLAMA.Properties.Caption = "Müþteri"
        End If
        If belgetipi = 2 Then
            'colDEPO.Visible =False 
            rowDEPO.Properties.Caption = "Çýkýþ Depo"
            rowTDEPO.Properties.Caption = "Giriþ Depo"
            rowTDEPO.Visible = True
        End If
        If belgetipi = 0 Then
            Me.Text = "Ürün Bazlý Talep Formu"
            Me.Vgrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(0, Byte))
        ElseIf belgetipi = 1 Then
            Me.Text = "Ürün Talep Formu"
            Vgrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        ElseIf belgetipi = 2 Then
            colFIYAT1.Visible = False
            colFIYAT2.Visible = False
            colFIYAT3.Visible = False
            colFIYAT4.Visible = False
            colFIYAT5.Visible = False
            colsFiyatTipi.Visible = False
            rowKOD1.Properties.Caption = "Teslim Eden"
            rowACIKLAMA.Properties.Caption = "Teslim Alan"
            'Me.Text = "Transfer Talep Formu"
            Me.Text = "Transfer Formu"
            'Me.Vgrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
            Me.Vgrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Crimson()
        End If
        If bSayim = True Then
            Me.Text = "Sayým Fiþi"
        End If
        If Trim(sDatabaseGenel) = "UGURLU" Then
            Dim dr As DataRow
            For Each dr In ds_baslik.Tables(0).Rows
                If Kod3ZorunluMu(Trim(dr("DEPO").ToString())) = True Then
                    If Trim(dr("KOD3").ToString()).Length < 1 Then
                        txt_ara.Enabled = False
                        SimpleButton3.Enabled = False
                        GridControl1.ContextMenu = Nothing
                        btn_SatirEkle.Enabled = False
                        btn_SatirEkleTransfer.Enabled = False
                        btn_SatirEkleAlis.Enabled = False
                        BarButtonItem4.Enabled = False
                        btn_SatirEklePaket.Enabled = False
                        BarButtonItem6.Enabled = False
                        btn_SatirSil.Enabled = False
                        BarButtonItem24.Enabled = False
                        MessageBox.Show("Lütfen 3.ÖzelKod alanýna belge numarasýný giriniz!")
                    Else
                        txt_ara.Enabled = True
                        SimpleButton3.Enabled = True
                        GridControl1.ContextMenu = kisayol_hareket
                        btn_SatirEkle.Enabled = True
                        btn_SatirEkleTransfer.Enabled = True
                        btn_SatirEkleAlis.Enabled = True
                        BarButtonItem4.Enabled = True
                        btn_SatirEklePaket.Enabled = True
                        BarButtonItem6.Enabled = True
                        btn_SatirSil.Enabled = True
                        BarButtonItem24.Enabled = True
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub gorunum_kaydet()
        If sStokAciklama <> "" Then
            GridView1.ClearColumnsFilter()
        End If
        'Vgrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\TALEP\" & belgetipi & "\BASLIK\" & Me.Name.ToString & "")
        'VGrid_toplam.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\TALEP\" & belgetipi & "\TOPLAM\" & Me.Name.ToString & "")
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\TALEP\" & belgetipi & "\HAREKET\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        Dim row As Object
        For Each row In Vgrid_baslik.Rows
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
        For Each row In categoryAçýklama.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        'Vgrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\TALEP\" & belgetipi & "\BASLIK\" & Me.Name.ToString & "")
        'VGrid_iskonto.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\FATURA\" & dr_baslik("sFisTipi") & "\ISKONTO\" & Me.Name.ToString & "")
        'VGrid_masraf.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\FATURA\" & dr_baslik("sFisTipi") & "\MASRAF\" & Me.Name.ToString & "")
        VGrid_toplam.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\TALEP\" & belgetipi & "\TOPLAM\" & Me.Name.ToString & "")
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\TALEP\" & belgetipi & "\HAREKET\" & Me.Name.ToString & "")

    End Sub
    Private Sub dataload_baslik()
        ds_baslik.Tables(0).Clear()
        ds_baslik = sorgu_baslik("")
        Vgrid_baslik.DataSource = ds_baslik
        Vgrid_baslik.DataMember = "BASLIK"
        Vgrid_baslik.Refresh()
        dr_baslik = ds_baslik.Tables(0).Rows(0)
    End Sub
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT BASLIK.*, DEPO.sAciklama AS sDepoAciklama, TDEPO.sAciklama AS sTDepoAciklama FROM ASTOKETIKETTALEPBASLIK BASLIK LEFT OUTER JOIN tbDepo TDEPO ON BASLIK.TDEPO = TDEPO.sDepo LEFT OUTER JOIN tbDepo DEPO ON BASLIK.DEPO = DEPO.sDepo WHERE BASLIK.IND =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_harekets(Optional ByVal bSelect As Boolean = True, Optional ByVal bFiyatlar As Boolean = False, Optional ByVal bekleyenVarMi As Boolean = False)
        colBekleyen.Visible = bekleyenVarMi
        ds_hareket = sorgu_harekets(bFiyatlar, bekleyenVarMi)
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        If bSelect = True Then
            GridControl1.Select()
        End If
        GridControl1.Refresh()
    End Sub
    Private Function sorgu_harekets(ByVal bFiyatlar As Boolean, Optional ByVal bekleyenVarMi As Boolean = False) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     *,dbo.ROUNDYTL(MIKTAR / lBirimMiktar) AS lMiktar,(SELECT     sBirimCinsi1 FROM          tbStok WHERE      nStokID = ASTOKETIKETTALEPDETAY.STOKNO) AS sBirimCinsi1 FROM         ASTOKETIKETTALEPDETAY WHERE EVRAKNO =" & belgeind & " ORDER BY IND")
        If bFiyatlar = False Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT HAREKET.*, tbStok.nFiyatlandirma,dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.IND")
            If bekleyenVarMi = True Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT (SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = HAREKET.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) and (hareket1.dteFisTarihi <= '31/12/2078') AND (depo.sDepo = HAREKET.DEPO)) TT) as Bekleyen, ISNULL((Select SUM(MIKTAR) From ASTOKETIKETTALEPDETAYDOGRULAMA dog Where (dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = HAREKET.EVRAKNO)), 0) as DogrulamaAdet, HAREKET.*, tbStok.nFiyatlandirma,dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.MALINCINSI")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 as Bekleyen, ISNULL((Select SUM(MIKTAR) From ASTOKETIKETTALEPDETAYDOGRULAMA dog Where (dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = HAREKET.EVRAKNO)), 0) as DogrulamaAdet, HAREKET.*, tbStok.nFiyatlandirma,dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.MALINCINSI")
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 as Bekleyen, ISNULL((Select SUM(MIKTAR) From ASTOKETIKETTALEPDETAYDOGRULAMA dog Where(dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = HAREKET.EVRAKNO)), 0) as DogrulamaAdet, HAREKET.STOKKODU, tbStok.nFiyatlandirma,dbo.ROUNDYTL(SUM(HAREKET.MIKTAR) ) AS lMiktar,tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " Group by STOKKODU,EVRAKNO,STOKNO, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, ETIKET, ACIKLAMA, DEPO, MIKTAR, sFiyatTipi, FIYAT1, FIYAT2, FIYAT3, sBirimCinsi, lBirimMiktar, nBirimCarpan, FIYAT4, FIYAT5,nFiyatlandirma,sBirimCinsi1,sBirimCinsi2,nStokID")


            End If
        ElseIf bFiyatlar = True Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT HAREKET.*, tbStok.nFiyatlandirma, dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.IND")
            If bekleyenVarMi = True Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT (SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = HAREKET.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) and (hareket1.dteFisTarihi <= '31/12/2078') AND (depo.sDepo = HAREKET.DEPO)) TT) as Bekleyen, ISNULL((Select SUM(MIKTAR) From ASTOKETIKETTALEPDETAYDOGRULAMA dog Where (dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = HAREKET.EVRAKNO)), 0) as DogrulamaAdet, HAREKET.*, tbStok.nFiyatlandirma, dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.MALINCINSI")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 as Bekleyen, ISNULL((Select SUM(MIKTAR) From ASTOKETIKETTALEPDETAYDOGRULAMA dog Where (dog.STOKNO = HAREKET.STOKNO) AND (dog.EVRAKNO = HAREKET.EVRAKNO)), 0) as DogrulamaAdet, HAREKET.*, tbStok.nFiyatlandirma, dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.MALINCINSI")
            End If
        End If
        'ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFIYAT1, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFIYAT2, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFIYAT3, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYATM, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYATA
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function baslik_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal depo As String, ByVal tdepo As String, ByVal belgetipi As Integer, ByVal aktif As Byte, ByVal transfer As Byte, ByVal bKilitli As Byte, ByVal KAYITTARIHI As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO ASTOKETIKETTALEPBASLIK (TARIH, BELGENO, ACIKLAMA, KOD1, KOD2, KOD3, KOD4, KOD5, SONUC,DEPO,TDEPO,BELGETIPI,AKTIF,TRANSFER,bKilitli,KAYITTARIHI,sKullanici,sKullaniciUpdate) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & ACIKLAMA & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & SONUC & "','" & depo & "','" & tdepo & "'," & belgetipi & "," & aktif & "," & transfer & "," & bKilitli & ",'" & KAYITTARIHI & "', 'Kodu: " & kullaniciKodu & ", Adý: " & kullaniciadi & ", Kasiyer: " & kasiyer & ", Rumuz: " & kasiyerno & "', '')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub baslik_teslim_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal depo As String, ByVal tdepo As String, ByVal belgetipi As Integer, ByVal aktif As Byte, ByVal transfer As Byte, ByVal bKilitli As Byte, ByVal KAYITTARIHI As DateTime, ByVal REFIND As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO ASTOKETIKETTESLIMBASLIK (TARIH, BELGENO, ACIKLAMA, KOD1, KOD2, KOD3, KOD4, KOD5, SONUC, DEPO, TDEPO, BELGETIPI, AKTIF, TRANSFER, bKilitli, KAYITTARIHI, REFIND, sKullanici, sKullaniciUpdate) VALUES ('" & TARIH & "', '" & BELGENO & "', '" & ACIKLAMA & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & SONUC & "', '" & depo & "', '" & tdepo & "', " & belgetipi & ", " & aktif & ", " & transfer & ", " & bKilitli & ", '" & KAYITTARIHI & "', '" & REFIND & "', 'Kodu: " & kullaniciKodu & ", Adý: " & kullaniciadi & ", Kasiyer: " & kasiyer & ", Rumuz: " & kasiyerno & "', '')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal RENK As String, ByVal BEDEN As String, ByVal MODEL As String, ByVal ETIKET As String, ByVal ACIKLAMA As String, ByVal DEPO As String, ByVal MIKTAR As Decimal, ByVal sFiyatTipi As String, ByVal FIYAT1 As Decimal, ByVal FIYAT2 As Decimal, ByVal FIYAT3 As Decimal, ByVal FIYAT4 As Decimal, ByVal FIYAT5 As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO ASTOKETIKETTALEPDETAY(EVRAKNO, STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, ETIKET, ACIKLAMA, DEPO, MIKTAR, sFiyatTipi, FIYAT1, FIYAT2, FIYAT3, FIYAT4, FIYAT5, sBirimCinsi, lBirimMiktar) VALUES (" & EVRAKNO & " , " & STOKNO & " , '" & STOKKODU & "', '" & MALINCINSI & "', '" & BARCODE & "', '" & RENK & "', '" & BEDEN & "', '" & MODEL & "', '" & ETIKET & "', '" & ACIKLAMA & "' , '" & DEPO & "', " & MIKTAR & ",'" & sFiyatTipi & "', " & FIYAT1 & " , " & FIYAT2 & " , " & FIYAT3 & ", " & FIYAT4 & ", " & FIYAT5 & ", '" & sBirimCinsi & "'," & lBirimMiktar & " )")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub baslik_kaydet_degistir(ByVal evrakno As Int64, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal depo As String, ByVal tdepo As String, ByVal aktif As Byte, ByVal transfer As Byte, ByVal HESAPNO As Int64, ByVal HESAPADI As String, ByVal bKilitli As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ASTOKETIKETTALEPBASLIK SET TARIH = '" & TARIH & "', BELGENO = '" & BELGENO & "', ACIKLAMA = '" & ACIKLAMA & "', KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', KOD3 = '" & KOD3 & "', KOD4 = '" & KOD4 & "', KOD5 = '" & KOD5 & "', SONUC = '" & SONUC & "', DEPO = '" & depo & "', TDEPO = '" & tdepo & "', AKTIF = " & aktif & ", TRANSFER = " & transfer & ", HESAPNO = " & HESAPNO & ", HESAPADI = '" & HESAPADI & "', bKilitli = " & bKilitli & ", sKullaniciUpdate = 'Kodu: " & kullaniciKodu & ", Adý: " & kullaniciadi & ", Kasiyer: " & kasiyer & ", Rumuz: " & kasiyerno & "' WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub baslik_teslim_kaydet_degistir(ByVal REFIND As String, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal depo As String, ByVal tdepo As String, ByVal aktif As Byte, ByVal transfer As Byte, ByVal HESAPNO As Int64, ByVal HESAPADI As String, ByVal bKilitli As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ASTOKETIKETTESLIMBASLIK SET TARIH = '" & TARIH & "', BELGENO = '" & BELGENO & "', ACIKLAMA = '" & ACIKLAMA & "', KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', KOD3 = '" & KOD3 & "', KOD4 = '" & KOD4 & "', KOD5 = '" & KOD5 & "', SONUC = '" & SONUC & "', DEPO = '" & depo & "', TDEPO = '" & tdepo & "', AKTIF = " & aktif & ", TRANSFER = " & transfer & ", HESAPNO = " & HESAPNO & ", HESAPADI = '" & HESAPADI & "', bKilitli = " & bKilitli & ", sKullaniciUpdate = 'Kodu: " & kullaniciKodu & ", Adý: " & kullaniciadi & ", Kasiyer: " & kasiyer & ", Rumuz: " & kasiyerno & "' WHERE REFIND = '" & REFIND & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal RENK As String, ByVal BEDEN As String, ByVal MODEL As String, ByVal ETIKET As String, ByVal ACIKLAMA As String, ByVal DEPO As String, ByVal MIKTAR As Decimal, ByVal sFiyatTipi As String, ByVal FIYAT1 As Decimal, ByVal FIYAT2 As Decimal, ByVal FIYAT3 As Decimal, ByVal FIYAT4 As Decimal, ByVal FIYAT5 As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ASTOKETIKETTALEPDETAY  SET EVRAKNO = " & EVRAKNO & " , STOKNO = " & STOKNO & " , STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "' , BARCODE = '" & BARCODE & "' , RENK = '" & RENK & "',  BEDEN = '" & BEDEN & "', MODEL = '" & MODEL & "', ETIKET = '" & ETIKET & "' , ACIKLAMA = '" & ACIKLAMA & "' , DEPO = '" & DEPO & "' , MIKTAR = " & MIKTAR & " , sFiyatTipi = '" & sFiyatTipi & "',FIYAT1 = " & FIYAT1 & " , FIYAT2 = " & FIYAT2 & ", FIYAT3 = " & FIYAT3 & ", FIYAT4 = " & FIYAT4 & ", FIYAT5 = " & FIYAT5 & ", sBirimCinsi ='" & sBirimCinsi & "' ,lBirimMiktar =" & lBirimMiktar & "  WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_miktar_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal Miktar As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    ASTOKETIKETTALEPDETAY  SET              MIKTAR = " & Miktar & ",lBirimMiktar =" & lBirimMiktar & ",sBirimCinsi ='" & sBirimCinsi & "'   WHERE IND = " & ind & " AND EVRAKNO = " & EVRAKNO & " ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub baslik_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM ASTOKETIKETTALEPBASLIK WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub entegrasyon_kaydet_sil(ByVal nStokFisiID As String, ByVal lTransferFisiID As String, ByVal dteFisTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID IN ('" & nStokFisiID & "', '" & lTransferFisiID & "')) AND sFisTipi = 'T' and dteFisTarihi = '" & dteFisTarihi & "' ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM tbStokFisiAciklamasi WHERE     (nStokFisiID IN ('" & nStokFisiID & "', '" & lTransferFisiID & "'))")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM tbStokFisiOdemePlani WHERE     (nStokFisiID IN ('" & nStokFisiID & "', '" & lTransferFisiID & "')) ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM tbStokFisiMaster WHERE     (nStokFisiID IN ('" & nStokFisiID & "', '" & lTransferFisiID & "')) and sFisTipi ='T' and dteFisTarihi = '" & dteFisTarihi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub entegrasyon_kaydet_sil_siparis(ByVal nSiparisTipi As Int64, ByVal nFirmaID As Int64, ByVal lSiparisNo As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kriter
        kriter = "WHERE     (lSiparisNo = " & lSiparisNo & ") AND (nSiparisTipi = " & nSiparisTipi & ") AND (nFirmaID = " & nFirmaID & ")"
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM tbSiparis " & kriter & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM tbSiparisAciklamasi " & kriter & " ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM ASTOKETIKETTALEPDETAY  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_satir_sil(ByVal IND As Int64, ByVal evrakno As Int64, ByVal STOKNO As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  DELETE FROM ASTOKETIKETTALEPDETAY  WHERE IND <> " & IND & " AND EVRAKNO = " & evrakno & " AND STOKNO = " & STOKNO & " ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub dataload_hareket()
        'ds_detay = sorgu_hareket(dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"))
        'If ds_detay.Tables(0).Rows.Count > 0 Then
        '    Dim miktar As Decimal = 0
        '    Dim dr As DataRow
        '    For Each dr In ds_detay.Tables(0).Rows
        '        miktar = miktar + dr("MIKTAR")
        '    Next
        '    detay_miktar = miktar
        '    If status = False Then
        '        Dim kontrol = sorgu_baslik_kontrol(dr_baslik("TARIH"), dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"), dr_baslik("DEPO"))
        '        If status = False Then
        '            If kontrol > 0 Then
        '                XtraMessageBox.Show(Sorgu_sDil("Bilgilerini Girmekte Olduðunuz Fiþ Önceden Teslim Edilmiþ... Lütfen Tekrar Deneyiniz...")
        '                If kontrol = 1 Then
        '                    If Trim(dr_baslik("IZAHAT").ToString) = "PF" Then
        '                        If XtraMessageBox.Show(Sorgu_sDil("Fiþi Açmak Ýster misiniz",sDil), MessageBoxButtons.YesNo,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
        '                            belgeind = sorgu_baslik_kontrol_kayitno(dr_baslik("TARIH"), dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"), dr_baslik("DEPO"))
        '                            belgetipleri()
        '                            baslik()
        '                            Try
        '                                loaded()
        '                            Catch ex As Exception
        '                            End Try
        '                            Try
        '                                'dataload_hareket()
        '                            Catch ex As Exception
        '                            End Try
        '                            Timer1.Enabled = True
        '                        End If
        '                    End If
        '                End If
        '            Else
        '                XtraMessageBox.Show(Sorgu_sDil("Toplam Teslim Edilecek Ürün Miktarý : " & FormatNumber(miktar, 0))
        '                'MsgBox(Sorgu_sDil("Toplam Teslim Edilecek Ürün Miktarý : " & FormatNumber(miktar, 0))
        '                dr_baslik("MIKTAR") = miktar
        '                dr_baslik("FIRMANO") = dr("FIRMANO")
        '                dr_baslik("ADI") = dr("ADI")
        '                dr_baslik("SOYADI") = dr("SOYADI")
        '                dr_baslik("FIRMAADI") = dr("ADI") & " " & dr("SOYADI")
        '                baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), dr_baslik("MIKTAR"), miktar)
        '                satir_ekle_stok(False)
        '            End If
        '        End If
        '    Else
        '    End If
        'End If
    End Sub
    Public Function sorgu_hareket(ByVal tarih As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String) As DataSet
        Dim kriter
        kriter = "WHERE (Hareket.dteFisTarihi = '" & tarih & "') AND (Musteri.lKodu = '" & firmakodu & "') AND (Hareket.lFisNo = " & fisno & ") AND (Hareket.sFisTipi = '" & izahat & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & "")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_baslik_kontrol(ByVal tarih As DateTime, ByVal fistarihi As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String, ByVal DEPO As String) As Int64
        Dim kriter
        'kriter = "WHERE (TARIH = '" & tarih & "') AND (FISTARIHI = '" & fistarihi & "') AND (FIRMAKODU = '" & firmakodu & "') AND (FISNO = '" & fisno & "') AND (IZAHAT = '" & izahat & "')AND (DEPO = '" & DEPO & "') "
        kriter = "WHERE (TARIH = '" & tarih & "') AND (FISTARIHI = '" & fistarihi & "') AND (FIRMAKODU = '" & firmakodu & "') AND (FISNO = '" & fisno & "') AND (IZAHAT = '" & izahat & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         ASTOKPAKETBASLIK " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_baslik_kontrol_kayitno(ByVal tarih As DateTime, ByVal fistarihi As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String, ByVal DEPO As String) As Int64
        Dim kriter
        'kriter = "WHERE (TARIH = '" & tarih & "') AND (FISTARIHI = '" & fistarihi & "') AND (FIRMAKODU = '" & firmakodu & "') AND (FISNO = '" & fisno & "') AND (IZAHAT = '" & izahat & "')AND (DEPO = '" & DEPO & "') "
        kriter = "WHERE (TARIH = '" & tarih & "') AND (FISTARIHI = '" & fistarihi & "') AND (FIRMAKODU = '" & firmakodu & "') AND (FISNO = '" & fisno & "') AND (IZAHAT = '" & izahat & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 IND  FROM         ASTOKPAKETBASLIK " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar()
        Return kayitsayisi
    End Function
    Private Sub baslik()
        If belgeind = 0 Then
            Dim dr As DataRow = ds_baslik.Tables(0).NewRow
            dr("TARIH") = Today
            Try
                dr("BELGENO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
            Catch ex As Exception
                dr("BELGENO") = "A-000001"
            End Try
            Try
                depokodu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
                If depokodu <> "True" Then
                    dr("DEPO") = depokodu
                    dr("TDEPO") = depokodu
                Else
                    dr("DEPO") = "1KAT"
                    dr("TDEPO") = "1KAT"
                End If
            Catch ex As Exception
                dr("DEPO") = "1KAT"
                dr("TDEPO") = "1KAT"
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", "True")
            End Try
            dr("KOD1") = ""
            dr("KOD2") = ""
            dr("KOD3") = ""
            dr("KOD4") = Microsoft.VisualBasic.Left(kasiyer, 50)
            dr("KOD5") = ""
            dr("ACIKLAMA") = ""
            dr("HESAPNO") = 0
            dr("HESAPADI") = ""
            dr("bKilitli") = 0
            If bSayim = False Then
                dr("SONUC") = "Bekliyor..."
            Else
                dr("SONUC") = "Sayým..."
                sec_baslik_sonuc.ReadOnly = True
            End If
            belgeind = baslik_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("SONUC"), dr("DEPO"), dr("TDEPO").ToString, belgetipi, 0, 0, 0, Now)
            baslik_teslim_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("SONUC"), dr("DEPO"), dr("TDEPO").ToString, belgetipi, 0, 0, 0, Now, belgeind)
            dr("IND") = belgeind
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = Nothing
            Try
                tbFisKilit_ekle(belgeind, belgetipi, kullanici, Now)
            Catch ex As Exception
                bKilitli = False
            End Try
        ElseIf belgeind <> 0 Then
            If sorgu_nKilit(belgeind, belgetipi, kullanici) = 0 Then
                bKilitli = False
                Try
                    tbFisKilit_ekle(belgeind, belgetipi, kullanici, Now)
                Catch ex As Exception
                    bKilitli = True
                End Try
            Else
                bKilitli = True
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub baslik_yeni()
        belgeind = 0
        ds_baslik.Tables(0).Clear()
        ds_detay.Tables(0).Clear()
        Vgrid_baslik.Enabled = True
        GridControl1.Enabled = True
        GridControl1.ContextMenu = kisayol_hareket
        BarSubItem3.Enabled = True
        txt_ara.Enabled = True
        btn_FisIptal.Enabled = True
        status = False
        If belgeind = 0 Then
            Dim dr As DataRow = ds_baslik.Tables(0).NewRow
            'dr("IZAHAT") = "K"
            Try
                depokodu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
                If depokodu <> "True" Then
                    dr("DEPO") = depokodu
                    dr("TDEPO") = depokodu
                Else
                    dr("DEPO") = "1KAT"
                    dr("TDEPO") = "1KAT"
                End If
            Catch ex As Exception
                dr("DEPO") = "1KAT"
                dr("TDEPO") = "1KAT"
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", "True")
            End Try
            dr("TARIH") = Today
            Try
                dr("BELGENO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
            Catch ex As Exception
                dr("BELGENO") = "A-000001"
            End Try
            dr("KOD1") = ""
            dr("KOD2") = ""
            dr("KOD3") = ""
            dr("KOD4") = Microsoft.VisualBasic.Left(kasiyer, 50)
            dr("KOD5") = ""
            dr("ACIKLAMA") = ""
            dr("HESAPNO") = 0
            dr("HESAPADI") = ""
            dr("bKilitli") = 0
            belgeind = baslik_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), "Bekliyor...", dr("DEPO"), dr("TDEPO").ToString, belgetipi, 0, 0, 0, Now)
            baslik_teslim_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), "Bekliyor...", dr("DEPO"), dr("TDEPO").ToString, belgetipi, 0, 0, 0, Now, belgeind)
            dr("IND") = belgeind
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = Nothing
            Try
                tbFisKilit_ekle(belgeind, belgetipi, kullanici, Now)
            Catch ex As Exception
                bKilitli = False
            End Try
        ElseIf belgeind <> 0 Then
            If sorgu_nKilit(belgeind, belgetipi, kullanici) = 0 Then
                bKilitli = False
                Try
                    tbFisKilit_ekle(belgeind, belgetipi, kullanici, Now)
                Catch ex As Exception
                    bKilitli = True
                End Try
            Else
                bKilitli = True
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Function belgeno_kontrol(ByVal belgeno As String, Optional ByVal islem As Integer = 0) As String
        Dim seri
        Dim no
        Dim evrak_no
        evrak_no = belgeno
        evrak_no = evrak_no.Replace(0, "")
        evrak_no = evrak_no.Replace(1, "")
        evrak_no = evrak_no.Replace(2, "")
        evrak_no = evrak_no.Replace(3, "")
        evrak_no = evrak_no.Replace(4, "")
        evrak_no = evrak_no.Replace(5, "")
        evrak_no = evrak_no.Replace(6, "")
        evrak_no = evrak_no.Replace(7, "")
        evrak_no = evrak_no.Replace(8, "")
        evrak_no = evrak_no.Replace(9, "")
        'txtbelgeseri.EditValue = evrak_no
        seri = evrak_no
        If evrak_no = "" Then
            seri = "A-"
        End If
        evrak_no = belgeno
        evrak_no = evrak_no.Replace("A", "")
        evrak_no = evrak_no.Replace("B", "")
        evrak_no = evrak_no.Replace("C", "")
        evrak_no = evrak_no.Replace("Ç", "")
        evrak_no = evrak_no.Replace("D", "")
        evrak_no = evrak_no.Replace("E", "")
        evrak_no = evrak_no.Replace("F", "")
        evrak_no = evrak_no.Replace("G", "")
        evrak_no = evrak_no.Replace("H", "")
        evrak_no = evrak_no.Replace("I", "")
        evrak_no = evrak_no.Replace("Ý", "")
        evrak_no = evrak_no.Replace("J", "")
        evrak_no = evrak_no.Replace("K", "")
        evrak_no = evrak_no.Replace("L", "")
        evrak_no = evrak_no.Replace("M", "")
        evrak_no = evrak_no.Replace("N", "")
        evrak_no = evrak_no.Replace("O", "")
        evrak_no = evrak_no.Replace("Ö", "")
        evrak_no = evrak_no.Replace("P", "")
        evrak_no = evrak_no.Replace("R", "")
        evrak_no = evrak_no.Replace("S", "")
        evrak_no = evrak_no.Replace("Þ", "")
        evrak_no = evrak_no.Replace("T", "")
        evrak_no = evrak_no.Replace("U", "")
        evrak_no = evrak_no.Replace("Ü", "")
        evrak_no = evrak_no.Replace("V", "")
        evrak_no = evrak_no.Replace("Y", "")
        evrak_no = evrak_no.Replace("Z", "")
        evrak_no = evrak_no.Replace("X", "")
        evrak_no = evrak_no.Replace("W", "")
        evrak_no = evrak_no.Replace("_", "")
        evrak_no = evrak_no.Replace("-", "")
        evrak_no = evrak_no.Replace("*", "")
        evrak_no = evrak_no.Replace("/", "")
        evrak_no = evrak_no.Replace("+", "")
        Try
            If islem = 0 Then
                no = CType(evrak_no, Integer) + 1
            Else
                no = CType(evrak_no, Integer)
            End If
            no = columnuzunlukinteger_sifir(no.ToString, 6)
            belgeno = seri + no.ToString
        Catch ex As Exception
            belgeno = seri + columnuzunlukinteger_sifir(1, 6)
        End Try
        Return belgeno
    End Function
    Private Function dataload_belgeno() As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim sonuc
        Try
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(BELGENO,'A-000001') AS BELGENO FROM    ASTOKETIKETTALEPBASLIK WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM    ASTOKETIKETTALEPBASLIK  WHERE  BELGENO LIKE 'A%')")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select ('A0' + convert(varchar, MAX(IND) + 1)) AS BELGENO from ASTOKETIKETTALEPBASLIK")
            sonuc = cmd.ExecuteScalar
            con.Close()
            If CStr(sonuc).ToString = "" Then
                sonuc = "A-000000"
            End If
        Catch ex As Exception
            sonuc = "A-000000"
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return sonuc
        sonuc = Nothing
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub belgetipleri()
        Dim dr1 As DataRow = ds_belgetipi.Tables(0).NewRow
        'dr1("IND") = "FA"
        'dr1("ACIKLAMA") = "Alýþ Faturasý"
        'ds_belgetipi.Tables(0).Rows.Add(dr1)
        'dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "K"
        dr1("ACIKLAMA") = "Kredili Satýþ"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "P"
        dr1("ACIKLAMA") = "Peþin Satýþ"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "PF"
        dr1("ACIKLAMA") = "Sonradan Teslim Onaylý"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkle.ItemClick
        If dr_baslik("IND") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            satir_ekle_stok(False)
            Timer1.Enabled = True
        ElseIf dr_baslik("IND") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Etiket Talep Föyü Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Function sorgu_s(ByVal query As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
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
    Private Function stok_kontrol(ByVal stokkodu As String) As Integer
        Dim dr As DataRow
        Dim sayi As Integer = 0
        For Each dr In ds_detay.Tables(0).Rows
            If dr("BARKOD") = stokkodu Then
                sayi = 1
            End If
        Next
        Return sayi
    End Function
    Private Sub satir_ekle_stok(ByVal yeni As Boolean, Optional ByVal ara As String = "", Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.mevcut = mevcut
        If Trim(ara.ToString) <> "" Then
            frm.gelismis = ara
            frm.qgelismis = "Baþlar"
            frm.status = True
        End If
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
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
                    If belgetipi = 2 Then
                        If bTransferEnvanterKontrol = False Then
                            stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
                        Else
                            stok_mevcut = 999999
                        End If
                        nSatir = sorgu_stok_varmi(dr1("nStokID"))
                    Else
                        nSatir = 0
                        stok_mevcut = 999999
                    End If
                    If miktarsec = True Then
                        If dr1("Mevcut") <> 0 Then
                            lMiktar = dr1("Mevcut")
                        Else
                            lMiktar = frm.mevcut
                        End If
                    Else
                        lMiktar = frm.mevcut
                    End If
                    If stok_mevcut >= lMiktar + nSatir Then
                        dr = ds_hareket.Tables(0).NewRow
                        dr("EVRAKNO") = belgeind
                        dr("STOKNO") = dr1("nStokId")
                        dr("STOKKODU") = Trim(dr1("sKodu").ToString)
                        dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                        dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("sBarkod").ToString), 20)
                        dr("MODEL") = Trim(dr1("sModel").ToString)
                        dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("sRenkAdi").ToString), 20)
                        dr("BEDEN") = Trim(dr1("sBeden").ToString)
                        Try
                            dr("FIYAT1") = CType(sorgu_sayi(dr1("PESIN"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT1") = 0
                        End Try
                        Try
                            dr("FIYAT2") = CType(sorgu_sayi(dr1("ALTIAY"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT2") = 0
                        End Try
                        Try
                            dr("FIYAT3") = CType(sorgu_sayi(dr1("ONAY"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT3") = 0
                        End Try
                        Try
                            dr("FIYAT4") = CType(sorgu_sayi(dr1("FIYAT4"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT4") = 0
                        End Try
                        Try
                            dr("FIYAT5") = CType(sorgu_sayi(dr1("FIYAT5"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT5") = 0
                        End Try
                        If miktarsec = True Then
                            If dr1("Mevcut") <> 0 Then
                                dr("MIKTAR") = dr1("Mevcut")
                            Else
                                dr("MIKTAR") = frm.mevcut
                            End If
                        Else
                            dr("MIKTAR") = frm.mevcut
                        End If
                        dr("lBirimMiktar") = 1
                        dr("sBirimCinsi") = dr1("sBirimCinsi1")
                        dr("lMiktar") = dr("MIKTAR")
                        'dr("MIKTAR") = 1
                        dr("sFiyatTipi") = sFiyat1
                        dr("nBirimCarpan") = dr1("nBirimCarpan")
                        dr("DEPO") = dr_baslik("TDEPO").ToString
                        dr("ACIKLAMA") = ""
                        dr("ETIKET") = ""
                        dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                        'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                        ds_hareket.Tables(0).Rows.Add(dr)
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("sKodu") & vbTab & dr1("sAciklama"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Me.Refresh()
                Next
                yeni = frm.yeni
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
                frm.Dispose()
                frm = Nothing
                stok_mevcut = Nothing
                If yeni = True Then
                    satir_ekle_stok(False)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    GridControl1.Focus()
                End If
                GridView1.FocusedColumn = colMIKTAR
            End If
        End If
    End Sub
    Private Sub satir_ekle_yeniler(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok_yeniler
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.etiket = True
        frm.kullanici = kullanici
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
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
                    If belgetipi = 2 Then
                        If bTransferEnvanterKontrol = False Then
                            stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
                        Else
                            stok_mevcut = 999999
                        End If
                        nSatir = sorgu_stok_varmi(dr1("nStokID"))
                    Else
                        nSatir = 0
                        stok_mevcut = 999999
                    End If
                    If miktarsec = True Then
                        If dr1("Mevcut") <> 0 Then
                            lMiktar = dr1("Mevcut")
                        Else
                            lMiktar = 1
                        End If
                    Else
                        lMiktar = 1
                    End If
                    If stok_mevcut >= lMiktar + nSatir Then
                        dr = ds_hareket.Tables(0).NewRow
                        dr("EVRAKNO") = belgeind
                        dr("STOKNO") = dr1("nStokId")
                        dr("STOKKODU") = Trim(dr1("sKodu").ToString)
                        dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                        dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("sBarkod").ToString), 20)
                        dr("MODEL") = Trim(dr1("sModel").ToString)
                        dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("sRenkAdi").ToString), 20)
                        dr("BEDEN") = Trim(dr1("sBeden").ToString)
                        Try
                            dr("FIYAT1") = CType(sorgu_sayi(dr1("PESIN"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT1") = 0
                        End Try
                        Try
                            dr("FIYAT2") = CType(sorgu_sayi(dr1("ALTIAY"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT2") = 0
                        End Try
                        Try
                            dr("FIYAT3") = CType(sorgu_sayi(dr1("ONAY"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT3") = 0
                        End Try
                        Try
                            dr("FIYAT4") = CType(sorgu_sayi(dr1("FIYAT4"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT4") = 0
                        End Try
                        Try
                            dr("FIYAT5") = CType(sorgu_sayi(dr1("FIYAT5"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT5") = 0
                        End Try
                        If miktarsec = True Then
                            If dr1("Mevcut") <> 0 Then
                                dr("MIKTAR") = dr1("Mevcut")
                            Else
                                dr("MIKTAR") = 1
                            End If
                        Else
                            dr("MIKTAR") = 1
                        End If
                        'dr("MIKTAR") = 1
                        dr("lBirimMiktar") = 1
                        dr("sBirimCinsi") = dr1("sBirimCinsi1")
                        dr("lMiktar") = dr("MIKTAR")
                        dr("sFiyatTipi") = "PS"
                        dr("DEPO") = dr_baslik("TDEPO").ToString
                        dr("ACIKLAMA") = ""
                        dr("ETIKET") = ""
                        dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                        'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                        ds_hareket.Tables(0).Rows.Add(dr)
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("sKodu") & vbTab & dr1("sAciklama"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.SimpleButton3 = Nothing
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
                frm.Dispose()
                frm = Nothing
                stok_mevcut = Nothing
                If yeni = True Then
                    satir_ekle_stok(False)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    GridControl1.Focus()
                End If
                GridView1.FocusedColumn = colMIKTAR
            End If
        End If
    End Sub
    Private Sub satir_ekle_degisenler(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok_fiyatidegisen
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.etiket = True
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
        frm.kullanici = kullanici
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
                    If belgetipi = 2 Then
                        If bTransferEnvanterKontrol = False Then
                            stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
                        Else
                            stok_mevcut = 999999
                        End If
                        nSatir = sorgu_stok_varmi(dr1("nStokID"))
                    Else
                        nSatir = 0
                        stok_mevcut = 999999
                    End If
                    If miktarsec = True Then
                        If dr1("Mevcut") <> 0 Then
                            lMiktar = dr1("Mevcut")
                        Else
                            lMiktar = 1
                        End If
                    Else
                        lMiktar = 1
                    End If
                    If stok_mevcut >= lMiktar + nSatir Then
                        dr = ds_hareket.Tables(0).NewRow
                        dr("EVRAKNO") = belgeind
                        dr("STOKNO") = dr1("nStokId")
                        dr("STOKKODU") = Trim(dr1("sKodu").ToString)
                        dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                        dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("sBarkod").ToString), 20)
                        dr("MODEL") = Trim(dr1("sModel").ToString)
                        dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("sRenkAdi").ToString), 20)
                        dr("BEDEN") = Trim(dr1("sBeden").ToString)
                        Try
                            dr("FIYAT1") = CType(dr1("PESIN"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT1") = 0
                        End Try
                        Try
                            dr("FIYAT2") = CType(dr1("ALTIAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT2") = 0
                        End Try
                        Try
                            dr("FIYAT3") = CType(dr1("ONAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT3") = 0
                        End Try
                        Try
                            dr("FIYAT4") = CType(dr1("FIYAT4"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT4") = 0
                        End Try
                        Try
                            dr("FIYAT5") = CType(dr1("FIYAT5"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT5") = 0
                        End Try
                        If miktarsec = True Then
                            If dr1("Mevcut") <> 0 Then
                                dr("MIKTAR") = dr1("Mevcut")
                            Else
                                dr("MIKTAR") = 1
                            End If
                        Else
                            dr("MIKTAR") = 1
                        End If
                        dr("lBirimMiktar") = 1
                        dr("sBirimCinsi") = dr1("sBirimCinsi1")
                        dr("lMiktar") = dr("MIKTAR")
                        'dr("MIKTAR") = 1
                        dr("sFiyatTipi") = "PS"
                        dr("DEPO") = dr_baslik("TDEPO").ToString
                        dr("ACIKLAMA") = ""
                        dr("ETIKET") = ""
                        dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                        'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                        ds_hareket.Tables(0).Rows.Add(dr)
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("sKodu") & vbTab & dr1("sAciklama"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.SimpleButton3 = Nothing
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
                frm.Dispose()
                frm = Nothing
                stok_mevcut = Nothing
                If yeni = True Then
                    satir_ekle_stok(False)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                    'GridView1.FocusedRowHandle = 0
                End If
                GridView1.FocusedColumn = colMIKTAR
            End If
        End If
    End Sub
    Private Sub satir_ekle_stok_transfer(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok_transfer_kontrol
        frm.status = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.status = True
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
        frm.kullanici = kullanici
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
                    If belgetipi = 2 Then
                        If bTransferEnvanterKontrol = False Then
                            stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
                        Else
                            stok_mevcut = 999999
                        End If
                        nSatir = sorgu_stok_varmi(dr1("nStokID"))
                    Else
                        nSatir = 0
                        stok_mevcut = 999999
                    End If
                    lMiktar = sorgu_sayi(dr1("lCikisMiktar1"), 1)
                    If stok_mevcut >= lMiktar + nSatir Then
                        dr = ds_hareket.Tables(0).NewRow
                        dr("EVRAKNO") = belgeind
                        dr("STOKNO") = dr1("nStokId")
                        dr("STOKKODU") = Trim(dr1("sKodu").ToString)
                        dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("StokAdi")), 50)
                        dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("sKodu")), 20)
                        dr("MODEL") = Trim(dr1("sModel").ToString)
                        dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("sRenkAdi")), 20)
                        dr("BEDEN") = Trim(dr1("sBeden").ToString)
                        Try
                            dr("FIYAT1") = 0 ' CType(dr1("PESIN"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT1") = 0
                        End Try
                        Try
                            dr("FIYAT2") = 0 'CType(dr1("ALTIAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT2") = 0
                        End Try
                        Try
                            dr("FIYAT3") = 0 'CType(dr1("ONAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT3") = 0
                        End Try
                        Try
                            dr("FIYAT4") = 0 'CType(dr1("ONAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT4") = 0
                        End Try
                        Try
                            dr("FIYAT5") = 0 'CType(dr1("ONAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT5") = 0
                        End Try
                        dr("MIKTAR") = sorgu_sayi(dr1("lCikisMiktar1"), 1)
                        dr("lBirimMiktar") = 1
                        dr("sBirimCinsi") = dr1("sBirimCinsi1")
                        dr("lMiktar") = dr("MIKTAR")
                        dr("sFiyatTipi") = "PS"
                        dr("DEPO") = dr1("sTransferDepo") 'dr_baslik("TDEPO").ToString
                        dr("ACIKLAMA") = dr1("sAciklama")
                        dr("ETIKET") = ""
                        dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                        'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                        ds_hareket.Tables(0).Rows.Add(dr)
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("sKodu") & vbTab & dr1("sStokAdi"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Me.Refresh()
                Next
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                stok_mevcut = Nothing
            End If
        End If
    End Sub
    Private Sub satir_ekle_stok_terminal(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok_paket_aktarim
        frm.status = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
        frm.kullanici = kullanici
        frm.islemstatus = True
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
                    If belgetipi = 2 Then
                        If bTransferEnvanterKontrol = False Then
                            stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
                        Else
                            stok_mevcut = 999999
                        End If
                        nSatir = sorgu_stok_varmi(dr1("nStokID"))
                    Else
                        nSatir = 0
                        stok_mevcut = 999999
                    End If
                    lMiktar = sorgu_sayi(dr1("lMiktar"), 0)
                    If stok_mevcut >= lMiktar + nSatir Then
                        dr = ds_hareket.Tables(0).NewRow
                        dr("EVRAKNO") = belgeind
                        dr("STOKNO") = dr1("nStokId")
                        dr("STOKKODU") = Trim(dr1("sStokKodu").ToString)
                        dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("sStokAciklama")), 50)
                        dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("sBarkod")), 20)
                        dr("MODEL") = Microsoft.VisualBasic.Left(Trim(dr1("sModel")), 20)
                        dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("sRenk")), 20)
                        dr("BEDEN") = Microsoft.VisualBasic.Left(Trim(dr1("sBeden")), 20)
                        Try
                            dr("FIYAT1") = 0 ' CType(dr1("PESIN"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT1") = 0
                        End Try
                        Try
                            dr("FIYAT2") = 0 'CType(dr1("ALTIAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT2") = 0
                        End Try
                        Try
                            dr("FIYAT3") = 0 'CType(dr1("ONAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT3") = 0
                        End Try
                        Try
                            dr("FIYAT4") = 0 'CType(dr1("ONAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT4") = 0
                        End Try
                        Try
                            dr("FIYAT5") = 0 'CType(dr1("ONAY"), Decimal)
                        Catch ex As Exception
                            dr("FIYAT5") = 0
                        End Try
                        dr("MIKTAR") = sorgu_sayi(dr1("lMiktar"), 0)
                        dr("lBirimMiktar") = 1
                        dr("sBirimCinsi") = "" 'dr1("sBirimCinsi1")
                        dr("lMiktar") = dr("MIKTAR")
                        dr("sFiyatTipi") = "PS"
                        dr("DEPO") = dr_baslik("TDEPO").ToString
                        dr("ACIKLAMA") = "" 'dr1("sAciklama")
                        dr("ETIKET") = ""
                        dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                        'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                        ds_hareket.Tables(0).Rows.Add(dr)
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("sKodu") & vbTab & dr1("sStokAciklama"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Me.Refresh()
                Next
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                stok_mevcut = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    GridControl1.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub satir_ekle_stok_alislar(ByVal yeni As Boolean, Optional ByVal bAlis As Boolean = True)
        Dim frm As New frm_stok_alislar
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
        frm.kullanici = kullanici
        frm.bAlis = bAlis
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
                    If belgetipi = 2 Then
                        If bTransferEnvanterKontrol = False Then
                            stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("STOKNO"))
                        Else
                            stok_mevcut = 999999
                        End If
                        nSatir = sorgu_stok_varmi(dr1("STOKNO"))
                    Else
                        nSatir = 0
                        stok_mevcut = 999999
                    End If
                    lMiktar = sorgu_sayi(dr1("MIKTAR"), 1)
                    If stok_mevcut >= lMiktar + nSatir Then
                        dr = ds_hareket.Tables(0).NewRow
                        dr("EVRAKNO") = belgeind
                        dr("STOKNO") = dr1("STOKNO")
                        dr("STOKKODU") = Trim(dr1("STOKKODU").ToString)
                        dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("STOKADI").ToString), 50)
                        dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("STOKKODU").ToString), 20)
                        dr("MODEL") = Trim(dr1("sModel").ToString)
                        dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("RENK").ToString), 20)
                        dr("BEDEN") = Trim(dr1("sBeden").ToString)
                        Try
                            dr("FIYAT1") = CType(sorgu_sayi(dr1("PESIN"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT1") = 0
                        End Try
                        Try
                            dr("FIYAT2") = CType(sorgu_sayi(dr1("ALTIAY"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT2") = 0
                        End Try
                        Try
                            dr("FIYAT3") = CType(sorgu_sayi(dr1("ONAY"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT3") = 0
                        End Try
                        Try
                            dr("FIYAT4") = CType(sorgu_sayi(dr1("FIYAT4"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT4") = 0
                        End Try
                        Try
                            dr("FIYAT5") = CType(sorgu_sayi(dr1("FIYAT5"), 0), Decimal)
                        Catch ex As Exception
                            dr("FIYAT5") = 0
                        End Try
                        dr("lBirimMiktar") = 1
                        dr("sBirimCinsi") = dr1("sBirimCinsi1").ToString
                        dr("MIKTAR") = sorgu_sayi(dr1("MIKTAR"), 1)
                        dr("lMiktar") = sorgu_sayi(dr1("MIKTAR"), 1)
                        'dr("MIKTAR") = 1
                        dr("sFiyatTipi") = sFiyat1
                        dr("DEPO") = dr_baslik("TDEPO").ToString
                        dr("ACIKLAMA") = ""
                        dr("ETIKET") = ""
                        dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                        'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                        ds_hareket.Tables(0).Rows.Add(dr)
                    Else
                        If nSatir = -1 Then
                            XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("STOKKODU") & vbTab & dr1("STOKADI"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            XtraMessageBox.Show(dr1("STOKKODU") & vbCrLf & dr1("STOKADI") & vbCrLf & Sorgu_sDil("Transfer Fiþlerinde Ayný Ürünü Farklý Farklý Satýrlarda Ýþleyemezsiniz...", sDil) & vbCrLf & "Satýr No: " & nSatir + 1, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.SimpleButton3 = Nothing
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
                frm.Dispose()
                frm = Nothing
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                stok_mevcut = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    GridControl1.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub satir_ekle_stok_tek(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
        s = i.ToString
        dr1 = ds_stok.Tables(0).Rows(0)
        'If bTransferEnvanterKontrol = False Then
        '    stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
        'Else
        '    stok_mevcut = 999999
        'End If
        If belgetipi = 2 Then
            If bTransferEnvanterKontrol = False Then
                stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
            Else
                stok_mevcut = 999999
            End If
            nSatir = sorgu_stok_varmi(dr1("nStokID"))
        Else
            nSatir = 0
            stok_mevcut = 999999
        End If
        If miktarsec = True Then
            If dr1("Mevcut") <> 0 Then
                lMiktar = dr1("Mevcut")
            Else
                lMiktar = mevcut
            End If
        Else
            lMiktar = mevcut
        End If
        If stok_mevcut >= lMiktar + nSatir Then
            dr = ds_hareket.Tables(0).NewRow
            'MsgBox(Sorgu_sDil("Satýþ Yapýlabilir Miktar: " & satis_miktar)
            dr("EVRAKNO") = belgeind
            dr("STOKNO") = dr1("nStokId")
            dr("STOKKODU") = Trim(dr1("sKodu").ToString)
            dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
            dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("sBarkod").ToString), 20)
            dr("MODEL") = Trim(dr1("sModel").ToString)
            dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("sRenkAdi").ToString), 20)
            dr("BEDEN") = Trim(dr1("sBeden").ToString)
            Try
                dr("FIYAT1") = CType(sorgu_sayi(dr1("FIYAT1"), 0), Decimal)
            Catch ex As Exception
                dr("FIYAT1") = 0
            End Try
            Try
                dr("FIYAT2") = CType(sorgu_sayi(dr1("FIYAT2"), 0), Decimal)
            Catch ex As Exception
                dr("FIYAT2") = 0
            End Try
            Try
                dr("FIYAT3") = CType(sorgu_sayi(dr1("FIYAT3"), 0), Decimal)
            Catch ex As Exception
                dr("FIYAT3") = 0
            End Try
            Try
                dr("FIYAT4") = CType(sorgu_sayi(dr1("FIYAT4"), 0), Decimal)
            Catch ex As Exception
                dr("FIYAT4") = 0
            End Try
            Try
                dr("FIYAT5") = CType(sorgu_sayi(dr1("FIYAT5"), 0), Decimal)
            Catch ex As Exception
                dr("FIYAT5") = 0
            End Try
            If miktarsec = True Then
                If dr1("Mevcut") <> 0 Then
                    dr("MIKTAR") = dr1("Mevcut")
                Else
                    dr("MIKTAR") = mevcut
                End If
            Else
                dr("MIKTAR") = mevcut
            End If
            dr("lBirimMiktar") = 1
            dr("sBirimCinsi") = dr1("sBirimCinsi1")
            dr("lMiktar") = dr("MIKTAR")
            'dr("MIKTAR") = 1
            dr("sFiyatTipi") = sFiyat1
            dr("nBirimCarpan") = dr1("nBirimCarpan")
            dr("DEPO") = dr_baslik("TDEPO")
            dr("ACIKLAMA") = ""
            dr("ETIKET") = ""
            dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
            'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
            ds_hareket.Tables(0).Rows.Add(dr)
            Label4.Text = "Stok Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("sKodu") & vbTab & dr1("sAciklama"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.Refresh()
        dr = Nothing
        dr1 = Nothing
        s = Nothing
        arr = Nothing
        i = Nothing
        stok_mevcut = Nothing
        If GridView1.RowCount > 0 And nSatir = -1 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            GridControl1.Focus()
        End If
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_ekle_stok_koli(ByVal sKoliKodu As String, Optional ByVal miktarsec As Boolean = False)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim stok_mevcut As Decimal = 0
        Dim nSatir As Decimal = 0
        Dim lMiktar As Decimal = 0
        Dim lMevcut As Decimal = mevcut
        s = i.ToString
        Dim ds_tbKoliDagilim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS FIYAT4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'), 0) AS FIYAT5, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'), 0) AS lAltFiyat, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbKoliDagilimi.sBirimCinsi,tbKoliDagilimi.lBirimMiktar,tbKoliDagilimi.lMiktar AS lMiktar FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbKoliDagilimi ON tbStok.nStokID = tbKoliDagilimi.nStokID WHERE (tbKoliDagilimi.sKoliKodu = N'" & sKoliKodu & "')")
        For Each dr1 In ds_tbKoliDagilim.Tables(0).Rows
            'If bTransferEnvanterKontrol = False Then
            '    stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
            'Else
            '    stok_mevcut = 999999
            'End If
            'mevcut = sorgu_sayi(dr1("lMiktar"), 1)
            mevcut = lMevcut * sorgu_sayi(dr1("lMiktar") * dr1("lBirimMiktar"), 1)
            If belgetipi = 2 Then
                If bTransferEnvanterKontrol = False Then
                    stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr1("nStokID"))
                Else
                    stok_mevcut = 999999
                End If
                nSatir = sorgu_stok_varmi(dr1("nStokID"))
            Else
                nSatir = 0
                stok_mevcut = 999999
            End If
            If miktarsec = True Then
                If dr1("Mevcut") <> 0 Then
                    lMiktar = dr1("Mevcut")
                Else
                    lMiktar = mevcut
                End If
            Else
                lMiktar = mevcut
            End If
            If stok_mevcut >= lMiktar + nSatir Then
                dr = ds_hareket.Tables(0).NewRow
                'MsgBox(Sorgu_sDil("Satýþ Yapýlabilir Miktar: " & satis_miktar)
                dr("EVRAKNO") = belgeind
                dr("STOKNO") = dr1("nStokId")
                dr("STOKKODU") = Trim(dr1("sKodu").ToString)
                dr("MALINCINSI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
                dr("BARCODE") = Microsoft.VisualBasic.Left(Trim(dr1("sBarkod").ToString), 20)
                dr("MODEL") = Trim(dr1("sModel").ToString)
                dr("RENK") = Microsoft.VisualBasic.Left(Trim(dr1("sRenkAdi").ToString), 20)
                dr("BEDEN") = Trim(dr1("sBeden").ToString)
                Try
                    dr("FIYAT1") = CType(sorgu_sayi(dr1("FIYAT1"), 0), Decimal)
                Catch ex As Exception
                    dr("FIYAT1") = 0
                End Try
                Try
                    dr("FIYAT2") = CType(sorgu_sayi(dr1("FIYAT2"), 0), Decimal)
                Catch ex As Exception
                    dr("FIYAT2") = 0
                End Try
                Try
                    dr("FIYAT3") = CType(sorgu_sayi(dr1("FIYAT3"), 0), Decimal)
                Catch ex As Exception
                    dr("FIYAT3") = 0
                End Try
                Try
                    dr("FIYAT4") = CType(sorgu_sayi(dr1("FIYAT4"), 0), Decimal)
                Catch ex As Exception
                    dr("FIYAT4") = 0
                End Try
                Try
                    dr("FIYAT5") = CType(sorgu_sayi(dr1("FIYAT5"), 0), Decimal)
                Catch ex As Exception
                    dr("FIYAT5") = 0
                End Try
                If miktarsec = True Then
                    If dr1("Mevcut") <> 0 Then
                        dr("MIKTAR") = dr1("Mevcut")
                    Else
                        dr("MIKTAR") = mevcut
                    End If
                Else
                    dr("MIKTAR") = mevcut
                End If
                dr("lBirimMiktar") = dr1("lBirimMiktar")
                dr("sBirimCinsi") = dr1("sBirimCinsi1")
                dr("lMiktar") = dr1("lMiktar")
                'dr("MIKTAR") = 1
                dr("sFiyatTipi") = sFiyat1
                dr("nBirimCarpan") = dr1("nBirimCarpan")
                dr("DEPO") = dr_baslik("TDEPO")
                dr("ACIKLAMA") = ""
                dr("ETIKET") = ""
                dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                ds_hareket.Tables(0).Rows.Add(dr)
                Label4.Text = "Stok Ýþlendi...Yeni Ürün Okutun..."
                Label4.Refresh()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Envanter Eksi(-) Olamaz...!", sDil) & vbCrLf & dr1("sKodu") & vbTab & dr1("sAciklama"), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Next
        Me.Refresh()
        dr = Nothing
        dr1 = Nothing
        s = Nothing
        arr = Nothing
        i = Nothing
        stok_mevcut = Nothing
        If GridView1.RowCount > 0 And nSatir = -1 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            GridControl1.Focus()
        End If
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_birlestir()
        Dim frm As New frm_stok_etikettalep_birlestir
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.EVRAKNO = belgeind
        frm.islemstatus = True
        Dim dr As DataRow
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            For Each dr In frm.dataset1.Tables(0).Rows
                If dr("SEC") = True Then
                    hareket_kaydet_miktar_degistir(dr("IND"), dr("EVRAKNO"), dr("STOKNO"), dr("MIKTAR"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                    hareket_kaydet_satir_sil(dr("IND"), dr("EVRAKNO"), dr("STOKNO"))
                End If
            Next
            dataload_harekets()
            XtraMessageBox.Show(Sorgu_sDil("Satýrlar Baþarýyla Birleþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr = Nothing
    End Sub
    Private Sub satis_takip()
        Dim frm As New frm_stok_satis_takip
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sEvrakno = dr_baslik("IND")
        frm.dteIslemTarihi1 = dr_baslik("KOD1").ToString
        frm.dteIslemTarihi2 = dr_baslik("KOD2").ToString
        frm.kullanici = kullanici
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
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
                If dr_hareket("STOKNO").ToString <> "" Then
                    hareket_kaydet_sil(dr_hareket("IND"))
                End If
                ds_hareket.Tables(0).Rows.Remove(dr_hareket)
                GridControl1.Focus()
                GridControl1.Select()
                GridView1.SelectRow(GridView1.FocusedRowHandle)
            End If
        End If
    End Sub
    Private Sub satir_degistir()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok
            Dim dr1 As DataRow
            Dim dr As DataRow
            'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("STOKNO") = dr1("nStokId")
                dr("STOKKODU") = dr1("sKodu")
                dr("MALINCINSI") = dr1("sAciklama")
                dr("BARCODE") = dr1("sBarkod")
                dr("BEDEN") = dr1("sBeden")
                dr("RENK") = dr1("sRenkAdi")
                dr("MODEL") = dr1("sModel")
                girdi_tutar_hesapla()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr1 = Nothing
        End If
    End Sub
    Private Sub belge_iptal(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'Plan Baslik
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKETIKETTALEPBASLIK WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        'Plan Hareket
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKETIKETTALEPDETAY WHERE EVRAKNO = " & evrakno & "")
        cmd.ExecuteNonQuery()
        'Teslim Baslik
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKETIKETTESLIMBASLIK WHERE REFIND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hesapla()
        If ds_hareket.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            GridControl1.Update()
            If dr("MIKTAR") = 0 Then
                dr("MIKTAR") = 1
            End If
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
            ds_hareket.Tables(0).EndInit()
            GridView1.UpdateTotalSummary()
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        'kl = CType(Me.BindingContext(DataView1), CurrencyManager)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim Ý As Integer
        Ý = 0
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        'kl.Position += 1
        For Ý = 1 To TOPLAM
            dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr_hareket.BeginEdit()
            dr_hareket("" & columnkriter & "") = durum
            dr_hareket.EndEdit()
            hesapla()
            'maliyetkontrol()
            'GridView1.FocusedRowHandle += 1
            If columnkriter = "ORAN1" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                fiyat_kontrol()
            ElseIf columnkriter = "ORAN2" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                fiyat_kontrol()
            ElseIf columnkriter = "ORAN3" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                fiyat_kontrol()
            ElseIf columnkriter = "PESIN" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                oran_kontrol()
            ElseIf columnkriter = "ALTIAY" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                oran_kontrol()
            ElseIf columnkriter = "ONAY" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                oran_kontrol()
            End If
            GridView1.FocusedRowHandle += 1
        Next
        'kl.Position = satir
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub girdi_tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            Dim bYenile As Boolean = False
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("MIKTAR") = 0 Then
                dr("MIKTAR") = 1
            End If
            dr("MIKTAR") = dr("lMiktar") * dr("lBirimMiktar")
            Dim stok_mevcut As Decimal = 0
            Dim nSatir As Decimal = 0
            If belgetipi = 2 Then
                If bTransferEnvanterKontrol = False Then
                    stok_mevcut = sorgu_envanter(dr_baslik("DEPO"), dr("STOKNO"))
                Else
                    stok_mevcut = 999999
                End If
                nSatir = sorgu_stok_varmi(dr("STOKNO"), GridView1.FocusedRowHandle)
            Else
                nSatir = 0
                stok_mevcut = 999999
            End If
            If stok_mevcut <= 0 Then
                Label4.Text = "Mevcut olmayan Stoðun transferini yapýyorsunuz... Stok Envanteri Eksi Olamaz"
                Label4.Refresh()
                MessageBox.Show("Mevcut Olmayan Stoðun transferini yapýyorsunuz... Stok Envanteri Eksi Olamaz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                satir_sil()
            ElseIf stok_mevcut < (dr("MIKTAR") + nSatir) Then
                'MsgBox((stok_mevcut - nSatir))
                dr("MIKTAR") = (stok_mevcut - nSatir)
                XtraMessageBox.Show(Sorgu_sDil("Mevcut Stoktan Fazla Transfer Ýþlemi Yapamazsýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dr("MIKTAR") = (stok_mevcut - nSatir)
                Label4.Text = "Mevcut Stoktan Fazla Transfer Ýþlemi Yapamazsýnýz..."
                Label4.Refresh()
                bYenile = True
            End If
            dr.EndEdit()
            ds_hareket.AcceptChanges()
            hareket_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("ETIKET"), dr("ACIKLAMA"), dr("DEPO"), dr("MIKTAR"), dr("sFiyatTipi"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("FIYAT4"), dr("FIYAT5"), dr("sBirimCinsi"), dr("lBirimMiktar"))
            GridControl1.DataSource = ds_hareket.Tables(0)
            GridControl1.Focus()
            GridControl1.Select()
            If bYenile = True Then
                Dim satir = GridView1.FocusedRowHandle
                dataload_harekets(False)
                GridView1.FocusedRowHandle = satir
                GridView1.Focus()
                GridView1.ClearSelection()
                GridView1.SelectRow(satir)
            End If
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_DegerYay.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName)
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirEkle.Click
        If dr_baslik("IND") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            satir_ekle_stok(False)
            Timer1.Enabled = True
        ElseIf dr_baslik("IND") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Ürün Talep Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Vgrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles Vgrid_baslik.CellValueChanged
        Try
            'Vgrid_baslik.PostEditor()
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            baslik_teslim_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            If Trim(sDatabaseGenel) = "UGURLU" Then
                Dim dr As DataRow
                For Each dr In ds_baslik.Tables(0).Rows
                    If Kod3ZorunluMu(Trim(dr("DEPO").ToString())) Then
                        If Trim(dr("KOD3").ToString()).Length < 1 Then
                            txt_ara.Enabled = False
                            SimpleButton3.Enabled = False
                            GridControl1.ContextMenu = Nothing
                            btn_SatirEkle.Enabled = False
                            btn_SatirEkleTransfer.Enabled = False
                            btn_SatirEkleAlis.Enabled = False
                            BarButtonItem4.Enabled = False
                            btn_SatirEklePaket.Enabled = False
                            BarButtonItem6.Enabled = False
                            btn_SatirSil.Enabled = False
                            BarButtonItem24.Enabled = False
                            MessageBox.Show("Lütfen 3.ÖzelKod alanýna belge numarasýný giriniz!")
                        Else
                            txt_ara.Enabled = True
                            SimpleButton3.Enabled = True
                            GridControl1.ContextMenu = kisayol_hareket
                            btn_SatirEkle.Enabled = True
                            btn_SatirEkleTransfer.Enabled = True
                            btn_SatirEkleAlis.Enabled = True
                            BarButtonItem4.Enabled = True
                            btn_SatirEklePaket.Enabled = True
                            BarButtonItem6.Enabled = True
                            btn_SatirSil.Enabled = True
                            BarButtonItem24.Enabled = True
                        End If
                    Else
                        txt_ara.Enabled = True
                        SimpleButton3.Enabled = True
                        GridControl1.ContextMenu = kisayol_hareket
                        btn_SatirEkle.Enabled = True
                        btn_SatirEkleTransfer.Enabled = True
                        btn_SatirEkleAlis.Enabled = True
                        BarButtonItem4.Enabled = True
                        btn_SatirEklePaket.Enabled = True
                        BarButtonItem6.Enabled = True
                        btn_SatirSil.Enabled = True
                        BarButtonItem24.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Try
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                GridControl1.Focus()
                GridControl1.Focus()
                GridView1.Focus()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 2 Then
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FisIptal.ItemClick
        If yetki_kontrol(kullanici, "frm_Transfer_Sil") = True Then
            If XtraMessageBox.Show(Me.Text & Sorgu_sDil(" Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                belge_iptal(belgeind)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub frm_stok_paket_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If GridView1.RowCount = 0 Then
            'If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..! " & vbCrLf & "Belgeyi Silmek Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            '    belge_iptal(belgeind)
            '    'Me.Close()
            'Else
            'End If
        Else
            Timer1.Enabled = False
            toplam_hesapla()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO").ToString, 1, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            baslik_teslim_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO").ToString, 1, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            Timer1.Enabled = True
        End If
        'SplitterControl1 = Nothing
        'BarManager1 = Nothing
        'barDockControlTop = Nothing
        'barDockControlBottom = Nothing
        'barDockControlLeft = Nothing
        'barDockControlRight = Nothing
        'Bar2 = Nothing
        'Bar3 = Nothing
        'BarSubItem1 = Nothing
        'BarSubItem2 = Nothing
        'BarSubItem3 = Nothing
        'Vgrid_baslik = Nothing
        'XtraTabControl1 = Nothing
        'XtraTabPage1 = Nothing
        'Panel_baslik = Nothing
        'Panel_toplamlar = Nothing
        'Panel_hareketler = Nothing
        'Panel_toplam = Nothing
        'Panel_depo_info = Nothing
        'Panel_satis_info = Nothing
        'VGrid_toplam = Nothing
        'VGrid_depo_info = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'BarButtonItem1 = Nothing
        'BarButtonItem2 = Nothing
        'BarButtonItem3 = Nothing
        'BarButtonItem4 = Nothing
        'BarButtonItem5 = Nothing
        'BarButtonItem6 = Nothing
        'BarButtonItem7 = Nothing
        'ds_baslik.Clear()
        'ds_baslik.Dispose()
        'ds_baslik = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn7 = Nothing
        'DataColumn10 = Nothing
        'DataColumn11 = Nothing
        'DataColumn12 = Nothing
        'DataColumn13 = Nothing
        'DataColumn14 = Nothing
        'DataColumn15 = Nothing
        'DataColumn17 = Nothing
        'rowIND = Nothing
        'rowBELGENO = Nothing
        'rowKOD1 = Nothing
        'rowKOD2 = Nothing
        'rowKOD3 = Nothing
        'rowKOD4 = Nothing
        'rowKOD5 = Nothing
        'rowACIKLAMA = Nothing
        'rowKAYITTARIHI = Nothing
        'categoryTanýmlar = Nothing
        'categoryAçýklama = Nothing
        'ds_hareket = Nothing
        'DataTable2 = Nothing
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'DataColumn21 = Nothing
        'kisayol_hareket = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'sec_depo_baslik = Nothing
        'sec_depo_hareket = Nothing
        'ds_belgetipi = Nothing
        'DataTable5 = Nothing
        'DataColumn83 = Nothing
        'DataColumn84 = Nothing
        'sec_baslik_belgetipi = Nothing
        'BarButtonItem8 = Nothing
        'ds_detay = Nothing
        'DataTable3 = Nothing
        'DataColumn36 = Nothing
        'DataColumn37 = Nothing
        'DataColumn38 = Nothing
        'DataColumn39 = Nothing
        'DataColumn40 = Nothing
        'DataColumn41 = Nothing
        'DataColumn42 = Nothing
        'DataColumn43 = Nothing
        'DataColumn44 = Nothing
        'DataColumn45 = Nothing
        'DataColumn46 = Nothing
        'DataColumn47 = Nothing
        'DataColumn48 = Nothing
        'DataColumn49 = Nothing
        'DataColumn50 = Nothing
        'DataColumn51 = Nothing
        'Timer1 = Nothing
        'Label1 = Nothing
        'Label2 = Nothing
        'Label3 = Nothing
        'rowTARIH = Nothing
        'sec_fiyat = Nothing
        'sec_oran = Nothing
        'BarSubItem4 = Nothing
        'BarButtonItem9 = Nothing
        'BarButtonItem10 = Nothing
        'BarButtonItem11 = Nothing
        'BarSubItem5 = Nothing
        'BarButtonItem12 = Nothing
        'BarButtonItem13 = Nothing
        'OpenFileDialog1 = Nothing
        'BarButtonItem14 = Nothing
        'BarSubItem6 = Nothing
        'BarButtonItem15 = Nothing
        'DataColumn60 = Nothing
        'DataColumn61 = Nothing
        'rowSONUC = Nothing
        'rowDEPO = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn8 = Nothing
        'DataColumn9 = Nothing
        'DataColumn16 = Nothing
        'DataColumn18 = Nothing
        'DataColumn22 = Nothing
        'DataColumn23 = Nothing
        'DataColumn24 = Nothing
        'DataColumn25 = Nothing
        'DataColumn26 = Nothing
        'colIND = Nothing
        'colEVRAKNO = Nothing
        'colSTOKNO = Nothing
        'colSTOKKODU = Nothing
        'colMALINCINSI = Nothing
        'colBARCODE = Nothing
        'colRENK = Nothing
        'colBEDEN = Nothing
        'colMODEL = Nothing
        'colETIKET = Nothing
        'colACIKLAMA = Nothing
        'colDEPO = Nothing
        'colMIKTAR = Nothing
        'colFIYAT1 = Nothing
        'colFIYAT2 = Nothing
        'colFIYAT3 = Nothing
        'BarButtonItem16 = Nothing
        'sec_baslik_sonuc = Nothing
        'sec_etiket = Nothing
        'BarButtonItem17 = Nothing
        'BarButtonItem18 = Nothing
        'BarButtonItem19 = Nothing
        'BarButtonItem20 = Nothing
        'BarButtonItem21 = Nothing
        'MenuItem6 = Nothing
        'PanelControl1 = Nothing
        'Label4 = Nothing
        'SimpleButton3 = Nothing
        'sec_kriter = Nothing
        'txt_ara = Nothing
        'lbl_ara = Nothing
        'BarButtonItem22 = Nothing
        'listbox1.Items.Clear()
        'listbox1.Dispose()
        'listbox1 = Nothing
        'status = Nothing
        'connection = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'stokno = Nothing
        'userno = Nothing
        'dr_baslik = Nothing
        'dr_hareket = Nothing
        'cmd = Nothing
        'con = Nothing
        'adapter = Nothing
        'belgeind = Nothing
        'miktar = Nothing
        'detay_miktar = Nothing
        'depokodu = Nothing
        'dr = Nothing
        'qr_hareket = Nothing
        'qr_baslik = Nothing
        'mevcut = Nothing
        'x = Nothing
        'okut = Nothing
        'ds_stok = Nothing
        'belgetipi = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub toplam_hesapla()
        'Dim dr As DataRow
        miktar = 0
        detay_miktar = 0
        For Each dr In ds_hareket.Tables(0).Rows
            miktar = miktar + dr("MIKTAR")
        Next
        'For Each dr In ds_detay.Tables(0).Rows
        '    detay_miktar = detay_miktar + dr("MIKTAR")
        'Next
        Try
            If dr_baslik("IND") = 0 Then
                Label1.Text = "Yeni Paket Fiþi" & vbCrLf & "Lütfen Teslim Fiþi Bilgilerini Girin...!"
                Me.Label1.ForeColor = System.Drawing.Color.Red
                Label1.BackColor = System.Drawing.Color.White
            Else
                'Dim fark As Int64 = detay_miktar - miktar
                'If fark = 0 Then
                '    Label1.Text = "Teslimat Bitti..!" & vbCrLf & "Yeni Belge Açýn"
                '    Me.Label1.ForeColor = System.Drawing.Color.Black
                '    Label1.BackColor = System.Drawing.Color.White
                'ElseIf fark > 0 Then
                '    Label1.Text = "Kalan Teslim Edilecek Ürün Sayýsý : " & vbCrLf & Math.Abs(fark)
                '    Me.Label1.ForeColor = System.Drawing.Color.Blue
                '    Label1.BackColor = System.Drawing.Color.Yellow
                'ElseIf fark < 0 Then
                '    Label1.Text = "Fazla Teslim Edilen Ürün Sayýsý : " & vbCrLf & Math.Abs(fark)
                '    Me.Label1.ForeColor = System.Drawing.Color.Red
                '    Label1.BackColor = System.Drawing.Color.Yellow
                'End If
            End If
            Label2.Text = Now.ToLongTimeString
            Label3.Text = Now.ToLongDateString
            Label1.Text = Me.Text + " / "
            Label1.Text += dr_baslik("SONUC")
            If Label1.Visible = False Then
                Label1.Visible = True
            Else
                Label1.Visible = False
            End If
            If GridView1.SelectedRowsCount > 1 Then
                Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & "/Satýr :" & GridView1.FocusedRowHandle + 1 & " /Seçili :" & GridView1.SelectedRowsCount & "/Miktar: " & Microsoft.VisualBasic.Format(miktar, "#,0.###")
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & "/Satýr :" & GridView1.FocusedRowHandle + 1 & "/Miktar: " & Microsoft.VisualBasic.Format(miktar, "#,0.###")
            Else
                Label5.Text = ""
            End If
            If dr_baslik("SONUC") = "SAYIM..." Then
                rowTARIH.Properties.ReadOnly = False
            Else
                rowTARIH.Properties.ReadOnly = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        toplam_hesapla()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Kaydedip Yeni Talep Belgesi Açmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Timer1.Enabled = False
            toplam_hesapla()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO").ToString, 1, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            baslik_teslim_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO").ToString, 1, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            Timer1.Enabled = True
            Try
                tbFisKilit_sil(dr_baslik("IND"), belgetipi, kullanici)
            Catch ex As Exception
            End Try
            baslik_yeni()
            Try
                loaded()
            Catch ex As Exception
                Me.Close()
            End Try
            Try
                'gorunum_yukle()
            Catch ex As Exception
            End Try
            Try
                dataload_hareket()
            Catch ex As Exception
            End Try
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub oran_kontrol()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            Try
                If dr("PESIN") <> 0 Then
                    dr("ORAN1") = ((dr("PESIN") - dr("NETMALIYET")) / dr("NETMALIYET")) * 100
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ALTIAY") <> 0 Then
                    dr("ORAN2") = ((dr("ALTIAY") - dr("NETMALIYET")) / dr("NETMALIYET")) * 100
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ONAY") <> 0 Then
                    dr("ORAN3") = ((dr("ONAY") - dr("NETMALIYET")) / dr("NETMALIYET")) * 100
                End If
            Catch ex As Exception
            End Try
            dr.EndEdit()
            girdi_tutar_hesapla()
            dr = Nothing
        End If
    End Sub
    Private Sub fiyat_kontrol()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            dr("PESIN") = dr("NETMALIYET") * ((dr("ORAN1") + 100) / 100)
            dr("ALTIAY") = dr("NETMALIYET") * ((dr("ORAN2") + 100) / 100)
            'dr("ALTIAY") = dr("ALTIAY") - CInt(dr("ALTIAY")) Mod 6
            dr("ONAY") = dr("NETMALIYET") * ((dr("ORAN3") + 100) / 100)
            'dr("ONAY") = dr("ONAY") - CType(dr("ONAY"), Decimal) Mod 10
            'oran_kontrol()
            dr.EndEdit()
            dr = Nothing
            girdi_tutar_hesapla()
        End If
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        'OpenFileDialog1.Title = "Rapor Seç..."
        'OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr*) |Form*.fr*"
        'OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Form_" & Trim(sFisTipi) & "" & sRaporUzanti & ""
        'OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr*) |Form*.fr*"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Etiket Talep"
        'OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form" & sRaporUzanti & ""
        If belgetipi = 0 Then
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form_talep" & sRaporUzanti & ""
        ElseIf belgetipi = 1 Then
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form_lojistik" & sRaporUzanti & ""
        ElseIf belgetipi = 2 Then
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form_transfer" & sRaporUzanti & ""
        End If
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                report_create_stok(sFile, "", nIslem)
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                'Dim sFile = OpenFileDialog1.FileName.ToString
                Dim report As New FastReport.Report
                report.Load(sFile)
                Dim ds_Siparis As DataSet
                'ds_Siparis = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT HAREKET.*, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN( 'T','DC') ) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonSatisTarihi, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.lGirisMiktar1 , 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisMiktari, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Mevcut,(SELECT isnull(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Satilan, (SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.nStokID = HAREKET.STOKNO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY stok.sKodu) AS Bekleyen FROM ASTOKETIKETTALEPDETAY HAREKET INNER JOIN ASTOKETIKETTALEPBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE (HAREKET.EVRAKNO = " & belgeind & ") ORDER BY HAREKET.STOKKODU"), "Siparis")
                ds_Siparis = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT HAREKET.*, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN( 'T','DC') ) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonSatisTarihi, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.lGirisMiktar1 , 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisMiktari, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Mevcut,(SELECT isnull(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Satilan, (SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.nStokID = HAREKET.STOKNO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY stok.sKodu) AS Bekleyen FROM ASTOKETIKETTALEPDETAY HAREKET INNER JOIN ASTOKETIKETTALEPBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE (HAREKET.EVRAKNO = " & belgeind & ") ORDER BY HAREKET.MALINCINSI"), "Siparis")
                dataload_baslik()
                report.RegisterData(ds_baslik)
                report.RegisterData(ds_hareket)
                report.RegisterData(ds_Siparis)
                report.RegisterData(ds_tbParamGenel)
                report.SetParameterValue("dteFisTarihi", dr_baslik("TARIH"))
                report.SetParameterValue("sFisNo", dr_baslik("BELGENO"))
                report.SetParameterValue("sFisTipi", Me.Text)
                report.ScriptLanguage = Language.Vb
                report.PrintSettings.Collate = False
                If nIslem = 0 Then
                    report.Show()
                ElseIf nIslem = 2 Then
                    report.Design()
                ElseIf nIslem = 1 Then
                    report.Print()
                ElseIf nIslem = 3 Then
                    report.PrintSettings.ShowDialog = False
                    report.Print()
                End If
                report.Dispose()
                report = Nothing
            End If
        End If
    End Sub
    Private Sub raporla_2(ByVal rapor As Integer, ByVal nIslem As Integer, Optional ByVal bDirekt As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.frx) |Form*.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Etiket Talep"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form.frx"
        If belgetipi = 0 Then
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form_talep.frx"
        ElseIf belgetipi = 1 Then
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form_lojistik.frx"
        ElseIf belgetipi = 2 Then
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form_transfer.frx"
        End If
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            Dim ds_Siparis As DataSet
            ds_Siparis = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT HAREKET.*, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN( 'T','DC') ) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonSatisTarihi, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.lGirisMiktar1 , 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisMiktari, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Mevcut,(SELECT isnull(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Satilan, (SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.nStokID = HAREKET.STOKNO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY stok.sKodu) AS Bekleyen FROM ASTOKETIKETTALEPDETAY HAREKET INNER JOIN ASTOKETIKETTALEPBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE (HAREKET.EVRAKNO = " & belgeind & ") ORDER BY HAREKET.STOKKODU"), "Siparis")
            dataload_baslik()
            report.RegisterData(ds_baslik)
            report.RegisterData(ds_hareket)
            report.RegisterData(ds_Siparis)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("dteFisTarihi", dr_baslik("TARIH"))
            report.SetParameterValue("sFisNo", dr_baslik("BELGENO"))
            report.SetParameterValue("sFisTipi", Me.Text)
            report.ScriptLanguage = Language.Vb
            report.PrintSettings.Collate = False
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 2 Then
                report.Design()
            ElseIf nIslem = 1 Then
                report.Print()
            ElseIf nIslem = 3 Then
                report.PrintSettings.ShowDialog = False
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " WHERE BASLIK.IND > 0"
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Etiket Talep"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Etiket Talep\Form.fr3"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
        file = Nothing
        kriter = Nothing
    End Sub
    Private Sub raporla_direkt(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " WHERE BASLIK.IND > 0"
        Dim dot_matrix As String
        Try
            dot_matrix = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DOTMATRIX").ToString
        Catch ex As Exception
            dot_matrix = "True"
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DOTMATRIX", "True")
        End Try
        Try
            If dot_matrix = "True" Then
                If belgetipi = 2 Then
                    file = "c:\Formlar\Raporlar\Etiket Talep\transfer_formu_dot.fr3"
                Else
                    file = "c:\Formlar\Raporlar\Etiket Talep\talep_formu_dot.fr3"
                End If
            Else
                If belgetipi = 2 Then
                    file = "c:\Formlar\Raporlar\Etiket Talep\transfer_formu.fr3"
                Else
                    file = "c:\Formlar\Raporlar\Etiket Talep\talep formu.fr3"
                End If
            End If
        Catch ex As Exception
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DOTMATRIX", "True")
            If belgetipi = 2 Then
                file = "c:\Formlar\Raporlar\Etiket Talep\transfer_formu_dot.fr3"
            Else
                file = "c:\Formlar\Raporlar\Etiket Talep\talep_formu_dot.fr3"
            End If
        End Try
        report_create_stok(file, kriter, islem)
        file = Nothing
        kriter = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        miktar = 1
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            If dr_baslik("SONUC") = "Sipariþ Talebi..." Then
                qr_hareket = frx.FindObject("qr_hareket")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT HAREKET.*, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN( 'T','DC') ) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonSatisTarihi, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.lGirisMiktar1 , 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisMiktari, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Mevcut,(SELECT isnull(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Satilan, (SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.nStokID = HAREKET.STOKNO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY stok.sKodu) AS Bekleyen FROM ASTOKETIKETTALEPDETAY HAREKET INNER JOIN ASTOKETIKETTALEPBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE (HAREKET.EVRAKNO = " & belgeind & ") ORDER BY HAREKET.STOKKODU")
                qr_baslik = frx.FindObject("qr_baslik")
                qr_baslik.Query = sorgu_query("set transaction isolation level read uncommitted SELECT BASLIK.*, DEPO.sAciklama AS sDepoAciklama, TDEPO.sAciklama AS sTDepoAciklama FROM ASTOKETIKETTALEPBASLIK BASLIK LEFT OUTER JOIN tbDepo TDEPO ON BASLIK.TDEPO = TDEPO.sDepo LEFT OUTER JOIN tbDepo DEPO ON BASLIK.DEPO = DEPO.sDepo WHERE BASLIK.IND =" & belgeind & "")
            Else
                qr_hareket = frx.FindObject("qr_hareket")
                'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT     *,(SELECT     TOP 1 sBarkod FROM          tbStokBarkodu  WHERE      nStokID = ASTOKETIKETTALEPDETAY.STOKNO) AS sBarkod FROM         ASTOKETIKETTALEPDETAY WHERE EVRAKNO =" & belgeind & " ORDER BY IND")
                qr_hareket.Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT HAREKET.*, dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.IND")
                qr_baslik = frx.FindObject("qr_baslik")
                qr_baslik.Query = sorgu_query("set transaction isolation level read uncommitted SELECT BASLIK.*, DEPO.sAciklama AS sDepoAciklama, TDEPO.sAciklama AS sTDepoAciklama FROM ASTOKETIKETTALEPBASLIK BASLIK LEFT OUTER JOIN tbDepo TDEPO ON BASLIK.TDEPO = TDEPO.sDepo LEFT OUTER JOIN tbDepo DEPO ON BASLIK.DEPO = DEPO.sDepo WHERE BASLIK.IND =" & belgeind & "")
            End If
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            frx.PrintOptions.Collate = False
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
                dr_baslik("KOD5") = "Yazdýrýldý..."
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
                dr_baslik("KOD5") = "Yazdýrýldý..."
            End If
            qr_baslik = Nothing
            qr_hareket = Nothing
            qr_connection = Nothing
            frx = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(4) = "" & status.ToString() & ""
            args(5) = "4"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            If dr_baslik("SONUC") = "Sipariþ Talebi..." Then
                args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT HAREKET.*, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN( 'T','DC') ) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonSatisTarihi, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.lGirisMiktar1 , 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = HAREKET.STOKNO AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisMiktari, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Mevcut,(SELECT isnull(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND HAREKET.STOKNO = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteFisTarihi <= BASLIK.TARIH) AS Satilan, (SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.nStokID = HAREKET.STOKNO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY stok.sKodu) AS Bekleyen FROM ASTOKETIKETTALEPDETAY HAREKET INNER JOIN ASTOKETIKETTALEPBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE (HAREKET.EVRAKNO = " & belgeind & ") ORDER BY HAREKET.STOKKODU") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT BASLIK.*, DEPO.sAciklama AS sDepoAciklama, TDEPO.sAciklama AS sTDepoAciklama FROM ASTOKETIKETTALEPBASLIK BASLIK LEFT OUTER JOIN tbDepo TDEPO ON BASLIK.TDEPO = TDEPO.sDepo LEFT OUTER JOIN tbDepo DEPO ON BASLIK.DEPO = DEPO.sDepo WHERE BASLIK.IND =" & belgeind & "") & ""
                args(3) = "qr_hareketéqr_baslik"
            Else
                args(2) = "" & sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT HAREKET.*, dbo.ROUNDYTL(HAREKET.MIKTAR / HAREKET.lBirimMiktar) AS lMiktar, tbStok.sBirimCinsi1, tbStok.sBirimCinsi2, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan FROM ASTOKETIKETTALEPDETAY HAREKET LEFT OUTER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID WHERE EVRAKNO =" & belgeind & " ORDER BY HAREKET.IND") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT BASLIK.*, DEPO.sAciklama AS sDepoAciklama, TDEPO.sAciklama AS sTDepoAciklama FROM ASTOKETIKETTALEPBASLIK BASLIK LEFT OUTER JOIN tbDepo TDEPO ON BASLIK.TDEPO = TDEPO.sDepo LEFT OUTER JOIN tbDepo DEPO ON BASLIK.DEPO = DEPO.sDepo WHERE BASLIK.IND =" & belgeind & "") & ""
                args(3) = "qr_hareketéqr_baslik"
            End If
            processYol = args(0)
            For i As Integer = 1 To 13
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
                If status = 1 Then
                    dr_baslik("KOD5") = "Yazdýrýldý..."
                ElseIf status = 3 Then
                    dr_baslik("KOD5") = "Yazdýrýldý..."
                End If
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub sec_fiyat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_fiyat.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Right Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Down Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Left Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        End If
    End Sub
    Private Sub sec_oran_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_oran.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Right Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Down Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Left Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        End If
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Vgrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        raporla(0, 2)
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla(0, 0)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla(0, 1)
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        calc()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        analiz_envanter()
    End Sub
    Public Sub calc()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If GridView1.FocusedColumn.OptionsColumn.AllowEdit = True Then
                dr(GridView1.FocusedColumn().FieldName) = frm.CalcEdit1.EditValue
                girdi_tutar_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub analiz_envanter()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokno = dr("STOKNO")
        frm.stokkodu = dr("STOKKODU")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_envanter_model()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter_model
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.modelno = dr("MODEL")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("STOKKODU")
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
            frm.Label1.Text = dr("MALINCINSI") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Me.Text & Sorgu_sDil(" Ekranýndan Çýkmak Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        raporla_etiket(0)
    End Sub
    Private Sub raporla_etiket(ByVal nIslem As Integer, Optional ByVal bDirekt As Boolean = False, Optional ByVal bMiktarli As Integer = 1)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol(True)
                    report_create_stok(sFile, kriter, nIslem, sorgu_sayi(dr("MIKTAR") * bMiktarli, 1), sorgu_sayi(dr("FIYAT1"), 0), sorgu_sayi(dr("FIYAT2"), 0), sorgu_sayi(dr("FIYAT3"), 0), sorgu_sayi(dr("FIYAT4"), 0), sorgu_sayi(dr("FIYAT5"), 0))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In ds_hareket.Tables(0).Rows
                        report_create_stok(sFile, " WHERE stok.nStokId =" & dr1("STOKNO") & "", nIslem, sorgu_sayi(dr1("MIKTAR") * bMiktarli, 1), sorgu_sayi(dr1("FIYAT1"), 0), sorgu_sayi(dr1("FIYAT2"), 0), sorgu_sayi(dr1("FIYAT3"), 0), sorgu_sayi(dr("FIYAT4"), 0), sorgu_sayi(dr("FIYAT5"), 0))
                    Next
                End If
                sFile = Nothing
                kriter = Nothing
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol(True)
                    report_create(nIslem, sFile, kriter, sorgu_sayi(dr("MIKTAR") * bMiktarli, 1))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In ds_hareket.Tables(0).Rows
                        report_create(nIslem, sFile, " WHERE stok.nStokId =" & dr1("STOKNO") & "", sorgu_sayi(dr1("MIKTAR") * bMiktarli, 1))
                    Next
                End If
                sFile = Nothing
                kriter = Nothing
            End If
        End If
    End Sub
    Private Sub report_create(ByVal nIslem As Integer, ByVal sFile As String, ByVal kriter As String, Optional ByVal bMiktarli As Integer = 1)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS FIYAT5, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok "), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
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
        ds_etiket = Nothing
        report.Dispose()
        report = Nothing
    End Sub
    Private Sub raporla_etiket1(ByVal islem As Integer)
        Dim file As String
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim fiyat4 As Decimal = 0
        Dim fiyat5 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            fiyat1 = dr("FIYAT1")
            fiyat2 = dr("FIYAT2")
            fiyat3 = dr("FIYAT3")
            fiyat4 = dr("FIYAT4")
            fiyat5 = dr("FIYAT5")
            miktar = dr("MIKTAR")
            report_create_stok(file, satir_kontrol(True), islem, miktar, fiyat1, fiyat2, fiyat3, fiyat4, fiyat5)
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        fiyat4 = Nothing
        fiyat5 = Nothing
        miktar = Nothing
    End Sub
    'Private Function satir_kontrol()
    '    Dim satir As String = "WHERE stok.nStokId IN ("
    '    Dim s As String
    '    Dim arr As Integer()
    '    Dim i As Integer
    '    Dim toplamsayi = GridView1.SelectedRowsCount
    '    Dim sayi = 0
    '    arr = GridView1.GetSelectedRows()
    '    Dim dr1 As DataRow
    '    If arr Is Nothing Then
    '    Else
    '        arr.Sort(arr)
    '        For Each i In arr
    '            s = i.ToString
    '            dr = ds_hareket.Tables(0).NewRow
    '            dr1 = GridView1.GetDataRow(s)
    '            satir += dr1("STOKNO").ToString
    '            sayi += 1
    '            If sayi < toplamsayi Then
    '                satir += ","
    '            ElseIf sayi = toplamsayi Then
    '                satir += ")"
    '            End If
    '        Next
    '    End If
    '    Return satir
    'End Function
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal, ByVal fiyat4 As Decimal, ByVal fiyat5 As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("PESIN", "" & fiyat1 & "")
            frx.SetVariable("ALTIAY", "" & fiyat2 & "")
            frx.SetVariable("ONAY", "" & fiyat3 & "")
            frx.SetVariable("FIYAT4", "" & fiyat4 & "")
            frx.SetVariable("FIYAT5", "" & fiyat5 & "")
            frx.SetVariable("FIYAT", "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2), FormatNumber(fiyat4, 2), FormatNumber(fiyat5, 2)) & "'")
            'frx.SetVariable("HD_PESIN_tl", "" & fiyat_gizle(FormatNumber(fiyat1, 2)).ToString & "")
            'frx.SetVariable("HD_ALTIAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat2, 2)).ToString & "")
            'frx.SetVariable("HD_ONAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat3, 2)).ToString & "")
            qr_hareket = frx.FindObject("qr_hareket")
            'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKisaAdi,stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama, tbSSinif2.sAciklama, tbSSinif3.sAciklama, tbSSinif4.sAciklama, tbSSinif5.sAciklama, tbSSinif6.sAciklama, tbSSinif7.sAciklama, tbSSinif8.sAciklama, tbSSinif9.sAciklama, tbSSinif10.sAciklama")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS FIYAT5, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok")
            'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
            'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
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
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_baslik = Nothing
            qr_hareket = Nothing
            qr_connection = Nothing
            frx = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS FIYAT5, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok") & ""
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
            args(14) = "PESIN"
            args(15) = "" & fiyat1 & ""
            args(16) = "ALTIAY"
            args(17) = "" & fiyat2 & ""
            args(18) = "ONAY"
            args(19) = "" & fiyat3 & ""
            args(20) = "FIYAT"
            args(21) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2), FormatNumber(fiyat4, 2), FormatNumber(fiyat5, 2)) & "'"
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
    Private Function fiyat_gizle_tumu(ByVal fiyat1 As String, ByVal fiyat2 As String, ByVal fiyat3 As String, ByVal fiyat4 As String, ByVal fiyat5 As String)
        Dim deger1 As String
        Dim deger2 As String
        Dim deger3 As String
        Dim deger4 As String
        Dim deger5 As String
        deger1 = fiyat_gizle(FormatNumber(fiyat1, 2)).ToString
        deger2 = fiyat_gizle(FormatNumber(fiyat2, 2)).ToString
        deger3 = fiyat_gizle(FormatNumber(fiyat3, 2)).ToString
        deger4 = fiyat_gizle(FormatNumber(fiyat4, 2)).ToString
        deger5 = fiyat_gizle(FormatNumber(fiyat5, 2)).ToString
        Return deger1 + "-" + deger2 + "-" + deger3 + "-" + deger4 + "-" + deger5
        deger1 = Nothing
        deger2 = Nothing
        deger3 = Nothing
        deger4 = Nothing
        deger5 = Nothing
    End Function
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        raporla_etiket(2)
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        raporla_etiket(1)
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        raporla_etiket(3, True)
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirEkleEnvanterli.Click
        If dr_baslik("IND") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            satir_ekle_stok(False, "", True)
            Timer1.Enabled = True
        ElseIf dr_baslik("IND") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Ürün Talep Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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
                satir_ekle_stok(False)
            Else
                If Len(txt_ara.Text) > 1 Then
                    If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoliDagilimi WHERE     (sKoliKodu = '" & txt_ara.Text & "')") = 0 Then
                        stok_ara()
                    Else
                        satir_ekle_stok_koli(txt_ara.Text)
                    End If
                End If
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            GridView1.FocusedColumn = colMIKTAR
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Talep Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.Enter Then
        '    If Trim(txt_ara.Text) <> "" Then
        '        Label4.Text = "Barkod Standardý Kontrol Ediliyor..."
        '        Label4.Refresh()
        '               '        If IsNumeric(Trim(txt_ara.Text)) = True Then
        '            If Len(Trim(txt_ara.Text).ToString) < 2 Then
        '                txt_ara.Text = Trim(txt_ara.Text) + "  "
        '            End If
        '            If Trim((Trim(txt_ara.Text)).Substring(0, 2)) = sBarcodeStd Then
        '                Dim deger = Trim(Trim(txt_ara.Text))
        '                If IsNumeric(deger) = True Then
        '                    mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
        '                    txt_ara.Text = deger.substring(2, 5)
        '                End If
        '            Else
        '                mevcut = 1
        '            End If
        '        Else
        '            If CStr(Trim(txt_ara.Text).ToString) <> "" Then
        '                x = (Trim(txt_ara.Text)).IndexOf("*", 1, (Trim(txt_ara.Text)).Length - 1)
        '                If x = -1 Then
        '                    mevcut = 1
        '                Else
        '                    mevcut = (Trim(txt_ara.Text)).Substring(0, x)
        '                    txt_ara.Text = (Trim(txt_ara.Text)).Substring((x + 1), (Trim(txt_ara.Text)).Length - (x + 1))
        '                    If IsNumeric(Trim(txt_ara.Text)) Then
        '                    Else
        '                    End If
        '                End If
        '            End If
        '        End If
        '        
        '        Label4.Text = "Barkod Standardý Kontrolü Tamamlandý..."
        '        Label4.Refresh()
        '        stok_kontrol()
        '    End If
        'ElseIf e.KeyCode = Keys.F6 Then
        'End If
    End Sub
    Private Sub stok_ara()
        mevcut = 1
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
    'Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
    '    Dim kriter
    '    kriter = "WHERE (Stok.sKodu = '" & kod & "') or (Barcode.sBarkod ='" & kod & "') "
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    conn.ConnectionString = connection
    '    cmd.Connection = conn
    '    conn.Open()
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok Stok INNER JOIN  tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & "")
    '    Dim kayitsayisi = cmd.ExecuteScalar
    '    Return kayitsayisi
    'End Function
    'Private Sub dataload_stok(ByVal kod As String)
    '    Dim kriter
    '    kriter = "WHERE (Stok.sKodu = '" & kod & "') or (barkod.sBarkod ='" & kod & "') "
    '    'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     Stok.nStokID AS StokNo, Stok.sKodu AS StokKodu, Stok.sAciklama AS Malincinsi, Barcode.sBarkod AS Barcode FROM         tbStok Stok INNER JOIN                       tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & ""))
    '    'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sBeden, stok.sModel, barkod.sBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY, tbRenk.sRenkAdi, stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & ") AS T  ORDER BY sKodu"))
    '    ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sBeden, stok.sModel, barkod.sBarkod,  tbRenk.sRenkAdi, stok.sRenk,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & ") AS T  ORDER BY sKodu"))
    'End Sub
    Private Sub stok_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Stok Kartý Kontrolü Yapýlýyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_stok_kontrol(txt_ara.EditValue, sec_kriter.Text)
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
            'dataload_tbstok(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Stok Bilgisi Yükleniyor... "
            Label4.Refresh()
            satir_ekle_stok_tek(False)
            Timer1.Enabled = True
        ElseIf kontrol > 1 Then
            satir_ekle_stok(False, Trim(txt_ara.Text))
            Label4.Text = "Stok Satýra Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Private Sub stok_yeni(Optional ByVal sBarkod As String = "")
        If KayitSiniri_kontrol("tbStok", "", nKayitSinir) = True Then
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
        End If
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        If dr_baslik("KOD5") = "Yazdýrýldý..." Then
            If XtraMessageBox.Show(Sorgu_sDil("Bu Belge Daha Önceden Yazdýrýlmýþ! Tekrar Yazdýrmak Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                raporla_direkt(0, 3)
            End If
        Else
            raporla_direkt(0, 3)
            If belgetipi = 2 Then
                If dr_baslik("TRANSFER") = False Then
                    entegre()
                End If
            End If
            If DevExpress.XtraEditors.XtraMessageBox.Show("Yazdýrýlmýþ Belgede Deðiþiklik Yapamazsýnýz...Yeni Form Oluþturmak Ýster misiniz..?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                'Yeni Talep Formu Aç
                Timer1.Enabled = False
                toplam_hesapla()
                baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO").ToString, 1, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
                baslik_teslim_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO").ToString, 1, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
                Timer1.Enabled = True
                baslik_yeni()
                Try
                    loaded()
                Catch ex As Exception
                    Me.Close()
                End Try
                Try
                    'gorunum_yukle()
                Catch ex As Exception
                End Try
                Try
                    dataload_hareket()
                Catch ex As Exception
                End Try
                Timer1.Enabled = True
            Else
                Me.Close()
            End If
        End If
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
            'If GridView1.FocusedRowHandle = 0 Then
            '    Vgrid_baslik.Focus()
            '    Vgrid_baslik.FocusedRecordCellIndex = rowKOD1.Index
            'ElseIf GridView1.RowCount = 0 Then
            '    Vgrid_baslik.Focus()
            'End If
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & "/Satýr :" & GridView1.FocusedRowHandle + 1 & " /Seçili :" & GridView1.SelectedRowsCount & "/Miktar: " & miktar
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & "/Satýr :" & GridView1.FocusedRowHandle + 1 & "/Miktar: " & miktar
        Else
            Label5.Text = ""
        End If
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Try
            dr_baslik("SONUC") = Sorgu_sDil("Tamamlandý...", sDil)
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub stok()
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.Show()
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        stok()
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        dataload_harekets()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkleAlis.ItemClick
        satir_ekle_stok_alislar(False)
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkleTransfer.ItemClick
        satir_ekle_stok_transfer(False)
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        txt_ara.Focus()
        txt_ara.SelectAll()
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
            kriter = " WHERE tbStok.nStokID IN (Select nStokID from tbStokBarkodu Where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStokBarkodu.sBarkod,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS FIYAT4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'), 0) AS FIYAT5, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
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
                ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStokBarkodu.sBarkod,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS FIYAT4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'), 0) AS FIYAT5, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,(SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
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
                    ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStokBarkodu.sBarkod,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS FIYAT4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'), 0) AS FIYAT5, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
                    kayitsayisi = 1
                ElseIf nAciklamaSayisi = 0 Then
                    kriter = "Where (tbStok.nStokID IN(select nStokID from tbStokFisiSeriNo where sSeri " & sorgu_kriter_string(ara, ara_kriter) & "))"
                    If sStokSinirla <> "" Then
                        kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                    End If
                    ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sModel,tbStokBarkodu.sBarkod,tbStok.sKodu,tbStok.sAciklama,tbStok.sBirimCinsi1,tbStok.nFiyatlandirma, tbStok.bEksiyeDusulebilirmi,tbStok.bEksideUyarsinmi,tbStok.nIskontoYuzdesiAV,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS FIYAT4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'), 0) AS FIYAT5, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT top 1 sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, tbStok.sRenk,tbStok.sBeden,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 " & kriter & ""))
                    kayitsayisi = 1
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
    Public Function sorgu_nStokID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_stok_sAciklama(ByVal kod As String) As String
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sAciklama, 0) AS sAciklama FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_tbstok(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbStok.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS FIYAT4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'), 0) AS FIYAT5, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
    End Sub
    Private Sub dataload_fis_master(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        ds_stok_fisi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokFisiMaster " & kriter & ""))
    End Sub
    Private Sub dataload_fis_detay(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (tbStokFisiDetayi.sFisTipi = '" & sFistipi & "') and (tbStokFisiDetayi.dteFisTarihi = '" & dteFisTarihi & "') and (tbStokFisiDetayi.lFisNo = '" & lFisno & "') and (tbStokFisiDetayi.nFirmaID= '" & nFirmaID & "') and (tbStokFisiDetayi.nGirisCikis = '" & nGirisCikis & "')  "
        ds_stok_fisi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu FROM         tbStokFisiDetayi INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & ""))
    End Sub
    Private Sub dataload_fis_firma_hareket(ByVal sFistipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (sHangiUygulama = '" & sFistipi & "') and (dteIslemTarihi = '" & dteFisTarihi & "') and (sEvrakNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "')  "
        ds_stok_fisi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
    End Sub
    Private Sub fis_firma_hareket_degistir(ByVal sFistipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, ByVal ylFisno As String, ByVal ydteFisTarihi As DateTime)
        Dim kriter
        kriter = "WHERE (sHangiUygulama = '" & sFistipi & "') and (dteIslemTarihi = '" & dteFisTarihi & "') and (sEvrakNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbFirmaHareketi SET sEvrakNo= '" & ylFisno & "',sAciklama= 'Evrak No: " & ylFisno & "',dteIslemTarihi = '" & ydteFisTarihi & "',dteValorTarihi= '" & ydteFisTarihi & "'          " & kriter & "")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub fis_detay_degistir(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, ByVal ylFisno As String, ByVal ydteFisTarihi As DateTime)
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lFisNo= '" & ylFisno & "',dteIslemTarihi = '" & ydteFisTarihi & "',dteFisTarihi= '" & ydteFisTarihi & "'          " & kriter & "")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub fis_Master_degistir(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, ByVal ylFisno As String, ByVal ydteFisTarihi As DateTime)
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lFisNo= '" & ylFisno & "',dteFisTarihi = '" & ydteFisTarihi & "',dteValorTarihi= '" & ydteFisTarihi & "'          " & kriter & "")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub fis_Master_fisno_degistir(ByVal nstokFisiID As String)
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
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
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub siparis_nSiparisID_degistir(ByVal nSiparisID As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE     tbSiparisSiraNo SET              nSonID = '" & nSiparisID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub fis_Master_nCariHareketID_degistir(ByVal nCariHareketID As String)
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub dataload_fis_aciklama(ByVal nStokFisiID As String)
        Dim kriter
        kriter = "WHERE (nStokFisiID = '" & nStokFisiID & "') "
        ds_stok_fisi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM           tbStokFisiAciklamasi " & kriter & ""))
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
        kriter = "WHERE (sStokSinif = '" & sStokSinifi & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM          tbSSinif" & sinifno & " " & kriter & ""))
    End Sub
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_firma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub dataload_sRenk(ByVal sRenk As String)
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "') "
        ds_renk = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbRenk " & kriter & ""))
    End Sub
    Public Function sorgu_envanter(ByVal depo As String, ByVal nStokID As String) As Decimal
        Dim kriter
        kriter = "WHERE (sDepo = '" & depo & "')  and (nStokID = '" & nStokID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) AS Mevcut FROM         tbStokFisiDetayi " & kriter & "")
        Dim kayitsayisi As Decimal = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_stok_varmi(ByVal nStokID As Integer, Optional ByVal nSatir As Integer = -1) As Decimal
        Dim dr As DataRow
        Dim lMevcut As Decimal = 0
        Dim nSayi As Integer = 0
        For Each dr In ds_hareket.Tables(0).Rows
            If dr("STOKNO") = nStokID And nSayi <> nSatir Then
                lMevcut = lMevcut + dr("MIKTAR")
            End If
            nSayi += 1
        Next
        Return lMevcut
        dr = Nothing
        lMevcut = Nothing
        nSayi = Nothing
    End Function
    Public Function sorgu_firma_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True) As Int64
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection)
        If resmi = True Then
            conn.ConnectionString = connection
        ElseIf resmi = False Then
            conn.ConnectionString = connection
        End If
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_siparis_kontrol(ByVal nSiparisTipi As Int64, ByVal nFirmaID As Int64, ByVal lSiparisNo As Int64) As Int64
        Dim kriter
        kriter = "WHERE     (lSiparisNo = " & lSiparisNo & ") AND (nSiparisTipi = " & nSiparisTipi & ") AND (nFirmaID = " & nFirmaID & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(DISTINCT lSiparisNo),0) AS KAYIT FROM         tbSiparis " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nfirmaID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sDepo = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID,0) AS nFirmaID FROM         tbDepo " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nStokFisiID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokFisiID+1,0) AS nStokFisiID FROM         tbStokFisiMaster " & kriter & " Order by nStokFisiID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        'cmd = Nothing
        'adapter = Nothing
        Return 1
    End Function
    Public Function sorgu_nStokIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        'cmd = Nothing
        'adapter = Nothing
        Return 1
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nSiparisID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nSiparisID + 1, 0) AS nSiparisID  FROM         tbSiparis " & kriter & " ORDER BY nSiparisID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        'cmd = Nothing
        'adapter = Nothing
        Return 1
    End Function
    Public Function sorgu_Renk_kontrol(ByVal sRenk As String) As Int64
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbRenk " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_Sinif_kontrol(ByVal sSinifKodu As String, ByVal sinifno As Integer) As Int64
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM          tbSSinif" & sinifno & " " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function satir_kontrol_eski(Optional ByVal etiket As Boolean = False)
        Dim satir As String = " ("
        If etiket = True Then
            satir = "WHERE stok.nStokId IN ("
        End If
        Dim toplamsayi = GridView1.RowCount
        Dim sayi = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_hareket.Tables(0).Rows
            satir += dr1("STOKNO").ToString
            sayi += 1
            If sayi < toplamsayi Then
                satir += ","
            ElseIf sayi = toplamsayi Then
                satir += ")"
            End If
        Next
        Return satir
    End Function
    Private Function satir_kontrol(Optional ByVal etiket As Boolean = False)
        Dim satir As String = " ("
        If etiket = True Then
            satir = " WHERE stok.nStokId IN ("
        End If
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If etiket = True Then
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    satir += dr1("STOKNO").ToString
                    sayi += 1
                    If sayi < toplamsayi Then
                        satir += ","
                    ElseIf sayi = toplamsayi Then
                        satir += ")"
                    End If
                Next
            End If
        Else
            For Each dr1 In ds_hareket.Tables(0).Rows
                satir += dr1("STOKNO").ToString
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
    Private Function stok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStok                       (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', '" & nStokTipi & "', '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi2 & "', " & nIskontoYuzdesi & " , '" & sKdvTipi & "', " & nTeminSuresi & " , " & lAsgariMiktar & " , " & lAzamiMiktar & " , '" & sOzelNot & "', '" & nFiyatlandirma & "', '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & " , '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & " , " & bOTVVar & " , '" & sOTVTipi & "' , '" & nIskontoYuzdesiAV & "', '" & bEk1 & "', '" & nEk2 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbFirma                       (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & " , '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "',  '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & " , '" & sOzelNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function master_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As Int64, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, Optional ByVal bTransferGuncelle As Boolean = False) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2,nTransferFirmaID) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & "," & nTransferFirmaID & " )")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        If bTransferGuncelle = True And Trim(sFisTipi) = "T" Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiMaster Set lTransferFisiID = " & nStokFisiID & " Where nStokFisiID = " & lTransferFisiID & ""
            cmd.ExecuteNonQuery()
        End If
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function siparis_kaydet_yeni(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As Decimal, ByVal nKdvOrani As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Int64, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbSiparis (nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru) VALUES     ( " & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nSiparisID = cmd.ExecuteScalar
        Return nSiparisID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub siparis_aciklama_kaydet_yeni(ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbSiparisAciklamasi                       (nSiparisTipi, lSiparisNo, nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     (" & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function detay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal bTransferGuncelle As Boolean = False) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", '" & nSiparisID & "', '" & nReceteNo & "', '" & nTransferID & "', '" & sTransferDepo & "', " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", '" & nTransferFirmaID & "',  '" & nAlisverisID & "', '" & nStokFisiID & "', '" & nIrsaliyeFisiID & "', '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', '" & nTransferID & "', '" & sTransferDepo & "', " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", '" & nTransferFirmaID & "',  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        If bTransferGuncelle = True And Trim(sFisTipi) = "T" Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi Set nTransferID = " & nIslemID & " Where nIslemID = " & nTransferID & ""
            cmd.ExecuteNonQuery()
        End If
        Return nIslemID
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub aciklama_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
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
    Private Sub odemeplani_kaydet_yeni(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani                       (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     ('" & nStokFisiID & "', '" & dteVadeTarihi & "', " & lTutari & ", '" & sCariIslem & "', '" & nCariHareketID & "')")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim hareketno = cmd.ExecuteScalar
        con.Close()
        'Return hareketno
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function firmahareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        con.Close()
        Return nHareketID
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub stok_renk_kaydet_yeni(ByVal sRenk As String, ByVal sRenkAdi As String, ByVal lRenkNo As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbRenk                       (sRenk, sRenkAdi, lRenkNo) VALUES     ('" & sRenk & "', '" & sRenkAdi & "', '" & lRenkNo & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub stok_sinif_kaydet_yeni(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSSinif" & sinifno & "                       (sSinifKodu, sAciklama) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub stok_barkod_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As String, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu                       (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     ('" & nStokID & "', '" & sBarkod & "', '" & nKisim & "', '" & nFirmaID & "', '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub stok_siniflari_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi                       (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     ('" & nStokID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "', '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub firma_siniflari_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi                       (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
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
    Private Sub entegre_kontrol()
        If XtraMessageBox.Show(Sorgu_sDil("Belgenin Transfer Kaydýný Kontrol Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow
            Dim dr_stok As DataRow
            Dim dr_cari As DataRow
            Dim dr_stok_barkod As DataRow
            Dim dr_renk As DataRow
            Dim dr_stok_sinifi As DataRow
            Dim dr_stok_sinif As DataRow
            Dim fis_kayit_sayisi As Int64 = 0
            Dim Tfis_kayit_sayisi As Int64 = 0
            Dim stok_kayit_sayisi As Int64 = 0
            Dim cari_kayit_sayisi As Int64 = 0
            Dim renk_kayit_sayisi As Int64 = 0
            Dim sinif_kayit_sayisi As Int64 = 0
            Dim barkod_var As Boolean = False
            Dim nStokID As Int64 = 0
            Dim nFirmaID As Int64 = 0
            Dim TnFirmaID As Int64 = 0
            Dim nStokFisiID As Int64 = 0
            Dim TnStokFisiID As Int64 = 0
            Dim nIslemID As Int64 = 0
            Dim TnIslemID As Int64 = 0
            Dim nHareketID As Int64 = 0
            Dim kayittarihi As DateTime = Now
            nFirmaID = sorgu_nfirmaID(dr_baslik("DEPO"))
            TnFirmaID = sorgu_nfirmaID(dr_baslik("TDEPO"))
            'MsgBox(nFirmaID & vbTab & TnFirmaID)
            fis_kayit_sayisi = sorgu_fis_kontrol("T", 3, dr_baslik("TARIH"), dr_baslik("IND"), nFirmaID)
            Tfis_kayit_sayisi = sorgu_fis_kontrol("T", 1, dr_baslik("TARIH"), dr_baslik("IND"), TnFirmaID)
            If fis_kayit_sayisi = 0 And Tfis_kayit_sayisi = 0 Then
                'MsgBox(Sorgu_sDil("Fatura Kaydý Bulunumadý",sDil), MessageBoxIcon.Warning)
                nStokFisiID = sorgu_nStokFisiID()
                TnStokFisiID = nStokFisiID + 1
                Timer1.Enabled = False
                toplam_hesapla()
                nStokFisiID = master_kaydet_yeni(nStokFisiID, "T", dr_baslik("TARIH"), 3, dr_baslik("IND"), TnFirmaID, dr_baslik("DEPO"), dr_baslik("TARIH"), 0, 0, 0, miktar, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "NULL", "NULL", "NULL", "NULL", "NULL", "UC", 0, 1, TnStokFisiID, nFirmaID, dr_baslik("TDEPO"), 0, kullanici, kayittarihi, ".YTL..YKr.", 0, 0, 0, 0, 0, 0)
                TnStokFisiID = master_kaydet_yeni(TnStokFisiID, "T", dr_baslik("TARIH"), 1, dr_baslik("IND"), nFirmaID, dr_baslik("TDEPO"), dr_baslik("TARIH"), 0, 0, 0, miktar, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "NULL", "NULL", "NULL", "NULL", "NULL", "UC", 0, 1, nStokFisiID, TnFirmaID, dr_baslik("DEPO"), 0, kullanici, kayittarihi, ".YTL..YKr.", 0, 0, 0, 0, 0, 0, True)
                fis_Master_fisno_degistir(TnStokFisiID)
                aciklama_kaydet_yeni(nStokFisiID, "MaðazaEntegrasyon", kasiyer, dr_baslik("KOD1"), dr_baslik("ACIKLAMA"), "")
                aciklama_kaydet_yeni(TnStokFisiID, "MaðazaEntegrasyon", kasiyer, dr_baslik("KOD1"), dr_baslik("ACIKLAMA"), "")
                'dataload_fis_detay(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"))
                Dim dr_fhareket As DataRow
                For Each dr_fhareket In ds_hareket.Tables(0).Rows
                    nIslemID = sorgu_nStokIslemID()
                    TnIslemID = nIslemID + 1
                    'nStokID = sorgu_nStokID(Trim(dr_fhareket("sKodu")))
                    nStokID = dr_fhareket("STOKNO")
                    dr_fhareket("DEPO") = dr_baslik("TDEPO")
                    nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dr_baslik("TARIH"), TnFirmaID, 0, "T", dr_baslik("TARIH"), dr_baslik("IND"), 3, dr_baslik("DEPO"), 0, "", "", "", "", dr_baslik("TARIH"), 0, 0, 0, 0, 0, dr_fhareket("MIKTAR"), 0, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, "", 0, "NULL", 0, TnIslemID, dr_baslik("TDEPO"), 0, 0, "Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000", "UC", 0, dr_fhareket("ACIKLAMA"), kayittarihi, "", 0, 0, "", 0, 0, 0, nFirmaID, "NULL", nStokFisiID, "NULL", "", "T", 0, 0, 0, 0, kullanici, kayittarihi)
                    TnIslemID = detay_kaydet_yeni(TnIslemID, nStokID, dr_baslik("TARIH"), nFirmaID, 0, "T", dr_baslik("TARIH"), dr_baslik("IND"), 1, dr_baslik("TDEPO"), 0, "", "", "", "", dr_baslik("TARIH"), 0, dr_fhareket("MIKTAR"), 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, "", 0, "NULL", 0, nIslemID, dr_baslik("DEPO"), 0, 0, "Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000", "UC", 0, dr_fhareket("ACIKLAMA"), kayittarihi, "", 0, 0, "", 0, 0, 0, TnFirmaID, "NULL", TnStokFisiID, "NULL", "", "T", 0, 0, 0, 0, kullanici, kayittarihi, True)
                    fis_detay_fisno_degistir(TnIslemID)
                Next
                'dataload_fis_aciklama(dr_baslik("nStokFisiID"))
                'dr_fatura = ds_stok_fisi.Tables(0).Rows(0)
                'aciklama_kaydet_yeni(nStokFisiID, dr_fatura("sAciklama1"), dr_fatura("sAciklama2"), dr_fatura("sAciklama3"), dr_fatura("sAciklama4"), dr_fatura("sAciklama5"))
                'dataload_fis_firma_hareket(dr_baslik("sFisTipi"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"))
                'Dim dr_firma_hareket As DataRow
                'For Each dr_firma_hareket In ds_stok_fisi.Tables(0).Rows
                '    nHareketID = sorgu_nCariHareketID()
                '    firmahareketi_kaydet_yeni(nHareketID, nFirmaID, dr_firma_hareket("dteIslemTarihi"), dr_firma_hareket("dteValorTarihi"), dr_firma_hareket("sCariIslem"), dr_firma_hareket("sAciklama"), dr_firma_hareket("lBorcTutar"), dr_firma_hareket("lAlacakTutar"), dr_firma_hareket("sEvrakNo"), dr_firma_hareket("lVadeFarki"), dr_firma_hareket("sHangiUygulama"), dr_firma_hareket("sHareketTipi"), dr_firma_hareket("sKullaniciAdi"), dr_firma_hareket("dteKayitTarihi"), dr_firma_hareket("sDovizCinsi1"), dr_firma_hareket("lDovizMiktari1"), dr_firma_hareket("lDovizKuru1"), dr_firma_hareket("sDovizCinsi2"), dr_firma_hareket("lDovizMiktari2"), dr_firma_hareket("lDovizKuru2"), dr_firma_hareket("sSonKullaniciAdi"), dr_firma_hareket("dteSonUpdateTarihi"))
                '    odemeplani_kaydet_yeni(nStokFisiID, dr_baslik("dteFisTarihi"), Math.Abs(dr_firma_hareket("lBorcTutar") - dr_firma_hareket("lAlacakTutar")), dr_firma_hareket("sCariIslem"), nHareketID)
                '    fis_Master_nCariHareketID_degistir(nHareketID)
                'Next
                dr_baslik("TRANSFER") = 1
                dr_baslik("SONUC") = Sorgu_sDil("Tamamlandý...", sDil)
                If dr_baslik("TRANSFER") = True Then
                    Vgrid_baslik.Enabled = False
                    GridControl1.Enabled = False
                    GridControl1.ContextMenu = Nothing
                    BarSubItem3.Enabled = False
                    txt_ara.Enabled = False
                    btn_FisIptal.Enabled = False
                End If
                baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
                baslik_teslim_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            Else
                XtraMessageBox.Show(Sorgu_sDil("Transfer Kaydý Mevcut", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            fis_resmi_kayit_kontrol()
            XtraMessageBox.Show(Sorgu_sDil("Transfer Kayýt Kontrol Ýþlemi Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dr = Nothing
            dr_stok = Nothing
            dr_cari = Nothing
            dr_stok_barkod = Nothing
            dr_renk = Nothing
            dr_stok_sinifi = Nothing
            dr_stok_sinif = Nothing
            fis_kayit_sayisi = Nothing
            stok_kayit_sayisi = Nothing
            cari_kayit_sayisi = Nothing
            renk_kayit_sayisi = Nothing
            sinif_kayit_sayisi = Nothing
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub fis_resmi_kayit_kontrol(Optional ByVal state As Boolean = False)
        Dim fis_kayit_sayisi As Int64 = 0
        Dim cari_kayit_sayisi As Int64 = 0
        Dim nFirmaID As Int64 = 0
        Dim tnFirmaID As Int64 = 0
        Dim dr_cari As DataRow
        cari_kayit_sayisi = 1 'sorgu_firma_kontrol("")
        If cari_kayit_sayisi = 0 Then
            'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
            'dataload_cari(dr_baslik("sKodu"))
            'dr_cari = ds_firma.Tables(0).Rows(0)
            'nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), 0, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
            'firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
        Else
            nFirmaID = sorgu_nfirmaID(dr_baslik("DEPO"))
            tnFirmaID = sorgu_nfirmaID(dr_baslik("TDEPO"))
            'MsgBox(nFirmaID & vbTab & tnFirmaID)
            'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Var...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            fis_kayit_sayisi = sorgu_fis_kontrol("T", 1, dr_baslik("TARIH"), dr_baslik("IND"), nFirmaID)
            If fis_kayit_sayisi = 0 Then
                If state = False Then
                    entegre_kontrol()
                ElseIf state = True Then
                    dr_baslik("TRANSFER") = 0
                End If
            Else
                If dr_baslik("TRANSFER") = 0 Then
                    dr_baslik("TRANSFER") = 1
                End If
                Me.Text = Me.Text + " (Belgenin Transfer Kaydý Var...)"
                If dr_baslik("TRANSFER") = True Then
                    If state = True Then
                        XtraMessageBox.Show(Sorgu_sDil("Transfer Ýþlemi Yapýlmýþ Belgede Deðiþiklik Yapamazsýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    Vgrid_baslik.Enabled = False
                    'GridControl1.Enabled = True
                    GridView1.OptionsBehavior.ReadOnly = True
                    GridControl1.ContextMenu = Nothing
                    BarSubItem3.Enabled = False
                    txt_ara.Enabled = False
                    btn_FisIptal.Enabled = False
                End If
            End If
        End If
        fis_kayit_sayisi = Nothing
        fis_kayit_sayisi = Nothing
        cari_kayit_sayisi = Nothing
        nFirmaID = Nothing
        dr_cari = Nothing
    End Sub
    Private Sub siparis_kayit_kontrol(Optional ByVal state As Boolean = False)
        If sorgu_siparis_kontrol(2, dr_baslik("HESAPNO"), dr_baslik("IND")) = 0 Then
            Vgrid_baslik.Enabled = True
            GridControl1.Enabled = True
            GridControl1.ContextMenu = kisayol_hareket
            BarSubItem3.Enabled = True
            txt_ara.Enabled = True
            btn_FisIptal.Enabled = True
        Else
            If state = True Then
                XtraMessageBox.Show(Sorgu_sDil("Sipariþ Entegrasyon Ýþlemi Yapýlmýþ Belgede Deðiþiklik Yapamazsýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Vgrid_baslik.Enabled = False
            GridControl1.Enabled = False
            GridControl1.ContextMenu = Nothing
            BarSubItem3.Enabled = False
            txt_ara.Enabled = False
            btn_FisIptal.Enabled = False
        End If
    End Sub
    Private Sub entegre_kontrol_siparis()
        Dim dr As DataRow
        Dim nSiparisID As Int64 = 0
        If sorgu_siparis_kontrol(2, dr_baslik("HESAPNO"), dr_baslik("IND")) = 0 Then
            For Each dr In ds_hareket.Tables(0).Rows
                nSiparisID = sorgu_nSiparisID()
                nSiparisID = siparis_kaydet_yeni(nSiparisID, 2, dr_baslik("IND"), dr_baslik("HESAPNO"), dr("STOKNO"), dr_baslik("TARIH"), dr_baslik("TARIH"), "", 0, "", dr_baslik("KOD4"), "", dr("MIKTAR"), 0, 0, "", 0, 0, 0, 0, kullanici, Now, 0, 0, "", 0, dr("ACIKLAMA"), 0, "", 0, 0)
                siparis_nSiparisID_degistir(nSiparisID)
            Next
            Try
                siparis_aciklama_kaydet_yeni(2, dr_baslik("IND"), dr_baslik("HESAPNO"), "Entegrasyon", "", "", "", "")
            Catch ex As Exception
            End Try
            XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            siparis_kayit_kontrol(True)
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Mevcut", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'If state = True Then
            '    XtraMessageBox.Show(Sorgu_sDil("Transfer Ýþlemi Yapýlmýþ Belgede Deðiþiklik Yapamazsýnýz...",sDil), MessageBoxIcon.Warning)
            'End If
            'Vgrid_baslik.Enabled = False
            'GridControl1.Enabled = False
            'GridControl1.ContextMenu = Nothing
            'BarSubItem3.Enabled = False
            'txt_ara.Enabled = False
            'BarButtonItem4.Enabled = False
        End If
    End Sub
    Private Sub entegrasyon_kaldir_siparis()
        If XtraMessageBox.Show(Sorgu_sDil("Entegrasyon Kaldýný Silmek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If sorgu_siparis_kontrol(2, dr_baslik("HESAPNO"), dr_baslik("IND")) = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Entegrasyon Kaydý Bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                entegrasyon_kaydet_sil_siparis(2, dr_baslik("HESAPNO"), dr_baslik("IND"))
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                siparis_kayit_kontrol(True)
            End If
        End If
    End Sub
    Private Sub entegrasyon_kaldir()
        Dim nFirmaID As Int64 = 0
        Dim tnFirmaID As Int64 = 0
        Dim fis_kayit_sayisi As Int64 = 0
        nFirmaID = sorgu_nfirmaID(dr_baslik("DEPO"))
        tnFirmaID = sorgu_nfirmaID(dr_baslik("TDEPO"))
        'MsgBox(nFirmaID & vbTab & tnFirmaID)
        'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Var...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
        fis_kayit_sayisi = sorgu_fis_kontrol("T", 1, dr_baslik("TARIH"), dr_baslik("IND"), nFirmaID)
        If fis_kayit_sayisi = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Entegrasyon Kaydý Bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf fis_kayit_sayisi = 1 Then
            Dim ds_fis As DataSet
            Dim kriter
            kriter = "WHERE (sFisTipi = 'T') and (dteFisTarihi = '" & dr_baslik("TARIH") & "') and (lFisNo = '" & dr_baslik("IND") & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '1')  "
            ds_fis = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nStokFisiID, lTransferFisiID FROM         tbStokFisiMaster " & kriter & ""))
            If ds_fis.Tables(0).Rows.Count > 0 Then
                Dim dr1 As DataRow
                dr1 = ds_fis.Tables(0).Rows(0)
                'MsgBox(dr1("nStokFisiID") & vbTab & dr1("lTransferFisiID"))
                entegrasyon_kaydet_sil(dr1("nStokFisiID"), dr1("lTransferFisiID"), dr_baslik("TARIH"))
            End If
            dr_baslik("TRANSFER") = 0
            dr_baslik("SONUC") = Sorgu_sDil("Bekliyor...", sDil)
            If dr_baslik("TRANSFER") = True Then
                Vgrid_baslik.Enabled = True
                GridControl1.Enabled = True
                GridControl1.ContextMenu = ContextMenu
                BarSubItem3.Enabled = True
                txt_ara.Enabled = True
                btn_FisIptal.Enabled = True
            End If
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            baslik_teslim_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            XtraMessageBox.Show(Sorgu_sDil("Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function transfer_yapildimi_kontrol() As Integer
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kayitsayisi As Integer
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count(*) from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay where (baslik.IND = detay.EVRAKNO) and ((detay.BARCODE NOT IN(SELECT detay.BARCODE from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay where (baslik.IND = detay.EVRAKNO))) or (detay.MIKTAR = ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.IND = xdetay.EVRAKNO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGENO = baslik.BELGENO)), 0))) and baslik.BELGENO = '" & Trim(dr_baslik("BELGENO")) & "'"
        'cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count(*) from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay where (baslik.IND = detay.EVRAKNO) and ((detay.BARCODE IN(SELECT detay.BARCODE from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay where (baslik.IND = detay.EVRAKNO))) and (ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0)) <> 0) and baslik.BELGENO = '" & Trim(dr_baslik("BELGENO")) & "'"
        If Trim(dr_baslik("SONUC")) <> "Ürün Talebi..." And Trim(dr_baslik("SONUC")) <> "Sipariþ Talebi..." Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count(*) from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay where (baslik.IND = detay.EVRAKNO) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) group by BARCODE), 0) <> ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0))) and baslik.BELGENO = '" & Trim(dr_baslik("BELGENO")) & "'"
            kayitsayisi = cmd.ExecuteScalar()
        Else
            kayitsayisi = 0
        End If
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub entegre()
        If transfer_yapildimi_kontrol() = 0 Then
            If belgetipi = 2 Then
                Dim bDevam As Boolean = False
                If Trim(dr_baslik("DEPO")) = Trim(dr_baslik("TDEPO")) Then
                    bDevam = False
                    XtraMessageBox.Show(Sorgu_sDil("Giriþ ve Çýkýþ Depolarý Ayný Olamaz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    bDevam = True
                End If
                If bDevam = True Then
                    If Trim(dr_baslik("KOD1")) = "" Or Trim(dr_baslik("ACIKLAMA")) = "" Then
                        bDevam = False
                        XtraMessageBox.Show(Sorgu_sDil("Teslim Eden/Teslim Alan Bilgilerini Boþ Býrakamazsýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        bDevam = True
                    End If
                End If
                If bDevam = True Then
                    'If listbox1.Items.Contains(dr_baslik("DEPO")) = True And listbox1.Items.Contains(dr_baslik("TDEPO")) = True Then
                    fis_resmi_kayit_kontrol()
                    'End If
                End If
            ElseIf belgetipi = 0 Then
                If dr_baslik("SONUC") = "Sipariþ Talebi..." Then
                    If XtraMessageBox.Show(Sorgu_sDil("Sipariþ Entegrasyonu Yapmak Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        If sorgu_siparis_kontrol(2, dr_baslik("HESAPNO"), dr_baslik("IND")) = 0 Then
                            If firma() = 1 Then
                                entegre_kontrol_siparis()
                            End If
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Kayýt Mevcut", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            End If
        ElseIf bTransferTeslimatYok = True Then
            If belgetipi = 2 Then
                Dim bDevam As Boolean = False
                If Trim(dr_baslik("DEPO")) = Trim(dr_baslik("TDEPO")) Then
                    bDevam = False
                    XtraMessageBox.Show(Sorgu_sDil("Giriþ ve Çýkýþ Depolarý Ayný Olamaz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    bDevam = True
                End If
                If bDevam = True Then
                    If Trim(dr_baslik("KOD1")) = "" Or Trim(dr_baslik("ACIKLAMA")) = "" Then
                        bDevam = False
                        XtraMessageBox.Show(Sorgu_sDil("Teslim Eden/Teslim Alan Bilgilerini Boþ Býrakamazsýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        bDevam = True
                    End If
                End If
                If bDevam = True Then
                    'If listbox1.Items.Contains(dr_baslik("DEPO")) = True And listbox1.Items.Contains(dr_baslik("TDEPO")) = True Then
                    fis_resmi_kayit_kontrol()
                    'End If
                End If
            ElseIf belgetipi = 0 Then
                If dr_baslik("SONUC") = "Sipariþ Talebi..." Then
                    If XtraMessageBox.Show(Sorgu_sDil("Sipariþ Entegrasyonu Yapmak Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        If sorgu_siparis_kontrol(2, dr_baslik("HESAPNO"), dr_baslik("IND")) = 0 Then
                            If firma() = 1 Then
                                entegre_kontrol_siparis()
                            End If
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Kayýt Mevcut", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                End If
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Teslimat Fiþi Tamamlanmadý!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function firma() As Int64
        Dim sonuc = 0
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr_baslik("HESAPNO") = Trim(dr1("nFirmaID"))
            dr_baslik("HESAPADI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            baslik_teslim_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("SONUC"), dr_baslik("DEPO"), dr_baslik("TDEPO"), 0, dr_baslik("TRANSFER"), dr_baslik("HESAPNO"), dr_baslik("HESAPADI").ToString, dr_baslik("bKilitli"))
            sonuc = 1
        End If
        Return sonuc
        sonuc = Nothing
    End Function
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        dataload_harekets()
        Dim dr2 As DataRow
        For Each dr2 In ds_baslik.Tables(0).Rows
            If TalepDogrulamaKontrol(Trim(dr2("DEPO").ToString())) = True Then
                Dim dr As DataRow
                Dim hepsi As Boolean = True
                hepsi = TalepDogrulamaOnayi(dr_baslik("IND").ToString())
                If hepsi = True Then
                    hepsi = TeslimDogrulamaOnayi(dr_baslik("IND").ToString())
                End If
                'For Each dr In ds_hareket.Tables(0).Rows
                '    If dr("DogrulamaAdet") <> dr("MIKTAR") Then
                '        hepsi = False
                '    End If
                'Next
                If hepsi = False Then
                    MessageBox.Show("Talep Fiþi Doðrulanmadý!")
                Else
                    entegre()
                End If
            Else
                entegre()
            End If
        Next
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        If belgetipi = 2 Then
            If XtraMessageBox.Show(Sorgu_sDil("Entegrasyon Kaydýnýsý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                entegrasyon_kaldir()
            End If
        ElseIf belgetipi = 0 Then
            If dr_baslik("SONUC") = "Sipariþ Talebi..." Then
                entegrasyon_kaldir_siparis()
            End If
        End If
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        printlink3.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub analiz_mevcut()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_etikettalep_mevcut
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.magaza = Trim(dr_baslik("DEPO"))
            frm.liste = Trim(dr_baslik("KOD2"))
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_mevcut_transfer()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim fr As New frm_stok_etikettalep_liste
            fr.firmano = firmano
            fr.donemno = donemno
            fr.connection = connection
            fr.belgetipi = 2
            If fr.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim frm As New frm_stok_etikettalep_mevcut
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.magaza = Trim(dr_baslik("DEPO"))
                frm.liste = Trim(dr_baslik("KOD2"))
                frm.bTransfer = True
                frm.kullanici = kullanici
                frm.IND = dr_baslik("IND")
                frm.INDLER = fr.nIndler
                If yetki_kontrol(kullanici, "frm_stok_etikettalep_mevcut_transfer") = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
        End If
    End Sub
    Private Sub sBirimCinsi_sec(Optional ByVal bAktar As Boolean = False)
        Dim frm As New frm_tbStokBirim
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sModel = dr("MODEL").ToString
        frm.sBirimCinsi = dr("sBirimCinsi1").ToString
        frm.lMiktar = dr("MIKTAR")
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            If Integer.Parse(dr1("bTersOran").ToString()) = 1 Then
                dr("lBirimMiktar") = (1 / Double.Parse(dr1("lOran").ToString())).ToString()
            Else
                dr("lBirimMiktar") = dr1("lOran")
            End If
            dr("sBirimCinsi") = dr1("sBirimCinsi")
            dr1 = Nothing
            GridView1.UpdateCurrentRow()
            girdi_tutar_hesapla()
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("STOKNO")
            frm.sKodu = dr("STOKKODU")
            frm.sModel = dr("MODEL")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        Dim dot_matrix As String
        Try
            dot_matrix = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DOTMATRIX").ToString
        Catch ex As Exception
            dot_matrix = "True"
        End Try
        dot_matrix = InputBox("Dot Matrix Yazýcý Onayý", "Dot Matrix Yazýcý Onayý", dot_matrix).ToString
        If dot_matrix <> "" Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DOTMATRIX", dot_matrix)
        End If
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        analiz_mevcut()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirEkleYeniler.Click
        If dr_baslik("IND") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            satir_ekle_yeniler(False)
            Timer1.Enabled = True
        ElseIf dr_baslik("IND") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Ürün Talep Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirEkleDegisenler.Click
        If dr_baslik("IND") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            satir_ekle_degisenler(False)
            Timer1.Enabled = True
        ElseIf dr_baslik("IND") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Ürün Talep Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEklePaket.ItemClick
        satir_ekle_stok_terminal(False)
    End Sub
    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        If BarButtonItem35.Down = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            BarButtonItem35.Down = True
        ElseIf BarButtonItem35.Down = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            BarButtonItem35.Down = False
        End If
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        satir_birlestir()
    End Sub
    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        satis_takip()
    End Sub
    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub sec_sBirimCinsi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_sBirimCinsi.KeyDown
        If e.KeyCode = Keys.Space Then
            sBirimCinsi_sec(True)
        End If
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub fatura_import_txt()
        Dim frm As New frm_fatura_import_txt
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ds_imports As New DataSet
            ds_imports = sorgu_imports(kullanici)
            Dim dri As DataRow
            For Each dri In ds_imports.Tables(0).Rows
                If dri("sKodu") <> "" Then
                    txt_ara.Text = Trim(dri("sKodu"))
                ElseIf dri("sBarkod") <> "" Then
                    txt_ara.Text = Trim(dri("sBarkod"))
                End If
                If dri("lMiktar") <> 0 Then
                    bImport = True
                    bIFiyati = dri("lFiyat")
                    bITutari = dri("lTutar")
                    If frm.txt_lFiyati_Sutun.Text <> -1 Then
                        bImport_Fiyat = True
                    End If
                    If frm.txt_lTutari_Sutun.Text <> -1 Then
                        bImport_Tutari = True
                    End If
                    mevcut = dri("lMiktar")
                    stok_kontrol()
                End If
            Next
        End If
    End Sub
    Private Sub Entegre_fisi_duzelt()
        If belgetipi = 2 Then
            Dim dr As DataRow
            Dim ds_Entegre As DataSet = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select nStokFisiID,nFirmaID,sFisTipi,nGirisCikis,lFisNo,dteFisTarihi,sDepo,sTransferDepo from tbStokFisiMaster Where dteFisTarihi = '" & dr_baslik("TARIH") & "' AND sFisTipi = 'T' and nGirisCikis = 3 and lFisNo = " & dr_baslik("IND") & ""))
            If ds_Entegre.Tables(0).Rows.Count = 1 Then
                If XtraMessageBox.Show(Sorgu_sDil("Transfer Entegre Fiþini Açmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    dr = ds_Entegre.Tables(0).Rows(0)
                    fis_duzelt(dr("lFisNo"), dr("dteFisTarihi"), dr("sFisTipi"), dr("nFirmaID"), dr("nGirisCikis"), dr("nStokFisiID"))
                End If
            End If
        End If
    End Sub
    Private Sub fis_duzelt(ByVal lFisNo As Int64, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nFirmaID As Int64, ByVal nGirisCikis As Int64, ByVal nStokFisiID As Int64)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = lFisNo
            frm.dteFisTarihi = dteFisTarihi
            frm.sFisTipi = sFisTipi
            frm.nFirmaID = nFirmaID
            frm.nGirisCikis = nGirisCikis
            frm.nStokFisiID = nStokFisiID
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
    Private Function sorgu_imports(ByVal sKullanici As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFaturaImportTxt WHERE     (sKullanici = '" & sKullanici & "')")
        sorgu_txt_hareket = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "Imports")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        fatura_import_txt()
    End Sub
    Private Sub BarButtonItem4_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        satir_ekle_stok_alislar(False, False)
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
    End Sub
    Private Sub Menu_SatirSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirSil.Click
        If yetki_kontrol1(kullanici, "frm_Transfer_Sil") = True Then
            'If XtraMessageBox.Show(Me.Text & Sorgu_sDil(" Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            satir_sil()
            ' Me.Close()
        End If
        'End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        satir_degistir()
    End Sub
    Private Sub BarButtonItem5_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_mevcut_transfer()
    End Sub
    Private Sub BarButtonItem7_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Entegre_fisi_duzelt()
    End Sub
    Private Sub BarButtonItem27_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        siniflandir()
    End Sub
    Private Sub siniflandir()
        Dim frm As New frm_ozelkod_tanimla
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim nSinifNo As Integer = 1
            Dim sSinifKod As String = ""
            Dim sSinifAciklama As String = ""
            nSinifNo = frm.sec_sinifno.Text
            sSinifKod = frm.sec_satici.EditValue
            sSinifAciklama = frm.sec_satici.Text
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarýn " & nSinifNo & ".Sýnýf Kodlarýný [" & sSinifKod & "/" & sSinifAciklama & " ] olarak Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If
                bar.Properties.Maximum = GridView1.RowCount
                panelstatus.Visible = True
                bar.Visible = True
                bar.Position = 0
                For Each dr In ds_hareket.Tables(0).Rows
                    'dr("Sinif" & nSinifNo & "") = sSinifAciklama
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSinifi set sSinifKodu" & nSinifNo & " = '" & sSinifKod & "'  where nStokID in ( select nStokID from tbStok where sModel = '" & dr("MODEL") & "' )")
                    cmd.ExecuteNonQuery()
                    bar.Position += 1
                    bar.Refresh()
                Next
                con.Close()
                con = Nothing
                cmd = Nothing
                dr = Nothing
                panelstatus.Visible = False
                bar.Visible = False
                XtraMessageBox.Show(Sorgu_sDil("Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub fiyatlandir_toplu()
        Dim frm As New frm_stok_fiyatlandir_toplu
        Dim kaynak As String = ""
        Dim hedef As String = ""
        Dim oran As Integer = 0
        Dim tutar As Decimal = 0
        Dim degistir As Boolean = False
        Dim sFiyatTipi As String = ""
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dataload_harekets(True, True)
            Dim dr As DataRow
            oran = CType(frm.txtoran.EditValue, Decimal)
            tutar = CType(frm.txttutar.EditValue, Decimal)
            'kaynak = frm.seckaynak.EditValue
            'hedef = frm.sechedef.EditValue
            If frm.seckaynak.Text = "1.SatisFiyati" Then
                kaynak = "lFIYAT1"
            ElseIf frm.seckaynak.Text = "2.SatisFiyati" Then
                kaynak = "lFIYAT2"
            ElseIf frm.seckaynak.Text = "3.SatisFiyati" Then
                kaynak = "lFIYAT3"
            ElseIf frm.seckaynak.Text = "AlisFiyati" Then
                kaynak = "FIYATA"
            ElseIf frm.seckaynak.Text = "Maliyet" Then
                kaynak = "FIYATM"
            End If
            If frm.sechedef.Text = "1.SatisFiyati" Then
                hedef = "lFIYAT1"
                sFiyatTipi = sFiyat1
            ElseIf frm.sechedef.Text = "2.SatisFiyati" Then
                hedef = "lFIYAT2"
                sFiyatTipi = sFiyat2
            ElseIf frm.sechedef.Text = "3.SatisFiyati" Then
                hedef = "lFIYAT3"
                sFiyatTipi = sFiyat3
            ElseIf frm.sechedef.Text = "AlisFiyati" Then
                hedef = "FIYATA"
                sFiyatTipi = sFiyatA
            ElseIf frm.sechedef.Text = "Maliyet" Then
                hedef = "FIYATM"
                sFiyatTipi = sFiyatM
            End If
            If frm.seckriter.Text = "% olarak artýr" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ",  " & frm.seckaynak.Text & " üzerinden " & "% " & FormatNumber(oran, 2) & " oranýnda artacaktýr..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "tutar ile artýr" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ",  " & frm.seckaynak.Text & " üzerinden " & " " & FormatNumber(tutar, 2) & " tutarýnda artacaktýr..! Eminmisiniz ? ", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "tutar ile deðiþtir" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & " " & FormatNumber(tutar, 2) & " olarak deðiþecektir..! Eminmisiniz ? ", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "YTL 'ye uyarla" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ",  1,000,000 'a bölünecektir..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "Eski Fiyatý ile deðiþtir" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ", Eski Fiyatýyla deðiþecektir..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    XtraMessageBox.Show(Sorgu_sDil("Fiyat deðiþim iþleminden sonra listeyi yeniden oluþturmanýz gerekmektedir..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    degistir = True
                Else
                    degistir = False
                End If
            End If
            Dim sayi As Integer = 0
            If degistir = True Then
                sayi = 0
                For Each dr In ds_hareket.Tables(0).Rows
                    'If dr("SEC") = True Then
                    sayi += 1
                    'End If
                Next
                bar.Properties.Maximum = sayi
                'labelbar.Text = "Toplam Satýr Sayýsý : " & (sayi) & ""
                panelstatus.Visible = True
                bar.Visible = True
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                con.ConnectionString = connection
                cmd.CommandTimeout = False
                cmd.Connection = con
                sayi = 0
                For Each dr In ds_hareket.Tables(0).Rows
                    sayi += 1
                    If frm.seckriter.Text = "tutar ile deðiþtir" Then
                        tutar = frm.txttutar.EditValue
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            End If
                            dr("" & hedef & "") = tutar
                            Me.Refresh()
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "% olarak artýr" Then
                        oran = frm.txtoran.EditValue
                        tutar = dr("" & kaynak & "") * ((oran + 100) / 100)
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            End If
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "tutar ile artýr" Then
                        tutar = dr("" & kaynak & "") + frm.txttutar.EditValue
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            End If
                            dr("" & hedef & "") = tutar
                            Me.Refresh()
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "YTL 'ye uyarla" Then
                        tutar = dr("" & hedef & "") / 1000000
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("MODEL").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sFiyatTipi, tutar, Today)
                            End If
                            dr("" & hedef & "") = tutar
                            Me.Refresh()
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "Eski Fiyatý ile deðiþtir" Then
                        'con.Open()
                        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE *!FTBLBIRIMLEREX SET SATISFIYATI" & fiyat & " = ESKIFIYAT" & fiyat & " WHERE IND =" & dr("BIRIMNO") & "")
                        'Dim sonuc = cmd.ExecuteNonQuery
                        'If sonuc < 0 Then XtraMessageBox.Show(Sorgu_sDil("Hata Oluþtu")
                        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SATISFIYATI" & fiyat & " FROM *!FTBLBIRIMLEREX WHERE IND =" & dr("BIRIMNO") & "")
                        'sonuc = cmd.ExecuteScalar
                        'con.Close()
                        'dr("" & hedef & "") = sonuc
                        Me.Refresh()
                        bar.Position = sayi
                        bar.Refresh()
                    End If
                    Me.Refresh()
                Next
            End If
            frm.Dispose()
            frm.Close()
            kaynak = Nothing
            hedef = Nothing
            oran = Nothing
            tutar = Nothing
            degistir = Nothing
            panelstatus.Visible = False
            bar.Visible = False
            sFiyatTipi = Nothing
        End If
    End Sub
    Private Sub sKdvTipi_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKdvTipi as sKod,nKdvOrani as sAciklama FROM         tbKdv"
        frm.lbl_sKod.Text = "KdvTipi:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Stoklara Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If
                Dim sKdvTipi
                For Each dr In ds_hareket.Tables(0).Rows
                    sKdvTipi = frm.LookUpEdit1.EditValue
                    'dr("sKdvTipi") = sKdvTipi
                    'dr("nKdvOrani") = frm.LookUpEdit1.Text
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStok set sKdvTipi = '" & sKdvTipi & "'  where sModel = '" & dr("sModel") & "'")
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                con = Nothing
                cmd = Nothing
                dr = Nothing
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Function sorgu_tbStokFiyati_kontrol(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String) As Decimal
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kayitsayisi As Int64
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "' and tbStok.sRenk = '" & sRenk & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "'and tbStok.sRenk = '" & sRenk & "' and tbStok.sBeden = '" & sBeden & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        End If
        kayitsayisi = cmd.ExecuteScalar()
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & kullanici & "' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & kullanici & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & kullanici & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_duzelt(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden = '" & sBeden & "' "
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_sil(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub BarButtonItem27_ItemClick_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        siniflandir()
    End Sub
    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        siniflandir()
    End Sub
    Private Sub BarButtonItem28_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        fiyatlandir_toplu()
    End Sub
    Private Sub BarButtonItem34_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        sKdvTipi_toplu()
    End Sub
    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                bar.Properties.Maximum = GridView1.RowCount
                panelstatus.Visible = True
                bar.Visible = True
                bar.Position = 0
                For Each dr In ds_hareket.Tables(0).Rows
                    tbStok_sil(dr("MODEL"), False)
                    bar.Position += 1
                    bar.Refresh()
                Next
                'ds_hareket.Clear()
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                dr = Nothing
                panelstatus.Visible = False
                bar.Visible = False
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub tbStok_sil(ByVal sModel As String, Optional ByVal uyari As Boolean = True)
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
            cmd.CommandText = sorgu_query("delete tbStokSinifi from tbStok where tbStok.nStokID = tbStokSinifi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBarkodu from tbStok where tbStok.nStokID = tbStokBarkodu.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokFiyati from tbStok  where tbStok.nStokID = tbStokFiyati.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBirimCevrimi from tbStok where tbStok.nStokID = tbStokBirimCevrimi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokMuhasebeEntegrasyon from tbStok where tbStok.nStokID = tbStokMuhasebeEntegrasyon.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokOdemePlani from tbStok  where tbStok.nStokID = tbStokOdemePlani.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSayim from tbStok where tbStok.nStokID = tbStokSayim.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokDil from tbStok where tbStok.nStokID = tbStokDil.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokAciklama from tbStok where tbStok.nStokID = tbStokAciklama.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokUzunNot where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokResim where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokMuhasebeEntegrasyon where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbKoliDagilimi where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStok where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sModel,'') as sModel FROM         tbStok WHERE     (sModel < '" & sModel & "' ) ORDER BY sModel DESC ")
            'sModel = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sModel
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'stok_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub BarButtonItem42_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        fis_kopyala()
    End Sub
    Private Sub fis_kopyala()
        Dim frm As New frm_fatura_kopyala
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sFisTipi = belgetipi
        frm.nGirisCikis = 3
        frm.kapla = True
        frm.nFirmaID = 0
        frm.sKodu = ""
        frm.txt_musteriNo.EditValue = ""
        frm.lbl_Firma.Text = ""
        frm.txt_dteFisTarihi1.EditValue = dr_baslik("TARIH")
        frm.txt_lFisNo.Text = dr_baslik("BELGENO")
        frm.bTalep = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(dr_baslik("BELGENO") & Sorgu_sDil(" Nolu Fiþi ", sDil) & Sorgu_sDil(" Kopyalamaya Baþlamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dataset1 As New DataSet
                Dim dataset2 As New DataSet
                Dim dr As DataRow
                Dim dr1 As DataRow
                Dim belgetipi As Integer = frm.sec_sFisTipi.EditValue
                dataset1 = sorgu("Select * from ASTOKETIKETTALEPBASLIK WHERE IND = " & dr_baslik("IND") & "")
                dr = dataset1.Tables(0).Rows(0)
                Try
                    dr("BELGENO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
                Catch ex As Exception
                    dr("BELGENO") = "A-000001"
                End Try
                Dim IND As Int64 = baslik_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("SONUC"), dr("DEPO"), dr("TDEPO"), belgetipi, dr("AKTIF"), 0, 0, Now)
                baslik_teslim_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("SONUC"), dr("DEPO"), dr("TDEPO"), belgetipi, dr("AKTIF"), 0, 0, Now, IND)
                dataset2 = sorgu("SELECT HAREKET.*, tbStok.nStokID,tbStok.sKodu FROM ASTOKETIKETTALEPDETAY AS HAREKET INNER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID Where HAREKET.EVRAKNO =" & dr("IND") & " ")
                For Each dr1 In dataset2.Tables(0).Rows
                    hareket_kaydet_yeni(IND, dr1("nStokID"), dr1("STOKKODU"), dr1("MALINCINSI"), dr1("BARCODE"), dr1("RENK"), dr1("BEDEN"), dr1("MODEL"), dr1("ETIKET"), dr1("ACIKLAMA"), dr1("DEPO"), dr1("MIKTAR"), dr1("sFiyatTipi"), dr1("FIYAT1"), dr1("FIYAT2"), dr1("FIYAT3"), dr1("FIYAT4"), dr1("FIYAT5"), dr1("sBirimCinsi"), dr1("lBirimMiktar"))
                Next
                incele(belgetipi, IND)
            End If
        End If
    End Sub
    Private Sub incele(ByVal belgetipi As Integer, ByVal IND As Int64)
        Dim frm As New frm_stok_etikettalep
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kasiyer = kasiyer
        frm.kasiyerno = kasiyerno
        frm.belgetipi = belgetipi
        frm.belgeind = IND
        frm.status = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, belgetipi & frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub BarButtonItem43_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        dataload_harekets(True, False, True)
    End Sub
End Class
