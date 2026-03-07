Imports Microsoft.Win32
Imports System.Windows.Forms
Imports FastReport
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_tablo_faaliyet
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
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tablo_faaliyet))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DataSet2 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn22 = New System.Data.DataColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Button2)
        Me.PanelControl1.Controls.Add(Me.RadioGroup1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(440, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(228, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(102, 5)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Perakende"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Fatura")})
        Me.RadioGroup1.Size = New System.Drawing.Size(100, 45)
        Me.RadioGroup1.TabIndex = 37
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(392, 2)
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 166)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(440, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(83, 8)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 9
        Me.SimpleButton4.Text = "&Tasarla"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 8)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "&Raporla"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(355, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(280, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Button1)
        Me.PanelControl3.Controls.Add(Me.ListBox1)
        Me.PanelControl3.Controls.Add(Me.Panelstatus)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.DateEdit1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(440, 110)
        Me.PanelControl3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(383, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Baþlat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(464, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(518, 160)
        Me.ListBox1.TabIndex = 14
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
        Me.Panelstatus.Location = New System.Drawing.Point(37, 1)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(367, 108)
        Me.Panelstatus.TabIndex = 13
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(8, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(343, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 50)
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
        Me.barlabel.Location = New System.Drawing.Point(8, 4)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 23)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(343, 18)
        Me.bar.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(6, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(8, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(109, 19)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Ýþlem Tarihi :"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(152, 40)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(272, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nAlisVerisID"
        '
        'frm_tablo_faaliyet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(440, 206)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tablo_faaliyet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faaliyet Raporu"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public otoIslemFaaliyet As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataset1 As DataSet
    Dim ds_alislar As DataSet
    Dim ds_satir_stok As DataSet
    Private Sub OtoFaaliyetThread()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim trd As Threading.Thread
        trd = New Threading.Thread(AddressOf OtoFaaliyetOlustur)
        trd.IsBackground = True
        trd.Start()
    End Sub
    Private Sub frm_tablo_faaliyet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        If otoIslemFaaliyet = True Then
            OtoFaaliyetThread()
        End If
    End Sub
    Private Sub FaaliyetDurumDegistir(ByVal eskiDurum As Integer, ByVal yeniDurum As Integer, ByVal IstekID As String, ByVal olusturmaTarihi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If Trim(olusturmaTarihi) = "" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Update FaaliyetMobile Set IstekDurum = " & yeniDurum & " WHERE (IstekDurum = " & eskiDurum & ") AND (id = '" & IstekID & "')")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Update FaaliyetMobile Set IstekDurum = " & yeniDurum & ", RaporOlusturmaTarihi = GetDate() WHERE (IstekDurum = " & eskiDurum & ") AND (id = '" & IstekID & "')")
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub OtoFaaliyetOlustur()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim IstekTarihi As String = ""
        Dim IstekTarihiDate As Date
        Dim IstekID As String = ""
        cmd.Connection = con
        con.ConnectionString = connection
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(IstekTarihi, '') FROM FaaliyetMobile WHERE (IstekDurum = 0) Order By IstekTarihi Desc")
            IstekTarihi = cmd.ExecuteScalar.ToString()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(id, 0) FROM FaaliyetMobile WHERE (IstekDurum = 0) Order By IstekTarihi Desc")
            IstekID = cmd.ExecuteScalar.ToString()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(IstekRapor, 0) FROM FaaliyetMobile WHERE (id = " & IstekID & ")")
            RadioGroup1.SelectedIndex = Integer.Parse(cmd.ExecuteScalar.ToString())
            con.Close()
        Catch ex As Exception
            RadioGroup1.SelectedIndex = 0
        End Try
        If Trim(IstekTarihi) <> "" Then
            IstekTarihiDate = Date.Parse(IstekTarihi)
            Dim YeniTarih As String = IstekTarihiDate.Day & "." & IstekTarihiDate.Month & "." & IstekTarihiDate.Year
            If Directory.Exists("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih) = True Then
                Try
                    If RadioGroup1.SelectedIndex = 0 Then
                        If Directory.Exists("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende") = True Then
                            Directory.Delete("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende", True)
                        End If
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende")
                    Else
                        If Directory.Exists("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura") = True Then
                            Directory.Delete("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura", True)
                        End If
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura")
                    End If
                Catch ex As Exception
                End Try
            Else
                Try
                    Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih)
                    If RadioGroup1.SelectedIndex = 0 Then
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende")
                    Else
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura")
                    End If
                Catch ex As Exception
                End Try
            End If
            Try
                FaaliyetDurumDegistir(0, 1, IstekID, "")
                dataload(YeniTarih, YeniTarih, "", "Kodu", "Baþlar", "", "Kodu", "Baþlar")
                dataload_satis(YeniTarih, YeniTarih, "", "Kodu", "Baþlar", "", "Kodu", "Baþlar", 6)
                raporla(4, YeniTarih, IstekID)
            Catch ex As Exception
            End Try
        Else
            If otoIslemFaaliyet = True Then
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit1.EditValue, "", "Kodu", "Baþlar", "", "Kodu", "Baþlar")
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton3.Enabled = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload_satis(DateEdit1.EditValue, DateEdit1.EditValue, "", "Kodu", "Baþlar", "", "Kodu", "Baþlar", 6)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton3.Enabled = True
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        raporla(0)
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        dataset1 = stok(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter)
        kontrol_oran()
        kontrol_hazirla()
    End Sub
    Private Sub dataload_satis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kontrol As Int64)
        dataset1 = stok_satis(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, kontrol, "()")
        PanelControl3.Select()
        kontrol_oran_satis()
        If kontrol = 6 Then
            Dim alisverisler As String = kontrol_fark(1)
            dataset1 = stok_satis(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, kontrol, alisverisler)
            PanelControl3.Select()
            kontrol_oran_satis()
            alisverisler = Nothing
        ElseIf kontrol = 7 Then
            Dim alisverisler As String = kontrol_fark(2)
            dataset1 = stok_satis(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, kontrol, alisverisler)
            PanelControl3.Select()
            kontrol_oran_satis()
            alisverisler = Nothing
        End If
        satis_kontrol_hazirla()
    End Sub
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String) As DataSet
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.nStokFisiID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lGirisMiktar2, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sDovizCinsi, tbStokFisiDetayi.lDovizFiyat, tbStokFisiDetayi.nSiparisID, tbStokFisiDetayi.sAciklama AS Expr1, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nIrsaliyeFisiID, tbStokFisiDetayi.sStokIslem, tbStokFisiDetayi.nOTVOrani, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIslemID, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT,CAST(0 AS MONEY) AS ISKONTO,CAST(0 AS MONEY) AS ISKONTOTUTAR, CAST(0 AS MONEY) AS GERCEKTOPLAM, CAST(0 AS MONEY) AS Fark,CAST(0 AS MONEY) AS FarkOran,CAST(0 AS MONEY) AS EKMASRAF, CAST(0 AS MONEY) AS ONCEKIMALIYET, 'Normal' AS Durum,tbFirma.sKodu AS FirmaKodu, tbFirma.sAciklama AS FirmaAdi, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lFisNo, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lMalBedeli, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lDipIskontoTutari3, tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lNetTutar FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiMaster.sFisTipi = 'FA ') AND (tbStokFisiMaster.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "')  " & kriter & " ORDER BY tbStokFisiDetayi.nIslemID")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function stok_satis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kontrol As Int64, ByVal alisverisler As String) As DataSet
        Dim kriter As String = ""
        If ara.ToString <> "" Then
            If konum = "Kodu" Then
                If firmatipi = False Then
                    kriter += " AND (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                End If
            ElseIf konum = "Adý" Then
                If firmatipi = False Then
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
                End If
            ElseIf konum = "Soyadý" Then
                kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Ýstihbarat" Then
                kriter += " AND ((tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "ÝþAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "EvTelefonu" Then
                kriter += " AND (tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "ÝþTelefonu" Then
                kriter += " AND (tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Gsm" Then
                kriter += " AND (tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "DoðumYeri" Then
                kriter += " AND (tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "1.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "2.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sýnýf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sýnýf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sýnýf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sýnýf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sýnýf5" Then
                kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Adý+Soyadý" Then
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
                    End If
                End If
                'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
                If adi.ToString <> "" Then
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & ")"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & ")"
                End If
            End If
        End If
        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND (tbStok.sKodu " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND (tbStok.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
                'ElseIf konum_stok = "Soyadý" Then
                '   kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sýnýf1" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sýnýf2" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sýnýf3" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sýnýf4" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sýnýf5" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Barkod" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            End If
        End If
        Dim kriter_hediyeli As String = ""
        If kontrol = 0 Then
            kriter_hediyeli = " WHERE abs(fiyat) <> gFiyat AND nAlisVerisID NOT IN (SELECT DISTINCT nAlisverisID FROM (SELECT tbAlisVeris.nAlisverisID, tbStokFisiDetayi.sFiyatTipi FROM tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.nAlisverisID, tbAlisverisSiparis.sFiyatTipi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Hediye WHERE (sFiyatTipi IN ('HD')))"
        ElseIf kontrol = 1 Then
            kriter_hediyeli = " WHERE nAlisVerisID IN (SELECT DISTINCT nAlisverisID FROM (SELECT tbAlisVeris.nAlisverisID, tbStokFisiDetayi.sFiyatTipi FROM tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.nAlisverisID, tbAlisverisSiparis.sFiyatTipi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Hediye WHERE (sFiyatTipi IN ('HD')))"
        ElseIf kontrol = 2 Then
            Dim odemekodu = InputBox("Peþin Fiyat Vade Kontrolü", "Peþin Vadesi", 0).ToString
            If odemekodu <> "" Then
                kriter_hediyeli = " WHERE sFiyatTipi = '" & sFiyat1 & "' and sOdemeKodu > " & odemekodu & " "
            End If
        ElseIf kontrol = 3 Then
            Dim odemekodu = InputBox("6 Aylýk Fiyat Vade Kontrolü", "6 Aylýk Fiyat Vadesi", 6).ToString
            If odemekodu <> "" Then
                kriter_hediyeli = " WHERE sFiyatTipi = '" & sFiyat2 & "' and sOdemeKodu > " & odemekodu & " "
            End If
        ElseIf kontrol = 4 Then
            Dim odemekodu = InputBox("10 Aylýk Fiyat Vade Kontrolü", "10 Aylýk Fiyat Vadesi", 10).ToString
            If odemekodu <> "" Then
                kriter_hediyeli = " WHERE sFiyatTipi = '" & sFiyat3 & "' and sOdemeKodu > " & odemekodu & " "
            End If
        ElseIf kontrol = 5 Then
        ElseIf kontrol = 6 Then
        ElseIf kontrol = 7 Then
        End If
        If alisverisler <> "()" Then
            'MsgBox(alisverisler)
            kriter_hediyeli = " Where nAlisVerisID IN " & alisverisler & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If RadioGroup1.SelectedIndex = 0 Then
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbStokFisiDetayi.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.dteFisTarihi, '01/01/1900') as dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbAlisVerisSiparis.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") t " & kriter_hediyeli & " ORDER BY nAlisVerisID, lNo")
        Else
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT ISNULL(tbStokFisiDetayi.nAlisverisID, '') as nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiDetayi.sFisTipi AS fisTipi, tbStokFisiDetayi.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo as sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbStokFisiDetayi.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.dteFisTarihi, '01/01/1900') as dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbStokFisiDetayi INNER JOIN tbDepo ON tbStokFisiDetayi.sDepo = tbDepo.sDepo ON tbMusteri.nMusteriID = tbStokFisiDetayi.nMusteriID LEFT OUTER JOIN tbAlisVeris ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'FS') AND tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT ISNULL(tbStokFisiDetayi.nAlisverisID, '') as nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiDetayi.sFisTipi AS fisTipi, tbStokFisiDetayi.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbStokFisiDetayi.sDepo as sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbAlisVerisSiparis.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbStokFisiDetayi ON tbAlisverisSiparis.nAlisverisID = tbStokFisiDetayi.nAlisverisID INNER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") t " & kriter_hediyeli & " ORDER BY lNo")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
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
    Private Sub kontrol_oran()
        Dim oranekmaliyet As Decimal = 0
        Dim dr As DataRow
        For Each dr In dataset1.Tables(0).Rows
            'dr("ISK1") = DR("Expr1")
            dr("GERCEKFIYAT") = dr("lGirisFiyat") * ((dr("nKdvOrani") + 100) / 100)
            'MsgBox(dr_toplam("lNetTutar"))
            Try
                dr("ISKONTO") = (dr("lMalIskontoTutari") + dr("lDipIskontoTutari3")) / dr("lMalBedeli")
                If CType(dr("lEkmaliyet1"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr("lEkmaliyet1"), Decimal) / CType(dr("lMalBedeli") - dr("lMalIskontoTutari"), Decimal)
                    dr("EKMASRAF") = oranekmaliyet
                    dr("GERCEKFIYAT") = dr("GERCEKFIYAT") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
            Catch ex As Exception
            End Try
            dr("GERCEKTOPLAM") = (dr("GERCEKFIYAT")) * (Math.Abs(dr("lGirisMiktar1")))
            oranekmaliyet = 0
            'dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGirisMiktar1")
            Dim dr1 As DataRow
            ds_alislar = sorgu_alislar(dr("dteFisTarihi"), dr("lFisNo"), dr("sKodu"))
            Dim sayi As Integer = 0
            For Each dr1 In ds_alislar.Tables(0).Rows
                sayi += 1
                If dr1("EKMALIYET") <> 0 Then
                    dr1("ORANEKMALIYET") = dr1("EKMALIYET") / dr1("FATURATUTARI")
                End If
                dr1("NETMALIYET") = dr1("KDVLITUTAR") * ((100 + (dr1("ORANEKMALIYET") * 100)) / 100)
                If sayi = 1 Then
                    dr("ONCEKIMALIYET") = FormatNumber(dr1("NETMALIYET"), 2)
                ElseIf sayi = 2 Then
                End If
                If dr("ONCEKIMALIYET") = 0 Then
                    dr("Durum") = "Yeni"
                End If
                dr("Fark") = FormatNumber((Math.Abs(dr("GERCEKFIYAT"))) - (Math.Abs(dr("ONCEKIMALIYET"))), 2)
                Try
                    dr("FarkOran") = dr("Fark") / dr("ONCEKIMALIYET")
                Catch ex As Exception
                    dr("FarkOran") = 0
                End Try
                If dr("Fark") > 0 Then
                    dr("Durum") = "Pahalý"
                ElseIf dr("Fark") < 0 Then
                    dr("Durum") = "Ucuz"
                ElseIf dr("Fark") = 0 Then
                    'dr("Durum") = "Normal"
                End If
            Next
        Next
        dr = Nothing
    End Sub
    Private Sub kontrol_oran_satis()
        Panelstatus.Visible = True
        bar.Properties.Maximum = dataset1.Tables(0).Rows.Count
        barlabel.Text = "Toplam Satýr Sayýsý : " & dataset1.Tables(0).Rows.Count
        bar.Position = 0
        Dim dr As DataRow
        Dim netmaliyet As Decimal = 0
        Dim normalfiyat As Decimal = 0
        Dim fiyattipi As String = ""
        For Each dr In dataset1.Tables(0).Rows
            barlabel.Text = "StokKodu:" & dr("sKodu").ToString & vbTab & "Adý:" & dr("sStokAciklama").ToString
            barlabel.Refresh()
            If dr("sKodu").ToString <> "" Then
                Try
                    netmaliyet = dr("MALIYET") * dr("Miktar")
                Catch ex As Exception
                    netmaliyet = 0
                End Try
                Try
                    dr("ORAN1") = ((dr("lNetTutar") - netmaliyet) / netmaliyet)
                    dr("KAR") = dr("lNetTutar") - netmaliyet
                Catch ex As Exception
                    dr("ORAN1") = 0
                    dr("KAR") = dr("lNetTutar") - netmaliyet
                End Try
                If dr("nGirisCikis") <> 5 Then
                    If Trim(dr("sFiyatTipi").ToString) <> "HD" Then
                        fiyattipi = Trim(dr("sFiyatTipi").ToString)
                        If fiyattipi = Trim(sFiyat3) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat2) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ALTIAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat1) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("PESIN"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        End If
                    Else
                        'fiyattipi = Trim(dr("sFiyatTipi").ToString)
                        If fiyattipi = Trim(sFiyat3) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = dr("Fiyat") - normalfiyat + +0.01
                        ElseIf fiyattipi = Trim(sFiyat2) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = dr("Fiyat") - normalfiyat + 0.01
                        ElseIf fiyattipi = Trim(sFiyat1) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = dr("Fiyat") - normalfiyat + 0.01
                        End If
                    End If
                End If
            End If
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Function kontrol_fark(Optional ByVal islem As Integer = 0)
        Panelstatus.Visible = True
        bar.Properties.Maximum = dataset1.Tables(0).Rows.Count
        barlabel.Text = "Toplam Satýr Sayýsý : " & dataset1.Tables(0).Rows.Count
        bar.Position = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim nAlisVerisID As String = ""
        Dim fark As Decimal = 0
        Dim alisverisler As String = "("
        Dim toplamsayi = dataset1.Tables(0).Rows.Count
        Dim sayi As Int64 = 0
        For Each dr In dataset1.Tables(0).Rows
            barlabel.Text = "AlýþVeriþNo:" & dr("nAlisVerisID").ToString & vbTab & "Adý:" & dr("sMusteriAdi").ToString
            barlabel.Refresh()
            sayi += 1
            If nAlisVerisID <> Trim(dr("nAlisVerisID")) Then
                If fark < 0 Then
                    fark = 0
                    If islem = 1 Then
                        dr2 = DataSet2.Tables(0).NewRow
                        dr2(0) = nAlisVerisID.ToString
                        DataSet2.Tables(0).Rows.Add(dr2)
                        fark = 0
                    End If
                ElseIf fark > 0 Then
                    fark = 0
                    If islem = 2 Then
                        dr2 = DataSet2.Tables(0).NewRow
                        dr2(0) = nAlisVerisID.ToString
                        DataSet2.Tables(0).Rows.Add(dr2)
                        fark = 0
                    End If
                Else
                    fark = 0
                End If
                nAlisVerisID = Trim(dr("nAlisVerisID"))
                fark += dr("FARK")
            Else
                fark += dr("FARK")
            End If
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        toplamsayi = DataSet2.Tables(0).Rows.Count
        sayi = 0
        alisverisler = "("
        For Each dr1 In DataSet2.Tables(0).Rows
            alisverisler += "'" & dr1(0) & "'"
            sayi += 1
            If sayi < toplamsayi Then
                alisverisler += ","
            ElseIf sayi = toplamsayi Then
                'alisverisler += ")"
            End If
        Next
        alisverisler += ")"
        DataSet2.Tables(0).Clear()
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        dr1 = Nothing
        sayi = Nothing
        toplamsayi = Nothing
        Return alisverisler
    End Function
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
    Private Sub kontrol_hazirla()
        Dim dr As DataRow
        hareket_kaydet_sifirla()
        For Each dr In dataset1.Tables(0).Rows
            hareket_kaydet_yeni(dr("nStokFisiID"), dr("sKodu"), Microsoft.VisualBasic.Left(dr("sAciklama"), 50), dr("sRenk"), sorgu_sayi(dr("lGirisMiktar1"), 0), sorgu_sayi(dr("lGirisMiktar2"), 0), sorgu_sayi(dr("lGirisFiyat"), 0), sorgu_sayi(dr("lGirisTutar"), 0), dr("sFiyatTipi"), sorgu_sayi(dr("lBrutFiyat"), 0), sorgu_sayi(dr("lBrutTutar"), 0), sorgu_sayi(dr("nIskontoYuzdesi"), 0), sorgu_sayi(dr("lIskontoTutari"), 0), dr("sDovizCinsi"), sorgu_sayi(dr("lDovizFiyat"), 0), dr("nSiparisID").ToString, dr("Expr1"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("sDepo"), dr("nStokID"), dr("nFirmaID"), dr("nIrsaliyeFisiID").ToString, dr("sStokIslem"), sorgu_sayi(dr("nOtvOrani"), 0), sorgu_sayi(dr("nKdvOrani"), 0), dr("nIslemID"), sorgu_sayi(dr("ISK1"), 0), sorgu_sayi(dr("ISK2"), 0), sorgu_sayi(dr("ISK3"), 0), sorgu_sayi(dr("ISK4"), 0), sorgu_sayi(dr("GERCEKFIYAT"), 0), sorgu_sayi(dr("ISKONTO"), 0), sorgu_sayi(dr("ISKONTOTUTAR"), 0), sorgu_sayi(dr("GERCEKTOPLAM"), 0), sorgu_sayi(dr("Fark"), 0), sorgu_sayi(dr("FarkOran"), 0), sorgu_sayi(dr("EKMASRAF"), 0), sorgu_sayi(dr("ONCEKIMALIYET"), 0), dr("Durum"), dr("FirmaKodu"), Microsoft.VisualBasic.Left(dr("FirmaAdi"), 50), dr("sFisTipi"), dr("dteFisTarihi"), dr("nGirisCikis"), dr("lFisNo"), sorgu_sayi(dr("lToplamMiktar"), 0), sorgu_sayi(dr("lMalBedeli"), 0), sorgu_sayi(dr("lMalIskontoTutari"), 0), sorgu_sayi(dr("lDipIskontoTutari3"), 0), sorgu_sayi(dr("lNetTutar"), 0))
        Next
        dr = Nothing
        'MsgBox(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function nullCevir(ByVal dbn As Object, ByVal tur As Integer) As Object
        If IsDBNull(dbn) Then
            If tur = 1 Then
                dbn = ""
            ElseIf tur = 2 Then
                dbn = 0
            End If
        End If
        Return dbn
    End Function
    Private Sub satis_kontrol_hazirla()
        Dim dr As DataRow
        satis_hareket_kaydet_sifirla()
        If dataset1.Tables(0).Rows.Count > 0 Then
            For Each dr In dataset1.Tables(0).Rows
                satis_hareket_kaydet_yeni(nullCevir(dr("nAlisVerisID"), 1), nullCevir(dr("nMusteriID"), 2), nullCevir(dr("lKodu"), 1), nullCevir(dr("sMusteriAdi"), 1), dr("dteTarih"), nullCevir(dr("fisTipi"), 1), nullCevir(dr("lNo"), 1), nullCevir(dr("nStokID"), 2), nullCevir(dr("sKodu"), 1), nullCevir(dr("sStokAciklama"), 1), sorgu_sayi(dr("Miktar"), 0), sorgu_sayi(dr("Fiyat"), 0), sorgu_sayi(dr("Iskonto"), 0), sorgu_sayi(dr("lNetTutar"), 0), nullCevir(dr("sOdemeKodu"), 1), nullCevir(dr("sFiyatTipi"), 1), nullCevir(dr("sSaticiRumuzu"), 1), nullCevir(dr("sKasiyerRumuzu"), 1), nullCevir(dr("nGirisCikis"), 2), nullCevir(dr("sMagaza"), 1), nullCevir(dr("sRenk"), 1), sorgu_sayi(dr("PESIN"), 0), sorgu_sayi(dr("ONAY"), 0), sorgu_sayi(dr("ALTIAY"), 0), sorgu_sayi(dr("MALIYET"), 0), sorgu_sayi(dr("gFiyat"), 0), sorgu_sayi(dr("ORAN1"), 0), sorgu_sayi(dr("KAR"), 0), sorgu_sayi(dr("FARK"), 0), sorgu_sayi(dr("FIYATFARKI"), 0), sorgu_sayi(dr("NORMALFIYAT"), 0), sorgu_sayi(dr("NORMALTUTAR"), 0), sorgu_tarih(dr("SonAlisTarihi"), "01/01/1900"))
            Next
        End If
        dr = Nothing
    End Sub
    Private Sub hareket_kaydet_sifirla()
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Truncate Table aEmirAlisDetay ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub satis_hareket_kaydet_sifirla()
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Truncate Table aEmirSatisDetay ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_yeni(ByVal nStokFisiID As Integer, ByVal sKodu As String, ByVal sAciklama As String, ByVal sRenk As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal Expr1 As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal sDepo As String, ByVal nStokID As Int64, ByVal nFirmaID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sStokIslem As String, ByVal nOtvOrani As Decimal, ByVal nKdvOrani As Decimal, ByVal nIslemID As Int64, ByVal ISK1 As Decimal, ByVal ISK2 As Decimal, ByVal ISK3 As Decimal, ByVal ISK4 As Decimal, ByVal GERCEKFIYAT As Decimal, ByVal ISKONTO As Decimal, ByVal ISKONTOTUTAR As Decimal, ByVal GERCEKTOPLAM As Decimal, ByVal Fark As Decimal, ByVal FarkOran As Decimal, ByVal EKMASRAF As Decimal, ByVal ONCEKIMALIYET As Decimal, ByVal Durum As String, ByVal FirmaKodu As String, ByVal FirmaAdi As String, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Integer, ByVal lFisNo As Int64, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lNetTutar As Decimal)
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO aEmirAlisDetay                       (nStokFisiID, sKodu, sAciklama, sRenk, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, Expr1, dteIrsaliyeTarihi, lIrsaliyeNo, sDepo, nStokID, nFirmaID, nIrsaliyeFisiID, sStokIslem, nOtvOrani, nKdvOrani, nIslemID, ISK1, ISK2, ISK3, ISK4, GERCEKFIYAT, ISKONTO, ISKONTOTUTAR, GERCEKTOPLAM, Fark, FarkOran, EKMASRAF,ONCEKIMALIYET, Durum, FirmaKodu, FirmaAdi, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, lToplamMiktar, lMalBedeli, lMalIskontoTutari,lDipIskontoTutari3, lNetTutar) VALUES     (" & nStokFisiID & ", '" & sKodu & "', N'" & sAciklama & "', '" & sRenk & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & " , '" & sFiyatTipi & "', " & lBrutFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & "," & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", 0, '" & Expr1 & "', '" & dteIrsaliyeTarihi & "', " & lIrsaliyeNo & ", '" & sDepo & "', " & nStokID & ", " & nFirmaID & ", 0, '" & sStokIslem & "'," & nOtvOrani & ", " & nKdvOrani & ", " & nIslemID & ", " & ISK1 & ", " & ISK2 & ", " & ISK3 & ", " & ISK4 & ", " & GERCEKFIYAT & ", " & ISKONTO & ", " & ISKONTOTUTAR & ", " & GERCEKTOPLAM & ", " & Fark & ", " & FarkOran & ", " & EKMASRAF & "," & ONCEKIMALIYET & ", '" & Durum & "', '" & FirmaKodu & "', '" & FirmaAdi & "', '" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & ", " & lFisNo & ", " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & lDipIskontoTutari3 & ", " & lNetTutar & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub satis_hareket_kaydet_yeni(ByVal nAlisverisID As String, ByVal nMusteriID As Int64, ByVal lKodu As String, ByVal sMusteriAdi As String, ByVal dteTarih As DateTime, ByVal fisTipi As String, ByVal lNo As String, ByVal nStokID As Int64, ByVal sKodu As String, ByVal sStokAciklama As String, ByVal Miktar As Decimal, ByVal Fiyat As Decimal, ByVal Iskonto As Decimal, ByVal lNetTutar As Decimal, ByVal sOdemeKodu As String, ByVal sFiyatTipi As String, ByVal sSaticiRumuzu As String, ByVal sKasiyerRumuzu As String, ByVal nGirisCikis As Int64, ByVal sMagaza As String, ByVal sRenk As String, ByVal PESIN As Decimal, ByVal ONAY As Decimal, ByVal ALTIAY As Decimal, ByVal MALIYET As Decimal, ByVal gFiyat As Decimal, ByVal ORAN1 As Decimal, ByVal KAR As Decimal, ByVal FARK As Decimal, ByVal FIYATFARKI As Decimal, ByVal NORMALFIYAT As Decimal, ByVal NORMALTUTAR As Decimal, ByVal SonAlisTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO aEmirSatisDetay (nAlisverisID, nMusteriID, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, nStokID, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, sOdemeKodu, sFiyatTipi, sSaticiRumuzu, sKasiyerRumuzu, nGirisCikis, sMagaza, sRenk, PESIN, ONAY, ALTIAY, MALIYET, gFiyat, ORAN1, KAR, FARK, FIYATFARKI, NORMALFIYAT, NORMALTUTAR, SonAlisTarihi) VALUES     ('" & nAlisverisID & "', " & nMusteriID & ", '" & lKodu & "', '" & sMusteriAdi & "', '" & dteTarih & "', '" & fisTipi & "', '" & lNo & "', " & nStokID & ", '" & sKodu & "', '" & sStokAciklama & "', " & Miktar & ", " & Fiyat & ", " & Iskonto & ", " & lNetTutar & ", '" & sOdemeKodu & "', '" & sFiyatTipi & "', '" & sSaticiRumuzu & "', '" & sKasiyerRumuzu & "', " & nGirisCikis & ", '" & sMagaza & "', '" & sRenk & "', " & PESIN & ", " & ONAY & ", " & ALTIAY & ", " & MALIYET & ", " & gFiyat & ", " & ORAN1 & ", " & KAR & ", " & FARK & ", " & FIYATFARKI & ", " & NORMALFIYAT & ", " & NORMALTUTAR & ", '" & SonAlisTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_alislar(ByVal tarih As DateTime, ByVal fisno As String, ByVal stokkodu As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < = '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') AND (tbStokFisiDetayi.lFisNo <> '" & fisno & "') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub raporla(ByVal status As Integer, Optional ByVal YeniTarih As String = "", Optional ByVal IstekID As String = "")
        Dim file1 As String
        Dim ara As String
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            frx.ClearReport()
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection)
            If status <> 4 Then
                file1 = "c:\Formlar\Raporlar\Faaliyet_Kontrol.fr3"
            Else
                file1 = "c:\Formlar\Raporlar\Faaliyet_Kontrol_Mobile.fr3"
            End If
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(file1)
            If status <> 4 Then
                frx.SetVariable("IslemTarihi", "'" & DateEdit1.EditValue & "'")
            Else
                Dim str As String = ""
                Dim strArr() As String
                str = YeniTarih
                strArr = str.Split(".")
                str = strArr(0) & "/" & strArr(1) & "/" & strArr(2)
                frx.SetVariable("IslemTarihi", "'" & str & " 00:00:00'")
            End If
            ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
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
            frx.PrintOptions.Printer = adi
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
                frx.DisableDialogs = False
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.ShowDialog = True
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 4 Then
                Try
                    frx.PrepareReport(True)
                    If RadioGroup1.SelectedIndex = 0 Then
                        frx.ExportToHTML("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende\Faaliyet.html", False, True, False, False, True, False)
                    Else
                        frx.ExportToHTML("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura\Faaliyet.html", False, True, False, False, True, False)
                    End If
                    FaaliyetDurumDegistir(1, 2, IstekID, "1")
                    If otoIslemFaaliyet = True Then
                        Me.Hide()
                    End If
                Catch ex As Exception
                End Try
            End If
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection)
            args(0) = "c:\Formlar\Raporlar\Faaliyet_Kontrol.fr3"
            args(1) = "" & connection.ToString() & ""
            args(2) = ""
            args(3) = ""
            args(4) = "" & status.ToString() & ""
            args(5) = "1"
            args(6) = "IslemTarihi"
            args(7) = "'" & DateEdit1.EditValue & "'"
            ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
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
            processYol = args(0)
            For i As Integer = 1 To 7
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
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        raporla(2)
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla(2)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OtoFaaliyetThread()
    End Sub
End Class
