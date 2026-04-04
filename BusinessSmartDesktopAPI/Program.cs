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
// AI YARDIMCI ENDPOINTLER (Sistem Ayar, Yetki, Perakende Risk)
// ===================================================================
var sqlConnStrUtil = config["SqlConnectionString"] ?? "";

// --- Sistem Ayar Sorgula ---
app.MapGet("/api/sistem/ayar/{ayarKodu}", async (HttpContext context, string ayarKodu) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);
    try
    {
        using var conn = new SqlConnection(sqlConnStrUtil);
        await conn.OpenAsync();
        var cmd = new SqlCommand("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu=@kod", conn);
        cmd.Parameters.AddWithValue("@kod", ayarKodu);
        var result = await cmd.ExecuteScalarAsync();
        return Results.Ok(new { ayarKodu, ayarDeger = result?.ToString() ?? "0" });
    }
    catch { return Results.Ok(new { ayarKodu, ayarDeger = "0" }); }
});

// --- Yetki Kontrol ---
app.MapGet("/api/yetki/kontrol", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);
    try
    {
        var kullaniciId = int.Parse(context.Request.Query["kullaniciId"].FirstOrDefault() ?? "0");
        var form = context.Request.Query["form"].FirstOrDefault() ?? "";
        using var conn = new SqlConnection(sqlConnStrUtil);
        await conn.OpenAsync();
        var cmd = new SqlCommand(@"SELECT ISNULL(y.bYetki, f.DefaultYetki)
            FROM aEmirForms f
            LEFT JOIN aPersonelYetki y ON f.nFormID = y.nFormID AND y.nPersonelID = @kid
            WHERE f.Form = @form", conn);
        cmd.Parameters.AddWithValue("@kid", kullaniciId);
        cmd.Parameters.AddWithValue("@form", form);
        var result = await cmd.ExecuteScalarAsync();
        return Results.Ok(new { yetkili = result != null && Convert.ToInt32(result) > 0 });
    }
    catch { return Results.Ok(new { yetkili = false }); }
});

