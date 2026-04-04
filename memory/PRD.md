# BARKOD YAZILIM - PRD (Product Requirements Document)

## Proje Ozeti
Legacy VB.NET Windows Forms ERP/POS uygulamasi (Barkod_Magaza) + C# .NET 8 Web API (BusinessSmartDesktopAPI).
Amaç: Mevcut sisteme AI tabanli is zekasi altyapisi eklemek.

## Mimari
- **Frontend**: VB.NET Windows Forms (DevExpress, CP1254 encoding)
- **Backend API**: C# .NET 8 Minimal APIs (BusinessSmartDesktopAPI)
- **Veritabani**: SQL Server (OleDb)
- **AI**: OpenAI GPT-4o-mini (LLMService.cs) + Kural bazli motor (KuralMotoru.cs)

## Tamamlanan Ozellikler

### AI Backend (C# API Endpoints)
- [x] POST /api/ai/risk-analiz - Risk analizi (LLM + Kural)
- [x] POST /api/ai/risk-aciklama - DB bazli firma risk aciklama
- [x] GET /api/ai/tahsilat-plani - Vadesi gecmis listesi + AI tahsilat onerisi
- [x] POST /api/ai/satis-oneri - Firma bazli urun oneri motoru
- [x] GET /api/ai/gun-sonu-ozet - Gunluk satis/tahsilat ozeti + AI analiz
- [x] POST /api/siparis/onay-kontrol - Siparis oncesi risk kontrolu
- [x] GET /api/cari/risk-skoru/{firmaId} - Cari risk skoru
- [x] GET /api/cari/{firmaId}/detay - Firma detay
- [x] POST /api/visit-note/add - Ziyaret notu kaydi
- [x] GET /api/sistem/ayar/{ayarKodu} - Sistem ayar sorgulama
- [x] GET /api/yetki/kontrol - Kullanici yetki kontrolu
- [x] GET /api/perakende/risk-skoru/{musteriId} - Perakende musteri risk

### AI Servis Katmani
- [x] LLMService.cs - OpenAI entegrasyonu (5 farkli analiz metodu)
- [x] AuditService.cs - AI kullanim loglama (tbAIAuditLog)
- [x] KuralMotoru.cs - Kural bazli risk degerlendirme
- [x] AIService.cs + RiskService.cs - Yardimci servisler

### AI UI (VB.NET Desktop Formlar)
- [x] frm_firma_kart.vb - Risk paneli + AI Detay + Satis Oneri butonlari
- [x] frm_perakende.vb - Perakende risk paneli + AI Detay butonu
- [x] frm_stok_cari_alis.vb - Siparis risk kontrolu (otomatik, parametrik)
- [x] frm_AITahsilatAsistani.vb - Tahsilat AI asistani (grid + AI analiz)
- [x] frm_AIGunSonuOzet.vb - Gun sonu ozet (4 KPI + AI ozet)
- [x] frm_AISatisOneri.vb - Satis oneri motoru (grid + AI oneri)
- [x] frm_YoneticiOzetPaneli.vb - Yonetici ozet paneli (KPI + Risk dagitim + Top 10 + AI ozet)
- [x] frm_AIAyarlari.vb - AI Ayarlari (parametreler)
- [x] frm_AIUrunIsle.vb - AI urun islem
- [x] frm_AIKullanimRaporu.vb - AI kullanim raporu
- [x] Form1.vb - AI menusu (7 buton: Ayarlar, Urun Isle, Toplu Islem, Rapor, Tahsilat, Gun Sonu, Satis Oneri, Yonetici Ozet)

### Daha Once Tamamlanan (Onceki Sessionlar)
- [x] B2B Settings tab (frm_personel.vb)
- [x] POS 400 error handling (frm_perakende_odeme.vb)
- [x] R2 Image upload (frm_tbSinif.vb, Form1.vb)
- [x] Backup FTP -> API migration (ApiClient.vb)
- [x] SQL Views (vw_AI_CariRiskVerisi, vw_AI_SatisGecmisi, vw_AI_PerakendeRiskVerisi)
- [x] Parametrik togglelar (tbSistemAyar)
- [x] Valor tarihi + Kredi limiti zorunluluk

## Bekleyen Gorevler

### P1
- [ ] B2B panel icin bakiye/odeme plani ekrani
- [ ] Mobil API uyumluluk (ayni endpoint'ler mobile uyumlu)

### P2
- [ ] Maliyet hesaplama standardizasyonu (FIFO, LIFO, Agirlikli Ortalama vs.)
- [ ] E-Fatura/E-Arsiv otomatik eslestirme
- [ ] Dusuk riskli AI araclari (aciklama temizleme, ilan yardimcisi)
- [ ] Performans olcumleri ve maliyet takibi
- [ ] AI kullanim loglari UI (mevcut AuditService loglarini gosteren form)

## Teknik Notlar
- VB.NET dosyalari CP1254 encoding kullanir - search_replace yerine python script ile edit
- Form1.vb 24000+ satir, frm_stok_cari_alis.vb 5100+ satir
- API Base URL: https://desktop.barkodyazilimevi.com
- API Key: BSmart2024Desktop!@#SecureKey
- AI ayarlari: appsettings.json -> AI:ApiKey, AI:ApiUrl, AI:Model
- AI olmadan da kural bazli motor calisir (KuralMotoru.cs)
