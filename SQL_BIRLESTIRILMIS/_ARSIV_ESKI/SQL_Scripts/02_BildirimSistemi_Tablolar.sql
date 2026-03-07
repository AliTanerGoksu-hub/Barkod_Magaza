-- =============================================
-- BILDIRIM SISTEMI - TABLO YAPISI
-- Bu scripti SQL Server Management Studio'da calistirin
-- =============================================

-- 1. Bildirim Tipleri Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbBildirimTipleri')
BEGIN
    CREATE TABLE tbBildirimTipleri (
        nTipID INT IDENTITY(1,1) PRIMARY KEY,
        sTipKodu NVARCHAR(50) NOT NULL,
        sTipAdi NVARCHAR(200) NOT NULL,
        sKategori NVARCHAR(50),
        bAktif BIT DEFAULT 1,
        bVarsayilanEmail BIT DEFAULT 0,
        bVarsayilanSMS BIT DEFAULT 0,
        bVarsayilanWhatsApp BIT DEFAULT 0,
        bVarsayilanUygulama BIT DEFAULT 1,
        sSablonEmail NVARCHAR(MAX),
        sSablonSMS NVARCHAR(500),
        sSablonWhatsApp NVARCHAR(500)
    )
    PRINT 'tbBildirimTipleri tablosu olusturuldu.'
END
GO

-- 2. Bildirim Log Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbBildirimLog')
BEGIN
    CREATE TABLE tbBildirimLog (
        nLogID INT IDENTITY(1,1) PRIMARY KEY,
        nTipID INT,
        nAliciID INT,
        sAliciEmail NVARCHAR(100),
        sAliciTelefon NVARCHAR(20),
        sBaslik NVARCHAR(200),
        sMesaj NVARCHAR(MAX),
        sKanal NVARCHAR(20), -- Email, SMS, WhatsApp, Uygulama
        sDurum NVARCHAR(20) DEFAULT 'Bekliyor', -- Bekliyor, Gonderildi, Hata
        sHataMesaji NVARCHAR(500),
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteGonderim DATETIME,
        bOkundu BIT DEFAULT 0,
        dteOkunma DATETIME
    )
    PRINT 'tbBildirimLog tablosu olusturuldu.'
END
GO

-- 3. Kullanici Bildirim Tercihleri Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbKullaniciBildirimTercihleri')
BEGIN
    CREATE TABLE tbKullaniciBildirimTercihleri (
        nTercihID INT IDENTITY(1,1) PRIMARY KEY,
        nKullaniciID INT NOT NULL,
        nTipID INT NOT NULL,
        bEmailAktif BIT DEFAULT 0,
        bSMSAktif BIT DEFAULT 0,
        bWhatsAppAktif BIT DEFAULT 0,
        bUygulamaAktif BIT DEFAULT 1,
        dteKayitTarihi DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (nTipID) REFERENCES tbBildirimTipleri(nTipID)
    )
    PRINT 'tbKullaniciBildirimTercihleri tablosu olusturuldu.'
END
GO

-- 4. WhatsApp Gruplari Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbWhatsappGruplari')
BEGIN
    CREATE TABLE tbWhatsappGruplari (
        nGrupID INT IDENTITY(1,1) PRIMARY KEY,
        sGrupAdi NVARCHAR(100) NOT NULL,
        sAciklama NVARCHAR(500),
        bAktif BIT DEFAULT 1,
        dteKayitTarihi DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbWhatsappGruplari tablosu olusturuldu.'
END
GO

-- 5. WhatsApp Grup Uyeleri Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbWhatsappGrupUyeleri')
BEGIN
    CREATE TABLE tbWhatsappGrupUyeleri (
        nUyeID INT IDENTITY(1,1) PRIMARY KEY,
        nGrupID INT NOT NULL,
        nPersonelID INT NOT NULL,
        bAktif BIT DEFAULT 1,
        dteKayitTarihi DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (nGrupID) REFERENCES tbWhatsappGruplari(nGrupID)
    )
    PRINT 'tbWhatsappGrupUyeleri tablosu olusturuldu.'
END
GO

-- 6. Sistem Ayarlari Tablosu (Email/SMS/WhatsApp API ayarlari)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbSistemAyar')
BEGIN
    CREATE TABLE tbSistemAyar (
        nAyarID INT IDENTITY(1,1) PRIMARY KEY,
        sAyarKodu NVARCHAR(50) NOT NULL,
        sAyarDeger NVARCHAR(500),
        sAciklama NVARCHAR(200),
        bAktif BIT DEFAULT 1
    )
    PRINT 'tbSistemAyar tablosu olusturuldu.'
    
    -- Varsayilan ayarlari ekle
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama, bAktif) VALUES
    ('EMAIL_SMTP_HOST', '', 'SMTP Sunucu Adresi', 1),
    ('EMAIL_SMTP_PORT', '587', 'SMTP Port', 1),
    ('EMAIL_SMTP_USER', '', 'SMTP Kullanici Adi', 1),
    ('EMAIL_SMTP_PASS', '', 'SMTP Sifre (sifreli)', 1),
    ('EMAIL_FROM', '', 'Gonderici Email Adresi', 1),
    ('EMAIL_AKTIF', '0', 'Email Bildirimi Aktif mi', 1),
    ('SMS_API_URL', '', 'SMS API URL', 1),
    ('SMS_API_KEY', '', 'SMS API Key', 1),
    ('SMS_SENDER', '', 'SMS Gonderici', 1),
    ('SMS_AKTIF', '0', 'SMS Bildirimi Aktif mi', 1),
    ('WHATSAPP_PHONE_ID', '', 'WhatsApp Phone Number ID', 1),
    ('WHATSAPP_ACCESS_TOKEN', '', 'WhatsApp Access Token (sifreli)', 1),
    ('WHATSAPP_BUSINESS_ID', '', 'WhatsApp Business ID', 1),
    ('WHATSAPP_API_VERSION', 'v17.0', 'WhatsApp API Version', 1),
    ('WHATSAPP_AKTIF', '0', 'WhatsApp Bildirimi Aktif mi', 1)
    PRINT 'Varsayilan sistem ayarlari eklendi.'
