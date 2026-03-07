-- ============================================================================
-- tbStokSinifi tablosuna bKategoriAtla sütunu ekleme
-- ============================================================================
-- Bu sütun, Trendyol'da bulunamayan veya yanlış eşleşen ürünleri işaretler
-- bKategoriAtla = 1 olan ürünler tekrar aranmaz
-- ============================================================================

USE [FURKAN2026]
GO

-- Sütun zaten var mı kontrol et
IF NOT EXISTS (
    SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE TABLE_NAME = 'tbStokSinifi' AND COLUMN_NAME = 'bKategoriAtla'
)
BEGIN
    ALTER TABLE tbStokSinifi ADD bKategoriAtla BIT DEFAULT 0 NOT NULL
    PRINT 'bKategoriAtla sütunu eklendi.'
END
ELSE
BEGIN
    PRINT 'bKategoriAtla sütunu zaten mevcut.'
END
GO
