-- =============================================
-- AUDIT LOG SİSTEMİ - VERITABANI YAPISI
-- Versiyon: 1.0
-- Oluşturma Tarihi: 2025-12-11
-- Açıklama: Tüm modüllerdeki işlemleri kaydeden merkezi audit log tablosu
-- =============================================

USE [BARKOD_MAGAZA]
GO

-- =============================================
-- 1. ANA AUDIT LOG TABLOSU
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbAuditLog]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbAuditLog](
        -- Primary Key
        [nAuditLogID] [bigint] IDENTITY(1,1) NOT NULL,
        
        -- Modül ve Kayıt Bilgileri
        [sModulAdi] [nvarchar](50) NOT NULL,                    -- Sipariş, Fatura, Perakende, Stok, Müşteri, Finans
        [sTabloAdi] [nvarchar](100) NOT NULL,                   -- tbSiparis, tbStokFisiMaster, tbCari vb.
        [nKayitID] [bigint] NULL,                               -- İlgili kaydın ID'si
        [sKayitReferans] [nvarchar](100) NULL,                  -- Ek referans (Fiş No, Sipariş No vb.)
        
        -- İşlem Bilgileri
        [sIslemTipi] [nvarchar](50) NOT NULL,                   -- INSERT, UPDATE, DELETE, APPROVE, CANCEL, ROLLBACK, RESTORE
        [sIslemAciklama] [nvarchar](500) NULL,                  -- İşlem açıklaması
        [sAlanAdi] [nvarchar](100) NULL,                        -- Değişen alan adı (UPDATE için)
        [sEskiDeger] [nvarchar](max) NULL,                      -- Eski değer
        [sYeniDeger] [nvarchar](max) NULL,                      -- Yeni değer
        [sJsonData] [nvarchar](max) NULL,                       -- Tüm kayıt JSON formatında (DELETE ve detaylı log için)
        
        -- Kullanıcı ve Sistem Bilgileri
        [sKullaniciAdi] [nvarchar](100) NOT NULL,               -- Uygulama kullanıcı adı
        [sWindowsKullanici] [nvarchar](100) NULL,               -- Windows domain\user
        [dteIslemZamani] [datetime] NOT NULL DEFAULT GETDATE(), -- İşlem tarihi ve saati
        
        -- Bilgisayar Bilgileri
        [sBilgisayarAdi] [nvarchar](100) NULL,                  -- PC hostname
        [sIPAdresi] [nvarchar](50) NULL,                        -- IP adresi
        [sMACAdres] [nvarchar](100) NULL,                       -- MAC adresi
        [sUygulamaVersiyon] [nvarchar](50) NULL,                -- Uygulama versiyonu
        
        -- Geri Alma Bilgileri
        [bGeriAlindi] [bit] NOT NULL DEFAULT 0,                 -- Bu işlem geri alındı mı?
        [nGeriAlanKullaniciID] [int] NULL,                      -- Geri alan kullanıcı
        [dteGeriAlmaTarihi] [datetime] NULL,                    -- Geri alma tarihi
        [nIliskiliAuditID] [bigint] NULL,                       -- İlişkili audit log ID (geri alma için)
        
        -- Ek Bilgiler
        [nIslemSuresi] [int] NULL,                              -- İşlem süresi (milisaniye)
        [sEkNotlar] [nvarchar](500) NULL,                       -- Ek notlar
        
        CONSTRAINT [PK_tbAuditLog] PRIMARY KEY CLUSTERED ([nAuditLogID] ASC)
    )
    
    PRINT 'tbAuditLog tablosu başarıyla oluşturuldu.'
END
ELSE
BEGIN
    PRINT 'tbAuditLog tablosu zaten mevcut.'
END
GO

-- =============================================
-- 2. İNDEXLER (Performans için)
-- =============================================

