-- =============================================
-- E-FATURA İHRACAT TANIMLARI SQL SCRIPT
-- Tarih: 2026-01-16
-- =============================================

-- 1. KDV Muafiyet Kodları Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbKdvMuafiyetKodlari')
BEGIN
    CREATE TABLE tbKdvMuafiyetKodlari (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sKod NVARCHAR(10) NOT NULL,
        sKanunMaddesi NVARCHAR(100) NULL,
        sAciklama NVARCHAR(200) NOT NULL,
        bAktif BIT DEFAULT 1,
        dtOlusturma DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbKdvMuafiyetKodlari tablosu oluşturuldu.'
END
GO

-- KDV Muafiyet Kodları Varsayılan Veriler
IF NOT EXISTS (SELECT * FROM tbKdvMuafiyetKodlari WHERE sKod = '301')
BEGIN
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('301', '11/1-a', 'Mal İhracatı')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('302', '11/1-c', 'Yolcu Beraberi Eşya (Bavul Ticareti)')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('303', '13/a', 'Deniz, Hava ve Demiryolu Taşıma Araçları')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('304', '13/b', 'Petrol Arama Faaliyetleri')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('305', '13/c', 'Altın, Gümüş, Platin Arama İşlemleri')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('306', '13/d', 'Yatırım Teşvik Belgesi Kapsamında Makine Teçhizat')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('307', '13/e', 'Liman ve Hava Meydanlarına Yapılan Bağışlar')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('308', '13/f', 'Liman ve Hava Meydanı Hizmetleri')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('309', '14/1', 'Transit Taşımacılık')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('310', '15/1-a', 'Diplomatik İstisna')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('311', '15/1-b', 'Uluslararası Kuruluş İstisnası')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('312', '17/1', 'Kültür ve Eğitim Amacı Taşıyan İşlemler')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('313', '17/2-b', 'Sağlık, Eğitim, Sinema ve Tiyatro İstisnası')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('314', '17/4-c', 'Birleşme, Devir, Bölünme ve Hisse Değişimi')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('315', '17/4-r', 'Konut ve İşyeri Teslimleri')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('316', '17/4-s', 'Organize Sanayi ve Küçük Sanayi Sitesi Teslimleri')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('350', 'Diğer', 'Diğer İstisnalar')
    INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama) VALUES ('351', '19/2', 'İade Hakkı Doğuran Diğer İstisnalar')
    PRINT 'KDV Muafiyet kodları eklendi.'
END
GO

-- 2. Taşıma Şekilleri Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTasimaSekilleri')
BEGIN
    CREATE TABLE tbTasimaSekilleri (
        nID INT PRIMARY KEY,
        sKod NVARCHAR(10) NOT NULL,
        sAciklama NVARCHAR(100) NOT NULL,
        bAktif BIT DEFAULT 1
    )
    PRINT 'tbTasimaSekilleri tablosu oluşturuldu.'
END
GO

-- Taşıma Şekilleri Varsayılan Veriler (UN/ECE Recommendation 19)
IF NOT EXISTS (SELECT * FROM tbTasimaSekilleri WHERE nID = 1)
BEGIN
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (1, '1', 'Denizyolu Taşımacılığı')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (2, '2', 'Demiryolu Taşımacılığı')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (3, '3', 'Karayolu Taşımacılığı')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (4, '4', 'Havayolu Taşımacılığı')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (5, '5', 'Posta ile Gönderim')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (6, '6', 'Çok Modlu Taşımacılık')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (7, '7', 'Sabit Taşıma Tesisleri')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (8, '8', 'İç Su Taşımacılığı')
    INSERT INTO tbTasimaSekilleri (nID, sKod, sAciklama) VALUES (9, '9', 'Uygulanamaz / Belirtilmemiş')
    PRINT 'Taşıma şekilleri eklendi.'
END
GO

-- 3. Paket Tipleri Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbPaketTipleri')
BEGIN
    CREATE TABLE tbPaketTipleri (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sKod NVARCHAR(10) NOT NULL,
        sAciklama NVARCHAR(100) NOT NULL,
        bAktif BIT DEFAULT 1
    )
    PRINT 'tbPaketTipleri tablosu oluşturuldu.'
END
GO

-- Paket Tipleri Varsayılan Veriler (UN/ECE Recommendation 21)
IF NOT EXISTS (SELECT * FROM tbPaketTipleri WHERE sKod = 'CT')
BEGIN
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('CT', 'Karton Kutu')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('BX', 'Kutu')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('PK', 'Paket')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('PX', 'Palet')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('CR', 'Kasa/Sandık')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('DR', 'Varil')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('BG', 'Çuval/Torba')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('RL', 'Rulo')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('CY', 'Silindir')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('NE', 'Paketlenmemiş/Dökme')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('CS', 'Koli')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('TB', 'Tüp')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('CN', 'Konteyner')
    INSERT INTO tbPaketTipleri (sKod, sAciklama) VALUES ('AF', 'Ambalajsız')
    PRINT 'Paket tipleri eklendi.'
END
GO

-- 4. tbStokFisiMaster Tablosuna Yeni Alanlar Ekleme
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'sKdvMuafiyetKodu')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD sKdvMuafiyetKodu VARCHAR(20) NULL
    PRINT 'sKdvMuafiyetKodu alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'nTasimaSekli')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD nTasimaSekli INT NULL
    PRINT 'nTasimaSekli alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'lBrutAgirlik')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD lBrutAgirlik DECIMAL(18,4) NULL
    PRINT 'lBrutAgirlik alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'lNetAgirlik')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD lNetAgirlik DECIMAL(18,4) NULL
    PRINT 'lNetAgirlik alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'nPaketSayisi')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD nPaketSayisi INT NULL
    PRINT 'nPaketSayisi alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'sPaketTipi')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD sPaketTipi NVARCHAR(20) NULL
    PRINT 'sPaketTipi alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'sGumrukCikisNo')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD sGumrukCikisNo NVARCHAR(50) NULL
    PRINT 'sGumrukCikisNo alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'sTeslimatAdresi')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD sTeslimatAdresi NVARCHAR(500) NULL
    PRINT 'sTeslimatAdresi alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'sTeslimatSehir')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD sTeslimatSehir NVARCHAR(100) NULL
    PRINT 'sTeslimatSehir alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'sTeslimatUlke')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD sTeslimatUlke NVARCHAR(100) NULL
    PRINT 'sTeslimatUlke alanı eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisiMaster') AND name = 'sTeslimatUlkeKodu')
BEGIN
    ALTER TABLE tbStokFisiMaster ADD sTeslimatUlkeKodu NVARCHAR(5) NULL
    PRINT 'sTeslimatUlkeKodu alanı eklendi.'
END
GO

-- 5. Fatura Sabiti alanı (tbStokFisNolar tablosuna)
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokFisNolar') AND name = 'sFaturaSabiti')
BEGIN
    ALTER TABLE tbStokFisNolar ADD sFaturaSabiti NVARCHAR(10) NULL
    PRINT 'sFaturaSabiti alanı tbStokFisNolar tablosuna eklendi.'
END
GO

PRINT ''
PRINT '============================================='
PRINT 'TÜM İŞLEMLER TAMAMLANDI!'
PRINT '============================================='
GO