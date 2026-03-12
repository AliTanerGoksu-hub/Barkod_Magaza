' ============================================================================
' TRENDYOL WEB SCRAPER SERVICE - VB.NET
' ============================================================================
' Python scraper'ının (v35_resume) VB.NET versiyonu
' Python ile AYNI mantık:
'   - accept-recommendations: token overlap >= 1 ise kabul (skor 0.85)
'   - Barcode birebir eşleşirse skor 1.0
'   - Diğer durumlarda benzerlik skoru (threshold: 0.60 ama token/barcode bypass)
' ============================================================================

Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq

Public Class TrendyolWebScraperService
    
    Private Const SEARCH_URL As String = "https://www.trendyol.com/sr?q={0}"
    Private Const USER_AGENT As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36"
    
    ' Python ile AYNI generic tokens listesi
    Private Shared ReadOnly GENERIC_TOKENS As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
        "kadin", "erkek", "cocuk", "bebek", "kiz", "oglan", "oğlan",
        "takim", "takimi", "takımı", "set", "ikili", "uclu", "üçlü", "uc", "3lu", "2li",
        "pijama", "esofman", "eşofman", "bermuda", "kapri", "mont", "tulum", "body",
        "sort", "şort", "tisort", "tişört", "tshirt", "tsirt", "atlet", "ic", "iç", "giyim",
        "renk", "lacivert", "siyah", "beyaz", "krem", "yesil", "yeşil", "mavi", "pembe", "turuncu",
        "lila", "mor", "kirmizi", "kırmızı", "gri", "bej", "haki", "kahve", "mocha", "mint",
        "basic", "standart", "model", "urun", "ürün", "yeni"
    }
    
    ' Python parametreleri ile aynı
    Private Const ACCEPT_RECOMMENDATIONS As Boolean = True
    Private Const MIN_TOKEN_OVERLAP As Integer = 1
    Private Const THRESHOLD As Double = 0.60
    
    ''' <summary>
    ''' Ana fonksiyon - Barkod ile Trendyol'dan kategori çeker
    ''' Python v35 ile AYNI MANTIK
    ''' </summary>
    Public Shared Function GetKategoriByBarkod(barkod As String, urunAdi As String, marka As String) As TrendyolScraperSonuc
        Dim sonuc As New TrendyolScraperSonuc()
        sonuc.Barkod = barkod
        sonuc.Basarili = False
        
        Try
            ' TLS ayarları
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            ServicePointManager.ServerCertificateValidationCallback = Function(sender, cert, chain, errors) True
            
            ' 1. Barkod ile arama yap
            Dim searchUrl As String = String.Format(SEARCH_URL, Uri.EscapeDataString(barkod))
            Dim searchHtml As String = GetPageContent(searchUrl)
            
            If String.IsNullOrEmpty(searchHtml) Then
                sonuc.HataMesaji = "Arama sayfası yüklenemedi"
                Return sonuc
            End If
            
            ' 2. Ürün linklerini topla
            Dim urunLinkleri As List(Of String) = CollectProductLinks(searchHtml)
            
            If urunLinkleri.Count = 0 Then
                sonuc.HataMesaji = "Arama sonucu bulunamadı"
                Return sonuc
            End If
            
            ' 3. Her ürün sayfasını kontrol et - Python ile AYNI mantık
            Dim bestHit As ProductHit = Nothing
            Dim bestReason As String = ""
            
            For Each urunUrl As String In urunLinkleri
                Try
                    Threading.Thread.Sleep(500) ' Rate limiting
                    
                    Dim productHtml As String = GetPageContent(urunUrl)
                    If String.IsNullOrEmpty(productHtml) Then Continue For
                    
                    Dim hit As ProductHit = ParseProductPage(productHtml, urunUrl)
                    
                    ' === PYTHON İLE AYNI KONTROL SIRASI ===
                    
                    ' 1. BARKOD TAM EŞLEŞME kontrolü (Python satır 510-515)
                    If Not String.IsNullOrEmpty(hit.Barcode) AndAlso NormalizeBarkod(hit.Barcode) = NormalizeBarkod(barkod) Then
                        hit.Score = 1.0
                        hit.Note = "Barkod birebir eşleşti"
                        bestHit = hit
                        bestReason = "barcode"
                        Exit For
                    End If
                    
                    ' 2. TOKEN OVERLAP kontrolü - accept-recommendations modu (Python satır 517-523)
                    If ACCEPT_RECOMMENDATIONS Then
                        Dim overlapResult = TokenOverlap(urunAdi, hit.Title)
                        If overlapResult.Count >= MIN_TOKEN_OVERLAP Then
                            hit.Score = Math.Max(hit.Score, 0.85)
                            hit.Note = $"Öneri kabul: token overlap={overlapResult.Count} ({String.Join(", ", overlapResult.CommonTokens.Take(6))})"
                            bestHit = hit
                            bestReason = "token"
                            Exit For
                        End If
                    End If
                    
                    ' 3. BENZERLİK SKORU hesapla (Python satır 525-532)
                    Dim brandScore As Double = If(Not String.IsNullOrEmpty(marka), Similarity(hit.Brand, marka), 0.0)
                    Dim titleScore As Double = If(Not String.IsNullOrEmpty(urunAdi), Similarity(hit.Title, urunAdi), 0.0)
                    hit.Score = 0.35 * brandScore + 0.65 * titleScore
                    hit.Note = $"Benzerlik: title={titleScore:F2} brand={brandScore:F2}"
                    
                    If bestHit Is Nothing OrElse hit.Score > bestHit.Score Then
                        bestHit = hit
                        bestReason = "score"
                    End If
                    
                Catch ex As Exception
                    Continue For
                End Try
            Next
            
            ' 4. Sonucu döndür - Python ile AYNI mantık (satır 539-559)
            If bestHit Is Nothing Then
                sonuc.HataMesaji = "Ürün sayfası okunamadı veya eşleşme yok"
                Return sonuc
            End If
            
            ' Her durumda bilgileri doldur (Python satır 545-551)
            sonuc.UrunUrl = bestHit.Url
            sonuc.KategoriYolu = bestHit.CategoryPath
            sonuc.Marka = bestHit.Brand
            sonuc.UrunAdi = bestHit.Title
            sonuc.Skor = bestHit.Score
            sonuc.Not_ = bestHit.Note & " | reason=" & bestReason
            
            ' Kategori yolunu parçala
            If Not String.IsNullOrEmpty(bestHit.CategoryPath) Then
                Dim kategoriler() As String = bestHit.CategoryPath.Split(New String() {" / ", "/"}, StringSplitOptions.RemoveEmptyEntries)
                sonuc.Kategoriler = New List(Of String)(kategoriler)
            End If
            
            ' Python satır 553-559: threshold kontrolü VEYA token/barcode ise kabul
            If bestHit.Score >= THRESHOLD OrElse bestReason = "token" OrElse bestReason = "barcode" Then
                sonuc.Basarili = True
            Else
                sonuc.Basarili = False
                sonuc.HataMesaji = $"Eşleşen ürün bulunamadı (en iyi skor: {bestHit.Score:F2}, reason: {bestReason})"
            End If
            
        Catch ex As Exception
            sonuc.HataMesaji = "Hata: " & ex.Message
        End Try
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' Barkod ile Trendyol'dan rakip fiyatlarını çeker
    ''' </summary>
    Public Shared Function GetRakipFiyatlari(barkod As String, Optional urunAdi As String = "") As RakipTaramaSonuc
        Dim sonuc As New RakipTaramaSonuc()
        sonuc.Barkod = barkod
        sonuc.Basarili = False
        
        Try
            ' TLS ayarları
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            ServicePointManager.ServerCertificateValidationCallback = Function(sender, cert, chain, errors) True
            
            ' 1. Barkod ile arama yap
            Dim searchQuery As String = If(String.IsNullOrEmpty(urunAdi), barkod, barkod & " " & urunAdi)
            Dim searchUrl As String = String.Format(SEARCH_URL, Uri.EscapeDataString(searchQuery))
            Dim searchHtml As String = GetPageContent(searchUrl)
            
            If String.IsNullOrEmpty(searchHtml) Then
                sonuc.HataMesaji = "Arama sayfası yüklenemedi (Cloudflare?)"
                Return sonuc
            End If
            
            ' 2. Ürün linklerini topla
            Dim urunLinkleri As List(Of String) = CollectProductLinks(searchHtml)
            
            If urunLinkleri.Count = 0 Then
                sonuc.HataMesaji = "Trendyol'da bulunamadı veya rakip yok"
                Return sonuc
            End If
            
            ' 3. İlk ürün sayfasına git ve fiyatları çek
            For Each urunUrl As String In urunLinkleri
                Try
                    Threading.Thread.Sleep(300) ' Rate limiting
                    
                    Dim productHtml As String = GetPageContent(urunUrl)
                    If String.IsNullOrEmpty(productHtml) Then Continue For
                    
                    ' Ürün sayfasından fiyat bilgilerini çek
                    Dim rakipler As List(Of RakipFiyatBilgi) = ParseRakipFiyatlari(productHtml)
                    
                    If rakipler.Count > 0 Then
                        sonuc.UrunUrl = urunUrl
                        sonuc.UrunAdi = ParseUrunAdi(productHtml)
                        sonuc.Rakipler = rakipler
                        sonuc.RakipSayisi = rakipler.Count
                        sonuc.EnDusukFiyat = rakipler.Min(Function(r) r.ToplamFiyat)
                        sonuc.OrtalamaFiyat = rakipler.Average(Function(r) r.ToplamFiyat)
                        sonuc.Basarili = True
                        Exit For
                    End If
                    
                Catch ex As Exception
                    Continue For
                End Try
            Next
            
            If Not sonuc.Basarili Then
                sonuc.HataMesaji = "Rakip fiyat bilgisi bulunamadı"
            End If
            
        Catch ex As Exception
            sonuc.HataMesaji = "Hata: " & ex.Message
        End Try
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' Ürün sayfasından rakip fiyatlarını parse eder
    ''' </summary>
    Private Shared Function ParseRakipFiyatlari(html As String) As List(Of RakipFiyatBilgi)
        Dim rakipler As New List(Of RakipFiyatBilgi)
        
        Try
            ' Trendyol'da fiyat bilgisi genellikle JSON-LD veya data attribute'larında
            ' "prc-dsc" class'ında fiyat bilgisi var
            ' "other-sellers" veya "merchant" bilgisi
            
            ' Ana satıcı fiyatını çek
            Dim fiyatPattern As String = """prc-dsc"">([0-9.,]+)\s*TL<"
            Dim fiyatMatch As Match = Regex.Match(html, fiyatPattern)
            
            If Not fiyatMatch.Success Then
                ' Alternatif pattern
                fiyatPattern = "class=""prc-slg"">([0-9.,]+)\s*TL"
                fiyatMatch = Regex.Match(html, fiyatPattern)
            End If
            
            If Not fiyatMatch.Success Then
                ' JSON-LD'den çek
                fiyatPattern = """price""\s*:\s*""?([0-9.,]+)""?"
                fiyatMatch = Regex.Match(html, fiyatPattern)
            End If
            
            If fiyatMatch.Success Then
                Dim fiyatStr As String = fiyatMatch.Groups(1).Value.Replace(".", "").Replace(",", ".")
                Dim fiyat As Decimal = 0
                Decimal.TryParse(fiyatStr, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, fiyat)
                
                If fiyat > 0 Then
                    ' Satıcı adını çek
                    Dim saticiPattern As String = "merchant[^>]*>([^<]+)<|seller[^>]*>([^<]+)<|""seller""\s*:\s*\{[^}]*""name""\s*:\s*""([^""]+)"""
                    Dim saticiMatch As Match = Regex.Match(html, saticiPattern, RegexOptions.IgnoreCase)
                    Dim saticiAdi As String = "Trendyol Satıcı"
                    
                    If saticiMatch.Success Then
                        For i As Integer = 1 To saticiMatch.Groups.Count - 1
                            If Not String.IsNullOrEmpty(saticiMatch.Groups(i).Value) Then
                                saticiAdi = saticiMatch.Groups(i).Value.Trim()
                                Exit For
                            End If
                        Next
                    End If
                    
                    Dim rakip As New RakipFiyatBilgi()
                    rakip.SaticiAdi = saticiAdi
                    rakip.Fiyat = fiyat
                    rakip.KargoUcreti = 0 ' Genellikle ücretsiz kargo
                    rakip.ToplamFiyat = fiyat
                    rakipler.Add(rakip)
                End If
            End If
            
            ' Diğer satıcıları da çek (varsa)
            ' "other-merchants" veya benzer pattern
            Dim digerSaticiPattern As String = "other-merchant[^>]*>[^<]*<[^>]*>([^<]+)<[^>]*>[^<]*([0-9.,]+)\s*TL"
            Dim digerMatches As MatchCollection = Regex.Matches(html, digerSaticiPattern, RegexOptions.IgnoreCase)
            
            For Each m As Match In digerMatches
                Try
                    Dim satici As String = m.Groups(1).Value.Trim()
                    Dim fiyatStr As String = m.Groups(2).Value.Replace(".", "").Replace(",", ".")
                    Dim fiyat As Decimal = 0
                    Decimal.TryParse(fiyatStr, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, fiyat)
                    
                    If fiyat > 0 AndAlso Not rakipler.Any(Function(r) r.SaticiAdi = satici) Then
                        Dim rakip As New RakipFiyatBilgi()
                        rakip.SaticiAdi = satici
                        rakip.Fiyat = fiyat
                        rakip.ToplamFiyat = fiyat
                        rakipler.Add(rakip)
                    End If
                Catch
                End Try
            Next
            
        Catch ex As Exception
        End Try
        
        Return rakipler
    End Function
    
    ''' <summary>
    ''' Ürün sayfasından ürün adını parse eder
    ''' </summary>
    Private Shared Function ParseUrunAdi(html As String) As String
        Try
            ' pr-new-br pattern
            Dim pattern As String = "class=""pr-new-br[^""]*""[^>]*>([^<]+)<"
            Dim m As Match = Regex.Match(html, pattern)
            If m.Success Then Return m.Groups(1).Value.Trim()
            
            ' title pattern
            pattern = "<title>([^<]+)</title>"
            m = Regex.Match(html, pattern)
            If m.Success Then Return m.Groups(1).Value.Split("|"c)(0).Trim()
            
            ' h1 pattern
            pattern = "<h1[^>]*>([^<]+)</h1>"
            m = Regex.Match(html, pattern)
            If m.Success Then Return m.Groups(1).Value.Trim()
            
        Catch
        End Try
        Return ""
    End Function
    
    ''' <summary>
    ''' Web sayfası içeriğini çeker
    ''' </summary>
    Private Shared Function GetPageContent(url As String) As String
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.UserAgent = USER_AGENT
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"
            request.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7")
            request.Headers.Add("Accept-Encoding", "gzip, deflate")
            request.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
            request.Timeout = 30000
            request.AllowAutoRedirect = True
            
            ' Cookie container ekle
            request.CookieContainer = New CookieContainer()
            
            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream(), Encoding.UTF8)
                    Return reader.ReadToEnd()
                End Using
            End Using
            
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Arama sayfasından ürün linklerini toplar
    ''' </summary>
    Private Shared Function CollectProductLinks(html As String) As List(Of String)
        Dim links As New List(Of String)
        
        Try
            ' href="/....-p-12345" pattern'i ara
            Dim pattern As String = "href=""(/[^""]*-p-\d+[^""]*)"""
            Dim matches As MatchCollection = Regex.Matches(html, pattern)
            
            Dim seen As New HashSet(Of String)
            For Each m As Match In matches
                Dim path As String = m.Groups(1).Value.Split("?"c)(0) ' Query string'i kaldır
                Dim fullUrl As String = "https://www.trendyol.com" & path
                
                If Not seen.Contains(fullUrl) Then
                    seen.Add(fullUrl)
                    links.Add(fullUrl)
                End If
                
                If links.Count >= 20 Then Exit For
            Next
            
        Catch ex As Exception
        End Try
        
        Return links
    End Function
    
    ''' <summary>
    ''' Ürün sayfasını parse eder
    ''' </summary>
    Private Shared Function ParseProductPage(html As String, url As String) As ProductHit
        Dim hit As New ProductHit()
        hit.Url = url
        
        Try
            ' Breadcrumb'dan kategori yolu
            hit.CategoryPath = ExtractBreadcrumb(html)
            
            ' JSON-LD'den ürün bilgileri
            Dim jsonLdData = ExtractJsonLd(html)
            If jsonLdData IsNot Nothing Then
                If Not String.IsNullOrEmpty(jsonLdData.Name) Then hit.Title = jsonLdData.Name
                If Not String.IsNullOrEmpty(jsonLdData.Brand) Then hit.Brand = jsonLdData.Brand
                If Not String.IsNullOrEmpty(jsonLdData.Barcode) Then hit.Barcode = jsonLdData.Barcode
                If Not String.IsNullOrEmpty(jsonLdData.Category) AndAlso String.IsNullOrEmpty(hit.CategoryPath) Then
                    hit.CategoryPath = jsonLdData.Category
                End If
            End If
            
            ' H1'den başlık
            If String.IsNullOrEmpty(hit.Title) Then
                Dim h1Pattern As String = "<h1[^>]*>([^<]+)</h1>"
                Dim h1Match As Match = Regex.Match(html, h1Pattern, RegexOptions.IgnoreCase)
                If h1Match.Success Then
                    hit.Title = WebUtility.HtmlDecode(h1Match.Groups(1).Value.Trim())
                End If
            End If
            
            ' Title tag'den başlık
            If String.IsNullOrEmpty(hit.Title) Then
                Dim titlePattern As String = "<title>([^<]+)</title>"
                Dim titleMatch As Match = Regex.Match(html, titlePattern, RegexOptions.IgnoreCase)
                If titleMatch.Success Then
                    hit.Title = WebUtility.HtmlDecode(titleMatch.Groups(1).Value.Trim())
                End If
            End If
            
            ' __NEXT_DATA__'dan ek bilgiler
            ExtractNextData(html, hit)
            
        Catch ex As Exception
        End Try
        
        Return hit
    End Function
    
    ''' <summary>
    ''' Breadcrumb'dan kategori yolunu çıkarır
    ''' </summary>
    Private Shared Function ExtractBreadcrumb(html As String) As String
        Try
            ' Breadcrumb pattern'leri
            Dim patterns() As String = {
                "class=""breadcrumb[^""]*""[^>]*>(.*?)</nav>",
                "class=""breadcrumb[^""]*""[^>]*>(.*?)</div>",
                "class=""breadcrumb[^""]*""[^>]*>(.*?)</ul>",
                "class=""breadcrumb[^""]*""[^>]*>(.*?)</ol>"
            }
            
            For Each pattern As String In patterns
                Dim match As Match = Regex.Match(html, pattern, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
                If match.Success Then
                    Dim breadcrumbHtml As String = match.Groups(1).Value
                    
                    ' Link metinlerini çıkar
                    Dim linkPattern As String = "<a[^>]*>([^<]+)</a>"
                    Dim linkMatches As MatchCollection = Regex.Matches(breadcrumbHtml, linkPattern, RegexOptions.IgnoreCase)
                    
                    Dim names As New List(Of String)
                    For Each lm As Match In linkMatches
                        Dim name As String = WebUtility.HtmlDecode(lm.Groups(1).Value.Trim())
                        If Not String.IsNullOrWhiteSpace(name) AndAlso
                           name.ToLower() <> "anasayfa" AndAlso
                           name.ToLower() <> "home" AndAlso
                           Not names.Contains(name) Then
                            names.Add(name)
                        End If
                    Next
                    
                    If names.Count >= 2 Then
                        Return String.Join(" / ", names)
                    End If
                End If
            Next
            
        Catch ex As Exception
        End Try
        
        Return ""
    End Function
    
    ''' <summary>
    ''' JSON-LD verilerini çıkarır
    ''' </summary>
    Private Shared Function ExtractJsonLd(html As String) As JsonLdProduct
        Try
            Dim pattern As String = "<script[^>]*type=""application/ld\+json""[^>]*>(.*?)</script>"
            Dim matches As MatchCollection = Regex.Matches(html, pattern, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            
            For Each m As Match In matches
                Dim jsonText As String = m.Groups(1).Value.Trim()
                
                ' Product tipini ara
                If jsonText.Contains("""@type""") AndAlso jsonText.Contains("Product") Then
                    Dim product As New JsonLdProduct()
                    
                    ' Name
                    Dim nameMatch As Match = Regex.Match(jsonText, """name""\s*:\s*""([^""]+)""")
                    If nameMatch.Success Then product.Name = nameMatch.Groups(1).Value
                    
                    ' Brand
                    Dim brandMatch As Match = Regex.Match(jsonText, """brand""\s*:\s*\{[^}]*""name""\s*:\s*""([^""]+)""")
                    If brandMatch.Success Then
                        product.Brand = brandMatch.Groups(1).Value
                    Else
                        brandMatch = Regex.Match(jsonText, """brand""\s*:\s*""([^""]+)""")
                        If brandMatch.Success Then product.Brand = brandMatch.Groups(1).Value
                    End If
                    
                    ' Barcode (gtin13, gtin, sku, mpn)
                    For Each key As String In {"gtin13", "gtin", "sku", "mpn"}
                        Dim bcMatch As Match = Regex.Match(jsonText, $"""{key}""\s*:\s*""([^""]+)""")
                        If bcMatch.Success Then
                            product.Barcode = bcMatch.Groups(1).Value
                            Exit For
                        End If
                    Next
                    
                    ' Category
                    Dim catMatch As Match = Regex.Match(jsonText, """category""\s*:\s*""([^""]+)""")
                    If catMatch.Success Then product.Category = catMatch.Groups(1).Value
                    
                    Return product
                End If
            Next
            
        Catch ex As Exception
        End Try
        
        Return Nothing
    End Function
    
    ''' <summary>
    ''' __NEXT_DATA__ JSON'ından bilgi çıkarır
    ''' </summary>
    Private Shared Sub ExtractNextData(html As String, ByRef hit As ProductHit)
        Try
            Dim pattern As String = "<script[^>]*id=""__NEXT_DATA__""[^>]*>(.*?)</script>"
            Dim match As Match = Regex.Match(html, pattern, RegexOptions.IgnoreCase Or RegexOptions.Singleline)
            
            If match.Success Then
                Dim jsonText As String = match.Groups(1).Value
                
                ' categoryHierarchy
                Dim catMatch As Match = Regex.Match(jsonText, """categoryHierarchy""\s*:\s*""([^""]+)""")
                If catMatch.Success AndAlso String.IsNullOrEmpty(hit.CategoryPath) Then
                    hit.CategoryPath = catMatch.Groups(1).Value.Replace("/", " / ")
                End If
                
                ' brandName
                If String.IsNullOrEmpty(hit.Brand) Then
                    Dim brandMatch As Match = Regex.Match(jsonText, """brandName""\s*:\s*""([^""]+)""")
                    If brandMatch.Success Then hit.Brand = brandMatch.Groups(1).Value
                End If
                
                ' barcode
                If String.IsNullOrEmpty(hit.Barcode) Then
                    Dim bcMatch As Match = Regex.Match(jsonText, """barcode""\s*:\s*""([^""]+)""")
                    If bcMatch.Success Then hit.Barcode = bcMatch.Groups(1).Value
                End If
            End If
            
        Catch ex As Exception
        End Try
    End Sub
    
    ''' <summary>
    ''' Barkodu normalize eder
    ''' </summary>
    Private Shared Function NormalizeBarkod(barkod As String) As String
        If String.IsNullOrEmpty(barkod) Then Return ""
        barkod = barkod.Trim().Replace(" ", "")
        If barkod.EndsWith(".0") Then barkod = barkod.Substring(0, barkod.Length - 2)
        Return barkod
    End Function
    
    ''' <summary>
    ''' Metni tokenize eder - Python ile BİREBİR AYNI
    ''' NOT: Generic tokens burada FİLTRELENMEZ, token_overlap içinde filtrelenir!
    ''' </summary>
    Private Shared Function Tokenize(text As String) As List(Of String)
        Dim tokens As New List(Of String)
        
        If String.IsNullOrEmpty(text) Then Return tokens
        
        ' Python: s = norm_text(s) -> strip().lower()
        text = text.Trim().ToLower()
        
        ' Python: s = re.sub(r"[^\w\sçğıöşü]", " ", s, flags=re.UNICODE)
        ' Türkçe karakterleri ve harfleri/rakamları koru, diğerlerini boşlukla değiştir
        text = Regex.Replace(text, "[^a-zA-Z0-9çÇğĞıİöÖşŞüÜ\s]", " ")
        
        ' Birden fazla boşluğu teke indir
        text = Regex.Replace(text, "\s+", " ")
        
        Dim parts() As String = text.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        
        ' Python: parts = [p for p in parts if len(p) >= 3 and not p.isdigit()]
        ' NOT: Generic tokens BURADA FİLTRELENMEZ!
        For Each p As String In parts
            If p.Length >= 3 AndAlso Not IsNumeric(p) Then
                tokens.Add(p)
            End If
        Next
        
        Return tokens
    End Function
    
    ''' <summary>
    ''' Token overlap hesaplar - Python ile BİREBİR AYNI
    ''' </summary>
    Private Shared Function TokenOverlap(a As String, b As String) As TokenOverlapResult
        Dim result As New TokenOverlapResult()
        
        ' Python: ta = [t for t in tokenize(a) if t not in GENERIC_TOKENS]
        Dim tokensA As List(Of String) = Tokenize(a)
        Dim tokensB As List(Of String) = Tokenize(b)
        
        ' Generic olanları çıkar - BURADA filtrelenir (Python satır 69-70)
        Dim filteredA As New List(Of String)
        For Each t As String In tokensA
            If Not GENERIC_TOKENS.Contains(t.ToLower()) Then
                filteredA.Add(t.ToLower())
            End If
        Next
        
        Dim filteredB As New List(Of String)
        For Each t As String In tokensB
            If Not GENERIC_TOKENS.Contains(t.ToLower()) Then
                filteredB.Add(t.ToLower())
            End If
        Next
        
        ' Python: common = sorted(set(ta).intersection(set(tb)))
        Dim setA As New HashSet(Of String)(filteredA)
        Dim setB As New HashSet(Of String)(filteredB)
        setA.IntersectWith(setB)
        
        result.Count = setA.Count
        result.CommonTokens = setA.ToList()
        
        Return result
    End Function
    
    ''' <summary>
    ''' Benzerlik skoru hesaplar - Python SequenceMatcher.ratio() ile AYNI
    ''' </summary>
    Private Shared Function Similarity(a As String, b As String) As Double
        ' Python: a, b = norm_text(a), norm_text(b)
        a = NormText(a)
        b = NormText(b)
        
        If String.IsNullOrEmpty(a) OrElse String.IsNullOrEmpty(b) Then Return 0.0
        If a = b Then Return 1.0
        
        ' Python SequenceMatcher.ratio() implementasyonu
        ' ratio = 2.0 * M / T where M = matches, T = total chars
        Return SequenceMatcherRatio(a, b)
    End Function
    
    ''' <summary>
    ''' Python'daki norm_text fonksiyonu
    ''' </summary>
    Private Shared Function NormText(s As String) As String
        If String.IsNullOrEmpty(s) Then Return ""
        s = s.Trim().ToLower()
        s = Regex.Replace(s, "\s+", " ")
        Return s
    End Function
    
    ''' <summary>
    ''' Python difflib.SequenceMatcher.ratio() implementasyonu
    ''' </summary>
    Private Shared Function SequenceMatcherRatio(a As String, b As String) As Double
        ' Find longest common subsequences
        Dim matches As Integer = 0
        Dim aChars As New List(Of Char)(a.ToCharArray())
        Dim bChars As New List(Of Char)(b.ToCharArray())
        
        ' Simple LCS-based matching count
        Dim used As New HashSet(Of Integer)
        For Each c As Char In aChars
            For j As Integer = 0 To bChars.Count - 1
                If Not used.Contains(j) AndAlso bChars(j) = c Then
                    matches += 1
                    used.Add(j)
                    Exit For
                End If
            Next
        Next
        
        Dim total As Integer = a.Length + b.Length
        If total = 0 Then Return 1.0
        
        Return (2.0 * matches) / total
    End Function
    
    ''' <summary>
    ''' Levenshtein mesafesi hesaplar
    ''' </summary>
    Private Shared Function LevenshteinDistance(s As String, t As String) As Integer
        Dim n As Integer = s.Length
        Dim m As Integer = t.Length
        
        If n = 0 Then Return m
        If m = 0 Then Return n
        
        Dim d(n, m) As Integer
        
        For i As Integer = 0 To n
            d(i, 0) = i
        Next
        
        For j As Integer = 0 To m
            d(0, j) = j
        Next
        
        For i As Integer = 1 To n
            For j As Integer = 1 To m
                Dim cost As Integer = If(s(i - 1) = t(j - 1), 0, 1)
                d(i, j) = Math.Min(Math.Min(d(i - 1, j) + 1, d(i, j - 1) + 1), d(i - 1, j - 1) + cost)
            Next
        Next
        
        Return d(n, m)
    End Function
    
    Private Shared Function IsNumeric(text As String) As Boolean
        Return Regex.IsMatch(text, "^\d+$")
    End Function
    
End Class

' Yardımcı sınıflar
Public Class ProductHit
    Public Property Url As String = ""
    Public Property Title As String = ""
    Public Property Brand As String = ""
    Public Property CategoryPath As String = ""
    Public Property Barcode As String = ""
    Public Property Score As Double = 0.0
    Public Property Note As String = ""
End Class

Public Class JsonLdProduct
    Public Property Name As String = ""
    Public Property Brand As String = ""
    Public Property Barcode As String = ""
    Public Property Category As String = ""
End Class

Public Class TokenOverlapResult
    Public Property Count As Integer = 0
    Public Property CommonTokens As New List(Of String)
End Class

''' <summary>
''' Scraper sonuç sınıfı
''' </summary>
Public Class TrendyolScraperSonuc
    Public Property Barkod As String = ""
    Public Property Basarili As Boolean = False
    Public Property KategoriYolu As String = ""
    Public Property UrunUrl As String = ""
    Public Property Marka As String = ""
    Public Property UrunAdi As String = ""
    Public Property Skor As Double = 0
    Public Property Not_ As String = ""
    Public Property HataMesaji As String = ""
    Public Property Kategoriler As New List(Of String)
End Class

''' <summary>
''' Rakip fiyat bilgisi
''' </summary>
Public Class RakipFiyatBilgi
    Public Property SaticiAdi As String = ""
    Public Property Fiyat As Decimal = 0
    Public Property KargoUcreti As Decimal = 0
    Public Property ToplamFiyat As Decimal = 0
    Public Property Puan As Decimal = 0
    Public Property YorumSayisi As Integer = 0
End Class

''' <summary>
''' Rakip tarama sonucu
''' </summary>
Public Class RakipTaramaSonuc
    Public Property Barkod As String = ""
    Public Property Basarili As Boolean = False
    Public Property UrunUrl As String = ""
    Public Property UrunAdi As String = ""
    Public Property Rakipler As New List(Of RakipFiyatBilgi)
    Public Property EnDusukFiyat As Decimal = 0
    Public Property OrtalamaFiyat As Decimal = 0
    Public Property RakipSayisi As Integer = 0
    Public Property HataMesaji As String = ""
End Class
