' ============================================================================
' TRENDYOL KATEGORİ SERVİSİ
' ============================================================================
' Kendi veritabanındaki ürünleri Trendyol'da arayarak kategori bilgisi çeker
' BARKOD KULLANILMIYOR - MARKA + ÜRÜN ADI İLE ARAMA YAPILIYOR
' ============================================================================

Imports System.Collections.Generic
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class TrendyolKategoriService
    
    Private Shared ReadOnly USER_AGENT As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36"
    
    ''' <summary>
    ''' Ürün adı ve marka ile Trendyol'da arama yaparak kategori bulur
    ''' KADEMEL ARAMA: Marka ile bulamazsa, marka olmadan dener
    ''' </summary>
    Public Shared Function GetKategorilerByBarkod(barkod As String, Optional urunAdi As String = "", Optional marka As String = "") As TrendyolKategoriSonuc
        Dim sonuc As New TrendyolKategoriSonuc()
        sonuc.Barkod = barkod
        
        Try
            ' TLS aktif et
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            ServicePointManager.ServerCertificateValidationCallback = Function(sender, cert, chain, errors) True
            
            ' Marka ve ürün adı boşsa hata ver
            If String.IsNullOrWhiteSpace(marka) AndAlso String.IsNullOrWhiteSpace(urunAdi) Then
                sonuc.Basarili = False
                sonuc.HataMesaji = "Marka veya ürün adı gerekli"
                Return sonuc
            End If
            
            ' KADEMEL ARAMA METINLERI OLUŞTUR
            Dim aramaListesi As List(Of String) = OlusturKademeliAramaListesi(marka, urunAdi)
            
            ' Debug log
            Try
                Dim logText As String = $"Barkod: {barkod}{vbCrLf}Marka: {marka}{vbCrLf}Ürün: {urunAdi}{vbCrLf}Arama Listesi:{vbCrLf}"
                For i As Integer = 0 To aramaListesi.Count - 1
                    logText &= $"  {i + 1}. {aramaListesi(i)}{vbCrLf}"
                Next
                IO.File.WriteAllText(IO.Path.Combine(IO.Path.GetTempPath(), "trendyol_arama.txt"), logText, Encoding.UTF8)
            Catch
            End Try
            
            ' Her arama metnini dene
            For Each aramaMetni As String In aramaListesi
                If String.IsNullOrWhiteSpace(aramaMetni) Then Continue For
                
                ' Trendyol'da ara
                Dim jsonSonuc As String = TrendyolArama(aramaMetni)
                
                If String.IsNullOrWhiteSpace(jsonSonuc) Then
                    Continue For
                End If
                
                ' İlk aramada marka ile eşleşen ürünü bul
                ' Sonraki aramalarda (marka olmadan) herhangi bir ürünün kategorisini al
                Dim aramaMarkasi As String = marka
                If Not aramaMetni.ToLower().Contains(marka.ToLower()) Then
                    ' Bu arama markasız, herhangi bir sonuç kabul
                    aramaMarkasi = ""
                End If
                
                Dim eslesenUrun As TrendyolUrunBilgi = BulEslesenUrun(jsonSonuc, aramaMarkasi, urunAdi)
                
                If eslesenUrun IsNot Nothing AndAlso eslesenUrun.Kategoriler.Count > 0 Then
                    ' Kategori bulundu!
                    sonuc.Basarili = True
                    sonuc.Marka = eslesenUrun.Marka
                    sonuc.UrunBaslik = eslesenUrun.UrunAdi
                    sonuc.UrunUrl = eslesenUrun.Url
                    sonuc.Kategoriler = eslesenUrun.Kategoriler
                    
                    If eslesenUrun.Kategoriler.Count > 0 Then sonuc.Kategori1 = eslesenUrun.Kategoriler(0)
                    If eslesenUrun.Kategoriler.Count > 1 Then sonuc.Kategori2 = eslesenUrun.Kategoriler(1)
                    If eslesenUrun.Kategoriler.Count > 2 Then sonuc.Kategori3 = eslesenUrun.Kategoriler(2)
                    If eslesenUrun.Kategoriler.Count > 3 Then sonuc.Kategori4 = eslesenUrun.Kategoriler(3)
                    If eslesenUrun.Kategoriler.Count > 4 Then sonuc.Kategori5 = eslesenUrun.Kategoriler(4)
                    
                    Return sonuc
                End If
                
                ' 2 saniye bekle sonraki arama için
                Thread.Sleep(2000)
            Next
            
            ' Hiçbir arama sonuç vermedi
            sonuc.Basarili = False
            sonuc.HataMesaji = $"Tüm arama denemeleri başarısız"
            
        Catch ex As Exception
            sonuc.Basarili = False
            sonuc.HataMesaji = $"Hata: {ex.Message}"
        End Try
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' Kademeli arama listesi oluştur
    ''' Örnek: "U.S.POLO KIZ BEBEK MONT" için:
    ''' 1. "U.S.POLO KIZ BEBEK MONT" (tam)
    ''' 2. "KIZ BEBEK MONT" (marka olmadan)
    ''' 3. "BEBEK MONT" (daha genel)
    ''' </summary>
    Private Shared Function OlusturKademeliAramaListesi(marka As String, urunAdi As String) As List(Of String)
        Dim liste As New List(Of String)
        
        If String.IsNullOrWhiteSpace(urunAdi) Then
            If Not String.IsNullOrWhiteSpace(marka) Then
                liste.Add(marka)
            End If
            Return liste
        End If
        
        ' Ürün adından kelimeleri ayır
        Dim kelimeler() As String = urunAdi.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim temizKelimeler As New List(Of String)
        
        For Each kelime As String In kelimeler
            If kelime.Length < 2 Then Continue For
            Dim kucuk As String = kelime.ToLower()
            If kucuk = "ve" OrElse kucuk = "veya" OrElse kucuk = "ile" OrElse kucuk = "için" Then
                Continue For
            End If
            temizKelimeler.Add(kelime)
        Next
        
        ' 1. TAM ARAMA: Tüm kelimeler (marka dahil, max 6 kelime)
        If temizKelimeler.Count > 0 Then
            Dim tamArama As String = String.Join(" ", temizKelimeler.GetRange(0, Math.Min(6, temizKelimeler.Count)))
            liste.Add(tamArama)
        End If
        
        ' 2. MARKA OLMADAN: Marka kelimesini çıkar (büyük/küçük harf duyarsız)
        If Not String.IsNullOrWhiteSpace(marka) AndAlso temizKelimeler.Count > 1 Then
            Dim markasizKelimeler As New List(Of String)
            Dim normalMarka As String = NormalizeText(marka)
            
            For Each kelime As String In temizKelimeler
                Dim normalKelime As String = NormalizeText(kelime)
                ' Marka kelimesini veya marka içeren kelimeyi atla (büyük/küçük harf duyarsız)
                If normalKelime <> normalMarka AndAlso Not normalMarka.Contains(normalKelime) AndAlso Not normalKelime.Contains(normalMarka) Then
                    markasizKelimeler.Add(kelime)
                End If
            Next
            
            If markasizKelimeler.Count > 0 Then
                Dim markasizArama As String = String.Join(" ", markasizKelimeler.GetRange(0, Math.Min(5, markasizKelimeler.Count)))
                Dim normalMarkasiz As String = NormalizeText(markasizArama)
                Dim normalTam As String = NormalizeText(liste(0))
                If normalMarkasiz <> normalTam Then ' Aynı değilse ekle (büyük/küçük harf duyarsız kontrol)
                    liste.Add(markasizArama)
                End If
            End If
        End If
        
        ' 3. DAHA GENEL: Son 2-3 kelime (genellikle ürün tipi)
        If temizKelimeler.Count > 2 Then
            Dim sonKelimeler As Integer = Math.Min(3, temizKelimeler.Count - 1)
            Dim genelArama As String = String.Join(" ", temizKelimeler.GetRange(temizKelimeler.Count - sonKelimeler, sonKelimeler))
            Dim normalGenel As String = NormalizeText(genelArama)
            Dim listedeVar As Boolean = False
            For Each mevcutArama As String In liste
                If NormalizeText(mevcutArama) = normalGenel Then
                    listedeVar = True
                    Exit For
                End If
            Next
            If Not listedeVar Then
                liste.Add(genelArama)
            End If
        End If
        
        ' 4. EN GENEL: Son 2 kelime
        If temizKelimeler.Count > 2 Then
            Dim enGenelArama As String = String.Join(" ", temizKelimeler.GetRange(temizKelimeler.Count - 2, 2))
            Dim normalEnGenel As String = NormalizeText(enGenelArama)
            Dim listedeVar As Boolean = False
            For Each mevcutArama As String In liste
                If NormalizeText(mevcutArama) = normalEnGenel Then
                    listedeVar = True
                    Exit For
                End If
            Next
            If Not listedeVar Then
                liste.Add(enGenelArama)
            End If
        End If
        
        Return liste
    End Function
    
    Private Shared Function IsNumeric(text As String) As Boolean
        Dim num As Double
        Return Double.TryParse(text, num)
    End Function
    
    ''' <summary>
    ''' Trendyol'da arama yap
    ''' </summary>
    Private Shared Function TrendyolArama(aramaMetni As String) As String
        Try
            Dim encodedArama As String = Uri.EscapeDataString(aramaMetni)
            Dim apiUrl As String = $"https://apigw.trendyol.com/discovery-web-searchgw-service/v2/api/infinite-scroll/sr?q={encodedArama}&qt={encodedArama}&st={encodedArama}&os=1&culture=tr-TR"
            
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
            request.Method = "GET"
            request.UserAgent = USER_AGENT
            request.Accept = "application/json"
            request.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9")
            request.Referer = "https://www.trendyol.com/"
            request.Headers.Add("Origin", "https://www.trendyol.com")
            request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
            request.Timeout = 30000
            
            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream(), Encoding.UTF8)
                    Dim json As String = reader.ReadToEnd()
                    
                    ' Debug
                    Try
                        IO.File.WriteAllText(IO.Path.Combine(IO.Path.GetTempPath(), "trendyol_api.json"), json, Encoding.UTF8)
                    Catch
                    End Try
                    
                    Return json
                End Using
            End Using
        Catch
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' JSON'dan marka ile eşleşen ürünü bul
    ''' Marka boşsa, aynı kategorideki herhangi bir ürünün bilgilerini al (genel arama için)
    ''' BÜYÜK/KÜÇÜK HARF DUYARSIZ + RENK KELİMELERİ YOKSAYILIR
    ''' </summary>
    Private Shared Function BulEslesenUrun(json As String, aramaMarka As String, aramaUrunAdi As String) As TrendyolUrunBilgi
        Try
            ' Normalize marka (nokta/boşluk yok) ve ürün adı
            Dim normalMarka As String = NormalizeMarka(aramaMarka)
            Dim normalUrun As String = NormalizeText(RenklereCikar(aramaUrunAdi))
            
            ' Marka boşsa, herhangi bir ürünün kategorisini al
            Dim markaZorunlu As Boolean = Not String.IsNullOrWhiteSpace(normalMarka)
            
            Dim bestMatch As TrendyolUrunBilgi = Nothing
            Dim bestScore As Integer = 0
            
            ' Basit parse: brand.name ve categoryHierarchy
            Dim brandPattern As String = """brand""\s*:\s*\{[^}]*""name""\s*:\s*""([^""]+)"""
            Dim catPattern As String = """categoryHierarchy""\s*:\s*""([^""]+)"""
            Dim namePattern As String = """name""\s*:\s*""([^""]+)"""
            Dim urlPattern As String = """url""\s*:\s*""(/[^""]+p-\d+[^""]*)"""
            
            Dim brandMatches As MatchCollection = Regex.Matches(json, brandPattern, RegexOptions.IgnoreCase)
            Dim catMatches As MatchCollection = Regex.Matches(json, catPattern, RegexOptions.IgnoreCase)
            Dim nameMatches As MatchCollection = Regex.Matches(json, namePattern, RegexOptions.IgnoreCase)
            Dim urlMatches As MatchCollection = Regex.Matches(json, urlPattern, RegexOptions.IgnoreCase)
            
            Dim minCount As Integer = Math.Min(brandMatches.Count, Math.Min(catMatches.Count, Math.Min(nameMatches.Count, urlMatches.Count)))
            
            For i As Integer = 0 To Math.Min(minCount - 1, 30)
                Dim bulunanMarka As String = brandMatches(i).Groups(1).Value
                Dim normalBulunan As String = NormalizeMarka(bulunanMarka)
                
                Dim score As Integer = 0
                
                If markaZorunlu Then
                    ' MARKA KONTROLÜ (nokta/boşluk olmadan karşılaştır)
                    ' "uspoloassn" = "uspoloassn" 
                    If normalBulunan = normalMarka Then
                        score = 100
                    ' İçerme kontrolü
                    ElseIf normalBulunan.Contains(normalMarka) OrElse normalMarka.Contains(normalBulunan) Then
                        score = 75
                    ' Kelime bazlı kontrol - en az 3 karakter eşleşsin
                    Else
                        Dim markaKelimeler() As String = normalMarka.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                        For Each kelime As String In markaKelimeler
                            If kelime.Length >= 2 AndAlso normalBulunan.Contains(kelime) Then
                                score += 30
                            End If
                        Next
                        ' Ayrıca ters kontrol - bulunan markanın kelimeleri bizim markada var mı
                        If score < 50 Then
                            Dim bulunanKelimeler() As String = normalBulunan.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                            For Each kelime As String In bulunanKelimeler
                                If kelime.Length >= 3 AndAlso normalMarka.Contains(kelime) Then
                                    score += 20
                                End If
                            Next
                        End If
                    End If
                Else
                    ' MARKA KONTROLÜ YOK - aynı kategorideki herhangi bir ürünü al
                    score = 50
                End If
                
                ' Ürün adı eşleşme bonus (renksiz karşılaştır)
                If Not String.IsNullOrWhiteSpace(normalUrun) Then
                    Dim bulunanUrun As String = NormalizeText(RenklereCikar(nameMatches(i).Groups(1).Value))
                    Dim urunKelimeler() As String = normalUrun.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                    For Each kelime As String In urunKelimeler
                        If kelime.Length >= 3 AndAlso bulunanUrun.Contains(kelime) Then
                            score += 5
                        End If
                    Next
                End If
                
                If score > bestScore Then
                    bestScore = score
                    
                    bestMatch = New TrendyolUrunBilgi()
                    bestMatch.Marka = bulunanMarka
                    bestMatch.UrunAdi = nameMatches(i).Groups(1).Value
                    bestMatch.Url = "https://www.trendyol.com" & urlMatches(i).Groups(1).Value
                    
                    ' Kategori yolunu parse et
                    Dim catPath As String = catMatches(i).Groups(1).Value
                    Dim catParts() As String = catPath.Split("/"c)
                    bestMatch.Kategoriler = New List(Of String)
                    For Each part As String In catParts
                        Dim cleanPart As String = part.Trim()
                        If Not String.IsNullOrWhiteSpace(cleanPart) Then
                            bestMatch.Kategoriler.Add(cleanPart)
                        End If
                    Next
                End If
                
                ' Marka kontrolü yoksa ve en az bir ürün bulduysa, en iyi eşleşmeyi al
                If Not markaZorunlu AndAlso bestMatch IsNot Nothing AndAlso i >= 5 Then
                    Exit For
                End If
            Next
            
            ' Minimum skor kontrolü - sadece marka zorunluysa uygula (eşik düşürüldü)
            If markaZorunlu AndAlso bestScore < 20 Then
                Return Nothing
            End If
            
            ' Marka zorunlu değilse, en düşük skorlu eşleşmeyi bile kabul et
            Return bestMatch
            
        Catch
        End Try
        
        Return Nothing
    End Function
    
    Private Shared Function NormalizeText(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then Return ""
        Dim result As String = text.ToLower().Trim()
        ' Türkçe karakterleri dönüştür
        result = result.Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u")
        result = result.Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")
        result = result.Replace("İ", "i").Replace("Ğ", "g").Replace("Ü", "u")
        result = result.Replace("Ş", "s").Replace("Ö", "o").Replace("Ç", "c")
        ' Nokta ve özel karakterleri kaldır (U.S.POLO = USPOLO = US POLO)
        result = result.Replace(".", "").Replace("-", " ").Replace("_", " ")
        ' Çoklu boşlukları tek boşluğa indir
        While result.Contains("  ")
            result = result.Replace("  ", " ")
        End While
        Return result.Trim()
    End Function
    
    ''' <summary>
    ''' Marka karşılaştırması için normalize et
    ''' "U.S. Polo Assn" = "U.S.POLO ASSN" = "US POLO ASSN"
    ''' </summary>
    Private Shared Function NormalizeMarka(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then Return ""
        Dim result As String = NormalizeText(text)
        ' Boşlukları da kaldır - sadece harfler kalsın
        result = result.Replace(" ", "")
        Return result
    End Function
    
    ''' <summary>
    ''' Renk kelimelerini çıkar
    ''' </summary>
    Private Shared Function RenklereCikar(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then Return ""
        Dim result As String = text
        Dim renkler() As String = {"beyaz", "siyah", "kirmizi", "mavi", "yesil", "sari", "turuncu", 
                                    "mor", "pembe", "gri", "kahverengi", "lacivert", "bej", "krem",
                                    "bordo", "antrasit", "ekru", "fuşya", "turkuaz", "haki",
                                    "white", "black", "red", "blue", "green", "yellow", "orange",
                                    "purple", "pink", "gray", "grey", "brown", "navy", "beige"}
        For Each renk As String In renkler
            result = Regex.Replace(result, "\b" & renk & "\b", "", RegexOptions.IgnoreCase)
        Next
        ' Çoklu boşlukları temizle
        While result.Contains("  ")
            result = result.Replace("  ", " ")
        End While
        Return result.Trim()
    End Function
    
End Class

''' <summary>
''' Trendyol'dan bulunan ürün bilgisi
''' </summary>
Public Class TrendyolUrunBilgi
    Public Property Barkod As String = ""
    Public Property Marka As String = ""
    Public Property UrunAdi As String = ""
    Public Property Url As String = ""
    Public Property Kategoriler As New List(Of String)
End Class

Public Class TrendyolUrun
    Public Property Url As String = ""
    Public Property UrunAdi As String = ""
    Public Property Marka As String = ""
    Public Property KategoriHierarchy As String = ""
End Class

Public Class TrendyolKategoriSonuc
    Public Property Barkod As String = ""
    Public Property Basarili As Boolean = False
    Public Property HataMesaji As String = ""
    Public Property UrunUrl As String = ""
    Public Property UrunBaslik As String = ""
    Public Property Marka As String = ""
    Private _kategoriler As List(Of String)
    
    Public Sub New()
        _kategoriler = New List(Of String)
    End Sub
    
    Public Property Kategoriler As List(Of String)
        Get
            Return _kategoriler
        End Get
        Set(value As List(Of String))
            _kategoriler = New List(Of String)
            If value IsNot Nothing Then
                _kategoriler.AddRange(value)
            End If
        End Set
    End Property
    
    Public Property Kategori1 As String = ""
    Public Property Kategori2 As String = ""
    Public Property Kategori3 As String = ""
    Public Property Kategori4 As String = ""
    Public Property Kategori5 As String = ""
    
    Public Sub Clear()
        Barkod = ""
        Basarili = False
        HataMesaji = ""
        UrunUrl = ""
        UrunBaslik = ""
        Marka = ""
        _kategoriler.Clear()
        Kategori1 = ""
        Kategori2 = ""
        Kategori3 = ""
        Kategori4 = ""
        Kategori5 = ""
    End Sub
    
    Public ReadOnly Property UrunAdi As String
        Get
            Return UrunBaslik
        End Get
    End Property
    
    Public ReadOnly Property KategoriYolu As String
        Get
            Return String.Join(" > ", _kategoriler)
        End Get
    End Property
End Class
