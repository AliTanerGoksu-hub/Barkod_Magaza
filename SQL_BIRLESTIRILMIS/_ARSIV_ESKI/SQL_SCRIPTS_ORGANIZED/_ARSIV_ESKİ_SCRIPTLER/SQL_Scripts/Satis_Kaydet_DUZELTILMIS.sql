SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Satis_Kaydet]
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
@Miktar4 numeric(14) Output
,@EkMaliyet3 numeric(18, 2) = 0 Output
as
DECLARE @nFirmaID int
DECLARE @nFirmaID1 int
DECLARE @nEvrakNo numeric(10, 0)
DECLARE @sKodu char(20)
DECLARE @Tarih smalldatetime
DECLARE @nHesapID int
DECLARE @AdresID int
DECLARE @nStokFisiID int
DECLARE @nCariHareketID int
DECLARE @nStokID int
DECLARE @nStokIslemID numeric(10, 0)
DECLARE @TarihSaat datetime
DECLARE @StokAdi varchar(60)
DECLARE @KdvMatrahi numeric(18, 2)
DECLARE @Hata varchar(50)
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
DECLARE @ToplamTutar1 numeric(18, 2)
DECLARE @ToplamTutar2 numeric(18, 2)
DECLARE @ToplamTutar3 numeric(18, 2)
DECLARE @ToplamTutar4 numeric(18, 2)
DECLARE @ToplamMiktar numeric(14)
DECLARE @ToplamMiktar1 numeric(14)
DECLARE @ToplamMiktar2 numeric(14)
DECLARE @ToplamMiktar3 numeric(14)
DECLARE @ToplamMiktar4 numeric(14)
DECLARE @lNetTutar  numeric(18, 2)
DECLARE @lNetTutar1  numeric(18, 2)
DECLARE @lNetTutar2  numeric(18, 2)
DECLARE @lNetTutar3  numeric(18, 2)
DECLARE @lNetTutar4  numeric(18, 2)
DECLARE @lKdv numeric(18, 2)
DECLARE @lKdv1 numeric(18, 2)
DECLARE @lKdv2 numeric(18, 2)
DECLARE @lKdv3 numeric(18, 2)
DECLARE @lKdv4 numeric(18, 2)
DECLARE @BrutTutar numeric(18, 2)
DECLARE @BrutTutar1 numeric(18, 2)
DECLARE @BrutTutar2 numeric(18, 2)
DECLARE @BrutTutar3 numeric(18, 2)
DECLARE @BrutTutar4 numeric(18, 2)
DECLARE @BTutar numeric(18, 2)
DECLARE @BTutar1 numeric(18, 2)
DECLARE @BTutar2 numeric(18, 2)
DECLARE @BTutar3 numeric(18, 2)
DECLARE @BTutar4 numeric(18, 2)
SET @Tutar = @Miktar * @Fiyat
SET @nFirmaID1=  (SELECT ISNULL(COUNT (nFirmaID),0) as nFirmaID FROM tbFirma WHERE (sKodu = '108.01.02.009') )
SET @SonMahsupFisNo = (SELECT     ISNULL(lSonMahsupNo1, 1) AS lFisNo FROM         tbMuhasebeFisNo)
SET @MahsupFis = @SonMahsupFisNo
Set @TarihFis = (SELECT FORMAT(GETDATE(),'yyyy.MM.dd'))
Set @Tarih = (SELECT FORMAT(GETDATE(),'yyyy.MM.dd'))
Set @TarihSaat = (SELECT FORMAT(GETDATE(),'yyyy.MM.dd HH:mm:ss'))
SET @nFirmaID=  (SELECT ISNULL(COUNT (nFirmaID),0) as nFirmaID FROM tbFirma WHERE (TC = @TC) )
SET @nFirmaID=  (SELECT ISNULL(COUNT (nFirmaID),0) as nFirmaID FROM tbFirma WHERE (sVergiNo = @VergiNo) )
SET @nFirmaID= (SELECT ISNULL(COUNT (tbFirma.nFirmaID),0) as nFirmaID FROM tbFirma  INNER JOIN tbFirmaIletisimi ON tbFirma.nFirmaID = tbFirmaIletisimi.nFirmaID WHERE (sIletisimAraci = 'E-Mail' and sIletisimAdresi = @eMail))
SET @sKodu= (SELECT  ISNULL(COUNT (sKodu),0) as sKodu    FROM         tbFirma WHERE     (sVergiNo = @sVergiNo) and nFirmaID <> 0 Group By sKodu,nFirmaID)
if @nFirmaID = 0 
begin
SET @nFirmaID1=  (SELECT nFirmaID as nFirmaID FROM tbFirma WHERE (sKodu = '108.01.02.009') )
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @KdvTipi = (SELECT sKdvTipi  From tbStok  Where nStokID= @nStokID)
SET @Kdv = (SELECT nKdvOrani  From tbKdv  Where sKdvTipi= @KdvTipi)
-- En büyük sKodu değerini al
SET @sKodu = (SELECT ISNULL(MAX(LTRIM(RTRIM(sKodu))), '120.01.99.0') FROM tbFirma WHERE sKodu LIKE '120.01.99.%');
DECLARE @prefix NVARCHAR(20) = LEFT(@sKodu, LEN(@sKodu) - LEN(PARSENAME(@sKodu, 1)));
DECLARE @number BIGINT = ISNULL(TRY_CAST(PARSENAME(@sKodu, 1) AS BIGINT), 0) + 1;
SET @sKodu = @prefix + FORMAT(@number, '0000000');
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     (@sKodu,@Adi+@Soyadi,'', 0, '', 0, '', '', 0, '1', @Tarih)
Set @nHesapID = (Select ISNULL(nHesapID, 0) AS nHesapID From tbHesapPlani Where sKodu= @sKodu)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirma (sKodu, sAciklama, TC, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi,sSaticiRumuzu,nOzelIskontosu2,nOzelIskontosu3,nOzelIskontosu4,bAktif,bSatisYapilamaz,bSipariseKapali, bTahsilatYapilamaz,sDovizCinsi,nEnlem,nBoylam,nZiyaret,nPeriyod,sDepo, sCariHesapTuru, sEfatura) VALUES (@sKodu,LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)),@TC, 0.00, 0.00, '01/01/1990', 0, N'Sayın', @Adres, N' ', @Ilce,@Il, N' ', @PostaKodu, @VergiDairesi, @VergiNo, @nHesapID, N'0000000', 'sa',@Tarih, N'3   ',N'',0.00,0.00,0.00,1,0, 0, 0,N'   ',0.00000000,0.00000000,0000000,0,N'D001', 'webCari','False')
Set @nFirmaID = (Select ISNULL(nFirmaID, 0) AS nFirmaID From tbFirma Where sKodu= @sKodu)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID,sIletisimAraci,sIletisimAdresi) VALUES (@nFirmaID,'Gsm',@Telefon)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES     (@nFirmaID,'E-Mail',@eMail )
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi (nFirmaID,sSinifKodu1,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu5) VALUES (@nFirmaID,'','3','','','')
Set @AdresID = (Select ISNULL(nFirmaID, 0) AS nFirmaID From tbFirma Where nFirmaID= @nFirmaID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaAdresi SET              sAciklama = N'Fatura', sAdres1 = @Adres, sAdres2 = '', sSemt = @Ilce, sIl = @Il, sUlke = @Ulke, sPostaKodu = @PostaKodu, sVergiDairesi = @VergiDairesi, sVergiNo = @VergiNo, sSubeMagaza = '001 ',sTelefon1 = @Telefon,sTelefon2 = '',sTelefon3 = '',sFaks = '',sMail = @eMail WHERE nAdresID = @AdresID
SET @nEvrakNo =  (SELECT ISNULL(lFaturaEvrakNo, 0) + 1 AS nEvrakNo FROM tbStokFisNolar WHERE (sDepo = 'D001'))
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisNolar SET lFaturaEvrakNo = @nEvrakNo WHERE (sDepo = 'D001')
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
IF ((SELECT COUNT(*) 
     FROM tbStokFisiMaster 
     WHERE lFisNo = (SELECT ISNULL(lToptanFatura1, 0) + 1 
                     FROM tbStokFisNolar 
                     WHERE sDepo = 'D001')) = 0)
BEGIN
    SELECT @lFisNo = ISNULL(lToptanFatura1, 0) + 1 
    FROM tbStokFisNolar 
    WHERE sDepo = 'D001';
END
ELSE
BEGIN
    SELECT @lFisNo = MAX(lFisNo) + 1 
    FROM tbStokFisiMaster;
END


SET @Tutar = (@Fiyat*@Miktar)
SET @Tutar = @Fiyat*@Miktar
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisNolar SET lToptanFatura1 = lToptanFatura1 + 1 WHERE (sDepo = 'D001')
SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, dteTeslimTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2,bKilitli,nEvrakNo) VALUES     ('FS ',@Tarih, @Tarih, 3 , @lFisNo, @nFirmaID, 'D001',@Tarih, 0 , 0 , 0 , 0 , 0, 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0, 0 , 0, 0 , 0, 0 , 0, 0 , 0, 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0, 0 ,  '001 ', 0, 0, '0',  '', 0 , 'Admin', @TarihSaat, '', 0, 0, 0, 0 , 0, 0,0,@nEvrakNo)
SET @nStokFisiID = (SELECT @@identity)
SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES (@nStokFisiID, '', '', '', '', '')
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSiraNo SET nSonID = @nStokFisiID where nSiraIndex = 2
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFisKilit                       (nKayitID, sFisTipi, sKullanici, dteKayitTarihi) VALUES     (@nStokFisiID, 'FS', '1', @TarihSaat)
SET DATEFORMAT DMY INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES (@nFirmaID, @Tarih,@Tarih, 'FS ', 'Evrak No' + @MahsupFis,@Tutar, 0, @SonMahsupFisNo, 0, 'FS ', '001 ', 'Admin',@TarihSaat, '', 0, 0, '', 0, 0, 'Admin', @TarihSaat) 
SET @nCariHareketID = (SELECT @@identity)
SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     (@nStokFisiID, @Tarih, @Tutar, 'FS ', @nCariHareketID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = @nCariHareketID where nSiraIndex = 1
Set @nHesapID = (Select ISNULL(nHesapID, 0) AS nHesapID From tbHesapPlani Where sKodu= @sKodu)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar, @Fiyat , @Tutar, 0 , '3' ,'AD ',1,@Fiyat, @Tutar , 0, 0, 0, 0.00000000, 0.001, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0, '', 0 , 0, 0, NULL,  NULL,@nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1

SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID1, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @Tutar, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @Tutar, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat, lCikisTutar = @Tutar, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat, lBrutTutar = @Tutar, lMaliyetFiyat = 875.8642, lMaliyetTutar = 875.8642, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
SET @lNetTutar = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv = (@Tutar * @Kdv) /100
SET @Tutar = (@Fiyat*@Miktar) + @lKdv 
SET @BrutTutar = @Tutar - @lKdv

SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @Miktar, lMalBedeli = @BrutTutar, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @BrutTutar, lKdv1 = @lKdv, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar = @Tutar, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 1000.00, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisNolar SET lFaturaEvrakNo = @nEvrakNo WHERE (sDepo = 'D001')
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @Tutar, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @Tutar, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 

IF @Barkod1 > '0'
BEGIN

SET @Tutar1 = @Miktar1 * @Fiyat1
SET @ToplamTutar1 = @lNetTutar + @Tutar1
SET @ToplamMiktar1 = (@Miktar+@Miktar1)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod1)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar1, 0, @Fiyat1 , @Tutar1, '3' ,'AD ',1, @Fiyat1, @Tutar1 , 0, 0, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar1 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv1 =(@lNetTutar1 * @kdv) /100
SET @BrutTutar1 = @Tutar1
SET @Tutar1 = (@Miktar1 * @Fiyat1)
SET @lNetTutar1 = @lNetTutar1 + @lKdv1
SET @BTutar1 = @lNetTutar1 - @lKdv1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar1, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat1, lCikisTutar = @Tutar1, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat1, lBrutTutar = @BrutTutar1, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar1, lMalBedeli = @BTutar1, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar1, lKdv1 = @lKdv1, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar1, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar1, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar1, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
IF @Barkod2 > '0'
BEGIN

