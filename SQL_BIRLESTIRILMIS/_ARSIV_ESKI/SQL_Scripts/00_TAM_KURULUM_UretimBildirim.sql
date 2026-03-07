-- =============================================
-- URETIM VE BILDIRIM SISTEMI - TAM KURULUM
-- MEVCUT TABLOLARI KULLANIR, YENI TABLO OLUSTURMAZ
-- Tarih: 2024
-- =============================================

PRINT '============================================================';
PRINT 'URETIM VE BILDIRIM SISTEMI TAM KURULUM BASLIYOR';
PRINT 'MEVCUT TABLOLAR KULLANILACAK';
PRINT '============================================================';
PRINT '';

-- =============================================
-- BOLUM 1: BILDIRIM SISTEMI TABLOLARI
-- =============================================

PRINT '>>> BOLUM 1: BILDIRIM SISTEMI';

-- 1.1 Bildirim Tipleri
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
    
    INSERT INTO tbBildirimTipleri (sTipKodu, sTipAdi, bEmailVarsayilan, bSMSVarsayilan, bWhatsAppVarsayilan, bUygulamaVarsayilan) VALUES
    ('SIPARIS_ONAY', 'Siparis Onayi', 1, 0, 0, 1),
    ('URETIM_EMRI_YENI', 'Yeni Uretim Emri', 1, 0, 1, 1),
    ('URETIM_RECETE_EKSIK', 'Uretim Recetesi Eksik', 1, 1, 1, 1),
    ('SATINALMA_SIPARIS_OLUSTURULDU', 'Satin Alma Siparisi Olusturuldu', 1, 1, 1, 1),
    ('SIPARIS_ONAYLANDI', 'Siparis Onaylandi', 1, 0, 1, 1),
    ('URETIM_ASAMA_BASLADI', 'Uretim Asamasi Basladi', 0, 0, 1, 1),
    ('URETIM_ASAMA_TAMAMLANDI', 'Uretim Asamasi Tamamlandi', 0, 0, 1, 1),
    ('URETIM_ONAY_TALEBI', 'Uretim Onay Talebi', 1, 1, 1, 1),
    ('URETIM_ONAY_REDDEDILDI', 'Uretim Onayi Reddedildi', 1, 1, 1, 1),
    ('SATINALMA_ONAY_TALEBI', 'Satin Alma Onay Talebi', 1, 1, 1, 1),
    ('SATINALMA_ONAYLANDI', 'Satin Alma Onaylandi', 1, 0, 1, 1),
    ('SATINALMA_REDDEDILDI', 'Satin Alma Reddedildi', 1, 1, 1, 1),
    ('GOREV_OLUSTURULDU', 'Yeni Gorev', 1, 0, 1, 1),
    ('GOREV_TAMAMLANDI', 'Gorev Tamamlandi', 1, 0, 0, 1),
    ('MALIYET_ALTI_SATIS', 'Maliyet Alti Satis', 1, 1, 1, 1),
    ('KRITIK_STOK', 'Kritik Stok Seviyesi', 1, 0, 1, 1),
    ('CEK_VADE_YAKLASTI', 'Cek Vadesi Yaklasti', 1, 1, 0, 1),
    ('SENET_VADE_YAKLASTI', 'Senet Vadesi Yaklasti', 1, 1, 0, 1),
    ('ETICARET_YENI_SIPARIS', 'E-Ticaret Yeni Siparis', 1, 1, 1, 1),
    ('BELGE_SILINDI', 'Kritik Belge Silindi', 1, 0, 0, 1),
    ('YUKSEK_NAKIT_ISLEM', 'Yuksek Tutarli Nakit Islem', 1, 1, 1, 1),
    ('BILDIRIM_TAKIP_RAPORU', 'Bildirim Takip Raporu', 1, 0, 1, 1)
    
    PRINT '  + tbBildirimTipleri tablosu olusturuldu.'
END
ELSE PRINT '  - tbBildirimTipleri zaten mevcut.'
GO

-- 1.2 Bildirim Log
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
    PRINT '  + tbBildirimLog tablosu olusturuldu.'
