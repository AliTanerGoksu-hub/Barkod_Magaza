-- =====================================================
-- YENİ TABLO YAPISI: tbStokResim (V2 - RENK DESTEKLİ)
-- =====================================================
-- Her ürün RENK bazında 11 resim = 11 ayrı satır
-- pResim: Base64 string (LOCAL gösterim için)
-- yol: R2 URL (E-ticaret + Mobile için)
-- sRenk: Renk bilgisi (RENK bazlı filtreleme için) **YENİ**
-- =====================================================

-- ADIM 1: Mevcut tabloya RENK kolonu ekle (varsa hatayı görmezden gel)
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokResim') AND name = 'sRenk')
BEGIN
    ALTER TABLE tbStokResim ADD sRenk VARCHAR(50) NULL;
    PRINT 'tbStokResim tablosuna sRenk kolonu eklendi.';
END
ELSE
BEGIN
    PRINT 'sRenk kolonu zaten mevcut.';
END
GO

-- ADIM 2: Mevcut resimlere default renk atama (opsiyonel)
-- Eğer mevcut resimler varsa ve renk bilgisi yoksa, tbStok'tan çek
UPDATE SR
SET SR.sRenk = T.sRenk
FROM tbStokResim SR
INNER JOIN tbStok T ON T.sModel = SR.sModel
WHERE SR.sRenk IS NULL OR SR.sRenk = ''
GO

-- ADIM 3: Index güncelle (Model + Renk kombinasyonu için)
IF EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_sModel_nSira' AND object_id = OBJECT_ID('tbStokResim'))
BEGIN
    DROP INDEX IX_sModel_nSira ON tbStokResim;
    PRINT 'Eski index silindi.';
END
GO

CREATE INDEX IX_sModel_sRenk_nSira ON tbStokResim(sModel, sRenk, nSira);
PRINT 'Yeni index (Model + Renk + Sira) oluşturuldu.';
GO

-- =====================================================
-- YENİ TABLO YARATMA (İlk kurulum için)
-- =====================================================
/*
CREATE TABLE tbStokResim (
    nStokResimID INT IDENTITY(1,1) PRIMARY KEY,
    sModel VARCHAR(50) NOT NULL,
    sRenk VARCHAR(50) NULL,  -- **YENİ KOLON**
    nSira INT NOT NULL DEFAULT 1,  -- 1-11 arası resim sırası
    pResim TEXT,  -- Base64 encoded image (LOCAL için, FULL quality)
    yol VARCHAR(500),  -- R2 URL (E-ticaret + Mobile için)
    sAciklama VARCHAR(250),  -- Resim açıklaması
    sKullaniciAdi VARCHAR(50),  -- Kim ekledi
    dteKayitTarihi DATETIME DEFAULT GETDATE(),  -- Ne zaman eklendi
    
    -- Index'ler
    INDEX IX_sModel (sModel),
    INDEX IX_sModel_sRenk_nSira (sModel, sRenk, nSira),
    
    -- Constraints
    CHECK (nSira BETWEEN 1 AND 11)
)
GO

-- Query optimizasyonu için
CREATE INDEX IX_yol ON tbStokResim(yol) WHERE yol IS NOT NULL
GO
*/

-- Örnek kullanım:
-- INSERT INTO tbStokResim (sModel, sRenk, nSira, pResim, yol) 
-- VALUES ('TS-FP02100', 'SIYAH', 1, 'iVBORw0KGgo...', 'https://r2.dev/products/firma/TS-FP02100_SIYAH/1_600.jpg')

PRINT 'tbStokResim tablosu RENK desteği ile güncellendi! ✓';
GO
