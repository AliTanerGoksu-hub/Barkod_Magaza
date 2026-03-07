-- ============================================================================
-- AI İÇERİK YÖNETİMİ VERİTABANI YAPISI
-- ============================================================================
-- Tüm AI ile oluşturulan içerikler için veritabanı yapısı
-- tbStok tablosu ile nStokID üzerinden ilişkili
-- ============================================================================

-- ============================================================================
-- TABLO 1: tbStokAIIcerik (AI ile Oluşturulan İçerikler)
-- ============================================================================
-- Bu tablo AI ile oluşturulan tüm içerikleri saklar
-- Her ürün (nStokID) için sadece 1 kayıt olur

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbStokAIIcerik' AND xtype='U')
BEGIN
    CREATE TABLE tbStokAIIcerik (
        nAIIcerikID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT NOT NULL,                       -- tbStok ile ilişki
        sModel NVARCHAR(50),                        -- Model (referans)
        sBarkod NVARCHAR(50),                       -- Barkod (referans)
        
        -- ========== SEO VE BAŞLIKLAR ==========
        sSEOBaslik NVARCHAR(255),                   -- AI ile oluşturulan SEO başlığı
        sMetaDescription NVARCHAR(500),             -- Meta açıklama (160 karakter)
        sMetaKeywords NVARCHAR(500),                -- Anahtar kelimeler (virgülle ayrılmış)
        sURLSlug NVARCHAR(255),                     -- URL dostu slug (ornek-urun-adi)
        
        -- ========== AÇIKLAMALAR ==========
        sKisaAciklama NVARCHAR(500),                -- Kısa açıklama (ürün kartı için)
        sDetayliAciklama NVARCHAR(MAX),             -- Detaylı açıklama (HTML formatında)
        sOzellikler NVARCHAR(MAX),                  -- Teknik özellikler (HTML ul/li formatında)
        
        -- ========== KULLANIM TALİMATLARI ==========
        sKullanimTalimati NVARCHAR(MAX),            -- Kullanım talimatları (HTML)
        sYikamaTalimati NVARCHAR(MAX),              -- Yıkama talimatları (Tekstil için)
        sBakimTalimati NVARCHAR(MAX),               -- Bakım talimatları
        sGuvenliklUyari NVARCHAR(MAX),              -- Güvenlik uyarıları
        
        -- ========== KATEGORİ VE ETİKETLER ==========
        sAIKategori NVARCHAR(100),                  -- AI önerisi kategori
        sAIAltKategori NVARCHAR(100),               -- AI önerisi alt kategori
        sEtiketler NVARCHAR(MAX),                   -- Etiketler (JSON array veya CSV)
        sAnahtarKelimeler NVARCHAR(MAX),            -- Arama için anahtar kelimeler
        
        -- ========== FİYATLANDIRMA ==========
        nOneriFiyat DECIMAL(18,2),                  -- AI önerilen fiyat
        nRakipOrtalama DECIMAL(18,2),               -- Rakip ortalama fiyat
        sFiyatStratejisi NVARCHAR(50),              -- Competitive / Premium / Value
        
        -- ========== AI İŞLEM BİLGİLERİ ==========
        sAIModel NVARCHAR(50),                      -- Kullanılan AI modeli (GPT-4o vb.)
        nAIMaliyet DECIMAL(10,4),                   -- AI işlem maliyeti (TL)
        nKullanilanKredi DECIMAL(10,2),             -- Kullanılan müşteri kredisi
        bAIKullanildi BIT DEFAULT 1,                -- AI kullanıldı mı?
        
        -- ========== DURUM VE ONAY ==========
        bOnaylandi BIT DEFAULT 0,                   -- İçerik onaylandı mı?
        sOnaylayanKullanici NVARCHAR(50),           -- Kim onayladı
        dteOnayTarihi DATETIME,                     -- Onay tarihi
        
        bAktif BIT DEFAULT 1,                       -- Aktif mi?
        bWebdeGoster BIT DEFAULT 1,                 -- Web'de göster
        
        -- ========== TARİH BİLGİLERİ ==========
        dteOlusturma DATETIME DEFAULT GETDATE(),    -- İlk oluşturma
        dteGuncelleme DATETIME DEFAULT GETDATE(),   -- Son güncelleme
        sOlusturanKullanici NVARCHAR(50),           -- Kim oluşturdu
        sGuncelleyenKullanici NVARCHAR(50),         -- Kim güncelledi
        
        -- Foreign Key
        FOREIGN KEY (nStokID) REFERENCES tbStok(nStokID) ON DELETE CASCADE
    )
    
    -- Index'ler
    CREATE INDEX IX_nStokID ON tbStokAIIcerik(nStokID)
    CREATE INDEX IX_sModel ON tbStokAIIcerik(sModel)
    CREATE INDEX IX_sBarkod ON tbStokAIIcerik(sBarkod)
    CREATE INDEX IX_bAktif ON tbStokAIIcerik(bAktif)
    CREATE INDEX IX_dteOlusturma ON tbStokAIIcerik(dteOlusturma)
    
    PRINT 'tbStokAIIcerik tablosu oluşturuldu.'