// --- Perakende Musteri Risk Skoru ---
app.MapGet("/api/perakende/risk-skoru/{musteriId}", async (HttpContext context, int musteriId) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);
    try
    {
        using var conn = new SqlConnection(sqlConnStrUtil);
        await conn.OpenAsync();
        var cmd = new SqlCommand(@"SELECT MusteriAd, KrediLimiti, Bakiye, SonAlisVerisTarihi,
            SonOdemeTarihi, Son90GunAlisveris
            FROM vw_AI_PerakendeRiskVerisi WHERE nMusteriID = @mid", conn);
        cmd.Parameters.AddWithValue("@mid", musteriId);
        using var reader = await cmd.ExecuteReaderAsync();
        if (!await reader.ReadAsync())
            return Results.NotFound(new { success = false, message = "Musteri bulunamadi" });

        var musteriAd = reader["MusteriAd"]?.ToString() ?? "";
        var krediLimiti = reader["KrediLimiti"] != DBNull.Value ? Convert.ToDecimal(reader["KrediLimiti"]) : 0;
        var bakiye = reader["Bakiye"] != DBNull.Value ? Convert.ToDecimal(reader["Bakiye"]) : 0;
        var sonAlisveris = reader["SonAlisVerisTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["SonAlisVerisTarihi"]) : (DateTime?)null;
        var sonOdeme = reader["SonOdemeTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["SonOdemeTarihi"]) : (DateTime?)null;
        var siparisSikligi = reader["Son90GunAlisveris"] != DBNull.Value ? Convert.ToInt32(reader["Son90GunAlisveris"]) : 0;

        var limitKullanim = krediLimiti > 0 ? bakiye / krediLimiti : 0;
        var gecikmeGun = sonAlisveris.HasValue && sonOdeme.HasValue
            ? (int)(sonAlisveris.Value - sonOdeme.Value).TotalDays : 0;
        if (gecikmeGun < 0) gecikmeGun = 0;

        int skor = 100;
        skor -= Math.Min(gecikmeGun * 2, 40);
        if (limitKullanim > 0.9m) skor -= 20;
        else if (limitKullanim > 0.7m) skor -= 10;
        if (bakiye > krediLimiti && krediLimiti > 0) skor -= 15;
        skor = Math.Max(0, Math.Min(100, skor));

        return Results.Ok(new
        {
            success = true, musteriId, musteriAd, skor,
            seviye = skor >= 70 ? "guvenli" : skor >= 40 ? "dikkat" : "kritik",
            bakiye, krediLimiti, limitKullanim, gecikmeGun, siparisSikligi,
            sonAlisveris = sonAlisveris?.ToString("yyyy-MM-dd"),
            sonOdeme = sonOdeme?.ToString("yyyy-MM-dd")
        });
    }
    catch (Exception ex)
    {
        return Results.Json(new { success = false, message = ex.Message }, statusCode: 500);
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



// ==================== AI & IS ZEKASI API ====================
// LLM, Risk Analizi, Tahsilat Plani, Satis Oneri, Siparis Onay, Gun Sonu Ozet

var aiApiKey = config["AI:ApiKey"] ?? "";
var aiApiUrl = config["AI:ApiUrl"] ?? "https://api.openai.com/v1/chat/completions";
var aiModel = config["AI:Model"] ?? "gpt-4o-mini";
var sqlConnStrAI = config["SqlConnectionString"] ?? "";

var llmService = new BusinessSmartDesktopAPI.Services.LLMService(aiApiKey, aiApiUrl, aiModel);
var auditService = new BusinessSmartDesktopAPI.Services.AuditService(sqlConnStrAI);

// --- POST /api/ai/risk-analiz ---
app.MapPost("/api/ai/risk-analiz", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        using var reader = new StreamReader(context.Request.Body);
        var body = await reader.ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(body);
        if (data == null) return Results.BadRequest(new { success = false });

        var firmaAdi = data.ContainsKey("firmaAdi") ? data["firmaAdi"].GetString() ?? "" : "";
        var bakiye = data.ContainsKey("bakiye") ? data["bakiye"].GetDecimal() : 0;
        var gecikmisBakiye = data.ContainsKey("gecikmisBakiye") ? data["gecikmisBakiye"].GetDecimal() : 0;
        var maxGecikmeGun = data.ContainsKey("maxGecikmeGun") ? data["maxGecikmeGun"].GetInt32() : 0;
        var gecikmisTaksit = data.ContainsKey("gecikmisTaksit") ? data["gecikmisTaksit"].GetInt32() : 0;
        var krediLimiti = data.ContainsKey("krediLimiti") ? data["krediLimiti"].GetDecimal() : 0;
        var bekleyenTutar = data.ContainsKey("bekleyenTutar") ? data["bekleyenTutar"].GetDecimal() : 0;
        var bekleyenAdet = data.ContainsKey("bekleyenAdet") ? data["bekleyenAdet"].GetInt32() : 0;
        var riskSkor = data.ContainsKey("riskSkor") ? data["riskSkor"].GetInt32() : 0;
        var ortOdemeSuresi = data.ContainsKey("ortOdemeSuresi") ? data["ortOdemeSuresi"].GetInt32() : 0;
        var kaynak = data.ContainsKey("kaynak") ? data["kaynak"].GetString() ?? "toptan" : "toptan";

        // Kural bazli analiz (her zaman calisir)
        var (kuralAciklama, oneriler, satisKarari) = BusinessSmartDesktopAPI.Services.KuralMotoru.RiskDegerlendirme(
            bakiye, gecikmisBakiye, gecikmisTaksit, maxGecikmeGun,
            krediLimiti, bekleyenAdet, bekleyenTutar, ortOdemeSuresi, riskSkor);

        // AI analiz (API key varsa)
        string aiAciklama = "";
        if (llmService.IsConfigured)
        {
            aiAciklama = await llmService.RiskAnaliziAsync(
                firmaAdi, kaynak, riskSkor, bakiye, gecikmisBakiye, gecikmisTaksit,
                maxGecikmeGun, krediLimiti, bekleyenAdet, bekleyenTutar, ortOdemeSuresi);
        }

        // Audit log
        await auditService.LogAsync(
            context.Request.Headers["X-User"].FirstOrDefault() ?? "system",
            "AI_RISK_ANALIZ", "risk",
            new { firmaAdi, riskSkor, bakiye, gecikmisBakiye },
            llmService.IsConfigured ? aiModel : "kural_bazli",
            context.Connection.RemoteIpAddress?.ToString());

        return Results.Json(new
        {
            success = true,
            riskSkor,
            seviye = riskSkor >= 70 ? "guvenli" : riskSkor >= 40 ? "dikkat" : "kritik",
            kuralBazliAciklama = kuralAciklama,
            oneriler = string.Join("\n", oneriler),
            satisKarari,
            aiAciklama,
            aiAktif = llmService.IsConfigured,
            tarih = DateTime.Now.ToString("dd.MM.yyyy HH:mm")
        });
    }
    catch (Exception ex)
    {
        return Results.Json(new { success = false, message = ex.Message }, statusCode: 500);
    }
});

// --- POST /api/ai/risk-aciklama (firmaId ile DB'den veri cekip analiz) ---
app.MapPost("/api/ai/risk-aciklama", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        using var bodyReader = new StreamReader(context.Request.Body);
        var body = await bodyReader.ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(body);
        if (data == null) return Results.BadRequest(new { success = false });

        var firmaId = data.ContainsKey("firmaId") ? data["firmaId"].GetInt32() : 0;
        if (firmaId <= 0) return Results.BadRequest(new { success = false, message = "firmaId gerekli" });

        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();

        // Firma bilgisi + risk verileri tek sorguda
        var sql = @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT 
                f.sAciklama AS FirmaAd, ISNULL(f.lKrediLimiti, 0) AS KrediLimiti,
                ISNULL(SUM(h.lBorcTutar - h.lAlacakTutar), 0) AS Bakiye,
                ISNULL(SUM(CASE WHEN h.lBorcTutar > 0 AND h.dteValorTarihi < GETDATE() THEN h.lBorcTutar - h.lAlacakTutar ELSE 0 END), 0) AS GecikmisBakiye,
                ISNULL(MAX(CASE WHEN h.lBorcTutar > 0 AND h.dteValorTarihi < GETDATE() THEN DATEDIFF(DAY, h.dteValorTarihi, GETDATE()) ELSE 0 END), 0) AS MaxGecikme,
                ISNULL(SUM(CASE WHEN h.lBorcTutar > 0 AND h.dteValorTarihi < GETDATE() THEN 1 ELSE 0 END), 0) AS GecikmisFatura
            FROM tbFirma f
            LEFT JOIN tbFirmaHareketi h ON f.nFirmaID = h.nFirmaID
            WHERE f.nFirmaID = @firmaId
            GROUP BY f.sAciklama, f.lKrediLimiti";

        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@firmaId", firmaId);
        using var reader = await cmd.ExecuteReaderAsync();

        if (!reader.Read())
            return Results.NotFound(new { success = false, message = "Firma bulunamadi" });

        var firmaAd = reader["FirmaAd"]?.ToString() ?? "";
        var bakiye = Convert.ToDecimal(reader["Bakiye"]);
        var gecikmisBakiye = Convert.ToDecimal(reader["GecikmisBakiye"]);
        var maxGecikme = Convert.ToInt32(reader["MaxGecikme"]);
        var gecikmisFatura = Convert.ToInt32(reader["GecikmisFatura"]);
        var krediLimiti = Convert.ToDecimal(reader["KrediLimiti"]);
        reader.Close();

        // Bekleyen siparisler
        var sipSql = "SELECT ISNULL(COUNT(DISTINCT lSiparisNo),0) AS Adet, ISNULL(SUM(lTutari),0) AS Tutar FROM tbSiparis WHERE nFirmaID=@fid AND ISNULL(bKapandimi,0)=0";
        using var sipCmd = new SqlCommand(sipSql, conn);
        sipCmd.Parameters.AddWithValue("@fid", firmaId);
        using var sipReader = await sipCmd.ExecuteReaderAsync();
        int bekAdet = 0; decimal bekTutar = 0;
        if (sipReader.Read()) { bekAdet = Convert.ToInt32(sipReader["Adet"]); bekTutar = Convert.ToDecimal(sipReader["Tutar"]); }
        sipReader.Close();

        // Risk skoru hesapla
        int skor = 100;
        if (maxGecikme > 90) skor -= 40;
        else if (maxGecikme > 60) skor -= 30;
        else if (maxGecikme > 30) skor -= 20;
        else if (maxGecikme > 0) skor -= 10;
        if (gecikmisFatura >= 4) skor -= 15;
        else if (gecikmisFatura >= 2) skor -= 10;
        if (krediLimiti > 0 && (bakiye + bekTutar) > krediLimiti) skor -= 20;
        else if (krediLimiti > 0 && (bakiye + bekTutar) / krediLimiti > 0.9m) skor -= 15;
        skor = Math.Max(0, Math.Min(100, skor));

        var (kuralAciklama, oneriler, satisKarari) = BusinessSmartDesktopAPI.Services.KuralMotoru.RiskDegerlendirme(
            bakiye, gecikmisBakiye, gecikmisFatura, maxGecikme, krediLimiti, bekAdet, bekTutar, 0, skor);

        string aiAciklama = "";
        if (llmService.IsConfigured)
        {
            aiAciklama = await llmService.RiskAnaliziAsync(firmaAd, "toptan", skor, bakiye, gecikmisBakiye, gecikmisFatura, maxGecikme, krediLimiti, bekAdet, bekTutar, 0);
        }

        await auditService.LogAsync("system", "AI_RISK_ACIKLAMA", "risk", new { firmaId, firmaAd, skor }, llmService.IsConfigured ? aiModel : "kural_bazli");

        return Results.Json(new
        {
            success = true,
            firmaId, firmaAd,
            riskSkor = skor,
            seviye = skor >= 70 ? "guvenli" : skor >= 40 ? "dikkat" : "kritik",
            aciklama = kuralAciklama,
            oneriler = oneriler,
            satisKarari,
            aiAciklama,
            aiAktif = llmService.IsConfigured,
            tarih = DateTime.Now.ToString("dd.MM.yyyy HH:mm")
        });
    }
    catch (Exception ex)
    {
        return Results.Json(new { success = false, message = ex.Message }, statusCode: 500);
    }
});

