# BARKOD YAZILIM - AI ENTEGRASYON IS PLANI
## Secen A: Bulut API + Hibrit Model (Hazir AI Servisleri + Sirket Verisi + Is Kurallari)

---

## 1. MIMARI YAPI

```
                    +------------------+
                    |   LLM Servisi    |
                    | (GPT/Gemini/     |
                    |  Claude API)     |
                    +--------+---------+
                             |
                             | HTTPS (Sifrelenmis)
                             |
+------------------+  +------+----------+  +------------------+
|  VB.NET Desktop  |  | BusinessSmart   |  |   B2B Web Panel  |
|  (Masaustu App)  +->+  Desktop API    +<-+  (React/Next.js) |
+------------------+  | (C# .NET 8.0)  |  +------------------+
                      |                 |
+------------------+  | - AI Controller |  +------------------+
|  Mobil Uygulama  +->+ - Kural Motoru  +<-+  Pazaryeri       |
|  (iOS/Android)   |  | - Audit Log    |  |  Entegrasyonlari |
+------------------+  | - Veri Erisim  |  +------------------+
                      |   Katmani      |
                      +--------+-------+
                               |
                      +--------+-------+
                      |   SQL Server   |
                      | (View Katmani) |
                      +----------------+
```

**Temel Prensipler:**
- AI ASLA dogrudan veritabanina baglanmaz — sadece View katmani uzerinden veri okur
- AI oneri verir, taslak hazirlar, risk isaretler — parasal islem YAPMAZ
- Tum AI islemleri Audit Log'a kaydedilir
- Ayni API, Desktop + Mobil + B2B + Pazaryeri tarafindan kullanilir

---

## 2. ONCELIK SIRASINA GORE AI OZELLIKLERI

### ONCELIK 1: Cari Risk Skoru + Siparis Onay Kurallari (Ilk 30 Gun)

**Ne Yapilacak:**
- Dinamik risk skoru hesaplama (bakiye, gecikme gunu, odeme disiplini, iade orani, siparis sikligi, temsilci notu)
- Gorsel gosterge: Yesil (guvenli), Sari (dikkat), Kirmizi (kritik)
- Siparis ekraninda limit/gecikme/risk uyarilari
- Is kurallari: 45+ gun gecikme = veresiye satis yasagi

**AI Kullanimi:**
- Risk skorunun NEDENINI dogal dille aciklama
- Ornek: "Bu musteri son 3 ayda 4 faturasini ortalama 28 gun geciktirdi. Son 2 siparisinde %15 iade orani var. Kredi limitinin %92'sini kullanmis durumda."

**API Endpoint'leri:**
```
POST /api/ai/risk-aciklama
  Girdi: { firmaId, riskSkoru, riskVerileri }
  Cikti: { aciklama: "Bu musteri neden riskli...", oneriler: [...] }

GET /api/cari/risk-skoru/{firmaId}
  Cikti: { skor: 72, seviye: "dikkat", detay: {...} }

POST /api/siparis/onay-kontrol
  Girdi: { firmaId, siparisTutari }
  Cikti: { onayDurumu: true/false, redNedeni: "...", uyarilar: [...] }
```

**Maliyet:** Risk aciklama icin LLM cagrisi basina ~$0.002 (GPT-4o-mini)

---

### ONCELIK 2: Tahsilat Oneri Listesi + Tahsilat Ekrani Revizyonu (30-60 Gun)

**Ne Yapilacak:**
- Gunluk tahsilat listesi: "Bugun kimlerden tahsilat yapmaliyim?"
- Onceliklendirme: bakiye buyuklugu + gecikme gunu + rota yakinligi + son temas
- Yonetici dashboard: yuksek riskli musteriler
- Tahsilat ekrani: bakiye, limit, gecikme, risk, son odeme, acik faturalar, aksiyonlar

**AI Kullanimi (Tahsilat AI Asistani):**
- Dogal dil ile tahsilat plani olusturma
- "Bugun 12 tahsilat var. En oncelikli 3 musteri: 1) Firma X - 45.000 TL, 62 gun gecikme, ofisi yakin..."
- Musteri bazli tahsilat stratejisi onerisi

