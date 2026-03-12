using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

// Konfigürasyon
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Konfigürasyon değerlerini al
var config = builder.Configuration;
var apiKey = config["ApiKey"] ?? "BSmart2024Desktop!@#";
var updatesPath = config["UpdatesPath"] ?? @"C:\BusinessSmartFiles\Updates";
var backupsPath = config["BackupsPath"] ?? @"C:\BusinessSmartFiles\Backups";
var filesPath = config["FilesPath"] ?? @"C:\BusinessSmartFiles\SharedFiles";

// Klasörleri oluştur
Directory.CreateDirectory(updatesPath);
Directory.CreateDirectory(backupsPath);
Directory.CreateDirectory(filesPath);

app.UseCors("AllowAll");

// API Key doğrulama
bool ValidateApiKey(HttpContext context)
{
    var requestKey = context.Request.Headers["X-Api-Key"].FirstOrDefault();
    return !string.IsNullOrEmpty(requestKey) && requestKey == apiKey;
}

// ==================== ANA SAYFA ====================
app.MapGet("/", () => Results.Ok(new
{
    service = "Business Smart Desktop API",
    status = "online",
    version = "1.0.0",
    serverTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
    endpoints = new[]
    {
        "GET  /api/update/check",
        "GET  /api/update/download?file=xxx",
        "GET  /api/update/info?file=xxx",
        "POST /api/backup/upload",
        "GET  /api/backup/list",
        "GET  /api/backup/download?file=xxx",
        "POST /api/license/verify",
        "POST /api/license/activate",
        "GET  /api/license/list",
        "GET  /api/files/list?folder=xxx",
        "GET  /api/files/download?file=xxx",
        "POST /api/files/upload?folder=xxx",
        "DELETE /api/files/delete?file=xxx",
        "POST /api/files/mkdir?folder=xxx"
    }
}));

// ==================== GÜNCELLEME API ====================

// Güncelleme kontrolü
app.MapGet("/api/update/check", (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var appName = context.Request.Query["app"].FirstOrDefault() ?? "business_smart";
    var currentVersion = context.Request.Query["version"].FirstOrDefault() ?? "0.0.0";

    var updates = new List<object>();
    
    if (Directory.Exists(updatesPath))
    {
        // x64 klasörü
        var x64Path = Path.Combine(updatesPath, "x64");
        if (Directory.Exists(x64Path))
        {
            foreach (var file in Directory.GetFiles(x64Path, "*.exe"))
            {
                var fi = new FileInfo(file);
                updates.Add(new
                {
                    fileName = fi.Name,
                    fileSize = fi.Length,
                    lastModified = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    platform = "x64",
                    downloadUrl = $"/api/update/download?file=x64/{fi.Name}"
                });
            }
        }

        // x86 klasörü
        var x86Path = Path.Combine(updatesPath, "x86");
        if (Directory.Exists(x86Path))
        {
            foreach (var file in Directory.GetFiles(x86Path, "*.exe"))
            {
                var fi = new FileInfo(file);
                updates.Add(new
                {
                    fileName = fi.Name,
                    fileSize = fi.Length,
                    lastModified = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    platform = "x86",
                    downloadUrl = $"/api/update/download?file=x86/{fi.Name}"
                });
            }
        }
    }

    return Results.Json(new
    {
        success = true,
        currentVersion,
        hasUpdate = updates.Count > 0,
        updates
    });
});

// Dosya bilgisi
app.MapGet("/api/update/info", (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var fileName = context.Request.Query["file"].FirstOrDefault();
    if (string.IsNullOrEmpty(fileName))
        return Results.Json(new { success = false, message = "File name required" }, statusCode: 400);

    // Güvenlik: Path traversal engelle
    fileName = fileName.Replace("..", "");
    var filePath = Path.Combine(updatesPath, fileName);

    if (!File.Exists(filePath))
        return Results.Json(new { success = false, message = "File not found" }, statusCode: 404);

    var fi = new FileInfo(filePath);
    return Results.Json(new
    {
        success = true,
        fileName = fi.Name,
        fileSize = fi.Length,
        lastModified = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
    });
});

// Dosya indirme
app.MapGet("/api/update/download", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Invalid API Key" });
        return;
    }

    var fileName = context.Request.Query["file"].FirstOrDefault();
    if (string.IsNullOrEmpty(fileName))
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "File name required" });
        return;
    }

    // Güvenlik
    fileName = fileName.Replace("..", "");
    var filePath = Path.Combine(updatesPath, fileName);

    if (!File.Exists(filePath))
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "File not found" });
        return;
    }

    var fi = new FileInfo(filePath);
    context.Response.ContentType = "application/octet-stream";
    context.Response.Headers.Append("Content-Disposition", $"attachment; filename=\"{fi.Name}\"");
    context.Response.ContentLength = fi.Length;

    await context.Response.SendFileAsync(filePath);
});

