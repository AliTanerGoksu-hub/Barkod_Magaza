Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_fiyat_degisim
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
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents kisayol_hareket As System.Windows.Forms.ContextMenu
    Friend WithEvents Menu_SatirEkleAlis As System.Windows.Forms.MenuItem
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
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
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
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIMMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIMFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISKONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKDVLITUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFATURAMIKTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFATURATUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALTIAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORANEKMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONALISMALIYETI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONCEKIALISMALIYETI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONCEKIALISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONALISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNETMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Menu_SatirEkleStok As System.Windows.Forms.MenuItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents collFiyat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnl_grid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_Ara As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents colORAN4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONBESAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowHATIRLAT As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents colFIYAT5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEFIYAT5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEFIYAT6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEFIYAT7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEFIYAT8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEFIYAT9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEFIYAT10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowbKilitli As DevExpress.XtraVerticalGrid.Rows.EditorRow
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_fiyat_degisim))
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
        Me.sec_depo_baslik = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_baslik_belgetipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBELGENO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKAYITTARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryAçýklama = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbKilitli = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowHATIRLAT = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
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
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.pnl_grid = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_hareket = New System.Windows.Forms.ContextMenu()
        Me.Menu_SatirEkleAlis = New System.Windows.Forms.MenuItem()
        Me.Menu_SatirEkleStok = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.Menu_SatirSil = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Menu_DegerYay = New System.Windows.Forms.MenuItem()
        Me.ds_hareket = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
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
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIMMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIMFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKDVLITUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFATURAMIKTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFATURATUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPESIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyat = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colALTIAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORANEKMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_oran = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colORAN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONALISMALIYETI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONCEKIALISMALIYETI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONCEKIALISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONALISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNETMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONUC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONBESAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFIYAT5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFIYAT6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFIYAT7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFIYAT8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFIYAT9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFIYAT10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_depo_hareket = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Panel_Ara = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
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
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FisIptal = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btn_SatirEkle = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirSil = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.ds_belgetipi = New System.Data.DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_baslik.SuspendLayout()
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_grid.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_oran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Ara.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_baslik
        '
        Me.Panel_baslik.Controls.Add(Me.Vgrid_baslik)
        Me.Panel_baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_baslik.Location = New System.Drawing.Point(0, 22)
        Me.Panel_baslik.Name = "Panel_baslik"
        Me.Panel_baslik.Size = New System.Drawing.Size(824, 136)
        Me.Panel_baslik.TabIndex = 0
        '
        'Vgrid_baslik
        '
        Me.Vgrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.Vgrid_baslik.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.Vgrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.Vgrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(648, 330, 208, 252)
        Me.Vgrid_baslik.DataMember = Nothing
        Me.Vgrid_baslik.DataSource = Me.ds_baslik
        Me.Vgrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vgrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.Vgrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.Vgrid_baslik.Name = "Vgrid_baslik"
        Me.Vgrid_baslik.RecordWidth = 209
        Me.Vgrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_depo_baslik, Me.sec_baslik_belgetipi})
        Me.Vgrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTanýmlar, Me.categoryAçýklama, Me.rowbKilitli, Me.rowHATIRLAT})
        Me.Vgrid_baslik.Size = New System.Drawing.Size(820, 132)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn7, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn17, Me.DataColumn60, Me.DataColumn61})
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
        Me.DataColumn60.ColumnName = "bKilitli"
        Me.DataColumn60.DataType = GetType(Byte)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "HATIRLAT"
        Me.DataColumn61.DataType = GetType(Date)
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
        '
        'rowBELGENO
        '
        Me.rowBELGENO.Name = "rowBELGENO"
        Me.rowBELGENO.Properties.Caption = "Belge No"
        Me.rowBELGENO.Properties.FieldName = "BELGENO"
        '
        'rowKAYITTARIHI
        '
        Me.rowKAYITTARIHI.Name = "rowKAYITTARIHI"
        Me.rowKAYITTARIHI.Properties.Caption = "Kayýt Tarihi"
        Me.rowKAYITTARIHI.Properties.FieldName = "KAYITTARIHI"
        Me.rowKAYITTARIHI.Visible = False
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.Properties.Caption = "BelgeTarihi"
        Me.rowTARIH.Properties.FieldName = "TARIH"
        '
        'categoryAçýklama
        '
        Me.categoryAçýklama.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowKOD1, Me.rowKOD2, Me.rowKOD3, Me.rowKOD4, Me.rowKOD5, Me.rowACIKLAMA})
        Me.categoryAçýklama.Name = "categoryAçýklama"
        Me.categoryAçýklama.Properties.Caption = "Açýklama"
        '
        'rowKOD1
        '
        Me.rowKOD1.Name = "rowKOD1"
        Me.rowKOD1.Properties.Caption = "1.ÖzelKod"
        Me.rowKOD1.Properties.FieldName = "KOD1"
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
        Me.rowKOD3.Properties.ReadOnly = True
        '
        'rowKOD4
        '
        Me.rowKOD4.Name = "rowKOD4"
        Me.rowKOD4.Properties.Caption = "4.ÖzelKod"
        Me.rowKOD4.Properties.FieldName = "KOD4"
        Me.rowKOD4.Properties.ReadOnly = True
        '
        'rowKOD5
        '
        Me.rowKOD5.Name = "rowKOD5"
        Me.rowKOD5.Properties.Caption = "5.ÖzelKod"
        Me.rowKOD5.Properties.FieldName = "KOD5"
        Me.rowKOD5.Properties.ReadOnly = True
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.Properties.Caption = "Açýklama"
        Me.rowACIKLAMA.Properties.FieldName = "ACIKLAMA"
        '
        'rowbKilitli
        '
        Me.rowbKilitli.Name = "rowbKilitli"
        Me.rowbKilitli.Properties.Caption = "Kilitli"
        Me.rowbKilitli.Properties.FieldName = "bKilitli"
        '
        'rowHATIRLAT
        '
        Me.rowHATIRLAT.Name = "rowHATIRLAT"
        Me.rowHATIRLAT.Properties.Caption = "HATIRLAT"
        Me.rowHATIRLAT.Properties.FieldName = "HATIRLAT"
        '
        'Panel_toplamlar
        '
        Me.Panel_toplamlar.Controls.Add(Me.Panel_satis_info)
        Me.Panel_toplamlar.Controls.Add(Me.Panel_depo_info)
        Me.Panel_toplamlar.Controls.Add(Me.Panel_toplam)
        Me.Panel_toplamlar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_toplamlar.Location = New System.Drawing.Point(0, 400)
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
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(7, 13)
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
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 19)
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
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 19)
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
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 158)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 6)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'Panel_hareketler
        '
        Me.Panel_hareketler.Controls.Add(Me.XtraTabControl1)
        Me.Panel_hareketler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_hareketler.Location = New System.Drawing.Point(0, 164)
        Me.Panel_hareketler.Name = "Panel_hareketler"
        Me.Panel_hareketler.Size = New System.Drawing.Size(824, 236)
        Me.Panel_hareketler.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 232)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panelstatus)
        Me.XtraTabPage1.Controls.Add(Me.pnl_grid)
        Me.XtraTabPage1.Controls.Add(Me.Panel_Ara)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 199)
        Me.XtraTabPage1.Text = "Stoklar"
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panelstatus.Appearance.Options.UseBackColor = True
        Me.Panelstatus.Controls.Add(Me.ProgressBarControl1)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(138, 45)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(542, 108)
        Me.Panelstatus.TabIndex = 12
        Me.Panelstatus.Visible = False
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(8, 73)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(518, 18)
        Me.ProgressBarControl1.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 50)
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
        Me.barlabel.Location = New System.Drawing.Point(8, 4)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 23)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(518, 18)
        Me.bar.TabIndex = 0
        '
        'pnl_grid
        '
        Me.pnl_grid.Controls.Add(Me.GridControl1)
        Me.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_grid.Location = New System.Drawing.Point(0, 0)
        Me.pnl_grid.Name = "pnl_grid"
        Me.pnl_grid.Size = New System.Drawing.Size(818, 170)
        Me.pnl_grid.TabIndex = 14
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_hareket
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_depo_hareket, Me.sec_fiyat, Me.sec_oran})
        Me.GridControl1.Size = New System.Drawing.Size(814, 166)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_hareket
        '
        Me.kisayol_hareket.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_SatirEkleAlis, Me.Menu_SatirEkleStok, Me.MenuItem2, Me.Menu_SatirSil, Me.MenuItem5, Me.Menu_DegerYay})
        '
        'Menu_SatirEkleAlis
        '
        Me.Menu_SatirEkleAlis.Index = 0
        Me.Menu_SatirEkleAlis.Text = "Satýr Ekle Alýþlar"
        '
        'Menu_SatirEkleStok
        '
        Me.Menu_SatirEkleStok.Index = 1
        Me.Menu_SatirEkleStok.Text = "Satýr Ekle Stoklar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Düzelt"
        '
        'Menu_SatirSil
        '
        Me.Menu_SatirSil.Index = 3
        Me.Menu_SatirSil.Text = "Satýr Sil"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "-"
        '
        'Menu_DegerYay
        '
        Me.Menu_DegerYay.Index = 5
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
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn8, Me.DataColumn9, Me.DataColumn16, Me.DataColumn18, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68})
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
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "STOKKODU"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "STOKADI"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FIRMAKODU"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FIRMAADI"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "FISTARIHI"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "FISNO"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "BIRIMMALIYET"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "BIRIMFIYAT"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ISKONTO"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "KDV"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "KDVLITUTAR"
        Me.DataColumn24.DataType = GetType(Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "FATURAMIKTARI"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "FATURATUTARI"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "EKMALIYET"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "RENK"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "PESIN"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ALTIAY"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "ONAY"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "ORANEKMALIYET"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "ORAN1"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ORAN2"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "ORAN3"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "SONALISMALIYETI"
        Me.DataColumn52.DataType = GetType(Decimal)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "ONCEKIALISMALIYETI"
        Me.DataColumn53.DataType = GetType(Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "ONCEKIALISTARIHI"
        Me.DataColumn54.DataType = GetType(Date)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "SONALISTARIHI"
        Me.DataColumn55.DataType = GetType(Date)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "NETMALIYET"
        Me.DataColumn56.DataType = GetType(Decimal)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "STATUS"
        Me.DataColumn57.DataType = GetType(Boolean)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "SONUC"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "MIKTAR"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "ORAN4"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "ORAN5"
        Me.DataColumn63.DataType = GetType(Decimal)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "ORAN6"
        Me.DataColumn64.DataType = GetType(Decimal)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "ORAN7"
        Me.DataColumn65.DataType = GetType(Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "ORAN8"
        Me.DataColumn66.DataType = GetType(Decimal)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "ORAN9"
        Me.DataColumn67.DataType = GetType(Decimal)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "ORAN10"
        Me.DataColumn68.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colEVRAKNO, Me.colSTOKNO, Me.colSTOKKODU, Me.colSTOKADI, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colFISTARIHI, Me.colFISNO, Me.colBIRIMMALIYET, Me.colBIRIMFIYAT, Me.colISKONTO, Me.colKDV, Me.colKDVLITUTAR, Me.colFATURAMIKTARI, Me.colFATURATUTARI, Me.colEKMALIYET, Me.colRENK, Me.colPESIN, Me.colALTIAY, Me.colONAY, Me.colORANEKMALIYET, Me.colORAN1, Me.colORAN2, Me.colORAN3, Me.colSONALISMALIYETI, Me.colONCEKIALISMALIYETI, Me.colONCEKIALISTARIHI, Me.colSONALISTARIHI, Me.colNETMALIYET, Me.colSTATUS, Me.colSONUC, Me.colMIKTAR, Me.collFiyat1, Me.collFiyat2, Me.collFiyat3, Me.collMaliyet, Me.colORAN4, Me.colONBESAY, Me.colFIYAT4, Me.colFIYAT5, Me.colFIYAT6, Me.colFIYAT7, Me.colFIYAT8, Me.colFIYAT9, Me.colFIYAT10, Me.colORAN5, Me.colORAN6, Me.colORAN7, Me.colORAN8, Me.colORAN9, Me.colORAN10, Me.colEFIYAT5, Me.colEFIYAT6, Me.colEFIYAT7, Me.colEFIYAT8, Me.colEFIYAT9, Me.colEFIYAT10})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(596, 267, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
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
        '
        'colEVRAKNO
        '
        Me.colEVRAKNO.Caption = "Evrak No"
        Me.colEVRAKNO.FieldName = "EVRAKNO"
        Me.colEVRAKNO.Name = "colEVRAKNO"
        Me.colEVRAKNO.OptionsColumn.AllowFocus = False
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        Me.colSTOKNO.OptionsColumn.AllowFocus = False
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.OptionsColumn.AllowFocus = False
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 0
        Me.colSTOKKODU.Width = 66
        '
        'colSTOKADI
        '
        Me.colSTOKADI.Caption = "Stok Adý"
        Me.colSTOKADI.FieldName = "STOKADI"
        Me.colSTOKADI.Name = "colSTOKADI"
        Me.colSTOKADI.OptionsColumn.AllowFocus = False
        Me.colSTOKADI.Visible = True
        Me.colSTOKADI.VisibleIndex = 1
        Me.colSTOKADI.Width = 99
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Firma Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.OptionsColumn.AllowFocus = False
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Firma Adý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.OptionsColumn.AllowFocus = False
        '
        'colFISTARIHI
        '
        Me.colFISTARIHI.Caption = "FiþTarihi"
        Me.colFISTARIHI.FieldName = "FISTARIHI"
        Me.colFISTARIHI.Name = "colFISTARIHI"
        Me.colFISTARIHI.OptionsColumn.AllowFocus = False
        '
        'colFISNO
        '
        Me.colFISNO.Caption = "Fiþ No"
        Me.colFISNO.FieldName = "FISNO"
        Me.colFISNO.Name = "colFISNO"
        Me.colFISNO.OptionsColumn.AllowFocus = False
        '
        'colBIRIMMALIYET
        '
        Me.colBIRIMMALIYET.Caption = "BirimMaliyet"
        Me.colBIRIMMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colBIRIMMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBIRIMMALIYET.FieldName = "BIRIMMALIYET"
        Me.colBIRIMMALIYET.Name = "colBIRIMMALIYET"
        Me.colBIRIMMALIYET.OptionsColumn.AllowFocus = False
        '
        'colBIRIMFIYAT
        '
        Me.colBIRIMFIYAT.Caption = "Birim Fiyat"
        Me.colBIRIMFIYAT.DisplayFormat.FormatString = "#,0.00"
        Me.colBIRIMFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBIRIMFIYAT.FieldName = "BIRIMFIYAT"
        Me.colBIRIMFIYAT.Name = "colBIRIMFIYAT"
        Me.colBIRIMFIYAT.OptionsColumn.AllowFocus = False
        '
        'colISKONTO
        '
        Me.colISKONTO.Caption = "Ýskonto"
        Me.colISKONTO.DisplayFormat.FormatString = "#,0.00"
        Me.colISKONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISKONTO.FieldName = "ISKONTO"
        Me.colISKONTO.Name = "colISKONTO"
        Me.colISKONTO.OptionsColumn.AllowFocus = False
        '
        'colKDV
        '
        Me.colKDV.Caption = "Kdv"
        Me.colKDV.DisplayFormat.FormatString = "#,0.00"
        Me.colKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKDV.FieldName = "KDV"
        Me.colKDV.Name = "colKDV"
        Me.colKDV.OptionsColumn.AllowFocus = False
        '
        'colKDVLITUTAR
        '
        Me.colKDVLITUTAR.Caption = "KdvlliMaliyet"
        Me.colKDVLITUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colKDVLITUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKDVLITUTAR.FieldName = "KDVLITUTAR"
        Me.colKDVLITUTAR.Name = "colKDVLITUTAR"
        Me.colKDVLITUTAR.OptionsColumn.AllowFocus = False
        Me.colKDVLITUTAR.Width = 47
        '
        'colFATURAMIKTARI
        '
        Me.colFATURAMIKTARI.Caption = "FaturaMiktarý"
        Me.colFATURAMIKTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colFATURAMIKTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFATURAMIKTARI.FieldName = "FATURAMIKTARI"
        Me.colFATURAMIKTARI.Name = "colFATURAMIKTARI"
        Me.colFATURAMIKTARI.OptionsColumn.AllowFocus = False
        '
        'colFATURATUTARI
        '
        Me.colFATURATUTARI.Caption = "FaturaTutarý"
        Me.colFATURATUTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colFATURATUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFATURATUTARI.FieldName = "FATURATUTARI"
        Me.colFATURATUTARI.Name = "colFATURATUTARI"
        Me.colFATURATUTARI.OptionsColumn.AllowFocus = False
        '
        'colEKMALIYET
        '
        Me.colEKMALIYET.Caption = "Ek Maliyet"
        Me.colEKMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colEKMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKMALIYET.FieldName = "EKMALIYET"
        Me.colEKMALIYET.Name = "colEKMALIYET"
        Me.colEKMALIYET.OptionsColumn.AllowFocus = False
        '
        'colRENK
        '
        Me.colRENK.Caption = "Renk"
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.Name = "colRENK"
        Me.colRENK.OptionsColumn.AllowFocus = False
        '
        'colPESIN
        '
        Me.colPESIN.Caption = "1. Satýþ Fiyatý"
        Me.colPESIN.ColumnEdit = Me.sec_fiyat
        Me.colPESIN.DisplayFormat.FormatString = "#,0.00"
        Me.colPESIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPESIN.FieldName = "PESIN"
        Me.colPESIN.Name = "colPESIN"
        Me.colPESIN.Visible = True
        Me.colPESIN.VisibleIndex = 4
        Me.colPESIN.Width = 53
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
        'colALTIAY
        '
        Me.colALTIAY.Caption = "2. Satýþ Fiyatý"
        Me.colALTIAY.ColumnEdit = Me.sec_fiyat
        Me.colALTIAY.DisplayFormat.FormatString = "#,0.00"
        Me.colALTIAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colALTIAY.FieldName = "ALTIAY"
        Me.colALTIAY.Name = "colALTIAY"
        Me.colALTIAY.Visible = True
        Me.colALTIAY.VisibleIndex = 5
        Me.colALTIAY.Width = 53
        '
        'colONAY
        '
        Me.colONAY.Caption = "3. Satýþ Fiyatý"
        Me.colONAY.ColumnEdit = Me.sec_fiyat
        Me.colONAY.DisplayFormat.FormatString = "#,0.00"
        Me.colONAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONAY.FieldName = "ONAY"
        Me.colONAY.Name = "colONAY"
        Me.colONAY.Visible = True
        Me.colONAY.VisibleIndex = 6
        Me.colONAY.Width = 74
        '
        'colORANEKMALIYET
        '
        Me.colORANEKMALIYET.Caption = "OranEkMaliyet"
        Me.colORANEKMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colORANEKMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORANEKMALIYET.FieldName = "ORANEKMALIYET"
        Me.colORANEKMALIYET.Name = "colORANEKMALIYET"
        Me.colORANEKMALIYET.OptionsColumn.AllowFocus = False
        Me.colORANEKMALIYET.Width = 47
        '
        'colORAN1
        '
        Me.colORAN1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colORAN1.AppearanceCell.Options.UseBackColor = True
        Me.colORAN1.AppearanceCell.Options.UseForeColor = True
        Me.colORAN1.Caption = "%Oran1"
        Me.colORAN1.ColumnEdit = Me.sec_oran
        Me.colORAN1.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN1.FieldName = "ORAN1"
        Me.colORAN1.Name = "colORAN1"
        Me.colORAN1.Width = 53
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
        'colORAN2
        '
        Me.colORAN2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN2.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN2.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colORAN2.AppearanceCell.Options.UseBackColor = True
        Me.colORAN2.AppearanceCell.Options.UseForeColor = True
        Me.colORAN2.Caption = "%Oran2"
        Me.colORAN2.ColumnEdit = Me.sec_oran
        Me.colORAN2.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN2.FieldName = "ORAN2"
        Me.colORAN2.Name = "colORAN2"
        Me.colORAN2.Width = 53
        '
        'colORAN3
        '
        Me.colORAN3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN3.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN3.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colORAN3.AppearanceCell.Options.UseBackColor = True
        Me.colORAN3.AppearanceCell.Options.UseForeColor = True
        Me.colORAN3.Caption = "%Oran3"
        Me.colORAN3.ColumnEdit = Me.sec_oran
        Me.colORAN3.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN3.FieldName = "ORAN3"
        Me.colORAN3.Name = "colORAN3"
        Me.colORAN3.Width = 53
        '
        'colSONALISMALIYETI
        '
        Me.colSONALISMALIYETI.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colSONALISMALIYETI.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSONALISMALIYETI.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colSONALISMALIYETI.AppearanceCell.Options.UseBackColor = True
        Me.colSONALISMALIYETI.AppearanceCell.Options.UseFont = True
        Me.colSONALISMALIYETI.AppearanceCell.Options.UseForeColor = True
        Me.colSONALISMALIYETI.Caption = "SonMaliyet"
        Me.colSONALISMALIYETI.DisplayFormat.FormatString = "#,0.00"
        Me.colSONALISMALIYETI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSONALISMALIYETI.FieldName = "SONALISMALIYETI"
        Me.colSONALISMALIYETI.Name = "colSONALISMALIYETI"
        Me.colSONALISMALIYETI.OptionsColumn.AllowFocus = False
        Me.colSONALISMALIYETI.Visible = True
        Me.colSONALISMALIYETI.VisibleIndex = 2
        Me.colSONALISMALIYETI.Width = 62
        '
        'colONCEKIALISMALIYETI
        '
        Me.colONCEKIALISMALIYETI.Caption = "Önceki Maliyet"
        Me.colONCEKIALISMALIYETI.DisplayFormat.FormatString = "#,0.00"
        Me.colONCEKIALISMALIYETI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONCEKIALISMALIYETI.FieldName = "ONCEKIALISMALIYETI"
        Me.colONCEKIALISMALIYETI.Name = "colONCEKIALISMALIYETI"
        Me.colONCEKIALISMALIYETI.OptionsColumn.AllowFocus = False
        '
        'colONCEKIALISTARIHI
        '
        Me.colONCEKIALISTARIHI.Caption = "Önceki Alýþ Tarihi"
        Me.colONCEKIALISTARIHI.FieldName = "ONCEKIALISTARIHI"
        Me.colONCEKIALISTARIHI.Name = "colONCEKIALISTARIHI"
        Me.colONCEKIALISTARIHI.OptionsColumn.AllowFocus = False
        '
        'colSONALISTARIHI
        '
        Me.colSONALISTARIHI.Caption = "Son Alýþ Tarihi"
        Me.colSONALISTARIHI.FieldName = "SONALISTARIHI"
        Me.colSONALISTARIHI.Name = "colSONALISTARIHI"
        Me.colSONALISTARIHI.OptionsColumn.AllowFocus = False
        '
        'colNETMALIYET
        '
        Me.colNETMALIYET.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colNETMALIYET.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNETMALIYET.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colNETMALIYET.AppearanceCell.Options.UseBackColor = True
        Me.colNETMALIYET.AppearanceCell.Options.UseFont = True
        Me.colNETMALIYET.AppearanceCell.Options.UseForeColor = True
        Me.colNETMALIYET.Caption = "Net Maliyet"
        Me.colNETMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colNETMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNETMALIYET.FieldName = "NETMALIYET"
        Me.colNETMALIYET.Name = "colNETMALIYET"
        Me.colNETMALIYET.OptionsColumn.AllowFocus = False
        Me.colNETMALIYET.Visible = True
        Me.colNETMALIYET.VisibleIndex = 3
        Me.colNETMALIYET.Width = 68
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Durum"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        Me.colSTATUS.OptionsColumn.AllowFocus = False
        '
        'colSONUC
        '
        Me.colSONUC.Caption = "Sonuç"
        Me.colSONUC.FieldName = "SONUC"
        Me.colSONUC.Name = "colSONUC"
        Me.colSONUC.OptionsColumn.AllowFocus = False
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.OptionsColumn.AllowFocus = False
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.##}")})
        '
        'collFiyat1
        '
        Me.collFiyat1.Caption = "EskiFiyat1"
        Me.collFiyat1.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat1.FieldName = "FIYAT1"
        Me.collFiyat1.Name = "collFiyat1"
        '
        'collFiyat2
        '
        Me.collFiyat2.Caption = "EskiFiyat2"
        Me.collFiyat2.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat2.FieldName = "FIYAT2"
        Me.collFiyat2.Name = "collFiyat2"
        '
        'collFiyat3
        '
        Me.collFiyat3.Caption = "EskiFiyat3"
        Me.collFiyat3.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat3.FieldName = "FIYAT3"
        Me.collFiyat3.Name = "collFiyat3"
        '
        'collMaliyet
        '
        Me.collMaliyet.Caption = "EskiFiyatMaliyet"
        Me.collMaliyet.DisplayFormat.FormatString = "#,0.00"
        Me.collMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMaliyet.FieldName = "MALIYET"
        Me.collMaliyet.Name = "collMaliyet"
        '
        'colORAN4
        '
        Me.colORAN4.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN4.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN4.AppearanceCell.Options.UseBackColor = True
        Me.colORAN4.Caption = "% Oran4"
        Me.colORAN4.ColumnEdit = Me.sec_oran
        Me.colORAN4.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN4.FieldName = "ORAN4"
        Me.colORAN4.Name = "colORAN4"
        Me.colORAN4.Width = 54
        '
        'colONBESAY
        '
        Me.colONBESAY.Caption = "4. Satýþ Fiyatý"
        Me.colONBESAY.ColumnEdit = Me.sec_fiyat
        Me.colONBESAY.DisplayFormat.FormatString = "#,0.00"
        Me.colONBESAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONBESAY.FieldName = "ONBESAY"
        Me.colONBESAY.Name = "colONBESAY"
        Me.colONBESAY.Visible = True
        Me.colONBESAY.VisibleIndex = 7
        Me.colONBESAY.Width = 81
        '
        'colFIYAT4
        '
        Me.colFIYAT4.Caption = "EskiFiyat4"
        Me.colFIYAT4.FieldName = "FIYAT4"
        Me.colFIYAT4.Name = "colFIYAT4"
        Me.colFIYAT4.Width = 150
        '
        'colFIYAT5
        '
        Me.colFIYAT5.Caption = "5. Satýþ Fiyatý"
        Me.colFIYAT5.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT5.FieldName = "FIYAT5"
        Me.colFIYAT5.Name = "colFIYAT5"
        '
        'colFIYAT6
        '
        Me.colFIYAT6.Caption = "6. Satýþ Fiyatý"
        Me.colFIYAT6.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT6.FieldName = "FIYAT6"
        Me.colFIYAT6.Name = "colFIYAT6"
        '
        'colFIYAT7
        '
        Me.colFIYAT7.Caption = "7. Satýþ Fiyatý"
        Me.colFIYAT7.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT7.FieldName = "FIYAT7"
        Me.colFIYAT7.Name = "colFIYAT7"
        '
        'colFIYAT8
        '
        Me.colFIYAT8.Caption = "8. Satýþ Fiyatý"
        Me.colFIYAT8.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT8.FieldName = "FIYAT8"
        Me.colFIYAT8.Name = "colFIYAT8"
        '
        'colFIYAT9
        '
        Me.colFIYAT9.Caption = "9. Satýþ Fiyatý"
        Me.colFIYAT9.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT9.FieldName = "FIYAT9"
        Me.colFIYAT9.Name = "colFIYAT9"
        '
        'colFIYAT10
        '
        Me.colFIYAT10.Caption = "10. Satýþ Fiyatý"
        Me.colFIYAT10.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT10.FieldName = "FIYAT10"
        Me.colFIYAT10.Name = "colFIYAT10"
        '
        'colORAN5
        '
        Me.colORAN5.Caption = "%Oran5"
        Me.colORAN5.ColumnEdit = Me.sec_oran
        Me.colORAN5.FieldName = "ORAN5"
        Me.colORAN5.Name = "colORAN5"
        '
        'colORAN6
        '
        Me.colORAN6.Caption = "%Oran6"
        Me.colORAN6.ColumnEdit = Me.sec_oran
        Me.colORAN6.FieldName = "ORAN6"
        Me.colORAN6.Name = "colORAN6"
        '
        'colORAN7
        '
        Me.colORAN7.Caption = "%Oran7"
        Me.colORAN7.ColumnEdit = Me.sec_oran
        Me.colORAN7.FieldName = "ORAN7"
        Me.colORAN7.Name = "colORAN7"
        '
        'colORAN8
        '
        Me.colORAN8.Caption = "%Oran8"
        Me.colORAN8.ColumnEdit = Me.sec_oran
        Me.colORAN8.FieldName = "ORAN8"
        Me.colORAN8.Name = "colORAN8"
        '
        'colORAN9
        '
        Me.colORAN9.Caption = "%Oran9"
        Me.colORAN9.ColumnEdit = Me.sec_oran
        Me.colORAN9.FieldName = "ORAN9"
        Me.colORAN9.Name = "colORAN9"
        '
        'colORAN10
        '
        Me.colORAN10.Caption = "%Oran10"
        Me.colORAN10.ColumnEdit = Me.sec_oran
        Me.colORAN10.FieldName = "ORAN10"
        Me.colORAN10.Name = "colORAN10"
        '
        'colEFIYAT5
        '
        Me.colEFIYAT5.Caption = "EskiFiyat5"
        Me.colEFIYAT5.DisplayFormat.FormatString = "#,0.00"
        Me.colEFIYAT5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEFIYAT5.FieldName = "EFIYAT5"
        Me.colEFIYAT5.Name = "colEFIYAT5"
        Me.colEFIYAT5.OptionsColumn.AllowEdit = False
        '
        'colEFIYAT6
        '
        Me.colEFIYAT6.Caption = "EskiFiyat6"
        Me.colEFIYAT6.DisplayFormat.FormatString = "#,0.00"
        Me.colEFIYAT6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEFIYAT6.FieldName = "FIYAT6"
        Me.colEFIYAT6.Name = "colEFIYAT6"
        Me.colEFIYAT6.OptionsColumn.AllowEdit = False
        '
        'colEFIYAT7
        '
        Me.colEFIYAT7.Caption = "EskiFiyat7"
        Me.colEFIYAT7.DisplayFormat.FormatString = "#,0.00"
        Me.colEFIYAT7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEFIYAT7.FieldName = "EFIYAT7"
        Me.colEFIYAT7.Name = "colEFIYAT7"
        Me.colEFIYAT7.OptionsColumn.AllowEdit = False
        '
        'colEFIYAT8
        '
        Me.colEFIYAT8.Caption = "EskiFiyat8"
        Me.colEFIYAT8.DisplayFormat.FormatString = "#,0.00"
        Me.colEFIYAT8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEFIYAT8.FieldName = "EFIYAT8"
        Me.colEFIYAT8.Name = "colEFIYAT8"
        Me.colEFIYAT8.OptionsColumn.AllowEdit = False
        '
        'colEFIYAT9
        '
        Me.colEFIYAT9.Caption = "EskiFiyat9"
        Me.colEFIYAT9.DisplayFormat.FormatString = "#,0.00"
        Me.colEFIYAT9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEFIYAT9.FieldName = "EFIYAT9"
        Me.colEFIYAT9.Name = "colEFIYAT9"
        Me.colEFIYAT9.OptionsColumn.AllowEdit = False
        '
        'colEFIYAT10
        '
        Me.colEFIYAT10.Caption = "EskiFiyat10"
        Me.colEFIYAT10.DisplayFormat.FormatString = "#,0.00"
        Me.colEFIYAT10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEFIYAT10.FieldName = "EFIYAT10"
        Me.colEFIYAT10.Name = "colEFIYAT10"
        Me.colEFIYAT10.OptionsColumn.AllowEdit = False
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
        'Panel_Ara
        '
        Me.Panel_Ara.Controls.Add(Me.GroupControl5)
        Me.Panel_Ara.Controls.Add(Me.GroupControl4)
        Me.Panel_Ara.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Ara.Location = New System.Drawing.Point(0, 170)
        Me.Panel_Ara.Name = "Panel_Ara"
        Me.Panel_Ara.Size = New System.Drawing.Size(818, 29)
        Me.Panel_Ara.TabIndex = 13
        '
        'GroupControl5
        '
        Me.GroupControl5.CaptionLocation = DevExpress.Utils.Locations.Right
        Me.GroupControl5.Controls.Add(Me.Label4)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(337, 2)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.ShowCaption = False
        Me.GroupControl5.Size = New System.Drawing.Size(479, 25)
        Me.GroupControl5.TabIndex = 22
        Me.GroupControl5.Text = "Ýnf"
        '
        'Label4
        '
        Me.Label4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "satýr % / %"
        '
        'GroupControl4
        '
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl4.Controls.Add(Me.Label5)
        Me.GroupControl4.Controls.Add(Me.lbl_ara)
        Me.GroupControl4.Controls.Add(Me.txt_ara)
        Me.GroupControl4.Controls.Add(Me.sec_kriter)
        Me.GroupControl4.Controls.Add(Me.Label6)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(335, 25)
        Me.GroupControl4.TabIndex = 21
        Me.GroupControl4.Text = "Ekle"
        '
        'Label5
        '
        Me.Label5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Ekle ="
        '
        'lbl_ara
        '
        Me.lbl_ara.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ara.Location = New System.Drawing.Point(52, 5)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(6, 11)
        Me.lbl_ara.TabIndex = 15
        Me.lbl_ara.Text = "*"
        '
        'txt_ara
        '
        Me.txt_ara.Location = New System.Drawing.Point(86, 2)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Red
        Me.txt_ara.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ara.Properties.MaxLength = 30
        Me.txt_ara.Size = New System.Drawing.Size(178, 20)
        ToolTipTitleItem1.Text = "Otomatik Stok Sorgulama"
        ToolTipItem1.LeftIndent = 6
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txt_ara.SuperTip = SuperToolTip1
        Me.txt_ara.TabIndex = 16
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.Location = New System.Drawing.Point(265, 2)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_kriter.Properties.Appearance.Options.UseFont = True
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(63, 20)
        ToolTipTitleItem2.Text = "Arama Kriteri Belirle"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = resources.GetString("ToolTipItem2.Text")
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.sec_kriter.SuperTip = SuperToolTip2
        Me.sec_kriter.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Appearance.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(2, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(5, 10)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "*"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.btn_FisIptal, Me.btn_SatirEkle, Me.BarButtonItem6, Me.btn_SatirSil, Me.BarButtonItem8, Me.BarSubItem4, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarSubItem5, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarSubItem6, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarSubItem7, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem7, Me.BarButtonItem31, Me.BarButtonItem32})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 42
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem4, "Dosyadan Oku KisaAdina Göre"), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FisIptal, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kaydet Yeni Belge"
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Dosyadan Oku StokKoduna Göre"
        Me.BarButtonItem5.Id = 38
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Dosyadan Oku"
        Me.BarButtonItem4.Id = 37
        Me.BarButtonItem4.Name = "BarButtonItem4"
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
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem3.Name = "BarButtonItem3"
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
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirEkle), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.btn_SatirSil, "Satýr Sil"), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'btn_SatirEkle
        '
        Me.btn_SatirEkle.Caption = "Satýr Ekle"
        Me.btn_SatirEkle.Id = 7
        Me.btn_SatirEkle.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.btn_SatirEkle.Name = "btn_SatirEkle"
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
        Me.btn_SatirSil.Caption = "Satýr Si"
        Me.btn_SatirSil.Id = 9
        Me.btn_SatirSil.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.btn_SatirSil.Name = "btn_SatirSil"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Stok Karlýlýk Analizi"
        Me.BarButtonItem16.Id = 21
        Me.BarButtonItem16.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Stoklar Karlýlýk Analizi"
        Me.BarButtonItem21.Id = 26
        Me.BarButtonItem21.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Stok Satýþ Analizi"
        Me.BarButtonItem18.Id = 23
        Me.BarButtonItem18.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Bekleyen Verilen Sipariþler"
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Bekleyen Alýnan Sipariþler"
        Me.BarButtonItem20.Id = 25
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Envanter"
        Me.BarButtonItem17.Id = 22
        Me.BarButtonItem17.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Araçlar"
        Me.BarSubItem6.Id = 19
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Hesap Makinesi"
        Me.BarButtonItem15.Id = 20
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem28.Caption = "Satýrlarda Ara"
        Me.BarButtonItem28.Id = 34
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Deðiþim Onayla"
        Me.BarSubItem4.Id = 11
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27)})
        Me.BarSubItem4.Name = "BarSubItem4"
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
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Etiketleri Önizle"
        Me.BarButtonItem29.Id = 35
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Etiketleri Yazdýr"
        Me.BarButtonItem22.Id = 27
        Me.BarButtonItem22.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Etiketleri Direkt Yazdýr"
        Me.BarButtonItem30.Id = 36
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Eski Satýþ Fiyatlarýný Güncelle"
        Me.BarButtonItem25.Id = 31
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Sýnýf5=""Ýndirimli Ürün"" olarak deðiþtir"
        Me.BarButtonItem26.Id = 32
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Sýnýf5='' olarak Deðiþtir"
        Me.BarButtonItem27.Id = 33
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Görünüm"
        Me.BarSubItem5.Id = 15
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem31, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem32)})
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
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Görünümü Kaydet"
        Me.BarButtonItem23.Id = 28
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Görünümü Yazdýr"
        Me.BarButtonItem7.Id = 39
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "Excel"
        Me.BarButtonItem31.Id = 40
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Csv"
        Me.BarButtonItem32.Id = 41
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "Ekran"
        Me.BarSubItem7.Id = 29
        Me.BarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24)})
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Tam Ekran"
        Me.BarButtonItem24.Id = 30
        Me.BarButtonItem24.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem24.Name = "BarButtonItem24"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 456)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 434)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 434)
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "deneme"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "BarButtonItem14"
        Me.BarButtonItem14.Id = 18
        Me.BarButtonItem14.Name = "BarButtonItem14"
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
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_stok_fiyat_degisim
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 478)
        Me.Controls.Add(Me.Panel_hareketler)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.Panel_toplamlar)
        Me.Controls.Add(Me.Panel_baslik)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_fiyat_degisim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiyat Deðiþim Föyü"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_baslik.ResumeLayout(False)
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplamlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplamlar.ResumeLayout(False)
        CType(Me.Panel_satis_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satis_info.ResumeLayout(False)
        Me.Panel_satis_info.PerformLayout()
        CType(Me.Panel_depo_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_depo_info.ResumeLayout(False)
        CType(Me.VGrid_depo_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplam.ResumeLayout(False)
        CType(Me.VGrid_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_hareketler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hareketler.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_grid.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_oran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Ara.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Public belgeind As Int64
    Public miktar As Decimal = 0
    Public detay_miktar As Decimal = 0
    Dim depokodu As String
    Dim dr As DataRow
    Dim ds_stok As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_satir_stok_aciklama As DataSet
    Dim mevcut As Integer = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Private Sub frm_stok_fiyat_degisim_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If GridView1.RowCount = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..! " & vbCrLf & "Fiyat Deðiþim Föyü Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                belge_iptal(belgeind)
            Else
            End If
        Else
            Timer1.Enabled = False
            toplam_hesapla()
            baslik_degistir()
            'baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), "Yeni...", dr_baslik("bKilitli"), dr_baslik("HATIRLAT"))
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub frm_stok_paket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colPESIN.Caption = sFiyat1Aciklama
        colALTIAY.Caption = sFiyat2Aciklama
        colONAY.Caption = sFiyat3Aciklama
        colONBESAY.Caption = sFiyat4Aciklama
        colFIYAT5.Caption = sFiyat5Aciklama
        colFIYAT6.Caption = sFiyat6Aciklama
        colFIYAT7.Caption = sFiyat7Aciklama
        colFIYAT8.Caption = sFiyat8Aciklama
        colFIYAT9.Caption = sFiyat9Aciklama
        colFIYAT10.Caption = sFiyat10Aciklama
        belgetipleri()
        baslik()
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        Try
            dataload_hareket()
        Catch ex As Exception
        End Try
        Timer1.Enabled = True
        If dr_baslik("bKilitli") = True Then
            GridView1.OptionsBehavior.Editable = False
            Panel_Ara.Enabled = False
            btn_FisIptal.Enabled = False
            btn_SatirEkle.Enabled = False
            btn_SatirSil.Enabled = False
            Menu_DegerYay.Enabled = False
            Menu_SatirEkleAlis.Enabled = False
            Menu_SatirEkleStok.Enabled = False
            Menu_SatirSil.Enabled = False
        End If
    End Sub
    Private Sub loaded()
        dataload_baslik()
        dataload_harekets()
        GridControl1.Focus()
        GridControl1.Select()
        sec_depo_baslik.DataSource = sorgu_s(sorgu_query("SELECT     sDepo AS DEPOKODU, sAciklama AS DEPOADI  FROM         tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        sec_depo_hareket.DataSource = sorgu_s(sorgu_query("SELECT     sDepo AS DEPOKODU, sAciklama AS DEPOADI  FROM         tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        dr_baslik = ds_baslik.Tables(0).Rows(0)
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM    ASTOKFIYATDEGISIMBASLIK WHERE IND =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_harekets()
        ds_hareket = sorgu_harekets("")
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        GridControl1.Select()
    End Sub
    Private Function sorgu_harekets(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ASTOKFIYATDEGISIMDETAY WHERE EVRAKNO =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function baslik_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal bKilitli As Byte, ByVal HATIRLAT As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKFIYATDEGISIMBASLIK                       (TARIH, BELGENO, ACIKLAMA, KOD1, KOD2, KOD3, KOD4, KOD5, SONUC,bKilitli,HATIRLAT) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & ACIKLAMA & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & SONUC & "'," & bKilitli & ",'" & HATIRLAT & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal TARIH As DateTime, ByVal FISTARIHI As DateTime, ByVal FISNO As String, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal STOKADI As String, ByVal MIKTAR As Decimal, ByVal BIRIMMALIYET As Decimal, ByVal BIRIMFIYAT As Decimal, ByVal ISKONTO As Decimal, ByVal KDV As Decimal, ByVal KDVLITUTAR As Decimal, ByVal FATURAMIKTARI As Decimal, ByVal FATURATUTARI As Decimal, ByVal EKMALIYET As Decimal, ByVal RENK As String, ByVal PESIN As Decimal, ByVal ONAY As Decimal, ByVal ALTIAY As Decimal, ByVal ORANEKMALIYET As Decimal, ByVal ORAN1 As Decimal, ByVal ORAN2 As Decimal, ByVal ORAN3 As Decimal, ByVal SONALISMALIYETI As Decimal, ByVal ONCEKIALISMALIYETI As Decimal, ByVal ONCEKIALISTARIHI As DateTime, ByVal SONALISTARIHI As DateTime, ByVal NETMALIYET As Decimal, ByVal STATUS As Integer, ByVal SONUC As String, ByVal FIYAT1 As Decimal, ByVal FIYAT2 As Decimal, ByVal FIYAT3 As Decimal, ByVal MALIYET As Decimal, ByVal ONBESAY As Decimal, ByVal ORAN4 As Decimal, ByVal FIYAT4 As Decimal, ByVal FIYAT5 As Decimal, ByVal EFIYAT5 As Decimal, ByVal FIYAT6 As Decimal, ByVal EFIYAT6 As Decimal, ByVal FIYAT7 As Decimal, ByVal EFIYAT7 As Decimal, ByVal FIYAT8 As Decimal, ByVal EFIYAT8 As Decimal, ByVal FIYAT9 As Decimal, ByVal EFIYAT9 As Decimal, ByVal FIYAT10 As Decimal, ByVal EFIYAT10 As Decimal, ByVal ORAN5 As Decimal, ByVal ORAN6 As Decimal, ByVal ORAN7 As Decimal, ByVal ORAN8 As Decimal, ByVal ORAN9 As Decimal, ByVal ORAN10 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKFIYATDEGISIMDETAY (EVRAKNO, TARIH, FISTARIHI, FISNO, FIRMAKODU, FIRMAADI, STOKNO, STOKKODU, STOKADI, MIKTAR, BIRIMMALIYET, BIRIMFIYAT, ISKONTO, KDV,  KDVLITUTAR, FATURAMIKTARI, FATURATUTARI, EKMALIYET, RENK, PESIN, ONAY, ALTIAY, ORANEKMALIYET, ORAN1, ORAN2, ORAN3, SONALISMALIYETI, ONCEKIALISMALIYETI, ONCEKIALISTARIHI, SONALISTARIHI, NETMALIYET, STATUS, SONUC,FIYAT1,FIYAT2,FIYAT3,MALIYET,ONBESAY,ORAN4,FIYAT4,FIYAT5,EFIYAT5,FIYAT6,EFIYAT6,FIYAT7,EFIYAT7,FIYAT8,EFIYAT8,FIYAT9,EFIYAT9,FIYAT10,EFIYAT10,ORAN5,ORAN6,ORAN7,ORAN8,ORAN9,ORAN10) VALUES     (" & EVRAKNO & ", '" & TARIH & "', '" & FISTARIHI & "', '" & FISNO & "', '" & FIRMAKODU & "', '" & FIRMAADI & "', " & STOKNO & ", '" & STOKKODU & "', '" & STOKADI & "', " & MIKTAR & " , " & BIRIMMALIYET & " , " & BIRIMFIYAT & " , " & ISKONTO & ", " & KDV & ", " & KDVLITUTAR & ", " & FATURAMIKTARI & " , " & FATURATUTARI & " , " & EKMALIYET & " , '" & RENK & "', " & PESIN & " , " & ONAY & " , " & ALTIAY & " , " & ORANEKMALIYET & " , " & ORAN1 & " , " & ORAN2 & " , " & ORAN3 & " , " & SONALISMALIYETI & " , " & ONCEKIALISMALIYETI & " , '" & ONCEKIALISTARIHI & "', '" & SONALISTARIHI & "' , " & NETMALIYET & ", " & STATUS & ", '" & SONUC & "'," & FIYAT1 & "," & FIYAT2 & "," & FIYAT3 & "," & MALIYET & "," & ONBESAY & "," & ORAN4 & "," & FIYAT4 & "," & FIYAT5 & "," & EFIYAT5 & "," & FIYAT6 & "," & EFIYAT6 & "," & FIYAT7 & "," & EFIYAT7 & "," & FIYAT8 & "," & EFIYAT8 & "," & FIYAT9 & "," & EFIYAT9 & "," & FIYAT10 & "," & EFIYAT10 & "," & ORAN5 & "," & ORAN6 & "," & ORAN7 & "," & ORAN8 & "," & ORAN9 & "," & ORAN10 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub baslik_kaydet_degistir(ByVal evrakno As Int64, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal bKilitli As Byte, ByVal HATIRLAT As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKFIYATDEGISIMBASLIK  SET              TARIH = '" & TARIH & "' , BELGENO = '" & BELGENO & "', ACIKLAMA = '" & ACIKLAMA & "', KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', KOD3 = '" & KOD3 & "' , KOD4 = '" & KOD4 & "', KOD5 = '" & KOD5 & "',   SONUC = '" & SONUC & "',bKilitli =" & bKilitli & ",HATIRLAT = '" & HATIRLAT & "' WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal TARIH As DateTime, ByVal FISTARIHI As DateTime, ByVal FISNO As String, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal STOKADI As String, ByVal MIKTAR As Decimal, ByVal BIRIMMALIYET As Decimal, ByVal BIRIMFIYAT As Decimal, ByVal ISKONTO As Decimal, ByVal KDV As Decimal, ByVal KDVLITUTAR As Decimal, ByVal FATURAMIKTARI As Decimal, ByVal FATURATUTARI As Decimal, ByVal EKMALIYET As Decimal, ByVal RENK As String, ByVal PESIN As Decimal, ByVal ONAY As Decimal, ByVal ALTIAY As Decimal, ByVal ORANEKMALIYET As Decimal, ByVal ORAN1 As Decimal, ByVal ORAN2 As Decimal, ByVal ORAN3 As Decimal, ByVal SONALISMALIYETI As Decimal, ByVal ONCEKIALISMALIYETI As Decimal, ByVal ONCEKIALISTARIHI As DateTime, ByVal SONALISTARIHI As DateTime, ByVal NETMALIYET As Decimal, ByVal STATUS As Integer, ByVal SONUC As String, ByVal FIYAT1 As Decimal, ByVal FIYAT2 As Decimal, ByVal FIYAT3 As Decimal, ByVal MALIYET As Decimal, ByVal ONBESAY As Decimal, ByVal ORAN4 As Decimal, ByVal FIYAT4 As Decimal, ByVal FIYAT5 As Decimal, ByVal EFIYAT5 As Decimal, ByVal FIYAT6 As Decimal, ByVal EFIYAT6 As Decimal, ByVal FIYAT7 As Decimal, ByVal EFIYAT7 As Decimal, ByVal FIYAT8 As Decimal, ByVal EFIYAT8 As Decimal, ByVal FIYAT9 As Decimal, ByVal EFIYAT9 As Decimal, ByVal FIYAT10 As Decimal, ByVal EFIYAT10 As Decimal, ByVal ORAN5 As Decimal, ByVal ORAN6 As Decimal, ByVal ORAN7 As Decimal, ByVal ORAN8 As Decimal, ByVal ORAN9 As Decimal, ByVal ORAN10 As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        ORAN1 = FormatNumber(ORAN1, 4)
        ORAN2 = FormatNumber(ORAN2, 4)
        ORAN3 = FormatNumber(ORAN3, 4)
        ORAN4 = FormatNumber(ORAN4, 4)
        ORAN5 = FormatNumber(ORAN5, 2)
        ORAN6 = FormatNumber(ORAN6, 2)
        ORAN7 = FormatNumber(ORAN7, 2)
        ORAN8 = FormatNumber(ORAN8, 2)
        ORAN9 = FormatNumber(ORAN9, 2)
        ORAN10 = FormatNumber(ORAN10, 2)
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKFIYATDEGISIMDETAY SET              EVRAKNO = " & EVRAKNO & ", TARIH = '" & TARIH & "', FISTARIHI = '" & FISTARIHI & "', FISNO = '" & FISNO & "', BIRIMMALIYET = " & BIRIMMALIYET & ", BIRIMFIYAT = " & BIRIMFIYAT & ", ISKONTO = " & ISKONTO & ", KDV = " & KDV & ", KDVLITUTAR = " & KDVLITUTAR & ", FATURAMIKTARI = " & FATURAMIKTARI & ", FATURATUTARI = " & FATURATUTARI & ", EKMALIYET = " & EKMALIYET & ",  PESIN = " & PESIN & ", ONAY = " & ONAY & ", ALTIAY = " & ALTIAY & ", ORANEKMALIYET = " & ORANEKMALIYET & ", ORAN1 = " & ORAN1 & ", ORAN2 = " & ORAN2 & ", ORAN3 = " & ORAN3 & " , SONALISMALIYETI = " & SONALISMALIYETI & ", ONCEKIALISMALIYETI = " & ONCEKIALISMALIYETI & ", NETMALIYET = " & NETMALIYET & ", STATUS = " & STATUS & ", SONUC = '" & SONUC & "',FIYAT1 = " & FIYAT1 & ",FIYAT2 = " & FIYAT2 & ",FIYAT3 = " & FIYAT3 & ",FIYAT4 = " & FIYAT4 & ",ONBESAY= " & ONBESAY & ",ORAN4 = " & ORAN4 & ",FIYAT5 = " & FIYAT5 & ",EFIYAT5 = " & EFIYAT5 & ",FIYAT6 = " & FIYAT6 & ",EFIYAT6 = " & EFIYAT6 & ",FIYAT7 = " & FIYAT7 & ",EFIYAT7 = " & EFIYAT7 & ",FIYAT8 = " & FIYAT8 & ",EFIYAT8 = " & EFIYAT8 & ",FIYAT9 = " & FIYAT9 & ",EFIYAT9 = " & EFIYAT9 & ",FIYAT10 = " & FIYAT10 & ",EFIYAT10 = " & EFIYAT10 & ",ORAN5 = " & ORAN5 & ",ORAN6 = " & ORAN6 & ",ORAN7 = " & ORAN7 & ",ORAN8 = " & ORAN8 & ",ORAN9 = " & ORAN9 & ",ORAN10 = " & ORAN10 & " WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
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
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKFIYATDEGISIMBASLIK  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
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
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKFIYATDEGISIMDETAY  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
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
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
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
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
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
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub baslik()
        If belgeind = 0 Then
            Dim dr As DataRow = ds_baslik.Tables(0).NewRow
            dr("TARIH") = Today
            Try
                dr("BELGENO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
                con.Close()
            Catch ex As Exception
                dr("BELGENO") = "A-000001"
            End Try
            dr("KOD1") = ""
            dr("KOD2") = ""
            dr("KOD3") = ""
            dr("KOD4") = ""
            dr("KOD5") = 0
            dr("ACIKLAMA") = ""
            dr("HATIRLAT") = "01/01/1900"
            dr("bKilitli") = 0
            belgeind = baslik_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), "Yeni...", dr("bKilitli"), dr("HATIRLAT"))
            dr("IND") = belgeind
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = Nothing
        ElseIf belgeind <> 0 Then
        Else
            Me.Close()
        End If
    End Sub
    Private Sub baslik_yeni()
        belgeind = 0
        ds_baslik.Tables(0).Clear()
        ds_detay.Tables(0).Clear()
        status = False
        If belgeind = 0 Then
            Dim dr As DataRow = ds_baslik.Tables(0).NewRow
            dr("IZAHAT") = "K"
            Try
                depokodu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
                If depokodu <> "True" Then
                    dr("DEPO") = depokodu
                Else
                    dr("DEPO") = "1KAT"
                End If
            Catch ex As Exception
                dr("DEPO") = "1KAT"
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", "True")
            End Try
            dr("TARIH") = Today
            Try
                dr("BELGENO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
                con.Close()
            Catch ex As Exception
                dr("BELGENO") = "A-000001"
            End Try
            dr("KOD1") = ""
            dr("KOD2") = ""
            dr("KOD3") = ""
            dr("KOD4") = ""
            dr("KOD5") = ""
            dr("ACIKLAMA") = ""
            dr("bKilitli") = 0
            dr("HATIRLAT") = "01/01/1900"
            belgeind = baslik_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), "Yeni...", 0, dr("HATIRLAT"))
            dr("IND") = belgeind
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = Nothing
        ElseIf belgeind <> 0 Then
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
        Dim sonuc
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(BELGENO,'A-000001') AS BELGENO FROM    ASTOKFIYATDEGISIMBASLIK WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM    ASTOKFIYATDEGISIMBASLIK  WHERE  BELGENO LIKE 'A%')")
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
            XtraMessageBox.Show(Sorgu_sDil("Fiyat Deðiþim Föyü Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
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
        dr = Nothing
    End Function
    Private Sub satir_ekle_stok(ByVal yeni As Boolean)
        Dim frm As New frm_stok_alislar
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
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
                    dr = ds_hareket.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("EVRAKNO") = belgeind
                    dr("TARIH") = dr_baslik("TARIH")
                    dr("FISTARIHI") = dr1("TARIH")
                    dr("FISNO") = dr1("FISNO")
                    dr("FIRMAKODU") = Trim(dr1("FIRMAKODU"))
                    dr("FIRMAADI") = Trim(Microsoft.VisualBasic.Left(dr1("FIRMAADI"), 49))
                    dr("STOKNO") = dr1("STOKNO")
                    dr("STOKKODU") = Trim(dr1("STOKKODU"))
                    dr("STOKADI") = Trim(Microsoft.VisualBasic.Left(dr1("STOKADI"), 50))
                    dr("MIKTAR") = sorgu_sayi(dr1("MIKTAR"), 0)
                    dr("BIRIMMALIYET") = sorgu_sayi(dr1("BIRIMMALIYET"), 0)
                    dr("BIRIMFIYAT") = sorgu_sayi(dr1("BIRIMFIYAT"), 0)
                    dr("ISKONTO") = sorgu_sayi(dr1("ISKONTO"), 0)
                    dr("KDV") = sorgu_sayi(dr1("KDV"), 0)
                    dr("KDVLITUTAR") = sorgu_sayi(dr1("KDVLITUTAR"), 0)
                    dr("FATURAMIKTARI") = sorgu_sayi(dr1("FATURAMIKTARI"), 0)
                    dr("FATURATUTARI") = sorgu_sayi(dr1("FATURATUTARI"), 0)
                    dr("EKMALIYET") = sorgu_sayi(dr1("EKMALIYET"), 0)
                    dr("RENK") = dr1("RENK")
                    dr("PESIN") = sorgu_sayi(dr1("PESIN"), 0)
                    dr("ALTIAY") = sorgu_sayi(dr1("ALTIAY"), 0)
                    dr("ONAY") = sorgu_sayi(dr1("ONAY"), 0)
                    dr("ONBESAY") = sorgu_sayi(dr1("ONBESAY"), 0)
                    dr("EFIYAT5") = sorgu_sayi(dr1("FIYAT5"), 0)
                    dr("EFIYAT6") = sorgu_sayi(dr1("FIYAT6"), 0)
                    dr("EFIYAT7") = sorgu_sayi(dr1("FIYAT7"), 0)
                    dr("EFIYAT8") = sorgu_sayi(dr1("FIYAT8"), 0)
                    dr("EFIYAT9") = sorgu_sayi(dr1("FIYAT9"), 0)
                    dr("EFIYAT10") = sorgu_sayi(dr1("FIYAT10"), 0)
                    dr("ORANEKMALIYET") = dr1("ORANEKMALIYET") * 100
                    dr("ORAN1") = sorgu_sayi(dr1("ORAN1"), 0) * 100
                    dr("ORAN2") = sorgu_sayi(dr1("ORAN2"), 0) * 100
                    dr("ORAN3") = sorgu_sayi(dr1("ORAN3"), 0) * 100
                    dr("ORAN4") = sorgu_sayi(dr1("ORAN4"), 0) * 100
                    dr("ORAN5") = sorgu_sayi(dr1("ORAN5"), 0) * 100
                    dr("ORAN6") = sorgu_sayi(dr1("ORAN6"), 0) * 100
                    dr("ORAN7") = sorgu_sayi(dr1("ORAN7"), 0) * 100
                    dr("ORAN8") = sorgu_sayi(dr1("ORAN8"), 0) * 100
                    dr("ORAN9") = sorgu_sayi(dr1("ORAN9"), 0) * 100
                    dr("ORAN10") = sorgu_sayi(dr1("ORAN10"), 0) * 100
                    dr("SONALISMALIYETI") = sorgu_sayi(dr1("SONALISMALIYETI"), 0)
                    dr("ONCEKIALISMALIYETI") = sorgu_sayi(dr1("ONCEKIALISMALIYETI"), 0)
                    dr("ONCEKIALISTARIHI") = dr1("ONCEKIALISTARIHI")
                    dr("SONALISTARIHI") = dr1("SONALISTARIHI")
                    dr("NETMALIYET") = sorgu_sayi(dr1("NETMALIYET"), 0)
                    dr("STATUS") = 0
                    dr("SONUC") = "Yeni..."
                    dr("ORAN1") = sorgu_sayi(dr("ORAN1"), 0)
                    dr("ORAN2") = sorgu_sayi(dr("ORAN2"), 0)
                    dr("ORAN3") = sorgu_sayi(dr("ORAN3"), 0)
                    dr("ORAN4") = sorgu_sayi(dr("ORAN4"), 0)
                    dr("FIYAT1") = dr("PESIN")
                    dr("FIYAT2") = dr("ALTIAY")
                    dr("FIYAT3") = dr("ONAY")
                    dr("FIYAT4") = dr("ONBESAY")
                    dr("FIYAT5") = dr("EFIYAT5")
                    dr("FIYAT6") = dr("EFIYAT6")
                    dr("FIYAT7") = dr("EFIYAT7")
                    dr("FIYAT8") = dr("EFIYAT8")
                    dr("FIYAT9") = dr("EFIYAT9")
                    dr("FIYAT10") = dr("EFIYAT10")
                    dr("MALIYET") = sorgu_sayi(dr1("NETMALIYET"), 0)
                    dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("TARIH"), dr("FISTARIHI"), dr("FISNO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("STOKADI"), dr("MIKTAR"), dr("BIRIMMALIYET"), dr("BIRIMFIYAT"), dr("ISKONTO"), dr("KDV"), dr("KDVLITUTAR"), dr("FATURAMIKTARI"), dr("FATURATUTARI"), dr("EKMALIYET"), dr("RENK"), dr("PESIN"), dr("ONAY"), dr("ALTIAY"), dr("ORANEKMALIYET"), dr("ORAN1"), dr("ORAN2"), dr("ORAN3"), dr("SONALISMALIYETI"), dr("ONCEKIALISMALIYETI"), dr("ONCEKIALISTARIHI"), dr("SONALISTARIHI"), dr("NETMALIYET"), dr("STATUS"), dr("SONUC"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("MALIYET"), sorgu_sayi(dr("ONBESAY"), 0), sorgu_sayi(dr("ORAN4"), 0), sorgu_sayi(dr("FIYAT4"), 0), sorgu_sayi(dr("FIYAT5"), 0), sorgu_sayi(dr("EFIYAT5"), 0), sorgu_sayi(dr("FIYAT6"), 0), sorgu_sayi(dr("EFIYAT6"), 0), sorgu_sayi(dr("FIYAT7"), 0), sorgu_sayi(dr("EFIYAT7"), 0), sorgu_sayi(dr("FIYAT8"), 0), sorgu_sayi(dr("EFIYAT8"), 0), sorgu_sayi(dr("FIYAT9"), 0), sorgu_sayi(dr("EFIYAT9"), 0), sorgu_sayi(dr("FIYAT10"), 0), sorgu_sayi(dr("EFIYAT10"), 0), sorgu_sayi(dr("ORAN5"), 0), sorgu_sayi(dr("ORAN6"), 0), sorgu_sayi(dr("ORAN7"), 0), sorgu_sayi(dr("ORAN8"), 0), sorgu_sayi(dr("ORAN9"), 0), sorgu_sayi(dr("ORAN10"), 0))
                    'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                    ds_hareket.Tables(0).Rows.Add(dr)
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
                If yeni = True Then
                    Timer1.Enabled = False
                    toplam_hesapla()
                    If miktar - detay_miktar = 0 Then
                        XtraMessageBox.Show(Sorgu_sDil("Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        satir_ekle_stok(False)
                    End If
                    Timer1.Enabled = True
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
    End Sub
    Private Sub satir_ekle(ByVal ara As String)
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If ara <> "" Then
            frm.qgelismis = sec_kriter.Text
            frm.gelismis = ara
            frm.status = True
            frm.mevcut = mevcut
        End If
        frm.islemstatus = True
        Dim yeni As Boolean = False
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
                    dr = ds_hareket.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("EVRAKNO") = belgeind
                    dr("TARIH") = dr_baslik("TARIH")
                    dr("FISTARIHI") = dr_baslik("TARIH")
                    dr("FISNO") = belgeind
                    dr("FIRMAKODU") = ""
                    dr("FIRMAADI") = ""
                    dr("STOKNO") = dr1("nStokID")
                    dr("STOKKODU") = Trim(dr1("sKodu"))
                    dr("STOKADI") = Trim(Microsoft.VisualBasic.Left(dr1("sAciklama"), 50))
                    dr("MIKTAR") = 1
                    dr1("MALIYET") = sorgu_sayi(dr1("MALIYET"), 0)
                    dr("BIRIMMALIYET") = sorgu_sayi(dr1("MALIYET"), 0)
                    dr("BIRIMFIYAT") = sorgu_sayi(dr1("MALIYET"), 0)
                    dr("ISKONTO") = 0
                    dr("KDV") = 0
                    dr("KDVLITUTAR") = sorgu_sayi(dr1("MALIYET"), 0)
                    dr("FATURAMIKTARI") = 0
                    dr("FATURATUTARI") = 0
                    dr("EKMALIYET") = 0
                    dr("RENK") = dr1("sRenkAdi").ToString
                    dr("PESIN") = sorgu_sayi(dr1("lFiyat1"), 0)
                    dr("ALTIAY") = sorgu_sayi(dr1("lFiyat2"), 0)
                    dr("ONAY") = sorgu_sayi(dr1("lFiyat3"), 0)
                    dr("ONBESAY") = sorgu_sayi(dr1("lFiyat4"), 0)
                    dr("EFIYAT5") = sorgu_sayi(dr1("lFiyat5"), 0)
                    dr("EFIYAT6") = sorgu_sayi(dr1("FIYAT6"), 0)
                    dr("EFIYAT7") = sorgu_sayi(dr1("lFiyat7"), 0)
                    dr("EFIYAT8") = sorgu_sayi(dr1("lFiyat8"), 0)
                    dr("EFIYAT9") = sorgu_sayi(dr1("lFiyat9"), 0)
                    dr("EFIYAT10") = sorgu_sayi(dr1("lFiyat10"), 0)
                    dr("FIYAT5") = dr("EFIYAT5")
                    dr("FIYAT6") = dr("EFIYAT6")
                    dr("FIYAT7") = dr("EFIYAT7")
                    dr("FIYAT8") = dr("EFIYAT8")
                    dr("FIYAT9") = dr("EFIYAT9")
                    dr("FIYAT10") = dr("EFIYAT10")
                    dr("ORANEKMALIYET") = 0
                    Dim maliyet As Decimal = sorgu_sayi(dr1("MALIYET"), 0)
                    Try
                        If dr("PESIN") <> 0 Then
                            dr("ORAN1") = ((dr("PESIN") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN1") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("ALTIAY") <> 0 Then
                            dr("ORAN2") = ((dr("ALTIAY") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN2") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("ONAY") <> 0 Then
                            dr("ORAN3") = ((dr("ONAY") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN3") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("ONBESAY") <> 0 Then
                            dr("ORAN4") = ((dr("ONBESAY") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN4") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("FIYAT5") <> 0 Then
                            dr("ORAN5") = ((dr("FIYAT5") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN5") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("FIYAT6") <> 0 Then
                            dr("ORAN6") = ((dr("FIYAT6") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN6") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("FIYAT7") <> 0 Then
                            dr("ORAN7") = ((dr("FIYAT7") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN7") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("FIYAT8") <> 0 Then
                            dr("ORAN8") = ((dr("FIYAT8") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN8") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("FIYAT9") <> 0 Then
                            dr("ORAN9") = ((dr("FIYAT9") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN9") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr("FIYAT10") <> 0 Then
                            dr("ORAN10") = ((dr("FIYAT10") - maliyet) / maliyet) * 100
                        Else
                            dr("ORAN10") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    dr("ORAN1") = sorgu_sayi(dr("ORAN1"), 0)
                    dr("ORAN2") = sorgu_sayi(dr("ORAN2"), 0)
                    dr("ORAN3") = sorgu_sayi(dr("ORAN3"), 0)
                    dr("ORAN4") = sorgu_sayi(dr("ORAN4"), 0)
                    dr("ORAN5") = sorgu_sayi(dr("ORAN5"), 0)
                    dr("ORAN6") = sorgu_sayi(dr("ORAN6"), 0)
                    dr("ORAN7") = sorgu_sayi(dr("ORAN7"), 0)
                    dr("ORAN8") = sorgu_sayi(dr("ORAN8"), 0)
                    dr("ORAN9") = sorgu_sayi(dr("ORAN9"), 0)
                    dr("ORAN10") = sorgu_sayi(dr("ORAN10"), 0)
                    dr("FIYAT1") = dr("PESIN")
                    dr("FIYAT2") = dr("ALTIAY")
                    dr("FIYAT3") = dr("ONAY")
                    dr("FIYAT4") = dr("ONBESAY")

                    dr("MALIYET") = sorgu_sayi(dr1("MALIYET"), 0)
                    dr("SONALISMALIYETI") = sorgu_sayi(maliyet, 0)
                    dr("ONCEKIALISMALIYETI") = 0
                    dr("ONCEKIALISTARIHI") = "01/01/1900"
                    dr("SONALISTARIHI") = "01/01/1900"
                    dr("NETMALIYET") = sorgu_sayi(maliyet, 0)
                    dr("STATUS") = 0
                    dr("SONUC") = "Yeni..."
                    dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("TARIH"), dr("FISTARIHI"), dr("FISNO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("STOKADI"), dr("MIKTAR"), sorgu_sayi(dr("BIRIMMALIYET"), 0), sorgu_sayi(dr("BIRIMFIYAT"), 0), sorgu_sayi(dr("ISKONTO"), 0), sorgu_sayi(dr("KDV"), 0), sorgu_sayi(dr("KDVLITUTAR"), 0), sorgu_sayi(dr("FATURAMIKTARI"), 0), sorgu_sayi(dr("FATURATUTARI"), 0), sorgu_sayi(dr("EKMALIYET"), 0), dr("RENK"), sorgu_sayi(dr("PESIN"), 0), sorgu_sayi(dr("ONAY"), 0), sorgu_sayi(dr("ALTIAY"), 0), sorgu_sayi(dr("ORANEKMALIYET"), 0), sorgu_sayi(dr("ORAN1"), 0), sorgu_sayi(dr("ORAN2"), 0), sorgu_sayi(dr("ORAN3"), 0), sorgu_sayi(dr("SONALISMALIYETI"), 0), sorgu_sayi(dr("ONCEKIALISMALIYETI"), 0), dr("ONCEKIALISTARIHI"), dr("SONALISTARIHI"), sorgu_sayi(dr("NETMALIYET"), 0), dr("STATUS"), dr("SONUC"), sorgu_sayi(dr("FIYAT1"), 0), sorgu_sayi(dr("FIYAT2"), 0), sorgu_sayi(dr("FIYAT3"), 0), sorgu_sayi(dr("MALIYET"), 0), sorgu_sayi(dr("ONBESAY"), 0), sorgu_sayi(dr("ORAN4"), 0), sorgu_sayi(dr("FIYAT4"), 0), sorgu_sayi(dr("FIYAT5"), 0), sorgu_sayi(dr("EFIYAT5"), 0), sorgu_sayi(dr("FIYAT6"), 0), sorgu_sayi(dr("EFIYAT6"), 0), sorgu_sayi(dr("FIYAT7"), 0), sorgu_sayi(dr("EFIYAT7"), 0), sorgu_sayi(dr("FIYAT8"), 0), sorgu_sayi(dr("EFIYAT8"), 0), sorgu_sayi(dr("FIYAT9"), 0), sorgu_sayi(dr("EFIYAT9"), 0), sorgu_sayi(dr("FIYAT10"), 0), sorgu_sayi(dr("EFIYAT10"), 0), sorgu_sayi(dr("ORAN5"), 0), sorgu_sayi(dr("ORAN6"), 0), sorgu_sayi(dr("ORAN7"), 0), sorgu_sayi(dr("ORAN8"), 0), sorgu_sayi(dr("ORAN9"), 0), sorgu_sayi(dr("ORAN10"), 0))
                    'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                    ds_hareket.Tables(0).Rows.Add(dr)
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
                If yeni = True Then
                    Timer1.Enabled = False
                    toplam_hesapla()
                    If miktar - detay_miktar = 0 Then
                        XtraMessageBox.Show(Sorgu_sDil("Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        satir_ekle_stok(False)
                    End If
                    Timer1.Enabled = True
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
    End Sub
    Private Sub satir_ekle_tek(ByVal ara As String, Optional ByVal lFiyat1 As Decimal = 0, Optional ByVal lFiyat2 As Decimal = 0, Optional ByVal lFiyat3 As Decimal = 0, Optional ByVal lFiyat4 As Decimal = 0, Optional ByVal lFiyat5 As Decimal = 0, Optional ByVal lFiyat6 As Decimal = 0, Optional ByVal lFiyat7 As Decimal = 0, Optional ByVal lFiyat8 As Decimal = 0, Optional ByVal lFiyat9 As Decimal = 0, Optional ByVal lFiyat10 As Decimal = 0)
        dr = ds_hareket.Tables(0).NewRow
        Dim dr1 As DataRow
        dr1 = ds_stok.Tables(0).Rows(0)
        dr("EVRAKNO") = belgeind
        dr("TARIH") = dr_baslik("TARIH")
        dr("FISTARIHI") = dr_baslik("TARIH")
        dr("FISNO") = belgeind
        dr("FIRMAKODU") = ""
        dr("FIRMAADI") = ""
        dr("STOKNO") = dr1("nStokID")
        dr("STOKKODU") = Trim(dr1("sKodu"))
        dr("STOKADI") = Trim(Microsoft.VisualBasic.Left(dr1("sAciklama"), 50))
        dr("MIKTAR") = 1
        dr("BIRIMMALIYET") = sorgu_sayi(dr1("MALIYET"), 0)
        dr("BIRIMFIYAT") = sorgu_sayi(dr1("MALIYET"), 0)
        dr("ISKONTO") = 0
        dr("KDV") = 0
        dr("KDVLITUTAR") = sorgu_sayi(dr1("MALIYET"), 0)
        dr("FATURAMIKTARI") = 0
        dr("FATURATUTARI") = 0
        dr("EKMALIYET") = 0
        dr("RENK") = dr1("sRenkAdi").ToString
        If lFiyat1 = 0 Then
            dr("PESIN") = sorgu_sayi(dr1("PESIN"), 0)
        Else
            dr("PESIN") = sorgu_sayi(lFiyat1, 0)
        End If
        If lFiyat2 = 0 Then
            dr("ALTIAY") = sorgu_sayi(dr1("ALTIAY"), 0)
        Else
            dr("ALTIAY") = sorgu_sayi(lFiyat2, 0)
        End If
        If lFiyat3 = 0 Then
            dr("ONAY") = sorgu_sayi(dr1("ONAY"), 0)
        Else
            dr("ONAY") = sorgu_sayi(lFiyat3, 0)
        End If
        If lFiyat4 = 0 Then
            dr("ONBESAY") = sorgu_sayi(dr1("ONBESAY"), 0)
        Else
            dr("ONBESAY") = sorgu_sayi(lFiyat4, 0)
        End If
        If lFiyat5 = 0 Then
            dr("EFIYAT5") = sorgu_sayi(dr1("FIYAT5"), 0)
        Else
            dr("EFIYAT5") = sorgu_sayi(lFiyat5, 0)
        End If
        If lFiyat6 = 0 Then
            dr("EFIYAT6") = sorgu_sayi(dr1("FIYAT6"), 0)
        Else
            dr("EFIYAT6") = sorgu_sayi(lFiyat6, 0)
        End If
        If lFiyat7 = 0 Then
            dr("EFIYAT7") = sorgu_sayi(dr1("FIYAT7"), 0)
        Else
            dr("EFIYAT7") = sorgu_sayi(lFiyat7, 0)
        End If
        If lFiyat8 = 0 Then
            dr("EFIYAT8") = sorgu_sayi(dr1("FIYAT8"), 0)
        Else
            dr("EFIYAT8") = sorgu_sayi(lFiyat8, 0)
        End If
        If lFiyat9 = 0 Then
            dr("EFIYAT9") = sorgu_sayi(dr1("FIYAT9"), 0)
        Else
            dr("EFIYAT9") = sorgu_sayi(lFiyat9, 0)
        End If
        If lFiyat10 = 0 Then
            dr("EFIYAT10") = sorgu_sayi(dr1("FIYAT10"), 0)
        Else
            dr("EFIYAT10") = sorgu_sayi(lFiyat10, 0)
        End If
        dr("FIYAT5") = dr("EFIYAT5")
        dr("FIYAT6") = dr("EFIYAT6")
        dr("FIYAT7") = dr("EFIYAT7")
        dr("FIYAT8") = dr("EFIYAT8")
        dr("FIYAT9") = dr("EFIYAT9")
        dr("FIYAT10") = dr("EFIYAT10")
        dr("ORANEKMALIYET") = 0
        Dim maliyet As Decimal = sorgu_sayi(dr1("MALIYET"), 0)
        Try
            If dr("PESIN") <> 0 Then
                dr("ORAN1") = ((dr("PESIN") - maliyet) / maliyet) * 100
            Else
                dr("ORAN1") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("ALTIAY") <> 0 Then
                dr("ORAN2") = ((dr("ALTIAY") - maliyet) / maliyet) * 100
            Else
                dr("ORAN2") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("ONAY") <> 0 Then
                dr("ORAN3") = ((dr("ONAY") - maliyet) / maliyet) * 100
            Else
                dr("ORAN3") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("ONBESAY") <> 0 Then
                dr("ORAN4") = ((dr("ONBESAY") - maliyet) / maliyet) * 100
            Else
                dr("ORAN4") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("FIYAT5") <> 0 Then
                dr("ORAN5") = ((dr("FIYAT5") - maliyet) / maliyet) * 100
            Else
                dr("ORAN5") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("FIYAT6") <> 0 Then
                dr("ORAN6") = ((dr("FIYAT6") - maliyet) / maliyet) * 100
            Else
                dr("ORAN6") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("FIYAT7") <> 0 Then
                dr("ORAN7") = ((dr("FIYAT7") - maliyet) / maliyet) * 100
            Else
                dr("ORAN7") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("FIYAT8") <> 0 Then
                dr("ORAN8") = ((dr("FIYAT8") - maliyet) / maliyet) * 100
            Else
                dr("ORAN8") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("FIYAT9") <> 0 Then
                dr("ORAN9") = ((dr("FIYAT9") - maliyet) / maliyet) * 100
            Else
                dr("ORAN9") = 0
            End If
        Catch ex As Exception
        End Try
        Try
            If dr("FIYAT10") <> 0 Then
                dr("ORAN10") = ((dr("FIYAT10") - maliyet) / maliyet) * 100
            Else
                dr("ORAN10") = 0
            End If
        Catch ex As Exception
        End Try
        dr("ORAN1") = sorgu_sayi(dr("ORAN1"), 0)
        dr("ORAN2") = sorgu_sayi(dr("ORAN2"), 0)
        dr("ORAN3") = sorgu_sayi(dr("ORAN3"), 0)
        dr("ORAN4") = sorgu_sayi(dr("ORAN4"), 0)
        dr("ORAN5") = sorgu_sayi(dr("ORAN5"), 0)
        dr("ORAN6") = sorgu_sayi(dr("ORAN6"), 0)
        dr("ORAN7") = sorgu_sayi(dr("ORAN7"), 0)
        dr("ORAN8") = sorgu_sayi(dr("ORAN8"), 0)
        dr("ORAN9") = sorgu_sayi(dr("ORAN9"), 0)
        dr("ORAN10") = sorgu_sayi(dr("ORAN10"), 0)
        dr("FIYAT1") = sorgu_sayi(dr("PESIN"), 0)
        dr("FIYAT2") = sorgu_sayi(dr("ALTIAY"), 0)
        dr("FIYAT3") = sorgu_sayi(dr("ONAY"), 0)
        dr("FIYAT4") = sorgu_sayi(dr("ONBESAY"), 0)
        dr("MALIYET") = sorgu_sayi(dr1("MALIYET"), 0)
        dr("SONALISMALIYETI") = sorgu_sayi(maliyet, 0)
        dr("ONCEKIALISMALIYETI") = 0
        dr("ONCEKIALISTARIHI") = "01/01/1900"
        dr("SONALISTARIHI") = "01/01/1900"
        dr("NETMALIYET") = sorgu_sayi(dr1("MALIYET"), 0)
        dr("STATUS") = 0
        dr("SONUC") = "Yeni..."
        dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("TARIH"), dr("FISTARIHI"), dr("FISNO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("STOKADI"), dr("MIKTAR"), dr("BIRIMMALIYET"), dr("BIRIMFIYAT"), dr("ISKONTO"), dr("KDV"), dr("KDVLITUTAR"), dr("FATURAMIKTARI"), dr("FATURATUTARI"), dr("EKMALIYET"), dr("RENK"), dr("PESIN"), dr("ONAY"), dr("ALTIAY"), dr("ORANEKMALIYET"), dr("ORAN1"), dr("ORAN2"), dr("ORAN3"), dr("SONALISMALIYETI"), dr("ONCEKIALISMALIYETI"), dr("ONCEKIALISTARIHI"), dr("SONALISTARIHI"), dr("NETMALIYET"), dr("STATUS"), dr("SONUC"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("MALIYET"), sorgu_sayi(dr("ONBESAY"), 0), sorgu_sayi(dr("ORAN4"), 0), sorgu_sayi(dr("FIYAT4"), 0), sorgu_sayi(dr("FIYAT5"), 0), sorgu_sayi(dr("EFIYAT5"), 0), sorgu_sayi(dr("FIYAT6"), 0), sorgu_sayi(dr("EFIYAT6"), 0), sorgu_sayi(dr("FIYAT7"), 0), sorgu_sayi(dr("EFIYAT7"), 0), sorgu_sayi(dr("FIYAT8"), 0), sorgu_sayi(dr("EFIYAT8"), 0), sorgu_sayi(dr("FIYAT9"), 0), sorgu_sayi(dr("EFIYAT9"), 0), sorgu_sayi(dr("FIYAT10"), 0), sorgu_sayi(dr("EFIYAT10"), 0), sorgu_sayi(dr("ORAN5"), 0), sorgu_sayi(dr("ORAN6"), 0), sorgu_sayi(dr("ORAN7"), 0), sorgu_sayi(dr("ORAN8"), 0), sorgu_sayi(dr("ORAN9"), 0), sorgu_sayi(dr("ORAN10"), 0))
        'dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
        ds_hareket.Tables(0).Rows.Add(dr)
        Me.Refresh()
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
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
        If lFiyat = 0 And bFiyatSifirGirilsin = False Then
            If nFiyatlandirma = 0 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
            ElseIf nFiyatlandirma = 2 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden ='" & sBeden & "'"
            End If
        Else
            If nFiyatlandirma = 0 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
            ElseIf nFiyatlandirma = 2 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden = '" & sBeden & "' "
            End If
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
    Private Sub duzelt_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " , dteFiyatTespittarihi = '" & Today & "' where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub duzelt_fiyat_renk(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal modelno As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & ", dteFiyatTespittarihi = '" & Today & "' where nStokID IN (Select nStokID from tbStok where sModel ='" & modelno & "') AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub ekle_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        If fiyat = 0 Then
            cmd.CommandText = sorgu_query("DELETE FROM tbStokFiyati    Where sFiyatTipi ='" & fiyattipi & "' and nStokID = " & stokno & " ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & Today & "', '" & sKullaniciAdi & "', GETDATE())")
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & Today & "', 'MUHASEBE', GETDATE())")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Fiyatlarý Kontrol Ediniz Kayýt Hatasý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (nStokID = " & stokno & ") and (sFiyatTipi= '" & fiyattipi & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat,0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi As Decimal = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr_hareket("STOKNO").ToString <> "" Then
                    hareket_kaydet_sil(dr_hareket("IND"))
                End If
                'DataTable1.Rows.RemoveAt(GridView1.FocusedRowHandle - 1)
                ds_hareket.Tables(0).Rows.Remove(dr_hareket)
                'dr.Delete()
                'dr.AcceptChanges()
                'GridControl1.EndUpdate()
                'DataSet1.EndInit()
                GridControl1.Select()
                GridControl1.Focus()
            End If
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
        'Plan Baþlýk
        cmd.CommandText = sorgu_query("DELETE FROM    ASTOKFIYATDEGISIMBASLIK WHERE IND =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Plan Hareket
        cmd.CommandText = sorgu_query("DELETE FROM    ASTOKFIYATDEGISIMDETAY WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
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
            hareket_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("TARIH"), dr("FISTARIHI"), dr("FISNO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("STOKADI"), dr("MIKTAR"), dr("BIRIMMALIYET"), dr("BIRIMFIYAT"), dr("ISKONTO"), dr("KDV"), dr("KDVLITUTAR"), dr("FATURAMIKTARI"), dr("FATURATUTARI"), dr("EKMALIYET"), dr("RENK"), dr("PESIN"), dr("ONAY"), dr("ALTIAY"), dr("ORANEKMALIYET"), dr("ORAN1"), dr("ORAN2"), dr("ORAN3"), dr("SONALISMALIYETI"), dr("ONCEKIALISMALIYETI"), dr("ONCEKIALISTARIHI"), dr("SONALISTARIHI"), dr("NETMALIYET"), dr("STATUS"), dr("SONUC"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("MALIYET"), sorgu_sayi(dr("ONBESAY"), 0), FormatNumber(sorgu_sayi(dr("ORAN4"), 0), 2), FormatNumber(sorgu_sayi(dr("FIYAT4"), 0), 4), sorgu_sayi(dr("FIYAT5"), 0), sorgu_sayi(dr("EFIYAT5"), 0), sorgu_sayi(dr("FIYAT6"), 0), sorgu_sayi(dr("EFIYAT6"), 0), sorgu_sayi(dr("FIYAT7"), 0), sorgu_sayi(dr("EFIYAT7"), 0), sorgu_sayi(dr("FIYAT8"), 0), sorgu_sayi(dr("EFIYAT8"), 0), sorgu_sayi(dr("FIYAT9"), 0), sorgu_sayi(dr("EFIYAT9"), 0), sorgu_sayi(dr("FIYAT10"), 0), sorgu_sayi(dr("EFIYAT10"), 0), sorgu_sayi(dr("ORAN5"), 0), sorgu_sayi(dr("ORAN6"), 0), sorgu_sayi(dr("ORAN7"), 0), sorgu_sayi(dr("ORAN8"), 0), sorgu_sayi(dr("ORAN9"), 0), sorgu_sayi(dr("ORAN10"), 0))
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
            ElseIf columnkriter = "ORAN4" Then
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
            ElseIf columnkriter = "ONBESAY" Then
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
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            If dr("MIKTAR") = 0 Then
                dr("MIKTAR") = 1
            End If
            dr("ORAN1") = sorgu_sayi(dr("ORAN1"), 0)
            dr("ORAN2") = sorgu_sayi(dr("ORAN2"), 0)
            dr("ORAN3") = sorgu_sayi(dr("ORAN3"), 0)
            dr("ORAN4") = sorgu_sayi(dr("ORAN4"), 0)
            dr("ORAN5") = sorgu_sayi(dr("ORAN5"), 0)
            dr("ORAN6") = sorgu_sayi(dr("ORAN6"), 0)
            dr("ORAN7") = sorgu_sayi(dr("ORAN7"), 0)
            dr("ORAN8") = sorgu_sayi(dr("ORAN8"), 0)
            dr("ORAN9") = sorgu_sayi(dr("ORAN9"), 0)
            dr("ORAN10") = sorgu_sayi(dr("ORAN10"), 0)
            dr("FIYAT1") = sorgu_sayi(dr("FIYAT1"), 0)
            dr("FIYAT2") = sorgu_sayi(dr("FIYAT2"), 0)
            dr("FIYAT3") = sorgu_sayi(dr("FIYAT3"), 0)
            dr("FIYAT4") = sorgu_sayi(dr("FIYAT4"), 0)
            dr("FIYAT5") = sorgu_sayi(dr("FIYAT5"), 0)
            dr("FIYAT6") = sorgu_sayi(dr("FIYAT6"), 0)
            dr("FIYAT7") = sorgu_sayi(dr("FIYAT7"), 0)
            dr("FIYAT8") = sorgu_sayi(dr("FIYAT8"), 0)
            dr("FIYAT9") = sorgu_sayi(dr("FIYAT9"), 0)
            dr("FIYAT10") = sorgu_sayi(dr("FIYAT10"), 0)
            'If GridView1.FocusedColumn.Name.ToString = colHTUTAR.Name.ToString Then
            '    dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
            'Else
            '    dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            'End If
            'dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("TARIH"), dr("FISTARIHI"), dr("FISNO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("STOKNO"), dr("STOKKODU"), dr("STOKADI"), dr("MIKTAR"), dr("BIRIMMALIYET"), dr("BIRIMFIYAT"), dr("ISKONTO"), dr("KDV"), dr("KDVLITUTAR"), dr("FATURAMIKTARI"), dr("FATURATUTARI"), dr("EKMALIYET"), dr("RENK"), dr("PESIN"), dr("ONAY"), dr("ALTIAY"), dr("ORANEKMALIYET"), dr("ORAN1"), dr("ORAN2"), dr("ORAN3"), dr("SONALISMALIYETI"), dr("ONCEKIALISMALIYETI"), dr("ONCEKIALISTARIHI"), dr("SONALISTARIHI"), dr("NETMALIYET"), dr("STATUS"), dr("SONUC"), dr("FIYAT1"), dr("FIYAT2"), dr("FIYAT3"), dr("MALIYET"), sorgu_sayi(dr("ONBESAY"), 0), FormatNumber(sorgu_sayi(dr("ORAN4"), 0), 2), FormatNumber(sorgu_sayi(dr("FIYAT4"), 0), 4), sorgu_sayi(dr("FIYAT5"), 0), sorgu_sayi(dr("EFIYAT5"), 0), sorgu_sayi(dr("FIYAT6"), 0), sorgu_sayi(dr("EFIYAT6"), 0), sorgu_sayi(dr("FIYAT7"), 0), sorgu_sayi(dr("EFIYAT7"), 0), sorgu_sayi(dr("FIYAT8"), 0), sorgu_sayi(dr("EFIYAT8"), 0), sorgu_sayi(dr("FIYAT9"), 0), sorgu_sayi(dr("EFIYAT9"), 0), sorgu_sayi(dr("FIYAT10"), 0), sorgu_sayi(dr("EFIYAT10"), 0), sorgu_sayi(dr("ORAN5"), 0), sorgu_sayi(dr("ORAN6"), 0), sorgu_sayi(dr("ORAN7"), 0), sorgu_sayi(dr("ORAN8"), 0), sorgu_sayi(dr("ORAN9"), 0), sorgu_sayi(dr("ORAN10"), 0))
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_DegerYay.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView1.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirEkleAlis.Click
        If dr_baslik("IND") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            satir_ekle_stok(False)
            Timer1.Enabled = True
        ElseIf dr_baslik("IND") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Fiyat Deðiþim Föyü Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Vgrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles Vgrid_baslik.CellValueChanged
        Try
            'Vgrid_baslik.PostEditor()
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
            'If dr_baslik("FIRMANO") = 0 Then
            '    dataload_hareket()
            'End If
            baslik_degistir()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub baslik_degistir()
        Try
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
            If dr_baslik("HATIRLAT") = "01/01/1900" Then
                If IsNumeric(dr_baslik("KOD5")) = True And sorgu_sayi(dr_baslik("KOD5"), 0) > 0 Then
                    gorev_sil(dr_baslik("KOD5"))
                    dr_baslik("KOD5") = 0
                End If
            Else
                Dim tarih As DateTime = dr_baslik("HATIRLAT")
                If IsNumeric(dr_baslik("KOD5")) = True And sorgu_sayi(dr_baslik("KOD5"), 0) > 0 Then
                    gorev_duzelt(dr_baslik("KOD5"), 2, 0, "", kullanici, 0, "Fiyat Deðiþim-" & dr_baslik("ACIKLAMA").ToString, dr_baslik("TARIH") & " Tarihli " & dr_baslik("BELGENO") & " Nolu Fiyat Deðiþim Föyü Güncellemesi Yapýlacaktýr" & vbCrLf & dr_baslik("ACIKLAMA").ToString, 1, Microsoft.VisualBasic.Left(dr_baslik("HATIRLAT").ToString, 10) & " " & "08:00:00", Microsoft.VisualBasic.Left(dr_baslik("HATIRLAT").ToString, 10) & " " & "08:00:00", "Fiyat Deðiþim Föyü", 0, 0, "", "<Reminders><Reminder AlertTime=""" & tarih.Month & "/" & tarih.Day & "/" & tarih.Year & " 07:45:00""/></Reminders>", 0, "", 0, 0, 0)
                Else
                    dr_baslik("KOD5") = gorev_ekle(2, 0, "", kullanici, 0, "Fiyat Deðiþim-" & dr_baslik("ACIKLAMA").ToString, dr_baslik("TARIH") & " Tarihli " & dr_baslik("BELGENO") & " Nolu Fiyat Deðiþim Föyü Güncellemesi Yapýlacaktýr" & vbCrLf & dr_baslik("ACIKLAMA").ToString, 1, Microsoft.VisualBasic.Left(dr_baslik("HATIRLAT").ToString, 10) & " " & "08:00:00", Microsoft.VisualBasic.Left(dr_baslik("HATIRLAT").ToString, 10) & " " & "08:00:00", "Fiyat Deðiþim Föyü", 0, 0, "", "<Reminders><Reminder AlertTime=""" & tarih.Month & "/" & tarih.Day & "/" & tarih.Year & " 07:45:00""/></Reminders>", 0, "", 0, 0, 0)
                End If
            End If
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), "Yeni...", dr_baslik("bKilitli"), dr_baslik("HATIRLAT"))
        Catch ex As Exception
        End Try
    End Sub

    Private Function gorev_ekle(ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", NULL,'" & ReminderInfo & "', " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno As Int64 = sorgu_sayi(cmd.ExecuteScalar, 0)
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Private Sub gorev_duzelt(ByVal ID As Int64, ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirAjanda SET              FirmaTipi = " & FirmaTipi & ", FirmaNo = '" & FirmaNo & "', Firma = '" & Firma & "', PersonelNo = " & PersonelNo & ", Status = " & Status & ", Subject = '" & Subject & "', Description = '" & Description & "', StartTime = '" & StartTime & "', EndTime = '" & EndTime & "', Location = '" & Location & "', AllDay = " & AllDay & ", EventType = " & EventType & ",   Tutar = " & Tutar & ", Pb = '" & Pb & "', Odendi = " & Odendi & ", Gelecekmi = " & Gelecekmi & ",ReminderInfo = '" & ReminderInfo & "'  WHERE ID= '" & ID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub gorev_sil(ByVal ID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Delete from FROM         tbMarketSozlesmeDetayiTakip WHERE     (nGorevID = 39)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirAjanda  WHERE ID= '" & ID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
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
        If XtraMessageBox.Show(Sorgu_sDil("Fiyat Degisim Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            belge_iptal(belgeind)
            Me.Close()
        End If
    End Sub
    Private Sub frm_stok_paket_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If GridView1.RowCount = 0 Then
        '    If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..! " & vbCrLf & "Fiyat Deðiþim Föyü Kaydýný Silmek Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
        '        belge_iptal(belgeind)
        '        Me.Close()
        '    Else
        '    End If
        'Else
        '    Timer1.Enabled = False
        '    toplam_hesapla()
        '    baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), "Yeni...")
        '    Timer1.Enabled = True
        'End If
        'Tanýmlarý Sil
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
        'ds_hareket.Clear()
        'ds_hareket.Dispose()
        'ds_hareket = Nothing
        'DataTable2 = Nothing
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'DataColumn21 = Nothing
        'DataColumn22 = Nothing
        'DataColumn23 = Nothing
        'kisayol_hareket = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'sec_depo_baslik = Nothing
        'sec_depo_hareket = Nothing
        'ds_belgetipi.Clear()
        'ds_belgetipi.Dispose()
        'ds_belgetipi = Nothing
        'DataTable5 = Nothing
        'DataColumn83 = Nothing
        'DataColumn84 = Nothing
        'sec_baslik_belgetipi = Nothing
        'BarButtonItem8 = Nothing
        'ds_detay.Clear()
        'ds_detay.Dispose()
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
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn8 = Nothing
        'DataColumn9 = Nothing
        'DataColumn16 = Nothing
        'DataColumn18 = Nothing
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
        'DataColumn52 = Nothing
        'DataColumn53 = Nothing
        'DataColumn54 = Nothing
        'DataColumn55 = Nothing
        'DataColumn56 = Nothing
        'DataColumn57 = Nothing
        'DataColumn58 = Nothing
        'colIND = Nothing
        'colEVRAKNO = Nothing
        'colSTOKNO = Nothing
        'colSTOKKODU = Nothing
        'colSTOKADI = Nothing
        'colFIRMAKODU = Nothing
        'colFIRMAADI = Nothing
        'colFISTARIHI = Nothing
        'colFISNO = Nothing
        'colBIRIMMALIYET = Nothing
        'colBIRIMFIYAT = Nothing
        'colISKONTO = Nothing
        'colKDV = Nothing
        'colKDVLITUTAR = Nothing
        'colFATURAMIKTARI = Nothing
        'colFATURATUTARI = Nothing
        'colEKMALIYET = Nothing
        'colRENK = Nothing
        'colPESIN = Nothing
        'colALTIAY = Nothing
        'colONAY = Nothing
        'colORANEKMALIYET = Nothing
        'colORAN1 = Nothing
        'colORAN2 = Nothing
        'colORAN3 = Nothing
        'colSONALISMALIYETI = Nothing
        'colONCEKIALISMALIYETI = Nothing
        'colONCEKIALISTARIHI = Nothing
        'colSONALISTARIHI = Nothing
        'colNETMALIYET = Nothing
        'colSTATUS = Nothing
        'colSONUC = Nothing
        'DataColumn59 = Nothing
        'colMIKTAR = Nothing
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
        'Panelstatus = Nothing
        'ProgressBarControl1 = Nothing
        'barlabel2 = Nothing
        'barlabel = Nothing
        'bar = Nothing
        'BarButtonItem16 = Nothing
        'BarButtonItem17 = Nothing
        'BarButtonItem18 = Nothing
        'BarButtonItem19 = Nothing
        'BarButtonItem20 = Nothing
        'BarButtonItem21 = Nothing
        'BarButtonItem22 = Nothing
        'BarButtonItem23 = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub toplam_hesapla()
        'Dim dr As DataRow
        miktar = 0
        detay_miktar = 0
        Try
            If dr_baslik("IND") = 0 Then
                Label1.Text = "Yeni Fiyat Degisim Fisi" & vbCrLf & "Lutfen Teslim Fisi Bilgilerini Girin...!"
                Me.Label1.ForeColor = System.Drawing.Color.Red
                Label1.BackColor = System.Drawing.Color.White
            Else
            End If
            Label2.Text = Now.ToLongTimeString
            Label3.Text = Now.ToLongDateString
            'Label1.Text = detay_miktar - miktar
            If Label1.Visible = False Then
                'Label1.Visible = True
            Else
                'Label1.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Function sorgu_stok_info(ByVal stokkodu As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, CAST(SUM(TS.GIREN) AS MONEY) AS  GIREN, CAST(SUM(TS.CIKAN) AS MONEY) AS CIKAN, CAST(SUM(TS.KALAN) AS MONEY) AS KALAN, CAST(SUM(TS.BEKLEYEN) AS MONEY) AS  BEKLEYEN, tbRenk.sRenkAdi FROM (SELECT sAciklama , SUM(GIREN) AS GIREN , SUM(CIKAN) AS CIKAN , SUM(KALAN) AS KALAN , SUM(BEKLEYEN) AS BEKLEYEN , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel FROM (SELECT depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = '" & stokkodu & "') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY depo.sAciklama , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID WHERE (stok.sKodu = '" & stokkodu & "' and hareket.sFistipi <> 'T') GROUP BY depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sAciklama , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel) TS INNER JOIN tbRenk ON TS.sRenk COLLATE Turkish_CI_AS = tbRenk.sRenk GROUP BY TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, tbRenk.sRenkAdi")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_stok(ByVal stokkodu As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sBeden, stok.sModel, barkod.sBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, tbRenk.sRenkAdi, stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk WHERE stok.sKodu = '" & stokkodu & "' ) AS T  ORDER BY sKodu")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub satir_info()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_satir_stok = sorgu_stok_info(dr("STOKKODU"))
            ds_satir_stok_aciklama = sorgu_stok(dr("STOKKODU"))
            Dim dr1 As DataRow = ds_satir_stok.Tables(0).Rows(0)
            Dim dr2 As DataRow = ds_satir_stok_aciklama.Tables(0).Rows(0)
            If dr1("sRenkAdi").ToString <> "" Then
                Label1.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ") Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN") & vbCrLf & " PS:" & FormatNumber(dr2("PESIN"), 2) & "  6Ay:" & FormatNumber(dr2("ALTIAY"), 2) & " 10Ay:" & FormatNumber(dr2("ONAY"), 2) & " 15Ay:" & FormatNumber(dr2("ONBESAY"), 2)
            Else
                Label1.Text = dr1("STOKADI") & " Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN") & vbCrLf & " PS:" & FormatNumber(dr2("PESIN"), 2) & "  6Ay:" & FormatNumber(dr2("ALTIAY"), 2) & " 10Ay:" & FormatNumber(dr2("ONAY"), 2) & " 15Ay:" & FormatNumber(dr2("ONBESAY"), 2)
            End If
            'Label1.Text = Label1.Text & vbTab & " Peþin: " & dr2("PESIN") & " 6Ay: " & dr2("ALTIAY") & "10Ay: " & dr2("ONAY")
            'Label2.Text = dr1("STOKADI") & " Renk: " & dr1("sRenkAdi") & " Giren: " & dr1("GIREN") & "Çýkan: " & dr1("CIKAN") & " Kalan: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
            Label1.Refresh()
            dr1 = Nothing
            dr2 = Nothing
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        toplam_hesapla()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Kaydedip Yeni Fiyat Deðiþim Belgesi Açmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Timer1.Enabled = False
            toplam_hesapla()
            baslik_degistir()
            'baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), "Yeni...", dr_baslik("bKilitli"), dr_baslik("HATIRLAT"))
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
        End If
    End Sub
    Private Sub oran_kontrol()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            dr("FIYAT1") = sorgu_sayi(dr("FIYAT1"), 0)
            dr("FIYAT2") = sorgu_sayi(dr("FIYAT2"), 0)
            dr("FIYAT3") = sorgu_sayi(dr("FIYAT3"), 0)
            dr("FIYAT4") = sorgu_sayi(dr("FIYAT4"), 0)
            Try
                If dr("PESIN") <> 0 Then
                    dr("ORAN1") = ((dr("PESIN") - dr("NETMALIYET")) / dr("NETMALIYET")) * 100
                Else
                    dr("ORAN1") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ALTIAY") <> 0 Then
                    dr("ORAN2") = ((dr("ALTIAY") - dr("NETMALIYET")) / dr("NETMALIYET")) * 100
                Else
                    dr("ORAN2") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ONAY") <> 0 Then
                    dr("ORAN3") = ((dr("ONAY") - dr("NETMALIYET")) / dr("NETMALIYET")) * 100
                Else
                    dr("ORAN3") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ONBESAY") <> 0 Then
                    dr("ORAN4") = ((dr("ONBESAY") - dr("NETMALIYET")) / dr("NETMALIYET")) * 100
                Else
                    dr("ORAN4") = 0
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
            dr("ORAN1") = sorgu_sayi(dr("ORAN1"), 0)
            dr("ORAN2") = sorgu_sayi(dr("ORAN2"), 0)
            dr("ORAN3") = sorgu_sayi(dr("ORAN3"), 0)
            dr("ORAN4") = sorgu_sayi(dr("ORAN4"), 0)
            If dr("ORAN1") <> 0 Then
                dr("PESIN") = dr("NETMALIYET") * ((dr("ORAN1") + 100) / 100)
            End If
            If dr("ORAN2") <> 0 Then
                dr("ALTIAY") = dr("NETMALIYET") * ((dr("ORAN2") + 100) / 100)
            End If
            If dr("ORAN3") <> 0 Then
                dr("ONAY") = dr("NETMALIYET") * ((dr("ORAN3") + 100) / 100)
            End If
            If dr("ORAN4") <> 0 Then
                dr("ONBESAY") = dr("NETMALIYET") * ((dr("ORAN4") + 100) / 100)
            End If
            dr.EndEdit()
            dr = Nothing
            girdi_tutar_hesapla()
        End If
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal nIslem As Integer, Optional ByVal bDirekt As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr*) |Form*.fr*"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Fiyat Degisim"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Fiyat Degisim\Form" & sRaporUzanti & ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                dataload_baslik()
                report.RegisterData(ds_baslik)
                report.RegisterData(ds_hareket)
                report.RegisterData(ds_tbParamGenel)
                report.SetParameterValue("dteFisTarihi", dr_baslik("TARIH"))
                report.SetParameterValue("sFisNo", dr_baslik("BELGENO"))
                report.SetParameterValue("sFisTipi", "Fiyat Deðiþim Listesi")
                report.ScriptLanguage = Language.Vb
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
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                report_create_stok(sFile, " WHERE BASLIK.IND > 0", nIslem)
            End If
        End If
    End Sub
    Private Sub raporla_fr3(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " WHERE BASLIK.IND > 0"
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Fiyat Degisim"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKFIYATDEGISIMDETAY WHERE EVRAKNO =" & belgeind & " ORDER BY FIRMAKODU,FISNO")
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKFIYATDEGISIMBASLIK WHERE IND =" & belgeind & "")
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
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
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
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKFIYATDEGISIMDETAY WHERE EVRAKNO =" & belgeind & " ORDER BY FIRMAKODU,FISNO") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKFIYATDEGISIMBASLIK WHERE IND =" & belgeind & "") & ""
            args(3) = "qr_hareketéqr_baslik"
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
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub report_create_stok_etiket(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
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
            frx.SetVariable("FIYAT", "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'")
            'frx.SetVariable("HD_PESIN_tl", "" & fiyat_gizle(FormatNumber(fiyat1, 2)).ToString & "")
            'frx.SetVariable("HD_ALTIAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat2, 2)).ToString & "")
            'frx.SetVariable("HD_ONAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat3, 2)).ToString & "")
            qr_hareket = frx.FindObject("qr_hareket")
            'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi,stok.sBirimCinsi1,stok.sBirimCinsi2,stok.sKdvTipi")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden,stok.sKavala, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok")
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
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden,stok.sKavala, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok") & ""
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
            args(21) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'"
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
        dr_baslik("KOD5") = "Etiketleri Yazdýrýldý..."
        baslik_degistir()
    End Sub
    Private Function fiyat_gizle_tumu(ByVal fiyat1 As String, ByVal fiyat2 As String, ByVal fiyat3 As String)
        Dim deger1 As String
        Dim deger2 As String
        Dim deger3 As String
        deger1 = fiyat_gizle(FormatNumber(fiyat1, 2)).ToString
        deger2 = fiyat_gizle(FormatNumber(fiyat2, 2)).ToString
        deger3 = fiyat_gizle(FormatNumber(fiyat3, 2)).ToString
        Return deger1 + "-" + deger2 + "-" + deger3
        deger1 = Nothing
        deger2 = Nothing
        deger3 = Nothing
    End Function
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
        Dim frm As New frm_calc
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Fiyat Deðiþim Emri Ekranýndan Çýkmak Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin Satýþ Fiyatlarýný Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_satis()
        End If
    End Sub
    Private Sub guncelle_maliyets()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        For Each dr In ds_hareket.Tables(0).Rows
            Dim fiyat As Decimal = 0
            '15 AYLIK FÝYAT
            Try
                fiyat = sorgu_stok_fiyat(sFiyat4, dr("STOKNO"))
            Catch ex As Exception
                fiyat = 0
            End Try
            If fiyat = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlanmamýþ... Lütfen Tekrar Deneyiniz..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    ekle_fiyat(dr("STOKNO"), sFiyat4, dr("ONBESAY"), kullaniciadi)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlý : " & fiyat, sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("STOKNO"), sFiyat4, dr("ONBESAY"))
                End If
            End If
            '10 AYLIK FÝYAT
            Try
                fiyat = sorgu_stok_fiyat(sFiyat3, dr("STOKNO"))
            Catch ex As Exception
                fiyat = 0
            End Try
            If fiyat = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlanmamýþ... Lütfen Tekrar Deneyiniz..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    ekle_fiyat(dr("STOKNO"), sFiyat3, dr("ONAY"), kullaniciadi)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlý : " & fiyat, sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("STOKNO"), sFiyat3, dr("ONAY"))
                End If
            End If
            '6 AYLIK FÝYAT
            Try
                fiyat = sorgu_stok_fiyat(sFiyat2, dr("STOKNO"))
            Catch ex As Exception
                fiyat = 0
            End Try
            If fiyat = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlanmamýþ... Lütfen Tekrar Deneyiniz..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    ekle_fiyat(dr("STOKNO"), sFiyat2, dr("ALTIAY"), kullaniciadi)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlý : " & fiyat, sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("STOKNO"), sFiyat2, dr("ALTIAY"))
                End If
            End If
            '6 PEÞÝN
            Try
                fiyat = sorgu_stok_fiyat(sFiyat1, dr("STOKNO"))
            Catch ex As Exception
                fiyat = 0
            End Try
            If fiyat = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlanmamýþ... Lütfen Tekrar Deneyiniz..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    ekle_fiyat(dr("STOKNO"), sFiyat1, dr("PESIN"), kullaniciadi)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlý : " & fiyat, sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("STOKNO"), sFiyat1, dr("PESIN"))
                End If
            End If
            '6 Maliyet
            Try
                fiyat = sorgu_stok_fiyat(sFiyatM, dr("STOKNO"))
            Catch ex As Exception
                fiyat = 0
            End Try
            If fiyat = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlanmamýþ... Lütfen Tekrar Deneyiniz..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    ekle_fiyat(dr("STOKNO"), sFiyatM, dr("NETMALIYET"), kullaniciadi)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Fiyat Tanýmlý : " & fiyat, sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatýný Tanýmlamak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("STOKNO"), sFiyatM, dr("NETMALIYET"))
                End If
            End If
            fiyat = Nothing
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Sub dataload_stok(ByVal stokno As Int64)
        Dim kriter
        kriter = "WHERE (nStokID = " & stokno & ")  "
        ds_stok = sorgu(sorgu_query("SELECT     * FROM  tbStok " & kriter & ""))
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub gorunum_kaydet()
        'Vgrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FD\BASLIK\" & Me.Name.ToString & "")
        'VGrid_toplam.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\TOPLAM\" & Me.Name.ToString & "")
        'VGrid_masraf.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\MASRAF\" & Me.Name.ToString & "")
        'VGrid_iskonto.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\ISKONTO\" & Me.Name.ToString & "")
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FD\HAREKET\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        'Vgrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FD\BASLIK\" & Me.Name.ToString & "")
        'VGrid_toplam.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\TOPLAM\" & Me.Name.ToString & "")
        'VGrid_masraf.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\MASRAF\" & Me.Name.ToString & "")
        'VGrid_iskonto.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\ISKONTO\" & Me.Name.ToString & "")
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FD\HAREKET\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(dr_baslik("TARIH"), 10) & " Tarihli " & vbCrLf
        kriter += " FisNo = " & dr_baslik("BELGENO") & " Nolu BordroTipi: Fiyat Deðiþim Föyü:" & dr_baslik("ACIKLAMA")
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finan Bordro Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".xls"
            SaveFileDialog1.FileName = Trim("FiyatDegisim" & Replace(dr_baslik("TARIH"), "/", "_") & ".xls")
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_excel_csv()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Csv Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.csv) |*.csv"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".csv"
            SaveFileDialog1.FileName = Trim("FiyatDegisim" & Replace(dr_baslik("TARIH"), "/", "_") & ".csv")
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'GridView1.ExportToExcelOld(SaveFileDialog1.FileName.ToString)
                printlink1.CreateDocument(ps)
                ps.ExportToCsv(SaveFileDialog1.FileName.ToString)
                'ps.PreviewRibbonFormEx.ShowDialog()
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub guncelle_maliyet()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr In ds_hareket.Tables(0).Rows
            dataload_stok(dr("STOKNO"))
            For Each dr1 In ds_stok.Tables(0).Rows
                Dim fiyat As Decimal = 0
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyatM & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 Then
                    ekle_fiyat(dr("STOKNO"), "" & sFiyatM & "", dr("NETMALIYET"), kullaniciadi)
                ElseIf fiyat <> dr("NETMALIYET") Then
                    If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                        duzelt_fiyat_renk(dr("STOKNO"), "" & sFiyatM & "", dr("NETMALIYET"), dr1("sModel"))
                    ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                        duzelt_fiyat(dr("STOKNO"), "" & sFiyatM & "", dr("NETMALIYET"))
                    ElseIf dr1("nStokTipi") = 0 Then
                        duzelt_fiyat(dr("STOKNO"), "" & sFiyatM & "", dr("NETMALIYET"))
                    End If
                    'duzelt_fiyat(dr("STOKNO"), sFiyatM, dr("NETMALIYET"))
                End If
                fiyat = Nothing
            Next
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Stok Maliyetleri Baþarýyla Deðiþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        dr_baslik("KOD4") = "Maliyetleri Deðiþtirildi..."
        baslik_degistir()
    End Sub
    Private Sub guncelle_satis()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr In ds_hareket.Tables(0).Rows
            dataload_stok(dr("STOKNO"))
            barlabel.Text = "StokKodu:" & dr("STOKKODU") & " StokAdý: " & dr("STOKADI")
            barlabel.Refresh()
            For Each dr1 In ds_stok.Tables(0).Rows
                Dim fiyat As Decimal = 0
                '///////////////////////////////////15 AYLIK FÝYAT
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat4 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("ONBESAY") <> 0 Then
                    'ekle_fiyat(dr("STOKNO"), "" & sFiyat4 & "", dr("ONBESAY"), kullaniciadi)
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("ONBESAY"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("ONBESAY"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ONBESAY"), sFiyat4)
                ElseIf fiyat <> dr("ONBESAY") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("ONBESAY"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ONBESAY"), sFiyat4)
                ElseIf dr("ONBESAY") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("ONBESAY"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("ONBESAY"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat4)
                End If
                If EsFiyat4.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat4 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat4 & "", dr("ONBESAY") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("ONBESAY") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat4 & "", dr("ONBESAY") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat4 & "", dr("ONBESAY") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat4 & "", dr("ONBESAY") * 1000000)
                        End If
                    End If
                End If
                '///////////////////////////////////Fiyat 5
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat5 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("FIYAT5") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("FIYAT5"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("FIYAT5"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT5"), sFiyat5)
                ElseIf fiyat <> dr("FIYAT5") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("FIYAT5"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT5"), sFiyat5)
                ElseIf dr("FIYAT5") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("FIYAT5"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("FIYAT5"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat5)
                End If
                If EsFiyat5.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat5 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat5 & "", dr("FIYAT5") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("FIYAT5") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat5 & "", dr("FIYAT5") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat5 & "", dr("FIYAT5") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat5 & "", dr("FIYAT5") * 1000000)
                        End If
                    End If
                End If
                '///////////////////////////////////Fiyat 6
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat6 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("FIYAT6") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("FIYAT6"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("FIYAT6"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT6"), sFiyat6)
                ElseIf fiyat <> dr("FIYAT6") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("FIYAT6"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT6"), sFiyat6)
                ElseIf dr("FIYAT6") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("FIYAT6"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("FIYAT6"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat6)
                End If
                If EsFiyat6.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat6 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat6 & "", dr("FIYAT6") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("FIYAT6") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat6 & "", dr("FIYAT6") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat6 & "", dr("FIYAT6") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat6 & "", dr("FIYAT6") * 1000000)
                        End If
                    End If
                End If
                '///////////////////////////////////Fiyat 7
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat7 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("FIYAT7") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("FIYAT7"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("FIYAT7"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT7"), sFiyat7)
                ElseIf fiyat <> dr("FIYAT7") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("FIYAT7"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT7"), sFiyat7)
                ElseIf dr("FIYAT7") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("FIYAT7"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("FIYAT7"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat7)
                End If
                If EsFiyat7.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat7 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat7 & "", dr("FIYAT7") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("FIYAT7") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat7 & "", dr("FIYAT7") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat7 & "", dr("FIYAT7") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat7 & "", dr("FIYAT7") * 1000000)
                        End If
                    End If
                End If
                '///////////////////////////////////Fiyat 8
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat8 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("FIYAT8") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("FIYAT8"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("FIYAT8"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT8"), sFiyat8)
                ElseIf fiyat <> dr("FIYAT8") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("FIYAT8"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT8"), sFiyat8)
                ElseIf dr("FIYAT8") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("FIYAT8"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("FIYAT8"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat8)
                End If
                If EsFiyat8.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat8 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat8 & "", dr("FIYAT8") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("FIYAT8") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat8 & "", dr("FIYAT8") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat8 & "", dr("FIYAT8") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat8 & "", dr("FIYAT8") * 1000000)
                        End If
                    End If
                End If
                '///////////////////////////////////Fiyat 9
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat9 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("FIYAT9") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("FIYAT9"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("FIYAT9"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT9"), sFiyat9)
                ElseIf fiyat <> dr("FIYAT9") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("FIYAT9"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT9"), sFiyat9)
                ElseIf dr("FIYAT9") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("FIYAT9"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("FIYAT9"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat9)
                End If
                If EsFiyat9.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat9 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat9 & "", dr("FIYAT9") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("FIYAT9") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat9 & "", dr("FIYAT9") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat9 & "", dr("FIYAT9") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat9 & "", dr("FIYAT9") * 1000000)
                        End If
                    End If
                End If
                '///////////////////////////////////Fiyat 10
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat10 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("FIYAT10") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("FIYAT10"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("FIYAT10"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT10"), sFiyat10)
                ElseIf fiyat <> dr("FIYAT10") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("FIYAT10"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT10"), sFiyat10)
                ElseIf dr("FIYAT10") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("FIYAT10"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("FIYAT10"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat10)
                End If
                If EsFiyat10.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat10 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat10 & "", dr("FIYAT10") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("FIYAT10") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat10 & "", dr("FIYAT10") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat10 & "", dr("FIYAT10") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat10 & "", dr("FIYAT10") * 1000000)
                        End If
                    End If
                End If
                '///////////////////////////////////10 AYLIK FÝYAT
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat3 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("ONAY") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ONAY"), sFiyat3)
                ElseIf fiyat <> dr("ONAY") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ONAY"), sFiyat3)
                ElseIf dr("ONAY") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat3)
                End If
                If EsFiyat3.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat3 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat3 & "", dr("ONAY") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("ONAY") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat3 & "", dr("ONAY") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat3 & "", dr("ONAY") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat3 & "", dr("ONAY") * 1000000)
                        End If
                    End If
                End If
                '/////////////////////////////////////6 AYLIK FÝYAT
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat2 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("ALTIAY") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ALTIAY"), sFiyat2)
                ElseIf fiyat <> dr("ALTIAY") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ALTIAY"), sFiyat2)
                ElseIf dr("ALTIAY") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat2)
                End If
                If EsFiyat2.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat2 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat2 & "", dr("ALTIAY") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("ALTIAY") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat2 & "", dr("ALTIAY") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat2 & "", dr("ALTIAY") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat2 & "", dr("ALTIAY") * 1000000)
                        End If
                    End If
                End If
                ''/////////////////////////////////////////////PEÞÝN
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyat1 & "", dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("PESIN") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat1)
                ElseIf fiyat <> dr("PESIN") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat1)
                ElseIf dr("PESIN") = 0 Then
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat1)
                End If
                If EsFiyat1.ToString <> "" Then
                    Try
                        fiyat = sorgu_stok_fiyat("" & EsFiyat1 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("STOKNO"), "" & EsFiyat1 & "", dr("PESIN") * 1000000, kullaniciadi)
                    ElseIf fiyat <> dr("PESIN") * 1000000 Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("STOKNO"), "" & EsFiyat1 & "", dr("PESIN") * 1000000, dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat1 & "", dr("PESIN") * 1000000)
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("STOKNO"), "" & EsFiyat1 & "", dr("PESIN") * 1000000)
                        End If
                    End If
                End If
                fiyat = Nothing
            Next
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Stok Fiyatlarý Baþarýyla Deðiþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        dr_baslik("KOD3") = "Satýþ Fiyatlarý Deðiþtirildi..."
        baslik_degistir()
    End Sub
    Private Sub guncelle_satis_eski()
        Panelstatus.Visible = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        bar.Properties.Maximum = toplamsayi
        barlabel.Text = "Toplam Satýr Sayýsý : " & toplamsayi
        bar.Position = 0
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                dataload_stok(dr("STOKNO"))
                For Each dr1 In ds_stok.Tables(0).Rows
                    Dim fiyat As Decimal = 0
                    dr("FIYAT1") = sorgu_sayi(dr("FIYAT1"), 0)
                    dr("FIYAT2") = sorgu_sayi(dr("FIYAT2"), 0)
                    dr("FIYAT3") = sorgu_sayi(dr("FIYAT3"), 0)
                    dr("FIYAT4") = sorgu_sayi(dr("FIYAT4"), 0)
                    dr("EFIYAT5") = sorgu_sayi(dr("EFIYAT5"), 0)
                    dr("EFIYAT6") = sorgu_sayi(dr("EFIYAT6"), 0)
                    dr("EFIYAT7") = sorgu_sayi(dr("EFIYAT7"), 0)
                    dr("EFIYAT8") = sorgu_sayi(dr("EFIYAT8"), 0)
                    dr("EFIYAT9") = sorgu_sayi(dr("EFIYAT9"), 0)
                    dr("EFIYAT10") = sorgu_sayi(dr("EFIYAT10"), 0)
                    '///////////////////////////////////Fiyat 5
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat5 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("EFIYAT5") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("EFIYAT5"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("EFIYAT5"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT5"), sFiyat5)
                    ElseIf fiyat <> dr("EFIYAT5") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("EFIYAT5"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT5"), sFiyat5)
                    ElseIf dr("EFIYAT5") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("EFIYAT5"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("EFIYAT5"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat5)
                    End If
                    '///////////////////////////////////Fiyat 6
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat6 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("EFIYAT6") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("EFIYAT6"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("EFIYAT6"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT6"), sFiyat6)
                    ElseIf fiyat <> dr("EFIYAT6") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("EFIYAT6"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT6"), sFiyat6)
                    ElseIf dr("EFIYAT6") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("EFIYAT6"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("EFIYAT6"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat6)
                    End If
                    '///////////////////////////////////Fiyat 7
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat7 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("EFIYAT7") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("EFIYAT7"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("EFIYAT7"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT7"), sFiyat7)
                    ElseIf fiyat <> dr("EFIYAT7") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("EFIYAT7"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT7"), sFiyat7)
                    ElseIf dr("EFIYAT7") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("EFIYAT7"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("EFIYAT7"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat7)
                    End If
                    '///////////////////////////////////Fiyat 8
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat8 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("EFIYAT8") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("EFIYAT8"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("EFIYAT8"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT8"), sFiyat8)
                    ElseIf fiyat <> dr("EFIYAT8") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("EFIYAT8"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT8"), sFiyat8)
                    ElseIf dr("EFIYAT8") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("EFIYAT8"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("EFIYAT8"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat8)
                    End If
                    '///////////////////////////////////Fiyat 9
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat9 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("EFIYAT9") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("EFIYAT9"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("EFIYAT9"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT9"), sFiyat9)
                    ElseIf fiyat <> dr("EFIYAT9") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("EFIYAT9"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT9"), sFiyat9)
                    ElseIf dr("EFIYAT9") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("EFIYAT9"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("EFIYAT9"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat9)
                    End If
                    '///////////////////////////////////Fiyat 10
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat10 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("EFIYAT10") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("EFIYAT10"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("EFIYAT10"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT10"), sFiyat10)
                    ElseIf fiyat <> dr("EFIYAT10") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("EFIYAT10"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("EFIYAT10"), sFiyat10)
                    ElseIf dr("EFIYAT10") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("EFIYAT10"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("EFIYAT10"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat10)
                    End If
                    '///////////////////////////////////15 AYLIK FÝYAT
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat4 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("FIYAT4") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("FIYAT4"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("FIYAT4"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT4"), sFiyat4)
                    ElseIf fiyat <> dr("FIYAT4") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("FIYAT4"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT4"), sFiyat4)
                    ElseIf dr("FIYAT4") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("FIYAT4"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("FIYAT4"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat4)
                    End If
                    '///////////////////////////////////10 Aylýk Fiyat
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat3 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("FIYAT3") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("FIYAT3"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("FIYAT3"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT3"), sFiyat3)
                    ElseIf fiyat <> dr("FIYAT3") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("FIYAT3"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT3"), sFiyat3)
                    ElseIf dr("FIYAT3") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("FIYAT3"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("FIYAT3"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat3)
                    End If
                    '///////////////////////////////////6 Aylýk Fiyat
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat2 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("FIYAT2") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("FIYAT2"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("FIYAT2"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT2"), sFiyat2)
                    ElseIf fiyat <> dr("FIYAT2") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("FIYAT2"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT2"), sFiyat2)
                    ElseIf dr("FIYAT2") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("FIYAT2"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("FIYAT2"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat2)
                    End If
                    '///////////////////////////////////Peþin
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat1 & "", dr("STOKNO"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 And dr("FIYAT1") <> 0 Then
                        Try
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("FIYAT1"), dteSistemTarihi)
                            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("FIYAT1"), dteSistemTarihi, kullaniciadi)
                        Catch ex As Exception
                        End Try
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat1)
                    ElseIf fiyat <> dr("FIYAT1") Then
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("FIYAT1"), dteSistemTarihi)
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat1)
                    ElseIf dr("FIYAT1") = 0 Then
                        'Sýfýr fiyat kontrolü
                        If bFiyatSifirGirilsin = False Then
                            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("FIYAT1"), dteSistemTarihi)
                        Else
                            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("FIYAT1"), dteSistemTarihi)
                        End If
                        takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("FIYAT1"), sFiyat1)
                    End If
                    fiyat = Nothing
                Next
                bar.Position = bar.Position + 1
                bar.Refresh()
            Next
        End If
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Stok Fiyatlarý Eski Satýþ Fiyatlarýyla Baþarýyla Deðiþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        dr_baslik("KOD3") = "Satýþ Eski Fiyatlarý Deðiþtirildi..."
        baslik_degistir()
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
    Private Sub analiz_karlilik()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_karlilik
        frm.status = True
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokno = dr("STOKNO")
        frm.stokkodu = dr("STOKKODU")
        frm.qstokkodu = "Eþittir"
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_karlilik_tumu(ByVal stoklar As String)
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_karlilik
        frm.status = True
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokno = dr("STOKNO")
        frm.stoklar = stoklar
        frm.qstoklar = "Eþittir"
        'frm.stokkodu = dr("STOKKODU")
        'frm.qstokkodu = "Eþittir"
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
            Dim dr As DataRow
            Dim dr1 As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr1 = ds_satir_stok.Tables(0).Rows(0)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("STOKNO")
            frm.sKodu = dr("STOKKODU")
            frm.sModel = dr1("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr1 = Nothing
        End If
    End Sub
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
    Private Function satir_kontrol_etiket() As String
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
    Private Sub raporla_etiket1(ByVal islem As Integer)
        Dim file As String
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            fiyat1 = sorgu_sayi(dr("PESIN"), 0)
            fiyat2 = sorgu_sayi(dr("ALTIAY"), 0)
            fiyat3 = sorgu_sayi(dr("ONAY"), 0)
            miktar = sorgu_sayi(dr("MIKTAR"), 1)
            report_create_stok_etiket(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        miktar = Nothing
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
                    report_create_stok_etiket(sFile, kriter, nIslem, sorgu_sayi(dr("MIKTAR") * bMiktarli, 1), sorgu_sayi(dr("PESIN"), 0), sorgu_sayi(dr("ALTIAY"), 0), sorgu_sayi(dr("ONAY"), 0))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In ds_hareket.Tables(0).Rows
                        report_create_stok_etiket(sFile, " WHERE stok.nStokId =" & dr1("STOKNO") & "", nIslem, sorgu_sayi(dr1("MIKTAR") * bMiktarli, 1), sorgu_sayi(dr1("PESIN"), 0), sorgu_sayi(dr1("ALTIAY"), 0), sorgu_sayi(dr1("ONAY"), 0))
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
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.lAsgariMiktar, stok.sBirimCinsi1,stok.sBirimCinsi2,stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
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
        ds_etiket = Nothing
        report.Dispose()
        report = Nothing
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin Maliyet Fiyatlarýný Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_maliyet()
        End If
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        analiz_karlilik()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        If GridView1.RowCount > 0 Then
            analiz_karlilik_tumu(satir_kontrol)
        End If
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        raporla_etiket(1)
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            satir_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirEkleStok.Click
        If dr_baslik("IND") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            satir_ekle("")
            Timer1.Enabled = True
        ElseIf dr_baslik("IND") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Fiyat Deðiþim Föyü Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Stok Fiyatlarini Eski Fiyatlar ile Degistirmek Istediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_satis_eski()
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
                stok_ara()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            GridView1.FocusedColumn = colPESIN
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Fiþ Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
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
            dataload_tbstok(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Stok Bilgisi Yükleniyor... "
            Label4.Refresh()
            satir_ekle_tek(False)
        ElseIf kontrol > 1 Then
            satir_ekle(Trim(txt_ara.Text))
            Label4.Text = "Stok Satýra Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter
        kriter = "WHERE (Stok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ") or (Stok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") OR Stok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok Stok INNER JOIN  tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID and Barcode.nKisim = 0 " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_tbstok(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbStok.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS ONBESAY,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'), 0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'), 0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'), 0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'), 0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'), 0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'), 0) AS FIYAT10, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
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
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Down Then
            If GridView1.FocusedRowHandle = GridView1.RowCount - 1 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            ElseIf GridView1.RowCount = 0 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            End If
        End If
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Stok Sýnýf Kodlarýný Güncellemek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_sinif12("Ýndirimli Ürün")
        End If
    End Sub
    Private Sub guncelle_sinif12(ByVal sSinifAciklama As String)
        Dim dr As DataRow
        Dim sSinifKodu5 As String = ""
        For Each dr In ds_hareket.Tables(0).Rows
            sSinifKodu5 = sorgu_Sinif_uret("", sorgu_telefon(sSinifAciklama, ""), 5, "S")
            tbStokSinifi_kaydet_duzelt(dr("STOKKODU"), sSinifKodu5, 5)
        Next
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub tbStokSinifi_kaydet_duzelt(ByVal sModel As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSinifi SET              sSinifKodu" & sSinifNo & " = '" & sSinifKodu & "' where nStokID IN (Select nStokID from tbStok where sModel = '" & sModel & "' )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sorgu_telefon(ByVal deger As Object, ByVal sonuc As String) As String
        If deger.ToString = "" Then
            deger = sonuc
        End If
        deger = deger.Replace("(", "")
        deger = deger.Replace(")", "")
        deger = deger.Replace("_", "")
        deger = deger.Replace(";", "")
        deger = deger.Replace("'", "")
        deger = deger.Replace(",", "")
        'deger = deger.Replace(".", "")
        Return deger
    End Function
    Private Sub tbStokSinifi_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nStokID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_Sinif_uret(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer, ByVal t As String) As String
        If Trim(sAciklama) <> "" Then
            sSinifKodu = sorgu_Sinif_kontrol(sAciklama, sinifno, t)
            If Trim(sSinifKodu) = "" Then
                sSinifKodu = columnuzunlukinteger_sifir(sorgu_Sinif_kontrol_sayi(sAciklama, sinifno, t), 5)
                stok_sinif_kaydet_yeni(sSinifKodu, sAciklama, sinifno, t)
            End If
        Else
            sSinifKodu = ""
        End If
        Return sSinifKodu
    End Function
    Public Function sorgu_Sinif_kontrol(ByVal sSinifKodu As String, ByVal sinifno As Integer, ByVal t As String) As String
        Dim kriter
        kriter = "WHERE (sAciklama = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu FROM          tb" & t & "Sinif" & sinifno & " " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_Sinif_kontrol_sayi(ByVal sSinifKodu As String, ByVal sinifno As Integer, ByVal t As String) As Int64
        Dim kriter
        kriter = "WHERE (sAciklama = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(COUNT(sSinifKodu), 0) + 1 AS nKayit FROM          tb" & t & "Sinif" & sinifno & "  Where sSinifKodu <>''")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Sub stok_sinif_kaydet_yeni(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer, ByVal t As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If t = "M" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tb" & t & "Sinif" & sinifno & "                       (sSinifKodu, sAciklama,bSatisYapilamaz) VALUES     ('" & sSinifKodu & "', N'" & sAciklama & "',0)")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tb" & t & "Sinif" & sinifno & "                       (sSinifKodu, sAciklama) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "')")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
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
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Stok Sýnýf Kodlarýný Boþ olarak Güncellemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_sinif12("")
        End If
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        If GridView1.OptionsView.ShowAutoFilterRow = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
        ElseIf GridView1.OptionsView.ShowAutoFilterRow = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
        End If
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        raporla_etiket(0)
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        Dim deger = ""
        deger = InputBox("Yazdýrma Çarpaný", "Yazdýrma Çarpaný", 1).ToString
        If deger.ToString <> "" Then
            raporla_etiket(3, deger)
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        OpenFileDialog1.Filter = "StokDosyalari(*.xls) |*.xls"
        OpenFileDialog1.InitialDirectory = "c:\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(OpenFileDialog1.FileName.ToString & " Ýsimli Dosyayi Okumak Istediginize Eminmisiniz...?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                oku_xlsSTOKLAR(OpenFileDialog1.FileName.ToString, 1)
            End If
        End If
    End Sub
    Private Sub oku_xlsSTOKLAR(ByVal dosya As String, Optional ByVal nIslem As Integer = 0)
        Dim connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
   "Data Source=" & dosya & " ;Extended Properties=""Excel 8.0;HDR=YES;"""
        Dim pram As OleDb.OleDbParameter
        Dim dr As DataRow
        Dim olecon As OleDb.OleDbConnection
        Dim olecomm As OleDb.OleDbCommand
        'Dim olecomm1 As OleDb.OleDbCommand
        Dim oleadpt As OleDb.OleDbDataAdapter
        olecon = New OleDb.OleDbConnection
        Try
            olecon.ConnectionString = connstring
            olecomm = New OleDb.OleDbCommand
            olecomm.CommandText = "SELECT sKodu,sKisaAdi,sAciklama,lFiyat1,lFiyat2,lFiyat3,lFiyat4 from [tbStok$]"
            olecomm.Connection = olecon
            oleadpt = New OleDb.OleDbDataAdapter(olecomm)
            Dim ds As New DataSet
            olecon.Open()
            oleadpt.Fill(ds, "tbStok")
            Dim sKodu As String = ""
            For Each dr In ds.Tables(0).Rows
                If nIslem = 0 Then
                    If dr("sKodu") <> "" Then
                        sKodu = dr("sKodu")
                        If sKodu = "" Then
                        Else
                            dataload_stok(sKodu)
                            satir_ekle_tek("", sorgu_sayi(dr("lFiyat1"), 0), sorgu_sayi(dr("lFiyat2"), 0), sorgu_sayi(dr("lFiyat3"), 0), sorgu_sayi(dr("lFiyat4"), 0))
                        End If
                    End If
                ElseIf nIslem = 1 Then
                    If dr("sKisaAdi") <> "" Then
                        sKodu = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sKodu,'') from tbStok where sKisaAdi = '" & Trim(dr("sKisaAdi")) & "'")
                        If sKodu = "" Then
                        Else
                            dataload_stok(sKodu)
                            satir_ekle_tek("", sorgu_sayi(dr("lFiyat1"), 0), sorgu_sayi(dr("lFiyat2"), 0), sorgu_sayi(dr("lFiyat3"), 0), sorgu_sayi(dr("lFiyat4"), 0))
                        End If
                    End If
                End If
            Next
            'If IsNothing(ds) = False Then
            '    dr = ds.Tables(0).NewRow
            '    dr("FirstName") = "Raman"
            '    dr("LastName") = "Tayal"
            '    dr("Age") = 24
            '    dr("Phone") = 98989898
            '    ds.Tables(0).Rows.Add(dr)
            '    oleadpt = New OleDbDataAdapter
            '    oleadpt.InsertCommand = olecomm1
            '    Dim i As Integer = oleadpt.Update(ds, "Sheet1")
            '    MessageBox.Show(i & " row affected")
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            olecon.Close()
            olecon = Nothing
            olecomm = Nothing
            oleadpt = Nothing
            'ds = Nothing
            dr = Nothing
            pram = Nothing
        End Try
    End Sub
    Private Sub Menu_SatirSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirSil.Click
        satir_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        OpenFileDialog1.Filter = "StokDosyalari(*.xls) |*.xls"
        OpenFileDialog1.InitialDirectory = "c:\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(OpenFileDialog1.FileName.ToString & " Ýsimli Dosyayi Okumak Istediginize Eminmisiniz...?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                oku_xlsSTOKLAR(OpenFileDialog1.FileName.ToString, 0)
            End If
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        raporla_excel_csv()
    End Sub
End Class
