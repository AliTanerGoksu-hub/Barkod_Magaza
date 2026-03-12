-- =============================================
-- E-Ticaret Parametreleri Güncelleme Script
-- =============================================
-- Bu script iki işlemi yapar:
-- 1. tbParamGenel tablosuna DefaultImageUrl kolonu ekler
-- 2. tbParamETicaret tablosunu kontrol eder ve örnek veri ekler
-- =============================================

USE [Database]; -- Veritabanı adınızı buraya yazın
GO

-- =============================================
-- 1. VARSAYILAN RESİM URL PARAMETRESİ EKLE
-- =============================================
PRINT '1. tbParamGenel tablosuna DefaultImageUrl kolonu ekleniyor...'
GO

-- Kolon zaten varsa hata vermesin diye kontrol
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamGenel') AND name = 'DefaultImageUrl')
BEGIN
    ALTER TABLE tbParamGenel ADD DefaultImageUrl NVARCHAR(255) NULL;
    PRINT '   ✓ DefaultImageUrl kolonu eklendi.'
END
ELSE
BEGIN
    PRINT '   ⚠ DefaultImageUrl kolonu zaten mevcut.'
END
GO

PRINT ''
PRINT '⚠️  ÖNEMLİ: DefaultImageUrl kolonunu kendi resim URL''niz ile güncelleyin!'
PRINT '   Örnek: UPDATE tbParamGenel SET DefaultImageUrl = ''https://sizin-site.com/default.jpg'''
PRINT ''
GO

-- =============================================
-- 2. E-TİCARET MALİYET PARAMETRELERİNİ KONTROL ET
-- =============================================
PRINT ''
PRINT '2. tbParamETicaret tablosu kontrol ediliyor...'
GO

-- Tablo var mı kontrol et
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND type in (N'U'))
BEGIN
    PRINT '   ❌ HATA: tbParamETicaret tablosu bulunamadı!'
    PRINT '   Lütfen önce bu tabloyu oluşturun.'
