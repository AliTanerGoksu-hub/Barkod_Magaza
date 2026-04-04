# BARKOD YAZILIM - PRD (Product Requirements Document)

## Proje Ozeti
Legacy VB.NET Windows Forms ERP/POS uygulamasi (Barkod_Magaza) + C# .NET 8 Web API (BusinessSmartDesktopAPI) + Mobil Backend (BarkodBackend) + .NET MAUI Blazor Mobil (BusinessSmartMobile).

## Mimari (3 Katman)
- **Desktop Frontend**: VB.NET Windows Forms (DevExpress, CP1254 encoding)
- **Desktop API**: C# .NET 8 Minimal APIs (BusinessSmartDesktopAPI) - Backup/License/AI
- **Mobil Backend**: C# ASP.NET Core (BarkodBackend) - Dapper, Multi-ERP adapter
- **Mobil Frontend**: .NET MAUI Blazor (BusinessSmartMobile) + React B2B Web
- **Veritabani**: SQL Server (OleDb desktop, Dapper mobil)

## Tamamlanan Ozellikler

### AI Backend - Desktop API (BusinessSmartDesktopAPI)
- [x] POST /api/ai/risk-analiz, /api/ai/risk-aciklama
- [x] GET /api/ai/tahsilat-plani
- [x] POST /api/ai/satis-oneri
- [x] GET /api/ai/gun-sonu-ozet
- [x] GET /api/ai/perakende-ozet
- [x] POST /api/siparis/onay-kontrol
- [x] GET /api/sistem/ayar, /api/yetki/kontrol
- [x] GET /api/cari/risk-skoru, /api/perakende/risk-skoru
- [x] LLMService, AuditService, KuralMotoru

### AI Backend - Mobil API (BarkodBackend/New_Backend)
- [x] GET /api/AI/RiskScore/{firmaId}
- [x] GET /api/AI/CollectionPlan
- [x] GET /api/AI/SalesSuggestions/{firmaId}
- [x] GET /api/AI/DailySummary
- [x] GET /api/AI/RetailSummary
- [x] GET /api/AI/OrderRiskCheck/{firmaId}

### AI UI - Desktop (VB.NET)
- [x] frm_firma_kart.vb - Risk panel + AI Detay + Satis Oneri butonlari
- [x] frm_perakende.vb - Risk panel + AI + Oneri butonlari
- [x] frm_stok_cari_alis.vb - Siparis risk kontrolu (parametrik)
- [x] frm_AITahsilatAsistani.vb, frm_AIGunSonuOzet.vb, frm_AISatisOneri.vb
- [x] frm_YoneticiOzetPaneli.vb (Toptan + Perakende)
- [x] Form1.vb AI menusu (8 buton)

### AI UI - Mobil (BusinessSmartMobile/New_Mobile)
- [x] AIService.cs - HTTP client + response modelleri
- [x] PatronAIDashboard.razor - AI ozet paneli (KPI + Risk + Tahsilat)
- [x] PatronDashboard.razor - AI menu butonu

### Onceki Calismalar
- [x] B2B Settings, POS error handling, R2 image upload
- [x] Backup FTP->API migration
- [x] SQL Views, Parametrik togglelar, Valor/Limit kontrol

## Bekleyen Gorevler
- [ ] P2: Maliyet hesaplama standardizasyonu (FIFO, LIFO, Agirlikli Ortalama)
- [ ] P2: E-Fatura/E-Arsiv otomatik eslestirme
- [ ] P2: AI kullanim loglari UI
- [ ] P2: Dusuk riskli AI araclari (aciklama temizleme, ilan yardimcisi)

## Repolar
- Desktop: github.com/AliTanerGoksu-hub/Barkod_Magaza.git
- Mobil Backend: github.com/AliTanerGoksu-hub/New_Backend.git
- Mobil Frontend: github.com/AliTanerGoksu-hub/New_Mobile.git