END
ELSE
BEGIN
    PRINT 'tbStokAIIcerik tablosu zaten mevcut.'
END
GO

-- ============================================================================
-- TABLO 2: tbStokResim (Mevcut - Güncelleme)
-- ============================================================================
-- Mevcut tbStokResim tablosuna AI ile bulunan resimler için ek alanlar

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='bAIBulundu')
BEGIN
    ALTER TABLE tbStokResim ADD bAIBulundu BIT DEFAULT 0
    PRINT 'tbStokResim: bAIBulundu alanı eklendi.'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='sAIKaynak')
BEGIN
    ALTER TABLE tbStokResim ADD sAIKaynak NVARCHAR(100)  -- Google / Bing / Manual
    PRINT 'tbStokResim: sAIKaynak alanı eklendi.'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='nAIGuvenSkoru')
BEGIN
    ALTER TABLE tbStokResim ADD nAIGuvenSkoru INT  -- 0-100 arası güven skoru
    PRINT 'tbStokResim: nAIGuvenSkoru alanı eklendi.'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='sOrjinalURL')
BEGIN
    ALTER TABLE tbStokResim ADD sOrjinalURL NVARCHAR(1000)  -- Orjinal resim URL
    PRINT 'tbStokResim: sOrjinalURL alanı eklendi.'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStokResim') AND name='nStokID')
BEGIN
    ALTER TABLE tbStokResim ADD nStokID INT
    PRINT 'tbStokResim: nStokID alanı eklendi.'
    
    -- Foreign Key ekle
    ALTER TABLE tbStokResim ADD CONSTRAINT FK_tbStokResim_tbStok 
        FOREIGN KEY (nStokID) REFERENCES tbStok(nStokID) ON DELETE CASCADE
    
    -- Index ekle
    CREATE INDEX IX_nStokID ON tbStokResim(nStokID)
END
GO

-- ============================================================================
-- TABLO 3: tbStok (Mevcut - Güncelleme)
-- ============================================================================
-- Ana stok tablosuna AI kullanımı için ek alanlar

-- AI içerik durumu
IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStok') AND name='bAIIcerikVar')
BEGIN
    ALTER TABLE tbStok ADD bAIIcerikVar BIT DEFAULT 0
    PRINT 'tbStok: bAIIcerikVar alanı eklendi.'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStok') AND name='dteAISonGuncelleme')
BEGIN
    ALTER TABLE tbStok ADD dteAISonGuncelleme DATETIME
    PRINT 'tbStok: dteAISonGuncelleme alanı eklendi.'
END

IF NOT EXISTS (SELECT * FROM syscolumns WHERE id=OBJECT_ID('tbStok') AND name='nAIKaliteSkor')
BEGIN
    ALTER TABLE tbStok ADD nAIKaliteSkor INT  -- 0-100 arası içerik kalite skoru
    PRINT 'tbStok: nAIKaliteSkor alanı eklendi.'
END
GO

