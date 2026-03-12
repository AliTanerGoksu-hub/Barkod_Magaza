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
    public class BackupController : ApiController
    {
        // POST api/backup/upload
        [HttpPost]
        public HttpResponseMessage Upload()
        {
            try
            {
                // API Key kontrolü
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                var httpRequest = HttpContext.Current.Request;
                
                if (httpRequest.Files.Count == 0)
                {
                    return CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "No file uploaded" });
                }

                var file = httpRequest.Files[0];
                var clientId = httpRequest.Headers["X-Client-Id"] ?? "unknown";
                var backupsPath = ConfigurationManager.AppSettings["BackupsPath"];
                
                // Client için klasör oluştur
                var clientPath = Path.Combine(backupsPath, SanitizeFolderName(clientId));
                if (!Directory.Exists(clientPath))
                {
                    Directory.CreateDirectory(clientPath);
                }

                // Dosya adı: original_name_timestamp.ext
                var originalName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var newFileName = string.Format("{0}_{1}{2}", originalName, DateTime.Now.ToString("yyyyMMdd_HHmmss"), extension);
                var filePath = Path.Combine(clientPath, newFileName);

                // Dosyayı kaydet
                file.SaveAs(filePath);

                var fileInfo = new FileInfo(filePath);

                return CreateResponse(HttpStatusCode.OK, new
                {
                    success = true,
                    message = "Backup uploaded successfully",
                    fileName = newFileName,
                    fileSize = fileInfo.Length,
                    uploadTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                });
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        // GET api/backup/list
        [HttpGet]
        public HttpResponseMessage List()
        {
            try
            {
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                var clientId = HttpContext.Current.Request.Headers["X-Client-Id"] ?? HttpContext.Current.Request.QueryString["clientId"];
                
                if (string.IsNullOrEmpty(clientId))
                {
                    return CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "Client ID required" });
                }

                var backupsPath = ConfigurationManager.AppSettings["BackupsPath"];
                var clientPath = Path.Combine(backupsPath, SanitizeFolderName(clientId));

                var backups = new List<BackupInfo>();

                if (Directory.Exists(clientPath))
                {
                    var files = Directory.GetFiles(clientPath);
                    foreach (var file in files)
                    {
                        var fileInfo = new FileInfo(file);
                        backups.Add(new BackupInfo
                        {
                            FileName = fileInfo.Name,
                            FileSize = fileInfo.Length,
                            CreatedDate = fileInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")
                        });
                    }
                }

                return CreateResponse(HttpStatusCode.OK, new
                {
                    success = true,
                    clientId = clientId,
                    backupCount = backups.Count,
                    backups = backups
                });
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        // GET api/backup/download?file=xxx
        [HttpGet]
        public HttpResponseMessage Download()
        {
            try
            {
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                var clientId = HttpContext.Current.Request.Headers["X-Client-Id"] ?? HttpContext.Current.Request.QueryString["clientId"];
                var fileName = HttpContext.Current.Request.QueryString["file"];

                if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(fileName))
                {
                    return CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "Client ID and file name required" });
                }

                fileName = Path.GetFileName(fileName); // Güvenlik
                var backupsPath = ConfigurationManager.AppSettings["BackupsPath"];
                var filePath = Path.Combine(backupsPath, SanitizeFolderName(clientId), fileName);

                if (!File.Exists(filePath))
                {
                    return CreateResponse(HttpStatusCode.NotFound, new { success = false, message = "Backup not found" });
                }

                var response = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                response.Content = new StreamContent(stream);
                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
                {
                    FileName = fileName
                };
                
                return response;
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        // DELETE api/backup/delete?file=xxx
        [HttpDelete]
        public HttpResponseMessage Delete()
        {
            try
            {
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                var clientId = HttpContext.Current.Request.Headers["X-Client-Id"] ?? HttpContext.Current.Request.QueryString["clientId"];
                var fileName = HttpContext.Current.Request.QueryString["file"];

                if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(fileName))
                {
                    return CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "Client ID and file name required" });
                }

                fileName = Path.GetFileName(fileName);
                var backupsPath = ConfigurationManager.AppSettings["BackupsPath"];
                var filePath = Path.Combine(backupsPath, SanitizeFolderName(clientId), fileName);

                if (!File.Exists(filePath))
                {
                    return CreateResponse(HttpStatusCode.NotFound, new { success = false, message = "Backup not found" });
                }

                File.Delete(filePath);

                return CreateResponse(HttpStatusCode.OK, new
                {
                    success = true,
                    message = "Backup deleted successfully"
                });
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        private string SanitizeFolderName(string name)
        {
            // Güvenli klasör adı oluştur
            var invalid = Path.GetInvalidFileNameChars();
            foreach (var c in invalid)
            {
                name = name.Replace(c, '_');
            }
            return name;
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

    public class BackupInfo
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string CreatedDate { get; set; }
    }
}
