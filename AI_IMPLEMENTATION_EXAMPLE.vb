' ============================================================================
' AI DESTEKLI ÜRÜN GÖNDERİM SİSTEMİ - ÖRNEK UYGULAMA
' ============================================================================
' Bu dosya, AI özelliklerinin nasıl entegre edileceğini gösterir
' frm_qukaGonder.vb dosyasına eklenebilir
' ============================================================================

Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class AIProductEnhancer
    
    Private emergentApiKey As String = ""
    Private ReadOnly logFilePath As String = "AI_Operations.log"
    
    ''' <summary>
    ''' Emergent LLM Key'i alır (emergent_integrations_manager ile)
    ''' </summary>
    Private Sub InitializeEmergentKey()
        Try
            ' emergent_integrations_manager tool çağrısı
            ' Bu tool ile universal key alınır
            emergentApiKey = GetEmergentUniversalKey()
            
            If String.IsNullOrEmpty(emergentApiKey) Then
                LogAI("ERROR", "InitializeEmergentKey", "Emergent LLM Key alınamadı!")
            Else
                LogAI("SUCCESS", "InitializeEmergentKey", "Emergent LLM Key başarıyla yüklendi")
            End If
            
        Catch ex As Exception
            LogAI("ERROR", "InitializeEmergentKey", $"Key alımı hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Emergent Universal Key alma fonksiyonu
    ''' Gerçek uygulamada emergent_integrations_manager tool'u kullanılmalı
    ''' </summary>
    Private Function GetEmergentUniversalKey() As String
        ' NOT: Gerçek implementasyonda emergent_integrations_manager tool çağrılacak
        ' Bu sadece örnek amaçlı placeholder
        Return "emergent-universal-key-placeholder"
    End Function
    
    ''' <summary>
    ''' OpenAI GPT-4o API çağrısı (Emergent Key ile)
    ''' </summary>
    Private Function CallOpenAI(prompt As String, Optional maxTokens As Integer = 200) As String
        Try
            If String.IsNullOrEmpty(emergentApiKey) Then
                InitializeEmergentKey()
            End If
            
            Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
            
            ' Request body hazırla
            Dim requestData As New Dictionary(Of String, Object) From {
                {"model", "gpt-4o-2024-08-06"},
                {"messages", New List(Of Object) From {
                    New Dictionary(Of String, String) From {
                        {"role", "system"},
                        {"content", "Sen profesyonel bir e-ticaret uzmanısın. Türkçe yanıt ver."}
                    },
                    New Dictionary(Of String, String) From {
                        {"role", "user"},
                        {"content", prompt}
                    }
                }},
                {"max_tokens", maxTokens},
                {"temperature", 0.7}
            }
            
            Dim jsonRequest As String = JsonConvert.SerializeObject(requestData)
            
            LogAI("DEBUG", "CallOpenAI", $"API çağrısı yapılıyor... Prompt uzunluğu: {prompt.Length}")
            
            ' HTTP Request
            Using client As New WebClient()
                client.Encoding = System.Text.Encoding.UTF8
                client.Headers.Add("Content-Type", "application/json")
                client.Headers.Add("Authorization", $"Bearer {emergentApiKey}")
                
                Dim response As String = client.UploadString(apiUrl, "POST", jsonRequest)
                
                ' Response parse et
                Dim jsonResponse As JObject = JObject.Parse(response)
                Dim aiContent As String = jsonResponse("choices")(0)("message")("content").ToString()
                
                LogAI("SUCCESS", "CallOpenAI", $"AI yanıtı alındı. Uzunluk: {aiContent.Length}")
                
                Return aiContent.Trim()
            End Using
            
        Catch ex As WebException
            Dim errorResponse As String = ""
            If ex.Response IsNot Nothing Then
                Using reader As New StreamReader(ex.Response.GetResponseStream())
                    errorResponse = reader.ReadToEnd()
                End Using
            End If
            
            LogAI("ERROR", "CallOpenAI", $"API hatası: {ex.Message}, Response: {errorResponse}")
            Return ""
            
        Catch ex As Exception
            LogAI("ERROR", "CallOpenAI", $"Beklenmeyen hata: {ex.Message}")
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' AI destekli ürün başlığı oluşturma (Platform-specific)
    ''' </summary>
    Public Function GenerateProductTitle(model As String, 
                                        renk As String, 
                                        kategori As String, 
                                        marka As String,
                                        platform As String) As String
        Try
            LogAI("INFO", "GenerateProductTitle", $"AI başlık üretiliyor: {model} - {platform}")
            
            Dim prompt As String = $"
E-ticaret platformu: {platform}

Ürün bilgileri:
- Model: {model}
- Renk: {renk}
- Kategori: {kategori}
- Marka: {marka}

Bu ürün için {platform} platformuna özel, SEO-friendly ve satış odaklı bir başlık oluştur.

Kurallar:
1. Maksimum 100 karakter
2. Marka adını başa al (örn: Nike Air Max...)
3. Anahtar kelimeleri kullan
4. {platform} platformunun tarzına uygun
5. Sayısal değerler varsa belirt
6. Türkçe karakter hatası OLMASIN

SADECE BAŞLIĞI DÖNDÜR, BAŞKA BİR ŞEY YAZMA!"

            Dim aiTitle As String = CallOpenAI(prompt, 120)
            
            ' Temizle
            aiTitle = aiTitle.Replace("""", "").Trim()
            
            ' Uzunluk kontrolü
            If aiTitle.Length > 100 Then
                aiTitle = aiTitle.Substring(0, 100)
            End If
            
            LogAI("SUCCESS", "GenerateProductTitle", $"Başlık oluşturuldu: {aiTitle}")
            
            Return aiTitle
            
        Catch ex As Exception
            LogAI("ERROR", "GenerateProductTitle", $"Hata: {ex.Message}")
            ' Fallback: Manuel başlık
            Return $"{marka} {model} {renk} {kategori}"
        End Try
    End Function
    
    ''' <summary>
    ''' AI destekli ürün açıklaması oluşturma
    ''' </summary>
    Public Function GenerateProductDescription(model As String, 
                                              renk As String, 
                                              kategori As String,
                                              ozellikler As String,
                                              platform As String) As String
        Try
            LogAI("INFO", "GenerateProductDescription", $"AI açıklama üretiliyor: {model}")
            
            Dim prompt As String = $"