-- ============================================================================
-- TABLO 4: tbMusteriKredi (Kredi Sistemi)
-- ============================================================================

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbMusteriKredi' AND xtype='U')
BEGIN
    CREATE TABLE tbMusteriKredi (
        nKrediID INT IDENTITY(1,1) PRIMARY KEY,
        nMusteriID INT NOT NULL,
        sMusteriAdi NVARCHAR(100),
        
        -- KREDİ BİLGİLERİ
        nToplamKredi DECIMAL(10,2) DEFAULT 0.00,
        nKullanilabilirKredi DECIMAL(10,2) DEFAULT 0.00,
        nKullanilanKredi DECIMAL(10,2) DEFAULT 0.00,
        
        -- AKTİF PAKET
        sAktifPaket NVARCHAR(50),
        dteAktifPaketTarihi DATETIME,
        dtePaketBitisTarihi DATETIME,
        
        -- LİMİTLER
        nGunlukLimit INT DEFAULT 100,
        nGunlukKullanim INT DEFAULT 0,
        dteGunlukResetTarihi DATE DEFAULT CAST(GETDATE() AS DATE),
        
        -- DURUM
        bAktif BIT DEFAULT 1,
        bOtomatikYenile BIT DEFAULT 0,
        
        -- ÖDEME BİLGİLERİ
        sOdemeTuru NVARCHAR(50),
        dteSonOdeme DATETIME,
        nSonOdemeTutar DECIMAL(10,2),
        
        -- BONUS
        nBonusOrani DECIMAL(5,2) DEFAULT 0.00,
        nToplamBonus DECIMAL(10,2) DEFAULT 0.00,
        
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteGuncelleme DATETIME DEFAULT GETDATE(),
        
        FOREIGN KEY (nMusteriID) REFERENCES tbMusteri(nMusteriID)
    )
    
    CREATE INDEX IX_nMusteriID ON tbMusteriKredi(nMusteriID)
    CREATE INDEX IX_bAktif ON tbMusteriKredi(bAktif)
    
    PRINT 'tbMusteriKredi tablosu oluşturuldu.'
END
GO

-- ============================================================================
-- TABLO 5: tbKrediPaketleri (Satılabilir Paketler)
-- ============================================================================

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbKrediPaketleri' AND xtype='U')
BEGIN
    CREATE TABLE tbKrediPaketleri (
        nPaketID INT IDENTITY(1,1) PRIMARY KEY,
        sPaketAdi NVARCHAR(100),
        sPaketAciklama NVARCHAR(500),
        
        -- FİYATLANDIRMA
        nFiyat DECIMAL(10,2),                       -- Satış fiyatı (TL)
        nKrediMiktari DECIMAL(10,2),                -- Verilecek kredi
        nBonusOrani DECIMAL(5,2) DEFAULT 0.00,      -- Bonus %
        nUrunBasinaKredi DECIMAL(10,4),             -- Ürün başına kredi
        
        -- ÖZELLİKLER
        bBaslikOlustur BIT DEFAULT 1,
        bAciklamaOlustur BIT DEFAULT 0,
        bTalimatOlustur BIT DEFAULT 1,
        bGorselBul BIT DEFAULT 0,
        bGorselDogrula BIT DEFAULT 0,
        bKategoriOner BIT DEFAULT 0,
        bFiyatOptimize BIT DEFAULT 0,
        
        -- LİMİTLER
        nGunlukLimit INT,
        nAylikLimit INT,
        
        -- ÖZEL HAKLAR
        bOncelikliDestek BIT DEFAULT 0,
        bOzelPrompt BIT DEFAULT 0,
        bAPIEntegrasyon BIT DEFAULT 0,
        
        -- DURUM
        bAktif BIT DEFAULT 1,
        nSiraNo INT DEFAULT 0,
        
        dteOlusturma DATETIME DEFAULT GETDATE()
    )
    
    CREATE INDEX IX_bAktif ON tbKrediPaketleri(bAktif)
    CREATE INDEX IX_nSiraNo ON tbKrediPaketleri(nSiraNo)
    
    PRINT 'tbKrediPaketleri tablosu oluşturuldu.'
END
GO

-- ============================================================================
-- TABLO 6: tbKrediHareketleri (Kredi Giriş/Çıkış)
-- ============================================================================

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbKrediHareketleri' AND xtype='U')
BEGIN
    CREATE TABLE tbKrediHareketleri (
        nHareketID INT IDENTITY(1,1) PRIMARY KEY,
        nMusteriID INT NOT NULL,
        nKrediID INT NOT NULL,
        
        -- HAREKET TİPİ
        sHareketTipi NVARCHAR(50),                  -- YuklemeManuel / YuklemePaket / Kullanim / Iade / Bonus
        nMiktar DECIMAL(10,2),
        
        -- İŞLEM DETAYI
        nIslemID INT,
        nStokID INT,
        sBarkod NVARCHAR(50),
        sIslemAciklama NVARCHAR(500),
        
        -- PAKET BİLGİSİ
        nPaketID INT,
        sPaketAdi NVARCHAR(100),
        nPaketFiyat DECIMAL(10,2),
        
        -- ÖDEME BİLGİSİ
        sOdemeTuru NVARCHAR(50),
        sOdemeReferans NVARCHAR(100),
        
        -- BAKİYE
        nOncekiBakiye DECIMAL(10,2),
        nYeniBakiye DECIMAL(10,2),
        
        dteTarih DATETIME DEFAULT GETDATE(),
        
        FOREIGN KEY (nMusteriID) REFERENCES tbMusteri(nMusteriID),
        FOREIGN KEY (nKrediID) REFERENCES tbMusteriKredi(nKrediID),
        FOREIGN KEY (nPaketID) REFERENCES tbKrediPaketleri(nPaketID)
    )
    
    CREATE INDEX IX_nMusteriID ON tbKrediHareketleri(nMusteriID)
    CREATE INDEX IX_nKrediID ON tbKrediHareketleri(nKrediID)
    CREATE INDEX IX_dteTarih ON tbKrediHareketleri(dteTarih)
    CREATE INDEX IX_sHareketTipi ON tbKrediHareketleri(sHareketTipi)
    
    PRINT 'tbKrediHareketleri tablosu oluşturuldu.'
