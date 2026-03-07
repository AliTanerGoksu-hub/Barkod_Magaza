Imports DevExpress.XtraEditors
Public Class frm_personel_sifre_degistir
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
    Friend WithEvents txt_personel_kodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_personel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sifre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_personel_sifre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_onay As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_personel_sifre_degistir))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_personel_sifre = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_onay = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sifre = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_personel = New DevExpress.XtraEditors.TextEdit()
        Me.txt_personel_kodu = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txt_personel_sifre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_onay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sifre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_personel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_personel_kodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(292, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Personel Þifre Deðiþtirme Bilgileri Aþaðýdadýr."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(234, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 232)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(292, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(205, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(77, 25)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(128, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(77, 25)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.txt_personel_sifre)
        Me.PanelControl3.Controls.Add(Me.Label5)
        Me.PanelControl3.Controls.Add(Me.txt_onay)
        Me.PanelControl3.Controls.Add(Me.Label4)
        Me.PanelControl3.Controls.Add(Me.txt_sifre)
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.txt_personel)
        Me.PanelControl3.Controls.Add(Me.txt_personel_kodu)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(292, 176)
        Me.PanelControl3.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Eski Þifre:"
        '
        'txt_personel_sifre
        '
        Me.txt_personel_sifre.Location = New System.Drawing.Point(86, 57)
        Me.txt_personel_sifre.Name = "txt_personel_sifre"
        Me.txt_personel_sifre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_personel_sifre.Properties.Appearance.Options.UseFont = True
        Me.txt_personel_sifre.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_personel_sifre.Size = New System.Drawing.Size(200, 20)
        Me.txt_personel_sifre.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(18, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Þifre Onay:"
        '
        'txt_onay
        '
        Me.txt_onay.Enabled = False
        Me.txt_onay.EnterMoveNextControl = True
        Me.txt_onay.Location = New System.Drawing.Point(86, 111)
        Me.txt_onay.Name = "txt_onay"
        Me.txt_onay.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_onay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_onay.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_onay.Properties.Appearance.Options.UseBackColor = True
        Me.txt_onay.Properties.Appearance.Options.UseFont = True
        Me.txt_onay.Properties.Appearance.Options.UseForeColor = True
        Me.txt_onay.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_onay.Size = New System.Drawing.Size(200, 20)
        Me.txt_onay.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Yeni Þifre:"
        '
        'txt_sifre
        '
        Me.txt_sifre.Enabled = False
        Me.txt_sifre.EnterMoveNextControl = True
        Me.txt_sifre.Location = New System.Drawing.Point(86, 86)
        Me.txt_sifre.Name = "txt_sifre"
        Me.txt_sifre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sifre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sifre.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_sifre.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sifre.Properties.Appearance.Options.UseFont = True
        Me.txt_sifre.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sifre.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_sifre.Size = New System.Drawing.Size(200, 20)
        Me.txt_sifre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PersonelAdý:"
        '
        'txt_personel
        '
        Me.txt_personel.Enabled = False
        Me.txt_personel.Location = New System.Drawing.Point(86, 31)
        Me.txt_personel.Name = "txt_personel"
        Me.txt_personel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_personel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_personel.Properties.Appearance.Options.UseFont = True
        Me.txt_personel.Properties.Appearance.Options.UseForeColor = True
        Me.txt_personel.Size = New System.Drawing.Size(200, 20)
        Me.txt_personel.TabIndex = 4
        '
        'txt_personel_kodu
        '
        Me.txt_personel_kodu.Enabled = False
        Me.txt_personel_kodu.Location = New System.Drawing.Point(86, 5)
        Me.txt_personel_kodu.Name = "txt_personel_kodu"
        Me.txt_personel_kodu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_personel_kodu.Properties.Appearance.Options.UseFont = True
        Me.txt_personel_kodu.Properties.MaxLength = 7
        Me.txt_personel_kodu.Size = New System.Drawing.Size(200, 20)
        Me.txt_personel_kodu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PersonelKodu:"
        '
        'frm_personel_sifre_degistir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(292, 272)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_personel_sifre_degistir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personel Þifre Deðiþtirme Formu"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txt_personel_sifre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_onay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sifre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_personel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_personel_kodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim personel
    Dim personelno
    Dim ds_personel As DataSet
    Dim status As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Trim(txt_sifre.Text) = Trim(txt_onay.Text) Then
            Try
                duzelt_sifre(personelno, txt_personel_kodu.Text, personel, Trim(txt_sifre.Text), Trim(txt_onay.Text))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Hata Oluþtu Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Þifre ve/vaya Onay Þifrenizi  Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_sifre.Focus()
            txt_sifre.Select()
        End If
    End Sub
    Private Sub duzelt_sifre(ByVal IND As Int64, ByVal personelkodu As String, ByVal personel As String, ByVal sifre As String, ByVal onay As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE APERSONEL SET SIFRE = '" & sifre & "', ONAY = '" & onay & "' WHERE IND = " & IND & "")
            cmd.ExecuteNonQuery()
            con.Close()
            XtraMessageBox.Show(Sorgu_sDil("Yeni Þifreniz Bir sonraki Oturumda Geçerli Olacaktýr...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Hata Oluþtu Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        con.Close()
    End Sub
    Private Sub frm_personel_sifre_degistir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_personel()
        txt_personel_kodu.Text = kullaniciKodu
        txt_personel.Text = kullaniciadi
        personel_kod_kontrol()
    End Sub
    Private Sub dataload_personel()
        ds_personel = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND, PERSONELKODU, PERSONELADI, SIFRE, ONAY FROM APERSONEL ORDER BY PERSONELKODU"))
    End Sub
    Private Sub txt_personel_kodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_personel_kodu.KeyDown
        If e.KeyCode = Keys.Enter Then
            personel_kod_kontrol()
        End If
    End Sub
    Private Sub txt_personel_sifre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_personel_sifre.KeyDown
        If e.KeyCode = Keys.Enter Then
            personel_sifre_kontrol()
        End If
    End Sub
    Private Sub personel_kod_kontrol()
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_personel.Tables(0).Rows
            If dr("PERSONELKODU") = txt_personel_kodu.Text Then
                personelno = dr("IND")
                personel = dr("PERSONELADI")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            txt_personel_sifre.Enabled = True
            txt_personel_sifre.Focus()
            txt_personel_sifre.Select()
            txt_personel.Text = personel
            txt_personel_kodu.Properties.ReadOnly = True
        End If
        If sonuc = False Then
            txt_personel_kodu.Focus()
            txt_personel_kodu.Select()
            SimpleButton1.Enabled = False
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Personel Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub personel_sifre_kontrol()
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_personel.Tables(0).Rows
            If dr("PERSONELKODU") = txt_personel_kodu.Text Then
                If dr("SIFRE") = txt_personel_sifre.Text Then
                    sonuc = True
                End If
            End If
        Next
        If sonuc = True Then
            txt_personel_sifre.Properties.ReadOnly = True
            SimpleButton1.Enabled = True
            txt_sifre.Enabled = True
            txt_onay.Enabled = True
            txt_sifre.Focus()
            txt_sifre.SelectAll()
        ElseIf sonuc = False Then
            SimpleButton1.Enabled = False
            txt_onay.Enabled = False
            txt_sifre.Enabled = False
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_personel_sifre.Focus()
            txt_personel_sifre.SelectAll()
        End If
    End Sub
End Class
