-- ============================================================================
-- YENİ AI KOLONLARINI EKLE
-- ============================================================================
-- Tarih: 2025
-- Açıklama: Kategori Öneri ve Fiyat Optimizasyonu kolonlarını ekler

USE [YourDatabaseName]
GO

-- Kategori Öneri kolonu ekle (eğer yoksa)
IF NOT EXISTS (SELECT * FROM sys.columns 
               WHERE object_id = OBJECT_ID(N'[dbo].[tbStokAIIcerik]') 
               AND name = 'sKategoriOner')
BEGIN
    ALTER TABLE [dbo].[tbStokAIIcerik]
    ADD [sKategoriOner] NVARCHAR(MAX) NULL
    
    PRINT '✅ sKategoriOner kolonu eklendi'
END
ELSE
BEGIN
    PRINT '⚠️ sKategoriOner kolonu zaten mevcut'
END
GO

-- Fiyat Optimizasyonu kolonu ekle (eğer yoksa)
IF NOT EXISTS (SELECT * FROM sys.columns 
               WHERE object_id = OBJECT_ID(N'[dbo].[tbStokAIIcerik]') 
               AND name = 'sFiyatOptimize')
BEGIN
    ALTER TABLE [dbo].[tbStokAIIcerik]
    ADD [sFiyatOptimize] NVARCHAR(MAX) NULL
    
    PRINT '✅ sFiyatOptimize kolonu eklendi'
END
ELSE
BEGIN
    PRINT '⚠️ sFiyatOptimize kolonu zaten mevcut'
END
GO

-- Tablo yapısını kontrol et
SELECT 
    COLUMN_NAME,
    DATA_TYPE,
    CHARACTER_MAXIMUM_LENGTH,
    IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'tbStokAIIcerik'
ORDER BY ORDINAL_POSITION
GO

PRINT '============================================'
PRINT '✅ YENİ AI KOLONLARI BAŞARIYLA EKLENDİ!'
PRINT '============================================'
PRINT ''
PRINT 'Eklenen Kolonlar:'
PRINT '  1. sKategoriOner (NVARCHAR(MAX)) - AI kategori önerileri'
PRINT '  2. sFiyatOptimize (NVARCHAR(MAX)) - AI fiyat analizi'
PRINT ''
PRINT 'Bu kolonlar aşağıdaki sekmeler için kullanılacak:'
PRINT '  🏷️ Kategori Öneri sekmesi'
PRINT '  💰 Fiyat Optimizasyonu sekmesi'
PRINT ''