// --- GET /api/cari/risk-skoru/{firmaId} ---
app.MapGet("/api/cari/risk-skoru/{firmaId}", async (HttpContext context, int firmaId) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();
        var sql = @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT ISNULL(SUM(lBorcTutar-lAlacakTutar),0) AS Bakiye,
                   ISNULL(SUM(CASE WHEN lBorcTutar>0 AND dteValorTarihi<GETDATE() THEN lBorcTutar-lAlacakTutar ELSE 0 END),0) AS VadesiGecmis,
                   ISNULL(MAX(CASE WHEN lBorcTutar>0 AND dteValorTarihi<GETDATE() THEN DATEDIFF(DAY,dteValorTarihi,GETDATE()) ELSE 0 END),0) AS MaxGecikme
            FROM tbFirmaHareketi WHERE nFirmaID=@fid";
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@fid", firmaId);
        using var r = await cmd.ExecuteReaderAsync();
        decimal bakiye=0, vadesiGecmis=0; int maxGecikme=0;
        if(r.Read()){ bakiye=Convert.ToDecimal(r["Bakiye"]); vadesiGecmis=Convert.ToDecimal(r["VadesiGecmis"]); maxGecikme=Convert.ToInt32(r["MaxGecikme"]); }
        r.Close();

        var limSql = "SELECT ISNULL(lKrediLimiti,0) FROM tbFirma WHERE nFirmaID=@fid";
        using var limCmd = new SqlCommand(limSql, conn);
        limCmd.Parameters.AddWithValue("@fid", firmaId);
        decimal krediLimiti = Convert.ToDecimal(await limCmd.ExecuteScalarAsync() ?? 0);

        int skor = 100;
        if(maxGecikme>90) skor-=40; else if(maxGecikme>60) skor-=30; else if(maxGecikme>30) skor-=20; else if(maxGecikme>0) skor-=10;
        if(krediLimiti>0 && bakiye/krediLimiti>0.9m) skor-=15;
        skor=Math.Max(0,Math.Min(100,skor));

        return Results.Json(new {
            success=true, skor, seviye=skor>=70?"guvenli":skor>=40?"dikkat":"kritik",
            bakiye, vadesiGecmis, maxGecikme, krediLimiti,
            limitKullanim = krediLimiti>0 ? Math.Round(bakiye/krediLimiti,2) : 0
        });
    }
    catch(Exception ex) { return Results.Json(new{success=false,message=ex.Message},statusCode:500); }
});

