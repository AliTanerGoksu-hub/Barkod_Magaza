-- =============================================
-- SISTEM AYAR TABLOSU DUZELTME
-- Mevcut tbSistemAyar tablosunu kontrol eder ve gerekli kolonlari ekler
-- =============================================

-- Oncelikle mevcut tablo yapisini kontrol edelim
-- Eger tablo yoksa olustur
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSistemAyar')
BEGIN
    CREATE TABLE tbSistemAyar (
        nAyarID INT IDENTITY(1,1) PRIMARY KEY,
        sAyarKodu NVARCHAR(50) NOT NULL,
        sAyarDeger NVARCHAR(500),
        sAciklama NVARCHAR(200),
        bAktif BIT DEFAULT 1
    )
    PRINT 'tbSistemAyar tablosu olusturuldu.'
END
ELSE
BEGIN
    -- Tablo var, kolonlari kontrol et
    PRINT 'tbSistemAyar tablosu mevcut, kolonlar kontrol ediliyor...'
    
    -- sAyarKodu kolonu var mi?
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSistemAyar') AND name = 'sAyarKodu')
    BEGIN
        ALTER TABLE tbSistemAyar ADD sAyarKodu NVARCHAR(50)
        PRINT 'sAyarKodu kolonu eklendi.'
    END
    
    -- sAyarDeger kolonu var mi?
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSistemAyar') AND name = 'sAyarDeger')
    BEGIN
        ALTER TABLE tbSistemAyar ADD sAyarDeger NVARCHAR(500)
        PRINT 'sAyarDeger kolonu eklendi.'
    END
    
    -- sAciklama kolonu var mi?
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSistemAyar') AND name = 'sAciklama')
    BEGIN
        ALTER TABLE tbSistemAyar ADD sAciklama NVARCHAR(200)
        PRINT 'sAciklama kolonu eklendi.'
    END
    
    -- bAktif kolonu var mi?
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSistemAyar') AND name = 'bAktif')
    BEGIN
        ALTER TABLE tbSistemAyar ADD bAktif BIT DEFAULT 1
        PRINT 'bAktif kolonu eklendi.'
    END
END
GO

-- Varsayilan ayarlari ekle (eger yoksa)
IF NOT EXISTS (SELECT * FROM tbSistemAyar WHERE sAyarKodu = 'EMAIL_SMTP_HOST')
BEGIN
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama, bAktif) VALUES
    ('EMAIL_SMTP_HOST', '', 'SMTP Sunucu Adresi', 1),
    ('EMAIL_SMTP_PORT', '587', 'SMTP Port', 1),
    ('EMAIL_SMTP_USER', '', 'SMTP Kullanici Adi', 1),
    ('EMAIL_SMTP_PASS', '', 'SMTP Sifre (sifreli)', 1),
    ('EMAIL_FROM', '', 'Gonderici Email Adresi', 1),
    ('EMAIL_AKTIF', '0', 'Email Bildirimi Aktif mi', 1),
    ('SMS_API_URL', '', 'SMS API URL', 1),
    ('SMS_API_KEY', '', 'SMS API Key', 1),
    ('SMS_SENDER', '', 'SMS Gonderici', 1),
    ('SMS_AKTIF', '0', 'SMS Bildirimi Aktif mi', 1),
    ('WHATSAPP_PHONE_ID', '', 'WhatsApp Phone Number ID', 1),
    ('WHATSAPP_ACCESS_TOKEN', '', 'WhatsApp Access Token (sifreli)', 1),
    ('WHATSAPP_BUSINESS_ID', '', 'WhatsApp Business ID', 1),
    ('WHATSAPP_API_VERSION', 'v17.0', 'WhatsApp API Version', 1),
    ('WHATSAPP_AKTIF', '0', 'WhatsApp Bildirimi Aktif mi', 1)
    PRINT 'Varsayilan sistem ayarlari eklendi.'
END
ELSE
BEGIN
    PRINT 'Sistem ayarlari zaten mevcut.'
END
GO

-- Mevcut tablo yapisini goster
SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'tbSistemAyar'
ORDER BY ORDINAL_POSITION

PRINT '=============================================';
PRINT 'SISTEM AYAR TABLOSU DUZELTMESI TAMAMLANDI';
PRINT '=============================================';
