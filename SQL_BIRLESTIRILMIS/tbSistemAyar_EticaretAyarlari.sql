-- =====================================================
-- tbSistemAyar - E-Ticaret Senkronizasyon Ayarları
-- Tarih: 2026-01-03
-- Açıklama: frm_qukaGonder formunda kullanılan tüm ayarlar
-- =====================================================

-- Senkronizasyon Kriterleri
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_TUM_STOKLAR') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_TUM_STOKLAR', '0', 'Tüm Stokları Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_FIYAT_DEGISEN') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_FIYAT_DEGISEN', '1', 'Fiyatı Değişenleri Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_MIKTAR_DEGISEN') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_MIKTAR_DEGISEN', '1', 'Miktarı Değişenleri Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_RESIM_GONDER') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_RESIM_GONDER', '1', 'Resim Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_VARYANT_GUNCELLE') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_VARYANT_GUNCELLE', '0', 'Varyant Güncelle')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_KATEGORI_GUNCELLE') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_KATEGORI_GUNCELLE', '1', 'Kategori Güncelle')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_SIPARIS_AL') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_SIPARIS_AL', '1', 'Siparişleri Al')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_TUM_SIPARISLER') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_TUM_SIPARISLER', '0', 'Tüm Siparişleri Çek (Manuel)')

-- Gönderim Ayarları
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_TUMUNU') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_TUMUNU', '1', 'Tümünü Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_MARKA') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_MARKA', '1', 'Marka Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_KATEGORI') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_KATEGORI', '1', 'Kategoriler Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_UZUN_ACIKLAMA') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_UZUN_ACIKLAMA', '1', 'Uzun Açıklama Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_KISA_ACIKLAMA') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_KISA_ACIKLAMA', '1', 'Kısa Açıklama Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_SEO') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_SEO', '1', 'SEO Bilgileri Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_DESI') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_DESI', '1', 'Desi/Ağırlık Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_PAZARYERI_FIYAT') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_PAZARYERI_FIYAT', '0', 'Pazaryeri Fiyatlarını Gönder')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'GONDERIM_FIYAT_TIPI') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('GONDERIM_FIYAT_TIPI', 'WEBP', 'Fiyat Tipi')

-- Kargo Ayarları
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'KARGO_EKLE_AKTIF') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('KARGO_EKLE_AKTIF', '1', 'Kargo Bedeli Ekle Aktif')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'KARGO_MIN_TUTAR') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('KARGO_MIN_TUTAR', '3000', 'Kargo Minimum Tutar (TL)')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'KARGO_STOK_KODU') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('KARGO_STOK_KODU', 'KARGOBEDELI', 'Kargo Stok Barkodu')

-- Trigger Ayarları
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'TRIGGER_AKTIF') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('TRIGGER_AKTIF', '0', 'Trigger Sistemi Aktif')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'TRIGGER_STOK') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('TRIGGER_STOK', '1', 'Trigger - Stok Değişikliği')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'TRIGGER_FIYAT') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('TRIGGER_FIYAT', '1', 'Trigger - Fiyat Değişikliği')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'TRIGGER_RESIM') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('TRIGGER_RESIM', '1', 'Trigger - Resim Değişikliği')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'TRIGGER_KATEGORI') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('TRIGGER_KATEGORI', '1', 'Trigger - Kategori Değişikliği')

-- Timer Süreleri (Dakika)
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_STOK_DAKIKA') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_STOK_DAKIKA', '10', 'Stok Kontrol Süresi (Dakika)')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_SIPARIS_DAKIKA') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_SIPARIS_DAKIKA', '3', 'Sipariş Kontrol Süresi (Dakika)')
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SENKRON_TRIGGER_DAKIKA') 
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('SENKRON_TRIGGER_DAKIKA', '5', 'Trigger Kontrol Süresi (Dakika)')

-- =====================================================
-- Kontrol Sorgusu: Tüm E-Ticaret ayarlarını listele
-- =====================================================
-- SELECT * FROM tbSistemAyar 
-- WHERE sAyarKodu LIKE 'SENKRON_%' 
--    OR sAyarKodu LIKE 'GONDERIM_%' 
--    OR sAyarKodu LIKE 'KARGO_%' 
--    OR sAyarKodu LIKE 'TRIGGER_%'
-- ORDER BY sAyarKodu