// --- POST /api/siparis/onay-kontrol ---
app.MapPost("/api/siparis/onay-kontrol", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        using var bodyReader = new StreamReader(context.Request.Body);
        var body = await bodyReader.ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(body);
        if (data == null) return Results.BadRequest(new { success = false });

        var firmaId = data["firmaId"].GetInt32();
        var siparisTutari = data["siparisTutari"].GetDecimal();

        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();

        // Bakiye + Limit
        var sql = @"SELECT ISNULL(f.lKrediLimiti,0) AS KrediLimiti,
            ISNULL((SELECT SUM(lBorcTutar-lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID=@fid),0) AS Bakiye,
            ISNULL((SELECT MAX(DATEDIFF(DAY,dteValorTarihi,GETDATE())) FROM tbFirmaHareketi WHERE nFirmaID=@fid AND lBorcTutar>0 AND dteValorTarihi<GETDATE()),0) AS MaxGecikme,
            ISNULL((SELECT SUM(lTutari) FROM tbSiparis WHERE nFirmaID=@fid AND ISNULL(bKapandimi,0)=0),0) AS AcikSiparis
            FROM tbFirma f WHERE f.nFirmaID=@fid";

        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@fid", firmaId);
        using var r = await cmd.ExecuteReaderAsync();
        if (!r.Read()) return Results.NotFound(new { success = false, message = "Firma bulunamadi" });

        var krediLimiti = Convert.ToDecimal(r["KrediLimiti"]);
        var bakiye = Convert.ToDecimal(r["Bakiye"]);
        var maxGecikme = Convert.ToInt32(r["MaxGecikme"]);
        var acikSiparis = Convert.ToDecimal(r["AcikSiparis"]);
        r.Close();

        var uyarilar = new List<string>();
        bool onay = true;

        // Is kurallari
        decimal toplamYuk = bakiye + acikSiparis + siparisTutari;
        if (maxGecikme > 45)
        {
            onay = false;
            uyarilar.Add($"45 gunu asan gecikme mevcut ({maxGecikme} gun). Veresiye satis yapilamaz.");
        }

        if (krediLimiti > 0 && toplamYuk > krediLimiti)
        {
            uyarilar.Add($"Bu siparis ile toplam yuk ({toplamYuk:N2} TL) kredi limitini ({krediLimiti:N2} TL) asacak.");
            if (toplamYuk > krediLimiti * 1.2m) onay = false;
        }

        if (bakiye > 0 && krediLimiti > 0 && bakiye / krediLimiti > 0.8m)
        {
            uyarilar.Add($"Kredi limitinin %{Math.Round(bakiye / krediLimiti * 100, 0)}'i kullanilmis.");
        }

        if (maxGecikme > 30)
        {
            uyarilar.Add($"30 gun ustu gecikme var ({maxGecikme} gun). Dikkatli olunmali.");
        }

        int skor = 100;
        if(maxGecikme>60) skor-=30; else if(maxGecikme>30) skor-=20; else if(maxGecikme>0) skor-=10;
        if(krediLimiti>0 && toplamYuk>krediLimiti) skor-=20;
        skor=Math.Max(0,Math.Min(100,skor));

        await auditService.LogAsync("system", "SIPARIS_ONAY_KONTROL", "siparis", new { firmaId, siparisTutari, onay, skor });

        return Results.Json(new
        {
            success = true, onayDurumu = onay,
            uyarilar,
            riskSeviye = skor >= 70 ? "guvenli" : skor >= 40 ? "dikkat" : "kritik",
            riskSkor = skor,
            mevcut = new { bakiye, krediLimiti, maxGecikme, acikSiparis },
            yeniToplamYuk = toplamYuk
        });
    }
    catch (Exception ex) { return Results.Json(new { success = false, message = ex.Message }, statusCode: 500); }
});

