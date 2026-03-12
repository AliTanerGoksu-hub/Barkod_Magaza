-- =============================================
-- KURULUM: Tablo ve Kolon Eklemeleri
-- =============================================
-- Bu script tüm gerekli tablo ve kolonları ekler
-- Birden fazla kez çalıştırılabilir (idempotent)
-- =============================================

USE [Database]; -- Veritabanı adınızı buraya yazın
GO

PRINT '========================================='
PRINT 'KURULUM BAŞLIYOR: Tablo ve Kolonlar'
PRINT '========================================='
PRINT ''

-- =============================================
-- 1. tbStokAIIcerik Tablosu (AI İçerikler)
-- =============================================
PRINT '1. tbStokAIIcerik tablosu kontrol ediliyor...'
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND type in (N'U'))
BEGIN
    CREATE TABLE tbStokAIIcerik (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT NULL,
        sModel NVARCHAR(50) NULL,
        sSEOBaslik NVARCHAR(MAX) NULL,
        sMetaDescription NVARCHAR(MAX) NULL,
        sKullanimTalimati NVARCHAR(MAX) NULL,
        sFiyatOptimize NVARCHAR(MAX) NULL,
        sKategoriOner NVARCHAR(MAX) NULL,
        dteOlusturma DATETIME DEFAULT GETDATE()
    );
    PRINT '   ✓ tbStokAIIcerik tablosu oluşturuldu'
END
ELSE
BEGIN
    PRINT '   ⚠ tbStokAIIcerik tablosu zaten mevcut'
    
    -- Kolonları kontrol et ve ekle
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sModel')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sModel NVARCHAR(50) NULL;
        PRINT '   ✓ sModel kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sSEOBaslik')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sSEOBaslik NVARCHAR(MAX) NULL;
        PRINT '   ✓ sSEOBaslik kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sMetaDescription')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sMetaDescription NVARCHAR(MAX) NULL;
        PRINT '   ✓ sMetaDescription kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sKullanimTalimati')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sKullanimTalimati NVARCHAR(MAX) NULL;
        PRINT '   ✓ sKullanimTalimati kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sFiyatOptimize')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sFiyatOptimize NVARCHAR(MAX) NULL;
        PRINT '   ✓ sFiyatOptimize kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sKategoriOner')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sKategoriOner NVARCHAR(MAX) NULL;
        PRINT '   ✓ sKategoriOner kolonu eklendi'
    END
END
GO

-- =============================================
-- 2. tbStokSinifi - sModel Kolonu
-- =============================================
PRINT ''
PRINT '2. tbStokSinifi tablosuna sModel kolonu ekleniyor...'
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokSinifi') AND name = 'sModel')
BEGIN
    ALTER TABLE tbStokSinifi ADD sModel NVARCHAR(50) NULL;
    PRINT '   ✓ tbStokSinifi.sModel kolonu eklendi'
END
ELSE
BEGIN
    PRINT '   ⚠ tbStokSinifi.sModel kolonu zaten mevcut'
END
GO

-- =============================================
-- 3. tbParamGenel - DefaultImageUrl Kolonu
-- =============================================
PRINT ''
PRINT '3. tbParamGenel tablosuna DefaultImageUrl kolonu ekleniyor...'
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamGenel') AND name = 'DefaultImageUrl')
BEGIN
    ALTER TABLE tbParamGenel ADD DefaultImageUrl NVARCHAR(255) NULL;
    PRINT '   ✓ tbParamGenel.DefaultImageUrl kolonu eklendi'
END
ELSE
BEGIN
    PRINT '   ⚠ tbParamGenel.DefaultImageUrl kolonu zaten mevcut'
END
GO

-- =============================================
-- 4. tbParamETicaret Tablosu (Tam Şema)
-- =============================================
PRINT ''
PRINT '4. tbParamETicaret tablosu kontrol ediliyor...'
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND type in (N'U'))
BEGIN
    CREATE TABLE tbParamETicaret (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sPazarYeri NVARCHAR(50) NULL,
        sKodu NVARCHAR(20) NULL,
        sSiparisNoOnek NVARCHAR(10) NULL,
        nKomisyonTipi INT DEFAULT 1,
        nKomisyonOrani DECIMAL(5,2) DEFAULT 0,
        lKomisyonSabitTutar DECIMAL(18,2) DEFAULT 0,
        lKargoSabitBedel DECIMAL(18,2) DEFAULT 0,
        nIadeOperasyonOrani DECIMAL(5,2) DEFAULT 0,
        nPaketlemeOrani DECIMAL(5,2) DEFAULT 0,
        nOdemeIslemUcretiOrani DECIMAL(5,2) DEFAULT 0,
        lOdemeIslemSabitUcret DECIMAL(18,2) DEFAULT 0,
        lDigerMasraf1 DECIMAL(18,2) DEFAULT 0,
        sDigerMasraf1Aciklama NVARCHAR(100) NULL,
        lDigerMasraf2 DECIMAL(18,2) DEFAULT 0,
        sDigerMasraf2Aciklama NVARCHAR(100) NULL,
        bAktif BIT DEFAULT 1,
        sSonKullaniciAdi NVARCHAR(50) NULL,
        dteSonGuncelleme DATETIME DEFAULT GETDATE()
    );
    PRINT '   ✓ tbParamETicaret tablosu oluşturuldu (Tam şema)'
