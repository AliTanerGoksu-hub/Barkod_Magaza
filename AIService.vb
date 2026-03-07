' ============================================================================
' AI SERVİSİ - İÇERİK OLUŞTURMA
' ============================================================================
' OpenAI API çağrıları ve içerik oluşturma
' ============================================================================

Imports System.Net
Imports System.Net.Http
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class AIService
    
    Private emergentApiKey As String = ""
    Private openaiApiKey As String = ""
    Private ReadOnly logFile As String = "AI_Service.log"
    
    ' Google Custom Search API (marka sitesinden arama için)
    Private googleSearchApiKey As String = ""
    Private googleSearchEngineId As String = ""
    
    Public Sub New()
        LoadApiKey()
        LoadGoogleApiKeys()
    End Sub
    
    Private Sub LoadApiKey()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Emergent Key'i yükle
                Try
                    Dim cmd1 As New OleDb.OleDbCommand("SELECT TOP 1 sEmergentKey FROM tbParamGenel", conn)
                    Dim result1 As Object = cmd1.ExecuteScalar()
                    If result1 IsNot Nothing AndAlso Not IsDBNull(result1) Then
                        emergentApiKey = result1.ToString().Trim()
                    End If
                Catch
                    ' Kolon yoksa devam et
                End Try
                
                ' OpenAI Key'i yükle (eğer varsa)
                Try
                    Dim cmd2 As New OleDb.OleDbCommand("SELECT TOP 1 sOpenAIKey FROM tbParamGenel", conn)
                    Dim result2 As Object = cmd2.ExecuteScalar()
                    If result2 IsNot Nothing AndAlso Not IsDBNull(result2) Then
                        openaiApiKey = result2.ToString().Trim()
                    End If
                Catch
                    ' Kolon yoksa devam et
                End Try
            End Using
            
            Log("INFO", "LoadApiKey", $"EmergentKey: {If(Not String.IsNullOrEmpty(emergentApiKey), "VAR", "YOK")}, OpenAIKey: {If(Not String.IsNullOrEmpty(openaiApiKey), "VAR", "YOK")}")
        Catch ex As Exception
            Log("ERROR", "LoadApiKey", ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Google Custom Search API key'lerini yükler
    ''' </summary>
    Private Sub LoadGoogleApiKeys()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Google API Key ve Search Engine ID'yi yükle
                Using cmd As New OleDb.OleDbCommand("SELECT TOP 1 sGoogleSearchApiKey, sGoogleSearchEngineId FROM tbParamGenel", conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            googleSearchApiKey = If(reader("sGoogleSearchApiKey") IsNot DBNull.Value, reader("sGoogleSearchApiKey").ToString().Trim(), "")
                            googleSearchEngineId = If(reader("sGoogleSearchEngineId") IsNot DBNull.Value, reader("sGoogleSearchEngineId").ToString().Trim(), "")
                        End If
                    End Using
                End Using
                
                conn.Close()
            End Using
            
            ' Varsayılan değerler (eğer DB'de yoksa)
            If String.IsNullOrEmpty(googleSearchApiKey) Then
                googleSearchApiKey = "AIzaSyC_dOGn3xgVmBgkJv4b6_03StemDSbrWIg"
            End If
            If String.IsNullOrEmpty(googleSearchEngineId) Then
                googleSearchEngineId = "d3830d60b868641c4"
            End If
            
            Log("INFO", "LoadGoogleApiKeys", $"Google API Key: {If(Not String.IsNullOrEmpty(googleSearchApiKey), googleSearchApiKey.Substring(0, 10) & "...", "YOK")}")
        Catch ex As Exception
            ' Varsayılan değerler
            googleSearchApiKey = "AIzaSyC_dOGn3xgVmBgkJv4b6_03StemDSbrWIg"
            googleSearchEngineId = "d3830d60b868641c4"
            Log("WARNING", "LoadGoogleApiKeys", $"DB'den yüklenemedi, varsayılan kullanılıyor: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' SEO Başlık oluştur - PARAMETRİK KATEGORİ DESTEKLİ
    ''' </summary>
    Public Function GenerateTitle(productData As Dictionary(Of String, Object)) As String
        Dim urunAdi As String = If(productData.ContainsKey("sAciklama"), productData("sAciklama").ToString(), "")
        Dim marka As String = If(productData.ContainsKey("sMarka"), productData("sMarka").ToString(), "")
        Dim kategori As String = If(productData.ContainsKey("sKategori"), productData("sKategori").ToString(), "")
        Dim model As String = If(productData.ContainsKey("sModel"), productData("sModel").ToString(), "")
        
        ' Sektör tespiti yap
        Dim sektor As String = TespitSektor(kategori, urunAdi)
        Log("DEBUG", "GenerateTitle", $"Ürün: {urunAdi}, Marka: {marka}, Kategori: {kategori}, Sektör: {sektor}")
        
        ' Sektöre göre yasakları belirle
        Dim yasaklar As String = ""
        Select Case sektor
            Case "Züccaciye"
                yasaklar = "
- ASLA 'Unisex', '%100 Pamuk', 'Beden' gibi GİYİM TERİMLERİ KULLANMA!
- Bu bir mutfak/ev aletidir, giysi DEĞİL!
- Cinsiyet, yaş grubu, beden tablosu YASAK!"
            Case "Elektronik"
                yasaklar = "
- ASLA 'Unisex', '%100 Pamuk', 'Beden' gibi GİYİM TERİMLERİ KULLANMA!
- Bu bir elektronik üründür!
- Teknik özellikler ve performans vurgula!"
            Case Else
                yasaklar = ""
        End Select
        
        Dim prompt As String = $"
Sen bir e-ticaret SEO uzmanısın. Aşağıdaki ürün için SEO-friendly, satış odaklı bir başlık oluştur.

Ürün: {urunAdi}
Marka: {marka}
Kategori: {kategori}
Model: {model}
Tespit Edilen Sektör: {sektor}

Kurallar:
- Maksimum 100 karakter
- Marka adını başa al (eğer varsa)
- Ürün tipine uygun anahtar kelimeleri kullan
- Sayısal değerler varsa belirt (lt, watt, cm vb.)
- Türkçe karakter hatası OLMASIN
{yasaklar}

SADECE BAŞLIĞI DÖNDÜR!"

        Return CallOpenAI(prompt, 80)
    End Function
    
    ''' <summary>
    ''' Detaylı açıklama oluştur
    ''' </summary>
    Public Function GenerateDescription(productData As Dictionary(Of String, Object)) As String
        Dim prompt As String = $"
Sen bir e-ticaret copywriter'ısın. Aşağıdaki ürün için ikna edici, detaylı bir açıklama yaz.

Ürün: {productData("sAciklama")}
Kategori: {If(productData.ContainsKey("sKategoriAdi"), productData("sKategoriAdi"), "")}
Özellikler: {If(productData.ContainsKey("sOzellikler"), productData("sOzellikler"), "")}

Format:
- Giriş cümlesi (ürünü tanıt, 1-2 cümle)
- Özellikler listesi (HTML <ul><li> formatında)
- Kullanım senaryoları (2-3 cümle)
- Harekete geçirici çağrı

200-300 kelime, HTML formatında.
SADECE AÇIKLAMAYI DÖNDÜR!"

        Return CallOpenAI(prompt, 400)
    End Function
    
    ''' <summary>
    ''' Kullanım talimatları oluştur - PARAMETRİK KATEGORİ DESTEKLİ
    ''' </summary>
    Public Function GenerateInstructions(productData As Dictionary(Of String, Object)) As String
        Dim kategori As String = If(productData.ContainsKey("sKategoriAdi"), productData("sKategoriAdi").ToString().ToLower(), "")
        If String.IsNullOrEmpty(kategori) Then
            kategori = If(productData.ContainsKey("sKategori"), productData("sKategori").ToString().ToLower(), "")
        End If
        
        Dim urunAdi As String = If(productData.ContainsKey("sAciklama"), productData("sAciklama").ToString(), "")
        
        ' Sektör tespiti yap
        Dim sektor As String = TespitSektor(kategori, urunAdi)
        Log("DEBUG", "GenerateInstructions", $"Ürün: {urunAdi}, Kategori: {kategori}, Sektör: {sektor}")
        
        Dim prompt As String = ""
        
        ' Sektöre göre prompt seç
        Select Case sektor
            Case "Züccaciye"
                prompt = GetZuccaciyeInstructionPrompt(productData, kategori)
            Case "Elektronik"
                prompt = GetElectronicsInstructionPrompt(productData)
            Case Else
                If kategori.Contains("tekstil") OrElse kategori.Contains("giyim") Then
                    prompt = GetTextileInstructionPrompt(productData)
                ElseIf kategori.Contains("ayakkabı") Then
                    prompt = GetShoeInstructionPrompt(productData)
                Else
                    prompt = GetGenericInstructionPrompt(productData)
                End If
        End Select
        
        Return CallOpenAI(prompt, 400)
    End Function
    
    ''' <summary>
    ''' Züccaciye/Ev Aletleri için kullanım talimatı promptu
    ''' </summary>
    Private Function GetZuccaciyeInstructionPrompt(productData As Dictionary(Of String, Object), kategori As String) As String
        Dim urun As String = If(productData.ContainsKey("sAciklama"), productData("sAciklama").ToString(), "")
        
        ' Alt kategori tespiti
        Dim altKat As String = TespitZuccaciyeAltKategori(urun.ToLower())
        
        If altKat = "EvAleti" OrElse kategori.Contains("elektrikli") OrElse kategori.Contains("mikser") OrElse _
           kategori.Contains("blender") OrElse kategori.Contains("kettle") Then
            ' Elektrikli ev aletleri için
            Return $"
Sen bir ev aletleri uzmanısın. Aşağıdaki ürün için KULLANIM ve BAKIM talimatları oluştur.

Ürün: {urun}
Kategori: {kategori}

Bu bir ELEKTRİKLİ EV ALETİDİR. ASLA giyim terimleri (yıkama, kumaş bakımı) KULLANMA!

HTML formatında şu başlıkları kullan:
<h4>🔌 Kullanım Talimatları</h4>
- İlk kullanımdan önce yapılacaklar
- Çalıştırma adımları
- Hız/güç ayarları
- Temizlik öncesi güvenlik (fişi çek!)

<h4>&#129529;#129529; Temizlik ve Bakım</h4>
- Ana gövde temizliği (nemli bez)
- Çıkarılabilir parçalar
- Depolama önerileri

<h4>⚠️ Güvenlik Uyarıları</h4>
- Elektrik güvenliği
- Çocuklardan uzak tutma
- Aşırı yükleme uyarısı

SADECE TALİMATLARI DÖNDÜR!"
        Else
            ' Diğer züccaciye ürünleri için
            Return $"
Sen bir züccaciye uzmanısın. Aşağıdaki ürün için KULLANIM ve BAKIM talimatları oluştur.

Ürün: {urun}
Kategori: {kategori}

HTML formatında şu başlıkları kullan:
<h4>&#127869;#127869;️#127869; Kullanım Önerileri</h4>
- İlk kullanımdan önce yıkama
- Uygun kullanım senaryoları

<h4>&#129532;#129532; Temizlik ve Bakım</h4>
- Bulaşık makinesinde yıkanabilirlik
- Elle yıkama önerileri
- Kurutma ve saklama

<h4>⚠️ Dikkat Edilmesi Gerekenler</h4>
- Ani sıcaklık değişimleri
- Çizilme önleme
- Kırılma riski

SADECE TALİMATLARI DÖNDÜR!"
        End If
    End Function
    
    ''' <summary>
    ''' Meta description oluştur - PARAMETRİK KATEGORİ DESTEKLİ
    ''' </summary>
    Public Function GenerateMetaDescription(productData As Dictionary(Of String, Object)) As String
        Dim urunAdi As String = If(productData.ContainsKey("sAciklama"), productData("sAciklama").ToString(), "")
        Dim marka As String = If(productData.ContainsKey("sMarka"), productData("sMarka").ToString(), "")
        Dim kategori As String = If(productData.ContainsKey("sKategori"), productData("sKategori").ToString(), "")
        
        ' Sektör tespiti yap
        Dim sektor As String = TespitSektor(kategori, urunAdi)
        Log("DEBUG", "GenerateMetaDescription", $"Ürün: {urunAdi}, Marka: {marka}, Kategori: {kategori}, Sektör: {sektor}")
        
        ' Sektöre göre yasakları belirle
        Dim yasaklar As String = ""
        Select Case sektor
            Case "Züccaciye"
                yasaklar = "ASLA 'Unisex', '%100 Pamuk', 'Beden' gibi GİYİM TERİMLERİ KULLANMA!"
            Case "Elektronik"
                yasaklar = "ASLA 'Unisex', '%100 Pamuk', 'Beden' gibi GİYİM TERİMLERİ KULLANMA!"
        End Select
        
        Dim prompt As String = $"
Aşağıdaki ürün için SEO meta description yaz (maksimum 160 karakter):

Ürün: {urunAdi}
Marka: {marka}
Kategori: {kategori}
Tespit Edilen Sektör: {sektor}

Kurallar:
- Maksimum 160 karakter
- Kısa, çekici ve arama motorları için optimize edilmiş olsun
- Marka adını kullan (eğer varsa)
- {yasaklar}

SADECE META DESCRIPTION'I DÖNDÜR!"

        Return CallOpenAI(prompt, 80)
    End Function
    
    ' ========== PROMPT ŞABLONLARI ==========
    
    Private Function GetTextileInstructionPrompt(productData As Dictionary(Of String, Object)) As String
        Return $"
Sen bir tekstil uzmanısın. Aşağıdaki ürün için yıkama ve bakım talimatları oluştur.

Ürün: {productData("sAciklama")}

HTML formatında şu başlıkları kullan:
📋 Genel Bilgiler
🧺 Yıkama (sıcaklık, deterjan)
&#128084;#128084; Kurutma
&#128293;#128293; Ütü
⚠️ Dikkat Edilecekler

200-250 kelime. SADECE TALİMATLARI DÖNDÜR!"
    End Function
    
    Private Function GetShoeInstructionPrompt(productData As Dictionary(Of String, Object)) As String
        Return $"
Sen bir ayakkabı bakım uzmanısın. Aşağıdaki ürün için kullanım ve bakım talimatları oluştur.

Ürün: {productData("sAciklama")}

HTML formatında:
👟 İlk Kullanım
&#129532;#129532; Temizlik
💧 Kurulama
&#128737;#128737; Koruma
&#128230;#128230; Saklama

200-250 kelime. SADECE TALİMATLARI DÖNDÜR!"
    End Function
    
    Private Function GetGlasswareInstructionPrompt(productData As Dictionary(Of String, Object)) As String
        Return $"
Sen bir ev eşyaları uzmanısın. Aşağıdaki ürün için kullanım talimatları oluştur.

Ürün: {productData("sAciklama")}

HTML formatında:
&#127869;#127869;️#127869; Kullanım
🧽 Temizlik
  - Bulaşık Makinesinde Yıkanabilir mi? (&#10003;#10003;/&#10060;#10060;)
  - Hangi program?
💦 Kurulama
⚠️ Dikkat Edilecekler

200-250 kelime. SADECE TALİMATLARI DÖNDÜR!"
    End Function
    
    Private Function GetElectronicsInstructionPrompt(productData As Dictionary(Of String, Object)) As String
        Return $"
Sen bir elektronik ürün uzmanısın. Aşağıdaki ürün için güvenli kullanım talimatları oluştur.

Ürün: {productData("sAciklama")}

HTML formatında:
🔌 İlk Kullanım
⚡ Güvenlik
&#129529;#129529; Temizlik
🔋 Pil/Şarj
⚠️ Uyarılar
&#9851;#9851; WEEE

250-300 kelime. SADECE TALİMATLARI DÖNDÜR!"
    End Function
    
    Private Function GetGenericInstructionPrompt(productData As Dictionary(Of String, Object)) As String
        Return $"
Aşağıdaki ürün için genel kullanım ve bakım talimatları oluştur.

Ürün: {productData("sAciklama")}

HTML formatında:
📋 Kullanım
🧽 Bakım
⚠️ Dikkat
&#128230;#128230; Saklama

150-200 kelime. SADECE TALİMATLARI DÖNDÜR!"
    End Function
    
    ' ========== OPENAI API ==========
    
    ' Rate limit için değişkenler
    Private Shared lastApiCallTime As DateTime = DateTime.MinValue
    Private Const MIN_CALL_INTERVAL_MS As Integer = 3000 ' Her API çağrısı arası en az 3 saniye
    Private Shared apiCallLock As New Object()
    
    Public Function CallOpenAI(prompt As String, maxTokens As Integer) As String
        ' Rate limit koruması - aynı anda çok fazla istek gönderme
        SyncLock apiCallLock
            Dim timeSinceLastCall = DateTime.Now.Subtract(lastApiCallTime).TotalMilliseconds
            If timeSinceLastCall < MIN_CALL_INTERVAL_MS Then
                Dim waitTime = CInt(MIN_CALL_INTERVAL_MS - timeSinceLastCall)
                Log("INFO", "CallOpenAI", $"Rate limit koruması - {waitTime}ms bekleniyor...")
                System.Threading.Thread.Sleep(waitTime)
            End If
            lastApiCallTime = DateTime.Now
        End SyncLock
        
        ' Retry mekanizması - 5 deneme
        Dim maxRetries As Integer = 5
        Dim retryCount As Integer = 0
        Dim lastError As String = ""
        
        While retryCount < maxRetries
            Try
                ' Key'leri yeniden yükle (güncel değerler için)
                LoadApiKey()
                
                ' Hangi key'i kullanacağımıza karar ver
                Dim apiKey As String = ""
                Dim model As String = "gpt-4o"
                
                If Not String.IsNullOrEmpty(openaiApiKey) Then
                    ' OpenAI key varsa onu kullan
                    apiKey = openaiApiKey
                    model = "gpt-4o-mini"  ' gpt-4o yerine gpt-4o-mini kullan - 6x daha yüksek rate limit!
                    Log("INFO", "CallOpenAI", "OpenAI key kullanılıyor (model: gpt-4o-mini)")
                ElseIf Not String.IsNullOrEmpty(emergentApiKey) Then
                    ' Yoksa Emergent key kullan
                    apiKey = emergentApiKey
                    model = "gpt-4o-mini"
                    Log("INFO", "CallOpenAI", "Emergent key kullanılıyor (model: gpt-4o-mini)")
                Else
                    Log("ERROR", "CallOpenAI", "Hiçbir API key bulunamadı!")
                    Return "API key bulunamadı (Lütfen AI Ayarları'ndan key girin)"
                End If
                
                Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
                
                Dim requestData As New Dictionary(Of String, Object) From {
                    {"model", model},
                    {"messages", New List(Of Object) From {
                        New Dictionary(Of String, String) From {
                            {"role", "user"},
                            {"content", prompt}
                        }
                    }},
                    {"max_tokens", maxTokens},
                    {"temperature", 0.7}
                }
                
                Dim jsonRequest As String = JsonConvert.SerializeObject(requestData)
                
                Using client As New WebClient()
                    client.Encoding = System.Text.Encoding.UTF8
                    client.Headers.Add("Content-Type", "application/json")
                    client.Headers.Add("Authorization", $"Bearer {apiKey}")
                    
                    Dim response As String = client.UploadString(apiUrl, "POST", jsonRequest)
                    Dim jsonResponse As JObject = JObject.Parse(response)
                    
                    ' Token kullanımını logla
                    Try
                        Dim usage As JObject = CType(jsonResponse("usage"), JObject)
                        If usage IsNot Nothing Then
                            Dim promptTokens As Integer = Convert.ToInt32(usage("prompt_tokens"))
                            Dim completionTokens As Integer = Convert.ToInt32(usage("completion_tokens"))
                            Dim totalTokens As Integer = Convert.ToInt32(usage("total_tokens"))
                            
                            ' Maliyet hesapla (gpt-4o-mini fiyatları)
                            Dim inputCost As Decimal = (promptTokens / 1000000D) * 0.15D ' $0.15 per 1M input tokens
                            Dim outputCost As Decimal = (completionTokens / 1000000D) * 0.60D ' $0.60 per 1M output tokens
                            Dim totalCost As Decimal = inputCost + outputCost
                            
                            LogTokenUsage(model, promptTokens, completionTokens, totalTokens, totalCost)
                        End If
                    Catch
                        ' Token loglama hatası - devam et
                    End Try
                    
                    Return jsonResponse("choices")(0)("message")("content").ToString().Trim()
                End Using
                
            Catch webEx As WebException
                Dim errorMsg As String = webEx.Message
                Dim statusCode As Integer = 0
                
                If webEx.Response IsNot Nothing Then
                    Dim httpResponse = TryCast(webEx.Response, HttpWebResponse)
                    If httpResponse IsNot Nothing Then
                        statusCode = CInt(httpResponse.StatusCode)
                    End If
                    Using reader As New StreamReader(webEx.Response.GetResponseStream())
                        errorMsg = reader.ReadToEnd()
                    End Using
                End If
                
                Log("ERROR", "CallOpenAI", $"HTTP {statusCode}: {errorMsg}")
                
                ' 429 Too Many Requests - Rate Limit
                If statusCode = 429 OrElse errorMsg.Contains("429") OrElse errorMsg.Contains("Too Many Requests") OrElse errorMsg.Contains("rate_limit") Then
                    retryCount += 1
                    If retryCount < maxRetries Then
                        ' Çok daha uzun bekleme: 30s, 60s, 120s, 180s, 240s
                        Dim waitSeconds As Integer = 30 * retryCount
                        Log("WARN", "CallOpenAI", $"429 Rate Limit! {waitSeconds} saniye bekleniyor... (Deneme {retryCount}/{maxRetries})")
                        System.Threading.Thread.Sleep(waitSeconds * 1000)
                        Continue While
                    Else
                        lastError = $"API Hatası: Rate limit aşıldı (5 deneme yapıldı). Hata: {errorMsg}"
                    End If
                ' 401 Unauthorized - API Key hatası
                ElseIf statusCode = 401 OrElse errorMsg.Contains("401") OrElse errorMsg.Contains("invalid_api_key") Then
                    Return $"API Hatası: Geçersiz API Key. Lütfen AI Ayarları'ndan yeni key girin. (Detay: {errorMsg})"
                ' 500+ Server Error
                ElseIf statusCode >= 500 Then
                    retryCount += 1
                    If retryCount < maxRetries Then
                        Log("WARN", "CallOpenAI", $"Sunucu hatası ({statusCode}). 3 saniye sonra tekrar denenecek...")
                        System.Threading.Thread.Sleep(3000)
                        Continue While
                    End If
                    lastError = $"API Hatası: Sunucu hatası ({statusCode}). Lütfen daha sonra tekrar deneyin."
                Else
                    lastError = $"API Hatası: {webEx.Message}"
                End If
                
                Log("ERROR", "CallOpenAI", $"WebException: {errorMsg}")
                Exit While
                
            Catch ex As Exception
                Log("ERROR", "CallOpenAI", ex.Message)
                lastError = $"Hata: {ex.Message}"
                Exit While
            End Try
        End While
        
        Return lastError
    End Function
    
    Private Sub Log(level As String, func As String, message As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logMessage As String = $"[{timestamp}] [{level}] [{func}] {message}"
            Console.WriteLine(logMessage)
            File.AppendAllText(logFile, logMessage & vbCrLf)
            
            ' ERROR seviyesindeki logları C:\AI\log.txt dosyasına da yaz
            If level = "ERROR" OrElse level = "WARN" Then
                WriteToAILogFile(logMessage)
            End If
        Catch
        End Try
    End Sub
    
    ''' <summary>
    ''' AI hatalarını C:\AI\log.txt dosyasına yazar
    ''' </summary>
    Private Sub WriteToAILogFile(message As String)
        Try
            Dim aiLogFolder As String = "C:\AI"
            Dim aiLogFile As String = Path.Combine(aiLogFolder, "log.txt")
            
            ' Klasör yoksa oluştur
            If Not Directory.Exists(aiLogFolder) Then
                Directory.CreateDirectory(aiLogFolder)
            End If
            
            ' Log dosyasına yaz
            File.AppendAllText(aiLogFile, message & vbCrLf)
        Catch
            ' Log dosyasına yazma hatası - sessizce devam et
        End Try
    End Sub
    
    ''' <summary>
    ''' Token kullanımını veritabanına ve log dosyasına kaydet
    ''' </summary>
    Private Sub LogTokenUsage(model As String, promptTokens As Integer, completionTokens As Integer, totalTokens As Integer, cost As Decimal)
        Try
            ' Log dosyasına yaz
            Dim tokenLogFile As String = "AI_Token_Usage.log"
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logMessage As String = $"[{timestamp}] Model={model}, PromptTokens={promptTokens}, CompletionTokens={completionTokens}, TotalTokens={totalTokens}, Cost=${cost:F6}"
            File.AppendAllText(tokenLogFile, logMessage & vbCrLf)
            
            ' Günlük özet dosyasına yaz
            Dim summaryFile As String = $"AI_Usage_{DateTime.Now:yyyyMMdd}.csv"
            If Not File.Exists(summaryFile) Then
                File.WriteAllText(summaryFile, "Tarih;Saat;Model;PromptTokens;CompletionTokens;TotalTokens;Cost_USD" & vbCrLf)
            End If
            File.AppendAllText(summaryFile, $"{DateTime.Now:yyyy-MM-dd};{DateTime.Now:HH:mm:ss};{model};{promptTokens};{completionTokens};{totalTokens};{cost:F6}" & vbCrLf)
            
            ' Veritabanına kaydet (tablo varsa)
            Try
                Using conn As New OleDb.OleDbConnection(connection)
                    conn.Open()
                    
                    Dim cmd As New OleDb.OleDbCommand(
                        "INSERT INTO tbAITokenKullanim (sModel, nPromptTokens, nCompletionTokens, nTotalTokens, nMaliyetUSD, dteTarih) " &
                        "VALUES (?, ?, ?, ?, ?, GETDATE())", conn)
                    cmd.Parameters.AddWithValue("?", model)
                    cmd.Parameters.AddWithValue("?", promptTokens)
                    cmd.Parameters.AddWithValue("?", completionTokens)
                    cmd.Parameters.AddWithValue("?", totalTokens)
                    cmd.Parameters.AddWithValue("?", cost)
                    cmd.ExecuteNonQuery()
                End Using
            Catch
                ' Tablo yoksa sessizce devam et
            End Try
            
        Catch ex As Exception
            ' Token loglama hatası - ana işlemi etkilemesin
            Debug.WriteLine("Token loglama hatası: " & ex.Message)
        End Try
    End Sub
    
    ' ========================================================================
    ' KAPSAMLI İÇERİK OLUŞTURMA SİSTEMİ (v2.0)
    ' ========================================================================
    ' Tek API çağrısı ile tüm içerikleri oluşturur
    ' ========================================================================
    
    ''' <summary>
    ''' Kapsamlı ürün içeriği oluşturur (tek API çağrısı)
    ''' Açıklama, Özellikler, Beden Tablosu, SEO bilgileri
    ''' </summary>
    Public Function GenerateCompleteContent(productData As Dictionary(Of String, Object)) As Dictionary(Of String, String)
        Dim result As New Dictionary(Of String, String)
        result("success") = "false"
        
        Try
            ' Ürün bilgilerini topla (marka artık AIContentManager'da doğru set ediliyor)
            Dim urunAdi As String = If(productData.ContainsKey("sAciklama"), productData("sAciklama").ToString(), "")
            Dim marka As String = If(productData.ContainsKey("sMarka"), productData("sMarka").ToString(), "")
            
            Dim kategori As String = If(productData.ContainsKey("sKategori"), productData("sKategori").ToString(), "")
            Dim cinsiyet As String = If(productData.ContainsKey("sCinsiyet"), productData("sCinsiyet").ToString(), "")
            Dim yasGrubu As String = If(productData.ContainsKey("sYasGrubu"), productData("sYasGrubu").ToString(), "")
            Dim kumasBilgisi As String = If(productData.ContainsKey("sKumasBilgisi"), productData("sKumasBilgisi").ToString(), "")
            Dim renkler As String = If(productData.ContainsKey("sRenkler"), productData("sRenkler").ToString(), "")
            Dim bedenler As String = If(productData.ContainsKey("sBedenler"), productData("sBedenler").ToString(), "")
            Dim sezon As String = If(productData.ContainsKey("sSezon"), productData("sSezon").ToString(), "")
            Dim fiyat As String = If(productData.ContainsKey("lFiyat"), productData("lFiyat").ToString(), "")
            
            ' Kategori tespiti
            Dim kategoriBilgisi As String = GetKategoriBilgisi(kategori, cinsiyet, yasGrubu)
            
            ' ===== WEB'DEN ÜRÜN BİLGİSİ ÇEKME (YENİ) =====
            Dim webBilgisi As String = ""
            Try
                webBilgisi = GetProductInfoFromWeb(urunAdi, marka)
                If Not String.IsNullOrEmpty(webBilgisi) Then
                    Log("SUCCESS", "GenerateCompleteContent", $"Web'den ürün bilgisi alındı: {urunAdi}")
                End If
            Catch webEx As Exception
                Log("WARNING", "GenerateCompleteContent", $"Web araması başarısız, yerel üretim yapılacak: {webEx.Message}")
            End Try
            
            ' Kapsamlı prompt oluştur (web bilgisi varsa ekle)
            Dim prompt As String = BuildComprehensivePrompt(urunAdi, marka, kategoriBilgisi, cinsiyet, yasGrubu, kumasBilgisi, renkler, bedenler, sezon, fiyat, webBilgisi)
            
            ' API'yi çağır (daha yüksek token limiti)
            Dim response As String = CallOpenAI(prompt, 2000)
            
            If String.IsNullOrEmpty(response) OrElse response.Contains("API key bulunamadı") Then
                result("error") = "API yanıt vermedi"
                Return result
            End If
            
            ' JSON yanıtı parse et
            result = ParseCompleteContentResponse(response)
            
            If result.ContainsKey("description") AndAlso Not String.IsNullOrEmpty(result("description")) Then
                result("success") = "true"
                Log("SUCCESS", "GenerateCompleteContent", $"İçerik başarıyla oluşturuldu: {urunAdi}")
            End If
            
        Catch ex As Exception
            result("error") = ex.Message
            Log("ERROR", "GenerateCompleteContent", ex.Message)
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' Web'den ürün bilgisi çeker - Google Custom Search API ile marka sitesinden arama yapar
    ''' Önce tbMarkaSiteleri'nde kayıtlı site var mı bakar, varsa o sitede arar
    ''' Yoksa normal arar ve bulunan siteyi kaydeder
    ''' </summary>
    Private Function GetProductInfoFromWeb(urunAdi As String, marka As String) As String
        Dim baslangicZamani As DateTime = DateTime.Now
        Dim bulunanSiteDomain As String = ""
        
        Try
            LogWebArama("========== WEB ARAMA BAŞLADI ==========")
            LogWebArama($"Ürün Adı: {urunAdi}")
            LogWebArama($"Marka: {If(String.IsNullOrEmpty(marka), "(YOK)", marka)}")
            
            ' API key kontrolü
            If String.IsNullOrEmpty(googleSearchApiKey) OrElse String.IsNullOrEmpty(googleSearchEngineId) Then
                LogWebArama("❌ HATA: Google API key bulunamadı!")
                Log("WARNING", "GetProductInfoFromWeb", "Google API key bulunamadı, web araması atlanıyor")
                Return ""
            End If
            
            LogWebArama($"✓ API Key: {googleSearchApiKey.Substring(0, 10)}...")
            LogWebArama($"✓ Engine ID: {googleSearchEngineId}")
            
            ' ===== MARKA SİTESİ ÖNBELLEK KONTROLÜ =====
            Dim kayitliSite As String = ""
            If Not String.IsNullOrEmpty(marka) Then
                kayitliSite = GetMarkaSitesi(marka)
                If Not String.IsNullOrEmpty(kayitliSite) Then
                    LogWebArama($"")
                    LogWebArama($"🎯 ÖNBELLEKTE MARKA SİTESİ BULUNDU: {kayitliSite}")
                    LogWebArama($"   Öncelikli olarak bu sitede aranacak!")
                End If
            End If
            
            ' Arama sorgusu oluştur
            Dim searchQuery As String = ""
            If Not String.IsNullOrEmpty(kayitliSite) Then
                ' Önbellekte site varsa: site:domain.com marka ürün
                searchQuery = $"site:{kayitliSite} {marka} {urunAdi}"
                LogWebArama($"📍 Site-spesifik arama: {searchQuery}")
            ElseIf Not String.IsNullOrEmpty(marka) Then
                ' Marka var ama site yok: normal arama
                searchQuery = $"{marka} {urunAdi}"
            Else
                searchQuery = urunAdi
            End If
            
            LogWebArama($"")
            LogWebArama($"🔍 GOOGLE ARAMA SORGUSU: {searchQuery}")
            Log("INFO", "GetProductInfoFromWeb", $"🔍 Google'da arama yapılıyor: {searchQuery}")
            
            ' Google Custom Search API URL
            Dim searchUrl As String = "https://www.googleapis.com/customsearch/v1?" &
                                     $"key={googleSearchApiKey}&" &
                                     $"cx={googleSearchEngineId}&" &
                                     $"q={Uri.EscapeDataString(searchQuery)}&" &
                                     "num=5&" &
                                     "lr=lang_tr"
            
            Dim webResults As New System.Text.StringBuilder()
            Dim sonucBulundu As Boolean = False
            
            Using client As New WebClient()
                client.Encoding = System.Text.Encoding.UTF8
                client.Headers.Add("User-Agent", "Mozilla/5.0")
                
                LogWebArama($"")
                LogWebArama($"📡 Google API çağrılıyor...")
                Dim apiBaslangic As DateTime = DateTime.Now
                
                Dim response As String = client.DownloadString(searchUrl)
                
                Dim apiSure As Double = (DateTime.Now - apiBaslangic).TotalMilliseconds
                LogWebArama($"✓ Google API yanıt aldı ({apiSure:N0} ms)")
                
                Dim jsonResponse As JObject = JObject.Parse(response)
                
                ' Toplam sonuç sayısı
                Dim totalResults As String = ""
                If jsonResponse("searchInformation") IsNot Nothing AndAlso jsonResponse("searchInformation")("totalResults") IsNot Nothing Then
                    totalResults = jsonResponse("searchInformation")("totalResults").ToString()
                    LogWebArama($"📊 Toplam sonuç: {totalResults}")
                End If
                
                If jsonResponse("items") IsNot Nothing Then
                    Dim items As JArray = CType(jsonResponse("items"), JArray)
                    Dim resultCount As Integer = 0
                    
                    LogWebArama($"")
                    LogWebArama($"========== GOOGLE SONUÇLARI ==========")
                    
                    For Each item As JObject In items
                        If resultCount >= 3 Then Exit For
                        
                        Dim title As String = If(item("title") IsNot Nothing, item("title").ToString(), "")
                        Dim snippet As String = If(item("snippet") IsNot Nothing, item("snippet").ToString(), "")
                        Dim link As String = If(item("link") IsNot Nothing, item("link").ToString(), "")
                        
                        If Not String.IsNullOrEmpty(snippet) Then
                            LogWebArama($"")
                            LogWebArama($"--- Sonuç #{resultCount + 1} ---")
                            LogWebArama($"Başlık: {title}")
                            LogWebArama($"URL: {link}")
                            LogWebArama($"Snippet: {snippet}")
                            
                            ' İlk sonuçtan site domain'ini çıkar (önbellek için)
                            If resultCount = 0 AndAlso Not String.IsNullOrEmpty(link) Then
                                bulunanSiteDomain = ExtractDomainFromUrl(link)
                                LogWebArama($"🌐 Bulunan Site Domain: {bulunanSiteDomain}")
                            End If
                            
                            webResults.AppendLine($"📌 Kaynak: {title}")
                            webResults.AppendLine($"   {snippet}")
                            webResults.AppendLine($"   URL: {link}")
                            webResults.AppendLine()
                            resultCount += 1
                            sonucBulundu = True
                        End If
                    Next
                    
                    LogWebArama($"")
                    LogWebArama($"✅ Kullanılan sonuç sayısı: {resultCount}")
                    Log("INFO", "GetProductInfoFromWeb", $"✅ {resultCount} Google sonucu bulundu")
                Else
                    LogWebArama($"⚠️ Google'dan sonuç bulunamadı!")
                    
                    ' Hata mesajı var mı kontrol et
                    If jsonResponse("error") IsNot Nothing Then
                        Dim errorMsg As String = jsonResponse("error")("message").ToString()
                        LogWebArama($"❌ Google API Hatası: {errorMsg}")
                    End If
                    
                    Log("WARNING", "GetProductInfoFromWeb", "Google'dan sonuç bulunamadı")
                End If
            End Using
            
            ' Sonuç yoksa boş döndür
            If webResults.Length = 0 Then
                LogWebArama($"")
                LogWebArama($"❌ Web sonucu yok, işlem sonlandırılıyor")
                LogWebArama($"========== WEB ARAMA BİTTİ (Süre: {(DateTime.Now - baslangicZamani).TotalMilliseconds:N0} ms) ==========")
                Return ""
            End If
            
            ' Google sonuçlarını AI'a ver
            LogWebArama($"")
            LogWebArama($"========== AI ANALİZİ BAŞLIYOR ==========")
            
            Dim webData As String = webResults.ToString()
            LogWebArama($"AI'a gönderilen veri uzunluğu: {webData.Length} karakter")
            
            Dim extractPrompt As String = $"
Aşağıda Google'dan alınan ürün bilgileri var. Bu bilgilerden SADECE GERÇEK teknik özellikleri çıkar.

ÜRÜN: {marka} {urunAdi}

GOOGLE SONUÇLARI:
{webData}

İstenen bilgiler (sadece bulabilirsen yaz, yoksa o satırı ATLAMA):
- Malzeme/Materyal (örn: 18/10 Paslanmaz Çelik, Kristal, Seramik, vs.)
- Boyutlar (cm, lt, ml, kapasite)
- Set içeriği (kaç parça, hangi parçalar)
- Önemli özellikler (indüksiyon uyumlu, bulaşık makinesine uygun, vs.)
- Üretim ülkesi
- Garanti süresi

KURALLAR:
- SADECE yukarıdaki Google sonuçlarındaki BİLGİLERİ kullan!
- UYDURMA! Kaynakta olmayan bilgi YAZMA!
- Bulamadığın bilgiyi atlama, yazmaya çalışma
- Kısa ve öz yaz, madde madde listele
"
            
            LogWebArama($"AI API çağrılıyor...")
            Dim aiBaslangic As DateTime = DateTime.Now
            
            Dim extractedInfo As String = CallOpenAI(extractPrompt, 500)
            
            Dim aiSure As Double = (DateTime.Now - aiBaslangic).TotalMilliseconds
            LogWebArama($"✓ AI yanıt aldı ({aiSure:N0} ms)")
            
            If Not String.IsNullOrEmpty(extractedInfo) Then
                LogWebArama($"")
                LogWebArama($"========== AI ÇIKTISI ==========")
                LogWebArama(extractedInfo)
                LogWebArama($"================================")
                
                ' ===== MARKA SİTESİNİ KAYDET (başarılı sonuç) =====
                If Not String.IsNullOrEmpty(marka) AndAlso Not String.IsNullOrEmpty(bulunanSiteDomain) Then
                    SaveMarkaSitesi(marka, bulunanSiteDomain, True)
                    LogWebArama($"💾 Marka sitesi kaydedildi: {marka} -> {bulunanSiteDomain}")
                End If
                
                Log("SUCCESS", "GetProductInfoFromWeb", $"🎯 Web bilgisi çıkarıldı: {extractedInfo.Substring(0, Math.Min(100, extractedInfo.Length))}...")
                
                Dim toplamSure As Double = (DateTime.Now - baslangicZamani).TotalMilliseconds
                LogWebArama($"")
                LogWebArama($"✅ WEB ARAMA BAŞARILI!")
                LogWebArama($"========== WEB ARAMA BİTTİ (Toplam Süre: {toplamSure:N0} ms) ==========")
                LogWebArama($"")
                
                Return extractedInfo
            Else
                LogWebArama($"⚠️ AI boş yanıt döndürdü!")
                
                ' Başarısız sonuç - yine de siteyi kaydet (kullanım sayısı için)
                If Not String.IsNullOrEmpty(marka) AndAlso Not String.IsNullOrEmpty(bulunanSiteDomain) Then
                    SaveMarkaSitesi(marka, bulunanSiteDomain, False)
                End If
            End If
            
            LogWebArama($"========== WEB ARAMA BİTTİ (Süre: {(DateTime.Now - baslangicZamani).TotalMilliseconds:N0} ms) ==========")
            Return ""
            
        Catch webEx As WebException
            LogWebArama($"❌ GOOGLE API HATASI: {webEx.Message}")
            If webEx.Response IsNot Nothing Then
                Try
                    Using reader As New StreamReader(webEx.Response.GetResponseStream())
                        Dim errorBody As String = reader.ReadToEnd()
                        LogWebArama($"Hata Detayı: {errorBody}")
                    End Using
                Catch
                End Try
            End If
            Log("ERROR", "GetProductInfoFromWeb", $"Google API hatası: {webEx.Message}")
            Return ""
        Catch ex As Exception
            LogWebArama($"❌ GENEL HATA: {ex.Message}")
            LogWebArama($"Stack: {ex.StackTrace}")
            Log("ERROR", "GetProductInfoFromWeb", $"Genel hata: {ex.Message}")
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' URL'den domain çıkarır (örn: https://www.zwilling.com.tr/urun -> zwilling.com.tr)
    ''' </summary>
    Private Function ExtractDomainFromUrl(url As String) As String
        Try
            If String.IsNullOrEmpty(url) Then Return ""
            
            Dim uri As New Uri(url)
            Dim host As String = uri.Host.ToLower()
            
            ' www. önekini kaldır
            If host.StartsWith("www.") Then
                host = host.Substring(4)
            End If
            
            Return host
        Catch
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' tbMarkaSiteleri tablosundan marka için kayıtlı site domain'ini getirir
    ''' Önce parametrik sınıf eşlemesinden firmanın markalarını kontrol eder
    ''' </summary>
    Private Function GetMarkaSitesi(marka As String) As String
        Try
            If String.IsNullOrEmpty(marka) Then Return ""
            
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' ===== 1. PARAMETRIK SINIF EŞLEMESİNDEN MARKA KONTROLÜ =====
                ' Firmanın marka sınıfını bul
                Dim markaField As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_MARKA", "sSinifKodu3")
                
                ' Marka bu firmada tanımlı mı kontrol et (tbSSinifX tablosundan)
                If markaField.StartsWith("sSinifKodu") Then
                    Dim sinifNo As String = markaField.Replace("sSinifKodu", "")
                    Dim sinifTablosu As String = $"tbSSinif{sinifNo}"
                    
                    ' Markanın firma sınıflarında kayıtlı olup olmadığını kontrol et
                    Using checkCmd As New OleDb.OleDbCommand(
                        $"SELECT COUNT(*) FROM {sinifTablosu} WHERE UPPER(sAciklama) LIKE UPPER(?)", conn)
                        checkCmd.Parameters.AddWithValue("?", "%" & marka.Trim() & "%")
                        
                        Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                        If count = 0 Then
                            LogWebArama($"⚠️ Marka '{marka}' firmada tanımlı değil ({sinifTablosu}), site önbelleği atlanıyor")
                            conn.Close()
                            Return ""
                        Else
                            LogWebArama($"✓ Marka '{marka}' firmada tanımlı ({sinifTablosu})")
                        End If
                    End Using
                End If
                
                ' ===== 2. tbMarkaSiteleri'NDEN SİTE BUL =====
                ' En çok başarılı sonuç veren ve aktif olan siteyi getir
                Using cmd As New OleDb.OleDbCommand(
                    "SELECT TOP 1 sSiteDomain FROM tbMarkaSiteleri " &
                    "WHERE UPPER(sMarka) = UPPER(?) AND bAktif = 1 " &
                    "ORDER BY nBasariliSonuc DESC, nKullanimSayisi DESC", conn)
                    
                    cmd.Parameters.AddWithValue("?", marka.Trim())
                    
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        Dim siteDomain As String = result.ToString().Trim()
                        
                        ' Kullanım sayısını artır
                        Using updateCmd As New OleDb.OleDbCommand(
                            "UPDATE tbMarkaSiteleri SET nKullanimSayisi = nKullanimSayisi + 1, " &
                            "dSonKullanim = GETDATE() WHERE UPPER(sMarka) = UPPER(?) AND sSiteDomain = ?", conn)
                            updateCmd.Parameters.AddWithValue("?", marka.Trim())
                            updateCmd.Parameters.AddWithValue("?", siteDomain)
                            updateCmd.ExecuteNonQuery()
                        End Using
                        
                        Return siteDomain
                    End If
                End Using
                
                conn.Close()
            End Using
            
            Return ""
        Catch ex As Exception
            Log("ERROR", "GetMarkaSitesi", ex.Message)
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' Parametrik sınıf eşleme ayarını okur (tbSistemAyar'dan)
    ''' </summary>
    Private Function GetSinifEslemeAyar(conn As OleDb.OleDbConnection, ayarKodu As String, varsayilan As String) As String
        Try
            Using cmd As New OleDb.OleDbCommand($"SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'", conn)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Return result.ToString()
                End If
            End Using
        Catch
        End Try
        Return varsayilan
    End Function
    
    ''' <summary>
    ''' Marka sitesini tbMarkaSiteleri tablosuna kaydeder veya günceller
    ''' Sadece firmada tanımlı markaları kaydeder (parametrik sınıf eşlemesinden)
    ''' </summary>
    Private Sub SaveMarkaSitesi(marka As String, siteDomain As String, basarili As Boolean)
        Try
            If String.IsNullOrEmpty(marka) OrElse String.IsNullOrEmpty(siteDomain) Then Exit Sub
            
            ' Pazaryeri ve genel siteleri kaydetme
            Dim excludedDomains() As String = {"trendyol.com", "hepsiburada.com", "n11.com", "amazon.com.tr", 
                                                "gittigidiyor.com", "ciceksepeti.com", "akakce.com", "cimri.com",
                                                "google.com", "youtube.com", "facebook.com", "instagram.com"}
            
            For Each excludedDomain As String In excludedDomains
                If siteDomain.Contains(excludedDomain) Then
                    LogWebArama($"⚠️ Pazaryeri/genel site kaydedilmedi: {siteDomain}")
                    Exit Sub
                End If
            Next
            
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' ===== PARAMETRIK SINIF EŞLEMESİNDEN MARKA KONTROLÜ =====
                ' Sadece firmada tanımlı markaları kaydet
                Dim markaField As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_MARKA", "sSinifKodu3")
                
                If markaField.StartsWith("sSinifKodu") Then
                    Dim sinifNo As String = markaField.Replace("sSinifKodu", "")
                    Dim sinifTablosu As String = $"tbSSinif{sinifNo}"
                    
                    ' Markanın firma sınıflarında kayıtlı olup olmadığını kontrol et
                    Using checkMarkaCmd As New OleDb.OleDbCommand(
                        $"SELECT COUNT(*) FROM {sinifTablosu} WHERE UPPER(sAciklama) LIKE UPPER(?)", conn)
                        checkMarkaCmd.Parameters.AddWithValue("?", "%" & marka.Trim() & "%")
                        
                        Dim count As Integer = CInt(checkMarkaCmd.ExecuteScalar())
                        If count = 0 Then
                            LogWebArama($"⚠️ Marka '{marka}' firmada tanımlı değil, site kaydedilmedi")
                            conn.Close()
                            Exit Sub
                        End If
                    End Using
                End If
                
                ' Mevcut kayıt var mı kontrol et
                Dim mevcutID As Integer = 0
                Using checkCmd As New OleDb.OleDbCommand(
                    "SELECT nID FROM tbMarkaSiteleri WHERE UPPER(sMarka) = UPPER(?) AND sSiteDomain = ?", conn)
                    checkCmd.Parameters.AddWithValue("?", marka.Trim())
                    checkCmd.Parameters.AddWithValue("?", siteDomain)
                    
                    Dim result = checkCmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        mevcutID = CInt(result)
                    End If
                End Using
                
                If mevcutID > 0 Then
                    ' Güncelle
                    Using updateCmd As New OleDb.OleDbCommand(
                        "UPDATE tbMarkaSiteleri SET nKullanimSayisi = nKullanimSayisi + 1, " &
                        "nBasariliSonuc = nBasariliSonuc + ?, dSonKullanim = GETDATE() WHERE nID = ?", conn)
                        updateCmd.Parameters.AddWithValue("?", If(basarili, 1, 0))
                        updateCmd.Parameters.AddWithValue("?", mevcutID)
                        updateCmd.ExecuteNonQuery()
                    End Using
                    LogWebArama($"📝 Marka sitesi güncellendi: {marka} -> {siteDomain} (Başarılı: {basarili})")
                Else
                    ' Yeni kayıt ekle
                    Using insertCmd As New OleDb.OleDbCommand(
                        "INSERT INTO tbMarkaSiteleri (sMarka, sSiteDomain, sSiteUrl, nKullanimSayisi, nBasariliSonuc) " &
                        "VALUES (?, ?, ?, 1, ?)", conn)
                        insertCmd.Parameters.AddWithValue("?", marka.Trim().ToUpper())
                        insertCmd.Parameters.AddWithValue("?", siteDomain)
                        insertCmd.Parameters.AddWithValue("?", $"https://www.{siteDomain}")
                        insertCmd.Parameters.AddWithValue("?", If(basarili, 1, 0))
                        insertCmd.ExecuteNonQuery()
                    End Using
                    LogWebArama($"✨ YENİ marka sitesi kaydedildi: {marka} -> {siteDomain}")
                End If
                
                conn.Close()
            End Using
        Catch ex As Exception
            Log("ERROR", "SaveMarkaSitesi", ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Web arama işlemleri için detaylı log dosyası
    ''' </summary>
    Private Sub LogWebArama(mesaj As String)
        Try
            Dim logFolder As String = "C:\AI\Logs"
            If Not Directory.Exists(logFolder) Then
                Directory.CreateDirectory(logFolder)
            End If
            
            Dim logFile As String = Path.Combine(logFolder, $"WebArama_{DateTime.Now:yyyy-MM-dd}.log")
            Dim logLine As String = $"[{DateTime.Now:HH:mm:ss.fff}] {mesaj}"
            
            File.AppendAllText(logFile, logLine & Environment.NewLine)
        Catch
            ' Log yazılamazsa sessizce devam et
        End Try
    End Sub
    
    ''' <summary>
    ''' Kapsamlı prompt oluşturur - SEKTÖRE GÖRE FARKLI PROMPT
    ''' </summary>
    Private Function BuildComprehensivePrompt(urunAdi As String, marka As String, kategori As String, 
                                               cinsiyet As String, yasGrubu As String, kumas As String,
                                               renkler As String, bedenler As String, sezon As String, fiyat As String,
                                               Optional webBilgisi As String = "") As String
        
        ' ===== SEKTÖR TESPİTİ =====
        Dim sektor As String = TespitSektor(kategori, urunAdi)
        
        ' Sektöre göre uygun base prompt al
        Dim basePrompt As String = ""
        Select Case sektor
            Case "Züccaciye"
                basePrompt = BuildZuccaciyePrompt(urunAdi, marka, kategori, kumas, renkler, "")
            Case "Elektronik"
                basePrompt = BuildElektronikPrompt(urunAdi, marka, kategori, kumas)
            Case "Kozmetik"
                basePrompt = BuildKozmetikPrompt(urunAdi, marka, kategori, kumas)
            Case "Ev Tekstili"
                basePrompt = BuildEvTekstiliPrompt(urunAdi, marka, kategori, kumas, renkler, bedenler)
            Case "Ayakkabı"
                basePrompt = BuildAyakkabiPrompt(urunAdi, marka, kategori, cinsiyet, yasGrubu, kumas, bedenler)
            Case "Aksesuar"
                basePrompt = BuildAksesuarPrompt(urunAdi, marka, kategori, cinsiyet, kumas, renkler)
            Case "Bebek"
                basePrompt = BuildBebekPrompt(urunAdi, marka, kategori, cinsiyet, kumas, bedenler)
            Case "Spor"
                basePrompt = BuildSporPrompt(urunAdi, marka, kategori, cinsiyet, yasGrubu, kumas, bedenler)
            Case "Oyuncak"
                basePrompt = BuildOyuncakPrompt(urunAdi, marka, kategori, yasGrubu)
            Case "Mobilya"
                basePrompt = BuildMobilyaPrompt(urunAdi, marka, kategori, kumas, renkler)
            Case "Çanta"
                basePrompt = BuildCantaPrompt(urunAdi, marka, kategori, cinsiyet, kumas, renkler)
            Case "Saat"
                basePrompt = BuildSaatPrompt(urunAdi, marka, kategori, cinsiyet)
            Case "Takı"
                basePrompt = BuildTakiPrompt(urunAdi, marka, kategori, cinsiyet, kumas)
            Case Else
                ' Giyim ve diğer kategoriler için standart prompt
                basePrompt = BuildGiyimPrompt(urunAdi, marka, kategori, cinsiyet, yasGrubu, kumas, renkler, bedenler, sezon)
        End Select
        
        ' Web bilgisi varsa, prompt'un sonuna ekle (JSON'dan önce)
        If Not String.IsNullOrEmpty(webBilgisi) Then
            ' JSON bloğundan önce web bilgisini ekle
            Dim jsonIndex As Integer = basePrompt.IndexOf("=== JSON FORMATI ===")
            If jsonIndex > 0 Then
                Dim webEkleme As String = $"

===== GERÇEK ÜRÜN BİLGİLERİ (WEB'DEN ALINAN - MUTLAKA KULLAN!) =====
{webBilgisi}

ÖNEMLİ: Yukarıdaki web'den alınan GERÇEK bilgileri kullanarak içerik oluştur!
Bu bilgiler doğru ve günceldir. UYDURMA, bu verileri temel al!

"
                basePrompt = basePrompt.Insert(jsonIndex, webEkleme)
            Else
                ' JSON bloğu bulunamadıysa sonuna ekle
                basePrompt = basePrompt & $"

===== GERÇEK ÜRÜN BİLGİLERİ (WEB'DEN ALINAN) =====
{webBilgisi}

ÖNEMLİ: Bu GERÇEK bilgileri kullan!"
            End If
        End If
        
        Return basePrompt
    End Function
    
    ''' <summary>
    ''' ZÜCCACİYE / MUTFAK ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' ALT-KATEGORİ BAZLI - Ürün tipine göre farklı promptlar
    ''' </summary>
    Private Function BuildZuccaciyePrompt(urunAdi As String, marka As String, kategori As String, 
                                          materyal As String, renkler As String, Optional webBilgisi As String = "") As String
        
        ' === ALT-KATEGORİ TESPİTİ ===
        Dim urun As String = If(urunAdi, "").ToLower()
        Dim altKategori As String = TespitZuccaciyeAltKategori(urun)
        
        Log("INFO", "BuildZuccaciyePrompt", $"Ürün: '{urunAdi}' -> Alt Kategori: '{altKategori}'")
        
        ' Alt kategoriye göre uygun prompt döndür + web bilgisi ekle
        Dim basePrompt As String = ""
        Select Case altKategori
            Case "İçecek"
                basePrompt = BuildIcecekPrompt(urunAdi, marka, materyal)
            Case "Yemek"
                basePrompt = BuildYemekTakimiPrompt(urunAdi, marka, materyal)
            Case "Pişirme"
                basePrompt = BuildPisirmePrompt(urunAdi, marka, materyal)
            Case "Saklama"
                basePrompt = BuildSaklamaPrompt(urunAdi, marka, materyal)
            Case "Servis"
                basePrompt = BuildServisPrompt(urunAdi, marka, materyal)
            Case "EvAleti"
                basePrompt = BuildEvAletiPrompt(urunAdi, marka, materyal)
            Case Else
                basePrompt = BuildGenelZuccaciyePrompt(urunAdi, marka, materyal)
        End Select
        
        ' Web bilgisi varsa ekle
        If Not String.IsNullOrEmpty(webBilgisi) Then
            basePrompt = basePrompt & webBilgisi
        End If
        
        Return basePrompt
    End Function
    
    ''' <summary>
    ''' Züccaciye ürününün alt kategorisini tespit eder
    ''' </summary>
    Private Function TespitZuccaciyeAltKategori(urun As String) As String
        ' === İÇECEK ÜRÜNLERİ (Fincan, Bardak, Kupa, Sürahi vb.) ===
        If urun.Contains("fincan") OrElse urun.Contains("bardak") OrElse urun.Contains("kupa") OrElse _
           urun.Contains("mug") OrElse urun.Contains("çay seti") OrElse urun.Contains("kahve seti") OrElse _
           urun.Contains("sürahi") OrElse urun.Contains("karaf") OrElse urun.Contains("demlik") OrElse _
           urun.Contains("çaydanlık") OrElse urun.Contains("cezve") OrElse urun.Contains("french press") OrElse _
           urun.Contains("espresso") OrElse urun.Contains("latte") OrElse urun.Contains("cappuccino") OrElse _
           urun.Contains("şarap") OrElse urun.Contains("viski") OrElse urun.Contains("kokteyl") OrElse _
           urun.Contains("bira") OrElse urun.Contains("shot") OrElse urun.Contains("kadeh") Then
            Return "İçecek"
        End If
        
        ' === YEMEK TAKIMI (Tabak, Kase, Çorba Kasesi vb.) ===
        If urun.Contains("tabak") OrElse urun.Contains("kase") OrElse urun.Contains("çorba") OrElse _
           urun.Contains("salata") OrElse urun.Contains("pilav") OrElse urun.Contains("makarna") OrElse _
           urun.Contains("komposto") OrElse urun.Contains("tatlı tabağı") OrElse urun.Contains("yemek takımı") OrElse _
           urun.Contains("servis tabağı") OrElse urun.Contains("sosluk") OrElse urun.Contains("kahvaltılık") Then
            Return "Yemek"
        End If
        
        ' === PİŞİRME (Tencere, Tava, Fırın, Düdüklü vb.) ===
        If urun.Contains("tencere") OrElse urun.Contains("tava") OrElse urun.Contains("fırın") OrElse _
           urun.Contains("düdüklü") OrElse urun.Contains("güveç") OrElse urun.Contains("wok") OrElse _
           urun.Contains("sote") OrElse urun.Contains("krep") OrElse urun.Contains("izgara") OrElse _
           urun.Contains("grill") OrElse urun.Contains("döküm") OrElse urun.Contains("emaye") OrElse _
           urun.Contains("teflon") OrElse urun.Contains("granit") OrElse urun.Contains("borcam") Then
            Return "Pişirme"
        End If
        
        ' === SAKLAMA (Kavanoz, Saklama Kabı, Tıpalı vb.) ===
        If urun.Contains("saklama") OrElse urun.Contains("kavanoz") OrElse urun.Contains("tıpa") OrElse _
           urun.Contains("kapak") OrElse urun.Contains("vakum") OrElse urun.Contains("hava almaz") OrElse _
           urun.Contains("kiler") OrElse urun.Contains("baharatlık") OrElse urun.Contains("yağdanlık") OrElse _
           urun.Contains("tuzluk") OrElse urun.Contains("biberlik") OrElse urun.Contains("konteyner") OrElse _
           urun.Contains("kutu") OrElse urun.Contains("hermetic") Then
            Return "Saklama"
        End If
        
        ' === SERVİS (Tepsi, Sunum, Çatal-Bıçak vb.) ===
        If urun.Contains("tepsi") OrElse urun.Contains("sunum") OrElse urun.Contains("çatal") OrElse _
           urun.Contains("bıçak") OrElse urun.Contains("kaşık") OrElse urun.Contains("servis") OrElse _
           urun.Contains("peçetelik") OrElse urun.Contains("ekmeklik") OrElse urun.Contains("kek") OrElse _
           urun.Contains("pasta") OrElse urun.Contains("meyvelik") OrElse urun.Contains("şekerlik") Then
            Return "Servis"
        End If
        
        ' === KÜÇÜK EV ALETLERİ (Mikser, Blender, Mutfak Robotu vb.) ===
        If urun.Contains("mikser") OrElse urun.Contains("mixer") OrElse urun.Contains("miks") OrElse _
           urun.Contains("blender") OrElse urun.Contains("mutfak robotu") OrElse urun.Contains("robot") OrElse _
           urun.Contains("kitchenaid") OrElse urun.Contains("kitchen aid") OrElse _
           urun.Contains("hamur") OrElse urun.Contains("rondo") OrElse urun.Contains("doğrayıcı") OrElse _
           urun.Contains("dilimleyici") OrElse urun.Contains("öğütücü") OrElse _
           urun.Contains("kahve makinesi") OrElse urun.Contains("espresso") OrElse urun.Contains("nespresso") OrElse _
           urun.Contains("tost makinesi") OrElse urun.Contains("ekmek kızartma") OrElse _
           urun.Contains("kettle") OrElse urun.Contains("su ısıtıcı") OrElse _
           urun.Contains("airfryer") OrElse urun.Contains("air fryer") OrElse urun.Contains("fritöz") OrElse _
           urun.Contains("watt") OrElse urun.Contains("lt stand") Then
            Return "EvAleti"
        End If
        
        Return "Genel"
    End Function
    
    ''' <summary>
    ''' İÇECEK ÜRÜNLERİ İÇİN PROMPT (Fincan, Bardak, Kupa vb.)
    ''' </summary>
    Private Function BuildIcecekPrompt(urunAdi As String, marka As String, materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı e-ticaret içerik yazarısın. Trendyol'da 10.000+ satış yapan mağazaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Porselen/Cam/Seramik - ürüne göre belirle]", materyal)}

=== KRİTİK KURAL ===
Bu bir İÇECEK ürünüdür (fincan/bardak/kupa). ""Sağlıklı saklama"" gibi ifadeler ASLA KULLANMA!
İçecek tüketimi, keyif, kahve/çay anı, misafir ağırlama temalı yaz.

=== YASAKLAR (ASLA YAZMA!) ===
&#10060;#10060; ""Sağlıklı saklama"" (Bu bir içecek kabı, saklama kabı DEĞİL!)
&#10060;#10060; ""Gıdalarınız güvende"" (İçecek ürünü için anlamsız)
&#10060;#10060; Cinsiyet, yaş grubu, beden tablosu
&#10060;#10060; Fiyat bilgisi

=== SATIŞ PSİKOLOJİSİ ===
1. KEYİF VURGULA: ""Her yudumda zevk"", ""Kahve molalarınızın yıldızı""
2. DUYGUSAL BAĞ: ""Misafirlerinizi etkileyin"", ""Sofranıza şıklık katın""
3. KALİTE: ""Isı yalıtımlı"", ""Uzun süre sıcak tutar""
4. ESTETİK: ""Şık tasarım"", ""Modern görünüm""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>{marka} {urunAdi} - Keyifli Anların Vazgeçilmezi!</h3>
    
    <p><strong>Her yudum bir ayrıcalık!</strong></p>
    
    <p>[2-3 cümle: İçecek keyfi, misafir ağırlama, sofra şıklığı temalı. 
    Örnek: Sabah kahvenizi bu şık fincanda yudumlayarak güne başlamak, 
    akşam çayınızı misafirlerinizle paylaşırken sofranıza zarafet katmak...</p>
    
    <h4>Neden Bu Ürün?</h4>
    <ul>
      <li><strong>Premium Malzeme:</strong> [Porselen/Cam] ile üstün kalite</li>
      <li><strong>Ergonomik Tasarım:</strong> Rahat kavrama, dengeli ağırlık</li>
      <li><strong>Isı Yalıtımı:</strong> İçeceğiniz uzun süre ideal sıcaklıkta</li>
      <li><strong>Şık Görünüm:</strong> Sofranıza estetik değer katar</li>
      <li><strong>Dayanıklı Yapı:</strong> Günlük kullanıma uygun</li>
    </ul>
    
    <h4>Paket İçeriği</h4>
    <p>[Set içeriğini belirt]</p>
    
    <h4>Güvence</h4>
    <ul>
      <li>%100 Orijinal Ürün</li>
      <li>Hızlı & Güvenli Kargo</li>
      <li>Kolay İade</li>
    </ul>
    
    <p><strong>Kahve ve çay keyfinizi bir üst seviyeye taşıyın!</strong></p>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} - Premium [malzeme] ile üstün kalite. Ergonomik tasarım, şık görünüm. Misafir ağırlamanın vazgeçilmezi. Hızlı kargo, kolay iade."",
  
  ""features"": [
    ""Malzeme: [Porselen/Cam/Seramik]"",
    ""Kapasite: [ml]"",
    ""Boyutlar: [cm]"",
    ""Set İçeriği: [adet]"",
    ""Bulaşık Makinesine Uygun: Evet"",
    ""Mikrodalgaya Uygun: [Evet/Hayır]"",
    ""Menşei: Türkiye"",
    ""Garanti: Üretici garantili""
  ],
  
  ""careInstructions"": ""<div class='care-instructions'>
    <h4>Bakım ve Kullanım</h4>
    <ul>
      <li><strong>İlk Kullanım:</strong> Ilık su ile yıkayın</li>
      <li><strong>Temizlik:</strong> Bulaşık makinesinde yıkayabilirsiniz</li>
      <li><strong>Dikkat:</strong> Ani sıcaklık değişimlerinden kaçının</li>
      <li><strong>Saklama:</strong> Üst üste koyarken dikkatli olun</li>
    </ul>
  </div>"",
  
  ""yikamaTalimati"": ""<ul><li>Bulaşık makinesinde yıkanabilir</li><li>Hafif deterjan kullanın</li><li>Aşındırıcı malzeme kullanmayın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Ani ısı değişimlerinden koruyun</li><li>Düşürmeyin ve çarpmayın</li><li>Yumuşak bezle kurulayın</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Çok sıcak içeceklerde dikkatli olun</li><li>Kırılabilir malzeme</li><li>Çocukların erişemeyeceği yerde saklayın</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Premium Kalite | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} - Premium kalite, şık tasarım. Kahve ve çay keyfinize eşlik eden en iyi tercih. Orijinal ürün, hızlı kargo!"",
  
  ""keywords"": ""{marka}, {urunAdi}, fincan, bardak, kupa, kahve fincanı, çay bardağı, porselen, cam, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' YEMEK TAKIMI ÜRÜNLERİ İÇİN PROMPT (Tabak, Kase vb.)
    ''' </summary>
    Private Function BuildYemekTakimiPrompt(urunAdi As String, marka As String, materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı e-ticaret içerik yazarısın. Trendyol'da 10.000+ satış yapan mağazaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Porselen/Seramik/Cam]", materyal)}

=== KRİTİK KURAL ===
Bu bir YEMEK SERVİSİ ürünüdür (tabak/kase). Sofra sunumu, yemek servisi, estetik sunum temalı yaz.

=== YASAKLAR ===
&#10060;#10060; Cinsiyet, yaş grubu, beden tablosu
&#10060;#10060; Fiyat bilgisi

=== SATIŞ PSİKOLOJİSİ ===
1. SUNUMVurgula: ""Yemekleriniz sanat eserine dönüşsün""
2. SOFRA ESTETİĞİ: ""Misafirlerinizi etkileyin""
3. PRATİKLİK: ""Günlük kullanıma dayanıklı""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>{marka} {urunAdi} - Sofranızın Yıldızı!</h3>
    
    <p><strong>Her öğün bir şölen!</strong></p>
    
    <p>[2-3 cümle: Yemek sunumu, sofra estetiği, misafir ağırlama temalı]</p>
    
    <h4>Neden Bu Ürün?</h4>
    <ul>
      <li><strong>Premium Malzeme:</strong> [Porselen/Seramik] ile üstün kalite</li>
      <li><strong>Estetik Tasarım:</strong> Yemeklerinizin sunumunu zenginleştirir</li>
      <li><strong>Pratik Boyut:</strong> Her porsiyon için ideal</li>
      <li><strong>Dayanıklı:</strong> Günlük kullanıma uygun</li>
    </ul>
    
    <h4>Paket İçeriği</h4>
    <p>[Set içeriği]</p>
    
    <h4>Güvence</h4>
    <ul>
      <li>%100 Orijinal Ürün</li>
      <li>Hızlı Kargo</li>
      <li>Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} - Premium [malzeme], estetik tasarım. Sofranıza şıklık katın. Hızlı kargo."",
  
  ""features"": [
    ""Malzeme: [Porselen/Seramik/Cam]"",
    ""Boyutlar: [cm]"",
    ""Set İçeriği: [adet]"",
    ""Bulaşık Makinesine Uygun: Evet"",
    ""Mikrodalgaya Uygun: [Evet/Hayır]"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>Bakım</h4><ul><li>Bulaşık makinesinde yıkanabilir</li><li>Ani ısı değişimlerinden kaçının</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Bulaşık makinesinde yıkanabilir</li><li>Hafif deterjan önerilir</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Ani ısı değişimlerinden koruyun</li><li>Çizilmeye karşı dikkatli olun</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Kırılabilir malzeme</li><li>Dikkatli taşıyın</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Şık Tasarım | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} - Sofranıza şıklık katan tasarım. Premium kalite, hızlı kargo!"",
  
  ""keywords"": ""{marka}, {urunAdi}, tabak, kase, yemek takımı, sofra, porselen, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' PİŞİRME ÜRÜNLERİ İÇİN PROMPT (Tencere, Tava vb.)
    ''' </summary>
    Private Function BuildPisirmePrompt(urunAdi As String, marka As String, materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı e-ticaret içerik yazarısın.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Paslanmaz Çelik/Döküm/Granit/Emaye]", materyal)}

=== KRİTİK KURAL ===
Bu bir PİŞİRME ürünüdür. Yemek yapma kolaylığı, pişirme performansı, sağlıklı pişirme temalı yaz.

=== YASAKLAR ===
&#10060;#10060; Cinsiyet, yaş grubu, beden tablosu
&#10060;#10060; Fiyat bilgisi

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>{marka} {urunAdi} - Profesyonel Mutfağın Sırrı!</h3>
    
    <p><strong>Mutfakta şef gibi hissedin!</strong></p>
    
    <p>[2-3 cümle: Pişirme kolaylığı, lezzet, sağlıklı yemek temalı]</p>
    
    <h4>Neden Bu Ürün?</h4>
    <ul>
      <li><strong>Üstün Isı Dağılımı:</strong> Homojen pişirme</li>
      <li><strong>Yapışmaz Yüzey:</strong> Az yağla sağlıklı pişirme</li>
      <li><strong>Ergonomik Sap:</strong> Güvenli kavrama</li>
      <li><strong>Dayanıklı:</strong> Uzun ömürlü kullanım</li>
    </ul>
    
    <h4>Teknik Özellikler</h4>
    <ul>
      <li>Çap: [cm]</li>
      <li>Malzeme: [Paslanmaz Çelik/Döküm/Granit]</li>
      <li>Kapak: [Cam/Metal]</li>
      <li>Tüm ocaklara uygun</li>
    </ul>
    
    <h4>Güvence</h4>
    <ul>
      <li>%100 Orijinal Ürün</li>
      <li>Hızlı Kargo</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} - Profesyonel pişirme performansı. [Malzeme], ergonomik tasarım. Hızlı kargo."",
  
  ""features"": [
    ""Malzeme: [Paslanmaz Çelik/Döküm/Granit/Emaye]"",
    ""Çap: [cm]"",
    ""Kapasite: [lt]"",
    ""Tüm Ocaklara Uygun: Evet"",
    ""İndüksiyon Uyumu: [Evet/Hayır]"",
    ""Fırın Uyumu: [Evet/Hayır]"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>Bakım</h4><ul><li>İlk kullanımdan önce yağlayın</li><li>Orta ateşte kullanın</li><li>Ahşap veya silikon spatula kullanın</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Ilık su ve yumuşak süngerle yıkayın</li><li>Aşındırıcı malzeme kullanmayın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Metal spatula kullanmayın</li><li>Aşırı ısıdan kaçının</li><li>Boş yakamayın</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Sap sıcak olabilir, tutacak kullanın</li><li>Çocuklardan uzak tutun</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Profesyonel Kalite | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} - Profesyonel pişirme performansı. Üstün ısı dağılımı, dayanıklı yapı. Hızlı kargo!"",
  
  ""keywords"": ""{marka}, {urunAdi}, tencere, tava, pişirme, mutfak, granit, döküm, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' SAKLAMA ÜRÜNLERİ İÇİN PROMPT (Kavanoz, Saklama Kabı vb.)
    ''' </summary>
    Private Function BuildSaklamaPrompt(urunAdi As String, marka As String, materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı e-ticaret içerik yazarısın.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Cam/Plastik/Paslanmaz Çelik]", materyal)}

=== KRİTİK KURAL ===
Bu bir SAKLAMA ürünüdür. BURADA ""sağlıklı saklama"" kullanabilirsin! Gıda koruma, düzen, tazelik temalı yaz.

=== YASAKLAR ===
&#10060;#10060; Cinsiyet, yaş grubu, beden tablosu
&#10060;#10060; Fiyat bilgisi

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>{marka} {urunAdi} - Gıdalarınız Güvende!</h3>
    
    <p><strong>Tazelik şimdi daha uzun sürsün!</strong></p>
    
    <p>[2-3 cümle: Gıda saklama, tazelik, düzen temalı. 
    Örnek: Mutfağınızda düzen mi istiyorsunuz? Gıdalarınızın tazeliğini korumak mı? 
    Bu saklama kabı ile hem düzen hem sağlık bir arada!]</p>
    
    <h4>Neden Bu Ürün?</h4>
    <ul>
      <li><strong>Sağlıklı Saklama:</strong> [Cam/BPA-free] malzeme ile gıdalarınız güvende</li>
      <li><strong>Hava Geçirmez:</strong> Tazeliği uzun süre korur</li>
      <li><strong>Pratik Kullanım:</strong> Kolay açılır-kapanır kapak</li>
      <li><strong>Görünür İçerik:</strong> İçindekileri kolayca görün</li>
      <li><strong>İstiflenebilir:</strong> Yerden tasarruf edin</li>
    </ul>
    
    <h4>Paket İçeriği</h4>
    <p>[Set içeriği ve kapasiteler]</p>
    
    <h4>Güvence</h4>
    <ul>
      <li>%100 Orijinal Ürün</li>
      <li>Hızlı Kargo</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} - Sağlıklı saklama, hava geçirmez kapak. [Malzeme] yapı. Gıdalarınız güvende. Hızlı kargo."",
  
  ""features"": [
    ""Malzeme: [Cam/Plastik/Paslanmaz Çelik]"",
    ""Kapasite: [ml/lt]"",
    ""Hava Geçirmez: Evet"",
    ""Bulaşık Makinesine Uygun: [Evet/Hayır]"",
    ""Mikrodalgaya Uygun: [Evet/Hayır]"",
    ""Derin Dondurucu Uyumu: [Evet/Hayır]"",
    ""Set İçeriği: [adet]"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>Bakım</h4><ul><li>Bulaşık makinesinde yıkanabilir</li><li>Kapağı ayrı yıkayın</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Bulaşık makinesinde yıkanabilir</li><li>Kapak ve gövdeyi ayrı yıkayın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Kapak contasını kontrol edin</li><li>Kuru saklayın</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Kapağı açık mikrodalgaya koymayın</li><li>Sıcak yiyecek koymadan önce soğutun</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Sağlıklı Saklama | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} - Sağlıklı saklama, hava geçirmez kapak. Gıdalarınızın tazeliğini koruyun. Hızlı kargo!"",
  
  ""keywords"": ""{marka}, {urunAdi}, saklama kabı, kavanoz, gıda saklama, hava geçirmez, cam, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' SERVİS ÜRÜNLERİ İÇİN PROMPT (Tepsi, Çatal-Bıçak vb.)
    ''' </summary>
    Private Function BuildServisPrompt(urunAdi As String, marka As String, materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı e-ticaret içerik yazarısın.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Paslanmaz Çelik/Bambu/Cam]", materyal)}

=== KRİTİK KURAL ===
Bu bir SERVİS ürünüdür. Sunum, misafir ağırlama, sofra düzeni temalı yaz.

=== YASAKLAR ===
&#10060;#10060; Cinsiyet, yaş grubu, beden tablosu
&#10060;#10060; Fiyat bilgisi

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>{marka} {urunAdi} - Sofranızı Taçlandırın!</h3>
    
    <p><strong>Servisin sanatını keşfedin!</strong></p>
    
    <p>[2-3 cümle: Sunum, misafir ağırlama, sofra estetiği temalı]</p>
    
    <h4>Neden Bu Ürün?</h4>
    <ul>
      <li><strong>Şık Tasarım:</strong> Her sofrada göz alıcı</li>
      <li><strong>Kaliteli Malzeme:</strong> Uzun ömürlü kullanım</li>
      <li><strong>Pratik:</strong> Kolay temizlik</li>
    </ul>
    
    <h4>Güvence</h4>
    <ul>
      <li>%100 Orijinal Ürün</li>
      <li>Hızlı Kargo</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} - Şık tasarım, kaliteli malzeme. Sofranıza zarafet katın. Hızlı kargo."",
  
  ""features"": [
    ""Malzeme: [Paslanmaz Çelik/Bambu/Cam]"",
    ""Boyutlar: [cm]"",
    ""Set İçeriği: [adet]"",
    ""Bulaşık Makinesine Uygun: [Evet/Hayır]"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>Bakım</h4><ul><li>Yumuşak bezle silin</li><li>Aşındırıcı kullanmayın</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Bulaşık makinesinde yıkanabilir</li><li>Hafif deterjan kullanın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Kuru saklayın</li><li>Çizilmeye dikkat edin</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Keskin kenarlara dikkat</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Şık Servis | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} - Sofranıza zarafet katan servis ürünü. Şık tasarım, hızlı kargo!"",
  
  ""keywords"": ""{marka}, {urunAdi}, servis, tepsi, sofra, paslanmaz çelik, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' GENEL ZÜCCACİYE PROMPT (Alt kategori tespit edilemezse)
    ''' </summary>
    Private Function BuildGenelZuccaciyePrompt(urunAdi As String, marka As String, materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı e-ticaret içerik yazarısın.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Ürüne göre belirle]", materyal)}

=== KRİTİK KURAL ===
Ürün tipini doğru tespit et ve ona uygun içerik yaz:
- Fincan/Bardak/Kupa ise: İçecek keyfi temalı yaz, ""sağlıklı saklama"" KULLANMA!
- Tabak/Kase ise: Yemek sunumu temalı yaz
- Tencere/Tava ise: Pişirme performansı temalı yaz
- Saklama Kabı ise: Gıda koruma temalı yaz

=== YASAKLAR ===
&#10060;#10060; Cinsiyet, yaş grubu, beden tablosu
&#10060;#10060; Fiyat bilgisi
&#10060;#10060; Ürün tipine uygun olmayan ifadeler

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>{marka} {urunAdi} - Mutfağınızın Yıldızı!</h3>
    
    <p><strong>[Ürün tipine uygun açılış cümlesi]</strong></p>
    
    <p>[2-3 cümle: Ürün tipine uygun tema ile yaz]</p>
    
    <h4>Neden Bu Ürün?</h4>
    <ul>
      <li><strong>Kaliteli Malzeme:</strong> [Ürüne uygun malzeme vurgusu]</li>
      <li><strong>Şık Tasarım:</strong> [Estetik vurgusu]</li>
      <li><strong>Pratik Kullanım:</strong> [Fonksiyon vurgusu]</li>
      <li><strong>Dayanıklı:</strong> Uzun ömürlü</li>
    </ul>
    
    <h4>Güvence</h4>
    <ul>
      <li>%100 Orijinal Ürün</li>
      <li>Hızlı Kargo</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} - Kaliteli malzeme, şık tasarım. Hızlı kargo, kolay iade."",
  
  ""features"": [
    ""Malzeme: [Ürüne uygun]"",
    ""Boyutlar: [cm/ml/lt]"",
    ""Bulaşık Makinesine Uygun: [Evet/Hayır]"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>Bakım</h4><ul><li>Ürün tipine uygun bakım talimatları</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Ürüne uygun yıkama talimatı</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Ürüne uygun bakım talimatı</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Ürüne uygun güvenlik uyarısı</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Orijinal | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} - Kaliteli malzeme, şık tasarım. Orijinal ürün, hızlı kargo!"",
  
  ""keywords"": ""{marka}, {urunAdi}, züccaciye, mutfak, orijinal, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' KÜÇÜK EV ALETLERİ İÇİN PROMPT (Mikser, Blender, Mutfak Robotu vb.)
    ''' </summary>
    Private Function BuildEvAletiPrompt(urunAdi As String, marka As String, materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı e-ticaret içerik yazarısın.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}

=== KRİTİK KURAL ===
Bu bir KÜÇÜK EV ALETİ / MUTFAK MAKİNESİDİR (mikser/blender/mutfak robotu).
ASLA ""Unisex"", ""%100 Pamuk"", ""Beden"" gibi GİYİM TERİMLERİ KULLANMA!
Performans, güç, kapasite, kullanım kolaylığı temalı yaz.

=== YASAKLAR (ASLA YAZMA!) ===
&#10060;#10060; ""Unisex"" (Bu bir elektrikli alet!)
&#10060;#10060; ""%100 Pamuk"" (Bu kumaş değil, makine!)
&#10060;#10060; Beden, cinsiyet, yaş grubu
&#10060;#10060; Kumaş türleri (pamuk, polyester vb.)
&#10060;#10060; Fiyat bilgisi

=== SATIŞ PSİKOLOJİSİ ===
1. PERFORMANS: ""Güçlü motor"", ""Profesyonel sonuçlar""
2. PRATİKLİK: ""Zamandan tasarruf"", ""Kolay kullanım""
3. DAYANIKLILIK: ""Uzun ömürlü"", ""Kaliteli malzeme""
4. TEKNOLOJİ: ""Yenilikçi tasarım"", ""Akıllı fonksiyonlar""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>{marka} {urunAdi} - Mutfağınızın Güçlü Yardımcısı!</h3>
    
    <p><strong>Profesyonel sonuçlar artık evinizde!</strong></p>
    
    <p>[2-3 cümle: Performans, güç, kullanım kolaylığı temalı. 
    Örnek: Güçlü motoru ve dayanıklı yapısıyla mutfakta her işi kolaylaştırır. 
    Profesyonel şefler gibi sonuçlar elde etmeniz artık çok kolay!</p>
    
    <h4>Neden Bu Ürün?</h4>
    <ul>
      <li><strong>Güçlü Motor:</strong> [Watt] güç ile zorlu işleri kolayca halleder</li>
      <li><strong>Geniş Kapasite:</strong> [Lt] hazne ile büyük porsiyonlar hazırlayın</li>
      <li><strong>Dayanıklı Yapı:</strong> Kaliteli malzemeler ile uzun ömürlü kullanım</li>
      <li><strong>Kolay Temizlik:</strong> Çıkarılabilir parçalar bulaşık makinesinde yıkanabilir</li>
      <li><strong>Çok Fonksiyonlu:</strong> Karıştırma, çırpma, yoğurma bir arada</li>
    </ul>
    
    <h4>Teknik Özellikler</h4>
    <ul>
      <li>Güç: [Watt]</li>
      <li>Kapasite: [Lt]</li>
      <li>Hız Ayarı: [adet] farklı hız</li>
      <li>Aksesuarlar: [liste]</li>
    </ul>
    
    <h4>Güvence</h4>
    <ul>
      <li>%100 Orijinal Ürün</li>
      <li>Üretici Garantili</li>
      <li>Hızlı Kargo</li>
      <li>Kolay İade</li>
    </ul>
    
    <p><strong>Mutfağınızı profesyonel bir şefin mutfağına dönüştürün!</strong></p>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} - Güçlü motor, geniş kapasite. Profesyonel sonuçlar evinizde. Orijinal ürün, üretici garantili. Hızlı kargo."",
  
  ""features"": [
    ""Marka: {marka}"",
    ""Güç: [Watt]"",
    ""Kapasite: [Lt]"",
    ""Hız Ayarı: [adet]"",
    ""Voltaj: 220V"",
    ""Garanti: 2 Yıl"",
    ""Menşei: [Ülke]"",
    ""Aksesuarlar: [liste]""
  ],
  
  ""careInstructions"": ""<div><h4>Bakım ve Kullanım</h4><ul><li>Kullanım kılavuzunu okuyun</li><li>Temizlemeden önce fişi çekin</li><li>Nemli bezle silin</li><li>Çıkarılabilir parçaları bulaşık makinesinde yıkayabilirsiniz</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Fişi çıkardıktan sonra temizleyin</li><li>Ana gövdeyi suya sokmayın</li><li>Çıkarılabilir parçalar bulaşık makinesinde yıkanabilir</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Düzenli olarak temizleyin</li><li>Serin ve kuru yerde saklayın</li><li>Kabloyu zorlamayın</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Islak elle kullanmayın</li><li>Çocuklardan uzak tutun</li><li>Çalışırken gözlem altında tutun</li><li>Aşırı yüklemeyin</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Orijinal | Garantili | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} - Güçlü performans, profesyonel sonuçlar. Orijinal ürün, üretici garantili. Hızlı kargo, kolay iade!"",
  
  ""keywords"": ""{marka}, {urunAdi}, mikser, blender, mutfak robotu, mutfak makinesi, orijinal, garantili, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' ELEKTRONİK ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildElektronikPrompt(urunAdi As String, marka As String, kategori As String, 
                                           materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı teknoloji e-ticaret içerik yazarısın. Trendyol ve Hepsiburada'da en çok satan elektronik ürünlerin içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}

