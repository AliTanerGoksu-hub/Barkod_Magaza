-- ============================================================================
-- QUKA WEB SENKRONIZASYON - TUM TRIGGER'LAR (RTRIM/LTRIM DUZELTMELI)
-- ============================================================================
-- Tarih: 2025-01
-- Aciklama: frm_qukagonder.vb formunda kullanilan TUM trigger'lar
--           RTRIM(LTRIM(...)) duzeltmesi ile olusturulur/guncellenir
-- 
-- ONEMLI: Bu script idempotent'tir - birden fazla kez calistirabilirsiniz
--         Varsa siler, yoksa olusturur
-- ============================================================================
-- 
-- KULLANIM:
-- 1. SQL Server Management Studio'da acin
-- 2. Dogru veritabanini secin (asagida BRISTOL kullaniyor)
-- 3. Tum script'i calistirin (F5)
--
-- ============================================================================

USE BRISTOL
GO

PRINT '============================================================================'
PRINT '  QUKA TRIGGER SISTEMI - RTRIM/LTRIM DUZELTMELI KURULUM'
PRINT '============================================================================'
PRINT ''
PRINT 'Baslangic: ' + CONVERT(VARCHAR(30), GETDATE(), 120)
PRINT ''
GO

-- ============================================================================
-- BOLUM 1: TABLO YAPISI KONTROLU
-- ============================================================================

PRINT '>> Tablo yapisi kontrol ediliyor...'
GO

-- products tablosu yoksa olustur
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Products')
BEGIN
    CREATE TABLE Products (
        productID NVARCHAR(200) PRIMARY KEY,
        status INT DEFAULT 1,
        f_durum INT DEFAULT 1,
        updated_at DATETIME DEFAULT GETDATE(),
        created_at DATETIME DEFAULT GETDATE()
    )
    PRINT '   [+] Products tablosu olusturuldu.'
END
ELSE
BEGIN
    -- Eksik sutunlari ekle
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Products') AND name = 'created_at')
        ALTER TABLE Products ADD created_at DATETIME DEFAULT GETDATE()
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Products') AND name = 'updated_at')
        ALTER TABLE Products ADD updated_at DATETIME DEFAULT GETDATE()
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Products') AND name = 'status')
        ALTER TABLE Products ADD status INT DEFAULT 1
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Products') AND name = 'f_durum')
        ALTER TABLE Products ADD f_durum INT DEFAULT 1
    
    PRINT '   [OK] Products tablosu mevcut.'
END
GO

-- product_images tablosu yoksa olustur
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'product_images')
BEGIN
    CREATE TABLE product_images (
        id INT IDENTITY(1,1) PRIMARY KEY,
        productID NVARCHAR(200),
        img_count INT DEFAULT 0,
        status INT DEFAULT 0,
        updated_at DATETIME DEFAULT GETDATE(),
        created_at DATETIME DEFAULT GETDATE()
    )
    PRINT '   [+] product_images tablosu olusturuldu.'
END
ELSE
BEGIN
    -- Eksik sutunlari ekle
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('product_images') AND name = 'img_count')
        ALTER TABLE product_images ADD img_count INT DEFAULT 0
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('product_images') AND name = 'updated_at')
        ALTER TABLE product_images ADD updated_at DATETIME DEFAULT GETDATE()
    
    PRINT '   [OK] product_images tablosu mevcut.'
END
GO

PRINT ''
PRINT '>> Trigger''lar olusturuluyor...'
PRINT ''
GO

-- ============================================================================
-- TRIGGER 1: tbStok INSERT (Yeni urun eklendiginde)
-- ============================================================================
PRINT '1. tbStokInsWebTriggers (tbStok INSERT)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokInsWebTriggers')
BEGIN
    DROP TRIGGER [dbo].[tbStokInsWebTriggers]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[tbStokInsWebTriggers] 
ON [dbo].[tbStok] 
AFTER INSERT 
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- Yeni urunleri products tablosuna ekle veya guncelle
    -- RTRIM(LTRIM(...)) ile bosluk sorunu onlenir
    MERGE INTO dbo.Products AS target
    USING (
        SELECT DISTINCT 
            RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(sRenk AS NVARCHAR(200)), ''))) AS productID
        FROM inserted 
        WHERE ISNULL(bWebGoruntule, 0) = 1
          AND sModel IS NOT NULL 
          AND RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) <> ''
    ) AS source
    ON RTRIM(LTRIM(target.productID)) = source.productID
    WHEN MATCHED THEN
        UPDATE SET status = 0, updated_at = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT (productID, status, f_durum, updated_at, created_at)
        VALUES (source.productID, 0, 0, GETDATE(), GETDATE());
