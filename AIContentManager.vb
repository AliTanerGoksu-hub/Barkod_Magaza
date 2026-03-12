' ============================================================================
' AI İÇERİK YÖNETİCİSİ - ANA MODÜL
' ============================================================================
' Tüm AI işlemlerini yöneten ana class
' Kredi kontrolü, içerik oluşturma, veritabanı kaydetme
' ============================================================================

Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks

Public Class AIContentManager
    
    ' Bağlantı string (global değişkenden alınacak)
    Private connectionString As String = connection
    
    ' AI Servisi
    Private aiService As AIService
    
    ' Log
    Private ReadOnly logFile As String = "AI_Content_Manager.log"
    
    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        Try
            ' Sadece AI servisini başlat
            aiService = New AIService()
            
            LogAI("SUCCESS", "AIContentManager", "AI Content Manager başlatıldı")
        Catch ex As Exception
            LogAI("ERROR", "AIContentManager", $"Başlatma hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Tek ürün için tam AI işlemi
    ''' options parametresi ile sadece seçili içerikler oluşturulur
    ''' </summary>
    Public Async Function ProcessProduct(nStokID As Integer, musteriID As Integer, Optional options As Dictionary(Of String, Boolean) = Nothing) As Task(Of Dictionary(Of String, Object))
        Try
            LogAI("INFO", "ProcessProduct", $"Ürün işleniyor: StokID={nStokID}")
            
            ' Varsayılan olarak tüm seçenekler açık
            If options Is Nothing Then
                options = New Dictionary(Of String, Boolean) From {
                    {"baslik", True},
                    {"kisaAciklama", True},
                    {"uzunAciklama", True},
                    {"ozellikler", True},
                    {"talimat", True},
                    {"seoBilgisi", True}
                }
            End If
            
            Dim result As New Dictionary(Of String, Object) From {
                {"success", False},
                {"stokID", nStokID},
                {"steps", New List(Of String)}
            }
            
            ' 1. Ürün bilgilerini al
            Dim productData As Dictionary(Of String, Object) = GetProductData(nStokID)
            If productData Is Nothing Then
                result("message") = "Ürün bulunamadı!"
                Return result
            End If
            
            Dim steps As List(Of String) = CType(result("steps"), List(Of String))
            Dim totalCost As Decimal = 0D
            
            ' 2. KAPSAMLI İÇERİK OLUŞTUR (TEK API ÇAĞRISI)
            ' Yeni sistem: Tüm içerikleri tek seferde oluşturur, sonra seçilenleri filtreler
            Try
                steps.Add("⏳ Kapsamlı AI içerik oluşturuluyor...")
                
                Dim completeContent As Dictionary(Of String, String) = aiService.GenerateCompleteContent(productData)
                
                If completeContent("success") = "true" Then
                    ' Uzun Açıklama (options: uzunAciklama)
                    If options.ContainsKey("uzunAciklama") AndAlso options("uzunAciklama") Then
                        If completeContent.ContainsKey("description") AndAlso Not String.IsNullOrEmpty(completeContent("description")) Then
                            productData("ai_aciklama") = completeContent("description")
                            steps.Add("✓ Detaylı açıklama oluşturuldu")
                        End If
                    End If
                    
                    ' Kısa açıklama (options: kisaAciklama)
                    If options.ContainsKey("kisaAciklama") AndAlso options("kisaAciklama") Then
                        If completeContent.ContainsKey("shortDescription") AndAlso Not String.IsNullOrEmpty(completeContent("shortDescription")) Then
                            productData("ai_kisa_aciklama") = completeContent("shortDescription")
                            steps.Add("✓ Kısa açıklama oluşturuldu")
                        End If
                    End If
                    
                    ' Özellikler HTML (options: ozellikler)
                    If options.ContainsKey("ozellikler") AndAlso options("ozellikler") Then
                        If completeContent.ContainsKey("featuresHtml") AndAlso Not String.IsNullOrEmpty(completeContent("featuresHtml")) Then
                            productData("ai_ozellikler") = completeContent("featuresHtml")
                            steps.Add("✓ Ürün özellikleri oluşturuldu")
                        End If
                    End If
                        
                    ' Bakım talimatları (options: talimat)
                    If options.ContainsKey("talimat") AndAlso options("talimat") Then
                        If completeContent.ContainsKey("careInstructions") AndAlso Not String.IsNullOrEmpty(completeContent("careInstructions")) Then
                            productData("ai_talimat") = completeContent("careInstructions")
                            steps.Add("✓ Bakım talimatları oluşturuldu")
                        End If
                    End If
                        
                    ' SEO Başlık (options: baslik)
                    If options.ContainsKey("baslik") AndAlso options("baslik") Then
                        If completeContent.ContainsKey("seoTitle") AndAlso Not String.IsNullOrEmpty(completeContent("seoTitle")) Then
                            productData("ai_baslik") = completeContent("seoTitle")
                            steps.Add("✓ SEO başlık oluşturuldu")
                        End If
                    End If
                        
                    ' Meta Description ve Keywords (options: seoBilgisi)
                    If options.ContainsKey("seoBilgisi") AndAlso options("seoBilgisi") Then
                        If completeContent.ContainsKey("metaDescription") AndAlso Not String.IsNullOrEmpty(completeContent("metaDescription")) Then
                            productData("ai_meta") = completeContent("metaDescription")
                            steps.Add("✓ Meta açıklama oluşturuldu")
                        End If
                        
                        If completeContent.ContainsKey("keywords") AndAlso Not String.IsNullOrEmpty(completeContent("keywords")) Then
                            productData("ai_keywords") = completeContent("keywords")
                            steps.Add("✓ Anahtar kelimeler oluşturuldu")
                        End If
                    End If
                    
                    ' Yeni alanlar: Yıkama, Bakım, Güvenlik (ayrı checkbox'lar ile kontrol edilir)
                    If options.ContainsKey("yikamaTalimati") AndAlso options("yikamaTalimati") Then
                        If completeContent.ContainsKey("yikamaTalimati") AndAlso Not String.IsNullOrEmpty(completeContent("yikamaTalimati")) Then
                            productData("ai_yikama") = completeContent("yikamaTalimati")
                            steps.Add("✓ Yıkama talimatı oluşturuldu")
                        End If
                    End If
                    
                    If options.ContainsKey("bakimTalimati") AndAlso options("bakimTalimati") Then
                        If completeContent.ContainsKey("bakimTalimati") AndAlso Not String.IsNullOrEmpty(completeContent("bakimTalimati")) Then
                            productData("ai_bakim") = completeContent("bakimTalimati")
                            steps.Add("✓ Bakım talimatı oluşturuldu")
                        End If
                    End If
                    
                    If options.ContainsKey("guvenlikUyari") AndAlso options("guvenlikUyari") Then
                        If completeContent.ContainsKey("guvenlikUyari") AndAlso Not String.IsNullOrEmpty(completeContent("guvenlikUyari")) Then
                            productData("ai_guvenlik") = completeContent("guvenlikUyari")
                            steps.Add("✓ Güvenlik uyarısı oluşturuldu")
                        End If
                    End If
                        
                    ' İçerik puanı hesapla
                    Dim contentScore As Integer = aiService.CalculateContentScore(completeContent)
                    productData("ai_puan") = contentScore
                    steps.Add($"📊 İçerik Puanı: {contentScore}/100")
                        
                        totalCost += 0.35D ' Tek çağrı maliyeti
                    Else
                        steps.Add("✗ Kapsamlı içerik hatası: " & If(completeContent.ContainsKey("error"), completeContent("error"), "Bilinmeyen hata"))
                        result("message") = If(completeContent.ContainsKey("error"), completeContent("error"), "AI içerik oluşturulamadı")
                        Return result
                    End If
                    
                Catch ex As Exception
                    steps.Add("✗ Kapsamlı içerik hatası: " & ex.Message)
                    LogAI("ERROR", "ProcessProduct", $"Kapsamlı içerik hatası: {ex.Message}")
                    result("message") = "AI içerik hatası: " & ex.Message
                    Return result
                End Try
            
            ' 6. BEDEN TABLOSU - frm_AI_TopluIslem'de checkbox ile kontrol edilir
            ' Bu blok kaldırıldı - beden tablosu sadece kullanıcı checkbox'ı işaretlediğinde oluşturulur
            
            ' 7. Veritabanına kaydet
            Try
                Dim saved As Boolean = SaveToDatabase(nStokID, productData, totalCost)
                If saved Then
                    steps.Add("✓ Veritabanına kaydedildi")
                    
                    result("success") = True
                    result("message") = "İşlem başarılı!"
                    result("totalCost") = totalCost
                    
                    LogAI("SUCCESS", "ProcessProduct", $"Ürün başarıyla işlendi: {nStokID}")
                Else
                    steps.Add("✗ Veritabanı kayıt hatası")
                    result("message") = "Veritabanı kayıt hatası!"
                End If
            Catch ex As Exception
                steps.Add("✗ Kayıt hatası: " & ex.Message)
                result("message") = "Kayıt hatası: " & ex.Message
            End Try
            
            Return result
            
        Catch ex As Exception
            LogAI("ERROR", "ProcessProduct", $"Genel hata: {ex.Message}")
            Return New Dictionary(Of String, Object) From {
                {"success", False},
                {"message", "Beklenmedik hata: " & ex.Message}
            }
        End Try
    End Function
    
    ''' <summary>
    ''' Toplu ürün işleme
    ''' </summary>
    Public Async Function ProcessBulkProducts(musteriID As Integer, maxCount As Integer) As Task(Of Dictionary(Of String, Object))
        Try
            LogAI("INFO", "ProcessBulkProducts", $"Toplu işlem başlatıldı: Max={maxCount}")
            
            Dim result As New Dictionary(Of String, Object) From {
                {"success", False},
                {"processed", 0},
                {"successful", 0},
                {"failed", 0},
                {"details", New List(Of Dictionary(Of String, Object))}
            }
            
            ' AI içeriği olmayan ürünleri al
            Dim urunler As List(Of Integer) = GetProductsWithoutAI(maxCount)
            
            If urunler.Count = 0 Then
                result("message") = "İşlenecek ürün bulunamadı!"
                Return result
            End If
            
            Dim details As List(Of Dictionary(Of String, Object)) = CType(result("details"), List(Of Dictionary(Of String, Object)))
            
            For Each stokID As Integer In urunler
                Try
                    Dim productResult As Dictionary(Of String, Object) = Await ProcessProduct(stokID, musteriID)
                    
                    result("processed") = CInt(result("processed")) + 1
                    
                    If Convert.ToBoolean(productResult("success")) Then
                        result("successful") = CInt(result("successful")) + 1
                    Else
                        result("failed") = CInt(result("failed")) + 1
                    End If
                    
                    details.Add(productResult)
                    
                    ' Rate limiting (1 saniye bekle)
                    Threading.Thread.Sleep(1000)
                    
                Catch ex As Exception
                    result("failed") = CInt(result("failed")) + 1
                    LogAI("ERROR", "ProcessBulkProducts", $"Ürün {stokID} hatası: {ex.Message}")
                End Try
            Next
            
            result("success") = True
            result("message") = $"{result("successful")} ürün başarıyla işlendi, {result("failed")} hata."
            
            LogAI("SUCCESS", "ProcessBulkProducts", $"Toplu işlem tamamlandı: {result("successful")}/{result("processed")}")
            
            Return result
            
        Catch ex As Exception
            LogAI("ERROR", "ProcessBulkProducts", $"Genel hata: {ex.Message}")
            Return New Dictionary(Of String, Object) From {
                {"success", False},
                {"message", "Toplu işlem hatası: " & ex.Message}
            }
        End Try
    End Function
    
    ''' <summary>
    ''' Ürün verilerini al
    ''' </summary>
    Private Function GetProductData(nStokID As Integer) As Dictionary(Of String, Object)
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                ' Parametrik sınıf eşleştirmelerini al (tbSistemAyar'dan)
                Dim markaField As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_MARKA", "sSinifKodu3")
                Dim kat1Field As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT1", "sSinifKodu4")
                Dim kat2Field As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT2", "sSinifKodu5")
                
                ' DEBUG: Hangi alanlar kullanılıyor
                LogAI("DEBUG", "GetProductData", $"Marka Field: {markaField}, Kat1 Field: {kat1Field}, Kat2 Field: {kat2Field}")
                
                ' Dinamik SQL oluştur - Sınıf koduna göre doğru tabloyu seç
                Dim markaSql As String = GetSinifSqlPart(markaField, "sSinifMarka")
                Dim kat1Sql As String = GetSinifSqlPart(kat1Field, "sKategori1")
                Dim kat2Sql As String = GetSinifSqlPart(kat2Field, "sKategori2")
                
                ' DEBUG: SQL parçaları
                LogAI("DEBUG", "GetProductData", $"Marka SQL: {markaSql}")
                LogAI("DEBUG", "GetProductData", $"Kat1 SQL: {kat1Sql}")
                LogAI("DEBUG", "GetProductData", $"Kat2 SQL: {kat2Sql}")
                
                Dim cmd As New OleDbCommand(
                    $"SELECT T1.*, {markaSql}, {kat1Sql}, {kat2Sql} " &
                    "FROM tbStok AS T1 " &
                    "LEFT JOIN tbStokSinifi AS T2 ON T2.nStokID = T1.nStokID " &
                    "WHERE T1.nStokID = ?", conn)
                cmd.Parameters.AddWithValue("?", nStokID)
                
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    Dim data As New Dictionary(Of String, Object)
                    
                    For i As Integer = 0 To reader.FieldCount - 1
                        Dim fieldName As String = reader.GetName(i)
                        Dim fieldValue As Object = If(reader.IsDBNull(i), "", reader.GetValue(i))
                        data(fieldName) = fieldValue
                    Next
                    
                    ' Ürün adı
                    Dim urunAdi As String = If(data.ContainsKey("sAciklama"), data("sAciklama").ToString(), "")
                    
                    ' Parametrik alanlardan değerleri al
                    Dim sinifMarka As String = If(data.ContainsKey("sSinifMarka"), data("sSinifMarka").ToString().Trim(), "")
                    Dim kat1 As String = If(data.ContainsKey("sKategori1"), data("sKategori1").ToString().Trim(), "")
                    Dim kat2 As String = If(data.ContainsKey("sKategori2"), data("sKategori2").ToString().Trim(), "")
                    
                    ' DEBUG: Okunan değerler
                    LogAI("DEBUG", "GetProductData", $"Ürün: {urunAdi}")
                    LogAI("DEBUG", "GetProductData", $"SinifMarka: {sinifMarka}")
                    LogAI("DEBUG", "GetProductData", $"Kat1: {kat1}")
                    LogAI("DEBUG", "GetProductData", $"Kat2: {kat2}")
                    
                    ' MARKA: Önce ürün adından çıkar, yoksa sınıf alanından al
                    Dim marka As String = ExtractMarkaFromUrunAdi(urunAdi)
                    If String.IsNullOrEmpty(marka) Then
                        marka = sinifMarka
                    End If
                    data("sMarka") = marka
                    
                    ' KATEGORİ: kat1 + kat2 birleştir (örn: "MUTFAK > SAKLAMA KABI")
                    Dim tumKategori As String = kat1
                    If Not String.IsNullOrEmpty(kat2) Then
                        tumKategori = kat1 & " > " & kat2
                    End If
                    data("sKategori") = tumKategori
                    data("sKategoriAdi") = tumKategori
                    
                    ' DEBUG: Sonuç
                    LogAI("DEBUG", "GetProductData", $"Sonuç Marka: {marka}")
                    LogAI("DEBUG", "GetProductData", $"Sonuç Kategori: {tumKategori}")
                    
                    reader.Close()
                    Return data
                End If
                
                reader.Close()
                Return Nothing
            End Using
        Catch ex As Exception
            LogAI("ERROR", "GetProductData", $"Hata: {ex.Message}")
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Sınıf eşleştirme ayarını veritabanından okur
    ''' </summary>
    Private Function GetSinifEslemeAyar(conn As OleDbConnection, ayarKodu As String, varsayilan As String) As String
        Try
            Using cmd As New OleDbCommand($"SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'", conn)
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
    ''' Sınıf alanı için SQL parçası oluşturur
    ''' </summary>
    Private Function GetSinifSqlPart(fieldCode As String, aliasName As String) As String
        If String.IsNullOrEmpty(fieldCode) Then
            Return $"'' AS {aliasName}"
        End If
        
        ' Sınıf alanları için lookup
        If fieldCode.StartsWith("sSinifKodu") Then
            Dim sinifNo As String = fieldCode.Replace("sSinifKodu", "")
            Return $"(SELECT sAciklama FROM tbSSinif{sinifNo} WHERE sSinifKodu = T2.{fieldCode}) AS {aliasName}"
        End If
        
        ' Grup veya diğer doğrudan alanlar
        If fieldCode.StartsWith("sGrup") OrElse fieldCode = "sModel" OrElse fieldCode = "sRenk" Then
            Return $"T1.{fieldCode} AS {aliasName}"
        End If
        
        Return $"'' AS {aliasName}"
    End Function
    
    ''' <summary>
    ''' Ürün adından markayı çıkarır
    ''' </summary>
    Private Function ExtractMarkaFromUrunAdi(urunAdi As String) As String
        If String.IsNullOrEmpty(urunAdi) Then Return ""
        
        ' Bilinen markalar listesi
        Dim bilenenMarkalar() As String = {
            "U.S. Polo Assn", "U.S.POLO ASSN", "US Polo", "US POLO",
            "Tommy Hilfiger", "Tommy", "Calvin Klein", "CK",
            "Lacoste", "Polo", "Ralph Lauren",
            "Nike", "Adidas", "Puma", "Reebok", "New Balance", "Converse", "Vans",
            "Levi's", "Levis", "Lee", "Wrangler", "Mavi", "LCW", "LC Waikiki",
            "Defacto", "DeFacto", "Koton", "Zara", "H&M", "Bershka", "Pull&Bear",
            "Kiğılı", "Damat", "D'S Damat", "Sarar", "Altınyıldız", "Pierre Cardin",
            "Beymen", "Network", "İpekyol", "Twist", "Machka", "Oxxo",
            "Collezione", "Colin's", "Colins", "Jack & Jones", "Only", "Vero Moda",
            "Guess", "Diesel", "Replay", "G-Star", "Superdry",
            "Under Armour", "Skechers", "Fila", "Kappa", "Hummel", "Umbro",
            "The North Face", "Columbia", "Timberland", "Cat", "Caterpillar"
        }
        
        Dim urunAdiLower As String = urunAdi.ToLower().Trim()
        
        ' Bilinen markalardan eşleşme ara
        For Each marka As String In bilenenMarkalar
            If urunAdiLower.StartsWith(marka.ToLower() & " ") OrElse
               urunAdiLower.StartsWith(marka.ToLower() & "-") OrElse
               urunAdiLower.Contains(" " & marka.ToLower() & " ") Then
                Return marka
            End If
        Next
        
        ' İlk kelimeyi marka olarak al (eğer uygunsa)
        Dim ilkKelime As String = urunAdi.Split({" "c, "-"c})(0).Trim()
        If ilkKelime.Length >= 2 AndAlso Not IsNumeric(ilkKelime) Then
            If System.Text.RegularExpressions.Regex.IsMatch(ilkKelime, "^[A-Za-zÇçĞğİıÖöŞşÜü\.&']+$") Then
                Return ilkKelime
            End If
        End If
        
        Return ""
    End Function
    
    ''' <summary>
    ''' AI içeriği olmayan MODELLERİ al (her model için tek sefer)
    ''' </summary>
    Private Function GetProductsWithoutAI(maxCount As Integer) As List(Of Integer)
        Try
            Dim urunler As New List(Of Integer)
            
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                ' Her model için sadece 1 stokID al (DISTINCT sModel bazlı)
                ' tbStokUzunNot'ta kaydı olmayan modelleri seç
                Dim cmd As New OleDbCommand(
                    $"SELECT TOP {maxCount} MIN(s.nStokID) as nStokID, s.sModel " &
                    "FROM tbStok s " &
                    "LEFT JOIN tbStokUzunNot u ON s.sModel = u.sModel " &
                    "WHERE s.bWebGoruntule = 1 " &
                    "AND (u.sModel IS NULL OR u.sUzunNot IS NULL OR u.sUzunNot = '') " &
                    "GROUP BY s.sModel " &
                    "ORDER BY s.sModel", conn)
                
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                
                While reader.Read()
                    urunler.Add(Convert.ToInt32(reader("nStokID")))
                End While
                
                reader.Close()
            End Using
            
            LogAI("INFO", "GetProductsWithoutAI", $"AI içeriği olmayan {urunler.Count} MODEL bulundu")
            Return urunler
        Catch ex As Exception
            LogAI("ERROR", "GetProductsWithoutAI", $"Hata: {ex.Message}")
            Return New List(Of Integer)
        End Try
    End Function
    
    ''' <summary>
    ''' Veritabanına kaydet - Stok kartındaki gibi tbStokUzunNot ve tbStokAIIcerik tablolarına
    ''' </summary>
    Private Function SaveToDatabase(nStokID As Integer, productData As Dictionary(Of String, Object), totalCost As Decimal) As Boolean
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                ' Önce sModel'i al
                Dim sModel As String = ""
                Dim getModelCmd As New OleDbCommand("SELECT sModel FROM tbStok WHERE nStokID = ?", conn)
                getModelCmd.Parameters.AddWithValue("?", nStokID)
                Dim modelResult As Object = getModelCmd.ExecuteScalar()
                If modelResult IsNot Nothing AndAlso modelResult IsNot DBNull.Value Then
                    sModel = modelResult.ToString().Trim()
                End If
                
                If String.IsNullOrEmpty(sModel) Then
                    LogAI("ERROR", "SaveToDatabase", $"sModel bulunamadı: nStokID={nStokID}")
                    Return False
                End If
                
                ' Değerleri al
                Dim aciklama As String = If(productData.ContainsKey("ai_aciklama"), productData("ai_aciklama").ToString(), "")
                Dim kisaAciklama As String = If(productData.ContainsKey("ai_kisa_aciklama"), productData("ai_kisa_aciklama").ToString(), "")
                Dim ozellikler As String = If(productData.ContainsKey("ai_ozellikler"), productData("ai_ozellikler").ToString(), "")
                Dim bakimTalimati As String = If(productData.ContainsKey("ai_talimat"), productData("ai_talimat").ToString(), "")
                Dim seoBaslik As String = If(productData.ContainsKey("ai_baslik"), productData("ai_baslik").ToString(), "")
                Dim metaAciklama As String = If(productData.ContainsKey("ai_meta"), productData("ai_meta").ToString(), "")
                Dim anahtarKelimeler As String = If(productData.ContainsKey("ai_keywords"), productData("ai_keywords").ToString(), "")
                Dim bedenTablosu As String = If(productData.ContainsKey("ai_beden_tablosu"), productData("ai_beden_tablosu").ToString(), "")
                Dim icerikPuani As Integer = If(productData.ContainsKey("ai_puan"), Convert.ToInt32(productData("ai_puan")), 0)
                ' Yeni alanlar
                Dim yikamaTalimati As String = If(productData.ContainsKey("ai_yikama"), productData("ai_yikama").ToString(), "")
                Dim bakimTalimatiYeni As String = If(productData.ContainsKey("ai_bakim"), productData("ai_bakim").ToString(), "")
                Dim guvenlikUyari As String = If(productData.ContainsKey("ai_guvenlik"), productData("ai_guvenlik").ToString(), "")
                
                ' 1. tbStokUzunNot tablosunu güncelle
                Try
                    Dim checkCmd As New OleDbCommand("SELECT COUNT(*) FROM tbStokUzunNot WHERE sModel = ?", conn)
                    checkCmd.Parameters.AddWithValue("?", sModel)
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    
                    If exists > 0 Then
                        Dim updateCmd As New OleDbCommand(
                            "UPDATE tbStokUzunNot SET sUzunNot = ?, sBedenTablosu = ?, sOzellikler = ?, " &
                            "sKullanimTalimati = ?, sSonKullaniciAdi = ?, dteSonUpdateTarihi = ? WHERE sModel = ?", conn)
                        updateCmd.Parameters.AddWithValue("?", aciklama)
                        updateCmd.Parameters.AddWithValue("?", bedenTablosu)
                        updateCmd.Parameters.AddWithValue("?", ozellikler)
                        updateCmd.Parameters.AddWithValue("?", bakimTalimati)
                        updateCmd.Parameters.AddWithValue("?", "AI_SISTEM")
                        updateCmd.Parameters.AddWithValue("?", DateTime.Now)
                        updateCmd.Parameters.AddWithValue("?", sModel)
                        updateCmd.ExecuteNonQuery()
                    Else
                        Dim insertCmd As New OleDbCommand(
                            "INSERT INTO tbStokUzunNot (sModel, sUzunNot, sBedenTablosu, sOzellikler, sKullanimTalimati, sSonKullaniciAdi, dteSonUpdateTarihi) " &
                            "VALUES (?, ?, ?, ?, ?, ?, ?)", conn)
                        insertCmd.Parameters.AddWithValue("?", sModel)
                        insertCmd.Parameters.AddWithValue("?", aciklama)
                        insertCmd.Parameters.AddWithValue("?", bedenTablosu)
                        insertCmd.Parameters.AddWithValue("?", ozellikler)
                        insertCmd.Parameters.AddWithValue("?", bakimTalimati)
                        insertCmd.Parameters.AddWithValue("?", "AI_SISTEM")
                        insertCmd.Parameters.AddWithValue("?", DateTime.Now)
                        insertCmd.ExecuteNonQuery()
                    End If
                    LogAI("SUCCESS", "SaveToDatabase", $"tbStokUzunNot kaydedildi: sModel={sModel}")
                Catch uzunNotEx As Exception
                    LogAI("WARNING", "SaveToDatabase", $"tbStokUzunNot hatası: {uzunNotEx.Message}")
                End Try
                
                ' 2. tbStokAIIcerik tablosunu güncelle (tablo yoksa veya kolon yoksa atla)
                Try
                    Dim checkAI As New OleDbCommand("SELECT COUNT(*) FROM tbStokAIIcerik WHERE sModel = ?", conn)
                    checkAI.Parameters.AddWithValue("?", sModel)
                    Dim existsAI As Integer = Convert.ToInt32(checkAI.ExecuteScalar())
                    
                    If existsAI > 0 Then
                        Dim updateAI As New OleDbCommand(
                            "UPDATE tbStokAIIcerik SET sKisaAciklama = ?, sOzelliklerHTML = ?, " &
                            "sKullanimTalimati = ?, sSEOBaslik = ?, sMetaDescription = ?, sAnahtarKelimeler = ?, " &
                            "sBedenTablosu = ?, nIcerikPuani = ?, sYikamaTalimati = ?, sBakimTalimati = ?, sGuvenliklUyari = ? WHERE sModel = ?", conn)
                        updateAI.Parameters.AddWithValue("?", kisaAciklama)
                        updateAI.Parameters.AddWithValue("?", ozellikler)
                        updateAI.Parameters.AddWithValue("?", bakimTalimati)
                        updateAI.Parameters.AddWithValue("?", seoBaslik)
                        updateAI.Parameters.AddWithValue("?", metaAciklama)
                        updateAI.Parameters.AddWithValue("?", anahtarKelimeler)
                        updateAI.Parameters.AddWithValue("?", bedenTablosu)
                        updateAI.Parameters.AddWithValue("?", icerikPuani)
                        updateAI.Parameters.AddWithValue("?", yikamaTalimati)
                        updateAI.Parameters.AddWithValue("?", bakimTalimatiYeni)
                        updateAI.Parameters.AddWithValue("?", guvenlikUyari)
                        updateAI.Parameters.AddWithValue("?", sModel)
                        updateAI.ExecuteNonQuery()
                    Else
                        Dim insertAI As New OleDbCommand(
                            "INSERT INTO tbStokAIIcerik (sModel, sKisaAciklama, sOzelliklerHTML, " &
                            "sKullanimTalimati, sSEOBaslik, sMetaDescription, sAnahtarKelimeler, sBedenTablosu, " &
                            "nIcerikPuani, sYikamaTalimati, sBakimTalimati, sGuvenliklUyari, dteOlusturmaTarihi) " &
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
                        insertAI.Parameters.AddWithValue("?", sModel)
                        insertAI.Parameters.AddWithValue("?", kisaAciklama)
                        insertAI.Parameters.AddWithValue("?", ozellikler)
                        insertAI.Parameters.AddWithValue("?", bakimTalimati)
                        insertAI.Parameters.AddWithValue("?", seoBaslik)
                        insertAI.Parameters.AddWithValue("?", metaAciklama)
                        insertAI.Parameters.AddWithValue("?", anahtarKelimeler)
                        insertAI.Parameters.AddWithValue("?", bedenTablosu)
                        insertAI.Parameters.AddWithValue("?", icerikPuani)
                        insertAI.Parameters.AddWithValue("?", yikamaTalimati)
                        insertAI.Parameters.AddWithValue("?", bakimTalimatiYeni)
                        insertAI.Parameters.AddWithValue("?", guvenlikUyari)
                        insertAI.Parameters.AddWithValue("?", DateTime.Now)
                        insertAI.ExecuteNonQuery()
                    End If
                    LogAI("SUCCESS", "SaveToDatabase", $"tbStokAIIcerik kaydedildi: sModel={sModel}")
                Catch aiEx As Exception
                    LogAI("WARNING", "SaveToDatabase", $"tbStokAIIcerik hatası: {aiEx.Message}")
                End Try
                
                ' 3. tbStok tablosunda AI içerik var işaretle (AYNI MODELİN TÜM VARYANTLARI)
                Try
                    Dim updateStok As New OleDbCommand("UPDATE tbStok SET bAIIcerikVar = 1 WHERE sModel = ?", conn)
                    updateStok.Parameters.AddWithValue("?", sModel)
                    Dim affected As Integer = updateStok.ExecuteNonQuery()
                    LogAI("SUCCESS", "SaveToDatabase", $"tbStok.bAIIcerikVar=1: sModel={sModel} ({affected} varyant güncellendi)")
                Catch stokEx As Exception
                    LogAI("WARNING", "SaveToDatabase", $"tbStok güncelleme hatası: {stokEx.Message}")
                End Try
                
                ' 4. E-TİCARET SENKRONİZASYONU İÇİN ÜRÜNLERİ İŞARETLE
                ' Products tablosunda bu modelin tüm varyantlarını status=0 yap (tekrar gönderim için)
                Try
                    LogAI("DEBUG", "SaveToDatabase", $"Products tablosu güncelleniyor... sModel={sModel}")
                    
                    Dim syncAffected As Integer = 0
                    
                    ' ===== ÖNCE VARYANTSIZ ÜRÜN KONTROLÜ (productID = sModel) =====
                    Dim countSingle As New OleDbCommand("SELECT COUNT(*) FROM Products WHERE productID = ?", conn)
                    countSingle.Parameters.AddWithValue("?", sModel)
                    Dim singleCount As Integer = Convert.ToInt32(countSingle.ExecuteScalar())
                    
                    LogAI("DEBUG", "SaveToDatabase", $"Varyansız ürün kontrolü: {singleCount} adet (productID={sModel})")
                    
                    If singleCount > 0 Then
                        ' Varyansız ürün bulundu - direkt güncelle
                        Dim updateSingle As New OleDbCommand(
                            "UPDATE Products SET status = 0, updated_at = Now() WHERE productID = ?", conn)
                        updateSingle.Parameters.AddWithValue("?", sModel)
                        syncAffected = updateSingle.ExecuteNonQuery()
                        LogAI("SUCCESS", "SaveToDatabase", $"✅ Varyansız ürün güncellendi: productID={sModel} ({syncAffected} ürün status=0)")
                    End If
                    
                    ' ===== VARYANTLI ÜRÜN KONTROLÜ (productID LIKE sModel__%) =====
                    ' Access'te LIKE için * kullanılır, % değil!
                    Dim countVariant As New OleDbCommand("SELECT COUNT(*) FROM Products WHERE productID LIKE ?", conn)
                    countVariant.Parameters.AddWithValue("?", sModel & "__*")
                    Dim variantCount As Integer = Convert.ToInt32(countVariant.ExecuteScalar())
                    
                    LogAI("DEBUG", "SaveToDatabase", $"Varyantlı ürün kontrolü: {variantCount} adet (productID LIKE {sModel}__*)")
                    
                    If variantCount > 0 Then
                        ' Varyantlı ürünler bulundu - LIKE ile güncelle
                        Dim updateVariant As New OleDbCommand(
                            "UPDATE Products SET status = 0, updated_at = Now() WHERE productID LIKE ?", conn)
                        updateVariant.Parameters.AddWithValue("?", sModel & "__*")
                        Dim variantAffected As Integer = updateVariant.ExecuteNonQuery()
                        syncAffected += variantAffected
                        LogAI("SUCCESS", "SaveToDatabase", $"✅ Varyantlı ürünler güncellendi: {sModel}__* ({variantAffected} ürün status=0)")
                    End If
                    
                    If syncAffected = 0 Then
                        LogAI("WARNING", "SaveToDatabase", $"⚠️ Products tablosunda bu model bulunamadı: sModel={sModel}")
                    Else
                        LogAI("SUCCESS", "SaveToDatabase", $"✅ TOPLAM {syncAffected} ürün senkronizasyon için işaretlendi")
                    End If
                    
                Catch syncEx As Exception
                    LogAI("ERROR", "SaveToDatabase", $"E-ticaret senkronizasyon işaretleme hatası: {syncEx.Message}")
                End Try
                
                Return True
            End Using
        Catch ex As Exception
            LogAI("ERROR", "SaveToDatabase", $"Genel hata: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Log - Hem yerel hem de C:\AI\log.txt dosyasına yazar
    ''' </summary>
    Private Sub LogAI(level As String, func As String, message As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logMessage As String = $"[{timestamp}] [{level}] [{func}] {message}"
            
            Console.WriteLine(logMessage)
            
            ' C:\AI klasörüne yaz
            Dim aiLogFolder As String = "C:\AI"
            Dim aiLogFile As String = Path.Combine(aiLogFolder, "AILog.txt")
            
            ' Klasör yoksa oluştur
            If Not Directory.Exists(aiLogFolder) Then
                Directory.CreateDirectory(aiLogFolder)
            End If
            
            File.AppendAllText(aiLogFile, logMessage & vbCrLf)
        Catch
            ' Ignore log errors
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
    
End Class
