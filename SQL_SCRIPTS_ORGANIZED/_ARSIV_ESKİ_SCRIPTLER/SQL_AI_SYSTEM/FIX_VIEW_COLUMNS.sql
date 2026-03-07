-- ============================================================================
-- VIEW DÜZELTME SCRİPTİ
-- ============================================================================
-- Kolon adı hatasını düzeltir: sBarkod -> sKodu, sStokAdi -> sAciklama
-- ============================================================================

USE [BARKOD_MAGAZA] -- Kendi veritabanı adınızı yazın
GO

PRINT 'View düzeltiliyor...'

-- Önce mevcut view'ı sil
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_StokAIOzet')
BEGIN
    DROP VIEW vw_StokAIOzet
    PRINT '✓ Eski view silindi'
END
GO

-- Yeni view'ı doğru kolon adlarıyla oluştur
CREATE VIEW vw_StokAIOzet AS
SELECT 
    s.nStokID,
    s.sModel,
    s.sKodu AS sBarkod,           -- DÜZELTME: sBarkod -> sKodu
    s.sAciklama AS sStokAdi,      -- DÜZELTME: sStokAdi -> sAciklama
    s.bAIIcerikVar,
    s.dteAISonGuncelleme,
    s.nAIKaliteSkor,
    
    ai.sSEOBaslik,
    ai.sKisaAciklama,
    ai.bOnaylandi,
    ai.nAIMaliyet,
    ai.dteOlusturma AS AIIcerikTarihi,
    
    (SELECT COUNT(*) FROM tbStokResim WHERE nStokID = s.nStokID AND bAIBulundu = 1) AS AIResimSayisi,
    
    CASE 
        WHEN s.bAIIcerikVar = 1 AND ai.bOnaylandi = 1 THEN 'Onaylandı'
        WHEN s.bAIIcerikVar = 1 AND ai.bOnaylandi = 0 THEN 'Onay Bekliyor'
        ELSE 'AI İçerik Yok'
    END AS sDurum
    
FROM tbStok s
LEFT JOIN tbStokAIIcerik ai ON s.nStokID = ai.nStokID
GO

PRINT '✅ View başarıyla düzeltildi!'
PRINT ''
PRINT 'Test sorgusu:'
PRINT 'SELECT TOP 10 * FROM vw_StokAIOzet'
GO
