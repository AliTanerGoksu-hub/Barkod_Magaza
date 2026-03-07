-- ============================================================================
-- SINIF/KATEGORİ TRİGGER EKLEMESİ
-- ============================================================================
-- Tarih: 2025-02-14
-- Açıklama: Kategori/Sınıf değişikliklerini algılayan trigger
-- 
-- SORUN: Mevcut sistemde sınıf değişiklikleri trigger ile algılanmıyordu
-- ÇÖZÜM: tbStokSinifi tablosuna trigger eklendi
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
PRINT 'Sınıf/Kategori Trigger Ekleniyor...'
PRINT '============================================'
GO

-- Eski trigger varsa sil
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokSinifi_WebSync')
BEGIN
    DROP TRIGGER trg_StokSinifi_WebSync
    PRINT '> Eski trg_StokSinifi_WebSync silindi'
END
GO

-- Yeni trigger oluştur
CREATE TRIGGER trg_StokSinifi_WebSync
ON dbo.tbStokSinifi
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Güncellenen kayıtlar için
    -- Kategori değiştiğinde products.status = 0 yap
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

PRINT ''
PRINT '============================================'
PRINT 'Sınıf/Kategori Trigger Eklendi!'
PRINT '============================================'
PRINT ''
PRINT 'Artık tbStokSinifi tablosunda değişiklik olduğunda:'
PRINT '  - sSinifKodu3 (Marka)'
PRINT '  - sSinifKodu4 (Kategori 1)'
PRINT '  - sSinifKodu5 (Kategori 2)'
PRINT '  - sSinifKodu6 (Kategori 3)'
PRINT '  - sSinifKodu7 (Kategori 4)'
PRINT '  - sSinifKodu8 (Kategori 5)'
PRINT ''
PRINT 'değişikliklerinde products.status = 0 olacak'
PRINT 've trigger sistemi bu ürünleri web''e gönderecek!'
GO

-- Test için: Trigger'ın oluştuğunu kontrol et
SELECT 
    name AS TriggerName,
    OBJECT_NAME(parent_id) AS TableName,
    create_date AS CreatedDate,
    modify_date AS ModifiedDate
FROM sys.triggers 
WHERE name = 'trg_StokSinifi_WebSync'
GO
