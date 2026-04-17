-- ================================================
-- BARKOD MAGAZA - BOSLUK TEMIZLEME SCRIPTI
-- Tum char/varchar alanlardaki gereksiz bosluklari temizler
-- Tarih: 2026-04-17
-- ================================================

-- ONCE TRANSACTION BASLA (geri alinabilir)
BEGIN TRANSACTION

-- ================================================
-- 1. tbStok TEMIZLEME
-- ================================================
PRINT '>>> tbStok temizleniyor...'

UPDATE tbStok SET 
    sKodu = RTRIM(LTRIM(sKodu)), 
    sRenk = RTRIM(LTRIM(sRenk)), 
    sBeden = RTRIM(LTRIM(sBeden)),
    sKavala = RTRIM(LTRIM(sKavala))
WHERE sKodu <> RTRIM(LTRIM(sKodu)) 
   OR sRenk <> RTRIM(LTRIM(sRenk))
   OR sBeden <> RTRIM(LTRIM(sBeden))
   OR sKavala <> RTRIM(LTRIM(sKavala))

PRINT '   tbStok etkilenen satir: ' + CAST(@@ROWCOUNT AS VARCHAR)

-- ================================================
-- 2. tbRenk TEMIZLEME
-- ================================================
PRINT '>>> tbRenk temizleniyor...'

UPDATE tbRenk SET 
    sRenk = RTRIM(LTRIM(sRenk)),
    sRenkAdi = RTRIM(LTRIM(sRenkAdi)),
    lRenkNo = RTRIM(LTRIM(lRenkNo))
WHERE sRenk <> RTRIM(LTRIM(sRenk))
   OR sRenkAdi <> RTRIM(LTRIM(sRenkAdi))
   OR lRenkNo <> RTRIM(LTRIM(lRenkNo))

PRINT '   tbRenk etkilenen satir: ' + CAST(@@ROWCOUNT AS VARCHAR)

-- ================================================
-- 3. tbBeden TEMIZLEME (sBeden1 - sBeden15)
-- ================================================
PRINT '>>> tbBeden temizleniyor...'

UPDATE tbBeden SET 
    sBeden1 = RTRIM(LTRIM(sBeden1)),
    sBeden2 = RTRIM(LTRIM(sBeden2)),
    sBeden3 = RTRIM(LTRIM(sBeden3)),
    sBeden4 = RTRIM(LTRIM(sBeden4)),
    sBeden5 = RTRIM(LTRIM(sBeden5)),
    sBeden6 = RTRIM(LTRIM(sBeden6)),
    sBeden7 = RTRIM(LTRIM(sBeden7)),
    sBeden8 = RTRIM(LTRIM(sBeden8)),
    sBeden9 = RTRIM(LTRIM(sBeden9)),
    sBeden10 = RTRIM(LTRIM(sBeden10)),
    sBeden11 = RTRIM(LTRIM(sBeden11)),
    sBeden12 = RTRIM(LTRIM(sBeden12)),
    sBeden13 = RTRIM(LTRIM(sBeden13)),
    sBeden14 = RTRIM(LTRIM(sBeden14)),
    sBeden15 = RTRIM(LTRIM(sBeden15))
WHERE sBeden1 <> RTRIM(LTRIM(sBeden1))
   OR sBeden2 <> RTRIM(LTRIM(sBeden2))
   OR sBeden3 <> RTRIM(LTRIM(sBeden3))
   OR sBeden4 <> RTRIM(LTRIM(sBeden4))
   OR sBeden5 <> RTRIM(LTRIM(sBeden5))
   OR sBeden6 <> RTRIM(LTRIM(sBeden6))
   OR sBeden7 <> RTRIM(LTRIM(sBeden7))
   OR sBeden8 <> RTRIM(LTRIM(sBeden8))
   OR sBeden9 <> RTRIM(LTRIM(sBeden9))
   OR sBeden10 <> RTRIM(LTRIM(sBeden10))
   OR sBeden11 <> RTRIM(LTRIM(sBeden11))
   OR sBeden12 <> RTRIM(LTRIM(sBeden12))
   OR sBeden13 <> RTRIM(LTRIM(sBeden13))
   OR sBeden14 <> RTRIM(LTRIM(sBeden14))
   OR sBeden15 <> RTRIM(LTRIM(sBeden15))

PRINT '   tbBeden etkilenen satir: ' + CAST(@@ROWCOUNT AS VARCHAR)

-- ================================================
-- SONUC KONTROL
-- ================================================
PRINT ''
PRINT '>>> Kontrol: Kalan bosluklu kayitlar'

SELECT 'tbStok' AS Tablo, COUNT(*) AS BoslukluKayit FROM tbStok
WHERE sKodu <> RTRIM(LTRIM(sKodu)) OR sRenk <> RTRIM(LTRIM(sRenk)) 
   OR sBeden <> RTRIM(LTRIM(sBeden)) OR sKavala <> RTRIM(LTRIM(sKavala))
UNION ALL
SELECT 'tbRenk', COUNT(*) FROM tbRenk
WHERE sRenk <> RTRIM(LTRIM(sRenk)) OR lRenkNo <> RTRIM(LTRIM(lRenkNo))
UNION ALL
SELECT 'tbBeden', COUNT(*) FROM tbBeden
WHERE sBeden1 <> RTRIM(LTRIM(sBeden1)) OR sBeden2 <> RTRIM(LTRIM(sBeden2))
   OR sBeden3 <> RTRIM(LTRIM(sBeden3)) OR sBeden4 <> RTRIM(LTRIM(sBeden4))
   OR sBeden5 <> RTRIM(LTRIM(sBeden5))

-- Her sey dogruysa COMMIT, degilse ROLLBACK
-- COMMIT TRANSACTION
-- ROLLBACK TRANSACTION

PRINT ''
PRINT '>>> ISLEM TAMAMLANDI'
PRINT '>>> Sonuclari kontrol edip COMMIT TRANSACTION veya ROLLBACK TRANSACTION calistirin'