END
GO

-- 7. APERSONEL tablosuna bildirim alanlari ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'sWhatsApp')
BEGIN
    ALTER TABLE APERSONEL ADD sWhatsApp NVARCHAR(20)
    PRINT 'APERSONEL tablosuna sWhatsApp kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bYonetici')
BEGIN
    ALTER TABLE APERSONEL ADD bYonetici BIT DEFAULT 0
    PRINT 'APERSONEL tablosuna bYonetici kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bEmailBildirimAl')
BEGIN
    ALTER TABLE APERSONEL ADD bEmailBildirimAl BIT DEFAULT 1
    PRINT 'APERSONEL tablosuna bEmailBildirimAl kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bSMSBildirimAl')
BEGIN
    ALTER TABLE APERSONEL ADD bSMSBildirimAl BIT DEFAULT 1
    PRINT 'APERSONEL tablosuna bSMSBildirimAl kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bWhatsAppBildirimAl')
BEGIN
    ALTER TABLE APERSONEL ADD bWhatsAppBildirimAl BIT DEFAULT 1
    PRINT 'APERSONEL tablosuna bWhatsAppBildirimAl kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('APERSONEL') AND name = 'bUygulamaBildirimAl')
BEGIN
    ALTER TABLE APERSONEL ADD bUygulamaBildirimAl BIT DEFAULT 1
    PRINT 'APERSONEL tablosuna bUygulamaBildirimAl kolonu eklendi.'
END
GO

-- 8. aEmirAjanda tablosuna bildirim alanlari ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('aEmirAjanda') AND name = 'BildirimGonderildi')
BEGIN
    ALTER TABLE aEmirAjanda ADD BildirimGonderildi BIT DEFAULT 0
    PRINT 'aEmirAjanda tablosuna BildirimGonderildi kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('aEmirAjanda') AND name = 'BildirimTarihi')
BEGIN
    ALTER TABLE aEmirAjanda ADD BildirimTarihi DATETIME
    PRINT 'aEmirAjanda tablosuna BildirimTarihi kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('aEmirAjanda') AND name = 'GorevVerenID')
BEGIN
    ALTER TABLE aEmirAjanda ADD GorevVerenID INT
    PRINT 'aEmirAjanda tablosuna GorevVerenID kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('aEmirAjanda') AND name = 'AcilMi')
BEGIN
    ALTER TABLE aEmirAjanda ADD AcilMi BIT DEFAULT 0
    PRINT 'aEmirAjanda tablosuna AcilMi kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('aEmirAjanda') AND name = 'OkunduMu')
BEGIN
    ALTER TABLE aEmirAjanda ADD OkunduMu BIT DEFAULT 0
    PRINT 'aEmirAjanda tablosuna OkunduMu kolonu eklendi.'
END
GO

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('aEmirAjanda') AND name = 'OkunmaTarihi')
BEGIN
    ALTER TABLE aEmirAjanda ADD OkunmaTarihi DATETIME
    PRINT 'aEmirAjanda tablosuna OkunmaTarihi kolonu eklendi.'
END
GO

