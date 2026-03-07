-- ============================================================================
-- TRİGGER SİSTEMİ TEST SCRİPT'İ
-- ============================================================================
-- Tarih: 2025-01-28
-- Açıklama: Web senkronizasyon trigger'larının doğru çalışıp çalışmadığını
--           test etmek için kullanılır
-- ============================================================================

USE FURKAN2026
GO

PRINT '============================================'
PRINT 'Trigger Sistemi Test Başlıyor'
PRINT '============================================'
PRINT ''
GO

-- ============================================================================
-- 1. TRİGGER'LARIN VAR OLDUĞUNU KONTROL ET
-- ============================================================================

PRINT '1. Trigger Varlık Kontrolü:'
PRINT '----------------------------'

SELECT 
    t.name AS trigger_adi,
    OBJECT_NAME(t.parent_id) AS tablo_adi,
    CASE WHEN t.is_disabled = 0 THEN 'AKTIF' ELSE 'DEVRE DIŞI' END AS durum,
    t.create_date AS olusturma_tarihi
FROM sys.triggers t
WHERE t.name IN (
    'trg_StokFisiDetayi_WebSync',
    'trg_StokFiyati_WebSync',
    'trg_StokResim_WebSync',
    'trg_StokUzunNot_WebSync',
    'trg_StokAIIcerik_WebSync',
    'trg_StokUpdate'
)
ORDER BY t.name
GO

-- ============================================================================
-- 2. PRODUCTS TABLOSU YAPISINI KONTROL ET
-- ============================================================================

PRINT ''
PRINT '2. Products Tablosu Yapı Kontrolü:'
PRINT '-----------------------------------'

SELECT 
    COLUMN_NAME as alan_adi,
    DATA_TYPE as veri_tipi,
    IS_NULLABLE as null_olabilir
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Products'
ORDER BY ORDINAL_POSITION
GO

-- ============================================================================
-- 3. BEKLEYEN DEĞİŞİKLİK SAYILARINI KONTROL ET
-- ============================================================================

PRINT ''
PRINT '3. Bekleyen Değişiklik Sayıları:'
PRINT '---------------------------------'

DECLARE @stokBekleyen INT, @fiyatBekleyen INT, @resimBekleyen INT

SELECT @stokBekleyen = COUNT(*) FROM Products WHERE status = 0
SELECT @fiyatBekleyen = COUNT(*) FROM Products WHERE f_durum = 0
SELECT @resimBekleyen = COUNT(*) FROM product_images WHERE status = 0

PRINT 'Stok değişikliği bekleyen (products.status=0): ' + CAST(@stokBekleyen AS VARCHAR(10))
PRINT 'Fiyat değişikliği bekleyen (products.f_durum=0): ' + CAST(@fiyatBekleyen AS VARCHAR(10))
PRINT 'Resim değişikliği bekleyen (product_images.status=0): ' + CAST(@resimBekleyen AS VARCHAR(10))
GO

-- ============================================================================
-- 4. TEST: STOK HAREKETİ SİMÜLASYONU (SADECE SELECT - DEĞİŞİKLİK YAPMAZ)
-- ============================================================================

PRINT ''
PRINT '4. Örnek Stok Hareketi (son 5 işlem):'
PRINT '--------------------------------------'

SELECT TOP 5
    sfd.nIslemID,
    sfd.nStokID,
    s.sModel,
    s.sRenk,
    sfd.lGirisMiktar1 as giris,
    sfd.lCikisMiktar1 as cikis,
    sfd.dteIslemTarihi
FROM tbStokFisiDetayi sfd
INNER JOIN tbStok s ON sfd.nStokID = s.nStokID
ORDER BY sfd.dteIslemTarihi DESC
GO

-- ============================================================================
-- 5. PRODUCTS TABLOSUNDA SON GÜNCELLENEN KAYITLAR
-- ============================================================================

PRINT ''
PRINT '5. Products Tablosu Son Güncellenen (Top 10):'
PRINT '----------------------------------------------'

SELECT TOP 10
    productID,
    status as stok_durum,
    f_durum as fiyat_durum,
    updated_at
FROM Products
ORDER BY updated_at DESC
GO

-- ============================================================================
-- 6. MANUEL TEST TALİMATLARI
-- ============================================================================

PRINT ''
PRINT '============================================'
PRINT 'MANUEL TEST TALİMATLARI'
PRINT '============================================'
PRINT ''
PRINT 'Stok Trigger Testi:'
PRINT '  1. Programda bir ürüne stok girişi yap'
PRINT '  2. Şu sorguyu çalıştır:'
PRINT '     SELECT * FROM Products WHERE status = 0 ORDER BY updated_at DESC'
PRINT '  3. Az önce stok girdiğin ürün listede olmalı'
PRINT ''
PRINT 'Fiyat Trigger Testi:'
PRINT '  1. Programda bir ürünün fiyatını değiştir'
PRINT '  2. Şu sorguyu çalıştır:'
PRINT '     SELECT * FROM Products WHERE f_durum = 0 ORDER BY updated_at DESC'
PRINT '  3. Az önce fiyat değiştirdiğin ürün listede olmalı'
PRINT ''
PRINT 'AI İçerik Trigger Testi:'
PRINT '  1. AI Ürün İşleme formundan bir ürüne içerik oluştur'
PRINT '  2. Şu sorguyu çalıştır:'
PRINT '     SELECT * FROM Products WHERE status = 0 ORDER BY updated_at DESC'
PRINT '  3. AI içerik oluşturduğun model listede olmalı'
GO
