-- =====================================================
-- SATIS_KAYDET STORED PROCEDURE - BARKOD2, BARKOD3, BARKOD4 EKLEME
-- Tarih: 2026-02-25
-- Sorun: 3+ ürünlü siparişlerde sadece ilk 2 ürün kaydediliyor
-- Çözüm: @Barkod2, @Barkod3, @Barkod4 bloklarını ekle
-- =====================================================
-- KULLANIM: Bu scripti SQL Server Management Studio'da çalıştırın
-- ÖNCELİKLE MEVCUT PROCEDURE'Ü YEDEKLEYİN!
-- =====================================================

-- Mevcut procedure'de satır 448'den sonra (IF @Barkod1 END'in ardından)
-- aşağıdaki blokları ekleyin:

-- ==========================================
-- ÜÇÜNCÜ ÜRÜN (BARKOD2)
-- ==========================================
IF @Barkod2 IS NOT NULL AND LTRIM(RTRIM(@Barkod2)) <> '' AND @Barkod2 <> '0'
BEGIN
    SET @Tutar2 = @Miktar2 * @Fiyat2
    SET @ToplamTutar2 = ISNULL(@lNetTutar1, @lNetTutar) + @Tutar2
    SET @ToplamMiktar2 = ISNULL(@ToplamMiktar1, @Miktar) + @Miktar2
    SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM tbStokFisiDetayi)
    SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod2)
    SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
    VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar2, 0, @Fiyat2, @Tutar2, '3', 'AD ', 1, @Fiyat2, @Tutar2, 0, 0, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)
    
    SET @nStokIslemID = (SELECT @@identity)
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1
    SET @lNetTutar2 = (SELECT ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID))
    SET @lKdv2 = (@lNetTutar2 * @Kdv) / 100
    SET @BrutTutar2 = @Tutar2
    SET @Tutar2 = (@Miktar2 * @Fiyat2)
    SET @lNetTutar2 = @lNetTutar2 + @lKdv2
    SET @BTutar2 = @lNetTutar2 - @lKdv2
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    UPDATE tbStokFisiDetayi 
    SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar2, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat2, lCikisTutar = @Tutar2, sFiyatTipi = '3', sBirimCinsi = 'AD ', lBirimMiktar = 1, lBrutFiyat = @Fiyat2, lBrutTutar = @BrutTutar2, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ', bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat, nPrim = 0, lPrimTutari = 0 
    WHERE nStokFisiID = @nStokFisiID AND nIslemID = @nStokIslemID
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    UPDATE tbStokFisiMaster 
    SET lToplamMiktar = @ToplamMiktar2, lMalBedeli = @BTutar2, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @BTutar2, lKdv1 = @lKdv2, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar = @lNetTutar2, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle = 'Bin İkiyüz TL', bFisTamamlandimi = 1 
    WHERE nStokFisiID = @nStokFisiID
    
    SET DATEFORMAT DMY 
    UPDATE tbFirmaHareketi 
    SET nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar2, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat 
    WHERE (nHareketID IN (SELECT nCariHareketID FROM tbStokFisiOdemePlani WHERE (nStokFisiID = @nStokFisiID)))
    
    SET DATEFORMAT DMY UPDATE tbStokFisiOdemePlani SET dteVadeTarihi = @Tarih, lTutari = @lNetTutar2, sCariIslem = 'FS ' WHERE (nStokFisiID = @nStokFisiID)
    SET @Odeme = (SELECT SUM(lBorcTutar - lAlacakTutar) AS Bakiye FROM tbFirmaHareketi WHERE nFirmaID = @nFirmaID)
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit WHERE nKayitID = @nStokFisiID AND sFisTipi = 'FS ' AND sKullanici = '1'
END

