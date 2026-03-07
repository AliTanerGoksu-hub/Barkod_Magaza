-- =============================================
-- SURE VE FIRE TAKIBI - RAPORLAMA VIEWLARI
-- Planlanan vs Gerceklesen sure/fire
-- Aşırı gecikme ve fire KIRMIZI ile isaretlenir
-- =============================================

PRINT '=============================================';
PRINT 'SURE VE FIRE RAPORLAMA SISTEMI KURULUYOR';
PRINT '=============================================';

-- =============================================
-- 1. VIEW: Asama Sure Performansi
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_AsamaSurePerformansi')
    DROP VIEW vw_AsamaSurePerformansi
GO

CREATE VIEW vw_AsamaSurePerformansi AS
SELECT 
    e.nID,
    e.nUretimEmriID,
    u.EVRAKNO,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    a.sAsamaAdi,
    a.nSiraNo,
    e.sDurum,
    e.dteBaslangic,
    e.dteBitis,
    e.nPlanlananSure,
    CASE 
        WHEN e.dteBitis IS NOT NULL AND e.dteBaslangic IS NOT NULL 
        THEN DATEDIFF(MINUTE, e.dteBaslangic, e.dteBitis)
        WHEN e.dteBaslangic IS NOT NULL 
        THEN DATEDIFF(MINUTE, e.dteBaslangic, GETDATE())
        ELSE 0 
    END AS nGerceklesenSure,
    CASE 
        WHEN e.nPlanlananSure > 0 THEN
            CASE 
                WHEN e.dteBitis IS NOT NULL AND e.dteBaslangic IS NOT NULL 
                THEN DATEDIFF(MINUTE, e.dteBaslangic, e.dteBitis) - e.nPlanlananSure
                WHEN e.dteBaslangic IS NOT NULL 
                THEN DATEDIFF(MINUTE, e.dteBaslangic, GETDATE()) - e.nPlanlananSure
                ELSE 0 
            END
        ELSE 0
    END AS nGecikmeSuresi,
    CASE 
        WHEN e.nPlanlananSure > 0 AND (
            (e.dteBitis IS NOT NULL AND e.dteBaslangic IS NOT NULL AND DATEDIFF(MINUTE, e.dteBaslangic, e.dteBitis) > e.nPlanlananSure * 1.1)
            OR (e.dteBaslangic IS NOT NULL AND e.dteBitis IS NULL AND DATEDIFF(MINUTE, e.dteBaslangic, GETDATE()) > e.nPlanlananSure * 1.1)
        )
        THEN 1 ELSE 0 
    END AS bGecikmeVar,  -- %10 tolerans asildi ise 1 (KIRMIZI)
    u.MIKTAR AS PlanlananMiktar
FROM tbUretimEmriAsama e
INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID
INNER JOIN TBLUREURETIM u ON e.nUretimEmriID = u.EVRAKNO OR e.nUretimEmriID = u.IND
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
GO
PRINT 'vw_AsamaSurePerformansi view olusturuldu.'

-- =============================================
-- 2. VIEW: Asama Fire Performansi
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_AsamaFirePerformansi')
    DROP VIEW vw_AsamaFirePerformansi
GO

CREATE VIEW vw_AsamaFirePerformansi AS
SELECT 
    e.nID,
    e.nUretimEmriID,
    u.EVRAKNO,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    a.sAsamaAdi,
    a.nSiraNo,
    e.sDurum,
    e.lPlanlananMiktar,
    e.lGerceklesenMiktar,
    ISNULL(e.lFireMiktar, 0) AS lFireMiktar,
    a.lStandartFireOrani,  -- Standart fire orani (%)
    CASE 
        WHEN ISNULL(e.lPlanlananMiktar, 0) > 0 
        THEN (ISNULL(e.lFireMiktar, 0) / e.lPlanlananMiktar) * 100
        ELSE 0 
    END AS lGerceklesenFireOrani,  -- Gerceklesen fire orani (%)
    CASE 
        WHEN ISNULL(e.lPlanlananMiktar, 0) > 0 AND a.lStandartFireOrani > 0 AND
             (ISNULL(e.lFireMiktar, 0) / e.lPlanlananMiktar) * 100 > a.lStandartFireOrani * 1.2
        THEN 1 ELSE 0 
    END AS bAsiriFire,  -- %20 tolerans asildi ise 1 (KIRMIZI)
    u.MIKTAR AS ToplamPlanlananMiktar