=== YASAKLAR ===
&#10060;#10060; Cinsiyet (elektronik üründe cinsiyet olmaz!)
&#10060;#10060; Yaş grubu
&#10060;#10060; Beden tablosu
&#10060;#10060; Abartılı teknik vaatler

=== SATIŞ PSİKOLOJİSİ ===
1. TEKNİK DETAY + FAYDA: ""3000mAh batarya"" değil ""3000mAh batarya ile gün boyu kesintisiz kullanım""
2. UYUMLULUK VURGULA: ""Tüm cihazlarla uyumlu""
3. GARANTİ GÜVENCESİ: ""2 yıl üretici garantisi""
4. HIZLI TESLİMAT: ""Aynı gün kargo""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>🔌 {marka} {urunAdi} - Teknolojinin Gücü Elinizde!</h3>
    
    <p><strong>Hayatınızı kolaylaştıran teknoloji!</strong></p>
    
    <p>[3-4 cümle: Ürünün günlük hayatta nasıl fayda sağlayacağını anlat]</p>
    
    <h4>⚡ Teknik Özellikler</h4>
    <ul>
      <li><strong>Güç:</strong> [Watt/Volt/mAh bilgisi]</li>
      <li><strong>Bağlantı:</strong> [USB/Bluetooth/WiFi vb.]</li>
      <li><strong>Uyumluluk:</strong> [Hangi cihazlarla uyumlu]</li>
      <li><strong>Boyut:</strong> [cm x cm x cm]</li>
      <li><strong>Ağırlık:</strong> [gram]</li>
    </ul>
    
    <h4>&#128230;#128230; Paket İçeriği</h4>
    <p>[Kutuda neler var listele]</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; [X] Yıl Garanti</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | [Ana teknik özellik] | Orijinal ürün | [X] Yıl garanti | Hızlı kargo"",
  
  ""features"": [
    ""Marka: {marka}"",
    ""Güç: [Watt/Volt/mAh]"",
    ""Bağlantı: [USB/Bluetooth/WiFi]"",
    ""Uyumluluk: [Cihaz listesi]"",
    ""Garanti: [X] Yıl"",
    ""Menşei: [Türkiye/İthal]""
  ],
  
  ""careInstructions"": ""<div><h4>&#128295;#128295; Kullanım ve Bakım</h4><ul><li>Kuru bez ile temizleyin</li><li>Su ve nemden uzak tutun</li><li>Aşırı sıcaktan koruyun</li><li>Orijinal şarj aleti kullanın</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Kuru bez ile silin</li><li>Suya temas ettirmeyin</li><li>Hafif nemli bez kullanabilirsiniz</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Orijinal şarj aleti kullanın</li><li>Aşırı sıcaktan koruyun</li><li>Toz birikmesini önleyin</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Voltaj değerlerine dikkat edin</li><li>Çocuklardan uzak tutun</li><li>Yanıcı maddelerden uzakta kullanın</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | [Ana özellik] | Garantili | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓Orijinal ✓Garantili ✓Hızlı Kargo. [Ana teknik özellik]. En uygun fiyat!"",
  
  ""keywords"": ""{marka}, {urunAdi}, elektronik, teknoloji, orijinal, garantili, hızlı kargo, en ucuz""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' KOZMETİK ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildKozmetikPrompt(urunAdi As String, marka As String, kategori As String, 
                                         materyal As String) As String
        Return $"Sen Türkiye'nin en başarılı kozmetik e-ticaret içerik yazarısın. Büyük kozmetik markalarının Trendyol içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}

