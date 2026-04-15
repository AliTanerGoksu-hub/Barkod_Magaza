' ============================================================================
' AI ÜRÜN İŞLEME FORMU
' ============================================================================
' Tek veya toplu ürün için AI içerik oluşturma
' ============================================================================

Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Threading.Tasks
Imports System.Data.OleDb
Imports System.IO

Public Class frm_AIUrunIsle
    Inherits Form
    
    ' Veritabanı bağlantısı - KeyCode.sConnection'dan al
    Private connection As String = KeyCode.sConnection
    
    Private contentManager As AIContentManager
    Private musteriID As Integer = 1 ' Gerçek uygulamada session'dan gelecek
    Private islemDurduruldu As Boolean = False ' Durdur butonu için flag
    
    ' Log dosyası - tarih bazlı
    Private logFolder As String = "C:\AI\Logs"
    Private currentLogFile As String = ""
    
    Private WithEvents btnTekUrun As Button
    Private WithEvents btnTopluIslem As Button
    Private WithEvents btnDurdur As Button
    Private WithEvents btnStokSec As Button  ' Stok listesinden seçim için
    Private WithEvents txtStokID As TextBox
    Private WithEvents lblUrunAdi As Label  ' Seçilen ürün adını göster
    Private WithEvents txtTopluAdet As TextBox
    Private WithEvents lstLog As ListBox
    Private WithEvents progressBar As ProgressBar
    Private WithEvents lblDurum As Label
    
    ' AI İçerik Seçenekleri Checkbox'ları
    Private WithEvents chkBaslik As CheckBox           ' SEO Başlık
    Private WithEvents chkKisaAciklama As CheckBox     ' Kısa Açıklama
    Private WithEvents chkUzunAciklama As CheckBox     ' Uzun Açıklama
    Private WithEvents chkOzellikler As CheckBox       ' Özellikler HTML
    Private WithEvents chkTalimat As CheckBox          ' Kullanım Talimatı
    Private WithEvents chkSEOBilgisi As CheckBox       ' Meta Description, Keywords
    Private WithEvents chkBedenTablosu As CheckBox     ' Beden Tablosu (ÜCRETSİZ)
    Private WithEvents chkYikamaTalimati As CheckBox   ' Yıkama Talimatı
    Private WithEvents chkBakimTalimati As CheckBox    ' Bakım Talimatı
    Private WithEvents chkGuvenlikUyari As CheckBox    ' Güvenlik Uyarısı
    Private WithEvents chkHepsiniSec As CheckBox       ' Hepsini seç
    
    ' Oluşturma Modu Checkbox'ları
    Private WithEvents chkSadeceBoslar As CheckBox     ' Sadece boş alanları oluştur
    Private WithEvents chkTekrarOlustur As CheckBox    ' Varsa bile tekrar oluştur
    
    Public Sub New()
        InitializeComponent()
        contentManager = New AIContentManager()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "AI Ürün İşleme"
        Me.Size = New Size(1150, 800)
        Me.StartPosition = FormStartPosition.CenterScreen
        
        Dim yPos As Integer = 20
        
        ' Başlık
        Dim lblBaslik As New Label With {
            .Text = "🤖 AI İÇERİK OLUŞTURMA",
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .Location = New Point(20, yPos),
            .Size = New Size(1060, 40),
            .ForeColor = Color.DarkBlue
        }
        Me.Controls.Add(lblBaslik)
        yPos += 50
        
        ' ===== SOL PANEL - ÜRÜN SEÇİMİ =====
        Dim grpTek As New GroupBox With {
            .Text = "Tek Ürün İşleme",
            .Location = New Point(20, yPos),
            .Size = New Size(350, 200)
        }
        
        Dim lblStokID As New Label With {
            .Text = "Stok ID:",
            .Location = New Point(15, 30),
            .Size = New Size(60, 25)
        }
        grpTek.Controls.Add(lblStokID)
        
        txtStokID = New TextBox With {
            .Location = New Point(80, 28),
            .Size = New Size(180, 25)
        }
        grpTek.Controls.Add(txtStokID)
        
        ' STOK SEÇ BUTONU
        btnStokSec = New Button With {
            .Text = "...",
            .Location = New Point(270, 26),
            .Size = New Size(50, 28),
            .BackColor = Color.SteelBlue,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }
        grpTek.Controls.Add(btnStokSec)
        
        ' SEÇİLEN ÜRÜN ADI
        lblUrunAdi = New Label With {
            .Text = "",
            .Location = New Point(15, 60),
            .Size = New Size(305, 35),
            .ForeColor = Color.DarkGreen,
            .Font = New Font("Segoe UI", 8, FontStyle.Italic)
        }
        grpTek.Controls.Add(lblUrunAdi)
        
        btnTekUrun = New Button With {
            .Text = "🚀 İşle",
            .Location = New Point(80, 100),
            .Size = New Size(240, 40),
            .BackColor = Color.Green,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }
        grpTek.Controls.Add(btnTekUrun)
        
        Me.Controls.Add(grpTek)
        
        ' ===== ORTA PANEL - İÇERİK SEÇENEKLERİ =====
        Dim grpSecenekler As New GroupBox With {
            .Text = "Oluşturulacak İçerikler",
            .Location = New Point(385, yPos),
            .Size = New Size(520, 200)
        }
        
        ' Hepsini Seç
        chkHepsiniSec = New CheckBox With {
            .Text = "✓ HEPSİNİ SEÇ",
            .Location = New Point(15, 22),
            .Size = New Size(320, 22),
            .Checked = True,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .ForeColor = Color.DarkBlue
        }
        grpSecenekler.Controls.Add(chkHepsiniSec)
        
        ' Sol sütun
        chkBaslik = New CheckBox With {
            .Text = "🏷️ SEO Başlık",
            .Location = New Point(15, 48),
            .Size = New Size(160, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkBaslik)
        
        chkKisaAciklama = New CheckBox With {
            .Text = "📝 Kısa Açıklama",
            .Location = New Point(15, 70),
            .Size = New Size(160, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkKisaAciklama)
        
        chkUzunAciklama = New CheckBox With {
            .Text = "📄 Uzun Açıklama",
            .Location = New Point(15, 92),
            .Size = New Size(160, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkUzunAciklama)
        
        chkOzellikler = New CheckBox With {
            .Text = "📋 Özellikler HTML",
            .Location = New Point(15, 114),
            .Size = New Size(160, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkOzellikler)
        
        ' Sağ sütun
        chkTalimat = New CheckBox With {
            .Text = "📖 Kullanım Talimatı",
            .Location = New Point(180, 48),
            .Size = New Size(160, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkTalimat)
        
        chkSEOBilgisi = New CheckBox With {
            .Text = "🔍 SEO Meta/Keywords",
            .Location = New Point(180, 70),
            .Size = New Size(160, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkSEOBilgisi)
        
        chkBedenTablosu = New CheckBox With {
            .Text = "📏 Beden Tablosu",
            .Location = New Point(180, 92),
            .Size = New Size(165, 20),
            .Checked = False,
            .Font = New Font("Segoe UI", 9),
            .ForeColor = Color.DarkGreen
        }
        grpSecenekler.Controls.Add(chkBedenTablosu)
        
        ' Üçüncü sütun - Yeni checkbox'lar
        chkYikamaTalimati = New CheckBox With {
            .Text = "🧼 Yıkama Talimatı",
            .Location = New Point(350, 48),
            .Size = New Size(150, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkYikamaTalimati)
        
        chkBakimTalimati = New CheckBox With {
            .Text = "🔧 Bakım Talimatı",
            .Location = New Point(350, 70),
            .Size = New Size(150, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkBakimTalimati)
        
        chkGuvenlikUyari = New CheckBox With {
            .Text = "⚠️ Güvenlik Uyarısı",
            .Location = New Point(350, 92),
            .Size = New Size(150, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        grpSecenekler.Controls.Add(chkGuvenlikUyari)
        
        ' ===== OLUŞTURMA MODU SEÇENEKLERİ =====
        Dim lblMod As New Label With {
            .Text = "─────── Oluşturma Modu ───────",
            .Location = New Point(15, 138),
            .Size = New Size(320, 18),
            .ForeColor = Color.Gray,
            .Font = New Font("Segoe UI", 8)
        }
        grpSecenekler.Controls.Add(lblMod)
        
        chkSadeceBoslar = New CheckBox With {
            .Text = "📭 Sadece Boş Olanları Oluştur",
            .Location = New Point(15, 158),
            .Size = New Size(180, 20),
            .Checked = True,
            .Font = New Font("Segoe UI", 9),
            .ForeColor = Color.DarkBlue
        }
        grpSecenekler.Controls.Add(chkSadeceBoslar)
        
        chkTekrarOlustur = New CheckBox With {
            .Text = "🔄 Tekrar Oluştur (Üzerine Yaz)",
            .Location = New Point(180, 158),
            .Size = New Size(165, 20),
            .Checked = False,
            .Font = New Font("Segoe UI", 9),
            .ForeColor = Color.DarkRed
        }
        grpSecenekler.Controls.Add(chkTekrarOlustur)
        
        Me.Controls.Add(grpSecenekler)
        
        ' ===== SAĞ PANEL - TOPLU İŞLEM =====
        Dim grpToplu As New GroupBox With {
            .Text = "Toplu Ürün İşleme (bWebGoruntule=1)",
            .Location = New Point(920, yPos),
            .Size = New Size(200, 200)
        }
        
        Dim lblAdet As New Label With {
            .Text = "Max Model:",
            .Location = New Point(15, 35),
            .Size = New Size(80, 25)
        }
        grpToplu.Controls.Add(lblAdet)
        
        txtTopluAdet = New TextBox With {
            .Location = New Point(100, 33),
            .Size = New Size(200, 25),
            .Text = "50"
        }
        grpToplu.Controls.Add(txtTopluAdet)
        
        btnTopluIslem = New Button With {
            .Text = "🔥 Toplu İşle",
            .Location = New Point(15, 75),
            .Size = New Size(170, 40),
            .BackColor = Color.DarkOrange,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold)
        }
        grpToplu.Controls.Add(btnTopluIslem)
        
        btnDurdur = New Button With {
            .Text = "⏹️ Durdur",
            .Location = New Point(15, 120),
            .Size = New Size(170, 40),
            .BackColor = Color.Red,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .Enabled = False
        }
        grpToplu.Controls.Add(btnDurdur)
        
        Me.Controls.Add(grpToplu)
        yPos += 210
        
        ' ===== DURUM LABEL =====
        lblDurum = New Label With {
            .Text = "⏸️ Hazır",
            .Location = New Point(20, yPos),
            .Size = New Size(1060, 30),
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .ForeColor = Color.DarkBlue,
            .BackColor = Color.LightCyan,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BorderStyle = BorderStyle.FixedSingle
        }
        Me.Controls.Add(lblDurum)
        yPos += 35
        
        ' ===== PROGRESS BAR =====
        progressBar = New ProgressBar With {
            .Location = New Point(20, yPos),
            .Size = New Size(1060, 25),
            .Style = ProgressBarStyle.Continuous
        }
        Me.Controls.Add(progressBar)
        yPos += 35
        
        ' ===== LOG =====
        Dim lblLog As New Label With {
            .Text = "İşlem Geçmişi:",
            .Location = New Point(20, yPos),
            .Size = New Size(1060, 25)
        }
        Me.Controls.Add(lblLog)
        yPos += 30
        
        lstLog = New ListBox With {
            .Location = New Point(20, yPos),
            .Size = New Size(1060, 400),
            .Font = New Font("Consolas", 9)
        }
        Me.Controls.Add(lstLog)
    End Sub
    
    ''' <summary>
    ''' Hepsini Seç checkbox - Tüm seçenekleri aç/kapat
    ''' </summary>
    Private Sub chkHepsiniSec_CheckedChanged(sender As Object, e As EventArgs) Handles chkHepsiniSec.CheckedChanged
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
    End Sub
    
    ''' <summary>
    ''' Sadece Boşlar checkbox - Tekrar Oluştur ile çakışmayı önle
    ''' </summary>
    Private Sub chkSadeceBoslar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSadeceBoslar.CheckedChanged
        If chkSadeceBoslar.Checked AndAlso chkTekrarOlustur.Checked Then
            chkTekrarOlustur.Checked = False
        End If
        KaydetCheckboxDurumlari()
    End Sub
    
    ''' <summary>
    ''' Tekrar Oluştur checkbox - Sadece Boşlar ile çakışmayı önle
    ''' </summary>
    Private Sub chkTekrarOlustur_CheckedChanged(sender As Object, e As EventArgs) Handles chkTekrarOlustur.CheckedChanged
        If chkTekrarOlustur.Checked AndAlso chkSadeceBoslar.Checked Then
            chkSadeceBoslar.Checked = False
        End If
        KaydetCheckboxDurumlari()
    End Sub
    
    Private Sub frm_AIUrunIsle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Checkbox durumlarını yükle
        YukleCheckboxDurumlari()
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
                AyarYaz(conn, "AI_CHK_SADECE_BOSLAR", If(chkSadeceBoslar.Checked, "1", "0"))
                AyarYaz(conn, "AI_CHK_TEKRAR_OLUSTUR", If(chkTekrarOlustur.Checked, "1", "0"))
            End Using
        Catch
        End Try
    End Sub
    
    ''' <summary>
    ''' Checkbox durumlarını veritabanından yükle
    ''' </summary>
    Private Sub YukleCheckboxDurumlari()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
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
                chkSadeceBoslar.Checked = AyarOku(conn, "AI_CHK_SADECE_BOSLAR") = "1"
                chkTekrarOlustur.Checked = AyarOku(conn, "AI_CHK_TEKRAR_OLUSTUR") = "1"
            End Using
        Catch
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
    
    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles _
        chkBaslik.CheckedChanged, chkKisaAciklama.CheckedChanged, chkUzunAciklama.CheckedChanged, _
        chkOzellikler.CheckedChanged, chkTalimat.CheckedChanged, chkSEOBilgisi.CheckedChanged, _
        chkBedenTablosu.CheckedChanged, chkYikamaTalimati.CheckedChanged, chkBakimTalimati.CheckedChanged, _
        chkGuvenlikUyari.CheckedChanged
        ' Checkbox durumlarını kaydet
        KaydetCheckboxDurumlari()
    End Sub
    
    ''' <summary>
    ''' Stok listesinden seçim yap
    ''' </summary>
    Private Sub btnStokSec_Click(sender As Object, e As EventArgs) Handles btnStokSec.Click
        Try
            ' Stok seçim formunu aç
            Using frmSec As New frm_StokSecim()
                If frmSec.ShowDialog() = DialogResult.OK Then
                    txtStokID.Text = frmSec.SecilenStokID.ToString()
                    lblUrunAdi.Text = frmSec.SecilenUrunAdi
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Stok listesi açılırken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub LoadCreditStatus()
        ' Kredi sistemi devre dışı - hiçbir şey yapma
    End Sub
    
    Private Async Sub btnTekUrun_Click(sender As Object, e As EventArgs) Handles btnTekUrun.Click
        Try
            If String.IsNullOrEmpty(txtStokID.Text) Then
                MessageBox.Show("Lütfen Stok ID girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            Dim stokID As Integer = Convert.ToInt32(txtStokID.Text)
            
            btnTekUrun.Enabled = False
            btnTopluIslem.Enabled = False
            
            AddLog("🚀 İşlem başlatıldı...")
            AddLog("📦 Ürün ID: " & stokID.ToString())
            
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
            
            Dim result As Dictionary(Of String, Object) = Await contentManager.ProcessProduct(stokID, musteriID, aiOptions)
            
            If Convert.ToBoolean(result("success")) Then
                AddLog("✅ İşlem BAŞARILI!")
                AddLog("📝 " & result("message").ToString())
                
                Dim steps As List(Of String) = CType(result("steps"), List(Of String))
                For Each stepItem As String In steps
                    AddLog("  " & stepItem)
                Next
                
                MessageBox.Show("✅ Ürün başarıyla işlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                AddLog("❌ İşlem BAŞARISIZ!")
                AddLog("📝 " & result("message").ToString())
                MessageBox.Show("❌ Hata: " & result("message").ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            AddLog("❌ Beklenmedik hata: " & ex.Message)
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnTekUrun.Enabled = True
            btnTopluIslem.Enabled = True
        End Try
    End Sub
    
    ''' <summary>
    ''' Durdur butonu - İşlemi durdurur
    ''' </summary>
    Private Sub btnDurdur_Click(sender As Object, e As EventArgs) Handles btnDurdur.Click
        islemDurduruldu = True
        btnDurdur.Enabled = False
        btnDurdur.Text = "⏳ Durduruluyor..."
        AddLog("⚠️ DURDURMA İSTEĞİ ALINDI - Mevcut işlem tamamlanınca duracak...")
        UpdateStatus("⏳ Durduruluyor...", Color.Orange)
    End Sub

    Private Async Sub btnTopluIslem_Click(sender As Object, e As EventArgs) Handles btnTopluIslem.Click
        Try
            ' Adet kontrolü
            Dim maxAdet As Integer = 0
            Try
                maxAdet = Convert.ToInt32(txtTopluAdet.Text)
            Catch
                MessageBox.Show("Lütfen geçerli bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End Try

            If maxAdet < 1 OrElse maxAdet > 1000 Then
                MessageBox.Show("Lütfen 1-1000 arası bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Başlangıç onayı
            Dim mesaj As String = "Toplu AI içerik oluşturma başlatılacak." & vbCrLf & vbCrLf &
                                  "• Max " & maxAdet.ToString() & " model işlenecek" & vbCrLf &
                                  "• Her model anında kaydedilecek" & vbCrLf &
                                  "• İşlem yarıda kalsa bile kaydedilenler korunur" & vbCrLf & vbCrLf &
                                  "Devam etmek istiyor musunuz?"

            If MessageBox.Show(mesaj, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If

            ' Durdurma flag'ini sıfırla
            islemDurduruldu = False
            
            ' Yeni log oturumu başlat
            StartNewLogSession()
            
            ' UI'ı kilitle
            btnTekUrun.Enabled = False
            btnTopluIslem.Enabled = False
            btnDurdur.Enabled = True
            btnDurdur.Text = "⏹️ Durdur"
            lstLog.Items.Clear()
            
            AddLog("🔥 TOPLU İŞLEM BAŞLADI")
            AddLog("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
            WriteLog("Toplu işlem başladı - Max adet: " & maxAdet.ToString())
            
            ' Modelleri al
            UpdateStatus("📋 Modeller sorgulanıyor...", Color.Blue)
            Dim modeller As List(Of Dictionary(Of String, Object)) = GetModelsWithoutAI(maxAdet)
            
            If modeller.Count = 0 Then
                AddLog("⚠️ İşlenecek model bulunamadı!")
                WriteLog("İşlenecek model bulunamadı!")
                UpdateStatus("⚠️ İşlenecek model yok", Color.Orange)
                MessageBox.Show("AI içeriği olmayan model bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            
            AddLog($"📊 {modeller.Count} model bulundu")
            WriteLog($"Toplam {modeller.Count} model bulundu")
            
            progressBar.Minimum = 0
            progressBar.Maximum = modeller.Count
            progressBar.Value = 0
            
            Dim basarili As Integer = 0
            Dim basarisiz As Integer = 0
            Dim aiService As New AIService()
            
            For i As Integer = 0 To modeller.Count - 1
                Dim model As Dictionary(Of String, Object) = modeller(i)
                Dim sModel As String = model("sModel").ToString()
                Dim nStokID As Integer = Convert.ToInt32(model("nStokID"))
                
                ' DURDURMA KONTROLÜ
                If islemDurduruldu Then
                    AddLog("")
                    AddLog("⛔ İŞLEM KULLANICI TARAFINDAN DURDURULDU!")
                    AddLog($"   ✅ Kaydedilen: {basarili}")
                    AddLog($"   ❌ Başarısız: {basarisiz}")
                    AddLog($"   ⏭️ Atlandı: {modeller.Count - i}")
                    Exit For
                End If
                
                Try
                    ' Durumu güncelle
                    UpdateStatus($"🔄 İşleniyor: {i + 1}/{modeller.Count} - {sModel}", Color.Blue)
                    AddLog($"")
                    AddLog($"▶️ [{i + 1}/{modeller.Count}] Model: {sModel}")
                    
                    Dim urunAdi As String = If(model.ContainsKey("sAciklama"), model("sAciklama").ToString(), sModel)
                    WriteLog($"")
                    WriteLog($"[{i + 1}/{modeller.Count}] Model: {sModel}")
                    
                    ' AI içerik oluştur
                    AddLog($"   ⏳ AI içerik oluşturuluyor...")
                    Dim productData As New Dictionary(Of String, Object)
                    productData("sModel") = sModel
                    productData("sAciklama") = If(model.ContainsKey("sAciklama"), model("sAciklama").ToString(), sModel)
                    productData("sMarka") = If(model.ContainsKey("sMarka"), model("sMarka").ToString(), "")
                    
                    ' Kategori bilgilerini ekle (parametrik sınıflardan alındı - 5 seviye)
                    Dim kat1 As String = If(model.ContainsKey("sKategori1"), model("sKategori1").ToString(), "")
                    Dim kat2 As String = If(model.ContainsKey("sKategori2"), model("sKategori2").ToString(), "")
                    Dim kat3 As String = If(model.ContainsKey("sKategori3"), model("sKategori3").ToString(), "")
                    Dim kat4 As String = If(model.ContainsKey("sKategori4"), model("sKategori4").ToString(), "")
                    Dim kat5 As String = If(model.ContainsKey("sKategori5"), model("sKategori5").ToString(), "")
                    
                    ' Tüm kategorileri birleştir (boş olmayanları " > " ile ayır)
                    Dim kategoriParcalari As New List(Of String)
                    If Not String.IsNullOrEmpty(kat1) Then kategoriParcalari.Add(kat1)
                    If Not String.IsNullOrEmpty(kat2) Then kategoriParcalari.Add(kat2)
                    If Not String.IsNullOrEmpty(kat3) Then kategoriParcalari.Add(kat3)
                    If Not String.IsNullOrEmpty(kat4) Then kategoriParcalari.Add(kat4)
                    If Not String.IsNullOrEmpty(kat5) Then kategoriParcalari.Add(kat5)
                    Dim tumKategori As String = String.Join(" > ", kategoriParcalari)
                    
                    productData("sKategori") = tumKategori
                    productData("sKategoriAdi") = tumKategori
                    
                    Dim marka As String = productData("sMarka").ToString()
                    AddLog($"   🏷️ Marka: {marka}")
                    AddLog($"   📋 Kategori: {tumKategori}")
                    WriteLog($"  Ürün: {urunAdi}")
                    WriteLog($"  Marka: {marka}")
                    WriteLog($"  Kategori: {tumKategori}")
                    
                    Dim content As Dictionary(Of String, String) = aiService.GenerateCompleteContent(productData)
                    
                    If content("success") = "true" Then
                        AddLog($"   ✅ AI içerik oluşturuldu")
                        WriteLog($"  AI içerik başarılı")
                        
                        ' Beden tablosu KALDIRILDI - frm_AI_TopluIslem'deki checkbox ile kontrol edilir
                        
                        ' HEMEN KAYDET - Yarıda kalsa bile bu model kaydedilmiş olur
                        AddLog($"   💾 Kaydediliyor...")
                        Dim kayitSonuc As Boolean = SaveModelContent(sModel, nStokID, content)
                        
                        If kayitSonuc Then
                            basarili += 1
                            AddLog($"   ✅ KAYIT BAŞARILI!")
                            WriteLog($"  KAYIT BAŞARILI")
                        Else
                            basarisiz += 1
                            AddLog($"   ❌ Kayıt hatası!")
                            WriteLog($"  KAYIT HATASI!")
                        End If
                    Else
                        basarisiz += 1
                        Dim hata As String = If(content.ContainsKey("error"), content("error"), "Bilinmeyen hata")
                        AddLog($"   ❌ AI hatası: {hata}")
                        WriteLog($"  AI HATASI: {hata}")
                    End If
                    
                Catch ex As Exception
                    basarisiz += 1
                    AddLog($"   ❌ HATA: {ex.Message}")
                    WriteLog($"  EXCEPTION: {ex.Message}")
                End Try
                
                ' Progress güncelle
                progressBar.Value = i + 1
                Application.DoEvents()
                
                ' Rate limiting
                System.Threading.Thread.Sleep(500)
            Next
            
            ' Sonuç
            AddLog("")
            AddLog("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
            AddLog($"🏁 TOPLU İŞLEM TAMAMLANDI!")
            AddLog($"   ✅ Başarılı: {basarili}")
            AddLog($"   ❌ Başarısız: {basarisiz}")
            AddLog($"   📊 Toplam: {modeller.Count}")
            
            WriteLog("========================================")
            WriteLog("TOPLU İŞLEM TAMAMLANDI")
            WriteLog($"Başarılı: {basarili}")
            WriteLog($"Başarısız: {basarisiz}")
            WriteLog($"Toplam: {modeller.Count}")
            WriteLog($"Log dosyası: {currentLogFile}")
            WriteLog("========================================")
            
            UpdateStatus($"✅ Tamamlandı! Başarılı: {basarili}, Başarısız: {basarisiz}", Color.Green)
            
            MessageBox.Show($"Toplu işlem tamamlandı!" & vbCrLf & vbCrLf &
                           $"Başarılı: {basarili}" & vbCrLf &
                           $"Başarısız: {basarisiz}" & vbCrLf &
                           $"Toplam: {modeller.Count}" & vbCrLf & vbCrLf &
                           $"Log: {currentLogFile}",
                           "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Catch ex As Exception
            AddLog($"❌ KRİTİK HATA: {ex.Message}")
            WriteLog($"KRİTİK HATA: {ex.Message}")
            UpdateStatus($"❌ HATA: {ex.Message}", Color.Red)
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnTekUrun.Enabled = True
            btnTopluIslem.Enabled = True
            btnDurdur.Enabled = False
            btnDurdur.Text = "⏹️ Durdur"
            progressBar.Value = 0
            islemDurduruldu = False
        End Try
    End Sub
    
    ''' <summary>
    ''' AI içeriği olmayan/eksik modelleri getir - Checkbox seçeneklerine göre
    ''' </summary>
    Private Function GetModelsWithoutAI(maxCount As Integer) As List(Of Dictionary(Of String, Object))
        Dim modeller As New List(Of Dictionary(Of String, Object))
        
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Parametrik sınıf eşleştirmelerini al
                ' Varsayılan değerler frm_SinifEsleme ile uyumlu
                Dim markaField As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_MARKA", "sSinifKodu3")
                Dim kat1Field As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT1", "sSinifKodu4")
                Dim kat2Field As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT2", "sSinifKodu5")
                Dim kat3Field As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT3", "sSinifKodu6")
                Dim kat4Field As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT4", "sSinifKodu7")
                Dim kat5Field As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT5", "sSinifKodu8")
                
                AddLog("📋 Sınıf Eşleştirme: MARKA=" & markaField & ", KAT1=" & kat1Field & ", KAT2=" & kat2Field & ", KAT3=" & kat3Field & ", KAT4=" & kat4Field & ", KAT5=" & kat5Field)
                
                ' Sınıf numaralarını al
                Dim markaSinifNo As String = markaField.Replace("sSinifKodu", "")
                Dim kat1SinifNo As String = kat1Field.Replace("sSinifKodu", "")
                Dim kat2SinifNo As String = kat2Field.Replace("sSinifKodu", "")
                Dim kat3SinifNo As String = kat3Field.Replace("sSinifKodu", "")
                Dim kat4SinifNo As String = kat4Field.Replace("sSinifKodu", "")
                Dim kat5SinifNo As String = kat5Field.Replace("sSinifKodu", "")
                
                Dim sql As String = ""
                
                ' Marka ve Kategori subquery'leri (5 kategoriye kadar)
                Dim markaSubquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{markaSinifNo} WHERE sSinifKodu = (SELECT TOP 1 {markaField} FROM tbStokSinifi WHERE nStokID = MIN(s.nStokID))) as sMarka"
                Dim kat1Subquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{kat1SinifNo} WHERE sSinifKodu = (SELECT TOP 1 {kat1Field} FROM tbStokSinifi WHERE nStokID = MIN(s.nStokID))) as sKategori1"
                Dim kat2Subquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{kat2SinifNo} WHERE sSinifKodu = (SELECT TOP 1 {kat2Field} FROM tbStokSinifi WHERE nStokID = MIN(s.nStokID))) as sKategori2"
                Dim kat3Subquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{kat3SinifNo} WHERE sSinifKodu = (SELECT TOP 1 {kat3Field} FROM tbStokSinifi WHERE nStokID = MIN(s.nStokID))) as sKategori3"
                Dim kat4Subquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{kat4SinifNo} WHERE sSinifKodu = (SELECT TOP 1 {kat4Field} FROM tbStokSinifi WHERE nStokID = MIN(s.nStokID))) as sKategori4"
                Dim kat5Subquery As String = $"(SELECT TOP 1 sAciklama FROM tbSSinif{kat5SinifNo} WHERE sSinifKodu = (SELECT TOP 1 {kat5Field} FROM tbStokSinifi WHERE nStokID = MIN(s.nStokID))) as sKategori5"
                
                ' TEKRAR OLUŞTUR seçiliyse: Tüm web'de görüntülenen ürünleri getir
                If chkTekrarOlustur.Checked Then
                    sql = $"SELECT TOP {maxCount} MIN(s.nStokID) as nStokID, s.sModel, MIN(s.sAciklama) as sAciklama, " &
                          $"{markaSubquery}, {kat1Subquery}, {kat2Subquery}, {kat3Subquery}, {kat4Subquery}, {kat5Subquery} " &
                          "FROM tbStok s " &
                          "WHERE s.bWebGoruntule = 1 " &
                          "GROUP BY s.sModel " &
                          "ORDER BY s.sModel"
                    AddLog("📋 Mod: TEKRAR OLUŞTUR - Tüm modeller alınıyor...")
                    
                ' SADECE BOŞLAR seçiliyse: Eksik içeriği olan modelleri getir (bAIIcerikVar=0 olanlar)
                ElseIf chkSadeceBoslar.Checked Then
                    ' Hangi alanların kontrol edileceğini belirle
                    Dim kosullar As New List(Of String)
                    
                    ' tbStokUzunNot kontrolü
                    If chkUzunAciklama.Checked Then kosullar.Add("(u.sModel IS NULL OR u.sUzunNot IS NULL OR u.sUzunNot = '')")
                    If chkBedenTablosu.Checked Then kosullar.Add("(u.sModel IS NULL OR u.sBedenTablosu IS NULL OR u.sBedenTablosu = '')")
                    If chkOzellikler.Checked Then kosullar.Add("(u.sModel IS NULL OR u.sOzellikler IS NULL OR u.sOzellikler = '')")
                    If chkTalimat.Checked Then kosullar.Add("(u.sModel IS NULL OR u.sKullanimTalimati IS NULL OR u.sKullanimTalimati = '')")
                    
                    ' tbStokAIIcerik kontrolü
                    If chkBaslik.Checked Then kosullar.Add("(a.sModel IS NULL OR a.sSEOBaslik IS NULL OR a.sSEOBaslik = '')")
                    If chkKisaAciklama.Checked Then kosullar.Add("(a.sModel IS NULL OR a.sKisaAciklama IS NULL OR a.sKisaAciklama = '')")
                    If chkSEOBilgisi.Checked Then kosullar.Add("(a.sModel IS NULL OR a.sMetaDescription IS NULL OR a.sMetaDescription = '' OR a.sAnahtarKelimeler IS NULL OR a.sAnahtarKelimeler = '')")
                    
                    Dim whereKosul As String = ""
                    If kosullar.Count > 0 Then
                        whereKosul = "AND (" & String.Join(" OR ", kosullar) & ")"
                    End If
                    
                    ' Secili alanlari bos olan modelleri al (bAIIcerikVar durumuna bakmadan)
                    sql = $"SELECT TOP {maxCount} MIN(s.nStokID) as nStokID, s.sModel, MIN(s.sAciklama) as sAciklama, " &
                          $"{markaSubquery}, {kat1Subquery}, {kat2Subquery}, {kat3Subquery}, {kat4Subquery}, {kat5Subquery} " &
                          "FROM tbStok s " &
                          "LEFT JOIN tbStokUzunNot u ON s.sModel = u.sModel " &
                          "LEFT JOIN tbStokAIIcerik a ON s.sModel = a.sModel " &
                          "WHERE s.bWebGoruntule = 1 " & whereKosul & " " &
                          "GROUP BY s.sModel " &
                          "ORDER BY s.sModel"
                    AddLog("📋 Mod: SADECE BOŞLAR - Seçili alanları boş olan modeller alınıyor...")
                    
                ' Varsayılan: AI içeriği hiç olmayan modeller
                Else
                    sql = $"SELECT TOP {maxCount} MIN(s.nStokID) as nStokID, s.sModel, MIN(s.sAciklama) as sAciklama, " &
                          $"{markaSubquery}, {kat1Subquery}, {kat2Subquery}, {kat3Subquery}, {kat4Subquery}, {kat5Subquery} " &
                          "FROM tbStok s " &
                          "LEFT JOIN tbStokUzunNot u ON s.sModel = u.sModel " &
                          "WHERE s.bWebGoruntule = 1 " &
                          "AND (u.sModel IS NULL OR u.sUzunNot IS NULL OR u.sUzunNot = '') " &
                          "GROUP BY s.sModel " &
                          "ORDER BY s.sModel"
                    AddLog("📋 Mod: VARSAYILAN - AI içeriği olmayan modeller alınıyor...")
                End If
                
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                
                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim model As New Dictionary(Of String, Object)
                        model("nStokID") = reader("nStokID")
                        model("sModel") = reader("sModel")
                        model("sAciklama") = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama"))
                        model("sMarka") = If(IsDBNull(reader("sMarka")), "", reader("sMarka"))
                        model("sKategori1") = If(IsDBNull(reader("sKategori1")), "", reader("sKategori1"))
                        model("sKategori2") = If(IsDBNull(reader("sKategori2")), "", reader("sKategori2"))
                        model("sKategori3") = If(IsDBNull(reader("sKategori3")), "", reader("sKategori3"))
                        model("sKategori4") = If(IsDBNull(reader("sKategori4")), "", reader("sKategori4"))
                        model("sKategori5") = If(IsDBNull(reader("sKategori5")), "", reader("sKategori5"))
                        modeller.Add(model)
                    End While
                End Using
            End Using
        Catch ex As Exception
            AddLog($"❌ Model sorgulama hatası: {ex.Message}")
        End Try
        
        Return modeller
    End Function
    
    ''' <summary>
    ''' Model içeriğini kaydet - tbStokUzunNot, tbStokAIIcerik ve tbStok güncelle
    ''' chkSadeceBoslar seçiliyse sadece boş alanları doldurur
    ''' </summary>
    Private Function SaveModelContent(sModel As String, nStokID As Integer, content As Dictionary(Of String, String)) As Boolean
        Dim kayitBasarili As Boolean = False
        Dim hataMesajlari As New List(Of String)
        
        Try
            If String.IsNullOrEmpty(connection) Then
                AddLog("   ⚠️ HATA: Veritabanı bağlantısı boş!")
                Return False
            End If
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' İçerikleri al
                Dim aciklama As String = GetContentValue(content, "description")
                Dim kisaAciklama As String = GetContentValue(content, "shortDescription")
                Dim ozellikler As String = GetContentValue(content, "featuresHtml")
                Dim bakimTalimati As String = GetContentValue(content, "careInstructions")
                Dim seoBaslik As String = GetContentValue(content, "seoTitle")
                Dim metaAciklama As String = GetContentValue(content, "metaDescription")
                Dim anahtarKelimeler As String = GetContentValue(content, "keywords")
                Dim bedenTablosu As String = GetContentValue(content, "sizeChart")
                Dim icerikPuani As Integer = 0
                If content.ContainsKey("contentScore") Then
                    Integer.TryParse(content("contentScore"), icerikPuani)
                End If
                
                ' YENİ ALANLAR - Yıkama, Bakım, Güvenlik
                Dim yikamaTalimati As String = GetContentValue(content, "yikamaTalimati")
                Dim bakimTalimatiYeni As String = GetContentValue(content, "bakimTalimati")
                Dim guvenlikUyari As String = GetContentValue(content, "guvenlikUyari")
                
                ' =====================================================
                ' 1. tbStokUzunNot - Ana içerik tablosu
                ' =====================================================
                Try
                    Dim checkCmd As New OleDbCommand("SELECT sUzunNot, sBedenTablosu, sOzellikler, sKullanimTalimati FROM tbStokUzunNot WHERE sModel = ?", conn)
                    checkCmd.Parameters.AddWithValue("?", sModel)
                    
                    Dim reader As OleDbDataReader = checkCmd.ExecuteReader()
                    Dim mevcutUzunNot As String = ""
                    Dim mevcutBeden As String = ""
                    Dim mevcutOzellik As String = ""
                    Dim mevcutTalimat As String = ""
                    Dim kayitVar As Boolean = False
                    
                    If reader.Read() Then
                        kayitVar = True
                        mevcutUzunNot = If(IsDBNull(reader("sUzunNot")), "", reader("sUzunNot").ToString())
                        mevcutBeden = If(IsDBNull(reader("sBedenTablosu")), "", reader("sBedenTablosu").ToString())
                        mevcutOzellik = If(IsDBNull(reader("sOzellikler")), "", reader("sOzellikler").ToString())
                        mevcutTalimat = If(IsDBNull(reader("sKullanimTalimati")), "", reader("sKullanimTalimati").ToString())
                    End If
                    reader.Close()
                    
                    ' Sadece Boşlar modunda: mevcut dolu alanları koru
                    If chkSadeceBoslar.Checked Then
                        If Not String.IsNullOrEmpty(mevcutUzunNot) Then aciklama = mevcutUzunNot
                        If Not String.IsNullOrEmpty(mevcutBeden) Then bedenTablosu = mevcutBeden
                        If Not String.IsNullOrEmpty(mevcutOzellik) Then ozellikler = mevcutOzellik
                        If Not String.IsNullOrEmpty(mevcutTalimat) Then bakimTalimati = mevcutTalimat
                    End If
                    
                    If kayitVar Then
                        Dim updateCmd As New OleDbCommand(
                            "UPDATE tbStokUzunNot SET sUzunNot = ?, sBedenTablosu = ?, sOzellikler = ?, " &
                            "sKullanimTalimati = ?, sSonKullaniciAdi = ?, dteSonUpdateTarihi = ? WHERE sModel = ?", conn)
                        updateCmd.Parameters.AddWithValue("?", aciklama)
                        updateCmd.Parameters.AddWithValue("?", bedenTablosu)
                        updateCmd.Parameters.AddWithValue("?", ozellikler)
                        updateCmd.Parameters.AddWithValue("?", bakimTalimati)
                        updateCmd.Parameters.AddWithValue("?", "AI_TOPLU")
                        updateCmd.Parameters.AddWithValue("?", DateTime.Now)
                        updateCmd.Parameters.AddWithValue("?", sModel)
                        Dim affected As Integer = updateCmd.ExecuteNonQuery()
                        If affected > 0 Then kayitBasarili = True
                    Else
                        Dim insertCmd As New OleDbCommand(
                            "INSERT INTO tbStokUzunNot (sModel, sUzunNot, sBedenTablosu, sOzellikler, sKullanimTalimati, " &
                            "sSonKullaniciAdi, dteSonUpdateTarihi) VALUES (?, ?, ?, ?, ?, ?, ?)", conn)
                        insertCmd.Parameters.AddWithValue("?", sModel)
                        insertCmd.Parameters.AddWithValue("?", aciklama)
                        insertCmd.Parameters.AddWithValue("?", bedenTablosu)
                        insertCmd.Parameters.AddWithValue("?", ozellikler)
                        insertCmd.Parameters.AddWithValue("?", bakimTalimati)
                        insertCmd.Parameters.AddWithValue("?", "AI_TOPLU")
                        insertCmd.Parameters.AddWithValue("?", DateTime.Now)
                        Dim affected As Integer = insertCmd.ExecuteNonQuery()
                        If affected > 0 Then kayitBasarili = True
                    End If
                Catch ex As Exception
                    hataMesajlari.Add($"tbStokUzunNot: {ex.Message}")
                End Try
                
                ' =====================================================
                ' 2. tbStokAIIcerik - SEO ve detaylı içerik tablosu
                ' =====================================================
                Try
                    Dim checkAI As New OleDbCommand("SELECT sDetayliAciklama, sKisaAciklama, sOzelliklerHTML, sKullanimTalimati, " &
                        "sSEOBaslik, sMetaDescription, sAnahtarKelimeler, sBedenTablosu, sYikamaTalimati, sBakimTalimati, sGuvenliklUyari " &
                        "FROM tbStokAIIcerik WHERE sModel = ?", conn)
                    checkAI.Parameters.AddWithValue("?", sModel)
                    
                    Dim readerAI As OleDbDataReader = checkAI.ExecuteReader()
                    Dim kayitVarAI As Boolean = False
                    
                    If readerAI.Read() Then
                        kayitVarAI = True
                        
                        ' Sadece Boşlar modunda: mevcut dolu alanları koru
                        If chkSadeceBoslar.Checked Then
                            Dim mevcutVal As String
                            
                            mevcutVal = If(IsDBNull(readerAI("sDetayliAciklama")), "", readerAI("sDetayliAciklama").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then aciklama = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sKisaAciklama")), "", readerAI("sKisaAciklama").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then kisaAciklama = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sOzelliklerHTML")), "", readerAI("sOzelliklerHTML").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then ozellikler = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sKullanimTalimati")), "", readerAI("sKullanimTalimati").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then bakimTalimati = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sSEOBaslik")), "", readerAI("sSEOBaslik").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then seoBaslik = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sMetaDescription")), "", readerAI("sMetaDescription").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then metaAciklama = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sAnahtarKelimeler")), "", readerAI("sAnahtarKelimeler").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then anahtarKelimeler = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sBedenTablosu")), "", readerAI("sBedenTablosu").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then bedenTablosu = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sYikamaTalimati")), "", readerAI("sYikamaTalimati").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then yikamaTalimati = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sBakimTalimati")), "", readerAI("sBakimTalimati").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then bakimTalimatiYeni = mevcutVal
                            
                            mevcutVal = If(IsDBNull(readerAI("sGuvenliklUyari")), "", readerAI("sGuvenliklUyari").ToString())
                            If Not String.IsNullOrEmpty(mevcutVal) Then guvenlikUyari = mevcutVal
                        End If
                    End If
                    readerAI.Close()
                    
                    If kayitVarAI Then
                        ' UPDATE - mevcut kaydı güncelle
                        Dim updateAI As New OleDbCommand(
                            "UPDATE tbStokAIIcerik SET sDetayliAciklama = ?, sKisaAciklama = ?, sOzelliklerHTML = ?, " &
                            "sKullanimTalimati = ?, sSEOBaslik = ?, sMetaDescription = ?, sAnahtarKelimeler = ?, " &
                            "sBedenTablosu = ?, nIcerikPuani = ?, sYikamaTalimati = ?, sBakimTalimati = ?, sGuvenliklUyari = ?, " &
                            "dteGuncelleme = ? WHERE sModel = ?", conn)
                        updateAI.Parameters.AddWithValue("?", aciklama)
                        updateAI.Parameters.AddWithValue("?", kisaAciklama)
                        updateAI.Parameters.AddWithValue("?", ozellikler)
                        updateAI.Parameters.AddWithValue("?", bakimTalimati)
                        updateAI.Parameters.AddWithValue("?", seoBaslik)
                        updateAI.Parameters.AddWithValue("?", metaAciklama)
                        updateAI.Parameters.AddWithValue("?", anahtarKelimeler)
                        updateAI.Parameters.AddWithValue("?", bedenTablosu)
                        updateAI.Parameters.AddWithValue("?", icerikPuani)
                        updateAI.Parameters.AddWithValue("?", yikamaTalimati)
                        updateAI.Parameters.AddWithValue("?", bakimTalimatiYeni)
                        updateAI.Parameters.AddWithValue("?", guvenlikUyari)
                        updateAI.Parameters.AddWithValue("?", DateTime.Now)
                        updateAI.Parameters.AddWithValue("?", sModel)
                        updateAI.ExecuteNonQuery()
                    Else
                        ' INSERT - nStokID zorunlu!
                        Dim insertAI As New OleDbCommand(
                            "INSERT INTO tbStokAIIcerik (nStokID, sModel, sDetayliAciklama, sKisaAciklama, sOzelliklerHTML, " &
                            "sKullanimTalimati, sSEOBaslik, sMetaDescription, sAnahtarKelimeler, sBedenTablosu, " &
                            "nIcerikPuani, sYikamaTalimati, sBakimTalimati, sGuvenliklUyari) " &
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
                        insertAI.Parameters.AddWithValue("?", nStokID)
                        insertAI.Parameters.AddWithValue("?", sModel)
                        insertAI.Parameters.AddWithValue("?", aciklama)
                        insertAI.Parameters.AddWithValue("?", kisaAciklama)
                        insertAI.Parameters.AddWithValue("?", ozellikler)
                        insertAI.Parameters.AddWithValue("?", bakimTalimati)
                        insertAI.Parameters.AddWithValue("?", seoBaslik)
                        insertAI.Parameters.AddWithValue("?", metaAciklama)
                        insertAI.Parameters.AddWithValue("?", anahtarKelimeler)
                        insertAI.Parameters.AddWithValue("?", bedenTablosu)
                        insertAI.Parameters.AddWithValue("?", icerikPuani)
                        insertAI.Parameters.AddWithValue("?", yikamaTalimati)
                        insertAI.Parameters.AddWithValue("?", bakimTalimatiYeni)
                        insertAI.Parameters.AddWithValue("?", guvenlikUyari)
                        insertAI.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                    hataMesajlari.Add($"tbStokAIIcerik: {ex.Message}")
                End Try
                
                ' =====================================================
                ' 3. tbStok - Tüm varyantları işaretle
                ' =====================================================
                Try
                    Dim updateStok As New OleDbCommand("UPDATE tbStok SET bAIIcerikVar = 1 WHERE sModel = ?", conn)
                    updateStok.Parameters.AddWithValue("?", sModel)
                    updateStok.ExecuteNonQuery()
                Catch ex As Exception
                    hataMesajlari.Add($"tbStok: {ex.Message}")
                End Try
                
                ' Hata varsa log'a yaz
                If hataMesajlari.Count > 0 Then
                    For Each hata As String In hataMesajlari
                        AddLog($"   ⚠️ {hata}")
                    Next
                End If
                
                Return kayitBasarili
            End Using
        Catch ex As Exception
            AddLog($"   ❌ DB BAĞLANTI HATASI: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Dictionary'den değer al, yoksa placeholder döndür
    ''' AI üretemediği alanlar için "---" yazılır, böylece tekrar sorgulanmaz
    ''' </summary>
    Private Function GetContentValue(dict As Dictionary(Of String, String), key As String) As String
        If dict.ContainsKey(key) AndAlso Not String.IsNullOrEmpty(dict(key)) Then
            Return dict(key)
        End If
        ' AI üretemedi - placeholder yaz ki tekrar sorgulanmasın
        Return "---"
    End Function
    
    ''' <summary>
    ''' Durum labelını güncelle
    ''' </summary>
    Private Sub UpdateStatus(text As String, color As Color)
        lblDurum.Text = text
        lblDurum.ForeColor = color
        Application.DoEvents()
    End Sub
    
    Private Sub AddLog(message As String)
        Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss")
        lstLog.Items.Insert(0, "[" & timestamp & "] " & message)
        
        If lstLog.Items.Count > 100 Then
            lstLog.Items.RemoveAt(lstLog.Items.Count - 1)
        End If
        
        Application.DoEvents()
    End Sub
    
    ''' <summary>
    ''' Parametrik sınıf eşleştirmesini oku (tbSistemAyar'dan)
    ''' </summary>
    Private Function GetSinifEslemeAyar(conn As OleDb.OleDbConnection, paramAdi As String, varsayilan As String) As String
        Try
            Using cmd As New OleDb.OleDbCommand("SELECT sAyarDegeri FROM tbSistemAyar WHERE sAyarKodu = ?", conn)
                cmd.Parameters.AddWithValue("?", paramAdi)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Return result.ToString()
                End If
            End Using
        Catch
        End Try
        Return varsayilan
    End Function
    
    ''' <summary>
    ''' Tarih bazlı log dosyası oluştur ve yaz
    ''' </summary>
    Private Sub WriteLog(message As String)
        Try
            ' Log klasörü yoksa oluştur
            If Not Directory.Exists(logFolder) Then
                Directory.CreateDirectory(logFolder)
            End If
            
            ' Tarih bazlı log dosyası
            If String.IsNullOrEmpty(currentLogFile) Then
                currentLogFile = Path.Combine(logFolder, $"AI_Toplu_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.log")
            End If
            
            Dim logLine As String = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}"
            File.AppendAllText(currentLogFile, logLine & vbCrLf)
        Catch
        End Try
    End Sub
    
    ''' <summary>
    ''' Yeni log oturumu başlat
    ''' </summary>
    Private Sub StartNewLogSession()
        currentLogFile = Path.Combine(logFolder, $"AI_Toplu_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.log")
        WriteLog("========================================")
        WriteLog("AI TOPLU İŞLEM BAŞLATILDI")
        WriteLog("========================================")
    End Sub
    
End Class
