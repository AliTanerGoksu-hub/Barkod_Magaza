using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BusinessSmartDesktopAPI.Services
{
    public class AIService
    {
        private readonly string _apiKey;
        private readonly string _apiUrl;
        private readonly string _model;
        private static readonly HttpClient _httpClient = new HttpClient();

        public AIService(IConfiguration config)
        {
            _apiKey = config["AI:ApiKey"] ?? "";
            _apiUrl = config["AI:ApiUrl"] ?? "https://api.openai.com/v1/chat/completions";
            _model = config["AI:Model"] ?? "gpt-4o-mini";
        }

        public bool IsConfigured => !string.IsNullOrEmpty(_apiKey);

        public async Task<string> GenerateAsync(string systemPrompt, string userPrompt)
        {
            if (!IsConfigured) return "AI servisi yapilandirmadi. appsettings.json icinde AI:ApiKey tanimlayin.";

            try
            {
                var requestBody = new
                {
                    model = _model,
                    messages = new[]
                    {
                        new { role = "system", content = systemPrompt },
                        new { role = "user", content = userPrompt }
                    },
                    max_tokens = 1000,
                    temperature = 0.3
                };

                var request = new HttpRequestMessage(HttpMethod.Post, _apiUrl);
                request.Headers.Add("Authorization", $"Bearer {_apiKey}");
                request.Content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

                var response = await _httpClient.SendAsync(request);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return $"AI servisi hatasi: {response.StatusCode}";

                using var doc = JsonDocument.Parse(responseBody);
                var content = doc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

                return content ?? "Yanit alinamadi";
            }
            catch (Exception ex)
            {
                return $"AI servisi hatasi: {ex.Message}";
            }
        }

        public async Task<(string aciklama, string[] oneriler)> RiskAciklamaAsync(
            string firmaAd, decimal bakiye, decimal krediLimiti, int gecikmeGun,
            decimal odemeDisipilin, decimal iadeOrani, int siparisSikligi, decimal limitKullanim)
        {
            var systemPrompt = @"Sen bir ERP sisteminde cari risk analiz asistanisin. 
Turkce yanit ver. Kisa ve net ol. Skor nedenini acikla, aksiyon oner.
Yaniti su formatta ver:
ACIKLAMA: (2-3 cumle risk aciklamasi)
ONERI1: (ilk oneri)
ONERI2: (ikinci oneri)
ONERI3: (ucuncu oneri)";

            var userPrompt = $@"Firma: {firmaAd}
Bakiye: {bakiye:N2} TL
Kredi Limiti: {krediLimiti:N2} TL
Limit Kullanim: %{limitKullanim * 100:N0}
Gecikme Gun: {gecikmeGun}
Odeme Disiplini: %{odemeDisipilin * 100:N0}
Iade Orani: %{iadeOrani * 100:N0}
Son 90 Gun Siparis: {siparisSikligi}

Bu musterinin risk durumunu dogal dille acikla.";

            var result = await GenerateAsync(systemPrompt, userPrompt);

            var aciklama = "";
            var oneriler = new System.Collections.Generic.List<string>();

            foreach (var line in result.Split('\n'))
            {
                var trimmed = line.Trim();
                if (trimmed.StartsWith("ACIKLAMA:"))
                    aciklama = trimmed.Substring(9).Trim();
                else if (trimmed.StartsWith("ONERI"))
                {
                    var idx = trimmed.IndexOf(':');
                    if (idx > 0)
                        oneriler.Add(trimmed.Substring(idx + 1).Trim());
                }
            }

            if (string.IsNullOrEmpty(aciklama)) aciklama = result;

            return (aciklama, oneriler.ToArray());
        }

        public async Task<string> GunSonuOzetAsync(
            decimal toplamSatis, decimal toplamTahsilat, int faturaSayisi,
            string enCokSatanUrunler, string aksayanTahsilatlar)
        {
            var systemPrompt = @"Sen bir ERP sisteminde yonetici ozet asistanisin.
Turkce yanit ver. Kisa, net ve aksiyona yonelik ol.
Gun sonu ozetini 3-5 cumle ile yaz, sonra 2-3 aksiyon onerisi ver.";

            var userPrompt = $@"Gun Sonu Verileri:
Toplam Satis: {toplamSatis:N2} TL ({faturaSayisi} fatura)
Toplam Tahsilat: {toplamTahsilat:N2} TL
En Cok Satan Urunler: {enCokSatanUrunler}
Aksayan Tahsilatlar: {aksayanTahsilatlar}

Yonetici icin kisa ozet ve aksiyon onerileri yaz.";

            return await GenerateAsync(systemPrompt, userPrompt);
        }

        public async Task<string> SatisOneriAsync(string firmaAd, string sonSiparisler)
        {
            var systemPrompt = @"Sen bir ERP sisteminde satis oneri asistanisin.
Turkce yanit ver. Her oneriyi su formatta ver:
ONERI: urunAdi | neden | tahminMiktar
Ornek: ONERI: Erkek T-Shirt Basic | Son 3 sipariste aldi | 50";

            var userPrompt = $@"Firma: {firmaAd}
Son Siparisler:
{sonSiparisler}

Bu musteriye hangi urunleri teklif etmeliyiz? Max 5 oneri ver.";

            return await GenerateAsync(systemPrompt, userPrompt);
        }

        public async Task<string> TahsilatStratejiAsync(string firmaAd, decimal bakiye, int gecikmeGun, string sonOdemeler)
        {
            var systemPrompt = @"Sen bir ERP sisteminde tahsilat strateji asistanisin.
Turkce yanit ver. Kisa ve aksiyona yonelik ol. 2-3 cumle strateji oner.";

            var userPrompt = $@"Firma: {firmaAd}
Bakiye: {bakiye:N2} TL
Gecikme: {gecikmeGun} gun
Son Odemeler: {sonOdemeler}

Bu musteri icin tahsilat stratejisi oner.";

            return await GenerateAsync(systemPrompt, userPrompt);
        }

        public async Task<string> UrunAciklamaTemizleAsync(string mevcutAciklama)
        {
            var systemPrompt = @"Sen bir e-ticaret urun aciklama editoriisun.
Turkce calis. Yasakli ifade, gereksiz karakter, hatali baslik, kopya ifade tespit et.
Temiz versiyonu ve tespitlerini ver:
TEMIZ: (temizlenmis aciklama)
TESPIT1: (tespit edilen sorun)
TESPIT2: ...
SKOR: (0-100 arasi kalite skoru)";

            return await GenerateAsync(systemPrompt, $"Urun Aciklamasi:\n{mevcutAciklama}");
        }
    }
}
