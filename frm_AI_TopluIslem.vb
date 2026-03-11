' ============================================================================
' AI TOPLU İŞLEM FORMU
' ============================================================================
' frm_stok_liste'den seçilen ürünler için toplu AI işlemi
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.IO
Imports System.Threading.Tasks

Partial Public Class frm_AI_TopluIslem
    
    Private contentManager As AIContentManager
    Private selectedStokIDs As List(Of Integer)
    Private musteriID As Integer = 1
    
    ' Form kontrolleri
    Private WithEvents lstUrunler As ListBox
    Private WithEvents lblToplamUrun As Label
    Private WithEvents lblTahminiMaliyet As Label
    Private WithEvents lblKrediDurumu As Label
    ' AI İçerik Seçenekleri
    Private WithEvents chkBaslik As CheckBox           ' SEO Başlık
    Private WithEvents chkKisaAciklama As CheckBox     ' Kısa Açıklama
    Private WithEvents chkUzunAciklama As CheckBox     ' Uzun Açıklama/Not
    Private WithEvents chkOzellikler As CheckBox       ' Özellikler HTML
    Private WithEvents chkTalimat As CheckBox          ' Kullanım Talimatı
    Private WithEvents chkSEOBilgisi As CheckBox       ' Meta Description, Keywords
    Private WithEvents chkBedenTablosu As CheckBox     ' Beden Tablosu
    Private WithEvents chkGorsel As CheckBox           ' Ürün Görseli
    Private WithEvents chkYikamaTalimati As CheckBox   ' Yıkama Talimatı
    Private WithEvents chkBakimTalimati As CheckBox    ' Bakım Talimatı
    Private WithEvents chkGuvenlikUyari As CheckBox    ' Güvenlik Uyarısı
    Private WithEvents chkHepsiniSec As CheckBox       ' Hepsini seç
    ' Diğer kontroller
    Private WithEvents progressBar As ProgressBar
    Private WithEvents lstLog As ListBox
    Private WithEvents btnBasla As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnIptal As DevExpress.XtraEditors.SimpleButton
    
    Private isProcessing As Boolean = False
    
    ''' <summary>
    ''' Constructor - Seçili ürün ID'leri ile başlat
    ''' </summary>
    Public Sub New(stokIDs As List(Of Integer))
        InitializeComponent()
        SetupUI()
        selectedStokIDs = stokIDs
        contentManager = New AIContentManager()
        LoadProductList()
        LoadCreditStatus()
        CalculateCost()
    End Sub
    
    Private Sub SetupUI()
        Me.Text = "🤖 AI Toplu İşlem"
        Me.Size = New Size(1000, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        
        Dim yPos As Integer = 20
        
        ' ===== BAŞLIK =====
        Dim lblBaslik As New Label With {
            .Text = "🤖 AI TOPLU İŞLEM",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .Location = New Point(20, yPos),
            .Size = New Size(960, 40),
            .ForeColor = Color.DarkBlue
        }
        Me.Controls.Add(lblBaslik)
        yPos += 50
        
        ' ===== KREDİ DURUMU =====
        lblKrediDurumu = New Label With {
            .Text = "💳 Kredi: Yükleniyor...",
            .Location = New Point(20, yPos),
            .Size = New Size(960, 30),
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .BackColor = Color.LightYellow,
            .BorderStyle = BorderStyle.FixedSingle,
            .TextAlign = ContentAlignment.MiddleCenter
        }
        Me.Controls.Add(lblKrediDurumu)
        yPos += 40
        
        ' ===== SOL PANEL - ÜRÜN LİSTESİ =====
        Dim grpUrunler As New GroupBox With {
            .Text = "Seçili Ürünler",
            .Location = New Point(20, yPos),
            .Size = New Size(450, 350)
        }
        
        lblToplamUrun = New Label With {
            .Text = "Toplam: 0 ürün",
            .Location = New Point(20, 25),
            .Size = New Size(410, 25),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }
        grpUrunler.Controls.Add(lblToplamUrun)
        
        lstUrunler = New ListBox With {
            .Location = New Point(20, 55),
            .Size = New Size(410, 280),
            .Font = New Font("Consolas", 9)
        }
        grpUrunler.Controls.Add(lstUrunler)
        
        Me.Controls.Add(grpUrunler)
        
        ' ===== SAĞ PANEL - AYARLAR =====
        Dim grpAyarlar As New GroupBox With {
            .Text = "İşlem Seçenekleri",
            .Location = New Point(490, yPos),
            .Size = New Size(490, 350)
        }
        
        Dim lblSecenekler As New Label With {
            .Text = "Hangi AI içerikleri oluşturulsun?",
            .Location = New Point(20, 25),
            .Size = New Size(450, 25),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        grpAyarlar.Controls.Add(lblSecenekler)
        
        ' ===== SOL SÜTUN =====
        chkBaslik = New CheckBox With {
            .Text = "🏷️ SEO Başlık",
            .Location = New Point(20, 55),
            .Size = New Size(220, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkBaslik)
        
        chkKisaAciklama = New CheckBox With {
            .Text = "📝 Kısa Açıklama",
            .Location = New Point(20, 80),
            .Size = New Size(220, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkKisaAciklama)
        
        chkUzunAciklama = New CheckBox With {
            .Text = "📄 Uzun Açıklama/Not",
            .Location = New Point(20, 105),
            .Size = New Size(220, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkUzunAciklama)
        
        chkOzellikler = New CheckBox With {
            .Text = "📋 Özellikler (HTML)",
            .Location = New Point(20, 130),
            .Size = New Size(220, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkOzellikler)
        
        ' ===== SAĞ SÜTUN =====
        chkTalimat = New CheckBox With {
            .Text = "📖 Kullanım Talimatı",
            .Location = New Point(250, 55),
            .Size = New Size(220, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkTalimat)
        
        chkSEOBilgisi = New CheckBox With {
            .Text = "🔍 SEO (Meta, Keywords)",
            .Location = New Point(250, 80),
            .Size = New Size(220, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkSEOBilgisi)
        
        chkBedenTablosu = New CheckBox With {
            .Text = "📏 Beden Tablosu (Ücretsiz)",
            .Location = New Point(250, 105),
            .Size = New Size(220, 22),
            .Checked = False,
            .Font = New Font("Segoe UI", 9),
            .ForeColor = Color.DarkGreen
        }
        grpAyarlar.Controls.Add(chkBedenTablosu)
        
        ' Yeni checkbox'lar - Yıkama, Bakım, Güvenlik
        chkYikamaTalimati = New CheckBox With {
            .Text = "🧼 Yıkama Talimatı",
            .Location = New Point(480, 30),
            .Size = New Size(180, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkYikamaTalimati)
        
        chkBakimTalimati = New CheckBox With {
            .Text = "🔧 Bakım Talimatı",
            .Location = New Point(480, 55),
            .Size = New Size(180, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkBakimTalimati)
        
        chkGuvenlikUyari = New CheckBox With {
            .Text = "⚠️ Güvenlik Uyarısı",
            .Location = New Point(480, 80),
            .Size = New Size(180, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkGuvenlikUyari)
        
        chkGorsel = New CheckBox With {
            .Text = "🖼️ Ürün Görseli Bul",
            .Location = New Point(480, 105),
            .Size = New Size(180, 22),
            .Checked = False,
            .Font = New Font("Segoe UI", 9)
        }
        grpAyarlar.Controls.Add(chkGorsel)
        
        ' ===== HEPSİNİ SEÇ =====
        chkHepsiniSec = New CheckBox With {
            .Text = "✅ HEPSİNİ SEÇ / KALDIR",
            .Location = New Point(20, 165),
            .Size = New Size(450, 25),
            .Checked = True,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .ForeColor = Color.DarkBlue
        }
        AddHandler chkHepsiniSec.CheckedChanged, AddressOf chkHepsiniSec_CheckedChanged
        grpAyarlar.Controls.Add(chkHepsiniSec)
        
        lblTahminiMaliyet = New Label With {
            .Text = "💰 Tahmini Maliyet: Hesaplanıyor...",
            .Location = New Point(20, 200),
            .Size = New Size(450, 30),
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .ForeColor = Color.DarkGreen
        }
        grpAyarlar.Controls.Add(lblTahminiMaliyet)
        
        Dim lblUyari As New Label With {
            .Text = "⚠️ Beden tablosu: Ürün adında 'Çocuk' varsa çocuk bedenleri oluşturulur",
            .Location = New Point(20, 235),
            .Size = New Size(450, 40),
            .Font = New Font("Segoe UI", 8),
            .ForeColor = Color.DarkOrange
        }
        grpAyarlar.Controls.Add(lblUyari)
        
        ' Butonlar
        btnBasla = New DevExpress.XtraEditors.SimpleButton()
        btnBasla.Text = "🚀 İşlemi Başlat"
        btnBasla.Location = New Point(20, 280)
        btnBasla.Size = New Size(220, 45)
        btnBasla.Appearance.BackColor = Color.Green
        btnBasla.Appearance.ForeColor = Color.White
        btnBasla.Appearance.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        grpAyarlar.Controls.Add(btnBasla)
        
        btnIptal = New DevExpress.XtraEditors.SimpleButton()
        btnIptal.Text = "❌ İptal"
        btnIptal.Location = New Point(250, 280)
        btnIptal.Size = New Size(220, 45)
        btnIptal.Appearance.BackColor = Color.Gray
        btnIptal.Appearance.ForeColor = Color.White
        btnIptal.Appearance.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        grpAyarlar.Controls.Add(btnIptal)
        
        Me.Controls.Add(grpAyarlar)
        yPos += 360
        
        ' ===== PROGRESS BAR =====
        progressBar = New ProgressBar With {
            .Location = New Point(20, yPos),
            .Size = New Size(960, 30),
            .Style = ProgressBarStyle.Continuous
        }
        Me.Controls.Add(progressBar)
        yPos += 40
        
        ' ===== LOG LİSTESİ =====
        Dim lblLog As New Label With {
            .Text = "İşlem Geçmişi:",
            .Location = New Point(20, yPos),
            .Size = New Size(960, 25)
        }
        Me.Controls.Add(lblLog)
        yPos += 30
        
        lstLog = New ListBox With {
            .Location = New Point(20, yPos),
            .Size = New Size(960, 180),
            .Font = New Font("Consolas", 9)
        }
        Me.Controls.Add(lstLog)
    End Sub
    
    Private Sub frm_AI_TopluIslem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form yüklendiğinde checkbox durumlarını yükle
        YukleCheckboxDurumlari()
        CalculateCost()
    End Sub
    
    Private Sub LoadProductList()
        Try
            lstUrunler.Items.Clear()
            
            If selectedStokIDs Is Nothing OrElse selectedStokIDs.Count = 0 Then
                lblToplamUrun.Text = "Toplam: 0 ürün (Hiç ürün seçilmemiş!)"
                lblToplamUrun.ForeColor = Color.Red
                btnBasla.Enabled = False
                Return
            End If
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                For Each stokID As Integer In selectedStokIDs
                    Dim cmd As New OleDbCommand(
                        "SELECT TOP 1 sKodu, sAciklama FROM tbStok WHERE nStokID = ?", conn)
                    cmd.Parameters.AddWithValue("?", stokID)
                    
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim kodu As String = reader("sKodu").ToString()
                        Dim aciklama As String = reader("sAciklama").ToString()
                        lstUrunler.Items.Add(String.Format("{0} - {1} - {2}", stokID, kodu, aciklama))
                    End If
                    reader.Close()
                Next
            End Using
            
            lblToplamUrun.Text = "Toplam: " & selectedStokIDs.Count.ToString() & " ürün"
            lblToplamUrun.ForeColor = Color.DarkGreen
            
        Catch ex As Exception
            MessageBox.Show("Ürün listesi yüklenemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub LoadCreditStatus()
        Try
            Dim creditService As New CreditService()
            Dim balance As Dictionary(Of String, Object) = creditService.GetCreditBalance(musteriID)
            
            If balance IsNot Nothing Then
                Dim kullanilabilir As Decimal = Convert.ToDecimal(balance("kullanilabilir"))
                Dim gunlukKullanim As Integer = Convert.ToInt32(balance("gunluk_kullanim"))
                Dim gunlukLimit As Integer = Convert.ToInt32(balance("gunluk_limit"))
                
                lblKrediDurumu.Text = "💳 Kredi: " & kullanilabilir.ToString("F2") & " TL | 📊 Günlük: " & gunlukKullanim.ToString() & "/" & gunlukLimit.ToString()
                
                If kullanilabilir < 10 Then
                    lblKrediDurumu.BackColor = Color.LightCoral
                ElseIf kullanilabilir < 50 Then
                    lblKrediDurumu.BackColor = Color.LightYellow
                Else
                    lblKrediDurumu.BackColor = Color.LightGreen
                End If
            Else
                lblKrediDurumu.Text = "⚠️ Kredi hesabı bulunamadı!"
                lblKrediDurumu.BackColor = Color.LightCoral
            End If
        Catch ex As Exception
            lblKrediDurumu.Text = "❌ Hata: " & ex.Message
            lblKrediDurumu.BackColor = Color.LightCoral
        End Try
    End Sub
    
    Private Sub CalculateCost()
        Dim costPerProduct As Decimal = 0D
        
        If chkBaslik.Checked Then costPerProduct += 0.02D
        If chkKisaAciklama.Checked Then costPerProduct += 0.05D
        If chkUzunAciklama.Checked Then costPerProduct += 0.12D
        If chkOzellikler.Checked Then costPerProduct += 0.08D
        If chkTalimat.Checked Then costPerProduct += 0.10D
        If chkSEOBilgisi.Checked Then costPerProduct += 0.05D
        If chkGorsel.Checked Then costPerProduct += 0.175D
        ' chkBedenTablosu ücretsiz - maliyet eklenmez
        
        Dim totalCost As Decimal = costPerProduct * selectedStokIDs.Count
        
        lblTahminiMaliyet.Text = "💰 Tahmini AI Maliyeti: " & costPerProduct.ToString("F2") & " TL/ürün × " & _
                                 selectedStokIDs.Count.ToString() & " = " & totalCost.ToString("F2") & " TL"
    End Sub
    
    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles _
        chkBaslik.CheckedChanged, chkKisaAciklama.CheckedChanged, chkUzunAciklama.CheckedChanged, _
        chkOzellikler.CheckedChanged, chkTalimat.CheckedChanged, chkSEOBilgisi.CheckedChanged, _
        chkBedenTablosu.CheckedChanged, chkYikamaTalimati.CheckedChanged, chkBakimTalimati.CheckedChanged, _
        chkGuvenlikUyari.CheckedChanged, chkGorsel.CheckedChanged
        CalculateCost()
        ' Checkbox durumlarını kaydet
        KaydetCheckboxDurumlari()
    End Sub
    
    ''' <summary>
    ''' Checkbox durumlarını veritabanına kaydet
    ''' </summary>
    Private Sub KaydetCheckboxDurumlari()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                AyarYaz(conn, "AI_CHK_BASLIK", If(chkBaslik.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_KISA_ACIKLAMA", If(chkKisaAciklama.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_UZUN_ACIKLAMA", If(chkUzunAciklama.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_OZELLIKLER", If(chkOzellikler.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_TALIMAT", If(chkTalimat.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_SEO_BILGISI", If(chkSEOBilgisi.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_BEDEN_TABLOSU", If(chkBedenTablosu.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_YIKAMA", If(chkYikamaTalimati.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_BAKIM", If(chkBakimTalimati.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_GUVENLIK", If(chkGuvenlikUyari.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_GORSEL", If(chkGorsel.Checked, "1", "0"))
                Debug.WriteLine("[AI Checkbox] Ayarlar kaydedildi")
            End Using
        Catch ex As Exception
            Debug.WriteLine("[AI Checkbox] Kaydetme hatası: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Checkbox durumlarını veritabanından yükle
    ''' </summary>
    Private Sub YukleCheckboxDurumlari()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                ' Tüm checkbox'lar için tutarlı mantık: "1" = seçili, diğer = seçili değil
                chkBaslik.Checked = AyarOku(conn, "AI_CHK_BASLIK") = "1"
                chkKisaAciklama.Checked = AyarOku(conn, "AI_CHK_KISA_ACIKLAMA") = "1"
                chkUzunAciklama.Checked = AyarOku(conn, "AI_CHK_UZUN_ACIKLAMA") = "1"
                chkOzellikler.Checked = AyarOku(conn, "AI_CHK_OZELLIKLER") = "1"
                chkTalimat.Checked = AyarOku(conn, "AI_CHK_TALIMAT") = "1"
                chkSEOBilgisi.Checked = AyarOku(conn, "AI_CHK_SEO_BILGISI") = "1"
                chkBedenTablosu.Checked = AyarOku(conn, "AI_CHK_BEDEN_TABLOSU") = "1"
                chkYikamaTalimati.Checked = AyarOku(conn, "AI_CHK_YIKAMA") = "1"
                chkBakimTalimati.Checked = AyarOku(conn, "AI_CHK_BAKIM") = "1"
                chkGuvenlikUyari.Checked = AyarOku(conn, "AI_CHK_GUVENLIK") = "1"
                chkGorsel.Checked = AyarOku(conn, "AI_CHK_GORSEL") = "1"
            End Using
        Catch ex As Exception
            Debug.WriteLine("[AI Checkbox] Yükleme hatası: " & ex.Message)
        End Try
    End Sub
    
    Private Function AyarOku(conn As OleDb.OleDbConnection, paramAdi As String) As String
        Try
            Using cmd As New OleDb.OleDbCommand("SELECT sParamDegeri FROM tbParamGenel WHERE sParamAdi = ?", conn)
                cmd.Parameters.AddWithValue("?", paramAdi)
                Dim result = cmd.ExecuteScalar()
                Return If(result IsNot Nothing AndAlso result IsNot DBNull.Value, result.ToString(), "")
            End Using
        Catch
            Return ""
        End Try
    End Function
    
    Private Sub AyarYaz(conn As OleDb.OleDbConnection, paramAdi As String, paramDegeri As String)
        Try
            Using checkCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbParamGenel WHERE sParamAdi = ?", conn)
                checkCmd.Parameters.AddWithValue("?", paramAdi)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                
                If exists > 0 Then
                    Using updateCmd As New OleDb.OleDbCommand("UPDATE tbParamGenel SET sParamDegeri = ? WHERE sParamAdi = ?", conn)
                        updateCmd.Parameters.AddWithValue("?", paramDegeri)
                        updateCmd.Parameters.AddWithValue("?", paramAdi)
                        updateCmd.ExecuteNonQuery()
                    End Using
                Else
                    Using insertCmd As New OleDb.OleDbCommand("INSERT INTO tbParamGenel (sParamAdi, sParamDegeri) VALUES (?, ?)", conn)
                        insertCmd.Parameters.AddWithValue("?", paramAdi)
                        insertCmd.Parameters.AddWithValue("?", paramDegeri)
                        insertCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch
        End Try
    End Sub
    
    Private Async Sub btnBasla_Click(sender As Object, e As EventArgs) Handles btnBasla.Click
        Try
            If isProcessing Then Return
            
            ' Onay al
            Dim dialogResult As DialogResult = MessageBox.Show(
                selectedStokIDs.Count.ToString() & " ürün için AI içerik oluşturulacak." & vbCrLf & vbCrLf &
                "Müşteriye satış: " & (selectedStokIDs.Count * 1.4D).ToString("F2") & " TL" & vbCrLf & vbCrLf &
                "Devam etmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            
            If dialogResult <> DialogResult.Yes Then Return
            
            isProcessing = True
            btnBasla.Enabled = False
            btnIptal.Enabled = False
            progressBar.Value = 0
            progressBar.Maximum = selectedStokIDs.Count
            lstLog.Items.Clear()
            
            ' İşlemi başlat
            ProcessProducts()
            
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            isProcessing = False
            btnBasla.Enabled = True
            btnIptal.Enabled = True
        End Try
    End Sub
    
    Private Async Sub ProcessProducts()
        Dim successCount As Integer = 0
        Dim failCount As Integer = 0
        Dim bedenCount As Integer = 0
        
        AddLog("🚀 Toplu AI işlem başlatıldı: " & selectedStokIDs.Count.ToString() & " ürün")
        AddLog("")
        AddLog("Seçili işlemler:")
        If chkBaslik.Checked Then AddLog("  ✓ SEO Başlık")
        If chkKisaAciklama.Checked Then AddLog("  ✓ Kısa Açıklama")
        If chkUzunAciklama.Checked Then AddLog("  ✓ Uzun Açıklama/Not")
        If chkOzellikler.Checked Then AddLog("  ✓ Özellikler HTML")
        If chkTalimat.Checked Then AddLog("  ✓ Kullanım Talimatı")
        If chkSEOBilgisi.Checked Then AddLog("  ✓ SEO (Meta, Keywords)")
        If chkBedenTablosu.Checked Then AddLog("  ✓ Beden Tablosu (Ücretsiz)")
        If chkGorsel.Checked Then AddLog("  ✓ Ürün Görseli")
        AddLog("")

        ' Parametrik sınıf eşleştirmelerini al (bir kere oku, tüm ürünler için kullan)
        ' Varsayılanlar frm_SinifEsleme ile uyumlu olmalı
        Dim markaField As String = GetSinifAyar("ETICARET_SINIF_MARKA", "sSinifKodu3")
        Dim kat1Field As String = GetSinifAyar("ETICARET_SINIF_KAT1", "sSinifKodu4")
        Dim kat2Field As String = GetSinifAyar("ETICARET_SINIF_KAT2", "sSinifKodu5")
        
        ' Form loguna da yaz
        AddLog("📋 Sınıf Eşleştirme Ayarları:")
        AddLog("   MARKA = " & markaField)
        AddLog("   KAT1 = " & kat1Field)
        AddLog("   KAT2 = " & kat2Field)

        ' Sınıf numaralarını çıkar
        Dim markaSinifNo As String = markaField.Replace("sSinifKodu", "")
        Dim kat1SinifNo As String = kat1Field.Replace("sSinifKodu", "")
        Dim kat2SinifNo As String = kat2Field.Replace("sSinifKodu", "")

        AddLog($"📋 Parametrik Sınıf Ayarları: Marka=Sınıf{markaSinifNo}, Kat1=Sınıf{kat1SinifNo}, Kat2=Sınıf{kat2SinifNo}")
        AddLog("")

        For Each stokID As Integer In selectedStokIDs
            Try
                ' Ürün bilgilerini al - PARAMETRİK SINIFLARLA
                Dim urunAdi As String = ""
                Dim sModel As String = ""
                Dim sMarka As String = ""
                Dim kategori1 As String = ""
                Dim kategori2 As String = ""
                Dim tumKategori As String = ""

                Using conn As New OleDbConnection(connection)
                    conn.Open()

                    ' Parametrik sınıf subquery'lerini oluştur
                    Dim markaSubquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{markaSinifNo} WHERE sSinifKodu = T2.{markaField}) as sSinifMarka"
                    Dim kat1Subquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{kat1SinifNo} WHERE sSinifKodu = T2.{kat1Field}) as sKategori1"
                    Dim kat2Subquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{kat2SinifNo} WHERE sSinifKodu = T2.{kat2Field}) as sKategori2"

                    Debug.WriteLine($"[AI-Sinif] Marka Field: {markaField} (Sinif{markaSinifNo})")
                    Debug.WriteLine($"[AI-Sinif] Kat1 Field: {kat1Field} (Sinif{kat1SinifNo})")
                    Debug.WriteLine($"[AI-Sinif] Kat2 Field: {kat2Field} (Sinif{kat2SinifNo})")

                    Dim cmd As New OleDbCommand(
                        $"SELECT T1.sAciklama, T1.sModel, T1.sMarka, T2.{markaField} as MarkaKod, T2.{kat1Field} as Kat1Kod, T2.{kat2Field} as Kat2Kod, {markaSubquery}, {kat1Subquery}, {kat2Subquery} " &
                        "FROM tbStok AS T1 LEFT JOIN tbStokSinifi AS T2 ON T2.nStokID = T1.nStokID " &
                        "WHERE T1.nStokID = ?", conn)
                    cmd.Parameters.AddWithValue("?", stokID)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            urunAdi = If(reader("sAciklama") Is DBNull.Value, "", reader("sAciklama").ToString())
                            sModel = If(reader("sModel") Is DBNull.Value, "", reader("sModel").ToString())

                            ' Debug: Ham sınıf kodlarını göster
                            Dim markaKod As String = If(reader("MarkaKod") Is DBNull.Value, "NULL", reader("MarkaKod").ToString())
                            Dim kat1Kod As String = If(reader("Kat1Kod") Is DBNull.Value, "NULL", reader("Kat1Kod").ToString())
                            Dim kat2Kod As String = If(reader("Kat2Kod") Is DBNull.Value, "NULL", reader("Kat2Kod").ToString())
                            Debug.WriteLine($"[AI-Sinif] Ham Kodlar - Marka:{markaKod}, Kat1:{kat1Kod}, Kat2:{kat2Kod}")

                            ' Marka: Önce parametrik sınıftan, yoksa tbStok.sMarka'dan
                            Dim sinifMarka As String = If(reader("sSinifMarka") Is DBNull.Value, "", reader("sSinifMarka").ToString().Trim())
                            sMarka = If(Not String.IsNullOrEmpty(sinifMarka), sinifMarka, If(reader("sMarka") Is DBNull.Value, "", reader("sMarka").ToString()))

                            ' Kategoriler (parametrik sınıflardan)
                            kategori1 = If(reader("sKategori1") Is DBNull.Value, "", reader("sKategori1").ToString().Trim())
                            kategori2 = If(reader("sKategori2") Is DBNull.Value, "", reader("sKategori2").ToString().Trim())

                            Debug.WriteLine($"[AI-Sinif] Çözümlenmiş - Marka:{sMarka}, Kat1:{kategori1}, Kat2:{kategori2}")

                            ' Tam kategori: "KAT1 > KAT2" formatında
                            tumKategori = kategori1
                            If Not String.IsNullOrEmpty(kategori2) Then
                                tumKategori = kategori1 & " > " & kategori2
                            End If
                        End If
                    End Using
                End Using

                AddLog("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
                AddLog("📦 " & sModel & " - " & If(urunAdi.Length > 35, urunAdi.Substring(0, 35) & "...", urunAdi))
                AddLog($"   Marka: {sMarka}, Kategori: {tumKategori}")

                ' AI içerik oluşturma seçeneklerine göre işle
                ' AI içerik oluşturma - herhangi bir AI seçeneği seçiliyse çalıştır
                Dim aiNeeded As Boolean = chkBaslik.Checked OrElse chkKisaAciklama.Checked OrElse
                                          chkUzunAciklama.Checked OrElse chkOzellikler.Checked OrElse
                                          chkTalimat.Checked OrElse chkSEOBilgisi.Checked OrElse chkGorsel.Checked OrElse
                                          chkYikamaTalimati.Checked OrElse chkBakimTalimati.Checked OrElse chkGuvenlikUyari.Checked

                If aiNeeded Then
                    ' Checkbox durumlarını options olarak gönder
                    Dim aiOptions As New Dictionary(Of String, Boolean) From {
                        {"baslik", chkBaslik.Checked},
                        {"kisaAciklama", chkKisaAciklama.Checked},
                        {"uzunAciklama", chkUzunAciklama.Checked},
                        {"ozellikler", chkOzellikler.Checked},
                        {"talimat", chkTalimat.Checked},
                        {"seoBilgisi", chkSEOBilgisi.Checked},
                        {"yikamaTalimati", chkYikamaTalimati.Checked},
                        {"bakimTalimati", chkBakimTalimati.Checked},
                        {"guvenlikUyari", chkGuvenlikUyari.Checked}
                    }

                    ' AI ContentManager sadece seçili içerikleri oluşturur
                    Dim result As Dictionary(Of String, Object) = Await contentManager.ProcessProduct(stokID, musteriID, aiOptions)

                    If Convert.ToBoolean(result("success")) Then
                        AddLog("  ✅ AI İçerik başarılı")
                        successCount += 1
                    Else
                        AddLog("  ❌ AI İçerik: " & result("message").ToString())
                        failCount += 1
                    End If
                End If

                ' Beden tablosu işlemi (ücretsiz, yerel)
                If chkBedenTablosu.Checked AndAlso Not String.IsNullOrEmpty(sModel) Then
                    ' Kategori bazlı kontrol - PARAMETRİK KATEGORİ KULLAN
                    Dim kategoriLower As String = tumKategori.ToLower()
                    Dim bedenTablosuAtla As Boolean = kategoriLower.Contains("züccaciye") OrElse
                                                       kategoriLower.Contains("zuccaciye") OrElse
                                                       kategoriLower.Contains("mutfak") OrElse
                                                       kategoriLower.Contains("elektrikli") OrElse
                                                       kategoriLower.Contains("elektronik") OrElse
                                                       kategoriLower.Contains("kozmetik") OrElse
                                                       kategoriLower.Contains("ev tekstil") OrElse
                                                       kategoriLower.Contains("banyo") OrElse
                                                       kategoriLower.Contains("mikser") OrElse
                                                       kategoriLower.Contains("blender") OrElse
                                                       kategoriLower.Contains("kettle")

                    If bedenTablosuAtla Then
                        AddLog($"  ⏭️ Beden Tablosu: Kategori '{tumKategori}' için atlandı")
                    Else
                        Dim yasGrubu As String = TespitYasGrubu(urunAdi)
                        Dim bedenTablosu As String = OlusturBedenTablosu(urunAdi)

                        If Not String.IsNullOrEmpty(bedenTablosu) Then
                            If KaydetBedenTablosu(sModel, bedenTablosu) Then
                                AddLog($"  📏 Beden Tablosu: {yasGrubu} oluşturuldu")
                                bedenCount += 1
                            Else
                                AddLog("  ❌ Beden Tablosu kayıt hatası")
                            End If
                        Else
                            AddLog("  ⏭️ Beden Tablosu: Ürün türü uygun değil")
                        End If
                    End If
                End If

                progressBar.Value += 1
                Application.DoEvents()

                ' Rate limiting
                Threading.Thread.Sleep(300)

            Catch ex As Exception
                AddLog("  ❌ Hata: " & ex.Message)
                failCount += 1
                progressBar.Value += 1
            End Try
        Next

        AddLog("")
        AddLog("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        AddLog("🎉 TOPLU İŞLEM TAMAMLANDI!")
        AddLog("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        AddLog("✅ AI İçerik Başarılı: " & successCount.ToString())
        AddLog("📏 Beden Tablosu: " & bedenCount.ToString())
        AddLog("❌ Başarısız: " & failCount.ToString())

        LoadCreditStatus()

        MessageBox.Show(
            "Toplu AI işlem tamamlandı!" & vbCrLf & vbCrLf &
            "✅ AI İçerik Başarılı: " & successCount.ToString() & vbCrLf &
            "📏 Beden Tablosu: " & bedenCount.ToString() & vbCrLf &
            "❌ Başarısız: " & failCount.ToString(),
            "Tamamlandı",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub

    Private Sub AddLog(message As String)
        Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss")
        lstLog.Items.Add("[" & timestamp & "] " & message)
        lstLog.TopIndex = lstLog.Items.Count - 1
        Application.DoEvents()
    End Sub

    ''' <summary>
    ''' Hepsini Seç checkbox değiştiğinde
    ''' </summary>
    Private Sub chkHepsiniSec_CheckedChanged(sender As Object, e As EventArgs)
        Dim secili As Boolean = chkHepsiniSec.Checked
        chkBaslik.Checked = secili
        chkKisaAciklama.Checked = secili
        chkUzunAciklama.Checked = secili
        chkOzellikler.Checked = secili
        chkTalimat.Checked = secili
        chkSEOBilgisi.Checked = secili
        chkBedenTablosu.Checked = secili
        chkYikamaTalimati.Checked = secili
        chkBakimTalimati.Checked = secili
        chkGuvenlikUyari.Checked = secili
        chkGorsel.Checked = secili
        CalculateCost()
    End Sub

    ''' <summary>
    ''' Ürün adından yaş grubunu tespit et (Çocuk/Yetişkin)
    ''' </summary>
    Private Function TespitYasGrubu(urunAdi As String) As String
        If String.IsNullOrEmpty(urunAdi) Then Return "Yetişkin"

        Dim urunAdiLower As String = urunAdi.ToLower()

        ' Çocuk kelimeleri - ürün adında bunlar varsa ÇOCUK
        Dim cocukKelimeleri() As String = {
            "çocuk", "cocuk", "bebek", "kids", "junior", "jr.",
            "erkek çocuk", "kız çocuk", "çocuk erkek", "çocuk kız",
            "boy", "girl", "infant", "toddler", "child"
        }

        For Each kelime As String In cocukKelimeleri
            If urunAdiLower.Contains(kelime) Then
                Return "Çocuk"
            End If
        Next

        ' Yaş aralığı kontrolü (0-16 yaş arası çocuk sayılır)
        If System.Text.RegularExpressions.Regex.IsMatch(urunAdiLower, "\b([0-9]|1[0-6])\s*(yaş|yas|age)\b") Then
            Return "Çocuk"
        End If

        ' Beden kontrolü (68, 74, 80, 86, 92... gibi çocuk bedenleri)
        If System.Text.RegularExpressions.Regex.IsMatch(urunAdiLower, "\b(68|74|80|86|92|98|104|110|116|122|128|134|140|146|152|158|164)\b") Then
            Return "Çocuk"
        End If

        Return "Yetişkin"
    End Function

    ''' <summary>
    ''' Giyim türünü tespit et
    ''' NOT: Züccaciye, Elektronik, Kozmetik gibi kategoriler için "BedenTablosuYok" döndürür
    ''' </summary>
    Private Function TespitGiyimTuru(urunAdi As String) As String
        Dim text As String = urunAdi.ToLower()

        ' ZÜCCACİYE / MUTFAK ÜRÜNLERİ - BEDEN TABLOSU YOK
        If text.Contains("cam") OrElse text.Contains("bardak") OrElse text.Contains("tabak") OrElse
           text.Contains("fincan") OrElse text.Contains("tencere") OrElse
           text.Contains("tava") OrElse text.Contains("çatal") OrElse text.Contains("kaşık") OrElse
           text.Contains("bıçak") OrElse text.Contains("sürahi") OrElse text.Contains("saklama kabı") OrElse
           text.Contains("kavanoz") OrElse text.Contains("glasslock") OrElse text.Contains("tupperware") OrElse
           text.Contains("korkmaz") OrElse text.Contains("emsan") OrElse text.Contains("paşabahçe") OrElse
           text.Contains("pasabahce") OrElse text.Contains("kütahya") OrElse text.Contains("porland") OrElse
           text.Contains("kase") OrElse text.Contains("tepsi") OrElse text.Contains("servis") OrElse
           text.Contains("çaydanlık") OrElse text.Contains("cezve") OrElse text.Contains("demlik") OrElse
           text.Contains("porselen") OrElse text.Contains("seramik") OrElse text.Contains("züccaciye") OrElse
           text.Contains("mutfak") OrElse text.Contains("bordallo") OrElse text.Contains("pinheiro") OrElse
           text.Contains("güral") OrElse text.Contains("gural") OrElse text.Contains("karaca") OrElse
           text.Contains("arzum") OrElse text.Contains("sinbo") OrElse text.Contains("çay seti") OrElse
           text.Contains("kahve seti") OrElse text.Contains("yemek takım") OrElse text.Contains("kahvaltı") Then
            Return "BedenTablosuYok"
        End If

        ' ELEKTRONİK - BEDEN TABLOSU YOK
        If text.Contains("şarj") OrElse text.Contains("kablo") OrElse text.Contains("kulaklık") OrElse
           text.Contains("telefon") OrElse text.Contains("tablet") OrElse text.Contains("bilgisayar") Then
            Return "BedenTablosuYok"
        End If

        ' KOZMETİK - BEDEN TABLOSU YOK
        If text.Contains("krem") OrElse text.Contains("şampuan") OrElse text.Contains("losyon") OrElse
           text.Contains("parfüm") OrElse text.Contains("makyaj") Then
            Return "BedenTablosuYok"
        End If

        ' EV TEKSTİLİ - BEDEN TABLOSU YOK (farklı ölçü sistemi kullanır)
        If text.Contains("nevresim") OrElse text.Contains("çarşaf") OrElse text.Contains("yastık") OrElse
           text.Contains("yorgan") OrElse text.Contains("battaniye") OrElse text.Contains("havlu") OrElse
           text.Contains("perde") OrElse text.Contains("halı") OrElse text.Contains("kilim") Then
            Return "BedenTablosuYok"
        End If

        ' Üst giyim
        If text.Contains("tişört") OrElse text.Contains("t-shirt") OrElse text.Contains("gömlek") OrElse
           text.Contains("kazak") OrElse text.Contains("sweat") OrElse text.Contains("mont") OrElse
           text.Contains("ceket") OrElse text.Contains("yelek") OrElse text.Contains("bluz") Then
            Return "UstGiyim"
        End If

        ' Alt giyim
        If text.Contains("pantolon") OrElse text.Contains("şort") OrElse text.Contains("etek") OrElse
           text.Contains("jean") OrElse text.Contains("kot") OrElse text.Contains("tayt") Then
            Return "AltGiyim"
        End If

        ' Takım
        If text.Contains("takım") OrElse text.Contains("eşofman") OrElse text.Contains("pijama") Then
            Return "Takim"
        End If

        ' Ayakkabı
        If text.Contains("ayakkabı") OrElse text.Contains("bot") OrElse text.Contains("sandalet") Then
            Return "Ayakkabi"
        End If

        Return "Genel"
    End Function

    ''' <summary>
    ''' Beden tablosu HTML oluştur
    ''' NOT: Züccaciye, Elektronik, Kozmetik gibi kategoriler için boş döndürür
    ''' </summary>
    Private Function OlusturBedenTablosu(urunAdi As String) As String
        Try
            Dim giyimTuru As String = TespitGiyimTuru(urunAdi)

            ' Beden tablosu gerektirmeyen ürünler için boş döndür
            If giyimTuru = "BedenTablosuYok" Then
                Return ""
            End If

            Dim yasGrubu As String = TespitYasGrubu(urunAdi)

            Dim bedenler As String
            Dim olculer As String

            If yasGrubu = "Çocuk" Then
                ' ÇOCUK BEDEN TABLOSU
                If giyimTuru = "UstGiyim" OrElse giyimTuru = "Takim" Then
                    bedenler = "1-2 Yaş, 2-3 Yaş, 3-4 Yaş, 4-5 Yaş, 5-6 Yaş, 6-7 Yaş, 7-8 Yaş, 8-9 Yaş, 9-10 Yaş, 10-11 Yaş, 11-12 Yaş"
                    olculer = "Göğüs, Boy, Kol"
                ElseIf giyimTuru = "AltGiyim" Then
                    bedenler = "1-2 Yaş, 2-3 Yaş, 3-4 Yaş, 4-5 Yaş, 5-6 Yaş, 6-7 Yaş, 7-8 Yaş, 8-9 Yaş, 9-10 Yaş"
                    olculer = "Bel, Kalça, Boy"
                ElseIf giyimTuru = "Ayakkabi" Then
                    bedenler = "20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35"
                    olculer = "Ayak Uzunluğu"
                Else
                    bedenler = "1-2 Yaş, 2-3 Yaş, 3-4 Yaş, 4-5 Yaş, 5-6 Yaş, 6-7 Yaş, 7-8 Yaş"
                    olculer = "Göğüs, Boy"
                End If
            Else
                ' YETİŞKİN BEDEN TABLOSU
                If giyimTuru = "UstGiyim" OrElse giyimTuru = "Takim" Then
                    bedenler = "XS, S, M, L, XL, 2XL, 3XL"
                    olculer = "Göğüs, Boy, Omuz, Kol"
                ElseIf giyimTuru = "AltGiyim" Then
                    bedenler = "XS, S, M, L, XL, 2XL, 3XL"
                    olculer = "Bel, Kalça, Bacak"
                ElseIf giyimTuru = "Ayakkabi" Then
                    bedenler = "36, 37, 38, 39, 40, 41, 42, 43, 44, 45"
                    olculer = "Ayak Uzunluğu"
                Else
                    bedenler = "S, M, L, XL, 2XL"
                    olculer = "Göğüs, Boy"
                End If
            End If

            ' HTML oluştur
            Dim html As New System.Text.StringBuilder()
            html.AppendLine("<div class='size-chart'>")
            html.AppendLine($"<h4>📏 BEDEN TABLOSU ({yasGrubu.ToUpper()})</h4>")
            html.AppendLine("<table border='1' cellpadding='8' cellspacing='0' style='border-collapse: collapse; width: 100%;'>")
            html.AppendLine("<thead style='background-color: #f5f5f5;'><tr><th>Beden</th>")

            Dim olcuList() As String = olculer.Split(","c)
            For Each olcu As String In olcuList
                html.AppendLine($"<th>{olcu.Trim()} (cm)</th>")
            Next
            html.AppendLine("</tr></thead><tbody>")

            Dim bedenList() As String = bedenler.Split(","c)
            Dim baseSize As Integer = If(yasGrubu = "Çocuk", 45, 86)

            For i As Integer = 0 To bedenList.Length - 1
                html.AppendLine("<tr>")
                html.AppendLine($"<td style='font-weight: bold;'>{bedenList(i).Trim()}</td>")
                For j As Integer = 0 To olcuList.Length - 1
                    html.AppendLine($"<td>{baseSize + (i * 4) + (j * 2)}</td>")
                Next
                html.AppendLine("</tr>")
            Next

            html.AppendLine("</tbody></table>")
            html.AppendLine("<p style='font-size: 11px; color: #666;'>* Ölçüler yaklaşık değerlerdir.</p>")
            html.AppendLine("</div>")

            Return html.ToString()
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Beden tablosunu veritabanına kaydet
    ''' </summary>
    Private Function KaydetBedenTablosu(sModel As String, bedenTablosu As String) As Boolean
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()

                Dim checkCmd As New OleDbCommand("SELECT COUNT(*) FROM tbStokUzunNot WHERE sModel = ?", conn)
                checkCmd.Parameters.AddWithValue("?", sModel)
                Dim count As Integer = CInt(checkCmd.ExecuteScalar())

                If count > 0 Then
                    Dim updateCmd As New OleDbCommand(
                        "UPDATE tbStokUzunNot SET sBedenTablosu = ?, dteSonUpdateTarihi = ? WHERE sModel = ?", conn)
                    updateCmd.Parameters.AddWithValue("?", bedenTablosu)
                    updateCmd.Parameters.AddWithValue("?", DateTime.Now)
                    updateCmd.Parameters.AddWithValue("?", sModel)
                    updateCmd.ExecuteNonQuery()
                Else
                    Dim insertCmd As New OleDbCommand(
                        "INSERT INTO tbStokUzunNot (sModel, sBedenTablosu, dteSonUpdateTarihi) VALUES (?, ?, ?)", conn)
                    insertCmd.Parameters.AddWithValue("?", sModel)
                    insertCmd.Parameters.AddWithValue("?", bedenTablosu)
                    insertCmd.Parameters.AddWithValue("?", DateTime.Now)
                    insertCmd.ExecuteNonQuery()
                End If

                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' tbSistemAyar'dan sınıf eşleştirme ayarını okur
    ''' </summary>
    Private Function GetSinifAyar(ayarKodu As String, varsayilan As String) As String
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = ?", conn)
                cmd.Parameters.AddWithValue("?", ayarKodu)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Dim deger As String = result.ToString().Trim()
                    If Not String.IsNullOrEmpty(deger) Then
                        Debug.WriteLine($"[SinifAyar] {ayarKodu} = {deger} (veritabanından)")
                        Return deger
                    End If
                End If
            End Using
        Catch ex As Exception
            Debug.WriteLine($"[SinifAyar] HATA: {ayarKodu} - {ex.Message}")
        End Try
        Debug.WriteLine($"[SinifAyar] {ayarKodu} = {varsayilan} (VARSAYILAN)")
        Return varsayilan
    End Function

End Class