FROM tbUretimEmriAsama e
INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID
INNER JOIN TBLUREURETIM u ON e.nUretimEmriID = u.EVRAKNO OR e.nUretimEmriID = u.IND
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
GO
PRINT 'vw_AsamaFirePerformansi view olusturuldu.'

-- =============================================
-- 3. VIEW: Uretim Emri Ozet Raporu
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_UretimEmriOzet')
    DROP VIEW vw_UretimEmriOzet
GO

CREATE VIEW vw_UretimEmriOzet AS
SELECT 
    u.IND,
    u.EVRAKNO,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    u.TARIH,
    u.MIKTAR,
    u.DURUM,
    u.dtePlanlananBaslangic,
    u.dteGercekBitis,
    u.nSiparisID,
    a.sAsamaAdi AS MevcutAsama,
    (SELECT COUNT(*) FROM tbUretimEmriAsama WHERE nUretimEmriID = u.EVRAKNO AND sDurum = 'Tamamlandi') AS TamamlananAsamaSayisi,
    (SELECT COUNT(*) FROM tbUretimEmriAsama WHERE nUretimEmriID = u.EVRAKNO) AS ToplamAsamaSayisi,
    (SELECT SUM(ISNULL(lFireMiktar, 0)) FROM tbUretimEmriAsama WHERE nUretimEmriID = u.EVRAKNO) AS ToplamFire,
    (SELECT COUNT(*) FROM tbUretimEmriAsamaOnaylar WHERE nUretimEmriID = u.EVRAKNO AND sOnayDurum = 'Bekliyor') AS BekleyenOnaySayisi,
    CASE 
        WHEN u.dtePlanlananBaslangic IS NOT NULL AND u.dteGercekBitis IS NOT NULL 
        THEN DATEDIFF(HOUR, u.dtePlanlananBaslangic, u.dteGercekBitis)
        ELSE NULL 
    END AS ToplamSure
FROM TBLUREURETIM u
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
LEFT JOIN tbUretimAsamaTanim a ON u.nMevcutAsamaID = a.nAsamaID
GO
PRINT 'vw_UretimEmriOzet view olusturuldu.'

-- =============================================
-- 4. VIEW: Geciken Asamalar (KIRMIZI RAPOR)
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_GecikenAsamalar')
    DROP VIEW vw_GecikenAsamalar
GO

CREATE VIEW vw_GecikenAsamalar AS
SELECT 
    e.nUretimEmriID,
    u.EVRAKNO,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    a.sAsamaAdi,
    e.dteBaslangic,
    e.nPlanlananSure,
    DATEDIFF(MINUTE, e.dteBaslangic, ISNULL(e.dteBitis, GETDATE())) AS GerceklesenSure,
    DATEDIFF(MINUTE, e.dteBaslangic, ISNULL(e.dteBitis, GETDATE())) - e.nPlanlananSure AS GecikmeSuresi,
    CAST((DATEDIFF(MINUTE, e.dteBaslangic, ISNULL(e.dteBitis, GETDATE())) - e.nPlanlananSure) * 100.0 / NULLIF(e.nPlanlananSure, 0) AS DECIMAL(10,2)) AS GecikmeOrani
FROM tbUretimEmriAsama e
INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID
INNER JOIN TBLUREURETIM u ON e.nUretimEmriID = u.EVRAKNO
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
WHERE e.nPlanlananSure > 0 
AND DATEDIFF(MINUTE, e.dteBaslangic, ISNULL(e.dteBitis, GETDATE())) > e.nPlanlananSure * 1.1
GO
PRINT 'vw_GecikenAsamalar view olusturuldu (KIRMIZI icin).'

-- =============================================
-- 5. VIEW: Asiri Fireli Asamalar (KIRMIZI RAPOR)
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_AsiriFireliAsamalar')
    DROP VIEW vw_AsiriFireliAsamalar
