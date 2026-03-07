# 🧪 TEST PLANI

## Test Aşamaları

### AŞAMA 1: API Bağlantı Testi

#### Test 1.1: Authentication
```
Girdi: Supplier ID, API Key, API Secret
Beklenen: HTTP 200 OK
Test Yöntemi: btn_Test_Click
```

#### Test 1.2: Yanlış Credentials
```
Girdi: Yanlış API Key
Beklenen: HTTP 401 Unauthorized
Test Yöntemi: btn_Test_Click
```

---

### AŞAMA 2: Ürün Arama Testi

#### Test 2.1: Mevcut Barkod ile Arama
```
Girdi: Trendyol'da var olan bir barkod
Beklenen: ProductSearchResult dönmeli
Kontrol: productId, title, sellersCount > 0
```

#### Test 2.2: Olmayan Barkod ile Arama
```
Girdi: Trendyol'da olmayan bir barkod
Beklenen: Boş sonuç veya 404
```

---

### AŞAMA 3: BuyBox Eşleştirme Testi

#### Test 3.1: Otomatik Eşleştirme
```
Senaryo: Barkod tuttuğunda
1. Kendi barkodumuz: 8680001234567
2. Trendyol'da ara
3. Sonuç: productId=123456 bulundu
4. tbTrendyolUrunEsleme'ye kaydet
5. nEslesmeDurumu = 1 (Eşleşti)
```

#### Test 3.2: Manuel Eşleştirme
```
Senaryo: Barkod tutmadığında
1. Kendi barkodumuz: FRK-001
2. Trendyol'da ara → Bulunamadı
3. Model kodu ile ara
4. Kullanıcıya seçenek sun
5. Kullanıcı seçti → Kaydet
6. nEslesmeDurumu = 3 (Manuel)
```

---

### AŞAMA 4: Fiyat/Stok Güncelleme Testi

#### Test 4.1: Tekli Güncelleme
```
Girdi:
{
  "items": [{
    "barcode": "8680001234567",
    "quantity": 50,
    "salePrice": 289.00,
    "listPrice": 399.00
  }]
}

Beklenen: batchRequestId dönmeli
Sonra: Batch status SUCCESS olmalı
```

#### Test 4.2: Toplu Güncelleme (10 ürün)
```
Girdi: 10 ürün listesi
Beklenen: batchRequestId dönmeli
Kontrol: Tüm ürünler SUCCESS olmalı
```

#### Test 4.3: Hatalı Güncelleme
```
Girdi: Olmayan barkod
Beklenen: Batch status FAILED
Hata: "Product not found"
```

---

### AŞAMA 5: Entegre Test (Uçtan Uca)

#### Test 5.1: Tam Akış
```
1. API ayarlarını kaydet
2. 5 ürün seç
3. BuyBox analiz yap
4. Eşleşenleri bul
5. Fiyat/Stok güncelle
6. Batch durumunu kontrol et
7. Log'a kaydet
8. Trendyol'da kontrol et
```

---

## Test Ürünleri (Kullanıcıdan Alınacak)

| # | Stok Kodu | Barkod | Durum | BuyBox? |
|---|-----------|--------|-------|---------|
| 1 | _________ | ______ | Eşleşti | ☐ Evet ☐ Hayır |
| 2 | _________ | ______ | Eşleşti | ☐ Evet ☐ Hayır |
| 3 | _________ | ______ | Eşleşti | ☐ Evet ☐ Hayır |
| 4 | _________ | ______ | Manuel | ☐ Evet ☐ Hayır |
| 5 | _________ | ______ | Başarısız | N/A |

---

## Başarı Kriterleri

### Minimum Viable Product (MVP)
- [x] API bağlantısı çalışıyor
- [ ] Barkod ile ürün aranabiliyor
- [ ] Eşleştirme kaydedilebiliyor
- [ ] Fiyat/Stok güncellemesi yapılabiliyor
- [ ] Batch durumu kontrol edilebiliyor

### Tam Başarı
- [ ] %90+ otomatik eşleştirme oranı
- [ ] Manuel eşleştirme arayüzü çalışıyor
- [ ] BuyBox'a giren ürün sayısı artıyor
- [ ] Log sistemi çalışıyor
- [ ] Hata durumlarında fallback çalışıyor

---

## Hata Senaryoları

| Hata | Nedeni | Çözüm |
|------|--------|-------|
| 401 Unauthorized | Yanlış API bilgileri | Credentials kontrol et |
| 404 Not Found | Barkod yok | Manuel eşleştir |
| 400 Bad Request | JSON formatı yanlış | Request body kontrol et |
| 500 Server Error | Trendyol sorunu | Bekle, tekrar dene |
| Timeout | Ağ yavaş | Timeout artır |

---

## Quka Karşılaştırma

| Metrik | Quka | Direkt | Fark |
|--------|------|--------|------|
| BuyBox'a giren ürün | ___ | ___ | ___ |
| Güncelleme süresi | ___ sn | ___ sn | ___ |
| Hata oranı | ___ % | ___ % | ___ |
| Manuel müdahale | ___ kez | ___ kez | ___ |
