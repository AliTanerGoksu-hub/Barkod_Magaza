-- =====================================================
-- tbStokResim: sRenk Kolonu Ekleme
-- =====================================================
-- sRenk kolonunu tbStokResim tablosuna ekler
-- Mevcut veriler için tbStok'tan sRenk bilgisini çeker
-- =====================================================

-- ADIM 1: sRenk kolonunu ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'sRenk')
BEGIN
    ALTER TABLE tbStokResim ADD sRenk VARCHAR(10) NULL;
    PRINT 'tbStokResim tablosuna sRenk kolonu eklendi.';
END
ELSE
BEGIN
    PRINT 'sRenk kolonu zaten mevcut.';
END
GO

-- ADIM 2: Mevcut resimlere sRenk değerini doldur
-- nStokID üzerinden tbStok'tan sRenk bilgisini çek
UPDATE SR
SET SR.sRenk = S.sRenk
FROM tbStokResim SR
INNER JOIN tbStok S ON S.nStokID = SR.nStokID
WHERE SR.sRenk IS NULL OR SR.sRenk = ''
GO

PRINT 'Mevcut resimlere sRenk değeri atandı.';
GO

-- KONTROL: Kaç kayda sRenk atandı?
SELECT 
    COUNT(*) AS ToplamResim,
    SUM(CASE WHEN sRenk IS NULL OR sRenk = '' THEN 1 ELSE 0 END) AS sRenkBosOlanlar,
    SUM(CASE WHEN sRenk IS NOT NULL AND sRenk <> '' THEN 1 ELSE 0 END) AS sRenkDoluOlanlar
FROM tbStokResim
GO

PRINT '==============================================';
PRINT 'tbStokResim tablosu sRenk ile güncellendi!';
PRINT '==============================================';
GO
