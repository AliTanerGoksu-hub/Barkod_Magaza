-- =============================================
-- MODEL BAZLI YAPILANDIRMA - MİGRATION SCRIPT
-- =============================================
-- Bu script veritabanını model bazlı yapıya dönüştürür
-- =============================================

USE [Database]; -- Veritabanı adınızı buraya yazın
GO

PRINT '========================================='
PRINT 'MODEL BAZLI YAPILANDIRMA BAŞLIYOR'
PRINT '========================================='
PRINT ''

-- =============================================
-- 1. YEDEK AL (ÖNEMLİ!)
-- =============================================
PRINT '1. Mevcut verilerin yedeği alınıyor...'
GO

-- tbStokSinifi yedek
IF OBJECT_ID('tbStokSinifi_BACKUP', 'U') IS NOT NULL
    DROP TABLE tbStokSinifi_BACKUP;
GO

SELECT * INTO tbStokSinifi_BACKUP FROM tbStokSinifi;
PRINT '   ✓ tbStokSinifi yedeklendi -> tbStokSinifi_BACKUP'
GO

-- tbStokAIIcerik yedek
IF OBJECT_ID('tbStokAIIcerik_BACKUP', 'U') IS NOT NULL
    DROP TABLE tbStokAIIcerik_BACKUP;
GO

SELECT * INTO tbStokAIIcerik_BACKUP FROM tbStokAIIcerik;
PRINT '   ✓ tbStokAIIcerik yedeklendi -> tbStokAIIcerik_BACKUP'
GO

-- =============================================
-- 2. tbStokSinifi'ye sModel kolonu ekle
-- =============================================
PRINT ''
PRINT '2. tbStokSinifi tablosuna sModel kolonu ekleniyor...'
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokSinifi') AND name = 'sModel')
BEGIN
    ALTER TABLE tbStokSinifi ADD sModel NVARCHAR(50) NULL;
    PRINT '   ✓ sModel kolonu eklendi'
END
ELSE
BEGIN
    PRINT '   ⚠ sModel kolonu zaten mevcut'
END
GO

-- =============================================
-- 3. tbStokAIIcerik'e sModel kolonu ekle
-- =============================================
PRINT ''
PRINT '3. tbStokAIIcerik tablosuna sModel kolonu ekleniyor...'
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sModel')
BEGIN
    ALTER TABLE tbStokAIIcerik ADD sModel NVARCHAR(50) NULL;
    PRINT '   ✓ sModel kolonu eklendi'
END
ELSE
BEGIN
    PRINT '   ⚠ sModel kolonu zaten mevcut'
END
GO

-- =============================================
-- 4. Mevcut verileri model bazlı yap
-- =============================================
PRINT ''
PRINT '4. Mevcut veriler model bazlı yapıya dönüştürülüyor...'
GO

-- tbStokSinifi için sModel doldur
UPDATE S
SET S.sModel = T.sModel
FROM tbStokSinifi S
INNER JOIN tbStok T ON T.nStokID = S.nStokID
WHERE S.sModel IS NULL;

DECLARE @UpdatedSinif INT = @@ROWCOUNT;
PRINT '   ✓ tbStokSinifi: ' + CAST(@UpdatedSinif AS NVARCHAR) + ' kayıt güncellendi'
GO

-- tbStokAIIcerik için sModel doldur
UPDATE A
SET A.sModel = T.sModel
FROM tbStokAIIcerik A
INNER JOIN tbStok T ON T.nStokID = A.nStokID
WHERE A.sModel IS NULL;

DECLARE @UpdatedAI INT = @@ROWCOUNT;
PRINT '   ✓ tbStokAIIcerik: ' + CAST(@UpdatedAI AS NVARCHAR) + ' kayıt güncellendi'
GO

-- =============================================
-- 5. Mükerrer kayıtları temizle (Model bazlı tek kayıt olmalı)
-- =============================================
PRINT ''
PRINT '5. Mükerrer kayıtlar temizleniyor (Model başına 1 kayıt kalacak)...'
GO

-- tbStokSinifi mükerrer temizleme
-- Her model için sadece ilk kaydı tut, diğerlerini sil
WITH CTE AS (
    SELECT 
        sModel,
        nStokID,
        ROW_NUMBER() OVER (PARTITION BY sModel ORDER BY nStokID ASC) AS RowNum
    FROM tbStokSinifi
    WHERE sModel IS NOT NULL
)
DELETE FROM tbStokSinifi
WHERE nStokID IN (
    SELECT nStokID FROM CTE WHERE RowNum > 1
);

DECLARE @DeletedSinif INT = @@ROWCOUNT;
PRINT '   ✓ tbStokSinifi: ' + CAST(@DeletedSinif AS NVARCHAR) + ' mükerrer kayıt silindi'
GO

-- tbStokAIIcerik mükerrer temizleme
WITH CTE AS (
    SELECT 
        sModel,
        nStokID,
        ROW_NUMBER() OVER (PARTITION BY sModel ORDER BY nStokID ASC) AS RowNum
    FROM tbStokAIIcerik
    WHERE sModel IS NOT NULL
)
DELETE FROM tbStokAIIcerik
WHERE nStokID IN (
    SELECT nStokID FROM CTE WHERE RowNum > 1
);

