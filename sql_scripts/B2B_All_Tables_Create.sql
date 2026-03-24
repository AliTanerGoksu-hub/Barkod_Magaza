-- =============================================
-- B2B Portal - Complete Database Setup Script
-- Version: 4.0
-- Tarih: Subat 2026
-- Aciklama: Tum B2B tablolarini ve kolon guncellemelerini icerir
-- NOT: Bu script guvenli bir sekilde tekrar tekrar calistirilabilir (IF NOT EXISTS kontrolleri)
-- =============================================

PRINT '=============================================';
PRINT 'B2B Portal Database Setup v4.0 Baslatiliyor...';
PRINT '=============================================';
PRINT '';

-- =============================================
-- 1. tbB2BParametre - B2B Genel Parametre Tablosu
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BParametre')
BEGIN
    CREATE TABLE tbB2BParametre (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        bBirimSecimi BIT DEFAULT 0,
        bMiktarGirisi BIT DEFAULT 0,
        bRenkSecimi BIT DEFAULT 0,
        bBedenSecimi BIT DEFAULT 0,
        bVaryantSecimi BIT DEFAULT 0,
        bStokKontrol BIT DEFAULT 0,
        bFiyatGoster BIT DEFAULT 1,
        bStokGoster BIT DEFAULT 0,
        bIskontoGoster BIT DEFAULT 0,
        bMarkaSliderGoster BIT DEFAULT 0,
        nMarkaSinifNo INT DEFAULT 2,
        bKatalogGruplama BIT DEFAULT 0,
        bSepetiKaydet BIT DEFAULT 0,
        nMinSiparisTutar DECIMAL(18,2) DEFAULT 0,
        sVarsayilanBirim NVARCHAR(20) DEFAULT 'Adet',
        dtGuncelleme DATETIME DEFAULT GETDATE()
    );
    INSERT INTO tbB2BParametre DEFAULT VALUES;
    PRINT ' [+] tbB2BParametre tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BParametre tablosu zaten mevcut.';
GO

-- =============================================
-- 2. tbB2BGruplamaSinifi - Katalog Gruplama Siniflari
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BGruplamaSinifi')
BEGIN
    CREATE TABLE tbB2BGruplamaSinifi (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nSinifNo INT NOT NULL,
        sBaslik NVARCHAR(50),
        bAktif BIT DEFAULT 1,
        nSira INT DEFAULT 0,
        bSliderGoster BIT DEFAULT 0,
        dtOlusturma DATETIME DEFAULT GETDATE(),
        CONSTRAINT UQ_B2BGruplamaSinifi_SinifNo UNIQUE (nSinifNo),
        CONSTRAINT CK_B2BGruplamaSinifi_SinifNo CHECK (nSinifNo >= 1 AND nSinifNo <= 10)
    );
    INSERT INTO tbB2BGruplamaSinifi (nSinifNo, sBaslik, bAktif, nSira, bSliderGoster)
    VALUES (2, 'Marka', 0, 1, 0);
    PRINT ' [+] tbB2BGruplamaSinifi tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BGruplamaSinifi tablosu zaten mevcut.';
GO

-- =============================================
-- 3. tbB2BCariGorunumAyari - Musteri Bazli Gorunum Ayarlari
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BCariGorunumAyari')
BEGIN
    CREATE TABLE tbB2BCariGorunumAyari (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sCariKodu NVARCHAR(50) NOT NULL,
        bUrunBarkodGoster BIT DEFAULT 0,
        bUrunStokKoduGoster BIT DEFAULT 0,
        bUrunKategoriGoster BIT DEFAULT 0,
        bUrunMarkaGoster BIT DEFAULT 0,
        bUrunStokMiktariGoster BIT DEFAULT 0,
        bUrunFiyatGoster BIT DEFAULT 1,
        bUrunResimGoster BIT DEFAULT 1,
        bSiparisBarkodGoster BIT DEFAULT 0,
        bSiparisStokKoduGoster BIT DEFAULT 0,
        bSiparisResimGoster BIT DEFAULT 0,
        bFaturaBarkodGoster BIT DEFAULT 0,
        bFaturaStokKoduGoster BIT DEFAULT 0,
        bFaturaResimGoster BIT DEFAULT 0,
        bSepetBarkodGoster BIT DEFAULT 0,
        bSepetStokKoduGoster BIT DEFAULT 0,
        bSepetResimGoster BIT DEFAULT 1,
        dtOlusturma DATETIME DEFAULT GETDATE(),
        dtGuncelleme DATETIME DEFAULT GETDATE(),
        CONSTRAINT UQ_B2BCariGorunumAyari_CariKodu UNIQUE (sCariKodu)
    );
    PRINT ' [+] tbB2BCariGorunumAyari tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BCariGorunumAyari tablosu zaten mevcut.';
GO

