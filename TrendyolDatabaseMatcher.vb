' ============================================================================
' TRENDYOL DATABASE MATCHER - VB.NET
' ============================================================================
' Önce veritabanındaki benzer ürünlere bakarak kategori eşleştirmesi yapar
' Aynı ürün tipi farklı cinsiyet olsa bile kategorileri eşleştirir
' Bulamazsa Trendyol'a gider
' ============================================================================

Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.Linq

Public Class TrendyolDatabaseMatcher
    
    ' 6 Cinsiyet türü + alternatif yazımlar
    ' Uzun olanlar önce kontrol edilmeli
    Private Shared ReadOnly CINSIYET_LISTESI As String()() = New String()() {
        New String() {"KIZBEBEK", "KIZ BEBEK", "Kız Bebek"},
        New String() {"ERKEKBEBEK", "ERKEK BEBEK", "Erkek Bebek"},
        New String() {"KIZCOCUK", "KIZ COCUK", "Kız Çocuk"},
        New String() {"ERKEKCOCUK", "ERKEK COCUK", "Erkek Çocuk"},
        New String() {"ANNEKIZ", "ANNE KIZ", "Kız Çocuk"},
        New String() {"BABAOGUL", "BABA OGUL", "Erkek Çocuk"},
        New String() {"KIZGARSON", "KIZ GARSON", "Kız Çocuk"},
        New String() {"ERKEKGARSON", "ERKEK GARSON", "Erkek Çocuk"},
        New String() {"BAYAN", "BAYAN", "Kadın"},
        New String() {"KADIN", "KADIN", "Kadın"},
        New String() {"BAY", "BAY", "Erkek"},
        New String() {"ERKEK", "ERKEK", "Erkek"},
        New String() {"BEBE", "BEBE", "Bebek"},
        New String() {"BEBEK", "BEBEK", "Bebek"},
        New String() {"COCUK", "COCUK", "Çocuk"},
        New String() {"GARSON", "GARSON", "Çocuk"}
    }
    
    ' Ürün tipleri - kategoriye etki eden gerçek ürün tipleri
    ' Kadife, polar, interlok, süprem, fitilli = kumaş türü, kategori değil
    Private Shared ReadOnly URUN_TIPI_LISTESI As String()() = New String()() {
        New String() {"ESOFMANTAKIM", "Eşofman Takımı"},
        New String() {"ESORTMANTAKIM", "Eşofman Takımı"},
        New String() {"ESOFMANALT", "Eşofman Altı"},
        New String() {"ESORTMANALT", "Eşofman Altı"},
        New String() {"ESOFMANUST", "Eşofman Üstü"},
        New String() {"ESORTMANUST", "Eşofman Üstü"},
        New String() {"ESOFMAN", "Eşofman"},
        New String() {"ESORTMAN", "Eşofman"},
        New String() {"PIJAMATAKIMI", "Pijama Takımı"},
        New String() {"PIJAMATAKM", "Pijama Takımı"},
        New String() {"PIJAMAALT", "Pijama Altı"},
        New String() {"PIJAMA", "Pijama"},
        New String() {"BEBEKTAKIMI", "Bebek Takımı"},
        New String() {"BEBEKTAKIM", "Bebek Takımı"},
        New String() {"BERETAKIMI", "Bere Takımı"},
        New String() {"BERETAKIM", "Bere Takımı"},
        New String() {"ALTUSTTAKIM", "Alt Üst Takım"},
        New String() {"ALTUSTTAKIMI", "Alt Üst Takım"},
        New String() {"ALTUST", "Alt Üst Takım"},
        New String() {"5LITAKIM", "5'li Takım"},
        New String() {"BESLITAKIM", "5'li Takım"},
        New String() {"4LUTAKIM", "4'lü Takım"},
        New String() {"DORTLUTAKIM", "4'lü Takım"},
        New String() {"3LUTAKIM", "3'lü Takım"},
        New String() {"UCLUTAKIM", "3'lü Takım"},
        New String() {"2LITAKIM", "2'li Takım"},
        New String() {"IKILITAKIM", "2'li Takım"},
        New String() {"LOHUSATAKIM", "Lohusa Takım"},
        New String() {"LOHUSA", "Lohusa"},
        New String() {"KAPRITAKIM", "Kapri Takım"},
        New String() {"KAPRITAKIMI", "Kapri Takımı"},
        New String() {"SORTTAKIM", "Şort Takım"},
        New String() {"SORTTAKIMI", "Şort Takımı"},
        New String() {"SORTLUTAKIM", "Şortlu Takım"},
        New String() {"BERMUDATAKIM", "Bermuda Takım"},
        New String() {"BERMUDA", "Bermuda"},
        New String() {"TISORT", "T-Shirt"},
        New String() {"TSHIRT", "T-Shirt"},
        New String() {"SWEATSHIRT", "Sweatshirt"},
        New String() {"SWEAT", "Sweat"},
        New String() {"SORT", "Şort"},
        New String() {"ELBISE", "Elbise"},
        New String() {"GECELIK", "Gecelik"},
        New String() {"SABAHLIK", "Sabahlık"},
        New String() {"MONT", "Mont"},
        New String() {"KABAN", "Kaban"},
        New String() {"YELEK", "Yelek"},
        New String() {"PANTOLON", "Pantolon"},
        New String() {"TAYT", "Tayt"},
        New String() {"KAPRI", "Kapri"},
        New String() {"HIRKA", "Hırka"},
        New String() {"KAZAK", "Kazak"},
        New String() {"BODY", "Body"},
        New String() {"TULUM", "Tulum"},
        New String() {"ATLET", "Atlet"},
        New String() {"GOMLEK", "Gömlek"},
        New String() {"CEKET", "Ceket"},
        New String() {"ETEK", "Etek"},
        New String() {"BERE", "Bere"},
        New String() {"TAKIM", "Takım"},
        New String() {"TAKIMI", "Takım"}
    }
    
    ''' <summary>
    ''' Ana fonksiyon - Önce database'e bakar, bulamazsa Trendyol'a gider
    ''' </summary>
    Public Shared Function GetKategori(connection As String, barkod As String, urunAdi As String, marka As String, sModel As String) As TrendyolScraperSonuc
        Dim sonuc As New TrendyolScraperSonuc()
        sonuc.Barkod = barkod
        
        Try
            ' 1. Önce veritabanında benzer ürün ara
            Dim dbSonuc As TrendyolScraperSonuc = AraVeEslestirDatabase(connection, urunAdi, sModel)
            
            If dbSonuc IsNot Nothing AndAlso dbSonuc.Basarili Then
                dbSonuc.Not_ = "DATABASE: " & dbSonuc.Not_
                Return dbSonuc
            End If
        Catch ex As Exception
            ' Database hatası, Trendyol'a geç
        End Try
        
        ' 2. Veritabanında bulamadık, Trendyol'a git
        Try
            Dim trendyolSonuc As TrendyolScraperSonuc = TrendyolWebScraperService.GetKategoriByBarkod(barkod, urunAdi, marka)
            If trendyolSonuc.Basarili Then
                trendyolSonuc.Not_ = "TRENDYOL: " & trendyolSonuc.Not_
            End If
            Return trendyolSonuc
        Catch ex As Exception
            sonuc.Basarili = False
            sonuc.HataMesaji = "Hata: " & ex.Message
            Return sonuc
        End Try
    End Function
    
    ''' <summary>
    ''' Sadece veritabanında arama yapar (Trendyol'a gitmez)
    ''' </summary>
    Public Shared Function AraVeritabani(connection As String, urunAdi As String) As TrendyolScraperSonuc
        Dim sonuc As New TrendyolScraperSonuc()
        sonuc.Basarili = False
        
        Try
            Dim dbSonuc As TrendyolScraperSonuc = AraVeEslestirDatabase(connection, urunAdi, "")
            
            If dbSonuc IsNot Nothing AndAlso dbSonuc.Basarili Then
                dbSonuc.Not_ = "DATABASE: " & dbSonuc.Not_
                Return dbSonuc
            End If
            
            sonuc.HataMesaji = "Veritabanında eşleşme bulunamadı"
            Return sonuc
        Catch ex As Exception
            sonuc.HataMesaji = "Veritabanı hatası: " & ex.Message
            Return sonuc
        End Try
    End Function
    
    ''' <summary>
    ''' Model kodu ile veritabanında arama yapar (sModel = 'XXX')
    ''' Aynı modeldeki başka bir ürünün kategorisini bulur
    ''' </summary>
    Public Shared Function AraVeritabaniModelKodu(connection As String, sModel As String) As TrendyolScraperSonuc
        Dim sonuc As New TrendyolScraperSonuc()
        sonuc.Basarili = False
        
        Try
            If String.IsNullOrEmpty(connection) OrElse String.IsNullOrEmpty(sModel) Then
                sonuc.HataMesaji = "Bağlantı veya model kodu boş"
                Return sonuc
            End If
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Aynı modeldeki, kategorisi dolu olan başka bir ürünü ara
                ' Marka (Sinif3) da dahil edildi
                Dim sql As String = "SELECT TOP 1 tbStok.sAciklama, tbStok.sModel, " &
                                   "s3.sAciklama AS Sinif3Aciklama, " &
                                   "s4.sAciklama AS Sinif4Aciklama, s5.sAciklama AS Sinif5Aciklama, " &
                                   "s6.sAciklama AS Sinif6Aciklama, s7.sAciklama AS Sinif7Aciklama, " &
                                   "s8.sAciklama AS Sinif8Aciklama " &
                                   "FROM tbStok " &
                                   "INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID " &
                                   "LEFT JOIN tbSSinif3 s3 ON s3.sSinifKodu = tbStokSinifi.sSinifKodu3 " &
                                   "LEFT JOIN tbSSinif4 s4 ON s4.sSinifKodu = tbStokSinifi.sSinifKodu4 " &
                                   "LEFT JOIN tbSSinif5 s5 ON s5.sSinifKodu = tbStokSinifi.sSinifKodu5 " &
                                   "LEFT JOIN tbSSinif6 s6 ON s6.sSinifKodu = tbStokSinifi.sSinifKodu6 " &
                                   "LEFT JOIN tbSSinif7 s7 ON s7.sSinifKodu = tbStokSinifi.sSinifKodu7 " &
                                   "LEFT JOIN tbSSinif8 s8 ON s8.sSinifKodu = tbStokSinifi.sSinifKodu8 " &
                                   "WHERE tbStok.sModel = ? " &
                                   "AND tbStokSinifi.sSinifKodu4 IS NOT NULL " &
                                   "AND tbStokSinifi.sSinifKodu4 <> '' " &
                                   "AND tbStokSinifi.sSinifKodu5 IS NOT NULL " &
                                   "AND tbStokSinifi.sSinifKodu5 <> ''"
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", sModel)
                
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim bulunanAciklama As String = If(reader("sAciklama") IsNot DBNull.Value, reader("sAciklama").ToString(), "")
                        
                        ' MARKA'yı al (Sinif3)
                        Dim sinif3 As String = If(reader("Sinif3Aciklama") IsNot DBNull.Value, reader("Sinif3Aciklama").ToString().Trim(), "")
                        
                        ' Kategori AÇIKLAMALARINI al
                        Dim sinif4 As String = If(reader("Sinif4Aciklama") IsNot DBNull.Value, reader("Sinif4Aciklama").ToString().Trim(), "")
                        Dim sinif5 As String = If(reader("Sinif5Aciklama") IsNot DBNull.Value, reader("Sinif5Aciklama").ToString().Trim(), "")
                        Dim sinif6 As String = If(reader("Sinif6Aciklama") IsNot DBNull.Value, reader("Sinif6Aciklama").ToString().Trim(), "")
                        Dim sinif7 As String = If(reader("Sinif7Aciklama") IsNot DBNull.Value, reader("Sinif7Aciklama").ToString().Trim(), "")
                        Dim sinif8 As String = If(reader("Sinif8Aciklama") IsNot DBNull.Value, reader("Sinif8Aciklama").ToString().Trim(), "")
                        
                        ' Kategorileri oluştur
                        Dim kategoriler As New List(Of String)
                        If Not String.IsNullOrEmpty(sinif4) Then kategoriler.Add(sinif4)
                        If Not String.IsNullOrEmpty(sinif5) Then kategoriler.Add(sinif5)
                        If Not String.IsNullOrEmpty(sinif6) Then kategoriler.Add(sinif6)
                        If Not String.IsNullOrEmpty(sinif7) Then kategoriler.Add(sinif7)
                        If Not String.IsNullOrEmpty(sinif8) Then kategoriler.Add(sinif8)
                        
                        If kategoriler.Count >= 2 Then
                            sonuc.Basarili = True
                            sonuc.KategoriYolu = String.Join(" / ", kategoriler)
                            sonuc.Kategoriler = kategoriler
                            sonuc.Marka = sinif3  ' MARKA bilgisini sonuca ekle
                            sonuc.Skor = 0.95
                            sonuc.Not_ = $"Model eşleşmesi: {bulunanAciklama}"
                            If Not String.IsNullOrEmpty(sinif3) Then
                                sonuc.Not_ &= $" | Marka: {sinif3}"
                            End If
                            Return sonuc
                        End If
                    End If
                End Using
            End Using
            
            sonuc.HataMesaji = "Veritabanında model eşleşmesi bulunamadı"
            Return sonuc
        Catch ex As Exception
            sonuc.HataMesaji = "Veritabanı hatası: " & ex.Message
            Return sonuc
        End Try
    End Function
    
    ''' <summary>
    ''' Veritabanında benzer ürün arar ve kategori eşleştirmesi yapar
    ''' </summary>
    Private Shared Function AraVeEslestirDatabase(connection As String, urunAdi As String, sModel As String) As TrendyolScraperSonuc
        Try
            If String.IsNullOrEmpty(connection) OrElse String.IsNullOrEmpty(urunAdi) Then
                Return Nothing
            End If
            
            ' Ürün adından cinsiyet ve ürün tipini çıkar (model kodu ile)
            Dim aramaninCinsiyeti As String = BulCinsiyet(urunAdi, sModel)
            Dim aramaninUrunTipi As String = BulUrunTipi(urunAdi)
            
            If String.IsNullOrEmpty(aramaninUrunTipi) Then
                Return Nothing
            End If
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Aynı ürün tipinde, kategorisi dolu olan ürünleri ara
                ' Yeni yapı: Sinif3=Marka, Sinif4=Kat1, Sinif5=Kat2, Sinif6=Kat3, Sinif7=Kat4, Sinif8=Kat5
                ' JOIN ile AÇIKLAMA değerlerini al (kod değil!)
                Dim sql As String = "SELECT TOP 10 tbStok.sAciklama, " &
                                   "s3.sAciklama AS Sinif3Aciklama, " &
                                   "s4.sAciklama AS Sinif4Aciklama, s5.sAciklama AS Sinif5Aciklama, " &
                                   "s6.sAciklama AS Sinif6Aciklama, s7.sAciklama AS Sinif7Aciklama, " &
                                   "s8.sAciklama AS Sinif8Aciklama " &
                                   "FROM tbStok " &
                                   "INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID " &
                                   "LEFT JOIN tbSSinif3 s3 ON s3.sSinifKodu = tbStokSinifi.sSinifKodu3 " &
                                   "LEFT JOIN tbSSinif4 s4 ON s4.sSinifKodu = tbStokSinifi.sSinifKodu4 " &
                                   "LEFT JOIN tbSSinif5 s5 ON s5.sSinifKodu = tbStokSinifi.sSinifKodu5 " &
                                   "LEFT JOIN tbSSinif6 s6 ON s6.sSinifKodu = tbStokSinifi.sSinifKodu6 " &
                                   "LEFT JOIN tbSSinif7 s7 ON s7.sSinifKodu = tbStokSinifi.sSinifKodu7 " &
                                   "LEFT JOIN tbSSinif8 s8 ON s8.sSinifKodu = tbStokSinifi.sSinifKodu8 " &
                                   "WHERE tbStok.sAciklama LIKE ? " &
                                   "AND tbStokSinifi.sSinifKodu4 IS NOT NULL " &
                                   "AND tbStokSinifi.sSinifKodu4 <> '' " &
                                   "AND tbStokSinifi.sSinifKodu5 IS NOT NULL " &
                                   "AND tbStokSinifi.sSinifKodu5 <> ''"
                
                ' Ürün tipini arama için hazırla
                Dim aramaTipi As String = "%" & aramaninUrunTipi & "%"
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", aramaTipi)
                
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim bulunanAciklama As String = If(reader("sAciklama") IsNot DBNull.Value, reader("sAciklama").ToString(), "")
                        
                        ' Bulunan ürünün de aynı ürün tipinde olduğunu doğrula
                        Dim bulunanUrunTipi As String = BulUrunTipi(bulunanAciklama)
                        If String.IsNullOrEmpty(bulunanUrunTipi) OrElse bulunanUrunTipi <> aramaninUrunTipi Then
                            Continue While
                        End If
                        
                        ' MARKA'yı al (Sinif3)
                        Dim sinif3 As String = If(reader("Sinif3Aciklama") IsNot DBNull.Value, reader("Sinif3Aciklama").ToString().Trim(), "")
                        
                        ' Kategori AÇIKLAMALARINI al (kod değil!)
                        Dim sinif4 As String = If(reader("Sinif4Aciklama") IsNot DBNull.Value, reader("Sinif4Aciklama").ToString().Trim(), "")
                        Dim sinif5 As String = If(reader("Sinif5Aciklama") IsNot DBNull.Value, reader("Sinif5Aciklama").ToString().Trim(), "")
                        Dim sinif6 As String = If(reader("Sinif6Aciklama") IsNot DBNull.Value, reader("Sinif6Aciklama").ToString().Trim(), "")
                        Dim sinif7 As String = If(reader("Sinif7Aciklama") IsNot DBNull.Value, reader("Sinif7Aciklama").ToString().Trim(), "")
                        Dim sinif8 As String = If(reader("Sinif8Aciklama") IsNot DBNull.Value, reader("Sinif8Aciklama").ToString().Trim(), "")
                        
                        ' En az sinif4 ve sinif5 dolu olmalı
                        If String.IsNullOrEmpty(sinif4) OrElse String.IsNullOrEmpty(sinif5) Then
                            Continue While
                        End If
                        
                        ' CİNSİYET DEĞİŞTİRME - sinif5 cinsiyet kategorisi, gerekirse değiştir
                        Dim yeniSinif5 As String = sinif5
                        Dim bulunanCinsiyet As String = BulCinsiyet(bulunanAciklama)
                        
                        If Not String.IsNullOrEmpty(aramaninCinsiyeti) AndAlso Not String.IsNullOrEmpty(bulunanCinsiyet) Then
                            ' Eğer cinsiyetler farklıysa, aranan ürünün cinsiyetini kullan
                            If aramaninCinsiyeti <> bulunanCinsiyet Then
                                yeniSinif5 = aramaninCinsiyeti ' BulCinsiyet zaten Trendyol karşılığını döndürüyor
                            End If
                        End If
                        
                        ' Kategorileri oluştur (Sinif4, Sinif5, Sinif6, Sinif7, Sinif8)
                        Dim kategoriler As New List(Of String)
                        If Not String.IsNullOrEmpty(sinif4) Then kategoriler.Add(sinif4)
                        If Not String.IsNullOrEmpty(yeniSinif5) Then kategoriler.Add(yeniSinif5)
                        If Not String.IsNullOrEmpty(sinif6) Then kategoriler.Add(sinif6)
                        If Not String.IsNullOrEmpty(sinif7) Then kategoriler.Add(sinif7)
                        If Not String.IsNullOrEmpty(sinif8) Then kategoriler.Add(sinif8)
                        
                        If kategoriler.Count >= 2 Then
                            Dim sonuc As New TrendyolScraperSonuc()
                            sonuc.Basarili = True
                            sonuc.KategoriYolu = String.Join(" / ", kategoriler)
                            sonuc.Kategoriler = kategoriler
                            sonuc.Marka = sinif3  ' MARKA bilgisini sonuca ekle
                            sonuc.Skor = 0.95
                            sonuc.Not_ = $"Benzer: {bulunanAciklama}"
                            
                            If Not String.IsNullOrEmpty(sinif3) Then
                                sonuc.Not_ &= $" | Marka: {sinif3}"
                            End If
                            
                            If aramaninCinsiyeti <> bulunanCinsiyet Then
                                sonuc.Not_ &= $" | Cinsiyet: {bulunanCinsiyet} → {aramaninCinsiyeti}"
                            End If
                            
                            Return sonuc
                        End If
                    End While
                End Using
            End Using
            
        Catch ex As Exception
            ' Hata durumunda null dön
        End Try
        
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Metni normalize eder: Büyük harf + Türkçe karakter -> ASCII + boşlukları kaldır
    ''' </summary>
    Private Shared Function NormalizeMetin(metin As String) As String
        If String.IsNullOrEmpty(metin) Then Return ""
        Return metin.ToUpperInvariant() _
            .Replace("İ", "I").Replace("i", "I").Replace("ı", "I").Replace("I", "I") _
            .Replace("Ş", "S").Replace("ş", "S") _
            .Replace("Ğ", "G").Replace("ğ", "G") _
            .Replace("Ü", "U").Replace("ü", "U") _
            .Replace("Ö", "O").Replace("ö", "O") _
            .Replace("Ç", "C").Replace("ç", "C") _
            .Replace(" ", "").Replace("-", "").Replace("_", "") _
            .Replace("'", "").Replace("'", "").Replace("`", "")
    End Function
    
    ''' <summary>
    ''' Ürün adından cinsiyeti bulur
    ''' ANNE KIZ / BABA OĞUL için model kodunun sonunda -S varsa yetişkin, yoksa çocuk
    ''' </summary>
    Private Shared Function BulCinsiyet(urunAdi As String, Optional sModel As String = "") As String
        If String.IsNullOrEmpty(urunAdi) Then Return ""
        
        Dim normalized As String = NormalizeMetin(urunAdi)
        Dim modelSonundaS As Boolean = False
        
        ' Model kodunun sonunda -S var mı kontrol et
        If Not String.IsNullOrEmpty(sModel) Then
            Dim modelUpper As String = sModel.ToUpperInvariant().Trim()
            modelSonundaS = modelUpper.EndsWith("-S") OrElse modelUpper.EndsWith("S")
        End If
        
        ' ANNE KIZ kontrolü - model koduna göre Kadın veya Kız Çocuk
        If normalized.Contains("ANNEKIZ") Then
            If modelSonundaS Then
                Return "Kadın"
            Else
                Return "Kız Çocuk"
            End If
        End If
        
        ' BABA OĞUL kontrolü - model koduna göre Erkek veya Erkek Çocuk
        If normalized.Contains("BABAOGUL") Then
            If modelSonundaS Then
                Return "Erkek"
            Else
                Return "Erkek Çocuk"
            End If
        End If
        
        ' Diğer cinsiyetler için normal kontrol
        For Each cinsiyetArr As String() In CINSIYET_LISTESI
            Dim aramaTerimi As String = cinsiyetArr(0)
            ' ANNEKIZ ve BABAOGUL zaten yukarıda işlendi, atla
            If aramaTerimi = "ANNEKIZ" OrElse aramaTerimi = "BABAOGUL" Then Continue For
            
            If normalized.Contains(aramaTerimi) Then
                Return cinsiyetArr(2) ' Trendyol karşılığı
            End If
        Next
        
        Return ""
    End Function
    
    ''' <summary>
    ''' Ürün adından ürün tipini bulur
    ''' </summary>
    Private Shared Function BulUrunTipi(urunAdi As String) As String
        If String.IsNullOrEmpty(urunAdi) Then Return ""
        
        Dim normalized As String = NormalizeMetin(urunAdi)
        
        For Each tipArr As String() In URUN_TIPI_LISTESI
            Dim aramaTerimi As String = tipArr(0) ' normalize edilmiş
            If normalized.Contains(aramaTerimi) Then
                Return tipArr(1) ' gösterilecek isim
            End If
        Next
        
        Return ""
    End Function
    
End Class

''' <summary>
''' Parse edilmiş ürün bilgisi
''' </summary>
Public Class UrunBilgiParsed
    Public Property Cinsiyet As String = ""
    Public Property UrunTipi As String = ""
    Public Property Marka As String = ""
End Class
