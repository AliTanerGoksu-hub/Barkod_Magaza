# 🧪 AI SİSTEM TEST REHBERİ

## 📋 KURULUM ADIMLARI

### 1. Veritabanı Kurulumu
```sql
-- SQL Server Management Studio'da sırasıyla çalıştır:

1. INSTALL_DATABASE.sql
2. DATABASE_AI_CONTENT_STRUCTURE.sql
```

**Beklenen Sonuç:**
- ✅ tbParamGenel güncel (AI alanları eklendi)
- ✅ tbStok güncellendi
- ✅ tbStokResim güncellendi
- ✅ tbStokAIIcerik oluştu
- ✅ tbMusteriKredi oluştu
- ✅ tbKrediPaketleri oluştu (4 paket hazır)
- ✅ tbKrediHareketleri oluştu
- ✅ tbOdemeler oluştu

---

### 2. API Key'leri Ayarla

**tbParamGenel tablosuna key'leri ekle:**
```sql
UPDATE tbParamGenel SET
    sEmergentKey = 'your-emergent-llm-key',
    sGoogleSearchApiKey = 'your-google-api-key',
    sGoogleSearchEngineId = 'your-search-engine-id',
    bAIKullan = 1,
    bBaslikOlustur = 1,
    bAciklamaOlustur = 1,
    bTalimatOlustur = 1
WHERE nParamID = 1
```

---

### 3. Test Müşterisi İçin Kredi Ekle

```sql
-- Müşteri ID 1 için 100 TL kredi ekle
EXEC sp_AddCredit 
    @nMusteriID = 1,
    @nMiktar = 100.00,
    @nPaketID = 2, -- Standart paket
    @sAciklama = 'Test kredisi'
```

Veya manuel:
```sql
INSERT INTO tbMusteriKredi (
    nMusteriID, sMusteriAdi, nToplamKredi, nKullanilabilirKredi,
    nGunlukLimit, dteGunlukResetTarihi, bAktif, dteOlusturma
) VALUES (
    1, 'Test Müşteri', 100.00, 100.00,
    100, CAST(GETDATE() AS DATE), 1, GETDATE()
)
```

---

## 🧪 TEST SENARYOLARI

### TEST 1: Tek Ürün İşleme

**Amaç:** Bir ürün için AI içerik oluştur

