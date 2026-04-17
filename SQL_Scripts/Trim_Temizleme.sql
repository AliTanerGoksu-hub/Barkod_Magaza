-- ================================================
-- BARKOD MAGAZA - BOSLUK TEMIZLEME SCRIPTI v2
-- char tipindeki kolonlar varchar'a cevrilerek trailing space temizlenir
-- Tarih: 2026-04-17
-- ================================================

-- NOT: SQL Server'da char(10) tipi her zaman 10 karakter dondurur.
-- RTRIM ile UPDATE yapilsa bile char(10) tekrar 10 karakter yapar.
-- Cozum: Kolon tiplerini varchar'a cevirmek.
-- Eger kolon tipi degistirilemiyorsa, uygulama tarafinda Trim yapilmali (zaten yapildi).

BEGIN TRANSACTION

-- ================================================
-- 1. tbRenk TEMIZLEME - Kolon tiplerini degistir
-- ================================================
PRINT '>>> tbRenk kolon tipleri degistiriliyor...'

-- Oncelik: PK constraint'i kontrol et
-- sRenk char(10) NOT NULL -> varchar(10) NOT NULL
-- lRenkNo varchar(5) NOT NULL (zaten varchar)

-- sRenk PK oldugu icin direkt ALTER edilemez
-- Gecici tablo ile coz:
-- Adim 1: Constraint'leri kontrol et
PRINT '   tbRenk.sRenk char(10) -> UPDATE ile RTRIM'

-- char tipinde UPDATE RTRIM ise yaramaz ama iliskili tablolarda varchar ise ise yarar
-- tbStok.sRenk char(10) ise ayni sorun var
-- En guvenli yol: Tum tablolardaki verileri RTRIM ile guncelle + uygulama Trim yapiyor

-- tbRenk verilerini temizle (sRenkAdi ve lRenkNo varchar ise calisiror)
UPDATE tbRenk SET 
    sRenkAdi = RTRIM(LTRIM(sRenkAdi)),
    lRenkNo = RTRIM(LTRIM(lRenkNo))
WHERE DATALENGTH(sRenkAdi) > LEN(RTRIM(LTRIM(sRenkAdi)))
   OR DATALENGTH(lRenkNo) > LEN(RTRIM(LTRIM(lRenkNo)))

PRINT '   tbRenk varchar alanlar temizlendi: ' + CAST(@@ROWCOUNT AS VARCHAR)

-- ================================================
-- 2. tbStok TEMIZLEME
-- ================================================
PRINT '>>> tbStok temizleniyor...'

-- sKodu muhtemelen char/varchar karisik
-- sBeden muhtemelen char(50)
-- Oncelikle varchar olan alanlari temizle
UPDATE tbStok SET 
    sKodu = RTRIM(LTRIM(sKodu)),
    sRenk = RTRIM(LTRIM(sRenk)),
    sBeden = RTRIM(LTRIM(sBeden)),
    sKavala = RTRIM(LTRIM(sKavala)),
    sModel = RTRIM(LTRIM(sModel))

PRINT '   tbStok guncellendi: ' + CAST(@@ROWCOUNT AS VARCHAR)

-- ================================================
-- 3. tbBedenTipi TEMIZLEME (sBeden1 - sBeden15)
-- ================================================
PRINT '>>> tbBedenTipi temizleniyor...'

UPDATE tbBedenTipi SET 
    sBeden1 = RTRIM(LTRIM(sBeden1)),
    sBeden2 = RTRIM(LTRIM(sBeden2)),
    sBeden3 = RTRIM(LTRIM(sBeden3)),
    sBeden4 = RTRIM(LTRIM(sBeden4)),
    sBeden5 = RTRIM(LTRIM(sBeden5)),
    sBeden6 = RTRIM(LTRIM(sBeden6)),
    sBeden7 = RTRIM(LTRIM(sBeden7)),
    sBeden8 = RTRIM(LTRIM(sBeden8)),
    sBeden9 = RTRIM(LTRIM(sBeden9)),
    sBeden10 = RTRIM(LTRIM(sBeden10)),
    sBeden11 = RTRIM(LTRIM(sBeden11)),
    sBeden12 = RTRIM(LTRIM(sBeden12)),
    sBeden13 = RTRIM(LTRIM(sBeden13)),
    sBeden14 = RTRIM(LTRIM(sBeden14)),
    sBeden15 = RTRIM(LTRIM(sBeden15))

PRINT '   tbBedenTipi guncellendi: ' + CAST(@@ROWCOUNT AS VARCHAR)

-- ================================================
-- 4. CHAR -> VARCHAR TIP DEGISIKLIGI (ONEMLI!)
-- char tipi her zaman padding yapar, varchar yapmaz
-- Bu adim opsiyoneldir - FK constraint'leri nedeniyle
-- dikkatli yapilmalidir
-- ================================================
PRINT ''
PRINT '>>> CHAR -> VARCHAR kolon tipi degisikligi...'

-- tbStok.sRenk char(10) -> varchar(10)
-- ONCE FK constraint varsa kaldirmak gerekir
-- Bu otomatik yapilamaz, manual kontrol edilmeli

-- Asagidaki ALTER komutlarini FK yoksa calistirin:
-- Yoksa oncelikle uygulamadaki Trim yeterlidir

-- tbStok
PRINT '   tbStok.sRenk...'
BEGIN TRY
    ALTER TABLE tbStok ALTER COLUMN sRenk VARCHAR(10) NOT NULL
    PRINT '      sRenk -> varchar(10) OK'
