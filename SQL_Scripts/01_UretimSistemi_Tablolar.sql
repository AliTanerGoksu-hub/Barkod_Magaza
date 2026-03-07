-- =============================================
-- URETIM VE SIPARIS ONAY SISTEMI - TABLO YAPISI
-- Bu scripti SQL Server Management Studio'da calistirin
-- =============================================

-- 1. Uretim Asamalari Tablo (Kesim, Dikim, Kalite Kontrol vb.)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimAsamalar')
BEGIN
    CREATE TABLE tbUretimAsamalar (
        nAsamaID INT IDENTITY(1,1) PRIMARY KEY,
        sAsamaKodu NVARCHAR(20) NOT NULL,
        sAsamaAdi NVARCHAR(100) NOT NULL,
        nSiraNo INT DEFAULT 0,
        bAktif BIT DEFAULT 1,
        nOnayGerekli BIT DEFAULT 1,
        sAciklama NVARCHAR(500),
        dteKayitTarihi DATETIME DEFAULT GETDATE(),
        sKullaniciAdi NVARCHAR(50)
    )
    PRINT 'tbUretimAsamalar tablosu olusturuldu.'
END
ELSE
    PRINT 'tbUretimAsamalar tablosu zaten mevcut.'
GO

-- 2. Asama Yetkililer Tablosu (Her asama icin kim onaylayacak)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimAsamaYetkililer')
BEGIN
    CREATE TABLE tbUretimAsamaYetkililer (
        nYetkiliID INT IDENTITY(1,1) PRIMARY KEY,
        nAsamaID INT NOT NULL,
        nPersonelID INT NOT NULL,
        bAktif BIT DEFAULT 1,
        dteKayitTarihi DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (nAsamaID) REFERENCES tbUretimAsamalar(nAsamaID)
    )
    PRINT 'tbUretimAsamaYetkililer tablosu olusturuldu.'
END
ELSE
    PRINT 'tbUretimAsamaYetkililer tablosu zaten mevcut.'
GO

-- 3. Uretim Emri Asamalari (Her uretim emrinin hangi asamada oldugu)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimEmriAsamalar')
BEGIN
    CREATE TABLE tbUretimEmriAsamalar (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriID INT NOT NULL,
        nAsamaID INT NOT NULL,
        sDurum NVARCHAR(20) DEFAULT 'Bekliyor', -- Bekliyor, Devam, Tamamlandi, Iptal
        dteBaslangic DATETIME,
        dteBitis DATETIME,
        nOnaylayanID INT,
        dteOnayTarihi DATETIME,
        sAciklama NVARCHAR(500),
        lPlanlananMiktar DECIMAL(18,4) DEFAULT 0,
        lGerceklesenMiktar DECIMAL(18,4) DEFAULT 0,
        lFireMiktar DECIMAL(18,4) DEFAULT 0,
        dteKayitTarihi DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (nAsamaID) REFERENCES tbUretimAsamalar(nAsamaID)
    )
    PRINT 'tbUretimEmriAsamalar tablosu olusturuldu.'
END
ELSE
    PRINT 'tbUretimEmriAsamalar tablosu zaten mevcut.'
GO

-- 4. Gecikme Kayitlari Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimGecikme')
BEGIN
    CREATE TABLE tbUretimGecikme (
        nGecikmeID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriID INT NOT NULL,
        nAsamaID INT,
        sGecikmeNedeni NVARCHAR(500),
        nGecikmeSuresi INT DEFAULT 0, -- Dakika cinsinden
        dteGecikmeBaslangic DATETIME,
        dteGecikmeBitis DATETIME,
        nKaydedenID INT,
        dteKayitTarihi DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbUretimGecikme tablosu olusturuldu.'
END
ELSE
    PRINT 'tbUretimGecikme tablosu zaten mevcut.'
GO

-- 5. Fire Kayitlari Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimFire')
BEGIN
    CREATE TABLE tbUretimFire (
        nFireID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriID INT NOT NULL,
        nAsamaID INT,
        nStokID INT,
        lFireMiktar DECIMAL(18,4) DEFAULT 0,
        sFireNedeni NVARCHAR(500),
        nKaydedenID INT,
        dteKayitTarihi DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbUretimFire tablosu olusturuldu.'
END
ELSE
    PRINT 'tbUretimFire tablosu zaten mevcut.'
GO

-- 6. Satin Alma Talepleri Tablosu (Eksik hammadde icin)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSatinAlmaTalep')
BEGIN
    CREATE TABLE tbSatinAlmaTalep (
        nTalepID INT IDENTITY(1,1) PRIMARY KEY,
        nSiparisID INT,
        nUretimEmriID INT,
        nStokID INT NOT NULL,
        lTalepMiktar DECIMAL(18,4) DEFAULT 0,
        sDurum NVARCHAR(20) DEFAULT 'Bekliyor', -- Bekliyor, Onaylandi, Reddedildi, Tamamlandi
        dteTalepTarihi DATETIME DEFAULT GETDATE(),
        nTalepEdenID INT,
        nOnaylayanID INT,
        dteOnayTarihi DATETIME,
        sAciklama NVARCHAR(500)
    )
    PRINT 'tbSatinAlmaTalep tablosu olusturuldu.'
END
ELSE
    PRINT 'tbSatinAlmaTalep tablosu zaten mevcut.'
GO

-- 7. TBLUREURETIM tablosuna yeni kolonlar ekle (eger yoksa)
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nMevcutAsama')
BEGIN
    ALTER TABLE TBLUREURETIM ADD nMevcutAsama INT DEFAULT 0
    PRINT 'TBLUREURETIM tablosuna nMevcutAsama kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nSiparisID')
BEGIN
    ALTER TABLE TBLUREURETIM ADD nSiparisID INT
    PRINT 'TBLUREURETIM tablosuna nSiparisID kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dtePlanlananBitis')
BEGIN
    ALTER TABLE TBLUREURETIM ADD dtePlanlananBitis DATETIME
    PRINT 'TBLUREURETIM tablosuna dtePlanlananBitis kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dteGercekBitis')
BEGIN
    ALTER TABLE TBLUREURETIM ADD dteGercekBitis DATETIME
    PRINT 'TBLUREURETIM tablosuna dteGercekBitis kolonu eklendi.'
END
GO

-- 8. Varsayilan Uretim Asamalarini Ekle
IF NOT EXISTS (SELECT * FROM tbUretimAsamalar WHERE sAsamaKodu = 'HAMMADDE')
BEGIN
    INSERT INTO tbUretimAsamalar (sAsamaKodu, sAsamaAdi, nSiraNo, bAktif, nOnayGerekli, sAciklama)
    VALUES 
    ('HAMMADDE', 'Hammadde Hazirlama', 1, 1, 1, 'Uretim icin gerekli hammaddelerin hazirlanmasi'),
    ('KESIM', 'Kesim', 2, 1, 1, 'Malzeme kesim islemi'),
    ('DIKIM', 'Dikim', 3, 1, 1, 'Dikim islemi'),
    ('MONTAJ', 'Montaj', 4, 1, 1, 'Montaj islemi'),
    ('KALITE', 'Kalite Kontrol', 5, 1, 1, 'Kalite kontrol islemi'),
    ('PAKETLEME', 'Paketleme', 6, 1, 0, 'Paketleme islemi'),
    ('SEVK', 'Sevke Hazir', 7, 1, 0, 'Sevke hazir')
    PRINT 'Varsayilan uretim asamalari eklendi.'
END
GO

PRINT '=============================================';
PRINT 'URETIM SISTEMI TABLOLARI BASARIYLA OLUSTURULDU';
PRINT '=============================================';