=== YASAKLAR ===
&#10060;#10060; Tıbbi iddialar (""cilt hastalığı tedavi eder"" gibi)
&#10060;#10060; Abartılı vaatler (""mucize"", ""anında gençleşme"")
&#10060;#10060; Cinsiyet/Yaş grubu (kozmetikte bu alanlar yok)

=== SATIŞ PSİKOLOJİSİ ===
1. SONUÇ ODAKLI: ""Nemlendirici"" değil ""Pürüzsüz ve ışıltılı cilt için nemlendirici""
2. DUYGUSAL BAĞ: ""Kendinize değer verin"", ""Güzelliğinizi keşfedin""
3. İÇERİK VURGULA: ""Doğal içerikler"", ""Dermatolojik test""
4. GÜVEN: ""Orijinal ürün"", ""Sağlık Bakanlığı onaylı""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>&#9830;#9830; {marka} {urunAdi} - Güzelliğinize Değer Katın!</h3>
    
    <p><strong>Cildiniz en iyisini hak ediyor!</strong></p>
    
    <p>[3-4 cümle: Ürünün cilde/saça nasıl fayda sağlayacağını anlat. Duygusal bağ kur.]</p>
    
    <h4>&#10022;#10022; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Hacim:</strong> [ml]</li>
      <li><strong>Cilt Tipi:</strong> [Tüm cilt tipleri / Kuru / Yağlı / Karma]</li>
      <li><strong>Etki:</strong> [Nemlendirme / Besleyici / Anti-aging vb.]</li>
      <li><strong>İçerik:</strong> [Ana aktif maddeler]</li>
      <li><strong>Koku:</strong> [Parfümsüz / Hafif çiçeksi vb.]</li>
    </ul>
    
    <h4>💆 Kullanım Şekli</h4>
    <p>[Nasıl uygulanacağını anlat]</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; Dermatolojik Test Edilmiş</li>
      <li>&#10003;#10003; Hızlı & Güvenli Kargo</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} [ml] | [Cilt tipi] için | [Ana etki] | Orijinal ürün | Hızlı kargo"",
  
  ""features"": [
    ""Hacim: [ml]"",
    ""Cilt Tipi: [Uygun cilt tipleri]"",
    ""Etki: [Ana etki]"",
    ""İçerik: [Ana maddeler]"",
    ""Uygulama: [Yüz/Vücut/Saç]"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>📋 Kullanım ve Saklama</h4><ul><li>Temiz cilde uygulayın</li><li>Göz çevresinden kaçının</li><li>Serin ve kuru yerde saklayın</li><li>Güneş ışığından koruyun</li><li>Son kullanma tarihine dikkat edin</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Ürünü suyla uygulayabilirsiniz</li><li>Kullanım sonrası ürün kapağını kapatın</li><li>Temiz ciltte kullanın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Serin ve kuru yerde saklayın</li><li>Direkt güneş ışığından koruyun</li><li>Kapağı sıkıca kapatın</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Göz temasından kaçının</li><li>Alerjik reaksiyon durumunda kullanımı durdurun</li><li>Çocukların erişemeyeceği yerde saklayın</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} [ml] | [Ana etki] | Orijinal | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓Orijinal ✓Dermatolojik Test ✓Hızlı Kargo. [Ana etki]. En uygun fiyat!"",
  
  ""keywords"": ""{marka}, {urunAdi}, kozmetik, cilt bakım, orijinal, dermatolojik, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' EV TEKSTİLİ ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildEvTekstiliPrompt(urunAdi As String, marka As String, kategori As String, 
                                           kumas As String, renkler As String, boyut As String) As String
        Return $"Sen Türkiye'nin en başarılı ev tekstili e-ticaret içerik yazarısın. Madame Coco, English Home gibi markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Kumaş: {If(String.IsNullOrEmpty(kumas), "[Pamuk/Saten/Ranforce vb.]", kumas)}