-- Modül ve tarih bazlı sorgular için
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbAuditLog_ModulTarih')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tbAuditLog_ModulTarih]
    ON [dbo].[tbAuditLog] ([sModulAdi], [dteIslemZamani] DESC)
    INCLUDE ([nKayitID], [sIslemTipi], [sKullaniciAdi])
    PRINT 'IX_tbAuditLog_ModulTarih indexi oluşturuldu.'
END
GO

-- Kayıt ID bazlı sorgular için
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbAuditLog_KayitID')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tbAuditLog_KayitID]
    ON [dbo].[tbAuditLog] ([nKayitID], [sModulAdi], [sTabloAdi])
    INCLUDE ([dteIslemZamani], [sIslemTipi], [sKullaniciAdi])
    PRINT 'IX_tbAuditLog_KayitID indexi oluşturuldu.'
END
GO

-- Kullanıcı bazlı sorgular için
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbAuditLog_Kullanici')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tbAuditLog_Kullanici]
    ON [dbo].[tbAuditLog] ([sKullaniciAdi], [dteIslemZamani] DESC)
    INCLUDE ([sModulAdi], [sIslemTipi], [nKayitID])
    PRINT 'IX_tbAuditLog_Kullanici indexi oluşturuldu.'
END
GO

-- İşlem tipi bazlı sorgular için
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbAuditLog_IslemTipi')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tbAuditLog_IslemTipi]
    ON [dbo].[tbAuditLog] ([sIslemTipi], [dteIslemZamani] DESC)
    INCLUDE ([sModulAdi], [nKayitID], [sKullaniciAdi])
    PRINT 'IX_tbAuditLog_IslemTipi indexi oluşturuldu.'
END
GO

-- Geri alınabilir kayıtlar için
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbAuditLog_GeriAlma')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tbAuditLog_GeriAlma]
    ON [dbo].[tbAuditLog] ([bGeriAlindi], [sIslemTipi])
    INCLUDE ([nKayitID], [sModulAdi], [dteIslemZamani])
    PRINT 'IX_tbAuditLog_GeriAlma indexi oluşturuldu.'
END
GO

-- =============================================
-- 3. YARDIMCI TABLOLAR
-- =============================================

-- İşlem Tipleri Referans Tablosu
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbAuditIslemTipleri]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbAuditIslemTipleri](
        [nIslemTipID] [int] IDENTITY(1,1) NOT NULL,
        [sIslemKodu] [nvarchar](50) NOT NULL,
        [sIslemAdi] [nvarchar](100) NOT NULL,
        [sAciklama] [nvarchar](500) NULL,
        [sRenk] [nvarchar](20) NULL,  -- UI'da gösterim için
        [nSiraNo] [int] NULL,
        [bAktif] [bit] NOT NULL DEFAULT 1,
        CONSTRAINT [PK_tbAuditIslemTipleri] PRIMARY KEY CLUSTERED ([nIslemTipID] ASC),
        CONSTRAINT [UK_tbAuditIslemTipleri_Kod] UNIQUE ([sIslemKodu])
    )
    
    -- Varsayılan işlem tiplerini ekle
    INSERT INTO [dbo].[tbAuditIslemTipleri] ([sIslemKodu], [sIslemAdi], [sAciklama], [sRenk], [nSiraNo])
    VALUES 
        ('INSERT', 'Yeni Kayıt', 'Yeni kayıt oluşturuldu', 'Green', 1),
        ('UPDATE', 'Güncelleme', 'Kayıt güncellendi', 'Blue', 2),
        ('DELETE', 'Silme', 'Kayıt silindi', 'Red', 3),
        ('APPROVE', 'Onay', 'Kayıt onaylandı', 'DarkGreen', 4),
        ('CANCEL', 'İptal', 'Kayıt iptal edildi', 'Orange', 5),
        ('RESTORE', 'Geri Yükleme', 'Silinen kayıt geri yüklendi', 'Purple', 6),
        ('ROLLBACK', 'Geri Alma', 'İşlem geri alındı', 'DarkRed', 7),
        ('VIEW', 'Görüntüleme', 'Kayıt görüntülendi', 'Gray', 8),
        ('PRINT', 'Yazdırma', 'Kayıt yazdırıldı', 'Navy', 9),
        ('EXPORT', 'Dışa Aktarma', 'Kayıt dışa aktarıldı', 'Teal', 10)
    
    PRINT 'tbAuditIslemTipleri tablosu oluşturuldu ve varsayılan veriler eklendi.'
