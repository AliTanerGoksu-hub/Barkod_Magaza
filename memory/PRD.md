# BARKOD YAZILIM - PRD (Product Requirements Document)

## Proje Ozeti
Legacy VB.NET Windows Forms ERP/POS uygulamasi (Barkod_Magaza) + C# .NET 8 Web API (BusinessSmartDesktopAPI) + Mobil Backend (BarkodBackend) + .NET MAUI Blazor Mobil (BusinessSmartMobile).

## Mimari (3 Katman)
- **Desktop Frontend**: VB.NET Windows Forms (DevExpress, CP1254 encoding)
- **Desktop API**: C# .NET 8 Minimal APIs (BusinessSmartDesktopAPI) - Backup/License ONLY (AI kaldirildi)
- **Mobil Backend**: C# ASP.NET Core (BarkodBackend) - Dapper, Multi-ERP adapter
- **Mobil Frontend**: .NET MAUI Blazor (BusinessSmartMobile)
- **Veritabani**: SQL Server (OleDb desktop, Dapper mobil)

## Repolar
- Desktop: github.com/AliTanerGoksu-hub/Barkod_Magaza.git
- Mobil Backend: github.com/AliTanerGoksu-hub/New_Backend.git
- Mobil Frontend: github.com/AliTanerGoksu-hub/New_Mobile.git

## Tamamlanan Ozellikler

### AI Risk Hesaplama - Desktop (AIService.vb + RiskBildirimModulu.vb)
- [x] Risk Skoru: Bakiye, Vadesi Gecmis, Max Gecikme, Kredi Limiti
- [x] Risk Skoru: Ortalama Vade (nVadeGun + AVG DATEDIFF)
- [x] Risk Skoru: Cek/Senet riski (tbCekSenet + tbCekSenetBordro)
- [x] RiskBildirimModulu: Sessiz risk paneli tum satis formlarinda
- [x] frm_AISatisOneri.vb: Satis Oneri Motoru (AIService.SatisOneriGetir)
- [x] frm_AIGunSonuOzet.vb, frm_AITahsilatAsistani.vb
- [x] frm_YoneticiOzetPaneli.vb: Patron ozet paneli

### AI Risk Hesaplama - Mobile Backend (AIController.cs) [GUNCELLENDI 2026-02-11]
- [x] GET /api/AI/RiskScore/{firmaId} - Cek/Senet + OrtVade EKLENDI
- [x] GET /api/AI/OrderRiskCheck/{firmaId} - Karsilikizsiz cek REDDET karari EKLENDI
- [x] GET /api/AI/CollectionPlan - Vadesi gecmis bakiye koruması eklendi
- [x] GET /api/AI/SalesSuggestions/{firmaId} - Fatura bazli sorgu (Desktop ile senkron)
- [x] GET /api/AI/DailySummary
- [x] GET /api/AI/RetailSummary

### AI UI - Mobile App (BusinessSmartMobile) [GUNCELLENDI 2026-02-11]
- [x] AIService.cs: Tum modeller Desktop ile senkron (CekPortfoy, CekVadesiGecmis, OrtVade vb.)
- [x] BusinessPartnerDetail.razor: Risk detaylarinda OrtVade, Cek/Senet bilgileri
- [x] SatisOneriMotoru.razor: Firma bazli satis oneri sayfasi (aktif/hatirlatma)
- [x] PatronAIDashboard.razor: AI ozet paneli

### Desktop Temizlik [2026-02-11]
- [x] Eski API_URL/API_KEY sabitleri 4 dosyadan kaldirildi
- [x] FtpEskiYedekleriSil_ESKI temiz (bos metod)
- [x] Tum AI formlari artik AIService.vb uzerinden calisiyor

### Onceki Calismalar
- [x] B2B Settings, POS error handling, R2 image upload
- [x] Backup FTP->API migration
- [x] SQL Views, Parametrik togglelar, Valor/Limit kontrol

## Bekleyen Gorevler
- [ ] P1: Maliyet hesaplama standardizasyonu (FIFO, LIFO, Agirlikli Ortalama)
- [ ] P2: E-Fatura/E-Arsiv otomatik eslestirme
- [ ] P2: AI kullanim loglari UI (frm_AIKullanimRaporu)
- [ ] P2: Dusuk riskli AI araclari (aciklama temizleme, ilan yardimcisi)

## Anahtar DB Semalari
- tbCekSenet, tbCekSenetBordro: Cek/Senet (risk hesaplamada kullaniliyor)
- tbFirmaHareketi: Bakiye, vade, odeme takip
- tbFirma: Kredi limiti, anlasma vadesi (nVadeGun)
- tbStokFisiMaster, tbStokFisiDetayi: Satis oneri motoru veri kaynagi
