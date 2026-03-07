-- =============================================
-- SIPARIS ONAY VE URETIM SISTEMI - TAM KURULUM
-- Bu scripti SQL Server Management Studio'da calistirin
-- =============================================

PRINT '=============================================';
PRINT 'SIPARIS VE URETIM SISTEMI KURULUMU BASLIYOR';
PRINT '=============================================';

-- =============================================
-- 1. URETIM ASAMA TANIMLARI TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimAsamaTanim')
BEGIN
    CREATE TABLE tbUretimAsamaTanim (
        nAsamaID INT IDENTITY(1,1) PRIMARY KEY,
        sAsamaKodu NVARCHAR(20) NOT NULL,
        sAsamaAdi NVARCHAR(100) NOT NULL,
        nSiraNo INT DEFAULT 0,
        nStandartSure INT DEFAULT 0,          -- Dakika cinsinden standart sure
        lStandartFireOrani DECIMAL(5,2) DEFAULT 0,  -- Yuzde olarak fire orani
        bOnayGerekli BIT DEFAULT 1,
        bAktif BIT DEFAULT 1,
        sAciklama NVARCHAR(500),
        dteKayitTarihi DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbUretimAsamaTanim tablosu olusturuldu.'
    
    -- Varsayilan asamalar
    INSERT INTO tbUretimAsamaTanim (sAsamaKodu, sAsamaAdi, nSiraNo, nStandartSure, lStandartFireOrani, bOnayGerekli, sAciklama) VALUES
    ('KESIMHANE', 'Kesimhane', 1, 60, 2.0, 1, 'Hammadde kesim islemi'),
    ('PRESHANE', 'Preshane', 2, 45, 1.5, 1, 'Pres islemi'),
    ('BOGMA', 'Bogma', 3, 30, 1.0, 1, 'Bogma islemi'),
    ('CAKMA', 'Cakma', 4, 25, 1.0, 1, 'Cakma islemi'),
    ('KAYNAK', 'Kaynak', 5, 20, 0.5, 1, 'Kaynak islemi'),
    ('POLISAJ', 'Polisaj', 6, 40, 1.0, 1, 'Polisaj islemi'),
    ('MONTAJ', 'Montaj', 7, 35, 0.5, 1, 'Montaj islemi'),
    ('PAKETLEME', 'Paketleme', 8, 20, 0.2, 0, 'Paketleme islemi')
    PRINT 'Varsayilan uretim asamalari eklendi.'
END
ELSE
    PRINT 'tbUretimAsamaTanim tablosu zaten mevcut.'
GO

-- =============================================
-- 2. URETIM EMRI ASAMA TAKIP TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimEmriAsama')
BEGIN
    CREATE TABLE tbUretimEmriAsama (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriID INT NOT NULL,           -- TBLUREURETIM.IND veya EVRAKNO
        nAsamaID INT NOT NULL,
        nPozisyonNo INT DEFAULT 0,            -- TBLURERECETEPOZ'dan
        sAsamaAdi NVARCHAR(100),
        nPlanlananSure INT DEFAULT 0,         -- Dakika
        nGercekSure INT DEFAULT 0,            -- Dakika
        dteBaslangic DATETIME,
        dteBitis DATETIME,
        dteDuraklama DATETIME,                -- Duraklama baslangici
        nToplamDuraklamaSure INT DEFAULT 0,   -- Toplam duraklama suresi (dakika)
        lPlanlananMiktar DECIMAL(18,4) DEFAULT 0,
        lGercekMiktar DECIMAL(18,4) DEFAULT 0,
        lFireMiktar DECIMAL(18,4) DEFAULT 0,
        lStandartFireOrani DECIMAL(5,2) DEFAULT 0,
        sDurum NVARCHAR(20) DEFAULT 'Bekliyor',  -- Bekliyor, Devam, Duraklatildi, Tamamlandi
        nOnaylayanID INT,
        dteOnayTarihi DATETIME,
        sAciklama NVARCHAR(500),
        sDuraklamaNedeni NVARCHAR(500),
        dteKayitTarihi DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (nAsamaID) REFERENCES tbUretimAsamaTanim(nAsamaID)
    )
    PRINT 'tbUretimEmriAsama tablosu olusturuldu.'
END
ELSE
    PRINT 'tbUretimEmriAsama tablosu zaten mevcut.'
GO

-- =============================================
-- 3. ASAMA YETKILILERI TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimAsamaYetkililer')
BEGIN
    CREATE TABLE tbUretimAsamaYetkililer (
        nYetkiliID INT IDENTITY(1,1) PRIMARY KEY,
        nAsamaID INT NOT NULL,
        nPersonelID INT NOT NULL,
        bAktif BIT DEFAULT 1,
        dteKayitTarihi DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (nAsamaID) REFERENCES tbUretimAsamaTanim(nAsamaID)
    )
    PRINT 'tbUretimAsamaYetkililer tablosu olusturuldu.'
END
ELSE
    PRINT 'tbUretimAsamaYetkililer tablosu zaten mevcut.'
GO

-- =============================================
-- 4. GECIKME KAYITLARI TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimGecikme')
BEGIN
    CREATE TABLE tbUretimGecikme (
        nGecikmeID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriID INT NOT NULL,
        nAsamaID INT,
        sGecikmeNedeni NVARCHAR(500),
        nGecikmeSuresi INT DEFAULT 0,         -- Dakika
        dteGecikmeBaslangic DATETIME,
        dteGecikmeBitis DATETIME,
        nKaydedenID INT,
        dteKayitTarihi DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbUretimGecikme tablosu olusturuldu.'
END
GO

-- =============================================
-- 5. FIRE KAYITLARI TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbUretimFire')
BEGIN
    CREATE TABLE tbUretimFire (
        nFireID INT IDENTITY(1,1) PRIMARY KEY,
        nUretimEmriID INT NOT NULL,
        nAsamaID INT,
        nStokID INT,
        lFireMiktar DECIMAL(18,4) DEFAULT 0,
        lStandartFireMiktar DECIMAL(18,4) DEFAULT 0,
        sFireNedeni NVARCHAR(500),
        nKaydedenID INT,
        dteKayitTarihi DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbUretimFire tablosu olusturuldu.'
END
GO

-- =============================================
-- 6. OTOMATIK SATIN ALMA SIPARISLERI TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOtomatikSiparis')
BEGIN
    CREATE TABLE tbOtomatikSiparis (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nAlinanSiparisID INT,                 -- Hangi alınan sipariş için
        nUretimEmriID INT,                    -- Hangi üretim emri için
        nVerilenSiparisID INT,                -- Oluşturulan verilen sipariş ID
        nStokID INT NOT NULL,                 -- Hangi ürün/hammadde
        nTedarikciID INT,                     -- Hangi firmaya
        lTalepMiktar DECIMAL(18,4) DEFAULT 0,
        lBirimFiyat DECIMAL(18,4) DEFAULT 0,
        sDurum NVARCHAR(20) DEFAULT 'Bekliyor', -- Bekliyor, Onaylandi, Reddedildi, Tamamlandi
        dteTalepTarihi DATETIME DEFAULT GETDATE(),
        nTalepEdenID INT,
        nOnaylayanID INT,
        dteOnayTarihi DATETIME,
        sAciklama NVARCHAR(500)
    )
    PRINT 'tbOtomatikSiparis tablosu olusturuldu.'
END
GO

-- =============================================
-- 7. TEDARIKCI FIYAT GECMISI (Firma secimi icin)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTedarikciStokFiyat')
BEGIN
    CREATE TABLE tbTedarikciStokFiyat (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT NOT NULL,
        nFirmaID INT NOT NULL,
        sFirmaKodu NVARCHAR(50),
        sFirmaAdi NVARCHAR(200),
        lSonFiyat DECIMAL(18,4) DEFAULT 0,
        sPB NVARCHAR(10) DEFAULT 'TL',
        dteSonAlimTarihi DATETIME,
        lSonAlimMiktar DECIMAL(18,4) DEFAULT 0,
        nAlimSayisi INT DEFAULT 0             -- Bu firmadan kac kez alinmis
    )
    PRINT 'tbTedarikciStokFiyat tablosu olusturuldu.'
END
GO

-- =============================================
-- 8. tbSiparis TABLOSUNA YENI KOLONLAR
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bOnayBekliyor')
BEGIN
    ALTER TABLE tbSiparis ADD bOnayBekliyor BIT DEFAULT 0
    PRINT 'tbSiparis tablosuna bOnayBekliyor kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bOnaylandi')
BEGIN
    ALTER TABLE tbSiparis ADD bOnaylandi BIT DEFAULT 0
    PRINT 'tbSiparis tablosuna bOnaylandi kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bKilitli')
BEGIN
    ALTER TABLE tbSiparis ADD bKilitli BIT DEFAULT 0
    PRINT 'tbSiparis tablosuna bKilitli kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'nOnaylayanID')
BEGIN
    ALTER TABLE tbSiparis ADD nOnaylayanID INT
    PRINT 'tbSiparis tablosuna nOnaylayanID kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'dteOnayTarihi')
BEGIN
    ALTER TABLE tbSiparis ADD dteOnayTarihi DATETIME
    PRINT 'tbSiparis tablosuna dteOnayTarihi kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'nUstSiparisID')
BEGIN
    ALTER TABLE tbSiparis ADD nUstSiparisID INT
    PRINT 'tbSiparis tablosuna nUstSiparisID kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'nUretimEmriID')
BEGIN
    ALTER TABLE tbSiparis ADD nUretimEmriID INT
    PRINT 'tbSiparis tablosuna nUretimEmriID kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bOtomatikOlusturuldu')