END
GO

PRINT '   [OK] tbStokInsWebTriggers olusturuldu'
GO

-- ============================================================================
-- TRIGGER 2: tbStok UPDATE (Urun bilgisi guncellendiginde)
-- ============================================================================
PRINT ''
PRINT '2. tbStokUpdWebTriggers (tbStok UPDATE)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokUpdWebTriggers')
BEGIN
    DROP TRIGGER [dbo].[tbStokUpdWebTriggers]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[tbStokUpdWebTriggers] 
ON [dbo].[tbStok] 
AFTER UPDATE 
AS 
BEGIN
    SET NOCOUNT ON;
    
    MERGE INTO dbo.Products AS target
    USING (
        SELECT DISTINCT 
            RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(sRenk AS NVARCHAR(200)), ''))) AS productID
        FROM inserted 
        WHERE ISNULL(bWebGoruntule, 0) = 1
          AND sModel IS NOT NULL 
          AND RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) <> ''
    ) AS source
    ON RTRIM(LTRIM(target.productID)) = source.productID
    WHEN MATCHED THEN
        UPDATE SET status = 0, updated_at = GETDATE()
    WHEN NOT MATCHED THEN
        INSERT (productID, status, f_durum, updated_at, created_at)
        VALUES (source.productID, 0, 0, GETDATE(), GETDATE());
END
GO

PRINT '   [OK] tbStokUpdWebTriggers olusturuldu'
GO

-- ============================================================================
-- TRIGGER 3: tbStok DELETE (Urun silindiginde)
-- ============================================================================
PRINT ''
PRINT '3. tbStokDelWebTriggers (tbStok DELETE)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokDelWebTriggers')
BEGIN
    DROP TRIGGER [dbo].[tbStokDelWebTriggers]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[tbStokDelWebTriggers] 
ON [dbo].[tbStok] 
AFTER DELETE 
AS 
BEGIN
    SET NOCOUNT ON;
    
    -- Silinen urunleri status=2 (silinecek) olarak isaretle
    UPDATE p 
    SET p.status = 2, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN (
        SELECT DISTINCT 
            RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(sRenk AS NVARCHAR(200)), ''))) AS productID
        FROM deleted 
        WHERE ISNULL(bWebGoruntule, 0) = 1
          AND sModel IS NOT NULL 
          AND RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) <> ''
    ) AS d ON RTRIM(LTRIM(p.productID)) = d.productID;
END
GO

PRINT '   [OK] tbStokDelWebTriggers olusturuldu'
GO

-- ============================================================================
-- TRIGGER 4: tbStokFisiDetayi (Stok hareketi - giris/cikis)
-- ============================================================================
PRINT ''
PRINT '4. trg_StokFisiDetayi_WebSync (tbStokFisiDetayi INSERT/UPDATE/DELETE)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFisiDetayi_WebSync')
BEGIN
    DROP TRIGGER [dbo].[trg_StokFisiDetayi_WebSync]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[trg_StokFisiDetayi_WebSync]
ON [dbo].[tbStokFisiDetayi]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Guncellenen kayitlar icin
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        -- Yeni kayit ekle veya mevcut kaydi guncelle
        MERGE INTO dbo.Products AS target
        USING (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM inserted i
            INNER JOIN dbo.tbStok s ON i.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1
              AND s.sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
        ) AS source
        ON RTRIM(LTRIM(target.productID)) = source.productID
        WHEN MATCHED THEN
            UPDATE SET status = 0, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, status, f_durum, updated_at, created_at)
            VALUES (source.productID, 0, 1, GETDATE(), GETDATE());
    END
    
    -- Silinen kayitlar icin
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE p 
        SET p.status = 0, p.updated_at = GETDATE()
        FROM dbo.Products p
        INNER JOIN (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM deleted d
            INNER JOIN dbo.tbStok s ON d.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1
              AND s.sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
        ) AS src ON RTRIM(LTRIM(p.productID)) = src.productID;
    END
END
GO

PRINT '   [OK] trg_StokFisiDetayi_WebSync olusturuldu (Stok hareketi -> Products.status=0)'
GO

-- ============================================================================
-- TRIGGER 5: tbStokFiyati (Fiyat degisikligi)
-- ============================================================================
PRINT ''
PRINT '5. trg_StokFiyati_WebSync (tbStokFiyati INSERT/UPDATE/DELETE)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokFiyati_WebSync')
BEGIN
    DROP TRIGGER [dbo].[trg_StokFiyati_WebSync]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[trg_StokFiyati_WebSync]
