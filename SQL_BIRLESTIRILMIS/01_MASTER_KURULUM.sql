-- =====================================================================
-- BARKOD MAGAZA - MASTER KURULUM SCRIPT
-- =====================================================================
-- Versiyon: 1.0
-- Tarih: Ocak 2025
-- Açıklama: Tüm tablo, kolon ve index tanımlarını içerir
-- =====================================================================
-- ÖNCE VERİTABANI YEDEĞİ ALIN!
-- Aşağıdaki satırdaki veritabanı adını değiştirin:
-- =====================================================================

USE [VERITABANI_ADINIZ]
GO

PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     BARKOD MAGAZA - MASTER KURULUM BASLIYOR                  ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''

-- =====================================================================
-- BÖLÜM 1: E-TİCARET PARAMETRE TABLOSU
-- =====================================================================
PRINT '▶ BÖLÜM 1: E-Ticaret Parametre Tablosu'
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbParamETicaret]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbParamETicaret](
        [nParamID] INT IDENTITY(1,1) PRIMARY KEY,
        [sPazarYeri] VARCHAR(50) NOT NULL,
        [sKodu] VARCHAR(20) NOT NULL UNIQUE,
        [sSiparisNoOnek] VARCHAR(10) NOT NULL,
        [nKomisyonTipi] TINYINT DEFAULT 1,
        [nKomisyonOrani] DECIMAL(5,2) DEFAULT 0,
        [lKomisyonSabitTutar] DECIMAL(18,2) DEFAULT 0,
        [lKargoSabitBedel] DECIMAL(18,2) DEFAULT 0,
        [nIadeOperasyonOrani] DECIMAL(5,2) DEFAULT 0,
        [nPaketlemeOrani] DECIMAL(5,2) DEFAULT 5.00,
        [nOdemeIslemUcretiOrani] DECIMAL(5,2) DEFAULT 0,
        [lOdemeIslemSabitUcret] DECIMAL(18,2) DEFAULT 10.00,
        [lDigerMasraf1] DECIMAL(18,2) DEFAULT 0,
        [sDigerMasraf1Aciklama] VARCHAR(100),
        [lDigerMasraf2] DECIMAL(18,2) DEFAULT 0,
        [sDigerMasraf2Aciklama] VARCHAR(100),
        [bAktif] BIT DEFAULT 1,
        [sKullaniciAdi] VARCHAR(50),
        [dteKayitTarihi] DATETIME DEFAULT GETDATE(),
        [sSonKullaniciAdi] VARCHAR(50),
        [dteSonGuncelleme] DATETIME
    )
    
    CREATE INDEX IX_tbParamETicaret_sSiparisNoOnek ON [dbo].[tbParamETicaret]([sSiparisNoOnek])
    PRINT '  ✓ tbParamETicaret tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbParamETicaret tablosu zaten mevcut'
GO

-- =====================================================================
-- BÖLÜM 2: AI İÇERİK TABLOSU
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 2: AI İçerik Tablosu'
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbStokAIIcerik')
BEGIN
    CREATE TABLE tbStokAIIcerik (
        nAIIcerikID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT NULL,
        sModel NVARCHAR(50) NULL,
        sSEOBaslik NVARCHAR(200) NULL,
        sKisaAciklama NVARCHAR(500) NULL,
        sDetayliAciklama NVARCHAR(MAX) NULL,
        sOzelliklerHTML NVARCHAR(MAX) NULL,
        sKullanimTalimati NVARCHAR(MAX) NULL,
        sBedenTablosu NVARCHAR(MAX) NULL,
        sMetaDescription NVARCHAR(200) NULL,
        sAnahtarKelimeler NVARCHAR(500) NULL,
        sFiyatOptimize NVARCHAR(MAX) NULL,
        sKategoriOner NVARCHAR(MAX) NULL,
        nIcerikPuani INT DEFAULT 0,
        nAIMaliyet DECIMAL(10,4) DEFAULT 0,
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteGuncelleme DATETIME DEFAULT GETDATE()
    )
    
    CREATE INDEX IX_tbStokAIIcerik_StokID ON tbStokAIIcerik(nStokID)
    CREATE INDEX IX_tbStokAIIcerik_sModel ON tbStokAIIcerik(sModel)
    PRINT '  ✓ tbStokAIIcerik tablosu oluşturuldu'
