# E-TİCARET PARAMETRE SİSTEMİ - KURULUM REHBERİ

## 📋 GENEL BAKIŞ

Bu sistem, e-ticaret siparişlerine ait maliyetleri otomatik olarak hesaplayıp `tbStokFisiMaster.lEkmaliyet3` alanına kaydeder.

---

## 🎯 ÖZELLİKLER

1. **Pazar Yeri Bazlı Parametreler:** Her pazar yeri için ayrı komisyon, kargo, işlem ücreti tanımları
2. **Otomatik Hesaplama:** Sipariş işlenirken maliyetler otomatik hesaplanır
3. **Esnek Yapı:** Parametreler kolayca güncellenebilir
4. **Gelecek İçin Hazır:** Yeni pazar yerleri kolayca eklenebilir

---

## 📦 KURULUM ADIMLARI

### Adım 1: SQL Tablo Oluşturma

```sql
-- SQL_Scripts/01_CREATE_tbParamETicaret.sql dosyasını çalıştırın
-- Bu komut şunları yapar:
-- 1. tbParamETicaret tablosunu oluşturur
-- 2. Index ekler
-- 3. Örnek pazar yeri verilerini ekler
```

**Desteklenen Pazar Yerleri:**
- Trendyol (ty()
- HepsiBurada (Hb()
- N11 (n11)
- Amazon (am()
- GittiGidiyor (gg()
- Çiçek Sepeti (cs()
- Kitapyurdu (ky()
- Pttavm (pt()
- Morhipo (mh()

### Adım 2: Satis_Kaydet Procedure Güncelleme

**ÖNEMLİ:** Önce mevcut procedure'ünüzün yedeğini alın!

```sql
-- Mevcut procedure backup
SELECT OBJECT_DEFINITION(OBJECT_ID('dbo.Satis_Kaydet'))

-- Procedure'e yeni parametre ekleyin:
@EkMaliyet3 numeric(18, 2) = 0 Output  -- En sona ekleyin
```

**Güncellenmesi Gereken Yerler:**

1. **Parametre Listesi** (en sona):
```sql
@Miktar4 numeric(14) Output,
@EkMaliyet3 numeric(18, 2) = 0 Output  -- YENİ
```

2. **Her tbStokFisiMaster UPDATE Komutu:**
```sql
UPDATE tbStokFisiMaster SET 
    lToplamMiktar = @Miktar, 
    lMalBedeli = @BrutTutar, 
    -- ... diğer alanlar ...
    lEkmaliyet1 = 0.00, 
    lEkmaliyet2 = 0.00, 
    lEkmaliyet3 = @EkMaliyet3,  -- YENİ ALAN EKLE
    -- ... diğer alanlar ...
WHERE nStokFisiID = @nStokFisiID
```

**Kaç Yerde Güncelleme Gerekli?**
Procedure'de 5 farklı yerde `UPDATE tbStokFisiMaster` komutu var:
- İlk ürün için
- 2. ürün eklendiğinde
- 3. ürün eklendiğinde
- 4. ürün eklendiğinde
- 5. ürün eklendiğinde

HEPSİNE `lEkmaliyet3 = @EkMaliyet3` ekleyin!

### Adım 3: Form1'e Menü Ekleme

**Form1.vb** veya **Form1.Designer.vb** dosyasında `RibbonPageGroup3` (Tanımlar) bölümüne yeni buton ekleyin:

```vb
' DevExpress RibbonControl kullanıyorsanız:
Dim btnETicaretParam As New DevExpress.XtraBars.BarButtonItem()
btnETicaretParam.Caption = "E-Ticaret Parametre"
btnETicaretParam.Id = xxx  ' Sıradaki ID
AddHandler btnETicaretParam.ItemClick, AddressOf BtnETicaretParam_Click
RibbonPageGroup3.ItemLinks.Add(btnETicaretParam)
```

**Event Handler:**
```vb
Private Sub BtnETicaretParam_Click(sender As Object, e As ItemClickEventArgs)
    Dim frm As New frm_Param_ETicaret()
    frm.ShowDialog()
End Sub
```

---

## 🔧 NASIL ÇALIŞIR?

### 1. Hesaplama Formülü

```
Toplam Ek Maliyet = Komisyon + Kargo + İade Op. + Paketleme + Ödeme İşlem

Örnek (Trendyol - 1000 TL satış):
- Komisyon (%15): 1000 * 0.15 = 150 TL
- Kargo (sabit): 25 TL
- İade Operasyon (%3): 1000 * 0.03 = 30 TL
- Paketleme (%5): 1000 * 0.05 = 50 TL
- Ödeme İşlem Ücreti (sabit): 10 TL
-----------------------------------------
TOPLAM: 265 TL (lEkmaliyet3'e yazılır)
```

### 2. Sipariş İşleme Akışı

```
1. E-Ticaret API'den sipariş gelir (örn: ty(12345))
2. frm_qukaGonder.AddOrder() çağrılır
3. HesaplaEkMaliyet() fonksiyonu çalışır:
   a. Sipariş önekini tanır (ty()
   b. tbParamETicaret'ten parametreleri çeker
   c. Maliyeti hesaplar
4. Satis_Kaydet procedure çağrılır (ekMaliyet3 parametre olarak gönderilir)
5. tbStokFisiMaster.lEkmaliyet3 alanına kaydedilir
```

### 3. Parametre Güncelleme

1. Form1 → Tanımlar → E-Ticaret Parametre
2. Grid'de istediğiniz pazar yerinin değerlerini değiştirin
3. Kaydet butonuna basın
4. Yeni siparişler güncel parametrelerle hesaplanır

---

## 📊 PARAMETRE AÇIKLAMALARI

| Alan | Açıklama | Örnek |
|------|----------|-------|
| **sPazarYeri** | Pazar yeri adı | Trendyol |
| **sKodu** | Kısa kod | TY |
| **sSiparisNoOnek** | Sipariş no öneki | ty( |
| **nKomisyonTipi** | 1=Yüzde, 2=Sabit | 1 |
| **nKomisyonOrani** | Komisyon yüzdesi | 15.00 |
| **lKomisyonSabitTutar** | Sabit komisyon | 0 |
| **lKargoSabitBedel** | Kargo bedeli (sabit) | 25.00 |
| **nIadeOperasyonOrani** | İade operasyon yüzdesi | 3.00 |
| **nPaketlemeOrani** | Paketleme yüzdesi | 5.00 |
| **nOdemeIslemUcretiOrani** | Ödeme işlem yüzdesi | 0 |
| **lOdemeIslemSabitUcret** | Ödeme işlem sabit | 10.00 |
| **bAktif** | Aktif mi? | 1 (Evet) |

---

## ⚠️ ÖNEMLİ NOTLAR

1. **lEkmaliyet3 Fatura Tutarını Değiştirmez**
   - Bu alan sadece maliyet takibi içindir
   - Alıcıya yansımaz
   - Raporlamalarda kullanılır

2. **Yeni Pazar Yeri Ekleme**
```sql
INSERT INTO tbParamETicaret (
    sPazarYeri, sKodu, sSiparisNoOnek, 
    nKomisyonOrani, lKargoSabitBedel, 
    nIadeOperasyonOrani, nPaketlemeOrani, 
    lOdemeIslemSabitUcret, bAktif, sKullaniciAdi
) VALUES (
    'YeniPazarYeri', 'YP', 'yp(', 
    18.00, 30.00, 
    3.50, 5.00, 
    10.00, 1, 'Admin'
)
```

3. **HesaplaEkMaliyet() Fonksiyonu**
   - Sipariş önekini otomatik tanır
   - Bulunamazsa 0 döner (hata vermez)
   - Log'lara kaydedilir

---

## 🐛 SORUN GİDERME

### Problem: Hesaplama yapılmıyor

**Kontrol Listesi:**
1. ✅ tbParamETicaret tablosu oluşturuldu mu?
2. ✅ Procedure'e @EkMaliyet3 parametresi eklendi mi?
3. ✅ UPDATE komutlarına lEkmaliyet3 = @EkMaliyet3 eklendi mi?
4. ✅ Sipariş öneki doğru mu? (ty(, Hb(, n11, vb.)
5. ✅ tbParamETicaret'te ilgili kayıt var mı ve bAktif = 1 mi?

### Problem: Parametre formu açılmıyor

1. frm_Param_ETicaret.vb dosyası projeye eklendi mi?
2. Form1'de menü butonu tanımlandı mı?
3. Event handler doğru mu?

### Logları Kontrol

```sql
-- frm_qukaGonder.vb log kayıtlarına bakın:
-- [INFO] HesaplaEkMaliyet - OrderID: ty(123), Toplam Satış: 1000, Ek Maliyet: 265
-- [DEBUG] AddOrder - EkMaliyet3=265
```

---

## 📞 EK BİLGİLER

### Gelecek Geliştirmeler (İhtiyaç Durumunda)

1. **Kategori Bazlı Komisyon**
   - tbParamETicaret'e nKategoriID eklenebilir
   - Züccaciye, Tekstil gibi farklı komisyonlar

2. **Ağırlık Bazlı Kargo**
   - tbStok.nAgirlik alanı kullanılabilir
   - Dinamik kargo hesaplama

3. **Tarih Aralıklı Parametreler**
   - Kampanya dönemlerinde farklı oranlar
   - Geçici indirimler

---

## ✅ KURULUM KONTROLÜ

```sql
-- 1. Tablo kontrolü
SELECT * FROM tbParamETicaret

-- 2. Procedure kontrolü
SELECT 
    PARAMETER_NAME, 
    DATA_TYPE, 
    ORDINAL_POSITION 
FROM INFORMATION_SCHEMA.PARAMETERS 
WHERE SPECIFIC_NAME = 'Satis_Kaydet'
ORDER BY ORDINAL_POSITION

-- @EkMaliyet3 parametresi en sonda görünmeli

-- 3. Test siparişi
-- E-ticaret API'den sipariş çekin ve kontrol edin:
SELECT 
    nStokFisiID, 
    lNetTutar, 
    lEkmaliyet3,
    dteFisTarihi
FROM tbStokFisiMaster 
WHERE dteFisTarihi >= CAST(GETDATE() AS DATE)
ORDER BY nStokFisiID DESC

-- lEkmaliyet3 > 0 olmalı
```

---

**Başarılar! 🚀**

*Bu sistem sayesinde e-ticaret maliyetlerinizi doğru takip edebilir ve karlılık analizleri yapabilirsiniz.*
