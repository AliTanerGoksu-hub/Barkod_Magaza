Imports System.Net
Imports System.Text
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_Perakende_SMS_Gonder
    Public firmano As Integer
    Public donemno As Integer
    Public connection As String
    Public kullanici As String
    Public GSMSMS As String
    Dim loaded As Boolean = False
    Dim sSmsKullaniciAdi As String = ""
    Dim sSmsKullaniciSifre As String = ""
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        sorgula_bakiye()
    End Sub
    Private Sub sorgula_bakiye()
        txt_sOperator.Text = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainReportRoot><UserName>" & txt_sKullanici.Text & "-" & txt_sBayiiKodu.Text & "</UserName><PassWord>" & txt_sSifre.Text & "</PassWord><Action>4</Action></MainReportRoot>")
        txt_sOperator.Text = Replace(txt_sOperator.Text, vbLf, vbCrLf)
    End Sub
    Private Function HTTPPoster(ByVal prmPostAddress As String, ByVal prmSendData As String) As String
        Try
            Dim wUpload As WebClient = New System.Net.WebClient
            Dim bPostArray As Byte() = Encoding.ASCII.GetBytes(prmSendData)
            Dim bResponse As Byte() = wUpload.UploadData(prmPostAddress, "POST", bPostArray)
            Dim sWebPage As String = Encoding.ASCII.GetChars(bResponse)
            HTTPPoster = sWebPage
        Catch ex As Exception
            HTTPPoster = ""
        End Try
    End Function
    Private Function gonderiKontrol(ByVal nMusteriID As String) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim kayitsayisi As Integer = 0
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) FROM tbSMSDetayi WHERE nMusteriID = " & nMusteriID & " AND dteGonderimTarihi >= '" & (Now.Day - 1) & "." & Now.Month & "." & Now.Year & "'")
        kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            Return True
        Else
            Return False
        End If
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
    End Function
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show("SMS Gönderme İşlemine Başlamak İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim sayi As Integer = 0
            'Dim sMessage As String = ""
            If Trim(txt_sGsmNolari.Text) = "" Then
                Dim dr As DataRow
                Bar1.Properties.Maximum = DataSet1.Tables(0).Rows.Count
                Bar1.Position = 0
                Dim toplamsayi As Int64 = DataSet1.Tables(0).Rows.Count
                Dim nSatir As Int64 = 0
                Dim sTelefonlar As String = ""
                Dim sMessage As String = ""
                Dim s As String
                Dim sSMSID As String = Now.Minute + Now.Second + Now.Millisecond
                If toplamsayi > 1000 Then
                    If txt_sMessage.Text.Contains("[") = True Then
                        s = ""
                        For Each dr In DataSet1.Tables(0).Rows
                            Try
                                'If gonderiKontrol(dr("nMusteriID").ToString()) = True Then
                                sMessage = txt_sMessage.Text
                                sMessage = Replace(sMessage, "[adi]", Trim(dr("sAdi")))
                                sMessage = Replace(sMessage, "[soyadi]", Trim(dr("sSoyadi")))
                                sMessage = Replace(sMessage, "[musteri]", Trim(dr("sAdi") + " " + dr("sSoyadi")))
                                sMessage = Replace(sMessage, "[bakiye]", FormatNumber(dr("lBakiye"), 2))
                                sMessage = Replace(sMessage, "'", "")
                                'Replace(sMessage, "*", "")
                                sMessage = Replace(sMessage, "ı", "i")
                                sMessage = Replace(sMessage, "İ", "I")
                                sMessage = Replace(sMessage, "ş", "s")
                                sMessage = Replace(sMessage, "Ş", "S")
                                sMessage = Replace(sMessage, "ç", "c")
                                sMessage = Replace(sMessage, "Ç", "C")
                                sMessage = Replace(sMessage, "ğ", "g")
                                sMessage = Replace(sMessage, "Ğ", "G")
                                sMessage = Replace(sMessage, "ü", "u")
                                sMessage = Replace(sMessage, "Ü", "U")
                                sMessage = Replace(sMessage, "ö", "o")
                                sMessage = Replace(sMessage, "Ö", "O")
                                sMessage = Replace(sMessage, """", "")
                                dr("nIslemID") = tbSmsDetayi_Kaydet_yeni(0, sSMSID, DateEdit1.EditValue, sMessage.ToString, dr("nMusteriID"), dr("sTelefon").ToString, DateEdit1.EditValue, 0)
                                s += "<Message><Mesgbody>" & sMessage & "</Mesgbody><Number>" & 0 & dr("sTelefon") & "</Number></Message>"
                                nSatir += 1
                                sayi += 1
                                If nSatir = 5000 Then
                                    nSatir = 0
                                    Dim deger As String = mesajlar_gonder(s)
                                    tbSmsDetaylari_kaydet_duzelt(sSMSID, Replace(deger, "ID: ", "").ToString, DateEdit1.EditValue)
                                    sSMSID = Now.Minute + Now.Second + Now.Millisecond
                                    s = ""
                                End If
                                'End If
                            Catch ex As Exception
                            End Try
                        Next
                        If s = "" Then
                        Else
                            Dim deger As String = mesajlar_gonder(s)
                            tbSmsDetaylari_kaydet_duzelt(sSMSID, Replace(deger, "ID: ", "").ToString, DateEdit1.EditValue)
                            sSMSID = Now.Minute + Now.Second + Now.Millisecond
                        End If
                    Else
                        sTelefonlar = ""
                        For Each dr In DataSet1.Tables(0).Rows
                            Try
                                'If gonderiKontrol(dr("nMusteriID").ToString()) = True Then
                                sMessage = txt_sMessage.Text
                                sMessage = Replace(sMessage, "[adi]", Trim(dr("sAdi")))
                                sMessage = Replace(sMessage, "[soyadi]", Trim(dr("sSoyadi")))
                                sMessage = Replace(sMessage, "[musteri]", Trim(dr("sAdi") + " " + dr("sSoyadi")))
                                sMessage = Replace(sMessage, "[bakiye]", FormatNumber(dr("lBakiye"), 2))
                                sMessage = Replace(sMessage, "'", "")
                                'Replace(sMessage, "*", "")
                                sMessage = Replace(sMessage, "ı", "i")
                                sMessage = Replace(sMessage, "İ", "I")
                                sMessage = Replace(sMessage, "ş", "s")
                                sMessage = Replace(sMessage, "Ş", "S")
                                sMessage = Replace(sMessage, "ç", "c")
                                sMessage = Replace(sMessage, "Ç", "C")
                                sMessage = Replace(sMessage, "ğ", "g")
                                sMessage = Replace(sMessage, "Ğ", "G")
                                sMessage = Replace(sMessage, "ü", "u")
                                sMessage = Replace(sMessage, "Ü", "U")
                                sMessage = Replace(sMessage, "ö", "o")
                                sMessage = Replace(sMessage, "Ö", "O")
                                sMessage = Replace(sMessage, """", "")
                                dr("nIslemID") = tbSmsDetayi_Kaydet_yeni(0, sSMSID, DateEdit1.EditValue, sMessage.ToString, dr("nMusteriID"), dr("sTelefon").ToString, DateEdit1.EditValue, 0)
                                sTelefonlar += 0 & dr("sTelefon") & ","
                                nSatir += 1
                                sayi += 1
                                If nSatir = 5000 Then
                                    nSatir = 0
                                    mesaj_gonder(sMessage, sTelefonlar)
                                    sTelefonlar = ""
                                End If
                                'End If
                            Catch ex As Exception
                            End Try
                        Next
                        If sTelefonlar = "" Then
                        Else
                            mesaj_gonder(sMessage, sTelefonlar)
                        End If
                    End If
                Else
                    For Each dr In DataSet1.Tables(0).Rows
                        Try
                            sMessage = txt_sMessage.Text
                            sMessage = Replace(sMessage, "[adi]", Trim(dr("sAdi")))
                            sMessage = Replace(sMessage, "[soyadi]", Trim(dr("sSoyadi")))
                            sMessage = Replace(sMessage, "[musteri]", Trim(dr("sAdi") + " " + dr("sSoyadi")))
                            sMessage = Replace(sMessage, "[bakiye]", FormatNumber(dr("lBakiye"), 2))
                            sMessage = Replace(sMessage, "'", "")
                            'Replace(sMessage, "*", "")
                            sMessage = Replace(sMessage, "ı", "i")
                            sMessage = Replace(sMessage, "İ", "I")
                            sMessage = Replace(sMessage, "ş", "s")
                            sMessage = Replace(sMessage, "Ş", "S")
                            sMessage = Replace(sMessage, "ç", "c")
                            sMessage = Replace(sMessage, "Ç", "C")
                            sMessage = Replace(sMessage, "ğ", "g")
                            sMessage = Replace(sMessage, "Ğ", "G")
                            sMessage = Replace(sMessage, "ü", "u")
                            sMessage = Replace(sMessage, "Ü", "U")
                            sMessage = Replace(sMessage, "ö", "o")
                            sMessage = Replace(sMessage, "Ö", "O")
                            sMessage = Replace(sMessage, """", "")
                            Dim deger As String = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainmsgBody><UserName>" & txt_sKullanici.Text & "-" & txt_sBayiiKodu.Text & "</UserName><PassWord>" & txt_sSifre.Text & "</PassWord><Action>0</Action><Mesgbody>" & Trim(sMessage) & "</Mesgbody><Numbers>0" & dr("sTelefon") & "</Numbers><Originator></Originator><SDate></SDate></MainmsgBody>")
                            dr("sSMSID") = Replace(deger, "ID: ", "").ToString
                            dr("sMesaj") = sMessage
                            dr("nIslemID") = tbSmsDetayi_Kaydet_yeni(0, dr("sSMSID").ToString, DateEdit1.EditValue, sMessage.ToString, dr("nMusteriID"), dr("sTelefon").ToString, DateEdit1.EditValue, 0)
                            Bar1.Position += 1
                            Bar1.Refresh()
                            sayi += 1
                        Catch ex As Exception
                        End Try
                    Next
                End If
                'DataSet1.Clear()
            Else
                Dim sTelefon As String = ""
                Dim str As String
                Dim strArr() As String
                Dim count As Integer
                str = txt_sGsmNolari.Text
                strArr = str.Split(",")
                For count = 0 To strArr.Length - 1
                    sTelefon = Trim(strArr(count))
                    Dim sMessage As String = txt_sMessage.Text
                    sMessage = Replace(sMessage, "'", "")
                    'Replace(sMessage, "*", "")
                    sMessage = Replace(sMessage, "ı", "i")
                    sMessage = Replace(sMessage, "İ", "I")
                    sMessage = Replace(sMessage, "ş", "s")
                    sMessage = Replace(sMessage, "Ş", "S")
                    sMessage = Replace(sMessage, "ç", "c")
                    sMessage = Replace(sMessage, "Ç", "C")
                    sMessage = Replace(sMessage, "ğ", "g")
                    sMessage = Replace(sMessage, "Ğ", "G")
                    sMessage = Replace(sMessage, "ü", "u")
                    sMessage = Replace(sMessage, "Ü", "U")
                    sMessage = Replace(sMessage, "ö", "o")
                    sMessage = Replace(sMessage, "Ö", "O")
                    sMessage = Replace(sMessage, """", "")
                    Dim deger As String = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainmsgBody><UserName>" & txt_sKullanici.Text & "-" & txt_sBayiiKodu.Text & "</UserName><PassWord>" & txt_sSifre.Text & "</PassWord><Action>0</Action><Mesgbody>" & Trim(sMessage) & "</Mesgbody><Numbers>" & sTelefon & "</Numbers><Originator></Originator><SDate></SDate></MainmsgBody>")
                    deger = Replace(deger, "ID: ", "")
                    tbSmsDetayi_Kaydet_yeni(0, deger, DateEdit1.EditValue, sMessage, 0, sTelefon, DateEdit1.EditValue, 0)
                    sayi += 1
                Next
            End If
            XtraMessageBox.Show("Gönderilen SMS Sayısı: " & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            sorgula_bakiye()
        End If
    End Sub
    Private Function mesaj_gonder(ByVal sMessage As String, ByVal sTelefon As String) As String
        Dim deger As String = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainmsgBody><UserName>" & txt_sKullanici.Text & "-" & txt_sBayiiKodu.Text & "</UserName><PassWord>" & txt_sSifre.Text & "</PassWord><Action>0</Action><Mesgbody>" & Trim(sMessage) & "</Mesgbody><Numbers>" & sTelefon & "</Numbers><Originator></Originator><SDate></SDate></MainmsgBody>")
        Return deger
    End Function
    Private Function mesajlar_gonder(ByVal sMessages As String) As String
        Dim deger As String = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainmsgBody><UserName>" & txt_sKullanici.Text & "-" & txt_sBayiiKodu.Text & "</UserName><PassWord>" & txt_sSifre.Text & "</PassWord><Action>0</Action><Messages>" & sMessages & "</Messages><Originator></Originator><SDate></SDate></MainmsgBody>")
        Return deger
    End Function
    Private Function tbSmsDetayi_Kaydet_yeni(ByVal nIslemID As Int64, ByVal sSMSID As String, ByVal dteGonderimTarihi As DateTime, ByVal sMesaj As String, ByVal nMusteriID As Int64, ByVal sTelefon As String, ByVal dteUpdateTarihi As DateTime, ByVal lDurum As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSMSDetayi (sSMSID, dteGonderimTarihi, sMesaj, nMusteriID, sTelefon, dteUpdateTarihi, lDurum) VALUES     ( '" & sSMSID & "', '" & dteGonderimTarihi & "', '" & sMesaj & "', " & nMusteriID & ", '" & sTelefon & "', '" & dteUpdateTarihi & "', " & lDurum & ") ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return nIslemID
    End Function
    Private Sub tbSmsDetayi_kaydet_duzelt(ByVal nIslemID As Int64, ByVal sSMSID As String, ByVal dteGonderimTarihi As DateTime, ByVal sMesaj As String, ByVal nMusteriID As Int64, ByVal sTelefon As String, ByVal dteUpdateTarihi As DateTime, ByVal lDurum As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSMSDetayi SET sSMSID = '" & sSMSID & "', dteGonderimTarihi = '" & dteGonderimTarihi & "', sMesaj = '" & sMesaj & "', nMusteriID = " & nMusteriID & ", sTelefon = '" & sTelefon & "',dteUpdateTarihi = '" & dteUpdateTarihi & "', lDurum = " & lDurum & " Where nIslemID = " & nIslemID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbSmsDetaylari_kaydet_duzelt(ByVal sSMSID As String, ByVal sYeniSMSID As String, ByVal dteGonderimTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSMSDetayi SET sSMSID = '" & sYeniSMSID & "' Where dteGonderimTarihi = '" & dteGonderimTarihi & "' and sSMSID = '" & sSMSID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub frm_Perakende_SMS_Gonder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("SMSKullaniciAdi", txt_sKullanici.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("SMSKullaniciSifre", txt_sSifre.Text)
    End Sub
    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    TextBox1.Text = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainmsgBody><UserName>agbaht-mb1361</UserName><PassWord>1502</PassWord><Action>0</Action><Mesgbody>deneme mesaji</Mesgbody><Numbers>05333329173,05308209495</Numbers><Originator></Originator><SDate></SDate></MainmsgBody>")
    'End Sub
    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    TextBox1.Text = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainReportRoot><UserName>agbaht-mb1361</UserName><PassWord>1502</PassWord><Action>3</Action><MsgID>2947582</MsgID></MainReportRoot>")
    '    TextBox1.Text = Replace(TextBox1.Text, vbLf, vbCrLf)
    'End Sub
    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    TextBox1.Text = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainmsgBody><UserName>agbaht-mb1361</UserName><PassWord>1502</PassWord><Action>1</Action><Messages><Message><Mesgbody>Deneme mesaj 1</Mesgbody><Number>05333329173</Number></Message><Message><Mesgbody>Deneme mesaji 2</Mesgbody><Number>05333329173</Number></Message></Messages><Originator></Originator><SDate></SDate></MainmsgBody>")
    'End Sub
    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    TextBox1.Text = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainReportRoot><UserName>agbaht-mb1361</UserName><PassWord>1502</PassWord><Action>2</Action><FDate>2010-11-01</FDate><LDate>2010-11-01</LDate></MainReportRoot>")
    '    TextBox1.Text = Replace(TextBox1.Text, vbLf, vbCrLf)
    'End Sub
    Private Sub frm_Perakende_SMS_Gonder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DateEdit1.EditValue = dteSistemTarihi
        txt_dteTarih1.EditValue = dteSistemTarihi
        txt_dteTarih2.EditValue = dteSistemTarihi
        Try
            sSmsKullaniciAdi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("SMSKullaniciAdi").ToString
        Catch ex As Exception
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("SMSKullaniciAdi", sSmsKullaniciAdi)
            sSmsKullaniciAdi = ""
        End Try
        Try
            sSmsKullaniciSifre = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("SMSKullaniciSifre").ToString
        Catch ex As Exception
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("SMSKullaniciSifre", sSmsKullaniciSifre)
            sSmsKullaniciSifre = ""
        End Try
        txt_sKullanici.Text = sSmsKullaniciAdi
        txt_sSifre.Text = sSmsKullaniciSifre
        Dim dr As DataRow = DataSet3.Tables(0).NewRow
        dr(0) = 1
        dr(1) = "Bekliyor"
        DataSet3.Tables(0).Rows.Add(dr)
        dr = DataSet3.Tables(0).NewRow
        dr(0) = 2
        dr(1) = "İletildi"
        DataSet3.Tables(0).Rows.Add(dr)
        dr = DataSet3.Tables(0).NewRow
        dr(0) = 3
        dr(1) = "Kullanılmıyor"
        DataSet3.Tables(0).Rows.Add(dr)
        dr = Nothing
        sec_lDurum.DataSource = DataSet3.Tables(0)
        txt_sGsmNolari.Text = GSMSMS
    End Sub
    Private Sub txt_sMessage_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sMessage.EditValueChanged
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "'", "")
        ''Replace(txt_sMessage.Text, "*", "")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "ı", "i")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "İ", "I")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "ş", "s")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "Ş", "S")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "ç", "c")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "Ç", "C")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "ğ", "g")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "Ğ", "G")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "ü", "u")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "Ü", "U")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "ö", "o")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, "Ö", "O")
        'txt_sMessage.Text = Replace(txt_sMessage.Text, """", "")
        Label2.Text = "Kalan Karakter Sayısı: " & 160 - Len(Trim(txt_sMessage.Text))
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        dataload(txt_dteTarih1.EditValue, txt_dteTarih2.EditValue, txt_sMusteriNo.Text, txt_sGsmNo.Text)
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sKodu As String, ByVal sGSM As String)
        loaded = False
        DataSet2 = stok(tarih1, tarih2, sKodu, sGSM)
        GridControl2.DataSource = DataSet2.Tables(0)
        GridControl2.DataMember = Nothing
        PanelControl3.Select()
        GridControl2.Focus()
        GridControl2.Select()
        GridView2.CollapseAllGroups()
        loaded = True
    End Sub
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sKodu As String, ByVal sGSM As String) As DataSet
        Dim kriter
        kriter = "WHERE tbSMSDetayi.dteGonderimTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        If sKodu <> "" Then
            kriter += " AND tbMusteri.sKodu = '" & sKodu & "'"
        End If
        If sGSM <> "" Then
            kriter += " AND tbSMSDetayi.sTelefon = '" & sGSM & "'"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSMSDetayi.nIslemID, tbSMSDetayi.sSMSID, tbSMSDetayi.dteGonderimTarihi, tbSMSDetayi.sMesaj, tbSMSDetayi.nMusteriID, tbSMSDetayi.sTelefon, tbSMSDetayi.dteUpdateTarihi, tbSMSDetayi.lDurum, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi FROM tbSMSDetayi LEFT OUTER JOIN tbMusteri ON tbSMSDetayi.nMusteriID = tbMusteri.nMusteriID " & kriter & " ORDER BY tbSMSDetayi.nIslemID")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If XtraMessageBox.Show("SMS Gönderim Sonuçlarını Güncellemek İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'dataload(txt_dteTarih1.EditValue, txt_dteTarih2.EditValue, txt_sMusteriNo.Text, txt_sGsmNo.Text)
            Dim dr As DataRow
            Bar1.Properties.Maximum = GridView2.SelectedRowsCount
            Bar1.Position = 0
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = GridView2.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView2.GetDataRow(s)
                    Try
                        Dim deger As String = ""
                        deger = HTTPPoster("http://gateway.mobilus.net/com.mobilus", "<MainReportRoot><UserName>" & txt_sKullanici.Text & "-" & txt_sBayiiKodu.Text & "</UserName><PassWord>" & txt_sSifre.Text & "</PassWord><Action>3</Action><MsgID>" & Trim(dr("sSMSID")) & "</MsgID></MainReportRoot>")
                        'MsgBox(deger)
                        dr("lDurum") = Microsoft.VisualBasic.Right(deger, 2)
                        tbSmsDetayi_kaydet_duzelt(dr("nIslemID"), dr("sSMSID"), dr("dteGonderimTarihi"), dr("sMesaj"), dr("nMusteriID"), dr("sTelefon"), dr("dteUpdateTarihi"), dr("lDurum"))
                        Bar1.Position += 1
                        Bar1.Refresh()
                    Catch ex As Exception
                    End Try
                Next
            End If
            XtraMessageBox.Show("Güncelleme İşlemi Tamamlandı...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub musteri()
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = txt_sMusteriNo.Text
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_sMusteriNo.Text = dr1("lKodu")
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satırı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                'DataTable1.Rows.RemoveAt(GridView1.FocusedRowHandle - 1)
                DataSet1.Tables(0).Rows.Remove(dr)
                'dr.Delete()
                'dr.AcceptChanges()
                'GridControl1.EndUpdate()
                'DataSet1.EndInit()
                'GridControl1.Select()
                'GridControl1.Focus()
                GridView1.UpdateTotalSummary()
                If GridView1.RowCount > 0 Then
                    'GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
                GridControl1.Focus()
                GridControl1.Select()
            End If
        End If
    End Sub
    Private Sub satir_ekle()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = txt_sMusteriNo.Text
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            Dim dr As DataRow = DataSet1.Tables(0).NewRow
            dr("nIslemID") = 0
            dr("sSMSID") = 0
            dr("dteGonderimTarihi") = Today
            dr("sMesaj") = ""
            dr("nMusteriID") = dr1("nMusteriID")
            dr("lKodu") = dr1("lKodu")
            dr("sAdi") = dr1("sAdi")
            dr("sSoyadi") = dr1("sSoyadi")
            dr("sTelefon") = dr1("sGSM")
            dr("dteUpdateTarihi") = Now
            dr("lDurum") = 0
            dr("lBakiye") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        End If
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_duzenle()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_musteri_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lKodu = dr("lKodu")
            frm.nMusteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub txt_sMusteriNo_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sMusteriNo.ButtonPressed
        musteri()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        txt_sMessage.Text = "Değerli Müşterimiz günü geçmiş borcunuz gözükmektedir, 4 gün içinde ödeme yapmanız gerekmektedir. Ödeme Yaptıysanız bu mesajı dikkate almayınız."
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        txt_sMessage.Text = "Değerli Müşterimiz Kayıtlarımızda günü geçmiş borcunuz gözükmektedir, 4 gün içinde ödeme yapmanız gerekmektedir aksi taktirde Adli Takip işlemi başlayacaktır."
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        txt_sMessage.Text = "Sayın [adi] [soyadi] günü geçmiş borcunuz gözükmektedir,4 gün içinde ödeme yapmanız gerekmektedir.Adli Takip başlatılacaktır."
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        txt_sMessage.Text = "Kefil Olduğunuz [adi] [soyadi] ın günü geçmiş borcu gözükmektedir, 3 gün içinde ödeme yapmanız gerekmektedir."
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        txt_sMessage.Text = "Siparişini verdiğiniz ürünler gelmiştir en kısa zamanda mağazamıza uğrayınız."
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        txt_sMessage.Text = "Doğum Gününüz Kutlu Olsun...! Sağlık Mutluluk ve Huzur Dolu Nice Senelere..."
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        txt_sMessage.Text = "Evlilik Yıldönümünüz Kutlu Olsun...! Sağlık Mutluluk ve Huzur Dolu Nice Senelere..."
    End Sub
    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton14.Click
        txt_sMessage.Text = "Değerli Müşterimiz Kişisel Bilgilerinizi Tamamlamak için En Kısa Zamanda Mağazamıza gelmeniz gerekmektedir."
    End Sub
    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton15.Click
        txt_sMessage.Text = "Servise Vermiş Olduğunuz Ürünleriniz Gelmiştir en kısa zamanda irtibat kurunuz."
    End Sub
    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton16.Click
        txt_sMessage.Text = "Satış Sözleşmeniz onaylanmıştır. En kısa zamanda mağazamıza uğramanız gerekmektedir."
    End Sub
End Class