END
ELSE
BEGIN
    PRINT '  - tbStokAIIcerik tablosu zaten mevcut, eksik kolonlar kontrol ediliyor...'
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sModel')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sModel NVARCHAR(50) NULL
        PRINT '    ✓ sModel kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sFiyatOptimize')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sFiyatOptimize NVARCHAR(MAX) NULL
        PRINT '    ✓ sFiyatOptimize kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'tbStokAIIcerik') AND name = 'sKategoriOner')
    BEGIN
        ALTER TABLE tbStokAIIcerik ADD sKategoriOner NVARCHAR(MAX) NULL
        PRINT '    ✓ sKategoriOner kolonu eklendi'
    END
END
GO

-- =====================================================================
-- BÖLÜM 3: STOK RESİM TABLOSU
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 3: Stok Resim Tablosu'
GO

IF OBJECT_ID('dbo.tbStokResim','U') IS NULL
BEGIN
    CREATE TABLE dbo.tbStokResim (
        nStokResimID INT IDENTITY(1,1) NOT NULL,
        sModel VARCHAR(50) NOT NULL,
        nSira INT NOT NULL CONSTRAINT DF_tbStokResim_nSira DEFAULT (1),
        pResim TEXT NULL,
        yol VARCHAR(500) NULL,
        sAciklama VARCHAR(250) NULL,
        sKullaniciAdi VARCHAR(50) NULL,
        dteKayitTarihi DATETIME NOT NULL CONSTRAINT DF_tbStokResim_dteKayitTarihi DEFAULT (GETDATE()),
        nStokID INT NULL,
        bAIBulundu BIT NULL DEFAULT (0),
        sAIKaynak NVARCHAR(100) NULL,
        nAIGuvenSkoru INT NULL,
        sOrjinalURL NVARCHAR(1000) NULL,
        sRenk VARCHAR(10) NULL,
        sBeden VARCHAR(10) NULL,
        sKavala VARCHAR(10) NULL,
        bAnaResim BIT NULL DEFAULT (0),
        CONSTRAINT PK_tbStokResim PRIMARY KEY CLUSTERED (nStokResimID ASC),
        CONSTRAINT CK_tbStokResim_nSira CHECK (nSira >= 1 AND nSira <= 11)
    )
    
    CREATE INDEX IX_tbStokResim_sModel ON tbStokResim(sModel)
    CREATE INDEX IX_tbStokResim_sModel_sRenk ON tbStokResim(sModel, sRenk)
    PRINT '  ✓ tbStokResim tablosu oluşturuldu'
END
ELSE
BEGIN
    PRINT '  - tbStokResim tablosu zaten mevcut, eksik kolonlar kontrol ediliyor...'
    
    IF COL_LENGTH('dbo.tbStokResim','sRenk') IS NULL
    BEGIN
        ALTER TABLE dbo.tbStokResim ADD sRenk VARCHAR(10) NULL
        PRINT '    ✓ sRenk kolonu eklendi'
    END
    
    IF COL_LENGTH('dbo.tbStokResim','sBeden') IS NULL
    BEGIN
        ALTER TABLE dbo.tbStokResim ADD sBeden VARCHAR(10) NULL
        PRINT '    ✓ sBeden kolonu eklendi'
    END
    
    IF COL_LENGTH('dbo.tbStokResim','bAnaResim') IS NULL
    BEGIN
        ALTER TABLE dbo.tbStokResim ADD bAnaResim BIT NULL DEFAULT (0)
        PRINT '    ✓ bAnaResim kolonu eklendi'
    END
    
    IF COL_LENGTH('dbo.tbStokResim','bAIBulundu') IS NULL
    BEGIN
        ALTER TABLE dbo.tbStokResim ADD bAIBulundu BIT NULL DEFAULT (0)
        PRINT '    ✓ bAIBulundu kolonu eklendi'
    END
    
    IF COL_LENGTH('dbo.tbStokResim','nStokID') IS NULL
    BEGIN
        ALTER TABLE dbo.tbStokResim ADD nStokID INT NULL
        PRINT '    ✓ nStokID kolonu eklendi'
    END
