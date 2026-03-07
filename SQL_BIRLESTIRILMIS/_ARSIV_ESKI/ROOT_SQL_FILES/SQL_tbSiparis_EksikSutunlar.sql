-- =============================================
-- tbSiparis Tablosu Eksik Sütunlar SQL SCRIPT
-- Tarih: 2026-01-21
-- Açıklama: frm_tbSiparis.vb dosyasındaki kodun 
-- kullandığı ancak tabloda bulunmayan sütunları ekler
-- =============================================

-- 1. sDurum sütunu ekleme (Sipariş durumu için)
-- Kullanılan değerler: 'Onaylandi', 'UretimBekliyor', 'SatinAlmaBekliyor', 'ReceteEksik'
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbSiparis') AND name = 'sDurum')
BEGIN
    ALTER TABLE tbSiparis ADD sDurum NVARCHAR(50) NULL
    PRINT 'sDurum sütunu tbSiparis tablosuna eklendi.'
END
ELSE
BEGIN
    PRINT 'sDurum sütunu zaten mevcut.'
END
GO

-- 2. Mevcut siparişlerin durumunu güncelle (opsiyonel)
-- Onaylanmış siparişler için varsayılan değer atama
UPDATE tbSiparis 
SET sDurum = 'Onaylandi' 
WHERE bOnaylandi = 1 AND sDurum IS NULL
PRINT 'Onaylı siparişlerin durumu güncellendi.'
GO

-- Onay bekleyen siparişler için varsayılan değer atama
UPDATE tbSiparis 
SET sDurum = 'OnayBekliyor' 
WHERE ISNULL(bOnaylandi, 0) = 0 AND ISNULL(bOnayBekliyor, 0) = 1 AND sDurum IS NULL
PRINT 'Onay bekleyen siparişlerin durumu güncellendi.'
GO

PRINT ''
PRINT '============================================='
PRINT 'tbSiparis TABLOSU GÜNCELLEMESİ TAMAMLANDI!'
PRINT '============================================='
GO
