-- ============================================================================
-- AI SİSTEM TAM KURULUM - TEK SCRIPT
-- ============================================================================
-- Bu script tüm AI sistem kurulumunu tek seferde yapar
-- Veritabanı adını değiştirip F5'e basın, biter!
-- ============================================================================

USE [BARKOD_MAGAZA] -- ← BURAYA KENDİ VERİTABANI ADINIZI YAZIN!
GO

SET NOCOUNT ON
PRINT ''
PRINT '╔════════════════════════════════════════════════════════════╗'
PRINT '║          AI SİSTEM KURULUM BAŞLIYOR...                     ║'
PRINT '╚════════════════════════════════════════════════════════════╝'
PRINT ''

-- ============================================================================
-- 1. nParamID Kolonu Ekle (Primary Key)
-- ============================================================================
PRINT '1/8 - nParamID kolonu kontrol ediliyor...'

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='nParamID')
BEGIN
    ALTER TABLE tbParamGenel ADD nParamID INT NOT NULL DEFAULT 1
    PRINT '      ✓ nParamID eklendi'
END
ELSE
    PRINT '      ✓ nParamID zaten mevcut'

GO

-- Primary Key ayarla
IF NOT EXISTS (SELECT * FROM sys.key_constraints 
               WHERE type = 'PK' 
               AND parent_object_id = OBJECT_ID('tbParamGenel')
               AND name = 'PK_tbParamGenel')
BEGIN
    -- Eski PK varsa kaldır
    IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
               WHERE TABLE_NAME = 'tbParamGenel' AND CONSTRAINT_TYPE = 'PRIMARY KEY')
    BEGIN
        DECLARE @pk1 NVARCHAR(128)
        SELECT @pk1 = name FROM sys.key_constraints 
        WHERE type = 'PK' AND parent_object_id = OBJECT_ID('tbParamGenel')
        EXEC('ALTER TABLE tbParamGenel DROP CONSTRAINT ' + @pk1)
    END
    
    ALTER TABLE tbParamGenel ADD CONSTRAINT PK_tbParamGenel PRIMARY KEY (nParamID)
    PRINT '      ✓ Primary Key ayarlandı'
END

PRINT ''
GO

-- ============================================================================
-- 2. tbParamGenel AI Kolonlarını Ekle
-- ============================================================================
PRINT '2/8 - AI kolonları ekleniyor...'

-- API Keys
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='sEmergentKey')
BEGIN
    ALTER TABLE tbParamGenel ADD sEmergentKey NVARCHAR(255)
    PRINT '      ✓ sEmergentKey eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='sOpenAIKey')
BEGIN
    ALTER TABLE tbParamGenel ADD sOpenAIKey NVARCHAR(255)
    PRINT '      ✓ sOpenAIKey eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='sGoogleSearchApiKey')
BEGIN
    ALTER TABLE tbParamGenel ADD sGoogleSearchApiKey NVARCHAR(255)
    PRINT '      ✓ sGoogleSearchApiKey eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='sGoogleSearchEngineId')
BEGIN
    ALTER TABLE tbParamGenel ADD sGoogleSearchEngineId NVARCHAR(255)
    PRINT '      ✓ sGoogleSearchEngineId eklendi'
END

-- AI Features
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bAIKullan')
BEGIN
    ALTER TABLE tbParamGenel ADD bAIKullan BIT DEFAULT 0
    PRINT '      ✓ bAIKullan eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bBaslikOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bBaslikOlustur BIT DEFAULT 1
    PRINT '      ✓ bBaslikOlustur eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bAciklamaOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bAciklamaOlustur BIT DEFAULT 1
    PRINT '      ✓ bAciklamaOlustur eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bTalimatOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bTalimatOlustur BIT DEFAULT 1
    PRINT '      ✓ bTalimatOlustur eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bGorselBul')
BEGIN
    ALTER TABLE tbParamGenel ADD bGorselBul BIT DEFAULT 1
    PRINT '      ✓ bGorselBul eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bGorselDogrula')
BEGIN
    ALTER TABLE tbParamGenel ADD bGorselDogrula BIT DEFAULT 0
    PRINT '      ✓ bGorselDogrula eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bKategoriOner')
