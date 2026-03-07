-- =============================================
-- DESTEK TICKET SİSTEMİ - SQL Server Tablosu
-- Barkod Mağaza - frm_BizeSorun için
-- =============================================

-- Tablo oluştur (yoksa)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DESTEK_TICKET')
BEGIN
    CREATE TABLE DESTEK_TICKET (
        ID INT IDENTITY(1,1) PRIMARY KEY,
        TicketNo NVARCHAR(20) NOT NULL,
        TicketSiraNo INT NOT NULL,
        MusteriAd NVARCHAR(100),
        MusteriEmail NVARCHAR(100),
        MusteriTelefon NVARCHAR(20),
        Kategori NVARCHAR(50),
        Konu NVARCHAR(200),
        Mesaj NVARCHAR(MAX),
        Oncelik NVARCHAR(20) DEFAULT 'Normal',
        Durum NVARCHAR(20) DEFAULT 'Açık',
        SistemBilgisi NVARCHAR(MAX),
        EkliDosyaSayisi INT DEFAULT 0,
        OlusturmaTarihi DATETIME DEFAULT GETDATE(),
        GuncellemeTarihi DATETIME,
        OnayKodu NVARCHAR(50),
        Yanit NVARCHAR(MAX),
        YanitTarihi DATETIME,
        AtananKisi NVARCHAR(100),
        NotlarInternal NVARCHAR(MAX)
    );
    
    PRINT 'DESTEK_TICKET tablosu oluşturuldu.';
END
ELSE
BEGIN
    PRINT 'DESTEK_TICKET tablosu zaten mevcut.';
END
GO

-- İndexler
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_DESTEK_TICKET_TicketNo')
BEGIN
    CREATE UNIQUE INDEX IX_DESTEK_TICKET_TicketNo ON DESTEK_TICKET(TicketNo);
    PRINT 'IX_DESTEK_TICKET_TicketNo indeksi oluşturuldu.';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_DESTEK_TICKET_OnayKodu')
BEGIN
    CREATE INDEX IX_DESTEK_TICKET_OnayKodu ON DESTEK_TICKET(OnayKodu);
    PRINT 'IX_DESTEK_TICKET_OnayKodu indeksi oluşturuldu.';
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_DESTEK_TICKET_Durum')
BEGIN
    CREATE INDEX IX_DESTEK_TICKET_Durum ON DESTEK_TICKET(Durum);
    PRINT 'IX_DESTEK_TICKET_Durum indeksi oluşturuldu.';
END
GO

-- Örnek durum değerleri için kontrol
-- Durum: 'Açık', 'İşlemde', 'Beklemede', 'Çözüldü', 'Kapatıldı'
-- Öncelik: 'Normal', 'Acil', 'Arayın'
-- Kategori: 'Hata Bildirimi', 'Kullanım Sorusu', 'Özellik Talebi', 'Lisans/Aktivasyon', 'Performans', 'Entegrasyon', 'Diğer'

-- =============================================
-- FAYDALI SORGULAR
-- =============================================

-- Tüm açık ticket'ları listele
-- SELECT * FROM DESTEK_TICKET WHERE Durum = 'Açık' ORDER BY OlusturmaTarihi DESC;

-- Acil ticket'ları listele
-- SELECT * FROM DESTEK_TICKET WHERE Oncelik IN ('Acil', 'Arayın') AND Durum <> 'Çözüldü' ORDER BY OlusturmaTarihi DESC;

-- Belirli bir müşterinin ticket'ları
-- SELECT * FROM DESTEK_TICKET WHERE OnayKodu = 'XXXX' ORDER BY OlusturmaTarihi DESC;

-- Ticket durumunu güncelle
-- UPDATE DESTEK_TICKET SET Durum = 'İşlemde', GuncellemeTarihi = GETDATE() WHERE TicketNo = 'TKT-2024-00001';

-- Ticket'a yanıt ekle
-- UPDATE DESTEK_TICKET SET Yanit = 'Yanıt metni...', YanitTarihi = GETDATE(), Durum = 'Çözüldü', GuncellemeTarihi = GETDATE() WHERE TicketNo = 'TKT-2024-00001';

-- İstatistikler
-- SELECT 
--     Durum,
--     COUNT(*) AS Adet,
--     AVG(DATEDIFF(HOUR, OlusturmaTarihi, ISNULL(YanitTarihi, GETDATE()))) AS OrtalamaYanitSuresi_Saat
-- FROM DESTEK_TICKET
-- GROUP BY Durum;

PRINT 'DESTEK_TICKET kurulumu tamamlandı.';
GO