ON [dbo].[tbStokFiyati]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Guncellenen kayitlar icin
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        MERGE INTO dbo.Products AS target
        USING (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM inserted i
            INNER JOIN dbo.tbStok s ON i.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1
              AND s.sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
        ) AS source
        ON RTRIM(LTRIM(target.productID)) = source.productID
        WHEN MATCHED THEN
            UPDATE SET f_durum = 0, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, status, f_durum, updated_at, created_at)
            VALUES (source.productID, 1, 0, GETDATE(), GETDATE());
    END
    
    -- Silinen kayitlar icin
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE p 
        SET p.f_durum = 0, p.updated_at = GETDATE()
        FROM dbo.Products p
        INNER JOIN (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM deleted d
            INNER JOIN dbo.tbStok s ON d.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1
              AND s.sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
        ) AS src ON RTRIM(LTRIM(p.productID)) = src.productID;
    END
END
GO

PRINT '   [OK] trg_StokFiyati_WebSync olusturuldu (Fiyat degisikligi -> Products.f_durum=0)'
GO

-- ============================================================================
-- TRIGGER 6: tbStokResim (Resim degisikligi)
-- ============================================================================
PRINT ''
PRINT '6. trg_StokResim_WebSync (tbStokResim INSERT/UPDATE/DELETE)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokResim_WebSync')
BEGIN
    DROP TRIGGER [dbo].[trg_StokResim_WebSync]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[trg_StokResim_WebSync]
ON [dbo].[tbStokResim]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Guncellenen kayitlar icin
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        MERGE dbo.product_images AS target
        USING (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM inserted
            WHERE sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) <> ''
        ) AS source (productID)
        ON RTRIM(LTRIM(target.productID)) = source.productID
        WHEN MATCHED THEN
            UPDATE SET status = 0, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, img_count, status, updated_at, created_at)
            VALUES (source.productID, 1, 0, GETDATE(), GETDATE());
    END
    
    -- Silinen kayitlar icin
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        MERGE dbo.product_images AS target
        USING (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM deleted
            WHERE sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) <> ''
        ) AS source (productID)
        ON RTRIM(LTRIM(target.productID)) = source.productID
        WHEN MATCHED THEN
            UPDATE SET status = 0, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, img_count, status, updated_at, created_at)
            VALUES (source.productID, 1, 0, GETDATE(), GETDATE());
    END
END
GO

PRINT '   [OK] trg_StokResim_WebSync olusturuldu (Resim degisikligi -> product_images.status=0)'
GO

-- ============================================================================
-- TRIGGER 7: tbStokSinifi (Kategori/Sinif degisikligi)
-- ============================================================================
PRINT ''
PRINT '7. trg_StokSinifi_WebSync (tbStokSinifi INSERT/UPDATE/DELETE)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokSinifi_WebSync')
BEGIN
    DROP TRIGGER [dbo].[trg_StokSinifi_WebSync]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[trg_StokSinifi_WebSync]
ON [dbo].[tbStokSinifi]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Eklenen/Guncellenen kayitlar icin
    IF EXISTS (SELECT 1 FROM inserted)
    BEGIN
        MERGE INTO dbo.Products AS target
        USING (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM inserted i
            INNER JOIN dbo.tbStok s ON i.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1
              AND s.sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
        ) AS source
        ON RTRIM(LTRIM(target.productID)) = source.productID
        WHEN MATCHED THEN
            UPDATE SET status = 0, updated_at = GETDATE()
        WHEN NOT MATCHED THEN
            INSERT (productID, status, f_durum, updated_at, created_at)
            VALUES (source.productID, 0, 1, GETDATE(), GETDATE());
    END
    
    -- Silinen kayitlar icin
    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        UPDATE p 
        SET p.status = 0, p.updated_at = GETDATE()
        FROM dbo.Products p
        INNER JOIN (
            SELECT DISTINCT 
                RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID
            FROM deleted d
            INNER JOIN dbo.tbStok s ON d.nStokID = s.nStokID
            WHERE ISNULL(s.bWebGoruntule, 0) = 1
              AND s.sModel IS NOT NULL 
              AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
        ) AS src ON RTRIM(LTRIM(p.productID)) = src.productID;
    END
END
GO

PRINT '   [OK] trg_StokSinifi_WebSync olusturuldu (Kategori degisikligi -> Products.status=0)'
GO

