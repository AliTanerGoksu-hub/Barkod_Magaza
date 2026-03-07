' ============================================================================
' AI ENTEGRASYON KODU - frm_stok_liste.vb ve ANA MENÜ İÇİN
' ============================================================================

' ======================================================================
' BÖLÜM 1: frm_stok_liste.vb İÇİN - SEÇİLİ ÜRÜNLERDE SAĞ TIK MENÜSÜ
' ======================================================================

' Class seviyesinde tanımlar:
Private WithEvents mnuAITopluIslem As DevExpress.Utils.Menu.DXMenuItem

' GridView'in PopupMenuShowing event'ine ekleyin:
Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) _
    Handles GridView1.PopupMenuShowing
    
    Try
        ' Mevcut menüye AI işlemi ekle
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            ' Separator ekle
            e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuSeparatorItem())
            
            ' AI Toplu İşlem menüsü
            mnuAITopluIslem = New DevExpress.Utils.Menu.DXMenuItem("🤖 Seçili Ürünler İçin AI İşlemi")
            AddHandler mnuAITopluIslem.Click, AddressOf mnuAITopluIslem_Click
            e.Menu.Items.Add(mnuAITopluIslem)
        End If
    Catch ex As Exception
        ' Hata durumunda sessizce geç
    End Try
End Sub

