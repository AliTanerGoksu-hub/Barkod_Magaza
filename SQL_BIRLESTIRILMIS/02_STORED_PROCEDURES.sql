-- =====================================================================
-- BARKOD MAGAZA - STORED PROCEDURES
-- =====================================================================
-- Versiyon: 1.0
-- Tarih: Ocak 2025
-- Açıklama: Tüm stored procedure tanımları
-- =====================================================================

USE [VERITABANI_ADINIZ]
GO

PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     STORED PROCEDURES KURULUMU BASLIYOR                      ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''

-- =====================================================================
-- 1. AUDIT LOG KAYDETME PROCEDURE
-- =====================================================================
PRINT '▶ 1. sp_AuditLog_Kaydet Procedure'
GO

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

PRINT '  ✓ sp_AuditLog_Kaydet procedure oluşturuldu'
GO

-- =====================================================================
-- 2. KAYIT GEÇMİŞİ GETİRME PROCEDURE
-- =====================================================================
PRINT ''
PRINT '▶ 2. sp_AuditLog_KayitGecmisi Procedure'
GO

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

PRINT '  ✓ sp_AuditLog_KayitGecmisi procedure oluşturuldu'
GO

-- =====================================================================
-- 3. E-TİCARET MALİYET HESAPLAMA FONKSİYONU
-- =====================================================================
PRINT ''
PRINT '▶ 3. fn_HesaplaEkMaliyet Fonksiyonu'
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_HesaplaEkMaliyet]') AND type in (N'FN'))
    DROP FUNCTION [dbo].[fn_HesaplaEkMaliyet]
GO

CREATE FUNCTION [dbo].[fn_HesaplaEkMaliyet]
(
    @SiparisNoOnek VARCHAR(10),
    @ToplamSatisTutari DECIMAL(18,2)
)
RETURNS DECIMAL(18,2)
AS
BEGIN
    DECLARE @EkMaliyet DECIMAL(18,2) = 0
    DECLARE @Komisyon DECIMAL(18,2) = 0
    DECLARE @Kargo DECIMAL(18,2) = 0
    DECLARE @IadeOp DECIMAL(18,2) = 0
    DECLARE @Paketleme DECIMAL(18,2) = 0
    DECLARE @OdemeIslem DECIMAL(18,2) = 0
    
    SELECT 
        @Komisyon = CASE 
            WHEN nKomisyonTipi = 1 THEN @ToplamSatisTutari * (nKomisyonOrani / 100)
            ELSE lKomisyonSabitTutar
        END,
        @Kargo = lKargoSabitBedel,
        @IadeOp = @ToplamSatisTutari * (nIadeOperasyonOrani / 100),
        @Paketleme = @ToplamSatisTutari * (nPaketlemeOrani / 100),
        @OdemeIslem = CASE 
            WHEN nOdemeIslemUcretiOrani > 0 THEN @ToplamSatisTutari * (nOdemeIslemUcretiOrani / 100)
            ELSE lOdemeIslemSabitUcret
        END
    FROM tbParamETicaret
    WHERE sSiparisNoOnek = @SiparisNoOnek AND bAktif = 1
    
    SET @EkMaliyet = ISNULL(@Komisyon, 0) + ISNULL(@Kargo, 0) + ISNULL(@IadeOp, 0) + 
                     ISNULL(@Paketleme, 0) + ISNULL(@OdemeIslem, 0)
    
    RETURN @EkMaliyet
END
GO

PRINT '  ✓ fn_HesaplaEkMaliyet fonksiyonu oluşturuldu'
GO

-- =====================================================================
-- 4. BİLDİRİM GÖNDERME PROCEDURE (Temel)
-- =====================================================================
PRINT ''
PRINT '▶ 4. sp_BildirimGonder Procedure'
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_BildirimGonder]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[sp_BildirimGonder]
GO

CREATE PROCEDURE [dbo].[sp_BildirimGonder]
    @sTipKodu NVARCHAR(50),
    @nAliciID INT,
    @sAliciAdi NVARCHAR(200),
    @sAliciEmail NVARCHAR(200) = NULL,
    @sAliciTelefon NVARCHAR(50) = NULL,
    @sBaslik NVARCHAR(200),
    @sMesaj NVARCHAR(MAX),
    @sKanal NVARCHAR(20) = 'Uygulama', -- Uygulama, Email, SMS, WhatsApp
    @sReferansID NVARCHAR(100) = NULL,
    @nYeniLogID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        INSERT INTO tbBildirimLog (
            sTipKodu, nAliciID, sAliciAdi, sAliciEmail, sAliciTelefon,
            sBaslik, sMesaj, sKanal, sGonderimDurum, sReferansID,
            sGonderenMakine, dteOlusturma
        )
        VALUES (
            @sTipKodu, @nAliciID, @sAliciAdi, @sAliciEmail, @sAliciTelefon,
            @sBaslik, @sMesaj, @sKanal, 'Gonderildi', @sReferansID,
            HOST_NAME(), GETDATE()
        )
        
        SET @nYeniLogID = SCOPE_IDENTITY()
        RETURN 0
    END TRY
    BEGIN CATCH
        PRINT 'HATA: ' + ERROR_MESSAGE()
        SET @nYeniLogID = 0
        RETURN -1
    END CATCH
