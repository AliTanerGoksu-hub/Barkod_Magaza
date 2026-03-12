' ============================================================================
' TRENDYOL BARKOD BAZLI KATEGORİ SERVİSİ
' ============================================================================
' BARKOD ile Trendyol'da TAM EŞLEŞME yaparak kategori çeker
' Rakiplerin kullandığı kategorileri öğrenmek için kullanılır
' ============================================================================

Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports System.Text

Public Class TrendyolBarkodKategoriService
    
    ''' <summary>
    ''' BARKOD ile Trendyol'da TAM EŞLEŞME yaparak kategori bilgisi çeker
    ''' AYNI BARKODLU ürünü bulup kategorisini alır - yanlış eşleşme olmaz!
    ''' </summary>
    Public Shared Function GetKategoriByBarkod(barkod As String) As TrendyolKategoriSonuc
        Dim sonuc As New TrendyolKategoriSonuc()
        sonuc.Barkod = barkod
        sonuc.Basarili = False
        
        Try
            ' TLS aktif et
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            ServicePointManager.ServerCertificateValidationCallback = Function(sender, cert, chain, errors) True
            
            ' 1. Trendyol Public API ile BARKOD araması yap
            Dim apiUrl As String = "https://apigw.trendyol.com/discovery-web-searchgw-service/v2/api/infinite-scroll/sr?q=" & Uri.EscapeDataString(barkod)
            
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(apiUrl), HttpWebRequest)
            request.Method = "GET"
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"
            request.Accept = "application/json"
            request.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9")
            request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
            request.Timeout = 30000
            
            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream(), Encoding.UTF8)
                    Dim json As String = reader.ReadToEnd()
                    
                    ' JSON'dan barkod ile TAM EŞLEŞEN ürünü bul
                    Dim urunBilgi As TrendyolUrunBilgi = BulBarkodEslesenUrun(json, barkod)
                    
                    If urunBilgi IsNot Nothing AndAlso urunBilgi.Kategoriler.Count > 0 Then
                        ' BAŞARILI - TAM EŞLEŞME BULUNDU!
                        sonuc.Basarili = True
                        sonuc.Marka = urunBilgi.Marka
                        sonuc.UrunBaslik = urunBilgi.UrunAdi
                        sonuc.UrunUrl = "https://www.trendyol.com" & urunBilgi.Url
                        sonuc.Kategoriler = urunBilgi.Kategoriler
                        
                        ' Kategorileri ayır
                        If urunBilgi.Kategoriler.Count > 0 Then sonuc.Kategori1 = urunBilgi.Kategoriler(0)
                        If urunBilgi.Kategoriler.Count > 1 Then sonuc.Kategori2 = urunBilgi.Kategoriler(1)
                        If urunBilgi.Kategoriler.Count > 2 Then sonuc.Kategori3 = urunBilgi.Kategoriler(2)
                        If urunBilgi.Kategoriler.Count > 3 Then sonuc.Kategori4 = urunBilgi.Kategoriler(3)
                        If urunBilgi.Kategoriler.Count > 4 Then sonuc.Kategori5 = urunBilgi.Kategoriler(4)
                        
                        sonuc.HataMesaji = ""
                    Else
                        sonuc.Basarili = False
                        sonuc.HataMesaji = "Bu barkod ile Trendyol'da ürün bulunamadı"
                    End If
                End Using
            End Using
            
        Catch ex As Exception
            sonuc.Basarili = False
            sonuc.HataMesaji = "API hatası: " & ex.Message
        End Try
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' JSON'dan BARKOD ile TAM EŞLEŞEN ürünü bul
    ''' SADECE barkod eşleşirse kabul eder - yanlış eşleşme olmaz!
    ''' </summary>
    Private Shared Function BulBarkodEslesenUrun(json As String, arananBarkod As String) As TrendyolUrunBilgi
        Try
            ' JSON içinde "products" array'ini bul
            Dim productsPattern As String = """products""\s*:\s*\[(.*?)\](?=,\s*""pagination"")"
            Dim productsMatch As Match = Regex.Match(json, productsPattern, RegexOptions.Singleline)
            
            If Not productsMatch.Success Then
                Return Nothing
            End If
            
            Dim productsJson As String = productsMatch.Groups(1).Value
            
            ' Her bir ürünü parse et
            ' Ürün pattern: {...} şeklinde
            Dim productPattern As String = "\{(?:[^{}]|(?<open>\{)|(?<-open>\}))+(?(open)(?!))\}"
            Dim productMatches As MatchCollection = Regex.Matches(productsJson, productPattern)
            
            For Each productMatch As Match In productMatches
                Dim productJson As String = productMatch.Value
                
                ' BARKOD kontrolü - TAM EŞLEŞME ZORUNLU!
                Dim barcodePattern As String = """barcode""\s*:\s*""([^""]+)"""
                Dim barcodeMatch As Match = Regex.Match(productJson, barcodePattern)
                
                If barcodeMatch.Success Then
                    Dim bulunanBarkod As String = barcodeMatch.Groups(1).Value.Trim()
                    
                    ' TAM EŞLEŞME kontrolü
                    If bulunanBarkod = arananBarkod Then
                        ' BARKOD EŞLEŞTİ! Bu ürünün bilgilerini al
                        Dim urun As New TrendyolUrunBilgi()
                        urun.Barkod = bulunanBarkod
                        
                        ' Marka
                        Dim brandPattern As String = """brand""\s*:\s*\{[^}]*""name""\s*:\s*""([^""]+)"""
                        Dim brandMatch As Match = Regex.Match(productJson, brandPattern)
                        If brandMatch.Success Then
                            urun.Marka = brandMatch.Groups(1).Value
                        End If
                        
                        ' Ürün adı
                        Dim namePattern As String = """name""\s*:\s*""([^""]+)"""
                        Dim nameMatch As Match = Regex.Match(productJson, namePattern)
                        If nameMatch.Success Then
                            urun.UrunAdi = nameMatch.Groups(1).Value
                        End If
                        
                        ' URL
                        Dim urlPattern As String = """url""\s*:\s*""(/[^""]+)"""
                        Dim urlMatch As Match = Regex.Match(productJson, urlPattern)
                        If urlMatch.Success Then
                            urun.Url = urlMatch.Groups(1).Value
                        End If
                        
                        ' KATEGORİ HİYERARŞİSİ - EN ÖNEMLİ!
                        Dim catPattern As String = """categoryHierarchy""\s*:\s*""([^""]+)"""
                        Dim catMatch As Match = Regex.Match(productJson, catPattern)
                        
                        If catMatch.Success Then
                            Dim kategoriYolu As String = catMatch.Groups(1).Value
                            ' "/" ile bölüp kategorileri ayır
                            ' Örnek: "Giyim/Alt Giyim/Erkek/Şort & Bermuda"
                            Dim kategoriler() As String = kategoriYolu.Split(New Char() {"/"c}, StringSplitOptions.RemoveEmptyEntries)
                            
                            urun.Kategoriler = New List(Of String)()
                            For Each kat As String In kategoriler
                                Dim temizKat As String = kat.Trim()
                                If Not String.IsNullOrWhiteSpace(temizKat) Then
                                    urun.Kategoriler.Add(temizKat)
                                End If
                            Next
                        End If
                        
                        ' Kategori varsa döndür
                        If urun.Kategoriler IsNot Nothing AndAlso urun.Kategoriler.Count > 0 Then
                            Return urun
                        End If
                    End If
                End If
            Next
            
            ' Hiçbir ürün barkod ile eşleşmedi
            Return Nothing
            
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    
End Class
