-- ============================================================================
-- WEB SENKRONİZASYON TRİGGER'LARI
-- ============================================================================
-- Tarih: 2025-01-28
-- Açıklama: E-ticaret senkronizasyonu için products ve product_images 
--           tablolarını otomatik güncelleyen trigger'lar
-- ============================================================================
-- 
-- KULLANIM:
-- 1. Bu script'i SQL Server Management Studio'da açın
-- 2. Doğru veritabanını seçin (USE FURKAN2026)
-- 3. Tüm script'i çalıştırın (F5)
--
-- NOT: Mevcut trigger'lar silinmez, sadece yeni trigger'lar eklenir
-- ============================================================================

USE FURKAN2026
GO

PRINT '============================================'
PRINT 'Web Senkronizasyon Trigger Kurulumu Başlıyor'
PRINT '============================================'
GO

-- ============================================================================
-- 1. STOK HAREKETİ TRİGGER (tbStokFisiDetayi)
-- ============================================================================
-- Stok giriş/çıkış yapıldığında products.status = 0 yapar
-- Böylece trigger sistemi bu ürünü "stok değişti" olarak algılar
-- ============================================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFisiDetayi_WebSync')
BEGIN
    DROP TRIGGER trg_StokFisiDetayi_WebSync
    PRINT '> Eski trg_StokFisiDetayi_WebSync silindi'
END
GO

CREATE TRIGGER trg_StokFisiDetayi_WebSync
ON dbo.tbStokFisiDetayi
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Güncellenen kayıtlar için
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN dbo.tbStok s ON p.productID = (s.sModel + '__' + s.sRenk) COLLATE Turkish_CI_AS
    WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM inserted)
    AND s.bWebGoruntule = '1';
    
    -- Silinen kayıtlar için
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN dbo.tbStok s ON p.productID = (s.sModel + '__' + s.sRenk) COLLATE Turkish_CI_AS
    WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM deleted)
    AND s.bWebGoruntule = '1';
END
GO

PRINT '✓ trg_StokFisiDetayi_WebSync oluşturuldu (Stok değişikliği -> products.status=0)'
GO

-- ============================================================================
-- 2. FİYAT TRİGGER (tbStokFiyati)
-- ============================================================================
-- Fiyat değiştiğinde products.f_durum = 0 yapar
-- Böylece trigger sistemi bu ürünü "fiyat değişti" olarak algılar
-- ============================================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFiyati_WebSync')
BEGIN
    DROP TRIGGER trg_StokFiyati_WebSync
    PRINT '> Eski trg_StokFiyati_WebSync silindi'
END
GO

CREATE TRIGGER trg_StokFiyati_WebSync
ON dbo.tbStokFiyati
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Güncellenen kayıtlar için
    UPDATE p 
    SET p.f_durum = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN dbo.tbStok s ON p.productID = (s.sModel + '__' + s.sRenk) COLLATE Turkish_CI_AS
    WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM inserted)
    AND s.bWebGoruntule = '1';
    
    -- Silinen kayıtlar için
    UPDATE p 
    SET p.f_durum = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN dbo.tbStok s ON p.productID = (s.sModel + '__' + s.sRenk) COLLATE Turkish_CI_AS
    WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM deleted)
    AND s.bWebGoruntule = '1';
END
GO

PRINT '✓ trg_StokFiyati_WebSync oluşturuldu (Fiyat değişikliği -> products.f_durum=0)'
GO

-- ============================================================================
-- 3. RESİM TRİGGER (tbStokResim)
-- ============================================================================
-- Resim eklendiğinde/değiştiğinde product_images.status = 0 yapar
-- Böylece trigger sistemi bu ürünü "resim değişti" olarak algılar
-- NOT: product_images tablosunda kayıt yoksa önce ekler (MERGE/UPSERT mantığı)
-- ============================================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokResim_WebSync')
BEGIN
    DROP TRIGGER trg_StokResim_WebSync
    PRINT '> Eski trg_StokResim_WebSync silindi'
END
GO

CREATE TRIGGER trg_StokResim_WebSync
ON dbo.tbStokResim
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Güncellenen kayıtlar için
    -- Önce product_images tablosuna kayıt ekle (yoksa), sonra status=0 yap
    MERGE dbo.product_images AS target
    USING (
        SELECT DISTINCT (s.sModel + '__' + s.sRenk) AS productID
        FROM dbo.tbStok s
        WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM inserted WHERE nStokID IS NOT NULL)
        AND s.bWebGoruntule = '1'
        AND s.sModel IS NOT NULL AND s.sRenk IS NOT NULL
    ) AS source (productID)
    ON target.productID = source.productID COLLATE Turkish_CI_AS
    WHEN MATCHED THEN
        UPDATE SET status = 0, updated_at = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT (productID, img_count, status, updated_at)
        VALUES (source.productID, 1, 0, GETDATE());
    
    -- Silinen kayıtlar için de aynı mantık
    MERGE dbo.product_images AS target
    USING (
        SELECT DISTINCT (s.sModel + '__' + s.sRenk) AS productID
        FROM dbo.tbStok s
        WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM deleted WHERE nStokID IS NOT NULL)
        AND s.bWebGoruntule = '1'
        AND s.sModel IS NOT NULL AND s.sRenk IS NOT NULL
    ) AS source (productID)
    ON target.productID = source.productID COLLATE Turkish_CI_AS
    WHEN MATCHED THEN
        UPDATE SET status = 0, updated_at = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT (productID, img_count, status, updated_at)
        VALUES (source.productID, 1, 0, GETDATE());
