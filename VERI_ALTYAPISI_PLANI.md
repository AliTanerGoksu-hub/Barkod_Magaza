# VERI ALTYAPISI HAZIRLIK PLANI
## AI icin Gerekli Veri Degisiklikleri

---

## MEVCUT DURUM (Veritabaninda ZATen VAR)

| Alan | Tablo | Durum |
|------|-------|-------|
| dteValorTarihi (Valor Tarihi) | tbStokFisiMaster | VAR ama zorunlu degil, genelde fis tarihiyle ayni |
| nVadeGun (Vade Gun) | tbFirma | VAR ama cogu firmada 0 |
| lKrediLimiti (Kredi Limiti) | tbFirma | VAR ama cogu firmada 0 (sinirsiz) |
| bTahsilatYapilamaz | tbFirma | VAR |
| bSatisYapilamaz | tbFirma | VAR |
| dteValorTarihi | tbFirmaHareketi | VAR (cari hareket valor tarihi) |
| dteVadeTarihi | tbStokFisiOdemePlani | VAR (fatura odeme plani) |
| dteVadeTarihi | tbCekSenet | VAR (cek/senet vade) |
| dteValorTarihi | tbOdeme (Perakende) | VAR |

---

## YAPILMASI GEREKEN DEGISIKLIKLER

### 1. FATURA/SIPARIS — Valor Tarihi ZORUNLU (Toptan + Perakende)

**Sorun:** dteValorTarihi genelde dteFisTarihi ile ayni ataniyor. Gercek vade tarihi girilmiyor.
**Cozum:** 
- Fatura/siparis kaydederken valor tarihi bos birakilamaz
- Firma kartinda nVadeGun tanimli ise, valor tarihi otomatik hesaplansin: dteFisTarihi + nVadeGun
- Kullanici degistirebilir ama bos birakamaz
- Pesin satislarda valor = fis tarihi (otomatik)

**Etkilenen Formlar:**
- `frm_stok_cari_satis.vb` (Toptan satis faturasi)
- `frm_stok_cari_alis.vb` (Alis faturasi)
- `frm_perakende_odeme.vb` (Perakende acik hesap/taksit)
- `FaturaMobile.vb` (Mobil fatura)

**Kod Degisikligi:**
```vb
' Fatura kaydederken:
If bPesinmi = 0 Then ' Veresiye ise
    If dteValorTarihi = dteFisTarihi OrElse dteValorTarihi = DateTime.MinValue Then
        ' Firma kartindan vade gun al
        If nVadeGun > 0 Then
            dteValorTarihi = dteFisTarihi.AddDays(nVadeGun)
        Else
            MessageBox.Show("Valor tarihi girilmeli veya firma kartinda vade gun tanimlanmali!")
            Return ' Kaydetme
        End If
    End If
End If
```

---

### 2. FIRMA KARTI — Kredi Limiti ve Vade Gun ZORUNLU

**Sorun:** Birçok firmada lKrediLimiti = 0 ve nVadeGun = 0. Risk hesaplanamaz.
**Cozum:**
- Veresiye calisilan firma kaydederken kredi limiti ve vade gun zorunlu
- 0 olarak birakildiysa uyari: "Kredi limiti tanimlanmamis, risk skoru hesaplanamaz"

**Etkilenen Formlar:**
- `Form1.vb` (Firma karti kaydet — tbFirma_kaydet_yeni)
- `frm_stok_cari_alis.vb` (firma_kaydet_yeni)

---

### 3. PERAKENDE — Acik Hesap / Taksitli Musteriler icin Risk Altyapisi

**Sorun:** Perakende musteriler (tbMusteri) ayri bir tabloda. Toptan carilerle (tbFirma) ayni risk skorlamasina tabi degil.
**Cozum:**
- Perakende acik hesap musteri kaydinda da vade gun ve limit bilgisi zorunlu
- tbMusteri tablosuna eklenmesi gereken alanlar (yoksa):
  - lKrediLimiti (varsa kontrol et)
  - nVadeGun
  - nRiskSkoru (hesaplanan)
  - dteRiskSonGuncelleme
- Perakende tahsilat ekraninda da risk gostergesi

