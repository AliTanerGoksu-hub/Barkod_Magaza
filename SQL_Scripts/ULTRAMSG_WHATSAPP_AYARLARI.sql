-- =============================================
-- ULTRAMSG WHATSAPP API AYARLARI
-- =============================================
-- tbSistemAyar tablosu icin duzeltilmis script
-- Kolon isimleri: sAyarKodu, sAyarDeger, sAciklama, bAktif
-- =============================================

-- WhatsApp Aktif/Pasif ayari
IF EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'WHATSAPP_AKTIF')
BEGIN
    UPDATE tbSistemAyar SET sAyarDeger = '1' WHERE sAyarKodu = 'WHATSAPP_AKTIF'
    PRINT 'WHATSAPP_AKTIF guncellendi.'
END
ELSE
BEGIN
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama, bAktif) 
    VALUES ('WHATSAPP_AKTIF', '1', 'WhatsApp bildirim aktif (1) / pasif (0)', 1)
    PRINT 'WHATSAPP_AKTIF eklendi.'
END
GO

-- UltraMsg Instance ID
IF EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'ULTRAMSG_INSTANCE_ID')
BEGIN
    UPDATE tbSistemAyar SET sAyarDeger = 'instance157897' WHERE sAyarKodu = 'ULTRAMSG_INSTANCE_ID'
    PRINT 'ULTRAMSG_INSTANCE_ID guncellendi.'
END
ELSE
BEGIN
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama, bAktif) 
    VALUES ('ULTRAMSG_INSTANCE_ID', 'instance157897', 'UltraMsg Instance ID', 1)
    PRINT 'ULTRAMSG_INSTANCE_ID eklendi.'
END
GO

-- UltraMsg Token
IF EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu = 'ULTRAMSG_TOKEN')
BEGIN
    UPDATE tbSistemAyar SET sAyarDeger = '4s5wk3zkxn17ws9' WHERE sAyarKodu = 'ULTRAMSG_TOKEN'
    PRINT 'ULTRAMSG_TOKEN guncellendi.'
END
ELSE
BEGIN
    INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama, bAktif) 
    VALUES ('ULTRAMSG_TOKEN', '4s5wk3zkxn17ws9', 'UltraMsg API Token', 1)
    PRINT 'ULTRAMSG_TOKEN eklendi.'
END
GO

-- Ayarlari kontrol et
SELECT sAyarKodu, sAyarDeger, sAciklama, bAktif 
FROM tbSistemAyar 
WHERE sAyarKodu IN ('WHATSAPP_AKTIF', 'ULTRAMSG_INSTANCE_ID', 'ULTRAMSG_TOKEN')
ORDER BY sAyarKodu

PRINT ''
PRINT '=========================================='
PRINT 'ULTRAMSG AYARLARI TAMAMLANDI!'
PRINT '=========================================='
GO
