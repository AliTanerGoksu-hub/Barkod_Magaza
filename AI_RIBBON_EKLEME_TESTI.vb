' ============================================================================
' AI RİBBON SEKMESI EKLEME - TEST VERSİYONU
' ============================================================================
' frm_stok_liste formuna ekleyin ve test edin
' Sonra ana menüye taşıyabilirsiniz
' ============================================================================

' frm_stok_liste.vb içine ekleyin:

' ===== Class seviyesinde tanımlar =====
Private aiRibbonPageAdded As Boolean = False

' ===== Form_Load içine ekleyin =====
Private Sub frm_stok_liste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' ... mevcut kodlarınız ...
    
    ' AI Ribbon sekmesini ekle (sadece bir kere)
    If Not aiRibbonPageAdded Then
        AddAIRibbonPage()
        aiRibbonPageAdded = True
    End If
End Sub

' ===== Fonksiyonu ekleyin =====
Private Sub AddAIRibbonPage()
    Try
        ' Ribbon kontrolünü bul
        Dim ribbon As DevExpress.XtraBars.Ribbon.RibbonControl = Nothing
        
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is DevExpress.XtraBars.Ribbon.RibbonControl Then
                ribbon = CType(ctrl, DevExpress.XtraBars.Ribbon.RibbonControl)
                Exit For
            End If
        Next
        
        If ribbon Is Nothing Then
            MessageBox.Show("Ribbon kontrolü bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        
        ' Zaten eklendi mi kontrol et
        For Each page As DevExpress.XtraBars.Ribbon.RibbonPage In ribbon.Pages
            If page.Name = "ribbonPageAI" Then
                ' Zaten var
                Return
            End If
        Next
        
        ' ===== YENİ AI SAYFASI OLUŞTUR =====
        Dim pageAI As New DevExpress.XtraBars.Ribbon.RibbonPage()
        pageAI.Text = "🤖 AI Sistemi"
        pageAI.Name = "ribbonPageAI"
        
        ' ===== GRUP 1: AYARLAR =====
        Dim groupAyarlar As New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        groupAyarlar.Text = "Ayarlar"
        
        ' AI Ayarları Butonu
        Dim btnAIAyarlar As New DevExpress.XtraBars.BarButtonItem()
        btnAIAyarlar.Caption = "AI Ayarları"
        btnAIAyarlar.Name = "btnAIAyarlar"
        btnAIAyarlar.Id = ribbon.Items.Count
        AddHandler btnAIAyarlar.ItemClick, Sub(s, args)
            Try
                Dim frm As New frm_AIAyarlari()
                frm.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        ribbon.Items.Add(btnAIAyarlar)
        groupAyarlar.ItemLinks.Add(btnAIAyarlar)
        
        ' ===== GRUP 2: İŞLEMLER =====
        Dim groupIslemler As New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        groupIslemler.Text = "İşlemler"
        
        ' Tek Ürün İşle
        Dim btnTekUrun As New DevExpress.XtraBars.BarButtonItem()
        btnTekUrun.Caption = "Tek Ürün İşle"
        btnTekUrun.Name = "btnAITekUrun"
        btnTekUrun.Id = ribbon.Items.Count
        AddHandler btnTekUrun.ItemClick, Sub(s, args)
            Try
                Dim frm As New frm_AIUrunIsle()
                frm.Show()
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        ribbon.Items.Add(btnTekUrun)
        groupIslemler.ItemLinks.Add(btnTekUrun)
        
        ' Toplu İşlem (Stok Liste'den)
        Dim btnTopluIslem As New DevExpress.XtraBars.BarButtonItem()
        btnTopluIslem.Caption = "Toplu İşlem"
        btnTopluIslem.Name = "btnAITopluIslem"
        btnTopluIslem.Id = ribbon.Items.Count
        AddHandler btnTopluIslem.ItemClick, Sub(s, args)
            MessageBox.Show(
                "Toplu işlem için:" & vbCrLf & vbCrLf &
                "1. Stok Liste'de ürünleri seçin (Ctrl+Click)" & vbCrLf &
                "2. Sağ tık yapın" & vbCrLf &
                "3. 'AI Toplu İşlem' seçeneğini tıklayın",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End Sub
        ribbon.Items.Add(btnTopluIslem)
        groupIslemler.ItemLinks.Add(btnTopluIslem)
        
        ' ===== GRUP 3: RAPORLAR =====
        Dim groupRaporlar As New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        groupRaporlar.Text = "Raporlar"
        
        ' AI Kullanım Raporu (placeholder)
        Dim btnRapor As New DevExpress.XtraBars.BarButtonItem()
        btnRapor.Caption = "AI Kullanım Raporu"
        btnRapor.Name = "btnAIRapor"
        btnRapor.Id = ribbon.Items.Count
        AddHandler btnRapor.ItemClick, Sub(s, args)
            MessageBox.Show("AI kullanım raporu yakında eklenecek!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        ribbon.Items.Add(btnRapor)
        groupRaporlar.ItemLinks.Add(btnRapor)
        
        ' Grupları sayfaya ekle
        pageAI.Groups.Add(groupAyarlar)
        pageAI.Groups.Add(groupIslemler)
        pageAI.Groups.Add(groupRaporlar)
        
        ' Sayfayı ribbon'a ekle
        ribbon.Pages.Add(pageAI)
        
        MessageBox.Show("✅ AI Sistemi sekmesi eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
    Catch ex As Exception
        MessageBox.Show("AI sekmesi eklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
End Sub

' ============================================================================
' KURULUM:
' ============================================================================
' 1. Bu fonksiyonları frm_stok_liste.vb'ye kopyalayın
' 2. Form_Load içinde AddAIRibbonPage() çağırın
' 3. Rebuild yapın
' 4. frm_stok_liste'yi açın
' 5. Ribbon'da "🤖 AI Sistemi" sekmesini göreceksiniz!
'
' NOT: Başarılı olursa aynı kodu ana menü formuna da ekleyebilirsiniz
' ============================================================================
