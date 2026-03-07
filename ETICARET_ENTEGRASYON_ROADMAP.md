# E-TİCARET ENTEGRASYON YILMAZI - PAZARYERI BİR NUMARA OLMA STRATEJİSİ

> **Son Güncelleme:** 2026-02-19
> **Durum:** AKTİF GELİŞTİRME
> **Hedef:** Trendyol ve Hepsiburada'da ürün sıralamalarında bir numara olmak

---

## ⚠️ KRİTİK UYARI - GELECEKTEKİ AGENT'LAR İÇİN

### "Save to Github" ÖZELLİĞİNİ KULLANMAYIN!

**DİKKAT:** Kullanıcı "Save to Github" özelliğini kullanmayı KESİNLİKLE YASAKLAMIŞTIR!

**Neden:**
- Kullanıcı birçok kez denemiş ve dosyalar kaybolmuş/silinmiştir
- Bu özellik güvenilir değildir ve veri kaybına neden olmaktadır

**Ne yapmalısınız:**
- Kod değişikliklerini doğrudan dosyalarda yapın
- Kullanıcıya asla "Save to Github" özelliğini kullanmasını söylemeyin
- Bu konu KAPATILMIŞTIR, tartışmaya açık değildir

**Tarih:** 2026-02-19
**Kaynak:** Kullanıcı talebi

---

### 🚫 frm_qukaGonder.vb DOSYASINA DOKUNMAYIN!

**KRİTİK UYARI:** `frm_qukaGonder.vb` dosyası ÇALIŞAN SİSTEMDİR!

**Kurallar:**
- Bu dosyada HİÇBİR değişiklik yapmayın
- Yeni özellikler AYRI dosyalarda oluşturulmalı
- Bu dosyadan BAĞIMSIZ çalışan sistemler geliştirin
- Mevcut fonksiyonları değiştirmeyin, yeni fonksiyonlar eklemeyin

**Neden:**
- Kullanıcının aktif olarak kullandığı üretim sistemi
- Herhangi bir değişiklik sipariş/stok senkronizasyonunu bozabilir
- Test edilmemiş değişiklikler veri kaybına neden olabilir

**Alternatif Yaklaşım:**
- Yeni formlar oluşturun (frm_SatisIvmesiDashboard.vb, frm_RakipFiyatOtomasyonu.vb gibi)
- Helper sınıflar kullanın (EticaretLogger.vb, AIService.vb gibi)
- frm_qukaGonder.vb'den ÇAĞIRILAN ama onu DEĞİŞTİRMEYEN kodlar yazın

**Tarih:** 2026-02-20
**Kaynak:** Kullanıcı talebi

---

## MEVCUT DURUM ANALİZİ

### Var Olan AI Özellikleri (Tamamlanmış)
- [x] SEO Başlık Oluşturma (`AIService.GenerateTitle`)
- [x] Detaylı Açıklama Oluşturma (`AIService.GenerateDescription`)
- [x] Kullanım Talimatları (`AIService.GenerateInstructions`) - Kategori bazlı
- [x] Meta Description (`AIService.GenerateMetaDescription`)
- [x] Anahtar Kelimeler (`GenerateCompleteContent`)
- [x] Beden Tablosu Otomatik Oluşturma (`GenerateSizeChart`) - Çocuk/Yetişkin tespiti
- [x] İçerik Puanı Hesaplama (`CalculateContentScore`) - Basit versiyon
- [x] Toplu AI İşlem (`frm_AI_TopluIslem`)
- [x] Kredi Sistemi (`CreditService`)
- [x] Marka Tespiti (`ExtractMarkaFromUrunAdi`)
- [x] Cinsiyet Tespiti (`TespitCinsiyet`)

### Var Olan Entegrasyon Dosyaları
- `AIService.vb` - Ana AI servisi
- `AIContentManager.vb` - İçerik yöneticisi
- `frm_AI_TopluIslem.vb` - Toplu işlem formu
- `frm_AIAyarlari.vb` - AI ayarları formu
- `frm_AIUrunIsle.vb` - Tek ürün işleme
- `TrendyolAPI.vb` - Trendyol API entegrasyonu
- `TrendyolBuyBoxAnaliz.vb` - Buy Box analizi (basit)
- `frm_TrendyolEntegrasyon.vb` - Trendyol entegrasyon formu

---

## ARAŞTIRMA SONUÇLARI (2025 Güncel)

