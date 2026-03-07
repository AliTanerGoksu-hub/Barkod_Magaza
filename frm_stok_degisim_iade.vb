Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_degisim_iade
    Inherits DevExpress.XtraEditors.XtraForm
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem

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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
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
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOYADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_FISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_FISTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_STOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_STOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_MALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_FIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_TUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_DEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_ODEME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_KASIYER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_SATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE_ACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_FISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_FISTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_STOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_STOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_MALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_FIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_TUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_DEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_ODEME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_KASIYER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_SATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_ACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents colGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFARK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_degisim_iade))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colFARK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOYADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_FISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_FISTIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_STOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_STOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_MALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_FIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_TUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_DEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_ODEME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_KASIYER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_SATICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE_ACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_FISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_FISTIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_STOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_STOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_MALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_FIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_TUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_DEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_ODEME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_KASIYER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_SATICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_ACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colFARK
        '
        Me.colFARK.Caption = "Fark"
        Me.colFARK.DisplayFormat.FormatString = "#,0.00"
        Me.colFARK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFARK.FieldName = "FARK"
        Me.colFARK.Name = "colFARK"
        Me.colFARK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FARK", "{0:#,0.00}")})
        Me.colFARK.Visible = True
        Me.colFARK.VisibleIndex = 12
        Me.colFARK.Width = 109
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 52)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ýade Deðiþim Ýþlemleri Listesi Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 362)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 43)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(96, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 9)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Ara F3"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 52)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 310)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 306)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panelstatus)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 273)
        Me.XtraTabPage1.Text = "Kartlar..."
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
        Me.Panelstatus.Location = New System.Drawing.Point(138, 83)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(542, 106)
        Me.Panelstatus.TabIndex = 10
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(10, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(518, 18)
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
        Me.bar.Size = New System.Drawing.Size(518, 18)
        Me.bar.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(818, 273)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37})
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
        Me.DataColumn3.ColumnName = "FIRMAKODU"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FIRMAADI"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ADI"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "SOYADI"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "IADE_FISNO"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "IADE_FISTIPI"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "IADE_STOKNO"
        Me.DataColumn9.DataType = GetType(Long)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "IADE_STOKKODU"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "IADE_MALINCINSI"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "IADE_MIKTAR"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "IADE_FIYAT"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "IADE_TUTAR"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "IADE_DEPO"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "IADE_ODEME"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "IADE_KASIYER"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "IADE_SATICI"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "IADE_ACIKLAMA"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "SATIS_FISNO"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "SATIS_FISTIPI"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "SATIS_STOKNO"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "SATIS_STOKKODU"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "SATIS_MALINCINSI"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "SATIS_MIKTAR"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "SATIS_FIYAT"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "SATIS_TUTAR"
        Me.DataColumn27.DataType = GetType(Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "SATIS_DEPO"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "SATIS_ODEME"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "SATIS_KASIYER"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "SATIS_SATICI"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "SATIS_ACIKLAMA"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "GIRIS"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sFiyatTipi"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "FIYAT"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "TUTAR"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "FARK"
        Me.DataColumn37.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colTARIH, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colADI, Me.colSOYADI, Me.colIADE_FISNO, Me.colIADE_FISTIPI, Me.colIADE_STOKNO, Me.colIADE_STOKKODU, Me.colIADE_MALINCINSI, Me.colIADE_MIKTAR, Me.colIADE_FIYAT, Me.colIADE_TUTAR, Me.colIADE_DEPO, Me.colIADE_ODEME, Me.colIADE_KASIYER, Me.colIADE_SATICI, Me.colIADE_ACIKLAMA, Me.colSATIS_FISNO, Me.colSATIS_FISTIPI, Me.colSATIS_STOKNO, Me.colSATIS_STOKKODU, Me.colSATIS_MALINCINSI, Me.colSATIS_MIKTAR, Me.colSATIS_FIYAT, Me.colSATIS_TUTAR, Me.colSATIS_DEPO, Me.colSATIS_ODEME, Me.colSATIS_KASIYER, Me.colSATIS_SATICI, Me.colSATIS_ACIKLAMA, Me.colGIRIS, Me.GridColumn2, Me.colFIYAT, Me.colTUTAR, Me.colFARK})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(551, 279, 208, 249)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colFARK
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colFARK
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADE_MIKTAR", Me.colIADE_MIKTAR, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADE_TUTAR", Me.colIADE_TUTAR, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SATIS_MIKTAR", Me.colSATIS_MIKTAR, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SATIS_TUTAR", Me.colSATIS_TUTAR, "{0:#,0.##}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
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
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 64
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Hesap Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 1
        Me.colFIRMAKODU.Width = 62
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Müþteri"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 2
        Me.colFIRMAADI.Width = 142
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
        'colIADE_FISNO
        '
        Me.colIADE_FISNO.Caption = "ÝadeFiþNo"
        Me.colIADE_FISNO.FieldName = "IADE_FISNO"
        Me.colIADE_FISNO.Name = "colIADE_FISNO"
        '
        'colIADE_FISTIPI
        '
        Me.colIADE_FISTIPI.Caption = "ÝadeFiþTipi"
        Me.colIADE_FISTIPI.FieldName = "IADE_FISTIPI"
        Me.colIADE_FISTIPI.Name = "colIADE_FISTIPI"
        '
        'colIADE_STOKNO
        '
        Me.colIADE_STOKNO.Caption = "ÝadeStokNo"
        Me.colIADE_STOKNO.FieldName = "IADE_STOKNO"
        Me.colIADE_STOKNO.Name = "colIADE_STOKNO"
        '
        'colIADE_STOKKODU
        '
        Me.colIADE_STOKKODU.Caption = "ÝadeStokKodu"
        Me.colIADE_STOKKODU.FieldName = "IADE_STOKKODU"
        Me.colIADE_STOKKODU.Name = "colIADE_STOKKODU"
        '
        'colIADE_MALINCINSI
        '
        Me.colIADE_MALINCINSI.Caption = "ÝadeStokAdý"
        Me.colIADE_MALINCINSI.FieldName = "IADE_MALINCINSI"
        Me.colIADE_MALINCINSI.Name = "colIADE_MALINCINSI"
        '
        'colIADE_MIKTAR
        '
        Me.colIADE_MIKTAR.Caption = "ÝadeMiktar"
        Me.colIADE_MIKTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colIADE_MIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIADE_MIKTAR.FieldName = "IADE_MIKTAR"
        Me.colIADE_MIKTAR.Name = "colIADE_MIKTAR"
        Me.colIADE_MIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADE_MIKTAR", "{0:#,0.##}")})
        '
        'colIADE_FIYAT
        '
        Me.colIADE_FIYAT.Caption = "ÝadeFiyat"
        Me.colIADE_FIYAT.DisplayFormat.FormatString = "#,0.##"
        Me.colIADE_FIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIADE_FIYAT.FieldName = "IADE_FIYAT"
        Me.colIADE_FIYAT.Name = "colIADE_FIYAT"
        '
        'colIADE_TUTAR
        '
        Me.colIADE_TUTAR.Caption = "Ýade Tutar"
        Me.colIADE_TUTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colIADE_TUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIADE_TUTAR.FieldName = "IADE_TUTAR"
        Me.colIADE_TUTAR.Name = "colIADE_TUTAR"
        Me.colIADE_TUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IADE_TUTAR", "{0:#,0.##}")})
        '
        'colIADE_DEPO
        '
        Me.colIADE_DEPO.Caption = "ÝadeDepo"
        Me.colIADE_DEPO.FieldName = "IADE_DEPO"
        Me.colIADE_DEPO.Name = "colIADE_DEPO"
        '
        'colIADE_ODEME
        '
        Me.colIADE_ODEME.Caption = "ÝadeOdeme"
        Me.colIADE_ODEME.FieldName = "IADE_ODEME"
        Me.colIADE_ODEME.Name = "colIADE_ODEME"
        '
        'colIADE_KASIYER
        '
        Me.colIADE_KASIYER.Caption = "ÝadeKasiyer"
        Me.colIADE_KASIYER.FieldName = "IADE_KASIYER"
        Me.colIADE_KASIYER.Name = "colIADE_KASIYER"
        '
        'colIADE_SATICI
        '
        Me.colIADE_SATICI.Caption = "ÝadeSatýcý"
        Me.colIADE_SATICI.FieldName = "IADE_SATICI"
        Me.colIADE_SATICI.Name = "colIADE_SATICI"
        '
        'colIADE_ACIKLAMA
        '
        Me.colIADE_ACIKLAMA.Caption = "ÝadeAçýklama"
        Me.colIADE_ACIKLAMA.FieldName = "IADE_ACIKLAMA"
        Me.colIADE_ACIKLAMA.Name = "colIADE_ACIKLAMA"
        '
        'colSATIS_FISNO
        '
        Me.colSATIS_FISNO.Caption = "SatýþFiþNo"
        Me.colSATIS_FISNO.FieldName = "SATIS_FISNO"
        Me.colSATIS_FISNO.Name = "colSATIS_FISNO"
        Me.colSATIS_FISNO.Visible = True
        Me.colSATIS_FISNO.VisibleIndex = 3
        Me.colSATIS_FISNO.Width = 56
        '
        'colSATIS_FISTIPI
        '
        Me.colSATIS_FISTIPI.Caption = "SatýþFiþTipi"
        Me.colSATIS_FISTIPI.FieldName = "SATIS_FISTIPI"
        Me.colSATIS_FISTIPI.Name = "colSATIS_FISTIPI"
        Me.colSATIS_FISTIPI.Visible = True
        Me.colSATIS_FISTIPI.VisibleIndex = 4
        Me.colSATIS_FISTIPI.Width = 63
        '
        'colSATIS_STOKNO
        '
        Me.colSATIS_STOKNO.Caption = "SatýþStokNo"
        Me.colSATIS_STOKNO.FieldName = "SATIS_STOKNO"
        Me.colSATIS_STOKNO.Name = "colSATIS_STOKNO"
        '
        'colSATIS_STOKKODU
        '
        Me.colSATIS_STOKKODU.Caption = "SatýþStokKodu"
        Me.colSATIS_STOKKODU.FieldName = "SATIS_STOKKODU"
        Me.colSATIS_STOKKODU.Name = "colSATIS_STOKKODU"
        '
        'colSATIS_MALINCINSI
        '
        Me.colSATIS_MALINCINSI.Caption = "SatýþMalýnCinsi"
        Me.colSATIS_MALINCINSI.FieldName = "SATIS_MALINCINSI"
        Me.colSATIS_MALINCINSI.Name = "colSATIS_MALINCINSI"
        Me.colSATIS_MALINCINSI.Visible = True
        Me.colSATIS_MALINCINSI.VisibleIndex = 5
        Me.colSATIS_MALINCINSI.Width = 87
        '
        'colSATIS_MIKTAR
        '
        Me.colSATIS_MIKTAR.Caption = "SatýþMiktar"
        Me.colSATIS_MIKTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colSATIS_MIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSATIS_MIKTAR.FieldName = "SATIS_MIKTAR"
        Me.colSATIS_MIKTAR.Name = "colSATIS_MIKTAR"
        Me.colSATIS_MIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SATIS_MIKTAR", "{0:#,0.##}")})
        Me.colSATIS_MIKTAR.Visible = True
        Me.colSATIS_MIKTAR.VisibleIndex = 6
        Me.colSATIS_MIKTAR.Width = 87
        '
        'colSATIS_FIYAT
        '
        Me.colSATIS_FIYAT.Caption = "SatýþFiyat"
        Me.colSATIS_FIYAT.DisplayFormat.FormatString = "#,0.##"
        Me.colSATIS_FIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSATIS_FIYAT.FieldName = "SATIS_FIYAT"
        Me.colSATIS_FIYAT.Name = "colSATIS_FIYAT"
        Me.colSATIS_FIYAT.Visible = True
        Me.colSATIS_FIYAT.VisibleIndex = 7
        Me.colSATIS_FIYAT.Width = 87
        '
        'colSATIS_TUTAR
        '
        Me.colSATIS_TUTAR.Caption = "SatýþTutar"
        Me.colSATIS_TUTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colSATIS_TUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSATIS_TUTAR.FieldName = "SATIS_TUTAR"
        Me.colSATIS_TUTAR.Name = "colSATIS_TUTAR"
        Me.colSATIS_TUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SATIS_TUTAR", "{0:#,0.##}")})
        Me.colSATIS_TUTAR.Visible = True
        Me.colSATIS_TUTAR.VisibleIndex = 8
        Me.colSATIS_TUTAR.Width = 87
        '
        'colSATIS_DEPO
        '
        Me.colSATIS_DEPO.Caption = "SatýþDepo"
        Me.colSATIS_DEPO.FieldName = "SATIS_DEPO"
        Me.colSATIS_DEPO.Name = "colSATIS_DEPO"
        '
        'colSATIS_ODEME
        '
        Me.colSATIS_ODEME.Caption = "SatýþÖdeme"
        Me.colSATIS_ODEME.FieldName = "SATIS_ODEME"
        Me.colSATIS_ODEME.Name = "colSATIS_ODEME"
        '
        'colSATIS_KASIYER
        '
        Me.colSATIS_KASIYER.Caption = "SatýþKasiyer"
        Me.colSATIS_KASIYER.FieldName = "SATIS_KASIYER"
        Me.colSATIS_KASIYER.Name = "colSATIS_KASIYER"
        '
        'colSATIS_SATICI
        '
        Me.colSATIS_SATICI.Caption = "SatýþSatýcý"
        Me.colSATIS_SATICI.FieldName = "SATIS_SATICI"
        Me.colSATIS_SATICI.Name = "colSATIS_SATICI"
        '
        'colSATIS_ACIKLAMA
        '
        Me.colSATIS_ACIKLAMA.Caption = "SatýþAçýklama"
        Me.colSATIS_ACIKLAMA.FieldName = "SATIS_ACIKLAMA"
        Me.colSATIS_ACIKLAMA.Name = "colSATIS_ACIKLAMA"
        '
        'colGIRIS
        '
        Me.colGIRIS.Caption = "Giriþ"
        Me.colGIRIS.FieldName = "GIRIS"
        Me.colGIRIS.Name = "colGIRIS"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "FiyatTipi"
        Me.GridColumn2.FieldName = "sFiyatTipi"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 9
        Me.GridColumn2.Width = 87
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT.FieldName = "FIYAT"
        Me.colFIYAT.Name = "colFIYAT"
        Me.colFIYAT.Visible = True
        Me.colFIYAT.VisibleIndex = 10
        Me.colFIYAT.Width = 87
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 11
        Me.colTUTAR.Width = 87
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PivotGridControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(818, 273)
        Me.XtraTabPage2.Text = "Analiz"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataMember = Nothing
        Me.PivotGridControl1.DataSource = Me.DataSet1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(818, 273)
        Me.PivotGridControl1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem29, Me.MenuItem30, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem28, Me.MenuItem12, Me.MenuItem19, Me.MenuItem27, Me.MenuItem5, Me.MenuItem6, Me.MenuItem20, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem26, Me.MenuItem21, Me.MenuItem25, Me.MenuItem18, Me.MenuItem17, Me.MenuItem4})
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
        'MenuItem29
        '
        Me.MenuItem29.Index = 2
        Me.MenuItem29.Text = "Belgeyi Göster"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 3
        Me.MenuItem30.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem1.Text = "Kalan Taksitler"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem2.Text = "Kalan Satýþlar"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 6
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem3.Text = "Yapýlan Ödemeler"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 7
        Me.MenuItem28.Text = "Hesap Ekstresi"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 8
        Me.MenuItem12.Text = "Satýþlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 9
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 10
        Me.MenuItem27.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 11
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem5.Text = "Envanter"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 12
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem6.Text = "Model Envanter"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 13
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem23, Me.MenuItem24})
        Me.MenuItem20.Text = "Etiket"
        Me.MenuItem20.Visible = False
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Text = "Etiket Önizle"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Etiket Dizayn"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem24.Text = "Etiket Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 14
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 15
        Me.MenuItem7.Text = "Görünümü Düzelt"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 16
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 17
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 18
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 19
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 20
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 21
        Me.MenuItem26.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 22
        Me.MenuItem21.Text = "Satýrlarý Aç"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 23
        Me.MenuItem25.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 24
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 25
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem17.Text = "Tam Ekran"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 26
        Me.MenuItem4.Text = "Ekstre"
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
        Me.printlink1.Landscape = True
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(60, 60, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Ýade / Deðiþim Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Ýade/Deðiþim Ýþlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Envanter,F6"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Musteri Karti,F4"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Satýþlar"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Odemeler"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kalan Borcu"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Excel"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Text"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Mail"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.Name = "BarButtonItem12"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 405)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 405)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 405)
        '
        'frm_stok_degisim_iade
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_degisim_iade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ýade/Deðiþim Kontrol"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public stokkodu
    Public malincinsi
    Public barkod
    Public muadilbarkod
    Public birim
    Public kod1
    Public kod2
    Public kod3
    Public kod4
    Public kod5
    Public kod6
    Public kod7
    Public kod8
    Public kod9
    Public kod10
    Public satisfiyati1
    Public satisfiyati2
    Public satisfiyati3
    Public istihbarat
    Public kayitno
    Public aktif
    Public sil As Boolean = False
    Public gelismis
    Public qkayitno
    Public qstokkodu
    Public qmalincinsi
    Public qbarkod
    Public qmuadilbarkod
    Public qkod1
    Public qkod2
    Public qkod3
    Public qkod4
    Public qkod5
    Public qkod6
    Public qkod7
    Public qkod8
    Public qkod9
    Public qkod10
    Public qistihbarat
    Public qbirim
    Public qdepo
    Public qsatisfiyati1
    Public qsatisfiyati2
    Public qsatisfiyati3
    Public qaktif
    Public qgelismis
    Public ilktarih
    Public sontarih
    Public ilkbelge
    Public sonbelge
    Public firmakodu
    Public firmaadi
    Public personel
    Public depo
    Public parabirimi
    Public kur
    Public aciklama
    Public kdvdahil
    Public kapali
    Public qilktarih
    Public qsontarih
    Public qilkbelge
    Public qsonbelge
    Public qfirmakodu
    Public qfirmaadi
    Public qpersonel
    Public qparabirimi
    Public qkur
    Public qaciklama
    Public qkdvdahil
    Public qkapali
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_alislar As DataSet

    Public frf_islem As String = "mektup"
    Public islemstatus As Boolean = False
    Dim ds_satis As DataSet
    Dim ds_siparis As DataSet
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If status = False Then
            count = ""
            Dim frm As New frm_fatura_ara
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                kayitno = frm.kayitno
                ilktarih = frm.ilktarih
                sontarih = frm.sontarih
                ilkbelge = frm.ilkbelge
                sonbelge = frm.sonbelge
                firmakodu = frm.firmakodu
                firmaadi = frm.firmaadi
                parabirimi = frm.parabirimi
                kur = frm.kur
                personel = frm.personel
                depo = frm.depo
                kod1 = frm.kod1
                kod2 = frm.kod2
                kdvdahil = frm.kdvdahil
                kapali = frm.kapali
                qkayitno = frm.qkayitno
                qilktarih = frm.qilktarih
                qsontarih = frm.qsontarih
                qilkbelge = frm.qilkbelge
                qsonbelge = frm.qsonbelge
                qfirmakodu = frm.qfirmakodu
                qfirmaadi = frm.qfirmaadi
                qparabirimi = frm.qparabirimi
                qkur = frm.qkur
                qpersonel = frm.qpersonel
                qdepo = frm.qdepo
                qkod1 = frm.qkod1
                qkod2 = frm.qkod2
                qkdvdahil = frm.qkdvdahil
                qkapali = frm.qkapali
                DataSet1.Clear()
                DataSet1.Dispose()
                dataload()
                'frm.DataSet1.Clear()
                'frm.DataSet1.Dispose()
                'frm.DataSet1 = Nothing
                'frm.SimpleButton1 = Nothing
                'frm.SimpleButton2 = Nothing
                'frm.PanelControl1.Dispose()
                'frm.PanelControl1 = Nothing
                'MessageBox.Show("7")
                'frm.PanelControl2.Dispose()
                'frm.PanelControl2 = Nothing
                'frm.PanelControl3.Dispose()
                'frm.PanelControl3 = Nothing
                'frm.PictureBox1.Dispose()
                'frm.PictureBox1 = Nothing
                'MessageBox.Show("8")
                'frm.VGridControl1.Dispose()
                'frm.VGridControl1 = Nothing
                'frm.XtraTabControl1.Dispose()
                'frm.XtraTabControl1 = Nothing
                'frm.XtraTabPage1.Dispose()
                'frm.XtraTabPage1 = Nothing
                'frm.Label1.Dispose()
                'MessageBox.Show("9")
                'frm.Label1 = Nothing
                'frm.Dispose()
                frm.Close()
                frm = Nothing
            Else
            End If
        End If
        'stok_islemleri.firmano = firmano
        'stok_islemleri.donemno = donemno
        'stok_islemleri.connection = connection
        If GridView1.RowCount = 0 Then
        ElseIf GridView1.RowCount = 1 Then
            'If sil = False Then
            '    sorgu()
            'End If
        Else
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_depo()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
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
    Public Function sorgu_alislar(ByVal tarih As DateTime, ByVal fisno As String, ByVal stokkodu As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.sFisTipi = 'FA') AND(tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < = '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') AND (tbStokFisiDetayi.lFisNo <> '" & fisno & "') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub ara_belge()
        Dim frm As New frm_fatura_ara
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
    End Sub
    Private Sub ara()
        Dim frm As New frm_fatura_ara
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.kayitno
            ilktarih = frm.ilktarih
            sontarih = frm.sontarih
            ilkbelge = frm.ilkbelge
            sonbelge = frm.sonbelge
            firmakodu = frm.firmakodu
            firmaadi = frm.firmaadi
            parabirimi = frm.parabirimi
            kur = frm.kur
            personel = frm.personel
            depo = frm.depo
            kod1 = frm.kod1
            kod2 = frm.kod2
            kdvdahil = frm.kdvdahil
            kapali = frm.kapali
            qkayitno = frm.qkayitno
            qilktarih = frm.qilktarih
            qsontarih = frm.qsontarih
            qilkbelge = frm.qilkbelge
            qsonbelge = frm.qsonbelge
            qfirmakodu = frm.qfirmakodu
            qfirmaadi = frm.qfirmaadi
            qparabirimi = frm.qparabirimi
            qkur = frm.qkur
            qpersonel = frm.qpersonel
            qdepo = frm.qdepo
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkdvdahil = frm.qkdvdahil
            qkapali = frm.qkapali
            DataSet1.Clear()
            DataSet1.Dispose()
            dataload()
        Else
            Me.Close()
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.SimpleButton1 = Nothing
        frm.SimpleButton2 = Nothing
        frm.PanelControl1.Dispose()
        frm.PanelControl1 = Nothing
        frm.PanelControl2.Dispose()
        frm.PanelControl2 = Nothing
        frm.PanelControl3.Dispose()
        frm.PanelControl3 = Nothing
        frm.PictureBox1.Dispose()
        frm.PictureBox1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.XtraTabControl1.Dispose()
        frm.XtraTabControl1 = Nothing
        frm.XtraTabPage1.Dispose()
        frm.XtraTabPage1 = Nothing
        frm.Label1.Dispose()
        frm.Label1 = Nothing
        frm.Dispose()
        frm.Close()
        frm = Nothing
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
    Private Sub dataload()
        dataload_depo()
        DataSet1.Clear()
        DataSet1.Dispose()
        DataSet1 = stok()
        kontrol_islemler()
        DataSet1 = sorgu_ekstre_detayli()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PivotGridControl1.DataSource = DataSet1.Tables(0)
        PivotGridControl1.DataMember = Nothing
        PivotGridControl1.RetrieveFields()
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub kontrol_islemler()
        If DataSet1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim musterino As String
            Dim kasiyerrumuzu As String
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "TRUNCATE TABLE ATBLDEGISIMIADEKONTROL"
            cmd.ExecuteNonQuery()
            con.Close()
            For Each dr In DataSet1.Tables(0).Rows
                musterino = dr("FIRMAKODU")
                kasiyerrumuzu = dr("KASIYER")
                ds_satis = sorgu_ekstre_satislar(musterino, ilktarih, sontarih, kasiyerrumuzu)
                For Each dr1 In ds_satis.Tables(0).Rows
                    If dr1("GirisCikis") = 3 Then
                        hareket_kaydet_yeni(dr1("dteTarih"), dr1("nMusteriID"), dr1("lKodu"), dr1("sMusteriAdi"), "", "", "", "", 0, "", "", 0, 0, 0, "", "", "", "", "", dr1("lNo"), dr1("fisTipi"), dr1("nStokID"), dr1("sKodu"), dr1("sStokAciklama"), dr1("Miktar"), dr1("Fiyat"), dr1("lNetTutar"), "", "", dr1("KasiyerRumuzu"), dr1("SaticiRumuzu"), "", dr1("GirisCikis"), dr1("sFiyatTipi"))
                    ElseIf dr1("GirisCikis") = 4 Then
                        hareket_kaydet_yeni(dr1("dteTarih"), dr1("nMusteriID"), dr1("lKodu"), dr1("sMusteriAdi"), "", "", "", "", 0, "", "", 0, 0, 0, "", "", "", "", "", dr1("lNo"), dr1("fisTipi"), dr1("nStokID"), dr1("sKodu"), dr1("sStokAciklama"), dr1("Miktar"), dr1("Fiyat"), dr1("lNetTutar"), "", "", dr1("KasiyerRumuzu"), dr1("SaticiRumuzu"), "", dr1("GirisCikis"), dr1("sFiyatTipi"))
                        'hareket_kaydet_yeni(dr1("dteTarih"), dr1("lKodu"), dr1("sMusteriAdi"), "", "", dr1("lNo"), dr1("fisTipi"), dr1("sKodu"), dr1("sKodu"), dr1("sStokAciklama"), dr1("Miktar"), dr1("Fiyat"), dr1("lNetTutar"), "", "", dr1("KasiyerRumuzu"), dr1("SaticiRumuzu"), "", "", "", 0, "", "", 0, 0, 0, "", "", "", "", "", dr1("GirisCikis"))
                    End If
                Next
                ds_siparis = sorgu_ekstre_siparisler(musterino, ilktarih, sontarih, kasiyerrumuzu)
                For Each dr1 In ds_siparis.Tables(0).Rows
                    If dr1("GirisCikis") = 3 Then
                        hareket_kaydet_yeni(dr1("dteTarih"), dr1("nMusteriID"), dr1("lKodu"), dr1("sMusteriAdi"), "", "", "", "", 0, "", "", 0, 0, 0, "", "", "", "", "", dr1("lNo"), dr1("fisTipi"), dr1("nStokID"), dr1("sKodu"), dr1("sStokAciklama"), dr1("Miktar"), dr1("Fiyat"), dr1("lNetTutar"), "", "", dr1("KasiyerRumuzu"), dr1("SaticiRumuzu"), "", dr1("GirisCikis"), dr1("sFiyatTipi"))
                    ElseIf dr1("GirisCikis") = 4 Then
                        hareket_kaydet_yeni(dr1("dteTarih"), dr1("nMusteriID"), dr1("lKodu"), dr1("sMusteriAdi"), "", "", "", "", 0, "", "", 0, 0, 0, "", "", "", "", "", dr1("lNo"), dr1("fisTipi"), dr1("nStokID"), dr1("sKodu"), dr1("sStokAciklama"), dr1("Miktar"), dr1("Fiyat"), dr1("lNetTutar"), "", "", dr1("KasiyerRumuzu"), dr1("SaticiRumuzu"), "", dr1("GirisCikis"), dr1("sFiyatTipi"))
                        'hareket_kaydet_yeni(dr1("dteTarih"), dr1("lKodu"), dr1("sMusteriAdi"), "", "", dr1("lNo"), dr1("fisTipi"), dr1("sKodu"), dr1("sKodu"), dr1("sStokAciklama"), dr1("Miktar"), dr1("Fiyat"), dr1("lNetTutar"), "", "", dr1("KasiyerRumuzu"), dr1("SaticiRumuzu"), "", "", "", 0, "", "", 0, 0, 0, "", "", "", "", "", dr1("GirisCikis"))
                    End If
                Next
            Next
        End If
    End Sub
    Private Function hareket_kaydet_yeni(ByVal TARIH As DateTime, ByVal nMusteriID As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal ADI As String, ByVal SOYADI As String, ByVal IADE_FISNO As String, ByVal IADE_FISTIPI As String, ByVal IADE_STOKNO As String, ByVal IADE_STOKKODU As String, ByVal IADE_MALINCINSI As String, ByVal IADE_MIKTAR As Decimal, ByVal IADE_FIYAT As Decimal, ByVal IADE_TUTAR As Decimal, ByVal IADE_DEPO As String, ByVal IADE_ODEME As String, ByVal IADE_KASIYER As String, ByVal IADE_SATICI As String, ByVal IADE_ACIKLAMA As String, ByVal SATIS_FISNO As String, ByVal SATIS_FISTIPI As String, ByVal SATIS_STOKNO As String, ByVal SATIS_STOKKODU As String, ByVal SATIS_MALINCINSI As String, ByVal SATIS_MIKTAR As Decimal, ByVal SATIS_FIYAT As Decimal, ByVal SATIS_TUTAR As Decimal, ByVal SATIS_DEPO As String, ByVal SATIS_ODEME As String, ByVal SATIS_KASIYER As String, ByVal SATIS_SATICI As String, ByVal SATIS_ACIKLAMA As String, ByVal GIRIS As Integer, ByVal sFiyatTipi As String) As Int64
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ATBLDEGISIMIADEKONTROL (TARIH, nMusteriID,FIRMAKODU, FIRMAADI, ADI, SOYADI, IADE_FISNO, IADE_FISTIPI, IADE_STOKNO, IADE_STOKKODU, IADE_MALINCINSI, IADE_MIKTAR, IADE_FIYAT, IADE_TUTAR, IADE_DEPO, IADE_ODEME, IADE_KASIYER, IADE_SATICI, IADE_ACIKLAMA, SATIS_FISNO, SATIS_FISTIPI, SATIS_STOKNO, SATIS_STOKKODU, SATIS_MALINCINSI, SATIS_MIKTAR, SATIS_FIYAT, SATIS_TUTAR, SATIS_DEPO, SATIS_ODEME, SATIS_KASIYER, SATIS_SATICI, SATIS_ACIKLAMA,GIRIS,sFiyatTipi) VALUES     ('" & TARIH & "'," & nMusteriID & " , '" & FIRMAKODU & "', '" & FIRMAADI & "', '" & ADI & "' , '" & SOYADI & "', '" & IADE_FISNO & "', '" & IADE_FISTIPI & "', '" & IADE_STOKNO & "', '" & IADE_STOKKODU & "', '" & IADE_MALINCINSI & "' , " & IADE_MIKTAR & ", " & IADE_FIYAT & " , " & IADE_TUTAR & " , '" & IADE_DEPO & "', '" & IADE_ODEME & "', '" & IADE_KASIYER & "', '" & IADE_SATICI & "', '" & IADE_ACIKLAMA & "', '" & SATIS_FISNO & "', '" & SATIS_FISTIPI & "', '" & SATIS_STOKNO & "' , '" & SATIS_STOKKODU & "', '" & SATIS_MALINCINSI & "' , " & SATIS_MIKTAR & " , " & SATIS_FIYAT & " , " & SATIS_TUTAR & " , '" & SATIS_DEPO & "', '" & SATIS_ODEME & "', '" & SATIS_KASIYER & "', '" & SATIS_SATICI & "', '" & SATIS_ACIKLAMA & "'," & GIRIS & ",'" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub kontrol_oran()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            barlabel.Text = "StokKodu:" & dr("STOKKODU").ToString & vbTab & "Adý:" & dr("STOKADI").ToString
            barlabel.Refresh()
            If dr("EKMALIYET") <> 0 Then
                dr("ORANEKMALIYET") = dr("EKMALIYET") / dr("FATURATUTARI")
            End If
            dr("NETMALIYET") = dr("KDVLITUTAR") * ((100 + (dr("ORANEKMALIYET") * 100)) / 100)
            'Karlýlýk Kontrol
            Try
                If dr("PESIN") <> 0 Then
                    dr("ORAN1") = ((dr("PESIN") - dr("NETMALIYET")) / dr("NETMALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ALTIAY") <> 0 Then
                    dr("ORAN2") = ((dr("ALTIAY") - dr("NETMALIYET")) / dr("NETMALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ONAY") <> 0 Then
                    dr("ORAN3") = ((dr("ONAY") - dr("NETMALIYET")) / dr("NETMALIYET"))
                End If
            Catch ex As Exception
            End Try
            Dim dr1 As DataRow
            ds_alislar = sorgu_alislar(dr("TARIH"), dr("FISNO"), dr("STOKKODU"))
            Dim sayi As Integer = 0
            For Each dr1 In ds_alislar.Tables(0).Rows
                sayi += 1
                If dr1("EKMALIYET") <> 0 Then
                    dr1("ORANEKMALIYET") = dr1("EKMALIYET") / dr1("FATURATUTARI")
                End If
                dr1("NETMALIYET") = dr1("KDVLITUTAR") * ((100 + (dr1("ORANEKMALIYET") * 100)) / 100)
                If sayi = 1 Then
                    dr("SONALISMALIYETI") = dr1("NETMALIYET")
                    dr("SONALISTARIHI") = dr1("TARIH")
                ElseIf sayi = 2 Then
                    dr("ONCEKIALISMALIYETI") = dr1("NETMALIYET")
                    dr("ONCEKIALISTARIHI") = dr1("TARIH")
                End If
            Next
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Sub stok_yeni()
        'stok_islemleri.kart_yeni()
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'stok_islemleri.kart_duzelt(dr("IND"), dr("STOKKODU"), dr("MALINCINSI"))
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
                    'stok_islemleri.kart_sil(dr1("IND"), False)
                    'If stok_islemleri.sil = True Then
                    '    'dr1.Delete()
                    '    'dr1.AcceptChanges()
                    'End If
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataload()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
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
    Public Function stok() As DataSet
        Dim kriter
        kriter = " WHERE  (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') AND (tbAlisVeris.nGirisCikis = 4)"
        'If stokkodu <> "" Then
        '    kriter += " AND (tbstok.skodu " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        'End If
        'If malincinsi <> "" Then
        '    kriter += " AND (tbstok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        'End If
        'If barkod <> "" Then
        '    kriter += " AND (barkod.sbarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
        'End If
        If kayitno <> "" Then
            kriter += " AND (tbMusteri.nMusteriID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        If ilktarih <> "" And sontarih <> "" Then
            kriter += " AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        End If
        If ilkbelge <> "" And sonbelge = "" Then
            kriter += " AND (tbAlisVeris.lFaturaNo LIKE '" & ilkbelge & " %')"
        ElseIf ilkbelge <> "" And sonbelge <> "" Then
            kriter += " AND (tbAlisVeris.lFaturaNo BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
        End If
        If firmakodu <> "" Then
            kriter += " AND (tbMusteri.lKodu " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
        End If
        If firmaadi <> "" Then
            kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string(firmaadi, qfirmaadi) & " )"
        End If
        If Trim(depo) <> "" Then
            kriter += " AND (tbAlisVeris.sMagaza = '" & Trim(depo) & "')"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU, tbMusteri.sAdi AS ADI, tbMusteri.sSoyadi AS SOYADI, tbAlisVeris.lFaturaNo AS BELGENO, tbAlisVeris.dteFaturaTarihi AS TARIH, tbAlisVeris.lToplamMiktar AS MIKTAR, tbAlisVeris.lNetTutar AS TUTAR, tbAlisVeris.nAlisverisID AS ALISVERISNO, tbAlisVeris.sFisTipi AS IZAHAT, tbAlisVeris.lVadeFarki AS VADEFARKI, tbAlisVeris.sMagaza AS MAGAZA, tbAlisVeris.sKasiyerRumuzu AS KASIYER, tbAlisVeris.nGirisCikis AS GIRIS, tbAlisVeris.sYaziIle AS YAZI, tbMusteri.dteDogumTarihi AS DOGUMTARIHI, tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID  " & kriter & " ORDER BY tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo")
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
    Public Function sorgu_ekstre_detayli() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, FIYAT.lFiyat AS FIYAT, KONTROL.SATIS_MIKTAR * FIYAT.lFiyat AS TUTAR, KONTROL.SATIS_TUTAR - KONTROL.SATIS_MIKTAR * FIYAT.lFiyat AS FARK FROM         ATBLDEGISIMIADEKONTROL KONTROL INNER JOIN                       tbStokFiyati FIYAT ON KONTROL.SATIS_STOKNO = FIYAT.nStokID AND KONTROL.sFiyatTipi = FIYAT.sFiyatTipi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_ekstre_satislar(ByVal musterino As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasiyer As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END, lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi, tbStokFisiDetayi.sFiyatTipi,tbStok.nStokID FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi ='" & tarih1 & "' AND tbMusteri.lKodu ='" & musterino & "' and tbAlisVeris.sKasiyerRumuzu ='" & kasiyer & "'")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, dtefaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, lFaturaNo AS lNo, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, isnull(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, isnull(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, isnull(lIskontoTutari, 0) AS Iskonto, lNetTutar = CASE WHEN dtefisTarihi IS NULL THEN tbAlisveris.lnetTutar + lvadefarki ELSE isnull(tbStokFisiDetayi.lBrutTutar - lIskontoTutari, 0) + lvadefarki END, tbAlisveris.lnetTutar + lvadefarki AS OdemeTutar, (CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN sStokIslem ELSE '' END) AS OdemeTipi, tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu, '' AS Teslimatci, sAlisverisYapanAdi + ' ' + sAlisverisYapanSoyadi AS AlisverisiYapan, tbAlisVeris.nAlisVerisId AS Id, '01/01/2078' AS TaksitTarihi, 0 AS TaksitTutari, tbAlisVeris.sFisTipi + '-' + tbAlisveris.sMagaza + ' ' + TBdEPO.sAciklama AS OdemeAciklama, 0 AS Tipi, tbAlisVeris.nGirisCikis AS GirisCikis, /*IadeAvInf = CASE WHEN tbAlisVeris.nGirisCikis <> 4 OR tbAlisveris.sFisTipi NOT IN ('K', 'SK') THEN '' ELSE isnull ((SELECT DISTINCT CONVERT(char(10), IadeAlisVeris.dteFaturaTarihi, 103) + '-' + ltrim(str(IadeAlisVeris.lFaturaNo)) FROM tbOdeme AS Odeme, tbAlisveris IadeAlisVeris WHERE tbAlisveris.nAlisverisId = Odeme.nAlisverisId AND Odeme.nIadeAlisverisId = IadeAlisVeris.nAlisVerisId), '') END,*/ lMalBedeli = CASE tbAlisVeris.sFisTipi WHEN 'KVF' THEN 0 ELSE lMalBedeli END, '' AS sHareketTipi, tbStokFisidetayi.nIslemId, tbStokFisidetayi.sOdemeKodu AS StokOdeme, '' AS SevkAciklama, 0 AS KalanTaksit, CONVERT(char(10), tbAlisVeris.dteKayitTarihi, 103) + '-' + CONVERT(char(5), tbAlisVeris.dteKayitTarihi, 108) AS KayitTarihi, tbStokFisiDetayi.sFiyatTipi,tbStok.nStokID FROM tbdepo, tbMusteri, tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbstokFisiDetayi.nAlisverisID = tbAlisveris.nAlisverisID LEFT OUTER JOIN tbStok ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE tbdepo.sDepo = tbAlisVeris.sMagaza AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi ='" & tarih1 & "' AND tbMusteri.lKodu ='" & musterino & "' and tbAlisVeris.sKasiyerRumuzu ='" & kasiyer & "'")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_ekstre_siparisler(ByVal musterino As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasiyer As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID,tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lBrutTutar AS lNetTutar, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisverisSiparis.sIadeNedeni AS IadeAvInf, tbAlisverisSiparis.dteTeslimEdilecek AS Termin, tbAlisverisSiparis.dteTeslimEdilen AS Teslimat, tbAlisverisSiparis.bTeslimEdildi AS TeslimEdildi, tbAlisverisSiparis.dteOnayTarihi AS Onay, tbAlisVeris.sMagaza, tbStok.sRenk, tbAlisVeris.nAlisverisID AS Id,tbStok.nStokID FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE  tbAlisveris.dteFaturaTarihi ='" & tarih1 & "' AND tbMusteri.lKodu ='" & musterino & "' and tbAlisVeris.sKasiyerRumuzu ='" & kasiyer & "'")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub analiz_envanter()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokno = dr("SATIS_STOKNO")
        frm.stokkodu = dr("SATIS_STOKKODU")
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
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = "" 'dr("sRenk")
            frm.sBeden = "" 'dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Function satir_kontrol()
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
                dr = DataSet1.Tables(0).NewRow
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
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                frx.PrintOptions.Copies = dr("MIKTAR")
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi") & ""
            args(3) = "qr_hareket"
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
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
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
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        ara()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        sorgu()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_duzelt()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_yeni()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        gorunum_yazdir()
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
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'stok_fiyat()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If islemstatus = False Then
            e.Cancel = True
            Me.Hide()
        Else
            'Me.Hide()
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
            'PanelControl1 = Nothing
            'PanelControl2 = Nothing
            'PanelControl3 = Nothing
            'XtraTabControl1 = Nothing
            'XtraTabPage1 = Nothing
            'GridControl1 = Nothing
            'GridView1 = Nothing
            'SimpleButton1 = Nothing
            'SimpleButton2 = Nothing
            'SimpleButton3 = Nothing
            'PictureBox1 = Nothing
            'Label1 = Nothing
            'DataSet1 = Nothing
            'DataTable1 = Nothing
            'ContextMenu1 = Nothing
            'MenuItem6 = Nothing
            'MenuItem7 = Nothing
            'MenuItem8 = Nothing
            'MenuItem9 = Nothing
            'MenuItem10 = Nothing
            'MenuItem11 = Nothing
            'MenuItem13 = Nothing
            'MenuItem14 = Nothing
            'MenuItem15 = Nothing
            'MenuItem16 = Nothing
            'ps = Nothing
            'printlink1 = Nothing
            'Label2 = Nothing
            'MenuItem17 = Nothing
            'MenuItem18 = Nothing
            'sec_renk = Nothing
            'MenuItem20 = Nothing
            'MenuItem22 = Nothing
            'MenuItem23 = Nothing
            'MenuItem24 = Nothing
            'OpenFileDialog1 = Nothing
            'Panelstatus = Nothing
            'bar2 = Nothing
            'barlabel2 = Nothing
            'barlabel = Nothing
            'bar = Nothing
            'MenuItem21 = Nothing
            'MenuItem25 = Nothing
            'MenuItem26 = Nothing
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
            'colIND = Nothing
            'colTARIH = Nothing
            'colFIRMAKODU = Nothing
            'colFIRMAADI = Nothing
            'colADI = Nothing
            'colSOYADI = Nothing
            'colIADE_FISNO = Nothing
            'colIADE_FISTIPI = Nothing
            'colIADE_STOKNO = Nothing
            'colIADE_STOKKODU = Nothing
            'colIADE_MALINCINSI = Nothing
            'colIADE_MIKTAR = Nothing
            'colIADE_FIYAT = Nothing
            'colIADE_TUTAR = Nothing
            'colIADE_DEPO = Nothing
            'colIADE_ODEME = Nothing
            'colIADE_KASIYER = Nothing
            'colIADE_SATICI = Nothing
            'colIADE_ACIKLAMA = Nothing
            'colSATIS_FISNO = Nothing
            'colSATIS_FISTIPI = Nothing
            'colSATIS_STOKNO = Nothing
            'colSATIS_STOKKODU = Nothing
            'colSATIS_MALINCINSI = Nothing
            'colSATIS_MIKTAR = Nothing
            'colSATIS_FIYAT = Nothing
            'colSATIS_TUTAR = Nothing
            'colSATIS_DEPO = Nothing
            'colSATIS_ODEME = Nothing
            'colSATIS_KASIYER = Nothing
            'colSATIS_SATICI = Nothing
            'colSATIS_ACIKLAMA = Nothing
            'XtraTabPage2 = Nothing
            'PivotGridControl1 = Nothing
            'DataColumn33 = Nothing
            'DataColumn34 = Nothing
            'colGIRIS = Nothing
            'GridColumn2 = Nothing
            'DataColumn35 = Nothing
            'DataColumn36 = Nothing
            'DataColumn37 = Nothing
            'colFIYAT = Nothing
            'colTUTAR = Nothing
            'colFARK = Nothing
            'MenuItem5 = Nothing
            'MenuItem1 = Nothing
            'MenuItem2 = Nothing
            'MenuItem3 = Nothing
            'MenuItem4 = Nothing
            'MenuItem12 = Nothing
            'MenuItem19 = Nothing
            'MenuItem27 = Nothing
            'MenuItem28 = Nothing
            'MenuItem29 = Nothing
            'MenuItem30 = Nothing
            System.GC.Collect()
            System.GC.GetTotalMemory(True)
            System.GC.SuppressFinalize(Me)
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
        frm.fistipi = Trim(dr("SATIS_FISTIPI").ToString)
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_sil()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim file As String
        OpenFileDialog1.Filter = "Plu Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, 0)
        End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 0)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim file As String
        OpenFileDialog1.Filter = "Plu Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, 2)
        End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim file As String
        OpenFileDialog1.Filter = "Plu Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, 1)
        End If
        'report_create_stok("C:\etiket1.fr3", satir_kontrol, 1)
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
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        stok_odeme_detay_tumu()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        incele()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ara_belge()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_hareket()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        stok_odeme_detay_tumu()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla_pdf()
    End Sub
End Class