**Etkilenen Formlar:**
- `frm_perakende.vb` (Musteri karti)
- `frm_perakende_odeme.vb` (Odeme/tahsilat)

---

### 4. CARI HAREKET — Gecikme Gun Hesaplama icin Veri Zenginlestirme

**Sorun:** tbFirmaHareketi'nde gecikme gunu hesaplamak icin dteValorTarihi kaydedilmis olmali.
**Cozum:**
- Cari hareket kaydederken dteValorTarihi'nin dogru doldurulmasini kontrol et
- Mevcut veriler icin: dteValorTarihi = dteIslemTarihi olanlari raporla (duzeltilmesi gerekebilir)

**SQL Rapor (Mevcut veri kalitesi kontrolu):**
```sql
-- Valor tarihi = islem tarihi olan veresiye kayitlari (duzeltilmesi gereken)
SELECT COUNT(*) AS EksikVadeKayit
FROM tbFirmaHareketi h
INNER JOIN tbStokFisiMaster m ON h.nHareketID = m.nCariHareketID
WHERE m.bPesinmi = 0
AND h.dteValorTarihi = h.dteIslemTarihi

-- Kredi limiti tanimlanmamis firmalar
SELECT COUNT(*) AS LimitsizFirma
FROM tbFirma
WHERE (lKrediLimiti = 0 OR lKrediLimiti IS NULL)
AND bAktif = 1

-- Vade gun tanimlanmamis firmalar
SELECT COUNT(*) AS VadesizFirma
FROM tbFirma
WHERE (nVadeGun = 0 OR nVadeGun IS NULL)
AND bAktif = 1
```

---

### 5. YENi TABLO: tbRiskSkoru (Hesaplanan Risk Verisi)

```sql
CREATE TABLE tbRiskSkoru (
    nFirmaID INT PRIMARY KEY,
    nRiskSkoru INT DEFAULT 0,           -- 0-100
    sRiskSeviye NVARCHAR(20),           -- 'guvenli', 'dikkat', 'kritik'
    lToplamBakiye DECIMAL(18,2),
    nMaxGecikmeGun INT,
    nOrtGecikmeGun INT,
    nOdemeDisipilin DECIMAL(5,2),       -- 0.00-1.00
    nIadeOrani DECIMAL(5,2),
    nSiparisSikligi INT,                -- Son 90 gun siparis sayisi
    nLimitKullanim DECIMAL(5,2),        -- 0.00-1.00
    sAIAciklama NVARCHAR(MAX),          -- AI'nin urettigi risk aciklamasi
    dteHesaplamaTarihi DATETIME,
    sKaynak NVARCHAR(20)                -- 'toptan' veya 'perakende'
)
```

---

### 6. YENi TABLO: tbTemsilciNot (Saha Notlari)

```sql
CREATE TABLE tbTemsilciNot (
    nNotID INT IDENTITY PRIMARY KEY,
    nFirmaID INT,
    nTemsilciID INT,
    sNotTipi NVARCHAR(50),              -- 'ziyaret', 'tahsilat', 'genel', 'risk'
    sNot NVARCHAR(MAX),
    dteTarih DATETIME DEFAULT GETDATE(),
    dteHatirlatma DATETIME NULL,        -- Hatirlatma tarihi (varsa)
    gpsLat DECIMAL(10,7) NULL,
    gpsLon DECIMAL(10,7) NULL
)
```

---

## UYGULAMA SIRASI

| Sira | Is | Etki |
|------|----|------|
| 1 | Firma kartinda nVadeGun ve lKrediLimiti uyarisi ekle | Yeni kayitlarda veri kalitesi |
| 2 | Fatura kaydetmede dteValorTarihi zorunlu yap | Gecikme gunu hesaplanabilir |
| 3 | tbRiskSkoru tablosu olustur | Risk verisi depolanabilir |
| 4 | tbTemsilciNot tablosu olustur | Saha notlari kaydedilebilir |
| 5 | Perakende musteri kartinda limit/vade alanlari | Perakende risk takibi |
| 6 | Mevcut veri kalitesi raporu SQL'leri calistir | Duzeltilmesi gereken veriler |
| 7 | API endpoint'leri (Risk, Tahsilat, Satis Oneri) | AI hazir |