E-ticaret platformu: {platform}

Ürün bilgileri:
- Model: {model}
- Renk: {renk}
- Kategori: {kategori}
- Özellikler: {ozellikler}

Bu ürün için {platform} platformuna özel, ikna edici ve satış odaklı bir açıklama yaz.

Format:
1. Giriş cümlesi (ürünü tanıt, 1-2 cümle)
2. Özellikler listesi (HTML <ul><li> formatında)
3. Kullanım senaryoları (2-3 cümle)
4. Harekete geçirici çağrı (CTA)

Kurallar:
- 200-300 kelime
- Faydaları vurgula (özellikler değil)
- Müşteri soularını yanıtla
- HTML formatında (<ul>, <li>, <strong>)
- Türkçe karakter hatası OLMASIN
- Abartma, dürüst ol

SADECE AÇIKLAMAYI DÖNDÜR!"

            Dim aiDescription As String = CallOpenAI(prompt, 400)
            
            LogAI("SUCCESS", "GenerateProductDescription", $"Açıklama oluşturuldu. Uzunluk: {aiDescription.Length}")
            
            Return aiDescription.Trim()
            
        Catch ex As Exception
            LogAI("ERROR", "GenerateProductDescription", $"Hata: {ex.Message}")
            Return $"<p>Kaliteli {kategori} ürünü.</p><ul><li>Model: {model}</li><li>Renk: {renk}</li></ul>"
        End Try
    End Function
    
    ''' <summary>
    ''' AI ile rakip fiyat analizi ve önerisi
    ''' </summary>
    Public Function SuggestOptimalPrice(productCode As String,
                                       currentPrice As Decimal,
                                       competitorPrices As List(Of Decimal),
                                       platform As String) As Dictionary(Of String, Object)
        Try
            If competitorPrices Is Nothing OrElse competitorPrices.Count = 0 Then
                LogAI("WARNING", "SuggestOptimalPrice", "Rakip fiyat verisi yok")
                Return New Dictionary(Of String, Object) From {
                    {"suggested_price", currentPrice},
                    {"strategy", "mevcut"},
                    {"reason", "Rakip veri yok"}
                }
            End If
            
            Dim avgPrice As Decimal = competitorPrices.Average()
            Dim minPrice As Decimal = competitorPrices.Min()
            Dim maxPrice As Decimal = competitorPrices.Max()
            
            LogAI("INFO", "SuggestOptimalPrice", 
                  $"Fiyat analizi: Mevcut={currentPrice}, Ort={avgPrice}, Min={minPrice}, Max={maxPrice}")
            
            Dim prompt As String = $"
Platform: {platform}
Ürün Kodu: {productCode}

Fiyat Bilgileri:
- Bizim Fiyat: {currentPrice:F2} TL
- Rakip Ortalama: {avgPrice:F2} TL
- En Düşük Rakip: {minPrice:F2} TL
- En Yüksek Rakip: {maxPrice:F2} TL
- Rakip Sayısı: {competitorPrices.Count}

Sen bir fiyatlandırma uzmanısın. Bu verilerle en uygun fiyat stratejisini öner.

SADECE AŞAĞIDAKI JSON FORMATINDA DÖNDÜR:
{{
    ""suggested_price"": 0.00,
    ""strategy"": ""competitive/premium/value"",
    ""reason"": ""Kısa açıklama"",
    ""expected_sales_increase"": ""%0""
}}

Strateji Kuralları:
- competitive: Rakiplerden %5-10 ucuz (hızlı satış)
- premium: Rakiplerden %10-15 pahalı (kalite imajı)
- value: Ortalamaya yakın (güvenli alan)

SADECE JSON DÖNDÜR, BAŞKA BİR ŞEY YAZMA!"

            Dim aiResponse As String = CallOpenAI(prompt, 200)
            
            ' JSON parse et
            Try
                ' Gereksiz karakterleri temizle
                aiResponse = aiResponse.Replace("```json", "").Replace("```", "").Trim()
                
                Dim result As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(aiResponse)
                
                LogAI("SUCCESS", "SuggestOptimalPrice", 
                      $"Önerilen fiyat: {result("suggested_price")} TL, Strateji: {result("strategy")}")
                
                Return result
                
            Catch jsonEx As Exception
                LogAI("ERROR", "SuggestOptimalPrice", $"JSON parse hatası: {jsonEx.Message}, AI Response: {aiResponse}")
                
                ' Fallback: Basit hesaplama
                Dim suggestedPrice As Decimal = avgPrice * 0.95D ' %5 daha ucuz
                Return New Dictionary(Of String, Object) From {
                    {"suggested_price", suggestedPrice},
                    {"strategy", "competitive"},
                    {"reason", "Otomatik hesaplama (AI parse hatası)"}
                }
            End Try
            
        Catch ex As Exception
            LogAI("ERROR", "SuggestOptimalPrice", $"Hata: {ex.Message}")
            Return New Dictionary(Of String, Object) From {
                {"suggested_price", currentPrice},
                {"strategy", "mevcut"},
                {"reason", "Hata oluştu"}
            }
        End Try
    End Function
    
    ''' <summary>
    ''' AI ile kategori ve etiket önerisi
    ''' </summary>
    Public Function SuggestCategoryAndTags(productName As String,
                                          model As String,
                                          marka As String) As Dictionary(Of String, Object)
        Try
            LogAI("INFO", "SuggestCategoryAndTags", $"Kategori önerisi: {productName}")
            
            Dim prompt As String = $"
