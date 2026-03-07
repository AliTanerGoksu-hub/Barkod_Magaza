-- =============================================
-- QUKA Senkronizasyon Trigger Sistemi
-- Tarih: 2026-01-21
-- Açıklama: tbStok, tbStokFiyati, tbStokFisiDetayi 
-- tablolarındaki değişiklikleri products tablosuna yansıtır
-- =============================================

-- =============================================
-- BÖLÜM 1: TABLO YAPISI
-- =============================================

-- products tablosu yoksa oluştur
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'products')
BEGIN
    CREATE TABLE products (
        productID NVARCHAR(200) PRIMARY KEY,
        status INT DEFAULT 1,
        f_durum INT DEFAULT 1,
        updated_at DATETIME DEFAULT GETDATE(),
        created_at DATETIME DEFAULT GETDATE()
    )
    PRINT 'products tablosu oluşturuldu.'
END
ELSE
BEGIN
    -- Eksik sütunları ekle
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('products') AND name = 'created_at')
        ALTER TABLE products ADD created_at DATETIME DEFAULT GETDATE()
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('products') AND name = 'updated_at')
        ALTER TABLE products ADD updated_at DATETIME DEFAULT GETDATE()
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('products') AND name = 'status')
        ALTER TABLE products ADD status INT DEFAULT 1
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('products') AND name = 'f_durum')
        ALTER TABLE products ADD f_durum INT DEFAULT 1
    
    PRINT 'products tablosu güncellendi.'
END
GO

-- product_images tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'product_images')
BEGIN
    CREATE TABLE product_images (
        id INT IDENTITY(1,1) PRIMARY KEY,
        productID NVARCHAR(200),
        image_url NVARCHAR(500),
        status INT DEFAULT 0,
        created_at DATETIME DEFAULT GETDATE()
    )
    PRINT 'product_images tablosu oluşturuldu.'
END
GO

-- NULL değerleri düzelt
UPDATE products SET created_at = GETDATE() WHERE created_at IS NULL
UPDATE products SET updated_at = GETDATE() WHERE updated_at IS NULL
UPDATE products SET status = 1 WHERE status IS NULL
UPDATE products SET f_durum = 1 WHERE f_durum IS NULL
GO

-- =============================================
-- BÖLÜM 2: TRIGGER'LAR
-- =============================================

-- TRIGGER 1: Stok Hareketi (tbStokFisiDetayi)
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFisiDetayi_QUKA')
    DROP TRIGGER trg_StokFisiDetayi_QUKA
GO

CREATE TRIGGER trg_StokFisiDetayi_QUKA
ON tbStokFisiDetayi
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO products (productID, status, f_durum, updated_at, created_at)
        SELECT DISTINCT
            RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID,
            0, 1, GETDATE(), GETDATE()
        FROM inserted i
        INNER JOIN tbStok s ON i.nStokID = s.nStokID
        WHERE ISNULL(s.bWebGoruntule, 0) = 1
          AND s.sModel IS NOT NULL AND s.sModel <> ''
          AND NOT EXISTS (
              SELECT 1 FROM products p 
              WHERE p.productID = RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))
          )
        
        UPDATE p SET p.status = 0, p.updated_at = GETDATE()
        FROM products p
        INNER JOIN (
            SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
            FROM inserted i INNER JOIN tbStok s ON i.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1 AND s.sModel IS NOT NULL AND s.sModel <> ''
        ) AS c ON p.productID = c.productID
    END
    
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE p SET p.status = 0, p.updated_at = GETDATE()
        FROM products p
        INNER JOIN (
            SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
            FROM deleted d INNER JOIN tbStok s ON d.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1 AND s.sModel IS NOT NULL AND s.sModel <> ''
        ) AS c ON p.productID = c.productID
    END
END
GO
PRINT 'trg_StokFisiDetayi_QUKA oluşturuldu.'
GO

-- TRIGGER 2: Fiyat Değişikliği (tbStokFiyati)
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFiyati_QUKA')
    DROP TRIGGER trg_StokFiyati_QUKA
GO

CREATE TRIGGER trg_StokFiyati_QUKA
ON tbStokFiyati
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO products (productID, status, f_durum, updated_at, created_at)
        SELECT DISTINCT
            RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID,
            1, 0, GETDATE(), GETDATE()
        FROM inserted i
        INNER JOIN tbStok s ON i.nStokID = s.nStokID
        WHERE ISNULL(s.bWebGoruntule, 0) = 1
          AND s.sModel IS NOT NULL AND s.sModel <> ''
          AND NOT EXISTS (
              SELECT 1 FROM products p 
              WHERE p.productID = RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))
          )
        
        UPDATE p SET p.f_durum = 0, p.updated_at = GETDATE()
        FROM products p
        INNER JOIN (
            SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
            FROM inserted i INNER JOIN tbStok s ON i.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1 AND s.sModel IS NOT NULL AND s.sModel <> ''
        ) AS c ON p.productID = c.productID
    END
    
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE p SET p.f_durum = 0, p.updated_at = GETDATE()
        FROM products p
        INNER JOIN (
            SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
            FROM deleted d INNER JOIN tbStok s ON d.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1 AND s.sModel IS NOT NULL AND s.sModel <> ''
        ) AS c ON p.productID = c.productID
    END
END
GO
PRINT 'trg_StokFiyati_QUKA oluşturuldu.'
GO

