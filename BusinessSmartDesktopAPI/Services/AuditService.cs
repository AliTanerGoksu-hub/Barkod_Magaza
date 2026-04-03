using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BusinessSmartDesktopAPI.Services
{
    public class AuditService
    {
        private readonly string _connStr;

        public AuditService(IConfiguration config)
        {
            _connStr = config["SqlConnectionString"] ?? "";
        }

        public async Task LogAsync(int kullaniciId, string kullaniciAdi, string islem,
            string modul, string? detay = null, string? aiModel = null, string platform = "desktop")
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                await conn.OpenAsync();
                var cmd = new SqlCommand(@"
                    INSERT INTO tbAuditLog (nKullaniciID, sKullaniciAdi, sIslem, sModul, sDetay, sAIModel, sPlatform)
                    VALUES (@kid, @kadi, @islem, @modul, @detay, @model, @platform)", conn);
                cmd.Parameters.AddWithValue("@kid", kullaniciId);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi ?? "");
                cmd.Parameters.AddWithValue("@islem", islem);
                cmd.Parameters.AddWithValue("@modul", modul);
                cmd.Parameters.AddWithValue("@detay", (object?)detay ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@model", (object?)aiModel ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@platform", platform);
                await cmd.ExecuteNonQueryAsync();
            }
            catch { /* Audit log hatasi uygulmayi engellemez */ }
        }
    }
}
