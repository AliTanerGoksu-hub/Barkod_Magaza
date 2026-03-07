-- ============================================================================
-- AI TOKEN KULLANIM TABLOSU
-- ============================================================================
-- Bu tabloyu veritabanınızda oluşturun
-- ============================================================================

-- Token kullanım tablosu
CREATE TABLE tbAITokenKullanim (
    nID INT IDENTITY(1,1) PRIMARY KEY,
    sModel NVARCHAR(50),                    -- Kullanılan model (gpt-4o-mini, gpt-4o, vb.)
    nPromptTokens INT DEFAULT 0,            -- Gönderilen token sayısı
    nCompletionTokens INT DEFAULT 0,        -- Alınan cevap token sayısı
    nTotalTokens INT DEFAULT 0,             -- Toplam token
    nMaliyetUSD DECIMAL(18,6) DEFAULT 0,    -- USD maliyet
    nMusteriID INT NULL,                    -- İşlemi yapan müşteri (varsa)
    nStokID INT NULL,                       -- İşlenen ürün (varsa)
    sIslemTipi NVARCHAR(50) NULL,           -- İşlem tipi (Baslik, Aciklama, vb.)
    dteTarih DATETIME DEFAULT GETDATE()    -- İşlem tarihi
);
GO

-- Index'ler
CREATE INDEX IX_AITokenKullanim_Tarih ON tbAITokenKullanim(dteTarih);
GO

CREATE INDEX IX_AITokenKullanim_Musteri ON tbAITokenKullanim(nMusteriID);
GO

-- Günlük özet view'ı
CREATE VIEW vw_AIGunlukOzet AS
SELECT 
    CONVERT(DATE, dteTarih) AS Tarih,
    COUNT(*) AS SorguSayisi,
    SUM(nPromptTokens) AS ToplamPromptToken,
    SUM(nCompletionTokens) AS ToplamCompletionToken,
    SUM(nTotalTokens) AS ToplamToken,
    SUM(nMaliyetUSD) AS ToplamMaliyetUSD,
    SUM(nMaliyetUSD) * 35 AS ToplamMaliyetTL  -- 1 USD = 35 TL varsayımı
FROM tbAITokenKullanim
GROUP BY CONVERT(DATE, dteTarih);
GO

-- Aylık özet view'ı
CREATE VIEW vw_AIAylikOzet AS
SELECT 
    YEAR(dteTarih) AS Yil,
    MONTH(dteTarih) AS Ay,
    COUNT(*) AS SorguSayisi,
    SUM(nTotalTokens) AS ToplamToken,
    SUM(nMaliyetUSD) AS ToplamMaliyetUSD,
    SUM(nMaliyetUSD) * 35 AS ToplamMaliyetTL
FROM tbAITokenKullanim
GROUP BY YEAR(dteTarih), MONTH(dteTarih);
GO

-- Model bazlı özet
CREATE VIEW vw_AIModelOzet AS
SELECT 
    sModel AS Model,
    COUNT(*) AS SorguSayisi,
    SUM(nTotalTokens) AS ToplamToken,
    AVG(nTotalTokens) AS OrtalamaToken,
    SUM(nMaliyetUSD) AS ToplamMaliyetUSD
FROM tbAITokenKullanim
GROUP BY sModel;
GO
