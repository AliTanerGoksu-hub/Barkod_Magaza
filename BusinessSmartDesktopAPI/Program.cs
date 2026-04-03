using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
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
var downloadsPath = config["DownloadsPath"] ?? @"D:\ftp"; // Bayii indirme klasörü

// Bayii kullanıcı bilgileri
var bayiiUsername = config["BayiiUsername"] ?? "bayii";
var bayiiPassword = config["BayiiPassword"] ?? "BusinessSmart4909";

// Klasörleri oluştur
Directory.CreateDirectory(updatesPath);
Directory.CreateDirectory(backupsPath);
Directory.CreateDirectory(filesPath);
Directory.CreateDirectory(downloadsPath);

app.UseCors("AllowAll");

// API Key doğrulama (internal API için)
bool ValidateApiKey(HttpContext context)
{
    var requestKey = context.Request.Headers["X-Api-Key"].FirstOrDefault();
    return !string.IsNullOrEmpty(requestKey) && requestKey == apiKey;
}

// Bayii kullanıcı doğrulama (download portal için)
bool ValidateBayiiUser(HttpContext context, out string? username)
{
    username = null;
    var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
    if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Basic "))
        return false;
    
    try
    {
        var base64 = authHeader.Substring(6);
        var credentials = Encoding.UTF8.GetString(Convert.FromBase64String(base64));
        var parts = credentials.Split(':');
        if (parts.Length != 2) return false;
        
        username = parts[0];
        var password = parts[1];
        
        return username == bayiiUsername && password == bayiiPassword;
    }
    catch
    {
        return false;
    }
}

// ==================== ANA SAYFA ====================
app.MapGet("/", (HttpContext context) => 
{
    var host = context.Request.Host.Host.ToLower();
    
    // ftp.barkodyazilimevi.com adresinden gelenlere download portal göster
    if (host.Contains("ftp.barkodyazilimevi.com") || host.Contains("ftp."))
    {
        return Results.Redirect("/download");
    }
    
    // Normal API ana sayfası
    return Results.Ok(new
    {
        service = "Business Smart Desktop API",
        status = "online",
        version = "1.1.0",
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
            "GET  /api/license/details?key=xxx - Lisans detayları",
            "GET  /api/license/bayii?id=xxx - Bayii bilgisi",
            "GET  /api/files/list?folder=xxx",
            "GET  /api/files/download?file=xxx",
            "POST /api/files/upload?folder=xxx",
            "DELETE /api/files/delete?file=xxx",
            "POST /api/files/mkdir?folder=xxx",
            "GET  /download - Bayii Download Portal (Web UI)",
            "GET  /api/download/list - Bayii dosya listesi",
            "GET  /api/download/file?name=xxx - Bayii dosya indirme"
        }
    });
});

// ==================== BAYİİ DOWNLOAD PORTAL (WEB UI) ====================

