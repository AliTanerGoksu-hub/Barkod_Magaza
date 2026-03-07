-- =====================================================
-- tbStokResim: KOMPLE GÜNCELLEME
-- =====================================================
-- Bu script tbStokResim tablosuna tüm gerekli kolonları ekler:
-- - nStokID (INT): Ürün varyant ID'si
-- - sRenk (VARCHAR(10)): Renk kodu
-- - sBeden (VARCHAR(10)): Beden
-- - sKavala (VARCHAR(10)): Kavala kodu
-- =====================================================

PRINT '==============================================';
PRINT 'tbStokResim Tablosu Güncelleniyor...';
PRINT '==============================================';
GO

-- ADIM 1: nStokID kolonunu ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'nStokID')
BEGIN
    ALTER TABLE tbStokResim ADD nStokID INT NULL;
    PRINT '✓ nStokID kolonu eklendi.';
END
ELSE
BEGIN
    PRINT '○ nStokID kolonu zaten mevcut.';
END
GO

-- ADIM 2: sRenk kolonunu ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'sRenk')
BEGIN
    ALTER TABLE tbStokResim ADD sRenk VARCHAR(10) NULL;
    PRINT '✓ sRenk kolonu eklendi.';
END
ELSE
BEGIN
    PRINT '○ sRenk kolonu zaten mevcut.';
END
GO

-- ADIM 3: sBeden kolonunu ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'sBeden')
BEGIN
    ALTER TABLE tbStokResim ADD sBeden VARCHAR(10) NULL;
    PRINT '✓ sBeden kolonu eklendi.';
END
ELSE
BEGIN
    PRINT '○ sBeden kolonu zaten mevcut.';
END
GO

-- ADIM 4: sKavala kolonunu ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'sKavala')
BEGIN
    ALTER TABLE tbStokResim ADD sKavala VARCHAR(10) NULL;
    PRINT '✓ sKavala kolonu eklendi.';
END
ELSE
BEGIN
    PRINT '○ sKavala kolonu zaten mevcut.';
END
GO

PRINT '';
PRINT 'Kolonlar eklendi. Şimdi mevcut verileri dolduruyoruz...';
PRINT '';
GO

-- ADIM 5: Mevcut resimlere nStokID, sRenk, sBeden, sKavala değerlerini doldur
-- Strateji: sModel + sRenk eşleşmesi ile ilk nStokID'yi bul
DECLARE @UpdatedRows INT = 0;

UPDATE SR
SET SR.nStokID = S.nStokID,
    SR.sRenk = S.sRenk,
    SR.sBeden = S.sBeden,
    SR.sKavala = S.sKavala
FROM tbStokResim SR
INNER JOIN (
    -- Her sModel için ilk nStokID'yi al (sRenk eşleşmesi ile)
    SELECT sModel, sRenk, MIN(nStokID) AS nStokID, MAX(sBeden) AS sBeden, MAX(sKavala) AS sKavala
    FROM tbStok
    GROUP BY sModel, sRenk
) S ON S.sModel = SR.sModel 
    AND (S.sRenk = SR.sRenk OR (S.sRenk IS NULL AND SR.sRenk IS NULL))
WHERE SR.nStokID IS NULL;

SET @UpdatedRows = @@ROWCOUNT;
PRINT '✓ ' + CAST(@UpdatedRows AS VARCHAR(10)) + ' adet kayda nStokID, sRenk, sBeden, sKavala atandı.';
GO

PRINT '';
PRINT 'Index oluşturuluyor...';
PRINT '';
GO

-- ADIM 6: Index'leri oluştur (Performance)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_nStokID' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE INDEX IX_tbStokResim_nStokID ON tbStokResim(nStokID);
    PRINT '✓ Index oluşturuldu: IX_tbStokResim_nStokID';
END
ELSE
BEGIN
    PRINT '○ Index zaten mevcut: IX_tbStokResim_nStokID';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_sModel' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE INDEX IX_tbStokResim_sModel ON tbStokResim(sModel);
    PRINT '✓ Index oluşturuldu: IX_tbStokResim_sModel';
END
ELSE
BEGIN
    PRINT '○ Index zaten mevcut: IX_tbStokResim_sModel';
END
GO

PRINT '';
PRINT 'KONTROL: Tablo durumu kontrol ediliyor...';
PRINT '';
GO

-- ADIM 7: Kontrol sorgusu
SELECT 
    COUNT(*) AS ToplamResim,
    SUM(CASE WHEN nStokID IS NULL THEN 1 ELSE 0 END) AS nStokID_NULL,
    SUM(CASE WHEN nStokID IS NOT NULL THEN 1 ELSE 0 END) AS nStokID_DOLU,
    SUM(CASE WHEN sRenk IS NULL OR sRenk = '' THEN 1 ELSE 0 END) AS sRenk_BOS,
    SUM(CASE WHEN sRenk IS NOT NULL AND sRenk <> '' THEN 1 ELSE 0 END) AS sRenk_DOLU,
    SUM(CASE WHEN sBeden IS NULL OR sBeden = '' THEN 1 ELSE 0 END) AS sBeden_BOS,
    SUM(CASE WHEN sBeden IS NOT NULL AND sBeden <> '' THEN 1 ELSE 0 END) AS sBeden_DOLU,
    SUM(CASE WHEN sKavala IS NULL OR sKavala = '' THEN 1 ELSE 0 END) AS sKavala_BOS,
    SUM(CASE WHEN sKavala IS NOT NULL AND sKavala <> '' THEN 1 ELSE 0 END) AS sKavala_DOLU
FROM tbStokResim;
GO

PRINT '';
PRINT '==============================================';
PRINT '✓✓✓ tbStokResim GÜNCELLEME TAMAMLANDI! ✓✓✓';
PRINT '==============================================';
PRINT '';
PRINT 'ŞİMDİ YAPABİLECEKLERİNİZ:';
PRINT '1. Yeni resim yükleyin - nStokID, sRenk, sBeden, sKavala otomatik kaydedilecek';
PRINT '2. Grid''de Renk, Beden, Kavala kolonları görünür olacak';
PRINT '3. E-ticaret entegrasyonu renk bazlı resimleri alabilecek';
PRINT '';
GO
