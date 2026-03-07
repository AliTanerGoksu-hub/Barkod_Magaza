-- =============================================
-- PARAMETRIK ONAY SISTEMI - TAM KURULUM
-- Her asama icin farkli onay sayisi ve onay turleri
-- =============================================

PRINT '=============================================';
PRINT 'PARAMETRIK ONAY SISTEMI KURULUMU BASLIYOR';
PRINT '=============================================';

-- =============================================
-- 1. ONAY TURLERI TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOnayTurleri')
BEGIN
    CREATE TABLE tbOnayTurleri (
        nOnayTurID INT IDENTITY(1,1) PRIMARY KEY,
        sOnayTurKodu NVARCHAR(50) NOT NULL,      -- URETIM_YETKILISI, FIRMA_YETKILISI, YONETICI
        sOnayTurAdi NVARCHAR(100) NOT NULL,
        nOncelik INT DEFAULT 0,                   -- Onay sirasi (dusuk=once)
        bAktif BIT DEFAULT 1,
        sAciklama NVARCHAR(500)
    )
    PRINT 'tbOnayTurleri tablosu olusturuldu.'
    
    -- Varsayilan onay turleri
    INSERT INTO tbOnayTurleri (sOnayTurKodu, sOnayTurAdi, nOncelik, sAciklama) VALUES
    ('URETIM_YETKILISI', 'Uretim Yetkilisi', 1, 'Uretim hatti sorumlusu'),
    ('KALITE_KONTROL', 'Kalite Kontrol', 2, 'Kalite kontrol sorumlusu'),
    ('FIRMA_YETKILISI', 'Firma Yetkilisi', 3, 'Sube/Fabrika muduru'),
    ('YONETICI', 'Ust Yonetici', 4, 'Genel mudur veya yardimcisi')
    PRINT 'Varsayilan onay turleri eklendi.'
END
GO

-- =============================================
-- 2. tbUretimAsamaTanim TABLOSUNA ONAY KOLONLARI EKLE
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbUretimAsamaTanim') AND name = 'nGerekliOnay')
BEGIN
    ALTER TABLE tbUretimAsamaTanim ADD nGerekliOnay INT DEFAULT 1  -- Kac onay gerekli (0=onay gerekmez)
    PRINT 'tbUretimAsamaTanim tablosuna nGerekliOnay kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbUretimAsamaTanim') AND name = 'sOnayTurleri')
BEGIN
    ALTER TABLE tbUretimAsamaTanim ADD sOnayTurleri NVARCHAR(500) DEFAULT ''  -- Virgul ile ayrilmis: URETIM_YETKILISI,FIRMA_YETKILISI
    PRINT 'tbUretimAsamaTanim tablosuna sOnayTurleri kolonu eklendi.'
END

-- Varsayilan degerleri guncelle
UPDATE tbUretimAsamaTanim SET nGerekliOnay = 1, sOnayTurleri = 'URETIM_YETKILISI' WHERE sOnayTurleri IS NULL OR sOnayTurleri = ''
GO

-- =============================================
-- 3. ASAMA ONAYLARI TABLOSU (Her onay icin ayri kayit)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimEmriAsamaOnaylar')
BEGIN
    CREATE TABLE tbUretimEmriAsamaOnaylar (
        nOnayID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriAsamaID INT NOT NULL,          -- tbUretimEmriAsama.nID
        nUretimEmriID INT NOT NULL,
        nAsamaID INT NOT NULL,
        nOnayTurID INT NOT NULL,                  -- tbOnayTurleri.nOnayTurID
        nOnayNo INT DEFAULT 1,                    -- 1. onay, 2. onay, 3. onay
        nOnaylayanID INT,                         -- APERSONEL.nKullaniciID
        sOnayDurum NVARCHAR(20) DEFAULT 'Bekliyor', -- Bekliyor, Onaylandi, Reddedildi
        dteOnayTarihi DATETIME,
        sAciklama NVARCHAR(500),
        dteTalepTarihi DATETIME DEFAULT GETDATE(),
        bBildirimGonderildi BIT DEFAULT 0,
        dteBildirimTarihi DATETIME,
        FOREIGN KEY (nAsamaID) REFERENCES tbUretimAsamaTanim(nAsamaID),
        FOREIGN KEY (nOnayTurID) REFERENCES tbOnayTurleri(nOnayTurID)
    )
    PRINT 'tbUretimEmriAsamaOnaylar tablosu olusturuldu.'
    
    CREATE INDEX IX_UretimOnay_Bekleyen ON tbUretimEmriAsamaOnaylar(sOnayDurum, nOnaylayanID)
    PRINT 'Index olusturuldu.'
