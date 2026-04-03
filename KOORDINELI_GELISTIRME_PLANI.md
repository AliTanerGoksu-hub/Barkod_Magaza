# BARKOD YAZILIM - KOORDINELI GELISTIRME PLANI
## PC Agent (Ben) + Mobil/B2B Agent (Diger) Gorev Dagilimi

---

## TEMEL KURAL: ORTAK API KONTRАТИ

Her iki agent de **BusinessSmartDesktopAPI** uzerinden calisir.
API kontrati (endpoint, request/response modelleri, auth) BEN tanimlayip kodluyorum.
Diger agent bu API'yi TUKETIR (consume eder), degistirmez.

```
+------------------+         +----------------------+         +------------------+
|  VB.NET Desktop  |         |  BusinessSmartDesktop |         |  Mobil Uygulama  |
|  (PC Agent)      +-------->+  API (C# .NET 8.0)   +<--------+  (Diger Agent)   |
+------------------+         |                      |         +------------------+
                             |  * AI Controller     |
                             |  * Risk Controller   |         +------------------+
                             |  * Tahsilat Ctrl     +<--------+  B2B Web Panel   |
                             |  * Satis Ctrl        |         |  (Diger Agent)   |
                             |  * Stok Ctrl         |         +------------------+
                             |  * Auth Controller   |
                             +----------+-----------+
                                        |
                              +---------+---------+
                              |    SQL Server     |
                              |  (View Katmani)   |
                              +-------------------+
```

---

## PC AGENT (BEN) - SORUMLULUKLAR

### A. Veritabani & Veri Katmani
- [x] SQL tablolari olusturma/guncelleme
- [x] View katmani (vw_AI_CariRiskVerisi, vw_AI_SatisGecmisi, vb.)
- [x] Is kurallari tablosu (tbIsKurallari)
- [x] Audit log tablosu (tbAuditLog)
- [x] Stored Procedure'ler

### B. BusinessSmartDesktopAPI (C# .NET 8.0) - MERKEZ API
- [x] Tum API endpoint tasarimi ve kodlamasi
- [x] AI entegrasyonu (LLMService - GPT/Gemini cagrisi)
- [x] Authentication/Authorization (JWT token)
- [x] Rate limiting, audit log middleware
- [x] Swagger/OpenAPI dokumantasyonu (diger agent buna bakacak)

### C. VB.NET Desktop Uygulamasi
- [x] Risk skoru gosterimi (siparis ekrani, cari kart)
- [x] Tahsilat ekrani revizyonu
- [x] AI oneri panelleri (satis, tahsilat, yonetici ozeti)
- [x] Icerik temizleme / pazaryeri ilan yardimcisi ekrani
- [x] Mevcut tum desktop UI degisiklikleri
- [x] GIB E-Fatura/E-Arsiv eslestirme (mevcut is)

### D. Kural Motoru
- [x] Kredi limit kurallari
- [x] Siparis onay kurallari
- [x] Iskonto kurallari
- [x] Kanal rezervasyon kurallari

---

## MOBIL/B2B AGENT (DIGER) - SORUMLULUKLAR