END
ELSE PRINT '  - tbBildirimLog zaten mevcut.'
GO

-- 1.3 Bildirim Gonderim Kontrol
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbBildirimGonderimKontrol')
BEGIN
    CREATE TABLE tbBildirimGonderimKontrol (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sTipKodu NVARCHAR(50) NOT NULL,
        sReferansID NVARCHAR(100),
        dteGonderimTarihi DATE NOT NULL,
        dteSaat DATETIME DEFAULT GETDATE(),
        sMakineAdi NVARCHAR(100),
        UNIQUE(sTipKodu, sReferansID, dteGonderimTarihi)
    )
    PRINT '  + tbBildirimGonderimKontrol tablosu olusturuldu.'
END
ELSE PRINT '  - tbBildirimGonderimKontrol zaten mevcut.'
GO

-- 1.4 Kullanici Bildirim Tercihleri
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbKullaniciBildirimTercihleri')
BEGIN
    CREATE TABLE tbKullaniciBildirimTercihleri (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nKullaniciID INT NOT NULL,
        nTipID INT NOT NULL,
        bEmailAktif BIT DEFAULT 1,
        bSMSAktif BIT DEFAULT 0,
        bWhatsAppAktif BIT DEFAULT 0,
        bUygulamaAktif BIT DEFAULT 1,
        UNIQUE(nKullaniciID, nTipID)
    )
    PRINT '  + tbKullaniciBildirimTercihleri tablosu olusturuldu.'
END
ELSE PRINT '  - tbKullaniciBildirimTercihleri zaten mevcut.'
GO

-- 1.5 Sistem Ayarlari
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSistemAyar')
BEGIN
    CREATE TABLE tbSistemAyar (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sAnahtar NVARCHAR(100) NOT NULL UNIQUE,
        sDeger NVARCHAR(500),
        sAciklama NVARCHAR(500),
        sKategori NVARCHAR(50)
    )
    
    INSERT INTO tbSistemAyar (sAnahtar, sDeger, sAciklama, sKategori) VALUES
    ('EMAIL_AKTIF', '0', 'Email bildirimi aktif mi', 'EMAIL'),
    ('EMAIL_SMTP_HOST', '', 'SMTP sunucu adresi', 'EMAIL'),
    ('EMAIL_SMTP_PORT', '587', 'SMTP port', 'EMAIL'),
    ('EMAIL_SMTP_USER', '', 'SMTP kullanici adi', 'EMAIL'),
    ('EMAIL_SMTP_PASS', '', 'SMTP sifre', 'EMAIL'),
    ('EMAIL_FROM', '', 'Gonderen email adresi', 'EMAIL'),
    ('SMS_AKTIF', '0', 'SMS bildirimi aktif mi', 'SMS'),
    ('WHATSAPP_AKTIF', '0', 'WhatsApp bildirimi aktif mi', 'WHATSAPP'),
    ('YUKSEK_TUTAR_LIMITI', '10000', 'Yuksek tutar bildirimi icin limit', 'GENEL'),
    ('VADE_UYARI_GUN', '7', 'Vade uyarisi kac gun once', 'GENEL'),
    ('BILDIRIM_TAKIP_SURESI_SAAT', '24', 'Teslim edilmeyen bildirimler icin uyari suresi', 'BILDIRIM'),
    ('BILDIRIM_TAKIP_AKTIF', '1', 'Bildirim takibi aktif mi', 'BILDIRIM')
    
    PRINT '  + tbSistemAyar tablosu olusturuldu.'
END
ELSE PRINT '  - tbSistemAyar zaten mevcut.'
GO

-- 1.6 APERSONEL tablosuna bildirim kolonlari
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'APERSONEL')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bYonetici')
        ALTER TABLE APERSONEL ADD bYonetici BIT DEFAULT 0
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'sWhatsApp')
        ALTER TABLE APERSONEL ADD sWhatsApp NVARCHAR(50)
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'sEmail')
        ALTER TABLE APERSONEL ADD sEmail NVARCHAR(200)
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bEmailBildirimAl')
        ALTER TABLE APERSONEL ADD bEmailBildirimAl BIT DEFAULT 1
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bUygulamaBildirimAl')
        ALTER TABLE APERSONEL ADD bUygulamaBildirimAl BIT DEFAULT 1
    PRINT '  + APERSONEL tablosuna bildirim kolonlari eklendi.'
