-- ============================================================================
-- RESİM TRİGGER DÜZELTMESİ
-- ============================================================================
-- Tarih: 2025-02-14
-- Açıklama: Resim değişikliklerini algılayan trigger - MERGE ile otomatik kayıt
-- 
-- SORUN: Mevcut trigger sadece UPDATE yapıyordu, product_images tablosunda
--        kayıt yoksa hiçbir şey olmuyordu
-- ÇÖZÜM: MERGE kullanarak kayıt yoksa INSERT, varsa UPDATE yapılıyor
-- ============================================================================
-- 
-- KULLANIM:
-- 1. Bu script'i SQL Server Management Studio'da açın
-- 2. Doğru veritabanını seçin (USE FURKAN2026 veya kendi veritabanınız)
-- 3. Tüm script'i çalıştırın (F5)
-- ============================================================================

USE FURKAN2026
GO

PRINT '============================================'
PRINT 'Resim Trigger Düzeltmesi Başlıyor...'
PRINT '============================================'
GO

-- Eski trigger'ı sil
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokResim_WebSync')
BEGIN
    DROP TRIGGER trg_StokResim_WebSync
    PRINT '> Eski trg_StokResim_WebSync silindi'
END
GO

-- Yeni trigger oluştur (MERGE ile)
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

PRINT ''
PRINT '============================================'
PRINT 'Resim Trigger Düzeltmesi Tamamlandı!'
PRINT '============================================'
PRINT ''
PRINT 'Artık tbStokResim tablosunda değişiklik olduğunda:'
PRINT '  - Yeni resim eklendiğinde'
PRINT '  - Resim URL güncellendiğinde'
PRINT '  - Resim silindiğinde'
PRINT ''
PRINT 'product_images tablosunda:'
PRINT '  - Kayıt yoksa OLUŞTURULACAK (INSERT)'
PRINT '  - Kayıt varsa status=0 YAPILACAK (UPDATE)'
PRINT ''
PRINT 'Bu sayede trigger sistemi resim değişikliklerini algılayacak!'
GO

-- Test için: Trigger'ın oluştuğunu kontrol et
SELECT 
    name AS TriggerName,
    OBJECT_NAME(parent_id) AS TableName,
    create_date AS CreatedDate,
    modify_date AS ModifiedDate
FROM sys.triggers 
WHERE name = 'trg_StokResim_WebSync'
GO

-- Mevcut product_images tablosundaki kayıt sayısı
SELECT 'product_images kayıt sayısı:' AS Info, COUNT(*) AS Sayi FROM product_images
GO
