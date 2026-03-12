Imports Newtonsoft.Json
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Net.Http
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Configuration
Imports Newtonsoft.Json.Linq
Imports System.Data
Imports System.Data.OleDb

Public Class frm_KolaysoftTest
    Inherits System.Windows.Forms.Form
    Private token As String
    Dim gibUser As String = ""
    Dim gibPass As String = ""
    Private Sub frm_KolaysoftTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Dim cmdParam As New OleDbCommand("SELECT TOP 1 * FROM tbParamGenel", con)
        Dim drParam = cmdParam.ExecuteReader()
        If drParam.Read() Then
            gibUser = drParam("GibKullanici").ToString().Trim()
            gibPass = drParam("GibSifre").ToString().Trim()

        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim result As Object = Nothing
        Dim responseContent As String = String.Empty
        Try
            Dim kullanici = gibUser
            Dim sifre = gibPass

            If String.IsNullOrEmpty(kullanici) OrElse String.IsNullOrEmpty(sifre) Then
                MessageBox.Show("Kullanıcı adı ve şifre gerekli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Using client As New HttpClient()
                Dim requestBody = New With {
                .username = kullanici,
                .password = sifre
            }
                Dim jsonBody = JsonConvert.SerializeObject(requestBody)
                Dim content = New StringContent(jsonBody, Encoding.UTF8, "application/json")
                Dim response = client.PostAsync("https://demo.kolaysoftpos.com/api/erp-authenticate", content).Result
                responseContent = response.Content.ReadAsStringAsync().Result

                If response.IsSuccessStatusCode Then
                    result = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseContent) ' Tipi netleştir
                    If result IsNot Nothing AndAlso result.ContainsKey("id_token") AndAlso result.ContainsKey("companyId") Then
                        lblDurum.Text = "✔ Giriş Başarılı"
                        Dim rawToken As String = result("id_token").ToString()
                        lblToken.Text = rawToken
                        lblFirma.Text = "Firma ID: " & result("companyId").ToString()
                    Else
                        lblDurum.Text = "❌ Giriş Başarısız"
                        MessageBox.Show("Geçersiz yanıt formatı: id_token veya companyId eksik. Yanıt: " & responseContent, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    lblDurum.Text = "❌ Giriş Başarısız"
                    MessageBox.Show("API isteği başarısız: " & response.StatusCode.ToString() & " (" & response.ReasonPhrase & ")" & vbCrLf & "Yanıt: " & responseContent, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As JsonException
            lblDurum.Text = "❌ Hata"
            MessageBox.Show("JSON ayrıştırma hatası: " & ex.Message & vbCrLf & "Yanıt: " & If(String.IsNullOrEmpty(responseContent), "Boş", responseContent), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            lblDurum.Text = "❌ Hata"
            MessageBox.Show("Giriş sırasında hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnPosListesi_Click(sender As Object, e As EventArgs) Handles btnPosListesi.Click
        Try
            Dim token As String = lblToken.Text
            If String.IsNullOrEmpty(token) Then
                MessageBox.Show("Lütfen önce giriş yapınız. Token alınamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim companyId As String = lblFirma.Text.Replace("Firma ID: ", "").Trim()
            Dim url As String = "https://demo.kolaysoftpos.com/services/pos/api/erp/pos-devices?companyId=" & companyId

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("Authorization", "Bearer " & token)

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim result As String = reader.ReadToEnd()
                    txtSonuc.Text = result
                    KolaysoftEntegrasyon.LogYaz("Test_PosCihazlari", result)
                End Using
            End Using
        Catch ex As WebException
            Dim responseText As String = ""
            If ex.Response IsNot Nothing Then
                Using reader As New StreamReader(ex.Response.GetResponseStream())
                    responseText = reader.ReadToEnd()
                End Using
            End If
            txtSonuc.Text = "Hata: Uzak sunucu hatası - " & ex.Message & vbCrLf & "Yanıt: " & responseText
            MessageBox.Show("POS listesi alınırken hata oluştu: " & ex.Message & vbCrLf & "Sunucu yanıtı: " & responseText, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            txtSonuc.Text = "Hata: " & ex.Message
            MessageBox.Show("POS listesi alınırken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnFaturaTest_Click(sender As Object, e As EventArgs) Handles btnFaturaTest.Click
        Try
            If String.IsNullOrEmpty(token) Then
                token = lblToken.Text
            End If
            Dim sonuc As String = TestFaturaGonder()
            If sonuc IsNot Nothing AndAlso sonuc.Contains("Hata") Then
                txtSonuc.Text = "Fatura testi başarısız."
                MessageBox.Show("API hatası: " & sonuc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(sonuc) Then
                txtSonuc.Text = "Fatura testi başarısız."
            Else
                txtSonuc.Text = sonuc
                KolaysoftEntegrasyon.LogYaz("Test_Fatura", sonuc)
            End If
        Catch ex As WebException
            Dim response As String
            Dim statusCode = CType(ex.Response, HttpWebResponse)?.StatusCode
            Using stream As Stream = ex.Response?.GetResponseStream()
                response = If(stream IsNot Nothing, New StreamReader(stream).ReadToEnd(), "Yanıt alınamadı")
            End Using
            txtSonuc.Text = $"Hata: Uzak sunucu hatası ({statusCode}) - {ex.Message} (Yanıt: {response})"
            KolaysoftEntegrasyon.LogYaz("Test_Fatura_Hata", $"WebException: {ex.Message}, Yanıt: {response}")
            MessageBox.Show($"Fatura testi sırasında ağ hatası ({statusCode}): {ex.Message}{Environment.NewLine}Sunucu yanıtı: {response}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As JsonException
            txtSonuc.Text = $"Hata: JSON ayrıştırma hatası - {ex.Message}"
            KolaysoftEntegrasyon.LogYaz("Test_Fatura_Hata", $"JsonException: {ex.Message}")
            MessageBox.Show($"Fatura testi sırasında JSON hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            txtSonuc.Text = $"Hata: {ex.Message}"
            KolaysoftEntegrasyon.LogYaz("Test_Fatura_Hata", $"Exception: {ex.Message}")
            MessageBox.Show($"Fatura testi sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetAuthenticationToken() As String
        Dim request As HttpWebRequest = CType(WebRequest.Create("https://demo.kolaysoftpos.com/api/erp-authenticate"), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"

        Dim jsonBody As String = $"{{ ""username"": ""{gibUser}"", ""password"": ""{gibPass}"" }}"

        Dim data As Byte() = Encoding.UTF8.GetBytes(jsonBody)
        request.ContentLength = data.Length

        Using stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
        End Using

        Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                Dim jsonResponse = reader.ReadToEnd()
                Dim parsed As JObject = JObject.Parse(jsonResponse)
                If parsed("id_token") IsNot Nothing Then
                    Return parsed("id_token").ToString()
                Else
                    Throw New Exception("Token alınamadı. Sunucu yanıtı: " & jsonResponse)
                End If
            End Using
        End Using
    End Function
    Private Function TestFaturaGonder() As String
        Dim token As String = lblToken.Text
        If String.IsNullOrEmpty(token) Then
            Throw New Exception("Token alınamadı, lütfen authentication'ı kontrol edin.")
        End If

        KolaysoftEntegrasyon.LogYaz("UsedToken", $"Kullanılan Token: {token}")
        Dim apiUrl As String = "https://demo.kolaysoftpos.com/services/pos/api/erp/invoices"
        Dim request As HttpWebRequest = CType(WebRequest.Create(apiUrl), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", $"Bearer {token}")

        Dim jsonBody As String = "
{
  ""totalAmount"": 100.0,
  ""companyId"": " & lblFirma.Text.Replace("Firma ID: ", "") & ",
  ""source"": ""ERP_RETAIL"",
  ""products"": [
    {
      ""quantity"": 1,
      ""taxedTotalAmount"": 100.0,
      ""productName"": ""Deneme Ürün"",
      ""productBarcode"": ""9999999999999""
    }
  ]
}"
        Dim data As Byte() = Encoding.UTF8.GetBytes(jsonBody)
        request.ContentLength = data.Length
        Using stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
        End Using
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Using reader As New StreamReader(response.GetResponseStream())
            Dim responseJson As String = reader.ReadToEnd()
            MsgBox("Başarılı yanıt: " & responseJson)
        End Using

    End Function
    Private Sub btnPrintTest_Click(sender As Object, e As EventArgs) Handles btnPrintTest.Click
        Try
            Dim cihazId As String = txtDeviceId.Text.Trim()
            If String.IsNullOrEmpty(cihazId) Then
                MessageBox.Show("Lütfen cihaz ID giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim token As String = lblToken.Text
            If String.IsNullOrEmpty(token) Then
                MessageBox.Show("Lütfen önce giriş yapınız. Token alınamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim companyId As String = lblFirma.Text.Replace("Firma ID: ", "").Trim()

            ' JSON body - ödeme bilgisi dahil
            Dim jsonBody As String = "
        {
          ""totalAmount"": 1.0,
          ""companyId"": " & companyId & ",
          ""source"": ""ERP_RETAIL"",
          ""terminalSerialNumber"": """ & cihazId & """,
          ""products"": [
            {
              ""quantity"": 1,
              ""taxedTotalAmount"": 1.0,
              ""productName"": ""Test Ürün"",
              ""productBarcode"": ""0000000000000""
            }
          ],
          ""paymentTypes"": [
            {
              ""paymentType"": ""CASH"",
              ""amount"": 1.0
            }
          ]
        }"

            Dim apiUrl As String = "https://demo.kolaysoftpos.com/services/pos/api/erp/invoices"
            Dim request As HttpWebRequest = CType(WebRequest.Create(apiUrl), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            request.Headers.Add("Authorization", "Bearer " & token)

            Dim data As Byte() = Encoding.UTF8.GetBytes(jsonBody)
            request.ContentLength = data.Length
            Using stream = request.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim result As String = reader.ReadToEnd()
                    txtSonuc.Text = result
                    KolaysoftEntegrasyon.LogYaz("Test_Print", result)
                End Using
            End Using
        Catch ex As WebException
            Dim response As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
            txtSonuc.Text = "Hata: " & ex.Message & " (Yanıt: " & response & ")"
            MessageBox.Show("Yazdırma sırasında hata oluştu: " & ex.Message & vbCrLf & "Sunucu yanıtı: " & response, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            txtSonuc.Text = "Hata: " & ex.Message
            MessageBox.Show("Yazdırma sırasında hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPosDurum_Click(sender As Object, e As EventArgs) Handles btnPosDurum.Click
        Try
            Dim token As String = lblToken.Text
            If String.IsNullOrEmpty(token) Then
                MessageBox.Show("Token bulunamadı. Önce giriş yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim companyId As String = lblFirma.Text.Replace("Firma ID: ", "").Trim()
            Dim url As String = "https://demo.kolaysoftpos.com/services/pos/api/erp/pos-payments?companyId.equals=" & companyId & "&page=0&size=10"

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("Authorization", "Bearer " & token)

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim result As String = reader.ReadToEnd()
                    txtSonuc.Text = result
                    KolaysoftEntegrasyon.LogYaz("Test_PosDurum", result)
                End Using
            End Using
        Catch ex As WebException
            Dim responseText As String = ""
            If ex.Response IsNot Nothing Then
                Using reader As New StreamReader(ex.Response.GetResponseStream())
                    responseText = reader.ReadToEnd()
                End Using
            End If
            txtSonuc.Text = "Hata: " & ex.Message & vbCrLf & "Yanıt: " & responseText
            MessageBox.Show("POS işlem durumu alınamadı: " & ex.Message & vbCrLf & responseText, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            txtSonuc.Text = "Hata: " & ex.Message
            MessageBox.Show("POS işlem durumu alınırken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class