Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_transfer_teslim
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
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_transfer_teslim))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBARCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTransferMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTeslimMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTransferDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTeslimDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKAYITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSONUC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBEDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colssFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFIYAT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFIYAT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFIYAT3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colssBirimCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colslBirimMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsnBirimCarpan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTalepKontrolMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferBekleyen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSatici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 106)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(681, 102)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(365, 22)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Fazladan Talep Doğrulama Ürünleri"
        Me.CheckEdit1.Size = New System.Drawing.Size(244, 19)
        Me.CheckEdit1.TabIndex = 15
        Me.CheckEdit1.Visible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
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
        Me.BarButtonItem2.Caption = "Yazdır,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(6, 46)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Stok:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(272, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Arasındaki"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(145, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "ve"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(5, 24)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 6, 16, 19, 41, 57, 199)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(164, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2007, 6, 16, 19, 41, 51, 511)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(38, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "BELGE NO"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(175, 43)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"BELGE NO", "STOK NO", "STOK KODU", "MALIN CİNSİ", "BARKOD"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 3
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(275, 69)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(275, 43)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 4
        '
        'txt_ara
        '
        Me.txt_ara.EditValue = ""
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(38, 43)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(137, 20)
        Me.txt_ara.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(777, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(45, 13)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "istihbarat"
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
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl2)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 106)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 253)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextMenu1
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.Location = New System.Drawing.Point(2, 153)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(820, 98)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.GridControl2.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem19, Me.MenuItem18, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem17, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "İletişim Bilgileri"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartı"
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = False
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Firma Hareketleri"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 6
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 7
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 8
        Me.MenuItem2.Text = "Başlık Değiştir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 9
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 10
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 11
        Me.MenuItem10.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 12
        Me.MenuItem17.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 13
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 14
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 15
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 16
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 17
        Me.MenuItem8.Text = "Satırları Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 18
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 19
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekranı Kapla"
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Expression = "0"
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SINIF", Nothing, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SINIF", Nothing, "{0} Kayıt")})
        Me.GridView2.IndicatorWidth = 35
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView2.OptionsPrint.ExpandAllGroups = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kayıt NO"
        Me.GridColumn1.FieldName = "IND"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "TARİH"
        Me.GridColumn2.FieldName = "TARIH"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "BELGE NO"
        Me.GridColumn3.FieldName = "BELGENO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "STOK NO"
        Me.GridColumn4.FieldName = "STOKNO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "STOK KODU"
        Me.GridColumn5.FieldName = "STOKKODU"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Malın Cinsi"
        Me.GridColumn6.FieldName = "MALINCINSI"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Barkod"
        Me.GridColumn7.FieldName = "BARCODE"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Transfer Miktar"
        Me.GridColumn8.FieldName = "TransferMiktar"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Teslim Miktar"
        Me.GridColumn9.FieldName = "TeslimMiktar"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 12
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Transfer Depo"
        Me.GridColumn10.FieldName = "TransferDepo"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 13
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Teslim Depo"
        Me.GridColumn11.FieldName = "TeslimDepo"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 14
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Kayıt Tarihi"
        Me.GridColumn12.FieldName = "KAYITTARIHI"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Sonuç"
        Me.GridColumn13.FieldName = "SONUC"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 15
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Renk"
        Me.GridColumn14.FieldName = "RENK"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Beden"
        Me.GridColumn15.FieldName = "BEDEN"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Model"
        Me.GridColumn16.FieldName = "MODEL"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Fiyat Tipi"
        Me.GridColumn17.FieldName = "sFiyatTipi"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Fiyat 1"
        Me.GridColumn18.FieldName = "FIYAT1"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Fiyat 2"
        Me.GridColumn19.FieldName = "FIYAT2"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Fiyat 3"
        Me.GridColumn20.FieldName = "FIYAT3"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Birim Cinsi"
        Me.GridColumn21.FieldName = "sBirimCinsi"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Birim Miktar"
        Me.GridColumn22.FieldName = "lBirimMiktar"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Birim Çarpan"
        Me.GridColumn23.FieldName = "nBirimCarpan"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Transfer Kontrol Miktar"
        Me.GridColumn24.FieldName = "TalepKontrolMiktar"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 9
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Transfer Kalan"
        Me.GridColumn25.FieldName = "TransferKalan"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 10
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Transfer Bekleyen"
        Me.GridColumn26.FieldName = "TransferBekleyen"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 11
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "SATICI"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "sSaticiRumuzu"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSatici})
        Me.GridControl1.Size = New System.Drawing.Size(820, 249)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsIND, Me.colsTARIH, Me.BELGENO, Me.colsSTOKNO, Me.colsSTOKKODU, Me.colsMALINCINSI, Me.colsBARCODE, Me.colsTransferMiktar, Me.colsTeslimMiktar, Me.colsTransferDepo, Me.colsTeslimDepo, Me.colsKAYITTARIHI, Me.colsSONUC, Me.colsRENK, Me.colsBEDEN, Me.colsMODEL, Me.colssFiyatTipi, Me.colsFIYAT1, Me.colsFIYAT2, Me.colsFIYAT3, Me.colssBirimCinsi, Me.colslBirimMiktar, Me.colsnBirimCarpan, Me.colTalepKontrolMiktar, Me.colTransferKalan, Me.colTransferBekleyen})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Expression = "0"
        StyleFormatCondition2.Tag = "0"
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SINIF", Nothing, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SINIF", Nothing, "{0} Kayıt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsIND
        '
        Me.colsIND.Caption = "Kayıt NO"
        Me.colsIND.FieldName = "IND"
        Me.colsIND.Name = "colsIND"
        Me.colsIND.Visible = True
        Me.colsIND.VisibleIndex = 0
        '
        'colsTARIH
        '
        Me.colsTARIH.Caption = "TARİH"
        Me.colsTARIH.FieldName = "TARIH"
        Me.colsTARIH.Name = "colsTARIH"
        Me.colsTARIH.Visible = True
        Me.colsTARIH.VisibleIndex = 1
        '
        'BELGENO
        '
        Me.BELGENO.Caption = "BELGE NO"
        Me.BELGENO.FieldName = "BELGENO"
        Me.BELGENO.Name = "BELGENO"
        Me.BELGENO.Visible = True
        Me.BELGENO.VisibleIndex = 2
        '
        'colsSTOKNO
        '
        Me.colsSTOKNO.Caption = "STOK NO"
        Me.colsSTOKNO.FieldName = "STOKNO"
        Me.colsSTOKNO.Name = "colsSTOKNO"
        Me.colsSTOKNO.Visible = True
        Me.colsSTOKNO.VisibleIndex = 3
        '
        'colsSTOKKODU
        '
        Me.colsSTOKKODU.Caption = "STOK KODU"
        Me.colsSTOKKODU.FieldName = "STOKKODU"
        Me.colsSTOKKODU.Name = "colsSTOKKODU"
        Me.colsSTOKKODU.Visible = True
        Me.colsSTOKKODU.VisibleIndex = 4
        '
        'colsMALINCINSI
        '
        Me.colsMALINCINSI.Caption = "Malın Cinsi"
        Me.colsMALINCINSI.FieldName = "MALINCINSI"
        Me.colsMALINCINSI.Name = "colsMALINCINSI"
        Me.colsMALINCINSI.Visible = True
        Me.colsMALINCINSI.VisibleIndex = 6
        '
        'colsBARCODE
        '
        Me.colsBARCODE.Caption = "Barkod"
        Me.colsBARCODE.FieldName = "BARCODE"
        Me.colsBARCODE.Name = "colsBARCODE"
        Me.colsBARCODE.Visible = True
        Me.colsBARCODE.VisibleIndex = 7
        '
        'colsTransferMiktar
        '
        Me.colsTransferMiktar.Caption = "Transfer Miktar"
        Me.colsTransferMiktar.FieldName = "TransferMiktar"
        Me.colsTransferMiktar.Name = "colsTransferMiktar"
        Me.colsTransferMiktar.Visible = True
        Me.colsTransferMiktar.VisibleIndex = 8
        '
        'colsTeslimMiktar
        '
        Me.colsTeslimMiktar.Caption = "Teslim Miktar"
        Me.colsTeslimMiktar.FieldName = "TeslimMiktar"
        Me.colsTeslimMiktar.Name = "colsTeslimMiktar"
        Me.colsTeslimMiktar.Visible = True
        Me.colsTeslimMiktar.VisibleIndex = 12
        '
        'colsTransferDepo
        '
        Me.colsTransferDepo.Caption = "Transfer Depo"
        Me.colsTransferDepo.FieldName = "TransferDepo"
        Me.colsTransferDepo.Name = "colsTransferDepo"
        Me.colsTransferDepo.Visible = True
        Me.colsTransferDepo.VisibleIndex = 13
        '
        'colsTeslimDepo
        '
        Me.colsTeslimDepo.Caption = "Teslim Depo"
        Me.colsTeslimDepo.FieldName = "TeslimDepo"
        Me.colsTeslimDepo.Name = "colsTeslimDepo"
        Me.colsTeslimDepo.Visible = True
        Me.colsTeslimDepo.VisibleIndex = 14
        '
        'colsKAYITTARIHI
        '
        Me.colsKAYITTARIHI.Caption = "Kayıt Tarihi"
        Me.colsKAYITTARIHI.FieldName = "KAYITTARIHI"
        Me.colsKAYITTARIHI.Name = "colsKAYITTARIHI"
        '
        'colsSONUC
        '
        Me.colsSONUC.Caption = "Sonuç"
        Me.colsSONUC.FieldName = "SONUC"
        Me.colsSONUC.Name = "colsSONUC"
        Me.colsSONUC.Visible = True
        Me.colsSONUC.VisibleIndex = 15
        '
        'colsRENK
        '
        Me.colsRENK.Caption = "Renk"
        Me.colsRENK.FieldName = "RENK"
        Me.colsRENK.Name = "colsRENK"
        Me.colsRENK.Visible = True
        Me.colsRENK.VisibleIndex = 5
        '
        'colsBEDEN
        '
        Me.colsBEDEN.Caption = "Beden"
        Me.colsBEDEN.FieldName = "BEDEN"
        Me.colsBEDEN.Name = "colsBEDEN"
        '
        'colsMODEL
        '
        Me.colsMODEL.Caption = "Model"
        Me.colsMODEL.FieldName = "MODEL"
        Me.colsMODEL.Name = "colsMODEL"
        '
        'colssFiyatTipi
        '
        Me.colssFiyatTipi.Caption = "Fiyat Tipi"
        Me.colssFiyatTipi.FieldName = "sFiyatTipi"
        Me.colssFiyatTipi.Name = "colssFiyatTipi"
        '
        'colsFIYAT1
        '
        Me.colsFIYAT1.Caption = "Fiyat 1"
        Me.colsFIYAT1.FieldName = "FIYAT1"
        Me.colsFIYAT1.Name = "colsFIYAT1"
        '
        'colsFIYAT2
        '
        Me.colsFIYAT2.Caption = "Fiyat 2"
        Me.colsFIYAT2.FieldName = "FIYAT2"
        Me.colsFIYAT2.Name = "colsFIYAT2"
        '
        'colsFIYAT3
        '
        Me.colsFIYAT3.Caption = "Fiyat 3"
        Me.colsFIYAT3.FieldName = "FIYAT3"
        Me.colsFIYAT3.Name = "colsFIYAT3"
        '
        'colssBirimCinsi
        '
        Me.colssBirimCinsi.Caption = "Birim Cinsi"
        Me.colssBirimCinsi.FieldName = "sBirimCinsi"
        Me.colssBirimCinsi.Name = "colssBirimCinsi"
        '
        'colslBirimMiktar
        '
        Me.colslBirimMiktar.Caption = "Birim Miktar"
        Me.colslBirimMiktar.FieldName = "lBirimMiktar"
        Me.colslBirimMiktar.Name = "colslBirimMiktar"
        '
        'colsnBirimCarpan
        '
        Me.colsnBirimCarpan.Caption = "Birim Çarpan"
        Me.colsnBirimCarpan.FieldName = "nBirimCarpan"
        Me.colsnBirimCarpan.Name = "colsnBirimCarpan"
        '
        'colTalepKontrolMiktar
        '
        Me.colTalepKontrolMiktar.Caption = "Transfer Kontrol Miktar"
        Me.colTalepKontrolMiktar.FieldName = "TalepKontrolMiktar"
        Me.colTalepKontrolMiktar.Name = "colTalepKontrolMiktar"
        Me.colTalepKontrolMiktar.Visible = True
        Me.colTalepKontrolMiktar.VisibleIndex = 9
        '
        'colTransferKalan
        '
        Me.colTransferKalan.Caption = "Transfer Kalan"
        Me.colTransferKalan.FieldName = "TransferKalan"
        Me.colTransferKalan.Name = "colTransferKalan"
        Me.colTransferKalan.Visible = True
        Me.colTransferKalan.VisibleIndex = 10
        '
        'colTransferBekleyen
        '
        Me.colTransferBekleyen.Caption = "Transfer Bekleyen"
        Me.colTransferBekleyen.FieldName = "TransferBekleyen"
        Me.colTransferBekleyen.Name = "colTransferBekleyen"
        Me.colTransferBekleyen.Visible = True
        Me.colTransferBekleyen.VisibleIndex = 11
        '
        'sec_sSatici
        '
        Me.sec_sSatici.AutoHeight = False
        Me.sec_sSatici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.DisplayMember = "SATICI"
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.ValueMember = "sSaticiRumuzu"
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
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Firmalar Karlılık Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Firma Hesapları Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_transfer_teslim
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
        Me.Name = "frm_transfer_teslim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Teslimat Hataları"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public sModul As String = "Cari"
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_satici As New DataSet
    Public sFiyatTipi As String = ""
    Public sDepo As String = ""
    Public islemstatus As Boolean = False
    Dim DataSet1 As DataSet
    Dim DataSet2 As DataSet
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        DateEdit1.Focus()
        DateEdit1.Select()
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasındaki Satıcı Personel Değerlendirme Listesi" & vbCrLf
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Financial Managment-Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandTimeout = Nothing
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " = '" & deger & "' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload()
        Dim kriter As String = ""
        If Trim(txt_ara.Text) <> "" Then
            If sec_konum.SelectedIndex = 0 Then
                kriter = "and baslik.BELGENO " & sorgu_kriter_string(Trim(txt_ara.Text), sec_kriter.Text)
            ElseIf sec_konum.SelectedIndex = 1 Then
                kriter = "and detay.STOKNO " & sorgu_kriter_string(Trim(txt_ara.Text), sec_kriter.Text)
            ElseIf sec_konum.SelectedIndex = 2 Then
                kriter = "and detay.STOKKODU " & sorgu_kriter_string(Trim(txt_ara.Text), sec_kriter.Text)
            ElseIf sec_konum.SelectedIndex = 3 Then
                kriter = "and detay.MALINCINSI " & sorgu_kriter_string(Trim(txt_ara.Text), sec_kriter.Text)
            ElseIf sec_konum.SelectedIndex = 4 Then
                kriter = "and detay.BARCODE " & sorgu_kriter_string(Trim(txt_ara.Text), sec_kriter.Text)
            End If
        End If
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and ((detay.BARCODE NOT IN(SELECT detay.BARCODE from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO))) or (detay.MIKTAR <= ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and ((detay.BARCODE NOT IN(SELECT detay.BARCODE from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO))) or (detay.MIKTAR = ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and ((detay.BARCODE IN(SELECT detay.BARCODE from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO))) and (ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL(SUM(detayDog.MIKTAR), 0) as TalepKontrolMiktar, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'BU1 DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL(detayDog.MIKTAR, 0) as TalepKontrolMiktar, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as TalepKontrolMiktar, 0 as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0)) AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL(SUM(detayDog.MIKTAR), 0) as TalepKontrolMiktar, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL(SUM(detayDog.MIKTAR), 0) as TalepKontrolMiktar, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'Yeni
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL(detayDog.MIKTAR, 0) as TalepKontrolMiktar, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = detay.EVRAKNO) group by BARCODE), 0) <> 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as TalepKontrolMiktar, 0 as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0)) AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,sum(detay.MIKTAR) as TalepKontrolMiktar, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) > 0) OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = detay.EVRAKNO) group by BARCODE), 0) > 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as TalepKontrolMiktar, 0 as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0)) AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as TalepKontrolMiktar, ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as xbaslik, ASTOKETIKETTALEPDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TransferMiktar', SUM(detay.MIKTAR) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay LEFT JOIN ASTOKETIKETTALEPBASLIK talepBaslik ON (talepBaslik.IND = (Select REFIND from ASTOKETIKETTESLIMBASLIK where IND = detay.EVRAKNO)) LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = talepBaslik.IND) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) < 0) OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = baslik.REFIND) group by BARCODE), 0) <> 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) group by baslik.IND, baslik.REFIND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.MIKTAR, detay.BARCODE, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI,  baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, SUM(detayDog.MIKTAR) as TalepKontrolMiktar, ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as xbaslik, ASTOKETIKETTALEPDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,SUM(detayDog.MIKTAR) as TalepKontrolMiktar,ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as xbaslik, ASTOKETIKETTALEPDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'Yeni 27.05.2015
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar',  ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) > 0) OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = detay.EVRAKNO) group by BARCODE), 0) > 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, 0 as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0)) AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as xbaslik, ASTOKETIKETTALEPDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TransferMiktar', SUM(detay.MIKTAR) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay LEFT JOIN ASTOKETIKETTALEPBASLIK talepBaslik ON (talepBaslik.IND = (Select REFIND from ASTOKETIKETTESLIMBASLIK where IND = detay.EVRAKNO)) LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = talepBaslik.IND) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) < 0) OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = baslik.REFIND) group by BARCODE), 0) <> 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) group by baslik.IND, baslik.REFIND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.MIKTAR, detay.BARCODE, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI,  baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sFiyatTipi, detay.FIYAT1, detay.FIYAT2, detay.FIYAT3, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        ' Bunu Ali Yaptı
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO),0) as TalepKontrolMiktar, ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as xbaslik, ASTOKETIKETTALEPDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0)  " & kriter & "  group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO),0) as TalepKontrolMiktar, ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as xbaslik, ASTOKETIKETTALEPDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar',baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1)AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0)  " & kriter & "   group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO),0) as TalepKontrolMiktar,sum(detay.MIKTAR) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND  (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and  hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) > 0) " & kriter & " OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = detay.EVRAKNO) group by BARCODE), 0) > 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) " & kriter & "  group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK,  detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, sum(detay.MIKTAR) as TalepKontrolMiktar, 0 as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)  as 'TeslimMiktar',   baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON  tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON  tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND  (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo  UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078'  GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN  FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID  INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND  (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo  UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON  hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0)) AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & "  group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,  ISNULL(sum(detaydog.MIKTAR),0) as TalepKontrolMiktar, ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as xbaslik, ASTOKETIKETTALEPDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)  as 'TeslimMiktar',  baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis  INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo  ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900'  AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo  UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID  INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and  hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON  tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay LEFT JOIN ASTOKETIKETTALEPBASLIK talepBaslik ON (talepBaslik.IND = (Select REFIND from ASTOKETIKETTESLIMBASLIK where IND = detay.EVRAKNO)) LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = talepBaslik.IND) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) < 0) OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = baslik.REFIND) group by BARCODE), 0) <> 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) group by baslik.IND, baslik.REFIND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.MIKTAR, detay.BARCODE, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI,  baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar',  ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND  (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and  hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) > 0) " & kriter & "   OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = detay.EVRAKNO) group by BARCODE), 0) > 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) " & kriter & "   group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK,  detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO),0) as TalepKontrolMiktar, SUM(detay.MIKTAR)  as 'TransferMiktar',  ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)  as 'TeslimMiktar',   baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON  tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON  tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND  (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo  UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078'  GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN  FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID  INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND  (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON  hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0))   AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & "  group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan  ")
        '05.06.2015
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1)  AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048')  AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) > 0) " & kriter & " OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = detay.EVRAKNO) group by BARCODE), 0) > 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO,  baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar,  detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL (SUM  ( detay.MIKTAR) , 0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND  depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0))  AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,ISNULL (( SUM  ( detayDog.MIKTAR) ),0)  as TalepKontrolMiktar,ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', SUM(detay.MIKTAR) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay LEFT JOIN ASTOKETIKETTALEPBASLIK talepBaslik ON (talepBaslik.IND = (Select REFIND from ASTOKETIKETTESLIMBASLIK where IND = detay.EVRAKNO)) LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = talepBaslik.IND) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) < 0) " & kriter & "  OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = baslik.REFIND) group by BARCODE), 0) <> 0)  AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) group by baslik.IND, baslik.REFIND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.MIKTAR, detay.BARCODE, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI,  baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan ")
        'DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE,ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar',  ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND  (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and  hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) > 0) " & kriter & "   OR ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = detay.EVRAKNO) group by BARCODE), 0) > 0) AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1))) " & kriter & "   group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK,  detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO),0) as TalepKontrolMiktar, SUM(detay.MIKTAR)  as 'TransferMiktar',  ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)  as 'TeslimMiktar',   baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON  tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON  tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND  (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo  UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078'  GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN  FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID  INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND  (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON  hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAYDOGRULAMA as detay where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and (((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0))   AND (detay.STOKNO Not IN(select STOKNO from ASTOKETIKETTALEPDETAY detayDog Where (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO))) " & kriter & "  group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, /*detay.IND,*/ detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan  ")
        'Sorunlu Ama Çalışıyor DataSet1 = sorgu(" SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar',  ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & "  group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM  tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2)  and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU)  AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2)  and ((ISNULL((SELECT SUM(DOG.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as DOG where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (abaslik.IND = DOG.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (DOG.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "') and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan ")
        DataSet1 = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT baslik.IND,baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and  (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo',  baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID  INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3)  AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND  (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078')  GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN  tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0)  as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris  ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo  AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND  (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo  UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID  INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt),0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & "  group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION SELECT baslik.IND,baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM  tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo  UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2)  and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & "   group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan  UNION SELECT baslik.IND, baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, ISNULL ((select  SUM ( MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG where DOG.EVRAKNO = DETAY.EVRAKNO and DOG.STOKNO = DETAY.STOKNO GROUP BY StokNo),0) as TalepKontrolMiktar, ISNULL ((select sum(MIKTAR) From ASTOKETIKETTALEPDETAY as trn where trn.EVRAKNO=DETAY.EVRAKNO and trn.STOKNO = DETAY.STOKNO GROUP BY StokNo ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and  (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU)  AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTALEPBASLIK as baslik, ASTOKETIKETTALEPDETAY as detay LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = detay.EVRAKNO) where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2)  and ((ISNULL((SELECT SUM(DOG.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAYDOGRULAMA as DOG where (abaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and  (abaslik.IND = DOG.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (DOG.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and (xbaslik.BELGENO = baslik.BELGENO) and (xdetay.BARCODE = detay.BARCODE) and (xbaslik.BELGETIPI = 2) group by BARCODE), 0)) <> 0) " & kriter & " group by baslik.IND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.IND, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI, detay.BARCODE, baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan UNION  SELECT  baslik.IND,baslik.TARIH, baslik.BELGENO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI,detay.BARCODE, ISNULL ((select  SUM ( DOG.MIKTAR)   From ASTOKETIKETTALEPDETAYDOGRULAMA AS DOG   where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and DOG.EVRAKNO = baslik.REFIND  AND DOG.BARCODE = DOG.BARCODE GROUP BY DOG.BARCODE),0) as TalepKontrolMiktar, ISNULL ((select sum(TRN.MIKTAR) From ASTOKETIKETTALEPDETAY as trn where (baslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and trn.EVRAKNO=baslik.REFIND and trn.BARCODE = trn.BARCODE GROUP BY trn.BARCODE ),0) as 'TransferMiktar', ISNULL((SELECT SUM(xdetay.MIKTAR) from ASTOKETIKETTESLIMBASLIK as xbaslik, ASTOKETIKETTESLIMDETAY as xdetay where (xbaslik.TARIH between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "' ) and (xbaslik.IND = xdetay.EVRAKNO) and xbaslik.BELGENO = baslik.BELGENO and (xdetay.BARCODE = detay.BARCODE) group by BARCODE), 0) as 'TeslimMiktar', baslik.DEPO as 'TransferDepo', baslik.TDEPO as 'TeslimDepo', ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket1.lGirisMiktar1 - hareket1.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferKalan', ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket1 ON stok.nStokID = hareket1.nStokID INNER JOIN tbDepo depo ON hareket1.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = detay.STOKKODU) AND (depo.sDepo = baslik.DEPO) and hareket1.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'TransferBekleyen', baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL, detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan from ASTOKETIKETTESLIMBASLIK as baslik, ASTOKETIKETTESLIMDETAY as detay LEFT JOIN ASTOKETIKETTALEPBASLIK talepBaslik ON (talepBaslik.IND = (Select REFIND from ASTOKETIKETTESLIMBASLIK where IND = detay.EVRAKNO)) LEFT JOIN ASTOKETIKETTALEPDETAYDOGRULAMA as detayDog ON (detayDog.STOKNO = detay.STOKNO) AND (detayDog.EVRAKNO = talepBaslik.IND) where (baslik.TARIH between '23/06/2015'   and '23/06/2015'   ) and (baslik.IND = detay.EVRAKNO) and (baslik.BELGETIPI = 2) and ((ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPBASLIK as abaslik, ASTOKETIKETTALEPDETAY as adetay where (abaslik.TARIH between '23/06/2015'   and '23/06/2015'   ) and  (abaslik.IND = adetay.EVRAKNO) and (abaslik.BELGENO = baslik.BELGENO) and (adetay.BARCODE = detay.BARCODE) and (abaslik.BELGETIPI = 2) group by BARCODE), 0) - ISNULL((SELECT SUM(adetay.MIKTAR) from ASTOKETIKETTALEPDETAYDOGRULAMA as adetay  where (adetay.BARCODE = detay.BARCODE) AND (adetay.STOKNO = detay.STOKNO) AND (adetay.EVRAKNO = baslik.REFIND) group by BARCODE), 0) <> 0)  AND ((select bTalepDogrulamaKontrol from tbDepo where (sDepo = baslik.DEPO)) = 1)) " & kriter & " group by baslik.IND, baslik.REFIND, baslik.TARIH, baslik.BELGENO, baslik.KOD3, detay.MIKTAR, detay.BARCODE, detayDog.MIKTAR, detay.EVRAKNO, detay.STOKNO, detay.STOKKODU, detay.MALINCINSI,  baslik.DEPO, baslik.TDEPO, baslik.KAYITTARIHI, baslik.SONUC, detay.RENK, detay.BEDEN, detay.MODEL,  detay.sBirimCinsi, detay.lBirimMiktar, detay.nBirimCarpan ")
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        GridView1.BestFitColumns()
        'GridControl2.DataSource = DataSet2.Tables(0)
        'GridControl2.DataMember = Nothing
        'GridControl2.Focus()
        'GridControl2.Select()
        'GridView2.CollapseAllGroups()
        'GridView2.BestFitColumns()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
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
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("ISTIHBARAT").ToString()
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                If GridView1.RowCount > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If MenuItem17.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem17.Checked = True
        ElseIf MenuItem17.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem17.Checked = False
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
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
        raporla_pdf()
    End Sub
    Friend WithEvents colsIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTransferMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTeslimMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        dataload()
    End Sub
    Friend WithEvents colsTransferDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTeslimDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKAYITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSONUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBEDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMODEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colssFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFIYAT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFIYAT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFIYAT3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colssBirimCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colslBirimMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsnBirimCarpan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalepKontrolMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferBekleyen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            GridControl1.Visible = False
            GridControl2.Visible = True
        Else
            GridControl1.Visible = True
            GridControl2.Visible = False
        End If
    End Sub
End Class