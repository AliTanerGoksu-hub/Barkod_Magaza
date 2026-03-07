-- =====================================================================
-- BARKOD MAGAZA - KURULUM KONTROL SCRIPT
-- =====================================================================
-- Versiyon: 1.0
-- Tarih: Ocak 2025
-- Açıklama: Kurulumu doğrular (READ-ONLY - veri değiştirmez)
-- =====================================================================

USE [VERITABANI_ADINIZ]
GO

PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     KURULUM KONTROL RAPORU                                   ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''

-- =====================================================================
-- 1. TABLO KONTROLLERI
-- =====================================================================
PRINT '▶ 1. TABLO KONTROLLERİ'
PRINT '─────────────────────────────────────────────────────────────────'
GO

DECLARE @TabloAdi NVARCHAR(100)
DECLARE @Durum NVARCHAR(20)

-- Kontrol edilecek tablolar
DECLARE @Tablolar TABLE (TabloAdi NVARCHAR(100))
INSERT INTO @Tablolar VALUES 
    ('tbParamETicaret'), ('tbStokAIIcerik'), ('tbStokResim'),
    ('tbAuditLog'), ('tbAuditIslemTipleri'), ('tbAuditModuller'),
    ('tbBildirimTipleri'), ('tbBildirimLog'), ('tbSistemAyar'),
    ('tbOnayTurleri'), ('tbOnayYetkilisi'),
    ('products'), ('product_images'), ('tbWebGuncel')

SELECT 
    t.TabloAdi,
    CASE WHEN OBJECT_ID(t.TabloAdi) IS NOT NULL THEN '✓ MEVCUT' ELSE '✗ EKSİK' END AS Durum
FROM @Tablolar t
ORDER BY t.TabloAdi
GO

-- =====================================================================
-- 2. KOLON KONTROLLERI
-- =====================================================================
PRINT ''
PRINT '▶ 2. KOLON KONTROLLERİ'
PRINT '─────────────────────────────────────────────────────────────────'
GO

-- tbStokSinifi kolonları
PRINT ''
PRINT 'tbStokSinifi:'
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokSinifi') AND name = 'sModel')
    PRINT '  ✓ sModel'
ELSE
    PRINT '  ✗ sModel EKSİK'

IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokSinifi') AND name = 'bKategoriAtla')
    PRINT '  ✓ bKategoriAtla'
ELSE
    PRINT '  ✗ bKategoriAtla EKSİK'
GO

-- tbStok kolonları
PRINT ''
PRINT 'tbStok:'
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'bAIIcerikVar')
    PRINT '  ✓ bAIIcerikVar'
ELSE
    PRINT '  ✗ bAIIcerikVar EKSİK'

IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'sWebAciklama')
    PRINT '  ✓ sWebAciklama'
ELSE
    PRINT '  ✗ sWebAciklama EKSİK'
GO

-- tbParamGenel kolonları
PRINT ''
PRINT 'tbParamGenel:'
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'DefaultImageUrl')
    PRINT '  ✓ DefaultImageUrl'
ELSE
    PRINT '  ✗ DefaultImageUrl EKSİK'

IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bAIKullan')
    PRINT '  ✓ bAIKullan'
ELSE
    PRINT '  ✗ bAIKullan EKSİK'
GO

-- =====================================================================
-- 3. VERİ KONTROLLERİ
-- =====================================================================
PRINT ''
PRINT '▶ 3. VERİ KONTROLLERİ'
PRINT '─────────────────────────────────────────────────────────────────'
GO

-- E-ticaret parametreleri
PRINT ''
PRINT 'E-Ticaret Parametreleri (tbParamETicaret):'
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbParamETicaret')
BEGIN
    SELECT 
        sPazarYeri AS 'Pazar Yeri',
        sKodu AS 'Kod',
        sSiparisNoOnek AS 'Sipariş Öneki',
        CAST(nKomisyonOrani AS VARCHAR) + '%' AS 'Komisyon',
        CAST(lKargoSabitBedel AS VARCHAR) + ' TL' AS 'Kargo',
        CASE WHEN bAktif = 1 THEN '✓ Aktif' ELSE '✗ Pasif' END AS 'Durum'
    FROM tbParamETicaret
    ORDER BY sPazarYeri
END
GO

-- Bildirim tipleri sayısı
PRINT ''
DECLARE @BildirimTipSayisi INT = 0
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbBildirimTipleri')
    SELECT @BildirimTipSayisi = COUNT(*) FROM tbBildirimTipleri