Boyut: {If(String.IsNullOrEmpty(boyut), "[Tek kişilik/Çift kişilik]", boyut)}

=== YASAKLAR ===
&#10060;#10060; Cinsiyet (ev tekstilinde cinsiyet olmaz!)
&#10060;#10060; Yaş grubu
&#10060;#10060; XS/S/M/L beden (ev tekstilinde tek/çift kişilik var!)

=== SATIŞ PSİKOLOJİSİ ===
1. KONFOR VURGULA: ""Pamuklu nevresim"" değil ""Bulut gibi yumuşak pamuklu nevresim""
2. ESTETİK BAĞ: ""Yatak odanızı butik otele çevirin""
3. KALİTE GÜVENCESİ: ""Yıkamada renk atmaz"", ""Çekmez""
4. SET AVANTAJI: ""Komple takım"", ""Uyumlu parçalar""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>&#127968;#127968; {marka} {urunAdi} - Evinize Lüks Dokunuş!</h3>
    
    <p><strong>Hayalinizdeki yatak odası artık gerçek!</strong></p>
    
    <p>[3-4 cümle: Ürünün eve nasıl şıklık katacağını, konforu nasıl artıracağını anlat. 
    Örnek: Her sabah 5 yıldızlı otel konforunda uyanmak ister misiniz? Bu şık nevresim takımı 
    ile yatak odanız bir butik otele dönüşecek. Yumuşacık pamuklu kumaşı cildinizi okşarken, 
    zarif deseni evinize sofistike bir hava katacak.]</p>
    
    <h4>&#10022;#10022; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Kumaş:</strong> [%100 Pamuk / Saten / Ranforce / Percale]</li>
      <li><strong>İplik Sıklığı:</strong> [57 tel / 80 tel / 120 tel]</li>
      <li><strong>Boyut:</strong> [Tek kişilik / Çift kişilik / King size]</li>
      <li><strong>Renk:</strong> [Renk bilgisi]</li>
      <li><strong>Desen:</strong> [Düz / Desenli / Jakarlı]</li>
    </ul>
    
    <h4>&#128230;#128230; Set İçeriği</h4>
    <ul>
      <li>[Parça 1]: [Boyut cm x cm]</li>
      <li>[Parça 2]: [Boyut cm x cm]</li>
      <li>[Parça 3]: [Boyut cm x cm]</li>
    </ul>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; Renk Atmaz (Reaktif Boya)</li>
      <li>&#10003;#10003; Çekmez</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | [Kumaş] | [Boyut] | [Parça sayısı] parça set | Renk atmaz, çekmez | Hızlı kargo"",
  
  ""features"": [
    ""Kumaş: [Pamuk/Saten/Ranforce]"",
    ""Kumaş Oranı: [%100 Pamuk vb.]"",
    ""Boyut: [Tek kişilik/Çift kişilik]"",
    ""Set İçeriği: [X] Parça"",
    ""İplik Sıklığı: [X] Tel"",
    ""Renk: [Renk]"",
    ""Desen: [Düz/Desenli]"",
    ""Özellik: Renk atmaz, çekmez"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>🧺 Yıkama ve Bakım</h4><ul><li><strong>İlk Yıkama:</strong> Ayrı yıkayın (hafif renk akması olabilir)</li><li><strong>Sıcaklık:</strong> 40°C'de yıkayın</li><li><strong>Kurutma:</strong> Düşük ısıda kurutun veya asarak kurutun</li><li><strong>Ütüleme:</strong> Orta ısıda, nemli iken ütüleyin</li><li><strong>Ağartıcı:</strong> Kullanmayın</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>40°C'de yıkayın</li><li>İlk yıkamada ayrı yıkayın</li><li>Hassas programda yıkayın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Asarak kurutun</li><li>Orta ısıda ütüleyin</li><li>Kuru temizleme önerilmez</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Ağartıcı kullanmayın</li><li>Çamaşır suyu kullanmayın</li><li>Etiketteki talimatlara uyun</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | [Kumaş] | [Boyut] | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓[Kumaş] ✓[Boyut] ✓Renk Atmaz ✓Hızlı Kargo. [Set parça sayısı] parça komple set!"",
  
  ""keywords"": ""{marka}, {urunAdi}, ev tekstili, nevresim, yatak örtüsü, pamuklu, saten, hızlı kargo, set""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' GİYİM ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' E-ticarette satışı garantileyen içerik!
    ''' </summary>
    Private Function BuildGiyimPrompt(urunAdi As String, marka As String, kategori As String, 
                                       cinsiyet As String, yasGrubu As String, kumas As String,
                                       renkler As String, bedenler As String, sezon As String) As String
        
        ' ===== CİNSİYET BİLGİSİNİ ÜRÜN ADINDAN TESPİT ET =====
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        
        ' ===== YAŞ GRUBU TESPİT =====
        Dim gercekYasGrubu As String = TespitYasGrubu(urunAdi, yasGrubu, kategori)
        
        Return $"Sen Türkiye'nin en başarılı moda e-ticaret içerik yazarısın. Trendyol'da milyonlarca satış yapan markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}
Yaş Grubu: {gercekYasGrubu}
Kumaş: {If(String.IsNullOrEmpty(kumas), "[Ürüne uygun kumaş tahmin et: Pamuk, Polyester, Viskon vb.]", kumas)}
Bedenler: {If(String.IsNullOrEmpty(bedenler), "S, M, L, XL, XXL", bedenler)}
Sezon: {If(String.IsNullOrEmpty(sezon), "4 Mevsim", sezon)}

=== YASAKLAR ===
&#10060;#10060; Emoji (HTML etiketleri kullan)
&#10060;#10060; Fiyat bilgisi
&#10060;#10060; Abartılı vaatler

=== SATIŞ PSİKOLOJİSİ KURALLARI ===
1. FAYDA ODAKLI: ""Pamuklu kumaş"" değil ""Cildinizi okşayan yumuşacık pamuk""
2. DUYGUSAL BAĞ: ""Kendinizi özel hissedin"", ""Tüm bakışları üzerinize çekin""
3. PROBLEM-ÇÖZÜM: ""Ne giysem derdine son!"", ""Her kombinle uyumlu""
4. SOSYAL KANIT: ""Bu sezonun en trend parçası"", ""En çok satan""
5. ACİLİYET: ""Sınırlı stok"", ""Tükenmeden alın""
6. GÜVEN: ""Orijinal ürün"", ""Hızlı kargo"", ""Ücretsiz iade""
7. VİZYON OLUŞTUR: Müşterinin ürünü giydiğini hayal etmesini sağla

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>&#10022;#10022; {marka} {urunAdi} - Tarzınızı Yansıtın!</h3>
    
    <p><strong>Gardırobunuzun vazgeçilmezi olmaya hazır!</strong></p>
    
    <p>[3-4 cümle: Ürünü giyince nasıl hissedeceklerini anlat. Hayal kurduğun bir sahne oluştur.
    Örnek: İster ofiste şık bir toplantıda, ister hafta sonu arkadaşlarınızla buluşmada... 
    Bu şık tasarım her ortamda fark yaratmanızı sağlayacak. Yumuşacık kumaşı ile gün boyu 
    konfor, modern kesimi ile kusursuz bir görünüm.]</p>
    
    <h4>&#9830;#9830; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Kumaş:</strong> [%100 Pamuk / Pamuk-Polyester karışım] - Cildinize dost, nefes alan yapı</li>
      <li><strong>Kalıp:</strong> [Regular Fit / Slim Fit / Oversize] - Vücut tipinize uygun kesim</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
      <li><strong>Yaş Grubu:</strong> {gercekYasGrubu}</li>
      <li><strong>Sezon:</strong> {sezon} kullanıma uygun</li>
      <li><strong>Yaka:</strong> [Yaka tipi]</li>
      <li><strong>Kol:</strong> [Kol tipi]</li>
      <li><strong>Desen:</strong> [Düz / Baskılı / Çizgili]</li>
    </ul>
    
    <h4>&#128087;#128087; Kombin Önerileri</h4>
    <p>[2-3 cümle ile nasıl kombinlenebileceğini anlat]</p>
    
    <h4>&#128207;#128207; Beden Bilgisi</h4>
    <p>Model bilgileri: [Boy/Kilo/Giydiği beden örneği]. Normal kalıp, beden tavsiyesi: Her zamanki bedeninizi alabilirsiniz.</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal {marka} Ürünü</li>
      <li>&#10003;#10003; Hızlı & Güvenli Kargo</li>
      <li>&#10003;#10003; Ücretsiz İade (15 gün)</li>
      <li>&#10003;#10003; Kapıda Ödeme İmkanı</li>
    </ul>
    
    <p><strong>&#128722;#128722; Gardırobunuzun yeni favorisini kaçırmayın - Hemen sepete ekleyin!</strong></p>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Kumaş] | [Kalıp] | {gercekYasGrubu} | Orijinal ürün, hızlı kargo, ücretsiz iade."",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Yaş Grubu: {gercekYasGrubu}"",
    ""Kumaş: [Pamuk / Polyester / Viskon / Karışım]"",
    ""Kumaş Oranı: [%100 Pamuk veya %65 Pamuk %35 Polyester vb.]"",
    ""Kalıp: [Regular Fit / Slim Fit / Oversize]"",
    ""Yaka Tipi: [Bisiklet / V Yaka / Polo vb.]"",
    ""Kol Tipi: [Uzun Kol / Kısa Kol / Kolsuz]"",
    ""Desen: [Düz / Baskılı / Çizgili / Kareli]"",
    ""Sezon: {sezon}"",
    ""Menşei: Türkiye"",
    ""Yıkama: 30°C'de makine yıkama""
  ],
  
  ""careInstructions"": ""<div class='care-instructions'>
    <h4>&#128084;#128084; Bakım Talimatları</h4>
    <ul>
      <li><strong>Yıkama:</strong> 30°C'de hassas programda yıkayın</li>
      <li><strong>Kurutma:</strong> Düz zeminüstünde, direkt güneş ışığından uzakta kurutun</li>
      <li><strong>Ütüleme:</strong> Orta ısıda, tersten ütüleyin</li>
      <li><strong>Dikkat:</strong> Beyaz ürünlerle birlikte yıkamayın</li>
      <li><strong>Saklama:</strong> Askıda muhafaza edin, katlamayın</li>
    </ul>
    <p><em>İpucu: İlk yıkamada hafif renk akması olabilir, ayrı yıkayın.</em></p>
  </div>"",
  
  ""yikamaTalimati"": ""<ul><li>30°C'de hassas programda yıkayın</li><li>İlk yıkamada ayrı yıkayın</li><li>Tersten yıkayın</li><li>Beyaz ürünlerle yıkamayın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Düz zeminde kurutun</li><li>Orta ısıda tersten ütüleyin</li><li>Askıda muhafaza edin</li><li>Direkt güneş ışığından koruyun</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Ağartıcı kullanmayın</li><li>Kuru temizleme önerilmez</li><li>Etiket talimatlarına uyun</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | {gercekCinsiyet} [Kumaş] | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓{gercekCinsiyet} ✓{gercekYasGrubu} ✓[Kumaş] ✓Orijinal ✓Hızlı Kargo ✓Ücretsiz İade. En uygun fiyat!"",
  
  ""keywords"": ""{marka}, {urunAdi}, {gercekCinsiyet}, {gercekYasGrubu}, [kumaş], [ürün tipi], online alışveriş, orijinal, kampanya, indirim, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' Ürün adından yaş grubu bilgisini tespit eder
    ''' </summary>
    Private Function TespitYasGrubu(urunAdi As String, mevcutYasGrubu As String, kategori As String) As String
        ' Önce mevcut yaş grubu bilgisini kontrol et
        If Not String.IsNullOrEmpty(mevcutYasGrubu) AndAlso mevcutYasGrubu.Trim().Length > 0 Then
            Return mevcutYasGrubu
        End If
        
        ' Ürün adı ve kategoriden yaş grubu tespit et
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        ' Bebek
        If kaynak.Contains("bebek") OrElse kaynak.Contains("baby") OrElse 
           kaynak.Contains("0-") OrElse kaynak.Contains("newborn") Then
            Return "Bebek (0-2 yaş)"
        End If
        
        ' Çocuk
        If kaynak.Contains("çocuk") OrElse kaynak.Contains("cocuk") OrElse 
           kaynak.Contains("kids") OrElse kaynak.Contains("junior") OrElse
           kaynak.Contains("yaş") OrElse kaynak.Contains("yas") Then
            ' Yaş aralığını kontrol et
            If kaynak.Contains("2-") OrElse kaynak.Contains("3-") OrElse kaynak.Contains("4-") Then
                Return "Çocuk (2-6 yaş)"
            ElseIf kaynak.Contains("7-") OrElse kaynak.Contains("8-") OrElse kaynak.Contains("10-") Then
                Return "Çocuk (7-14 yaş)"
            Else
                Return "Çocuk"
            End If
        End If
        
        ' Yetişkin varsayılan
        Return "Yetişkin"
    End Function
    
    ''' <summary>
    ''' Ürün adından cinsiyet bilgisini tespit eder
    ''' </summary>
    Private Function TespitCinsiyet(urunAdi As String, mevcutCinsiyet As String, kategori As String) As String
        ' Önce mevcut cinsiyet bilgisini kontrol et (boş değilse ve Unisex değilse kullan)
        If Not String.IsNullOrEmpty(mevcutCinsiyet) AndAlso 
           Not mevcutCinsiyet.ToLower().Trim() = "unisex" AndAlso
           Not mevcutCinsiyet.ToLower().Trim() = "" Then
            Return mevcutCinsiyet
        End If
        
        ' Ürün adı ve kategoriden cinsiyet tespit et
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        ' Öncelik sırasına göre cinsiyet belirle (en spesifik olanı önce)
        If kaynak.Contains("erkek bebek") Then
            Return "Erkek Bebek"
        ElseIf kaynak.Contains("kız bebek") OrElse kaynak.Contains("kiz bebek") Then
            Return "Kız Bebek"
        ElseIf kaynak.Contains("erkek çocuk") OrElse kaynak.Contains("erkek cocuk") Then
            Return "Erkek Çocuk"
        ElseIf kaynak.Contains("kız çocuk") OrElse kaynak.Contains("kiz cocuk") Then
            Return "Kız Çocuk"
        ElseIf kaynak.Contains("kadın") OrElse kaynak.Contains("kadin") OrElse kaynak.Contains("bayan") Then
            Return "Kadın"
        ElseIf kaynak.Contains("erkek") Then
            Return "Erkek"
        ElseIf kaynak.Contains("bebek") Then
            Return "Bebek"
        ElseIf kaynak.Contains("çocuk") OrElse kaynak.Contains("cocuk") Then
            Return "Çocuk"
        Else
            Return "Unisex"
        End If
    End Function
    
    ''' <summary>
    ''' Kategori bilgisini belirler
    ''' </summary>
    Private Function GetKategoriBilgisi(kategori As String, cinsiyet As String, yasGrubu As String) As String
        Dim kat As String = kategori.ToLower()
        
        ' Önce sektör tespiti yap
        Dim sektor As String = TespitSektor(kategori, "")
        
        If sektor = "Züccaciye" Then
            Return "Züccaciye / Mutfak Ürünleri"
        ElseIf sektor = "Ev Tekstili" Then
            Return "Ev Tekstili"
        ElseIf sektor = "Elektronik" Then
            Return "Elektronik"
        ElseIf sektor = "Kozmetik" Then
            Return "Kozmetik / Kişisel Bakım"
        ElseIf kat.Contains("bebek") OrElse yasGrubu.ToLower().Contains("bebek") Then
            Return "Bebek Giyim"
        ElseIf kat.Contains("çocuk") OrElse yasGrubu.ToLower().Contains("çocuk") Then
            Return "Çocuk Giyim"
        ElseIf cinsiyet.ToLower().Contains("kadın") OrElse cinsiyet.ToLower().Contains("kız") Then
            Return "Kadın Giyim"
        ElseIf cinsiyet.ToLower().Contains("erkek") Then
            Return "Erkek Giyim"
        ElseIf kat.Contains("ayakkabı") Then
            Return "Ayakkabı"
        ElseIf kat.Contains("aksesuar") Then
            Return "Aksesuar"
        Else
            Return If(String.IsNullOrEmpty(kategori), "Genel", kategori)
        End If
    End Function
    
    ''' <summary>
    ''' Sektör tespiti yapar (Giyim, Züccaciye, Elektronik, vb.)
    ''' GENİŞLETİLMİŞ VERSİYON - Tüm sektörler
    ''' </summary>
    Private Function TespitSektor(kategori As String, urunAdi As String) As String
        Dim kat As String = If(kategori, "").ToLower()
        Dim urun As String = If(urunAdi, "").ToLower()
        
        ' DEBUG LOG
        Log("DEBUG", "TespitSektor", $"Kategori: '{kategori}', Ürün: '{urunAdi}'")
        
        ' ===== PARAMETRİK KATEGORİ TESPİTİ (ÖNCELİKLİ) =====
        ' Kategori "MUTFAK", "ELEKTRİKLİ", "BANYO" gibi değerler içeriyorsa direkt tespit et
        ' Bu değerler parametrik sınıf eşleştirmesinden geliyor (kat1 > kat2 formatında)
        
        ' === ZÜCCACİYE / KRİSTAL / CAM ÜRÜNLER (AKSESUAR kategorisinde bile olsa) ===
        ' Meyvelik, bowl, şekerlik, kristal gibi ürünler AKSESUAR'da olsa bile Züccaciye'dir!
        If kat.Contains("meyvelik") OrElse kat.Contains("şekerlik") OrElse kat.Contains("kristal") OrElse _
           kat.Contains("dekoratif") OrElse kat.Contains("vazo") OrElse kat.Contains("mumluk") OrElse _
           kat.Contains("çerçeve") OrElse kat.Contains("tabak") OrElse kat.Contains("kase") Then
            Log("INFO", "TespitSektor", $"Züccaciye tespit edildi (aksesuar alt kategori): {kategori}")
            Return "Züccaciye"
        End If
        
        ' === ELEKTRİKLİ / KÜÇÜK EV ALETLERİ ===
        If kat.Contains("elektrikli") OrElse kat.Contains("ev alet") OrElse kat.Contains("küçük ev") OrElse _
           kat.Contains("stand miks") OrElse kat.Contains("mikser") OrElse kat.Contains("blender") OrElse _
           kat.Contains("kettle") OrElse kat.Contains("kahve mak") OrElse kat.Contains("tost mak") OrElse _
           kat.Contains("airfryer") OrElse kat.Contains("fritöz") Then
            Log("INFO", "TespitSektor", $"Züccaciye/Ev Aleti tespit edildi (parametrik kategori): {kategori}")
            Return "Züccaciye"
        End If
        
        ' === MUTFAK / ZÜCCACİYE ===
        If kat.Contains("mutfak") OrElse kat.Contains("züccaciye") OrElse kat.Contains("zuccaciye") OrElse _
           kat.Contains("kase") OrElse kat.Contains("tabak") OrElse kat.Contains("bardak") OrElse _
           kat.Contains("tencere") OrElse kat.Contains("tava") OrElse kat.Contains("fincan") OrElse _
           kat.Contains("cam") OrElse kat.Contains("porselen") OrElse kat.Contains("seramik") OrElse _
           kat.Contains("saklama") OrElse kat.Contains("kavanoz") OrElse kat.Contains("servis") OrElse _
           kat.Contains("bıçak") OrElse kat.Contains("çatal") OrElse kat.Contains("kaşık") Then
            Log("INFO", "TespitSektor", $"Züccaciye tespit edildi (parametrik kategori): {kategori}")
            Return "Züccaciye"
        End If
        
        ' === BANYO ===
        If kat.Contains("banyo") OrElse kat.Contains("tuvalet") OrElse kat.Contains("duş") OrElse _
           kat.Contains("lavabo") OrElse kat.Contains("sabunluk") OrElse kat.Contains("havlu") Then
            Log("INFO", "TespitSektor", $"Banyo/Züccaciye tespit edildi (parametrik kategori): {kategori}")
            Return "Züccaciye"
        End If
        
        ' === ELEKTRONİK ===
        If kat.Contains("elektronik") OrElse kat.Contains("bilgisayar") OrElse kat.Contains("telefon") OrElse _
           kat.Contains("tablet") OrElse kat.Contains("tv") OrElse kat.Contains("ses sistemi") Then
            Log("INFO", "TespitSektor", $"Elektronik tespit edildi (parametrik kategori): {kategori}")
            Return "Elektronik"
        End If
        
        ' === KOZMETİK ===
        If kat.Contains("kozmetik") OrElse kat.Contains("parfüm") OrElse kat.Contains("makyaj") OrElse _
           kat.Contains("cilt bakım") OrElse kat.Contains("saç bakım") Then
            Log("INFO", "TespitSektor", $"Kozmetik tespit edildi (parametrik kategori): {kategori}")
            Return "Kozmetik"
        End If
        
        ' === OYUNCAK ===
        If kat.Contains("oyuncak") OrElse kat.Contains("oyun") Then
            Log("INFO", "TespitSektor", $"Oyuncak tespit edildi (parametrik kategori): {kategori}")
            Return "Oyuncak"
        End If
        
        ' === MOBİLYA ===
        If kat.Contains("mobilya") OrElse kat.Contains("masa") OrElse kat.Contains("sandalye") OrElse _
           kat.Contains("koltuk") OrElse kat.Contains("yatak") OrElse kat.Contains("dolap") Then
            Log("INFO", "TespitSektor", $"Mobilya tespit edildi (parametrik kategori): {kategori}")
            Return "Mobilya"
        End If
        
        ' ===== ÜRÜN ADINDAN TESPİT (YEDEK) =====
        ' Parametrik kategoride bulunamazsa ürün adından tespit et
        
        ' Züccaciye/Dekoratif/Kristal ürünler - ürün adından tespit (EN ÖNCELİKLİ)
        If urun.Contains("bowl") OrElse urun.Contains("meyvelik") OrElse urun.Contains("şekerlik") OrElse _
           urun.Contains("kristal") OrElse urun.Contains("crystal") OrElse urun.Contains("vazo") OrElse _
           urun.Contains("vase") OrElse urun.Contains("mumluk") OrElse urun.Contains("şamdan") OrElse _
           urun.Contains("dekoratif") OrElse urun.Contains("biblo") OrElse urun.Contains("heykel") Then
            Log("INFO", "TespitSektor", $"Züccaciye/Dekoratif tespit edildi (ürün adı): {urunAdi}")
            Return "Züccaciye"
        End If
        
        ' Kristal/Cam markaları - ürün adından tespit
        If urun.Contains("rogaska") OrElse urun.Contains("baccarat") OrElse urun.Contains("waterford") OrElse _
           urun.Contains("swarovski") OrElse urun.Contains("lalique") OrElse urun.Contains("villeroy") OrElse _
           urun.Contains("boch") OrElse urun.Contains("rosenthal") OrElse urun.Contains("meissen") OrElse _
           urun.Contains("hermes") OrElse urun.Contains("christofle") OrElse urun.Contains("daum") Then
            Log("INFO", "TespitSektor", $"Züccaciye/Kristal tespit edildi (marka): {urunAdi}")
            Return "Züccaciye"
        End If
        
        ' Küçük ev aletleri - ürün adından tespit
        If urun.Contains("mikser") OrElse urun.Contains("mixer") OrElse urun.Contains("miks") OrElse _
           urun.Contains("blender") OrElse urun.Contains("mutfak robotu") OrElse _
           urun.Contains("kitchenaid") OrElse urun.Contains("kitchen aid") OrElse _
           urun.Contains("kahve makinesi") OrElse urun.Contains("espresso") OrElse urun.Contains("nespresso") OrElse _
           urun.Contains("tost makinesi") OrElse urun.Contains("ekmek kızartma") OrElse _
           urun.Contains("kettle") OrElse urun.Contains("su ısıtıcı") OrElse _
           urun.Contains("airfryer") OrElse urun.Contains("air fryer") OrElse urun.Contains("fritöz") OrElse _
           urun.Contains("ütü") OrElse urun.Contains("süpürge") OrElse _
           urun.Contains("watt") OrElse urun.Contains("lt stand") Then
            Log("INFO", "TespitSektor", $"Züccaciye/Ev Aleti tespit edildi (ürün adı): {urunAdi}")
            Return "Züccaciye"
        End If
        
        ' Züccaciye ürünleri - ürün adından tespit
        If urun.Contains("kase") OrElse urun.Contains("tabak") OrElse urun.Contains("bardak") OrElse _
           urun.Contains("fincan") OrElse urun.Contains("tencere") OrElse urun.Contains("tava") OrElse _
           urun.Contains("çatal") OrElse urun.Contains("kaşık") OrElse urun.Contains("bıçak") OrElse _
           urun.Contains("sürahi") OrElse urun.Contains("saklama") OrElse urun.Contains("kavanoz") OrElse _
           urun.Contains("tepsi") OrElse urun.Contains("servis") OrElse urun.Contains("fırın") OrElse _
           urun.Contains("emaye") OrElse urun.Contains("porselen") OrElse urun.Contains("seramik") Then
            Log("INFO", "TespitSektor", $"Züccaciye tespit edildi (ürün adı): {urunAdi}")
            Return "Züccaciye"
        End If
        
        ' Züccaciye markaları + Küçük Ev Aletleri markaları
        If urun.Contains("mason cash") OrElse urun.Contains("joseph") OrElse urun.Contains("bordallo") OrElse _
           urun.Contains("pinheiro") OrElse urun.Contains("korkmaz") OrElse urun.Contains("emsan") OrElse _
           urun.Contains("arzum") OrElse urun.Contains("sinbo") OrElse urun.Contains("kütahya") OrElse _
           urun.Contains("paşabahçe") OrElse urun.Contains("pasabahce") OrElse urun.Contains("güral") OrElse _
           urun.Contains("porland") OrElse urun.Contains("karaca") OrElse urun.Contains("bernardo") OrElse _
           urun.Contains("borcam") OrElse urun.Contains("pyrex") OrElse urun.Contains("tefal") OrElse _
           urun.Contains("zwilling") OrElse urun.Contains("wmf") OrElse urun.Contains("fissler") OrElse _
           urun.Contains("tupperware") OrElse urun.Contains("glasslock") OrElse _
           urun.Contains("kitchenaid") OrElse urun.Contains("kenwood") OrElse urun.Contains("bosch") OrElse _
           urun.Contains("philips") OrElse urun.Contains("braun") OrElse urun.Contains("moulinex") OrElse _
           urun.Contains("delonghi") OrElse urun.Contains("smeg") OrElse urun.Contains("dyson") OrElse _
           urun.Contains("fakir") OrElse urun.Contains("arçelik") OrElse urun.Contains("beko") OrElse _
           urun.Contains("vestel") OrElse urun.Contains("grundig") OrElse urun.Contains("siemens") Then
            Log("INFO", "TespitSektor", $"Züccaciye/Ev Aleti tespit edildi (marka): {urunAdi}")
            Return "Züccaciye"
        End If
        
        ' ===== AYAKKABI =====
        If kat.Contains("ayakkabı") OrElse kat.Contains("ayakkabi") OrElse _
           urun.Contains("ayakkabı") OrElse urun.Contains("sneaker") OrElse urun.Contains("bot") OrElse _
           urun.Contains("sandalet") OrElse urun.Contains("terlik") OrElse urun.Contains("loafer") OrElse _
           urun.Contains("oxford") OrElse urun.Contains("stiletto") OrElse urun.Contains("topuklu") OrElse _
           urun.Contains("babet") OrElse urun.Contains("spor ayakkabı") OrElse urun.Contains("koşu") OrElse _
           urun.Contains("nike") OrElse urun.Contains("adidas") OrElse urun.Contains("puma") OrElse _
           urun.Contains("converse") OrElse urun.Contains("vans") OrElse urun.Contains("new balance") Then
            Return "Ayakkabı"
        End If
        
        ' ===== ÇANTA =====
        If kat.Contains("çanta") OrElse kat.Contains("canta") OrElse _
           urun.Contains("çanta") OrElse urun.Contains("sırt çantası") OrElse urun.Contains("el çantası") OrElse _
           urun.Contains("omuz çantası") OrElse urun.Contains("clutch") OrElse urun.Contains("postacı") OrElse _
           urun.Contains("valiz") OrElse urun.Contains("bavul") OrElse urun.Contains("cüzdan") Then
            Return "Çanta"
        End If
        
        ' ===== SAAT =====
        If kat.Contains("saat") OrElse _
           urun.Contains("kol saati") OrElse urun.Contains("akıllı saat") OrElse urun.Contains("smartwatch") OrElse _
           urun.Contains("casio") OrElse urun.Contains("fossil") OrElse urun.Contains("daniel wellington") OrElse _
           urun.Contains("samsung watch") OrElse urun.Contains("apple watch") OrElse urun.Contains("huawei watch") Then
            Return "Saat"
        End If
        
        ' ===== TAKI =====
        If kat.Contains("takı") OrElse kat.Contains("taki") OrElse kat.Contains("mücevher") OrElse _
           urun.Contains("kolye") OrElse urun.Contains("küpe") OrElse urun.Contains("bileklik") OrElse _
           urun.Contains("yüzük") OrElse urun.Contains("broş") OrElse urun.Contains("pandora") OrElse _
           urun.Contains("altın") OrElse urun.Contains("gümüş") OrElse urun.Contains("pırlanta") Then
            Return "Takı"
        End If
        
        ' ===== AKSESUAR (Diğer) =====
        If kat.Contains("aksesuar") OrElse _
           urun.Contains("kemer") OrElse urun.Contains("şapka") OrElse urun.Contains("bere") OrElse _
           urun.Contains("atkı") OrElse urun.Contains("fular") OrElse urun.Contains("şal") OrElse _
           urun.Contains("eldiven") OrElse urun.Contains("gözlük") OrElse urun.Contains("kravat") OrElse _
           urun.Contains("papyon") Then
            Return "Aksesuar"
        End If
        
        ' ===== BEBEK =====
        If kat.Contains("bebek") OrElse _
           urun.Contains("bebek") OrElse urun.Contains("baby") OrElse urun.Contains("infant") OrElse _
           urun.Contains("newborn") OrElse urun.Contains("0-3 ay") OrElse urun.Contains("3-6 ay") OrElse _
           urun.Contains("biberon") OrElse urun.Contains("emzik") OrElse urun.Contains("mama") OrElse _
           urun.Contains("bebek bezi") OrElse urun.Contains("bebek arabası") OrElse urun.Contains("puset") Then
            Return "Bebek"
        End If
        
        ' ===== OYUNCAK =====
        If kat.Contains("oyuncak") OrElse _
           urun.Contains("oyuncak") OrElse urun.Contains("lego") OrElse urun.Contains("barbie") OrElse _
           urun.Contains("hot wheels") OrElse urun.Contains("puzzle") OrElse urun.Contains("yapboz") OrElse _
           urun.Contains("peluş") OrElse urun.Contains("oyun") OrElse urun.Contains("bebek") Then
            Return "Oyuncak"
        End If
        
        ' ===== SPOR =====
        If kat.Contains("spor") OrElse kat.Contains("outdoor") OrElse _
           urun.Contains("spor") OrElse urun.Contains("fitness") OrElse urun.Contains("gym") OrElse _
           urun.Contains("yoga") OrElse urun.Contains("pilates") OrElse urun.Contains("koşu") OrElse _
           urun.Contains("bisiklet") OrElse urun.Contains("kamp") OrElse urun.Contains("trekking") OrElse _
           urun.Contains("dambıl") OrElse urun.Contains("plates") OrElse urun.Contains("mat") Then
            Return "Spor"
        End If
        
        ' ===== MOBİLYA / DEKORASYON =====
        If kat.Contains("mobilya") OrElse kat.Contains("dekorasyon") OrElse kat.Contains("ev") OrElse _
           urun.Contains("koltuk") OrElse urun.Contains("sandalye") OrElse urun.Contains("masa") OrElse _
           urun.Contains("sehpa") OrElse urun.Contains("dolap") OrElse urun.Contains("yatak") OrElse _
           urun.Contains("raf") OrElse urun.Contains("ayna") OrElse urun.Contains("lamba") OrElse _
           urun.Contains("abajur") OrElse urun.Contains("vazo") OrElse urun.Contains("çerçeve") Then
            Return "Mobilya"
        End If
        
        ' ===== EV TEKSTİLİ =====
        If kat.Contains("ev tekstil") OrElse kat.Contains("nevresim") OrElse kat.Contains("havlu") OrElse _
           kat.Contains("perde") OrElse kat.Contains("halı") OrElse kat.Contains("kilim") OrElse _
           urun.Contains("nevresim") OrElse urun.Contains("çarşaf") OrElse urun.Contains("yastık") OrElse _
           urun.Contains("yorgan") OrElse urun.Contains("battaniye") OrElse urun.Contains("pike") Then
            Return "Ev Tekstili"
        End If
        
        ' ===== ELEKTRONİK =====
        If kat.Contains("elektronik") OrElse kat.Contains("telefon") OrElse kat.Contains("bilgisayar") OrElse _
           urun.Contains("şarj") OrElse urun.Contains("kablo") OrElse urun.Contains("kulaklık") OrElse _
           urun.Contains("powerbank") OrElse urun.Contains("tablet") OrElse urun.Contains("laptop") Then
            Return "Elektronik"
        End If
        
        ' ===== KOZMETİK =====
        If kat.Contains("kozmetik") OrElse kat.Contains("parfüm") OrElse kat.Contains("makyaj") OrElse _
           urun.Contains("krem") OrElse urun.Contains("şampuan") OrElse urun.Contains("losyon") OrElse _
           urun.Contains("ruj") OrElse urun.Contains("fondöten") OrElse urun.Contains("maskara") Then
            Return "Kozmetik"
        End If
        
        ' ===== GİYİM (Varsayılan) =====
        If kat.Contains("giyim") OrElse kat.Contains("tekstil") OrElse _
           kat.Contains("pantolon") OrElse kat.Contains("elbise") OrElse kat.Contains("gömlek") OrElse _
           urun.Contains("tişört") OrElse urun.Contains("pantolon") OrElse urun.Contains("elbise") OrElse _
           urun.Contains("ceket") OrElse urun.Contains("mont") OrElse urun.Contains("kazak") Then
            Return "Giyim"
        End If
        
        Return "Giyim" ' Varsayılan olarak giyim döndür
    End Function
    
    ''' <summary>
    ''' Sektöre göre özellik alanlarını döndürür
    ''' </summary>
    Private Function GetSektorOzellikAlanlari(sektor As String, materyal As String, cinsiyet As String, yasGrubu As String, bedenler As String) As String
        Select Case sektor
            Case "Züccaciye"
                Return "Aşağıdaki özellikleri MUTLAKA içeriğe dahil et:
- Malzeme: (Cam, Porselen, Seramik, Paslanmaz Çelik, vb.)
- Kapasite/Boyut: (ml, lt, cm, adet)
- Set İçeriği: (Kaç parça, hangi parçalar)
- Kullanım Alanı: (Günlük, Misafir, Fırın, Ocak, vb.)
- Bulaşık Makinesine Uygunluk: (Evet/Hayır)
- Mikrodalgaya Uygunluk: (Evet/Hayır)
- Menşei: Türkiye
- Kalite: Orijinal ürün"
            
            Case "Ev Tekstili"
                Return "Aşağıdaki özellikleri MUTLAKA içeriğe dahil et:
- Kumaş: (Pamuk, Polyester, Saten, vb.)
- Boyut: (cm veya tek/çift kişilik)
- Parça Sayısı: (Set içeriği)
- Yıkama Talimatı: (Derece, program)
- Menşei: Türkiye
- Kalite: Orijinal ürün"
            
            Case "Elektronik"
                Return "Aşağıdaki özellikleri MUTLAKA içeriğe dahil et:
- Teknik Özellikler: (Watt, Volt, mAh, vb.)
- Uyumluluk: (Hangi cihazlarla uyumlu)
- Garanti: (Süre)
- Menşei: Türkiye/İthal
- Kalite: Orijinal ürün"
            
            Case "Kozmetik"
                Return "Aşağıdaki özellikleri MUTLAKA içeriğe dahil et:
- İçerik: (Ana bileşenler)
- Hacim: (ml)
- Cilt Tipi: (Uygun cilt tipleri)
- Kullanım: (Nasıl uygulanır)
- Menşei: Türkiye
- Kalite: Orijinal ürün"
            
            Case "Giyim"
                Return $"Aşağıdaki özellikleri MUTLAKA içeriğe dahil et:
- Cinsiyet: {If(String.IsNullOrEmpty(cinsiyet), "Belirtilmemiş", cinsiyet)}
- Yaş Grubu: {If(String.IsNullOrEmpty(yasGrubu), "Yetişkin", yasGrubu)}
- Kumaş: {If(String.IsNullOrEmpty(materyal), "Ürüne uygun kumaş", materyal)}
- Bedenler: {If(String.IsNullOrEmpty(bedenler), "S-M-L-XL", bedenler)}
- Menşei: Türkiye
- Kalite: Orijinal ürün"
            
            Case Else
                Return "Aşağıdaki özellikleri MUTLAKA içeriğe dahil et:
- Materyal/Malzeme
- Boyut/Ölçü
- Kullanım Alanı
- Menşei: Türkiye
- Kalite: Orijinal ürün"
        End Select
    End Function
    
    ''' <summary>
    ''' Sektöre göre bakım talimatlarını döndürür
    ''' </summary>
    Private Function GetSektorBakimTalimatlari(sektor As String) As String
        Select Case sektor
            Case "Züccaciye"
                Return "- Yıkama: Bulaşık deterjanı ile
    - Dikkat: Ani sıcaklık değişimlerinden kaçının
    - Saklama: Kuru ve serin ortamda
    - Önemli: Aşındırıcı maddeler kullanmayın"
            
            Case "Ev Tekstili"
                Return "- Yıkama: 30-40 derece, hassas program
    - Kurutma: Düşük ısıda veya asarak
    - Ütüleme: Orta ısı
    - Saklama: Kuru ve havadar ortamda"
            
            Case "Elektronik"
                Return "- Temizlik: Kuru bez ile silin
    - Dikkat: Su ve nemden uzak tutun
    - Saklama: Orijinal kutusunda
    - Önemli: Aşırı sıcak/soğuktan koruyun"
            
            Case "Kozmetik"
                Return "- Saklama: Serin ve kuru ortamda
    - Dikkat: Direkt güneş ışığından koruyun
    - Kullanım: Son kullanma tarihine dikkat edin
    - Önemli: Ağız ve göz çevresinden uzak tutun"
            
            Case "Giyim"
                Return "- Yıkama: Etiketteki talimatlara uyun
    - Kurutma: Düşük ısıda veya asarak
    - Ütüleme: Kumaş türüne göre
    - Saklama: Askıda veya katlanmış"
            
            Case Else
                Return "- Kullanım kılavuzunu okuyun
    - Temiz ve kuru tutun
    - Orijinal ambalajında saklayın"
        End Select
    End Function
    
    ''' <summary>
    ''' API yanıtını parse eder
    ''' </summary>
    Private Function ParseCompleteContentResponse(response As String) As Dictionary(Of String, String)
        Dim result As New Dictionary(Of String, String)
        result("success") = "false"
        
        Try
            ' JSON bloğunu bul
            Dim jsonStart As Integer = response.IndexOf("{")
            Dim jsonEnd As Integer = response.LastIndexOf("}") + 1
            
            If jsonStart >= 0 AndAlso jsonEnd > jsonStart Then
                Dim jsonStr As String = response.Substring(jsonStart, jsonEnd - jsonStart)
                
                Dim json As JObject = JObject.Parse(jsonStr)
                
                ' Alanları çıkar
                If json("description") IsNot Nothing Then
                    result("description") = json("description").ToString()
                End If
                
                If json("shortDescription") IsNot Nothing Then
                    result("shortDescription") = json("shortDescription").ToString()
                End If
                
                If json("features") IsNot Nothing Then
                    Dim features As JArray = CType(json("features"), JArray)
                    Dim featuresList As New List(Of String)
                    For Each feat As JToken In features
                        featuresList.Add(feat.ToString())
                    Next
                    result("features") = String.Join("|", featuresList)
                    
                    ' HTML formatında özellikler
                    Dim featuresHtml As String = "<ul class='product-features'>"
                    For Each feat As JToken In features
                        featuresHtml &= $"<li>{feat}</li>"
                    Next
                    featuresHtml &= "</ul>"
                    result("featuresHtml") = featuresHtml
                End If
                
                If json("careInstructions") IsNot Nothing Then
                    result("careInstructions") = json("careInstructions").ToString()
                End If
                
                ' Yeni alanlar: yikamaTalimati, bakimTalimati, guvenlikUyari
                If json("yikamaTalimati") IsNot Nothing Then
                    result("yikamaTalimati") = json("yikamaTalimati").ToString()
                End If
                
                If json("bakimTalimati") IsNot Nothing Then
                    result("bakimTalimati") = json("bakimTalimati").ToString()
                End If
                
                If json("guvenlikUyari") IsNot Nothing Then
                    result("guvenlikUyari") = json("guvenlikUyari").ToString()
                End If
                
                If json("seoTitle") IsNot Nothing Then
                    result("seoTitle") = json("seoTitle").ToString()
                End If
                
                If json("metaDescription") IsNot Nothing Then
                    result("metaDescription") = json("metaDescription").ToString()
                End If
                
                If json("keywords") IsNot Nothing Then
                    result("keywords") = json("keywords").ToString()
                End If
                
                result("success") = "true"
                
                ' Eksik alanları default değerlerle doldur
                If Not result.ContainsKey("yikamaTalimati") OrElse String.IsNullOrEmpty(result("yikamaTalimati")) Then
                    ' careInstructions'dan yıkama bilgisi çıkar
                    If result.ContainsKey("careInstructions") AndAlso Not String.IsNullOrEmpty(result("careInstructions")) Then
                        result("yikamaTalimati") = result("careInstructions")
                    Else
                        result("yikamaTalimati") = "<ul><li>Etiket talimatlarına uyun</li><li>Uygun şekilde temizleyin</li></ul>"
                    End If
                End If
                
                If Not result.ContainsKey("bakimTalimati") OrElse String.IsNullOrEmpty(result("bakimTalimati")) Then
                    result("bakimTalimati") = "<ul><li>Uygun şekilde saklayın</li><li>Direkt güneş ışığından koruyun</li></ul>"
                End If
                
                If Not result.ContainsKey("guvenlikUyari") OrElse String.IsNullOrEmpty(result("guvenlikUyari")) Then
                    result("guvenlikUyari") = "<ul><li>Kullanım talimatlarını okuyun</li><li>Çocuklardan uzak tutun</li></ul>"
                End If
            Else
                ' JSON bulunamadı, düz metin olarak al
                result("description") = response
                result("success") = "true"
            End If
            
        Catch ex As Exception
            Log("ERROR", "ParseCompleteContentResponse", $"JSON parse hatası: {ex.Message}")
            ' Parse edilemezse düz metin olarak kaydet
            result("description") = response
            result("success") = "true"
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' Beden tablosu oluşturur (kategori bazlı)
    ''' NOT: Züccaciye, Elektronik, Kozmetik gibi kategoriler için beden tablosu OLUŞTURULMAZ
    ''' </summary>
    Public Function GenerateSizeChart(kategori As String, cinsiyet As String, yasGrubu As String, bedenler As String) As String
        Try
            ' Sektör tespiti yap
            Dim sektor As String = TespitSektor(kategori, "")
            
            ' Züccaciye, Elektronik, Kozmetik gibi kategorilerde beden tablosu OLMAZ
            If sektor = "Züccaciye" OrElse sektor = "Elektronik" OrElse sektor = "Kozmetik" Then
                Log("INFO", "GenerateSizeChart", $"Beden tablosu oluşturulmadı - Sektör: {sektor} (beden tablosu gerektirmez)")
                Return ""
            End If
            
            ' Kategori bilgisinden sektör tespit et (ürün adı olmadan)
            Dim kategoriBilgisi As String = GetKategoriBilgisi(kategori, cinsiyet, yasGrubu)
            
            ' Züccaciye, Mutfak, Ev eşyası kontrolü (ek güvenlik)
            Dim katLower As String = If(kategori, "").ToLower()
            If katLower.Contains("züccaciye") OrElse katLower.Contains("mutfak") OrElse _
               katLower.Contains("cam") OrElse katLower.Contains("elektronik") OrElse _
               katLower.Contains("kozmetik") OrElse katLower.Contains("ev eşya") OrElse _
               kategoriBilgisi.Contains("Züccaciye") OrElse kategoriBilgisi.Contains("Elektronik") OrElse _
               kategoriBilgisi.Contains("Kozmetik") Then
                Log("INFO", "GenerateSizeChart", $"Beden tablosu oluşturulmadı - Kategori: {kategori} (beden tablosu gerektirmez)")
                Return ""
            End If
            
            ' Önce veritabanından şablon var mı kontrol et
            Dim sablonHtml As String = GetSizeChartTemplate(kategori, cinsiyet, yasGrubu)
            
            If Not String.IsNullOrEmpty(sablonHtml) Then
                Log("INFO", "GenerateSizeChart", "Şablondan beden tablosu alındı")
                Return sablonHtml
            End If
            
            ' Şablon yoksa AI ile oluştur (SADECE GİYİM ÜRÜNLERİ İÇİN)
            Dim prompt As String = $"
{kategoriBilgisi} kategorisi için profesyonel bir beden tablosu HTML'i oluştur.

Bedenler: {If(String.IsNullOrEmpty(bedenler), "XS, S, M, L, XL, XXL", bedenler)}
Cinsiyet: {If(String.IsNullOrEmpty(cinsiyet), "Unisex", cinsiyet)}

HTML formatında tablo oluştur:
- <table> etiketi ile border, cellpadding, style özellikleri olsun
- Başlık satırı thead içinde, gövde tbody içinde olsun
- Türkçe başlıklar kullan (Beden, Yaş, Boy, Göğüs, Bel, Kalça vb.)
- Profesyonel görünüm için inline CSS kullan
- Tablonun altına küçük punto ile uyarı notu ekle

SADECE HTML KODU DÖNDÜR, başka bir şey yazma!"
            
            Dim response As String = CallOpenAI(prompt, 800)
            
            ' HTML etiketlerini temizle (code block varsa)
            response = response.Replace("```html", "").Replace("```", "").Trim()
            
            Return response
            
        Catch ex As Exception
            Log("ERROR", "GenerateSizeChart", ex.Message)
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' Veritabanından beden tablosu şablonu alır
    ''' </summary>
    Private Function GetSizeChartTemplate(kategori As String, cinsiyet As String, yasGrubu As String) As String
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Önce tam eşleşme ara
                Dim cmd As New OleDb.OleDbCommand(
                    "SELECT TOP 1 sBedenTablosuHTML FROM tbBedenTablosuSablon " &
                    "WHERE bAktif = 1 AND sKategori LIKE ? ORDER BY nID", conn)
                
                ' Kategori tespiti
                Dim aramaKategori As String = GetKategoriBilgisi(kategori, cinsiyet, yasGrubu)
                cmd.Parameters.AddWithValue("?", "%" & aramaKategori & "%")
                
                Dim result As Object = cmd.ExecuteScalar()
                
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return result.ToString()
                End If
            End Using
        Catch ex As Exception
            Log("ERROR", "GetSizeChartTemplate", ex.Message)
        End Try
        
        Return ""
    End Function
    
    ''' <summary>
    ''' İçerik kalite puanı hesaplar
    ''' </summary>
    Public Function CalculateContentScore(content As Dictionary(Of String, String)) As Integer
        Dim score As Integer = 0
        
        Try
            ' Açıklama var mı? (30 puan)
            If content.ContainsKey("description") AndAlso Not String.IsNullOrEmpty(content("description")) Then
                Dim descLength As Integer = content("description").Length
                If descLength > 500 Then
                    score += 30
                ElseIf descLength > 300 Then
                    score += 20
                ElseIf descLength > 100 Then
                    score += 10
                End If
            End If
            
            ' Kısa açıklama var mı? (15 puan)
            If content.ContainsKey("shortDescription") AndAlso Not String.IsNullOrEmpty(content("shortDescription")) Then
                score += 15
            End If
            
            ' Özellikler var mı? (15 puan)
            If content.ContainsKey("features") AndAlso Not String.IsNullOrEmpty(content("features")) Then
                Dim featureCount As Integer = content("features").Split("|"c).Length
                If featureCount >= 5 Then
                    score += 15
                ElseIf featureCount >= 3 Then
                    score += 10
                End If
            End If
            
            ' SEO başlık var mı? (10 puan)
            If content.ContainsKey("seoTitle") AndAlso Not String.IsNullOrEmpty(content("seoTitle")) Then
                score += 10
            End If
            
            ' Meta description var mı? (10 puan)
            If content.ContainsKey("metaDescription") AndAlso Not String.IsNullOrEmpty(content("metaDescription")) Then
                score += 10
            End If
            
            ' Bakım talimatları var mı? (10 puan)
            If content.ContainsKey("careInstructions") AndAlso Not String.IsNullOrEmpty(content("careInstructions")) Then
                score += 10
            End If
            
            ' Anahtar kelimeler var mı? (10 puan)
            If content.ContainsKey("keywords") AndAlso Not String.IsNullOrEmpty(content("keywords")) Then
                score += 10
            End If
            
        Catch ex As Exception
            Log("ERROR", "CalculateContentScore", ex.Message)
        End Try
        
        Return score
    End Function
    
    ''' <summary>
    ''' Trendyol'un gerçek kriterlerine göre detaylı içerik puanlama sistemi
    ''' ROADMAP.md'deki Content Score v2 implementasyonu
    ''' </summary>
    Public Function CalculateTrendyolScore(nStokID As Integer, conn As OleDb.OleDbConnection) As Dictionary(Of String, Object)
        Dim result As New Dictionary(Of String, Object)
        Dim totalScore As Integer = 0
        Dim maxScore As Integer = 100
        Dim details As New List(Of String)
        Dim missingFields As New List(Of String)
        Dim recommendations As New List(Of String)
        
        Try
            EticaretLogger.LogInfo($"Trendyol Score hesaplanıyor: nStokID={nStokID}")
            
            ' Ürün verilerini çek
            Dim sql As String = "SELECT s.sAciklama, s.sModel, s.sMarka, s.sRenk, s.sKodu, " &
                               "s.sWebBaslik, s.sWebAciklama, s.sWebMetaDescription, " &
                               "s.sCinsiyet, s.sYasGrubu, s.sMateryal, s.sMensei, " &
                               "(SELECT COUNT(*) FROM tbResim r WHERE r.nStokID = s.nStokID) AS nResimSayisi, " &
                               "(SELECT COUNT(*) FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID) AS nVaryantSayisi " &
                               "FROM tbStok s WHERE s.nStokID = ?"
            
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("?", nStokID)
            
            Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' =====================================================
                    ' 1. BAŞLIK (15 puan)
                    ' =====================================================
                    Dim baslik As String = If(IsDBNull(reader("sWebBaslik")), "", reader("sWebBaslik").ToString().Trim())
                    If String.IsNullOrEmpty(baslik) Then baslik = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString().Trim())
                    
                    Dim baslikScore As Integer = 0
                    Dim baslikLength As Integer = baslik.Length
                    
                    If baslikLength >= 80 AndAlso baslikLength <= 120 Then
                        baslikScore = 15
                        details.Add($"&#10003;#10003; Başlık uzunluğu ideal ({baslikLength} karakter)")
                    ElseIf baslikLength >= 60 AndAlso baslikLength <= 150 Then
                        baslikScore = 10
                        details.Add($"⚠️ Başlık uzunluğu kabul edilebilir ({baslikLength} karakter)")
                        recommendations.Add("Başlığı 80-120 karakter arasına getirin (+5 puan)")
                    ElseIf baslikLength > 0 Then
                        baslikScore = 5
                        details.Add($"&#10060;#10060; Başlık çok kısa/uzun ({baslikLength} karakter)")
                        missingFields.Add("Başlık optimizasyonu")
                    Else
                        details.Add("&#10060;#10060; Başlık yok!")
                        missingFields.Add("Başlık")
                    End If
                    
                    ' Marka başta mı bonus (+5)
                    Dim marka As String = If(IsDBNull(reader("sMarka")), "", reader("sMarka").ToString().Trim())
                    If Not String.IsNullOrEmpty(marka) AndAlso baslik.ToLower().StartsWith(marka.ToLower()) Then
                        baslikScore += 5
                        details.Add("&#10003;#10003; Marka başlığın başında (+5 bonus)")
                    ElseIf Not String.IsNullOrEmpty(marka) Then
                        recommendations.Add("Markayı başlığın başına alın (+5 puan)")
                    End If
                    
                    totalScore += Math.Min(baslikScore, 20)
                    
                    ' =====================================================
                    ' 2. AÇIKLAMA (15 puan)
                    ' =====================================================
                    Dim aciklama As String = If(IsDBNull(reader("sWebAciklama")), "", reader("sWebAciklama").ToString().Trim())
                    Dim aciklamaScore As Integer = 0
                    Dim kelimeSayisi As Integer = If(String.IsNullOrEmpty(aciklama), 0, aciklama.Split({" "c, vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries).Length)
                    
                    If kelimeSayisi >= 500 Then
                        aciklamaScore = 15
                        details.Add($"&#10003;#10003; Açıklama detaylı ({kelimeSayisi} kelime)")
                    ElseIf kelimeSayisi >= 300 Then
                        aciklamaScore = 10
                        details.Add($"⚠️ Açıklama orta ({kelimeSayisi} kelime)")
                        recommendations.Add("Açıklamayı 500+ kelimeye çıkarın (+5 puan)")
                    ElseIf kelimeSayisi >= 100 Then
                        aciklamaScore = 5
                        details.Add($"&#10060;#10060; Açıklama kısa ({kelimeSayisi} kelime)")
                        missingFields.Add("Detaylı açıklama")
                    Else
                        details.Add("&#10060;#10060; Açıklama yok veya çok kısa!")
                        missingFields.Add("Ürün açıklaması")
                    End If
                    
                    ' HTML formatında mı bonus (+5)
                    If aciklama.Contains("<") AndAlso aciklama.Contains(">") Then
                        aciklamaScore += 5
                        details.Add("&#10003;#10003; HTML formatında açıklama (+5 bonus)")
                    Else
                        recommendations.Add("Açıklamayı HTML formatına çevirin (+5 puan)")
                    End If
                    
                    totalScore += Math.Min(aciklamaScore, 20)
                    
                    ' =====================================================
                    ' 3. GÖRSEL (20 puan) - EN ÖNEMLİ
                    ' =====================================================
                    Dim resimSayisi As Integer = If(IsDBNull(reader("nResimSayisi")), 0, CInt(reader("nResimSayisi")))
                    Dim gorselScore As Integer = 0
                    
                    If resimSayisi >= 8 Then
                        gorselScore = 20
                        details.Add($"&#10003;#10003; Yeterli görsel ({resimSayisi} adet)")
                    ElseIf resimSayisi >= 5 Then
                        gorselScore = 15
                        details.Add($"⚠️ Görsel kabul edilebilir ({resimSayisi} adet)")
                        recommendations.Add("8+ görsel ekleyin (+5 puan)")
                    ElseIf resimSayisi >= 3 Then
                        gorselScore = 10
                        details.Add($"&#10060;#10060; Görsel az ({resimSayisi} adet)")
                        missingFields.Add("Daha fazla görsel (min 5)")
                    ElseIf resimSayisi >= 1 Then
                        gorselScore = 5
                        details.Add($"&#10060;#10060; Görsel çok az ({resimSayisi} adet)")
                        missingFields.Add("En az 5 görsel gerekli")
                    Else
                        details.Add("&#10060;#10060; HİÇ GÖRSEL YOK!")
                        missingFields.Add("Görsel (zorunlu)")
                    End If
                    
                    totalScore += gorselScore
                    
                    ' =====================================================
                    ' 4. ÖZELLİKLER (25 puan) - EN AĞIRLIKLI
                    ' =====================================================
                    Dim ozellikScore As Integer = 0
                    
                    ' Cinsiyet (5 puan)
                    Dim cinsiyet As String = If(IsDBNull(reader("sCinsiyet")), "", reader("sCinsiyet").ToString().Trim())
                    If Not String.IsNullOrEmpty(cinsiyet) Then
                        ozellikScore += 5
                        details.Add("&#10003;#10003; Cinsiyet bilgisi var")
                    Else
                        missingFields.Add("Cinsiyet")
                        recommendations.Add("Cinsiyet ekleyin (+5 puan)")
                    End If
                    
                    ' Yaş Grubu (3 puan)
                    Dim yasGrubu As String = If(IsDBNull(reader("sYasGrubu")), "", reader("sYasGrubu").ToString().Trim())
                    If Not String.IsNullOrEmpty(yasGrubu) Then
                        ozellikScore += 3
                        details.Add("&#10003;#10003; Yaş grubu bilgisi var")
                    Else
                        missingFields.Add("Yaş grubu")
                    End If
                    
                    ' Renk (3 puan)
                    Dim renk As String = If(IsDBNull(reader("sRenk")), "", reader("sRenk").ToString().Trim())
                    If Not String.IsNullOrEmpty(renk) Then
                        ozellikScore += 3
                        details.Add("&#10003;#10003; Renk bilgisi var")
                    Else
                        missingFields.Add("Renk")
                    End If
                    
                    ' Materyal/Kumaş (4 puan)
                    Dim materyal As String = If(IsDBNull(reader("sMateryal")), "", reader("sMateryal").ToString().Trim())
                    If Not String.IsNullOrEmpty(materyal) Then
                        ozellikScore += 4
                        details.Add("&#10003;#10003; Materyal/kumaş bilgisi var")
                    Else
                        missingFields.Add("Materyal/Kumaş")
                        recommendations.Add("Materyal bilgisi ekleyin (+4 puan)")
                    End If
                    
                    ' Menşei (2 puan)
                    Dim mensei As String = If(IsDBNull(reader("sMensei")), "", reader("sMensei").ToString().Trim())
                    If Not String.IsNullOrEmpty(mensei) Then
                        ozellikScore += 2
                        details.Add("&#10003;#10003; Menşei bilgisi var")
                    Else
                        missingFields.Add("Menşei")
                    End If
                    
                    ' Marka (5 puan)
                    If Not String.IsNullOrEmpty(marka) Then
                        ozellikScore += 5
                        details.Add("&#10003;#10003; Marka bilgisi var")
                    Else
                        missingFields.Add("Marka")
                        recommendations.Add("Marka ekleyin (+5 puan)")
                    End If
                    
                    totalScore += Math.Min(ozellikScore, 25)
                    
                    ' =====================================================
                    ' 5. VARYANT (15 puan)
                    ' =====================================================
                    Dim varyantSayisi As Integer = If(IsDBNull(reader("nVaryantSayisi")), 0, CInt(reader("nVaryantSayisi")))
                    Dim varyantScore As Integer = 0
                    
                    If varyantSayisi >= 5 Then
                        varyantScore = 15
                        details.Add($"&#10003;#10003; Yeterli varyant ({varyantSayisi} adet)")
                    ElseIf varyantSayisi >= 3 Then
                        varyantScore = 10
                        details.Add($"⚠️ Varyant kabul edilebilir ({varyantSayisi} adet)")
                    ElseIf varyantSayisi >= 1 Then
                        varyantScore = 5
                        details.Add($"&#10060;#10060; Varyant az ({varyantSayisi} adet)")
                    Else
                        details.Add("&#10060;#10060; Varyant yok!")
                        missingFields.Add("Beden/renk varyantları")
                    End If
                    
                    totalScore += varyantScore
                    
                    ' =====================================================
                    ' 6. META DESCRIPTION (5 puan)
                    ' =====================================================
                    Dim metaDesc As String = If(IsDBNull(reader("sWebMetaDescription")), "", reader("sWebMetaDescription").ToString().Trim())
                    If Not String.IsNullOrEmpty(metaDesc) AndAlso metaDesc.Length >= 100 Then
                        totalScore += 5
                        details.Add("&#10003;#10003; Meta description var")
                    Else
                        recommendations.Add("Meta description ekleyin (+5 puan)")
                    End If
                    
                End If
            End Using
            
            ' Sonuçları hazırla
            result("totalScore") = totalScore
            result("maxScore") = maxScore
            result("percentage") = CInt((totalScore / maxScore) * 100)
            result("grade") = GetGrade(totalScore)
            result("details") = details
            result("missingFields") = missingFields
            result("recommendations") = recommendations
            result("nStokID") = nStokID
            
            EticaretLogger.LogInfo($"Trendyol Score hesaplandı: nStokID={nStokID}, Puan={totalScore}/{maxScore}, Grade={result("grade")}")
            
        Catch ex As Exception
            EticaretLogger.LogError($"CalculateTrendyolScore hatası: nStokID={nStokID}", ex)
            result("error") = ex.Message
            result("totalScore") = 0
            result("maxScore") = maxScore
            result("grade") = "F"
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' Puana göre not hesapla
    ''' </summary>
    Private Function GetGrade(score As Integer) As String
        Select Case score
            Case Is >= 90 : Return "A"
            Case Is >= 75 : Return "B"
            Case Is >= 60 : Return "C"
            Case Is >= 40 : Return "D"
            Case Else : Return "F"
        End Select
    End Function
    
    ' =====================================================
    ' YENİ SEKTÖR PROMPTLARI
    ' =====================================================
    
    ''' <summary>
    ''' AYAKKABI ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildAyakkabiPrompt(urunAdi As String, marka As String, kategori As String, 
                                          cinsiyet As String, yasGrubu As String, materyal As String, bedenler As String) As String
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        Dim gercekYasGrubu As String = TespitYasGrubu(urunAdi, yasGrubu, kategori)
        
        Return $"Sen Türkiye'nin en başarılı ayakkabı e-ticaret içerik yazarısın. Nike, Adidas, Skechers gibi markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}
Yaş Grubu: {gercekYasGrubu}
Materyal: {If(String.IsNullOrEmpty(materyal), "[Deri/Tekstil/Sentetik - tahmin et]", materyal)}

=== SATIŞ PSİKOLOJİSİ ===
1. KONFOR VURGULA: ""Gün boyu yorulmadan yürüyün""
2. STİL + PERFORMANS: ""Hem şık hem rahat""
3. BEDEN GÜVENCE: ""Normalden dar/geniş keser"" bilgisi
4. MARKA GÜVENİ: ""Orijinal ürün, yetkili satıcı""
5. DAYANIKLILIK: ""Yıllarca giyeceğiniz kalite""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>👟 {marka} {urunAdi} - Adımlarınıza Güç Katın!</h3>
    
    <p><strong>Her adımda konfor, her kombinle uyum!</strong></p>
    
    <p>[3-4 cümle: Ayakkabının günlük hayatta nasıl fayda sağlayacağını anlat. 
    Örnek: İster sabah koşusunda, ister akşam yürüyüşünde... Bu ayakkabı ile her adımınız 
    konforlu olacak. Özel taban teknolojisi ayaklarınızı gün boyu desteklerken, şık tasarımı 
    ile her kombinle uyum sağlar.]</p>
    
    <h4>&#10022;#10022; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Üst Malzeme:</strong> [Deri/Tekstil/Mesh/Sentetik]</li>
      <li><strong>Taban:</strong> [Kauçuk/EVA/Phylon] - Kaymaz, esnek</li>
      <li><strong>İç Astar:</strong> [Tekstil] - Nefes alan yapı</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
      <li><strong>Yaş Grubu:</strong> {gercekYasGrubu}</li>
      <li><strong>Kullanım:</strong> [Günlük/Spor/Outdoor]</li>
      <li><strong>Sezon:</strong> [4 Mevsim/Yaz/Kış]</li>
    </ul>
    
    <h4>&#128207;#128207; Beden Rehberi</h4>
    <p><strong>⚠️ Dikkat:</strong> [Normal kalıp / Dar kalıp - yarım numara büyük alın / Geniş kalıp]</p>
    <p>Ayak uzunluğunuzu ölçün ve tabloyu kontrol edin.</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal {marka} Ürünü</li>
      <li>&#10003;#10003; Yetkili Satıcı Garantisi</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Kolay İade (Deneme hakkı)</li>
    </ul>
    
    <p><strong>&#128722;#128722; Ayaklarınız bu konforu hak ediyor - Hemen sipariş verin!</strong></p>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Malzeme] | [Taban] | Orijinal | Hızlı kargo"",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Yaş Grubu: {gercekYasGrubu}"",
    ""Üst Malzeme: [Deri/Tekstil/Sentetik]"",
    ""Taban: [Kauçuk/EVA]"",
    ""Kalıp: [Normal/Dar/Geniş]"",
    ""Kullanım Alanı: [Günlük/Spor/Outdoor]"",
    ""Sezon: [4 Mevsim]"",
    ""Menşei: [Türkiye/Vietnam/Çin]"",
    ""Garanti: Orijinal ürün garantisi""
  ],
  
  ""careInstructions"": ""<div><h4>👞 Bakım Talimatları</h4><ul><li>Yumuşak fırça ile temizleyin</li><li>Direkt güneş ışığından koruyun</li><li>Nemli bezle silin, makinede yıkamayın</li><li>Gazete kağıdı ile şeklini koruyun</li><li>Hava almasını sağlayın</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Makinede yıkamayın</li><li>Nemli bezle silin</li><li>Özel ayakkabı temizleyici kullanın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Gazete kağıdı ile şeklini koruyun</li><li>Direkt güneş ışığından koruyun</li><li>Hava almasını sağlayın</li><li>Deri bakım kremi kullanın</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Ilık su kullanın</li><li>Keskin cisimlerden uzak tutun</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | {gercekCinsiyet} Ayakkabı | Orijinal | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓{gercekCinsiyet} ✓Orijinal ✓Hızlı Kargo ✓Kolay İade. [Malzeme] üst, [taban] taban. En uygun fiyat!"",
  
  ""keywords"": ""{marka}, {urunAdi}, ayakkabı, {gercekCinsiyet}, spor ayakkabı, günlük ayakkabı, orijinal, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' ÇANTA ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildCantaPrompt(urunAdi As String, marka As String, kategori As String, 
                                       cinsiyet As String, materyal As String, renkler As String) As String
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        
        Return $"Sen Türkiye'nin en başarılı çanta e-ticaret içerik yazarısın. Lüks ve günlük çanta markalarının içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Deri/Suni Deri/Kanvas - tahmin et]", materyal)}

