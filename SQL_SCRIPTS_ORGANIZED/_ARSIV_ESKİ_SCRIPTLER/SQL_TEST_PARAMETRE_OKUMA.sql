-- =============================================
-- E-Ticaret Parametre Okuma Test Script
-- =============================================
-- Bu script mevcut parametreleri kontrol eder
-- =============================================

USE [Database]; -- Veritabanı adınızı buraya yazın
GO

PRINT '=================================='
PRINT 'PARAMETRE OKUMA TEST'
PRINT '=================================='
PRINT ''

-- =============================================
-- 1. tbParamGenel Kontrolü
-- =============================================
PRINT '1. tbParamGenel Parametreleri:'
PRINT '=================================='
GO

SELECT 
    ApiKey AS 'API Key',
    ApiSecret AS 'API Secret',
    ProductSave AS 'API Base URL',
    ISNULL(DefaultImageUrl, '*** TANIM YOK ***') AS 'Varsayılan Resim URL'
FROM tbParamGenel WITH (NOLOCK);
GO

-- =============================================
-- 2. tbParamETicaret Kontrolü (Tüm Kayıtlar)
-- =============================================
PRINT ''
PRINT '2. E-Ticaret Parametreleri (TÜM KAYITLAR):'
PRINT '=================================='
GO

SELECT 
    sSiparisNoOnek AS 'Platform Öneki',
    CASE 
        WHEN nKomisyonTipi = 1 THEN 'Yüzde Bazlı'
        ELSE 'Sabit Tutar'
    END AS 'Komisyon Tipi',
    nKomisyonOrani AS 'Komisyon %',
    lKomisyonSabitTutar AS 'Sabit Komisyon ₺',
    lKargoSabitBedel AS 'Kargo ₺',
    nIadeOperasyonOrani AS 'İade Op %',
    nPaketlemeOrani AS 'Paketleme %',
    nOdemeIslemUcretiOrani AS 'Ödeme Ücret %',
    lOdemeIslemSabitUcret AS 'Ödeme Sabit ₺',
    lDigerMasraf1 AS 'Diğer Masraf 1',
    lDigerMasraf2 AS 'Diğer Masraf 2',
    CASE 
        WHEN bAktif = 1 THEN '✓ AKTİF'
        ELSE '✗ PASİF'
    END AS 'Durum'
FROM tbParamETicaret WITH (NOLOCK)
ORDER BY bAktif DESC, sSiparisNoOnek;
GO

-- =============================================
-- 3. Sadece Aktif Parametreler
-- =============================================
PRINT ''
PRINT '3. E-Ticaret Parametreleri (SADECE AKTİF):'
PRINT '=================================='
GO

SELECT 
    sSiparisNoOnek AS 'Platform',
    nKomisyonOrani AS 'Komisyon %',
    lKargoSabitBedel AS 'Kargo ₺',
    nIadeOperasyonOrani + nPaketlemeOrani AS 'Toplam Operasyon %'
FROM tbParamETicaret WITH (NOLOCK)
WHERE bAktif = 1
ORDER BY sSiparisNoOnek;
GO

-- =============================================
-- 4. Örnek Maliyet Hesaplama
-- =============================================
PRINT ''
PRINT '4. Örnek Maliyet Hesaplama (100₺ Sipariş için):'
PRINT '=================================='
GO

DECLARE @toplamSatis DECIMAL(18,2) = 100.00;

