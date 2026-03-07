Imports System.IO
Imports DevExpress.XtraEditors
Public Class frm_tbPos_Inter_Program
    Public sPath As String
    Public sFile As String
    Public nIlkKasa As Integer
    Public nSonKasa As Integer
    Public firmano As Integer
    Public donemno As Integer
    Public connection As String
    Public kullanici As String
    Public sAyrac As String = ":"
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub program_oku(ByVal sPath As String)
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = "" & sPath & sAyrac & sFile & "\poskon\program.dat" 'SAVE.FileName.ToString
        'dosyayý kontrol et
        Dim dosya As New FileInfo(z)
        If dosya.Exists = True Then
        Else
            dosya.Create()
        End If
        Dim dr_tus As DataRow
        Dim dr_dept As DataRow
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        Dim okunan As String
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            okunan = Trim(satir.Substring(0, 3))
            If okunan.Substring(0, 2) = "L1" Then
                logo1.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "L2" Then
                logo2.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "L3" Then
                logo3.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "L4" Then
                logo4.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "L5" Then
                'logo5.Text = satir.Substring(2, 40)
            ElseIf okunan.Substring(0, 2) = "L6" Then
                logo6.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "XD" Then
                s_XV.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "XN" Then
                s_xn.Text = RTrim(satir.Substring(2))
                'gösterge
            ElseIf okunan.Substring(0, 2) = "M1" Then
                gostergesatir1.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "M2" Then
                gostergesatir2.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "M3" Then
                gostergesatir3.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "M4" Then
                gostergesatir4.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "M5" Then
                gostergesatir5.Text = RTrim(satir.Substring(2))
            ElseIf okunan.Substring(0, 2) = "M6" Then
                gostergesatir6.Text = RTrim(satir.Substring(2))
                'departmanlar
            ElseIf okunan = "D01" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "01"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext1.Text = RTrim(satir.Substring(3))
            ElseIf okunan = "D02" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "02"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext2.Text = satir.Substring(3)
            ElseIf okunan = "D03" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "03"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext3.Text = satir.Substring(3)
            ElseIf okunan = "D04" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "04"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext4.Text = satir.Substring(3)
            ElseIf okunan = "D05" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "05"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext5.Text = satir.Substring(3)
            ElseIf okunan = "D06" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "06"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext6.Text = satir.Substring(3)
            ElseIf okunan = "D07" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "07"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext7.Text = satir.Substring(3)
            ElseIf okunan = "D08" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "08"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext8.Text = satir.Substring(3)
            ElseIf okunan = "D09" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "09"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext9.Text = satir.Substring(3)
            ElseIf okunan = "D10" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "10"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext10.Text = satir.Substring(3)
            ElseIf okunan = "D11" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "11"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext11.Text = satir.Substring(3)
            ElseIf okunan = "D12" Then
                dr_dept = ds_departman.Tables(0).NewRow
                dr_dept("IND") = "12"
                dr_dept("nKdvOrani") = RTrim(satir.Substring(4, 2))
                dr_dept("sAciklama") = RTrim(satir.Substring(6))
                ds_departman.Tables(0).Rows.Add(dr_dept)
                'deptext12.Text = satir.Substring(3)
                'kredi tuþlarý
            ElseIf okunan = "K01" Then
                kreditus1.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K02" Then
                kreditus2.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K03" Then
                kreditus3.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K04" Then
                kreditus4.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K05" Then
                kreditus5.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K06" Then
                kreditus6.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K07" Then
                kreditus7.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K08" Then
                kreditus8.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K09" Then
                kreditus9.Text = Trim(satir.Substring(3))
            ElseIf okunan = "K10" Then
                kreditus10.Text = Trim(satir.Substring(3))
                'etiket tuþlarý
            ElseIf okunan.Substring(0, 3) = "E01" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "01"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E02" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "02"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E03" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "03"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E04" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "04"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E05" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "05"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E06" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "06"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E07" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "07"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E08" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "08"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E09" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "09"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E10" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "10"
                dr_tus("nStokID") = satir.Substring(3)
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E11" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "11"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E12" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "12"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E13" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "13"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E14" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "14"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E15" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "15"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E16" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "16"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E17" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "17"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E18" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "18"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E19" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "19"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E20" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "20"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E21" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "21"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E22" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "22"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E23" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "23"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E24" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "24"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E25" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "25"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E26" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "26"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E27" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "27"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E28" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "28"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E29" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "29"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E30" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "30"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E31" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "31"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
            ElseIf okunan.Substring(0, 3) = "E32" Then
                dr_tus = ds_tus.Tables(0).NewRow
                dr_tus("IND") = "32"
                dr_tus("nStokID") = satir.Substring(3)
                dr_tus("sAciklama") = sorgu_sAciklama(dr_tus("nStokID"))
                ds_tus.Tables(0).Rows.Add(dr_tus)
                'fis limiti
            ElseIf okunan.Substring(0, 1) = "Y" Then
                fislimit.Text = satir.Substring(2)
                'barkod ayarlarý
            ElseIf okunan.Substring(0, 1) = "G" Then
                gramajtext.Text = satir.Substring(1)
            ElseIf okunan.Substring(0, 1) = "A" Then
                adettext.Text = satir.Substring(1)
            ElseIf okunan.Substring(0, 1) = "T" Then
                tutartext.Text = satir.Substring(1)
                'fatura koordinatlarý
            ElseIf okunan.Substring(0, 1) = "S" Then
                Try
                    x1.Text = satir.Substring(1, 2)
                    y1.Text = satir.Substring(3, 2)
                    x2.Text = satir.Substring(5, 2)
                    y2.Text = satir.Substring(7, 2)
                    x3.Text = satir.Substring(9, 2)
                    y3.Text = satir.Substring(11, 2)
                    sabit.Text = satir.Substring(13, 3)
                    If satir.Substring(16, 1) = 0 Then
                        form.Checked = False
                    ElseIf satir.Substring(15, 1) = 0 Then
                        form.Checked = True
                    End If
                Catch ex As Exception
                End Try
            End If
        Loop
        sk.Close()
    End Sub
    Private Sub programtransfer(ByVal sPath As String)
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = "" & sPath & sAyrac & sFile & "\poskon\program.dat" 'SAVE.FileName.ToString
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'firma logosu
        Dim L1 = degeruzunlukkontrol(logo1.Text, 40)
        Dim L2 = degeruzunlukkontrol(logo2.Text, 40)
        Dim L3 = degeruzunlukkontrol(logo3.Text, 40)
        Dim L4 = degeruzunlukkontrol(logo4.Text, 40)
        Dim L5 = degeruzunlukkontrol(logo5.Text, 40)
        Dim L6 = degeruzunlukkontrol(logo6.Text, 40)
        Dim XD = degeruzunlukkontrol(s_xv.Text, 41)
        Dim XN = degeruzunlukkontrol(s_xn.Text, 41)
        'departman
        Dim D01 As String = "" '= dll.degeruzunlukkontrol(deptext1.Text, 20)
        Dim D02 As String = "" '= dll.degeruzunlukkontrol(deptext2.Text, 20)
        Dim D03 As String = "" '= dll.degeruzunlukkontrol(deptext3.Text, 20)
        Dim D04 As String = "" '= dll.degeruzunlukkontrol(deptext4.Text, 20)
        Dim D05 As String = "" '= dll.degeruzunlukkontrol(deptext5.Text, 20)
        Dim D06 As String = "" '= dll.degeruzunlukkontrol(deptext6.Text, 20)
        Dim D07 As String = "" '= dll.degeruzunlukkontrol(deptext7.Text, 20)
        Dim D08 As String = "" '= dll.degeruzunlukkontrol(deptext8.Text, 20)
        Dim D09 As String = "" '= dll.degeruzunlukkontrol(deptext9.Text, 20)
        Dim D10 As String = "" '= dll.degeruzunlukkontrol(deptext10.Text, 20)
        Dim D11 As String = "" '= dll.degeruzunlukkontrol(deptext11.Text, 20)
        Dim D12 As String = "" '= dll.degeruzunlukkontrol(deptext12.Text, 20)
        'vergi
        Dim v01 As String = "" '= dll.sayiuzunlukkontrol(dep1.Text, 2)
        Dim v02 As String = "" '= dll.sayiuzunlukkontrol(dep2.Text, 2)
        Dim v03 As String = "" '= dll.sayiuzunlukkontrol(dep3.Text, 2)
        Dim v04 As String = "" '= dll.sayiuzunlukkontrol(dep4.Text, 2)
        Dim v05 As String = "" '= dll.sayiuzunlukkontrol(dep5.Text, 2)
        Dim v06 As String = "" '= dll.sayiuzunlukkontrol(dep6.Text, 2)
        Dim v07 As String = "" '= dll.sayiuzunlukkontrol(dep7.Text, 2)
        Dim v08 As String = "" '= dll.sayiuzunlukkontrol(dep8.Text, 2)
        Dim v09 As String = "" '= dll.sayiuzunlukkontrol(dep9.Text, 2)
        Dim v10 As String = "" '= dll.sayiuzunlukkontrol(dep10.Text, 2)
        Dim v11 As String = "" '= dll.sayiuzunlukkontrol(dep11.Text, 2)
        Dim v12 As String = "" '= dll.sayiuzunlukkontrol(dep12.Text, 2)
        Dim dr_dept As DataRow
        For Each dr_dept In ds_departman.Tables(0).Rows
            If dr_dept("IND") = "01" Then
                v01 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D01 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "02" Then
                v02 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D02 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "03" Then
                v03 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D03 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "04" Then
                v04 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D04 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "05" Then
                v05 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D05 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "06" Then
                v06 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D06 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "07" Then
                v07 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D07 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "08" Then
                v08 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D08 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "09" Then
                v09 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D09 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "10" Then
                v10 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D10 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "11" Then
                v11 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D11 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            ElseIf dr_dept("IND") = "12" Then
                v12 = sayiuzunlukkontrol(dr_dept("nKdvOrani"), 2)
                D12 = "%" & degeruzunlukkontrol(dr_dept("nKdvOrani"), 2) & degeruzunlukkontrol(dr_dept("sAciklama"), 17)
            End If
        Next
        'Dim v00 = v01 & v02 & v03 & v04 & v05 & v06 & v07 & v08 & v09 & v10 & v11 & v12
        'gösterge
        Dim M1 = degeruzunlukkontrol(gostergesatir1.Text, 20)
        Dim M2 = degeruzunlukkontrol(gostergesatir2.Text, 20)
        Dim M3 = degeruzunlukkontrol(gostergesatir3.Text, 20)
        Dim M4 = degeruzunlukkontrol(gostergesatir4.Text, 20)
        Dim M5 = degeruzunlukkontrol(gostergesatir5.Text, 20)
        Dim M6 = degeruzunlukkontrol(gostergesatir6.Text, 20)
        'kredi tuþlarý
        Dim K01 = degeruzunlukkontrol(kreditus1.Text, 20)
        Dim K02 = degeruzunlukkontrol(kreditus2.Text, 20)
        Dim K03 = degeruzunlukkontrol(kreditus3.Text, 20)
        Dim K04 = degeruzunlukkontrol(kreditus4.Text, 20)
        Dim K05 = degeruzunlukkontrol(kreditus5.Text, 20)
        Dim K06 = degeruzunlukkontrol(kreditus6.Text, 20)
        Dim K07 = degeruzunlukkontrol(kreditus7.Text, 20)
        Dim K08 = degeruzunlukkontrol(kreditus8.Text, 20)
        Dim K09 = degeruzunlukkontrol(kreditus9.Text, 20)
        Dim K10 = degeruzunlukkontrol(kreditus10.Text, 20)
        'etiket tuþlarý
        Dim E01 As String = "" '= dll.degeruzunlukkontrol(tus1.Text, 6)
        Dim E02 As String = "" '= dll.degeruzunlukkontrol(tus2.Text, 6)
        Dim E03 As String = "" '= dll.degeruzunlukkontrol(tus3.Text, 6)
        Dim E04 As String = "" '= dll.degeruzunlukkontrol(tus4.Text, 6)
        Dim E05 As String = "" '= dll.degeruzunlukkontrol(tus5.Text, 6)
        Dim E06 As String = "" '= dll.degeruzunlukkontrol(tus6.Text, 6)
        Dim E07 As String = "" '= dll.degeruzunlukkontrol(tus7.Text, 6)
        Dim E08 As String = "" '= dll.degeruzunlukkontrol(tus8.Text, 6)
        Dim E09 As String = "" '= dll.degeruzunlukkontrol(tus9.Text, 6)
        Dim E10 As String = "" '= dll.degeruzunlukkontrol(tus10.Text, 6)
        Dim E11 As String = "" '= dll.degeruzunlukkontrol(tus11.Text, 6)
        Dim E12 As String = "" '= dll.degeruzunlukkontrol(tus12.Text, 6)
        Dim E13 As String = "" '= dll.degeruzunlukkontrol(tus13.Text, 6)
        Dim E14 As String = "" '= dll.degeruzunlukkontrol(tus14.Text, 6)
        Dim E15 As String = "" '= dll.degeruzunlukkontrol(tus15.Text, 6)
        Dim E16 As String = "" '= dll.degeruzunlukkontrol(tus16.Text, 6)
        Dim E17 As String = "" '= dll.degeruzunlukkontrol(tus17.Text, 6)
        Dim E18 As String = "" '= dll.degeruzunlukkontrol(tus18.Text, 6)
        Dim E19 As String = "" '= dll.degeruzunlukkontrol(tus19.Text, 6)
        Dim E20 As String = "" '= dll.degeruzunlukkontrol(tus20.Text, 6)
        Dim E21 As String = "" '= dll.degeruzunlukkontrol(tus21.Text, 6)
        Dim E22 As String = "" '= dll.degeruzunlukkontrol(tus22.Text, 6)
        Dim E23 As String = "" '= dll.degeruzunlukkontrol(tus23.Text, 6)
        Dim E24 As String = "" '= dll.degeruzunlukkontrol(tus24.Text, 6)
        Dim E25 As String = "" '= dll.degeruzunlukkontrol(tus25.Text, 6)
        Dim E26 As String = "" '= dll.degeruzunlukkontrol(tus26.Text, 6)
        Dim E27 As String = "" '= dll.degeruzunlukkontrol(tus27.Text, 6)
        Dim E28 As String = "" '= dll.degeruzunlukkontrol(tus28.Text, 6)
        Dim E29 As String = "" '= dll.degeruzunlukkontrol(tus29.Text, 6)
        Dim E30 As String = "" '= dll.degeruzunlukkontrol(tus30.Text, 6)
        Dim E31 As String = "" '= dll.degeruzunlukkontrol(tus31.Text, 6)
        Dim E32 As String = "" '= dll.degeruzunlukkontrol(tus32.Text, 6)
        Dim dr_tus As DataRow
        For Each dr_tus In ds_tus.Tables(0).Rows
            If dr_tus("IND") = "01" Then
                E01 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "02" Then
                E02 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "03" Then
                E03 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "04" Then
                E04 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "05" Then
                E05 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "06" Then
                E06 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "07" Then
                E07 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "08" Then
                E08 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "09" Then
                E09 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "10" Then
                E10 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "11" Then
                E11 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "12" Then
                E12 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "13" Then
                E13 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "14" Then
                E14 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "15" Then
                E15 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "16" Then
                E16 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "17" Then
                E17 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "18" Then
                E18 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "19" Then
                E19 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "20" Then
                E20 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "21" Then
                E21 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "22" Then
                E22 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "23" Then
                E23 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "24" Then
                E24 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "25" Then
                E25 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "26" Then
                E26 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "27" Then
                E27 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "28" Then
                E28 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "29" Then
                E29 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "30" Then
                E30 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "31" Then
                E31 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            ElseIf dr_tus("IND") = "32" Then
                E32 = degeruzunlukkontrol(dr_tus("nStokID"), 6)
            End If
        Next
        'fiþlimiti
        Dim Y = " " & fislimit.Text
        'barkod tanýmlarý
        Dim G = gramajtext.Text
        Dim T = tutartext.Text
        Dim A = adettext.Text
        'fatura koordinatlarý
        Dim S = x1.Text & y1.Text & x2.Text & y2.Text & x3.Text & y3.Text & sabit.Text & "0"
        Dim fy = "0"
        Dim sT As String
        sT = ""
        If L1.ToString <> "" Then
            sT += "L1" & L1 & vbCrLf
            sw.WriteLine("L1" & L1)
        End If
        If L2.ToString <> "" Then
            sT += "L2" & L2 & vbCrLf
            sw.WriteLine("L2" & L2)
        End If
        If L3.ToString <> "" Then
            sT += "L3" & L3 & vbCrLf
            sw.WriteLine("L3" & L3)
        End If
        If L4.ToString <> "" Then
            sT += "L4" & L4 & vbCrLf
            sw.WriteLine("L4" & L4)
        End If
        If L5.ToString <> "" Then
            sT += "L5" & L5 & vbCrLf
            sw.WriteLine("L5" & L5)
        End If
        If L6.ToString <> "" Then
            sT += "L6" & L6 & vbCrLf
            sw.WriteLine("L6" & L6)
        End If
        If XD.ToString <> "" Then
            sT += "XD" & XD & vbCrLf
            sw.WriteLine("XD" & XD)
        End If
        If XN.ToString <> "" Then
            sT += "XN" & XN & vbCrLf
            sw.WriteLine("XN" & XN)
        End If
        If M1.ToString <> "" Then
            sT += "M1" & M1 & vbCrLf
            sw.WriteLine("M1" & M1)
        End If
        If M2.ToString <> "" Then
            sT += "M2" & M2 & vbCrLf
            sw.WriteLine("M2" & M2)
        End If
        If M3.ToString <> "" Then
            sT += "M3" & M3 & vbCrLf
            sw.WriteLine("M3" & M3)
        End If
        If M4.ToString <> "" Then
            sT += "M4" & M4 & vbCrLf
            sw.WriteLine("M4" & M4)
        End If
        If M5.ToString <> "" Then
            sT += "M5" & M5 & vbCrLf
            sw.WriteLine("M5" & M5)
        End If
        If M6.ToString <> "" Then
            sT += "M6" & M6 & vbCrLf
            sw.WriteLine("M6" & M6)
        End If
        If Trim(D01.ToString) <> "" Then
            sT += "D01" & D01 & vbCrLf
            sw.WriteLine("D01" & D01)
        Else
            v01 = ""
        End If
        If Trim(D02.ToString) <> "" Then
            sT += "D02" & D02 & vbCrLf
            sw.WriteLine("D02" & D02)
        Else
            v02 = ""
        End If
        If Trim(D03.ToString) <> "" Then
            sT += "D03" & D03 & vbCrLf
            sw.WriteLine("D03" & D03)
        Else
            v03 = ""
        End If
        If Trim(D04.ToString) <> "" Then
            sT += "D04" & D04 & vbCrLf
            sw.WriteLine("D04" & D04)
        Else
            v04 = ""
        End If
        If Trim(D05.ToString) <> "" Then
            sT += "D05" & D05 & vbCrLf
            sw.WriteLine("D05" & D05)
        Else
            v05 = ""
        End If
        If Trim(D06.ToString) <> "" Then
            sT += "D06" & D06 & vbCrLf
            sw.WriteLine("D06" & D06)
        Else
            v06 = ""
        End If
        If Trim(D07.ToString) <> "" Then
            sT += "D07" & D07 & vbCrLf
            sw.WriteLine("D07" & D07)
        Else
            v07 = ""
        End If
        If Trim(D08.ToString) <> "" Then
            sT += "D08" & D08 & vbCrLf
            sw.WriteLine("D08" & D08)
        Else
            v08 = ""
        End If
        If Trim(D09.ToString) <> "" Then
            sT += "D09" & D09 & vbCrLf
            sw.WriteLine("D09" & D09)
        Else
            v09 = ""
        End If
        If Trim(D10.ToString) <> "" Then
            sT += "D10" & D10 & vbCrLf
            sw.WriteLine("D10" & D10)
        Else
            v10 = ""
        End If
        If Trim(D11.ToString) <> "" Then
            sT += "D11" & D11 & vbCrLf
            sw.WriteLine("D11" & D11)
        Else
            v11 = ""
        End If
        If Trim(D12.ToString) <> "" Then
            sT += "D12" & D12 & vbCrLf
            sw.WriteLine("D12" & D12)
        Else
            v12 = ""
        End If
        Dim v00 = Trim(v01) & Trim(v02) & Trim(v03) & Trim(v04) & Trim(v05) & Trim(v06) & Trim(v07) & Trim(v08) & Trim(v09) & Trim(v10) & Trim(v11) & Trim(v12)
        If v00.ToString <> "" Then
            sT += "V" & RTrim(v00) & vbCrLf
            sw.WriteLine("V" & RTrim(v00))
        End If
        If K01.ToString <> "" Then
            sT += "K01" & K01 & vbCrLf
            sw.WriteLine("K01" & K01)
        End If
        If K02.ToString <> "" Then
            sT += "K02" & K02 & vbCrLf
            sw.WriteLine("K02" & K02)
        End If
        If K03.ToString <> "" Then
            sT += "K03" & K03 & vbCrLf
            sw.WriteLine("K03" & K03)
        End If
        If K04.ToString <> "" Then
            sT += "K04" & K04 & vbCrLf
            sw.WriteLine("K04" & K04)
        End If
        If K05.ToString <> "" Then
            sT += "K05" & K05 & vbCrLf
            sw.WriteLine("K05" & K05)
        End If
        If K06.ToString <> "" Then
            sT += "K06" & K06 & vbCrLf
            sw.WriteLine("K06" & K06)
        End If
        If K07.ToString <> "" Then
            sT += "K07" & K07 & vbCrLf
            sw.WriteLine("K07" & K07)
        End If
        If K08.ToString <> "" Then
            sT += "K08" & K08 & vbCrLf
            sw.WriteLine("K08" & K08)
        End If
        If K09.ToString <> "" Then
            sT += "K09" & K09 & vbCrLf
            sw.WriteLine("K09" & K09)
        End If
        If K10.ToString <> "" Then
            sT += "K10" & K10 & vbCrLf
            sw.WriteLine("K10" & K10)
        End If
        If Y.ToString <> "" Then
            sT += "Y" & Y & vbCrLf
            sw.WriteLine("Y" & Y)
        End If
        If A.ToString <> "" Then
            sT += "A" & A & vbCrLf
            sw.WriteLine("A" & A)
        End If
        If G.ToString <> "" Then
            sT += "G" & G & vbCrLf
            sw.WriteLine("G" & G)
        End If
        If T.ToString <> "" Then
            sT += "T" & T & vbCrLf
            sw.WriteLine("T" & T)
        End If
        If S.ToString <> "" Then
            sT += "S" & S & vbCrLf
            sw.WriteLine("S" & S)
        End If
        If fy.ToString <> "" Then
            sT += "FY" & fy & vbCrLf
            sw.WriteLine("FY" & fy)
        End If
        If Trim(E01.ToString) <> "" Then
            sT += "E01" & E01 & vbCrLf
            sw.WriteLine("E01" & E01)
        End If
        If Trim(E02.ToString) <> "" Then
            sT += "E02" & E02 & vbCrLf
            sw.WriteLine("E02" & E02)
        End If
        If Trim(E03.ToString) <> "" Then
            sT += "E03" & E03 & vbCrLf
            sw.WriteLine("E03" & E03)
        End If
        If Trim(E04.ToString) <> "" Then
            sT += "E04" & E04 & vbCrLf
            sw.WriteLine("E04" & E04)
        End If
        If Trim(E05.ToString) <> "" Then
            sT += "E05" & E05 & vbCrLf
            sw.WriteLine("E05" & E05)
        End If
        If Trim(E06.ToString) <> "" Then
            sT += "E06" & E06 & vbCrLf
            sw.WriteLine("E06" & E06)
        End If
        If Trim(E07.ToString) <> "" Then
            sT += "E07" & E07 & vbCrLf
            sw.WriteLine("E07" & E07)
        End If
        If Trim(E08.ToString) <> "" Then
            sT += "E08" & E08 & vbCrLf
            sw.WriteLine("E08" & E08)
        End If
        If Trim(E09.ToString) <> "" Then
            sT += "E09" & E09 & vbCrLf
            sw.WriteLine("E09" & E09)
        End If
        If Trim(E10.ToString) <> "" Then
            sT += "E10" & E10 & vbCrLf
            sw.WriteLine("E10" & E10)
        End If
        If Trim(E11.ToString) <> "" Then
            sT += "E11" & E11 & vbCrLf
            sw.WriteLine("E11" & E11)
        End If
        If Trim(E12.ToString) <> "" Then
            sT += "E12" & E12 & vbCrLf
            sw.WriteLine("E12" & E12)
        End If
        If Trim(E13.ToString) <> "" Then
            sT += "E13" & E13 & vbCrLf
            sw.WriteLine("E13" & E13)
        End If
        If Trim(E14.ToString) <> "" Then
            sT += "E14" & E14 & vbCrLf
            sw.WriteLine("E14" & E14)
        End If
        If Trim(E15.ToString) <> "" Then
            sT += "E15" & E15 & vbCrLf
            sw.WriteLine("E15" & E15)
        End If
        If Trim(E16.ToString) <> "" Then
            sT += "E16" & E16 & vbCrLf
            sw.WriteLine("E16" & E16)
        End If
        If Trim(E17.ToString) <> "" Then
            sT += "E17" & E17 & vbCrLf
            sw.WriteLine("E17" & E17)
        End If
        If Trim(E18.ToString) <> "" Then
            sT += "E18" & E18 & vbCrLf
            sw.WriteLine("E18" & E18)
        End If
        If Trim(E19.ToString) <> "" Then
            sT += "E19" & E19 & vbCrLf
            sw.WriteLine("E19" & E19)
        End If
        If Trim(E20.ToString) <> "" Then
            sT += "E20" & E20 & vbCrLf
            sw.WriteLine("E20" & E20)
        End If
        If Trim(E21.ToString) <> "" Then
            sT += "E21" & E21 & vbCrLf
            sw.WriteLine("E21" & E21)
        End If
        If Trim(E22.ToString) <> "" Then
            sT += "E22" & E22 & vbCrLf
            sw.WriteLine("E22" & E22)
        End If
        If Trim(E23.ToString) <> "" Then
            sT += "E23" & E23 & vbCrLf
            sw.WriteLine("E23" & E23)
        End If
        If Trim(E24.ToString) <> "" Then
            sT += "E24" & E24 & vbCrLf
            sw.WriteLine("E24" & E24)
        End If
        If Trim(E25.ToString) <> "" Then
            sT += "E25" & E25 & vbCrLf
            sw.WriteLine("E25" & E25)
        End If
        If Trim(E26.ToString) <> "" Then
            sT += "E26" & E26 & vbCrLf
            sw.WriteLine("E26" & E26)
        End If
        If Trim(E27.ToString) <> "" Then
            sT += "E27" & E27 & vbCrLf
            sw.WriteLine("E27" & E27)
        End If
        If Trim(E28.ToString) <> "" Then
            sT += "E28" & E28 & vbCrLf
            sw.WriteLine("E28" & E28)
        End If
        If Trim(E29.ToString) <> "" Then
            sT += "E29" & E29 & vbCrLf
            sw.WriteLine("E29" & E29)
        End If
        If Trim(E30.ToString) <> "" Then
            sT += "E30" & E30 & vbCrLf
            sw.WriteLine("E30" & E30)
        End If
        If Trim(E31.ToString) <> "" Then
            sT += "E31" & E31 & vbCrLf
            sw.WriteLine("E31" & E31)
        End If
        If Trim(E32.ToString) <> "" Then
            sT += "E32" & E32 & vbCrLf
            sw.WriteLine("E32" & E32)
        End If
        sw.Close()
        XtraMessageBox.Show(sT, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub kasiyer_oku(ByVal sPath As String)
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = "" & sPath & sAyrac & sFile & "\posgenel\kasiyer.dat" 'SAVE.FileName.ToString
        'dosyayý kontrol et
        Dim dosya As New FileInfo(z)
        If dosya.Exists = True Then
        Else
            dosya.Create()
        End If
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        Dim no
        Dim ad
        Dim sifre
        Dim yetki
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            Try
                Dim dr As DataRow = ds_kasiyer.Tables(0).NewRow
                no = satir.Substring(1, 4)
                dr(0) = no
                ad = satir.Substring(5, 20)
                dr(1) = ad
                sifre = satir.Substring(25, 6)
                dr(2) = sifre
                yetki = satir.Substring(31, 1)
                dr(3) = yetki
                ds_kasiyer.Tables(0).Rows.Add(dr)
                dr = Nothing
            Catch ex As Exception
            End Try
        Loop
        sk.Close()
    End Sub
    Private Sub kasiyer_ekle()
        Dim dr As DataRow = ds_kasiyer.Tables(0).NewRow
        dr(0) = sayiuzunlukkontrol(GridView1.RowCount + 1, 4)
        dr(1) = ""
        dr(2) = sayiuzunlukkontrol(GridView1.RowCount + 1, 6)
        dr(3) = "X"
        ds_kasiyer.Tables(0).Rows.Add(dr)
        dr = Nothing
    End Sub
    Private Sub kasiyer_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Eminmisiniz ...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
        End If
    End Sub
    Private Sub kasiyertransfer(ByVal sPath As String)
        Dim dr As DataRow
        Dim no
        Dim ad
        Dim sifre
        Dim yetki
        Dim s As String
        s = ""
        Dim z As String = "" & sPath & sAyrac & sFile & "\posgenel\kasiyer.dat" 'SAVE.FileName.ToString
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        For Each dr In ds_kasiyer.Tables(0).Rows
            no = sayiuzunlukkontrol(dr(0), 4)
            ad = degeruzunlukkontrol(Trim(dr(1)), 20)
            sifre = degeruzunlukkontrol(dr(2), 6)
            yetki = degeruzunlukkontrol(dr(3), 1)
            sw.WriteLine(1 & no & ad & sifre & yetki)
        Next
        sw.Close()
    End Sub
    Private Sub mesaj_create(ByVal sPath As String, ByVal nIlkKasa As Integer, ByVal nSonKasa As Integer, ByVal mesaj As String)
        Dim i As Integer
        Dim t As Integer = nIlkKasa - 1
        For i = nIlkKasa To nSonKasa
            t += 1
            Dim Z As String = "" & sPath & sAyrac & sFile & "\POSKON\MESAJ.00" & t & ""
            Dim sw As StreamWriter = File.CreateText(Z)
            sw.WriteLine(mesaj)
            sw.Close()
        Next
    End Sub
    Private Sub departman_ekle()
        Dim dr As DataRow = ds_departman.Tables(0).NewRow
        dr(0) = sayiuzunlukkontrol(GridView2.RowCount + 1, 2)
        dr(1) = "0"
        dr(2) = "Departman"
        ds_departman.Tables(0).Rows.Add(dr)
        dr = Nothing
    End Sub
    Private Sub departman_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Eminmisiniz ...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView2.DeleteRow(GridView2.FocusedRowHandle)
        End If
    End Sub
    Private Sub tus_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Eminmisiniz ...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView3.DeleteRow(GridView3.FocusedRowHandle)
        End If
    End Sub
    Private Sub satir_ekle_stok()
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_tus.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("IND") = sayiuzunlukkontrol(GridView3.RowCount + 1, 2)
                    dr("nStokID") = Microsoft.VisualBasic.Right(dr1("nStokID"), 6)
                    dr("sAciklama") = dr1("sAciklama")
                    ds_tus.Tables(0).Rows.Add(dr)
                Next
            End If
        End If
    End Sub
    Public Function degeruzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        deger = deger.Replace("Ý", "I")
        deger = deger.Replace("Þ", "S")
        deger = deger.Replace("Ç", "C")
        deger = deger.Replace("Ð", "G")
        deger = deger.Replace("Ü", "U")
        deger = deger.Replace("Ö", "O")
        deger = deger.Replace("ý", "i")
        deger = deger.Replace("þ", "s")
        deger = deger.Replace("ç", "c")
        deger = deger.Replace("ð", "g")
        deger = deger.Replace("ü", "u")
        deger = deger.Replace("ö", "o")
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(muzunluk, " ")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Public Function sayiuzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(0, "0")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Public Function sorgu_sAciklama(ByVal nStokID As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sAciklama FROM         tbStok WHERE     nStokID LIKE '%" & nStokID & "'")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub frm_tbPos_Inter_Program_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Try
            program_oku(sPath)
        Catch ex As Exception
        End Try
        Try
            kasiyer_oku(sPath)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        kasiyer_ekle()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kasiyer_sil()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        departman_ekle()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        departman_sil()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        kasiyertransfer(sPath)
        mesaj_create(sPath, nIlkKasa, nSonKasa, "109000000000000")
        XtraMessageBox.Show(Sorgu_sDil("Kasalara Kasiyer Bilgileri Gönderildi ..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        programtransfer(sPath)
        mesaj_create(sPath, nIlkKasa, nSonKasa, "106000000000000")
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        satir_ekle_stok()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridControl3.Focus()
        GridControl3.Select()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        tus_sil()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If XtraMessageBox.Show(kasano.Text & Sorgu_sDil("  nolu Kasaya Mesaj Göndermek Ýstiyormusunuz ..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim Z As String = "" & sPath & sAyrac & sFile & "\POSKON\MESAJ." & sayiuzunlukkontrol(kasano.Text, 3) & ""
            Dim sw As StreamWriter = File.CreateText(Z)
            sw.WriteLine("113" & mesaj.Text)
            sw.Close()
            XtraMessageBox.Show(Sorgu_sDil("Mesaj Gönderildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            PictureBox1.Focus()
            PictureBox1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GroupControl1.Focus()
            GroupControl1.Select()
            logo1.Focus()
            logo1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            GroupControl3.Focus()
            GroupControl3.Select()
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            GroupControl4.Focus()
            GroupControl4.Select()
            GridControl2.Focus()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 4 Then
            GroupControl5.Focus()
            GroupControl5.Select()
            GridControl3.Focus()
            GridControl3.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 5 Then
            GroupControl6.Focus()
            GroupControl6.Select()
            gramajtext.Focus()
            gramajtext.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 6 Then
            GroupControl11.Focus()
            GroupControl11.Select()
            mesaj.Focus()
            mesaj.SelectAll()
        End If
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        If XtraMessageBox.Show("Kasiyer Bilgilerini Sistemden Çekmek Ýstediðinize Emin misiniz...?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim ds_tbKasiyer As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbKasiyer Where sKasiyerRumuzu like '0%' and len(sKasiyerRumuzu) > 1 order by sKasiyerRumuzu")
            ds_kasiyer.Tables(0).Rows.Clear()
            For Each dr In ds_tbKasiyer.Tables(0).Rows
                dr1 = ds_kasiyer.Tables(0).NewRow
                dr1("IND") = sayiuzunlukkontrol(Trim(dr("sKasiyerRumuzu")), 4)
                dr1("AD") = sayiuzunlukkontrol(dr("sAdi") & " " & dr("sSoyadi"), 20)
                dr1("SIFRE") = sayiuzunlukkontrol(dr("sSifresi"), 6)
                dr1("YETKI") = "Z"
                ds_kasiyer.Tables(0).Rows.Add(dr1)
            Next
            XtraMessageBox.Show(Sorgu_sDil("Ýþleminiz Baþarýyla Tamamlandý!", sDil), Sorgu_sDil("Dikkat", sDil))
        End If
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        If XtraMessageBox.Show("Plu Listesini Sistemden Çekmek Ýstediðinize Emin misiniz...?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim ds_tbStok As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select nStokID,sKodu,sAciklama,sRenk,sBeden from tbStok Where sKodu like '0%' and len(sKodu) = 6 Order by sKodu ")
            ds_tus.Tables(0).Rows.Clear()
            For Each dr In ds_tbStok.Tables(0).Rows
                dr1 = ds_tus.Tables(0).NewRow
                dr1("IND") = Microsoft.VisualBasic.Right(dr("sKodu"), 2)
                dr1("nStokID") = Microsoft.VisualBasic.Right(dr("nStokID"), 6)
                dr1("sAciklama") = degeruzunlukkontrol(dr("sAciklama"), 20)
                ds_tus.Tables(0).Rows.Add(dr1)
            Next
            XtraMessageBox.Show(Sorgu_sDil("Ýþleminiz Baþarýyla Tamamlandý!", sDil), Sorgu_sDil("Dikkat", sDil))
        End If
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        If XtraMessageBox.Show("Departman Listesini Sistemden Çekmek Ýstediðinize Emin misiniz...?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim ds_tbStok As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbKdv Order by sKdvTipi")
            ds_departman.Tables(0).Rows.Clear()
            For Each dr In ds_tbStok.Tables(0).Rows
                dr1 = ds_departman.Tables(0).NewRow
                dr1("IND") = Microsoft.VisualBasic.Right(dr("sKdvTipi"), 2)
                dr1("nKdvOrani") = sayiuzunlukkontrol(dr("nKdvOrani"), 2)
                dr1("sAciklama") = dr("nKdvOrani")
                ds_departman.Tables(0).Rows.Add(dr1)
            Next
            XtraMessageBox.Show(Sorgu_sDil("Ýþleminiz Baþarýyla Tamamlandý!", sDil), Sorgu_sDil("Dikkat", sDil))
        End If
    End Sub
End Class