# PRD - Business Smart Barkod Magaza

## Original Problem Statement
VB.NET Windows Forms tabanlı e-ticaret ve perakende yönetim uygulaması. Ana özellikler:
- Quka API üzerinden sipariş senkronizasyonu
- Pazaryeri entegrasyonları (Trendyol, Hepsiburada)
- GİB e-Fatura/e-Arşiv entegrasyonu (Kolaysoft)
- Stok ve fiyat yönetimi
- POS satış işlemleri

## Implemented Features (2025-03)

### Bug Fixes (Completed)
1. **POS Ödeme Donma Hatası** - `frm_perakende_odeme.vb`
   - Ödeme isteği bekleme sırasını düzeltildi

2. **Gece Yarısı lic.dat Dosya Kilidi Çökmesi** - `Form1.vb`
   - Try...Finally bloğu ile dosya kapatma garantilendi

3. **Toplu Resim Yükleme Duplikasyon Hatası** - `frm_TopluResimYukleme.vb`, `frm_stok_kart.vb`
   - Model+Renk bazlı kontrol (Size bazlı yerine)

4. **Excel Import Hataları** - `frm_fatura.vb`
   - Varyant veri kalıcılığı ve COM exception düzeltmeleri

5. **✅ Quka API Müşteri Bilgisi Kaydedilmiyor (2025-03-10)** - `frm_qukaGonder.vb`
   - **Kök Neden:** GetIlName fonksiyonu sadece plaka kodu ile arama yapıyordu
   - **Çözüm:** 
     - GetIlName: Plaka + İl adı + Türkçe karakter toleranslı arama
     - GetVarsayilanIl: Veritabanından gerçek varsayılan il değeri
     - NormalizeTurkishChars: Türkçe karakter dönüşümü
   - **Dosya:** frm_qukaGonder.vb (satır 81-172, 3270-3300, 9925-9945)

### New Features (In Progress)
1. **Pazaryeri Fatura Entegrasyonu** - P1
   - Form: `frm_PazaryeriFaturaGonderim.vb` (oluşturuldu)
   - DB Tablosu: `tbPazaryeriFaturaGonderim` (auto-create)
   - GİB onaylı faturaları listeleme (tamamlandı)
   - **Eksik:** `GonderTrendyol` ve `GonderHepsiburada` API fonksiyonları

## Key Database Schema
- `tbStokFisiMaster`: Fatura header (nFisNo, GibFaturaNo, nFirmaID)
- `tbStokFisiAciklamasi`: Sipariş kodu (sAciklama3)
- `tbPazaryeriAyar`: API credentials (sSaticiID, sApiKey, sApiSecret)
- `tbPazaryeriFaturaGonderim`: Fatura gönderim log
- `tbFirma`: Müşteri bilgileri (sIl FK -> tbIl.sIl)
- `tbIl`: İl tablosu (sPlaka, sIl)

## Architecture
- VB.NET Windows Forms
- SQL Server (FURKAN2026)
- OleDb bağlantı
- DevExpress UI
- External APIs: Quka, Kolaysoft, Trendyol, Hepsiburada

## Files of Reference
- `/app/Barkod_Magaza_Git/frm_qukaGonder.vb` - Sipariş senkronizasyonu
- `/app/Barkod_Magaza_Git/frm_PazaryeriFaturaGonderim.vb` - Pazaryeri fatura gönderim
- `/app/Barkod_Magaza_Git/frm_fatura_liste.vb` - Fatura listesi
- `/app/Barkod_Magaza_Git/Form1.vb` - Ana form

## Known Issues
- None currently open

## Backlog (P1)
1. Pazaryeri Fatura Gönderim API entegrasyonu tamamlanması
   - GonderTrendyol fonksiyonu
   - GonderHepsiburada fonksiyonu
