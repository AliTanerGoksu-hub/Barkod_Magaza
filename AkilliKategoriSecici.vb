' ============================================================================
' AKILLI KATEGORİ SEÇİCİ - VB.NET
' ============================================================================
' Birden fazla kaynaktan (Excel, Veritabanı, Trendyol) gelen kategorileri
' ürün adına göre karşılaştırarak en uygun olanı seçer.
' ============================================================================

Imports System.Collections.Generic
Imports System.Linq

''' <summary>
''' Farklı kaynaklardan gelen kategorileri akıllıca karşılaştırır ve en uygun olanı seçer
''' </summary>
Public Class AkilliKategoriSecici
    
    ''' <summary>
    ''' Birden fazla kaynaktan gelen sonuçları karşılaştırır ve en uygun olanı seçer
    ''' </summary>
    Public Shared Function EnUygunKategoriyiSec(
        urunAdi As String,
        Optional excelSonuc As TrendyolScraperSonuc = Nothing,
        Optional veritabaniSonuc As TrendyolScraperSonuc = Nothing,
        Optional trendyolSonuc As TrendyolScraperSonuc = Nothing) As AkilliSecimSonuc
        
        Dim sonuc As New AkilliSecimSonuc()
        sonuc.Basarili = False
        
        ' Geçerli sonuçları topla
        Dim gecerliSonuclar As New List(Of KaynakSonuc)
        
        If excelSonuc IsNot Nothing AndAlso excelSonuc.Basarili AndAlso excelSonuc.Kategoriler IsNot Nothing AndAlso excelSonuc.Kategoriler.Count > 0 Then
            gecerliSonuclar.Add(New KaynakSonuc() With {.Kaynak = "EXCEL", .Sonuc = excelSonuc, .Skor = 0})
        End If
        
        If veritabaniSonuc IsNot Nothing AndAlso veritabaniSonuc.Basarili AndAlso veritabaniSonuc.Kategoriler IsNot Nothing AndAlso veritabaniSonuc.Kategoriler.Count > 0 Then
            gecerliSonuclar.Add(New KaynakSonuc() With {.Kaynak = "DATABASE", .Sonuc = veritabaniSonuc, .Skor = 0})
        End If
        
        If trendyolSonuc IsNot Nothing AndAlso trendyolSonuc.Basarili AndAlso trendyolSonuc.Kategoriler IsNot Nothing AndAlso trendyolSonuc.Kategoriler.Count > 0 Then
            gecerliSonuclar.Add(New KaynakSonuc() With {.Kaynak = "TRENDYOL", .Sonuc = trendyolSonuc, .Skor = 0})
        End If
        
        ' Hiç geçerli sonuç yoksa
        If gecerliSonuclar.Count = 0 Then
            sonuc.SecimNedeni = "Hiçbir kaynaktan geçerli kategori bulunamadı"
            Return sonuc
        End If
        
        ' Tek sonuç varsa direkt döndür
        If gecerliSonuclar.Count = 1 Then
            sonuc.Basarili = True
            sonuc.SecilenSonuc = gecerliSonuclar(0).Sonuc
            sonuc.SecilenKaynak = gecerliSonuclar(0).Kaynak
            sonuc.SecimNedeni = "Tek kaynak mevcut: " & gecerliSonuclar(0).Kaynak
            Return sonuc
        End If
        
        ' Birden fazla sonuç var - akıllı seçim yap
        Dim urunBilgi As UrunAdiAnaliz = UrunAdiniAnalizeEt(urunAdi)
        
        ' Her sonuç için skor hesapla
        For Each ks As KaynakSonuc In gecerliSonuclar
            ks.Skor = KategoriSkoruHesapla(urunBilgi, ks.Sonuc)
            ks.DetayliLog = ks.Kaynak & ": Skor=" & ks.Skor.ToString("F2") & ", Kategoriler=" & String.Join(" / ", ks.Sonuc.Kategoriler)
        Next
        
        ' En yüksek skorlu sonucu seç
        gecerliSonuclar = gecerliSonuclar.OrderByDescending(Function(x) x.Skor).ToList()
        
        Dim enIyi As KaynakSonuc = gecerliSonuclar(0)
        
        sonuc.Basarili = True
        sonuc.SecilenSonuc = enIyi.Sonuc
        sonuc.SecilenKaynak = enIyi.Kaynak
        
        ' Seçim nedenini oluştur
        Dim nedenler As New List(Of String)
        nedenler.Add("En yüksek skor: " & enIyi.Skor.ToString("F2"))
        
        If Not String.IsNullOrEmpty(urunBilgi.UrunTipi) Then
            Dim kategoriUyumu As Boolean = KategorideUrunTipiVar(enIyi.Sonuc.Kategoriler, urunBilgi.UrunTipi)
            If kategoriUyumu Then
                nedenler.Add("Ürün tipi uyumu: " & urunBilgi.UrunTipi)
            End If
        End If
        
        If Not String.IsNullOrEmpty(urunBilgi.Cinsiyet) Then
            Dim cinsiyetUyumu As Boolean = KategorideCinsiyetVar(enIyi.Sonuc.Kategoriler, urunBilgi.Cinsiyet)
            If cinsiyetUyumu Then
                nedenler.Add("Cinsiyet uyumu: " & urunBilgi.Cinsiyet)
            End If
        End If
        
        sonuc.SecimNedeni = String.Join(", ", nedenler)
        
        ' Karşılaştırma detaylarını ekle
        sonuc.KarsilastirmaDetayi = New List(Of String)
        For Each ks As KaynakSonuc In gecerliSonuclar
            sonuc.KarsilastirmaDetayi.Add(ks.DetayliLog)
        Next
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' Ürün adını analiz ederek ürün tipi, cinsiyet vb. bilgileri çıkarır
    ''' </summary>
    Private Shared Function UrunAdiniAnalizeEt(urunAdi As String) As UrunAdiAnaliz
        Dim analiz As New UrunAdiAnaliz()
        
        If String.IsNullOrEmpty(urunAdi) Then Return analiz
        
        Dim normalized As String = NormalizeText(urunAdi.ToUpper())
        
        ' Cinsiyet bul - ÖNEMLİ: Spesifik olanlar önce! (KIZ BEBEK önce, KIZ sonra)
        Dim cinsiyetler() As String = {
            "ANNE-KIZ", "ANNE KIZ", "BABA-OGUL", "BABA OGUL",
            "KIZ COCUK", "ERKEK COCUK", "KIZ BEBEK", "ERKEK BEBEK",
            "KADIN", "ERKEK", "BEBEK", "COCUK"
        }
        
        For Each c As String In cinsiyetler
            Dim cNorm As String = NormalizeText(c)
            If normalized.Contains(cNorm) Then
                analiz.Cinsiyet = c
                Exit For
            End If
        Next
        
        ' Ürün tipi bul
        Dim urunTipleri() As String = {
            "ESOFMAN TAKIM", "ESOFMAN ALT", "ESOFMAN UST", "ESOFMAN",
            "PIJAMA TAKIM", "PIJAMA ALT", "PIJAMA UST", "PIJAMA",
            "BERMUDA", "TISORT", "SORT", "MONT", "KABAN", "YELEK",
            "PANTOLON", "TAYT", "KAPRI", "SWEAT", "HIRKA", "KAZAK",
            "BODY", "TULUM", "ATLET", "GOMLEK", "ELBISE", "ETEK", "CEKET"
        }
        
        For Each tip As String In urunTipleri
            If normalized.Contains(NormalizeText(tip)) Then
                analiz.UrunTipi = tip
                Exit For
            End If
        Next
        
        Return analiz
    End Function
    
    ''' <summary>
    ''' Kategori listesinin ürün bilgilerine ne kadar uyduğunu hesaplar (0-1 arası skor)
    ''' </summary>
    Private Shared Function KategoriSkoruHesapla(urunBilgi As UrunAdiAnaliz, sonuc As TrendyolScraperSonuc) As Double
        Dim skor As Double = 0.0
        
        If sonuc Is Nothing OrElse sonuc.Kategoriler Is Nothing OrElse sonuc.Kategoriler.Count = 0 Then
            Return 0.0
        End If
        
        ' 1. Ürün tipi uyumu (en önemli - 0.5 puan)
        If Not String.IsNullOrEmpty(urunBilgi.UrunTipi) Then
            If KategorideUrunTipiVar(sonuc.Kategoriler, urunBilgi.UrunTipi) Then
                skor += 0.5
            End If
        Else
            skor += 0.25  ' Ürün tipi yoksa orta puan
        End If
        
        ' 2. Cinsiyet uyumu (0.3 puan)
        If Not String.IsNullOrEmpty(urunBilgi.Cinsiyet) Then
            If KategorideCinsiyetVar(sonuc.Kategoriler, urunBilgi.Cinsiyet) Then
                skor += 0.3
            End If
        Else
            skor += 0.15  ' Cinsiyet yoksa orta puan
        End If
        
        ' 3. Kategori derinliği (0.2 puan - daha fazla kategori daha iyi)
        Dim derinlikPuani As Double = Math.Min(sonuc.Kategoriler.Count / 5.0, 1.0) * 0.2
        skor += derinlikPuani
        
        ' 4. Orijinal skor bonus (varsa)
        If sonuc.Skor > 0 Then
            skor = skor * 0.8 + sonuc.Skor * 0.2
        End If
        
        Return Math.Min(skor, 1.0)
    End Function
    
    ''' <summary>
    ''' Kategorilerde ürün tipi var mı kontrol eder
    ''' </summary>
    Private Shared Function KategorideUrunTipiVar(kategoriler As List(Of String), urunTipi As String) As Boolean
        If kategoriler Is Nothing OrElse String.IsNullOrEmpty(urunTipi) Then Return False
        
        Dim normalizedTip As String = NormalizeText(urunTipi)
        
        For Each kat As String In kategoriler
            Dim normalizedKat As String = NormalizeText(kat)
            If normalizedKat.Contains(normalizedTip) Then
                Return True
            End If
        Next
        
        Return False
    End Function
    
    ''' <summary>
    ''' Kategorilerde cinsiyet var mı kontrol eder
    ''' </summary>
    Private Shared Function KategorideCinsiyetVar(kategoriler As List(Of String), cinsiyet As String) As Boolean
        If kategoriler Is Nothing OrElse String.IsNullOrEmpty(cinsiyet) Then Return False
        
        Dim normalizedCinsiyet As String = NormalizeText(cinsiyet)
        
        For Each kat As String In kategoriler
            Dim normalizedKat As String = NormalizeText(kat)
            If normalizedKat.Contains(normalizedCinsiyet) Then
                Return True
            End If
        Next
        
        Return False
    End Function
    
    ''' <summary>
    ''' Türkçe karakterleri normalize eder
    ''' </summary>
    Private Shared Function NormalizeText(text As String) As String
        If String.IsNullOrEmpty(text) Then Return ""
        
        Return text.ToUpper() _
            .Replace("İ", "I") _
            .Replace("Ş", "S") _
            .Replace("Ğ", "G") _
            .Replace("Ü", "U") _
            .Replace("Ö", "O") _
            .Replace("Ç", "C") _
            .Replace("ı", "I") _
            .Replace("ş", "S") _
            .Replace("ğ", "G") _
            .Replace("ü", "U") _
            .Replace("ö", "O") _
            .Replace("ç", "C")
    End Function
    
End Class

''' <summary>
''' Akıllı seçim sonucu
''' </summary>
Public Class AkilliSecimSonuc
    Public Property Basarili As Boolean = False
    Public Property SecilenSonuc As TrendyolScraperSonuc = Nothing
    Public Property SecilenKaynak As String = ""
    Public Property SecimNedeni As String = ""
    Public Property KarsilastirmaDetayi As List(Of String) = Nothing
End Class

''' <summary>
''' Ürün adı analiz sonucu
''' </summary>
Public Class UrunAdiAnaliz
    Public Property Cinsiyet As String = ""
    Public Property UrunTipi As String = ""
End Class

''' <summary>
''' Kaynak ve sonuç ikilisi
''' </summary>
Public Class KaynakSonuc
    Public Property Kaynak As String = ""
    Public Property Sonuc As TrendyolScraperSonuc = Nothing
    Public Property Skor As Double = 0
    Public Property DetayliLog As String = ""
End Class