// --- GET /api/ai/tahsilat-plani ---
app.MapGet("/api/ai/tahsilat-plani", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var temsilciId = context.Request.Query["temsilciId"].FirstOrDefault() ?? "0";
        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();

        var sql = @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT TOP 20 f.nFirmaID, RTRIM(f.sAciklama) AS FirmaAd, RTRIM(ISNULL(f.sIl,'')) AS Il,
                ISNULL(SUM(h.lBorcTutar-h.lAlacakTutar),0) AS Bakiye,
                ISNULL(MAX(CASE WHEN h.lBorcTutar>0 AND h.dteValorTarihi<GETDATE() THEN DATEDIFF(DAY,h.dteValorTarihi,GETDATE()) ELSE 0 END),0) AS GecikmeGun,
                ISNULL(f.lKrediLimiti,0) AS KrediLimiti
            FROM tbFirma f
            INNER JOIN tbFirmaHareketi h ON f.nFirmaID=h.nFirmaID
            GROUP BY f.nFirmaID, f.sAciklama, f.sIl, f.lKrediLimiti
            HAVING SUM(h.lBorcTutar-h.lAlacakTutar) > 0
            ORDER BY MAX(CASE WHEN h.lBorcTutar>0 AND h.dteValorTarihi<GETDATE() THEN DATEDIFF(DAY,h.dteValorTarihi,GETDATE()) ELSE 0 END) DESC, SUM(h.lBorcTutar-h.lAlacakTutar) DESC";

        using var cmd = new SqlCommand(sql, conn);
        using var r = await cmd.ExecuteReaderAsync();

        var liste = new List<Dictionary<string, object>>();
        decimal toplamBakiye = 0;
        while (r.Read())
        {
            var bakiye = Convert.ToDecimal(r["Bakiye"]);
            var gecikme = Convert.ToInt32(r["GecikmeGun"]);
            toplamBakiye += bakiye;
            int skor = 100;
            if(gecikme>60) skor-=30; else if(gecikme>30) skor-=20; else if(gecikme>0) skor-=10;
            liste.Add(new Dictionary<string, object> {
                {"firmaId", Convert.ToInt32(r["nFirmaID"])}, {"firmaAd", r["FirmaAd"].ToString()!},
                {"il", r["Il"].ToString()!}, {"bakiye", bakiye}, {"gecikmeGun", gecikme},
                {"krediLimiti", Convert.ToDecimal(r["KrediLimiti"])},
                {"riskSeviye", skor>=70?"guvenli":skor>=40?"dikkat":"kritik"},
                {"oncelik", liste.Count+1}
            });
        }
        r.Close();

        string aiOzet = "";
        if (llmService.IsConfigured && liste.Count > 0)
        {
            aiOzet = await llmService.TahsilatPlaniAsync("Temsilci", liste);
        }

        string kuralOzet = $"Bugun {liste.Count} musteriden tahsilat yapilmasi onerilmektedir. Toplam bakiye: {toplamBakiye:N2} TL.";
        if (liste.Count > 0)
        {
            var ilk = liste[0];
            kuralOzet += $" En oncelikli: {ilk["firmaAd"]} ({ilk["bakiye"]:N2} TL, {ilk["gecikmeGun"]} gun gecikme).";
        }

        await auditService.LogAsync("system", "TAHSILAT_PLANI", "tahsilat", new { temsilciId, musteriSayisi = liste.Count });

        return Results.Json(new { success = true, ozet = kuralOzet, aiOzet, aiAktif = llmService.IsConfigured, toplamBakiye, musteriSayisi = liste.Count, liste });
    }
    catch (Exception ex) { return Results.Json(new { success = false, message = ex.Message }, statusCode: 500); }
});

// --- POST /api/ai/satis-oneri ---
app.MapPost("/api/ai/satis-oneri", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        using var bodyReader = new StreamReader(context.Request.Body);
        var body = await bodyReader.ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(body);
        var firmaId = data!["firmaId"].GetInt32();

        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();

        // Son 6 ay satis gecmisi
        var sql = @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT TOP 20 s.sKodu AS StokKodu, RTRIM(s.sAciklama) AS StokAdi,
                SUM(d.lCikisMiktar1) AS ToplamMiktar, COUNT(DISTINCT m.nStokFisiID) AS SiparisSayisi,
                MAX(m.dteFisTarihi) AS SonSiparisTarih, AVG(d.lCikisFiyat) AS OrtFiyat
            FROM tbStokFisiMaster m
            INNER JOIN tbStokFisiDetayi d ON m.nStokFisiID=d.nStokFisiID
            INNER JOIN tbStok s ON d.nStokID=s.nStokID
            WHERE m.nFirmaID=@fid AND m.sFisTipi IN ('FS','FT') AND m.dteFisTarihi>=DATEADD(MONTH,-6,GETDATE())
            GROUP BY s.sKodu, s.sAciklama
            ORDER BY COUNT(DISTINCT m.nStokFisiID) DESC, SUM(d.lCikisMiktar1) DESC";

        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@fid", firmaId);
        using var r = await cmd.ExecuteReaderAsync();

        var sonSiparisler = new List<Dictionary<string, object>>();
        while (r.Read())
        {
            sonSiparisler.Add(new Dictionary<string, object> {
                {"stokKodu", r["StokKodu"].ToString()!}, {"stokAdi", r["StokAdi"].ToString()!},
                {"toplamMiktar", Convert.ToDecimal(r["ToplamMiktar"])}, {"siparisSayisi", Convert.ToInt32(r["SiparisSayisi"])},
                {"sonSiparisTarih", Convert.ToDateTime(r["SonSiparisTarih"]).ToString("dd.MM.yyyy")},
                {"ortFiyat", Convert.ToDecimal(r["OrtFiyat"])},
                {"neden", Convert.ToInt32(r["SiparisSayisi"]) >= 3 ? "Duzeli alim yapıyor" : Convert.ToInt32(r["SiparisSayisi"]) >= 2 ? "Tekrarlayan alim" : "Gecmiste almis"}
            });
        }
        r.Close();

        // Firma adi
        using var fCmd = new SqlCommand("SELECT RTRIM(sAciklama) FROM tbFirma WHERE nFirmaID=@fid", conn);
        fCmd.Parameters.AddWithValue("@fid", firmaId);
        var firmaAdi = (await fCmd.ExecuteScalarAsync())?.ToString() ?? "";

        string aiOneri = "";
        if (llmService.IsConfigured && sonSiparisler.Count > 0)
        {
            aiOneri = await llmService.SatisOneriAsync(firmaAdi, sonSiparisler);
        }

        await auditService.LogAsync("system", "SATIS_ONERI", "satis", new { firmaId, urunSayisi = sonSiparisler.Count });

        return Results.Json(new { success = true, firmaId, firmaAdi, oneriler = sonSiparisler, aiOneri, aiAktif = llmService.IsConfigured });
    }
    catch (Exception ex) { return Results.Json(new { success = false, message = ex.Message }, statusCode: 500); }
});

