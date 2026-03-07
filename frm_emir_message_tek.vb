Imports DevExpress.XtraEditors
Public Class frm_emir_message_tek
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
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_message As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_cevap As DevExpress.XtraEditors.MemoEdit
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
    Friend WithEvents txt_tarih As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_kimden As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_message_tek))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.txt_cevap = New DevExpress.XtraEditors.MemoEdit
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txt_message = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txt_tarih = New DevExpress.XtraEditors.DateEdit
        Me.txt_kimden = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txt_cevap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_message.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kimden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(440, 56)
        Me.PanelControl1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mesajýnýz Var."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 408)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(440, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(352, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(272, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(440, 352)
        Me.PanelControl3.TabIndex = 2
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txt_cevap)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 240)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(424, 100)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Cevap:"
        '
        'txt_cevap
        '
        Me.txt_cevap.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Cevap", True))
        Me.txt_cevap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_cevap.Location = New System.Drawing.Point(2, 22)
        Me.txt_cevap.Name = "txt_cevap"
        Me.txt_cevap.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_cevap.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_cevap.Properties.Appearance.Options.UseFont = True
        Me.txt_cevap.Properties.Appearance.Options.UseForeColor = True
        Me.txt_cevap.Size = New System.Drawing.Size(420, 76)
        Me.txt_cevap.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Kimden"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Kim"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Message"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dteTarih"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "PersonelNo"
        Me.DataColumn6.DataType = GetType(Long)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Okundu"
        Me.DataColumn7.DataType = GetType(Boolean)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteTarihOkundu"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Cevap"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_message)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 82)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(424, 150)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Mesaj:"
        '
        'txt_message
        '
        Me.txt_message.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Message", True))
        Me.txt_message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_message.Location = New System.Drawing.Point(2, 22)
        Me.txt_message.Name = "txt_message"
        Me.txt_message.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_message.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_message.Properties.Appearance.Options.UseBackColor = True
        Me.txt_message.Properties.Appearance.Options.UseFont = True
        Me.txt_message.Properties.ReadOnly = True
        Me.txt_message.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_message.Size = New System.Drawing.Size(420, 126)
        Me.txt_message.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_tarih)
        Me.GroupControl1.Controls.Add(Me.txt_kimden)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(424, 69)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Mesaj Sahibi"
        '
        'txt_tarih
        '
        Me.txt_tarih.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.dteTarih", True))
        Me.txt_tarih.EditValue = Nothing
        Me.txt_tarih.Location = New System.Drawing.Point(96, 44)
        Me.txt_tarih.Name = "txt_tarih"
        Me.txt_tarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tarih.Properties.Appearance.Options.UseBackColor = True
        Me.txt_tarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tarih.Properties.DisplayFormat.FormatString = "dd.MM.yy HH:mm"
        Me.txt_tarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_tarih.Properties.ReadOnly = True
        Me.txt_tarih.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_tarih.Size = New System.Drawing.Size(320, 20)
        Me.txt_tarih.TabIndex = 3
        '
        'txt_kimden
        '
        Me.txt_kimden.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.Kim", True))
        Me.txt_kimden.Location = New System.Drawing.Point(96, 22)
        Me.txt_kimden.Name = "txt_kimden"
        Me.txt_kimden.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_kimden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_kimden.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_kimden.Properties.Appearance.Options.UseBackColor = True
        Me.txt_kimden.Properties.Appearance.Options.UseFont = True
        Me.txt_kimden.Properties.Appearance.Options.UseForeColor = True
        Me.txt_kimden.Properties.ReadOnly = True
        Me.txt_kimden.Size = New System.Drawing.Size(320, 20)
        Me.txt_kimden.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tarih:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kimden:"
        '
        'frm_emir_message_tek
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(440, 448)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_emir_message_tek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesaj"
        Me.TopMost = True
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.txt_cevap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_message.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kimden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        cikis()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        cikis()
    End Sub
    Private Sub cikis()
        emir_message_kontrol()
        If Trim(txt_cevap.EditValue) <> "" Then
            emir_message_ekle()
        End If
        'Me.Close()
    End Sub
    Private Sub frm_emir_message_tek_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        GroupControl3.Focus()
        txt_cevap.Focus()
        txt_cevap.Select()
        'MsgBox(Sorgu_sDil("Mesajýnýz Var...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
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
    Private Sub dataload()
        DataSet1 = sorgu(sorgu_query("SELECT     * FROM         aEmirMessage Where IND =" & kayitno & " "))
        Dim dr As DataRow = DataSet1.Tables(0).Rows(0)
        txt_kimden.EditValue = dr("Kim")
        txt_tarih.EditValue = dr("dteTarih")
        txt_message.EditValue = dr("Message")
        txt_message.Focus()
        txt_message.Select(Trim(Len(txt_message.EditValue)) - 1, 1)
        txt_message.ScrollToCaret()
        dr = Nothing
    End Sub
    Private Sub emir_message_kontrol()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'Dim kayitno As Int64
        cmd.CommandText = "Set Dateformat DMY UPDATE aEmirMessage SET OKUNDU = 1 ,STATUS=2,dteTarihOkundu = '" & Now & "',Cevap = '" & txt_cevap.EditValue & "' WHERE IND ='" & kayitno & "' "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub emir_message_ekle()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim dr As DataRow = DataSet1.Tables(0).Rows(0)
        Dim message As String = ""
        'message += "=======================" & vbCrLf
        'message += "Orjinal Mesaj" & vbCrLf
        'message += "Tarih : " & dr("dteTarih") & vbCrLf
        'message += "Kimden : " & dr("Kim") & vbCrLf
        'message += "Mesaj;" & vbCrLf
        message += dr("Message") & vbCrLf
        'message += "=======================" & vbCrLf
        'message += "Cevap: " & txt_cevap.EditValue & vbCrLf
        'message += dr("Kim") & vbTab & " Diyor ki ;" & vbTab & CType(dr("dteTarih"), DateTime).ToLongTimeString & vbCrLf
        message += kasiyer & vbTab & " Diyor ki ;" & vbTab & CType(dr("dteTarih"), DateTime).ToLongTimeString & vbCrLf
        message += txt_cevap.EditValue & vbCrLf & vbCrLf
        'MsgBox(message)
        cmd.CommandText = "Set Dateformat DMY INSERT INTO aEmirMessage                        (Kimden, Kim, Message, dteTarih, PersonelNo, Personel, Okundu, Status)  VALUES     (" & kasiyerno & ", '" & kasiyer & "', '" & message & "' , '" & Now & "', '" & dr("Kimden") & "', '" & dr("Kim") & "', 0, 0)"
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
End Class
