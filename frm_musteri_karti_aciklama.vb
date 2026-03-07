Imports DevExpress.XtraEditors
Public Class frm_musteri_karti_aciklama
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
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_aciklama1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_aciklama2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents txt_aciklama5 As DevExpress.XtraEditors.MemoEdit

    Friend WithEvents txt_aciklama4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LabelControl5 As LabelControl
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents LabelControl6 As LabelControl
    Friend WithEvents LabelControl7 As LabelControl
    Friend WithEvents LabelControl8 As LabelControl
    Friend WithEvents LabelControl9 As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents txt_aciklama9 As MemoEdit
    Friend WithEvents LabelControl10 As LabelControl
    Friend WithEvents txt_aciklama10 As MemoEdit
    Friend WithEvents txt_aciklama8 As MemoEdit
    Friend WithEvents txt_aciklama7 As MemoEdit
    Friend WithEvents txt_aciklama6 As MemoEdit
    Friend WithEvents txt_aciklama3 As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_karti_aciklama))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_aciklama10 = New DevExpress.XtraEditors.MemoEdit()
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
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama9 = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_aciklama8 = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_aciklama7 = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_aciklama6 = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama5 = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_aciklama4 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama3 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama2 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama1 = New DevExpress.XtraEditors.MemoEdit()
        Me.Label16 = New DevExpress.XtraEditors.LabelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.txt_aciklama10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(594, 80)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(145, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Takip Notlarý Aþaðýdadýr."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 706)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(594, 68)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(443, 17)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(128, 34)
        Me.SimpleButton2.TabIndex = 11
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(315, 17)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(128, 34)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txt_aciklama10)
        Me.PanelControl3.Controls.Add(Me.LabelControl10)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama9)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama8)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama7)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama6)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.LabelControl8)
        Me.PanelControl3.Controls.Add(Me.LabelControl7)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Controls.Add(Me.LabelControl4)
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama5)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama4)
        Me.PanelControl3.Controls.Add(Me.Label4)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama3)
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama2)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.txt_aciklama1)
        Me.PanelControl3.Controls.Add(Me.Label16)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(594, 626)
        Me.PanelControl3.TabIndex = 0
        '
        'txt_aciklama10
        '
        Me.txt_aciklama10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama10", True))
        Me.txt_aciklama10.EnterMoveNextControl = True
        Me.txt_aciklama10.Location = New System.Drawing.Point(139, 543)
        Me.txt_aciklama10.Name = "txt_aciklama10"
        Me.txt_aciklama10.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama10.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama10.Properties.MaxLength = 200
        Me.txt_aciklama10.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama10.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama10.TabIndex = 55
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sAciklama1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama2"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sAciklama3"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAciklama4"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sAciklama5"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sAciklama6"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sAciklama7"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAciklama8"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sAciklama9"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sAciklama10"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(13, 547)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(54, 19)
        Me.LabelControl10.TabIndex = 54
        Me.LabelControl10.Text = "Not10 :"
        '
        'txt_aciklama9
        '
        Me.txt_aciklama9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama9", True))
        Me.txt_aciklama9.EnterMoveNextControl = True
        Me.txt_aciklama9.Location = New System.Drawing.Point(139, 483)
        Me.txt_aciklama9.Name = "txt_aciklama9"
        Me.txt_aciklama9.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama9.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama9.Properties.MaxLength = 200
        Me.txt_aciklama9.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama9.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama9.TabIndex = 53
        '
        'txt_aciklama8
        '
        Me.txt_aciklama8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama8", True))
        Me.txt_aciklama8.EnterMoveNextControl = True
        Me.txt_aciklama8.Location = New System.Drawing.Point(139, 424)
        Me.txt_aciklama8.Name = "txt_aciklama8"
        Me.txt_aciklama8.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama8.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama8.Properties.MaxLength = 200
        Me.txt_aciklama8.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama8.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama8.TabIndex = 52
        '
        'txt_aciklama7
        '
        Me.txt_aciklama7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama7", True))
        Me.txt_aciklama7.EnterMoveNextControl = True
        Me.txt_aciklama7.Location = New System.Drawing.Point(141, 367)
        Me.txt_aciklama7.Name = "txt_aciklama7"
        Me.txt_aciklama7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama7.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama7.Properties.MaxLength = 200
        Me.txt_aciklama7.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama7.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama7.TabIndex = 51
        '
        'txt_aciklama6
        '
        Me.txt_aciklama6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama6", True))
        Me.txt_aciklama6.EnterMoveNextControl = True
        Me.txt_aciklama6.Location = New System.Drawing.Point(141, 310)
        Me.txt_aciklama6.Name = "txt_aciklama6"
        Me.txt_aciklama6.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama6.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama6.Properties.MaxLength = 200
        Me.txt_aciklama6.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama6.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama6.TabIndex = 50
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(13, 491)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl9.TabIndex = 47
        Me.LabelControl9.Text = "Not9 :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(13, 491)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl8.TabIndex = 47
        Me.LabelControl8.Text = "Not8 :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 491)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl7.TabIndex = 47
        Me.LabelControl7.Text = "Not7 :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 491)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl6.TabIndex = 47
        Me.LabelControl6.Text = "Not6 :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 256)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl5.TabIndex = 49
        Me.LabelControl5.Text = "Not5 :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 491)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl4.TabIndex = 47
        Me.LabelControl4.Text = "Not9 :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 433)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "Not8 :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 376)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Not7 :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 314)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Not6 :"
        '
        'txt_aciklama5
        '
        Me.txt_aciklama5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama5", True))
        Me.txt_aciklama5.EnterMoveNextControl = True
        Me.txt_aciklama5.Location = New System.Drawing.Point(141, 251)
        Me.txt_aciklama5.Name = "txt_aciklama5"
        Me.txt_aciklama5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama5.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama5.Properties.MaxLength = 200
        Me.txt_aciklama5.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama5.Size = New System.Drawing.Size(435, 58)
        Me.txt_aciklama5.TabIndex = 39
        '
        'txt_aciklama4
        '
        Me.txt_aciklama4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama4", True))
        Me.txt_aciklama4.EnterMoveNextControl = True
        Me.txt_aciklama4.Location = New System.Drawing.Point(141, 194)
        Me.txt_aciklama4.Name = "txt_aciklama4"
        Me.txt_aciklama4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama4.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama4.Properties.MaxLength = 200
        Me.txt_aciklama4.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama4.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama4.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Not4 :"
        '
        'txt_aciklama3
        '
        Me.txt_aciklama3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama3", True))
        Me.txt_aciklama3.EnterMoveNextControl = True
        Me.txt_aciklama3.Location = New System.Drawing.Point(141, 137)
        Me.txt_aciklama3.Name = "txt_aciklama3"
        Me.txt_aciklama3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama3.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama3.Properties.MaxLength = 200
        Me.txt_aciklama3.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama3.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama3.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Not3 :"
        '
        'txt_aciklama2
        '
        Me.txt_aciklama2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama2", True))
        Me.txt_aciklama2.EnterMoveNextControl = True
        Me.txt_aciklama2.Location = New System.Drawing.Point(141, 80)
        Me.txt_aciklama2.Name = "txt_aciklama2"
        Me.txt_aciklama2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama2.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama2.Properties.MaxLength = 200
        Me.txt_aciklama2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama2.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Not2 :"
        '
        'txt_aciklama1
        '
        Me.txt_aciklama1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.sAciklama1", True))
        Me.txt_aciklama1.EnterMoveNextControl = True
        Me.txt_aciklama1.Location = New System.Drawing.Point(141, 23)
        Me.txt_aciklama1.Name = "txt_aciklama1"
        Me.txt_aciklama1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_aciklama1.Properties.Appearance.Options.UseFont = True
        Me.txt_aciklama1.Properties.MaxLength = 200
        Me.txt_aciklama1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama1.Size = New System.Drawing.Size(435, 57)
        Me.txt_aciklama1.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(13, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 19)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Not1 :"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Çýkýþ,Esc"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(594, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 774)
        Me.barDockControlBottom.Size = New System.Drawing.Size(594, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 774)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(594, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 774)
        '
        'frm_musteri_karti_aciklama
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(594, 804)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_musteri_karti_aciklama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Takip Notu"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txt_aciklama10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public kayitno
    Public connection
    Public kullanici
    Public kasiyer
    Public kasiyerno
    Dim ds_kasiyer As DataSet
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    Public firma As Boolean = False
    Public tbMuhasebeFisi As Boolean = False
    Public tbStokFisiAciklamasi As Boolean = False
    Public tbSiparis As Boolean = False
    Public tbFirmaHareketi As Boolean = False
    Public dteFisTarihi As DateTime
    Public sMuhFisTipi As Integer
    Public lFisNo As Int64
    Public nSiparisTipi As String
    Public lSiparisNo As String
    Public nFirmaID As String
    Public nStokFisiID As Int64 = 0
    Private Sub frm_musteri_karti_aciklama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
    End Sub
    Private Sub duzelt(ByVal nMusteriID As Int64, ByVal aciklama1 As String, ByVal aciklama2 As String, ByVal aciklama3 As String, ByVal aciklama4 As String, ByVal aciklama5 As String, ByVal aciklama6 As String, ByVal aciklama7 As String, ByVal aciklama8 As String, ByVal aciklama9 As String, ByVal aciklama10 As String)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If firma = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY UPDATE    tbFirmaAciklamasi SET              sAciklama1 ='" & aciklama1 & "', sAciklama2 ='" & aciklama2 & "', sAciklama3 ='" & aciklama3 & "', sAciklama4 ='" & aciklama4 & "', sAciklama5 ='" & aciklama5 & "' , sAciklama6 ='" & aciklama6 & "' , sAciklama7 ='" & aciklama7 & "', sAciklama8 ='" & aciklama8 & "', sAciklama9 ='" & aciklama9 & "', sAciklama10 ='" & aciklama10 & "' WHERE nFirmaID= '" & kayitno & "'")
        ElseIf tbMuhasebeFisi = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY UPDATE    tbMuhasebeFisiAciklamasi SET              sAciklama1 = '" & aciklama1 & "', sAciklama2 = '" & aciklama2 & "', sAciklama3 = '" & aciklama3 & "', sAciklama4 = '" & aciklama4 & "', sAciklama5 = '" & aciklama5 & "', sAciklama6 ='" & aciklama6 & "' , sAciklama7 ='" & aciklama7 & "', sAciklama8 ='" & aciklama8 & "', sAciklama9 ='" & aciklama9 & "', sAciklama10 ='" & aciklama10 & "'  WHERE     (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        ElseIf tbSiparis = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY UPDATE    tbSiparisAciklamasi SET              sAciklama1 = '" & aciklama1 & "', sAciklama2 = '" & aciklama2 & "', sAciklama3 = '" & aciklama3 & "', sAciklama4 = '" & aciklama4 & "', sAciklama5 = '" & aciklama5 & "' , sAciklama6 ='" & aciklama6 & "' , sAciklama7 ='" & aciklama7 & "', sAciklama8 ='" & aciklama8 & "', sAciklama9 ='" & aciklama9 & "', sAciklama10 ='" & aciklama10 & "'  WHERE     (nSiparisTipi = " & nSiparisTipi & ") AND (lSiparisNo = " & lSiparisNo & ") AND (nFirmaID = " & nFirmaID & ")")
        ElseIf tbStokFisiAciklamasi = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY UPDATE    tbStokFisiAciklamasi SET              sAciklama1 = '" & aciklama1 & "', sAciklama2 = '" & aciklama2 & "', sAciklama3 = '" & aciklama3 & "', sAciklama4 = '" & aciklama4 & "', sAciklama5 = '" & aciklama5 & "' , sAciklama6 ='" & aciklama6 & "' , sAciklama7 ='" & aciklama7 & "', sAciklama8 ='" & aciklama8 & "', sAciklama9 ='" & aciklama9 & "', sAciklama10 ='" & aciklama10 & "'  WHERE     (nStokFisiID = " & nStokFisiID & ") ")
        ElseIf tbFirmaHareketi = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY UPDATE    tbFirmaHareketi SET              sAciklama1 = '" & aciklama1 & "' WHERE     (nHareketID = " & nStokFisiID & ") ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY UPDATE    tbMusteri SET              sAciklama1 ='" & aciklama1 & "', sAciklama2 ='" & aciklama2 & "', sAciklama3 ='" & aciklama3 & "', sAciklama4 ='" & aciklama4 & "', sAciklama5 ='" & aciklama5 & "' , sAciklama6 ='" & aciklama6 & "' , sAciklama7 ='" & aciklama7 & "', sAciklama8 ='" & aciklama8 & "', sAciklama9 ='" & aciklama9 & "', sAciklama10 ='" & aciklama10 & "'  WHERE nMusteriID= '" & kayitno & "'")
        End If
        cmd.ExecuteNonQuery()
        conn.Close()
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub yetki_kontrol()
        Dim yetki As Int64 = Sorgu_Yetki(kullanici, Me.Name)
        If yetki = 0 Then
            Me.Hide()
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!" & vbCrLf & "Lütfen Sistem Yönecinizle Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            status = True
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
    Private Sub dataload()
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If firma = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nFirmaID,sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5 , sAciklama6, sAciklama7, sAciklama8, sAciklama9, sAciklama10 FROM         tbFirmaAciklamasi WHERE nFirmaID =" & kayitno & "")
        ElseIf tbStokFisiAciklamasi = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nStokFisiID,sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sAciklama6, sAciklama7, sAciklama8, sAciklama9, sAciklama10 FROM         tbStokFisiAciklamasi WHERE nStokFisiID =" & nStokFisiID & "")
        ElseIf tbMuhasebeFisi = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbMuhasebeFisiAciklamasi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        ElseIf tbSiparis = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbSiparisAciklamasi WHERE     (nSiparisTipi = " & nSiparisTipi & ") AND (lSiparisNo = " & lSiparisNo & ") AND (nFirmaID = " & nFirmaID & ")")
        ElseIf tbFirmaHareketi = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nHareketID AS nStokFisiID,sAciklama1, '' AS sAciklama2, '' AS sAciklama3, '' AS sAciklama4, '' AS sAciklama5, '' AS sAciklama6, '' AS sAciklama7, '' AS sAciklama8, '' AS sAciklama9, '' AS sAciklama10 FROM         tbFirmaHareketi WHERE nHareketID =" & nStokFisiID & "")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nMusteriID,sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sAciklama6, sAciklama7, sAciklama8, sAciklama9, sAciklama10 FROM         tbMusteri WHERE nMusteriID ='" & kayitno & "'")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            duzelt(kayitno, txt_aciklama1.Text, txt_aciklama2.Text, txt_aciklama3.Text, txt_aciklama4.Text, txt_aciklama5.Text, txt_aciklama6.Text, txt_aciklama7.Text, txt_aciklama8.Text, txt_aciklama9.Text, txt_aciklama10.Text)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Hata Oluþtu!!! Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End Try
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
End Class
