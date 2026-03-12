using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace BusinessSmartAPI.Controllers
{
    public class UpdateController : ApiController
    {
        // GET api/update/check
        [HttpGet]
        public HttpResponseMessage Check()
        {
            try
            {
                // API Key kontrolü
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                string currentVersion = HttpContext.Current.Request.QueryString["version"] ?? "0.0.0";
                string appName = HttpContext.Current.Request.QueryString["app"] ?? "business_smart";

                var updatesPath = ConfigurationManager.AppSettings["UpdatesPath"];
                
                // Güncelleme klasöründeki dosyaları kontrol et
                var updates = new List<UpdateInfo>();
                
                if (Directory.Exists(updatesPath))
                {
                    var files = Directory.GetFiles(updatesPath, "*.exe");
                    foreach (var file in files)
                    {
                        var fileInfo = new FileInfo(file);
                        updates.Add(new UpdateInfo
                        {
                            FileName = fileInfo.Name,
                            FileSize = fileInfo.Length,
                            LastModified = fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"),
                            DownloadUrl = "/api/update/download?file=" + fileInfo.Name
                        });
                    }
                }

                return CreateResponse(HttpStatusCode.OK, new
                {
                    success = true,
                    currentVersion = currentVersion,
                    updates = updates,
                    hasUpdate = updates.Count > 0
                });
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        // GET api/update/download?file=business_smart.exe
        [HttpGet]
        public HttpResponseMessage Download()
        {
            try
            {
                // API Key kontrolü
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                string fileName = HttpContext.Current.Request.QueryString["file"];
                
                if (string.IsNullOrEmpty(fileName))
                {
                    return CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "File name required" });
                }

                // Güvenlik: Sadece dosya adı kabul et, path traversal engelle
                fileName = Path.GetFileName(fileName);
                
                var updatesPath = ConfigurationManager.AppSettings["UpdatesPath"];
                var filePath = Path.Combine(updatesPath, fileName);

                if (!File.Exists(filePath))
                {
                    return CreateResponse(HttpStatusCode.NotFound, new { success = false, message = "File not found" });
                }

                // Dosyayı stream olarak gönder
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                response.Content = new StreamContent(stream);
                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
                {
                    FileName = fileName
                };
                response.Content.Headers.ContentLength = stream.Length;
                
                return response;
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        // GET api/update/info?file=business_smart.exe
        [HttpGet]
        public HttpResponseMessage Info()
        {
            try
            {
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                string fileName = HttpContext.Current.Request.QueryString["file"];
                
                if (string.IsNullOrEmpty(fileName))
                {
                    return CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "File name required" });
                }

                fileName = Path.GetFileName(fileName);
                var updatesPath = ConfigurationManager.AppSettings["UpdatesPath"];
                var filePath = Path.Combine(updatesPath, fileName);

                if (!File.Exists(filePath))
                {
                    return CreateResponse(HttpStatusCode.NotFound, new { success = false, message = "File not found" });
                }

                var fileInfo = new FileInfo(filePath);
                
                return CreateResponse(HttpStatusCode.OK, new
                {
                    success = true,
                    fileName = fileInfo.Name,
                    fileSize = fileInfo.Length,
                    lastModified = fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
                });
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        private bool ValidateApiKey()
        {
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];
            var requestKey = HttpContext.Current.Request.Headers["X-Api-Key"];
            return !string.IsNullOrEmpty(requestKey) && requestKey == apiKey;
        }

        private HttpResponseMessage CreateResponse(HttpStatusCode statusCode, object data)
        {
            var response = Request.CreateResponse(statusCode);
            response.Content = new StringContent(ToJson(data), Encoding.UTF8, "application/json");
            return response;
        }

        private string ToJson(object obj)
        {
            var sb = new StringBuilder();
            sb.Append("{");
            var props = obj.GetType().GetProperties();
            var first = true;
            foreach (var prop in props)
            {
                if (!first) sb.Append(",");
                first = false;
                var value = prop.GetValue(obj, null);
                sb.AppendFormat("\"{0}\":", prop.Name.ToLower());
                if (value == null)
                    sb.Append("null");
                else if (value is bool)
                    sb.Append(value.ToString().ToLower());
                else if (value is int || value is long || value is double)
                    sb.Append(value);
                else if (value is System.Collections.IEnumerable && !(value is string))
                {
                    sb.Append("[");
                    var firstItem = true;
                    foreach (var item in (System.Collections.IEnumerable)value)
                    {
                        if (!firstItem) sb.Append(",");
                        firstItem = false;
                        sb.Append(ToJson(item));
                    }
                    sb.Append("]");
                }
                else
                    sb.AppendFormat("\"{0}\"", value);
            }
            sb.Append("}");
            return sb.ToString();
        }
    }

    public class UpdateInfo
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string LastModified { get; set; }
        public string DownloadUrl { get; set; }
    }
}