Ürün:
- İsim: {productName}
- Model: {model}
- Marka: {marka}

Bu ürün için en uygun kategori ve SEO etiketlerini öner.

SADECE AŞAĞIDAKI JSON FORMATINDA DÖNDÜR:
{{
    ""main_category"": ""Ana Kategori"",
    ""sub_category"": ""Alt Kategori"",
    ""tags"": [""etiket1"", ""etiket2"", ""etiket3"", ""etiket4"", ""etiket5""],
    ""keywords"": [""anahtar1"", ""anahtar2"", ""anahtar3""]
}}

Kurallar:
- Kategoriler pazaryeri standartlarına uygun
- 5-8 adet SEO-friendly etiket
- Türkçe ve İngilizce karışık olabilir
- Arama hacmi yüksek kelimeler

SADECE JSON DÖNDÜR!"

            Dim aiResponse As String = CallOpenAI(prompt, 250)
            aiResponse = aiResponse.Replace("```json", "").Replace("```", "").Trim()
            
            Dim result As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(aiResponse)
            
            LogAI("SUCCESS", "SuggestCategoryAndTags", $"Kategori: {result("main_category")}")
            
            Return result
            
        Catch ex As Exception
            LogAI("ERROR", "SuggestCategoryAndTags", $"Hata: {ex.Message}")
            Return New Dictionary(Of String, Object) From {
                {"main_category", "Genel"},
                {"sub_category", "Diğer"},
                {"tags", New List(Of String) From {marka, model}},
                {"keywords", New List(Of String) From {productName}}
            }
        End Try
    End Function
    
    ''' <summary>
    ''' AI ile müşteri sorusu otomatik yanıtlama
    ''' </summary>
    Public Function GenerateCustomerResponse(question As String,
                                            productName As String,
                                            productFeatures As String,
                                            isInStock As Boolean,
                                            price As Decimal) As String
        Try
            LogAI("INFO", "GenerateCustomerResponse", $"Müşteri sorusu: {question}")
            
            Dim prompt As String = $"
Müşteri Sorusu: {question}

Ürün Bilgileri:
- İsim: {productName}
- Özellikler: {productFeatures}
- Stok: {If(isInStock, "Mevcut", "Tükendi")}
- Fiyat: {price:F2} TL

Sen müşteri hizmetleri temsilcisisin. Bu soruya profesyonel, yardımcı ve dostane bir yanıt ver.

Kurallar:
1. Kibar ve profesyonel
2. Soruyu doğrudan yanıtla
3. Ürünü hafifçe övebilirsin (abartma)
4. 80-120 kelime
5. Türkçe karakter hatası OLMASIN

SADECE YANITI DÖNDÜR, BAŞKA BİR ŞEY YAZMA!"

            Dim aiResponse As String = CallOpenAI(prompt, 180)
            
            LogAI("SUCCESS", "GenerateCustomerResponse", "Otomatik yanıt oluşturuldu")
            
            Return aiResponse.Trim()
            
        Catch ex As Exception
            LogAI("ERROR", "GenerateCustomerResponse", $"Hata: {ex.Message}")
            Return "Ürün hakkında detaylı bilgi için lütfen müşteri hizmetlerimizle iletişime geçin. Teşekkür ederiz."
        End Try
    End Function
    
    ''' <summary>
    ''' AI işlemleri için log fonksiyonu
    ''' </summary>
    Private Sub LogAI(level As String, function As String, message As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logMessage As String = $"[{timestamp}] [{level}] [{function}] {message}"
            
            ' Console'a yaz
            Console.WriteLine(logMessage)
            
            ' Dosyaya kaydet
            File.AppendAllText(logFilePath, logMessage & vbCrLf)
            
        Catch ex As Exception
            ' Log hatası olsa bile uygulama çökmesin
            Console.WriteLine($"Log yazma hatası: {ex.Message}")
        End Try
    End Sub
    
End Class

' ============================================================================
' KULLANIM ÖRNEKLERİ
' ============================================================================

Public Class AIUsageExamples
    
    ''' <summary>
    ''' Örnek 1: Ürün başlığı ve açıklaması oluşturma
    ''' </summary>
    Public Sub Example1_GenerateProductContent()
        Dim aiHelper As New AIProductEnhancer()
        
        ' AI ile başlık oluştur
        Dim aiTitle As String = aiHelper.GenerateProductTitle(
            model:="Air Max 270",
            renk:="Siyah",
            kategori:="Spor Ayakkabı",
            marka:="Nike",
            platform:="Trendyol"
        )
        
        Console.WriteLine($"AI Başlık: {aiTitle}")
        
        ' AI ile açıklama oluştur
        Dim aiDescription As String = aiHelper.GenerateProductDescription(
            model:="Air Max 270",
            renk:="Siyah",
            kategori:="Spor Ayakkabı",
            ozellikler:="Nefes alabilir kumaş, Air Max yastıklama, hafif tasarım",
            platform:="Trendyol"
        )
        
        Console.WriteLine($"AI Açıklama: {aiDescription}")
    End Sub
    
    ''' <summary>
    ''' Örnek 2: Fiyat optimizasyonu
    ''' </summary>
    Public Sub Example2_PriceOptimization()
        Dim aiHelper As New AIProductEnhancer()
        
        ' Rakip fiyatları (gerçek uygulamada API'den çekilecek)
        Dim competitorPrices As New List(Of Decimal) From {
            899.90D,  ' Rakip 1
            849.99D,  ' Rakip 2
            879.00D,  ' Rakip 3
            920.00D,  ' Rakip 4
            865.50D   ' Rakip 5
        }
        
        ' AI ile optimal fiyat önerisi al
        Dim priceStrategy As Dictionary(Of String, Object) = aiHelper.SuggestOptimalPrice(
            productCode:="NKE-AM270-BLK",
            currentPrice:=899.90D,
            competitorPrices:=competitorPrices,
            platform:="Trendyol"
        )
        
        Console.WriteLine($"Önerilen Fiyat: {priceStrategy("suggested_price")} TL")
        Console.WriteLine($"Strateji: {priceStrategy("strategy")}")
        Console.WriteLine($"Neden: {priceStrategy("reason")}")
    End Sub
    
    ''' <summary>
    ''' Örnek 3: Kategori ve etiket önerisi
    ''' </summary>
    Public Sub Example3_CategorySuggestion()
        Dim aiHelper As New AIProductEnhancer()
        
        Dim suggestions As Dictionary(Of String, Object) = aiHelper.SuggestCategoryAndTags(
            productName:="Nike Air Max 270 Erkek Siyah Spor Ayakkabı",
            model:="Air Max 270",
            marka:="Nike"
        )
        
        Console.WriteLine($"Ana Kategori: {suggestions("main_category")}")
        Console.WriteLine($"Alt Kategori: {suggestions("sub_category")}")
        Console.WriteLine($"Etiketler: {String.Join(", ", DirectCast(suggestions("tags"), List(Of String)))}")
    End Sub
    
    ''' <summary>
    ''' Örnek 4: Otomatik müşteri yanıtı
    ''' </summary>
    Public Sub Example4_CustomerResponse()
        Dim aiHelper As New AIProductEnhancer()
        
        Dim autoResponse As String = aiHelper.GenerateCustomerResponse(
            question:="Bu ayakkabının ölçüleri doğru mu? Genelde 42 numara giyiyorum.",
            productName:="Nike Air Max 270",
            productFeatures:="Standart kalıp, nefes alabilen üst yapı",
            isInStock:=True,
            price:=899.90D
        )
        
        Console.WriteLine($"Otomatik Yanıt: {autoResponse}")
    End Sub
    
