' ============================================================================
' AI AYARLARI FORMU
' ============================================================================
' Admin tarafında AI parametrelerini ayarlamak için form
' ============================================================================

Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing

Public Class frm_AIAyarlari
    Inherits Form
    
    Private paramService As ParameterService
    
    ' Form controls
    Private WithEvents chkAIKullan As CheckBox
    Private WithEvents chkBaslikOlustur As CheckBox
    Private WithEvents chkAciklamaOlustur As CheckBox
    Private WithEvents chkTalimatOlustur As CheckBox
    Private WithEvents chkGorselBul As CheckBox
    Private WithEvents chkGorselDogrula As CheckBox
    Private WithEvents chkKategoriOner As CheckBox
    Private WithEvents chkFiyatOptimize As CheckBox
    
    Private WithEvents txtEmergentKey As TextBox
    Private WithEvents txtOpenAIKey As TextBox
    Private WithEvents txtGoogleApiKey As TextBox
    Private WithEvents txtGoogleEngineId As TextBox
    Private WithEvents txtGunlukLimit As TextBox
    Private WithEvents txtAylikBudget As TextBox
    
    Private WithEvents btnKaydet As Button
    Private WithEvents btnTest As Button
    Private WithEvents lnkGoogleRehber As LinkLabel
    
    Private lblMaliyetUrun As Label
    Private lblMaliyet1000 As Label
    Private lblBudgetUyari As Label
    
    Public Sub New()
        InitializeComponent()
        paramService = New ParameterService()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "AI Ayarları"
        Me.Size = New Size(800, 720)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.AutoScroll = True
        
        Dim yPos As Integer = 20
        
        ' Başlık
        Dim lblBaslik As New Label With {
            .Text = "🤖 AI SİSTEM AYARLARI",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .Location = New Point(20, yPos),
            .Size = New Size(760, 40),
            .ForeColor = Color.DarkBlue
        }
        Me.Controls.Add(lblBaslik)
        yPos += 50
        
        ' ===== GENEL AYARLAR =====
        Dim grpGenel As New GroupBox With {
            .Text = "Genel Ayarlar",
            .Location = New Point(20, yPos),
            .Size = New Size(760, 100)
        }
        
        chkAIKullan = New CheckBox With {
            .Text = "✅ AI Sistemi Aktif (Ana anahtar)",
            .Location = New Point(20, 30),
            .Size = New Size(300, 30),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }
        grpGenel.Controls.Add(chkAIKullan)
        
        Dim lblAciklama As New Label With {
            .Text = "Bu seçenek kapalıysa hiçbir AI özelliği kullanılmaz",
            .Location = New Point(20, 60),
            .Size = New Size(400, 20),
            .ForeColor = Color.Gray
        }
        grpGenel.Controls.Add(lblAciklama)
        
        Me.Controls.Add(grpGenel)
        yPos += 110
        
        ' ===== ÖZELLİKLER =====
        Dim grpOzellikler As New GroupBox With {
            .Text = "AI Özellikleri (Hangileri Kullanılsın?)",
            .Location = New Point(20, yPos),
            .Size = New Size(760, 180)
        }
        
        chkBaslikOlustur = New CheckBox With {
            .Text = "📝 SEO Başlığı Oluştur (0.02 TL/ürün)",
            .Location = New Point(20, 30),
            .Size = New Size(350, 25)
        }
        grpOzellikler.Controls.Add(chkBaslikOlustur)
        
        chkAciklamaOlustur = New CheckBox With {
            .Text = "📄 Detaylı Açıklama Oluştur (0.12 TL/ürün)",
            .Location = New Point(20, 60),
            .Size = New Size(350, 25)
        }
        grpOzellikler.Controls.Add(chkAciklamaOlustur)
        
        chkTalimatOlustur = New CheckBox With {
            .Text = "📋 Kullanım Talimatları Oluştur (0.10 TL/ürün)",
            .Location = New Point(20, 90),
            .Size = New Size(350, 25)
        }
        grpOzellikler.Controls.Add(chkTalimatOlustur)
        
        chkGorselBul = New CheckBox With {
            .Text = "🖼️ Ürün Görseli Bul (0.175 TL/ürün)",
            .Location = New Point(20, 120),
            .Size = New Size(350, 25)
        }
        grpOzellikler.Controls.Add(chkGorselBul)
        
        chkGorselDogrula = New CheckBox With {
            .Text = "✔️ Görsel Doğrulama (Vision API) (0.05 TL/ürün)",
            .Location = New Point(400, 30),
            .Size = New Size(350, 25)
        }
        grpOzellikler.Controls.Add(chkGorselDogrula)
        
        chkKategoriOner = New CheckBox With {
            .Text = "🏷️ Kategori/Etiket Önerisi (0.05 TL/ürün)",
            .Location = New Point(400, 60),
            .Size = New Size(350, 25)
        }
        grpOzellikler.Controls.Add(chkKategoriOner)
        
        chkFiyatOptimize = New CheckBox With {
            .Text = "💰 Fiyat Optimizasyonu (0.07 TL/ürün)",
            .Location = New Point(400, 90),
            .Size = New Size(350, 25)
        }
        grpOzellikler.Controls.Add(chkFiyatOptimize)
        
        Me.Controls.Add(grpOzellikler)
        yPos += 190
        
        ' ===== API ANAHTARLARI =====
        Dim grpAPI As New GroupBox With {
            .Text = "API Anahtarları",
            .Location = New Point(20, yPos),
            .Size = New Size(760, 200)
        }
        
        Dim lblEmergent As New Label With {
            .Text = "Emergent LLM Key: *",
            .Location = New Point(20, 30),
            .Size = New Size(150, 20),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        grpAPI.Controls.Add(lblEmergent)
        
        txtEmergentKey = New TextBox With {
            .Location = New Point(180, 28),
            .Size = New Size(550, 25),
            .PasswordChar = "●"c
        }
        grpAPI.Controls.Add(txtEmergentKey)
        
        Dim lblEmergentInfo As New Label With {
            .Text = "* Universal key (tüm AI özellikler)",
            .Location = New Point(180, 53),
            .Size = New Size(300, 15),
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8)
        }
        grpAPI.Controls.Add(lblEmergentInfo)
        
        Dim lblOpenAI As New Label With {
            .Text = "OpenAI API Key:",
            .Location = New Point(20, 75),
            .Size = New Size(150, 20),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        grpAPI.Controls.Add(lblOpenAI)
        
        txtOpenAIKey = New TextBox With {
            .Location = New Point(180, 73),
            .Size = New Size(550, 25),
            .PasswordChar = "●"c
        }
        grpAPI.Controls.Add(txtOpenAIKey)
        
        Dim lblOpenAIInfo As New Label With {
            .Text = "* Alternatif (Emergent yerine kullanılabilir)",
            .Location = New Point(180, 98),
            .Size = New Size(300, 15),
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8)
        }
        grpAPI.Controls.Add(lblOpenAIInfo)
        
        Dim lblGoogle As New Label With {
            .Text = "Google Search API Key:",
            .Location = New Point(20, 120),
            .Size = New Size(150, 20)
        }
        grpAPI.Controls.Add(lblGoogle)
        
        txtGoogleApiKey = New TextBox With {
            .Location = New Point(180, 118),
            .Size = New Size(550, 25)
        }
        grpAPI.Controls.Add(txtGoogleApiKey)
        
        Dim lblGoogleInfo As New Label With {
            .Text = "(Opsiyonel - sadece görsel bulma için)",
            .Location = New Point(180, 143),
            .Size = New Size(300, 15),
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8)
        }
        grpAPI.Controls.Add(lblGoogleInfo)
        
        Dim lblGoogleEngine As New Label With {
            .Text = "Google Engine ID:",
            .Location = New Point(20, 165),
            .Size = New Size(150, 20)
        }
        grpAPI.Controls.Add(lblGoogleEngine)
        
        txtGoogleEngineId = New TextBox With {
            .Location = New Point(180, 163),
            .Size = New Size(400, 25)
        }
        grpAPI.Controls.Add(txtGoogleEngineId)
        
        lnkGoogleRehber = New LinkLabel With {
            .Text = "❓ Nasıl alınır?",
            .Location = New Point(590, 165),
            .Size = New Size(140, 20),
            .LinkColor = Color.Blue
        }
        grpAPI.Controls.Add(lnkGoogleRehber)
        
        Me.Controls.Add(grpAPI)
        yPos += 220
        
        ' ===== MALİYET HESAPLAMA =====
        Dim grpMaliyet As New GroupBox With {
            .Text = "💰 Tahmini Maliyet",
            .Location = New Point(20, yPos),
            .Size = New Size(760, 100)
        }
        
        lblMaliyetUrun = New Label With {
            .Text = "Ürün Başına: 0.00 TL",
            .Location = New Point(20, 30),
            .Size = New Size(200, 25),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }
        grpMaliyet.Controls.Add(lblMaliyetUrun)
        
        lblMaliyet1000 = New Label With {
            .Text = "1000 Ürün: 0.00 TL",
            .Location = New Point(250, 30),
            .Size = New Size(200, 25)
        }
        grpMaliyet.Controls.Add(lblMaliyet1000)
        
        lblBudgetUyari = New Label With {
            .Text = "",
            .Location = New Point(20, 60),
            .Size = New Size(720, 25),
            .ForeColor = Color.Green
        }
        grpMaliyet.Controls.Add(lblBudgetUyari)
        
        Me.Controls.Add(grpMaliyet)
        yPos += 110
        
        ' ===== BUTONLAR =====
        btnKaydet = New Button With {
            .Text = "💾 Ayarları Kaydet",
            .Location = New Point(520, yPos),
            .Size = New Size(150, 40),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .BackColor = Color.Green,
            .ForeColor = Color.White
        }
        Me.Controls.Add(btnKaydet)
        
        btnTest = New Button With {
            .Text = "🧪 Test Et",
            .Location = New Point(350, yPos),
            .Size = New Size(150, 40)
        }
        Me.Controls.Add(btnTest)
    End Sub
    
    Private Sub frm_AIAyarlari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub
    
    Private Sub LoadSettings()
        Try
            paramService.LoadParameters()
            
            ' Checkbox'ları ayarla
            chkAIKullan.Checked = paramService.IsAIEnabled()
            chkBaslikOlustur.Checked = paramService.IsFeatureEnabled("bBaslikOlustur")
            chkAciklamaOlustur.Checked = paramService.IsFeatureEnabled("bAciklamaOlustur")
            chkTalimatOlustur.Checked = paramService.IsFeatureEnabled("bTalimatOlustur")
            chkGorselBul.Checked = paramService.IsFeatureEnabled("bGorselBul")
            chkGorselDogrula.Checked = paramService.IsFeatureEnabled("bGorselDogrula")
            chkKategoriOner.Checked = paramService.IsFeatureEnabled("bKategoriOner")
            chkFiyatOptimize.Checked = paramService.IsFeatureEnabled("bFiyatOptimize")
            
            ' API Key'leri ayarla
            Dim emergentKey As Object = paramService.GetParameter("sEmergentKey")
            If emergentKey IsNot Nothing AndAlso Not IsDBNull(emergentKey) Then
                txtEmergentKey.Text = emergentKey.ToString()
            Else
                txtEmergentKey.Text = ""
            End If
            
            Dim openaiKey As Object = paramService.GetParameter("sOpenAIKey")
            If openaiKey IsNot Nothing AndAlso Not IsDBNull(openaiKey) Then
                txtOpenAIKey.Text = openaiKey.ToString()
            Else
                txtOpenAIKey.Text = ""
            End If
            
            Dim googleKey As Object = paramService.GetParameter("sGoogleSearchApiKey")
            If googleKey IsNot Nothing AndAlso Not IsDBNull(googleKey) Then
                txtGoogleApiKey.Text = googleKey.ToString()
            Else
                txtGoogleApiKey.Text = ""
            End If
            
            Dim googleEngine As Object = paramService.GetParameter("sGoogleSearchEngineId")
            If googleEngine IsNot Nothing AndAlso Not IsDBNull(googleEngine) Then
                txtGoogleEngineId.Text = googleEngine.ToString()
            Else
                txtGoogleEngineId.Text = ""
            End If
            
            CalculateCost()
        Catch ex As Exception
            MessageBox.Show("Ayarlar yüklenemedi: " & ex.Message & vbCrLf & vbCrLf & "Varsayılan ayarlar kullanılacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Varsayılan değerlerle devam et - tüm checkbox'lar zaten False
        End Try
    End Sub
    
    Private Sub CalculateCost()
        Dim cost As Decimal = 0D
        
        If chkBaslikOlustur.Checked Then cost += 0.02D
        If chkAciklamaOlustur.Checked Then cost += 0.12D
        If chkTalimatOlustur.Checked Then cost += 0.10D
        If chkGorselBul.Checked Then cost += 0.175D
        If chkGorselDogrula.Checked Then cost += 0.05D
        If chkKategoriOner.Checked Then cost += 0.05D
        If chkFiyatOptimize.Checked Then cost += 0.07D
        
        lblMaliyetUrun.Text = $"Ürün Başına: {cost:F2} TL"
        lblMaliyet1000.Text = $"1000 Ürün: {(cost * 1000):F2} TL"
        
        ' Müşteriye satış fiyatı (maliyet x 1.4)
        Dim satisFiyati As Decimal = cost * 1.4D
        lblBudgetUyari.Text = $"✅ Müşteri ödemesi: {satisFiyati:F2} TL/ürün (1000 ürün = {(satisFiyati * 1000):F2} TL)"
    End Sub
    
    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles _
        chkBaslikOlustur.CheckedChanged, chkAciklamaOlustur.CheckedChanged,
        chkTalimatOlustur.CheckedChanged, chkGorselBul.CheckedChanged,
        chkGorselDogrula.CheckedChanged, chkKategoriOner.CheckedChanged,
        chkFiyatOptimize.CheckedChanged
        
        CalculateCost()
    End Sub
    
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Try
            ' Validasyon
            If chkAIKullan.Checked Then
                If String.IsNullOrWhiteSpace(txtEmergentKey.Text) AndAlso String.IsNullOrWhiteSpace(txtOpenAIKey.Text) Then
                    MessageBox.Show("AI Sistemi aktifken en az bir API key gerekli!" & vbCrLf & vbCrLf & "Lütfen Emergent veya OpenAI key'i girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtOpenAIKey.Focus()
                    Return
                End If
            End If
            
            btnKaydet.Enabled = False
            btnKaydet.Text = "Kaydediliyor..."
            
            ' Parametreleri kaydet
            Dim success As Boolean = True
            success = success And paramService.SetParameter("bAIKullan", If(chkAIKullan.Checked, 1, 0))
            success = success And paramService.SetParameter("bBaslikOlustur", If(chkBaslikOlustur.Checked, 1, 0))
            success = success And paramService.SetParameter("bAciklamaOlustur", If(chkAciklamaOlustur.Checked, 1, 0))
            success = success And paramService.SetParameter("bTalimatOlustur", If(chkTalimatOlustur.Checked, 1, 0))
            success = success And paramService.SetParameter("bGorselBul", If(chkGorselBul.Checked, 1, 0))
            success = success And paramService.SetParameter("bGorselDogrula", If(chkGorselDogrula.Checked, 1, 0))
            success = success And paramService.SetParameter("bKategoriOner", If(chkKategoriOner.Checked, 1, 0))
            success = success And paramService.SetParameter("bFiyatOptimize", If(chkFiyatOptimize.Checked, 1, 0))
            
            success = success And paramService.SetParameter("sEmergentKey", txtEmergentKey.Text.Trim())
            success = success And paramService.SetParameter("sOpenAIKey", txtOpenAIKey.Text.Trim())
            success = success And paramService.SetParameter("sGoogleSearchApiKey", txtGoogleApiKey.Text.Trim())
            success = success And paramService.SetParameter("sGoogleSearchEngineId", txtGoogleEngineId.Text.Trim())
            
            If success Then
                MessageBox.Show("✅ Ayarlar başarıyla kaydedildi!" & vbCrLf & vbCrLf & "Değişiklikler hemen geçerli olacak.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("⚠️ Bazı ayarlar kaydedilemedi!" & vbCrLf & vbCrLf & "Veritabanı bağlantısını kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Ayarlar kaydedilemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnKaydet.Enabled = True
            btnKaydet.Text = "💾 Ayarları Kaydet"
        End Try
    End Sub
    
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Try
            btnTest.Enabled = False
            btnTest.Text = "Test ediliyor..."
            
            ' Basit bir test - Emergent Key kontrolü
            If String.IsNullOrEmpty(txtEmergentKey.Text) Then
                MessageBox.Show("Lütfen önce Emergent LLM Key girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            ' AI Service ile basit test
            Dim aiService As New AIService()
            Dim testData As New Dictionary(Of String, Object) From {
                {"sAciklama", "Test Ürün"}
            }
            
            Dim result As String = aiService.GenerateTitle(testData)
            
            If Not String.IsNullOrEmpty(result) AndAlso result <> "API key bulunamadı" AndAlso result <> "AI içerik oluşturulamadı" Then
                MessageBox.Show("✅ Test başarılı! AI sistemi çalışıyor." & vbCrLf & vbCrLf & "Örnek çıktı: " & result, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("❌ Test başarısız! API key veya bağlantı sorunu olabilir." & vbCrLf & vbCrLf & "Hata: " & result, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Test sırasında hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnTest.Enabled = True
            btnTest.Text = "🧪 Test Et"
        End Try
    End Sub
    
    Private Sub lnkGoogleRehber_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGoogleRehber.LinkClicked
        Try
            Dim rehberPath As String = System.IO.Path.Combine(Application.StartupPath, "GOOGLE_API_KURULUM_REHBERI.md")
            
            If System.IO.File.Exists(rehberPath) Then
                ' Notepad ile aç
                Process.Start("notepad.exe", rehberPath)
            Else
                ' Dosya yoksa online rehbere yönlendir
                MessageBox.Show(
                    "📖 Google API Kurulum Rehberi" & vbCrLf & vbCrLf &
                    "1️⃣ Google Cloud Console'a gidin:" & vbCrLf &
                    "   https://console.cloud.google.com/" & vbCrLf & vbCrLf &
                    "2️⃣ Yeni proje oluşturun" & vbCrLf & vbCrLf &
                    "3️⃣ 'Custom Search API' etkinleştirin" & vbCrLf & vbCrLf &
                    "4️⃣ 'Kimlik Bilgileri' > 'API Anahtarı' oluşturun" & vbCrLf & vbCrLf &
                    "5️⃣ Programmable Search Engine oluşturun:" & vbCrLf &
                    "   https://programmablesearchengine.google.com/" & vbCrLf & vbCrLf &
                    "6️⃣ Arama Motoru Kimliği'ni (cx) kopyalayın" & vbCrLf & vbCrLf &
                    "💡 Ücretsiz: Günde 100 sorgu",
                    "Google API Nasıl Alınır?",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Rehber açılamadı: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
End Class
