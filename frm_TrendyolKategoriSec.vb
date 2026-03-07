' ============================================
' TRENDYOL KATEGORİ SEÇİM FORMU
' Dosya: frm_TrendyolKategoriSec.vb
' Tarih: 2026-01-30
' Açıklama: Trendyol URL'den veya listeden kategori seçimi
' ============================================

Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Linq

''' <summary>
''' Kategori bilgisi icin yardimci sinif
''' </summary>
Public Class KategoriBilgisi
    Public Property Id As String
    Public Property Ad As String
    Public Property Hiyerarsi As String
    Public Property UrunSayisi As Integer
End Class

Public Class frm_TrendyolKategoriSec
    Inherits Form
    
    Public connection As String = ""
    Public SecilenKategoriId As String = ""
    Public SecilenKategoriAd As String = ""
    
    Private _kategoriler As List(Of TrendyolCategory)
    Private WithEvents grp_TrendyolAra As GroupBox
    Private WithEvents txt_AramaKelimesi As TextBox
    Private WithEvents btn_TrendyoldaAra As Button
    Private WithEvents lst_BulunanKategoriler As ListBox
    Private WithEvents lbl_AramaBilgi As Label
    Private WithEvents grp_URL As GroupBox
    Private WithEvents txt_TrendyolURL As TextBox
    Private WithEvents btn_URLdenAl As Button
    Private WithEvents lbl_URLBilgi As Label
    Private WithEvents grp_Liste As GroupBox
    Private WithEvents txt_Ara As TextBox
    Private WithEvents lst_Kategoriler As ListBox
    Private WithEvents btn_Sec As Button
    Private WithEvents btn_Iptal As Button
    Private WithEvents lbl_Status As Label
    
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.grp_URL = New GroupBox()
        Me.txt_TrendyolURL = New TextBox()
        Me.btn_URLdenAl = New Button()
        Me.lbl_URLBilgi = New Label()
        Me.grp_Liste = New GroupBox()
        Me.txt_Ara = New TextBox()
        Me.lst_Kategoriler = New ListBox()
        Me.btn_Sec = New Button()
        Me.btn_Iptal = New Button()
        Me.lbl_Status = New Label()
        Me.grp_TrendyolAra = New GroupBox()
        Me.txt_AramaKelimesi = New TextBox()
        Me.btn_TrendyoldaAra = New Button()
        Me.lst_BulunanKategoriler = New ListBox()
        Me.lbl_AramaBilgi = New Label()
        Me.SuspendLayout()
        
        ' grp_TrendyolAra - Trendyol'da Ara (EN KOLAY YONTEM)
        Me.grp_TrendyolAra.Location = New Point(12, 12)
        Me.grp_TrendyolAra.Size = New Size(560, 180)
        Me.grp_TrendyolAra.Text = "1. YONTEM: Trendyol'da Benzer Urun Ara (ONERILEN)"
        Me.grp_TrendyolAra.Font = New Font("Tahoma", 9.0!, FontStyle.Bold)
        Me.grp_TrendyolAra.ForeColor = Color.Green
        
        ' lbl_AramaBilgi
        Me.lbl_AramaBilgi.Location = New Point(10, 22)
        Me.lbl_AramaBilgi.Size = New Size(540, 15)
        Me.lbl_AramaBilgi.Text = "Urun tipini yazin (ornek: bermuda takim, sort, tisort):"
        Me.lbl_AramaBilgi.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.lbl_AramaBilgi.ForeColor = Color.Black
        Me.grp_TrendyolAra.Controls.Add(Me.lbl_AramaBilgi)
        
        ' txt_AramaKelimesi
        Me.txt_AramaKelimesi.Location = New Point(10, 40)
        Me.txt_AramaKelimesi.Size = New Size(430, 20)
        Me.txt_AramaKelimesi.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.txt_AramaKelimesi.Text = "bermuda takim"
        Me.grp_TrendyolAra.Controls.Add(Me.txt_AramaKelimesi)
        
        ' btn_TrendyoldaAra
        Me.btn_TrendyoldaAra.Location = New Point(450, 38)
        Me.btn_TrendyoldaAra.Size = New Size(100, 25)
        Me.btn_TrendyoldaAra.Text = "Ara"
        Me.btn_TrendyoldaAra.BackColor = Color.FromArgb(0, 150, 50)
        Me.btn_TrendyoldaAra.ForeColor = Color.White
        Me.btn_TrendyoldaAra.FlatStyle = FlatStyle.Flat
        Me.btn_TrendyoldaAra.Font = New Font("Tahoma", 8.25!, FontStyle.Bold)
        Me.grp_TrendyolAra.Controls.Add(Me.btn_TrendyoldaAra)
        
        ' lst_BulunanKategoriler
        Me.lst_BulunanKategoriler.Location = New Point(10, 68)
        Me.lst_BulunanKategoriler.Size = New Size(540, 100)
        Me.lst_BulunanKategoriler.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_TrendyolAra.Controls.Add(Me.lst_BulunanKategoriler)
        
        ' grp_URL - URL'den Kategori Al
        Me.grp_URL.Location = New Point(12, 200)
        Me.grp_URL.Size = New Size(560, 80)
        Me.grp_URL.Text = "2. YONTEM: Trendyol URL'den Al"
        Me.grp_URL.Font = New Font("Tahoma", 9.0!, FontStyle.Bold)
        
        ' lbl_URLBilgi
        Me.lbl_URLBilgi.Location = New Point(10, 22)
        Me.lbl_URLBilgi.Size = New Size(540, 15)
        Me.lbl_URLBilgi.Text = "Trendyol kategori URL'si yapistirin (ornek: .../erkek-sort-x-g2-c530):"
        Me.lbl_URLBilgi.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_URL.Controls.Add(Me.lbl_URLBilgi)
        
        ' txt_TrendyolURL
        Me.txt_TrendyolURL.Location = New Point(10, 42)
        Me.txt_TrendyolURL.Size = New Size(430, 20)
        Me.txt_TrendyolURL.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_URL.Controls.Add(Me.txt_TrendyolURL)
        
        ' btn_URLdenAl
        Me.btn_URLdenAl.Location = New Point(450, 40)
        Me.btn_URLdenAl.Size = New Size(100, 25)
        Me.btn_URLdenAl.Text = "Kategori Al"
        Me.btn_URLdenAl.BackColor = Color.FromArgb(76, 175, 80)
        Me.btn_URLdenAl.ForeColor = Color.White
        Me.btn_URLdenAl.FlatStyle = FlatStyle.Flat
        Me.btn_URLdenAl.Font = New Font("Tahoma", 8.25!, FontStyle.Bold)
        Me.grp_URL.Controls.Add(Me.btn_URLdenAl)
        
        ' grp_Liste - Listeden Seç
        Me.grp_Liste.Location = New Point(12, 288)
        Me.grp_Liste.Size = New Size(560, 160)
        Me.grp_Liste.Text = "3. YONTEM: Tum Kategorilerden Sec"
        Me.grp_Liste.Font = New Font("Tahoma", 9.0!, FontStyle.Bold)
        
        ' txt_Ara
        Me.txt_Ara.Location = New Point(10, 22)
        Me.txt_Ara.Size = New Size(540, 20)
        Me.txt_Ara.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Liste.Controls.Add(Me.txt_Ara)
        
        ' lst_Kategoriler
        Me.lst_Kategoriler.Location = New Point(10, 47)
        Me.lst_Kategoriler.Size = New Size(540, 105)
        Me.lst_Kategoriler.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Liste.Controls.Add(Me.lst_Kategoriler)
        
        ' btn_Sec
        Me.btn_Sec.Location = New Point(370, 458)
        Me.btn_Sec.Size = New Size(100, 30)
        Me.btn_Sec.Text = "Seç ve Uygula"
        Me.btn_Sec.BackColor = Color.FromArgb(0, 122, 204)
        Me.btn_Sec.ForeColor = Color.White
        Me.btn_Sec.FlatStyle = FlatStyle.Flat
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New Point(480, 458)
        Me.btn_Iptal.Size = New Size(90, 30)
        Me.btn_Iptal.Text = "Iptal"
        
        ' lbl_Status
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New Point(12, 466)
        Me.lbl_Status.Size = New Size(300, 13)
        Me.lbl_Status.Text = "Kategoriler yukleniyor..."
        
        ' Form
        Me.ClientSize = New Size(584, 500)
        Me.Controls.Add(Me.grp_TrendyolAra)
        Me.Controls.Add(Me.grp_URL)
        Me.Controls.Add(Me.grp_Liste)
        Me.Controls.Add(Me.btn_Sec)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.lbl_Status)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Trendyol Kategori Seç - BuyBox İçin"
        
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    
    Private Sub frm_TrendyolKategoriSec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub
    
    Private Async Sub LoadCategories()
        Try
            If Not TrendyolAPI.Instance.IsConfigured Then
                lbl_Status.Text = "API yapılandırılmamış!"
                lbl_Status.ForeColor = Color.Red
                Return
            End If
            
            lbl_Status.Text = "Kategoriler yükleniyor..."
            lbl_Status.ForeColor = Color.Blue
            
            Dim result As ApiResult(Of List(Of TrendyolCategory)) = Await TrendyolAPI.Instance.GetCategoriesAsync()
            
            If result.Success AndAlso result.Data IsNot Nothing Then
                _kategoriler = result.Data
                FillCategoryList("")
                lbl_Status.Text = _kategoriler.Count.ToString() & " kategori yüklendi"
                lbl_Status.ForeColor = Color.Green
            Else
                lbl_Status.Text = "Hata: " & result.ErrorMessage
                lbl_Status.ForeColor = Color.Red
            End If
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
        End Try
    End Sub
    
    Private Sub FillCategoryList(filter As String)
        lst_Kategoriler.Items.Clear()
        
        If _kategoriler Is Nothing Then Return
        
        Dim filteredList As List(Of TrendyolCategory)
        
        If String.IsNullOrWhiteSpace(filter) Then
            filteredList = _kategoriler
        Else
            filter = filter.ToLower()
            filteredList = New List(Of TrendyolCategory)
            For Each cat As TrendyolCategory In _kategoriler
                If cat.Name IsNot Nothing AndAlso cat.Name.ToLower().Contains(filter) Then
                    filteredList.Add(cat)
                End If
            Next
        End If
        
        For Each cat As TrendyolCategory In filteredList
            lst_Kategoriler.Items.Add(cat.Id.ToString() & " - " & cat.Name)
        Next
    End Sub
    
    Private Sub txt_Ara_TextChanged(sender As Object, e As EventArgs) Handles txt_Ara.TextChanged
        FillCategoryList(txt_Ara.Text)
    End Sub
    
    ''' <summary>
    ''' Trendyol'da anahtar kelime ile arama yap ve kullanilan kategorileri bul
    ''' </summary>
    Private Async Sub btn_TrendyoldaAra_Click(sender As Object, e As EventArgs) Handles btn_TrendyoldaAra.Click
        Dim aramaKelimesi As String = txt_AramaKelimesi.Text.Trim()
        
        If String.IsNullOrEmpty(aramaKelimesi) Then
            MessageBox.Show("Lutfen bir arama kelimesi girin (ornek: bermuda takim)", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        lst_BulunanKategoriler.Items.Clear()
        lbl_Status.Text = "Trendyol'da araniyor: " & aramaKelimesi & "..."
        lbl_Status.ForeColor = Color.Blue
        btn_TrendyoldaAra.Enabled = False
        Application.DoEvents()
        
        Try
            ' Public API ile ara
            Dim publicClient As New System.Net.Http.HttpClient()
            publicClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
            publicClient.DefaultRequestHeaders.Add("Accept", "application/json")
            
            ' URL encode
            Dim encodedQuery As String = System.Uri.EscapeDataString(aramaKelimesi)
            Dim apiUrl As String = "https://apigw.trendyol.com/discovery-web-searchgw-service/v2/api/infinite-scroll/sr?q=" & encodedQuery
            
            Dim response As System.Net.Http.HttpResponseMessage = Await publicClient.GetAsync(apiUrl)
            Dim content As String = Await response.Content.ReadAsStringAsync()
            
            If response.StatusCode = System.Net.HttpStatusCode.OK Then
                ' JSON'dan kategorileri cikart
                Dim kategoriler As New Dictionary(Of String, KategoriBilgisi)()
                
                ' categoryId pattern
                Dim productPattern As String = """categoryId"":(\d+).*?""categoryName"":""([^""]*)""|""categoryName"":""([^""]*)"".*?""categoryId"":(\d+)"
                Dim catIdPattern As String = """categoryId"":(\d+)"
                Dim catNamePattern As String = """categoryName"":""([^""]*)"""
                Dim catHierPattern As String = """categoryHierarchy"":""([^""]*)"""
                
                ' Basit parsing - categoryId ve categoryName eslesmeleri
                Dim idMatches As MatchCollection = Regex.Matches(content, catIdPattern)
                Dim nameMatches As MatchCollection = Regex.Matches(content, catNamePattern)
                Dim hierMatches As MatchCollection = Regex.Matches(content, catHierPattern)
                
                ' ID'leri ve isimleri eslestir
                Dim i As Integer = 0
                For Each idMatch As Match In idMatches
                    Dim catId As String = idMatch.Groups(1).Value
                    Dim catName As String = ""
                    Dim catHier As String = ""
                    
                    If i < nameMatches.Count Then
                        catName = nameMatches(i).Groups(1).Value
                    End If
                    
                    If i < hierMatches.Count Then
                        catHier = hierMatches(i).Groups(1).Value
                    End If
                    
                    If Not String.IsNullOrEmpty(catId) AndAlso Not kategoriler.ContainsKey(catId) Then
                        Dim bilgi As New KategoriBilgisi()
                        bilgi.Id = catId
                        bilgi.Ad = catName
                        bilgi.Hiyerarsi = catHier
                        bilgi.UrunSayisi = 1
                        kategoriler.Add(catId, bilgi)
                    ElseIf kategoriler.ContainsKey(catId) Then
                        kategoriler(catId).UrunSayisi += 1
                    End If
                    
                    i += 1
                Next
                
                ' Sonuclari listele (urun sayisina gore sirali)
                Dim siraliKategoriler As List(Of KategoriBilgisi) = kategoriler.Values.ToList()
                siraliKategoriler.Sort(Function(a, b) b.UrunSayisi.CompareTo(a.UrunSayisi))
                
                For Each kat As KategoriBilgisi In siraliKategoriler
                    Dim gosterilecek As String = kat.Id & " - "
                    If Not String.IsNullOrEmpty(kat.Hiyerarsi) Then
                        gosterilecek = gosterilecek & kat.Hiyerarsi
                    Else
                        gosterilecek = gosterilecek & kat.Ad
                    End If
                    gosterilecek = gosterilecek & " (" & kat.UrunSayisi.ToString() & " urun)"
                    lst_BulunanKategoriler.Items.Add(gosterilecek)
                Next
                
                If kategoriler.Count > 0 Then
                    lbl_Status.Text = kategoriler.Count.ToString() & " farkli kategori bulundu. En cok kullanilani secin."
                    lbl_Status.ForeColor = Color.Green
                Else
                    lbl_Status.Text = "Kategori bulunamadi. Farkli kelimelerle deneyin."
                    lbl_Status.ForeColor = Color.Orange
                End If
            Else
                lbl_Status.Text = "Arama hatasi: HTTP " & CInt(response.StatusCode).ToString()
                lbl_Status.ForeColor = Color.Red
            End If
            
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
        Finally
            btn_TrendyoldaAra.Enabled = True
        End Try
    End Sub
    
    ''' <summary>
    ''' Bulunan kategorilerden secim
    ''' </summary>
    Private Sub lst_BulunanKategoriler_DoubleClick(sender As Object, e As EventArgs) Handles lst_BulunanKategoriler.DoubleClick
        If lst_BulunanKategoriler.SelectedIndex >= 0 Then
            Dim selected As String = lst_BulunanKategoriler.SelectedItem.ToString()
            ' Format: "530 - Giyim/Alt Giyim/Sort & Bermuda (5 urun)"
            Dim parts() As String = selected.Split(New String() {" - "}, 2, StringSplitOptions.None)
            
            If parts.Length >= 1 Then
                SecilenKategoriId = parts(0).Trim()
                
                If parts.Length >= 2 Then
                    ' " (5 urun)" kismini kaldir
                    Dim adPart As String = parts(1)
                    Dim parantezIndex As Integer = adPart.LastIndexOf(" (")
                    If parantezIndex > 0 Then
                        SecilenKategoriAd = adPart.Substring(0, parantezIndex)
                    Else
                        SecilenKategoriAd = adPart
                    End If
                Else
                    SecilenKategoriAd = "Kategori " & SecilenKategoriId
                End If
                
                Dim sonuc As DialogResult = MessageBox.Show( _
                    "Secilen Kategori:" & vbCrLf & vbCrLf & _
                    "ID: " & SecilenKategoriId & vbCrLf & _
                    "Ad: " & SecilenKategoriAd & vbCrLf & vbCrLf & _
                    "Bu kategoriyi urunlere uygulamak istiyor musunuz?", _
                    "Kategori Secildi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                
                If sonuc = DialogResult.Yes Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If
        End If
    End Sub
    
    Private Sub btn_URLdenAl_Click(sender As Object, e As EventArgs) Handles btn_URLdenAl.Click
        ' Trendyol URL'den kategori ID çıkar
        ' Kategori URL Örneği: https://www.trendyol.com/erkek-sort-x-g2-c1182
        ' Ürün URL Örneği: https://www.trendyol.com/marka/urun-adi-p-1094108169
        
        Dim url As String = txt_TrendyolURL.Text.Trim()
        
        If String.IsNullOrEmpty(url) Then
            MessageBox.Show("Lutfen Trendyol URL'sini yapistirin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' URL'den kategori ID'sini çıkar
        ' Pattern 1: Kategori URL'si -c(\d+) veya /c(\d+)
        Dim pattern As String = "-c(\d+)"
        Dim match As Match = Regex.Match(url, pattern)
        
        If match.Success Then
            SecilenKategoriId = match.Groups(1).Value
            KategoriBulundu()
            Return
        End If
        
        ' Pattern 2: categoryId parametresi
        pattern = "categoryId[=:](\d+)"
        match = Regex.Match(url, pattern)
        
        If match.Success Then
            SecilenKategoriId = match.Groups(1).Value
            KategoriBulundu()
            Return
        End If
        
        ' Pattern 3: Ürün URL'si - p-(\d+) ile ürün ID'si var
        ' Bu durumda Public API ile ürün kategorisini bulacağız
        pattern = "-p-(\d+)"
        match = Regex.Match(url, pattern)
        
        If match.Success Then
            Dim productId As String = match.Groups(1).Value
            lbl_Status.Text = "Urun sayfasindan kategori alinıyor..."
            lbl_Status.ForeColor = Color.Blue
            Application.DoEvents()
            
            ' Ürün URL'sinden kategori almak için Public API kullan
            GetCategoryFromProductUrl(url, productId)
            Return
        End If
        
        ' Hiçbir pattern eşleşmedi
        MessageBox.Show( _
            "URL'den kategori ID'si cikarilamadi." & vbCrLf & vbCrLf & _
            "Desteklenen URL formatlari:" & vbCrLf & _
            "1. Kategori: https://www.trendyol.com/erkek-sort-x-g2-c1182" & vbCrLf & _
            "2. Urun: https://www.trendyol.com/marka/urun-adi-p-123456" & vbCrLf & vbCrLf & _
            "Veya asagidaki listeden manuel secim yapin.", _
            "URL Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    
    Private Sub KategoriBulundu()
        ' Kategori adını bul
        SecilenKategoriAd = "Kategori " & SecilenKategoriId
        If _kategoriler IsNot Nothing Then
            For Each cat As TrendyolCategory In _kategoriler
                If cat.Id.ToString() = SecilenKategoriId Then
                    SecilenKategoriAd = cat.Name
                    Exit For
                End If
            Next
        End If
        
        lbl_Status.Text = "Kategori bulundu: " & SecilenKategoriId & " - " & SecilenKategoriAd
        lbl_Status.ForeColor = Color.Green
        
        Dim sonuc As DialogResult = MessageBox.Show( _
            "Bulunan Kategori:" & vbCrLf & vbCrLf & _
            "ID: " & SecilenKategoriId & vbCrLf & _
            "Ad: " & SecilenKategoriAd & vbCrLf & vbCrLf & _
            "Bu kategoriyi secili urunlere uygulamak istiyor musunuz?", _
            "Kategori Bulundu", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If sonuc = DialogResult.Yes Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
    
    Private Async Sub GetCategoryFromProductUrl(url As String, productId As String)
        Try
            ' Trendyol product sayfasından kategori bilgisini çekmek için
            ' Public API'yi kullanarak ürün bilgilerini alalım
            
            ' URL'den ürün adını çıkar ve arama yap
            Dim urlParts() As String = url.Split(New Char() {"/"c, "-"c, "?"c}, StringSplitOptions.RemoveEmptyEntries)
            Dim searchQuery As String = productId
            
            ' Public API ile ara
            Dim publicClient As New System.Net.Http.HttpClient()
            publicClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
            publicClient.DefaultRequestHeaders.Add("Accept", "application/json")
            
            ' Content ID ile arama dene
            Dim apiUrl As String = "https://apigw.trendyol.com/discovery-web-productgw-service/api/productDetail/" & productId
            
            Try
                Dim response As System.Net.Http.HttpResponseMessage = Await publicClient.GetAsync(apiUrl)
                Dim content As String = Await response.Content.ReadAsStringAsync()
                
                If response.StatusCode = System.Net.HttpStatusCode.OK Then
                    ' JSON'dan kategori ID'sini çıkar
                    ' categoryId pattern
                    Dim catPattern As String = """categoryId"":(\d+)"
                    Dim catMatch As Match = Regex.Match(content, catPattern)
                    
                    If catMatch.Success Then
                        SecilenKategoriId = catMatch.Groups(1).Value
                        KategoriBulundu()
                        Return
                    End If
                    
                    ' category pattern
                    catPattern = """category"":\s*\{[^}]*""id"":(\d+)"
                    catMatch = Regex.Match(content, catPattern)
                    
                    If catMatch.Success Then
                        SecilenKategoriId = catMatch.Groups(1).Value
                        KategoriBulundu()
                        Return
                    End If
                End If
            Catch ex As Exception
                ' API hatası - devam et
            End Try
            
            ' API çalışmazsa kullanıcıya bilgi ver
            lbl_Status.Text = "Urun sayfasindan kategori alinamadi"
            lbl_Status.ForeColor = Color.Orange
            
            MessageBox.Show( _
                "Urun sayfasindan kategori otomatik alinamadi." & vbCrLf & vbCrLf & _
                "COZUM: Trendyol'da bu urunun sayfasina gidin," & vbCrLf & _
                "sol taraftaki KATEGORI linkine tiklayin," & vbCrLf & _
                "acilan kategori sayfasinin URL'sini buraya yapistirin." & vbCrLf & vbCrLf & _
                "Ornek kategori URL'si:" & vbCrLf & _
                "https://www.trendyol.com/erkek-sort-x-g2-c1182", _
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
        End Try
    End Sub
    
    Private Sub btn_Sec_Click(sender As Object, e As EventArgs) Handles btn_Sec.Click
        If lst_Kategoriler.SelectedIndex < 0 Then
            MessageBox.Show("Lütfen listeden bir kategori seçin veya URL'den kategori alın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim selected As String = lst_Kategoriler.SelectedItem.ToString()
        Dim parts() As String = selected.Split(New String() {" - "}, 2, StringSplitOptions.None)
        
        If parts.Length >= 2 Then
            SecilenKategoriId = parts(0).Trim()
            SecilenKategoriAd = parts(1).Trim()
        End If
        
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    
    Private Sub btn_Iptal_Click(sender As Object, e As EventArgs) Handles btn_Iptal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    
    Private Sub lst_Kategoriler_DoubleClick(sender As Object, e As EventArgs) Handles lst_Kategoriler.DoubleClick
        btn_Sec_Click(sender, e)
    End Sub
    
End Class