// ==================== YEDEKLEME API ====================

// Yedek yükleme
app.MapPost("/api/backup/upload", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var clientId = context.Request.Headers["X-Client-Id"].FirstOrDefault() ?? "unknown";
    
    if (!context.Request.HasFormContentType)
        return Results.Json(new { success = false, message = "Form content required" }, statusCode: 400);

    var form = await context.Request.ReadFormAsync();
    var file = form.Files.FirstOrDefault();

    if (file == null || file.Length == 0)
        return Results.Json(new { success = false, message = "No file uploaded" }, statusCode: 400);

    // Client klasörü oluştur
    var clientPath = Path.Combine(backupsPath, SanitizeFolderName(clientId));
    Directory.CreateDirectory(clientPath);

    // Dosya adı: original_timestamp.ext
    var originalName = Path.GetFileNameWithoutExtension(file.FileName);
    var extension = Path.GetExtension(file.FileName);
    var newFileName = $"{originalName}_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";
    var filePath = Path.Combine(clientPath, newFileName);

    // Kaydet
    using (var stream = new FileStream(filePath, FileMode.Create))
    {
        await file.CopyToAsync(stream);
    }

    var fi = new FileInfo(filePath);
    return Results.Json(new
    {
        success = true,
        message = "Backup uploaded successfully",
        fileName = newFileName,
        fileSize = fi.Length,
        uploadTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    });
});

// Yedek listesi
app.MapGet("/api/backup/list", (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var clientId = context.Request.Headers["X-Client-Id"].FirstOrDefault() 
                   ?? context.Request.Query["clientId"].FirstOrDefault();

    if (string.IsNullOrEmpty(clientId))
        return Results.Json(new { success = false, message = "Client ID required" }, statusCode: 400);

    var clientPath = Path.Combine(backupsPath, SanitizeFolderName(clientId));
    var backups = new List<object>();

    if (Directory.Exists(clientPath))
    {
        foreach (var file in Directory.GetFiles(clientPath))
        {
            var fi = new FileInfo(file);
            backups.Add(new
            {
                fileName = fi.Name,
                fileSize = fi.Length,
                createdDate = fi.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")
            });
        }
    }

    return Results.Json(new
    {
        success = true,
        clientId,
        backupCount = backups.Count,
        backups
    });
});

// Yedek indirme
app.MapGet("/api/backup/download", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Invalid API Key" });
        return;
    }

    var clientId = context.Request.Headers["X-Client-Id"].FirstOrDefault()
                   ?? context.Request.Query["clientId"].FirstOrDefault();
    var fileName = context.Request.Query["file"].FirstOrDefault();

    if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(fileName))
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Client ID and file name required" });
        return;
    }

    fileName = Path.GetFileName(fileName); // Güvenlik
    var filePath = Path.Combine(backupsPath, SanitizeFolderName(clientId), fileName);

    if (!File.Exists(filePath))
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Backup not found" });
        return;
    }

    var fi = new FileInfo(filePath);
    context.Response.ContentType = "application/octet-stream";
    context.Response.Headers.Append("Content-Disposition", $"attachment; filename=\"{fi.Name}\"");

    await context.Response.SendFileAsync(filePath);
});

// ==================== LİSANS API ====================

