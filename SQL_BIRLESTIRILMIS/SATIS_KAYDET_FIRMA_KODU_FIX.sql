-- ================================================================
-- SATIS_KAYDET - FİRMA KODU ARTIRMA DÜZELTMESİ
-- ================================================================
-- SORUN 1: Firma kodu 120.01.99.1000'de kalıyor, artmıyor
--          MAX() fonksiyonu string karşılaştırma yapıyor
--          '999' > '1000' olarak değerlendiriliyor (string comparison)
--
-- SORUN 2: sKodu sonuna boşluk ekleniyor
--          char(20) tipi otomatik boşluk dolduruyor
--
-- ÇÖZÜM: Sayısal kısmı BIGINT olarak karşılaştır, VARCHAR kullan
-- ================================================================
-- TARİH: 2025-12
-- ================================================================

-- ==========================================
-- MEVCUT HATALI KOD:
-- ==========================================
/*
    SET @sKodu = (SELECT ISNULL(MAX(LTRIM(RTRIM(sKodu))), '120.01.99.0') FROM tbFirma WHERE sKodu LIKE '120.01.99.%');
    DECLARE @prefix NVARCHAR(20) = LEFT(@sKodu, LEN(@sKodu) - LEN(PARSENAME(@sKodu, 1)));
    DECLARE @number BIGINT = ISNULL(TRY_CAST(PARSENAME(@sKodu, 1) AS BIGINT), 0) + 1;
    SET @sKodu = @prefix + FORMAT(@number, '000');
*/

-- ==========================================
-- DÜZELTİLMİŞ KOD (BU KISMI KULLANIN):
-- ==========================================

-- Önce DECLARE kısmında sKodu tipini değiştirin:
-- ESKİ: DECLARE @sKodu char(20)
-- YENİ: DECLARE @sKodu varchar(20)

-- Sonra firma kodu oluşturma kısmını şöyle değiştirin:

/*
-- Yeni firma kodu oluştur - SAYISAL SIRALAMA İLE
DECLARE @maxNumber BIGINT = 0;

-- En büyük sayısal numarayı bul (string karşılaştırma yerine sayısal)
SELECT @maxNumber = ISNULL(MAX(
    TRY_CAST(
        PARSENAME(LTRIM(RTRIM(sKodu)), 1) 
    AS BIGINT)
), 0)
FROM tbFirma 
WHERE sKodu LIKE '120.01.99.%'
  AND TRY_CAST(PARSENAME(LTRIM(RTRIM(sKodu)), 1) AS BIGINT) IS NOT NULL;

-- Yeni numara = max + 1
DECLARE @newNumber BIGINT = @maxNumber + 1;

-- Yeni kodu oluştur (boşluksuz)
SET @sKodu = '120.01.99.' + CAST(@newNumber AS VARCHAR(10));
*/

-- ==========================================
-- TAM BLOK DEĞİŞİKLİĞİ:
-- ==========================================
-- Aşağıdaki kodu "IF @FirmaBulundu = 0" bloğunun içinde,
-- "Yeni firma kodu oluştur" yorumundan sonra kullanın:

/*
IF @FirmaBulundu = 0
BEGIN
    -- Yeni firma kodu oluştur - SAYISAL SIRALAMA İLE (DÜZELTİLMİŞ)
    DECLARE @maxNumber BIGINT = 0;
    
    -- En büyük sayısal numarayı bul
    SELECT @maxNumber = ISNULL(MAX(
        TRY_CAST(PARSENAME(LTRIM(RTRIM(sKodu)), 1) AS BIGINT)
    ), 0)
    FROM tbFirma 
    WHERE LTRIM(RTRIM(sKodu)) LIKE '120.01.99.%'
      AND TRY_CAST(PARSENAME(LTRIM(RTRIM(sKodu)), 1) AS BIGINT) IS NOT NULL;
    
    -- Yeni numara
    DECLARE @newNumber BIGINT = @maxNumber + 1;
    
    -- Yeni kod (boşluksuz - VARCHAR olarak)
    SET @sKodu = '120.01.99.' + CAST(@newNumber AS VARCHAR(10));

    -- Hesap planı yoksa ekle
    -- ... (geri kalan kod aynı)
*/

-- ==========================================
-- AÇIKLAMA:
-- ==========================================
-- 1. MAX() yerine TRY_CAST ile sayısal karşılaştırma yapılıyor
-- 2. '120.01.99.999' ve '120.01.99.1000' arasında 1000 büyük çıkıyor
-- 3. CAST(@newNumber AS VARCHAR(10)) ile boşluksuz string oluşturuluyor
-- 4. char(20) yerine varchar(20) kullanılmalı

-- ==========================================
-- TEST SORGUSU (Mevcut en büyük numarayı görmek için):
-- ==========================================
/*
SELECT TOP 10 
    sKodu,
    LTRIM(RTRIM(sKodu)) as TrimmedKodu,
    PARSENAME(LTRIM(RTRIM(sKodu)), 1) as SonKisim,
    TRY_CAST(PARSENAME(LTRIM(RTRIM(sKodu)), 1) AS BIGINT) as SayisalDeger
FROM tbFirma 
WHERE LTRIM(RTRIM(sKodu)) LIKE '120.01.99.%'
ORDER BY TRY_CAST(PARSENAME(LTRIM(RTRIM(sKodu)), 1) AS BIGINT) DESC;
*/
