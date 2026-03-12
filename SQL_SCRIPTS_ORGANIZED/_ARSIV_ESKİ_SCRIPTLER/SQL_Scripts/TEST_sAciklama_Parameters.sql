-- TEST PROCEDURE - Parametrelerin doğru çalışıp çalışmadığını test eder
-- Eski SQL Server sürümü uyumlu

-- Önce procedure varsa sil
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Test_sAciklama_Parameters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Test_sAciklama_Parameters]
GO

-- Procedure'ü oluştur
CREATE PROCEDURE [dbo].[Test_sAciklama_Parameters]
    @TestsAciklama1 varchar(255) = '',
    @TestsAciklama2 varchar(255) = ''
AS
BEGIN
    -- Test tablosu oluştur (sadece test için)
    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TestAciklamaTablosu]') AND type in (N'U'))
    BEGIN
        CREATE TABLE TestAciklamaTablosu (
            ID int IDENTITY(1,1),
            sAciklama1 varchar(255),
            sAciklama2 varchar(255),
            TestTarihi datetime DEFAULT GETDATE()
        )
    END
    
    -- Parametreleri test tablosuna ekle
    INSERT INTO TestAciklamaTablosu (sAciklama1, sAciklama2)
    VALUES (@TestsAciklama1, @TestsAciklama2)
    
    -- Sonucu göster
    SELECT TOP 1 
        ID,
        sAciklama1,
        sAciklama2,
        TestTarihi,
        CASE 
            WHEN sAciklama1 = '@TestsAciklama1' THEN 'PARAMETRE CALIŞMIYOR!'
            ELSE 'Parametre calisiyor'
        END AS Test1Durumu,
        CASE 
            WHEN sAciklama2 = '@TestsAciklama2' THEN 'PARAMETRE CALIŞMIYOR!'
            ELSE 'Parametre calisiyor'
        END AS Test2Durumu
    FROM TestAciklamaTablosu 
    ORDER BY ID DESC
END
GO

-- TEST ÇALIŞTIRIN:
-- EXEC Test_sAciklama_Parameters @TestsAciklama1 = 'Test Müşteri', @TestsAciklama2 = 'ty(123456)'

-- Temizlik (isteğe bağlı):
-- DROP TABLE TestAciklamaTablosu
-- DROP PROCEDURE Test_sAciklama_Parameters