' ============================================================================
' AI ENTEGRASYON KODU - frm_stok_kart.vb İÇİN
' ============================================================================
' Bu kodu frm_stok_kart.vb dosyasına ekleyin
' ============================================================================

' ======================================================================
' ADIM 1: Class seviyesinde buton tanımları (en üstte, diğer butonların yanına)
' ======================================================================

Private WithEvents btnAIResimEkle As DevExpress.XtraEditors.SimpleButton
Private WithEvents btnAIUrunOzellikleri As DevExpress.XtraEditors.SimpleButton
Private WithEvents btnAIAyarlari As DevExpress.XtraEditors.SimpleButton

' ======================================================================
' ADIM 2: Form_Load veya InitializeComponent'te butonları oluştur
' ======================================================================

Private Sub InitializeAIButtons()
    Try
        ' ===== AI RESİM EKLE BUTONU (Dökümanlar sekmesine) =====
        ' XtraTabPage3 veya resim/döküman sekmesini bulup ona ekleyin
        
        btnAIResimEkle = New DevExpress.XtraEditors.SimpleButton()
        btnAIResimEkle.Text = "🤖 AI Resim Ekle"
        btnAIResimEkle.Location = New Point(20, 20) ' Konumu ayarlayın
        btnAIResimEkle.Size = New Size(150, 35)
        btnAIResimEkle.Appearance.BackColor = Color.FromArgb(255, 140, 0) ' Turuncu
        btnAIResimEkle.Appearance.ForeColor = Color.White
        btnAIResimEkle.Appearance.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        
        ' Dökümanlar sekmesine ekle (XtraTabPage adını kontrol edin)
        ' Örnek: XtraTabPage_Dokumanlar.Controls.Add(btnAIResimEkle)
        ' Veya resim panelinin yanına ekleyin
        
        
        ' ===== AI ÜRÜN ÖZELLİKLERİ BUTONU (Not/Açıklama sekmesine) =====
        
        btnAIUrunOzellikleri = New DevExpress.XtraEditors.SimpleButton()
        btnAIUrunOzellikleri.Text = "✨ AI Ürün Özellikleri"
        btnAIUrunOzellikleri.Location = New Point(20, 20) ' Konumu ayarlayın
        btnAIUrunOzellikleri.Size = New Size(180, 35)
        btnAIUrunOzellikleri.Appearance.BackColor = Color.FromArgb(34, 139, 34) ' Yeşil
        btnAIUrunOzellikleri.Appearance.ForeColor = Color.White
        btnAIUrunOzellikleri.Appearance.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        
        ' Not/Açıklama sekmesine ekle
        ' Örnek: XtraTabPage_Not.Controls.Add(btnAIUrunOzellikleri)
        
        
        ' ===== AI AYARLARI BUTONU (Ana sekmede, köşede) =====
        
        btnAIAyarlari = New DevExpress.XtraEditors.SimpleButton()
        btnAIAyarlari.Text = "⚙️"
        btnAIAyarlari.Location = New Point(Me.Width - 80, 10) ' Sağ üst köşe
        btnAIAyarlari.Size = New Size(60, 30)
        btnAIAyarlari.Appearance.BackColor = Color.Gray
        btnAIAyarlari.Appearance.ForeColor = Color.White
        btnAIAyarlari.ToolTip = "AI Ayarları"
        
        ' Ana forma ekle
        Me.Controls.Add(btnAIAyarlari)
        btnAIAyarlari.BringToFront()
        
    Catch ex As Exception
        MessageBox.Show("AI butonları eklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub

' ======================================================================
' ADIM 3: Buton Click Event'leri
' ======================================================================

Private Sub btnAIResimEkle_Click(sender As Object, e As EventArgs) Handles btnAIResimEkle.Click
    Try
        ' Eğer form yeni kayıt modundaysa (nStokID = 0), uyar
        If nStokID = 0 OrElse nStokID = Nothing Then
            MessageBox.Show("Lütfen önce ürünü kaydedin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' AI Görsel Bulma
        Dim imageService As New AIImageFinder()
        
        ' Ürün bilgilerini hazırla
        Dim barkod As String = If(txtBarkod IsNot Nothing, txtBarkod.Text, "")
        Dim model As String = If(txtModel IsNot Nothing, txtModel.Text, "")
        Dim renk As String = If(txtRenk IsNot Nothing, txtRenk.Text, "")
        Dim marka As String = If(txtMarka IsNot Nothing, txtMarka.Text, "")
        Dim kategori As String = ""
        Dim urunAdi As String = If(txtStokAdi IsNot Nothing, txtStokAdi.Text, "")
        
        ' Progress göster
        Cursor.Current = Cursors.WaitCursor
        
        Dim result As Dictionary(Of String, Object) = imageService.AutoFindAndAddImage(
            barkod, model, renk, marka, kategori, urunAdi
        )
        
        Cursor.Current = Cursors.Default
        
        If Convert.ToBoolean(result("success")) Then
            MessageBox.Show("✅ Ürün görseli bulundu ve eklendi!" & vbCrLf & vbCrLf & 
                          "URL: " & result("image_url").ToString(), 
                          "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' Resim listesini yenile (formdaki resim grid'ini refresh edin)
            ' Örnek: LoadProductImages()
        Else
            MessageBox.Show("❌ Görsel bulunamadı: " & result("message").ToString(), 
                          "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
    Catch ex As Exception
        Cursor.Current = Cursors.Default
        MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub

Private Async Sub btnAIUrunOzellikleri_Click(sender As Object, e As EventArgs) Handles btnAIUrunOzellikleri.Click
    Try
        ' Eğer form yeni kayıt modundaysa, uyar
        If nStokID = 0 OrElse nStokID = Nothing Then
            MessageBox.Show("Lütfen önce ürünü kaydedin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Onay al
        Dim result As DialogResult = MessageBox.Show(
            "Bu ürün için AI ile ürün özellikleri oluşturulsun mu?" & vbCrLf & vbCrLf &
            "• SEO Başlık" & vbCrLf &
            "• Detaylı Açıklama" & vbCrLf &
            "• Kullanım Talimatları" & vbCrLf &
            "• Meta Description" & vbCrLf & vbCrLf &
            "Maliyet: ~1.4 TL",
            "Onay",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        
        If result <> DialogResult.Yes Then Return
        
        ' Progress göster
        Cursor.Current = Cursors.WaitCursor
        
        ' AI İçerik Oluştur
        Dim contentManager As New AIContentManager()
        Dim processResult As Dictionary(Of String, Object) = Await contentManager.ProcessProduct(nStokID, 1) ' musteriID = 1 (varsayılan)
        
        Cursor.Current = Cursors.Default
        
        If Convert.ToBoolean(processResult("success")) Then
            ' Başarılı mesajı
            Dim steps As List(Of String) = CType(processResult("steps"), List(Of String))
            Dim stepText As String = String.Join(vbCrLf, steps)
            
            MessageBox.Show(
                "✅ AI İçerik Başarıyla Oluşturuldu!" & vbCrLf & vbCrLf &
                stepText & vbCrLf & vbCrLf &
                "📝 " & processResult("message").ToString(),
                "Başarılı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            
            ' AI içeriğini forma yükle
            LoadAIContent()
        Else
            MessageBox.Show(
                "❌ İşlem Başarısız!" & vbCrLf & vbCrLf &
                processResult("message").ToString(),
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If
        
    Catch ex As Exception
        Cursor.Current = Cursors.Default
        MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub

Private Sub btnAIAyarlari_Click(sender As Object, e As EventArgs) Handles btnAIAyarlari.Click
    Try
        ' AI Ayarları formunu aç
        Dim frmAI As New frm_AIAyarlari()
        frmAI.ShowDialog()
    Catch ex As Exception
        MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub

' ======================================================================
' ADIM 4: AI İçeriğini Form'a Yükle (Opsiyonel - görüntüleme için)
' ======================================================================

Private Sub LoadAIContent()
    Try
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            
            Dim cmd As New OleDb.OleDbCommand(
                "SELECT sSEOBaslik, sDetayliAciklama, sKullanimTalimati, sMetaDescription " &
                "FROM tbStokAIIcerik WHERE nStokID = ?", conn)
            cmd.Parameters.AddWithValue("?", nStokID)
            
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
            
            If reader.Read() Then
                ' AI içeriğini ilgili textbox'lara yükle
                ' Örnek:
                ' txtSEOBaslik.Text = reader("sSEOBaslik").ToString()
                ' txtAciklama.Text = reader("sDetayliAciklama").ToString()
                ' txtKullanimTalimati.Text = reader("sKullanimTalimati").ToString()
                
                ' Veya yeni bir sekme aç ve göster
                MessageBox.Show("AI içeriği yüklendi! Formda ilgili alanlara yerleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
            reader.Close()
        End Using
    Catch ex As Exception
        ' Sessizce geç veya log tut
    End Try
End Sub

' ======================================================================
' ADIM 5: Form_Load'da AI butonlarını başlat
' ======================================================================

' Form_Load event'ine ekleyin:
' Private Sub frm_stok_kart_Load(...) Handles MyBase.Load
'     ...
'     InitializeAIButtons()
'     ...
' End Sub

' ======================================================================
' KURULUM TALİMATLARI:
' ======================================================================
' 1. Bu dosyadaki kodu frm_stok_kart.vb'ye kopyalayın
' 2. InitializeAIButtons() fonksiyonunu Form_Load'da çağırın
' 3. Buton konumlarını ve tab page'leri projenize göre ayarlayın
' 4. txtBarkod, txtModel, txtRenk gibi kontrol adlarını düzeltin
' 5. Compile edin ve test edin!
' ======================================================================