END
GO

-- =====================================================================
-- BÖLÜM 4: tbStok TABLOSUNA EK KOLONLAR
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 4: tbStok Tablosuna Ek Kolonlar'
GO

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbStok')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'bAIIcerikVar')
    BEGIN
        ALTER TABLE tbStok ADD bAIIcerikVar BIT DEFAULT 0
        PRINT '  ✓ tbStok.bAIIcerikVar kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'dteAISonGuncelleme')
    BEGIN
        ALTER TABLE tbStok ADD dteAISonGuncelleme DATETIME NULL
        PRINT '  ✓ tbStok.dteAISonGuncelleme kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'sWebAciklama')
    BEGIN
        ALTER TABLE tbStok ADD sWebAciklama NVARCHAR(MAX) NULL
        PRINT '  ✓ tbStok.sWebAciklama kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'sWebBaslik')
    BEGIN
        ALTER TABLE tbStok ADD sWebBaslik NVARCHAR(200) NULL
        PRINT '  ✓ tbStok.sWebBaslik kolonu eklendi'
    END
    
    -- Soft Delete kolonları
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'bSilindi')
    BEGIN
        ALTER TABLE tbStok ADD bSilindi BIT NOT NULL DEFAULT 0
        PRINT '  ✓ tbStok.bSilindi kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStok') AND name = 'dteSilinmeTarihi')
    BEGIN
        ALTER TABLE tbStok ADD dteSilinmeTarihi DATETIME NULL
        PRINT '  ✓ tbStok.dteSilinmeTarihi kolonu eklendi'
    END
END
ELSE
    PRINT '  ! tbStok tablosu bulunamadı'
GO

-- =====================================================================
-- BÖLÜM 5: tbStokSinifi TABLOSUNA EK KOLONLAR
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 5: tbStokSinifi Tablosuna Ek Kolonlar'
GO

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbStokSinifi')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokSinifi') AND name = 'sModel')
    BEGIN
        ALTER TABLE tbStokSinifi ADD sModel NVARCHAR(50) NULL
        CREATE INDEX IX_tbStokSinifi_sModel ON tbStokSinifi(sModel)
        PRINT '  ✓ tbStokSinifi.sModel kolonu ve indexi eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokSinifi') AND name = 'bKategoriAtla')
    BEGIN
        ALTER TABLE tbStokSinifi ADD bKategoriAtla BIT DEFAULT 0 NOT NULL
        PRINT '  ✓ tbStokSinifi.bKategoriAtla kolonu eklendi'
    END
END
ELSE
    PRINT '  ! tbStokSinifi tablosu bulunamadı'
GO

