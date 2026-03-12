Imports System.IO
Imports Microsoft.Win32
Public Class frm_fatura_import_txt
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Private Sub frm_fatura_import_txt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txt_sDosya.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("sDosya").ToString
        Catch ex As Exception
            txt_sDosya.Text = "C:\Import.TXT"
        End Try
        Try
            sec_sDosyaTipi.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("sDosyaTipi").ToString
        Catch ex As Exception
            sec_sDosyaTipi.Text = "Sabit Aralýklý"
        End Try
        'nStokID
        Try
            txt_nStokID_Sutun.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("nStokID_Sutun").ToString
        Catch ex As Exception
            txt_nStokID_Sutun.Text = -1
        End Try
        Try
            txt_nStokID_Uzunluk.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("nStokID_Uzunluk").ToString
        Catch ex As Exception
            txt_nStokID_Uzunluk.Text = ""
        End Try
        'sKodu
        Try
            txt_sKodu_Sutun.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("sKodu_Sutun").ToString
        Catch ex As Exception
            txt_sKodu_Sutun.Text = -1
        End Try
        Try
            txt_sKodu_Uzunluk.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("sKodu_Uzunluk").ToString
        Catch ex As Exception
            txt_sKodu_Uzunluk.Text = ""
        End Try
        'sBarkod
        Try
            txt_sBarkod_Sutun.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("sBarkod_Sutun").ToString
        Catch ex As Exception
            txt_sBarkod_Sutun.Text = -1
        End Try
        Try
            txt_sBarkod_Uzunluk.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("sBarkod_Uzunluk").ToString
        Catch ex As Exception
            txt_sBarkod_Uzunluk.Text = ""
        End Try
        'lMiktar
        Try
            txt_lMiktar_Sutun.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("lMiktar_Sutun").ToString
        Catch ex As Exception
            txt_lMiktar_Sutun.Text = -1
        End Try
        Try
            txt_lMiktar_Uzunluk.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("lMiktar_Uzunluk").ToString
        Catch ex As Exception
            txt_lMiktar_Uzunluk.Text = ""
        End Try
        'nKdvOrani
        Try
            txt_nKdvOrani_Sutun.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("nKdvOrani_Sutun").ToString
        Catch ex As Exception
            txt_nKdvOrani_Sutun.Text = -1
        End Try
        Try
            txt_nKdvOrani_Uzunluk.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("nKdvOrani_Uzunluk").ToString
        Catch ex As Exception
            txt_nKdvOrani_Uzunluk.Text = ""
        End Try
        'lFiyati
        Try
            txt_lFiyati_Sutun.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("lFiyati_Sutun").ToString
        Catch ex As Exception
            txt_lFiyati_Sutun.Text = -1
        End Try
        Try
            txt_lFiyati_Uzunluk.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("lFiyati_Uzunluk").ToString
        Catch ex As Exception
            txt_lFiyati_Uzunluk.Text = ""
        End Try
        'lTutari
        Try
            txt_lTutari_Sutun.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("lTutari_Sutun").ToString
        Catch ex As Exception
            txt_lTutari_Sutun.Text = -1
        End Try
        Try
            txt_lTutari_Uzunluk.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("lTutari_Uzunluk").ToString
        Catch ex As Exception
            txt_lTutari_Uzunluk.Text = ""
        End Try
        'bKdvDahil
        Try
            sec_bKdvDahil.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").OpenSubKey("IMPORT").OpenSubKey("TXT").GetValue("bKdvDahil").ToString
        Catch ex As Exception
            sec_bKdvDahil.Checked = False
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_yukle()
        Label1.Text = Sorgu_sDil(Label1.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        LabelControl6.Text = Sorgu_sDil(LabelControl6.Text, sDil)
        LabelControl7.Text = Sorgu_sDil(LabelControl7.Text, sDil)
        LabelControl8.Text = Sorgu_sDil(LabelControl8.Text, sDil)
        LabelControl9.Text = Sorgu_sDil(LabelControl9.Text, sDil)
        LabelControl10.Text = Sorgu_sDil(LabelControl10.Text, sDil)
        LabelControl11.Text = Sorgu_sDil(LabelControl10.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
    End Sub
    Private Sub dosya_sec()
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Filter = "Aktarým Dosyalarý(*.*) |*.*"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.FileName = "C:\Import.txt"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_sDosya.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub
    Private Sub dosya_ac(ByVal dosya As String, ByVal sDosyaTipi As String)
        Dim sk As StreamReader = File.OpenText(dosya)
        Dim satir
        Dim nStokID As Int64 = 0
        Dim sKodu As String = ""
        Dim sBarkod As String = ""
        Dim lMiktar As Decimal = 0
        Dim nKdvOrani As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lTutar As Decimal = 0
        Dim bKdvDahil As Decimal = 1
        Dim sayi As Integer = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            sayi += 1
        Loop
        sk.Close()
        FileOpen(1, dosya, OpenMode.Input, OpenAccess.Default)
        tbFaturaImportTxt_kaydet_sil()
        BAR1.Position = 0
        BAR1.Properties.Maximum = sayi
        BAR1.Refresh()
        sayi = 0
        While Not EOF(1)
            Dim a As Object = LineInput(1).Split(sDosyaTipi)
            nStokID = 0
            sKodu = ""
            sBarkod = ""
            lMiktar = 0
            nKdvOrani = 0
            lFiyat = 0
            lTutar = 0
            bKdvDahil = 1
            If txt_nStokID_Sutun.Text <> -1 Then
                nStokID = Trim(a(txt_nStokID_Sutun.Text))
            End If
            If txt_sKodu_Sutun.Text <> -1 Then
                sKodu = Trim(a(txt_sKodu_Sutun.Text))
            End If
            If txt_sBarkod_Sutun.Text <> -1 Then
                sBarkod = Trim(a(txt_sBarkod_Sutun.Text))
            End If
            If txt_lMiktar_Sutun.Text <> -1 Then
                lMiktar = Trim(a(txt_lMiktar_Sutun.Text))
            End If
            If txt_nKdvOrani_Sutun.Text <> -1 Then
                nKdvOrani = Trim(a(txt_nKdvOrani_Sutun.Text))
            End If
            If txt_lFiyati_Sutun.Text <> -1 Then
                lFiyat = Trim(a(txt_lFiyati_Sutun.Text))
            End If
            If txt_lTutari_Sutun.Text <> -1 Then
                lTutar = Trim(a(txt_lTutari_Sutun.Text))
            End If
            bKdvDahil = Math.Abs(CInt(sec_bKdvDahil.Checked))
            'MsgBox(nStokID & vbCrLf & sKodu & vbCrLf & sBarkod & vbCrLf & lMiktar & vbCrLf & lFiyat & vbCrLf & lTutar & vbCrLf & bKdvDahil & vbCrLf & kullanici)
            tbFaturaImportTxt_kaydet_yeni(nStokID, sKodu, sBarkod, lMiktar, nKdvOrani, lFiyat, lTutar, bKdvDahil, kullanici)
            BAR1.Position += 1
            BAR1.Refresh()
            Label2.Text = "Lütfen Bekleyiniz...Satýr :" & BAR1.Position
            Label2.Refresh()
        End While
        FileClose(1)
    End Sub
    Public Sub dosya_ac_SabitAralik(ByVal sDosya As String)
        'dataset1.Tables("TOPLUSTOK").Clear()
        Dim dosya As String = sDosya
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        Dim satis
        'Dim plu
        's = sr.Read
        'Dim takipno
        'Dim barcode
        'Dim stokadi
        'Dim satisfiyati
        'Dim departman
        'Dim birimadi
        'Dim status
        'Dim fiyattl
        Dim nStokID As Int64 = 0
        Dim sKodu As String = ""
        Dim sBarkod As String = ""
        Dim lMiktar As Decimal = 0
        Dim nKdvOrani As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lTutar As Decimal = 0
        Dim bKdvDahil As Decimal = 1
        Dim sayi As Integer = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            sayi += 1
        Loop
        BAR1.Properties.Maximum = sayi
        sayi = 0
        tbFaturaImportTxt_kaydet_sil()
        Do While sr.Peek() > -1
            satis = sr.ReadLine
            'takipno = Trim(satis.Substring(1, 6))
            'barcode = Trim(satis.Substring(7, 20))
            'stokadi = Trim(satis.Substring(27, 20))
            'satisfiyati = Trim(satis.Substring(47, 9))
            'departman = Trim(satis.Substring(56, 2))
            'birimadi = Trim(satis.Substring(58, 4))
            'status = Trim(satis.Substring(62, 1))
            'fiyattl = CType(satisfiyati, Decimal) * 1000000
            nStokID = 0
            sKodu = ""
            sBarkod = ""
            lMiktar = 1
            nKdvOrani = 0
            lFiyat = 0
            lTutar = 0
            bKdvDahil = 1
            If txt_nStokID_Sutun.Text <> -1 Then
                nStokID = Trim(satis.Substring(txt_nStokID_Sutun.Text, txt_nStokID_Uzunluk.Text))
            End If
            If txt_sKodu_Sutun.Text <> -1 Then
                sKodu = Trim(satis.Substring(txt_sKodu_Sutun.Text, txt_sKodu_Uzunluk.Text))
            End If
            If txt_sBarkod_Sutun.Text <> -1 Then
                sBarkod = Trim(satis.Substring(txt_sBarkod_Sutun.Text, txt_sBarkod_Uzunluk.Text))
            End If
            If txt_lMiktar_Sutun.Text <> -1 Then
                lMiktar = Trim(satis.Substring(txt_lMiktar_Sutun.Text, txt_lMiktar_Uzunluk.Text))
            End If
            If txt_nKdvOrani_Sutun.Text <> -1 Then
                nKdvOrani = Trim(satis.Substring(txt_nKdvOrani_Sutun.Text, txt_nKdvOrani_Uzunluk.Text))
            End If
            If txt_lFiyati_Sutun.Text <> -1 Then
                lFiyat = Trim(satis.Substring(txt_lFiyati_Sutun.Text, txt_lFiyati_Uzunluk.Text))
            End If
            If txt_lTutari_Sutun.Text <> -1 Then
                lTutar = Trim(satis.Substring(txt_lTutari_Sutun.Text, txt_lTutari_Uzunluk.Text))
            End If
            bKdvDahil = Math.Abs(CInt(sec_bKdvDahil.Checked))
            'MsgBox(nStokID & vbCrLf & sKodu & vbCrLf & sBarkod & vbCrLf & lMiktar & vbCrLf & lFiyat & vbCrLf & lTutar & vbCrLf & bKdvDahil & vbCrLf & kullanici)
            tbFaturaImportTxt_kaydet_yeni(nStokID, sKodu, sBarkod, lMiktar, nKdvOrani, lFiyat, lTutar, bKdvDahil, kullanici)
            BAR1.Position += 1
            BAR1.Refresh()
            Label2.Text = "Lütfen Bekleyiniz...Satýr :" & BAR1.Position
            Label2.Refresh()
        Loop
        'Dim stoklistesi As String = "SELECT     PLU.IND, PLU.PLUNO AS TAKIPNO, PLU.BARCODE, PLU.STOKADI, PLU.SATISFIYATI, PLU.BIRIM, PLU.DEPARTMAN, PLU.REYON, PLU.STATUS,  DEPARTMAN.KDV, DEPARTMAN.ACIKLAMA FROM         (PLU INNER JOIN DEPARTMAN ON PLU.DEPARTMAN = DEPARTMAN.DEPARTMAN)"
    End Sub
    Private Sub tbFaturaImportTxt_kaydet_yeni(ByVal nStokID As Integer, ByVal sKodu As String, ByVal sBarkod As String, ByVal lMiktar As Decimal, ByVal nKdvOrani As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal bKdvDahil As Integer, ByVal sKullanici As String, Optional ByVal ISK As Decimal = 0)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If ISK >= 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFaturaImportTxt (nStokID, sKodu, sBarkod, lMiktar, nKdvOrani,lFiyat, lTutar, bKdvDahil, sKullanici, ISK) VALUES (" & nStokID & ", '" & sKodu & "', '" & sBarkod & "', " & lMiktar & ", " & nKdvOrani & "," & lFiyat & ", " & lTutar & ", " & bKdvDahil & ", '" & sKullanici & "', " & ISK & ")")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFaturaImportTxt (nStokID, sKodu, sBarkod, lMiktar, nKdvOrani,lFiyat, lTutar, bKdvDahil, sKullanici) VALUES (" & nStokID & ", '" & sKodu & "', '" & sBarkod & "', " & lMiktar & ", " & nKdvOrani & "," & lFiyat & ", " & lTutar & ", " & bKdvDahil & ", '" & sKullanici & "')")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFaturaImportTxt_kaydet_sil()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED TRUNCATE TABLE tbFaturaImportTxt ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub txt_sDosya_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sDosya.ButtonPressed
        dosya_sec()
    End Sub
    Private Sub txt_sDosya_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sDosya.KeyDown
        If e.KeyCode = Keys.F6 Then
            dosya_sec()
        End If
    End Sub
    Private Sub dosya_ac_Nebim(ByVal dosya As String, ByVal stokKoduInd As Integer, ByVal miktarInd As Integer, ByVal birimFiyatInd As Integer, ByVal toplamFiyatInd As Integer, ByVal ISKInd As Integer, ByVal KDVInd As Integer)
        Dim sr As StreamReader = File.OpenText(dosya)
        Dim sk As StreamReader = File.OpenText(dosya)
        Dim satir As String = ""
        Dim nStokKodu As String = ""
        Dim nMiktar As Decimal = 0
        Dim nBirimFiyat As Decimal = 0
        Dim nToplamFiyat As Decimal = 0
        Dim nISK As Decimal = 0
        Dim nKDV As Decimal = 0
        Dim satirSplit() As String
        Dim sayi As Integer = 0
        Try
            Do While sk.Peek() > -1
                sayi += 1
            Loop
        Catch ex As Exception
        End Try
        BAR1.Properties.Maximum = sayi
        sayi = 0
        tbFaturaImportTxt_kaydet_sil()
        Do While sr.Peek() > -1
            satir = sr.ReadLine
            satirSplit = satir.Split(New [Char]() {CChar(vbTab)})
            Try
                nStokKodu = satirSplit(stokKoduInd)
                nMiktar = satirSplit(miktarInd)
                nBirimFiyat = satirSplit(birimFiyatInd)
                nToplamFiyat = satirSplit(toplamFiyatInd)
                nISK = satirSplit(ISKInd)
                nISK = (nISK / nToplamFiyat) * 100
                nKDV = satirSplit(KDVInd)
                tbFaturaImportTxt_kaydet_yeni(0, nStokKodu, "", nMiktar, nKDV, nBirimFiyat, nToplamFiyat, Math.Abs(CInt(sec_bKdvDahil.Checked)), kullanici, nISK)
                BAR1.Position += 1
                BAR1.Refresh()
                Label2.Text = "Lütfen Bekleyiniz...Satýr :" & BAR1.Position
                Label2.Refresh()
            Catch ex As Exception
            End Try
        Loop
    End Sub
    Private Sub dosya_ac_Nebim_Toptan(ByVal dosya As String, ByVal stokKoduInd As Integer, ByVal miktarInd As Integer, ByVal birimFiyatInd As Integer, ByVal toplamFiyatInd As Integer, ByVal ISKInd As Integer, ByVal KDVInd As Integer)
        Dim sr As StreamReader = File.OpenText(dosya)
        Dim sk As StreamReader = File.OpenText(dosya)
        Dim satir As String = ""
        Dim nStokKodu As String = ""
        Dim nMiktar As Decimal = 0
        Dim nBirimFiyat As Decimal = 0
        Dim nToplamFiyat As Decimal = 0
        Dim nISK As Decimal = 0
        Dim nKDV As Decimal = 0
        Dim satirSplit() As String
        Dim sayi As Integer = 0
        Try
            Do While sk.Peek() > -1
                sayi += 1
            Loop
        Catch ex As Exception
        End Try
        BAR1.Properties.Maximum = sayi
        sayi = 0
        tbFaturaImportTxt_kaydet_sil()
        Do While sr.Peek() > -1
            satir = sr.ReadLine
            satirSplit = satir.Split(New [Char]() {CChar(vbTab)})
            Try
                nStokKodu = satirSplit(stokKoduInd)
                nMiktar = satirSplit(miktarInd)
                nBirimFiyat = satirSplit(birimFiyatInd)
                nToplamFiyat = satirSplit(toplamFiyatInd)
                nKDV = satirSplit(KDVInd)
                tbFaturaImportTxt_kaydet_yeni(0, nStokKodu, "", nMiktar, nKDV, nBirimFiyat, nToplamFiyat, Math.Abs(CInt(sec_bKdvDahil.Checked)), kullanici, 0)
                BAR1.Position += 1
                BAR1.Refresh()
                Label2.Text = "Lütfen Bekleyiniz...Satýr :" & BAR1.Position
                Label2.Refresh()
            Catch ex As Exception
            End Try
        Loop
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        If sec_sDosyaTipi.Text = "Virgül ile Ayrýlmýþ" Then
            dosya_ac(txt_sDosya.Text, ",")
        ElseIf sec_sDosyaTipi.Text = "NoktalýVirgül ile Ayrýlmýþ" Then
            dosya_ac(txt_sDosya.Text, ";")
        ElseIf sec_sDosyaTipi.Text = "Çift Týrnak ile Ayrýlmýþ" Then
            dosya_ac(txt_sDosya.Text, """")
        ElseIf sec_sDosyaTipi.Text = "Kesme Ýþareti ile Ayrýlmýþ" Then
            dosya_ac(txt_sDosya.Text, "'")
        ElseIf sec_sDosyaTipi.Text = "Nebim Dýþ Veri Al" Then
            dosya_ac_Nebim(txt_sDosya.Text, 0, 9, 14, 15, 17, 21)
        ElseIf sec_sDosyaTipi.Text = "Nebim Dýþ Veri Al Toptan" Then
            dosya_ac_Nebim_Toptan(txt_sDosya.Text, 0, 15, 20, 21, 17, 26)
        Else
            dosya_ac_SabitAralik(txt_sDosya.Text)
        End If
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("sDosya", txt_sDosya.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("sDosyaTipi", sec_sDosyaTipi.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("nStokID_Sutun", txt_nStokID_Sutun.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("nStokID_Uzunluk", txt_nStokID_Uzunluk.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("sKodu_Sutun", txt_sKodu_Sutun.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("sKodu_Uzunluk", txt_sKodu_Uzunluk.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("sBarkod_Sutun", txt_sBarkod_Sutun.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("sBarkod_Uzunluk", txt_sBarkod_Uzunluk.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("lMiktar_Sutun", txt_lMiktar_Sutun.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("lMiktar_Uzunluk", txt_lMiktar_Uzunluk.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("nKdvOrani_Sutun", txt_nKdvOrani_Sutun.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("nKdvOrani_Uzunluk", txt_nKdvOrani_Uzunluk.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("lFiyati_Sutun", txt_lFiyati_Sutun.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("lFiyati_Uzunluk", txt_lFiyati_Uzunluk.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("lTutari_Sutun", txt_lTutari_Sutun.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("lTutari_Uzunluk", txt_lTutari_Uzunluk.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").CreateSubKey("IMPORT").CreateSubKey("TXT").SetValue("bKdvDahil", sec_bKdvDahil.Checked)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub sec_bKdvDahil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_bKdvDahil.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1.Focus()
        End If
    End Sub
    Private Sub sec_sDosyaTipi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles sec_sDosyaTipi.SelectedIndexChanged
        If sec_sDosyaTipi.Text = "Nebim Dýþ Veri Al" Or sec_sDosyaTipi.Text = "Nebim Dýþ Veri Al Toptan" Then
            PanelControl4.Enabled = False
        Else
            PanelControl4.Enabled = True
        End If
    End Sub
End Class