=== SATIŞ PSİKOLOJİSİ ===
1. STİL İKONU: ""Her kadının dolabında olması gereken""
2. FONKSİYONELLİK: ""Tüm eşyalarınız düzenli""
3. KALİTE VURGUSU: ""El işçiliği"", ""Premium malzeme""
4. KOMBİN: ""Her kıyafetle uyumlu""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>👜 {marka} {urunAdi} - Tarzınızın Tamamlayıcısı!</h3>
    
    <p><strong>Şıklık ve pratiklik bir arada!</strong></p>
    
    <p>[3-4 cümle: Çantanın günlük kullanımda nasıl fark yaratacağını anlat.
    Örnek: Sabah işe giderken, öğlen toplantıda, akşam arkadaşlarla buluşurken... 
    Bu şık çanta her anınıza eşlik edecek. Geniş iç hacmi ile tüm eşyalarınızı düzenli 
    taşırken, premium malzemesi ile yıllarca kullanacaksınız.]</p>
    
    <h4>&#10022;#10022; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Malzeme:</strong> [Hakiki Deri/Suni Deri/Kanvas]</li>
      <li><strong>Boyut:</strong> [cm x cm x cm]</li>
      <li><strong>Askı:</strong> [Ayarlanabilir/Sabit] - [cm uzunluk]</li>
      <li><strong>Kapama:</strong> [Fermuarlı/Mıknatıslı/Çıtçıtlı]</li>
      <li><strong>İç Bölme:</strong> [X adet cep, telefon gözü, fermuarlı bölme]</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
    </ul>
    
    <h4>&#128230;#128230; Kullanım Alanları</h4>
    <p>[İş/Okul/Günlük/Seyahat] için ideal</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; Özel Kutusunda Gönderim</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Malzeme] | [Boyut] | Orijinal | Hızlı kargo"",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Malzeme: [Deri/Suni Deri/Kanvas]"",
    ""Boyut: [cm x cm x cm]"",
    ""Askı Uzunluğu: [cm]"",
    ""Kapama Tipi: [Fermuarlı/Mıknatıslı]"",
    ""İç Bölme: [X adet]"",
    ""Menşei: [Türkiye/İthal]""
  ],
  
  ""careInstructions"": ""<div><h4>👜 Bakım</h4><ul><li>Nemli bezle silin</li><li>Deri bakım kremi kullanın</li><li>Direkt güneşten koruyun</li><li>İçini boşaltarak saklayın</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Makinede yıkamayın</li><li>Nemli bezle silin</li><li>Deri için özel temizleyici kullanın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Deri bakım kremi kullanın</li><li>Direkt güneşten koruyun</li><li>İçini boşaltarak saklayın</li><li>Gazete kağıdı ile doldurun</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Keskin cisimlerden uzak tutun</li><li>Ağır yük taşımayın</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | {gercekCinsiyet} Çanta | Orijinal | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓{gercekCinsiyet} ✓[Malzeme] ✓Orijinal ✓Hızlı Kargo. Şık ve fonksiyonel!"",
  
  ""keywords"": ""{marka}, çanta, {gercekCinsiyet}, el çantası, omuz çantası, orijinal, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' SAAT ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildSaatPrompt(urunAdi As String, marka As String, kategori As String, 
                                      cinsiyet As String) As String
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        
        Return $"Sen Türkiye'nin en başarılı saat e-ticaret içerik yazarısın. Casio, Fossil, Daniel Wellington gibi markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}

