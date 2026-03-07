Imports Microsoft.Win32
Imports System.Collections.Generic
Imports System.Net.Mail
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Net
Public Class frm_Gonderi
    Public firmano As String
    Public donemno As String
    Public kullanici As String
    Public connection As String
    Dim ds_tbSatisMagaza As DataSet
    Dim ds_tbSatisTahsilat As DataSet
    Dim ds_tbSatisSinif As DataSet
    Dim ds_tbSatisSatici As DataSet
    Dim dataset1 As DataSet
    Dim ds1 As DataSet
    Dim nakit As Decimal = 0
    Dim masraf As Decimal = 0
    Public pos As Boolean = False
    Public nPosIslem As Integer = 0
    Dim tutar As Decimal = 0
    Dim maliyet As Decimal = 0
    Dim kar As Decimal = 0
    Dim satiskari As Decimal = 0
    Dim miktar As Decimal = 0
    Dim sayi As Decimal = 0
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub mail_gonder()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim smtpServer As New SmtpClient()
        Using mail As New MailMessage()
            smtpServer.Credentials = New NetworkCredential("barkodsmart@gmail.com", "cscsfzjbiaztjsmc")
            smtpServer.Port = 587
            smtpServer.Host = "smtp.gmail.com"
            smtpServer.EnableSsl = True
            mail.From = New MailAddress("barkodsmart@gmail.com")
            ' Çoklu email desteği (; veya , ile ayrılmış)
            Dim emailAdresleri As String = If(Form1.otoMailKontrol, Form1.otoMailAdres, txt_mail.Text)
            Dim emailList() As String = emailAdresleri.Split(New Char() {";"c, ","c}, StringSplitOptions.RemoveEmptyEntries)
            For Each emailAddr As String In emailList
                mail.To.Add(emailAddr.Trim())
            Next
            mail.Subject = String.Format("Gönderi-{0}-{1}-{2}", kullaniciadi, txt_sKimden.Text, txt_sKonu.Text)
            'mail.Body = String.Format("Mail:{0}{1}Kimden: {2}{1}Öncelik:  {3}{1}{1}{4}", txt_mail.Text, vbCrLf, txt_sKimden.Text, txt_sOncelik.Text, Replace(txt_sMesaj.HtmlText, "<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">", ""))
            mail.Body = (txt_sMesaj1.Text)
            mail.IsBodyHtml = True
            Try
                smtpServer.Send(mail)
                Label8.Text = "Mail Gönderildi..." & Now
                If Form1.otoMailKontrol = False Then
                    XtraMessageBox.Show("Raporunuz Başarıyla Gönderilmiştir...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                Label8.Text = "Mail Gönderilemedi..."
                If Form1.otoMailKontrol = False Then
                    XtraMessageBox.Show(String.Format("Raporunuz Gönderilemedi...!{0}Lütfen Daha Sonra Tekrar Deneyiniz...!", vbCrLf), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Try
        End Using
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        If Form1.otoMailKontrol = True Then
            Timer1.Enabled = False
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        mail_gonder()
    End Sub
    Private Sub frm_Gonderi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.Value = Today
        DateEdit2.Value = Today
        
        If Form1.otoMailKontrol = True Then
            ' Otomatik mail modunda tüm raporları default seçili yap
            For i As Integer = 0 To sec_sIslem.Items.Count - 1
                sec_sIslem.SetItemChecked(i, True)
            Next
            
            timer1S = 900
            Timer1.Enabled = True
        End If
    End Sub
    Private Function dataload_satis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1) As String
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim kriter_magaza = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter += "  and sMagaza IN ( " & sMagaza & " )"
        End If
        ds_tbSatisMagaza = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, sMagaza, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA   FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sMagaza ORDER BY " & count_sirala & " sMagaza"), "tbSatisMagaza")
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim Tutar As Decimal = 0
        Dim Kar As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim Yuzde As Decimal = 0
        Dim MusteriSayisi As Decimal = 0
        Dim FisSayisi As Int64 = 0
        Dim FisOrt As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">Satışların Mağazalara Dağılımı</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Mağaza</th>"
        s += "<th class=""cs67572338"">Miktar</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        s += "<th class=""cs67572338"">Kar</th>"
        s += "<th class=""cs67572338"">Yüzde</th>"
        s += "<th class=""cs67572338"">Müşteri</th>"
        s += "<th class=""cs67572338"">Fis</th>"
        s += "<th class=""cs67572338"">FisOrt</th>"
        ProgressBar2.Properties.Maximum = ds_tbSatisMagaza.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbSatisMagaza.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sMagaza") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("Miktar"), "#,0.###") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Tutar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Kar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">%" & Format(dr("Yuzde"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("MUSTERISAYISI"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("FISSAYISI"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("FISORTALAMA"), "#,0.00") & "</td>"
            s += "</tr>"
            kayit += 1
            Miktar += dr("Miktar")
            Tutar += dr("Tutar")
            Kar += dr("Kar")
            maliyet += dr("Maliyet")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        Try
            Yuzde = (Kar / maliyet) * 100
        Catch ex As Exception
            Yuzde = 0
        End Try
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & kayit & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(Miktar, "#,0.###") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Tutar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Kar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">%" & Format(Yuzde, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(MusteriSayisi, "#,0") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(FisSayisi, "#,0") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(FisOrt, "#,0") & "</td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_tahsilat(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1) As String
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        Dim kriter_magaza = ""
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbOdeme.sMagaza IN ( " & sMagaza & " )"
        End If
        ds_tbSatisTahsilat = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sMagaza, SUM(IadeTutar) AS IadeTutar, SUM(IadeMusteri) AS IadeMusteri, SUM(Pesinat) AS Pesinat, SUM(PesinatMusteri) AS PesinatMusteri, SUM(Tahsilat) AS Tahsilat, SUM(TahsilatMusteri) AS TahsilatMusteri, SUM(ToplamTutar) AS ToplamTutar, SUM(ToplamMusteri) AS ToplamMusteri FROM (SELECT tbOdeme.sMagaza , 0 AS IadeTutar , 0 AS IadeMusteri , 0 AS Pesinat , 0 AS PesinatMusteri , 0 AS Tahsilat , 0 AS TahsilatMusteri , SUM(tbOdeme.lOdemeTutar) AS ToplamTutar , COUNT(DISTINCT tbAlisVeris.nMusteriID) AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " and (tbOdeme.nOdemeKodu IN(1,2)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza , 0 AS IadeTutar , 0 AS IadeMusteri , SUM(tbOdeme.lOdemeTutar) AS Pesinat , COUNT(DISTINCT tbAlisVeris.nMusteriID) AS PesinatMusteri , 0 AS Tahsilat , 0 AS TahsilatMusteri , 0 AS ToplamTutar , 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "')  " & kriter_magaza & " AND tbOdeme.nOdemeKodu = 1 AND tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza , 0 AS IadeTutar , 0 AS IadeMusteri , 0 AS Pesinat , 0 AS PesinatMusteri , SUM(tbOdeme.lOdemeTutar) AS Tahsilat , COUNT(DISTINCT tbAlisVeris.nMusteriID) AS TahsilatMusteri , 0 AS ToplamTutar , 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND tbOdeme.nOdemeKodu = 2 GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza , SUM(ABS(tbOdeme.lOdemeTutar)) AS IadeTutar , COUNT(DISTINCT tbAlisVeris.nMusteriID) AS IadeMusteri , 0 AS Pesinat , 0 AS PesinatMusteri , 0 AS Tahsilat , 0 AS TahsilatMusteri , 0 AS ToplamTutar , 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "')  AND (tbAlisVeris.nGirisCikis = 4) " & kriter_magaza & " and tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza ) T GROUP BY sMagaza"), "tbSatisTahsilat")
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim Tutar As Decimal = 0
        Dim Kar As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim Yuzde As Decimal = 0
        Dim MusteriSayisi As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">Tahsilatların Mağazalara Dağılımı</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Mağaza</th>"
        s += "<th class=""cs67572338"">Peşinat</th>"
        s += "<th class=""cs67572338"">Sayı</th>"
        s += "<th class=""cs67572338"">Tahsilat</th>"
        s += "<th class=""cs67572338"">Sayı</th>"
        s += "<th class=""cs67572338"">ToplamTahsilat</th>"
        kayit = 0
        Dim Pesinat As Decimal = 0
        Dim PesinatMusteri As Decimal = 0
        Dim Tahsilat As Decimal = 0
        Dim TahsilatMusteri As Decimal = 0
        Dim ToplamTahsilat As Decimal = 0
        ProgressBar2.Properties.Maximum = ds_tbSatisTahsilat.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbSatisTahsilat.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sMagaza") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Pesinat"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("PesinatMusteri"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Tahsilat"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("TahsilatMusteri"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("ToplamTutar"), "#,0.00") & "</td>"
            s += "</tr>"
            kayit += 1
            Pesinat += dr("Pesinat")
            PesinatMusteri += dr("PesinatMusteri")
            Tahsilat += dr("Tahsilat")
            TahsilatMusteri += dr("TahsilatMusteri")
            ToplamTahsilat += +dr("ToplamTutar")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Pesinat, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(PesinatMusteri, "#,0") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Tahsilat, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(TahsilatMusteri, "#,0") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(ToplamTahsilat, "#,0.00") & "</td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_satis_sinif(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        Dim kriter_magaza = ""
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter += "  and sMagaza IN ( " & sMagaza & " )"
        End If
        ds_tbSatisSinif = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, sSinifKodu, sAciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0.01))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sSinifKodu, sAciklama ORDER BY " & count_sirala & " sSinifKodu, sAciklama"), "tbSatisSinif")
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim Tutar As Decimal = 0
        Dim Kar As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim Yuzde As Decimal = 0
        Dim MusteriSayisi As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & tarih1 & " ve " & tarih2 & " Tarihleri Arasındaki Satışların Sınıflara Dağılımı</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Sınıflandırma</th>"
        s += "<th class=""cs67572338"">Miktar</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        s += "<th class=""cs67572338"">Kar</th>"
        s += "<th class=""cs67572338"">Yüzde</th>"
        s += "<th class=""cs67572338"">Müşteri</th>"
        s += "<th class=""cs67572338"">Fis</th>"
        s += "<th class=""cs67572338"">FisOrt</th>"
        ProgressBar2.Properties.Maximum = ds_tbSatisSinif.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbSatisSinif.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:150px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sSinifKodu") & "\" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Miktar"), "#,0.###") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(sorgu_sayi(dr("Tutar"), 0), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(sorgu_sayi(dr("Kar"), 0), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">%" & Format(sorgu_sayi(dr("Yuzde"), 0), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("MUSTERISAYISI"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("FISSAYISI"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("FISORTALAMA"), "#,0.00") & "</td>"
            s += "</tr>"
            kayit += 1
            Miktar += dr("Miktar")
            Tutar += dr("Tutar")
            Kar += dr("Kar")
            maliyet += dr("Maliyet")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        Try
            Yuzde = (Kar / maliyet) * 100
        Catch ex As Exception
            Yuzde = 0
        End Try
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:150px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Miktar, "#,0") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Tutar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Kar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">%" & Format(Yuzde, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(MusteriSayisi, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(0, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(0, "#,0.00") & "</td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_satis_satici(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        Dim kriter_magaza = ""
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter += "  and sMagaza IN ( " & sMagaza & " )"
        End If
        'Grid_satis_personel.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisVeris LEFT OUTER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & "  GROUP BY sKat,sSaticiRumuzu, Satici ORDER BY sKat,sSaticiRumuzu, Satici")).Tables(0)
        'ds_tbSatisSatici = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Prim) Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat,PersonelOran,sSaticiRumuzu, Satici ORDER BY sKat,sSaticiRumuzu, Satici"), "tbSatisSatici")
        ds_tbSatisSatici = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto,SUM(Prim) AS Prim, SUM(lNetTutar) AS Tutar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI,SUM(lMaliyetTutar) as Maliyet,SUM(lKar) as lKar,nOran = CASE WHEN SUM(lMaliyetTutar) <> 0 AND SUM(lKar) <> 0 THEN (SUM(lKar) / SUM(lMaliyetTutar)) * 100 ELSE 100 END FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.lCikisMiktar1 * ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lMaliyetTutar, ISNULL(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari, 0) - (tbStokFisiDetayi.lCikisMiktar1 *ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0)) AS lKar,tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici,tbSaticiKatlari.sKat FROM tbAlisVeris LEFT OUTER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisVerisSiparis.lGCMiktar * ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.nStokID AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lMaliyetTutar, (tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) - (tbAlisVerisSiparis.lGCMiktar * ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0)) AS lKar,tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici,tbSaticiKatlari.sKat FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & "  GROUP BY sKat,sSaticiRumuzu, Satici ORDER BY SUM(lNetTutar),sSaticiRumuzu, Satici"), "tbSatisSatici")
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim Tutar As Decimal = 0
        Dim Prim As Decimal = 0
        Dim Kar As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim Yuzde As Decimal = 0
        Dim MusteriSayisi As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & tarih1 & " ve " & tarih2 & " Tarihleri Arasındaki Satışların Satıcılara Dağılımı</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Satıcı</th>"
        s += "<th class=""cs67572338"">Miktar</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        s += "<th class=""cs67572338"">Prim</th>"
        s += "<th class=""cs67572338"">Kar</th>"
        s += "<th class=""cs67572338"">Yüzde</th>"
        s += "<th class=""cs67572338"">Müşteri</th>"
        ProgressBar2.Properties.Maximum = ds_tbSatisSatici.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbSatisSatici.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sSaticiRumuzu") & "\" & dr("Satici") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Miktar"), "#,0.###") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Tutar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Prim"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lKar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">%" & Format(dr("nOran"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("MUSTERISAYISI"), "#,0") & "</td>"
            s += "</tr>"
            kayit += 1
            Miktar += dr("Miktar")
            Prim += dr("Prim")
            Tutar += dr("Tutar")
            Kar += dr("lKar")
            maliyet += dr("Maliyet")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        Try
            Yuzde = (Kar / maliyet) * 100
        Catch ex As Exception
            Yuzde = 0
        End Try
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Miktar, "#,0") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Tutar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Prim, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(Kar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">%" & Format(Yuzde, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(MusteriSayisi, "#,0.00") & "</td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_tbNakitKasa(ByVal sSubeMagaza As String, ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal sec_bTumu As Boolean) As String
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        Dim dkriter As String = ""
        kriter = "WHERE (tbNakitKasa.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & " ')"
        If Trim(sSubeMagaza) <> "" Then
            kriter += " AND (tbNakitKasa.sSube = '" & sSubeMagaza & "  ') "
            dkriter += " AND (sSube = '" & sSubeMagaza & "  ') "
        Else
            If sec_bTumu = True Then
            Else
                kriter += " AND (tbNakitKasa.sSube = '" & sSubeMagaza & "  ') "
                dkriter += " AND (sSube = '" & sSubeMagaza & "  ') "
            End If
        End If
        Dim ds_tbNakitKasa As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbNakitKasa.nKasaIslemID, tbNakitKasa.sSube, tbNakitKasa.dteIslemTarihi, tbNakitKasa.lTahsilTutar, tbNakitKasa.lTediyeTutar, (SELECT ISNULL(SUM(lTahsilTutar - lTediyeTutar) , 0) AS lBakiye FROM tbNakitKasa tbDevir WHERE nKasaIslemID <= tbNakitKasa.nKasaIslemID " & dkriter & ") AS lKalan ,tbNakitKasa.sAciklama, tbNakitKasa.nCariHareketID, tbNakitKasa.sHangiUygulama, tbNakitKasa.sHareketTipi, tbNakitKasa.bMuhasebeyeIslendimi, tbNakitKasa.nFirmaID, tbNakitKasa.nHesapID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbNakitKasa.sMasrafYontemi, tbNakitKasa.sDovizCinsi1, tbNakitKasa.lDovizMiktari1, tbNakitKasa.lDovizKuru1, tbNakitKasa.sDovizCinsi2, tbNakitKasa.lDovizMiktari2, tbNakitKasa.lDovizKuru2, tbNakitKasa.dteKayitTarihi, tbNakitKasa.sKullaniciAdi, tbFirmaHareketi.sEvrakNo FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHesapPlani ON tbNakitKasa.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN tbFirmaHareketi ON tbNakitKasa.nCariHareketID = tbFirmaHareketi.nHareketID " & kriter & " ORDER BY tbNakitKasa.sSube, tbNakitKasa.nKasaIslemID "), "tbSatisTahsilat")
        Dim dr As DataRow
        Dim lKalan As Decimal = 0
        lKalan = sorgu_lKalanBakiye(dteIslemTarihi1, sSubeMagaza, sec_bTumu)
        For Each dr In ds_tbNakitKasa.Tables(0).Rows
            lKalan = lKalan + (dr("lTahsilTutar") - dr("lTediyeTutar"))
            dr("lKalan") = lKalan
        Next
        Dim kayit As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim Tutar As Decimal = 0
        Dim Kar As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim Yuzde As Decimal = 0
        Dim MusteriSayisi As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & dteIslemTarihi1 & " ve " & dteIslemTarihi2 & " Tarihleri Arasındaki Nakit Kasası</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">FirmaKodu</th>"
        s += "<th class=""cs67572338"">FirmaAdı</th>"
        s += "<th class=""cs67572338"">Açıklama</th>"
        s += "<th class=""cs67572338"">EvrakNo</th>"
        s += "<th class=""cs67572338"">Gelir</th>"
        s += "<th class=""cs67572338"">Gider</th>"
        s += "<th class=""cs67572338"">Kalan</th>"
        s += "<th class=""cs67572338"">Döviz</th>"
        s += "<th class=""cs67572338"">Kur</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        kayit = 0
        Dim lGelir As Decimal = 0
        Dim lGider As Decimal = 0
        lKalan = 0
        ProgressBar2.Properties.Maximum = ds_tbNakitKasa.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbNakitKasa.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sFirmaKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sFirmaAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sEvrakNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lTahsilTutar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lTediyeTutar"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lKalan"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sDovizCinsi1") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lDovizKuru1") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lDovizMiktari1") & "</td>"
            s += "</tr>"
            kayit += 1
            lGelir += dr("lTahsilTutar")
            lGider += dr("lTediyeTutar")
            lKalan = dr("lKalan")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGelir, "#,0") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGider, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lKalan, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Public Function sorgu_lKalanBakiye(ByVal dteIslemTarihi1 As DateTime, ByVal sSubeMagaza As String, ByVal sec_bTumu As Boolean) As Decimal
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        kriter = "Where dteIslemTarihi < '" & dteIslemTarihi1 & "' "
        If Trim(sSubeMagaza) <> "" Then
            kriter += " AND (sSube = '" & sSubeMagaza & "  ') "
        Else
            If sec_bTumu = True Then
            Else
                kriter += " AND (sSube = '" & sSubeMagaza & "  ') "
            End If
        End If
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lTahsilTutar - lTediyeTutar),0) AS lBakiye FROM         tbNakitKasa " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function dataload_tbYekun(ByVal sSubeMagaza As String, ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal sec_bTumu As Boolean) As String
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        Dim kriter_devir As String = ""
        Dim kriter_bugun As String = ""
        Dim kriter_genel As String = ""
        kriter_devir = "WHERE (dteIslemTarihi < '" & dteIslemTarihi2 & "') "
        kriter_bugun = "WHERE (dteIslemTarihi = '" & dteIslemTarihi2 & "') "
        kriter_genel = "WHERE (dteIslemTarihi <= '" & dteIslemTarihi2 & "') "
        If Trim(sSubeMagaza) <> "" Then
            kriter_devir += " AND (sSube = '" & sSubeMagaza & " ') "
            kriter_bugun += " AND (sSube = '" & sSubeMagaza & " ') "
            kriter_genel += " AND (sSube = '" & sSubeMagaza & " ') "
        Else
            If sec_bTumu = True Then
            Else
                kriter_devir += " AND (sSube = '" & sSubeMagaza & " ') "
                kriter_bugun += " AND (sSube = '" & sSubeMagaza & " ') "
                kriter_genel += " AND (sSube = '" & sSubeMagaza & " ') "
            End If
        End If
        Dim ds_tbYekun As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT N'" & Sorgu_sDil("Devreden", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa " & kriter_devir & " UNION ALL SELECT N'" & Sorgu_sDil("Bugün", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa " & kriter_bugun & " UNION ALL SELECT N'" & Sorgu_sDil("Genel", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa " & kriter_genel & " "), "tbYekun")
        Dim dr As DataRow

        Dim kayit As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim Tutar As Decimal = 0
        Dim Kar As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim Yuzde As Decimal = 0
        Dim MusteriSayisi As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">Kasa Bakiyesi</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Açıklama</th>"
        's += "<th class=""cs67572338"">DövizCinsi</th>"
        s += "<th class=""cs67572338"">Gelir</th>"
        s += "<th class=""cs67572338"">Gider</th>"
        s += "<th class=""cs67572338"">Kalan</th>"

        kayit = 0
        Dim lGelir As Decimal = 0
        Dim lGider As Decimal = 0
        Dim lBakiye As Decimal = 0
        For Each dr In ds_tbYekun.Tables(0).Rows
            'Hareketler
            s += "</tr>"

            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            's += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sEvrakNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lTahsilTutar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lTediyeTutar"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lBakiye"), "#,0.00") & "</td>"

            s += "</tr>"
            kayit += 1
            lGelir += dr("lTahsilTutar")
            lGider += dr("lTediyeTutar")
            lBakiye = dr("lBakiye")
        Next
        'Toplam
        's += "</tr>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        ''s += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGelir, "#,0") & "</td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGider, "#,0.00") & "</td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"

        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function boslukToInt(ByVal intInteger As Object) As String
        If IsDBNull(intInteger) Then
            Return "0"
        Else
            Return intInteger
        End If
    End Function
    Private Function dataload_tbNakitKasaToplamlari(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As String
        Dim ds_tbYekun As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT '100' AS sHesap, '100' AS sKodu, N'Kasa Toplamları' sAciklamaTR, N'Kasa Toplamları' sAciklama, SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lBakiye, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lTutar, 1 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' UNION ALL SELECT '100-' + tbNakitKasa.sSube AS sHesap, '100-' + tbNakitKasa.sSube AS sKodu, tbSubeMagaza.sAciklama sAciklamaTR, N'Kasa Toplamları' sAciklama, SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lBakiye, 0 AS lTutar, 2 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbNakitKasa.sSube, tbSubeMagaza.sAciklama ORDER BY sKodu, sAciklama"), "tbYekun")
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim Tutar As Decimal = 0
        Dim Kar As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim Yuzde As Decimal = 0
        Dim MusteriSayisi As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">Kasa Sube Toplamlari</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Kasa</th>"
        s += "<th class=""cs67572338"">Aciklama</th>"
        s += "<th class=""cs67572338"">Gelir</th>"
        s += "<th class=""cs67572338"">Gider</th>"
        s += "<th class=""cs67572338"">Kalan</th>"
        kayit = 0
        Dim lGelir As Decimal = 0
        Dim lGider As Decimal = 0
        Dim lBakiye As Decimal = 0
        For Each dr In ds_tbYekun.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(boslukToInt(dr("lBorcTutar")), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(boslukToInt(dr("lAlacakTutar")), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(boslukToInt(dr("lBakiye")), "#,0.00") & "</td>"
            s += "</tr>"
            kayit += 1
            lGelir += boslukToInt(dr("lBorcTutar"))
            lGider += boslukToInt(dr("lAlacakTutar"))
            lBakiye = boslukToInt(dr("lBakiye"))
        Next
        'Toplam
        's += "</tr>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        ''s += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGelir, "#,0") & "</td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGider, "#,0.00") & "</td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Public Function dataload_tbFirmaHareketleri(ByVal musterino As String, ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal bDovizli As Boolean, ByVal bIrsaliye As Integer, ByVal sDovizCinsi As String, ByVal bAltHesapli As Boolean, ByVal bMuhasebe As Boolean) As String
        Dim kriter
        Dim ds_tbFirmaHareketleri As New DataSet
        kriter = ""
        If sDovizCinsi <> "" Then
            kriter += " AND (tbFirmaHareketi.sDovizCinsi1 ='" & sDovizCinsi & "') "
        End If
        If bMuhasebe = False Then
            If bDovizli = False Then
                If bAltHesapli = True Then
                    ds_tbFirmaHareketleri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS lBakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,tbStokFisiAciklamasi.sAciklama1,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID RIGHT OUTER JOIN tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '" & dteIslemTarihi1 & "' AND tbFirma.sKodu = '" & Trim(musterino) & "' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID ON tbStokFisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE (tbFirma.sKodu LIKE '" & Trim(musterino) & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') ORDER BY tbFirma.sKodu,tbFirmaHareketi.dteIslemTarihi "))
                Else
                    ds_tbFirmaHareketleri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, tbFirmaHareketi.lBorcTutar, tbFirmaHareketi.lAlacakTutar, tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar AS lBakiye, tbFirmaHareketi.sCariIslem AS IslemAciklama,(SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) sIslem, Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,tbStokFisiAciklamasi.sAciklama1,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID RIGHT OUTER JOIN tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT SUM(tbFirmaHareketi.lBorcTutar) - SUM(tbFirmaHareketi.lAlacakTutar) AS lDevir , tbFirmaHareketi.nFirmaID FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaId = tbFirmaHareketi.nFirmaId AND dteIslemTarihi < '" & dteIslemTarihi1 & "' AND tbFirma.sKodu = '" & Trim(musterino) & "' GROUP BY tbFirmaHareketi.nFirmaID) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID ON tbStokFisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE (tbFirma.sKodu = '" & Trim(musterino) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') ORDER BY tbFirmaHareketi.dteIslemTarihi "))
                End If
            ElseIf bDovizli = True Then
                If bAltHesapli = True Then
                    ds_tbFirmaHareketleri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sCariIslem AS IslemAciklama, (SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) as sIslem,Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT sDovizCinsi1, nFirmaID, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lDevir FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi < '" & dteIslemTarihi1 & "') AND (tbFirma.sKodu = '" & Trim(musterino) & "')) TemDevir GROUP BY nFirmaID, sDovizCinsi1) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID AND tbFirmaHareketi.sDovizCinsi1 = TempDevir.sDovizCinsi1 LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu LIKE '" & Trim(musterino) & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') " & kriter & " ORDER BY tbFirmaHareketi.sDovizCinsi1,tbFirma.sKodu,tbFirmaHareketi.dteIslemTarihi "))
                Else
                    ds_tbFirmaHareketleri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID,tbFirmaHareketi.nHareketID,tbFirma.sKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END, tbFirmaHareketi.sCariIslem AS IslemAciklama, (SELECT     sAciklama FROM         tbCariIslem where sCariIslem = tbFirmaHareketi.sCariIslem) as sIslem,Isnull(tbStokFisiMaster.nGirisCikis,0) as nGirisCikis,tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.dteKayitTarihi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, tbFirmaHareketi.sKullaniciAdi, ISNULL(TempDevir.lDevir, 0) AS lDevir,(SELECT ISNULL(nCekSenetID,0) FROM tbCekSenet WHERE CAST(lCekSenetNo AS CHAR(10)) = CAST(tbFirmaHareketi.sEvrakNo AS CHAR(10)) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT sDovizCinsi1, nFirmaID, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lDevir FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi < '" & dteIslemTarihi1 & "') AND (tbFirma.sKodu ='" & Trim(musterino) & "')) TemDevir GROUP BY nFirmaID, sDovizCinsi1) TempDevir ON tbFirmaHareketi.nFirmaID = TempDevir.nFirmaID AND tbFirmaHareketi.sDovizCinsi1 = TempDevir.sDovizCinsi1 LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID WHERE (tbFirma.sKodu = '" & Trim(musterino) & "') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') " & kriter & " ORDER BY tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.dteIslemTarihi "))
                End If
            End If
        ElseIf bMuhasebe = True Then
            If bDovizli = False Then
                ds_tbFirmaHareketleri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,CAST(0 AS MONEY) as lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu LIKE '" & Trim(musterino) & "%') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID "))
            ElseIf bDovizli = True Then
                ds_tbFirmaHareketleri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbMuhasebeFisi.nFisSiraID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sFirmaAciklama, tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.dteFisTarihi AS dteIslemTarihi,tbMuhasebeFisi.dteFisTarihi AS dteValorTarihi,tbMuhasebeFisi.lFisNo, tbMuhasebeFisi.lBorcTutar, tbMuhasebeFisi.lAlacakTutar, tbMuhasebeFisi.sMuhFisTipi AS IslemAciklama,sIslem = Case When tbMuhasebeFisi.sMuhFisTipi = 0 then 'Açılış Fişi' When tbMuhasebeFisi.sMuhFisTipi = 1 then 'Tahsilat Fişi' When tbMuhasebeFisi.sMuhFisTipi =2 then 'Tediye Fişi' When tbMuhasebeFisi.sMuhFisTipi =3 then 'Mahsup Fişi' END,tbMuhasebeFisi.sMuhFisTipi as nGirisCikis,0 as nStokFisiID,CAST(0 AS MONEY) as lDevir,0 as nCekSenetID,tbMuhasebeFisi.lGirenMiktar, tbMuhasebeFisi.lCikanMiktar, tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar AS lBakiye, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.lYevmiyeNo, tbMuhasebeFisi.sAciklama, tbMuhasebeFisi.sMasrafYontemi, tbMuhasebeFisi.nKasaID, tbMuhasebeFisi.sHangiUygulama, tbMuhasebeFisi.sHareketTipi, tbMuhasebeFisi.nCariHareketID, tbMuhasebeFisi.sKullaniciAdi, tbMuhasebeFisi.dteKayitTarihi, tbMuhasebeFisi.sDovizCinsi1, tbMuhasebeFisi.lDovizMiktari1, tbMuhasebeFisi.lDovizKuru1, tbMuhasebeFisi.sDovizCinsi2, tbMuhasebeFisi.lDovizMiktari2, tbMuhasebeFisi.lDovizKuru2, tbMuhasebeFisi.nSatir, tbMuhasebeFisi.sSubeMagaza, tbMuhasebeFisi.sSonKullaniciAdi, tbMuhasebeFisi.dteSonUpdateTarihi FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "') AND (tbHesapPlani.sKodu LIKE '" & Trim(musterino) & "%') ORDER BY tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nFisSiraID "))
            End If
        End If
        Dim dr As DataRow
        Dim bakiye = 0
        Dim bakiye_status = "-"
        Dim sayi As Integer = 0
        Dim lDevir As Decimal = 0
        lDevir = 0
        Dim sDovizCinsi1 As String = ""
        For Each dr In ds_tbFirmaHareketleri.Tables(0).Rows
            sayi += 1
            If sayi = 1 Then
                bakiye = bakiye + dr("lDevir")
                lDevir = dr("lDevir")
            End If
            If bDovizli = True Then
                If Trim(dr("sDovizCinsi1")) <> sDovizCinsi1 Then
                    bakiye = 0
                    bakiye = bakiye + dr("lDevir")
                    sDovizCinsi1 = Trim(dr("sDovizCinsi1"))
                End If
            End If
            bakiye = bakiye + (dr("lBorcTutar") - dr("lAlacakTutar"))
            dr("lBakiye") = bakiye
            If bakiye < 0 Then
                bakiye_status = "A"
            ElseIf bakiye = 0 Then
                bakiye_status = "-"
            ElseIf bakiye > 0 Then
                bakiye_status = "B"
            End If
            If dr("nGirisCikis") = 1 Then
            ElseIf dr("nGirisCikis") = 2 Then
                If Trim(dr("sHangiUygulama").ToString) = "FA" Then
                    dr("sIslem") = "Alıştan İade"
                ElseIf Trim(dr("sHangiUygulama").ToString) = "DG" Then
                    dr("sIslem") = "StokİadeEdilen"
                End If
            ElseIf dr("nGirisCikis") = 3 Then
            ElseIf dr("nGirisCikis") = 4 Then
                If Trim(dr("sHangiUygulama").ToString) = "FS" Then
                    dr("sIslem") = "Satıştan İade"
                ElseIf Trim(dr("sHangiUygulama").ToString) = "DC" Then
                    dr("sIslem") = "StokİadeAlınan"
                End If
            End If
            dr("sIslem") = Sorgu_sDil(dr("sIslem").ToString, sDil)
            dr("sAciklama") = Replace(dr("sAciklama").ToString, "Evrak No:", Sorgu_sDil("Evrak No:", sDil))
            dr("sAciklama") = Replace(dr("sAciklama").ToString, "ISKONTO YAPILDI", Sorgu_sDil("ISKONTO YAPILDI", sDil))
            dr("sAciklama") = Replace(dr("sAciklama").ToString, "Pesin Fatura No :", Sorgu_sDil("Pesin Fatura No ::", sDil))
        Next
        Dim kayit As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & dteIslemTarihi1 & " ve " & dteIslemTarihi2 & " Tarihleri Arasındaki Banka Hareketleri</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">HesapKodu</th>"
        s += "<th class=""cs67572338"">HesapAdı</th>"
        s += "<th class=""cs67572338"">İşlem</th>"
        s += "<th class=""cs67572338"">İşlemTarihi</th>"
        s += "<th class=""cs67572338"">ValörTarihi</th>"
        s += "<th class=""cs67572338"">FişNo</th>"
        s += "<th class=""cs67572338"">Açıklama</th>"
        s += "<th class=""cs67572338"">Borç</th>"
        s += "<th class=""cs67572338"">Alacak</th>"
        s += "<th class=""cs67572338"">Bakiye</th>"
        s += "<th class=""cs67572338"">Döviz</th>"
        s += "<th class=""cs67572338"">Kur</th>"
        s += "<th class=""cs67572338"">DövizTutarı</th>"
        kayit = 0
        ProgressBar2.Properties.Maximum = ds_tbFirmaHareketleri.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbFirmaHareketleri.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sFirmaAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sIslem") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("dteIslemTarihi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & dr("dteValorTarihi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;"">" & dr("lFisNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lBorcTutar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lAlacakTutar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lBakiye"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sDovizCinsi1") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lDovizKuru1"), "#,0.0000") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lDovizMiktari1"), "#,0.0000") & "</td>"
            s += "</tr>"
            kayit += 1
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
        Return s
    End Function
    Private Function dataload_tbBankaBakiye() As String
        Dim ds_tbBankaBakiye As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sOzelNot,tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM(ISNULL((lBorcTutar - lAlacakTutar),0.01)) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, tbFirma.sDovizCinsi, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],tbFirma.bSatisYapilamaz,tbFirma.bTahsilatYapilamaz,bAnaHesap = CASE WHEN RIGHT(tbFirma.sAciklama, 1) = '+' THEN 1 ELSE 0 END FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID Where tbFirma.sKodu like '102%' and tbFirma.bAktif =1 ORDER BY tbFirma.sKodu"), "tbBankaBakiye")
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">Banka Bakiyeleri</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">HesapKodu</th>"
        s += "<th class=""cs67572338"">HesapAdı</th>"
        s += "<th class=""cs67572338"">HesapTipi</th>"
        s += "<th class=""cs67572338"">HesapNo</th>"
        s += "<th class=""cs67572338"">KrediLimiti</th>"
        s += "<th class=""cs67572338"">Bakiye</th>"
        s += "<th class=""cs67572338"">Döviz</th>"
        kayit = 0
        Dim lKrediLimiti As Decimal = 0
        Dim lBakiye As Decimal = 0
        For Each dr In ds_tbBankaBakiye.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:150px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sVergiDairesi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sVergiNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lKrediLimiti"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lBakiye"), "#,0") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sDovizCinsi") & "</td>"
            s += "</tr>"
            kayit += 1
            lKrediLimiti += dr("lKrediLimiti")
            lBakiye += dr("lBakiye")
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:150px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_tbMarketKasaTeslimat(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As String
        Dim kriter As String = ""
        Dim ds_tbMarketKasaTeslimat As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbMarketKasaTeslimat Where dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "'  " & kriter & " Order by dteFisTarihi,sDepo,nKasaNo,sKasiyerRumuzu"), "tbBankaBakiye")
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white""> " & tarih1 & " ve " & tarih2 & " Tarihleri Arasındaki Kasa Teslimatları</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Tarih</th>"
        s += "<th class=""cs67572338"">Mağaza</th>"
        s += "<th class=""cs67572338"">Kasa</th>"
        s += "<th class=""cs67572338"">Kasiyer</th>"
        s += "<th class=""cs67572338"">Acilis</th>"
        s += "<th class=""cs67572338"">Kapanis</th>"
        s += "<th class=""cs67572338"">Gonderilecek</th>"
        s += "<th class=""cs67572338"">Kagit</th>"
        s += "<th class=""cs67572338"">Bozuk</th>"
        s += "<th class=""cs67572338"">Nakit</th>"
        s += "<th class=""cs67572338"">Poslar</th>"
        s += "<th class=""cs67572338"">Ödemeler</th>"
        s += "<th class=""cs67572338"">Z</th>"
        s += "<th class=""cs67572338"">Fark</th>"
        s += "<th class=""cs67572338"">Iptal</th>"
        s += "<th class=""cs67572338"">IptalTutari</th>"
        kayit = 0
        Dim lKagitPara As Decimal = 0
        Dim lBozukPara As Decimal = 0
        Dim lNakitPara As Decimal = 0
        Dim lKasa As Decimal = 0
        Dim lOdemeler As Decimal = 0
        Dim lPoslar As Decimal = 0
        Dim lGenelKasa As Decimal = 0
        Dim lZToplam As Decimal = 0
        Dim lAcilis As Decimal = 0
        Dim lKapanis As Decimal = 0
        Dim lFark As Decimal = 0
        Dim nIptalSayisi As Decimal = 0
        Dim lIptalTutari As Decimal = 0
        Dim lGonderilecek As Decimal = 0
        For Each dr In ds_tbMarketKasaTeslimat.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("dteFisTarihi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:150px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sDepo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("nKasaNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKasiyerRumuzu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lAcilis"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lKapanis"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lGonderilecek"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lKagit"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lBozuk"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lNakit"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lKredi"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lOdeme"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lZ"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lFark"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("nIptalSayisi"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lIptalTutari"), "#,0.00") & "</td>"

            s += "</tr>"
            kayit += 1
            lAcilis += dr("lAcilis")
            lKapanis += dr("lKapanis")
            lGonderilecek += dr("lGonderilecek")
            lKagitPara += dr("lKagit")
            lBozukPara += dr("lBozuk")
            lNakitPara += dr("lNakit")
            lPoslar += dr("lKredi")
            lOdemeler += dr("lOdeme")
            lZToplam += dr("lZ")
            lFark += dr("lFark")
            nIptalSayisi += dr("nIptalSayisi")
            lIptalTutari += dr("lIptalTutari")
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:150px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lAcilis, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lKapanis, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGonderilecek, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lKagitPara, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lBozukPara, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lNakitPara, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lPoslar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lOdemeler, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lZToplam, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lFark, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(nIptalSayisi, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lIptalTutari, "#,0.00") & "</td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Sub dataload_satislar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal saat1 As DateTime, ByVal saat2 As DateTime)
        Dim kriter As String = ""
        kriter = " AND a.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        If saat1 = "00:00:00" Then
        Else
            kriter = " AND a.dteKayitTarihi BETWEEN '" & tarih1 & " " & saat1 & "' AND '" & tarih2 & " " & saat2 & "'"
        End If
        'MsgBox(saat1 & vbTab & saat2)
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND a.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND a.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND a.sMagaza IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter += " AND a.sHareketTipi IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter += " AND a.sFisTipi IN ( " & fistipi & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama, Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama , '' AS Bos1 , '' AS Bos2 , '' AS Bos3 , a.nGirisCikis AS nGirisCikis , Malbedeli = CASE WHEN a.sFisTipi = 'CP' THEN SUM(lNetTutar) ELSE SUM(a.lMalBedeli) END , SUM(a.lMalIskontoTutari + a.lDipIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , SUM(a.lVadeKdvMatrahi) AS VadeKdvMatrahi , SUM(a.lVadeFarki) AS VadeFarki , SUM(a.lKdv1 + a.lKdv2 + a.lKdv3 + a.lKdv4 + a.lKdv5 + a.lVadeKdv) AS KdvTutari , SUM(a.lToplamMiktar) AS Miktar , SUM(a.lKdvMatrahi1 + a.lKdvMatrahi2 + a.lKdvMatrahi3 + a.lKdvMatrahi4 + a.lKdvMatrahi5 + a.lVadeKdvMatrahi) AS KDVMatrahi , SUM(a.lNetTutar + a.lVadeFarki) AS NetTutar FROM tbAlisVeris a , tbFisTipi b , tbKasiyer , tbParekendeKasa c WHERE a.sFisTipi = b.sFisTipi AND a.sFisTipi <> 'KA' AND a.sFisTipi <> 'PAD' AND a.nKasaNo = c.nKasaNo AND a.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu  " & kriter & " GROUP BY b.sAciklama , a.nGirisCikis , a.sFisTipi UNION ALL SELECT b.sAciklama + ' Toplamı' AS Aciklama , 'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lMalBedeli) AS MalBedeli , SUM(a.lMalIskontoTutari + a.lDipIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , SUM(a.lVadeKdvMatrahi) AS VadeKdvMatrahi , SUM(a.lVadeFarki) AS VadeFarki , SUM(a.lKdv1 + a.lKdv2 + a.lKdv3 + a.lKdv4 + a.lKdv5 + a.lVadeKdv) AS KdvTutari , SUM(a.lToplamMiktar) AS Miktar , SUM(a.lKdvMatrahi1 + a.lKdvMatrahi2 + a.lKdvMatrahi3 + a.lKdvMatrahi4 + a.lKdvMatrahi5 + a.lVadeKdvMatrahi) AS KDVMatrahi , SUM(a.lNetTutar + a.lVadeFarki) AS NetTutar FROM tbAlisVeris a , tbFisTipi b , tbKasiyer , tbParekendeKasa c WHERE a.sFisTipi = b.sFisTipi AND (a.sFisTipi = 'K' OR a.sFisTipi = 'P') AND a.nKasaNo = c.nKasaNo AND a.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, Bos1"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Sınıf") = "Başlık"
        dr("Aciklama") = "AlışVeriş Şekli"
        dr("MIKTAR") = "Adet"
        dr("IZAHAT") = "BelgeTipi"
        dr("col1") = "Brüt Satış"
        dr("col2") = "Iskonto"
        dr("col3") = "VadeFarkı"
        dr("col4") = "KdvMatrahı"
        dr("col5") = "KdvTutarı"
        dr("col6") = "NetTutar"
        'dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        Dim miktar As Decimal = 0
        Dim col1 As Decimal = 0
        Dim col2 As Decimal = 0
        Dim col3 As Decimal = 0
        Dim col4 As Decimal = 0
        Dim col5 As Decimal = 0
        Dim col6 As Decimal = 0
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sınıf") = "Satışlar"
            dr("Aciklama") = dr1("Aciklama")
            dr("MIKTAR") = FormatNumber(dr1("Miktar"), 2)
            If dr1("nGirisCikis") = 3 Then
                dr("IZAHAT") = "Normal"
            ElseIf dr1("nGirisCikis") = 4 Then
                dr("IZAHAT") = "Iade"
            ElseIf dr1("nGirisCikis") = 0 Then
                dr("IZAHAT") = "Toplam"
            End If
            'dr("IZAHAT") = dr1("nGirisCikis")
            dr("col1") = FormatNumber(dr1("Malbedeli"), 2)
            dr("col2") = FormatNumber(dr1("IskontoTutari"), 2)
            dr("col3") = FormatNumber(dr1("VadeFarki"), 2)
            dr("col4") = FormatNumber(dr1("KDVMatrahi"), 2)
            dr("col5") = FormatNumber(dr1("KdvTutari"), 2)
            dr("col6") = FormatNumber(dr1("NetTutar"), 2)
            dr("Status") = 1
            DataSet1.Tables(0).Rows.Add(dr)
            If dr1("nGirisCikis") <> 0 Then
                miktar += dr("MIKTAR")
                col1 += CType(dr("col1"), Decimal)
                col2 += CType(dr("col2"), Decimal)
                col3 += CType(dr("col3"), Decimal)
                col4 += CType(dr("col4"), Decimal)
                col5 += CType(dr("col5"), Decimal)
                col6 += CType(dr("col6"), Decimal)
            End If
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Sınıf") = "Satışlar"
        dr("Aciklama") = "GenelToplam"
        dr("MIKTAR") = FormatNumber(miktar, 2)
        dr("IZAHAT") = ""
        dr("col1") = FormatNumber(col1, 2)
        dr("col2") = FormatNumber(col2, 2)
        dr("col3") = FormatNumber(col3, 2)
        dr("col4") = FormatNumber(col4, 2)
        dr("col5") = FormatNumber(col5, 2)
        dr("col6") = FormatNumber(col6, 2)
        'dr("col7") = FormatNumber(col7, 0)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_yenikayitsayisi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS Sayi FROM         tbMusteri a WHERE     (CAST(CONVERT(char(10), dteKayitTarihi, 103) AS smalldatetime) BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sınıf") = "Ödemeler"
            dr("Aciklama") = "YeniAçılanMüşteri"
            dr("MIKTAR") = dr1("Sayi")
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        Next
        nakit = nakit - (masraf)
        dr = DataSet1.Tables(0).NewRow
        'dr("Sınıf") = "Nakit"
        'dr("Aciklama") = "NakitleriToplamı"
        'dr("MIKTAR") = 0
        'dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        dr("col5") = "NakitKasa"
        dr("col6") = FormatNumber(nakit, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_Odemeler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal saat1 As DateTime, ByVal saat2 As DateTime)
        Dim kriter As String = ""
        kriter = " AND (b.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If saat1 = "00:00:00" Then
        Else
            kriter = " AND a.dteKayitTarihi BETWEEN '" & tarih1 & " " & saat1 & "' AND '" & tarih2 & " " & saat2 & "'"
        End If
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND b.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT OdemeSekli, sAciklama1, nOdemeTipi, SUM(Odeme) AS Odeme, COUNT(lMakbuzNo) as nKayit,sFisTipi, nOdemeKodu, nGirisCikis FROM (SELECT CASE WHEN a.sFisTipi = 'KS' THEN 'Sli' ELSE substring(c.sAciklama , 1 , 3) END AS sAciklama , d.sAciklama AS sAciklama1 , SUM(b.lOdemeTutar) AS Odeme , b.lMakbuzNo,b.sKasiyerRumuzu , tbKasiyer.sAdi , tbKasiyer.sSoyadi , CASE WHEN a.sFisTipi = 'KS' THEN 'S ' + d.sOdemeSekli ELSE d.sOdemeSekli END AS OdemeSekli , k.nOdemeTipi , b.lOdemeNo , a.sFisTipi , b.sDovizCinsi , k.sAciklama AS Expr2 , b.nOdemeKodu , a.nGirisCikis FROM tbOdemeKodu c INNER JOIN tbOdeme b ON c.nOdemeKodu = b.nOdemeKodu INNER JOIN tbOdemeSekli d ON b.sOdemeSekli = d.sOdemeSekli INNER JOIN tbAlisVeris a ON b.nAlisverisID = a.nAlisverisID INNER JOIN tbKasiyer ON b.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu INNER JOIN tbOdemeTipi k ON d.nOdemeTipi = k.nOdemeTipi INNER JOIN tbFisTipi f ON a.sFisTipi = f.sFisTipi WHERE (a.sFisTipi <> 'KA') " & kriter & " GROUP BY c.sAciklama , b.sKasiyerRumuzu , d.sAciklama , tbKasiyer.sAdi , tbKasiyer.sSoyadi , d.sOdemeSekli , k.nOdemeTipi , b.lOdemeNo , b.lMakbuzNo,a.sFisTipi , b.sDovizCinsi , k.sAciklama , b.nOdemeKodu , a.nGirisCikis) TT GROUP BY OdemeSekli, sAciklama1, nOdemeTipi, sFisTipi, nOdemeKodu, nGirisCikis ORDER BY OdemeSekli, nGirisCikis, nOdemeKodu"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Status") = 1
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sınıf") = "Başlık"
        dr("Aciklama") = "ÖdemeŞekli"
        dr("MIKTAR") = "Kayıt"
        dr("IZAHAT") = "Kod"
        dr("col1") = "KR.Peşinatı"
        dr("col2") = "PeşinSatış"
        dr("col3") = "KK.Ödeme"
        dr("col4") = "KR.Iadesi"
        dr("col5") = "PeşinatIadesı"
        dr("col6") = "Toplam"
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        Dim miktar As Decimal = 0
        Dim col1 As Decimal = 0
        Dim col2 As Decimal = 0
        Dim col3 As Decimal = 0
        Dim col4 As Decimal = 0
        Dim col5 As Decimal = 0
        Dim col6 As Decimal = 0
        Dim Odeme As String = ""
        Dim odemeaciklama As String = ""
        'Dim nakit As Decimal = 0
        Dim kredi As Decimal = 0
        Dim kredipesinat As Decimal = 0
        Dim pesinsatis As Decimal = 0
        Dim krediodeme As Decimal = 0
        Dim krediiade As Decimal = 0
        Dim pesinatiade As Decimal = 0
        Dim sayi As Integer = 0
        Dim toplam As Integer = 0
        toplam = ds1.Tables(0).Rows.Count
        Dim top_kredipesinat As Decimal = 0
        Dim top_pesinpesinat As Decimal = 0
        Dim top_krediodeme As Decimal = 0
        Dim top_krediiade As Decimal = 0
        Dim top_pesinatiade As Decimal = 0
        Dim top_toplam As Decimal = 0
        nakit = 0
        kredi = 0
        masraf = 0
        For Each dr1 In ds1.Tables(0).Rows
            sayi += 1
            If sayi > 1 Then
                If Trim(dr1("OdemeSekli")) <> Odeme Then
                    dr = DataSet1.Tables(0).NewRow
                    dr("Sınıf") = "Ödemeler"
                    dr("Aciklama") = odemeaciklama
                    dr("MIKTAR") = dr1("nKayit")
                    dr("IZAHAT") = Odeme
                    dr("col1") = FormatNumber(kredipesinat, 2)
                    dr("col2") = FormatNumber(pesinsatis, 2)
                    dr("col3") = FormatNumber(krediodeme, 2)
                    dr("col4") = FormatNumber(krediiade, 2)
                    dr("col5") = FormatNumber(pesinatiade, 2)
                    dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                    If dr("IZAHAT") = "N" Then
                        nakit = CType(dr("col6"), Decimal)
                    End If
                    dr("Status") = 1
                    top_kredipesinat += CType(dr("col1"), Decimal)
                    top_pesinpesinat += CType(dr("col2"), Decimal)
                    top_krediodeme += CType(dr("col3"), Decimal)
                    top_krediiade += CType(dr("col4"), Decimal)
                    top_pesinatiade += CType(dr("col5"), Decimal)
                    top_toplam += CType(dr("col6"), Decimal)
                    DataSet1.Tables(0).Rows.Add(dr)
                    kredipesinat = 0
                    pesinsatis = 0
                    krediodeme = 0
                    krediiade = 0
                    pesinatiade = 0
                    Odeme = Trim(dr1("OdemeSekli"))
                    miktar = 0
                    odemeaciklama = dr1("sAciklama1")
                End If
            Else
                miktar = 0
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
            'Nakitleri Toplam
            If dr1("nOdemeTipi") = 1 Then
                If Trim(dr1("OdemeSekli")) = "N" Then
                    'nakit += dr1("Odeme")
                End If
            ElseIf dr1("nOdemeTipi") = 2 Then
                kredi += dr1("Odeme")
                miktar += dr1("nKayit")
            End If
            'Normal Ödemeleri Ayıkla
            If dr1("nGirisCikis") = 3 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Then
                        kredipesinat += dr1("Odeme")
                        miktar += dr1("nKayit")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinsatis += dr1("Odeme")
                        miktar += dr1("nKayit")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                    krediodeme += dr1("odeme")
                    miktar += dr1("nKayit")
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
                'İade Ödemeleri Ayıkla
            ElseIf dr1("nGirisCikis") = 4 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Then
                        krediiade += dr1("Odeme")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinatiade += dr1("Odeme")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
            End If
            If sayi = toplam Then
                dr = DataSet1.Tables(0).NewRow
                dr("Sınıf") = "Ödemeler"
                dr("Aciklama") = odemeaciklama
                dr("MIKTAR") = miktar
                dr("IZAHAT") = Odeme
                dr("col1") = FormatNumber(kredipesinat, 2)
                dr("col2") = FormatNumber(pesinsatis, 2)
                dr("col3") = FormatNumber(krediodeme, 2)
                dr("col4") = FormatNumber(krediiade, 2)
                dr("col5") = FormatNumber(pesinatiade, 2)
                dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                If dr("IZAHAT") = "N" Then
                    nakit = CType(dr("col6"), Decimal)
                End If
                dr("Status") = 1
                top_kredipesinat += CType(dr("col1"), Decimal)
                top_pesinpesinat += CType(dr("col2"), Decimal)
                top_krediodeme += CType(dr("col3"), Decimal)
                top_krediiade += CType(dr("col4"), Decimal)
                top_pesinatiade += CType(dr("col5"), Decimal)
                top_toplam += CType(dr("col6"), Decimal)
                DataSet1.Tables(0).Rows.Add(dr)
                kredipesinat = 0
                pesinsatis = 0
                krediodeme = 0
                krediiade = 0
                pesinatiade = 0
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Sınıf") = "Ödemeler"
        dr("Aciklama") = "ÖdemelerinToplamı"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        dr("col1") = FormatNumber(top_kredipesinat, 2)
        dr("col2") = FormatNumber(top_pesinpesinat, 2)
        dr("col3") = FormatNumber(top_krediodeme, 2)
        dr("col4") = FormatNumber(top_krediiade, 2)
        dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(top_toplam, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sınıf") = "Nakit"
        dr("Aciklama") = "NakitlerinToplamı"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(nakit, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sınıf") = "Kredi"
        dr("Aciklama") = "KredilerinToplamı"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(kredi, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        'masraflar 
        dataload_masraflar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
    End Sub
    Private Sub dataload_odemesayisi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND b.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(DISTINCT lMakbuzNo) AS Sayi FROM         tbOdeme b WHERE     (nOdemeKodu = 2) " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sınıf") = "Ödemeler"
            dr("Aciklama") = "ÖdemeYapanMüşteri"
            dr("MIKTAR") = dr1("Sayi")
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_masraflar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (a.dteMasrafTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND a.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND a.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND a.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select isnull(sum(a.lTutar), 0) as lTutar from tbMagazaMasrafi as a , tbParekendeKasa as b,tbKasiyer Where a.nKasaNo = b.nKasaNo and a.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu  " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        masraf = 0
        For Each dr1 In ds1.Tables(0).Rows
            masraf += dr1("lTutar")
        Next
        Dim lMasraf As Decimal
        If masraf <> 0 Then
            lMasraf = -(masraf)
            dr = DataSet1.Tables(0).NewRow
            dr("Sınıf") = "Masraf"
            dr("Aciklama") = "MasraflarınToplamı"
            dr("MIKTAR") = 0
            dr("IZAHAT") = ""
            'dr("col1") = FormatNumber(top_kredipesinat, 2)
            'dr("col2") = FormatNumber(top_pesinpesinat, 2)
            'dr("col3") = FormatNumber(top_krediodeme, 2)
            'dr("col4") = FormatNumber(top_krediiade, 2)
            'dr("col5") = FormatNumber(top_pesinatiade, 2)
            dr("col6") = FormatNumber(lMasraf, 2)
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        End If
        dr = Nothing
        dr1 = Nothing
        lMasraf = Nothing
    End Sub
    Private Function KasaKasiyerRaporu() As String
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">KasaKasiyer Raporu</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        s += "<th class=""cs67572338""></th>"
        kayit = 0
        ProgressBar2.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In dataset1.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Sınıf") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Aciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("IZAHAT") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("MIKTAR") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Col1") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Col2") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Col3") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Col4") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Col5") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Col6") & "</td>"

            s += "</tr>"
            kayit += 1
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function GelirTablosu() As String
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">Gelir Tablosu</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Başlık</th>"
        s += "<th class=""cs67572338"">Açıklama</th>"
        s += "<th class=""cs67572338"">Miktar</th>"
        s += "<th class=""cs67572338"">Sayi</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        s += "<th class=""cs67572338"">Kar</th>"
        s += "<th class=""cs67572338"">Yuzde</th>"
        s += "<th class=""cs67572338"">Not</th>"

        kayit = 0
        ProgressBar2.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In dataset1.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Baslik") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Aciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Miktar") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Sayi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("Tutar"), 0), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("Kar"), 0), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">%" & Format(sorgu_sayi(dr("Yuzde"), 0), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Not") & "</td>"

            s += "</tr>"
            kayit += 1
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function DurumTablosu() As String
        Dim dr As DataRow
        Dim kayit As Decimal = 0
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">Durum Tablosu</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Başlık</th>"
        s += "<th class=""cs67572338"">Açıklama</th>"
        s += "<th class=""cs67572338"">Miktar</th>"
        s += "<th class=""cs67572338"">Sayi</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        s += "<th class=""cs67572338"">Kar</th>"
        s += "<th class=""cs67572338"">Yuzde</th>"
        s += "<th class=""cs67572338"">Not</th>"
        kayit = 0
        ProgressBar2.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In dataset1.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Baslik") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Aciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Miktar") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Sayi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("Tutar"), 0), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("Kar"), 0), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">%" & Format(sorgu_sayi(dr("Yuzde"), 0), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Not") & "</td>"
            s += "</tr>"
            kayit += 1
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        's += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        's += "<td class=""cs67572338"" style=""width:52px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Public Function dataload_tbCekSenet(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sCekSenetKodu As String, ByVal sTarih As String, ByVal sec_bTumu As Boolean, ByVal sAciklama As String) As String
        Dim kriter As String = "WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "')"
        If sTarih = "Vade:" Then
            kriter += " AND tbCekSenet.dteVadeTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        ElseIf sTarih = "Tarih:" Then
            kriter += " AND tbCekSenetBordro.dteBordroTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        End If
        kriter += " and tbCekSenet.lCekSenetNo between '" & lBordroNo1 & "' and '" & lBordroNo2 & "'"
        If Trim(sBankaKodu) <> "" Then
            kriter += " And tbCekSenet.sBankaKodu = '" & sBankaKodu & "' "
        End If
        If nCekSenetIslem <> "[Tümü]" Then
            kriter += " and tbCekSenetBordro.nCekSenetIslem IN (" & nCekSenetIslem & ") "
        End If
        If Trim(sCekSenetKodu) <> "" Then
            If sec_bTumu = True Then
            Else
                kriter += " and tbCekSenet.sCekSenetKodu1 = '" & Trim(sCekSenetKodu) & "'"
            End If
        End If
        Dim dr As DataRow
        Dim ds_tbCekSenet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.sCekSenetTipi,tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.nVerenID,tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, tbFirma_1.sKodu AS sAlanFirmaKodu, tbFirma_1.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi,(SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lTahsilat, tbCekSenet.lTutar - (SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lKalan,tbCekSenet.sKullaniciAdi,tbCekSenet.dteKayitTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi"), "tbCekSenet")
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & dteBordroTarihi1 & " ve " & dteBordroTarihi2 & "Tarihleri Arasındaki " & sAciklama & "</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">İşlem</th>"
        s += "<th class=""cs67572338"">FirmaKodu</th>"
        s += "<th class=""cs67572338"">Firma</th>"
        s += "<th class=""cs67572338"">Portföy</th>"
        s += "<th class=""cs67572338"">EvrakNo</th>"
        s += "<th class=""cs67572338"">Kalan</th>"
        s += "<th class=""cs67572338"">Vade</th>"
        s += "<th class=""cs67572338"">Semt</th>"
        s += "<th class=""cs67572338"">Banka</th>"
        s += "<th class=""cs67572338"">DövizCinsi</th>"
        Dim kayit As Integer = 0
        Dim lKalan As Decimal = 0
        kayit = 0
        ProgressBar2.Properties.Maximum = ds_tbCekSenet.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbCekSenet.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sIslem") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sVerenFirmaKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sVerenFirmaAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lCekSenetNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sOrjinalCekSenetNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lKalan") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("dteVadeTarihi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sSemt") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sBankaAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sDovizCinsi1") & "</td>"
            s += "</tr>"
            kayit += 1
            lKalan += dr("lKalan")
            ProgressBar2.EditValue = 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lKalan, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Public Function Dataload_tbCekSenetBordro(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal dteVadeTarihi1 As DateTime, ByVal dteVadeTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sCekSenetKodu As String, ByVal sec_bTumu As Boolean, ByVal sAciklama As String) As String
        Dim kriter As String = " WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenet.sBankaKodu = tbBanka.sBankaKodu  AND tbCekSenetIslem.nCekSenetIslem = tbCekSenetBordro.nCekSenetIslem AND (tbCekSenet.sCekSenetTipi IN ('AC','AS','BC','BS'))"
        kriter += " AND tbCekSenetBordro.dteBordroTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        kriter += " AND tbCekSenet.dteVadeTarihi between '" & dteVadeTarihi1 & "' and '" & dteVadeTarihi2 & "' "
        kriter += " and tbCekSenet.lCekSenetNo between '" & lBordroNo1 & "' and '" & lBordroNo2 & "'"
        'kriter += " and tbCekSenet.sOrjinalCekSenetNo between '" & sEvrakNo1 & "' and '" & sEvrakNo2 & "'"
        If Trim(sBankaKodu) <> "" Then
            kriter += " And tbCekSenet.sBankaKodu = '" & sBankaKodu & "' "
        End If
        If nCekSenetIslem <> "[Tümü]" And nCekSenetIslem <> "" Then
            kriter += " and tbCekSenetBordro.nCekSenetIslem IN (" & nCekSenetIslem & ") "
        End If
        If Trim(sCekSenetKodu) <> "" Then
            If sec_bTumu = True Then
            Else
                kriter += " and tbCekSenet.sCekSenetKodu1 = '" & Trim(sCekSenetKodu) & "'"
            End If
        End If
        Dim ds_tbCekSenetBordro = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.sCekSenetTipi,tbCekSenetBordro.dteBordroTarihi,CONVERT(char(10), tbCekSenetBordro.dteBordroTarihi, 103) + ' ' + tbCekSenetIslem.sAciklama AS Status, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, tbFirma.sAciklama, tbCekSenet.lCekSenetNo, tbBanka.sBankaKodu, tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sSemt, tbCekSenet.sIl, tbCekSenet.dteVadeTarihi, tbCekSenet.lTutar, lGiren = CASE WHEN tbCekSenetBordro.nCekSenetIslem = 1 OR tbCekSenetBordro.nCekSenetIslem = 6 OR tbCekSenetBordro.nCekSenetIslem = 22 THEN tbCekSenet.lTutar ELSE 0 END, lCikan = CASE WHEN tbCekSenetBordro.nCekSenetIslem = 2 OR tbCekSenetBordro.nCekSenetIslem = 3 OR tbCekSenetBordro.nCekSenetIslem = 4 OR tbCekSenetBordro.nCekSenetIslem = 5 OR tbCekSenetBordro.nCekSenetIslem = 20 THEN tbCekSenet.lTutar ELSE 0 END,(DateDiff(Day, tbCekSenetBordro.dteBordroTarihi, tbCekSenet.dteVadeTarihi) * tbCekSenet.lTutar) VadeGun, tbHareketTipi.sHareketTipi, tbHareketTipi.sAciklama AS sHareketAciklama, tbCekSenet.sOrjinalCekSenetNo, sCekSenetKodu1 + (CASE sCekSenetKodu1 WHEN '' THEN '' ELSE ' - ' END) + (SELECT sAciklama FROM tbCekSenetKodu WHERE tbCekSenetKodu.sCekSenetKodu = tbCekSenet.sCekSenetKodu1) AS Kod1, sCekSenetKodu2 + (CASE sCekSenetKodu2 WHEN '' THEN '' ELSE ' - ' END) + (SELECT sAciklama FROM tbCekSenetKodu WHERE tbCekSenetKodu.sCekSenetKodu = tbCekSenet.sCekSenetKodu2) AS Kod2,tbCekSenet.sNot FROM tbCekSenetIslem, tbCekSenetBordro, tbCekSenet, tbFirma, tbBanka, tbHareketTipi " & kriter & " ORDER BY tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, tbCekSenet.dteVadeTarihi"), "tbCekSenetBordro")
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & dteBordroTarihi1 & " ve " & dteBordroTarihi2 & " Tarihleri Arasındaki İşlemler# " & sAciklama & "</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">İşlem</th>"
        s += "<th class=""cs67572338"">BordroNo</th>"
        s += "<th class=""cs67572338"">Kodu</th>"
        s += "<th class=""cs67572338"">Açıklama</th>"
        s += "<th class=""cs67572338"">Banka</th>"
        s += "<th class=""cs67572338"">Semt</th>"
        s += "<th class=""cs67572338"">EvrakNo</th>"
        s += "<th class=""cs67572338"">Vade</th>"
        s += "<th class=""cs67572338"">Giren</th>"
        s += "<th class=""cs67572338"">Çıkan</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        Dim dr As DataRow
        Dim kayit As Integer = 0
        Dim lGiren As Decimal = 0
        Dim lCikan As Decimal = 0
        Dim lTutar As Decimal = 0
        kayit = 0
        ProgressBar2.Properties.Maximum = ds_tbSatisMagaza.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbCekSenetBordro.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:150px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Status") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lBordroNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sBankaAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sSemt") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sOrjinalCekSenetNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("dteVadeTarihi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lGiren"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lCikan"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lTutar"), "#,#.##") & "</td>"
            s += "</tr>"
            kayit += 1
            lGiren += dr("lGiren")
            lCikan += dr("lCikan")
            lTutar += dr("lTutar")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:150px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lGiren, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lCikan, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lTutar, "#,0.00") & "</td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Public Function Dataload_StokListesiEksiyeDusenler(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal mevcut As String, ByVal depo As String) As String
        Dim kriter = "WHERE tbStok.sKodu <> '' and tbStok.nStokTipi < 5 "
        Dim kriter2 = ""
        Dim kriter_depo = ""
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter += " AND (tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
            ElseIf konum = "Sınıf1" Then
                kriter += " AND ( tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf2" Then
                kriter += " AND ( tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf3" Then
                kriter += " AND ( tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf4" Then
                kriter += " AND ( tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf5" Then
                kriter += " AND ( tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf6" Then
                kriter += " AND ( tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf7" Then
                kriter += " AND ( tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf8" Then
                kriter += " AND ( tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf9" Then
                kriter += " AND ( tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf10" Then
                kriter += " AND ( tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf11" Then
                kriter += " AND ( tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf12" Then
                kriter += " AND ( tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf13" Then
                kriter += " AND ( tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf14" Then
                kriter += " AND ( tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf15" Then
                kriter += " AND ( tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        If sStokSinirla <> "" Then
            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
        End If
        If depo <> "[Tümü]" Then
            kriter += " AND tbStokFisiDetayi.sDepo IN ( " & depo & " )"
        End If
        If mevcut <> "" Then
            If mevcut = "[Tümü]" Then
            ElseIf mevcut = "Artılar" Then
                kriter2 = " WHERE (Mevcut > 0) "
            ElseIf mevcut = "Eksiler" Then
                kriter2 = " Where (Mevcut < 0) "
            ElseIf mevcut = "Bitenler" Then
                kriter2 = " Where (Mevcut = 0) "
            End If
        End If
        Dim ds_tbStok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) AS Mevcut, { fn UCASE(tbStokFisiDetayi.sDepo) } AS sDepo, tbStok.nStokID,tbStok.sKodu, tbStok.sAciklama,tbStok.sModel, tbStok.sBeden,tbStok.sKavala,tbRenk.sRenkAdi,'' as ISTIHBARAT FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY { fn UCASE(tbStokFisiDetayi.sDepo) }, tbStok.nStokID,tbStok.sKodu, tbStok.sAciklama, tbStok.sModel,tbStok.sBeden,tbStok.sKavala,tbRenk.sRenkAdi HAVING (SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) < 0) ORDER BY { fn UCASE(tbStokFisiDetayi.sDepo) }  , tbStok.sKodu"), "tbStok")
        Dim s As String = ""
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & DateEdit2.Value & " Tarih itibariyle (-)Eksiye Düşen Stoklar</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">StokKodu</th>"
        s += "<th class=""cs67572338"">StokAdı</th>"
        s += "<th class=""cs67572338"">Renk</th>"
        s += "<th class=""cs67572338"">Beden</th>"
        s += "<th class=""cs67572338"">Kavala</th>"
        s += "<th class=""cs67572338"">Mevcut</th>"
        s += "<th class=""cs67572338"">Depo</th>"

        Dim dr As DataRow
        Dim kayit As Integer = 0
        Dim lMiktar As Decimal = 0
        kayit = 0
        ProgressBar2.Properties.Maximum = ds_tbStok.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbStok.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:90px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sRenkAdi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sBeden") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:56px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKavala") & "</td>"

            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("Mevcut"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sDepo") & "</td>"
            s += "</tr>"
            kayit += 1

            lMiktar += dr("Mevcut")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:90px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:56px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lMiktar, "#,0.###") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Public Function dataload_tbFisler(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String, ByVal sSaticiRumuzu As String, ByVal sAciklama As String) As String
        Dim kriter As String = "WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        kriter += " and tbStokFisiMaster.lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'"
        kriter += " and tbStokFisiMaster.lNetTutar between '" & lNetTutar1 & "' and '" & lNetTutar2 & "'"
        'If Trim(sDepo) <> "" Then
        '    kriter += " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sDepo IN ('" & sDepo & "')) and dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' and sFisTipi '" & sFisTipi & "' and nGirisCikis =" & nGirisCikis & ") "
        'End If
        If Trim(sHareketTipi) <> "" Then
            kriter += " And tbStokFisiMaster.sHareketTipi = '" & sHareketTipi & "' "
        End If
        If nGirisCikis > 0 Then
            kriter += " and tbStokFisiMaster.nGirisCikis =" & nGirisCikis & " "
        End If
        If Trim(sFisTipi) = "PF" Then
            If CStr(Trim(ara.ToString)) <> "" Then
                If konum = "Kodu" Then
                    kriter += " AND   (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf konum = "Adı" Then
                    kriter += " AND  (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        Else
            If CStr(Trim(ara.ToString)) <> "" Then
                If konum = "Kodu" Then
                    kriter += " AND   (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf konum = "Adı" Then
                    kriter += " AND  (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        End If
        If Trim(sDepo) <> "[Tümü]" Then
            kriter += " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sDepo IN (" & sDepo & ")) and (dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "') )"
        End If
        If Trim(sSaticiRumuzu) <> "" Then
            kriter += " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sSaticiRumuzu IN ('" & sSaticiRumuzu & "')) and (dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "') )"
        End If
        Dim nCiktiSatirSayisi As Integer = 25
        If nGirisCikis = 3 Or nGirisCikis = 4 Then
            If Trim(sFisTipi) = "FS" Then
                nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
            ElseIf Trim(sFisTipi) = "IS" Then
                nCiktiSatirSayisi = nIrsaliyeCiktiSatirSayisi
            ElseIf Trim(sFisTipi) = "DC" Then
                nCiktiSatirSayisi = nStokFisiCiktiSatirSayisi
            ElseIf Trim(sFisTipi) = "HS" Then
                nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
            End If
        End If
        Dim nSayfa = ""
        Dim ds_tbStokFisiMaster As DataSet
        If Trim(sFisTipi) = "PF" Then
            ds_tbStokFisiMaster = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, tbStokFisiMaster.bPesinmi,CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot, tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5 AS KdvTutari, tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5 AS KdvMatrahi, tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 AS EkMaliyet, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli, CAST(0 AS MONEY) AS ISKONTO, tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI, CAST(0 AS MONEY) AS EkOran, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari3, tbMusteri.nMusteriID, tbMusteri.lKodu AS sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAciklama,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli FROM tbStokFisiMaster INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo"), "tbFisler")
        Else
            ds_tbStokFisiMaster = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,ISKONTO = CASE WHEN (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) / tbStokFisiMaster.lMalBedeli END, EkOran = CASE WHEN tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) END,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari,tbStokFisiMaster.lOTV2,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli " & nSayfa & "  FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo"), "tbFisler")
        End If
        Dim dr As DataRow
        Dim s As String
        'Başlık
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & dteFisTarihi1 & " ve " & dteFisTarihi2 & " Tarihleri Arasında ki " & sAciklama & "</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Tarih</th>"
        s += "<th class=""cs67572338"">FirmaKodu</th>"
        s += "<th class=""cs67572338"">FirmaAdı</th>"
        s += "<th class=""cs67572338"">FişNo</th>"
        s += "<th class=""cs67572338"">Miktar</th>"
        s += "<th class=""cs67572338"">Brüt</th>"
        s += "<th class=""cs67572338"">İskonto</th>"
        s += "<th class=""cs67572338"">%İsk</th>"
        s += "<th class=""cs67572338"">KdvTutarı</th>"
        s += "<th class=""cs67572338"">NetTutar</th>"
        s += "<th class=""cs67572338"">Notlar</th>"
        s += "<th class=""cs67572338"">Kilitli</th>"
        s += "<th class=""cs67572338"">Depo</th>"
        s += "<th class=""cs67572338"">Transfer</th>"
        s += "<th class=""cs67572338"">Kaydeden</th>"
        Dim kayit As Integer = 0
        Dim lMiktar As Decimal = 0
        Dim lToplamMalBedeli As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lNetTutar As Decimal = 0
        Dim lKdvTutari As Decimal = 0
        kayit = 0
        ProgressBar2.Properties.Maximum = ds_tbStokFisiMaster.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds_tbStokFisiMaster.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("dteFisTarihi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:90px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lFisNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lToplamMiktar"), "#,0.") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lMalBedeli"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lIskontoTutari"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;"">%" & Format(dr("ISKONTO"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("KdvTutari"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(dr("lNetTutar"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sNot") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("bKilitli") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sDepo") & "\" & dr("Depo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sTransferDepo") & "\" & dr("Depo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKullaniciAdi") & "</td>"
            s += "</tr>"
            kayit += 1
            lMiktar += dr("lToplamMiktar")
            lToplamMalBedeli += dr("lMalBedeli")
            lIskontoTutari += dr("lIskontoTutari")
            lKdvTutari += dr("KdvTutari")
            lNetTutar += dr("lNetTutar")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:90px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lMiktar, "#,0.###") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lToplamMalBedeli, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lIskontoTutari, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lKdvTutari, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lNetTutar, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Sub dataload_satis_magazalar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sec_FS As Boolean, ByVal sec_DC As Boolean)
        If sec_FS = True Or sec_DC = True Then
            Dim sFisTipi_kriter As String = ""
            If sec_FS = True And sec_DC = True Then
                sFisTipi_kriter = " AND (tbStokFisiDetayi.sFisTipi IN ('FS','DC')) "
            ElseIf sec_FS = True And sec_DC = False Then
                sFisTipi_kriter = " AND (tbStokFisiDetayi.sFisTipi IN ('FS')) "
            ElseIf sec_FS = False And sec_DC = True Then
                sFisTipi_kriter = " AND (tbStokFisiDetayi.sFisTipi IN ('DC')) "
            End If
            'ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '17' AS IND, 'Satışlar' AS Baslik, sMagaza AS Aciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde, COUNT(DISTINCT nMusteriID) AS Sayi FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi , tbStokFisiDetayi.sFisTipi , tbStokFisiDetayi.sDepo AS sMagaza , tbStokFisiDetayi.nFirmaID AS nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar , tbSSinif1.sSinifKodu , tbSSinif1.sAciklama , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & sFisTipi_kriter & ") Satislar WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY sMagaza ORDER BY sMagaza "))
            ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '17' AS IND, 'Satışlar' AS Baslik, sMagaza AS Aciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde, COUNT(DISTINCT nMusteriID) AS Sayi FROM (SELECT tbAlisVeris.nAlisVerisID,tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbAlisVeris.nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.nAlisVerisID,tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbAlisVeris.nMusteriID, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.nAlisVerisID,tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi , tbStokFisiDetayi.sFisTipi , tbStokFisiDetayi.sDepo AS sMagaza , tbStokFisiDetayi.nFirmaID AS nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar , tbSSinif1.sSinifKodu , tbSSinif1.sAciklama , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & sFisTipi_kriter & ") Satislar WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY sMagaza ORDER BY sMagaza "))
        Else
            ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '17' AS IND, 'Satışlar' AS Baslik,sMagaza AS Aciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde, COUNT(DISTINCT nAlisVerisID) AS Sayi FROM (SELECT tbAlisVeris.nAlisVerisID,tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbAlisVeris.nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.nAlisVerisID,tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbAlisVeris.nMusteriID, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar WHERE dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sMagaza ORDER BY sMagaza "))
        End If
        Dim dr As DataRow
        Dim dr1 As DataRow
        tutar = 0
        maliyet = 0
        kar = 0
        miktar = 0
        sayi = 0
        For Each dr1 In ds1.Tables(0).Rows
            tutar += dr1("Tutar")
            maliyet += dr1("Maliyet")
            kar += dr1("Kar")
            miktar += dr1("Miktar")
            sayi += dr1("Sayi")
        Next
        dr = dataset1.Tables(0).NewRow
        dr("Baslik") = "Satışlar"
        dr("Aciklama") = ""
        dr("Miktar") = miktar
        dr("Sayi") = sayi
        dr("Tutar") = tutar
        dr("Yuzde") = 1
        dr("Status") = 0
        dataset1.Tables(0).Rows.Add(dr)
        For Each dr1 In ds1.Tables(0).Rows
            'Satışlar
            dr = dataset1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil) + " Detay"
            dr("sMagaza") = Replace(Trim(dr1("Aciklama")), "D", "")
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "-" & sorgu_sDepoAdi(dr1("Aciklama"))
            dr("Miktar") = dr1("Miktar")
            dr("Sayi") = dr1("Sayi")
            dr("Kar") = dr1("Tutar")
            Try
                dr("Yuzde") = dr1("Tutar") / tutar
            Catch ex As Exception
                dr("Yuzde") = 0
            End Try
            dr("Status") = 1
            dataset1.Tables(0).Rows.Add(dr)
        Next
        dr = dataset1.Tables(0).NewRow
        dr("Baslik") = "Maliyetler"
        dr("Aciklama") = ""
        dr("Tutar") = -maliyet
        dr("Status") = 0
        dataset1.Tables(0).Rows.Add(dr)
        For Each dr1 In ds1.Tables(0).Rows
            'Maliyetler
            dr = dataset1.Tables(0).NewRow
            dr("Baslik") = "Satış Maliyeti" + " Detay"
            dr("sMagaza") = Replace(Trim(dr1("Aciklama")), "D", "")
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "-" & sorgu_sDepoAdi(dr1("Aciklama"))
            dr("Kar") = -dr1("Maliyet")
            dr("Status") = 1
            dataset1.Tables(0).Rows.Add(dr)
        Next
        dr = dataset1.Tables(0).NewRow
        dr("Baslik") = "Brüt Kar"
        dr("Aciklama") = ""
        dr("Tutar") = kar
        Try
            dr("Yuzde") = (tutar - maliyet) / maliyet
        Catch ex As Exception
            dr("Yuzde") = 0
        End Try
        dr("Status") = 0
        dataset1.Tables(0).Rows.Add(dr)
        For Each dr1 In ds1.Tables(0).Rows
            'Maliyetler
            dr = dataset1.Tables(0).NewRow
            dr("Baslik") = "Karlılık" + " Detay"
            dr("sMagaza") = Replace(Trim(dr1("Aciklama")), "D", "")
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "-" & sorgu_sDepoAdi(dr1("Aciklama"))
            dr("Kar") = dr1("Kar")
            dr("Yuzde") = dr1("Yuzde")
            dr("Status") = 1
            dataset1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_masraf_dagilim(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sec_bMasrafAlacakli As Boolean)
        If sec_bMasrafAlacakli = True Then
            ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '10' AS IND, LOWER(tbFSinif1.sAciklama) AS Baslik, LOWER(tbFSinif2.sAciklama) AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, - SUM(tbFirmaHareketi.lBorcTutar-tbFirmaHareketi.lAlacakTutar) AS Tutar,tbFirmaHareketi.sHareketTipi FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE (tbFirma.sKodu LIKE '800%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirmaHareketi.sHareketTipi,tbFSinif1.sAciklama, tbFSinif2.sAciklama ORDER BY tbFirmaHareketi.sHareketTipi,tbFSinif1.sAciklama, tbFSinif2.sAciklama "))
        Else
            ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '10' AS IND, LOWER(tbFSinif1.sAciklama) AS Baslik, LOWER(tbFSinif2.sAciklama) AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, - SUM(tbFirmaHareketi.lBorcTutar) AS Tutar,tbFirmaHareketi.sHareketTipi FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE (tbFirma.sKodu LIKE '800%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirmaHareketi.sHareketTipi,tbFSinif1.sAciklama, tbFSinif2.sAciklama ORDER BY tbFirmaHareketi.sHareketTipi,tbFSinif1.sAciklama, tbFSinif2.sAciklama "))
        End If
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim masraf As Decimal = 0
        Dim masrafsayi As Decimal = 0
        For Each dr1 In ds1.Tables(0).Rows
            masraf += dr1("Tutar")
            masrafsayi += dr1("Sayi")
        Next
        dr = dataset1.Tables(0).NewRow
        dr("Baslik") = "Masraflar"
        dr("Aciklama") = "Toplam Masraf"
        dr("Sayi") = masrafsayi
        dr("Tutar") = masraf
        Try
            dr("Yuzde") = masraf / tutar
        Catch ex As Exception
            dr("Yuzde") = 0
        End Try
        dr("Status") = 0
        dataset1.Tables(0).Rows.Add(dr)
        For Each dr1 In ds1.Tables(0).Rows
            dr = dataset1.Tables(0).NewRow
            dr("Baslik") = dr1("sHareketTipi") & "-" & dr1("Baslik") & Sorgu_sDil(" Masrafı", sDil)
            dr("sMagaza") = Sorgu_sDil(dr1("sHareketTipi"), sDil)
            dr("sSinif1") = dr1("Baslik")
            dr("sSinif2") = dr1("Aciklama")
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Sayi") = dr1("Sayi")
            dr("Kar") = dr1("Tutar")
            Try
                dr("Yuzde") = dr1("Tutar") / masraf
            Catch ex As Exception
                dr("Yuzde") = 0
            End Try
            dr("Status") = 1
            dataset1.Tables(0).Rows.Add(dr)
        Next
        dr = dataset1.Tables(0).NewRow
        dr("Baslik") = "Kar"
        dr("Aciklama") = "Satış Karı"
        'dr("Sayi") = dr1("Sayi")
        dr("Tutar") = (kar) - (Math.Abs(masraf))
        satiskari = dr("Tutar")
        Try
            dr("Yuzde") = dr("Tutar") / maliyet
        Catch ex As Exception
            dr("Yuzde") = 0
        End Try
        dr("Status") = 0
        dataset1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_mevcut_mal(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS IND, 'Envanter' AS Baslik, 'Mevcut Mal Tutarı' AS Aciklama, COUNT(DISTINCT nStokID) AS Sayi, SUM(Mevcut) AS Miktar, SUM(Mevcut * Maliyet) AS Tutar FROM (SELECT Stok.nStokID , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') AS Mevcut , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk WHERE (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') > 0) t"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Miktar") = sorgu_sayi(dr1("Miktar"), 0)
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_acikhesap(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '1' AS IND, 'Borçlar' AS Baslik, 'Açık Hesap Borç Bakiyesi' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '320%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '1' AS IND, 'Borçlar' AS Baslik, 'Açık Hesap Borç Bakiyesi' AS Aciklama, COUNT(DISTINCT tbCari.nFirmaID) AS Sayi, tbCariHareketi.sDovizCinsi1, SUM(tbCariHareketi.DBakiye) AS Bakiye FROM (SELECT nFirmaID , sFirmaKodu , SUM(lBorcTutar) Borc , SUM(lAlacakTutar) Alacak , SUM(lBorcTutar - lAlacakTutar) AS DBakiye , sDovizCinsi1 FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu AS sFirmaKodu , tbFirma.sAciklama AS sFirmaAciklama , lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END , lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END , Bakiye = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lBorcTutar - lAlacakTutar END , sDovizCinsi1 FROM tbFirma , tbCariIslem , tbFirmaHareketi LEFT OUTER JOIN tbStokfisiOdemePlani ON tbStokfisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem) AS T GROUP BY sDovizCinsi1 , nFirmaID , sFirmaKodu) tbCariHareketi LEFT OUTER JOIN (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS Bakiye FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.sKodu LIKE '320%') tbCari ON tbCari.nFirmaID = tbCariHareketi.nFirmaID WHERE (tbCari.Bakiye <> 0) GROUP BY tbCariHareketi.sDovizCinsi1 ORDER BY tbCariHareketi.sDovizCinsi1 DESC"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "( " & dr1("sDovizCinsi1") & " )"
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Bakiye"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alacak_acikhesap(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '1' AS IND, 'Borçlar' AS Baslik, 'Açık Hesap Borç Bakiyesi' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '320%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '1' AS IND, 'Alacaklar' AS Baslik, 'Açık Hesap Alacak Bakiyesi' AS Aciklama, COUNT(DISTINCT tbCari.nFirmaID) AS Sayi, tbCariHareketi.sDovizCinsi1, SUM(tbCariHareketi.DBakiye) AS Bakiye FROM (SELECT nFirmaID , sFirmaKodu , SUM(lBorcTutar) Borc , SUM(lAlacakTutar) Alacak , SUM(lBorcTutar - lAlacakTutar) AS DBakiye , sDovizCinsi1 FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu AS sFirmaKodu , tbFirma.sAciklama AS sFirmaAciklama , lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END , lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END , Bakiye = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lBorcTutar - lAlacakTutar END , sDovizCinsi1 FROM tbFirma , tbCariIslem , tbFirmaHareketi LEFT OUTER JOIN tbStokfisiOdemePlani ON tbStokfisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem) AS T GROUP BY sDovizCinsi1 , nFirmaID , sFirmaKodu) tbCariHareketi LEFT OUTER JOIN (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS Bakiye FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.sKodu LIKE '120%') tbCari ON tbCari.nFirmaID = tbCariHareketi.nFirmaID WHERE (tbCari.Bakiye <> 0) GROUP BY tbCariHareketi.sDovizCinsi1 ORDER BY tbCariHareketi.sDovizCinsi1 DESC"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "( " & dr1("sDovizCinsi1") & " )"
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Bakiye"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_acikhesap_tumu(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '1' AS IND, 'Borçlar' AS Baslik, 'Açık Hesap Borç Bakiyesi Değeri' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Bakiye,'YTL' AS sDovizCinsi1 FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '320%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "( " & dr1("sDovizCinsi1") & " )"
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Bakiye"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alacak_acikhesap_tumu(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '1' AS IND, 'Alacaklar' AS Baslik, 'Açık Hesap Alacak Bakiyesi Değeri' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Bakiye,'YTL' AS sDovizCinsi1 FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '120%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "( " & dr1("sDovizCinsi1") & " )"
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Bakiye"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_odenecek_cekler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '2' AS IND, 'Borçlar' AS Baslik, 'Ödenecek Çekler' AS Aciklama, COUNT(DISTINCT tbCekSenet.lCekSenetNo) AS Sayi, -SUM(tbCekSenet.lTutar) AS Tutar FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu WHERE (tbFirma.sKodu BETWEEN '' AND 'zzzzzzzzzzzzzzz') AND (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenetBordro.nCekSenetIslem = 20) AND (tbCekSenetBordro.dteBordroTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih2 & "' AND '31/12/2078') AND (tbCekSenetBordro.lBordroNo BETWEEN 0 AND 999999999) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_odenecek_senetler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '2' AS IND, 'Borçlar' AS Baslik, 'Ödenecek Senetler' AS Aciklama, COUNT(DISTINCT tbCekSenet.lCekSenetNo) AS Sayi, -SUM(tbCekSenet.lTutar) AS Tutar FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu WHERE (tbFirma.sKodu BETWEEN '' AND 'zzzzzzzzzzzzzzz') AND (tbCekSenet.sCekSenetTipi = 'BS') AND (tbCekSenetBordro.nCekSenetIslem = 20) AND (tbCekSenetBordro.dteBordroTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih2 & "' AND '31/12/2078') AND (tbCekSenetBordro.lBordroNo BETWEEN 0 AND 999999999) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_kredikarti(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '4' AS IND, 'Borçlar' AS Baslik, 'Kredi Kartı Ödemeleri' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '903.02.00001%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "')"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_borc_kredikarti_detay(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '4' AS IND, 'Borçlar' AS Baslik, tbFirma.sAciklama AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '903.02.00001%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') GROUP BY tbFirma.sAciklama"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alacak_musteriler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '5' AS IND, 'Alacaklar' AS Baslik, 'Müşterilerden Alacaklar' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID ,  isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme WHERE dteOdemeTarihi <= '" & tarih2 & "' GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbAlisVeris.dteFaturaTarihi <= '" & tarih2 & "' GROUP BY tbMusteri.nMusteriID ) tbptemp WHERE (Tutar > 0 ) GROUP BY nMusteriID ) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            dr("Not") = tarih2 & " İtibariyle Alacaklar"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alacak_musteriler_Tumu(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     '5' AS IND, 'Müşteri' AS Baslik, 'Aktif Bakiyeli Müşteriler' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS Tutar FROM         vwMusteriKalan "))
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '5' AS IND, 'Alacaklar' AS Baslik, 'Müşterilerden Alacaklar' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID ,  isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme  GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID  GROUP BY tbMusteri.nMusteriID ) tbptemp WHERE (Tutar > 0 ) GROUP BY nMusteriID ) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            dr("Not") = Today & " İtibariyle Müşteri Bakiye Toplamları"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_mevcut_kasa(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '6' AS IND, 'Kasa' AS Baslik, 'Nakit Kasa Mevcudu' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '770.01.00001%') AND (tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_mevcut_banka(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '7' AS IND, 'Banka' AS Baslik, 'Banka Nakit Mevcudu' AS Aciklama, COUNT(DISTINCT tbCari.nFirmaID) AS Sayi, tbCariHareketi.sDovizCinsi1, SUM(tbCariHareketi.DBakiye) AS Bakiye FROM (SELECT nFirmaID , sFirmaKodu , SUM(lBorcTutar) Borc , SUM(lAlacakTutar) Alacak , SUM(lBorcTutar - lAlacakTutar) AS DBakiye , sDovizCinsi1 FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu AS sFirmaKodu , tbFirma.sAciklama AS sFirmaAciklama , lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END , lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 = '' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END , Bakiye = CASE WHEN tbFirmaHareketi.lBorcTutar <> 0 AND sDovizCinsi1 <> '' THEN lDovizMiktari1 WHEN tbFirmaHareketi.lAlacakTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lBorcTutar - lAlacakTutar END , sDovizCinsi1 FROM tbFirma , tbCariIslem , tbFirmaHareketi LEFT OUTER JOIN tbStokfisiOdemePlani ON tbStokfisiOdemePlani.nCariHareketID = tbFirmaHareketi.nHareketID WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "' AND tbCariIslem.sCariIslem = tbFirmaHareketi.sCariIslem) AS T GROUP BY sDovizCinsi1 , nFirmaID , sFirmaKodu) tbCariHareketi LEFT OUTER JOIN (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS Bakiye FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.sKodu LIKE '102%') tbCari ON tbCari.nFirmaID = tbCariHareketi.nFirmaID WHERE (tbCari.Bakiye <> 0) GROUP BY tbCariHareketi.sDovizCinsi1 ORDER BY tbCariHareketi.sDovizCinsi1 DESC"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil) & "( " & dr1("sDovizCinsi1") & " )"
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Bakiye"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_alinan_ugurlu(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '8' AS IND, 'Alınan' AS Baslik, '3.Sahistan Alinan' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lAlacakTutar-tbFirmaHareketi.lBorcTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '902.01.00002%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_verilen_velic(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '9' AS IND, 'Verilen' AS Baslik, '3.Sahisa Verilen' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, - SUM(tbFirmaHareketi.lAlacakTutar-tbFirmaHareketi.lBorcTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '901.01.00001%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_masrafdagilim_sahsi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '9' AS IND, 'Verilen' AS Baslik, 'Şahsi Masraf' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, - SUM(tbFirmaHareketi.lAlacakTutar-tbFirmaHareketi.lBorcTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '771.01.00002%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_fiyatfarklari(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '9' AS IND, 'Kesilen' AS Baslik, 'Fiyat Farkları' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi,  SUM(tbFirmaHareketi.lBorcTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.sCariIslem='FF') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_firma_personelleri(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '9' AS IND, 'Kesilen' AS Baslik, 'Firma Personeli Maaşları' AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, SUM(tbFirmaHareketi.lBorcTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.sCariIslem='PM') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_masraf_dagilim(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '10' AS IND, LOWER(tbFSinif1.sAciklama) + ' Masraf' AS Baslik, LOWER(tbFSinif2.sAciklama) AS Aciklama, COUNT(DISTINCT tbFirma.nFirmaID) AS Sayi, - SUM(tbFirmaHareketi.lAlacakTutar-tbFirmaHareketi.lBorcTutar) AS Tutar FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE (tbFirma.sKodu LIKE '800%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFSinif1.sAciklama, tbFSinif2.sAciklama ORDER BY tbFSinif1.sAciklama, tbFSinif2.sAciklama "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_alisverisyapan(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '11' AS IND, 'Müşteri' AS Baslik, 'AlışVeriş Yapan Müşteri' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(lNetTutar) AS Tutar FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_yeni(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Dim sSaat1 As String = " 00:00:00"
        Dim sSaat2 As String = " 23:59:59"
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '11' AS IND, 'Müşteri' AS Baslik, 'AlışVeriş Yapan Yeni Müşteri' AS Aciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(lNetTutar) AS Tutar FROM tbAlisVeris WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (nMusteriID IN (SELECT nMusteriID FROM tbMusteri WHERE dteKayitTarihi BETWEEN '" & tarih1 & sSaat1 & "' AND '" & tarih2 & sSaat2 & "')) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = dataset1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            dataset1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_hesapkapanan(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '12' AS IND,'Müşteri' as Baslik,'Hesabı Kapanan Müşteri' AS Aciklama,count(DISTINCT nMusteriID) AS Sayi,sum(Tutar) as Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme where dteOdemeTarihi <= '" & tarih2 & "' GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar = 0) AND nMusteriID IN (SELECT DISTINCT tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) GROUP BY nMusteriID , kodu) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_bakiyesiz(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '13' AS IND,'Müşteri' as Baslik,'Hareket Görmüş Bakiyesiz Müşteri' AS Aciklama,count(DISTINCT nMusteriID) AS Sayi,sum(Tutar) as Tutar FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu AS kodu , isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbptemp WHERE (Tutar = 0) AND nMusteriID IN (SELECT DISTINCT nMusteriID FROM         tbAlisVeris) GROUP BY nMusteriID , kodu) GECIKME "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_musteri_kayitli(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '14' AS IND,'Müşteri' as Baslik,'Kayıtlı Müşteri' AS Aciklama,count(DISTINCT nMusteriID) AS Sayi,0 as Tutar FROM tbMusteri WHERE dteKayitTarihi < = '" & tarih2 & "' "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            dr("Not") = tarih2 & " İtibariyle Kayıtlı Müşteri Sayısı"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_cek_odenmis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '16' AS IND, 'Ödemeler' AS Baslik, 'Ödenen Çekler' AS Aciklama, COUNT(tbFirmaHareketi.sEvrakNo) AS Sayi, ISNULL(SUM(tbFirmaHareketi.lAlacakTutar),0) AS Tutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbFirmaHareketi.sHangiUygulama = 'BC') AND (tbFirmaHareketi.lAlacakTutar > 0) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_cek_odenecek(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Dim gun
        Dim ay
        Dim yil
        yil = tarih1.ToString.Substring(8, 2)
        gun = tarih1.ToString.Substring(0, 2)
        ay = tarih2.ToString.Substring(3, 2)
        tarih2 = DateAdd(DateInterval.Month, 1, tarih2)
        tarih1 = DateAdd(DateInterval.Month, 1, tarih1)
        'Try
        '    tarih2 = CType("31/" + CStr((ay + 1)) + "/" + yil, Date)
        'Catch ex As Exception
        '    If ay <> 2 Then
        '        tarih2 = CType("30/" + CStr((ay + 1)) + "/" + yil, Date)
        '    Else
        '        tarih2 = CType("28/" + CStr((ay + 1)) + "/" + yil, Date)
        '    End If
        'End Try
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '2' AS IND, 'Borçlar' AS Baslik, 'Sonraki Ay Ödenecek Çekler' AS Aciklama, COUNT(DISTINCT tbCekSenet.lCekSenetNo) AS Sayi, ISNULL(-SUM(tbCekSenet.lTutar),0) AS Tutar FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu WHERE (tbFirma.sKodu BETWEEN '' AND 'zzzzzzzzzzzzzzz') AND (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenetBordro.nCekSenetIslem = 20) AND (tbCekSenetBordro.dteBordroTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenetBordro.lBordroNo BETWEEN 0 AND 999999999) "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = dr1("Miktar")
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_satis_magazalar_Perakende(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '17' AS IND, 'Satışlar' AS Baslik,sMagaza AS Aciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde, COUNT(DISTINCT nMusteriID) AS Sayi FROM (SELECT tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbAlisVeris.nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbAlisVeris.nMusteriID, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar WHERE dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sMagaza ORDER BY sMagaza "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = dataset1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Miktar") = sorgu_sayi(dr1("Miktar"), 0)
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            dr("Kar") = sorgu_sayi(dr1("Kar"), 0)
            dr("Yuzde") = sorgu_sayi(dr1("Yuzde"), 0)
            dataset1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_satis_magazalar_FS(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '17' AS IND, 'Faturalı Satışlar' AS Baslik, sMagaza AS Aciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde, COUNT(DISTINCT nMusteriID) AS Sayi FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi , tbStokFisiDetayi.sFisTipi , tbStokFisiDetayi.sDepo AS sMagaza , tbStokFisiDetayi.nFirmaID AS nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar , tbSSinif1.sSinifKodu , tbSSinif1.sAciklama , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY sMagaza ORDER BY sMagaza "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Miktar") = sorgu_sayi(dr1("Miktar"), 0)
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            dr("Kar") = sorgu_sayi(dr1("Kar"), 0)
            dr("Yuzde") = sorgu_sayi(dr1("Yuzde"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_satis_magazalar_DC(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '17' AS IND, 'Fişli Satışlar' AS Baslik, sMagaza AS Aciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde, COUNT(DISTINCT nMusteriID) AS Sayi FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi , tbStokFisiDetayi.sFisTipi , tbStokFisiDetayi.sDepo AS sMagaza , tbStokFisiDetayi.nFirmaID AS nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar , tbSSinif1.sSinifKodu , tbSSinif1.sAciklama , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif1 INNER JOIN tbStokSinifi ON tbSSinif1.sSinifKodu = tbStokSinifi.sSinifKodu1 INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'DC')) Satislar WHERE (dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY sMagaza ORDER BY sMagaza "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Miktar") = sorgu_sayi(dr1("Miktar"), 0)
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            dr("Kar") = sorgu_sayi(dr1("Kar"), 0)
            dr("Yuzde") = sorgu_sayi(dr1("Yuzde"), 0)
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_satis_bekleyen(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        ds1 = sorgu(sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '18' AS IND, 'Bekleyen' AS Baslik, 'Bekleyen Ön Ödemeli Satışlar' AS Aciklama, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS Sayi, SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, -SUM((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbDepo ON tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbMusteri.lKodu BETWEEN 0 AND 999999999) AND (tbAlisVeris.dteFaturaTarihi <= '" & tarih2 & "') AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            dr("Miktar") = sorgu_sayi(dr1("Miktar"), 0)
            dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            'dr("Kar") = dr1("Kar")
            'dr1("Yuzde") = dr1("Yuzde")
            dr("Not") = tarih2 & " İtibariyle Bekleyen Ön Ödemeli Satışlar"
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Function dataload_tbMusteri_YenilerKontrol(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As String
        Dim kriter
        kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.sMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sEvAdresi1,tbMusteri.sEvTelefonu,tbMusteri.sGSM,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,ISNULL(tbMusteriKefil1.sIsPostaKodu,0) AS lKefil1Kodu, tbMusteriKefil1.sAdi AS sKefil1Adi, tbMusteriKefil1.sSoyadi AS sKefil1Soyadi, CAST(0 AS money) AS lKefil1OdemeTutari, CAST(0 AS money) AS lKefil1OdemeOrtGun, ISNULL(tbMusteriKefil2.sIsPostaKodu,0) AS lKefil2Kodu, tbMusteriKefil2.sAdi AS sKefil2Adi, tbMusteriKefil2.sSoyadi AS sKefil2Soyadi, CAST(0 AS money) AS lKefil2OdemeTutari, CAST(0 AS money) AS lKefil2OdemeOrtGun,CAST(0 AS money) AS lSatisTutari,CAST(0 AS money) AS lKalanBakiye,CAST(0 AS money) AS lKalanTaksitSayisi,tbMusteriSinifi.sSinifKodu1, tbMusteriSinifi.sSinifKodu2, tbMusteriSinifi.sSinifKodu3, tbMusteriSinifi.sSinifKodu4, tbMusteriSinifi.sSinifKodu5 FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID LEFT OUTER JOIN tbMusteriKefil2 ON tbMusteri.nMusteriID = tbMusteriKefil2.nMusteriID LEFT OUTER JOIN tbMusteriKefil1 ON tbMusteri.nMusteriID = tbMusteriKefil1.nMusteriID " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr In ds1.Tables(0).Rows
            Dim ds_taksit_kalan As DataSet
            Dim ds_taksitler As DataSet
            ds_taksit_kalan = sorgu_taksitler_kalanli(dr("nMusteriID"))
            For Each dr1 In ds_taksit_kalan.Tables(0).Rows
                dr("lKalanBakiye") = dr1("KALAN")
            Next
            ds_taksitler = sorgu_taksitler(dr("nMusteriID"))
            Dim ilktaksit As DateTime
            Dim ilktaksittutar As Decimal
            Dim gecikmistaksitsayisi As Int64 = 0
            Dim gecikmistaksittutari As Decimal = 0
            Dim kalantaksitsayisi As Int64 = 0
            Dim sayi As Integer = 0
            For Each dr1 In ds_taksitler.Tables(0).Rows
                sayi += 1
                If sayi = 1 Then
                    ilktaksit = dr1("dteTarihi")
                    ilktaksittutar = dr1("KALAN")
                End If
                If dr1("dteTarihi") <= Today Then
                    gecikmistaksitsayisi += 1
                    gecikmistaksittutari += dr1("KALAN")
                End If
                kalantaksitsayisi += 1
            Next
            dr("lKalanTaksitSayisi") = kalantaksitsayisi
            Dim ds_satislar_detayli As DataSet
            Dim toplammiktar As Decimal = 0
            Dim toplamsatistutari As Decimal = 0
            Dim toplampesinattutari As Decimal = 0
            Dim iademiktar As Decimal = 0
            Dim iadetutari As Decimal = 0
            Dim satissayisi As Int64 = 0
            Dim satismiktar As Decimal = 0
            Dim satistutari As Decimal = 0
            Dim iadesayisi As Int64 = 0
            Dim sonsatistutari As Decimal = 0
            Dim sonsatistarihi As DateTime
            sayi = 0
            ds_satislar_detayli = sorgu_satislar_detayli(dr("nMusteriID"))
            For Each dr1 In ds_satislar_detayli.Tables(0).Rows
                If dr1("nGirisCikis") = 3 Then
                    satismiktar += dr1("lToplamMiktar")
                    satistutari += dr1("lNetTutar")
                    toplampesinattutari = dr1("lPesinat")
                    satissayisi += 1
                    sayi += 1
                    If sayi = 1 Then
                        sonsatistutari += dr1("lNetTutar")
                        sonsatistarihi = dr1("dteFaturaTarihi")
                    End If
                ElseIf dr1("nGirisCikis") = 4 Then
                    iademiktar += Math.Abs(dr1("lToplamMiktar"))
                    iadetutari += Math.Abs(dr1("lNetTutar"))
                    iadesayisi += 1
                End If
                toplammiktar += dr1("lToplamMiktar")
                toplamsatistutari += dr1("lNetTutar")
            Next
            dr("lSatisTutari") = satistutari
            If dr("lKefil1Kodu") <> "" And IsNumeric(dr("lKefil1Kodu")) = True Then
                dr("lKefil1OdemeTutari") = sorgu_tahsilatlar_toplam(dr("lKefil1Kodu"))
                dr("lKefil1OdemeOrtGun") = sorgu_tahsilatlar_ort(dr("lKefil1Kodu"))
            End If
            If dr("lKefil2Kodu") <> "" And IsNumeric(dr("lKefil2Kodu")) = True Then
                dr("lKefil2OdemeTutari") = sorgu_tahsilatlar_toplam(dr("lKefil2Kodu"))
                dr("lKefil2OdemeOrtGun") = sorgu_tahsilatlar_ort(dr("lKefil2Kodu"))
            End If
        Next
        'Başlık
        Dim s As String = ""
        Dim kayit As Integer = 0
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & tarih1 & " ve " & tarih2 & " Tarihleri Arasında Yeni Açılan Müşteriler</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Mağaza</th>"
        s += "<th class=""cs67572338"">Kodu</th>"
        s += "<th class=""cs67572338"">Adı</th>"
        s += "<th class=""cs67572338"">Soyadı</th>"
        s += "<th class=""cs67572338"">EvAdresi</th>"
        s += "<th class=""cs67572338"">EvTelefonu</th>"
        s += "<th class=""cs67572338"">Gsm</th>"
        s += "<th class=""cs67572338"">Kefil1Adı</th>"
        s += "<th class=""cs67572338"">Kefil1Soyadı</th>"
        s += "<th class=""cs67572338"">1.KefilÖdemeTutarı</th>"
        s += "<th class=""cs67572338"">1.KefilÖdemeOrt.</th>"
        s += "<th class=""cs67572338"">SatışTutarı</th>"
        s += "<th class=""cs67572338"">KalanBakiye</th>"
        s += "<th class=""cs67572338"">Taksit</th>"
        s += "<th class=""cs67572338"">Sözleşme</th>"
        s += "<th class=""cs67572338"">Not</th>"
        kayit = 0
        Dim lSatisTutari As Decimal = 0
        Dim lKalanBakiye As Decimal = 0
        ProgressBar2.Properties.Maximum = ds1.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds1.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sMagaza") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAdi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sSoyadi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sEvAdresi1") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sEvTelefonu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sGSM") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKefil1Adi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKefil1Soyadi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lKefil1OdemeTutari"), "#,#.##") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lKefil1OdemeOrtGun"), "#,#") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lSatisTutari"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lKalanBakiye"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lKalanTaksitSayisi"), "#,0.") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("SOZLESME") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("ISTIHBARAT") & "</td>"
            s += "</tr>"
            kayit += 1
            lSatisTutari += dr("lSatisTutari")
            lKalanBakiye += dr("lKalanBakiye")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lSatisTutari, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lKalanBakiye, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_tbFirma_Yeniler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As String
        Dim kriter As String = ""
        kriter = " Where tbFirma.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        ds1 = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.*,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sSinifKodu AS SINIF1, tbFSinif2.sSinifKodu AS SINIF2, tbFSinif3.sSinifKodu AS SINIF3, tbFSinif4.sSinifKodu AS SINIF4, tbFSinif5.sSinifKodu AS SINIF5,(SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu"))
        Dim dr As DataRow

        'Başlık
        Dim s As String = ""
        Dim kayit As Integer = 0
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & tarih1 & " ve " & tarih2 & " Tarihleri Arasında Yeni Açılan Hesaplar</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">HesapKodu</th>"
        s += "<th class=""cs67572338"">HesapAdı</th>"
        s += "<th class=""cs67572338"">VergiDairesi</th>"
        s += "<th class=""cs67572338"">VergiNo</th>"
        s += "<th class=""cs67572338"">Adres1</th>"
        s += "<th class=""cs67572338"">Adres2</th>"
        s += "<th class=""cs67572338"">KrediLimiti</th>"
        s += "<th class=""cs67572338"">İl</th>"
        s += "<th class=""cs67572338"">Semt</th>"
        s += "<th class=""cs67572338"">Sını1</th>"
        s += "<th class=""cs67572338"">Sını2</th>"
        s += "<th class=""cs67572338"">Bakiye</th>"
        s += "<th class=""cs67572338"">Not</th>"
        kayit = 0
        Dim lBakiye As Decimal = 0
        ProgressBar2.Properties.Maximum = ds1.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds1.Tables(0).Rows
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sVergiDairesi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sVergiNo") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAdres1") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAdres2") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("lKrediLimiti") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sIl") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sSemt") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("SINIF1") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("SINIF2") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("lBakiye"), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("ISTIHBARAT") & "</td>"

            s += "</tr>"
            kayit += 1
            lBakiye += dr("lBakiye")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lBakiye, "#,0.00") & "</td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_tbStok_Yeniler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As String
        Dim kriter As String = ""
        kriter = "WHERE tbStok.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' and tbStok.nStokTipi < 5 "
        ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*,(Select sRenkAdi from tbRenk Where sRenk = tbStok.sRenk) as sRenkAdi,'' as sCheckDigit,lEN(tbStok.sAciklama) nAciklamaUzunluk, tbStok.sModel as Model,tbStokBarkodu.sBarkod, tbSSinif1.sSinifKodu AS Sinif1, tbSSinif2.sSinifKodu AS Sinif2, tbSSinif3.sSinifKodu AS Sinif3, tbSSinif4.sSinifKodu AS Sinif4, tbSSinif5.sSinifKodu AS Sinif5, tbSSinif6.sSinifKodu AS Sinif6, tbSSinif7.sSinifKodu AS Sinif7, tbSSinif8.sSinifKodu AS Sinif8, tbSSinif9.sSinifKodu AS Sinif9, tbSSinif10.sSinifKodu AS Sinif10, tbSSinif11.sSinifKodu AS Sinif11, tbSSinif12.sSinifKodu AS Sinif12, tbSSinif13.sSinifKodu AS Sinif13, tbSSinif14.sSinifKodu AS Sinif14, tbSSinif15.sSinifKodu AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat2 & "') AS FIYAT2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat3 & "') AS FIYAT3,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat4 & "') AS FIYAT4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyatA & "') AS ALIS,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyatM & "') AS MALIYET,CAST(0 as Money) as ORAN1,CAST(0 as Money) as ORAN2,CAST(0 as Money) as ORAN3,CAST(0 as Money) as ORAN4  FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim= 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu"))
        Dim dr As DataRow
        'Başlık
        Dim s As String = ""
        Dim kayit As Integer = 0
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & tarih1 & " ve " & tarih2 & " Tarihleri Arasında Yeni Açılan Stoklar</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">KayıtTarihi</th>"
        s += "<th class=""cs67572338"">StokKodu</th>"
        s += "<th class=""cs67572338"">StokAdı</th>"
        s += "<th class=""cs67572338"">Renk</th>"
        s += "<th class=""cs67572338"">Beden</th>"
        s += "<th class=""cs67572338"">Kavala</th>"
        s += "<th class=""cs67572338"">Kdv</th>"
        s += "<th class=""cs67572338"">Mevcut</th>"
        s += "<th class=""cs67572338"">Fiyat1</th>"
        s += "<th class=""cs67572338"">Oran1</th>"
        s += "<th class=""cs67572338"">Fiyat2</th>"
        s += "<th class=""cs67572338"">Oran2</th>"
        s += "<th class=""cs67572338"">Fiyat3</th>"
        s += "<th class=""cs67572338"">Oran3</th>"
        s += "<th class=""cs67572338"">Alış</th>"
        s += "<th class=""cs67572338"">Maliyet</th>"
        kayit = 0
        Dim lMevcut As Decimal = 0
        ProgressBar2.Properties.Maximum = ds1.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds1.Tables(0).Rows
            Try
                If dr("FIYAT1") <> 0 Then
                    dr("ORAN1") = ((dr("FIYAT1") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("FIYAT2") <> 0 Then
                    dr("ORAN2") = ((dr("FIYAT2") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("FIYAT3") <> 0 Then
                    dr("ORAN3") = ((dr("FIYAT3") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("FIYAT4") <> 0 Then
                    dr("ORAN4") = ((dr("FIYAT4") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("dteKayitTarihi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKodu") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sAciklama") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sRenkAdi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sBeden") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKavala") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("sKdvTipi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & Format(dr("Mevcut"), "#,0.###") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("FIYAT1"), 0), "#,0.00#") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">%" & Format(sorgu_sayi(dr("ORAN1"), 0), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("FIYAT2"), 0), "#,0.00#") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">%" & Format(sorgu_sayi(dr("ORAN2"), 0), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("FIYAT3"), 0), "#,0.00#") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">%" & Format(sorgu_sayi(dr("ORAN3"), 0), "#,0.00") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("ALIS"), 0), "#,0.00#") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & Format(sorgu_sayi(dr("MALIYET"), 0), "#,0.00#") & "</td>"
            s += "</tr>"
            kayit += 1
            lMevcut += dr("Mevcut")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lMevcut, "#,0.###") & "</td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Private Function dataload_tbAjanda(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal personelno As Int64) As String

        ds1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY Select *,Cast ('1' as bit) as Eski From aEmirAjanda Where Tamamlandi=0 And StartTime < '" & tarih1 & "'  AND PersonelNo =" & personelno & "   UNION ALL Select *,Cast ('0' as bit) as Eski From aEmirAjanda WHERE StartTime between '" & tarih1 & " 00:00:00' and '" & tarih2 & " 23:59:59'   AND PersonelNo =" & personelno & "  AND Tamamlandi =0  "))
        Dim dr As DataRow
        'Başlık
        Dim s As String = ""
        Dim kayit As Integer = 0
        s = "<html><head><title>Business Gönderi</title><meta HTTP-EQUIV='Content-Type' CONTENT='text/html; charset=utf-8'><style type=""text/css"">.cs67572338 {color:#000000;background-color:#F0F0F0;border-left:#808080 1px solid;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;}.csB5C7FF62 {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right:#808080 1px solid;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csB8A76CBF {color:#000000;background-color:#F0F0F0;border-left-style: none;border-top:#808080 1px solid;border-right-style: none;border-bottom:#808080 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; }.csC7F87CB9 {color:#000000;background-color:#FFFFFF;border-left:#A0A0A0 1px solid;border-top:#A0A0A0 1px solid;border-right:#A0A0A0 1px solid;border-bottom:#A0A0A0 1px solid;font-family:Tahoma; font-size:11px; font-weight:normal; font-style:normal; padding-left:2px;padding-right:1px;}.csF7D3565D {height:0px;width:0px;overflow:hidden;font-size:0px;line-height:0px;}</style></head><body>"
        s += "<table border=""2"">"
        s += "</tr>"
        s += "<th colspan=""9"" align=""center"" bgcolor=""black""><b><i><font size=""+2"" color=""white"">" & tarih2 & " itirabiyle Yapılacak İşler</b></i></font></th>"
        s += "</tr>"
        s += "<th class=""cs67572338"">Konu</th>"
        s += "<th class=""cs67572338"">Yer</th>"
        s += "<th class=""cs67572338"">Hesap</th>"
        s += "<th class=""cs67572338"">Açıklama</th>"
        s += "<th class=""cs67572338"">Başlama</th>"
        s += "<th class=""cs67572338"">Bitiş</th>"
        s += "<th class=""cs67572338"">Tutar</th>"
        s += "<th class=""cs67572338"">Pb</th>"
        s += "<th class=""cs67572338"">Ödendi?</th>"
        s += "<th class=""cs67572338"">Gelecekmi?</th>"
        s += "<th class=""cs67572338"">Tamamlandimi?</th>"

        kayit = 0
        Dim lMevcut As Decimal = 0
        ProgressBar2.Properties.Maximum = ds1.Tables(0).Rows.Count
        ProgressBar2.EditValue = 0
        For Each dr In ds1.Tables(0).Rows

            'Hareketler
            s += "</tr>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Subject") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:120px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Location") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Firma") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Description") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("StartTime") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:100px;height:18px;text-align:left;vertical-align:middle;"">" & dr("EndTime") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:70px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Tutar") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Pb") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:50px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Odendi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">%" & dr("Gelecekmi") & "</td>"
            s += "<td class=""csC7F87CB9"" style=""width:60px;height:18px;text-align:left;vertical-align:middle;"">" & dr("Tamamlandi") & "</td>"

            s += "</tr>"
            kayit += 1
            lMevcut += dr("Tutar")
            ProgressBar2.EditValue += 1
            ProgressBar2.Refresh()
        Next
        'Toplam
        s += "</tr>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:left;vertical-align:middle;"">" & Format(kayit, "#,0") & " Kayıt</td>"
        s += "<td class=""cs67572338"" style=""width:120px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:80px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:100px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;"">" & Format(lMevcut, "#,0.###") & "</td>"
        s += "<td class=""cs67572338"" style=""width:70px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:50px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"
        s += "<td class=""cs67572338"" style=""width:60px;height:18px;text-align:right;vertical-align:middle;""></td>"

        s += "</tr>"
        s += "</br>"
        s += "</table></body></html>"
        Return s
    End Function
    Public Function sorgu_taksitler(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT  ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , tbTaksit.dteTarihi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY  tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_taksitler_kalanli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_satislar_detayli(ByVal musterino As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi, dteFaturaTarihi, nGirisCikis, lToplamMiktar, lNetTutar,lPesinat  FROM         tbAlisVeris  WHERE     (nMusteriID = " & musterino & ") ORDER BY dteFaturaTarihi DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_tahsilatlar_toplam(ByVal musterino As Int64) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(tbOdeme.lOdemeTutar),0) AS TAHSILAT, tbAlisVeris.nMusteriID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbMusteri.lKodu = " & musterino & ") AND (tbOdeme.nOdemeKodu = 2) GROUP BY tbAlisVeris.nMusteriID")
        conn.Open()
        Dim lTahsilat As Decimal = cmd.ExecuteScalar
        conn.Close()
        Return lTahsilat
    End Function
    Public Function sorgu_tahsilatlar_ort(ByVal musterino As Int64) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(AVG(GECIKME),0) AS lOrtGecikme FROM (SELECT ROUND(CAST(CAST(tbOdeme.dteOdemeTarihi AS INT) - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT) , 0) AS GECIKME FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbTaksit ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE (tbMusteri.lKodu = " & musterino & ") AND (tbOdeme.nOdemeKodu = 2)) t")
        conn.Open()
        Dim lTahsilat As Decimal = cmd.ExecuteScalar
        conn.Close()
        Return lTahsilat
    End Function
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        ProgressBar1.Properties.Maximum = 20
        ProgressBar1.EditValue = 0
        ProgressBar2.EditValue = 0
        ProgressBar2.Refresh()
        hazirla()
        ProgressBar1.EditValue = 0
        ProgressBar1.Refresh()
        ProgressBar2.EditValue = 0
        ProgressBar2.Refresh()
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Sub hazirla()
        txt_sMesaj.Text = ""
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim tarih1 As DateTime = DateEdit1.Value
        Dim tarih2 As DateTime = DateEdit2.Value
        Dim sMagaza As String = "[Tümü]"
        Dim sSubeMagaza As String = "001"
        Dim kasatipi As String = "Kasiyer:"
        Dim kasiyer As String = "[Tümü]"
        Dim harekettipi As String = "[Tümü]"
        Dim fistipi As String = "[Tümü]"
        Dim saat1 As String = "00:00:00"
        Dim saat2 As String = "00:00:00"
        Dim s As String = ""
        txt_sMesaj.HtmlText = ""
        txt_sMesaj1.Text = ""
        If sec_sIslem.Items.Item(0).CheckState = CheckState.Checked Then
            'Satışların Mağazalara Dağılımı
            Label2.Text = "Satışların Mağazalara Dağılımı Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_satis(tarih1, tarih2, "")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            'Tahsilatların Mağazalara Dağılımı
            Label2.Text = "Tahsilatların Mağazalara Dağılımı Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tahsilat(tarih1, tarih2, "")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            'Satışların Sınıflara Dağılımı
            Label2.Text = "Satışların Sınıflara Dağılımı Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_satis_sinif(tarih1, tarih2, "")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            'Satışların Satıcılara Dağılımı
            Label2.Text = "Satışların Satıcılara Dağılımı Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_satis_satici(tarih1, tarih2, "")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(1).CheckState = CheckState.Checked Then
            'Kasa Hareketleri ve Bakiye
            Label2.Text = "Nakit Kasa İşlemleri ve Kalan Bakiye Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbNakitKasa(sSubeMagaza, tarih1, tarih2, False)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            s = dataload_tbYekun(sSubeMagaza, tarih1, tarih2, False)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            s = dataload_tbNakitKasaToplamlari(tarih1, tarih2)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(2).CheckState = CheckState.Checked Then
            'Banka Hareketleri ve Bakiye
            Label2.Text = "Banka Hareketleri ve Kalan Bakiye Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbFirmaHareketleri("102", tarih1, tarih2, False, 0, "", True, False)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            s = dataload_tbBankaBakiye()
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        If sec_sIslem.Items.Item(21).CheckState = CheckState.Checked Then
            'Banka Hareketleri ve Bakiye
            Label2.Text = "Kasa Teslimatları Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbMarketKasaTeslimat(tarih1, tarih2)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(3).CheckState = CheckState.Checked Then
            'Kasa Kasiyer Raporu
            Label2.Text = "Kasa/Kasiyer Raporu Hazırlanıyor..."
            Label2.Refresh()
            Dim sSorgu As String = ""
            sSorgu = sorgu_query("Select '' Sınıf,'' Aciklama,'' MIKTAR,'' IZAHAT,'' col1,'' col2,'' col3,'' col4,'' col5,'' col6,'' col7,'' col8,'' Status")
            dataset1 = sorgu(sSorgu)
            dataload_satislar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, saat1, saat2)
            dataload_Odemeler(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, saat1, saat2)
            dataload_odemesayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
            dataload_yenikayitsayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
            s = KasaKasiyerRaporu()
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(5).CheckState = CheckState.Checked Then
            'Portföydeki Çekler
            Label2.Text = "Porföydeki Çeklerin Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbCekSenet("", "Kodu", "Başlar", "AC", "'1'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sSubeMagaza, "Vade:", True, "Portföydeki Çeklerin Listesi")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(6).CheckState = CheckState.Checked Then
            'Takastaki Çekler
            Label2.Text = "Takastaki Çeklerin Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbCekSenet("", "Kodu", "Başlar", "AC", "'3'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sSubeMagaza, "Vade:", True, "Takastaki Çeklerin Listesi")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(4).CheckState = CheckState.Checked Then
            'Tarihli Ödenecek Çekler
            Label2.Text = "Ödenecek Çeklerin Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbCekSenet("", "Kodu", "Başlar", "BC", "'20'", 0, tarih1, tarih2, 0, 9999999, 0, 9999999, "", "", sSubeMagaza, "Vade:", True, "Ödenecek Çeklerin Listesi")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            ''Ödenecek Çekler
            'Label2.Text = "Ödenecek Çeklerin Listesi Hazırlanıyor..."
            'Label2.Refresh()
            's = dataload_tbCekSenet("", "Kodu", "Başlar", "BC", "'20'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sSubeMagaza, "Vade:", True, "Ödenecek Çeklerin Listesi")
            'txt_sMesaj.HtmlText += s
            'txt_sMesaj1.Text += s
            'Tarihli Ödenecek Senetler
            Label2.Text = "Ödenecek Senetlerin Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbCekSenet("", "Kodu", "Başlar", "BS", "'20'", 0, tarih1, tarih2, 0, 9999999, 0, 9999999, "", "", sSubeMagaza, "Vade:", True, "Ödenecek Senetlerin Listesi")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
            ''Ödenecek Senetler
            'Label2.Text = "Ödenecek Senetlerin Listesi Hazırlanıyor..."
            'Label2.Refresh()
            's = dataload_tbCekSenet("", "Kodu", "Başlar", "BS", "'20'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sSubeMagaza, "Vade:", True, "Ödenecek Senetlerin Listesi")
            'txt_sMesaj.HtmlText += s
            'txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(7).CheckState = CheckState.Checked Then
            'Yapılacak İşler
            Label2.Text = "Yapılacak İşlerin Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbAjanda(tarih1, tarih2, 1)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(8).CheckState = CheckState.Checked Then
            'Çek Senet İşlemleri
            Label2.Text = "İşlem Çek/Senet Hareketlerinin Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = Dataload_tbCekSenetBordro("", "Kodu", "Başlar", "AC", "[Tümü]", 0, tarih1, tarih2, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sSubeMagaza, True, "Yapılan Çek Senet İşlemleri")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(9).CheckState = CheckState.Checked Then
            'Yeni Açılan Müşteriler
            Label2.Text = "Yeni Açılan Müşteri Hesaplarının Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbMusteri_YenilerKontrol(tarih1, tarih2)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(10).CheckState = CheckState.Checked Then
            'Yeni Açılan Firmalar
            Label2.Text = "Yeni Açılan Hesapların Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbFirma_Yeniler(tarih1, tarih2)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(11).CheckState = CheckState.Checked Then
            'Yeni Açılan Stoklar
            Label2.Text = "Yeni Açılan Stok Kartlarının Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbStok_Yeniler(tarih1, tarih2)
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(12).CheckState = CheckState.Checked Then
            'Eksiye Düşen Stoklar
            Label2.Text = "Eksiye Düşen Stokların Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = Dataload_StokListesiEksiyeDusenler("", "Kod", "Başlar", tarih2, "Eksiler", "[Tümü]")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(13).CheckState = CheckState.Checked Then
            'Alış Faturaları
            Label2.Text = "Alış Faturalarının Kontrol Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbFisler("", "Adı", "Başlar", "FA", 1, tarih1, tarih2, 0, 999999999, -999999999, 999999999, "[Tümü]", "", "", "Alış Faturaları")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(14).CheckState = CheckState.Checked Then
            'Satış Faturaları
            Label2.Text = "Satış Faturalarının Kontrol Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbFisler("", "Adı", "Başlar", "FS", 3, tarih1, tarih2, 0, 999999999, -999999999, 999999999, "[Tümü]", "", "", "Satış Faturaları")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(15).CheckState = CheckState.Checked Then
            'Teslimatlar
            Label2.Text = "Yapılan Teslimetların Kontrol Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbFisler("", "Adı", "Başlar", "PF", 3, tarih1, tarih2, 0, 999999999, -999999999, 999999999, "[Tümü]", "", "", "Teslimatlar")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(16).CheckState = CheckState.Checked Then
            'Transfer Fişleri
            Label2.Text = "Transfer Fişlerinin Listesi Hazırlanıyor..."
            Label2.Refresh()
            s = dataload_tbFisler("", "Adı", "Başlar", "T", 3, tarih1, tarih2, 0, 999999999, -999999999, 999999999, "[Tümü]", "", "", "Transferler")
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(18).CheckState = CheckState.Checked Then
            'Gelir Tablosu
            Label2.Text = "Gelir Tablosu Hazırlanıyor..."
            Label2.Refresh()
            Dim sSorgu As String = ""
            sSorgu = sorgu_query("Select '' IND,'' Baslik,'' Aciklama,'' Miktar,'' Tutar,'' Sayi,'' Kar,'' Yuzde,'' [Not],'' [Status],'' [sMagaza],'' [sSinif1],'' [sSinif2]")
            dataset1 = sorgu(sSorgu)
            dataload_satis_magazalar(tarih1, tarih2, False, False)
            dataload_masraf_dagilim(tarih1, tarih2, False)
            s = GelirTablosu()
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        If sec_sIslem.Items.Item(18).CheckState = CheckState.Checked Then
            'Durum Tablosu
            Label2.Text = "Durum Tablosu Hazırlanıyor..."
            Label2.Refresh()
            Dim sSorgu As String = ""
            sSorgu = sorgu_query("Select '' IND,'' Baslik,'' Aciklama,'' Miktar,'' Tutar,'' Sayi,'' Kar,'' Yuzde,'' [Not],'' [Status],'' [sMagaza],'' [sSinif1],'' [sSinif2]")
            dataset1 = sorgu(sSorgu)
            Label2.Text = "Envanter Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            dataload_mevcut_mal(tarih1, tarih2)
            Label2.Text = "Açık Hesaplar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_borc_acikhesap(tarih1, tarih2)
            'If sec_bDovizli.Checked = True Then
            '    dataload_borc_acikhesap_tumu(tarih1, tarih2)
            'End If
            'dataload_alacak_acikhesap(tarih1, tarih2)
            'dataload_alacak_acikhesap_tumu(tarih1, tarih2)
            Label2.Text = "Çekler Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_borc_odenecek_cekler(tarih1, tarih2)
            Label2.Text = "Senetler Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_borc_odenecek_senetler(tarih1, tarih2)
            Label2.Text = "Kredi Kartı Hesapları Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_borc_kredikarti(tarih1, tarih2)
            dataload_borc_kredikarti_detay(tarih1, tarih2)
            Label2.Text = tarih2 & " itibariyle Müşteri Bakiyeleri Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_alacak_musteriler(tarih1, tarih2)
            dataload_alacak_acikhesap(tarih1, tarih2)
            'If sec_bDovizli.Checked = True Then
            '    dataload_alacak_acikhesap_tumu(tarih1, tarih2)
            'End If
            Label2.Text = "Kasa Mevcutları Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_mevcut_kasa(tarih1, tarih2)
            Label2.Text = "Banka Mevcutları Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_mevcut_banka(tarih1, tarih2)
            Label2.Text = "Alınan Paralar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_alinan_ugurlu(tarih1, tarih2)
            Label2.Text = "Verilen Paralar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_verilen_velic(tarih1, tarih2)
            Label2.Text = "Yapılan Masraflar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_masraf_dagilim(tarih1, tarih2)
            Label2.Text = "Yapılan Şahsi Masraflar Masraflar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_masrafdagilim_sahsi(tarih1, tarih2)
            Label2.Text = "Kesilen Fiyat Farkları Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_fiyatfarklari(tarih1, tarih2)
            Label2.Text = "Firma Personel Maaş Kesintileri Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_firma_personelleri(tarih1, tarih2)
            Label2.Text = "AlışVerişler Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_musteri_alisverisyapan(tarih1, tarih2)
            Label2.Text = "Yeni Müşteri Kayıtları Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_musteri_yeni(tarih1, tarih2)
            Label2.Text = "Kapanan Hesaplar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_musteri_hesapkapanan(tarih1, tarih2)
            Label2.Text = "Tüm Hesaplar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_alacak_musteriler_Tumu(tarih1, tarih2)
            Label2.Text = "Bakiyesiz Hesaplar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_musteri_bakiyesiz(tarih1, tarih2)
            Label2.Text = "Kayıtlı Hesaplar Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_musteri_kayitli(tarih1, tarih2)
            Label2.Text = "Çek Ödemeleri Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_cek_odenmis(tarih1, tarih2)
            dataload_cek_odenecek(tarih1, tarih2)
            Label2.Text = "Mağaza Satışları Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_satis_magazalar_Perakende(tarih1, tarih2)
            'If sec_FS.Checked = True Then
            '    dataload_satis_magazalar_FS(tarih1, tarih2)
            'End If
            'If sec_DC.Checked = True Then
            '    dataload_satis_magazalar_DC(tarih1, tarih2)
            'End If
            Label2.Text = "Bekleyen Alışverişler Kontrol Ediliyor, Lütfen Bekleyiniz..."
            Label2.Refresh()
            dataload_satis_bekleyen(tarih1, tarih2)
            s = DurumTablosu()
            txt_sMesaj.HtmlText += s
            txt_sMesaj1.Text += s
        End If
        ProgressBar1.EditValue += 1
        ProgressBar1.Refresh()
        txt_sKonu.Text = tarih1 & " ve " & tarih2 & " Tarihleri Arasındaki Bilgilendirme Raporu"
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        If Form1.otoMailKontrol = True Then
            Timer1.Enabled = False
            mail_gonder()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        sec_sIslem.CheckAll()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        sec_sIslem.UnCheckAll()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
    End Sub
    Private timer1S As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If timer1S = 0 Then
            Me.Close()
            Timer1.Enabled = False
        ElseIf timer1S = 895 Then
            timer1S -= 1
            hazirla()
        Else
            timer1S -= 1
        End If
    End Sub
    Private Sub frm_Gonderi_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.otoMailDakika = Int(Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoMail").GetValue("zaman")) * 60
        Form1.otoMailKontrol = False
    End Sub
End Class