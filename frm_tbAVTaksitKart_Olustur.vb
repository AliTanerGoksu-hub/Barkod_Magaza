Imports System.Windows.Forms
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Wizard
Imports DevExpress.XtraCharts.Design
Imports DevExpress.Charts
Imports DevExpress.XtraEditors
Public Class frm_tbAVTaksitKart_Olustur
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents sec_baslik As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chColorEach As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_renk As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kasatipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_fistipi As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_harekettipi As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_kasakasiyer As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_periyod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbAVTaksitKart_Olustur))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_periyod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_kasatipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_fistipi = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_harekettipi = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_kasakasiyer = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_baslik = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_renk = New DevExpress.XtraEditors.CheckEdit()
        Me.chColorEach = New DevExpress.XtraEditors.CheckEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnOdemeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOdemeSekli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOdemeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOdemeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_periyod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasatipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_harekettipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasakasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_baslik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chColorEach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 173)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_periyod)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sec_kasatipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.sec_fistipi)
        Me.GroupControl1.Controls.Add(Me.sec_harekettipi)
        Me.GroupControl1.Controls.Add(Me.sec_kasakasiyer)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Location = New System.Drawing.Point(104, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(404, 156)
        Me.GroupControl1.TabIndex = 35
        Me.GroupControl1.Text = "Ara"
        '
        'Label3
        '
        Me.Label3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Periyod :"
        '
        'sec_periyod
        '
        Me.sec_periyod.EditValue = "Günlük"
        Me.sec_periyod.EnterMoveNextControl = True
        Me.sec_periyod.Location = New System.Drawing.Point(72, 109)
        Me.sec_periyod.Name = "sec_periyod"
        Me.sec_periyod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_periyod.Properties.Items.AddRange(New Object() {"Günlük", "Haftalýk", "Haftanýn Günü", "Aylýk", "Quarter", "Yýllýk", "Saatlik"})
        Me.sec_periyod.Properties.ReadOnly = True
        Me.sec_periyod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_periyod.Size = New System.Drawing.Size(230, 20)
        Me.sec_periyod.TabIndex = 7
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(304, 91)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl9.TabIndex = 25
        Me.LabelControl9.Text = "Ýçerir"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(304, 69)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Ýçerir"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(304, 47)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "Ýçerir"
        '
        'sec_kasatipi
        '
        Me.sec_kasatipi.EditValue = "Kasiyer:"
        Me.sec_kasatipi.EnterMoveNextControl = True
        Me.sec_kasatipi.Location = New System.Drawing.Point(5, 65)
        Me.sec_kasatipi.Name = "sec_kasatipi"
        Me.sec_kasatipi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_kasatipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_kasatipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasatipi.Properties.Items.AddRange(New Object() {"Kasiyer:", "Kasa:"})
        Me.sec_kasatipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kasatipi.Size = New System.Drawing.Size(67, 20)
        Me.sec_kasatipi.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(29, 91)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "Ýþlemler:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(29, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Maðaza:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(165, 92)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "O.Þekli"
        '
        'sec_fistipi
        '
        Me.sec_fistipi.EditValue = "[Tümü]"
        Me.sec_fistipi.EnterMoveNextControl = True
        Me.sec_fistipi.Location = New System.Drawing.Point(202, 87)
        Me.sec_fistipi.Name = "sec_fistipi"
        Me.sec_fistipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fistipi.Properties.ShowPopupCloseButton = False
        Me.sec_fistipi.Size = New System.Drawing.Size(100, 20)
        Me.sec_fistipi.TabIndex = 6
        '
        'sec_harekettipi
        '
        Me.sec_harekettipi.EditValue = "'1','2'"
        Me.sec_harekettipi.EnterMoveNextControl = True
        Me.sec_harekettipi.Location = New System.Drawing.Point(72, 87)
        Me.sec_harekettipi.Name = "sec_harekettipi"
        Me.sec_harekettipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_harekettipi.Properties.ShowPopupCloseButton = False
        Me.sec_harekettipi.Size = New System.Drawing.Size(88, 20)
        Me.sec_harekettipi.TabIndex = 5
        '
        'sec_kasakasiyer
        '
        Me.sec_kasakasiyer.EditValue = "[Tümü]"
        Me.sec_kasakasiyer.EnterMoveNextControl = True
        Me.sec_kasakasiyer.Location = New System.Drawing.Point(72, 65)
        Me.sec_kasakasiyer.Name = "sec_kasakasiyer"
        Me.sec_kasakasiyer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasakasiyer.Properties.ShowPopupCloseButton = False
        Me.sec_kasakasiyer.Size = New System.Drawing.Size(230, 20)
        Me.sec_kasakasiyer.TabIndex = 4
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(72, 43)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(230, 20)
        Me.sec_depo.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(304, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Arasýndaki"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(168, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "ve"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(42, 22)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 6, 16, 19, 41, 57, 199)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(202, 21)
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
        Me.DateEdit1.Location = New System.Drawing.Point(72, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(88, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(72, 131)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(231, 20)
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "&Listele"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(776, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(46, 11)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.sec_baslik)
        Me.PanelControl2.Controls.Add(Me.sec_renk)
        Me.PanelControl2.Controls.Add(Me.chColorEach)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(169, 16)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(145, 20)
        Me.SimpleButton4.TabIndex = 17
        Me.SimpleButton4.Text = "&Olustur"
        '
        'sec_baslik
        '
        Me.sec_baslik.EditValue = True
        Me.sec_baslik.Location = New System.Drawing.Point(496, 16)
        Me.sec_baslik.Name = "sec_baslik"
        Me.sec_baslik.Properties.Caption = "Baþlýk Göster"
        Me.sec_baslik.Size = New System.Drawing.Size(96, 19)
        Me.sec_baslik.TabIndex = 16
        Me.sec_baslik.Visible = False
        '
        'sec_renk
        '
        Me.sec_renk.Location = New System.Drawing.Point(394, 16)
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.Properties.Caption = "Yüzdeyi Göster"
        Me.sec_renk.Size = New System.Drawing.Size(96, 19)
        Me.sec_renk.TabIndex = 15
        Me.sec_renk.Visible = False
        '
        'chColorEach
        '
        Me.chColorEach.EditValue = True
        Me.chColorEach.Location = New System.Drawing.Point(320, 16)
        Me.chColorEach.Name = "chColorEach"
        Me.chColorEach.Properties.Caption = "Renklendir"
        Me.chColorEach.Size = New System.Drawing.Size(80, 19)
        Me.chColorEach.TabIndex = 14
        Me.chColorEach.Visible = False
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
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 173)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 208)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 204)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.sec_grid)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 171)
        Me.XtraTabPage1.Text = "Ta&blo..."
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(174, 8)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(232, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.GridColumn1, Me.colACIKLAMA})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colSEC
        '
        Me.colSEC.Caption = "Seçim"
        Me.colSEC.FieldName = "SEC"
        Me.colSEC.Name = "colSEC"
        Me.colSEC.Visible = True
        Me.colSEC.VisibleIndex = 0
        Me.colSEC.Width = 48
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kod"
        Me.GridColumn1.FieldName = "KOD"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 52
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.OptionsColumn.AllowFocus = False
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        Me.colACIKLAMA.Width = 128
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(818, 171)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem15, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem15
        '
        Me.MenuItem15.Index = 8
        Me.MenuItem15.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 9
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 10
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 11
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 12
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 13
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 14
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 15
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "PERIYOD"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "KOD"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TUTAR"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MUSTERISAYISI"
        Me.DataColumn4.DataType = GetType(Long)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnOdemeID, Me.colsOdemeSekli, Me.collOdemeTutar, Me.coldteOdemeTarihi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "{0:#,0.00}")})
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
        'colnOdemeID
        '
        Me.colnOdemeID.Caption = "OdemeNo"
        Me.colnOdemeID.FieldName = "nOdemeID"
        Me.colnOdemeID.Name = "colnOdemeID"
        Me.colnOdemeID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nOdemeID", "{0} Kayýt")})
        Me.colnOdemeID.Visible = True
        Me.colnOdemeID.VisibleIndex = 0
        '
        'colsOdemeSekli
        '
        Me.colsOdemeSekli.Caption = "Ödeme Þekli"
        Me.colsOdemeSekli.FieldName = "sOdemeSekli"
        Me.colsOdemeSekli.Name = "colsOdemeSekli"
        Me.colsOdemeSekli.Visible = True
        Me.colsOdemeSekli.VisibleIndex = 1
        '
        'collOdemeTutar
        '
        Me.collOdemeTutar.Caption = "Tutar"
        Me.collOdemeTutar.FieldName = "lOdemeTutar"
        Me.collOdemeTutar.Name = "collOdemeTutar"
        Me.collOdemeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOdemeTutar", "{0:#,0.00##}")})
        Me.collOdemeTutar.Visible = True
        Me.collOdemeTutar.VisibleIndex = 2
        '
        'coldteOdemeTarihi
        '
        Me.coldteOdemeTarihi.Caption = "OdemeTarihi"
        Me.coldteOdemeTarihi.FieldName = "dteOdemeTarihi"
        Me.coldteOdemeTarihi.Name = "coldteOdemeTarihi"
        Me.coldteOdemeTarihi.Visible = True
        Me.coldteOdemeTarihi.VisibleIndex = 3
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ChartControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(818, 171)
        Me.XtraTabPage2.Text = "&Grafik..."
        '
        'ChartControl1
        '
        Me.ChartControl1.DataSource = Me.DataTable1
        XyDiagram1.AxisX.Interlaced = True
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.Tickmarks.MinorVisible = False
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Interlaced = True
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.Tickmarks.MinorVisible = False
        XyDiagram1.AxisY.Tickmarks.Visible = False
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "PERIYOD"
        SideBySideBarSeriesLabel1.LineVisible = True
        PointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        SideBySideBarSeriesLabel1.PointOptions = PointOptions1
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "TUTAR"
        SideBySideBarSeriesView1.ColorEach = True
        Series1.View = SideBySideBarSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        SideBySideBarSeriesView2.ColorEach = True
        Me.ChartControl1.SeriesTemplate.View = SideBySideBarSeriesView2
        Me.ChartControl1.Size = New System.Drawing.Size(818, 171)
        Me.ChartControl1.TabIndex = 0
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Periyodik Ciro Analizi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment- Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.ChartControl1
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Landscape = True
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.Owner = Nothing
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Ciro Grafiði", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment-Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'frm_tbAVTaksitKart_Olustur
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbAVTaksitKart_Olustur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kredi Kartlarý Odemelerini Olustur..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_periyod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasatipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_harekettipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasakasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_baslik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chColorEach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim tarih As DateTime
    Dim tarihGun As DateTime
    Dim ds_magaza As DataSet
    Dim ds_kasiyer As DataSet
    Dim ds_kasa As DataSet
    Dim ds_harekettipi As DataSet
    Dim ds_fistipi As DataSet
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
        DateEdit1.Focus()
        DateEdit1.Select()
        dataload_depo()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_depo()
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        ds_kasiyer = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sKasiyerRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '') ORDER BY sAdi"))
        ds_kasa = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nKasaNo AS KOD, sAciklama AS ACIKLAMA FROM         tbParekendeKasa"))
        ds_harekettipi = sorgu(sorgu_query("SELECT     CAST('1' AS bit) AS SEC, nOdemeKodu AS KOD, sAciklama AS ACIKLAMA FROM         tbOdemeKodu WHERE     (nOdemeKodu IN (1, 2))"))
        ds_fistipi = sorgu(sorgu_query("SELECT     CAST('0' AS bit) AS SEC, sOdemeSekli AS KOD, sAciklama AS ACIKLAMA FROM         tbOdemeSekli ORDER BY sOdemeSekli"))
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
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridView1.ColumnsCustomization()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            degistir_grafik()
        End If
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
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Periyodik Tahsilat Analizi" & vbCrLf
        kriter += "Maðaza = " & sec_depo.Text & vbTab & "Periyod : " & sec_periyod.Text & vbTab & "Kasa/Kasiyer:" & sec_kasakasiyer.Text
        'printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        'printlink1.CreateDocument(ps)
        'ps.PreviewRibbonFormEx.Show()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment-Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment-Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal periyod As String) As DataSet
        Dim kriter As String = ""
        kriter += " WHERE  (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND tbOdeme.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND tbOdeme.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND tbOdeme.sMagaza IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter += " AND tbOdeme.nOdemeKodu IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter += " AND tbOdeme.sOdemeSekli IN ( " & fistipi & ")"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFIRST 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DATEPART(DW, tbOdeme.dteOdemeTarihi) as nSatisGun, tbOdeme.nOdemeID, tbOdeme.sOdemeSekli, tbOdeme.lOdemeTutar, tbOdeme.dteOdemeTarihi, tbBankaOdemeSekli.* FROM tbAlisVeris INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID INNER JOIN tbDepo ON tbOdeme.sMagaza = tbDepo.sDepo INNER JOIN tbBankaOdemeSekli ON tbOdeme.sOdemeSekli = tbBankaOdemeSekli.sOdemeSekli " & kriter & " ORDER BY tbOdeme.sOdemeSekli, tbOdeme.nOdemeID")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub tbAVTaksitKart_kaydet_sil(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal periyod As String)
        Dim kriter As String = ""
        kriter += " AND  (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND tbOdeme.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND tbOdeme.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND tbOdeme.sMagaza IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter += " AND tbOdeme.nOdemeKodu IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter += " AND tbOdeme.sOdemeSekli IN ( " & fistipi & ")"
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE tbAVKartTaksit FROM tbalisveris, tbBankaOdemeSekli, tbDepo, tbOdeme WHERE tbOdeme.nAlisverisID = tbalisveris.nAlisverisID AND tbDepo.sDepo = tbOdeme.sMagaza AND tbOdeme.sOdemeSekli = tbBankaOdemeSekli.sOdemeSekli " & kriter & " AND tbAVKartTaksit.nOdemeID = tbOdeme.nOdemeID ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbAVTaksitKart_kaydet_ekle(ByVal nOdemeID As String, ByVal sOdemeSekli As String, ByVal dteTaksitTarihi As DateTime, ByVal lTaksitTutari As Decimal, ByVal lIadeTutari As Decimal, ByVal lPuan As Decimal, ByVal lPuanKdv As Decimal, ByVal lServisBedeli As Decimal, ByVal lKomisyonTutari As Decimal, ByVal bKullaniciDegistirdi As Integer, ByVal sDegistirenKullaniciAdi As String, ByVal dteDegisiklikTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal lKomisyonKDV As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAVKartTaksit (nOdemeID, sOdemeSekli, dteTaksitTarihi, lTaksitTutari, lIadeTutari, lPuan, lPuanKdv, lServisBedeli, lKomisyonTutari, bKullaniciDegistirdi, sDegistirenKullaniciAdi, dteDegisiklikTarihi, sKullaniciAdi, dteKayitTarihi, lKomisyonKDV) VALUES ('" & nOdemeID & "', '" & sOdemeSekli & "', '" & dteTaksitTarihi & "', " & lTaksitTutari & ", " & lIadeTutari & ", " & lPuan & ", " & lPuanKdv & ", " & lServisBedeli & ", " & lKomisyonTutari & ", " & bKullaniciDegistirdi & ", '" & sDegistirenKullaniciAdi & "', '" & dteDegisiklikTarihi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & lKomisyonKDV & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal periyod As String)
        DataSet1 = stok(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, periyod)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        'ChartControl1.DataSource = DataSet1.Tables(0)
        'ChartControl1.Refresh()
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text, sec_kasatipi.Text, sec_kasakasiyer.Text, sec_harekettipi.Text, sec_fistipi.Text, sec_periyod.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        'Dim dr As DataRow
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'lbl_istihbarat.Text = dr("ISTIHBARAT")
        'dr = Nothing
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            'Me.Close()
        End If
    End Sub
    Private Sub degistir_grafik()
        ' Create a chart.
        'Dim Chart As New ChartControl
        ' Set its datasource.
        ' Note that you can also set any other specific options for the chart here.
        'Chart.DataSource = DataSet1.Tables(0)
        ' Run the chart's wizard.
        'ChartControl1.SeriesTemplate.ChangeView(ViewType.Pie)
        'ChartWizard.Run(Me.ChartControl1, Nothing, True)
        Dim chartWizard_Renamed As ChartWizard = New ChartWizard(Me.ChartControl1)
        chartWizard_Renamed.ShowDialog()
        If TypeOf ChartControl1.Series(0).View Is SeriesViewColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesViewColorEachSupportBase).ColorEach
        ElseIf TypeOf ChartControl1.Series(0).View Is SeriesView3DColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesView3DColorEachSupportBase).ColorEach
        Else
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            chColorEach.Enabled = False
            chColorEach.Checked = False
        End If
        ' Create a form, add the chart to it, and display the form.
        'Dim Form1 As New Form
        'Form1.Controls.Add(Chart)
        'Form1.Show()
    End Sub
    Private Sub chColorEach_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chColorEach.CheckedChanged
        If chColorEach.Enabled Then
            Dim series As Series
            For Each series In ChartControl1.Series
                If TypeOf ChartControl1.Series(0).View Is SeriesViewColorEachSupportBase Then
                    CType(ChartControl1.Series(0).View, SeriesViewColorEachSupportBase).ColorEach = chColorEach.Checked
                ElseIf TypeOf ChartControl1.Series(0).View Is SeriesView3DColorEachSupportBase Then
                    CType(ChartControl1.Series(0).View, SeriesView3DColorEachSupportBase).ColorEach = chColorEach.Checked
                End If
            Next series
        End If
    End Sub
    Private Sub sec_baslik_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_baslik.CheckedChanged
        If sec_baslik.Checked = True Then
            ChartControl1.Series(0).Label.PointOptions.PointView = PointView.ArgumentAndValues
        ElseIf sec_baslik.Checked = False Then
            ChartControl1.Series(0).Label.PointOptions.PointView = PointView.Values
        End If
    End Sub
    Private Sub sec_renk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_renk.CheckedChanged
        If sec_renk.Checked = True Then
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
        ElseIf sec_renk.Checked = False Then
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        End If
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        'If s.ToString <> "" Then
        '    e.Value = s.ToString
        'Else
        '    e.Value = "[Tümü]"
        'End If
        Return s.ToString
    End Function
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.BeginEdit()
            dr.EndEdit()
            GridControl2.Focus()
            GridControl2.Select()
        End If
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_fistipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_fistipi.QueryResultValue
        Dim s As String = deger(ds_fistipi)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_harekettipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_harekettipi.QueryResultValue
        Dim s As String = deger(ds_harekettipi)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_kasakasiyer_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_kasakasiyer.QueryResultValue
        Dim s As String = ""
        If sec_kasatipi.Text = "Kasa:" Then
            s = deger(ds_kasa)
        ElseIf sec_kasatipi.Text = "Kasiyer:" Then
            s = deger(ds_kasiyer)
        End If
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.F4 Then
            ClosePopup()
        ElseIf e.KeyCode = Keys.Escape Then
            ClosePopup()
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_fistipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_fistipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = sec_grid
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_fistipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_kasakasiyer_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_kasakasiyer.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = sec_grid
        sec_depo.Properties.PopupControl = Nothing
        If sec_kasatipi.Text = "Kasa:" Then
            GridControl2.DataSource = ds_kasa.Tables(0)
        ElseIf sec_kasatipi.Text = "Kasiyer:" Then
            GridControl2.DataSource = ds_kasiyer.Tables(0)
        End If
        'GridControl2.DataSource = ds_kasiyer.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_harekettipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_harekettipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = sec_grid
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_harekettipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Friend WithEvents colnOdemeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOdemeSekli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOdemeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOdemeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show(Sorgu_sDil("Taksit Kartlarýnýn Odemelerini Olusturmak Ýstediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbAVTaksitKart_Olustur()
        End If
    End Sub
    Private Sub tbAVTaksitKart_Olustur()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        tbAVTaksitKart_kaydet_sil(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text, sec_kasatipi.Text, sec_kasakasiyer.Text, sec_harekettipi.Text, sec_fistipi.Text, sec_periyod.Text)
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            Dim i As Integer
            Dim x As Integer
            Dim dteTarihi As DateTime
            Dim TaksitSayisi As Int64 = dr("nTaksitSayisi")
            Dim nTaksitID As String = ""
            Dim dteBaslangic As DateTime = dr("dteOdemeTarihi")
            Dim lTaksitTutari As Decimal = 0
            Dim lIadeTutari As Decimal = 0
            Dim lPuan As Decimal = 0
            Dim lPuanKdv As Decimal = 0
            Dim lServisBedeli As Decimal = 0
            Dim lKomisyonTutari As Decimal = 0
            Dim lKomisyonKDV As Decimal = 0
            Dim lKomisyonTutari2 As Decimal = 0
            Dim lKomisyon As Decimal = 0
            Dim bEkle As Boolean = True
            Dim nEkle As Integer = 0
            If dr("lOdemeTutar") > 0 Then
                If TaksitSayisi = 0 Then
                    lTaksitTutari = dr("lOdemeTutar") / 1
                Else
                    lTaksitTutari = dr("lOdemeTutar") / TaksitSayisi
                End If
                lIadeTutari = 0
            ElseIf dr("lOdemeTutar") < 0 Then
                If TaksitSayisi = 0 Then
                    lIadeTutari = dr("lOdemeTutar") / 1
                Else
                    lIadeTutari = dr("lOdemeTutar") / TaksitSayisi
                End If
                lTaksitTutari = 0
            End If
            dteTarihi = dteBaslangic
            'Satis Gunu Protokol Kontrolu
            'Satis Gunu Protokol Kontrolu
            'Cuma
            If dr("nSatisGun") = 5 Then
                If dr("bS_Cuma_Pazar") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                ElseIf dr("bs_Cuma_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 3, dteTarihi)
                    bEkle = False
                ElseIf dr("bs_Cuma_Cumartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cuma_Cuma") = True Then
                    dteBaslangic = dteTarihi
                End If
                dteBaslangic = dteTarihi
                'Cumartesi
            ElseIf dr("nSatisGun") = 6 Then
                If dr("bS_Cumartesi_Pazar") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cumartesi_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cumartesi_Cumartesi") = True Then
                    dteBaslangic = dteTarihi
                End If
                dteBaslangic = dteTarihi

                'Pazar
            ElseIf dr("nSatisGun") = 7 Then
                If dr("bS_Pazar_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Pazar_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
            End If
            dteBaslangic = dteTarihi
            'Taksit Hesapla
            For i = 1 To TaksitSayisi
                'Bonus Hesapla
                If dr("nBonusOrani") <> 0 Then
                    lPuan = (dr("lOdemeTutar") * dr("nBonusOrani")) / 100
                    If dr("nBonus_KdvOrani") <> 0 Then
                        lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                    End If
                End If
                'Komisyon Hesapla
                If dr("nKomisyonOrani") <> 0 Then
                    If lTaksitTutari <> 0 Then
                        lKomisyonTutari = (lTaksitTutari * dr("nKomisyonOrani")) / 100
                    Else
                        lKomisyonTutari = (lIadeTutari * dr("nKomisyonOrani")) / 100
                    End If
                    If dr("nKomisyon_Kdv_Orani") <> 0 Then
                        lKomisyonKDV = (lKomisyonTutari * dr("nKomisyon_Kdv_Orani")) / 100
                    End If
                End If
                lKomisyon = lKomisyonTutari
                'Ek Komisyon Hesapla
                If dr("nKomisyonOrani_2") <> 0 Then
                    If dr("nKomisyonOrani_2_Aciklama") = 0 Then
                        lKomisyonTutari2 += (dr("lOdemeTutar") * dr("nKomisyonOrani_2")) / 100
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 1 Then
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 2 Then
                        lKomisyonTutari2 += ((dr("lOdemeTutar") - lKomisyonTutari) * dr("nKomisyonOrani_2")) / 100
                    End If
                End If
                'Taksit Protokol Kontrolu
              If i > 1 Then
                    If dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            If dr("nTaksit" & i & "") <> 0 Then
                                dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit" & i & ""), dteTarihi)
                            Else
                                dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                            End If
                        ElseIf dr("bTaksit_Satis") = 2 Then
                            If dr("nTaksit" & i & "") <> 2 Then
                                dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit" & i & ""), dteTarihi)
                            End If
                        End If
                    Else
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    End If


                    If dr("nBonus_Puan") = 0 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 2 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 3 Then
                        lPuan = 0
                        lPuanKdv = 0
                    End If
                    If dr("bKomisyon_IlkTaksit") = 1 Then
                        lKomisyonTutari = 0
                        lKomisyonKDV = 0
                    End If
                    'ElseIf i = 2 Then
                    '    dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    '    'If bEkle = True Then
                    '    '    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    '    'End If
                ElseIf i = 1 Then
                    'Ýlk Taksit
                    lKomisyonTutari += lKomisyonTutari2
                    If dr("nTaksit") = 0 Then
                        Dim gun As Integer = 0
                        Dim ay As Integer = 0
                        Dim yil As Integer = 0
                        gun = dteTarihi.Day
                        ay = dteTarihi.Month
                        yil = dteTarihi.Year
                        If gun > 0 And dteTarihi.Day <= dr("nAlisGun1") Then
                            If dr("bS_Bulundugu_Ay1") = 0 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 1 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 2 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun1") And gun <= dr("nAlisGun2") Then
                            If dr("bS_Bulundugu_Ay2") = 0 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 1 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 2 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun2") And gun <= dr("nAlisGun3") Then
                            If dr("bS_Bulundugu_Ay3") = 0 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 1 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 2 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun3") And gun <= dr("nAlisGun4") Then
                            If dr("bS_Bulundugu_Ay4") = 0 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 1 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 2 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun4") And gun <= dr("nAlisGun5") Then
                            If dr("bS_Bulundugu_Ay5") = 0 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 1 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 2 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun5") And gun <= dr("nAlisGun6") Then
                            If dr("bS_Bulundugu_Ay6") = 0 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 1 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 2 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        End If
                    ElseIf dr("nTaksit") = 1 Then
                        dteTarihi = DateAdd(DateInterval.Day, dr("nIlkTaksitSonra"), dteBaslangic)
                    ElseIf dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteBaslangic)
                        ElseIf dr("bTaksit_Satis") = 1 Then
                            'MsgBox(dteBaslangic)
                            'If bEkle = True Then
                            If dr("nSatisGun") = 5 Then
                                dteTarihi = DateAdd(DateInterval.Day, 2, dr("dteOdemeTarihi"))
                                nEkle = 2
                            ElseIf dr("nSatisGun") = 6 Then
                                dteTarihi = DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi"))
                                nEkle = 1
                            ElseIf dr("nSatisGun") = 7 Then
                                dteTarihi = DateAdd(DateInterval.Day, 0, dr("dteOdemeTarihi"))
                                nEkle = 0
                            End If
                            'End If
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteTarihi)
                        ElseIf dr("bTaksit_Satis") = 2 Then
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteTarihi)
                        End If
                    ElseIf dr("nTaksit") = 3 Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    End If
                End If
                'Servis Bedeli Hesapla
                If dr("nBSMV") <> 0 Then
                    If dr("bServisAlisveristen") = 0 Then
                        lServisBedeli = (lKomisyon * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 1 Then
                        lServisBedeli = (lKomisyonTutari * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 2 Then
                        If lTaksitTutari <> 0 Then
                            lServisBedeli = (lTaksitTutari * dr("nBSMV")) / 100
                        Else
                            lServisBedeli = (lIadeTutari * dr("nBSMV")) / 100
                        End If
                    End If
                End If
                'Puan Protokol Kontrolu
                If dr("nBonus_Puan") = 2 Then
                    lPuan = 0
                    lPuanKdv = 0
                ElseIf dr("nBonus_Puan") = 3 Then
                    lPuan = 0
                    lPuanKdv = 0
                End If
                'Taksit Gunu Kontrolu
                If dteTarihi = tarih Then
                    If dr("bTaksit_Tatil_Gunleri") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                        'nEkle = 1
                    End If
                ElseIf dteTarihi <= tarihGun Then
                    If dteTarihi > tarih Then
                        x = tarihGun.Day - dteTarihi.Day
                        If dr("bTaksit_Tatil_Gunleri") = True Then
                            dteTarihi = DateAdd(DateInterval.Day, x, dteTarihi)
                            'nEkle = 1
                        End If
                    End If
                End If

                If dteTarihi.DayOfWeek = DayOfWeek.Saturday Then
                    If dr("bT_Cumartesi_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                        nEkle = 2
                    End If
                ElseIf dteTarihi.DayOfWeek = DayOfWeek.Sunday Then
                    If dr("bT_Pazar_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                        nEkle = 1
                    End If
                End If
                'Ekle
                tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dteTarihi, lTaksitTutari, lIadeTutari, lPuan, lPuanKdv, lServisBedeli, lKomisyonTutari, 0, kullanici, "01/01/1900", kullanici, Today, lKomisyonKDV)
                'If dr("nTaksit") <> 3 Then
                '    If nEkle > 0 Then
                '        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                '        nEkle = 0
                '    End If
                'End If
                If dr("nTaksit") = 2 Then
                    If dr("bTaksit_Satis") = 1 Or dr("bTaksit_Satis") = 2 Then
                        If nEkle > 0 Then
                            dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                            nEkle = 0
                        End If
                    End If
                ElseIf dr("nTaksit") = 0 Then
                    If nEkle > 0 Then
                        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                        nEkle = 0
                    End If
                End If
                'Taksit Protokol Kontrolu
                'If i = 1 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                '    End If
                'ElseIf i = 2 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, -1, dteTarihi)
                '    End If
                'End If
                Dim conn As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                Dim adapter As New OleDb.OleDbDataAdapter
                conn.ConnectionString = connection
                cmd.Connection = conn
                conn.Open()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select dteTatilGunuBasla,dteTatilGunuBitis from tbResmiTatilGunleri where dteTatilGunuBasla <='" & dteTarihi & "' AND dteTatilGunuBitis >='" & dteTarihi & "' ")
                Dim oku As OleDb.OleDbDataReader = cmd.ExecuteReader
                While oku.Read
                    tarih = oku("dteTatilGunuBasla")
                    tarihGun = oku("dteTatilGunuBitis")
                End While
                conn.Close()
            Next
            'Bonus Hesapla
            If dr("nBonusOrani") <> 0 Then
                lPuan = (dr("lOdemeTutar") * dr("nBonusOrani")) / 100
                If dr("nBonus_KdvOrani") <> 0 Then
                    lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                End If
            End If
            If dr("nBonus_Puan") = 2 Then
                tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dr("dteOdemeTarihi"), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today, lKomisyonKDV)
            ElseIf dr("nBonus_Puan") = 3 Then
                tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi")), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today, lKomisyonKDV)
            End If
        Next
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        If MenuItem15.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem15.Checked = True
        ElseIf MenuItem15.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem15.Checked = False
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class
