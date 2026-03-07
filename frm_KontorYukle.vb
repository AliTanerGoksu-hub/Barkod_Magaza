Imports System.Data.OleDb
Imports System.Net
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports System.Data
Imports System.IO
Imports System.Net.Http
Imports System.Text

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_KontorYukle
    Inherits System.Windows.Forms.Form

    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter

    Private Sub frm_KontorYukle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ComboBox'a ödeme tiplerini yükle
        cmbOdemeTuru.Items.AddRange(New String() {"Pesin", "Taksit", "Ucretsiz"})
        cmbOdemeTuru.SelectedIndex = 0 ' Varsayılan olarak "Pesin" seçili
        KontorSorgula()
    End Sub

    Private Sub btnYukle_Click(sender As Object, e As EventArgs) Handles btnYukle.Click
        KontorYukleme()
    End Sub

    Private Sub btnSorgula_Click(sender As Object, e As EventArgs) Handles btnSorgula.Click
        KontorSorgula()
    End Sub
#Region "Tasarımcıdan Ayrılmış Kod"
Private Sub KontorYukleme()
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adapter As New OleDbDataAdapter
    Dim sEentegrasyon As Boolean

    con.ConnectionString = connection ' Projedeki global connection kullanıldı
    cmd.CommandTimeout = 0
    cmd.Connection = con

    If con.State = ConnectionState.Closed Then
        con.Open()
    End If

    ' Parametreleri çekiyoruz
    Dim cmdParam As New OleDbCommand("SELECT TOP 1 * FROM tbParamGenel", con)
    Dim drParam = cmdParam.ExecuteReader()
    Dim vkn_tckn As String = ""
    Dim unvan As String = ""
    Dim username As String = ""
    Dim password As String = ""

    If drParam.Read() Then
        vkn_tckn = drParam("sVergiNumarasi").ToString().Trim()
        unvan = drParam("sFirmaAdi").ToString().Trim()
        username = drParam("GibKullanici").ToString().Trim()
        password = drParam("GibSifre").ToString().Trim()
        txtVKN.Text = vkn_tckn
        txtUnvan.Text = unvan
        WriteLog("Yükleme Başlatıldı - VKN: " & vkn_tckn & ", Username: " & username)
    End If
    drParam.Close()

    ' Entegrasyon durumu
    cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sEentegrasyon FROM tbparamgenel"
    adapter.SelectCommand = cmd
    Dim ds As New DataSet
    adapter.Fill(ds)

    If ds.Tables(0).Rows.Count > 0 Then
        sEentegrasyon = ds.Tables(0).Rows(0)("sEentegrasyon")
    End If

    con.Close()

    If sEentegrasyon = True Then
        If XtraMessageBox.Show(Sorgu_sDil("Kontör yüklemek istediğinize emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim odemeTuru As String = cmbOdemeTuru.SelectedItem.ToString()
                Dim birimMiktari As String = txtMiktar.Text.Trim()

                If String.IsNullOrEmpty(birimMiktari) OrElse Not IsNumeric(birimMiktari) OrElse CInt(birimMiktari) <= 0 Then
                    Throw New Exception("Birim Miktarı pozitif bir sayı olmalı.")
                End If

                ' SOAP XML oluşturuluyor
                Dim baslangicTarihi As String = Date.Now.ToString("yyyy-MM-dd")
                Dim sonKullanimTarihi As String = Date.Now.AddMonths(1).ToString("yyyy-MM-dd")

                Dim soapXml As String = $"
<soap:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'
               xmlns:xsd='http://www.w3.org/2001/XMLSchema'
               xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'
               xmlns:kont='http://kontoryuklemeservisi.entegrator.com/'>
  <soap:Header>
    <kont:Username>{username}</kont:Username>
    <kont:Password>{password}</kont:Password>
  </soap:Header>
  <soap:Body>
    <kont:birimTipiyleYuklemeYap>
      <kont:vkn_tckn>{vkn_tckn}</kont:vkn_tckn>
      <kont:birimTuru>FaturaAdedi</kont:birimTuru>
      <kont:islemTuru>Satinalma</kont:islemTuru>
      <kont:krediTuru>
        <kont:odemeTuru>{odemeTuru}</kont:odemeTuru>
        <kont:birimMiktari>{birimMiktari}</kont:birimMiktari>
        <kont:baslangicTarihi>{baslangicTarihi}</kont:baslangicTarihi>
        <kont:sonKullanimTarihi>{sonKullanimTarihi}</kont:sonKullanimTarihi>
      </kont:krediTuru>
    </kont:birimTipiyleYuklemeYap>
  </soap:Body>
</soap:Envelope>"

                WriteLog("SOAP İstek XML: " & soapXml)

                ' Web isteği hazırlanıyor
                Dim request As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://servis.smartdonusum.com/KontorYuklemeServisi/KontorYuklemeWS"), HttpWebRequest)
                request.Method = "POST"
                request.ContentType = "text/xml; charset=utf-8"
                request.Accept = "text/xml"

                Dim bytes As Byte() = Encoding.UTF8.GetBytes(soapXml)
                request.ContentLength = bytes.Length

                Using stream = request.GetRequestStream()
                    stream.Write(bytes, 0, bytes.Length)
                End Using

                Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim responseXml As String = reader.ReadToEnd()
                    WriteLog("SOAP Yanıt: " & responseXml)
                    XtraMessageBox.Show("Kontör yükleme başarılı yanıt aldı: " & responseXml, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

            Catch ex As WebException
                Dim errorResponse As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
                WriteLog("SOAP Hata: " & ex.Message & " - Yanıt: " & errorResponse)
                XtraMessageBox.Show("SOAP isteğinde hata oluştu: " & ex.Message & vbCrLf & errorResponse, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As Exception
                WriteLog("Yükleme Genel Hatası: " & ex.Message)
                XtraMessageBox.Show("Kontör yükleme sırasında hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End If
End Sub

    Private Sub KontorSorgula()
        Dim con As New OleDbConnection
        con.ConnectionString = connection ' Projedeki global connection kullanıldı

        Dim cmdParam As New OleDbCommand("SELECT TOP 1 * FROM tbParamGenel", con)
        cmdParam.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim drParam = cmdParam.ExecuteReader()
        Dim vkn_tckn As String = ""
        Dim unvan As String = ""
        Dim username As String = ""
        Dim password As String = ""

        If drParam.Read() Then
            vkn_tckn = drParam("sVergiNumarasi").ToString().Trim()
            unvan = drParam("sFirmaAdi").ToString().Trim()
            username = drParam("GibKullanici").ToString().Trim()
            password = drParam("GibSifre").ToString().Trim()
            txtVKN.Text = vkn_tckn
            txtUnvan.Text = unvan
            WriteLog("Sorgulama Başlatıldı - VKN: " & vkn_tckn & ", Username: " & username)
        End If
        drParam.Close()
        con.Close()

        Try
            ' SOAP XML hazırlanıyor
            Dim soapXml As String = $"
<soap:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'
               xmlns:xsd='http://www.w3.org/2001/XMLSchema'
               xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'
               xmlns:kont='http://kontoryuklemeservisi.entegrator.com/'>
  <soap:Header>
    <kont:Username>{username}</kont:Username>
    <kont:Password>{password}</kont:Password>
  </soap:Header>
  <soap:Body>
    <kont:kalanKontorSorgula>
      <kont:vkn_tckn>{vkn_tckn}</kont:vkn_tckn>
      <kont:birimTuru>FaturaAdedi</kont:birimTuru>
    </kont:kalanKontorSorgula>
  </soap:Body>
</soap:Envelope>"

            WriteLog("SOAP Sorgu XML: " & soapXml)

            Dim request As HttpWebRequest = DirectCast(HttpWebRequest.Create("https://servis.smartdonusum.com/KontorYuklemeServisi/KontorYuklemeWS"), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "text/xml; charset=utf-8"
            request.Accept = "text/xml"

            Dim data As Byte() = Encoding.UTF8.GetBytes(soapXml)
            request.ContentLength = data.Length
            Using stream = request.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using

            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Using reader As New StreamReader(response.GetResponseStream())
                Dim responseXml As String = reader.ReadToEnd()
                WriteLog("SOAP Yanıt: " & responseXml)

                ' Basit bakiye ayıklama örneği (detaylı XPath ile geliştirilebilir)
                Dim bakiye As String = ""
                Dim match = System.Text.RegularExpressions.Regex.Match(responseXml, "Kalan Dokuman Sayısı[^:]*:\s*(\d+)")
                If match.Success Then
                    bakiye = match.Groups(1).Value
                Else
                    bakiye = "Bilinmiyor"
                End If

                lblBakiye.Text = "Bakiye: " & bakiye
            End Using

        Catch ex As WebException
            Dim errorResponse As String = New StreamReader(ex.Response.GetResponseStream()).ReadToEnd()
            WriteLog("SOAP Hata: " & ex.Message & " - Yanıt: " & errorResponse)
            XtraMessageBox.Show("Sorgulama sırasında hata oluştu: " & ex.Message & vbCrLf & errorResponse, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            WriteLog("Genel Sorgulama Hatası: " & ex.Message)
            XtraMessageBox.Show("Kontör sorgulama sırasında hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ParseBakiye(response As String) As String
        Dim bakiye As String = "Bilinmiyor"
        If response.Contains("Kalan Dokuman Sayisi") Then
            bakiye = response.Split("Kalan Dokuman Sayisi:")(1).Split(" ")(0)
        End If
        Return bakiye
    End Function

    Private Sub WriteLog(message As String)
        Try
            Dim logPath As String = Path.Combine(Application.StartupPath, "KontorSorgulamaLog.txt") ' Log dosyası uygulama dizinine yazılır
            Using writer As New StreamWriter(logPath, True) ' True ile append mode
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - " & message)
            End Using
        Catch ex As Exception
            XtraMessageBox.Show("Log yazma hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class