-- =====================================================================
-- BÖLÜM 6: tbParamGenel TABLOSUNA EK KOLONLAR (AI ve E-Ticaret)
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 6: tbParamGenel Tablosuna Ek Kolonlar'
GO

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbParamGenel')
BEGIN
    -- AI Parametreleri
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bAIKullan')
    BEGIN
        ALTER TABLE tbParamGenel ADD bAIKullan BIT DEFAULT 1
        PRINT '  ✓ tbParamGenel.bAIKullan kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bBaslikOlustur')
    BEGIN
        ALTER TABLE tbParamGenel ADD bBaslikOlustur BIT DEFAULT 1
        PRINT '  ✓ tbParamGenel.bBaslikOlustur kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bAciklamaOlustur')
    BEGIN
        ALTER TABLE tbParamGenel ADD bAciklamaOlustur BIT DEFAULT 1
        PRINT '  ✓ tbParamGenel.bAciklamaOlustur kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bKapsamliIcerik')
    BEGIN
        ALTER TABLE tbParamGenel ADD bKapsamliIcerik BIT DEFAULT 1
        PRINT '  ✓ tbParamGenel.bKapsamliIcerik kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bTalimatOlustur')
    BEGIN
        ALTER TABLE tbParamGenel ADD bTalimatOlustur BIT DEFAULT 1
        PRINT '  ✓ tbParamGenel.bTalimatOlustur kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'bBedenTablosuOlustur')
    BEGIN
        ALTER TABLE tbParamGenel ADD bBedenTablosuOlustur BIT DEFAULT 1
        PRINT '  ✓ tbParamGenel.bBedenTablosuOlustur kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'sEmergentKey')
    BEGIN
        ALTER TABLE tbParamGenel ADD sEmergentKey NVARCHAR(500) NULL
        PRINT '  ✓ tbParamGenel.sEmergentKey kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'sOpenAIKey')
    BEGIN
        ALTER TABLE tbParamGenel ADD sOpenAIKey NVARCHAR(500) NULL
        PRINT '  ✓ tbParamGenel.sOpenAIKey kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamGenel') AND name = 'DefaultImageUrl')
    BEGIN
        ALTER TABLE tbParamGenel ADD DefaultImageUrl NVARCHAR(255) NULL
        PRINT '  ✓ tbParamGenel.DefaultImageUrl kolonu eklendi'
    END
END
ELSE
    PRINT '  ! tbParamGenel tablosu bulunamadı'
GO

-- =====================================================================
-- BÖLÜM 7: AUDIT LOG TABLOSU
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 7: Audit Log Tablosu'
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbAuditLog]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbAuditLog](
        [nAuditLogID] BIGINT IDENTITY(1,1) NOT NULL,
        [sModulAdi] NVARCHAR(50) NOT NULL,
        [sTabloAdi] NVARCHAR(100) NOT NULL,
        [nKayitID] BIGINT NULL,
        [sKayitReferans] NVARCHAR(100) NULL,
        [sIslemTipi] NVARCHAR(50) NOT NULL,
        [sIslemAciklama] NVARCHAR(500) NULL,
        [sAlanAdi] NVARCHAR(100) NULL,
        [sEskiDeger] NVARCHAR(MAX) NULL,
        [sYeniDeger] NVARCHAR(MAX) NULL,
        [sJsonData] NVARCHAR(MAX) NULL,
        [sKullaniciAdi] NVARCHAR(100) NOT NULL,
        [sWindowsKullanici] NVARCHAR(100) NULL,
        [dteIslemZamani] DATETIME NOT NULL DEFAULT GETDATE(),
        [sBilgisayarAdi] NVARCHAR(100) NULL,
        [sIPAdresi] NVARCHAR(50) NULL,
        [sMACAdres] NVARCHAR(100) NULL,
        [sUygulamaVersiyon] NVARCHAR(50) NULL,
        [bGeriAlindi] BIT NOT NULL DEFAULT 0,
        [nGeriAlanKullaniciID] INT NULL,
        [dteGeriAlmaTarihi] DATETIME NULL,
        [nIliskiliAuditID] BIGINT NULL,
        [nIslemSuresi] INT NULL,
        [sEkNotlar] NVARCHAR(500) NULL,
        CONSTRAINT [PK_tbAuditLog] PRIMARY KEY CLUSTERED ([nAuditLogID] ASC)
    )
    
    CREATE INDEX IX_tbAuditLog_ModulTarih ON tbAuditLog(sModulAdi, dteIslemZamani DESC)
    CREATE INDEX IX_tbAuditLog_KayitID ON tbAuditLog(nKayitID, sModulAdi, sTabloAdi)
    CREATE INDEX IX_tbAuditLog_Kullanici ON tbAuditLog(sKullaniciAdi, dteIslemZamani DESC)
    CREATE INDEX IX_tbAuditLog_IslemTipi ON tbAuditLog(sIslemTipi, dteIslemZamani DESC)
    
    PRINT '  ✓ tbAuditLog tablosu ve indexleri oluşturuldu'
