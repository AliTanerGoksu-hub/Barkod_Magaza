Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_servis
    Inherits DevExpress.XtraEditors.XtraForm
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents colISK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISKONTOTUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents colISKONTOSUZTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem

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
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ds_baslik As System.Data.DataSet
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
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBELGENO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIRMANO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIRMAKODU As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIRMAADI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBELGETIPI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowACIKLAMA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowGIRIS As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIADE As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIPTAL As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKAYITTARIHI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSONUC As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryHesap_Bilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryEk_Bilgiler As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents rowADRES As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTELEFON As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYETKILI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAKSESUAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colARIZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMARKA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISBELGETIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERVIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_fiyat As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents sec_satici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ds_belgetipi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents VGrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents sec_izahat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_firma As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents sec_baslik_sonuc As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents colGARANTILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_birimler As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents colSERVISTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowFIRMATIPI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents colUCRET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_arizatipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_servis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_yetkilisatici As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colYETKILISATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents rowILETISIM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_baslik_iletisim As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_depo_hareket As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_servis))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.VGrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl()
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
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.sec_aciklama = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.sec_firma = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.sec_izahat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.sec_baslik_sonuc = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.sec_baslik_iletisim = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBELGENO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBELGETIPI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIRMATIPI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIRMAKODU = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIRMAADI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowADRES = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTELEFON = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYETKILI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIRMANO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowGIRIS = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIADE = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIPTAL = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKAYITTARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryHesap_Bilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.categoryEk_Bilgiler = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSONUC = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowILETISIM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.ds_hareket = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_birimler = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyat = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAKSESUAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colARIZA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_arizatipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMARKA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_satici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSATISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISBELGETIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERVIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_servis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colGARANTILI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERVISTIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUCRET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILISATICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_yetkilisatici = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_depo_hareket = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colISK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTOTUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTOSUZTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.ds_belgetipi = New System.Data.DataSet()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_firma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_izahat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_sonuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_iletisim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_birimler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_arizatipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_servis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_yetkilisatici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.VGrid_baslik)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 22)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 184)
        Me.PanelControl1.TabIndex = 4
        '
        'VGrid_baslik
        '
        Me.VGrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(557, 257, 208, 252)
        Me.VGrid_baslik.DataMember = Nothing
        Me.VGrid_baslik.DataSource = Me.ds_baslik
        Me.VGrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_baslik.Name = "VGrid_baslik"
        Me.VGrid_baslik.RecordWidth = 118
        Me.VGrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_aciklama, Me.sec_firma, Me.sec_izahat, Me.sec_baslik_sonuc, Me.sec_baslik_iletisim})
        Me.VGrid_baslik.RowHeaderWidth = 91
        Me.VGrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTanýmlar, Me.rowFIRMANO, Me.rowGIRIS, Me.rowIADE, Me.rowIPTAL, Me.rowKAYITTARIHI, Me.categoryHesap_Bilgileri, Me.categoryEk_Bilgiler, Me.rowSONUC, Me.rowILETISIM})
        Me.VGrid_baslik.Size = New System.Drawing.Size(820, 180)
        Me.VGrid_baslik.TabIndex = 0
        Me.VGrid_baslik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn49, Me.DataColumn51})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TARIH"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "BELGENO"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FIRMANO"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "FIRMAKODU"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "FIRMAADI"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "BELGETIPI"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ACIKLAMA"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "KOD1"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KOD2"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KOD3"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "KOD4"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KOD5"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "GIRIS"
        Me.DataColumn14.DataType = GetType(Boolean)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "IADE"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "IPTAL"
        Me.DataColumn16.DataType = GetType(Boolean)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KAYITTARIHI"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "SONUC"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "ADRES"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "TELEFON"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "YETKILI"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "FIRMATIPI"
        Me.DataColumn49.DataType = GetType(Boolean)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "ILETISIM"
        '
        'sec_aciklama
        '
        Me.sec_aciklama.Name = "sec_aciklama"
        '
        'sec_firma
        '
        Me.sec_firma.AutoHeight = False
        Me.sec_firma.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_firma.Name = "sec_firma"
        '
        'sec_izahat
        '
        Me.sec_izahat.AutoHeight = False
        Me.sec_izahat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_izahat.DataSource = Me.DataTable5
        Me.sec_izahat.DisplayMember = "ACIKLAMA"
        Me.sec_izahat.Name = "sec_izahat"
        Me.sec_izahat.ValueMember = "IND"
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
        Me.sec_baslik_sonuc.Items.AddRange(New Object() {"ServisKabul", "ServisTeslim", "ServiseÇýkýþ", "ServistenGiriþ", "ArýzaKabul", "Ýade", "Ýptal", "Tamamlandý"})
        Me.sec_baslik_sonuc.Name = "sec_baslik_sonuc"
        Me.sec_baslik_sonuc.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_baslik_sonuc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'sec_baslik_iletisim
        '
        Me.sec_baslik_iletisim.AutoHeight = False
        Me.sec_baslik_iletisim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_baslik_iletisim.Items.AddRange(New Object() {"YüzYüze", "Maðaza", "Servis", "Kargo", "Paket", "Adres", "Telefon", "Fax", "E-Mail", "Posta"})
        Me.sec_baslik_iletisim.Name = "sec_baslik_iletisim"
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIND, Me.rowTARIH, Me.rowBELGENO, Me.rowBELGETIPI, Me.rowFIRMATIPI, Me.rowFIRMAKODU, Me.rowFIRMAADI, Me.rowADRES, Me.rowTELEFON, Me.rowYETKILI})
        Me.categoryTanýmlar.Name = "categoryTanýmlar"
        Me.categoryTanýmlar.Properties.Caption = "Tanýmlar"
        '
        'rowIND
        '
        Me.rowIND.Height = 15
        Me.rowIND.Name = "rowIND"
        Me.rowIND.Properties.Caption = "Kayýt No"
        Me.rowIND.Properties.FieldName = "IND"
        Me.rowIND.Visible = False
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.Properties.Caption = "Tarih"
        Me.rowTARIH.Properties.FieldName = "TARIH"
        '
        'rowBELGENO
        '
        Me.rowBELGENO.Name = "rowBELGENO"
        Me.rowBELGENO.Properties.Caption = "Belge No"
        Me.rowBELGENO.Properties.FieldName = "BELGENO"
        '
        'rowBELGETIPI
        '
        Me.rowBELGETIPI.Name = "rowBELGETIPI"
        Me.rowBELGETIPI.Properties.Caption = "Belge Tipi"
        Me.rowBELGETIPI.Properties.FieldName = "BELGETIPI"
        '
        'rowFIRMATIPI
        '
        Me.rowFIRMATIPI.Name = "rowFIRMATIPI"
        Me.rowFIRMATIPI.Properties.Caption = "Firma?"
        Me.rowFIRMATIPI.Properties.FieldName = "FIRMATIPI"
        Me.rowFIRMATIPI.Properties.ReadOnly = True
        '
        'rowFIRMAKODU
        '
        Me.rowFIRMAKODU.Name = "rowFIRMAKODU"
        Me.rowFIRMAKODU.Properties.Caption = "Hesap Kodu"
        Me.rowFIRMAKODU.Properties.FieldName = "FIRMAKODU"
        Me.rowFIRMAKODU.Properties.RowEdit = Me.sec_firma
        '
        'rowFIRMAADI
        '
        Me.rowFIRMAADI.Name = "rowFIRMAADI"
        Me.rowFIRMAADI.Properties.Caption = "HesapAdý"
        Me.rowFIRMAADI.Properties.FieldName = "FIRMAADI"
        '
        'rowADRES
        '
        Me.rowADRES.Name = "rowADRES"
        Me.rowADRES.Properties.Caption = "Adres"
        Me.rowADRES.Properties.FieldName = "ADRES"
        '
        'rowTELEFON
        '
        Me.rowTELEFON.Name = "rowTELEFON"
        Me.rowTELEFON.Properties.Caption = "Telefon"
        Me.rowTELEFON.Properties.FieldName = "TELEFON"
        '
        'rowYETKILI
        '
        Me.rowYETKILI.Name = "rowYETKILI"
        Me.rowYETKILI.Properties.Caption = "Yetkili"
        Me.rowYETKILI.Properties.FieldName = "YETKILI"
        '
        'rowFIRMANO
        '
        Me.rowFIRMANO.Name = "rowFIRMANO"
        Me.rowFIRMANO.Properties.Caption = "Hesap No"
        Me.rowFIRMANO.Properties.FieldName = "FIRMANO"
        Me.rowFIRMANO.Visible = False
        '
        'rowGIRIS
        '
        Me.rowGIRIS.Name = "rowGIRIS"
        Me.rowGIRIS.Properties.Caption = "Giriþ"
        Me.rowGIRIS.Properties.FieldName = "GIRIS"
        Me.rowGIRIS.Visible = False
        '
        'rowIADE
        '
        Me.rowIADE.Name = "rowIADE"
        Me.rowIADE.Properties.Caption = "Ýade"
        Me.rowIADE.Properties.FieldName = "IADE"
        Me.rowIADE.Visible = False
        '
        'rowIPTAL
        '
        Me.rowIPTAL.Name = "rowIPTAL"
        Me.rowIPTAL.Properties.Caption = "iptal"
        Me.rowIPTAL.Properties.FieldName = "IPTAL"
        Me.rowIPTAL.Visible = False
        '
        'rowKAYITTARIHI
        '
        Me.rowKAYITTARIHI.Name = "rowKAYITTARIHI"
        Me.rowKAYITTARIHI.Properties.Caption = "Kayýt Tarihi"
        Me.rowKAYITTARIHI.Properties.FieldName = "KAYITTARIHI"
        Me.rowKAYITTARIHI.Visible = False
        '
        'categoryHesap_Bilgileri
        '
        Me.categoryHesap_Bilgileri.Name = "categoryHesap_Bilgileri"
        Me.categoryHesap_Bilgileri.Properties.Caption = "Hesap Bilgileri"
        Me.categoryHesap_Bilgileri.Visible = False
        '
        'categoryEk_Bilgiler
        '
        Me.categoryEk_Bilgiler.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowKOD1, Me.rowKOD2, Me.rowKOD3, Me.rowKOD4, Me.rowKOD5, Me.rowACIKLAMA})
        Me.categoryEk_Bilgiler.Name = "categoryEk_Bilgiler"
        Me.categoryEk_Bilgiler.Properties.Caption = "Ek Bilgiler"
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
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Height = 82
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.Properties.Caption = "Açýklama"
        Me.rowACIKLAMA.Properties.FieldName = "ACIKLAMA"
        Me.rowACIKLAMA.Properties.RowEdit = Me.sec_aciklama
        '
        'rowSONUC
        '
        Me.rowSONUC.Name = "rowSONUC"
        Me.rowSONUC.Properties.Caption = "Sonuç"
        Me.rowSONUC.Properties.FieldName = "SONUC"
        Me.rowSONUC.Properties.RowEdit = Me.sec_baslik_sonuc
        '
        'rowILETISIM
        '
        Me.rowILETISIM.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowILETISIM.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowILETISIM.Appearance.Options.UseFont = True
        Me.rowILETISIM.Appearance.Options.UseForeColor = True
        Me.rowILETISIM.Name = "rowILETISIM"
        Me.rowILETISIM.Properties.Caption = "Ýletiþim"
        Me.rowILETISIM.Properties.FieldName = "ILETISIM"
        Me.rowILETISIM.Properties.RowEdit = Me.sec_baslik_iletisim
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.GroupControl3)
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 496)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 88)
        Me.PanelControl2.TabIndex = 1
        '
        'GroupControl3
        '
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(176, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(494, 84)
        Me.GroupControl3.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(174, 84)
        Me.GroupControl2.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(670, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(152, 84)
        Me.GroupControl1.TabIndex = 0
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 206)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 6)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterControl2.Location = New System.Drawing.Point(0, 490)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(824, 6)
        Me.SplitterControl2.TabIndex = 3
        Me.SplitterControl2.TabStop = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 212)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 278)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_fiyat, Me.sec_satici, Me.sec_birimler, Me.sec_arizatipi, Me.sec_servis, Me.sec_yetkilisatici, Me.sec_depo_hareket})
        Me.GridControl1.Size = New System.Drawing.Size(820, 274)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem6, Me.MenuItem2, Me.MenuItem3, Me.MenuItem5, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Satýr Ekle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Stoklardan Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "Satýr Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Satýr Sil"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 5
        Me.MenuItem4.Text = "Deðer Yay"
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn50, Me.DataColumn52, Me.DataColumn53})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "IND"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "STOKNO"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "STOKKODU"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "MALINCINSI"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "GIREN"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "BIRIM"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "BARCODE"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "FIYAT"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "TUTAR"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "ACIKLAMA"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "AKSESUAR"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "SERINO"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ARIZA"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "MARKA"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "MODEL"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "SATICI"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "SATISTARIHI"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "SATISBELGENO"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "SATISBELGETIPI"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "SATISDEPO"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "SERVIS"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "CIKAN"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "sDepo"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "REFNO"
        Me.DataColumn45.DataType = GetType(Long)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "REFHAREKET"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "GARANTILI"
        Me.DataColumn47.DataType = GetType(Boolean)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "SERVISTIPI"
        Me.DataColumn48.DataType = GetType(Boolean)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "UCRET"
        Me.DataColumn50.DataType = GetType(Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "ISK"
        Me.DataColumn52.DataType = GetType(Decimal)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "ISKONTOTUTARI"
        Me.DataColumn53.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colMIKTAR, Me.colBIRIM, Me.colBARCODE, Me.colFIYAT, Me.colTUTAR, Me.colACIKLAMA, Me.colAKSESUAR, Me.colSERINO, Me.colARIZA, Me.colMARKA, Me.colMODEL, Me.colSATICI, Me.colSATISTARIHI, Me.colSATISBELGENO, Me.colSATISBELGETIPI, Me.colSATISDEPO, Me.colSERVIS, Me.colGARANTILI, Me.colSERVISTIPI, Me.colUCRET, Me.colYETKILISATICI, Me.colsDepo, Me.colISK, Me.colISKONTOTUTARI, Me.colISKONTOSUZTUTAR})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(500, 217, 208, 170)
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
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.OptionsColumn.AllowEdit = False
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        Me.colSTOKNO.OptionsColumn.AllowEdit = False
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.OptionsColumn.AllowEdit = False
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 0
        Me.colSTOKKODU.Width = 105
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.OptionsColumn.AllowEdit = False
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 1
        Me.colMALINCINSI.Width = 209
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "GIREN"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.##}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 2
        Me.colMIKTAR.Width = 54
        '
        'colBIRIM
        '
        Me.colBIRIM.Caption = "Birim"
        Me.colBIRIM.ColumnEdit = Me.sec_birimler
        Me.colBIRIM.FieldName = "BIRIM"
        Me.colBIRIM.Name = "colBIRIM"
        Me.colBIRIM.Visible = True
        Me.colBIRIM.VisibleIndex = 3
        Me.colBIRIM.Width = 60
        '
        'sec_birimler
        '
        Me.sec_birimler.AutoHeight = False
        Me.sec_birimler.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_birimler.Items.AddRange(New Object() {"Adet", "Paket", "Koli", "Çuval", "Þilink", "Prç", "Kasa", "Set", "Sandýk"})
        Me.sec_birimler.Name = "sec_birimler"
        Me.sec_birimler.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barcode"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        Me.colBARCODE.OptionsColumn.AllowEdit = False
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.ColumnEdit = Me.sec_fiyat
        Me.colFIYAT.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT.FieldName = "FIYAT"
        Me.colFIYAT.Name = "colFIYAT"
        Me.colFIYAT.Visible = True
        Me.colFIYAT.VisibleIndex = 4
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
        Me.sec_fiyat.NullText = "0.00"
        Me.sec_fiyat.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Net"
        Me.colTUTAR.ColumnEdit = Me.sec_fiyat
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.##}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 8
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colACIKLAMA.AppearanceHeader.Options.UseForeColor = True
        Me.colACIKLAMA.Caption = "Þikayet..."
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 12
        Me.colACIKLAMA.Width = 141
        '
        'colAKSESUAR
        '
        Me.colAKSESUAR.Caption = "Aksesuar"
        Me.colAKSESUAR.FieldName = "AKSESUAR"
        Me.colAKSESUAR.Name = "colAKSESUAR"
        Me.colAKSESUAR.Visible = True
        Me.colAKSESUAR.VisibleIndex = 13
        '
        'colSERINO
        '
        Me.colSERINO.Caption = "SeriNo"
        Me.colSERINO.FieldName = "SERINO"
        Me.colSERINO.Name = "colSERINO"
        Me.colSERINO.Visible = True
        Me.colSERINO.VisibleIndex = 14
        '
        'colARIZA
        '
        Me.colARIZA.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colARIZA.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colARIZA.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colARIZA.AppearanceCell.Options.UseBackColor = True
        Me.colARIZA.AppearanceCell.Options.UseForeColor = True
        Me.colARIZA.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colARIZA.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.colARIZA.AppearanceHeader.Options.UseFont = True
        Me.colARIZA.AppearanceHeader.Options.UseForeColor = True
        Me.colARIZA.Caption = "Arýza"
        Me.colARIZA.ColumnEdit = Me.sec_arizatipi
        Me.colARIZA.FieldName = "ARIZA"
        Me.colARIZA.Name = "colARIZA"
        Me.colARIZA.Visible = True
        Me.colARIZA.VisibleIndex = 15
        '
        'sec_arizatipi
        '
        Me.sec_arizatipi.AutoHeight = False
        Me.sec_arizatipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_arizatipi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KOD", "KOD"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "ACIKLAMA")})
        Me.sec_arizatipi.DisplayMember = "ACIKLAMA"
        Me.sec_arizatipi.Name = "sec_arizatipi"
        Me.sec_arizatipi.NullText = ""
        Me.sec_arizatipi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_arizatipi.ShowFooter = False
        Me.sec_arizatipi.ShowHeader = False
        Me.sec_arizatipi.ValueMember = "IND"
        '
        'colMARKA
        '
        Me.colMARKA.Caption = "Marka"
        Me.colMARKA.FieldName = "MARKA"
        Me.colMARKA.Name = "colMARKA"
        Me.colMARKA.Visible = True
        Me.colMARKA.VisibleIndex = 16
        '
        'colMODEL
        '
        Me.colMODEL.Caption = "Model"
        Me.colMODEL.FieldName = "MODEL"
        Me.colMODEL.Name = "colMODEL"
        Me.colMODEL.Visible = True
        Me.colMODEL.VisibleIndex = 17
        '
        'colSATICI
        '
        Me.colSATICI.Caption = "Satýcý"
        Me.colSATICI.ColumnEdit = Me.sec_satici
        Me.colSATICI.FieldName = "SATICI"
        Me.colSATICI.Name = "colSATICI"
        Me.colSATICI.Visible = True
        Me.colSATICI.VisibleIndex = 19
        '
        'sec_satici
        '
        Me.sec_satici.AutoHeight = False
        Me.sec_satici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satici.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "KayýtNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SATICI", "Satýcý")})
        Me.sec_satici.DisplayMember = "SATICI"
        Me.sec_satici.Name = "sec_satici"
        Me.sec_satici.NullText = ""
        Me.sec_satici.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_satici.ShowFooter = False
        Me.sec_satici.ShowHeader = False
        Me.sec_satici.ValueMember = "IND"
        '
        'colSATISTARIHI
        '
        Me.colSATISTARIHI.Caption = "FaturaTarihi"
        Me.colSATISTARIHI.FieldName = "SATISTARIHI"
        Me.colSATISTARIHI.Name = "colSATISTARIHI"
        Me.colSATISTARIHI.Visible = True
        Me.colSATISTARIHI.VisibleIndex = 21
        '
        'colSATISBELGENO
        '
        Me.colSATISBELGENO.Caption = "FaturaBelgeNo"
        Me.colSATISBELGENO.FieldName = "SATISBELGENO"
        Me.colSATISBELGENO.Name = "colSATISBELGENO"
        Me.colSATISBELGENO.OptionsColumn.AllowEdit = False
        Me.colSATISBELGENO.Visible = True
        Me.colSATISBELGENO.VisibleIndex = 22
        '
        'colSATISBELGETIPI
        '
        Me.colSATISBELGETIPI.Caption = "FaturaBelgeTipi"
        Me.colSATISBELGETIPI.FieldName = "SATISBELGETIPI"
        Me.colSATISBELGETIPI.Name = "colSATISBELGETIPI"
        Me.colSATISBELGETIPI.OptionsColumn.AllowEdit = False
        Me.colSATISBELGETIPI.Visible = True
        Me.colSATISBELGETIPI.VisibleIndex = 23
        '
        'colSATISDEPO
        '
        Me.colSATISDEPO.Caption = "FaturaDeposu"
        Me.colSATISDEPO.FieldName = "SATISDEPO"
        Me.colSATISDEPO.Name = "colSATISDEPO"
        Me.colSATISDEPO.OptionsColumn.AllowEdit = False
        Me.colSATISDEPO.Visible = True
        Me.colSATISDEPO.VisibleIndex = 24
        '
        'colSERVIS
        '
        Me.colSERVIS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSERVIS.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSERVIS.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSERVIS.AppearanceCell.Options.UseBackColor = True
        Me.colSERVIS.AppearanceCell.Options.UseForeColor = True
        Me.colSERVIS.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSERVIS.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.colSERVIS.AppearanceHeader.Options.UseFont = True
        Me.colSERVIS.AppearanceHeader.Options.UseForeColor = True
        Me.colSERVIS.Caption = "Servis"
        Me.colSERVIS.ColumnEdit = Me.sec_servis
        Me.colSERVIS.FieldName = "SERVIS"
        Me.colSERVIS.Name = "colSERVIS"
        Me.colSERVIS.Visible = True
        Me.colSERVIS.VisibleIndex = 18
        '
        'sec_servis
        '
        Me.sec_servis.AutoHeight = False
        Me.sec_servis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_servis.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KODU", "KODU"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADI", "ADI")})
        Me.sec_servis.DisplayMember = "KODU"
        Me.sec_servis.Name = "sec_servis"
        Me.sec_servis.NullText = ""
        Me.sec_servis.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_servis.ShowFooter = False
        Me.sec_servis.ShowHeader = False
        Me.sec_servis.ValueMember = "KODU"
        '
        'colGARANTILI
        '
        Me.colGARANTILI.Caption = "Garantili?"
        Me.colGARANTILI.FieldName = "GARANTILI"
        Me.colGARANTILI.Name = "colGARANTILI"
        Me.colGARANTILI.Visible = True
        Me.colGARANTILI.VisibleIndex = 9
        '
        'colSERVISTIPI
        '
        Me.colSERVISTIPI.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colSERVISTIPI.AppearanceCell.Options.UseForeColor = True
        Me.colSERVISTIPI.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSERVISTIPI.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.colSERVISTIPI.AppearanceHeader.Options.UseFont = True
        Me.colSERVISTIPI.AppearanceHeader.Options.UseForeColor = True
        Me.colSERVISTIPI.Caption = "Kýrýk?"
        Me.colSERVISTIPI.FieldName = "SERVISTIPI"
        Me.colSERVISTIPI.Name = "colSERVISTIPI"
        Me.colSERVISTIPI.Visible = True
        Me.colSERVISTIPI.VisibleIndex = 11
        '
        'colUCRET
        '
        Me.colUCRET.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUCRET.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUCRET.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colUCRET.AppearanceCell.Options.UseBackColor = True
        Me.colUCRET.AppearanceCell.Options.UseForeColor = True
        Me.colUCRET.Caption = "Servis Ücreti"
        Me.colUCRET.ColumnEdit = Me.sec_fiyat
        Me.colUCRET.FieldName = "UCRET"
        Me.colUCRET.Name = "colUCRET"
        Me.colUCRET.Visible = True
        Me.colUCRET.VisibleIndex = 10
        '
        'colYETKILISATICI
        '
        Me.colYETKILISATICI.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colYETKILISATICI.AppearanceCell.Options.UseForeColor = True
        Me.colYETKILISATICI.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.colYETKILISATICI.AppearanceHeader.Options.UseForeColor = True
        Me.colYETKILISATICI.Caption = "YetkiliSatýcý"
        Me.colYETKILISATICI.ColumnEdit = Me.sec_yetkilisatici
        Me.colYETKILISATICI.FieldName = "YETKILISATICI"
        Me.colYETKILISATICI.Name = "colYETKILISATICI"
        Me.colYETKILISATICI.Visible = True
        Me.colYETKILISATICI.VisibleIndex = 25
        '
        'sec_yetkilisatici
        '
        Me.sec_yetkilisatici.AutoHeight = False
        Me.sec_yetkilisatici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_yetkilisatici.Name = "sec_yetkilisatici"
        Me.sec_yetkilisatici.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.ColumnEdit = Me.sec_depo_hareket
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.Visible = True
        Me.colsDepo.VisibleIndex = 20
        '
        'sec_depo_hareket
        '
        Me.sec_depo_hareket.AutoHeight = False
        Me.sec_depo_hareket.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo_hareket.DisplayMember = "DEPOADI"
        Me.sec_depo_hareket.Name = "sec_depo_hareket"
        Me.sec_depo_hareket.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_depo_hareket.ShowFooter = False
        Me.sec_depo_hareket.ShowHeader = False
        Me.sec_depo_hareket.ShowLines = False
        Me.sec_depo_hareket.ValueMember = "DEPOKODU"
        '
        'colISK
        '
        Me.colISK.Caption = "Isk"
        Me.colISK.DisplayFormat.FormatString = "#,0.00"
        Me.colISK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK.FieldName = "ISK"
        Me.colISK.Name = "colISK"
        Me.colISK.Visible = True
        Me.colISK.VisibleIndex = 6
        '
        'colISKONTOTUTARI
        '
        Me.colISKONTOTUTARI.Caption = "Iskonto"
        Me.colISKONTOTUTARI.DisplayFormat.FormatString = "#,0.00"
        Me.colISKONTOTUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISKONTOTUTARI.FieldName = "ISKONTOTUTARI"
        Me.colISKONTOTUTARI.Name = "colISKONTOTUTARI"
        Me.colISKONTOTUTARI.Visible = True
        Me.colISKONTOTUTARI.VisibleIndex = 7
        '
        'colISKONTOSUZTUTAR
        '
        Me.colISKONTOSUZTUTAR.Caption = "Tutar"
        Me.colISKONTOSUZTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colISKONTOSUZTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISKONTOSUZTUTAR.FieldName = "ISKONTOSUZTUTAR"
        Me.colISKONTOSUZTUTAR.Name = "colISKONTOSUZTUTAR"
        Me.colISKONTOSUZTUTAR.Visible = True
        Me.colISKONTOSUZTUTAR.VisibleIndex = 5
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.AutoSaveInRegistry = True
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.CloseButtonAffectAllTabs = False
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarSubItem6, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarSubItem7, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 25
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Belge Dizayn"
        Me.BarButtonItem9.Id = 16
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Belge Önizle"
        Me.BarButtonItem10.Id = 17
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Belge Yazdýr"
        Me.BarButtonItem11.Id = 18
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Belgeyi Ýptal Et"
        Me.BarButtonItem12.Id = 19
        Me.BarButtonItem12.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Satýr"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15, True)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Satýr Ekle"
        Me.BarButtonItem13.Id = 20
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Satýr Sil"
        Me.BarButtonItem14.Id = 21
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Satýþ Belgesi Seç"
        Me.BarButtonItem15.Id = 22
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Araçlar"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Hesap Makinasý"
        Me.BarButtonItem8.Id = 15
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Görünüm"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17, True)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Baþlýk"
        Me.BarButtonItem1.Id = 6
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Hareketler"
        Me.BarButtonItem2.Id = 7
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Analizler"
        Me.BarSubItem6.Id = 9
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Müþteri Analizi"
        Me.BarButtonItem4.Id = 10
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Stok/Servis Analizi"
        Me.BarButtonItem5.Id = 11
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Belge Analizi"
        Me.BarButtonItem6.Id = 12
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Görünüm Kaydet"
        Me.BarButtonItem17.Id = 24
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Analiz"
        Me.BarSubItem5.Id = 4
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Hareket Analiz"
        Me.BarButtonItem16.Id = 23
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "Ekran"
        Me.BarSubItem7.Id = 13
        Me.BarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7)})
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Tam Ekran"
        Me.BarButtonItem7.Id = 14
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem7.Name = "BarButtonItem7"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 584)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 562)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 562)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Analizler"
        Me.BarButtonItem3.Id = 8
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'ds_belgetipi
        '
        Me.ds_belgetipi.DataSetName = "NewDataSet"
        Me.ds_belgetipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_belgetipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar5})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22})
        Me.BarManager2.MaxItemId = 5
        Me.BarManager2.StatusBar = Me.Bar5
        '
        'Bar5
        '
        Me.Bar5.BarName = "Status bar"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22, True)})
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Status bar"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Fislerden Ekle,Ins"
        Me.BarButtonItem18.Id = 0
        Me.BarButtonItem18.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem18.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Stoklardan Ekle"
        Me.BarButtonItem19.Id = 1
        Me.BarButtonItem19.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem19.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Satýr Sil,Ctrl+Del"
        Me.BarButtonItem20.Id = 2
        Me.BarButtonItem20.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem20.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Fis Sil,Ctrl+Y"
        Me.BarButtonItem21.Id = 3
        Me.BarButtonItem21.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem21.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Yazdýr,F2"
        Me.BarButtonItem22.Id = 4
        Me.BarButtonItem22.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem22.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(824, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 584)
        Me.BarDockControl2.Size = New System.Drawing.Size(824, 22)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 584)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(824, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 584)
        '
        'frm_stok_servis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 606)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.SplitterControl2)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_servis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servis Kabul Ýþlemleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_firma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_izahat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_sonuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_iletisim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_birimler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_arizatipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_servis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_yetkilisatici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
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

    Dim ds_satici As DataSet
    Public firmatipi As Boolean = False
    Public yeni As Boolean = False
    Private Sub frm_stok_servis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        baslik()
        belgetipleri()
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        Try
            'gorunum_yukle()
        Catch ex As Exception
        End Try
        'Try
        '    dataload_hareket()
        'Catch ex As Exception
        'End Try
        If yeni = True Then
            If firmatipi = False Then
                musteri()
            ElseIf firmatipi = True Then
                firma()
            End If
        End If
    End Sub
    Private Sub loaded()
        dataload_baslik()
        dataload_harekets()
        GridControl1.Focus()
        GridControl1.Select()
        'sec_depo_baslik.DataSource = sorgu_s(sorgu_query("SELECT     sDepo AS DEPOKODU, sAciklama AS DEPOADI  FROM         tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        'sec_depo_hareket.DataSource = sorgu_s(sorgu_query("SELECT     sDepo AS DEPOKODU, sAciklama AS DEPOADI  FROM         tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        dataload_satici()
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        firmatipi = dr_baslik("FIRMATIPI")
    End Sub
    Private Sub dataload_baslik()
        ds_baslik.Tables(0).Clear()
        ds_baslik = sorgu_baslik("")
        VGrid_baslik.DataSource = ds_baslik
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
    End Sub
    Private Sub dataload_satici()
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu AS IND, sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici WHERE     (sSaticiRumuzu <> '') and bAktif =1"))
        sec_arizatipi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND,KOD,ACIKLAMA FROM ASTOKSERVISARIZATIPLERI")).Tables(0)
        sec_servis.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND,KODU,ADI FROM ASTOKSERVISCI")).Tables(0)
        sec_satici.DataSource = ds_satici.Tables(0)
        sec_depo_hareket.DataSource = sorgu_s(sorgu_query("SELECT     sDepo AS DEPOKODU, sAciklama AS DEPOADI  FROM         tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
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
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ASTOKSERVISBASLIK WHERE IND =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
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
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ASTOKSERVISDETAY WHERE EVRAKNO =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
    End Function
    Private Sub baslik()
        If belgeind = 0 Then
            Dim dr As DataRow = ds_baslik.Tables(0).NewRow
            dr("BELGETIPI") = "K"
            'Try
            '    depokodu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
            '    If depokodu <> "True" Then
            '        dr("DEPO") = depokodu
            '    Else
            '        dr("DEPO") = "1KAT"
            '    End If
            'Catch ex As Exception
            '    dr("DEPO") = "1KAT"
            '    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", "True")
            'End Try
            'dr("FISTARIHI") = Today
            dr("TARIH") = Today
            dr("KAYITTARIHI") = Now
            dr("FIRMANO") = 0
            dr("FIRMAKODU") = ""
            dr("FIRMAADI") = ""
            dr("YETKILI") = ""
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
            dr("GIRIS") = 1
            dr("IADE") = 0
            dr("IPTAL") = 0
            dr("SONUC") = "ServisKabul"
            dr("ADRES") = ""
            dr("TELEFON") = ""
            dr("YETKILI") = ""
            dr("ILETISIM") = "" '"YüzYüze"
            dr("FIRMATIPI") = firmatipi
            belgeind = baslik_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("FIRMATIPI"), dr("FIRMANO"), dr("FIRMAKODU"), dr("FIRMAADI"), dr("BELGETIPI"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("GIRIS"), dr("IADE"), dr("IPTAL"), dr("KAYITTARIHI"), dr("SONUC"), dr("ADRES"), dr("TELEFON"), dr("YETKILI"), dr("ILETISIM"))
            dr("IND") = belgeind
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = Nothing
        ElseIf belgeind <> 0 Then
            'rowFISTARIH.Properties.ReadOnly = True
            rowBELGETIPI.Properties.ReadOnly = True
            'rowFISNO.Properties.ReadOnly = True
            rowFIRMAKODU.Properties.ReadOnly = True
            rowFIRMAADI.Properties.ReadOnly = True
        Else
            Me.Close()
        End If
    End Sub
    Private Function baslik_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal firmatipi As Integer, ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal BELGETIPI As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal GIRIS As Integer, ByVal IADE As Integer, ByVal IPTAL As Integer, ByVal KAYITTARIHI As DateTime, ByVal SONUC As String, ByVal ADRES As String, ByVal TELEFON As String, ByVal YETKILI As String, ByVal ILETISIM As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO ASTOKSERVISBASLIK                       (TARIH, BELGENO, FIRMATIPI,FIRMANO, FIRMAKODU, FIRMAADI, BELGETIPI, ACIKLAMA, KOD1, KOD2, KOD3, KOD4, KOD5, GIRIS, IADE, IPTAL, KAYITTARIHI,SONUC, ADRES, TELEFON, YETKILI,ILETISIM) VALUES     ('" & TARIH & "', '" & BELGENO & "'," & firmatipi & ", " & FIRMANO & ", '" & FIRMAKODU & "', '" & FIRMAADI & "', '" & BELGETIPI & "' , '" & ACIKLAMA & "', '" & KOD1 & "' , '" & KOD2 & "' , '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "' , " & GIRIS & " , " & IADE & " , " & IPTAL & " , '" & KAYITTARIHI & "' ,'" & SONUC & "' , '" & ADRES & "', '" & TELEFON & "', '" & YETKILI & "' ,'" & ILETISIM & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Function hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal REFNO As Int64, ByVal REFHAREKET As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal CIKAN As Decimal, ByVal GIREN As Decimal, ByVal BIRIM As String, ByVal FIYAT As Decimal, ByVal ISK As Decimal, ByVal ISKONTOTUTARI As Decimal, ByVal ISKONTOSUZTUTAR As Decimal, ByVal TUTAR As Decimal, ByVal UCRET As Decimal, ByVal GARANTILI As Integer, ByVal ACIKLAMA As String, ByVal AKSESUAR As String, ByVal SERINO As String, ByVal ARIZA As String, ByVal MARKA As String, ByVal MODEL As String, ByVal SATICI As String, ByVal SATISTARIHI As DateTime, ByVal SATISBELGENO As String, ByVal SATISBELGETIPI As String, ByVal sDepo As String, ByVal SATISDEPO As String, ByVal SERVIS As String, ByVal STATUS As Boolean, ByVal KAYITTARIHI As DateTime, ByVal SERVISTIPI As Integer, ByVal YETKILISATICI As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKSERVISDETAY                       (EVRAKNO, REFNO, REFHAREKET, STOKNO, STOKKODU, MALINCINSI, BARCODE, CIKAN, GIREN, BIRIM, FIYAT, ISK,ISKONTOTUTARI,ISKONTOSUZTUTAR,TUTAR,UCRET, GARANTILI,ACIKLAMA, AKSESUAR, SERINO, ARIZA, MARKA, MODEL, SATICI, SATISTARIHI, SATISBELGENO, SATISBELGETIPI, sDepo, SATISDEPO, SERVIS, STATUS, KAYITTARIHI,SERVISTIPI,YETKILISATICI) VALUES     (" & EVRAKNO & " , " & REFNO & " , " & REFHAREKET & " , " & STOKNO & " , '" & STOKKODU & "' , '" & MALINCINSI & "', '" & BARCODE & "' , " & CIKAN & " , " & GIREN & " , '" & BIRIM & "' , " & FIYAT & " , " & ISK & "," & ISKONTOTUTARI & "," & ISKONTOSUZTUTAR & " ," & TUTAR & " ," & UCRET & "," & GARANTILI & ", '" & ACIKLAMA & "' , '" & AKSESUAR & "','" & SERINO & "' , '" & ARIZA & "' , '" & MARKA & "', '" & MODEL & "' , '" & SATICI & "', '" & SATISTARIHI & "', '" & SATISBELGENO & "', '" & SATISBELGETIPI & "', '" & sDepo & "' , '" & SATISDEPO & "', '" & SERVIS & "' , '" & STATUS & "' , '" & KAYITTARIHI & "'," & SERVISTIPI & ",'" & YETKILISATICI & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub hareketler_kaydet_yeni(ByVal TARIH As DateTime, ByVal ISLEMTIPI As Integer, ByVal BELGETIPI As String, ByVal BELGENO As String, ByVal EVRAKNO As Int64, ByVal ACIKLAMA As String, ByVal REFNO As Int64, ByVal REFBASLIK As Int64, ByVal KAYITTARIHI As DateTime, ByVal ucret As Decimal, ByVal FIRMANO As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKSERVISHAREKETLERI                       (TARIH, ISLEMTIPI,BELGETIPI,BELGENO, EVRAKNO, ACIKLAMA, REFNO, REFBASLIK, KAYITTARIHI,UCRET,FIRMANO) VALUES     ('" & TARIH & "'," & ISLEMTIPI & ", '" & BELGETIPI & "', '" & BELGENO & "'," & EVRAKNO & " , '" & ACIKLAMA & "', " & REFNO & " , " & REFBASLIK & " , '" & KAYITTARIHI & "'," & ucret & " ," & FIRMANO & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareketler_kaydet_degistir(ByVal ind As Int64, ByVal TARIH As DateTime, ByVal BELGETIPI As String, ByVal EVRAKNO As Int64, ByVal ACIKLAMA As String, ByVal REFNO As Int64, ByVal REFBASLIK As Int64, ByVal KAYITTARIHI As DateTime, ByVal ucret As Decimal)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKSERVISHAREKETLERI SET              TARIH = '" & TARIH & "', BELGETIPI = '" & BELGETIPI & "', EVRAKNO = " & EVRAKNO & " , ACIKLAMA = '" & ACIKLAMA & "', REFNO = " & REFNO & " , REFBASLIK = " & REFBASLIK & ",UCRET =" & ucret & "  WHERE EVRAKNO = " & EVRAKNO & " AND BELGETIPI ='" & BELGETIPI & "' AND REFNO =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareketler_kaydet_degistir_baslik(ByVal tarih As DateTime, ByVal belgeno As String, ByVal belgetipi As String, ByVal evrakno As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKSERVISHAREKETLERI SET              TARIH = '" & tarih & "', BELGENO = '" & belgeno & "' WHERE EVRAKNO = " & evrakno & " AND BELGETIPI ='" & belgetipi & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareketler_kaydet_sil(ByVal belgetipi As String, ByVal evrakno As Int64, ByVal ind As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKSERVISHAREKETLERI  WHERE EVRAKNO = " & evrakno & " AND BELGETIPI ='" & belgetipi & "' AND REFNO =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal REFNO As Int64, ByVal REFHAREKET As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal CIKAN As Decimal, ByVal GIREN As Decimal, ByVal BIRIM As String, ByVal FIYAT As Decimal, ByVal ISK As Decimal, ByVal ISKONTOTUTARI As Decimal, ByVal ISKONTOSUZTUTAR As Decimal, ByVal TUTAR As Decimal, ByVal UCRET As Decimal, ByVal GARANTILI As Integer, ByVal ACIKLAMA As String, ByVal AKSESUAR As String, ByVal SERINO As String, ByVal ARIZA As String, ByVal MARKA As String, ByVal MODEL As String, ByVal SATICI As String, ByVal SATISTARIHI As DateTime, ByVal SATISBELGENO As String, ByVal SATISBELGETIPI As String, ByVal sDepo As String, ByVal SATISDEPO As String, ByVal SERVIS As String, ByVal STATUS As Boolean, ByVal KAYITTARIHI As DateTime, ByVal SERVISTIPI As Integer, ByVal YETKILISATICI As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKSERVISDETAY SET               STOKNO = " & STOKNO & " , STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "' , BARCODE = '" & BARCODE & "', CIKAN = " & CIKAN & " , GIREN = " & GIREN & " , BIRIM = '" & BIRIM & "' , FIYAT = " & FIYAT & " ,ISK= " & ISK & ",ISKONTOTUTARI= " & ISKONTOTUTARI & ",ISKONTOSUZTUTAR =" & ISKONTOSUZTUTAR & ", TUTAR = " & TUTAR & " ,UCRET =" & UCRET & ",GARANTILI=" & GARANTILI & ", ACIKLAMA = '" & ACIKLAMA & "', AKSESUAR = '" & AKSESUAR & "', SERINO = '" & SERINO & "', ARIZA = '" & ARIZA & "' , MARKA = '" & MARKA & "' , MODEL = '" & MODEL & "', SATICI = '" & SATICI & "', SATISTARIHI = '" & SATISTARIHI & "' , SATISBELGENO = '" & SATISBELGENO & "' , SATISBELGETIPI = '" & SATISBELGETIPI & "', sDepo = '" & sDepo & "' , SATISDEPO = '" & SATISDEPO & "', SERVIS = '" & SERVIS & "',SERVISTIPI =" & SERVISTIPI & ",YETKILISATICI ='" & YETKILISATICI & "'   WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKSERVISDETAY  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub baslik_kaydet_degistir(ByVal evrakno As Int64, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal FIRMATIPI As Integer, ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal BELGETIPI As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal GIRIS As Integer, ByVal IADE As Integer, ByVal IPTAL As Integer, ByVal KAYITTARIHI As DateTime, ByVal SONUC As String, ByVal ADRES As String, ByVal TELEFON As String, ByVal YETKILI As String, ByVal ILETISIM As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE ASTOKSERVISBASLIK SET TARIH = '" & TARIH & "', BELGENO = '" & BELGENO & "', FIRMATIPI = " & FIRMATIPI & ", FIRMANO = " & FIRMANO & ", FIRMAKODU = '" & FIRMAKODU & "', FIRMAADI = '" & FIRMAADI & "', BELGETIPI = '" & BELGETIPI & "', ACIKLAMA = '" & ACIKLAMA & "', KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', KOD3 = '" & KOD3 & "', KOD4 = '" & KOD4 & "', KOD5 = '" & KOD5 & "', GIRIS = " & GIRIS & ",  SONUC = '" & SONUC & "', ADRES = '" & ADRES & "', TELEFON = '" & TELEFON & "', YETKILI = '" & YETKILI & "', ILETISIM= '" & ILETISIM & "' WHERE IND = " & evrakno & "")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
        Try
            hareketler_kaydet_degistir_baslik(TARIH, BELGENO, BELGETIPI, evrakno)
        Catch ex As Exception
        End Try
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
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(BELGENO,'A-000001') AS BELGENO FROM ASTOKSERVISBASLIK WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM ASTOKSERVISBASLIK  WHERE  BELGENO LIKE 'A%')")
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
    Private Sub belgetipleri()
        Dim dr1 As DataRow = ds_belgetipi.Tables(0).NewRow
        'dr1("IND") = "FA"
        'dr1("ACIKLAMA") = "Alýþ Faturasý"
        'ds_belgetipi.Tables(0).Rows.Add(dr1)
        'dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "K"
        dr1("ACIKLAMA") = "Servis Kabul"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "T"
        dr1("ACIKLAMA") = "Servis Teslim"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "A"
        dr1("ACIKLAMA") = "Arýza"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "Ç"
        dr1("ACIKLAMA") = "Servise Çýkýþ"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "G"
        dr1("ACIKLAMA") = "Servisten Giriþ"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Function sorgu_s(ByVal query As String) As DataSet
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
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub calculator()
        Dim frm As New frm_calc
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        calculator()
    End Sub
    Private Sub satir_ekle_stok(ByVal yeni As Boolean)
        Dim frm As New frm_stok_satis
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.musterino = Trim(dr_baslik("FIRMANO"))
        frm.txt_ara.Text = Trim(dr_baslik("FIRMAKODU"))
        frm.firmatipi = firmatipi
        frm.sec_konum.Text = "Kodu"
        frm.kullanici = kullanici
        frm.DateEdit1.EditValue = dr_baslik("TARIH")
        frm.DateEdit2.EditValue = dr_baslik("TARIH")
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
                    dr("REFNO") = belgeind
                    dr("REFHAREKET") = 0
                    dr("STOKNO") = dr1("nStokID")
                    dr("STOKKODU") = Microsoft.VisualBasic.Left(dr1("sKodu"), 20)
                    dr("MALINCINSI") = Microsoft.VisualBasic.Left(dr1("sStokAciklama"), 50)
                    dr("BARCODE") = dr("STOKKODU")
                    dr("CIKAN") = 0
                    dr("GIREN") = 1
                    dr("BIRIM") = "Adet"
                    dr("FIYAT") = dr1("Fiyat")
                    dr("ISK") = 0
                    dr("ISKONTOTUTARI") = 0
                    dr("ISKONTOSUZTUTAR") = dr("GIREN") * dr("FIYAT")
                    dr("TUTAR") = dr("GIREN") * dr("FIYAT")
                    dr("UCRET") = 0
                    dr("GARANTILI") = 1
                    dr("ACIKLAMA") = ""
                    dr("AKSESUAR") = ""
                    dr("SERINO") = ""
                    dr("ARIZA") = ""
                    dr("MARKA") = ""
                    dr("MODEL") = dr1("sRenk")
                    dr("SATICI") = dr1("sSaticiRumuzu")
                    dr("SATISTARIHI") = dr1("dteTarih")
                    dr("SATISBELGENO") = dr1("lNo")
                    dr("SATISBELGETIPI") = dr1("fisTipi")
                    dr("sDepo") = "D001"
                    dr("SATISDEPO") = dr1("sMagaza")
                    dr("SERVIS") = ""
                    dr("STATUS") = True
                    dr("KAYITTARIHI") = Now
                    dr("SERVISTIPI") = False
                    If firmatipi = True Then
                        dr("YETKILISATICI") = dr_baslik("FIRMAKODU")
                    Else
                        dr("YETKILISATICI") = ""
                    End If
                    dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("REFNO"), dr("REFHAREKET"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("CIKAN"), dr("GIREN"), dr("BIRIM"), dr("FIYAT"), dr("ISK"), dr("ISKONTOTUTARI"), dr("ISKONTOSUZTUTAR"), dr("TUTAR"), dr("UCRET"), dr("GARANTILI"), dr("ACIKLAMA"), dr("AKSESUAR"), dr("SERINO"), dr("ARIZA"), dr("MARKA"), dr("MODEL"), dr("SATICI"), dr("SATISTARIHI"), dr("SATISBELGENO"), dr("SATISBELGETIPI"), dr("sDepo"), dr("SATISDEPO"), dr("SERVIS"), dr("STATUS"), dr("KAYITTARIHI"), dr("SERVISTIPI"), dr("YETKILISATICI"))
                    hareketler_kaydet_yeni(dr_baslik("TARIH"), 0, dr_baslik("BELGETIPI"), dr_baslik("BELGENO"), dr_baslik("IND"), "", dr("IND"), dr_baslik("IND"), Now, 0, dr_baslik("FIRMANO"))
                    ds_hareket.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                'yeni = frm.yeni
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
                'frm.XtraTabControl1.Dispose()
                'frm.XtraTabControl1 = Nothing
                'frm.XtraTabPage1.Dispose()
                'frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok(False)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
    End Sub
    Private Sub satir_ekle_stoklar(ByVal yeni As Boolean)
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
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
                    dr = ds_hareket.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("EVRAKNO") = belgeind
                    dr("REFNO") = belgeind
                    dr("REFHAREKET") = 0
                    dr("STOKNO") = dr1("nStokID")
                    dr("STOKKODU") = Microsoft.VisualBasic.Left(dr1("sKodu"), 20)
                    dr("MALINCINSI") = Microsoft.VisualBasic.Left(dr1("sAciklama"), 50)
                    dr("BARCODE") = dr("STOKKODU")
                    dr("CIKAN") = 0
                    dr("GIREN") = 1
                    dr("BIRIM") = "Adet"
                    Try
                        dr("FIYAT") = CType(dr1("PESIN"), Decimal)
                    Catch ex As Exception
                        dr("FIYAT") = 0
                    End Try
                    dr("ISK") = 0
                    dr("ISKONTOTUTARI") = 0
                    dr("ISKONTOSUZTUTAR") = dr("GIREN") * dr("FIYAT")
                    dr("TUTAR") = dr("GIREN") * dr("FIYAT")
                    dr("UCRET") = 0
                    dr("GARANTILI") = 1
                    dr("ACIKLAMA") = ""
                    dr("AKSESUAR") = ""
                    dr("SERINO") = ""
                    dr("ARIZA") = ""
                    dr("MARKA") = ""
                    dr("MODEL") = dr1("sRenkAdi")
                    dr("SATICI") = ""
                    dr("SATISTARIHI") = "01/01/1900"
                    dr("SATISBELGENO") = 0
                    dr("SATISBELGETIPI") = ""
                    dr("sDepo") = "D001"
                    dr("SATISDEPO") = "D001"
                    dr("SERVIS") = ""
                    dr("STATUS") = True
                    dr("KAYITTARIHI") = Now
                    dr("SERVISTIPI") = False
                    If firmatipi = True Then
                        dr("YETKILISATICI") = dr_baslik("FIRMAKODU")
                    Else
                        dr("YETKILISATICI") = ""
                    End If
                    dr("IND") = hareket_kaydet_yeni(dr("EVRAKNO"), dr("REFNO"), dr("REFHAREKET"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("CIKAN"), dr("GIREN"), dr("BIRIM"), dr("FIYAT"), dr("ISK"), dr("ISKONTOTUTARI"), dr("ISKONTOSUZTUTAR"), dr("TUTAR"), dr("UCRET"), dr("GARANTILI"), dr("ACIKLAMA"), dr("AKSESUAR"), dr("SERINO"), dr("ARIZA"), dr("MARKA"), dr("MODEL"), dr("SATICI"), dr("SATISTARIHI"), dr("SATISBELGENO"), dr("SATISBELGETIPI"), dr("sDepo"), dr("SATISDEPO"), dr("SERVIS"), dr("STATUS"), dr("KAYITTARIHI"), dr("SERVISTIPI"), dr("YETKILISATICI"))
                    hareketler_kaydet_yeni(dr_baslik("TARIH"), 0, dr_baslik("BELGETIPI"), dr_baslik("BELGENO"), dr_baslik("IND"), "", dr("IND"), dr_baslik("IND"), Now, 0, dr_baslik("FIRMANO"))
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
                    satir_ekle_stok(True)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView1.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr_hareket("STOKNO").ToString <> "" Then
                    hareket_kaydet_sil(dr_hareket("IND"))
                    hareketler_kaydet_sil(dr_baslik("BELGETIPI"), dr_baslik("IND"), dr_hareket("IND"))
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
    Private Sub fis_sil()
        If yetki_kontrol(kullanici, "frm_servis_silme") = True Then
            If XtraMessageBox.Show(Sorgu_sDil("Servis Ýþlem Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                belge_iptal(belgeind)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
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
            Dim lGercekToplam As Decimal = 0
            Dim lGercekFiyat As Decimal = 0
            Dim lIskTutar As Decimal = 0
            lFiyat = dr("FIYAT")
            lMiktar = dr("GIREN")
            If dr("ISK") > 100 Then
                dr("ISK") = 100
            ElseIf dr("ISK") < 0 Then
                dr("ISK") = 0
            End If
            If dr("GIREN") = 0 Then
                dr("GIREN") = 1
            End If
            If dr("GARANTILI") = True Then
                dr("UCRET") = 0
            End If
            If GridView1.FocusedColumn.Name.ToString = colISKONTOTUTARI.Name.ToString Then
                If dr("ISKONTOTUTARI") <> 0 Then
                    dr("ISK") = dr("ISKONTOTUTARI") / dr("ISKONTOSUZTUTAR") * 100
                Else
                    dr("ISK") = 0
                End If
                isk1 = lFiyat * ((100 - dr("ISK")) / 100)
            Else
                dr("ISKONTOTUTARI") = lFiyat * ((100 - dr("ISK")) / 100)
            End If
            'If GridView1.FocusedColumn.Name.ToString = colTUTAR.Name.ToString Then
            '    dr("FIYAT") = dr("TUTAR") / dr("GIREN")
            'Else
            '    dr("TUTAR") = dr("GIREN") * dr("FIYAT")
            'End If
            'dr("TUTAR") = dr("GIREN") * dr("FIYAT")
            isk1 = lFiyat * ((100 - dr("ISK")) / 100)
            isk2 = isk1 * ((100 - 0) / 100)
            isk3 = isk2 * ((100 - 0) / 100)
            isk4 = isk3 * ((100 - 0) / 100)
            isk5 = isk4
            lGercekFiyat = isk5
            lGercekToplam = isk5 * lMiktar
            lIskTutar = (lFiyat * lMiktar) - lGercekToplam
            'lkdvtutar = (lGercekToplam * (dr("nKdvOrani") / 100))
            If GridView1.FocusedColumn.Name.ToString = colISKONTOSUZTUTAR.Name.ToString Then
                dr("FIYAT") = dr("ISKONTOSUZTUTAR") / lMiktar
            Else
                dr("ISKONTOSUZTUTAR") = lMiktar * dr("FIYAT")
            End If
            dr("ISKONTOSUZTUTAR") = lMiktar * dr("FIYAT")
            dr("TUTAR") = lGercekToplam
            dr("ISKONTOTUTARI") = dr("ISKONTOSUZTUTAR") - lGercekToplam
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("REFNO"), dr("REFHAREKET"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("CIKAN"), dr("GIREN"), dr("BIRIM"), dr("FIYAT"), dr("ISK"), dr("ISKONTOTUTARI"), dr("ISKONTOSUZTUTAR"), dr("TUTAR"), dr("UCRET"), dr("GARANTILI"), dr("ACIKLAMA"), dr("AKSESUAR"), dr("SERINO"), dr("ARIZA"), dr("MARKA"), dr("MODEL"), dr("SATICI"), dr("SATISTARIHI"), dr("SATISBELGENO"), dr("SATISBELGETIPI"), dr("sDepo"), dr("SATISDEPO"), dr("SERVIS"), dr("STATUS"), dr("KAYITTARIHI"), dr("SERVISTIPI"), dr("YETKILISATICI"))
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub musteri()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            Try
                dr_baslik("FIRMANO") = dr1("nMusteriID")
                dr_baslik("FIRMAKODU") = dr1("lKodu")
                dr_baslik("FIRMAADI") = dr1("Musteri")
                dr_baslik("YETKILI") = dr1("Musteri")
                dr_baslik("ADRES") = dr1("sEvAdresi")
                dr_baslik("TELEFON") = dr1("sEvTelefonu")
            Catch ex As Exception
            End Try
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("FIRMATIPI"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("BELGETIPI"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("GIRIS"), dr_baslik("IADE"), dr_baslik("IPTAL"), dr_baslik("KAYITTARIHI"), dr_baslik("SONUC"), dr_baslik("ADRES"), dr_baslik("TELEFON"), dr_baslik("YETKILI"), dr_baslik("ILETISIM"))
        End If
    End Sub
    Private Sub firma()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr_baslik("FIRMANO") = Trim(dr1("nFirmaID"))
            dr_baslik("FIRMAKODU") = Trim(dr1("sKodu"))
            dr_baslik("FIRMAADI") = Microsoft.VisualBasic.Left(Trim(dr1("sAciklama")), 50)
            dr_baslik("YETKILI") = ""
            dr_baslik("ADRES") = Trim(dr1("Adres"))
            dr_baslik("TELEFON") = ""
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("FIRMATIPI"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("BELGETIPI"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("GIRIS"), dr_baslik("IADE"), dr_baslik("IPTAL"), dr_baslik("KAYITTARIHI"), dr_baslik("SONUC"), dr_baslik("ADRES"), dr_baslik("TELEFON"), dr_baslik("YETKILI"), dr_baslik("ILETISIM"))
        End If
    End Sub
    Private Sub satis_sec()
        Dim frm As New frm_stok_satis
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("FIRMANO")
        frm.txt_ara.Text = dr_baslik("FIRMAKODU")
        frm.sec_konum.Text = "Kodu"
        frm.kullanici = kullanici
        frm.DateEdit1.EditValue = dr_baslik("TARIH")
        frm.DateEdit2.EditValue = dr_baslik("TARIH")
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        'frm.islemstatus = True
    End Sub
    Private Sub belge_iptal(ByVal evrakno As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'Plan Baþlýk
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKSERVISBASLIK WHERE IND =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Plan Hareket
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKSERVISDETAY WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKSERVISHAREKETLERI WHERE EVRAKNO =" & evrakno & " AND REFBASLIK =" & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        satir_ekle_stok(False)
    End Sub
    Private Sub sec_firma_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_firma.ButtonPressed
        If GridView1.RowCount = 0 Then
            If firmatipi = False Then
                musteri()
            ElseIf firmatipi = True Then
                firma()
            End If
        End If
    End Sub
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        Try
            'Vgrid_baslik.PostEditor()
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("TARIH"), dr_baslik("BELGENO"), dr_baslik("FIRMATIPI"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("BELGETIPI"), dr_baslik("ACIKLAMA"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("GIRIS"), dr_baslik("IADE"), dr_baslik("IPTAL"), dr_baslik("KAYITTARIHI"), dr_baslik("SONUC"), dr_baslik("ADRES"), dr_baslik("TELEFON"), dr_baslik("YETKILI"), dr_baslik("ILETISIM"))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        satis_sec()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle_stok(False)
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        fis_sil()
    End Sub
    Private Sub frm_stok_servis_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If GridView1.RowCount = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..! " & vbCrLf & "Servis Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                belge_iptal(belgeind)
                'Me.Close()
            Else
            End If
        Else
            'baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), detay_miktar, miktar)
        End If
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'SplitterControl1 = Nothing
        'SplitterControl2 = Nothing
        'PanelControl3 = Nothing
        'BarManager1 = Nothing
        'barDockControlTop = Nothing
        'barDockControlBottom = Nothing
        'barDockControlLeft = Nothing
        'barDockControlRight = Nothing
        'Bar2 = Nothing
        'BarSubItem1 = Nothing
        'BarSubItem2 = Nothing
        'BarSubItem3 = Nothing
        'BarSubItem4 = Nothing
        'BarSubItem5 = Nothing
        'Bar3 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'GroupControl1 = Nothing
        'GroupControl2 = Nothing
        'GroupControl3 = Nothing
        'BarButtonItem1 = Nothing
        'BarButtonItem2 = Nothing
        'BarButtonItem3 = Nothing
        'BarSubItem6 = Nothing
        'BarButtonItem4 = Nothing
        'BarButtonItem5 = Nothing
        'BarButtonItem6 = Nothing
        'BarSubItem7 = Nothing
        'BarButtonItem7 = Nothing
        'BarButtonItem8 = Nothing
        'ds_baslik.Clear()
        'ds_baslik.Dispose()
        'ds_baslik = Nothing
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
        'rowIND = Nothing
        'rowTARIH = Nothing
        'rowBELGENO = Nothing
        'rowFIRMANO = Nothing
        'rowFIRMAKODU = Nothing
        'rowFIRMAADI = Nothing
        'rowBELGETIPI = Nothing
        'rowACIKLAMA = Nothing
        'rowKOD1 = Nothing
        'rowKOD2 = Nothing
        'rowKOD3 = Nothing
        'rowKOD4 = Nothing
        'rowKOD5 = Nothing
        'rowGIRIS = Nothing
        'rowIADE = Nothing
        'rowIPTAL = Nothing
        'rowKAYITTARIHI = Nothing
        'rowSONUC = Nothing
        'categoryTanýmlar = Nothing
        'categoryHesap_Bilgileri = Nothing
        'categoryEk_Bilgiler = Nothing
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'DataColumn21 = Nothing
        'rowADRES = Nothing
        'rowTELEFON = Nothing
        'rowYETKILI = Nothing
        'sec_aciklama = Nothing
        'ds_hareket.Clear()
        'ds_hareket.Dispose()
        'ds_hareket = Nothing
        'DataTable2 = Nothing
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
        'BarButtonItem9 = Nothing
        'BarButtonItem10 = Nothing
        'BarButtonItem11 = Nothing
        'BarButtonItem12 = Nothing
        'BarButtonItem13 = Nothing
        'BarButtonItem14 = Nothing
        'DataColumn42 = Nothing
        'colIND = Nothing
        'colSTOKNO = Nothing
        'colSTOKKODU = Nothing
        'colMALINCINSI = Nothing
        'colMIKTAR = Nothing
        'colBIRIM = Nothing
        'colBARCODE = Nothing
        'colFIYAT = Nothing
        'colTUTAR = Nothing
        'colACIKLAMA = Nothing
        'colAKSESUAR = Nothing
        'colSERINO = Nothing
        'colARIZA = Nothing
        'colMARKA = Nothing
        'colMODEL = Nothing
        'colSATICI = Nothing
        'colSATISTARIHI = Nothing
        'colSATISBELGENO = Nothing
        'colSATISBELGETIPI = Nothing
        'colSATISDEPO = Nothing
        'colSERVIS = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem5 = Nothing
        'BarButtonItem15 = Nothing
        'sec_fiyat = Nothing
        'sec_satici = Nothing
        'BarButtonItem16 = Nothing
        'BarButtonItem17 = Nothing
        'ds_belgetipi = Nothing
        'DataTable5 = Nothing
        'DataColumn83 = Nothing
        'DataColumn84 = Nothing
        'VGrid_baslik = Nothing
        'sec_izahat = Nothing
        'sec_firma = Nothing
        'sec_baslik_sonuc = Nothing
        'DataColumn43 = Nothing
        'DataColumn44 = Nothing
        'DataColumn45 = Nothing
        'DataColumn46 = Nothing
        'DataColumn47 = Nothing
        'colGARANTILI = Nothing
        'sec_birimler = Nothing
        'DataColumn48 = Nothing
        'colSERVISTIPI = Nothing
        'rowFIRMATIPI = Nothing
        'DataColumn49 = Nothing
        'DataColumn50 = Nothing
        'colUCRET = Nothing
        'sec_arizatipi = Nothing
        'sec_servis = Nothing
        'sec_yetkilisatici = Nothing
        'colYETKILISATICI = Nothing
        'MenuItem4 = Nothing
        'rowILETISIM = Nothing
        'sec_baslik_iletisim = Nothing
        'DataColumn51 = Nothing
        'OpenFileDialog1 = Nothing
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
        'ds_satici.Clear()
        'ds_satici.Dispose()
        'ds_satici = Nothing
        'firmatipi = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub satir_yetkili_satici_degistir()
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("YETKILISATICI") = dr1("sKodu")
            girdi_tutar_hesapla()
            GridView1.UpdateCurrentRow()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
        dr1 = Nothing
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
            girdi_tutar_hesapla()
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
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " WHERE BASLIK.IND > 0"
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Servis Talep"
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
            frx.SetVariable("BELGETIPI", "'Servis Kabul Formu'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKSERVISDETAY WHERE EVRAKNO =" & belgeind & " ORDER BY STOKKODU")
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKSERVISBASLIK WHERE IND =" & belgeind & "")
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
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
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
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKSERVISDETAY WHERE EVRAKNO =" & belgeind & " ORDER BY STOKKODU") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKSERVISBASLIK WHERE IND =" & belgeind & "") & ""
            args(3) = "qr_hareketéqr_baslik"
            args(4) = "" & status.ToString() & ""
            args(5) = "5"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "BELGETIPI"
            args(15) = "'Servis Kabul Formu'"
            processYol = args(0)
            For i As Integer = 1 To 15
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
    Private Sub sec_yetkilisatici_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_yetkilisatici.KeyDown
        If e.KeyCode = Keys.Space Then
            satir_yetkili_satici_degistir()
        ElseIf e.KeyCode = Keys.F4 Then
            satir_yetkili_satici_degistir()
        End If
    End Sub
    Private Sub sec_yetkilisatici_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_yetkilisatici.ButtonPressed
        satir_yetkili_satici_degistir()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView1.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Servis Ýþlemleri Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla(0, 0)
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla(0, 2)
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla(0, 1)
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        satir_ekle_stoklar(False)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        satir_ekle_stok(False)
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        satir_ekle_stoklar(False)
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        fis_sil()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        raporla(0, 0)
    End Sub
End Class
