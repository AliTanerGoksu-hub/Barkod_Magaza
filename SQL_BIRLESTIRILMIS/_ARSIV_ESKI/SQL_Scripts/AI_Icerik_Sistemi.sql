-- =============================================
-- AI İçerik Sistemi Geliştirme
-- Tarih: 2026-01-21
-- Açıklama: Kapsamlı ürün içeriği için tablo yapısı
-- =============================================

-- =============================================
-- BÖLÜM 1: PARAMETRE TABLOSU GÜNCELLEMESİ
-- =============================================

-- Yeni AI parametreleri ekle (tbParamGenel veya tbParamAI)
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'tbParamAI')
BEGIN
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamAI') AND name = 'bKapsamliIcerik')
        ALTER TABLE tbParamAI ADD bKapsamliIcerik BIT DEFAULT 1
    
    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbParamAI') AND name = 'bBedenTablosuOlustur')
        ALTER TABLE tbParamAI ADD bBedenTablosuOlustur BIT DEFAULT 1
    
    PRINT 'tbParamAI güncel parametreler eklendi.'
END
GO

-- =============================================
-- BÖLÜM 2: BEDEN TABLOSU ŞABLONLARI
-- =============================================

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbBedenTablosuSablon')
BEGIN
    CREATE TABLE tbBedenTablosuSablon (
        nID INT IDENTITY(1,1) PRIMARY KEY,
        sKategori NVARCHAR(100) NOT NULL,           -- Çocuk Giyim, Yetişkin Giyim, Ayakkabı vb.
        sCinsiyet NVARCHAR(20),                      -- Erkek, Kadın, Unisex, Çocuk
        sYasGrubu NVARCHAR(50),                      -- Bebek, Çocuk, Yetişkin
        sBedenTablosuHTML NVARCHAR(MAX),             -- HTML formatında beden tablosu
        bAktif BIT DEFAULT 1,
        dteOlusturmaTarihi DATETIME DEFAULT GETDATE(),
        dteGuncellemeTarihi DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbBedenTablosuSablon tablosu oluşturuldu.'
END
GO

-- Varsayılan beden tablosu şablonları ekle
IF NOT EXISTS (SELECT 1 FROM tbBedenTablosuSablon WHERE sKategori = 'Çocuk Giyim')
BEGIN
    INSERT INTO tbBedenTablosuSablon (sKategori, sCinsiyet, sYasGrubu, sBedenTablosuHTML)
    VALUES ('Çocuk Giyim', 'Çocuk', 'Çocuk', 
    '<div class="size-chart">
    <h3>📏 Çocuk Beden Tablosu</h3>
    <table border="1" cellpadding="8" cellspacing="0" style="border-collapse:collapse; width:100%; text-align:center;">
    <thead style="background-color:#f5f5f5;">
        <tr><th>Beden</th><th>Yaş</th><th>Boy (cm)</th><th>Göğüs (cm)</th><th>Bel (cm)</th></tr>
    </thead>
    <tbody>
        <tr><td>1-2 Yaş</td><td>1-2</td><td>80-92</td><td>50-52</td><td>48-50</td></tr>
        <tr><td>2-3 Yaş</td><td>2-3</td><td>92-98</td><td>52-54</td><td>50-52</td></tr>
        <tr><td>3-4 Yaş</td><td>3-4</td><td>98-104</td><td>54-56</td><td>52-53</td></tr>
        <tr><td>4-5 Yaş</td><td>4-5</td><td>104-110</td><td>56-58</td><td>53-54</td></tr>
        <tr><td>5-6 Yaş</td><td>5-6</td><td>110-116</td><td>58-60</td><td>54-55</td></tr>
        <tr><td>6-7 Yaş</td><td>6-7</td><td>116-122</td><td>60-62</td><td>55-56</td></tr>
        <tr><td>7-8 Yaş</td><td>7-8</td><td>122-128</td><td>62-64</td><td>56-58</td></tr>
        <tr><td>8-9 Yaş</td><td>8-9</td><td>128-134</td><td>64-67</td><td>58-60</td></tr>
        <tr><td>9-10 Yaş</td><td>9-10</td><td>134-140</td><td>67-70</td><td>60-62</td></tr>
        <tr><td>10-11 Yaş</td><td>10-11</td><td>140-146</td><td>70-74</td><td>62-64</td></tr>
        <tr><td>11-12 Yaş</td><td>11-12</td><td>146-152</td><td>74-78</td><td>64-66</td></tr>
        <tr><td>12-13 Yaş</td><td>12-13</td><td>152-158</td><td>78-82</td><td>66-68</td></tr>
        <tr><td>13-14 Yaş</td><td>13-14</td><td>158-164</td><td>82-86</td><td>68-70</td></tr>
    </tbody>
    </table>
    <p style="font-size:12px; color:#666; margin-top:10px;">⚠️ Ölçüler yaklaşık değerlerdir. Çocuğunuzun yaşı ve ölçüleri tablodaki değerlerden farklı olabilir.</p>
    </div>')
    PRINT 'Çocuk Giyim beden tablosu şablonu eklendi.'
END
GO

IF NOT EXISTS (SELECT 1 FROM tbBedenTablosuSablon WHERE sKategori = 'Erkek Giyim')
BEGIN
    INSERT INTO tbBedenTablosuSablon (sKategori, sCinsiyet, sYasGrubu, sBedenTablosuHTML)
    VALUES ('Erkek Giyim', 'Erkek', 'Yetişkin', 
    '<div class="size-chart">
    <h3>📏 Erkek Beden Tablosu</h3>
    <table border="1" cellpadding="8" cellspacing="0" style="border-collapse:collapse; width:100%; text-align:center;">
    <thead style="background-color:#f5f5f5;">
        <tr><th>Beden</th><th>Göğüs (cm)</th><th>Bel (cm)</th><th>Kalça (cm)</th><th>Kol (cm)</th></tr>
    </thead>
    <tbody>
        <tr><td>XS</td><td>86-90</td><td>72-76</td><td>86-90</td><td>60</td></tr>
        <tr><td>S</td><td>90-94</td><td>76-80</td><td>90-94</td><td>61</td></tr>
        <tr><td>M</td><td>94-98</td><td>80-84</td><td>94-98</td><td>62</td></tr>
        <tr><td>L</td><td>98-102</td><td>84-88</td><td>98-102</td><td>63</td></tr>
        <tr><td>XL</td><td>102-106</td><td>88-92</td><td>102-106</td><td>64</td></tr>
        <tr><td>XXL</td><td>106-112</td><td>92-98</td><td>106-112</td><td>65</td></tr>
        <tr><td>3XL</td><td>112-118</td><td>98-104</td><td>112-118</td><td>66</td></tr>
    </tbody>
    </table>
    <p style="font-size:12px; color:#666; margin-top:10px;">💡 Göğüs, bel ve kalça ölçülerinizi alarak tablodaki en yakın bedeni seçebilirsiniz.</p>
    </div>')
    PRINT 'Erkek Giyim beden tablosu şablonu eklendi.'
END
GO

IF NOT EXISTS (SELECT 1 FROM tbBedenTablosuSablon WHERE sKategori = 'Kadın Giyim')
BEGIN
    INSERT INTO tbBedenTablosuSablon (sKategori, sCinsiyet, sYasGrubu, sBedenTablosuHTML)
    VALUES ('Kadın Giyim', 'Kadın', 'Yetişkin', 
    '<div class="size-chart">
    <h3>📏 Kadın Beden Tablosu</h3>
    <table border="1" cellpadding="8" cellspacing="0" style="border-collapse:collapse; width:100%; text-align:center;">
    <thead style="background-color:#f5f5f5;">
        <tr><th>Beden</th><th>TR Beden</th><th>Göğüs (cm)</th><th>Bel (cm)</th><th>Kalça (cm)</th></tr>
    </thead>
    <tbody>
        <tr><td>XS</td><td>34</td><td>80-84</td><td>60-64</td><td>86-90</td></tr>
        <tr><td>S</td><td>36</td><td>84-88</td><td>64-68</td><td>90-94</td></tr>
        <tr><td>M</td><td>38</td><td>88-92</td><td>68-72</td><td>94-98</td></tr>
        <tr><td>L</td><td>40</td><td>92-96</td><td>72-76</td><td>98-102</td></tr>
        <tr><td>XL</td><td>42</td><td>96-100</td><td>76-80</td><td>102-106</td></tr>
        <tr><td>XXL</td><td>44</td><td>100-106</td><td>80-86</td><td>106-112</td></tr>
        <tr><td>3XL</td><td>46</td><td>106-112</td><td>86-92</td><td>112-118</td></tr>
    </tbody>
    </table>
    <p style="font-size:12px; color:#666; margin-top:10px;">💡 En doğru beden seçimi için vücut ölçülerinizi mezura ile alın.</p>
    </div>')
    PRINT 'Kadın Giyim beden tablosu şablonu eklendi.'
END
GO

IF NOT EXISTS (SELECT 1 FROM tbBedenTablosuSablon WHERE sKategori = 'Bebek Giyim')
BEGIN
    INSERT INTO tbBedenTablosuSablon (sKategori, sCinsiyet, sYasGrubu, sBedenTablosuHTML)
    VALUES ('Bebek Giyim', 'Unisex', 'Bebek', 
    '<div class="size-chart">
    <h3>👶 Bebek Beden Tablosu</h3>
    <table border="1" cellpadding="8" cellspacing="0" style="border-collapse:collapse; width:100%; text-align:center;">
    <thead style="background-color:#fff3e0;">
        <tr><th>Beden</th><th>Yaş/Ay</th><th>Boy (cm)</th><th>Kilo (kg)</th></tr>
    </thead>
    <tbody>
        <tr><td>50</td><td>Yenidoğan</td><td>50</td><td>3-3.5</td></tr>
        <tr><td>56</td><td>0-1 Ay</td><td>51-56</td><td>3.5-4.5</td></tr>
        <tr><td>62</td><td>1-3 Ay</td><td>57-62</td><td>4.5-6</td></tr>
        <tr><td>68</td><td>3-6 Ay</td><td>63-68</td><td>6-7.5</td></tr>
        <tr><td>74</td><td>6-9 Ay</td><td>69-74</td><td>7.5-9</td></tr>
        <tr><td>80</td><td>9-12 Ay</td><td>75-80</td><td>9-10.5</td></tr>
        <tr><td>86</td><td>12-18 Ay</td><td>81-86</td><td>10.5-12</td></tr>
        <tr><td>92</td><td>18-24 Ay</td><td>87-92</td><td>12-13.5</td></tr>
    </tbody>
    </table>
    <p style="font-size:12px; color:#666; margin-top:10px;">⚠️ Her bebek farklı gelişir. Bebeğinizin boy ve kilosuna göre bir üst bedeni tercih edebilirsiniz.</p>
    </div>')
    PRINT 'Bebek Giyim beden tablosu şablonu eklendi.'
END
GO

-- =============================================
-- BÖLÜM 2: AI İÇERİK TABLOSU GÜNCELLEMESİ
-- =============================================

-- tbStokAIIcerik tablosuna yeni alanlar ekle
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokAIIcerik') AND name = 'sBedenTablosu')
BEGIN
    ALTER TABLE tbStokAIIcerik ADD sBedenTablosu NVARCHAR(MAX) NULL
    PRINT 'sBedenTablosu sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokAIIcerik') AND name = 'sOzelliklerHTML')
BEGIN
    ALTER TABLE tbStokAIIcerik ADD sOzelliklerHTML NVARCHAR(MAX) NULL
    PRINT 'sOzelliklerHTML sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokAIIcerik') AND name = 'sKullanimTalimati')
BEGIN
    ALTER TABLE tbStokAIIcerik ADD sKullanimTalimati NVARCHAR(MAX) NULL
    PRINT 'sKullanimTalimati sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokAIIcerik') AND name = 'sAnahtarKelimeler')
