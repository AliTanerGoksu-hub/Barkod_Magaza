# UltraMsg WhatsApp Entegrasyonu Kılavuzu

## Genel Bakış
Bu kılavuz, Barkod Mağaza uygulamasında UltraMsg API kullanarak WhatsApp mesajları göndermeyi açıklamaktadır.

## Gerekli Bilgiler (UltraMsg Panel'den)

| Ayar | Değer | Açıklama |
|------|-------|----------|
| Instance ID | `instance157897` | UltraMsg panelinden alınır |
| Token | `4s5wk3zkxn17ws9` | API erişim tokeni |
| API URL | `https://api.ultramsg.com/instance157897/messages/chat` | Mesaj gönderim endpoint'i |

## Kurulum Adımları

### 1. SQL Server'da Ayarları Ekleyin
`SQL_Scripts/ULTRAMSG_WHATSAPP_AYARLARI.sql` dosyasını SQL Server'da çalıştırın.

Veya manuel olarak:
```sql
-- WhatsApp'ı aktif et
INSERT INTO tbSistemAyar (sAnahtar, sDeger, sAciklama) 
VALUES ('WHATSAPP_AKTIF', '1', 'WhatsApp bildirim aktif/pasif')

-- Instance ID
INSERT INTO tbSistemAyar (sAnahtar, sDeger, sAciklama) 
VALUES ('ULTRAMSG_INSTANCE_ID', 'instance157897', 'UltraMsg Instance ID')

-- Token
INSERT INTO tbSistemAyar (sAnahtar, sDeger, sAciklama) 
VALUES ('ULTRAMSG_TOKEN', '4s5wk3zkxn17ws9', 'UltraMsg API Token')
```

### 2. VB.NET Kodunda Kullanım

#### Bağlantı Testi
```vb
' Bağlantıyı test et
Dim sonuc As String = BildirimServisi.WhatsAppBaglantisiTest()
MessageBox.Show(sonuc)
```

#### Test Mesajı Gönder
```vb
' Test mesajı gönder
Dim sonuc As String = BildirimServisi.WhatsAppTestMesajiGonder("905551234567")
MessageBox.Show(sonuc)

' Özel mesaj ile test
Dim sonuc2 As String = BildirimServisi.WhatsAppTestMesajiGonder("905551234567", "Merhaba, bu test mesajıdır!")
MessageBox.Show(sonuc2)
```

#### Hızlı Mesaj Gönder
```vb
' Telefon numarasına direkt mesaj gönder
BildirimServisi.HizliBildirim("5551234567", "Siparisiniz hazırlandı!")
```

#### Kullanıcıya Bildirim Gönder
```vb
' Kullanıcı ID'sine göre bildirim
BildirimServisi.Gonder("SIPARIS_YENI", "Yeni sipariş alındı!", nKullaniciID)
```

#### Ayarları Kaydet
```vb
' Ayarları programatik olarak kaydet
BildirimServisi.UltraMsgAyarlariKaydet("instance157897", "4s5wk3zkxn17ws9")
```

## Telefon Numarası Formatı
Sistem otomatik olarak telefon numaralarını formatlar:

| Girilen | Dönüştürülen |
|---------|--------------|
| `5551234567` | `+905551234567` |
| `05551234567` | `+905551234567` |
| `905551234567` | `+905551234567` |
| `+905551234567` | `+905551234567` |

## Hata Ayıklama

### Yaygın Hatalar

1. **"ULTRAMSG_INSTANCE_ID ayari eksik"**
   - tbSistemAyar tablosuna ULTRAMSG_INSTANCE_ID ekleyin

2. **"ULTRAMSG_TOKEN ayari eksik"**
   - tbSistemAyar tablosuna ULTRAMSG_TOKEN ekleyin

3. **"WhatsApp aktif degil"**
   - WHATSAPP_AKTIF değerini '1' yapın

4. **API yanıtında hata**
   - UltraMsg panelinden WhatsApp bağlantısını kontrol edin
   - Telefonunuzun internete bağlı olduğundan emin olun

### Log Kontrolü
```vb
' Debug logları Visual Studio Output penceresinde görüntülenir
Debug.WriteLine("WhatsApp log mesaji")
```

## UltraMsg Panel

- **Panel URL**: https://user.ultramsg.com
- **API Dökümanı**: https://docs.ultramsg.com

### Panel'de Yapılması Gerekenler
1. Hesap oluşturun veya giriş yapın
2. Yeni bir instance oluşturun
3. QR kodu telefonunuzla tarayarak WhatsApp'ı bağlayın
4. Instance ID ve Token bilgilerini kopyalayın
5. Bu bilgileri veritabanınıza kaydedin

## Veritabanı Tabloları

### tbSistemAyar
| Kolon | Tip | Açıklama |
|-------|-----|----------|
| nAyarID | INT | Primary Key |
| sAnahtar | NVARCHAR(100) | Ayar kodu |
| sDeger | NVARCHAR(500) | Ayar değeri |
| sAciklama | NVARCHAR(500) | Açıklama |

### tbBildirimLog
Gönderilen tüm bildirimler bu tabloya kaydedilir.

## İletişim
Sorun yaşarsanız UltraMsg destek ekibiyle iletişime geçin:
- https://ultramsg.com/contact
