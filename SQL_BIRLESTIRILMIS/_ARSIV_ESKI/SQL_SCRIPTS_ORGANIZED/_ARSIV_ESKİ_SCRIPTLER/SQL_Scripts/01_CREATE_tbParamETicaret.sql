-- =====================================================
-- E-TİCARET PARAMETRE TABLOSU
-- Pazar yeri bazında maliyet parametrelerini tutar
-- =====================================================

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbParamETicaret]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbParamETicaret](
        [nParamID] INT IDENTITY(1,1) PRIMARY KEY,
        [sPazarYeri] VARCHAR(50) NOT NULL,           -- 'Trendyol', 'HepsiBurada', 'N11', 'Amazon', vb.
        [sKodu] VARCHAR(20) NOT NULL UNIQUE,         -- 'TY', 'HB', 'N11', 'AM' (kısa kod)
        [sSiparisNoOnek] VARCHAR(10) NOT NULL,       -- 'ty(', 'Hb(', 'n11', 'am(' 
        
        -- Komisyon Parametreleri
        [nKomisyonTipi] TINYINT DEFAULT 1,           -- 1=Yüzde, 2=Sabit Tutar
        [nKomisyonOrani] DECIMAL(5,2) DEFAULT 0,     -- Örn: 15.50 (%)
        [lKomisyonSabitTutar] DECIMAL(18,2) DEFAULT 0,
        
        -- Kargo Parametreleri (Şimdilik Sabit)
        [lKargoSabitBedel] DECIMAL(18,2) DEFAULT 0,   -- Örn: 25.00 TL
        
        -- İade Operasyon Parametreleri
        [nIadeOperasyonOrani] DECIMAL(5,2) DEFAULT 0, -- Örn: 3.00 (%)
        
        -- Paketleme Parametreleri
        [nPaketlemeOrani] DECIMAL(5,2) DEFAULT 5.00,  -- Örn: 5.00 (%)
        
        -- Ödeme/İşlem Ücretleri
        [nOdemeIslemUcretiOrani] DECIMAL(5,2) DEFAULT 0,
        [lOdemeIslemSabitUcret] DECIMAL(18,2) DEFAULT 10.00, -- Sabit işlem ücreti
        
        -- Diğer Masraflar (İleride Kullanım İçin)
        [lDigerMasraf1] DECIMAL(18,2) DEFAULT 0,
        [sDigerMasraf1Aciklama] VARCHAR(100),
        [lDigerMasraf2] DECIMAL(18,2) DEFAULT 0,
        [sDigerMasraf2Aciklama] VARCHAR(100),
        
        -- Sistem Alanları
        [bAktif] BIT DEFAULT 1,
        [sKullaniciAdi] VARCHAR(50),
        [dteKayitTarihi] DATETIME DEFAULT GETDATE(),
        [sSonKullaniciAdi] VARCHAR(50),
        [dteSonGuncelleme] DATETIME
    )
    
    PRINT 'tbParamETicaret tablosu oluşturuldu.'
END
ELSE
BEGIN
    PRINT 'tbParamETicaret tablosu zaten mevcut.'
END
GO

-- Index oluştur (performans için)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbParamETicaret_sSiparisNoOnek')
BEGIN
    CREATE INDEX IX_tbParamETicaret_sSiparisNoOnek ON [dbo].[tbParamETicaret]([sSiparisNoOnek])
    PRINT 'IX_tbParamETicaret_sSiparisNoOnek index oluşturuldu.'
END
GO

-- Initial data insert
IF NOT EXISTS (SELECT * FROM tbParamETicaret WHERE sKodu = 'TY')
BEGIN
    INSERT INTO tbParamETicaret (sPazarYeri, sKodu, sSiparisNoOnek, nKomisyonOrani, lKargoSabitBedel, nIadeOperasyonOrani, nPaketlemeOrani, lOdemeIslemSabitUcret, bAktif, sKullaniciAdi)
    VALUES 
    ('Trendyol', 'TY', 'ty(', 15.00, 25.00, 3.00, 5.00, 10.00, 1, 'Admin'),
    ('HepsiBurada', 'HB', 'Hb(', 12.00, 20.00, 3.00, 5.00, 10.00, 1, 'Admin'),
    ('N11', 'N11', 'n11', 14.00, 22.00, 2.50, 5.00, 10.00, 1, 'Admin'),
    ('Amazon', 'AM', 'am(', 15.00, 30.00, 3.00, 5.00, 10.00, 1, 'Admin'),
    ('GittiGidiyor', 'GG', 'gg(', 10.00, 20.00, 2.00, 5.00, 10.00, 1, 'Admin'),
    ('Çiçek Sepeti', 'CS', 'cs(', 18.00, 25.00, 3.50, 5.00, 10.00, 1, 'Admin'),
    ('Kitapyurdu', 'KY', 'ky(', 20.00, 15.00, 2.00, 5.00, 10.00, 1, 'Admin'),
    ('Pttavm', 'PT', 'pt(', 12.50, 18.00, 2.50, 5.00, 10.00, 1, 'Admin'),
    ('Morhipo', 'MH', 'mh(', 16.00, 22.00, 3.00, 5.00, 10.00, 1, 'Admin')
    
    PRINT 'tbParamETicaret tablosuna örnek veriler eklendi.'
END
GO

PRINT 'Script tamamlandı!'
GO
