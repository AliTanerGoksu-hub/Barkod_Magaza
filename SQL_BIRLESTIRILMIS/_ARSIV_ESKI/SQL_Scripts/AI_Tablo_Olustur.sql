-- =============================================
-- AI İçerik Sistemi - TABLO OLUŞTURMA
-- Tarih: 2024
-- Bu scripti SQL Server Management Studio'da çalıştırın
-- =============================================

-- =============================================
-- BÖLÜM 1: tbStokAIIcerik TABLOSU
-- =============================================

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbStokAIIcerik')
BEGIN
    CREATE TABLE tbStokAIIcerik (
        nAIIcerikID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT NOT NULL,
        sSEOBaslik NVARCHAR(200) NULL,
        sKisaAciklama NVARCHAR(500) NULL,
        sDetayliAciklama NVARCHAR(MAX) NULL,
        sOzelliklerHTML NVARCHAR(MAX) NULL,
        sKullanimTalimati NVARCHAR(MAX) NULL,
        sBedenTablosu NVARCHAR(MAX) NULL,
        sMetaDescription NVARCHAR(200) NULL,
        sAnahtarKelimeler NVARCHAR(500) NULL,
        nIcerikPuani INT DEFAULT 0,
        nAIMaliyet DECIMAL(10,4) DEFAULT 0,
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteGuncelleme DATETIME DEFAULT GETDATE()
    )
    
    CREATE INDEX IX_tbStokAIIcerik_StokID ON tbStokAIIcerik(nStokID)
    PRINT '✓ tbStokAIIcerik tablosu oluşturuldu.'
END
ELSE
BEGIN
    PRINT '→ tbStokAIIcerik tablosu zaten mevcut.'
END
GO

-- =============================================
-- BÖLÜM 2: tbStok TABLOSUNA AI KOLONLARI EKLE
-- =============================================

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'bAIIcerikVar')
BEGIN
    ALTER TABLE tbStok ADD bAIIcerikVar BIT DEFAULT 0
    PRINT '✓ tbStok.bAIIcerikVar sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'dteAISonGuncelleme')
BEGIN
    ALTER TABLE tbStok ADD dteAISonGuncelleme DATETIME NULL
    PRINT '✓ tbStok.dteAISonGuncelleme sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'sWebAciklama')
BEGIN
    ALTER TABLE tbStok ADD sWebAciklama NVARCHAR(MAX) NULL
    PRINT '✓ tbStok.sWebAciklama sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'sWebBaslik')
BEGIN
    ALTER TABLE tbStok ADD sWebBaslik NVARCHAR(200) NULL
    PRINT '✓ tbStok.sWebBaslik sütunu eklendi.'
END
GO

-- =============================================
-- BÖLÜM 3: tbParamGenel TABLOSUNA AI PARAMETRELER
-- =============================================

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bAIKullan')
BEGIN
    ALTER TABLE tbParamGenel ADD bAIKullan BIT DEFAULT 1
    PRINT '✓ tbParamGenel.bAIKullan sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bBaslikOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bBaslikOlustur BIT DEFAULT 1
    PRINT '✓ tbParamGenel.bBaslikOlustur sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bAciklamaOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bAciklamaOlustur BIT DEFAULT 1
    PRINT '✓ tbParamGenel.bAciklamaOlustur sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bKapsamliIcerik')
BEGIN
    ALTER TABLE tbParamGenel ADD bKapsamliIcerik BIT DEFAULT 1
    PRINT '✓ tbParamGenel.bKapsamliIcerik sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bTalimatOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bTalimatOlustur BIT DEFAULT 1
    PRINT '✓ tbParamGenel.bTalimatOlustur sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bGorselBul')
BEGIN
    ALTER TABLE tbParamGenel ADD bGorselBul BIT DEFAULT 0
    PRINT '✓ tbParamGenel.bGorselBul sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bBedenTablosuOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bBedenTablosuOlustur BIT DEFAULT 1
    PRINT '✓ tbParamGenel.bBedenTablosuOlustur sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'sEmergentKey')
BEGIN
    ALTER TABLE tbParamGenel ADD sEmergentKey NVARCHAR(500) NULL
    PRINT '✓ tbParamGenel.sEmergentKey sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'sOpenAIKey')
BEGIN
    ALTER TABLE tbParamGenel ADD sOpenAIKey NVARCHAR(500) NULL
    PRINT '✓ tbParamGenel.sOpenAIKey sütunu eklendi.'
END
GO

-- Varsayılan AI parametrelerini aktifleştir
UPDATE tbParamGenel SET 
    bAIKullan = 1,
    bBaslikOlustur = 1,
    bAciklamaOlustur = 1,
    bKapsamliIcerik = 1,
    bTalimatOlustur = 1,
    bBedenTablosuOlustur = 1
WHERE bAIKullan IS NULL OR bAIKullan = 0
GO

PRINT ''
PRINT '============================================='
PRINT 'AI İÇERİK SİSTEMİ KURULUMU TAMAMLANDI!'
PRINT ''
PRINT 'Oluşturulan/Güncellenen:'
PRINT '  - tbStokAIIcerik (AI içerik tablosu)'
PRINT '  - tbStok (bAIIcerikVar, sWebAciklama, sWebBaslik)'
PRINT '  - tbParamGenel (AI parametreleri)'
PRINT '============================================='
GO
