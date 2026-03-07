Imports DevExpress.XtraEditors
Public Class frm_emir_message_tek_gonder
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kime As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_kimden As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_message As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_message_tek_gonder))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_message = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_kime = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_kimden = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_message.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_kime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kimden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(438, 56)
        Me.PanelControl1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mesaj Gönder."
        '
        'PictureBox1
        '
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
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 350)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(438, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(352, 16)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(272, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(438, 294)
        Me.PanelControl3.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_message)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 93)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(408, 192)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Mesaj"
        '
        'txt_message
        '
        Me.txt_message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_message.Location = New System.Drawing.Point(2, 15)
        Me.txt_message.Name = "txt_message"
        Me.txt_message.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_message.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_message.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_message.Properties.Appearance.Options.UseBackColor = True
        Me.txt_message.Properties.Appearance.Options.UseFont = True
        Me.txt_message.Properties.Appearance.Options.UseForeColor = True
        Me.txt_message.Size = New System.Drawing.Size(404, 175)
        Me.txt_message.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_kime)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_kimden)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(408, 72)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Mesaj Bilgileri"
        '
        'sec_kime
        '
        Me.sec_kime.EnterMoveNextControl = True
        Me.sec_kime.Location = New System.Drawing.Point(88, 43)
        Me.sec_kime.Name = "sec_kime"
        Me.sec_kime.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_kime.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_kime.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_kime.Properties.Appearance.Options.UseBackColor = True
        Me.sec_kime.Properties.Appearance.Options.UseFont = True
        Me.sec_kime.Properties.Appearance.Options.UseForeColor = True
        Me.sec_kime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kime.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Personeller")})
        Me.sec_kime.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_kime.Properties.NullText = "[Personeller]"
        Me.sec_kime.Properties.ShowFooter = False
        Me.sec_kime.Properties.ShowHeader = False
        Me.sec_kime.Properties.ValueMember = "IND"
        Me.sec_kime.Size = New System.Drawing.Size(312, 20)
        Me.sec_kime.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kime:"
        '
        'sec_kimden
        '
        Me.sec_kimden.EnterMoveNextControl = True
        Me.sec_kimden.Location = New System.Drawing.Point(88, 24)
        Me.sec_kimden.Name = "sec_kimden"
        Me.sec_kimden.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_kimden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_kimden.Properties.Appearance.Options.UseBackColor = True
        Me.sec_kimden.Properties.Appearance.Options.UseFont = True
        Me.sec_kimden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kimden.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Personeller")})
        Me.sec_kimden.Properties.DisplayMember = "ACIKLAMA"
        Me.sec_kimden.Properties.NullText = "[Personeller]"
        Me.sec_kimden.Properties.ShowFooter = False
        Me.sec_kimden.Properties.ShowHeader = False
        Me.sec_kimden.Properties.ValueMember = "IND"
        Me.sec_kimden.Size = New System.Drawing.Size(312, 20)
        Me.sec_kimden.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kimden:"
        '
        'frm_emir_message_tek_gonder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(438, 398)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_emir_message_tek_gonder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesaj Gönder"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_message.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_kime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kimden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kayitno
    Public status
    Public kullanici
    Public kasiyerno
    Public kasiyer
    Public personelno
    Public personel
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_kimden As DataSet
    Dim ds_kime As DataSet
    Private Sub frm_emir_message_tek_gonder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_kasiyer()
        txt_message.Focus()
        txt_message.Select()
    End Sub
    Private Sub dataload_kasiyer()
        ds_kimden = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     IND, PERSONELADI AS ACIKLAMA, SIFRE FROM         APERSONEL WHERE IND ='" & kasiyerno & "'"))
        ds_kime = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     IND, PERSONELADI AS ACIKLAMA, SIFRE FROM         APERSONEL WHERE IND = '" & personelno & "'"))
        sec_kimden.Properties.DataSource = ds_kimden.Tables(0)
        sec_kimden.ItemIndex = 0
        sec_kime.Properties.DataSource = ds_kime.Tables(0)
        sec_kime.ItemIndex = 0
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
        cmd.CommandTimeout = Nothing
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
    Private Sub emir_message_ekle()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim message As String = ""
        message = txt_message.EditValue
        cmd.CommandText = "Set Dateformat DMY INSERT INTO aEmirMessage                        (Kimden, Kim, Message, dteTarih, PersonelNo, Personel, Okundu, Status)  VALUES     (" & kasiyerno & ", '" & kasiyer & "', '" & message & "' , '" & Now & "', '" & sec_kime.EditValue & "', '" & sec_kime.Text & "', 0, 0)"
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        emir_message_ekle()
        Me.Close()
    End Sub
End Class
