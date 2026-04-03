using System;
using System.Data.SqlClient;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessSmartDesktopAPI.Services
{
    public class AuditService
    {
        private readonly string _connectionString;

        public AuditService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task LogAsync(string kullanici, string islem, string modul, object? detay = null, string? aiModel = null, string? ipAdres = null)
        {
            if (string.IsNullOrEmpty(_connectionString)) return;

            try
            {
                using var conn = new SqlConnection(_connectionString);
                await conn.OpenAsync();

                var sql = @"INSERT INTO tbAuditLog (sKullaniciAdi, sIslem, sModul, sDetay, sAIModel, sIPAdres, sPlatform)
                           VALUES (@kullanici, @islem, @modul, @detay, @aiModel, @ipAdres, 'api')";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kullanici", kullanici ?? "system");
                cmd.Parameters.AddWithValue("@islem", islem);
                cmd.Parameters.AddWithValue("@modul", modul);
                cmd.Parameters.AddWithValue("@detay", detay != null ? JsonSerializer.Serialize(detay) : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@aiModel", (object?)aiModel ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ipAdres", (object?)ipAdres ?? DBNull.Value);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AuditLog] Yazma hatasi: {ex.Message}");
            }
        }
    }
}