// --- GET /api/ai/gun-sonu-ozet ---
app.MapGet("/api/ai/gun-sonu-ozet", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        var tarih = context.Request.Query["tarih"].FirstOrDefault() ?? DateTime.Now.ToString("yyyy-MM-dd");
        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();

        // Satis ozeti
        var sql = @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT ISNULL(SUM(lNetTutar),0) AS ToplamSatis, COUNT(*) AS FisSayisi,
                ISNULL(MAX(lNetTutar),0) AS EnBuyukSatis
            FROM tbStokFisiMaster WHERE sFisTipi IN ('FS','FT') AND CONVERT(DATE,dteFisTarihi)=@tarih";
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@tarih", tarih);
        using var r = await cmd.ExecuteReaderAsync();
        decimal toplamSatis=0; int fisSayisi=0; decimal enBuyukSatis=0;
        if(r.Read()){ toplamSatis=Convert.ToDecimal(r["ToplamSatis"]); fisSayisi=Convert.ToInt32(r["FisSayisi"]); enBuyukSatis=Convert.ToDecimal(r["EnBuyukSatis"]); }
        r.Close();

        // Tahsilat ozeti
        var tSql = @"SELECT ISNULL(SUM(lAlacakTutar),0) AS ToplamTahsilat FROM tbFirmaHareketi WHERE lAlacakTutar>0 AND CONVERT(DATE,dteIslemTarihi)=@tarih";
        using var tCmd = new SqlCommand(tSql, conn);
        tCmd.Parameters.AddWithValue("@tarih", tarih);
        decimal toplamTahsilat = Convert.ToDecimal(await tCmd.ExecuteScalarAsync() ?? 0);

        string kuralOzet = $"Tarih: {tarih}\nToplam Satis: {toplamSatis:N2} TL ({fisSayisi} fis)\nToplam Tahsilat: {toplamTahsilat:N2} TL\nEn Buyuk Satis: {enBuyukSatis:N2} TL";

        string aiOzet = "";
        if (llmService.IsConfigured)
        {
            aiOzet = await llmService.GunSonuOzetAsync(toplamSatis, toplamTahsilat, fisSayisi, 0, enBuyukSatis, "");
        }

        return Results.Json(new { success = true, tarih, kuralOzet, aiOzet, aiAktif = llmService.IsConfigured, toplamSatis, toplamTahsilat, fisSayisi, enBuyukSatis });
    }
    catch (Exception ex) { return Results.Json(new { success = false, message = ex.Message }, statusCode: 500); }
});

// --- GET /api/cari/{firmaId}/detay ---
app.MapGet("/api/cari/{firmaId}/detay", async (HttpContext context, int firmaId) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();
        var sql = @"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT f.nFirmaID, RTRIM(f.sAciklama) AS FirmaAd, ISNULL(f.sVergiNo,'') AS VergiNo,
                ISNULL(RTRIM(f.sIl),'') AS Il, ISNULL(RTRIM(f.sSemt),'') AS Semt,
                ISNULL(f.lKrediLimiti,0) AS KrediLimiti, ISNULL(f.nVadeGun,0) AS VadeGun,
                ISNULL((SELECT SUM(lBorcTutar-lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID=f.nFirmaID),0) AS Bakiye,
                ISNULL((SELECT MAX(CASE WHEN lBorcTutar>0 AND dteValorTarihi<GETDATE() THEN DATEDIFF(DAY,dteValorTarihi,GETDATE()) ELSE 0 END) FROM tbFirmaHareketi WHERE nFirmaID=f.nFirmaID),0) AS GecikmeGun,
                ISNULL((SELECT MAX(dteIslemTarihi) FROM tbFirmaHareketi WHERE nFirmaID=f.nFirmaID AND lAlacakTutar>0),'1900-01-01') AS SonOdemeTarih
            FROM tbFirma f WHERE f.nFirmaID=@fid";
        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@fid", firmaId);
        using var r = await cmd.ExecuteReaderAsync();
        if (!r.Read()) return Results.NotFound(new { success = false });

        var bakiye = Convert.ToDecimal(r["Bakiye"]);
        var krediLimiti = Convert.ToDecimal(r["KrediLimiti"]);
        var gecikme = Convert.ToInt32(r["GecikmeGun"]);
        int skor=100; if(gecikme>60) skor-=30; else if(gecikme>30) skor-=20; else if(gecikme>0) skor-=10;
        if(krediLimiti>0 && bakiye/krediLimiti>0.9m) skor-=15; skor=Math.Max(0,skor);

        return Results.Json(new {
            success=true, firmaId=Convert.ToInt32(r["nFirmaID"]), firmaAd=r["FirmaAd"].ToString(),
            vergiNo=r["VergiNo"].ToString(), il=r["Il"].ToString(), semt=r["Semt"].ToString(),
            bakiye, krediLimiti, vadeGun=Convert.ToInt32(r["VadeGun"]),
            gecikmeGun=gecikme, sonOdemeTarih=Convert.ToDateTime(r["SonOdemeTarih"]).ToString("yyyy-MM-dd"),
            riskSkoru=skor, riskSeviye=skor>=70?"guvenli":skor>=40?"dikkat":"kritik"
        });
    }
    catch(Exception ex) { return Results.Json(new{success=false,message=ex.Message},statusCode:500); }
});