END
GO

PRINT '';
PRINT '>>> BOLUM 2: ONAY SISTEMI';

-- =============================================
-- BOLUM 2: ONAY SISTEMI
-- =============================================

-- 2.1 Onay Turleri
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
    
    INSERT INTO tbOnayTurleri (sOnayTurKodu, sOnayTurAdi, nOncelik, sAciklama) VALUES
    ('URETIM_YETKILISI', 'Uretim Yetkilisi', 1, 'Uretim hatti sorumlusu'),
    ('KALITE_KONTROL', 'Kalite Kontrol', 2, 'Kalite kontrol sorumlusu'),
    ('FIRMA_YETKILISI', 'Firma Yetkilisi', 3, 'Fabrika muduru'),
    ('YONETICI', 'Ust Yonetici', 4, 'Genel mudur')
    
    PRINT '  + tbOnayTurleri tablosu olusturuldu.'
END
ELSE PRINT '  - tbOnayTurleri zaten mevcut.'
GO

-- 2.2 Onay Yetkilisi
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbOnayYetkilisi')
BEGIN
    CREATE TABLE tbOnayYetkilisi (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nOnayTurID INT NOT NULL,
        nPersonelID INT NOT NULL,
        bAktif BIT DEFAULT 1,
        dteBaslangic DATETIME DEFAULT GETDATE()
    )
    PRINT '  + tbOnayYetkilisi tablosu olusturuldu.'
END
ELSE PRINT '  - tbOnayYetkilisi zaten mevcut.'
GO

PRINT '';
PRINT '>>> BOLUM 3: URETIM SISTEMI EK KOLONLAR';

-- =============================================
-- BOLUM 3: MEVCUT URETIM TABLOLARINA EK KOLONLAR
-- =============================================

-- 3.1 TBLUREURETIM tablosuna ek kolonlar
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREURETIM')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'DURUM')
        ALTER TABLE TBLUREURETIM ADD DURUM NVARCHAR(50) DEFAULT 'Planlandi'
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('TBLUREURETIM') AND name = 'nSiparisID')
        ALTER TABLE TBLUREURETIM ADD nSiparisID INT
    PRINT '  + TBLUREURETIM tablosuna ek kolonlar eklendi.'
END
GO

-- 3.2 tbSiparis tablosuna onay kolonlari
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSiparis')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bOnaylandi')
        ALTER TABLE tbSiparis ADD bOnaylandi BIT DEFAULT 0
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'bKilitli')
        ALTER TABLE tbSiparis ADD bKilitli BIT DEFAULT 0
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'nOnaylayanID')
        ALTER TABLE tbSiparis ADD nOnaylayanID INT
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'dteOnayTarihi')
        ALTER TABLE tbSiparis ADD dteOnayTarihi DATETIME
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'sDurum')
        ALTER TABLE tbSiparis ADD sDurum NVARCHAR(30) DEFAULT 'Bekliyor'
    PRINT '  + tbSiparis tablosuna onay kolonlari eklendi.'
END
GO

-- 3.2.1 tbParamVerSiparis tablosuna onay kolonu (Verilen Siparis icin)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbParamVerSiparis')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamVerSiparis') AND name = 'bOnayVar')
        ALTER TABLE tbParamVerSiparis ADD bOnayVar BIT DEFAULT 1
    PRINT '  + tbParamVerSiparis tablosuna bOnayVar kolonu eklendi.'
END
GO

-- 3.3 Otomatik Satin Alma Siparisi
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
        dteKayit DATETIME DEFAULT GETDATE(),
        dteOnay DATETIME,
        sAciklama NVARCHAR(500)
    )
    PRINT '  + tbOtomatikSiparis tablosu olusturuldu.'
