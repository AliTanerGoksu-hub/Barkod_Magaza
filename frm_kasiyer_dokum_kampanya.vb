Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_kasiyer_dokum_kampanya
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents txt_baslama As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_bitis As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_fiyat5 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_aciklama5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_aciklama4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_fiyat2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_aciklama2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_fiyat3 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_aciklama3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_fiyat1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents sec_bOtomatikHediye As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_aciklama1 As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_kasiyer_dokum_kampanya))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_bOtomatikHediye = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_baslama = New DevExpress.XtraEditors.DateEdit()
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
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_bitis = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_fiyat5 = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_aciklama5 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_aciklama4 = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_fiyat2 = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_aciklama2 = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_fiyat3 = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_aciklama3 = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_fiyat1 = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_aciklama1 = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_bOtomatikHediye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.txt_baslama.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_baslama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bitis.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bitis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txt_fiyat5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txt_fiyat2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_fiyat3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_fiyat1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(552, 48)
        Me.PanelControl1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dökümlerde Çýkan Kampanya Bilgileri Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.sec_bOtomatikHediye)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 358)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(552, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'sec_bOtomatikHediye
        '
        Me.sec_bOtomatikHediye.Location = New System.Drawing.Point(6, 11)
        Me.sec_bOtomatikHediye.Name = "sec_bOtomatikHediye"
        Me.sec_bOtomatikHediye.Properties.Caption = "Otomatik Hediye Çýk"
        Me.sec_bOtomatikHediye.Size = New System.Drawing.Size(135, 19)
        Me.sec_bOtomatikHediye.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(467, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(392, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Controls.Add(Me.GroupControl4)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 48)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(552, 310)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.txt_baslama)
        Me.GroupControl5.Controls.Add(Me.LabelControl2)
        Me.GroupControl5.Controls.Add(Me.txt_bitis)
        Me.GroupControl5.Location = New System.Drawing.Point(8, 20)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(264, 48)
        Me.GroupControl5.TabIndex = 0
        Me.GroupControl5.Text = "Kampanya Geçerlilik Süresi"
        '
        'txt_baslama
        '
        Me.txt_baslama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BASLAMA", True))
        Me.txt_baslama.EditValue = Nothing
        Me.txt_baslama.EnterMoveNextControl = True
        Me.txt_baslama.Location = New System.Drawing.Point(8, 24)
        Me.txt_baslama.Name = "txt_baslama"
        Me.txt_baslama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_baslama.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_baslama.Size = New System.Drawing.Size(100, 20)
        Me.txt_baslama.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Açýklama 1"
        Me.DataColumn2.ColumnName = "ACIKLAMA1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FIYAT1"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "ACIKLAMA2"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "FIYAT2"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ACIKLAMA3"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "FIYAT3"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ACIKLAMA4"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "FIYAT4"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ACIKLAMA5"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "FIYAT5"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "BASLAMA"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "BITIS"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(121, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "ve"
        '
        'txt_bitis
        '
        Me.txt_bitis.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.BITIS", True))
        Me.txt_bitis.EditValue = Nothing
        Me.txt_bitis.EnterMoveNextControl = True
        Me.txt_bitis.Location = New System.Drawing.Point(158, 24)
        Me.txt_bitis.Name = "txt_bitis"
        Me.txt_bitis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_bitis.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_bitis.Size = New System.Drawing.Size(100, 20)
        Me.txt_bitis.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.txt_fiyat5)
        Me.GroupControl4.Controls.Add(Me.txt_aciklama5)
        Me.GroupControl4.Controls.Add(Me.txt_aciklama4)
        Me.GroupControl4.Location = New System.Drawing.Point(280, 136)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(264, 163)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "Fýrsat Kampanyasý"
        '
        'txt_fiyat5
        '
        Me.txt_fiyat5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FIYAT5", True))
        Me.txt_fiyat5.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_fiyat5.EnterMoveNextControl = True
        Me.txt_fiyat5.Location = New System.Drawing.Point(2, 121)
        Me.txt_fiyat5.Name = "txt_fiyat5"
        Me.txt_fiyat5.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_fiyat5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_fiyat5.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_fiyat5.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fiyat5.Properties.Appearance.Options.UseFont = True
        Me.txt_fiyat5.Properties.Appearance.Options.UseForeColor = True
        Me.txt_fiyat5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_fiyat5.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_fiyat5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat5.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_fiyat5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat5.Properties.NullText = "0.00"
        Me.txt_fiyat5.Size = New System.Drawing.Size(260, 32)
        Me.txt_fiyat5.TabIndex = 2
        '
        'txt_aciklama5
        '
        Me.txt_aciklama5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ACIKLAMA5", True))
        Me.txt_aciklama5.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_aciklama5.Location = New System.Drawing.Point(2, 101)
        Me.txt_aciklama5.Name = "txt_aciklama5"
        Me.txt_aciklama5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_aciklama5.Properties.Appearance.Options.UseForeColor = True
        Me.txt_aciklama5.Size = New System.Drawing.Size(260, 20)
        Me.txt_aciklama5.TabIndex = 1
        '
        'txt_aciklama4
        '
        Me.txt_aciklama4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ACIKLAMA4", True))
        Me.txt_aciklama4.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_aciklama4.Location = New System.Drawing.Point(2, 15)
        Me.txt_aciklama4.Name = "txt_aciklama4"
        Me.txt_aciklama4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_aciklama4.Properties.Appearance.Options.UseForeColor = True
        Me.txt_aciklama4.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama4.Size = New System.Drawing.Size(260, 86)
        Me.txt_aciklama4.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txt_fiyat2)
        Me.GroupControl3.Controls.Add(Me.txt_aciklama2)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 186)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(264, 113)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Kampanya2"
        '
        'txt_fiyat2
        '
        Me.txt_fiyat2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FIYAT2", True))
        Me.txt_fiyat2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_fiyat2.EnterMoveNextControl = True
        Me.txt_fiyat2.Location = New System.Drawing.Point(2, 71)
        Me.txt_fiyat2.Name = "txt_fiyat2"
        Me.txt_fiyat2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_fiyat2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_fiyat2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_fiyat2.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fiyat2.Properties.Appearance.Options.UseFont = True
        Me.txt_fiyat2.Properties.Appearance.Options.UseForeColor = True
        Me.txt_fiyat2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_fiyat2.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_fiyat2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat2.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_fiyat2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat2.Properties.NullText = "0.00"
        Me.txt_fiyat2.Size = New System.Drawing.Size(260, 32)
        Me.txt_fiyat2.TabIndex = 1
        '
        'txt_aciklama2
        '
        Me.txt_aciklama2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ACIKLAMA2", True))
        Me.txt_aciklama2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_aciklama2.Location = New System.Drawing.Point(2, 15)
        Me.txt_aciklama2.Name = "txt_aciklama2"
        Me.txt_aciklama2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_aciklama2.Properties.Appearance.Options.UseForeColor = True
        Me.txt_aciklama2.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama2.Size = New System.Drawing.Size(260, 56)
        Me.txt_aciklama2.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_fiyat3)
        Me.GroupControl2.Controls.Add(Me.txt_aciklama3)
        Me.GroupControl2.Location = New System.Drawing.Point(280, 20)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(264, 112)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Kampanya3"
        '
        'txt_fiyat3
        '
        Me.txt_fiyat3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FIYAT3", True))
        Me.txt_fiyat3.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_fiyat3.EnterMoveNextControl = True
        Me.txt_fiyat3.Location = New System.Drawing.Point(2, 71)
        Me.txt_fiyat3.Name = "txt_fiyat3"
        Me.txt_fiyat3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_fiyat3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_fiyat3.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_fiyat3.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fiyat3.Properties.Appearance.Options.UseFont = True
        Me.txt_fiyat3.Properties.Appearance.Options.UseForeColor = True
        Me.txt_fiyat3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_fiyat3.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_fiyat3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat3.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_fiyat3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat3.Properties.NullText = "0.00"
        Me.txt_fiyat3.Size = New System.Drawing.Size(260, 32)
        Me.txt_fiyat3.TabIndex = 1
        '
        'txt_aciklama3
        '
        Me.txt_aciklama3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ACIKLAMA3", True))
        Me.txt_aciklama3.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_aciklama3.Location = New System.Drawing.Point(2, 15)
        Me.txt_aciklama3.Name = "txt_aciklama3"
        Me.txt_aciklama3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_aciklama3.Properties.Appearance.Options.UseForeColor = True
        Me.txt_aciklama3.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama3.Size = New System.Drawing.Size(260, 56)
        Me.txt_aciklama3.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_fiyat1)
        Me.GroupControl1.Controls.Add(Me.txt_aciklama1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 72)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(264, 113)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Kampanya1"
        '
        'txt_fiyat1
        '
        Me.txt_fiyat1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.FIYAT1", True))
        Me.txt_fiyat1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_fiyat1.EnterMoveNextControl = True
        Me.txt_fiyat1.Location = New System.Drawing.Point(2, 71)
        Me.txt_fiyat1.Name = "txt_fiyat1"
        Me.txt_fiyat1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_fiyat1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_fiyat1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_fiyat1.Properties.Appearance.Options.UseBackColor = True
        Me.txt_fiyat1.Properties.Appearance.Options.UseFont = True
        Me.txt_fiyat1.Properties.Appearance.Options.UseForeColor = True
        Me.txt_fiyat1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_fiyat1.Properties.DisplayFormat.FormatString = "#,0.00"
        Me.txt_fiyat1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat1.Properties.EditFormat.FormatString = "#,0.00"
        Me.txt_fiyat1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_fiyat1.Properties.NullText = "0.00"
        Me.txt_fiyat1.Size = New System.Drawing.Size(260, 32)
        Me.txt_fiyat1.TabIndex = 3
        '
        'txt_aciklama1
        '
        Me.txt_aciklama1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ACIKLAMA1", True))
        Me.txt_aciklama1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_aciklama1.Location = New System.Drawing.Point(2, 15)
        Me.txt_aciklama1.Name = "txt_aciklama1"
        Me.txt_aciklama1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_aciklama1.Properties.Appearance.Options.UseForeColor = True
        Me.txt_aciklama1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama1.Size = New System.Drawing.Size(260, 56)
        Me.txt_aciklama1.TabIndex = 2
        '
        'frm_kasiyer_dokum_kampanya
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(552, 406)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_kasiyer_dokum_kampanya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kamyanyalar"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.sec_bOtomatikHediye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.txt_baslama.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_baslama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bitis.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bitis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.txt_fiyat5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txt_fiyat2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_fiyat3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txt_fiyat1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kullanici
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_kasiyer_dokum_kampanya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = connection
        dataload()
        Try
            sec_bOtomatikHediye.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("bOtomatikHediye").ToString
        Catch ex As Exception
            sec_bOtomatikHediye.Checked = False
        End Try
    End Sub
    Private Sub dataload()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ATBLDOKUMKAMPANYA WHERE IND =1 "
        cmd.Connection = con
        con.Open()
        adapter.Fill(DataSet1.Tables(0))
        con.Close()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
    End Sub
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
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet()
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("bOtomatikHediye", sec_bOtomatikHediye.Checked)
    End Sub
    Private Sub kaydet()
        Try
            con.ConnectionString = connection
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = "SET DATEFORMAT DMY UPDATE ATBLDOKUMKAMPANYA SET ACIKLAMA1 ='" & txt_aciklama1.EditValue & "',ACIKLAMA2 ='" & txt_aciklama2.EditValue & "',ACIKLAMA3 ='" & txt_aciklama3.EditValue & "',ACIKLAMA4 ='" & txt_aciklama4.EditValue & "',ACIKLAMA5 ='" & txt_aciklama5.EditValue & "',FIYAT1 =" & txt_fiyat1.EditValue & ",FIYAT2 =" & txt_fiyat2.EditValue & ",FIYAT3 =" & txt_fiyat3.EditValue & ",FIYAT5 =" & txt_fiyat5.EditValue & ",BASLAMA ='" & txt_baslama.EditValue & "',BITIS ='" & txt_bitis.EditValue & "' WHERE IND =1"
            cmd.ExecuteNonQuery()
            con.Close()
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Hata Oluþtu , Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Me.Close()
    End Sub
End Class