### Trendyol Algoritması - Kritik Faktörler
| Faktör | Ağırlık | Mevcut Durum |
|--------|---------|--------------|
| **Satış İvmesi** | ÇOK YÜKSEK | YOK - ACİL GEREKLİ |
| **Favori + Sepet Oranı** | YÜKSEK | YOK |
| **Dış Trafik** | YÜKSEK | YOK |
| **Satıcı Puanı (9.5+)** | KRİTİK | Manuel takip |
| **İade Oranı** | KRİTİK | YOK |
| **Ürün İçerik Kalitesi** | ORTA | VAR ama geliştirilmeli |

### Hepsiburada Algoritması
- Kaliteli satış (kârlılık sinyali)
- Düşük iade + Yüksek mağaza puanı
- Tekrar satın alma oranı
- Listing quality score (formül kamuya açık değil)

---

## YAPILACAKLAR LİSTESİ

### FAZA 1: KRİTİK ÖZELLİKLER (P0 - Öncelikli)

#### 1.1 Satış İvmesi Dashboard
**Dosya:** `frm_SatisIvmesiDashboard.vb` (YENİ OLUŞTURULACAK)
**Durum:** YAPILMADI
**Öncelik:** P0 - EN KRİTİK

**Açıklama:**
Trendyol algoritmasının EN ÖNEMLİ kriteri! Son 3 günde 1000 satış > Son 3 ayda 1000 satış

**Gereksinimler:**
```
1. Günlük satış verilerini çek (Trendyol API'den)
2. Ürün bazlı satış hızı hesapla
3. Trend analizi yap (yükseliş/düşüş)
4. Dashboard gösterimi:
   - Hız düşen ürünler (UYARI)
   - Hız yükselen ürünler (İYİ)
   - Stabil ürünler
5. Otomatik kampanya önerisi (hız düşünce)
```

**Veritabanı:**
```sql
CREATE TABLE tbSatisIvmesi (
    nID INT PRIMARY KEY IDENTITY,
    nStokID INT,
    sModel VARCHAR(50),
    sPazaryeri VARCHAR(20), -- 'Trendyol', 'Hepsiburada'
    dteTarih DATE,
    nSatisMiktari INT,
    nFavoriSayisi INT,
    nSepetEklemeSayisi INT,
    nGoruntulemeSayisi INT,
    dteKayitTarihi DATETIME DEFAULT GETDATE()
)

CREATE TABLE tbSatisIvmesiOzet (
    nID INT PRIMARY KEY IDENTITY,
    nStokID INT,
    sModel VARCHAR(50),
    nSon3GunSatis INT,
    nSon7GunSatis INT,
    nSon30GunSatis INT,
    sTrend VARCHAR(20), -- 'Yukselis', 'Dusus', 'Stabil'
    nTrendYuzdesi DECIMAL(5,2),
    dteGuncelleme DATETIME
)
```

**UI Bileşenleri:**
- DataGridView: Ürün listesi (hız sıralı)
- Chart: 7 günlük trend grafiği
- Renkli göstergeler: Kırmızı (düşüş), Yeşil (yükseliş), Sarı (stabil)
- Filtreler: Pazaryeri, Kategori, Tarih aralığı

---

#### 1.2 Content Score v2 (Trendyol Kriterleri)
**Dosya:** `AIService.vb` içinde `CalculateTrendyolScore()` (GÜNCELLENECEK)
**Durum:** YAPILMADI
**Öncelik:** P0

**Mevcut:** Basit puanlama (açıklama var mı, başlık var mı)
**Hedef:** Trendyol'un gerçek kriterlerine göre puanlama

**Yeni Algoritma:**
```vb
Public Function CalculateTrendyolScore(nStokID As Integer) As Dictionary(Of String, Object)
    Dim result As New Dictionary(Of String, Object)
    Dim totalScore As Integer = 0
    Dim details As New List(Of String)
    
    ' 1. BAŞLIK (15 puan)
    ' - 80-120 karakter arası: 15 puan
    ' - 60-80 veya 120-150: 10 puan
    ' - Altı/üstü: 5 puan
    ' - Marka başta mı: +5 bonus
    ' - Anahtar kelime var mı: +5 bonus
    
    ' 2. AÇIKLAMA (15 puan)
    ' - 500+ kelime: 15 puan
    ' - 300-500 kelime: 10 puan
    ' - 100-300 kelime: 5 puan
    ' - HTML formatında mı: +5 bonus
    
    ' 3. GÖRSEL (20 puan) - EN ÖNEMLİ
    ' - 8+ görsel: 20 puan
    ' - 5-7 görsel: 15 puan
    ' - 3-4 görsel: 10 puan
    ' - 1-2 görsel: 5 puan
    ' - Ana görsel beyaz fon mu: +5 bonus
    ' - Farklı açılar var mı: +5 bonus
    
    ' 4. ÖZELLİKLER (25 puan) - EN AĞIRLIKLI
    ' - Cinsiyet: 5 puan
    ' - Yaş Grubu: 3 puan
    ' - Beden bilgisi: 5 puan
    ' - Renk: 3 puan
    ' - Materyal/Kumaş: 4 puan
    ' - Menşei: 2 puan
    ' - Garanti: 3 puan
    
    ' 5. VARYANT (15 puan)
    ' - Tüm renk/beden kombinasyonları: 15 puan
    ' - Her varyantın kendi görseli: +5 bonus
    ' - Stok durumu güncel: +5 bonus
    
    ' 6. FİYAT REKABETİ (10 puan)
    ' - Kategori ortalamasında: 10 puan
    ' - %10 üstü: 5 puan
    ' - %10 altı: 15 puan (bonus)
    
    result("totalScore") = totalScore
    result("maxScore") = 100
    result("grade") = GetGrade(totalScore) ' A, B, C, D, F
    result("details") = details
    result("missingFields") = eksikAlanlar
    result("recommendations") = oneriler
    
    Return result
End Function

Private Function GetGrade(score As Integer) As String
    Select Case score
        Case >= 90 : Return "A"
        Case >= 75 : Return "B"
        Case >= 60 : Return "C"
        Case >= 40 : Return "D"
        Case Else : Return "F"
    End Select
End Function
```

