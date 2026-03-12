Imports DevExpress.XtraEditors
Public Class frm_stok_servis_bekleyen
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
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
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
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara_stok As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREFNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIREN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUCRET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGARANTILI As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERVIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILISATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERVISTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMATIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGETIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBASLIKACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colILETISIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents colSTOKSERVISTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_stok_islemtipi As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sec_stok_islemtipi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_servis_bekleyen))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.sec_konum_stok = New DevExpress.XtraEditors.ComboBoxEdit
        Me.sec_kriter_stok = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara_stok = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
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
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colREFNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGIREN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIKAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIRIM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUCRET = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGARANTILI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAKSESUAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSERINO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colARIZA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMARKA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMODEL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSATICI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSATISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSATISBELGENO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSATISBELGETIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSATISDEPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSERVIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYETKILISATICI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKAYITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSERVISTIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMATIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBELGETIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBASLIKACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colILETISIM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIADE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIPTAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSONUC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colADRES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEFON = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYETKILI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKSERVISTIPI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_stok_islemtipi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.ds_stok_islemtipi = New System.Data.DataSet
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_stok_islemtipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_stok_islemtipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 104)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_konum_stok)
        Me.GroupControl1.Controls.Add(Me.sec_kriter_stok)
        Me.GroupControl1.Controls.Add(Me.txt_ara_stok)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(456, 100)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "Ara"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(-4, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Stoklar:"
        '
        'sec_konum_stok
        '
        Me.sec_konum_stok.EditValue = "Kod"
        Me.sec_konum_stok.EnterMoveNextControl = True
        Me.sec_konum_stok.Location = New System.Drawing.Point(176, 45)
        Me.sec_konum_stok.Name = "sec_konum_stok"
        Me.sec_konum_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum_stok.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum_stok.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum_stok.TabIndex = 3
        '
        'sec_kriter_stok
        '
        Me.sec_kriter_stok.EditValue = "Baþlar"
        Me.sec_kriter_stok.EnterMoveNextControl = True
        Me.sec_kriter_stok.Location = New System.Drawing.Point(259, 45)
        Me.sec_kriter_stok.Name = "sec_kriter_stok"
        Me.sec_kriter_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_stok.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter_stok.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter_stok.TabIndex = 4
        '
        'txt_ara_stok
        '
        Me.txt_ara_stok.EnterMoveNextControl = True
        Me.txt_ara_stok.Location = New System.Drawing.Point(64, 45)
        Me.txt_ara_stok.Name = "txt_ara_stok"
        Me.txt_ara_stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara_stok.Properties.Appearance.Options.UseFont = True
        Me.txt_ara_stok.Properties.MaxLength = 15
        Me.txt_ara_stok.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara_stok.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(-4, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Hesaplar:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(272, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(-4, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(176, 23)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(64, 23)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(176, 67)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.ReadOnly = True
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 6
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(323, 67)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(259, 67)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.ReadOnly = True
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 7
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(64, 67)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Properties.ReadOnly = True
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(159, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(552, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(270, 100)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 100)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 358)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 104)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 254)
        Me.PanelControl3.TabIndex = 0
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_stok_islemtipi})
        Me.GridControl1.Size = New System.Drawing.Size(820, 250)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 5
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 6
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 10
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 11
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 12
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 13
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 14
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn32, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "EVRAKNO"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "REFNO"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "STOKNO"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "STOKKODU"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "MALINCINSI"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "BARCODE"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "GIREN"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "CIKAN"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "BIRIM"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "FIYAT"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "TUTAR"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "UCRET"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "GARANTILI"
        Me.DataColumn14.DataType = GetType(Boolean)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ACIKLAMA"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "AKSESUAR"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "SERINO"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ARIZA"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "MARKA"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "MODEL"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "SATICI"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "SATISTARIHI"
        Me.DataColumn22.DataType = GetType(Date)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "SATISBELGENO"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "SATISBELGETIPI"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sDepo"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "SATISDEPO"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "SERVIS"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "YETKILISATICI"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "STATUS"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "KAYITTARIHI"
        Me.DataColumn30.DataType = GetType(Date)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "SERVISTIPI"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "TARIH"
        Me.DataColumn33.DataType = GetType(Date)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "BELGENO"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "FIRMATIPI"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "FIRMANO"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "FIRMAKODU"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "FIRMAADI"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "BELGETIPI"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "BASLIKACIKLAMA"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "KOD1"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "KOD2"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "KOD3"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "KOD4"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "KOD5"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "ILETISIM"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "GIRIS"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "IADE"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "IPTAL"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "SONUC"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "ADRES"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "TELEFON"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "YETKILI"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "STOKSERVISTIPI"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colEVRAKNO, Me.colREFNO, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colBARCODE, Me.colGIREN, Me.colCIKAN, Me.colBIRIM, Me.colFIYAT, Me.colTUTAR, Me.colUCRET, Me.colGARANTILI, Me.colACIKLAMA, Me.colAKSESUAR, Me.colSERINO, Me.colARIZA, Me.colMARKA, Me.colMODEL, Me.colSATICI, Me.colSATISTARIHI, Me.colSATISBELGENO, Me.colSATISBELGETIPI, Me.colsDepo, Me.colSATISDEPO, Me.colSERVIS, Me.colYETKILISATICI, Me.colSTATUS, Me.colKAYITTARIHI, Me.colSERVISTIPI, Me.colTARIH, Me.colBELGENO, Me.colFIRMATIPI, Me.colFIRMANO, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colBELGETIPI, Me.colBASLIKACIKLAMA, Me.colKOD1, Me.colKOD2, Me.colKOD3, Me.colKOD4, Me.colKOD5, Me.colILETISIM, Me.colGIRIS, Me.colIADE, Me.colIPTAL, Me.colSONUC, Me.colADRES, Me.colTELEFON, Me.colYETKILI, Me.colSTOKSERVISTIPI})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(505, 245, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tutar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tutar", Nothing, "GecikmiþTutar:{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'colREFNO
        '
        Me.colREFNO.Caption = "RefNo"
        Me.colREFNO.FieldName = "REFNO"
        Me.colREFNO.Name = "colREFNO"
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
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 0
        Me.colSTOKKODU.Width = 74
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 1
        Me.colMALINCINSI.Width = 65
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barcode"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        '
        'colGIREN
        '
        Me.colGIREN.Caption = "Giren"
        Me.colGIREN.DisplayFormat.FormatString = "#,0.00"
        Me.colGIREN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGIREN.FieldName = "GIREN"
        Me.colGIREN.Name = "colGIREN"
        Me.colGIREN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIREN", "{0:#,0.##}")})
        Me.colGIREN.Visible = True
        Me.colGIREN.VisibleIndex = 2
        Me.colGIREN.Width = 47
        '
        'colCIKAN
        '
        Me.colCIKAN.Caption = "Çýkan"
        Me.colCIKAN.FieldName = "CIKAN"
        Me.colCIKAN.Name = "colCIKAN"
        '
        'colBIRIM
        '
        Me.colBIRIM.Caption = "Birim"
        Me.colBIRIM.FieldName = "BIRIM"
        Me.colBIRIM.Name = "colBIRIM"
        Me.colBIRIM.Visible = True
        Me.colBIRIM.VisibleIndex = 3
        Me.colBIRIM.Width = 47
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.FieldName = "FIYAT"
        Me.colFIYAT.Name = "colFIYAT"
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        '
        'colUCRET
        '
        Me.colUCRET.Caption = "Ücret"
        Me.colUCRET.FieldName = "UCRET"
        Me.colUCRET.Name = "colUCRET"
        Me.colUCRET.Visible = True
        Me.colUCRET.VisibleIndex = 4
        Me.colUCRET.Width = 47
        '
        'colGARANTILI
        '
        Me.colGARANTILI.Caption = "Garantili?"
        Me.colGARANTILI.FieldName = "GARANTILI"
        Me.colGARANTILI.Name = "colGARANTILI"
        Me.colGARANTILI.Visible = True
        Me.colGARANTILI.VisibleIndex = 5
        Me.colGARANTILI.Width = 47
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Þikayet..."
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 6
        Me.colACIKLAMA.Width = 47
        '
        'colAKSESUAR
        '
        Me.colAKSESUAR.Caption = "Aksesuar"
        Me.colAKSESUAR.FieldName = "AKSESUAR"
        Me.colAKSESUAR.Name = "colAKSESUAR"
        '
        'colSERINO
        '
        Me.colSERINO.Caption = "seriNo"
        Me.colSERINO.FieldName = "SERINO"
        Me.colSERINO.Name = "colSERINO"
        '
        'colARIZA
        '
        Me.colARIZA.Caption = "Arýza"
        Me.colARIZA.FieldName = "ARIZA"
        Me.colARIZA.Name = "colARIZA"
        Me.colARIZA.Visible = True
        Me.colARIZA.VisibleIndex = 7
        Me.colARIZA.Width = 47
        '
        'colMARKA
        '
        Me.colMARKA.Caption = "Marka"
        Me.colMARKA.FieldName = "MARKA"
        Me.colMARKA.Name = "colMARKA"
        '
        'colMODEL
        '
        Me.colMODEL.Caption = "Model"
        Me.colMODEL.FieldName = "MODEL"
        Me.colMODEL.Name = "colMODEL"
        '
        'colSATICI
        '
        Me.colSATICI.Caption = "YetkiliSatýcý"
        Me.colSATICI.FieldName = "SATICI"
        Me.colSATICI.Name = "colSATICI"
        '
        'colSATISTARIHI
        '
        Me.colSATISTARIHI.Caption = "FaturaTarihi"
        Me.colSATISTARIHI.FieldName = "SATISTARIHI"
        Me.colSATISTARIHI.Name = "colSATISTARIHI"
        '
        'colSATISBELGENO
        '
        Me.colSATISBELGENO.Caption = "FaturaNo"
        Me.colSATISBELGENO.FieldName = "SATISBELGENO"
        Me.colSATISBELGENO.Name = "colSATISBELGENO"
        '
        'colSATISBELGETIPI
        '
        Me.colSATISBELGETIPI.Caption = "FaturaTipi"
        Me.colSATISBELGETIPI.FieldName = "SATISBELGETIPI"
        Me.colSATISBELGETIPI.Name = "colSATISBELGETIPI"
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colSATISDEPO
        '
        Me.colSATISDEPO.Caption = "FaturaDepo"
        Me.colSATISDEPO.FieldName = "SATISDEPO"
        Me.colSATISDEPO.Name = "colSATISDEPO"
        '
        'colSERVIS
        '
        Me.colSERVIS.Caption = "YetkiliServis"
        Me.colSERVIS.FieldName = "SERVIS"
        Me.colSERVIS.Name = "colSERVIS"
        Me.colSERVIS.Visible = True
        Me.colSERVIS.VisibleIndex = 8
        Me.colSERVIS.Width = 47
        '
        'colYETKILISATICI
        '
        Me.colYETKILISATICI.Caption = "YetkiliSatýcý"
        Me.colYETKILISATICI.FieldName = "YETKILISATICI"
        Me.colYETKILISATICI.Name = "colYETKILISATICI"
        Me.colYETKILISATICI.Width = 47
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Durum"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        '
        'colKAYITTARIHI
        '
        Me.colKAYITTARIHI.Caption = "Kayýt Tarihi"
        Me.colKAYITTARIHI.FieldName = "KAYITTARIHI"
        Me.colKAYITTARIHI.Name = "colKAYITTARIHI"
        '
        'colSERVISTIPI
        '
        Me.colSERVISTIPI.Caption = "Kýrýk?"
        Me.colSERVISTIPI.FieldName = "SERVISTIPI"
        Me.colSERVISTIPI.Name = "colSERVISTIPI"
        Me.colSERVISTIPI.Visible = True
        Me.colSERVISTIPI.VisibleIndex = 9
        Me.colSERVISTIPI.Width = 47
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "ServisTarihi"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 10
        Me.colTARIH.Width = 47
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "ServisNo"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Width = 47
        '
        'colFIRMATIPI
        '
        Me.colFIRMATIPI.Caption = "Müþteri?"
        Me.colFIRMATIPI.FieldName = "FIRMATIPI"
        Me.colFIRMATIPI.Name = "colFIRMATIPI"
        '
        'colFIRMANO
        '
        Me.colFIRMANO.Caption = "Hesap No"
        Me.colFIRMANO.FieldName = "FIRMANO"
        Me.colFIRMANO.Name = "colFIRMANO"
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Hesap Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.Width = 47
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "HesapAdý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 11
        Me.colFIRMAADI.Width = 47
        '
        'colBELGETIPI
        '
        Me.colBELGETIPI.Caption = "ServisTipi"
        Me.colBELGETIPI.FieldName = "BELGETIPI"
        Me.colBELGETIPI.Name = "colBELGETIPI"
        '
        'colBASLIKACIKLAMA
        '
        Me.colBASLIKACIKLAMA.Caption = "ServisAçýklama"
        Me.colBASLIKACIKLAMA.FieldName = "BASLIKACIKLAMA"
        Me.colBASLIKACIKLAMA.Name = "colBASLIKACIKLAMA"
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
        'colILETISIM
        '
        Me.colILETISIM.Caption = "Ýletiþim"
        Me.colILETISIM.FieldName = "ILETISIM"
        Me.colILETISIM.Name = "colILETISIM"
        '
        'colGIRIS
        '
        Me.colGIRIS.Caption = "Giriþ?"
        Me.colGIRIS.FieldName = "GIRIS"
        Me.colGIRIS.Name = "colGIRIS"
        '
        'colIADE
        '
        Me.colIADE.Caption = "Ýade?"
        Me.colIADE.FieldName = "IADE"
        Me.colIADE.Name = "colIADE"
        '
        'colIPTAL
        '
        Me.colIPTAL.Caption = "Ýptal?"
        Me.colIPTAL.FieldName = "IPTAL"
        Me.colIPTAL.Name = "colIPTAL"
        '
        'colSONUC
        '
        Me.colSONUC.Caption = "ServisSonucu"
        Me.colSONUC.FieldName = "SONUC"
        Me.colSONUC.Name = "colSONUC"
        '
        'colADRES
        '
        Me.colADRES.Caption = "Adres"
        Me.colADRES.FieldName = "ADRES"
        Me.colADRES.Name = "colADRES"
        '
        'colTELEFON
        '
        Me.colTELEFON.Caption = "Telefon"
        Me.colTELEFON.FieldName = "TELEFON"
        Me.colTELEFON.Name = "colTELEFON"
        '
        'colYETKILI
        '
        Me.colYETKILI.Caption = "YetkiliKiþi"
        Me.colYETKILI.FieldName = "YETKILI"
        Me.colYETKILI.Name = "colYETKILI"
        '
        'colSTOKSERVISTIPI
        '
        Me.colSTOKSERVISTIPI.Caption = "StokDurumu"
        Me.colSTOKSERVISTIPI.ColumnEdit = Me.sec_stok_islemtipi
        Me.colSTOKSERVISTIPI.FieldName = "STOKISLEMTIPI"
        Me.colSTOKSERVISTIPI.Name = "colSTOKSERVISTIPI"
        Me.colSTOKSERVISTIPI.Visible = True
        Me.colSTOKSERVISTIPI.VisibleIndex = 12
        Me.colSTOKSERVISTIPI.Width = 66
        '
        'sec_stok_islemtipi
        '
        Me.sec_stok_islemtipi.AutoHeight = False
        Me.sec_stok_islemtipi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_stok_islemtipi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_stok_islemtipi.DataSource = Me.DataTable3
        Me.sec_stok_islemtipi.DisplayMember = "ACIKLAMA"
        Me.sec_stok_islemtipi.Name = "sec_stok_islemtipi"
        Me.sec_stok_islemtipi.ValueMember = "STOKISLEMTIPI"
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn75, Me.DataColumn76})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "STOKISLEMTIPI"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "ACIKLAMA"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Ödemesi Geciken Müþteri Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'ds_stok_islemtipi
        '
        Me.ds_stok_islemtipi.DataSetName = "NewDataSet"
        Me.ds_stok_islemtipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_stok_islemtipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Excel"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Text"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Mail"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 406)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 406)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 406)
        '
        'frm_stok_servis_bekleyen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_servis_bekleyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Servis Kontrol "
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_stok_islemtipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_stok_islemtipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public islemstatus As Boolean = False
    Public firmatipi As Boolean = False
    Public servis As Boolean = False
    Public serviste As Boolean = False
    Public kontrol As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        stok_islem_tipleri()
        DateEdit1.EditValue = "01/01/" + Today.Year.ToString
        DateEdit2.EditValue = "31/12/" + Today.Year.ToString
        DateEdit1.Focus()
        DateEdit1.Select()
        If txt_ara.EditValue <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        If txt_ara_stok.EditValue <> "" Then
        Else
            txt_ara_stok.EditValue = ""
        End If
        'dataload()
        If kontrol = True Then
            Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
            Label2.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text)
            Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Private Sub stok_islem_tipleri()
        Dim dr1 As DataRow = ds_stok_islemtipi.Tables(0).NewRow
        dr1(0) = 0
        dr1(1) = "Bekliyor"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 1
        dr1(1) = "Serviste"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 2
        dr1(1) = "ServistenGeldi"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 3
        dr1(1) = "Onarýldý"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 4
        dr1(1) = "Firmada"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 5
        dr1(1) = "FirmadanGeldi"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 9
        dr1(1) = "TeslimEdildi"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 10
        dr1(1) = "Ýptal"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Satýþlar" & vbCrLf
        'kriter += "Limit = " & txt_altlimit.EditValue & "-" & txt_ustlimit.EditValue
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String) As DataSet
        Dim kriter As String = ""
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                If firmatipi = False Then
                    kriter += " AND( tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                Else
                    kriter += " AND( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            ElseIf sec_konum.Text = "Adý" Then
                If firmatipi = False Then
                    kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
                Else
                    kriter += " AND ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvTelefonu" Then
                kriter += " AND ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþTelefonu" Then
                kriter += " AND ( tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Gsm" Then
                kriter += " AND ( tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "DoðumYeri" Then
                kriter += " AND ( tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "1.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "2.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý+Soyadý" Then
                Dim adi As String = ""
                Dim soyadi As String = ""
                Dim x
                If CStr(ara.ToString) <> "" Then
                    x = (ara).IndexOf(" ", 1, (ara.Length - 1))
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
                If adi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
                End If
            Else
            End If
        End If
        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
                'ElseIf konum_stok = "Soyadý" Then
                '   kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Barkod" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID  FROM         tbStok INNER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If servis = False Then
            If kontrol = False Then
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE BASLIK.FIRMAKODU = '" & txt_ara.Text & "' and BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') T WHERE STOKISLEMTIPI IN(0,2,3,5) ")
            Else
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE HAREKET.STOKKODU = '" & txt_ara_stok.Text & "' and BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND BASLIK.FIRMATIPI=1) T WHERE STOKISLEMTIPI IN(0,2,4) ")
            End If
        Else
            If serviste = True Then
                If firmatipi = True Then
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE HAREKET.SERVIS = '" & txt_ara.Text & "' and BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') T WHERE STOKISLEMTIPI IN(1) ")
                Else
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE HAREKET.YETKILISATICI = '" & txt_ara.Text & "' and BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') T WHERE STOKISLEMTIPI IN(4) ")
                End If
            Else
                If firmatipi = True Then
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE HAREKET.SERVIS = '" & txt_ara.Text & "' and BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') T WHERE STOKISLEMTIPI IN(0,2,5) ")
                Else
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE HAREKET.YETKILISATICI = '" & txt_ara.Text & "' and BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') T WHERE STOKISLEMTIPI IN(0,2,5) ")
                End If
                'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE HAREKET.SERVIS = '" & txt_ara.Text & "' and BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') T WHERE STOKISLEMTIPI IN(0,2) ")
            End If
        End If
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
    Public Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        DataSet1 = stok(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub stok_satis_detay()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nAlisverisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
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
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
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
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
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
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        'Dim dr As DataRow
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'lbl_istihbarat.Text = dr("ISTIHBARAT")
        'dr = Nothing
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
        'Me.Close()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            'Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
End Class
