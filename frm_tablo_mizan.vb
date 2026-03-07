Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tablo_mizan
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
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
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
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataColumn10 As System.Data.DataColumn
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
    Friend WithEvents sec_DC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_FS As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tablo_mizan))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_DC = New DevExpress.XtraEditors.CheckEdit
        Me.sec_FS = New DevExpress.XtraEditors.CheckEdit
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHesap1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHesap2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHesap3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklamaKebir = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklamaGrup1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklamaGrup2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBorc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAlacak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBorcBakiye = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAlacakBakiye = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOncekiBorc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOncekiAlacak = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOncekiBorcBakiye = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOncekiAlacakBakiye = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBilancoGrup2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklamaBilancoGrup2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsOzelNot = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
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
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
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
        CType(Me.sec_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_FS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 88)
        Me.PanelControl1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.sec_DC)
        Me.GroupControl1.Controls.Add(Me.sec_FS)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Location = New System.Drawing.Point(112, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(352, 75)
        Me.GroupControl1.TabIndex = 39
        Me.GroupControl1.Text = "Ara"
        '
        'sec_DC
        '
        Me.sec_DC.Location = New System.Drawing.Point(98, 51)
        Me.sec_DC.Name = "sec_DC"
        Me.sec_DC.Properties.Caption = "DC"
        Me.sec_DC.Size = New System.Drawing.Size(44, 19)
        Me.sec_DC.TabIndex = 41
        '
        'sec_FS
        '
        Me.sec_FS.EditValue = True
        Me.sec_FS.Location = New System.Drawing.Point(62, 51)
        Me.sec_FS.Name = "sec_FS"
        Me.sec_FS.Properties.Caption = "FS"
        Me.sec_FS.Size = New System.Drawing.Size(36, 19)
        Me.sec_FS.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(272, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasındaki"
        '
        'Label7
        '
        Me.Label7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(-4, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(161, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(181, 23)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit2.Properties.Appearance.Options.UseBackColor = True
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
        Me.DateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.DateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(181, 48)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(83, 20)
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
        Me.lbl_istihbarat.TabIndex = 36
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 34
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
        Me.PanelControl2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 88)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 270)
        Me.PanelControl3.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 266)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 240)
        Me.XtraTabPage1.Text = "Tablo..."
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(814, 240)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Baslik"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Aciklama"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Miktar"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Tutar"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Sayi"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Kar"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Yuzde"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Not"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Status"
        Me.DataColumn10.DataType = GetType(Boolean)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsKodu, Me.colsHesap1, Me.colsHesap2, Me.colsHesap3, Me.colsAciklama, Me.colsAciklamaKebir, Me.colsAciklamaGrup1, Me.colsAciklamaGrup2, Me.collBorc, Me.collAlacak, Me.collBorcBakiye, Me.collAlacakBakiye, Me.collOncekiBorc, Me.collOncekiAlacak, Me.collOncekiBorcBakiye, Me.collOncekiAlacakBakiye, Me.colsBilancoGrup2, Me.colsAciklamaBilancoGrup2, Me.colsOzelNot})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(529, 214, 208, 154)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 3
        Me.colsKodu.Width = 137
        '
        'colsHesap1
        '
        Me.colsHesap1.Caption = "Hesap1"
        Me.colsHesap1.FieldName = "sHesap1"
        Me.colsHesap1.Name = "colsHesap1"
        Me.colsHesap1.Visible = True
        Me.colsHesap1.VisibleIndex = 0
        Me.colsHesap1.Width = 135
        '
        'colsHesap2
        '
        Me.colsHesap2.Caption = "Hesap2"
        Me.colsHesap2.FieldName = "sHesap2"
        Me.colsHesap2.Name = "colsHesap2"
        Me.colsHesap2.Visible = True
        Me.colsHesap2.VisibleIndex = 1
        Me.colsHesap2.Width = 135
        '
        'colsHesap3
        '
        Me.colsHesap3.Caption = "Hesap3"
        Me.colsHesap3.FieldName = "sHesap3"
        Me.colsHesap3.Name = "colsHesap3"
        Me.colsHesap3.Visible = True
        Me.colsHesap3.VisibleIndex = 2
        Me.colsHesap3.Width = 135
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açıklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 4
        Me.colsAciklama.Width = 239
        '
        'colsAciklamaKebir
        '
        Me.colsAciklamaKebir.Caption = "AçıklamaKebir"
        Me.colsAciklamaKebir.FieldName = "sAciklamaKebir"
        Me.colsAciklamaKebir.Name = "colsAciklamaKebir"
        '
        'colsAciklamaGrup1
        '
        Me.colsAciklamaGrup1.Caption = "Açıklama Grup 1"
        Me.colsAciklamaGrup1.FieldName = "sAciklamaGrup1"
        Me.colsAciklamaGrup1.Name = "colsAciklamaGrup1"
        '
        'colsAciklamaGrup2
        '
        Me.colsAciklamaGrup2.Caption = "Açıklama Grup 2"
        Me.colsAciklamaGrup2.FieldName = "sAciklamaGrup2"
        Me.colsAciklamaGrup2.Name = "colsAciklamaGrup2"
        '
        'collBorc
        '
        Me.collBorc.Caption = "Borç"
        Me.collBorc.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorc.FieldName = "lBorc"
        Me.collBorc.Name = "collBorc"
        Me.collBorc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorc", "{0:#,0.00}")})
        Me.collBorc.Visible = True
        Me.collBorc.VisibleIndex = 5
        Me.collBorc.Width = 144
        '
        'collAlacak
        '
        Me.collAlacak.Caption = "Alacak"
        Me.collAlacak.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacak.FieldName = "lAlacak"
        Me.collAlacak.Name = "collAlacak"
        Me.collAlacak.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacak", "{0:#,0.00}")})
        Me.collAlacak.Visible = True
        Me.collAlacak.VisibleIndex = 6
        Me.collAlacak.Width = 110
        '
        'collBorcBakiye
        '
        Me.collBorcBakiye.Caption = "Borç Bakiyesi"
        Me.collBorcBakiye.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collBorcBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcBakiye.FieldName = "lBorcBakiye"
        Me.collBorcBakiye.Name = "collBorcBakiye"
        Me.collBorcBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcBakiye", "{0:#,0.00}")})
        Me.collBorcBakiye.Visible = True
        Me.collBorcBakiye.VisibleIndex = 7
        Me.collBorcBakiye.Width = 110
        '
        'collAlacakBakiye
        '
        Me.collAlacakBakiye.Caption = "Alacak Bakiyesi"
        Me.collAlacakBakiye.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collAlacakBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakBakiye.FieldName = "lAlacakBakiye"
        Me.collAlacakBakiye.Name = "collAlacakBakiye"
        Me.collAlacakBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakBakiye", "{0:#,0.00}")})
        Me.collAlacakBakiye.Visible = True
        Me.collAlacakBakiye.VisibleIndex = 8
        Me.collAlacakBakiye.Width = 122
        '
        'collOncekiBorc
        '
        Me.collOncekiBorc.Caption = "Önceki Borç"
        Me.collOncekiBorc.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collOncekiBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOncekiBorc.FieldName = "lOncekiBorc"
        Me.collOncekiBorc.Name = "collOncekiBorc"
        Me.collOncekiBorc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOncekiBorc", "{0:#,0.00}")})
        '
        'collOncekiAlacak
        '
        Me.collOncekiAlacak.Caption = "Önceki Alacak"
        Me.collOncekiAlacak.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collOncekiAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOncekiAlacak.FieldName = "lOncekiAlacak"
        Me.collOncekiAlacak.Name = "collOncekiAlacak"
        Me.collOncekiAlacak.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOncekiAlacak", "{0:#,0.00}")})
        '
        'collOncekiBorcBakiye
        '
        Me.collOncekiBorcBakiye.Caption = "Önceki Borç Bakiyesi"
        Me.collOncekiBorcBakiye.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collOncekiBorcBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOncekiBorcBakiye.FieldName = "lOncekiBorcBakiye"
        Me.collOncekiBorcBakiye.Name = "collOncekiBorcBakiye"
        Me.collOncekiBorcBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOncekiBorcBakiye", "{0:#,0.00}")})
        '
        'collOncekiAlacakBakiye
        '
        Me.collOncekiAlacakBakiye.Caption = "Önceki Alacak Bakiyesi"
        Me.collOncekiAlacakBakiye.DisplayFormat.FormatString = "{0:#,0.00}"
        Me.collOncekiAlacakBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOncekiAlacakBakiye.FieldName = "lOncekiAlacakBakiye"
        Me.collOncekiAlacakBakiye.Name = "collOncekiAlacakBakiye"
        Me.collOncekiAlacakBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lOncekiAlacakBakiye", "{0:#,0.00}")})
        '
        'colsBilancoGrup2
        '
        Me.colsBilancoGrup2.Caption = "Bilanço Grup 2"
        Me.colsBilancoGrup2.FieldName = "sBilancoGrup2"
        Me.colsBilancoGrup2.Name = "colsBilancoGrup2"
        '
        'colsAciklamaBilancoGrup2
        '
        Me.colsAciklamaBilancoGrup2.Caption = "Açıklama Bilanço Grup 2"
        Me.colsAciklamaBilancoGrup2.FieldName = "sAciklamaBilancoGrup2"
        Me.colsAciklamaBilancoGrup2.Name = "colsAciklamaBilancoGrup2"
        '
        'colsOzelNot
        '
        Me.colsOzelNot.Caption = "Özel Not"
        Me.colsOzelNot.FieldName = "sOzelNot"
        Me.colsOzelNot.Name = "colsOzelNot"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 245)
        Me.XtraTabPage2.Text = "Detay..."
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
        Me.MenuItem2.Text = "Başlık Değiştir"
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
        Me.MenuItem4.Text = "Görünümü Yazdır"
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
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 10
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 11
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 12
        Me.MenuItem8.Text = "Satırları Kapat"
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
        Me.MenuItem9.Text = "Ekranı Kapla"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Durum Tablosu", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "information", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Yazdır,Ctrl+P"
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
        'frm_tablo_mizan
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
        Me.Name = "frm_tablo_mizan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mizan"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_FS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public islemstatus As Boolean = False
    Public firmatipi As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim tutar As Decimal = 0
    Dim maliyet As Decimal = 0
    Dim kar As Decimal = 0
    Dim miktar As Decimal = 0
    Dim sayi As Decimal = 0
    Dim masraf As Decimal = 0
    Dim masrafsayi As Decimal = 0
    Dim satiskari As Decimal = 0
    Dim ds1 As DataSet
    Private Sub frm_tablo_durum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = "01/01/1900" '"01/01/" + Today.Year.ToString
        DateEdit2.EditValue = dteSistemTarihi '"31/12/" + Today.Year.ToString
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub yetki_kontrol()
        Dim yetki As Int64 = Sorgu_Yetki(kullanici, Me.Name)
        If yetki = 0 Then
            Me.Hide()
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!" & vbCrLf & "Lütfen Sistem Yönecinizle Görüşün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf yetki = 1 Then
        End If
    End Sub
    Private Function Sorgu_Yetki(ByVal kasiyerno As Int64, ByVal Form As String, Optional ByVal islem As Integer = 0, Optional ByVal bYetki As Integer = 0) As Int64
        Dim kriter
        kriter = " WHERE     (Personel.PersonelNo = " & kasiyerno & ") AND (Forms.Form = '" & Form & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         aEmirForms WHERE     (Form = '" & Form & "')")
        formkayitsayisi = cmd.ExecuteScalar
        If formkayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES     ('Genel', '" & Form & "', '" & Form & "', " & bYetki & ")")
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(CAST(Personel.Yetki AS int), 0) AS Yetki FROM         aPersonelYetki Personel INNER JOIN                       aEmirForms Forms ON Personel.Form = Forms.Form  " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        If islem = 1 Then
            If kayitsayisi = 0 Then
                kayitsayisi = 1
            ElseIf kayitsayisi = 1 Then
                kayitsayisi = 0
            End If
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Label2.Text = "Mağaza Satışları Kontrol Ediliyor, Lütfen Bekleyiniz..."
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        GridControl1.Refresh()
        dataload_satis_magazalar(tarih1, tarih2)
        GridControl1.DataSource = ds1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub dataload_mevcut_mal(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS IND, 'Envanter' AS Baslik, 'Mevcut Mal Tutarı' AS Aciklama, COUNT(DISTINCT nStokID) AS Sayi, SUM(Mevcut) AS Miktar, SUM(Mevcut * Maliyet) AS Tutar FROM (SELECT Stok.nStokID , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') AS Mevcut , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk WHERE (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') > 0) t"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_acikhesap(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '1' AS IND, 'Borçlar' AS Baslik, 'Açık Hesap Borç Bakiyesi' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '320%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_odenecek_cekler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '2' AS IND, 'Borçlar' AS Baslik, 'Ödenecek Çekler' AS Aciklama, COUNT(DISTINCT tbCekSenet.lCekSenetNo) AS Sayi, -SUM(tbCekSenet.lTutar) AS Tutar FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu WHERE (tbFirma.sKodu BETWEEN '' AND 'zzzzzzzzzzzzzzz') AND (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenetBordro.nCekSenetIslem = 20) AND (tbCekSenetBordro.dteBordroTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih2 & "' AND '31/12/2078') AND (tbCekSenetBordro.lBordroNo BETWEEN 0 AND 999999999) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_odenecek_senetler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '2' AS IND, 'Borçlar' AS Baslik, 'Ödenecek Senetler' AS Aciklama, COUNT(DISTINCT tbCekSenet.lCekSenetNo) AS Sayi, -SUM(tbCekSenet.lTutar) AS Tutar FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu WHERE (tbFirma.sKodu BETWEEN '' AND 'zzzzzzzzzzzzzzz') AND (tbCekSenet.sCekSenetTipi = 'BS') AND (tbCekSenetBordro.nCekSenetIslem = 20) AND (tbCekSenetBordro.dteBordroTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih2 & "' AND '31/12/2078') AND (tbCekSenetBordro.lBordroNo BETWEEN 0 AND 999999999) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_kredikarti(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '4' AS IND, 'Borçlar' AS Baslik, 'Kredi Kartı Ödemeleri' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '900.02.00001%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alacak_musteriler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '5' AS IND, 'Alacaklar' AS Baslik, 'Müşterilerden Alacaklar' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID ,  isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme WHERE dteOdemeTarihi <= '" & tarih2 & "' GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbAlisVeris.dteFaturaTarihi <= '" & tarih2 & "' GROUP BY tbMusteri.nMusteriID ) tbptemp WHERE (Tutar > 0 ) GROUP BY nMusteriID ) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            dr("Not") = tarih2 & " İtibariyle Alacaklar"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alacak_musteriler_Tumu(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     '5' AS IND, 'Müşteri' AS Baslik, 'Aktif Bakiyeli Müşteriler' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS Tutar FROM         vwMusteriKalan "))
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '5' AS IND, 'Alacaklar' AS Baslik, 'Müşterilerden Alacaklar' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID ,  isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme  GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID  GROUP BY tbMusteri.nMusteriID ) tbptemp WHERE (Tutar > 0 ) GROUP BY nMusteriID ) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            dr("Not") = Today & " İtibariyle Müşteri Bakiye Toplamları"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_mevcut_kasa(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '6' AS IND, 'Kasa' AS Baslik, 'Nakit Kasa Mevcudu' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '770.01.00001%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_mevcut_banka(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '7' AS IND, 'Banka' AS Baslik, 'Banka Nakit Mevcudu' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '10201001%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alinan_ugurlu(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '8' AS IND, 'Alınan' AS Baslik, 'Uğurlu Otel Alınan' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '900.01.00002%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_verilen_velic(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '9' AS IND, 'Verilen' AS Baslik, 'Büyük Velic Verilen' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, - SUM(tbFirmaHareketi.lBorcTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '900.01.00001%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_masraf_dagilim(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '10' AS IND, LOWER(tbFSinif1.sAciklama) + ' Masraf' AS Baslik, LOWER(tbFSinif2.sAciklama) AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, - SUM(tbFirmaHareketi.lBorcTutar) AS Tutar,tbFirmaHareketi.sHareketTipi FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE (tbFirma.sKodu LIKE '800%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirmaHareketi.sHareketTipi,tbFSinif1.sAciklama, tbFSinif2.sAciklama ORDER BY tbFirmaHareketi.sHareketTipi,tbFSinif1.sAciklama, tbFSinif2.sAciklama "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim masraf As Decimal = 0
        Dim masrafsayi As Decimal = 0
        For Each dr1 In ds1.Tables(0).Rows
            masraf += dr1("Tutar")
            masrafsayi += dr1("Sayi")
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Baslik") = "Masraflar"
        dr("Aciklama") = "Toplam Masraf"
        dr("Sayi") = masrafsayi
        dr("Tutar") = masraf
        Try
            dr("Yuzde") = masraf / tutar
        Catch ex As Exception
            dr("Yuzde") = 0
        End Try
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = dr1("sHareketTipi") & "-" & dr1("Baslik")
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Sayi") = dr1("Sayi")
            dr("Kar") = dr1("Tutar")
            Try
                dr("Yuzde") = dr1("Tutar") / masraf
            Catch ex As Exception
                dr("Yuzde") = 0
            End Try
            dr("Status") = 1
            DataSet1.Tables(0).Rows.Add(dr)
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Baslik") = "Kar"
        dr("Aciklama") = "Satış Karı"
        'dr("Sayi") = dr1("Sayi")
        dr("Tutar") = (kar) - (Math.Abs(masraf))
        satiskari = dr("Tutar")
        Try
            dr("Yuzde") = dr("Tutar") / maliyet
        Catch ex As Exception
            dr("Yuzde") = 0
        End Try
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_musteri_alisverisyapan(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '11' AS IND, 'Müşteri' AS Baslik, 'AlışVeriş Yapan Müşteri' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(lNetTutar) AS Tutar FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_yeni(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '11' AS IND, 'Müşteri' AS Baslik, 'AlışVeriş Yapan Yeni Müşteri' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(lNetTutar) AS Tutar FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (nMusteriID IN (SELECT nMusteriID FROM tbMusteri WHERE dteKayitTarihi BETWEEN '" & tarih1 & "' + ' 00:00:00' AND '" & tarih2 & "' + ' 23:59:59')) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_hesapkapanan(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '12' AS IND,'Müşteri' as Baslik,'Hesabı Kapanan Müşteri' AS Aciklama,count(DISTINCT nMusteriID) AS Sayi,sum(Tutar) as Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme where dteOdemeTarihi <= '" & tarih2 & "' GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar = 0) AND nMusteriID IN (SELECT DISTINCT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) GROUP BY nMusteriID , kodu) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_bakiyesiz(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '13' AS IND,'Müşteri' as Baslik,'Hareket Görmüş Bakiyesiz Müşteri' AS Aciklama,count(DISTINCT nMusteriID) AS Sayi,sum(Tutar) as Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar = 0) AND nMusteriID IN (SELECT DISTINCT nMusteriID FROM         tbAlisVeris) GROUP BY nMusteriID , kodu) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_kayitli(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '14' AS IND,'Müşteri' as Baslik,'Kayıtlı Müşteri' AS Aciklama,count(DISTINCT nMusteriID) AS Sayi,0 as Tutar FROM tbMusteri WHERE dteKayitTarihi < = '" & tarih2 & "' "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            dr("Not") = tarih2 & " İtibariyle Kayıtlı Müşteri Sayısı"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_cek_odenmis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '16' AS IND, 'Ödemeler' AS Baslik, 'Ödenen Çekler' AS Aciklama, COUNT(tbFirmaHareketi.sEvrakNo) AS Sayi, SUM(tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbFirmaHareketi.sHangiUygulama = 'BC') AND (tbFirmaHareketi.lAlacakTutar > 0) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_cek_odenecek(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Dim gun
        Dim ay
        Dim yil
        yil = tarih1.ToString.Substring(8, 2)
        gun = tarih1.ToString.Substring(0, 2)
        ay = tarih2.ToString.Substring(3, 2)
        tarih1 = CDate("01." + CStr((ay + 1)) + "." + yil)
        Try
            tarih2 = CDate("31." + CStr((ay + 1)) + "." + yil)
        Catch ex As Exception
            If ay <> 2 Then
                tarih2 = CDate("30." + CStr((ay + 1)) + "." + yil)
            Else
                tarih2 = CDate("28." + CStr((ay + 1)) + "." + yil)
            End If
        End Try
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '2' AS IND, 'Borçlar' AS Baslik, 'Sonraki Ay Ödenecek Çekler' AS Aciklama, COUNT(DISTINCT tbCekSenet.lCekSenetNo) AS Sayi, -SUM(tbCekSenet.lTutar) AS Tutar FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu WHERE (tbFirma.sKodu BETWEEN '' AND 'zzzzzzzzzzzzzzz') AND (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenetBordro.nCekSenetIslem = 20) AND (tbCekSenetBordro.dteBordroTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenetBordro.lBordroNo BETWEEN 0 AND 999999999) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_satis_magazalar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT DISTINCT tbFirma.sKodu, SUBSTRING(tbFirma.sKodu, 1, 1) AS sHesap1, SUBSTRING(tbFirma.sKodu, 1, 2) AS sHesap2, SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap3, tbFirma.sAciklama, tbFirma.sOzelNot,tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1, tbtempGrup2.sAciklamaGrup2, SUM(tbFirmaHareketi.lBorcTutar) AS lBorc, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacak, lBorcBakiye = CASE WHEN Bakiye.lbakiyeTutar > 0 THEN abs(Bakiye.lBakiyeTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN Bakiye.lbakiyeTutar < 0 THEN abs(Bakiye.lBakiyeTutar) ELSE 0 END, 0 AS lOncekiBorc, 0 AS lOncekiAlacak, 0 AS lOncekiBorcBakiye, 0 AS lOncekiAlacakBakiye, SUBSTRING(tbFirma.sKodu, 1, 5) AS sBilancoGrup2, tbtempBilancoGrup2.sAciklamaBilancoGrup2 AS sAciklamaBilancoGrup2 FROM (SELECT sKodu AS sKodu, sAciklama AS sAciklamaBilancoGrup2 FROM tbFirma) tbtempBilancoGrup2 RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi INNER JOIN (SELECT tbFirma.nFirmaID, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar FROM tbFirmaHareketi, tbFirma WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbFirma.nFirmaID) Bakiye ON Bakiye.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID LEFT OUTER JOIN (SELECT sKodu AS sKodu, sAciklama AS sAciklamakebir FROM tbFirma) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbFirma.sKodu, 1, 1) LEFT OUTER JOIN (SELECT sKodu AS sKodu, sAciklama AS sAciklamaGrup1 FROM tbFirma) tbtempGrup1 ON tbtempGrup1.sKodu = SUBSTRING(tbFirma.sKodu, 1, 2) AND LEN(tbFirma.sKodu) >= 2 LEFT OUTER JOIN (SELECT sKodu AS sKodu, sAciklama AS sAciklamaGrup2 FROM tbFirma) tbtempGrup2 ON tbtempGrup2.sKodu = SUBSTRING(tbFirma.sKodu, 1, 3) AND LEN(tbFirma.sKodu) >= 3 ON tbtempBilancoGrup2.sKodu = SUBSTRING(tbFirma.sKodu, 1, 5) AND LEN(tbFirma.sKodu) >= 5 WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND SUBSTRING(tbFirma.sKodu, 1, 1) <='9') GROUP BY Bakiye.lbakiyeTutar, SUBSTRING(tbFirma.sKodu, 1, 1), SUBSTRING(tbFirma.sKodu, 1, 2), SUBSTRING(tbFirma.sKodu, 1, 3), tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sOzelNot,tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1, tbtempGrup2.sAciklamaGrup2, SUBSTRING(tbFirma.sKodu, 1, 5), tbtempBilancoGrup2.sAciklamaBilancoGrup2 HAVING (ABS(SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) ORDER BY SUBSTRING(tbFirma.sKodu, 1, 1), SUBSTRING(tbFirma.sKodu, 1, 2), SUBSTRING(tbFirma.sKodu, 1, 3), SUBSTRING(tbFirma.sKodu, 1, 5), tbFirma.sKodu, tbFirma.sAciklama, tbtempGrup1.sAciklamaGrup1, tbtempGrup2.sAciklamaGrup2"))
    End Sub
    Private Sub dataload_valor(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  '' AS PERIYOD, cast(0 AS Money) AS Dagilim,cast(0 AS Money) AS Komisyon,cast(0 AS Money) AS VadeFarki,cast(0 AS Money) AS Net, cast(sOdemeKodu AS int) sOdemeKodu, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,(SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif1.sSinifKodu , tbSSinif1.sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet,tbStokFisiDetayi.sOdemeKodu FROM tbAlisVeris LEFT OUTER JOIN tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif1.sSinifKodu , tbSSinif1.sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet,tbAlisverisSiparis.sOdemeKodu FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar  GROUP BY sOdemeKodu ORDER BY  sOdemeKodu"))
        Dim tutar As Decimal = 0
        Dim dr As DataRow
        For Each dr In ds1.Tables(0).Rows
            tutar += sorgu_sayi(dr("Tutar"), 0)
        Next
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr1("Dagilim") = dr1("Tutar") / tutar
            If dr1("sOdemeKodu") = 0 Then
                dr1("Komisyon") = 0
                dr1("VadeFarki") = 0
                dr1("Net") = dr1("Kar")
            ElseIf dr1("sOdemeKodu") = 1 Then
                dr1("Komisyon") = sorgu_komisyon("GBV")
                dr1("VadeFarki") = dr1("Tutar") * (dr1("Komisyon") / 100)
                dr1("Net") = (dr1("Tutar") - dr1("VadeFarki")) - dr1("Maliyet")
            Else
                dr1("Komisyon") = sorgu_komisyon(("GB" & CType(dr1("sOdemeKodu"), Integer) & ""))
                dr1("VadeFarki") = dr1("Tutar") * (dr1("Komisyon") / 100)
                dr1("Net") = (dr1("Tutar") - dr1("VadeFarki")) - dr1("Maliyet")
            End If
        Next
        tutar = 0
        kar = 0
        miktar = 0
        sayi = 0
        For Each dr1 In ds1.Tables(0).Rows
            tutar += dr1("VadeFarki")
            'maliyet += dr1("Maliyet")
            'kar += dr1("Kar")
            miktar += dr1("Miktar")
            sayi += dr1("MUSTERISAYISI")
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Baslik") = "Valor Kayıpları"
        dr("Aciklama") = "Kesintiler"
        dr("Miktar") = miktar
        dr("Sayi") = sayi
        dr("Tutar") = -tutar
        dr("Yuzde") = 1
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        For Each dr1 In ds1.Tables(0).Rows
            'Kesintiler
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = dr1("sOdemeKodu").ToString + " Aylık Vadeli Satış Valor Kaybı Kesintisi"
            dr("Aciklama") = FormatNumber(dr1("Tutar"), 2).ToString & " Ciro Üzerinden % " & FormatNumber(dr1("Komisyon"), 2).ToString & " Hesaplanan "
            dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("MUSTERISAYISI")
            dr("Kar") = -dr1("VadeFarki")
            Try
                dr("Yuzde") = dr1("VadeFarki") / tutar
            Catch ex As Exception
                dr("Yuzde") = 0
            End Try
            dr("Status") = 1
            DataSet1.Tables(0).Rows.Add(dr)
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Baslik") = "NetSatışKar"
        dr("Aciklama") = "Net Satış Karı"
        'dr("Sayi") = dr1("Sayi")
        dr("Tutar") = satiskari - tutar
        Try
            dr("Yuzde") = dr("Tutar") / maliyet
        Catch ex As Exception
            dr("Yuzde") = 0
        End Try
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Public Function sorgu_komisyon(ByVal sOdemeSekli As String) As Decimal
        Dim kriter
        kriter = " WHERE     (sOdemeSekli = '" & Trim(sOdemeSekli) & " ') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      nKomisyonOrani FROM         tbBankaOdemeSekli " & kriter & " ORDER BY sOdemeSekli")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_satis_bekleyen(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '18' AS IND, 'Bekleyen' AS Baslik, 'Bekleyen Ön Ödemeli Satışlar' AS Aciklama, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS Sayi, SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, -SUM((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbDepo ON tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbMusteri.lKodu BETWEEN 0 AND 999999999) AND (tbAlisVeris.dteFaturaTarihi <= '" & tarih2 & "') AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Tutar") = dr1("Tutar")
            'dr("Kar") = dr1("Kar")
            'dr1("Yuzde") = dr1("Yuzde")
            dr("Not") = tarih2 & " İtibariyle Bekleyen Ön Ödemeli Satışlar"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
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
            SaveFileDialog1.FileName = "Rapor.txt"
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
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
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
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
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
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridView1.ColumnsCustomization()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            'degistir_grafik()
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasındaki İşletme Mizanı " & vbCrLf
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment-Satış Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
            ps.PreviewRibbonFormEx.Show()
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
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        DataSet1.Clear()
        DataSet1.Tables(0).Columns(0).AutoIncrementSeed = 0
        DataSet1.Tables(0).Columns(0).AutoIncrementStep = 1
        dataload(DateEdit1.EditValue, DateEdit2.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesap1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesap2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesap3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklamaKebir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklamaGrup1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklamaGrup2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorcBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOncekiBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOncekiAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOncekiBorcBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOncekiAlacakBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBilancoGrup2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklamaBilancoGrup2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOzelNot As DevExpress.XtraGrid.Columns.GridColumn
End Class