-- ============================================================================
-- TRIGGER 8: tbStokUzunNot (AI Uzun Aciklama)
-- ============================================================================
PRINT ''
PRINT '8. trg_StokUzunNot_WebSync (tbStokUzunNot INSERT/UPDATE)'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokUzunNot_WebSync')
BEGIN
    DROP TRIGGER [dbo].[trg_StokUzunNot_WebSync]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[trg_StokUzunNot_WebSync]
ON [dbo].[tbStokUzunNot]
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- tbStokUzunNot.sModel ile eslesen tum tbStok kayitlarini bul ve guncelle
    -- KRITIK: RTRIM(LTRIM(...)) ile bosluk sorunu onlenir
    
    -- Yeni kayit yoksa ekle
    INSERT INTO dbo.Products (productID, status, f_durum, updated_at, created_at)
    SELECT DISTINCT
        RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID,
        0, 1, GETDATE(), GETDATE()
    FROM inserted i
    INNER JOIN dbo.tbStok s ON RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) = RTRIM(LTRIM(CAST(i.sModel AS NVARCHAR(200))))
    WHERE ISNULL(s.bWebGoruntule, 0) = 1
      AND s.sModel IS NOT NULL 
      AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
      AND NOT EXISTS (
          SELECT 1 FROM dbo.Products p 
          WHERE RTRIM(LTRIM(p.productID)) = RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), '')))
      );
    
    -- Mevcut kayitlari guncelle - status=0 (icerik degisti, gonderilmeli)
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM dbo.Products p
    INNER JOIN (
        SELECT DISTINCT 
            RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID
        FROM inserted i 
        INNER JOIN dbo.tbStok s ON RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) = RTRIM(LTRIM(CAST(i.sModel AS NVARCHAR(200))))
        WHERE ISNULL(s.bWebGoruntule, 0) = 1 
          AND s.sModel IS NOT NULL 
          AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
    ) AS c ON RTRIM(LTRIM(p.productID)) = c.productID;
END
GO

PRINT '   [OK] trg_StokUzunNot_WebSync olusturuldu (AI Uzun Aciklama -> Products.status=0)'
GO

-- ============================================================================
-- TRIGGER 9: tbStokAIIcerik (AI SEO Icerik) - KRITIK DUZELTME
-- ============================================================================
PRINT ''
PRINT '9. trg_StokAIIcerik_WebSync (tbStokAIIcerik INSERT/UPDATE) - RTRIM/LTRIM DUZELTMELI'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokAIIcerik_WebSync')
BEGIN
    DROP TRIGGER [dbo].[trg_StokAIIcerik_WebSync]
    PRINT '   [!] Eski trigger silindi'
END
GO

CREATE TRIGGER [dbo].[trg_StokAIIcerik_WebSync]
ON [dbo].[tbStokAIIcerik]
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- ============================================================================
    -- KRITIK DUZELTME: 
    -- tbStokAIIcerik.sModel sutununda bosluk karakterleri olabilir
    -- RTRIM(LTRIM(CAST(...))) kullanarak bu sorun onlenir
    -- ============================================================================
    
    DECLARE @InsertedModel NVARCHAR(200);
    
    -- inserted tablosundan sModel degerini al ve temizle
    SELECT TOP 1 @InsertedModel = RTRIM(LTRIM(CAST(sModel AS NVARCHAR(200)))) 
    FROM inserted;
    
    -- Eger gecerli bir model yoksa cik
    IF @InsertedModel IS NULL OR @InsertedModel = ''
        RETURN;
    
    -- Debug icin (gerekirse acilabilir)
    -- PRINT 'Trigger calisti. Model: [' + @InsertedModel + ']';
    
    -- Yeni kayit yoksa ekle
    INSERT INTO BRISTOL.dbo.Products (productID, status, f_durum, updated_at, created_at)
    SELECT DISTINCT
        RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), ''))) AS productID,
        0, 1, GETDATE(), GETDATE()
    FROM BRISTOL.dbo.tbStok s 
    WHERE RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) = @InsertedModel
      AND ISNULL(s.bWebGoruntule, 0) = 1
      AND s.sModel IS NOT NULL 
      AND RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) <> ''
      AND NOT EXISTS (
          SELECT 1 FROM BRISTOL.dbo.Products p 
          WHERE RTRIM(LTRIM(p.productID)) = RTRIM(LTRIM(CAST(s.sModel AS NVARCHAR(200)))) + '__' + RTRIM(LTRIM(ISNULL(CAST(s.sRenk AS NVARCHAR(200)), '')))
      );
    
    -- Mevcut kayitlari guncelle - status=0 (SEO icerik degisti, gonderilmeli)
    -- KRITIK: Hem productID'yi hem de @InsertedModel'i RTRIM/LTRIM ile temizle
    UPDATE p 
    SET p.status = 0, p.updated_at = GETDATE()
    FROM BRISTOL.dbo.Products p
    WHERE RTRIM(LTRIM(p.productID)) LIKE @InsertedModel + '__%'
       OR RTRIM(LTRIM(p.productID)) = @InsertedModel + '__';
    
    -- Debug icin (gerekirse acilabilir)
    -- DECLARE @RowCount INT = @@ROWCOUNT;
    -- PRINT 'Guncellenen urun sayisi: ' + CAST(@RowCount AS VARCHAR(10));
