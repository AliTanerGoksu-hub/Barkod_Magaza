' ============================================================================
' E-TİCARET ANALİZ MENÜSÜ
' Dosya: frm_EticaretAnalizMenu.vb
' Tarih: 2026-02-20
' Açıklama: Tüm e-ticaret analiz formlarına kolay erişim sağlar
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing

''' <summary>
''' E-Ticaret Analiz Araçları Ana Menü Formu
''' </summary>
Public Class frm_EticaretAnalizMenu
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "E-Ticaret Analiz Araclari"
        Me.Size = New Size(700, 620)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.BackColor = Color.FromArgb(245, 245, 250)
        
        ' Başlık
        Dim lblBaslik As New Label()
        lblBaslik.Text = "📊 E-Ticaret Analiz Araçları"
        lblBaslik.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblBaslik.ForeColor = Color.FromArgb(33, 33, 33)
        lblBaslik.Location = New Point(30, 20)
        lblBaslik.AutoSize = True
        Me.Controls.Add(lblBaslik)
        
        Dim lblAlt As New Label()
        lblAlt.Text = "Pazaryeri performansınızı analiz edin ve satışlarınızı artırın"
        lblAlt.Font = New Font("Segoe UI", 10)
        lblAlt.ForeColor = Color.Gray
        lblAlt.Location = New Point(30, 55)
        lblAlt.AutoSize = True
        Me.Controls.Add(lblAlt)
        
        ' Butonlar
        Dim yPos As Integer = 100
        Dim btnHeight As Integer = 55
        Dim btnSpacing As Integer = 65
        
        ' 1. Satış İvmesi Dashboard
        CreateMenuButton("📈 Satış İvmesi Dashboard", 
                        "Ürün satış hızını analiz edin, trend tespiti yapın", 
                        Color.FromArgb(63, 81, 181), yPos, AddressOf btnSatisIvmesi_Click)
        yPos += btnSpacing
        
        ' 2. Rakip Fiyat Otomasyonu
        CreateMenuButton("🏷️ Rakip Fiyat Otomasyonu", 
                        "Rakip fiyatlarını izleyin, otomatik fiyat ayarlayın", 
                        Color.FromArgb(0, 150, 136), yPos, AddressOf btnRakipFiyat_Click)
        yPos += btnSpacing
        
        ' 3. Favori/Sepet Analizi
        CreateMenuButton("❤️ Favori/Sepet Analizi", 
                        "Dönüşüm oranlarını analiz edin, performans ölçün", 
                        Color.FromArgb(233, 30, 99), yPos, AddressOf btnFavoriSepet_Click)
        yPos += btnSpacing
        
        ' 4. İade Riski Tahmini
        CreateMenuButton("⚠️ İade Riski Tahmini", 
                        "Yüksek iade riskli ürünleri tespit edin", 
                        Color.FromArgb(244, 67, 54), yPos, AddressOf btnIadeRiski_Click)
        yPos += btnSpacing
        
        ' 5. Kampanya Önerisi
        CreateMenuButton("🎯 Otomatik Kampanya Önerisi", 
                        "Stok eritme ve satış artırma kampanyaları", 
                        Color.FromArgb(76, 175, 80), yPos, AddressOf btnKampanya_Click)
        yPos += btnSpacing
        
        ' 6. Yorum Analizi
        CreateMenuButton("Yorum Analizi", 
                        "Musteri yorumlarini analiz edin, icgoruler elde edin", 
                        Color.FromArgb(156, 39, 176), yPos, AddressOf btnYorum_Click)
        yPos += btnSpacing
        
        ' 7. Pazaryeri API Ayarlari
        CreateMenuButton("Pazaryeri API Ayarlari", 
                        "Trendyol, Hepsiburada, N11, Amazon ve diger pazaryeri API bilgileri", 
                        Color.FromArgb(96, 125, 139), yPos, AddressOf btnAPIAyarlari_Click)
    End Sub
    
    Private Sub CreateMenuButton(text As String, description As String, color As Color, yPos As Integer, handler As EventHandler)
        Dim btn As New Button()
        btn.Size = New Size(620, 50)
        btn.Location = New Point(30, yPos)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = color
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.Padding = New Padding(15, 0, 0, 0)
        btn.Text = text
        btn.Cursor = Cursors.Hand
        AddHandler btn.Click, handler
        Me.Controls.Add(btn)
        
        ' Alt açıklama
        Dim lbl As New Label()
        lbl.Text = description
        lbl.Font = New Font("Segoe UI", 8)
        lbl.ForeColor = Color.White
        lbl.BackColor = color
        lbl.Location = New Point(45, yPos + 30)
        lbl.AutoSize = True
        Me.Controls.Add(lbl)
        lbl.BringToFront()
    End Sub
    
    Private Sub btnSatisIvmesi_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frm_SatisIvmesiDashboard()
            frm.connection = KeyCode.connection
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnRakipFiyat_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frm_RakipFiyatOtomasyonu()
            frm.connection = KeyCode.connection
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnFavoriSepet_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frm_FavoriSepetAnalizi()
            frm.connection = KeyCode.connection
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnIadeRiski_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frm_IadeRiskiTahmini()
            frm.connection = KeyCode.connection
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnKampanya_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frm_KampanyaOnerisi()
            frm.connection = KeyCode.connection
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnYorum_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frm_YorumAnalizi()
            frm.connection = KeyCode.connection
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnAPIAyarlari_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frm_PazaryeriAPIAyarlari()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