END
ELSE PRINT '  - tbOtomatikSiparis zaten mevcut.'
GO

PRINT '';
PRINT '>>> BOLUM 4: MEVCUT TABLOLARA VARSAYILAN VERILER';

-- =============================================
-- BOLUM 4: MEVCUT TABLOLARA VARSAYILAN VERILER
-- =============================================

-- 4.1 URETIM YERLERI (TBLUREURETIMYERLERI)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREURETIMYERLERI')
BEGIN
    IF NOT EXISTS (SELECT TOP 1 * FROM TBLUREURETIMYERLERI)
    BEGIN
        INSERT INTO TBLUREURETIMYERLERI (KOD, AD, CARINO, UNVAN, ADRESSEVK, TELEFON, FAX, VERGIDAIRESI, VERGINO, DEPONO, DEPOKODU) VALUES
        ('KESIMHANE', 'Kesimhane', 0, 'Lazer Kesim Departmani', '', '', '', '', '', 0, ''),
        ('PRESHANE', 'Preshane', 0, 'Pres Islemleri Departmani', '', '', '', '', '', 0, ''),
        ('PRESHANE_H1', 'Preshane Hat 1', 0, 'Pres-5, Pres-6 Hatti', '', '', '', '', '', 0, ''),
        ('CAYDANLIK_P', 'Caydanlik Pres', 0, 'Caydanlik Pres Otomasyon', '', '', '', '', '', 0, ''),
        ('KAPAK_OTOM', 'Kapak Otomasyon', 0, 'Kapak Otomasyon Hatti', '', '', '', '', '', 0, ''),
        ('BOGMA', 'Bogma', 0, 'Bogma Departmani', '', '', '', '', '', 0, ''),
        ('BOGMA_S1', 'Bogma Sube 1', 0, 'Bogma-1, Bogma-2', '', '', '', '', '', 0, ''),
        ('BOGMA_S2', 'Bogma Sube 2', 0, 'Bogma-3, Bogma-4', '', '', '', '', '', 0, ''),
        ('BOGMA_CAYD', 'Caydanlik Bogma', 0, 'Caydanlik Bogma Hatti', '', '', '', '', '', 0, ''),
        ('CAKMA', 'Cakma', 0, 'Sap/Kulp Takma', '', '', '', '', '', 0, ''),
        ('KAYNAK', 'Kaynak', 0, 'Kaynak Departmani', '', '', '', '', '', 0, ''),
        ('POLISAJ', 'Polisaj', 0, 'Polisaj Departmani', '', '', '', '', '', 0, ''),
        ('POLISAJ_TEN', 'Tencere Polisaj', 0, 'Tencere Polisaj Hatti', '', '', '', '', '', 0, ''),
        ('POLISAJ_CAY', 'Caydanlik Polisaj', 0, 'Caydanlik Polisaj Hatti', '', '', '', '', '', 0, ''),
        ('MONTAJ', 'Montaj', 0, 'Montaj Departmani', '', '', '', '', '', 0, ''),
        ('PAKETLEME', 'Paketleme', 0, 'Paketleme Departmani', '', '', '', '', '', 0, ''),
        ('PAKET_TENC', 'Tencere Paket', 0, 'Tencere Paketleme', '', '', '', '', '', 0, ''),
        ('PAKET_CAYD', 'Caydanlik Paket', 0, 'Caydanlik Paketleme', '', '', '', '', '', 0, '')
        PRINT '  + TBLUREURETIMYERLERI: 18 uretim yeri eklendi.'
    END
    ELSE PRINT '  - TBLUREURETIMYERLERI tabloda veri var, atlanıyor.'
END
ELSE PRINT '  ! TBLUREURETIMYERLERI tablosu bulunamadi!'
GO