END
ELSE
    PRINT '  - tbAuditLog tablosu zaten mevcut'
GO

-- Audit İşlem Tipleri
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbAuditIslemTipleri]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbAuditIslemTipleri](
        [nIslemTipID] INT IDENTITY(1,1) NOT NULL,
        [sIslemKodu] NVARCHAR(50) NOT NULL,
        [sIslemAdi] NVARCHAR(100) NOT NULL,
        [sAciklama] NVARCHAR(500) NULL,
        [sRenk] NVARCHAR(20) NULL,
        [nSiraNo] INT NULL,
        [bAktif] BIT NOT NULL DEFAULT 1,
        CONSTRAINT [PK_tbAuditIslemTipleri] PRIMARY KEY CLUSTERED ([nIslemTipID] ASC),
        CONSTRAINT [UK_tbAuditIslemTipleri_Kod] UNIQUE ([sIslemKodu])
    )
    PRINT '  ✓ tbAuditIslemTipleri tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbAuditIslemTipleri tablosu zaten mevcut'
GO

-- Audit Modüller
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbAuditModuller]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbAuditModuller](
        [nModulID] INT IDENTITY(1,1) NOT NULL,
        [sModulKodu] NVARCHAR(50) NOT NULL,
        [sModulAdi] NVARCHAR(100) NOT NULL,
        [sAciklama] NVARCHAR(500) NULL,
        [sAnaTabloAdi] NVARCHAR(100) NULL,
        [bLogAktif] BIT NOT NULL DEFAULT 1,
        [bDetayliLog] BIT NOT NULL DEFAULT 1,
        [nSiraNo] INT NULL,
        CONSTRAINT [PK_tbAuditModuller] PRIMARY KEY CLUSTERED ([nModulID] ASC),
        CONSTRAINT [UK_tbAuditModuller_Kod] UNIQUE ([sModulKodu])
    )
    PRINT '  ✓ tbAuditModuller tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbAuditModuller tablosu zaten mevcut'
GO

-- =====================================================================
-- BÖLÜM 8: BİLDİRİM SİSTEMİ TABLOLARI
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 8: Bildirim Sistemi Tabloları'
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbBildirimTipleri')
BEGIN
    CREATE TABLE tbBildirimTipleri (
        nTipID INT IDENTITY(1,1) PRIMARY KEY,
        sTipKodu NVARCHAR(50) NOT NULL UNIQUE,
        sTipAdi NVARCHAR(100) NOT NULL,
        sAciklama NVARCHAR(500),
        bAktif BIT DEFAULT 1,
        bEmailVarsayilan BIT DEFAULT 1,
        bSMSVarsayilan BIT DEFAULT 0,
        bWhatsAppVarsayilan BIT DEFAULT 0,
        bUygulamaVarsayilan BIT DEFAULT 1
    )
    PRINT '  ✓ tbBildirimTipleri tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbBildirimTipleri tablosu zaten mevcut'
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbBildirimLog')
BEGIN
    CREATE TABLE tbBildirimLog (
        nLogID INT IDENTITY(1,1) PRIMARY KEY,
        sTipKodu NVARCHAR(50),
        nAliciID INT,
        sAliciAdi NVARCHAR(200),
        sAliciEmail NVARCHAR(200),
        sAliciTelefon NVARCHAR(50),
        sBaslik NVARCHAR(200),
        sMesaj NVARCHAR(MAX),
        sKanal NVARCHAR(20),
        sGonderimDurum NVARCHAR(20) DEFAULT 'Bekliyor',
        bTeslimEdildi BIT DEFAULT 0,
        dteTeslimTarihi DATETIME,
        bOkundu BIT DEFAULT 0,
        dteOkunmaTarihi DATETIME,
        bOnaylandi BIT DEFAULT 0,
        dteOnayTarihi DATETIME,
        sHataMesaji NVARCHAR(500),
        sReferansID NVARCHAR(100),
        sGonderenMakine NVARCHAR(100),
        dteOlusturma DATETIME DEFAULT GETDATE()
    )
    CREATE INDEX IX_BildirimLog_Alici ON tbBildirimLog(nAliciID, bOkundu, bTeslimEdildi)
    PRINT '  ✓ tbBildirimLog tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbBildirimLog tablosu zaten mevcut'
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSistemAyar')
BEGIN
    CREATE TABLE tbSistemAyar (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sAnahtar NVARCHAR(100) NOT NULL UNIQUE,
        sDeger NVARCHAR(500),
        sAciklama NVARCHAR(500),
        sKategori NVARCHAR(50)
    )
    PRINT '  ✓ tbSistemAyar tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbSistemAyar tablosu zaten mevcut'
