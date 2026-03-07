-- ================================================================
-- SATIS_KAYDET - 5 ÜRÜN DESTEĞİ DÜZELTMESİ
-- ================================================================
-- SORUN: Procedure sadece 2 ürün işliyordu (@Barkod ve @Barkod1)
-- @Barkod2, @Barkod3, @Barkod4 blokları eksikti
-- 
-- ÖNCEKİ DURUM: 3 ürünlü siparişte sadece 2 ürün faturaya düşüyordu
-- SONRA: 5 ürüne kadar tam destek
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

    -- Türkiye ülkesi yoksa ekle
    IF NOT EXISTS (SELECT 1 FROM dbo.tbUlke WHERE sUlke = N'Türkiye')
    BEGIN
        INSERT INTO dbo.tbUlke (sUlke) VALUES (N'Türkiye');
    END

    -- İyzico Ödeme firması kontrolü
    IF NOT EXISTS (SELECT 1 FROM tbFirma WHERE sKodu = '108.01.02.009')
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM tbHesapPlani WHERE sKodu = '108.01.02.009')
        BEGIN
            INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi)
            VALUES ('108.01.02.009', N'İyzico Ödeme', '', 0, '', 0, '', '', 0, '1', @Tarih);
        END
        SET @nHesapID = (SELECT TOP 1 nHesapID FROM tbHesapPlani WHERE sKodu='108.01.02.009');
        INSERT INTO tbFirma (sKodu, sAciklama, TC, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi, sSaticiRumuzu, nOzelIskontosu2, nOzelIskontosu3, nOzelIskontosu4, bAktif, bSatisYapilamaz, bSipariseKapali, bTahsilatYapilamaz, sDovizCinsi, nEnlem, nBoylam, nZiyaret, nPeriyod, sDepo, sCariHesapTuru, sEfatura)
        VALUES ('108.01.02.009', N'İyzico Ödeme', 0, 0.00, 0.00, '01/01/1990', 0, N'Sayın', N' ', N' ', N' ', N' ', N' ', N' ', N' ', N' ', @nHesapID, N'0000000', 'sa', @Tarih, N'A   ', N'    ', 0.00, 0.00, 0.00, 1, 0, 0, 0, N'   ', 0.00000000, 0.00000000, 0, 0, N'    ', 'Cari', 0);
    END

    SET @nFirmaID1 = (SELECT ISNULL(nFirmaID, 0) FROM tbFirma WHERE sKodu = '108.01.02.009')
    SET @SonMahsupFisNo = (SELECT ISNULL(lSonMahsupNo1, 1) FROM tbMuhasebeFisNo)
    SET @MahsupFis = @SonMahsupFisNo

    -- MEVCUT FİRMA KONTROLÜ (E-Mail, Ad Soyad, TC ile)
    SELECT TOP (1) @nFirmaID = ISNULL(f.nFirmaID, 0) 
    FROM tbFirma AS f 
    INNER JOIN tbFirmaIletisimi AS i ON i.nFirmaID = f.nFirmaID 
    WHERE i.sIletisimAraci = 'E-Mail' AND i.sIletisimAdresi = @eMail 
    ORDER BY f.nFirmaID DESC

    IF @nFirmaID = 0 OR @nFirmaID IS NULL
    BEGIN
        SELECT TOP (1) @nFirmaID = ISNULL(nFirmaID, 0) 
        FROM tbFirma 
        WHERE LTRIM(RTRIM(sAciklama)) = LTRIM(RTRIM(CONCAT(@Adi, ' ', @Soyadi)))
        ORDER BY nFirmaID DESC
    END

    IF @nFirmaID = 0 OR @nFirmaID IS NULL
    BEGIN
        IF @TC IS NOT NULL AND @TC <> '' AND @TC <> '0' AND @TC <> '1' AND LEN(LTRIM(RTRIM(@TC))) >= 9
        BEGIN
            SELECT TOP (1) @nFirmaID = ISNULL(nFirmaID, 0) FROM tbFirma WHERE TC = @TC ORDER BY nFirmaID DESC
        END
    END

    IF @nFirmaID > 0
    BEGIN
        SET @FirmaBulundu = 1
        SET @sKodu = (SELECT TOP 1 ISNULL(sKodu, '') FROM tbFirma WHERE nFirmaID = @nFirmaID)
    END

    -- YENİ FİRMA OLUŞTUR
    IF @FirmaBulundu = 0
    BEGIN
        SET @sKodu = (SELECT ISNULL(MAX(LTRIM(RTRIM(sKodu))), '120.01.99.0') FROM tbFirma WHERE sKodu LIKE '120.01.99.%');
        DECLARE @prefix NVARCHAR(20) = LEFT(@sKodu, LEN(@sKodu) - LEN(PARSENAME(@sKodu, 1)));
        DECLARE @number BIGINT = ISNULL(TRY_CAST(PARSENAME(@sKodu, 1) AS BIGINT), 0) + 1;
        SET @sKodu = @prefix + FORMAT(@number, '000');

        IF NOT EXISTS (SELECT 1 FROM dbo.tbHesapPlani WHERE sKodu = @sKodu)
        BEGIN
            INSERT INTO dbo.tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi)
            VALUES (@sKodu, ISNULL(@Adi,'') + ' ' + ISNULL(@Soyadi,''), '', 0, '', 0, '', '', 0, '1', @Tarih);
        END
        SET @nHesapID = (SELECT ISNULL(nHesapID, 0) FROM tbHesapPlani WHERE sKodu = @sKodu)

        INSERT INTO tbFirma (sKodu, sAciklama, TC, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi, sSaticiRumuzu, nOzelIskontosu2, nOzelIskontosu3, nOzelIskontosu4, bAktif, bSatisYapilamaz, bSipariseKapali, bTahsilatYapilamaz, sDovizCinsi, nEnlem, nBoylam, nZiyaret, nPeriyod, sDepo, sCariHesapTuru, sEfatura) 
        VALUES (@sKodu, LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)), @TC, 0.00, 0.00, '01/01/1990', 0, N'Sayın', @Adres, N' ', @Ilce, @Il, N' ', @PostaKodu, @VergiDairesi, @VergiNo, @nHesapID, N'0000000', 'sa', @Tarih, N'3   ', N'', 0.00, 0.00, 0.00, 1, 0, 0, 0, N'   ', 0.00000000, 0.00000000, 0000000, 0, N'D001', 'webCari', 'False')

        SELECT TOP (1) @nFirmaID = ISNULL(nFirmaID, 0) FROM tbFirma WHERE sKodu = @sKodu ORDER BY nFirmaID DESC

        INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES (@nFirmaID, 'Gsm', @Telefon)
        INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES (@nFirmaID, 'E-Mail', @eMail)

        IF NOT EXISTS (SELECT 1 FROM tbFSinif2 WHERE sSinifKodu = '099')
            INSERT INTO tbFSinif2 (sSinifKodu, sAciklama) VALUES ('099', 'Eticaret');

        IF NOT EXISTS (SELECT 1 FROM tbFirmaSinifi WHERE nFirmaID = @nFirmaID)
            INSERT INTO tbFirmaSinifi (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES (@nFirmaID, '', '099', '', '', '');
    END

    -- İLK ÜRÜN BİLGİLERİ
    SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod)
    SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
    SET @KdvTipi = (SELECT sKdvTipi FROM tbStok WHERE nStokID = @nStokID)
    SET @Kdv = (SELECT ISNULL(nKdvOrani, 10) FROM tbKdv WHERE sKdvTipi = @KdvTipi)
    IF @Kdv IS NULL SET @Kdv = 10

    SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 FROM tbStokFisiDetayi)
    SET @nEvrakNo = (SELECT ISNULL(lFaturaEvrakNo, 0) + 1 FROM tbStokFisNolar WHERE sDepo = 'D001')
    UPDATE tbStokFisNolar SET lFaturaEvrakNo = @nEvrakNo WHERE sDepo = 'D001'

    IF ((SELECT COUNT(*) FROM tbStokFisiMaster WHERE lFisNo = (SELECT ISNULL(lToptanFatura1, 0) + 1 FROM tbStokFisNolar WHERE sDepo = 'D001')) = 0)
        SELECT @lFisNo = ISNULL(lToptanFatura1, 0) + 1 FROM tbStokFisNolar WHERE sDepo = 'D001';
    ELSE
        SELECT @lFisNo = MAX(lFisNo) + 1 FROM tbStokFisiMaster;

    SET @Tutar = (@Fiyat * @Miktar)
    UPDATE tbStokFisNolar SET lToptanFatura1 = lToptanFatura1 + 1 WHERE sDepo = 'D001'

    -- STOK FİŞİ MASTER KAYDI
    INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, dteTeslimTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, bKilitli, nEvrakNo) 
    VALUES ('FS ', @Tarih, @Tarih, 3, @lFisNo, @nFirmaID, 'D001', @Tarih, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, @EkMaliyet3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '001 ', 0, 0, '0', '', 0, 'Admin', @TarihSaat, '', 0, 0, 0, 0, 0, 0, 0, @nEvrakNo)

    SET @nStokFisiID = SCOPE_IDENTITY()

    INSERT INTO tbStokFisiAciklamasi (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) 
    VALUES (@nStokFisiID, '', @sAciklama2, @sAciklama3, '', '')

    UPDATE tbStokSiraNo SET nSonID = @nStokFisiID WHERE nSiraIndex = 2
    INSERT INTO tbFisKilit (nKayitID, sFisTipi, sKullanici, dteKayitTarihi) VALUES (@nStokFisiID, 'FS', '1', @TarihSaat)

    -- CARİ HAREKET
    INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) 
    VALUES (@nFirmaID, @Tarih, @Tarih, 'FS ', 'Evrak No' + @MahsupFis, @Tutar, 0, @SonMahsupFisNo, 0, 'FS ', '001 ', 'Admin', @TarihSaat, '', 0, 0, '', 0, 0, 'Admin', @TarihSaat)

    SET @nCariHareketID = SCOPE_IDENTITY()

    INSERT INTO tbStokFisiOdemePlani (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) 
    VALUES (@nStokFisiID, @Tarih, @Tutar, 'FS ', @nCariHareketID)

    UPDATE tbCariSiraNo SET nSonID = @nCariHareketID WHERE nSiraIndex = 1

    SET @nHesapID = (SELECT ISNULL(nHesapID, 0) FROM tbHesapPlani WHERE sKodu = @sKodu)
    SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 FROM tbStokFisiDetayi)

    -- ==========================================
    -- 1. ÜRÜN DETAY KAYDI (@Barkod)
    -- ==========================================
    INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
    VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar, @Fiyat, @Tutar, 0, '3', 'AD ', 1, @Fiyat, @Tutar, 0, 0, 0, 0.00, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Ürün 1', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)

    SET @nStokIslemID = SCOPE_IDENTITY()
    UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1

    DELETE FROM tbFisKilit WHERE nKayitID = @nStokFisiID AND sFisTipi = 'FS ' AND sKullanici = '1'

    SET @lNetTutar = (SELECT ISNULL(ROUND(SUM(lBrutTutar), 2), 0) FROM tbStokFisiDetayi WHERE nStokFisiID = @nStokFisiID)
    SET @lKdv = (@lNetTutar * @Kdv) / 100
    SET @BrutTutar = @lNetTutar
    SET @ToplamMiktar = @Miktar

    -- ==========================================
    -- 2. ÜRÜN (@Barkod1)
    -- ==========================================
    IF @Barkod1 IS NOT NULL AND @Barkod1 > '0' AND LEN(LTRIM(RTRIM(@Barkod1))) > 1
    BEGIN
        SET @Tutar1 = @Miktar1 * @Fiyat1
        SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod1)
        SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
        SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 FROM tbStokFisiDetayi)
        
        INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
        VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar1, 0, @Fiyat1, @Tutar1, '3', 'AD ', 1, @Fiyat1, @Tutar1, 0, 0, 0, 0.00, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Ürün 2', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)
        
        SET @nStokIslemID = SCOPE_IDENTITY()
        UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1
        SET @ToplamMiktar = @ToplamMiktar + @Miktar1
    END

    -- ==========================================
    -- 3. ÜRÜN (@Barkod2) - YENİ EKLENDİ!
    -- ==========================================
    IF @Barkod2 IS NOT NULL AND @Barkod2 > '0' AND LEN(LTRIM(RTRIM(@Barkod2))) > 1
    BEGIN
        SET @Tutar2 = @Miktar2 * @Fiyat2
        SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod2)
        SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
        SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 FROM tbStokFisiDetayi)
        
        INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
        VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar2, 0, @Fiyat2, @Tutar2, '3', 'AD ', 1, @Fiyat2, @Tutar2, 0, 0, 0, 0.00, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Ürün 3', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)
        
        SET @nStokIslemID = SCOPE_IDENTITY()
        UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1
        SET @ToplamMiktar = @ToplamMiktar + @Miktar2
    END

    -- ==========================================
    -- 4. ÜRÜN (@Barkod3) - YENİ EKLENDİ!
    -- ==========================================
    IF @Barkod3 IS NOT NULL AND @Barkod3 > '0' AND LEN(LTRIM(RTRIM(@Barkod3))) > 1
    BEGIN
        SET @Tutar3 = @Miktar3 * @Fiyat3
        SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod3)
        SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
        SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 FROM tbStokFisiDetayi)
        
        INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
        VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar3, 0, @Fiyat3, @Tutar3, '3', 'AD ', 1, @Fiyat3, @Tutar3, 0, 0, 0, 0.00, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Ürün 4', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)
        
        SET @nStokIslemID = SCOPE_IDENTITY()
        UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1
        SET @ToplamMiktar = @ToplamMiktar + @Miktar3
    END

    -- ==========================================
    -- 5. ÜRÜN (@Barkod4) - YENİ EKLENDİ!
    -- ==========================================
    IF @Barkod4 IS NOT NULL AND @Barkod4 > '0' AND LEN(LTRIM(RTRIM(@Barkod4))) > 1
    BEGIN
        SET @Tutar4 = @Miktar4 * @Fiyat4
        SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod4)
        SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
        SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 FROM tbStokFisiDetayi)
        
        INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
        VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar4, 0, @Fiyat4, @Tutar4, '3', 'AD ', 1, @Fiyat4, @Tutar4, 0, 0, 0, 0.00, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Ürün 5', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)
        
        SET @nStokIslemID = SCOPE_IDENTITY()
        UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1
        SET @ToplamMiktar = @ToplamMiktar + @Miktar4
    END

    -- ==========================================
    -- FİNAL HESAPLAMALAR VE GÜNCELLEMELER
    -- ==========================================
    
    -- Toplam brüt tutar ve KDV hesapla
    SET @lNetTutar = (SELECT ISNULL(ROUND(SUM(lBrutTutar), 2), 0) FROM tbStokFisiDetayi WHERE nStokFisiID = @nStokFisiID)
    SET @lKdv = (@lNetTutar * @Kdv) / 100
    SET @BTutar = @lNetTutar
    SET @ToplamTutar = @lNetTutar + @lKdv

    -- Master tablosunu güncelle
    UPDATE tbStokFisiMaster 
    SET lToplamMiktar = @ToplamMiktar, 
        lMalBedeli = @BTutar, 
        lEkmaliyet3 = @EkMaliyet3, 
        nKdvOrani1 = @Kdv, 
        lKdvMatrahi1 = @BTutar, 
        lKdv1 = @lKdv, 
        lNetTutar = @ToplamTutar, 
        bFisTamamlandimi = 1 
    WHERE nStokFisiID = @nStokFisiID

    -- Cari hareket güncelle
    UPDATE tbFirmaHareketi 
    SET lBorcTutar = @ToplamTutar 
    WHERE nHareketID IN (SELECT nCariHareketID FROM tbStokFisiOdemePlani WHERE nStokFisiID = @nStokFisiID)

    -- Ödeme planı güncelle
    UPDATE tbStokFisiOdemePlani 
    SET lTutari = @ToplamTutar 
    WHERE nStokFisiID = @nStokFisiID

    -- ==========================================
    -- FİNANS İŞLEMLERİ (İyzico)
    -- ==========================================
    IF NOT EXISTS (SELECT 1 FROM dbo.tbCariIslem WHERE sCariIslem = 'iyz')
    BEGIN
        INSERT INTO dbo.tbCariIslem (sCariIslem, sAciklama) VALUES ('iyz', 'İyzico Ödeme');
    END

    SET @Odeme = (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = @nFirmaID)

    DECLARE @CarinHesapID INT = (SELECT ISNULL(nHesapID, 0) FROM tbFirma WHERE sKodu = '108.01.02.009')

    INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) 
    VALUES (@nFirmaID1, @Tarih, @Tarih, 'iyz ', 'Iyzico ile Tahsilat', @Odeme, 0, @SonMahsupFisNo, 0, 'MUH', '001 ', 'Admin', @TarihSaat, '', 0, 0, '', 0, 0, 'Admin', @TarihSaat)

    SET @nCariHareketID = SCOPE_IDENTITY()
    UPDATE tbCariSiraNo SET nSonID = @nCariHareketID WHERE nSiraIndex = 1

    INSERT INTO tbMuhasebeFisi (dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) 
    VALUES (@Tarih, '3', @SonMahsupFisNo, @SonMahsupFisNo, @SonMahsupFisNo, @CarinHesapID, LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)) + '\Iyzico ile Tahsilat', 0, 0, @Odeme, 0, '', 0, 'CHS', '001 ', @nCariHareketID, 'Admin', @TarihSaat, '', 0, 0, '', 0, 0, 0, '001 ', 'Admin', @TarihSaat)

    INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) 
    VALUES (@nFirmaID, @Tarih, @Tarih, 'iyz ', N'Iyzico ile Tahsilat', 0, @Odeme, @SonMahsupFisNo, 0, 'MUH', '001 ', 'Admin', @TarihSaat, '', 0, 0, '', 0, 0, 'Admin', @TarihSaat)

    SET @nCariHareketID = SCOPE_IDENTITY()
    UPDATE tbCariSiraNo SET nSonID = @nCariHareketID WHERE nSiraIndex = 1

    INSERT INTO tbMuhasebeFisi (dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) 
    VALUES (@Tarih, '3', @SonMahsupFisNo, @SonMahsupFisNo, @SonMahsupFisNo, @nHesapID, N'İyzico Ödeme\K.Kartı ile Tahsilat', 0, 0, 0, @Odeme, '', 0, 'CHS', '001 ', @nCariHareketID, 'Admin', @TarihSaat, '', 0, 0, '', 0, 0, 0, '001 ', 'Admin', @TarihSaat)

    INSERT INTO tbMuhasebeFisiAciklamasi (dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, bKilitli) 
    VALUES (@Tarih, '3', @SonMahsupFisNo, '', 'FinansEntegre', 'Iyzico ile Tahsilat', '', '', 0)

    UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1, 1) FROM tbMuhasebeFisi WHERE sMuhFisTipi = 3 ORDER BY lFisNo DESC), 1)

    DELETE FROM tbFirmaHareketi WHERE sHangiUygulama IN ('IA', 'IS')

    SELECT @nFirmaID
END
GO

PRINT '✅ Satis_Kaydet procedure 5 ürün desteği ile güncellendi!'
PRINT 'Artık @Barkod, @Barkod1, @Barkod2, @Barkod3, @Barkod4 parametreleri tam işlenecek.'
GO