END
GO

-- Modül Referans Tablosu
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbAuditModuller]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[tbAuditModuller](
        [nModulID] [int] IDENTITY(1,1) NOT NULL,
        [sModulKodu] [nvarchar](50) NOT NULL,
        [sModulAdi] [nvarchar](100) NOT NULL,
        [sAciklama] [nvarchar](500) NULL,
        [sAnaTabloAdi] [nvarchar](100) NULL,
        [bLogAktif] [bit] NOT NULL DEFAULT 1,
        [bDetayliLog] [bit] NOT NULL DEFAULT 1,  -- Alan bazlı değişiklik logu
        [nSiraNo] [int] NULL,
        CONSTRAINT [PK_tbAuditModuller] PRIMARY KEY CLUSTERED ([nModulID] ASC),
        CONSTRAINT [UK_tbAuditModuller_Kod] UNIQUE ([sModulKodu])
    )
    
    -- Varsayılan modülleri ekle
    INSERT INTO [dbo].[tbAuditModuller] ([sModulKodu], [sModulAdi], [sAciklama], [sAnaTabloAdi], [bLogAktif], [bDetayliLog], [nSiraNo])
    VALUES 
        ('SIPARIS', 'Sipariş Yönetimi', 'Satın alma ve satış siparişleri', 'tbSiparis', 1, 1, 1),
        ('FATURA', 'Fatura İşlemleri', 'Alış ve satış faturaları', 'tbStokFisiMaster', 1, 1, 2),
        ('PERAKENDE', 'Perakende Satış', 'POS satış işlemleri', 'tbStokFisiMaster', 1, 1, 3),
        ('STOK', 'Stok Yönetimi', 'Stok kartı ve hareket işlemleri', 'tbStok', 1, 1, 4),
        ('MUSTERI', 'Müşteri/Cari Yönetimi', 'Müşteri ve cari kart işlemleri', 'tbCari', 1, 1, 5),
        ('FINANS', 'Finans İşlemleri', 'Kasa, banka, çek işlemleri', 'tbFinans', 1, 1, 6),
        ('ETICARET', 'E-Ticaret', 'E-ticaret sipariş ve entegrasyon işlemleri', 'tbEticaretSiparis', 1, 1, 7),
        ('PERSONEL', 'Personel Yönetimi', 'Personel ve yetki işlemleri', 'tbPersonel', 1, 0, 8),
        ('PARAMETRE', 'Parametre Yönetimi', 'Sistem parametreleri', 'tbParametre', 1, 0, 9),
        ('SISTEM', 'Sistem İşlemleri', 'Genel sistem işlemleri', NULL, 1, 0, 10)
    
    PRINT 'tbAuditModuller tablosu oluşturuldu ve varsayılan veriler eklendi.'
END
GO

-- =============================================
-- 4. STORED PROCEDURES
-- =============================================

-- Audit Log Kaydetme Procedure
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_AuditLog_Kaydet]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[sp_AuditLog_Kaydet]
GO