Private Sub mnuAITopluIslem_Click(sender As Object, e As EventArgs)
    Try
        ' Seçili satırları al
        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()
        
        If selectedRowHandles Is Nothing OrElse selectedRowHandles.Length = 0 Then
            MessageBox.Show("Lütfen işlem yapmak için ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Seçili ürünlerin nStokID'lerini al
        Dim stokIDs As New List(Of Integer)
        
        For Each rowHandle As Integer In selectedRowHandles
            If rowHandle >= 0 Then ' Geçerli satır mı?
                Dim stokID As Object = GridView1.GetRowCellValue(rowHandle, "nStokID")
                If stokID IsNot Nothing AndAlso IsNumeric(stokID) Then
                    stokIDs.Add(Convert.ToInt32(stokID))
                End If
            End If
        Next
        
        If stokIDs.Count = 0 Then
            MessageBox.Show("Geçerli ürün bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' AI Toplu İşlem formunu aç
        Dim frmToplu As New frm_AI_TopluIslem(stokIDs)
        frmToplu.ShowDialog()
        
        ' İşlem tamamlandıktan sonra listeyi yenile
        ' Örnek: LoadStokListesi()
        
    Catch ex As Exception
        MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub

' ======================================================================
' BÖLÜM 2: frm_stok_liste.vb - RIBBON MENÜYE BUTON EKLE
' ======================================================================

' Ribbon var ise, yeni bir buton ekleyin:
Private WithEvents barButtonAIToplu As DevExpress.XtraBars.BarButtonItem

' InitializeComponent veya Form_Load'da:
Private Sub AddAIButtonToRibbon()
    Try
        ' Ribbon kontrolü bul (adı değişebilir: ribbonControl1, RibbonControl vb.)
        If RibbonControl1 IsNot Nothing Then
            ' Yeni buton oluştur
            barButtonAIToplu = New DevExpress.XtraBars.BarButtonItem()
            barButtonAIToplu.Caption = "🤖 AI Toplu İşlem"
            barButtonAIToplu.Id = BarManager1.GetNewItemId()
            ' barButtonAIToplu.ImageOptions.LargeImage = My.Resources.ai_icon ' Icon ekleyebilirsiniz
            
            AddHandler barButtonAIToplu.ItemClick, AddressOf barButtonAIToplu_ItemClick
            
            ' Bar manager'a ekle
            BarManager1.Items.Add(barButtonAIToplu)
            
            ' İlgili ribbon page group'a ekle (örnek: Stok sayfasının işlemler grubu)
            ' ribbonPageGroupIslemler.ItemLinks.Add(barButtonAIToplu)
        End If
    Catch ex As Exception
        ' Ribbon yoksa veya hata varsa sessizce geç
    End Try
End Sub

Private Sub barButtonAIToplu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    ' Aynı işlemi yap
    mnuAITopluIslem_Click(sender, e)
End Sub

' ======================================================================
' BÖLÜM 3: ANA MENÜ/RIBBON'A YENİ AI SEKMESİ EKLE
' ======================================================================

' Ana form'da (giriş sonrası açılan ana menü formu)
' Ribbon varsa yeni bir RibbonPage ekleyin:

Private Sub AddAIPageToMainRibbon()
    Try
        ' Ana ribbon kontrolünü bul
        Dim mainRibbon As DevExpress.XtraBars.Ribbon.RibbonControl = Nothing
        
        ' Form kontrollerini ara
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is DevExpress.XtraBars.Ribbon.RibbonControl Then
                mainRibbon = CType(ctrl, DevExpress.XtraBars.Ribbon.RibbonControl)
                Exit For
            End If
        Next
        
        If mainRibbon Is Nothing Then Return
        
        ' Yeni AI sayfası oluştur
        Dim pageAI As New DevExpress.XtraBars.Ribbon.RibbonPage()
        pageAI.Text = "🤖 AI Sistemi"
        pageAI.Name = "ribbonPageAI"
        
        ' Grup 1: Ayarlar
        Dim groupAyarlar As New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        groupAyarlar.Text = "Ayarlar"
        
        Dim btnAIAyarlar As New DevExpress.XtraBars.BarButtonItem()
        btnAIAyarlar.Caption = "⚙️ AI Ayarları"
        btnAIAyarlar.Id = BarManager1.GetNewItemId()
        AddHandler btnAIAyarlar.ItemClick, Sub(s, e)
            Dim frm As New frm_AIAyarlari()
            frm.ShowDialog()
        End Sub
        BarManager1.Items.Add(btnAIAyarlar)
        groupAyarlar.ItemLinks.Add(btnAIAyarlar)
        
        ' Grup 2: İşlemler
        Dim groupIslemler As New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        groupIslemler.Text = "İşlemler"
        
        Dim btnTekUrun As New DevExpress.XtraBars.BarButtonItem()
        btnTekUrun.Caption = "📦 Tek Ürün İşle"
        btnTekUrun.Id = BarManager1.GetNewItemId()
        AddHandler btnTekUrun.ItemClick, Sub(s, e)
            Dim frm As New frm_AIUrunIsle()
            frm.Show()
        End Sub
        BarManager1.Items.Add(btnTekUrun)
        groupIslemler.ItemLinks.Add(btnTekUrun)
        
        Dim btnTopluIslem As New DevExpress.XtraBars.BarButtonItem()
        btnTopluIslem.Caption = "🔥 Toplu İşlem"
        btnTopluIslem.Id = BarManager1.GetNewItemId()
        AddHandler btnTopluIslem.ItemClick, Sub(s, e)
            ' Stok liste formunu aç veya toplu işlem formunu direkt aç
            MessageBox.Show("Lütfen Stok Liste'den ürünleri seçip sağ tık menüsünden 'AI Toplu İşlem' seçeneğini kullanın.", _
                          "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        BarManager1.Items.Add(btnTopluIslem)
        groupIslemler.ItemLinks.Add(btnTopluIslem)
        
        ' Grup 3: Raporlar
        Dim groupRaporlar As New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        groupRaporlar.Text = "Raporlar"
        
        Dim btnRapor As New DevExpress.XtraBars.BarButtonItem()
        btnRapor.Caption = "📊 AI Kullanım Raporu"
        btnRapor.Id = BarManager1.GetNewItemId()
        AddHandler btnRapor.ItemClick, Sub(s, e)
            ' Rapor formu aç (ileride eklenebilir)
            MessageBox.Show("AI kullanım raporu yakında eklenecek!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        BarManager1.Items.Add(btnRapor)
        groupRaporlar.ItemLinks.Add(btnRapor)
        
        ' Grupları sayfaya ekle
        pageAI.Groups.Add(groupAyarlar)
        pageAI.Groups.Add(groupIslemler)
        pageAI.Groups.Add(groupRaporlar)
        
        ' Sayfayı ribbon'a ekle
        mainRibbon.Pages.Add(pageAI)
        
    Catch ex As Exception
        MessageBox.Show("AI menüsü eklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Try
End Sub

' ======================================================================
' BÖLÜM 4: KLAVYE KISAYOLU (Opsiyonel)
' ======================================================================

' Ana form'da KeyPreview = True yapın ve:
Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    ' Ctrl + Shift + A = AI Ayarları
    If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.A Then
        Dim frm As New frm_AIAyarlari()
        frm.ShowDialog()
        e.Handled = True
    End If
    
    ' Ctrl + Shift + I = AI Tek İşlem
    If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.I Then
        Dim frm As New frm_AIUrunIsle()
        frm.Show()
        e.Handled = True
    End If
End Sub

' ======================================================================
' KURULUM TALİMATLARI:
' ======================================================================
'
' frm_stok_liste.vb için:
' 1. GridView1_PopupMenuShowing event'ini ekleyin
' 2. Ribbon varsa AddAIButtonToRibbon() çağırın
'
' Ana menü formu için:
' 3. AddAIPageToMainRibbon() fonksiyonunu Form_Load'da çağırın
' 4. Ribbon kontrolü ve BarManager adlarını kontrol edin
'
' NOT: DevExpress kontrol adları projenize göre değişebilir!
' - RibbonControl1 → RibbonControl, ribbonControl vb. olabilir
' - BarManager1 → BarManager, barManager1 vb. olabilir
' - GridView1 → gridView1, GridView, gvStok vb. olabilir
'
' Kontrol adlarını projenize göre düzeltin!
' ======================================================================
