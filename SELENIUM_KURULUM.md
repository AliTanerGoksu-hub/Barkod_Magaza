# Selenium WebDriver Kurulum Rehberi

## 📦 Gerekli NuGet Paketleri

Visual Studio'da **NuGet Package Manager** ile şu paketleri yükleyin:

```
Install-Package Selenium.WebDriver -Version 4.27.0
Install-Package Selenium.WebDriver.ChromeDriver
```

Veya **NuGet Package Manager Console** ile:

1. `Tools` → `NuGet Package Manager` → `Package Manager Console`
2. Şu komutları çalıştırın:
   ```
   Install-Package Selenium.WebDriver
   Install-Package Selenium.WebDriver.ChromeDriver
   ```

## 🌐 Chrome Tarayıcı

Selenium, Chrome tarayıcısını kullanır. Bilgisayarınızda **Google Chrome** yüklü olmalıdır.

ChromeDriver versiyonu otomatik olarak Chrome versiyonunuzla eşleşir.

## 📁 Eklenen Dosyalar

1. **TrendyolSeleniumScraperService.vb** - Selenium tabanlı scraper servisi
2. **packages.config** - Selenium paketleri eklendi
3. **BARKOD_MAGAZA.vbproj** - Selenium referansları eklendi
4. **frm_TrendyolKategoriEslestir.vb** - Selenium kullanacak şekilde güncellendi

## 🚀 Nasıl Çalışır?

1. "Trendyol" checkbox'ı seçiliyken eşleştirme başlatıldığında
2. Selenium otomatik olarak Chrome tarayıcı başlatır (headless - arka planda)
3. Python scraper ile aynı mantıkta çalışır:
   - Barkod ile Trendyol'da arama yapar
   - JavaScript render eder (bu kritik!)
   - Ürün sayfalarını ziyaret eder
   - Token overlap / benzerlik skoru hesaplar
4. İşlem bittiğinde tarayıcı otomatik kapatılır

## ⚙️ Headless vs Görünür Mod

Varsayılan olarak **headless** (arka planda) çalışır. 

Eğer tarayıcıyı görmek isterseniz, `TrendyolSeleniumScraperService.vb` dosyasında:

```vb
' Headless modu kapatmak için:
_seleniumScraper = New TrendyolSeleniumScraperService(headless:=False)
```

## 🔧 Sorun Giderme

### ChromeDriver Hatası
Eğer "ChromeDriver not found" hatası alırsanız:
1. NuGet paketlerini yeniden yükleyin
2. `packages\Selenium.WebDriver.ChromeDriver.xxx\driver\win32\chromedriver.exe` dosyasının var olduğunu kontrol edin

### Chrome Versiyon Uyumsuzluğu
Chrome güncellendiyse ChromeDriver'ı da güncelleyin:
```
Update-Package Selenium.WebDriver.ChromeDriver
```

## 📊 Beklenen Sonuç

Python scraper'da olduğu gibi:
- Token overlap eşleşmesi: `skor=0.850 | token`
- Barkod eşleşmesi: `skor=1.0 | barcode`
- Benzerlik eşleşmesi: `skor=0.60+ | score`