-- ==========================================
-- DÖRDÜNCÜ ÜRÜN (BARKOD3)
-- ==========================================
IF @Barkod3 IS NOT NULL AND LTRIM(RTRIM(@Barkod3)) <> '' AND @Barkod3 <> '0'
BEGIN
    SET @Tutar3 = @Miktar3 * @Fiyat3
    SET @ToplamTutar3 = ISNULL(@lNetTutar2, ISNULL(@lNetTutar1, @lNetTutar)) + @Tutar3
    SET @ToplamMiktar3 = ISNULL(@ToplamMiktar2, ISNULL(@ToplamMiktar1, @Miktar)) + @Miktar3
    SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM tbStokFisiDetayi)
    SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod3)
    SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
    VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar3, 0, @Fiyat3, @Tutar3, '3', 'AD ', 1, @Fiyat3, @Tutar3, 0, 0, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)
    
    SET @nStokIslemID = (SELECT @@identity)
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1
    SET @lNetTutar3 = (SELECT ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID))
    SET @lKdv3 = (@lNetTutar3 * @Kdv) / 100
    SET @BrutTutar3 = @Tutar3
    SET @Tutar3 = (@Miktar3 * @Fiyat3)
    SET @lNetTutar3 = @lNetTutar3 + @lKdv3
    SET @BTutar3 = @lNetTutar3 - @lKdv3
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    UPDATE tbStokFisiDetayi 
    SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar3, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat3, lCikisTutar = @Tutar3, sFiyatTipi = '3', sBirimCinsi = 'AD ', lBirimMiktar = 1, lBrutFiyat = @Fiyat3, lBrutTutar = @BrutTutar3, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ', bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat, nPrim = 0, lPrimTutari = 0 
    WHERE nStokFisiID = @nStokFisiID AND nIslemID = @nStokIslemID
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    UPDATE tbStokFisiMaster 
    SET lToplamMiktar = @ToplamMiktar3, lMalBedeli = @BTutar3, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @BTutar3, lKdv1 = @lKdv3, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar = @lNetTutar3, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle = 'Bin İkiyüz TL', bFisTamamlandimi = 1 
    WHERE nStokFisiID = @nStokFisiID
    
    SET DATEFORMAT DMY 
    UPDATE tbFirmaHareketi 
    SET nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar3, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat 
    WHERE (nHareketID IN (SELECT nCariHareketID FROM tbStokFisiOdemePlani WHERE (nStokFisiID = @nStokFisiID)))
    
    SET DATEFORMAT DMY UPDATE tbStokFisiOdemePlani SET dteVadeTarihi = @Tarih, lTutari = @lNetTutar3, sCariIslem = 'FS ' WHERE (nStokFisiID = @nStokFisiID)
    SET @Odeme = (SELECT SUM(lBorcTutar - lAlacakTutar) AS Bakiye FROM tbFirmaHareketi WHERE nFirmaID = @nFirmaID)
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit WHERE nKayitID = @nStokFisiID AND sFisTipi = 'FS ' AND sKullanici = '1'
END

-- ==========================================
-- BEŞİNCİ ÜRÜN (BARKOD4)
-- ==========================================
IF @Barkod4 IS NOT NULL AND LTRIM(RTRIM(@Barkod4)) <> '' AND @Barkod4 <> '0'
BEGIN
    SET @Tutar4 = @Miktar4 * @Fiyat4
    SET @ToplamTutar4 = ISNULL(@lNetTutar3, ISNULL(@lNetTutar2, ISNULL(@lNetTutar1, @lNetTutar))) + @Tutar4
    SET @ToplamMiktar4 = ISNULL(@ToplamMiktar3, ISNULL(@ToplamMiktar2, ISNULL(@ToplamMiktar1, @Miktar))) + @Miktar4
    SET @nStokIslemID = (SELECT ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM tbStokFisiDetayi)
    SET @nStokID = (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod = @Barkod4)
    SET @StokAdi = (SELECT sAciklama FROM tbStok WHERE nStokID = @nStokID)
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi, nPrim, lPrimTutari) 
    VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar4, 0, @Fiyat4, @Tutar4, '3', 'AD ', 1, @Fiyat4, @Tutar4, 0, 0, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ', 0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0, 0, 0, NULL, NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0, 0, 'Admin', @TarihSaat, 0.50, 0.000)
    
    SET @nStokIslemID = (SELECT @@identity)
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSiraNo SET nSonID = @nStokIslemID WHERE nSiraIndex = 1
    SET @lNetTutar4 = (SELECT ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID))
    SET @lKdv4 = (@lNetTutar4 * @Kdv) / 100
    SET @BrutTutar4 = @Tutar4
    SET @Tutar4 = (@Miktar4 * @Fiyat4)
    SET @lNetTutar4 = @lNetTutar4 + @lKdv4
    SET @BTutar4 = @lNetTutar4 - @lKdv4
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    UPDATE tbStokFisiDetayi 
    SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar4, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat4, lCikisTutar = @Tutar4, sFiyatTipi = '3', sBirimCinsi = 'AD ', lBirimMiktar = 1, lBrutFiyat = @Fiyat4, lBrutTutar = @BrutTutar4, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ', bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat, nPrim = 0, lPrimTutari = 0 
    WHERE nStokFisiID = @nStokFisiID AND nIslemID = @nStokIslemID
    
    SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    UPDATE tbStokFisiMaster 
    SET lToplamMiktar = @ToplamMiktar4, lMalBedeli = @BTutar4, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @BTutar4, lKdv1 = @lKdv4, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar = @lNetTutar4, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle = 'Bin İkiyüz TL', bFisTamamlandimi = 1 
    WHERE nStokFisiID = @nStokFisiID
    
    SET DATEFORMAT DMY 
    UPDATE tbFirmaHareketi 
    SET nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar4, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat 
    WHERE (nHareketID IN (SELECT nCariHareketID FROM tbStokFisiOdemePlani WHERE (nStokFisiID = @nStokFisiID)))
    
    SET DATEFORMAT DMY UPDATE tbStokFisiOdemePlani SET dteVadeTarihi = @Tarih, lTutari = @lNetTutar4, sCariIslem = 'FS ' WHERE (nStokFisiID = @nStokFisiID)
    SET @Odeme = (SELECT SUM(lBorcTutar - lAlacakTutar) AS Bakiye FROM tbFirmaHareketi WHERE nFirmaID = @nFirmaID)
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit WHERE nKayitID = @nStokFisiID AND sFisTipi = 'FS ' AND sKullanici = '1'
END
