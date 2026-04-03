using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BusinessSmartDesktopAPI.Services
{
    public class RiskService
    {
        private readonly string _connStr;

        public RiskService(IConfiguration config)
        {
            _connStr = config["SqlConnectionString"] ?? "";
        }

        public class RiskSonuc
        {
            public int FirmaId { get; set; }
            public string FirmaAd { get; set; } = "";
            public int Skor { get; set; }
            public string Seviye { get; set; } = "";
            public decimal Bakiye { get; set; }
            public decimal VadesiGecmisBakiye { get; set; }
            public decimal KrediLimiti { get; set; }
            public int GecikmeGun { get; set; }
            public decimal OdemeDisipilin { get; set; }
            public decimal IadeOrani { get; set; }
            public int SiparisSikligi { get; set; }
            public decimal LimitKullanim { get; set; }
        }

        public async Task<RiskSonuc?> RiskHesaplaAsync(int firmaId)
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                await conn.OpenAsync();

                // View'dan veri cek
                var cmd = new SqlCommand(@"
                    SELECT FirmaAd, KrediLimiti, VadeGun, Bakiye, VadesiGecmisBakiye,
                           ISNULL(MaxGecikmeGun, 0) AS MaxGecikmeGun, Son90GunSiparis
                    FROM vw_AI_CariRiskVerisi WHERE nFirmaID = @firmaId", conn);
                cmd.Parameters.AddWithValue("@firmaId", firmaId);

                using var reader = await cmd.ExecuteReaderAsync();
                if (!await reader.ReadAsync()) return null;

                var sonuc = new RiskSonuc
                {
                    FirmaId = firmaId,
                    FirmaAd = reader["FirmaAd"]?.ToString() ?? "",
                    KrediLimiti = reader["KrediLimiti"] != DBNull.Value ? Convert.ToDecimal(reader["KrediLimiti"]) : 0,
                    Bakiye = reader["Bakiye"] != DBNull.Value ? Convert.ToDecimal(reader["Bakiye"]) : 0,
                    VadesiGecmisBakiye = reader["VadesiGecmisBakiye"] != DBNull.Value ? Convert.ToDecimal(reader["VadesiGecmisBakiye"]) : 0,
                    GecikmeGun = reader["MaxGecikmeGun"] != DBNull.Value ? Convert.ToInt32(reader["MaxGecikmeGun"]) : 0,
                    SiparisSikligi = reader["Son90GunSiparis"] != DBNull.Value ? Convert.ToInt32(reader["Son90GunSiparis"]) : 0
                };
                reader.Close();

                // Limit kullanim orani
                sonuc.LimitKullanim = sonuc.KrediLimiti > 0 ? sonuc.Bakiye / sonuc.KrediLimiti : 0;
                if (sonuc.LimitKullanim < 0) sonuc.LimitKullanim = 0;
                if (sonuc.LimitKullanim > 1) sonuc.LimitKullanim = 1;

                // Odeme disiplini: son 12 ayda zamaninda odenen fatura orani
                var cmdOdeme = new SqlCommand(@"
                    SELECT 
                        COUNT(*) AS ToplamFatura,
                        SUM(CASE WHEN DATEDIFF(DAY, h.dteValorTarihi, 
                            ISNULL((SELECT MIN(h2.dteIslemTarihi) FROM tbFirmaHareketi h2 
                                    WHERE h2.nFirmaID = h.nFirmaID AND h2.sBorcAlacak = 'A' 
                                    AND h2.dteIslemTarihi >= h.dteIslemTarihi), GETDATE())) <= 7 
                             THEN 1 ELSE 0 END) AS ZamanindaOdenen
                    FROM tbFirmaHareketi h
                    WHERE h.nFirmaID = @firmaId AND h.sBorcAlacak = 'B'
                    AND h.dteIslemTarihi >= DATEADD(MONTH, -12, GETDATE())", conn);
                cmdOdeme.Parameters.AddWithValue("@firmaId", firmaId);

                using var readerOdeme = await cmdOdeme.ExecuteReaderAsync();
                if (await readerOdeme.ReadAsync())
                {
                    var toplamFatura = Convert.ToInt32(readerOdeme["ToplamFatura"]);
                    var zamaninda = Convert.ToInt32(readerOdeme["ZamanindaOdenen"]);
                    sonuc.OdemeDisipilin = toplamFatura > 0 ? (decimal)zamaninda / toplamFatura : 1;
                }
                readerOdeme.Close();

                // Risk skoru hesapla (0-100, dusuk = riskli)
                int skor = 100;

                // Gecikme gunu (-2 puan / gun, max -40)
                skor -= Math.Min(sonuc.GecikmeGun * 2, 40);

                // Limit kullanimi (-20 puan max)
                if (sonuc.LimitKullanim > 0.9m) skor -= 20;
                else if (sonuc.LimitKullanim > 0.7m) skor -= 10;
                else if (sonuc.LimitKullanim > 0.5m) skor -= 5;

                // Odeme disiplini (-20 puan max)
                skor -= (int)((1 - sonuc.OdemeDisipilin) * 20);

                // Vadesi gecmis bakiye (-10 puan max)
                if (sonuc.VadesiGecmisBakiye > sonuc.KrediLimiti * 0.5m && sonuc.KrediLimiti > 0) skor -= 10;
                else if (sonuc.VadesiGecmisBakiye > 0) skor -= 5;

                // Siparis sikligi (bonus +5)
                if (sonuc.SiparisSikligi >= 5) skor += 5;

                skor = Math.Max(0, Math.Min(100, skor));
                sonuc.Skor = skor;
                sonuc.Seviye = skor >= 70 ? "guvenli" : skor >= 40 ? "dikkat" : "kritik";

                // Risk skorunu kaydet
                var cmdSave = new SqlCommand(@"
                    IF EXISTS (SELECT 1 FROM tbRiskSkoru WHERE nFirmaID = @firmaId)
                        UPDATE tbRiskSkoru SET nRiskSkoru=@skor, sRiskSeviye=@seviye, lToplamBakiye=@bakiye,
                            lVadesiGecmisBakiye=@vadesi, nMaxGecikmeGun=@gecikme, nOdemeDisipilin=@odeme,
                            nSiparisSikligi=@siparis, nLimitKullanim=@limit, dteHesaplamaTarihi=GETDATE()
                        WHERE nFirmaID = @firmaId
                    ELSE
                        INSERT INTO tbRiskSkoru (nFirmaID, nRiskSkoru, sRiskSeviye, lToplamBakiye, lVadesiGecmisBakiye,
                            nMaxGecikmeGun, nOdemeDisipilin, nSiparisSikligi, nLimitKullanim)
                        VALUES (@firmaId, @skor, @seviye, @bakiye, @vadesi, @gecikme, @odeme, @siparis, @limit)", conn);
                cmdSave.Parameters.AddWithValue("@firmaId", firmaId);
                cmdSave.Parameters.AddWithValue("@skor", sonuc.Skor);
                cmdSave.Parameters.AddWithValue("@seviye", sonuc.Seviye);
                cmdSave.Parameters.AddWithValue("@bakiye", sonuc.Bakiye);
                cmdSave.Parameters.AddWithValue("@vadesi", sonuc.VadesiGecmisBakiye);
                cmdSave.Parameters.AddWithValue("@gecikme", sonuc.GecikmeGun);
                cmdSave.Parameters.AddWithValue("@odeme", sonuc.OdemeDisipilin);
                cmdSave.Parameters.AddWithValue("@siparis", sonuc.SiparisSikligi);
                cmdSave.Parameters.AddWithValue("@limit", sonuc.LimitKullanim);

                try { await cmdSave.ExecuteNonQueryAsync(); } catch { /* tablo yoksa engelleme */ }

                return sonuc;
            }
            catch
            {
                return null;
            }
        }

        public async Task<string> SistemAyarGetirAsync(string ayarKodu)
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                await conn.OpenAsync();
                var cmd = new SqlCommand("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu=@kod", conn);
                cmd.Parameters.AddWithValue("@kod", ayarKodu);
                var result = await cmd.ExecuteScalarAsync();
                return result?.ToString() ?? "0";
            }
            catch { return "0"; }
        }

        public async Task<bool> YetkiKontrolAsync(int kullaniciId, string formAdi)
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                await conn.OpenAsync();
                var cmd = new SqlCommand(@"
                    SELECT ISNULL(y.bYetki, f.DefaultYetki)
                    FROM aEmirForms f
                    LEFT JOIN aPersonelYetki y ON f.nFormID = y.nFormID AND y.nPersonelID = @kid
                    WHERE f.Form = @form", conn);
                cmd.Parameters.AddWithValue("@kid", kullaniciId);
                cmd.Parameters.AddWithValue("@form", formAdi);
                var result = await cmd.ExecuteScalarAsync();
                return result != null && Convert.ToInt32(result) > 0;
            }
            catch { return false; }
        }
    }
}