GO

CREATE VIEW vw_AsiriFireliAsamalar AS
SELECT 
    e.nUretimEmriID,
    u.EVRAKNO,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    a.sAsamaAdi,
    e.lPlanlananMiktar,
    e.lGerceklesenMiktar,
    e.lFireMiktar,
    a.lStandartFireOrani AS StandartFireOrani,
    CAST((e.lFireMiktar / NULLIF(e.lPlanlananMiktar, 0)) * 100 AS DECIMAL(10,2)) AS GerceklesenFireOrani,
    CAST(((e.lFireMiktar / NULLIF(e.lPlanlananMiktar, 0)) * 100) - a.lStandartFireOrani AS DECIMAL(10,2)) AS AsimMiktar
FROM tbUretimEmriAsama e
INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID
INNER JOIN TBLUREURETIM u ON e.nUretimEmriID = u.EVRAKNO
INNER JOIN tbStok s ON u.STOKNO = s.nStokID
WHERE a.lStandartFireOrani > 0 
AND e.lPlanlananMiktar > 0
AND (e.lFireMiktar / e.lPlanlananMiktar) * 100 > a.lStandartFireOrani * 1.2
GO
PRINT 'vw_AsiriFireliAsamalar view olusturuldu (KIRMIZI icin).'

-- =============================================
-- 6. VIEW: Bekleyen Satin Alma Onaylari
-- =============================================
IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_BekleyenSatinAlmaOnaylari')
    DROP VIEW vw_BekleyenSatinAlmaOnaylari
GO

CREATE VIEW vw_BekleyenSatinAlmaOnaylari AS
SELECT 
    o.nID,
    o.nAlinanSiparisID,
    s.sKodu AS StokKodu,
    s.sAciklama AS StokAdi,
    f.sKodu AS TedarikciKodu,
    f.sAciklama AS TedarikciAdi,
    o.lTalepMiktar,
    o.lBirimFiyat,
    o.lTalepMiktar * o.lBirimFiyat AS ToplamTutar,
    o.sDurum,
    o.nGerekliOnay,
    o.nMevcutOnay,
    (SELECT sAdi + ' ' + sSoyadi FROM APERSONEL WHERE nKullaniciID = o.nTalepEdenID) AS TalepEden,
    o.dteKayit,
    o.sAciklama
FROM tbOtomatikSiparis o
INNER JOIN tbStok s ON o.nStokID = s.nStokID
INNER JOIN tbFirma f ON o.nTedarikciID = f.nFirmaID
WHERE o.sDurum = 'OnayBekliyor'
GO
PRINT 'vw_BekleyenSatinAlmaOnaylari view olusturuldu.'

-- =============================================
-- 7. tbOtomatikSiparis icin eksik kolonlari ekle
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'dteKayit')
BEGIN
    ALTER TABLE tbOtomatikSiparis ADD dteKayit DATETIME DEFAULT GETDATE()
    PRINT 'tbOtomatikSiparis tablosuna dteKayit kolonu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbOtomatikSiparis') AND name = 'nTalepEdenID')
BEGIN
    ALTER TABLE tbOtomatikSiparis ADD nTalepEdenID INT
    PRINT 'tbOtomatikSiparis tablosuna nTalepEdenID kolonu eklendi.'
END
GO

PRINT '';
PRINT '=============================================';
PRINT 'SURE VE FIRE RAPORLAMA SISTEMI TAMAMLANDI';
PRINT '=============================================';
PRINT '';
PRINT 'Kullanim:';
PRINT '- vw_GecikenAsamalar: Geciken asamalari listeler (KIRMIZI)';
PRINT '- vw_AsiriFireliAsamalar: Asiri fireli asamalari listeler (KIRMIZI)';
PRINT '- vw_AsamaSurePerformansi: Tum asamalarin sure performansi';
PRINT '- vw_AsamaFirePerformansi: Tum asamalarin fire performansi';
PRINT '- vw_UretimEmriOzet: Uretim emirlerinin ozeti';
PRINT '- vw_BekleyenSatinAlmaOnaylari: Onay bekleyen satin alma siparisleri';