CREATE PROCEDURE [dbo].[sp_AuditLog_Kaydet]
    @sModulAdi NVARCHAR(50),
    @sTabloAdi NVARCHAR(100),
    @nKayitID BIGINT = NULL,
    @sKayitReferans NVARCHAR(100) = NULL,
    @sIslemTipi NVARCHAR(50),
    @sIslemAciklama NVARCHAR(500) = NULL,
    @sAlanAdi NVARCHAR(100) = NULL,
    @sEskiDeger NVARCHAR(MAX) = NULL,
    @sYeniDeger NVARCHAR(MAX) = NULL,
    @sJsonData NVARCHAR(MAX) = NULL,
    @sKullaniciAdi NVARCHAR(100),
    @sWindowsKullanici NVARCHAR(100) = NULL,
    @sBilgisayarAdi NVARCHAR(100) = NULL,
    @sIPAdresi NVARCHAR(50) = NULL,
    @sMACAdres NVARCHAR(100) = NULL,
    @sUygulamaVersiyon NVARCHAR(50) = NULL,
    @nIslemSuresi INT = NULL,
    @sEkNotlar NVARCHAR(500) = NULL,
    @nYeniAuditLogID BIGINT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        INSERT INTO [dbo].[tbAuditLog] (
            [sModulAdi], [sTabloAdi], [nKayitID], [sKayitReferans],
            [sIslemTipi], [sIslemAciklama], [sAlanAdi], [sEskiDeger], [sYeniDeger], [sJsonData],
            [sKullaniciAdi], [sWindowsKullanici], [dteIslemZamani],
            [sBilgisayarAdi], [sIPAdresi], [sMACAdres], [sUygulamaVersiyon],
            [nIslemSuresi], [sEkNotlar]
        )
        VALUES (
            @sModulAdi, @sTabloAdi, @nKayitID, @sKayitReferans,
            @sIslemTipi, @sIslemAciklama, @sAlanAdi, @sEskiDeger, @sYeniDeger, @sJsonData,
            @sKullaniciAdi, @sWindowsKullanici, GETDATE(),
            @sBilgisayarAdi, @sIPAdresi, @sMACAdres, @sUygulamaVersiyon,
            @nIslemSuresi, @sEkNotlar
        )
        
        SET @nYeniAuditLogID = SCOPE_IDENTITY()
        
        RETURN 0
    END TRY
    BEGIN CATCH
        PRINT 'HATA: ' + ERROR_MESSAGE()
        RETURN -1
    END CATCH
END
GO

PRINT 'sp_AuditLog_Kaydet procedure oluşturuldu.'
GO

-- Kayıt Geçmişi Getirme Procedure
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_AuditLog_KayitGecmisi]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[sp_AuditLog_KayitGecmisi]
GO

CREATE PROCEDURE [dbo].[sp_AuditLog_KayitGecmisi]
    @sModulAdi NVARCHAR(50) = NULL,
    @nKayitID BIGINT = NULL,
    @sTabloAdi NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        al.*,
        it.sIslemAdi,
        it.sRenk
    FROM [dbo].[tbAuditLog] al
    LEFT JOIN [dbo].[tbAuditIslemTipleri] it ON al.sIslemTipi = it.sIslemKodu
    WHERE 
        (@sModulAdi IS NULL OR al.sModulAdi = @sModulAdi)
        AND (@nKayitID IS NULL OR al.nKayitID = @nKayitID)
        AND (@sTabloAdi IS NULL OR al.sTabloAdi = @sTabloAdi)
    ORDER BY al.dteIslemZamani DESC, al.nAuditLogID DESC
END
GO

PRINT 'sp_AuditLog_KayitGecmisi procedure oluşturuldu.'
GO

-- =============================================
-- 5. SOFT DELETE İÇİN ANA TABLOLARA KOLON EKLEMELERİ
-- =============================================

-- tbSiparis tablosuna soft delete kolonları
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbSiparis]'))
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbSiparis]') AND name = 'bSilindi')
    BEGIN
        ALTER TABLE [dbo].[tbSiparis] ADD [bSilindi] BIT NOT NULL DEFAULT 0
        PRINT 'tbSiparis.bSilindi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbSiparis]') AND name = 'dteSilinmeTarihi')
    BEGIN
        ALTER TABLE [dbo].[tbSiparis] ADD [dteSilinmeTarihi] DATETIME NULL
        PRINT 'tbSiparis.dteSilinmeTarihi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbSiparis]') AND name = 'sSilenKullanici')
    BEGIN
        ALTER TABLE [dbo].[tbSiparis] ADD [sSilenKullanici] NVARCHAR(100) NULL
        PRINT 'tbSiparis.sSilenKullanici kolonu eklendi.'
    END
