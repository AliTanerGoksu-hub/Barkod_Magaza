Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_cari_ekstre_ozet
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
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
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
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_ekstre_tarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_ekstre_tarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Firma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
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
    Friend WithEvents colTAHSILAT As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari_ekstre_ozet))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.grid_odemeler_kalan = New DevExpress.XtraPivotGrid.PivotGridControl()
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
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
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
        Me.colTAHSILAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_ekstre_tarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_ekstre_tarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Firma = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label39 = New DevExpress.XtraEditors.LabelControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.grid_odemeler_kalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Müþteri Hesap Ekstresi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
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
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 303)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GroupControl7)
        Me.PanelControl5.Controls.Add(Me.GridControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 53)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(820, 248)
        Me.PanelControl5.TabIndex = 1
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.grid_odemeler_kalan)
        Me.GroupControl7.Location = New System.Drawing.Point(70, 29)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(362, 196)
        Me.GroupControl7.TabIndex = 3
        Me.GroupControl7.Text = "Kalan Ödemeler"
        Me.GroupControl7.Visible = False
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
        Me.grid_odemeler_kalan.Size = New System.Drawing.Size(358, 179)
        Me.grid_odemeler_kalan.TabIndex = 1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "kodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TUTAR"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "TAHSILAT"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "KALAN"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "AY"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "YIL"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteTarihi"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sFisTipi"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "dteFaturaTarihi"
        Me.DataColumn10.DataType = GetType(Date)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lFaturaNo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lToplamMiktar"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lPesinat"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lNetTutar"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sYaziIle"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nKasaNo"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "dteKayitTarihi"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nAlisverisID"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sAdi"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sSoyadi"
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
        Me.PivotGridField6.Width = 83
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField7.AreaIndex = 0
        Me.PivotGridField7.Caption = "Yýl"
        Me.PivotGridField7.FieldName = "YIL"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.Width = 60
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
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(816, 244)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem21, Me.MenuItem14, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem20, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 1
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem21.Text = "Ara"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Satisi Goster"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 5
        Me.MenuItem17.Text = "Ödemeyi Göster"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 6
        Me.MenuItem18.Text = "Kalan Taksitleri Göster"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 7
        Me.MenuItem20.Text = "Satis Bazli Kalan Taksitler"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 8
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 9
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 11
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 12
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 14
        Me.MenuItem22.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 15
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 16
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 17
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 18
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 19
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 20
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 21
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFIRMAKODU, Me.colADI, Me.colSOYADI, Me.colBELGENO, Me.colTARIH, Me.colMIKTAR, Me.colTUTAR, Me.colALISVERISNO, Me.colIZAHAT, Me.colVADEFARKI, Me.colMAGAZA, Me.colKASIYER, Me.colGIRIS, Me.colYAZI, Me.colDOGUMTARIHI, Me.colEVLILIKTARIHI, Me.colYAZDIRMA, Me.colKAYIT, Me.colSOZLESME, Me.colTAHSILAT, Me.collBakiye})
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
        Me.colTUTAR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTUTAR.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colTUTAR.AppearanceCell.Options.UseFont = True
        Me.colTUTAR.AppearanceCell.Options.UseForeColor = True
        Me.colTUTAR.Caption = "Satýþ"
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
        Me.colKAYIT.VisibleIndex = 10
        '
        'colSOZLESME
        '
        Me.colSOZLESME.Caption = "Sözleþme"
        Me.colSOZLESME.FieldName = "SOZLESME"
        Me.colSOZLESME.Name = "colSOZLESME"
        '
        'colTAHSILAT
        '
        Me.colTAHSILAT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTAHSILAT.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTAHSILAT.AppearanceCell.Options.UseFont = True
        Me.colTAHSILAT.AppearanceCell.Options.UseForeColor = True
        Me.colTAHSILAT.Caption = "Tahsilat"
        Me.colTAHSILAT.DisplayFormat.FormatString = "#,0.00"
        Me.colTAHSILAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTAHSILAT.FieldName = "TAHSILAT"
        Me.colTAHSILAT.Name = "colTAHSILAT"
        Me.colTAHSILAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TAHSILAT", "{0:#,0.00}")})
        Me.colTAHSILAT.Visible = True
        Me.colTAHSILAT.VisibleIndex = 8
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "lBakiye", "{0:#,0.00#}")})
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 9
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.SimpleButton6)
        Me.PanelControl4.Controls.Add(Me.sec_ekstre_tarih2)
        Me.PanelControl4.Controls.Add(Me.sec_ekstre_tarih1)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.lbl_Firma)
        Me.PanelControl4.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl4.Controls.Add(Me.Label39)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 51)
        Me.PanelControl4.TabIndex = 0
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(310, 26)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton6.TabIndex = 21
        Me.SimpleButton6.Text = "&Listele"
        '
        'sec_ekstre_tarih2
        '
        Me.sec_ekstre_tarih2.EditValue = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.sec_ekstre_tarih2.EnterMoveNextControl = True
        Me.sec_ekstre_tarih2.Location = New System.Drawing.Point(223, 26)
        Me.sec_ekstre_tarih2.Name = "sec_ekstre_tarih2"
        Me.sec_ekstre_tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih2.Size = New System.Drawing.Size(81, 20)
        Me.sec_ekstre_tarih2.TabIndex = 2
        '
        'sec_ekstre_tarih1
        '
        Me.sec_ekstre_tarih1.EditValue = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.sec_ekstre_tarih1.EnterMoveNextControl = True
        Me.sec_ekstre_tarih1.Location = New System.Drawing.Point(97, 26)
        Me.sec_ekstre_tarih1.Name = "sec_ekstre_tarih1"
        Me.sec_ekstre_tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_ekstre_tarih1.Size = New System.Drawing.Size(88, 20)
        Me.sec_ekstre_tarih1.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(15, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(15, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "MüþteriKodu:"
        '
        'lbl_Firma
        '
        Me.lbl_Firma.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Firma.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Firma.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_Firma.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Firma.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Firma.Location = New System.Drawing.Point(310, 4)
        Me.lbl_Firma.Name = "lbl_Firma"
        Me.lbl_Firma.Size = New System.Drawing.Size(243, 20)
        Me.lbl_Firma.TabIndex = 24
        Me.lbl_Firma.Text = "*"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.EnterMoveNextControl = True
        Me.txt_musteriNo.Location = New System.Drawing.Point(97, 4)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(207, 20)
        Me.txt_musteriNo.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(191, 23)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(12, 13)
        Me.Label39.TabIndex = 22
        Me.Label39.Text = "ve"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.printlink})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Müþteri Hesap Ekstresi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "CRM-Müþteri Ýliþkileri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.grid_odemeler_kalan
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'printlink
        '
        '
        '
        '
        Me.printlink.ImageCollection.ImageStream = CType(resources.GetObject("printlink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        Me.printlink.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Perakende Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink.PrintingSystem = Me.ps
        Me.printlink.PrintingSystemBase = Me.ps
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlBottom.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Satýþý Göster ,F6"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Kalan Taksitleri Goster"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Satýþ Bazlý Kalan Taksitler"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Text"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Mail"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
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
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 407)
        Me.BarDockControl2.Size = New System.Drawing.Size(824, 22)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 407)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(824, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 407)
        '
        'frm_cari_ekstre_ozet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cari_ekstre_ozet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hesap Ekstresi Özet"
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
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.grid_odemeler_kalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public musteriID
    Public kasiyerno
    Public kullanici
    Dim ds_ekstre As DataSet
    Dim ds_OdemelerKalan As DataSet
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        sec_ekstre_tarih2.EditValue = "01/01/1900"
        sec_ekstre_tarih2.EditValue = dteSistemTarihi
        txt_musteriNo.Text = musterino
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
        'If musterino <> "" Then
        '    incele()
        'End If
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
        kriter += Microsoft.VisualBasic.Left(sec_ekstre_tarih1.EditValue, 10).ToString
        kriter += " ve "
        kriter += Microsoft.VisualBasic.Left(sec_ekstre_tarih2.EditValue, 10).ToString
        kriter += " Tarihleri Arasýndaki Müþteri Ekstresi "
        printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "CRM-Müþteri Ýliþkileri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Public Function stok() As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        stok_satis_detay()
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub incele()
        musterino = txt_musteriNo.Text
        If musterino.ToString <> "" Then
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ds_ekstre = sorgu_ekstre_detayli(musterino, sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue)
            Dim dr As DataRow
            Dim bakiye As Decimal = 0
            Dim bakiye_status As String = 0
            For Each dr In ds_ekstre.Tables(0).Rows
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
            GridView1.OptionsView.ShowFooter = True
            collBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(bakiye), 2).ToString & "(" & bakiye_status & ")"
            GridView1.UpdateSummary()
            'For Each dr In ds_ekstre.Tables(0).Rows
            '    If dr("Tipi") <> 2 Then
            '        dr("OdemeTutar") = 0
            '        If Trim(dr("fisTipi").ToString) = "SK" Or Trim(dr("fisTipi").ToString) = "SP" Then
            '            If Trim(dr("SevkAciklama")) <> "" Then
            '                dr("Teslimatci") = "1"
            '            Else
            '                dr("Teslimatci") = "0"
            '            End If
            '        End If
            '    Else
            '        Dim fistipi As String = Trim(dr("fisTipi").ToString)
            '        If fistipi = "P" Then
            '            dr("sKodu") = "Peþin Satýþ"
            '            dr("sStokAciklama") = "Peþinat"
            '        ElseIf fistipi = "Z" Then
            '            dr("sKodu") = "Taksit"
            '            dr("sStokAciklama") = "Ödeme"
            '        ElseIf fistipi = "K" Then
            '            dr("sKodu") = "Kredili Satýþ"
            '            dr("sStokAciklama") = "Peþinat"
            '        End If
            '    End If
            'Next
            GridControl1.DataSource = ds_ekstre.Tables(0)
            GridControl1.DataMember = Nothing
            GridControl1.Focus()
            GridControl1.Select()
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.SelectRow(GridView1.FocusedRowHandle)
                GridControl1.Focus()
            End If
            ds_OdemelerKalan = odemeler_kalan(musterino)
            grid_odemeler_kalan.DataSource = ds_OdemelerKalan.Tables(0)
            grid_odemeler_kalan.DataMember = Nothing
            grid_odemeler_kalan.RefreshData()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Public Function sorgu_ekstre_detayli(ByVal musterino As Int64, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim kriter_musteri As String = ""
        kriter_musteri = " AND tbMusteri.lKodu = '" & Trim(musterino) & "' "
        cmd.CommandTimeout = False
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = tbAlisVeris.nAlisVerisID) AND (nOdemeKodu = 3)) Kapatma) AS TAHSILAT,tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & "  AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION ALL SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR ,SUM(TAHSILAT) AS TAHSILAT, '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , 0 AS TUTAR ,SUM(tbOdeme.lOdemeTutar) AS TAHSILAT , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & " GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY TARIH,IZAHAT, BELGENO")
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) ) Kapatma) AS TAHSILAT,CAST(0 AS MONEY) as lBakiye,tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & "  AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION ALL SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR ,SUM(TAHSILAT) AS TAHSILAT, CAST(0 AS MONEY) as lBakiye,'0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , 0 AS TUTAR ,SUM(tbOdeme.lOdemeTutar) AS TAHSILAT , CAST(0 AS MONEY) as lBakiye,tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_musteri & " GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY TARIH,IZAHAT, BELGENO")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function odemeler_kalan(ByVal lKodu As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN,  CAST(MONTH(dteTarihi) AS VARCHAR(2)) + '.' + DATENAME(month, dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi as Ad, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, tbMusteri.sSoyadi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.lKodu = " & lKodu & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi  , tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = musteriID
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
            frm.musterino = musteriID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub musteri_sec()
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
            musteriID = dr1("nMusteriID")
            musterino = dr1("lKodu")
            lbl_Firma.Text = dr1("Musteri")
            txt_musteriNo.EditValue = musterino
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
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
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.rtf) |*.rtf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.rtf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToRtf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        incele()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub frm_cari_ekstre_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label2 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'DataSet1.Clear()
        'DataSet1.Dispose()
        'DataSet1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem13 = Nothing
        'MenuItem14 = Nothing
        'MenuItem15 = Nothing
        'ps = Nothing
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
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'printlink1 = Nothing
        'MenuItem16 = Nothing
        'PanelControl4 = Nothing
        'Label39 = Nothing
        'SimpleButton6 = Nothing
        'Label40 = Nothing
        'sec_ekstre_tarih2 = Nothing
        'sec_ekstre_tarih1 = Nothing
        'PanelControl5 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'collKodu = Nothing
        'colsMusteriAdi = Nothing
        'coldteTarih = Nothing
        'colfisTipi = Nothing
        'collNo = Nothing
        'colsKodu = Nothing
        'colsStokAciklama = Nothing
        'colMiktar = Nothing
        'colFiyat = Nothing
        'colIskonto = Nothing
        'collNetTutar1 = Nothing
        'colOdemeTutar = Nothing
        'colOdemeTipi = Nothing
        'colSaticiRumuzu = Nothing
        'colKasiyerRumuzu = Nothing
        'colTeslimatci = Nothing
        'colId = Nothing
        'colOdemeAciklama = Nothing
        'colTipi = Nothing
        'colGirisCikis = Nothing
        'colIadeAvInf = Nothing
        'collMalBedeli = Nothing
        'colsHareketTipi = Nothing
        'colnIslemId = Nothing
        'colStokOdeme = Nothing
        'colSevkAciklama = Nothing
        'colKayitTarihi = Nothing
        'MenuItem17 = Nothing
        'MenuItem18 = Nothing
        'MenuItem19 = Nothing
        'MenuItem20 = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_musteriNo.EditValue = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        musteri_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_musteriNo.EditValue.ToString = "" Then
                musteri_sec()
            End If
        End If
    End Sub
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        txt_musteriNo.Text = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_rtf()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        stok_satis_detay()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            incele_fis()
        End If
    End Sub
    Private Sub incele_fis()
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
    Private Sub GridView1_SelectionChanged1(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If MenuItem22.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem22.Checked = True
        ElseIf MenuItem22.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem22.Checked = False
        End If
    End Sub
End Class