=== SATIŞ PSİKOLOJİSİ ===
1. STATÜ SEMBOLÜ: ""Tarzınızı yansıtın""
2. KALİTE: ""İsviçre mekanizma"", ""Japon kuvars""
3. DAYANIKLILIK: ""Su geçirmez"", ""Çizilmez cam""
4. YATIRIM: ""Yıllarca değerini korur""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>&#8986;#8986; {marka} {urunAdi} - Zamanın Şık Yüzü!</h3>
    
    <p><strong>Her bakışta prestij, her anı özel kılın!</strong></p>
    
    <p>[3-4 cümle: Saatin nasıl bir stil ikonu olduğunu anlat.
    Örnek: İş toplantısında güven, özel gecede şıklık... Bu zarif saat bileğinizde 
    bir statü sembolü olacak. Hassas mekanizması ile dakik, şık tasarımı ile göz alıcı.]</p>
    
    <h4>&#9881;#9881; Teknik Özellikler</h4>
    <ul>
      <li><strong>Mekanizma:</strong> [Kuvars/Otomatik/Dijital]</li>
      <li><strong>Kasa Çapı:</strong> [mm]</li>
      <li><strong>Kasa Malzeme:</strong> [Paslanmaz Çelik/Titanyum]</li>
      <li><strong>Cam:</strong> [Mineral/Safir] - Çizilmeye dayanıklı</li>
      <li><strong>Kordon:</strong> [Deri/Çelik/Silikon]</li>
      <li><strong>Su Geçirmezlik:</strong> [3/5/10 ATM]</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
    </ul>
    
    <h4>&#128230;#128230; Kutu İçeriği</h4>
    <p>Saat + Orijinal kutu + Garanti belgesi + Kullanım kılavuzu</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; [X] Yıl Resmi Garanti</li>
      <li>&#10003;#10003; Orijinal Kutusunda Gönderim</li>
      <li>&#10003;#10003; Hızlı & Sigortalı Kargo</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Mekanizma] | [Su geçirmezlik] | Orijinal | Garantili"",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Mekanizma: [Kuvars/Otomatik]"",
    ""Kasa Çapı: [mm]"",
    ""Kasa Malzeme: [Paslanmaz Çelik]"",
    ""Cam: [Mineral/Safir]"",
    ""Kordon: [Deri/Çelik]"",
    ""Su Geçirmezlik: [X] ATM"",
    ""Garanti: [X] Yıl""
  ],
  
  ""careInstructions"": ""<div><h4>&#8986;#8986; Bakım</h4><ul><li>Su geçirmezlik sınırını aşmayın</li><li>Manyetik alanlardan uzak tutun</li><li>Yumuşak bezle temizleyin</li><li>Deri kordon için bakım kremi</li><li>Pil değişimi yetkili serviste</li></ul></div>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | {gercekCinsiyet} Kol Saati | Orijinal | Garantili"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓{gercekCinsiyet} ✓Orijinal ✓[X] Yıl Garanti ✓Hızlı Kargo. [Mekanizma], [su geçirmezlik]!"",
  
  ""keywords"": ""{marka}, kol saati, {gercekCinsiyet}, orijinal saat, garantili, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' TAKI ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildTakiPrompt(urunAdi As String, marka As String, kategori As String, 
                                      cinsiyet As String, materyal As String) As String
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        
        Return $"Sen Türkiye'nin en başarılı takı e-ticaret içerik yazarısın. Pandora, Swarovski gibi markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Gümüş/Altın/Çelik - tahmin et]", materyal)}

