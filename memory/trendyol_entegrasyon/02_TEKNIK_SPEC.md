# 🔧 TRENDYOL API TEKNİK SPEC

## API Genel Bilgileri

### Base URL
```
Production: https://api.trendyol.com/sapigw
```

### Authentication
```
Authorization: Basic base64(API_KEY:API_SECRET)
Content-Type: application/json
```

### VB.NET Authentication Kodu
```vb
Private Function GetAuthHeader() As String
    Dim credentials = API_KEY & ":" & API_SECRET
    Dim bytes = System.Text.Encoding.UTF8.GetBytes(credentials)
    Return "Basic " & Convert.ToBase64String(bytes)
End Function
```

---

## 📌 KULLANILACAK ENDPOINT'LER

### 1. Ürün Arama (BuyBox Eşleştirme İçin) ⭐ KRİTİK
```
GET /product-detail/{barcode}

Amaç: Barkod ile mevcut ürünü bul
Kullanım: BuyBox eşleştirme için
```

**Response Örneği:**
```json
{
  "productId": 123456789,
  "barcode": "8680001234567",
  "title": "Pamuklu Pijama Takımı",
  "brand": "Furkan Pijama",
  "categoryId": 1234,
  "listPrice": 399.00,
  "salePrice": 299.00,
  "quantity": 100,
  "hasActiveCampaign": false,
  "sellersCount": 5
}
```

---

### 2. Fiyat ve Stok Güncelleme ⭐ EN ÖNEMLİ
```
POST /suppliers/{supplierId}/products/price-and-inventory

Amaç: BuyBox'taki fiyat/stok güncellemesi
Bu endpoint ile MEVCUT ürüne fiyat verebilirsiniz
```

**Request Body:**
```json
{
  "items": [
    {
      "barcode": "8680001234567",
      "quantity": 100,
      "salePrice": 289.00,
      "listPrice": 399.00
    },
    {
      "barcode": "8680001234568",
      "quantity": 50,
      "salePrice": 199.00,
      "listPrice": 299.00
    }
  ]
}
```

**Response:**
```json
{
  "batchRequestId": "abc-123-def"
}
```

**VB.NET Kodu:**
```vb
Public Function UpdatePriceAndInventory(items As List(Of PriceStockItem)) As String
    Dim url = BASE_URL & "/suppliers/" & SUPPLIER_ID & "/products/price-and-inventory"
    
    Dim payload = New With {
        .items = items.Select(Function(i) New With {
            .barcode = i.TrendyolBarkod,  ' Kritik: Trendyol'daki barkod!
            .quantity = i.Quantity,
            .salePrice = i.SalePrice,
            .listPrice = i.ListPrice
        }).ToArray()
    }
    
    Return PostRequest(url, JsonConvert.SerializeObject(payload))
End Function
```

---

### 3. Batch Request Durumu Kontrol
```
GET /suppliers/{supplierId}/products/batch-requests/{batchRequestId}

Amaç: Gönderilen güncellemenin sonucunu kontrol et
```

**Response:**
```json
{
  "batchRequestId": "abc-123-def",
  "status": "COMPLETED",
  "items": [
    {
      "barcode": "8680001234567",
      "status": "SUCCESS"
    },
    {
      "barcode": "8680001234568",
      "status": "FAILED",
      "failureReasons": ["Product not found"]
    }
  ]
}
```

---

### 4. Kategori Listesi
```
GET /product-categories

Amaç: Tüm kategorileri çek
```

---

### 5. Kategori Özellikleri (Attributes)
```
GET /product-categories/{categoryId}/attributes

Amaç: Belirli kategorinin zorunlu/opsiyonel özelliklerini al
PRODUCTSAVE008 hatasının çözümü için kritik!
```

**Response:**
```json
{
  "categoryId": 1234,
  "categoryName": "Pijama Takımı",
  "attributes": [
    {
      "id": 101,
      "name": "Renk",
      "required": true,
      "allowedValues": ["Mavi", "Kırmızı", "Siyah"]
    },
    {
      "id": 102,
      "name": "Beden",
      "required": true,
      "allowedValues": ["S", "M", "L", "XL"]
    }
  ]
}
```

---

### 6. Marka Listesi
```
GET /brands

Amaç: Trendyol'daki marka listesini al
```

---

### 7. Yeni Ürün Oluşturma (İleride Gerekirse)
```
POST /suppliers/{supplierId}/products

Amaç: Tamamen yeni ürün ekle
Not: BuyBox sorununu çözmez, sadece yeni ürün için
```

---

## 🔄 BUYBOX AKIŞI

```
ADIM 1: Kendi barkodunuzu alın
        ↓
ADIM 2: Trendyol API'den bu barkodla arama yapın
        GET /product-detail/{barcode}
        ↓
ADIM 3A: Ürün bulundu?
         → productId'yi kaydet
         → Bu ürünün BuyBox'ına katılabilirsiniz
         ↓
ADIM 3B: Ürün bulunamadı?
         → Farklı barkod deneyin
         → Veya model kodu ile arayın
         → Manuel eşleştirme gerekebilir
         ↓
ADIM 4: Fiyat/Stok güncellemesi yapın
        POST /suppliers/{supplierId}/products/price-and-inventory
        {
          "items": [{
            "barcode": "TRENDYOL_BARKODU",  // Kendi barkodunuz değil!
            "quantity": 100,
            "salePrice": 289.00,
            "listPrice": 399.00
          }]
        }
        ↓
ADIM 5: Batch durumunu kontrol edin
        GET /batch-requests/{batchRequestId}
        ↓
ADIM 6: Başarılı → BuyBox'tasınız! 🎉
        Başarısız → Hata mesajını analiz edin
```

---

## ⚠️ HATA KODLARI

| Kod | Açıklama | Çözüm |
|-----|----------|-------|
| PRODUCT_NOT_FOUND | Barkod bulunamadı | Doğru Trendyol barkodunu kullan |
| INVALID_PRICE | Fiyat geçersiz | salePrice <= listPrice olmalı |
| INVALID_QUANTITY | Stok geçersiz | 0'dan büyük olmalı |
| CATEGORY_NOT_MATCH | Kategori uyuşmuyor | Doğru kategori ID kullan |
| BRAND_NOT_FOUND | Marka bulunamadı | Trendyol marka listesinden seç |

---

## 📊 RATE LIMITS

- Dakikada max 100 istek
- Batch işlemlerde max 1000 ürün
- Günlük limit: Kontrol edilmeli

---

## 🔐 GÜVENLİK

```vb
' API bilgileri .env veya config'den alınmalı
' KOD İÇİNE YAZILMAMALI!

Private SUPPLIER_ID As String = GetSetting("Trendyol", "SupplierId")
Private API_KEY As String = GetSetting("Trendyol", "ApiKey")
Private API_SECRET As String = GetSetting("Trendyol", "ApiSecret")
```