SET @Tutar2 = @Miktar2 * @Fiyat2
SELECT @Tutar2
SET @ToplamTutar2 = (@lNetTutar1 + @Tutar2)
SET @ToplamMiktar2 = (@Miktar+@Miktar1+@Miktar2)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod2)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar2, 0,  @Fiyat2 , @Tutar2, '3' ,'AD ',1, @Fiyat2, @Tutar2, 2141.6667, 2141.6667, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar2 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv2 = (@lNetTutar2 * @kdv)/100
SET @BrutTutar2 = @Tutar2
SET @Tutar2 = (@Miktar2 * @Fiyat2)
SET @lNetTutar2 = @lNetTutar2 + @lKdv2
SET @BTutar2 = @lNetTutar2 - @lKdv2
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar2, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat2, lCikisTutar = @Tutar1, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat2, lBrutTutar = @BrutTutar2, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar2, lMalBedeli = @BTutar2, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar2, lKdv1 = @lKdv2, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar2, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar2, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar2, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
IF @Barkod3 > '0'
BEGIN
SET @Tutar3 = @Miktar3 * @Fiyat3
SET @ToplamTutar3 = @lNetTutar2 + @Tutar3
SET @ToplamMiktar3 = (@Miktar+@Miktar1+@Miktar2+@Miktar3)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod3)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar3,0,  @Fiyat3 , @Tutar3,  '3' ,'AD ',1, @Fiyat3, @Tutar3 , 2141.6667, 2141.6667, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar3 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv3 = (@lNetTutar3 * @kdv) /100
SET @BrutTutar3 = @Tutar3
SET @Tutar3 = (@Miktar3 * @Fiyat3) + @lKdv3
SET @lNetTutar3 = @lNetTutar3 + @lKdv3
SET @BTutar3 = @lNetTutar3 - @lKdv3
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar3, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat3, lCikisTutar = @Tutar3, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat3, lBrutTutar = @BrutTutar3, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar3, lMalBedeli = @BTutar3, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar3, lKdv1 = @lKdv3, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar3, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar3, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar3, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
IF @Barkod4 > '0'
BEGIN
SET @Tutar4 = @Fiyat4 * @Miktar4
SET @ToplamTutar4 = @lNetTutar3 + @Tutar4
SET @ToplamMiktar4 = (@Miktar+@Miktar1+@Miktar2+@Miktar3+@Miktar4)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod4)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar4,0,  @Fiyat4 , @Tutar4,  '3' ,'AD ',1, @Fiyat4, @Tutar4, 2141.6667, 2141.6667, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar4 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv4 = (@lNetTutar4 * @kdv) /100
SET @BrutTutar4 = @Tutar4
SET @Tutar4 = (@Fiyat4 * @Miktar4) + @lKdv4
SET @lNetTutar4 = @lNetTutar4 + @lKdv4
SET @BTutar4 = @lNetTutar4 - @lKdv4
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar4, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat4, lCikisTutar = @Tutar4, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat4, lBrutTutar = @BrutTutar4, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar4, lMalBedeli = @BTutar4, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar4, lKdv1 = @lKdv4, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar4, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar4, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar4, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
SET @lNetTutar = (SELECT ISNULL(SUM(lBrutTutar), 0) FROM tbStokFisiDetayi WHERE nStokFisiID = @nStokFisiID);
IF @lNetTutar < 3000
BEGIN
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     (-2147473470, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, 1,0.00, 0.00, 0 , '3' ,'AD ',1,0.00, 0.00 , 0, 0, 0, 0.00000000, 0.001, '   ', 0, NULL, '0', NULL, NULL, 20.00, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, 'KARGOBEDELİ', @TarihSaat, '', 0, 0, '', 0 , 0, 0, NULL,  NULL,@nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
END
DECLARE @CarinHesapID INT
DECLARE @CariSiraSonID numeric(10, 0)
DECLARE @MuhasebeSiraSonID numeric(10, 0)
Set @nHesapID = (Select ISNULL(nHesapID, 0) AS nHesapID From tbHesapPlani Where sKodu= @sKodu)
SET @CarinHesapID = (SELECT nHesapID FROM tbFirma WHERE (sKodu = '108.01.02.009') )
SET @Odeme = (select SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (@nFirmaID1, @Tarih, @Tarih, 'iyz ', 'Iyzico ile Tahsilat',@Odeme, 0 ,@SonMahsupFisNo, 0, 'MUH', '001 ', 'Admin', @TarihSaat, '', 0, 0 , '', 0, 0 , 'Admin', @TarihSaat)
SET @nCariHareketID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = @nCariHareketID where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (@Tarih, '3', @SonMahsupFisNo, @SonMahsupFisNo, @SonMahsupFisNo, @CarinHesapID,LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)) + '\Iyzico ile Tahsilat', 0, 0, @Odeme, 0, '', 0, 'CHS', '001 ', @nCariHareketID, 'Admin',@TarihSaat , '', 0, 0, '', 0, 0, 0, '001 ', 'Admin', @TarihSaat)
SET @MuhasebeSiraSonID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = @MuhasebeSiraSonID where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi  ORDER BY nHareketID DESC
SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi(nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (@nFirmaID, @Tarih, @Tarih, 'iyz ', N'Iyzico ile Tahsilat', 0, @Odeme , @SonMahsupFisNo, 0, 'MUH', '001 ', 'Admin', @TarihSaat, '', 0, 0 , '', 0, 0 , 'Admin', @TarihSaat)
SET @nCariHareketID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = @nCariHareketID where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( @Tarih, '3', @SonMahsupFisNo, @SonMahsupFisNo, @SonMahsupFisNo, @nHesapID, N'İyzico Ödeme\K.Kartı ile Tahsilat', 0, 0, 0, @Odeme, '', 0, 'CHS', '001 ', @nCariHareketID, 'Admin', @TarihSaat, '', 0, 0, '', 0, 0, 0, '001 ', 'Admin', @TarihSaat)
SET @MuhasebeSiraSonID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = @SonMahsupFisNo where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)
SET DATEFORMAT DMY  INSERT INTO tbMuhasebeFisiAciklamasi (dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,bKilitli) VALUES     (@Tarih, '3', @SonMahsupFisNo, '', 'FinansEntegre', 'Iyzico ile Tahsilat', '', '',0)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFisKilit                       (nKayitID, sFisTipi, sKullanici, dteKayitTarihi) VALUES     (@SonMahsupFisNo, '3', '1', @TarihSaat)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @SonMahsupFisNo AND sFisTipi ='3  ' and sKullanici ='1'
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)
SET DATEFORMAT DMY  UPDATE    tbMuhasebeFisiAciklamasi SET              sAciklama1 = '', sAciklama2 = 'FinansEntegre' , sAciklama3 = 'Iyzico ile Tahsilat',  sAciklama4 = '', sAciklama5 = 'İyzi Ödeme<-->'+@Adi+@Soyadi,bKilitli =0 where dteFisTarihi = @Tarih  and sMuhFisTipi = '3  ' AND lFisno = @SonMahsupFisNo 
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeFisi SET              dteFisTarihi = @Tarih,sAciklama = LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)) + '\Iyzico ile Tahsilat', lGirenMiktar = 0.0000, lCikanMiktar = 0.0000, lBorcTutar = @Odeme, lAlacakTutar = 0.000000, sMasrafYontemi = '', nKasaID = 0, sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, nSatir = 0, sSubeMagaza = '001 ', sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi =@TarihSaat ,nHesapID = @CarinHesapID Where nFisSiraID = @MuhasebeSiraSonID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID= @nFirmaID1 , dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'iyz', sAciklama = LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)) + '\Iyzico ile Tahsilat'+'FNo:@SonMahsupFisNo', lBorcTutar = @Odeme, lAlacakTutar = 0.000000, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'MUH', sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID = @CariSiraSonID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeFisi SET              dteFisTarihi = @Tarih,sAciklama = 'Iyzi Ödeme\Iyzico ile Tahsilat', lGirenMiktar = 0.0000, lCikanMiktar = 0.0000, lBorcTutar = 0.000000, lAlacakTutar = @Odeme, sMasrafYontemi = '', nKasaID = 0, sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, nSatir = 0, sSubeMagaza = '001 ', sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nHesapID = @nHesapID Where nFisSiraID = @MuhasebeSiraSonID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID= @nFirmaID , dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = '', sAciklama = N'Iyzico Ödeme\Iyzico ile Tahsilat-FNo:@SonMahsupFisNo', lBorcTutar = 0.000000, lAlacakTutar = @Odeme, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'MUH', sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID = @CariSiraSonID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMuhasebe SET lSonMahsupYevmiyeNo = @SonMahsupFisNo
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (sHangiUygulama IN ('IA', 'IS'))
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisverisID),0) AS nKayit FROM         tbAlisVeris Where nMusteriID = @nFirmaID1
end
ELSE If @nFirmaID > '0'
Begin
SET @nFirmaID1=  (SELECT nFirmaID as nFirmaID FROM tbFirma WHERE (sKodu = '108.01.02.009') )
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @KdvTipi = (SELECT sKdvTipi  From tbStok  Where nStokID= @nStokID)
SET @Kdv = (SELECT nKdvOrani  From tbKdv  Where sKdvTipi= @KdvTipi)
SET @sKodu = (SELECT ISNULL(MAX(LTRIM(RTRIM(sKodu))), '120.01.99.0')FROM tbFirma WHERE sKodu LIKE '120.01.99.%');
SET @prefix = LEFT(@sKodu, LEN(@sKodu) - LEN(PARSENAME(@sKodu, 1)));
SET @number = ISNULL(TRY_CAST(PARSENAME(@sKodu, 1) AS BIGINT), 0) + 1;
SET @sKodu = @prefix + FORMAT(@number, '0000000');
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     (@sKodu,@Adi+@Soyadi,'', 0, '', 0, '', '', 0, '1', @Tarih)
Set @nHesapID = (Select ISNULL(nHesapID, 0) AS nHesapID From tbHesapPlani Where sKodu= @sKodu)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirma (sKodu, sAciklama, TC, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi,sSaticiRumuzu,nOzelIskontosu2,nOzelIskontosu3,nOzelIskontosu4,bAktif,bSatisYapilamaz,bSipariseKapali, bTahsilatYapilamaz,sDovizCinsi,nEnlem,nBoylam,nZiyaret,nPeriyod,sDepo, sCariHesapTuru, sEfatura) VALUES (@sKodu,LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)),@TC, 0.00, 0.00, '01/01/1990', 0, N'Sayın', @Adres, N' ', @Ilce,@Il, N' ', @PostaKodu, @VergiDairesi, @VergiNo, @nHesapID, N'0000000', 'sa',@Tarih, N'3   ',N'',0.00,0.00,0.00,1,0, 0, 0,N'   ',0.00000000,0.00000000,0000000,0,N'D001', 'webCari','False')
Set @nFirmaID = (Select ISNULL(nFirmaID, 0) AS nFirmaID From tbFirma Where sKodu= @sKodu)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID,sIletisimAraci,sIletisimAdresi) VALUES (@nFirmaID,'Gsm',@Telefon)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES     (@nFirmaID,'E-Mail',@eMail )
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi (nFirmaID,sSinifKodu1,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu5) VALUES (@nFirmaID,'','3','','','')
Set @AdresID = (Select ISNULL(nFirmaID, 0) AS nFirmaID From tbFirma Where nFirmaID= @nFirmaID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaAdresi SET              sAciklama = N'Fatura', sAdres1 = @Adres, sAdres2 = '', sSemt = @Ilce, sIl = @Il, sUlke = @Ulke, sPostaKodu = @PostaKodu, sVergiDairesi = @VergiDairesi, sVergiNo = @VergiNo, sSubeMagaza = '001 ',sTelefon1 = @Telefon,sTelefon2 = '',sTelefon3 = '',sFaks = '',sMail = @eMail WHERE nAdresID = @AdresID
SET @nEvrakNo =  (SELECT ISNULL(lFaturaEvrakNo, 0) + 1 AS nEvrakNo FROM tbStokFisNolar WHERE (sDepo = 'D001'))
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisNolar SET lFaturaEvrakNo = @nEvrakNo WHERE (sDepo = 'D001')
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
IF ((SELECT COUNT(*) 
     FROM tbStokFisiMaster 
     WHERE lFisNo = (SELECT ISNULL(lToptanFatura1, 0) + 1 
                     FROM tbStokFisNolar 
                     WHERE sDepo = 'D001')) = 0)
BEGIN
    SELECT @lFisNo = ISNULL(lToptanFatura1, 0) + 1 
    FROM tbStokFisNolar 
    WHERE sDepo = 'D001';
END
ELSE
BEGIN
    SELECT @lFisNo = MAX(lFisNo) + 1 
    FROM tbStokFisiMaster;
END


SET @Tutar = (@Fiyat*@Miktar)
SET @Tutar = @Fiyat*@Miktar
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisNolar SET lToptanFatura1 = lToptanFatura1 + 1 WHERE (sDepo = 'D001')
SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, dteTeslimTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2,bKilitli,nEvrakNo) VALUES     ('FS ',@Tarih, @Tarih, 3 , @lFisNo, @nFirmaID, 'D001',@Tarih, 0 , 0 , 0 , 0 , 0, 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0, 0 , 0, 0 , 0, 0 , 0, 0 , 0, 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0, 0 ,  '001 ', 0, 0, '0',  '', 0 , 'Admin', @TarihSaat, '', 0, 0, 0, 0 , 0, 0,0,@nEvrakNo)
SET @nStokFisiID = (SELECT @@identity)
SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES (@nStokFisiID, '', '', '', '', '')
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSiraNo SET nSonID = @nStokFisiID where nSiraIndex = 2
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFisKilit                       (nKayitID, sFisTipi, sKullanici, dteKayitTarihi) VALUES     (@nStokFisiID, 'FS', '1', @TarihSaat)
SET DATEFORMAT DMY INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES (@nFirmaID, @Tarih,@Tarih, 'FS ', 'Evrak No' + @MahsupFis,@Tutar, 0, @SonMahsupFisNo, 0, 'FS ', '001 ', 'Admin',@TarihSaat, '', 0, 0, '', 0, 0, 'Admin', @TarihSaat) 
SET @nCariHareketID = (SELECT @@identity)
SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     (@nStokFisiID, @Tarih, @Tutar, 'FS ', @nCariHareketID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = @nCariHareketID where nSiraIndex = 1
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
Set @nHesapID = (Select ISNULL(nHesapID, 0) AS nHesapID From tbHesapPlani Where sKodu= @sKodu)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, @Miktar, @Fiyat , @Tutar, 0 , '3' ,'AD ',1,@Fiyat, @Tutar , 0, 0, 0, 0.00000000, 0.001, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0, '', 0 , 0, 0, NULL,  NULL,@nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID1, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @Tutar, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @Tutar, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat, lCikisTutar = @Tutar, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat, lBrutTutar = @Tutar, lMaliyetFiyat = 875.8642, lMaliyetTutar = 875.8642, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
SET @lNetTutar = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv = (@Tutar * @Kdv) /100
SET @Tutar = (@Fiyat*@Miktar) + @lKdv 
SET @BrutTutar = @Tutar - @lKdv

SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @Miktar, lMalBedeli = @BrutTutar, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @BrutTutar, lKdv1 = @lKdv, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar = @Tutar, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 1000.00, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisNolar SET lFaturaEvrakNo = @nEvrakNo WHERE (sDepo = 'D001')
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @Tutar, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @Tutar, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 


IF @Barkod1 > '0'
BEGIN

SET @Tutar1 = @Miktar1 * @Fiyat1
SET @ToplamTutar1 = @lNetTutar + @Tutar1
SET @ToplamMiktar1 = (@Miktar+@Miktar1)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod1)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar1, 0, @Fiyat1 , @Tutar1, '3' ,'AD ',1, @Fiyat1, @Tutar1 , 0, 0, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar1 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv1 =(@lNetTutar1 * @kdv) /100
SET @BrutTutar1 = @Tutar1
SET @Tutar1 = (@Miktar1 * @Fiyat1)
SET @lNetTutar1 = @lNetTutar1 + @lKdv1
SET @BTutar1 = @lNetTutar1 - @lKdv1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar1, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat1, lCikisTutar = @Tutar1, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat1, lBrutTutar = @BrutTutar1, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar1, lMalBedeli = @BTutar1, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar1, lKdv1 = @lKdv1, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar1, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar1, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar1, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
IF @Barkod2 > '0'
BEGIN