END
GO

PRINT '✓ trg_StokResim_WebSync oluşturuldu (Resim değişikliği -> product_images.status=0, MERGE ile otomatik kayıt)'
GO

-- ============================================================================
-- 4. AI İÇERİK TRİGGER (tbStokUzunNot)
-- ============================================================================
-- AI içerik oluşturulduğunda products.status = 0 yapar
-- Böylece AI içerikleri de otomatik senkronize edilir
-- ============================================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokUzunNot_WebSync')
BEGIN
    DROP TRIGGER trg_StokUzunNot_WebSync
    PRINT '> Eski trg_StokUzunNot_WebSync silindi'
END
GO

CREATE TRIGGER trg_StokUzunNot_WebSync
ON dbo.tbStokUzunNot
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- sModel bazlı güncelleme (tbStokUzunNot'ta sModel var)
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    WHERE p.productID LIKE (SELECT TOP 1 sModel FROM inserted) + '__%'
    OR p.productID = (SELECT TOP 1 sModel FROM inserted);
END
GO

PRINT '✓ trg_StokUzunNot_WebSync oluşturuldu (AI Uzun Açıklama -> products.status=0)'
GO

-- ============================================================================
-- 5. AI SEO İÇERİK TRİGGER (tbStokAIIcerik)
-- ============================================================================
-- AI SEO içerik oluşturulduğunda products.status = 0 yapar
-- ============================================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokAIIcerik_WebSync')
BEGIN
    DROP TRIGGER trg_StokAIIcerik_WebSync
    PRINT '> Eski trg_StokAIIcerik_WebSync silindi'
END
GO

CREATE TRIGGER trg_StokAIIcerik_WebSync
ON dbo.tbStokAIIcerik
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- sModel bazlı güncelleme
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    WHERE p.productID LIKE (SELECT TOP 1 sModel FROM inserted) + '__%'
    OR p.productID = (SELECT TOP 1 sModel FROM inserted);
END
GO

PRINT '✓ trg_StokAIIcerik_WebSync oluşturuldu (AI SEO İçerik -> products.status=0)'
GO

-- ============================================================================
-- 6. SINIF/KATEGORİ TRİGGER (tbStokSinifi)
-- ============================================================================
-- Kategori/Sınıf değiştiğinde products.status = 0 yapar
-- Böylece trigger sistemi bu ürünü "kategori değişti" olarak algılar
-- ve web platformuna güncel kategori bilgisi gönderilir
-- ============================================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokSinifi_WebSync')
BEGIN
    DROP TRIGGER trg_StokSinifi_WebSync
    PRINT '> Eski trg_StokSinifi_WebSync silindi'
END
GO

CREATE TRIGGER trg_StokSinifi_WebSync
ON dbo.tbStokSinifi
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Güncellenen kayıtlar için
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN dbo.tbStok s ON p.productID = (s.sModel + '__' + s.sRenk) COLLATE Turkish_CI_AS
    WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM inserted)
    AND s.bWebGoruntule = '1';
    
    -- Silinen kayıtlar için
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN dbo.tbStok s ON p.productID = (s.sModel + '__' + s.sRenk) COLLATE Turkish_CI_AS
    WHERE s.nStokID IN (SELECT DISTINCT nStokID FROM deleted)
    AND s.bWebGoruntule = '1';
END
GO

PRINT '✓ trg_StokSinifi_WebSync oluşturuldu (Sınıf/Kategori değişikliği -> products.status=0)'
GO

-- ============================================================================
-- KURULUM TAMAMLANDI
-- ============================================================================

PRINT ''
PRINT '============================================'
PRINT 'Web Senkronizasyon Trigger Kurulumu Tamamlandı!'
PRINT '============================================'
PRINT ''
PRINT 'Oluşturulan Trigger''lar:'
PRINT '  1. trg_StokFisiDetayi_WebSync  -> Stok değişikliği algılama'
PRINT '  2. trg_StokFiyati_WebSync      -> Fiyat değişikliği algılama'
PRINT '  3. trg_StokResim_WebSync       -> Resim değişikliği algılama'
PRINT '  4. trg_StokUzunNot_WebSync     -> AI Uzun Açıklama algılama'
PRINT '  5. trg_StokAIIcerik_WebSync    -> AI SEO İçerik algılama'
PRINT '  6. trg_StokSinifi_WebSync      -> Sınıf/Kategori değişikliği algılama'
PRINT ''
PRINT 'Artık:'
PRINT '  - Stok değişince      -> products.status = 0'
PRINT '  - Fiyat değişince     -> products.f_durum = 0'
PRINT '  - Resim değişince     -> product_images.status = 0'
PRINT '  - AI içerik değişince -> products.status = 0'
PRINT '  - Kategori değişince  -> products.status = 0'
PRINT ''
PRINT 'Trigger sistemi bu değişiklikleri otomatik algılayacak!'
GO