END
GO

-- =============================================
-- 4. ONAY YETKILISI ESLESTIRME TABLOSU
-- Hangi personel hangi onay turunu verebilir
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOnayYetkilisi')
BEGIN
    CREATE TABLE tbOnayYetkilisi (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nOnayTurID INT NOT NULL,
        nPersonelID INT NOT NULL,
        nAsamaID INT,                             -- NULL ise tum asamalar icin yetkili
        bAktif BIT DEFAULT 1,
        dteBaslangic DATETIME DEFAULT GETDATE(),
        dteBitis DATETIME,
        FOREIGN KEY (nOnayTurID) REFERENCES tbOnayTurleri(nOnayTurID),
        FOREIGN KEY (nAsamaID) REFERENCES tbUretimAsamaTanim(nAsamaID)
    )
    PRINT 'tbOnayYetkilisi tablosu olusturuldu.'
END
GO

-- =============================================
-- 5. SATIN ALMA SIPARISI ONAYLARI
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSatinAlmaSiparisOnay')
BEGIN
    CREATE TABLE tbSatinAlmaSiparisOnay (
        nOnayID INT IDENTITY(1,1) PRIMARY KEY,
        nSatinAlmaID INT NOT NULL,               -- tbOtomatikSiparis.nID veya lSiparisNo
        nOnayTurID INT NOT NULL,
        nOnayNo INT DEFAULT 1,
        nOnaylayanID INT,
        sOnayDurum NVARCHAR(20) DEFAULT 'Bekliyor',
        dteOnayTarihi DATETIME,
        sAciklama NVARCHAR(500),
        dteTalepTarihi DATETIME DEFAULT GETDATE(),
        bBildirimGonderildi BIT DEFAULT 0
    )
    PRINT 'tbSatinAlmaSiparisOnay tablosu olusturuldu.'
END
GO

-- =============================================
-- 6. tbOtomatikSiparis TABLOSUNU GUNCELLE
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'nGerekliOnay')
BEGIN
    ALTER TABLE tbOtomatikSiparis ADD nGerekliOnay INT DEFAULT 1
    PRINT 'tbOtomatikSiparis tablosuna nGerekliOnay kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'nMevcutOnay')
BEGIN
    ALTER TABLE tbOtomatikSiparis ADD nMevcutOnay INT DEFAULT 0
    PRINT 'tbOtomatikSiparis tablosuna nMevcutOnay kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'sSeciliTedarikci')
BEGIN
    ALTER TABLE tbOtomatikSiparis ADD sSeciliTedarikci NVARCHAR(200)
    PRINT 'tbOtomatikSiparis tablosuna sSeciliTedarikci kolonu eklendi.'
END
GO

-- =============================================
-- 7. STORED PROCEDURE: Asama Onay Olustur
-- =============================================
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_UretimAsamaOnayOlustur')
    DROP PROCEDURE sp_UretimAsamaOnayOlustur
GO

CREATE PROCEDURE sp_UretimAsamaOnayOlustur
    @nUretimEmriAsamaID INT,
    @nUretimEmriID INT,
    @nAsamaID INT
