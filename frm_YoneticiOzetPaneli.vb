' ============================================================================
' YONETICI OZET PANELI
' ============================================================================
' Gunluk/Haftalik satis, tahsilat, risk, siparis ozetini gosterir
' API: GET /api/ai/gun-sonu-ozet, GET /api/ai/tahsilat-plani
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net

Public Class frm_YoneticiOzetPaneli
    Inherits Form

    ' === Ust Kartlar ===
    Private pnlKartlar As FlowLayoutPanel
    Private pnlGunlukSatis As Panel
    Private pnlGunlukTahsilat As Panel
    Private pnlFisSayisi As Panel
    Private pnlKritikMusteri As Panel

    ' === Risk Dagitim ===
    Private grpRiskDagilim As GroupBox
    Private pnlRiskGuvenli As Panel
    Private pnlRiskDikkat As Panel
    Private pnlRiskKritik As Panel
    Private lblGuvenliSayi As Label
    Private lblDikkatSayi As Label
    Private lblKritikSayi As Label
    Private lblGuvenliYuzde As Label
    Private lblDikkatYuzde As Label
    Private lblKritikYuzde As Label

    ' === Tahsilat Listesi ===
    Private grpTahsilat As GroupBox
    Private dgvOncelikli As DataGridView

    ' === AI Ozet ===
    Private grpAiOzet As GroupBox
    Private rtbAiOzet As RichTextBox

    ' === Alt Panel ===
    Private pnlUst As Panel
    Private lblBaslik As Label
    Private lblTarih As Label
    Private WithEvents btnYenile As Button

    Private statusStrip As StatusStrip
    Private lblStatus As ToolStripStatusLabel

    Private Const API_URL As String = "https://desktop.barkodyazilimevi.com"
    Private Const API_KEY As String = "BSmart2024Desktop!@#SecureKey"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "Yonetici Ozet Paneli"
        Me.Size = New Size(1200, 850)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.BackColor = Color.FromArgb(240, 242, 245)

        ' === UST HEADER ===
        pnlUst = New Panel()
        pnlUst.Dock = DockStyle.Top
        pnlUst.Height = 65
        pnlUst.BackColor = Color.FromArgb(30, 39, 46)
        pnlUst.Padding = New Padding(20, 12, 20, 12)

        lblBaslik = New Label()
        lblBaslik.Text = "Yonetici Ozet Paneli"
        lblBaslik.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblBaslik.ForeColor = Color.White
        lblBaslik.AutoSize = True
        lblBaslik.Location = New Point(20, 15)
        pnlUst.Controls.Add(lblBaslik)

        lblTarih = New Label()
        lblTarih.Text = DateTime.Now.ToString("dd MMMM yyyy, dddd")
        lblTarih.Font = New Font("Segoe UI", 10)
        lblTarih.ForeColor = Color.FromArgb(200, 200, 210)
        lblTarih.AutoSize = True
        lblTarih.Location = New Point(420, 22)
        pnlUst.Controls.Add(lblTarih)

        btnYenile = New Button()
        btnYenile.Text = "Yenile"
        btnYenile.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnYenile.Size = New Size(100, 35)
        btnYenile.Location = New Point(1060, 15)
        btnYenile.BackColor = Color.FromArgb(52, 152, 219)
        btnYenile.ForeColor = Color.White
        btnYenile.FlatStyle = FlatStyle.Flat
        btnYenile.FlatAppearance.BorderSize = 0
        pnlUst.Controls.Add(btnYenile)

        Me.Controls.Add(pnlUst)

        ' === KPI KARTLARI ===
        pnlKartlar = New FlowLayoutPanel()
        pnlKartlar.Dock = DockStyle.Top
        pnlKartlar.Height = 115
        pnlKartlar.Padding = New Padding(15, 12, 15, 5)
        pnlKartlar.BackColor = Color.FromArgb(240, 242, 245)

        pnlGunlukSatis = KpiKartOlustur("Gunluk Satis", "-", Color.FromArgb(46, 204, 113), "TL")
        pnlGunlukTahsilat = KpiKartOlustur("Gunluk Tahsilat", "-", Color.FromArgb(52, 152, 219), "TL")
        pnlFisSayisi = KpiKartOlustur("Fis Sayisi", "-", Color.FromArgb(155, 89, 182), "adet")
        pnlKritikMusteri = KpiKartOlustur("Kritik Musteri", "-", Color.FromArgb(231, 76, 60), "adet")

        pnlKartlar.Controls.Add(pnlGunlukSatis)
        pnlKartlar.Controls.Add(pnlGunlukTahsilat)
        pnlKartlar.Controls.Add(pnlFisSayisi)
        pnlKartlar.Controls.Add(pnlKritikMusteri)

        Me.Controls.Add(pnlKartlar)

        ' === ORTA BOLUM (Risk + Tahsilat) ===
        Dim pnlOrta As New SplitContainer()
        pnlOrta.Dock = DockStyle.Top
        pnlOrta.Height = 280
        pnlOrta.SplitterDistance = 350

        ' Risk Dagilimi
        grpRiskDagilim = New GroupBox()
        grpRiskDagilim.Text = " Risk Dagilimi "
        grpRiskDagilim.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpRiskDagilim.ForeColor = Color.FromArgb(44, 62, 80)
        grpRiskDagilim.Dock = DockStyle.Fill
        grpRiskDagilim.Padding = New Padding(15)

        ' Guvenli bar
        Dim yBase As Integer = 35

        Dim lblG As New Label()
        lblG.Text = "Guvenli (70+)"
        lblG.Font = New Font("Segoe UI", 9)
        lblG.ForeColor = Color.FromArgb(39, 174, 96)
        lblG.Location = New Point(15, yBase)
        lblG.AutoSize = True
        grpRiskDagilim.Controls.Add(lblG)

        pnlRiskGuvenli = New Panel()
        pnlRiskGuvenli.Location = New Point(15, yBase + 22)
        pnlRiskGuvenli.Size = New Size(200, 25)
        pnlRiskGuvenli.BackColor = Color.FromArgb(39, 174, 96)
        grpRiskDagilim.Controls.Add(pnlRiskGuvenli)

        lblGuvenliSayi = New Label()
        lblGuvenliSayi.Text = "0"
        lblGuvenliSayi.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblGuvenliSayi.ForeColor = Color.White
        lblGuvenliSayi.Location = New Point(5, 3)
        lblGuvenliSayi.AutoSize = True
        pnlRiskGuvenli.Controls.Add(lblGuvenliSayi)

        lblGuvenliYuzde = New Label()
        lblGuvenliYuzde.Text = ""
        lblGuvenliYuzde.Font = New Font("Segoe UI", 8)
        lblGuvenliYuzde.ForeColor = Color.Gray
        lblGuvenliYuzde.Location = New Point(225, yBase + 25)
        lblGuvenliYuzde.AutoSize = True
        grpRiskDagilim.Controls.Add(lblGuvenliYuzde)

        yBase += 60

        Dim lblD As New Label()
        lblD.Text = "Dikkat (40-69)"
        lblD.Font = New Font("Segoe UI", 9)
        lblD.ForeColor = Color.FromArgb(243, 156, 18)
        lblD.Location = New Point(15, yBase)
        lblD.AutoSize = True
        grpRiskDagilim.Controls.Add(lblD)

        pnlRiskDikkat = New Panel()
        pnlRiskDikkat.Location = New Point(15, yBase + 22)
        pnlRiskDikkat.Size = New Size(100, 25)
        pnlRiskDikkat.BackColor = Color.FromArgb(243, 156, 18)
        grpRiskDagilim.Controls.Add(pnlRiskDikkat)

        lblDikkatSayi = New Label()
        lblDikkatSayi.Text = "0"
        lblDikkatSayi.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblDikkatSayi.ForeColor = Color.White
        lblDikkatSayi.Location = New Point(5, 3)
        lblDikkatSayi.AutoSize = True
        pnlRiskDikkat.Controls.Add(lblDikkatSayi)

        lblDikkatYuzde = New Label()
        lblDikkatYuzde.Text = ""
        lblDikkatYuzde.Font = New Font("Segoe UI", 8)
        lblDikkatYuzde.ForeColor = Color.Gray
        lblDikkatYuzde.Location = New Point(225, yBase + 25)
        lblDikkatYuzde.AutoSize = True
        grpRiskDagilim.Controls.Add(lblDikkatYuzde)

        yBase += 60

        Dim lblK As New Label()
        lblK.Text = "Kritik (0-39)"
        lblK.Font = New Font("Segoe UI", 9)
        lblK.ForeColor = Color.FromArgb(231, 76, 60)
        lblK.Location = New Point(15, yBase)
        lblK.AutoSize = True
        grpRiskDagilim.Controls.Add(lblK)

        pnlRiskKritik = New Panel()
        pnlRiskKritik.Location = New Point(15, yBase + 22)
        pnlRiskKritik.Size = New Size(50, 25)
        pnlRiskKritik.BackColor = Color.FromArgb(231, 76, 60)
        grpRiskDagilim.Controls.Add(pnlRiskKritik)

        lblKritikSayi = New Label()
        lblKritikSayi.Text = "0"
        lblKritikSayi.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblKritikSayi.ForeColor = Color.White
        lblKritikSayi.Location = New Point(5, 3)
        lblKritikSayi.AutoSize = True
        pnlRiskKritik.Controls.Add(lblKritikSayi)

        lblKritikYuzde = New Label()
        lblKritikYuzde.Text = ""
        lblKritikYuzde.Font = New Font("Segoe UI", 8)
        lblKritikYuzde.ForeColor = Color.Gray
        lblKritikYuzde.Location = New Point(225, yBase + 25)
        lblKritikYuzde.AutoSize = True
        grpRiskDagilim.Controls.Add(lblKritikYuzde)

        pnlOrta.Panel1.Controls.Add(grpRiskDagilim)

        ' Oncelikli Tahsilat Grid
        grpTahsilat = New GroupBox()
        grpTahsilat.Text = " Oncelikli Tahsilat (Top 10) "
        grpTahsilat.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpTahsilat.ForeColor = Color.FromArgb(44, 62, 80)
        grpTahsilat.Dock = DockStyle.Fill
        grpTahsilat.Padding = New Padding(10)

        dgvOncelikli = New DataGridView()
        dgvOncelikli.Dock = DockStyle.Fill
        dgvOncelikli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOncelikli.ReadOnly = True
        dgvOncelikli.AllowUserToAddRows = False
        dgvOncelikli.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOncelikli.BackgroundColor = Color.White
        dgvOncelikli.Font = New Font("Segoe UI", 8)
        dgvOncelikli.RowHeadersVisible = False
        dgvOncelikli.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94)
        dgvOncelikli.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvOncelikli.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgvOncelikli.EnableHeadersVisualStyles = False
        dgvOncelikli.ColumnHeadersHeight = 28

        dgvOncelikli.Columns.Add("no", "#")
        dgvOncelikli.Columns.Add("firma", "Firma")
        dgvOncelikli.Columns.Add("bakiye", "Bakiye")
        dgvOncelikli.Columns.Add("gecikme", "Gecikme")
        dgvOncelikli.Columns.Add("risk", "Risk")

        dgvOncelikli.Columns("no").Width = 30
        dgvOncelikli.Columns("firma").Width = 200
        dgvOncelikli.Columns("bakiye").DefaultCellStyle.Format = "N2"
        dgvOncelikli.Columns("bakiye").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvOncelikli.Columns("gecikme").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOncelikli.Columns("risk").Width = 60

        grpTahsilat.Controls.Add(dgvOncelikli)
        pnlOrta.Panel2.Controls.Add(grpTahsilat)

        Me.Controls.Add(pnlOrta)

        ' === AI OZET ===
        grpAiOzet = New GroupBox()
        grpAiOzet.Text = " AI Gunluk Ozet "
        grpAiOzet.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpAiOzet.ForeColor = Color.FromArgb(142, 68, 173)
        grpAiOzet.Dock = DockStyle.Fill
        grpAiOzet.Padding = New Padding(10)

        rtbAiOzet = New RichTextBox()
        rtbAiOzet.Dock = DockStyle.Fill
        rtbAiOzet.ReadOnly = True
        rtbAiOzet.BackColor = Color.FromArgb(250, 248, 255)
        rtbAiOzet.Font = New Font("Segoe UI", 10)
        rtbAiOzet.BorderStyle = BorderStyle.None
        grpAiOzet.Controls.Add(rtbAiOzet)

        Me.Controls.Add(grpAiOzet)

        ' Status
        statusStrip = New StatusStrip()
        lblStatus = New ToolStripStatusLabel("Hazir")
        statusStrip.Items.Add(lblStatus)
        Me.Controls.Add(statusStrip)
    End Sub

    Private Function KpiKartOlustur(baslik As String, deger As String, renk As Color, birim As String) As Panel
        Dim pnl As New Panel()
        pnl.Size = New Size(265, 85)
        pnl.BackColor = Color.White
        pnl.Margin = New Padding(8, 5, 8, 5)

        Dim pnlRenk As New Panel()
        pnlRenk.Dock = DockStyle.Left
        pnlRenk.Width = 6
        pnlRenk.BackColor = renk
        pnl.Controls.Add(pnlRenk)

        Dim lblB As New Label()
        lblB.Text = baslik
        lblB.Font = New Font("Segoe UI", 8)
        lblB.ForeColor = Color.Gray
        lblB.Location = New Point(18, 10)
        lblB.AutoSize = True
        pnl.Controls.Add(lblB)

        Dim lblD As New Label()
        lblD.Text = deger
        lblD.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblD.ForeColor = Color.FromArgb(30, 39, 46)
        lblD.Location = New Point(18, 32)
        lblD.AutoSize = True
        lblD.Name = "lblDeger"
        pnl.Controls.Add(lblD)

        Dim lblBirim As New Label()
        lblBirim.Text = birim
        lblBirim.Font = New Font("Segoe UI", 8)
        lblBirim.ForeColor = Color.Gray
        lblBirim.Location = New Point(18, 62)
        lblBirim.AutoSize = True
        lblBirim.Name = "lblBirim"
        pnl.Controls.Add(lblBirim)

        Return pnl
    End Function

    Private Sub KpiGuncelle(pnl As Panel, deger As String)
        For Each ctrl As Control In pnl.Controls
            If ctrl.Name = "lblDeger" Then
                CType(ctrl, Label).Text = deger
                Exit For
            End If
        Next
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        TumVerileriYukle()
    End Sub

    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        TumVerileriYukle()
    End Sub

    Private Sub TumVerileriYukle()
        Me.Cursor = Cursors.WaitCursor
        lblStatus.Text = "Veriler yukleniyor..."
        Application.DoEvents()

        GunSonuOzetYukle()
        TahsilatPlaniYukle()

        lblStatus.Text = "Tum veriler yuklendi - " & DateTime.Now.ToString("HH:mm:ss")
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GunSonuOzetYukle()
        Try
            Dim tarih As String = DateTime.Today.ToString("yyyy-MM-dd")
            Dim wc As New WebClient()
            wc.Encoding = System.Text.Encoding.UTF8
            wc.Headers.Add("X-Api-Key", API_KEY)

            Dim result As String = wc.DownloadString(API_URL & "/api/ai/gun-sonu-ozet?tarih=" & tarih)

            Dim toplamSatis As String = ParseField(result, "toplamSatis")
            Dim toplamTahsilat As String = ParseField(result, "toplamTahsilat")
            Dim fisSayisi As String = ParseField(result, "fisSayisi")
            Dim kuralOzet As String = ParseField(result, "kuralOzet")
            Dim aiOzet As String = ParseField(result, "aiOzet")

            Dim satisTutar As Decimal = 0
            Decimal.TryParse(toplamSatis, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, satisTutar)
            Dim tahsilatTutar As Decimal = 0
            Decimal.TryParse(toplamTahsilat, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, tahsilatTutar)

            KpiGuncelle(pnlGunlukSatis, satisTutar.ToString("N0"))
            KpiGuncelle(pnlGunlukTahsilat, tahsilatTutar.ToString("N0"))
            KpiGuncelle(pnlFisSayisi, fisSayisi)

            Dim ozetMetin As String = kuralOzet.Replace("\n", vbCrLf)
            If aiOzet <> "" Then
                ozetMetin &= vbCrLf & vbCrLf & "--- AI ANALIZ ---" & vbCrLf & aiOzet.Replace("\n", vbCrLf)
            End If
            rtbAiOzet.Text = ozetMetin

        Catch ex As Exception
            rtbAiOzet.Text = "Gun sonu ozet yuklenemedi: " & ex.Message
        End Try
    End Sub

    Private Sub TahsilatPlaniYukle()
        Try
            Dim wc As New WebClient()
            wc.Encoding = System.Text.Encoding.UTF8
            wc.Headers.Add("X-Api-Key", API_KEY)

            Dim result As String = wc.DownloadString(API_URL & "/api/ai/tahsilat-plani?temsilciId=0")

            dgvOncelikli.Rows.Clear()

            ' Parse liste
            Dim listeStart As Integer = result.IndexOf("""liste"":[")
            If listeStart >= 0 Then
                Dim arrStart As Integer = result.IndexOf("[", listeStart)
                Dim arrEnd As Integer = FindMatchingBracket(result, arrStart)
                If arrEnd > arrStart Then
                    Dim listeJson As String = result.Substring(arrStart + 1, arrEnd - arrStart - 1)
                    Dim pos As Integer = 0
                    Dim guvenli As Integer = 0
                    Dim dikkat As Integer = 0
                    Dim kritik As Integer = 0
                    Dim sira As Integer = 0

                    While pos < listeJson.Length
                        Dim objStart As Integer = listeJson.IndexOf("{", pos)
                        If objStart < 0 Then Exit While
                        Dim objEnd As Integer = FindMatchingBrace(listeJson, objStart)
                        If objEnd <= objStart Then Exit While

                        Dim obj As String = listeJson.Substring(objStart, objEnd - objStart + 1)
                        Dim firmaAd As String = ParseField(obj, "firmaAd")
                        Dim bakiye As String = ParseField(obj, "bakiye")
                        Dim gecikme As String = ParseField(obj, "gecikmeGun")
                        Dim riskSeviye As String = ParseField(obj, "riskSeviye")

                        ' Risk sayilari
                        If riskSeviye = "guvenli" Then guvenli += 1
                        If riskSeviye = "dikkat" Then dikkat += 1
                        If riskSeviye = "kritik" Then kritik += 1

                        sira += 1
                        If sira <= 10 Then
                            Dim rowIdx As Integer = dgvOncelikli.Rows.Add(sira, firmaAd, bakiye, gecikme & " gun", riskSeviye)
                            If riskSeviye = "kritik" Then
                                dgvOncelikli.Rows(rowIdx).DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230)
                            ElseIf riskSeviye = "dikkat" Then
                                dgvOncelikli.Rows(rowIdx).DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 225)
                            End If
                        End If

                        pos = objEnd + 1
                    End While

                    KpiGuncelle(pnlKritikMusteri, kritik.ToString())

                    ' Risk dagilim bar grafigi guncelle
                    Dim toplam As Integer = guvenli + dikkat + kritik
                    If toplam > 0 Then
                        Dim maxWidth As Integer = 290
                        pnlRiskGuvenli.Width = Math.Max(30, CInt(guvenli / toplam * maxWidth))
                        pnlRiskDikkat.Width = Math.Max(30, CInt(dikkat / toplam * maxWidth))
                        pnlRiskKritik.Width = Math.Max(30, CInt(kritik / toplam * maxWidth))
                        If guvenli = 0 Then pnlRiskGuvenli.Width = 30
                        If dikkat = 0 Then pnlRiskDikkat.Width = 30
                        If kritik = 0 Then pnlRiskKritik.Width = 30

                        lblGuvenliSayi.Text = guvenli.ToString()
                        lblDikkatSayi.Text = dikkat.ToString()
                        lblKritikSayi.Text = kritik.ToString()

                        lblGuvenliYuzde.Text = Math.Round(guvenli * 100.0 / toplam, 0) & "%"
                        lblDikkatYuzde.Text = Math.Round(dikkat * 100.0 / toplam, 0) & "%"
                        lblKritikYuzde.Text = Math.Round(kritik * 100.0 / toplam, 0) & "%"
                    End If
                End If
            End If

        Catch ex As Exception
            lblStatus.Text = "Tahsilat yuklenemedi: " & ex.Message
        End Try
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
        Dim inStr As Boolean = False
        For i As Integer = start To json.Length - 1
            If json(i) = "\"c AndAlso Not inStr Then
                i += 1
                Continue For
            End If
            If json(i) = Chr(34) Then inStr = Not inStr
            If Not inStr Then
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