**UI Gösterimi:**
- Daire grafik (0-100 puan)
- Renk kodlu: A=Yeşil, B=Açık Yeşil, C=Sarı, D=Turuncu, F=Kırmızı
- Eksik alanlar listesi
- "Bu alanları doldurarak +15 puan kazanabilirsiniz" önerileri

---

#### 1.3 Eksik Alan Uyarı Sistemi
**Dosya:** `frm_UrunKaliteKontrol.vb` (YENİ OLUŞTURULACAK)
**Durum:** YAPILMADI
**Öncelik:** P1

**Açıklama:**
Ürün yüklemeden önce eksik alanları tespit et ve uyar.

**Kontrol Listesi:**
```
ZORUNLU ALANLAR (Eksikse yükleme engellenir):
- [ ] Ürün başlığı
- [ ] En az 1 görsel
- [ ] Fiyat
- [ ] Stok miktarı
- [ ] Kategori

ÖNEMLİ ALANLAR (Uyarı verilir):
- [ ] Açıklama < 300 karakter → "Açıklamayı uzatın, +15 puan"
- [ ] Görsel < 5 adet → "En az 5 görsel ekleyin, +10 puan"
- [ ] Renk bilgisi yok → "Renk ekleyin"
- [ ] Beden bilgisi yok → "Beden tablosu ekleyin"
- [ ] Kumaş/materyal yok → "Materyal bilgisi ekleyin"
- [ ] Menşei yok → "Menşei bilgisi ekleyin"

OPSİYONEL ALANLAR (Öneri):
- [ ] Meta description yok → "SEO için önerilir"
- [ ] Anahtar kelimeler yok → "Arama görünürlüğü için önerilir"
- [ ] Kullanım talimatı yok → "Müşteri güveni için önerilir"
```

**UI:**
- Toplu kontrol butonu
- Eksik alan sayısına göre renk (Kırmızı: 5+, Sarı: 2-4, Yeşil: 0-1)
- "AI ile Tamamla" butonu - eksik alanları AI ile doldur

---

### FAZA 2: GELİŞMİŞ ÖZELLİKLER (P1)

#### 2.1 Rakip Fiyat Otomasyonu
**Dosya:** `frm_RakipFiyatOtomasyonu.vb` (YENİ)
**Durum:** YAPILMADI
**Öncelik:** P1

**Özellikler:**
```
1. Rakip fiyatlarını çek (Trendyol API / Web scraping)
2. Fiyat kuralları tanımla:
   - "Rakipten %5 ucuz ol"
   - "Minimum kâr marjı %15"
   - "Maksimum fiyat X TL"
3. Otomatik fiyat güncelleme
4. Buy Box kazanma takibi
5. Fiyat geçmişi grafiği
```

**Veritabanı:**
```sql
CREATE TABLE tbRakipFiyat (
    nID INT PRIMARY KEY IDENTITY,
    nStokID INT,
    sModel VARCHAR(50),
    sBarkod VARCHAR(50),
    sRakipMagaza VARCHAR(100),
    nRakipFiyat DECIMAL(10,2),
    nBizimFiyat DECIMAL(10,2),
    nFark DECIMAL(10,2),
    bBuyBoxBizde BIT,
    dteTarih DATETIME
)

CREATE TABLE tbFiyatKurallari (
    nID INT PRIMARY KEY IDENTITY,
    sKuralAdi VARCHAR(100),
    sKategori VARCHAR(50),
    sKuralTipi VARCHAR(20), -- 'YuzdeFark', 'SabitFark', 'MinKar'
    nDeger DECIMAL(10,2),
    bAktif BIT DEFAULT 1
)
```