BEGIN
    ALTER TABLE tbParamGenel ADD bKategoriOner BIT DEFAULT 0
    PRINT '      ✓ bKategoriOner eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bFiyatOptimize')
BEGIN
    ALTER TABLE tbParamGenel ADD bFiyatOptimize BIT DEFAULT 0
    PRINT '      ✓ bFiyatOptimize eklendi'
END

-- Limits
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='nGunlukAILimit')
BEGIN
    ALTER TABLE tbParamGenel ADD nGunlukAILimit INT DEFAULT 100
    PRINT '      ✓ nGunlukAILimit eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='nAylikBudget')
BEGIN
    ALTER TABLE tbParamGenel ADD nAylikBudget DECIMAL(18,2) DEFAULT 500
    PRINT '      ✓ nAylikBudget eklendi'
END

PRINT ''
GO

-- ============================================================================
-- 3. Varsayılan Değerleri Ekle (nParamID = 1)
-- ============================================================================
PRINT '3/8 - Varsayılan parametreler kontrol ediliyor...'

IF NOT EXISTS (SELECT * FROM tbParamGenel WHERE nParamID = 1)
BEGIN
    INSERT INTO tbParamGenel (
        nParamID, bAIKullan, bBaslikOlustur, bAciklamaOlustur, 
        bTalimatOlustur, bGorselBul, bGorselDogrula, bKategoriOner, 
        bFiyatOptimize, sEmergentKey, sGoogleSearchApiKey, 
        sGoogleSearchEngineId, nGunlukAILimit, nAylikBudget
    )
    VALUES (
        1, 0, 1, 1, 1, 1, 0, 0, 0, '', '', '', 100, 500
    )
    PRINT '      ✓ nParamID = 1 oluşturuldu'
END
ELSE
    PRINT '      ✓ nParamID = 1 zaten mevcut'

PRINT ''

-- ============================================================================
-- 4. tbStokResim Tablosu
-- ============================================================================
PRINT '4/8 - tbStokResim tablosu kontrol ediliyor...'

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tbStokResim') AND type in (N'U'))
BEGIN
    CREATE TABLE tbStokResim (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT,
        sKodu NVARCHAR(50),
        sResimYolu NVARCHAR(500),
        sRenk NVARCHAR(50),
        bAnaResim BIT DEFAULT 0,
        dTarih DATETIME DEFAULT GETDATE()
    )
    PRINT '      ✓ tbStokResim tablosu oluşturuldu'
END
ELSE
BEGIN
    -- Kolonları kontrol et ve ekle
    IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='nStokID')
    BEGIN
        ALTER TABLE tbStokResim ADD nStokID INT
        PRINT '      ✓ nStokID eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='sRenk')
    BEGIN
        ALTER TABLE tbStokResim ADD sRenk NVARCHAR(50)
        PRINT '      ✓ sRenk eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='bAnaResim')
    BEGIN
        ALTER TABLE tbStokResim ADD bAnaResim BIT DEFAULT 0
        PRINT '      ✓ bAnaResim eklendi'
    END
    
    PRINT '      ✓ tbStokResim güncellendi'
END

PRINT ''

-- ============================================================================
-- 5. tbAIContent Tablosu (AI İçerik Kayıtları)
-- ============================================================================
PRINT '5/8 - tbAIContent tablosu kontrol ediliyor...'

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tbAIContent') AND type in (N'U'))
BEGIN
    CREATE TABLE tbAIContent (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT,
        sKodu NVARCHAR(50),
        sContentType NVARCHAR(50), -- 'title', 'description', 'instruction'
        sContent NVARCHAR(MAX),
        dCreatedDate DATETIME DEFAULT GETDATE(),
        sCreatedBy NVARCHAR(50),
        nCost DECIMAL(18,4) DEFAULT 0
    )
    PRINT '      ✓ tbAIContent oluşturuldu'
END
ELSE
    PRINT '      ✓ tbAIContent zaten mevcut'

PRINT ''

