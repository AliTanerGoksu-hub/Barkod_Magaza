' ============================================================================
' PARAMETRİK AI SİSTEMİ - KULLANIM TALİMATLARI OLUŞTURMA
' ============================================================================
' Müşteriler AI kullanmak isterse kullanır, istemezse kullanmaz
' Kategori bazlı özelleştirme ve maliyet kontrolü
' ============================================================================

Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class AIParametricSystem
    
    Private emergentApiKey As String = ""
    Private aiSettings As Dictionary(Of String, Object)
    Private ReadOnly logFilePath As String = "AI_Parametric.log"
    
    ''' <summary>
    ''' Constructor - AI ayarlarını yükle
    ''' </summary>
    Public Sub New()
        Try
            LoadAISettings()
            LogParam("SUCCESS", "AIParametricSystem", "Parametrik AI sistemi başlatıldı")
        Catch ex As Exception
            LogParam("ERROR", "AIParametricSystem", $"Başlatma hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Veritabanından AI ayarlarını yükle
    ''' </summary>
    Private Sub LoadAISettings()
        Try
            aiSettings = New Dictionary(Of String, Object)
            
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                Dim cmd As New OleDb.OleDbCommand(
                    "SELECT * FROM tbParamAI WHERE nAIParamID = 1", conn)
                
                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    aiSettings("bAIKullan") = Convert.ToBoolean(reader("bAIKullan"))
                    aiSettings("bBaslikOlustur") = Convert.ToBoolean(reader("bBaslikOlustur"))
                    aiSettings("bAciklamaOlustur") = Convert.ToBoolean(reader("bAciklamaOlustur"))
                    aiSettings("bTalimatOlustur") = Convert.ToBoolean(reader("bTalimatOlustur"))
                    aiSettings("bGorselBul") = Convert.ToBoolean(reader("bGorselBul"))
                    aiSettings("bGorselDogrula") = Convert.ToBoolean(reader("bGorselDogrula"))
                    aiSettings("bKategoriOner") = Convert.ToBoolean(reader("bKategoriOner"))
                    aiSettings("bFiyatOptimize") = Convert.ToBoolean(reader("bFiyatOptimize"))
                    aiSettings("nGunlukMaxIstek") = Convert.ToInt32(reader("nGunlukMaxIstek"))
                    aiSettings("nAylikBudget") = Convert.ToDecimal(reader("nAylikBudget"))
                    aiSettings("nToplamHarcama") = Convert.ToDecimal(reader("nToplamHarcama"))
                    
                    emergentApiKey = If(reader("sEmergentKey") IsNot DBNull.Value, 
                                       reader("sEmergentKey").ToString(), "")
                Else
                    ' Default ayarlar
                    SetDefaultSettings()
                End If
                
                reader.Close()
            End Using
            
            LogParam("SUCCESS", "LoadAISettings", "AI ayarları yüklendi")
            
        Catch ex As Exception
            LogParam("ERROR", "LoadAISettings", $"Ayar yükleme hatası: {ex.Message}")
            SetDefaultSettings()
        End Try
    End Sub
    
    ''' <summary>
    ''' Default ayarları set et
    ''' </summary>
    Private Sub SetDefaultSettings()
        aiSettings = New Dictionary(Of String, Object) From {
            {"bAIKullan", False},
            {"bBaslikOlustur", False},
            {"bAciklamaOlustur", False},
            {"bTalimatOlustur", False},
            {"bGorselBul", False},
            {"bGorselDogrula", False},
            {"bKategoriOner", False},
            {"bFiyatOptimize", False},
            {"nGunlukMaxIstek", 100},
            {"nAylikBudget", 500.0},
            {"nToplamHarcama", 0.0}
        }
    End Sub
    
    ''' <summary>
    ''' AI kullanılabilir mi kontrol et
    ''' </summary>
    Public Function IsAIEnabled() As Boolean
        Return Convert.ToBoolean(aiSettings("bAIKullan"))
    End Function
    
    ''' <summary>
    ''' Belirli özellik aktif mi kontrol et
    ''' </summary>
    Public Function IsFeatureEnabled(featureName As String) As Boolean
        If Not IsAIEnabled() Then Return False
        
        If aiSettings.ContainsKey(featureName) Then
            Return Convert.ToBoolean(aiSettings(featureName))
        End If
        
        Return False
    End Function
    
    ''' <summary>
    ''' Günlük limit kontrolü
    ''' </summary>
    Public Function CheckDailyLimit() As Boolean
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                Dim cmd As New OleDb.OleDbCommand(
                    "SELECT COUNT(*) FROM tbAIIslemLog " &
                    "WHERE CAST(dteTarih AS DATE) = CAST(GETDATE() AS DATE)", conn)
                
                Dim todayCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Dim maxLimit As Integer = Convert.ToInt32(aiSettings("nGunlukMaxIstek"))
                
                If todayCount >= maxLimit Then
                    LogParam("WARNING", "CheckDailyLimit", 
                            $"Günlük limit aşıldı: {todayCount}/{maxLimit}")
                    Return False
                End If
                
                Return True
            End Using
            
        Catch ex As Exception
            LogParam("ERROR", "CheckDailyLimit", $"Hata: {ex.Message}")
            Return True ' Hata durumunda izin ver
        End Try
    End Function
    
    ''' <summary>
    ''' Aylık bütçe kontrolü
    ''' </summary>
    Public Function CheckMonthlyBudget() As Boolean
        Try
            Dim toplamHarcama As Decimal = Convert.ToDecimal(aiSettings("nToplamHarcama"))
            Dim aylikBudget As Decimal = Convert.ToDecimal(aiSettings("nAylikBudget"))
            
            If toplamHarcama >= aylikBudget Then
                LogParam("WARNING", "CheckMonthlyBudget", 
                        $"Aylık bütçe aşıldı: {toplamHarcama}/{aylikBudget} TL")
                Return False
            End If
            
            Return True
            
        Catch ex As Exception
            LogParam("ERROR", "CheckMonthlyBudget", $"Hata: {ex.Message}")
            Return True
        End Try
    End Function
    
    ''' <summary>
    ''' Kategori için AI ayarlarını kontrol et
    ''' </summary>
    Public Function GetCategoryAISettings(kategoriID As Integer) As Dictionary(Of String, Object)
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                Dim cmd As New OleDb.OleDbCommand(
                    "SELECT * FROM tbParamAIKategori WHERE nKategoriID = ?", conn)
                cmd.Parameters.AddWithValue("?", kategoriID)
                
                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    Dim categorySettings As New Dictionary(Of String, Object) From {
                        {"bAIKullan", Convert.ToBoolean(reader("bAIKullan"))},
                        {"bBaslikOlustur", Convert.ToBoolean(reader("bBaslikOlustur"))},
                        {"bAciklamaOlustur", Convert.ToBoolean(reader("bAciklamaOlustur"))},
                        {"bTalimatOlustur", Convert.ToBoolean(reader("bTalimatOlustur"))},
                        {"sTalimatTuru", reader("sTalimatTuru").ToString()},
                        {"sOzelPrompt", If(reader("sOzelPrompt") IsNot DBNull.Value, 
                                          reader("sOzelPrompt").ToString(), "")}
                    }
                    
                    reader.Close()
                    Return categorySettings
                Else
                    reader.Close()
                    ' Kategori ayarı yoksa genel ayarları kullan
                    Return Nothing
                End If
            End Using
            
        Catch ex As Exception
            LogParam("ERROR", "GetCategoryAISettings", $"Hata: {ex.Message}")
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Kullanım talimatları oluştur (Kategori bazlı)
    ''' </summary>
    Public Function GenerateUsageInstructions(productData As Dictionary(Of String, Object)) As String
        Try
            ' AI kontrolü
            If Not IsFeatureEnabled("bTalimatOlustur") Then
                LogParam("INFO", "GenerateUsageInstructions", "AI talimat oluşturma kapalı")
                Return GetDefaultInstructions()
            End If
            
            ' Limit kontrolü
            If Not CheckDailyLimit() OrElse Not CheckMonthlyBudget() Then
                LogParam("WARNING", "GenerateUsageInstructions", "AI limit/bütçe aşıldı, default kullanılıyor")
                Return GetDefaultInstructions()
            End If
            
            ' Kategori belirle
            Dim kategoriID As Integer = Convert.ToInt32(productData("nKategoriID"))
            Dim kategoriAdi As String = productData("sKategoriAdi").ToString().ToLower()
            
            ' Kategori ayarlarını kontrol et
            Dim categorySettings As Dictionary(Of String, Object) = GetCategoryAISettings(kategoriID)
            
            If categorySettings IsNot Nothing AndAlso 
               Not Convert.ToBoolean(categorySettings("bTalimatOlustur")) Then
                LogParam("INFO", "GenerateUsageInstructions", 
                        $"Kategori {kategoriAdi} için AI talimat kapalı")
                Return GetDefaultInstructions()
            End If
            
            ' Kategori türüne göre talimat oluştur
            Dim instructions As String = ""
            Dim talimatTuru As String = If(categorySettings IsNot Nothing, 
                                          categorySettings("sTalimatTuru").ToString(), 
                                          DetermineCategoryType(kategoriAdi))
            
            LogParam("INFO", "GenerateUsageInstructions", 
                    $"Talimat türü: {talimatTuru}, Ürün: {productData("sStokAdi")}")
            
            Select Case talimatTuru.ToLower()
                Case "tekstil"
                    instructions = GenerateTextileInstructions(productData)
                    
                Case "ayakkabı", "ayakkabi"
                    instructions = GenerateShoeInstructions(productData)
                    
                Case "züccaciye", "zuccaciye", "cam"
                    instructions = GenerateGlasswareInstructions(productData)
                    
                Case "elektronik"
                    instructions = GenerateElectronicsInstructions(productData)
                    
                Case Else
                    instructions = GenerateGenericInstructions(productData)
            End Select
            
            ' Maliyet kaydet
            Dim cost As Decimal = 0.10D ' Talimat oluşturma maliyeti
            LogAIOperation(productData("nStokID"), productData("sBarkod").ToString(), 
                          "Talimat", "GPT-4o", 180, 250, cost, True, "")
            
            Return instructions
            
        Catch ex As Exception
            LogParam("ERROR", "GenerateUsageInstructions", $"Hata: {ex.Message}")
            Return GetDefaultInstructions()
        End Try
    End Function
    
    ''' <summary>
    ''' Kategori türünü otomatik belirle
    ''' </summary>
    Private Function DetermineCategoryType(kategoriAdi As String) As String
        kategoriAdi = kategoriAdi.ToLower()
        
        If kategoriAdi.Contains("tekstil") OrElse kategoriAdi.Contains("giyim") OrElse 
           kategoriAdi.Contains("tişört") OrElse kategoriAdi.Contains("pantolon") Then
            Return "Tekstil"
        ElseIf kategoriAdi.Contains("ayakkabı") OrElse kategoriAdi.Contains("bot") OrElse 
               kategoriAdi.Contains("spor ayakkabı") Then
            Return "Ayakkabı"
        ElseIf kategoriAdi.Contains("züccaciye") OrElse kategoriAdi.Contains("cam") OrElse 
               kategoriAdi.Contains("porselen") OrElse kategoriAdi.Contains("tabak") Then
            Return "Züccaciye"
        ElseIf kategoriAdi.Contains("elektronik") OrElse kategoriAdi.Contains("telefon") OrElse 
               kategoriAdi.Contains("bilgisayar") Then
            Return "Elektronik"
        Else
            Return "Genel"
        End If
    End Function
    
    ''' <summary>
    ''' Tekstil talimatları
    ''' </summary>
    Private Function GenerateTextileInstructions(productData As Dictionary(Of String, Object)) As String
        Try
            Dim prompt As String = $"
Sen bir tekstil ürünleri uzmanısın. Aşağıdaki ürün için detaylı kullanım ve yıkama talimatları oluştur.

Ürün: {productData("sStokAdi")}
Malzeme: {If(productData.ContainsKey("sMalzeme"), productData("sMalzeme"), "Pamuk karışımlı")}
Renk: {productData("sRenk")}

HTML formatında şu başlıkları kullan:

📋 Genel Bilgiler
🧺 Yıkama Talimatları (sıcaklık, deterjan, renk ayrımı)
👔 Kurutma (asma şekli, güneş ışığı)
🔥 Ütü (sıcaklık)
⚠️ Dikkat Edilecekler
🔄 Bakım Önerileri

Kısa, net ve kullanıcı dostu olsun (200-250 kelime).
SADECE HTML TALİMATLARI DÖNDÜR (ul, li, strong kullan)!"

            Return CallOpenAIForInstructions(prompt, 400)
            
        Catch ex As Exception
            LogParam("ERROR", "GenerateTextileInstructions", $"Hata: {ex.Message}")
            Return GetDefaultTextileInstructions()
        End Try
    End Function
    
    ''' <summary>
    ''' Ayakkabı talimatları
    ''' </summary>
    Private Function GenerateShoeInstructions(productData As Dictionary(Of String, Object)) As String
        Try
            Dim prompt As String = $"
