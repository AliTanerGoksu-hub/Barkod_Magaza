-- =============================================
-- PARAMETRIK ONAY SISTEMI - DUZELTILMIS VERSIYON
-- Mevcut veritabani yapisiyla uyumlu
-- =============================================

PRINT '=============================================';
PRINT 'PARAMETRIK ONAY SISTEMI KURULUMU BASLIYOR (v2)';
PRINT '=============================================';

-- =============================================
-- 1. ONAY TURLERI TABLOSU (Zaten olusturulmus olabilir)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOnayTurleri')
BEGIN
    CREATE TABLE tbOnayTurleri (
        nOnayTurID INT IDENTITY(1,1) PRIMARY KEY,
        sOnayTurKodu NVARCHAR(50) NOT NULL,
        sOnayTurAdi NVARCHAR(100) NOT NULL,
        nOncelik INT DEFAULT 0,
        bAktif BIT DEFAULT 1,
        sAciklama NVARCHAR(500)
    )
    PRINT 'tbOnayTurleri tablosu olusturuldu.'
    
    INSERT INTO tbOnayTurleri (sOnayTurKodu, sOnayTurAdi, nOncelik, sAciklama) VALUES
    ('URETIM_YETKILISI', 'Uretim Yetkilisi', 1, 'Uretim hatti sorumlusu'),
    ('KALITE_KONTROL', 'Kalite Kontrol', 2, 'Kalite kontrol sorumlusu'),
    ('FIRMA_YETKILISI', 'Firma Yetkilisi', 3, 'Sube/Fabrika muduru'),
    ('YONETICI', 'Ust Yonetici', 4, 'Genel mudur veya yardimcisi')
    PRINT 'Varsayilan onay turleri eklendi.'
END
GO

-- =============================================
-- 2. tbUretimAsamaTanim - Parametrik onay kolonlari
-- Once tablonun var olup olmadigini kontrol et
-- =============================================
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimAsamaTanim')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbUretimAsamaTanim') AND name = 'nGerekliOnay')
    BEGIN
        ALTER TABLE tbUretimAsamaTanim ADD nGerekliOnay INT DEFAULT 1
        PRINT 'tbUretimAsamaTanim.nGerekliOnay kolonu eklendi.'
    END

    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbUretimAsamaTanim') AND name = 'sOnayTurleri')
    BEGIN
        ALTER TABLE tbUretimAsamaTanim ADD sOnayTurleri NVARCHAR(500) DEFAULT 'URETIM_YETKILISI'
        PRINT 'tbUretimAsamaTanim.sOnayTurleri kolonu eklendi.'
    END
END
ELSE
BEGIN
    -- Tablo yoksa olustur
    CREATE TABLE tbUretimAsamaTanim (
        nAsamaID INT IDENTITY(1,1) PRIMARY KEY,
        sAsamaKodu NVARCHAR(50),
        sAsamaAdi NVARCHAR(100) NOT NULL,
        nSiraNo INT DEFAULT 0,
        bAktif BIT DEFAULT 1,
        nStandartSure INT DEFAULT 0,
        lStandartFireOrani DECIMAL(10,2) DEFAULT 0,
        nGerekliOnay INT DEFAULT 1,
        sOnayTurleri NVARCHAR(500) DEFAULT 'URETIM_YETKILISI',
        sAciklama NVARCHAR(500)
    )
    PRINT 'tbUretimAsamaTanim tablosu olusturuldu.'
    
    INSERT INTO tbUretimAsamaTanim (sAsamaKodu, sAsamaAdi, nSiraNo, nGerekliOnay, sOnayTurleri) VALUES
    ('KESIM', 'Kesim', 1, 1, 'URETIM_YETKILISI'),
    ('PRES', 'Pres', 2, 1, 'URETIM_YETKILISI'),
    ('KAYNAK', 'Kaynak', 3, 1, 'URETIM_YETKILISI'),
    ('MONTAJ', 'Montaj', 4, 1, 'URETIM_YETKILISI,KALITE_KONTROL'),
    ('PAKETLEME', 'Paketleme', 5, 2, 'KALITE_KONTROL,FIRMA_YETKILISI')
    PRINT 'Varsayilan uretim asamalari eklendi.'
END
GO

