-- =============================================
-- DEBUG: Ürün Verisi Kontrolü
-- =============================================
-- Belirli bir model için tüm verileri kontrol et
-- =============================================

USE [Database]; -- Veritabanı adınızı buraya yazın
GO

-- Model kodunu buraya gir
DECLARE @sModel NVARCHAR(50) = 'ABC123' -- ÖRN: Kendi model kodunuzu yazın

PRINT '========================================='
PRINT 'ÜRÜN VERİ KONTROLÜ'
PRINT '========================================='
PRINT 'Model: ' + @sModel
PRINT ''

-- 1. tbStok kontrolü
PRINT '1. tbStok - Temel Ürün Bilgileri:'
SELECT 
    nStokID AS 'Stok ID',
    sModel AS 'Model',
    sAciklama AS 'Açıklama',
    sKisaAdi AS 'Kısa Adı',
    bWebGoruntule AS 'Web Göster',
    bAIIcerikVar AS 'AI İçerik Var mı'
FROM tbStok WITH (NOLOCK)
WHERE sModel = @sModel;
GO

-- 2. tbStokAIIcerik kontrolü
PRINT ''
PRINT '2. tbStokAIIcerik - AI İçerikleri:'
SELECT 
    sModel AS 'Model',
    CASE 
        WHEN sSEOBaslik IS NOT NULL AND sSEOBaslik <> '' THEN '✓ VAR'
        ELSE '✗ YOK'
    END AS 'SEO Başlık',
    CASE 
        WHEN sMetaDescription IS NOT NULL AND sMetaDescription <> '' THEN '✓ VAR'
        ELSE '✗ YOK'
    END AS 'Meta Açıklama',
    CASE 
        WHEN sKullanimTalimati IS NOT NULL AND sKullanimTalimati <> '' THEN '✓ VAR'
        ELSE '✗ YOK'
    END AS 'Kullanım Talimatı',
    LEFT(sSEOBaslik, 50) AS 'SEO Başlık (İlk 50 kar)',
    LEFT(sMetaDescription, 50) AS 'Meta Açıklama (İlk 50 kar)'
FROM tbStokAIIcerik WITH (NOLOCK)
WHERE sModel = @sModel;

-- Eğer kayıt yoksa bildir
IF NOT EXISTS (SELECT * FROM tbStokAIIcerik WHERE sModel = @sModel)
BEGIN
    PRINT '⚠️ BU MODEL İÇİN AI İÇERİK YOK!'
    PRINT 'Stok kart formunda AI butonlarını kullanarak içerik oluşturun.'
END
GO

-- 3. tbStokSinifi kontrolü
PRINT ''
PRINT '3. tbStokSinifi - Kategoriler ve Etiketler:'
SELECT 
    sModel AS 'Model',
    (SELECT sAciklama FROM tbSSinif3 WHERE sSinifKodu = sSinifKodu3) AS 'Marka (Tip 3)',
    (SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu = sSinifKodu4) AS 'Ana Kat (Tip 4)',
    (SELECT sAciklama FROM tbSSinif5 WHERE sSinifKodu = sSinifKodu5) AS 'Alt Kat1 (Tip 5)',
    (SELECT sAciklama FROM tbSSinif6 WHERE sSinifKodu = sSinifKodu6) AS 'Alt Kat2 (Tip 6)',
    (SELECT sAciklama FROM tbSSinif7 WHERE sSinifKodu = sSinifKodu7) AS 'Etiket 1 (Tip 7)',
    (SELECT sAciklama FROM tbSSinif8 WHERE sSinifKodu = sSinifKodu8) AS 'Etiket 2 (Tip 8)',
    (SELECT sAciklama FROM tbSSinif9 WHERE sSinifKodu = sSinifKodu9) AS 'Etiket 3 (Tip 9)',
    (SELECT sAciklama FROM tbSSinif10 WHERE sSinifKodu = sSinifKodu10) AS 'Etiket 4 (Tip 10)',
    (SELECT sAciklama FROM tbSSinif11 WHERE sSinifKodu = sSinifKodu11) AS 'Etiket 5 (Tip 11)',
    (SELECT sAciklama FROM tbSSinif12 WHERE sSinifKodu = sSinifKodu12) AS 'Etiket 6 (Tip 12)',
    (SELECT sAciklama FROM tbSSinif13 WHERE sSinifKodu = sSinifKodu13) AS 'Etiket 7 (Tip 13)'
FROM tbStokSinifi WITH (NOLOCK)
WHERE sModel = @sModel;

-- Eğer kayıt yoksa bildir
IF NOT EXISTS (SELECT * FROM tbStokSinifi WHERE sModel = @sModel)
BEGIN
    PRINT '⚠️ BU MODEL İÇİN SINIF BİLGİSİ YOK!'
    PRINT 'Stok kart formunda AI Kategori Öner butonunu kullanın.'
END
GO

PRINT ''
PRINT '========================================='
PRINT 'KONTROL TAMAMLANDI'
PRINT '========================================='
PRINT ''
PRINT '📝 SONUÇ:'
PRINT '- Eğer AI İçerik YOK: Stok kart formunda AI butonlarını kullanın'
PRINT '- Eğer Sınıf Bilgisi YOK: AI Kategori Öner butonunu kullanın'
PRINT '- Tüm veriler VAR ama e-ticarette yok: Log dosyalarını kontrol edin'
GO
