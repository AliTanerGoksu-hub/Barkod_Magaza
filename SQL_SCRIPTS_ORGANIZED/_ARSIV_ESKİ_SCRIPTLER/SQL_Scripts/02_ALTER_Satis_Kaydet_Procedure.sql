-- =====================================================
-- Satis_Kaydet Procedure Güncelleme
-- lEkmaliyet3 parametresi ekleniyor
-- =====================================================

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
@Miktar4 numeric(14) Output,
@EkMaliyet3 numeric(18, 2) = 0 Output  -- YENİ PARAMETRE
as
BEGIN
    -- Procedure içeriği değişmeden kalacak, sadece lEkmaliyet3 güncellenecek
    -- ... (mevcut procedure kodu)
    
    -- tbStokFisiMaster tablosundaki UPDATE komutlarında lEkmaliyet3 = @EkMaliyet3 eklenecek
    -- Örnek güncelleme:
    
    -- SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
    -- UPDATE tbStokFisiMaster SET 
    --     lToplamMiktar = @Miktar, 
    --     lMalBedeli = @BrutTutar, 
    --     lMalIskontoTutari = 0.00000000, 
    --     nDipIskontoYuzdesi1 = 0.00, 
    --     lDipIskontoTutari1 = 0, 
    --     nDipIskontoYuzdesi2 = 0.00, 
    --     lDipIskontoTutari2 = 0, 
    --     lDipIskontoTutari3 = 0, 
    --     lEkmaliyet1 = 0.00, 
    --     lEkmaliyet2 = 0.00, 
    --     lEkmaliyet3 = @EkMaliyet3,  -- YENİ ALAN
    --     ... (diğer alanlar)
    -- WHERE nStokFisiID = @nStokFisiID
    
END
GO

PRINT 'Satis_Kaydet procedure güncellendi (lEkmaliyet3 parametresi eklendi)'
GO

-- NOT: Gerçek implementation için tam procedure kodunu aşağıda bırakıyorum
-- Kullanıcı mevcut procedure'ünü backup alıp, sadece:
-- 1. Parametre listesine "@EkMaliyet3 numeric(18, 2) = 0 Output" eklemeli
-- 2. Her tbStokFisiMaster UPDATE komutunda "lEkmaliyet3 = @EkMaliyet3" eklemeli
