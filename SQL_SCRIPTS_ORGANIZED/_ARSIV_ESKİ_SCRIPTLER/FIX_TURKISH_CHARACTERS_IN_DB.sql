-- =====================================================
-- VERİTABANINDAKİ BOZUK TÜRKÇE KARAKTERLERİ DÜZELTİCİ
-- =====================================================
-- Bu script tbStokFisiMaster tablosundaki bozuk Türkçe karakterleri düzeltir
-- {240} -> ğ, {253} -> ı, {246} -> ö, {252} -> ü, {231} -> ç, {222} -> Ş vb.

SET NOCOUNT ON
GO

PRINT '==================== TÜRKÇE KARAKTER DÜZELTİCİ BAŞLATILIYOR ===================='
PRINT 'Tarih: ' + CONVERT(VARCHAR(20), GETDATE(), 120)
PRINT ''

-- Önce kaç kayıt etkilenecek görelim
DECLARE @ToplamKayit INT
DECLARE @BozukKayit INT

SELECT @ToplamKayit = COUNT(*) 
FROM tbStokFisiMaster

SELECT @BozukKayit = COUNT(DISTINCT nStokFisiID)
FROM tbStokFisiMaster
WHERE 
    -- Firma tablosundaki firma adlarında bozuk karakterler
    nFirmaID IN (
        SELECT nFirmaID 
        FROM tbFirma 
        WHERE sAciklama LIKE '%{%}%'
           OR sAciklama LIKE '%Ã%'
           OR sAciklama LIKE '%Ä%'
           OR sAciklama LIKE '%Å%'
    )

PRINT 'Toplam Kayıt Sayısı: ' + CAST(@ToplamKayit AS VARCHAR(10))
PRINT 'Bozuk Karakter İçeren Firma Sayısı: ' + CAST(@BozukKayit AS VARCHAR(10))
PRINT ''

-- ======================================
-- ADIM 1: tbFirma Tablosunu Düzelt
-- ======================================
PRINT '==================== ADIM 1: tbFirma Düzeltiliyor ===================='

UPDATE tbFirma
SET sAciklama = 
    -- {kod} formatındaki karakterleri düzelt
    REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
    REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
        sAciklama,
        '{199}', 'Ç'),    -- Ç
        '{231}', 'ç'),    -- ç
        '{208}', 'Ğ'),    -- Ğ
        '{240}', 'ğ'),    -- ğ
        '{221}', 'İ'),    -- İ
        '{253}', 'ı'),    -- ı
        '{214}', 'Ö'),    -- Ö
        '{246}', 'ö'),    -- ö
        '{222}', 'Ş'),    -- Ş
        '{254}', 'ş'),    -- ş
        '{220}', 'Ü'),    -- Ü
        '{252}', 'ü')     -- ü
WHERE 
    sAciklama LIKE '%{%}%'

PRINT 'tbFirma tablosu düzeltildi: ' + CAST(@@ROWCOUNT AS VARCHAR(10)) + ' kayıt güncellendi'
PRINT ''

-- Mojibake karakterlerini de düzelt
UPDATE tbFirma
SET sAciklama = 
    REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
    REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
    REPLACE(REPLACE(
        sAciklama,
        'Ã§', 'ç'),
        'Ã°', 'ğ'),
        'Ä±', 'ı'),
        'Ã¶', 'ö'),
        'Å', 'ş'),
        'Ã¼', 'ü'),
        'Ã', 'Ç'),
        'Ä', 'Ğ'),
        'Ä°', 'İ'),
        'Ã', 'Ö'),
        'Å', 'Ş'),
        'Ã', 'Ü'),
        'Ã½', 'ı'),
        'Ã¾', 'ş')
WHERE 
    sAciklama LIKE '%Ã%'
    OR sAciklama LIKE '%Ä%'
    OR sAciklama LIKE '%Å%'

PRINT 'Mojibake karakterleri düzeltildi: ' + CAST(@@ROWCOUNT AS VARCHAR(10)) + ' kayıt güncellendi'
PRINT ''

-- ======================================
-- ADIM 2: Sonuçları Kontrol Et
-- ======================================
PRINT '==================== ADIM 2: SONUÇ KONTROLÜ ===================='

-- Hala bozuk karakterli firma var mı?
SELECT @BozukKayit = COUNT(*)
FROM tbFirma
WHERE 
    sAciklama LIKE '%{%}%'
    OR sAciklama LIKE '%Ã%'
    OR sAciklama LIKE '%Ä%'
    OR sAciklama LIKE '%Å%'

IF @BozukKayit = 0
BEGIN
    PRINT '✅ BAŞARILI! Tüm Türkçe karakterler düzeltildi!'
    PRINT ''
    
    -- Düzeltilen örnekleri göster
    PRINT 'Düzeltilen Firma Örnekleri (İlk 10):'
    SELECT TOP 10 
        nFirmaID,
        sKodu,
        sAciklama
    FROM tbFirma
    WHERE 
        sAciklama LIKE '%ğ%'
        OR sAciklama LIKE '%ı%'
        OR sAciklama LIKE '%ö%'
        OR sAciklama LIKE '%ü%'
        OR sAciklama LIKE '%ç%'
        OR sAciklama LIKE '%ş%'
        OR sAciklama LIKE '%İ%'
        OR sAciklama LIKE '%Ş%'
    ORDER BY nFirmaID DESC
END
ELSE
BEGIN
    PRINT '⚠️ UYARI! Hala ' + CAST(@BozukKayit AS VARCHAR(10)) + ' adet bozuk kayıt var!'
    PRINT ''
    PRINT 'Bozuk Kayıtlar:'
    SELECT TOP 20 
        nFirmaID,
        sKodu,
        sAciklama
    FROM tbFirma
    WHERE 
        sAciklama LIKE '%{%}%'
        OR sAciklama LIKE '%Ã%'
        OR sAciklama LIKE '%Ä%'
        OR sAciklama LIKE '%Å%'
END

PRINT ''
PRINT '==================== İŞLEM TAMAMLANDI ===================='
PRINT 'Bitiş Zamanı: ' + CONVERT(VARCHAR(20), GETDATE(), 120)

GO
