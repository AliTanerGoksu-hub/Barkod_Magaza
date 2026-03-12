' ============================================================================
' TRENDYOL SELENIUM SCRAPER SERVICE - VB.NET
' ============================================================================
' Python Playwright scraper'ının Selenium WebDriver versiyonu
' JavaScript render ederek tam sayfa içeriğini alır
' Python v35_resume ile BİREBİR AYNI MANTIK
' ============================================================================

Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Linq
Imports System.Threading
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class TrendyolSeleniumScraperService
    Implements IDisposable
    
    Private Const SEARCH_URL As String = "https://www.trendyol.com/sr?q={0}"
    Private Const HOME_URL As String = "https://www.trendyol.com/"
    
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
    
    ' Python parametreleri ile AYNI
    Private Const ACCEPT_RECOMMENDATIONS As Boolean = True
    Private Const MIN_TOKEN_OVERLAP As Integer = 1
    Private Const THRESHOLD As Double = 0.60
    
    Private _driver As IWebDriver = Nothing
    Private _isInitialized As Boolean = False
    Private _headless As Boolean = True
    
    ''' <summary>
    ''' Constructor - Headless mod seçilebilir
    ''' </summary>
    Public Sub New(Optional headless As Boolean = True)
        _headless = headless
    End Sub
    
    ' Son hata mesajı - debug için
    Public Property LastError As String = ""
    
    ''' <summary>
    ''' Chrome WebDriver'ı başlatır
    ''' </summary>
    Public Function Initialize() As Boolean
        Try
            ' Zaten başlatılmışsa tekrar başlatma
            If _isInitialized AndAlso _driver IsNot Nothing Then
                Return True
            End If
            
            ' ChromeDriver servisini oluştur
            Dim service As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            service.HideCommandPromptWindow = True
            
            Dim options As New ChromeOptions()
            
            ' DevToolsActivePort hatası için gerekli ayarlar
            options.AddArgument("--no-sandbox")
            options.AddArgument("--disable-dev-shm-usage")
            options.AddArgument("--disable-gpu")
            options.AddArgument("--remote-debugging-port=0")
            
            ' Temp user data directory
            Dim tempDir As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "chrome_selenium_" & Guid.NewGuid().ToString("N").Substring(0, 8))
            options.AddArgument($"--user-data-dir={tempDir}")
            
            ' Diğer ayarlar
            options.AddArgument("--disable-blink-features=AutomationControlled")
            options.AddArgument("--disable-infobars")
            options.AddArgument("--disable-extensions")
            options.AddArgument("--lang=tr-TR")
            options.AddArgument("--window-size=1366,768")
            options.AddArgument("--log-level=3")
            
            ' User agent
            options.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/144.0.0.0 Safari/537.36")
            
            ' Headless mod
            If _headless Then
                options.AddArgument("--headless")
                options.AddArgument("--disable-software-rasterizer")
            End If
            
            ' Stealth için
            options.AddExcludedArgument("enable-automation")
            
            ' Driver başlat
            _driver = New ChromeDriver(service, options)
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30)
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10)
            
            ' Ana sayfaya git ve cookie kabul et
            _driver.Navigate().GoToUrl(HOME_URL)
            Thread.Sleep(3000)
            AcceptCookies()
            
            _isInitialized = True
            LastError = ""
            Return True
            
        Catch ex As Exception
            LastError = ex.Message
            Debug.WriteLine($"[SELENIUM HATA] {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Cookie popup'ını kabul eder
    ''' </summary>
    Private Sub AcceptCookies()
        Try
            Dim selectors() As String = {
                "button#onetrust-accept-btn-handler",
                "//button[contains(text(),'Kabul Et')]",
                "//button[contains(text(),'Kabul et')]",
                "//button[contains(text(),'Tamam')]"
            }
            
            For Each selector As String In selectors
                Try
                    Dim element As IWebElement = Nothing
                    If selector.StartsWith("//") Then
                        element = _driver.FindElement(By.XPath(selector))
                    Else
                        element = _driver.FindElement(By.CssSelector(selector))
                    End If
                    
                    If element IsNot Nothing AndAlso element.Displayed Then
                        element.Click()
                        Thread.Sleep(500)
                        Exit For
                    End If
                Catch
                    Continue For
                End Try
            Next
        Catch
            ' Cookie bulunamadı, devam et
        End Try
    End Sub
    
    ''' <summary>
    ''' Ana fonksiyon - Barkod ile Trendyol'dan kategori çeker (Selenium ile)
    ''' Python v35 ile BİREBİR AYNI MANTIK
    ''' </summary>
    Public Function GetKategoriByBarkod(barkod As String, urunAdi As String, marka As String) As TrendyolScraperSonuc
        Dim sonuc As New TrendyolScraperSonuc()
        sonuc.Barkod = barkod
        sonuc.Basarili = False
        
        Try
            ' Driver başlat (henüz başlatılmadıysa)
            If Not _isInitialized Then
                If Not Initialize() Then
                    sonuc.HataMesaji = "Selenium başlatılamadı"
                    Return sonuc
                End If
            End If
            
            ' 1. Barkod ile arama yap
            Dim searchUrl As String = String.Format(SEARCH_URL, Uri.EscapeDataString(barkod))
            _driver.Navigate().GoToUrl(searchUrl)
            Thread.Sleep(3000)
            
            ' 2. Ürün linklerini topla
            Dim urunLinkleri As List(Of String) = CollectProductLinks()
            
            Debug.WriteLine($"[SELENIUM] Barkod: {barkod} - Link sayısı: {urunLinkleri.Count}")
            
            If urunLinkleri.Count = 0 Then
                sonuc.HataMesaji = "Arama sonucu bulunamadı"
                Return sonuc
            End If
            
            ' 3. Her ürün sayfasını kontrol et - Python ile AYNI
            Dim bestHit As SeleniumProductHit = Nothing
            Dim bestReason As String = ""
            
            For Each urunUrl As String In urunLinkleri
                Try
                    Thread.Sleep(1000)
                    
                    _driver.Navigate().GoToUrl(urunUrl)
                    Thread.Sleep(2000) ' Sayfa yüklenmesini bekle
                    
                    Dim hit As SeleniumProductHit = ParseProductPage(urunUrl)
                    
                    ' === PYTHON İLE BİREBİR AYNI KONTROL SIRASI ===
                    
                    ' 1. BARKOD TAM EŞLEŞME kontrolü
                    If Not String.IsNullOrEmpty(hit.Barcode) AndAlso NormalizeBarkod(hit.Barcode) = NormalizeBarkod(barkod) Then
                        hit.Score = 1.0
                        hit.Note = "Barkod birebir eşleşti"
                        bestHit = hit
                        bestReason = "barcode"
                        Exit For
                    End If
                    
                    ' 2. TOKEN OVERLAP kontrolü - Python ile AYNI
                    If ACCEPT_RECOMMENDATIONS Then
                        Dim overlapResult = TokenOverlap(urunAdi, hit.Title)
                        If overlapResult.Count >= MIN_TOKEN_OVERLAP Then
                            hit.Score = Math.Max(hit.Score, 0.85)
                            hit.Note = $"Token overlap={overlapResult.Count} ({String.Join(", ", overlapResult.CommonTokens.Take(6))})"
                            bestHit = hit
                            bestReason = "token"
                            Exit For
                        End If
                    End If
                    
                    ' 3. BENZERLİK SKORU hesapla
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
            
            ' 4. Sonucu döndür - Python ile AYNI
            If bestHit Is Nothing Then
                sonuc.HataMesaji = "Eşleşme yok"
                Return sonuc
            End If
            
            ' Bilgileri doldur
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
            
            ' Python: if best.score >= args.threshold or best_reason in ("token","barcode")
            If bestHit.Score >= THRESHOLD OrElse bestReason = "token" OrElse bestReason = "barcode" Then
                sonuc.Basarili = True
            Else
                sonuc.Basarili = False
                sonuc.HataMesaji = $"Skor yetersiz: {bestHit.Score:F2} < {THRESHOLD}"
            End If
            
        Catch ex As Exception
            sonuc.HataMesaji = "Hata: " & ex.Message
        End Try
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' Sayfayı aşağı kaydırır - lazy loading için
    ''' </summary>
    Private Sub ScrollPage()
        Try
            Dim js As IJavaScriptExecutor = CType(_driver, IJavaScriptExecutor)
            ' Sayfayı aşağı kaydır
            js.ExecuteScript("window.scrollTo(0, 500);")
            Thread.Sleep(500)
            js.ExecuteScript("window.scrollTo(0, 1000);")
            Thread.Sleep(500)
            js.ExecuteScript("window.scrollTo(0, 1500);")
            Thread.Sleep(500)
            ' Tekrar yukarı
            js.ExecuteScript("window.scrollTo(0, 0);")
            Thread.Sleep(300)
        Catch
        End Try
    End Sub
    
    ''' <summary>
    ''' Arama sayfasından ürün linklerini toplar - PYTHON İLE AYNI
    ''' </summary>
    Private Function CollectProductLinks() As List(Of String)
        Dim links As New List(Of String)
        
        Try
            ' Sayfanın yüklenmesini bekle
            Thread.Sleep(3000)
            
            ' Scroll yap
            ScrollPage()
            Thread.Sleep(1000)
            
            ' JavaScript ile linkleri al - Python ile AYNI
            Dim js As IJavaScriptExecutor = CType(_driver, IJavaScriptExecutor)
            Dim result As Object = js.ExecuteScript("return Array.from(document.querySelectorAll('a[href*=""-p-""]')).map(e => e.href);")
            
            If result IsNot Nothing Then
                Dim linkArray As System.Collections.IEnumerable = CType(result, System.Collections.IEnumerable)
                Dim seen As New HashSet(Of String)
                
                For Each item As Object In linkArray
                    If item IsNot Nothing Then
                        Dim href As String = item.ToString()
                        If Not String.IsNullOrEmpty(href) AndAlso href.Contains("-p-") AndAlso href.StartsWith("http") Then
                            Dim cleanUrl As String = href.Split("?"c)(0)
                            If Not seen.Contains(cleanUrl) Then
                                seen.Add(cleanUrl)
                                links.Add(cleanUrl)
                            End If
                        End If
                    End If
                    If links.Count >= 20 Then Exit For
                Next
            End If
            
        Catch ex As Exception
            Debug.WriteLine($"[CollectProductLinks HATA] {ex.Message}")
        End Try
        
        Return links
    End Function
    
    ''' <summary>
    ''' Ürün sayfasını parse eder - Selenium ile tam JavaScript render
    ''' </summary>
    Private Function ParseProductPage(url As String) As SeleniumProductHit
        Dim hit As New SeleniumProductHit()
        hit.Url = url
        
        Try
            ' Breadcrumb'dan kategori yolu
            hit.CategoryPath = ExtractBreadcrumb()
            
            ' H1'den başlık
            Try
                Dim h1 As IWebElement = _driver.FindElement(By.TagName("h1"))
                If h1 IsNot Nothing Then
                    hit.Title = h1.Text.Trim()
                End If
            Catch
            End Try
            
            ' Title tag'den başlık (yedek)
            If String.IsNullOrEmpty(hit.Title) Then
                hit.Title = _driver.Title
            End If
            
            ' Marka bilgisi
            Try
                ' Trendyol'da marka genellikle bu class'ta
                Dim brandElem As IWebElement = _driver.FindElement(By.CssSelector(".product-brand-name-with-link, .pr-new-br a, [class*='brand'] a"))
                If brandElem IsNot Nothing Then
                    hit.Brand = brandElem.Text.Trim()
                End If
            Catch
            End Try
            
            ' JSON-LD'den ek bilgiler
            ExtractJsonLdData(hit)
            
            ' __NEXT_DATA__'dan ek bilgiler
            ExtractNextData(hit)
            
        Catch ex As Exception
        End Try
        
        Return hit
    End Function
    
    ''' <summary>
    ''' Breadcrumb'dan kategori yolunu çıkarır
    ''' </summary>
    Private Function ExtractBreadcrumb() As String
        Try
            Dim selectors() As String = {
                "nav[aria-label*='breadcrumb'] a",
                "div[class*='breadcrumb'] a",
                "ul[class*='breadcrumb'] a",
                "ol[class*='breadcrumb'] a",
                ".breadcrumb a"
            }
            
            For Each selector As String In selectors
                Try
                    Dim elements As IReadOnlyCollection(Of IWebElement) = _driver.FindElements(By.CssSelector(selector))
                    If elements.Count > 0 Then
                        Dim names As New List(Of String)
                        Dim seen As New HashSet(Of String)
                        
                        For Each elem As IWebElement In elements
                            Dim name As String = elem.Text.Trim()
                            If Not String.IsNullOrEmpty(name) AndAlso
                               name.ToLower() <> "anasayfa" AndAlso
                               name.ToLower() <> "home" AndAlso
                               Not seen.Contains(name) Then
                                seen.Add(name)
                                names.Add(name)
                            End If
                        Next
                        
                        If names.Count >= 2 Then
                            Return String.Join(" / ", names)
                        End If
                    End If
                Catch
                    Continue For
                End Try
            Next
            
        Catch ex As Exception
        End Try
        
        Return ""
    End Function
    
    ''' <summary>
    ''' JSON-LD verilerini çıkarır
    ''' </summary>
    Private Sub ExtractJsonLdData(ByRef hit As SeleniumProductHit)
        Try
            Dim scripts As IReadOnlyCollection(Of IWebElement) = _driver.FindElements(By.CssSelector("script[type='application/ld+json']"))
            
            For Each script As IWebElement In scripts
                Try
                    Dim jsonText As String = script.GetAttribute("innerHTML")
                    If String.IsNullOrEmpty(jsonText) Then Continue For
                    
                    If jsonText.Contains("""@type""") AndAlso jsonText.Contains("Product") Then
                        ' Name
                        Dim nameMatch As Match = Regex.Match(jsonText, """name""\s*:\s*""([^""]+)""")
                        If nameMatch.Success AndAlso String.IsNullOrEmpty(hit.Title) Then
                            hit.Title = nameMatch.Groups(1).Value
                        End If
                        
                        ' Brand
                        Dim brandMatch As Match = Regex.Match(jsonText, """brand""\s*:\s*\{[^}]*""name""\s*:\s*""([^""]+)""")
                        If brandMatch.Success AndAlso String.IsNullOrEmpty(hit.Brand) Then
                            hit.Brand = brandMatch.Groups(1).Value
                        Else
                            brandMatch = Regex.Match(jsonText, """brand""\s*:\s*""([^""]+)""")
                            If brandMatch.Success AndAlso String.IsNullOrEmpty(hit.Brand) Then
                                hit.Brand = brandMatch.Groups(1).Value
                            End If
                        End If
                        
                        ' Barcode (gtin13, gtin, sku, mpn)
                        For Each key As String In {"gtin13", "gtin", "sku", "mpn"}
                            Dim bcMatch As Match = Regex.Match(jsonText, $"""{key}""\s*:\s*""([^""]+)""")
                            If bcMatch.Success AndAlso String.IsNullOrEmpty(hit.Barcode) Then
                                hit.Barcode = bcMatch.Groups(1).Value.Trim()
                                Exit For
                            End If
                        Next
                        
                        ' Category
                        Dim catMatch As Match = Regex.Match(jsonText, """category""\s*:\s*""([^""]+)""")
                        If catMatch.Success AndAlso String.IsNullOrEmpty(hit.CategoryPath) Then
                            hit.CategoryPath = catMatch.Groups(1).Value
                        End If
                        
                        Exit For
                    End If
                Catch
                    Continue For
                End Try
            Next
            
        Catch ex As Exception
        End Try
    End Sub
    
    ''' <summary>
    ''' __NEXT_DATA__ JSON'ından bilgi çıkarır
    ''' </summary>
    Private Sub ExtractNextData(ByRef hit As SeleniumProductHit)
        Try
            Dim script As IWebElement = _driver.FindElement(By.Id("__NEXT_DATA__"))
            If script Is Nothing Then Return
            
            Dim jsonText As String = script.GetAttribute("innerHTML")
            If String.IsNullOrEmpty(jsonText) Then Return
            
            ' brandName
            If String.IsNullOrEmpty(hit.Brand) Then
                Dim brandMatch As Match = Regex.Match(jsonText, """brandName""\s*:\s*""([^""]+)""")
                If brandMatch.Success Then hit.Brand = brandMatch.Groups(1).Value
            End If
            
            ' barcode
            If String.IsNullOrEmpty(hit.Barcode) Then
                Dim bcMatch As Match = Regex.Match(jsonText, """barcode""\s*:\s*""([^""]+)""")
                If bcMatch.Success Then hit.Barcode = bcMatch.Groups(1).Value.Trim()
            End If
            
            ' categoryHierarchy
            If String.IsNullOrEmpty(hit.CategoryPath) Then
                Dim catMatch As Match = Regex.Match(jsonText, """categoryHierarchy""\s*:\s*""([^""]+)""")
                If catMatch.Success Then hit.CategoryPath = catMatch.Groups(1).Value.Replace("/", " / ")
            End If
            
        Catch ex As Exception
        End Try
    End Sub
    
    ' ===================== YARDIMCI FONKSİYONLAR - PYTHON İLE BİREBİR AYNI =====================
    
    Private Shared Function NormalizeBarkod(barkod As String) As String
        If String.IsNullOrEmpty(barkod) Then Return ""
        barkod = barkod.Trim().Replace(" ", "")
        If barkod.EndsWith(".0") Then barkod = barkod.Substring(0, barkod.Length - 2)
        Return barkod
    End Function
    
    ''' <summary>
    ''' Python norm_text ile birebir aynı
    ''' </summary>
    Private Shared Function NormText(s As String) As String
        If String.IsNullOrEmpty(s) Then Return ""
        s = s.Trim().ToLower()
        s = Regex.Replace(s, "\s+", " ")
        Return s
    End Function
    
    ''' <summary>
    ''' Python tokenize ile birebir aynı
    ''' </summary>
    Private Shared Function Tokenize(text As String) As List(Of String)
        Dim tokens As New List(Of String)
        If String.IsNullOrEmpty(text) Then Return tokens
        
        ' Python: s = norm_text(s)
        text = NormText(text)
        
        ' Python: s = re.sub(r"[^\w\sçğıöşü]", " ", s, flags=re.UNICODE)
        ' Harf, rakam, boşluk ve Türkçe karakterler dışındaki her şeyi boşlukla değiştir
        text = Regex.Replace(text, "[^\w\sçğıöşüÇĞİÖŞÜ]", " ", RegexOptions.None)
        
        ' Python: parts = [p for p in re.split(r"\s+", s) if p]
        Dim parts() As String = Regex.Split(text, "\s+")
        
        ' Python: parts = [p for p in parts if len(p) >= 3 and not p.isdigit()]
        For Each p As String In parts
            If Not String.IsNullOrEmpty(p) AndAlso p.Length >= 3 AndAlso Not Regex.IsMatch(p, "^\d+$") Then
                tokens.Add(p)
            End If
        Next
        
        Return tokens
    End Function
    
    ''' <summary>
    ''' Python token_overlap ile birebir aynı
    ''' </summary>
    Private Shared Function TokenOverlap(a As String, b As String) As TokenOverlapResult
        Dim result As New TokenOverlapResult()
        
        ' Python: ta = [t for t in tokenize(a) if t not in GENERIC_TOKENS]
        Dim tokensA As List(Of String) = Tokenize(a)
        Dim filteredA As New List(Of String)
        For Each t As String In tokensA
            If Not GENERIC_TOKENS.Contains(t) Then
                filteredA.Add(t)
            End If
        Next
        
        ' Python: tb = [t for t in tokenize(b) if t not in GENERIC_TOKENS]
        Dim tokensB As List(Of String) = Tokenize(b)
        Dim filteredB As New List(Of String)
        For Each t As String In tokensB
            If Not GENERIC_TOKENS.Contains(t) Then
                filteredB.Add(t)
            End If
        Next
        
        ' Python: common = sorted(set(ta).intersection(set(tb)))
        Dim setA As New HashSet(Of String)(filteredA)
        Dim setB As New HashSet(Of String)(filteredB)
        setA.IntersectWith(setB)
        
        result.Count = setA.Count
        result.CommonTokens = setA.ToList()
        result.CommonTokens.Sort()
        
        Return result
    End Function
    
    ''' <summary>
    ''' Python similarity ile birebir aynı (SequenceMatcher.ratio)
    ''' </summary>
    Private Shared Function Similarity(a As String, b As String) As Double
        a = NormText(a)
        b = NormText(b)
        
        If String.IsNullOrEmpty(a) OrElse String.IsNullOrEmpty(b) Then Return 0.0
        If a = b Then Return 1.0
        
        Return SequenceMatcherRatio(a, b)
    End Function
    
    Private Shared Function SequenceMatcherRatio(a As String, b As String) As Double
        Dim matches As Integer = 0
        Dim aChars As New List(Of Char)(a.ToCharArray())
        Dim bChars As New List(Of Char)(b.ToCharArray())
        
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
    ''' Kaynakları temizle
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        Try
            If _driver IsNot Nothing Then
                _driver.Quit()
                _driver.Dispose()
                _driver = Nothing
            End If
            _isInitialized = False
        Catch
        End Try
    End Sub
    
    ''' <summary>
    ''' Driver'ı kapat
    ''' </summary>
    Public Sub Close()
        Dispose()
    End Sub
    
End Class

''' <summary>
''' Selenium için ProductHit sınıfı
''' </summary>
Public Class SeleniumProductHit
    Public Property Url As String = ""
    Public Property Title As String = ""
    Public Property Brand As String = ""
    Public Property CategoryPath As String = ""
    Public Property Barcode As String = ""
    Public Property Score As Double = 0.0
    Public Property Note As String = ""
End Class
