-- =====================================================
-- YENİ TABLO YAPISI: tbStokResim
-- =====================================================
-- Her ürün için 11 resim = 11 ayrı satır
-- pResim: Base64 string (LOCAL gösterim için)
-- yol: R2 URL (E-ticaret + Mobile için)
-- =====================================================

-- Eski tabloyu yedekle (opsiyonel)
-- SELECT * INTO tbStokResim_BACKUP FROM tbStokResim

-- Yeni tablo yapısı
CREATE TABLE tbStokResim (
    nStokResimID INT IDENTITY(1,1) PRIMARY KEY,
    sModel VARCHAR(50) NOT NULL,
    nSira INT NOT NULL DEFAULT 1,  -- 1-11 arası resim sırası
    pResim TEXT,  -- Base64 encoded image (LOCAL için, FULL quality)
    yol VARCHAR(500),  -- R2 URL (E-ticaret + Mobile için)
    sAciklama VARCHAR(250),  -- Resim açıklaması
    sKullaniciAdi VARCHAR(50),  -- Kim ekledi
    dteKayitTarihi DATETIME DEFAULT GETDATE(),  -- Ne zaman eklendi
    
    -- Index'ler
    INDEX IX_sModel (sModel),
    INDEX IX_sModel_nSira (sModel, nSira),
    
    -- Constraints
    CHECK (nSira BETWEEN 1 AND 11)
)

-- Örnek kullanım:
-- INSERT INTO tbStokResim (sModel, nSira, pResim, yol) 
-- VALUES ('MODEL123', 1, 'iVBORw0KGgo...', 'https://r2.dev/products/firma/MODEL123/1_600.jpg')

-- Query optimizasyonu için
CREATE INDEX IX_yol ON tbStokResim(yol) WHERE yol IS NOT NULL