END
GO

-- tbStokFisiMaster tablosuna soft delete kolonları
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbStokFisiMaster]'))
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbStokFisiMaster]') AND name = 'bSilindi')
    BEGIN
        ALTER TABLE [dbo].[tbStokFisiMaster] ADD [bSilindi] BIT NOT NULL DEFAULT 0
        PRINT 'tbStokFisiMaster.bSilindi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbStokFisiMaster]') AND name = 'dteSilinmeTarihi')
    BEGIN
        ALTER TABLE [dbo].[tbStokFisiMaster] ADD [dteSilinmeTarihi] DATETIME NULL
        PRINT 'tbStokFisiMaster.dteSilinmeTarihi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbStokFisiMaster]') AND name = 'sSilenKullanici')
    BEGIN
        ALTER TABLE [dbo].[tbStokFisiMaster] ADD [sSilenKullanici] NVARCHAR(100) NULL
        PRINT 'tbStokFisiMaster.sSilenKullanici kolonu eklendi.'
    END
END
GO

-- tbCari tablosuna soft delete kolonları
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbCari]'))
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbCari]') AND name = 'bSilindi')
    BEGIN
        ALTER TABLE [dbo].[tbCari] ADD [bSilindi] BIT NOT NULL DEFAULT 0
        PRINT 'tbCari.bSilindi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbCari]') AND name = 'dteSilinmeTarihi')
    BEGIN
        ALTER TABLE [dbo].[tbCari] ADD [dteSilinmeTarihi] DATETIME NULL
        PRINT 'tbCari.dteSilinmeTarihi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbCari]') AND name = 'sSilenKullanici')
    BEGIN
        ALTER TABLE [dbo].[tbCari] ADD [sSilenKullanici] NVARCHAR(100) NULL
        PRINT 'tbCari.sSilenKullanici kolonu eklendi.'
    END
END
GO

-- tbStok tablosuna soft delete kolonları
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbStok]'))
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbStok]') AND name = 'bSilindi')
    BEGIN
        ALTER TABLE [dbo].[tbStok] ADD [bSilindi] BIT NOT NULL DEFAULT 0
        PRINT 'tbStok.bSilindi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbStok]') AND name = 'dteSilinmeTarihi')
    BEGIN
        ALTER TABLE [dbo].[tbStok] ADD [dteSilinmeTarihi] DATETIME NULL
        PRINT 'tbStok.dteSilinmeTarihi kolonu eklendi.'
    END
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[tbStok]') AND name = 'sSilenKullanici')
    BEGIN
        ALTER TABLE [dbo].[tbStok] ADD [sSilenKullanici] NVARCHAR(100) NULL
        PRINT 'tbStok.sSilenKullanici kolonu eklendi.'
    END
END
GO

PRINT ''
PRINT '============================================='
PRINT 'AUDIT LOG SİSTEMİ KURULUMU TAMAMLANDI!'
PRINT '============================================='
PRINT 'Oluşturulan Tablolar:'
PRINT '  - tbAuditLog (Ana log tablosu)'
PRINT '  - tbAuditIslemTipleri (İşlem tipleri referans)'
PRINT '  - tbAuditModuller (Modül referans)'
PRINT ''
PRINT 'Oluşturulan İndexler: 5 adet'
PRINT 'Oluşturulan Stored Procedures: 2 adet'
PRINT 'Soft Delete Kolonları: 4 tabloya eklendi'
PRINT ''
PRINT 'Sonraki Adım: AuditLogger.vb helper class projeye eklenecek'
PRINT '============================================='
