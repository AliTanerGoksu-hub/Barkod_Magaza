-- =============================================
-- TRENDYOL TABLO GÜNCELLEME
-- Dosya: 10_TABLO_GUNCELLE.sql
-- Açıklama: Product ID artık string (GUID) formatında
-- =============================================

USE [YONCALINES]
GO

-- nTrendyolProductId sütununu VARCHAR'a çevir (Trendyol artık GUID kullanıyor)
IF EXISTS (SELECT * FROM sys.columns WHERE name = 'nTrendyolProductId' AND object_id = OBJECT_ID('tbTrendyolUrunEsleme'))
BEGIN
    -- Önce sütunu kaldır ve yeniden oluştur
    ALTER TABLE tbTrendyolUrunEsleme DROP COLUMN nTrendyolProductId
    ALTER TABLE tbTrendyolUrunEsleme ADD sTrendyolProductId VARCHAR(100)
    PRINT '✓ nTrendyolProductId → sTrendyolProductId (VARCHAR) olarak güncellendi'
END
GO

-- nTrendyolCategoryId sütununu VARCHAR'a çevir
IF EXISTS (SELECT * FROM sys.columns WHERE name = 'nTrendyolCategoryId' AND object_id = OBJECT_ID('tbTrendyolUrunEsleme'))
BEGIN
    ALTER TABLE tbTrendyolUrunEsleme DROP COLUMN nTrendyolCategoryId
    ALTER TABLE tbTrendyolUrunEsleme ADD sTrendyolCategoryId VARCHAR(50)
    PRINT '✓ nTrendyolCategoryId → sTrendyolCategoryId (VARCHAR) olarak güncellendi'
END
GO

-- Eğer sütunlar yoksa ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE name = 'sTrendyolProductId' AND object_id = OBJECT_ID('tbTrendyolUrunEsleme'))
BEGIN
    ALTER TABLE tbTrendyolUrunEsleme ADD sTrendyolProductId VARCHAR(100)
    PRINT '✓ sTrendyolProductId sütunu eklendi'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE name = 'sTrendyolCategoryId' AND object_id = OBJECT_ID('tbTrendyolUrunEsleme'))
BEGIN
    ALTER TABLE tbTrendyolUrunEsleme ADD sTrendyolCategoryId VARCHAR(50)
    PRINT '✓ sTrendyolCategoryId sütunu eklendi'
END
GO

PRINT ''
PRINT '=== TABLO GÜNCELLEME TAMAMLANDI ==='
GO