Sen bir ayakkabı bakım uzmanısın. Aşağıdaki ayakkabı için kullanım ve bakım talimatları oluştur.

Ürün: {productData("sStokAdi")}
Malzeme: {If(productData.ContainsKey("sMalzeme"), productData("sMalzeme"), "Deri/Kumaş")}

HTML formatında şu başlıkları kullan:

👟 İlk Kullanım
🧼 Temizlik (malzeme bazlı)
💧 Kurulama
🛡️ Koruma (su geçirmezlik)
📦 Saklama
⚠️ Dikkat Edilecekler

Kısa ve pratik (200-250 kelime).
SADECE HTML TALİMATLARI DÖNDÜR!"

            Return CallOpenAIForInstructions(prompt, 400)
            
        Catch ex As Exception
            LogParam("ERROR", "GenerateShoeInstructions", $"Hata: {ex.Message}")
            Return GetDefaultShoeInstructions()
        End Try
    End Function
    
    ''' <summary>
    ''' Züccaciye talimatları
    ''' </summary>
    Private Function GenerateGlasswareInstructions(productData As Dictionary(Of String, Object)) As String
        Try
            Dim prompt As String = $"
Sen bir ev eşyaları uzmanısın. Aşağıdaki züccaciye/cam ürün için kullanım ve bakım talimatları oluştur.

Ürün: {productData("sStokAdi")}
Malzeme: {If(productData.ContainsKey("sMalzeme"), productData("sMalzeme"), "Cam/Porselen")}

HTML formatında şu başlıkları kullan:

🍽️ Kullanım
🧽 Temizlik
  - Bulaşık Makinesinde Yıkanabilir mi? (✅/❌)
  - Eğer evet: Hangi program, kaç derece?
  - El ile yıkama önerisi
💦 Kurulama
🔥 Sıcaklık (fırın/mikrodalga)
⚠️ Dikkat Edilecekler (kırılma, ani sıcaklık değişimi)
📦 Saklama

Net ve güvenlik odaklı (200-250 kelime).
SADECE HTML TALİMATLARI DÖNDÜR!"

            Return CallOpenAIForInstructions(prompt, 400)
            
        Catch ex As Exception
            LogParam("ERROR", "GenerateGlasswareInstructions", $"Hata: {ex.Message}")
            Return GetDefaultGlasswareInstructions()
        End Try
    End Function
    
    ''' <summary>
    ''' Elektronik talimatları
    ''' </summary>
    Private Function GenerateElectronicsInstructions(productData As Dictionary(Of String, Object)) As String
        Try
            Dim prompt As String = $"
