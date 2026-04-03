-- =====================================================
-- BARKOD YAZILIM - AI ALTYAPI SQL SCRIPT
-- Parametrik Ayarlar + Yetki + Risk Skoru Tablosu
-- =====================================================

-- =====================================================
-- 1. PARAMETRIK AYARLAR (tbSistemAyar)
-- Kullanmak istemeyen musteriler icin opsiyonel
-- =====================================================

-- Ayar yoksa ekle (MERGE yerine IF NOT EXISTS)
IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'AI_MODUL_AKTIF')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('AI_MODUL_AKTIF', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'VALOR_TARIHI_ZORUNLU')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('VALOR_TARIHI_ZORUNLU', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'KREDI_LIMIT_UYARI')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('KREDI_LIMIT_UYARI', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'RISK_SKORU_AKTIF')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('RISK_SKORU_AKTIF', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'PERAKENDE_RISK_AKTIF')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('PERAKENDE_RISK_AKTIF', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SIPARIS_LIMIT_KONTROL')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('SIPARIS_LIMIT_KONTROL', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'TAHSILAT_AI_AKTIF')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('TAHSILAT_AI_AKTIF', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'SATIS_ONERI_AKTIF')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('SATIS_ONERI_AKTIF', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'YONETICI_OZET_AKTIF')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('YONETICI_OZET_AKTIF', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'ICERIK_YARDIMCI_AKTIF')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('ICERIK_YARDIMCI_AKTIF', '0')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'AI_API_URL')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('AI_API_URL', '')

IF NOT EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'AI_API_KEY')
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('AI_API_KEY', '')

-- =====================================================
-- 2. YETKI TANIMLARI (aEmirForms)
-- Her AI ozelligini ayri yetki ile kontrol et
-- =====================================================

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'ai_risk_skoru_gor')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('AI', 'ai_risk_skoru_gor', 'Risk Skoru Gorebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'ai_risk_aciklama_gor')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('AI', 'ai_risk_aciklama_gor', 'AI Risk Aciklamasi Gorebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'ai_tahsilat_plani')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('AI', 'ai_tahsilat_plani', 'AI Tahsilat Plani Gorebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'ai_satis_onerisi')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('AI', 'ai_satis_onerisi', 'AI Satis Onerisi Gorebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'ai_yonetici_ozet')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('AI', 'ai_yonetici_ozet', 'AI Yonetici Ozeti Gorebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'ai_icerik_yardimci')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('AI', 'ai_icerik_yardimci', 'AI Icerik Yardimcisi Kullanabilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'ai_ayarlar_yonet')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('AI', 'ai_ayarlar_yonet', 'AI Ayarlarini Yonetebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'cari_bakiye_gor')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('Cari', 'cari_bakiye_gor', 'Cari Bakiye Bilgisi Gorebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'cari_kredi_limit_gor')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('Cari', 'cari_kredi_limit_gor', 'Kredi Limit Bilgisi Gorebilir', 0)

IF NOT EXISTS (SELECT 1 FROM aEmirForms WHERE Form = 'cari_tahsilat_detay')
    INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES ('Cari', 'cari_tahsilat_detay', 'Tahsilat Detay Gorebilir', 0)

-- =====================================================
-- 3. RISK SKORU TABLOSU
-- =====================================================

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbRiskSkoru')
BEGIN
    CREATE TABLE tbRiskSkoru (
        nRiskID INT IDENTITY(1,1) PRIMARY KEY,
        nFirmaID INT NOT NULL,
        nRiskSkoru INT DEFAULT 0,               -- 0-100 arasi puan
        sRiskSeviye NVARCHAR(20) DEFAULT '',     -- 'guvenli', 'dikkat', 'kritik'
        lToplamBakiye DECIMAL(18,2) DEFAULT 0,
        lVadesiGecmisBakiye DECIMAL(18,2) DEFAULT 0,
        nMaxGecikmeGun INT DEFAULT 0,
        nOrtGecikmeGun INT DEFAULT 0,
        nOdemeDisipilin DECIMAL(5,2) DEFAULT 0,  -- 0.00-1.00
        nIadeOrani DECIMAL(5,2) DEFAULT 0,       -- 0.00-1.00
        nSiparisSikligi INT DEFAULT 0,            -- Son 90 gun siparis sayisi
        nLimitKullanim DECIMAL(5,2) DEFAULT 0,   -- 0.00-1.00
        sAIAciklama NVARCHAR(MAX) NULL,           -- AI tarafindan uretilen risk aciklamasi
        dteHesaplamaTarihi DATETIME DEFAULT GETDATE(),
        sKaynak NVARCHAR(20) DEFAULT 'toptan',    -- 'toptan' veya 'perakende'
        bAktif BIT DEFAULT 1
    )

    CREATE NONCLUSTERED INDEX IX_tbRiskSkoru_FirmaID ON tbRiskSkoru (nFirmaID)
END

