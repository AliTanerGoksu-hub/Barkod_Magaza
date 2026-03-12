<%@ Page Language="C#" %>
<!DOCTYPE html>
<html>
<head>
    <title>Business Smart API</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 40px; background: #f5f5f5; }
        .container { background: white; padding: 30px; border-radius: 10px; max-width: 600px; margin: 0 auto; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }
        h1 { color: #2c3e50; }
        .status { color: #27ae60; font-weight: bold; }
        .endpoint { background: #ecf0f1; padding: 10px; margin: 10px 0; border-radius: 5px; font-family: monospace; }
        .method { color: #e74c3c; font-weight: bold; }
    </style>
</head>
<body>
    <div class="container">
        <h1>Business Smart API</h1>
        <p class="status">Status: ONLINE</p>
        <p>Version: 1.0.0</p>
        <p>Server Time: <%= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") %></p>
        
        <h3>Available Endpoints:</h3>
        <div class="endpoint"><span class="method">POST</span> /api/license/verify</div>
        <div class="endpoint"><span class="method">GET</span> /api/update/check</div>
        <div class="endpoint"><span class="method">GET</span> /api/update/download/{filename}</div>
        <div class="endpoint"><span class="method">POST</span> /api/backup/upload</div>
        <div class="endpoint"><span class="method">GET</span> /api/backup/list</div>
        
        <p style="margin-top:20px; color:#7f8c8d; font-size:12px;">
            All requests require X-Api-Key header for authentication.
        </p>
    </div>
</body>
</html>