-- 4.2 URETIM ARACLARI (TBLUREARAC)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREARAC')
BEGIN
    IF NOT EXISTS (SELECT TOP 1 * FROM TBLUREARAC)
    BEGIN
        INSERT INTO TBLUREARAC (KOD, AD, CALISMAUSULU) VALUES
        ('LAZER-1', 'Lazer Kesim Makinesi 1', 1),
        ('PRES-1', 'Pres Makinesi 1', 0),
        ('PRES-2', 'Pres Makinesi 2', 0),
        ('PRES-3', 'Pres Makinesi 3', 0),
        ('PRES-4', 'Pres Makinesi 4', 0),
        ('PRES-5', 'Pres Makinesi 5', 0),
        ('PRES-6', 'Pres Makinesi 6', 0),
        ('BOGMA-1', 'Bogma Makinesi 1', 0),
        ('BOGMA-2', 'Bogma Makinesi 2', 0),
        ('BOGMA-3', 'Bogma Makinesi 3', 0),
        ('BOGMA-4', 'Bogma Makinesi 4', 0),
        ('KAYNAK-1', 'Kaynak Makinesi 1', 0),
        ('KAYNAK-2', 'Kaynak Makinesi 2', 0),
        ('POLISAJ-1', 'Polisaj Makinesi 1', 0),
        ('POLISAJ-2', 'Polisaj Makinesi 2', 0),
        ('POLISAJ-3', 'Polisaj Makinesi 3', 0),
        ('PAKET-1', 'Paketleme Makinesi 1', 0),
        ('PAKET-2', 'Paketleme Makinesi 2', 0)
        PRINT '  + TBLUREARAC: 18 uretim araci eklendi.'
    END
    ELSE PRINT '  - TBLUREARAC tabloda veri var, atlanıyor.'
END
ELSE PRINT '  ! TBLUREARAC tablosu bulunamadi!'
GO

-- 4.3 VARDIYALAR (TBLUREVARDIYALIST)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREVARDIYALIST')
BEGIN
    IF NOT EXISTS (SELECT TOP 1 * FROM TBLUREVARDIYALIST)
    BEGIN
        INSERT INTO TBLUREVARDIYALIST (GRUPADI, BASLAMASAATI, BITISAATI) VALUES
        ('SABAH', '1900-01-01 08:00:00', '1900-01-01 17:00:00'),
        ('AKSAM', '1900-01-01 17:00:00', '1900-01-01 01:00:00'),
        ('GECE', '1900-01-01 01:00:00', '1900-01-01 08:00:00')
        PRINT '  + TBLUREVARDIYALIST: 3 vardiya eklendi.'
    END
    ELSE PRINT '  - TBLUREVARDIYALIST tabloda veri var, atlanıyor.'
END
ELSE PRINT '  ! TBLUREVARDIYALIST tablosu bulunamadi!'
GO

-- 4.4 POZISYONLAR / ASAMALAR (TBLUREPOZISYONLIST)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREPOZISYONLIST')
BEGIN
    IF NOT EXISTS (SELECT TOP 1 * FROM TBLUREPOZISYONLIST)
    BEGIN
        INSERT INTO TBLUREPOZISYONLIST (KOD, ACIKLAMA, SURE) VALUES
        ('KESIM', 'Lazer Kesim', 60),
        ('PRES', 'Pres Islemi', 45),
        ('BOGMA', 'Bogma Islemi', 30),
        ('CAKMA', 'Sap/Kulp Takma', 20),
        ('KAYNAK', 'Kaynak Islemi', 25),
        ('POLISAJ', 'Polisaj/Parlatma', 35),
        ('MONTAJ', 'Montaj', 15),
        ('KALITE', 'Kalite Kontrol', 10),
        ('PAKETLEME', 'Paketleme', 10)
        PRINT '  + TBLUREPOZISYONLIST: 9 pozisyon/asama eklendi.'
    END
    ELSE PRINT '  - TBLUREPOZISYONLIST tabloda veri var, atlanıyor.'
END
ELSE PRINT '  ! TBLUREPOZISYONLIST tablosu bulunamadi!'
GO