-- TRIGGER 3: Ürün Bilgisi (tbStok)
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_Stok_QUKA')
    DROP TRIGGER trg_Stok_QUKA
GO

CREATE TRIGGER trg_Stok_QUKA
ON tbStok
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO products (productID, status, f_durum, updated_at, created_at)
    SELECT DISTINCT
        RTRIM(LTRIM(i.sModel)) + '__' + RTRIM(LTRIM(ISNULL(i.sRenk, ''))) AS productID,
        0, 0, GETDATE(), GETDATE()
    FROM inserted i
    WHERE ISNULL(i.bWebGoruntule, 0) = 1
      AND i.sModel IS NOT NULL AND i.sModel <> ''
      AND NOT EXISTS (
          SELECT 1 FROM products p 
          WHERE p.productID = RTRIM(LTRIM(i.sModel)) + '__' + RTRIM(LTRIM(ISNULL(i.sRenk, '')))
      )
    
    UPDATE p SET p.status = 0, p.f_durum = 0, p.updated_at = GETDATE()
    FROM products p
    INNER JOIN inserted i ON p.productID = RTRIM(LTRIM(i.sModel)) + '__' + RTRIM(LTRIM(ISNULL(i.sRenk, '')))
    WHERE ISNULL(i.bWebGoruntule, 0) = 1
END
GO
PRINT 'trg_Stok_QUKA oluşturuldu.'
GO

-- =============================================
-- TRIGGER 4: AI İçerik Güncellemesi (tbStokUzunNot)
-- =============================================
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokUzunNot_QUKA')
    DROP TRIGGER trg_StokUzunNot_QUKA
GO

CREATE TRIGGER trg_StokUzunNot_QUKA
ON tbStokUzunNot
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- tbStokUzunNot.sModel ile eşleşen tüm tbStok kayıtlarını bul
    INSERT INTO products (productID, status, f_durum, updated_at, created_at)
    SELECT DISTINCT
        RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID,
        0, 1, GETDATE(), GETDATE()
    FROM inserted i
    INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(i.sModel))
    WHERE ISNULL(s.bWebGoruntule, 0) = 1
      AND s.sModel IS NOT NULL AND s.sModel <> ''
      AND NOT EXISTS (
          SELECT 1 FROM products p 
          WHERE p.productID = RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))
      )
    
    -- Mevcut kayıtları güncelle - status=0 (içerik değişti, gönderilmeli)
    UPDATE p SET p.status = 0, p.updated_at = GETDATE()
    FROM products p
    INNER JOIN (
        SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
        FROM inserted i 
        INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(i.sModel))
        WHERE ISNULL(s.bWebGoruntule, 0) = 1 AND s.sModel IS NOT NULL AND s.sModel <> ''
    ) AS c ON p.productID = c.productID
END
GO
PRINT 'trg_StokUzunNot_QUKA oluşturuldu (AI içerik trigger).'
GO

-- =============================================
-- TRIGGER 5: AI SEO İçerik Güncellemesi (tbStokAIIcerik)
-- =============================================
IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokAIIcerik_QUKA')
    DROP TRIGGER trg_StokAIIcerik_QUKA
GO

CREATE TRIGGER trg_StokAIIcerik_QUKA
ON tbStokAIIcerik
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- tbStokAIIcerik.sModel ile eşleşen tüm tbStok kayıtlarını bul
    INSERT INTO products (productID, status, f_durum, updated_at, created_at)
    SELECT DISTINCT
        RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID,
        0, 1, GETDATE(), GETDATE()
    FROM inserted i
    INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(i.sModel))
    WHERE ISNULL(s.bWebGoruntule, 0) = 1
      AND s.sModel IS NOT NULL AND s.sModel <> ''
      AND NOT EXISTS (
          SELECT 1 FROM products p 
          WHERE p.productID = RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))
      )
    
    -- Mevcut kayıtları güncelle - status=0 (SEO içerik değişti, gönderilmeli)
    UPDATE p SET p.status = 0, p.updated_at = GETDATE()
    FROM products p
    INNER JOIN (
        SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
        FROM inserted i 
        INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(i.sModel))
        WHERE ISNULL(s.bWebGoruntule, 0) = 1 AND s.sModel IS NOT NULL AND s.sModel <> ''
    ) AS c ON p.productID = c.productID
END
GO
PRINT 'trg_StokAIIcerik_QUKA oluşturuldu (AI SEO trigger).'
GO

-- =============================================
-- BÖLÜM 3: MEVCUT ÜRÜNLERİ EKLE (İLK KURULUM)
-- =============================================
INSERT INTO products (productID, status, f_durum, updated_at, created_at)
SELECT DISTINCT
    RTRIM(LTRIM(sModel)) + '__' + RTRIM(LTRIM(ISNULL(sRenk, ''))) AS productID,
    0, 0, GETDATE(), GETDATE()
FROM tbStok
WHERE ISNULL(bWebGoruntule, 0) = 1
  AND sModel IS NOT NULL AND sModel <> ''
  AND NOT EXISTS (
      SELECT 1 FROM products p 
      WHERE p.productID = RTRIM(LTRIM(sModel)) + '__' + RTRIM(LTRIM(ISNULL(sRenk, '')))
  )
GO

PRINT ''
PRINT '============================================='
PRINT 'QUKA TRIGGER SISTEMI KURULUMU TAMAMLANDI!'
PRINT '============================================='
GO