// --- POST /api/visit-note/add ---
app.MapPost("/api/visit-note/add", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);

    try
    {
        using var bodyReader = new StreamReader(context.Request.Body);
        var body = await bodyReader.ReadToEndAsync();
        var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(body);
        if (data == null) return Results.BadRequest(new { success = false });

        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();

        var sql = @"INSERT INTO tbVisitNote (nFirmaID, nKullaniciID, sNotTipi, sNot, sKonum, sPlatform)
                   VALUES (@firmaId, @kullaniciId, @notTipi, @not, @konum, @platform);
                   SELECT SCOPE_IDENTITY()";

        using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@firmaId", data["firmaId"].GetInt32());
        cmd.Parameters.AddWithValue("@kullaniciId", data.ContainsKey("kullaniciId") ? data["kullaniciId"].GetInt32() : 0);
        cmd.Parameters.AddWithValue("@notTipi", data.ContainsKey("notTipi") ? data["notTipi"].GetString() ?? "genel" : "genel");
        cmd.Parameters.AddWithValue("@not", data.ContainsKey("not") ? data["not"].GetString() ?? "" : "");
        cmd.Parameters.AddWithValue("@konum", data.ContainsKey("konum") ? data["konum"].GetString() ?? "" : "");
        cmd.Parameters.AddWithValue("@platform", data.ContainsKey("platform") ? data["platform"].GetString() ?? "desktop" : "desktop");

        var noteId = Convert.ToInt32(await cmd.ExecuteScalarAsync());

        return Results.Json(new { success = true, noteId });
    }
    catch (Exception ex) { return Results.Json(new { success = false, message = ex.Message }, statusCode: 500); }
});