BEGIN
    ALTER TABLE tbSiparis ADD bOtomatikOlusturuldu BIT DEFAULT 0
    PRINT 'tbSiparis tablosuna bOtomatikOlusturuldu kolonu eklendi.'
END
GO

-- =============================================
-- 9. TBLUREURETIM TABLOSUNA YENI KOLONLAR
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nMevcutAsamaID')
BEGIN
    ALTER TABLE TBLUREURETIM ADD nMevcutAsamaID INT DEFAULT 0
    PRINT 'TBLUREURETIM tablosuna nMevcutAsamaID kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nSiparisID')
BEGIN
    ALTER TABLE TBLUREURETIM ADD nSiparisID INT
    PRINT 'TBLUREURETIM tablosuna nSiparisID kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dtePlanlananBaslangic')
BEGIN
    ALTER TABLE TBLUREURETIM ADD dtePlanlananBaslangic DATETIME
    PRINT 'TBLUREURETIM tablosuna dtePlanlananBaslangic kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dtePlanlananBitis')
BEGIN
    ALTER TABLE TBLUREURETIM ADD dtePlanlananBitis DATETIME
    PRINT 'TBLUREURETIM tablosuna dtePlanlananBitis kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dteGercekBaslangic')
BEGIN
    ALTER TABLE TBLUREURETIM ADD dteGercekBaslangic DATETIME
    PRINT 'TBLUREURETIM tablosuna dteGercekBaslangic kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'dteGercekBitis')
