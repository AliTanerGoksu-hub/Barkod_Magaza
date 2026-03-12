Imports Microsoft.Win32
Imports FastReport
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_tbStokMetraj
    Dim dr As DataRow
    Public sconnection
    Public nfirmano
    Public ndonemno
    Public sKullanici
    Dim status As Boolean = False
    Private Sub frm_tbStokMetraj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        status = True
    End Sub
    Private Sub print(ByVal islem As Integer)
        OpenFileDialog1.Filter = "MetrajEtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\metraj_etiket.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim z As String = OpenFileDialog1.FileName.ToString
            'Dim z As String = "c:\Formlar\Raporlar\metraj_etiket.fr3"
            If IntPtr.Size = 4 Then
                '32 Bit
                Dim frx As New TfrxReportClass
                Dim qr_hareket As New FastReport.TfrxADOQuery
                frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
                frx.LoadReportFromFile(z)
                frx.SetVariable("FIRMANO", "" & nfirmano & "")
                frx.SetVariable("DONEMNO", "" & ndonemno & "")
                frx.SetVariable("sKullanici", "'" & sKullanici & "'")
                dr = Dataset1.Tables(0).Rows(0)
                frx.SetVariable("nStokID", "" & dr("nStokID") & "")
                frx.SetVariable("sKodu", "'" & dr("sKodu") & "'")
                frx.SetVariable("sAciklama", "'" & dr("sAciklama") & "'")
                frx.SetVariable("sBarkod", "'" & dr("sBarkod") & "'")
                frx.SetVariable("lMiktar", "" & dr("lMiktar") & "")
                frx.SetVariable("lBrutFiyat1", "" & dr("lBrutFiyat1") & "")
                frx.SetVariable("lBrutFiyat2", "" & dr("lBrutFiyat2") & "")
                frx.SetVariable("lBrutTutar1", "" & dr("lBrutTutar1") & "")
                frx.SetVariable("lBrutTutar2", "" & dr("lBrutTutar2") & "")
                frx.SetVariable("sBarkodex", "'" & dr("sBarkodex") & "'")
                frx.SetVariable("sRenk", "'" & dr("sRenk") & "'")
                frx.SetVariable("sRenkAdi", "'" & dr("sRenkAdi") & "'")
                frx.SetVariable("sBeden", "'" & dr("sBeden") & "'")
                frx.SetVariable("sKavala", "'" & dr("sKavala") & "'")
                frx.SetVariable("SINIF1", "'" & dr("SINIF1") & "'")
                Dim ds_tbStokSinifi As DataSet = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT tbStokSinifi.nStokID, tbStokSinifi.sSinifKodu1, tbStokSinifi.sSinifKodu2, tbStokSinifi.sSinifKodu3, tbStokSinifi.sSinifKodu4, tbStokSinifi.sSinifKodu5, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5 FROM tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE (tbStokSinifi.nStokID = " & dr("nStokID") & ")"))
                Dim dr1 As DataRow
                For Each dr1 In ds_tbStokSinifi.Tables(0).Rows
                    frx.SetVariable("sSinifKodu1", "'" & dr1("sSinifKodu1") & "'")
                    frx.SetVariable("sSinifKodu2", "'" & dr1("sSinifKodu2") & "'")
                    frx.SetVariable("sSinifKodu3", "'" & dr1("sSinifKodu3") & "'")
                    frx.SetVariable("sSinifKodu4", "'" & dr1("sSinifKodu4") & "'")
                    frx.SetVariable("sSinifKodu5", "'" & dr1("sSinifKodu5") & "'")
                    frx.SetVariable("SINIF2", "'" & dr1("SINIF2") & "'")
                    frx.SetVariable("SINIF3", "'" & dr1("SINIF3") & "'")
                    frx.SetVariable("SINIF4", "'" & dr1("SINIF4") & "'")
                    frx.SetVariable("SINIF5", "'" & dr1("SINIF5") & "'")
                Next
                Dim kriter As String = " Where stok.nStokID = " & dr("nStokID") & ""
                qr_hareket = frx.FindObject("qr_hareket")
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
                Dim qr_connection As New FastReport.TfrxADODatabase
                qr_connection.ConnectionString = connection.ToString
                qr_connection.LoginPrompt = False
                qr_connection.CommandTimeout = Nothing
                qr_connection.Connected = True
                qr_hareket.DataBase = qr_connection
                frx.PrintOptions.Collate = False
                If islem = 0 Then
                    frx.ShowReport()
                ElseIf islem = 1 Then
                    frx.DesignReport()
                ElseIf islem = 2 Then
                    frx.PrintReport()
                End If
            ElseIf IntPtr.Size = 8 Then
                '64 Bit
                Dim args(65) As String
                Dim processYol As String
                args(0) = "" & z & ""
                args(1) = "" & connection.ToString() & ""
                args(4) = "" & status.ToString() & ""
                args(5) = "27"
                args(6) = "FIRMANO"
                args(7) = "" & nfirmano.ToString() & ""
                args(8) = "DONEMNO"
                args(9) = "" & ndonemno.ToString() & ""
                args(10) = "sKullanici"
                args(11) = "'" & sKullanici & "'"
                args(12) = "nStokID"
                args(13) = "" & dr("nStokID") & ""
                args(14) = "sKodu"
                args(15) = "'" & dr("sKodu") & "'"
                args(16) = "sAciklama"
                args(17) = "'" & dr("sAciklama") & "'"
                args(18) = "sBarkod"
                args(19) = "'" & dr("sBarkod") & "'"
                args(20) = "lMiktar"
                args(21) = "" & dr("lMiktar") & ""
                args(22) = "lBrutFiyat1"
                args(23) = "" & dr("lBrutFiyat1") & ""
                args(24) = "lBrutFiyat2"
                args(25) = "" & dr("lBrutFiyat2") & ""
                args(26) = "lBrutTutar1"
                args(27) = "" & dr("lBrutTutar1") & ""
                args(28) = "lBrutTutar2"
                args(29) = "" & dr("lBrutTutar2") & ""
                args(30) = "sBarkodex"
                args(31) = "'" & dr("sBarkodex") & "'"
                args(32) = "sRenk"
                args(33) = "'" & dr("sRenk") & "'"
                args(34) = "sRenkAdi"
                args(35) = "'" & dr("sRenkAdi") & "'"
                args(36) = "sBeden"
                args(37) = "'" & dr("sBeden") & "'"
                args(38) = "sKavala"
                args(39) = "'" & dr("sKavala") & "'"
                args(40) = "SINIF1"
                args(41) = "'" & dr("SINIF1") & "'"
                dr = Dataset1.Tables(0).Rows(0)
                Dim ds_tbStokSinifi As DataSet = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT tbStokSinifi.nStokID, tbStokSinifi.sSinifKodu1, tbStokSinifi.sSinifKodu2, tbStokSinifi.sSinifKodu3, tbStokSinifi.sSinifKodu4, tbStokSinifi.sSinifKodu5, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5 FROM tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE (tbStokSinifi.nStokID = " & dr("nStokID") & ")"))
                Dim dr1 As DataRow
                For Each dr1 In ds_tbStokSinifi.Tables(0).Rows
                    args(42) = "sSinifKodu1"
                    args(43) = "'" & dr1("sSinifKodu1") & "'"
                    args(44) = "sSinifKodu2"
                    args(45) = "'" & dr1("sSinifKodu2") & "'"
                    args(46) = "sSinifKodu3"
                    args(47) = "'" & dr1("sSinifKodu3") & "'"
                    args(48) = "sSinifKodu4"
                    args(49) = "'" & dr1("sSinifKodu4") & "'"
                    args(50) = "sSinifKodu5"
                    args(51) = "'" & dr1("sSinifKodu5") & "'"
                    args(52) = "SINIF2"
                    args(53) = "'" & dr1("SINIF2") & "'"
                    args(54) = "SINIF3"
                    args(55) = "'" & dr1("SINIF3") & "'"
                    args(56) = "SINIF4"
                    args(57) = "'" & dr1("SINIF4") & "'"
                    args(58) = "SINIF5"
                    args(59) = "'" & dr1("SINIF5") & "'"
                Next
                Dim kriter As String = " Where stok.nStokID = " & dr("nStokID") & ""
                args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
                args(3) = "qr_hareket"
                processYol = args(0)
                For i As Integer = 1 To 59
                    processYol += "|" & args(i)
                Next
                Dim objReader As StreamWriter
                Dim yeniYol As String
                Dim Generator As System.Random = New System.Random()
                Try
                    yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                    objReader = New StreamWriter(yeniYol)
                    objReader.Write(processYol)
                    objReader.Close()
                Catch Ex As Exception
                    MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
                End Try
                If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                    Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                    Process.Start(sInfo)
                Else
                    MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
                End If
            End If
        End If
    End Sub
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Sub txt_lMiktar_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_lMiktar.EditValueChanged
        barkod_hesapla()
    End Sub
    Private Sub dataload()
        dr = Dataset1.Tables(0).NewRow
        dr("nStokID") = 0
        dr("sKodu") = ""
        dr("sAciklama") = ""
        dr("sBarkod") = "00000"
        dr("lMiktar") = 1
        dr("lBrutFiyat1") = 0
        dr("lBrutFiyat2") = 0
        dr("lBrutTutar1") = 0
        dr("lBrutTutar2") = 0
        dr("sRenk") = ""
        dr("sRenkAdi") = ""
        dr("sBeden") = ""
        dr("sKavala") = ""
        dr("SINIF1") = ""
        dr("SINIF2") = ""
        dr("SINIF3") = ""
        dr("SINIF4") = ""
        dr("SINIF5") = ""
        dr("sBarkodex") = "00000"
        Dataset1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub ara()
        Dim frm As New frm_stok
        dr = DataSet1.Tables(0).Rows(0)
        Dim dr1 As DataRow
        frm.connection = sconnection
        frm.firmano = nfirmano
        frm.donemno = ndonemno
        frm.islemstatus = True
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr = Dataset1.Tables(0).Rows(0)
            If Microsoft.VisualBasic.Len(Trim(dr1("sBarkod")).ToString) = 5 Then
                dr.BeginEdit()
                dr("nStokID") = dr1("nStokID")
                dr("sKodu") = dr1("sKodu")
                dr("sAciklama") = dr1("sAciklama")
                dr("sBarkod") = Trim(dr1("sBarkod"))
                dr("lMiktar") = 1
                dr("lBrutFiyat1") = sorgu_sayi(dr1("PESIN"), 0)
                dr("lBrutFiyat2") = sorgu_sayi(dr1("ALTIAY"), 0)
                dr("lBrutTutar1") = sorgu_sayi(dr1("PESIN"), 0)
                dr("lBrutTutar2") = sorgu_sayi(dr1("ALTIAY"), 0)
                dr("sRenk") = dr1("sRenk")
                dr("sRenkAdi") = dr1("sRenkAdi")
                dr("sBeden") = dr1("sBeden")
                dr("sKavala") = dr1("sKavala")
                dr("SINIF1") = dr1("SINIF1")
                dr("SINIF2") = ""
                dr("SINIF3") = ""
                dr("SINIF4") = ""
                dr("SINIF5") = ""
                dr("sBarkodex") = "27" + Trim(dr("sBarkod")) + "00000"
                dr.EndEdit()
                txt_lMiktar.Focus()
                txt_lMiktar.SelectAll()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Seçilen Ürünün Barkod Standardý Metraj etiketi basýmýna uygun deðil", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                ara()
            End If
            frm.DataSet1.Clear()
            frm.DataSet1.Dispose()
            frm.DataSet1 = Nothing
            frm.SimpleButton1 = Nothing
            frm.SimpleButton2 = Nothing
            frm.GridControl1.Dispose()
            frm.GridControl1 = Nothing
            frm.GridView1.Dispose()
            frm.GridView1 = Nothing
            frm.XtraTabControl1.Dispose()
            frm.XtraTabControl1 = Nothing
            frm.XtraTabPage1.Dispose()
            frm.XtraTabPage1 = Nothing
            frm.Label1.Dispose()
            frm.Label1 = Nothing
            frm.Label2.Dispose()
            frm.Label2 = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub barkod_hesapla()
        Dim miktar = FormatNumber(txt_lMiktar.EditValue, 2)
        Dim x
        Dim kg As String = ""
        Dim gr As String = ""
        If CStr(miktar) <> "" Then
            x = (miktar).indexof(".", 1, (miktar).LENGTH - 1)
            If x = -1 Then
                kg = 1
            Else
                kg = (miktar).substring(0, x)
                gr = (miktar).substring((x + 1), (miktar).LENGTH - (x + 1))
                If IsNumeric(miktar) Then
                Else
                End If
            End If
        End If
        kg = columnuzunlukinteger_sifir(kg, sBarcodeStd_KG)
        gr = columnuzunlukinteger_sifir(gr, sBarcodeStd_GR).ToString
        If status = True Then
            dr = Dataset1.Tables(0).Rows(0)
            'dr.BeginEdit()
            dr("lMiktar") = txt_lMiktar.EditValue
            dr("sBarkodex") = sBarcodeStd + Microsoft.VisualBasic.Left(dr("sBarkod"), 5) + kg + gr '+ "0"
            dr("lBrutTutar1") = dr("lBrutFiyat1") * dr("lMiktar")
            dr("lBrutTutar2") = dr("lBrutFiyat2") * dr("lMiktar")
            dr.EndEdit()
            'dr = DataSet1.Tables(0).Rows(0)
            'miktar = dr("BARCODEX")
            ''MsgBox(miktar)
            'Dim sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12, sayi13
            'sayi1 = sayi_kontrol((miktar).substring(0, 1))
            'sayi2 = sayi_kontrol((miktar).substring(1, 1))
            'sayi3 = sayi_kontrol((miktar).substring(2, 1))
            'sayi4 = sayi_kontrol((miktar).substring(3, 1))
            'sayi5 = sayi_kontrol((miktar).substring(4, 1))
            'sayi6 = sayi_kontrol((miktar).substring(5, 1))
            'sayi7 = sayi_kontrol((miktar).substring(6, 1))
            'sayi8 = sayi_kontrol((miktar).substring(7, 1))
            'sayi9 = sayi_kontrol((miktar).substring(8, 1))
            'sayi10 = sayi_kontrol((miktar).substring(9, 1))
            'sayi11 = sayi_kontrol((miktar).substring(10, 1))
            'sayi12 = sayi_kontrol((miktar).substring(11, 1))
            'sayi13 = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 + sayi10 + sayi11 + sayi12
            ''Label11.Text = sayi13
        End If
    End Sub
    Private Function mode(ByVal deger As Integer, Optional ByVal kontrol As Integer = 10) As Integer
        If deger > kontrol Then
            deger = -kontrol
        End If
        Return deger
    End Function
    Private Function sayi_kontrol(ByVal deger As String) As Integer
        deger = CType(deger, Integer)
        If deger = 1 Then
            deger = deger * 3
        ElseIf deger = 3 Then
            deger = deger * 3
        ElseIf deger = 5 Then
            deger = deger * 3
        ElseIf deger = 7 Then
            deger = deger * 3
        ElseIf deger = 9 Then
            deger = deger * 3
        Else
            deger = deger * 1
        End If
        Return deger
    End Function
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        print(0)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        print(1)
    End Sub
End Class