**API Endpoint'leri:**
```
GET /api/ai/tahsilat-plani?temsilciId=X&tarih=2026-04-01
  Cikti: {
    ozet: "Bugun 12 tahsilat onerilmektedir...",
    liste: [
      { firmaId, firmaAd, bakiye, gecikmeGun, oncelik, rota, strateji }
    ]
  }

POST /api/ai/tahsilat-strateji
  Girdi: { firmaId }
  Cikti: { strateji: "Bu musteriyle yuzyuze gorusme onerilir...", sonOdemeGecmisi: "..." }
```

**Mobil Entegrasyon:**
- Saha temsilcisi telefondan tahsilat listesini gorup, tahsilat kaydedebilir
- GPS ile rota optimizasyonu
- Ziyaret sonrasi hizli anket: tahsilat yapildi mi, neden yapilmadi, sonraki ziyaret

**B2B Entegrasyon:**
- B2B panelinde musteri kendi bakiyesini ve odeme planini gorebilir
- Otomatik hatirlatma e-postalari

---

### ONCELIK 3: Sicak Satis Musteri Karti + Ziyaret Kapanis Akisi (30-60 Gun)

**Ne Yapilacak:**
- Musteri kartinda detayli gecmis: son siparisler, iadeler, odemeler, notlar
- Ziyaret -> Satis -> Tahsilat -> Iade -> Not -> Sonraki Aksiyon zinciri
- Temsilci rotalari: tahsilat/satis potansiyeline gore onceliklendirme

**AI Kullanimi (Satis Oneri Motoru):**
- "Bu musteriye son 3 siparisine gore sunlari teklif edebilirsin: Urun A (son 2 sipariste aldi), Urun B (benzer musteriler aliyor)"
- OTOMATIK SIPARIS URETMEZ — sadece oneri, insan onayi sart

**API Endpoint'leri:**
```
POST /api/ai/satis-oneri
  Girdi: { firmaId }
  Cikti: {
    oneriler: [
      { urunKod, urunAd, neden: "Son 3 sipariste aldi", tahminMiktar: 50 }
    ]
  }

POST /api/ziyaret/kapat
  Girdi: { firmaId, temsilciId, satisYapildiMi, tahsilatMi, notlar, sonrakiZiyaret }
```

**Mobil:**
- Temsilci sahada musteri kartini acar, AI onerisini gorur, siparis olusturur
- Online-first: veri canli, baglanti kopsa taslak kaydeder

---

### ONCELIK 4: Tek Stok Havuzu + Rezervasyon Mantigi (60-90 Gun)

**Ne Yapilacak:**
- Stok turleri netlestirilmesi: fiziksel, satilabilir, rezerve, iade bekleyen
- Kanal bazli rezervasyon suresi ve guvenlik stogu
- Urun eslestirme hata alarmlari (barkod, varyant, fiyat, kategori)

**AI Kullanimi:**
- Stok tahmin onerisi: "Bu urunun satisi son 2 haftada %30 artti, guvenlik stogunu artirmayi dusunun"
- Kanal bazli stok dagitim onerisi

**B2B Entegrasyon:**
- B2B musterileri canli stok gorebilir
- Rezervasyon yapabilir (insan onayi ile)

---

### ONCELIK 5: Yonetici Dashboard + AI Ozetleri (60-90 Gun)

**Ne Yapilacak:**
- Gun sonu AI ozeti: satis nerede yukseldi, tahsilat nerede aksadi, hangi kanal marj dusurdu
- Haftalik rapor: veri tablosu + aksiyon onerisi
- Ornek: "Bu hafta X musteri grubunda iskonto sikilastir, Y urunde guvenlik stogunu artir"