AS
BEGIN
    DECLARE @nGerekliOnay INT
    DECLARE @sOnayTurleri NVARCHAR(500)
    DECLARE @nOnayNo INT = 0
    
    -- Asama ayarlarini al
    SELECT @nGerekliOnay = ISNULL(nGerekliOnay, 1), 
           @sOnayTurleri = ISNULL(sOnayTurleri, 'URETIM_YETKILISI')
    FROM tbUretimAsamaTanim WHERE nAsamaID = @nAsamaID
    
    IF @nGerekliOnay = 0 RETURN  -- Onay gerekmiyorsa cik
    
    -- Onay turlerini parcala ve kayit olustur
    DECLARE @OnayTur NVARCHAR(50)
    DECLARE @Pos INT
    
    WHILE LEN(@sOnayTurleri) > 0 AND @nOnayNo < @nGerekliOnay
    BEGIN
        SET @nOnayNo = @nOnayNo + 1
        SET @Pos = CHARINDEX(',', @sOnayTurleri)
        
        IF @Pos > 0
        BEGIN
            SET @OnayTur = LTRIM(RTRIM(SUBSTRING(@sOnayTurleri, 1, @Pos - 1)))
            SET @sOnayTurleri = SUBSTRING(@sOnayTurleri, @Pos + 1, LEN(@sOnayTurleri))
        END
        ELSE
        BEGIN
            SET @OnayTur = LTRIM(RTRIM(@sOnayTurleri))
            SET @sOnayTurleri = ''
        END
        
        -- Onay kaydini olustur
        DECLARE @nOnayTurID INT
        SELECT @nOnayTurID = nOnayTurID FROM tbOnayTurleri WHERE sOnayTurKodu = @OnayTur AND bAktif = 1
        
        IF @nOnayTurID IS NOT NULL
        BEGIN
            INSERT INTO tbUretimEmriAsamaOnaylar 
                (nUretimEmriAsamaID, nUretimEmriID, nAsamaID, nOnayTurID, nOnayNo, sOnayDurum)
            VALUES 
                (@nUretimEmriAsamaID, @nUretimEmriID, @nAsamaID, @nOnayTurID, @nOnayNo, 'Bekliyor')
        END
    END
END
GO
PRINT 'sp_UretimAsamaOnayOlustur stored procedure olusturuldu.'

-- =============================================
-- 8. STORED PROCEDURE: Onay Ver
-- =============================================
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_UretimAsamaOnayVer')
    DROP PROCEDURE sp_UretimAsamaOnayVer
GO

CREATE PROCEDURE sp_UretimAsamaOnayVer
    @nOnayID INT,
    @nOnaylayanID INT,
    @sAciklama NVARCHAR(500) = ''
AS
BEGIN
    DECLARE @nUretimEmriAsamaID INT
    DECLARE @nAsamaID INT
    DECLARE @nUretimEmriID INT
    DECLARE @nGerekliOnay INT
    DECLARE @nMevcutOnay INT
    
    -- Onay bilgilerini al
    SELECT @nUretimEmriAsamaID = nUretimEmriAsamaID, 
           @nAsamaID = nAsamaID,
           @nUretimEmriID = nUretimEmriID
    FROM tbUretimEmriAsamaOnaylar WHERE nOnayID = @nOnayID
    
    -- Onay ver
    UPDATE tbUretimEmriAsamaOnaylar 
    SET sOnayDurum = 'Onaylandi', 
        nOnaylayanID = @nOnaylayanID, 
        dteOnayTarihi = GETDATE(),
        sAciklama = @sAciklama
    WHERE nOnayID = @nOnayID
    
    -- Tum onaylar tamamlandi mi kontrol et
    SELECT @nGerekliOnay = nGerekliOnay FROM tbUretimAsamaTanim WHERE nAsamaID = @nAsamaID
    SELECT @nMevcutOnay = COUNT(*) FROM tbUretimEmriAsamaOnaylar 
    WHERE nUretimEmriAsamaID = @nUretimEmriAsamaID AND sOnayDurum = 'Onaylandi'
    
    -- Tum onaylar tamamlandiysa asamayi tamamla
    IF @nMevcutOnay >= @nGerekliOnay
    BEGIN
        UPDATE tbUretimEmriAsama 
        SET sDurum = 'Tamamlandi', dteBitis = GETDATE() 
        WHERE nID = @nUretimEmriAsamaID
        
        -- Sonraki asamaya gec
        DECLARE @nSonrakiAsamaID INT
        SELECT TOP 1 @nSonrakiAsamaID = a.nAsamaID 
        FROM tbUretimEmriAsama e 
        INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID
        WHERE e.nUretimEmriID = @nUretimEmriID AND e.sDurum = 'Bekliyor'
        ORDER BY a.nSiraNo
        
        IF @nSonrakiAsamaID IS NOT NULL
        BEGIN
            UPDATE tbUretimEmriAsama SET sDurum = 'Devam', dteBaslangic = GETDATE() 
            WHERE nUretimEmriID = @nUretimEmriID AND nAsamaID = @nSonrakiAsamaID
            
            UPDATE TBLUREURETIM SET nMevcutAsamaID = @nSonrakiAsamaID WHERE IND = @nUretimEmriID OR EVRAKNO = @nUretimEmriID
        END
        ELSE
        BEGIN
            -- Tum asamalar bitti, uretim tamamlandi
            UPDATE TBLUREURETIM SET DURUM = 'Tamamlandi', dteGercekBitis = GETDATE() 
            WHERE IND = @nUretimEmriID OR EVRAKNO = @nUretimEmriID
        END
    END
    
    RETURN @nMevcutOnay