=== SATIŞ PSİKOLOJİSİ ===
1. HEDİYE: ""Sevdiklerinize özel""
2. EL İŞÇİLİĞİ: ""Özenle işlenmiş""
3. ANLAM: ""Her parçanın bir hikayesi var""
4. ÖZEL AN: ""Doğum günü, yıldönümü, sevgililer günü""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>&#9830;#9830; {marka} {urunAdi} - Zarafetin Simgesi!</h3>
    
    <p><strong>Işıltınıza ışıltı katın!</strong></p>
    
    <p>[3-4 cümle: Takının nasıl özel hissettireceğini anlat.
    Örnek: Her kadın özel günlerde parlamak ister. Bu zarif tasarım ile tüm bakışları 
    üzerinize çekeceksiniz. İster kendinize ister sevdiklerinize... Unutulmaz bir hediye.]</p>
    
    <h4>💍 Ürün Özellikleri</h4>
    <ul>
      <li><strong>Malzeme:</strong> [925 Ayar Gümüş/14K Altın/Çelik]</li>
      <li><strong>Kaplama:</strong> [Altın/Rose Gold/Rodaj]</li>
      <li><strong>Taş:</strong> [Zirkon/Swarovski/Pırlanta]</li>
      <li><strong>Uzunluk:</strong> [cm]</li>
      <li><strong>Ağırlık:</strong> [gram]</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
    </ul>
    
    <h4>🎁 Hediye Seçenekleri</h4>
    <p>Özel hediye kutusunda, sevgililer günü, doğum günü, yıldönümü için ideal</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; Sertifikalı (varsa)</li>
      <li>&#10003;#10003; Özel Hediye Kutusunda</li>
      <li>&#10003;#10003; Hızlı & Güvenli Kargo</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Malzeme] | [Taş] | Hediye kutusunda"",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Malzeme: [Gümüş/Altın/Çelik]"",
    ""Ayar: [925/14K/18K]"",
    ""Taş: [Zirkon/Swarovski]"",
    ""Uzunluk: [cm]"",
    ""Ağırlık: [gram]"",
    ""Paket: Hediye kutusunda""
  ],
  
  ""careInstructions"": ""<div><h4>&#9830;#9830; Bakım</h4><ul><li>Parfüm ve kremden sonra takın</li><li>Nemli ortamdan koruyun</li><li>Ayrı kutuda saklayın</li><li>Gümüş parlatma bezi kullanın</li><li>Profesyonel temizlik önerilir</li></ul></div>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | {gercekCinsiyet} Takı | Hediye | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓{gercekCinsiyet} ✓[Malzeme] ✓Hediye kutusunda ✓Hızlı Kargo. Özel anlara özel hediye!"",
  
  ""keywords"": ""{marka}, takı, kolye, küpe, bileklik, {gercekCinsiyet}, hediye, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' AKSESUAR ÜRÜNLERİ İÇİN PROFESYONEL PROMPT (Kemer, Şapka, Atkı vb.)
    ''' </summary>
    Private Function BuildAksesuarPrompt(urunAdi As String, marka As String, kategori As String, 
                                          cinsiyet As String, materyal As String, renkler As String) As String
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        
        Return $"Sen Türkiye'nin en başarılı aksesuar e-ticaret içerik yazarısın.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Deri/Tekstil/Yün - tahmin et]", materyal)}

=== SATIŞ PSİKOLOJİSİ ===
1. TAMAMLAYICI: ""Kombininizin son dokunuşu""
2. ÇOK YÖNLÜ: ""Her kıyafetle uyumlu""
3. KALİTE: ""Premium malzeme""
4. SEZON: ""Yaz/Kış koleksiyonu""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>🎩 {marka} {urunAdi} - Tarzınıza Son Dokunuş!</h3>
    
    <p><strong>Kombininizi tamamlayan detay!</strong></p>
    
    <p>[3-4 cümle: Aksesuarın tarzı nasıl tamamladığını anlat.]</p>
    
    <h4>&#10022;#10022; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Malzeme:</strong> [Deri/Tekstil/Yün/Akrilik]</li>
      <li><strong>Boyut:</strong> [cm veya S/M/L]</li>
      <li><strong>Renk:</strong> [Renk bilgisi]</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
      <li><strong>Sezon:</strong> [Kış/Yaz/4 Mevsim]</li>
    </ul>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Malzeme] | Orijinal | Hızlı kargo"",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Malzeme: [Deri/Tekstil/Yün]"",
    ""Boyut: [S/M/L veya cm]"",
    ""Sezon: [Kış/Yaz/4 Mevsim]"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>🧣 Bakım</h4><ul><li>Etiket talimatlarını takip edin</li><li>Kuru temizleme önerilir</li><li>Düz yüzeyde saklayın</li></ul></div>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | {gercekCinsiyet} Aksesuar | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓{gercekCinsiyet} ✓[Malzeme] ✓Orijinal ✓Hızlı Kargo. Tarzınızı tamamlayın!"",
  
  ""keywords"": ""{marka}, aksesuar, {gercekCinsiyet}, kemer, şapka, atkı, orijinal, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' BEBEK ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildBebekPrompt(urunAdi As String, marka As String, kategori As String, 
                                       cinsiyet As String, materyal As String, bedenler As String) As String
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        If gercekCinsiyet = "Unisex" Then gercekCinsiyet = "Unisex (Erkek Bebek/Kız Bebek)"
        
        Return $"Sen Türkiye'nin en başarılı bebek ürünleri e-ticaret içerik yazarısın. Anne-babaların güvenini kazanan içerikler yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Organik pamuk/Pamuk - tahmin et]", materyal)}

=== YASAKLAR ===
&#10060;#10060; Abartılı sağlık vaatleri

=== SATIŞ PSİKOLOJİSİ ===
1. GÜVENLİK: ""Sertifikalı"", ""BPA içermez"", ""Hipoalerjenik""
2. ANNE GÜVENİ: ""Binlerce anne tercih ediyor""
3. KONFOR: ""Bebeğinizin hassas cildine uygun""
4. KALİTE: ""Orijinal"", ""Garantili""
5. PRATİKLİK: ""Kolay giyim"", ""Kolay yıkama""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>👶 {marka} {urunAdi} - Bebeğiniz İçin En İyisi!</h3>
    
    <p><strong>Minik bedeniniz için büyük konfor!</strong></p>
    
    <p>[3-4 cümle: Ürünün bebeğe ve anneye nasıl fayda sağlayacağını anlat.
    Örnek: Bebeğinizin hassas cildi en yumuşak dokunuşu hak ediyor. %100 organik pamuktan 
    üretilen bu ürün, cildi tahriş etmez ve gün boyu konfor sağlar. Kolay giydirme tasarımı 
    ile anne-babaların işini kolaylaştırır.]</p>
    
    <h4>&#10022;#10022; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Malzeme:</strong> [%100 Organik Pamuk/Pamuk]</li>
      <li><strong>Sertifika:</strong> [OEKO-TEX/GOTS] - Bebek güvenliği onaylı</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
      <li><strong>Yaş/Beden:</strong> [0-3 ay / 3-6 ay / 6-12 ay vb.]</li>
      <li><strong>Özellik:</strong> Hipoalerjenik, hassas cilt dostu</li>
    </ul>
    
    <h4>&#128207;#128207; Beden Tablosu</h4>
    <p>0-3 ay: 56-62 cm | 3-6 ay: 62-68 cm | 6-9 ay: 68-74 cm | 9-12 ay: 74-80 cm</p>
    
    <h4>&#128274;#128274; Anne Güvencesi</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; Sertifikalı Güvenli Malzeme</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Malzeme] | Sertifikalı | Hızlı kargo"",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Yaş Grubu: Bebek"",
    ""Malzeme: [Organik Pamuk/Pamuk]"",
    ""Sertifika: [OEKO-TEX]"",
    ""Özellik: Hipoalerjenik"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>👶 Bebek Kıyafeti Bakımı</h4><ul><li>İlk kullanımdan önce yıkayın</li><li>30°C'de hassas programda yıkayın</li><li>Bebek deterjanı kullanın</li><li>Yumuşatıcı kullanmayın</li><li>Düşük ısıda kurutun</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>İlk kullanımdan önce yıkayın</li><li>30°C'de hassas programda yıkayın</li><li>Bebek deterjanı kullanın</li><li>Renklileri ayrı yıkayın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Yumuşatıcı kullanmayın</li><li>Düşük ısıda kurutun</li><li>Orta ısıda ütüleyin</li><li>Kuru temizleme yapmayın</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Bebek üzerinde gevşek parçalar bırakmayın</li><li>Düğme ve aksesuar kontrolü yapın</li><li>Sertifikalı ürün kullanın</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | Bebek | [Malzeme] | Sertifikalı | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓Bebek ✓[Malzeme] ✓Sertifikalı ✓Hızlı Kargo. Bebeğiniz için en güvenlisi!"",
  
  ""keywords"": ""{marka}, bebek, {gercekCinsiyet}, organik, pamuk, bebek kıyafeti, güvenli, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' SPOR ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildSporPrompt(urunAdi As String, marka As String, kategori As String, 
                                      cinsiyet As String, yasGrubu As String, materyal As String, bedenler As String) As String
        Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
        Dim gercekYasGrubu As String = TespitYasGrubu(urunAdi, yasGrubu, kategori)
        
        Return $"Sen Türkiye'nin en başarılı spor ürünleri e-ticaret içerik yazarısın. Nike, Under Armour, Decathlon gibi markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Cinsiyet: {gercekCinsiyet}
Yaş Grubu: {gercekYasGrubu}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Polyester/Nylon - tahmin et]", materyal)}

=== SATIŞ PSİKOLOJİSİ ===
1. PERFORMANS: ""Limitlerini zorla""
2. TEKNOLOJİ: ""Nem çekici"", ""Nefes alan""
3. MOTİVASYON: ""Hedeflerine bir adım daha yaklaş""
4. DAYANIKLILIK: ""Yoğun antrenmanlar için""
5. KONFOR: ""Hareket özgürlüğü""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>💪 {marka} {urunAdi} - Limitlerini Aş!</h3>
    
    <p><strong>Her antrenman bir zafer!</strong></p>
    
    <p>[3-4 cümle: Ürünün sportif performansı nasıl artıracağını anlat.
    Örnek: Sabah koşusundan akşam fitness'a, her antrenmanınızda yanınızda. Nem çekici 
    teknolojisi ile kuru ve konforlu kalın. Esnek yapısı ile tam hareket özgürlüğü.]</p>
    
    <h4>⚡ Performans Özellikleri</h4>
    <ul>
      <li><strong>Malzeme:</strong> [Polyester/Nylon] - Hafif, dayanıklı</li>
      <li><strong>Teknoloji:</strong> [Dri-FIT/ClimaCool] - Nem yönetimi</li>
      <li><strong>Nefes Alabilirlik:</strong> Havalandırma panelleri</li>
      <li><strong>Esneklik:</strong> 4 yönlü streç</li>
      <li><strong>Cinsiyet:</strong> {gercekCinsiyet}</li>
      <li><strong>Yaş Grubu:</strong> {gercekYasGrubu}</li>
      <li><strong>Kullanım:</strong> [Fitness/Koşu/Yoga/Outdoor]</li>
    </ul>
    
    <h4>🏋️ İdeal Kullanım Alanları</h4>
    <p>[Spor salonu/Koşu/Yoga/Outdoor aktiviteler] için tasarlandı</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal {marka} Ürünü</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | {gercekCinsiyet} | [Malzeme] | [Teknoloji] | Orijinal | Hızlı kargo"",
  
  ""features"": [
    ""Cinsiyet: {gercekCinsiyet}"",
    ""Yaş Grubu: {gercekYasGrubu}"",
    ""Malzeme: [Polyester/Nylon]"",
    ""Teknoloji: [Nem çekici]"",
    ""Kullanım: [Fitness/Koşu/Yoga]"",
    ""Özellik: Nefes alan, esnek"",
    ""Menşei: [Türkiye/Vietnam]""
  ],
  
  ""careInstructions"": ""<div><h4>🧺 Spor Giysi Bakımı</h4><ul><li>Soğuk suda yıkayın</li><li>Yumuşatıcı kullanmayın (performansı düşürür)</li><li>Asarak kurutun</li><li>Ütülemeyin</li></ul></div>"",
  
  ""yikamaTalimati"": ""<ul><li>Soğuk suda yıkayın</li><li>Tersten yıkayın</li><li>Diğer kıyafetlerle ayrı yıkayın</li><li>Çamaşır suyu kullanmayın</li></ul>"",
  
  ""bakimTalimati"": ""<ul><li>Yumuşatıcı kullanmayın</li><li>Asarak kurutun</li><li>Makinede kurutmayın</li><li>Ütülemeyin</li></ul>"",
  
  ""guvenlikUyari"": ""<ul><li>Etiket talimatlarına uyun</li><li>Kuru temizleme yapmayın</li></ul>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | {gercekCinsiyet} Spor | Orijinal | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓{gercekCinsiyet} ✓[Teknoloji] ✓Orijinal ✓Hızlı Kargo. Performansınızı artırın!"",
  
  ""keywords"": ""{marka}, spor, fitness, {gercekCinsiyet}, antrenman, orijinal, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' OYUNCAK ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildOyuncakPrompt(urunAdi As String, marka As String, kategori As String, 
                                         yasGrubu As String) As String
        Return $"Sen Türkiye'nin en başarılı oyuncak e-ticaret içerik yazarısın. LEGO, Barbie, Hot Wheels gibi markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Yaş Grubu: {If(String.IsNullOrEmpty(yasGrubu), "[Yaş aralığını belirle]", yasGrubu)}

=== YASAKLAR ===
&#10060;#10060; Cinsiyet (oyuncaklarda genel olarak yaş önemli)

=== SATIŞ PSİKOLOJİSİ ===
1. EĞİTİCİ: ""Motor becerilerini geliştirir""
2. EĞLENCELİ: ""Saatlerce eğlence""
3. GÜVENLİ: ""CE sertifikalı"", ""BPA içermez""
4. ANNE ONAYI: ""Ebeveynlerin güvendiği marka""
5. HEDİYE: ""Doğum günü için ideal""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>🎮 {marka} {urunAdi} - Eğlence Zamanı!</h3>
    
    <p><strong>Çocuğunuzun yüzündeki gülümseme priceless!</strong></p>
    
    <p>[3-4 cümle: Oyuncağın çocuğa nasıl keyif vereceğini anlat.
    Örnek: Hayal gücünü sınırsızca keşfetsin! Bu eğitici oyuncak ile çocuğunuz hem eğlenecek 
    hem de gelişecek. Motor becerileri, yaratıcılık ve problem çözme yeteneği için ideal.]</p>
    
    <h4>🧸 Ürün Özellikleri</h4>
    <ul>
      <li><strong>Yaş Grubu:</strong> [X-Y yaş] için uygundur</li>
      <li><strong>Parça Sayısı:</strong> [X adet] (varsa)</li>
      <li><strong>Malzeme:</strong> [Plastik/Ahşap/Peluş] - Güvenli malzeme</li>
      <li><strong>Sertifika:</strong> CE belgeli, BPA içermez</li>
      <li><strong>Batarya:</strong> [Gerekli/Dahil/Gerekmez]</li>
    </ul>
    
    <h4>🎓 Eğitici Özellikler</h4>
    <ul>
      <li>[Motor becerileri]</li>
      <li>[Hayal gücü]</li>
      <li>[Problem çözme]</li>
      <li>[Renk/şekil tanıma]</li>
    </ul>
    
    <h4>&#128274;#128274; Anne-Baba Güvencesi</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; CE Sertifikalı - Güvenli</li>
      <li>&#10003;#10003; Hızlı Kargo</li>
      <li>&#10003;#10003; Hediye Paketi Seçeneği</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | [Yaş grubu] | Eğitici | CE Sertifikalı | Hızlı kargo"",
  
  ""features"": [
    ""Yaş Grubu: [X-Y yaş]"",
    ""Parça Sayısı: [X adet]"",
    ""Malzeme: [Plastik/Ahşap]"",
    ""Sertifika: CE belgeli"",
    ""Güvenlik: BPA içermez"",
    ""Batarya: [Gerekli/Gerekmez]"",
    ""Menşei: [Türkiye/İthal]""
  ],
  
  ""careInstructions"": ""<div><h4>🧸 Oyuncak Bakımı</h4><ul><li>Nemli bezle temizleyin</li><li>3 yaş altı için küçük parçalara dikkat</li><li>Direkt güneşten koruyun</li><li>Orijinal ambalajında saklayın</li></ul></div>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | [Yaş] Yaş Oyuncak | CE Sertifikalı | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓[Yaş grubu] ✓Eğitici ✓CE Sertifikalı ✓Hızlı Kargo. Çocuğunuz için güvenli eğlence!"",
  
  ""keywords"": ""{marka}, oyuncak, çocuk, eğitici, güvenli, CE sertifikalı, hediye, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
    ''' <summary>
    ''' MOBİLYA / DEKORASYON ÜRÜNLERİ İÇİN PROFESYONEL PROMPT
    ''' </summary>
    Private Function BuildMobilyaPrompt(urunAdi As String, marka As String, kategori As String, 
                                         materyal As String, renkler As String) As String
        Return $"Sen Türkiye'nin en başarılı mobilya ve dekorasyon e-ticaret içerik yazarısın. IKEA, Bellona gibi markaların içeriklerini yazıyorsun.