SELECT 
    sSiparisNoOnek AS 'Platform',
    
    -- Komisyon Hesabı
    CASE 
        WHEN nKomisyonTipi = 1 
        THEN (@toplamSatis * nKomisyonOrani / 100)
        ELSE lKomisyonSabitTutar
    END AS 'Komisyon ₺',
    
    -- Kargo
    lKargoSabitBedel AS 'Kargo ₺',
    
    -- İade Operasyon
    (@toplamSatis * nIadeOperasyonOrani / 100) AS 'İade Op ₺',
    
    -- Paketleme
    (@toplamSatis * nPaketlemeOrani / 100) AS 'Paketleme ₺',
    
    -- Ödeme İşlem
    (lOdemeIslemSabitUcret + (@toplamSatis * nOdemeIslemUcretiOrani / 100)) AS 'Ödeme İşlem ₺',
    
    -- Diğer Masraflar
    (lDigerMasraf1 + lDigerMasraf2) AS 'Diğer ₺',
    
    -- TOPLAM EK MALİYET
    CASE 
        WHEN nKomisyonTipi = 1 
        THEN (@toplamSatis * nKomisyonOrani / 100)
        ELSE lKomisyonSabitTutar
    END 
    + lKargoSabitBedel 
    + (@toplamSatis * nIadeOperasyonOrani / 100)
    + (@toplamSatis * nPaketlemeOrani / 100)
    + (lOdemeIslemSabitUcret + (@toplamSatis * nOdemeIslemUcretiOrani / 100))
    + lDigerMasraf1
    + lDigerMasraf2
    AS 'TOPLAM EK MALİYET ₺',
    
    -- NET KÂR
    @toplamSatis - (
        CASE 
            WHEN nKomisyonTipi = 1 
            THEN (@toplamSatis * nKomisyonOrani / 100)
            ELSE lKomisyonSabitTutar
        END 
        + lKargoSabitBedel 
        + (@toplamSatis * nIadeOperasyonOrani / 100)
        + (@toplamSatis * nPaketlemeOrani / 100)
        + (lOdemeIslemSabitUcret + (@toplamSatis * nOdemeIslemUcretiOrani / 100))
        + lDigerMasraf1
        + lDigerMasraf2
    ) AS 'NET KÂR ₺'
    
FROM tbParamETicaret WITH (NOLOCK)
WHERE bAktif = 1
ORDER BY sSiparisNoOnek;
GO

-- =============================================
-- 5. Platform Eşleşme Kontrolü
-- =============================================
PRINT ''
PRINT '5. Sipariş Öneki Eşleşme Kontrolü:'
PRINT '=================================='
PRINT 'Uygulamada desteklenen önekler: ty(, Hb(, n11, am(, gg(, cs(, ky(, pt(, mh('
PRINT ''
GO

-- Hangi önekler tanımlı?
SELECT 
    CASE sSiparisNoOnek
        WHEN 'ty(' THEN '✓ Trendyol (ty()'
        WHEN 'Hb(' THEN '✓ Hepsiburada (Hb()'
        WHEN 'n11' THEN '✓ N11 (n11)'
        WHEN 'am(' THEN '✓ Amazon (am()'
        WHEN 'gg(' THEN '✓ GittiGidiyor (gg()'
        WHEN 'cs(' THEN '✓ Ciceksepeti (cs()'
        WHEN 'ky(' THEN '✓ Kolay (ky()'
        WHEN 'pt(' THEN '✓ Pttavm (pt()'
        WHEN 'mh(' THEN '✓ Morhipo (mh()'
        ELSE '⚠ DİĞER: ' + sSiparisNoOnek
    END AS 'Platform',
    CASE WHEN bAktif = 1 THEN 'AKTİF' ELSE 'PASİF' END AS 'Durum'
FROM tbParamETicaret WITH (NOLOCK)
ORDER BY bAktif DESC, sSiparisNoOnek;
GO

-- =============================================
-- 6. Eksik Platform Kontrolü
-- =============================================
PRINT ''
PRINT '6. Eksik Platform Kontrolü:'
PRINT '=================================='
GO

-- Hangi platformlar eksik?
IF NOT EXISTS (SELECT * FROM tbParamETicaret WHERE sSiparisNoOnek = 'ty(')
    PRINT '⚠ Trendyol (ty() parametresi EKSİK!'
ELSE
    PRINT '✓ Trendyol (ty() tanımlı'

IF NOT EXISTS (SELECT * FROM tbParamETicaret WHERE sSiparisNoOnek = 'Hb(')
    PRINT '⚠ Hepsiburada (Hb() parametresi EKSİK!'
ELSE
    PRINT '✓ Hepsiburada (Hb() tanımlı'

IF NOT EXISTS (SELECT * FROM tbParamETicaret WHERE sSiparisNoOnek = 'n11')
    PRINT '⚠ N11 (n11) parametresi EKSİK!'
ELSE
    PRINT '✓ N11 (n11) tanımlı'

IF NOT EXISTS (SELECT * FROM tbParamETicaret WHERE sSiparisNoOnek = 'am(')
    PRINT '⚠ Amazon (am() parametresi EKSİK!'
ELSE
    PRINT '✓ Amazon (am() tanımlı'

GO

PRINT ''
PRINT '=================================='
PRINT '✅ Test tamamlandı!'
PRINT '=================================='
GO
