-- ============================================================================
-- RESİM TRİGGER TEST SCRIPTİ
-- ============================================================================
-- Bu script trigger'ın düzgün çalışıp çalışmadığını test eder
-- ============================================================================

USE FURKAN2026
GO

PRINT '============================================'
PRINT 'Resim Trigger Test Başlıyor...'
PRINT '============================================'
GO

-- 1. Trigger var mı kontrol et
PRINT ''
PRINT '1. Trigger Kontrolü:'
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokResim_WebSync')
    PRINT '   ✓ trg_StokResim_WebSync trigger''ı MEVCUT'
ELSE
    PRINT '   ✗ trg_StokResim_WebSync trigger''ı YOK - Önce trigger''ı oluşturun!'
GO

-- 2. product_images tablosu var mı kontrol et
PRINT ''
PRINT '2. product_images Tablosu Kontrolü:'
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'product_images')
BEGIN
    PRINT '   ✓ product_images tablosu MEVCUT'
    SELECT 'Tablo yapısı:' AS Info
    SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'product_images'
END
ELSE
    PRINT '   ✗ product_images tablosu YOK - Önce tabloyu oluşturun!'
GO

-- 3. Mevcut kayıt sayısı
PRINT ''
PRINT '3. Mevcut Kayıt Durumu:'
SELECT 'product_images toplam kayıt:' AS Info, COUNT(*) AS Sayi FROM product_images
SELECT 'status=0 (bekleyen):' AS Info, COUNT(*) AS Sayi FROM product_images WHERE status = 0
SELECT 'status=1 (işlenmiş):' AS Info, COUNT(*) AS Sayi FROM product_images WHERE status = 1
GO

-- 4. tbStokResim tablosundan örnek kayıtlar
PRINT ''
PRINT '4. tbStokResim Örnek Kayıtlar:'
SELECT TOP 10 
    SR.nStokID, 
    SR.sModel, 
    SR.sRenk, 
    SR.nSira,
    LEFT(SR.yol, 50) AS yol_kisaltilmis,
    S.bWebGoruntule
FROM tbStokResim SR
LEFT JOIN tbStok S ON SR.nStokID = S.nStokID
WHERE S.bWebGoruntule = '1'
ORDER BY SR.nStokID DESC
GO

-- 5. ProductID uzunluk kontrolü (64 karaktere sığıyor mu?)
PRINT ''
PRINT '5. ProductID Uzunluk Kontrolü:'
SELECT 'Maksimum productID uzunluğu:' AS Info,
    MAX(LEN(sModel + '__' + sRenk)) AS MaxUzunluk
FROM tbStok
WHERE bWebGoruntule = '1' AND sModel IS NOT NULL AND sRenk IS NOT NULL

SELECT TOP 5 
    sModel + '__' + sRenk AS productID,
    LEN(sModel + '__' + sRenk) AS Uzunluk
FROM tbStok
WHERE bWebGoruntule = '1' AND sModel IS NOT NULL AND sRenk IS NOT NULL
ORDER BY LEN(sModel + '__' + sRenk) DESC
GO

-- 6. Manuel test: Bir ürün için product_images'a kayıt ekle ve kontrol et
PRINT ''
PRINT '6. Manuel Test İçin Örnek Ürün:'
SELECT TOP 1 
    S.sModel + '__' + S.sRenk AS productID,
    S.sModel,
    S.sRenk,
    (SELECT COUNT(*) FROM tbStokResim WHERE sModel = S.sModel) AS ResimSayisi
FROM tbStok S
WHERE S.bWebGoruntule = '1' 
AND S.sModel IS NOT NULL 
AND S.sRenk IS NOT NULL
AND EXISTS (SELECT 1 FROM tbStokResim WHERE sModel = S.sModel)
ORDER BY S.sModel
GO

PRINT ''
PRINT '============================================'
PRINT 'Test Tamamlandı!'
PRINT '============================================'
PRINT ''
PRINT 'Trigger''ı test etmek için:'
PRINT '1. tbStokResim tablosunda bir kayıt güncelleyin:'
PRINT '   UPDATE tbStokResim SET yol = yol WHERE nStokID = (bir nStokID)'
PRINT ''
PRINT '2. Sonra product_images tablosunu kontrol edin:'
PRINT '   SELECT * FROM product_images WHERE status = 0'
PRINT ''
PRINT 'Eğer yeni kayıt oluştuysa veya status=0 olduysa trigger çalışıyor demektir!'
GO
