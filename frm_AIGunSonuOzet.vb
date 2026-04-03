' ============================================================================
' GUN SONU OZET FORMU
' ============================================================================
' Gunluk satis/tahsilat ozetini gosterir, AI analizi sunar
' API: GET /api/ai/gun-sonu-ozet
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net

Public Class frm_AIGunSonuOzet
    Inherits Form

    Private pnlUst As Panel
    Private lblBaslik As Label
    Private dtpTarih As DateTimePicker
    Private WithEvents btnSorgula As Button

    Private pnlKartlar As FlowLayoutPanel
    Private pnlSatisTutar As Panel
    Private pnlTahsilatTutar As Panel
    Private pnlFisSayisi As Panel
    Private pnlEnBuyuk As Panel

    Private rtbKuralOzet As RichTextBox
    Private rtbAiOzet As RichTextBox

    Private statusStrip As StatusStrip
    Private lblStatus As ToolStripStatusLabel

    Private Const API_URL As String = "https://desktop.barkodyazilimevi.com"
    Private Const API_KEY As String = "BSmart2024Desktop!@#SecureKey"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "Gun Sonu Ozet"
        Me.Size = New Size(900, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.BackColor = Color.FromArgb(245, 245, 250)

        ' Ust Panel
        pnlUst = New Panel()
        pnlUst.Dock = DockStyle.Top
        pnlUst.Height = 70
        pnlUst.BackColor = Color.FromArgb(44, 62, 80)
        pnlUst.Padding = New Padding(15, 10, 15, 10)

        lblBaslik = New Label()
        lblBaslik.Text = "Gun Sonu Ozet"
        lblBaslik.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblBaslik.ForeColor = Color.White
        lblBaslik.AutoSize = True
        lblBaslik.Location = New Point(15, 18)
        pnlUst.Controls.Add(lblBaslik)

        dtpTarih = New DateTimePicker()
        dtpTarih.Format = DateTimePickerFormat.Short
        dtpTarih.Value = DateTime.Today
        dtpTarih.Location = New Point(600, 20)
        dtpTarih.Size = New Size(130, 30)
        dtpTarih.Font = New Font("Segoe UI", 10)
        pnlUst.Controls.Add(dtpTarih)

        btnSorgula = New Button()
        btnSorgula.Text = "Sorgula"
        btnSorgula.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSorgula.Size = New Size(100, 30)
        btnSorgula.Location = New Point(745, 20)
        btnSorgula.BackColor = Color.FromArgb(52, 152, 219)
        btnSorgula.ForeColor = Color.White
        btnSorgula.FlatStyle = FlatStyle.Flat
        pnlUst.Controls.Add(btnSorgula)

        Me.Controls.Add(pnlUst)

        ' Kart paneli
        pnlKartlar = New FlowLayoutPanel()
        pnlKartlar.Dock = DockStyle.Top
        pnlKartlar.Height = 110
        pnlKartlar.Padding = New Padding(15, 15, 15, 5)
        pnlKartlar.BackColor = Color.FromArgb(245, 245, 250)

        pnlSatisTutar = KartOlustur("Toplam Satis", "-", Color.FromArgb(46, 204, 113))
        pnlTahsilatTutar = KartOlustur("Toplam Tahsilat", "-", Color.FromArgb(52, 152, 219))
        pnlFisSayisi = KartOlustur("Fis Sayisi", "-", Color.FromArgb(155, 89, 182))
        pnlEnBuyuk = KartOlustur("En Buyuk Satis", "-", Color.FromArgb(243, 156, 18))

        pnlKartlar.Controls.Add(pnlSatisTutar)
        pnlKartlar.Controls.Add(pnlTahsilatTutar)
        pnlKartlar.Controls.Add(pnlFisSayisi)
        pnlKartlar.Controls.Add(pnlEnBuyuk)
        Me.Controls.Add(pnlKartlar)

        ' Kural ozet
        rtbKuralOzet = New RichTextBox()
        rtbKuralOzet.Dock = DockStyle.Top
        rtbKuralOzet.Height = 120
        rtbKuralOzet.ReadOnly = True
        rtbKuralOzet.BackColor = Color.White
        rtbKuralOzet.Font = New Font("Segoe UI", 10)
        rtbKuralOzet.BorderStyle = BorderStyle.None
        rtbKuralOzet.Padding = New Padding(10)
        Me.Controls.Add(rtbKuralOzet)

        ' AI ozet
        Dim lblAi As New Label()
        lblAi.Text = "  AI Analizi"
        lblAi.Dock = DockStyle.Top
        lblAi.Height = 25
        lblAi.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblAi.ForeColor = Color.FromArgb(142, 68, 173)
        lblAi.BackColor = Color.FromArgb(245, 240, 255)
        Me.Controls.Add(lblAi)

        rtbAiOzet = New RichTextBox()
        rtbAiOzet.Dock = DockStyle.Fill
        rtbAiOzet.ReadOnly = True
        rtbAiOzet.BackColor = Color.FromArgb(250, 248, 255)
        rtbAiOzet.Font = New Font("Segoe UI", 10)
        rtbAiOzet.BorderStyle = BorderStyle.None
        Me.Controls.Add(rtbAiOzet)

        ' Status bar
        statusStrip = New StatusStrip()
        lblStatus = New ToolStripStatusLabel("Hazir")
        statusStrip.Items.Add(lblStatus)
        Me.Controls.Add(statusStrip)
    End Sub

    Private Function KartOlustur(baslik As String, deger As String, renk As Color) As Panel
        Dim pnl As New Panel()
        pnl.Size = New Size(195, 80)
        pnl.BackColor = Color.White
        pnl.Margin = New Padding(5)

        Dim pnlRenk As New Panel()
        pnlRenk.Dock = DockStyle.Left
        pnlRenk.Width = 5
        pnlRenk.BackColor = renk
        pnl.Controls.Add(pnlRenk)

        Dim lblB As New Label()
        lblB.Text = baslik
        lblB.Font = New Font("Segoe UI", 8)
        lblB.ForeColor = Color.Gray
        lblB.Location = New Point(15, 10)
        lblB.AutoSize = True
        pnl.Controls.Add(lblB)

        Dim lblD As New Label()
        lblD.Text = deger
        lblD.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblD.ForeColor = Color.FromArgb(44, 62, 80)
        lblD.Location = New Point(15, 35)
        lblD.AutoSize = True
        lblD.Tag = baslik
        pnl.Controls.Add(lblD)

        Return pnl
    End Function

    Private Sub KartGuncelle(pnl As Panel, deger As String)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Label AndAlso CType(ctrl, Label).Font.Bold Then
                CType(ctrl, Label).Text = deger
                Exit For
            End If
        Next
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        VeriYukle()
    End Sub

    Private Sub btnSorgula_Click(sender As Object, e As EventArgs) Handles btnSorgula.Click
        VeriYukle()
    End Sub

    Private Sub VeriYukle()
        Try
            Me.Cursor = Cursors.WaitCursor
            lblStatus.Text = "Veri yukleniyor..."
            Application.DoEvents()

            Dim tarih As String = dtpTarih.Value.ToString("yyyy-MM-dd")
            Dim wc As New WebClient()
            wc.Encoding = System.Text.Encoding.UTF8
            wc.Headers.Add("X-Api-Key", API_KEY)

            Dim result As String = wc.DownloadString(API_URL & "/api/ai/gun-sonu-ozet?tarih=" & tarih)

            Dim toplamSatis As String = ParseField(result, "toplamSatis")
            Dim toplamTahsilat As String = ParseField(result, "toplamTahsilat")
            Dim fisSayisi As String = ParseField(result, "fisSayisi")
            Dim enBuyukSatis As String = ParseField(result, "enBuyukSatis")
            Dim kuralOzet As String = ParseField(result, "kuralOzet")
            Dim aiOzet As String = ParseField(result, "aiOzet")

            ' Format numbers
            Dim satisTutar As Decimal = 0
            Decimal.TryParse(toplamSatis, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, satisTutar)
            Dim tahsilatTutar As Decimal = 0
            Decimal.TryParse(toplamTahsilat, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, tahsilatTutar)
            Dim enBuyuk As Decimal = 0
            Decimal.TryParse(enBuyukSatis, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, enBuyuk)

            KartGuncelle(pnlSatisTutar, satisTutar.ToString("N2") & " TL")
            KartGuncelle(pnlTahsilatTutar, tahsilatTutar.ToString("N2") & " TL")
            KartGuncelle(pnlFisSayisi, fisSayisi)
            KartGuncelle(pnlEnBuyuk, enBuyuk.ToString("N2") & " TL")

            rtbKuralOzet.Text = kuralOzet.Replace("\n", vbCrLf)

            If aiOzet <> "" Then
                rtbAiOzet.Text = aiOzet.Replace("\n", vbCrLf)
            Else
                rtbAiOzet.Text = "AI analizi aktif degil. appsettings.json dosyasinda AI:ApiKey tanimlayin."
            End If

            lblStatus.Text = "Yuklendi - Tarih: " & tarih
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            lblStatus.Text = "Hata: " & ex.Message
            MessageBox.Show("Veri yuklenemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

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
