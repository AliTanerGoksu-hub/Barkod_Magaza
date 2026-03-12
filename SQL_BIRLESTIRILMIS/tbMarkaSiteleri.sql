-- =====================================================
-- tbMarkaSiteleri - Marka Site Eşleştirme Tablosu
-- Tarih: 2026-01-03
-- Açıklama: AI içerik oluşturmada marka sitelerini önbelleğe alır
--           Google aramada öncelikli site olarak kullanılır
--           Markalar parametrik sınıf eşlemesinden dinamik olarak alınır
-- =====================================================

-- Tablo oluştur
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbMarkaSiteleri' AND xtype='U')
BEGIN
    CREATE TABLE tbMarkaSiteleri (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sMarka NVARCHAR(100) NOT NULL,           -- Marka adı (ZWILLING, KARACA, vb.)
        sSiteDomain NVARCHAR(200) NOT NULL,       -- Site domain (zwilling.com.tr)
        sSiteUrl NVARCHAR(500) NULL,              -- Tam URL (https://www.zwilling.com.tr)
        nKullanimSayisi INT DEFAULT 1,            -- Kaç kez kullanıldı
        nBasariliSonuc INT DEFAULT 0,             -- Kaç kez başarılı sonuç verdi
        dEklenmeTarihi DATETIME DEFAULT GETDATE(),
        dSonKullanim DATETIME DEFAULT GETDATE(),
        bAktif BIT DEFAULT 1                      -- Aktif/Pasif
    )
    
    CREATE INDEX IX_tbMarkaSiteleri_Marka ON tbMarkaSiteleri(sMarka)
    CREATE INDEX IX_tbMarkaSiteleri_Domain ON tbMarkaSiteleri(sSiteDomain)
    
    PRINT 'tbMarkaSiteleri tablosu oluşturuldu.'
END
GO

-- =====================================================
-- NOT: Markalar otomatik olarak eklenir!
-- 
-- AIService.GetProductInfoFromWeb() fonksiyonu:
-- 1. Parametrik sınıf eşlemesinden marka alanını bulur (ETICARET_SINIF_MARKA)
-- 2. tbSSinifX tablosundan firmanın markalarını kontrol eder
-- 3. Google'da arama yapar
-- 4. Başarılı sonuç bulursa siteyi bu tabloya kaydeder
-- 5. Sonraki aramalarda öncelikli olarak bu siteyi kullanır
--
-- Örnek akış:
-- 1. ZWILLING markası için arama yapılıyor
-- 2. Firmada ZWILLING tanımlı mı? -> tbSSinif3.sAciklama = 'ZWILLING'
-- 3. Evet -> Google'da ara -> zwilling.com.tr bulundu
-- 4. tbMarkaSiteleri'ne kaydet: ZWILLING -> zwilling.com.tr
-- 5. Sonraki ZWILLING araması: site:zwilling.com.tr ZWILLING ürün adı
-- =====================================================

-- =====================================================
-- YARDIMCI SORGULAR
-- =====================================================

-- Tüm kayıtlı marka sitelerini listele
-- SELECT * FROM tbMarkaSiteleri ORDER BY sMarka

-- En çok kullanılan siteler
-- SELECT sMarka, sSiteDomain, nKullanimSayisi, nBasariliSonuc 
-- FROM tbMarkaSiteleri 
-- ORDER BY nKullanimSayisi DESC

-- Başarı oranına göre sırala
-- SELECT sMarka, sSiteDomain, nKullanimSayisi, nBasariliSonuc,
--        CAST(nBasariliSonuc AS FLOAT) / NULLIF(nKullanimSayisi, 0) * 100 AS BasariOrani
-- FROM tbMarkaSiteleri 
-- WHERE nKullanimSayisi > 0
-- ORDER BY BasariOrani DESC

-- Firmadaki markalarla eşleştir (parametrik sınıf eşlemesine göre)
-- Örnek: Marka sınıfı = sSinifKodu3 ise:
-- SELECT DISTINCT s.sAciklama AS FirmaMarka, m.sSiteDomain
-- FROM tbSSinif3 s
-- LEFT JOIN tbMarkaSiteleri m ON UPPER(s.sAciklama) = UPPER(m.sMarka)
-- ORDER BY s.sAciklama