-- =============================================
-- 4. tbB2BSepet - Kalici Sepet Tablosu
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BSepet')
BEGIN
    CREATE TABLE tbB2BSepet (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sCariKodu NVARCHAR(50) NOT NULL,
        sStokKodu NVARCHAR(50) NOT NULL,
        sStokAdi NVARCHAR(200),
        nMiktar INT DEFAULT 1,
        sBirimCinsi NVARCHAR(20) DEFAULT 'Adet',
        lBirimOran DECIMAL(18,4) DEFAULT 1,
        sRenk NVARCHAR(50),
        sBeden NVARCHAR(50),
        lBirimFiyat DECIMAL(18,4) DEFAULT 0,
        sResimUrl NVARCHAR(500),
        sNot NVARCHAR(500),
        dtEkleme DATETIME DEFAULT GETDATE(),
        dtGuncelleme DATETIME DEFAULT GETDATE()
    );
    CREATE INDEX IX_B2BSepet_CariKodu ON tbB2BSepet(sCariKodu);
    PRINT ' [+] tbB2BSepet tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BSepet tablosu zaten mevcut.';
GO

-- =============================================
-- 5. tbB2BSmsDogrulama - SMS Dogrulama Kodlari
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BSmsDogrulama')
BEGIN
    CREATE TABLE tbB2BSmsDogrulama (
        nDogrulamaID INT IDENTITY(1,1) PRIMARY KEY,
        sPersonelKodu NVARCHAR(100) NOT NULL,
        sKod NVARCHAR(10) NOT NULL,
        sTelefon NVARCHAR(20),
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteSonGecerlilik DATETIME,
        bKullanildi BIT DEFAULT 0
    );
    CREATE INDEX IX_B2BSmsDogrulama_PersonelKodu ON tbB2BSmsDogrulama(sPersonelKodu);
    PRINT ' [+] tbB2BSmsDogrulama tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BSmsDogrulama tablosu zaten mevcut.';
GO

-- =============================================
-- 6. tbB2BSifreSifirlama - Sifre Sifirlama Tokenlari
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BSifreSifirlama')
BEGIN
    CREATE TABLE tbB2BSifreSifirlama (
        nTokenID INT IDENTITY(1,1) PRIMARY KEY,
        sPersonelKodu NVARCHAR(100) NOT NULL,
        sToken NVARCHAR(100) NOT NULL,
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteSonGecerlilik DATETIME,
        bKullanildi BIT DEFAULT 0
    );
    CREATE INDEX IX_B2BSifreSifirlama_Token ON tbB2BSifreSifirlama(sToken);
    CREATE INDEX IX_B2BSifreSifirlama_PersonelKodu ON tbB2BSifreSifirlama(sPersonelKodu);
    PRINT ' [+] tbB2BSifreSifirlama tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BSifreSifirlama tablosu zaten mevcut.';
GO

-- =============================================
-- 7. tbB2BPendingOrders - Bekleyen Odemeler (PayTR)
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BPendingOrders')
BEGIN
    CREATE TABLE tbB2BPendingOrders (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sMerchantOid NVARCHAR(100) NOT NULL,
        sCariKodu NVARCHAR(50),
        lTutar DECIMAL(18,2),
        sKalemlerJson NVARCHAR(MAX),
        bOdendi BIT DEFAULT 0,
        sOdemeDurumu NVARCHAR(50) DEFAULT 'Bekliyor',
        sHataMesaji NVARCHAR(500),
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteOdemeTarihi DATETIME
    );
    CREATE INDEX IX_B2BPendingOrders_MerchantOid ON tbB2BPendingOrders(sMerchantOid);
    CREATE INDEX IX_B2BPendingOrders_CariKodu ON tbB2BPendingOrders(sCariKodu);
    PRINT ' [+] tbB2BPendingOrders tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BPendingOrders tablosu zaten mevcut.';
GO

-- =============================================
-- 8. tbB2BGirisKodu - Giris Kodlari
-- =============================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbB2BGirisKodu')
BEGIN
    CREATE TABLE tbB2BGirisKodu (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sKullaniciAdi NVARCHAR(100) NOT NULL,
        sKod NVARCHAR(10) NOT NULL,
        sTelefon NVARCHAR(20),
        dtOlusturma DATETIME DEFAULT GETDATE(),
        dtGecerlilik DATETIME,
        bKullanildi BIT DEFAULT 0
    );
    CREATE INDEX IX_B2BGirisKodu_KullaniciAdi ON tbB2BGirisKodu(sKullaniciAdi);
    PRINT ' [+] tbB2BGirisKodu tablosu olusturuldu.';
END
ELSE
    PRINT ' [=] tbB2BGirisKodu tablosu zaten mevcut.';
GO

PRINT '';
PRINT '=============================================';
PRINT 'B2B Portal Database Setup v4.0 Tamamlandi!';
PRINT '=============================================';
GO
