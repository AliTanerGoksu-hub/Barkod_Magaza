using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessSmartDesktopAPI.Services
{
    public class LLMService
    {
        private readonly string _apiKey;
        private readonly string _apiUrl;
        private readonly string _model;
        private readonly HttpClient _httpClient;

        public LLMService(string apiKey, string apiUrl, string model)
        {
            _apiKey = apiKey;
            _apiUrl = apiUrl;
            _model = model;
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
            if (!string.IsNullOrEmpty(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            }
        }

        public bool IsConfigured => !string.IsNullOrEmpty(_apiKey);

        public async Task<string> ChatAsync(string systemPrompt, string userPrompt, int maxTokens = 1000)
        {
            if (!IsConfigured) return "";

            try
            {
                var request = new
                {
                    model = _model,
                    messages = new[]
                    {
                        new { role = "system", content = systemPrompt },
                        new { role = "user", content = userPrompt }
                    },
                    max_tokens = maxTokens,
                    temperature = 0.3
                };

                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(_apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    using var doc = JsonDocument.Parse(responseBody);
                    return doc.RootElement
                        .GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString() ?? "";
                }
                else
                {
                    var errorBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"[LLM] API Error {response.StatusCode}: {errorBody}");
                    return $"AI servisi hata verdi: {response.StatusCode}";
                }
            }
            catch (TaskCanceledException)
            {
                return "AI servisi zaman asimina ugradi.";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LLM] Exception: {ex.Message}");
                return $"AI servisi hatasi: {ex.Message}";
            }
        }

        public async Task<string> RiskAnaliziAsync(
            string firmaAdi, string kaynak, int riskSkor,
            decimal bakiye, decimal gecikmisBakiye, int gecikmisTaksit, int maxGecikmeGun,
            decimal krediLimiti, int bekleyenAdet, decimal bekleyenTutar, int ortOdemeSuresi)
        {
            var prompt = $@"Asagidaki musteri verilerini analiz et ve Turkce risk raporu olustur.

Musteri: {firmaAdi}
Tur: {(kaynak == "perakende" ? "Perakende Musteri" : "Toptan Cari Hesap")}
Risk Skoru: {riskSkor}/100
Toplam Bakiye: {bakiye:N2} TL
Geciken Bakiye: {gecikmisBakiye:N2} TL ({gecikmisTaksit} adet geciken taksit/fatura)
Max Gecikme Suresi: {maxGecikmeGun} gun
Kredi Limiti: {(krediLimiti > 0 ? krediLimiti.ToString("N2") + " TL" : "Tanimlanmamis")}
Bekleyen Siparis/Teslim: {bekleyenAdet} adet ({bekleyenTutar:N2} TL)
Ortalama Odeme Suresi: {ortOdemeSuresi} gun (vadeden sonra)

Rapor formati:
1. GENEL DURUM: (1-2 cumle)
2. RISK FAKTORLERI: (madde madde, varsa)
3. ONERILER: (3-5 madde, aksiyona yonelik)
4. SATIS KARARI: Yeni satis yapilmali mi? (Evet/Hayir/Sartli - neden?)";

            return await ChatAsync(
                "Sen bir ERP/POS risk analiz uzmansin. Turkce yaz. Kisa, net, aksiyona yonelik ol. Emoji kullanma.",
                prompt, 800);
        }

        public async Task<string> TahsilatPlaniAsync(string temsilciAdi, List<Dictionary<string, object>> musteriler)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Temsilci: {temsilciAdi}");
            sb.AppendLine($"Tarih: {DateTime.Now:dd.MM.yyyy}");
            sb.AppendLine($"Tahsilat yapilacak musteri sayisi: {musteriler.Count}");
            sb.AppendLine();

            foreach (var m in musteriler)
            {
                sb.AppendLine($"- {m.GetValueOrDefault("firmaAd", "")} | Bakiye: {m.GetValueOrDefault("bakiye", 0)} TL | Gecikme: {m.GetValueOrDefault("gecikmeGun", 0)} gun | Risk: {m.GetValueOrDefault("riskSeviye", "")}");
            }

            var prompt = $@"Asagidaki tahsilat listesini analiz et ve Turkce tahsilat plani olustur.

{sb}

Plan formati:
1. GUNUN OZETI: Kac musteri, toplam ne kadar bakiye, oncelik sirasi
2. ONCELIKLI 3 MUSTERI: Neden once bunlar? Hangi strateji?
3. GENEL TAVSIYELER: Gorusme taktikleri, dikkat edilecekler";

            return await ChatAsync(
                "Sen bir tahsilat planlama uzmansin. Turkce yaz. Pratik, sahada uygulanabilir onerilerde bulun.",
                prompt, 800);
        }

        public async Task<string> SatisOneriAsync(string firmaAdi, List<Dictionary<string, object>> sonSiparisler)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Musteri: {firmaAdi}");
            sb.AppendLine("Son Siparisler:");
            foreach (var s in sonSiparisler)
            {
                sb.AppendLine($"- {s.GetValueOrDefault("tarih", "")} | {s.GetValueOrDefault("stokAdi", "")} | {s.GetValueOrDefault("miktar", 0)} adet | {s.GetValueOrDefault("tutar", 0)} TL");
            }

            var prompt = $@"Asagidaki musterinin satin alma gecmisini analiz et.

{sb}

Onerilerin:
1. Bu musteriye hangi urunler teklif edilmeli? (3-5 urun)
2. Her urun icin neden? (kisa aciklama)
3. Tahmini siparis miktari ve zamanlama
4. Dikkat edilecek noktalar (iade gecmisi, mevsimsellik vb.)";

            return await ChatAsync(
                "Sen bir satis danismanisin. Turkce yaz. Veri odakli, pratik oneriler ver.",
                prompt, 600);
        }

        public async Task<string> GunSonuOzetAsync(
            decimal toplamSatis, decimal toplamTahsilat, int siparisSayisi,
            int yeniMusteri, decimal enBuyukSatis, string enBuyukSatisFirma)
        {
            var prompt = $@"Bugunun is verilerini ozetle:

Tarih: {DateTime.Now:dd.MM.yyyy}
Toplam Satis: {toplamSatis:N2} TL
Toplam Tahsilat: {toplamTahsilat:N2} TL
Siparis Sayisi: {siparisSayisi}
Yeni Musteri: {yeniMusteri}
En Buyuk Satis: {enBuyukSatis:N2} TL ({enBuyukSatisFirma})

Ozetle:
1. GUNUN PERFORMANSI: (2-3 cumle)
2. DIKKAT GEREKTIREN NOKTALAR: (varsa)
3. YARIN ICIN AKSIYON: (2-3 madde)";

            return await ChatAsync(
                "Sen bir is analisti ve yonetici asistanisin. Turkce yaz. Kisa, onemli noktalara odaklan.",
                prompt, 500);
        }
    }
}