BEGIN
    ALTER TABLE TBLUREURETIM ADD dteGercekBitis DATETIME
    PRINT 'TBLUREURETIM tablosuna dteGercekBitis kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nToplamGecikmeSure')
BEGIN
    ALTER TABLE TBLUREURETIM ADD nToplamGecikmeSure INT DEFAULT 0
    PRINT 'TBLUREURETIM tablosuna nToplamGecikmeSure kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'lToplamFire')
BEGIN
    ALTER TABLE TBLUREURETIM ADD lToplamFire DECIMAL(18,4) DEFAULT 0
    PRINT 'TBLUREURETIM tablosuna lToplamFire kolonu eklendi.'
END
GO

-- =============================================
-- 10. STORED PROCEDURE: Tedarikci Fiyat Gecmisini Guncelle
-- =============================================
IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'sp_TedarikciStokFiyatGuncelle')
    DROP PROCEDURE sp_TedarikciStokFiyatGuncelle
GO

CREATE PROCEDURE sp_TedarikciStokFiyatGuncelle
AS
BEGIN
    -- Tum stok fisi detaylarindan tedarikci bilgilerini cek
    MERGE tbTedarikciStokFiyat AS target
    USING (
        SELECT 
            d.nStokID,
            f.nCariID AS nFirmaID,
            c.sKodu AS sFirmaKodu,
            c.sUnvan AS sFirmaAdi,
            d.lBirimFiyati AS lSonFiyat,
            d.sPB,
            f.dteFisTarihi AS dteSonAlimTarihi,
            d.lGirisMiktar1 AS lSonAlimMiktar
        FROM tbStokFisiDetayi d
        INNER JOIN tbStokFisi f ON d.nStokFisiID = f.nStokFisiID
        INNER JOIN tbCari c ON f.nCariID = c.nCariID
        WHERE d.lGirisMiktar1 > 0 
        AND f.sFisTipi IN ('AF', 'AI')  -- Alis Faturasi, Alis Irsaliyesi
        AND f.dteFisTarihi = (
            SELECT MAX(f2.dteFisTarihi) 
            FROM tbStokFisiDetayi d2 
            INNER JOIN tbStokFisi f2 ON d2.nStokFisiID = f2.nStokFisiID
            WHERE d2.nStokID = d.nStokID AND f2.nCariID = f.nCariID
            AND f2.sFisTipi IN ('AF', 'AI')
        )
    ) AS source
    ON target.nStokID = source.nStokID AND target.nFirmaID = source.nFirmaID
    WHEN MATCHED THEN
        UPDATE SET 
            lSonFiyat = source.lSonFiyat,
            sPB = source.sPB,
            dteSonAlimTarihi = source.dteSonAlimTarihi,
            lSonAlimMiktar = source.lSonAlimMiktar,
            nAlimSayisi = nAlimSayisi + 1
    WHEN NOT MATCHED THEN
        INSERT (nStokID, nFirmaID, sFirmaKodu, sFirmaAdi, lSonFiyat, sPB, dteSonAlimTarihi, lSonAlimMiktar, nAlimSayisi)
        VALUES (source.nStokID, source.nFirmaID, source.sFirmaKodu, source.sFirmaAdi, source.lSonFiyat, source.sPB, source.dteSonAlimTarihi, source.lSonAlimMiktar, 1);
