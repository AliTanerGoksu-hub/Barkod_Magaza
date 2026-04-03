# MOBIL VE B2B AGENT ICIN GOREV DOKUMANI
## PC Agent Tarafindan Hazirlanan API ve Veri Yapisi Uzerine Yapilacaklar

---

## GENEL BILGI

PC Agent (Desktop taraf) asagidaki islemleri tamamlamistir veya tamamlayacaktir:
- BusinessSmartDesktopAPI (C# .NET 8.0) uzerinde AI endpoint'leri
- SQL tablolari: tbRiskSkoru, tbAuditLog, tbSistemAyar parametreleri
- Yetki tanimlari: aEmirForms tablosunda AI yetki kayitlari
- View katmani: vw_AI_CariRiskVerisi, vw_AI_SatisGecmisi

Mobil ve B2B agent bu API'yi TUKETECEK (consume), API'yi DEGISTIRMEYECEK.

---

## A. MOBIL UYGULAMA GOREVLERI

### A1. Authentication (Giris)
```
POST /api/auth/login
Request:  { "kullaniciAdi": "...", "sifre": "...", "platform": "mobil" }
Response: { "token": "JWT", "kullaniciId": 1, "yetki": "temsilci", "firmaId": 5 }
```
- JWT token'i her istekte `Authorization: Bearer {token}` header'inda gonder
- Token suresi dolunca `POST /api/auth/refresh` ile yenile

### A2. Tahsilat Listesi Ekrani
```
GET /api/tahsilat/gunluk-plan?temsilciId={id}&tarih={yyyy-MM-dd}
Response: {
  "planlar": [
    { "firmaId": 1, "firmaAd": "ABC", "bakiye": 45000, "gecikmeGun": 28, "oncelik": 1,
      "riskSeviye": "dikkat", "il": "Istanbul", "semt": "Beylikduzu" }
  ]
}
```
**UI Gereksinimleri:**
- Liste oncelik sirasina gore siralanmis gelmeli
- Risk seviyesine gore renk kodu: yesil (guvenli), sari (dikkat), kirmizi (kritik)
- Her satirda firma adi, bakiye, gecikme gunu, risk gostergesi
- Satira tiklaninca musteri detay ekranina git

### A3. AI Tahsilat Plani (Yetki: ai_tahsilat_plani)
```
GET /api/ai/tahsilat-plani?temsilciId={id}&tarih={yyyy-MM-dd}
Response: {
  "ozet": "Bugun 12 tahsilat onerilmektedir...",
  "liste": [
    { "firmaId": 1, "firmaAd": "ABC", "bakiye": 45000, "gecikmeGun": 28,
      "oncelik": 1, "riskSeviye": "dikkat", "strateji": "Yuzyuze gorusme onerilir..." }
  ]
}
```
**UI Gereksinimleri:**
- Ekranin ustunde AI ozet metni goster
- Kullanicinin AI_MODUL_AKTIF=0 ise bu butonu GIZLE
- Kullanicinin ai_tahsilat_plani yetkisi yoksa butonu GIZLE

### A4. Musteri Karti Detay
```
GET /api/cari/{firmaId}/detay
Response: {
  "firmaId": 1, "firmaAd": "ABC Tekstil",
  "bakiye": 45000, "krediLimit": 100000, "riskSkoru": 72, "riskSeviye": "dikkat",
  "gecikmeGun": 28, "sonOdemeTarih": "2026-03-15",
  "il": "Istanbul", "semt": "Beylikduzu", "telefon": "..."
}
```
**UI Gereksinimleri:**
- Bakiye ve kredi limit bilgisi: SADECE `cari_bakiye_gor` ve `cari_kredi_limit_gor` yetkisi olan kullanicilar gorebilir
- Risk skoru: SADECE `ai_risk_skoru_gor` yetkisi olan kullanicilar gorebilir

### A5. AI Risk Aciklamasi (Yetki: ai_risk_aciklama_gor)
```
POST /api/ai/risk-aciklama
Request:  { "firmaId": 1 }
Response: {
  "aciklama": "Bu musteri son 3 ayda 4 faturasini ortalama 28 gun geciktirdi...",
  "oneriler": ["Veresiye satisi sinirlayın"]
}
```
**UI:** Musteri karti icinde "Risk Analizi" butonu. Tiklaninca popup/bottomsheet ile AI aciklama goster.

### A6. AI Satis Onerisi (Yetki: ai_satis_onerisi)
```
POST /api/ai/satis-oneri
Request:  { "firmaId": 1 }
Response: {
  "oneriler": [
    { "urunKod": "STK001", "urunAd": "...", "neden": "Son 3 sipariste aldi",
      "tahminMiktar": 50, "birimFiyat": 120.00 }
  ]
}
```
**UI:** Musteri karti icinde "AI Oneri" butonu. Oneriler listesi gosterilir.
**ONEMLI:** Oneri tiklaninca siparis formuna otomatik eklenebilir ama INSAN ONAYI SART.

### A7. Siparis Olusturma
```
POST /api/siparis/onay-kontrol
Request:  { "firmaId": 1, "siparisTutari": 25000 }
Response: { "onayDurumu": true, "uyarilar": ["Kredi limitinin %92'si kullanilmis"], "riskSeviye": "dikkat" }

POST /api/siparis/olustur
Request: {
  "firmaId": 1, "temsilciId": 5,
  "kalemler": [ { "urunKod": "STK001", "miktar": 50, "birimFiyat": 120, "iskontoOran": 10 } ],
  "platform": "mobil"
}
Response: { "basarili": true, "siparisId": 678, "toplamTutar": 5400 }
```
**UI:**
- Siparis kaydetmeden once `onay-kontrol` cagir
- Uyari varsa kullaniciya goster, onay iste
- SIPARIS_LIMIT_KONTROL=1 ise limit uyarisi gosterilmeli

### A8. Ziyaret Kapanis (MEVCUT - tbVisitNote)
```
POST /api/ziyaret/kapat (veya mevcut /api/VisitNote/Add)
```
**NOT:** Bu zaten mobil agent tarafindan yapilmis. tbVisitNote tablosuna yaziliyor.
Desktop tarafinda da ayni tabloyu okuyacagiz.

### A9. Tahsilat Kaydi
```
POST /api/tahsilat/kaydet
Request: {
  "firmaId": 1, "tutar": 15000, "odemeTipi": "nakit",
  "aciklama": "Kismi odeme", "temsilciId": 5,
  "gpsLat": 41.0082, "gpsLon": 28.9784
}
Response: { "basarili": true, "islemId": 12345, "kalanBakiye": 30000 }
```

### A10. GPS Konum Guncelleme
```
POST /api/konum/guncelle
Request: { "temsilciId": 5, "lat": 41.0082, "lon": 28.9784 }
```

---

## B. B2B WEB PANEL GOREVLERI

### B1. B2B Musteri Girisi
```
POST /api/auth/login
Request: { "kullaniciAdi": "musteri@firma.com", "sifre": "...", "platform": "b2b" }
Response: { "token": "JWT", "yetki": "b2b_musteri", "firmaId": 5 }
```
**NOT:** B2B musterileri SINIRLI yetkilere sahip. Sadece kendi firma verilerini gorebilir.

### B2. Urun Katalogu
```
GET /api/b2b/urunler?kategori={kat}&arama={q}&sayfa=1&adet=20
Response: {
  "toplamKayit": 500,
  "urunler": [
    { "urunKod": "STK001", "urunAd": "...", "fiyat": 120, "stokDurum": "mevcut", "resimUrl": "..." }
  ]
}
```
**UI:** Urun kartlari grid, arama, kategori filtresi, stok durumu gosterimi

### B3. Canli Stok Gosterimi
```
GET /api/b2b/stok/{urunKod}
Response: { "urunKod": "STK001", "fizikselStok": 500, "satilabilirStok": 450, "rezerveStok": 50 }
```

### B4. Siparis Olusturma
```
POST /api/b2b/siparis
Request: {
  "kalemler": [ { "urunKod": "STK001", "miktar": 50 } ],
  "platform": "b2b"
}
Response: { "basarili": true, "siparisId": 678, "durum": "onay_bekliyor" }
```
**NOT:** B2B siparisleri her zaman "onay_bekliyor" durumunda baslar. Desktop kullanicisi onaylar.

### B5. Siparis Takibi
```
GET /api/b2b/siparisler?durum={durum}&sayfa=1
Response: {
  "siparisler": [
    { "siparisId": 678, "tarih": "2026-04-01", "tutar": 5400, "durum": "onay_bekliyor",
      "kalemSayisi": 3 }
  ]
}
```

### B6. Bakiye ve Ekstre
```
GET /api/b2b/bakiye
Response: { "bakiye": 45000, "krediLimit": 100000, "kullanilanLimit": 92000, "vadesiGecmis": 15000 }

GET /api/b2b/ekstre?baslangic={tarih}&bitis={tarih}
Response: {
  "hareketler": [
    { "tarih": "2026-03-01", "aciklama": "Fatura #1234", "borc": 5000, "alacak": 0, "bakiye": 45000 }
  ]
}
```

### B7. Odeme Plani
```
GET /api/b2b/odeme-plani
Response: {
  "planlar": [
    { "faturNo": "FS-1234", "tutar": 15000, "vadeTarih": "2026-04-15", "durum": "acik" }
  ]
}
```

### B8. AI Urun Onerisi (B2B Musteriye)
```
GET /api/b2b/ai/oneriler
Response: {
  "oneriler": [
    { "urunKod": "STK001", "urunAd": "...", "neden": "Son 3 sipariste aldiniz", "fiyat": 120 }
  ]
}
```
**NOT:** SATIS_ONERI_AKTIF=0 ise bu endpoint bos liste doner

---

## C. YETKI KONTROLLERI (HER IKI PLATFORM)

Her API cagrisi oncesinde kullanici yetkisini kontrol et:
```
GET /api/yetki/kontrol?form={formAdi}
Response: { "yetkili": true }
```

| Yetki Kodu | Aciklama | Mobil | B2B |
|-----------|---------|-------|-----|
| ai_risk_skoru_gor | Risk skoru gorebilir | Evet | Hayir |
| ai_risk_aciklama_gor | AI risk aciklamasi | Evet | Hayir |
| ai_tahsilat_plani | Tahsilat plani | Evet | Hayir |
| ai_satis_onerisi | Satis onerisi | Evet | Hayir (ayri endpoint) |
| ai_yonetici_ozet | Yonetici ozeti | Evet | Hayir |
| cari_bakiye_gor | Bakiye bilgisi | Evet | Evet (kendi firmasininki) |
| cari_kredi_limit_gor | Kredi limit bilgisi | Evet | Evet (kendi firmasininki) |

**KURAL:** Yetkisi olmayan ozellik icin UI elementi GIZLENMELI, sadece disable edilmemeli.

---

## D. PARAMETRIK AYARLAR (GIZLE/GOSTER)

Bu ayarlar `tbSistemAyar` tablosundan okunur:
```
GET /api/sistem/ayar/{ayarKodu}
Response: { "ayarKodu": "AI_MODUL_AKTIF", "ayarDeger": "1" }
```

| Ayar Kodu | Deger | Etki |
|----------|-------|------|
| AI_MODUL_AKTIF | 0/1 | 0 ise tum AI butonlari gizle |
| RISK_SKORU_AKTIF | 0/1 | 0 ise risk gostergeleri gizle |
| TAHSILAT_AI_AKTIF | 0/1 | 0 ise tahsilat AI onerisi gizle |
| SATIS_ONERI_AKTIF | 0/1 | 0 ise satis onerisi gizle |
| SIPARIS_LIMIT_KONTROL | 0/1 | 0 ise limit kontrolu yapma |
| PERAKENDE_RISK_AKTIF | 0/1 | 0 ise perakende risk gizle |

**KURAL:** Ayar = "0" veya bos ise ozellik GIZLENMELI. Kullanici o ozelligin var oldugunu bile bilmemeli.

---

## E. HATA FORMATI (STANDART)

Tum API hatalari ayni formatta donecek:
```json
{ "basarili": false, "hataKodu": "YETERSIZ_LIMIT", "hataMesaji": "Kredi limiti asildi" }
```

HTTP Durum Kodlari:
- 200: Basarili
- 400: Gecersiz istek (eksik parametre vb.)
- 401: Yetkisiz (token gecersiz)
- 403: Erisim engellendi (yetki yok)
- 404: Kayit bulunamadi
- 500: Sunucu hatasi

---

## F. ORTAK KURALLAR

1. **Tarih Formati:** ISO 8601 (`2026-04-01T10:30:00Z`)
2. **Para Birimi:** TL, 2 ondalik (`45000.00`)
3. **Sayfalama:** `?sayfa=1&adet=20` (varsayilan adet=20, max=100)
4. **Platform Bilgisi:** Siparis/islem olusturulurken `"platform": "mobil"` veya `"platform": "b2b"` gonder
5. **Online-First (Mobil):** Kritik veriler cache'lenebilir ama siparis/tahsilat/odeme icin sunucu onay SART
6. **B2B Musteri Izolasyonu:** B2B musterisi SADECE kendi firma verilerini gorebilir. API tarafinda firmaId token'dan alinir, request'ten degil
7. **Audit Log:** Tum AI cagrilari, siparis olusturma, tahsilat kaydi otomatik loglanir
8. **API Degisiklik Bildirimi:** PC Agent endpoint degistirdiginde commit mesajinda `[API-DEGISIKLIK]` etiketi olacak

---

## G. MEVCUT TABLOLAR (ORTAK KULLANIM)

Bu tablolar her iki tarafin da kullandigi tablolardir. Yeni kolon eklenecekse KOORDINE EDIN:

| Tablo | Kullanan | Aciklama |
|-------|---------|---------|
| tbVisitNote | Mobil + Desktop | Ziyaret notlari |
| tbVisitNoteResim | Mobil + Desktop | Ziyaret notu resimleri |
| tbRouteDetail | Mobil + Desktop | Rota detay |
| tbRoute | Mobil + Desktop | Rota ana kayit |
| tbRiskSkoru | Desktop + Mobil (okuma) | Risk skoru (Desktop yazar, Mobil okur) |
| tbAuditLog | Desktop + Mobil + B2B | Audit log (hepsi yazar) |
| tbSistemAyar | Desktop + Mobil + B2B | Parametrik ayarlar (hepsi okur) |