PRINT 'Bildirim Tipleri: ' + CAST(@BildirimTipSayisi AS VARCHAR) + ' adet'
GO

-- Audit işlem tipleri sayısı
DECLARE @AuditTipSayisi INT = 0
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbAuditIslemTipleri')
    SELECT @AuditTipSayisi = COUNT(*) FROM tbAuditIslemTipleri
PRINT 'Audit İşlem Tipleri: ' + CAST(@AuditTipSayisi AS VARCHAR) + ' adet'
GO

-- =====================================================================
-- 4. STORED PROCEDURE KONTROLLERİ
-- =====================================================================
PRINT ''
PRINT '▶ 4. STORED PROCEDURE KONTROLLERİ'
PRINT '─────────────────────────────────────────────────────────────────'
GO

IF OBJECT_ID('sp_AuditLog_Kaydet', 'P') IS NOT NULL
    PRINT '  ✓ sp_AuditLog_Kaydet'
ELSE
    PRINT '  ✗ sp_AuditLog_Kaydet EKSİK'

IF OBJECT_ID('sp_AuditLog_KayitGecmisi', 'P') IS NOT NULL
    PRINT '  ✓ sp_AuditLog_KayitGecmisi'
ELSE
    PRINT '  ✗ sp_AuditLog_KayitGecmisi EKSİK'

IF OBJECT_ID('fn_HesaplaEkMaliyet', 'FN') IS NOT NULL
    PRINT '  ✓ fn_HesaplaEkMaliyet'
ELSE
    PRINT '  ✗ fn_HesaplaEkMaliyet EKSİK'

IF OBJECT_ID('sp_BildirimGonder', 'P') IS NOT NULL
    PRINT '  ✓ sp_BildirimGonder'
ELSE
    PRINT '  ✗ sp_BildirimGonder EKSİK'
GO

-- =====================================================================
-- 5. TRIGGER KONTROLLERİ
-- =====================================================================
PRINT ''
PRINT '▶ 5. TRIGGER KONTROLLERİ'
PRINT '─────────────────────────────────────────────────────────────────'
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokInsWebTriggers')
    PRINT '  ✓ tbStokInsWebTriggers'
ELSE
    PRINT '  - tbStokInsWebTriggers (opsiyonel)'

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'tbStokUpdWebTriggers')
    PRINT '  ✓ tbStokUpdWebTriggers'
ELSE
    PRINT '  - tbStokUpdWebTriggers (opsiyonel)'

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'trg_StokResimUpdate')
    PRINT '  ✓ trg_StokResimUpdate'
ELSE
    PRINT '  - trg_StokResimUpdate (opsiyonel)'
GO

-- =====================================================================
-- 6. ÖRNEK MALİYET HESAPLAMASI
-- =====================================================================
PRINT ''
PRINT '▶ 6. ÖRNEK MALİYET HESAPLAMASI (1000 TL satış için)'
PRINT '─────────────────────────────────────────────────────────────────'
GO

IF OBJECT_ID('fn_HesaplaEkMaliyet', 'FN') IS NOT NULL AND EXISTS (SELECT * FROM tbParamETicaret)
BEGIN
    SELECT 
        sPazarYeri AS 'Platform',
        sSiparisNoOnek AS 'Önek',
        dbo.fn_HesaplaEkMaliyet(sSiparisNoOnek, 1000) AS 'Ek Maliyet (1000 TL için)'
    FROM tbParamETicaret
    WHERE bAktif = 1
    ORDER BY sPazarYeri
END
ELSE
    PRINT '  Fonksiyon veya parametre verisi bulunamadı'
GO

-- =====================================================================
-- 7. ÖZET
-- =====================================================================
PRINT ''
PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     KONTROL TAMAMLANDI                                       ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''
PRINT 'Eksik öğeler varsa ilgili scriptleri tekrar çalıştırın:'
PRINT '  - Tablolar için: 01_MASTER_KURULUM.sql'
PRINT '  - Procedure''ler için: 02_STORED_PROCEDURES.sql'
PRINT '  - Trigger''lar için: 03_TRIGGER_SISTEMI.sql'
PRINT '  - Veriler için: 04_VARSAYILAN_VERILER.sql'
PRINT ''
PRINT '⚠️  DefaultImageUrl değerini güncellemeyi unutmayın!'
PRINT '   UPDATE tbParamGenel SET DefaultImageUrl = ''https://sizin-url.com/resim.jpg'''
GO
