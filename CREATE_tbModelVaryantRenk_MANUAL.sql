-- ============================================================================
-- MANUEL TABLO OLUŞTURMA: tbModelVaryantRenk
-- Bu SQL'i SQL Server Management Studio veya Visual Studio'da çalıştırın
-- ============================================================================

USE [YourDatabaseName]  -- Kendi database adınızı yazın!
GO

-- Tablo varsa sil (opsiyonel - sadece yeniden oluşturmak için)
-- DROP TABLE IF EXISTS tbModelVaryantRenk
-- GO

-- Tablo oluştur
CREATE TABLE tbModelVaryantRenk (
    nID INT PRIMARY KEY IDENTITY(1,1),
    sModel VARCHAR(50) NOT NULL,
    lRenkNo VARCHAR(10) NOT NULL,
    sRenkAdi VARCHAR(100) NOT NULL,
    sRenkKodu VARCHAR(20) NOT NULL,
    dteEklenmeTarihi DATETIME DEFAULT GETDATE(),
    sEkleyenKullanici VARCHAR(50),
    CONSTRAINT UQ_ModelVaryant UNIQUE (sModel, lRenkNo)
)
GO

-- İndeksler oluştur
CREATE INDEX IX_ModelVaryantRenk_Model ON tbModelVaryantRenk(sModel, lRenkNo)
GO

CREATE INDEX IX_ModelVaryantRenk_RenkKodu ON tbModelVaryantRenk(sRenkKodu)
GO

CREATE INDEX IX_ModelVaryantRenk_RenkAdi ON tbModelVaryantRenk(sRenkAdi)
GO

-- Kontrol
SELECT 'Tablo başarıyla oluşturuldu!' AS Mesaj
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbModelVaryantRenk'
GO