END
GO

PRINT '  ✓ sp_BildirimGonder procedure oluşturuldu'
GO

-- =====================================================================
-- 5. STOK AI İÇERİK KAYDETME PROCEDURE
-- =====================================================================
PRINT ''
PRINT '▶ 5. sp_StokAIIcerikKaydet Procedure'
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_StokAIIcerikKaydet]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[sp_StokAIIcerikKaydet]
GO

CREATE PROCEDURE [dbo].[sp_StokAIIcerikKaydet]
    @nStokID INT,
    @sModel NVARCHAR(50),
    @sSEOBaslik NVARCHAR(200) = NULL,
    @sKisaAciklama NVARCHAR(500) = NULL,
    @sDetayliAciklama NVARCHAR(MAX) = NULL,
    @sOzelliklerHTML NVARCHAR(MAX) = NULL,
    @sKullanimTalimati NVARCHAR(MAX) = NULL,
    @sBedenTablosu NVARCHAR(MAX) = NULL,
    @sMetaDescription NVARCHAR(200) = NULL,
    @sAnahtarKelimeler NVARCHAR(500) = NULL,
    @nIcerikPuani INT = 0,
    @nAIMaliyet DECIMAL(10,4) = 0
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Mevcut kayıt var mı kontrol et (Model bazlı)
        IF EXISTS (SELECT 1 FROM tbStokAIIcerik WHERE sModel = @sModel)
        BEGIN
            -- Güncelle
            UPDATE tbStokAIIcerik SET
                sSEOBaslik = ISNULL(@sSEOBaslik, sSEOBaslik),
                sKisaAciklama = ISNULL(@sKisaAciklama, sKisaAciklama),
                sDetayliAciklama = ISNULL(@sDetayliAciklama, sDetayliAciklama),
                sOzelliklerHTML = ISNULL(@sOzelliklerHTML, sOzelliklerHTML),
                sKullanimTalimati = ISNULL(@sKullanimTalimati, sKullanimTalimati),
                sBedenTablosu = ISNULL(@sBedenTablosu, sBedenTablosu),
                sMetaDescription = ISNULL(@sMetaDescription, sMetaDescription),
                sAnahtarKelimeler = ISNULL(@sAnahtarKelimeler, sAnahtarKelimeler),
                nIcerikPuani = @nIcerikPuani,
                nAIMaliyet = nAIMaliyet + @nAIMaliyet,
                dteGuncelleme = GETDATE()
            WHERE sModel = @sModel
            
            PRINT 'AI içerik güncellendi: ' + @sModel
        END
        ELSE
        BEGIN
            -- Yeni kayıt ekle
            INSERT INTO tbStokAIIcerik (
                nStokID, sModel, sSEOBaslik, sKisaAciklama, sDetayliAciklama,
                sOzelliklerHTML, sKullanimTalimati, sBedenTablosu,
                sMetaDescription, sAnahtarKelimeler, nIcerikPuani, nAIMaliyet,
                dteOlusturma, dteGuncelleme
            )
            VALUES (
                @nStokID, @sModel, @sSEOBaslik, @sKisaAciklama, @sDetayliAciklama,
                @sOzelliklerHTML, @sKullanimTalimati, @sBedenTablosu,
                @sMetaDescription, @sAnahtarKelimeler, @nIcerikPuani, @nAIMaliyet,
                GETDATE(), GETDATE()
            )
            
            PRINT 'AI içerik eklendi: ' + @sModel
        END
        
        -- tbStok tablosunu güncelle
        UPDATE tbStok SET 
            bAIIcerikVar = 1,
            dteAISonGuncelleme = GETDATE()
        WHERE nStokID = @nStokID
        
        RETURN 0
    END TRY
    BEGIN CATCH
        PRINT 'HATA: ' + ERROR_MESSAGE()
        RETURN -1
    END CATCH
END
GO

PRINT '  ✓ sp_StokAIIcerikKaydet procedure oluşturuldu'
GO

-- =====================================================================
-- ÖZET
-- =====================================================================
PRINT ''
PRINT '╔══════════════════════════════════════════════════════════════╗'
PRINT '║     STORED PROCEDURES KURULUMU TAMAMLANDI!                   ║'
PRINT '╚══════════════════════════════════════════════════════════════╝'
PRINT ''
PRINT 'Oluşturulan Procedure/Fonksiyonlar:'
PRINT '  - sp_AuditLog_Kaydet'
PRINT '  - sp_AuditLog_KayitGecmisi'
PRINT '  - fn_HesaplaEkMaliyet'
PRINT '  - sp_BildirimGonder'
PRINT '  - sp_StokAIIcerikKaydet'
PRINT ''
PRINT 'Sonraki adım: 03_TRIGGER_SISTEMI.sql (isteğe bağlı)'
GO
