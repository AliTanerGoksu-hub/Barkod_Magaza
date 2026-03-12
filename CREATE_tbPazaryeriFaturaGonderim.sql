-- =====================================================
-- Pazaryeri Fatura Gönderim Tablosu
-- GİB'e gönderilen faturaların pazaryerlerine gönderim durumunu takip eder
-- =====================================================

-- Tablo var mı kontrol et, yoksa oluştur
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbPazaryeriFaturaGonderim' AND xtype='U')
BEGIN
    CREATE TABLE tbPazaryeriFaturaGonderim (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nStokFisiID INT NOT NULL,                    -- Fatura ID (tbStokFisiMaster.nStokFisiID)
        sPazaryeri NVARCHAR(50),                     -- Trendyol, Hepsiburada, N11
        sSiparisNo NVARCHAR(50),                     -- TY11035907594, HB12345678
        sFaturaNo NVARCHAR(50),                      -- GİB Fatura Numarası
        sFaturaUUID NVARCHAR(100),                   -- e-Fatura UUID
        bGonderildi BIT DEFAULT 0,                   -- Pazaryerine gönderildi mi?
        dteGonderimTarihi DATETIME,                  -- Ne zaman gönderildi?
        sGonderimSonucu NVARCHAR(500),               -- API yanıtı
        sHataMesaji NVARCHAR(500),                   -- Hata varsa
        nDenemeAdet INT DEFAULT 0,                   -- Kaç kez denendi?
        dteOlusturma DATETIME DEFAULT GETDATE(),
        
        -- İndeksler
        INDEX IX_PazaryeriFatura_StokFisiID (nStokFisiID),
        INDEX IX_PazaryeriFatura_Pazaryeri (sPazaryeri),
        INDEX IX_PazaryeriFatura_SiparisNo (sSiparisNo),
        INDEX IX_PazaryeriFatura_Gonderildi (bGonderildi)
    )
    
    PRINT 'tbPazaryeriFaturaGonderim tablosu oluşturuldu.'
END
ELSE
BEGIN
    PRINT 'tbPazaryeriFaturaGonderim tablosu zaten mevcut.'
END
GO

-- =====================================================
-- tbParamGenel tablosuna yeni parametre ekle (varsa)
-- =====================================================
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id = OBJECT_ID('tbParamGenel') AND name = 'PazaryeriFaturaOtoGonder')
BEGIN
    ALTER TABLE tbParamGenel ADD PazaryeriFaturaOtoGonder BIT DEFAULT 0
    PRINT 'PazaryeriFaturaOtoGonder parametresi eklendi.'
END
GO

-- =====================================================
-- Örnek Kullanım Sorgusu
-- GİB'e gönderilmiş ama pazaryerine gönderilmemiş faturalar
-- =====================================================
/*
SELECT 
    M.nStokFisiID,
    M.dteFisTarihi,
    M.lFisNo,
    M.GibFaturaNo,
    M.sFaturaGuid,
    M.sFaturaTipi,
    M.neFaturaDurum,
    M.lNetTutar,
    A.sAciklama3 AS SiparisNo,
    CASE 
        WHEN A.sAciklama3 LIKE 'TY%' THEN 'Trendyol'
        WHEN A.sAciklama3 LIKE 'HB%' THEN 'Hepsiburada'
        WHEN A.sAciklama3 LIKE 'N11%' THEN 'N11'
        ELSE 'Bilinmiyor'
    END AS Pazaryeri
FROM tbStokFisiMaster M
INNER JOIN tbStokFisiAciklamasi A ON M.nStokFisiID = A.nStokFisiID
LEFT JOIN tbPazaryeriFaturaGonderim P ON M.nStokFisiID = P.nStokFisiID
WHERE M.GibFaturaNo IS NOT NULL AND M.GibFaturaNo <> ''
AND (A.sAciklama3 LIKE 'TY%' OR A.sAciklama3 LIKE 'HB%' OR A.sAciklama3 LIKE 'N11%')
AND ISNULL(P.bGonderildi, 0) = 0
ORDER BY M.dteFisTarihi DESC
*/