### E. Mobil Uygulama (iOS/Android)
- [ ] Giris ekrani (JWT auth - API'den token al)
- [ ] Tahsilat listesi ekrani (GET /api/tahsilat/gunluk-plan)
- [ ] Musteri karti ekrani (GET /api/cari/{firmaId}/detay)
- [ ] AI tahsilat onerisi gosterimi (GET /api/ai/tahsilat-plani)
- [ ] AI satis onerisi gosterimi (POST /api/ai/satis-oneri)
- [ ] Siparis olusturma (POST /api/siparis/olustur)
- [ ] Ziyaret kapanis formu (POST /api/ziyaret/kapat)
- [ ] Tahsilat kaydi (POST /api/tahsilat/kaydet)
- [ ] GPS konum gonderme (POST /api/konum/guncelle)
- [ ] Bildirimler (push notification)
- [ ] Online-first mimari: cache + taslak kaydetme + baglanti kontrolu

### F. B2B Web Panel
- [ ] Musteri giris (JWT auth - ayri B2B kullanici tablosu)
- [ ] Urun katalogu (GET /api/b2b/urunler)
- [ ] Canli stok gosterimi (GET /api/b2b/stok/{urunKod})
- [ ] Siparis olusturma (POST /api/b2b/siparis)
- [ ] Siparis takibi (GET /api/b2b/siparisler)
- [ ] Bakiye/ekstre goruntuleme (GET /api/b2b/bakiye)
- [ ] Odeme plani (GET /api/b2b/odeme-plani)
- [ ] Fatura indirme (GET /api/b2b/fatura/{faturaId}/pdf)
- [ ] AI urun onerisi gosterimi (GET /api/b2b/ai/oneriler)

---

## ORTAK API KONTRATI (HER IKI AGENT BUNA UYAR)

### Authentication
```
POST /api/auth/login
  Request:  { "kullaniciAdi": "string", "sifre": "string", "platform": "desktop|mobil|b2b" }
  Response: { "token": "JWT_TOKEN", "kullaniciId": 1, "yetki": "admin|temsilci|b2b_musteri", "firmaId": 5 }

POST /api/auth/refresh
  Request:  { "refreshToken": "string" }
  Response: { "token": "NEW_JWT_TOKEN" }
```
**Token Header:** `Authorization: Bearer {JWT_TOKEN}`

---

### CARI / MUSTERI
```
GET /api/cari/{firmaId}/detay
  Response: {
    "firmaId": 1,
    "firmaAd": "ABC Tekstil",
    "vergiNo": "1234567890",
    "il": "Istanbul",
    "semt": "Beylikduzu",
    "ulke": "Turkiye",
    "adres": "...",
    "telefon": "...",
    "bakiye": 45000.00,
    "krediLimit": 100000.00,
    "riskSkoru": 72,
    "riskSeviye": "dikkat",
    "gecikmeGun": 28,
    "sonOdemeTarih": "2026-03-15"
  }

GET /api/cari/{firmaId}/hareket?sayfa=1&adet=50
  Response: {
    "toplamKayit": 150,
    "hareketler": [
      { "tarih": "2026-03-01", "aciklama": "Fatura #1234", "borc": 5000, "alacak": 0, "bakiye": 45000 }
    ]
  }

GET /api/cari/risk-skoru/{firmaId}
  Response: {
    "skor": 72,
    "seviye": "dikkat",
    "bakiye": 45000,
    "gecikmeGun": 28,
    "odemeDisipilin": 0.65,
    "iadeOrani": 0.15,
    "limitKullanim": 0.92
  }
```

---

### AI ENDPOINT'LERI
```
POST /api/ai/risk-aciklama
  Request:  { "firmaId": 1 }
  Response: {
    "aciklama": "Bu musteri son 3 ayda 4 faturasini ortalama 28 gun geciktirdi...",
    "oneriler": ["Veresiye satisi sinirlayın", "Yuzyuze gorusme planlayin"],
    "model": "gpt-4o-mini",
    "timestamp": "2026-04-01T10:30:00Z"
  }

GET /api/ai/tahsilat-plani?temsilciId=5&tarih=2026-04-01
  Response: {
    "ozet": "Bugun 12 tahsilat onerilmektedir. Toplam 185.000 TL bakiye.",
    "liste": [
      {
        "firmaId": 1,
        "firmaAd": "ABC Tekstil",
        "bakiye": 45000,
        "gecikmeGun": 28,
        "oncelik": 1,
        "riskSeviye": "dikkat",
        "sonZiyaret": "2026-03-20",
        "strateji": "Yuzyuze gorusme, taksit plani teklif edin"
      }
    ]
  }

POST /api/ai/satis-oneri
  Request:  { "firmaId": 1 }
  Response: {
    "oneriler": [
      {
        "urunKod": "STK001",
        "urunAd": "Erkek T-Shirt Basic",
        "neden": "Son 3 sipariste aldi, stokta mevcut",
        "tahminMiktar": 50,
        "birimFiyat": 120.00,
        "sonSiparisTarih": "2026-03-10"
      }
    ]
  }

GET /api/ai/gun-sonu-ozet?tarih=2026-04-01
  Response: {
    "ozet": "Bugun toplam satis 125.000 TL (%8 artis)...",
    "satisAnaliz": "...",
    "tahsilatAnaliz": "...",
    "aksiyonlar": ["X musteride iskonto gozden gecir"]
  }

POST /api/ai/urun-aciklama-temizle
  Request:  { "urunKod": "STK001", "mevcutAciklama": "..." }
  Response: {
    "temizAciklama": "...",
    "tespitler": ["yasakli kelime kaldirildi", "fazla bosluk temizlendi"],
    "skor": 85
  }

POST /api/ai/pazaryeri-ilan
  Request:  { "urunKod": "STK001", "platform": "trendyol" }
  Response: {
    "baslik": "...",
    "kisaAciklama": "...",
    "teknikOzellik": "...",
    "etiketler": ["erkek", "t-shirt", "basic"]
  }
```

---

### TAHSILAT
```
GET /api/tahsilat/gunluk-plan?temsilciId=5&tarih=2026-04-01
  Response: {
    "planlar": [
      { "firmaId": 1, "firmaAd": "ABC", "bakiye": 45000, "gecikmeGun": 28, "oncelik": 1 }
    ]
  }

POST /api/tahsilat/kaydet
  Request: {
    "firmaId": 1,
    "tutar": 15000,
    "odemeTipi": "nakit|cek|havale|kredikarti",
    "aciklama": "Kismi odeme",
    "temsilciId": 5,
    "gpsLat": 41.0082,
    "gpsLon": 28.9784
  }
  Response: { "basarili": true, "islemId": 12345, "kalanBakiye": 30000 }
```

---

### SIPARIS
```
POST /api/siparis/onay-kontrol
  Request:  { "firmaId": 1, "siparisTutari": 25000 }
  Response: {
    "onayDurumu": true,
    "uyarilar": ["Kredi limitinin %92'si kullanilmis"],
    "riskSeviye": "dikkat"
  }

POST /api/siparis/olustur
  Request: {
    "firmaId": 1,
    "temsilciId": 5,
    "kalemler": [
      { "urunKod": "STK001", "miktar": 50, "birimFiyat": 120.00, "iskontoOran": 10 }
    ],
    "platform": "mobil|desktop|b2b"
  }
  Response: { "basarili": true, "siparisId": 678, "toplamTutar": 5400.00 }
```

---

### ZIYARET
```
POST /api/ziyaret/kapat
  Request: {
    "firmaId": 1,
    "temsilciId": 5,
    "satisYapildiMi": true,
    "tahsilatYapildiMi": true,
    "tahsilatTutar": 15000,
    "notlar": "Yeni sezon urunlerini gormek istiyor",
    "sonrakiZiyaretTarih": "2026-04-08",
    "gpsLat": 41.0082,
    "gpsLon": 28.9784
  }
  Response: { "basarili": true, "ziyaretId": 890 }
```

---

### KONUM
```
POST /api/konum/guncelle
  Request: { "temsilciId": 5, "lat": 41.0082, "lon": 28.9784 }
  Response: { "basarili": true }
```

---

### B2B OZEL ENDPOINT'LER
```
GET /api/b2b/urunler?kategori=X&sayfa=1&adet=20
  Response: {
    "toplamKayit": 500,
    "urunler": [
      { "urunKod": "STK001", "urunAd": "...", "fiyat": 120.00, "stokDurum": "mevcut", "resimUrl": "..." }
    ]
  }

GET /api/b2b/stok/{urunKod}
  Response: { "urunKod": "STK001", "fizikselStok": 500, "satilabilirStok": 450, "rezerveStok": 50 }

GET /api/b2b/bakiye
  Response: { "bakiye": 45000, "krediLimit": 100000, "kullanilanLimit": 92000, "vadesiGecmis": 15000 }

GET /api/b2b/siparisler?durum=beklemede&sayfa=1
  Response: {
    "siparisler": [
      { "siparisId": 678, "tarih": "2026-04-01", "tutar": 5400, "durum": "onay_bekliyor" }
    ]
  }

GET /api/b2b/odeme-plani
  Response: {
    "planlar": [
      { "faturNo": "FS-1234", "tutar": 15000, "vadeTarih": "2026-04-15", "durum": "acik" }
    ]
  }

GET /api/b2b/ai/oneriler
  Response: {
    "oneriler": [
      { "urunKod": "STK001", "urunAd": "...", "neden": "Son 3 sipariste aldiniz", "fiyat": 120.00 }
    ]
  }
```

---

## ZAMAN CIZELGESI

| Hafta | PC Agent (Ben) | Mobil/B2B Agent (Diger) |
|-------|----------------|------------------------|
| 1-2 | SQL tablolari + View'lar + Auth endpoint | - (API'yi bekliyor) |
| 2-3 | Risk skoru hesaplama + AI risk aciklama endpoint | - (API'yi bekliyor) |
| 3-4 | Tahsilat + Siparis + Ziyaret endpoint'leri | Mobil: Auth + Giris ekrani |
| 4-5 | AI tahsilat plani + satis oneri endpoint'leri | Mobil: Tahsilat listesi + Musteri karti |
| 5-6 | Desktop UI (risk gosterge, tahsilat ekrani) | Mobil: Siparis + Ziyaret kapanis |
| 6-7 | Stok/Rezervasyon endpoint'leri | B2B: Auth + Urun katalogu |
| 7-8 | Yonetici ozet + Icerik AI endpoint'leri | B2B: Siparis + Bakiye + Odeme plani |
| 8-9 | Desktop UI (yonetici paneli, icerik yardimcisi) | B2B: AI oneriler + Stok gosterim |
| 9-10 | Kural motoru + Audit log finalize | Mobil: GPS + Bildirim + Cache |
| 10-12 | Test + Hata duzeltme + Optimizasyon | Test + Hata duzeltme + Optimizasyon |

---

## DIGER AGENT ICIN NOTLAR

1. **Swagger UI**: API hazir oldugunda `https://desktop.barkodyazilimevi.com/swagger` adresinden tum endpoint'leri test edebilirsin
2. **Auth**: Her istekte `Authorization: Bearer {token}` header'i zorunlu
3. **Hata Formati**: Tum hatalar ayni formatta donecek:
   ```json
   { "basarili": false, "hataKodu": "YETERSIZ_LIMIT", "hataMesaji": "Kredi limiti asildi" }
   ```
4. **Sayfalama**: Liste endpoint'lerinde `?sayfa=1&adet=20` kullan
5. **Tarih Formati**: ISO 8601 (`2026-04-01T10:30:00Z`)
6. **Para Birimi**: Tum tutarlar TL, 2 ondalik
7. **Platform Bilgisi**: Siparis/islem olusturulurken `"platform": "mobil"` veya `"platform": "b2b"` gonder
8. **Online-First (Mobil)**: Kritik veriler cache'lenebilir ama siparis/tahsilat icin sunucu onay sart
9. **B2B Musteri Auth**: B2B musteriler ayri bir login endpoint kullanacak, yetki seviyesi sinirli
10. **API Degisiklik Bildirimi**: Ben endpoint degistirdigimde git commit mesajinda `[API-DEGISIKLIK]` etiketi olacak