DECLARE @DeletedAI INT = @@ROWCOUNT;
PRINT '   ✓ tbStokAIIcerik: ' + CAST(@DeletedAI AS NVARCHAR) + ' mükerrer kayıt silindi'
GO

-- =============================================
-- 6. Index'leri oluştur (Performans için)
-- =============================================
PRINT ''
PRINT '6. Performans için index''ler oluşturuluyor...'
GO

-- tbStokSinifi sModel index
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokSinifi_sModel' AND object_id = OBJECT_ID('tbStokSinifi'))
BEGIN
    CREATE NONCLUSTERED INDEX IX_tbStokSinifi_sModel ON tbStokSinifi(sModel);
    PRINT '   ✓ tbStokSinifi.sModel index oluşturuldu'
END
ELSE
BEGIN
    PRINT '   ⚠ tbStokSinifi.sModel index zaten mevcut'
END
GO

-- tbStokAIIcerik sModel index
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokAIIcerik_sModel' AND object_id = OBJECT_ID('tbStokAIIcerik'))
BEGIN
    CREATE NONCLUSTERED INDEX IX_tbStokAIIcerik_sModel ON tbStokAIIcerik(sModel);
    PRINT '   ✓ tbStokAIIcerik.sModel index oluşturuldu'
END
ELSE
BEGIN
    PRINT '   ⚠ tbStokAIIcerik.sModel index zaten mevcut'
END
GO

-- =============================================
-- 7. Sonuçları kontrol et
-- =============================================
PRINT ''
PRINT '7. Sonuçlar kontrol ediliyor...'
PRINT '========================================='
GO

-- tbStokSinifi istatistikleri
PRINT ''
PRINT 'tbStokSinifi İstatistikleri:'
SELECT 
    COUNT(DISTINCT sModel) AS 'Toplam Model Sayısı',
    COUNT(*) AS 'Toplam Kayıt Sayısı',
    COUNT(CASE WHEN sModel IS NULL THEN 1 END) AS 'sModel Boş Kayıtlar'
FROM tbStokSinifi;
GO

-- tbStokAIIcerik istatistikleri
PRINT ''
PRINT 'tbStokAIIcerik İstatistikleri:'
SELECT 
    COUNT(DISTINCT sModel) AS 'Toplam Model Sayısı (AI içerikli)',
    COUNT(*) AS 'Toplam Kayıt Sayısı',
    COUNT(CASE WHEN sModel IS NULL THEN 1 END) AS 'sModel Boş Kayıtlar'
FROM tbStokAIIcerik;
GO

-- Örnek kayıtları göster
PRINT ''
PRINT 'Örnek tbStokSinifi kayıtları (İlk 5):'
SELECT TOP 5
    sModel AS 'Model',
    (SELECT sAciklama FROM tbSSinif3 WHERE sSinifKodu = sSinifKodu3) AS 'Marka',
    (SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu = sSinifKodu4) AS 'Ana Kategori',
    (SELECT sAciklama FROM tbSSinif8 WHERE sSinifKodu = sSinifKodu8) AS 'Etiket 1'
FROM tbStokSinifi
WHERE sModel IS NOT NULL
ORDER BY sModel;
GO

PRINT ''
PRINT 'Örnek tbStokAIIcerik kayıtları (İlk 5):'
SELECT TOP 5
    sModel AS 'Model',
    LEFT(sSEOBaslik, 50) AS 'SEO Başlık (İlk 50 kar)',
    LEFT(sMetaDescription, 50) AS 'Meta Açıklama (İlk 50 kar)'
FROM tbStokAIIcerik
WHERE sModel IS NOT NULL
ORDER BY sModel;
GO

-- =============================================
-- 8. TAMAMLANDI
-- =============================================
PRINT ''
PRINT '========================================='
PRINT '✅ MİGRATION TAMAMLANDI!'
PRINT '========================================='
PRINT ''
PRINT '⚠️  ÖNEMLİ NOTLAR:'
PRINT '1. Yedek tablolar oluşturuldu:'
PRINT '   - tbStokSinifi_BACKUP'
PRINT '   - tbStokAIIcerik_BACKUP'
PRINT ''
PRINT '2. Artık her iki tablo da model bazlı çalışıyor'
PRINT '3. Mükerrer kayıtlar temizlendi'
PRINT '4. Performans için index''ler eklendi'
PRINT ''
PRINT '5. *** ŞİMDİ UYGULAMAYİ YENİDEN DERLEYİN ***'
PRINT ''
PRINT '6. Sorun olursa geri dönüş:'
PRINT '   DROP TABLE tbStokSinifi; SELECT * INTO tbStokSinifi FROM tbStokSinifi_BACKUP;'
PRINT '   DROP TABLE tbStokAIIcerik; SELECT * INTO tbStokAIIcerik FROM tbStokAIIcerik_BACKUP;'
PRINT '========================================='
GO