END TRY
BEGIN CATCH
    PRINT '      sRenk degistirilemedi (FK constraint olabilir): ' + ERROR_MESSAGE()
END CATCH

PRINT '   tbStok.sBeden...'
BEGIN TRY
    ALTER TABLE tbStok ALTER COLUMN sBeden VARCHAR(50) NOT NULL
    PRINT '      sBeden -> varchar(50) OK'
END TRY
BEGIN CATCH
    PRINT '      sBeden degistirilemedi: ' + ERROR_MESSAGE()
END CATCH

PRINT '   tbStok.sKavala...'
BEGIN TRY
    ALTER TABLE tbStok ALTER COLUMN sKavala VARCHAR(10) NOT NULL
    PRINT '      sKavala -> varchar(10) OK'
END TRY
BEGIN CATCH
    PRINT '      sKavala degistirilemedi: ' + ERROR_MESSAGE()
END CATCH

-- tbRenk.sRenk (PK - dikkatli!)
PRINT '   tbRenk.sRenk (PK)...'
BEGIN TRY
    -- PK'yi kaldir, tipi degistir, PK'yi tekrar ekle
    ALTER TABLE tbStok DROP CONSTRAINT IF EXISTS FK_tbStok_tbRenk
    ALTER TABLE tbRenk DROP CONSTRAINT [PK__tbRenk__22401542]
    ALTER TABLE tbRenk ALTER COLUMN sRenk VARCHAR(10) NOT NULL
    ALTER TABLE tbRenk ADD CONSTRAINT PK_tbRenk PRIMARY KEY (sRenk)
    PRINT '      sRenk -> varchar(10) OK'
END TRY
BEGIN CATCH
    PRINT '      sRenk degistirilemedi (PK/FK): ' + ERROR_MESSAGE()
END CATCH

-- tbBedenTipi bedenleri
PRINT '   tbBedenTipi bedenleri...'
BEGIN TRY
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden1 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden2 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden3 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden4 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden5 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden6 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden7 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden8 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden9 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden10 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden11 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden12 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden13 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden14 VARCHAR(50) NOT NULL
    ALTER TABLE tbBedenTipi ALTER COLUMN sBeden15 VARCHAR(50) NOT NULL
    PRINT '      sBeden1-15 -> varchar(50) OK'
END TRY
BEGIN CATCH
    PRINT '      tbBedenTipi degistirilemedi: ' + ERROR_MESSAGE()
END CATCH

-- ================================================
-- 5. TEKRAR RTRIM (tip degisikliginden sonra)
-- ================================================
PRINT ''
PRINT '>>> Tip degisikligi sonrasi tekrar RTRIM...'

UPDATE tbStok SET 
    sRenk = RTRIM(LTRIM(sRenk)),
    sBeden = RTRIM(LTRIM(sBeden)),
    sKavala = RTRIM(LTRIM(sKavala))

PRINT '   tbStok: ' + CAST(@@ROWCOUNT AS VARCHAR)

UPDATE tbRenk SET sRenk = RTRIM(LTRIM(sRenk))
PRINT '   tbRenk: ' + CAST(@@ROWCOUNT AS VARCHAR)

UPDATE tbBedenTipi SET 
    sBeden1 = RTRIM(LTRIM(sBeden1)),
    sBeden2 = RTRIM(LTRIM(sBeden2)),
    sBeden3 = RTRIM(LTRIM(sBeden3)),
    sBeden4 = RTRIM(LTRIM(sBeden4)),
    sBeden5 = RTRIM(LTRIM(sBeden5)),
    sBeden6 = RTRIM(LTRIM(sBeden6)),
    sBeden7 = RTRIM(LTRIM(sBeden7)),
    sBeden8 = RTRIM(LTRIM(sBeden8)),
    sBeden9 = RTRIM(LTRIM(sBeden9)),
    sBeden10 = RTRIM(LTRIM(sBeden10)),
    sBeden11 = RTRIM(LTRIM(sBeden11)),
    sBeden12 = RTRIM(LTRIM(sBeden12)),
    sBeden13 = RTRIM(LTRIM(sBeden13)),
    sBeden14 = RTRIM(LTRIM(sBeden14)),
    sBeden15 = RTRIM(LTRIM(sBeden15))

PRINT '   tbBedenTipi: ' + CAST(@@ROWCOUNT AS VARCHAR)

-- ================================================
-- SONUC KONTROL
-- ================================================
PRINT ''
PRINT '>>> SONUC KONTROL:'

SELECT 'tbStok.sRenk' AS Alan, 
       COUNT(*) AS ToplamKayit,
       SUM(CASE WHEN DATALENGTH(sRenk) > LEN(RTRIM(sRenk)) * 2 THEN 1 ELSE 0 END) AS BoslukluKayit
FROM tbStok
UNION ALL
SELECT 'tbStok.sBeden',
       COUNT(*),
       SUM(CASE WHEN DATALENGTH(sBeden) > LEN(RTRIM(sBeden)) * 2 THEN 1 ELSE 0 END)
FROM tbStok
UNION ALL
SELECT 'tbRenk.sRenk',
       COUNT(*),
       SUM(CASE WHEN DATALENGTH(sRenk) > LEN(RTRIM(sRenk)) * 2 THEN 1 ELSE 0 END)
FROM tbRenk

-- COMMIT veya ROLLBACK
-- COMMIT TRANSACTION
-- ROLLBACK TRANSACTION

PRINT ''
PRINT '>>> ISLEM TAMAMLANDI'
PRINT '>>> COMMIT TRANSACTION veya ROLLBACK TRANSACTION calistirin'