Sen bir elektronik ürünler uzmanısın. Aşağıdaki ürün için güvenli kullanım ve bakım talimatları oluştur.

Ürün: {productData("sStokAdi")}

HTML formatında şu başlıkları kullan:

🔌 İlk Kullanım
⚡ Güvenli Kullanım (elektrik, su/nem)
🧹 Temizlik ve Bakım
🔋 Pil/Şarj Yönetimi
🌡️ Çevre Koşulları
⚠️ Güvenlik Uyarıları
♻️ Çevre Koruma (WEEE)

Güvenlik odaklı ve net (250-300 kelime).
SADECE HTML TALİMATLARI DÖNDÜR!"

            Return CallOpenAIForInstructions(prompt, 500)
            
        Catch ex As Exception
            LogParam("ERROR", "GenerateElectronicsInstructions", $"Hata: {ex.Message}")
            Return GetDefaultElectronicsInstructions()
        End Try
    End Function
    
    ''' <summary>
    ''' Genel talimatlar (diğer kategoriler için)
    ''' </summary>
    Private Function GenerateGenericInstructions(productData As Dictionary(Of String, Object)) As String
        Try
            Dim prompt As String = $"
Aşağıdaki ürün için genel kullanım ve bakım talimatları oluştur.

Ürün: {productData("sStokAdi")}
Kategori: {productData("sKategoriAdi")}

HTML formatında şu başlıkları kullan:

📋 Kullanım
🧽 Temizlik ve Bakım
⚠️ Dikkat Edilecekler
📦 Saklama
🔄 Bakım Önerileri

Kısa ve net (150-200 kelime).
SADECE HTML TALİMATLARI DÖNDÜR!"

            Return CallOpenAIForInstructions(prompt, 300)
            
        Catch ex As Exception
            LogParam("ERROR", "GenerateGenericInstructions", $"Hata: {ex.Message}")
            Return GetDefaultInstructions()
        End Try
    End Function
    
    ''' <summary>
    ''' OpenAI API çağrısı (talimatlar için)
    ''' </summary>
    Private Function CallOpenAIForInstructions(prompt As String, maxTokens As Integer) As String
        Try
            If String.IsNullOrEmpty(emergentApiKey) Then
                LogParam("ERROR", "CallOpenAIForInstructions", "Emergent API key eksik!")
                Return GetDefaultInstructions()
            End If
            
            Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
            
            Dim requestData As New Dictionary(Of String, Object) From {
                {"model", "gpt-4o-2024-08-06"},
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
                client.Headers.Add("Authorization", $"Bearer {emergentApiKey}")
                
                Dim response As String = client.UploadString(apiUrl, "POST", jsonRequest)
                Dim jsonResponse As JObject = JObject.Parse(response)
                
                Dim instructions As String = jsonResponse("choices")(0)("message")("content").ToString()
                
                LogParam("SUCCESS", "CallOpenAIForInstructions", "Talimatlar oluşturuldu")
                Return instructions.Trim()
            End Using
            
        Catch ex As Exception
            LogParam("ERROR", "CallOpenAIForInstructions", $"API hatası: {ex.Message}")
            Return GetDefaultInstructions()
        End Try
    End Function
    
    ''' <summary>
    ''' AI işlemini logla ve maliyeti kaydet
    ''' </summary>
    Private Sub LogAIOperation(stokID As Object, barcode As String, islemTuru As String, 
                               aiModel As String, inputToken As Integer, outputToken As Integer,
                               maliyet As Decimal, basarili As Boolean, hataMesaji As String)
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' İşlemi logla
                Dim cmd As New OleDb.OleDbCommand(
                    "INSERT INTO tbAIIslemLog (nStokID, sBarkod, sIslemTuru, sAIModel, " &
                    "nInputToken, nOutputToken, nMaliyet, bBasarili, sHataMesaji, dteTarih) " &
                    "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, GETDATE())", conn)
                
                cmd.Parameters.AddWithValue("?", If(stokID IsNot Nothing, stokID, DBNull.Value))
                cmd.Parameters.AddWithValue("?", barcode)
                cmd.Parameters.AddWithValue("?", islemTuru)
                cmd.Parameters.AddWithValue("?", aiModel)
                cmd.Parameters.AddWithValue("?", inputToken)
                cmd.Parameters.AddWithValue("?", outputToken)
                cmd.Parameters.AddWithValue("?", maliyet)
                cmd.Parameters.AddWithValue("?", If(basarili, 1, 0))
                cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(hataMesaji), DBNull.Value, hataMesaji))
                
                cmd.ExecuteNonQuery()
                
                ' Toplam harcamayı güncelle
                Dim updateCmd As New OleDb.OleDbCommand(
                    "UPDATE tbParamAI SET nToplamHarcama = nToplamHarcama + ? WHERE nAIParamID = 1", conn)
                updateCmd.Parameters.AddWithValue("?", maliyet)
                updateCmd.ExecuteNonQuery()
                
                LogParam("SUCCESS", "LogAIOperation", $"İşlem loglandı: {islemTuru}, Maliyet: {maliyet} TL")
            End Using
            
        Catch ex As Exception
            LogParam("ERROR", "LogAIOperation", $"Log kaydetme hatası: {ex.Message}")
        End Try
    End Sub
    
    ' ========== DEFAULT ŞABLONLAR (AI kullanılmazsa) ==========
    
    Private Function GetDefaultInstructions() As String
        Return "<h3>Kullanım ve Bakım Talimatları</h3>
<ul>
<li><strong>Kullanım:</strong> Ürünü kullanım amacına uygun şekilde kullanınız</li>
<li><strong>Temizlik:</strong> Düzenli olarak temizleyiniz</li>
<li><strong>Saklama:</strong> Kuru ve serin ortamda saklayınız</li>
<li><strong>Uyarı:</strong> Çocukların erişemeyeceği yerlerde saklayınız</li>
</ul>"
    End Function
    
    Private Function GetDefaultTextileInstructions() As String
        Return "<h3>Tekstil Kullanım ve Bakım Talimatları</h3>
<ul>
<li><strong>Yıkama:</strong> 30°C'de makine yıkama</li>
<li><strong>Kurutma:</strong> Doğal kurutma önerilir</li>
<li><strong>Ütü:</strong> Orta sıcaklıkta ütülenebilir</li>
<li><strong>Ağartma:</strong> Ağartıcı kullanmayınız</li>
<li><strong>İlk Yıkama:</strong> Ayrı yıkayınız</li>
</ul>"
    End Function
    
    Private Function GetDefaultShoeInstructions() As String
        Return "<h3>Ayakkabı Kullanım ve Bakım Talimatları</h3>
<ul>
<li><strong>Temizlik:</strong> Nemli bez ile siliniz</li>
<li><strong>Kurutma:</strong> Oda sıcaklığında kurutunuz</li>
<li><strong>Koruma:</strong> Su geçirmezlik spreyi kullanılabilir</li>
<li><strong>Saklama:</strong> Havadar ortamda saklayınız</li>
</ul>"
    End Function
    
    Private Function GetDefaultGlasswareInstructions() As String
        Return "<h3>Züccaciye Kullanım ve Bakım Talimatları</h3>
<ul>
<li><strong>Yıkama:</strong> Bulaşık makinesinde yıkanabilir</li>
<li><strong>Sıcaklık:</strong> Ani sıcaklık değişiminden kaçınınız</li>
<li><strong>Temizlik:</strong> Yumuşak sünger kullanınız</li>
<li><strong>Saklama:</strong> Dik konumda saklayınız</li>
</ul>"
    End Function
    
    Private Function GetDefaultElectronicsInstructions() As String
        Return "<h3>Elektronik Ürün Kullanım ve Bakım Talimatları</h3>
<ul>
<li><strong>Güvenlik:</strong> Elektrik çarpmasına karşı dikkatli olunuz</li>
<li><strong>Temizlik:</strong> Nemli bezle siliniz, suya sokmayınız</li>
<li><strong>Şarj:</strong> Orijinal şarj cihazı kullanınız</li>
<li><strong>Çevre:</strong> Eski ürünü geri dönüşüme veriniz</li>
</ul>"
    End Function
    
    ''' <summary>
    ''' Log fonksiyonu
    ''' </summary>
    Private Sub LogParam(level As String, functionName As String, message As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logMessage As String = $"[{timestamp}] [{level}] [{functionName}] {message}"
            
            Console.WriteLine(logMessage)
            File.AppendAllText(logFilePath, logMessage & vbCrLf)
            
        Catch
            ' Log hatası olsa bile devam et
        End Try
    End Sub
    
End Class