-- =============================================
-- 3. tbUretimEmriAsama - Uretim emri asamalari
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimEmriAsama')
BEGIN
    CREATE TABLE tbUretimEmriAsama (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriID INT NOT NULL,
        nAsamaID INT NOT NULL,
        sAsamaAdi NVARCHAR(100),
        sDurum NVARCHAR(20) DEFAULT 'Bekliyor',
        dteBaslangic DATETIME,
        dteBitis DATETIME,
        nPlanlananSure INT DEFAULT 0,
        nGerceklesenSure INT DEFAULT 0,
        lPlanlananMiktar DECIMAL(18,4) DEFAULT 0,
        lGerceklesenMiktar DECIMAL(18,4) DEFAULT 0,
        lFireMiktar DECIMAL(18,4) DEFAULT 0,
        sAciklama NVARCHAR(500)
    )
    PRINT 'tbUretimEmriAsama tablosu olusturuldu.'
END
GO

-- =============================================
-- 4. TBLUREURETIM - nMevcutAsamaID kolonu
-- =============================================
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREURETIM')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nMevcutAsamaID')
    BEGIN
        ALTER TABLE TBLUREURETIM ADD nMevcutAsamaID INT
        PRINT 'TBLUREURETIM.nMevcutAsamaID kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dtePlanlananBaslangic')
    BEGIN
        ALTER TABLE TBLUREURETIM ADD dtePlanlananBaslangic DATETIME
        PRINT 'TBLUREURETIM.dtePlanlananBaslangic kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dteGercekBitis')
    BEGIN
        ALTER TABLE TBLUREURETIM ADD dteGercekBitis DATETIME
        PRINT 'TBLUREURETIM.dteGercekBitis kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nSiparisID')
    BEGIN
        ALTER TABLE TBLUREURETIM ADD nSiparisID INT
        PRINT 'TBLUREURETIM.nSiparisID kolonu eklendi.'
    END
END
GO

-- =============================================
-- 5. tbUretimEmriAsamaOnaylar - Onay kayitlari (Zaten olusturulmus olabilir)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimEmriAsamaOnaylar')
BEGIN
    CREATE TABLE tbUretimEmriAsamaOnaylar (
        nOnayID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriAsamaID INT NOT NULL,
        nUretimEmriID INT NOT NULL,
        nAsamaID INT NOT NULL,
        nOnayTurID INT NOT NULL,
        nOnayNo INT DEFAULT 1,
        nOnaylayanID INT,
        sOnayDurum NVARCHAR(20) DEFAULT 'Bekliyor',
        dteOnayTarihi DATETIME,
        sAciklama NVARCHAR(500),
        dteTalepTarihi DATETIME DEFAULT GETDATE(),
        bBildirimGonderildi BIT DEFAULT 0,
        dteBildirimTarihi DATETIME
    )
    PRINT 'tbUretimEmriAsamaOnaylar tablosu olusturuldu.'
    
    CREATE INDEX IX_UretimOnay_Bekleyen ON tbUretimEmriAsamaOnaylar(sOnayDurum, nOnaylayanID)
END
GO

-- =============================================
-- 6. tbOnayYetkilisi - Onay yetkilisi eslestirme (Zaten olusturulmus olabilir)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOnayYetkilisi')
BEGIN
    CREATE TABLE tbOnayYetkilisi (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nOnayTurID INT NOT NULL,
        nPersonelID INT NOT NULL,
        nAsamaID INT,
        bAktif BIT DEFAULT 1,
        dteBaslangic DATETIME DEFAULT GETDATE(),
        dteBitis DATETIME
    )
    PRINT 'tbOnayYetkilisi tablosu olusturuldu.'
END
GO

-- =============================================
-- 7. tbOtomatikSiparis - Satin alma siparisi tablosu
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOtomatikSiparis')
BEGIN
    CREATE TABLE tbOtomatikSiparis (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nAlinanSiparisID INT,
        nStokID INT NOT NULL,
        nTedarikciID INT,
        lTalepMiktar DECIMAL(18,4) DEFAULT 0,
        lBirimFiyat DECIMAL(18,4) DEFAULT 0,
        sDurum NVARCHAR(30) DEFAULT 'OnayBekliyor',
        nTalepEdenID INT,
        nOnaylayanID INT,
        sSeciliTedarikci NVARCHAR(200),
        nGerekliOnay INT DEFAULT 1,
        nMevcutOnay INT DEFAULT 0,
        dteKayit DATETIME DEFAULT GETDATE(),
        dteOnay DATETIME,
        sAciklama NVARCHAR(500)
    )
    PRINT 'tbOtomatikSiparis tablosu olusturuldu.'
