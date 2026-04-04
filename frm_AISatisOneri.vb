' ============================================================================
' SATIS ONERI MOTORU FORMU
' ============================================================================
' Secili firma icin gecmis siparis verilerine dayanarak urun onerileri sunar
' API: POST /api/ai/satis-oneri
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net

Public Class frm_AISatisOneri
    Inherits Form

    Private pnlUst As Panel
    Private lblBaslik As Label
    Private txtFirmaId As TextBox
    Private lblFirmaAdi As Label
    Private WithEvents btnSorgula As Button

    Private dgvOneriler As DataGridView
    Private rtbAiOneri As RichTextBox

    Private statusStrip As StatusStrip
    Private lblStatus As ToolStripStatusLabel
    Private pnlAlt As SplitContainer


    Public nFirmaID As Integer = 0
    Public sFirmaAdi As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(firmaId As Integer, firmaAdi As String)
        InitializeComponent()
        nFirmaID = firmaId
        sFirmaAdi = firmaAdi
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "Satis Oneri Motoru"
        Me.Size = New Size(1000, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.Sizable

        ' Ust Panel
        pnlUst = New Panel()
        pnlUst.Dock = DockStyle.Top
        pnlUst.Height = 70
        pnlUst.BackColor = Color.FromArgb(39, 174, 96)
        pnlUst.Padding = New Padding(15, 10, 15, 10)

        lblBaslik = New Label()
        lblBaslik.Text = "Satis Oneri Motoru (AI)"
        lblBaslik.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblBaslik.ForeColor = Color.White
        lblBaslik.AutoSize = True
        lblBaslik.Location = New Point(15, 18)
        pnlUst.Controls.Add(lblBaslik)

        Dim lblFirmaIdLabel As New Label()
        lblFirmaIdLabel.Text = "Firma ID:"
        lblFirmaIdLabel.Font = New Font("Segoe UI", 10)
        lblFirmaIdLabel.ForeColor = Color.White
        lblFirmaIdLabel.AutoSize = True
        lblFirmaIdLabel.Location = New Point(550, 22)
        pnlUst.Controls.Add(lblFirmaIdLabel)

        txtFirmaId = New TextBox()
        txtFirmaId.Font = New Font("Segoe UI", 10)
        txtFirmaId.Size = New Size(80, 28)
        txtFirmaId.Location = New Point(620, 20)
        pnlUst.Controls.Add(txtFirmaId)

        btnSorgula = New Button()
        btnSorgula.Text = "Oneri Getir"
        btnSorgula.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSorgula.Size = New Size(120, 30)
        btnSorgula.Location = New Point(715, 18)
        btnSorgula.BackColor = Color.FromArgb(44, 62, 80)
        btnSorgula.ForeColor = Color.White
        btnSorgula.FlatStyle = FlatStyle.Flat
        pnlUst.Controls.Add(btnSorgula)

        lblFirmaAdi = New Label()
        lblFirmaAdi.Text = ""
        lblFirmaAdi.Font = New Font("Segoe UI", 10, FontStyle.Italic)
        lblFirmaAdi.ForeColor = Color.FromArgb(200, 255, 200)
        lblFirmaAdi.AutoSize = True
        lblFirmaAdi.Location = New Point(850, 22)
        pnlUst.Controls.Add(lblFirmaAdi)

        Me.Controls.Add(pnlUst)

        ' Split panel
        pnlAlt = New SplitContainer()
        pnlAlt.Dock = DockStyle.Fill
        pnlAlt.Orientation = Orientation.Horizontal
        pnlAlt.SplitterDistance = 350

        ' Grid
        dgvOneriler = New DataGridView()
        dgvOneriler.Dock = DockStyle.Fill
        dgvOneriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOneriler.ReadOnly = True
        dgvOneriler.AllowUserToAddRows = False
        dgvOneriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOneriler.BackgroundColor = Color.White
        dgvOneriler.Font = New Font("Segoe UI", 9)
        dgvOneriler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 174, 96)
        dgvOneriler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvOneriler.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvOneriler.EnableHeadersVisualStyles = False

        dgvOneriler.Columns.Add("stokKodu", "Stok Kodu")
        dgvOneriler.Columns.Add("stokAdi", "Urun Adi")
        dgvOneriler.Columns.Add("toplamMiktar", "Toplam Miktar")
        dgvOneriler.Columns.Add("siparisSayisi", "Siparis Sayisi")
        dgvOneriler.Columns.Add("sonSiparisTarih", "Son Siparis")
        dgvOneriler.Columns.Add("ortFiyat", "Ort. Fiyat")
        dgvOneriler.Columns.Add("neden", "Oneri Nedeni")

        dgvOneriler.Columns("stokKodu").Width = 100
        dgvOneriler.Columns("stokAdi").Width = 200
        dgvOneriler.Columns("toplamMiktar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvOneriler.Columns("siparisSayisi").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOneriler.Columns("ortFiyat").DefaultCellStyle.Format = "N2"
        dgvOneriler.Columns("ortFiyat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        pnlAlt.Panel1.Controls.Add(dgvOneriler)

        ' AI oneri
        rtbAiOneri = New RichTextBox()
        rtbAiOneri.Dock = DockStyle.Fill
        rtbAiOneri.ReadOnly = True
        rtbAiOneri.BackColor = Color.FromArgb(240, 255, 245)
        rtbAiOneri.Font = New Font("Segoe UI", 10)
        rtbAiOneri.BorderStyle = BorderStyle.None
        pnlAlt.Panel2.Controls.Add(rtbAiOneri)

        Me.Controls.Add(pnlAlt)

        ' Status bar
        statusStrip = New StatusStrip()
        lblStatus = New ToolStripStatusLabel("Hazir")
        statusStrip.Items.Add(lblStatus)
        Me.Controls.Add(statusStrip)
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        If nFirmaID > 0 Then
            txtFirmaId.Text = nFirmaID.ToString()
            lblFirmaAdi.Text = sFirmaAdi
            VeriYukle()
        End If
    End Sub

    Private Sub btnSorgula_Click(sender As Object, e As EventArgs) Handles btnSorgula.Click
        Dim fid As Integer = 0
        If Integer.TryParse(txtFirmaId.Text.Trim(), fid) AndAlso fid > 0 Then
            nFirmaID = fid
            VeriYukle()
        Else
            MessageBox.Show("Gecerli bir Firma ID girin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub VeriYukle()
        Try
            Me.Cursor = Cursors.WaitCursor
            lblStatus.Text = "Oneri yukleniyor..."
            Application.DoEvents()

            Dim aiSvc As New AIService()
            Dim result As String = aiSvc.SatisOneriGetir(CLng(nFirmaID))

            dgvOneriler.Rows.Clear()

            Dim firmaAdi As String = ParseField(result, "firmaAdi")
            Dim aiOneri As String = ParseField(result, "aiOneri")

            lblFirmaAdi.Text = firmaAdi
            Me.Text = "Satis Oneri Motoru - " & firmaAdi

            If aiOneri <> "" Then
                rtbAiOneri.Text = "AI ONERI:" & vbCrLf & aiOneri.Replace("\n", vbCrLf)
            Else
                rtbAiOneri.Text = "AI analizi aktif degil. Kural bazli oneriler tabloda goruntuleniyor."
            End If

            ' Parse oneriler array
            Dim listeStart As Integer = result.IndexOf("""oneriler"":[")
            If listeStart >= 0 Then
                Dim arrStart As Integer = result.IndexOf("[", listeStart)
                Dim arrEnd As Integer = FindMatchingBracket(result, arrStart)
                If arrEnd > arrStart Then
                    Dim listeJson As String = result.Substring(arrStart + 1, arrEnd - arrStart - 1)
                    ParseAndFillGrid(listeJson)
                End If
            End If

            lblStatus.Text = "Yuklendi - " & dgvOneriler.Rows.Count & " urun onerisi"
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            lblStatus.Text = "Hata: " & ex.Message
            MessageBox.Show("Oneri yuklenemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ParseAndFillGrid(listeJson As String)
        Dim pos As Integer = 0
        While pos < listeJson.Length
            Dim objStart As Integer = listeJson.IndexOf("{", pos)
            If objStart < 0 Then Exit While
            Dim objEnd As Integer = FindMatchingBrace(listeJson, objStart)
            If objEnd <= objStart Then Exit While

            Dim obj As String = listeJson.Substring(objStart, objEnd - objStart + 1)
            dgvOneriler.Rows.Add(
                ParseField(obj, "stokKodu"),
                ParseField(obj, "stokAdi"),
                ParseField(obj, "toplamMiktar"),
                ParseField(obj, "siparisSayisi"),
                ParseField(obj, "sonSiparisTarih"),
                ParseField(obj, "ortFiyat"),
                ParseField(obj, "neden")
            )
            pos = objEnd + 1
        End While
    End Sub

    Private Function FindMatchingBracket(json As String, start As Integer) As Integer
        Dim depth As Integer = 0
        For i As Integer = start To json.Length - 1
            If json(i) = "["c Then depth += 1
            If json(i) = "]"c Then
                depth -= 1
                If depth = 0 Then Return i
            End If
        Next
        Return -1
    End Function

    Private Function FindMatchingBrace(json As String, start As Integer) As Integer
        Dim depth As Integer = 0
        Dim inString As Boolean = False
        For i As Integer = start To json.Length - 1
            If json(i) = "\"c AndAlso Not inString Then
                i += 1
                Continue For
            End If
            If json(i) = Chr(34) Then inString = Not inString
            If Not inString Then
                If json(i) = "{"c Then depth += 1
                If json(i) = "}"c Then
                    depth -= 1
                    If depth = 0 Then Return i
                End If
            End If
        Next
        Return -1
    End Function

    Private Function ParseField(json As String, fieldName As String) As String
        Try
            Dim key As String = Chr(34) & fieldName & Chr(34)
            Dim keyIdx As Integer = json.IndexOf(key)
            If keyIdx < 0 Then Return ""
            Dim colonIdx As Integer = json.IndexOf(":", keyIdx + key.Length)
            If colonIdx < 0 Then Return ""
            Dim afterColon As String = json.Substring(colonIdx + 1).TrimStart()
            If afterColon.StartsWith(Chr(34)) Then
                Dim valueStart As Integer = 1
                Dim valueEnd As Integer = valueStart
                While valueEnd < afterColon.Length
                    If afterColon(valueEnd) = "\"c AndAlso valueEnd + 1 < afterColon.Length Then
                        valueEnd += 2
                    ElseIf afterColon(valueEnd) = Chr(34) Then
                        Exit While
                    Else
                        valueEnd += 1
                    End If
                End While
                Return afterColon.Substring(valueStart, valueEnd - valueStart)
            Else
                Dim endIdx As Integer = afterColon.IndexOfAny(New Char() {","c, "}"c, "]"c})
                If endIdx < 0 Then endIdx = afterColon.Length
                Return afterColon.Substring(0, endIdx).Trim()
            End If
        Catch
            Return ""
        End Try
    End Function
End Class