-- ============================================================================
-- 6. tbAIHistory Tablosu (AI İşlem Geçmişi)
-- ============================================================================
PRINT '6/8 - tbAIHistory tablosu kontrol ediliyor...'

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tbAIHistory') AND type in (N'U'))
BEGIN
    CREATE TABLE tbAIHistory (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sOperation NVARCHAR(100),
        nStokID INT,
        sKodu NVARCHAR(50),
        bSuccess BIT,
        sErrorMessage NVARCHAR(MAX),
        dDate DATETIME DEFAULT GETDATE(),
        sUser NVARCHAR(50),
        nCost DECIMAL(18,4) DEFAULT 0
    )
    PRINT '      ✓ tbAIHistory oluşturuldu'
END
ELSE
    PRINT '      ✓ tbAIHistory zaten mevcut'

PRINT ''

-- ============================================================================
-- 7. tbCreditUsage Tablosu (Kredi Kullanım Takibi)
-- ============================================================================
PRINT '7/8 - tbCreditUsage tablosu kontrol ediliyor...'

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tbCreditUsage') AND type in (N'U'))
BEGIN
    CREATE TABLE tbCreditUsage (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        dDate DATE DEFAULT GETDATE(),
        nDailyUsage INT DEFAULT 0,
        nMonthlyUsage INT DEFAULT 0,
        nMonthlyCost DECIMAL(18,2) DEFAULT 0
    )
    PRINT '      ✓ tbCreditUsage oluşturuldu'
END
ELSE
    PRINT '      ✓ tbCreditUsage zaten mevcut'

PRINT ''

-- ============================================================================
-- 8. İndeksler Oluştur (Performans İçin)
-- ============================================================================
PRINT '8/8 - İndeksler kontrol ediliyor...'

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_nStokID' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE INDEX IX_tbStokResim_nStokID ON tbStokResim(nStokID)
    PRINT '      ✓ tbStokResim indeks eklendi'
END

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbAIContent_nStokID' AND object_id = OBJECT_ID('tbAIContent'))
BEGIN
    CREATE INDEX IX_tbAIContent_nStokID ON tbAIContent(nStokID)
    PRINT '      ✓ tbAIContent indeks eklendi'
END

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbAIHistory_dDate' AND object_id = OBJECT_ID('tbAIHistory'))
BEGIN
    CREATE INDEX IX_tbAIHistory_dDate ON tbAIHistory(dDate)
    PRINT '      ✓ tbAIHistory indeks eklendi'
END

PRINT ''

-- ============================================================================
-- KURULUM TAMAMLANDI - KONTROL
-- ============================================================================
PRINT '╔════════════════════════════════════════════════════════════╗'
PRINT '║          KURULUM TAMAMLANDI!                               ║'
PRINT '╚════════════════════════════════════════════════════════════╝'
PRINT ''
PRINT 'KONTROL:'

-- tbParamGenel kontrolü
DECLARE @aiAktif BIT, @keyVar NVARCHAR(20)
SELECT @aiAktif = ISNULL(bAIKullan, 0) FROM tbParamGenel WHERE nParamID = 1
SELECT @keyVar = CASE WHEN LEN(ISNULL(sEmergentKey,'')) > 0 THEN 'MEVCUT' ELSE 'BOŞ' END FROM tbParamGenel WHERE nParamID = 1

PRINT '  ✓ tbParamGenel (nParamID=1) : ' + CASE WHEN @aiAktif=1 THEN 'AI AKTİF' ELSE 'AI KAPALI' END
PRINT '  ✓ Emergent Key            : ' + @keyVar

-- Tablo sayıları
DECLARE @resimSayisi INT, @aiContentSayisi INT
SELECT @resimSayisi = COUNT(*) FROM tbStokResim
SELECT @aiContentSayisi = COUNT(*) FROM tbAIContent

PRINT '  ✓ tbStokResim             : ' + CAST(@resimSayisi AS VARCHAR(10)) + ' kayıt'
PRINT '  ✓ tbAIContent             : ' + CAST(@aiContentSayisi AS VARCHAR(10)) + ' kayıt'

PRINT ''
PRINT 'SONRAKI ADIMLAR:'
PRINT '  1. Uygulamayı açın'
PRINT '  2. Sistem > AI Sistemi > AI Ayarları'
PRINT '  3. Emergent LLM Key girin'
PRINT '  4. AI Sistemi Aktif checkbox işaretleyin'
PRINT '  5. Ayarları Kaydet butonuna basın'
PRINT '  6. Test Et butonuna basın'
PRINT ''
PRINT '═══════════════════════════════════════════════════════════'

GO
