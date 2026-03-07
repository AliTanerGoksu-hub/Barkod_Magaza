# 📱 WhatsApp Bildirim Mesaj Şablonları

Bu döküman, sistemdeki tüm bildirim türleri için kullanılan WhatsApp mesaj şablonlarını içerir.

---

## 📋 BİLDİRİM TİPLERİ TABLOSU

| # | Tip Kodu | Tip Adı | Kategori | Fonksiyon |
|---|----------|---------|----------|-----------|
| 1 | GOREV_ATANDI | Yeni Görev Atandı | Görev | `GorevBildirimiGonder` |
| 2 | GOREV_HATIRLATMA | Görev Hatırlatması | Görev | `GorevHatirlatmaBildirimiGonder` |
| 3 | GOREV_TAMAMLANDI | Görev Tamamlandı | Görev | `GorevTamamlandiBildirimiGonder` |
| 4 | GOREV_ACIL | Acil Görev | Görev | `GorevBildirimiGonder` |
| 5 | SIPARIS_YENI | Yeni Sipariş | Sipariş | `SiparisYeniBildirimiGonder` |
| 6 | SIPARIS_ONAYLANDI | Sipariş Onaylandı | Sipariş | `SiparisOnaylandiBildirimiGonder` |
| 7 | SIPARIS_IPTAL | Sipariş İptal Edildi | Sipariş | `SiparisIptalBildirimiGonder` |
| 8 | SIPARIS_SEVK | Sipariş Sevk Edildi | Sipariş | `SiparisSevkBildirimiGonder` |
| 9 | URETIM_BASLADI | Üretim Başladı | Üretim | `UretimBasladiBildirimiGonder` |
| 10 | URETIM_ASAMA_TAMAMLANDI | Üretim Aşaması Tamamlandı | Üretim | `UretimAsamaTamamlandiBildirimiGonder` |
| 11 | URETIM_TAMAMLANDI | Üretim Tamamlandı | Üretim | `UretimTamamlandiBildirimiGonder` |
| 12 | URETIM_GECIKME | Üretim Gecikmesi | Üretim | `UretimGecikmeBildirimiGonder` |
| 13 | URETIM_FIRE | Üretim Fire Bildirimi | Üretim | `UretimFireBildirimiGonder` |
| 14 | URETIM_ONAY_BEKLIYOR | Üretim Onayı Bekliyor | Üretim | `UretimOnayBekliyorBildirimiGonder` |
| 15 | STOK_KRITIK | Kritik Stok Seviyesi | Stok | `StokKritikBildirimiGonder` |
| 16 | STOK_FIYAT_DUSUK | Stok Fiyatı Maliyetin Altında | Stok | `StokFiyatDusukBildirimiGonder` |
| 17 | SATIN_ALMA_TALEP | Satın Alma Talebi | Stok | `SatinAlmaTalepBildirimiGonder` |
| 18 | SATIN_ALMA_ONAYLANDI | Satın Alma Onaylandı | Stok | `SatinAlmaOnaylandiBildirimiGonder` |
| 19 | CEK_VADE_YAKLASTI | Çek Vadesi Yaklaştı | Finans | `CekVadeYaklastiBildirimiGonder` |
| 20 | SENET_VADE_YAKLASTI | Senet Vadesi Yaklaştı | Finans | `SenetVadeYaklastiBildirimiGonder` |
| 21 | YUKSEK_NAKIT_ISLEM | Yüksek Tutarlı Nakit İşlem | Finans | `YuksekNakitIslemBildirimiGonder` |
| 22 | ODEME_BEKLIYOR | Ödeme Bekliyor | Finans | `OdemeBekliyorBildirimiGonder` |
| 23 | ETICARET_YENI_SIPARIS | E-Ticaret Yeni Sipariş | E-Ticaret | `ETicaretYeniSiparisBildirimiGonder` |
| 24 | ETICARET_IADE | E-Ticaret İade Talebi | E-Ticaret | `ETicaretIadeBildirimiGonder` |
| 25 | FATURA_SILINDI | Fatura Silindi | Belge | `FaturaSilindiBildirimiGonder` |
| 26 | IRSALIYE_SILINDI | İrsaliye Silindi | Belge | `IrsaliyeSilindiBildirimiGonder` |
| 27 | SIPARIS_SILINDI | Sipariş Silindi | Belge | `SiparisSilindiBildirimiGonder` |
| 28 | SISTEM_HATA | Sistem Hatası | Sistem | `SistemHatasiBildirimiGonder` |
| 29 | SISTEM_UYARI | Sistem Uyarısı | Sistem | `SistemUyarisiBildirimiGonder` |
| 30 | KULLANICI_GIRIS | Kullanıcı Girişi | Sistem | `KullaniciGirisBildirimiGonder` |
| 31 | DUYURU | Genel Duyuru | Genel | `DuyuruBildirimiGonder` |
| 32 | ANLIK_MESAJ | Anlık Mesaj | Genel | `AnlikMesajBildirimiGonder` |