BEGIN
    ALTER TABLE tbStokAIIcerik ADD sAnahtarKelimeler NVARCHAR(500) NULL
    PRINT 'sAnahtarKelimeler sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokAIIcerik') AND name = 'sKisaAciklama')
BEGIN
    ALTER TABLE tbStokAIIcerik ADD sKisaAciklama NVARCHAR(500) NULL
    PRINT 'sKisaAciklama sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokAIIcerik') AND name = 'nIcerikPuani')
BEGIN
    ALTER TABLE tbStokAIIcerik ADD nIcerikPuani INT DEFAULT 0
    PRINT 'nIcerikPuani sütunu eklendi.'
END
GO

-- =============================================
-- BÖLÜM 3: tbStokUzunNot TABLOSU GÜNCELLEMESİ
-- =============================================

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokUzunNot') AND name = 'sBedenTablosu')
BEGIN
    ALTER TABLE tbStokUzunNot ADD sBedenTablosu NVARCHAR(MAX) NULL
    PRINT 'tbStokUzunNot.sBedenTablosu sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokUzunNot') AND name = 'sOzellikler')
BEGIN
    ALTER TABLE tbStokUzunNot ADD sOzellikler NVARCHAR(MAX) NULL
    PRINT 'tbStokUzunNot.sOzellikler sütunu eklendi.'
END

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('tbStokUzunNot') AND name = 'sKullanimTalimati')
BEGIN
    ALTER TABLE tbStokUzunNot ADD sKullanimTalimati NVARCHAR(MAX) NULL
    PRINT 'tbStokUzunNot.sKullanimTalimati sütunu eklendi.'
END
GO

PRINT ''
PRINT '============================================='
PRINT 'AI İÇERİK SİSTEMİ TABLOALRI HAZIR!'
PRINT ''
PRINT 'Oluşturulan/Güncellenen:'
PRINT '  - tbBedenTablosuSablon (yeni tablo)'
PRINT '  - tbStokAIIcerik (yeni sütunlar)'
PRINT '  - tbStokUzunNot (yeni sütunlar)'
PRINT '============================================='
GO