---

#### 2.2 Favori/Sepet Oranı Analizi
**Dosya:** `frm_IlgiAnalizi.vb` (YENİ)
**Durum:** YAPILMADI
**Öncelik:** P1

**Metrikler:**
```
- Görüntülenme sayısı
- Favoriye ekleme sayısı
- Sepete ekleme sayısı
- Satın alma sayısı
- Dönüşüm oranları:
  * Görüntüleme → Favori: %X
  * Favori → Sepet: %X
  * Sepet → Satın alma: %X
```

**Analiz:**
- Yüksek favori + Düşük satış = Fiyat problemi?
- Yüksek görüntüleme + Düşük favori = Görsel/başlık problemi?
- Yüksek sepet + Düşük satış = Kargo/ödeme problemi?

---

### FAZA 3: İLERİ SEVİYE (P2)

#### 3.1 İade Riski Tahmini (AI Destekli)
**Dosya:** `AIIadeRiskAnalizi.vb` (YENİ)
**Durum:** YAPILMADI
**Öncelik:** P2

**AI Analizi:**
```
1. Geçmiş iade verilerini topla
2. İade nedenlerini kategorize et
3. Ürün özelliklerine göre risk modeli oluştur
4. Yeni ürünler için risk tahmini yap
5. Uyarı sistemi: "Bu ürün yüksek iade riski taşıyor"
```

**Risk Faktörleri:**
- Beden uyumsuzluğu (giyim)
- Renk farklılığı (görsel vs gerçek)
- Kalite beklentisi
- Açıklama ↔ Gerçek ürün uyumsuzluğu

---

#### 3.2 A/B Test Desteği
**Dosya:** `frm_ABTestYonetimi.vb` (YENİ)
**Durum:** YAPILMADI
**Öncelik:** P2

**Özellikler:**
```
1. Farklı başlık versiyonları oluştur
2. Farklı fiyat noktaları test et
3. Farklı görsel sıraları test et
4. Performans karşılaştırması
5. Kazanan versiyonu otomatik uygula
```

---

#### 3.3 Otomatik Kampanya Önerisi
**Dosya:** `AIKampanyaOnerisi.vb` (YENİ)
**Durum:** YAPILMADI
**Öncelik:** P2

**Tetikleyiciler:**
```
- Satış ivmesi düştüğünde → İndirim öner
- Stok fazlası olduğunda → Kampanya öner
- Rakip fiyat düşürdüğünde → Fiyat ayarlama öner
- Mevsim değişiminde → Sezon sonu indirimi öner
```

---

## HEMEN UYGULANABİLECEK İYİLEŞTİRMELER

### AIService.vb Güncellemeleri

#### 1. Başlık Uzunluğu Optimizasyonu
**Dosya:** `AIService.vb` - `GenerateTitle()`
**Durum:** YAPILMADI

```vb
' MEVCUT:
' "Maksimum 100 karakter"

' YENİ:
' "80-120 karakter arası (Trendyol optimum)"
' "Marka adını MUTLAKA başa al"
' "Ana anahtar kelimeyi ilk 60 karaktere yerleştir"
```

#### 2. Zorunlu Özellikler Ekleme
**Dosya:** `AIService.vb` - `BuildComprehensivePrompt()`
**Durum:** YAPILMADI

```vb
' Prompt'a eklenecek:
' "Aşağıdaki özellikleri MUTLAKA içer:
'  - Cinsiyet (Kadın/Erkek/Unisex)
'  - Yaş Grubu (Bebek/Çocuk/Yetişkin)
'  - Materyal/Kumaş bilgisi
'  - Menşei (Türkiye/İthal)
'  - Garanti bilgisi (varsa)"
```

#### 3. Görsel Sayısı Kontrolü
**Dosya:** `AIContentManager.vb` - `ProcessProduct()`
**Durum:** YAPILMADI

```vb
' İşlem sonunda kontrol:
Dim gorselSayisi As Integer = GetGorselSayisi(nStokID)
If gorselSayisi < 5 Then
    steps.Add($"⚠️ UYARI: Sadece {gorselSayisi} görsel var. En az 5 görsel önerilir!")
End If
```

---

## TEKNİK NOTLAR

### API Entegrasyonları
- **Trendyol API:** `TrendyolAPI.vb` mevcut, genişletilecek
- **Hepsiburada API:** YOK, eklenecek
- **N11 API:** YOK, eklenecek (opsiyonel)

