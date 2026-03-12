Imports Microsoft.Win32
Imports System.Windows.Forms
Imports FastReport
Imports System.Threading
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_kasiyer_dokum_liste
    Inherits DevExpress.XtraEditors.XtraForm
    Friend WithEvents sec_ts As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_to As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_isim As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
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
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_belgeno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents colKAYIT As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colSOZLESME As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_analiz As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_goster As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_dotmatrix As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_sMagaza As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_promosyon As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl_hediye As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_hediye As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_kasiyer_dokum_liste))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_hediye = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_hediye = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.DataSet1 = New System.Data.DataSet()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOYADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALISVERISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVADEFARKI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAGAZA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASIYER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYAZI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOGUMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVLILIKTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYAZDIRMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAYIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOZLESME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musterino = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_ts = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_to = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_belgeno = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_dotmatrix = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_promosyon = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_goster = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_analiz = New DevExpress.XtraEditors.CheckEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_isim = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sMagaza = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.btn_baglan = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_kasiyer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_to.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_dotmatrix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_promosyon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_goster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_analiz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 22)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(896, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Aþaðýda Döküm Emirlerini Görmektesiniz. Ýþlem Yapmak Ýstediðiniz Emri seçmek için" &
    " Ýlgili kaydýn üstüne geliniz..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.btn_hediye)
        Me.PanelControl2.Controls.Add(Me.lbl_hediye)
        Me.PanelControl2.Controls.Add(Me.Label5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 372)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(896, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(166, 21)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(95, 24)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "&Depo Döküm"
        '
        'btn_hediye
        '
        Me.btn_hediye.Enabled = False
        Me.btn_hediye.Image = CType(resources.GetObject("btn_hediye.Image"), System.Drawing.Image)
        Me.btn_hediye.Location = New System.Drawing.Point(261, 21)
        Me.btn_hediye.Name = "btn_hediye"
        Me.btn_hediye.Size = New System.Drawing.Size(91, 24)
        Me.btn_hediye.TabIndex = 9
        Me.btn_hediye.Text = "&Hediye Ekle"
        '
        'lbl_hediye
        '
        Me.lbl_hediye.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_hediye.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_hediye.Location = New System.Drawing.Point(2, 2)
        Me.lbl_hediye.Name = "lbl_hediye"
        Me.lbl_hediye.Size = New System.Drawing.Size(37, 13)
        Me.lbl_hediye.TabIndex = 8
        Me.lbl_hediye.Text = "Hediye:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(404, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(91, 21)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton5.TabIndex = 6
        Me.SimpleButton5.Text = "&Yazdýr"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(16, 21)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "&Yenile"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(808, 17)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(728, 17)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 78)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(896, 294)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.Panelstatus)
        Me.PanelControl5.Controls.Add(Me.GridControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 129)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(892, 163)
        Me.PanelControl5.TabIndex = 1
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
        Me.Panelstatus.Location = New System.Drawing.Point(180, 28)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(533, 106)
        Me.Panelstatus.TabIndex = 4
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
        Me.GridControl1.Size = New System.Drawing.Size(888, 159)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem24, Me.MenuItem14, Me.MenuItem3, Me.MenuItem2, Me.MenuItem4, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem37, Me.MenuItem29, Me.MenuItem28, Me.MenuItem30, Me.MenuItem20, Me.MenuItem19, Me.MenuItem35, Me.MenuItem31, Me.MenuItem15, Me.MenuItem5, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem6, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
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
        Me.MenuItem2.Text = "Kalan Satýþlar"
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
        Me.MenuItem25.Text = "Ekstre"
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
        'MenuItem37
        '
        Me.MenuItem37.Index = 9
        Me.MenuItem37.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem37.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 10
        Me.MenuItem29.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 11
        Me.MenuItem28.Text = "Takibe Al"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 12
        Me.MenuItem30.Text = "Ýlk Taksit Ödemesi Takip Et"
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
        'MenuItem35
        '
        Me.MenuItem35.Index = 15
        Me.MenuItem35.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 16
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem33, Me.MenuItem34, Me.MenuItem36, Me.MenuItem32})
        Me.MenuItem31.Text = "Hediye"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 0
        Me.MenuItem33.Text = "Hediyeyi Sil"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 1
        Me.MenuItem34.Text = "Hediyeyi Deðiþtir"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 2
        Me.MenuItem36.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 3
        Me.MenuItem32.Text = "Hediye Verilmeyecek?"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 17
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 18
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 19
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 20
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 21
        Me.MenuItem16.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 22
        Me.MenuItem6.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 23
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 24
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 25
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 26
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 27
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 28
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 29
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem13.Text = "Ekraný Kapla"
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
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "FIRMAKODU", Nothing, "ÝþlemSayýsý: {0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "ToplamMiktar: {0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Nothing, "ToplamTutar: {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
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
        Me.PanelControl4.Controls.Add(Me.GroupControl2)
        Me.PanelControl4.Controls.Add(Me.lbl_isim)
        Me.PanelControl4.Controls.Add(Me.lbl_sMagaza)
        Me.PanelControl4.Controls.Add(Me.GroupControl1)
        Me.PanelControl4.Controls.Add(Me.btn_baglan)
        Me.PanelControl4.Controls.Add(Me.txt_kasiyer)
        Me.PanelControl4.Controls.Add(Me.txt_kod)
        Me.PanelControl4.Controls.Add(Me.Label2)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(892, 127)
        Me.PanelControl4.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.DateEdit1)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.txt_musterino)
        Me.GroupControl2.Controls.Add(Me.sec_ts)
        Me.GroupControl2.Controls.Add(Me.sec_to)
        Me.GroupControl2.Controls.Add(Me.txt_belgeno)
        Me.GroupControl2.Controls.Add(Me.sec_resmi)
        Me.GroupControl2.Controls.Add(Me.sec_dotmatrix)
        Me.GroupControl2.Controls.Add(Me.sec_promosyon)
        Me.GroupControl2.Controls.Add(Me.SimpleButton6)
        Me.GroupControl2.Controls.Add(Me.CheckEdit1)
        Me.GroupControl2.Controls.Add(Me.sec_goster)
        Me.GroupControl2.Controls.Add(Me.sec_analiz)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Location = New System.Drawing.Point(343, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(365, 102)
        Me.GroupControl2.TabIndex = 59
        Me.GroupControl2.Text = "Belge Ara"
        '
        'Label6
        '
        Me.Label6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Tarih:"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(57, 2)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(214, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Müþteri:"
        '
        'txt_musterino
        '
        Me.txt_musterino.EditValue = ""
        Me.txt_musterino.Location = New System.Drawing.Point(57, 22)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_musterino.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musterino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musterino.Properties.NullText = "[Tümü]"
        Me.txt_musterino.Size = New System.Drawing.Size(80, 20)
        ToolTipTitleItem1.Text = "MüþteriNo"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Müþteri Numarasý biliniyorsa buraya yazýlýr. Bilinmiyorsa tümü için boþ býrakmaný" &
    "z yeterlidir, eðerki tek müþterinin hareketleri listelenmek isteniyorsa F6 tuþun" &
    "a basýlarak müþteri seçilebilir. "
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txt_musterino.SuperTip = SuperToolTip1
        Me.txt_musterino.TabIndex = 1
        '
        'sec_ts
        '
        Me.sec_ts.Location = New System.Drawing.Point(318, 61)
        Me.sec_ts.Name = "sec_ts"
        Me.sec_ts.Properties.Caption = "tS"
        Me.sec_ts.Size = New System.Drawing.Size(45, 19)
        Me.sec_ts.TabIndex = 57
        '
        'sec_to
        '
        Me.sec_to.Location = New System.Drawing.Point(281, 61)
        Me.sec_to.Name = "sec_to"
        Me.sec_to.Properties.Caption = "Termal"
        Me.sec_to.Size = New System.Drawing.Size(40, 19)
        Me.sec_to.TabIndex = 56
        '
        'txt_belgeno
        '
        Me.txt_belgeno.EditValue = ""
        Me.txt_belgeno.EnterMoveNextControl = True
        Me.txt_belgeno.Location = New System.Drawing.Point(191, 22)
        Me.txt_belgeno.Name = "txt_belgeno"
        Me.txt_belgeno.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_belgeno.Properties.Appearance.Options.UseBackColor = True
        Me.txt_belgeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_belgeno.Properties.NullText = "[Tümü]"
        Me.txt_belgeno.Size = New System.Drawing.Size(80, 20)
        ToolTipTitleItem2.Text = "BelgeNo"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Belirtilen belgeno ya göre aramak yapýlmak istendiðinde belgenin numarasý buraya " &
    "yazýlýr. boþ býrakýlýr ise tüm belgeler listelenecektir."
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txt_belgeno.SuperTip = SuperToolTip2
        Me.txt_belgeno.TabIndex = 2
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(281, 23)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 53
        '
        'sec_dotmatrix
        '
        Me.sec_dotmatrix.Location = New System.Drawing.Point(281, 42)
        Me.sec_dotmatrix.Name = "sec_dotmatrix"
        Me.sec_dotmatrix.Properties.Caption = "Dot Matrix?"
        Me.sec_dotmatrix.Size = New System.Drawing.Size(77, 19)
        Me.sec_dotmatrix.TabIndex = 26
        '
        'sec_promosyon
        '
        Me.sec_promosyon.Location = New System.Drawing.Point(159, 61)
        Me.sec_promosyon.Name = "sec_promosyon"
        Me.sec_promosyon.Properties.Caption = "Promosyon Hesapla?"
        Me.sec_promosyon.Size = New System.Drawing.Size(124, 19)
        Me.sec_promosyon.TabIndex = 54
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(2, 82)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(361, 18)
        Me.SimpleButton6.TabIndex = 14
        Me.SimpleButton6.Text = "&Listele"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = True
        Me.CheckEdit1.Location = New System.Drawing.Point(54, 42)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Yazdýrýlmayanlar?"
        Me.CheckEdit1.Size = New System.Drawing.Size(104, 19)
        Me.CheckEdit1.TabIndex = 12
        '
        'sec_goster
        '
        Me.sec_goster.EditValue = True
        Me.sec_goster.Location = New System.Drawing.Point(55, 61)
        Me.sec_goster.Name = "sec_goster"
        Me.sec_goster.Properties.Caption = "Döküm Göster?"
        Me.sec_goster.Size = New System.Drawing.Size(103, 19)
        Me.sec_goster.TabIndex = 25
        '
        'sec_analiz
        '
        Me.sec_analiz.EditValue = True
        Me.sec_analiz.Location = New System.Drawing.Point(160, 42)
        Me.sec_analiz.Name = "sec_analiz"
        Me.sec_analiz.Properties.Caption = "Müþteri Analizi?"
        Me.sec_analiz.Size = New System.Drawing.Size(95, 19)
        Me.sec_analiz.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(143, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "BelgeNo:"
        '
        'lbl_isim
        '
        Me.lbl_isim.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_isim.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_isim.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_isim.Location = New System.Drawing.Point(2, 112)
        Me.lbl_isim.Name = "lbl_isim"
        Me.lbl_isim.Size = New System.Drawing.Size(6, 13)
        Me.lbl_isim.TabIndex = 58
        Me.lbl_isim.Text = "*"
        '
        'lbl_sMagaza
        '
        Me.lbl_sMagaza.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sMagaza.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sMagaza.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sMagaza.Location = New System.Drawing.Point(3, 70)
        Me.lbl_sMagaza.Name = "lbl_sMagaza"
        Me.lbl_sMagaza.Size = New System.Drawing.Size(47, 13)
        Me.lbl_sMagaza.TabIndex = 55
        Me.lbl_sMagaza.Text = "Maðaza:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lbl_istihbarat)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(714, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(176, 123)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "Ýstihbarat"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_istihbarat.Location = New System.Drawing.Point(2, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(172, 13)
        Me.lbl_istihbarat.TabIndex = 40
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'btn_baglan
        '
        Me.btn_baglan.Image = CType(resources.GetObject("btn_baglan.Image"), System.Drawing.Image)
        Me.btn_baglan.Location = New System.Drawing.Point(64, 28)
        Me.btn_baglan.Name = "btn_baglan"
        Me.btn_baglan.Size = New System.Drawing.Size(232, 23)
        Me.btn_baglan.TabIndex = 11
        Me.btn_baglan.Text = "&Baðlan"
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(143, 8)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(154, 20)
        Me.txt_kasiyer.TabIndex = 10
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(64, 8)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(79, 20)
        Me.txt_kod.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kasiyer:"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Döküm Emirleri Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Ýþ Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 420)
        Me.barDockControlBottom.Size = New System.Drawing.Size(896, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 398)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(896, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 398)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'frm_kasiyer_dokum_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(896, 420)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_kasiyer_dokum_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Döküm Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_to.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_dotmatrix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_promosyon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_goster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_analiz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public connection
    Public connection_resmi
    Public connection_orj
    Public kullanici
    Public firmano
    Public donemno
    Public kasiyerno
    Public kasiyer = ""
    Public kasiyer_depo = ""
    Public personelno As Int64 = 0
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
    Dim ds_stok_fisi As DataSet
    Dim ds_promosyon_stok As DataSet
    Public frf_islem As String = "mektup"
    'Dim tarih As DateTime
    Private _searching As Boolean
    Private _deferSearch As Boolean
    Private _searchThread As Thread
    Private _onSearchComplete As EventHandler
    Dim bOtomatikHediye As Boolean = False
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
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        Try
            bOtomatikHediye = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("bOtomatikHediye").ToString
        Catch ex As Exception
            bOtomatikHediye = False
        End Try
        Try
            sec_to.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("TermalOdeme").ToString
        Catch ex As Exception
            sec_to.Checked = False
        End Try
        Try
            sec_ts.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("TermalSatis").ToString
        Catch ex As Exception
            sec_ts.Checked = False
        End Try
        Try
            sPrinter_Depo = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterDepo").ToString
        Catch ex As Exception
            sPrinter_Depo = ""
        End Try
        firmano = 100
        donemno = 1
        DateEdit1.EditValue = dteSistemTarihi
        'tarih = Today
        dataload_kasiyer()
        dataload_satici()
        dataload_fiyattipi()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        GridControl1.Enabled = False
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload(ByVal tarih As DateTime, ByVal kasiyerno As String, ByVal musterikodu As String, ByVal belgeno As String)
        Dim kriter_musteri = ""
        Dim kriter_belgeno = ""
        Dim kasiyer_satis = ""
        Dim kasiyer_odeme = ""
        'kriter += " WHERE Tarih ='" & tarih & "' "
        If Trim(kasiyerno) = "VC" Then
        ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
        ElseIf Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "AL" Then
            kasiyer_satis = " AND tbAlisVeris.sMagaza ='" & kasiyer_depo & "' "
            kasiyer_odeme = " AND tbOdeme.sMagaza ='" & kasiyer_depo & "' "
        Else
            kasiyer_satis = " AND tbAlisVeris.sKasiyerRumuzu ='" & kasiyerno & "' "
            kasiyer_odeme = " AND tbOdeme.sKasiyerRumuzu ='" & kasiyerno & "' "
        End If
        If musterikodu <> "" Then
            kriter_musteri = " AND tbMusteri.lKodu = '" & Trim(musterikodu) & "' "
        End If
        If Trim(belgeno) <> "" Then
            kriter_belgeno = " AND tbAlisVeris.lFaturaNo = '" & Trim(belgeno) & "' "
        End If
        DataSet1.Clear()
        sorgu_dokumler(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_satis & " AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR , '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,MAX(KAYIT) KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , SUM(tbOdeme.lOdemeTutar) AS TUTAR , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_odeme & " " & kriter_belgeno & "  GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,SOZLESME,ISTIHBARAT) T ORDER BY KAYIT DESC"))
        'DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_satis & " AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR , '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , SUM(tbOdeme.lOdemeTutar) AS TUTAR , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih & "' AND '" & tarih & "') " & kriter_musteri & " " & kasiyer_odeme & " " & kriter_belgeno & "  GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY IZAHAT, BELGENO"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = 0
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            'GridView1.FocusedRowHandle = 0
            'Try
            promosyon_kontrol_belge()
            'Catch ex As Exception
            'End Try
        End If
    End Sub
    Private Sub sorgu_dokumler(ByVal query As String)
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        cmd.CommandTimeout = False
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        DS = Nothing
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        conn.Close()
        Return DS
    End Function
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
                lbl_sMagaza.Text = "Maðaza: " & kasiyer_depo
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
            txt_musterino.Select()
            txt_musterino.SelectAll()
            status = True
            If Trim(kasiyerno) = "VC" Then
                DateEdit1.Properties.ReadOnly = False
                'sec_sonuc.Properties.ReadOnly = False
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "AL" Then
                DateEdit1.Properties.ReadOnly = False
                'sec_sonuc.Properties.ReadOnly = False
            Else
                DateEdit1.Properties.ReadOnly = True
            End If
        ElseIf sonuc = False Then
            lbl_sMagaza.Text = "*"
            txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            'txt_kasiyer.Enabled = True
            GridControl1.Enabled = False
            btn_baglan.Text = "Baðlan"
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_kod.Focus()
            txt_kod.SelectAll()
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
                If Trim(dr("ADI")).ToString.Contains("PEÞÝN") = False Then
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
    Private Sub promosyon_kontrol_belge()
        Dim dr As DataRow
        kasiyer_depo = Trim(kasiyer_depo).ToString
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        btn_hediye.Enabled = False
        Dim listeNo As Integer = 0
        Dim hediye_sayisi As Integer = 0
        If Trim(dr("IZAHAT")).ToString = "K" Then
            hediye_sayisi = sorgu_promosyon_sayisi(dr("IZAHAT"), dr("GIRIS"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", True)
        ElseIf Trim(dr("IZAHAT")).ToString = "P" Then
            hediye_sayisi = sorgu_promosyon_sayisi(dr("IZAHAT"), dr("GIRIS"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", True)
        ElseIf Trim(dr("IZAHAT")).ToString = "SK" Then
            hediye_sayisi = sorgu_promosyon_sayisi(dr("IZAHAT"), dr("GIRIS"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", False)
        ElseIf Trim(dr("IZAHAT")).ToString = "SP" Then
            hediye_sayisi = sorgu_promosyon_sayisi(dr("IZAHAT"), dr("GIRIS"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", False)
        End If
        If hediye_sayisi = 0 Then
            If Trim(dr("IZAHAT")).ToString = "OD" Then
                btn_hediye.Enabled = False
                lbl_hediye.Text = ""
            Else
                If sec_promosyon.Checked = True Then
                    If Microsoft.VisualBasic.Left(Trim(dr("YAZI")), 3) <> "HI " Then
                        If dr("Tutar") > Form1.liste1_bas And dr("Tutar") < Form1.liste1_bit And Form1.list1_Check = True Then
                            listeNo = 1
                            lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE1", Trim(dr("MAGAZA")))
                            If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                                Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                                lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                                promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                                btn_hediye.Enabled = True
                            End If
                        ElseIf dr("Tutar") > Form1.liste2_bas And dr("Tutar") < Form1.liste2_bit And Form1.list2_Check = True Then
                            listeNo = 2
                            lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE2", Trim(dr("MAGAZA")))
                            If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                                Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                                lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                                promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                                btn_hediye.Enabled = True
                            End If
                        ElseIf dr("TUTAR") > Form1.liste3_bas And dr("TUTAR") < Form1.liste3_bit And Form1.list3_Check = True Then
                            listeNo = 3
                            lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE3", Trim(dr("MAGAZA")))
                            If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                                Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                                lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                                promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                                btn_hediye.Enabled = True
                            End If
                        ElseIf dr("TUTAR") > Form1.liste4_bas And dr("TUTAR") < Form1.liste4_bit And Form1.list4_Check = True Then
                            listeNo = 4
                            lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE4", Trim(dr("MAGAZA")))
                            If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                                Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                                lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                                promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                                btn_hediye.Enabled = True
                            End If
                        ElseIf dr("TUTAR") > Form1.liste5_bas And dr("TUTAR") < Form1.liste5_bit And Form1.list5_Check = True Then
                            listeNo = 5
                            lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE5", Trim(dr("MAGAZA")))
                            If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                                Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                                lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                                promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                                btn_hediye.Enabled = True
                            End If
                        ElseIf dr("TUTAR") > Form1.liste6_bas And dr("TUTAR") < Form1.liste6_bit And Form1.list6_Check = True Then
                            listeNo = 6
                            lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE6", Trim(dr("MAGAZA")))
                            If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                                Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                                lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                                promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                                btn_hediye.Enabled = True
                            End If
                            'ElseIf dr("TUTAR") > 999.99 And dr("TUTAR") < 1999.99 Then
                            '    listeNo = 7
                            '    lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            '    ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE7", Trim(dr("MAGAZA")))
                            '    If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                            '        Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                            '        lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                            '        promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                            '        btn_hediye.Enabled = True
                            '    End If
                            'ElseIf dr("TUTAR") > 1999.99 And dr("TUTAR") < 999999.99 Then
                            '    listeNo = 8
                            '    lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            '    ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE8", Trim(dr("MAGAZA")))
                            '    If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                            '        Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                            '        lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                            '        promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                            '        btn_hediye.Enabled = True
                            '    End If
                            'ElseIf dr("TUTAR") > 1499.99 And dr("TUTAR") < 1999.99 Then
                            '    listeNo = 9
                            '    lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            '    ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE9", Trim(dr("MAGAZA")))
                            '    If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                            '        Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                            '        lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                            '        promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                            '        btn_hediye.Enabled = True
                            '    End If
                            'ElseIf dr("TUTAR") > 1999.99 And dr("TUTAR") < 99999.99 Then
                            '    listeNo = 10
                            '    lbl_hediye.Text = "Hediye Listesi: " & Trim(dr("MAGAZA")) & " Liste" & listeNo & ""
                            '    ds_promosyon_stok = sorgu_promosyon_stok_info("LISTE10", Trim(dr("MAGAZA")))
                            '    If ds_promosyon_stok.Tables(0).Rows.Count > 0 Then
                            '        Dim dr1 As DataRow = ds_promosyon_stok.Tables(0).Rows(0)
                            '        lbl_hediye.Text += " SýraNo: " & dr1("ETIKET") & " StokKodu: " & dr1("STOKKODU") & " StokAdý: " & dr1("MALINCINSI") & " Renk : " & dr1("RENK")
                            '        promosyon_ekle(Trim(dr("IZAHAT")), dr("GIRIS"), dr("TARIH"), dr("BELGENO"), dr("ALISVERISNO"), dr("nMusteriID"), "Pr", dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), "LISTE" & listeNo & " / " & dr1("ETIKET"), Trim(dr("MAGAZA")), "", True)
                            '        btn_hediye.Enabled = True
                            '    End If
                        Else
                            btn_hediye.Enabled = False
                            lbl_hediye.Text = "Hediye Çýkmadý..."
                        End If
                    End If
                Else
                End If
            End If
        Else
            lbl_hediye.Text = "Hediye Verilmiþ"
        End If
    End Sub
    Private Sub promosyon_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Int64, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nAlisVerisID As String, ByVal nMusteriID As Int64, ByVal sFiyatTipi As String, ByVal nStokID As Int64, ByVal sKodu As String, ByVal sAciklama As String, ByVal liste As String, ByVal sMagaza As String, ByVal sYaziIle As String, Optional ByVal kredili As Boolean = True)
        Dim nIslemID As Int64 = 0
        Dim nSiparisID As Int64 = 0
        If Trim(sFisTipi).ToString = "K" Or Trim(sFisTipi).ToString = "P" Then
            dataload_fis_detay(sFisTipi, nGirisCikis, dteFisTarihi, lFisNo, nMusteriID, nAlisVerisID)
            If ds_stok_fisi.Tables(0).Rows.Count > 0 Then
                Dim dr_fhareket As DataRow = ds_stok_fisi.Tables(0).Rows(0)
                nIslemID = sorgu_nStokIslemID()
                'MsgBox(dr_fhareket(0) & vbCrLf & dr_fhareket(1) & vbCrLf & dr_fhareket(2) & vbCrLf & dr_fhareket(3) & vbCrLf & dr_fhareket(4) & vbCrLf & dr_fhareket(5) & vbCrLf & dr_fhareket(6) & vbCrLf & dr_fhareket(7) & vbCrLf & dr_fhareket(8) & vbCrLf & dr_fhareket(9) & vbCrLf & dr_fhareket(10) & vbCrLf & dr_fhareket(11) & vbCrLf & dr_fhareket(12) & vbCrLf & dr_fhareket(13) & vbCrLf & dr_fhareket(14) & vbCrLf & dr_fhareket(15) & vbCrLf & dr_fhareket(16) & vbCrLf & dr_fhareket(17) & vbCrLf & dr_fhareket(18) & vbCrLf & dr_fhareket(19) & vbCrLf & dr_fhareket(20) & vbCrLf & dr_fhareket(21) & vbCrLf & dr_fhareket(22) & vbCrLf & dr_fhareket(23) & vbCrLf & dr_fhareket(24) & vbCrLf & dr_fhareket(25) & vbCrLf & dr_fhareket(26) & vbCrLf & dr_fhareket(27) & vbCrLf & dr_fhareket(28) & vbCrLf & dr_fhareket(29) & vbCrLf & dr_fhareket(30) & vbCrLf & dr_fhareket(31) & vbCrLf & dr_fhareket(32) & vbCrLf & dr_fhareket(33) & vbCrLf & dr_fhareket(34) & vbCrLf & dr_fhareket(35) & vbCrLf & dr_fhareket(36) & vbCrLf & dr_fhareket(37) & vbCrLf & dr_fhareket(38) & vbCrLf & dr_fhareket(39) & vbCrLf & dr_fhareket(40) & vbCrLf & dr_fhareket(41) & vbCrLf & dr_fhareket(42) & vbCrLf & dr_fhareket(43) & vbCrLf & dr_fhareket(44) & vbCrLf & dr_fhareket(45) & vbCrLf & dr_fhareket(46) & vbCrLf & dr_fhareket(47) & vbCrLf & dr_fhareket(48) & vbCrLf & dr_fhareket(49) & vbCrLf & dr_fhareket(50) & vbCrLf & dr_fhareket(51) & vbCrLf & dr_fhareket(52) & vbCrLf & dr_fhareket(53) & vbCrLf & dr_fhareket(54) & vbCrLf & dr_fhareket(55) & vbCrLf & dr_fhareket(56) & vbCrLf & dr_fhareket(57) & vbCrLf & dr_fhareket(58) & vbCrLf & dr_fhareket(59) & vbCrLf & dr_fhareket(60), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
                detay_kaydet_yeni(nIslemID, nStokID, dr_fhareket("dteIslemTarihi"), 0, nMusteriID, dr_fhareket("sFisTipi"), dr_fhareket("dteFisTarihi"), dr_fhareket("lFisNo"), dr_fhareket("nGirisCikis"), dr_fhareket("sDepo"), 0, dr_fhareket("sStokIslem"), dr_fhareket("sKasiyerRumuzu"), dr_fhareket("sSaticiRumuzu"), dr_fhareket("sOdemeKodu"), dr_fhareket("dteIrsaliyeTarihi"), 0, 0, 0, 0, 0, 1, 0, 0.01, 0.01, sFiyatTipi, 0.01, 0.01, dr_fhareket("lMaliyetFiyat"), dr_fhareket("lMaliyetTutar"), dr_fhareket("lIlaveMaliyetTutar"), dr_fhareket("nIskontoYuzdesi"), dr_fhareket("lIskontoTutari"), dr_fhareket("sDovizCinsi"), dr_fhareket("lDovizFiyat"), "NULL", 0, "NULL", "NULL", 0, 0, sAciklama, dr_fhareket("sHareketTipi"), dr_fhareket("bMuhasebeyeIslendimi"), dr_fhareket("sKullaniciAdi"), dr_fhareket("dteKayitTarihi"), dr_fhareket("sDovizCinsi1"), dr_fhareket("lDovizMiktari1"), dr_fhareket("lDovizKuru1"), dr_fhareket("sDovizCinsi2"), dr_fhareket("lDovizMiktari2"), dr_fhareket("lDovizKuru2"), dr_fhareket("nOTVOrani"), "NULL", nAlisVerisID, "NULL", "NULL", dr_fhareket("sMasrafYontemi"), dr_fhareket("sHangiUygulama"), dr_fhareket("nEkSaha1"), dr_fhareket("nEkSaha2"), dr_fhareket("bEkSoru1"), dr_fhareket("bEkSoru2"), dr_fhareket("sSonKullaniciAdi"), dr_fhareket("dteSonUpdateTarihi"))
                fis_detay_fisno_degistir(nIslemID)
                fis_Master_degistir(nAlisVerisID, liste & "     " & sYaziIle)
            End If
        ElseIf Trim(sFisTipi).ToString = "SK" Or Trim(sFisTipi).ToString = "SP" Then
            dataload_siparis(sFisTipi, nGirisCikis, dteFisTarihi, lFisNo, nMusteriID, nAlisVerisID)
            If ds_stok_fisi.Tables(0).Rows.Count > 0 Then
                Dim dr_shareket As DataRow = ds_stok_fisi.Tables(0).Rows(0)
                nSiparisID = sorgu_nSiparisID(sMagaza)
                siparis_kaydet_yeni(nAlisVerisID, sMagaza, nSiparisID, nGirisCikis, nStokID, dr_shareket("sKasiyerRumuzu"), dr_shareket("sSaticiRumuzu"), dr_shareket("sOdemeKodu"), dr_shareket("lReyonFisNo"), sFiyatTipi, 1, 0.01, 0.01, 0, 0, 0.01, 0.01, 0, dr_shareket("sIadeNedeni"), dr_shareket("nPartiID"), DateAdd(DateInterval.Day, 1, dteFisTarihi), "01/01/1900", 0, 0, dr_shareket("sAciklama"), 0, 0, "", dr_shareket("sDovizCinsi1"), dr_shareket("lDovizMiktari1"), dr_shareket("lDovizKuru1"), dr_shareket("sSonKullaniciAdi"), dr_shareket("dteSonUpdateTarihi"), dr_shareket("nStokIslemID").ToString, "01/01/1900")
                siparis_fisno_degistir(nSiparisID, sMagaza)
                fis_Master_degistir(nAlisVerisID, liste & "     " & sYaziIle)
            End If
        End If
    End Sub
    Private Sub promosyon_sil(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nAlisVerisID As String, ByVal sYaziIle As String, ByVal sMagazaKodu As String)
        Dim nIslemID As Int64 = 0
        Dim nSiparisID As Int64 = 0
        If Trim(sFisTipi).ToString = "K" Or Trim(sFisTipi).ToString = "P" Then
            detay_kaydet_sil(nAlisVerisID)
            'fis_Master_degistir(nAlisVerisID, (sYaziIle).Substring(11, 60))
        ElseIf Trim(sFisTipi).ToString = "SK" Or Trim(sFisTipi).ToString = "SP" Then
            siparis_kaydet_sil(nAlisVerisID, sMagazaKodu)
            'fis_Master_degistir(nAlisVerisID, (sYaziIle).Substring(11, 60))
        End If
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub promosyon_degistir(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nAlisVerisID As String, ByVal sYaziIle As String, ByVal sMagazaKodu As String)
        Dim nIslemID As Int64 = 0
        Dim nSiparisID As Int64 = 0
        If Trim(sFisTipi).ToString = "K" Or Trim(sFisTipi).ToString = "P" Then
            Dim frm As New frm_stok
            frm.islemstatus = True
            Dim dr1 As DataRow
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            frm.okut = False
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                detay_kaydet_degistir(nAlisVerisID, dr1("nStokID"))
                fis_Master_degistir(nAlisVerisID, "")
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
            dr1 = Nothing
        ElseIf Trim(sFisTipi).ToString = "SK" Or Trim(sFisTipi).ToString = "SP" Then
            Dim frm As New frm_stok
            frm.islemstatus = True
            Dim dr1 As DataRow
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            frm.okut = False
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                siparis_kaydet_degistir(nAlisVerisID, dr1("nStokID"), sMagazaKodu)
                fis_Master_degistir(nAlisVerisID, "")
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
            dr1 = Nothing
        End If
    End Sub
    Public Function sorgu_promosyon_sayisi(ByVal sFisTipi As String, ByVal nGirisCikis As Int64, ByVal nAlisVerisID As String, ByVal nMusteriID As Int64, ByVal sFiyatTipi As String, Optional ByVal kredili As Boolean = True) As Int64
        Dim kriter
        'kriter = "WHERE (nMusteriID = '" & nMusteriID & "') and  (sFisTipi = '" & sFisTipi & "') AND (nGirisCikis = " & nGirisCikis & ") AND (nAlisverisID = '" & nAlisVerisID & "') AND (sFiyatTipi = '" & sFiyatTipi & "') "
        'kriter = "WHERE (nMusteriID = '" & nMusteriID & "') AND (nGirisCikis = " & nGirisCikis & ") AND (nAlisverisID = '" & nAlisVerisID & "') AND (sFiyatTipi = '" & sFiyatTipi & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If kredili = True Then
            kriter = "WHERE (nMusteriID = '" & nMusteriID & "') and  (sFisTipi = '" & sFisTipi & "') AND (nGirisCikis = " & nGirisCikis & ") AND (nAlisverisID = '" & nAlisVerisID & "') AND (sFiyatTipi = '" & sFiyatTipi & "') "
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS Sayi FROM         tbStokFisiDetayi " & kriter & "")
        Else
            kriter = "WHERE (nGirisCikis = " & nGirisCikis & ") AND (nAlisverisID = '" & nAlisVerisID & "') AND (sFiyatTipi = '" & sFiyatTipi & "') "
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS Sayi FROM         tbAlisVerisSiparis " & kriter & "")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
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
    Private Function sorgu_promosyon_stok_info(ByVal liste As String, ByVal magaza As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * FROM (SELECT Hareket.STOKNO , Hareket.STOKKODU , Hareket.MALINCINSI , Hareket.BARCODE , Hareket.RENK , Hareket.ETIKET , Hareket.MIKTAR , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Hareket.StokNo = tbStokFisiDetayi.nStokID AND sDepo = '" & magaza & "') AS Mevcut , (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (sDepo = '" & magaza & "') AND (stok.sKodu = hareket.STOKKODU) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY stok.sKodu ) AS Bekleyen FROM ASTOKETIKETTALEPDETAY Hareket INNER JOIN ASTOKETIKETTALEPBASLIK Baslik ON Hareket.EVRAKNO = Baslik.IND WHERE (Baslik.DEPO = '" & magaza & "') AND (Baslik.KOD2 like  '" & liste & "%')) T WHERE (ISNULL(Mevcut,0) - ISNULL(Bekleyen, 0) > 0) ORDER BY CAST(ETIKET as INT), STOKKODU")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
    End Function
    Private Sub dataload_fis_detay(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nMusteriID As String, ByVal nAlisVerisID As String)
        Dim kriter
        kriter = " WHERE (tbStokFisiDetayi.nAlisVerisID = '" & nAlisVerisID & "') and (tbStokFisiDetayi.sFisTipi = '" & sFistipi & "') and (tbStokFisiDetayi.dteFisTarihi = '" & dteFisTarihi & "') and (tbStokFisiDetayi.lFisNo = '" & lFisno & "') and (tbStokFisiDetayi.nMusteriID= '" & nMusteriID & "') and (tbStokFisiDetayi.nGirisCikis = '" & nGirisCikis & "')  "
        ds_stok_fisi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 tbStokFisiDetayi.*, tbStok.sKodu FROM         tbStokFisiDetayi INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & " Order by tbStokFisiDetayi.nIslemID DESC "))
    End Sub
    Private Sub dataload_siparis(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nMusteriID As String, ByVal nAlisVerisID As String)
        Dim kriter
        kriter = " WHERE (nAlisVerisID = '" & nAlisVerisID & "') "
        ds_stok_fisi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 *  FROM tbAlisVerisSiparis " & kriter & " Order by nSiparisID DESC "))
    End Sub
    Private Sub detay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As String, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", '" & nSiparisID & "', '" & nReceteNo & "', '" & nTransferID & "', '" & sTransferDepo & "', " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", '" & nTransferFirmaID & "',  '" & nAlisverisID & "', '" & nStokFisiID & "', '" & nIrsaliyeFisiID & "', '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi (nIslemID, nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID,  nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nIslemID & " ,'" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "',  NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID,  nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "',  NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub detay_kaydet_sil(ByVal nAlisVerisID As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') and sFiyatTipi ='Pr'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub detay_kaydet_degistir(ByVal nAlisVerisID As String, ByVal nStokID As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFisiDetayi SET              nStokID = '" & nStokID & "' WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (sFiyatTipi = 'Pr') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub siparis_kaydet_yeni(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As String, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBruttFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Int64, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Integer, ByVal bMuhasebeyeIslendimi As Integer, ByVal sAciklama As String, ByVal bEkSoru As Integer, ByVal bEkAlan1 As Integer, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal nStokIslemID As String, ByVal dteOnayTarihi As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbAlisverisSiparis                       (nAlisverisID, sMagazaKodu, nSiparisID, nGirisCikis, nStokID, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, lReyonFisNo, sFiyatTipi, lGCMiktar, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, nKdvOrani, sIadeNedeni, nPartiID, dteTeslimEdilecek, dteTeslimEdilen, bTeslimEdildi, bMuhasebeyeIslendimi, sAciklama, bEkSoru, bEkAlan1, bEkAlan2, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sSonKullaniciAdi, dteSonUpdateTarihi, nStokIslemID, dteOnayTarihi) VALUES ('" & nAlisverisID & "', '" & sMagazaKodu & "', " & nSiparisID & ", " & nGirisCikis & ", " & nStokID & ", '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & lReyonFisNo & "', '" & sFiyatTipi & "', " & lGCMiktar & ", " & lBruttFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", " & lFiyat & ", " & lTutar & ", " & nKdvOrani & ", '" & sIadeNedeni & "', " & nPartiID & ", '" & dteTeslimEdilecek & "', '" & dteTeslimEdilen & "'," & bTeslimEdildi & ", " & bMuhasebeyeIslendimi & ", N'" & sAciklama & "'," & bEkSoru & ", " & bEkAlan1 & ", '" & bEkAlan2 & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', NULL, '" & dteOnayTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub siparis_kaydet_sil(ByVal nAlisverisID As String, ByVal sMagazaKodu As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM tbAlisVerisSiparis WHERE     (nAlisverisID = '" & nAlisverisID & "') and sFiyatTipi ='Pr' and sMagazaKodu ='" & sMagazaKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub siparis_kaydet_degistir(ByVal nAlisverisID As String, ByVal nStokID As String, ByVal sMagazaKodu As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbAlisVerisSiparis SET              nStokID = '" & nStokID & "' WHERE     (nAlisverisID = '" & nAlisverisID & "') AND (sFiyatTipi = 'Pr') AND sMagazaKodu ='" & sMagazaKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub fis_Master_degistir(ByVal nAlisVerisID As String, ByVal aciklama As String)
        Dim kriter
        kriter = "WHERE nAlisVerisID = '" & nAlisVerisID & "'  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisVeris SET sYaziIle= '" & aciklama & "'+ sYaziIle          " & kriter & "")
        cmd.ExecuteNonQuery()
        con.Close()
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
        con.Close()
    End Sub
    Private Sub siparis_fisno_degistir(ByVal nSiparisID As String, ByVal sMagaza As String)
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVSiraNo SET              nSonID = '" & nSiparisID & "' where nSiraIndex = 5 and sDepo = '" & sMagaza & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokFisiID+1,0) AS nStokFisiID FROM         tbStokFisiMaster " & kriter & " Order by nStokFisiID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    'Public Function sorgu_nSiparisID(ByVal sMagaza As String) As Int64
    '    Dim kriter = " WHERE sMagazaKodu = '" & sMagaza & "' "
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    conn.ConnectionString = connection
    '    cmd.Connection = conn
    '    conn.Open()
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nSiparisID+1,0) AS nSiparisID FROM         tbAlisVerisSiparis " & kriter & " Order by nSiparisID DESC")
    '    Dim kayitsayisi = cmd.ExecuteScalar
    '    Return kayitsayisi
    'End Function
    Public Function sorgu_nSiparisID(ByVal sMagaza As String) As Int64
        Dim kriter = " WHERE sMagazaKodu = '" & sMagaza & "' "
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nSiparisID), 0) + 1 AS nSiparisID FROM         tbAlisverisSiparis " & kriter & " ")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nSonID, 0) + 1 AS nSonID FROM         tbAVSiraNo WHERE     (nSiraIndex = 5) AND (sDepo = '" & sMagaza & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_taksitler_kalanli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") ")
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
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT  ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY  tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
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
        cmd.CommandTimeout = False
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
        cmd.CommandTimeout = False
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
        cmd.CommandTimeout = False
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
        cmd.CommandTimeout = False
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
        cmd.CommandTimeout = False
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
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(GECIKMIS),0) AS GECIKMIS FROM (SELECT Musteri_TanimlamaNo AS nMusteriID , COUNT(*) AS GECIKMIS , 0 AS ERKEN , 0 AS GUNUNDE FROM vwMusteriOdemeleri WHERE  (Odeme_tutar > 0) AND (Musteri_TanimlamaNo = " & musterino & ") AND (nFarkErken = 0) AND (NFarkGecikmis = 0) GROUP BY Musteri_TanimlamaNo ) T GROUP BY nMusteriID")
        sayi = cmd.ExecuteScalar
        conn.Close()
        Return sayi
        sayi = Nothing
    End Function
    Public Function sorgu_satislar_detayli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi, dteFaturaTarihi, nGirisCikis, lToplamMiktar, lNetTutar,lPesinat  FROM         tbAlisVeris  WHERE     (nMusteriID = " & musterino & ") ORDER BY dteFaturaTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
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
            dataload(Today, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue)
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
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub frm_kasiyer_stok_fiyatlandir_liste_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If Trim(kasiyerno) <> "" Then
        '    Dim sayi As Int64
        '    sayi = kayit_kontrol()
        '    If sayi = 0 Then
        '        e.Cancel = True
        '        Me.Hide()
        '    ElseIf sayi = 1 Then
        '        XtraMessageBox.Show(Sorgu_sDil("Bekleyen Ýþlemleriniz Var...Lütfen Bekleyiniz...!")
        '        e.Cancel = True
        '    End If
        'End If
        e.Cancel = True
        Me.Hide()
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
                    dataload(Today, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue)
                End If
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "AL" Then
                If XtraMessageBox.Show(dr("StokKodu") & Sorgu_sDil("  Kodlu Stoðun Fiyatýný Eski Fiyatý Ýle Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("eFiyat"))
                    duzelt2(dr("IND"), Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dataload(Today, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue)
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
            Dim ds As New TfrxUserDataSetClass
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
                qr_hareket.Query = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         vwParekendeOdeme WHERE     (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')")
                frx.SetVariable("BelgeTipi", "'Tahsilat'")
            ElseIf Trim(izahat) = "K" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Kredili Satýþ Ýade/Deðiþim'")
                End If
            ElseIf Trim(izahat) = "P" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Peþin Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Peþin Satýþ Ýade/Deðiþim'")
                End If
            ElseIf Trim(izahat) = "SP" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peþin Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Peþin Satýþ Ýade/Deðiþim'")
                End If
            ElseIf Trim(izahat) = "SK" Then
                qr_hareket = frx.FindObject("qr_musteri")
                qr_hareket.Query = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')")
                If miktar > 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satýþ'")
                ElseIf miktar < 0 Then
                    frx.SetVariable("BelgeTipi", "'Sonradan Teslim Kredili Satýþ Ýade/Deðiþim'")
                End If
            End If
            '        qr_hareket = frx.FindObject("qr_musteri")
            '       qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu, (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) AS MUSTERI,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbMusteri.sAciklama1, tbMusteri.sAciklama2, tbMusteri.sAciklama3, tbMusteri.sAciklama4, tbMusteri.sAciklama5, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteriSinifi.sSinifKodu1 AS KOD1, tbMusteriSinifi.sSinifKodu2 AS KOD2, tbMusteriSinifi.sSinifKodu3 AS KOD3, tbMusteriSinifi.sSinifKodu4 AS KOD4, tbMusteriSinifi.sSinifKodu5 AS KOD5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID Where TbMusteri.nMusteriID =" & musterino & " Order By TbMusteri.lKodu")
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
                        frx.PrintOptions.Printer = adi
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
                frx.PrintOptions.Printer = sPrinter_Depo
                status = 1
            Else
                If adi.ToString <> "" Then
                    frx.PrintOptions.Printer = adi
                End If
            End If
            'If status <> 2 Then
            '    If sec_goster.Checked = True Then
            '        status = 0
            '    ElseIf sec_goster.Checked = False Then
            '        status = 1
            '    End If
            'End If
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                'frx.OldStyleProgress = True
                'frx.PrepareReport(True)
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
                args(2) = "" & sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         vwParekendeOdeme WHERE     (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')") & ""
                args(44) = "BelgeTipi"
                args(45) = "'Tahsilat'"
            ElseIf Trim(izahat) = "K" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Kredili Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Kredili Satýþ Ýade/Deðiþim'"
                End If
            ElseIf Trim(izahat) = "P" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Peþin Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Peþin Satýþ Ýade/Deðiþim'"
                End If
            ElseIf Trim(izahat) = "SP" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Peþin Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Peþin Satýþ Ýade/Deðiþim'"
                End If
            ElseIf Trim(izahat) = "SK" Then
                args(3) = "qr_musteri"
                args(2) = "" & sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeSiparis WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')") & ""
                If miktar > 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Kredili Satýþ'"
                ElseIf miktar < 0 Then
                    args(44) = "BelgeTipi"
                    args(45) = "'Sonradan Teslim Kredili Satýþ Ýade/Deðiþim'"
                End If
            End If
            Dim ara As String
            Try
                ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
            Catch ex As Exception
                ara = ""
            End Try
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
                End If
            End If
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
                    If status <> 2 Then
                        If sec_goster.Checked = True Then
                            status = 0
                        ElseIf sec_goster.Checked = False Then
                            status = 1
                        End If
                    End If
                End If
            End If
            args(4) = "" & status.ToString() & ""
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
        SimpleButton5.Text = "&Yazdir"
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
            ds_TOPLAM = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sum(tutari) as nToplamTutar FROM vwParekendeOdeme WHERE (MakbuzNo = " & belgeno & ") AND (Fis_Musteri_Kodu = " & musterikodu & ") "), "TOPLAM")
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         vwParekendeOdeme WHERE     (MakbuzNo = '" & belgeno & "') AND (Tarihi = '" & tarih & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "')"), "TAHSILAT")
            report.RegisterData(ds_HAREKET)
            report.RegisterData(ds_TOPLAM)
            report.SetParameterValue("BelgeTipi", "Tahsilat")
        ElseIf Trim(izahat) = "K" Then
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')"), "HAREKET")
            ds_Taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbTaksit WHERE (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
            report.RegisterData(ds_HAREKET)
            report.RegisterData(ds_Taksit)
            If miktar > 0 Then
                report.SetParameterValue("BelgeTipi", "Kredili Satýþ")
            ElseIf miktar < 0 Then
                report.SetParameterValue("BelgeTipi", "Kredili Satýþ Ýade/Deðiþim")
            End If
        ElseIf Trim(izahat) = "P" Then
            ds_HAREKET = sorgu(sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         vwParekendeFatura WHERE     (Fis_dteFaturaTarihi = '" & tarih & "') AND (Fis_No = '" & belgeno & "') AND (Fis_Musteri_Kodu = '" & musterikodu & "') AND (Fis_Tipi = '" & izahat & "')"), "HAREKET")
            ds_Taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbTaksit WHERE (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID "), "Taksitlendirme")
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
        taksit_kontrol_satirlar()
        raporla(1)
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
        yazdir()
    End Sub
    Sub yazdir()
        If GridView1.RowCount > 0 Then
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If SimpleButton5.Text = "&Durdur" Then
                'StopSearch()
                SimpleButton5.Text = "&Yazdir"
            Else
                SimpleButton5.Text = "&Durdur"
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr("STATUS") = "False" Then
                    If sec_analiz.Checked = True Then
                        If sorgula_Decimal("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisverisID),0) AS nKayit FROM         tbAlisVeris Where nMusteriID = " & dr("nMusteriID") & "") <= 50 Then
                            taksit_kontrol_satirlar()
                        End If
                    End If
                    raporla(0)
                Else
                    raporla(0)
                End If
            End If
            Cursor.Current = Cursors.Default
            Cursor.Hide()
            'StopSearch()
            SimpleButton5.Text = "&Yazdir"
        End If
        SimpleButton5.Text = "&Yazdir"
    End Sub
    Public Sub BeginSearch()
        If IsHandleCreated Then
            _searchThread = New Thread(New ThreadStart(AddressOf yazdir))
            _searching = True
            _searchThread.Start()
        Else
            _deferSearch = True
        End If
    End Sub
    Public Sub StopSearch()
        If Not _searching Then
            Return
        End If
        If _searchThread.IsAlive Then
            _searchThread.Abort()
            _searchThread.Join()
        End If
        _searchThread = Nothing
        _searching = False
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        ara()
    End Sub
    Private Sub ara()
        If IsNumeric(Trim(txt_musterino.Text)) = True Or Trim(txt_musterino.Text) = "" Then
            Label5.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
            Label5.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            dataload(DateEdit1.EditValue, kasiyerno, txt_musterino.EditValue, txt_belgeno.EditValue)
            Label5.Text = Sorgu_sDil("Tamamlandý...", sDil)
            Label5.Refresh()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Sayýsal Veri Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
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
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_isim.Text = dr("ADI").ToString & " " & dr("SOYADI").ToString
            Dim gun_evlilik As String = ""
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
        Else
            Label5.Text = "*"
        End If
        If GridView1.SelectedRowsCount > 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label5.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label5.Text = ""
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If Trim(kasiyerno) = "VC" Then
            anons()
        ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "AL" Then
            anons()
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
    Private Sub stok_satis_detay()
        Dim frm As New frm_stok_cari_satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
                stok_satis_detay()
            End If
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
    Private Sub kampanya()
        Dim frm As New frm_kasiyer_dokum_kampanya
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub anons()
        Dim frm As New frm_kasiyer_dokum_anons
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If Trim(kasiyerno) = "VC" Then
            kampanya()
        ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "EA" Or Trim(kasiyerno) = "AL" Then
            kampanya()
        End If
    End Sub
    Private Sub txt_musterino_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonPressed
        'musteri()
    End Sub
    Private Sub musteri()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_musterino.Text = dr1("lKodu")
        End If
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.F6 Then
            musteri()
        ElseIf e.KeyCode = Keys.Enter Then
            ara()
        End If
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri()
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
        frm.txt_takip_aciklama.Text = "AlýþVeriþ Listesi..."
        frm.status = True
        frm.kullanici = kullanici
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
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        takibe_al()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr("STATUS") = "False" Then
            taksit_kontrol_satirlar()
            takibe_al(True)
        Else
            takibe_al(True)
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If bOtomatikHediye = True Then
                promosyon_kontrol_belge()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_hediye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hediye.Click
        XtraMessageBox.Show(Sorgu_sDil("Hazýr Deðil", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Belgeye Hediye Uygulamasýný Ýptal Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            fis_Master_degistir(dr("ALISVERISNO"), "HI ")
            dr = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Belgenin Hediyesini Ýptal Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            promosyon_sil(Trim(dr("IZAHAT")), dr("TARIH"), dr("ALISVERISNO"), dr("YAZI"), dr("MAGAZA"))
            dr = Nothing
        End If
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Belgenin Hediyesini Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            promosyon_degistir(Trim(dr("IZAHAT")), dr("TARIH"), dr("ALISVERISNO"), dr("YAZI"), dr("MAGAZA"))
            dr = Nothing
        End If
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            'dataload()
            'sec_resmi1.Checked = False
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            'dataload()
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
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
    End Sub
    Private Sub sec_to_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_to.CheckStateChanged
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("TermalOdeme", sec_to.Checked)
    End Sub
    Private Sub sec_ts_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_ts.CheckStateChanged
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("TermalSatis", sec_ts.Checked)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F3 Then
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub SimpleButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            sPrinter_Depo = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterDepo").ToString
        Catch ex As Exception
            sPrinter_Depo = ""
        End Try
        If sPrinter_Depo <> "" Then
            raporla(0, True)
        Else
            raporla(0)
        End If
    End Sub
    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class
