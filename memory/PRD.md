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

### AI Altyapi (Backend - C# API)
- [x] LLMService.cs - OpenAI entegrasyonu (risk analizi, tahsilat plani, satis oneri, gun sonu ozet)
- [x] AuditService.cs - AI kullanim loglama
- [x] KuralMotoru.cs - Kural bazli risk degerlendirme (AI olmadan da calisir)
- [x] POST /api/ai/risk-analiz - VB.NET'ten gelen verilerle risk analizi
- [x] POST /api/ai/risk-aciklama - DB'den veri cekip firma bazli risk aciklama
- [x] GET /api/ai/tahsilat-plani - Vadesi gecmis musteri listesi + AI tahsilat onerisi
- [x] POST /api/ai/satis-oneri - Firma bazli urun oneri motoru
- [x] GET /api/ai/gun-sonu-ozet - Gunluk satis/tahsilat ozeti + AI analiz
- [x] POST /api/siparis/onay-kontrol - Siparis oncesi risk kontrolu
- [x] GET /api/cari/risk-skoru/{firmaId} - Cari risk skoru
- [x] GET /api/cari/{firmaId}/detay - Cari firma detay bilgisi
- [x] POST /api/visit-note/add - Ziyaret notu kaydi
- [x] GET /api/sistem/ayar/{ayarKodu} - Sistem ayar sorgulama
- [x] GET /api/yetki/kontrol - Kullanici yetki kontrolu
- [x] GET /api/perakende/risk-skoru/{musteriId} - Perakende musteri risk skoru

### AI UI (VB.NET Desktop)
- [x] frm_firma_kart.vb - Risk paneli (renkli bar + skor + detay)
- [x] frm_firma_kart.vb - "AI Detay" butonu (/api/ai/risk-aciklama cagirip sonucu gosterir)
- [x] frm_firma_kart.vb - "Satis Oneri" butonu (frm_AISatisOneri formunu acar)
- [x] frm_perakende.vb - Perakende risk paneli (renkli bar + skor)
- [x] frm_perakende.vb - "AI" detay butonu
- [x] frm_AITahsilatAsistani.vb - Tahsilat AI asistani formu (grid + AI ozet)
- [x] frm_AIGunSonuOzet.vb - Gun sonu ozet formu (kartlar + AI)
- [x] frm_AISatisOneri.vb - Satis oneri motoru formu (grid + AI oneri)
- [x] Form1.vb - AI menusune 3 yeni buton eklendi

### Daha Once Tamamlanan
- [x] B2B Settings tab (frm_personel.vb)
- [x] POS 400 error handling (frm_perakende_odeme.vb)
- [x] R2 Image upload (frm_tbSinif.vb, Form1.vb)
- [x] Backup FTP -> API migration (ApiClient.vb)
- [x] AI Ayarlari formu (frm_AIAyarlari.vb)
- [x] AI Urun Isle formu (frm_AIUrunIsle.vb)
- [x] AI Kullanim Raporu formu (frm_AIKullanimRaporu.vb)
- [x] SQL Views (vw_AI_CariRiskVerisi, vw_AI_SatisGecmisi, vw_AI_PerakendeRiskVerisi)
- [x] Parametrik togglelar (tbSistemAyar: RISK_SKORU_AKTIF, PERAKENDE_RISK_AKTIF vs.)
- [x] Valor tarihi zorunluluk kontrolu (master_kaydet_yeni)
- [x] Kredi limiti kontrolu (SIPARIS_LIMIT_KONTROL)

## Bekleyen Gorevler

### P1 - Yakin Gelecek
- [ ] frm_stok_cari_alis.vb'de siparis oncesi API bazli risk uyarisi (siparis/onay-kontrol)
- [ ] B2B panel icin bakiye/odeme plani ekrani
- [ ] Mobil API'ler (ayni endpoint'ler mobile uyumlu)
- [ ] Yonetici ozet paneli + dogal dilde haftalik rapor

### P2 - Gelecek
- [ ] Maliyet hesaplama standardizasyonu (FIFO, LIFO, Agirlikli Ortalama vs.)
- [ ] E-Fatura/E-Arsiv otomatik eslestirme
- [ ] Dusuk riskli AI araclari (aciklama temizleme, ilan yardimcisi)
- [ ] Performans olcumleri ve maliyet takibi
- [ ] AI kullanim loglari UI

## Teknik Notlar
- VB.NET dosyalari CP1254 encoding kullanir
- Form1.vb 24000+ satir - dikkatli edit gerekir
- API Base URL: https://desktop.barkodyazilimevi.com
- API Key: BSmart2024Desktop!@#SecureKey
- AI ayarlari appsettings.json'da: AI:ApiKey, AI:ApiUrl, AI:Model