END
ELSE
BEGIN
    -- Mevcut kayıtları göster
    PRINT '   Mevcut e-ticaret parametreleri:'
    SELECT 
        sSiparisNoOnek AS 'Sipariş Öneki',
        CASE WHEN bAktif = 1 THEN 'AKTİF' ELSE 'PASİF' END AS 'Durum',
        nKomisyonOrani AS 'Komisyon %',
        lKargoSabitBedel AS 'Kargo Bedeli'
    FROM tbParamETicaret;
    
    -- Eğer hiç kayıt yoksa örnek veri ekle
    IF NOT EXISTS (SELECT * FROM tbParamETicaret)
    BEGIN
        PRINT ''
        PRINT '   ⚠ Tabloda hiç kayıt yok. Örnek parametreler ekleniyor...'
        
        -- TRENDYOL
        INSERT INTO tbParamETicaret (
            sSiparisNoOnek, nKomisyonTipi, nKomisyonOrani, lKomisyonSabitTutar, 
            lKargoSabitBedel, nIadeOperasyonOrani, nPaketlemeOrani, 
            nOdemeIslemUcretiOrani, lOdemeIslemSabitUcret, lDigerMasraf1, lDigerMasraf2, bAktif
        ) VALUES (
            'ty(', 1, 15.00, 0.00, 
            8.00, 0.50, 1.00, 
            2.50, 0.50, 0.00, 0.00, 1
        );
        
        -- HEPSIBURADA
        INSERT INTO tbParamETicaret (
            sSiparisNoOnek, nKomisyonTipi, nKomisyonOrani, lKomisyonSabitTutar, 
            lKargoSabitBedel, nIadeOperasyonOrani, nPaketlemeOrani, 
            nOdemeIslemUcretiOrani, lOdemeIslemSabitUcret, lDigerMasraf1, lDigerMasraf2, bAktif
        ) VALUES (
            'Hb(', 1, 18.00, 0.00, 
            10.00, 0.75, 1.00, 
            2.80, 0.60, 0.00, 0.00, 1
        );
        
        -- N11
        INSERT INTO tbParamETicaret (
            sSiparisNoOnek, nKomisyonTipi, nKomisyonOrani, lKomisyonSabitTutar, 
            lKargoSabitBedel, nIadeOperasyonOrani, nPaketlemeOrani, 
            nOdemeIslemUcretiOrani, lOdemeIslemSabitUcret, lDigerMasraf1, lDigerMasraf2, bAktif
        ) VALUES (
            'n11', 1, 16.00, 0.00, 
            9.00, 0.60, 1.00, 
            2.60, 0.55, 0.00, 0.00, 1
        );
        
        -- AMAZON
        INSERT INTO tbParamETicaret (
            sSiparisNoOnek, nKomisyonTipi, nKomisyonOrani, lKomisyonSabitTutar, 
            lKargoSabitBedel, nIadeOperasyonOrani, nPaketlemeOrani, 
            nOdemeIslemUcretiOrani, lOdemeIslemSabitUcret, lDigerMasraf1, lDigerMasraf2, bAktif
        ) VALUES (
            'am(', 1, 20.00, 0.00, 
            12.00, 1.00, 1.50, 
            3.00, 0.70, 0.00, 0.00, 1
        );
        
        PRINT '   ✓ Örnek e-ticaret parametreleri eklendi (Trendyol, Hepsiburada, N11, Amazon)'
        PRINT ''
        PRINT '   📝 NOT: Bu değerler ÖRNEKTIR. Lütfen kendi anlaşmalarınıza göre güncelleyin!'
    END
    ELSE
    BEGIN
        PRINT ''
        PRINT '   ✓ tbParamETicaret tablosunda kayıtlar mevcut.'
        PRINT '   📝 Eğer maliyet hesaplama çalışmıyorsa:'
        PRINT '      1. bAktif alanının 1 (aktif) olduğunu kontrol edin'
        PRINT '      2. sSiparisNoOnek değerlerinin doğru olduğunu kontrol edin'
        PRINT '         (ty(, Hb(, n11, am(, gg(, cs(, ky(, pt(, mh()'
    END
END
GO

-- =============================================
-- 3. KONTROLLERİ GÖSTER
-- =============================================
PRINT ''
PRINT '=================================='
PRINT 'GÜNCELLENMİŞ PARAMETRELERİ KONTROL'
PRINT '=================================='
GO

-- tbParamGenel'deki güncel değerler
PRINT 'tbParamGenel Parametreleri:'
SELECT 
    ApiKey AS 'API Key',
    ApiSecret AS 'API Secret',
    ProductSave AS 'API Base URL',
    DefaultImageUrl AS 'Varsayılan Resim URL'
FROM tbParamGenel;
GO

-- tbParamETicaret'deki güncel değerler
PRINT ''
PRINT 'tbParamETicaret Parametreleri (Aktif Olanlar):'
SELECT 
    sSiparisNoOnek AS 'Platform',
    nKomisyonOrani AS 'Komisyon %',
    lKargoSabitBedel AS 'Kargo ₺',
    nIadeOperasyonOrani AS 'İade Op %',
    nPaketlemeOrani AS 'Paketleme %',
    CASE WHEN bAktif = 1 THEN '✓ AKTİF' ELSE '✗ PASİF' END AS 'Durum'
FROM tbParamETicaret
ORDER BY bAktif DESC, sSiparisNoOnek;
GO

PRINT ''
PRINT '✅ Güncelleme scripti tamamlandı!'
PRINT ''
PRINT '⚠️  ÖNEMLİ NOTLAR:'
PRINT '1. *** MUTLAKA *** DefaultImageUrl değerini kendi resim URL''nize göre güncelleyin:'
PRINT '   UPDATE tbParamGenel SET DefaultImageUrl = ''https://sizin-site.com/default-image.jpg'''
PRINT ''
PRINT '2. E-ticaret platform parametrelerini kendi anlaşmalarınıza göre düzenleyin'
PRINT '3. Uygulamayı yeniden derleyin ve test edin'
GO
