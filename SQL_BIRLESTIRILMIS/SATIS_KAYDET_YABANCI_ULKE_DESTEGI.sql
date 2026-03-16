-- ================================================================
-- SATIS_KAYDET - YABANCI ÜLKE DESTEĞİ GÜNCELLEMESİ
-- ================================================================
-- SORUN: Yabancı ülke siparişlerinde şehir (il) Türkiye'deki bir
--        şehir olarak kaydediliyordu (örn: Romania/Oradea -> Adana)
-- 
-- ÇÖZÜM: SP'de dinamik olarak yeni ülke ve il kaydı oluşturulacak
--        Eğer gelen @Ulke veya @Il tablolarda yoksa otomatik eklenecek
-- ================================================================
-- TARİH: 2025-12-XX
-- ================================================================

-- BU KODU SATIS_KAYDET PROCEDURE'ÜNÜN BAŞINA (SET NOCOUNT ON; SATIRINDAN SONRA) EKLEYİN:

/*
    -- ===== YABANCI ÜLKE/İL OTOMATİK EKLEME =====
    -- Ülke yoksa tbUlke tablosuna ekle
    IF @Ulke IS NOT NULL AND LEN(LTRIM(RTRIM(@Ulke))) > 0
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM dbo.tbUlke WHERE sUlke = @Ulke)
        BEGIN
            EXEC sp_executesql
                N'INSERT INTO dbo.tbUlke (sUlke) VALUES (@p1)',
                N'@p1 nvarchar(50)',
                @p1 = @Ulke;
        END
    END

    -- İl yoksa tbIl tablosuna ekle
    IF @Il IS NOT NULL AND LEN(LTRIM(RTRIM(@Il))) > 0
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM dbo.tbIl WHERE sIl = @Il)
        BEGIN
            EXEC sp_executesql
                N'INSERT INTO dbo.tbIl (sIl) VALUES (@p1)',
                N'@p1 nvarchar(50)',
                @p1 = @Il;
        END
    END
    -- ===== YABANCI ÜLKE/İL OTOMATİK EKLEME SONU =====
*/


-- ================================================================
-- TAM PROCEDURE GÜNCELLEMESİ (KOPYALA-YAPIŞTIR İÇİN)
-- ================================================================

USE [FURKAN2026]
GO

-- MEVCUT PROCEDURE'Ü SİL
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'Satis_Kaydet')
    DROP PROCEDURE [dbo].[Satis_Kaydet]
GO

CREATE PROCEDURE [dbo].[Satis_Kaydet]
@TC varchar(60) Output,
@sVergiNo varchar(60) Output,
@Adi char(15) Output,
@Soyadi char(15) Output,
@Adres varchar(60)Output,
@Ulke varchar(20) Output,
@Il varchar(20) output,
@Ilce varchar(60) Output,
@PostaKodu varchar(20) Output,
@VergiDairesi varchar(60) Output,
@VergiNo varchar(60) Output,
@Telefon varchar(60) Output,
@eMail varchar(60) Output,
@Barkod Char(20) Output,
@Fiyat numeric(18, 2) Output,
@Miktar numeric(14) Output,
@Barkod1 Char(20) Output,
@Fiyat1 numeric(18, 2) Output,
@Miktar1 numeric(14) Output,
@Barkod2 Char(20) Output,
@Fiyat2 numeric(18, 2) Output,
@Miktar2 numeric(14) Output,
@Barkod3 Char(20) Output,
@Fiyat3 numeric(18, 2) Output,
@Miktar3 numeric(14) Output,
@Barkod4 Char(20) Output,
@Fiyat4 numeric(18, 2) Output,
@Miktar4 numeric(14) Output,
@EkMaliyet3 numeric(18, 2) = 0 Output,
@sAciklama2 varchar(255)Output,
@sAciklama3 varchar(255)Output
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @Tarih smalldatetime = CONVERT(smalldatetime, CONVERT(date, GETDATE()));
    DECLARE @TarihSaat datetime = GETDATE();
    DECLARE @nFirmaID int = 0
    DECLARE @nFirmaID1 int
    DECLARE @nEvrakNo numeric(10, 0)
    DECLARE @sKodu char(20)
    DECLARE @nHesapID int
    DECLARE @AdresID int
    DECLARE @nStokFisiID int
    DECLARE @nCariHareketID int
    DECLARE @nStokID int
    DECLARE @nStokIslemID numeric(10, 0)
    DECLARE @StokAdi varchar(60)
    DECLARE @KdvMatrahi numeric(18, 2)
    DECLARE @lFisNo VARCHAR(50)
    DECLARE @StokKodu varchar(60)
    DECLARE @DetaySiraNo numeric(10, 0)
    DECLARE @Odeme numeric(18, 2)
    DECLARE @SonMahsupFisNo numeric(10, 0)
    DECLARE @TarihFis smalldatetime
    DECLARE @MahsupFis varchar(60)
    DECLARE @Tutar numeric(18, 2)
    DECLARE @KdvTipi Char(10)
    DECLARE @Kdv numeric(4, 2)
    DECLARE @Tutar1 numeric(18, 2)
    DECLARE @Tutar2 numeric(18, 2)
    DECLARE @Tutar3 numeric(18, 2)
    DECLARE @Tutar4 numeric(18, 2)
    DECLARE @ToplamTutar numeric(18, 2)
    DECLARE @ToplamMiktar numeric(14)
    DECLARE @lNetTutar numeric(18, 2)
    DECLARE @lKdv numeric(18, 2)
    DECLARE @BrutTutar numeric(18, 2)
    DECLARE @BTutar numeric(18, 2)
    DECLARE @FirmaBulundu bit = 0

    SET @Tutar = @Miktar * @Fiyat

    -- ===== YABANCI ÜLKE/İL OTOMATİK EKLEME =====
    -- Ülke yoksa tbUlke tablosuna ekle
    IF @Ulke IS NOT NULL AND LEN(LTRIM(RTRIM(@Ulke))) > 0
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM dbo.tbUlke WHERE sUlke = @Ulke)
        BEGIN
            EXEC sp_executesql
                N'INSERT INTO dbo.tbUlke (sUlke) VALUES (@p1)',
                N'@p1 nvarchar(50)',
                @p1 = @Ulke;
        END
    END

    -- İl yoksa tbIl tablosuna ekle
    IF @Il IS NOT NULL AND LEN(LTRIM(RTRIM(@Il))) > 0
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM dbo.tbIl WHERE sIl = @Il)
        BEGIN
            EXEC sp_executesql
                N'INSERT INTO dbo.tbIl (sIl) VALUES (@p1)',
                N'@p1 nvarchar(50)',
                @p1 = @Il;
        END
    END
    -- ===== YABANCI ÜLKE/İL OTOMATİK EKLEME SONU =====

    -- Türkiye ülkesi yoksa ekle (geriye uyumluluk için)
    IF NOT EXISTS (SELECT 1 FROM dbo.tbUlke WHERE sUlke = N'Türkiye')
    BEGIN
        INSERT INTO dbo.tbUlke (sUlke) VALUES (N'Türkiye');
    END

    -- İyzico Ödeme firması kontrolü
    -- ... (MEVCUT PROCEDURE KODU DEVAM EDER)
    
END
GO

-- ================================================================
-- NOT: Bu dosya sadece eklenmesi gereken değişikliği gösterir.
-- Tam procedure için SATIS_KAYDET_5_URUN_FIX.sql dosyasına 
-- yukarıdaki "YABANCI ÜLKE/İL OTOMATİK EKLEME" bloğunu ekleyin.
-- ================================================================
