
Imports System.Security.Cryptography
    Imports System.Text
    Imports System.IO

Module frm_qnb_modul
    Sub MakePayment()

        Dim endpoint As String = "https://vpos.qnbfinansbank.com/Gateway/Default.aspx"

        Dim clientid As String = "08730000010785" ' MerchantID from image

        Dim userid As String = "yoncalines" ' UserCode

        Dim password As String = "y8WVe" ' UserPass - replace with actual

        Dim storekey As String = "37276443" ' MerchantPass

        Dim storetype As String = "3D" ' For 3D Secure

        Dim txntype As String = "Auth"

        Dim amount As String = "1.00" ' Test amount

        Dim currency As String = "949" ' TL

        Dim oid As String = "TestOrder" & DateTime.Now.ToString("yyyyMMddHHmmss")

        Dim okUrl As String = "http://yourdomain.com/success.aspx" ' Replace

        Dim failUrl As String = "http://yourdomain.com/fail.aspx" ' Replace

        Dim rnd As String = DateTime.Now.ToString("yyyyMMddHHmmss")

        Dim taksit As String = "" ' Installment, empty for no

        Dim hashstr As String = clientid & oid & amount & okUrl & failUrl & txntype & taksit & rnd & storekey

        Dim hashbytes As Byte() = SHA1.Create().ComputeHash(Encoding.GetEncoding("ISO-8859-9").GetBytes(hashstr))

        Dim hash As String = Convert.ToBase64String(hashbytes)

        Dim html As StringBuilder = New StringBuilder()

        html.Append("<html><body>")

        html.Append("<form name='form1' method='post' action='" & endpoint & "'>")

        html.Append("<input type='hidden' name='clientid' value='" & clientid & "'>")

        html.Append("<input type='hidden' name='userid' value='" & userid & "'>")

        html.Append("<input type='hidden' name='password' value='" & password & "'>")

        html.Append("<input type='hidden' name='storetype' value='" & storetype & "'>")

        html.Append("<input type='hidden' name='txntype' value='" & txntype & "'>")

        html.Append("<input type='hidden' name='amount' value='" & amount & "'>")

        html.Append("<input type='hidden' name='currency' value='" & currency & "'>")

        html.Append("<input type='hidden' name='oid' value='" & oid & "'>")

        html.Append("<input type='hidden' name='okUrl' value='" & okUrl & "'>")

        html.Append("<input type='hidden' name='failUrl' value='" & failUrl & "'>")

        html.Append("<input type='hidden' name='rnd' value='" & rnd & "'>")

        html.Append("<input type='hidden' name='hash' value='" & hash & "'>")

        html.Append("<input type='hidden' name='lang' value='tr'>")

        ' Card info if non-3D, but for 3D, user enters on bank page

        html.Append("</form>")

        html.Append("<script>document.form1.submit();</script>")

        html.Append("</body></html>")

        ' Save to file or show in WebBrowser control

        File.WriteAllText("payment.html", html.ToString())

        System.Diagnostics.Process.Start("payment.html")

    End Sub

End Module