END
GO
PRINT 'sp_UretimAsamaOnayVer stored procedure olusturuldu.'

-- =============================================
-- 9. VIEW: Bekleyen Onaylar
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
    u.MIKTAR,
    (SELECT sAdi + ' ' + sSoyadi FROM APERSONEL WHERE nKullaniciID = o.nOnaylayanID) AS Onaylayan
FROM tbUretimEmriAsamaOnaylar o
INNER JOIN tbUretimAsamaTanim a ON o.nAsamaID = a.nAsamaID
INNER JOIN tbOnayTurleri t ON o.nOnayTurID = t.nOnayTurID
INNER JOIN TBLUREURETIM u ON o.nUretimEmriID = u.IND OR o.nUretimEmriID = u.EVRAKNO
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
WHERE o.sOnayDurum = 'Bekliyor'
GO
PRINT 'vw_BekleyenOnaylar view olusturuldu.'

-- =============================================
-- 10. VIEW: Tedarikci Secenekleri (onceki alimlardan)
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
    AVG(d.lBirimFiyati) AS OrtalamaFiyat,
    MAX(d.lBirimFiyati) AS SonFiyat
FROM tbStokFisiDetayi d
INNER JOIN tbStokFisi sf ON d.nStokFisiID = sf.nStokFisiID
INNER JOIN tbFirma f ON sf.nFirmaID = f.nFirmaID
INNER JOIN tbStok s ON d.nStokID = s.nStokID
WHERE sf.sFisTipi IN ('AF', 'AI', '01', '02')  -- Alis faturasi, alis irsaliyesi
AND d.lGirisMiktar1 > 0
GROUP BY d.nStokID, s.sKodu, s.sAciklama, f.nFirmaID, f.sKodu, f.sAciklama
GO
PRINT 'vw_TedarikciSecenekleri view olusturuldu.'

PRINT '';
PRINT '=============================================';
PRINT 'PARAMETRIK ONAY SISTEMI KURULUMU TAMAMLANDI';
PRINT '=============================================';
PRINT '';
PRINT 'Onemli Notlar:';
PRINT '1. Her asama icin farkli onay sayisi ayarlanabilir (nGerekliOnay)';
PRINT '2. Onay turleri parametrik: URETIM_YETKILISI, KALITE_KONTROL, FIRMA_YETKILISI, YONETICI';
PRINT '3. Tum onaylar tamamlaninca sonraki asamaya otomatik gecis';
PRINT '4. Tedarikci secimi onceki alimlardan otomatik onerilir';
