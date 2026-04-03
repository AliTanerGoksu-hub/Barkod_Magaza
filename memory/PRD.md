# BARKOD YAZILIM - PRD (Product Requirements Document)

## Orijinal Problem
Legacy VB.NET Windows Forms ERP/POS uygulamasina AI entegrasyonu, B2B yonetimi, 
E-Fatura/E-Arsiv eslestirme ve maliyet hesaplama standardizasyonu eklenmesi.

## Mimari
- Frontend: VB.NET Windows Forms + DevExpress
- Backend API: C# .NET 8.0 Minimal API (BusinessSmartDesktopAPI)
- Database: SQL Server (OleDb + SqlClient)
- AI: Bulut API (OpenAI GPT-4o-mini / Gemini) - opsiyonel
- Mobil: MAUI Blazor (ayri agent)
- B2B: Web Panel (ayri agent)

## Tamamlanan Isler

### 2026-04-01: AI Altyapi Kurulumu
- [x] AI_IS_PLANI.md - 6 oncelikli AI ozelligi, maliyet, 90 gunluk yol haritasi
- [x] KOORDINELI_GELISTIRME_PLANI.md - PC/Mobil/B2B gorev dagilimi, ortak API kontrati
- [x] VERI_ALTYAPISI_PLANI.md - Parametrik ayarlar, yetki, veri degisiklikleri
- [x] MOBIL_B2B_AGENT_GOREV_DOKUMANI.md - Diger agent icin tum API detaylari
- [x] SQL: tbRiskSkoru, tbAuditLog tablosu, tbSistemAyar parametrik ayarlar
- [x] SQL: aEmirForms yetki tanimlari (AI modulleri icin)
- [x] SQL: vw_AI_CariRiskVerisi, vw_AI_SatisGecmisi, vw_AI_PerakendeRiskVerisi view'lari
- [x] C# API: AIService.cs (LLM cagrisi - GPT/Gemini)
- [x] C# API: RiskService.cs (Risk skoru hesaplama + sistem ayar + yetki kontrol)
- [x] C# API: AuditService.cs (Audit log)
- [x] C# API Endpoint'leri:
  - GET /api/cari/risk-skoru/{firmaId}
  - POST /api/ai/risk-aciklama
  - GET /api/ai/tahsilat-plani
  - POST /api/ai/satis-oneri
  - GET /api/ai/gun-sonu-ozet
  - GET /api/cari/{firmaId}/detay
  - GET /api/perakende/risk-skoru/{musteriId}
  - GET /api/sistem/ayar/{ayarKodu}
  - GET /api/yetki/kontrol
- [x] VB.NET: master_kaydet_yeni - parametrik valor tarihi + kredi limit kontrolu
- [x] frm_fatura_liste.vb: GIB tutar parse fix (InvariantCulture)
- [x] frm_fatura_liste.vb: Eslestirme algoritmasi: Isim -> Adres -> Tutar sirasi

### Onceki Oturumlar:
- [x] B2B Settings tab
- [x] POS 400 Bad Request hata isleme
- [x] R2 Logo upload (Sinif + Firma)
- [x] Otomatik yedek hata duzeltmeleri
- [x] FTP -> API migrasyon
- [x] E-Fatura/E-Arsiv API pagination
- [x] TurkceNormalize fonksiyonu

## Devam Eden Isler (P0)
- [ ] GIB eslestirme: Tutar parse duzeltmesi test edilmeli (kullanicidan yeni log bekleniyor)

## Siradaki Isler (P1)
- [ ] Desktop UI: Cari kartta risk gostergesi (yesil/sari/kirmizi)
- [ ] Desktop UI: Siparis ekraninda AI uyarilari
- [ ] Desktop UI: AI ayarlari yonetim ekrani (tbSistemAyar CRUD)
- [ ] Desktop UI: Tahsilat ekrani revizyonu
- [ ] Perakende: Acik hesap musteri kartinda risk gostergesi

## Gelecek Isler (P2)
- [ ] Stok tahmin ve guvenlik stogu onerisi
- [ ] Urun aciklama temizleme / pazaryeri ilan yardimcisi
- [ ] Kolaysoft SOAP cagrlarini ayri service class'a tasi
- [ ] Maliyet hesaplama standardizasyonu

## Parametrik Ayarlar (tbSistemAyar)
| Kod | Varsayilan | Aciklama |
|-----|-----------|---------|
| AI_MODUL_AKTIF | 0 | AI ozellikleri acik/kapali |
| VALOR_TARIHI_ZORUNLU | 0 | Faturada valor tarihi zorunlu |
| KREDI_LIMIT_UYARI | 0 | Firma kartinda kredi limit uyarisi |
| RISK_SKORU_AKTIF | 0 | Risk skoru hesaplama |
| PERAKENDE_RISK_AKTIF | 0 | Perakende risk takibi |
| SIPARIS_LIMIT_KONTROL | 0 | Siparis kaydetmede limit kontrol |
| TAHSILAT_AI_AKTIF | 0 | AI tahsilat plani |
| SATIS_ONERI_AKTIF | 0 | AI satis onerisi |
| YONETICI_OZET_AKTIF | 0 | AI yonetici ozeti |
| ICERIK_YARDIMCI_AKTIF | 0 | AI icerik yardimcisi |
