Imports DevExpress.XtraEditors
Public Class frm_personel_takip_liste
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Dataset1 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRISSAAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKISSAAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAGAZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVARDIYA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILIKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERSONELKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERSONEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEFKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAZERET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECCIKIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_kasiyer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_personel As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_vardiya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSef As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_dteSaat As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents sec_sDepo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colYEVMIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMESAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMESAIUCRETI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_lTutar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents colEKLENTI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKLENTI2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKLENTI3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKLENTI4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKLENTI5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKESINTI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKESINTI2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKESINTI3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKESINTI4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKESINTI5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents colDEPARTMAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_DEPARTMAN As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem8 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_personel_takip_liste))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_personel = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_kasiyer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.Dataset1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRISSAAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_dteSaat = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.colCIKISSAAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAGAZA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVARDIYA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_vardiya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILIKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERSONELKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERSONEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEFKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSef = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMAZERET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECCIKIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYEVMIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_lTutar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colMESAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMESAIUCRETI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKLENTI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKLENTI2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKLENTI3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKLENTI4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKLENTI5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKESINTI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKESINTI2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKESINTI3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKESINTI4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKESINTI5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPARTMAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_DEPARTMAN = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.sec_sDepo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem8 = New DevExpress.XtraBars.BarSubItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_personel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_dteSaat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_vardiya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_lTutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_DEPARTMAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDepo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 32)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1649, 168)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckEdit3)
        Me.GroupControl1.Controls.Add(Me.CheckEdit2)
        Me.GroupControl1.Controls.Add(Me.CheckEdit1)
        Me.GroupControl1.Controls.Add(Me.txt_personel)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.txt_kasiyer)
        Me.GroupControl1.Controls.Add(Me.txt_kod)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(154, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(576, 164)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Ara"
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(307, 124)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Çýktý?"
        Me.CheckEdit3.Size = New System.Drawing.Size(103, 24)
        Me.CheckEdit3.TabIndex = 62
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(205, 124)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Gecikti?"
        Me.CheckEdit2.Size = New System.Drawing.Size(102, 24)
        Me.CheckEdit2.TabIndex = 61
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(125, 124)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Ýzinli?"
        Me.CheckEdit1.Size = New System.Drawing.Size(77, 24)
        Me.CheckEdit1.TabIndex = 60
        '
        'txt_personel
        '
        Me.txt_personel.EnterMoveNextControl = True
        Me.txt_personel.Location = New System.Drawing.Point(128, 96)
        Me.txt_personel.Name = "txt_personel"
        Me.txt_personel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_personel.Size = New System.Drawing.Size(307, 26)
        Me.txt_personel.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Personel:"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(443, 123)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(120, 28)
        Me.SimpleButton5.TabIndex = 57
        Me.SimpleButton5.Text = "&Listele"
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(230, 39)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(205, 26)
        Me.txt_kasiyer.TabIndex = 56
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(128, 39)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(107, 26)
        Me.txt_kod.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(26, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Yetkili:"
        '
        'Label6
        '
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(435, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(26, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(280, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 19)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(307, 67)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(128, 26)
        Me.DateEdit2.TabIndex = 50
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(128, 67)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.ReadOnly = True
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(144, 26)
        Me.DateEdit1.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(154, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Personel Giriþ Çýkýþ Listesi Aþaðýdadýr."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton7)
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 940)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1649, 61)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = Global.business_smart.My.Resources.Resources.replace2
        Me.SimpleButton7.Location = New System.Drawing.Point(373, 11)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton7.TabIndex = 6
        Me.SimpleButton7.Text = "&Toplamlar"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = Global.business_smart.My.Resources.Resources.nav_up_red
        Me.SimpleButton6.Location = New System.Drawing.Point(253, 11)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton6.TabIndex = 5
        Me.SimpleButton6.Text = "&Çýkýþ"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = Global.business_smart.My.Resources.Resources.nav_down_green
        Me.SimpleButton4.Location = New System.Drawing.Point(133, 11)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "&Giriþ"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(682, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(13, 11)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Ara F3"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1513, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1393, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 200)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1649, 740)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1645, 736)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1643, 697)
        Me.XtraTabPage1.Text = "Giriþ/Çýkýþlar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.Dataset1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk, Me.sec_vardiya, Me.sec_sSef, Me.sec_dteSaat, Me.sec_sDepo, Me.sec_lTutar, Me.sec_DEPARTMAN})
        Me.GridControl1.Size = New System.Drawing.Size(1643, 697)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Dataset1
        '
        Me.Dataset1.DataSetName = "NewDataSet"
        Me.Dataset1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.Dataset1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn6, Me.DataColumn5, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.DataTable2.TableName = "Table1"
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
        Me.DataColumn3.ColumnName = "BELGENO"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "GIRISSAAT"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CIKISSAAT"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "SURE"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "MAGAZA"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "VARDIYA"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "IZAHAT"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "YETKILIKODU"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "YETKILI"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "PERSONELKODU"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "PERSONEL"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "SEFKODU"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "SEF"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "MAZERET"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "ACIKLAMA"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "GIRIS"
        Me.DataColumn18.DataType = GetType(Date)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "GECGIRIS"
        Me.DataColumn19.DataType = GetType(Boolean)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "CIKIS"
        Me.DataColumn20.DataType = GetType(Date)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "GECCIKIS"
        Me.DataColumn21.DataType = GetType(Boolean)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "STATUS"
        Me.DataColumn22.DataType = GetType(Boolean)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colTARIH, Me.colBELGENO, Me.colGIRISSAAT, Me.colCIKISSAAT, Me.colSURE, Me.colMAGAZA, Me.colVARDIYA, Me.colIZAHAT, Me.colYETKILIKODU, Me.colYETKILI, Me.colPERSONELKODU, Me.colPERSONEL, Me.colSEFKODU, Me.colMAZERET, Me.colACIKLAMA, Me.colGIRIS, Me.colGECGIRIS, Me.colCIKIS, Me.colGECCIKIS, Me.colSTATUS, Me.colYEVMIYE, Me.colMESAI, Me.colMESAIUCRETI, Me.colEKLENTI1, Me.colEKLENTI2, Me.colEKLENTI3, Me.colEKLENTI4, Me.colEKLENTI5, Me.colKESINTI1, Me.colKESINTI2, Me.colKESINTI3, Me.colKESINTI4, Me.colKESINTI5, Me.colNET, Me.colDEPARTMAN})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(364, 294, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YEVMIYE", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MESAI", Nothing, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MESAIUCRETI", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI2", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI3", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI4", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI5", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI2", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI3", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI4", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI5", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", Me.colTARIH, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YEVMIYE", Me.colYEVMIYE, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MESAI", Me.colMESAI, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "MESAIUCRETI", Me.colMESAIUCRETI, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI1", Me.colEKLENTI1, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI2", Me.colKESINTI2, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI3", Me.colEKLENTI3, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI4", Me.colEKLENTI4, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "EKLENTI5", Me.colEKLENTI5, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI1", Me.colKESINTI1, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI2", Me.colKESINTI2, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI3", Me.colKESINTI3, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI4", Me.colKESINTI4, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI5", Me.colKESINTI5, "{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.OptionsColumn.ReadOnly = True
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.OptionsColumn.AllowEdit = False
        Me.colTARIH.OptionsColumn.ReadOnly = True
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 32
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.OptionsColumn.AllowEdit = False
        Me.colBELGENO.OptionsColumn.ReadOnly = True
        Me.colBELGENO.Width = 42
        '
        'colGIRISSAAT
        '
        Me.colGIRISSAAT.Caption = "Açýlýþ"
        Me.colGIRISSAAT.ColumnEdit = Me.sec_dteSaat
        Me.colGIRISSAAT.DisplayFormat.FormatString = "HH:mm"
        Me.colGIRISSAAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGIRISSAAT.FieldName = "GIRISSAAT"
        Me.colGIRISSAAT.Name = "colGIRISSAAT"
        Me.colGIRISSAAT.Visible = True
        Me.colGIRISSAAT.VisibleIndex = 1
        Me.colGIRISSAAT.Width = 42
        '
        'sec_dteSaat
        '
        Me.sec_dteSaat.AutoHeight = False
        Me.sec_dteSaat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_dteSaat.Name = "sec_dteSaat"
        '
        'colCIKISSAAT
        '
        Me.colCIKISSAAT.Caption = "Kapanýþ"
        Me.colCIKISSAAT.ColumnEdit = Me.sec_dteSaat
        Me.colCIKISSAAT.DisplayFormat.FormatString = "HH:mm"
        Me.colCIKISSAAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCIKISSAAT.FieldName = "CIKISSAAT"
        Me.colCIKISSAAT.Name = "colCIKISSAAT"
        Me.colCIKISSAAT.Visible = True
        Me.colCIKISSAAT.VisibleIndex = 2
        Me.colCIKISSAAT.Width = 42
        '
        'colSURE
        '
        Me.colSURE.Caption = "Süre"
        Me.colSURE.FieldName = "SURE"
        Me.colSURE.Name = "colSURE"
        Me.colSURE.Width = 42
        '
        'colMAGAZA
        '
        Me.colMAGAZA.Caption = "Maðaza"
        Me.colMAGAZA.FieldName = "MAGAZA"
        Me.colMAGAZA.Name = "colMAGAZA"
        '
        'colVARDIYA
        '
        Me.colVARDIYA.Caption = "Vardiya"
        Me.colVARDIYA.ColumnEdit = Me.sec_vardiya
        Me.colVARDIYA.FieldName = "VARDIYA"
        Me.colVARDIYA.Name = "colVARDIYA"
        '
        'sec_vardiya
        '
        Me.sec_vardiya.AutoHeight = False
        Me.sec_vardiya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_vardiya.DisplayMember = "GRUPADI"
        Me.sec_vardiya.Name = "sec_vardiya"
        Me.sec_vardiya.ValueMember = "IND"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Ýzahat"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.OptionsColumn.ReadOnly = True
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 3
        Me.colIZAHAT.Width = 42
        '
        'colYETKILIKODU
        '
        Me.colYETKILIKODU.Caption = "YetkiliKodu"
        Me.colYETKILIKODU.FieldName = "YETKILIKODU"
        Me.colYETKILIKODU.Name = "colYETKILIKODU"
        Me.colYETKILIKODU.OptionsColumn.ReadOnly = True
        '
        'colYETKILI
        '
        Me.colYETKILI.Caption = "Yetkili"
        Me.colYETKILI.FieldName = "YETKILI"
        Me.colYETKILI.Name = "colYETKILI"
        Me.colYETKILI.OptionsColumn.ReadOnly = True
        Me.colYETKILI.Visible = True
        Me.colYETKILI.VisibleIndex = 4
        Me.colYETKILI.Width = 42
        '
        'colPERSONELKODU
        '
        Me.colPERSONELKODU.Caption = "PersonelKodu"
        Me.colPERSONELKODU.FieldName = "PERSONELKODU"
        Me.colPERSONELKODU.Name = "colPERSONELKODU"
        Me.colPERSONELKODU.OptionsColumn.ReadOnly = True
        '
        'colPERSONEL
        '
        Me.colPERSONEL.Caption = "Personel"
        Me.colPERSONEL.FieldName = "PERSONEL"
        Me.colPERSONEL.Name = "colPERSONEL"
        Me.colPERSONEL.OptionsColumn.ReadOnly = True
        Me.colPERSONEL.Visible = True
        Me.colPERSONEL.VisibleIndex = 5
        Me.colPERSONEL.Width = 42
        '
        'colSEFKODU
        '
        Me.colSEFKODU.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSEFKODU.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSEFKODU.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colSEFKODU.AppearanceCell.Options.UseBackColor = True
        Me.colSEFKODU.AppearanceCell.Options.UseForeColor = True
        Me.colSEFKODU.Caption = "SefKodu"
        Me.colSEFKODU.ColumnEdit = Me.sec_sSef
        Me.colSEFKODU.FieldName = "SEFKODU"
        Me.colSEFKODU.Name = "colSEFKODU"
        Me.colSEFKODU.Visible = True
        Me.colSEFKODU.VisibleIndex = 7
        '
        'sec_sSef
        '
        Me.sec_sSef.AutoHeight = False
        Me.sec_sSef.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSef.DisplayMember = "PERSONELADI"
        Me.sec_sSef.Name = "sec_sSef"
        Me.sec_sSef.NullText = "[Sef]"
        Me.sec_sSef.ValueMember = "PERSONELKODU"
        '
        'colMAZERET
        '
        Me.colMAZERET.Caption = "Maazeret"
        Me.colMAZERET.FieldName = "MAZERET"
        Me.colMAZERET.Name = "colMAZERET"
        Me.colMAZERET.Visible = True
        Me.colMAZERET.VisibleIndex = 6
        Me.colMAZERET.Width = 42
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 8
        Me.colACIKLAMA.Width = 42
        '
        'colGIRIS
        '
        Me.colGIRIS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGIRIS.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGIRIS.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.colGIRIS.AppearanceCell.Options.UseBackColor = True
        Me.colGIRIS.AppearanceCell.Options.UseForeColor = True
        Me.colGIRIS.Caption = "GiriþSaati"
        Me.colGIRIS.ColumnEdit = Me.sec_dteSaat
        Me.colGIRIS.DisplayFormat.FormatString = "HH:mm"
        Me.colGIRIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGIRIS.FieldName = "GIRIS"
        Me.colGIRIS.Name = "colGIRIS"
        Me.colGIRIS.Visible = True
        Me.colGIRIS.VisibleIndex = 9
        Me.colGIRIS.Width = 42
        '
        'colGECGIRIS
        '
        Me.colGECGIRIS.Caption = "GeçGiriþ?"
        Me.colGECGIRIS.FieldName = "GECGIRIS"
        Me.colGECGIRIS.Name = "colGECGIRIS"
        Me.colGECGIRIS.OptionsColumn.ReadOnly = True
        Me.colGECGIRIS.Width = 42
        '
        'colCIKIS
        '
        Me.colCIKIS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCIKIS.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCIKIS.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.colCIKIS.AppearanceCell.Options.UseBackColor = True
        Me.colCIKIS.AppearanceCell.Options.UseForeColor = True
        Me.colCIKIS.Caption = "ÇýkýþSaati"
        Me.colCIKIS.ColumnEdit = Me.sec_dteSaat
        Me.colCIKIS.DisplayFormat.FormatString = "HH:mm"
        Me.colCIKIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCIKIS.FieldName = "CIKIS"
        Me.colCIKIS.Name = "colCIKIS"
        Me.colCIKIS.Visible = True
        Me.colCIKIS.VisibleIndex = 10
        Me.colCIKIS.Width = 42
        '
        'colGECCIKIS
        '
        Me.colGECCIKIS.Caption = "GeçÇýkýþ?"
        Me.colGECCIKIS.FieldName = "GECCIKIS"
        Me.colGECCIKIS.Name = "colGECCIKIS"
        Me.colGECCIKIS.OptionsColumn.ReadOnly = True
        Me.colGECCIKIS.Width = 55
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Çýktý?"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        Me.colSTATUS.OptionsColumn.ReadOnly = True
        Me.colSTATUS.Visible = True
        Me.colSTATUS.VisibleIndex = 11
        Me.colSTATUS.Width = 48
        '
        'colYEVMIYE
        '
        Me.colYEVMIYE.Caption = "Yevmiye"
        Me.colYEVMIYE.ColumnEdit = Me.sec_lTutar
        Me.colYEVMIYE.FieldName = "YEVMIYE"
        Me.colYEVMIYE.Name = "colYEVMIYE"
        Me.colYEVMIYE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YEVMIYE", "{0:#,0.00##}")})
        '
        'sec_lTutar
        '
        Me.sec_lTutar.AutoHeight = False
        Me.sec_lTutar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_lTutar.DisplayFormat.FormatString = "#,0.00"
        Me.sec_lTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lTutar.EditFormat.FormatString = "#,0.00"
        Me.sec_lTutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lTutar.Name = "sec_lTutar"
        '
        'colMESAI
        '
        Me.colMESAI.Caption = "Mesai"
        Me.colMESAI.ColumnEdit = Me.sec_lTutar
        Me.colMESAI.FieldName = "MESAI"
        Me.colMESAI.Name = "colMESAI"
        Me.colMESAI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MESAI", "{0:#,0.00##}")})
        '
        'colMESAIUCRETI
        '
        Me.colMESAIUCRETI.Caption = "Mesai Ücreti"
        Me.colMESAIUCRETI.ColumnEdit = Me.sec_lTutar
        Me.colMESAIUCRETI.FieldName = "MESAIUCRETI"
        Me.colMESAIUCRETI.Name = "colMESAIUCRETI"
        Me.colMESAIUCRETI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MESAIUCRETI", "{0:#,0.00##}")})
        '
        'colEKLENTI1
        '
        Me.colEKLENTI1.Caption = "Çavuþluk"
        Me.colEKLENTI1.ColumnEdit = Me.sec_lTutar
        Me.colEKLENTI1.DisplayFormat.FormatString = "#,0.00"
        Me.colEKLENTI1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKLENTI1.FieldName = "EKLENTI1"
        Me.colEKLENTI1.Name = "colEKLENTI1"
        Me.colEKLENTI1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI1", "{0:#,0.00}")})
        '
        'colEKLENTI2
        '
        Me.colEKLENTI2.Caption = "Servis Ücreti"
        Me.colEKLENTI2.ColumnEdit = Me.sec_lTutar
        Me.colEKLENTI2.DisplayFormat.FormatString = "#,0.00"
        Me.colEKLENTI2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKLENTI2.FieldName = "EKLENTI2"
        Me.colEKLENTI2.Name = "colEKLENTI2"
        Me.colEKLENTI2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI2", "{0:#,0.00}")})
        '
        'colEKLENTI3
        '
        Me.colEKLENTI3.Caption = "Eklenti 4"
        Me.colEKLENTI3.ColumnEdit = Me.sec_lTutar
        Me.colEKLENTI3.DisplayFormat.FormatString = "#,0.00"
        Me.colEKLENTI3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKLENTI3.FieldName = "EKLENTI3"
        Me.colEKLENTI3.Name = "colEKLENTI3"
        Me.colEKLENTI3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI3", "{0:#,0.00}")})
        '
        'colEKLENTI4
        '
        Me.colEKLENTI4.Caption = "Eklenti 4"
        Me.colEKLENTI4.ColumnEdit = Me.sec_lTutar
        Me.colEKLENTI4.DisplayFormat.FormatString = "#,0.00"
        Me.colEKLENTI4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKLENTI4.FieldName = "EKLENTI4"
        Me.colEKLENTI4.Name = "colEKLENTI4"
        Me.colEKLENTI4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI4", "{0:#,0.00}")})
        '
        'colEKLENTI5
        '
        Me.colEKLENTI5.Caption = "Eklenti 5"
        Me.colEKLENTI5.ColumnEdit = Me.sec_lTutar
        Me.colEKLENTI5.DisplayFormat.FormatString = "#,0.00"
        Me.colEKLENTI5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKLENTI5.FieldName = "EKLENTI5"
        Me.colEKLENTI5.Name = "colEKLENTI5"
        Me.colEKLENTI5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKLENTI5", "{0:#,0.00}")})
        '
        'colKESINTI1
        '
        Me.colKESINTI1.Caption = "Kesinti 1"
        Me.colKESINTI1.ColumnEdit = Me.sec_lTutar
        Me.colKESINTI1.DisplayFormat.FormatString = "#,0.00"
        Me.colKESINTI1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKESINTI1.FieldName = "KESINTI1"
        Me.colKESINTI1.Name = "colKESINTI1"
        Me.colKESINTI1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI1", "{0:#,0.00}")})
        '
        'colKESINTI2
        '
        Me.colKESINTI2.Caption = "Kesinti 2"
        Me.colKESINTI2.ColumnEdit = Me.sec_lTutar
        Me.colKESINTI2.DisplayFormat.FormatString = "#,0.00"
        Me.colKESINTI2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKESINTI2.FieldName = "KESINTI2"
        Me.colKESINTI2.Name = "colKESINTI2"
        Me.colKESINTI2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI2", "{0:#,0.00}")})
        '
        'colKESINTI3
        '
        Me.colKESINTI3.Caption = "Kesinti 3"
        Me.colKESINTI3.ColumnEdit = Me.sec_lTutar
        Me.colKESINTI3.DisplayFormat.FormatString = "#,0.00"
        Me.colKESINTI3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKESINTI3.FieldName = "KESINTI3"
        Me.colKESINTI3.Name = "colKESINTI3"
        Me.colKESINTI3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI3", "{0:#,0.00}")})
        '
        'colKESINTI4
        '
        Me.colKESINTI4.Caption = "Kesinti 4"
        Me.colKESINTI4.ColumnEdit = Me.sec_lTutar
        Me.colKESINTI4.DisplayFormat.FormatString = "#,0.00"
        Me.colKESINTI4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKESINTI4.FieldName = "KESINTI4"
        Me.colKESINTI4.Name = "colKESINTI4"
        Me.colKESINTI4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI4", "{0:#,0.00}")})
        '
        'colKESINTI5
        '
        Me.colKESINTI5.Caption = "Kesinti 5"
        Me.colKESINTI5.ColumnEdit = Me.sec_lTutar
        Me.colKESINTI5.DisplayFormat.FormatString = "#,0.00"
        Me.colKESINTI5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKESINTI5.FieldName = "KESINTI5"
        Me.colKESINTI5.Name = "colKESINTI5"
        Me.colKESINTI5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KESINTI5", "{0:#,0.00}")})
        '
        'colNET
        '
        Me.colNET.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNET.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.colNET.AppearanceCell.Options.UseFont = True
        Me.colNET.AppearanceCell.Options.UseForeColor = True
        Me.colNET.Caption = "Net"
        Me.colNET.DisplayFormat.FormatString = "#,0.00"
        Me.colNET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNET.FieldName = "NET"
        Me.colNET.Name = "colNET"
        Me.colNET.OptionsColumn.ReadOnly = True
        Me.colNET.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NET", "{0:#,0.00}")})
        '
        'colDEPARTMAN
        '
        Me.colDEPARTMAN.Caption = "DEPARTMAN"
        Me.colDEPARTMAN.ColumnEdit = Me.sec_DEPARTMAN
        Me.colDEPARTMAN.FieldName = "DEPARTMAN"
        Me.colDEPARTMAN.Name = "colDEPARTMAN"
        '
        'sec_DEPARTMAN
        '
        Me.sec_DEPARTMAN.AutoHeight = False
        Me.sec_DEPARTMAN.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_DEPARTMAN.DisplayMember = "ACIKLAMA"
        Me.sec_DEPARTMAN.Name = "sec_DEPARTMAN"
        Me.sec_DEPARTMAN.ValueMember = "KOD"
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
        'sec_sDepo
        '
        Me.sec_sDepo.AutoHeight = False
        Me.sec_sDepo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDepo.DisplayMember = "sDepo"
        Me.sec_sDepo.Name = "sec_sDepo"
        Me.sec_sDepo.ValueMember = "sDepo"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem25, Me.MenuItem27, Me.MenuItem20, Me.MenuItem4, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem26, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem15.Text = "Ara"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = False
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 5
        Me.MenuItem25.Text = "Kaydý Olmayanlar"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 6
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem27.Text = "Deðer Yay"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 7
        Me.MenuItem20.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = False
        Me.MenuItem4.Index = 8
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem12, Me.MenuItem19, Me.MenuItem24, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem4.Text = "Raporla"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Hata Kaydý Düþülenler"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Açýklama Kaydý Düþülenler"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Okutulmayanlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "Tümü"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 4
        Me.MenuItem24.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "Çýkýþý Yapýlmayan Kredili Satýþlar"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Text = "Çýkýþý Yapýlmayan Peþin Satýþlar"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 7
        Me.MenuItem23.Text = "Çýkýþý Yapýlmayan Sonradan Teslimler"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 9
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 11
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 12
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 13
        Me.MenuItem14.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 14
        Me.MenuItem26.Text = "Hýzlý Filtre"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 16
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 17
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 18
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem17.Text = "Tam Ekran"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Personel Giriþ/Çýkýþ Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Personel Takip", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarSubItem4, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarSubItem5, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarSubItem6, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarSubItem7, Me.BarSubItem8})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 35
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem8, True)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Personel Tanýmlarý"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Personel Tanýmlarý"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Departman Tanýmlarý"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Maazeret Tanýmlarý"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Vardiya Tanýmlarý"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Yetkili Tanýmlarý"
        Me.BarButtonItem5.Id = 7
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Raporlar"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Analiz"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Ýnsan Kaynaklarý"
        Me.BarSubItem5.Id = 11
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem8, "Ýþ Baþvurusu Ekle"), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem10, "Departmanlar", True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem11, "Yabancý Dil"), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Ýþ Baþvurusu Ekle/Deðiþtir/Sil"
        Me.BarButtonItem8.Id = 12
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Ýþ Baþvurularý"
        Me.BarButtonItem9.Id = 13
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Ýþ Baþvurularý Deðerlendirme Listesi"
        Me.BarButtonItem10.Id = 14
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "BarButtonItem11"
        Me.BarButtonItem11.Id = 15
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Yabancý Dil Seviyeleri"
        Me.BarButtonItem12.Id = 16
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Yüksek Okullar"
        Me.BarButtonItem13.Id = 17
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Yüksek Okul Bölümleri"
        Me.BarButtonItem14.Id = 18
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Ýþ Pozisyonlarý"
        Me.BarButtonItem15.Id = 19
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Personel Ýþlemleri"
        Me.BarSubItem6.Id = 20
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem26), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Personel Ekle"
        Me.BarButtonItem16.Id = 21
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Personel Listesi"
        Me.BarButtonItem17.Id = 22
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Yakýnlýk Derecesi"
        Me.BarButtonItem18.Id = 23
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Ýzin Tipleri"
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Eðitim Tipleri"
        Me.BarButtonItem20.Id = 25
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Sýnýf Kodlarý"
        Me.BarButtonItem21.Id = 26
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Bordro Tipleri"
        Me.BarButtonItem22.Id = 27
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Meslek Kodlarý"
        Me.BarButtonItem23.Id = 28
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Sicil Kodlarý"
        Me.BarButtonItem24.Id = 29
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Eksik Çalýþma Nedenleri"
        Me.BarButtonItem25.Id = 30
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Ýþten Çýkýþ Kodlarý"
        Me.BarButtonItem26.Id = 31
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Borç Tipleri"
        Me.BarButtonItem27.Id = 32
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "Bordro Ýþlemleri"
        Me.BarSubItem7.Id = 33
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarSubItem8
        '
        Me.BarSubItem8.Caption = "SGK Ýþlemleri"
        Me.BarSubItem8.Id = 34
        Me.BarSubItem8.Name = "BarSubItem8"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1649, 32)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1001)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1649, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 32)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 969)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1649, 32)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 969)
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Ýþ Baþvurularý"
        Me.BarSubItem4.Id = 8
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "BarButtonItem6"
        Me.BarButtonItem6.Id = 9
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Ýþ Baþvurularý"
        Me.BarButtonItem7.Id = 10
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'frm_personel_takip_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1649, 1001)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_personel_takip_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personel Takip Fiþleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_personel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_dteSaat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_vardiya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_lTutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_DEPARTMAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDepo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean = False
    Public connection
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_kasiyer As DataSet
    Public kasiyerno
    Public kasiyer
    Public personelno
    Dim info As Boolean = False
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_kasiyer()
        dataload_vardiya()
        dataload_Sef()
        dataload_Depo()
        dataload_DEPARTMAN()
        Me.WindowState = FormWindowState.Maximized
        Me.Refresh()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        SimpleButton7.Text = Sorgu_sDil(SimpleButton7.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_vardiya()
        sec_vardiya.DataSource = sorgu(sorgu_query("SELECT * FROM  APERSONELVARDIYALIST")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_Sef()
        sec_sSef.DataSource = sorgu(sorgu_query("SELECT PERSONELKODU,PERSONELADI FROM  APERSONEL WHERE LEN(PERSONELKODU)= 2 ")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_Depo()
        sec_sDepo.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_DEPARTMAN()
        sec_DEPARTMAN.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT    KOD,ACIKLAMA FROM         APERSONELDEPT ORDER BY KOD")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
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
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kod.Text Then
                kasiyerno = dr("IND")
                kasiyer = dr("KASIYER")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            txt_kasiyer.EditValue = kasiyer
            txt_kod.Enabled = False
            If Trim(kasiyerno) = "VC" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                'sec_depo.Properties.ReadOnly = False
                'sec_sonuc.Properties.ReadOnly = False
            ElseIf Trim(kasiyerno) = "ALI" Or Trim(kasiyerno) = "MB" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                'sec_depo.Properties.ReadOnly = False
                'sec_sonuc.Properties.ReadOnly = False
            End If
            DateEdit1.Focus()
            DateEdit1.SelectAll()
            GridControl1.Enabled = True
            status = True
        ElseIf sonuc = False Then
            txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            GridControl1.Enabled = False
            txt_kod.Focus()
            txt_kod.SelectAll()
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Dataset1 = stok(tarih1, tarih2)
        GridControl1.DataSource = Dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub stok_yeni_tek(Optional ByVal islemstatus As Boolean = False)
        Dim frm As New frm_personel
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        frm.status = True
        Dim belgeno As String = "1"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            belgeno = belgeno_kontrol(dataload_belgeno().ToString).ToString
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    ekle(DateEdit1.EditValue, belgeno.ToString, Now, 15, sDepo.ToCharArray, 0, "Normal", kasiyerno, kasiyer, dr1("PERSONELKODU").ToString, dr1("PERSONELADI").ToString, "", "", "", "", Now, 0, Now, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "")
                Next
            End If
        End If
        dataload(DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
    Private Sub stok_yeni(Optional ByVal islemstatus As Boolean = False)
        Dim frm As New frm_personel_takip
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = islemstatus
        If islemstatus = False Then
            frm.Text = "Personel Giriþ Ýþlemleri"
        Else
            frm.Text = "Personel Çýkýþ Ýþlemleri"
        End If
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Function ekle(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal SAAT As DateTime, ByVal SURE As Integer, ByVal MAGAZA As String, ByVal vardiya As Int64, ByVal IZAHAT As String, ByVal YETKILIKODU As String, ByVal YETKILI As String, ByVal PERSONELKODU As String, ByVal PERSONEL As String, ByVal SEFKODU As String, ByVal SEF As String, ByVal MAZERET As String, ByVal ACIKLAMA As String, ByVal GIRIS As DateTime, ByVal gecgiris As Integer, ByVal cikis As DateTime, ByVal GECCIKIS As Integer, ByVal YEVMIYE As Decimal, ByVal MESAI As Decimal, ByVal MESACIUCRETI As Decimal, ByVal EKLENTI1 As Decimal, ByVal EKLENTI2 As Decimal, ByVal EKLENTI3 As Decimal, ByVal EKLENTI4 As Decimal, ByVal EKLENTI5 As Decimal, ByVal KESINTI1 As Decimal, ByVal KESINTI2 As Decimal, ByVal KESINTI3 As Decimal, ByVal KESINTI4 As Decimal, ByVal KESINTI5 As Decimal, ByVal NET As Decimal, ByVal DEPARTMAN As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitno As Int64
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO APERSONELTAKIP                       (TARIH, BELGENO, GIRISSAAT,CIKISSAAT, SURE, MAGAZA, VARDIYA,IZAHAT, YETKILIKODU, YETKILI, PERSONELKODU, PERSONEL, SEFKODU, SEF, MAZERET, ACIKLAMA, GIRIS,CIKIS, GECGIRIS,GECCIKIS,STATUS,YEVMIYE,MESAI,MESAIUCRETI,EKLENTI1,EKLENTI2,EKLENTI3,EKLENTI4,EKLENTI5,KESINTI1,KESINTI2,KESINTI3,KESINTI4,KESINTI5,NET,DEPARTMAN) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & SAAT & "','01/01/1900 00:00:00', " & SURE & ", '" & MAGAZA & "'," & vardiya & ", '" & IZAHAT & "', '" & YETKILIKODU & "', '" & YETKILI & "', '" & PERSONELKODU & "', '" & PERSONEL & "', '" & SEFKODU & "' , '" & SEF & "' , '" & MAZERET & "', '" & ACIKLAMA & "', '" & GIRIS & "','01/01/1900 00:00:00', '" & gecgiris & "',0,0," & YEVMIYE & "," & MESAI & "," & MESACIUCRETI & "," & EKLENTI1 & "," & EKLENTI2 & "," & EKLENTI3 & "," & EKLENTI4 & "," & EKLENTI5 & "," & KESINTI1 & "," & KESINTI2 & "," & KESINTI3 & "," & KESINTI4 & "," & KESINTI5 & "," & NET & ",'" & DEPARTMAN & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub duzelt(ByVal IND As Int64, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal GIRISSAAT As DateTime, ByVal CIKISSAAT As DateTime, ByVal SURE As Int64, ByVal MAGAZA As String, ByVal VARDIYA As String, ByVal IZAHAT As String, ByVal YETKILIKODU As String, ByVal YETKILI As String, ByVal PERSONELKODU As String, ByVal PERSONEL As String, ByVal SEFKODU As String, ByVal SEF As String, ByVal MAZERET As String, ByVal ACIKLAMA As String, ByVal GIRIS As DateTime, ByVal GECGIRIS As Integer, ByVal CIKIS As DateTime, ByVal GECCIKIS As Integer, ByVal STATUS As Integer, ByVal YEVMIYE As Decimal, ByVal MESAI As Decimal, ByVal MESACIUCRETI As Decimal, ByVal EKLENTI1 As Decimal, ByVal EKLENTI2 As Decimal, ByVal EKLENTI3 As Decimal, ByVal EKLENTI4 As Decimal, ByVal EKLENTI5 As Decimal, ByVal KESINTI1 As Decimal, ByVal KESINTI2 As Decimal, ByVal KESINTI3 As Decimal, ByVal KESINTI4 As Decimal, ByVal KESINTI5 As Decimal, ByVal NET As Decimal, ByVal DEPARTMAN As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    APERSONELTAKIP SET              TARIH = '" & TARIH & "', BELGENO = '" & BELGENO & "', GIRISSAAT = '" & GIRISSAAT & "', CIKISSAAT = '" & CIKISSAAT & "', SURE = " & SURE & ", MAGAZA = '" & MAGAZA & "', VARDIYA = '" & VARDIYA & "', IZAHAT = '" & IZAHAT & "', YETKILIKODU = '" & YETKILIKODU & "', YETKILI = '" & YETKILI & "', PERSONELKODU = '" & PERSONELKODU & "', PERSONEL = '" & PERSONEL & "', SEFKODU = '" & SEFKODU & "', SEF = '" & SEF & "', MAZERET = '" & MAZERET & "', ACIKLAMA = '" & ACIKLAMA & "', GIRIS = '" & GIRIS & "', GECGIRIS = '" & GECGIRIS & "', CIKIS = '" & CIKIS & "', GECCIKIS = '" & GECCIKIS & "', STATUS = '" & STATUS & "',YEVMIYE =" & YEVMIYE & ",MESAI=" & MESAI & ",MESAIUCRETI=" & MESACIUCRETI & ",EKLENTI1=" & EKLENTI1 & ",EKLENTI2 =" & EKLENTI2 & ",EKLENTI3 =" & EKLENTI3 & ",EKLENTI4 =" & EKLENTI4 & ",EKLENTI5 =" & EKLENTI5 & ",KESINTI1 =" & KESINTI1 & ",KESINTI2 =" & KESINTI2 & ",KESINTI3 =" & KESINTI3 & ",KESINTI4 =" & KESINTI4 & ",KESINTI5 =" & KESINTI5 & ",NET=" & NET & ",DEPARTMAN='" & DEPARTMAN & "' Where IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub sil(ByVal IND As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    APERSONELTAKIP  Where IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
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
            seri = ""
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
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Try
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SELECT ISNULL(BELGENO,'000001') AS BELGENO FROM APERSONELTAKIP WHERE IND = (SELECT ISNULL(MAX(BELGENO),0) FROM APERSONELTAKIP  WHERE  TARIH < '" & Today & "')")
            sonuc = cmd.ExecuteScalar
            con.Close()
            If CStr(sonuc).ToString = "" Then
                sonuc = "000000"
            End If
        Catch ex As Exception
            sonuc = "000000"
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
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'Dim frm As New frm_stok_paket
            'frm.connection = connection
            'frm.firmano = firmano
            'frm.donemno = donemno
            'frm.belgeind = dr("IND")
            'frm.status = True
            'frm.ShowDialog()
            'frm.Close()
            'frm.Dispose()
            'frm = Nothing
            'Dim satir = GridView1.FocusedRowHandle
            'dataload(DateEdit1.EditValue, DateEdit2.EditValue)
            'GridView1.FocusedRowHandle = satir
            'satir = Nothing
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Satýrlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'dr = DataSet1.Tables(0).Rows(0)
            'stok_islemleri.kart_sil(dr("IND"), False)
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    sil(dr1("IND"))
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataload(DateEdit1.EditValue, DateEdit2.EditValue)
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim kriter As String = ""
        'kriter = "WHERE (IND> 99) AND FIRMANO <> 0"
        kriter += " WHERE TARIH BETWEEN '" & tarih1 & "' and '" & tarih2 & "' "
        'If kayitno <> "" Then
        '    kriter += " AND (IND " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        'End If
        'If ilktarih <> "" And sontarih <> "" Then
        '    kriter += " AND (TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        'End If
        'If ilkbelge <> "" And sonbelge = "" Then
        '    kriter += " AND (BELGENO LIKE '" & ilkbelge & " %')"
        'ElseIf ilkbelge <> "" And sonbelge <> "" Then
        '    kriter += " AND (BELGENO BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
        'End If
        'If firmakodu <> "" Then
        '    kriter += " AND (FIRMAKODU " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
        'End If
        'If firmaadi <> "" Then
        '    kriter += " AND (FIRMAADI " & sorgu_kriter_string(firmaadi, qfirmaadi) & " )"
        'End If
        'If kod1 <> "" Then
        '    kriter += " AND (KOD1 " & sorgu_kriter_string(kod1, qkod1) & " )"
        'End If
        'If kod2 <> "" Then
        '    kriter += " AND (KOD2 " & sorgu_kriter_string(kod2, qkod2) & " )"
        'End If
        'If aciklama <> "" Then
        '    kriter += " AND (ACIKLAMA " & sorgu_kriter_string(aciklama, qaciklama) & " )"
        'End If
        'If depo <> "" Then
        '    kriter += " AND (DEPO " & sorgu_kriter_string(depo, qdepo) & " )"
        'End If
        'If personel <> "" Then
        '    kriter += " AND (PERSONEL  " & sorgu_kriter_string(depo, qdepo) & " )"
        'End If
        'If kapali <> "" Then
        '    If kapali = True Then
        '        kapali = "1"
        '    Else
        '        kapali = "2"
        '    End If
        '    kriter += " AND (Baslik.sGirisCikis " & sorgu_kriter_string(kapali, qkapali) & " )"
        'End If
        'If gelismis <> "" Then
        '    kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        'End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM APERSONELTAKIP " & kriter & "  ORDER BY TARIH,IND")
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
    Private Sub analiz_envanter()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokno = dr("nStokId")
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
        frm.modelno = dr("sModel")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_hareket()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub personel_listesi(Optional ByVal kriter As String = "")
        Dim frm As New frm_personel
        frm.kriter = kriter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyerno = personelno
        frm.kullanici = kullanici
        frm.takip = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub personel_dept()
        Dim frm As New frm_personel_dept
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub personel_vardiya()
        Dim frm As New frm_personel_vardiyalari
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub personel_mazeret()
        Dim frm As New frm_personel_mazeret
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Function satir_kontrol()
        Dim satir As String = " WHERE PERSONELKODU NOT IN ( "
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
                satir += "'0" + dr1("PERSONELKODU").ToString + "'"
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += " )"
                End If
            Next
        End If
        Return satir
    End Function
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            'Try
            tutar_hesapla()
            'Catch ex As Exception
            '    XtraMessageBox.Show(Sorgu_sDil("Lütfen Ýþleminizi Kontrol Ediniz...",sDil), MessageBoxIcon.Warning, sorgu_sDil("Dikkat",sDil))
            'End Try
        End If
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("NET") = dr("YEVMIYE") + dr("MESAIUCRETI") + dr("EKLENTI1") + dr("EKLENTI2") + dr("EKLENTI3") + dr("EKLENTI4") + dr("EKLENTI5")
            dr("NET") = dr("NET") - (dr("KESINTI1") + dr("KESINTI2") + dr("KESINTI3") + dr("KESINTI4") + dr("KESINTI5"))
            duzelt(dr("IND"), dr("TARIH"), dr("BELGENO"), dr("GIRISSAAT"), dr("CIKISSAAT"), dr("SURE"), dr("MAGAZA"), dr("VARDIYA"), dr("IZAHAT"), dr("YETKILIKODU"), dr("YETKILI"), dr("PERSONELKODU"), dr("PERSONEL"), dr("SEFKODU"), dr("SEF"), dr("MAZERET"), dr("ACIKLAMA"), dr("GIRIS"), dr("GECGIRIS"), dr("CIKIS"), dr("GECCIKIS"), dr("STATUS"), dr("YEVMIYE"), dr("MESAI"), dr("MESAIUCRETI"), dr("EKLENTI1"), dr("EKLENTI2"), dr("EKLENTI3"), dr("EKLENTI4"), dr("EKLENTI5"), dr("KESINTI1"), dr("KESINTI2"), dr("KESINTI3"), dr("KESINTI4"), dr("KESINTI5"), dr("NET"), dr("DEPARTMAN"))
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        'If GridView1.SelectedRowsCount > 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Dim sayi1 = GridView1.SelectedRowsCount
        '    GridView1.FocusedColumn = colSTOKKODU
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}/Satýr:" & sayi & "/Seçili:" & sayi1 & ""
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}"
        'End If
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        stok_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            stok_duzelt()
        ElseIf e.KeyCode = Keys.Escape Then
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        stok_yeni()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += DateEdit1.EditValue.ToLongDateString & " ve " & DateEdit2.EditValue.ToLongDateString & " Tarihleri Arasýndaki Personel Listesi" & vbCrLf
        'kriter += "Maðazalar:" & sec_depo.Text & sec_kasatipi.Text & " " & sec_kasakasiyer.Text & " HareketTipi: " & sec_harekettipi.Text & " FiþTipi: " & sec_fistipi.Text
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Personel Takip Listesi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter_model()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
        'Me.Hide()
        'PanelControl1.Dispose()
        'PanelControl2.Dispose()
        ''PanelControl3.Dispose()
        'SimpleButton1.Dispose()
        'SimpleButton2.Dispose()
        'SimpleButton3.Dispose()
        'ContextMenu1.Dispose()
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        ''PanelControl3 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton3 = Nothing
        'ContextMenu1 = Nothing
        'status = Nothing
        'connection = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'stokno = Nothing
        'userno = Nothing
        'stokkodu = Nothing
        'malincinsi = Nothing
        'barkod = Nothing
        'muadilbarkod = Nothing
        'birim = Nothing
        'kod1 = Nothing
        'kod2 = Nothing
        'kod3 = Nothing
        'kod4 = Nothing
        'kod5 = Nothing
        'kod6 = Nothing
        'kod7 = Nothing
        'kod8 = Nothing
        'kod9 = Nothing
        'kod10 = Nothing
        'satisfiyati1 = Nothing
        'satisfiyati2 = Nothing
        'satisfiyati3 = Nothing
        'istihbarat = Nothing
        'kayitno = Nothing
        'qkayitno = Nothing
        'qstokkodu = Nothing
        'qmalincinsi = Nothing
        'qbarkod = Nothing
        'qmuadilbarkod = Nothing
        'qkod1 = Nothing
        'qkod2 = Nothing
        'qkod3 = Nothing
        'qkod4 = Nothing
        'qkod5 = Nothing
        'qkod6 = Nothing
        'qkod7 = Nothing
        'qkod8 = Nothing
        'qkod9 = Nothing
        'qkod10 = Nothing
        'qistihbarat = Nothing
        'qbirim = Nothing
        'qdepo = Nothing
        'qsatisfiyati1 = Nothing
        'qsatisfiyati2 = Nothing
        'qsatisfiyati3 = Nothing
        ''XtraTabPage1.Dispose()
        ''XtraTabPage1 = Nothing
        ''stok_islemleri = Nothing
        ''stkdll = Nothing
        'dr = Nothing
        'count = Nothing
        'ps.ClearContent()
        'ps.Dispose()
        'ps = Nothing
        'printlink1.Dispose()
        'printlink1 = Nothing
        'System.GC.Collect()
        'System.GC.GetTotalMemory(True)
        'System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_kaydet()
    End Sub
    Private Sub frm_stok_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        stok_sil()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim file As String
        'OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        'OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    file = OpenFileDialog1.FileName.ToString
        '    report_create_stok(file, satir_kontrol, 0)
        'End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 0)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim file As String
        'OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        'OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    file = OpenFileDialog1.FileName.ToString
        '    report_create_stok(file, satir_kontrol, 2)
        'End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim file As String
        'OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        'OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    file = OpenFileDialog1.FileName.ToString
        '    report_create_stok(file, satir_kontrol, 1)
        'End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 1)
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'personel_listesi()
        If Trim(kasiyerno) = "VC" Then
            personel_listesi()
        ElseIf Trim(kasiyerno) = "ALI" Or Trim(kasiyerno) = "MB" Then
            personel_listesi()
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If Trim(kasiyerno) = "VC" Then
            personel_dept()
        ElseIf Trim(kasiyerno) = "ALI" Or Trim(kasiyerno) = "MB" Then
            personel_dept()
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If Trim(kasiyerno) = "VC" Then
            personel_vardiya()
        ElseIf Trim(kasiyerno) = "ALI" Or Trim(kasiyerno) = "MB" Then
            personel_vardiya()
        End If
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If Trim(kasiyerno) = "VC" Then
            personel_mazeret()
        ElseIf Trim(kasiyerno) = "ALI" Or Trim(kasiyerno) = "MB" Then
            personel_mazeret()
        End If
    End Sub
    Private Sub txt_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        dataload(DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        stok_yeni()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        stok_yeni(True)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If Trim(kasiyerno) = "VC" Then
            GridView1.SelectAll()
            personel_listesi(satir_kontrol)
        ElseIf Trim(kasiyerno) = "ALI" Or Trim(kasiyerno) = "MB" Then
            GridView1.SelectAll()
            personel_listesi(satir_kontrol)
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If MenuItem26.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem26.Checked = True
        ElseIf MenuItem26.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem26.Checked = False
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                info = False
                degeryay(GridView1.FocusedColumn().FieldName, True)
                info = True
            End If
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String, Optional ByVal bSatirDegistir As Boolean = True)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim Ý As Integer
        Ý = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            If bSatirDegistir = True Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.BeginEdit()
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            End If
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
    Private Sub toplamlar()
        Dim frm As New frm_personel_takip_toplam
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.DateEdit1.EditValue = DateEdit1.EditValue
        frm.DateEdit2.EditValue = DateEdit2.EditValue
        frm.ShowDialog()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        toplamlar()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Personel Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub tbKasiyer()
        Dim frm As New frm_tbKasiyer
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        tbKasiyer()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        tbIsBasvuruFormu_Ekle()
    End Sub
    Private Sub tbPersonel_Ekle()
        Dim frm As New frm_tbPersonel
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.yeni = True
        frm.nPersonelID = 0
        frm.txt_nPersonelID.Text = frm.nPersonelID
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbPersonel_Duzelt()
        Dim frm As New frm_tbPersonel_Liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbIsBasvuruFormu_Ekle()
        Dim frm As New frm_tbBasvuru
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.yeni = True
        frm.nAdayID = 0
        frm.txt_AdayNo.Text = frm.nAdayID
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbIsBasvuruFormu_Duzelt()
        Dim frm As New frm_tbBasvuru_Liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbEditor(ByVal table As String, Optional ByVal form As String = "", Optional ByVal sKriter As String = "")
        Dim frm As New frm_Table_Edit
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = SQLconnection
        frm.kullanici = kullanici
        frm.m_TableName = table
        form = "frm_" + table
        frm.sKriter = sKriter
        frm.Text = "Tablo Editörü-" + table
        'frm.MdiParent = Me
        If yetki_kontrol(kullanici, form) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbSinif(ByVal tablo As String)
        Dim fr As New frm_tbSinif
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.kullanici = kullanici
        fr.Table = tablo
        If yetki_kontrol(kullanici, fr.Name) = True Then
            fr.Show()
        End If
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        tbIsBasvuruFormu_Duzelt()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbEditor("tbBordroFirmadepartman")
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        tbEditor("tbYabanciDilSeviye")
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        tbEditor("tbYabanciDil")
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        tbEditor("tbYuksekOkul")
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        tbEditor("tbYuksekOkulBolum")
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        tbEditor("tbIsPozisyonu")
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        tbPersonel_Ekle()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        tbPersonel_Duzelt()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        tbEditor("tbYakinlik")
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        tbEditor("tbIzinTipi")
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        tbEditor("tbEgitimTipi")
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        tbEditor("tbBordroTipi")
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        tbEditor("tbPersonelMeslekKod")
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        tbEditor("tbPersonelSicilKod")
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        tbEditor("tbEksikCalismaNedeni")
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        tbEditor("tbIstenCikisSebebi")
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        tbEditor("tbPersonelBorcTipi")
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        tbSinif("tbPSinif")
    End Sub
End Class
