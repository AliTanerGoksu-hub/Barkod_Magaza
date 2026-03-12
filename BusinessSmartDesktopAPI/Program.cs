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

// Klasörleri oluştur
Directory.CreateDirectory(updatesPath);
Directory.CreateDirectory(backupsPath);

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
        "POST /api/license/verify"
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

        // TODO: Kendi lisans doğrulama mantığınızı ekleyin
        // Şimdilik basit bir kontrol
        var isValid = licenseKey.Length >= 10;

        return Results.Json(new
        {
            success = isValid,
            message = isValid ? "License valid" : "Invalid license key",
            expiryDate = isValid ? DateTime.Now.AddYears(1).ToString("yyyy-MM-dd") : null,
            features = isValid ? "full" : null,
            maxUsers = isValid ? 10 : 0
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

// Uygulamayı başlat
Console.WriteLine("===========================================");
Console.WriteLine("  Business Smart Desktop API");
Console.WriteLine("===========================================");
Console.WriteLine($"  Listening on: http://0.0.0.0:8080");
Console.WriteLine($"  Updates Path: {updatesPath}");
Console.WriteLine($"  Backups Path: {backupsPath}");
Console.WriteLine("===========================================");

app.Run("http://0.0.0.0:8080");