END
ELSE
BEGIN
    PRINT '   ⚠ tbParamETicaret tablosu zaten mevcut - Eksik kolonlar kontrol ediliyor...'
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'sPazarYeri')
    BEGIN
        ALTER TABLE tbParamETicaret ADD sPazarYeri NVARCHAR(50) NULL;
        PRINT '   ✓ tbParamETicaret.sPazarYeri kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'sKodu')
    BEGIN
        ALTER TABLE tbParamETicaret ADD sKodu NVARCHAR(20) NULL;
        PRINT '   ✓ tbParamETicaret.sKodu kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'sSiparisNoOnek')
    BEGIN
        ALTER TABLE tbParamETicaret ADD sSiparisNoOnek NVARCHAR(10) NULL;
        PRINT '   ✓ tbParamETicaret.sSiparisNoOnek kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'nKomisyonTipi')
    BEGIN
        ALTER TABLE tbParamETicaret ADD nKomisyonTipi INT DEFAULT 1;
        PRINT '   ✓ tbParamETicaret.nKomisyonTipi kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'nKomisyonOrani')
    BEGIN
        ALTER TABLE tbParamETicaret ADD nKomisyonOrani DECIMAL(5,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.nKomisyonOrani kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'lKomisyonSabitTutar')
    BEGIN
        ALTER TABLE tbParamETicaret ADD lKomisyonSabitTutar DECIMAL(18,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.lKomisyonSabitTutar kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'lKargoSabitBedel')
    BEGIN
        ALTER TABLE tbParamETicaret ADD lKargoSabitBedel DECIMAL(18,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.lKargoSabitBedel kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'nIadeOperasyonOrani')
    BEGIN
        ALTER TABLE tbParamETicaret ADD nIadeOperasyonOrani DECIMAL(5,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.nIadeOperasyonOrani kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'nPaketlemeOrani')
    BEGIN
        ALTER TABLE tbParamETicaret ADD nPaketlemeOrani DECIMAL(5,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.nPaketlemeOrani kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'nOdemeIslemUcretiOrani')
    BEGIN
        ALTER TABLE tbParamETicaret ADD nOdemeIslemUcretiOrani DECIMAL(5,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.nOdemeIslemUcretiOrani kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'lOdemeIslemSabitUcret')
    BEGIN
        ALTER TABLE tbParamETicaret ADD lOdemeIslemSabitUcret DECIMAL(18,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.lOdemeIslemSabitUcret kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'lDigerMasraf1')
    BEGIN
        ALTER TABLE tbParamETicaret ADD lDigerMasraf1 DECIMAL(18,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.lDigerMasraf1 kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'sDigerMasraf1Aciklama')
    BEGIN
        ALTER TABLE tbParamETicaret ADD sDigerMasraf1Aciklama NVARCHAR(100) NULL;
        PRINT '   ✓ tbParamETicaret.sDigerMasraf1Aciklama kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'lDigerMasraf2')
    BEGIN
        ALTER TABLE tbParamETicaret ADD lDigerMasraf2 DECIMAL(18,2) DEFAULT 0;
        PRINT '   ✓ tbParamETicaret.lDigerMasraf2 kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'sDigerMasraf2Aciklama')
    BEGIN
        ALTER TABLE tbParamETicaret ADD sDigerMasraf2Aciklama NVARCHAR(100) NULL;
        PRINT '   ✓ tbParamETicaret.sDigerMasraf2Aciklama kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'bAktif')
    BEGIN
        ALTER TABLE tbParamETicaret ADD bAktif BIT DEFAULT 1;
        PRINT '   ✓ tbParamETicaret.bAktif kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'sSonKullaniciAdi')
    BEGIN
        ALTER TABLE tbParamETicaret ADD sSonKullaniciAdi NVARCHAR(50) NULL;
        PRINT '   ✓ tbParamETicaret.sSonKullaniciAdi kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbParamETicaret') AND name = 'dteSonGuncelleme')
    BEGIN
        ALTER TABLE tbParamETicaret ADD dteSonGuncelleme DATETIME DEFAULT GETDATE();
        PRINT '   ✓ tbParamETicaret.dteSonGuncelleme kolonu eklendi'
    END
END
GO

-- =============================================
-- 5. tbStokResim Tablosu (OleDb Uyumlu)
-- =============================================
IF OBJECT_ID('dbo.tbStokResim','U') IS NULL
BEGIN
    CREATE TABLE dbo.tbStokResim (
        nStokResimID int IDENTITY(1,1) NOT NULL,
        sModel varchar(50) NOT NULL,
        nSira int NOT NULL CONSTRAINT DF_tbStokResim_nSira DEFAULT (1),
        pResim text NULL,
        yol varchar(500) NULL,
        sAciklama varchar(250) NULL,
        sKullaniciAdi varchar(50) NULL,
        dteKayitTarihi datetime NOT NULL CONSTRAINT DF_tbStokResim_dteKayitTarihi DEFAULT (getdate()),
        nStokID int NULL,
        bAIBulundu bit NULL DEFAULT (0),
        sAIKaynak nvarchar(100) NULL,
        nAIGuvenSkoru int NULL,
        sOrjinalURL nvarchar(1000) NULL,
        sRenk varchar(10) NULL,
        sBeden varchar(10) NULL,
        sKavala varchar(10) NULL,
        bAnaResim bit NULL DEFAULT (0),
        CONSTRAINT PK_tbStokResim PRIMARY KEY CLUSTERED (nStokResimID ASC),
        CONSTRAINT CK_tbStokResim_nSira CHECK (nSira >= 1 AND nSira <= 11)
    );
