-- B2B Tabloları Oluşturma Scripti
-- Bu script frm_personel.vb B2B sekmesi için gerekli tabloları oluşturur
-- Tüm alanlar default olarak false (0) değeri alır

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- tbB2BCariGorunumAyari Tablosu
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbB2BCariGorunumAyari]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbB2BCariGorunumAyari](
    [nID] [int] IDENTITY(1,1) NOT NULL,
    [sCariKodu] [nvarchar](50) NOT NULL,
    [bUrunBarkodGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunStokKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunKategoriGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunMarkaGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunStokMiktariGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunBirimFiyatGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunListeFiyatiGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunIskontoOraniGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunRenkGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunBedenGoster] [bit] NOT NULL DEFAULT (0),
    [bUrunResimGoster] [bit] NOT NULL DEFAULT (0),
    [bDetayBarkodGoster] [bit] NOT NULL DEFAULT (0),
    [bDetayStokKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bDetayRenkKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bDetayBedenKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bDetayBirimCinsiGoster] [bit] NOT NULL DEFAULT (0),
    [bDetayKdvOraniGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfBarkodGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfStokKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfRenkKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfBedenKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfBirimCinsiGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfKategoriGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfMarkaGoster] [bit] NOT NULL DEFAULT (0),
    [bPdfResimGoster] [bit] NOT NULL DEFAULT (0),
    [bSepetBarkodGoster] [bit] NOT NULL DEFAULT (0),
    [bSepetStokKoduGoster] [bit] NOT NULL DEFAULT (0),
    [bSepetResimGoster] [bit] NOT NULL DEFAULT (0),
    [dtOlusturma] [datetime] NOT NULL DEFAULT (getdate()),
    [dtGuncelleme] [datetime] NULL,
 CONSTRAINT [PK_tbB2BCariGorunumAyari] PRIMARY KEY CLUSTERED 
(
    [nID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- sCariKodu için unique index oluştur
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbB2BCariGorunumAyari_sCariKodu')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [IX_tbB2BCariGorunumAyari_sCariKodu] ON [dbo].[tbB2BCariGorunumAyari]
    (
        [sCariKodu] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
END
GO

-- tbB2BDetay Tablosu
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbB2BDetay]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbB2BDetay](
    [nID] [int] IDENTITY(1,1) NOT NULL,
    [nB2BSiparisID] [int] NOT NULL,
    [sStokKodu] [nvarchar](50) NOT NULL,
    [sBarkod] [nvarchar](50) NULL,
    [sRenkKodu] [nvarchar](20) NULL,
    [sBedenKodu] [nvarchar](20) NULL,
    [sBirimCinsi] [nvarchar](20) NULL,
    [nMiktar] [decimal](18, 4) NOT NULL DEFAULT (0),
    [nBirimFiyat] [decimal](18, 4) NOT NULL DEFAULT (0),
    [nKdvOrani] [decimal](5, 2) NOT NULL DEFAULT (0),
    [nIskontoOrani] [decimal](5, 2) NOT NULL DEFAULT (0),
    [nTutar] [decimal](18, 4) NOT NULL DEFAULT (0),
    [sAciklama] [nvarchar](500) NULL,
    [dtOlusturmaTarihi] [datetime] NOT NULL DEFAULT (getdate()),
    [dtGuncellenmeTarihi] [datetime] NULL,
 CONSTRAINT [PK_tbB2BDetay] PRIMARY KEY CLUSTERED 
(
    [nID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- nB2BSiparisID için index oluştur
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbB2BDetay_nB2BSiparisID')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tbB2BDetay_nB2BSiparisID] ON [dbo].[tbB2BDetay]
    (
        [nB2BSiparisID] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
END
GO

-- tbB2BSepet Tablosu
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbB2BSepet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbB2BSepet](
    [nID] [int] IDENTITY(1,1) NOT NULL,
    [sCariKodu] [nvarchar](50) NOT NULL,
    [sStokKodu] [nvarchar](50) NOT NULL,
    [sBarkod] [nvarchar](50) NULL,
    [sRenkKodu] [nvarchar](20) NULL,
    [sBedenKodu] [nvarchar](20) NULL,
    [nMiktar] [decimal](18, 4) NOT NULL DEFAULT (0),
    [nBirimFiyat] [decimal](18, 4) NOT NULL DEFAULT (0),
    [nKdvOrani] [decimal](5, 2) NOT NULL DEFAULT (0),
    [dtOlusturmaTarihi] [datetime] NOT NULL DEFAULT (getdate()),
    [dtGuncellenmeTarihi] [datetime] NULL,
 CONSTRAINT [PK_tbB2BSepet] PRIMARY KEY CLUSTERED 
(
    [nID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

-- sCariKodu için index oluştur
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_tbB2BSepet_sCariKodu')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_tbB2BSepet_sCariKodu] ON [dbo].[tbB2BSepet]
    (
        [sCariKodu] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
END
GO

PRINT 'B2B Tablolari basariyla olusturuldu!'
GO