// ===================================================================
// PERAKENDE OZET ENDPOINT
// ===================================================================
app.MapGet("/api/ai/perakende-ozet", async (HttpContext context) =>
{
    if (!ValidateApiKey(context))
        return Results.Json(new { success = false, message = "Invalid API Key" }, statusCode: 401);
    try
    {
        var tarih = context.Request.Query["tarih"].FirstOrDefault() ?? DateTime.Today.ToString("yyyy-MM-dd");
        using var conn = new SqlConnection(sqlConnStrAI);
        await conn.OpenAsync();

        // Gunluk perakende satis
        var cmdSatis = new SqlCommand(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT COUNT(DISTINCT nAlisverisID) AS FisSayisi,
                   ISNULL(SUM(lNetTutar),0) AS ToplamSatis
            FROM tbAlisVeris
            WHERE CAST(dteFaturaTarihi AS DATE) = @tarih
              AND sFisTipi IN ('K','SK','P','SP','KVF','PD','PTX','KS')", conn);
        cmdSatis.Parameters.AddWithValue("@tarih", tarih);
        using var rdrSatis = await cmdSatis.ExecuteReaderAsync();
        int pFisSayisi = 0;
        decimal pToplamSatis = 0;
        if (await rdrSatis.ReadAsync())
        {
            pFisSayisi = rdrSatis["FisSayisi"] != DBNull.Value ? Convert.ToInt32(rdrSatis["FisSayisi"]) : 0;
            pToplamSatis = rdrSatis["ToplamSatis"] != DBNull.Value ? Convert.ToDecimal(rdrSatis["ToplamSatis"]) : 0;
        }
        rdrSatis.Close();

        // Gunluk perakende tahsilat
        var cmdTahsilat = new SqlCommand(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT ISNULL(SUM(o.lOdemeTutar),0) AS ToplamTahsilat
            FROM tbOdeme o
            INNER JOIN tbAlisVeris a ON o.nAlisverisID = a.nAlisverisID
            WHERE o.nOdemeKodu = 2 AND CAST(o.dteOdemeTarihi AS DATE) = @tarih", conn);
        cmdTahsilat.Parameters.AddWithValue("@tarih", tarih);
        var pToplamTahsilat = Convert.ToDecimal(await cmdTahsilat.ExecuteScalarAsync() ?? 0);

        // Vadesi gecmis taksitler (tum zamanlar)
        var cmdGeciken = new SqlCommand(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT COUNT(DISTINCT m.nMusteriID) AS GecikMusteri,
                   ISNULL(SUM(t.lTutari - ISNULL(od.Odenen,0)),0) AS GecikenTutar
            FROM tbTaksit t
            INNER JOIN tbAlisVeris a ON t.nAlisverisID = a.nAlisverisID
            INNER JOIN tbMusteri m ON a.nMusteriID = m.nMusteriID
            LEFT JOIN (SELECT nTaksitId, SUM(lOdemeTutar) AS Odenen FROM tbOdeme GROUP BY nTaksitId) od
                ON t.nTaksitID = od.nTaksitId
            WHERE t.dteTarihi < GETDATE()
              AND (t.lTutari - ISNULL(od.Odenen,0)) > 0", conn);
        using var rdrGeciken = await cmdGeciken.ExecuteReaderAsync();
        int gecikMusteri = 0;
        decimal gecikenTutar = 0;
        if (await rdrGeciken.ReadAsync())
        {
            gecikMusteri = rdrGeciken["GecikMusteri"] != DBNull.Value ? Convert.ToInt32(rdrGeciken["GecikMusteri"]) : 0;
            gecikenTutar = rdrGeciken["GecikenTutar"] != DBNull.Value ? Convert.ToDecimal(rdrGeciken["GecikenTutar"]) : 0;
        }
        rdrGeciken.Close();

        // Aktif musteri sayisi (son 90 gun alisveris yapan)
        var cmdAktif = new SqlCommand(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT COUNT(DISTINCT nMusteriID) AS AktifMusteri
            FROM tbAlisVeris
            WHERE dteFaturaTarihi >= DATEADD(DAY,-90,GETDATE())
              AND nMusteriID > 0", conn);
        var aktifMusteri = Convert.ToInt32(await cmdAktif.ExecuteScalarAsync() ?? 0);

        // Risk dagilimi (kredi limiti olan musteriler)
        var cmdRisk = new SqlCommand(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT
                SUM(CASE WHEN RiskSkor >= 70 THEN 1 ELSE 0 END) AS Guvenli,
                SUM(CASE WHEN RiskSkor >= 40 AND RiskSkor < 70 THEN 1 ELSE 0 END) AS Dikkat,
                SUM(CASE WHEN RiskSkor < 40 THEN 1 ELSE 0 END) AS Kritik
            FROM (
                SELECT m.nMusteriID,
                    100
                    - CASE WHEN ISNULL(maxGecikme.Gun,0) > 90 THEN 40
                           WHEN ISNULL(maxGecikme.Gun,0) > 60 THEN 30
                           WHEN ISNULL(maxGecikme.Gun,0) > 30 THEN 20
                           WHEN ISNULL(maxGecikme.Gun,0) > 0 THEN 10
                           ELSE 0 END
                    - CASE WHEN k.lKrediLimiti > 0 AND ISNULL(bakiye.Toplam,0) > k.lKrediLimiti THEN 20
                           WHEN k.lKrediLimiti > 0 AND ISNULL(bakiye.Toplam,0) / k.lKrediLimiti > 0.9 THEN 15
                           ELSE 0 END
                    AS RiskSkor
                FROM tbMusteri m
                INNER JOIN tbMusteriKredisi k ON m.nMusteriID = k.nMusteriID
                LEFT JOIN (
                    SELECT a.nMusteriID, SUM(t.lTutari - ISNULL(o.Odenen,0)) AS Toplam
                    FROM tbTaksit t
                    INNER JOIN tbAlisVeris a ON t.nAlisverisID = a.nAlisverisID
                    LEFT JOIN (SELECT nTaksitId, SUM(lOdemeTutar) AS Odenen FROM tbOdeme GROUP BY nTaksitId) o ON t.nTaksitID = o.nTaksitId
                    WHERE (t.lTutari - ISNULL(o.Odenen,0)) > 0
                    GROUP BY a.nMusteriID
                ) bakiye ON m.nMusteriID = bakiye.nMusteriID
                LEFT JOIN (
                    SELECT a.nMusteriID, MAX(DATEDIFF(DAY, t.dteTarihi, GETDATE())) AS Gun
                    FROM tbTaksit t
                    INNER JOIN tbAlisVeris a ON t.nAlisverisID = a.nAlisverisID
                    LEFT JOIN (SELECT nTaksitId, SUM(lOdemeTutar) AS Odenen FROM tbOdeme GROUP BY nTaksitId) o ON t.nTaksitID = o.nTaksitId
                    WHERE t.dteTarihi < GETDATE() AND (t.lTutari - ISNULL(o.Odenen,0)) > 0
                    GROUP BY a.nMusteriID
                ) maxGecikme ON m.nMusteriID = maxGecikme.nMusteriID
                WHERE k.lKrediLimiti > 0
            ) RiskTablosu", conn);
        using var rdrRisk = await cmdRisk.ExecuteReaderAsync();
        int guvenli = 0, dikkat = 0, kritik = 0;
        if (await rdrRisk.ReadAsync())
        {
            guvenli = rdrRisk["Guvenli"] != DBNull.Value ? Convert.ToInt32(rdrRisk["Guvenli"]) : 0;
            dikkat = rdrRisk["Dikkat"] != DBNull.Value ? Convert.ToInt32(rdrRisk["Dikkat"]) : 0;
            kritik = rdrRisk["Kritik"] != DBNull.Value ? Convert.ToInt32(rdrRisk["Kritik"]) : 0;
        }
        rdrRisk.Close();

        // Top 5 geciken musteri
        var cmdTop = new SqlCommand(@"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
            SELECT TOP 5 m.nMusteriID, m.sAdi + ' ' + m.sSoyadi AS MusteriAd,
                   SUM(t.lTutari - ISNULL(o.Odenen,0)) AS GecikenBakiye,
                   MAX(DATEDIFF(DAY, t.dteTarihi, GETDATE())) AS MaxGecikmeGun
            FROM tbTaksit t
            INNER JOIN tbAlisVeris a ON t.nAlisverisID = a.nAlisverisID
            INNER JOIN tbMusteri m ON a.nMusteriID = m.nMusteriID
            LEFT JOIN (SELECT nTaksitId, SUM(lOdemeTutar) AS Odenen FROM tbOdeme GROUP BY nTaksitId) o
                ON t.nTaksitID = o.nTaksitId
            WHERE t.dteTarihi < GETDATE() AND (t.lTutari - ISNULL(o.Odenen,0)) > 0
            GROUP BY m.nMusteriID, m.sAdi, m.sSoyadi
            ORDER BY GecikenBakiye DESC", conn);
        var topGeciken = new List<object>();
        using var rdrTop = await cmdTop.ExecuteReaderAsync();
        while (await rdrTop.ReadAsync())
        {
            topGeciken.Add(new {
                musteriId = Convert.ToInt32(rdrTop["nMusteriID"]),
                musteriAd = rdrTop["MusteriAd"]?.ToString() ?? "",
                gecikenBakiye = Convert.ToDecimal(rdrTop["GecikenBakiye"]),
                maxGecikmeGun = Convert.ToInt32(rdrTop["MaxGecikmeGun"])
            });
        }
        rdrTop.Close();

        return Results.Ok(new {
            success = true,
            tarih,
            gunlukSatis = pToplamSatis,
            gunlukFis = pFisSayisi,
            gunlukTahsilat = pToplamTahsilat,
            gecikMusteri,
            gecikenTutar,
            aktifMusteri,
            riskDagilim = new { guvenli, dikkat, kritik },
            topGecikenMusteriler = topGeciken
        });
    }
    catch (Exception ex) { return Results.Json(new { success = false, message = ex.Message }, statusCode: 500); }
});


app.Run(listenUrl);