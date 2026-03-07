-- ============================================================================
-- VARSAYILAN PARAMETRE KAYDI
-- ============================================================================
-- Bu script tbParamGenel tablosuna varsayılan AI parametrelerini ekler
-- Eğer nParamID = 1 satırı yoksa INSERT yapar
-- ============================================================================

USE [BARKOD_MAGAZA] -- Kendi veritabanı adınızı yazın
GO

PRINT '============================================'
PRINT 'VARSAYILAN PARAMETRELERİ EKLİYOR...'
PRINT '============================================'
PRINT ''

-- tbParamGenel tablosunda nParamID = 1 var mı kontrol et
IF NOT EXISTS (SELECT * FROM tbParamGenel WHERE nParamID = 1)
BEGIN
    PRINT 'nParamID = 1 bulunamadı, varsayılan değerler ekleniyor...'
    
    -- Varsayılan satırı ekle
    INSERT INTO tbParamGenel (
        nParamID,
        bAIKullan,
        bBaslikOlustur,
        bAciklamaOlustur,
        bTalimatOlustur,
        bGorselBul,
        bGorselDogrula,
        bKategoriOner,
        bFiyatOptimize,
        sEmergentKey,
        sGoogleSearchApiKey,
        sGoogleSearchEngineId,
        nGunlukAILimit,
        nAylikBudget
    )
    VALUES (
        1,                    -- nParamID
        0,                    -- bAIKullan (Kapalı)
        1,                    -- bBaslikOlustur (Açık)
        1,                    -- bAciklamaOlustur (Açık)
        1,                    -- bTalimatOlustur (Açık)
        1,                    -- bGorselBul (Açık)
        0,                    -- bGorselDogrula (Kapalı)
        0,                    -- bKategoriOner (Kapalı)
        0,                    -- bFiyatOptimize (Kapalı)
        '',                   -- sEmergentKey (Boş)
        '',                   -- sGoogleSearchApiKey (Boş)
        '',                   -- sGoogleSearchEngineId (Boş)
        100,                  -- nGunlukAILimit
        500                   -- nAylikBudget (TL)
    )
    
    PRINT '  ✓ Varsayılan parametreler eklendi'
    PRINT ''
    PRINT '  NOT: AI Sistemi kullanmak için:'
    PRINT '  1. Uygulamada Sistem > AI Sistemi > AI Ayarları açın'
    PRINT '  2. Emergent LLM Key girin'
    PRINT '  3. AI Sistemi Aktif checkbox işaretleyin'
    PRINT '  4. Ayarları Kaydet butonuna tıklayın'
    PRINT ''
END
ELSE
BEGIN
    PRINT '✓ nParamID = 1 zaten mevcut'
    
    -- Mevcut değerleri göster
    DECLARE @aiAktif BIT
    DECLARE @emergentKey NVARCHAR(50)
    
    SELECT @aiAktif = ISNULL(bAIKullan, 0) FROM tbParamGenel WHERE nParamID = 1
    SELECT @emergentKey = ISNULL(LEFT(sEmergentKey, 10), '(boş)') FROM tbParamGenel WHERE nParamID = 1
    
    PRINT '  Mevcut Durum:'
    PRINT '    - AI Aktif: ' + CASE WHEN @aiAktif = 1 THEN 'EVET' ELSE 'HAYIR' END
    PRINT '    - Emergent Key: ' + @emergentKey + '...'
    PRINT ''
END

PRINT '============================================'
PRINT 'İŞLEM TAMAMLANDI'
PRINT '============================================'

GO
