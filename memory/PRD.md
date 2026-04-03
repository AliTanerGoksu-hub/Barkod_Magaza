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

### 2026-02-XX: Derleme Hatalari Duzeltmesi (Bu Oturum)
- [x] Mukerrer frm_AI_Ayarlar.vb silindi, Form1.vb -> frm_AIAyarlari() yonlendirildi
- [x] frm_firma_kart.vb: Orijinal dosya geri yuklendi, Inherits sirasi duzeltildi, encoding bozulmasi giderildi
- [x] frm_perakende.vb: Ayni sekilde orijinal dosya geri yuklendi ve risk kodu dogru pozisyona eklendi
- [x] Risk UI panelleri (frm_firma_kart.vb, frm_perakende.vb) lokal SQL ile calisiyor, dogru pozisyonda

### 2026-04-01: AI Altyapi Kurulumu
- [x] AI planlama dokumanlari (AI_IS_PLANI.md, KOORDINELI_GELISTIRME_PLANI.md, VERI_ALTYAPISI_PLANI.md, MOBIL_B2B_AGENT_GOREV_DOKUMANI.md)
- [x] SQL: tbRiskSkoru, tbAuditLog, tbSistemAyar parametrik ayarlar, aEmirForms yetki, AI view'lari
- [x] C# API: AIService.cs, RiskService.cs, AuditService.cs + tum endpoint'ler
- [x] VB.NET: master_kaydet_yeni - parametrik valor tarihi + kredi limit kontrolu
- [x] frm_fatura_liste.vb: GIB tutar parse fix (InvariantCulture) + Eslestirme: Isim -> Adres -> Tutar
- [x] frm_firma_kart.vb: Risk gostergesi (yesil/sari/kirmizi panel)
- [x] frm_perakende.vb: Perakende risk gostergesi
- [x] frm_AIAyarlari.vb: AI ayarlari yonetim ekrani

### Onceki Oturumlar:
- [x] B2B Settings tab, POS 400 Bad Request hata isleme
- [x] R2 Logo upload (Sinif + Firma), Otomatik yedek hata duzeltmeleri
- [x] FTP -> API migrasyon, E-Fatura/E-Arsiv API pagination, TurkceNormalize

## Devam Eden Isler (P0)
- [ ] GIB eslestirme: Tutar parse testi (kullanicidan yeni log bekleniyor)

## Siradaki Isler (P1)
- [ ] Satis Oneri Motoru - siparis ekraninda AI bazli urun onerisi
- [ ] Tahsilat AI Asistani - gecikmiş bakiyeler ve rota yakinligi
- [ ] Desktop UI: Siparis ekraninda AI uyarilari

## Gelecek Isler (P2)
- [ ] Maliyet hesaplama standardizasyonu (FIFO, LIFO, Agirlikli Ortalama vb.)
- [ ] AI kullanim takibi ve denetim log ekrani (tbAuditLog -> UI)
- [ ] Stok tahmin ve guvenlik stogu onerisi
- [ ] Urun aciklama temizleme / pazaryeri ilan yardimcisi
- [ ] Kolaysoft SOAP cagrlarini ayri service class'a tasi

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