app.MapPost("/api/license/verify", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, string>>(body) ?? new Dictionary<string, string>();

        var licenseKey = data.GetValueOrDefault("licenseKey", "");
        var machineId = data.GetValueOrDefault("machineId", "");

        if (string.IsNullOrEmpty(licenseKey))
            return Results.Json(new { success = false, message = "License key required" }, statusCode: 400);

        // BAYII veritabanına bağlan ve lisans kontrolü yap
        var licenseConnStr = config["LicenseConnectionString"] ?? 
            "Provider=SQLOLEDB.1;Password=87918991;Persist Security Info=True;User ID=bayii1;Initial Catalog=BAYII;Data Source=SERVER\\SERVER,8991";
        
        using var conn = new System.Data.OleDb.OleDbConnection(licenseConnStr);
        await conn.OpenAsync();
        
        using var cmd = new System.Data.OleDb.OleDbCommand(
            @"SELECT tbFirmaLisans.sOnayKodu, tbFirmaLisans.sMacID, tbFirmaLisans.dteGecerlilikTarihi, 
                     tbFirmaLisans.sParametre1, tbFirmaLisans.sParametre2, tbFirmaLisans.nFirmaID,
                     tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sOzelNot
              FROM tbFirmaLisans 
              INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID 
              WHERE tbFirmaLisans.sOnayKodu = ?", conn);
        cmd.Parameters.AddWithValue("?", licenseKey);
        
        using var reader = await cmd.ExecuteReaderAsync();
        
        if (!reader.Read())
        {
            return Results.Json(new { 
                success = false, 
                message = "Lisans bulunamadı",
                isValid = false 
            });
        }
        
        var dbMacId = reader["sMacID"]?.ToString() ?? "";
        var expiryDate = reader["dteGecerlilikTarihi"] as DateTime?;
        var firmaKodu = reader["sKodu"]?.ToString() ?? "";
        var firmaAdi = reader["sAciklama"]?.ToString() ?? "";
        var ozelNot = reader["sOzelNot"]?.ToString() ?? "";
        var parametre1 = reader["sParametre1"]?.ToString() ?? "";
        var parametre2 = reader["sParametre2"]?.ToString() ?? "";
        
        // MAC ID kontrolü (opsiyonel - boş değilse kontrol et)
        bool macValid = string.IsNullOrEmpty(dbMacId) || string.IsNullOrEmpty(machineId) || 
                        dbMacId.Equals(machineId, StringComparison.OrdinalIgnoreCase);
        
        // Tarih kontrolü
        bool dateValid = !expiryDate.HasValue || expiryDate.Value >= DateTime.Now;
        
        bool isValid = macValid && dateValid;
        
        return Results.Json(new
        {
            success = true,
            isValid = isValid,
            message = isValid ? "Lisans geçerli" : (macValid ? "Lisans süresi dolmuş" : "Bu lisans başka bir bilgisayara kayıtlı"),
            licenseKey = licenseKey,
            firmaKodu = firmaKodu,
            firmaAdi = firmaAdi,
            expiryDate = expiryDate?.ToString("yyyy-MM-dd"),
            ozelNot = ozelNot,
            parametre1 = parametre1,
            parametre2 = parametre2,
            macIdMatch = macValid
        });
    }
    catch (Exception ex)
    {
        return Results.Json(new { success = false, message = "Veritabanı hatası: " + ex.Message }, statusCode: 500);
    }
});

// Lisans aktivasyonu - MAC ID kaydet
app.MapPost("/api/license/activate", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, string>>(body) ?? new Dictionary<string, string>();

        var licenseKey = data.GetValueOrDefault("licenseKey", "");
        var machineId = data.GetValueOrDefault("machineId", "");
        var computerName = data.GetValueOrDefault("computerName", "");
        var userName = data.GetValueOrDefault("userName", "");
        var ipAddress = data.GetValueOrDefault("ipAddress", "");
        var osVersion = data.GetValueOrDefault("osVersion", "");
        var cpuId = data.GetValueOrDefault("cpuId", "");
        var hddSerial = data.GetValueOrDefault("hddSerial", "");
        var biosVersion = data.GetValueOrDefault("biosVersion", "");
        var manufacturer = data.GetValueOrDefault("manufacturer", "");
        var model = data.GetValueOrDefault("model", "");
        var systemType = data.GetValueOrDefault("systemType", "");

        if (string.IsNullOrEmpty(licenseKey) || string.IsNullOrEmpty(machineId))
            return Results.Json(new { success = false, message = "Lisans anahtarı ve MAC ID gerekli" }, statusCode: 400);

        var licenseConnStr = config["LicenseConnectionString"];
        
        using var conn = new System.Data.OleDb.OleDbConnection(licenseConnStr);
        await conn.OpenAsync();
        
        // Önce lisansın var olup olmadığını kontrol et
        using var checkCmd = new System.Data.OleDb.OleDbCommand(
            "SELECT sMacID FROM tbFirmaLisans WHERE sOnayKodu = ?", conn);
        checkCmd.Parameters.AddWithValue("?", licenseKey);
        var existingMac = await checkCmd.ExecuteScalarAsync() as string;
        
        if (existingMac == null)
        {
            return Results.Json(new { success = false, message = "Lisans bulunamadı" });
        }
        
        // Zaten başka MAC'e kayıtlıysa
        if (!string.IsNullOrEmpty(existingMac) && !existingMac.Equals(machineId, StringComparison.OrdinalIgnoreCase))
        {
            return Results.Json(new { 
                success = false, 
                message = "Bu lisans başka bir bilgisayara kayıtlı",
                registeredMac = existingMac
            });
        }
        
        // MAC ID ve diğer bilgileri güncelle
        using var updateCmd = new System.Data.OleDb.OleDbCommand(
            @"UPDATE tbFirmaLisans SET 
                sMacID = ?, sBilgisayar = ?, sOturum = ?, sIP = ?, sOS = ?,
                sCpuID = ?, sHddSerial = ?, sBiosVersion = ?,
                sManufactor = ?, sModel = ?, sSystemType = ?
              WHERE sOnayKodu = ?", conn);
        
        updateCmd.Parameters.AddWithValue("?", machineId);
        updateCmd.Parameters.AddWithValue("?", computerName);
        updateCmd.Parameters.AddWithValue("?", userName);
        updateCmd.Parameters.AddWithValue("?", ipAddress);
        updateCmd.Parameters.AddWithValue("?", osVersion);
        updateCmd.Parameters.AddWithValue("?", cpuId);
        updateCmd.Parameters.AddWithValue("?", hddSerial);
        updateCmd.Parameters.AddWithValue("?", biosVersion);
        updateCmd.Parameters.AddWithValue("?", manufacturer);
        updateCmd.Parameters.AddWithValue("?", model);
        updateCmd.Parameters.AddWithValue("?", systemType);
        updateCmd.Parameters.AddWithValue("?", licenseKey);
        
        await updateCmd.ExecuteNonQueryAsync();
        
        return Results.Json(new
        {
            success = true,
            message = "Lisans başarıyla aktive edildi",
            licenseKey = licenseKey,
            machineId = machineId
        });
    }
    catch (Exception ex)
    {
        return Results.Json(new { success = false, message = "Aktivasyon hatası: " + ex.Message }, statusCode: 500);
    }
});