**API Endpoint'leri:**
```
GET /api/ai/gun-sonu-ozet?tarih=2026-04-01
  Cikti: {
    ozet: "Bugun toplam satis 125.000 TL (%8 artis). Tahsilat 89.000 TL...",
    satisAnaliz: "...",
    tahsilatAnaliz: "...",
    aksiyonlar: ["X musteride iskonto gozden gecir", "Y urunde stok tamamla"]
  }

GET /api/ai/haftalik-rapor?hafta=2026-W14
  Cikti: {
    ozet: "...",
    trendler: [...],
    aksiyonOnerileri: [...]
  }
```

**Maliyet:** Gunluk ozet ~$0.01-0.05 (veri boyutuna gore)

---

### ONCELIK 6: Urun Aciklama + Pazaryeri Icerik Yardimcisi (90+ Gun)

**AI Kullanimi:**
- Yasakli ifade, gereksiz karakter, hatali baslik, kopya aciklama tespiti
- Pazaryeri ilani hazirlama: baslik, kisa aciklama, teknik ozellik ozeti, etiket uretimi
- Ornek: Urun kodu gir -> AI otomatik Trendyol/Hepsiburada formatinda ilan taslas olusturur

**API Endpoint'leri:**
```
POST /api/ai/urun-aciklama-temizle
  Girdi: { urunKod, mevcutAciklama }
  Cikti: { temizAciklama, tespit: ["yasakli kelime: X", "fazla bosluk"], skor: 85 }

POST /api/ai/pazaryeri-ilan
  Girdi: { urunKod, platform: "trendyol" }
  Cikti: { baslik, kisaAciklama, teknikOzellik, etiketler }
```

---

## 3. TEKNIK ALTYAPI

### 3.1. Kural Motoru
```sql
-- Ornek: tbIsKurallari tablosu
CREATE TABLE tbIsKurallari (
    nKuralID INT IDENTITY PRIMARY KEY,
    sKuralTipi NVARCHAR(50),        -- 'SIPARIS_ONAY', 'KREDI_LIMIT', 'ISKONTO'
    sKosul NVARCHAR(500),           -- JSON formatinda kosul
    sAksiyon NVARCHAR(500),         -- JSON formatinda aksiyon
    bAktif BIT DEFAULT 1,
    dtOlusturma DATETIME DEFAULT GETDATE()
)
```

### 3.2. Audit Log
```sql
CREATE TABLE tbAuditLog (
    nLogID BIGINT IDENTITY PRIMARY KEY,
    sKullanici NVARCHAR(100),
    sIslem NVARCHAR(100),          -- 'AI_RISK_SORGULAMA', 'AI_TAHSILAT_PLANI', 'FIYAT_DEGISIKLIK'
    sDetay NVARCHAR(MAX),          -- JSON
    sAIModel NVARCHAR(50),         -- 'gpt-4o-mini', 'gemini-flash' vb.
    dtIslem DATETIME DEFAULT GETDATE(),
    sIPAdres NVARCHAR(50)
)
```

### 3.3. AI Veri Erisim Katmani (View)
```sql
-- AI sadece bu view'lar uzerinden veri okur, dogrudan tablo erisimi yok
CREATE VIEW vw_AI_CariRiskVerisi AS
SELECT
    f.nFirmaID, f.sAciklama AS FirmaAd,
    f.sVergiNo, f.sIl, f.sSemt,
    SUM(CASE WHEN c.sBorcAlacak='B' THEN c.lTutar ELSE 0 END) AS ToplamBorc,
    SUM(CASE WHEN c.sBorcAlacak='A' THEN c.lTutar ELSE 0 END) AS ToplamAlacak,
    DATEDIFF(DAY, MAX(c.dteFisTarihi), GETDATE()) AS SonIslemGun
FROM tbFirma f
LEFT JOIN tbCariHareket c ON f.nFirmaID = c.nFirmaID
GROUP BY f.nFirmaID, f.sAciklama, f.sVergiNo, f.sIl, f.sSemt

CREATE VIEW vw_AI_SatisGecmisi AS
SELECT
    m.nFirmaID, m.dteFisTarihi, m.lNetTutar, m.lKdvTutar,
    d.sStokKodu, d.sStokAdi, d.lMiktar, d.sBirim
FROM tbStokFisiMaster m
INNER JOIN tbStokFisiDetay d ON m.nStokFisiID = d.nStokFisiID
WHERE m.sFisTipi IN ('FS', 'FT')
```