END
GO
PRINT 'sp_TedarikciStokFiyatGuncelle stored procedure olusturuldu.'

-- Tedarikci fiyat gecmisini guncelle
EXEC sp_TedarikciStokFiyatGuncelle
PRINT 'Tedarikci fiyat gecmisi guncellendi.'
GO

-- =============================================
-- 11. VIEW: Siparis Onay Yetkilileri
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_SiparisOnayYetkililer')
    DROP VIEW vw_SiparisOnayYetkililer
GO

CREATE VIEW vw_SiparisOnayYetkililer AS
SELECT DISTINCT p.nKullaniciID, p.sKodu, p.sAdi, p.sSoyadi, p.sEmail, p.sTelefon
FROM APERSONEL p
INNER JOIN APersonelYetki y ON p.nKullaniciID = y.nKullaniciID
WHERE y.sYetkiKodu = 'frm_tbSiparis_Onay' AND y.bYetkiDurumu = 1
AND p.bAktif = 1
GO
PRINT 'vw_SiparisOnayYetkililer view olusturuldu.'

-- =============================================
-- 12. VIEW: Uretim Durumu Ozet
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_UretimDurumuOzet')
    DROP VIEW vw_UretimDurumuOzet
GO

CREATE VIEW vw_UretimDurumuOzet AS
SELECT 
    u.IND AS nUretimEmriID,
    u.EVRAKNO,
    u.TARIH,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    u.MIKTAR AS PlanlananMiktar,
    u.DURUM,
    a.sAsamaAdi AS MevcutAsama,
    u.dtePlanlananBaslangic,
    u.dtePlanlananBitis,
    u.dteGercekBaslangic,
    u.dteGercekBitis,
    u.nToplamGecikmeSure,
    u.lToplamFire,
    (SELECT COUNT(*) FROM tbUretimEmriAsama WHERE nUretimEmriID = u.IND AND sDurum = 'Tamamlandi') AS TamamlananAsamaSayisi,
    (SELECT COUNT(*) FROM tbUretimEmriAsama WHERE nUretimEmriID = u.IND) AS ToplamAsamaSayisi
FROM TBLUREURETIM u
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
LEFT JOIN tbUretimAsamaTanim a ON u.nMevcutAsamaID = a.nAsamaID
GO
PRINT 'vw_UretimDurumuOzet view olusturuldu.'

PRINT '';
PRINT '=============================================';
PRINT 'SIPARIS VE URETIM SISTEMI KURULUMU TAMAMLANDI';
PRINT '=============================================';
PRINT '';
PRINT 'Onemli Notlar:';
PRINT '1. tbSiparis tablosuna yeni kolonlar eklendi (bOnayBekliyor, bKilitli, vb.)';
PRINT '2. TBLUREURETIM tablosuna asama takip kolonlari eklendi';
PRINT '3. Varsayilan uretim asamalari (8 adet) eklendi';
PRINT '4. Tedarikci fiyat gecmisi tablosu olusturuldu';
PRINT '5. frm_tbSiparis_Onay yetkisi olan kullanicilar siparis onaylayabilir';
