-- E-Ticaret Analiz Cache Tablolari
-- Bu tablolar PazaryeriAPIHelper.EnsureETicaretAnalizTable() fonksiyonu tarafindan otomatik olusturulur
-- Manuel olusturmak icin asagidaki script'i calistirabilirsiniz

-- Ana Analiz Cache Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbETicaretAnaliz')
BEGIN
    CREATE TABLE tbETicaretAnaliz (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT,
        sBarkod NVARCHAR(50) NOT NULL,
        sStokKodu NVARCHAR(50),
        sModel NVARCHAR(100),
        sUrunAdi NVARCHAR(500),
        sRenk NVARCHAR(50),
        sBeden NVARCHAR(50),
        sKategori NVARCHAR(200),
        sPazaryeri NVARCHAR(50) DEFAULT 'Trendyol',
        
        -- Fiyat Bilgileri
        dBizimFiyat DECIMAL(18,2) DEFAULT 0,
        dEnDusukRakipFiyat DECIMAL(18,2) DEFAULT 0,
        dOrtalamaRakipFiyat DECIMAL(18,2) DEFAULT 0,
        iRakipSayisi INT DEFAULT 0,
        dFiyatFarki DECIMAL(18,2) DEFAULT 0,
        fFiyatFarkYuzde DECIMAL(5,2) DEFAULT 0,
        
        -- Satis Verileri
        iSatis7Gun INT DEFAULT 0,
        iSatis30Gun INT DEFAULT 0,
        iSatis90Gun INT DEFAULT 0,
        dSatisTutari30Gun DECIMAL(18,2) DEFAULT 0,
        
        -- Iade Verileri
        iIadeSayisi INT DEFAULT 0,
        iIptalSayisi INT DEFAULT 0,
        iTeslimEdilemedi INT DEFAULT 0,
        iToplamIade INT DEFAULT 0,
        fIadeOrani DECIMAL(5,2) DEFAULT 0,
        
        -- Yorum/Puan Verileri
        iYorumSayisi INT DEFAULT 0,
        fOrtalamaPuan DECIMAL(3,1) DEFAULT 0,
        iPozitifYorum INT DEFAULT 0,
        iNegatifYorum INT DEFAULT 0,
        iNotrYorum INT DEFAULT 0,
        sSikSikayet NVARCHAR(200),
        sSikOvergu NVARCHAR(200),
        
        -- Favori/Sepet Verileri (Tahmini)
        iGoruntulenmeSayisi INT DEFAULT 0,
        iFavoriSayisi INT DEFAULT 0,
        iSepetSayisi INT DEFAULT 0,
        fFavoriOrani DECIMAL(5,2) DEFAULT 0,
        fSepetOrani DECIMAL(5,2) DEFAULT 0,
        fDonusumOrani DECIMAL(5,2) DEFAULT 0,
        
        -- Stok Bilgileri
        iStokMiktari INT DEFAULT 0,
        bStokVar BIT DEFAULT 1,
        
        -- Meta Bilgiler
        sContentId NVARCHAR(50),
        dteSonGuncelleme DATETIME DEFAULT GETDATE(),
        
        INDEX IX_ETicaretAnaliz_Barkod (sBarkod),
        INDEX IX_ETicaretAnaliz_StokID (nStokID),
        INDEX IX_ETicaretAnaliz_Pazaryeri (sPazaryeri),
        INDEX IX_ETicaretAnaliz_Guncelleme (dteSonGuncelleme)
    )
    PRINT 'tbETicaretAnaliz tablosu olusturuldu'
END
ELSE
BEGIN
    PRINT 'tbETicaretAnaliz tablosu zaten mevcut'
END
GO

-- Rakip Detay Tablosu (her urun icin birden fazla rakip olabilir)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbETicaretRakipDetay')
BEGIN
    CREATE TABLE tbETicaretRakipDetay (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sBarkod NVARCHAR(50) NOT NULL,
        sRakipMagaza NVARCHAR(200),
        sMagazaId NVARCHAR(50),
        dFiyat DECIMAL(18,2) DEFAULT 0,
        dIndirimiFiyat DECIMAL(18,2) DEFAULT 0,
        dKargoUcreti DECIMAL(18,2) DEFAULT 0,
        fPuan DECIMAL(3,1) DEFAULT 0,
        iYorumSayisi INT DEFAULT 0,
        bStokVar BIT DEFAULT 1,
        bAnaSatici BIT DEFAULT 0,
        dteSonGuncelleme DATETIME DEFAULT GETDATE(),
        INDEX IX_RakipDetay_Barkod (sBarkod)
    )
    PRINT 'tbETicaretRakipDetay tablosu olusturuldu'
END
ELSE
BEGIN
    PRINT 'tbETicaretRakipDetay tablosu zaten mevcut'
END
GO

-- Cache temizleme (7 gunluk eski kayitlar)
-- DELETE FROM tbETicaretAnaliz WHERE DATEDIFF(day, dteSonGuncelleme, GETDATE()) > 7
-- DELETE FROM tbETicaretRakipDetay WHERE DATEDIFF(day, dteSonGuncelleme, GETDATE()) > 7
