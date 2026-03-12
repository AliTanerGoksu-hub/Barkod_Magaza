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
    public class LicenseController : ApiController
    {
        // POST api/license/verify
        [HttpPost]
        public HttpResponseMessage Verify()
        {
            try
            {
                // API Key kontrolü
                if (!ValidateApiKey())
                {
                    return CreateResponse(HttpStatusCode.Unauthorized, new { success = false, message = "Invalid API Key" });
                }

                // Request body'den lisans bilgilerini al
                var content = Request.Content.ReadAsStringAsync().Result;
                var data = ParseJson(content);
                
                string licenseKey = GetValue(data, "licenseKey");
                string machineId = GetValue(data, "machineId");
                string appVersion = GetValue(data, "appVersion");

                if (string.IsNullOrEmpty(licenseKey))
                {
                    return CreateResponse(HttpStatusCode.BadRequest, new { success = false, message = "License key required" });
                }

                // Lisans doğrulama (Basit örnek - kendi veritabanınıza göre düzenleyin)
                var result = ValidateLicense(licenseKey, machineId);
                
                return CreateResponse(HttpStatusCode.OK, new
                {
                    success = result.IsValid,
                    message = result.Message,
                    expiryDate = result.ExpiryDate,
                    features = result.Features,
                    maxUsers = result.MaxUsers
                });
            }
            catch (Exception ex)
            {
                return CreateResponse(HttpStatusCode.InternalServerError, new { success = false, message = ex.Message });
            }
        }

        private LicenseResult ValidateLicense(string licenseKey, string machineId)
        {
            // TODO: Kendi lisans doğrulama mantığınızı buraya ekleyin
            // Şimdilik basit bir kontrol
            
            // Örnek: Lisans anahtarı formatı kontrolü
            if (licenseKey.Length >= 10)
            {
                return new LicenseResult
                {
                    IsValid = true,
                    Message = "License valid",
                    ExpiryDate = DateTime.Now.AddYears(1).ToString("yyyy-MM-dd"),
                    Features = "full",
                    MaxUsers = 10
                };
            }
            
            return new LicenseResult
            {
                IsValid = false,
                Message = "Invalid license key"
            };
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

        private Dictionary<string, string> ParseJson(string json)
        {
            var result = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(json)) return result;
            
            json = json.Trim().TrimStart('{').TrimEnd('}');
            var pairs = json.Split(',');
            foreach (var pair in pairs)
            {
                var keyValue = pair.Split(':');
                if (keyValue.Length == 2)
                {
                    var key = keyValue[0].Trim().Trim('"');
                    var value = keyValue[1].Trim().Trim('"');
                    result[key] = value;
                }
            }
            return result;
        }

        private string GetValue(Dictionary<string, string> dict, string key)
        {
            return dict.ContainsKey(key) ? dict[key] : null;
        }

        private string ToJson(object obj)
        {
            // Basit JSON serialization
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
                else
                    sb.AppendFormat("\"{0}\"", value);
            }
            sb.Append("}");
            return sb.ToString();
        }
    }

    public class LicenseResult
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public string ExpiryDate { get; set; }
        public string Features { get; set; }
        public int MaxUsers { get; set; }
    }
}