END
ELSE
BEGIN
    -- Eksik kolonlari ekle
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'nGerekliOnay')
        ALTER TABLE tbOtomatikSiparis ADD nGerekliOnay INT DEFAULT 1
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'nMevcutOnay')
        ALTER TABLE tbOtomatikSiparis ADD nMevcutOnay INT DEFAULT 0
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'sSeciliTedarikci')
        ALTER TABLE tbOtomatikSiparis ADD sSeciliTedarikci NVARCHAR(200)
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'dteKayit')
        ALTER TABLE tbOtomatikSiparis ADD dteKayit DATETIME DEFAULT GETDATE()
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'nTalepEdenID')
        ALTER TABLE tbOtomatikSiparis ADD nTalepEdenID INT
    PRINT 'tbOtomatikSiparis tablosuna eksik kolonlar eklendi.'
END
GO

-- =============================================
-- 8. VIEW: Bekleyen Onaylar (APERSONEL uyumlu)
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_BekleyenOnaylar')
    DROP VIEW vw_BekleyenOnaylar
GO

CREATE VIEW vw_BekleyenOnaylar AS
SELECT 
    o.nOnayID,
    o.nUretimEmriID,
    u.EVRAKNO,
    a.sAsamaAdi,
    t.sOnayTurAdi,
    o.nOnayNo,
    o.sOnayDurum,
    o.dteTalepTarihi,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    u.MIKTAR
FROM tbUretimEmriAsamaOnaylar o
INNER JOIN tbUretimAsamaTanim a ON o.nAsamaID = a.nAsamaID
INNER JOIN tbOnayTurleri t ON o.nOnayTurID = t.nOnayTurID
INNER JOIN TBLUREURETIM u ON o.nUretimEmriID = u.IND OR o.nUretimEmriID = u.EVRAKNO
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
WHERE o.sOnayDurum = 'Bekliyor'
GO
PRINT 'vw_BekleyenOnaylar view olusturuldu.'

-- =============================================
-- 9. VIEW: Tedarikci Secenekleri (tbStokFisiMaster kullanarak)
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_TedarikciSecenekleri')
    DROP VIEW vw_TedarikciSecenekleri
GO

CREATE VIEW vw_TedarikciSecenekleri AS
SELECT 
    d.nStokID,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    f.nFirmaID,
    f.sKodu AS TedarikciKodu,
    f.sAciklama AS TedarikciAdi,
    MAX(sf.dteFisTarihi) AS SonAlimTarihi,
    SUM(d.lGirisMiktar1) AS ToplamAlinanMiktar,
    COUNT(DISTINCT sf.nStokFisiID) AS AlimSayisi,
    AVG(d.lGirisFiyat) AS OrtalamaFiyat,
    MAX(d.lGirisFiyat) AS SonFiyat
FROM tbStokFisiDetayi d
INNER JOIN tbStokFisiMaster sf ON d.nStokFisiID = sf.nStokFisiID
INNER JOIN tbFirma f ON sf.nFirmaID = f.nFirmaID
INNER JOIN tbStok s ON d.nStokID = s.nStokID
WHERE sf.sFisTipi IN ('AF', 'AI', '01', '02')
AND d.lGirisMiktar1 > 0
GROUP BY d.nStokID, s.sKodu, s.sAciklama, f.nFirmaID, f.sKodu, f.sAciklama
GO
PRINT 'vw_TedarikciSecenekleri view olusturuldu (tbStokFisiMaster ile).'

-- =============================================
-- 10. tbSiparis - Onay ve kilitleme kolonlari
-- =============================================
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSiparis')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bOnaylandi')
    BEGIN
        ALTER TABLE tbSiparis ADD bOnaylandi BIT DEFAULT 0
        PRINT 'tbSiparis.bOnaylandi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bKilitli')
    BEGIN
        ALTER TABLE tbSiparis ADD bKilitli BIT DEFAULT 0
        PRINT 'tbSiparis.bKilitli kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'nOnaylayanID')
    BEGIN
        ALTER TABLE tbSiparis ADD nOnaylayanID INT
        PRINT 'tbSiparis.nOnaylayanID kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'dteOnayTarihi')
    BEGIN
        ALTER TABLE tbSiparis ADD dteOnayTarihi DATETIME
        PRINT 'tbSiparis.dteOnayTarihi kolonu eklendi.'
    END
END
GO

PRINT '';
PRINT '=============================================';
PRINT 'PARAMETRIK ONAY SISTEMI KURULUMU TAMAMLANDI (v2)';
PRINT '=============================================';
PRINT '';
PRINT 'Onemli: Simdi 06_SureFire_Raporlama.sql dosyasini calistirin.';