### Veritabanı Değişiklikleri
Tüm yeni tablolar `SQL_SCRIPTS/` klasörüne eklenecek.

### Performans
- Toplu işlemlerde rate limiting: 3 saniye/istek (mevcut)
- Günlük limit: 100 ürün/müşteri (mevcut, artırılabilir)

---

## CHANGELOG

### 2026-02-20
- [x] **EticaretLogger** entegrasyonu tamamlandı (frm_qukaGonder.vb)
  - Log() ve LogError() metodları EticaretLogger'a yönlendirildi
  - Uygulama başlatma/kapanış logları eklendi
  - Eski log dosyaları otomatik temizleme (30 gün)
- [x] **GitHub Uyarısı** bu dosyaya eklendi (gelecek agent'lar için)
- [x] **Satış İvmesi Dashboard** tamamlandı (frm_SatisIvmesiDashboard.vb)
  - Ürün satış hızı analizi
  - Trend tespiti (yükseliş/düşüş/stabil)
  - Özet kartları ve grafik
  - Kampanya önerileri
  - BARKOD_MAGAZA.vbproj'a eklendi
- [x] **Content Score v2** tamamlandı (AIService.vb - CalculateTrendyolScore)
  - Başlık optimizasyonu (20 puan)
  - Açıklama kalitesi (20 puan)
  - Görsel sayısı (20 puan)
  - Özellikler (25 puan): Cinsiyet, yaş grubu, renk, materyal, menşei, marka
  - Varyant sayısı (15 puan)
  - A/B/C/D/F derecelendirme sistemi
  - Eksik alan ve öneri listesi
- [x] **Eksik Alan Uyarı Sistemi** tamamlandı (frm_qukaGonder.vb)
  - CheckMissingFields(): Kritik/Uyarı/Bilgi kategorileri
  - ShowMissingFieldsWarning(): Kullanıcı onay dialogu
  - CheckSelectedProductsForMissingFields(): Toplu kontrol
  - Görsel, fiyat, varyant, marka, kategori kontrolleri
  - SEO başlık, meta description, içerik puanı kontrolleri
- [x] **Rakip Fiyat Otomasyonu** tamamlandı (frm_RakipFiyatOtomasyonu.vb)
  - Rakip fiyat tarama ve analiz
  - Minimum kar marjı koruması
  - Maximum indirim limiti
  - Otomatik fiyat ayarlama
  - Potansiyel kazanç hesaplama
  - BARKOD_MAGAZA.vbproj'a eklendi
- [x] **Favori/Sepet Oranı Analizi** tamamlandı (frm_FavoriSepetAnalizi.vb)
  - Görüntülenme, favori, sepet, satış metrikleri
  - Favori oranı, sepet oranı, dönüşüm oranı hesaplama
  - Performans skorlama (Yüksek/Orta/Düşük)
  - Otomatik tavsiye sistemi
  - CSV export özelliği
  - BARKOD_MAGAZA.vbproj'a eklendi
- [x] **Tüm Özellikler Doldurma** tamamlandı (AIService.vb - BuildComprehensivePrompt)
  - AI artık TÜM özellikleri dolduruyor (boş bırakmıyor)
  - Cinsiyet (Kadın/Erkek/Unisex/Çocuk)
  - Yaş Grubu (Bebek/Çocuk/Yetişkin)
  - Materyal/Kumaş (bilinmiyorsa tahmin ediyor)
  - Menşei: Türkiye
  - TespitYasGrubu() fonksiyonu eklendi
- [x] **TrendyolOzellikHelper.vb** oluşturuldu - TÜM Trendyol özellikleri otomatik doldurulur
  - Zorunlu Alanlar: Kargo Firması, Marka, Beden, Boy, Cinsiyet, Desen, Kalıp, Kumaş Tipi, Menşei, Renk, Web Color, Yaş Grubu
  - Opsiyonel Alanlar: Alt-Üst Takım, Astar Durumu, Baskı/Nakış Tekniği, Bel, Cep, Dokuma Tipi, Ek Özellik, Kalınlık, Kapama Şekli, Kemer/Kuşak Durumu, Kol Boyu, Kol Tipi, Koleksiyon, Kutu Durumu, Materyal, Ortam, Paça Tipi, Paket İçeriği, Parça Sayısı, Persona, Sezon, Siluet, Sürdürülebilirlik Detayı, Ürün Detayı, Ürün Tipi, Yaka Tipi
  - Ürün adından otomatik tespit: Cinsiyet, Yaş Grubu, Kumaş, Desen, Kalıp, Kol Boyu, Yaka Tipi vb.
  - SABİT değerler: Kargo=Trendyol Express, Beden=Standart, Kumaş Tipi=Dokuma, Kalıp=Regular, Web Color=Çok Renkli, Renk=Beyaz
- [x] **İade Riski Tahmini** tamamlandı (frm_IadeRiskiTahmini.vb)
  - Risk skorlama (0-100)
  - Risk seviyeleri: Kritik, Yüksek, Orta, Düşük
  - İade nedenleri analizi
  - Kategori bazlı filtreleme
  - CSV rapor export
- [x] **Otomatik Kampanya Önerisi** tamamlandı (frm_KampanyaOnerisi.vb)
  - Kampanya tipleri: Stok Eritme, Satış Artırma, Yeni Ürün, Sezon Sonu
  - Öncelik skorlama
  - Toplu kampanya uygulama
  - Potansiyel ciro hesaplama
- [x] **Yorum Analizi** tamamlandı (frm_YorumAnalizi.vb)
  - Duygu analizi (Pozitif/Notr/Negatif)
  - Ortalama puan hesaplama
  - Sık şikayet ve övgü tespiti
  - Ürün bazlı yorum detayları

### 2026-02-19
- [x] Tarih aralığı ile sipariş çekme özelliği tamamlandı
- [x] 4 katmanlı mükerrer kontrol sistemi eklendi
- [x] AddOrder NullReferenceException hatası düzeltildi
- [x] Bu roadmap dokümanı oluşturuldu
- [x] EticaretLogger.vb dosyası oluşturuldu (C:\eticaret\log)

### Önceki (Handoff'tan)
- [x] Varyant sayısı kontrolü eklendi
- [x] "Varyant Güncelle" ve "Kategori Güncelle" checkbox'ları eklendi
- [x] Progress indicator (Gönderilen: 10/50) eklendi
- [x] UI layout düzeltmeleri yapıldı

---

## SONRAKİ AGENT İÇİN TALİMATLAR

1. **Bu dosyayı oku** ve mevcut durumu anla
2. **Öncelik sırasına göre** (P0 → P1 → P2) ilerle
3. **Her tamamlanan özelliği** CHANGELOG'a ekle ve durumu güncelle
4. **Yeni keşifler** olursa ARAŞTIRMA SONUÇLARI bölümüne ekle
5. **Veritabanı değişikliklerini** SQL_SCRIPTS/ klasörüne kaydet

### Başlangıç Noktası
**ÖNCELİK:** `frm_SatisIvmesiDashboard.vb` oluştur - Bu Trendyol'un #1 kriteri!

### Dosya Konumları
```
/app/Barkod_Magaza/
├── AIService.vb (MEVCUT - güncelle)
├── AIContentManager.vb (MEVCUT)
├── frm_AI_TopluIslem.vb (MEVCUT)
├── frm_SatisIvmesiDashboard.vb (YENİ - OLUŞTUR)
├── frm_UrunKaliteKontrol.vb (YENİ - OLUŞTUR)
├── frm_RakipFiyatOtomasyonu.vb (YENİ - OLUŞTUR)
├── TrendyolAPI.vb (MEVCUT - genişlet)
└── ETICARET_ENTEGRASYON_ROADMAP.md (BU DOSYA)
```

---

## İLETİŞİM VE SORULAR

Bu dokümanla ilgili sorular için önceki konuşma geçmişine bakılabilir.
Kullanıcı tercihi: Türkçe yanıt, teknik detay, mükerrer kontrolüne önem veriyor.

---

## PROJEDEKİ TRENDYOL FORMLARI - DETAYLI BELGELEME

### 1. frm_TrendyolAyar.vb
**Amaç:** Trendyol API bağlantı ayarlarının yapılandırılması

**UI Bileşenleri:**
- `txt_SupplierId` - Satıcı ID girişi
- `txt_ApiKey` - API Anahtarı girişi
- `txt_ApiSecret` - API Gizli Anahtarı girişi
- `txt_BaseUrl` - API Base URL (varsayılan: https://api.trendyol.com/sapigw)
- `btn_Test` - Bağlantı testi butonu
- `btn_Kaydet` - Ayarları kaydet butonu
- `btn_Iptal` - İptal butonu
- `lbl_Status` - Durum göstergesi

**Veritabanı Tabloları:**
- `tbTrendyolAyar` - API ayarlarının saklandığı tablo
  - `sSupplierId`, `sApiKey`, `sApiSecret`, `sBaseUrl`, `bAktif`, `dteOlusturma`, `dteGuncelleme`

**Ana Fonksiyonlar:**
- `LoadSettings()` - Veritabanından ayarları yükler
- `SaveSettings()` - Ayarları veritabanına kaydeder
- `btn_Test_Click()` - TrendyolAPI.Instance ile bağlantı testi yapar

---

### 2. frm_TrendyolBuyBoxAnaliz.vb
**Amaç:** Ürünlerin Trendyol BuyBox durumunu analiz etme ve kategori eşleştirme

**UI Bileşenleri:**
- `grd_Urunler` - DevExpress DataGridView (ürün listesi)
- `txt_Barkod`, `txt_StokKodu` - Filtre alanları
- `chk_SadeceEslesmeyen` - Sadece eşleşmeyenleri filtrele
- `btn_Yukle`, `btn_Analiz`, `btn_TumunuSec`, `btn_SecimTemizle`
- `btn_KategoriDegistir`, `btn_OtomatikDuzelt` - Kategori işlemleri
- `progressBar`, `lbl_Status`

**Veritabanı Tabloları:**
- `tbStok` - Ana stok tablosu
- `tbStokBarkodu` - Barkod bilgileri
- `tbTrendyolUrunEsleme` - Trendyol eşleşme verileri
  - `nStokID`, `sBizimBarkod`, `sTrendyolBarkod`, `sTrendyolProductId`
  - `sTrendyolTitle`, `sTrendyolCategoryId`, `sTrendyolBrand`
  - `nEslesmeDurumu` (0=Bekliyor, 1=Eslesti, 2=Eslesemedi, 3=Manuel)
  - `nBuyBoxDurumu` (0=?, 1=BuyBox'ta, 2=BuyBox disi, 3=Tek satici)
- `tbSSinif4` - Kategori tanımları
- `tbStokSinifi` - Stok sınıf ilişkileri

**Ana Fonksiyonlar:**
- `LoadProducts()` - Ürünleri veritabanından yükler
- `AnalyzeSelectedProducts()` - Seçili ürünleri Trendyol'da analiz eder
- `TrendyoldaUrunAraVeKategoriBul()` - Trendyol Public API ile kategori arar
- `UrunAdindanAramaKelimesiOlustur()` - Ürün adından anahtar kelime çıkarır
- `MarkaCikar()` - Marka normalize eder (U.S.POLO -> us polo)
- `SaveCategoryToDatabase()` - Kategori değişikliğini kaydeder
- `OtomatikKategoriDuzelt()` - Toplu kategori düzeltme

**Önemli Özellikler:**
- Trendyol Public API kullanarak kategori araması
- Marka tanıma ve normalize etme (40+ marka)
- Otomatik kategori önerisi
- BuyBox durumu takibi

---

### 3. frm_TrendyolEntegrasyon.vb
**Amaç:** Trendyol'a fiyat ve stok senkronizasyonu

**UI Bileşenleri:**
- `grd_Urunler` - Eşleşmiş ürünlerin listesi
- `chk_SadeceDegisen` - Sadece değişen ürünleri filtrele
- `btn_Yukle`, `btn_Senkronize`, `btn_TumunuSec`, `btn_SecimTemizle`
- `progressBar`, `lbl_Status`

**Grid Sütunları:**
- Sec, sKodu, sAciklama, sBarkod, TrendyolBarkod
- Stok, SatisFiyati, ListeFiyati, SonSenkron, Durum

**Veritabanı Tabloları:**
- `tbTrendyolUrunEsleme` - Eşleşme ve senkronizasyon durumu
  - `dteSonSenkron`, `sSonBatchId`, `nSonFiyat`, `nSonStok`
- `tbTrendyolLog` - İşlem logları
  - `sIslemTipi`, `sBatchRequestId`, `nToplamUrun`, `nBasarili`, `nBasarisiz`

**Ana Fonksiyonlar:**
- `LoadProducts()` - Eşleşmiş ürünleri yükler (nEslesmeDurumu=1)
- `SyncSelectedProducts()` - Seçili ürünleri Trendyol API'ye gönderir
- `UpdateSyncDates()` - Senkronizasyon tarihlerini günceller
- `LogSyncOperation()` - İşlem loglarını kaydeder

**API Entegrasyonu:**
- `TrendyolAPI.Instance.UpdatePriceAndInventoryAsync()` - Fiyat/stok güncelleme
- `TrendyolAPI.Instance.GetBatchStatusAsync()` - Batch durumu kontrolü

---

### 4. frm_TrendyolKategoriEslestir.vb
**Amaç:** Web'de görüntülenecek ürünler için toplu kategori eşleştirme

**UI Bileşenleri:**
- `dgvUrunler` - Ürün listesi (Model, Renk, Barkod, UrunAdi, Marka, Kategori, Durum)
- `btnListeYukle` - frm_stok_liste_fiyat'tan ürün seç
- `btnTumunuSec`, `btnSecilenleriEsle`, `btnTumunuEsle`
- `btnDurdur` - İşlemi durdur
- `btnSiniflariSil` - Tüm sınıfları temizle
- `btnKategoriKontrol` - Yanlış kategorileri bul
- `chkSadeceBosKategoriler` - Sadece kategorisi boş olanlar
- `chkVeritabani`, `chkTrendyol`, `chkExcel` - Eşleştirme kaynakları
- `btnExcelSec` - Excel dosyası seç
- `lstLog` - İşlem logları
- `progressBar`

**Eşleştirme Kaynakları:**
1. **Veritabanı** - Mevcut kategori tanımları
2. **Trendyol** - Selenium ile web scraping
3. **Excel** - Manuel kategori eşleştirme dosyası

**Excel Eşleştirme Özellikleri:**
- NPOI kütüphanesi ile Excel okuma
- Sütun eşleştirme formu (Barkod, Model Kodu, Marka, Kategori sütunları)
- Sabit ana kategori ekleme özelliği
- TrendyolExcelMatcher sınıfı

**Selenium Entegrasyonu:**
- `TrendyolSeleniumScraperService` - Headless Chrome ile scraping
- Trendyol'da ürün arama ve kategori bulma
- Rate limiting (3 saniye/istek)

**Veritabanı Tabloları:**
- `tbStok` (bWebGoruntule=1 filtresi)
- `tbStokSinifi` (sSinifKodu4-8 kategori alanları)
- `tbSSinif4-8` - Kategori tanım tabloları

**Ana Fonksiyonlar:**
- `YukleTumWebUrunleri()` - bWebGoruntule=1 ürünleri yükler
- `EsleUrunler()` - Seçili ürünleri eşleştirir
- `GetNPOICellValue()` - NPOI hücre değeri okuma
- Kaynak önceliği: Excel → Veritabanı → Trendyol (Selenium)

---

### 5. frm_TrendyolKategoriSec.vb
**Amaç:** Trendyol kategorisi seçimi için 3 farklı yöntem sunan form

**UI Bileşenleri:**
- **Yöntem 1 - Trendyol'da Ara (Önerilen):**
  - `txt_AramaKelimesi` - Arama kelimesi girişi
  - `btn_TrendyoldaAra` - Ara butonu
  - `lst_BulunanKategoriler` - Bulunan kategoriler listesi

- **Yöntem 2 - URL'den Al:**
  - `txt_TrendyolURL` - Trendyol URL yapıştırma alanı
  - `btn_URLdenAl` - URL'den kategori çıkar

- **Yöntem 3 - Listeden Seç:**
  - `txt_Ara` - Kategori arama filtresi
  - `lst_Kategoriler` - Tüm kategoriler listesi

- `btn_Sec`, `btn_Iptal`, `lbl_Status`

**Çıktı Değişkenleri:**
- `SecilenKategoriId` - Seçilen kategori ID'si
- `SecilenKategoriAd` - Seçilen kategori adı

**API Entegrasyonu:**
- `TrendyolAPI.Instance.GetCategoriesAsync()` - Tüm kategorileri çeker
- Trendyol Public API ile arama:
  - `https://apigw.trendyol.com/discovery-web-searchgw-service/v2/api/infinite-scroll/sr`
  - `https://apigw.trendyol.com/discovery-web-productgw-service/api/productDetail/`

**URL Parsing:**
- Kategori URL: `-c(\d+)` pattern (örn: erkek-sort-x-g2-c1182)
- Ürün URL: `-p-(\d+)` pattern

**Ana Fonksiyonlar:**
- `LoadCategories()` - API'den kategorileri yükler
- `FillCategoryList()` - Filtrelenmiş kategori listesi
- `btn_TrendyoldaAra_Click()` - Public API ile arama
- `GetCategoryFromProductUrl()` - Ürün URL'inden kategori bulma
- `KategoriBulundu()` - Seçim onayı

---

## TRENDYOL API SINIFI (TrendyolAPI.vb)

**Singleton Pattern:** `TrendyolAPI.Instance`

**Konfigürasyon:**
```vb
TrendyolAPI.Instance.Configure(supplierId, apiKey, apiSecret, baseUrl)
```

**Ana Metotlar:**
- `TestConnectionAsync()` - Bağlantı testi
- `GetCategoriesAsync()` - Kategori listesi
- `UpdatePriceAndInventoryAsync()` - Fiyat/stok güncelleme
- `UpdateProductCategoryAsync()` - Kategori güncelleme
- `GetBatchStatusAsync()` - Batch durumu kontrolü

---

**SON GÜNCELLEME:** 2026-02-19 16:00
**GÜNCELLEYEN:** AI Agent (Emergent)
