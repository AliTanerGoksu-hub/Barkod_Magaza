-- ============================================================================
-- nParamID KOLONU EKLEME VE DÜZELTME
-- ============================================================================
-- Bu script tbParamGenel tablosuna nParamID kolonu ekler ve düzenler
-- ============================================================================

USE [BARKOD_MAGAZA] -- Kendi veritabanı adınızı yazın
GO

PRINT '============================================'
PRINT 'tbParamGenel nParamID KONTROLÜ'
PRINT '============================================'
PRINT ''

-- nParamID kolonu var mı kontrol et
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbParamGenel') AND name='nParamID')
BEGIN
    PRINT 'nParamID kolonu bulunamadı, ekleniyor...'
    
    -- Kolon ekle
    ALTER TABLE tbParamGenel 
    ADD nParamID INT NOT NULL DEFAULT 1
    
    PRINT '  ✓ nParamID kolonu eklendi'
    PRINT ''
    
    -- Primary Key varsa kaldır
    IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
               WHERE TABLE_NAME = 'tbParamGenel' AND CONSTRAINT_TYPE = 'PRIMARY KEY')
    BEGIN
        DECLARE @pkName NVARCHAR(128)
        SELECT @pkName = name FROM sys.key_constraints 
        WHERE type = 'PK' AND parent_object_id = OBJECT_ID('tbParamGenel')
        
        EXEC('ALTER TABLE tbParamGenel DROP CONSTRAINT ' + @pkName)
        PRINT '  ✓ Eski Primary Key kaldırıldı'
    END
    
    -- nParamID'yi Primary Key yap
    ALTER TABLE tbParamGenel 
    ADD CONSTRAINT PK_tbParamGenel PRIMARY KEY (nParamID)
    
    PRINT '  ✓ nParamID Primary Key olarak ayarlandı'
    PRINT ''
END
ELSE
BEGIN
    PRINT '✓ nParamID kolonu zaten mevcut'
    
    -- nParamID Primary Key mi kontrol et
    IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
                   WHERE TABLE_NAME = 'tbParamGenel' 
                   AND CONSTRAINT_TYPE = 'PRIMARY KEY'
                   AND CONSTRAINT_NAME LIKE '%nParamID%')
    BEGIN
        PRINT '  ⚠ nParamID Primary Key değil, düzeltiliyor...'
        
        -- Mevcut Primary Key varsa kaldır
        IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
                   WHERE TABLE_NAME = 'tbParamGenel' AND CONSTRAINT_TYPE = 'PRIMARY KEY')
        BEGIN
            DECLARE @pkName2 NVARCHAR(128)
            SELECT @pkName2 = name FROM sys.key_constraints 
            WHERE type = 'PK' AND parent_object_id = OBJECT_ID('tbParamGenel')
            
            EXEC('ALTER TABLE tbParamGenel DROP CONSTRAINT ' + @pkName2)
            PRINT '    ✓ Eski Primary Key kaldırıldı'
        END
        
        -- nParamID'yi Primary Key yap
        ALTER TABLE tbParamGenel 
        ADD CONSTRAINT PK_tbParamGenel PRIMARY KEY (nParamID)
        
        PRINT '    ✓ nParamID Primary Key olarak ayarlandı'
    ELSE
        PRINT '  ✓ nParamID zaten Primary Key'
    END
    PRINT ''
END

-- Kayıt sayısını kontrol et
DECLARE @kayitSayisi INT
SELECT @kayitSayisi = COUNT(*) FROM tbParamGenel

PRINT 'Tablo Durumu:'
PRINT '  - Toplam kayıt: ' + CAST(@kayitSayisi AS VARCHAR(10))

IF @kayitSayisi = 0
BEGIN
    PRINT '  ⚠ UYARI: Hiç kayıt yok!'
    PRINT '  ➜ Şimdi INSERT_DEFAULT_PARAMS.sql çalıştırın'
    PRINT ''
END
ELSE
BEGIN
    -- nParamID = 1 var mı?
    IF EXISTS (SELECT * FROM tbParamGenel WHERE nParamID = 1)
        PRINT '  ✓ nParamID = 1 mevcut'
    ELSE
    BEGIN
        PRINT '  ⚠ nParamID = 1 bulunamadı'
        PRINT '  ➜ INSERT_DEFAULT_PARAMS.sql çalıştırın'
    END
    PRINT ''
END

PRINT '============================================'
PRINT 'İŞLEM TAMAMLANDI'
PRINT '============================================'

GO