GO

-- =====================================================================
-- BÖLÜM 9: ONAY SİSTEMİ TABLOLARI
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 9: Onay Sistemi Tabloları'
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOnayTurleri')
BEGIN
    CREATE TABLE tbOnayTurleri (
        nOnayTurID INT IDENTITY(1,1) PRIMARY KEY,
        sOnayTurKodu NVARCHAR(50) NOT NULL UNIQUE,
        sOnayTurAdi NVARCHAR(100) NOT NULL,
        nOncelik INT DEFAULT 0,
        bAktif BIT DEFAULT 1,
        sAciklama NVARCHAR(500)
    )
    PRINT '  ✓ tbOnayTurleri tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbOnayTurleri tablosu zaten mevcut'
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOnayYetkilisi')
BEGIN
    CREATE TABLE tbOnayYetkilisi (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nOnayTurID INT NOT NULL,
        nPersonelID INT NOT NULL,
        bAktif BIT DEFAULT 1,
        dteBaslangic DATETIME DEFAULT GETDATE()
    )
    PRINT '  ✓ tbOnayYetkilisi tablosu oluşturuldu'
END
ELSE
    PRINT '  - tbOnayYetkilisi tablosu zaten mevcut'
GO

-- =====================================================================
-- BÖLÜM 10: SİPARİŞ TABLOSUNA EK KOLONLAR
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 10: tbSiparis Tablosuna Ek Kolonlar'
GO

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSiparis')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bOnaylandi')
    BEGIN
        ALTER TABLE tbSiparis ADD bOnaylandi BIT DEFAULT 0
        PRINT '  ✓ tbSiparis.bOnaylandi kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bKilitli')
    BEGIN
        ALTER TABLE tbSiparis ADD bKilitli BIT DEFAULT 0
        PRINT '  ✓ tbSiparis.bKilitli kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'nOnaylayanID')
    BEGIN
        ALTER TABLE tbSiparis ADD nOnaylayanID INT
        PRINT '  ✓ tbSiparis.nOnaylayanID kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'sDurum')
    BEGIN
        ALTER TABLE tbSiparis ADD sDurum NVARCHAR(30) DEFAULT 'Bekliyor'
        PRINT '  ✓ tbSiparis.sDurum kolonu eklendi'
    END
    
    -- Soft Delete kolonları
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bSilindi')
    BEGIN
        ALTER TABLE tbSiparis ADD bSilindi BIT NOT NULL DEFAULT 0
        PRINT '  ✓ tbSiparis.bSilindi kolonu eklendi'
    END
END
ELSE
    PRINT '  ! tbSiparis tablosu bulunamadı'
GO

-- =====================================================================
-- BÖLÜM 11: WEB SENKRONIZASYON TABLOLARI
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 11: Web Senkronizasyon Tabloları'
GO