=== ÜRÜN ===
{urunAdi}
Marka: {If(String.IsNullOrEmpty(marka), "[Markayı ürün adından çıkar]", marka)}
Malzeme: {If(String.IsNullOrEmpty(materyal), "[Ahşap/Metal/Cam - tahmin et]", materyal)}

=== YASAKLAR ===
&#10060;#10060; Cinsiyet (mobilyada cinsiyet olmaz!)
&#10060;#10060; Yaş grubu

=== SATIŞ PSİKOLOJİSİ ===
1. DÖNÜŞÜM: ""Evinizi yenileyin""
2. KALİTE: ""Yıllarca kullanacağınız dayanıklılık""
3. TASARIM: ""Modern/Klasik/Minimalist""
4. FONKSİYONEL: ""Pratik, çok amaçlı""
5. KURULUM: ""Kolay montaj""

=== JSON FORMATI ===
{{
  ""description"": ""<div class='product-description'>
    <h3>&#127968;#127968; {marka} {urunAdi} - Evinize Karakter Katın!</h3>
    
    <p><strong>Yaşam alanınızı yeniden tanımlayın!</strong></p>
    
    <p>[3-4 cümle: Ürünün eve nasıl değer katacağını anlat.
    Örnek: Eviniz sizin yansımanız. Bu şık tasarım ile yaşam alanınıza modern bir dokunuş 
    katın. Kaliteli malzemesi ile yıllarca kullanacak, dayanıklı yapısı ile ailenize 
    güvenle hizmet edecek.]</p>
    
    <h4>&#10022;#10022; Ürün Özellikleri</h4>
    <ul>
      <li><strong>Malzeme:</strong> [MDF/Ahşap/Metal/Cam]</li>
      <li><strong>Boyutlar:</strong> [En x Boy x Yükseklik cm]</li>
      <li><strong>Renk:</strong> [Renk seçenekleri]</li>
      <li><strong>Taşıma Kapasitesi:</strong> [kg] (varsa)</li>
      <li><strong>Montaj:</strong> [Kolay montaj/Montajlı gönderim]</li>
      <li><strong>Stil:</strong> [Modern/Klasik/Minimalist/Rustik]</li>
    </ul>
    
    <h4>📐 Boyut Bilgisi</h4>
    <p>En: [cm] | Boy: [cm] | Yükseklik: [cm]</p>
    
    <h4>&#128230;#128230; Paket İçeriği</h4>
    <p>Ürün + Montaj aparatları + Kurulum kılavuzu</p>
    
    <h4>&#128274;#128274; Güvence</h4>
    <ul>
      <li>&#10003;#10003; %100 Orijinal Ürün</li>
      <li>&#10003;#10003; [X] Yıl Garanti</li>
      <li>&#10003;#10003; Sigortalı Kargo</li>
      <li>&#10003;#10003; Kolay İade</li>
    </ul>
  </div>"",
  
  ""shortDescription"": ""{marka} {urunAdi} | [Malzeme] | [Boyutlar] | [Stil] | Garantili | Hızlı kargo"",
  
  ""features"": [
    ""Malzeme: [MDF/Ahşap/Metal]"",
    ""Boyutlar: [En x Boy x Yükseklik]"",
    ""Renk: [Renk]"",
    ""Stil: [Modern/Klasik]"",
    ""Montaj: [Kolay/Montajlı]"",
    ""Garanti: [X] Yıl"",
    ""Menşei: Türkiye""
  ],
  
  ""careInstructions"": ""<div><h4>🪑 Mobilya Bakımı</h4><ul><li>Nemli bezle silin</li><li>Aşındırıcı deterjan kullanmayın</li><li>Direkt güneşten koruyun</li><li>Ağır yük koymayın</li><li>Düzenli olarak vidalarını kontrol edin</li></ul></div>"",
  
  ""seoTitle"": ""{marka} {urunAdi} | [Stil] Mobilya | Garantili | Hızlı Kargo"",
  
  ""metaDescription"": ""{marka} {urunAdi} ✓[Malzeme] ✓[Boyutlar] ✓Garantili ✓Hızlı Kargo. Evinize şıklık katın!"",
  
  ""keywords"": ""{marka}, mobilya, ev dekorasyon, [ürün tipi], modern, şık, garantili, hızlı kargo""
}}

SADECE JSON döndür!"
    End Function
    
End Class
