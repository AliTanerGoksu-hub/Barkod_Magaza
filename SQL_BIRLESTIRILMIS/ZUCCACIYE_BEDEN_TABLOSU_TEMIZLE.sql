-- ================================================================
-- ZÜCCACİYE ÜRÜNLERİNİN BEDEN TABLOSU TEMİZLEME
-- ================================================================
-- Bu script, züccaciye/mutfak ürünlerinin yanlışlıkla 
-- oluşturulmuş beden tablosu alanlarını temizler.
-- 
-- Çalıştırmadan önce: Yedek alın!
-- ================================================================

-- 1. Ürün adında züccaciye kelimeleri olanları tespit et
SELECT DISTINCT s.sModel, s.sAciklama
FROM tbStok s
INNER JOIN tbStokUzunNot u ON s.sModel = u.sModel
WHERE u.sBedenTablosu IS NOT NULL 
  AND u.sBedenTablosu <> ''
  AND (
    LOWER(s.sAciklama) LIKE '%cam%'
    OR LOWER(s.sAciklama) LIKE '%bardak%'
    OR LOWER(s.sAciklama) LIKE '%tabak%'
    OR LOWER(s.sAciklama) LIKE '%fincan%'
    OR LOWER(s.sAciklama) LIKE '%tencere%'
    OR LOWER(s.sAciklama) LIKE '%tava%'
    OR LOWER(s.sAciklama) LIKE '%saklama kabı%'
    OR LOWER(s.sAciklama) LIKE '%kavanoz%'
    OR LOWER(s.sAciklama) LIKE '%glasslock%'
    OR LOWER(s.sAciklama) LIKE '%tupperware%'
    OR LOWER(s.sAciklama) LIKE '%korkmaz%'
    OR LOWER(s.sAciklama) LIKE '%paşabahçe%'
    OR LOWER(s.sAciklama) LIKE '%pasabahce%'
    OR LOWER(s.sAciklama) LIKE '%kütahya%'
    OR LOWER(s.sAciklama) LIKE '%porland%'
    OR LOWER(s.sAciklama) LIKE '%kase%'
    OR LOWER(s.sAciklama) LIKE '%tepsi%'
    OR LOWER(s.sAciklama) LIKE '%çaydanlık%'
    OR LOWER(s.sAciklama) LIKE '%demlik%'
    OR LOWER(s.sAciklama) LIKE '%cezve%'
  )
ORDER BY s.sModel;

-- 2. Züccaciye ürünlerinin beden tablosunu temizle (tbStokUzunNot)
UPDATE u
SET u.sBedenTablosu = NULL, 
    u.dteSonUpdateTarihi = GETDATE(),
    u.sSonKullaniciAdi = 'SISTEM_TEMIZLIK'
FROM tbStokUzunNot u
INNER JOIN tbStok s ON s.sModel = u.sModel
WHERE u.sBedenTablosu IS NOT NULL 
  AND u.sBedenTablosu <> ''
  AND (
    LOWER(s.sAciklama) LIKE '%cam%'
    OR LOWER(s.sAciklama) LIKE '%bardak%'
    OR LOWER(s.sAciklama) LIKE '%tabak%'
    OR LOWER(s.sAciklama) LIKE '%fincan%'
    OR LOWER(s.sAciklama) LIKE '%tencere%'
    OR LOWER(s.sAciklama) LIKE '%tava%'
    OR LOWER(s.sAciklama) LIKE '%saklama kabı%'
    OR LOWER(s.sAciklama) LIKE '%kavanoz%'
    OR LOWER(s.sAciklama) LIKE '%glasslock%'
    OR LOWER(s.sAciklama) LIKE '%tupperware%'
    OR LOWER(s.sAciklama) LIKE '%korkmaz%'
    OR LOWER(s.sAciklama) LIKE '%paşabahçe%'
    OR LOWER(s.sAciklama) LIKE '%pasabahce%'
    OR LOWER(s.sAciklama) LIKE '%kütahya%'
    OR LOWER(s.sAciklama) LIKE '%porland%'
    OR LOWER(s.sAciklama) LIKE '%kase%'
    OR LOWER(s.sAciklama) LIKE '%tepsi%'
    OR LOWER(s.sAciklama) LIKE '%çaydanlık%'
    OR LOWER(s.sAciklama) LIKE '%demlik%'
    OR LOWER(s.sAciklama) LIKE '%cezve%'
  );

-- 3. Züccaciye ürünlerinin beden tablosunu temizle (tbStokAIIcerik - varsa)
UPDATE ai
SET ai.sBedenTablosu = NULL
FROM tbStokAIIcerik ai
INNER JOIN tbStok s ON s.sModel = ai.sModel
WHERE ai.sBedenTablosu IS NOT NULL 
  AND ai.sBedenTablosu <> ''
  AND (
    LOWER(s.sAciklama) LIKE '%cam%'
    OR LOWER(s.sAciklama) LIKE '%bardak%'
    OR LOWER(s.sAciklama) LIKE '%tabak%'
    OR LOWER(s.sAciklama) LIKE '%fincan%'
    OR LOWER(s.sAciklama) LIKE '%tencere%'
    OR LOWER(s.sAciklama) LIKE '%tava%'
    OR LOWER(s.sAciklama) LIKE '%saklama kabı%'
    OR LOWER(s.sAciklama) LIKE '%kavanoz%'
    OR LOWER(s.sAciklama) LIKE '%glasslock%'
    OR LOWER(s.sAciklama) LIKE '%tupperware%'
    OR LOWER(s.sAciklama) LIKE '%korkmaz%'
    OR LOWER(s.sAciklama) LIKE '%paşabahçe%'
    OR LOWER(s.sAciklama) LIKE '%pasabahce%'
    OR LOWER(s.sAciklama) LIKE '%kütahya%'
    OR LOWER(s.sAciklama) LIKE '%porland%'
    OR LOWER(s.sAciklama) LIKE '%kase%'
    OR LOWER(s.sAciklama) LIKE '%tepsi%'
    OR LOWER(s.sAciklama) LIKE '%çaydanlık%'
    OR LOWER(s.sAciklama) LIKE '%demlik%'
    OR LOWER(s.sAciklama) LIKE '%cezve%'
  );

PRINT 'Züccaciye ürünlerinin beden tablosu alanları temizlendi.';