-- products tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'products')
BEGIN
    CREATE TABLE products (
        productID VARCHAR(100) PRIMARY KEY,
        status INT NOT NULL DEFAULT 0,
        f_durum INT NOT NULL DEFAULT 0,
        updated_at DATETIME DEFAULT GETDATE()
    )
    PRINT '  ✓ products tablosu oluşturuldu'
END
ELSE
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('products') AND name = 'f_durum')
    BEGIN
        ALTER TABLE products ADD f_durum INT NOT NULL DEFAULT 0
        PRINT '  ✓ products.f_durum kolonu eklendi'
    END
END
GO

-- product_images tablosu
-- NOT: Mevcut tablonuz varchar(64) ise bu script çalışmaz, tablo zaten var demektir
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'product_images')
BEGIN
    CREATE TABLE product_images (
        productID VARCHAR(64) NOT NULL PRIMARY KEY,
        img_count INT NOT NULL DEFAULT 0,
        status INT NOT NULL DEFAULT 0,
        updated_at DATETIME DEFAULT GETDATE()
    )
    PRINT '  ✓ product_images tablosu oluşturuldu'
END
GO

-- tbWebGuncel tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbWebGuncel')
BEGIN
    CREATE TABLE tbWebGuncel (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        tbStokS INT DEFAULT 0,
        tbStokResmiS INT DEFAULT 0,
        sonGuncelleme DATETIME DEFAULT GETDATE()
    )
    INSERT INTO tbWebGuncel (tbStokS, tbStokResmiS) VALUES (0, 0)
    PRINT '  ✓ tbWebGuncel tablosu oluşturuldu'
END
GO

-- =====================================================================
-- BÖLÜM 12: PERSONEL TABLOSUNA EK KOLONLAR
-- =====================================================================
PRINT ''
PRINT '▶ BÖLÜM 12: APERSONEL Tablosuna Ek Kolonlar'
GO

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'APERSONEL')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bYonetici')
    BEGIN
        ALTER TABLE APERSONEL ADD bYonetici BIT DEFAULT 0
        PRINT '  ✓ APERSONEL.bYonetici kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'sWhatsApp')
    BEGIN
        ALTER TABLE APERSONEL ADD sWhatsApp NVARCHAR(50)
        PRINT '  ✓ APERSONEL.sWhatsApp kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'sEmail')
    BEGIN
        ALTER TABLE APERSONEL ADD sEmail NVARCHAR(200)
        PRINT '  ✓ APERSONEL.sEmail kolonu eklendi'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bEmailBildirimAl')
    BEGIN
        ALTER TABLE APERSONEL ADD bEmailBildirimAl BIT DEFAULT 1
        PRINT '  ✓ APERSONEL.bEmailBildirimAl kolonu eklendi'
    END
END
GO

-- =====================================================================
-- ÖZET
-- =====================================================================
PRINT ''
PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     MASTER KURULUM TAMAMLANDI!                               ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''
PRINT 'Oluşturulan/Güncellenen Tablolar:'
PRINT '  - tbParamETicaret (E-ticaret parametreleri)'
PRINT '  - tbStokAIIcerik (AI içerikler)'
PRINT '  - tbStokResim (Stok resimleri)'
PRINT '  - tbAuditLog, tbAuditIslemTipleri, tbAuditModuller'
PRINT '  - tbBildirimTipleri, tbBildirimLog, tbSistemAyar'
PRINT '  - tbOnayTurleri, tbOnayYetkilisi'
PRINT '  - products, product_images, tbWebGuncel'
PRINT ''
PRINT 'Güncellenen Mevcut Tablolar:'
PRINT '  - tbStok (AI ve soft delete kolonları)'
PRINT '  - tbStokSinifi (sModel, bKategoriAtla)'
PRINT '  - tbParamGenel (AI parametreleri, DefaultImageUrl)'
PRINT '  - tbSiparis (onay ve soft delete kolonları)'
PRINT '  - APERSONEL (bildirim kolonları)'
PRINT ''
PRINT 'Sonraki adım: 02_STORED_PROCEDURES.sql'
GO