End Class

' ============================================================================
' frm_qukaGonder.vb İÇİNE ENTEGRASYON ÖRNEĞİ
' ============================================================================

''' <summary>
''' Mevcut SendProduct fonksiyonuna AI desteği ekleme
''' </summary>
Private Function SendProductWithAI(ByVal id As String, ByVal conn As OleDb.OleDbConnection) As Dictionary(Of String, Object)
    Try
        ' Mevcut ürün bilgilerini al
        Dim productData As Dictionary(Of String, Object) = GetProductData(id, conn)
        
        If productData Is Nothing Then
            Return Nothing
        End If
        
        ' AI Helper başlat
        Dim aiHelper As New AIProductEnhancer()
        
        ' Platform bilgisini belirle (örnek: Trendyol)
        Dim targetPlatform As String = "Trendyol"
        
        ' AI ile başlık oluştur
        Dim aiTitle As String = aiHelper.GenerateProductTitle(
            model:=productData("sModel").ToString(),
            renk:=productData("sRenk").ToString(),
            kategori:=productData("sKategori").ToString(),
            marka:=productData("sMarka").ToString(),
            platform:=targetPlatform
        )
        
        ' AI ile açıklama oluştur
        Dim aiDescription As String = aiHelper.GenerateProductDescription(
            model:=productData("sModel").ToString(),
            renk:=productData("sRenk").ToString(),
            kategori:=productData("sKategori").ToString(),
            ozellikler:=productData("sOzellikler").ToString(),
            platform:=targetPlatform
        )
        
        ' AI ile kategori ve etiketler
        Dim aiCategoryTags As Dictionary(Of String, Object) = aiHelper.SuggestCategoryAndTags(
            productName:=productData("sStokAdi").ToString(),
            model:=productData("sModel").ToString(),
            marka:=productData("sMarka").ToString()
        )
        
        ' Ürün verisini AI çıktıları ile güncelle
        productData("title") = aiTitle
        productData("description") = aiDescription
        productData("category") = aiCategoryTags("main_category")
        productData("tags") = aiCategoryTags("tags")
        
        Log("SUCCESS", "SendProductWithAI", $"AI ile ürün zenginleştirildi: {id}")
        
        ' Mevcut API gönderim fonksiyonunu çağır
        Return productData
        
    Catch ex As Exception
        LogError($"SendProductWithAI hatası: {ex.Message}")
        Return Nothing
    End Try
End Function
