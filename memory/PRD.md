# Barkod Magaza - Product Requirements Document

## Original Problem Statement
VB.NET Windows Forms ERP/POS uygulamasinin gelistirilmesi:
- POS entegrasyonlari (Kolaysoft) hata duzeltmeleri
- GIB e-fatura XML olusturma duzeltmeleri
- UI thread crash duzeltmeleri
- Maliyet hesaplama yontemlerinin standardize edilmesi (FIFO, LIFO, Agirlikli Ortalama, Hareketli Ortalama, Gercek Parti, Standart Maliyet)

## Repository
- URL: https://github.com/AliTanerGoksu-hub/Barkod_Magaza.git
- Branch: main

## Completed Work

### Session 1 (Previous)
- Form1.vb derleme hatalari duzeltildi (FtpEskiYedekleriSil_ESKI)
- B2B Settings tab eklendi (frm_personel.vb)
- R2 Image upload (frm_tbSinif.vb, Form1.vb)
- Otomatik yedekleme hatalari duzeltildi
- BusinessSmartDesktopAPI .NET 8.0'a guncellendi
- ApiClient.vb FTP'den API'ye gecis

### Session 2 (Previous)
- Cross-thread exception duzeltildi (SatisiKolaysoftaGonder)
- Iptal/iade faturalari Kolaysoft'a gonderilmesi engellendi
- Kolaysoft error.notExist hatasi duzeltildi
- KDV cift ekleme hatasi duzeltildi (frm_fatura_liste.vb, frm_stok_satis_karlilik.vb)
- RowNotInTableException duzeltildi (frm_Perakende_Satis.vb)
- POS UI: Basarisiz odeme kaydetme mantigi duzeltildi
- SQL syntax hatasi duzeltildi (frm_tbKod.vb)
- GIB E-Fatura XML cac:Person hatasi duzeltildi (mod_EFatura.vb)
- Repository Barkod_Magaza_Git -> Barkod_Magaza tasindi

### Session 3 (Current - Feb 2026)
- Merkezi MaliyetHesaplayici.vb modulu olusturuldu (231 satir)
  - FIFO, LIFO, Agirlikli Ortalama, Hareketli Ortalama, Gercek Parti, Standart Maliyet
  - BirimMaliyetHesapla: KDV + ek maliyet hesaplama (mevcut maliyet_kontrol mantigi)
  - AlisKayitlariGetir: SQL ile alis kayitlari sorgulama
  - AlisKdvDahilMi: Onbellekli KDV kontrolu
- frm_stok_satis_karlilik.vb: ComboBox (index 3-8) ve kontrol_oran() guncellendi
- frm_stok_liste_envanter_deger.vb: sec_MaliyetTipi ComboBox, lblMaliyet, dataload sonrasi maliyet yeniden hesaplama eklendi
- BARKOD_MAGAZA.vbproj guncellendi

## Architecture
```
/app/
MaliyetHesaplayici.vb    # YENI - Merkezi maliyet modulu
frm_stok_satis_karlilik.vb    # Karlilik formu (ComboBox 0-8)
frm_stok_liste_envanter_deger.vb  # Envanter formu (ComboBox 0-8)
Form1.vb, KeyCode.vb, ApiClient.vb...
```

## ComboBox Index Mapping
- 0: Stok Kartindan (mevcut)
- 1: Maliyetlendirmeden (mevcut)
- 2: Satis Gunundeki Maliyet (mevcut)
- 3: FIFO (Ilk Giren Ilk Cikar) [YENI]
- 4: LIFO (Son Giren Ilk Cikar) [YENI]
- 5: Agirlikli Ortalama [YENI]
- 6: Hareketli Ortalama [YENI]
- 7: Gercek Parti Maliyeti [YENI]
- 8: Standart Maliyet [YENI]

## Remaining / Future Tasks
- P1: Diger maliyet hesaplayan formlarda da ayni ComboBox yapisini uygula
- P1: POS yerel kaydetme akisini dogrula
- P2: End-to-end B2B senkronizasyonu testi
