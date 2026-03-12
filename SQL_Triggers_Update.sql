-- =====================================================
-- QUKA SENKRONIZASYON TRIGGER'LARI
-- Bu script mevcut trigger'ları günceller ve yenilerini ekler
-- Tablolar: products, product_images, fis_detay
-- =====================================================

-- =====================================================
-- 1. tbStok TRIGGER'LARI (Ürün değişiklikleri)
-- =====================================================

-- tbStok INSERT Trigger
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokInsWebTriggers')
    DROP TRIGGER [dbo].[tbStokInsWebTriggers]
GO

CREATE TRIGGER [dbo].[tbStokInsWebTriggers] 
ON [dbo].[tbStok] 
AFTER INSERT 
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- products tablosuna ekle veya güncelle (status=0 = senkronize edilmesi gerekiyor)
    -- DISTINCT kullanarak aynı productID için birden fazla satır olmasını engelle
    MERGE INTO dbo.products AS target
    USING (
        SELECT DISTINCT CONCAT(RTRIM(sModel), '__', RTRIM(sRenk)) AS productID
        FROM inserted 
        WHERE bWebGoruntule = 1
    ) AS source
    ON target.productID = source.productID
    WHEN MATCHED THEN
        UPDATE SET status = 0, updated_at = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT (productID, status, f_durum, updated_at)
        VALUES (source.productID, 0, 0, GETDATE());
    
    -- Eski tbWebGuncel sistemini de güncelle (geriye uyumluluk)
    IF EXISTS (SELECT 1 FROM inserted WHERE bWebGoruntule = 1)
    BEGIN
        UPDATE tbWebGuncel SET tbStokS = tbStokS + 1, sonGuncelleme = GETDATE();
    END
END
GO

-- tbStok UPDATE Trigger
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokUpdWebTriggers')
    DROP TRIGGER [dbo].[tbStokUpdWebTriggers]
GO

CREATE TRIGGER [dbo].[tbStokUpdWebTriggers] 
ON [dbo].[tbStok] 
AFTER UPDATE 
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- products tablosuna ekle veya güncelle
    -- DISTINCT kullanarak aynı productID için birden fazla satır olmasını engelle
    MERGE INTO dbo.products AS target
    USING (
        SELECT DISTINCT CONCAT(RTRIM(sModel), '__', RTRIM(sRenk)) AS productID
        FROM inserted 
        WHERE bWebGoruntule = 1
    ) AS source
    ON target.productID = source.productID
    WHEN MATCHED THEN
        UPDATE SET status = 0, updated_at = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT (productID, status, f_durum, updated_at)
        VALUES (source.productID, 0, 0, GETDATE());
    
    -- Eski tbWebGuncel sistemini de güncelle
    IF EXISTS (SELECT 1 FROM inserted WHERE bWebGoruntule = 1)
    BEGIN
        UPDATE tbWebGuncel SET tbStokS = tbStokS + 1, sonGuncelleme = GETDATE();
    END
END
GO

-- tbStok DELETE Trigger
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokDelWebTriggers')
    DROP TRIGGER [dbo].[tbStokDelWebTriggers]
GO

CREATE TRIGGER [dbo].[tbStokDelWebTriggers] 
ON [dbo].[tbStok] 
AFTER DELETE 
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- Silinen ürünleri products tablosunda işaretle (status=2 = silinecek)
    UPDATE p 
    SET p.status = 2, p.updated_at = GETDATE()
    FROM dbo.products p
    INNER JOIN deleted d ON p.productID = CONCAT(RTRIM(d.sModel), '__', RTRIM(d.sRenk))
    WHERE d.bWebGoruntule = 1;
    
    -- Eski tbWebGuncel sistemini de güncelle
    IF EXISTS (SELECT 1 FROM deleted WHERE bWebGoruntule = 1)
    BEGIN
        UPDATE tbWebGuncel SET tbStokS = tbStokS + 1, sonGuncelleme = GETDATE();
    END
END
GO

-- =====================================================
-- 2. tbStokFisiDetayi TRIGGER (Stok hareketleri)
-- =====================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFisiDetayiUpdate')
    DROP TRIGGER [dbo].[trg_StokFisiDetayiUpdate]
GO

CREATE TRIGGER [dbo].[trg_StokFisiDetayiUpdate] 
ON [dbo].[tbStokFisiDetayi] 
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- INSERT ve UPDATE için
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        -- products tablosunu güncelle (stok değişti)
        MERGE INTO dbo.products AS target
        USING (
            SELECT DISTINCT CONCAT(RTRIM(s.sModel), '__', RTRIM(s.sRenk)) AS productID
            FROM inserted i
            INNER JOIN dbo.tbStok s ON i.nStokID = s.nStokID
            WHERE s.bWebGoruntule = 1
        ) AS source
        ON target.productID = source.productID
        WHEN MATCHED THEN
            UPDATE SET status = 0, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, status, f_durum, updated_at)
            VALUES (source.productID, 0, 0, GETDATE());
    END
    
    -- DELETE için
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        -- products tablosunu güncelle
        UPDATE p 
        SET p.status = 0, p.updated_at = GETDATE()
        FROM dbo.products p
        INNER JOIN (
            SELECT DISTINCT CONCAT(RTRIM(s.sModel), '__', RTRIM(s.sRenk)) AS productID
            FROM deleted d
            INNER JOIN dbo.tbStok s ON d.nStokID = s.nStokID
            WHERE s.bWebGoruntule = 1
        ) src ON p.productID = src.productID;
    END
