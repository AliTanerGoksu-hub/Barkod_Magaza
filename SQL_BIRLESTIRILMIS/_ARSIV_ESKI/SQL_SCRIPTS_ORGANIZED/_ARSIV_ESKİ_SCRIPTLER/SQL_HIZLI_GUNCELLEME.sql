-- =============================================
-- HIZLI GÜNCELLEME - DefaultImageUrl
-- =============================================
-- Bu komutu çalıştırarak kendi resim URL'nizi ekleyin
-- =============================================

USE [Database]; -- Veritabanı adınızı buraya yazın
GO

-- KENDİ RESIM URL'NİZİ BURAYA YAZIN:
DECLARE @YeniResimURL NVARCHAR(255) = 'https://sizin-site.com/varsayilan-resim.jpg'

-- Güncelleme
UPDATE tbParamGenel 
SET DefaultImageUrl = @YeniResimURL;

-- Kontrol
SELECT 
    'tbParamGenel' AS 'Tablo',
    DefaultImageUrl AS 'Varsayılan Resim URL',
    CASE 
        WHEN DefaultImageUrl IS NULL OR DefaultImageUrl = '' 
        THEN '❌ BOŞ - Lütfen güncelleyin!'
        ELSE '✅ TANIMI'
    END AS 'Durum'
FROM tbParamGenel;

PRINT ''
PRINT '✅ DefaultImageUrl güncellendi!'
PRINT 'Şimdi uygulamayı yeniden başlatın.'
GO