app.MapGet("/download", (HttpContext context) =>
{
    // HTML sayfa döndür
    var html = @"<!DOCTYPE html>
<html lang='tr'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Barkod Yazılım - İndirme Portalı</title>
    <style>
        * { margin: 0; padding: 0; box-sizing: border-box; }
        body { 
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: #000;
            min-height: 100vh;
            color: #fff;
        }
        .container { max-width: 900px; margin: 0 auto; padding: 40px 20px; }
        .header { text-align: center; margin-bottom: 40px; }
        .header .logo-wrapper {
            display: inline-block;
            background: linear-gradient(145deg, #1a1a1a 0%, #0a0a0a 100%);
            padding: 25px 40px;
            border-radius: 20px;
            box-shadow: 0 10px 40px rgba(180,212,85,0.15), inset 0 1px 0 rgba(255,255,255,0.1);
            border: 1px solid rgba(180,212,85,0.2);
            margin-bottom: 20px;
        }
        .header img { 
            max-width: 220px; 
            filter: drop-shadow(0 2px 4px rgba(0,0,0,0.3));
        }
        .header p { color: #b4d455; font-size: 1.1em; letter-spacing: 2px; text-transform: uppercase; }
        .login-box {
            background: rgba(180,212,85,0.05);
            border-radius: 15px;
            padding: 30px;
            margin-bottom: 30px;
            border: 1px solid rgba(180,212,85,0.3);
        }
        .login-box h2 { margin-bottom: 20px; color: #b4d455; }
        .form-group { margin-bottom: 15px; }
        .form-group label { display: block; margin-bottom: 5px; color: #aaa; }
        .form-group input {
            width: 100%;
            padding: 12px 15px;
            border: 1px solid rgba(180,212,85,0.3);
            border-radius: 8px;
            background: rgba(0,0,0,0.5);
            color: #fff;
            font-size: 16px;
        }
        .form-group input:focus { outline: none; border-color: #b4d455; }
        .btn {
            background: linear-gradient(135deg, #b4d455 0%, #8fb33a 100%);
            color: #000;
            border: none;
            padding: 12px 30px;
            border-radius: 8px;
            cursor: pointer;
            font-size: 16px;
            font-weight: 600;
            transition: transform 0.2s, box-shadow 0.2s;
        }
        .btn:hover { transform: translateY(-2px); box-shadow: 0 5px 20px rgba(180,212,85,0.4); }
        .file-list { display: none; }
        .file-list.active { display: block; }
        .file-item {
            background: rgba(255,255,255,0.05);
            border-radius: 10px;
            padding: 20px;
            margin-bottom: 15px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            border: 1px solid rgba(255,255,255,0.1);
            transition: background 0.2s;
        }
        .file-item:hover { background: rgba(255,255,255,0.1); }
        .file-info h3 { margin-bottom: 5px; }
        .file-info span { color: #888; font-size: 14px; }
        .download-btn {
            background: linear-gradient(135deg, #00ff88 0%, #00cc6a 100%);
            color: #000;
            padding: 10px 20px;
            border-radius: 6px;
            text-decoration: none;
            font-weight: 600;
            transition: transform 0.2s;
        }
        .download-btn:hover { transform: scale(1.05); }
        .error { color: #ff4444; margin-top: 10px; display: none; }
        .loading { text-align: center; padding: 40px; color: #888; }
        .icon { font-size: 24px; margin-right: 15px; }
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <div class='logo-wrapper'>
                <img src='https://customer-assets.emergentagent.com/job_219c0f73-95be-426c-9147-3f613dde92c2/artifacts/n7zeyh71_JPG.jpg' alt='Barkod Yazılım'>
            </div>
            <p>İndirme Portalı</p>
        </div>
        
        <div class='login-box' id='loginBox'>
            <h2>Giriş Yap</h2>
            <div class='form-group'>
                <label>Kullanıcı Adı</label>
                <input type='text' id='username' placeholder='Kullanıcı adınızı girin'>
            </div>
            <div class='form-group'>
                <label>Şifre</label>
                <input type='password' id='password' placeholder='Şifrenizi girin'>
            </div>
            <button class='btn' onclick='login()'>Giriş Yap</button>
            <p class='error' id='loginError'>Kullanıcı adı veya şifre hatalı!</p>
        </div>
        
        <div class='file-list' id='fileList'>
            <h2 style='margin-bottom: 20px; color: #b4d455;'>İndirilebilir Dosyalar</h2>
            <div id='files' class='loading'>Dosyalar yükleniyor...</div>
        </div>
    </div>
    
    <script>
        let authToken = '';
        
        function login() {
            const username = document.getElementById('username').value;
            const password = document.getElementById('password').value;
            authToken = btoa(username + ':' + password);
            
            fetch('/api/download/list', {
                headers: { 'Authorization': 'Basic ' + authToken }
            })
            .then(r => r.json())
            .then(data => {
                if (data.success) {
                    document.getElementById('loginBox').style.display = 'none';
                    document.getElementById('fileList').classList.add('active');
                    renderFiles(data.files);
                } else {
                    document.getElementById('loginError').style.display = 'block';
                }
            })
            .catch(() => {
                document.getElementById('loginError').style.display = 'block';
            });
        }
        
        function renderFiles(files) {
            const container = document.getElementById('files');
            if (files.length === 0) {
                container.innerHTML = '<p>Henüz indirilebilir dosya bulunmuyor.</p>';
                return;
            }
            
            container.innerHTML = files.map(f => `
                <div class='file-item'>
                    <div class='file-info'>
                        <h3><span class='icon'>${getIcon(f.name)}</span>${f.name}</h3>
                        <span>${formatSize(f.size)} • ${f.lastModified}</span>
                    </div>
                    <a href='/api/download/file?name=${encodeURIComponent(f.name)}' 
                       class='download-btn'
                       onclick='return downloadFile(event, ""${f.name}"")'>
                       ⬇️ İndir
                    </a>
                </div>
            `).join('');
        }
        
        function downloadFile(event, filename) {
            event.preventDefault();
            const link = document.createElement('a');
            link.href = '/api/download/file?name=' + encodeURIComponent(filename);
            
            // Auth header ile fetch yap
            fetch(link.href, {
                headers: { 'Authorization': 'Basic ' + authToken }
            })
            .then(r => r.blob())
            .then(blob => {
                const url = window.URL.createObjectURL(blob);
                const a = document.createElement('a');
                a.href = url;
                a.download = filename;
                a.click();
                window.URL.revokeObjectURL(url);
            });
            
            return false;
        }
        
        function getIcon(filename) {
            if (filename.endsWith('.exe')) return '💿';
            if (filename.endsWith('.msi')) return '📦';
            if (filename.endsWith('.zip')) return '🗜️';
            if (filename.endsWith('.pdf')) return '📄';
            return '📁';
        }
        
        function formatSize(bytes) {
            if (bytes < 1024) return bytes + ' B';
            if (bytes < 1024*1024) return (bytes/1024).toFixed(1) + ' KB';
            if (bytes < 1024*1024*1024) return (bytes/1024/1024).toFixed(1) + ' MB';
            return (bytes/1024/1024/1024).toFixed(1) + ' GB';
        }
        
        // Enter tuşu ile giriş
        document.getElementById('password').addEventListener('keypress', (e) => {
            if (e.key === 'Enter') login();
        });
    </script>
</body>
</html>";
    
    context.Response.ContentType = "text/html; charset=utf-8";
    return Results.Content(html, "text/html");
});

// Bayii dosya listesi API
app.MapGet("/api/download/list", (HttpContext context) =>
{
    if (!ValidateBayiiUser(context, out var username))
    {
        return Results.Json(new { success = false, message = "Yetkisiz erişim" }, statusCode: 401);
    }
    
    var files = new List<object>();
    
    if (Directory.Exists(downloadsPath))
    {
        foreach (var file in Directory.GetFiles(downloadsPath))
        {
            var fi = new FileInfo(file);
            files.Add(new
            {
                name = fi.Name,
                size = fi.Length,
                lastModified = fi.LastWriteTime.ToString("dd.MM.yyyy HH:mm")
            });
        }
    }
    
    return Results.Json(new
    {
        success = true,
        user = username,
        fileCount = files.Count,
        files = files.OrderByDescending(f => ((dynamic)f).lastModified).ToList()
    });
});

// Bayii dosya indirme API
app.MapGet("/api/download/file", async (HttpContext context) =>
{
    if (!ValidateBayiiUser(context, out var username))
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Yetkisiz erişim" });
        return;
    }
    
    var fileName = context.Request.Query["name"].FirstOrDefault();
    
    if (string.IsNullOrEmpty(fileName))
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Dosya adı gerekli" });
        return;
    }
    
    // Güvenlik: Path traversal engelle
    fileName = Path.GetFileName(fileName);
    var filePath = Path.Combine(downloadsPath, fileName);
    
    if (!File.Exists(filePath))
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsJsonAsync(new { success = false, message = "Dosya bulunamadı" });
        return;
    }
    
    var fi = new FileInfo(filePath);
    context.Response.ContentType = "application/octet-stream";
    context.Response.Headers.Append("Content-Disposition", $"attachment; filename=\"{fi.Name}\"");
    context.Response.ContentLength = fi.Length;
    
    await context.Response.SendFileAsync(filePath);
});;

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
// ==================== BACKUP DELETE ====================
app.MapPost("/api/backup/delete", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
    {
        return Results.Unauthorized();
    }
    
    try
    {
        using var reader = new StreamReader(context.Request.Body);
        var body = await reader.ReadToEndAsync();
        var json = JsonSerializer.Deserialize<Dictionary<string, string>>(body);
        
        if (json == null || !json.ContainsKey("clientId") || !json.ContainsKey("fileName"))
        {
            return Results.BadRequest(new { error = "clientId ve fileName gerekli" });
        }
        
        var clientId = json["clientId"];
        var fileName = json["fileName"];
        
        if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(fileName))
        {
            return Results.BadRequest(new { error = "clientId ve fileName bos olamaz" });
        }
        
        // Güvenlik kontrolü
        if (fileName.Contains("..") || fileName.Contains("/") || fileName.Contains("\"))
        {
            return Results.BadRequest(new { error = "Gecersiz dosya adi" });
        }
        
        var clientPath = Path.Combine(backupsPath, SanitizeFolderName(clientId));
        var filePath = Path.Combine(clientPath, fileName);
        
        if (!File.Exists(filePath))
        {
            return Results.NotFound(new { error = "Dosya bulunamadi", fileName });
        }
        
        File.Delete(filePath);
        
        Console.WriteLine($"[Backup Delete] Silindi: {clientId}/{fileName}");
        
        return Results.Ok(new { success = true, message = "Dosya silindi", fileName });
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[Backup Delete] Hata: {ex.Message}");
        return Results.Problem($"Silme hatasi: {ex.Message}");
    }
});

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

        var sqlConnStr = config["SqlConnectionString"] ?? throw new Exception("SqlConnectionString not configured in appsettings.json");
        
        using var conn = new SqlConnection(sqlConnStr);
        await conn.OpenAsync();
        
        using var cmd = new SqlCommand(
            @"SELECT tbFirmaLisans.sOnayKodu, tbFirmaLisans.sMacID, tbFirmaLisans.dteGecerlilikTarihi, 
                     tbFirmaLisans.sParametre1, tbFirmaLisans.sParametre2, tbFirmaLisans.nFirmaID,
                     tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sOzelNot
              FROM tbFirmaLisans 
              INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID 
              WHERE tbFirmaLisans.sOnayKodu = @licenseKey", conn);
        cmd.Parameters.AddWithValue("@licenseKey", licenseKey);
        
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
        var parametre1 = data.GetValueOrDefault("parametre1", "");
        var parametre2 = data.GetValueOrDefault("parametre2", "");
        var country = data.GetValueOrDefault("country", "");
        var region = data.GetValueOrDefault("region", "");
        var installedBy = data.GetValueOrDefault("installedBy", "");
        var bayiiId = data.GetValueOrDefault("bayiiId", "");

        if (string.IsNullOrEmpty(licenseKey) || string.IsNullOrEmpty(machineId))
            return Results.Json(new { success = false, message = "Lisans anahtarı ve MAC ID gerekli" }, statusCode: 400);

        var sqlConnStr = config["SqlConnectionString"] ?? throw new Exception("SqlConnectionString not configured in appsettings.json");
        
        using var conn = new SqlConnection(sqlConnStr);
        await conn.OpenAsync();
        
        // Önce lisansın var olup olmadığını kontrol et
        using var checkCmd = new SqlCommand(
            "SELECT sMacID FROM tbFirmaLisans WHERE sOnayKodu = @licenseKey", conn);
        checkCmd.Parameters.AddWithValue("@licenseKey", licenseKey);
        var existingMac = await checkCmd.ExecuteScalarAsync();
        
        if (existingMac == null && existingMac != DBNull.Value)
        {
            return Results.Json(new { success = false, message = "Lisans bulunamadı" });
        }
        
        // MAC ID ve diğer bilgileri güncelle (BARKOD_INSTALL'dan gelen tüm alanlar)
        using var updateCmd = new SqlCommand(
            @"UPDATE tbFirmaLisans SET 
                sMacID = @machineId, sBilgisayar = @computerName, sOturum = @userName, 
                sIP = @ipAddress, sOS = @osVersion,
                sCpuID = @cpuId, sHddSerial = @hddSerial, sBiosVersion = @biosVersion,
                sManufactor = @manufacturer, sModel = @model, sSystemType = @systemType,
                sParametre1 = @parametre1, sParametre2 = @parametre2,
                sUlke = @country, sBolge = @region, sSifreyiAlan = @installedBy
              WHERE sOnayKodu = @licenseKey2", conn);
        
        updateCmd.Parameters.AddWithValue("@machineId", machineId);
        updateCmd.Parameters.AddWithValue("@computerName", computerName);
        updateCmd.Parameters.AddWithValue("@userName", userName);
        updateCmd.Parameters.AddWithValue("@ipAddress", ipAddress);
        updateCmd.Parameters.AddWithValue("@osVersion", osVersion);
        updateCmd.Parameters.AddWithValue("@cpuId", cpuId);
        updateCmd.Parameters.AddWithValue("@hddSerial", hddSerial);
        updateCmd.Parameters.AddWithValue("@biosVersion", biosVersion);
        updateCmd.Parameters.AddWithValue("@manufacturer", manufacturer);
        updateCmd.Parameters.AddWithValue("@model", model);
        updateCmd.Parameters.AddWithValue("@systemType", systemType);
        updateCmd.Parameters.AddWithValue("@parametre1", parametre1);
        updateCmd.Parameters.AddWithValue("@parametre2", parametre2);
        updateCmd.Parameters.AddWithValue("@country", country);
        updateCmd.Parameters.AddWithValue("@region", region);
        updateCmd.Parameters.AddWithValue("@installedBy", installedBy);
        updateCmd.Parameters.AddWithValue("@licenseKey2", licenseKey);
        
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
        var sqlConnStr = config["SqlConnectionString"] ?? throw new Exception("SqlConnectionString not configured in appsettings.json");
        
        using var conn = new SqlConnection(sqlConnStr);
        await conn.OpenAsync();
        
        using var cmd = new SqlCommand(
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

// ==================== LİSANS DETAY API (BARKOD_INSTALL için) ====================

// Lisans detayları - Firma bilgileri ve modüller dahil
app.MapGet("/api/license/details", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var licenseKey = context.Request.Query["key"].FirstOrDefault();
        
        if (string.IsNullOrEmpty(licenseKey))
            return Results.Json(new { success = false, message = "License key required" }, statusCode: 400);

        var sqlConnStr = config["SqlConnectionString"] ?? throw new Exception("SqlConnectionString not configured in appsettings.json");
        
        using var conn = new SqlConnection(sqlConnStr);
        await conn.OpenAsync();
        
        using var cmd = new SqlCommand(
            @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
              SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sAdres1, tbFirma.sAdres2, 
                     tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sOzelNot,
                     tbFirmaLisans.sOnayKodu, tbFirmaLisans.dteGecerlilikTarihi,
                     tbFirmaLisans.sParametre1, tbFirmaLisans.sParametre2, 
                     tbFirmaLisans.sManufactor, tbFirmaLisans.sModel, tbFirmaLisans.sSystemType, 
                     tbFirmaLisans.sCpuID, tbFirmaLisans.sBiosVersion, tbFirmaLisans.sHddSerial, tbFirmaLisans.sMacID,
                     (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS Email,
                     (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon,
                     (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm,
                     (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili
              FROM tbFirmaLisans 
              INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID 
              WHERE tbFirmaLisans.sOnayKodu = @licenseKey", conn);
        cmd.Parameters.AddWithValue("@licenseKey", licenseKey);
        
        using var reader = await cmd.ExecuteReaderAsync();
        
        if (!reader.Read())
            return Results.Json(new { success = false, message = "Lisans bulunamadı" });

        var firmaId = reader["nFirmaID"]?.ToString();
        var responseData = new Dictionary<string, object?>
        {
            ["success"] = true,
            ["firmaId"] = firmaId,
            ["firmaKodu"] = reader["sKodu"]?.ToString(),
            ["firmaAdi"] = reader["sAciklama"]?.ToString(),
            ["adres1"] = reader["sAdres1"]?.ToString(),
            ["adres2"] = reader["sAdres2"]?.ToString(),
            ["semt"] = reader["sSemt"]?.ToString(),
            ["il"] = reader["sIl"]?.ToString(),
            ["ulke"] = reader["sUlke"]?.ToString(),
            ["ozelNot"] = reader["sOzelNot"]?.ToString(),
            ["expiryDate"] = reader["dteGecerlilikTarihi"]?.ToString(),
            ["parametre1"] = reader["sParametre1"]?.ToString(),
            ["parametre2"] = reader["sParametre2"]?.ToString(),
            ["manufacturer"] = reader["sManufactor"]?.ToString(),
            ["model"] = reader["sModel"]?.ToString(),
            ["systemType"] = reader["sSystemType"]?.ToString(),
            ["cpuId"] = reader["sCpuID"]?.ToString(),
            ["biosVersion"] = reader["sBiosVersion"]?.ToString(),
            ["hddSerial"] = reader["sHddSerial"]?.ToString(),
            ["macId"] = reader["sMacID"]?.ToString(),
            ["email"] = reader["Email"]?.ToString(),
            ["telefon"] = reader["Telefon"]?.ToString(),
            ["gsm"] = reader["Gsm"]?.ToString(),
            ["yetkili"] = reader["Yetkili"]?.ToString()
        };
        
        reader.Close();
        
        // Modülleri al
        var moduller = new List<object>();
        if (!string.IsNullOrEmpty(firmaId) && int.TryParse(firmaId, out int firmaIdInt))
        {
            using var modCmd = new SqlCommand(
                @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
                  SELECT tbFirmaModulu.sModul, tbFirmaModulu.sAciklama 
                  FROM tbFirmaModulu 
                  INNER JOIN tbModul ON tbFirmaModulu.sModul = tbModul.sModul 
                  WHERE tbFirmaModulu.nFirmaID = @firmaId 
                  ORDER BY tbModul.nModulID", conn);
            modCmd.Parameters.AddWithValue("@firmaId", firmaIdInt);
            
            using var modReader = await modCmd.ExecuteReaderAsync();
            while (modReader.Read())
            {
                moduller.Add(new
                {
                    modul = modReader["sModul"]?.ToString(),
                    aciklama = modReader["sAciklama"]?.ToString()
                });
            }
        }
        responseData["moduller"] = moduller;

        return Results.Json(responseData);
    }
    catch (Exception ex)
    {
        return Results.Json(new { success = false, message = ex.Message }, statusCode: 500);
    }
});

// Bayii bilgisi al
app.MapGet("/api/license/bayii", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var bayiiId = context.Request.Query["id"].FirstOrDefault();
        
        if (string.IsNullOrEmpty(bayiiId))
            return Results.Json(new { success = false, message = "Bayii ID required" }, statusCode: 400);

        // SqlClient bağlantı stringi
        var sqlConnStr = config["SqlConnectionString"] ?? throw new Exception("SqlConnectionString not configured in appsettings.json");
        
        using var conn = new SqlConnection(sqlConnStr);
        await conn.OpenAsync();
        
        // nFirmaID ile ara, sKodu 320 ile başlayanlar bayii
        using var cmd = new SqlCommand(
            @"SELECT nFirmaID, sKodu, sAciklama, sAdres1, sAdres2,
                     (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon,
                     (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web
              FROM tbFirma 
              WHERE nFirmaID = @bayiiId AND sKodu LIKE '320%'", conn);
        cmd.Parameters.AddWithValue("@bayiiId", int.Parse(bayiiId));
        
        using var reader = await cmd.ExecuteReaderAsync();
        
        if (!reader.Read())
            return Results.Json(new { success = false, message = "Bayii bulunamadı" });

        return Results.Json(new
        {
            success = true,
            bayiiId = reader["nFirmaID"]?.ToString(),
            bayiiKodu = reader["sKodu"]?.ToString(),
            bayiiAdi = reader["sAciklama"]?.ToString(),
            adres1 = reader["sAdres1"]?.ToString(),
            adres2 = reader["sAdres2"]?.ToString(),
            telefon = reader["Telefon"]?.ToString(),
            web = reader["Web"]?.ToString()
        });
    }
    catch (Exception ex)
    {
        return Results.Json(new { 
            success = false, 
            message = "Bayii sorgu hatası: " + ex.Message,
            innerException = ex.InnerException?.Message
        }, statusCode: 500);
    }
});

// ==================== DOSYA YÖNETİMİ API (FTP YERİNE) ====================

// Lisans email bildirimi
app.MapPost("/api/license/notify", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, string>>(body) ?? new Dictionary<string, string>();

        var licenseKey = data.GetValueOrDefault("licenseKey", "");
        var customerName = data.GetValueOrDefault("customerName", "");
        var customerEmail = data.GetValueOrDefault("customerEmail", "");
        var parametre1 = data.GetValueOrDefault("parametre1", "");
        var parametre2 = data.GetValueOrDefault("parametre2", "");
        var moduller = data.GetValueOrDefault("moduller", "");

        // Email bilgilerini config'den al
        var smtpHost = config["SmtpHost"] ?? "smtp.gmail.com";
        var smtpPort = int.Parse(config["SmtpPort"] ?? "587");
        var smtpUser = config["SmtpUser"] ?? "";
        var smtpPassword = config["SmtpPassword"] ?? "";
        var notifyEmails = config["NotifyEmails"] ?? "alitanergoksu@barkodyazilimevi.com";

        if (string.IsNullOrEmpty(smtpUser) || string.IsNullOrEmpty(smtpPassword))
        {
            // Email yapılandırılmamış, sadece log tut
            Console.WriteLine($"[LICENSE NOTIFY] License: {licenseKey}, Customer: {customerName}");
            Console.WriteLine($"[LICENSE NOTIFY] Parametre1: {parametre1}, Parametre2: {parametre2}");
            Console.WriteLine($"[LICENSE NOTIFY] Moduller: {moduller}");
            return Results.Json(new { success = true, message = "Notification logged (email not configured)" });
        }

        // Email gönder
        using var client = new System.Net.Mail.SmtpClient(smtpHost, smtpPort);
        client.EnableSsl = true;
        client.Credentials = new System.Net.NetworkCredential(smtpUser, smtpPassword);

        var message = new System.Net.Mail.MailMessage();
        message.From = new System.Net.Mail.MailAddress(smtpUser);
        foreach (var email in notifyEmails.Split(','))
        {
            if (!string.IsNullOrWhiteSpace(email))
                message.To.Add(email.Trim());
        }
        message.Subject = $"Install - {licenseKey} - {customerName}";
        message.Body = $"Müşteri: {customerName}\n" +
                       $"Email: {customerEmail}\n" +
                       $"OnayKodu: {licenseKey}\n\n" +
                       $"Parametre1: {parametre1}\n" +
                       $"Parametre2: {parametre2}\n\n" +
                       $"Modüller:\n{moduller}\n\n" +
                       $"Tarih: {DateTime.Now}";

        await client.SendMailAsync(message);

        return Results.Json(new { success = true, message = "Email sent successfully" });
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[LICENSE NOTIFY ERROR] {ex.Message}");
        return Results.Json(new { success = false, message = ex.Message }, statusCode: 500);
    }
});

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

// ===================================================================
// AI SERVISLERI
// ===================================================================
var aiService = new BusinessSmartDesktopAPI.Services.AIService(config);
var riskService = new BusinessSmartDesktopAPI.Services.RiskService(config);
var auditService = new BusinessSmartDesktopAPI.Services.AuditService(config);

// --- Sistem Ayar Sorgula ---
app.MapGet("/api/sistem/ayar/{ayarKodu}", async (string ayarKodu) =>
{
    var deger = await riskService.SistemAyarGetirAsync(ayarKodu);
    return Results.Ok(new { ayarKodu, ayarDeger = deger });
});

// --- Yetki Kontrol ---
app.MapGet("/api/yetki/kontrol", async (int kullaniciId, string form) =>
{
    var yetkili = await riskService.YetkiKontrolAsync(kullaniciId, form);
    return Results.Ok(new { yetkili });
});

// --- Risk Skoru Hesapla ---
app.MapGet("/api/cari/risk-skoru/{firmaId}", async (int firmaId) =>
{
    var aktif = await riskService.SistemAyarGetirAsync("RISK_SKORU_AKTIF");
    if (aktif != "1") return Results.Ok(new { basarili = false, hataMesaji = "Risk skoru modulu aktif degil" });

    var sonuc = await riskService.RiskHesaplaAsync(firmaId);
    if (sonuc == null) return Results.NotFound(new { basarili = false, hataMesaji = "Firma bulunamadi" });

    return Results.Ok(new
    {
        basarili = true,
        firmaId = sonuc.FirmaId,
        firmaAd = sonuc.FirmaAd,
        skor = sonuc.Skor,
        seviye = sonuc.Seviye,
        bakiye = sonuc.Bakiye,
        vadesiGecmisBakiye = sonuc.VadesiGecmisBakiye,
        krediLimiti = sonuc.KrediLimiti,
        gecikmeGun = sonuc.GecikmeGun,
        odemeDisipilin = sonuc.OdemeDisipilin,
        iadeOrani = sonuc.IadeOrani,
        siparisSikligi = sonuc.SiparisSikligi,
        limitKullanim = sonuc.LimitKullanim
    });
});

// --- AI Risk Aciklama ---
app.MapPost("/api/ai/risk-aciklama", async (HttpContext context) =>
{
    var aktif = await riskService.SistemAyarGetirAsync("AI_MODUL_AKTIF");
    if (aktif != "1") return Results.Ok(new { basarili = false, hataMesaji = "AI modulu aktif degil" });

    if (!aiService.IsConfigured) return Results.Ok(new { basarili = false, hataMesaji = "AI API anahtari tanimlanmamis" });

    var body = await JsonSerializer.DeserializeAsync<JsonElement>(context.Request.Body);
    var firmaId = body.GetProperty("firmaId").GetInt32();

    var risk = await riskService.RiskHesaplaAsync(firmaId);
    if (risk == null) return Results.NotFound(new { basarili = false, hataMesaji = "Firma bulunamadi" });

    var (aciklama, oneriler) = await aiService.RiskAciklamaAsync(
        risk.FirmaAd, risk.Bakiye, risk.KrediLimiti, risk.GecikmeGun,
        risk.OdemeDisipilin, risk.IadeOrani, risk.SiparisSikligi, risk.LimitKullanim);

    await auditService.LogAsync(0, "", "AI_RISK_SORGU", "AI",
        $"FirmaID={firmaId}, Skor={risk.Skor}", "gpt-4o-mini");

    return Results.Ok(new
    {
        basarili = true,
        firmaId,
        riskSkoru = risk.Skor,
        riskSeviye = risk.Seviye,
        aciklama,
        oneriler,
        timestamp = DateTime.UtcNow.ToString("o")
    });
});

// --- AI Tahsilat Plani ---
app.MapGet("/api/ai/tahsilat-plani", async (int temsilciId, string? tarih) =>
{
    var aktif = await riskService.SistemAyarGetirAsync("TAHSILAT_AI_AKTIF");
    if (aktif != "1") return Results.Ok(new { basarili = false, hataMesaji = "Tahsilat AI modulu aktif degil" });

    // Bakiyesi olan firmalari getir ve risk skorlarina gore sirala
    var connStr = config["SqlConnectionString"] ?? "";
    var liste = new System.Collections.Generic.List<object>();

    try
    {
        using var conn = new SqlConnection(connStr);
        await conn.OpenAsync();
        var cmd = new SqlCommand(@"
            SELECT TOP 50 r.nFirmaID, f.sAciklama AS FirmaAd, r.lToplamBakiye, r.lVadesiGecmisBakiye,
                   r.nMaxGecikmeGun, r.nRiskSkoru, r.sRiskSeviye, ISNULL(f.sIl,'') AS Il, ISNULL(f.sSemt,'') AS Semt
            FROM tbRiskSkoru r
            INNER JOIN tbFirma f ON r.nFirmaID = f.nFirmaID
            WHERE r.lToplamBakiye > 0 AND r.bAktif = 1
            ORDER BY r.nMaxGecikmeGun DESC, r.lToplamBakiye DESC", conn);

        using var reader = await cmd.ExecuteReaderAsync();
        int oncelik = 1;
        while (await reader.ReadAsync())
        {
            liste.Add(new
            {
                firmaId = Convert.ToInt32(reader["nFirmaID"]),
                firmaAd = reader["FirmaAd"]?.ToString() ?? "",
                bakiye = Convert.ToDecimal(reader["lToplamBakiye"]),
                vadesiGecmis = Convert.ToDecimal(reader["lVadesiGecmisBakiye"]),
                gecikmeGun = Convert.ToInt32(reader["nMaxGecikmeGun"]),
                riskSkoru = Convert.ToInt32(reader["nRiskSkoru"]),
                riskSeviye = reader["sRiskSeviye"]?.ToString() ?? "",
                il = reader["Il"]?.ToString() ?? "",
                semt = reader["Semt"]?.ToString() ?? "",
                oncelik = oncelik++
            });
        }
    }
    catch { }

    string ozet = $"Bugun {liste.Count} firma icin tahsilat onerilmektedir.";
    if (aiService.IsConfigured && liste.Count > 0)
    {
        var aktifAi = await riskService.SistemAyarGetirAsync("AI_MODUL_AKTIF");
        if (aktifAi == "1")
        {
            ozet = await aiService.GenerateAsync(
                "Sen tahsilat planlama asistanisin. Turkce, 2-3 cumle ozet yaz.",
                $"Toplam {liste.Count} firma, tahsilat plani ozeti yaz.");
        }
    }

    await auditService.LogAsync(0, "", "AI_TAHSILAT_PLANI", "AI",
        $"TemsilciID={temsilciId}, FirmaSayisi={liste.Count}");

    return Results.Ok(new { basarili = true, ozet, liste });
});

// --- AI Satis Onerisi ---
app.MapPost("/api/ai/satis-oneri", async (HttpContext context) =>
{
    var aktif = await riskService.SistemAyarGetirAsync("SATIS_ONERI_AKTIF");
    if (aktif != "1") return Results.Ok(new { basarili = false, hataMesaji = "Satis oneri modulu aktif degil" });

    var body = await JsonSerializer.DeserializeAsync<JsonElement>(context.Request.Body);
    var firmaId = body.GetProperty("firmaId").GetInt32();

    var connStr = config["SqlConnectionString"] ?? "";
    var sonSiparisler = new StringBuilder();
    string firmaAd = "";

    try
    {
        using var conn = new SqlConnection(connStr);
        await conn.OpenAsync();

        // Firma adini al
        var cmdFirma = new SqlCommand("SELECT ISNULL(sAciklama,'') FROM tbFirma WHERE nFirmaID=@fid", conn);
        cmdFirma.Parameters.AddWithValue("@fid", firmaId);
        firmaAd = (await cmdFirma.ExecuteScalarAsync())?.ToString() ?? "";

        // Son 6 ay siparisleri
        var cmd = new SqlCommand(@"
            SELECT TOP 30 StokAdi, SUM(lMiktar) AS ToplamMiktar, COUNT(*) AS SiparisSayisi, MAX(dteFisTarihi) AS SonTarih
            FROM vw_AI_SatisGecmisi WHERE nFirmaID=@fid
            GROUP BY StokAdi ORDER BY SiparisSayisi DESC", conn);
        cmd.Parameters.AddWithValue("@fid", firmaId);

        using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            sonSiparisler.AppendLine($"- {reader["StokAdi"]}: {reader["ToplamMiktar"]} adet, {reader["SiparisSayisi"]} siparis, son: {reader["SonTarih"]}");
        }
    }
    catch { }

    if (!aiService.IsConfigured || string.IsNullOrEmpty(sonSiparisler.ToString()))
    {
        return Results.Ok(new { basarili = true, oneriler = new object[0] });
    }

    var sonuc = await aiService.SatisOneriAsync(firmaAd, sonSiparisler.ToString());

    var oneriler = new System.Collections.Generic.List<object>();
    foreach (var line in sonuc.Split('\n'))
    {
        if (line.Trim().StartsWith("ONERI:"))
        {
            var parts = line.Trim().Substring(6).Split('|');
            if (parts.Length >= 2)
            {
                oneriler.Add(new
                {
                    urunAd = parts[0].Trim(),
                    neden = parts.Length > 1 ? parts[1].Trim() : "",
                    tahminMiktar = parts.Length > 2 ? parts[2].Trim() : ""
                });
            }
        }
    }

    await auditService.LogAsync(0, "", "AI_SATIS_ONERI", "AI",
        $"FirmaID={firmaId}, OneriSayisi={oneriler.Count}", "gpt-4o-mini");

    return Results.Ok(new { basarili = true, firmaAd, oneriler });
});

// --- AI Gun Sonu Ozet ---
app.MapGet("/api/ai/gun-sonu-ozet", async (string? tarih) =>
{
    var aktif = await riskService.SistemAyarGetirAsync("YONETICI_OZET_AKTIF");
    if (aktif != "1") return Results.Ok(new { basarili = false, hataMesaji = "Yonetici ozet modulu aktif degil" });

    var connStr = config["SqlConnectionString"] ?? "";
    decimal toplamSatis = 0, toplamTahsilat = 0;
    int faturaSayisi = 0;
    string hedefTarih = tarih ?? DateTime.Now.ToString("yyyy-MM-dd");

    try
    {
        using var conn = new SqlConnection(connStr);
        await conn.OpenAsync();

        var cmdSatis = new SqlCommand(@"
            SELECT ISNULL(SUM(lNetTutar + lKdvTutar), 0), COUNT(*)
            FROM tbStokFisiMaster WHERE sFisTipi='FS' AND CONVERT(DATE, dteFisTarihi) = @tarih", conn);
        cmdSatis.Parameters.AddWithValue("@tarih", hedefTarih);
        using var r1 = await cmdSatis.ExecuteReaderAsync();
        if (await r1.ReadAsync()) { toplamSatis = r1.GetDecimal(0); faturaSayisi = r1.GetInt32(1); }
        r1.Close();

        var cmdTahsilat = new SqlCommand(@"
            SELECT ISNULL(SUM(lTutar), 0)
            FROM tbFirmaHareketi WHERE sBorcAlacak='A' AND CONVERT(DATE, dteIslemTarihi) = @tarih", conn);
        cmdTahsilat.Parameters.AddWithValue("@tarih", hedefTarih);
        toplamTahsilat = Convert.ToDecimal(await cmdTahsilat.ExecuteScalarAsync() ?? 0);
    }
    catch { }

    string ozet = $"Toplam Satis: {toplamSatis:N2} TL ({faturaSayisi} fatura), Tahsilat: {toplamTahsilat:N2} TL";

    if (aiService.IsConfigured)
    {
        var aktifAi = await riskService.SistemAyarGetirAsync("AI_MODUL_AKTIF");
        if (aktifAi == "1")
        {
            ozet = await aiService.GunSonuOzetAsync(toplamSatis, toplamTahsilat, faturaSayisi, "", "");
        }
    }

    await auditService.LogAsync(0, "", "AI_GUN_SONU_OZET", "AI", $"Tarih={hedefTarih}");

    return Results.Ok(new { basarili = true, tarih = hedefTarih, toplamSatis, toplamTahsilat, faturaSayisi, ozet });
});

// --- Cari Detay ---
app.MapGet("/api/cari/{firmaId}/detay", async (int firmaId) =>
{
    var connStr = config["SqlConnectionString"] ?? "";
    try
    {
        using var conn = new SqlConnection(connStr);
        await conn.OpenAsync();
        var cmd = new SqlCommand(@"
            SELECT f.nFirmaID, RTRIM(ISNULL(f.sAciklama,'')) AS sAciklama, ISNULL(f.sVergiNo,'') AS sVergiNo,
                   ISNULL(RTRIM(f.sIl),'') AS sIl, ISNULL(RTRIM(f.sSemt),'') AS sSemt,
                   ISNULL(RTRIM(f.sUlke),'') AS sUlke, ISNULL(f.sTelefon,'') AS sTelefon,
                   ISNULL(f.lKrediLimiti,0) AS lKrediLimiti, ISNULL(f.nVadeGun,0) AS nVadeGun,
                   (SELECT ISNULL(SUM(CASE WHEN sBorcAlacak='B' THEN lTutar ELSE 0 END),0) - ISNULL(SUM(CASE WHEN sBorcAlacak='A' THEN lTutar ELSE 0 END),0) FROM tbFirmaHareketi WHERE nFirmaID=f.nFirmaID) AS Bakiye,
                   r.nRiskSkoru, r.sRiskSeviye, r.nMaxGecikmeGun
            FROM tbFirma f
            LEFT JOIN tbRiskSkoru r ON f.nFirmaID = r.nFirmaID
            WHERE f.nFirmaID = @fid", conn);
        cmd.Parameters.AddWithValue("@fid", firmaId);

        using var reader = await cmd.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
            return Results.NotFound(new { basarili = false, hataMesaji = "Firma bulunamadi" });

        return Results.Ok(new
        {
            basarili = true,
            firmaId = Convert.ToInt32(reader["nFirmaID"]),
            firmaAd = reader["sAciklama"]?.ToString(),
            vergiNo = reader["sVergiNo"]?.ToString(),
            il = reader["sIl"]?.ToString(),
            semt = reader["sSemt"]?.ToString(),
            ulke = reader["sUlke"]?.ToString(),
            telefon = reader["sTelefon"]?.ToString(),
            krediLimit = Convert.ToDecimal(reader["lKrediLimiti"]),
            vadeGun = Convert.ToInt32(reader["nVadeGun"]),
            bakiye = Convert.ToDecimal(reader["Bakiye"]),
            riskSkoru = reader["nRiskSkoru"] != DBNull.Value ? Convert.ToInt32(reader["nRiskSkoru"]) : (int?)null,
            riskSeviye = reader["sRiskSeviye"]?.ToString(),
            gecikmeGun = reader["nMaxGecikmeGun"] != DBNull.Value ? Convert.ToInt32(reader["nMaxGecikmeGun"]) : 0
        });
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

// --- Perakende Musteri Risk Skoru ---
app.MapGet("/api/perakende/risk-skoru/{musteriId}", async (int musteriId) =>
{
    var aktif = await riskService.SistemAyarGetirAsync("PERAKENDE_RISK_AKTIF");
    if (aktif != "1") return Results.Ok(new { basarili = false, hataMesaji = "Perakende risk modulu aktif degil" });

    var connStr = config["SqlConnectionString"] ?? "";
    try
    {
        using var conn = new SqlConnection(connStr);
        await conn.OpenAsync();
        var cmd = new SqlCommand(@"
            SELECT MusteriAd, KrediLimiti, Bakiye, SonAlisVerisTarihi, SonOdemeTarihi, Son90GunAlisveris
            FROM vw_AI_PerakendeRiskVerisi WHERE nMusteriID = @mid", conn);
        cmd.Parameters.AddWithValue("@mid", musteriId);

        using var reader = await cmd.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
            return Results.NotFound(new { basarili = false, hataMesaji = "Musteri bulunamadi" });

        var musteriAd = reader["MusteriAd"]?.ToString() ?? "";
        var krediLimiti = reader["KrediLimiti"] != DBNull.Value ? Convert.ToDecimal(reader["KrediLimiti"]) : 0;
        var bakiye = reader["Bakiye"] != DBNull.Value ? Convert.ToDecimal(reader["Bakiye"]) : 0;
        var sonAlisveris = reader["SonAlisVerisTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["SonAlisVerisTarihi"]) : (DateTime?)null;
        var sonOdeme = reader["SonOdemeTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["SonOdemeTarihi"]) : (DateTime?)null;
        var siparisSikligi = reader["Son90GunAlisveris"] != DBNull.Value ? Convert.ToInt32(reader["Son90GunAlisveris"]) : 0;

        var limitKullanim = krediLimiti > 0 ? bakiye / krediLimiti : 0;
        var gecikmeGun = sonAlisveris.HasValue && sonOdeme.HasValue ? (int)(sonAlisveris.Value - sonOdeme.Value).TotalDays : 0;
        if (gecikmeGun < 0) gecikmeGun = 0;

        int skor = 100;
        skor -= Math.Min(gecikmeGun * 2, 40);
        if (limitKullanim > 0.9m) skor -= 20;
        else if (limitKullanim > 0.7m) skor -= 10;
        if (bakiye > krediLimiti && krediLimiti > 0) skor -= 15;
        skor = Math.Max(0, Math.Min(100, skor));

        var seviye = skor >= 70 ? "guvenli" : skor >= 40 ? "dikkat" : "kritik";

        return Results.Ok(new
        {
            basarili = true,
            musteriId,
            musteriAd,
            skor,
            seviye,
            bakiye,
            krediLimiti,
            limitKullanim,
            gecikmeGun,
            siparisSikligi,
            sonAlisveris = sonAlisveris?.ToString("yyyy-MM-dd"),
            sonOdeme = sonOdeme?.ToString("yyyy-MM-dd")
        });
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

// ===================================================================
Console.WriteLine("===========================================");
Console.WriteLine("  Business Smart Desktop API");
Console.WriteLine("===========================================");
Console.WriteLine($"  Listening on: {listenUrl}");
Console.WriteLine($"  Updates Path: {updatesPath}");
Console.WriteLine($"  Backups Path: {backupsPath}");
Console.WriteLine($"  Files Path:   {filesPath}");
Console.WriteLine("===========================================");

app.Run(listenUrl);