END
GO

-- =====================================================
-- 3. tbStokFiyati TRIGGER (Fiyat değişiklikleri)
-- =====================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFiyatiUpdate')
    DROP TRIGGER [dbo].[trg_StokFiyatiUpdate]
GO

CREATE TRIGGER [dbo].[trg_StokFiyatiUpdate] 
ON [dbo].[tbStokFiyati] 
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- INSERT ve UPDATE için
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        -- products tablosunu güncelle (fiyat değişti, f_durum=0)
        MERGE INTO dbo.products AS target
        USING (
            SELECT DISTINCT CONCAT(RTRIM(s.sModel), '__', RTRIM(s.sRenk)) AS productID
            FROM inserted i
            INNER JOIN dbo.tbStok s ON i.nStokID = s.nStokID
            WHERE s.bWebGoruntule = 1
        ) AS source
        ON target.productID = source.productID
        WHEN MATCHED THEN
            UPDATE SET f_durum = 0, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, status, f_durum, updated_at)
            VALUES (source.productID, 0, 0, GETDATE());
    END
    
    -- DELETE için
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE p 
        SET p.f_durum = 0, p.updated_at = GETDATE()
        FROM dbo.products p
        INNER JOIN (
            SELECT DISTINCT CONCAT(RTRIM(s.sModel), '__', RTRIM(s.sRenk)) AS productID
            FROM deleted d
            INNER JOIN dbo.tbStok s ON d.nStokID = s.nStokID
            WHERE s.bWebGoruntule = 1
        ) src ON p.productID = src.productID;
    END
END
GO

-- =====================================================
-- 4. tbStokResim TRIGGER (Resim değişiklikleri) - YENİ!
-- =====================================================

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokResimUpdate')
    DROP TRIGGER [dbo].[trg_StokResimUpdate]
GO

CREATE TRIGGER [dbo].[trg_StokResimUpdate] 
ON [dbo].[tbStokResim] 
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- INSERT ve UPDATE için
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        -- product_images tablosuna ekle veya güncelle
        MERGE INTO dbo.product_images AS target
        USING (
            SELECT 
                CONCAT(RTRIM(i.sModel), '__', ISNULL(RTRIM(i.sRenk), '')) AS productID,
                (SELECT COUNT(*) FROM tbStokResim WHERE sModel = i.sModel AND ISNULL(sRenk,'') = ISNULL(i.sRenk,'')) AS img_count
            FROM inserted i
            GROUP BY i.sModel, i.sRenk
        ) AS source
        ON target.productID = source.productID
        WHEN MATCHED THEN
            UPDATE SET status = 0, img_count = source.img_count, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, img_count, status, updated_at)
            VALUES (source.productID, source.img_count, 0, GETDATE());
        
        -- Eski tbWebGuncel sistemini de güncelle
        UPDATE tbWebGuncel SET tbStokResmiS = tbStokResmiS + 1, sonGuncelleme = GETDATE();
    END
    
    -- DELETE için
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        -- product_images tablosunu güncelle
        MERGE INTO dbo.product_images AS target
        USING (
            SELECT 
                CONCAT(RTRIM(d.sModel), '__', ISNULL(RTRIM(d.sRenk), '')) AS productID,
                (SELECT COUNT(*) FROM tbStokResim WHERE sModel = d.sModel AND ISNULL(sRenk,'') = ISNULL(d.sRenk,'')) AS img_count
            FROM deleted d
            GROUP BY d.sModel, d.sRenk
        ) AS source
        ON target.productID = source.productID
        WHEN MATCHED THEN
            UPDATE SET status = 0, img_count = source.img_count, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, img_count, status, updated_at)
            VALUES (source.productID, source.img_count, 0, GETDATE());
        
        UPDATE tbWebGuncel SET tbStokResmiS = tbStokResmiS + 1, sonGuncelleme = GETDATE();
    END
END
GO

-- =====================================================
-- 5. products tablosuna f_durum sütunu ekle (eğer yoksa)
-- =====================================================

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.products') AND name = 'f_durum')
BEGIN
    ALTER TABLE dbo.products ADD f_durum INT NOT NULL DEFAULT(0);
    PRINT 'f_durum sütunu products tablosuna eklendi.';
END
GO

-- =====================================================
-- ÖZET:
-- status = 0 → Senkronize edilmesi gerekiyor (stok değişti)
-- status = 1 → Senkronize edildi
-- status = 2 → Silinecek
-- f_durum = 0 → Fiyat senkronize edilmesi gerekiyor
-- f_durum = 1 → Fiyat senkronize edildi
-- =====================================================

PRINT 'Tüm trigger''lar başarıyla güncellendi!'
GO
