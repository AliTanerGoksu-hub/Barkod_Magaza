Imports Microsoft.Win32
Public Class frm_otoMail

    Private Sub durum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles durum.CheckedChanged
        If durum.Checked = True Then
            durum.Text = "Otomatik Gönderim Aktif."
        Else
            durum.Text = "Otomatik Gönderim Pasif."
        End If
    End Sub

    Private Sub frm_otoMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            durum.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoMail").GetValue("durum")
            zaman.Value = Int(Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoMail").GetValue("zaman"))
            adres.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoMail").GetValue("adres")
            Dim defaultSaat As String = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoMail").GetValue("saat", "18:00").ToString()
            saatPicker.Value = Date.Parse(defaultSaat)
        Catch ex As Exception
            ' Default deÄŸerler
            zaman.Value = 1
            saatPicker.Value = Date.Parse("18:00")
            
            ' Email adresini tbParamGenel'den al
            adres.Text = GetEmailFromParamGenel()
            
            ' Email dolu ise Aktif, boÅŸ ise Pasif
            durum.Checked = Not String.IsNullOrWhiteSpace(adres.Text)
        End Try

        saatPicker.Format = DateTimePickerFormat.Time
        saatPicker.ShowUpDown = True
        Me.Controls.Add(saatPicker)
    End Sub

    ''' <summary>
    ''' tbParamGenel tablosundan Email adresini al
    ''' </summary>
    Private Function GetEmailFromParamGenel() As String
        Try
            ' Registry'den connection string ve firmano al
            Dim connectionStr As String = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU").ToString()
            Dim firmaNo As Integer = Integer.Parse(Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").GetValue("nFirma").ToString())
            
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            cmd.Connection = con
            con.ConnectionString = connectionStr
            
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            
            cmd.CommandText = "SELECT Email FROM tbParamGenel WHERE nFirmaNo = " & firmaNo
            Dim result As Object = cmd.ExecuteScalar()
            
            con.Close()
            cmd.Dispose()
            con.Dispose()
            
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return result.ToString().Trim()
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoMail").SetValue("durum", durum.Checked.ToString())
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoMail").SetValue("adres", adres.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoMail").SetValue("zaman", zaman.Value.ToString())
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoMail").SetValue("saat", saatPicker.Value.ToString("HH:mm"))

        Form1.otoMail = durum.Checked
        Form1.otoMailDakika = zaman.Value * 60
        Form1.otoMailAdres = adres.Text
        Form1.otoMailSaat = saatPicker.Value.TimeOfDay ' Form1'de Public otoMailSaat As TimeSpan tanýmlayýn
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class

' Form1'de:
' Public otoMailSaat As TimeSpan
' Private WithEvents Timer1 As New Timer()

' Private Sub Form1_Load(...) Handles MyBase.Load
'     ' ... diðer kodlar
'     BaslatTimer()
' End Sub

' Private Sub BaslatTimer()
'     If otoMail Then
'         Dim hedefSaat As TimeSpan = otoMailSaat
'         Dim suAn As TimeSpan = Now.TimeOfDay
'         Dim gecikme As TimeSpan = If(suAn < hedefSaat, hedefSaat - suAn, TimeSpan.FromDays(1) + hedefSaat - suAn)
'         Timer1.Interval = Math.Min(CInt(gecikme.TotalMilliseconds), Integer.MaxValue) ' Interval max 2^31-1 ms
'         Timer1.Start()
'     End If
' End Sub

' Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
'     ' E-posta gönderme kodunuz
'     Timer1.Interval = 86400000 ' 24 saat
' End Sub