**Adımlar:**
1. frm_AIUrunIsle formunu aç
2. Stok ID: 1 (veya mevcut bir ürün ID'si)
3. "İşle" butonuna tıkla

**Beklenen Sonuç:**
- ✅ SEO başlığı oluşturuldu
- ✅ Detaylı açıklama oluşturuldu
- ✅ Kullanım talimatları oluşturuldu
- ✅ Kredi 1.4 TL azaldı
- ✅ tbStokAIIcerik'e kayıt eklendi
- ✅ tbStok.bAIIcerikVar = 1 oldu

**Kontrol:**
```sql
-- Ürünün AI içeriğini kontrol et
SELECT * FROM vw_StokAIOzet WHERE nStokID = 1

-- Kredi hareketini kontrol et
SELECT TOP 1 * FROM tbKrediHareketleri 
WHERE nMusteriID = 1 
ORDER BY dteTarih DESC
```

---

### TEST 2: Toplu İşlem

**Amaç:** 10 ürün için AI içerik oluştur

**Adımlar:**
1. frm_AIUrunIsle formunu aç
2. Ürün Adedi: 10
3. "Toplu İşle" butonuna tıkla
4. Onay ver

**Beklenen Sonuç:**
- ✅ 10 ürün işlendi (veya AI içeriği olmayan kadar)
- ✅ Başarı/hata sayıları gösterildi
- ✅ Kredi düştü (10 x 1.4 = 14 TL)
- ✅ Log dosyası oluştu: AI_Content_Manager.log

**Kontrol:**
```sql
-- Kaç ürün işlendi?
SELECT COUNT(*) AS IslenmisSayi FROM tbStok WHERE bAIIcerikVar = 1

-- Toplam harcanan kredi
SELECT SUM(nMiktar) AS ToplamHarcama FROM tbKrediHareketleri 
WHERE nMusteriID = 1 AND sHareketTipi = 'Kullanim'
```

---

### TEST 3: Kredi Yetersiz Durumu

**Amaç:** Kredi yetersizse engelle

**Adımlar:**
1. Krediyi sıfırla:
```sql
UPDATE tbMusteriKredi SET nKullanilabilirKredi = 0 WHERE nMusteriID = 1
```
2. frm_AIUrunIsle'de işlem yap

**Beklenen Sonuç:**
- ❌ "Yetersiz kredi!" uyarısı
- ❌ İşlem yapılmadı
- ✅ Kredi değişmedi

---

### TEST 4: Günlük Limit Aşımı

**Amaç:** Günlük limit aşılırsa engelle

**Adımlar:**
1. Limiti düşür:
```sql
UPDATE tbMusteriKredi SET 
    nGunlukKullanim = 100,
    nGunlukLimit = 100
WHERE nMusteriID = 1
```
2. frm_AIUrunIsle'de işlem yap

**Beklenen Sonuç:**
- ❌ "Günlük limit aşıldı!" uyarısı
- ❌ İşlem yapılmadı

---

### TEST 5: Parametrik Kontrol

**Amaç:** AI kapalıysa çalışmasın

**Adımlar:**
1. AI'yı kapat:
```sql
UPDATE tbParamGenel SET bAIKullan = 0 WHERE nParamID = 1
```
2. frm_AIUrunIsle'de işlem yap

**Beklenen Sonuç:**
- ❌ "AI sistemi kapalı" uyarısı
- ❌ İşlem yapılmadı

---

### TEST 6: Ayarlar Formu

**Amaç:** Parametreleri değiştir

**Adımlar:**
1. frm_AIAyarlari formunu aç
2. Ayarları değiştir
3. "Kaydet" butonuna tıkla
4. Form'u kapat ve tekrar aç

**Beklenen Sonuç:**
- ✅ Ayarlar kaydedildi
- ✅ Tekrar açıldığında aynı değerler gözüküyor
- ✅ Maliyet hesaplama doğru

---

## 📊 VERİ DOĞRULAMA

### 1. AI İçerik Kontrolü
```sql
-- En son işlenen 10 ürün
SELECT TOP 10 
    nStokID,
    sSEOBaslik,
    LEFT(sDetayliAciklama, 100) AS Aciklama,
    LEFT(sKullanimTalimati, 100) AS Talimat,
    nAIMaliyet,
    dteOlusturma
FROM tbStokAIIcerik
ORDER BY dteOlusturma DESC
```

### 2. Kredi Durumu
```sql
-- Müşteri kredi özeti
SELECT 
    nToplamKredi,
    nKullanilabilirKredi,
    nKullanilanKredi,
    nGunlukKullanim,
    nGunlukLimit,
    sAktifPaket
FROM tbMusteriKredi
WHERE nMusteriID = 1
```

### 3. Kredi Hareketleri
```sql
-- Son 20 hareket
SELECT TOP 20
    sHareketTipi,
    nMiktar,
    nStokID,
    sIslemAciklama,
    nOncekiBakiye,
    nYeniBakiye,
    dteTarih
FROM tbKrediHareketleri
WHERE nMusteriID = 1
ORDER BY dteTarih DESC
```

---

## 🐛 HATA AYIKLAMA

### Log Dosyaları
```
- AI_Content_Manager.log
- AI_Service.log
- Credit_Service.log
- AI_ImageFinder.log
```

### Yaygın Hatalar

**1. "API key bulunamadı"**
- Çözüm: tbParamGenel'de sEmergentKey kontrol et
- ```sql SELECT sEmergentKey FROM tbParamGenel WHERE nParamID = 1 ```

**2. "Ürün bulunamadı"**
- Çözüm: Stok ID'yi kontrol et
- ```sql SELECT * FROM tbStok WHERE nStokID = 1 ```

**3. "Veritabanı kayıt hatası"**
- Çözüm: tbStokAIIcerik tablosu var mı kontrol et
- ```sql SELECT * FROM sysobjects WHERE name='tbStokAIIcerik' ```

**4. "OpenAI API hatası"**
- Çözüm: API key geçerli mi? Bakiye var mı?
- Test: ```curl``` ile manuel istek at

---

## ✅ BAŞARILI TEST ÇIKTISI

```
[10:30:45] 🚀 İşlem başlatıldı...
[10:30:45] 📦 Ürün ID: 1
[10:30:47] ✓ SEO Başlık oluşturuldu
[10:30:50] ✓ Detaylı açıklama oluşturuldu
[10:30:53] ✓ Kullanım talimatları oluşturuldu
[10:30:56] ✓ Ürün görseli bulundu ve kaydedildi
[10:30:58] ✓ Meta veriler oluşturuldu
[10:31:00] ✓ Veritabanına kaydedildi
[10:31:00] ✅ İşlem BAŞARILI!
[10:31:00] 📝 İşlem başarılı! 1.4 kredi kullanıldı.
```

---

## 🎯 PERFORMANS BEKLENTİSİ

| İşlem | Süre | Maliyet |
|-------|------|---------|
| Tek ürün | 10-15 saniye | 1.4 TL (müşteriye) |
| 10 ürün | 2-3 dakika | 14 TL |
| 50 ürün | 10-15 dakika | 70 TL |
| 100 ürün | 20-30 dakika | 140 TL |

---

## 📞 DESTEK

Test sırasında sorun yaşarsanız:
1. Log dosyalarını kontrol edin
2. SQL sorgularıyla veriyi kontrol edin
3. Parametreleri kontrol edin
4. API key'leri kontrol edin

**Test başarılı olursa pazartesi günü production'a geçilebilir!** 🚀