-- 9. Varsayilan Bildirim Tiplerini Ekle
IF NOT EXISTS (SELECT * FROM tbBildirimTipleri WHERE sTipKodu = 'GOREV_ATANDI')
BEGIN
    INSERT INTO tbBildirimTipleri (sTipKodu, sTipAdi, sKategori, bAktif, bVarsayilanEmail, bVarsayilanSMS, bVarsayilanWhatsApp, bVarsayilanUygulama) VALUES
    -- Gorev Bildirimleri
    ('GOREV_ATANDI', 'Yeni Gorev Atandi', 'Gorev', 1, 1, 0, 1, 1),
    ('GOREV_HATIRLATMA', 'Gorev Hatirlatmasi', 'Gorev', 1, 1, 0, 0, 1),
    ('GOREV_TAMAMLANDI', 'Gorev Tamamlandi', 'Gorev', 1, 1, 0, 1, 1),
    ('GOREV_ACIL', 'Acil Gorev', 'Gorev', 1, 1, 1, 1, 1),
    
    -- Siparis Bildirimleri
    ('SIPARIS_YENI', 'Yeni Siparis', 'Siparis', 1, 1, 0, 0, 1),
    ('SIPARIS_ONAYLANDI', 'Siparis Onaylandi', 'Siparis', 1, 1, 0, 1, 1),
    ('SIPARIS_IPTAL', 'Siparis Iptal Edildi', 'Siparis', 1, 1, 0, 1, 1),
    ('SIPARIS_SEVK', 'Siparis Sevk Edildi', 'Siparis', 1, 1, 1, 1, 1),
    
    -- Uretim Bildirimleri
    ('URETIM_BASLADI', 'Uretim Basladi', 'Uretim', 1, 0, 0, 0, 1),
    ('URETIM_ASAMA_TAMAMLANDI', 'Uretim Asamasi Tamamlandi', 'Uretim', 1, 0, 0, 0, 1),
    ('URETIM_TAMAMLANDI', 'Uretim Tamamlandi', 'Uretim', 1, 1, 0, 1, 1),
    ('URETIM_GECIKME', 'Uretim Gecikmesi', 'Uretim', 1, 1, 0, 1, 1),
    ('URETIM_FIRE', 'Uretim Fire Bildirimi', 'Uretim', 1, 1, 0, 0, 1),
    ('URETIM_ONAY_BEKLIYOR', 'Uretim Onayi Bekliyor', 'Uretim', 1, 1, 0, 1, 1),
    
    -- Stok Bildirimleri
    ('STOK_KRITIK', 'Kritik Stok Seviyesi', 'Stok', 1, 1, 0, 1, 1),
    ('STOK_FIYAT_DUSUK', 'Stok Fiyati Maliyetin Altinda', 'Stok', 1, 1, 0, 0, 1),
    ('SATIN_ALMA_TALEP', 'Satin Alma Talebi', 'Stok', 1, 1, 0, 0, 1),
    ('SATIN_ALMA_ONAYLANDI', 'Satin Alma Onaylandi', 'Stok', 1, 1, 0, 0, 1),
    
    -- Finans Bildirimleri
    ('CEK_VADE_YAKLASTI', 'Cek Vadesi Yaklasti', 'Finans', 1, 1, 1, 1, 1),
    ('SENET_VADE_YAKLASTI', 'Senet Vadesi Yaklasti', 'Finans', 1, 1, 1, 1, 1),
    ('YUKSEK_NAKIT_ISLEM', 'Yuksek Tutarli Nakit Islem', 'Finans', 1, 1, 1, 1, 1),
    ('ODEME_BEKLIYOR', 'Odeme Bekliyor', 'Finans', 1, 1, 0, 0, 1),
    
    -- E-Ticaret Bildirimleri
    ('ETICARET_YENI_SIPARIS', 'E-Ticaret Yeni Siparis', 'E-Ticaret', 1, 1, 1, 1, 1),
    ('ETICARET_IADE', 'E-Ticaret Iade Talebi', 'E-Ticaret', 1, 1, 0, 1, 1),
    
    -- Belge Bildirimleri
    ('FATURA_SILINDI', 'Fatura Silindi', 'Belge', 1, 1, 0, 0, 1),
    ('IRSALIYE_SILINDI', 'Irsaliye Silindi', 'Belge', 1, 1, 0, 0, 1),
    ('SIPARIS_SILINDI', 'Siparis Silindi', 'Belge', 1, 1, 0, 0, 1),
    
    -- Sistem Bildirimleri
    ('SISTEM_HATA', 'Sistem Hatasi', 'Sistem', 1, 1, 0, 0, 1),
    ('SISTEM_UYARI', 'Sistem Uyarisi', 'Sistem', 1, 0, 0, 0, 1),
    ('KULLANICI_GIRIS', 'Kullanici Girisi', 'Sistem', 1, 0, 0, 0, 1),
    
    -- Genel
    ('DUYURU', 'Genel Duyuru', 'Genel', 1, 1, 0, 1, 1),
    ('ANLIK_MESAJ', 'Anlik Mesaj', 'Genel', 1, 0, 0, 0, 1)
    
    PRINT 'Varsayilan bildirim tipleri eklendi.'
END
GO

PRINT '=============================================';
PRINT 'BILDIRIM SISTEMI TABLOLARI BASARIYLA OLUSTURULDU';
PRINT '=============================================';