END
GO

PRINT '   [OK] trg_StokAIIcerik_WebSync olusturuldu (AI SEO Icerik -> Products.status=0)'
GO

-- ============================================================================
-- KURULUM OZETI
-- ============================================================================

PRINT ''
PRINT '============================================================================'
PRINT '  KURULUM TAMAMLANDI!'
PRINT '============================================================================'
PRINT ''
PRINT 'Olusturulan/Guncellenen Trigger''lar:'
PRINT ''
PRINT '  TABLO               | TRIGGER ADI                    | ISLEM'
PRINT '  --------------------|--------------------------------|------------------'
PRINT '  tbStok              | tbStokInsWebTriggers           | INSERT -> status=0'
PRINT '  tbStok              | tbStokUpdWebTriggers           | UPDATE -> status=0'
PRINT '  tbStok              | tbStokDelWebTriggers           | DELETE -> status=2'
PRINT '  tbStokFisiDetayi    | trg_StokFisiDetayi_WebSync     | Stok hareketi -> status=0'
PRINT '  tbStokFiyati        | trg_StokFiyati_WebSync         | Fiyat -> f_durum=0'
PRINT '  tbStokResim         | trg_StokResim_WebSync          | Resim -> product_images.status=0'
PRINT '  tbStokSinifi        | trg_StokSinifi_WebSync         | Kategori -> status=0'
PRINT '  tbStokUzunNot       | trg_StokUzunNot_WebSync        | AI Uzun Aciklama -> status=0'
PRINT '  tbStokAIIcerik      | trg_StokAIIcerik_WebSync       | AI SEO Icerik -> status=0'
PRINT ''
PRINT 'Status Degerleri:'
PRINT '  - status = 0  -> Senkronize edilmesi gerekiyor'
PRINT '  - status = 1  -> Senkronize edildi'
PRINT '  - status = 2  -> Silinecek (web''den kaldirilacak)'
PRINT '  - f_durum = 0 -> Fiyat senkronize edilmesi gerekiyor'
PRINT '  - f_durum = 1 -> Fiyat senkronize edildi'
PRINT ''
PRINT 'KRITIK DUZELTME ACIKLAMASI:'
PRINT '  Tum trigger''larda RTRIM(LTRIM(CAST(...))) kullanildi.'
PRINT '  Bu duzeltme, veritabanindaki bosluk karakterlerinin'
PRINT '  trigger''larin calismamasi sorununu onler.'
PRINT ''
PRINT 'Bitis: ' + CONVERT(VARCHAR(30), GETDATE(), 120)
PRINT '============================================================================'
GO

-- ============================================================================
-- TRIGGER KONTROL SORGUSU
-- ============================================================================

PRINT ''
PRINT '>> Trigger Kontrol Sorgusu:'
PRINT ''

SELECT 
    t.name AS [Trigger Adi],
    OBJECT_NAME(t.parent_id) AS [Tablo],
    CASE WHEN t.is_disabled = 0 THEN 'AKTIF' ELSE 'DEVRE DISI' END AS [Durum],
    t.create_date AS [Olusturma Tarihi],
    t.modify_date AS [Degistirilme Tarihi]
FROM sys.triggers t
WHERE t.name IN (
    'tbStokInsWebTriggers',
    'tbStokUpdWebTriggers',
    'tbStokDelWebTriggers',
    'trg_StokFisiDetayi_WebSync',
    'trg_StokFiyati_WebSync',
    'trg_StokResim_WebSync',
    'trg_StokSinifi_WebSync',
    'trg_StokUzunNot_WebSync',
    'trg_StokAIIcerik_WebSync'
)
ORDER BY OBJECT_NAME(t.parent_id), t.name
GO