---

## 📋 GÖREV BİLDİRİMLERİ

### 1. GOREV_ATANDI - Yeni Görev Atandı
```
📋 *YENİ GÖREV*
================================
📌 *Görev:* {Görev Başlığı}
📝 *Açıklama:* {Görev Açıklaması}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 2. GOREV_HATIRLATMA - Görev Hatırlatması
```
⏰ *GÖREV HATIRLATMA*
================================
📌 *Görev:* {Görev Başlığı}
📅 *Bitiş Tarihi:* {dd.MM.yyyy HH:mm}
================================
```

### 3. GOREV_TAMAMLANDI - Görev Tamamlandı
```
✅ *GÖREV TAMAMLANDI*
================================
📌 *Görev:* {Görev Başlığı}
👤 *Tamamlayan:* {Personel Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 4. GOREV_ACIL - Acil Görev
```
🚨 *ACİL GÖREV*
================================
📌 *Görev:* {Görev Başlığı}
📝 *Açıklama:* {Görev Açıklaması}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

---

## 📦 SİPARİŞ BİLDİRİMLERİ

### 5. SIPARIS_YENI - Yeni Sipariş
```
🛒 *YENİ SİPARİŞ*
================================
📋 *Sipariş No:* {Sipariş No}
🏢 *Müşteri:* {Müşteri Adı}
💰 *Tutar:* {Tutar} TL
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 6. SIPARIS_ONAYLANDI - Sipariş Onaylandı
```
✅ *SİPARİŞ ONAYLANDI*
================================
📋 *Sipariş No:* {Sipariş No}
🏢 *Müşteri:* {Müşteri Adı}
👤 *Onaylayan:* {Personel Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 7. SIPARIS_IPTAL - Sipariş İptal Edildi
```
❌ *SİPARİŞ İPTAL EDİLDİ*
================================
📋 *Sipariş No:* {Sipariş No}
🏢 *Müşteri:* {Müşteri Adı}
📝 *Neden:* {İptal Nedeni}
👤 *İptal Eden:* {Personel Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 8. SIPARIS_SEVK - Sipariş Sevk Edildi
```
🚚 *SİPARİŞ SEVK EDİLDİ*
================================
📋 *Sipariş No:* {Sipariş No}
🏢 *Müşteri:* {Müşteri Adı}
📦 *Kargo:* {Kargo Firması}
🔢 *Takip No:* {Takip Numarası}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

---

## 🏭 ÜRETİM BİLDİRİMLERİ

### 9. URETIM_BASLADI - Üretim Başladı
```
🏭 *ÜRETİM BAŞLADI*
================================
📋 *Evrak No:* {Evrak No}
📦 *Ürün:* {Ürün Adı}
📊 *Miktar:* {Miktar}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 10. URETIM_ASAMA_TAMAMLANDI - Üretim Aşaması Tamamlandı
```
🔄 *ÜRETİM AŞAMASI TAMAMLANDI*
================================
📋 *Evrak No:* {Evrak No}
📦 *Ürün:* {Ürün Adı}
🔄 *Aşama:* {Aşama Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 11. URETIM_TAMAMLANDI - Üretim Tamamlandı
```
✅ *ÜRETİM TAMAMLANDI*
================================
📋 *Evrak No:* {Evrak No}
📦 *Ürün:* {Ürün Adı}
📊 *Miktar:* {Miktar}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 12. URETIM_GECIKME - Üretim Gecikmesi
```
⚠️ *ÜRETİM GECİKMESİ*
================================
📋 *Evrak No:* {Evrak No}
📦 *Ürün:* {Ürün Adı}
⏰ *Geciken Gün:* {Gün Sayısı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 13. URETIM_FIRE - Üretim Fire Bildirimi
```
🔥 *ÜRETİM FİRE BİLDİRİMİ*
================================
📋 *Evrak No:* {Evrak No}
📦 *Ürün:* {Ürün Adı}
📊 *Fire Miktarı:* {Miktar}
📝 *Neden:* {Fire Nedeni}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 14. URETIM_ONAY_BEKLIYOR - Üretim Onayı Bekliyor
```
⏳ *ÜRETİM ONAYI BEKLİYOR*
================================
📋 *Evrak No:* {Evrak No}
🔄 *Aşama:* {Aşama Adı}
📦 *Ürün:* {Ürün Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
Lütfen onayınızı verin.
```

---

## 📊 STOK BİLDİRİMLERİ

### 15. STOK_KRITIK - Kritik Stok Seviyesi
```
⚠️ *KRİTİK STOK SEVİYESİ*
================================
📦 *Stok Kodu:* {Stok Kodu}
📋 *Stok Adı:* {Stok Adı}
📊 *Mevcut:* {Mevcut Miktar}
🔴 *Kritik Seviye:* {Kritik Seviye}
================================
```

### 16. STOK_FIYAT_DUSUK - Stok Fiyatı Maliyetin Altında
```
💰 *STOK FİYATI MALİYETİN ALTINDA*
================================
📦 *Stok:* {Stok Kodu} - {Stok Adı}
💵 *Satış Fiyatı:* {Fiyat} TL
📉 *Maliyet:* {Maliyet} TL
================================
```

### 17. SATIN_ALMA_TALEP - Satın Alma Talebi
```
🛒 *SATIN ALMA TALEBİ*
================================
📦 *Hammadde:* {Stok Kodu} - {Stok Adı}
📊 *Miktar:* {Miktar}
👤 *Talep Eden:* {Personel Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 18. SATIN_ALMA_ONAYLANDI - Satın Alma Onaylandı
```
✅ *SATIN ALMA ONAYLANDI*
================================
📦 *Hammadde:* {Stok Kodu} - {Stok Adı}
📊 *Miktar:* {Miktar}
🏢 *Tedarikçi:* {Tedarikçi Adı}
👤 *Onaylayan:* {Personel Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

---

## 💰 FİNANS BİLDİRİMLERİ

### 19. CEK_VADE_YAKLASTI - Çek Vadesi Yaklaştı
```
📅 *ÇEK VADESİ YAKLASTI*
================================
📋 *Evrak No:* {Evrak No}
🏢 *Firma:* {Firma Adı}
💰 *Tutar:* {Tutar} TL
📅 *Vade:* {dd.MM.yyyy}
================================
```

### 20. SENET_VADE_YAKLASTI - Senet Vadesi Yaklaştı
```
📅 *SENET VADESİ YAKLASTI*
================================
📋 *Evrak No:* {Evrak No}
🏢 *Firma:* {Firma Adı}
💰 *Tutar:* {Tutar} TL
📅 *Vade:* {dd.MM.yyyy}
================================
```

### 21. YUKSEK_NAKIT_ISLEM - Yüksek Tutarlı Nakit İşlem
```
💵 *YÜKSEK TUTARLI NAKİT İŞLEM*
================================
📋 *İşlem Tipi:* {İşlem Tipi}
💰 *Tutar:* {Tutar} TL
👤 *Kullanıcı:* {Kullanıcı Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 22. ODEME_BEKLIYOR - Ödeme Bekliyor
```
💳 *ÖDEME BEKLİYOR*
================================
🏢 *Firma:* {Firma Adı}
💰 *Tutar:* {Tutar} TL
📅 *Vade:* {dd.MM.yyyy}
================================
```

---

## 🛍️ E-TİCARET BİLDİRİMLERİ

### 23. ETICARET_YENI_SIPARIS - E-Ticaret Yeni Sipariş
```
🛍️ *YENİ E-TİCARET SİPARİŞİ*
================================
📋 *Sipariş No:* {Sipariş No}
🏪 *Platform:* {Platform Adı}
👤 *Müşteri:* {Müşteri Adı}
📍 *Şehir:* {Şehir}

📦 *ÜRÜNLER:*
{Ürün Listesi}

💰 *Toplam:* {Toplam Tutar} TL
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 24. ETICARET_IADE - E-Ticaret İade Talebi
```
🔄 *E-TİCARET İADE TALEBİ*
================================
📋 *Sipariş No:* {Sipariş No}
👤 *Müşteri:* {Müşteri Adı}
📦 *Ürün:* {Ürün Adı}
📝 *Neden:* {İade Nedeni}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

---

## 📄 BELGE BİLDİRİMLERİ

### 25. FATURA_SILINDI - Fatura Silindi
```
🗑️ *FATURA SİLİNDİ*
================================
📋 *Evrak No:* {Evrak No}
🏢 *Firma:* {Firma Adı}
💰 *Tutar:* {Tutar} TL
👤 *Silen:* {Kullanıcı Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 26. IRSALIYE_SILINDI - İrsaliye Silindi
```
🗑️ *İRSALİYE SİLİNDİ*
================================
📋 *Evrak No:* {Evrak No}
🏢 *Firma:* {Firma Adı}
👤 *Silen:* {Kullanıcı Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 27. SIPARIS_SILINDI - Sipariş Silindi
```
🗑️ *SİPARİŞ SİLİNDİ*
================================
📋 *Evrak No:* {Evrak No}
🏢 *Firma:* {Firma Adı}
👤 *Silen:* {Kullanıcı Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

---

## ⚙️ SİSTEM BİLDİRİMLERİ

### 28. SISTEM_HATA - Sistem Hatası
```
🔴 *SİSTEM HATASI*
================================
📋 *Modül:* {Modül Adı}
❌ *Hata:* {Hata Mesajı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 29. SISTEM_UYARI - Sistem Uyarısı
```
⚠️ *SİSTEM UYARISI*
================================
📋 *Konu:* {Konu}
📝 *Açıklama:* {Açıklama}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

### 30. KULLANICI_GIRIS - Kullanıcı Girişi
```
🔑 *KULLANICI GİRİŞİ*
================================
👤 *Kullanıcı:* {Kullanıcı Adı}
💻 *Bilgisayar:* {Bilgisayar Adı}
📅 *Tarih:* {dd.MM.yyyy HH:mm}
================================
```

---

## 📢 GENEL BİLDİRİMLER

### 31. DUYURU - Genel Duyuru
```
📢 *DUYURU*
================================
📋 *{Duyuru Başlığı}*

{Duyuru İçeriği}
================================
📅 {dd.MM.yyyy HH:mm}
```

### 32. ANLIK_MESAJ - Anlık Mesaj
```
💬 *{Mesaj Başlığı}*
================================
{Mesaj İçeriği}
================================
📅 {dd.MM.yyyy HH:mm}
```

---

## 🔧 KULLANIM

Her bildirim tipi için `BildirimServisi.vb` modülündeki ilgili fonksiyonu çağırmanız yeterlidir:

```vbnet
' Örnek: Yeni Sipariş Bildirimi
BildirimServisi.SiparisYeniBildirimiGonder(sSiparisNo, sMusteriAdi, lTutar)

' Örnek: Kritik Stok Bildirimi
BildirimServisi.StokKritikBildirimiGonder(sStokKodu, sStokAdi, lMevcutMiktar, lKritikSeviye)

' Örnek: Görev Atama Bildirimi
BildirimServisi.GorevBildirimiGonder(nGorevID, nPersonelID, sBaslik, sAciklama, bAcil:=False)
```

---

## 📝 NOTLAR

1. Tüm mesajlar WhatsApp formatına uygun şekilde hazırlanmıştır (*bold* için yıldız kullanılır)
2. Emoji desteği mevcuttur ve her bildirim türü için uygun emojiler seçilmiştir
3. Mesaj şablonları `BildirimServisi.vb` dosyasında her fonksiyonun içinde tanımlanmıştır
4. Kullanıcı tercihleri `tbKullaniciBildirimTercihleri` tablosundan kontrol edilir
5. WhatsApp aktif olup olmadığı `tbSistemAyar` tablosundaki `WHATSAPP_AKTIF` değerine göre belirlenir

---

*Son Güncelleme: {Tarih}*
