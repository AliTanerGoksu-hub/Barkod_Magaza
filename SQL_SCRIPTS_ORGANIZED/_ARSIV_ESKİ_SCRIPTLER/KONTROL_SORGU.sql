-- ==========================================
-- tbStokFisiMaster KAYIT KONTROL SORGUSU
-- ==========================================

-- 1. Son 50 kayıt (tarihe göre sıralı)
SELECT TOP 50 
    nStokFisiID,
    sFisTipi,
    CONVERT(VARCHAR(10), dteFisTarihi, 120) AS Fis_Tarihi,
    CONVERT(VARCHAR(19), dteKayitTarihi, 120) AS Kayit_Zamani,
    lFisNo,
    nFirmaID,
    lNetTutar,
    sDepo,
    sKullaniciAdi,
    nEvrakNo
FROM tbStokFisiMaster
ORDER BY dteKayitTarihi DESC, nStokFisiID DESC;

-- 2. Bugünün kayıtları
SELECT 
    COUNT(*) AS Bugun_Kayit_Sayisi,
    MIN(nStokFisiID) AS Min_ID,
    MAX(nStokFisiID) AS Max_ID,
    CONVERT(VARCHAR(10), GETDATE(), 120) AS Bugun_Tarihi
FROM tbStokFisiMaster
WHERE CONVERT(DATE, dteKayitTarihi) = CONVERT(DATE, GETDATE());

-- 3. Son 10 güne ait kayıt dağılımı
SELECT 
    CONVERT(VARCHAR(10), dteFisTarihi, 120) AS Fis_Tarihi,
    COUNT(*) AS Kayit_Sayisi
FROM tbStokFisiMaster
WHERE dteFisTarihi >= DATEADD(DAY, -10, GETDATE())
GROUP BY CONVERT(VARCHAR(10), dteFisTarihi, 120)
ORDER BY Fis_Tarihi DESC;

-- 4. nStokFisiID = 306 ile 350 arası (log'daki ID'ler)
SELECT 
    nStokFisiID,
    sFisTipi,
    CONVERT(VARCHAR(10), dteFisTarihi, 120) AS Fis_Tarihi,
    CONVERT(VARCHAR(19), dteKayitTarihi, 120) AS Kayit_Zamani,
    lFisNo,
    nFirmaID,
    lNetTutar,
    nEvrakNo
FROM tbStokFisiMaster
WHERE nStokFisiID BETWEEN 306 AND 350
ORDER BY nStokFisiID DESC;

-- 5. Detay kayıtları (son 20)
SELECT TOP 20
    d.nStokFisiID,
    m.lFisNo,
    CONVERT(VARCHAR(10), m.dteFisTarihi, 120) AS Fis_Tarihi,
    d.nSira,
    d.sBarkod,
    d.sAciklama,
    d.lMiktar,
    d.lBirimFiyat,
    d.lTutar
FROM tbStokFisiDetayi d
INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID
ORDER BY d.nStokFisiID DESC, d.nSira ASC;

-- 6. Fatura listesi sorgusu (örnek - sizin sistem nasıl çekiyorsa)
-- NOT: Bu sorguyu kendi fatura listeleme ekranınıza göre düzenleyin
SELECT 
    m.nStokFisiID,
    m.sFisTipi,
    CONVERT(VARCHAR(10), m.dteFisTarihi, 103) AS Fatura_Tarihi, -- DD/MM/YYYY
    m.lFisNo AS Fis_No,
    m.nEvrakNo AS Evrak_No,
    f.sKodu AS Firma_Kodu,
    f.sAciklama AS Firma_Adi,
    m.lNetTutar,
    m.sDepo,
    CASE 
        WHEN m.bFisTamamlandimi = 1 THEN 'Tamamlandı'
        ELSE 'Açık'
    END AS Durum
FROM tbStokFisiMaster m
LEFT JOIN tbFirma f ON m.nFirmaID = f.nFirmaID
WHERE m.dteFisTarihi >= DATEADD(DAY, -30, GETDATE()) -- Son 30 gün
ORDER BY m.dteFisTarihi DESC, m.lFisNo DESC;
