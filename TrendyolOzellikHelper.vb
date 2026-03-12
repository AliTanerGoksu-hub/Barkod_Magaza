' ============================================================================
' TRENDYOL ÖZELLİK DOLDURMA HELPER
' Dosya: TrendyolOzellikHelper.vb
' Tarih: 2026-02-20
' Açıklama: Trendyol ürün özelliklerini otomatik doldurur
' NOT: frm_qukaGonder.vb'den BAĞIMSIZ çalışır
' ============================================================================

Imports System.Collections.Generic

''' <summary>
''' Trendyol ürün özelliklerini kategori ve ürün bilgisine göre otomatik doldurur
''' Hiçbir alan boş kalmaz - eksik alanlar varsayılan değerlerle doldurulur
''' </summary>
Public Class TrendyolOzellikHelper

#Region "Ana Metod"

    ''' <summary>
    ''' Ürün için tüm Trendyol özelliklerini doldurur
    ''' </summary>
    Public Shared Function DoldurTumOzellikler(urunAdi As String, kategori As String, 
                                                marka As String, renk As String,
                                                Optional cinsiyet As String = "",
                                                Optional yasGrubu As String = "",
                                                Optional kumas As String = "") As Dictionary(Of String, Object)
        
        Dim ozellikler As New Dictionary(Of String, Object)
        
        Try
            EticaretLogger.LogInfo($"Trendyol özellikleri dolduruluyor: {urunAdi}")
            
            ' Cinsiyet ve yaş grubu tespit
            Dim gercekCinsiyet As String = TespitCinsiyet(urunAdi, cinsiyet, kategori)
            Dim gercekYasGrubu As String = TespitYasGrubu(urunAdi, yasGrubu, kategori)
            Dim gercekKumas As String = TespitKumas(urunAdi, kumas, kategori)
            
            ' ===== ZORUNLU ALANLAR (*) - SABİT DEĞERLER =====
            ozellikler("kargoFirmasi") = "Trendyol Express"  ' SABİT
            ozellikler("marka") = If(String.IsNullOrEmpty(marka), "Furkan Pijama", marka)
            ozellikler("beden") = "Standart"                  ' SABİT
            ozellikler("boy") = "Normal Boy"                  ' SABİT
            ozellikler("cinsiyet") = gercekCinsiyet
            ozellikler("desen") = TespitDesen(urunAdi, kategori)
            ozellikler("kalip") = "Regular"                   ' SABİT
            ozellikler("kumasTipi") = "Dokuma"                ' SABİT
            ozellikler("mensei") = "TR"                       ' SABİT
            ozellikler("renk") = "Beyaz"                      ' SABİT
            ozellikler("webColor") = "Çok Renkli"             ' SABİT
            ozellikler("yasGrubu") = gercekYasGrubu
            
            ' ===== OPSİYONEL ALANLAR (Ama hepsini dolduruyoruz) =====
            ozellikler("altUstTakim") = TespitAltUstTakim(urunAdi, kategori)
            ozellikler("astarDurumu") = "Astarsız"
            ozellikler("baskiNakisTekniki") = TespitBaskiTeknik(urunAdi)
            ozellikler("bel") = "Normal Bel"
            ozellikler("cep") = "Cepsiz"
            ozellikler("dokumaTipi") = TespitDokumaTipi(gercekKumas)
            ozellikler("ekOzellik") = TespitEkOzellik(urunAdi, marka)
            ozellikler("kalinlik") = "Orta"
            ozellikler("kapamaSekli") = TespitKapamaSekli(urunAdi, kategori)
            ozellikler("kemerKusakDurumu") = "Kemersiz"
            ozellikler("kolBoyu") = TespitKolBoyu(urunAdi, kategori)
            ozellikler("kolTipi") = "Standart Kol"
            ozellikler("koleksiyon") = TespitKoleksiyon(urunAdi, marka)
            ozellikler("kutuDurumu") = "Kutu yok"
            ozellikler("materyal") = gercekKumas
            ozellikler("ortam") = "Casual/Günlük"
            ozellikler("pacaTipi") = TespitPacaTipi(urunAdi, kategori)
            ozellikler("paketIcerigi") = TespitPaketIcerigi(urunAdi, kategori)
            ozellikler("parcaSayisi") = TespitParcaSayisi(urunAdi, kategori)
            ozellikler("persona") = TespitPersona(gercekYasGrubu)
            ozellikler("sezon") = "Tüm Sezonlar"
            ozellikler("siluet") = "Basic"
            ozellikler("surdurulebilirlikDetayi") = "Hayır"
            ozellikler("urunDetayi") = TespitUrunDetayi(urunAdi, gercekKumas)
            ozellikler("urunTipi") = "Düz"
            ozellikler("yakaTipi") = TespitYakaTipi(urunAdi, kategori)
            
            ' ===== İTHALATÇI/ÜRETİCİ BİLGİLERİ (Boş bırakılabilir) =====
            ozellikler("birincilIthalatciAdi") = ""
            ozellikler("birincilIthalatciAdres") = ""
            ozellikler("birincilIthalatciMail") = ""
            ozellikler("ikincilIthalatciAdi") = ""
            ozellikler("ikincilIthalatciAdres") = ""
            ozellikler("ikincilIthalatciMail") = ""
            ozellikler("ucunculIthalatciAdi") = ""
            ozellikler("ucunculIthalatciAdres") = ""
            ozellikler("ucunculIthalatciMail") = ""
            ozellikler("ureticiAdi") = ""
            ozellikler("ureticiAdres") = ""
            ozellikler("ureticiMail") = ""
            
            EticaretLogger.LogInfo($"Trendyol özellikleri dolduruldu: {ozellikler.Count} alan")
            
        Catch ex As Exception
            EticaretLogger.LogError("DoldurTumOzellikler hatası", ex)
        End Try
        
        Return ozellikler
    End Function

#End Region

#Region "Tespit Metodları"

    ''' <summary>
    ''' Ürün adından cinsiyet tespit eder
    ''' </summary>
    Public Shared Function TespitCinsiyet(urunAdi As String, mevcutCinsiyet As String, kategori As String) As String
        If Not String.IsNullOrEmpty(mevcutCinsiyet) AndAlso mevcutCinsiyet.ToLower() <> "unisex" Then
            Return mevcutCinsiyet
        End If
        
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("erkek bebek") Then Return "Erkek Bebek"
        If kaynak.Contains("kız bebek") OrElse kaynak.Contains("kiz bebek") Then Return "Kız Bebek"
        If kaynak.Contains("erkek çocuk") OrElse kaynak.Contains("erkek cocuk") Then Return "Erkek Çocuk"
        If kaynak.Contains("kız çocuk") OrElse kaynak.Contains("kiz cocuk") Then Return "Kız Çocuk"
        If kaynak.Contains("kadın") OrElse kaynak.Contains("kadin") OrElse kaynak.Contains("bayan") Then Return "Kadın"
        If kaynak.Contains("erkek") Then Return "Erkek"
        If kaynak.Contains("bebek") Then Return "Bebek"
        If kaynak.Contains("çocuk") OrElse kaynak.Contains("cocuk") Then Return "Çocuk"
        
        Return "Unisex"
    End Function
    
    ''' <summary>
    ''' Ürün adından yaş grubu tespit eder
    ''' </summary>
    Public Shared Function TespitYasGrubu(urunAdi As String, mevcutYasGrubu As String, kategori As String) As String
        If Not String.IsNullOrEmpty(mevcutYasGrubu) Then
            Return mevcutYasGrubu
        End If
        
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("bebek") OrElse kaynak.Contains("baby") Then Return "Bebek"
        If kaynak.Contains("çocuk") OrElse kaynak.Contains("cocuk") OrElse kaynak.Contains("kids") Then Return "Çocuk"
        
        Return "Yetişkin"
    End Function
    
    ''' <summary>
    ''' Ürün adından kumaş/materyal tespit eder
    ''' </summary>
    Public Shared Function TespitKumas(urunAdi As String, mevcutKumas As String, kategori As String) As String
        If Not String.IsNullOrEmpty(mevcutKumas) Then
            Return mevcutKumas
        End If
        
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        ' Kumaş tespiti
        If kaynak.Contains("pamuk") OrElse kaynak.Contains("cotton") Then Return "Pamuklu"
        If kaynak.Contains("polar") OrElse kaynak.Contains("fleece") Then Return "Polar"
        If kaynak.Contains("kadife") Then Return "Kadife"
        If kaynak.Contains("welsoft") Then Return "Welsoft"
        If kaynak.Contains("polyester") Then Return "Polyester"
        If kaynak.Contains("viskon") Then Return "Viskon"
        If kaynak.Contains("penye") Then Return "Penye"
        If kaynak.Contains("süprem") OrElse kaynak.Contains("suprem") Then Return "Süprem"
        If kaynak.Contains("interlok") Then Return "İnterlok"
        
        ' Kategori bazlı varsayılan
        If kaynak.Contains("pijama") OrElse kaynak.Contains("gecelik") Then Return "Pamuklu"
        If kaynak.Contains("mont") OrElse kaynak.Contains("kaban") Then Return "Polyester"
        If kaynak.Contains("t-shirt") OrElse kaynak.Contains("tişört") Then Return "Pamuklu"
        
        Return "Pamuklu"
    End Function
    
    ''' <summary>
    ''' Desen tespit eder
    ''' </summary>
    Public Shared Function TespitDesen(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("baskılı") OrElse kaynak.Contains("baskili") OrElse kaynak.Contains("print") Then Return "Baskılı"
        If kaynak.Contains("çizgili") OrElse kaynak.Contains("cizgili") Then Return "Çizgili"
        If kaynak.Contains("kareli") Then Return "Kareli"
        If kaynak.Contains("puantiyeli") Then Return "Puantiyeli"
        If kaynak.Contains("desenli") Then Return "Desenli"
        If kaynak.Contains("düz") OrElse kaynak.Contains("duz") Then Return "Düz"
        
        Return "Baskılı"
    End Function
    
    ''' <summary>
    ''' Kalıp tespit eder
    ''' </summary>
    Public Shared Function TespitKalip(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("slim") OrElse kaynak.Contains("dar") Then Return "Slim Fit"
        If kaynak.Contains("oversize") OrElse kaynak.Contains("bol") Then Return "Oversize"
        If kaynak.Contains("loose") Then Return "Loose"
        
        Return "Regular"
    End Function
    
    ''' <summary>
    ''' Kumaş tipi tespit eder
    ''' </summary>
    Public Shared Function TespitKumasTipi(kumas As String) As String
        Dim kumasLower As String = kumas.ToLower()
        
        If kumasLower.Contains("örme") OrElse kumasLower.Contains("penye") OrElse 
           kumasLower.Contains("süprem") OrElse kumasLower.Contains("interlok") Then
            Return "Örme"
        End If
        
        If kumasLower.Contains("dokuma") Then Return "Dokuma"
        
        Return "Dokuma"
    End Function
    
    ''' <summary>
    ''' Web renk tespit eder
    ''' </summary>
    Public Shared Function TespitWebColor(renk As String) As String
        If String.IsNullOrEmpty(renk) Then Return "Çok Renkli"
        
        Dim renkLower As String = renk.ToLower()
        
        If renkLower.Contains("beyaz") Then Return "Beyaz"
        If renkLower.Contains("siyah") Then Return "Siyah"
        If renkLower.Contains("mavi") Then Return "Mavi"
        If renkLower.Contains("kırmızı") OrElse renkLower.Contains("kirmizi") Then Return "Kırmızı"
        If renkLower.Contains("yeşil") OrElse renkLower.Contains("yesil") Then Return "Yeşil"
        If renkLower.Contains("sarı") OrElse renkLower.Contains("sari") Then Return "Sarı"
        If renkLower.Contains("pembe") Then Return "Pembe"
        If renkLower.Contains("mor") Then Return "Mor"
        If renkLower.Contains("turuncu") Then Return "Turuncu"
        If renkLower.Contains("gri") Then Return "Gri"
        If renkLower.Contains("kahve") OrElse renkLower.Contains("kahverengi") Then Return "Kahverengi"
        If renkLower.Contains("bej") Then Return "Bej"
        If renkLower.Contains("lacivert") Then Return "Lacivert"
        If renkLower.Contains("ekru") Then Return "Ekru"
        
        Return "Çok Renkli"
    End Function
    
    ''' <summary>
    ''' Alt-Üst Takım tespit eder
    ''' </summary>
    Public Shared Function TespitAltUstTakim(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("takım") OrElse kaynak.Contains("takim") OrElse kaynak.Contains("set") Then
            If kaynak.Contains("pijama") Then Return "Pijama Takımı"
            If kaynak.Contains("eşofman") OrElse kaynak.Contains("esofman") Then Return "Eşofman Takımı"
            Return "T-shirt-Şort"
        End If
        
        If kaynak.Contains("t-shirt") OrElse kaynak.Contains("tişört") Then Return "T-shirt"
        If kaynak.Contains("şort") OrElse kaynak.Contains("sort") Then Return "Şort"
        If kaynak.Contains("pantolon") Then Return "Pantolon"
        
        Return "T-shirt-Şort"
    End Function
    
    ''' <summary>
    ''' Baskı/Nakış tekniği tespit eder
    ''' </summary>
    Public Shared Function TespitBaskiTeknik(urunAdi As String) As String
        Dim kaynak As String = urunAdi.ToLower()
        
        If kaynak.Contains("nakış") OrElse kaynak.Contains("nakis") Then Return "Nakış"
        If kaynak.Contains("serigrafi") Then Return "Serigrafi"
        If kaynak.Contains("transfer") Then Return "Transfer Baskı"
        
        Return "Dijital Baskı"
    End Function
    
    ''' <summary>
    ''' Dokuma tipi tespit eder
    ''' </summary>
    Public Shared Function TespitDokumaTipi(kumas As String) As String
        Dim kumasLower As String = kumas.ToLower()
        
        If kumasLower.Contains("penye") Then Return "2 iplik penye"
        If kumasLower.Contains("süprem") Then Return "Süprem"
        If kumasLower.Contains("interlok") Then Return "İnterlok"
        If kumasLower.Contains("ribana") Then Return "Ribana"
        
        Return "2 iplik penye"
    End Function
    
    ''' <summary>
    ''' Ek özellik tespit eder
    ''' </summary>
    Public Shared Function TespitEkOzellik(urunAdi As String, marka As String) As String
        Dim kaynak As String = urunAdi.ToLower()
        
        If kaynak.Contains("lisans") OrElse Not String.IsNullOrEmpty(marka) Then Return "Lisanslı"
        
        Return "Lisanssız"
    End Function
    
    ''' <summary>
    ''' Kapama şekli tespit eder
    ''' </summary>
    Public Shared Function TespitKapamaSekli(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("düğme") OrElse kaynak.Contains("dugme") Then Return "Düğmeli"
        If kaynak.Contains("fermuar") OrElse kaynak.Contains("zip") Then Return "Fermuarlı"
        If kaynak.Contains("çıtçıt") OrElse kaynak.Contains("citcit") Then Return "Çıtçıtlı"
        If kaynak.Contains("bağcık") OrElse kaynak.Contains("bagcik") Then Return "Bağlama / Bağcık"
        If kaynak.Contains("lastik") Then Return "Lastikli"
        
        Return "Bağlama / Bağcık"
    End Function
    
    ''' <summary>
    ''' Kol boyu tespit eder
    ''' </summary>
    Public Shared Function TespitKolBoyu(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("kısa kol") OrElse kaynak.Contains("kisa kol") Then Return "Kısa"
        If kaynak.Contains("uzun kol") Then Return "Uzun"
        If kaynak.Contains("kolsuz") Then Return "Kolsuz"
        If kaynak.Contains("3/4") OrElse kaynak.Contains("üç çeyrek") Then Return "3/4 Kol"
        
        ' Sezona göre varsayılan
        If kaynak.Contains("yaz") OrElse kaynak.Contains("t-shirt") Then Return "Kısa"
        If kaynak.Contains("kış") OrElse kaynak.Contains("polar") Then Return "Uzun"
        
        Return "Kısa"
    End Function
    
    ''' <summary>
    ''' Koleksiyon tespit eder
    ''' </summary>
    Public Shared Function TespitKoleksiyon(urunAdi As String, marka As String) As String
        If Not String.IsNullOrEmpty(marka) Then
            Return "Lisanslı"
        End If
        Return "Standart"
    End Function
    
    ''' <summary>
    ''' Paça tipi tespit eder
    ''' </summary>
    Public Shared Function TespitPacaTipi(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("dar paça") Then Return "Dar Paça"
        If kaynak.Contains("geniş paça") OrElse kaynak.Contains("genis paca") Then Return "Geniş Paça"
        If kaynak.Contains("lastikli paça") Then Return "Lastikli Paça"
        
        Return "Geniş Paça"
    End Function
    
    ''' <summary>
    ''' Paket içeriği tespit eder
    ''' </summary>
    Public Shared Function TespitPaketIcerigi(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("3'lü") OrElse kaynak.Contains("3lü") OrElse kaynak.Contains("3 lü") Then Return "3'lü"
        If kaynak.Contains("2'li") OrElse kaynak.Contains("2li") OrElse kaynak.Contains("2 li") OrElse 
           kaynak.Contains("takım") OrElse kaynak.Contains("set") Then Return "2'li"
        If kaynak.Contains("4'lü") OrElse kaynak.Contains("4lü") Then Return "4'lü"
        If kaynak.Contains("5'li") OrElse kaynak.Contains("5li") Then Return "5'li"
        
        Return "Tekli"
    End Function
    
    ''' <summary>
    ''' Parça sayısı tespit eder
    ''' </summary>
    Public Shared Function TespitParcaSayisi(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("3'lü") OrElse kaynak.Contains("3lü") Then Return "3"
        If kaynak.Contains("2'li") OrElse kaynak.Contains("2li") OrElse kaynak.Contains("takım") Then Return "2"
        If kaynak.Contains("4'lü") Then Return "4"
        If kaynak.Contains("5'li") Then Return "5"
        
        Return "1"
    End Function
    
    ''' <summary>
    ''' Persona tespit eder
    ''' </summary>
    Public Shared Function TespitPersona(yasGrubu As String) As String
        If yasGrubu.ToLower().Contains("bebek") OrElse yasGrubu.ToLower().Contains("çocuk") Then
            Return "Childish"
        End If
        Return "Casual"
    End Function
    
    ''' <summary>
    ''' Ürün detayı tespit eder
    ''' </summary>
    Public Shared Function TespitUrunDetayi(urunAdi As String, kumas As String) As String
        Dim kaynak As String = urunAdi.ToLower()
        
        If kaynak.Contains("baskı") OrElse kaynak.Contains("print") Then Return "Baskı Detaylı"
        If kaynak.Contains("nakış") Then Return "Nakış Detaylı"
        If kaynak.Contains("aplikeli") Then Return "Aplike Detaylı"
        
        If kumas.ToLower().Contains("dokuma") Then Return "Dokuma Detaylı"
        
        Return "Dokuma Detaylı"
    End Function
    
    ''' <summary>
    ''' Yaka tipi tespit eder
    ''' </summary>
    Public Shared Function TespitYakaTipi(urunAdi As String, kategori As String) As String
        Dim kaynak As String = (urunAdi & " " & kategori).ToLower()
        
        If kaynak.Contains("v yaka") Then Return "V Yaka"
        If kaynak.Contains("polo") Then Return "Polo Yaka"
        If kaynak.Contains("kapüşon") OrElse kaynak.Contains("kapuson") Then Return "Kapüşonlu"
        If kaynak.Contains("balıkçı") OrElse kaynak.Contains("balikci") Then Return "Balıkçı Yaka"
        If kaynak.Contains("dik yaka") Then Return "Dik Yaka"
        If kaynak.Contains("gömlek yaka") Then Return "Gömlek Yaka"
        
        Return "Bisiklet Yaka"
    End Function

#End Region

#Region "API Format Dönüşümü"

    ''' <summary>
    ''' Trendyol API formatına dönüştürür
    ''' </summary>
    Public Shared Function ToTrendyolAPIFormat(ozellikler As Dictionary(Of String, Object)) As List(Of Dictionary(Of String, Object))
        Dim attributes As New List(Of Dictionary(Of String, Object))
        
        ' Her özelliği Trendyol attribute formatına çevir
        ' Format: {"attributeId": 123, "attributeValueId": 456} veya {"attributeId": 123, "customAttributeValue": "değer"}
        
        ' NOT: Gerçek attributeId'ler Trendyol kategori API'sinden alınmalı
        ' Bu örnek yapıyı göstermek için
        
        If ozellikler.ContainsKey("cinsiyet") Then
            attributes.Add(New Dictionary(Of String, Object) From {
                {"attributeName", "Cinsiyet"},
                {"attributeValue", ozellikler("cinsiyet")}
            })
        End If
        
        If ozellikler.ContainsKey("yasGrubu") Then
            attributes.Add(New Dictionary(Of String, Object) From {
                {"attributeName", "Yaş Grubu"},
                {"attributeValue", ozellikler("yasGrubu")}
            })
        End If
        
        If ozellikler.ContainsKey("materyal") Then
            attributes.Add(New Dictionary(Of String, Object) From {
                {"attributeName", "Materyal"},
                {"attributeValue", ozellikler("materyal")}
            })
        End If
        
        If ozellikler.ContainsKey("mensei") Then
            attributes.Add(New Dictionary(Of String, Object) From {
                {"attributeName", "Menşei"},
                {"attributeValue", ozellikler("mensei")}
            })
        End If
        
        ' Diğer tüm özellikler...
        For Each kvp As KeyValuePair(Of String, Object) In ozellikler
            ' Bu attribute zaten eklenmiş mi kontrol et
            Dim mevcutMu As Boolean = False
            For Each attr As Dictionary(Of String, Object) In attributes
                If attr("attributeName").ToString().ToLower().Replace(" ", "") = kvp.Key.ToLower() Then
                    mevcutMu = True
                    Exit For
                End If
            Next
            
            If Not mevcutMu Then
                attributes.Add(New Dictionary(Of String, Object) From {
                    {"attributeName", FormatAttributeName(kvp.Key)},
                    {"attributeValue", kvp.Value}
                })
            End If
        Next
        
        Return attributes
    End Function
    
    ''' <summary>
    ''' Attribute adını formatlar
    ''' </summary>
    Private Shared Function FormatAttributeName(key As String) As String
        ' camelCase'i "Normal İsim" formatına çevir
        Dim result As String = ""
        For Each ch As Char In key
            If Char.IsUpper(ch) AndAlso result.Length > 0 Then
                result &= " "
            End If
            result &= ch
        Next
        
        ' İlk harfi büyük yap
        If result.Length > 0 Then
            result = Char.ToUpper(result(0)) & result.Substring(1)
        End If
        
        Return result
    End Function

#End Region

End Class
