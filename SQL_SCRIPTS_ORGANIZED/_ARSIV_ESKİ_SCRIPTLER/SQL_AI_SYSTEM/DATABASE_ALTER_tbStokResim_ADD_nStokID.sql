-- =====================================================
-- tbStokResim: nStokID Kolonu Ekleme (V3)
-- =====================================================
-- nStokID ile tbStok'a JOIN yaparak renk, beden, kavala
-- bilgilerini güvenilir şekilde alabiliriz
-- =====================================================

-- ADIM 1: nStokID, sBeden, sKavala kolonlarını ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'nStokID')
BEGIN
    ALTER TABLE tbStokResim ADD nStokID INT NULL;
    PRINT 'tbStokResim tablosuna nStokID kolonu eklendi.';
END
ELSE
BEGIN
    PRINT 'nStokID kolonu zaten mevcut.';
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'sBeden')
BEGIN
    ALTER TABLE tbStokResim ADD sBeden VARCHAR(10) NULL;
    PRINT 'tbStokResim tablosuna sBeden kolonu eklendi.';
END
ELSE
BEGIN
    PRINT 'sBeden kolonu zaten mevcut.';
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'sKavala')
BEGIN
    ALTER TABLE tbStokResim ADD sKavala VARCHAR(10) NULL;
    PRINT 'tbStokResim tablosuna sKavala kolonu eklendi.';
END
ELSE
BEGIN
    PRINT 'sKavala kolonu zaten mevcut.';
END
GO

-- ADIM 2: Mevcut resimlere nStokID, sBeden, sKavala'yı doldur
-- İlk nStokID'yi bul (sModel + sRenk ile eşleştir)
UPDATE SR
SET SR.nStokID = S.nStokID,
    SR.sBeden = S.sBeden,
    SR.sKavala = S.sKavala
FROM tbStokResim SR
INNER JOIN tbStok S ON S.sModel = SR.sModel 
    AND (S.sRenk = SR.sRenk OR (S.sRenk IS NULL AND SR.sRenk IS NULL))
WHERE SR.nStokID IS NULL
GO

PRINT 'Mevcut resimlere nStokID, sBeden, sKavala atandı.';
GO

-- ADIM 3: Index oluştur (Performance)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_nStokID' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE INDEX IX_tbStokResim_nStokID ON tbStokResim(nStokID);
    PRINT 'Index oluşturuldu: IX_tbStokResim_nStokID';
END
GO

-- ADIM 4: Composite index güncelle (Model + Renk + Sira yerine nStokID + Sira)
IF EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_sModel_sRenk_nSira' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    DROP INDEX IX_sModel_sRenk_nSira ON tbStokResim;
    PRINT 'Eski index silindi: IX_sModel_sRenk_nSira';
END
GO

-- Yeni composite index (nStokID + nSira)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_nStokID_nSira' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE INDEX IX_tbStokResim_nStokID_nSira ON tbStokResim(nStokID, nSira);
    PRINT 'Yeni index oluşturuldu: IX_tbStokResim_nStokID_nSira';
END
GO

-- ADIM 5: sModel için index koru (E-ticaret queries için)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_sModel' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE INDEX IX_tbStokResim_sModel ON tbStokResim(sModel);
    PRINT 'Index oluşturuldu: IX_tbStokResim_sModel';
END
GO

-- =====================================================
-- KONTROLPlutocratic QUERIES
-- =====================================================

-- 1. Migration kontrolü
SELECT 
    COUNT(*) AS ToplamResim,
    SUM(CASE WHEN nStokID IS NULL THEN 1 ELSE 0 END) AS nStokIDNullOlanlar,
    SUM(CASE WHEN nStokID IS NOT NULL THEN 1 ELSE 0 END) AS nStokIDDoluOlanlar
FROM tbStokResim
GO

-- 2. Örnek JOIN query (Renk, Beden, Kavala ile)
/*
SELECT TOP 10
    SR.nStokResimID,
    SR.sModel,
    SR.nStokID,
    SR.nSira,
    S.sKodu,
    S.sRenk,
    R.sRenkAdi,
    S.sBeden,
    S.sKavala,
    SR.yol
FROM tbStokResim SR
LEFT JOIN tbStok S ON SR.nStokID = S.nStokID
LEFT JOIN tbRenk R ON S.sRenk = R.sRenk
ORDER BY SR.nStokResimID DESC
*/

PRINT '==============================================';
PRINT 'tbStokResim tablosu nStokID ile güncellendi!';
PRINT '==============================================';
GO