END
GO

-- ============================================================================
-- TABLO 7: tbOdemeler (Ödeme Kayıtları)
-- ============================================================================

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tbOdemeler' AND xtype='U')
BEGIN
    CREATE TABLE tbOdemeler (
        nOdemeID INT IDENTITY(1,1) PRIMARY KEY,
        nMusteriID INT NOT NULL,
        
        -- ÖDEME BİLGİLERİ
        nTutar DECIMAL(10,2),
        sOdemeTuru NVARCHAR(50),                    -- KrediKarti / Havale / EFT
        sOdemeDurumu NVARCHAR(50),                  -- Beklemede / Onaylandi / Iptal / Hata
        
        -- PAKET BİLGİSİ
        nPaketID INT,
        sPaketAdi NVARCHAR(100),
        nKrediMiktari DECIMAL(10,2),
        
        -- ÖDEME GATEWAY
        sGateway NVARCHAR(50),                      -- iyzico / Stripe / PayTR
        sTransactionID NVARCHAR(100),
        sPaymentToken NVARCHAR(255),
        sErrorMessage NVARCHAR(500),
        
        -- FATURA
        sFaturaNo NVARCHAR(50),
        sFaturaAdresi NVARCHAR(500),
        sVergiNo NVARCHAR(50),
        
        -- TARİHLER
        dteOdemeTarihi DATETIME DEFAULT GETDATE(),
        dteOnayTarihi DATETIME,
        
        FOREIGN KEY (nMusteriID) REFERENCES tbMusteri(nMusteriID),
        FOREIGN KEY (nPaketID) REFERENCES tbKrediPaketleri(nPaketID)
    )
    
    CREATE INDEX IX_nMusteriID ON tbOdemeler(nMusteriID)
    CREATE INDEX IX_sOdemeDurumu ON tbOdemeler(sOdemeDurumu)
    CREATE INDEX IX_dteOdemeTarihi ON tbOdemeler(dteOdemeTarihi)
    
    PRINT 'tbOdemeler tablosu oluşturuldu.'
END
GO

-- ============================================================================
-- ÖRNEK VERİ: Paketleri Oluştur (1.4 TL/ürün fiyatlandırma)
-- ============================================================================

-- Mevcut paketleri temizle (opsiyonel)
-- DELETE FROM tbKrediPaketleri

-- Paket 1: BAŞLANGIÇ
IF NOT EXISTS (SELECT * FROM tbKrediPaketleri WHERE sPaketAdi = 'Başlangıç')
BEGIN
    INSERT INTO tbKrediPaketleri (
        sPaketAdi, sPaketAciklama, nFiyat, nKrediMiktari, nBonusOrani, nUrunBasinaKredi,
        bBaslikOlustur, bAciklamaOlustur, bTalimatOlustur, bGorselBul,
        nGunlukLimit, bAktif, nSiraNo
    ) VALUES (
        'Başlangıç',
        'Küçük işletmeler için ideal başlangıç paketi. Temel AI özellikleri ile ürünlerinizi hızla doldurun.',
        700.00,      -- 700 TL (500 kredi x 1.4)
        500.00,      -- 500 Kredi
        0.00,        -- Bonus yok
        1.40,        -- 1.4 TL/ürün
        1, 0, 1, 0,  -- Sadece başlık ve talimat
        50,          -- Günlük 50 işlem
        1, 1         -- Aktif, sıra 1
    )
    PRINT 'Başlangıç paketi oluşturuldu.'
END