### 3.4. AI Servis Katmani (C# API)
```
BusinessSmartDesktopAPI/
  Controllers/
    AIController.cs          -- Tum AI endpoint'leri
    RiskController.cs        -- Risk skoru hesaplama
    TahsilatController.cs    -- Tahsilat plani
  Services/
    LLMService.cs            -- GPT/Gemini/Claude cagrisi (tek nokta)
    RiskHesaplayici.cs       -- Kural bazli risk skoru
    TahsilatPlanlayici.cs    -- Tahsilat onceliklendirme
    SatisOneriMotoru.cs      -- Satis onerisi
    IcerikTemizleyici.cs     -- Urun aciklama AI
  Models/
    AIRequest.cs
    AIResponse.cs
    RiskModeli.cs
  Middleware/
    AuditLogMiddleware.cs    -- Her AI cagrisi loglanir
    RateLimitMiddleware.cs   -- API cagri limiti
```

---

## 4. MALIYET TAHMINI (AYLIK)

| Ozellik | Gunluk Cagri | Cagri Basi Maliyet | Aylik Maliyet |
|---------|-------------|-------------------|--------------|
| Risk Aciklama | ~50 | $0.002 | ~$3 |
| Tahsilat Plani | ~10 | $0.005 | ~$1.5 |
| Satis Onerisi | ~30 | $0.003 | ~$2.7 |
| Gun Sonu Ozet | 1 | $0.05 | ~$1.5 |
| Haftalik Rapor | 0.25 | $0.10 | ~$0.1 |
| Icerik Temizleme | ~20 | $0.005 | ~$3 |
| **TOPLAM** | | | **~$12/ay** |

GPT-4o-mini veya Gemini Flash kullanildiginda maliyet cok dusuk.
Gerektiginde daha guclu model (GPT-4o, Claude) kullanilabilir (~5x maliyet artisi).

---

## 5. GUVENLIK

- API Key sunucuda saklanir, istemciye gonderilmez
- AI'ya giden veride kisisel veri minimizasyonu (TC, telefon gondermeden risk hesapla)
- Rate limiting: kullanici basi saatte max 100 AI cagrisi
- Tum AI cagrilari Audit Log'da
- AI ciktilari "ONERI" olarak isaretlenir, kesinlikle "KARAR" olarak sunulmaz

---

## 6. 90 GUNLUK YOL HARITASI

### Ilk 30 Gun
- [ ] Risk skoru icin veri alanlari tanimla (tbCariHareket, tbStokFisiMaster)
- [ ] Risk skoru formulu kesinlestir (agirlikli puanlama)
- [ ] BusinessSmartDesktopAPI'ye AIController ekle
- [ ] LLMService.cs - GPT/Gemini entegrasyonu
- [ ] Siparis ekranina limit/gecikme/risk uyarisi ekle
- [ ] POST /api/ai/risk-aciklama endpoint'i canli
- [ ] Audit Log tablosu ve middleware

### 31-60 Gun
- [ ] Tahsilat oneri listesi ve gunluk gorev ekrani
- [ ] GET /api/ai/tahsilat-plani endpoint'i
- [ ] Sicak satis musteri karti ve ziyaret kapanis formu
- [ ] POST /api/ai/satis-oneri endpoint'i
- [ ] Mobil API'ler hazir (ayni endpoint'ler)
- [ ] B2B panel icin bakiye/odeme plani ekrani

### 61-90 Gun
- [ ] Yonetici ozet paneli + dogal dille haftalik rapor
- [ ] Dusuk riskli AI araclari: aciklama temizleme, ilan yardimcisi
- [ ] AI kullanim loglari ve yetki sinirlari netlestirilmesi
- [ ] Performans olcumleri ve maliyet takibi