// Lisans listesi (Admin için)
app.MapGet("/api/license/list", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var licenseConnStr = config["LicenseConnectionString"];
        
        using var conn = new System.Data.OleDb.OleDbConnection(licenseConnStr);
        await conn.OpenAsync();
        
        using var cmd = new System.Data.OleDb.OleDbCommand(
            @"SELECT TOP 100 tbFirmaLisans.sOnayKodu, tbFirmaLisans.sMacID, 
                     tbFirmaLisans.dteGecerlilikTarihi, tbFirmaLisans.sBilgisayar,
                     tbFirmaLisans.sIP, tbFirma.sKodu, tbFirma.sAciklama
              FROM tbFirmaLisans 
              INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID 
              ORDER BY tbFirma.sAciklama", conn);
        
        using var reader = await cmd.ExecuteReaderAsync();
        var licenses = new List<object>();
        
        while (reader.Read())
        {
            licenses.Add(new
            {
                licenseKey = reader["sOnayKodu"]?.ToString(),
                macId = reader["sMacID"]?.ToString(),
                expiryDate = (reader["dteGecerlilikTarihi"] as DateTime?)?.ToString("yyyy-MM-dd"),
                computerName = reader["sBilgisayar"]?.ToString(),
                ipAddress = reader["sIP"]?.ToString(),
                firmaKodu = reader["sKodu"]?.ToString(),
                firmaAdi = reader["sAciklama"]?.ToString()
            });
        }
        
        return Results.Json(new
        {
            success = true,
            count = licenses.Count,
            licenses
        });
    }
    catch (Exception ex)
    {
        return Results.Json(new { success = false, message = ex.Message }, statusCode: 500);
    }
});

// Yardımcı fonksiyon
string SanitizeFolderName(string name)
{
    var invalid = Path.GetInvalidFileNameChars();
    foreach (var c in invalid)
        name = name.Replace(c, '_');
    return name;
}

// ==================== DOSYA YÖNETİMİ API (FTP YERİNE) ====================

// Dosya listele
app.MapGet("/api/files/list", (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var folder = context.Request.Query["folder"].FirstOrDefault() ?? "";
    
    // Güvenlik: Path traversal engelle
    folder = folder.Replace("..", "").Trim('/').Trim('\\');
    
    var targetPath = string.IsNullOrEmpty(folder) 
        ? filesPath 
        : Path.Combine(filesPath, folder);

    if (!Directory.Exists(targetPath))
        return Results.Json(new { success = false, message = "Folder not found" }, statusCode: 404);

    var files = new List<object>();
    var folders = new List<object>();

    // Alt klasörleri listele
    foreach (var dir in Directory.GetDirectories(targetPath))
    {
        var di = new DirectoryInfo(dir);
        folders.Add(new
        {
            name = di.Name,
            type = "folder",
            lastModified = di.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
        });
    }

    // Dosyaları listele
    foreach (var file in Directory.GetFiles(targetPath))
    {
        var fi = new FileInfo(file);
        files.Add(new
        {
            name = fi.Name,
            type = "file",
            size = fi.Length,
            lastModified = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"),
            downloadUrl = $"/api/files/download?file={Uri.EscapeDataString(Path.Combine(folder, fi.Name).Replace("\\", "/"))}"
        });
    }

    return Results.Json(new
    {
        success = true,
        currentFolder = folder,
        folderCount = folders.Count,
        fileCount = files.Count,
        folders,
        files
    });
});

