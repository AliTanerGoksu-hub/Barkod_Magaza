' ============================================================================
' TAHSILAT AI ASISTANI FORMU
' ============================================================================
' Vadesi gecmis musterileri listeler, AI tabanli tahsilat plani olusturur
' API: GET /api/ai/tahsilat-plani
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net

Public Class frm_AITahsilatAsistani
    Inherits Form

    Private dgvMusteriler As DataGridView
    Private rtbOzet As RichTextBox
    Private rtbAiAnaliz As RichTextBox
    Private lblBaslik As Label
    Private lblToplamBakiye As Label
    Private lblMusteriSayisi As Label
    Private WithEvents btnYenile As Button
    Private WithEvents btnAiAnaliz As Button
    Private pnlUst As Panel
    Private pnlAlt As SplitContainer
    Private statusStrip As StatusStrip
    Private lblStatus As ToolStripStatusLabel

    Private Const API_URL As String = "https://desktop.barkodyazilimevi.com"
    Private Const API_KEY As String = "BSmart2024Desktop!@#SecureKey"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "Tahsilat AI Asistani"
        Me.Size = New Size(1100, 750)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.Sizable

        ' Ust Panel
        pnlUst = New Panel()
        pnlUst.Dock = DockStyle.Top
        pnlUst.Height = 80
        pnlUst.BackColor = Color.FromArgb(44, 62, 80)
        pnlUst.Padding = New Padding(15, 10, 15, 10)

        lblBaslik = New Label()
        lblBaslik.Text = "Tahsilat AI Asistani"
        lblBaslik.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblBaslik.ForeColor = Color.White
        lblBaslik.AutoSize = True
        lblBaslik.Location = New Point(15, 10)
        pnlUst.Controls.Add(lblBaslik)

        lblToplamBakiye = New Label()
        lblToplamBakiye.Text = "Toplam: -"
        lblToplamBakiye.Font = New Font("Segoe UI", 11)
        lblToplamBakiye.ForeColor = Color.FromArgb(241, 196, 15)
        lblToplamBakiye.AutoSize = True
        lblToplamBakiye.Location = New Point(15, 48)
        pnlUst.Controls.Add(lblToplamBakiye)

        lblMusteriSayisi = New Label()
        lblMusteriSayisi.Text = ""
        lblMusteriSayisi.Font = New Font("Segoe UI", 11)
        lblMusteriSayisi.ForeColor = Color.FromArgb(46, 204, 113)
        lblMusteriSayisi.AutoSize = True
        lblMusteriSayisi.Location = New Point(350, 48)
        pnlUst.Controls.Add(lblMusteriSayisi)

        btnYenile = New Button()
        btnYenile.Text = "Yenile"
        btnYenile.Font = New Font("Segoe UI", 10)
        btnYenile.Size = New Size(100, 35)
        btnYenile.Location = New Point(880, 15)
        btnYenile.BackColor = Color.FromArgb(52, 152, 219)
        btnYenile.ForeColor = Color.White
        btnYenile.FlatStyle = FlatStyle.Flat
        pnlUst.Controls.Add(btnYenile)

        btnAiAnaliz = New Button()
        btnAiAnaliz.Text = "AI Analiz"
        btnAiAnaliz.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnAiAnaliz.Size = New Size(100, 35)
        btnAiAnaliz.Location = New Point(990, 15)
        btnAiAnaliz.BackColor = Color.FromArgb(142, 68, 173)
        btnAiAnaliz.ForeColor = Color.White
        btnAiAnaliz.FlatStyle = FlatStyle.Flat
        pnlUst.Controls.Add(btnAiAnaliz)

        Me.Controls.Add(pnlUst)

        ' Alt Split Panel (Grid + Ozet)
        pnlAlt = New SplitContainer()
        pnlAlt.Dock = DockStyle.Fill
        pnlAlt.Orientation = Orientation.Horizontal
        pnlAlt.SplitterDistance = 400

        ' Grid
        dgvMusteriler = New DataGridView()
        dgvMusteriler.Dock = DockStyle.Fill
        dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMusteriler.ReadOnly = True
        dgvMusteriler.AllowUserToAddRows = False
        dgvMusteriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMusteriler.BackgroundColor = Color.White
        dgvMusteriler.Font = New Font("Segoe UI", 9)
        dgvMusteriler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94)
        dgvMusteriler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvMusteriler.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvMusteriler.EnableHeadersVisualStyles = False

        dgvMusteriler.Columns.Add("oncelik", "Oncelik")
        dgvMusteriler.Columns.Add("firmaAd", "Firma")
        dgvMusteriler.Columns.Add("il", "Il")
        dgvMusteriler.Columns.Add("bakiye", "Bakiye")
        dgvMusteriler.Columns.Add("gecikmeGun", "Gecikme (Gun)")
        dgvMusteriler.Columns.Add("krediLimiti", "Kredi Limiti")
        dgvMusteriler.Columns.Add("riskSeviye", "Risk")

        dgvMusteriler.Columns("oncelik").Width = 60
        dgvMusteriler.Columns("firmaAd").Width = 250
        dgvMusteriler.Columns("il").Width = 80
        dgvMusteriler.Columns("bakiye").DefaultCellStyle.Format = "N2"
        dgvMusteriler.Columns("krediLimiti").DefaultCellStyle.Format = "N2"
        dgvMusteriler.Columns("bakiye").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvMusteriler.Columns("gecikmeGun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvMusteriler.Columns("krediLimiti").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvMusteriler.Columns("riskSeviye").Width = 70

        pnlAlt.Panel1.Controls.Add(dgvMusteriler)

        ' Ozet paneli
        Dim pnlOzetContainer As New Panel()
        pnlOzetContainer.Dock = DockStyle.Fill

        rtbOzet = New RichTextBox()
        rtbOzet.Dock = DockStyle.Top
        rtbOzet.Height = 80
        rtbOzet.ReadOnly = True
        rtbOzet.BackColor = Color.FromArgb(245, 245, 250)
        rtbOzet.Font = New Font("Segoe UI", 10)
        rtbOzet.BorderStyle = BorderStyle.None

        rtbAiAnaliz = New RichTextBox()
        rtbAiAnaliz.Dock = DockStyle.Fill
        rtbAiAnaliz.ReadOnly = True
        rtbAiAnaliz.BackColor = Color.FromArgb(250, 245, 255)
        rtbAiAnaliz.Font = New Font("Segoe UI", 9)
        rtbAiAnaliz.BorderStyle = BorderStyle.FixedSingle

        pnlOzetContainer.Controls.Add(rtbAiAnaliz)
        pnlOzetContainer.Controls.Add(rtbOzet)
        pnlAlt.Panel2.Controls.Add(pnlOzetContainer)

        Me.Controls.Add(pnlAlt)

        ' Status bar
        statusStrip = New StatusStrip()
        lblStatus = New ToolStripStatusLabel("Hazir")
        statusStrip.Items.Add(lblStatus)
        Me.Controls.Add(statusStrip)
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        VeriYukle()
    End Sub

    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        VeriYukle()
    End Sub

    Private Sub btnAiAnaliz_Click(sender As Object, e As EventArgs) Handles btnAiAnaliz.Click
        VeriYukle()
    End Sub

    Private Sub VeriYukle()
        Try
            Me.Cursor = Cursors.WaitCursor
            lblStatus.Text = "Veri yukleniyor..."
            Application.DoEvents()

            Dim wc As New WebClient()
            wc.Encoding = System.Text.Encoding.UTF8
            wc.Headers.Add("X-Api-Key", API_KEY)

            Dim result As String = wc.DownloadString(API_URL & "/api/ai/tahsilat-plani?temsilciId=0")

            ' Parse JSON
            dgvMusteriler.Rows.Clear()

            Dim ozet As String = ParseField(result, "ozet")
            Dim aiOzet As String = ParseField(result, "aiOzet")
            Dim toplamBakiye As String = ParseField(result, "toplamBakiye")
            Dim musteriSayisi As String = ParseField(result, "musteriSayisi")

            rtbOzet.Text = ozet.Replace("\n", vbCrLf)
            If aiOzet <> "" Then
                rtbAiAnaliz.Text = "AI ANALIZI:" & vbCrLf & aiOzet.Replace("\n", vbCrLf)
            Else
                rtbAiAnaliz.Text = "AI analizi aktif degil. API anahtarini AI Ayarlarindan tanimlayin."
            End If

            lblToplamBakiye.Text = "Toplam Bakiye: " & toplamBakiye & " TL"
            lblMusteriSayisi.Text = "Musteri Sayisi: " & musteriSayisi

            ' Parse liste array
            Dim listeStart As Integer = result.IndexOf("""liste"":[")
            If listeStart >= 0 Then
                Dim arrStart As Integer = result.IndexOf("[", listeStart)
                Dim arrEnd As Integer = FindMatchingBracket(result, arrStart)
                If arrEnd > arrStart Then
                    Dim listeJson As String = result.Substring(arrStart + 1, arrEnd - arrStart - 1)
                    ParseAndFillGrid(listeJson)
                End If
            End If

            ' Color rows by risk
            For Each row As DataGridViewRow In dgvMusteriler.Rows
                If row.Cells("riskSeviye").Value IsNot Nothing Then
                    Dim seviye As String = row.Cells("riskSeviye").Value.ToString()
                    If seviye = "kritik" Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230)
                    ElseIf seviye = "dikkat" Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220)
                    End If
                End If
            Next

            lblStatus.Text = "Yuklendi - " & dgvMusteriler.Rows.Count & " musteri"
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            lblStatus.Text = "Hata: " & ex.Message
            MessageBox.Show("Veri yuklenemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ParseAndFillGrid(listeJson As String)
        ' Simple JSON array parser for objects
        Dim pos As Integer = 0
        While pos < listeJson.Length
            Dim objStart As Integer = listeJson.IndexOf("{", pos)
            If objStart < 0 Then Exit While
            Dim objEnd As Integer = FindMatchingBrace(listeJson, objStart)
            If objEnd <= objStart Then Exit While

            Dim obj As String = listeJson.Substring(objStart, objEnd - objStart + 1)
            Dim oncelik As String = ParseField(obj, "oncelik")
            Dim firmaAd As String = ParseField(obj, "firmaAd")
            Dim il As String = ParseField(obj, "il")
            Dim bakiye As String = ParseField(obj, "bakiye")
            Dim gecikmeGun As String = ParseField(obj, "gecikmeGun")
            Dim krediLimiti As String = ParseField(obj, "krediLimiti")
            Dim riskSeviye As String = ParseField(obj, "riskSeviye")

            dgvMusteriler.Rows.Add(oncelik, firmaAd, il, bakiye, gecikmeGun, krediLimiti, riskSeviye)
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
