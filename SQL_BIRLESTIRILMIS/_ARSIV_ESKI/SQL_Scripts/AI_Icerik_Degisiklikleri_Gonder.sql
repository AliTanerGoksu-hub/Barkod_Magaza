-- =============================================
-- AI İçerik Değişikliklerini QUKA'ya Gönder
-- Tarih: 2026-01-25
-- Açıklama: tbStokUzunNot veya tbStokAIIcerik'te 
-- kayıt olan ürünleri products tablosuna ekler
-- Trigger kurulmadan önce yapılan değişiklikler için
-- =============================================

-- =============================================
-- BÖLÜM 1: tbStokUzunNot'tan (Ana İçerik)
-- =============================================
PRINT 'tbStokUzunNot kayıtları işleniyor...'

-- Yeni kayıt ekle (yoksa)
INSERT INTO products (productID, status, f_durum, updated_at, created_at)
SELECT DISTINCT
    RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID,
    0, 1, GETDATE(), GETDATE()
FROM tbStokUzunNot u
INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(u.sModel))
WHERE ISNULL(s.bWebGoruntule, 0) = 1
  AND s.sModel IS NOT NULL AND s.sModel <> ''
  AND (u.sUzunNot IS NOT NULL AND u.sUzunNot <> '')  -- İçerik olan kayıtlar
  AND NOT EXISTS (
      SELECT 1 FROM products p 
      WHERE p.productID = RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))
  )

PRINT 'Yeni ürünler eklendi: ' + CAST(@@ROWCOUNT AS VARCHAR(10))

-- Mevcut kayıtları güncelle - status=0 (gönderilmeli)
UPDATE p SET p.status = 0, p.updated_at = GETDATE()
FROM products p
INNER JOIN (
    SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
    FROM tbStokUzunNot u
    INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(u.sModel))
    WHERE ISNULL(s.bWebGoruntule, 0) = 1 
      AND s.sModel IS NOT NULL AND s.sModel <> ''
      AND (u.sUzunNot IS NOT NULL AND u.sUzunNot <> '')
) AS c ON p.productID = c.productID
WHERE p.status <> 0  -- Sadece henüz işaretlenmemişleri güncelle

PRINT 'Mevcut ürünler güncellendi (tbStokUzunNot): ' + CAST(@@ROWCOUNT AS VARCHAR(10))
GO

-- =============================================
-- BÖLÜM 2: tbStokAIIcerik'ten (SEO İçerik)
-- =============================================
PRINT ''
PRINT 'tbStokAIIcerik kayıtları işleniyor...'

-- Yeni kayıt ekle (yoksa)
INSERT INTO products (productID, status, f_durum, updated_at, created_at)
SELECT DISTINCT
    RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID,
    0, 1, GETDATE(), GETDATE()
FROM tbStokAIIcerik ai
INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(ai.sModel))
WHERE ISNULL(s.bWebGoruntule, 0) = 1
  AND s.sModel IS NOT NULL AND s.sModel <> ''
  AND NOT EXISTS (
      SELECT 1 FROM products p 
      WHERE p.productID = RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))
  )

PRINT 'Yeni ürünler eklendi: ' + CAST(@@ROWCOUNT AS VARCHAR(10))

-- Mevcut kayıtları güncelle
UPDATE p SET p.status = 0, p.updated_at = GETDATE()
FROM products p
INNER JOIN (
    SELECT DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, ''))) AS productID
    FROM tbStokAIIcerik ai
    INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(ai.sModel))
    WHERE ISNULL(s.bWebGoruntule, 0) = 1 
      AND s.sModel IS NOT NULL AND s.sModel <> ''
) AS c ON p.productID = c.productID
WHERE p.status <> 0

PRINT 'Mevcut ürünler güncellendi (tbStokAIIcerik): ' + CAST(@@ROWCOUNT AS VARCHAR(10))
GO

-- =============================================
-- BÖLÜM 3: SONUÇ RAPORU
-- =============================================
PRINT ''
PRINT '============================================='
PRINT 'AI İÇERİK DEĞİŞİKLİKLERİ İŞARETLENDİ!'
PRINT '============================================='
PRINT ''

SELECT 
    'Toplam gönderilecek ürün' AS Durum,
    COUNT(*) AS Adet
FROM products 
WHERE status = 0

SELECT 
    'AI içerikli ürün (tbStokUzunNot)' AS Kaynak,
    COUNT(DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))) AS Adet
FROM tbStokUzunNot u
INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(u.sModel))
WHERE ISNULL(s.bWebGoruntule, 0) = 1
  AND (u.sUzunNot IS NOT NULL AND u.sUzunNot <> '')

UNION ALL

SELECT 
    'SEO içerikli ürün (tbStokAIIcerik)' AS Kaynak,
    COUNT(DISTINCT RTRIM(LTRIM(s.sModel)) + '__' + RTRIM(LTRIM(ISNULL(s.sRenk, '')))) AS Adet
FROM tbStokAIIcerik ai
INNER JOIN tbStok s ON RTRIM(LTRIM(s.sModel)) = RTRIM(LTRIM(ai.sModel))
WHERE ISNULL(s.bWebGoruntule, 0) = 1

PRINT ''
PRINT 'Artık "Değişen Ürünleri Gönder" seçeneği ile'
PRINT 'bu ürünler QUKA''ya gönderilecek.'
PRINT '============================================='
GO