-- =====================================================
-- 4. AUDIT LOG TABLOSU
-- =====================================================

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbAuditLog')
BEGIN
    CREATE TABLE tbAuditLog (
        nLogID BIGINT IDENTITY(1,1) PRIMARY KEY,
        nKullaniciID INT NULL,
        sKullaniciAdi NVARCHAR(100) DEFAULT '',
        sIslem NVARCHAR(100) NOT NULL,           -- 'AI_RISK_SORGU', 'AI_TAHSILAT_PLANI', 'FIYAT_DEGISIKLIK', 'LIMIT_OVERRIDE'
        sModul NVARCHAR(50) DEFAULT '',           -- 'AI', 'SATIS', 'TAHSILAT', 'STOK'
        sDetay NVARCHAR(MAX) NULL,                -- JSON detay
        sAIModel NVARCHAR(50) NULL,               -- 'gpt-4o-mini', 'gemini-flash' vb.
        dtIslem DATETIME DEFAULT GETDATE(),
        sIPAdres NVARCHAR(50) DEFAULT '',
        sPlatform NVARCHAR(20) DEFAULT 'desktop'  -- 'desktop', 'mobil', 'b2b'
    )

    CREATE NONCLUSTERED INDEX IX_tbAuditLog_Tarih ON tbAuditLog (dtIslem)
    CREATE NONCLUSTERED INDEX IX_tbAuditLog_Kullanici ON tbAuditLog (nKullaniciID)
END

-- =====================================================
-- 5. AI VERI ERISIM VIEW'LARI
-- AI sadece bu view'lar uzerinden veri okur
-- =====================================================

-- Cari Risk Verisi (AI icin)
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_AI_CariRiskVerisi')
    DROP VIEW vw_AI_CariRiskVerisi
GO

CREATE VIEW vw_AI_CariRiskVerisi AS
SELECT
    f.nFirmaID,
    RTRIM(ISNULL(f.sAciklama, '')) AS FirmaAd,
    ISNULL(f.sVergiNo, '') AS VergiNo,
    ISNULL(RTRIM(f.sIl), '') AS Il,
    ISNULL(RTRIM(f.sSemt), '') AS Semt,
    ISNULL(f.lKrediLimiti, 0) AS KrediLimiti,
    ISNULL(f.nVadeGun, 0) AS VadeGun,
    ISNULL(f.bTahsilatYapilamaz, 0) AS TahsilatBloke,
    ISNULL(f.bSatisYapilamaz, 0) AS SatisBloke,
    (SELECT ISNULL(SUM(CASE WHEN sBorcAlacak='B' THEN lTutar ELSE 0 END), 0) FROM tbFirmaHareketi WHERE nFirmaID = f.nFirmaID) AS ToplamBorc,
    (SELECT ISNULL(SUM(CASE WHEN sBorcAlacak='A' THEN lTutar ELSE 0 END), 0) FROM tbFirmaHareketi WHERE nFirmaID = f.nFirmaID) AS ToplamAlacak,
    (SELECT ISNULL(SUM(CASE WHEN sBorcAlacak='B' THEN lTutar ELSE 0 END), 0) -
            ISNULL(SUM(CASE WHEN sBorcAlacak='A' THEN lTutar ELSE 0 END), 0)
     FROM tbFirmaHareketi WHERE nFirmaID = f.nFirmaID) AS Bakiye,
    (SELECT ISNULL(SUM(CASE WHEN sBorcAlacak='B' AND dteValorTarihi < GETDATE() THEN lTutar ELSE 0 END), 0) -
            ISNULL(SUM(CASE WHEN sBorcAlacak='A' AND dteValorTarihi < GETDATE() THEN lTutar ELSE 0 END), 0)
     FROM tbFirmaHareketi WHERE nFirmaID = f.nFirmaID) AS VadesiGecmisBakiye,
    (SELECT MAX(DATEDIFF(DAY, dteValorTarihi, GETDATE()))
     FROM tbFirmaHareketi WHERE nFirmaID = f.nFirmaID AND sBorcAlacak='B' AND dteValorTarihi < GETDATE()) AS MaxGecikmeGun,
    (SELECT COUNT(*) FROM tbStokFisiMaster WHERE nFirmaID = f.nFirmaID AND sFisTipi = 'FS' AND dteFisTarihi >= DATEADD(DAY, -90, GETDATE())) AS Son90GunSiparis,
    (SELECT MAX(dteFisTarihi) FROM tbStokFisiMaster WHERE nFirmaID = f.nFirmaID) AS SonIslemTarihi,
    (SELECT MAX(dteIslemTarihi) FROM tbFirmaHareketi WHERE nFirmaID = f.nFirmaID AND sBorcAlacak='A') AS SonOdemeTarihi
FROM tbFirma f
WHERE f.bAktif = 1
GO

-- Satis Gecmisi (AI Satis Oneri icin)
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_AI_SatisGecmisi')
    DROP VIEW vw_AI_SatisGecmisi
GO

CREATE VIEW vw_AI_SatisGecmisi AS
SELECT
    m.nFirmaID,
    m.dteFisTarihi,
    m.lNetTutar,
    m.lKdvTutar,
    d.sStokKodu,
    RTRIM(ISNULL(d.sStokAdi, '')) AS StokAdi,
    d.lMiktar,
    d.sBirim,
    d.lBirimFiyat,
    m.sFisTipi
FROM tbStokFisiMaster m
INNER JOIN tbStokFisiDetay d ON m.nStokFisiID = d.nStokFisiID
WHERE m.sFisTipi IN ('FS', 'FT')
AND m.dteFisTarihi >= DATEADD(MONTH, -6, GETDATE())
GO

PRINT 'AI Altyapi SQL Script basariyla tamamlandi.'
