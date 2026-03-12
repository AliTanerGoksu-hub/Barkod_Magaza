-- ============================================================================
-- YENI TABLO: tbModelVaryantRenk
-- Amaç: Model bazlı varyant ve renk yönetimi
-- Kullanım: Excel import ve Toplu resim yükleme özellikleri için
-- Not: Mevcut tbRenk tablosuna DOKUNMAZ, paralel çalışır
-- ============================================================================

CREATE TABLE tbModelVaryantRenk (
    nID INT PRIMARY KEY IDENTITY(1,1),
    sModel VARCHAR(50) NOT NULL,           -- Model kodu: AR3555-S, AR3571-S
    lRenkNo VARCHAR(10) NOT NULL,          -- Varyant kodu: V1, V2, V3, V4, V5, V6
    sRenkAdi VARCHAR(100) NOT NULL,        -- Renk adı: BEYAZ, SOMON, LACİVERT
    sRenkKodu VARCHAR(20) NOT NULL,        -- Unique renk kodu: AR3555-S-001
    dteEklenmeTarihi DATETIME DEFAULT GETDATE(),
    sEkleyenKullanici VARCHAR(50),
    CONSTRAINT UQ_ModelVaryant UNIQUE (sModel, lRenkNo)  -- Her model için varyant bir kez
)

-- Performans indeksleri
CREATE INDEX IX_ModelVaryantRenk_Model ON tbModelVaryantRenk(sModel, lRenkNo)
CREATE INDEX IX_ModelVaryantRenk_RenkKodu ON tbModelVaryantRenk(sRenkKodu)
CREATE INDEX IX_ModelVaryantRenk_RenkAdi ON tbModelVaryantRenk(sRenkAdi)

-- Örnek veriler (test için)
-- INSERT INTO tbModelVaryantRenk (sModel, lRenkNo, sRenkAdi, sRenkKodu, sEkleyenKullanici)
-- VALUES 
-- ('AR3555-S', 'V1', 'SOMON', 'AR3555-S-001', 'SYSTEM'),
-- ('AR3555-S', 'V2', 'LACİVERT', 'AR3555-S-002', 'SYSTEM'),
-- ('AR3571-S', 'V1', 'AÇIK PEMBE', 'AR3571-S-001', 'SYSTEM'),
-- ('AR3571-S', 'V2', 'SARI', 'AR3571-S-002', 'SYSTEM')