-- 4.5 MALIYET BIRIMLERI (TBLUREMALIYETBIRIMLERI)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREMALIYETBIRIMLERI')
BEGIN
    IF NOT EXISTS (SELECT TOP 1 * FROM TBLUREMALIYETBIRIMLERI)
    BEGIN
        INSERT INTO TBLUREMALIYETBIRIMLERI (BIRIM, BIRIMADI) VALUES
        ('ADET', 'Adet'),
        ('KG', 'Kilogram'),
        ('M', 'Metre'),
        ('M2', 'Metrekare'),
        ('LT', 'Litre'),
        ('SAAT', 'Saat'),
        ('DK', 'Dakika')
        PRINT '  + TBLUREMALIYETBIRIMLERI: 7 birim eklendi.'
    END
    ELSE PRINT '  - TBLUREMALIYETBIRIMLERI tabloda veri var, atlanıyor.'
END
ELSE PRINT '  ! TBLUREMALIYETBIRIMLERI tablosu bulunamadi!'
GO

-- 4.6 MALIYET UNSURLARI (TBLUREMALIYETUNSURLARI)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'TBLUREMALIYETUNSURLARI')
BEGIN
    IF NOT EXISTS (SELECT TOP 1 * FROM TBLUREMALIYETUNSURLARI)
    BEGIN
        INSERT INTO TBLUREMALIYETUNSURLARI (KOD, AD, ORANSAL, GIRISMUHKOD, CIKISMUHKOD, TUTAR, BIRIMNO, TUR) VALUES
        ('HAM-INOX', 'Paslanmaz Celik Sac', 0, '', '', 0, 2, 1),
        ('HAM-ALU', 'Aluminyum', 0, '', '', 0, 2, 1),
        ('HAM-BAKIR', 'Bakir', 0, '', '', 0, 2, 1),
        ('ISC-DIREKT', 'Direkt Iscilik', 0, '', '', 0, 6, 2),
        ('ISC-DOLAYLI', 'Dolayli Iscilik', 0, '', '', 0, 6, 2),
        ('ENR-ELEK', 'Elektrik', 0, '', '', 0, 6, 3),
        ('ENR-GAZ', 'Dogalgaz', 0, '', '', 0, 6, 3),
        ('GDR-BAKIM', 'Bakim Giderleri', 1, '', '', 0, 1, 4),
        ('GDR-AMORT', 'Amortisman', 1, '', '', 0, 1, 4)
        PRINT '  + TBLUREMALIYETUNSURLARI: 9 maliyet unsuru eklendi.'
    END
    ELSE PRINT '  - TBLUREMALIYETUNSURLARI tabloda veri var, atlanıyor.'
END
ELSE PRINT '  ! TBLUREMALIYETUNSURLARI tablosu bulunamadi!'
GO

PRINT '';
PRINT '============================================================';
PRINT 'KURULUM TAMAMLANDI!';
PRINT '============================================================';
PRINT '';
PRINT 'BILDIRIM SISTEMI TABLOLARI:';
PRINT '  - tbBildirimTipleri';
PRINT '  - tbBildirimLog';
PRINT '  - tbBildirimGonderimKontrol';
PRINT '  - tbKullaniciBildirimTercihleri';
PRINT '  - tbSistemAyar';
PRINT '';
PRINT 'ONAY SISTEMI TABLOLARI:';
PRINT '  - tbOnayTurleri';
PRINT '  - tbOnayYetkilisi';
PRINT '  - tbOtomatikSiparis';
PRINT '';
PRINT 'MEVCUT TABLOLARA EKLENEN VERILER:';
PRINT '  - TBLUREURETIMYERLERI: 18 uretim yeri';
PRINT '  - TBLUREARAC: 18 uretim araci';
PRINT '  - TBLUREVARDIYALIST: 3 vardiya';
PRINT '  - TBLUREPOZISYONLIST: 9 pozisyon/asama';
PRINT '  - TBLUREMALIYETBIRIMLERI: 7 birim';
PRINT '  - TBLUREMALIYETUNSURLARI: 9 maliyet unsuru';
PRINT '';
PRINT 'GUNCELLENEN TABLOLAR:';
PRINT '  - APERSONEL (bildirim kolonlari)';
PRINT '  - TBLUREURETIM (durum kolonu)';
PRINT '  - tbSiparis (onay kolonlari)';
PRINT '';
