-- ============================================================================
-- KURULUM SCRİPTİ: Tüm Veritabanı Yapısını Oluştur
-- ============================================================================
-- Bu script tüm AI sistem tablolarını ve parametreleri oluşturur
-- Çalıştırma: SQL Server Management Studio'da F5 veya Execute
-- ============================================================================

USE [BARKOD_MAGAZA] -- Kendi veritabanı adınızı yazın
GO

PRINT '============================================'
PRINT 'AI SİSTEM KURULUMU BAŞLIYOR...'
PRINT '============================================'
PRINT ''

-- ============================================================================
-- 1. tbParamGenel Güncellemeleri
-- ============================================================================

PRINT '1. tbParamGenel güncelleniyor...'

-- AI Anahtarları
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='sEmergentKey')
BEGIN
    ALTER TABLE tbParamGenel ADD sEmergentKey NVARCHAR(255)
    PRINT '  ✓ sEmergentKey eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='sGoogleSearchApiKey')
BEGIN
    ALTER TABLE tbParamGenel ADD sGoogleSearchApiKey NVARCHAR(255)
    PRINT '  ✓ sGoogleSearchApiKey eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='sGoogleSearchEngineId')
BEGIN
    ALTER TABLE tbParamGenel ADD sGoogleSearchEngineId NVARCHAR(255)
    PRINT '  ✓ sGoogleSearchEngineId eklendi'
END

-- AI Parametreleri
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bAIKullan')
BEGIN
    ALTER TABLE tbParamGenel ADD bAIKullan BIT DEFAULT 0
    PRINT '  ✓ bAIKullan eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bBaslikOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bBaslikOlustur BIT DEFAULT 1
    PRINT '  ✓ bBaslikOlustur eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bAciklamaOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bAciklamaOlustur BIT DEFAULT 1
    PRINT '  ✓ bAciklamaOlustur eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bTalimatOlustur')
BEGIN
    ALTER TABLE tbParamGenel ADD bTalimatOlustur BIT DEFAULT 1
    PRINT '  ✓ bTalimatOlustur eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bGorselBul')
BEGIN
    ALTER TABLE tbParamGenel ADD bGorselBul BIT DEFAULT 0
    PRINT '  ✓ bGorselBul eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bGorselDogrula')
BEGIN
    ALTER TABLE tbParamGenel ADD bGorselDogrula BIT DEFAULT 0
    PRINT '  ✓ bGorselDogrula eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bKategoriOner')
BEGIN
    ALTER TABLE tbParamGenel ADD bKategoriOner BIT DEFAULT 0
    PRINT '  ✓ bKategoriOner eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='bFiyatOptimize')
BEGIN
    ALTER TABLE tbParamGenel ADD bFiyatOptimize BIT DEFAULT 0
    PRINT '  ✓ bFiyatOptimize eklendi'
END

-- Limitler
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='nGunlukAILimit')
BEGIN
    ALTER TABLE tbParamGenel ADD nGunlukAILimit INT DEFAULT 100
    PRINT '  ✓ nGunlukAILimit eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='nAylikBudget')
BEGIN
    ALTER TABLE tbParamGenel ADD nAylikBudget DECIMAL(10,2) DEFAULT 500.00
    PRINT '  ✓ nAylikBudget eklendi'
END

PRINT '  tbParamGenel güncellendi ✓'
PRINT ''

-- ============================================================================
-- 2. tbStok Güncellemeleri
-- ============================================================================

PRINT '2. tbStok güncelleniyor...'

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStok') AND name='bAIIcerikVar')
BEGIN
    ALTER TABLE tbStok ADD bAIIcerikVar BIT DEFAULT 0
    PRINT '  ✓ bAIIcerikVar eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStok') AND name='dteAISonGuncelleme')
BEGIN
    ALTER TABLE tbStok ADD dteAISonGuncelleme DATETIME
    PRINT '  ✓ dteAISonGuncelleme eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStok') AND name='nAIKaliteSkor')
BEGIN
    ALTER TABLE tbStok ADD nAIKaliteSkor INT
    PRINT '  ✓ nAIKaliteSkor eklendi'
END

PRINT '  tbStok güncellendi ✓'
PRINT ''

-- ============================================================================
-- 3. tbStokResim Güncellemeleri
-- ============================================================================

PRINT '3. tbStokResim güncelleniyor...'

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='nStokID')
BEGIN
    ALTER TABLE tbStokResim ADD nStokID INT
    PRINT '  ✓ nStokID eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='bAIBulundu')
BEGIN
    ALTER TABLE tbStokResim ADD bAIBulundu BIT DEFAULT 0
    PRINT '  ✓ bAIBulundu eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='sAIKaynak')
BEGIN
    ALTER TABLE tbStokResim ADD sAIKaynak NVARCHAR(100)
    PRINT '  ✓ sAIKaynak eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='nAIGuvenSkoru')
BEGIN
    ALTER TABLE tbStokResim ADD nAIGuvenSkoru INT
    PRINT '  ✓ nAIGuvenSkoru eklendi'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='sOrjinalURL')
BEGIN
    ALTER TABLE tbStokResim ADD sOrjinalURL NVARCHAR(1000)
    PRINT '  ✓ sOrjinalURL eklendi'
END

PRINT '  tbStokResim güncellendi ✓'
PRINT ''

-- ============================================================================
-- 4. YENİ TABLOLAR
-- ============================================================================

-- Devamı DATABASE_AI_CONTENT_STRUCTURE.sql dosyasından...
-- (Dosya çok büyük olduğu için ayrı çalıştırın)

PRINT '============================================'
PRINT 'TEMEL YAPILAR OLUŞTURULDU!'
PRINT ''
PRINT 'SONRAKİ ADIM:'
PRINT '  DATABASE_AI_CONTENT_STRUCTURE.sql dosyasını çalıştırın'
PRINT '============================================'