SET @Tutar2 = @Miktar2 * @Fiyat2
SELECT @Tutar2
SET @ToplamTutar2 = (@lNetTutar1 + @Tutar2)
SET @ToplamMiktar2 = (@Miktar+@Miktar1+@Miktar2)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod2)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar2, 0,  @Fiyat2 , @Tutar2, '3' ,'AD ',1, @Fiyat2, @Tutar2, 2141.6667, 2141.6667, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar2 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv2 = (@lNetTutar2 * @kdv)/100
SET @BrutTutar2 = @Tutar2
SET @Tutar2 = (@Miktar2 * @Fiyat2)
SET @lNetTutar2 = @lNetTutar2 + @lKdv2
SET @BTutar2 = @lNetTutar2 - @lKdv2
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar2, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat2, lCikisTutar = @Tutar1, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat2, lBrutTutar = @BrutTutar2, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar2, lMalBedeli = @BTutar2, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar2, lKdv1 = @lKdv2, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar2, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar2, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar2, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
IF @Barkod3 > '0'
BEGIN
SET @Tutar3 = @Miktar3 * @Fiyat3
SET @ToplamTutar3 = @lNetTutar2 + @Tutar3
SET @ToplamMiktar3 = (@Miktar+@Miktar1+@Miktar2+@Miktar3)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod3)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar3,0,  @Fiyat3 , @Tutar3,  '3' ,'AD ',1, @Fiyat3, @Tutar3 , 2141.6667, 2141.6667, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar3 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv3 = (@lNetTutar3 * @kdv) /100
SET @BrutTutar3 = @Tutar3
SET @Tutar3 = (@Miktar3 * @Fiyat3) + @lKdv3
SET @lNetTutar3 = @lNetTutar3 + @lKdv3
SET @BTutar3 = @lNetTutar3 - @lKdv3
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar3, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat3, lCikisTutar = @Tutar3, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat3, lBrutTutar = @BrutTutar3, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar3, lMalBedeli = @BTutar3, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar3, lKdv1 = @lKdv3, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar3, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar3, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar3, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
IF @Barkod4 > '0'
BEGIN
SET @Tutar4 = @Fiyat4 * @Miktar4
SET @ToplamTutar4 = @lNetTutar3 + @Tutar4
SET @ToplamMiktar4 = (@Miktar+@Miktar1+@Miktar2+@Miktar3+@Miktar4)
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET @nStokID = (SELECT nStokID From tbStokBarkodu Where sBarkod = @Barkod4)
SET @StokAdi = (SELECT sAciklama  From tbStok  Where nStokID= @nStokID)
SET @nStokIslemID = ( SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES (@nStokID, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', 100, '', @Tarih, '0', 0, 0, 0, 0, @Miktar4,0,  @Fiyat4 , @Tutar4,  '3' ,'AD ',1, @Fiyat4, @Tutar4, 2141.6667, 2141.6667, 0, 0.00000000, 0, '   ', 0, NULL, '0', NULL, NULL, @Kdv, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, @StokAdi, @TarihSaat, '', 0, 0.0000, '', 0 , 0, 0, NULL,  NULL, @nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
SET @lNetTutar4 = (SELECT  ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = @nStokFisiID ))
SET @lKdv4 = (@lNetTutar4 * @kdv) /100
SET @BrutTutar4 = @Tutar4
SET @Tutar4 = (@Fiyat4 * @Miktar4) + @lKdv4
SET @lNetTutar4 = @lNetTutar4 + @lKdv4
SET @BTutar4 = @lNetTutar4 - @lKdv4
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET nStokID = @nStokID, dteIslemTarihi = @Tarih, nFirmaID = @nFirmaID, nMusteriID = 0, sFisTipi = 'FS ', dteFisTarihi = @Tarih, lFisNo = @lFisNo, nGirisCikis = 3, sDepo = 'D001', lReyonFisNo = 0, sStokIslem = '', sKasiyerRumuzu = '', sSaticiRumuzu = '100', sOdemeKodu = '', dteIrsaliyeTarihi = @Tarih, lIrsaliyeNo = '0', lGirisMiktar1 = 0, lGirisMiktar2 = 0, lGirisFiyat = 0, lGirisTutar = 0, lCikisMiktar1 = @Miktar4, lCikisMiktar2 = 0, lCikisFiyat = @Fiyat4, lCikisTutar = @Tutar4, sFiyatTipi = '3', sBirimCinsi ='AD ',lBirimMiktar = 1,lBrutFiyat = @Fiyat4, lBrutTutar = @BrutTutar4, lMaliyetFiyat = 0, lMaliyetTutar = 0, lIlaveMaliyetTutar = 0, nIskontoYuzdesi = 0.00000000, lIskontoTutari = 0.0000000000000000000000000, sDovizCinsi = '   ', lDovizFiyat = 0, nReceteNo = 0, nKdvOrani = @Kdv, nHesapID = 0, sAciklama = N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Isk5:00.00 Msrf:0.0000', sHareketTipi = '001 ' , bMuhasebeyeIslendimi = 0, sKullaniciAdi = @StokAdi, dteKayitTarihi = @TarihSaat, sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, nOTVOrani = 0, sMasrafYontemi = '', sHangiUygulama = 'FS ', nEkSaha1 = 0, nEkSaha2 = 0, bEkSoru1 = 0, bEkSoru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nPrim = 0,lPrimTutari = 0 Where nStokFisiID = @nStokFisiID and nIslemID = @nStokIslemID
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lToplamMiktar = @ToplamMiktar4, lMalBedeli = @BTutar4, lMalIskontoTutari = 0.00000000, nDipIskontoYuzdesi1 = 0.00, lDipIskontoTutari1 = 0, nDipIskontoYuzdesi2 = 0.00, lDipIskontoTutari2 = 0, lDipIskontoTutari3 = 0, lEkmaliyet1 = 0.00, lEkmaliyet2 = 0.00, lEkmaliyet3 = @EkMaliyet3, nKdvOrani1 = @Kdv, lKdvMatrahi1 = @Tutar4, lKdv1 = @lKdv4, nKdvOrani2 = 0, lKdvMatrahi2 = 0, lKdv2 = 0, nKdvOrani3 = 0, lKdvMatrahi3 = 0, lKdv3 = 0, nKdvOrani4 = 0, lKdvMatrahi4 = 0, lKdv4 = 0, nKdvOrani5 = 0, lKdvMatrahi5 = 0, lKdv5 = 0, lNetTutar =@lNetTutar4, nTevkifatKdvOrani = 0.00, lTevkifatKdvMatrahi = 0, lTevkifatKdv = 0, nOTVOrani1 = 0.000, lOTVMatrahi1 = 0.000, lOTV1 = 0.000000, nOTVOrani2 = 0, lOTVMatrahi2 = 0.00, lOTV2 = 0.00, sYaziIle= 'Bin İkiyüz TL', bFisTamamlandimi = 1 WHERE nStokFisiID = @nStokFisiID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = @nFirmaID, dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'FS ', sAciklama = 'Evrak No' + @MahsupFis, lBorcTutar = @lNetTutar4, lAlacakTutar = 0, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'FS ', sHareketTipi = '001 ', sDovizCinsi1 = '', lDovizMiktari1 = 0, lDovizKuru1 = 0.0000, sDovizCinsi2 = '', lDovizMiktari2 = 0, lDovizKuru2 = 0, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = @nStokFisiID )))
SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = @Tarih, lTutari = @ToplamTutar4, sCariIslem = 'FS ' WHERE     (nStokFisiID = @nStokFisiID) 
SET @Odeme = (SELECT SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @nStokFisiID AND sFisTipi ='FS ' and sKullanici ='1'
end
SET @lNetTutar = (SELECT ISNULL(SUM(lBrutTutar), 0) FROM tbStokFisiDetayi WHERE nStokFisiID = @nStokFisiID);

IF @lNetTutar < 3000
BEGIN
SET @nStokIslemID = (SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     (-2147473470, @Tarih, @nFirmaID, '0', 'FS ', @Tarih, @lFisNo, 3, 'D001', '0', '', '', '100', '', @Tarih, '0', 0, 0, 0, 0, 1,0.00, 0.00, 0 , '3' ,'AD ',1,0.00, 0.00 , 0, 0, 0, 0.00000000, 0.001, '   ', 0, NULL, '0', NULL, NULL, 20.00, '0', N'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00 Msrf:0.0000', '001 ',0, 'KARGOBEDELİ', @TarihSaat, '', 0, 0, '', 0 , 0, 0, NULL,  NULL,@nStokFisiID, NULL, '', 'FS ', 0, 0, 0 , 0, 'Admin', @TarihSaat,0.50,0.000)
SET @nStokIslemID =(SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = @nStokIslemID where nSiraIndex = 1
END
SET @CarinHesapID = (SELECT nHesapID FROM tbFirma WHERE (sKodu = '108.01.02.009') )
SET @Odeme = (select SUM (lBorcTutar - lAlacakTutar ) as Bakiye from tbFirmaHareketi where nFirmaID = @nFirmaID)
SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (@nFirmaID1, @Tarih, @Tarih, 'iyz ', 'Iyzico ile Tahsilat',@Odeme, 0 ,@SonMahsupFisNo, 0, 'MUH', '001 ', 'Admin', @TarihSaat, '', 0, 0 , '', 0, 0 , 'Admin', @TarihSaat)
SET @nCariHareketID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = @nCariHareketID where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (@Tarih, '3', @SonMahsupFisNo, @SonMahsupFisNo, @SonMahsupFisNo, @CarinHesapID, LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)) + '\Iyzico ile Tahsilat', 0, 0, @Odeme, 0, '', 0, 'CHS', '001 ', @nCariHareketID, 'Admin',@TarihSaat , '', 0, 0, '', 0, 0, 0, '001 ', 'Admin', @TarihSaat)
SET @MuhasebeSiraSonID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = @MuhasebeSiraSonID where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi  ORDER BY nHareketID DESC
SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi(nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (@nFirmaID, @Tarih, @Tarih, 'iyz ', N'Iyzico ile Tahsilat', 0, @Odeme , @SonMahsupFisNo, 0, 'MUH', '001 ', 'Admin', @TarihSaat, '', 0, 0 , '', 0, 0 , 'Admin', @TarihSaat)
SET @nCariHareketID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = @nCariHareketID where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( @Tarih, '3', @SonMahsupFisNo, @SonMahsupFisNo, @SonMahsupFisNo, @nHesapID, N'İyzico Ödeme\K.Kartı ile Tahsilat', 0, 0, 0, @Odeme, '', 0, 'CHS', '001 ', @nCariHareketID, 'Admin', @TarihSaat, '', 0, 0, '', 0, 0, 0, '001 ', 'Admin', @TarihSaat)
SET @MuhasebeSiraSonID= (SELECT @@identity)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = @SonMahsupFisNo where nSiraIndex = 1
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)
SET DATEFORMAT DMY  INSERT INTO tbMuhasebeFisiAciklamasi (dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,bKilitli) VALUES     (@Tarih, '3', @SonMahsupFisNo, '', 'FinansEntegre', 'Iyzico ile Tahsilat', '', '',0)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFisKilit                       (nKayitID, sFisTipi, sKullanici, dteKayitTarihi) VALUES     (@SonMahsupFisNo, '3', '1', @TarihSaat)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFisKilit where nKayitID = @SonMahsupFisNo AND sFisTipi ='3  ' and sKullanici ='1'
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)
SET DATEFORMAT DMY  UPDATE    tbMuhasebeFisiAciklamasi SET              sAciklama1 = '', sAciklama2 = 'FinansEntegre' , sAciklama3 = 'Iyzico ile Tahsilat',  sAciklama4 = '', sAciklama5 = 'İyzi Ödeme<-->'+@Adi+@Soyadi,bKilitli =0 where dteFisTarihi = @Tarih  and sMuhFisTipi = '3  ' AND lFisno = @SonMahsupFisNo 
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeFisi SET              dteFisTarihi = @Tarih,sAciklama = LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)) + '\Iyzico ile Tahsilat', lGirenMiktar = 0.0000, lCikanMiktar = 0.0000, lBorcTutar = @Odeme, lAlacakTutar = 0.000000, sMasrafYontemi = '', nKasaID = 0, sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, nSatir = 0, sSubeMagaza = '001 ', sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi =@TarihSaat ,nHesapID = @CarinHesapID Where nFisSiraID = @MuhasebeSiraSonID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID= @nFirmaID1 , dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = 'iyz', sAciklama = LTRIM(RTRIM(@Adi)) + ' ' + LTRIM(RTRIM(@Soyadi)) + '\Iyzico ile Tahsilat'+'FNo:@SonMahsupFisNo', lBorcTutar = @Odeme, lAlacakTutar = 0.000000, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'MUH', sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID = @CariSiraSonID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeFisi SET              dteFisTarihi = @Tarih,sAciklama = 'Iyzi Ödeme\Iyzico ile Tahsilat', lGirenMiktar = 0.0000, lCikanMiktar = 0.0000, lBorcTutar = 0.000000, lAlacakTutar = @Odeme, sMasrafYontemi = '', nKasaID = 0, sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, nSatir = 0, sSubeMagaza = '001 ', sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat,nHesapID = @nHesapID Where nFisSiraID = @MuhasebeSiraSonID
SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID= @nFirmaID , dteIslemTarihi = @Tarih, dteValorTarihi = @Tarih, sCariIslem = '', sAciklama = N'Iyzico Ödeme\Iyzico ile Tahsilat-FNo:@SonMahsupFisNo', lBorcTutar = 0.000000, lAlacakTutar = @Odeme, sEvrakNo = @SonMahsupFisNo, lVadeFarki = 0, sHangiUygulama = 'MUH', sHareketTipi = '001 ', sDovizCinsi1 = '   ', lDovizMiktari1 = 0.0000, lDovizKuru1 = 0.0000, sDovizCinsi2 = '   ', lDovizMiktari2 = 0.0000, lDovizKuru2 = 0.0000, sSonKullaniciAdi = 'Admin', dteSonUpdateTarihi = @TarihSaat  WHERE     (nHareketID = @CariSiraSonID)
SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMuhasebe SET lSonMahsupYevmiyeNo = @SonMahsupFisNo
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (sHangiUygulama IN ('IA', 'IS'))
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nAlisverisID),0) AS nKayit FROM         tbAlisVeris Where nMusteriID = @nFirmaID1
end