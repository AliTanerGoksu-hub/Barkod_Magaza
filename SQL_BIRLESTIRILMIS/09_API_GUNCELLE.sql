-- =============================================
-- TRENDYOL API BİLGİLERİNİ GÜNCELLE
-- Dosya: 09_API_GUNCELLE.sql
-- =============================================

USE [YONCALINES]
GO

-- Mevcut kayıtları güncelle
UPDATE tbTrendyolAyar
SET 
    sSupplierId = '708257',
    sApiKey = 'n4KSHjK0VPTmzlcco4iJ',
    sApiSecret = 'XwWTP5lvWnktDukgz9dn',
    sBaseUrl = 'https://apigw.trendyol.com/integration',
    dteGuncelleme = GETDATE()
WHERE bAktif = 1

-- Eğer kayıt yoksa ekle
IF @@ROWCOUNT = 0
BEGIN
    INSERT INTO tbTrendyolAyar (sSupplierId, sApiKey, sApiSecret, sBaseUrl, bAktif)
    VALUES ('708257', 'n4KSHjK0VPTmzlcco4iJ', 'XwWTP5lvWnktDukgz9dn', 'https://api.trendyol.com/sapigw', 1)
END

PRINT 'API bilgileri güncellendi!'
PRINT ''
PRINT 'Yeni bilgiler:'
PRINT 'Supplier ID: 708257'
PRINT 'API Key: n4KSHjK0VPTmzlcco4iJ'
PRINT 'API Secret: XwWTP5lvWnktDukgz9dn'
GO