-- Paket 2: STANDART (Önerilen)
IF NOT EXISTS (SELECT * FROM tbKrediPaketleri WHERE sPaketAdi = 'Standart')
BEGIN
    INSERT INTO tbKrediPaketleri (
        sPaketAdi, sPaketAciklama, nFiyat, nKrediMiktari, nBonusOrani, nUrunBasinaKredi,
        bBaslikOlustur, bAciklamaOlustur, bTalimatOlustur, bGorselBul,
        nGunlukLimit, bAktif, nSiraNo
    ) VALUES (
        'Standart',
        'Orta ölçekli işletmeler için en popüler paket. Tam özellikli AI desteği ile profesyonel içerikler.',
        1400.00,     -- 1400 TL (1000 kredi x 1.4)
        1100.00,     -- 1100 Kredi (%10 bonus)
        10.00,       -- %10 bonus
        1.27,        -- 1.27 TL/ürün (bonus ile)
        1, 1, 1, 1,  -- Tüm temel özellikler
        100,         -- Günlük 100 işlem
        1, 2         -- Aktif, sıra 2
    )
    PRINT 'Standart paketi oluşturuldu.'
END

-- Paket 3: PRO
IF NOT EXISTS (SELECT * FROM tbKrediPaketleri WHERE sPaketAdi = 'Pro')
BEGIN
    INSERT INTO tbKrediPaketleri (
        sPaketAdi, sPaketAciklama, nFiyat, nKrediMiktari, nBonusOrani, nUrunBasinaKredi,
        bBaslikOlustur, bAciklamaOlustur, bTalimatOlustur, bGorselBul, bGorselDogrula, bKategoriOner, bFiyatOptimize,
        nGunlukLimit, bOncelikliDestek, bAktif, nSiraNo
    ) VALUES (
        'Pro',
        'Büyük işletmeler için gelişmiş paket. Tüm AI özellikleri + öncelikli destek ile maksimum verimlilik.',
        3500.00,     -- 3500 TL (2500 kredi x 1.4)
        3000.00,     -- 3000 Kredi (%20 bonus)
        20.00,       -- %20 bonus
        1.17,        -- 1.17 TL/ürün (bonus ile)
        1, 1, 1, 1, 1, 1, 1,  -- Tüm özellikler
        200,         -- Günlük 200 işlem
        1,           -- Öncelikli destek
        1, 3         -- Aktif, sıra 3
    )
    PRINT 'Pro paketi oluşturuldu.'
END

-- Paket 4: ENTERPRISE
IF NOT EXISTS (SELECT * FROM tbKrediPaketleri WHERE sPaketAdi = 'Enterprise')
BEGIN
    INSERT INTO tbKrediPaketleri (
        sPaketAdi, sPaketAciklama, nFiyat, nKrediMiktari, nBonusOrani, nUrunBasinaKredi,
        bBaslikOlustur, bAciklamaOlustur, bTalimatOlustur, bGorselBul, bGorselDogrula, bKategoriOner, bFiyatOptimize,
        nGunlukLimit, bOncelikliDestek, bOzelPrompt, bAPIEntegrasyon, bAktif, nSiraNo
    ) VALUES (
        'Enterprise',
        'Kurumsal çözümler için özel paket. Sınırsız özellik, API entegrasyonu ve özel destek ile tam kontrol.',
        7000.00,     -- 7000 TL (5000 kredi x 1.4)
        7000.00,     -- 7000 Kredi (%40 bonus)
        40.00,       -- %40 bonus
        1.00,        -- 1.00 TL/ürün (bonus ile)
        1, 1, 1, 1, 1, 1, 1,  -- Tüm özellikler
        500,         -- Günlük 500 işlem
        1,           -- Öncelikli destek
        1,           -- Özel prompt
        1,           -- API erişimi
        1, 4         -- Aktif, sıra 4
    )
    PRINT 'Enterprise paketi oluşturuldu.'
END
GO

-- ============================================================================
-- VİEW: Ürün AI İçerik Özeti
-- ============================================================================

IF EXISTS (SELECT * FROM sysobjects WHERE name='vw_StokAIOzet' AND xtype='V')
    DROP VIEW vw_StokAIOzet
GO