END
ELSE
BEGIN
    IF COL_LENGTH('dbo.tbStokResim','sModel') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sModel varchar(50) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','nSira') IS NULL
        ALTER TABLE dbo.tbStokResim ADD nSira int NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','pResim') IS NULL
        ALTER TABLE dbo.tbStokResim ADD pResim text NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','yol') IS NULL
        ALTER TABLE dbo.tbStokResim ADD yol varchar(500) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','sAciklama') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sAciklama varchar(250) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','sKullaniciAdi') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sKullaniciAdi varchar(50) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','dteKayitTarihi') IS NULL
        ALTER TABLE dbo.tbStokResim ADD dteKayitTarihi datetime NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','nStokID') IS NULL
        ALTER TABLE dbo.tbStokResim ADD nStokID int NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','bAIBulundu') IS NULL
        ALTER TABLE dbo.tbStokResim ADD bAIBulundu bit NULL DEFAULT (0);
    
    IF COL_LENGTH('dbo.tbStokResim','sAIKaynak') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sAIKaynak nvarchar(100) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','nAIGuvenSkoru') IS NULL
        ALTER TABLE dbo.tbStokResim ADD nAIGuvenSkoru int NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','sOrjinalURL') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sOrjinalURL nvarchar(1000) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','sRenk') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sRenk varchar(10) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','sBeden') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sBeden varchar(10) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','sKavala') IS NULL
        ALTER TABLE dbo.tbStokResim ADD sKavala varchar(10) NULL;
    
    IF COL_LENGTH('dbo.tbStokResim','bAnaResim') IS NULL
        ALTER TABLE dbo.tbStokResim ADD bAnaResim bit NULL DEFAULT (0);
END
GO

-- =============================================
-- 6. tbStok Tablosu - AI Kolonları
-- =============================================
PRINT ''
PRINT '6. tbStok tablosuna AI kolonları ekleniyor...'
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStok') AND name = 'bAIIcerikVar')
BEGIN
    ALTER TABLE tbStok ADD bAIIcerikVar BIT DEFAULT 0;
    PRINT '   ✓ tbStok.bAIIcerikVar kolonu eklendi'
END
ELSE
BEGIN
    PRINT '   ⚠ tbStok.bAIIcerikVar kolonu zaten mevcut'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStok') AND name = 'dteAISonGuncelleme')
BEGIN
    ALTER TABLE tbStok ADD dteAISonGuncelleme DATETIME NULL;
    PRINT '   ✓ tbStok.dteAISonGuncelleme kolonu eklendi'
END
ELSE
BEGIN
    PRINT '   ⚠ tbStok.dteAISonGuncelleme kolonu zaten mevcut'
END
GO

-- =============================================
-- 7. Index'leri Oluştur (Performans)
-- =============================================
PRINT ''
PRINT '7. Performans index''leri oluşturuluyor...'
GO

-- tbStokAIIcerik.sModel index
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokAIIcerik_sModel' AND object_id = OBJECT_ID('tbStokAIIcerik'))
BEGIN
    CREATE NONCLUSTERED INDEX IX_tbStokAIIcerik_sModel ON tbStokAIIcerik(sModel);
    PRINT '   ✓ IX_tbStokAIIcerik_sModel index oluşturuldu'
END

-- tbStokSinifi.sModel index
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokSinifi_sModel' AND object_id = OBJECT_ID('tbStokSinifi'))
BEGIN
    CREATE NONCLUSTERED INDEX IX_tbStokSinifi_sModel ON tbStokSinifi(sModel);
    PRINT '   ✓ IX_tbStokSinifi_sModel index oluşturuldu'
END

-- tbStokResim.sModel index
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_sModel' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE NONCLUSTERED INDEX IX_tbStokResim_sModel ON tbStokResim(sModel);
    PRINT '   ✓ IX_tbStokResim_sModel index oluşturuldu'
END

-- tbStokResim composite index (sModel + sRenk)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbStokResim_sModel_sRenk' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    CREATE NONCLUSTERED INDEX IX_tbStokResim_sModel_sRenk ON tbStokResim(sModel, sRenk);
    PRINT '   ✓ IX_tbStokResim_sModel_sRenk index oluşturuldu'
END
GO

PRINT ''
PRINT '========================================='
PRINT '✅ KURULUM TAMAMLANDI'
PRINT '========================================='
PRINT ''
PRINT 'Sonraki adım: 02_MIGRATION_MODEL_BAZLI.sql'
GO