// Dosya indir
app.MapGet("/api/files/download", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Invalid API Key" });
        return;
    }

    var filePath = context.Request.Query["file"].FirstOrDefault();
    
    if (string.IsNullOrEmpty(filePath))
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "File path required" });
        return;
    }

    // Güvenlik: Path traversal engelle
    filePath = filePath.Replace("..", "");
    var fullPath = Path.Combine(filesPath, filePath);

    if (!File.Exists(fullPath))
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "File not found" });
        return;
    }

    var fi = new FileInfo(fullPath);
    context.Response.ContentType = "application/octet-stream";
    context.Response.Headers.Append("Content-Disposition", $"attachment; filename=\"{fi.Name}\"");
    context.Response.ContentLength = fi.Length;

    await context.Response.SendFileAsync(fullPath);
});

// Dosya yükle
app.MapPost("/api/files/upload", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var folder = context.Request.Query["folder"].FirstOrDefault() ?? "";
    
    // Güvenlik
    folder = folder.Replace("..", "").Trim('/').Trim('\\');
    
    if (!context.Request.HasFormContentType)
        return Results.Json(new { success = false, message = "Form content required" }, statusCode: 400);

    var form = await context.Request.ReadFormAsync();
    var file = form.Files.FirstOrDefault();

    if (file == null || file.Length == 0)
        return Results.Json(new { success = false, message = "No file uploaded" }, statusCode: 400);

    var targetPath = string.IsNullOrEmpty(folder)
        ? filesPath
        : Path.Combine(filesPath, folder);
    
    Directory.CreateDirectory(targetPath);

    var fileName = Path.GetFileName(file.FileName);
    var fullPath = Path.Combine(targetPath, fileName);

    // Dosyayı kaydet
    using (var stream = new FileStream(fullPath, FileMode.Create))
    {
        await file.CopyToAsync(stream);
    }

    var fi = new FileInfo(fullPath);
    return Results.Json(new
    {
        success = true,
        message = "File uploaded successfully",
        fileName = fi.Name,
        folder = folder,
        fileSize = fi.Length,
        uploadTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    });
});

// Dosya sil
app.MapDelete("/api/files/delete", (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var filePath = context.Request.Query["file"].FirstOrDefault();
    
    if (string.IsNullOrEmpty(filePath))
        return Results.Json(new { success = false, message = "File path required" }, statusCode: 400);

    // Güvenlik
    filePath = filePath.Replace("..", "");
    var fullPath = Path.Combine(filesPath, filePath);

    if (!File.Exists(fullPath))
        return Results.Json(new { success = false, message = "File not found" }, statusCode: 404);

    File.Delete(fullPath);

    return Results.Json(new
    {
        success = true,
        message = "File deleted successfully"
    });
});

// Klasör oluştur
app.MapPost("/api/files/mkdir", (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    var folder = context.Request.Query["folder"].FirstOrDefault();
    
    if (string.IsNullOrEmpty(folder))
        return Results.Json(new { success = false, message = "Folder name required" }, statusCode: 400);

    // Güvenlik
    folder = folder.Replace("..", "").Trim('/').Trim('\\');
    var fullPath = Path.Combine(filesPath, folder);

    Directory.CreateDirectory(fullPath);

    return Results.Json(new
    {
        success = true,
        message = "Folder created successfully",
        folder = folder
    });
});

// Port ayarı - environment variable veya appsettings'den al
var port = Environment.GetEnvironmentVariable("API_PORT") ?? config["Port"] ?? "5080";
var listenUrl = $"http://0.0.0.0:{port}";

// Uygulamayı başlat
Console.WriteLine("===========================================");
Console.WriteLine("  Business Smart Desktop API");
Console.WriteLine("===========================================");
Console.WriteLine($"  Listening on: {listenUrl}");
Console.WriteLine($"  Updates Path: {updatesPath}");
Console.WriteLine($"  Backups Path: {backupsPath}");
Console.WriteLine($"  Files Path:   {filesPath}");
Console.WriteLine("===========================================");

app.Run(listenUrl);