CREATE VIEW vw_StokAIOzet AS
SELECT 
    s.nStokID,
    s.sModel,
    s.sKodu AS sBarkod,
    s.sAciklama AS sStokAdi,
    s.bAIIcerikVar,
    s.dteAISonGuncelleme,
    s.nAIKaliteSkor,
    
    ai.sSEOBaslik,
    ai.sKisaAciklama,
    ai.bOnaylandi,
    ai.nAIMaliyet,
    ai.dteOlusturma AS AIIcerikTarihi,
    
    (SELECT COUNT(*) FROM tbStokResim WHERE nStokID = s.nStokID AND bAIBulundu = 1) AS AIResimSayisi,
    
    CASE 
        WHEN s.bAIIcerikVar = 1 AND ai.bOnaylandi = 1 THEN 'Onaylandı'
        WHEN s.bAIIcerikVar = 1 AND ai.bOnaylandi = 0 THEN 'Onay Bekliyor'
        ELSE 'AI İçerik Yok'
    END AS Durum
    
FROM tbStok s
LEFT JOIN tbStokAIIcerik ai ON s.nStokID = ai.nStokID
GO

-- ============================================================================
-- STORED PROCEDURE: AI İçerik Kaydet
-- ============================================================================

IF EXISTS (SELECT * FROM sysobjects WHERE name='sp_StokAIIcerikKaydet' AND xtype='P')
    DROP PROCEDURE sp_StokAIIcerikKaydet
GO

CREATE PROCEDURE sp_StokAIIcerikKaydet
    @nStokID INT,
    @sSEOBaslik NVARCHAR(255),
    @sDetayliAciklama NVARCHAR(MAX),
    @sKullanimTalimati NVARCHAR(MAX),
    @sMetaDescription NVARCHAR(500),
    @nKullanilanKredi DECIMAL(10,2),
    @sKullaniciAdi NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON
    
    -- Mevcut kayıt var mı kontrol et
    IF EXISTS (SELECT 1 FROM tbStokAIIcerik WHERE nStokID = @nStokID)
    BEGIN
        -- Güncelle
        UPDATE tbStokAIIcerik SET
            sSEOBaslik = @sSEOBaslik,
            sDetayliAciklama = @sDetayliAciklama,
            sKullanimTalimati = @sKullanimTalimati,
            sMetaDescription = @sMetaDescription,
            nKullanilanKredi = nKullanilanKredi + @nKullanilanKredi,
            dteGuncelleme = GETDATE(),
            sGuncelleyenKullanici = @sKullaniciAdi
        WHERE nStokID = @nStokID
        
        PRINT 'AI içerik güncellendi.'
    END
    ELSE
    BEGIN
        -- Yeni kayıt ekle
        INSERT INTO tbStokAIIcerik (
            nStokID, sSEOBaslik, sDetayliAciklama, sKullanimTalimati, 
            sMetaDescription, nKullanilanKredi, sOlusturanKullanici
        ) VALUES (
            @nStokID, @sSEOBaslik, @sDetayliAciklama, @sKullanimTalimati,
            @sMetaDescription, @nKullanilanKredi, @sKullaniciAdi
        )
        
        PRINT 'AI içerik oluşturuldu.'
    END
    
    -- tbStok tablosunu güncelle
    UPDATE tbStok SET
        bAIIcerikVar = 1,
        dteAISonGuncelleme = GETDATE()
    WHERE nStokID = @nStokID
    
    RETURN 0
END
GO

PRINT '============================================'
PRINT 'Veritabanı yapısı başarıyla oluşturuldu!'
PRINT '============================================'
PRINT ''
PRINT 'Oluşturulan Tablolar:'
PRINT '  1. tbStokAIIcerik - AI içerik deposu'
PRINT '  2. tbMusteriKredi - Müşteri kredi hesapları'
PRINT '  3. tbKrediPaketleri - Satılabilir paketler (1.4 TL/ürün)'
PRINT '  4. tbKrediHareketleri - Kredi işlem logu'
PRINT '  5. tbOdemeler - Ödeme kayıtları'
PRINT ''
PRINT 'Güncellenen Tablolar:'
PRINT '  - tbStok (bAIIcerikVar, dteAISonGuncelleme)'
PRINT '  - tbStokResim (bAIBulundu, sAIKaynak, nStokID)'
PRINT ''
PRINT 'View ve SP:'
PRINT '  - vw_StokAIOzet'
PRINT '  - sp_StokAIIcerikKaydet'
PRINT ''
PRINT 'Paketler (1.4 TL bazlı):'
PRINT '  - Başlangıç: 700 TL (500 kredi)'
PRINT '  - Standart: 1400 TL (1100 kredi) +%10'
PRINT '  - Pro: 3500 TL (3000 kredi) +%20'
PRINT '  - Enterprise: 7000 TL (7000 kredi) +%40'
PRINT '============================================'
