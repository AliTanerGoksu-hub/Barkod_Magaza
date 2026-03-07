Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Public Class frm_stok_paket
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
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel_baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_toplamlar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_hareketler As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_toplam As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_depo_info As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_satis_info As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirEkle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_SatirSil As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents rowFIRMANO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFISNO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIRMAKODU As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIRMAADI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBELGENO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIZAHAT As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDEPO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowACIKLAMA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUSERNO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKAYITTARIHI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMIKTAR As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categoryTeslimat As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAçýklama As DevExpress.XtraVerticalGrid.Rows.CategoryRow
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHATA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBEDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents colMODEL As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
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
    Friend WithEvents colIND1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISNO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOYADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODEL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASIYER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowFISTARIH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents EditorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_baslik_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Panel_Ara As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_baslik_fisno As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents sec_baslik_firmakodu As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents rowbKilitli As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents collSevkiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_Miktar As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_paket))
        Me.Panel_baslik = New DevExpress.XtraEditors.PanelControl()
        Me.Vgrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl()
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
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.sec_depo_baslik = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_baslik_belgetipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.sec_baslik_aciklama = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.sec_baslik_fisno = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.sec_baslik_firmakodu = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.categoryTeslimat = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowFIRMANO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFISTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIZAHAT = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFISNO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIRMAKODU = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIRMAADI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDEPO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBELGENO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMIKTAR = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUSERNO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKAYITTARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.EditorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryAçýklama = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbKilitli = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.Panel_toplamlar = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_satis_info = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel_depo_info = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel_toplam = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.Panel_hareketler = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_hareket = New System.Windows.Forms.ContextMenu()
        Me.Menu_SatirEkle = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.Menu_SatirSil = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.Menu_DegerYay = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_Miktar = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_depo_hareket = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHATA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBEDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISNO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOYADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBARKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMODEL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASIYER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSevkiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.btn_SatirEkle = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_SatirSil = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.ds_belgetipi = New System.Data.DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Ara = New DevExpress.XtraEditors.PanelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_baslik.SuspendLayout()
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_fisno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik_firmakodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_toplamlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_toplamlar.SuspendLayout()
        CType(Me.Panel_satis_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_satis_info.SuspendLayout()
        CType(Me.Panel_depo_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_depo_info.SuspendLayout()
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_toplam.SuspendLayout()
        CType(Me.Panel_hareketler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_hareketler.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Miktar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Ara.SuspendLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_baslik
        '
        Me.Panel_baslik.Controls.Add(Me.Vgrid_baslik)
        Me.Panel_baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_baslik.Location = New System.Drawing.Point(0, 22)
        Me.Panel_baslik.Name = "Panel_baslik"
        Me.Panel_baslik.Size = New System.Drawing.Size(824, 200)
        Me.Panel_baslik.TabIndex = 0
        '
        'Vgrid_baslik
        '
        Me.Vgrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(648, 330, 208, 252)
        Me.Vgrid_baslik.DataMember = Nothing
        Me.Vgrid_baslik.DataSource = Me.ds_baslik
        Me.Vgrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vgrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.Vgrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.Vgrid_baslik.Name = "Vgrid_baslik"
        Me.Vgrid_baslik.OptionsBehavior.UseTabKey = False
        Me.Vgrid_baslik.RecordWidth = 139
        Me.Vgrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_depo_baslik, Me.sec_baslik_belgetipi, Me.sec_baslik_aciklama, Me.sec_baslik_fisno, Me.sec_baslik_firmakodu})
        Me.Vgrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTeslimat, Me.categoryTanýmlar, Me.categoryAçýklama, Me.rowbKilitli})
        Me.Vgrid_baslik.Size = New System.Drawing.Size(820, 196)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn34, Me.DataColumn35, Me.DataColumn52, Me.DataColumn54, Me.DataColumn55})
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
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FIRMANO"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FISNO"
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
        Me.DataColumn7.ColumnName = "BELGENO"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "IZAHAT"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "DEPO"
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
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "USERNO"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KAYITTARIHI"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "MIKTAR"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ADI"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "SOYADI"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "FISTARIHI"
        Me.DataColumn52.DataType = GetType(Date)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "FISKAYITTARIHI"
        Me.DataColumn54.DataType = GetType(Date)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "bKilitli"
        Me.DataColumn55.DataType = GetType(Byte)
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
        Me.sec_baslik_belgetipi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", 6, "IND"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "ACIKLAMA")})
        Me.sec_baslik_belgetipi.DataSource = Me.DataTable5
        Me.sec_baslik_belgetipi.DisplayMember = "ACIKLAMA"
        Me.sec_baslik_belgetipi.Name = "sec_baslik_belgetipi"
        Me.sec_baslik_belgetipi.NullText = "[BelgeTipi Seç]"
        Me.sec_baslik_belgetipi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_baslik_belgetipi.ShowFooter = False
        Me.sec_baslik_belgetipi.ShowHeader = False
        Me.sec_baslik_belgetipi.ShowLines = False
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
        'sec_baslik_aciklama
        '
        Me.sec_baslik_aciklama.Name = "sec_baslik_aciklama"
        Me.sec_baslik_aciklama.ScrollBars = System.Windows.Forms.ScrollBars.None
        '
        'sec_baslik_fisno
        '
        Me.sec_baslik_fisno.AutoHeight = False
        Me.sec_baslik_fisno.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_baslik_fisno.Name = "sec_baslik_fisno"
        '
        'sec_baslik_firmakodu
        '
        Me.sec_baslik_firmakodu.AutoHeight = False
        Me.sec_baslik_firmakodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_baslik_firmakodu.Name = "sec_baslik_firmakodu"
        '
        'categoryTeslimat
        '
        Me.categoryTeslimat.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowFIRMANO, Me.rowFISTARIH, Me.rowIZAHAT, Me.rowFISNO, Me.rowFIRMAKODU, Me.rowFIRMAADI, Me.rowDEPO})
        Me.categoryTeslimat.Name = "categoryTeslimat"
        Me.categoryTeslimat.Properties.Caption = "Teslimat"
        '
        'rowFIRMANO
        '
        Me.rowFIRMANO.Name = "rowFIRMANO"
        Me.rowFIRMANO.Properties.Caption = "Firma No"
        Me.rowFIRMANO.Properties.FieldName = "FIRMANO"
        Me.rowFIRMANO.Visible = False
        '
        'rowFISTARIH
        '
        Me.rowFISTARIH.Name = "rowFISTARIH"
        Me.rowFISTARIH.Properties.Caption = "FiþTarihi"
        Me.rowFISTARIH.Properties.FieldName = "FISTARIHI"
        '
        'rowIZAHAT
        '
        Me.rowIZAHAT.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowIZAHAT.Appearance.Options.UseFont = True
        Me.rowIZAHAT.Name = "rowIZAHAT"
        Me.rowIZAHAT.Properties.Caption = "Belge Tipi"
        Me.rowIZAHAT.Properties.FieldName = "IZAHAT"
        Me.rowIZAHAT.Properties.RowEdit = Me.sec_baslik_belgetipi
        '
        'rowFISNO
        '
        Me.rowFISNO.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowFISNO.Appearance.Options.UseFont = True
        Me.rowFISNO.Name = "rowFISNO"
        Me.rowFISNO.Properties.Caption = "Fiþ No"
        Me.rowFISNO.Properties.FieldName = "FISNO"
        Me.rowFISNO.Properties.RowEdit = Me.sec_baslik_fisno
        '
        'rowFIRMAKODU
        '
        Me.rowFIRMAKODU.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowFIRMAKODU.Appearance.Options.UseFont = True
        Me.rowFIRMAKODU.Name = "rowFIRMAKODU"
        Me.rowFIRMAKODU.Properties.Caption = "Firma Kodu"
        Me.rowFIRMAKODU.Properties.FieldName = "FIRMAKODU"
        Me.rowFIRMAKODU.Properties.RowEdit = Me.sec_baslik_firmakodu
        '
        'rowFIRMAADI
        '
        Me.rowFIRMAADI.Name = "rowFIRMAADI"
        Me.rowFIRMAADI.Properties.Caption = "Firma Adý"
        Me.rowFIRMAADI.Properties.FieldName = "FIRMAADI"
        '
        'rowDEPO
        '
        Me.rowDEPO.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowDEPO.Appearance.Options.UseFont = True
        Me.rowDEPO.Name = "rowDEPO"
        Me.rowDEPO.Properties.Caption = "Depo"
        Me.rowDEPO.Properties.FieldName = "DEPO"
        Me.rowDEPO.Properties.RowEdit = Me.sec_depo_baslik
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIND, Me.rowBELGENO, Me.rowMIKTAR, Me.rowUSERNO, Me.rowKAYITTARIHI, Me.EditorRow1})
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
        Me.rowBELGENO.Name = "rowBELGENO"
        Me.rowBELGENO.Properties.Caption = "Belge No"
        Me.rowBELGENO.Properties.FieldName = "BELGENO"
        '
        'rowMIKTAR
        '
        Me.rowMIKTAR.Name = "rowMIKTAR"
        Me.rowMIKTAR.Properties.Caption = "TeslimEdilecekMiktar"
        Me.rowMIKTAR.Properties.FieldName = "MIKTAR"
        Me.rowMIKTAR.Properties.Format.FormatString = "#,0.00"
        Me.rowMIKTAR.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowMIKTAR.Properties.ReadOnly = True
        '
        'rowUSERNO
        '
        Me.rowUSERNO.Name = "rowUSERNO"
        Me.rowUSERNO.Properties.Caption = "Kaydeden"
        Me.rowUSERNO.Properties.FieldName = "USERNO"
        Me.rowUSERNO.Properties.ReadOnly = True
        Me.rowUSERNO.Visible = False
        '
        'rowKAYITTARIHI
        '
        Me.rowKAYITTARIHI.Name = "rowKAYITTARIHI"
        Me.rowKAYITTARIHI.Properties.Caption = "Kayýt Tarihi"
        Me.rowKAYITTARIHI.Properties.FieldName = "KAYITTARIHI"
        Me.rowKAYITTARIHI.Properties.ReadOnly = True
        Me.rowKAYITTARIHI.Visible = False
        '
        'EditorRow1
        '
        Me.EditorRow1.Name = "EditorRow1"
        Me.EditorRow1.Properties.Caption = "BelgeTarihi"
        Me.EditorRow1.Properties.FieldName = "TARIH"
        Me.EditorRow1.Properties.ReadOnly = True
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
        Me.rowKOD3.Visible = False
        '
        'rowKOD4
        '
        Me.rowKOD4.Name = "rowKOD4"
        Me.rowKOD4.Properties.Caption = "4.ÖzelKod"
        Me.rowKOD4.Properties.FieldName = "KOD4"
        Me.rowKOD4.Visible = False
        '
        'rowKOD5
        '
        Me.rowKOD5.Name = "rowKOD5"
        Me.rowKOD5.Properties.Caption = "5.ÖzelKod"
        Me.rowKOD5.Properties.FieldName = "KOD5"
        Me.rowKOD5.Visible = False
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowACIKLAMA.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowACIKLAMA.Appearance.Options.UseFont = True
        Me.rowACIKLAMA.Appearance.Options.UseForeColor = True
        Me.rowACIKLAMA.Height = 71
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.Properties.Caption = "Açýklama"
        Me.rowACIKLAMA.Properties.FieldName = "ACIKLAMA"
        '
        'rowbKilitli
        '
        Me.rowbKilitli.Name = "rowbKilitli"
        Me.rowbKilitli.Properties.Caption = "Kilitli?"
        Me.rowbKilitli.Properties.FieldName = "bKilitli"
        '
        'Panel_toplamlar
        '
        Me.Panel_toplamlar.Controls.Add(Me.Panel_satis_info)
        Me.Panel_toplamlar.Controls.Add(Me.Panel_depo_info)
        Me.Panel_toplamlar.Controls.Add(Me.Panel_toplam)
        Me.Panel_toplamlar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_toplamlar.Location = New System.Drawing.Point(0, 376)
        Me.Panel_toplamlar.Name = "Panel_toplamlar"
        Me.Panel_toplamlar.Size = New System.Drawing.Size(824, 80)
        Me.Panel_toplamlar.TabIndex = 3
        '
        'Panel_satis_info
        '
        Me.Panel_satis_info.Controls.Add(Me.Label1)
        Me.Panel_satis_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_satis_info.Location = New System.Drawing.Point(151, 2)
        Me.Panel_satis_info.Name = "Panel_satis_info"
        Me.Panel_satis_info.Size = New System.Drawing.Size(505, 76)
        Me.Panel_satis_info.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*"
        '
        'Panel_depo_info
        '
        Me.Panel_depo_info.Controls.Add(Me.Label3)
        Me.Panel_depo_info.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_depo_info.Location = New System.Drawing.Point(2, 2)
        Me.Panel_depo_info.Name = "Panel_depo_info"
        Me.Panel_depo_info.Size = New System.Drawing.Size(149, 76)
        Me.Panel_depo_info.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "*"
        '
        'Panel_toplam
        '
        Me.Panel_toplam.Controls.Add(Me.Label2)
        Me.Panel_toplam.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_toplam.Location = New System.Drawing.Point(656, 2)
        Me.Panel_toplam.Name = "Panel_toplam"
        Me.Panel_toplam.Size = New System.Drawing.Size(166, 76)
        Me.Panel_toplam.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 222)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 6)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'Panel_hareketler
        '
        Me.Panel_hareketler.Controls.Add(Me.XtraTabControl1)
        Me.Panel_hareketler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_hareketler.Location = New System.Drawing.Point(0, 228)
        Me.Panel_hareketler.Name = "Panel_hareketler"
        Me.Panel_hareketler.Size = New System.Drawing.Size(824, 116)
        Me.Panel_hareketler.TabIndex = 4
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 112)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 79)
        Me.XtraTabPage1.Text = "Teslimat"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_hareket
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_depo_hareket, Me.sec_Miktar})
        Me.GridControl1.Size = New System.Drawing.Size(818, 79)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_hareket
        '
        Me.kisayol_hareket.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_SatirEkle, Me.MenuItem2, Me.Menu_SatirSil, Me.MenuItem6, Me.MenuItem5, Me.Menu_DegerYay})
        '
        'Menu_SatirEkle
        '
        Me.Menu_SatirEkle.Index = 0
        Me.Menu_SatirEkle.Text = "Satýr Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Düzelt"
        '
        'Menu_SatirSil
        '
        Me.Menu_SatirSil.Index = 2
        Me.Menu_SatirSil.Text = "Satýr Sil"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem6.Text = "Okut"
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
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn53})
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
        Me.DataColumn23.ColumnName = "MALINCINSI"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "BARCODE"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "MIKTAR"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "DEPO"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "MEVCUT"
        Me.DataColumn27.DataType = GetType(Boolean)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "HATA"
        Me.DataColumn28.DataType = GetType(Boolean)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "ACIKLAMA"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "FISNO"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "RENK"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "BEDEN"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "MODEL"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "OKUT"
        Me.DataColumn53.DataType = GetType(Boolean)
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colEVRAKNO, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colBARCODE, Me.colMIKTAR, Me.colDEPO, Me.colMEVCUT, Me.colHATA, Me.colACIKLAMA, Me.colIZAHAT, Me.colFISNO, Me.colRENK, Me.colBEDEN, Me.colMODEL})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(437, 256, 208, 170)
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
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'colEVRAKNO
        '
        Me.colEVRAKNO.Caption = "Evrak No"
        Me.colEVRAKNO.FieldName = "EVRAKNO"
        Me.colEVRAKNO.Name = "colEVRAKNO"
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.OptionsColumn.AllowEdit = False
        Me.colMALINCINSI.OptionsColumn.AllowFocus = False
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 2
        Me.colMALINCINSI.Width = 176
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barkod"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        Me.colBARCODE.OptionsColumn.AllowFocus = False
        Me.colBARCODE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BARCODE", "{0} Kayýt")})
        Me.colBARCODE.Visible = True
        Me.colBARCODE.VisibleIndex = 0
        Me.colBARCODE.Width = 99
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.ColumnEdit = Me.sec_Miktar
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.##}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        Me.colMIKTAR.Width = 33
        '
        'sec_Miktar
        '
        Me.sec_Miktar.AutoHeight = False
        Me.sec_Miktar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_Miktar.DisplayFormat.FormatString = "#,0.###"
        Me.sec_Miktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_Miktar.EditFormat.FormatString = "#,0.###"
        Me.sec_Miktar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_Miktar.MaxValue = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.sec_Miktar.MinValue = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.sec_Miktar.Name = "sec_Miktar"
        '
        'colDEPO
        '
        Me.colDEPO.Caption = "Depo"
        Me.colDEPO.ColumnEdit = Me.sec_depo_hareket
        Me.colDEPO.FieldName = "DEPO"
        Me.colDEPO.Name = "colDEPO"
        Me.colDEPO.Visible = True
        Me.colDEPO.VisibleIndex = 4
        Me.colDEPO.Width = 45
        '
        'sec_depo_hareket
        '
        Me.sec_depo_hareket.AutoHeight = False
        Me.sec_depo_hareket.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo_hareket.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOADI", "DEPOADI")})
        Me.sec_depo_hareket.DisplayMember = "DEPOADI"
        Me.sec_depo_hareket.Name = "sec_depo_hareket"
        Me.sec_depo_hareket.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_depo_hareket.ShowFooter = False
        Me.sec_depo_hareket.ShowHeader = False
        Me.sec_depo_hareket.ShowLines = False
        Me.sec_depo_hareket.ValueMember = "DEPOKODU"
        '
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcutmu"
        Me.colMEVCUT.FieldName = "MEVCUT"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.Width = 72
        '
        'colHATA
        '
        Me.colHATA.Caption = "Hatalýmý"
        Me.colHATA.FieldName = "HATA"
        Me.colHATA.Name = "colHATA"
        Me.colHATA.OptionsColumn.ReadOnly = True
        Me.colHATA.Visible = True
        Me.colHATA.VisibleIndex = 5
        Me.colHATA.Width = 46
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 6
        Me.colACIKLAMA.Width = 189
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Belge Tipi"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        '
        'colFISNO
        '
        Me.colFISNO.Caption = "Fiþ No"
        Me.colFISNO.FieldName = "FISNO"
        Me.colFISNO.Name = "colFISNO"
        '
        'colRENK
        '
        Me.colRENK.Caption = "Renk"
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.Name = "colRENK"
        Me.colRENK.OptionsColumn.AllowFocus = False
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 1
        Me.colRENK.Width = 51
        '
        'colBEDEN
        '
        Me.colBEDEN.Caption = "Beden"
        Me.colBEDEN.FieldName = "BEDEN"
        Me.colBEDEN.Name = "colBEDEN"
        Me.colBEDEN.Width = 77
        '
        'colMODEL
        '
        Me.colMODEL.Caption = "Model"
        Me.colMODEL.FieldName = "MODEL"
        Me.colMODEL.Name = "colMODEL"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(818, 79)
        Me.XtraTabPage2.Text = "Ürünler"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = Nothing
        Me.GridControl2.DataSource = Me.ds_detay
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(818, 79)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND1, Me.colTARIH, Me.colFISNO1, Me.colFIRMAKODU, Me.colADI, Me.colSOYADI, Me.colDEPONO, Me.colSTOKKODU1, Me.colMALINCINSI1, Me.colBARKOD, Me.colRENK1, Me.colMIKTAR1, Me.colMODEL1, Me.colIZAHAT1, Me.colSATICI, Me.colKASIYER, Me.collSevkiyat, Me.collKalan})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(315, 247, 208, 170)
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
        'colIND1
        '
        Me.colIND1.Caption = "Kayýt No"
        Me.colIND1.FieldName = "IND"
        Me.colIND1.Name = "colIND1"
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        '
        'colFISNO1
        '
        Me.colFISNO1.Caption = "Fiþ No"
        Me.colFISNO1.FieldName = "FISNO"
        Me.colFISNO1.Name = "colFISNO1"
        Me.colFISNO1.Visible = True
        Me.colFISNO1.VisibleIndex = 0
        Me.colFISNO1.Width = 50
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Firma Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        '
        'colADI
        '
        Me.colADI.Caption = "Adý"
        Me.colADI.FieldName = "ADI"
        Me.colADI.Name = "colADI"
        '
        'colSOYADI
        '
        Me.colSOYADI.Caption = "Soyadý"
        Me.colSOYADI.FieldName = "SOYADI"
        Me.colSOYADI.Name = "colSOYADI"
        '
        'colDEPONO
        '
        Me.colDEPONO.Caption = "Depo"
        Me.colDEPONO.FieldName = "DEPONO"
        Me.colDEPONO.Name = "colDEPONO"
        Me.colDEPONO.Visible = True
        Me.colDEPONO.VisibleIndex = 4
        Me.colDEPONO.Width = 77
        '
        'colSTOKKODU1
        '
        Me.colSTOKKODU1.Caption = "Stok Kodu"
        Me.colSTOKKODU1.FieldName = "STOKKODU"
        Me.colSTOKKODU1.Name = "colSTOKKODU1"
        Me.colSTOKKODU1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU1.Visible = True
        Me.colSTOKKODU1.VisibleIndex = 1
        Me.colSTOKKODU1.Width = 153
        '
        'colMALINCINSI1
        '
        Me.colMALINCINSI1.Caption = "Stok Adý"
        Me.colMALINCINSI1.FieldName = "MALINCINSI"
        Me.colMALINCINSI1.Name = "colMALINCINSI1"
        Me.colMALINCINSI1.Visible = True
        Me.colMALINCINSI1.VisibleIndex = 2
        Me.colMALINCINSI1.Width = 147
        '
        'colBARKOD
        '
        Me.colBARKOD.Caption = "Barkod"
        Me.colBARKOD.FieldName = "BARKOD"
        Me.colBARKOD.Name = "colBARKOD"
        Me.colBARKOD.Width = 107
        '
        'colRENK1
        '
        Me.colRENK1.Caption = "Renk"
        Me.colRENK1.FieldName = "RENK"
        Me.colRENK1.Name = "colRENK1"
        Me.colRENK1.Visible = True
        Me.colRENK1.VisibleIndex = 3
        Me.colRENK1.Width = 97
        '
        'colMIKTAR1
        '
        Me.colMIKTAR1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMIKTAR1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMIKTAR1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colMIKTAR1.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colMIKTAR1.AppearanceCell.Options.UseBackColor = True
        Me.colMIKTAR1.AppearanceCell.Options.UseFont = True
        Me.colMIKTAR1.AppearanceCell.Options.UseForeColor = True
        Me.colMIKTAR1.Caption = "Miktar"
        Me.colMIKTAR1.DisplayFormat.FormatString = "#,0.##"
        Me.colMIKTAR1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR1.FieldName = "MIKTAR"
        Me.colMIKTAR1.Name = "colMIKTAR1"
        Me.colMIKTAR1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.##}")})
        Me.colMIKTAR1.Visible = True
        Me.colMIKTAR1.VisibleIndex = 6
        Me.colMIKTAR1.Width = 112
        '
        'colMODEL1
        '
        Me.colMODEL1.Caption = "Model"
        Me.colMODEL1.FieldName = "MODEL"
        Me.colMODEL1.Name = "colMODEL1"
        '
        'colIZAHAT1
        '
        Me.colIZAHAT1.Caption = "Belge Tipi"
        Me.colIZAHAT1.FieldName = "IZAHAT"
        Me.colIZAHAT1.Name = "colIZAHAT1"
        '
        'colSATICI
        '
        Me.colSATICI.Caption = "Satýcý"
        Me.colSATICI.FieldName = "SATICI"
        Me.colSATICI.Name = "colSATICI"
        Me.colSATICI.Visible = True
        Me.colSATICI.VisibleIndex = 5
        Me.colSATICI.Width = 106
        '
        'colKASIYER
        '
        Me.colKASIYER.Caption = "Kasiyer"
        Me.colKASIYER.FieldName = "KASIYER"
        Me.colKASIYER.Name = "colKASIYER"
        Me.colKASIYER.Width = 99
        '
        'collSevkiyat
        '
        Me.collSevkiyat.Caption = "Sevkiyat"
        Me.collSevkiyat.DisplayFormat.FormatString = "#,0.###"
        Me.collSevkiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkiyat.FieldName = "lSevkiyat"
        Me.collSevkiyat.Name = "collSevkiyat"
        Me.collSevkiyat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkiyat", "{0:#,0.###}")})
        Me.collSevkiyat.Visible = True
        Me.collSevkiyat.VisibleIndex = 7
        '
        'collKalan
        '
        Me.collKalan.Caption = "Kalan"
        Me.collKalan.DisplayFormat.FormatString = "#,0.###"
        Me.collKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalan.FieldName = "lKalan"
        Me.collKalan.Name = "collKalan"
        Me.collKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalan", "{0:#,0.###}")})
        Me.collKalan.Visible = True
        Me.collKalan.VisibleIndex = 8
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.btn_SatirEkle, Me.BarButtonItem6, Me.btn_SatirSil, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarSubItem4, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem5, Me.BarButtonItem7})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 20
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kaydet Yeni Belge"
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem8.Name = "BarButtonItem8"
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
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Kalanlarý Yazdýr"
        Me.BarButtonItem7.Id = 19
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Belgeyi Ýptal Et"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Satýr"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirEkle), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_SatirSil), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True)})
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
        Me.btn_SatirSil.Caption = "Satýr Sil"
        Me.btn_SatirSil.Id = 9
        Me.btn_SatirSil.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.btn_SatirSil.Name = "btn_SatirSil"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Okut"
        Me.BarButtonItem9.Id = 11
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Bilgi"
        Me.BarSubItem4.Id = 12
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Müþteri Kartý"
        Me.BarButtonItem10.Id = 13
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Satýþlar"
        Me.BarButtonItem11.Id = 14
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Ekstre"
        Me.BarButtonItem12.Id = 15
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Teslimat Hatalarý"
        Me.BarButtonItem13.Id = 16
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Envanter"
        Me.BarButtonItem14.Id = 17
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Fiþi Göster"
        Me.BarButtonItem5.Id = 18
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem5.Name = "BarButtonItem5"
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
        'Panel_Ara
        '
        Me.Panel_Ara.Controls.Add(Me.Label4)
        Me.Panel_Ara.Controls.Add(Me.SimpleButton3)
        Me.Panel_Ara.Controls.Add(Me.sec_kriter)
        Me.Panel_Ara.Controls.Add(Me.txt_ara)
        Me.Panel_Ara.Controls.Add(Me.lbl_ara)
        Me.Panel_Ara.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Ara.Location = New System.Drawing.Point(0, 344)
        Me.Panel_Ara.Name = "Panel_Ara"
        Me.Panel_Ara.Size = New System.Drawing.Size(824, 32)
        Me.Panel_Ara.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(400, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(7, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "*"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(322, 7)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(70, 20)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Eþittir"
        Me.sec_kriter.Location = New System.Drawing.Point(240, 7)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.ReadOnly = True
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 5
        '
        'txt_ara
        '
        Me.txt_ara.Location = New System.Drawing.Point(35, 7)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 30
        Me.txt_ara.Size = New System.Drawing.Size(198, 20)
        Me.txt_ara.TabIndex = 4
        '
        'lbl_ara
        '
        Me.lbl_ara.Location = New System.Drawing.Point(7, 8)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(6, 13)
        Me.lbl_ara.TabIndex = 3
        Me.lbl_ara.Text = "*"
        '
        'frm_stok_paket
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 478)
        Me.Controls.Add(Me.Panel_hareketler)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.Panel_baslik)
        Me.Controls.Add(Me.Panel_Ara)
        Me.Controls.Add(Me.Panel_toplamlar)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_paket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Paketleme"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_baslik.ResumeLayout(False)
        CType(Me.Vgrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_fisno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik_firmakodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplamlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplamlar.ResumeLayout(False)
        CType(Me.Panel_satis_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satis_info.ResumeLayout(False)
        CType(Me.Panel_depo_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_depo_info.ResumeLayout(False)
        CType(Me.Panel_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplam.ResumeLayout(False)
        CType(Me.Panel_hareketler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hareketler.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Miktar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_detay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_belgetipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Ara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Ara.ResumeLayout(False)
        Me.Panel_Ara.PerformLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim ds_stok As DataSet
    Dim ds_iade As DataSet
    Dim mevcut As Decimal = 0
    Public x
    Public okut As Boolean = False
    Private Sub frm_stok_paket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        belgetipleri()
        baslik()
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        Try
            dataload_hareket()
        Catch ex As Exception
        End Try
        Timer1.Enabled = True
        If dr_baslik("bKilitli") = True Then
            GridView1.OptionsBehavior.Editable = False
            Menu_DegerYay.Enabled = False
            Menu_SatirEkle.Enabled = False
            Menu_SatirSil.Enabled = False
            btn_SatirEkle.Enabled = False
            btn_SatirSil.Enabled = False
            Panel_Ara.Enabled = False
        End If
        stok_kontrol_teslim(False)
        If yetki_kontrol(kullanici, "frm_stok_paket_tarih") = True Then
            rowFISTARIH.Properties.ReadOnly = False
        Else
            rowFISTARIH.Properties.ReadOnly = True
        End If
        GridView2.ClearColumnsFilter()
        GridView2.Columns("lKalan").FilterInfo = New ColumnFilterInfo("[lKalan] <> 0 ")
    End Sub
    Private Sub loaded()
        dataload_baslik()
        dataload_harekets()
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
    End Sub
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        cmd.Connection = con
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ASTOKPAKETBASLIK WHERE IND =" & belgeind & "")
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
        'GridControl1.Select()
    End Sub
    Private Function sorgu_harekets(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        cmd.Connection = con
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ASTOKPAKETDETAY WHERE EVRAKNO =" & belgeind & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
    End Function
    Private Function baslik_kaydet_yeni(ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal ADI As String, ByVal SOYADI As String, ByVal BELGENO As String, ByVal FISTARIHI As DateTime, ByVal TARIH As DateTime, ByVal IZAHAT As String, ByVal FISNO As String, ByVal DEPO As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal ACIKLAMA As String, ByVal USERNO As Int64, ByVal KAYITTARIHI As DateTime, ByVal MIKTAR As Decimal, ByVal TESLIMAT As Decimal, ByVal FISKAYITTARIHI As DateTime, ByVal bKilitli As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKPAKETBASLIK (FIRMANO, FIRMAKODU, ADI, SOYADI, BELGENO, FISTARIHI, TARIH, IZAHAT, FISNO, DEPO, KOD1, KOD2, KOD3, KOD4, KOD5, ACIKLAMA, USERNO, KAYITTARIHI, MIKTAR,TESLIMAT,FISKAYITTARIHI,bKilitli) VALUES     (" & FIRMANO & ", '" & FIRMAKODU & "', '" & ADI & "', '" & SOYADI & "', '" & BELGENO & "', '" & FISTARIHI & "', '" & TARIH & "', '" & IZAHAT & "', '" & FISNO & "', '" & DEPO & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & ACIKLAMA & "', " & USERNO & ",  '" & KAYITTARIHI & "', " & MIKTAR & "," & TESLIMAT & ",'" & FISKAYITTARIHI & "'," & bKilitli & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Function hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal FIRMANO As Int64, ByVal FISNO As String, ByVal IZAHAT As String, ByVal TARIH As DateTime, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal RENK As String, ByVal BEDEN As String, ByVal MODEL As String, ByVal MIKTAR As Decimal, ByVal DEPO As String, ByVal MEVCUT As Byte, ByVal HATA As Byte, ByVal ACIKLAMA As String, ByVal okut As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.ConnectionString = connection
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKPAKETDETAY (EVRAKNO, FIRMANO, FISNO, IZAHAT, TARIH, STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, MIKTAR, DEPO, MEVCUT, HATA, ACIKLAMA,OKUT) VALUES     (" & EVRAKNO & ", " & FIRMANO & ", '" & FISNO & "', '" & Trim(IZAHAT) & "', '" & TARIH & "', " & STOKNO & ", '" & STOKKODU & "', '" & MALINCINSI & "', '" & BARCODE & "', '" & RENK & "', '" & BEDEN & "', '" & MODEL & "', " & MIKTAR & ", '" & Trim(DEPO) & "', " & MEVCUT & ", " & HATA & ", '" & ACIKLAMA & "'," & okut & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub baslik_kaydet_degistir(ByVal evrakno As Int64, ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal ADI As String, ByVal SOYADI As String, ByVal BELGENO As String, ByVal FISTARIHI As DateTime, ByVal TARIH As DateTime, ByVal IZAHAT As String, ByVal FISNO As String, ByVal DEPO As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal ACIKLAMA As String, ByVal USERNO As Int64, ByVal KAYITTARIHI As DateTime, ByVal MIKTAR As Decimal, ByVal TESLIMAT As Decimal, ByVal FISKAYITTARIHI As DateTime, ByVal bKilitli As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.ConnectionString = connection
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKPAKETBASLIK SET              FIRMANO = " & FIRMANO & ", FIRMAKODU = '" & FIRMAKODU & "', FIRMAADI ='" & FIRMAADI & "',ADI = '" & ADI & "', SOYADI = '" & SOYADI & "', BELGENO = '" & BELGENO & "', FISTARIHI = '" & FISTARIHI & "',FISKAYITTARIHI = '" & FISKAYITTARIHI & "', KAYITTARIHI = '" & KAYITTARIHI & "',TARIH = '" & TARIH & "',IZAHAT = '" & IZAHAT & "', FISNO = '" & FISNO & "', DEPO = '" & DEPO & "', KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', KOD3 = '" & KOD3 & "', KOD4 = '" & KOD4 & "', KOD5 = '" & KOD5 & "', ACIKLAMA = '" & ACIKLAMA & "', USERNO = " & USERNO & ", MIKTAR = " & MIKTAR & ",TESLIMAT =" & TESLIMAT & ",bKilitli =" & bKilitli & " WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal FIRMANO As Int64, ByVal FISNO As String, ByVal IZAHAT As String, ByVal TARIH As DateTime, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal RENK As String, ByVal BEDEN As String, ByVal MODEL As String, ByVal MIKTAR As Decimal, ByVal DEPO As String, ByVal MEVCUT As Byte, ByVal HATA As Byte, ByVal ACIKLAMA As String, ByVal okut As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKPAKETDETAY SET              EVRAKNO = " & EVRAKNO & ", FIRMANO = " & FIRMANO & ", FISNO = '" & FISNO & "', IZAHAT = '" & IZAHAT & "', TARIH = '" & TARIH & "', STOKNO = " & STOKNO & ", STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "', BARCODE = '" & BARCODE & "', RENK = '" & RENK & "', BEDEN = '" & BEDEN & "', MODEL = '" & MODEL & "', MIKTAR = " & MIKTAR & ", DEPO = '" & DEPO & "', MEVCUT = " & MEVCUT & ", HATA = " & HATA & ",OKUT =" & okut & ", ACIKLAMA = '" & ACIKLAMA & "' WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub baslik_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKPAKETBASLIK  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKPAKETDETAY  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub dataload_hareket()
        ds_detay = sorgu_hareket(dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"))
        GridControl2.DataSource = ds_detay.Tables(0)
        GridControl2.DataMember = Nothing
        GridControl2.RefreshDataSource()
        'GridControl2.Refresh()
        'GridControl2.Select()
        'Dim dr As DataRow
        stok_kontrol_teslim(False)
        If ds_detay.Tables(0).Rows.Count > 0 Then
            Dim miktar As Decimal = 0
            Dim lFisNo As Int64 = 0
            Dim dr As DataRow = ds_detay.Tables(0).Rows(0)
            For Each dr In ds_detay.Tables(0).Rows
                If dr("MIKTAR") > 0 Then
                    miktar = miktar + dr("MIKTAR")
                ElseIf dr("MIKTAR") < 0 Then
                    If lFisNo <> dr("FISNO") Then
                        miktar = miktar + dr("MIKTAR")
                    End If
                End If
                If lFisNo <> dr("FISNO") Then
                    lFisNo = dr("FISNO")
                End If
            Next
            detay_miktar = miktar
            If status = False Then
                Dim kontrol = sorgu_baslik_kontrol(dr_baslik("TARIH"), dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"), dr_baslik("DEPO"))
                If status = False Then
                    If kontrol > 0 Then
                        XtraMessageBox.Show(Sorgu_sDil("Bilgilerini Girmekte Olduðunuz Fiþ Önceden Teslim Edilmiþ... Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If kontrol = 1 Then
                            If Trim(dr_baslik("IZAHAT").ToString) = "PF" Or Trim(dr_baslik("IZAHAT").ToString) = "K" Or Trim(dr_baslik("IZAHAT").ToString) = "P" Then
                                If XtraMessageBox.Show(Sorgu_sDil("Fiþi Açmak Ýster misiniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                                    belgeind = sorgu_baslik_kontrol_kayitno(dr_baslik("TARIH"), dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"), dr_baslik("DEPO"))
                                    belgetipleri()
                                    baslik()
                                    Try
                                        loaded()
                                    Catch ex As Exception
                                    End Try
                                    Timer1.Enabled = True
                                End If
                            End If
                        End If
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Toplam Teslim Edilecek Ürün Miktarý : ", sDil) & FormatNumber(miktar, 0), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'MsgBox(Sorgu_sDil("Toplam Teslim Edilecek Ürün Miktarý : " & FormatNumber(miktar, 0))
                        dr_baslik("MIKTAR") = miktar
                        dr_baslik("FIRMANO") = dr("FIRMANO")
                        'dr_baslik("FIRMAKODU") = dr("FIRMAKODU")
                        dr_baslik("ADI") = dr("ADI")
                        dr_baslik("SOYADI") = dr("SOYADI")
                        dr_baslik("FIRMAADI") = Microsoft.VisualBasic.Left(dr("ADI") & " " & dr("SOYADI"), 50)
                        dr_baslik("FISKAYITTARIHI") = dr("dteKayitTarihi")
                        dr_baslik("KAYITTARIHI") = sorgu_tarih_sistem(1)
                        baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), dr_baslik("MIKTAR"), miktar, dr_baslik("FISKAYITTARIHI"), dr_baslik("bKilitli"))
                        rowFISTARIH.Properties.ReadOnly = True
                        rowIZAHAT.Properties.ReadOnly = True
                        rowFISNO.Properties.ReadOnly = True
                        rowFIRMAKODU.Properties.ReadOnly = True
                        rowFIRMAADI.Properties.ReadOnly = True
                        'satir_ekle_stok(False)
                        txt_ara.Focus()
                        txt_ara.SelectAll()
                        Label4.Text = "Yeni Fiþ..."
                        Label4.Refresh()
                    End If
                End If
            End If
        End If
        toplam_hesapla()
    End Sub
    Public Function sorgu_hareket(ByVal tarih As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String) As DataSet
        Dim kriter
        Dim kriter2 = ""
        If Trim(firmakodu) = "" Then
            firmakodu = "0"
        End If
        If Trim(izahat) = "FS" Then
            kriter = "WHERE (Hareket.dteFisTarihi = '" & tarih & "') AND (tbFirma.nFirmaID = '" & firmakodu & "') AND (Hareket.lFisNo = " & fisno & ") AND (Hareket.sFisTipi = '" & izahat & "') "
        ElseIf Trim(izahat) = "AS" Then
            kriter = "WHERE (tbSiparis.dteSiparisTarihi = '" & tarih & "') AND (tbFirma.nFirmaID = '" & firmakodu & "') AND (tbSiparis.lSiparisNo = " & fisno & ") AND (tbSiparis.nSiparisTipi = '1') "
        ElseIf Trim(izahat) = "VS" Then
            kriter = "WHERE (tbSiparis.dteSiparisTarihi = '" & tarih & "') AND (tbFirma.nFirmaID = '" & firmakodu & "') AND (tbSiparis.lSiparisNo = " & fisno & ") AND (tbSiparis.nSiparisTipi = '2') "
        Else
            kriter = "WHERE (Hareket.dteFisTarihi = '" & tarih & "') AND (Musteri.lKodu = '" & firmakodu & "') AND (Hareket.lFisNo = " & fisno & ") AND (Hareket.sFisTipi = '" & izahat & "') "
            ds_iade = sorgu_iade_fisler(dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"))
            Dim dr1 As DataRow
            For Each dr1 In ds_iade.Tables(0).Rows
                kriter2 += " UNION ALL SELECT Hareket.dteKayitTarihi,Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID (tbStokBarkodu.nKisim IN(0)) INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk WHERE Hareket.nAlisVerisID = '" & dr1("nAlisVerisID") & "' ORDER BY Hareket.lFisNo"
            Next
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If Trim(izahat) = "FS" Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Hareket.dteKayitTarihi, Hareket.dteFisTarihi AS TARIH, tbFirma.nFirmaID AS FIRMANO, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, tbFirma.sAciklama AS ADI,'' as SOYADI,Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk INNER JOIN tbFirma ON Hareket.nFirmaID = tbFirma.nFirmaID  " & kriter & " " & kriter2 & "")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Hareket.dteFisTarihi as dteKayitTarihi, Hareket.dteFisTarihi AS TARIH, tbFirma.nFirmaID AS FIRMANO, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, tbFirma.sAciklama AS ADI,'' as SOYADI,Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, SUM(Hareket.lCikisMiktar1) AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, '' AS SATICI, '' AS KASIYER, Hareket.lFisNo AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID and (tbStokBarkodu.nKisim = 0) INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk INNER JOIN tbFirma ON Hareket.nFirmaID = tbFirma.nFirmaID  " & kriter & " " & kriter2 & " GROUP BY Hareket.dteFisTarihi, Hareket.sFisTipi,tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, Hareket.lFisNo, Hareket.sDepo,Stok.sKodu, Stok.sAciklama, tbRenk.sRenkAdi,  Stok.sModel, Stok.nStokID,tbStokBarkodu.sBarkod")
        ElseIf Trim(izahat) = "AS" Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.dteKayitTarihi, tbSiparis.dteSiparisTarihi AS TARIH, tbFirma.nFirmaID AS FIRMANO, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI,tbFirma.sAciklama AS ADI,'' as SOYADI, tbSiparis.lSiparisNo AS FISNO, '' AS DEPONO, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS MALINCINSI, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS BARKOD, tbRenk.sRenkAdi AS RENK, tbSiparis.lMiktari AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,tbStok.sModel AS MODEL, 'AS' AS IZAHAT, '' AS SATICI, '' AS KASIYER, tbSiparis.nSiparisID AS IND FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID " & kriter & " " & kriter2 & "")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.dteSiparisTarihi as dteKayitTarihi, tbSiparis.dteSiparisTarihi AS TARIH, tbFirma.nFirmaID AS FIRMANO, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI,tbFirma.sAciklama AS ADI,'' as SOYADI, tbSiparis.lSiparisNo AS FISNO, '' AS DEPONO, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS MALINCINSI, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and (nKisim = 0)) AS BARKOD, tbRenk.sRenkAdi AS RENK, SUM(tbSiparis.lMiktari) AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,tbStok.sModel AS MODEL, 'AS' AS IZAHAT, '' AS SATICI, '' AS KASIYER, tbSiparis.lSiparisNo AS IND FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID " & kriter & " " & kriter2 & " GROUP BY tbSiparis.dteSiparisTarihi, tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbStok.sKodu, tbStok.sAciklama, tbRenk.sRenkAdi,  tbStok.sModel, tbStok.nStokID")
        ElseIf Trim(izahat) = "VS" Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.dteKayitTarihi, tbSiparis.dteSiparisTarihi AS TARIH, tbFirma.nFirmaID AS FIRMANO, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, tbFirma.sAciklama AS ADI,'' as SOYADI,tbSiparis.lSiparisNo AS FISNO, '' AS DEPONO, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS MALINCINSI, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS BARKOD, tbRenk.sRenkAdi AS RENK, tbSiparis.lMiktari AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,tbStok.sModel AS MODEL, 'VS' AS IZAHAT, '' AS SATICI, '' AS KASIYER, tbSiparis.nSiparisID AS IND FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID " & kriter & " " & kriter2 & "")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.dteSiparisTarihi as dteKayitTarihi, tbSiparis.dteSiparisTarihi AS TARIH, tbFirma.nFirmaID AS FIRMANO, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI,tbFirma.sAciklama AS ADI,'' as SOYADI, tbSiparis.lSiparisNo AS FISNO, '' AS DEPONO, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS MALINCINSI, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and (nKisim = 0)) AS BARKOD, tbRenk.sRenkAdi AS RENK, SUM(tbSiparis.lMiktari) AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,tbStok.sModel AS MODEL, 'AS' AS IZAHAT, '' AS SATICI, '' AS KASIYER, tbSiparis.lSiparisNo AS IND FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID " & kriter & " " & kriter2 & " GROUP BY tbSiparis.dteSiparisTarihi, tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbStok.sKodu, tbStok.sAciklama, tbRenk.sRenkAdi,  tbStok.sModel, tbStok.nStokID")
        Else
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Hareket.dteKayitTarihi,Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID AND (tbStokBarkodu.nKisim = 0) INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & " " & kriter2 & " ORDER BY HAREKET.MIKTAR DESC")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Hareket.dteKayitTarihi,Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, CAST(0 AS MONEY) AS lSevkiyat,Cast(0 as Money) as lKalan,Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID AND (tbStokBarkodu.nKisim = 0) INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & " " & kriter2 & "")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
        kriter = Nothing
        kriter2 = Nothing
    End Function
    Public Function sorgu_iade_fisler(ByVal tarih As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String) As DataSet
        Dim kriter
        If Trim(firmakodu) = "" Then
            firmakodu = "0"
        End If
        kriter = "WHERE (Hareket.dteFaturaTarihi = '" & tarih & "') AND (Musteri.lKodu = " & firmakodu & ") AND (Hareket.lFaturaNo = " & fisno & ") AND (Hareket.sFisTipi = '" & izahat & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     DISTINCT tbOdeme.nAlisverisID FROM         tbOdeme INNER JOIN                       tbAlisVeris Hareket ON tbOdeme.nIadeAlisverisID = Hareket.nAlisverisID INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID " & kriter & "")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_baslik_kontrol(ByVal tarih As DateTime, ByVal fistarihi As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String, ByVal DEPO As String) As Int64
        Dim kriter
        kriter = "WHERE (FISTARIHI = '" & fistarihi & "') AND (FIRMAKODU = '" & firmakodu & "') AND (FISNO = '" & fisno & "') AND (IZAHAT = '" & izahat & "') "
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
            dr("FISTARIHI") = sorgu_tarih_sistem()
            dr("TARIH") = dr("FISTARIHI")
            dr("KAYITTARIHI") = sorgu_tarih_sistem(1)
            dr("FISNO") = ""
            dr("FIRMANO") = 0
            dr("FIRMAKODU") = ""
            dr("FIRMAADI") = ""
            dr("ADI") = ""
            dr("SOYADI") = ""
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
            dr("KOD5") = kullaniciadi
            dr("ACIKLAMA") = ""
            dr("USERNO") = kullanici
            dr("MIKTAR") = 0
            dr("FISKAYITTARIHI") = dr("FISTARIHI")
            dr("bKilitli") = 0
            belgeind = baslik_kaydet_yeni(0, "", dr("FIRMAADI"), "", "", dr("BELGENO"), dr("FISTARIHI"), dr("TARIH"), dr("IZAHAT"), dr("FISNO"), dr("DEPO"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("ACIKLAMA"), dr("USERNO"), dr("KAYITTARIHI"), dr("MIKTAR"), 0, dr("FISTARIHI"), 0)
            dr("IND") = belgeind
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = Nothing
            Vgrid_baslik.Focus()
            Vgrid_baslik.Select()
            Vgrid_baslik.FocusedRow = rowIZAHAT
        ElseIf belgeind <> 0 Then
            rowFISTARIH.Properties.ReadOnly = True
            rowIZAHAT.Properties.ReadOnly = True
            rowFISNO.Properties.ReadOnly = True
            rowFIRMAKODU.Properties.ReadOnly = True
            rowFIRMAADI.Properties.ReadOnly = True
        Else
            Me.Close()
        End If
    End Sub
    Public Function sorgu_tarih_sistem(Optional ByVal islem As Integer = 0) As DateTime
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If islem = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select convert (char(12) , getdate() , 103) as Tarih")
        ElseIf islem = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select  getdate()  as Tarih")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub baslik_yeni()
        belgeind = 0
        ds_baslik.Tables(0).Clear()
        rowFISTARIH.Properties.ReadOnly = False
        rowIZAHAT.Properties.ReadOnly = False
        rowFISNO.Properties.ReadOnly = False
        rowFIRMAKODU.Properties.ReadOnly = False
        rowFIRMAADI.Properties.ReadOnly = False
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
            dr("FISTARIHI") = sorgu_tarih_sistem()
            dr("TARIH") = dr("FISTARIHI")
            dr("KAYITTARIHI") = Now
            dr("FISNO") = ""
            dr("FIRMANO") = 0
            dr("FIRMAKODU") = ""
            dr("FIRMAADI") = ""
            dr("ADI") = ""
            dr("SOYADI") = ""
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
            dr("KOD5") = kullaniciadi
            dr("ACIKLAMA") = ""
            dr("USERNO") = kullanici
            dr("MIKTAR") = 0
            dr("FISKAYITTARIHI") = dr("TARIH")
            dr("bKilitli") = 0
            belgeind = baslik_kaydet_yeni(0, "", dr("FIRMAADI"), "", "", dr("BELGENO"), dr("FISTARIHI"), dr("TARIH"), dr("IZAHAT"), dr("FISNO"), dr("DEPO"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("ACIKLAMA"), dr("USERNO"), dr("KAYITTARIHI"), dr("MIKTAR"), 0, dr("FISKAYITTARIHI"), 0)
            dr("IND") = belgeind
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = Nothing
            Panel_baslik.Focus()
            Panel_baslik.Select()
            Vgrid_baslik.Focus()
            Vgrid_baslik.Select()
            Vgrid_baslik.FocusedRow = rowIZAHAT
        ElseIf belgeind <> 0 Then
            rowFISTARIH.Properties.ReadOnly = True
            rowIZAHAT.Properties.ReadOnly = True
            rowFISNO.Properties.ReadOnly = True
            rowFIRMAKODU.Properties.ReadOnly = True
            rowFIRMAADI.Properties.ReadOnly = True
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
        seri = ""
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
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(BELGENO,'A-000001') AS BELGENO FROM ASTOKPAKETBASLIK WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM ASTOKPAKETBASLIK  WHERE  BELGENO LIKE 'A%')")
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
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "FS"
        dr1("ACIKLAMA") = "Satis Faturasi"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "AS"
        dr1("ACIKLAMA") = "Alýnan Siparis"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_belgetipi.Tables(0).NewRow
        dr1("IND") = "VS"
        dr1("ACIKLAMA") = "Verilen Siparis"
        ds_belgetipi.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkle.ItemClick
        If dr_baslik("FIRMANO") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            If miktar - detay_miktar = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                satir_ekle_stok(False)
            End If
            Timer1.Enabled = True
        ElseIf dr_baslik("FIRMANO") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Teslim Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Function sorgu_s(ByVal query As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        cmd.Connection = con
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
    Private Sub stok_kontrol_teslim(Optional ByVal message As Boolean = True)
        Dim dr As DataRow
        Dim satis_miktar As Decimal = 0
        Dim s As String = ""
        s += "EksikTeslimat;" & vbCrLf
        For Each dr In ds_detay.Tables(0).Rows
            satis_miktar = stok_kontrol_miktar(dr("BARKOD"), dr("MIKTAR"))
            If satis_miktar > 0 Then
                If dr("MIKTAR") >= satis_miktar Then
                    s += Trim(dr("STOKKODU")) & vbTab & FormatNumber(satis_miktar, 2) & vbTab & Trim(dr("MALINCINSI")) & vbCrLf
                    dr("lSevkiyat") = dr("MIKTAR") - satis_miktar
                    dr("lKalan") = satis_miktar
                End If
            Else
                dr("lSevkiyat") = dr("MIKTAR")
                dr("lKalan") = 0
            End If
            satis_miktar = 0
        Next
        's += vbCrLf
        's += " " & vbCrLf
        's += "FazlaTeslimat;" & vbCrLf
        'For Each dr In ds_hareket.Tables(0).Rows
        '    satis_miktar = stok_kontrol_miktar(dr("BARCODE"), dr("MIKTAR"))
        '    If satis_miktar < 0 Then
        '        If dr("MIKTAR") >= satis_miktar Then
        '            s += Trim(dr("STOKKODU")) & vbTab & FormatNumber(dr("MIKTAR"), 2) & vbTab & Trim(dr("MALINCINSI")) & vbCrLf
        '        End If
        '    End If
        '    satis_miktar = 0
        'Next
        If message = True Then
            XtraMessageBox.Show(s, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        s = Nothing
        dr = Nothing
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            End If
            'dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = dr("STOKKODU")
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
    Private Function muadilToMasterBarkode(ByVal mBarkod As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SELECT sBarkod FROM tbStokBarkodu WHERE nKisim = 0 AND nStokID = (Select nStokID From tbStokBarkodu Where sBarkod = '" & Trim(mBarkod) & "')")
        mBarkod = cmd.ExecuteScalar
        Return mBarkod
    End Function
    Private Function stok_kontrol_miktar(ByVal stokkodu As String, ByVal miktar As Decimal) As Decimal
        Dim dr As DataRow
        Dim DR1 As DataRow
        Dim sayi As Decimal = 0
        Dim satis_miktar As Decimal = 0
        For Each dr In ds_detay.Tables(0).Rows
            If Trim(dr("BARKOD")) = Trim(stokkodu) Then
                satis_miktar += dr("MIKTAR")
            End If
        Next
        Dim teslim_miktar As Decimal = 0
        For Each DR1 In ds_hareket.Tables(0).Rows
            If Trim(DR1("BARCODE")) = Trim(stokkodu) Then
                teslim_miktar += DR1("MIKTAR")
            End If
        Next
        sayi = (satis_miktar - teslim_miktar)
        Return sayi
    End Function
    Private Sub satir_ekle_stok(ByVal yeni As Boolean)
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.okut = False
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
                    Dim satis_miktar As Decimal = 0
                    satis_miktar = stok_kontrol_miktar(dr1("sBarkod"), frm.mevcut)
                    If frm.mevcut <= satis_miktar Then
                        'MsgBox(Sorgu_sDil("Satýþ Yapýlabilir Miktar: " & satis_miktar)
                        dr = ds_hareket.Tables(0).NewRow
                        dr("STOKNO") = dr1("nStokId")
                        dr("STOKKODU") = dr1("sKodu")
                        dr("MALINCINSI") = dr1("sAciklama")
                        dr("BARCODE") = dr1("sBarkod")
                        dr("MODEL") = dr1("sModel")
                        dr("RENK") = dr1("sRenkAdi")
                        dr("MEVCUT") = 0
                        Dim sayi = stok_kontrol(dr("BARCODE"))
                        If sayi = 0 Then
                            If XtraMessageBox.Show(Sorgu_sDil("Okutulan Ürün Satýþ Listesinde Gözükmemektedir..!" & vbCrLf & " Hata Kaydý Düþüyorum", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning) = MsgBoxResult.Ok Then
                                dr("HATA") = 1
                            End If
                        Else
                            dr("HATA") = 0
                            'MsgBox(stok_kontrol_miktar(dr("BARCODE"), frm.mevcut))
                        End If
                        If frm.okut = False Then
                            dr("OKUT") = 0
                        ElseIf frm.okut = True Then
                            dr("OKUT") = 1
                        End If
                        dr("DEPO") = dr_baslik("DEPO")
                        dr("MIKTAR") = frm.mevcut
                        dr("BEDEN") = ""
                        dr("MEVCUT") = 1
                        dr("ACIKLAMA") = ""
                        dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr("HATA"))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                        ds_hareket.Tables(0).Rows.Add(dr)
                        Me.Refresh()
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Seçilen Ürünün Teslimatý Yapýlmýþ veya Teslimat Listesinde Yok...!!!" & vbCrLf & "Lütfen Ürünü Kontrol Ediniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
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
                        kaydet_yeni()
                    Else
                        satir_ekle_stok(False)
                    End If
                    Timer1.Enabled = True
                End If
                stok_kontrol_teslim(False)
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
    End Sub
    'Burasý
    Private Sub satir_ekle_stok_tek(ByVal yeni As Boolean)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        s = i.ToString
        dr1 = ds_stok.Tables(0).Rows(0)
        Dim satis_miktar As Decimal = 0
        satis_miktar = stok_kontrol_miktar(dr1("sBarkod"), mevcut)
        If mevcut <= satis_miktar Then
            'MsgBox(Sorgu_sDil("Satýþ Yapýlabilir Miktar: " & satis_miktar)
            dr = ds_hareket.Tables(0).NewRow
            dr("STOKNO") = dr1("nStokId")
            dr("STOKKODU") = dr1("sKodu")
            dr("MALINCINSI") = dr1("sAciklama")
            dr("BARCODE") = dr1("sBarkod")
            dr("MODEL") = dr1("sModel")
            dr("RENK") = dr1("sRenkAdi")
            dr("MEVCUT") = 0
            Dim sayi = stok_kontrol(dr("BARCODE"))
            If sayi = 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Okutulan Ürün Satýþ Listesinde Gözükmemektedir..!" & vbCrLf & " Hata Kaydý Düþüyorum", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning) = MsgBoxResult.Ok Then
                    dr("HATA") = 1
                End If
            Else
                dr("HATA") = 0
                'MsgBox(stok_kontrol_miktar(dr("BARCODE"), frm.mevcut))
            End If
            If okut = False Then
                dr("OKUT") = 0
            ElseIf okut = True Then
                dr("OKUT") = 1
            End If
            dr("DEPO") = dr_baslik("DEPO")
            dr("MIKTAR") = mevcut
            dr("BEDEN") = ""
            dr("MEVCUT") = 1
            dr("ACIKLAMA") = ""
            dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr("HATA"))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
            ds_hareket.Tables(0).Rows.Add(dr)
            Label4.Text = "Stok Teslimatý Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            Me.Refresh()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Seçilen Ürünün Teslimatý Yapýlmýþ veya Teslimat Listesinde Yok...!!!" & vbCrLf & "Lütfen Ürünü Kontrol Ediniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = "Seçilen Ürünün Teslimatý Yapýlmýþ veya Teslimat Listesinde Yok...!!!"
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
        stok_kontrol_teslim(False)
        If yeni = True Then
            Timer1.Enabled = False
            toplam_hesapla()
            If miktar - detay_miktar = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Label4.Text = "Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz..."
                Label4.Refresh()
                kaydet_yeni()
            End If
            Timer1.Enabled = True
        End If
        dr = Nothing
        dr1 = Nothing
        s = Nothing
        arr = Nothing
        i = Nothing
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_ekle_stok_koli(ByVal sKoliKodu As String)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        s = i.ToString
        'dr1 = ds_stok.Tables(0).Rows(0)
        Dim satis_miktar As Decimal = 0
        Dim lMevcut As Decimal = mevcut
        Dim ds_tbKoliDagilim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET,  ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,tbKoliDagilimi.lMiktar AS lMiktar,tbKoliDagilimi.sBirimCinsi,tbKoliDagilimi.lBirimMiktar,tbKoliDagilimi.lFiyat,tbKoliDagilimi.sFiyatTipi FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND (tbStokBarkodu.nKisim IN (0,1)) INNER JOIN tbKoliDagilimi ON tbStok.nStokID = tbKoliDagilimi.nStokID WHERE (tbKoliDagilimi.sKoliKodu = N'" & sKoliKodu & "')")
        For Each dr1 In ds_tbKoliDagilim.Tables(0).Rows
            mevcut = lMevcut * sorgu_sayi(dr1("lMiktar") * dr1("lBirimMiktar"), 1)
            satis_miktar = stok_kontrol_miktar(dr1("sBarkod").ToString, mevcut)
            If mevcut <= satis_miktar Then
                'MsgBox("Satýþ Yapýlabilir Miktar: " & satis_miktar)
                dr = ds_hareket.Tables(0).NewRow
                dr("STOKNO") = dr1("nStokId")
                dr("STOKKODU") = dr1("sKodu")
                dr("MALINCINSI") = dr1("sAciklama")
                dr("BARCODE") = dr1("sBarkod")
                dr("MODEL") = dr1("sModel")
                dr("RENK") = dr1("sRenkAdi")
                dr("MEVCUT") = 0
                Dim sayi = stok_kontrol(dr("BARCODE"))
                If sayi = 0 Then
                    If MsgBox("Okutulan Ürün Satýþ Listesinde Gözükmemektedir..!" & vbCrLf & " Hata Kaydý Düþüyorum", MsgBoxStyle.Critical) = MsgBoxResult.Ok Then
                        dr("HATA") = 1
                    End If
                Else
                    dr("HATA") = 0
                    'MsgBox(stok_kontrol_miktar(dr("BARCODE"), frm.mevcut))
                End If
                If okut = False Then
                    dr("OKUT") = 0
                ElseIf okut = True Then
                    dr("OKUT") = 1
                End If
                dr("DEPO") = dr_baslik("DEPO")
                dr("MIKTAR") = mevcut
                dr("BEDEN") = ""
                dr("MEVCUT") = 1
                dr("ACIKLAMA") = ""
                dr("IND") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr("HATA"))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                ds_hareket.Tables(0).Rows.Add(dr)
                Label2.Text = "Stok Teslimatý Ýþlendi...Yeni Ürün Okutun..."
                Label2.Refresh()
                Me.Refresh()
            Else
                MsgBox("Seçilen Ürünün Teslimatý Yapýlmýþ veya Teslimat Listesinde Yok...!!!" & vbCrLf & "Lütfen Ürünü Kontrol Ediniz.", MsgBoxStyle.Information, "Uyarý...")
                Label2.Text = "Seçilen Ürünün Teslimatý Yapýlmýþ veya Teslimat Listesinde Yok...!!!"
                Label2.Refresh()
                txt_ara.Focus()
                txt_ara.SelectAll()
            End If
        Next
        'If yeni = True Then
        '    Timer1.Enabled = False
        '    toplam_hesapla()
        '    If miktar - detay_miktar = 0 Then
        '        MsgBox("Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz...", MsgBoxStyle.Critical, "Kontrol")
        '        Label2.Text = "Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz..."
        '        Label2.Refresh()
        '        kaydet_yeni()
        '    Else
        '        'satir_ekle_stok(False)
        '    End If
        '    Timer1.Enabled = True
        'End If
        stok_kontrol_teslim(False)
        dr = Nothing
        dr1 = Nothing
        s = Nothing
        arr = Nothing
        i = Nothing
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
                If dr_hareket("STOKNO").ToString <> "" Then
                    hareket_kaydet_sil(dr_hareket("IND"))
                End If
                'DataTable1.Rows.RemoveAt(GridView1.FocusedRowHandle - 1)
                ds_hareket.Tables(0).Rows.Remove(dr_hareket)
                stok_kontrol_teslim(False)
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
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKPAKETBASLIK WHERE IND =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Plan Hareket
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKPAKETDETAY WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
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
            hareket_kaydet_degistir(dr("IND"), dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr("HATA"))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
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
            If stok_kontrol_miktar(dr("BARCODE"), dr("MIKTAR")) < 0 Then
                MsgBox("Fazla Yükleme Yapamazsýnýz...!", MsgBoxStyle.Critical, "Dikkat")
                Dim satir = GridView1.FocusedRowHandle
                dataload_harekets()
                GridView1.FocusedRowHandle = satir
            Else
                dr.EndEdit()
                hareket_kaydet_degistir(dr("IND"), dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr("HATA"))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
                GridControl1.Focus()
                GridControl1.Select()
                stok_kontrol_teslim(False)
                toplam_hesapla()
            End If
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
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirEkle.Click
        If dr_baslik("FIRMANO") <> 0 Then
            Timer1.Enabled = False
            toplam_hesapla()
            If miktar - detay_miktar = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                satir_ekle_stok(False)
            End If
            Timer1.Enabled = True
        ElseIf dr_baslik("FIRMANO") = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Teslim Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Vgrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles Vgrid_baslik.CellValueChanged
        Try
            'Vgrid_baslik.PostEditor()
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
            If dr_baslik("FIRMANO") = 0 Then
                dataload_hareket()
                'txt_ara.Focus()
                'txt_ara.SelectAll()
                Label4.Text = "Yeni Fiþ..."
                Label4.Refresh()
            End If
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), dr_baslik("MIKTAR"), miktar, dr_baslik("FISKAYITTARIHI"), dr_baslik("bKilitli"))
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
                GridControl2.Focus()
                GridControl2.Focus()
                GridView2.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Paketleme Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            belge_iptal(belgeind)
            Me.Close()
        End If
    End Sub
    Private Sub frm_stok_paket_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If GridView1.RowCount = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Boþ Belge Kaydedemezsiniz..! " & vbCrLf & "Paketleme Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                belge_iptal(belgeind)
                Me.Close()
            Else
                Timer1.Enabled = False
                toplam_hesapla()
                baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), detay_miktar, miktar, dr_baslik("FISKAYITTARIHI"), dr_baslik("bKilitli"))
                Timer1.Enabled = True
            End If
        Else
            Timer1.Enabled = False
            toplam_hesapla()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), detay_miktar, miktar, dr_baslik("FISKAYITTARIHI"), dr_baslik("bKilitli"))
            Timer1.Enabled = True
        End If
        'Tanýmlarý Sil
        SplitterControl1 = Nothing
        BarManager1 = Nothing
        barDockControlTop = Nothing
        barDockControlBottom = Nothing
        barDockControlLeft = Nothing
        barDockControlRight = Nothing
        Bar2 = Nothing
        Bar3 = Nothing
        BarSubItem1 = Nothing
        BarSubItem2 = Nothing
        BarSubItem3 = Nothing
        Vgrid_baslik = Nothing
        XtraTabControl1 = Nothing
        XtraTabPage1 = Nothing
        XtraTabPage2 = Nothing
        Panel_baslik = Nothing
        Panel_toplamlar = Nothing
        Panel_hareketler = Nothing
        Panel_toplam = Nothing
        Panel_depo_info = Nothing
        Panel_satis_info = Nothing
        GridControl1 = Nothing
        GridView1 = Nothing
        GridControl2 = Nothing
        GridView2 = Nothing
        BarButtonItem1 = Nothing
        BarButtonItem2 = Nothing
        BarButtonItem3 = Nothing
        BarButtonItem4 = Nothing
        btn_SatirEkle = Nothing
        BarButtonItem6 = Nothing
        btn_SatirSil = Nothing
        ds_baslik.Clear()
        ds_baslik.Dispose()
        ds_baslik = Nothing
        DataTable1 = Nothing
        DataColumn1 = Nothing
        DataColumn2 = Nothing
        DataColumn3 = Nothing
        DataColumn4 = Nothing
        DataColumn5 = Nothing
        DataColumn6 = Nothing
        DataColumn7 = Nothing
        DataColumn8 = Nothing
        DataColumn9 = Nothing
        DataColumn10 = Nothing
        DataColumn11 = Nothing
        DataColumn12 = Nothing
        DataColumn13 = Nothing
        DataColumn14 = Nothing
        DataColumn15 = Nothing
        DataColumn16 = Nothing
        DataColumn17 = Nothing
        DataColumn18 = Nothing
        rowIND = Nothing
        rowFIRMANO = Nothing
        rowFISNO = Nothing
        rowFIRMAKODU = Nothing
        rowFIRMAADI = Nothing
        rowBELGENO = Nothing
        rowIZAHAT = Nothing
        rowDEPO = Nothing
        rowKOD1 = Nothing
        rowKOD2 = Nothing
        rowKOD3 = Nothing
        rowKOD4 = Nothing
        rowKOD5 = Nothing
        rowACIKLAMA = Nothing
        rowUSERNO = Nothing
        rowKAYITTARIHI = Nothing
        rowMIKTAR = Nothing
        categoryTeslimat = Nothing
        categoryTanýmlar = Nothing
        categoryAçýklama = Nothing
        ds_hareket.Clear()
        ds_hareket.Dispose()
        ds_hareket = Nothing
        DataTable2 = Nothing
        DataColumn19 = Nothing
        DataColumn20 = Nothing
        DataColumn21 = Nothing
        DataColumn22 = Nothing
        DataColumn23 = Nothing
        DataColumn24 = Nothing
        DataColumn25 = Nothing
        DataColumn26 = Nothing
        DataColumn27 = Nothing
        DataColumn28 = Nothing
        DataColumn29 = Nothing
        colIND = Nothing
        colEVRAKNO = Nothing
        colSTOKNO = Nothing
        colSTOKKODU = Nothing
        colMALINCINSI = Nothing
        colBARCODE = Nothing
        colMIKTAR = Nothing
        colDEPO = Nothing
        colMEVCUT = Nothing
        colHATA = Nothing
        colACIKLAMA = Nothing
        colIZAHAT = Nothing
        colFISNO = Nothing
        DataColumn30 = Nothing
        DataColumn31 = Nothing
        DataColumn32 = Nothing
        colRENK = Nothing
        colBEDEN = Nothing
        DataColumn33 = Nothing
        colMODEL = Nothing
        kisayol_hareket = Nothing
        Menu_SatirEkle = Nothing
        MenuItem2 = Nothing
        Menu_SatirSil = Nothing
        Menu_DegerYay = Nothing
        MenuItem5 = Nothing
        sec_depo_baslik = Nothing
        sec_depo_hareket = Nothing
        ds_belgetipi.Clear()
        ds_belgetipi.Dispose()
        ds_belgetipi = Nothing
        DataTable5 = Nothing
        DataColumn83 = Nothing
        DataColumn84 = Nothing
        sec_baslik_belgetipi = Nothing
        BarButtonItem8 = Nothing
        DataColumn34 = Nothing
        DataColumn35 = Nothing
        ds_detay.Clear()
        ds_detay.Dispose()
        ds_detay = Nothing
        DataTable3 = Nothing
        DataColumn36 = Nothing
        DataColumn37 = Nothing
        DataColumn38 = Nothing
        DataColumn39 = Nothing
        DataColumn40 = Nothing
        DataColumn41 = Nothing
        DataColumn42 = Nothing
        DataColumn43 = Nothing
        DataColumn44 = Nothing
        DataColumn45 = Nothing
        DataColumn46 = Nothing
        DataColumn47 = Nothing
        DataColumn48 = Nothing
        DataColumn49 = Nothing
        DataColumn50 = Nothing
        DataColumn51 = Nothing
        colIND1 = Nothing
        colTARIH = Nothing
        colFISNO1 = Nothing
        colFIRMAKODU = Nothing
        colADI = Nothing
        colSOYADI = Nothing
        colDEPONO = Nothing
        colSTOKKODU1 = Nothing
        colMALINCINSI1 = Nothing
        colBARKOD = Nothing
        colRENK1 = Nothing
        colMIKTAR1 = Nothing
        colMODEL1 = Nothing
        colIZAHAT1 = Nothing
        colSATICI = Nothing
        colKASIYER = Nothing
        rowFISTARIH = Nothing
        DataColumn52 = Nothing
        EditorRow1 = Nothing
        Timer1 = Nothing
        Label1 = Nothing
        DataColumn53 = Nothing
        Label2 = Nothing
        Label3 = Nothing
        sec_baslik_aciklama = Nothing
        Panel_Ara = Nothing
        lbl_ara = Nothing
        txt_ara = Nothing
        SimpleButton3 = Nothing
        sec_kriter = Nothing
        MenuItem6 = Nothing
        Label4 = Nothing
        BarButtonItem9 = Nothing
        sec_baslik_firmakodu = Nothing
        sec_baslik_fisno = Nothing
        Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub analiz_musteri_karti()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_musteri_karti
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("FIRMAKODU")
        frm.musteriID = dr_baslik("FIRMANO")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_musteri_satislar()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_cari_faturalar_kapatma
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("FIRMAKODU")
        frm.musteriID = dr_baslik("FIRMANO")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_cari_ekstre
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("FIRMAKODU")
        frm.musteriID = dr_baslik("FIRMANO")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Function analiz_musteri_kayitno(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nMusteriID,0) AS IND FROM         tbMusteri " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        Dim lFisNo As Int64
        miktar = 0
        detay_miktar = 0
        For Each dr In ds_hareket.Tables(0).Rows
            miktar = miktar + dr("MIKTAR")
        Next
        For Each dr In ds_detay.Tables(0).Rows
            If dr("MIKTAR") > 0 Then
                detay_miktar = detay_miktar + dr("MIKTAR")
            ElseIf dr("MIKTAR") < 0 Then
                If lFisNo <> dr("FISNO") Then
                    detay_miktar = detay_miktar + dr("MIKTAR")
                End If
            End If
            If lFisNo <> dr("FISNO") Then
                lFisNo = dr("FISNO")
            End If
            'If lFisNo <> dr("FISNO") Then
            '    detay_miktar = detay_miktar + dr("MIKTAR")
            '    lFisNo = dr("FISNO")
            'End If
        Next
        Try
            If dr_baslik("FIRMANO") = 0 Then
                Label1.Text = "Yeni Paket Fiþi" & vbCrLf & "Lütfen Teslim Fiþi Bilgilerini Girin...!"
                Me.Label1.ForeColor = System.Drawing.Color.Red
                Label1.BackColor = System.Drawing.Color.White
            Else
                Dim fark As Decimal = detay_miktar - miktar
                If fark = 0 Then
                    Label1.Text = "Teslimat Bitti..!" & vbCrLf & "Yeni Belge Açýn"
                    Me.Label1.ForeColor = System.Drawing.Color.Black
                    Label1.BackColor = System.Drawing.Color.White
                ElseIf fark > 0 Then
                    Label1.Text = "Kalan Teslim Edilecek Ürün Sayýsý : " & vbCrLf & FormatNumber(Math.Abs(fark), 2)
                    Me.Label1.ForeColor = System.Drawing.Color.Blue
                    Label1.BackColor = System.Drawing.Color.Yellow
                ElseIf fark < 0 Then
                    Label1.Text = "Fazla Teslim Edilen Ürün Sayýsý : " & vbCrLf & FormatNumber(Math.Abs(fark), 2)
                    Me.Label1.ForeColor = System.Drawing.Color.Red
                    Label1.BackColor = System.Drawing.Color.Yellow
                End If
            End If
            Label2.Text = Now.ToLongTimeString
            Label3.Text = Now.ToLongDateString
            'Label1.Text = detay_miktar - miktar
            If Label1.Visible = False Then
                Label1.Visible = True
            Else
                Label1.Visible = False
            End If
        Catch ex As Exception
        End Try
        lFisNo = Nothing
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        toplam_hesapla()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        kaydet_yeni()
    End Sub
    Private Sub kaydet_yeni()
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Kaydedip Yeni Paket Teslimat Belgesi Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Timer1.Enabled = False
            toplam_hesapla()
            baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), dr_baslik("MIKTAR"), miktar, dr_baslik("FISKAYITTARIHI"), dr_baslik("bKilitli"))
            Timer1.Enabled = True
            baslik_yeni()
            Try
                loaded()
            Catch ex As Exception
                Me.Close()
            End Try
            Try
                dataload_hareket()
                txt_ara.Focus()
                txt_ara.SelectAll()
                Label4.Text = "Yeni Fiþ..."
                Label4.Refresh()
            Catch ex As Exception
            End Try
            Timer1.Enabled = True
            Vgrid_baslik.Focus()
            Vgrid_baslik.FocusedRow = rowIZAHAT
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE Barcode.nKisim IN (0, 1) AND ((Stok.sKodu = '" & kod & "') or (Barcode.sBarkod ='" & kod & "')) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS KAYIT FROM tbStok Stok INNER JOIN tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (Stok.sKodu = '" & kod & "') or (barkod.sBarkod ='" & kod & "') "
        'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     Stok.nStokID AS StokNo, Stok.sKodu AS StokKodu, Stok.sAciklama AS Malincinsi, Barcode.sBarkod AS Barcode FROM         tbStok Stok INNER JOIN                       tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & ""))
        'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sBeden, stok.sModel, barkod.sBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY, tbRenk.sRenkAdi, stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & ") AS T  ORDER BY sKodu"))
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sBeden, stok.sModel, barkod.sBarkod,  tbRenk.sRenkAdi, stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID AND (barkod.nKisim IN(0,1)) INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & ") AS T  ORDER BY sKodu"))
    End Sub
    Private Sub stok_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Stok Kartý Kontrolü Yapýlýyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_stok_kontrol(txt_ara.EditValue)
        If kontrol = 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Label4.Text = "Stok Kaydý Bulunamadý!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Stok Kaydý Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayýt Tek...")
            If dr_baslik("FIRMANO") <> 0 Then
                Timer1.Enabled = False
                toplam_hesapla()
                If miktar - detay_miktar = 0 Then
                    XtraMessageBox.Show(Sorgu_sDil("Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Label4.Text = "Teslimat Bitti veya Teslim Edilecek Ürün Yok..! Lütfen Yeni Teslim Belgesi Açýnýz..."
                    Label4.Refresh()
                    txt_ara.Focus()
                    txt_ara.SelectAll()
                Else
                    dataload_stok(muadilToMasterBarkode(Trim(txt_ara.Text)))
                    Label4.Text = "Stok Bilgisi Yükleniyor... "
                    Label4.Refresh()
                    satir_ekle_stok_tek(False)
                End If
                Timer1.Enabled = True
            ElseIf dr_baslik("FIRMANO") = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Teslim Bilgilerini Girmeniz Gerekmektedir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        ElseIf kontrol > 1 Then
            'MsgBox(Sorgu_sDil("Kayýt 1 den Fazla...")
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_SatirSil.Click
        satir_sil()
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
                        End If
                    End If
                End If
                Label4.Text = "Barkod Standardý Kontrolü Tamamlandý..."
                Label4.Refresh()
                If Len(txt_ara.Text) > 1 Then
                    If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM tbKoliDagilimi WHERE (sKoliKodu = '" & txt_ara.Text & "')") = 0 Then
                        stok_kontrol()
                    Else
                        satir_ekle_stok_koli(txt_ara.Text)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        'If Trim(txt_ara.Text) <> "" Then
        '    stok_kontrol()
        'End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If dr_baslik("FIRMANO") > 0 Then
            analiz_musteri_karti()
        End If
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        If dr_baslik("FIRMANO") > 0 Then
            analiz_musteri_satislar()
        End If
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        If dr_baslik("FIRMANO") > 0 Then
            analiz_musteri_hareket_ekstre()
        End If
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        stok_kontrol_teslim()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        analiz_envanter()
    End Sub
    Private Sub sec_baslik_fisno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_baslik_fisno.KeyDown
        If e.KeyCode = Keys.Space Then
            okut_barkod(False)
        End If
    End Sub
    Private Sub okut_barkod(ByVal musteri As Boolean)
        If dr_baslik("FIRMANO") = 0 Then
            Vgrid_baslik.UpdateFocusedRecord()
            Vgrid_baslik.CloseEditor()
            Dim deger = ""
            If musteri = True Then
                deger = InputBox("MüþteriNumarasýný Okutun", "MüþteriKartOkut", "").ToString
                If deger.ToString <> "" Then
                    dr_baslik("FIRMAKODU") = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Decimal)
                End If
                Vgrid_baslik.UpdateFocusedRecord()
                Vgrid_baslik.CloseEditor()
            Else
                'deger = InputBox("FiþNumarýsýný Okutun", "FiþOkut", "").ToString()
                deger = InputBox("FiþNumarasýný Okutun", "FiþOkut", "").ToString
                If Trim(deger.ToString) <> "" Then
                    dr_baslik("FISNO") = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Int64)
                End If
                Vgrid_baslik.UpdateFocusedRecord()
                Vgrid_baslik.CloseEditor()
                deger = ""
                deger = InputBox("MüþteriNumarasýný Okutun", "MüþteriKartOkut", "").ToString
                If Trim(deger.ToString) <> "" Then
                    dr_baslik("FIRMAKODU") = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Decimal)
                End If
                Vgrid_baslik.UpdateFocusedRecord()
                Vgrid_baslik.CloseEditor()
            End If
            Try
                'Vgrid_baslik.PostEditor()
                Vgrid_baslik.UpdateFocusedRecord()
                Vgrid_baslik.CloseEditor()
                If dr_baslik("FIRMANO") = 0 Then
                    dataload_hareket()
                    txt_ara.Focus()
                    txt_ara.SelectAll()
                    Label4.Text = "Yeni Fiþ..."
                    Label4.Refresh()
                End If
                'baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), dr_baslik("KOD1"), dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), dr_baslik("MIKTAR"), miktar)
            Catch ex As Exception
            End Try
            deger = Nothing
            'If musteri = False Then
            '    okut_barkod(True)
            'End If
        End If
    End Sub
    Private Sub sec_baslik_firmakodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_baslik_firmakodu.KeyDown
        If e.KeyCode = Keys.Space Then
            okut_barkod(True)
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If dr_baslik("IZAHAT") = "AS" Or dr_baslik("IZAHAT") = "VS" Then
            analiz_siparis()
        ElseIf dr_baslik("IZAHAT") = "FA" Or dr_baslik("IZAHAT") = "FS" Then
            fis_duzelt()
        End If
    End Sub
    Private Sub analiz_siparis()
        If dr_baslik("FIRMANO") > 0 And Trim(dr_baslik("IZAHAT")) = "AS" Or Trim(dr_baslik("IZAHAT")) = "VS" Then
            Dim frm As New frm_tbSiparis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.dteSiparisTarihi = dr_baslik("FISTARIHI")
            frm.lSiparisNo = dr_baslik("FISNO")
            frm.nFirmaID = dr_baslik("FIRMANO")
            'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
            frm.sSiparisiAlan = ""
            frm.sSiparisiVeren = ""
            If Trim(dr_baslik("IZAHAT")) = "AS" Then
                frm.nSiparisTipi = 1
            ElseIf Trim(dr_baslik("IZAHAT")) = "VS" Then
                frm.nSiparisTipi = 2
            End If
            frm.kullanici = kullanici
            frm.islemstatus = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
        End If
    End Sub
    Private Sub fis_duzelt()
        If dr_baslik("FIRMANO") > 0 And Trim(dr_baslik("IZAHAT")) = "AS" Or Trim(dr_baslik("IZAHAT")) = "VS" Then
            Dim nStokFisiID As Int64 = 0
            nStokFisiID = sorgu_nStokFisiID_lSayi(dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr_baslik("FISNO"), dr_baslik("FIRMANO"))
            If nStokFisiID > 0 Then
                Dim frm As New frm_fatura
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.lFisNo = dr_baslik("FISNO")
                frm.dteFisTarihi = dr_baslik("FISTARIHI")
                frm.sFisTipi = Trim(dr_baslik("IZAHAT"))
                frm.nFirmaID = dr_baslik("FIRMANO")
                If Trim(dr_baslik("IZAHAT")) = "FS" Then
                    frm.nGirisCikis = 3
                ElseIf Trim(dr_baslik("IZAHAT")) = "FA" Then
                    frm.nGirisCikis = 1
                End If
                frm.nStokFisiID = nStokFisiID
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    Try
                        frm.Show()
                    Catch ex As Exception
                    End Try
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Public Function sorgu_nStokFisiID_lSayi(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As Int64, ByVal nFirmaID As Int64) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        Dim kayitsayisi As Int64
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL((nStokFisiID), 0) AS nStokFisiID FROM         tbStokFisiMaster WHERE     dteFisTarihi = '" & dteFisTarihi & "' and lFisNo = " & lFisNo & " and nFirmaID = " & nFirmaID & " and sFisTipi = '" & sFisTipi & "'")
        kayitsayisi = 0
        kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        GridView1.ShowRibbonPrintPreview()
    End Sub
    Private Sub BarButtonItem7_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        GridView2.ShowRibbonPrintPreview()
    End Sub
End Class
